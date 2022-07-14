using System;

namespace Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá, fundamentos C#");
            int escolha;

            Console.Write("Escolha um dos programas abaixo \n\t1 - numeros\n\t2 - texto\n\t3 - condicionais\n\t4 - repeticao\nQual executar? ");
            escolha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (escolha == 1)
                Numeros.run();
            else if (escolha == 2)
                Texto.run();
            else if (escolha == 3)
                Condicionais.run();
            else if (escolha == 4)
                Repeticoes.run();
            else
                Console.WriteLine("Opcao invalida!");

        }
    }

}