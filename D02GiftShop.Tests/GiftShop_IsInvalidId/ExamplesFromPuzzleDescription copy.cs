namespace D02GiftShop.Tests.GiftShop_IsInvalidId;

public class WhenSpecialValidId
{
    [Theory]
    [InlineData(101UL)]
    [InlineData(10101UL)]
    public void ReturnsFalse(ulong candidate)
    {
        GiftShop.IsInvalidId(candidate).Should().Be(false);
    }
}