using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class EventParticipant
    {
        [Key]
        public int EventParticipantId { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        public int UserId { get; set; }

        public string Status { get; set; }
    }
}
