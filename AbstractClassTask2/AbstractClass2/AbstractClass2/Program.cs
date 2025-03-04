// See https://aka.ms/new-console-template for more information
using AbstractClass2.Abstracts;

GenelMudur gm = new GenelMudur();
Mudur mu= new Mudur();
Programci pr= new Programci();
Stajyer st=new Stajyer();

double toplammaas = 0.0;
toplammaas += gm.KacParaMaas();
toplammaas += mu.KacParaMaas();
toplammaas += pr.KacParaMaas();
toplammaas +=st.KacParaMaas();
Console.WriteLine("Toplam Verilen Maaş:" + " " + toplammaas + " " + "TL");