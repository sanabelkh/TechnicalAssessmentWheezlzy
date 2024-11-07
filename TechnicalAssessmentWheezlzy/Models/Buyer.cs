using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalAssessmentWheezlzy.Models
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        public int CarId { get; set; }
        public decimal Quote { get; set; }
        public bool IsCurrentBuyer { get; set; }

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }



    }
}
