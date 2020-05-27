using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class RandomShooting : ITargetSelect
    {
        public RandomShooting(Grid evidenceGrid, List<int> shipsToShoot)
        {
            this.evidenceGrid = evidenceGrid;
            this.shipsToShoot = shipsToShoot;
        }

        public Square NextTarget(int shipLength)
        {
            int shipLength = shipsToShoot[0];
            var placements = evidenceGrid.GetAvailablePlacments(shipLength);
            // create simple array of sqaures from arrays of arrays
            var allCandidates = placements.SelectMany(seq => seq);
            // create groups with individual squares
            var groups = allCandidates.GroupBy(sq => sq);
            // find the number of squares in largest group
            var maxCount = groups.Max(g => g.Count());
            // filter only froups that have maxCount elements
            var largestGroups = groups.Where(g => g.Count() == maxCount);
            // fetch keys from each group (i.e. square that represents the group)
            var mostCommon = largestGroups.Select(g => g.Key);
            if (mostCommon.Count() == 1)
                return mostCommon.First();
            int index = random.Next(0, mostCommon.Count());
            return mostCommon.ElementAt(index);
        }
        private Random random = new Random();
        private readonly Grid evidenceGrid;
        private readonly List<int> shipsToShoot;
    }
}
