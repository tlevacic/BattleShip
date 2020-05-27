using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    interface ITargetSelect
    {
        Square NextTarget(ShootingTactics tactics);
    }
}
