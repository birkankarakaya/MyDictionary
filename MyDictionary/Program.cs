using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Kullanicilar = new MyDictionary<int, string>();

            Kullanicilar.Add(1, "Birkan");
            Kullanicilar.Add(2, "Ece");
            Kullanicilar.Add(3, "Emre");
            Kullanicilar.Add(4, "Sıla");

            Console.WriteLine("\nToplam Kayıt Sayısı: " + Kullanicilar.Count);

            Kullanicilar.Add(5, "Engin");
            Console.WriteLine("\nToplam Kayıt Sayısı: " + Kullanicilar.Count);
        }
    }
}
