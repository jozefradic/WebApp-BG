using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class UserProfile
    {
        [Key]
        public int UserProfileId { get; set; }

        [ForeignKey("User")]     
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public int PhoneNumber { get; set; }

        public virtual User User { get; set; }

    }
}
