namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage.GivenSingleBank;

public class AndTwoBatteries
{
    [Fact]
    public void When12_returns12()
    {
        Lobby.CalculateTotalJoltage(["12"]).Should().Be(12);
    }

    [Fact]
    public void When32_returns32()
    {
        Lobby.CalculateTotalJoltage(["32"]).Should().Be(32);
    }

    [Fact]
    public void When52_returns52()
    {
        Lobby.CalculateTotalJoltage(["52"]).Should().Be(52);
    }
}
