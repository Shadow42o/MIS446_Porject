namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAccount
    {
        private string trim_FirstName = string.Empty;
        private string trim_LastName = string.Empty;
        private string trim_Email = string.Empty;
        private string trim_Username = string.Empty;
        private string trim_Password = string.Empty;
        private string trim_ConfirmPass = string.Empty;


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName
        {
            get { return this.trim_FirstName; }
            set { this.trim_FirstName = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Required]
        [StringLength(255)]
        public string LastName
        {
            get { return this.trim_LastName; }
            set { this.trim_LastName = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Required]
        [StringLength(255)]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Please Enter a Correct Email Address")]
        public string Email
        {
            get { return this.trim_Email; }
            set { this.trim_Email = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Required]
        [StringLength(255)]
        public string Username
        {
            get { return this.trim_Username; }
            set { this.trim_Username = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        public string Password
        {
            get { return this.trim_Password; }
            set { this.trim_Password = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword
        {
            get { return this.trim_ConfirmPass; }
            set { this.trim_ConfirmPass = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [StringLength(255)]
        public string Role { get; set; }
    }

    public enum RoleList
    {
        Admin,
        Pilot,
        OutsideParty,
        User
    }
}
