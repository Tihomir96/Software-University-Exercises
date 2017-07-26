
namespace _3.Wild_Farm
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
