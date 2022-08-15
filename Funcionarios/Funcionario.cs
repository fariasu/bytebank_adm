using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
      
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();


        public abstract double getBonificacao();
       
    }
}
