using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Hand
    {
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        public List<CombatCard> CombatCards { get;set }
        public List<SpecialCard> SpecialCards { get; set }

        public void AddCombatCard(CombatCard combatCard) { }
        public void AddSpecialCard(SpecialCard specialCard) { }
        public void DestroyCombatCard(int cardId) { }
        public void DestroySpecialCard(int cardId) { }


    }
}
