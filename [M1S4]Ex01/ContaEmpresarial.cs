using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S4_Ex01
{// Resolução Ex3_04_05_06 - M1S4
    public class ContaEmpresarial:ContaBancaria
    {//Resolução Ex4 M1S4

        public Decimal LimiteEmprestimo { get; private set; }
        public Decimal TaxasJuros { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public Decimal ValorUsado { get; private set; }
        public string CNPJ { get; private set; }

       
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal LimiteEmprestimo, decimal TaxasJuros, string CNPJ) : base(numero, agencia, cliente)
        {
            LimiteEmprestimo = LimiteEmprestimo;
            TaxasJuros = TaxasJuros;
            CNPJ = CNPJ;

            //excessão para validar tipo pessoa Juridica
            if (Cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
            throw new ArgumentException("Cliente precisa ser do tipo Juridico");
            }
        }
        public void FazerEmprestimo(Decimal valor)
        {
            if(valor <=0)
            {
                Console.WriteLine("O valor precisa ser maior que zero!");
                return;
            }
            if(PossuiEmprestimo)
            {
                Console.WriteLine("Você já possui um emprestimo ativo!");
                return;
            }
            if(valor > LimiteEmprestimo)
            {
                Console.WriteLine("O valor ultrapasa o seu limite de emprestimo disponivel!");
                return;
            }
            PossuiEmprestimo = true;
            ValorUsado = valor;
            Console.WriteLine($"Emprestimo no valor de R${valor} realizado com sucesso!");
        }
            public void PagarEmprestimo()
        {
            decimal total = ValorUsado + (ValorUsado * TaxasJuros / 100);
            if(total > Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar o pagamento!");
                return;
            }
            Sacar(total);
            PossuiEmprestimo = false;
            ValorUsado = 0;
            Console.WriteLine($"Emprestimo no valor total de R${total} pago com sucesso!");
            }
        public override void Sacar(decimal valor)
        {
            valor += 1;
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.50M;
            base.Transferir(conta, valor);
        }
    }
}
