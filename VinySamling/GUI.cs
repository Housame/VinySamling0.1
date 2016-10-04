using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class GUI
    {
        public static void Start()
        {
            StartGui();
            HeadGui();
        }

        static void StartGui()
        {
            Console.WriteLine(@"###                                                                                                                         ");
            Console.WriteLine(@" #   #####   ####       #    #   ####   #####       ####   #    #  #       #   #      #    #  #    #   ####   #   ####      ");
            Console.WriteLine(@" #     #    #           ##   #  #    #    #        #    #  ##   #  #        # #       ##  ##  #    #  #       #  #    #     ");
            Console.WriteLine(@" #     #     ####       # #  #  #    #    #        #    #  # #  #  #         #        # ## #  #    #   ####   #  #          ");
            Console.WriteLine(@" #     #         #      #  # #  #    #    #        #    #  #  # #  #         #        #    #  #    #       #  #  #          ");
            Console.WriteLine(@" #     #    #    #      #   ##  #    #    #        #    #  #   ##  #         #        #    #  #    #  #    #  #  #    #     ");
            Console.WriteLine(@"###    #     ####       #    #   ####     #         ####   #    #  ######    #        #    #   ####    ####   #   ####      ");
            Program.Timer(3);
            Console.Clear();
            Console.WriteLine(@"###                                                                                                         ");
            Console.WriteLine(@" #   #####   ####       #    #   ####   #####       ####   #    #  #       #   #        ##    #####   ##### ");
            Console.WriteLine(@" #     #    #           ##   #  #    #    #        #    #  ##   #  #        # #        #  #   #    #    #   ");
            Console.WriteLine(@" #     #     ####       # #  #  #    #    #        #    #  # #  #  #         #        #    #  #    #    #   ");
            Console.WriteLine(@" #     #         #      #  # #  #    #    #        #    #  #  # #  #         #        ######  #####     #   ");
            Console.WriteLine(@" #     #    #    #      #   ##  #    #    #        #    #  #   ##  #         #        #    #  #   #     #   ");
            Console.WriteLine(@"###    #     ####       #    #   ####     #         ####   #    #  ######    #        #    #  #    #    #   ");
            Program.Timer(3);
            Console.Clear();
            Console.WriteLine(@" ###                                                                                                 ");
            Console.WriteLine(@" #   #####   ####         ##         ####    ####   #    #  #    #  #    #  #    #  #  #####  #   # ");
            Console.WriteLine(@" #     #    #            #  #       #    #  #    #  ##  ##  ##  ##  #    #  ##   #  #    #     # #  ");
            Console.WriteLine(@" #     #     ####       #    #      #       #    #  # ## #  # ## #  #    #  # #  #  #    #      #   ");
            Console.WriteLine(@" #     #         #      ######      #       #    #  #    #  #    #  #    #  #  # #  #    #      #   ");
            Console.WriteLine(@" #     #    #    #      #    #      #    #  #    #  #    #  #    #  #    #  #   ##  #    #      #   ");
            Console.WriteLine(@"###    #     ####       #    #       ####    ####   #    #  #    #   ####   #    #  #    #      #   ");
            Program.Timer(3);
            Console.Clear();
        }

        public static void ByeByeGui()
        {
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
        }

        public static void ShowListGui()
        {
            Console.WriteLine("          ##       ####  ######  ########    ###    ##    ## ");
            Console.WriteLine("          ##        ##  ##    ##    ##      ## ##   ###   ## ");
            Console.WriteLine("          ##        ##  ##          ##     ##   ##  ####  ## ");
            Console.WriteLine("          ##        ##   ######     ##    ##     ## ## ## ## ");
            Console.WriteLine("          ##        ##        ##    ##    ######### ##  #### ");
            Console.WriteLine("          ##        ##  ##    ##    ##    ##     ## ##   ### ");
            Console.WriteLine("          ######## ####  ######     ##    ##     ## ##    ## ");
        }

        static void HeadGui()
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
            Console.WriteLine("        **                                     1. Visa din Vinylsamling                                               **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                          2. Lägga till                                                     **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                           3. Redigera                                                      **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                             4.Ta bort                                                      **");
            Console.WriteLine("        **                                                                                                            **");
            Console.WriteLine("        **                                                                                                            **");
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
