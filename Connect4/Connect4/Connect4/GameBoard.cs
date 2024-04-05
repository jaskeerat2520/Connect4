using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    internal class GameBoard
    {

        String turn = "user";

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

            int numberOfRows = Board.GetLength(0);
            int numberOfColumns = Board.GetLength(1);

            MessageBox.Show(numberOfRows.ToString());




        }




        public string GetBoardAsString()
        {
            StringBuilder sb = new StringBuilder();

            for (int column = 6; column >= 0; column--)
            {
                for (int row = 0; row < 6; row++)
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

                if (Board[row, column].PlayerId < 0)
                {
                    


                    MessageBox.Show("the current Row is " + row);

                    // Found an empty cell, return its row index
                    return row ;

                   

                }
            }

            // Column is full
            return -1;
        }


        internal void dropDisc(int row, int column, int playerId)
        {
            if (Board[row, column].PlayerId < 0)
            {
                Board[row, column].PlayerId = playerId;
                MessageBox.Show("row =" + row.ToString() + "coloumn" + column.ToString() + "id" + playerId.ToString());


                CheckWinner(row, column , playerId);
            }
        }


        private void CheckWinner(int row, int column, int playerId)
        {


            // check for top right
            int numberOfRows = Board.GetLength(0);
            int numberOfColumns = Board.GetLength(1);

            int currentPlayerID = playerId;

            // check for top right
            if (column + 1 < numberOfColumns && row + 1 < numberOfRows)
            {
                if (currentPlayerID == Board[column + 1, row + 1].PlayerId)
                {
                    MessageBox.Show("topright");
                }
            }

            // check for top left 

            // check for above 

            // check for right


            // check for left 


            // check for bottom left

         

            // Check if the indices are within the valid range
        


        // check for botton write 


        // check for below


    }
    }
       
}

