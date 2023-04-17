using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Program
    {
        static void Serie1(int n)
        {
            int pos=1, r=0;
            Console.WriteLine("Serie 1:");
            for (int i = 1; i <= n; i++) {
                r = pos * i;
                Console.WriteLine(r);
                pos=r;
            }

        }
        static void Serie2(int n)
        {
            int pos = 1, r=0;
            Console.WriteLine("Serie 2:");
            for (int i = 0; i <= n; i++)
            {
                r = pos * 2;
                Console.WriteLine(r);
                pos = r;
            }

        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese número de elementos en la serie");
            n=int.Parse(Console.ReadLine());
            Serie1(n);
            Serie2(n);
            Console.ReadKey();
        }
    }
}
