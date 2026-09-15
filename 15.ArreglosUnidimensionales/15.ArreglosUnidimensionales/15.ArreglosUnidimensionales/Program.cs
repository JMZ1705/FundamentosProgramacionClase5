using System;


namespace _15.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*      //Arreglos Unidimensionales = vectores
                  int[] numeros = new int[5];//Con los [] ya sabemos que es un vector, new para crear un objeto a partir de una clase, el numero en los segundos [] nos inican el rango
                  numeros[0] = 10;
                  numeros[1] = 56;
                  numeros[2] = 22;
                  numeros[3] = 45;// en la posicion 4 con indice 3, porque los indices empiezan en 0 pero la posicion en 1.
                  numeros[4] = 102;//Solo hasta el indice 4, porque el rango es de 5 posiciones

                  Console.WriteLine($"el numero almacenado en la posicion 2 con indice 3 es {numeros[2]}");
                  //Otras formas de declarar e inicializar vectores
                  char[] simbolos = new char[] {'#', '$', 'o','u','i'};
                  bool[] valoresVerdaderos = {true, false, true, true, false, false, true, false};

                  //recorrer para almacenar datos
                  string[] nombres = new string[7];
                  for (int i=0; i<7; i++)
                  {
                      Console.WriteLine($"ingrese el nombre para P{i+1}: I{i}");
                      nombres[i] = Console.ReadLine();
                  }
                  Console.Clear();//Limpia la consola de todo lo que estaba escrito
                  //Recoger para recuperar
                  for (int i = 0; i<nombres.Length; i++)//esta i es distinta  a la anterior porque el contexto es distinto, .Length 
                  {
                      Console.Write($"{nombres[i]} |");
                  }
      */


            //Crear un arreglo "numeros" de 100 elementos asignar el numero 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en la pantalla
            /*            int[] numeros = new int[100];
                        for(int i=0; i<100; i++)
                        {
                            numeros[i] = 10;
                        }
                        for (int i=0; i < numeros.Length; i++)
                        {
                            Console.Write($" {numeros[i]} |");
                        }*/

            //Algoritmo que permita solicitar 10 numeros, los cuales seran almacenados en un arreglo, al final debe visualizarse el promedio de esos numeros
            float sumNum = 0;
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero");
                numeros[i] = int.Parse(Console.ReadLine());
                sumNum += numeros[i];
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} |");
               
            } 
            Console.WriteLine($"\nEl promedio de los numeros ingresados es {sumNum / 10}");
        }
    }
}
