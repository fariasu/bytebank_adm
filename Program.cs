using bytebank_adm.Funcionarios;
using bytebank_adm.SistemaInterno;
using bytebank_adm.Utilitarios;

CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer farias = new Designer("123.222.123-90");
    farias.Nome = "Farias";

    Desenvolvedor garcia = new Desenvolvedor("333.312.321-00");
    garcia.Nome = "Garcia";

    Diretor pablo = new Diretor("312.333.321-99");
    pablo.Nome = "Pablo";

    Auxiliar galarce = new Auxiliar("111.222.333-44");
    galarce.Nome = "Galarce";

    GerenteDeContas fernanda = new GerenteDeContas("222.333.444-99");
    fernanda.Nome = "Fernanda";

    gerenciador.Registrar(farias);
    gerenciador.Registrar(garcia);
    gerenciador.Registrar(pablo);
    gerenciador.Registrar(galarce);
    gerenciador.Registrar(fernanda);

    Console.WriteLine($"Total de Bonificação: {gerenciador.getBonificacao()}");
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Login = "Rob";
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("326.985.628-89");
    ursula.Nome = "Ursula";
    ursula.Login = "Urs";
    ursula.Senha = "321";

    sistemaInterno.Logar(roberta, "123", "Rob");

    sistemaInterno.Logar(ursula, "321", "Urs");
}

Console.ReadKey();