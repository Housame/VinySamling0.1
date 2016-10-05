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
        public static FileName fileName;
        public static VinylList vinylList;

        static string filePath;
        public static string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
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
            Console.Clear();
            int caseSwitch;
            string input;
            string tempName;
            while (true)
            {
                GUI.FileChoiceGui();
                input = Console.ReadLine();

                if (input == "1" || input == "2" || input =="3")

                    caseSwitch = int.Parse(input);

                else

                    caseSwitch = 0;

                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\n  Skriv in listans namn som du vill skapa:");
                        tempName = Console.ReadLine();
                        fileName = new FileName(tempName);
                        ListCreator();
                        Console.WriteLine("Listan är skapade!!");
                        Program.Timer(1.5);
                        return;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n\n  Skriv in listans namn som du vill ladda upp:");
                        tempName = TryFindFile(Console.ReadLine());
                        fileName = new FileName(tempName);
                        string[] tempVinylList = File.ReadAllLines(FilePath + @"\" + fileName.name + ".txt");
                        vinylList = new VinylList(tempVinylList);
                        return;
                    case 3:
                        Console.Clear();
                        Instructions();
                        return;

                    default:
                        Console.WriteLine("Vänlligen skriv in ett giltigt val 1,2 eller 3!");
                        Program.Timer(1);
                        Console.Clear();
                        break;
                }
            }
        }

        private static void Instructions()
        {
            Console.Clear();
            GUI.InstructionsGui();
            Console.WriteLine("\n\n");    
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                   För att skapa en fil, skriv endast fil namn");
            Console.WriteLine(@"                   Namnet på filen får inte innehålla  \ / : * ? | < > ");
            Console.WriteLine("                   Du behöver ej skriva .txt, endast namnet på filen");
            Console.WriteLine("\n\n");
            Console.WriteLine(@"                   För att ladda upp en fil se till att den ligger i Dokument\VinylSamlingData som skapas automatiskt när du startar programmet");
            Console.WriteLine("                   För att programmet ska hitta filen se till att du skriver den rätt, stora och små bokstäver måste skrivas som det står på filen");
            Console.WriteLine("\n\n");
            Console.WriteLine("                   Tryck enter för att komma tillbaka till menyn:");
            Console.Read();
            Console.Clear();
            Console.ResetColor();
            FileChoice();
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



        public static VinylList ListCreator()
        {
            
            filePathString = FilePath + @"\" + fileName.name + ".txt";

            File.WriteAllText(filePathString, "");
            string[] tempVinylList= File.ReadAllLines(filePathString);
            vinylList = new VinylList(tempVinylList);
            return vinylList;

            
        }


        
    }
}
