using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfacetask.Interfaces;

namespace Interfacetask.Classes
{
    public class Porche : Arac, IOzellik
    {
        public void hızlıgit(string marka)
        {
            Console.WriteLine(marka +" "+"Çok hızlı Gidiyor");
        }
    }
}
