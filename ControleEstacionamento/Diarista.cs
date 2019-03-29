using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento
{
    class Diarista : Cadastro
    {
        public Diarista(int cpf, int modalidade, string placa, float valorCarro,
        float valorMoto) : base(cpf, modalidade, placa, valorCarro, valorMoto)
        {
            this.ValorCarro = 30;
            this.ValorMoto = 15;
        }

        public void diaristaMoto()
        {
            Console.WriteLine("O pagamento deverá ser efetuado ao entrar" + ValorMoto);
        }

        public void diaristaCarro()
        {
            Console.WriteLine("O pagamento deverá ser efetuado ao entrar" + ValorCarro);
        }

    }
}
