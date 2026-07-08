namespace WakingSkeleton.Library
{
    public class Order
    {
        public List<LineItem>? LineItems { get; set; }

        public decimal TotalExcludingShipping()
        {
            return 159.95m;
        }

        public Order()
        {
            LineItems = new List<LineItem>();
        }
    }

    public class LineItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}