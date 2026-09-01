using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CicloDoWhile
            /* int contador = 1;
             int acumulador = 0;

             do 
             {
                 acumulador += contador;//al acumulador se le suma el contador.
                 contador++;
             }
             while ( contador <=5);
             Console.WriteLine($"La suma de los cinco primeros numúmeros enteros es {acumulador}");
 */
            //Algoritmo que solicita un número y genera su correspondiente tabla de multiplicar desde el 1 hasta el 10.
            //Y así sucesivamente hasta que el usuaru¿io ya no desee continuar generando tablas de multiplicar

            /*  int contador = 1;
              int acumulador = 1;
              int numero = 0;
              string confirmacion;

              do
              {
                  contador = 1;
                  acumulador = 0;
                  Console.WriteLine("\nIngrese un número del 1 al 10");
                  numero = int.Parse(Console.ReadLine());
                  do
                  {

                      acumulador = contador;
                      Console.WriteLine($"\n {numero} * {acumulador} = {numero * acumulador}");
                      contador++;

                  }
                  while (contador <= 10);
                  Console.WriteLine("\n¿Desea ingresar otro número? escriba si o no");
                  confirmacion = Console.ReadLine();
              }while (confirmacion=="si");
              Console.WriteLine("\nGracias por jugar, bitch");*/

            //Crear un algoritmo que permita calcular y mostrar lo numeros primos hasta el numero 100.

            int contador=1;
            int contador2 = 1;
            int divisiones = 0;
            do
            {
                do
                {
                    if(contador%contador2==0)//mientra el residuo de la división sea 0, es decir, si es divisible por un entero
                    {
                        divisiones++;
                    }
                    contador2++;//aumenta el valor del divisor
                } while (contador2<=contador);//Solamente hasta que el divisor alcance al dividendo
                if(divisiones==2)//Para que sea primo solo debe ser divisible por 1 y por si mismo
                {
                    Console.WriteLine($"{contador}");
                }
                contador2 = 1;//Devolver las variables a los valores originales para volver a iniciar el ciclo cpon cada numero
                divisiones = 0;
                contador++;//continua con el siguiente numero
            }
            while (contador <= 100);
        }
    }
}
