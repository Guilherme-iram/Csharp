using System;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            Console.WriteLine("Criando funcionario ...");
            numeroFuncionarios++;
        }

        public abstract double bonificacao();

        public abstract void aumentarSalario(); // Metodo virtual que pode ser sobrescrito por uma classe filha vida override
        
        public virtual void info()
        {
            Console.WriteLine("\nNome: " +  Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Salario: R$ " +  Salario);
            Console.WriteLine("Bonificacao: R$ " + bonificacao() + "\n") ;

        }

        public static int numeroFuncionarios
        { get; private set; }
    }
}
