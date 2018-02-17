using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using AutoMapper;
using FastFood.Data;
using FastFood.DataProcessor.Dto.Import;
using FastFood.Models;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using Newtonsoft.Json;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace FastFood.DataProcessor
{
	public static class Deserializer
	{
		private const string FailureMessage = "Invalid data format.";
		private const string SuccessMessage = "Record {0} successfully imported.";

	    public static string ImportEmployees(FastFoodDbContext context, string jsonString)
	    {
	        var sb = new StringBuilder();

	        var deserializedEmployees = JsonConvert.DeserializeObject<EmployeeDto[]>(jsonString, new JsonSerializerSettings()
	        {
	            NullValueHandling = NullValueHandling.Ignore
	        });

	        var employees = new List<Employee>();
	        foreach (var employeeDto in deserializedEmployees)
	        {
	            if (!IsValid(employeeDto))
	            {
	                sb.AppendLine(FailureMessage);
	                continue;
	            }
	            var positionInDb = context.Positions.FirstOrDefault(x => x.Name == employeeDto.Position);
	            if (positionInDb == null)
	            {
	                var position = new Position()
	                {
	                    Name = employeeDto.Position,
	                };
	                context.Positions.Add(position);
	                context.SaveChanges();
	            }

	            var employee = new Employee()
	            {
	                Name = employeeDto.Name,
	                Age = employeeDto.Age,
	                Position = context.Positions.FirstOrDefault(x=>x.Name==employeeDto.Position),
                    PositionId = context.Positions.FirstOrDefault(x => x.Name == employeeDto.Position).Id
                };
	           
	            employees.Add(employee);
	            sb.AppendLine($"Record {employee.Name} successfully imported.");
	        }
            context.Employees.AddRange(employees);
	        context.SaveChanges();
	        return sb.ToString().TrimEnd();
	    }

	    public static string ImportItems(FastFoodDbContext context, string jsonString)
		{
		    var sb = new StringBuilder();

		    var deserializedItems = JsonConvert.DeserializeObject<ItemDto[]>(jsonString, new JsonSerializerSettings()
		    {
		        NullValueHandling = NullValueHandling.Ignore
		    });

		    var items = new List<Item>();
		    foreach (var deserializedItem in deserializedItems)
		    {
		        if (!IsValid(deserializedItem))
		        {
	                sb.AppendLine(FailureMessage);
                    continue;
		        }
		        if (items.Any(x => x.Name == deserializedItem.Name))
		        {
		            sb.AppendLine(FailureMessage);
                    continue;
		        }
		        var categoryInDb = context.Categories.FirstOrDefault(x => x.Name == deserializedItem.Category);
		        if (categoryInDb == null)
		        {
		            var category = new Category()
		            {
		                Name = deserializedItem.Category
		            };
		            context.Categories.Add(category);
		            context.SaveChanges();
		        }
                var item = new Item()
                {
                    Name = deserializedItem.Name,
                    Price = deserializedItem.Price,
                    Category = context.Categories.FirstOrDefault(x=>x.Name==deserializedItem.Category)
                };
                items.Add(item);
		        sb.AppendLine($"Record {item.Name} successfully imported.");
		    }
            context.Items.AddRange(items);
		    context.SaveChanges();
		    return sb.ToString().TrimEnd();

		}

        public static string ImportOrders(FastFoodDbContext context, string xmlString)
		{

		    var sb = new StringBuilder();
		    bool noItems = false;
		    var orders = new List<Order>();
		    
		        var serializer = new XmlSerializer(typeof(OrderDto[]), new XmlRootAttribute("Orders"));
		        var deserializedOrders = (OrderDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

		        foreach (var desOrder in deserializedOrders)
		        {
		            if (!IsValid(desOrder))
		            {
		                sb.AppendLine(FailureMessage);
                        continue;
		            }
		            var datetime = DateTime.ParseExact(desOrder.DateTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
		            var employee = context.Employees.FirstOrDefault(x => x.Name == desOrder.Employee);
		            foreach (var desOrderItem in desOrder.Items)
		            {
		                if (!context.Items.Any(x => x.Name == desOrderItem.Name))
		                {
		                    noItems = true;
		                }
		            }
		            if (datetime== null || employee == null || noItems)
		            {
		                sb.AppendLine(FailureMessage);
                        continue;
		            }
		            var orderItems = new List<OrderItem>();
		            var itemExists = true;
                foreach (var desOrderItem in desOrder.Items)
		            {
		                if (!context.Items.Any(x => x.Name == desOrderItem.Name) )
		                {
		                    itemExists = false;
		                }
		                if (itemExists)
		                {
		                    var orderItem = new OrderItem()
		                    {
		                        Item = context.Items.FirstOrDefault(x => x.Name == desOrderItem.Name),
		                        Quantity = desOrderItem.Quantity
		                    };

		                    orderItems.Add(orderItem);
		                }
		                else
		                {
		                    sb.AppendLine(FailureMessage);
                            continue;
		                }
                }
                    var order = new Order()
                    {
                        Customer = desOrder.Customer,
                        DateTime = datetime,
                        Employee = employee,
                        OrderItems = orderItems
                    };
                    orders.Add(order);
		            var date = string.Format($"{datetime:dd/MM/yyyy HH:mm}",CultureInfo.InvariantCulture);
		            var datestring = datetime.ToString("dd/MM/yyyy HH:mm");
		            sb.AppendLine($"Order for {desOrder.Customer} on {date} added");
		        }
            
		    context.Orders.AddRange(orders);
		    context.SaveChanges();
		    return sb.ToString().TrimEnd();
		}
	    private static bool IsValid(object obj)
	    {
	        var validationContext = new ValidationContext(obj);
	        var validationResults = new List<ValidationResult>();

	        var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
	        return isValid;
	    }
    }
}