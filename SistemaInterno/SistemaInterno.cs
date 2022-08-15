using bytebank_adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel autenticavel, string senha, string login)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(senha, login);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }
    }
}
