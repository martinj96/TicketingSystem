using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Models
{
    public class TicketManager
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public void CreateTicket(TicketCreateModel t)
        {
            TicketModel ticket = new TicketModel();
            ticket.Name = t.Name;
            ticket.Description = t.Description;
            ticket.Message = t.Message;
            ticket.Date = DateTime.UtcNow;
            _db.Tickets.Add(ticket);
            _db.SaveChanges();
        }
        public void CreateComment(int tId, string cContent, int uId)
        {
            Comment comment = new Comment();
            comment.TicketId = tId;
            comment.CommentContent = cContent;
            comment.UserId = uId;
            _db.Comments.Add(comment);
            _db.SaveChanges();
        }

    }
}