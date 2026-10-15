using System;
using System.Diagnostics;

namespace Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //1Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
             diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
 pantalla los números de menor a mayor.
 Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
 ingresar números diferentes. 
 */
           float num1 = 0;
            float num2 = 0;
            float num3 = 0;

            Console.WriteLine("Ingrese valor 1");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor 2");
            num2= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor 3");
            num3 = float.Parse(Console.ReadLine());

            if(num1!=num2 && num1!=num3 && num2!=num3)
            {
                if(num1>num2)
                {
                    if (num1>num3)
                    {
                        if (num2 > num3)
                        {
                            Console.WriteLine(num1 + "Es el numero mayor, seguido por " + num2 + "y por último " + num3);
                        }
                        else 
                        {
                            Console.WriteLine(num1 + "Es el numero mayor, seguido por " + num3 + "y por último " + num2);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{num3} es el mayor, seguido por {num1} y por último {num2}");
                    }
                }
                else
                {
                    if (num2>num3)
                    {
                        if(num1>num3)
                        {
                            Console.WriteLine($"{num2} es el mayor, seguido por {num1} y por último {num3}");
                        }
                        else
                        {
                            Console.WriteLine($"{num2} es el mayor, seguido por {num3} y por último {num1}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{num3} es el mayor, seguido por {num2} y por último {num1}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Se deben ingresar números diferentes entre sí");
            }
        }
    }
}
