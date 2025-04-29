using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("vavedi niza - ");
                string niz = Console.ReadLine();
                string proverka = "";
                bool rezult = true;
                Compare(niz, rezult, proverka);
            }
            static void Compare(string niz, bool exit, string sravnenie)
            {
                for (int i = niz.Length - 1; i >= 0; i--)
                {
                    sravnenie = sravnenie + niz[i];
                }
                if (sravnenie != niz)
                {
                    exit = false;
                }
                else
                {
                    exit = true;
                }
                Console.WriteLine(exit);
            
        }
    }
}
