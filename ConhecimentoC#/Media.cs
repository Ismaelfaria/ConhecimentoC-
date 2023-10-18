
using FileSee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Media
    {
        public static void Aluno()
        {
            Console.Write("digite o nome do aluno: ");
            var nome = Console.ReadLine();
            var qtdNotas = 3;
            Console.WriteLine("-------------------");
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);

            var notas = new List<int>();
            var totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.Write("-Digite a nota numero " + i + ": ");
                int nota;
                int.TryParse(Console.ReadLine(), out nota);
                totalNotas += nota;
                notas.Add(nota);
            }
            var media = totalNotas / notas.Count;
            Console.WriteLine("====\nA media do aluno " + nome + " é: " + media);
            Console.WriteLine("As notas são\n");
            foreach (var nota in notas)
            {
                Console.WriteLine("-nota: " + nota + "\n");
            }

        }
    }
}