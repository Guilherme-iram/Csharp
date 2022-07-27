﻿using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.bonificacao();
        }

        public double GetTotalBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
