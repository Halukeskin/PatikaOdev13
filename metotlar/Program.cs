using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b= 3;

            Console.WriteLine(a+b);

            int sonuc = topla (a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
        }
        static int topla(int deger1, int deger2)
        {
            return(deger1 + deger2);
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int deger1, int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1 + deger2;
        }
    }
}
