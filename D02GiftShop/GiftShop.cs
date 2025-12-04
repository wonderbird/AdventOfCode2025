
namespace D02GiftShop;

public class GiftShop
{
    public static int AddInvalidIds(IEnumerable<string> ranges)
    {
        var range = ranges.First();
        var rangeLimits = range.Split('-');
        
        var left = int.Parse(rangeLimits[0]);
        var right = int.Parse(rangeLimits[1]);

        for (var number = left; number <= right; number++)
        {
            var numberAsString = number.ToString();
            var length = numberAsString.Length;
            var leftHalf = numberAsString.Substring(0, length/2);
            var rightHalf = numberAsString.Substring(length / 2);
        
            if (leftHalf == rightHalf)
            {
                return number;
            }            
        }
        return 0;
    }
}
