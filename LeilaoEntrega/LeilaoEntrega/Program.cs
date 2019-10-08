using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoEntrega
{

    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

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
                case 3: //exibir sequência de entregas                        
                    break;                    
            }                       
        }

        public static void LerListaDestino()
        {
            Console.Clear();
            string arquivo;
            Console.WriteLine("_____ Leilão de entregas _____");
            Console.WriteLine("1 - Carregar lista de destinos");
            Console.Write("Informe o diretório do arquivo txt: ");
            arquivo = Console.ReadLine();
            String text = System.IO.File.ReadAllText(arquivo);
            System.Console.WriteLine("Conteúdo do texto\n\n" + text);
            Console.ReadLine();
        }

        public static void LerListaEntregas()
        {
            Console.Clear();
            string arquivo;
            Console.WriteLine("_____ Leilão de entregas _____");
            Console.WriteLine("2 - Carregar lista de entregas");
            Console.Write("Informe o diretório do arquivo txt: ");
            arquivo = Console.ReadLine();
            String text = System.IO.File.ReadAllText(arquivo);
            System.Console.WriteLine("Conteúdo do texto\n\n" + text);
            Console.ReadLine();
        }
    }
}
