using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class Advertisement : DateTimeInfo
    {
        [Key]
        public int AdvertisementId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public string Message { get; set; }

        public virtual ICollection<AdvertisementComment> AdvertisementComments { get; set; }
        public virtual ICollection<AdvertisementRating> AdvertisementRatings { get; set; }



    }
}
