using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class OwnedGame
    {
        [Key]
        public int OwnedGameId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public string GameName { get; set; }

        public int GameId { get; set; }

        public DateTime PurchaseYear { get; set; }
    }
}
