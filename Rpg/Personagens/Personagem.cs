using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprimorando_rpg.Personagens
{
    public abstract class Personagem
    {               
        public int ChanceAcerto { get; protected set; }
        public int Dano { get; protected set; }
        public int PontosDeVida { get; protected set; }
        public int Armadura { get; protected set; }
        public int Esquiva { get; protected set; }

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
