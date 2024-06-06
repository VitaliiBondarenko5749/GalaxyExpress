using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using GalaxyExpress.BLL.DTOs.PostBranchDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Validators;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace GalaxyExpress.BLL.Services;

#pragma warning disable

public interface IPostBranchService
{
    Task<List<PostBranchInfoDTO>> GetAllAsync(string? searchText);
    Task<ServerResponse> DeleteAsync(Guid id);
    Task<ServerResponse> CheckExistenceByParametersAsync(int branchNumber, string globalAddress, string localAddress);
    Task<ServerResponse> AddAsync(AddPostBranchDTO addPostBranchDTO);
}

public class PostBranchService : IPostBranchService
{
    private readonly IUnitOfWork unitOfWork;

    public PostBranchService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<PostBranchInfoDTO>> GetAllAsync(string? searchText)
    {
        IEnumerable<PostBranch> postBranches = await unitOfWork.PostBranches.GetAllAsync();

        if (!string.IsNullOrEmpty(searchText))
        {
            postBranches = postBranches.Where(x => x.GlobalAddress.Contains(searchText) || x.LocalAddress.Contains(searchText));
        }

        return MapperConfiguration.CreateMapper()
            .Map<List<PostBranchInfoDTO>>(postBranches);
    }

    public async Task<ServerResponse> DeleteAsync(Guid id)
    {
        await unitOfWork.PostBranches.DeleteAsync(id);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse
        {
            Message = $"Відділення з id: {id} було видалено успішно!",
            IsSuccess = true
        };
    }

    public async Task<ServerResponse> CheckExistenceByParametersAsync(int branchNumber, string globalAddress, string localAddress)
    {
        PostBranch? postBranch = await unitOfWork.PostBranches
            .CheckExistenceByParametersAsync(branchNumber, globalAddress, localAddress);

        if (postBranch is null)
        {
            return new ServerResponse { Message = "Відділення з даними параметрами не існує!", IsSuccess = false };
        }

        return new ServerResponse { Message = "Відділення з даними параметрами існує!", IsSuccess = true };
    }

    public async Task<ServerResponse> AddAsync(AddPostBranchDTO addPostBranchDTO)
    {
        AddPostBranchValidator validator = new();
        ValidationResult validationResult = await validator.ValidateAsync(addPostBranchDTO);

        if (!validationResult.IsValid)
        {
            string errors = validationResult.ToString("~");

            return new ServerResponse
            {
                Message = "Щось пішло не так... всі помилки в списку \"Errors\"!",
                IsSuccess = false,
                Errors = errors.Split('~')
            };
        }

        PostBranch? postBranch = null;

        postBranch = await unitOfWork.PostBranches
            .CheckExistenceByParametersAsync(addPostBranchDTO.BranchNumber, addPostBranchDTO.GlobalAddress,
            addPostBranchDTO.LocalAddress);

        if (postBranch is not null)
        {
            return new ServerResponse { Message = "Відділення з даними параметрами існує!", IsSuccess = false };
        }

        postBranch = new()
        {
            BranchId = Guid.NewGuid(),
            BranchNumber = addPostBranchDTO.BranchNumber,
            LocalAddress = addPostBranchDTO.LocalAddress,
            GlobalAddress = addPostBranchDTO.GlobalAddress,
            Coordinates = $"{addPostBranchDTO.X};{addPostBranchDTO.Y}"
        };

        await unitOfWork.PostBranches.CreateAsync(postBranch);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = "Відділення було додане успішно!", IsSuccess = true };
    }

    private static MapperConfiguration MapperConfiguration
    {
        get => new(config =>
        {
            config.CreateMap<PostBranch, PostBranchInfoDTO>()
            .ForMember(dest => dest.X, opt => opt.MapFrom(src =>
            float.Parse(src.Coordinates.Substring(0, src.Coordinates.IndexOf(';')))))
            .ForMember(dest => dest.Y, opt => opt.MapFrom(src =>
            float.Parse(src.Coordinates.Substring(src.Coordinates.IndexOf(';') + 1))));
        });
    }
}