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
            int opcao, cpf, tipoVeiculo, contadorMoto = 0, contadorCarro = 0;
            String placa;

            List<int> cpfListas = new List<int>();
            List<String> placasListas = new List<String>();
            List<int> servicos = new List<int>();

            Console.WriteLine("--- ESCOLHA A OPÇÃO DESEJADA ---");
            Console.WriteLine("  - Digite 1 - Registrar entrada veículo");
            Console.WriteLine("  - Digite 2 - Calcular valor a pagar");
            Console.WriteLine("  - Digite 3 - ");
            Console.WriteLine("  - Digite 4 - Cadastrar novo cliente");
            Console.WriteLine("  - Digite 5 - Verificar veículo no estacionamento");
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

                /*     if (opcao == 1 && tipoVeiculo == 1)
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
                     } */

            }
            else if (opcao == 3)
            {


            }
            else if (opcao == 4)
            {
                Console.WriteLine("-- Cadastrar novo cliente --");
                try
                {
                    Console.WriteLine("Digite o tipo de veículo, sendo: 1 para moto ou 2 para carro:");
                    tipoVeiculo = Convert.ToChar(Console.ReadLine());

                    if (tipoVeiculo == 1)
                    {
                        Moto M = new Moto();
                        contadorMoto++;

                    }
                    else
                    {
                        Carro C = new Carro();
                        contadorCarro++;
                    }

                    Console.WriteLine(" Digite o CPF do cliente: ");
                    Cliente p = new Cliente();
                    //List<int> cpfListas = new List<int>();
                    cpf = Convert.ToInt32(Console.ReadLine());
                    cpfListas.Add(cpf);

                    Console.WriteLine(" Modalidade: 1 - Horista 2 - Diarista 3 - Mensalista ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    Servicos s = new Servicos();
                    servicos.Add(opcao);

                    Console.WriteLine(" Placa do veículo: ");
                    placa = Convert.ToString(Console.ReadLine());
                    Veiculo V = new Veiculo();
                    placasListas.Add(placa);
                }
                catch
                {
                    Console.WriteLine("Opção inválida! Tente novamente");
                }
                finally
                {
                    Console.WriteLine("Voltar para o menu");
                }

            }

            else if (opcao == 5)
            {
                /*Precos p = new Precos();
                p.ConsultarValores();*/

                Console.WriteLine("-- Verificar se o veículo se encontra no estacionamento --");
                Console.WriteLine(" Digite o CPF do cliente: ");
                cpf = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Placa do veículo: ");
                placa = Convert.ToString(Console.ReadLine());


                Console.WriteLine(cpfListas.Contains(cpf));
                Console.WriteLine(placasListas.Contains(placa));



            }
            else
            {
                Console.WriteLine("Opção não encontrada, verifique e tente novamente");
            }

            Console.ReadKey();
        }
    }
}

