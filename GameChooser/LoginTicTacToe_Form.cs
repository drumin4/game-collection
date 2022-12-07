using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeProject
{
    public partial class LoginTicTacToe_Form : Form
    {
        string checker;

        public LoginTicTacToe_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checker = button2.Text;
            TicTacToe_Form.setPlayerNames(p1Name.Text, p2Name.Text, checker);
            
            try
            {
                if (p1Name.Text != "" && p2Name.Text != "" && checker == "Change to Singleplayer")
                {
                    Close();
                }
                    
                else if (p1Name.Text != "" && checker == "Change to Multiplayer")
                    Close();
                else if (checker == "Change to Singleplayer")
                    MessageBox.Show("I need both names.\nPlease try again :)");
                else
                    MessageBox.Show("I need your name.\nPlease try again :)");
            }
            
            catch
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1Name.Text = "";
            p2Name.Text = "";

            if (button2.Text == "Change to Singleplayer")
            {
                button2.Text = "Change to Multiplayer";
                p2Name.Hide();
                label2.Hide();
                p2Name.Text = "Computer";
            }
                
            else
            {
                button2.Text = "Change to Singleplayer";
                p2Name.Show();
                label2.Show();
                p2Name.Clear();
            }
        }

        private void p1Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button1.PerformClick();
        }

        private void p2Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button1.PerformClick();
        }
    }
}
