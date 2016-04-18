namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PilotDate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? fk_PilotIDNumber { get; set; }

        [StringLength(20)]
        public string fk_PlaneIDNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDateAvailable { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDateAvailable { get; set; }

        public virtual Pilot Pilot { get; set; }

        public virtual Plane Plane { get; set; }
    }
}
