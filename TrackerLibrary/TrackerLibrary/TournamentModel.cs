using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TournamentModel
    {
        /// <summary>
        /// Name of tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Cost to enter.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams entered.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Complete tournament bracket.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
