using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Oyun_Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>Hoşgeldiniz<<<<<<\n");

            Console.Write("İsminiz >>");
            string isim = Console.ReadLine();

            Console.Write("Soyadınız >>");
            string soyad = Console.ReadLine();

            Console.Write("İsmin karakter sayısı  {0}\nSoyadın karakter sayısı  {1}\n", isim.Length, soyad.Length);
            int a = isim.Length; int b = soyad.Length;

            Console.WriteLine("Dogum tarihini sırasıyla gün,ay,yıl şeklinde giriniz:");

            Console.Write("Gün -->");
            int gun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ay -->");
            int ay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yıl --> ");
            int yıl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************************************************");

            
            int puan = 0;

            if (a == b)
            {
                puan += 25;
                

            }
            else if (a < b)
            {
                puan -= 10;
                

            }
            else if (a > b)
            {
                puan += 50;
                

            }
           

            if (ay <= 6)
            {
                puan += 30;
                
            }
            else if (ay > 6 && ay <= 12)
            {
                puan -= 20;
                
            }
            int hak = 10;
            while (hak >= 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    Random rastgele = new Random();
                    int zar = rastgele.Next(1, 7);

                    Console.Write("Gelen zar >> {0}\n", zar);
                    if (zar == 1)
                    {
                        puan -= 75;
                        break;
                    }
                    else if (zar == 6)
                    {
                        puan += 100;
                        break;
                    }
                }
                hak--;
            }
            
            Console.WriteLine("\nPuanın >> {0}", puan);
            if (puan < 500)
            {
                Console.WriteLine("Maalesef oyunu kaybettiniz.\nTekrar deneyiniz.");

            }
            else if (puan >= 500)
            {

                Console.WriteLine("Tebrikler oyunu kazandınız.\nYine bekleriz");
            }



        }    
    }
}
