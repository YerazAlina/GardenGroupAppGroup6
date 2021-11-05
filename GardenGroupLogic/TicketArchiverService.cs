using GardenGroupDAL;
using GardenGroupModel;
using MongoDB.Bson;
using System.Collections.Generic;



namespace GardenGroupLogic
{
    public class TicketArchiverService
    {
        TicketArchiverDAO ticketArchiverDAO = new TicketArchiverDAO();

        public void TicketArchiver(Ticket ticket)
        {
            ticketArchiverDAO.TicketArchiver(ticket);
        }

        public List<Ticket> GetArchivedTicketCollection()
        {
            return ticketArchiverDAO.ReadArchivedTicketAll();
        }

        public void RemoveArchivedTicket(ObjectId ticket)
        {
            ticketArchiverDAO.RemoveArchivedTicket(ticket);
        }
    }
}
