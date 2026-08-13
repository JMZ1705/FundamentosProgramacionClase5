using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales múltiples
            int respuesta = 0;
            Console.WriteLine("-----------menú-----------");
            Console.WriteLine("1.Opción 1       2.Opción 2");
            Console.WriteLine("3.Opción 3       4.Opción 4");
            Console.WriteLine("5.Opción 5");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Elija una opción del menú");

            switch (respuesta)
            {
                case 1://Uno para cad opción
                    Console.WriteLine("Eligió la opción 1");
                    break;//Solamente ejecuta la oción seleccionada y hasta ahí
                case 2:
                    Console.WriteLine("Eligió la opción 2");
                    break;
                case 3:
                    Console.WriteLine("Eligió la opción 3");
                    break;
                case 4:
                    Console.WriteLine("Eligió la opción 4");
                    break;
                case 5:
                    Console.WriteLine("Eligió la opción 5");
                    break;
                default://Si el usuario pone otra cosa que no esté entre las selccionadas
                    Console.WriteLine("Elija una opción válida");
                    break;

            }    
        }
    }
}
