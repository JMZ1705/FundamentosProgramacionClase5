using System;


namespace tallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
  pantalla la suma de los elementos de cada columna.*/
            /*
                        float[,] numeros = new float[10, 20];
                        float suma = 0;
                        Random aleatorio = new Random();
                        for (int i=0; i<10; i++)
                        {
                            for(int j=0; j<20; j++)
                            {
                                numeros[i,j] = aleatorio.Next(1, 11);
                            }
                        }

                        for (int i = 0; i < numeros.GetLength(0); i++) 
                        {
                            for (int j = 0; j < numeros.GetLength(1); j++)
                            {
                                Console.Write($"{numeros[i,j]} |");
                            }
                            Console.WriteLine();
                        }

                        for (int j = 0; j < numeros.GetLength(1); j++)
                        {
                            suma = 0;

                            for (int i = 0; i < numeros.GetLength(0); i++)
                            {
                                suma += numeros[i,j];
                            }
                            Console.WriteLine($"la suma de la columna {j+1} es {suma}");
                        }*/


            /* 2.Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa
 caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
 primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
 matriz con el intercambio de filas.*/

            /*    int n;
                int m;
                Console.WriteLine("ingrese el numero de filas");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el numero de columnas");
                m = int.Parse(Console.ReadLine());

                char[,] caracteres = new char[n, m];
                char[,] intercambio = new char[n, m];

                for (int i = 0; i < n; i++) 
                {
                    for(int j = 0; j < m; j++)
                    {
                        Console.WriteLine($"Ingrese un caracter para la  posición {i+1} , {j+1}");
                        caracteres[i,j] = char.Parse(Console.ReadLine());
                        if (i == 0)
                        {
                            intercambio[n-1,j] = caracteres[i,j] ;
                        }
                        if (0<i && i<(n-1))
                        {
                            intercambio[i, j] = caracteres[i, j];
                        }
                        if(i== (n - 1))
                        {
                            intercambio[0, j] = caracteres[i,j];
                        }
                    }
                }

                for(int i=0; i < caracteres.GetLength(0);i++)
                {
                    for(int j=0; j < caracteres.GetLength(1); j++)
                    {
                        Console.Write($"{caracteres[i, j]} |");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine() ;
                for (int i = 0; i < caracteres.GetLength(0); i++)
                {
                    for (int j = 0; j < caracteres.GetLength(1); j++)
                    {
                        Console.Write($"{intercambio[i, j]} |");
                    }
                    Console.WriteLine() ;
                }*/

            /*3.Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de
5x5 llena de números aleatorios.
El algoritmo debe permitir:
 Usa la función Random para generar los números aleatorios.
 Crea un arreglo adicional para almacenar la frecuencia de cada número.
 Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número*/

            /* int[,] aleatorios = new int[5, 5];
             int[,] frecuencia = new int[2, 10];

             Random aleatorio = new Random();

             for (int i = 0; i < 5; i++) 
             {
                 for(int j = 0; j < 5; j++)
                 {

                     aleatorios[i, j] = aleatorio.Next(1, 11);
                 }
             }

             for (int i = 0; i <aleatorios.GetLength(0); i++) 
             {
                 for( int j = 0;j < aleatorios.GetLength(1); j++)
                 {
                     if (aleatorios[i, j] == 1)
                     {
                         frecuencia[1,0]++;
                     }
                     if (aleatorios[i, j] == 2)
                     {
                         frecuencia[1,1]++;
                     }
                     if (aleatorios[i, j] == 3)
                     {
                         frecuencia[1,2]++;
                     }
                     if (aleatorios[i, j] == 4)
                     {
                         frecuencia[1, 3]++;
                     }
                     if (aleatorios[i, j] == 5)
                     {
                         frecuencia[1, 4]++;
                     }
                     if (aleatorios[i, j] == 6)
                     {
                         frecuencia[1, 5]++;
                     }
                     if (aleatorios[i, j] == 7)
                     {
                         frecuencia[1, 6]++;
                     }
                     if (aleatorios[i, j] == 8)
                     {
                         frecuencia[1, 7]++;
                     }
                     if (aleatorios[i, j] == 9)
                     {
                         frecuencia[1, 8]++;
                     }
                     if (aleatorios[i, j] == 10)
                     {
                         frecuencia[1, 9]++;
                     }
                 }
             }

             for (int i = 0; i < aleatorios.GetLength(0); i++)
             {
                 for(int j = 0; j < aleatorios.GetLength(1); j++)
                 {
                     Console.Write($"{aleatorios[i, j]} |");
                 }
                 Console.WriteLine();
             }

             for (int i = 0; i < frecuencia.GetLength(0); i++)
             {
                 for (int j = 0; j < frecuencia.GetLength(1); j++)
                 {
                     if (i == 0)
                     {
                         Console.Write($"{j+1} |");
                     }
                     else
                     {
                         Console.Write($"{frecuencia[i,j]} |");
                     }
                 }
                 Console.WriteLine();
             }*/

            /*4.Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en
posiciones aleatorias.Luego, el algoritmo le debe permitir al usuario intentar adivinar la
posición de una "X".
El algoritmo debe permitir:
 Usar la función Random para colocar las "X" en la matriz.
 Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado.
 Al final sacar un mensaje de éxito o error.Si el mensaje es de éxito mostrar la
posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. */

            char[,] 

        }
    }
}
