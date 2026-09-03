using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Ciclo for
            int acumulador = 0;//nop es necesario definir el contador pues el for lo controla automaticamente

            for (int contador = 1; contador<=5; contador++)//Importante los ; en la sintaxis 
            {
                acumulador += contador;
            }
            Console.WriteLine($"La suma de los 5 primeros numeros enteros es {acumulador}");*/

            //algoritmo que permita al usuario calcular la factorial de un numero ingresado
            int numero = 0;
            int acumulador = 1;

            Console.WriteLine("Ingrese un numero entero positivo");
            numero = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= numero; contador++)
            {

                acumulador = contador * acumulador;

            }
            Console.WriteLine($"El factorial de {numero} es {acumulador}");
        }
    }
}
