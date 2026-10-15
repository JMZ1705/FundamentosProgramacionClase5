using System;
using System.Collections.Generic;
using System.Threading;


namespace TallerModulos
{
    internal class Program
    {
        /* 1.Desarrolla un programa que permita: 
 Ingresar una palabra
 LLevar la palabra ingresada a un vector de caracteres
 Contar la cantidad de vocales y consonantes en la palabra proporcionada por el
usuario.*/
        /*static void Main(string[] args)
        {
            //IngresarPalabra();
            //VectorCaracteres(IngresarPalabra());
            Console.WriteLine(VectorCaracteres(IngresarPalabra()));
        }

        static string IngresarPalabra()
        {
            Console.WriteLine("ingrese una palabra");
            return Console.ReadLine();
        }

        static string VectorCaracteres(string palabra)
        {
            char[] VectorCaracteres = palabra.ToCharArray();
            int Cvocal =0;
            int Ccon = 0;
            for(int i =0;  i<VectorCaracteres.Length; i++)
            {
                if (VectorCaracteres[i] == 'a'|| VectorCaracteres[i] == 'e' || VectorCaracteres[i] == 'i' || VectorCaracteres[i] == 'o' || VectorCaracteres[i] == 'u')
                {
                    Cvocal++;
                }
                else
                {
                    Ccon++;
                }
            }
            return $"El numero de vocales en la {palabra} es {Cvocal} y de consonantes {Ccon}";
           
        } */

        /*2. Crear un programa que permita gestionar una lista de tareas: 
 Agregar tareas.
 Eliminar tareas 
 Mostrar la lista de tareas.
*/
        static void Main(string[] args)
        {
            
        }
    }
}
