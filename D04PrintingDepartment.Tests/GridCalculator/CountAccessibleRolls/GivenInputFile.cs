namespace D04PrintingDepartment.Tests.GridCalculator.CountAccessibleRolls;

public class GivenInputFile
{
    [Theory]
    [InlineData("ExampleInput.txt", 13)]
    [InlineData("PuzzleInput.txt", 1389)]
    [InlineData("OnlyOneRemovalStepPossible.txt", 1)]
    public void WhenFileName_ReturnsExpected(string fileName, int expected)
    {
        var path = Path.Combine("Data", fileName);
        var input = File.ReadAllLines(path);
        new D04PrintingDepartment.GridCalculator(input).AccessibleRolls.Should().Be(expected);
    }
}