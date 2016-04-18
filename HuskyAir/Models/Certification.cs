namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Certification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int fk_PilotIDNumber { get; set; }

        [Column("Certification")]
        [StringLength(20)]
        public string Certification1 { get; set; }

        public virtual Pilot Pilot { get; set; }
    }
}
