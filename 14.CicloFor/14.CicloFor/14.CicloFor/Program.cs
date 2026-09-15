using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que permita imprimir por pantalla los números múltiplos de 5, el usuario debe ingresar por el teclado el rango de números a evaluar. 
            int porCinco = 1;

            Console.WriteLine("ingrese el numero de multiplos de 5 que desea");
            porCinco = int.Parse(Console.ReadLine());
            for(int multiplo=0; multiplo<=porCinco; multiplo++)
            {
                Console.WriteLine($"{multiplo} X 5 = {multiplo*5}");
            }
        }
    }
}
