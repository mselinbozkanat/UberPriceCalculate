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
//Belli de�eleri d��ar�dan al�yoruz.
            int ride_time = 0;
            int ride_distance = 0;
            double[] cpmilee = new double[4] { 1.1, 1.8, 2.3, 3.5 };
            double[] cpminutee = new double[4] { 0.2, 0.35, 0.4, 0.45 };          

//Kullan�c�dan ald���m�z bilgilerin do�rulu�unu kontrol edip ona g�re i�lem yapt�raca��z
            do
            {
                Console.WriteLine("S�re Giriniz :");
                 ride_time = Convert.ToInt32(Console.ReadLine());
                if (9 >= ride_time || ride_time >= 51)
                {
                    Console.WriteLine("Yanl�� S�re Girildi. Tekrar Giriniz :");
                }
            } while (9 >= ride_time || ride_time >= 51);
            do
            {
                Console.WriteLine("Mesafe Giriniz :");
                ride_distance = Convert.ToInt32(Console.ReadLine());
                if (4 >= ride_distance || ride_distance >= 21)
                {
                    Console.WriteLine("Yanl�� Mesafe Girildi. Tekrar Giriniz :");
                }
            } while (4 >= ride_distance || ride_distance >= 21);
            for (int i = 0; i <4; i++)
            {
                UcretHesapla(ride_time, cpminutee[i], ride_distance,  cpmilee[i]);

            }
            

            Console.ReadKey();

        }
//�creti hesaplayaca��m�z metotumuzu yaz�yoruz
        public static double UcretHesapla(int rt, double cpminute, int rd, double cpmile) {


            double sonuc = ((rt*cpminute)+(rd*cpmile));
            Console.WriteLine(sonuc);


            return sonuc;
        }
    }
}
