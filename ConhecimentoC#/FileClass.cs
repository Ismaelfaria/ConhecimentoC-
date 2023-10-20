using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSee
{
    internal class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }
        public static void SeeAndCreate(string nomeDoArquivo)
        {
            
            var arquivoComCaminho = caminhoArquivo + nomeDoArquivo + ".txt";

            Console.WriteLine("==\n" + "==Lendo o arquivo -- " + arquivoComCaminho + "\n==" + "\n===========Conteúdo===========");
            if (File.Exists(arquivoComCaminho))
            {
                OpenFile(arquivoComCaminho);
            }
            else
            {
                var sim = "sim";
                var textErro = "--------ERRO-------------\n" +
                                   "ARQUIVO NAO ENCONTRADO\n" +
                                   "Deseja cria um novo arquivo no mesmo caminho?";
                Console.WriteLine(textErro);

                var respCreate = Console.ReadLine();
                var comparResp = string.Equals(sim, respCreate, StringComparison.OrdinalIgnoreCase);
                if (comparResp)
                {
                    Console.WriteLine("Digite o nome do seu arquivo: ");
                    var respNameFile = Console.ReadLine();
                    var newPath = caminhoArquivo + respNameFile + ".txt";

                    Console.WriteLine("Deseja escrever algo no arquivo:");
                    var respYNContentFile = Console.ReadLine();
                    var compareResp = string.Equals(sim, respYNContentFile, StringComparison.OrdinalIgnoreCase);

                    if (compareResp)
                    {
                        Console.WriteLine("Escreve o conteudo:");
                        var contentFile = Console.ReadLine();

                        CreateFile(newPath, contentFile);
                    }
                    Console.WriteLine("Sucesso arquivo criado!!!");
                }
            }
        }
        /// <summary>
        /// Command Open File
        /// </summary>       
        public static void OpenFile(string arquivos)
        {
            using (StreamReader arquivo = File.OpenText(arquivos))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        /// <summary>
        /// Command Create File
        /// </summary>
        public static void CreateFile(string nomeArquivo,string conteudoArquivo)
        {
            using (StreamWriter writer = File.CreateText(nomeArquivo))
            {
                // Você pode adicionar informações iniciais ao arquivo se desejar.
                writer.WriteLine(conteudoArquivo);
            }
        }


    }
}

