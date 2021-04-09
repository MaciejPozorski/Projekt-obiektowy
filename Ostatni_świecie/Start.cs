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
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sys. Atlas booting..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Sys. Atlas booting");
                Thread.Sleep(500);
                Console.Clear();
            }
            for (int i = 0; i < 25; i++)
            {
                Console.Write("#");
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.Write("        ############         ");
            Console.Write("     #################       ");
            Console.Write("    #####################      ");
            Console.Write("    ######################     ");
            Console.Write("   #########################    ");
            Console.Write("  ###########################   ");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");

        }
    }
}
