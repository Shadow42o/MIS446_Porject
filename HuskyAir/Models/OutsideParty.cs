namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutsideParty")]
    public partial class OutsideParty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OutsideParty()
        {
            PatientOutsideParties = new HashSet<PatientOutsideParty>();
        }

        [Key]
        [StringLength(10)]
        public string OutsidePartyIDNumber { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

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
        public string EmailAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientOutsideParty> PatientOutsideParties { get; set; }
    }
}
