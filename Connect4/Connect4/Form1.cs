using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Connect4
{
    public partial class Form1 : Form
    {

        private User currentUser;
        private Bot botPlayer;
        private GameBoard board;
        private Connect4Game game;
        GameBoard gameBoard = new GameBoard();

         

        public Form1()
        {
            InitializeComponent();

            currentUser = new User(1, "thomas", "green");
            botPlayer = new Bot();


         


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void ButtonColumn7_Click(object sender, EventArgs e)
        {
            int column = 6;
            int row = 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column, 1);
                botTurn();

            }
        }

        private void ButtonColumn6_Click(object sender, EventArgs e)
        {
            int column = 5;
            int row = 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column,1 );
                botTurn();

            }
        }

        private void ButtonColumn3_Click(object sender, EventArgs e)
        {

            int column = 2;
            int row = 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column, 1);
                botTurn();

            }
        }

        private void ButtonCollumn2_Click(object sender, EventArgs e)
        {
            int column = 1;
            int row = 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column, 1);
                botTurn();

            }
        }

        private void ButtonCollumn1_Click(object sender, EventArgs e)
        {


            
            int column = 0;
            int row= 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {   
                // make function to drop disk in location 
                

                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column, 1);
                botTurn();

            }

           

        }




        private void botTurn()
        {
           
            int column = 0;
            int row = 0;
            int id = 2;

            column = botPlayer.MakeMove();
            row = gameBoard.IsFull(column);




            if (row >= 0)
            {


              
                gameBoard.DropDisc(row, column, 2);
                MessageBox.Show(gameBoard.GetBoardAsString());
                AddCoin(row, column, 2);



            }

        }



         private void ChangetoUser()
        {

            TextBoxTurn.Text = currentUser.Name;
        }

        private void ChangeToAi()
        {
            TextBoxTurn.Text = botPlayer.Name;
        }


        private void AddCoin(int row, int column, int id)
        {

            if (gameBoard.CheckWinner(column, row, id))
            {
                ClearBoard(); 
            }
            String together = (column.ToString() + row.ToString());
            String pictureBoxName = "PictureBox" + together.ToString();

            MessageBox.Show(column.ToString());


            MessageBox.Show(pictureBoxName);
            Image imageName;



            if (id == 1)
            {
                 imageName = Properties.Resources.coin;
                //ChangeToAi()
;            }
            else
            {
                 imageName = Properties.Resources.pngegg;
                //ChangetoUser();
            }

            Control[] controls = this.Controls.Find(pictureBoxName, true); // Assuming the PictureBox is contained within a form or a container

            if (controls.Length > 0 && controls[0] is PictureBox pictureBoxToChange)
            {
                // Assuming you have images stored with names like "image1.jpg", "image2.jpg", etc.
              
                pictureBoxToChange.Image = imageName;
                pictureBoxToChange.BringToFront();
                pictureBoxToChange.BackColor = Color.FromArgb(41, 0, 255);
            }
            







        }


        private void ButtonColumn5_Click(object sender, EventArgs e)
        {
            int column = 4;
            int row = 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column, 1);
                botTurn();

            }

        }

        private void ButtonColumn6_Click_1(object sender, EventArgs e)
        {
            int column = 5;
            int row = 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column, 1);
                botTurn();

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int column = 3;
            int row = 0;

            row = gameBoard.IsFull(column);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, column, 1);
                AddCoin(row, column, 1);
                botTurn();

            }
        }

        //making a function to clear the gameboard
        private void ClearBoard()
        {
            // Reset the PictureBoxes
            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    string pictureBoxName = "PictureBox" + column.ToString() + row.ToString();


                    Control[] controls = this.Controls.Find(pictureBoxName, true); // Assuming the PictureBox is contained within a form or a container

                    if (controls.Length > 0 && controls[0] is PictureBox pictureBoxToChange)
                    {
                        // Assuming you have images stored with names like "image1.jpg", "image2.jpg", etc.

                        pictureBoxToChange.SendToBack();
                        pictureBoxToChange.BackColor = Color.Transparent;
                    }


                }
            }

            // Reset the game board array
            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    // Reset the PlayerId of each cell to -1
                    gameBoard.Board[column, row].PlayerId = -1;
                }
            }
        }
    }
}
