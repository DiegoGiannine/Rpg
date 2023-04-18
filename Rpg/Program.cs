using aprimorando_rpg.Personagens;


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
        Mago Ator = new Mago(4, 8, 20, 0);

        Console.WriteLine("Sua chance de acerto será " + Ator.ChanceAcerto);        
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Seu dano será " + Ator.Dano);
        Console.WriteLine("Seus pontos de vida serão " + Ator.PontosDeVida);        
    }
    if (ator.ToLower() == "guerreiro")
    {
        Guerreiro Ator = new Guerreiro(4, 4, 20, 2);

        Console.WriteLine("Sua chance de acerto será " + Ator.ChanceAcerto);       
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Seu dano será " + Ator.Dano);
        Console.WriteLine("Seus pontos de vida serão " + Ator.PontosDeVida);
    }
    if (ator.ToLower() == "arqueiro")
    {
        Arqueiro Ator = new Arqueiro(4, 6, 20, 0);

        Console.WriteLine("Sua chance de acerto será " + Ator.ChanceAcerto);        
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Seu dano será " + Ator.Dano);
        Console.WriteLine("Seus pontos de vida serão " + Ator.PontosDeVida);
    }

    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Em uma rolagem de dados você terá \nque tirar de 1 a 4 para acertar o ataque.");
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

