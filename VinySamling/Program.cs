using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class Program
    {
        public static bool endProgram = true;
        static void Main(string[] args)
        {
            ImportFiles.PathCreator();
            GUI.StartGui();
            
            while (true)
            {
                
                while (endProgram)
                {
                    
                    
                    Console.Clear();
                    GUI.HeadGui();
                    Database.Choice();
                }
                
                endProgram = true;
            }
        }

        public static void Timer(double seconds)
        {
            {
                double sec = seconds;
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(sec));
                    return;
                });
                t.Wait();

            }
        }

        //public static void Restart()
        //{
        //    Environment.Exit(0);
        //    ImportFiles.FileChoice();
        //    Console.Clear();
        //    GUI.HeadGui();
        //    Database.Choice();
        //}

        }
}
