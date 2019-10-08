using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe para funções

namespace LeilaoEntrega
{
    public class Gerenciador
    {
        public void LerArquivo(string arquivo)
        {
            String text = System.IO.File.ReadAllText(arquivo);
            System.Console.WriteLine("Conteúdo do texto\n\n" + text);
            Console.ReadLine();
        }
    }
}
