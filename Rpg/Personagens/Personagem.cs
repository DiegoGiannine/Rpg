using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprimorando_rpg.Personagens
{
    public abstract class Personagem
    {               
        public int ChanceAcerto { get;  set; }
        public int Dano { get;  set; }
        public int PontosDeVida { get;  set; }
        public int Armadura { get;  set; }
        public int Esquiva { get;  set; }

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
