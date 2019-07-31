using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// List of matchups.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winner of the round.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Round number. First round, second round, etc.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
