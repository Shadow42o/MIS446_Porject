namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            PatientOutsideParties = new HashSet<PatientOutsideParty>();
        }

        [Key]
        [StringLength(10)]
        public string PatientIDNumber { get; set; }

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
        public string SpecialNeeds { get; set; }

        [StringLength(10)]
        public string InsuranceIDNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientOutsideParty> PatientOutsideParties { get; set; }
    }
}
