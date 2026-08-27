using System;


namespace _9.CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir.
             int CanNum = 0;
             int Contador = 0;
             int NumPos =0;
             int NumNeg =0;
             int Cero = 0;
             int numero =0;
             Console.WriteLine("Ingrese la cantidad de numeros enteros que desea");
             CanNum = int.Parse(Console.ReadLine());

             while (CanNum > Contador) 
             {

                 Console.WriteLine("Ingrese un numero");
                 numero = int.Parse(Console.ReadLine());
                 Contador++;
                 if (numero > 0)
                 {
                     NumPos++;
                 }
                 else
                 {
                     if(numero < 0)
                     {
                         NumNeg++;
                     }
                     else
                     {
                         Cero++;
                     }

                 }

             }

             Console.WriteLine($"La cantidad de Numeros positivos es {NumPos}, la cantidad de numeros negativos es {NumNeg} y la catidad de iguales a cero es {Cero}");*/


            //Escribir un algoritmo que cuente cuantos numeros pares hay en un rango de numeros del 1 al numero n
            int n = 0;
            int contador = 0;
            int divisor = 2;
            int NumPar = 0;
            Console.WriteLine("Ingrese un numero entero positivo");
            n = int.Parse(Console.ReadLine());

            while(1 < contador && contador < n)
            {
                contador++;
                
                if(contador % divisor == 0)
                {
                    NumPar++;
                }
            }
            Console.WriteLine($"La cantidada de numperos pares entre 1 y {n} es {NumPar}");
        }
    }
}
