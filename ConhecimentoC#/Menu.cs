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
                String mensagem = "Ola usuario, bem vindo ao programa\n" +
                                  "\nUtilizando programação funcional" +
                                  "\n\n" +
                                  "\nDigite uma das opções abaixo:  " +
                                  "\n0 - Sair do programa" +
                                  "\n1 - Para Ler Aquivos" +
                                  "\n2 - Para Executar a tabuada" +
                                  "\n3 - Calcular média de alunos" +
                                  "\n-----------------------------";

                Console.WriteLine(mensagem);

                var valor = int.Parse(Console.ReadLine());


                if (valor == Constante.SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == Constante.LER_ARQUIVOS)
                {
                    Console.WriteLine("=========Opção ler arquivos==========");
                    Arquivo.LerArquivos("arq1");
                    Console.WriteLine("=====================================");
                }
                else if (valor == Constante.TABUADA)
                {
                    Console.WriteLine("=================Opção Tabuada==================");
                    Console.Write("Digite o numero que deseja na tabuada: ");
                    var num = int.Parse(Console.ReadLine());
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

