using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo;  para cada usuario se debe hacer lo siguiente:
            //i. Si el saldo es mayor o igual a 3´000.000 , sacar un mensaje que diga el nombre del usuario, el numero de cuenta, el saldo y "es apto para crédito"
            //ii. Si el saldo es menor a 3´000.000, todo lo anterioir pero que el mensaje sea "No es apto para crédito"
            //El algoritmo debe permitir preguntar la información se usuarios, hasta que se indique que ya no se desea preguntar más.
            // Además debe permitir mostrar el número de usuarios a los que se le pidió la información y debe mostrar el promedio de saldos.

            float saldo = 0;
            float SumSaldo = 0;
            int cuenta = 0;
            string nombre;
            string confirmacion;
            int Cantper=0;
            do
            {
                do
                {
                    saldo = 0;
                    cuenta = 0;
                    Console.WriteLine("Ingrese su nombre de usuario");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su numero de cuenta");
                    cuenta = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su saldo");
                    saldo = float.Parse(Console.ReadLine());
                    if( saldo < 3000000)
                    {
                        Console.WriteLine($"{nombre}, con numero de cuenta {cuenta} y saldo {saldo}$ no es apto para credito");
                    }
                } while (saldo < 3000000);
                Console.WriteLine($"{nombre}, con numero de cuenta {cuenta}, y saldo {saldo}$ es apto para cuenta, \n desea ingresar otro usuario?");
                confirmacion = Console.ReadLine();
                Cantper++;
                SumSaldo += saldo;
            } while (confirmacion == "si");
            Console.WriteLine($"Se le pregunto a {Cantper} personas. El promedio de saldos es {SumSaldo/Cantper}$");
           
            


        }
    }
}
