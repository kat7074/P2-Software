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

        private void devButton_Click(object sender, EventArgs e)
        {
            FloraFaunaHandler ffTest = new FloraFaunaHandler();
            ffTest.AddFauna("Trout");
            
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            // Til gruppe: Denne funktion er vores next turn metode.
            // Til debug:
            Console.WriteLine("Next turn pressed");
        }
    }
}
