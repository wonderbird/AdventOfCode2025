namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage.GivenSingleBank;

public class AndMultipleBatteries
{
    [Fact]
    public void When123_returns23()
    {
        IEnumerable<string> banks = ["123"];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(23);
    }
    
    [Fact]
    public void When121_returns21()
    {
        IEnumerable<string> banks = ["121"];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(21);
    }
    
    [Fact]
    public void When571_returns71()
    {
        IEnumerable<string> banks = ["571"];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(71);
    }
}
