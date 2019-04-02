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


/*O Sistema de Gestão de Estacionamento deve controlar os serviços que oferece aos seus clientes.
Os serviços são divididos em três tipos: Mensalista, Diarista e Horista.
    
São admitidos dois tipo de veículos para o estacionamento, sendo eles carros e motos.A cobrança dos
valores são diferentes para cada modalidade adotada pelo cliente.O mensalista paga o valor antecipadamente
para o mês corrente, sendo assim, ao entrar a primeira vez, será cobrado o valor da mensalidade. O Diarista,
da mesma forma.Ao entrar, deverá pagar o valor / dia. O Horista, paga ao sair.

Os clientes deverão se cadastrar informando CPF, Placa do veículo e modalidade de serviço.
O sistema deverá registrar a entrada do veículo, vinculada ao cliente.

Um cliente poderá ter vários veículos (ex. 1 carro e 1 moto. 2 carros). Na entrada do veículo,
o sistema deverá validar se o cliente está cadastrado e se existe tbm o cadastro para o veículo utilizado.

O sistema deverá calcular os valores baseados na tabela de preços e modalidade de serviço.Ao informar o 
CPF e Placa do veículo, o sistema deve validar se veículo está dentro o estacionamento e a quanto tempo
no dia corrente.A funcionalidade de calculo do débito do cliente terá como entrada o CPF e Placa do veículo.

Tabela de Valores
Carros
- Mensalista: R$300
- Diarista: R$30
- Horista: R$10
 
Motos
- Mensalista: R$150
- Diarista: R$15
- Horista: R$5 */

/*                if (opcao == 1 && tipoVeiculo == 1)
            {
                Veiculo v = new Veiculo();
                v.HoristaMoto();

            }
            else if (opcao == 1 && tipoVeiculo == 2)
            {
                Veiculo v = new Veiculo();
                v.DiaristaMoto();
            }
            else if (opcao == 2 && tipoVeiculo == 1)
            {
                Veiculo v = new Veiculo();
                v.MensalistaMoto();
            }
            else if (opcao == 2 && tipoVeiculo == 2)
            {
                Veiculo v = new Veiculo();
                v.HoristaCarro();
            }
            else if (opcao == 3 && tipoVeiculo == 1)
            {
                Veiculo v = new Veiculo();
                v.DiaristaCarro();
            }
            else
            {
                Veiculo v = new Veiculo();
                v.MensalistaCarro();
            }
*/