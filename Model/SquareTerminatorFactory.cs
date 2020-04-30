using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public enum ShipAdjoining
    {
        None,
        Corners
    }

    public static class SquareTerminatorFactory
    {
        public static ISquareTerminator Create(ShipAdjoining adjoining,int rows,int columns)
        {
            switch(adjoining)
            {
                case ShipAdjoining.None:
                    return new SquareTerminator(rows, columns);
                case ShipAdjoining.Corners:
                     return null;
                default:
                    Debug.Assert(false);
                    return null;
            }
        }


    }
}
