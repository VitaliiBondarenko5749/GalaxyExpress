using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities.Identity
{
    public class RegisterModel
    {
        public string PhoneNumber { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Login { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string? FatherName { get; set; }
    }
}
