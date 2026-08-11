using System;


namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condiconales anidados
            //Hacer un programa que compare 3 numeros escritos por el usuario y diga cual es el mayor
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Escribe el número 1");
            num1 = int.Parse(Console.ReadLine()); //Otra forma de hacer la conversión del string que viene por defecto a int
            Console.WriteLine("Escribe el número 2");
            num2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Escribe el número 3");
            num3 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                //Verdarera
                if(num1>num3)
                {
                    Console.WriteLine("El número 1 es el mayor");
                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                }
            }
            else
            {
                //Falsa
                if (num2>num3)
                {
                    Console.WriteLine("El número 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                }
            }
        }
    }
}
