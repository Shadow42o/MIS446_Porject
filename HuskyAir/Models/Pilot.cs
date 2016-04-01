namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pilot")]
    public partial class Pilot
    {
        [Key]
        [StringLength(10)]
        public string PilotIDNumber { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string DOB { get; set; }

        [StringLength(10)]
        public string Address { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(10)]
        public string EMailAddress { get; set; }

        [StringLength(10)]
        public string TotalHours { get; set; }

        [StringLength(10)]
        public string AverageRating { get; set; }
    }
}
