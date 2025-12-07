namespace D04PrintingDepartment.Tests;

public class GridCalculator_CountAccessibleRolls
{
    [Fact]
    public void Returns0()
    {
        new GridCalculator().CountAccessibleRolls([ "." ]).Should().Be(0);
    }
}
