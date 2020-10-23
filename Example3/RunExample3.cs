using System;

namespace CodingPracticeSep2020.Example3
{
    class RunExample3
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nahasan\Downloads\Voorstellen.docx\";
            var splitResult = PathSplitter.SplitDirectoryFile(path);

            Console.WriteLine($"Path { path}");
            Console.WriteLine($"Directory { splitResult.Directory }");
            Console.WriteLine($"File { splitResult.File }");
        }
    }
}
