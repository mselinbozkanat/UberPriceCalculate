using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
//Belli deðeleri dýþarýdan alýyoruz.
            int ride_time = 0;
            int ride_distance = 0;
            double[] cpmilee = new double[4] { 1.1, 1.8, 2.3, 3.5 };
            double[] cpminutee = new double[4] { 0.2, 0.35, 0.4, 0.45 };          

//Kullanýcýdan aldýðýmýz bilgilerin doðruluðunu kontrol edip ona göre iþlem yaptýracaðýz
            do
            {
                Console.WriteLine("Süre Giriniz :");
                 ride_time = Convert.ToInt32(Console.ReadLine());
                if (9 >= ride_time || ride_time >= 51)
                {
                    Console.WriteLine("Yanlýþ Süre Girildi. Tekrar Giriniz :");
                }
            } while (9 >= ride_time || ride_time >= 51);
            do
            {
                Console.WriteLine("Mesafe Giriniz :");
                ride_distance = Convert.ToInt32(Console.ReadLine());
                if (4 >= ride_distance || ride_distance >= 21)
                {
                    Console.WriteLine("Yanlýþ Mesafe Girildi. Tekrar Giriniz :");
                }
            } while (4 >= ride_distance || ride_distance >= 21);
            for (int i = 0; i <4; i++)
            {
                UcretHesapla(ride_time, cpminutee[i], ride_distance,  cpmilee[i]);

            }
            

            Console.ReadKey();

        }
//Ücreti hesaplayacaðýmýz metotumuzu yazýyoruz
        public static double UcretHesapla(int rt, double cpminute, int rd, double cpmile) {


            double sonuc = ((rt*cpminute)+(rd*cpmile));
            Console.WriteLine(sonuc);


            return sonuc;
        }
    }
}
