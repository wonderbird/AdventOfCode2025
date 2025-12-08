namespace D04PrintingDepartment.Tests.GridCalculator.CountAccessibleRolls;

public class GivenSingleRow
{
    [Fact]
    public void Returns0()
    {
        new D04PrintingDepartment.GridCalculator(["."]).AccessibleRolls.Should().Be(0);
    }

    [Fact]
    public void GivenSingleRoll_Returs1()
    {
        new D04PrintingDepartment.GridCalculator(["@"]).AccessibleRolls.Should().Be(1);
    }
}