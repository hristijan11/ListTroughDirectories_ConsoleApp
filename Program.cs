using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static ConsoleApp.Folders;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Directories
            ConsoleApp.Folders CreateFolder = new Folders();
            try
            {
                CreateFolder.CreateFolder(" !");
            }
            catch (OutOfMemoryException e)
            {
                throw new OutOfMemoryException();
                Console.WriteLine("Error" + e.Message);
                Console.WriteLine("Comes from:" + e.StackTrace);
            }
            //Create SubDirectories
            ConsoleApp.Subfolders CreateSubFolders = new Subfolders();
            CreateSubFolders.CreateSubFolders();
            //Create Files
            Files CreateFiles = new Files();
            CreateFiles.CreateFiles();
            //ListAllDirectories
            ListDirectories listDirectories = new ListDirectories();
            listDirectories.ListInAllDirectories();
        }
    }
}
