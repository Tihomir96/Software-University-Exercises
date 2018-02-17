using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Newtonsoft.Json;
using ProductsShop.Data;
using ProductsShop.Data.Models;

namespace ProductsShopStartUp
{
    public class Program
    {
        public static void Main()
        {
UsersSoldProductsXml();        }

        static void UsersSoldProductsXml()
        {
            using (var db = new ProductShopContext())
            {
                var users = db.Users.Where(x => x.ProductsSold.Count > 0)
                    .OrderByDescending(x => x.ProductsSold.Count)
                    .ThenBy(x => x.LastName)
                    .Select(x => new
                    {
                        FirstName = x.FirstName == null ? string.Empty : x.FirstName,
                        LastName = x.LastName,
                        Age = x.Age == null ? "unknown" : $"{x.Age}",
                        SoldProductsCount = x.ProductsSold.Count,
                        Products = x.ProductsSold.Select(s => new
                        {
                            ProductName = s.Name,
                            Price = s.Price
                        }).ToArray()
                    }).ToArray();

                var xDoc = new XDocument(new XElement("users",new XAttribute("count", users.Length)));
                foreach (var user in users)
                {
                    xDoc.Root.Add(new XElement("user",
                                    new XAttribute("first-name",user.FirstName),
                                    new XAttribute("last-name",user.LastName),
                                    new XAttribute("age",user.Age)),
                                  new XElement("sold-products", 
                                    new XAttribute("count", user.SoldProductsCount)));

                    foreach (var product in user.Products)
                    {
                        xDoc.Root.Elements("user").Last()
                                   .Add(new XElement("product",
                                        new XAttribute("name",product.ProductName),
                                        new XAttribute("price",product.Price)));
                    }
                }
                var xmlString = xDoc.ToString();
                File.WriteAllText("UsersSoldProducts.xml", xmlString);
            }
        }
        static void CategoriesByProductCountXml()
        {
            using (var db =new ProductShopContext())
            {
                var categories = db.Categories.OrderByDescending(x => x.Products.Count).Select(x => new
                {
                    Name = x.Name,
                    ProductsCount = x.Products.Count,
                    AvgPrice = x.Products.Select(p => p.Product.Price).Average(),
                    TotalRevenue = x.Products.Select(t => t.Product.Price).Sum()
                }).ToArray();
                var xDoc = new XDocument(new XElement("categories"));
                

                foreach (var category in categories)
                {
                    xDoc.Root.Add(new XElement("category",
                                         new XAttribute("name", category.Name),
                                      new XElement("products-count", category.ProductsCount),
                                      new XElement("average-price", category.AvgPrice),
                                      new XElement("total-revenue", category.TotalRevenue)));
                }
                var xmlString = xDoc.ToString();
                File.WriteAllText("CategoriesByProductCount.xml", xmlString);
            }
        }
        static void UsersAndProductsJson()
        {
            using (var db = new ProductShopContext())
            {
                var users = db.Users.OrderByDescending(x => x.ProductsSold.Any(b => b.BuyerId != null))
                    .ThenBy(x => x.LastName)
                    .Select(x => new
                    {
                        firstName = x.FirstName,
                        lastName = x.LastName,
                        age = x.Age,
                        count = x.ProductsSold.Count,
                        soldProducts = x.ProductsSold.Select(ps => new
                        {                            
                            name = ps.Name,
                            price = $"{ps.Price:f2}"
                        }).ToArray()
                    }).ToArray();

                var jsonString = JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore });
                File.WriteAllText("UsersAndProducts,json", jsonString);
            }
        }
        static void CategoriesByProductsJson()
        {
            using (var db=new ProductShopContext())
            {
                var categories = db.Categories.OrderBy(x=>x.Name).Select(x => new
                {
                    category = x.Name,
                    productsCount = x.Products.Count,
                    averagePrice = x.Products.Select(y => y.Product.Price).Average(),
                    totalRevenue = x.Products.Select(p => p.Product.Price).Sum()
                }).ToArray();

                var jsonString = JsonConvert.SerializeObject(categories, Formatting.Indented, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore });
                File.WriteAllText("CategoriesByProduct.json", jsonString);
            }
        }
        static void SoldProductXml()
        {
            using (var db = new ProductShopContext())   
            {
                var users = db.Users.Where(x => x.ProductsSold.Any(y => y.BuyerId != null)).OrderBy(x => x.LastName)
                    .ThenBy(x => x.FirstName == null ? string.Empty : x.FirstName).Select(x => new
                    {
                        x.FirstName,
                        x.LastName,
                        x.ProductsSold,
                    });
                var xDoc = new XDocument(new XElement("users"));
                foreach (var user in users)
                {
                    xDoc.Root.Add(new XElement("user", new XAttribute("first-name", user.FirstName == null ? string.Empty : user.FirstName),
                                                      new XAttribute("last-name", user.LastName),
                        new XElement("sold-products")));

                    
                    foreach (var product in user.ProductsSold)
                    {
                        xDoc.Root.Elements("user").Last().Element("sold-products").Add(new XElement("product",
                                      new XElement("name", product.Name),
                                      new XElement("price", product.Price)));
                    }
                    var xmlString = xDoc.ToString();
                    File.WriteAllText("SoldProduct.xml", xmlString);
                }
            }
        }
        static void ProductsInRange()
        {
            using (var db= new ProductShopContext())
            {
                var products = db.Products.Where(x=>x.BuyerId!=null&& x.Price>=1000 && x.Price<=2000).OrderBy(x=>x.Price).Select(x => new
                {
                    x.Name,
                    x.Price,
                    Buyer = $"{x.Buyer.FirstName} {x.Buyer.LastName}"
                }).ToArray();
                var xDoc = new XDocument(new XElement("products"));
                foreach (var product in products)
                {
                    xDoc.Root.Add(new XElement("product",new XAttribute("name",product.Name),
                                                         new XAttribute("price",product.Price),
                                                         new XAttribute("buyer",product.Buyer)));
                }
                var xmlString = xDoc.ToString();
                File.WriteAllText("ProductsInRange.xml",xmlString);
            }
        }
        static string ImportProductsFromXml()
        {
            var path = "Files/products.xml";
            var xmlString = File.ReadAllText(path);
            var xmlDoc = XDocument.Parse(xmlString);
            var elements = xmlDoc.Root.Elements();
            var catProducts = new List<CategoryProduct>();

            using (var db = new ProductShopContext())
            {
                var userIds = db.Users.Select(x => x.Id).ToArray();
                var categoryIds = db.Categories.Select(x => x.Id).ToArray();

                var rnd = new Random();
                foreach (var element in elements)
                {
                    var name = element.Element("name").Value;
                    var price = decimal.Parse(element.Element("price").Value);
                    var sellerIndex = rnd.Next(0, userIds.Length);
                    var sellerId = userIds[sellerIndex];

                    var product = new Product()
                    {
                        Name = name,
                        Price = price,
                        SellerId = sellerId
                    };
                    int categoryIndex = rnd.Next(0, categoryIds.Length);
                    int categoryId = categoryIds[categoryIndex];
                    var catProduct = new CategoryProduct()
                    {
                        Product = product,
                        CategoryId = categoryId
                    };
                    catProducts.Add(catProduct);
                }
                db.AddRange(catProducts);
                db.SaveChanges();
            }
            return $"{catProducts.Count} categories were imported from {path}";
        }
        static string ImportCategoriesFromXml()
        {
            string path = "Files/categories.xml";
            var xmlString = File.ReadAllText(path);
            var xmlDoc = XDocument.Parse(xmlString);
            var elements = xmlDoc.Root.Elements();
            var categories = new List<Category>();
            foreach (var element in elements)
            {
                var category = new Category()
                {
                    Name = element.Element("name").Value
                };
                categories.Add(category);
            }
            using (var db = new ProductShopContext())
            {
                db.Categories.AddRange(categories);
                db.SaveChanges();
            }
            return $"{categories.Count} categories were imported from {path}";
        }
        static string ImportUsersFromXml()
        {
            string xmlString = File.ReadAllText("Files/users.xml");

            var xmlDoc = XDocument.Parse(xmlString);

            var elements = xmlDoc.Root.Elements();
            var users = new List<User>();
            foreach (var xElement in elements)
            {
                string firstName = xElement.Attribute("firstName")?.Value;
                string lastName = xElement.Attribute("lastName")?.Value;
                int? age = null;
                if (xElement.Attribute("age") != null)
                {
                    age = int.Parse(xElement.Attribute("age").Value);
                }
                var user= new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };
                users.Add(user);
            }
            using (var db= new ProductShopContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
            return $"{users.Count} users were imported from file :Files/users.xml";
        }
        static void SetCategories()
        {
            using (var db = new ProductShopContext())
            {
                var productIds= db.Products.Select(x => x.Id).ToArray();
                var categoriesIds = db.Categories.Select(x => x.Id).ToArray();

                var categoryProducts = new List<CategoryProduct>();
                var rnd = new Random();
                foreach (var product in productIds)
                {
                    int index = -1;
                    for (int i = 0; i < 3; i++)
                    {
                        index = rnd.Next(0, categoriesIds.Length);

                        while (categoryProducts.Any(x=>x.CategoryId==categoriesIds[index]&& x.ProductId==product))
                        {
                            index = rnd.Next(0, categoriesIds.Length);
                        }

                        var catPr = new CategoryProduct()
                        {
                            ProductId = product,
                            CategoryId = categoriesIds[index]
                        };
                        categoryProducts.Add(catPr);
                    }
                }
                db.AddRange(categoryProducts);
                db.SaveChanges();
            }
        }
        static void GetSuccessfullySoldProductsJson()
        {
            using (var db =new ProductShopContext())
            {
                var users = db.Users.Where(x => x.ProductsSold.Any(p => p.BuyerId != null))
                    .OrderBy(x => x.LastName)
                    .ThenBy(x => x.FirstName)
                    .Select(x => new
                    {
                        x.FirstName,
                        x.LastName,
                        SoldProducts= x.ProductsSold.Select(y=>new
                        {
                            y.Name,
                            y.Price,
                            BuyerFirstName =y.Buyer.FirstName,
                            BuyerLastName = y.Buyer.LastName
                        })
                    }).ToArray();
                var jsonString = JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore});
                File.WriteAllText("SuccessfullySoldProducts.json",jsonString);
            }
        }
        static void GetProductsInRange()
        {
            using (var db= new ProductShopContext())
            {
                var products = db.Products
                    .Where(x => x.Price >= 500 && x.Price <= 1000)
                    .OrderBy(x => x.Price)
                    .Select(x => new
                    {
                        x.Name,
                        x.Price,
                        Seller = $"{x.Seller.FirstName} {x.Seller.LastName}"
                    }).ToArray();

                var jsonString = JsonConvert.SerializeObject(products,Formatting.Indented,new JsonSerializerSettings(){DefaultValueHandling = DefaultValueHandling.Ignore});

                File.WriteAllText("PricesInRange.json",jsonString);
            }
        }
        static string ImportProductsFromJson()
        {
            var rnd = new Random();
            
            string path = "Files/products.json";

            var products = ImportJson<Product>(path);

            using (var db = new ProductShopContext())
            {
                var userIds = db.Users.Select(x => x.Id).ToArray();
                foreach (var product in products)
                {
                    var index = rnd.Next(0, userIds.Length);
                    int sellerId = userIds[index];
                    int? buyerId = sellerId;
                    while (buyerId == sellerId)
                    {
                        var buyerIndex = rnd.Next(0, userIds.Length);
                        buyerId = userIds[buyerIndex];
                    }

                    if (buyerId - sellerId < 10 && buyerId - sellerId > 0)
                    {
                        buyerId = null;
                    }

                    product.SellerId = sellerId;
                    product.BuyerId = buyerId;
                }
                db.Products.AddRange(products);
                db.SaveChanges();
            }
            return $"{products.Length} products were were imported from {path}";
        }
        public static string ImportCategoriesFromJson()
        {
            string path = "Files/categories.json";

            Category[] categories = ImportJson<Category>(path);

            using (var db = new ProductShopContext())
            {
                db.Categories.AddRange(categories);
                db.SaveChanges();
            }
            return $"{categories.Length} categories were imported from {path}";
        }
        static string ImportUsersFromJson()
        {
            string path = "Files/users.json";
            User[] users = ImportJson<User>(path);

            using (var db = new ProductShopContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
            return $"{users.Length} users were imported from {path}";
        }
        static T[] ImportJson<T>(string path)
        {
            string jsonString = File.ReadAllText(path);
            T[] objects = JsonConvert.DeserializeObject<T[]>(jsonString);
            return objects;
        }
    }
}
