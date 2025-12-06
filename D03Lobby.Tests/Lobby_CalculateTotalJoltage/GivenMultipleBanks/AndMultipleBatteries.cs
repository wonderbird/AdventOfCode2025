namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage.GivenMultipleBanks;

public class AndMultipleBatteries
{
    [Fact]
    public void Test()
    {
        IEnumerable<string> banks = ["123", "591"];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(23 + 91);
    }
}