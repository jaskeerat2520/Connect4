using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    internal class Connect4Game
    {

        public Connect4Game(GameBoard board, List<Player> players)
        {
            gameBoard = board;
            this.players = players;
            currentPlayerIndex = 0; // Start with the first player
        }

        private GameBoard gameBoard;
        List <Player> players;
        private int currentPlayerIndex;
        private Boolean isDraw;
        string winner;
        string currentPlayer;
        private Boolean isOver;
        private  bot botPlayer;

        public Cells[,] Board
        {
            get { return gameBoard.Board; }
            set { gameBoard.Board = value; }
        }



        public void changeTurn()
        {
            MessageBox.Show("ai works");
           


             


            
        }




    }
}
