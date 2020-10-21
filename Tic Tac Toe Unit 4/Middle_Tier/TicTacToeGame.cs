using System;
using TicTacToe_Interfaces;

namespace Middle_Tier
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
