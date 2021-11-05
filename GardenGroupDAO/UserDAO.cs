using GardenGroupModel;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace GardenGroupDAO
{
    public class UserDAO : BaseDAO
    {
        public List<User> ReadUserAll()
        {
            return db.UserCollection();
        }

        public void AddUser(User user)
        {
            db.AddUser(user);
        }

        public User GetEmail(string email)
        {
            return db.GetEmail(email);
        }

        public void RemoveUser(ObjectId user)
        {
            db.RemoveUser(user);
        }

        public void UpdateUser(User user)
        {
            db.UpdateUser(user);
        }
    }
}