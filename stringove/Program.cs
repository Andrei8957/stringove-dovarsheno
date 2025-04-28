using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wywedi chisloto w koqto iskash da preobrazuwash i wywedi chisloto koeto she preobrazuwash");
            string[] nachalo=Console.ReadLine().Split(' ').ToArray();
            int izhodnoChislo=int.Parse(nachalo[0]);
            int chisloZApreobrazuvane=int.Parse(nachalo[1]);
            string gotovoChislo = "";

           while(chisloZApreobrazuvane>0)
            {
                int ostatyk= chisloZApreobrazuvane%izhodnoChislo;
                gotovoChislo = ostatyk + gotovoChislo;
                chisloZApreobrazuvane = chisloZApreobrazuvane / izhodnoChislo;
            }
            Console.WriteLine(gotovoChislo);
        }
    }
}
