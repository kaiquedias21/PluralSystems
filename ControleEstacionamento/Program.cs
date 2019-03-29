using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Controle de Estacionamento

O Sistema de Gestão de Estacionamento deve controlar os serviços que oferece aos seus clientes.
Os serviços são divididos em três tipos: Mensalista, Diarista e Horista.São admitidos dois tipo 
de veículos para o estacionamento, sendo eles carros e motos. A cobrança dos valores são diferentes
para cada modalidade adotada pelo cliente. O mensalista paga o valor antecipadamente para o mês corrente, 
sendo assim, ao entrar a primeira vez, será cobrado o valor da mensalidade. O Diarista, da mesma forma.
Ao entrar, deverá pagar o valor / dia.O Horista, paga ao sair.

1 * Os clientes deverão se cadastrar informando CPF, Placa do veículo e modalidade de serviço.

2 * O sistema deverá registrar a entrada do veículo, vinculada ao cliente.Um cliente poderá ter vários
veículos (ex. 1 carro e 1 moto. 2 carros). Na entrada do veículo, o sistema deverá validar se o cliente
está cadastrado e se existe tbm o cadastro para o veículo utilizado.

3 * O sistema deverá calcular os valores baseados na tabela de preços e modalidade de serviço.

4 * Ao informar o CPF e Placa do veículo, o sistema deve validar se veículo está dentro o estacionamento 
e a quanto tempo no dia corrente. 

A funcionalidade de calculo do débito do cliente terá como entrada 
o CPF e Placa do veículo.*/

namespace ControleEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("--- ESCOLHA A OPÇÃO DESEJADA ---");
            Console.WriteLine("  - Digite 1 - Registrar entrada veículo");
            Console.WriteLine("  - Digite 2 - Calcular valor a pagar");
            Console.WriteLine("  - Digite 3 - Verificar veículo no estacionamento");
            Console.WriteLine("  - Digite 4 - Cadastrar novo cliente");
            Console.WriteLine("  - Digite 5 - Tabela de preços");

            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("--- Registrar a entrada de veículo ---");

            }
            else if (opcao == 2)
            {
                Console.WriteLine(" -- Calcular valor a pagar -- ");
                Console.WriteLine(" Tipo de veículo: 1 - carro 2 - moto ");
                Console.WriteLine(" Digite a modalidade: ");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("-- Verificar se o veículo se encontra no estacionamento --");
                Console.WriteLine(" Digite o CPF do cliente: ");
                Console.WriteLine(" Placa do veículo: ");

            }
            else if (opcao == 4)
            {
                Console.WriteLine("-- Cadastrar novo cliente --");
                Console.WriteLine(" Digite o CPF do cliente: ");

                Console.WriteLine(" Digite o tipo de veículo, sendo: 1 para carro, 2 Para moto: ");

                Console.WriteLine(" Placa do veículo: ");

                Console.WriteLine(" Modalidade: 1 - Horista 2 - Diarista 3 - Mensalista ");
                Console.WriteLine("-- Cadastro efetuado com sucesso!--"); 

            }
            else if (opcao == 5)
            {
                Precos p = new Precos();
                p.ConsultarValores();
            }
            else
            {
                Console.WriteLine("Opção não encontrada, verifique e tente novamente");
            }

            Console.ReadKey();
        }
    }
}

