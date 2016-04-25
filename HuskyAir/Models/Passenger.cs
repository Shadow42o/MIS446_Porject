namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Passenger")]
    public partial class Passenger
    {
        private string trim_FirstName = string.Empty;
        private string trim_LastNight = string.Empty;
        private string trim_Address = string.Empty;
        private string trim_City = string.Empty;
        private string trim_State = string.Empty;
        private string trim_Phone = string.Empty;
        private string trim_Email = string.Empty;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passenger()
        {
            FlightPassengers = new HashSet<FlightPassenger>();
        }

        [Key]
        [Display(Name = "Passenger ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PassengerID { get; set; }

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
            get { return this.trim_LastNight; }
            set { this.trim_LastNight = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Date")]
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
        [StringLength(255)]
        public string PhoneNumber
        {
            get { return this.trim_Phone; }
            set { this.trim_Phone = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EMailAddress
        {
            get { return this.trim_Email; }
            set { this.trim_Email = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPassenger> FlightPassengers { get; set; }
    }
}
