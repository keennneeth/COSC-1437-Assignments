using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_Interfaces;

namespace Buisness_Layer_CSharp1
{
    
        public class TicTacToeGame : ITicTacToeGame
        {
            public string PlayerName { get; set; } = "The Human";

            public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
            {
                throw new NotImplementedException();
            }

            public void SetCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
            {
                throw new NotImplementedException();
            }
        }
}
