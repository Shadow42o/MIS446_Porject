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
        [Display(Name = "Outside Party ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OutsidePartyIDNumber { get; set; }

        [Display(Name = "Title")]
        [StringLength(255)]
        public string Title { get; set; }

        [Display(Name = "Address")]
        [StringLength(255)]
        public string Address { get; set; }

        [Display(Name = "City")]
        [StringLength(255)]
        public string City { get; set; }

        [Display(Name = "State")]
        [StringLength(255)]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int? ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientOutsideParty> PatientOutsideParties { get; set; }
    }
}
