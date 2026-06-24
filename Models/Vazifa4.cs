using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa4
    {
        static List<int> ombor = new List<int>();
        static readonly object omborQulf = new object();
        static bool ishlabChiqarishTugadi = false;

        public static void Run()
        {
            ombor.Clear(); 
            ishlabChiqarishTugadi = false;

            Thread producer = new Thread(IshlabChiqaruvchi);
            Thread consumer = new Thread(Istemolchi);

            producer.Start(); consumer.Start();
            producer.Join(); consumer.Join();
        }

        static void IshlabChiqaruvchi()
        {
            for (int i = 1; i <= 10; i++)
            {
                lock (omborQulf)
                {
                    ombor.Add(i);
                    Console.WriteLine($" Ishlab chiqaruvchi mahsulot qo'shdi: {i}");
                }
                Thread.Sleep(100);
            }
            ishlabChiqarishTugadi = true;
        }

        static void Istemolchi()
        {
            while (!ishlabChiqarishTugadi || ombor.Count > 0)
            {
                lock (omborQulf)
                {
                    if (ombor.Count > 0)
                    {
                        int maxsulot = ombor[0];
                        ombor.RemoveAt(0);
                        Console.WriteLine($" Iste'molchi mahsulotni oldi: {maxsulot}");
                    }
                }
                Thread.Sleep(150);
            }
        }
    }
}