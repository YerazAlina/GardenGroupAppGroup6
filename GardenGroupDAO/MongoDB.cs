using GardenGroupModel;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GardenGroupDAO
{
    public class MongoDB
    {
        private static MongoDB instance;
        private readonly IMongoDatabase db;

        public static MongoDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MongoDB();
                }

                return instance;
            }
        }

        private MongoDB()
        {
            var client = new MongoClient("mongodb+srv://YerazAlina:Project2.1Group6@gardengroupdb.cd0sx.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");//mongostring
            db = client.GetDatabase("GardenGroup");
        }
        public List<Ticket> TicketCollection()
        {
            IMongoCollection<Ticket> ticketCollection = db.GetCollection<Ticket>("tickets");
            List<Ticket> tickets = ticketCollection.AsQueryable().ToList();
            return tickets;
        }
        public List<User> UserCollection()
        {
            IMongoCollection<User> userCollection = db.GetCollection<User>("users");
            List<User> users = userCollection.AsQueryable().ToList();
            return users;
        }

        public void AddUser(User user)
        {
            var collection = db.GetCollection<User>("users");
            collection.InsertOne(user);
        }

        public List<T> FindByQuery<T>(string table, FilterDefinition<T> filter)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find<T>(filter).ToList();
        }

        public User GetEmail(string email)
        {
            var filter = Builders<User>.Filter.Eq("Email", email);
            List<User> users = FindByQuery<User>("users", filter);

            return users.Count > 0 ? users[0] : null;
        }

        public void AddTicket(Ticket ticket)
        {
            var collection = db.GetCollection<Ticket>("tickets");
            collection.InsertOne(ticket);
        }
        
        public List<Ticket> ReadAllTickets()
        {
            IMongoCollection<Ticket> ticketCollection = db.GetCollection<Ticket>("tickets");
            List<Ticket> tickets = ticketCollection.AsQueryable().ToList();
            return tickets;
        }

        public void ChangeTicketUser()
        {

        }

        public void TicketArchiver(Ticket ticket)
        {
                var collection = db.GetCollection<Ticket>("archivedTickets");
                collection.InsertOne(ticket);      
        }

        public void RemoveUser(ObjectId user)
        {
            var collection = db.GetCollection<BsonDocument>("users");
            var deleteuser = Builders<BsonDocument>.Filter.Eq("_id", user);
            collection.DeleteOne(deleteuser);
        }

        public void RemoveTicket(ObjectId ticket)
        {
            var collection = db.GetCollection<BsonDocument>("tickets");
            var deletetickets= Builders<BsonDocument>.Filter.Eq("_id", ticket);
            collection.DeleteOne(deletetickets);
        }

        public List<Ticket> ReadAllArchivedTickets()
        {
            IMongoCollection<Ticket> archivedticketCollection = db.GetCollection<Ticket>("archivedTickets");
            List<Ticket> Archivedtickets = archivedticketCollection.AsQueryable().ToList();
            return Archivedtickets;
        }

        public void RemoveArchivedTicket(ObjectId ticket)
        {
            var collection = db.GetCollection<BsonDocument>("archivedTickets");
            var deletetickets = Builders<BsonDocument>.Filter.Eq("_id", ticket);
            collection.DeleteOne(deletetickets);
        }

        public void UpdateUser(User user)
        {
            var collection = db.GetCollection<User>("users");
            var filter = Builders<User>.Filter.Eq("_id", user.Id);
            collection.ReplaceOne(filter, user, new ReplaceOptions() { IsUpsert = true });
        }
    }
}