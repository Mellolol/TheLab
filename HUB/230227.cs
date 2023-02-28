using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb27 // Note:depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*
            int i=0;
            int[] tomb = new int[8];
            for(i=0;i<8;i++)
            {
                Console.Write("{0}.~~Adj meg egy szamot: ",i);
                tomb[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<8;i++)
            {
                Console.WriteLine("Megadott szam: {0}",tomb[i]);
            }
            int elso = 0;
            int utolso = 7;
            int kozepso = 0;
            int melyik = 0;
            do{
                kozepso = (elso+utolso)/2;
                if(11<tomb[kozepso])
                {
                    utolso = kozepso-1;
                }
                else if(11>tomb[kozepso]){
                    elso = kozepso+1;
                }
            }
            while(elso<=utolso && tomb[kozepso]!=11);
            if(elso<=utolso)
            {
                melyik = kozepso;
                Console.WriteLine("A tombben {0} a keresett elem, es {1} az elem indexe",tomb[melyik],melyik);
            }
            else{
                Console.WriteLine("NINCS a tombben 11es");
            }
*/
            int[] tomb = new int[9];
            int i;
            for(i=0;i<9;i++)
            {
                Console.Write("Add meg a {0}. szamot: ",i+1);
                tomb[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------");
            for(i=0;i<9;i++)
            {
                Console.WriteLine("~~{0}. szam: {1}",i+1,tomb[i]);
            }
            Console.WriteLine("----------------------------------------");
            int maxi=0, maxe=tomb[0],mini=0,mine=tomb[0];
            for(i=0;i<9;i++)
            {
                if(tomb[i]>maxe)
                {
                    maxi=i;
                    maxe=tomb[i];
                }
                if(tomb[i]<mine)
                {
                    mini=i;
                    mine=tomb[i];
                }
            }
            Console.WriteLine("A legnagyobb szam: {0}, aminek az indexe: {1}",maxe,maxi);
            Console.WriteLine("A legkisebb szam: {0}, aminek az indexe: {1}",mine,mini);
            Console.WriteLine("----------------------------------------");
            i=0;
            int melyik=0;
            while(i<=8 && tomb[i]!=17)
            {
                i++;
            }
            if(i<=8)
            {
                melyik=i;
                Console.WriteLine("A tombben a {0} a keresett elem, es {1} az elem indexe",tomb[melyik],melyik);
            }
            else{
                Console.WriteLine("Nincs benne a keresett elem");
            }
            Console.WriteLine("----------------------------------------");
            int elso = 0;
            int utolso = 8;
            int kozepso = 0;
            int melyik2 = 0;
            do{
                kozepso = (elso+utolso)/2;
                if(21<tomb[kozepso])
                {
                    utolso = kozepso-1;
                }
                else if(21>tomb[kozepso]){
                    elso = kozepso+1;
                }
            }
            while(elso<=utolso && tomb[kozepso]!=21);
            if(elso<=utolso)
            {
                melyik2 = kozepso;
                Console.WriteLine("A tombben {0} a keresett elem, es {1} az elem indexe",tomb[melyik2],melyik2);
            }
            else{
                Console.WriteLine("NINCS a tombben 11es");
            }

       }
    }
}
