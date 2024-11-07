using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TechnicalAssessmentWheezlzy.Models
{
    public class StatusHistory
    {
        [Key]
        public int HistoryId { get; set; }
        public int CarId { get; set; }
        public int StatusId { get; set; }
        public DateTime StatusDate { get; set; }
        public string ChangedBy { get; set; }

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
    }
}
