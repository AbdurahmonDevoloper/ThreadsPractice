using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa8
    {
        public static void Run()
        {
            Thread fonOqimi = new Thread(AvtoSaqlash);
            fonOqimi.IsBackground = true;
            fonOqimi.Start();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"[Main]: Foydalanuvchi kod yozmoqda... {i}");
                Thread.Sleep(1500);
            }
            Console.WriteLine("[Main]: Dastur tugadi.");
        }

        static void AvtoSaqlash()
        {
            while (true)
            {
                Thread.Sleep(2000);
                Console.WriteLine(" [FON]: Ma'lumotlar avtomatik saqlandi!");
            }
        }
    }
}