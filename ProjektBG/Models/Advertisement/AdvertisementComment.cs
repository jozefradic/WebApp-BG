using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class AdvertisementComment : DateTimeInfo
    {
        [Key]
        public int AdvertisementCommentId { get; set; }

        [ForeignKey("Advertisement")]
        public int AdvertisementId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string AdvertisementCommentMessage { get; set; }
    }
}
