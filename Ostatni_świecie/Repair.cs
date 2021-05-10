using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Repair
    {
        public static void RepairShip()
        {
            bool start = true;
            if (Stats.RepairCost == 0)
            {
                start = false;
                Console.WriteLine("Nie ma nic do naprawy.");
                Console.ReadLine();
                Console.Clear();
            }
            
            while (start == true)
            {
                Console.Write("Bateria: ");
                for (int i = 0; i < Stats.Battery / 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#");
                }
                for (int i = 0; i < 15 - (Stats.Battery / 10); i++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("#");
                }
                Console.ResetColor(); Console.WriteLine("");
                Console.Write("Info:"); Console.Write(Stats.WitchEvent + "\n");

                Console.WriteLine("|===========================================================|");
                Console.WriteLine("| Podaj ile czasu chcesz przeznaczyć na naprawę: (Exit = 0) |");
                Console.WriteLine("|===========================================================|");
                try
                {

                    int choise = int.Parse(Console.ReadLine());
                    if (choise > Stats.Battery / 10 || choise > Stats.RepairCost / 10)      //Zabezpieczenie aby nie naładować więcej niż limit siły, sprawdzam baterię oraz koszt naprawy
                    {
                        Console.Clear();
                        Console.WriteLine("Zastanów się co chcesz zrobić. Spróbuj jeszcze raz.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                   else if (choise == 0)
                    {
                        Console.Clear();
                        start = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("|=========================================================|");
                        Console.WriteLine("| Naprawa w toku.. Naciśnij dowolny klawisz aby zakończyć |");
                        Console.WriteLine("|=========================================================|");
                        Console.ReadLine();
                        Stats.Strength += choise * 10;
                        Stats.RepairCost -= choise * 10;
                        Stats.Battery -= choise * 10;
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
