using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        public string Name { get; set; }

        public string Rating { get; set; }

        public int CategoryId { get; set; }

        public int NumberOfPlayer { get; set; }

        public int PlayTime { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
        public virtual ICollection<GameCategory> GameCategories { get; set; }
        public virtual ICollection<GameRating> GameRatings { get; set; }

    }
}
