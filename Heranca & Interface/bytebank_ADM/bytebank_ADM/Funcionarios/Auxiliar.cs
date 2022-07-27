using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string nome, string cpf): base(nome, cpf, 2000)
        {
            Console.WriteLine("Criando auxiliar ...");
        }

        public override void aumentarSalario()
        {
            Salario *= 1.10;
        }

        public override double bonificacao()
        {
            return Salario * 0.20;
        }

    }
}
