using ProjektBG.Domain.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class QuestionAnswer : DateTimeInfo
    {
        [Key]
        public int QuestionAnswerId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string MessageQA { get; set; }

        public int ParrentQAID { get; set; }

    }
}
