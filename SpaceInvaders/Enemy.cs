using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SpaceInvaders
{
    internal class Enemy
    {
        public int width = 20;
        public int height = 20;
        public int xSpeed = -6;
        public int x, y;

        public Enemy(int _x, int _y, int _xSpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
        }
        public void Move(string direction, Size ss)
        {
            x += xSpeed;

            if (x > ss.Width - width || x < 0)
            {
                y = y + 10; 
                xSpeed *= -1; 
            }
        }
    }
}
