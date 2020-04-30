using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class RulesSingelton
    {
        private static readonly RulesSingelton instance = new RulesSingelton();

        private RulesSingelton()
        {
            Rows = 10;
            Columns = 10;
            ShipLengths = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
        }


        public static RulesSingelton Instance { get { return instance; } }

        public readonly int Rows;
        public readonly int Columns;
        public readonly int[] ShipLengths;
    }
}
