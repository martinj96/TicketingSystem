using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Security.Models
{  
    [Table("UserProfile")]
    public class User
    {
        public User()
        {

        }
        public User(string uName, string fName, string lName, string pass)
        {
            UserName = uName;
            FirstName = fName;
            LastName = lName;
            Password = pass;
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}