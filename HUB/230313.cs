using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mar13 // Note:depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---KIVALOTAGAS TETELE---
            /*
            int[] tomb = new int[15];
            int[] negativ = new int[15];
            Random rangen = new Random();
            int i=0,db=0;
            for(i=0;i<15;i++)
            {
                tomb[i]=rangen.Next(-50,51);
            }
            for(i=0;i<15;i++)
            {
                Console.WriteLine("{0}. generalt szam: {1}",i+1,tomb[i]);
            }
            for(i=0;i<15;i++)
            {
                if(tomb[i]<0)
                {
                    negativ[db]=tomb[i];
                    db++;
                }
            }
            // ---KIVALOTAGAS TETEL VEGE---
            Console.WriteLine("----------------------------------------");
            for(i=0;i<15;i++)
            {
                if(negativ[i]!=0)
                {
                 Console.WriteLine("{0}. elem a negativ tombben: {1}",i+1,negativ[i]);
                }
            }
            Console.WriteLine("----------------------------------------");
            db=0;
            int[] otalatt = new int[15];
            for(i=0;i<15;i++)
            {
                if(tomb[i]>=-20 && tomb[i]<=5)
                {
                    otalatt[db]=tomb[i];
                    db++;
                }
            }
            for(i=0;i<15;i++)
            {
                Console.WriteLine("{0}. elem az '5alatt' tombben: {1}",i+1,otalatt[i]);
            }
            Console.WriteLine("----------------------------------------");
            db=0;
            int[] pozitiv = new int[15];
            for(i=0;i<15;i++)
            {
                if(tomb[i]>0 && (tomb[i]%3==0 || tomb[i]%5==0))
                {
                    pozitiv[db]=tomb[i];
                    db++;
                }
            }
            for(i=0;i<15;i++)
            {
                if(pozitiv[i]!=0)
                {
                    Console.WriteLine("{0}. elem a pozitive tombben: {1}",i+1,pozitiv[i]);
                }
            }
            Console.WriteLine("----------------------------------------");
            */
            int[] aoldal = new int[20];
            int[] boldal = new int[20];
            int[] coldal = new int[20];
            int i=0;
            Random rangen = new Random();
            for(i=0;i<20;i++)
            {
                aoldal[i]=rangen.Next(30,61);
                boldal[i]=rangen.Next(20,51);
                coldal[i]=rangen.Next(10,41);
            }
            for(i=0;i<20;i++)
            {
                Console.WriteLine("{0}.~ a oldal: {1}, b oldal: {2}, c oldal: {3}",i+1,aoldal[i],boldal[i],coldal[i]);
            }
            Console.WriteLine("----------------------------------------");
            int[] felszin = new int[20]; // (a*b)*2+(b*c)*2+(a*c)*2
            int[] terfogat = new int[20]; // a*b*c
            for(i=0;i<20;i++)
            {
                felszin[i]=(aoldal[i]*boldal[i])*2+(boldal[i]*coldal[i])*2+(aoldal[i]*coldal[i])*2;
                terfogat[i]=aoldal[i]*boldal[i]*coldal[i];
            }
            for(i=0;i<20;i++)
            {
                Console.WriteLine("{0}.~ felszin: {1}, terfogat: {2}, a oldal: {3}, b odal: {4}, c oldal: {5}",i+1,felszin[i],terfogat[i],aoldal[i],boldal[i],coldal[i]);
            }
            int maxfeli=0,maxfele=felszin[0],minteri=0,mintere=terfogat[0];
            for(i=0;i<20;i++)
            {
                if(felszin[i]>maxfele)
                {
                    maxfeli=i;
                    maxfele=felszin[i];
                }
                if(terfogat[i]<mintere)
                {
                    minteri=i;
                    mintere=terfogat[i];
                }
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("A legkisebb terfogat: {0} indexu {1}, legnagyobb felszin: {2} indexu {3}",minteri,mintere,maxfeli,maxfele);
            int[] felszinnagyobb = new int[20];
            int db=0;
            Console.WriteLine("----------------------------------------");
            for(i=0;i<20;i++)
            {
                if(felszin[i]>8000)
                {
                    felszinnagyobb[db] = felszin[i];
                    db++;
                }
            }
            for(i=0;i<20;i++)
            {
                if(felszinnagyobb[i]!=0)
                {
                 Console.WriteLine("{0}.~ 8000-nel nagyobb felszinu: {1}",i+1,felszinnagyobb[i]);
                }
            }
            Console.WriteLine("----------------------------------------");
            int[] terfogatkisebb = new int[20];
            db=0;
            for(i=0;i<20;i++)
            {
                if(terfogat[i]<40000)
                {
                    terfogatkisebb[db]=terfogat[i];
                    db++;
                }
            }
            for(i=0;i<20;i++)
            {
                if(terfogatkisebb[i]!=0)
                {
                    Console.WriteLine("{0}.~ 40.000-nel kisebb terfogatu: {1}",i+1,terfogatkisebb[i]);
                }
            }
            Console.WriteLine("----------------------------------------");
            int[] felszinoldal = new int[20];
            db=0;
            for(i=0;i<20;i++)
            {
                if(aoldal[i]>40 && boldal[i]<45 && (coldal[i]>=15 && coldal[i]<=35))
                {
                    felszinoldal[db]=felszin[i];
                    db++;
                }
            }
            for(i=0;i<20;i++)
            {
                if(felszinoldal[i]!=0)
                {
                    Console.WriteLine("{0}.~ felszinoldal bigyo: {1}",i+1,felszinoldal[i]);
                }
            }
        }
    }
}
