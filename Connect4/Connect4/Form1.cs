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
            int collomn = 6;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.dropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }
        }

        private void ButtonColumn6_Click(object sender, EventArgs e)
        {
            int collomn = 5;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.dropDisc(row, collomn, 1);
                AddCoin(row, collomn,1 );
                botTurn();

            }
        }

        private void ButtonColumn3_Click(object sender, EventArgs e)
        {

            int collomn = 2;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.dropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }
        }

        private void ButtonCollumn2_Click(object sender, EventArgs e)
        {
            int collomn = 1;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.dropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }
        }

        private void ButtonCollumn1_Click(object sender, EventArgs e)
        {


            
            int collomn = 0;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 
                

                gameBoard.dropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }

           

        }




        private void botTurn()
        {
           
            int collumn = 0;
            int row = 0;
            int id = 2;

            collumn = botPlayer.MakeMove();
            row = gameBoard.IsFull(collumn);




            if (row >= 0)
            {


              
                gameBoard.dropDisc(row, collumn, 2);
                MessageBox.Show(gameBoard.GetBoardAsString());
                AddCoin(row, collumn, 2);



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


        private void ButtonCollomn5_Click(object sender, EventArgs e)
        {
            int collomn = 4;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.dropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }

        }

        private void ButtonColumn6_Click_1(object sender, EventArgs e)
        {
            int collomn = 5;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.dropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
