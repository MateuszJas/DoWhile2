using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            Console.WriteLine("Podaj liczbę: ");
            liczba = System.Int32.Parse(Console.ReadLine());
            int i = 0;

            do
            {
                i++;
                if (liczba % i == 0)
                    Console.WriteLine(i);
                



            } while (liczba != i);

            
            Console.ReadKey();



        }
    }
}
