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
                case 1:
                    {
                        //carregar lista de destinos
                        break;
                    }

                case 2:
                    {
                        // carregar lista de entregas
                        break;
                    }

                case 3:
                    {
                        //exibir sequência de entregas
                        break;
                    }

            }

        }
    }
}
