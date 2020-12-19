using System;
using System.Text;
using System.Threading;

namespace RandPasswd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Password Length= ");
            var range = Convert.ToInt32(Console.ReadLine());
            var a = new Random();
            var b = a.Next();
            var sb = new StringBuilder();

            for (var i = 0; i <= range; i++)
            {
                var z = a.Next(32, 122);
                var c = Convert.ToChar(z);
                sb.Append(c);
               

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
