using Calculo;
using FileSee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGlobal
{
    internal class Menu
    {
        public static void Opcoes()
        {
            while (true)
            {
                var mensagem = "Ola usuario, bem vindo ao programa\n" +
                                  "\nUtilizando programação funcional" +
                                  "\n\n" +
                                  "\nDigite uma das opções abaixo:  " +
                                  "\n0 - Sair do programa" +
                                  "\n1 - Para Ler Aquivos" +
                                  "\n2 - Para Executar a tabuada" +
                                  "\n3 - Calcular média de alunos" +
                                  "\n-----------------------------";

                Console.WriteLine(mensagem);

                int valor;
                int.TryParse(Console.ReadLine(), out valor);

                if (valor == Constante.SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == Constante.LER_ARQUIVOS)
                {
                    Console.Write("=========Opção ler arquivos==========\n" + "\nDigite o nome do arquivo: ");
                    var name = Console.ReadLine();
                    Arquivo.SeeAndCreate(name);
                    Console.WriteLine("=====================================");
                }
                else if (valor == Constante.TABUADA)
                {
                    Console.WriteLine("=================Opção Tabuada==================");
                   Console.Write("Digite o numero que deseja na tabuada: ");
                    int num;
                    int.TryParse(Console.ReadLine(), out num);
                    Tabuada.tabuada(num);
                    Console.WriteLine("\n============================================\n");

                }
                else if (valor == Constante.CALCULO_MEDIA)
                {
                    Console.WriteLine("============Opção Media==============");
                    Media.Aluno();
                    Console.WriteLine("\n==================================\n");

                }
                else
                {
                    Console.WriteLine("Opção invalida digite novamente");
                }



            }
        }
    }
}

