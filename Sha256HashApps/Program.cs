using System;

namespace Sha256HashApps
{
    class Program
    {
        static void Main(string[] args)
        {
            string encriptPassword = Sha256Hash.EncriptSha256Hash("shohag");
            Console.WriteLine(encriptPassword);
            Console.ReadKey();
        }
    }
}
