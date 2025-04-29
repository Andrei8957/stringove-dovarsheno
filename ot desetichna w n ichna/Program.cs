using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ot_desetichna_w_n_ichna
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("wywedi chisloto koeto she preobrazuwash i negovata stepen");
            string[] nachalo = Console.ReadLine().Split(' ').ToArray();
            int stepen = int.Parse(nachalo[0]);
            int chisloZApreobrazuvane = int.Parse(nachalo[1]);
            int[] rabota=new int[chisloZApreobrazuvane];
            int rezult = 0;
            int promenliva = 0;
            for (int i= 0; i < rabota.Length; i++)
            {
                rabota[i] = chisloZApreobrazuvane[i];
            }
            for (int i = 0; i < rabota.Length;i++)
            {
                promenliva = rabota[i] * stepen ^ rabota.Length-i;
                rezult += promenliva;
            }
            Console.WriteLine(rezult);
        }
    }
}
