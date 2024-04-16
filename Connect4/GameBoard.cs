using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    internal class GameBoard
    {
        String turn = "user";
        private readonly int playerId;
        public int win { get; set; }

        public Cells[,] Board { get; set; }

        public GameBoard()
        {
            Board = new Cells[7, 6];

            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    Board[column, row] = new Cells();
                }
            }
        }

        public string GetBoardAsString()
        {
            int numberOfRows = Board.GetLength(1);
            int numberOfColumns = Board.GetLength(0);

            StringBuilder sb = new StringBuilder();

            for (int row = numberOfRows - 1; row >= 0; row--)
            {
                for (int column = 0; column < numberOfColumns; column++)
                {
                    sb.Append(Board[column, row].PlayerId >= 0 ? Board[column, row].PlayerId.ToString() : "_");
                    sb.Append(" ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public int IsFull(int column)
        {
            for (int row = 0; row < 6; row++)
            {
                if (Board[column, row].PlayerId == -1)
                {
                    MessageBox.Show("the current Row is " + row);
                    return row;
                }
            }
            MessageBox.Show("Invalid move, please choose an empty slot");
            return -1;
        }
        //creating a function to clear the gameboard 
        public void ClearBoard()
        {
            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    Board[column, row].PlayerId = -1;
                }
            }
        }
        // Creating a function to check wins
        public bool CheckWinner(int column, int row, int playerId)
        {
            int consecutiveCount;


            // Checking horizontally
            consecutiveCount = CountConsecutive(column, row, playerId, 1, 0) + CountConsecutive(column, row, playerId, -1, 0) - 1;

            if (consecutiveCount >= 4)
            {
                MessageBox.Show("The winner is player " + playerId.ToString());
                return true;
            }

            // Checking vertically
            consecutiveCount = CountConsecutive(column, row, playerId, 0, 1) + CountConsecutive(column, row, playerId, 0, -1) - 1;

            if (consecutiveCount >= 4)
            {
                MessageBox.Show("The winner is player " + playerId.ToString());
                return true;
            }

            // Check diagonal (top-left to bottom-right)
            consecutiveCount = CountConsecutive(column, row, playerId, 1, 1) + CountConsecutive(column, row, playerId, -1, -1) - 1;

            if (consecutiveCount >= 4)
            {
                MessageBox.Show("The winner is player " + playerId.ToString());
                return true;
            }

            // Check diagonal (top-right to bottom-left)
            consecutiveCount = CountConsecutive(column, row, playerId, 1, -1) + CountConsecutive(column, row, playerId, -1, 1) - 1;

            if (consecutiveCount >= 4)
            {
                MessageBox.Show("The winner is player " + playerId.ToString());
                return true;
            }

            // If no win condition is found, return false
            return false;
        }

        // Method to count consecutive discs in a specified direction
        private int CountConsecutive(int column, int row, int playerId, int columnDirection, int rowDirection)
        {
            int consecutiveCount = 0;

            int currentColumn = column;
            int currentRow = row;

            while (currentColumn >= 0 && currentColumn < 7 && currentRow >= 0 && currentRow < 6 &&
                   Board[currentColumn, currentRow].PlayerId == playerId)
            {
                consecutiveCount++;
                currentColumn += columnDirection;
                currentRow += rowDirection;
            }

            return consecutiveCount;
        }


        internal void DropDisc(int row, int column, int playerId)
        {
            if (Board[column, row].PlayerId < 0)
            {
                Board[column, row].PlayerId = playerId;

                // check for a winner
                /*
                if (CheckWinner(column, row, playerId))
                {
                    MessageBox.Show("Connect 4! The winner is player " + playerId.ToString());
                    win = playerId;
                    ClearBoard();
                }
                */
            }
        }



        





    }
}