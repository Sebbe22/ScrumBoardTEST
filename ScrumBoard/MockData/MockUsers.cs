using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumBoardLib.Model;

namespace ScrumBoard.MockData
{
    public class MockUsers
    {

        private static List<User> Users = new List<User>()
        {
            new User("seb123", "password123"),
            new User("seb456", "password456"),
            new User("taco123", "tacoword123")
        };

        public static List<User> GetMockUsers()
        {
            return Users;
        }
    }
}
