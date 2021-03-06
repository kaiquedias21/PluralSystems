﻿using System;
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
            int opcao, tipoVeiculo, contadorMoto = 0, contadorCarro = 0;
            String placa;
            Double cpf;
            Double valorApagar;

            List<Double> cpfListas = new List<Double>();
            List<String> placasListas = new List<String>();
            List<int> servicos = new List<int>();
            bool sair = false;

            while (sair == false)
            {
                Console.WriteLine("--- ESCOLHA A OPÇÃO DESEJADA ---");
                Console.WriteLine("  - Digite 1 - Registrar entrada veículo");
                Console.WriteLine("  - Digite 2 - Calcular valor a pagar[OFF]");
                Console.WriteLine("  - Digite 3 - Sair");
                Console.WriteLine("  - Digite 4 - Cadastrar novo cliente");
                Console.WriteLine("  - Digite 5 - Verificar veículo no estacionamento");
                Console.WriteLine("  - Digite 6 - Tabela de preços");
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("--- Registrar a entrada de veículo ---");

                        Console.WriteLine(" Digite o CPF do cliente: ");
                        cpf = Convert.ToDouble(Console.ReadLine());

                        Cliente p = new Cliente();
                        cpfListas.Add(cpf);

                        Console.WriteLine(" Placa do veículo: ");
                        placa = Convert.ToString(Console.ReadLine());
                        Veiculo V = new Veiculo();
                        placasListas.Add(placa);

                        DateTime date1 = DateTime.Now;
                        Console.WriteLine("O veiculo entrou as " + DateTime.Now);
                        
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
                            //v.HoristaMoto();
                        }
                        else if (opcao == 1 && tipoVeiculo == 2)
                        {
                            Veiculo v = new Veiculo();
                            //v.DiaristaMoto();
                        }
                        else if (opcao == 2 && tipoVeiculo == 1)
                        {
                            Veiculo v = new Veiculo();
                            //v.MensalistaMoto();
                        }
                        else if (opcao == 2 && tipoVeiculo == 2)
                        {
                            Veiculo v = new Veiculo();
                            //v.HoristaCarro();
                        }
                        else if (opcao == 3 && tipoVeiculo == 1)
                        {
                            Veiculo v = new Veiculo();
                            //v.DiaristaCarro();
                        }
                        else
                        {
                            Veiculo v = new Veiculo();
                            //v.MensalistaCarro();
                        }
                    }
                    else if (opcao == 3)
                    {
                        sair = true;
                        Console.WriteLine("Aperte enter para encerrar o programa.");
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine("-- Cadastrar novo cliente --");
                        Console.WriteLine("Digite o tipo de veículo, sendo: 1 para moto ou 2 para carro:");
                        tipoVeiculo = Convert.ToInt32(Console.ReadLine());

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
                        cpf = Convert.ToDouble(Console.ReadLine());

                        Cliente p = new Cliente();
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

                    else if (opcao == 5)
                    {
                        Console.WriteLine("-- Verificar se o veículo se encontra no estacionamento --");
                        Console.WriteLine(" Digite o CPF do cliente: ");
                        cpf = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Placa do veículo: ");
                        placa = Convert.ToString(Console.ReadLine());

                        Console.WriteLine(cpfListas.Contains(cpf));
                        Console.WriteLine(placasListas.Contains(placa));
                    }
                    else if (opcao == 6)
                    {
                        Precos p = new Precos();
                        p.ConsultarValores();
                    }

                    else
                    {
                        Console.WriteLine("Opção não encontrada, verifique e tente novamente");
                    }
                }
                catch
                {
                    Console.WriteLine("Algo de errado não está certo!");
                }
            }
            Console.ReadKey();
        }
    }
}



