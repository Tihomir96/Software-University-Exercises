
using P03_FootballBetting.Data;

namespace FootballBettingStartUp
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new FootballBettingContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
