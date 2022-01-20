
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp
{
    class ListDirectories
    {
        public void ListInAllDirectories()
        {
            string rootFolder = @"C:\tmp\";
            string subDirectory = @"C:\tmp\ConsoleAppWork";
            string destinationFolder = @"C:\tmp\ConsoleAppWork\";
            //string destinationFile = @"C:\tmp\ConsoleAppWork\file1.txt";
            string finalFolder = @"C:\tmp\ConsoleAppWork\SubDirectory\";
            ListDirectories ListInAllDirectories = new ListDirectories();
            try
            {
                //get a list of all Directories  
                Console.WriteLine("If you want to list all the Directories enter Y / N");
                var inputDir = Console.ReadLine();
                while (inputDir == inputDir)
                {
                    if (inputDir != "Y" && inputDir != "y")
                    {
                        Console.WriteLine("Thank you for your time! ");
                    }
                    else
                    {
                        //sql-c#
                        var dirs = from dir in
                        Directory.EnumerateDirectories(rootFolder)
                                   select dir;
                        Console.WriteLine("Directories: {0}", dirs.Count<string>().ToString());
                        Console.WriteLine("List of Directories");
                        foreach (var dir in dirs)
                        {
                            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
                        }
                    }
                    break;    
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new NullReferenceException("NullReferenceException..");
            }
            try
            {
                //get a list of all SubDirectories  
                Console.WriteLine("If you want to list all the Subdirectories enter Y / N");
                var inputSubDir = Console.ReadLine();
                while (inputSubDir == inputSubDir)
                {
                    if (inputSubDir != "Y" && inputSubDir != "y")
                    {
                        Console.WriteLine("Thank you for your time! ");
                    }
                    else
                    {
                        //sql-c#
                        var dirs = from dir in
                        Directory.EnumerateDirectories(subDirectory)
                                   select dir;
                        Console.WriteLine("SubDirectories: {0}", dirs.Count<string>().ToString());
                        Console.WriteLine("List of SubDirectories");
                        foreach (var dir in dirs)
                        {
                            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
                        }
                    }
                    break;
                   
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new NullReferenceException("NullReferenceException..");
            }
            try
            {
                //get a list of all SubDirectories
                Console.WriteLine("If you want to list all the Subdirectories enter Y / N");
                var inputSubDir0 = Console.ReadLine();
                while (inputSubDir0 == inputSubDir0)
                {
                    if (inputSubDir0 != "Y" && inputSubDir0 != "y")
                    {
                        Console.WriteLine("Thank you for your time! ");
                    }
                    else
                    {
                        //sql-c#
                        var dirs = from dir in
                        Directory.EnumerateFiles(finalFolder)
                                   select dir;
                        Console.WriteLine("Files: {0}", dirs.Count<string>().ToString());
                        Console.WriteLine("List of files is: ");
                        foreach (var dir in dirs)
                        {
                            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
                        }
                    }
                    break;
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new NullReferenceException("NullReferenceException..");
            }
            Console.ReadKey();
        }
    }
}