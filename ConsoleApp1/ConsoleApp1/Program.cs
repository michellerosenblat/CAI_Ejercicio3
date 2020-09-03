using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();
            bool palindromo = true;

            int i = 0;
            int j = palabra.Length;

            while (palindromo && i < palabra.Length / 2 && j >= 0)
            {
                if (palabra.Substring(i, 1) != palabra.Substring(j-1, 1))
                {
                    palindromo = false;
                }
                else
                {
                    j--;
                    i++;

                }

                

            }

            if (palindromo)
            {
                Console.Write(palabra + " es palindromo");
            }
            else
            {
                Console.WriteLine(palabra + " no es palindromo");
            }
            Console.ReadLine();
        }
    }
}
