namespace TicTacToeProject
{
    partial class TicTacToe_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbXwins = new System.Windows.Forms.Label();
            this.lbDraws = new System.Windows.Forms.Label();
            this.lbOwins = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.changeModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // changeModeToolStripMenuItem
            // 
            this.changeModeToolStripMenuItem.Name = "changeModeToolStripMenuItem";
            this.changeModeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.changeModeToolStripMenuItem.Text = "Change Mode";
            this.changeModeToolStripMenuItem.Click += new System.EventHandler(this.changeModeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Silver;
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.FlatAppearance.BorderSize = 0;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.A1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.A1.Location = new System.Drawing.Point(22, 45);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(130, 130);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Silver;
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.FlatAppearance.BorderSize = 0;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.A2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.A2.Location = new System.Drawing.Point(170, 45);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(130, 130);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Silver;
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.FlatAppearance.BorderSize = 0;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.A3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.A3.Location = new System.Drawing.Point(318, 45);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(130, 130);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Silver;
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.FlatAppearance.BorderSize = 0;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.B1.Location = new System.Drawing.Point(22, 199);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(130, 130);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Silver;
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.FlatAppearance.BorderSize = 0;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.B2.Location = new System.Drawing.Point(170, 199);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(130, 130);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Silver;
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.FlatAppearance.BorderSize = 0;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.B3.Location = new System.Drawing.Point(318, 199);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(130, 130);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Silver;
            this.C1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C1.FlatAppearance.BorderSize = 0;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.C1.Location = new System.Drawing.Point(22, 353);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(130, 130);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Silver;
            this.C2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C2.FlatAppearance.BorderSize = 0;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.C2.Location = new System.Drawing.Point(170, 353);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(130, 130);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Silver;
            this.C3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C3.FlatAppearance.BorderSize = 0;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.C3.Location = new System.Drawing.Point(318, 353);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(130, 130);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(180, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbXwins
            // 
            this.lbXwins.AutoSize = true;
            this.lbXwins.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbXwins.Location = new System.Drawing.Point(73, 542);
            this.lbXwins.Name = "lbXwins";
            this.lbXwins.Size = new System.Drawing.Size(22, 25);
            this.lbXwins.TabIndex = 13;
            this.lbXwins.Text = "0";
            // 
            // lbDraws
            // 
            this.lbDraws.AutoSize = true;
            this.lbDraws.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDraws.Location = new System.Drawing.Point(221, 542);
            this.lbDraws.Name = "lbDraws";
            this.lbDraws.Size = new System.Drawing.Size(22, 25);
            this.lbDraws.TabIndex = 14;
            this.lbDraws.Text = "0";
            // 
            // lbOwins
            // 
            this.lbOwins.AutoSize = true;
            this.lbOwins.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOwins.Location = new System.Drawing.Point(369, 542);
            this.lbOwins.Name = "lbOwins";
            this.lbOwins.Size = new System.Drawing.Size(22, 25);
            this.lbOwins.TabIndex = 15;
            this.lbOwins.Text = "0";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p2.Location = new System.Drawing.Point(326, 502);
            this.p2.MaximumSize = new System.Drawing.Size(110, 25);
            this.p2.MinimumSize = new System.Drawing.Size(110, 25);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(110, 25);
            this.p2.TabIndex = 12;
            this.p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p1.Location = new System.Drawing.Point(30, 502);
            this.p1.MaximumSize = new System.Drawing.Size(110, 25);
            this.p1.MinimumSize = new System.Drawing.Size(110, 25);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(110, 25);
            this.p1.TabIndex = 10;
            this.p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToe_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 586);
            this.Controls.Add(this.lbOwins);
            this.Controls.Add(this.lbDraws);
            this.Controls.Add(this.lbXwins);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 633);
            this.MinimumSize = new System.Drawing.Size(493, 633);
            this.Name = "TicTacToe_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicTacToe_Form_FormClosed);
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Label label2;
        private Label lbXwins;
        private Label lbDraws;
        private Label lbOwins;
        private Label p2;
        private Label p1;
        private ToolStripMenuItem changeModeToolStripMenuItem;
    }
}