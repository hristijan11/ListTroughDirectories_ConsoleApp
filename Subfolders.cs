using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp
{
    public class Subfolders
    {
        public void CreateSubFolders()
        {
            Subfolders CreateSubFolders = new Subfolders();
            //path
            string rootFolder = @"C:\tmp\";
            string subDirectory = @"C:\tmp\ConsoleAppWork\";
            string destinationFolder = @"C:\tmp\ConsoleAppWork\";
            string finalFolder = @"C:\tmp\ConsoleAppWork\SubDirectory\file";
            string[] extensions = { ".txt", ".jpg", ".html", ".css", ".js", ".pdf", ".cs", ".sln" };
            //Object obj = new Object();
            Console.WriteLine("2)Type how many subfolders you want to create: ");
            var user2 = Convert.ToInt32(Console.ReadLine());
            int counter1 = 1;
            //var dir = Directory.GetCurrentDirectory(Path.GetFullPath,subDirectory ,SearchOption.AllDirectories);
            while (counter1 != user2)
            {
                //don't create more than 300 directories beacuse of "memory"
                if (user2 <= 300 || user2 >= 0)
                {
                    for (int qi = 1; qi <= user2; qi++)
                        Directory.CreateDirectory(destinationFolder + qi);
                    //string combine = destinationFolder + qi;
                    Console.WriteLine("Successfully created : " + user2 + " SubDirectories!");
                    var directory = Path.GetFullPath(subDirectory.Replace(subDirectory, destinationFolder));
                    Console.WriteLine("Your path of subdirectories is: " + directory);
                    break;
                }
                else
                {
                    Console.WriteLine("Folders already exists in you Directory");
                }
                break;
            }
        }
    }
}
