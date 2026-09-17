using System;
class Program
{
    static void Main()
    {
        string usernameBenar = "admin";
        string passwordBenar = "1234";
        Console.Write("Username:");
        string username = Console.ReadLine();
        Console.Write("Password:");
        string password = Console.ReadLine();
        if (username ==usernameBenar && password == passwordBenar)
        {
            Console.WriteLine("Login berhasil");

        }
        else
        {
            Console.WriteLine("Username atau password salah");

        }
    }
}