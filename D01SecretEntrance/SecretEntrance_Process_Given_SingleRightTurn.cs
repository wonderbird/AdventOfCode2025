namespace D01SecretEntrance;

public class SecretEntrance_Process_Given_SingleRightTurn
{
    [Fact]
    public void WhenNotPointingAt0_Returns0()
    {
        var actual = SecretEntrance.Process(["R0"]);
        actual.Should().Be(0);
    }

    [Fact]
    public void WhenPointingAt0_Returns1()
    {
        var actual = SecretEntrance.Process(["R50"]);
        actual.Should().Be(1);
    }
}
