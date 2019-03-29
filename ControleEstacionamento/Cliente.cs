using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento
{
    public abstract class Cadastro
    {
        private int modalidade;
        private String placa;
        private float valorCarro;
        private float valorMoto;
        private int cpf;


        protected Cadastro(int cpf, int modalidade, string placa, float valorCarro, float valorMoto)
        {
            this.Cpf = cpf;
            this.Modalidade = modalidade;
            this.Placa = placa;
            this.ValorCarro = valorCarro;
            this.ValorMoto = valorMoto;
        }

        protected int Cpf { get => cpf; set => cpf = value; }
        protected int Modalidade { get => modalidade; set => modalidade = value; }
        protected string Placa { get => placa; set => placa = value; }
        protected float ValorCarro { get => valorCarro; set => valorCarro = value; }
        protected float ValorMoto { get => valorMoto; set => valorMoto = value; }
    }
}
