using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalAssessmentWheezlzy.Models
{
    public class Car
    {


        [Key]
        public int CarId { get; set; }
        public int CarYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Submodel { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Buyer> Buyers { get; set; }
        public virtual ICollection<StatusHistory> StatusHistory { get; set; }
    }
}
