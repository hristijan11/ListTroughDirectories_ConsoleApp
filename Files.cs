using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp
{
    class Files
    {
        public void CreateFiles()
        {
            Files CreateFiles = new Files();
            string rootFolder = @"C:\tmp\";
            string subDirectory = @"C:\tmp\ConsoleAppWork\";
            string destinationFolder = @"C:\tmp\ConsoleAppWork\";
            string finalFolder = @"C:\tmp\ConsoleAppWork\SubDirectory\";
            string[] extensions = { ".txt", ".jpg", ".html", ".css", ".js", ".pdf", ".cs", ".sln" };
            //Creating files
            int counter1 = 1;
            if (!Directory.Exists(finalFolder))
                Console.WriteLine("How many files you want to create?");
            var user3 = Convert.ToInt32(Console.ReadLine());
            for (int z = 0; z <= user3; z++)
            {
                Directory.CreateDirectory(finalFolder);
                while (counter1 <= user3)
                {
                    for (int q = 0; q <= user3; q++)
                    {
                        File.Create(@"C:\tmp\ConsoleAppWork\SubDirectory\file" + (q + 1) + ".txt");
                        var extensionsChange = Path.ChangeExtension(finalFolder, ".jpg");
                    }
                    Console.WriteLine("Succesfully created: " + user3 + " files!");
                    break;
                }
                break;
            }
        }
    }
}
