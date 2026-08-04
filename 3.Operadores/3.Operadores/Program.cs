using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numéricos
            //Incremento decremento
            int dato1 = 0;
            dato1++; //Incremento en 1 unidad; Dato1 + 1
            dato1--;//Decremento en 1 unidad; Dato1 - 1
            dato1 += 15; //dato1 = dato1 + 15
            dato1 -= 14; //dato1 = dato1 - 14
            dato1 *= 3; //dato1 = dato1 * 3
            dato1 /= 2; //dato1 = dato1 / 2

            //Orden de evaluación de operadores aritméticos
            int dato2 = 4 * 3 / 2; //* y / están en el mismo nivel, pero se lee primero * porque está a la izquierda
            int dato3 = 5 / 2 * 4;
            int dato4 = 4 * (5 / 2);
            int dato5 = 3 - 1 * (4 / 2);
            //OPERADORES LÓGICOS
            //CONJUNCIÓN - AND - Y - &&
            Console.WriteLine("Tabla de la conjunción");
            Console.WriteLine("V && V =" + (true && true));
            Console.WriteLine("V && F =" + (true && false));
            Console.WriteLine("F && V =" + (false && true));
            Console.WriteLine("F && F =" + (false && false));

            //DISYUNCIÓN - OR - O - ||

            Console.WriteLine("Tabla de la disyunción");
            Console.WriteLine("V || V =" + (true || true));
            Console.WriteLine("V || F =" + (true || false));
            Console.WriteLine("F || V =" + (false || true));
            Console.WriteLine("F || F =" + (false || false));

            //NEGACIÓN
            bool dato6 = true;
            bool dato7 = !dato6;

            //OPERADORES DE COMPARACIÓN
            bool dato8 = 5 > 4; //Verdadero
            bool dato9 = 10 >= 9; //Verdadero
            bool dato10 = 1002 == 102; // Falso
            bool dato11 = 0 != 1; //0 es diferente a 1, verdadero
            bool dato12 = 4 < 5 && 3 == 0; //Verdadero && Falso = Falso
            bool dato13 = 0 != 2 && dato8 || dato9; // Verdadero && Verdadero ||verdadero, Verdadero && falso, falso

        }
    }
}
