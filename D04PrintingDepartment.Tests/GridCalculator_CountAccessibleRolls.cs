namespace D04PrintingDepartment.Tests;

public class GridCalculator_CountAccessibleRolls
{
    [Fact]
    public void Returns0()
    {
        new GridCalculator(["."]).AccessibleRolls.Should().Be(0);
    }

    [Fact]
    public void GivenSingleRoll_Returs1()
    {
        new GridCalculator(["@"]).AccessibleRolls.Should().Be(1);
    }

    [Fact]
    public void GivenTestInput_Returns13()
    {
        var input = File.ReadAllLines("Data/ExampleInput.txt");
        new GridCalculator(input).AccessibleRolls.Should().Be(13);
    }

    [Fact]
    public void GivenPuzzleInput_Returns13()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        new GridCalculator(input).AccessibleRolls.Should().Be(1389);
    }
}