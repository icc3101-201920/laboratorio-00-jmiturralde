using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Player
    {
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public int LifePoints { get; set}
        public int AttackPoints { get; set }
        public Deck Deck { get; set }
        public Hand Hand { get; set }
        public SpecialCard Captain { get; set }

        public void DrawCard() { }
        public void PlayerCard(int cardId) { }
        public void ChangeCard(int cardId) { }
        public void FirstHand() { }
        public void ChooseCaptainCard(SpecialCard captainCard) { }
    }
}
}
