using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sessions
    {

        public class UserSessions
        {
            public int ID { get; }
            public string Username { get; internal set; }
            public string Role { get; }
            public bool IsActive { get; internal set; }

            public UserSessions(int ID, string Username, string Role, bool IsActive)
            {

                this.ID = ID;
                this.Username = Username;
                this.Role = Role;
                this.IsActive = IsActive;
            }

           

           

        }
        public static UserSessions CurrentUser { get; internal set; }
        static internal void CreateUserSession(int ID, string Username, string Role, bool IsActive)
            {
                UserSessions CurrentUser_1 = new UserSessions(ID, Username, Role, IsActive);
                CurrentUser = CurrentUser_1;
            }
    }
}
