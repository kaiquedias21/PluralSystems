using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento
{
    class Servicos
    {
        public void HoristaMoto()
        {

            Console.WriteLine("Modalidade escolhida: Horista \n Categoria de veículo: MOTO." +
                " \n Valor a ser pago: R$5 Reais. \n FAVOR EFETUAR O PAGAMENTO AO SAIR ");
        }

        public void DiaristaMoto()
        {
            Console.WriteLine("Modalidade escolhida: Diarista \n Categoria de veículo: MOTO." +
               " \n Valor a ser pago: R$30 Reais. \n FAVOR EFETUAR O PAGAMENTO ANTECIPADO ");
        }

        public void MensalistaMoto()
        {
            Console.WriteLine("Modalidade escolhida: Mensalista \n Categoria de veículo: MOTO." +
                " \n Valor a ser pago: R$5 Reais. \n FAVOR EFETUAR O PAGAMENTO ANTECIPADO ");
        }

        public void HoristaCarro()
        {
            Console.WriteLine("Modalidade escolhida: HORISTA \n Categoria de veículo: Carro." +
               " \n Valor a ser pago: R$10 Reais. \n FAVOR EFETUAR O PAGAMENTO AO SAIR ");
        }

        public void DiaristaCarro()
        {
            Console.WriteLine("Modalidade escolhida: DIARISTA \n Categoria de veículo: CARRO." +
               " \n Valor a ser pago: R$30 Reais. \n FAVOR EFETUAR O PAGAMENTO ANTECIPADO ");
        }

        public void MensalistaCarro()
        {
            Console.WriteLine("Modalidade escolhida: MENSALISTA \n Categoria de veículo: CARRO." +
               " \n Valor a ser pago: R$30 Reais. \n FAVOR EFETUAR O PAGAMENTO ANTECIPADO ");
        }
    }
}
