﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class Desenvolvedor: Funcionario
    {
        public Desenvolvedor(string cpf):base(cpf, 3000)
        {
            Console.WriteLine("Criando um Desenvolvedor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
