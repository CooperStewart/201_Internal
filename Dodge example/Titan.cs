using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class Titan 
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image titanImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Titan(int spacing)
        {

            x = 1500;
            y = spacing;
            width = 100;
            height = 220;
            //planetImage contains the plane1.png image
            titanImage = Properties.Resources.titan2;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawPlanet(Graphics g)
        {

            g.DrawImage(titanImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MovePlanet()
        {

            titanrec.Location = new Point(x,y);
        }
        public void ChangeSprite()
        {
            titanImage = Properties.Resources.titan;

        }
        public void ChangeSprite2()
        {
            titanImage = Properties.Resources.titan2
                ;

        }

    }
}
