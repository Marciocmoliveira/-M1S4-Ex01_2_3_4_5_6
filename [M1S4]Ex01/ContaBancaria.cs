using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S4_Ex01
    //Resolução Ex2 M1S4
{
    public  class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Decimal Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = 0; // tipo decimal sempre inicia em 0
            Cliente = cliente;
           
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            //Valida se o valor transferido é maior que 0
            if(valor <= 0)
            {
                Console.WriteLine("Seu saldo tem que ser maior que Zero!");
                return;
            }
            if(valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }
            Saldo = Saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R${valor} transferido com susseço!");
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                Saldo = Saldo + valor;
            }
        }

        
        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;

            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;

            }
            else
            {
                Saldo = Saldo - valor;
            }
            Console.WriteLine($"Saque de R${valor} realizado com susseço!");
        }

        
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R${Saldo}.");
        }
    }
}
