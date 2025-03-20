using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading.Constructors
{
    public class Araba
    {
        public Kapı kapı;
        public Kasa kasa;
        public Marka marka;
        public Pencere pencere;
        public Fiyat Fiyat;
        public Model model;
        public Araba(Kapı kapı,Kasa kasa, Marka marka,Pencere pencere,Fiyat fiyat,Model model)
        {
            this.kapı=kapı;
            this.kasa=kasa; 
            this.marka=marka;
            this.pencere=pencere;
            this.Fiyat = fiyat;
            this.model=model;
           
        }
    }
}