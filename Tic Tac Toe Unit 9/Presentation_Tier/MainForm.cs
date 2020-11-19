using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using CoreLibrary;
using TicTacToe_Interfaces;


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

            var PlayerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = PlayerNameIsValid;
            btnGoComputer.Enabled = PlayerNameIsValid;

            panel1.Enabled = PlayerNameIsValid;


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
               if (item is Button btn)
                {
                    btn.Text = "?";
                }
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("btnGoComputer", "Button Click");
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }

        private void btnCellxx_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            var btn = sender as Button;
            var rowID = btn.Name.Substring(7, 1).ToInt();
            var colID = btn.Name.Substring(8, 1).ToInt();

            Debug.WriteLine($"Button click: row={rowID} col={colID}");

            _ticTacToeGame.AssignCellOwner(rowID, colID, CellOwners.Human);
            btn.Text = "X";

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
        }
        private void CellOwnerChangedHandler(object sender, Middle_Tier.TicTacToeGame.CellOwnerChangedArgs e)
        {
            var buttonName = $"btnCell{e.RowID}{e.ColID}";
            foreach (var control in panel1.Controls)
            {
                if (control is Button button)
                {
                    if (button.Name == buttonName)
                    {
                        switch (e.CellOwner)
                        {
                            case CellOwners.Error:
                                button.Text = "#";
                                break;

                            case CellOwners.Open:
                                button.Text = "?";
                                break;

                            case CellOwners.Human:
                                button.Text = "X";
                                break;

                            case CellOwners.Computer:
                                button.Text = "O";
                                break;

                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                }
            }
        }



    }
}
