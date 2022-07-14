using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class Numeros
    {
        public static void run()
        {
            Console.WriteLine("Hello, variaveis!");
            int idade; // usando int
            idade = 21;

            Console.WriteLine("Minha idade eh " + idade); // Nao quebra a linha
            Console.Write("Sua idade? "); // quebra a linha
            string input = Console.ReadLine(); // recebe um input
            int suaIdade = Convert.ToInt16(input); // converte o input str para int16
            Console.WriteLine("Sua idade eh " + suaIdade + "\n"); // exemplo de concatenacao em C#


            Console.Write("Digite n1: ");
            int n1 = Convert.ToInt16(Console.ReadLine()); // recebendo um input direto n1
            Console.Write("Digite n2: ");
            int n2 = Convert.ToInt16(Console.ReadLine()); // recebendo um input direto n2
            int res;

            Console.WriteLine("\nOperações inteiras: ");
            res = n1 + n2;
            Console.WriteLine("" + n1 + " + " + n2 + " = " + res);
            res = n1 - n2;
            Console.WriteLine("" + n1 + " - " + n2 + " = " + res);
            res = n1 * n2;
            Console.WriteLine("" + n1 + " * " + n2 + " = " + res);
            res = n1 / n2;
            Console.WriteLine("" + n1 + " / " + n2 + " = " + res);
            res = n1 % n2;
            Console.WriteLine("" + n1 + " % " + n2 + " = " + res);



            double n3 = 9;
            double n4 = 4;
            double res_d; //convencao por efeito colateral (8 / 3) == 2, (8.0 / 3) == 2.6666...
            Console.WriteLine("Operacoes double: ");
            res_d = n3 + n4;
            Console.WriteLine("" + n3 + " + " + n4 + " = " + res_d);
            res_d = n3 - n4;
            Console.WriteLine("" + n3 + " - " + n4 + " = " + res_d);
            res_d = n3 * n4;
            Console.WriteLine("" + n3 + " * " + n4 + " = " + res_d);
            res_d = n3 / n4;
            Console.WriteLine("" + n3 + " / " + n4 + " = " + res_d);
            res_d = n3 % n4;
            Console.WriteLine("" + n3 + " % " + n4 + " = " + res_d);


            int n5_double = 5;
            Console.WriteLine("\nConvertendo um int \'" + n5_double + "\' em double ...");
            double n5_int = (double)n5_double;
            Console.WriteLine("Precisei criar uma nova variável pra isso");
            Console.WriteLine("Agora temos " + n5_double + ", prova: " + n5_double + " / 2.0 = " + (n5_double / 2.0));
            Console.WriteLine("Se eu tentasse fazer \'5 / 2\' receberia \'2\' ao inves de \'2,5\'");

            Console.WriteLine("\nAperte enter para fechar ...");
            Console.ReadLine();
        }
    }
}
