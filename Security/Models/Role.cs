using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Security.Models
{
    public class Role
    {
        public Role()
        {

        }
        public Role(string name)
        {
            Name = name;
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}