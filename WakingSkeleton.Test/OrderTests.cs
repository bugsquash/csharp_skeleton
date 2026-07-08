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
            ProductId = product.Id,
            Quantity = 1,
            Price = product.Price
        };

        Order order = new();
        order.LineItems.Add(lineItem);

        Assert.AreEqual(159.95m, order.TotalExcludingShipping());
    }
}