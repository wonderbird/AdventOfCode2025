namespace D02GiftShop.Tests.GiftShop_IsInvalidId;

public class ExamplesFromPuzzleDescription
{
    [Theory]
    [InlineData(1010UL)]
    [InlineData(565656UL)]
    [InlineData(824824824UL)]
    [InlineData(2121212121UL)]
    public void InvalidId(ulong candidate)
    {
        GiftShop.IsInvalidId(candidate).Should().Be(true);
    }
}