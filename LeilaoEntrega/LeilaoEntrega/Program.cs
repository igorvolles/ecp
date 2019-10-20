using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LeilaoEntrega
{

    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.WriteLine("_____ LEILÃO DE ENTREGAS _____");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Carregar lista de destinos");
            Console.WriteLine("2 - Carregar lista de entregas");
            Console.WriteLine("3 - Exibir sequência de entregas");
            Console.Write("Op: ");
            opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1: LerListaDestino();                                                          
                    break;          
                case 2: LerListaEntregas();
                    break;
                case 3:                     
                    //exibir sequência de entregas                        
                    break;                    
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
                AlimentarMatriz(diretorio);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Matriz " + TamanhoMatriz + " x " + TamanhoMatriz + " criada");
                Console.WriteLine("Dados carregados com sucesso!");  
                Console.ReadKey();
                
            }
            else if (resp != "S" || resp != "N")
            {                
                Console.WriteLine("Resposta inválida");
                Console.Write("Os dados estão corretos? (S/N): ");
                resp = Console.ReadLine().ToUpper();
                // criar while para resposta incorreta
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
                AlimentarMatriz(diretorio);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Matriz " + TamanhoMatriz + " x " + TamanhoMatriz + " criada");
                Console.WriteLine("Dados carregados com sucesso!");
                Console.ReadKey();

            }
            else if (resp != "S" || resp != "N")
            {
                Console.WriteLine("Resposta inválida");
                Console.Write("Os dados estão corretos? (S/N): ");
                resp = Console.ReadLine().ToUpper();
                // criar while para resposta incorreta
            }
        }

        public static void AlimentarMatriz(string diretorio)
        {
            StreamReader file = new StreamReader(diretorio);
            int linha = int.Parse(file.ReadLine());
            int coluna = linha;
            string[,] matriz = new string[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                string linhaLida = file.ReadLine();
                string[] dados = linhaLida.Split(',');
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = dados[j];
                }
                matriz[i, coluna - 1] = dados[coluna - 1];
            }
            for (int i = 0; i < linha; i ++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz[i, j]);
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
    }
}
