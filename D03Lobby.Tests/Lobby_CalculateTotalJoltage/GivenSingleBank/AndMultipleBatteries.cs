namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage.GivenSingleBank;

public class AndMultipleBatteries
{
    [Fact]
    public void When123_returns23()
    {
        Lobby.CalculateTotalJoltage(["123"]).Should().Be(23);
    }
    
    [Fact]
    public void When121_returns21()
    {
        Lobby.CalculateTotalJoltage(["121"]).Should().Be(21);
    }
    
    [Fact]
    public void When571_returns71()
    {
        Lobby.CalculateTotalJoltage(["571"]).Should().Be(71);
    }
}
