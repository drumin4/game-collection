using System;
using System.Runtime.CompilerServices;

namespace TicTacToeProject
{
    public partial class TicTacToe_Form : Form
    {
        bool turn = true;
        int turn_count = 0;
        static int winsX = 0, winsO = 0, draws = 0;
        static string player1Name = "", player2Name = "";
        static string checker = "Change to Singleplayer";
        
        public TicTacToe_Form()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            LoginTicTacToe_Form f2 = new LoginTicTacToe_Form();
            f2.ShowDialog();
            p1.Text = player1Name;
            p2.Text = player2Name;
        }

        public static void setPlayerNames(string name1, string name2, string _checker)
        {
            player1Name = name1;
            player2Name = name2;
            if (player1Name != "")
                player1Name = player1Name[0].ToString().ToUpper() + player1Name.Substring(1).ToLower();
            if (player2Name != "")
                player2Name = player2Name[0].ToString().ToUpper() + player2Name.Substring(1).ToLower();
            checker = _checker;
        }

        private void computer_make_move()
        {
            Button? move = null;

            move = check_if_can_win_or_block("O");
            if (move == null)
            {
                move = check_if_can_win_or_block("X");
                if (move == null)
                {
                    move = attempt_win();
                    while (move == null)
                        move = take_free_spot();
                }
            }

            move.PerformClick();
        }

        private Button? check_if_can_win_or_block(string mark)
        {
            if (A1.Text == "" && A2.Text == mark && A3.Text == mark)
                return A1;
            if (A1.Text == mark && A2.Text == "" && A3.Text == mark)
                return A2;
            if (A1.Text == mark && A2.Text == mark && A3.Text == "")
                return A3;

            if (B1.Text == "" && B2.Text == mark && B3.Text == mark)
                return B1;
            if (B1.Text == mark && B2.Text == "" && B3.Text == mark)
                return B2;
            if (B1.Text == mark && B2.Text == mark && B3.Text == "")
                return B3;

            if (C1.Text == "" && C2.Text == mark && C3.Text == mark)
                return C1;
            if (C1.Text == mark && C2.Text == "" && C3.Text == mark)
                return C2;
            if (C1.Text == mark && C2.Text == mark && C3.Text == "")
                return C3;

            
            if (A1.Text == "" && B1.Text == mark && C1.Text == mark)
                return A1;
            if (A1.Text == mark && B1.Text == "" && C1.Text == mark)
                return B1;
            if (A1.Text == mark && B1.Text == mark && C1.Text == "")
                return C1;

            if (A2.Text == "" && B2.Text == mark && C2.Text == mark)
                return A2;
            if (A2.Text == mark && B2.Text == "" && C2.Text == mark)
                return B2;
            if (A2.Text == mark && B2.Text == mark && C2.Text == "")
                return C2;

            if (A3.Text == "" && B3.Text == mark && C3.Text == mark)
                return A3;
            if (A3.Text == mark && B3.Text == "" && C3.Text == mark)
                return B3;
            if (A3.Text == mark && B3.Text == mark && C3.Text == "")
                return C3;


            if (A1.Text == "" && B2.Text == mark && C3.Text == mark)
                return A1;
            if (A1.Text == mark && B2.Text == "" && C3.Text == mark)
                return B2;
            if (A1.Text == mark && B2.Text == mark && C3.Text == "")
                return C3;

            if (A3.Text == "" && B2.Text == mark && C1.Text == mark)
                return A3;
            if (A3.Text == mark && B2.Text == "" && C1.Text == mark)
                return B2;
            if (A3.Text == mark && B2.Text == mark && C1.Text == "")
                return C1;
            return null;
        }

        private Button? attempt_win()
        {
            var list = new List<Button>();
            Button? buttonToPress = null;

            if (A1.Text == "O")
            {
                if (A2.Text == "")
                    list.Add(A2);
                if (B1.Text == "")
                    list.Add(B1);
                if (B2.Text == "")
                    list.Add(B2);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }

            if (A2.Text == "O")
            {
                if (A1.Text == "")
                    list.Add(A1);
                if (A3.Text == "")
                    list.Add(A3);
                if (B2.Text == "")
                    list.Add(B2);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }
            
            if (A3.Text == "O")
            {
                if (A2.Text == "")
                    list.Add(A2);
                if (B2.Text == "")
                    list.Add(B2);
                if (B3.Text == "")
                    list.Add(B3);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }
            
            if (B1.Text == "O")
            {
                if (A1.Text == "")
                    list.Add(A1);
                if (B2.Text == "")
                    list.Add(B2);
                if (C1.Text == "")
                    list.Add(C1);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }
            
            if (B2.Text == "O")
            {
                if (A1.Text == "" && C3.Text == "")
                    list.Add(A1);
                if (A2.Text == "" && C2.Text == "")
                    list.Add(A2);
                if (A3.Text == "" && C1.Text == "")
                    list.Add(A3);
                if (B1.Text == "" && B3.Text == "")
                    list.Add(B1);
                if (B3.Text == "" && B1.Text == "")
                    list.Add(B3);
                if (C1.Text == "" && A3.Text == "")
                    list.Add(C1);
                if (C2.Text == "" && A2.Text == "")
                    list.Add(C2);
                if (C3.Text == "" && A1.Text == "")
                    list.Add(C3);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }

            if (B3.Text == "O")
            {
                if (A3.Text == "")
                    list.Add(A3);
                if (B2.Text == "")
                    list.Add(B2);
                if (C3.Text == "")
                    list.Add(C3);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }
            
            if (C1.Text == "O")
            {
                if (B1.Text == "")
                    list.Add(B1);
                if (B2.Text == "")
                    list.Add(B2);
                if (C2.Text == "")
                    list.Add(C2);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }

            if (C2.Text == "O")
            {
                if (C1.Text == "")
                    list.Add(C1);
                if (B2.Text == "")
                    list.Add(B2);
                if (C3.Text == "")
                    list.Add(C3);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }

            if (C3.Text == "O")
            {
                if (C2.Text == "")
                    list.Add(C2);
                if (B2.Text == "")
                    list.Add(B2);
                if (B3.Text == "")
                    list.Add(B3);

                select_bttn_from_list(list, ref buttonToPress);
                if (buttonToPress != null)
                    return buttonToPress;
            }

            return buttonToPress;
        }

        private Button? take_free_spot()
        {

            var options = new List<Button>() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            var availableOptions = options.FindAll(x => x.Text == "");
            Button? buttonToPress = null;

            select_bttn_from_list(availableOptions, ref buttonToPress);
            return buttonToPress;

        }

        private void select_bttn_from_list(List<Button> list, ref Button pressedBttn)
        {
            Random random = new Random();
            if (list.Count != 0)
            {
                int randomIndex = random.Next(list.Count);
                pressedBttn = list[randomIndex];
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Leo", "Info");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn && b.Text == "X" && b.ForeColor == Color.FromArgb(64, 64, 64))
            {
                turn = !turn;
                b.ForeColor = Color.Black;
                turn_count++;
                
            }
                
            else if(b.Text == "O" && b.ForeColor == Color.FromArgb(64, 64, 64))
            {
                turn = !turn;
                b.ForeColor = Color.Black;
                turn_count++;
            }

            else if (b.Text == "" && b.ForeColor == Color.FromArgb(64, 64, 64))
            {
                turn = !turn;
                b.ForeColor = Color.Black;
                turn_count++;
                b.Text = "O";
            }

            checkForWinner();

            if (p2.Text == "Computer" && turn == false)
            {
                computer_make_move();
            }
        }

        private void checkForWinner()
        {
            bool winnerFound = false;
            string winner="";

            if(A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
            {
                if (A1.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound = true;
                winner = A1.Text;
                
            }
            
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                if (B1.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound =true;
                winner = B1.Text;
            }
            
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                if (C1.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound =true;
                winner = C1.Text;
            }
            
            else if (A1.Text == B1.Text && A1.Text == C1.Text && A1.Text != "")
            {
                if (A1.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound = true;
                winner = A1.Text;
            }
            
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
            {
                if (A2.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound = true;
                winner = A2.Text;
            }
            
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
            {
                if (A3.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound = true;
                winner= A3.Text;
            }
            
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                if (A1.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound = true;
                winner = A1.Text;
            }
            
            else if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
            {
                if (A3.Text == "X")
                    MessageBox.Show(player1Name + " won!");

                else
                    MessageBox.Show(player2Name + " won!");
                winnerFound = true;
                winner = A3.Text;
            }

            if(winnerFound)
            {
                resetGame();
            }
            else if(turn_count == 9)
            {
                MessageBox.Show("It's a Draw!");
                resetGame();
                draws++;
            }

            winnerCount(winner);
            lbXwins.Text = winsX.ToString();
            lbDraws.Text = draws.ToString();
            lbOwins.Text = winsO.ToString();
        }

        private void winnerCount(string winner)
        {
            if (winner == "X")
                winsX++;
            else if (winner == "O")
                winsO++;
        }
        
        private void resetGame()
        {
            foreach(Control c in Controls)
            {
                if (c is Button)
                {
                    c.ForeColor = Color.FromArgb(64, 64, 64);
                    c.Text = "";
                }
                    
            }
            turn = true;
            turn_count = 0;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
            winsX = 0;
            winsO = 0;
            draws = 0;
            lbOwins.Text = "0";
            lbXwins.Text = "0";
            lbDraws.Text = "0";
        }

        private void changeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            player1Name = "";
            player2Name = "";
            winsX = 0;
            winsO = 0;
            draws = 0;
            lbOwins.Text = "0";
            lbXwins.Text = "0";
            lbDraws.Text = "0";
            
            LoginTicTacToe_Form f2 = new LoginTicTacToe_Form();
            f2.ShowDialog();

            if(player1Name != "")
                p1.Text = player1Name[0].ToString().ToUpper() + player1Name.Substring(1).ToLower();
            if(player2Name != "")
                p2.Text = player2Name[0].ToString().ToUpper() + player2Name.Substring(1).ToLower();


            resetGame();
            
            try
            {
                this.Show();
            }
            
            catch { }
        }

        private new void MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn && b.Text == "")
            {
                b.Text = "X";
            }
            
            else if (b.Text == "")
            {
                b.Text = "O";
            }
        }

        private new void MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text != "" && b.ForeColor != Color.Black)
            {
                b.Text = "";
            }
        }

        private void TicTacToe_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}