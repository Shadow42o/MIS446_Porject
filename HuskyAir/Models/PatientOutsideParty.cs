namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PatientOutsideParty")]
    public partial class PatientOutsideParty
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string fk_PatientIDNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string fk_OutsidePartyIDNumber { get; set; }

        public virtual OutsideParty OutsideParty { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
