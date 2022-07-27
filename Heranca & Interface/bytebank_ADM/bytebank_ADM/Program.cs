using System;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;

Console.WriteLine("- - Byte Bank - -\n");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Auxiliar Carlos = new Auxiliar("Carlos", "123.456.789-11");
Console.WriteLine("Numero de funcionarios: " + Funcionario.numeroFuncionarios);

Designer Thereza = new Designer("Thereza", "222.333.444-55");
Console.WriteLine("Numero de funcionarios: " + Funcionario.numeroFuncionarios);

Diretor Ana = new Diretor("Ana", "234.567.890-22", "123");
Console.WriteLine("Numero de funcionarios: " + Funcionario.numeroFuncionarios);

GerenteDeContas Daniel = new GerenteDeContas("Daniel", "333.444.555-66", "123");
Console.WriteLine("Numero de funcionarios: " + Funcionario.numeroFuncionarios);

Carlos.info();
Thereza.info();
Ana.info();
Daniel.info();

Carlos.aumentarSalario();
Thereza.aumentarSalario();
Ana.aumentarSalario();
Daniel.aumentarSalario();

Carlos.info();
Thereza.info();
Ana.info();
Daniel.info();

gerenciador.Registrar(Carlos);
gerenciador.Registrar(Thereza);
gerenciador.Registrar(Ana);
gerenciador.Registrar(Daniel);

Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

UsarSistema();
CalcularBonificacao();

static void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor samya = new Diretor("Sâmya", "159.753.398-04", "asd");

    GerenteDeContas brenda = new GerenteDeContas("Brenda", "326.985.628-89", "qwe");

    ParceiroComercial parceiro = new ParceiroComercial();
    parceiro.Senha = "123456";

    sistemaInterno.Logar(parceiro, "123456");
    sistemaInterno.Logar(samya, "asd");
    sistemaInterno.Logar(brenda, "qwe");
}


static void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciadorBonificacao = new GerenciadorDeBonificacao();

    Funcionario pedro = new Designer("Pedro", "833.222.048-39");

    Funcionario roberta = new Diretor("Roberta", "159.753.398-04", "123");

    Funcionario igor = new Auxiliar("Igor", "981.198.778-53");

    Funcionario camila = new GerenteDeContas("Camila", "326.985.628-89", "234");

    gerenciadorBonificacao.Registrar(pedro);
    gerenciadorBonificacao.Registrar(roberta);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(camila);

    Console.WriteLine("Total de bonificações do mês " +
    gerenciadorBonificacao.GetTotalBonificacao());
}
