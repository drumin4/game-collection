namespace CarRacingGame
{
    partial class FormUfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUfo));
            this.panelRoad = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cowImage = new System.Windows.Forms.PictureBox();
            this.lblEndScore = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.Car4 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Ufo = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.cowScore = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.panelRoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.DarkGray;
            this.panelRoad.Controls.Add(this.progressBar1);
            this.panelRoad.Controls.Add(this.cowImage);
            this.panelRoad.Controls.Add(this.lblEndScore);
            this.panelRoad.Controls.Add(this.txtInfo);
            this.panelRoad.Controls.Add(this.lblGameOver);
            this.panelRoad.Controls.Add(this.Car4);
            this.panelRoad.Controls.Add(this.Car3);
            this.panelRoad.Controls.Add(this.Car2);
            this.panelRoad.Controls.Add(this.Ufo);
            this.panelRoad.Controls.Add(this.pictureBox5);
            this.panelRoad.Controls.Add(this.pictureBox6);
            this.panelRoad.Controls.Add(this.pictureBox4);
            this.panelRoad.Controls.Add(this.pictureBox3);
            this.panelRoad.Controls.Add(this.pictureBox2);
            this.panelRoad.Controls.Add(this.pictureBox1);
            this.panelRoad.Location = new System.Drawing.Point(66, 1);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(484, 549);
            this.panelRoad.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 522);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 29);
            this.progressBar1.TabIndex = 17;
            // 
            // cowImage
            // 
            this.cowImage.Image = ((System.Drawing.Image)(resources.GetObject("cowImage.Image")));
            this.cowImage.Location = new System.Drawing.Point(178, 53);
            this.cowImage.Name = "cowImage";
            this.cowImage.Size = new System.Drawing.Size(45, 38);
            this.cowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cowImage.TabIndex = 16;
            this.cowImage.TabStop = false;
            // 
            // lblEndScore
            // 
            this.lblEndScore.AutoSize = true;
            this.lblEndScore.BackColor = System.Drawing.Color.YellowGreen;
            this.lblEndScore.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndScore.Location = new System.Drawing.Point(178, 190);
            this.lblEndScore.Name = "lblEndScore";
            this.lblEndScore.Size = new System.Drawing.Size(118, 38);
            this.lblEndScore.TabIndex = 15;
            this.lblEndScore.Text = "Score: 0";
            this.lblEndScore.Visible = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Yellow;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfo.Enabled = false;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.ForeColor = System.Drawing.Color.Red;
            this.txtInfo.Location = new System.Drawing.Point(143, 292);
            this.txtInfo.MaximumSize = new System.Drawing.Size(190, 53);
            this.txtInfo.MinimumSize = new System.Drawing.Size(190, 53);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(190, 53);
            this.txtInfo.TabIndex = 13;
            this.txtInfo.Text = "Try Again - Enter\r\nExit - Esc\r\n";
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInfo.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Yellow;
            this.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameOver.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(143, 246);
            this.lblGameOver.MaximumSize = new System.Drawing.Size(190, 47);
            this.lblGameOver.MinimumSize = new System.Drawing.Size(190, 47);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(190, 47);
            this.lblGameOver.TabIndex = 14;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // Car4
            // 
            this.Car4.Image = ((System.Drawing.Image)(resources.GetObject("Car4.Image")));
            this.Car4.Location = new System.Drawing.Point(327, -1);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(25, 48);
            this.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car4.TabIndex = 10;
            this.Car4.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.Image = ((System.Drawing.Image)(resources.GetObject("Car3.Image")));
            this.Car3.Location = new System.Drawing.Point(54, 224);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(25, 48);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 9;
            this.Car3.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(31, 58);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(25, 48);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 8;
            this.Car2.TabStop = false;
            // 
            // Ufo
            // 
            this.Ufo.BackColor = System.Drawing.Color.Transparent;
            this.Ufo.Image = ((System.Drawing.Image)(resources.GetObject("Ufo.Image")));
            this.Ufo.Location = new System.Drawing.Point(208, 480);
            this.Ufo.Name = "Ufo";
            this.Ufo.Size = new System.Drawing.Size(47, 36);
            this.Ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ufo.TabIndex = 6;
            this.Ufo.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(457, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(13, 549);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(12, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(13, 549);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(233, 502);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 94);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(233, 315);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 94);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(233, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 94);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(233, -47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 550);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(3, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(60, 62);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.lblScore);
            this.panel2.Controls.Add(this.cowScore);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Location = new System.Drawing.Point(550, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 549);
            this.panel2.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(22, 43);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // cowScore
            // 
            this.cowScore.Image = ((System.Drawing.Image)(resources.GetObject("cowScore.Image")));
            this.cowScore.Location = new System.Drawing.Point(13, 13);
            this.cowScore.Name = "cowScore";
            this.cowScore.Size = new System.Drawing.Size(34, 30);
            this.cowScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cowScore.TabIndex = 4;
            this.cowScore.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(0, 454);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(60, 62);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 303);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(60, 62);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Interval = 1000;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // FormUfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUfo";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUfo_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UfoMovement_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelRoad.ResumeLayout(false);
            this.panelRoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelRoad;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Ufo;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox Car4;
        private PictureBox Car3;
        private PictureBox Car2;
        private TextBox txtInfo;
        private Label lblGameOver;
        private Label lblEndScore;
        private Label lblScore;
        private PictureBox cowScore;
        private PictureBox cowImage;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerProgress;
    }
}