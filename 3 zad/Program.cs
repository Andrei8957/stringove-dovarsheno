using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _3_zad
{
    internal class Program
    {
        static string Naobratno(string duma)
        {
            string resultat=" ";

            for (int i = duma.Length - 1; i >= 0; i--)
            {
                resultat += duma[i];
            }

            return resultat;
        }
        static void Main(string[] args)
        {
            Console.Write("napishi niz ot bukvi - ");
            string duma=Console.ReadLine();
            Console.WriteLine(Naobratno(duma));
        }
    }
}
