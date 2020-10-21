using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeCell
    {
        // Property indicating the row of the referenced sqaure (0-2)

        int RowID { get; set;  }

        // Property indicating the column of the referenced square (0-2)

        int ColID { get; set; }

        // Property indicating the owner of a square (human, computer, open, error)

        CellOwners CellOwner { get; set; }
    }
}
