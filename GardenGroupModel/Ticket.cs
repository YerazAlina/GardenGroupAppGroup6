using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace GardenGroupModel
{
    public class Ticket
    {
        [BsonId]
        public ObjectId TicketId { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime TicketDate { get; set; }
        
        [BsonRepresentation(BsonType.String)]
        public IncidentType TypeOfIncident { get; set; }
        
        [BsonElement("IncidentSubject")]
        public string IncidentSubject { get; set; }

        [BsonElement("ReportedByUser")]
        public string ReportedByUser { get; set; }

        [BsonElement("EmailUser")]
        public string EmailUser { get; set; }

        [BsonRepresentation(BsonType.String)]
        public Priority TicketPriority { get; set; }
        
        [BsonRepresentation(BsonType.String)]
        public TicketStatus TicketStatus { get; set; }

        [BsonElement("TicketDeadline")]
        public string TicketDeadline { get; set; }

        [BsonElement("TicketDescription")]
        public string TicketDescription { get; set; }
    }

    public enum IncidentType
    {
        Hardware, Software, Service
    }

    public enum Priority
    {
        Low, Normal, High
    }

    public enum TicketStatus
    {
        Open, InProgress, OnHold, Escalated, Closed
    }
}