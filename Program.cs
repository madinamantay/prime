using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i.ToString() + " ");
                }
            }
            Console.ReadKey();
        }
        private static bool isPrime(int n)
        {
            for (int i = 2; i < (int)(n / 2); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
