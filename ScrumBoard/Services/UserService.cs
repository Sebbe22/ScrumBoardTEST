using ScrumBoard.MockData;
using ScrumBoardLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumBoard.Services
{
    public class UserService : IUserService
    {

        public static List<User> Users;

        public UserService()
        {
            Users = MockUsers.GetMockUsers();
        }

        public User Create(User newUser)
        {
            Users.Add(newUser);
            return newUser;
        }

        public User Delete(string username)
        {
            foreach(User user in Users)
            {
                if( user.UserName == username)
                {
                    Users.Remove(user);
                    return user;
                } 
            }
            return null;
        }

        public List<User> GetAll()
        {
            return Users;
        }

        public User GetByString(string username)
        {
            foreach(User user in Users)
            {
                if( user.UserName == username)
                {
                    return user;
                }
            }
            return null;
        }

        public User Modify(User modifiedUser)
        {
            foreach(User user in Users)
            {
                if(modifiedUser.UserName == user.UserName)
                {
                    user.Password = modifiedUser.Password;
                    user.UserName = modifiedUser.UserName;
                    user.Rolle = modifiedUser.Rolle;
                }
                return modifiedUser;
            }
            return null;
        }


    }
}
