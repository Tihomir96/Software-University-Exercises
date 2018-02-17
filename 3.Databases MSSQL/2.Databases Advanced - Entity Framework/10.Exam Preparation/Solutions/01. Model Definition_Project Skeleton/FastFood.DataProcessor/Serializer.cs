using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using FastFood.Data;
using FastFood.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FastFood.DataProcessor
{
	public class Serializer
	{
		public static string ExportOrdersByEmployee(FastFoodDbContext context, string employeeName, string orderType)
		{
		    //var employee = context.Employees.Include(x=>x.Orders.Where(y=>y.Type == Enum.Parse<OrderType>(orderType))).ThenInclude(x=>x.OrderItems).ThenInclude(x=>x.Item)
      //          .FirstOrDefault(x => x.Name == employeeName);

      //      string jsonString = JsonConvert.SerializeObject(employee, Formatting.Indented);

		    //return jsonString;
		    return null;
		}

		public static string ExportCategoryStatistics(FastFoodDbContext context, string categoriesString)
		{
			throw new NotImplementedException();
		}
	}
}