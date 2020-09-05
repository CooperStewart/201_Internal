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
using System.Threading;

namespace Dodge_example
{
    public partial class FrmDodge : Form
    {
      
        


        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Titan[] titan = new Titan[7];
        Titan2[] titan2 = new Titan2[7];
        rock[] rock = new rock[7];
        Beast[] beast = new Beast[7];
        Background[] background = new Background[7];
        Background2[] background2 = new Background2[7];
        Background3[] background3 = new Background3[7];
        flare flare = new flare();
        Random yspeed = new Random();
        Random xloc = new Random();
        Spaceship spaceship = new Spaceship();
        bool left, right, up, down;
        bool turnLeft, turnLEFT;
        int Acceleration;
        string move;
        int cycle;
        int score, lives, stop, stop2, fall, thump, flare1, flip;
        public FrmDodge()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            PnlGame.Size = new System.Drawing.Size(1000, 450);



            for (int i = 0; i < 7; i++)
            {
                int x = 235 + (i * 75);
                int x2 = 320 + (i * 75);
                int x3 = 0 + (i * 75);
                rock[i] = new rock(235);
                titan[i] = new Titan(x);
                titan2[i] = new Titan2(x2);
                background[i] = new Background(x3);
                background2[i] = new Background2(x3);
                background3[i] = new Background3(x3);

                beast[i] = new Beast(x);


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
                int rndmspeed = yspeed.Next(5, 10)+ (score/10);
                rock[i].x += 15+((rock[i].x/100)*2);
                beast[i].y += 7;
                Acceleration = (score / 10)*2;
                if (score > 9)
                {
                    if (flare1 < 10)
                    {
                        flare.width += 150;
                    }
                    if (flare1 > 10)
                    {
                        flare.width -= 200;
                    }
                }
                if (score < 16)
                {
                    beast[i].y = 1000;
                }

                if  (beast[i].y < PnlGame.Width)
                {
                    if (score > 14)
                    {
                        background[i].x += 0;
                        background2[i].x += 0;
                        background3[i].x += 0;

                        titan2[i].y += 8+Acceleration;
                        rock[i].y = 0;
                        rock[i].x = 500;
                        if (stop < 7)
                        {
                            titan[i].y += 6 +Acceleration;


                        }
                        else
                        {
                            titan[i].y += 0;

                            titan[i].ChangeSprite();
                        }
                        if (stop == 20)
                        {
                            stop = 0;
                            titan[i].ChangeSprite2();



                        }
                    }
                }
               
                
                else
                {

                    background[i].x += 7+Acceleration;
                    background2[i].x = background[i].x - 1000;
                    background3[i].x = background[i].x + 1000;

                    background[i].y = 0;
                    background2[i].y = 0;
                    background3[i].y = 0;
                    titan2[i].y += 15 + Acceleration;
                    if (rock[i].x < 345)
                    {
                        rock[i].y += 15 + Acceleration;
                    }
                    else
                    {
                        rock[i].y += 7+Acceleration;

                    }
                    if (stop < 7)
                    {
                        titan[i].y += 13 +Acceleration;


                    }
                    else
                    {
                        titan[i].y += 7+Acceleration;

                        titan[i].ChangeSprite();
                    }
                    if (stop == 20)
                    {
                        stop = 0;
                        titan[i].ChangeSprite2();



                    }

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
                titan2[i].y += rndmspeed;
                //call the Planet class's drawPlanet method to draw the images
                background3[i].DrawBackground(g);
                background2[i].DrawBackground(g);
                background[i].DrawBackground(g);
               

                if (score > 10)
                {
                    if (score < 15)
                    {
                        rock[i].DrawRock(g);
                    }
                }


                titan[i].DrawPlanet(g);
                titan2[i].DrawTitan2(g);
                if (flare.width > 2)
                {
                    if (score > 9)
                    {
                        flare.DrawFlare(g);
                    }
                }
                if (score > 14)
                {
                    beast[i].DrawBeast(g);
                }
                spaceship.DrawSpaceship(g);


            }

        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            if (score > 9)
            {
                flare1 += 1;
            }
            stop += 1;
            stop2 += 1;
            healthbar.Width = lives*5;
          
       

            if (thump > 55)
            {
                lblthump1.Visible = false;
                lblname.Visible = false;
            }
            for (int i = 0; i < 1; i++)
            {
                titan[i].MovePlanet();
                titan2[i].MoveTitan2();
                rock[i].MoveRock();
                beast[i].MoveBeast();
                int rndmloc = (xloc.Next(1000, 1500))-score;
                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (score == 15)
                {
                    beast[i].y = 0;
                }

                if (titan[i].y >= 1700)
                {
                 
                    
                        titan[i].y = -100;
                    
                }

                if (beast[i].y > 1000)
                {
                    if (beast[i].y < 1200)
                    {
                        score += 10;//update the score
                        lblScore.Text = score.ToString();// display score
                        beast[i].y = 1200;
                    }

                }

                if (titan[i].y > 1000)
                {
                    if (titan[i].y < 1200)
                    {
                        score += 1;//update the score
                        lblScore.Text = score.ToString();// display score
                        titan[i].y = 1200;
                    }

                }

                if (rock[i].x >= 350)
                {

                    rock[i].x = 350;

                }
                if (rock[i].y >= 1000)
                {

                    rock[i].x = 0;
                    rock[i].y = 100;

                }


                if (titan2[i].y >= 1700)
                {


                    titan2[i].y = -100;
                }


                if (titan2[i].y > 1000)
                {
                    if (titan2[i].y < 1200)
                    {
                        score += 1;//update the score
                        lblScore.Text = score.ToString();// display score
                        titan2[i].y = 1200;
                    }

                }

                if (background[i].x > 1000)
                {
                    background[i].x = -1000;
                }


              

              
                titan[i].MovePlanet();
                titan2[i].MoveTitan2();
                background[i].MoveBackground();
                background2[i].MoveBackground();
                background3[i].MoveBackground();


                if (spaceship.spaceRec.IntersectsWith(titan[i].titanrec))
                {
                    //reset planet[i] back to top of panel
                    if (down == false)
                    {
                        if (up == false)
                        {
                            lives -= 1;// lose a life
                            txtLives.Text = lives.ToString();// display number of lives
                            CheckLives();
                        }
                    }
                }

                if (spaceship.spaceRec.IntersectsWith(beast[i].titanrec))
                {

                    if (score > 15)
                    {
                        //reset planet[i] back to top of panel
                        if (down == false)
                        {
                            if (up == false)
                            {
                                lives -= 3;// lose a life
                                txtLives.Text = lives.ToString();// display number of lives
                                CheckLives();
                            }
                        }
                    }
                }

                if (spaceship.spaceRec.IntersectsWith(titan2[i].titanrec))
                {
                    //reset planet[i] back to top of panel
                    if (down == false)
                    {
                        if (up == false)
                        {
                            lives -= 1;// lose a life
                            txtLives.Text = lives.ToString();// display number of lives
                            CheckLives();
                        }
                    }
                }
                if (spaceship.spaceRec.IntersectsWith(rock[i].titanrec))
                {
                    //reset planet[i] back to top of panel
                    if (score > 10)
                    {
                        //reset planet[i] back to top of panel
                        lives -= 1;// lose a life
                        txtLives.Text = lives.ToString();// display number of lives
                        CheckLives();
                    }
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

            cycle += 1;
       

            if (turnLeft) { 
                spaceship.rotationAngle -= 20;
        }
            if(turnLEFT)
            {
                spaceship.rotationAngle -= 35;

            }
            if (spaceship.spaceRec.Location.Y < 260)
            {
                flip += 1;
            }

            if (stop2 < 2)
            {
                spaceship.SpriteChange();
                if(lives < 150)
                {
                    if (lives > 100)
                    {
                        spaceship.InjuredSpriteChange();
                    }

                }
                if (lives < 100)
                {
                    if (lives > 50)
                    {
                        spaceship.InjuredSpriteChange21();

                    }
                }
                if (lives < 50)
                {
                    spaceship.InjuredSpriteChange31();

                }
            }
            if (stop2 == 2)
            {
                spaceship.SpriteChange2();
                if (lives < 150)
                {
                    if (lives > 100)
                    {
                        spaceship.injuredSpriteChange2();
                    }

                }
                if (lives < 100)
                {
                    if (lives > 50)
                    {
                        spaceship.injuredSpriteChange22();
                    }

                }
                if (lives < 50)
                {
                    spaceship.injuredSpriteChange32();

                }
            }

            if (stop2 == 4)
            {
                spaceship.SpriteChange3();
                if (lives < 150)
                {
                    if (lives > 100)
                    {
                        spaceship.InjuredSpriteChange3();
                    }
                }
                if (lives < 100)
                {
                    if (lives > 50)
                    {
                        spaceship.InjuredSpriteChange23();
                    }
                }
                if (lives < 50)
                {
                    spaceship.InjuredSpriteChange33();

                }
            }

            if (stop2 == 8)
            {
                spaceship.SpriteChange2();
                cycle = 0;
                if (lives < 150)
                {
                    if (lives > 100)
                    {
                        spaceship.injuredSpriteChange2();
                    }
                }
                if (lives < 100)
                {
                    if (lives > 50)
                    {
                        spaceship.injuredSpriteChange22();
                    }
                }
                if (lives < 50)
                {
                    spaceship.injuredSpriteChange32();

                }
            }
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
            if (flip == 1)
            {
                spaceship.SpriteChange6();
                if (lives < 150)
                {
                    if (lives > 100)
                    {
                        spaceship.InjuredSpriteChange6();
                    }
                }
                if (lives < 100)
                {
                    if (lives > 50)
                    {
                        spaceship.InjuredSpriteChange26();
                    }
                }
                if (lives < 50)
                {
                    spaceship.InjuredSpriteChange36();

                }

            }
            if (up)
            {


                if (spaceship.spaceRec.Location.Y < 260)
                {
                    
                        spaceship.SpriteChange7();
                    turnLeft = true;
                    if (lives < 150)
                    {
                        if (lives > 100)
                        {
                            spaceship.InjuredSpriteChange7();
                        }
                    }
                    if (lives < 100)
                    {
                        if (lives > 50)
                        {
                            spaceship.InjuredSpriteChange27();
                        }
                    }
                    if (lives < 50)
                    {
                        spaceship.InjuredSpriteChange37();

                    }

                }

                


                if (fall > 0)
                {
                    move = "up";
                    spaceship.MoveSpaceship(move);
                    fall -= 1;
                }
            }
            if (down)
            {
                spaceship.SpriteChange8();
                if (lives < 150)
                {
                    if (lives > 100)
                    {
                        spaceship.InjuredSpriteChange8();
                    }
                }
                if (lives < 100)
                {
                    if (lives > 50)
                    {
                        spaceship.InjuredSpriteChange28();
                    }
                }
                if (lives < 50)
                {
                    spaceship.InjuredSpriteChange38();

                }
                turnLEFT = true;
                move = "down";
                spaceship.MoveSpaceship(move);
                up = false;
            }
            if (spaceship.spaceRec.Location.Y > 259)
            {
                down = false;
                fall = 10;
                turnLeft = false;
                spaceship.rotationAngle =0;

                turnLEFT = false;

            }
            if (spaceship.spaceRec.Location.Y < 85)
            {
         
            }
            else
            {
                spaceship.Flip2();
            }
            if (spaceship.spaceRec.Location.Y < 10)
            {
                up = false;
                down = true;
     
                fall = 0;
            }
            if (spaceship.spaceRec.Location.Y > 260)
            {
                down = false;
                spaceship.spaceRec.Y = 260;
            }
        }

        private void txtLives_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { textBox1.Visible = false; lblname.Text = textBox1.Text; lblstart.Visible = true; lblyourname.Visible = false; }

        }

        private void lbl1_Click(object sender, EventArgs e)
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
            lives = 200;
            txtLives.Text = lives.ToString();
            lblyourname.Visible = false;
            lblname.Visible = false;

            lblfinalscore.Visible = false;
            startscreen.Visible = false;
            lblstart.Visible = false;
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            lbljump.Visible = false;
            TmrPlanet.Enabled = true;
            TmrShip.Enabled = true;
           
        }

        private void tmrJump_Tick(object sender, EventArgs e)
        {
            fall += 1;
            
        }

        private void lblstart_MouseHover(object sender, EventArgs e)
        {
        }

        private void startscreen_Click(object sender, EventArgs e)
        {

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
            tmrJump.Enabled = false;

        }

        private void FrmDodge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }

        }


        private void CheckLives()
        {
            if (lives < 1)
            {
                left = false;
            
            right = false; 
            lblstart.Visible = true;
                lblstart.Text = "Restart";
                lblyourname.Visible = true;
                lblyourname.Text = "Final Score";
                lblfinalscore.Visible = true;
                lblfinalscore.Text = lblScore.Text;
                lblname.Visible = true;
                startscreen.Visible = true;
                tmrJump.Enabled = false;
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over");

            }

        }

      

    }
}