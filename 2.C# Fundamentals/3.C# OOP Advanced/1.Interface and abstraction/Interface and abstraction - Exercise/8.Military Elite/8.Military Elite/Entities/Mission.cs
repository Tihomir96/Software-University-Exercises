﻿

using _8.Military_Elite.Interfaces;

namespace _8.Military_Elite.Entities
{
    public class Mission:IMission
    {
        public Mission(string name, string state)
        {
            this.Name = name;
            this.State = state;
        }
        public string Name { get; private set; }
        public string State { get; private set; }
        public override string ToString()
        {
            return $"Code Name: {this.Name} State: {this.State}";
        }
    }
}
