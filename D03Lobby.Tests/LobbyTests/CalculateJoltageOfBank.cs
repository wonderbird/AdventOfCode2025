namespace D03Lobby.Tests.LobbyTests;

public class CalculateJoltageOfBank
{
    [Fact]
    public void Test()
    {
        Lobby.CalculateJoltageOfBank([1], 1).Should().Be(1);
    }
}