# AdventOfCode2024

Solutions for the [Advent of Code '25](https://adventofcode.com/) puzzles.

The solution for each part is marked by a tag in the git history.

## New Puzzle

In the following shell command sequence, replace `D03Lobby` by the name of the next project.
Then, replace `D02GiftShop` by `D03Lobby`.

```shell
dotnet new classlib -o D03Lobby; \
dotnet sln add D03Lobby; \
dotnet new xunit -o D03Lobby.Tests; \
dotnet sln add D03Lobby.Tests; \
dotnet reference add D03Lobby/D03Lobby.csproj --project D03Lobby.Tests/D03Lobby.Tests.csproj; \
\
cd D03Lobby.Tests; \
dotnet add package FluentAssertions; \
\
mkdir Data; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/.gitkeep; \
echo "Ensure that the folder is created. Place your puzzle input here." > Data/PuzzleInput.txt; \
cd ..; \
\
cp D02GiftShop.Tests/GlobalUsings.cs D03Lobby.Tests/
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
