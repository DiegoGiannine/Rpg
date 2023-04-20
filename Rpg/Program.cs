using aprimorando_rpg.Personagens;
using Rpg.Utilitarios;

 
Arqueiro atorArqueiro = new Arqueiro();
Mago atorMago = new Mago();
Guerreiro atorGuerreiro = new Guerreiro();

RolagemDeDados rolarDados = new RolagemDeDados();


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

    Goblin goblin = new Goblin();

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

        int acerto = rolarDados.RolarDado();
        Console.WriteLine(acerto);

        if (ator.ToLower() == "arqueiro" || ator.ToLower() == "guerreiro" || ator.ToLower() == "mago")
        {
            if (acerto <= atorArqueiro.ChanceAcerto + atorArqueiro.Esquiva || acerto <= atorGuerreiro.ChanceAcerto + atorGuerreiro.Esquiva || acerto <= atorMago.ChanceAcerto + atorMago.Esquiva)
            {
                Console.WriteLine("Você passou despercebido");
            }
            else
            {
                Console.WriteLine("Você foi percebido, \ngoblin atacará você");
                Console.ReadKey();
                Console.WriteLine("Pressione Enter para ver a rolagem do goblin");
                Console.ReadKey();

                acerto = rolarDados.RolarDado();
                Console.WriteLine(acerto);
                if (ator.ToLower() == "arqueiro" && acerto <= goblin.ChanceAcerto - atorArqueiro.Esquiva || ator.ToLower() != "arqueiro" && acerto <= goblin.ChanceAcerto)
                {
                    if (ator.ToLower() == "arqueiro")
                    {
                        Console.WriteLine("Goblin acertou você tirando " + goblin.Dano + " pontos de vida");
                        atorArqueiro.PontosDeVida -= goblin.Dano;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Seus pontos de vida são " + atorArqueiro.PontosDeVida);
                             
                    }
                    if (ator.ToLower() == "mago")
                    {
                        Console.WriteLine("Goblin acertou você tirando " + goblin.Dano + " pontos de vida");
                        atorMago.PontosDeVida -= goblin.Dano;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Seus pontos de vida são " + atorMago.PontosDeVida);

                    }
                    else
                    {
                        Console.WriteLine("Goblin acertou você tirando " + (goblin.Dano - atorGuerreiro.Armadura) + " pontos de vida");
                        atorGuerreiro.PontosDeVida -= (goblin.Dano - atorGuerreiro.Armadura);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Seus pontos de vida são " + atorGuerreiro.PontosDeVida);
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Você inicia o ataque");
    }
    
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Aperte Enter para fazer a sua rolagem de acerto");
    Console.ReadKey();

    Console.WriteLine(rolarDados.RolarDado());
    

    Console.WriteLine("Você salvou sua família");
    Console.WriteLine("FIM!!!");
    Console.ReadKey();
    
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

