﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class Database

    {
        #region
        
       
        #endregion

        public static void Choice()
        {
            int caseSwitch;
            string input;
            while (true)
            {
                GUI.MenuGui();
                input = Console.ReadLine();

                if (input == "1" || input == "2" || input == "3" || input == "4"|| input =="5"||input =="6")

                    caseSwitch = int.Parse(input);

                else

                    caseSwitch = 0;

                switch (caseSwitch)
                {
                    case 1:
                        ShowList();
                        return;
                    case 2:
                        AddVinyl();
                        return;
                    case 3:
                        EditList();
                        return;
                    case 4:
                        RemoveVinyl();
                        return;
                    case 5:
                        ImportFiles.FileChoice();
                        return;
                    case 6:
                        GUI.ByeByeGui();
                        Program.Timer(1.5);
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Vänlligen skriv in ett giltigt val 1,2,3 eller 4!");
                        Program.Timer(1);
                        Console.Clear();
                        break;
                }
            }
            
        }

        private static void ShowList()
        {
            Console.Clear();
            GUI.ShowListGui();
            Console.WriteLine("\n");
            Console.WriteLine(ImportFiles.fileName.filePathString);
            for (int i = 0; i < ImportFiles.fileName.vinylList.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + ImportFiles.fileName.vinylList[i]);
            }


            Console.WriteLine("\nÄr du färdig med Listan? tryck enter för att komma ut");
            Console.Read();
            BackOrOut();
        }

        private static void AddVinyl()
        {

            Console.Clear();
            GUI.AddVinylGui();
            Console.WriteLine("\n\n");
            Console.WriteLine();
            Vinyl.Name = InputController.NameController().ToUpper();
            Console.WriteLine();
            Vinyl.Album = InputController.AlbumController().ToUpper();
            Console.WriteLine();
            Vinyl.Artist = InputController.ArtistController().ToUpper();
            Console.WriteLine();
            Vinyl.Year = InputController.YearController();

            string vinylLine = Vinyl.Name + " " + Vinyl.Album + " " + Vinyl.Artist + " " + Vinyl.Year + ";" + Environment.NewLine;
            File.AppendAllText(@ImportFiles.fileName.filePathString, vinylLine);
            for (int i = 0; i < 8; i++)
            {
                InputController.ClearOneLine();
            }
            Console.WriteLine("klart!!!");
            ImportFiles.fileName.vinylList = File.ReadAllLines(ImportFiles.fileName.filePathString);
            
            Console.WriteLine("Vill du lägga in en till? Tryck 1 annars tryck 2 för att komma ut ");
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
                        AddVinyl();
                        return;
                    case 2:

                        BackOrOut();
                        return;

                    default:
                        Console.WriteLine("Vänlligen skriv in ett giltigt val 1 eller 2!");
                        Program.Timer(1);
                        Console.Clear();
                        break;
                }
            }


        }

        private static void EditList()
        {
            Console.Clear();
            GUI.EditListGui();
            Console.WriteLine("\n\n");
            for (int i = 0; i < ImportFiles.fileName.vinylList.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + ImportFiles.fileName.vinylList[i]);
            }
            Console.WriteLine("Vänligen välj vilken låt vill du ändra på!");
            int input = InputNumberOfLine();
            Console.WriteLine("Du valde att ändra på låten nummer {0}", input);

            Console.WriteLine();
            Vinyl.Name = InputController.NameController().ToUpper();
            Console.WriteLine();
            Vinyl.Album = InputController.AlbumController().ToUpper();
            Console.WriteLine();
            Vinyl.Artist = InputController.ArtistController().ToUpper();
            Console.WriteLine();
            Vinyl.Year = InputController.YearController();
            
            
            string vinylLine = Vinyl.Name + " " + Vinyl.Album + " " + Vinyl.Artist + " " + Vinyl.Year + ";";
            var tempList = new List<string>(File.ReadAllLines(@ImportFiles.fileName.filePathString));
            tempList[input - 1] = vinylLine;
            File.WriteAllLines(@ImportFiles.fileName.filePathString, tempList);
            for (int i = 0; i < ImportFiles.fileName.vinylList.Length + 11; i++)
            {
                InputController.ClearOneLine();
            }
            Console.WriteLine("klart!!!");
            ImportFiles.fileName.vinylList = File.ReadAllLines(ImportFiles.fileName.filePathString);
            for (int i = 0; i < ImportFiles.fileName.vinylList.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + ImportFiles.fileName.vinylList[i]);
            }
            EditMoreOrNot();

        }

        private static void RemoveVinyl()
        {
            Console.Clear();
            GUI.RemoveVinylGui();
            Console.WriteLine("\n\n");
            for (int i = 0; i < ImportFiles.fileName.vinylList.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + ImportFiles.fileName.vinylList[i]);
            }

           int input = InputNumberOfLine();// kontroll för att input ska vara en av nr från listan
            Console.WriteLine("Du valde att ta bort låten nummer {0}",input);

            //sätta filen i en list och sen ta bort raden, därefter överför listan till file.txt.
            var tempFile = new List<string>(File.ReadAllLines(@ImportFiles.fileName.filePathString));
            tempFile.RemoveAt(input-1);
            File.WriteAllLines(@ImportFiles.fileName.filePathString, tempFile.ToArray());
            // ta bort raderna för den listan som visades förr, grafisk optimization
            for (int i = 0; i < ImportFiles.fileName.vinylList.Length + 2; i++)
            {
                InputController.ClearOneLine();
            }
            Console.WriteLine("klart!!!");
            ImportFiles.fileName.vinylList = File.ReadAllLines(ImportFiles.fileName.filePathString);
            for (int i = 0; i < ImportFiles.fileName.vinylList.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + ImportFiles.fileName.vinylList[i]);
            }
            InputMenu();
            
        }

        private static void InputMenu()
        {
            while (true)
            {
                Console.WriteLine("Ta bort fler tryck 1? annars tryck 2: ");
                string inputMenu = Console.ReadLine();
                int caseSwitch;

                if (inputMenu == "1" || inputMenu == "2")

                    caseSwitch = int.Parse(inputMenu);

                else

                    caseSwitch = 0;

                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        RemoveVinyl();
                        return;
                    case 2:
                        Console.Clear();
                        BackOrOut();
                        return;
                    default:
                        Console.WriteLine("Vänlligen skriv in ett giltigt val 1 eller 2");
                        Program.Timer(1);
                        Console.Clear();
                        break;
                }
            }
        }

        private static int InputNumberOfLine()
        {
            bool condition = true;
            int input=0;
            while (condition)
            {
                Console.WriteLine("Välj vilken låt vill du ta bort [{0},{1}]:", 1, ImportFiles.fileName.vinylList.Length );
                try
                {
                    input = int.Parse(Console.ReadLine());
                    InputController.ClearOneLine();
                }
                catch (Exception)
                {
                    InputController.ClearOneLine();
                    Console.WriteLine("Vänligen skriv in ett nummer mellan {0} och {1}", 1, ImportFiles.fileName.vinylList.Length );
                    Program.Timer(1.5);
                    InputController.ClearOneLine();
                }
                if (input <= ImportFiles.fileName.vinylList.Length  && input >= 1)

                    condition = false;
                else
                {
                    InputController.ClearOneLine();
                    Console.WriteLine("Vänligen skriv in ett nummer mellan {0} och {1}", 1, ImportFiles.fileName.vinylList.Length);
                    InputController.ClearOneLine();
                }

            }
            return input;
        }

        private static void EditMoreOrNot()
        {
           
            Console.WriteLine("Vill du redigera en till? Tryck 1 annars tryck 2 för att komma ut ");
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
                        EditList();
                        return;
                    case 2:

                        BackOrOut();
                        return;

                    default:
                        Console.WriteLine("Vänlligen skriv in ett giltigt val 1 eller 2!");
                        Program.Timer(1);
                        Console.Clear();
                        break;
                }
            }
        }

        private static void BackOrOut()
        {
            Console.Clear();
            int caseSwitch;
            string input;
            while (true)
            {
                GUI.BackOrOutGui();
                input = Console.ReadLine();

                if (input == "1" || input == "2")

                    caseSwitch = int.Parse(input);

                else

                    caseSwitch = 0;

                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        Choice();
                        return;
                    case 2:
                        Console.Clear();
                        GUI.ByeByeGui();
                        Program.Timer(3);
                        Environment.Exit(0);
                        return;
                    
                    default:
                        Console.WriteLine("Vänlligen skriv in ett giltigt val 1 eller 2!");
                        Program.Timer(1);
                        Console.Clear();
                        break;
                }
            }

        }
    }
}
