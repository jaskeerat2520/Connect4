using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {

        private User currentUser;
        private bot botPlayer;
        private GameBoard board;
        private Connect4Game game;
        GameBoard gameBoard = new GameBoard();

         

        public Form1()
        {
            InitializeComponent();

            currentUser = new User(1, "thomas", "green");

            botPlayer = new bot();
       

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
                AddCoin(row, collomn);

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
                AddCoin(row, collomn);
             
            }

           

        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void TableLayoutPanelBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Handle PictureBox click event
            PictureBox pictureBox = (PictureBox)sender;
            int col = (int)pictureBox.Tag;
          
        }



        private void botTurn()
        {
           
            int collumn = 0;
            int row = 0;

            collumn = botPlayer.FindMove();
            row = gameBoard.IsFull(collumn);




            if (row >= 0)
            {


              
                gameBoard.dropDisc(row, collumn, 2);
                MessageBox.Show(gameBoard.GetBoardAsString());



            }

        }

        private void AddCoin(int row, int column)
        {
            _ = MessageBox.Show(row.ToString(), column.ToString());
           
            if (column == 0 && row ==1)
            {
                TextBox00.Text = "x";
              
                MessageBox.Show("heelo");

              


            }
            MessageBox.Show(gameBoard.GetBoardAsString());
            botTurn();



        }

    }
}
