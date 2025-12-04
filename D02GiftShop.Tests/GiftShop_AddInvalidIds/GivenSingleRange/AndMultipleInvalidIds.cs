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
    public void When90To1200_Returns99Plus1010Plus1111()
    {
        GiftShop.AddInvalidIds(["90-1200"]).Should().Be(99 + 1010 + 1111);
    }
}
