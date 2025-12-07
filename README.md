# AdventOfCode2024

Solutions for the [Advent of Code '25](https://adventofcode.com/) puzzles.

The solution for each part is marked by a tag in the git history.

## New Puzzle

In the following shell command sequence, replace `D04PrintingDepartment` by the name of the next project.
Then, replace `D03Lobby` by `D03Lobby`.

```shell
dotnet new classlib -o D04PrintingDepartment; \
dotnet sln add D04PrintingDepartment; \
dotnet new xunit -o D04PrintingDepartment.Tests; \
dotnet sln add D04PrintingDepartment.Tests; \
dotnet reference add D04PrintingDepartment/D04PrintingDepartment.csproj --project D04PrintingDepartment.Tests/D04PrintingDepartment.Tests.csproj; \
\
cd D04PrintingDepartment.Tests; \
dotnet add package FluentAssertions; \
\
mkdir Data; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/.gitkeep; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/PuzzleInput.txt; \
cd ..; \
\
cp D03Lobby.Tests/GlobalUsings.cs D04PrintingDepartment.Tests/
```

Add the following configuration to the bottom of the `.csproj` file, right before the closing `</Project>` tag.

```xml
  <ItemGroup>
    <Content Include="Data\*.*">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>  
  </ItemGroup>
```

If you are using Visual Studio Code, you might need to re-open the project folder so that the [C# Dev Kit extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) catches the changes.

## Build, Test

To simply run the unit test, execute

```shell
dotnet test
```

To run mutation tests with [Stryker Mutator](https://stryker-mutator.io), first install the tool

```shell
dotnet tool restore
```

then run mutation tests

```shell
dotnet dotnet-stryker
```
