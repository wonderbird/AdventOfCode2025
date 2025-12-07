namespace D04PrintingDepartment;

public class GridCalculator
{
    private readonly int _yMax;
    private readonly int _xMax;
    private readonly int[,] _grid;
    private readonly int[,] _adjacentRolls;
    private readonly int[,] _accessibleRolls;
    private int _numberOfAccessibleRolls;

    public GridCalculator(IEnumerable<string> input)
    {
        var enumeratedInput = input.ToList();
        
        _yMax = enumeratedInput.Count;
        _xMax = enumeratedInput[0].Length;
        _grid = new int[_xMax + 2, _yMax + 2];
        _adjacentRolls = new int[_xMax + 2, _yMax + 2];
        _accessibleRolls = new int[_xMax + 2, _yMax + 2];

        InputToGrid(enumeratedInput);

        CalculateAdjacentRolls();

        CalculateAccessibleRolls();

        CountAccessibleRoles();
    }

    private void InputToGrid(IEnumerable<string> input)
    {
        var y = 1;
        foreach (var row in input)
        {
            var x = 1;
            foreach (var symbol in row)
            {
                _grid[x, y] = symbol == '@' ? 1 : 0;
                x++;
            }

            y++;
        }
    }

    private void CalculateAdjacentRolls()
    {
        for (var y = 1; y <= _yMax; y++)
        {
            for (var x = 1; x <= _xMax; x++)
            {
                var rollsInSector = new int[9];

                var index = 0;

                for (var yGrid = y - 1; yGrid <= y + 1; yGrid++)
                {
                    for (var xGrid = x - 1; xGrid <= x + 1; xGrid++)
                    {
                        rollsInSector[index] = _grid[xGrid, yGrid];
                        index++;
                    }
                }

                // The current roll is ignored
                rollsInSector[4] = 0;

                _adjacentRolls[x, y] = rollsInSector.Sum();
            }
        }
    }

    private void CalculateAccessibleRolls()
    {
        for (var y = 1; y <= _yMax; y++)
        {
            for (var x = 1; x <= _xMax; x++)
            {
                _accessibleRolls[x, y] = (_grid[x, y] == 1 && _adjacentRolls[x, y] < 4) ? 1 : 0;
            }
        }
    }

    private void CountAccessibleRoles()
    {
        _numberOfAccessibleRolls = 0;
        foreach (var isAccessible in _accessibleRolls)
        {
            if (isAccessible == 1)
            {
                _numberOfAccessibleRolls++;
            }
        }
    }

    public int AccessibleRolls => _numberOfAccessibleRolls;
}