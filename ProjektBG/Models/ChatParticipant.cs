using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class ChatParticipant   
    {
        [Key]
        public int ChatParticipantId { get; set; }

        [ForeignKey("Chat")]
        public int ChatId { get; set; }

        public int UserId { get; set; }

        }
}
