using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class InputController
    {
        public static string NameController()
        {

            do
            {
                Console.Write(" Var vänlig och skriv in namnet på skivan: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    ClearOneLine();
                    Console.WriteLine("Var vänlig skriv in ett giltigt namn!!");
                    Program.Timer(1);
                    ClearOneLine();
                }
            } while (true);

        }

        public static string AlbumController()
        {

            do
            {
                Console.Write(" Var vänlig och skriv in Vilet album är det: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {
                   
                    return input;
                }
                else
                {
                    ClearOneLine();
                    Console.WriteLine("Var vänlig skriv in ett giltigt Album!!");
                    Program.Timer(1);
                    ClearOneLine();


                }
            } while (true);

        }

        public static string ArtistController()
        {

            do
            {
                Console.Write(" Var vänlig och skriv in namnet på artisten: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {
                    
                    return input;
                }
                else
                {
                    ClearOneLine();
                    Console.WriteLine("Var vänlig skriv in ett giltigt artist namn!!");
                    Program.Timer(1);
                    ClearOneLine();

                }
            } while (true);

        }

        public static int YearController()// input måste vara 4 siffror
        {
            int input=0;
            do
            {
                Console.Write(" Var vänlig och skriv in vilket år släpptes skivan: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    ClearOneLine();
                    Console.WriteLine("Var vänlig skriv in ett giltigt year!!");
                    Program.Timer(1.5);
                    
                    
                };

                if (input >= 1948 && input <= 2016)
                {

                    return input;
                }
                else if (input > 2016)
                {
                    ClearOneLine();
                    Console.WriteLine("Idag är {0} nu!! Var vänlig skriv in ett giltigt year!!", DateTime.Now.ToString("yyyy"));
                    Program.Timer(1.5);
                    ClearOneLine();

                }
                else
                {
                    ClearOneLine();
                    Console.WriteLine("VinylSkivor kom först året 1948!! Var vänlig skriv in ett giltigt year!!");
                    Program.Timer(1.5);
                    ClearOneLine();


                }
            } while (true);

        }

        public static void ClearOneLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

    }
}
