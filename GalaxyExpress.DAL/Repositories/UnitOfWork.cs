using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories;

public interface IUnitOfWork
{
    GalaxyExpressDbContext _dbContext { get; set; }
    IEmailRepository Emails { get; }
    IParcelMachineRepository ParcelMachines { get; }
    IPostBranchRepository PostBranches { get; }

    UserManager<User> _userManager { get; set; }
    RoleManager<IdentityRole<Guid>> _roleManager { get; set; }

    Task SaveChangesAsync();
}

public class UnitOfWork : IUnitOfWork
{
    public GalaxyExpressDbContext _dbContext { get; set; }
    public IEmailRepository Emails { get; set; }
    public IParcelMachineRepository ParcelMachines { get; set; }
    public IPostBranchRepository PostBranches { get; set; }

    public UserManager<User> _userManager { get; set; }
    public RoleManager<IdentityRole<Guid>> _roleManager { get; set; }


    public UnitOfWork(
        GalaxyExpressDbContext dbContext, 
        IEmailRepository emails,
        UserManager<User> userManager, 
        RoleManager<IdentityRole<Guid>> roleManager, 
        IParcelMachineRepository parcelMachines, 
        IPostBranchRepository postBranches)
    {
        _dbContext = dbContext;
        Emails = emails;
        ParcelMachines = parcelMachines;
        PostBranches = postBranches;

        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
