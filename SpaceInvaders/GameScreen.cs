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
        Bullet bullet = null;

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

            for (int i = 1; i <= 11; i++)
            {
                int x = i * 50;
                

                Enemy e = new Enemy(x, 225, -3);               
                enemyList.Add(e);
            }          
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
            foreach (Enemy en in enemyList)
            {
                en.Move("left", screenSize);
            }

            //foreach (Bullet b in bulletList)
            //{
            //    b.Move("up", screenSize);
            //}

            if(bullet != null)
            {
                bullet.Move("up", screenSize);
            }
            if (bullet != null)
            {
                if (bullet.y < 0)
                {
                    bullet = null;
                }
            }

            PlayerMovement();
            NewBullet();
            BulletsEnemyCollision();

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
            if (spaceBarDown == true && bullet ==null)
            {        
                bullet = new Bullet(hero.x, hero.y, 15);               
            }

       
        }

        public void BulletsEnemyCollision()
        {
            foreach (Enemy e in enemyList)
            {
                if (bullet != null)
                {
                    if (e.Collision(bullet))
                    {
                        bullet = null;
                        enemyList.Remove(e);
                        return;
                    }
                }
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
             e.Graphics.FillRectangle(Brushes.DodgerBlue, hero.x, hero.y, hero.width, hero.height);

            foreach (Enemy en in enemyList)
            {
                e.Graphics.FillRectangle(Brushes.Red, en.x, en.y, en.width, en.height);
            }

            if (bullet != null)
            {
                e.Graphics.FillRectangle(Brushes.Green, bullet.x, bullet.y, bullet.width, bullet.height);
            }
            //foreach (Bullet b in bulletList)
            //{
            //    e.Graphics.FillRectangle(Brushes.Green, b.x, b.y, b.width, b.height);
            //}
        }
    }
}
