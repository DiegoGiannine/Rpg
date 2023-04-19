using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprimorando_rpg.Personagens
{
    public class Personagem
    {        
        public string Ator {get; set;}
        public int ChanceAcerto { get; private set; }
        public int Dano { get; private set; }
        public int PontosDeVida { get; private set; }
        public int Armadura { get; private set; }
        public int Esquiva { get; private set; }

        public Personagem(int chanceacerto, int dano, int pontosdevida, int armadura, int esquiva)
        {
            this.ChanceAcerto = chanceacerto;
            this.Dano = dano;
            this.PontosDeVida = pontosdevida;
            this.Armadura = armadura;
            this.Esquiva= esquiva;
        }
    }
}
