using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfacetask.Interfaces;

namespace Interfacetask.Classes
{
    public class Bmw : Arac, IOzellik,IOzellik2, IOzellik3
    {
        public void denizdeyuz(string marka)
        {
           Console.WriteLine(marka+" "+"Denizde yüzüyor.");
        }

        public void havadauc(string marka)
        {
            Console.WriteLine(marka+" "+"Havada Uçuyor");
        }

        public void hızlıgit(string marka)
        {
            Console.WriteLine(marka+" "+"Çok Hızlı gidiyor.");
        }
    }
}
