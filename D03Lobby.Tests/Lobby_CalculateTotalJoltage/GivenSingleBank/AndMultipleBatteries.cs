namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage.GivenSingleBank;

public class AndMultipleBatteries
{
    [Fact]
    public void When123_returns123()
    {
        Lobby.CalculateTotalJoltage(["123"]).Should().Be(23);
    }
}
