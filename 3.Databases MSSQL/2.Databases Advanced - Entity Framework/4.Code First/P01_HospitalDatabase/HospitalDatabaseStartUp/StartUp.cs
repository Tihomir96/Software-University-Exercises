using System;
using P01_HospitalDatabase.Data;
namespace HospitalDatabaseStartUp
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new HospitalContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
