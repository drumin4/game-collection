namespace ChooseGames
{
    partial class ChooseGameCollection_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGameCollection_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUfo = new System.Windows.Forms.Button();
            this.buttonTicTacToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Shrikhand", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a game:";
            // 
            // buttonUfo
            // 
            this.buttonUfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonUfo.FlatAppearance.BorderSize = 4;
            this.buttonUfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUfo.Location = new System.Drawing.Point(54, 189);
            this.buttonUfo.Name = "buttonUfo";
            this.buttonUfo.Size = new System.Drawing.Size(201, 74);
            this.buttonUfo.TabIndex = 1;
            this.buttonUfo.Text = "UFO Prowl";
            this.buttonUfo.UseVisualStyleBackColor = false;
            this.buttonUfo.Click += new System.EventHandler(this.buttonUfo_Click);
            // 
            // buttonTicTacToe
            // 
            this.buttonTicTacToe.BackColor = System.Drawing.Color.Silver;
            this.buttonTicTacToe.FlatAppearance.BorderSize = 4;
            this.buttonTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicTacToe.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTicTacToe.Location = new System.Drawing.Point(322, 189);
            this.buttonTicTacToe.Name = "buttonTicTacToe";
            this.buttonTicTacToe.Size = new System.Drawing.Size(201, 74);
            this.buttonTicTacToe.TabIndex = 2;
            this.buttonTicTacToe.Text = "Tic Tac Toe";
            this.buttonTicTacToe.UseVisualStyleBackColor = false;
            this.buttonTicTacToe.Click += new System.EventHandler(this.buttonTicTacToe_Click);
            // 
            // ChooseGameCollection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(574, 313);
            this.Controls.Add(this.buttonTicTacToe);
            this.Controls.Add(this.buttonUfo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseGameCollection_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonUfo;
        private Button buttonTicTacToe;
    }
}