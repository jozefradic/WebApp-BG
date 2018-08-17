using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBG.Domain.Models
{
    public class SearchHistory
    {
        [Key]        
        public int SearchHistoryId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public DateTime SearchHistoryDate { get; set; }

        public string SearchType { get; set; }

        public string SearchText { get; set; }
    }
}
