namespace Dodge_example
{
    partial class FrmDodge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.lblthump3 = new System.Windows.Forms.Label();
            this.lblthump2 = new System.Windows.Forms.Label();
            this.lblthump1 = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Label();
            this.startscreen = new System.Windows.Forms.PictureBox();
            this.lbljump = new System.Windows.Forms.Label();
            this.healthbar = new System.Windows.Forms.PictureBox();
            this.txtLives = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlanetDodge = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.tmrJump = new System.Windows.Forms.Timer(this.components);
            this.tmrhelp = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.White;
            this.PnlGame.Controls.Add(this.lblthump3);
            this.PnlGame.Controls.Add(this.lblthump2);
            this.PnlGame.Controls.Add(this.lblthump1);
            this.PnlGame.Controls.Add(this.lblstart);
            this.PnlGame.Controls.Add(this.startscreen);
            this.PnlGame.Controls.Add(this.lbljump);
            this.PnlGame.Controls.Add(this.healthbar);
            this.PnlGame.Controls.Add(this.txtLives);
            this.PnlGame.Controls.Add(this.lblScore);
            this.PnlGame.Controls.Add(this.label2);
            this.PnlGame.Controls.Add(this.txtName);
            this.PnlGame.Controls.Add(this.label1);
            this.PnlGame.Controls.Add(this.PlanetDodge);
            this.PnlGame.Controls.Add(this.pictureBox2);
            this.PnlGame.Location = new System.Drawing.Point(-3, 5);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(986, 457);
            this.PnlGame.TabIndex = 1;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // lblthump3
            // 
            this.lblthump3.AutoSize = true;
            this.lblthump3.BackColor = System.Drawing.Color.White;
            this.lblthump3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblthump3.Location = new System.Drawing.Point(699, 65);
            this.lblthump3.Name = "lblthump3";
            this.lblthump3.Size = new System.Drawing.Size(241, 76);
            this.lblthump3.TabIndex = 14;
            this.lblthump3.Text = "Thump";
            this.lblthump3.Visible = false;
            // 
            // lblthump2
            // 
            this.lblthump2.AutoSize = true;
            this.lblthump2.BackColor = System.Drawing.Color.White;
            this.lblthump2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblthump2.Location = new System.Drawing.Point(363, 256);
            this.lblthump2.Name = "lblthump2";
            this.lblthump2.Size = new System.Drawing.Size(241, 76);
            this.lblthump2.TabIndex = 13;
            this.lblthump2.Text = "Thump";
            this.lblthump2.Visible = false;
            // 
            // lblthump1
            // 
            this.lblthump1.AutoSize = true;
            this.lblthump1.BackColor = System.Drawing.Color.White;
            this.lblthump1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblthump1.Location = new System.Drawing.Point(-313, 19);
            this.lblthump1.Name = "lblthump1";
            this.lblthump1.Size = new System.Drawing.Size(1625, 76);
            this.lblthump1.TabIndex = 12;
            this.lblthump1.Text = " System.IO.Stream str = Properties.Resources.music;";
            this.lblthump1.Visible = false;
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.BackColor = System.Drawing.Color.White;
            this.lblstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F);
            this.lblstart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblstart.Location = new System.Drawing.Point(348, 112);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(277, 120);
            this.lblstart.TabIndex = 7;
            this.lblstart.Text = "Start";
            this.lblstart.Click += new System.EventHandler(this.label3_Click);
            this.lblstart.MouseHover += new System.EventHandler(this.lblstart_MouseHover);
            // 
            // startscreen
            // 
            this.startscreen.BackgroundImage = global::Dodge_example.Properties.Resources.damien_hausson_promo_bg_low_copie;
            this.startscreen.Location = new System.Drawing.Point(0, -5);
            this.startscreen.Name = "startscreen";
            this.startscreen.Size = new System.Drawing.Size(986, 462);
            this.startscreen.TabIndex = 11;
            this.startscreen.TabStop = false;
            this.startscreen.Click += new System.EventHandler(this.startscreen_Click);
            // 
            // lbljump
            // 
            this.lbljump.AutoSize = true;
            this.lbljump.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.lbljump.Location = new System.Drawing.Point(112, 112);
            this.lbljump.Name = "lbljump";
            this.lbljump.Size = new System.Drawing.Size(348, 29);
            this.lbljump.TabIndex = 10;
            this.lbljump.Text = "Press the spacebar to jump";
            this.lbljump.Visible = false;
            // 
            // healthbar
            // 
            this.healthbar.BackColor = System.Drawing.Color.Lime;
            this.healthbar.Location = new System.Drawing.Point(3, 0);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(986, 20);
            this.healthbar.TabIndex = 8;
            this.healthbar.TabStop = false;
            this.healthbar.Click += new System.EventHandler(this.healthbar_Click);
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.Location = new System.Drawing.Point(600, 6);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(25, 13);
            this.txtLives.TabIndex = 2;
            this.txtLives.Text = "200";
            this.txtLives.Click += new System.EventHandler(this.txtLives_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(492, 62);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(504, 385);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // PlanetDodge
            // 
            this.PlanetDodge.AutoSize = true;
            this.PlanetDodge.Location = new System.Drawing.Point(15, 19);
            this.PlanetDodge.Name = "PlanetDodge";
            this.PlanetDodge.Size = new System.Drawing.Size(72, 13);
            this.PlanetDodge.TabIndex = 2;
            this.PlanetDodge.Text = "Planet Dodge";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox2.Location = new System.Drawing.Point(3, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(986, 20);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Interval = 50;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TmrShip
            // 
            this.TmrShip.Interval = 10;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // tmrJump
            // 
            this.tmrJump.Interval = 1000;
            this.tmrJump.Tick += new System.EventHandler(this.tmrJump_Tick);
            // 
            // tmrhelp
            // 
            this.tmrhelp.Enabled = true;
            this.tmrhelp.Tick += new System.EventHandler(this.tmrhelp_Tick);
            // 
            // FrmDodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "FrmDodge";
            this.Text = "Dodge";
            this.Load += new System.EventHandler(this.FrmDodge_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlanetDodge;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.PictureBox healthbar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbljump;
        private System.Windows.Forms.Timer tmrhelp;
        private System.Windows.Forms.PictureBox startscreen;
        private System.Windows.Forms.Label lblthump3;
        public System.Windows.Forms.Label lblthump2;
        private System.Windows.Forms.Label lblthump1;
    }
}

