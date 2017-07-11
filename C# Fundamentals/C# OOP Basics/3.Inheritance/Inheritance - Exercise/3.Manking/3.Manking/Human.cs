﻿using System;
using System.Linq;

namespace _3.Manking
{
    public class Human
    {
        private string firstName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (char.IsLower(value.First()))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }                
                this.firstName = value;
            }
        }
        
        private string lastName;

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (char.IsLower(value.First()))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                this.lastName = value;
            }
        }



    }
}
