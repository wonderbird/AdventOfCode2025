using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace D03Lobby;

public class Lobby
{
    private readonly ILogger _logger;

    public Lobby(ILoggerFactory? loggerFactory = null)
    {
        if (loggerFactory != null)
        {
            _logger = loggerFactory.CreateLogger("Lobby");
        }
        else
        {
            _logger = NullLogger.Instance;
        }
    }

    public ulong CalculateTotalJoltage(IEnumerable<string> banks, int numberOfActiveBatteries)
    {
        var sum = 0UL;

        foreach (var bankString in banks)
        {
            var bank = bankString.Select(x => x - '0').ToList();
            var joltage = CalculateJoltageOfBank(bank, numberOfActiveBatteries);
            sum += joltage;

            _logger.LogInformation("{Bank} => {JoltageOfBank}", bankString, joltage);
        }

        return sum;
    }

    public ulong CalculateJoltageOfBank(List<int> bank, int numberOfActiveBatteries)
    {
        _logger.LogInformation("Processing {Bank}", bank);
        var joltages = FindLargestJoltages(bank, numberOfActiveBatteries);
        return ConvertToNumber(joltages);
    }

    private static IEnumerable<int> FindLargestJoltages(List<int> bank, int numberOfActiveBatteries)
    {
        // If there are exactly as many batteries as needed, then
        // all batteries are returned in order
        if (bank.Count == numberOfActiveBatteries)
        {
            return bank;
        }

        // We have more batteries than needed
        if (numberOfActiveBatteries == 1)
        {
            return [FindMaximum(bank).joltage];
        }

        // We have more batteries than needed
        // We need more than one battery
        // Thus, select the strongest from the left
        var options = bank.Slice(0, bank.Count - numberOfActiveBatteries + 1);
        var (joltage, index) = FindMaximum(options);

        // Find the remaining batteries right from the strongest
        var remainder = bank.Slice(index + 1, bank.Count - 1 - index);
        var right = FindLargestJoltages(remainder, numberOfActiveBatteries - 1);

        return [joltage, ..right];
    }

    private static (int joltage, int index) FindMaximum(List<int> bank)
    {
        var joltage = bank.Max();

        var index = bank.IndexOf(joltage);

        return (joltage, index);
    }

    private static ulong ConvertToNumber(IEnumerable<int> joltages)
    {
        var bankJoltageAsString = string.Join("", joltages);
        return ulong.Parse(bankJoltageAsString);
    }
}