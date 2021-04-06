using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Ostatni_świecie
{
    class Save
    {
        public void SaveStats(int batery, int km )
        {//int batery, int km
              string path = @"D:\pliki\projekty\C#\Projekt OWW\Ostatni_świecie\Stats.txt";
            using (StreamWriter sw = File.CreateText(path))
            {

                sw.Write(batery);
                sw.WriteLine("");
                sw.Write(km);
                
            }

          
                
            
        }
    }
}
