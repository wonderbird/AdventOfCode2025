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

        foreach (var bank in banks)
        {
            var joltageOfBank = CalculateJoltageOfBank(bank, numberOfActiveBatteries);

            sum += joltageOfBank;

            _logger.LogInformation("{Bank} => {JoltageOfBank}", bank, joltageOfBank);
        }

        return sum;
    }

    public static int CalculateJoltageOfBank(string bank, int numberOfActiveBatteries)
    {
        var unsorted = bank.Select(x => x - '0').ToList();
        
        if (numberOfActiveBatteries == 1)
        {
            return FindLargestJoltage(unsorted).joltage;
        }
        
        var sizeOfBank = bank.Length;
        var (joltage, index) = FindLargestJoltage(unsorted);

        var first = 0;
        var second = 0;
        if (index == sizeOfBank - 1)
        {
            second = joltage;
            (joltage, _) = FindLargestJoltage(unsorted.Slice(0, index));
            first = joltage;
        }
        else
        {
            first = joltage;
            (joltage, _) = FindLargestJoltage(unsorted.Slice(index + 1, sizeOfBank - index - 1));
            second = joltage;
        }

        var joltageOfBank = first * 10 + second;
        return joltageOfBank;
    }

    private static (int joltage, int index) FindLargestJoltage(List<int> unsortedSubset)
    {
        var sortedSubset = unsortedSubset.OrderByDescending(x => x).ToList();
        var joltage = sortedSubset[0];

        var index = unsortedSubset.IndexOf(joltage);

        return (joltage, index);
    }
}
