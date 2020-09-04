using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class Background3
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image Backgroundimage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Background3(int spacing)
        {

            x = 2000;
            y = 380;
            width = 1000;
            height = 450;
            //planetImage contains the plane1.png image
            Backgroundimage = Properties.Resources.background4;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawBackground(Graphics g)
        {

            g.DrawImage(Backgroundimage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MoveBackground()
        {

        }
        public void ChangeSprite()
        {
            Backgroundimage = Properties.Resources.titan;

        }
        public void ChangeSprite2()
        {
            Backgroundimage = Properties.Resources.titan2
                ;

        }

    }
}
