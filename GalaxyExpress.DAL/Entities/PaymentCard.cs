using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities
{
    public class PaymentCard : BaseEntity
    {
        public Guid CardId
        {
            get => Id;
            set => Id = value;
        }
        public string CardNumber { get; set; } = default!;
        public string Validity { get; set; } = default!; // "03/24"
        public string CVV { get; set; } = default!; 

        public Guid UserId { get; set; } // FK
        public User User { get; set; } = default!;
    }
}
