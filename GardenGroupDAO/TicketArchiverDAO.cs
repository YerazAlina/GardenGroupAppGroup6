using System;
using System.Collections.Generic;
using System.Text;
using GardenGroupModel;
using GardenGroupDAO;
using MongoDB.Bson;
namespace GardenGroupDAL
{
    public class TicketArchiverDAO : BaseDAO
    {

        public void TicketArchiver(Ticket ticket)
        {
            db.TicketArchiver(ticket);
        }

        public List<Ticket> ReadArchivedTicketAll()
        {
            return db.ReadAllArchivedTickets();
        }

        public void RemoveArchivedTicket(ObjectId ticket)
        {
           db.RemoveArchivedTicket(ticket);
        }

    }
}
