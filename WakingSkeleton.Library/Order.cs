using System.ComponentModel.DataAnnotations;

namespace WakingSkeleton.Library
{
    public class Order
    {
        [Required]
        public List<LineItem> LineItems { get; set; }

        public decimal TotalExcludingShipping()
        {
            return LineItems.Sum(x => x.Product.Price * x.Quantity);
        }

        public Order()
        {
            LineItems = new List<LineItem>();
        }
    }

    public class LineItem
    {
        public Product? Product { get; set; }
        public int Quantity { get; set; }
    }
}