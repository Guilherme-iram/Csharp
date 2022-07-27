using System;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf, string senha) : base(nome, cpf, 5000, senha)
        {
            Console.WriteLine("Criando Diretor ...");
        }

        public override void aumentarSalario() // Metodo virtual que pode ser sobrescrito por uma classe filha vida override
        {
            Salario *= 1.15;
        }

        public override double bonificacao()
        {
            return Salario * 0.5;
        }

    }
}
