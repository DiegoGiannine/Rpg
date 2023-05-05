using aprimorando_rpg.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Personagens
{
    internal class Ator : Personagem
    {
        public Ator(int chanceacerto, int dano, int pontosdevida, int armadura, int esquiva) : base(chanceacerto, dano, pontosdevida, armadura, esquiva)
        {
        }
    }
}
