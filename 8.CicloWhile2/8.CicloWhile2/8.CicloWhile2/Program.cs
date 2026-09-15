using System;

namespace _8.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.
            int sumNum = 0;
            int numero = 0;
            Console.WriteLine("introduzca un numero entero");
            numero = int.Parse(Console.ReadLine());
            
            while (numero > 0) 
            {
                sumNum += numero;
                Console.WriteLine("introduzca otro numero entero");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"la suma de los numeros ingresados es {sumNum}");

        }
    }
}
