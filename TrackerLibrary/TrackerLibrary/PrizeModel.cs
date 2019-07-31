using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Numerical value of place.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// String value of place. This can be: First Place, Champion, Winner, etc.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Cash value for prize.
        /// </summary>
        public double PrizeAmount { get; set; }

        /// <summary>
        /// Percent won of combined prizes.
        /// </summary>
        public double Percentage { get; set; }

    }
}
