using GardenGroupDAO;
using GardenGroupModel;
using MongoDB.Bson;
using System.Collections.Generic;

namespace GardenGroupLogic
{
    public class UserService
    {
        private UserDAO userDAO = new UserDAO();

        public List<User> GetUserCollection()
        {
            return userDAO.ReadUserAll();
        }

        public void AddUser(User user)
        {
            userDAO.AddUser(user);
        }

        public User GetEmail(string email)
        {
            return userDAO.GetEmail(email);
        }
        public void RemoveUser(ObjectId user)
        {
            userDAO.RemoveUser(user);
        }

        public void UpdateUser(User user)
        {
            userDAO.UpdateUser(user);
        }
    }
}