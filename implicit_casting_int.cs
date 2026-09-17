using System;
/*
1.  Implicit Casting (Berharap)
    - Implicit casting adalah konversial tipe data yang dilakukan secara otomatis
       oleh compitor.
    - Biasanya terjadi ketika mengkonversi tipe daya yang lebih kecil
      ke tipe data yang leboh besar.
    - Contoh: byte -> short -> int -> long -> float -> double -> decimal
    - keutungan dari implicit casting adalah
           a. tidak perlu menulis kode tembahan untuk melakukan konversi 
                karena compiler akan dilakukan secara otomatis.
           b.  mengurangi kemungkinan kesalahan konversi tipe data
                karena compiler akan melakukan pengecekan tipe data secara otomatis.
           c.  meningkatan keterbacaan kode karena tidak perlu menulis kode konversi secara eksplisit.
           d.  meningkatkan performa program karena tidak perlu melakukan konversi tipe data secara manual.
           e.  meningkatkan keamanan program karena compiler akan melakukan pengecekan tipe data secara otomatis.
           f. meningkatkan fleksibilitas program karena kita dapat menggukan tipe data yang lebih besar
               tanpa harus melakukan konversi secara manual. 


*/

class Program
{
     static void Main()
        { 
         byte nilaiByte = 100;
         short nilaiShort = nilaiByte;
         int nilaiInt = nilaiShort;
         long nilaiLong = nilaiInt;
         float nilaiFloat = nilaiLong;
         double nilaiDouble = nilaiFloat;
         decimal nilaiDecimal = (decimal)nilaiDouble;


          Console.WriteLine("Byte       : " + nilaiByte + " " + nilaiByte.GetType());
          Console.WriteLine("Short     : " + nilaiShort + " " +  nilaiShort.GetType());
          Console.WriteLine("Int   : " + nilaiInt   + " " +  nilaiInt.GetType());
          Console.WriteLine("Long  : " + nilaiLong + " " + nilaiLong.GetType());
          Console.WriteLine("Float : " + nilaiFloat + " " + nilaiFloat.GetType());
          Console.WriteLine("Double : " + nilaiDouble + " " + nilaiDouble.GetType());
          Console.WriteLine("Decimal : " + nilaiDecimal + " " + nilaiDecimal.GetType());

    }

}
       

