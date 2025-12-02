namespace D01SecretEntrance;

public class SecretEntrance_Process_Given_MixedLeftAndRightTurns
{
    [Fact(Skip = "not implemented yet")]
    public void WhenLeftGoesNegativeAndRightReaches0_Returns2()
    {
        var actual = SecretEntrance.Process(["L75", "R25"]);
        actual.Should().Be(2);
    }
}
