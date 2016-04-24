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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pilot()
        {
            Certifications = new HashSet<Certification>();
            Flights = new HashSet<Flight>();
            PilotDates = new HashSet<PilotDate>();
            Planes = new HashSet<Plane>();
        }

        [Key]
        [Display(Name = "Pilot ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PilotIDNumber { get; set; }

        [Display(Name = "First Name")]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(255)]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

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
        [StringLength(255)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EMailAddress { get; set; }

        [Display(Name = "Total Hours")]
        public int? TotalHours { get; set; }

        [Display(Name = "Rating")]
        public int? AverageRating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certification> Certifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PilotDate> PilotDates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plane> Planes { get; set; }
    }
}
