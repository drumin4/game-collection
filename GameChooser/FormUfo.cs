using System;

namespace CarRacingGame
{
    public partial class FormUfo : Form
    {
        int speed = 10;
        bool movesLeft2 = true;
        bool gameOngoing = true;
        
        public FormUfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLines(speed);
            moveCars(speed);
            collideCars();
            collideCows();
            moveCow(speed);
            
            
        }

        private void moveCars(int speed)
        {
            if (Car2.Top > 643)
            {
                Car2.Top = -94;
            }
            else
            {
                Car2.Top += speed - 3;
                

                if (movesLeft2 && Car2.Left > 26)
                {
                    Car2.Left -= 2;
                }
                else if (movesLeft2 == false && Car2.Left < 423)
                {
                    Car2.Left += 2;
                }
                else
                {
                    movesLeft2 = !movesLeft2;
                }
            }

            if (Car3.Top > 643)
            {
                Random random = new Random();
                Car3.Left = random.Next(26, 423);
                Car3.Top = -94;
            }
            else
            {
                Car3.Top += speed - 4;

            }

            if (Car4.Top > 643)
            {
                Random random = new Random();
                Car4.Left = random.Next(26, 423);
                Car4.Top = -94;
            }
            else
            {
                Car4.Top += speed - 4;

            }
        }

        private void moveLines(int speed)
        {
            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;
            pictureBox8.Top += speed;
            pictureBox9.Top += speed;
            pictureBox10.Top += speed;

            if (pictureBox1.Top > 643)
            {
                pictureBox1.Top = -94;
            }

            if (pictureBox2.Top > 643)
            {
                pictureBox2.Top = -94;
            }

            if (pictureBox3.Top > 643)
            {
                pictureBox3.Top = -94;
            }

            if (pictureBox4.Top > 643)
            {
                pictureBox4.Top = -94;
            }

            if (pictureBox8.Top > 643)
            {
                pictureBox8.Top = -94;
            }

            if (pictureBox9.Top > 643)
            {
                pictureBox9.Top = -94;
            }

            if (pictureBox10.Top > 643)
            {
                pictureBox10.Top = -94;
            }
        }

        private void moveCow(int speed)
        {
            cowImage.Top += speed -7;
            Random random = new Random();

            

            if (cowImage.Top > 643)
            {
                cowImage.Visible = true;
                cowImage.Top = -500;
                cowImage.Left = random.Next(29, 386);
            }


        }

        private void collideCars()
        {
            if (Ufo.Bounds.IntersectsWith(Car2.Bounds))
                gameOver();
            if (Ufo.Bounds.IntersectsWith(Car3.Bounds))
                gameOver();
            if (Ufo.Bounds.IntersectsWith(Car4.Bounds))
                gameOver();
        }

        private void collideCows()
        {
            Random random = new Random();

            if (Ufo.Bounds.IntersectsWith(cowImage.Bounds))
            {
                lblScore.Text = (int.Parse(lblScore.Text) + 1).ToString();
                lblEndScore.Text = "Score: " + (int.Parse(lblEndScore.Text.Substring(7)) + 1).ToString();
                cowImage.Top = -500;
                cowImage.Left = random.Next(29, 386);
            }
        }

        private void gameOver()
        {
            lblGameOver.Visible = true;
            lblEndScore.Visible = true;
            txtInfo.Visible = true;
            lblScore.Visible = false;
            cowScore.Visible = false;
            cowImage.Top = -94;
            lblScore.Text = "0";
            gameOngoing = false;
            speed = 0;
        }

        private void gameOverWon()
        {
            gameOver();
            lblGameOver.Text = "You Won!";
            txtInfo.Text = "Play again - Enter\r\nExit - Esc";
        }

        private void UfoMovement_KeyDown(object sender, KeyEventArgs e)
        {
            if (Ufo.Left > 29)
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    Ufo.Left -= 18;
                }
            }

            if (Ufo.Right < 450)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    Ufo.Left += 18;
                }
            }

            if (speed > 1)
            {


                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    speed--;
                }
            }

            if (speed < 16)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    speed++;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                speed = 10;
                lblGameOver.Visible = false;
                lblEndScore.Visible = false;
                txtInfo.Visible = false;
                lblScore.Visible = true;
                cowScore.Visible = true;
                Car2.Top = -94;
                Car3.Top = -94;
                Car4.Top = -300;
                progressBar1.Value = 0;
                lblEndScore.Text = "Score: 0";
                speed = 10;
                gameOngoing = true;
            }
            
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            
            if (gameOngoing == false)
            {
                progressBar1.Increment(0);
            }
            else
            {
                progressBar1.Increment(1);
            }
                

            if(progressBar1.Value == progressBar1.Maximum)
            {
                gameOverWon();
            }

        }


        private void FormUfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}