using System;
using System.Windows.Forms;

namespace Presentation_Tier
{
    public partial class MainForm : Form
    {

        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var newForm = new AboutBox();
            newForm.Show();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)

        {

            var PlayerNameIsVaid = (txtPlayerName.Text.Length >= 3);


            // as the content changes, this event will trigger as each charcter changes
        }

        private void txtPlayerName_VisibleChanged(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("btnStartNewGame", "Button Click");
            foreach (var item in panel1.Controls)
            {
                var btn = item as Button;
                if (btn != null)
                {
                    btn.Text = "?";
                }
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("btnGoComputer", "Button Click");

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell01", "Button Click");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell02", "Button Click");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell03", "Button Click");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell04", "Button Click");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell05", "Button Click");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell06", "Button Click");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell07", "Button Click");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell08", "Button Click");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell09", "Button Click");
        }

   
    }
}
