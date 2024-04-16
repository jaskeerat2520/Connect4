using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {

        private User currentUser;
        private Bot botPlayer;
        private GameBoard board;
        private Connect4Game game;
        GameBoard gameBoard = new GameBoard();

       

        public Form1(string name, string theme)
        {
            InitializeComponent();


            MessageBox.Show(theme.ToString());
            currentUser = new User(1, name, "silver");
            botPlayer = new Bot();



            TextBoxTurn.Text = currentUser.Name;

            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            button.BackColor = Color.AntiqueWhite; button.FlatStyle = FlatStyle.System;
            button.Text = "settings";
            button.BringToFront();
            this.Controls.Add(button);


            ChangeTheme(theme);

          





           




        }

        public Form1()
        {
        }

        public int movesPlayed = 0;






        public void ChangeTheme(string theme)
        {

            if (theme == "Christmass")

            {
                BackColor = Color.FromArgb(204, 0, 0);


                foreach (Control control in this.Controls)
                {
                    if (control is System.Windows.Forms.Button)
                    {
                        Button button = (System.Windows.Forms.Button)control;
                        button.BackColor = Color.FromArgb(0, 128, 0);
                    }
                }
            }
            if (theme == "Neon")
            {
                BackColor = Color.GreenYellow;
            }
            if (theme == "Dark Mode")
            {
                BackColor = Color.Black; // Set the background color of the form to red for the Christmas theme
            }
            if (theme == "Default")
            {
                BackColor = Color.LightYellow; // Set the background color of the form to red for the Christmas theme
            }

            if (theme == "Sky")
            {
                BackColor = Color.LightBlue; // Set the background color of the form to red for the Christmas theme
            }

            if (theme == "Haloween")
            {



                BackColor = Color.Orange; // Set the background color of the form to red for the Christmas theme
            }
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


                gameBoard.DropDisc(row, collomn, 1);
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


                gameBoard.DropDisc(row, collomn, 1);
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


                gameBoard.DropDisc(row, collomn, 1);
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


                gameBoard.DropDisc(row, collomn, 1);
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
                

                gameBoard.DropDisc(row, collomn, 1);
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


              
                gameBoard.DropDisc(row, collumn, 2);
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


            if (gameBoard.CheckWinner(column, row, id))
            {
                // add the file to json
                AddToJSON(id);
                // clear the form board
                ClearBoard();

                // clear the gameboard array
                gameBoard.ClearBoard();
            

            }
            else
            {

                // add a turn to the total amount of moves played
                movesPlayed = +1;
                TextBoxTurnsPlayed.Text = movesPlayed.ToString();

                // concatenate the picture name
                String together = (column.ToString() + row.ToString());
                String pictureBoxName = "PictureBox" + together.ToString();

                Image imageName;


                // dependeing on the id change image to its correct coin
                if (id == 1)
                {
                    imageName = Properties.Resources.coin;
                    ChangeToAi()
    ;
                }
                else
                {
                    imageName = Properties.Resources.pngegg;
                    ChangetoUser();
                }



                // go through all of the images to find the correct picture box and add the image  and other details
                Control[] controls = this.Controls.Find(pictureBoxName, true);
                if (controls.Length > 0 && controls[0] is PictureBox pictureBoxToChange)
                {

                    pictureBoxToChange.Image = imageName;
                    pictureBoxToChange.BringToFront();
                    pictureBoxToChange.BackColor = Color.FromArgb(41, 0, 255);
                }




            }



        }

        /// <summary>
        /// Brings the board to the front which clears the board
        /// </summary>
        private void ClearBoard()
        {

            pictureBox1.BringToFront();
        }

        private void ButtonColumn6_Click_1(object sender, EventArgs e)
        {
            int collomn = 5;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

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


                gameBoard.DropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {

            int collomn = 3;
            int row = 0;

            row = gameBoard.IsFull(collomn);

            if (row >= 0)
            {
                // make function to drop disk in location 


                gameBoard.DropDisc(row, collomn, 1);
                AddCoin(row, collomn, 1);
                botTurn();

            }

        }

        /// <summary>
        /// Opens the intro Dialog Where users can change the Theme of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSettings_Click(object sender, EventArgs e)
        {

            // Create a intro and pass the current users name
            Intro intro = new Intro(currentUser.Name);


            intro.ShowDialog();
            ChangeTheme(intro.ComboBoxTheme.Text);


            
        }

        /// <summary>
        /// Button Resets the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRestart_Click(object sender, EventArgs e)
        {

            // Clears the gameBoard Array
            gameBoard.ClearBoard();

            // Clears the Board
            ClearBoard();

        }
        /// <summary>
        /// Closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Logs the game into a json file
        /// </summary>
        /// <param name="id"></param>
       private void AddToJSON(int id)
        {
            ClearBoard();
            string  GameWinner="";


            // Finds the winner
            if (botPlayer.Id  == id)
            {
                 GameWinner = botPlayer.Name;
            }
            else
            {
                GameWinner = currentUser.Name;
            }
            
            var data = new
            {
                UserName = currentUser.Name,
                MovesPlayed = movesPlayed,
                GameHistory = gameBoard,
                Winner = GameWinner

            };

            string jsonString = JsonConvert.SerializeObject(data);
            MessageBox.Show(jsonString);

            string filePath = Path.Combine("winners.json");

            File.WriteAllText(filePath, jsonString);

        }
    }
}
