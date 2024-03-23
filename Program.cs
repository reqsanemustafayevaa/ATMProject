using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //istifadeciden hansi prosesi yerine yetireceyini sorusuruq:
            //1-pulu  goruntuleme
            //2-Pul Cekme
            //3-pul kocurme
            //q-cixis
            int money = 1000;
            Console.WriteLine("ATM-e xos geldiniz.");
            Console.WriteLine("Etmek istediyiniz prosesi secin:");
            string secim=Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Money: " + money);
                Console.ReadLine();
            }
            else if(secim == "2")
            {
                Console.WriteLine("cekmek istediyiniz miqdari daxil edin:");
                int pulmiqdari=Convert.ToInt32(Console.ReadLine());
                if(pulmiqdari<=money)
                {
                    Console.WriteLine("Qalan pul: " + (money - pulmiqdari));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("movcud puldan cox pul ceke bilmezsiniz!");
                    Console.ReadLine();
                }
               
            }
            else if( secim == "3")
            {
                Console.WriteLine("kocurmek istediyiniz pul miqdarini daxil edin:");
                int kocurulecekpul=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("yeni pulunuz: " + (money+ kocurulecekpul));
                Console.ReadLine();
            }
            else if( secim == "q") 
            {
                Console.WriteLine("ATM-den cixis edilir...");
                Console.WriteLine("Cixis edildi.Xos gunler.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("zehmet olmasa kecerli nomre giriniz");
                Console.ReadLine();
            }
        }
    }
}
