using bank.cliente;

namespace bank

{
    public class ContaCorrente
    {
        private Cliente _titular;
        private string _conta;
        private int _numeroAgencia;
        private string _nomeAgencia;
        private double _saldo;

        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
        public string Conta { 
            
            get
            {
                return _conta;
            }
            set
            {
                _conta = value;
            }
        }
        public int NumeroAgencia { 
            
            get
            {
                return _numeroAgencia;
            }
            set
            {
                _numeroAgencia = value;
            }
        }
        public string NomeAgencia { 
            
            get
            {
                return _nomeAgencia;
            }
            set
            {
                _nomeAgencia = value;
            }

        }
        public double Saldo { 
            
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }

        }
        public static int NumeroDeContasCriadas { get; set; }

        public ContaCorrente(string nome, string cpf, string profissao, string conta, string nomeAgencia, int numeroAgencia)
        {
            Titular = new Cliente(nome, cpf, profissao);
            Conta = conta;
            NomeAgencia = nomeAgencia;
            NumeroAgencia = numeroAgencia;
            NumeroDeContasCriadas++;
        }
        public void dadosDaConta()
        {
            Console.WriteLine($"Titular da conta: {Titular.Nome}");
            Console.WriteLine($"Cpf do titular da conta: {Titular.Cpf}");
            Console.WriteLine($"Profissão do titular da conta: {Titular.Profissao}");
            Console.WriteLine($"Número da conta: {Conta}");
            Console.WriteLine($"Agência: {NomeAgencia}");
            Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", Saldo)}\n");
        }

        public void extrato()
        {
            Console.WriteLine($"({Titular.Nome}) Saldo R$ {String.Format("{0:0.00}", Saldo)}\n");
        }
        public bool sacar(double valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool transferir(double valor, ContaCorrente destinatario)
        {
            if (this.sacar(valor) && destinatario.depositar(valor))
                return true;
            else
                return false;
        }

    }
}