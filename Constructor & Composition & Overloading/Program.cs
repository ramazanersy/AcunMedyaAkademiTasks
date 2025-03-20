// See https://aka.ms/new-console-template for more information
using Constructor___Composition___Overloading.Class;
using Constructor___Composition___Overloading.Constructors;


Kapı kapi = new Kapı(5);
Kasa kasa = new Kasa("Sedan");
Marka marka = new Marka("BMW");
Pencere pencere = new Pencere(5);
Fiyat fiyat = new Fiyat(2000000);
Model model = new Model("X5");
Araba araba = new Araba(kapi, kasa, marka, pencere, fiyat, model);
Console.WriteLine("Arabanın markası:" + araba.marka.markasi+","+"Modeli:"+araba.model.modeli+
    ","+"Kapı Sayısı:"+araba.kapı.kapisayisi+","+"Pencere Sayısı:"
    +araba.pencere.penceresayisi+","+"Kasası:"+araba.kasa.kasaturu+","+"Fiyatı:"+araba.Fiyat.fiyati+"TL");

Matematik m = new Matematik();
int inttoplam=m.topla(3, 5);
double doubletoplam = m.topla(7, 9, 10);
int intcarpim = m.carp(3, 8, 5);
double doublecarpim = m.carp(8, 6);
Console.WriteLine("Integer Sayıların toplamı=" + inttoplam);
Console.WriteLine("Double Sayıların toplamı="+doubletoplam);
Console.WriteLine("Integer Sayıların çarpımı="+intcarpim);
Console.WriteLine("Double Sayıların çarpımı="+doublecarpim);



