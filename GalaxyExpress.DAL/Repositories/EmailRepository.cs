using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Repositories;

public interface IEmailRepository : IGenericRepository<Email>
{
    Task<Email?> CheckUserEmailExistence(string email, Guid userId);
    Task<Email[]> GetAllByUserIdAsync(Guid userId);
}
public class EmailRepository : GenericRepository<Email>, IEmailRepository
{
    public EmailRepository(GalaxyExpressDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Email?> CheckUserEmailExistence(string email, Guid userId)
    {
        return await dbContext.Emails.AsNoTracking()
            .SingleOrDefaultAsync(e => e.EmailAddress.Equals(email) && e.UserId.Equals(userId)); 
    }

    public async Task<Email[]> GetAllByUserIdAsync(Guid userId)
    {
        return await dbContext.Emails.AsNoTracking()
            .Where(e => e.UserId.Equals(userId))
            .ToArrayAsync() ?? Array.Empty<Email>();
    }
}
