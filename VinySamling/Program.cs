﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class Program
    {

        static void Main(string[] args)
        {
            ImportFiles.PathCreator();
            GUI.StartGui();
            ImportFiles.FileChoice();

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



    }
}
