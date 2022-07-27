using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
            Console.WriteLine("Criando um design ...");
        }

        public override void aumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double bonificacao()
        {
            return Salario * 0.17;
        }


    }
}
