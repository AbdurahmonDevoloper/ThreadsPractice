#  ThreadsPractice — C# Multithreading Project

Ushbu amaliy loyiha C# dasturlash tili va .NET platformasida **Ko'p oqimlilik (Multithreading)** hamda **Oqimlarni sinxronizatsiya qilish (Thread Synchronization)** mavzularini chuqur o'rganish va amaliyotda qo'llash maqsadida yaratildi. Loyiha tarkibida jami 11 ta maxsus vazifa alohida modullar ko'rinishida ishlab chiqilgan.

---

##  Loyiha Arxitekturasi (Clean Architecture)

Loyiha kodlarining tozaligi va oson o'qilishini ta'minlash maqsadida klassik **Clean Architecture** qoidalariga rioya qilingan:
* **`Program.cs`** — Dasturning asosiy kirish nuqtasi va foydalanuvchi uchun interaktiv Menyu tizimi.
* **`Models/`** — Har bir topshiriq uchun alohida yaratilgan klasslar (Vazifa1 dan boshlab BonusVazifagacha). Bu kodning qayta ishlanuvchanligini (maintainability) oshiradi.
* **`ThreadsPractice.csproj`** — Loyiha sozlamalari fayli. Kodda vizual chalg'ituvchi sariq va yashil chiziqlar (warnings) chiqmasligi uchun `Nullable` xossasi o'chirib qo'yilgan (`<Nullable>disable</Nullable>`).

---

## 📋 Amaliy Vazifalar Ro'yxati va Ularning Vazifasi

Dastur ishga tushganda quyidagi interaktiv menyu orqali har bir vazifani alohida sinovdan o'tkazish mumkin:

1. **Parallel Counter (Parallel hisoblagich):** 3 ta alohida oqimning parallel va aralash holatda qanday ishlashini hamda `Thread.Sleep` yordamida protsessor navbatini boshqarishni ko'rsatib beradi.
2. **Sum Numbers (Parallel yig'indi):** 1 dan 1 milliongacha bo'lgan sonlar yig'indisini 4 ta oqimga (Data Partitioning) teng bo'lib yuborib, matematik hisob-kitobni 4 marta tezroq bajaradi.
3. **Shared Bank Account (Parallel pul yechish):** Bir vaqtda umumiy hisobdan pul yechayotgan mijozlar dasturi. `lock` bloki yordamida **Race Condition (Poyga holati)** muammosi hal etilgan.
4. **Producer-Consumer (Ishlab chiqaruvchi va iste'molchi):** Ma'lumot qo'shuvchi va o'chiruvchi oqimlararo hamkorlik. `List<int>` xavfsizligini ta'minlash uchun sinxronizatsiya ishlatilgan.
5. **Thread-Safe Logger (Faylga xavfsiz yozish):** 10 ta oqimning bir vaqtda bitta `log.txt` fayliga parallel yozishi. `IOException (File in use)` xatosini oldini olish uchun fayl tizimi qulflangan.
6. **Sequential Execution (Ketma-ket bajarish):** Oqimlarning parallelizmini vaqtincha cheklab, `t.Join()` metodi yordamida ularni qat'iy tartibda (`t1 -> t2 -> t3`) ishlatish.
7. **Prime Number Finder (Tub sonlarni qidirish):** 100,000 gacha bo'lgan tub sonlarni 4 ta oqim yordamida qidirish. Har bir oqim o'zining shaxsiy xotirasida ishlab, tezlikni maksimal darajaga oshirgan.
8. **Background Autosave (Orqa fonda saqlash):** Matn muharrirlaridagi avto-saqlash tizimi simulyatsiyasi. `IsBackground = true` xossasining ishlash mexanizmini tushuntiradi.
9. **Download Manager (Yuklab olish simulyatsiyasi):** 5 ta faylni brauzer kabi bir vaqtda, bir-birini to'sib qo'ymagan holda (Non-blocking) parallel yuklash jarayoni.
10. **Ticket Booking System (Chipta band qilish):** Kassada chipta sotish tizimi. Kritik biznes mantiqni `lock` bilan himoya qilib, chiptalar soni minusga kirib ketishini to'sadi.
11. **Bonus Challenge: Traffic Light (Svetofor simulyatsiyasi):** Qizil, Sariq va Yashil oqimlarni o'zaro tsiklik navbat (`% 3`) bilan yoqish va dasturni bayroqcha yordamida xavfsiz (Graceful Shutdown) to'xtatish.

---

## 🚀 Loyihani Ishga Tushirish

Loyihani kompyuterda ishga tushirish uchun .NET SDK o'rnatilgan bo'lishi lozim. Terminalda loyiha papkasiga kirib, quyidagi buyruqlarni bering:

```bash
# Loyihani tiklash va ishga tushirish
dotnet run
