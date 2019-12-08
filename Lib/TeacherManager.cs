using Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class TeacherManager
    {
        private List<User> users;

        public bool CheckIfUserExists(string login)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Login == login)
                {
                    return true;
                }
            }
            return false;
        }

        public void RegisterUser(string login, string fullName, string university, string group, string password)
        {
            var user = new User
            {
                Login = login,
                Fullname = fullName,
                University = university,
                Group = group,
                Password = password
            };

            users.Add(user);
        }


    }
}
