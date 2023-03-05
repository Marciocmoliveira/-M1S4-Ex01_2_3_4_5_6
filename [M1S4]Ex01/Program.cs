

using _M1S4_Ex01;
Cliente pessoaJuridica = new Cliente("Márcio Oliveira", DateTime.Parse("1980-10-22"), "Técnico em Eletrônica", "Casado", TipoPessoaEnum.FISICA);

ContaEmpresarial contaJuridica = new ContaEmpresarial(1542, 1234, pessoaJuridica, 1500, 10, "04528241000123");

contaJuridica.FazerEmprestimo(1200);
contaJuridica.Depositar(200);
contaJuridica.ExibirSaldo();
contaJuridica.PagarEmprestimo();
contaJuridica.ExibirSaldo();

Cliente pessoaFisica = new Cliente("Bruno Costa", DateTime.Parse("1999-01-25"), "Desenvolvedor", "Casado", TipoPessoaEnum.JURIDICA);

ContaCorrente contaCorrente = new ContaCorrente(1786, 7580, pessoaFisica);

contaCorrente.Depositar(350);
contaCorrente.Sacar(100);
contaCorrente.ExibirSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(1542, 1234, pessoaFisica);

contaPoupanca.Depositar(320);
contaPoupanca.Transferir(contaCorrente, 80);
contaPoupanca.ExibirSaldo();