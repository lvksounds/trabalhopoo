using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTrabalho
{
    internal class Menu
    {
        Dictionary<string, Action> Exercicios;

        public Menu(Dictionary<string, Action> exercicios)
        {
            Exercicios = exercicios;
        }

        public void SelecionarEExecutar()
        {
            int indice = 1;

            foreach(var exercicio in Exercicios)
            {
                Console.WriteLine("{0}) {1}", indice, exercicio.Key);
                indice++;
            }

            Console.WriteLine("Digite um numero para selecionar um exercicio (enter selecionar o ultimo): ");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= Exercicios.Count;
            num = numValido ? num - 1 : Exercicios.Count - 1;

            string nomeExercicio = Exercicios.ElementAt(num).Key;

            Action executar = Exercicios.ElementAt(num).Value;

            try
            {
                executar();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: {0}", e);
            }
        }
    }
}
