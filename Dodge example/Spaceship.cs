using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Drawing.Drawing2D;

namespace Dodge_example
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image
        
        public Rectangle spaceRec;//variable for a rectangle to place our image in
        public  int rotationAngle;
        public Matrix matrix;
        Point centre;

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {

            x = 10;
            y = 301;
            width = 160;
            height = 210;
            rotationAngle = 0;

            spaceship = Properties.Resources.player;
            spaceRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void DrawSpaceship(Graphics g)
        {
            // find the centre point of spaceRec
             centre = new Point(spaceRec.X + width / 2, spaceRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(spaceship, spaceRec);
        }
        public void Flip()
        {
            spaceRec.Width = 150;
            spaceRec.Height = 25;
        }

        public void SpriteChange()
        {
            spaceship = Properties.Resources.player2;

        }

        public void SpriteChange2()
        {
            spaceship = Properties.Resources.player;

        }
        public void SpriteChange3()
        {
            spaceship = Properties.Resources.player3;

        }

        public void SpriteChange4()
        {
            spaceship = Properties.Resources.player4;

        }

        public void SpriteChange5()
        {
            spaceship = Properties.Resources.player5;

        }

        public void SpriteChange6()
        {
            spaceship = Properties.Resources.player6;

        }

        public void SpriteChange7()
        {
            spaceship = Properties.Resources.player7;

        }

        public void SpriteChange8()
        {
            spaceship = Properties.Resources.player8;

        }
        public void Flip2()
        {
            spaceRec.Width = 160;
            spaceRec.Height = 210;
        }


        public void MoveSpaceship(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 999) // is spaceship within 50 of right side
                {

                    x = 998;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    if (move == "up")
                    {
                        x += 2;
                        spaceRec.Location = new Point(x, y);
                    }
                    else
                    {
                        x += 30;
                        spaceRec.Location = new Point(x, y);
                    }
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

                    if (move == "up")
                    {
                        x += 2;
                        spaceRec.Location = new Point(x, y);
                    }
                    else
                    {
                        x -= 30;
                        spaceRec.Location = new Point(x, y);
                    }
                }

            }
            if (move == "up")
            {
                if (spaceRec.Location.Y < -10)
                {
                    y = -9;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    
                    y -= ((spaceRec.Location.Y / 10)*3)+10;
                    spaceRec.Location = new Point(x, y);
                }
                if (spaceRec.Location.Y < 50)
                {
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
                    y +=45+((spaceRec.Location.Y/100)*7);
                    spaceRec.Location = new Point(x, y);
                }

            }

            
        }

    }
}