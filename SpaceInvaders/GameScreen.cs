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
    public partial class GameScreen : UserControl
    {
        Player hero;
        Enemy enemy;
        Bullet bullet;

        Random randGen = new Random();
        Size screenSize;

        List<Enemy> enemyList = new List<Enemy>();
        List<Bullet> bulletList = new List<Bullet>();

        bool rightArrowDown = false;
        bool leftArrowDown = false;
        bool spaceBarDown = false;

        public GameScreen()
        {
            InitializeComponent();
            hero = new Player(300, 400);
            enemy = new Enemy(300, 225, -3);
            screenSize = new Size(this.Width, this.Height);

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    spaceBarDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceBarDown = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {             
            enemy.Move("left",screenSize); 
            foreach (Bullet b in bulletList)
            {
                bullet.Move("up", screenSize);
            }

            PlayerMovement();
            NewBullet();


            Refresh();
        }

        public void PlayerMovement()
        {

            if (leftArrowDown == true)
            {
                hero.Move("left", screenSize);
            }

            if (rightArrowDown == true)
            {
                hero.Move("right", screenSize);
            }
        }

        public void NewBullet()
        {
            if (spaceBarDown == true)
            {
                Bullet b = new Bullet(hero.x, hero.y, 15);
                bulletList.Add(b);
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DodgerBlue, hero.x, hero.y, hero.width, hero.height);
            e.Graphics.FillRectangle(Brushes.Red, enemy.x, enemy.y, enemy.width, enemy.height);

            foreach (Bullet b in bulletList)
            {
                e.Graphics.FillRectangle(Brushes.Green, bullet.x, bullet.y, bullet.width, bullet.height);
            }
        }
    }
}
