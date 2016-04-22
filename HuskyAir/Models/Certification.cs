namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Certification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int fk_PilotIDNumber { get; set; }

        [Column("Certification")]
        [StringLength(255)]
        public string Certification1 { get; set; }

        public virtual Pilot Pilot { get; set; }
    }
}
