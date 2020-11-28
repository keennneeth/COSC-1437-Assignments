using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreLibrary;
using TicTacToe_Interfaces;

/*
 * ProfReynolds
 * your name here
 */

namespace TicTacToeGraphics
{
    /*
     * ProfReynolds
     * form is properly named, but the file is names Form1.
     * Typically, when you rename the file, the class is
     * optionally renamed. But this does not work the other way around.
     * I fixed it
     */
    public partial class MainForm : Form
    {
        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartNewGame_Click(object sender, EventArgs e)
        {
            _ticTacToeGame.ResetGrid();

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is GameCell gameCell)
                {
                    gameCell.GameCellOwner = CellOwners.Open;
                }
            }
        }

        private void CellOwnerChangedHandler(object sender, Middle_Tier.TicTacToeGame.CellOwnerChangedArgs e)
        {
            foreach (var control in tableLayoutPanel1.Controls)
            {
                if (control is GameCell gameCell)
                {
                    /*
                     * ProfReynolds
                     * in the designer, each user control must have the GameCellCol and GameCellRow properties set.
                     * currently, they are all 0-0.
                     */
                    if (gameCell.GameCellRow == e.RowID &&
                        gameCell.GameCellCol == e.ColID)
                    {
                        gameCell.GameCellOwner = e.CellOwner;
                    }
                }
            }
        }


        private void gameCell_CellOwnerChanged(object sender)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            var gameCell = sender as GameCell;

            _ticTacToeGame.AssignCellOwner(gameCell.GameCellRow, gameCell.GameCellCol, CellOwners.Human);

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show(@"The Winner is the Human!");
            }
        }

        private void GoComputer_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }

        /*
         * ProfReynolds
         * this is working fine. But the text box should be initialized. Otherwise, everything
         * is initialized but there is no player.
         */
        private void PlayerName_TextChanged(object sender, EventArgs e)
        {
            var playerNameIsValid = (PlayerName.Text.Length >= 3);

            StartNewGame.Enabled = playerNameIsValid;
            GoComputer.Enabled = playerNameIsValid;
            tableLayoutPanel1.Enabled = playerNameIsValid;
        }

        private void PlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
            /*
             * ProfReynolds
             * this event method should place the value of txtlayerName.Text into
             * the property _ticTacToeGame.PlayerName
             */
        }

        /*
         * ProfReynolds
         * this is correct, but should normally be immediately after the constructor method.
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
        }

    }
}
