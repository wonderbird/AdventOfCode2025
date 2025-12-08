namespace D04PrintingDepartment.Tests.ForkliftOperator.IterativelyRemoveAccessibleRolls
{
    public class GivenInputFile
    {
        [Theory]
        [InlineData("OnlyOneRemovalStepPossible.txt", 1)]
        [InlineData("ExampleInput.txt", 43)]
        [InlineData("PuzzleInput.txt", 9000)]
        public void WhenFileName_ReturnsExpected(string fileName, int expected)
        {
            var path = Path.Combine("Data", fileName);
            var input = File.ReadAllLines(path);
            new D04PrintingDepartment.ForkliftOperator(input).TotalOfRemovedRolls.Should().Be(expected);
        }
    }
}