using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ostatni_świecie
{
    class Load
    {
        Menu game = new Menu();
        public void LoadStats(ref int batery, ref int km)
        {
            
            string path = "stats.txt";           
            string[] read = File.ReadAllLines(path);
            batery = Convert.ToInt32(read[0]);
            km = Convert.ToInt32(read[1]);
        }
    }
}
