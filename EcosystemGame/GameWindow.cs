using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcosystemGame
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            GameMenu gameM = new GameMenu();

            // Hides the GameMenu form.
            this.Hide();
            // Shows the GameWindow form.
            gameM.Show();
        }

        // Knap til at teste forskellige ting. 
        private void devButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            // Til gruppe: Denne funktion er vores next turn metode.
            // Til debug:
            Console.WriteLine("Next turn pressed");
        }

        private void addFaunaButton_Click(object sender, EventArgs e)
        {
            // Creates a new instance of the FaunaSelector form.
            GameWindowFaunaSelector faunaSelector = new GameWindowFaunaSelector();
            // Shows the form as a dialog, this ensures that the button can't be pressed again, before the new form has been closed.
            faunaSelector.ShowDialog();
        }
    }
}
