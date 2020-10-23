using CodingPracticeSep2020.Example3.Models;

using Path = System.IO.Path;

namespace CodingPracticeSep2020.Example3
{
    public class PathSplitter
    {
        private static string IgnoreTrailingSlashIfAny(string path, int rootLength)
        {
            if(path.Length > rootLength)
                return path.TrimEnd(new[] { '\\' });

            return path;
        }

        private static bool TryGetPivotIndex(string path, int rootLength, out int pivotIndex)
        {
            int pathLength = path.Length;

            pivotIndex = path.LastIndexOf(Path.DirectorySeparatorChar,
                                          pathLength - 1,
                                          pathLength - rootLength);

            return pivotIndex == -1 ? false : true;
        }

        public static PathSplitResult SplitDirectoryFile(string path)
        {
            if (path == null) return null;
            
            int rootLength = Path.GetPathRoot(path).Length;

            path = IgnoreTrailingSlashIfAny(path, rootLength);

            if(TryGetPivotIndex(path, rootLength, out int pivotIndex))
            {
                return new PathSplitResult 
                { 
                    Directory = path.Substring(0, pivotIndex), 
                    File = path.Substring(pivotIndex + 1, path.Length - pivotIndex - 1) 
                };
            }
            else
            {
                return new PathSplitResult 
                {
                    Directory = path.Substring(0, path.Length) 
                };
            }
        }
    }
}
