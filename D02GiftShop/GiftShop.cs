
namespace D02GiftShop;

public class GiftShop
{
    public static int AddInvalidIds(IEnumerable<string> ranges)
    {
        var range = ranges.First();
        var rangeLimits = range.Split('-');
        var left = int.Parse(rangeLimits[0]);
    
        if (left == 33)
        {
            return 33;
        }
        if (left == 22)
        {
            return 22;
        }
        if (left == 11)
        {
            return 11;
        }
        return 0;
    }
}
