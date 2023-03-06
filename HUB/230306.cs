using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mar06 // Note:depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[20];
            Random rangen = new Random();
            int i;
            for(i=0;i<20;i++)
            {
                tomb[i]=rangen.Next(10,41);
            }
            for(i=0;i<20;i++)
            {
                Console.WriteLine("Random generalt szam az 1. tombben: {0}",tomb[i]);
            }
            int[] tomb2 = new int[20];
            Console.WriteLine("----------------------------------------");
            for(i=0;i<20;i++)
            {
                tomb2[i]=tomb[i];
            }
            for(i=0;i<20;i++)
            {
                Console.WriteLine("Masolt szamok: {0}",tomb2[i]);
            }
            int[] tomb3 = new int[20];
            Console.WriteLine("----------------------------------------");
            for(i=0;i<20;i++)
            {
                tomb3[i]=tomb[i]*3;
            }
            for(i=0;i<20;i++)
            {
                Console.WriteLine("Transzformalt szamok: {0}",tomb3[i]);
            }
            int[] negyzet = new int[20];
            Console.WriteLine("----------------------------------------");
            for(i=0;i<20;i++)
            {
                negyzet[i]=(int)Math.Pow(tomb[i],2);
            }
            for(i=0;i<20;i++)
            {
                Console.WriteLine("Generalt szam negyzete: {0}",negyzet[i]);
            }
            double[] aoldal = new double[15];
            double[] boldal = new double[15];
            Console.WriteLine("----------------------------------------");
            for(i=0;i<15;i++)
            {
                aoldal[i]=rangen.NextDouble()*20+20;
            }
            for(i=0;i<15;i++)
            {
                Console.WriteLine("~{0}~Aoldal: {1}",i,aoldal[i]);
            }
            Console.WriteLine("-----");
            for(i=0;i<15;i++)
            {
                boldal[i]=rangen.NextDouble()*10+5;
            }
            for(i=0;i<15;i++)
            {
                Console.WriteLine("~{0}~Boldal: {1}",i,boldal[i]);
            }
            double[] kerulet = new double[15];
            double[] terulet = new double[15];
            Console.WriteLine("----------------------------------------");
            for(i=0;i<15;i++)
            {
                kerulet[i]=(2*aoldal[i])+(2*boldal[i]);
                terulet[i]=aoldal[i]*boldal[i];
            }
            for(i=0;i<15;i++)
            {
            Console.WriteLine("{0}. oldalak kerulete: {1:0.00}, es terulete: {2:0.00}",i,kerulet[i],terulet[i]);
            }
            Console.WriteLine("----------------------------------------");
            int maxkeri=0;
            double maxkere=kerulet[0];
            for(i=0;i<15;i++)
            {
                if(kerulet[i]>maxkere)
                {
                    maxkeri=i;
                    maxkere=kerulet[0];
                }
            }
            Console.WriteLine("A legnagyobb kerulet: {0:0.00}, aminek az indexe: {1},\n hozza tartozo a oldal {2:0.00}, b oldal {3:0.00}, hozza tartozo terulet {4:0.00}",maxkere,maxkeri,aoldal[maxkeri],boldal[maxkeri],terulet[maxkeri]);
            Console.WriteLine("----------------------------------------");
            int minteri=0;
            double mintere=terulet[0];
            for(i=0;i<15;i++)
            {
                if(terulet[i]<mintere)
                {
                    minteri=i;
                    mintere=terulet[i];
                }
            }
            Console.WriteLine("A legkisebb terulet: {0:0.00}, aminek az indexe: {1},\n hozza tartozo a oldal {2:0.00}, b oldal {3:0.00}, hozza tartozo kerulet {4:0.00}",mintere,minteri,aoldal[minteri],boldal[minteri],kerulet[minteri]);
            Console.WriteLine("----------------------------------------");
            i=0;
            int melyik=0;
            while(i<=14 && aoldal[i]>25)
            {
                i++;
            }
            if(i<=14)
            {
                melyik=i;
                Console.WriteLine("Van kisebb a oldal mint 25, indexe: {0}",melyik);
                Console.WriteLine("A oldal: {0:0.00}, b oldal: {1:0.00}, kerulet: {2:0.00}, terulet: {3:0.00}",aoldal[melyik],boldal[melyik],kerulet[melyik],terulet[melyik]);
            }
            else{
                Console.WriteLine("Nincs 25nel kisebb a oldal");
            }

        }
    }
}
