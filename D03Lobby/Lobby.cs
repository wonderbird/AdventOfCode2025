
using System.Numerics;

namespace D03Lobby;

public class Lobby
{
    public static int CalculateTotalJoltage(string bank)
    {
        var unsorted = bank.Select(x => x - '0').ToList();
        var sorted = unsorted.OrderByDescending(x => x).ToList();

        var first = sorted[0];
        var second = sorted[1];

        var indexOfFirst = unsorted.FindIndex(x => x == first);
        var indexOfSecond = unsorted.FindIndex(x => x == second);

        if (indexOfFirst < indexOfSecond)
        {
            return 10 * first + second;
        }
        else
        {
            return 10 * second + first;
        }
    }
}
