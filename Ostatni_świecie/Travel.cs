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

            while(start == true)
            {
                Console.Clear();
                Console.WriteLine("|================================|");
                Console.WriteLine("| Podaj czas podróży (Exit = 0): |");
                Console.WriteLine("|================================|");

                try
                {
                    int time = Convert.ToInt32(Console.ReadLine());

                    if(time >= (batery / 10))
                    {
                        Console.Clear();
                        Console.WriteLine("Nie masz wystarczająco energii! Wciśnij dowolny przycisk i spróbuj ponownie.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if(time == 0)
                    {
                        start = false;
                        Console.Clear();
                    }
                    else
                    {
                        Random(ref batery);

                        km += time * 10;
                        batery -= time * 10;
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
        public void Animation(ref int batery, int draw, int draw_time) // draw_time = moment w którym ma się odpalić event w czasie podróży 
        {
            Events events = new Events();
            //Animacja
            events.DrawEvent(ref batery, draw);
        }
        public void Random(ref int batery)
        {
            Random random = new Random();
            
            int draw = random.Next(2);

            if(draw != 0)
            {
                int draw_time = random.Next(10) + 1;

                Animation(ref batery, draw, draw_time);
            }
        }
    }
}
