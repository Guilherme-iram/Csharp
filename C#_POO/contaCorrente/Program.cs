using bank;

{
    ContaCorrente conta1 = new ContaCorrente(
        "Carlos",
        "123.456.789-11",
        "Programador Python",
        "1234-5",
        "Bank Bank",
        123
    );

    ContaCorrente conta2 = new ContaCorrente(
        "Ana",
        "234.567.890-99",
        "Programadora C#",
        "2345-6",
        "Bank Bank",
        234
    );

    conta1.Saldo = 250;
    conta2.Saldo = 750;

    conta1.dadosDaConta();
    conta2.dadosDaConta();

    conta1.sacar(50);
    conta2.sacar(100);
    conta1.extrato();
    conta2.extrato();

    conta1.depositar(100);
    conta2.depositar(200);
    conta1.extrato();
    conta2.extrato();

    conta1.transferir(200, conta2);
    conta1.extrato();
    conta2.extrato();

    Console.ReadKey();
    
}