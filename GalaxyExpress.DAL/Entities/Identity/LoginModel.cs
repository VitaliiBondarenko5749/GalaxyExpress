using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities.Identity
{
    public class LoginModel
    {
        public string Login { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
