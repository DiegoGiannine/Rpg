using aprimorando_rpg.Personagens;
using Rpg.Utilitarios;

Arqueiro atorArqueiro = new Arqueiro(4, 6, 20, 0, 1);

Mago atorMago = new Mago(4, 8, 20, 0, 0);

Guerreiro atorGuerreiro = new Guerreiro(4, 4, 20, 2, 0);

RolagemDeDados rolarDados = new RolagemDeDados();

int acerto;


Console.WriteLine("Em uma cidadizinha na região metropolitana \nde Minas Gerais, ");
Console.ReadKey();
Console.WriteLine();
Console.WriteLine("havia um jovem onde sua vida estaria \nprestes a mudar....");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Em uma bela manhã, quando ele acabou de acordar, \ndescobre que sua família havia sido sequestrada. " +
    "\nLendo uma nota deixada pelos sequestradores, \ntinha um pedido de resgate, que pedia ao jovem " +
    "\npara levar toda a fortuna de sua familia, \nà uma caverna denominada Biquinha.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Você quer salvar sua família? (sim ou não)");

string salvarSimOuNao = Console.ReadLine();

while (salvarSimOuNao.ToLower() != "sim" && salvarSimOuNao.ToLower() != "não")
{
    salvarSimOuNao = Console.ReadLine();
}

if (salvarSimOuNao.ToLower() == "sim")
{
    Console.Clear();
    Console.WriteLine("Então você decide salvar sua familia.");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Qual classe você escolhe?");    
    Console.WriteLine("Guerreiro, Arqueiro ou Mago?");

    string ator = Console.ReadLine();

    while (ator.ToLower() != "guerreiro" && ator.ToLower() != "arqueiro" && ator.ToLower() != "mago")
    {
        ator = Console.ReadLine();
    }

    if (ator.ToLower() == "mago")
    {        
        Console.WriteLine("Sua chance de acerto será " + atorMago.ChanceAcerto);        
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Seu dano será " + atorMago.Dano);
        Console.WriteLine("Seus pontos de vida serão " + atorMago.PontosDeVida);        
    }
    if (ator.ToLower() == "guerreiro")
    {        
        Console.WriteLine("Sua chance de acerto será " + atorGuerreiro.ChanceAcerto);       
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Seu dano será " + atorGuerreiro.Dano);
        Console.WriteLine("Seus pontos de vida serão " + atorGuerreiro.PontosDeVida);
    }
    if (ator.ToLower() == "arqueiro")
    {
        Console.WriteLine("Sua chance de acerto será " + atorArqueiro.ChanceAcerto);        
        Console.WriteLine("Seu dano será " + atorArqueiro.Dano);
        Console.WriteLine("Seus pontos de vida serão " + atorArqueiro.PontosDeVida);
        Console.WriteLine("Sua esquiva será " + atorArqueiro.Esquiva);
        Console.ReadKey();
        Console.Clear();
    }
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Em uma rolagem de dados você terá \nque tirar de 1 a 4 para acertar o ataque.");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Chegando na entrada da Biquinha, \nvocê se depara com uma criatura goblin \n" +
                    "fazendo uma ronda de vigia");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("O que você faz?");
    Console.WriteLine("Ataca ou espera, para tentar passar despercebido \n" +
        "(atacar ou esperar)");

    string atacarOuEsperar = Console.ReadLine();

    while (atacarOuEsperar.ToLower() != "atacar" && atacarOuEsperar.ToLower() != "esperar")
    {
        atacarOuEsperar = Console.ReadLine();
    }
    if (atacarOuEsperar.ToLower() == "esperar")
    {
        Console.Clear();
        Console.WriteLine("Pressione Enter para fazer uma rolagem,");
        Console.ReadKey();

        acerto = rolarDados.RolarDado();
        Console.WriteLine(acerto);

        if (ator.ToLower() == "arqueiro")
        {            
            if (acerto <= (atorArqueiro.ChanceAcerto + atorArqueiro.Esquiva))
            {
                Console.WriteLine("Você passou despercebido");
            }
            else
            {
                Console.WriteLine("Você foi percebido, \ngoblin atacará você");
            }
        }
        if (ator.ToLower() == "guerreiro")
        {
            if (acerto <= atorGuerreiro.ChanceAcerto + atorGuerreiro.Esquiva)
            {
                Console.WriteLine("Você passou despercebido");
            }
            else 
            {
                Console.WriteLine("Você foi percebido, \ngoblin atacará você");
            }
        }
        else
        {
            if (acerto <= atorMago.ChanceAcerto + atorMago.Esquiva)
            {
                Console.WriteLine("Você passou despercebido");
            }
            else
            {
                Console.WriteLine("Você foi percebido, \ngoblin atacará você");
            }
        }
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Você salvou sua família");
        Console.WriteLine("FIM!!!");
        Console.ReadKey();
    }




}
else
{
    if (salvarSimOuNao.ToLower() == "não")
    {
        Console.WriteLine("Sua família morreu");
        Console.WriteLine("Fim de jornada");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

