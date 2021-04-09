using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Charging
    {
        public void ChargeBatteries()
        {
            Menu g = new Menu();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine(g.batery);
                Console.WriteLine(g.km);
                Console.Write("|===============================|\n");
                Console.Write("| Podaj czas ładowania baterii: |\n");
                Console.Write("|===============================|\n");
                try
                {
                    int time = Convert.ToInt32(Console.ReadLine());
                    //g.batery += 10 * time;
                    Console.WriteLine(time);
                    g.batery = time;
                    if (g.batery>100)
                    {
                        g.batery = 100;
                    }
                    check = false;
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Tak to się nie uda! Podaj ile godzin.");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }
            
            

        }
    }
}
