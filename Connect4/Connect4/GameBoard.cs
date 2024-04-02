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

        public Cells[,] Board { get; set; }

        public GameBoard(int width, int height)
        {
            Board = new Cells[width, height];

    
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Board[i, j] = new Cells(); 
                }
            }
        }



        public int IsFull(int column)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                if (Board[i, column].PlayerId < 1)
                {

                    
                    // Found an empty cell, return its row index
                    return i -1;
                }
            }

            // Column is full
            return -1;
        }


        internal void dropDisc(int row, int column, int playerId)
        {
            if (Board[row, column] != null)
            {
                Board[row, column].PlayerId = playerId;
            }
        }
    }
       
}

