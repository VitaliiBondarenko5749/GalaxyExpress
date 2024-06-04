using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GalaxyExpress.DAL.Entities
{
    public abstract class BaseEntity
    {
        [NotMapped]
        [JsonIgnore]
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
