using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        Console.Write("Masukkan nilai");
        int nilai = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan Persentase Kehadiran:");
        int kehadiran=Convert.ToInt32(Console.ReadLine());
        if (nilai>=75 && kehadiran >=80)
        {
            Console.WriteLine("Status: LULUS");

        }
        else
        {
            Console.WriteLine("status TIDAK LULUS");
            
        }
    }
}