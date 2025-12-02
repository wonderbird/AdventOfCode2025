# AdventOfCode2024

Solutions for the [Advent of Code '25](https://adventofcode.com/) puzzles

## New Puzzle

In the following shell command sequence, replace `D01SecretEntrance` by the name of the next project.
Then, replace `LastProjectName` by `D01SecretEntrance`.

```shell
dotnet new xunit -o D01SecretEntrance; \
dotnet sln add D01SecretEntrance; \
\
cd D01SecretEntrance; \
dotnet add package FluentAssertions; \
\
mkdir Data; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/.gitkeep; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/PuzzleInput.txt; \
cd ..; \
\
cp LastProjectName/GlobalUsings.cs D01SecretEntrance/
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
