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
        private string trim_FirstName = string.Empty;
        private string trim_LastName = string.Empty;
        private string trim_Address = string.Empty;
        private string trim_City = string.Empty;
        private string trim_State = string.Empty;
        private string trim_Email = string.Empty;
        private string trim_Needs = string.Empty;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Flights = new HashSet<Flight>();
            PatientOutsideParties = new HashSet<PatientOutsideParty>();
        }

        [Key]
        [Display(Name = "Patient ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientIDNumber { get; set; }

        [Display(Name = "First Name")]
        [StringLength(255)]
        public string FirstName
        {
            get { return this.trim_FirstName; }
            set { this.trim_FirstName = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Last Name")]
        [StringLength(255)]
        public string LastName
        {
            get { return this.trim_LastName; }
            set { this.trim_LastName = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [Display(Name = "Address")]
        [StringLength(255)]
        public string Address
        {
            get { return this.trim_Address; }
            set { this.trim_Address = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "City")]
        [StringLength(255)]
        public string City
        {
            get { return this.trim_City; }
            set { this.trim_City = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "State")]
        [StringLength(255)]
        public string State
        {
            get { return this.trim_State; }
            set { this.trim_State = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Zip Code")]
        public int? ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        public int? PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EMailAddress
        {
            get { return this.trim_Email; }
            set { this.trim_Email = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Special Needs")]
        [StringLength(255)]
        public string SpecialNeeds
        {
            get { return this.trim_Needs; }
            set { this.trim_Needs = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Insurance ID")]
        public int? fk_InsuranceIDNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }

        public virtual Insurance Insurance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientOutsideParty> PatientOutsideParties { get; set; }
    }
}
