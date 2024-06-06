using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Repositories;

public interface IPhoneNumberRepository : IGenericRepository<PhoneNumber, Guid>
{
    Task<PhoneNumber?> CheckUserPhoneNumberExistenceAsync(Guid userId, string phoneNumber);
    Task<PhoneNumber[]> GetAllByUserIdAsync(Guid userId);
}

public class PhoneNumberRepository : GenericRepository<PhoneNumber>, IPhoneNumberRepository
{
    public PhoneNumberRepository(GalaxyExpressDbContext dbContext) : base(dbContext) { }

    public async Task<PhoneNumber?> CheckUserPhoneNumberExistenceAsync(Guid userId, string phoneNumber)
    {
        return await dbContext.PhoneNumbers.AsNoTracking()
            .SingleOrDefaultAsync(pn => pn.UserId.Equals(userId) && pn.Number.Equals(phoneNumber));
    }

    public async Task<PhoneNumber[]> GetAllByUserIdAsync(Guid userId)
    {
        return await dbContext.PhoneNumbers.AsNoTracking()
            .Where(pn => pn.UserId.Equals(userId))
            .ToArrayAsync() ?? Array.Empty<PhoneNumber>();
    }
}