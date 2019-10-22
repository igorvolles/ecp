using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LeilaoEntrega
{
    //Solução desenvolvido por Igor Volles e Matheus Alcantara

    public class Program
    {
        public static string[,] matriz1;
        public static string[,] matriz2;
        public static int linha1, linha2;
        public static int coluna1, coluna2;
        public static int opcao = 0;
        static void Main(string[] args)
        {
            while(opcao == 0)
            {
                Console.Clear();
                Console.WriteLine("_____ LEILÃO DE ENTREGAS _____");
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Carregar lista de destinos");
                Console.WriteLine("2 - Carregar lista de entregas");
                Console.WriteLine("3 - Exibir sequência de entregas");
                Console.WriteLine("4 - Sair");
                Console.Write("Op: ");
                opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        LerListaDestino();
                        break;
                    case 2:
                        LerListaEntregas();
                        break;
                    case 3:
                        MostrarMatriz();
                        break;
                    case 4:
                        Environment.Exit(4);
                        break;
                }
            }
        }

        public static void LerListaDestino()
        {
            string resp = ""; 
            string diretorio;
            int TamanhoMatriz = 0;
            Console.Clear();
            Console.WriteLine("_____ LEILÃO DE ENTREGAS _____");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Carregar lista de destinos");
            Console.WriteLine("------------------------------");
            diretorio = LerArquivoTxt();
            string txt = File.ReadAllText(diretorio);
            Console.WriteLine("\nConteúdo do arquivo");
            Console.WriteLine("------------------------------");
            Console.WriteLine(txt);
            Console.WriteLine("------------------------------");
            Console.Write("Os dados estão corretos? (S/N): ");
            resp = Console.ReadLine().ToUpper();
            if (resp == "S")
            {
                Console.Clear();
                Console.WriteLine("_____ LEILÃO DE ENTREGAS _____");
                Console.WriteLine("------------------------------");
                Console.WriteLine("LISTA DE DESTINOS");
                Console.WriteLine("------------------------------");
                TamanhoMatriz = LerTamanhoMatriz(diretorio);
                AlimentarMatriz1(diretorio);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Matriz " + TamanhoMatriz + " x " + TamanhoMatriz + " criada");
                Console.WriteLine("Dados carregados com sucesso!");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Pressione uma telca para voltar ao menu");
                Console.ReadKey();
                opcao = 0;
                
            }
            else if (resp != "S" || resp != "N")
            {                
                Console.WriteLine("Resposta inválida");
                Console.WriteLine("Necessário repetir a operação");
                Console.WriteLine("Pressione uma telca para continuar");
                Console.ReadKey();
                opcao = 0;                
            }
        }

        public static void LerListaEntregas()
        {
            Console.Clear();
            string diretorio;
            string resp;
            int TamanhoMatriz = 0;
            Console.WriteLine("_____ Leilão de entregas _____");
            Console.WriteLine("------------------------------");
            Console.WriteLine("2 - Carregar lista de entregas");
            Console.WriteLine("------------------------------");
            diretorio = LerArquivoTxt();
            string txt = File.ReadAllText(diretorio);
            Console.WriteLine("\nConteúdo do arquivo");
            Console.WriteLine("------------------------------");
            Console.WriteLine(txt);
            Console.WriteLine("------------------------------");
            Console.Write("Os dados estão corretos? (S/N): ");
            resp = Console.ReadLine().ToUpper();
            if (resp == "S")
            {
                Console.Clear();
                Console.WriteLine("_____ Leilão de entregas _____");
                Console.WriteLine("------------------------------");
                Console.WriteLine("LISTA ENTREGAS");
                Console.WriteLine("------------------------------");
                TamanhoMatriz = LerTamanhoMatriz(diretorio);
                AlimentarMatriz2(diretorio);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Matriz " + TamanhoMatriz + " x " + TamanhoMatriz + " criada");
                Console.WriteLine("Dados carregados com sucesso!");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Pressione uma telca para voltar ao menu");
                Console.ReadKey();
                opcao = 0;

            }
            else if (resp != "S" || resp != "N")
            {
                Console.WriteLine("Resposta inválida");
                Console.WriteLine("Necessário repetir a operação");
                Console.WriteLine("Pressione uma telca para continuar");
                Console.ReadKey();
                opcao = 0;
                //Console.Write("Os dados estão corretos? (S/N): ");
                //resp = Console.ReadLine().ToUpper();
                // criar while para resposta incorreta
            }
        }

        public static void AlimentarMatriz1(string diretorio)
        {
            StreamReader file = new StreamReader(diretorio);
            linha1 = int.Parse(file.ReadLine())+1;
            coluna1 = linha1-1;
            matriz1 = new string[linha1, coluna1];
            for (int i = 0; i < linha1; i++)
            {
                string linhaLida = file.ReadLine();
                string[] dados = linhaLida.Split(',');
                for (int j = 0; j < coluna1; j++)
                {
                    matriz1[i, j] = dados[j];
                }
                matriz1[i, coluna1 - 1] = dados[coluna1 - 1];
            }
            for (int i = 0; i < linha1; i ++)
            {
                for (int j = 0; j < coluna1; j++)
                {
                    Console.Write(matriz1[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        public static void AlimentarMatriz2(string diretorio)
        {
            StreamReader file = new StreamReader(diretorio);
            linha2 = int.Parse(file.ReadLine());
            coluna2 = 3;
            matriz2 = new string[linha2, coluna2];
            for (int i = 0; i < linha2; i++)
            {
                string linhaLida = file.ReadLine();
                string[] dados = linhaLida.Split(',');
                for (int j = 0; j < coluna2; j++)
                {
                    matriz2[i, j] = dados[j];
                }
                matriz2[i, coluna2 - 1] = dados[coluna2 - 1];
            }
            for (int i = 0; i < linha2; i++)
            {
                for (int j = 0; j < coluna2; j++)
                {
                    Console.Write(matriz2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        public static int LerTamanhoMatriz(string txt)
        {
            int tamanho_matriz;
            StreamReader file = new StreamReader(txt);
            tamanho_matriz = Convert.ToInt32(file.ReadLine());
            return tamanho_matriz; //retornar tamanho da matriz
        }

        public static string LerArquivoTxt()
        {
            Console.Write("Informe o diretório do arquivo txt: ");                         
            string diretorio = Console.ReadLine();
            return diretorio;
        }

        public static void MostrarMatriz()
        {
            Console.Clear();
            Console.WriteLine("Lista de destinos");
            Console.WriteLine("------------------");
            for (int i = 0; i < linha1; i++)
            {
                for (int j = 0; j < coluna1; j++)
                {
                    Console.Write(matriz1[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Lista de entregas");
            Console.WriteLine("------------------");
            for (int i = 0; i < linha2; i++)
            {
                for (int j = 0; j < coluna2; j++)
                {
                    Console.Write(matriz2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Pressione uma telca para voltar ao menu");
            Console.ReadKey();
            opcao = 0;
        }
    }
}
