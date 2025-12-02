namespace D01SecretEntrance;

public class SecretEntrance_Process_Given_TwoRightTurns
{
    [Fact]
    public void WhenSecondPointsAt0_Returns1()
    {
        var actual = SecretEntrance.Process(["R25", "R25"]);
        actual.Should().Be(1);
    }

    [Fact]
    public void WhenBothPointAt0_Returns2()
    {
        var actual = SecretEntrance.Process(["R50", "R100"]);
        actual.Should().Be(2);
    }

    [Fact]
    public void WhenFirstPointsAt0AndSecondCrosses0_Returns2()
    {
        var actual = SecretEntrance.Process(["R50", "R101"]);
        actual.Should().Be(2);
    }
}