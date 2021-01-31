using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.ID = "134554323132432";
                musteri1.Name = "ziya";
                musteri1.Salary = 3000;
            }

            Musteri musteri2 = new Musteri();
            {
                musteri2.ID = "1324567654321345";
                musteri2.Name = "sultan";
                musteri2.Salary = 8000;
            }

            Musteri musteri3 = new Musteri();
            {
                musteri3.ID = "1345678765432123";
                musteri3.Name = "tolga";
                musteri3.Salary = 5500;
            }

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            //ilk olarak ekliyorum sisteme
            musteriManager.Add(musteri1);

            //Simdi listeliyorum
            musteriManager.List(musteri1);

            //En son olarakda siliyorum 
            musteriManager.Delete(musteri1);
        }
    }
}
