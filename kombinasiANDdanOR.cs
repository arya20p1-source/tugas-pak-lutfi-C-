using System;
class Program
{
    static void Main()
    {
        Console.Write("Apakah siswa?(true/false):");
        bool siswa = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Apakah guru?(true/false):");
        bool guru = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Memiliki kartu akses?(true/false):");
        bool kartuAkses = Convert.ToBoolean(Console.ReadLine());
        if((siswa || guru)&& kartuAkses)
        {
            Console.WriteLine("Akses laboratarium DITERIMA.");

        }
        else
        {
            Console.WriteLine("Akses laboratarium DITOLAK.");
        }
    }
}