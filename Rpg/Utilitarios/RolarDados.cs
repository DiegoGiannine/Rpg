using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Utilitarios
{
    public class RolagemDeDados
    {
        public int  RolarDado()

        {
            Random random = new Random();
            int rolagem = random.Next(1, 7);
            return rolagem;
        }
    }
}
 