using System;
class Program
{
    static void Main()
    {
      Console.Write("Nilai teori");
      int teori = Convert.ToInt32(Console.ReadLine());
      Console.Write("Nilai Pratik: ");
      int praktik= Convert.ToInt32(Console.ReadLine());
      if(teori <75 || praktik < 75 )
        {
            Console.WriteLine("Murid ikut REMEDIAL.");

        }     
        else
        {
            Console.WriteLine("Murid tidak perlu remidial");
        }
    }
}