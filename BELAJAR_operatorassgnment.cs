using System;

namespace BelajarOpertorAssignment
{
    class Program
    {
        static void Main(string[]args)
        {
            //1.Assigment Dasar(=)
            //Mengisi nilai 20 ke dalam wadah (variabel) 'angka'
            int angka = 20;
            Console.WriteLine($"Nilai awal angka: {angka}");



            //2.Addition Assignment(+=)
            //Bentuk ringkas dari:angka=angka + 10;
            angka+=10;
            Console.WriteLine($"Setelah angka+=10: {angka}");// Hasil: 30

            //3.Subtraction Assignment (-=)
            //Bentuk ringkas dari: angka = angka-5
            angka-=5;
            Console.WriteLine($"Setelah angka -=5 : {angka}");//Hasil: 25


            //4.Multiplication Assignment(*=)
            //Bentuk ringkas dari: angka= angka*2;
            angka *=2;
            Console.WriteLine($"Setelah angka/=5 : {angka}");//Hasil: 50



            //5.Division Assignment(/=)
            //Bentuk ringkas dari: angka= angka/5;
            angka%=4;
            Console.WriteLine($"Setelah angka%=4 : {angka}");//Hasil: 2 (sisa bagi 10/4)


            //Kasus khusus: Operator+=pada string (penggabungan Teks/ Concatenation)
            string salam ="Selamat Datang";
            salam+=" di jurusan RPL!";
            Console.WriteLine($"\nString Assignment:");
            Console.WriteLine(salam);



            Console.ReadLine();
            

        }
    }
}