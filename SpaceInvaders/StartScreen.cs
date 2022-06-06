using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new InstructionScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
