using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ÖRNEĞİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yatirilacak_tutar = 0;
            int bakiye= 700;

            Console.WriteLine("Atm ye hoşgeldiniz");
            Console.WriteLine("Lütfen bir işlem seçiniz");
            Console.WriteLine("1- Bakiye Görüntüle");
            Console.WriteLine("2- Para Çek");
            Console.WriteLine("3-Para Yatır");
            Console.WriteLine("4-Çıkış Yap");

            string secim=Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz:" + bakiye);
                    Console.ReadLine();
                    break;

                 case "2":
                    Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                    //int = Convert.ToInt32(Console.ReadLine());
                    int cekilecek_tutar= Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_tutar > bakiye) 
                    {
                        Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                        Console.ReadLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz:" + ( bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                    yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni Bakiyeniz:" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("Hesabınızdan Çıkış Yapılıyor İyi Günler");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                    Console.ReadLine();
                    break;







            }











        }
    }
}
