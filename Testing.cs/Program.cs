using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Oom.Battleship.Model;

namespace Testing.cs
{
    class Program
    {
        private readonly Fleet fleet;
        private readonly Gunner gunner;
        private readonly int rows=10;
        private readonly int columns=10;
        int[] shipLengths = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };

        private Program()
        {
            Shipwright sw = new Shipwright(rows, columns);
            fleet = sw.CreateFleet(shipLengths);
            gunner = new Gunner(rows, columns, shipLengths);
        }

        public HitResult ShootNextTarget(bool testing)
        {
            //Shoot next target
            //if testing is true then GetAvailablePlacements is regular, else it gets 1 as parameter.
            Square s= gunner.NextTarget(testing);
            return fleet.Hit(s);
            //No need for changing tactics cuz we will stop after first square is hit
            //gunner.ProcessHitResult(result);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int numberOfAttempts = 10;

            //FIRST TRY
            int suma = 0;
            for(int i=0; i < numberOfAttempts; i++)
            {
                int cnt = 1;
                while (true)
                {
                    HitResult result = p.ShootNextTarget(false);
                    if (result == HitResult.Hit)
                        break;
                    cnt++;
                }
                Console.WriteLine("HITTED IN " + cnt + " attempts");
                suma += cnt;
            }
            Console.WriteLine("FIRST AVERAGE : " + suma/numberOfAttempts);


            //SECODND TRY
            suma = 0;
            for (int i = 0; i < numberOfAttempts; i++)
            {
                int cnt = 1;
                while (true)
                {
                    HitResult result = p.ShootNextTarget(true);
                    if (result == HitResult.Hit)
                        break;
                    cnt++;
                }
                Console.WriteLine("HITTED IN " + cnt + " attempts");
                suma += cnt;
            }
            Console.WriteLine("SECOND AVERAGE : " + suma / numberOfAttempts);
        }
    }
}
