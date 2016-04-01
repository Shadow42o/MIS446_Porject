namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [Key]
        [StringLength(10)]
        public string FlightIDNumber { get; set; }

        [StringLength(10)]
        public string fk_PilotID { get; set; }

        [StringLength(10)]
        public string fk_PlaneID { get; set; }

        [StringLength(10)]
        public string fk_PatientID { get; set; }

        [StringLength(10)]
        public string DestinationInformation { get; set; }

        [StringLength(10)]
        public string NumberOfPassengers { get; set; }

        [StringLength(10)]
        public string FlightDuration { get; set; }

        [StringLength(10)]
        public string Distance { get; set; }

        [StringLength(10)]
        public string DateOfFlight { get; set; }

        [StringLength(10)]
        public string TimeOfFlight { get; set; }

        [StringLength(10)]
        public string WeightOfLuggage { get; set; }

        [StringLength(10)]
        public string FuelUsed { get; set; }
    }
}
