using TicTacToeProject;
using CarRacingGame;

namespace ChooseGames
{
    public partial class ChooseGameCollection_Form : Form
    {
        public ChooseGameCollection_Form()
        {
            InitializeComponent();
        }

        private void buttonUfo_Click(object sender, EventArgs e)
        {
            FormUfo ufo = new FormUfo();
            ufo.Show();
            this.Hide();
        }

        private void buttonTicTacToe_Click(object sender, EventArgs e)
        {
            TicTacToe_Form tictactoe = new TicTacToe_Form();
            tictactoe.Show();
            this.Hide();
        }
    }
}