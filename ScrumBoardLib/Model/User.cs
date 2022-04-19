using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib.Model
{
    public class User
    {

        public enum Role
        {
            Guest,
            Member,
            Admin
        }

        private Role _Rolle;
        private string _UserName;
        private string _Password;

        public Role Rolle
        {
            get => _Rolle;
            set => _Rolle = value;
        }
        public string UserName
        {
            get => _UserName;
            set => _UserName = value;
        }

        public string Password
        {
            get => _Password;
            set => _Password = value;
        }

        public User()
        {

        }

        public User(string UserName, string Password, Role rolle)
        {
            _Password = Password;
            _UserName = UserName;
            Rolle = rolle;

        }
    }
}
