using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities.Identity
{
    public class AuthenticationModel
    {
        public string Message { get; set; } = default!;
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; } = default!;
        public List<string> Emails { get; set; } = new List<string>();
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        public List<string> Roles { get; set; } = new List<string>();
        public string Token { get; set; } = default!;
    }
}
