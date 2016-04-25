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
        private string trim_Title = string.Empty;
        private string trim_Address = string.Empty;
        private string trim_City = string.Empty;
        private string trim_State = string.Empty;
        private string trim_Phone = string.Empty;
        private string trim_Email = string.Empty;

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
        public string Title
        {
            get { return this.trim_Title; }
            set { this.trim_Title = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
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
        public int? ZipCode{ get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(10)]
        public string PhoneNumber
        {
            get { return this.trim_Phone; }
            set { this.trim_Phone = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EmailAddress
        {
            get { return this.trim_Email; }
            set { this.trim_Email = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientOutsideParty> PatientOutsideParties { get; set; }
    }
}
