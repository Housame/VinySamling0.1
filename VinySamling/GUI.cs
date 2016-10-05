using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class GUI
    {

        public static void StartGui()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"###                                                                                                                         ");
            Console.WriteLine(@" #   #####   ####       #    #   ####   #####       ####   #    #  #       #   #      #    #  #    #   ####   #   ####      ");
            Console.WriteLine(@" #     #    #           ##   #  #    #    #        #    #  ##   #  #        # #       ##  ##  #    #  #       #  #    #     ");
            Console.WriteLine(@" #     #     ####       # #  #  #    #    #        #    #  # #  #  #         #        # ## #  #    #   ####   #  #          ");
            Console.WriteLine(@" #     #         #      #  # #  #    #    #        #    #  #  # #  #         #        #    #  #    #       #  #  #          ");
            Console.WriteLine(@" #     #    #    #      #   ##  #    #    #        #    #  #   ##  #         #        #    #  #    #  #    #  #  #    #     ");
            Console.WriteLine(@"###    #     ####       #    #   ####     #         ####   #    #  ######    #        #    #   ####    ####   #   ####      ");
            Program.Timer(2);
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"###                                                                                                         ");
            Console.WriteLine(@" #   #####   ####       #    #   ####   #####       ####   #    #  #       #   #        ##    #####   ##### ");
            Console.WriteLine(@" #     #    #           ##   #  #    #    #        #    #  ##   #  #        # #        #  #   #    #    #   ");
            Console.WriteLine(@" #     #     ####       # #  #  #    #    #        #    #  # #  #  #         #        #    #  #    #    #   ");
            Console.WriteLine(@" #     #         #      #  # #  #    #    #        #    #  #  # #  #         #        ######  #####     #   ");
            Console.WriteLine(@" #     #    #    #      #   ##  #    #    #        #    #  #   ##  #         #        #    #  #   #     #   ");
            Console.WriteLine(@"###    #     ####       #    #   ####     #         ####   #    #  ######    #        #    #  #    #    #   ");
            Program.Timer(2);
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"###                                                                                                 ");
            Console.WriteLine(@" #   #####   ####         ##         ####    ####   #    #  #    #  #    #  #    #  #  #####  #   # ");
            Console.WriteLine(@" #     #    #            #  #       #    #  #    #  ##  ##  ##  ##  #    #  ##   #  #    #     # #  ");
            Console.WriteLine(@" #     #     ####       #    #      #       #    #  # ## #  # ## #  #    #  # #  #  #    #      #   ");
            Console.WriteLine(@" #     #         #      ######      #       #    #  #    #  #    #  #    #  #  # #  #    #      #   ");
            Console.WriteLine(@" #     #    #    #      #    #      #    #  #    #  #    #  #    #  #    #  #   ##  #    #      #   ");
            Console.WriteLine(@"###    #     ####       #    #       ####    ####   #    #  #    #   ####   #    #  #    #      #   ");
            Program.Timer(2);
            Console.ResetColor();
            Console.Clear();
        }


        public static void InstructionsGui()
        {
            Console.WriteLine(@"       #### ##    ##  ######  ######## ########  ##     ## ##    ## ######## ####  #######  ##    ## ######## ########  ");
            Console.WriteLine(@"        ##  ###   ## ##    ##    ##    ##     ## ##     ## ##   ##     ##     ##  ##     ## ###   ## ##       ##     ## ");
            Console.WriteLine(@"        ##  ####  ## ##          ##    ##     ## ##     ## ##  ##      ##     ##  ##     ## ####  ## ##       ##     ## ");
            Console.WriteLine(@"        ##  ## ## ##  ######     ##    ########  ##     ## #####       ##     ##  ##     ## ## ## ## ######   ########  ");
            Console.WriteLine(@"        ##  ##  ####       ##    ##    ##   ##   ##     ## ##  ##      ##     ##  ##     ## ##  #### ##       ##   ##   ");
            Console.WriteLine(@"        ##  ##   ### ##    ##    ##    ##    ##  ##     ## ##   ##     ##     ##  ##     ## ##   ### ##       ##    ##  ");
            Console.WriteLine(@"       #### ##    ##  ######     ##    ##     ##  #######  ##    ##    ##    ####  #######  ##    ## ######## ##     ## ");
        }

        public static void AddVinylGui()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"                  \#   #/                                                                   ");
            Console.WriteLine(@"        ##          ###     ######    ######      ###       ######## #### ##       ##    ");
            Console.WriteLine(@"        ##         ## ##   ##    ##  ##    ##    ## ##         ##     ##  ##       ##       ");
            Console.WriteLine(@"        ##        ##   ##  ##        ##         ##   ##        ##     ##  ##       ##       ");
            Console.WriteLine(@"        ##       ##     ## ##   #### ##   #### ##     ##       ##     ##  ##       ##       ");
            Console.WriteLine(@"        ##       ######### ##    ##  ##    ##  #########       ##     ##  ##       ##       ");
            Console.WriteLine(@"        ##       ##     ## ##    ##  ##    ##  ##     ##       ##     ##  ##       ##       ");
            Console.WriteLine(@"        ######## ##     ##  ######    ######   ##     ##       ##    #### ######## ######## ");
            Console.ResetColor();
        }

        public static void EditListGui()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"########  ######## ########  ####  ######   ######## ########     ### ");
            Console.WriteLine(@"##     ## ##       ##     ##  ##  ##    ##  ##       ##     ##   ## ##   ");
            Console.WriteLine(@"##     ## ##       ##     ##  ##  ##        ##       ##     ##  ##   ##  ");
            Console.WriteLine(@"########  ######   ##     ##  ##  ##   #### ######   ########  ##     ## ");
            Console.WriteLine(@"##   ##   ##       ##     ##  ##  ##    ##  ##       ##   ##   ######### ");
            Console.WriteLine(@"##    ##  ##       ##     ##  ##  ##    ##  ##       ##    ##  ##     ## ");
            Console.WriteLine(@"##     ## ######## ########  ####  ######   ######## ##     ## ##     ## ");
            Console.ResetColor();
        }

        public static void FileChoiceGui()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("       * ***************************************************************************************************************");
            Console.WriteLine("         **************************************************************************************************************");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                 Vänligen välj en av alternativen                                           **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                     1. Skapa en Lista                                                      **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                     2. Ladda upp en Lista                                                  **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                     3. Instruktioner                                                       **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("         **************************************************************************************************************");
            Console.WriteLine("        ****************************************************************************************************************");
            Console.ResetColor();
        }

        public static void RemoveVinylGui()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"        ########    ###       ########   #######  ########  ######## ");
            Console.WriteLine(@"           ##      ## ##      ##     ## ##     ## ##     ##    ##    ");
            Console.WriteLine(@"           ##     ##   ##     ##     ## ##     ## ##     ##    ##    ");
            Console.WriteLine(@"           ##    ##     ##    ########  ##     ## ########     ##    ");
            Console.WriteLine(@"           ##    #########    ##     ## ##     ## ##   ##      ##    ");
            Console.WriteLine(@"           ##    ##     ##    ##     ## ##     ## ##    ##     ##    ");
            Console.WriteLine(@"           ##    ##     ##    ########   #######  ##     ##    ##   ");
            Console.ResetColor();
        }

        public static void ByeByeGui()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"          ████████████████████████████████████████");
            Console.WriteLine(@"          ██████┴┬┴███████████████████████████████");
            Console.WriteLine(@"          ████┬┴┬┴┬┴┬█████████████████████████████");
            Console.WriteLine(@"          ███┬┴┬████┴┬████████████████████████████");
            Console.WriteLine(@"          ██┬┴███████┴┬███████████████████████████");
            Console.WriteLine(@"          ██┴┬███████┬┴██┬┴┬████┴┬┴██┬┴┬┴┬████████");
            Console.WriteLine(@"          ██┬████┴┬███┬┴┬┴┬┴┬┴┬┴┬┴┬┴┬┴┬┴┬┴┬┴██████");
            Console.WriteLine(@"          █┬┴███┴┬┴████┬┴███┴┬┴┬███┬┴█████┴┬┴┬████");
            Console.WriteLine(@"          █┴┬███┬┴┬█████████████████████████┬┴┬███");
            Console.WriteLine(@"          █┬┴███┴┬┴██████████████████████████┬┴███");
            Console.WriteLine(@"          █┴┬███┬┴┬█┬┴┴███┬██████┴████┬┴┬█████┬┴██");
            Console.WriteLine(@"          █┬┴███┴┬┴┬┴┬┴┬█┬┴┬████┴┬┴█┴┬┴┬┴┬┴███┴┬██");
            Console.WriteLine(@"          █┴┬███┬┴┬┴┬┴┬┴┬█┬┴┬██┴┬┴█┴┬┴┬┴┬┴┬┴██┬┴██");
            Console.WriteLine(@"          █┬┴███┴┬┴┬██┴┬┴█┴┬┴██┬┴┬█┬┴┬██┴┬┴███┴┬██");
            Console.WriteLine(@"          █┴┬███┬┴┬███┬┴┬█┬┴┬┴█┴┬█┬┴┬┴█┴┬┴┬███┬┴██");
            Console.WriteLine(@"          █┬┴███┴┬┴███┴┬┴██┬┴┬┴┬┴█┴┬┴┬┴┬┴██████┬┴█");
            Console.WriteLine(@"          █┴┬███┬┴┬███┬┴┬██┴┬┴┬┴┬█┬┴┬┴┬███┬┴███┴┬█");
            Console.WriteLine(@"          █┬┴███┴┬┴┬┴┬┴┬┴███┴┬┴┬███┬┴┬┴┬┴┬┴┬███┬┴█");
            Console.WriteLine(@"          █┴┬███┬┴┬┴┬┴┬┴████┬┴┬┴███┴┬┴┬┴┬┴┬┴███┴┬█");
            Console.WriteLine(@"          █┬┴███┴┬┴┬┴┬┴█████┴┬┴█████┴┬┴┬┴┬█████┬██");
            Console.WriteLine(@"          ██┬███████████████┬┴┬███████████████┬┴██");
            Console.WriteLine(@"          ██┴┬█████████████┬┴┬███████████████┬┴███");
            Console.WriteLine(@"          ██┬┴┬████████████┴┬┴███┴┬████████┴┬┴████");
            Console.WriteLine(@"          ███┬┴┬┴┬┴┬┴┬┴┬███┬┴████┬┴┬┴┬┴┬┴┬┴┬┴█████");
            Console.WriteLine(@"          █████┴┬┴┬┴┬┴┬┴████████┬┴██┬┴┬┴┬┴┬███████");
            Console.WriteLine(@"          █████████████┬████████┴┬████████████████");
            Console.WriteLine(@"          █████████████┴┬██████┴┬█████████████████");
            Console.WriteLine(@"          ██████████████┴┬┴██┬┴┬██████████████████");
            Console.WriteLine(@"          ███████████████┴┬┴┬┴┬███████████████████");
            Console.WriteLine(@"          ████████████████████████████████████████");
            Console.ResetColor();
        }

        public static void ShowListGui()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("          ##       ####  ######  ########    ###    ##    ## ");
            Console.WriteLine("          ##        ##  ##    ##    ##      ## ##   ###   ## ");
            Console.WriteLine("          ##        ##  ##          ##     ##   ##  ####  ## ");
            Console.WriteLine("          ##        ##   ######     ##    ##     ## ## ## ## ");
            Console.WriteLine("          ##        ##        ##    ##    ######### ##  #### ");
            Console.WriteLine("          ##        ##  ##    ##    ##    ##     ## ##   ### ");
            Console.WriteLine("          ######## ####  ######     ##    ##     ## ##    ## ");
            Console.ResetColor();
        }

        public static void HeadGui()
        {
            Console.WriteLine(@"                                                                                                                ");
            Console.WriteLine(@"        #    #  #  #    #      #    #  #  #    #  #   #  #        ####     ##    #    #  #       #  #    #   ####      ");
            Console.WriteLine(@"        ##  ##  #  ##   #      #    #  #  ##   #   # #   #       #        #  #   ##  ##  #       #  ##   #  #    #     ");
            Console.WriteLine(@"        # ## #  #  # #  #      #    #  #  # #  #    #    #        ####   #    #  # ## #  #       #  # #  #  #        ");
            Console.WriteLine(@"        #    #  #  #  # #      #    #  #  #  # #    #    #            #  ######  #    #  #       #  #  # #  #  ###     ");
            Console.WriteLine(@"        #    #  #  #   ##       #  #   #  #   ##    #    #       #    #  #    #  #    #  #       #  #   ##  #    #     ");
            Console.WriteLine(@"        #    #  #  #    #        ##    #  #    #    #    ######   ####   #    #  #    #  ######  #  #    #   ####      ");
            Program.Timer(1.5);
        }

        public static void MenuGui()
        {
            Console.WriteLine("        ****************************************************************************************************************");
            Console.WriteLine("         **************************************************************************************************************");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                           Hej och välkommen här nedan har du alternativen                                  **");
            Console.WriteLine("        **                                                                                                            **");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        **                                     1. Visa din Vinylsamling                                               **");
            Console.WriteLine("        **                                                                                                            **");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        **                                     2. Lägga till                                                          **");
            Console.WriteLine("        **                                                                                                            **");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        **                                     3. Redigera                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        **                                     4. Ta bort                                                             **");
            Console.WriteLine("        **                                                                                                            **");
            Console.ResetColor();
            Console.WriteLine("        **                                     5. Ladda upp/ Skapa en annan fil                                       **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                     6. Avsluta                                                             **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("         **************************************************************************************************************");
            Console.WriteLine("        ****************************************************************************************************************");

        }

        public static void BackOrOutGui()
        {
            Console.WriteLine("        ****************************************************************************************************************");
            Console.WriteLine("         **************************************************************************************************************");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                 Vänligen välj en av alternativen                                           **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                     1. Gå tillbaka till meny                                               **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                          2. Avsluta                                                        **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("         **************************************************************************************************************");
            Console.WriteLine("        ****************************************************************************************************************");

        }
    }
}
