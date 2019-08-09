using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Board
    {
        private List<CombatCard> meleeCard;
        private List<CombatCard> rangeCards;
        private List<CombatCard> longRangeCards;
        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;
        private List<SpecialCard> captainCards;
        private List<SpecialCard> weatherCards;

        public List<CombatCard> MeleeCards { get; set}
        public List<CombatCard> RangeCards { get; set}
        public List<CombatCard> LongRangeCards { get; set}
        public SpecialCard[] SpecialMeleeCards { get; set }
        public SpecialCard[] SpecialRangeCards { get; set }
        public SpecialCard[] SpecialLongRangeCards { get; set }
        public List<SpecialCard> CaptainCards { get; set }
        public List<SpecialCard> WheatherCards { get; set }

        public void AddComnatCard(int playerId, CombatCard combatCard) { }
        public void AddSpecialCard(int playerId, SpecialCard specialCard) { }
        public void DestroyCombatCards() { }
        public void DestroySpecialCards() { }
        public int[] GetMeleeAttackPoints() { }
        public int[] GetRangeAttackPoints() { }
        public int[] GetLongRangeAttackPoints() { }





    }
}
