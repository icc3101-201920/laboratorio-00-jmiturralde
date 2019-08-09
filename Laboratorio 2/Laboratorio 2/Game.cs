using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Game
    {
        private Player[] players;
        private Board boardGame;
        private Player activePlayer;
        private bool endGame;

        public Player[] Players { get; set}
        public Board BoardGame { get;set }
        public Player ActivePlayer { get; set }
        public bool EndGame { get; set }

        public bool CheckIfEndGame() { }
        public int GetWinner() { }
        public void Play() { }

    }
}
