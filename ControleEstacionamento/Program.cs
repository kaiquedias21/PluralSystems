using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
             int opcao, tipoVeiculo, cpf;
             String placa;

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
                tipoVeiculo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Digite a modalidade: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1 && tipoVeiculo == 1)
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

                Console.WriteLine(" Modalidade: 1 - Horista 2 - Diarista 3 - Mensalista ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o tipo de veículo, sendo: 1 para moto ou 2 para carro:");
                tipoVeiculo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Digite o CPF do cliente: ");
                Cliente c = new Cliente();
                cpf = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Placa do veículo: ");
                placa = Convert.ToString(Console.ReadLine());

                if (opcao == 1 && tipoVeiculo == 1)
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

