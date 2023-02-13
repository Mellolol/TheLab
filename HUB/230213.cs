using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb13 // Note:depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Legnagyobb kivalasztas tetele:
            int[] tomb = new int[15];
            Random rangen = new Random();
            int i;
            Console.WriteLine("==================================================");
            for(i=0;i<15;i++)
            {
                tomb[i] = rangen.Next(20,51);
            }
            for(i=0;i<15;i++)
            {
                Console.WriteLine("Tomb {0}. eleme: {1}",i,tomb[i]);
            }
            int maxi=0,maxe=tomb[0];
            Console.WriteLine("==================================================");
            for(i=1;i<15;i++)
            {
                if(tomb[i]>maxe)
                {
                    maxi=i;
                    maxe=tomb[i];
                }
            }
            Console.WriteLine("A legnagyobb szam: {0} es annak indexe: {1}",maxe,maxi);
            // ---END---
            // Minimum kivalasztas tetele:
            Console.WriteLine("==================================================");
            int mini=0,mine=tomb[0];
            for(i=1;i<15;i++)
            {
                if(tomb[i]<mine)
                {
                    mini=i;
                    mine=tomb[i];
                }
            }
            Console.WriteLine("A legkisebb szam: {0} es annak indexe: {1}",mine,mini);
            Console.WriteLine("==================================================");
            // ---END---

            int[] block = new int[25];
            int osszeg=0, db=0;
            for(i=0;i<25;i++)
            {
                block[i]=rangen.Next(10,71);
            }
            for(i=0;i<25;i++)
            {
                Console.WriteLine("2. tomb {0}. eleme: {1}",i,block[i]);
            }
            Console.WriteLine("==================================================");
            for(i=0;i<25;i++)
            {
                if(block[i]%3==0 || block[i]%2==0)
                {
                    osszeg=osszeg+block[i];
                }
            }
            for(i=0;i<25;i++)
            {
                if(block[i]%5==0)
                {
                    db++;
                }
            }
            Console.WriteLine("2. tombben talalhato 3al vagy 2el oszthato szamok osszege: {0}",osszeg);
            Console.WriteLine("2. tombben talalhato 5el oszthato szamok: {0}db",db);
            Console.WriteLine("==================================================");
            i=0;
            int sorsz=0;
            while(i<=24 && block[i]%6!=0)
            {
                i++;
            }
            if(i<=24)
            {
                Console.WriteLine("Wan benne 6al oszthato");
                i=0;
                while(block[i]%6!=0)
                {
                    i++;
                }
                sorsz=i;
                Console.WriteLine("6al oszthato szam sorszama: {0}",sorsz);
            }
            else{
                Console.WriteLine("Nincs benne 6al oszthato szam");
            }
            Console.WriteLine("==================================================");
            int maximumi=0,maximume=block[0],minimumi=0,minimume=block[0];
            for(i=1;i<25;i++)
            {
                if(block[i]>maximume)
                {
                    maximumi=i;
                    maximume=block[i];
                }
            }
            for(i=1;i<25;i++)
            {
                if(block[i]<minimume)
                {
                    minimumi=i;
                    minimume=block[i];
                }
            }
            Console.WriteLine("Minimum indexe: {0}, annak erteke: {1},\nMaximum indexe: {2}, annak erteke: {3}",minimumi,minimume,maximumi,maximume);
        }
    }
}
