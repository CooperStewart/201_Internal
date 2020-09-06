namespace Dodge_example
{
    partial class FrmGame
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
            this.lblyourname = new System.Windows.Forms.Label();
            this.lblfinalscore = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.PnlGame.Controls.Add(this.lblyourname);
            this.PnlGame.Controls.Add(this.lblfinalscore);
            this.PnlGame.Controls.Add(this.lblname);
            this.PnlGame.Controls.Add(this.textBox1);
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
            this.PnlGame.Controls.Add(this.pictureBox2);
            this.PnlGame.Location = new System.Drawing.Point(-3, 5);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(986, 457);
            this.PnlGame.TabIndex = 1;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // lblyourname
            // 
            this.lblyourname.AutoSize = true;
            this.lblyourname.BackColor = System.Drawing.Color.White;
            this.lblyourname.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold);
            this.lblyourname.Location = new System.Drawing.Point(230, 295);
            this.lblyourname.Name = "lblyourname";
            this.lblyourname.Size = new System.Drawing.Size(563, 76);
            this.lblyourname.TabIndex = 18;
            this.lblyourname.Text = "Enter Your Name";
            // 
            // lblfinalscore
            // 
            this.lblfinalscore.AutoSize = true;
            this.lblfinalscore.BackColor = System.Drawing.Color.White;
            this.lblfinalscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold);
            this.lblfinalscore.Location = new System.Drawing.Point(708, 381);
            this.lblfinalscore.Name = "lblfinalscore";
            this.lblfinalscore.Size = new System.Drawing.Size(71, 76);
            this.lblfinalscore.TabIndex = 16;
            this.lblfinalscore.Text = "1";
            this.lblfinalscore.Visible = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(230, 381);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(246, 76);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Thump";
            this.lblname.Visible = false;
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(243, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 98);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblthump1
            // 
            this.lblthump1.AutoSize = true;
            this.lblthump1.BackColor = System.Drawing.Color.White;
            this.lblthump1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblthump1.Location = new System.Drawing.Point(-282, 194);
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
            this.lblstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold);
            this.lblstart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblstart.Location = new System.Drawing.Point(360, 95);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(282, 120);
            this.lblstart.TabIndex = 7;
            this.lblstart.Text = "Start";
            this.lblstart.Visible = false;
            this.lblstart.Click += new System.EventHandler(this.label3_Click);
            this.lblstart.MouseEnter += new System.EventHandler(this.lblstart_MouseEnter);
            this.lblstart.MouseLeave += new System.EventHandler(this.lblstart_MouseLeave);
            this.lblstart.MouseHover += new System.EventHandler(this.lblstart_MouseHover);
            // 
            // startscreen
            // 
            this.startscreen.BackgroundImage = global::Dodge_example.Properties.Resources.damien_hausson_promo_bg_low_copie;
            this.startscreen.Location = new System.Drawing.Point(3, -5);
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
            this.healthbar.Location = new System.Drawing.Point(3, -1);
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
            this.txtLives.Visible = false;
            this.txtLives.Click += new System.EventHandler(this.txtLives_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(857, 22);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(28, 29);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(749, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
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
            this.label1.Visible = false;
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
            this.TmrShip.Interval = 1;
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
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "FrmGame";
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
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.PictureBox healthbar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbljump;
        private System.Windows.Forms.Timer tmrhelp;
        private System.Windows.Forms.PictureBox startscreen;
        public System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblthump1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblfinalscore;
        public System.Windows.Forms.Label lblyourname;
        private System.Windows.Forms.Timer TmrShip;
    }
}

