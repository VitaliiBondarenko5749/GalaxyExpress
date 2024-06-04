using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Repositories;

public interface IEmailRepository : IGenericRepository<Email, Guid>
{
}
public class EmailRepository : GenericRepository<Email>, IEmailRepository
{
    public EmailRepository(GalaxyExpressDbContext dbContext) : base(dbContext)
    {
    }


    public override async Task<IEnumerable<Email>> GetAllAsync()
    {
        return await entities
            .AsNoTracking()
            .Include(e => e.User)
            .ToListAsync();
    }

    public override async Task<Email?> GetByIdAsync(Guid id)
    {
        return await entities
            .AsNoTracking()
            .Include(e => e.User)
            .FirstOrDefaultAsync(e => e.EmailId == id);
    }
}
