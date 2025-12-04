namespace D02GiftShop.Tests;

public class GiftShop_AddInvalidIds_GivenSingleRangeAndInvalidNumbers
{
    [Fact]
    public void When11_Returns11()
    {
        GiftShop.AddInvalidIds(["11-11"]).Should().Be(11);
    }

    [Fact]
    public void When22_Returns22()
    {
        GiftShop.AddInvalidIds(["22-22"]).Should().Be(22);
    }

    [Fact]
    public void When33_Returns33()
    {
        GiftShop.AddInvalidIds(["33-33"]).Should().Be(33);
    }

}
