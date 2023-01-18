using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan16 // Note:depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[15];
            int i;
            double osszeg=0,db=0;
            Random RanGen = new Random();
            for(i=0;i<15;i++)
            {
                tomb[i] = RanGen.Next(150,221);
                osszeg=osszeg+tomb[i];
                db++;
            }
            for(i=0;i<15;i++)
            {
                Console.WriteLine("{0}. random szam: {1}",i+1,tomb[i]);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Random szamok osszege: {0}, es az atlaga: {1:0.00}",osszeg,osszeg/db);
        }
    }
}
