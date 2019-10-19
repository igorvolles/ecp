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
                Console.WriteLine("Dados carregados com sucesso!");
                Console.WriteLine("Matriz " + matriz + " x " + matriz + " criada");
                Console.ReadKey();

            }
            else if (resp != "S" || resp != "N")
            {
                Console.WriteLine("Resposra inválida");
                Console.WriteLine("Os dados estão corretos? (S/N)");
                resp = Console.ReadLine().ToUpper();
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

        public static void MatrizEndereco(int tamanhoMatriz)
        {
            int linha = tamanhoMatriz;
            int coluna = tamanhoMatriz;
            Console.WriteLine("matriz de endereços");
            int[,] matriz = new int[linha, coluna];
            for (int j = 0; j < matriz.Length; j++) //ler  coluna
            {
                for (int i = 1; i <= matriz.Length; i++) //ler linha
                {
                    //matriz[j, i] = Convert.ToInt32(file.ReadLine());
                }
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
            Console.WriteLine("Informe o diretório do arquivo txt:");                         
            string diretorio = Console.ReadLine();
            return diretorio;
        }
    }
}
