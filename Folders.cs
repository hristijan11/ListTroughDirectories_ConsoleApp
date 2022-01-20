using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp
{
    public class Folders
    {
        public void CreateFolder(string Folders)
        {
            Folders CreateFolder = new Folders();
            //set color to green
            ConsoleColor green = ConsoleColor.Green;
            Console.ForegroundColor = green;
            Console.WriteLine("Enter your name: ");
            var user1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hi, " + user1);
            //ConsoleColor white = ConsoleColor.White;            
            //string combinedFolders = Path.Combine(rootFolder, "subDirectory");
            #region
            string rootFolder = @"C:\tmp\";
            string subDirectory = @"C:\tmp\ConsoleAppWork";
            string destinationFolder = @"C:\tmp\ConsoleAppWork\SubDirectory\";
            Object obj = new Object();
            Console.WriteLine("Type how many directories you want to create: ");
            var user = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (counter != user)
                {
                if(user <= 300 || user >= 0)
                for (int i = 1; i <= user; i++)
                    Directory.CreateDirectory(subDirectory + i);
                string userInput = subDirectory + user;
                {
                    if (!Directory.Exists(userInput))
                    {
                        Console.WriteLine("Already exists!");
                    }
                    else
                    {
                        Console.WriteLine("Successfully created : " + user + " directories!");
                        var directory = Path.GetFullPath(rootFolder);
                        Console.WriteLine("Your path of directories is: " + directory);
                        break;
                        }
                    }
                }
            //var exists = Directory.Exists(subDirectory);
            //if (Directory.Exists(subDirectory)) 
            //{
            //    Directory.Delete(File.Exists());
            //    Console.WriteLine("uspesno izbrisani");
        }
    }
}
#endregion
#region
//    int counter1 = 0;
//    while(counter1 != user2)
//    {
//        if(!Directory.Exists(subDirectory))
//        Directory.CreateDirectory(secondUserInput + j + "\\");

//        for (int j = 0; j < user2; j++)


//        Console.WriteLine("Uspesno subfolderi kreirani");
//        {
//            if (Directory.Exists(secondUserInput))
//            {
//                Console.WriteLine("uspesno kreirani : " + user2 + " subfolderi!\n" );
//            }
//            else
//            {
//                Console.WriteLine("vekje se kreirani drugarce");
//                break;
//            }

//        }
//    }
//}


//DestinationFolder=ConsoleWork=SubDirectory + file file
//{

//    Directory.CreateDirectory(destinationFolder + user);
//    string destinationFolder1 = rootFolder + user;
//    Console.WriteLine("You have created: " + user + " folders!");
//    {
//        Directory.CreateDirectory(destinationFolder);
//        Console.WriteLine("You have created: " + user + " folders!");
//    }
//    //break;
//}





//    for (int zq = 0; zq <= user; zq++)
//        Directory.CreateDirectory(subDirectory + user + zq + "\\");
//    Console.WriteLine("Created subDirectory path + user + zq");
//    break;
//}
//    if (user <= 0 && user >= 100)
//    {
//        for (int zq = 0; zq <= user; zq++)
//            //{
//            //    for (int pz = 0; pz < user; pz++) 
//            //    Directory.CreateDirectory(subDirectory + user + pz);
//            //    Console.WriteLine("created rootFolder");
//            //    break;
//            //}
//            //if (!Directory.Exists(destinationFolder))
//            //{
//            Directory.CreateDirectory(subDirectory + user + zq + "\\");
//        Console.WriteLine("Created subDirectory path + user + zq");
//    }
////KREIRA SUB SUB FAJLOVI
//    else if (user <= 100 && user >= 0)
//    {
//        for (int qi = 0; qi <= user; qi++)
//            Directory.CreateDirectory(destinationFolder + user + qi + "\\");
//    }
//



//        int counter = 0;
//        while (counter <= 10)
//        {
//            //creating tmp folder
//            if (!Directory.Exists(rootFolder))
//            {
//                Directory.CreateDirectory(rootFolder);
//                Console.WriteLine("Message:Folders are succesfully created!");
//            }
//            else
//            {
//                Console.WriteLine("Folders already exists!");
//                break;
//            }
//            //creating subDirectory ,hardway.
//            if (!Directory.Exists(subDirectory))
//                Directory.CreateDirectory(subDirectory + counter + "\\");
//            for (int z = 0; z <= 9; z++)
//            {
//                Directory.CreateDirectory(rootFolder + z + "\\");
//                string subFolder = rootFolder + counter + "\\" + z;
//                for (int j = 0; j <= 9; j++)
//                {
//                }

//            }
//        }
//    }
//}
#endregion
