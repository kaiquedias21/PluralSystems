using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento
{
    class Mensalista : Cadastro
    {
        public Mensalista(int cpf, int modalidade, string placa, float valorCarro,
        float valorMoto) : base(cpf, modalidade, placa, valorCarro, valorMoto)
        {
            this.ValorCarro = 300;
            this.ValorMoto = 150;
        }

        public void mensalistaMoto()
        {
            Console.WriteLine("O pagamento deverá ser efetuado ao entrar" + ValorMoto);
        }

        public void mensalistaCarro()
        {
            Console.WriteLine("O pagamento deverá ser efetuado ao entrar" + ValorCarro);
        }
    }
}
