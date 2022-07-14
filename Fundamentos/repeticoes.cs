using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class Repeticoes
    {
        public static void run()
        {
            Console.WriteLine("Olá, repeticoes");

            Console.WriteLine("As estruturas de repeticao sao basicamente as mesmas de C e C++");
            Console.Write("Vamos calcular um fatorial? Diga um numero ");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.Write("O fatorial de " + n + " eh: ");

            for (int i = 0, res = 1; i < n; i++)
            {
                res *= (i + 1);
                if (i == (n - 1))
                    Console.WriteLine(res);
            }
            Console.WriteLine("\nAgora, vamos imprimir todos os números multiplos de 3 entra 0 e 100 ...");
            n = 0;
            while (n <= 100)
            {
                n++;
                if (n % 3 == 0)
                    Console.Write(n + " ");
            }

            Console.WriteLine("\n\nAgora, vamos desenhar triangulos");
            Console.Write("Qual o tamanho do triangulo? ");
            n = Convert.ToInt64(Console.ReadLine());

            long aux = 1;
            do
            {

                for (int i = 0; i < aux; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                aux++;

            } while (n >= aux);

            Console.WriteLine("\nDigite enter para sair ...");
            Console.ReadLine();
        }
    }
}
