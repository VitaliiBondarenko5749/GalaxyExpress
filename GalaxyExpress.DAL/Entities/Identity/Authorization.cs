using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities.Identity
{
    public static class Authorization
    {
        public enum Roles
        {
            Admin,
            Manager,
            User
        }

        public const string default_username = "user_";
        public const Roles default_role = Roles.User;
    }
}
