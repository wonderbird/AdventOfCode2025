
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
                var numberAsString = number.ToString();
                var length = numberAsString.Length;
                var leftHalf = numberAsString.Substring(0, length / 2);
                var rightHalf = numberAsString.Substring(length / 2);

                if (leftHalf == rightHalf)
                {
                    sum += number;
                }
            }
        }
        return sum;
    }
}
