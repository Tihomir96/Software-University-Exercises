using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using Microsoft.EntityFrameworkCore.Storage;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;

namespace BillsPaymentSystemStartUp
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BillsPaymentSystemContext())
            {
                db.Database.EnsureCreated();
                // Seed(db);
                //UserDetails(db);
            }
        }

        private static void UserDetails(BillsPaymentSystemContext db)
        {
            var userId = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            using (db)
            {
                var user = db.Users.Where(u => u.UserId == userId)
                    .Select(u => new
                    {
                        Name = $"{u.FirstName} {u.LastName}",
                        CreditCards = u.PaymentMethods
                            .Where(x => x.Type == PaymentMethodType.CreditCard)
                            .Select(x => x.CreditCard)
                            .ToArray(),
                        BankAccounts = u.PaymentMethods
                            .Where(x => x.Type == PaymentMethodType.BankAccount)
                            .Select(x => x.BankAccount)
                            .ToArray()
                    }).FirstOrDefault();
                sb.AppendLine($"User: {user.Name}");
                
                if (user.BankAccounts.Any())
                {
                    sb.AppendLine("Bank Accounts:");
                    foreach (var bankAccount in user.BankAccounts)
                    {
                        sb.AppendLine($"-- ID: {bankAccount.BankAccountId}");
                        sb.AppendLine($"--- Balance: {bankAccount.Balance:f2}");
                        sb.AppendLine($"--- Bank: {bankAccount.BankName}");
                        sb.AppendLine($"--- {bankAccount.SwiftCode}");
                    }
                }

                if (user.CreditCards.Any())
                {
                    sb.AppendLine($" Credit Cards:");
                    foreach (var cc in user.CreditCards)
                    {
                        sb.AppendLine($"--ID: {cc.CreditCardId}");
                        sb.AppendLine($"--- Limit: {cc.Limit}");
                        sb.AppendLine($"--- Money Owed: {cc.MoneyOwed}");
                        sb.AppendLine($"--- Limit Left:: {cc.LimitLeft}");
                        sb.AppendLine($"--- Expiration Date: {cc.ExpirationDate.ToString("yyyy/MM",CultureInfo.InvariantCulture)}");
                    }
                }
                Console.WriteLine(sb.ToString().Trim());
            }
        }

        private static void Seed(BillsPaymentSystemContext db)
        {
            using (db)
            {
                var user = new User()
                {
                    FirstName = "FrNa",
                    LastName = "LaNa",
                    Email = "nqkuvTup@email.com",
                    Password = "superSecurityPass"
                };
                db.Users.Add(user);
                var bankaccount = new BankAccount()
                {
                    Balance = 3m,
                    BankName = "Nashata Bank (Back to Soca)",
                    SwiftCode = "SocaStyle"
                };
                db.BankAccounts.Add(bankaccount);
                var crediCards = new CreditCard[]
                {
                    new CreditCard()
                    {
                        ExpirationDate = DateTime.ParseExact("20.05.2020","dd.MM.yyyy",null),
                        Limit = 53443423422m,
                        MoneyOwed = 31231123123m
                    },
                    new CreditCard()
                    {
                        ExpirationDate = DateTime.ParseExact("17.05.2099","dd.MM.yyyy",null),
                        Limit = 5344342m,
                        MoneyOwed =3123m
                    }
                };
                db.CreditCards.AddRange(crediCards);
                var paymentMethods = new PaymentMethod[]
                {
                    new PaymentMethod()
                    {
                        User = user,
                        CreditCard = crediCards[0],
                        Type = PaymentMethodType.BankAccount,
                    },
                    new PaymentMethod()
                    {
                        User = user,
                        CreditCard = crediCards[1],
                        Type = PaymentMethodType.CreditCard,
                    },
                };
                db.PaymentMethods.AddRange(paymentMethods);
                db.SaveChanges();
            }
            
        }

    }
}
