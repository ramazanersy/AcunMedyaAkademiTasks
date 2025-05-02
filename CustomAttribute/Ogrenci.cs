using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    public class Ogrenci
    {
        [ZorunluAlan("Öğrenci adı boş geçilemez.")]
        public string Ad { get; set; }

        [ZorunluAlan("Öğrenci soyadı boş geçilemez.")]
        public string Soyad { get; set; }

        [ZorunluAlan("Öğrenci bölümü boş geçilemez.")]
        public string Bolum { get; set; }
    }

}
