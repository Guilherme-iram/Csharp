using System;

namespace condicionais
{   
    public class program
    {
        static void Main(string[] args){

        Console.WriteLine("Ola, condicionais");
        Console.WriteLine("Usando if, else if e else ...\n");
        
        int idade;
        Console.Write("Qual a sua idade? ");
        
        string input = Console.ReadLine();
        idade = Convert.ToInt16(input);

        //sistema de condicionais igual ao C e ao C++
        if (idade >= 60) 
            Console.WriteLine("Você é idoso (" + idade + ")");
        else if (idade >= 18)
            Console.WriteLine("Você é adulto (" + idade + ")");
        else if (idade >= 14)
            Console.WriteLine("Você é adolescente (" + idade + ")");
        else if (idade >= 0)
            Console.WriteLine("Você é criança (" + idade + ")");
        
        if (idade >= 18){
            double salario = 0.0;
            Console.Write("\nSe você trabalha, digite o seu salário, caso não, digite 0: R$ ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario > 0){
                Console.WriteLine("Seu salário com aumento de 10%: R$ " + (salario * 1.1));
                Console.WriteLine("Seu salário com um corte de 10%: R$ " + (salario * 0.9));
            }
            Console.WriteLine("Lembrando que a variavel \'salario\' so existe no escopo deste if");
        }else{
            Console.WriteLine("Você provavelmente não tem emprego.");
        }

        Console.Write("\nAgora escolha um núme de 1 a 5: ");
        int escolha;
        Console.Write("Qual a sua idade? ");
        input = Console.ReadLine();
        escolha = Convert.ToInt16(input);

        switch (escolha){ //Uso do switch case
            case 1:
                Console.WriteLine("Você ganhou uma torta");
                break;

            case 2:
                Console.WriteLine("Você ganhou uma torrada");
                break;
            case 3:
                Console.WriteLine("Você ganhou uma torneira");
                break;
            case 4:
                Console.WriteLine("Você ganhou uma tangerina");
                break;
            case 5:
                Console.WriteLine("Você ganhou uma tartaruga");
                break;

            default:
                Console.WriteLine("Número invalido! Reinicie o programa");
                break;
        }   
            
        Console.WriteLine("Aperte enter para encerrar ...");
        Console.ReadLine();

        }
    }
}