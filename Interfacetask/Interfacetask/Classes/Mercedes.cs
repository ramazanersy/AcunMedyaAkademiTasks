using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfacetask.Interfaces;

namespace Interfacetask.Classes
{
    public class Mercedes : Arac, IOzellik,IOzellik2
    {
        public void denizdeyuz(string marka)
        {
            Console.WriteLine(marka+" "+"Denizde Yüzüyor.");
        }

        public void hızlıgit(string marka)
        {
           Console.WriteLine(marka+" "+"Çok hızlı Gidiyor.");
        }
    }
}
