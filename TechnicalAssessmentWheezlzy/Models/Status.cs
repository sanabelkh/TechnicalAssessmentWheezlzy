using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TechnicalAssessmentWheezlzy.Models
{
    public class Status
    {

        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<StatusHistory> StatusHistory { get; set; }
    }
}
