using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class UserRating : DateTimeInfo
    {
        [Key]
        public int UserRatingId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public int RatedUserId { get; set; }

        public int Rating { get; set; }

        public string MessageUserRating { get; set; }

        public virtual User User { get; set; }

    }
}
