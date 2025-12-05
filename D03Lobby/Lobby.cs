using System.Numerics;

namespace D03Lobby;

public class Lobby
{
    public static int CalculateTotalJoltage(IEnumerable<string> banks)
    {
        var sum = 0;

        // Refactor:
        // If the battery with maximum joltage is not the last battery in the bank, then it must always be the 10x digit.
        foreach (var bank in banks)
        {
            var unsorted = bank.Select(x => x - '0').ToList();
            var sorted = unsorted.OrderByDescending(x => x).ToList();

            var larger = sorted[0];
            var lower = sorted[1];

            var indexOfLarger = unsorted.IndexOf(larger);
            var indexOfLower = unsorted.LastIndexOf(lower);
            var candidate = 0;
            if (indexOfLarger < indexOfLower)
            {
                candidate = 10 * larger + lower;
            }
            else
            {
                candidate = 10 * lower + larger;
            }
            
            var length = bank.Length;
            if (indexOfLarger < length - 1 && larger * 10 > candidate)
            {
                var subsetStart = indexOfLarger + 1;
                var subsetLength = length - subsetStart;
                var unsortedSubset = unsorted.Slice(subsetStart, subsetLength);
                var sortedSubset = unsortedSubset.OrderByDescending(x => x).ToList();
                var largestInSubset = sortedSubset[0];
                candidate = 10 * larger + largestInSubset;
            }

            sum += candidate;
        }

        return sum;
    }
}