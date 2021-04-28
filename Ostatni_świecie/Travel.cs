using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Travel
    {
        
      
        public void Traveling(ref int batery, ref int km)
        {
            bool start = true;
            TravelLoop tl = new TravelLoop();
            while (start == true)
            {
                Console.Clear();
                Console.WriteLine("|================================|");
                Console.WriteLine("| Podaj czas podróży (Exit = 0): |");
                Console.WriteLine("|================================|");

                try
                {
                     int time = Convert.ToInt32(Console.ReadLine());

                    if (time >= (batery / 10))
                    {
                        Console.Clear();
                        Console.WriteLine("Nie masz wystarczająco energii! Wciśnij dowolny przycisk i spróbuj ponownie.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (time == 0)
                    {
                        start = false;
                        Console.Clear();
                    }
                    else
                    {
                        tl.tLoop(ref km, ref batery, ref time);
                        
                        start = false;
                        Console.Clear();
                    }
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Tak to się nie uda! Podaj ile godzin. Wciśnij dowolny przycisk i spróbuj ponownie.");
                    Console.ReadKey();
                    Console.Clear();
                }


            }
        }

    }
}
