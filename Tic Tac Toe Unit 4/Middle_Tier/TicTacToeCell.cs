using TicTacToe_Interfaces;

namespace Middle_Tier
{
    public class TicTacToeCell : ITicTacToeCell
    {
        public int RowID { get; set; }

        public int ColID { get; set; }

        public CellOwners CellOwner { get; set; } = CellOwners.Open;
    }
}
