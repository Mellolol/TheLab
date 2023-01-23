using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[16];
            int i=0;
            double db=0,ossz=0, db60=0,ossz60=0;
            Random rangen = new Random();
            for(i=0;i<16;i++)
            {
                tomb[i] = rangen.Next(0,131);
            }
            for(i=0;i<16;i++)
            {
                Console.WriteLine("A/az {0}. ember sulya: {1}kg",i+1,tomb[i]);
            }
            for(i=0;i<16;i++)
            {
                if(tomb[i]>110)
                {
                    db++;
                }
            }
            for(i=0;i<16;i++)
            {
                if(tomb[i]>110)
                {
                    ossz=ossz+tomb[i];
                }
            }
            for(i=0;i<16;i++)
            {
                if(tomb[i]>=60 && tomb[i]<=90)
                {
                    Console.WriteLine("Normal: {0}kg",tomb[i]);
                }
            }
            for(i=0;i<16;i++)
            {
                if(tomb[i]>=60 && tomb[i]<=90)
                {
                    db60++;
                }
            }
            for(i=0;i<16;i++)
            {
                if(tomb[i]>=60 && tomb[i]<=90)
                {
                    ossz60=ossz60+tomb[i];
                }
            }
            Console.WriteLine("{0}db 110kg feletti van a tombben, azok osszege: {1}, es atlag sulya: {2:0.0}kg",db,ossz,ossz/db);
            Console.WriteLine("{0}db 60-90kg kozott van a tombben, azok osszege: {1}, es atlag sulya: {2:0.0}kg",db60,ossz60,ossz60/db60);
            Console.WriteLine("\n\n");
            int[] block = new int[30];
            int p;
            for(p=0;p<30;p++)
            {
                block[p] = rangen.Next(0,11);
            }
            for(p=0;p<30;p++)
            {
                Console.WriteLine("{0}. generalt szam: {1}",p+1,block[p]);
            }
            bool van = false;
            p=0;
            while(p<=29 && block[p]!=5)
            {
                p++;
            }
            if(p<=29)
            {
                Console.WriteLine("VAN BENNE 5");
            }
            else
            {
                Console.WriteLine("NINCS BENNE 5");
            }
            if(p<=29)
            {
                van = true;
            }
            if(van)
            {
                Console.WriteLine("VAN 5");
            }
            else
            {
                Console.WriteLine("NINCS");
            }
            p=0;
            van = false;
            while(p<=29 && block[p]==5)
            {
                p++;
            }
            if(p>29)
            {
                Console.WriteLine("CSAK 5");
            }
            else
            {
                Console.WriteLine("NEM MIND 5");
            }
            bool mind = false;
            if(p>29)
            {
                mind = true;
            }
            if(mind)
            {
                Console.WriteLine("5CSAK 5");
            }
            else
            {
                Console.WriteLine("5NEM MIND 5");
            }
        }
    }
}

