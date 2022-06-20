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

        public static int score;
        int lives = 3;

        int enemySpeed = 3;

        List<Enemy> enemyList = new List<Enemy>();
        List<Bullet> bulletList = new List<Bullet>();

        bool rightArrowDown = false;
        bool leftArrowDown = false;
        bool spaceBarDown = false;

        public GameScreen()
        {
            InitializeComponent();
            hero = new Player(300, 400);
            GameStart();
        }
       

        public void GameStart ()
        {
            for (int i = 1; i <= 11; i++)
            {
                int x = i * 50;

                Enemy e = new Enemy(x, 225, enemySpeed);
                enemyList.Add(e);
            }
            screenSize = new Size(this.Width, this.Height);

            livesLabel.Text = $"Lives: {lives}";
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
            EnemyReachesPlayer();

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
                        score = score + 15;
                        scoreLabel.Text = $" Score: {score}";

                        if (enemyList.Count == 0)
                        {
                            enemySpeed++;                          
                            GameStart();
                        }

                        return;
                    }
                }
            }
        }

        public void EnemyReachesPlayer()
        {
            foreach (Enemy e in enemyList)
            {
                if (e.Collision(hero))
                {
                    lives--;
                    score = score - 10;
                    scoreLabel.Text = $" Score: {score}";
                    livesLabel.Text = $"Lives: {lives}";
                    enemyList.Remove(e);    
                    
                    if (lives == 0)
                    {
                        Form1.ChangeScreen(this, new GameOverScreen());
                    }

                    return;
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
