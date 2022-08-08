using System;
namespace Donguler_for_loop
{
    class Program
    {
        static void Main (string[]args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= sayi; i++)
            {
                if (i%2==1)
                Console.WriteLine(i);
            }

            int tektoplam=0;
            int cifttoplam=0;  

            for (int i = 0; i < 1000; i++)
            {
                if(i%2 == 1)
                tektoplam += i;

                else 
                cifttoplam +=i;
            }
            Console.WriteLine("Tek sayılar toplamı: "+tektoplam);
            Console.WriteLine("Çift sayıların toplamı: "+cifttoplam);

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
             if(i==4)
             continue;
             Console.WriteLine(i);   
            }
        }
    }
}