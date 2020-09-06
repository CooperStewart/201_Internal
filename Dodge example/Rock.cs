using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class rock 
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image titanImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public rock(int spacing)
        {

            x = spacing;
            y = 100;
            width = 100;
            height = 100;
            //planetImage contains the plane1.png image
            titanImage = Properties.Resources.rocki;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawRock(Graphics g)
        {

            g.DrawImage(titanImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MoveRock()
        {

            titanrec.Location = new Point(y, x -10);
        }
        public void SpriteChange()
        {

            titanImage = Properties.Resources.rocki2;
        }
        public void SpriteChange2()
        {

            titanImage = Properties.Resources.rocki;
        }
    }
}
