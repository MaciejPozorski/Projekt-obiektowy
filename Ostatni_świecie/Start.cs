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
                Thread.Sleep(50);
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("System Atlas booting..");
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("System Atlas booting  ");
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
            Thread.Sleep(2500);
            Console.Clear();
            Console.Write("Witaj w PKP Programie Kont"); Thread.Sleep(150); Console.Write("roli Pozagalaktycznej Atlas.\n"); Thread.Sleep(150);
            Console.Write("Zostałeś wybrany jako operator "); Thread.Sleep(150); Console.Write("humanoidalnego półautomatycznego \n"); Thread.Sleep(150);
            Console.Write("robota-pilota statku naszej korporacji."); Thread.Sleep(150); Console.Write(" Przez dramatycznie pogarszający się\n"); Thread.Sleep(150);
            Console.Write("stan kondycji naszej planety, postanowiliśmy "); Thread.Sleep(150); Console.Write("jak najszybciej wysłać statek z zahibernowanymi osobami\n");
            Console.Write("przygotowanymi do kolonizacji nowej planety."); Thread.Sleep(150); Console.Write(" Jest to jedyny taki statek kosmiczny, \n");
            Console.Write("o napędzie zakrzywiającym grawitację. "); Thread.Sleep(150); Console.Write("Jest to nasza jedyna nadzieja.\n");
            Console.Write("Dlatego teraz przedstawimy Tobie twoje obowiązki. "); Thread.Sleep(150); Console.Write("Robot jest wstanie sam wykonywać pracę, takie jak pilotowanie\n");
            Console.Write("lub konserwacja statku, lecz to tym musisz wydawać mu polecenia. "); Console.Write("Uznaliśmy że taki zabieg zminimalizuje ryzyko niepowodzenia.\n");
            Console.Write("Nie zawiedź nas!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("STAN STATKU \n");
            Console.Write("Załoga:"); Thread.Sleep(500); Console.Write(" 500 osób"); Thread.Sleep(500); Console.Write("  1 Robot ATLAS\n");
            Console.Write("Stan hibernacji:"); Thread.Sleep(500); Console.Write("100% Stabilny\n");
            Console.Write("lokalizacja statku:"); Thread.Sleep(500); Console.Write("1 milion lat świetlnych od Galaktyki Andromedy\n");


        }
    }
         
}
