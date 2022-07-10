using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ola, texto!");

        char letra = 'a';
        Console.WriteLine("Caracter: " + letra);
        letra = (char) 65; // convertendo int em char
        Console.WriteLine("Caracter: " + letra);
        letra = (char) (65 + 1);
        Console.WriteLine("Caracter: " + letra);
        letra += letra; // soma a parte inteira dos caracteres
        Console.WriteLine("Caracter: " + letra);

        Console.WriteLine("Trabalhando com strings ...");
        string primeiraFrase = "Csharp é uma linguagem de programação";
        Console.WriteLine(primeiraFrase + " interessante\n");
        
        
        string vazia = "";
        Console.WriteLine("String vazia: " + vazia);
        vazia += "conteudo";
        Console.WriteLine("String vazia: " + vazia);

        Console.WriteLine("Uso do @ para listagem em strings: ");
        string lista = @"Lista de compras
banana
    maca
        torta
            cebola";

        Console.WriteLine(lista + '\n');

        Console.WriteLine("Mostrando que o operador \'+\' concatena diferentes tipos numa string ...");
        string saudacao = "Olá, meu nome é ";
        string nome = "Carlos ";
        string continuacao = "e minha idade é ";
        int idade = 27;
        Console.WriteLine(saudacao + nome + continuacao + idade);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}