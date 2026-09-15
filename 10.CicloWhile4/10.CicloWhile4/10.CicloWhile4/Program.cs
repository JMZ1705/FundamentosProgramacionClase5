using System;


namespace _10.CicloWhile4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. Utilizar la función Random para elegir el número aleatorio.

            Random rnd = new Random();
            int numeroA = rnd.Next(1, 100);
            int guess = 0;

            Console.WriteLine("Intenta adivinar un numero entero entre 1 y 100");
            guess = int.Parse(Console.ReadLine());

            while(guess != numeroA)
            {
                if(guess<numeroA)
                {
                    Console.WriteLine("INTENTA CON UN NUMERO MAYOR");
                }
                if (guess > numeroA)
                {
                    Console.WriteLine("INTENTA CON UN NUMERO MENOR");
                }
                guess= int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Felicitaciones, el numero era {numeroA}");
        }
    }
}
