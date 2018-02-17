namespace _5.Border_Control
{
    class Pet:IBreathable
    {
        public string Name { get; }
        public string BirthDate { get; }

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
    }
}
