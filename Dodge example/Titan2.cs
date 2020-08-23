using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class Titan2
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Titan2(int spacing)
        {
            x = spacing;
            y = 180;
            width = 120;
            height = 150;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.titan21;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawTitan2(Graphics g)
        {

            g.DrawImage(planetImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MoveTitan2()
        {

            titanrec.Location = new Point(y, x -10);
        }
        public void ChangeSprite()
        {
            planetImage = Properties.Resources.titan22;

        }
        public void ChangeSprite2()
        {
            planetImage = Properties.Resources.titan23;

        }

        public void ChangeSprite3()
        {
            planetImage = Properties.Resources.titan24;

        }

        public void ChangeSprite4()
        {
            planetImage = Properties.Resources.titan21;

        }
    }
}
