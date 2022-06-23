namespace Bookshop.Classes
{
    public class Order
    {
        public int orderId { get; set; }
        public int totalPrice { get; set; }
        public Customer customer { get; set; }

        public Order() { }

        public Order(int orderId)
        {
            this.orderId = orderId;
        }

        public Order(int orderId, int totalPrice)
        {
            this.orderId = orderId;
            this.totalPrice = totalPrice;
        }
    }
}
