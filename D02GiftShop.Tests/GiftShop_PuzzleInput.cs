using D02GiftShop;

namespace D01SecretEntrance;

public class GiftShop_PuzzleInput
{
    // [Fact(Skip = "not implemented yet")]
    [Fact]
    public void Returns()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        var ranges = input[0].Split(',').Select(x => x.Trim());
        var actual = GiftShop.AddInvalidIds(ranges);
        actual.Should().Be(38158151648UL);
    }
}
