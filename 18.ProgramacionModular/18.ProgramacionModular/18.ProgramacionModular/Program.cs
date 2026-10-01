using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Puto el  que uso IA en el parcial");
            
            MostrarMensaje("Juan"); //Asigna el parametro string en el procedimiento mostrar mensaje
            MostrarMensaje("Alberto"); //va a ejecutar el par[ametro con una palabra distinta
            MostrarMensaje("Miguel","Si");//Diferencia cual de los dos MostrarMensaje llama por el n[umero de parametros
            Console.WriteLine($"Ferney tiene {CalcularEdad()}");
            Console.WriteLine($"Ferney tiene {CalcularEdad(2026,2008)}");
            Console.ReadKey();
            Program.BorrarPantalla();
        }
        //Procedimiento parámetros.
        static void BorrarPantalla()//Sintaxis: void para establecer el parametro; Static son objetos que no toca instanciar
                             //NombreDelParametro y () 
        {
            Console.Clear();
        }

        static int CalcularEdad()
        {
            int anoNacimiento= 1992;
            int anoActual= 2026;
            int edad= anoActual - anoNacimiento;
            return edad;//MUY IMPORTANTE que devuelva un valor, si no manda error
        }
        //Procedimiento con parametros
        static void MostrarMensaje(string nombre)//Tiene un parametro string nombre
                                                                  
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso");
        }
        static void MostrarMensaje(string nombre, string apellido)//Tiene un parametro string nombre, y una sobrecarga string apellido
                                                                  //Sobrecarga son parametros adicionales
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellido} al curso");
        }

        static int CalcularEdad(int anoActual, int anoNacimiento)
        {
            
            return anoActual - anoNacimiento;
           
        }
    }
}
