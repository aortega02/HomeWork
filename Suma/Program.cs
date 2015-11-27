using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            //RESULTADO DE UNA SUMA DE 3 NUMEROS

            string valor1;
            string valor2;
            string valor3;

            int result;

            Console.WriteLine("************--------- RESULTADO DE UNA SUMA DE 3 NUMEROS ---------************");
            Console.WriteLine("PULSA ENTER PARA COMENZAR...");
            Console.ReadLine();

            Console.WriteLine("Primer Numero:");
            valor1 = Console.ReadLine();

            Console.WriteLine("Segundo Numero:");
            valor2 = Console.ReadLine();

            Console.WriteLine("Tercer Numero:");
            valor3 = Console.ReadLine();

            result = suma(valor1, valor2, valor3);

            Console.WriteLine("**************REALIZANDO CALCULO***********");
            Console.WriteLine("Presiones ENTER para continuar");
            Console.ReadLine();

            Console.WriteLine("El resultado de {0} + {1} + {2} = {3}", valor1, valor2, valor3, result);
            Console.ReadLine();

        }

        public static int suma(string v1, string v2, string v3)
        {
            int r;
            r = Convert.ToInt32(v1) + Convert.ToInt32(v2) + Convert.ToInt32(v3);

            return r;
        }
    }
}
