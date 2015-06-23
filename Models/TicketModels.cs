using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Models
{
    public class TicketModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
    public class TicketCreateModel
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Message { get; set; }
    }
    public class TicketViewModel
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
    public class Comment
	{
		[Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        [Required]
        public int TicketId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string CommentContent { get; set; }
	}
    public class CommentViewModel{
        [Key]
        public int TicketId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}