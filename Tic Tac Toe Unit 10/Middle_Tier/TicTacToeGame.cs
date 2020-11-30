﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using TicTacToe_Interfaces;

/*
 * Kenneth Rodriguez
 */

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame

    {

        public delegate void CellOwnerChangedHandler(object sender, CellOwnerChangedArgs e);

        public string PlayerName { get; set; } = "The Human";
        public CellOwners Winner { get; private set; }

        /// <summary>
        ///     This class defines a set of cells
        /// </summary>
        private readonly Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();
        private Collection<TicTacToeCell> _goodNextMove;
        private Collection<Collection<TicTacToeCell>> _winningCombinations;


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




            _goodNextMove = new Collection<TicTacToeCell>()
                 {
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1), // the computer will use center square, if open
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0), // upper-left
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2), // upper right
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0), // lower left
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2), // lower-right
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1), // top-center
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0), // middle-left
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2), // middle-right
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1), // lower-center
                };

            _winningCombinations = new Collection<Collection<TicTacToeCell>>()
            {
                new Collection<TicTacToeCell>() // loading the first row
                {
                    // the reference to these objects is in the collection - not new ones!
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the second row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the first column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the first diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading final diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0)
                },
            };


            Debug.WriteLine("\nMethod: Reset()");

        }

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            if (_ticTacToeCells.Count == 0) return CellOwners.Error;

            var cellOwner =
                    _ticTacToeCells
                      .FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol)
                      ?.CellOwner
                    ?? CellOwners.Error;

            Debug.WriteLine($"Method: IdentifyCellOwner {CellRow}-{CellCol} --> {cellOwner}");

            return cellOwner;

        }

        public void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {

            if (_ticTacToeCells.Count == 0) return;

            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;

            var targetCell = _ticTacToeCells
                .FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol);

            if (targetCell == null)
                return;

            targetCell.CellOwner = CellOwner;

            Debug.WriteLine($"Method: AssignCellOwner {CellRow}-{CellCol} {CellOwner}");
            var eventArgs = new CellOwnerChangedArgs(CellRow, CellCol, CellOwner);

            CellOwnerChanged?.Invoke(this, eventArgs);
        }

        public void AutoPlayComputer()
        {
            if (_ticTacToeCells.Count == 0) return;
            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;


            // checking if the computer is the winner

            /*
             * ProfReynolds
             * this section will require significant revision in the semester project.
             * instructions are provided in the lab manual
             * (just giving you a heads-up)
             */
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if ((combination[1].CellOwner == CellOwners.Computer) &&
                        (combination[2].CellOwner == CellOwners.Computer))
                    {
                        AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Computer) &&
                        (combination[2].CellOwner == CellOwners.Computer))
                    {
                        AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Computer) &&
                        (combination[1].CellOwner == CellOwners.Computer))
                    {
                        AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }

            // checking if the human is the winner


            foreach (var targetCell in _goodNextMove)
            {
                if (targetCell.CellOwner == CellOwners.Open)
                {
                    AssignCellOwner(targetCell.RowID, targetCell.ColID, CellOwners.Computer);
                    return;
                }
            }
        }
   
              

        
        public bool CheckForWinner()

            {
                // first row

                if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                    (IdentifyCellOwner(0, 1) == CellOwners.Human) &&
                    (IdentifyCellOwner(0, 2) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }

                // second row

                if ((IdentifyCellOwner(1, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 2) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }
                // third row

                if ((IdentifyCellOwner(2, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 2) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }

                // first column

                if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 0) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }

                // second column

                if ((IdentifyCellOwner(0, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 1) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }

                // third column

                if ((IdentifyCellOwner(0, 2) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 2) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 2) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }

                //   '\' diagonal

                if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 2) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }

                // '/' diagonal

                if ((IdentifyCellOwner(2, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(0, 2) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }



                // Computer Winning Condition

                // first row

                if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                    (IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
                    (IdentifyCellOwner(0, 2) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }

                // second row

                if ((IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 2) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }
                // third row

                if ((IdentifyCellOwner(2, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(2, 1) == CellOwners.Computer) &&
                   (IdentifyCellOwner(2, 2) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }

                // first column

                if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(2, 0) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }

                // second column

                if ((IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                   (IdentifyCellOwner(2, 1) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }

                // third column

                if ((IdentifyCellOwner(0, 2) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 2) == CellOwners.Computer) &&
                   (IdentifyCellOwner(2, 2) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }

                //   '\' diagonal

                if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                   (IdentifyCellOwner(2, 2) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }

                // '/' diagonal

                if ((IdentifyCellOwner(2, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                   (IdentifyCellOwner(0, 2) == CellOwners.Computer))
                {
                    Winner = CellOwners.Computer;
                    return true;
                }


            foreach (var combination in _winningCombinations)
            {
                // combination is a collection of 3 TicTacToe cell references
                var firstCell = combination[0];

                if ((firstCell.CellOwner != CellOwners.Computer) &&
                    (firstCell.CellOwner != CellOwners.Human)) continue;

                if ((firstCell.CellOwner != combination[1].CellOwner) ||
                    (firstCell.CellOwner != combination[2].CellOwner)) continue;

                Winner = firstCell.CellOwner;


                Debug.WriteLine($"Method: CheckForWinner {Winner}");

                return true;
            }

            Debug.WriteLine($"Method: CheckForWinner {Winner}");

            return false;

            }

           public string IdentifyWinner()
            {
                switch (Winner)
                {
                    case CellOwners.Computer:
                        return "Computer";

                    case CellOwners.Human:
                        return PlayerName == "" ? "Unnamed Human" : PlayerName;

                    case CellOwners.Open:
                        return string.Empty;

                    default:
                        return "Error";
                }
            }

        public event CellOwnerChangedHandler CellOwnerChanged;

        public class CellOwnerChangedArgs : EventArgs
        {
            public CellOwnerChangedArgs(int rowID, int colID, CellOwners cellOwner)
            {
                RowID = rowID;
                ColID = colID;
                CellOwner = cellOwner;
                Debug.WriteLine($"Method: CellOwnerChangedArgs {RowID}-{ColID} {CellOwner}");
            }

            public int RowID { get; }
            public int ColID { get; }
            public CellOwners CellOwner { get; }
        }
    }
}
