using System;
using ThreadsPractice.Models;

class Program
{
    static void Main()
    {
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("    C# MULTITHREADING AMALIY VAZIFALAR MENYUSI  ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Parallel Counter (Parallel hisoblagich)");
            Console.WriteLine("2. Sum Numbers (Parallel yig'indi)");
            Console.WriteLine("3. Shared Bank Account (Parallel pul yechish)");
            Console.WriteLine("4. Producer-Consumer (Ishlab chiqaruvchi va iste'molchi)");
            Console.WriteLine("5. Thread-Safe Logger (Faylga xavfsiz yozish)");
            Console.WriteLine("6. Sequential Execution (Ketma-ket bajarish)");
            Console.WriteLine("7. Prime Number Finder (Tub sonlarni qidirish)");
            Console.WriteLine("8. Background Autosave (Orqa fonda saqlash)");
            Console.WriteLine("9. Download Manager (Yuklab olish simulyatsiyasi)");
            Console.WriteLine("10. Ticket Booking System (Chipta band qilish)");
            Console.WriteLine("11. Bonus Challenge: Traffic Light (Svetofor simulyatsiyasi)");
            Console.WriteLine("0. Chiqish");
            Console.WriteLine("==================================================");
            Console.Write("Vazifa raqamini kiriting: ");

            string input = Console.ReadLine();
            if (input == "0") break;

            Console.WriteLine("\n--------------------------------------------------");
            
            switch (input)
            {
                case "1": Vazifa1.Run(); break;
                case "2": Vazifa2.Run(); break;
                case "3": Vazifa3.Run(); break;
                case "4": Vazifa4.Run(); break;
                case "5": Vazifa5.Run(); break;
                case "6": Vazifa6.Run(); break;
                case "7": Vazifa7.Run(); break;
                case "8": Vazifa8.Run(); break;
                case "9": Vazifa9.Run(); break;
                case "10": Vazifa10.Run(); break;
                case "11": BonusVazifa.Run(); break;
                default: Console.WriteLine(" Noto'g'ri buyruq!"); break;
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\nDavom etish uchun Enter bosing...");
            Console.ReadLine();
        }
    }
}