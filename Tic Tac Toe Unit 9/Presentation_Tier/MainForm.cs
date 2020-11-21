using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

/*
 * ProfReynolds - i did this:
 * copy the CoreLibrary project to this solution folder
 * add the dependency for the CorLibrary project (AND you need to 
 */
using CoreLibrary; 

using TicTacToe_Interfaces;

/*
 * ProfReynolds
 * your name here
 */

/*
 * ProfReynolds
 * very important - the button names should be
 * btnCell00, btnCell01, btnCell02, btnCell10, ... btnCell22
 * this is required so that CellOwnerChangedHandler will function properly
 */

namespace Presentation_Tier
{
    public partial class MainForm : Form
    {

        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();


        public MainForm()
        {
            InitializeComponent();
        }

        /*
         * ProfReynolds
         * I rearranged the methods. Does not change the operation but makes it easier to follow:
         * 1) constructor (MainForm) and never put anything other than InitializeComponent in the method
         * 2) form events especially the load event
         * 3) control events especially the click events
         * 4) other event handlers such as the _ticTacToeGame.CellOwnerChanged
         * 5) misc necessary methods (since very, very little implementation belongs in the UI, this should be limited)
         */

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
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
            // ProfReynolds - iside methods, the variable should begin with a lowercase
            var playerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = playerNameIsValid;
            btnGoComputer.Enabled = playerNameIsValid;

            panel1.Enabled = playerNameIsValid;


            // as the content changes, this event will trigger as each charcter changes
        }

        /*
         * ProfReynolds
         * you do not want this event. You do want the Validated event. When the
         * control has been validated, this command is needed:
         * _ticTacToeGame.PlayerName = txtPlayerName.Text;
         */
        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            /*
             * ProfReynolds
             * need this: _ticTacToeGame.ResetGrid();
             */

            _ticTacToeGame.ResetGrid(); // profreynolds **

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
                MessageBox.Show("Computer", "The Winner!");
                // ProfReynolds - this would be better: MessageBox.Show("Computer","The Winner!");
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


            // ProfReynolds: This is even better than the above:

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show(_ticTacToeGame.PlayerName, "The Winner!");
                // ProfReynolds - this would be better: MessageBox.Show(_ticTacToeGame.PlayerName,"The Winner!");
            }
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
