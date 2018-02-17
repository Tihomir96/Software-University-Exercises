namespace _5.Border_Control
{
    public class Robot:IIdentifiable
    {
        public string id { get; }

        public string Model { get; set; }

        public Robot( string model,string id)
        {
            this.id = id;
            this.Model = model;
        }
    }
}
