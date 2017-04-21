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
    public partial class GameWindowFaunaSelector: Form
    {
        public GameWindowFaunaSelector()
        {
            InitializeComponent();
        }

        private void faunaSelectorExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
