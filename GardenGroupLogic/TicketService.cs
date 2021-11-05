using GardenGroupDAL;
using GardenGroupModel;
using MongoDB.Bson;
using System.Collections.Generic;

namespace GardenGroupLogic
{
    public class TicketService
    {
        private TicketDAO ticketDAO = new TicketDAO();

        public List<Ticket> GetTicketCollection()
        {
            return ticketDAO.ReadTicketAll();
        }
        public List<Ticket> ReadAllTickets()
        {
            List<Ticket> tickets = ticketDAO.ReadAllTickets();
            return tickets;
        }

        public void AddTicket(Ticket ticket)
        {
            ticketDAO.AddTicket(ticket);
        }

        public void RemoveTicket(ObjectId ticket)
        {
            ticketDAO.RemoveTicket(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            ticketDAO.UpdateTicket(ticket);
        }
    }
}