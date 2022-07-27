using bytebank_ADM.SistemaInterno;
using System;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticavel
    {

        public GerenteDeContas(string nome, string cpf, string senha): base(nome, cpf, 4000, senha)
        {
            Console.WriteLine("Criando um Gerente de Contas ...");
        }

        public override void aumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double bonificacao()
        {
            return Salario * 0.25;
        }

    }
}
