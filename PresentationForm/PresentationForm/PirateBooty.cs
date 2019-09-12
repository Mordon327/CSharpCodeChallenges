using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationForm
{
    class PirateBooty
    {
        public string description = "At the end of a successfull raid the winnings are divided up. \n 10% goes to the captain, 20% into repairs and \n provisions and the rest are divided up among the sailers. \n Any extras go to the first mate and captain evenly. Any remainder go to the ship.";
        public double CAPTAIN_PERCENT = .2;
        public double SHIP_PERCENT = .3;

        public int CaptainEarnings { get; set; }
        public int FirstMateEarnings { get; set; }
        public int ShipEarnings { get; set; }
        public int PirateEarnings { get; set; }
        public int NumberOfPirates { get; set; }
        public int NumberOfCoins { get; set; }

        public void CalculateEarnings ()
        {
            if (NumberOfCoins == 0 || NumberOfPirates == 0)
            {
                
            }
            else
            {
                //captain = 4 + 2 from bonus, ship = 6, numPirates = 6, firstmate bonus = 2, numCoins = 20 CoinPerPirate = 1
            }
        }
    }
}
