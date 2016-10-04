using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class ImportFiles
    {
        static string filePath;
        public static string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        static string fileName;

        public static string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        static string folderName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static string FolderName
        {
            get { return folderName; }
            private set { folderName = value; }
        }
        static string filePathString;

        public static string FilePathString
        {
            get { return filePathString; }
            set { filePathString = value; }
        }
        public static void FileChoice()
        {
            GUI.FileChoiceGui();

            int caseSwitch;
            string input;
            while (true)
            {

                input = Console.ReadLine();

                if (input == "1" || input == "2")

                    caseSwitch = int.Parse(input);

                else

                    caseSwitch = 0;

                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\n  Skriv in listans namn som du vill skapa:");
                        fileName = Console.ReadLine();
                        ListCreator();
                        Console.WriteLine("Listan är skapade!!");
                        Program.Timer(1.5);
                        return;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n\n  Skriv in listans namn som du vill ladda upp:");
                        fileName = TryFindFile(Console.ReadLine());
                        VinylList = File.ReadAllLines(FilePath + @"\" + FileName + ".txt");
                        return;

                    default:
                        Console.WriteLine("Vänlligen skriv in ett giltigt val 1 eller 2!");
                        Program.Timer(1);
                        Console.Clear();
                        break;
                }
            }
        }

        private static string TryFindFile(string listName)
        {
           
            bool condition = true;
            while (condition)
            {
                if (File.Exists(filePath + @"\" + listName + ".txt"))
                {
                    
                    condition = false;
                }

                else
                {
                    InputController.ClearOneLine();
                    Console.WriteLine("Skriv in en befintlig namn på listan!!");
                    Program.Timer(1.5);
                    InputController.ClearOneLine();
                    listName = Console.ReadLine();
                  
                }

            }
            
            return listName;

        }

        public static void PathCreator()
        {
            filePath = Path.Combine(folderName, "VinylSamlingData");
            Directory.CreateDirectory(filePath);
        }

        public static string[] VinylList { get; set; }

        public static string[] ListCreator()
        {
            
            filePathString = FilePath + @"\" + FileName + ".txt";

            File.WriteAllText(filePathString, "");

            return VinylList= File.ReadAllLines(filePathString);
        }


        
    }
}
