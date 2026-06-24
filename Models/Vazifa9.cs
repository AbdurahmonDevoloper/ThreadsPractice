using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa9
    {
        public static void Run()
        {
            Thread[] yuklashlar = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                string fayl = $"Fayl_{i + 1}.zip";
                yuklashlar[i] = new Thread(() => FaylYukla(fayl));
                yuklashlar[i].Start();
            }

            foreach (var t in yuklashlar) t.Join();
            Console.WriteLine(" Hamma fayllar muvaffaqiyatli yuklandi!");
        }

        static void FaylYukla(string nomi)
        {
            Random r = new Random();
            for (int foiz = 0; foiz <= 100; foiz += 20)
            {
                Console.WriteLine($" {nomi}: {foiz}% yuklandi.");
                Thread.Sleep(r.Next(100, 400));
            }
        }
    }
}