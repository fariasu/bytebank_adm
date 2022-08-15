using bytebank_adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf):base(cpf, 4000)
        {
            Console.WriteLine("Criando Gerente de Contas.");
        }
        
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }


        public override double getBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
