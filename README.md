# AdventOfCode StarterKit

This project can be used as starterkit for the [AdventOfCode](https://www.AdventOfCode.com] competition. 

## Provision a new day

To get started quickly, this starterkit assists you with the generator for initializing the 
source code for the puzzles. Just run the application and enter the number of the day, your 
want to initialize.

The generator creates the following:
- A new directory for the requested day
- The boilerplate code for the solver
- The Unit-Tests to execute the solver
- An empty textfile called input.txt (will be opened in the standard texteditor)

## Implement the solver

After initializing a Day, you have to paste the input data the website to the input.txt file 
and implement the Solve1 and Solve2 methods. 

```csharp

// Solver for AoC2018, day 1
protected override string Solve1(List<string> data)
{
    return data.Select(q => Int.Parse(q)).Sum().ToString();
}

```

## Executing the solvers

To Execute the solvers, you have to use the generated unit tests. When you run the unit test 
using the Test Explorer in Visual Studio. The unit tests load the input.txt, call the Solve method 
and save the output to a text file called output1.txt or output2.txt.

You can change the name of the input and output filename by passing alternative filename as paramenter.

```csharp

[Fact]
public void RunStep1() => Output.WriteLine(new Day[Day]Solver().ExecutePuzzle1("testinput.txt"));

```
