using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class Chat
    {
        [Key]
        public int ChatId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string ChatMessage { get; set; }

        public int ParrentChatId { get; set; }

        public DateTime ChatMessageDate { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<ChatParticipant> ChatParticipants { get; set; }
    }
}
