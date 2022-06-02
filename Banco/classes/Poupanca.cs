using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.classes
{
    class Poupanca : Conta
    {
        public Poupanca(Cliente cliente, int numero, decimal saldo)
           : base( cliente,  numero,  saldo)
        {

        }    
        public override bool Depositar(decimal ValorDepositar)
        {
            if(ValorDepositar <= 0 )
            {
                Mensaguemtrans = $"O valor do deposito é invalido !";
                return false;
            }
            Saldo += (ValorDepositar + 0.5m);
            Mensaguemtrans = $"Depositado com sucesso";
            return true;
        }      

        public override bool Sacar(decimal ValorSaque)
        {
            if(Saldo <= 0m)
            {
                Mensaguemtrans = $"Saldo da conta negativo ou zerado";
                return false;
            }
            if(Saldo < ValorSaque)
            {
                Mensaguemtrans = $"Valor indisponivel para saque, valor na conta =R${Saldo}";
                return false;
            }
            Saldo -= (ValorSaque - 0.10m);
            Mensaguemtrans = "Saque realizado com sucesso";
                return true;
                
                
        }
    }
}
