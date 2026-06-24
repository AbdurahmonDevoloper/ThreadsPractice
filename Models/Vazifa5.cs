using System;
using System.IO;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa5
    {
        static readonly object faylQulf = new object();
        static string faylNomi = "log.txt";

        public static void Run()
        {
            if (File.Exists(faylNomi)) File.Delete(faylNomi);

            Thread[] oqimlar = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                int id = i + 1;
                oqimlar[i] = new Thread(() => Yozuvchi(id));
                oqimlar[i].Start();
            }
            foreach (var t in oqimlar) t.Join();
            Console.WriteLine(" 'log.txt' fayliga hamma narsa xavfsiz yozildi.");
        }

        static void Yozuvchi(int oqimId)
        {
            for (int i = 1; i <= 100; i++)
            {
                lock (faylQulf)
                {
                    File.AppendAllText(faylNomi, $"Oqim {oqimId} - Xabar {i}\n");
                }
            }
        }
    }
}