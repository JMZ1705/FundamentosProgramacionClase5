using System;

namespace _19.ProgramacionModular2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static void MostrarMenu() //Es un procedimiento proque no devuelve ningun valor
        {
            Console.WriteLine("---------------Menu---------------");
            Console.WriteLine(" 1   Suma                2   Resta");
            Console.WriteLine("3   Multiplicacion      4  Division");
            Console.WriteLine("0    Salir");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ingrese una opcion del menu");

        }

        static int CapturarOpcion()//Funcion, si devuelve valor
        {

            return int.Parse(Console.ReadLine());
        }

        static float Suma()
        {
            float numero = 0;
            float suma = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea sumar mas numeros");
                respuesta = char.Parse(Console.ReadLine());

            }while (respuesta == 's');
            return suma;
        }
        static float Multiplicacion()
        {
            float numero = 0;
            float multi = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                multi *= numero;
                Console.WriteLine("Desea multiplicar mas numeros");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');
            return multi;
        }

        static float Resta()
        {

            Console.WriteLine("Ingrese el numero 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1-numero2;
        }
        static float Division()
        {

            Console.WriteLine("Ingrese el numero 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }
        static void RealizarOperaciones(int opcion)
        {
            while (opcion!=0)
            {
                     switch(opcion)
                        {
                        case 1:
                            Console.WriteLine($" la SUMA de los numeros ingresados es {Suma()}");
                            break;
                         case 2:
                            Console.WriteLine($"la RESTA de los dos numeros ingresados es {Resta()}");
                            break ;
                        case 3:
                            Console.WriteLine($"la MULTIPLICACION de los numeros ingresados es {Multiplicacion()}");
                            break;
                        case 4:
                             Console.WriteLine($"la DIVISION de los dos numeros ingresados es {Division()}");
                             break;
                        }
            }
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
            opcion = CapturarOpcion();
           
        }
    }
}
