using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Connect4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            string DefualtName = null;
            // Show the intro form with the default name
            Intro introForm = new Intro(DefualtName); ;
            introForm.ShowDialog();



            // Get the name and the theme from the form
            string name = introForm.TextBoxName.Text;

            string theme = introForm.ComboBoxTheme.SelectedItem.ToString(); 

            // Start form1 and pass the name and the theme
            Application.Run(new Form1(name, theme));


        }
    }
}
