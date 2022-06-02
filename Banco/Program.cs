using System;
using Banco.classes;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Cliente cli = new Cliente();
                //dados do cliente matheus B //nome, Telefone, telefone, cpf, nascimento SEGUINDO A ORDEM do Cliente.cs
                var ClientePrincipal = Cliente.CreateCliente("Matheus B", "Av doutor edson baccarin", 16997009743, "111.111.111-11", new DateTime(1999, 11, 20));
                Console.WriteLine(ClientePrincipal.ToString());
                //dados do cliente matheus R //seguindo a mesma ordem acima
                var ClienteSecundario = Cliente.CreateCliente("Matheus R", "Av jose alberto", 1698059954, "222.222.222-22", new DateTime(2002, 05, 20));
                Console.WriteLine(ClienteSecundario.ToString());

                Conta ContaPoupancaOne = new Poupanca(ClientePrincipal, 12297, 2000);
                Console.WriteLine($"Matheus B : {ContaPoupancaOne.Saldo}");

                Conta ContaCorrenteTwo = new Corrente(ClienteSecundario, 12297, 300);
                Console.WriteLine($"Matheus R : {ContaCorrenteTwo.Saldo}");
                //Transferir dentro do ContaPoupancaOne
                ContaPoupancaOne.Trasferir(1000, ContaCorrenteTwo);//valor a ser transferido

                Console.WriteLine($"Matheus B = {ContaCorrenteTwo.Saldo}");
                Console.WriteLine($"Matheus R = {ContaPoupancaOne.Saldo}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
    }
}
