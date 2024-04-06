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




        }




        public string GetBoardAsString()
        {
            int numberOfRows = Board.GetLength(1); // Swap the dimensions for rows and columns
            int numberOfColumns = Board.GetLength(0);

            StringBuilder sb = new StringBuilder();

            for (int row = numberOfRows -1; row >= 0; row--)
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

                if (Board[column, row].PlayerId ==-1)
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
            if (Board[column, row].PlayerId < 0)
            {
                Board[column, row].PlayerId = playerId;
                MessageBox.Show("row =" + row.ToString() + "coloumn" + column.ToString() + "id" + playerId.ToString());


                CheckWinner(column, row , playerId);
            }
        }


        private void CheckWinner(int column, int row, int playerId)
        {


            // check for top right
            

            int currentPlayerID = playerId;

            // check for top right

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

