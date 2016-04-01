namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PilotDate
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string fk_PilotIDNumber { get; set; }

        [StringLength(10)]
        public string fk_PlaneIDNumber { get; set; }

        [StringLength(10)]
        public string StartDateAvailable { get; set; }

        [StringLength(10)]
        public string EndDateAvailable { get; set; }
    }
}
