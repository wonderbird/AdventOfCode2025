namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage.GivenMultipleBanks;

public class AndMultipleBatteries
{
    [Fact]
    public void Test()
    {
        Lobby.CalculateTotalJoltage(["123", "591"]).Should().Be(23 + 59);
    }
}