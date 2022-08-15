using bytebank_adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double TotalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.getBonificacao();
        }
        
        public double getBonificacao() {
            return this.TotalBonificacao;
        }
    }
}
