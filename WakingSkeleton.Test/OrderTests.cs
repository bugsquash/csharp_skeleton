using WakingSkeleton.Library;

namespace WakingSkeleton.Test;

public class OrderTests
{
    [Test]
    public void TotalExcludingShippingCalculation_GivenAnOrderContainingASingleProduct_ReturnsCorrectTotal()
    {
        Product product = new()
        {
            Id = 327,
            Description = "Ibanez Tube Screamer",
            Price = 159.95m
        };

        LineItem lineItem = new()
        {
            Product = product,
            Quantity = 1
        };

        Order order = new();
        order.LineItems.Add(lineItem);

        Assert.AreEqual(159.95m, order.TotalExcludingShipping());
    }
}