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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Insurance()
        {
            Patients = new HashSet<Patient>();
        }

        [Key]
        [Display(Name = "Insurance ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsuranceIDNumber { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(255)]
        public string CompanyName { get; set; }

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
        public int? PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EMailAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
