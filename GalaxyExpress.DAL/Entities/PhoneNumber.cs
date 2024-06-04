using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities
{
    public class PhoneNumber : BaseEntity
    {
        public Guid PhoneNumberId
        {
            get => Id;
            set => Id = value;
        }
        public string Number { get; set; } = default!;
        public bool PhoneNumberConfirmed { get; set; } = false;

        public Guid UserId { get; set; } // FK
        public User User { get; set; } = default!;
    }
}
