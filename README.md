# AdventOfCode2024

Solutions for the [Advent of Code '25](https://adventofcode.com/) puzzles

## New Puzzle

In the following shell command sequence, replace `D02GiftShop` by the name of the next project.
Then, replace `D01SecretEntrance` by `D01SecretEntrance`.

```shell
dotnet new classlib -o D02GiftShop; \
dotnet sln add D02GiftShop; \
dotnet new xunit -o D02GiftShop.Tests; \
dotnet sln add D02GiftShop.Tests; \
dotnet reference add D02GiftShop/D02GiftShop.csproj --project D02GiftShop.Tests/D02GiftShop.Tests.csproj \
\
cd D02GiftShop.Tests; \
dotnet add package FluentAssertions; \
\
mkdir Data; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/.gitkeep; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/PuzzleInput.txt; \
cd ..; \
\
cp D01SecretEntrance.Tests/GlobalUsings.cs D02GiftShop.Tests/
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
