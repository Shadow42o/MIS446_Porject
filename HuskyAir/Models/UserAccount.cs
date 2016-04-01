namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAccount
    {
        [Key]
        [StringLength(10)]
        public string UserId { get; set; }

        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Username { get; set; }

        [StringLength(10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(10)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
