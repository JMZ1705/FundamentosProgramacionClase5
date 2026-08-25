using System;


namespace _7.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo While
            //Crear un algoritmo que permita generar los primeros 5 numero positivos y su sumatoria
            /*
                        int contador = 1;
                        int acumulador = 1;

                        while (contador < 5)
                        {
                            contador++;
                            acumulador = contador + acumulador;
                        }
                        Console.WriteLine($"La suma de los 5 primeros numeros positivos es {acumulador}");
            */
            //Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario

            int contador = 1;
            int acumulador = 1;
         
            int numero = 0;

            Console.WriteLine("ingrese un numero entero positivo");
            numero = int.Parse(Console.ReadLine());

            while( contador <= numero)
            {
                
                acumulador = contador * acumulador;
                contador++;
            }
            Console.WriteLine($"El factorial de {numero} es {acumulador}");
        }
    }
}
