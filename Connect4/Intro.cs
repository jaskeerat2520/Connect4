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
    public partial class Intro : Form
    {
        public Intro(string name)
        {
            InitializeComponent();
            TextBoxName = new TextBox();

            TextBoxName.Location = new Point(105, 80); // Set the location of the TextBox
            TextBoxName.Size = new Size(200, 20); // Set the size of the TextBox

            // Add TextBox control to the form's controls collection
            Controls.Add(TextBoxName);

            ComboBoxTheme = new ComboBox();
            ComboBoxTheme.Location = new Point(105, 150);
            ComboBoxTheme.Size = new Size(200, 20);

            ComboBoxTheme.Items.Add("Christmass");
            ComboBoxTheme.Items.Add("Neon");
            ComboBoxTheme.Items.Add("Dark Mode");
            ComboBoxTheme.Items.Add("Default");
            ComboBoxTheme.Items.Add("Sky");
            ComboBoxTheme.Items.Add("Haloween");


            if (name != null)
            {
                TextBoxName.Text = name;
                TextBoxName.Enabled = false;
            }


            ComboBoxTheme.SelectedIndexChanged += ComboBoxTheme_SelectedIndexChanged;


            Controls.Add(ComboBoxTheme);

        }




        public TextBox TextBoxName { get; set; }

        public ComboBox ComboBoxTheme { get; set; }





        private void ComboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

            var theme = ComboBoxTheme.SelectedItem.ToString();

            // Check the selected theme and update the background color accordingly
            if (theme == "Christmass")

            {
                ComboBoxTheme.BackColor = Color.Green;
                BackColor = Color.Red;
                TextBoxName.BackColor = Color.Green;
                ButtonContinue.BackColor = Color.Green;
            }
            if (theme == "Neon")
            {
                BackColor = Color.GreenYellow;
                ComboBoxTheme.BackColor = Color.Yellow;
                ButtonContinue.BackColor = Color.Yellow;
                TextBoxName.BackColor = Color.Green;
                TextBoxName.ForeColor = Color.Yellow;
            }
            if (theme == "Dark Mode")
            {
                BackColor = Color.Black; 
            }
            if (theme == "Default")
            {
                BackColor = Color.LightYellow; 
            }

            if (theme == "Sky")
            {
                BackColor = Color.LightBlue; 
            }

            if (theme == "Haloween")
            {


               
                BackColor = Color.Orange; 
            }
        }

        /// <summary>
        /// Button allows users to go to the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonContinue_Click(object sender, EventArgs e)
        {


            if (TextBoxName.Text == null)
            {

                MessageBox.Show("please enter a valid name that is longer than 3 digits");


            }
            else if(ComboBoxTheme.Text== null){
                MessageBox.Show("please select a theme");

            }
            else
            {


                Hide();
            }
        }



    }
}
