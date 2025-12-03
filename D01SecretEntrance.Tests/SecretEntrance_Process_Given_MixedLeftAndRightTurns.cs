namespace D01SecretEntrance;

public class SecretEntrance_Process_Given_MixedLeftAndRightTurns
{
    [Fact]
    public void WhenLeftGoesNegativeAndRightReaches0_Returns2()
    {
        var actual = SecretEntrance.Process(["L75", "R25"]);
        actual.Should().Be(2);
    }

    [Fact]
    public void AoCExampleSubset3Turns_Returns2()
    {
        var actual = SecretEntrance.Process(["L68", "L30", "R48"]);
        actual.Should().Be(2);
    }

    [Fact]
    public void AoCExampleSubset4Turns_Returns2()
    {
        var actual = SecretEntrance.Process(["L68", "L30", "R48", "L5"]);
        actual.Should().Be(2);
    }
}
