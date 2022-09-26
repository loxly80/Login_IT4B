using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_IT4B
{
    public class SqlRepository
    {
        private Dictionary<string,User> users = new Dictionary<string, User>()
        {
            {"admin", new User("admin","admin") },
            {"user", new User("user", "user") },
            {"guest", new User("guest", "guest") },
            {"poweruser", new User("poweruser", "poweruser") },
            {"jirka", new User("jirka", "jirka") }
        };

        public List<User> GetUsers()
        {
            return users.Values.ToList();
        }

        public User? GetUser(string username)
        {
            if (users.ContainsKey(username))
            {
                return users[username];
            }
            else
            {
                return null;
            }
        }
    }
}
