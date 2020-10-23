using System;
using System.Collections.ObjectModel;
using TicTacToe_Interfaces;

/*
 * Kenneth Rodriguez
 */

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "The Human";
        public CellOwners Winner { get; private set; }

        /// <summary>
        ///     This class defines a set of cells
        /// </summary>
        private readonly Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();

        // notice - no constructor. I dont think one is needed

        public void ResetGrid()
        {
            _ticTacToeCells.Clear(); // resets the collection to empty

            Winner = CellOwners.Open;

            // create the 9 cells
            for (var rowNo = 0; rowNo < 3; rowNo++)
                for (var colNo = 0; colNo < 3; colNo++)
                {
                    _ticTacToeCells.Add(new TicTacToeCell
                    {
                        RowID = rowNo,
                        ColID = colNo
                    });
                }

        }

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }

        public void AutoPlayComputer()
        {
            throw new NotImplementedException();
        }

        public bool CheckForWinner()
        {
            return false;
        }

        public string IdentifyWinner()
        {
            return "";
        }

    }
}