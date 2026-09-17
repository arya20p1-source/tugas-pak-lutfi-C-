using System;

namespace BelajarOperatorArimatika
{
    class Program
    {
        static void Main(string[]args)
        {
             int angka1 = 17;
             int angka2 = 5;
             //1.penjumlahan (+)
             int hasilTambah = angka1 + angka2;
             Console.WriteLine($"{angka1}+{angka2}= {hasilTambah}");
             //2.pengurangan(-)
             int hasilKurang = angka1 - angka2;
             Console.WriteLine($"{angka1}-{angka2}={hasilKurang}");
             //3.perkalian(*)
             int hasilKali = angka1 * angka2;
             Console.WriteLine($"{angka1}={angka2}");
             //4.pembagian Bulat(/)
             //karena kedua variabel bertipe int, hasilnya dibulatkan ke bawah
             int hasilBagiBulat = angka1 / angka2;
             Console.WriteLine($"{angka1}/{angka2}(Inter Devision)={hasilBagiBulat}");
             //5.Pembagian Pecahan (Type Casting)
             //Diubah ke double agar menghasilkan angka di belakang koma
             double hasilBagiDesimal = (double)angka1 / angka2;
             Console.WriteLine($"{angka1} / {angka2} (floaring Point) = {hasilBagiDesimal}");
             //6.Modulus/Sisa Bagi (%)
             int sisaBagi=angka1 % angka2;
             Console.WriteLine($"{angka1}%{angka2}(sisa Bagi)={sisaBagi}");
             //7.Increment(++) dan Dacrement (--)
             int nilai =10;
             nilai++;//Menambah nilai Sebesar 1 (nilai sekarang: 11)
             Console.WriteLine($"Nilai setelah increment(++):{nilai}");
             nilai--;//Mengurangi nilai sebesar 1 (nilai sekarang: 10)
             Console.WriteLine($"Nilai setelah decrement(--):{nilai}");
             


            
        }
       


    }
}