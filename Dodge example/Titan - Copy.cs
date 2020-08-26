using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class flare
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image titanImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public flare()
        {

            x = 600;
            y = -100    ;
            width = 500;
            height = 500;
            //planetImage contains the plane1.png image
            titanImage = Properties.Resources.flare;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawFlare(Graphics g)
        {

            g.DrawImage(titanImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
    }
}