using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndCondition.Araclar
{
    public abstract class Arac
    {
        public string marka = "";
        public string model = "";
        public int kapisayisi = 0;
        public int camsayisi = 0;
        public string yakitturu = "";
        public abstract double KacLitre();
    }
}
