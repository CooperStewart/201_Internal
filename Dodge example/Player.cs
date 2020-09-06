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
    class Player
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image Playerimg;//variable for the planet's image
        
        public Rectangle spaceRec;//variable for a rectangle to place our image in
        public  int rotationAngle;
        public Matrix matrix;
        Point centre;

        //Create a constructor (initialises the values of the fields)
        public Player()
        {

            x = 10;
            y = 260;
            width = 160;
            height = 210;
            rotationAngle = 0;

            Playerimg = Properties.Resources.player;
            spaceRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void Drawplayer(Graphics g)
        {
            // find the centre point of spaceRec
             centre = new Point(spaceRec.X + width / 2, spaceRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the player

            g.DrawImage(Playerimg, spaceRec);
        }
        public void Flip()
        {
            spaceRec.Width = 150;
            spaceRec.Height = 25;
        }

        public void SpriteChange()
        {
            Playerimg = Properties.Resources.playeri1;

        }

        public void InjuredSpriteChange()
        {
            Playerimg = Properties.Resources.injured1;

        }

        public void InjuredSpriteChange21()
        {
            Playerimg = Properties.Resources.injured21;

        }

        public void InjuredSpriteChange31()
        {
            Playerimg = Properties.Resources.injured31;

        }
        public void SpriteChange2()
        {
            Playerimg = Properties.Resources.playeri2;

        }

        public void injuredSpriteChange2()
        {
            Playerimg = Properties.Resources.injured2;

        }

        public void injuredSpriteChange22()
        {
            Playerimg = Properties.Resources.injured22;

        }

        public void injuredSpriteChange32()
        {
            Playerimg = Properties.Resources.injured32;

        }
        public void SpriteChange3()
        {
            Playerimg = Properties.Resources.playeri3;

        }

        public void InjuredSpriteChange3()
        {
            Playerimg = Properties.Resources.injured3;

        }


        public void InjuredSpriteChange23()
        {
            Playerimg = Properties.Resources.injured23;

        }
        public void InjuredSpriteChange33()
        {
            Playerimg = Properties.Resources.injured33;

        }
        public void SpriteChange4()
        {
            Playerimg = Properties.Resources.player4;

        }

        public void SpriteChange5()
        {
            Playerimg = Properties.Resources.player5;

        }

        public void SpriteChange6()
        {
            Playerimg = Properties.Resources.player6;

        }

        public void InjuredSpriteChange6()
        {
            Playerimg = Properties.Resources.injured6;

        }

        public void InjuredSpriteChange26()
        {
            Playerimg = Properties.Resources.injured26;

        }

        public void InjuredSpriteChange36()
        {
            Playerimg = Properties.Resources.injured36;

        }
        public void SpriteChange7()
        {
            Playerimg = Properties.Resources.player7;

        }

        public void InjuredSpriteChange7()
        {
            Playerimg = Properties.Resources.injured7;

        }
        public void InjuredSpriteChange27()
        {
            Playerimg = Properties.Resources.injured27;

        }

        public void InjuredSpriteChange37()
        {
            Playerimg = Properties.Resources.injured27;

        }
        public void SpriteChange8()
        {
            Playerimg = Properties.Resources.player8;

        }

        public void InjuredSpriteChange8()
        {
            Playerimg = Properties.Resources.injured8;

        }
        public void InjuredSpriteChange28()
        {
            Playerimg = Properties.Resources.injured28;

        }

        public void InjuredSpriteChange38()
        {
            Playerimg = Properties.Resources.injured38;

        }

        public void InjuredSpriteChange9()
        {
            Playerimg = Properties.Resources.titanstill;

        }
        public void Flip2()
        {
            spaceRec.Width = 160;
            spaceRec.Height = 210;
        }


        public void Moveplayer(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 999) // is player within 50 of right side
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
                if (spaceRec.Location.X < 10) // is player within 10 of left side
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
                if (spaceRec.Location.Y > 260)
                {
                    y = 259;
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