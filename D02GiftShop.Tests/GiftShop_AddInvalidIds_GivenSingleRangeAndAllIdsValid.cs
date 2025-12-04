namespace D02GiftShop.Tests;

public class GiftShop_AddInvalidIds_GivenSingleRangeAndAllIdsValid
{
    [Fact]
    public void WhenSingleNumber_Returns0()
    {
        GiftShop.AddInvalidIds(["1-1"]).Should().Be(0);
    }
}
