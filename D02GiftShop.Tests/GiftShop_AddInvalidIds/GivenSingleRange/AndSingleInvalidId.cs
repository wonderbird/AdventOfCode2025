namespace D02GiftShop.Tests.GiftShop_AddInvalidIds.GivenSingleRange;

public class AndSingleInvalidId
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

    [Fact]
    public void When1313_Returns1313()
    {
        GiftShop.AddInvalidIds(["1313-1313"]).Should().Be(1313);
    }

    [Fact]
    public void When10To11_Returns11()
    {
        GiftShop.AddInvalidIds(["10-11"]).Should().Be(11);
    }

    [Fact]
    public void When20To30_Returns22()
    {
        GiftShop.AddInvalidIds(["20-30"]).Should().Be(22);
    }
}
