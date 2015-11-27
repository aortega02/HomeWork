using System;

namespace Lenght
{
    class Program
    {
        static void Main(string[] args)
        {
            //CANTIDAD DE LETRAS DE UN NOMBRE

            string valor1;

            int result;

            Console.WriteLine("************--------- CANTIDAD DE LETRAS DE UN NOMBRE ---------************");
            Console.WriteLine("PULSA ENTER PARA COMENZAR...");
            Console.ReadLine();

            Console.WriteLine("Ingrese el nombre completo:");
            valor1 = Console.ReadLine();

            result = calculo(valor1);

            Console.WriteLine("**************REALIZANDO CONTEO***********");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();

            Console.WriteLine("La cantidad de letras que tiene el nombre: {0} es de: {1} caracteres", valor1, result);
            Console.ReadLine();

        }
        public static int calculo(string v1)
        {
            char[] r;
            int cant;
            r = v1.ToCharArray();
            cant = r.Length;
            return cant;
        }
    }
}
