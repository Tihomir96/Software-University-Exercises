
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace P03_FootballBetting.Data.Models
{
    public class Player
    {
        public Player()
        {
            this.PlayerStatistics = new List<PlayerStatistic>();
        }
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int SquadNumber { get; set; }
        public int TeamId { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public bool IsInjured { get; set; }

        public Team Team { get; set; }
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; }

    }
}
