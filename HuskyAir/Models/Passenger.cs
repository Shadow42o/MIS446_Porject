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
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(255)]
        public string LastName { get; set; }

        [Display(Name = "Date")]
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
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string EMailAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPassenger> FlightPassengers { get; set; }
    }
}
