namespace D02GiftShop.Tests.GiftShop_AddInvalidIds.GivenMultipleRanges;

public class AndSingleInvalidId
{
    [Fact]
    public void When12To20And90To100_Returns0Plus99()
    {
        GiftShop.AddInvalidIds(["12-20", "90-100"]).Should().Be(0 + 99);
    }
}
