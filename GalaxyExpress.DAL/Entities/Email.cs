using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities
{
    public class Email : BaseEntity
    {
        public Guid EmailId
        {
            get => Id;
            set => Id = value;
        }
        public string EmailAddress { get; set; } = default!;
        public bool EmailConfirmed { get; set; } = false;

        public Guid UserId { get; set; } // FK
        public User User { get; set; } = default!;
    }
}
