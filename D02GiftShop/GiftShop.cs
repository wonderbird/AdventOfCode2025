
namespace D02GiftShop;

public class GiftShop
{
    public static int AddInvalidIds(IEnumerable<string> ranges)
    {
        var range = ranges.First();
        var rangeLimits = range.Split('-');
        
        var left = int.Parse(rangeLimits[0]);

        var numberAsString = left.ToString();
        var length = numberAsString.Length;
        var leftHalf = numberAsString.Substring(0, length/2);
        var rightHalf = numberAsString.Substring(length / 2);
    
        if (leftHalf == rightHalf)
        {
            return left;
        }
        return 0;
    }
}
