using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace convertSHA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string converted = Console.ReadLine();
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(converted));

            var nb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                nb.Append(bytes[i].ToString("x2"));
            }
            Console.WriteLine(nb.ToString().ToUpper());
            Console.ReadKey();
        }
    }
}
