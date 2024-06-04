using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Repositories;

public interface IPostBranchRepository : IGenericRepository<PostBranch, Guid>
{
    Task<PostBranch?> CheckExistenceByParametersAsync(int branchNumber, string globalAddress, string localAddress);
}

public class PostBranchRepository : GenericRepository<PostBranch>, IPostBranchRepository
{
    public PostBranchRepository(GalaxyExpressDbContext dbContext) : base(dbContext) { }

    public async Task<PostBranch?> CheckExistenceByParametersAsync(int branchNumber, string globalAddress, string localAddress)
       => await dbContext.PostBranches.AsNoTracking()
       .SingleOrDefaultAsync(x => x.BranchNumber.Equals(branchNumber) && x.GlobalAddress.Equals(globalAddress)
       && x.LocalAddress.Equals(localAddress));
}