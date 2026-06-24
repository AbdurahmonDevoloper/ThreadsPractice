using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class BonusVazifa
    {
        static bool ishlamoqda = true;
        static int chiroqNavbati = 0;
        static readonly object svetoforQulf = new object();

        public static void Run()
        {
            ishlamoqda = true; chiroqNavbati = 0;

            Thread qizil = new Thread(() => Tizim(0, "QIZIL ", 2000));
            Thread sariq = new Thread(() => Tizim(1, "SARIQ ", 1000));
            Thread yashil = new Thread(() => Tizim(2, "YASHIL ", 2000));

            qizil.Start(); sariq.Start(); yashil.Start();

            Console.WriteLine("🚥 Svetofor ishladi. To'xtatish uchun Enter tugmasini bosing...");
            Console.ReadLine();
            ishlamoqda = false;
        }

        static void Tizim(int id, string chiroqNomi, int vaqt)
        {
            while (ishlamoqda)
            {
                if (chiroqNavbati == id)
                {
                    Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {chiroqNomi}");
                    Thread.Sleep(vaqt);

                    lock (svetoforQulf)
                    {
                        chiroqNavbati = (chiroqNavbati + 1) % 3;
                    }
                }
                else
                {
                    Thread.Sleep(50);
                }
            }
        }
    }
}