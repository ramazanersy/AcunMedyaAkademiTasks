using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndCondition.Calisanlar
{
    public abstract class Calisan
    {
        public string adi;
        public string soyadi;
        public string mesleği;
        public string departman;
        public abstract double KacparaMaas();
    }
}
