using GalaxyExpress.DAL.Entities;
using Microsoft.AspNetCore.Http;

namespace GalaxyExpress.BLL.DTOs.UserDTOs;

public class UpdateUserDTO
{
    public Guid UserId { get; set; }
    public string Login { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string? FatherName { get; set; }
    public DateTime? Birthday { get; set; }
    public Gender Gender { get; set; }
    public IFormFile? Photo { get; set; }
}