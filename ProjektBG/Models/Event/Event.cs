using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class Event : DateTimeInfo
    {
        [Key]
        public int EventId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Message { get; set; }

        public DateTime DateOfEvent { get; set; }

        public virtual ICollection<EventComment> EventComments { get; set; }
        public virtual ICollection<EventParticipant> EventParticipants { get; set; }
        public virtual ICollection<EventRating> EventRatings { get; set; }


    }
}
