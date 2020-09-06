﻿using System;
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
    public partial class FrmGame : Form
    {
      
        


        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Titan[] titan = new Titan[7];
        Titan2[] titan2 = new Titan2[7];
        Titan3[] titan3 = new Titan3[7];

        rock[] rock = new rock[7];
        Beast[] beast = new Beast[7];
        Background[] background = new Background[7];
        Background2[] background2 = new Background2[7];
        Background3[] background3 = new Background3[7];
        flare flare = new flare();
        Random yspeed = new Random();
        Random xloc = new Random();
        Player player = new Player();
        bool left, right, up, down;
        bool turnLeft, turnLEFT, mssg;
        int Acceleration;
        string move;
        int cycle;
        int score, lives, stop, stop2, fall, thump, flare1, flip;
        public FrmGame()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            PnlGame.Size = new System.Drawing.Size(1000, 450);



            for (int i = 0; i < 7; i++)
            {
                int x = 235 + (i * 75);
                int x2 = 320 + (i * 75);
                int x3 = 0 + (i * 75);
                int x4 = 370 + (i * 75);
                int x5 = 185 + (i * 75);
                rock[i] = new rock(235);
                titan[i] = new Titan(x);
                titan2[i] = new Titan2(x2);
                titan3[i] = new Titan3(x4);

                background[i] = new Background(x3);
                background2[i] = new Background2(x3);
                background3[i] = new Background3(x3);

                beast[i] = new Beast(x5);


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
                Acceleration = (score / 10)*2;
                if (score > 19)
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
                if (score < 31)
                {
                    beast[i].y = 1000;
                }

                if  (beast[i].y < PnlGame.Width)
                {
                    if (score > 29)
                    {
                        
                        background[i].x += 0;
                        background2[i].x += 0;
                        background3[i].x += 0;

                        titan2[i].y += 8+Acceleration;
                        titan3[i].y += 7 + Acceleration;

                        rock[i].y = 0;
                        rock[i].x = 500;

                        if (thump > 1)
                        {
                            if (thump < 10)
                            {
                                beast[i].y += 7;
                                beast[i].ChangeSprite2();
                            }
                        }

                        if (thump > 10)
                        {
                            if (thump < 15)
                            {
                                beast[i].ChangeSprite();
                            }
                        }

                        if (thump > 15)
                        {
                            if (thump < 25)
                            {
                                beast[i].y += 7;
                                beast[i].ChangeSprite2();
                            }
                        }

                        if (thump > 25)
                        {
                            if (thump < 30)
                            {
                                beast[i].ChangeSprite3();
                            }
                        }


                        if (stop < 7)
                        {
                            titan[i].y += 7;



                        }





                        else
                        {
                            titan[i].y += 0;

                            titan[i].ChangeSprite();
                        }
                        if (stop < 12)
                        {

                        }
                        else
                        {

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

                    titan3[i].y += 12 + Acceleration;

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
                    titan3[i].ChangeSprite();


                }
                if (stop2 ==2)
                { titan2[i].ChangeSprite();
                    titan3[i].ChangeSprite2();




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
               

                if (score > 20)
                {
                    if (score < 30)
                    {
                        rock[i].DrawRock(g);
                    }
                }

                if (titan[i].y < 1000)
                {
                    titan[i].DrawPlanet(g);
                }
                if (titan2[i].y <1000)
                {
                    titan2[i].DrawTitan2(g);
                }
                if (titan3[i].y < 1000)
                {
                    titan3[i].DrawTitan3(g);
                }

              
                if (score > 29)
                {
                    beast[i].DrawBeast(g);
                }
                player.Drawplayer(g);

                if (flare.width > 2)
                {
                    if (score > 19)
                    {
                        flare.DrawFlare(g);
                    }
                }
            }

        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            if (thump> 30)
            {
                thump = 0;
            }

            if (score > 19)
            {
                flare1 += 1;
            }
            stop += 1;
            stop2 += 1;
            healthbar.Width = lives*10;

            thump += 1;

           
            for (int i = 0; i < 1; i++)
            {
                titan[i].MovePlanet();
                titan2[i].MoveTitan2();
                titan3[i].MoveTitan3();

                rock[i].MoveRock();
                beast[i].MoveBeast();
                int rndmloc = (xloc.Next(1000, 1500))-score;
                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (score == 31)
                {
                    beast[i].y = 0;
                }

                if (titan[i].y >= 2500)
                {
                 
                    
                        titan[i].y = -100;
                    
                }

                if (titan3[i].y >= 2500)
                {


                    titan3[i].y = -100;

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
                if (titan3[i].y > 1000)
                {
                    if (titan3[i].y < 1200)
                    {
                        score += 1;//update the score
                        lblScore.Text = score.ToString();// display score
                        titan3[i].y = 1200;
                    }

                }

                if (rock[i].x == 350)
                {
                    rock[i].SpriteChange();
                    rock[i].x = 350;

                }
                if (rock[i].y >= 1000)
                {
                    rock[i].SpriteChange2();

                    rock[i].x = 0;
                    rock[i].y = 100;

                }


                if (titan2[i].y >= 2500)
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
                titan3[i].MoveTitan3();
                beast[i].MoveBeast();
                background[i].MoveBackground();
                background2[i].MoveBackground();
                background3[i].MoveBackground();


                if (player.spaceRec.IntersectsWith(titan[i].titanrec))
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

                if (player.spaceRec.IntersectsWith(beast[i].titanrec))
                {

                    if (score > 30)
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

                if (player.spaceRec.IntersectsWith(titan2[i].titanrec))
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

                if (player.spaceRec.IntersectsWith(titan3[i].titanrec))
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
                if (player.spaceRec.IntersectsWith(rock[i].titanrec))
                {
                    //reset planet[i] back to top of panel
                    if (score > 20)
                    {
                        if (score < 30){
                            //reset planet[i] back to top of panel
                            lives -= 1;// lose a life
                            txtLives.Text = lives.ToString();// display number of lives
                            CheckLives();
                        }
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
            if (flare.width > 2)
            {
                if (score > 19)
                {
                    turnLEFT = false;
                    turnLeft = false;


                }
            }
            cycle += 1;
            thump += 1;
            label3.Text = thump.ToString();

            if (turnLeft) { 
                player.rotationAngle -= 20;
        }
            if(turnLEFT)
            {
                player.rotationAngle -= 35;

            }
            if (player.spaceRec.Location.Y < 260)
            {
                flip += 1;
            }

            if (stop2 < 2)
            {
                player.SpriteChange();
                if(lives < 75)
                {
                    if (lives > 50)
                    {
                        player.InjuredSpriteChange();
                    }

                }
                if (lives < 50)
                {
                    if (lives > 25)
                    {
                        player.InjuredSpriteChange21();

                    }
                }
                if (lives < 25)
                {
                    player.InjuredSpriteChange31();

                }
            }
            if (stop2 == 2)
            {
                player.SpriteChange2();
                if (lives < 75)
                {
                    if (lives > 50)
                    {
                        player.injuredSpriteChange2();
                    }

                }
                if (lives < 50)
                {
                    if (lives > 25)
                    {
                        player.injuredSpriteChange22();
                    }

                }
                if (lives < 25)
                {
                    player.injuredSpriteChange32();

                }
            }

            if (stop2 == 4)
            {
                player.SpriteChange3();
                if (lives < 75)
                {
                    if (lives > 50)
                    {
                        player.InjuredSpriteChange3();
                    }
                }
                if (lives < 50)
                {
                    if (lives > 25)
                    {
                        player.InjuredSpriteChange23();
                    }
                }
                if (lives < 25)
                {
                    player.InjuredSpriteChange33();

                }
            }

            if (stop2 == 8)
            {
                player.SpriteChange2();
                cycle = 0;
                if (lives < 75)
                {
                    if (lives > 50)
                    {
                        player.injuredSpriteChange2();
                    }
                }
                if (lives < 50)
                {
                    if (lives > 25)
                    {
                        player.injuredSpriteChange22();
                    }
                }
                if (lives < 25)
                {
                    player.injuredSpriteChange32();

                }
            }
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.Moveplayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.Moveplayer(move);
            }
            if (flip == 1)
            {
                player.SpriteChange6();
                if (lives < 75)
                {
                    if (lives > 50)
                    {
                        player.InjuredSpriteChange6();
                    }
                }
                if (lives < 50)
                {
                    if (lives > 25)
                    {
                        player.InjuredSpriteChange26();
                    }
                }
                if (lives < 25)
                {
                    player.InjuredSpriteChange36();

                }

            }
            if (up)
            {


                if (player.spaceRec.Location.Y < 260)
                {
                    
                        player.SpriteChange7();
                    turnLeft = true;
                    if (lives < 75)
                    {
                        if (lives > 50)
                        {
                            player.InjuredSpriteChange7();
                        }
                    }
                    if (lives < 50)
                    {
                        if (lives > 25)
                        {
                            player.InjuredSpriteChange27();
                        }
                    }
                    if (lives < 25)
                    {
                        player.InjuredSpriteChange37();

                    }

                }

                


                if (fall > 0)
                {
                    move = "up";
                    player.Moveplayer(move);
                    fall -= 1;
                }
            }
            if (down)
            {
                player.SpriteChange8();
                if (lives < 75)
                {
                    if (lives > 50)
                    {
                        player.InjuredSpriteChange8();
                    }
                }
                if (lives < 50)
                {
                    if (lives > 25)
                    {
                        player.InjuredSpriteChange28();
                    }
                }
                if (lives < 25)
                {
                    player.InjuredSpriteChange38();

                }
                turnLEFT = true;
                move = "down";
                player.Moveplayer(move);
                up = false;
            }
            if (player.spaceRec.Location.Y > 259)
            {
                down = false;
                fall = 10;
                turnLeft = false;
                player.rotationAngle =0;

                turnLEFT = false;

            }
            if (player.spaceRec.Location.Y < 85)
            {
         
            }
            else
            {
                player.Flip2();
            }
            if (player.spaceRec.Location.Y < 10)
            {
                up = false;
                down = true;
     
                fall = 0;
            }
            if (player.spaceRec.Location.Y > 260)
            {
                down = false;
                player.spaceRec.Y = 260;
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
            if (e.KeyData == Keys.Enter) { mssg = true; label3.Text = thump.ToString(); label3.Visible = true; textBox1.Visible = false; lblname.Text = textBox1.Text; lblstart.Visible = true; lblyourname.Visible = false; }
        }

        private void textBox1_KeyDown(object sender, KeyPressEventArgs e)
        {

          
                e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lblstart_MouseLeave(object sender, EventArgs e)
        {
            lblstart.BackColor = System.Drawing.Color.White;
        }

        private void lblstart_MouseEnter(object sender, EventArgs e)
        {
            lblstart.BackColor = System.Drawing.Color.Gray;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                if (mssg)
                {
                   
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Please enter only Upper or lowercase letters");
                }
            }


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
            lives = 100;
            txtLives.Text = lives.ToString();
            lblyourname.Visible = false;
            lblname.Visible = false;

            lblfinalscore.Visible = false;
            startscreen.Visible = false;
            lblstart.Visible = false;
            score =29;
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
            lblstart.BackColor = System.Drawing.Color.Gray;
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