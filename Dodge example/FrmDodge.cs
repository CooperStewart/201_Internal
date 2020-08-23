using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
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

        int score, lives, stop, stop2;
        public FrmDodge()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });



            for (int i = 0; i < 7; i++)
            {
                int x = 200 + (i * 75);
                int x2 = 300 + (i * 75);


                titan[i] = new Titan(x);
                titan2[i] = new Titan2(x2);



            }


        }

        private void FrmDodge_Load(object sender, EventArgs e)
        {

           
            lbljump.Visible = true;

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {

            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 1; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 10)+ score/10;
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



                }
                if (stop2 <2)
                {
                    titan2[i].ChangeSprite4();

                }
                if (stop2 ==2)
                { titan2[i].ChangeSprite();
                
                }

                if (stop2 == 4)
                {
                    titan2[i].ChangeSprite2();

                }

                if (stop2 == 6)
                {
                    titan2[i].ChangeSprite3();
                    stop2 = 0;

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
            stop2 += 1;
            healthbar.Width = lives;
          
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
                    titan[i].y = 0;
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }
                if (spaceship.spaceRec.IntersectsWith(titan2[i].titanrec))
                {
                    //reset planet[i] back to top of panel
                    titan2[i].y = 0;

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
            if (spaceship.spaceRec.Location.Y < 50)
            {
                up = false;
                down = true;
            }

          
        }

        private void txtLives_Click(object sender, EventArgs e)
        {

        }

        private void healthbar_Click(object sender, EventArgs e)
        {

        }

        private void tmrhelp_Tick(object sender, EventArgs e)
        {
            if (up == true)
            {
                lbljump.Visible=false;
                TmrPlanet.Enabled = true;
                TmrShip.Enabled = true;
            }
        }

        private void MnuStart_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            startscreen.Visible = false;
            lblstart.Visible = false;
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            lbljump.Visible = false;
            TmrPlanet.Enabled = true;
            TmrShip.Enabled = true;

        }

        private void lblstart_MouseHover(object sender, EventArgs e)
        {
        }

        private void startscreen_Click(object sender, EventArgs e)
        {

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