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
        private GameBoard board;
        GameBoard gameBoard = new GameBoard(7, 6);

        public Form1()
        {
            InitializeComponent();

            currentUser = new User(1, "thomas", "green");



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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCollumn1_Click(object sender, EventArgs e)
        {
           
            if (gameBoard.IsFull(0) > -1)
            {
                // make function to drop disk in location 
                
                gameBoard.dropDisc(gameBoard.IsFull(0), 0, 1);

                MessageBox.Show(gameBoard.IsFull(0).ToString(), "0");

                AddCoin(gameBoard.IsFull(0), 0);
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void TableLayoutPanelBoard_Paint(object sender, PaintEventArgs e)
        {

        }



        private void AddCoin(int row, int column)
        {

            if (column == 0 && row ==1)
            {
                TextBox00.Text = "x";

                MessageBox.Show("heelo");
            
            }
     
        }

    }
}
