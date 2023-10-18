using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSee
{
    internal class Arquivo
    {
        public static void LerArquivos(string nomeDoArquivo)
        {
            //Fiz umas melhorias.
            //Já chamamos o método informando o nome do arquivo como parametro.

            string arquivoComCaminho = Constante.caminho + "arq" + nomeDoArquivo + ".txt";
            //O caminho agr é uma constante e foi chamada importando o namespace

            Console.WriteLine("==\n" + "==Lendo o arquivo -- " + arquivoComCaminho + "\n==" + "\n===========Conteúdo===========");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            else
            {
                var sim = "sim";
                var textErro = "--------ERRO-------------\n" +
                                   "ARQUIVO NAO ENCONTRADO\n" +
                                   "Deseja cria um novo arquivo no mesmo caminho:";
                Console.WriteLine(textErro);

                var T = Console.ReadLine();
                var Compar = string.Equals(sim, T, StringComparison.OrdinalIgnoreCase);
                if (Compar)
                {
                    Console.WriteLine("Digite o nome do seu arquivo: ");
                    var Ti = Console.ReadLine();
                    var newFile = Constante.caminho + Ti + ".txt";

                    Console.WriteLine("Deseja escrever algo no arquivo:");
                    var Tip = Console.ReadLine();
                    var Compare = string.Equals(sim, Tip, StringComparison.OrdinalIgnoreCase);

                    if (Compare)
                    {
                        Console.WriteLine("Escreve o conteudo:");
                        string Typi = Console.ReadLine();
                        using (StreamWriter writer = File.CreateText(newFile))
                        {
                            // Você pode adicionar informações iniciais ao arquivo se desejar.
                            writer.WriteLine(Typi);
                        }
                    }
                    Console.WriteLine("Sucesso arquivo criado!!!");
                }
            }
        }
    }
}

