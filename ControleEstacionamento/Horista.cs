using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento
{
    class Horista : Cadastro
    {
        public Horista(int cpf, int modalidade, string placa, float valorCarro,
        float valorMoto) : base(cpf, modalidade, placa, valorCarro, valorMoto)
        {
            this.ValorCarro = 10;
            this.ValorMoto = 5;
        }

        public void horistaMoto()
        {
            Console.WriteLine("O pagamento deverá ser efetuado ao sair no valor de" + ValorMoto);
        }

        public void horistaCarro()
        {
            Console.WriteLine("O pagamento deverá ser efetuado ao sair no valor de" + ValorCarro);
        }
    }
}

