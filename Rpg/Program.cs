using aprimorando_rpg.Personagens;
using Rpg.Personagens;
using Rpg.Utilitarios;

 
Ator ator = new Ator(0, 0, 0, 0, 0);

RolagemDeDados rolarDados = new RolagemDeDados();
int acerto;


Console.WriteLine("Em uma cidadizinha na região metropolitana \nde Minas Gerais, ");
Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Havia um jovem onde sua vida estaria \nprestes a mudar....");
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

    string personagem = Console.ReadLine();

    while (personagem.ToLower() != "guerreiro" && personagem.ToLower() != "arqueiro" && personagem.ToLower() != "mago")
    {
        personagem = Console.ReadLine();
    }

    if (personagem.ToLower() == "mago")
    {
        ator.ChanceAcerto = 4;
        ator.Dano = 8;
        ator.PontosDeVida = 20;
        Console.WriteLine("Sua chance de acerto será " + ator.ChanceAcerto);        
        Console.WriteLine("Seu dano será " + ator.Dano);
        Console.WriteLine("Seus pontos de vida serão " + ator.PontosDeVida);
    }
    if (personagem.ToLower() == "guerreiro")
    {
        ator.ChanceAcerto = 4;
        ator.Dano = 4;
        ator.PontosDeVida = 20;
        ator.Armadura = 1;
        Console.WriteLine("Sua chance de acerto será " + ator.ChanceAcerto);        
        Console.WriteLine("Seu dano será " + ator.Dano);
        Console.WriteLine("Seus pontos de vida serão " + ator.PontosDeVida);
        Console.WriteLine("Sua armadura será " + ator.Armadura);
        Console.WriteLine("Que reduzirá o dano recebido em " + ator.Armadura);
    }
    if (personagem.ToLower() == "arqueiro")
    {
        ator.ChanceAcerto = 4;
        ator.Dano = 6;
        ator.PontosDeVida = 20;
        ator.Esquiva = 1;
        Console.WriteLine("Sua chance de acerto será " + ator.ChanceAcerto);
        Console.WriteLine("Seu dano será " + ator.Dano);
        Console.WriteLine("Seus pontos de vida serão " + ator.PontosDeVida);
        Console.WriteLine("Sua esquiva será " + ator.Esquiva);        
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

    switch (atacarOuEsperar.ToLower())
    {
        case "esperar":
            Console.Clear();
            Console.WriteLine("Pressione Enter para fazer uma rolagem,");
            Console.ReadKey();

            acerto = rolarDados.RolarDado();
            Console.WriteLine(acerto);
            Console.ReadKey();

           if(acerto <= ator.ChanceAcerto + ator.Esquiva)
           {                
                Console.WriteLine("Você passou despercebido");
                atacarOuEsperar = "passou despercebido";
                Console.ReadKey();
                break;            
           }
           else
           {
               Console.WriteLine("Você foi percebido, \ngoblin atacará você");
               Console.ReadKey();
               Console.WriteLine("Pressione Enter para ver a rolagem do goblin");
               Console.ReadKey();

               acerto = rolarDados.RolarDado();
               Console.WriteLine(acerto);
               if (acerto <= goblin.ChanceAcerto - ator.Esquiva)
               {                    
                   Console.WriteLine("Goblin acertou você tirando " + (goblin.Dano - ator.Armadura) + " pontos de vida");
                   ator.PontosDeVida -= goblin.Dano;
                   Console.ReadKey();
                   Console.Clear();
                   Console.WriteLine("Seus pontos de vida são " + ator.PontosDeVida);                                
               }
                break;
           }            
           
        case "atacar":

            Console.WriteLine("Você inicia o ataque");
            break;
    }
    if (atacarOuEsperar.ToLower() == "passou despercebido")
    {        
        Console.WriteLine("Você salvou sua família");
        Console.WriteLine("FIM!!!");
        Console.ReadKey();
        Environment.Exit(0);        
    }
    while (ator.PontosDeVida > 0 && goblin.PontosDeVida > 0)
    {
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Aperte Enter para fazer a sua rolagem de acerto");
        Console.ReadKey();

        acerto = rolarDados.RolarDado();
        Console.WriteLine(acerto);
        Console.ReadKey();
        if (acerto <= ator.ChanceAcerto - goblin.Esquiva)
        {
            Console.WriteLine("Você acertou o goblin tirando " + (ator.Dano - goblin.Armadura) + " pontos de vida");
            goblin.PontosDeVida -= ator.Dano;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Os pontos de vida do goblin são " + goblin.PontosDeVida);
        }
        else
        {
            Console.WriteLine("Você errou o ataque");
        }
        if (goblin.PontosDeVida > 0)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Aperte Enter para ver a rolagem de acerto do goblin");
            Console.ReadKey();

            acerto = rolarDados.RolarDado();
            Console.WriteLine(acerto);
            Console.ReadKey();
            if (acerto <= goblin.ChanceAcerto - ator.Esquiva)
            {
                Console.WriteLine("O goblin acertou você tirando " + goblin.Dano + " pontos de vida");
                Console.WriteLine("menos o valor da sua armadura " + ator.Armadura);
                ator.PontosDeVida -= (goblin.Dano - ator.Armadura);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Os seus pontos de vida são " + ator.PontosDeVida);
            }
            else
            {
                Console.WriteLine("Goblin errou o ataque");
            }
        }
    }
    Console.WriteLine("O goblin morreu");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Parabéns");
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
