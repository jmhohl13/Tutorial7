using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial7
{
    public class Chessboard
    {
        Dictionary<Tuple<char,int>, Pawn> pawns = new Dictionary<Tuple<char, int>, Pawn>();


        public void placePiece(Pawn p, Tuple<char,int> loc )
        {
            pawns.Add(loc,p);
        }

        public void movePiece(Tuple<char,int> old, Tuple<char,int> next)
        {
            Pawn temp = pawns[old];
            pawns.Remove(old);
            pawns.Add(next, temp);
        }
    }
}
