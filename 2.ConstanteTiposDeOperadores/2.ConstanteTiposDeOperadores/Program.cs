using System;


namespace _2.ConstanteTiposDeOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string gravedad = "9.8";
            string nombre = "putocarlos";
            nombre = "nigrocarlos;";
            //gravedad = "Lencio"; no puedo cambiar el valor de una constante
           
            //TIPOS DE DATOS
            byte dato1 = 67; //entero sin signo
            int dato2 = -1456; //entero con signo
            ulong dato3 = 5615616515615615; //Bien largo
            float dato4 = 14.6f; // decimales, Importante el sufijo f, ES CON . NO CON ,
            double dato5 = 56456186151161.1544111481561d; //No rquiere sufijo, pero se le puede poner "d"
            decimal dato6 = 132156518151564416856165.5641865156181651845648756m; //El de mayor precisión pero consume más espacio, sufijo m o piensa que es un double
            char dato7 = '°'; //comillas simples, sin espacios
            string dato8 = "secsito"; //Cadena de caracteres
            bool dato9 = false; //true or false
            object dato10 = new object(); //La clase superior

            //OPERADORES
            //OPERADORES NUMÉRICOS
            //CAMBIO DE SIGNO
            int dato11 = 5;
            int dato12 = -dato11; //Sería -5
            int dato13 = -dato12; //+(-5) = -5
            int dato14 = -dato13; //-(-5) = 5
            Console.WriteLine("dato11:{0},dato12:{1},dato13:{2},dato14:{3},", dato11, dato12, dato13, dato14);
            //OPERADORES ARITMÉTICOS
            int dato15 = 5 + 3; //Suma
            int dato16 = dato15 - 2; //resta
            int dato17 = 25 * 3; //producto
            float dato18 =(float) 5 / 3; //División.
                                         // float dato18 =(float) 5 / 3. El (float) es para que haga la operación con enteros pero de el resultado decimal
                                         // float dato18 = 5f/ 3f también se soluciona poniendo el sufijo.
            Console.WriteLine("Suma: {0}, resta:{1}, producto:{2}, división:{3}", dato15, dato16, dato17, dato18);
        }
    }
}
