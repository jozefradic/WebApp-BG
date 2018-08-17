using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{ 
    public class GameRating : DateTimeInfo
    {
        [Key]
        public int GameRatingId { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public int RatedUserId { get; set; }

        public int Rating { get; set; }

        public string GameRatingMessage { get; set; }
               
    }
}
