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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? fk_PatientIDNumber { get; set; }

        public int fk_OutsidePartyIDNumber { get; set; }

        public virtual OutsideParty OutsideParty { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
