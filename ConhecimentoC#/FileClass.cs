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
            
            var arquivoComCaminho = Constante.CAMINHO + "arq" + nomeDoArquivo + ".txt";
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

                var t = Console.ReadLine();
                var Compar = string.Equals(sim, t, StringComparison.OrdinalIgnoreCase);
                if (Compar)
                {
                    Console.WriteLine("Digite o nome do seu arquivo: ");
                    var ti = Console.ReadLine();
                    var newFile = Constante.CAMINHO + ti + ".txt";

                    Console.WriteLine("Deseja escrever algo no arquivo:");
                    var tip = Console.ReadLine();
                    var compare = string.Equals(sim, tip, StringComparison.OrdinalIgnoreCase);

                    if (compare)
                    {
                        Console.WriteLine("Escreve o conteudo:");
                        var typi = Console.ReadLine();
                        using (StreamWriter writer = File.CreateText(newFile))
                        {
                            // Você pode adicionar informações iniciais ao arquivo se desejar.
                            writer.WriteLine(typi);
                        }
                    }
                    Console.WriteLine("Sucesso arquivo criado!!!");
                }
            }
        }
    }
}

