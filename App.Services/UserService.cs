using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services
{
    public class UserService
    {
        public List<User> users = new List<User>();
        
        public User InsertUser(User user)
        {
            if (!user.ValidEmail())
                return null;

            user.ID = users.Count + 1;
            users.Add(user);

            return user;
        }
    }
}
