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
        public Image planetImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Titan(int spacing)
        {
            x = spacing;
            y = 300;
            width = 70;
            height = 90;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.planet1;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawPlanet(Graphics g)
        {
            g.DrawImage(planetImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MovePlanet()
        {

            titanrec.Location = new Point(y, x -10);
        }

    }
}
