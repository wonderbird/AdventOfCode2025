namespace D04PrintingDepartment;

public class ForkliftOperator
{
    public int TotalOfRemovedRolls { get; }

    public ForkliftOperator(string[] input)
    {
        var currentInput = input;
        var hasRemovedRolls = false;
        TotalOfRemovedRolls = 0;

        do
        {
            var calculator = new GridCalculator(currentInput);
            hasRemovedRolls = calculator.AccessibleRolls > 0;
            TotalOfRemovedRolls += calculator.AccessibleRolls;
            currentInput = calculator.StateAfterRemovingAccessibleRolls;
        } while (hasRemovedRolls);
    }
}