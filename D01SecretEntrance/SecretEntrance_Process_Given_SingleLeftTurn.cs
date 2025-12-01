namespace D01SecretEntrance;

public class SecretEntrance_Process_Given_SingleLeftTurn
{
    [Fact]
    public void WhenNotPointingAt0_Returns0()
    {
        var actual = SecretEntrance.Process(["L0"]);
        actual.Should().Be(0);
    }

    [Fact]
    public void WhenPointingAt0_Returns1()
    {
        var actual = SecretEntrance.Process(["L50"]);
        actual.Should().Be(1);
    }
}
