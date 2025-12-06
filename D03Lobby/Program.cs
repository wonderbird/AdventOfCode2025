using D03Lobby;
using Microsoft.Extensions.Logging;

using var factory = LoggerFactory .Create(builder => builder.AddConsole());
var logger = factory.CreateLogger("Program");

var input = File.ReadAllLines("../../../../D03Lobby.Tests/bin/Debug/net9.0/Data/PuzzleInput.txt");
var sum = new Lobby(factory).CalculateTotalJoltage(input, 2);
logger.LogInformation("Sum: {Sum}", sum);