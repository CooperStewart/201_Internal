using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 10;
            y = 150;
            width = 80;
            height = 80;
            spaceship = Properties.Resources.alien1;
            spaceRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void DrawSpaceship(Graphics g)
        {

            g.DrawImage(spaceship, spaceRec);
        }

       
        public void MoveSpaceship(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    x = 450;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 10;
                    spaceRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (spaceRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 10;
                    spaceRec.Location = new Point(x, y);
                }

            }
            if (move == "up")
            {
                if (spaceRec.Location.Y < 12)
                {
                    y = 20;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 30;
                    spaceRec.Location = new Point(x, y);
                }
            }
            if (move == "down")
            {
                if (spaceRec.Location.Y > 390)
                {
                    y = 389;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y += 31;
                    spaceRec.Location = new Point(x, y);
                }

            }
        }

    }
}