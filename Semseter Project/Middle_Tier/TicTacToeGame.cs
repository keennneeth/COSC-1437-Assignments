using System;
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
            for (var rowNo = 0; rowNo < 5; rowNo++)
                for (var colNo = 0; colNo < 5; colNo++)
                {
                    _ticTacToeCells.Add(new TicTacToeCell
                    {
                        RowID = rowNo,
                        ColID = colNo
                    });
                }




            _goodNextMove = new Collection<TicTacToeCell>()
                 {
               _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==4),

                };

            _winningCombinations = new Collection<Collection<TicTacToeCell>>()
            {
                new Collection<TicTacToeCell>() // loading the first row
                {
                    // the reference to these objects is in the collection - not new ones!
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>() // loading the second row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()  // third row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>() // fourth row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==4)

                },
                new Collection<TicTacToeCell>() // fifth row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4)

                },

                new Collection<TicTacToeCell>() // loading the first column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0)

                },
                new Collection<TicTacToeCell>() // second column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==1)
                },
                new Collection<TicTacToeCell>() // third column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // fourth column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==3)
                },
                  new Collection<TicTacToeCell>() // fifth column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4)
                },




                new Collection<TicTacToeCell>() // loading the first diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4),

                },
                new Collection<TicTacToeCell>() // loading final diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0)
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
            bool SearchForPlayerReadyToWin(CellOwners checkingCellOwner)
            {
                foreach (var combination in _winningCombinations)
                    foreach (var targetCell in combination.Where(tttc => tttc.CellOwner == CellOwners.Open))
                    {
                        if (combination
                            .Count(tttc =>
                                tttc != targetCell &&
                                tttc.CellOwner != checkingCellOwner) > 0)
                            break;

                        AssignCellOwner(targetCell.RowID, targetCell.ColID, CellOwners.Computer);
                        return true;
                    }

                return false;
            }

            if (_ticTacToeCells.Count == 0) return;

            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;


            if (SearchForPlayerReadyToWin(CellOwners.Computer)) return;
            if (SearchForPlayerReadyToWin(CellOwners.Human)) return;

            var winningCell = _goodNextMove
                .FirstOrDefault(tttc => tttc.CellOwner == CellOwners.Open);
            if (winningCell != null)
                AssignCellOwner(winningCell.RowID, winningCell.ColID, CellOwners.Computer);
        }
    

        /*
         * ProfReynolds1204
         * this is a rather advanced solution but you will learn if you study it.

        public void AutoPlayComputer()
        {
            bool SearchForPlayerReadyToWin(CellOwners checkingCellOwner)
            {
                foreach (var combination in _winningCombinations)
                foreach (var targetCell in combination.Where(tttc => tttc.CellOwner == CellOwners.Open))
                {
                    if (combination
                        .Count(tttc =>
                            tttc != targetCell &&
                            tttc.CellOwner != checkingCellOwner) > 0)
                        break;

                    AssignCellOwner(targetCell.RowID, targetCell.ColID, CellOwners.Computer);
                    return true;
                }

                return false;
            }

            if (_ticTacToeCells.Count == 0) return;

            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;


            if (SearchForPlayerReadyToWin(CellOwners.Computer)) return;
            if (SearchForPlayerReadyToWin(CellOwners.Human)) return;

            var winningCell = _goodNextMove
                .FirstOrDefault(tttc => tttc.CellOwner == CellOwners.Open);
            if (winningCell != null)
                AssignCellOwner(winningCell.RowID, winningCell.ColID, CellOwners.Computer);
        }

        */


        public bool CheckForWinner()

            {
                // first row

                if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                    (IdentifyCellOwner(0, 1) == CellOwners.Human) &&
                    (IdentifyCellOwner(0, 2) == CellOwners.Human) &&
                    (IdentifyCellOwner(0, 3) == CellOwners.Human) &&
                    (IdentifyCellOwner(0, 4) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }

                // second row

                if ((IdentifyCellOwner(1, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 2) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 3) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 4) == CellOwners.Human))
                {
                    Winner = CellOwners.Human;
                    return true;
                }
                // third row

                if ((IdentifyCellOwner(2, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 3) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 4) == CellOwners.Human))

                {
                    Winner = CellOwners.Human;
                    return true;
                }
                 // fourth row

                if ((IdentifyCellOwner(3, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(3, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(3, 2) == CellOwners.Human) &&
                   (IdentifyCellOwner(3, 3) == CellOwners.Human) &&
                   (IdentifyCellOwner(3, 4) == CellOwners.Human))

                {
                    Winner = CellOwners.Human;
                    return true;
                }
                   // fifth row

                if ((IdentifyCellOwner(4, 0) == CellOwners.Human) &&
               (IdentifyCellOwner(4, 1) == CellOwners.Human) &&
               (IdentifyCellOwner(4, 2) == CellOwners.Human) &&
               (IdentifyCellOwner(4, 3) == CellOwners.Human) &&
               (IdentifyCellOwner(4, 4) == CellOwners.Human))

               {
                Winner = CellOwners.Human;
                return true;
               }



            // first column

            if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 0) == CellOwners.Human)&&
                   (IdentifyCellOwner(3, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(4, 0) == CellOwners.Human))
            {
                    Winner = CellOwners.Human;
                    return true;
                }

                // second column

                if ((IdentifyCellOwner(0, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(2, 1) == CellOwners.Human)&&
                    (IdentifyCellOwner(3, 1) == CellOwners.Human) &&
                   (IdentifyCellOwner(4, 1) == CellOwners.Human))
            {
                    Winner = CellOwners.Human;
                    return true;
                }

                // third column

                if ((IdentifyCellOwner(0, 2) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 2) == CellOwners.Human) &&
                   (IdentifyCellOwner(3, 2) == CellOwners.Human) &&
                   (IdentifyCellOwner(4, 2) == CellOwners.Human))
            {
                    Winner = CellOwners.Human;
                    return true;
                }

            // fourth column

            if ((IdentifyCellOwner(0, 3) == CellOwners.Human) &&
               (IdentifyCellOwner(1, 3) == CellOwners.Human) &&
               (IdentifyCellOwner(2, 3) == CellOwners.Human) &&
               (IdentifyCellOwner(3, 3) == CellOwners.Human) &&
               (IdentifyCellOwner(4, 3) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // fifth column

            if ((IdentifyCellOwner(0, 4) == CellOwners.Human) &&
               (IdentifyCellOwner(1, 4) == CellOwners.Human) &&
               (IdentifyCellOwner(2, 4) == CellOwners.Human) &&
               (IdentifyCellOwner(3, 4) == CellOwners.Human) &&
               (IdentifyCellOwner(4, 4) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            //   '\' diagonal

            if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                     (IdentifyCellOwner(3, 3) == CellOwners.Human) &&
                   (IdentifyCellOwner(4, 4) == CellOwners.Human))


                {
                    Winner = CellOwners.Human;
                    return true;
                }

                // '/' diagonal

                if ((IdentifyCellOwner(4, 0) == CellOwners.Human) &&
                   (IdentifyCellOwner(3, 1) == CellOwners.Human) &&
 
                   (IdentifyCellOwner(1, 3) == CellOwners.Human) &&
                   (IdentifyCellOwner(0, 4) == CellOwners.Human))
            {
                    Winner = CellOwners.Human;
                    return true;
                }



            // Computer Winning Condition
            // first row


            if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
            (IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
            (IdentifyCellOwner(0, 2) == CellOwners.Computer) &&
            (IdentifyCellOwner(0, 3) == CellOwners.Computer) &&
            (IdentifyCellOwner(0, 4) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // second row

            if ((IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 2) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 4) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }
            // third row

            if ((IdentifyCellOwner(2, 0) == CellOwners.Computer) &&
               (IdentifyCellOwner(2, 1) == CellOwners.Computer) &&
               (IdentifyCellOwner(2, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(2, 4) == CellOwners.Computer))

            {
                Winner = CellOwners.Computer;
                return true;
            }
            // fourth row

            if ((IdentifyCellOwner(3, 0) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 1) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 2) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 4) == CellOwners.Computer))

            {
                Winner = CellOwners.Computer;
                return true;
            }
            // fifth row

            if ((IdentifyCellOwner(4, 0) == CellOwners.Computer) &&
           (IdentifyCellOwner(4, 1) == CellOwners.Computer) &&
           (IdentifyCellOwner(4, 2) == CellOwners.Computer) &&
           (IdentifyCellOwner(4, 3) == CellOwners.Computer) &&
           (IdentifyCellOwner(4, 4) == CellOwners.Computer))

            {
                Winner = CellOwners.Computer;
                return true;
            }



            // first column

            if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(2, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(3, 0) == CellOwners.Computer) &&
                   (IdentifyCellOwner(4, 0) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // second column

            if ((IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
               (IdentifyCellOwner(2, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(3, 1) == CellOwners.Computer) &&
               (IdentifyCellOwner(4, 1) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // third column

            if ((IdentifyCellOwner(0, 2) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 2) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 2) == CellOwners.Computer) &&
               (IdentifyCellOwner(4, 2) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // fourth column

            if ((IdentifyCellOwner(0, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(2, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(4, 3) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // fifth column

            if ((IdentifyCellOwner(0, 4) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 4) == CellOwners.Computer) &&
               (IdentifyCellOwner(2, 4) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 4) == CellOwners.Computer) &&
               (IdentifyCellOwner(4, 4) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            //   '\' diagonal

            if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(3, 3) == CellOwners.Computer) &&
                (IdentifyCellOwner(4, 4) == CellOwners.Computer))


            {
                Winner = CellOwners.Computer;
                return true;
            }

            // '/' diagonal

            if ((IdentifyCellOwner(4, 0) == CellOwners.Computer) &&
               (IdentifyCellOwner(3, 1) == CellOwners.Computer) &&
               (IdentifyCellOwner(1, 3) == CellOwners.Computer) &&
               (IdentifyCellOwner(0, 4) == CellOwners.Computer))
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


                if (combination.Any(tttc => tttc.CellOwner != firstCell.CellOwner))
                    continue;

                Winner = firstCell.CellOwner;
            }

            /*
             * ProfReynolds1204
             * The above is complicated due to the combinations being 4 or 5
             * replace the above with this
             *
            if (combination.Any(tttc => tttc.CellOwner != firstCell.CellOwner))
                continue;

            Winner = firstCell.CellOwner;
             *
             */

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
