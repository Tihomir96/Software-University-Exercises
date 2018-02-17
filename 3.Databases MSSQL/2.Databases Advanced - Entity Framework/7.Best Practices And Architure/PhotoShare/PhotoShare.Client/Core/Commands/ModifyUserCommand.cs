﻿using System.Linq;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class ModifyUserCommand
    {
        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public static string Execute(string[] data)
        {
            var username = data[0];
            var property = data[1];
            var newValue = data[2];

            using (var context= new PhotoShareContext())
            {
                var user = context.Users.Where(x => x.Username == username).FirstOrDefault();
                if (user==null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }
                switch (property.ToLower())
                {
                    case "password":
                        if (!newValue.Any(c => char.IsLower(c)) || !newValue.Any(c => char.IsDigit(c)))
                        {
                            throw new ArgumentException($"Value {newValue} not valid." + Environment.NewLine +"Invalid Password!");
                        }
                        user.Password = newValue;
                        break;
                    case "borntown":

                        var bornTown = context.Towns.Where(x => x.Name == newValue).FirstOrDefault(); 
                        if (bornTown==null)
                        {
                            throw new ArgumentException($"Value {newValue} not valid." + Environment.NewLine + $"Town {newValue} not found!");
                        }
                        user.BornTown = bornTown;
                        break;
                    case "currenttown":
                        var currentTown = context.Towns.Where(x => x.Name == newValue).FirstOrDefault();
                        if (currentTown == null)
                        {
                            throw new ArgumentException($"Town {newValue} not found!");
                        }
                        user.CurrentTown = currentTown;
                        break;               
                    default:
                        throw new ArgumentException($"Property {property} not supported!");
                }
                context.SaveChanges();
                return $"User {username} {property} is {newValue}";
            }
        }
    }
}
