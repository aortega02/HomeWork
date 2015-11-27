using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1;
            double result;
            Console.WriteLine("************------------ CALCULO DE AREA DE UN CIRCULO ------------************");
            Console.WriteLine("PULSA ENTER PARA COMENZAR...");
            Console.ReadLine();

            Console.WriteLine("Introduzca el Radio del Circulo:");
            valor1 = Console.ReadLine();

            result = calculo(valor1);
            Console.WriteLine("**************REALIZANDO CALCULO***********");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();

            Console.WriteLine("El area del circulo es: {0}", result.ToString("#.##"));
            Console.ReadLine();
        }

        public static double calculo(string v1)
        {
            double area, radio;
            const double Pi = Math.PI;

            radio = Convert.ToDouble(v1);
            area = radio * radio;
            area = area * Pi;

            return area;
        }

    }
}
