using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_semulator.Data
{
    [Serializable()]
    public class User
    {
        public string name;
        public List<Session> listSessions;
        public int A_first;
       

        public User (string name) {
            this.name = name;
            listSessions = new List<Session>();
            A_first = 0;

        }

        public static User searchUser (List<User> listUsers, string name)
        {
            foreach (User user in listUsers)
                if (name == user.name) return user;
            return null; 
        }

        public int get_t_AllTime()
        {
            int t_AllTime = 0;
            foreach (Session session in listSessions) t_AllTime += session.sessionTime;
            return t_AllTime;
        }

        

    }
}
