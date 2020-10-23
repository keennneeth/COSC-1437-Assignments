using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeGame
    {
        /// <summary>
        /// Used to store the name of the player
        /// <summary>

        string PlayerName { get; set; }

        /// <summary>
        /// Identifies the cell owner of a cell in a speficied row - col
        /// <summary>
        /// <param name = "CellRow" = the row of the cell </param>
        /// <param name = "CellCol" = the column of the cell </param>
        /// <returns> the identity of the owner of the cell </returns>
        CellOwners IdentifyCellOwner(int CellRow, int CellCol);

        /// <summary>
        /// sets the cell owner of a cell in a specific row - col
        /// </summary>
        /// <param name="CellRow">the row of the cell</param>
        /// <param name="CellCol">the column opf the cell</param>
        /// <param name="CellOwner">the new owner of the cell</param>

        void AssignCellOwner(int CellRow, int Cellcol, CellOwners CellOwner);

    }
}
