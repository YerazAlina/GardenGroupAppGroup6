using System;
using System.Collections.Generic;
using System.Text;
using GardenGroupModel;
using GardenGroupDAO;
using MongoDB.Bson;

namespace GardenGroupDAL
{
    public class TicketDAO : BaseDAO
    {
        public List<Ticket> ReadTicketAll()
        {
            return db.TicketCollection();
        }

        public void ChangeTicketUser(Ticket ticket) 
        {
            db.ChangeTicketUser();
        }
        
        public List<Ticket> ReadAllTickets()
        {
            return db.ReadAllTickets();
        }

        public void AddTicket(Ticket ticket)
        {
            db.AddTicket(ticket);
        }

        public void RemoveTicket(ObjectId ticket)
        {
            db.RemoveTicket(ticket);
        }


    }
}
