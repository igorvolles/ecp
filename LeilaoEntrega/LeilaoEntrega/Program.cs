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

            Console.WriteLine("_____ Leilão de entregas _____");
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
            Console.Clear();
            string diretorio;
            int matriz = 0;
            Console.WriteLine("_____ Leilão de entregas _____");
            Console.WriteLine("1 - Carregar lista de destinos");
            diretorio = LerArquivoTxt();
            string txt = File.ReadAllText(diretorio);
            Console.WriteLine("Conteúdo do texto\n\n" + txt);
            Console.WriteLine("Os dados estão corretos? (S/N)");
            resp = Console.ReadLine().ToUpper();
            if (resp == "S")
            {
                matriz = LerTamanhoMatriz(diretorio);
                AlimentarMatriz(matriz, diretorio);
                Console.WriteLine("Dados carregados com sucesso!");
                Console.WriteLine("Matriz " + matriz + " x " + matriz + " criada");
                Console.ReadKey();

            }
            else if (resp != "S" || resp != "N")
            {
                Console.WriteLine("Resposta inválida");
                Console.WriteLine("Os dados estão corretos? (S/N)");
                resp = Console.ReadLine().ToUpper();
                // criar while para resposta incorreta
            }
        }

        public static void LerListaEntregas()
        {
            Console.Clear();
            string arquivo;
            Console.WriteLine("_____ Leilão de entregas _____");
            Console.WriteLine("2 - Carregar lista de entregas");            
            arquivo = LerArquivoTxt();
            System.Console.WriteLine("Conteúdo do texto\n\n" + arquivo);
            Console.ReadKey();
        }

        public static void AlimentarMatriz(int tamanhoMatriz, string diretorio)
        {
            StreamReader file = new StreamReader(diretorio);
            int linha = int.Parse(file.ReadLine());
            int coluna = linha;
            string[,] matriz = new string[linha, coluna];
            for  (int j = 0; j < coluna; j++)
            {
                for (int i = 0; i < linha; i++)
                {
                    matriz[i, j] = file.ReadLine(); // como incluir a porra do separador
                }
            }
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz[i,j]);
                }
            }
            Console.ReadLine();
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
            Console.WriteLine("Informe o diretório do arquivo txt:");                         
            string diretorio = Console.ReadLine();
            return diretorio;
        }
    }
}
