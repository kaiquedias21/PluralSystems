using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento
{
    class Precos
    {
        public void ConsultarValores() { 
        Console.WriteLine("Tabela de Valores:\n  Carro \n - Mensalista: R$300 " +
                                                        "\n-  Diarista: R$30 " +
                                                        "\n-  Horista: R$10");
        Console.WriteLine("\n Moto  " +
            "\n - Mensalista: R$150" +
            "\n - Diarista: R$15" +
            "\n - Horista: R$5 ");
        }
    }
}
