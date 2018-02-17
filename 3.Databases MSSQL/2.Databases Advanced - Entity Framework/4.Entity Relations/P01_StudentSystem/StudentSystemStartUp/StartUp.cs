using System;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;

namespace StudentSystemStartUp
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new StudentSystemContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
