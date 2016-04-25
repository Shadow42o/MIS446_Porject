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
        private string trim_CompanyName = string.Empty;
        private string trim_Address = string.Empty;
        private string trim_City = string.Empty;
        private string trim_State = string.Empty;
        private string trim_Email = string.Empty;

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
        public string CompanyName
        {
            get { return this.trim_CompanyName; }
            set { this.trim_CompanyName = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

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
        [DataType(DataType.PhoneNumber)]
        public int? PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EMailAddress
        {
            get { return this.trim_Email; }
            set { this.trim_Email = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
