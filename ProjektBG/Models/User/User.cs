using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class User : DateTimeInfo
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
        public virtual ICollection<Event> Events { get; set; }        
        public virtual ICollection<UserRating> UserRatings { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<OwnedGame> OwnedGames { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual ICollection<SearchHistory> SearchHistories { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
