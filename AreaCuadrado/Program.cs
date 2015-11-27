using System;

namespace AreaCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1;
            string valor2;
            int result;
            Console.WriteLine("************------------ CALCULO DE AREA DE UN CUADRADO ------------************");
            Console.WriteLine("PULSA ENTER PARA COMENZAR...");
            Console.ReadLine();

            Console.WriteLine("Introduzca la longitud:");
            valor1 = Console.ReadLine();

            Console.WriteLine("Introduzca la altura:");
            valor2 = Console.ReadLine();

            result = calculo(valor1, valor2);

            Console.WriteLine("El area del cuadrado es: {0}", result);
            Console.ReadLine();
        }

        public static int calculo(string v1, string v2)
        {
            int r;
            r = Convert.ToInt32(v1) * Convert.ToInt32(v2);

            return r;
        }
    }
}
