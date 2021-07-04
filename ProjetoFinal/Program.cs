using System;
using System.Collections.Generic;

namespace ProjetoFinal
{
    

    class Program
    {
        public static int UltimoClienteCadastrado = 0;
        public static List<Cliente> Clientes = new List<Cliente>();
        
        static void Main(string[] args)
        {
            string opcao = "";
            while (opcao != "5")
            {//.

                ApresentarMenu();
                opcao = Console.ReadLine();
                Console.WriteLine("");
                if (opcao == "1")
                {
                    Console.WriteLine("Ok, vamos cadastrar um novo cliente.");
                    Console.WriteLine("Digite abaixo o nome do cliente");
                    Console.Write("> ");
                    string nomeDoCliente = Console.ReadLine();

                    Console.WriteLine("Digite agora o limite  de crédito do cliente:");
                    Console.Write("> ");
                    string limiteDeCredito = Console.ReadLine();

                    decimal limiteDeCreditoEmNumero = decimal.Parse(limiteDeCredito);

                    Console.WriteLine("Digite o endereço do cliente");
                    Console.Write("> ");
                    string endereco = Console.ReadLine();

                    Cliente cliente = new Cliente();
                    cliente.Nome = nomeDoCliente;
                    cliente.LimiteDeCredito = limiteDeCreditoEmNumero;
                    cliente.Endereco = endereco;
                    cliente.Codigo = ++UltimoClienteCadastrado;

                    Clientes.Add(cliente);

                    Console.WriteLine("Parabéns! Você acabou de cadastrar o cliente codigo {0}", cliente.Codigo);

                    Console.ReadKey();

                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Aqui abaixo está a lista de clientes cadastrados: ");
                    Console.WriteLine("");

                    foreach (Cliente cliente in Clientes) 
                    {
                        Console.WriteLine("- Cliente ID {0} - Nome {1} - Limite {2} - Endereço {3}",
                             cliente.Codigo, cliente.Nome, cliente.LimiteDeCredito, cliente.Endereco);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Estes são todos os clientes cadastrados.");

                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Qual é o codigo do cliente que você deseja alterar?");
                    Console.Write("> ");
                    string codigoClienteParaAlteracao = Console.ReadLine();
                    
                    Cliente cliente = null;

                    for (int i = 0; i < Clientes.Count; i++)
                    {
                        Cliente clienteDaLista = Clientes[i];
                        if(clienteDaLista.Codigo.ToString() == codigoClienteParaAlteracao)
                        {
                            cliente = clienteDaLista;
                            break;
                        }
                    }
                    if (cliente == null)
                    {
                        Console.WriteLine("O cliente de código {0} não foi encontrado no cadastro. Tente novamente.", codigoClienteParaAlteracao);
                    }
                    else
                    {
                        Console.WriteLine("Digite abaixo o novo nome do cliente (nome antigo: {0}", cliente.Nome);
                        Console.Write("> ");
                        string novoNome = Console.ReadLine();

                        Console.WriteLine("Digite abaixo o novo limite de crédito do cliente (limite antigo: {0}", cliente.LimiteDeCredito);
                        Console.Write("> ");
                        string novoLimiteDeCredito = Console.ReadLine();
                        decimal limiteDeCreditoEmNumero = decimal.Parse(novoLimiteDeCredito);

                        Console.WriteLine("Digite abaixo o novo enredeço do cliente (endereço antigo: {0}", cliente.Endereco);
                        Console.Write("> ");
                        string novoEndereco = Console.ReadLine();

                        cliente.Nome = novoNome;
                        cliente.LimiteDeCredito = limiteDeCreditoEmNumero;
                        cliente.Endereco = novoEndereco;

                        Console.WriteLine("Parabéns! Você alterou os dados do cliente {0}.", cliente.Codigo);
                    }
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Qual é o codigo do cliente que você deseja remover?");
                    Console.Write("> ");
                    string codigoClienteParaRemover = Console.ReadLine();

                    Cliente cliente = null;

                    for (int i = 0; i < Clientes.Count; i++)
                    {
                        Cliente clienteDaLista = Clientes[i];
                        if (clienteDaLista.Codigo.ToString() == codigoClienteParaRemover)
                        {
                            cliente = clienteDaLista;
                            break;
                        }
                    }
                    if (cliente == null)
                    {
                        Console.WriteLine("O cliente de código {0} não foi encontrado no cadastro. Tente novamente.", codigoClienteParaRemover);
                    }
                    else
                    {
                        Clientes.Remove(cliente);
                        Console.WriteLine("O cliente de codigo {0} foi removido com sucesso.", codigoClienteParaRemover);
                    }
                }
                else if (opcao == "5")
                {
                    Console.WriteLine("Você optou por sair do sistema.");
                    break;
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção invalida.");   
                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
                Console.ReadKey();
            }

            Console.WriteLine(" Obrigado por utilizar nosso sistema de cadastro para clientes.");
            Console.WriteLine("Pressione qualquer tecla para finalizar o programa.");
            Console.ReadKey();
        }

        public static void ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Cadastro de clientes");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma opção abaixo: ");
            Console.WriteLine("1) Cadastrar novo cliente");
            Console.WriteLine("2) Listar todos os clientes");
            Console.WriteLine("3) Alterar os dados de um cliente");
            Console.WriteLine("4) Remover um cliente");
            Console.WriteLine("5) Sair");
            Console.WriteLine("");
            Console.WriteLine("Digite sua opção");
            Console.Write("> ");
        }
    }
}
