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

    [Fact]
    public void WhenStoppingAtMinus100_Returns2()
    {
        var actual = SecretEntrance.Process(["L150"]);
        actual.Should().Be(2);
    }

    [Fact]
    public void WhenStoppingAtMinus350_Returns4()
    {
        var actual = SecretEntrance.Process(["L400"]);
        actual.Should().Be(4);
    }
}
