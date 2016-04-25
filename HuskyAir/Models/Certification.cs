namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Certification
    {
        private string trim_Certification = string.Empty;

        [Key]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a valid pilot id")]
        [Display(Name = "Pilot ID")]
        public int? fk_PilotIDNumber { get; set; }

        [Column("Certification")]
        [Display(Name = "Certification")]
        [StringLength(255)]
        public string Certification1
        {
            get { return this.trim_Certification; }
            set { this.trim_Certification = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [ForeignKey("PilotIDNumber")]
        public virtual Pilot Pilot { get; set; }
    }
}
