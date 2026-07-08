using System.ComponentModel.DataAnnotations;

namespace WakingSkeleton.Library
{
    public class Order
    {
        [Required]
        public List<LineItem> LineItems { get; set; }

        public decimal TotalExcludingShipping()
        {
            return LineItems.Sum(x => x.Price * x.Quantity);
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
        public decimal Price { get; set; }
    }
}