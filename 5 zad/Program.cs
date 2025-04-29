using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_zad
{
    internal class Program
    {
        static void Suma(string ParviNiz, string VtoriNiz)
        {
            int exit = 0;
            int PoMalkiqNiz = 0;
            if (ParviNiz.Length < VtoriNiz.Length)
            {
                PoMalkiqNiz = ParviNiz.Length;
            }
            else
            {
                PoMalkiqNiz = VtoriNiz.Length;
            }
            for (int i = 0; i < PoMalkiqNiz; i++)
            {
                exit = exit + (ParviNiz[i] * VtoriNiz[i]);
            }
            if (ParviNiz.Length < VtoriNiz.Length)
            {
                for (int i = PoMalkiqNiz; i < VtoriNiz.Length; i++)
                {
                    exit = exit + VtoriNiz[i];
                }
            }
            else
            {
                for (int i = PoMalkiqNiz; i < ParviNiz.Length; i++)
                {
                    exit = exit + ParviNiz[i];
                }
            }
            Console.WriteLine($"Rezultatyt e {exit}");
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Vavedi dva razlichni niza na edin red");
            string[] nachalo = Console.ReadLine().Split(' ');
            string VtoriNiz = nachalo[1];
            string ParwiNiz = nachalo[0];
            Suma(ParwiNiz, VtoriNiz);
        }
        
    }
}
