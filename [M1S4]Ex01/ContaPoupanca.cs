using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S4_Ex01
{// Resolução Ex3 M1S4
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia,cliente) 
        {//Excessão para validar pessoa tipo fisica
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }
        public override void Sacar(decimal valor)
        {
            valor += 0.10M; // Taxa de 0,10 centavos por saque
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.05M; // Taxa de 0,05 centavos por transferências
            base.Transferir(conta, valor);
        }
    }
}
