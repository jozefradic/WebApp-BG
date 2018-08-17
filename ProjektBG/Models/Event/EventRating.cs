using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class EventRating : DateTimeInfo
    {
        [Key]
        public int EventRatingId { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        public float EventRatingNumber { get; set; }

        public string EventRatingMessage { get; set; }

    }

}
