using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class GameCategory
    {
        [Key]
        public int GameCategoryId { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public string Name { get; set; }

        public int ParentGameId { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
