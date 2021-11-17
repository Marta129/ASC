
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat
{
    class automat_asc
    {
        static void Main(string[] args)
        {
            int a, suma = 0, rest = 0;
            Console.WriteLine("Puteti introduce 5 bani,10 bani sau 25 de bani.");
            Console.WriteLine("Soldul curent este 0/20");
            while (suma < 20)
            { 
                Input:
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if(a==5 || a==10 || a==25)
                    {  Console.Clear();
                        suma += a;
                        Console.WriteLine($"Soldul curent este {suma}/20");
                      
                    }
                    else
                    {   
                        Console.Clear();
                        Console.WriteLine("Suma introdusa nu este acceptata de aparat");
                        Console.WriteLine("Puteti introduce 5 bani,10 bani sau 25 de bani.");
                        Console.WriteLine($"Soldul curent este {suma}/20");
                    }
                }
                catch
                {
                    goto Input;
                   
                }
                

            }
            if(suma!=20)
            {
                rest = suma - 20;
            }
            Console.Clear();
            Console.WriteLine($"Cafeaua dumneavoastra este gata,iar restul este {rest} bani");
            Console.ReadLine();
        }
    }
}

