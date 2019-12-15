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
        List<User> users = new List<User> { };

        public TeacherManager()
        {
            var session = new User
            {
                Login = "login",
                Fullname = "vadim",
                University = "hse",
                Group = "bbi186",
                Password = "123"
            };

            users.Add(session);
        }

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

        public bool CheckPassword(string login, string password)
        {
            //textBoxPassword.Text
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Login == login & users[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
