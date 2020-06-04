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
            var result = fleet.Hit(s);
            gunner.ProcessHitResult(result);
            return result;
        }

        static void Main(string[] args)
        {
            Program p;
            int numberOfAttempts = 1000;

            //FIRST TRY
            int sunkenShips = 0;

            int[] sumOfSinkingShips = new int[] {0,0,0,0,0,0,0,0,0 };

            for (int i=0; i < numberOfAttempts; i++)
            {
                p = new Program();
                int firstTimeHit = 0;
                int cnt = 1;
                List<int> sunkenShipsCnt = new List<int>();
                // List will be: FirstShipIsSunked SecondShipIsHit SecondShipIsSunked ThirdShipIsHit .... 
                while (sunkenShips < 10)
                {
                    HitResult result = p.ShootNextTarget(false);
                    if (result == HitResult.Hit && firstTimeHit==0) //How many times till first hit of some ship
                        firstTimeHit = cnt;
                    if (result == HitResult.Sunken)
                    {
                        if(sunkenShips > 1)
                            sunkenShipsCnt.Add(firstTimeHit);
                        sunkenShipsCnt.Add(cnt);                     //How many times till ship is sunked
                        sunkenShips++;
                        firstTimeHit = 0;
                    }
                    cnt++;
                }

                for (int j = 0, k=0; j < sumOfSinkingShips.Count(); j++, k+=2)
                {
                    int result = sunkenShipsCnt[k + 1] - sunkenShipsCnt[k];
                    sumOfSinkingShips[j] = sumOfSinkingShips[j] + result;
                }

                //Console.WriteLine(String.Join(", ", sunkenShipsCnt));     UNCOMMENT TO SEE DATA IN ARRAY WHEN SHIPS IS HIT; SHIP IS SUNKED
                sunkenShips = 0;
            }
            //After all data is stored in array, need to calculate average hit for every ship
            for(int i=0; i< sumOfSinkingShips.Count(); i++)
            {
                if (i < 9)
                {
                    Console.WriteLine(i + 1 + " ship hit : " + (i+2) + " sunked : Average is --->>> " + sumOfSinkingShips[i] / numberOfAttempts);
                }
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //SECOND TRY- all code is same, just another param is sent to ShootNextTarget
            //FIRST TRY
            sunkenShips = 0;

            sumOfSinkingShips = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < numberOfAttempts; i++)
            {
                p = new Program();
                int firstTimeHit = 0;
                int cnt = 1;
                List<int> sunkenShipsCnt = new List<int>();
                // List will be: FirstShipIsSunked SecondShipIsHit SecondShipIsSunked ThirdShipIsHit .... 
                while (sunkenShips < 10)
                {
                    HitResult result = p.ShootNextTarget(true);
                    if (result == HitResult.Hit && firstTimeHit == 0) //How many times till first hit of some ship
                        firstTimeHit = cnt;
                    if (result == HitResult.Sunken)
                    {
                        if (sunkenShips > 1)
                            sunkenShipsCnt.Add(firstTimeHit);
                        sunkenShipsCnt.Add(cnt);                     //How many times till ship is sunked
                        sunkenShips++;
                        firstTimeHit = 0;
                    }
                    cnt++;
                }

                for (int j = 0, k = 0; j < sumOfSinkingShips.Count(); j++, k += 2)
                {
                    int result = sunkenShipsCnt[k + 1] - sunkenShipsCnt[k];
                    sumOfSinkingShips[j] = sumOfSinkingShips[j] + result;
                }

                //Console.WriteLine(String.Join(", ", sunkenShipsCnt));     UNCOMMENT TO SEE DATA IN ARRAY WHEN SHIPS IS HIT; SHIP IS SUNKED
                sunkenShips = 0;
            }
            //After all data is stored in array, need to calculate average hit for every ship
            for (int i = 0; i < sumOfSinkingShips.Count(); i++)
            {
                if (i < 9)
                {
                    Console.WriteLine(i + 1 + " ship hit : " + (i + 2) + " sunked : Average is --->>> " + sumOfSinkingShips[i] / numberOfAttempts);
                }
            }











        }
    }
}
