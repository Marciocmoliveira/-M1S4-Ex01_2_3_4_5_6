using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S4_Ex01
{// Resolução Ex3 M1S4
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente (int numero, int agencia, Cliente cliente) :  base(numero, agencia, cliente)
        {
            // Excessão para validar pessoa física
            if ( Cliente.TipoPessoa != TipoPessoaEnum.FISICA )
            {
            throw new ArgumentException("Cliente precisa ser do tipo física!" );
            }
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.25M; // Taxa de 0,25 centacos por transferência
            base.Transferir(conta, valor);
        }

    }


}
