namespace AdventOfCode.Base;

static class DayInitialization
{
    public static void Execute(int day)
    {
        var projectDir = AppContext.BaseDirectory[..AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal)];
        var solutionProjectDir = Path.Combine(projectDir, $"..{Path.DirectorySeparatorChar}AdventOfCode.Solutions");

        var dayStr = day.ToString("00");
        var dayDir = $@"{solutionProjectDir}\Day{dayStr}\";

        if (Directory.Exists(dayDir))
        {
            Console.WriteLine($"Directory {dayDir} was already initialized");
            return;
        }

        Directory.CreateDirectory(dayDir);

        var template = File.ReadAllText($@"{projectDir}Base\solver.txt");
        template = template.Replace("[Day]", dayStr);
        File.WriteAllText($"{dayDir}Day{dayStr}Solver.cs", template);

        void CreateInputFile(string fileName)
        {
            var inputFileName = $"{dayDir}{fileName}";
            File.WriteAllText(inputFileName, "");

            Process.Start(new ProcessStartInfo(inputFileName) { UseShellExecute = true, });
        }

        CreateInputFile("input.txt");
        CreateInputFile("example.txt");
    }
}