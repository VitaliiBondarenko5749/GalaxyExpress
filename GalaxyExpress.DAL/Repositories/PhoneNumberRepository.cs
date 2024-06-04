using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;

namespace GalaxyExpress.DAL.Repositories;

public interface IPhoneNumberRepository : IGenericRepository<PhoneNumber, Guid>
{
}

public class PhoneNumberRepository : GenericRepository<PhoneNumber>, IPhoneNumberRepository
{
    public PhoneNumberRepository(GalaxyExpressDbContext dbContext) : base(dbContext) { }
}