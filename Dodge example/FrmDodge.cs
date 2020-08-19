using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodge_example
{
    public partial class FrmDodge : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Titan[] titan = new Titan[7];
        Titan2[] titan2 = new Titan2[7];

        Random yspeed = new Random();
        Random xloc = new Random();
        Spaceship spaceship = new Spaceship();
        bool left, right, up, down;
        string move;
        protected virtual bool DoubleBuffered { get; set; }

        int score, lives, stop;
        public FrmDodge()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 200 + (i * 75);

                titan[i] = new Titan(x);
                titan2[i] = new Titan2(x);



            }


        }

        private void FrmDodge_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            txtName.Focus();

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {

            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 1; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 10);
                titan2[i].y += 15;

                if (stop < 10)
                {
                    titan[i].y += rndmspeed;


                }
                else {
                    titan[i].ChangeSprite();

                }

                if (stop == 20)
                {
                    stop = 0;
                    titan[i].ChangeSprite2();
                    titan2[i].ChangeSprite2();



                }
                //call the Planet class's drawPlanet method to draw the images
                titan[i].DrawPlanet(g);
                titan2[i].DrawTitan2(g);


            }

            spaceship.DrawSpaceship(g);
        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            stop += 1;

          
            for (int i = 0; i < 1; i++)
            {
                titan[i].MovePlanet();
                titan2[i].MoveTitan2();


                int rndmloc = xloc.Next(-100, 0);
                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (titan[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    lblScore.Text = score.ToString();// display score

                    titan[i].y = -100;
                }
                if (titan2[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    lblScore.Text = score.ToString();// display score

                    titan2[i].y = -100;
                }
                titan[i].MovePlanet();
                titan2[i].MoveTitan2();

                if (spaceship.spaceRec.IntersectsWith(titan[i].titanrec))
                {
                    //reset planet[i] back to top of panel

                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }
                if (spaceship.spaceRec.IntersectsWith(titan2[i].titanrec))
                {
                    //reset planet[i] back to top of panel

                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }

        private void FrmDodge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Space) { up = true; }
            if (e.KeyData == Keys.Up) { up = true; }


        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                spaceship.MoveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                spaceship.MoveSpaceship(move);
            }
            if (up)
            {
                move = "up";
                spaceship.MoveSpaceship(move);
            }
            if (down)
            {
                move = "down";
                spaceship.MoveSpaceship(move);
                up = false;
            }
            if (spaceship.spaceRec.Location.Y > 389)
            {
                down = false;
            }
            if (spaceship.spaceRec.Location.Y < 150)
            {
                up = false;
                down = true;
            }

          
        }

        private void tmrColosion_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 1; i++)
            {
                titan[i].MovePlanet();
                if (spaceship.spaceRec.IntersectsWith(titan[i].titanrec))
                {
                    //reset planet[i] back to top of panel

                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }


                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (titan[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    lblScore.Text = score.ToString();// display score

                    titan[i].y = 30;
                }



            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            TmrPlanet.Enabled = true;
            TmrShip.Enabled = true;
        
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrShip.Enabled = false;
            TmrPlanet.Enabled = false;
            tmrColosion.Enabled = false;

        }

        private void FrmDodge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Space) { down = true; up = false; }

        }


        private void CheckLives()
        {
            if (lives == 0)
            {
                tmrColosion.Enabled = false;
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over");

            }

        }

    }
}