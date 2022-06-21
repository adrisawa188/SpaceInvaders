using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SpaceInvaders
{
    public partial class GameOverScreen : UserControl
    {
        //string[] highsocre;
        public GameOverScreen()
        {
            InitializeComponent();
            { 
            //if (GameScreen.score > Convert.ToInt32(highsocre[0]))
            //{
            //    highsocre[0] = Convert.ToString(GameScreen.score);
            //    highsocre = File.ReadAllLines("Highscore.txt");
            }
            finalScoreLabel.Text = $"Your Score Was: {GameScreen.score}";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new StartScreen());

        }

        //public void SaveHS()
        //{
        //    File.WriteAllLines("Highscore.txt", highsocre);
        //}
    }
}
