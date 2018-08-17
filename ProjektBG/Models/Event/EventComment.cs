using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class EventComment : DateTimeInfo
    {
        [Key]
        public int EventCommentId { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

    }
}
