using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan30 // Note:depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[] tomb = new int[13];
            Random rangen = new Random();
            int i=0, sorsz=0,sorsz2=0;
            for(i=0;i<13;i++)
            {
                tomb[i]=rangen.Next(2,131);
            }
            for(i=0;i<13;i++)
            {
                Console.WriteLine("Generalt szam: {0}",tomb[i]);
            }
            i=0;
            while(i<=12 && tomb[i]>39)
            {
                i++;
            }
            if(i<=12)
            {
                while(tomb[i]>39)
                {
                    i++;
                }
                sorsz=i;
                Console.WriteLine("40kg alatti sorszama: {0}",sorsz);
            }
            else
            {
                Console.WriteLine("NINCS");
            }
            Console.WriteLine("\n\n");
            int[] tomb2 = new int[5];
            int e;
            for(e=0;e<5;e++)
            {
                Console.Write("{0}-Adj meg egy szamot: ",e);
                tomb2[e] = Convert.ToInt32(Console.ReadLine());
            }
            for(e=0;e<5;e++)
            {
                Console.WriteLine("A tomb {0}. eleme: {1}",e,tomb2[e]);
            }
            e=0;
            while(tomb2[e]>39)
            {
                e++;
            }
            Console.WriteLine("40kg alatti sorszama: {0}",e);
        }
    }
}
