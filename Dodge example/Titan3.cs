using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class Titan3
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Titan3(int spacing)
        {
            x = spacing;
            y = 1201;
            width = 200;
            height = 110;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.titan31;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawTitan3(Graphics g)
        {

            g.DrawImage(planetImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MoveTitan3()
        {

            titanrec.Location = new Point(y, x -10);
        }
        public void ChangeSprite()
        {
            planetImage = Properties.Resources.titan31;

        }
        public void ChangeSprite2()
        {
            planetImage = Properties.Resources.titan32;

        }

        public void ChangeSprite3()
        {
            planetImage = Properties.Resources.titan33;

        }

        public void ChangeSprite4()
        {
            planetImage = Properties.Resources.titan21;

        }
    }
}
