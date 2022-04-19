using ScrumBoardLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumBoard.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetByString(String username);
        User Create(User newUser);
        User Delete(String username);
        User Modify(User modifiedUser);




    }
}
