using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> allFiles = new List<string>();
            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            string filter = Console.ReadLine();
            var filterParts = Regex.Split(filter, " in ");
            var filterExt = "." + filterParts[0];
            var filterRoot = filterParts[1] + "\\";
            bool checker = true;
            
            Dictionary<string, long> fileSize = new Dictionary<string, long>();
            foreach (var f in allFiles)
            {
                var filePlusSize = f.Split(';');
                var size = long.Parse(filePlusSize[1]);
                var pathPlusFileName = filePlusSize[0];
                if (pathPlusFileName.StartsWith(filterRoot) && pathPlusFileName.EndsWith(filterExt))
                {
                    var pathTokens = pathPlusFileName.Split('\\');
                    var fileName = pathTokens[pathTokens.Length - 1];
                    fileSize[fileName] = size;
                    checker = false;
                }
            }
            var sortedOutputFiles = fileSize
                .ToArray()
                .OrderByDescending(fs => fs.Value)
                .ThenBy(fs => fs.Key);

            foreach (var fs in sortedOutputFiles)
            {
                Console.WriteLine(fs.Key + " - " + fs.Value + " KB");
            }
            if (checker)
            {
                Console.WriteLine("No");
            }
        }
    }
}
