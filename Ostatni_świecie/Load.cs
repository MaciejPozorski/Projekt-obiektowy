using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ostatni_świecie
{

    class Load
    {
        
    
        public static void LoadSave()
        {
            string path = "stats.txt";                         //nazwa pliku z statami
            if (File.Exists(path))                             //sprawdzamy czy plik isnieje
            {
                string[] read = File.ReadAllLines(path);       //odczytujemy i zapisujemy pliki kolejno z każdej lini
                Stats.Battery = Convert.ToInt32(read[0]);
                Stats.Km = Convert.ToInt32(read[1]);
                Stats.Strength = Convert.ToInt32(read[2]);
                Stats.RepairCost = Convert.ToInt32(read[3]);
                Stats.WitchEvent = (string)read[4];
                Menu.MainMenu(); 
                Menu.intro = false;
            }
            else
            {
                Console.WriteLine("Nie posiadasz zapisu gry!");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
