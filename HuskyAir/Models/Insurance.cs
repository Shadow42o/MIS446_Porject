namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Insurance")]
    public partial class Insurance
    {
        [Key]
        [StringLength(10)]
        public string InsuranceIDNumber { get; set; }

        [StringLength(10)]
        public string CompanyName { get; set; }

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
    }
}
