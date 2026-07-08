namespace WakingSkeleton.Test;

public class OrderTests
{
    [Test]
    public void TotalExcludingShippingCalculation_GivenAnOrderContainingASingleProduct_ReturnsCorrectTotal()
    {
        Assert.AreEqual(159.95m, Order.TotalExcludingShipping());
    }
}