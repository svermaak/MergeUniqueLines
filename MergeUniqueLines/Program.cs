using System.Diagnostics;

class MergeUniqueLines
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: MergeUniqueLines <outputFile> <inputFile1> <inputFile2> ...");
            return;
        }

        string destination = args[0];
        var inputFiles = args.Skip(1).ToList();

        var stopwatch = Stopwatch.StartNew();
        var hashSet = new HashSet<string>(StringComparer.Ordinal);

        foreach (var file in inputFiles)
        {
            try
            {
                using var reader = new StreamReader(file);
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    hashSet.Add(line);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to process {file}: {ex.Message}");
            }
        }

        var sortedLines = hashSet.ToList();
        sortedLines.Sort();

        try
        {
            File.WriteAllLines(destination, sortedLines, System.Text.Encoding.UTF8);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Failed to write output: {ex.Message}");
            return;
        }

        stopwatch.Stop();
        var destInfo = new FileInfo(destination);

        Console.WriteLine("Merge complete:");
        Console.WriteLine($"  Files processed : {inputFiles.Count}");
        Console.WriteLine($"  Output file     : {destInfo.FullName}");
        Console.WriteLine($"  Lines written   : {sortedLines.Count}");
        Console.WriteLine($"  Size (bytes)    : {destInfo.Length}");
        Console.WriteLine($"  Time taken      : {stopwatch.Elapsed}");
    }
}