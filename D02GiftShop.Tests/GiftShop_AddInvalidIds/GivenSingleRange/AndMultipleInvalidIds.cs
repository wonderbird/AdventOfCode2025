namespace D02GiftShop.Tests.GiftShop_AddInvalidIds.GivenSingleRange;

public class AndMultipleInvalidIds
{
    [Fact]
    public void When10To30_Returns11Plus22()
    {
        GiftShop.AddInvalidIds(["10-30"]).Should().Be(11 + 22);
    }

    [Fact]
    public void When10To40_Returns11Plus22Plus33()
    {
        GiftShop.AddInvalidIds(["10-40"]).Should().Be(11 + 22 + 33);
    }

    [Fact]
    public void When90To1200_Returns99Plus111Plus222Plus333Plus444Plus555Plus666Plus777Plus888Plus999Plus1010Plus1111()
    {
        GiftShop.AddInvalidIds(["90-1200"]).Should().Be(99 + 111 + 222 + 333 + 444 + 555 + 666 + 777 + 888 + 999 + 1010 + 1111);
    }
}
