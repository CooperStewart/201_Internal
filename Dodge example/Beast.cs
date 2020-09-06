using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class Beast 
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image titanImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Beast(int spacing)
        {

            x = 0;
            y = spacing;
            width = 150;
            height = 280;
            //planetImage contains the plane1.png image
            titanImage = Properties.Resources.beasti1;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawBeast(Graphics g)
        {

            g.DrawImage(titanImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MoveBeast()
        {

            titanrec.Location = new Point(x,y);
        }
        public void ChangeSprite()
        {
            titanImage = Properties.Resources.beasti2;


        }
        public void ChangeSprite2()
        {
            titanImage = Properties.Resources.beasti1;


            

        }
        public void ChangeSprite3()
        {
            titanImage = Properties.Resources.beasti3;




        }

    }
}
