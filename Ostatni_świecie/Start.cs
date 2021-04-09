using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Ostatni_świecie
{
    class Start
    {
        public void AtlasIntro()
        {
            for (int i = 0; i < 25; i++) 
            {
                Console.Write("#");
                Thread.Sleep(55);
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sys. Atlas booting..");
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("Sys. Atlas booting  ");
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.WriteLine("Downloading ILM (Intergalactic Light Map)");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(30);
            }
            Console.Clear();

            Thread.Sleep(1250);

            Console.Write("  #############################   \n");
            Console.Write("  #############   #############   \n");
            Thread.Sleep(300);
            Console.Write("  ###########   #   ###########   \n");
            Console.Write("  ##########   ###   ##########   \n");
            Thread.Sleep(300);
            Console.Write("  #########   #####   #########   \n");
            Console.Write("  #######                ######   \n");
            Thread.Sleep(300);
            Console.Write("  #######   #########   #######   \n");
            Console.Write("  ######   ###########   ######   \n");
            Thread.Sleep(300);
            Console.Write("  #####   #############   #####   \n");
            Console.Write("  ####   ###############   ####   \n");
            Thread.Sleep(300);
            Console.Write("  ##     ###############     ##   \n");
            Console.Write("  #############################   \n");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Witaj w PKP Programie Kontroli Pozagalaktycznej Atlas.");
            Console.WriteLine("");
        }
    }
}
