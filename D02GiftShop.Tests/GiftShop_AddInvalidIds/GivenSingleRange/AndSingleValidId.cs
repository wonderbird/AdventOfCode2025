namespace D02GiftShop.Tests.GiftShop_AddInvalidIds.GivenSingleRange;

public class AndSingleValidId
{
    [Fact]
    public void When1_Returns0()
    {
        GiftShop.AddInvalidIds(["1-1"]).Should().Be(0);
    }
}
