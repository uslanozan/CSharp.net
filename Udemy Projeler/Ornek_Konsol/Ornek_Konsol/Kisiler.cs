using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Konsol
{
    internal class Kisiler
    {
        public void kisiListesi(string ad)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+" "+ad);
            }
        }
    }
}
