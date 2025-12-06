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

    public int CalculateTotalJoltage(IEnumerable<string> banks, int numberOfActiveBatteries)
    {
        var sum = 0;

        foreach (var bankString in banks)
        {
            var bank = bankString.Select(x => x - '0').ToList();
            var joltage = CalculateJoltageOfBank(bank, numberOfActiveBatteries);
            sum += joltage;

            _logger.LogInformation("{Bank} => {JoltageOfBank}", bankString, joltage);
        }

        return sum;
    }

    public static int CalculateJoltageOfBank(List<int> bank, int numberOfActiveBatteries)
    {
        var joltages = FindLargestJoltages(bank, numberOfActiveBatteries);
        return ConvertToInt(joltages);
    }

    private static IEnumerable<int> FindLargestJoltages(List<int> bank, int numberOfActiveBatteries)
    {
        var (joltage, index) = FindMaximum(bank);

        if (numberOfActiveBatteries == 1)
        {
            return [joltage];
        }

        if (index == bank.Count - 1)
        {
            var slice = bank.Slice(0, bank.Count - 1);
            var left = FindLargestJoltages(slice, numberOfActiveBatteries - 1);
            return [..left, joltage];
        }
        else
        {
            var slice = bank.Slice(index + 1, bank.Count - 1 - index);
            var right = FindLargestJoltages(slice, numberOfActiveBatteries - 1);
            return [joltage, ..right];
        }
    }

    private static (int joltage, int index) FindMaximum(List<int> bank)
    {
        var joltage = bank.Max();

        var index = bank.IndexOf(joltage);

        return (joltage, index);
    }

    private static int ConvertToInt(IEnumerable<int> joltages)
    {
        var bankJoltageAsString = string.Join("", joltages);
        return int.Parse(bankJoltageAsString);
    }
}