using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeGame
    {
        /// <summary>
        /// Used to store the name of the player
        /// <summary>

        string PlayerName { get; set; }
        void ResetGrid();

        /// <summary>
        /// Identifies the cell owner of a cell in a speficied row - col
        /// </summary> 
        /// <param name = "CellRow">the row of the cell </param>
        /// <param name = "CellCol">the column of the cell </param>
        /// <returns> the identity of the owner of the cell </returns>
        CellOwners IdentifyCellOwner(int CellRow, int CellCol);

        /*
         * ProfReynolds
         * in the method signature - changed Cellcol to CellCol
         * note: there are 30 refeences to this method; ReSharper made the change a snap
         */
        /// <summary>
        /// sets the cell owner of a cell in a specific row - col
        /// </summary>
        /// <param name="CellRow">the row of the cell</param>
        /// <param name="CellCol">the column opf the cell</param>
        /// <param name="CellOwner">the new owner of the cell</param>

        void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner);
        void AutoPlayComputer();
        bool CheckForWinner();
        string IdentifyWinner();

    }
}
