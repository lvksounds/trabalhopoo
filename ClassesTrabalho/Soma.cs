using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTrabalho
{
    internal class Soma
    {
        public static void ExercicioSoma()
        {
            var soma = new Soma();

            int x, y;
            Console.WriteLine("Entre com o primeiro valor: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor: ");
            y = Convert.ToInt32(Console.ReadLine());

            string result = $"Resultado da soma entre {x} e {y} = {soma.Somar(x, y)}";

            Console.WriteLine(result);
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }

    }
}
