using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SpaceInvaders
{
    internal class Bullet
    {
        public int width = 8;
        public int height = 16;
        public int ySpeed = 15;
        public int x, y;


        public Bullet(int _x, int _y, int _ySpeed)
        {
            x = _x;
            y = _y;
            ySpeed = _ySpeed;

        }
        public void Move(string direction, Size ss)
        {
            y -= ySpeed;

            if (y > ss.Height - height)
            {
                ySpeed *= -1;
            }
        }      
    }
}
