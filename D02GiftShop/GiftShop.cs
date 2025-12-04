namespace D02GiftShop;

public class GiftShop
{
    public static ulong AddInvalidIds(IEnumerable<string> ranges)
    {
        var sum = 0UL;

        foreach (var range in ranges)
        {
            var rangeLimits = range.Split('-');

            var left = ulong.Parse(rangeLimits[0]);
            var right = ulong.Parse(rangeLimits[1]);

            for (var number = left; number <= right; number++)
            {
                if (IsInvalidId(number))
                {
                    sum += number;
                }
            }
        }
        return sum;
    }

    private static bool IsInvalidId(ulong number)
    {
        var numberAsString = number.ToString();
        var length = numberAsString.Length;

        if (length < 2)
        {
            return false;
        }

        for (var chunkSize = 1; chunkSize <= length / 2; chunkSize++)
        {
            var isMatch = true;
            var pattern = numberAsString.Substring(0, chunkSize);
            var comparisonStart = chunkSize;
            while (isMatch && (comparisonStart + chunkSize <= length))
            {
                var comparison = numberAsString.Substring(comparisonStart, chunkSize);
                isMatch = isMatch && (comparison == pattern);
                comparisonStart += chunkSize;
            }

            if (isMatch)
            {
                return true;
            }
        }

        return false;
    }
}
