using System;

namespace donguler_while_forech
{
    class Program
    {
        static void Main(string[] args)
        {
            //While döngüsü
            // 1'den başlayarak consoldan girilen sayıya kadar(sayı dahil) ortalama hesaplayan program yazın.
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayı = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayı)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayac);
            // 'a' dan 'z'ye kadar olan harfleri yazdır
            char a ='a';
            while(a<='z')
            {
                Console.Write(a);
                a++;
            }
           Console.WriteLine("***Foreach");
           string[] arabalar = {"Bmv","Audi","Mercedes","Ford","WW"};
           foreach (var araba in arabalar)//var tipi belli olmayan genel void gibi obje alır
           {
               Console.WriteLine(araba);
           }
        }
    }
}