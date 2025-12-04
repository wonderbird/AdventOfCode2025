namespace D02GiftShop;

public class GiftShop_PuzzleInput
{
    // Too High: 1134489814339UL
    // [Fact(Skip = "not implemented yet")]
    [Fact]
    public void Returns()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        var ranges = input[0].Split(',').Select(x => x.Trim());
        var actual = GiftShop.AddInvalidIds(ranges);
        actual.Should().Be(45283684555UL);
    }
}
