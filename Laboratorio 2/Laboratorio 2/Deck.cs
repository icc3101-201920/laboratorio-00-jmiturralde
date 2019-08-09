using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Deck
    {
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        public List<CombatCard> CombatCards { get; set}
        public Board BoardGame { get; set }

        public bool CheckIfEndGame() { }
        public int GetWinner() { }
        public void Play() { }

    }
}
