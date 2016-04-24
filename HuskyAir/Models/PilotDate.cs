namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PilotDate
    {
        [Key]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Pilot ID")]
        public int? fk_PilotIDNumber { get; set; }

        [Display(Name = "Plane ID")]
        [StringLength(255)]
        public string fk_PlaneIDNumber { get; set; }

        [Display(Name = "Start Availibility")]
        [Column(TypeName = "date")]
        public DateTime? StartDateAvailable { get; set; }

        [Display(Name = "End Availability")]
        [Column(TypeName = "date")]
        public DateTime? EndDateAvailable { get; set; }

        public virtual Pilot Pilot { get; set; }

        public virtual Plane Plane { get; set; }
    }
}
