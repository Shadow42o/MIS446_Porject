namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FlightPassenger")]
    public partial class FlightPassenger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int fk_FlightID { get; set; }

        public int? fk_PassengerID { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual Passenger Passenger { get; set; }
    }
}
