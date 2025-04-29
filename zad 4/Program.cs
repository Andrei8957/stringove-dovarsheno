using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("wywedi duma - ");
            string duma=Console.ReadLine();
            for (int i = 0; i < duma.Length; i++)
            {
                Console.WriteLine($"Character: {duma[i]}, Unicode: /u{((int)duma[i]):X4}");
            }
        }
    }
}
