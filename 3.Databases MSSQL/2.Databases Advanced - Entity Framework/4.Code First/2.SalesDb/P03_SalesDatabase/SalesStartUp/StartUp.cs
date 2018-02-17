using System;
using Microsoft.EntityFrameworkCore.Storage;
using P03_SalesDatabase.Data.Models;

namespace SalesStartUp
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new SaleContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
