using AutoMapper;
using FluentValidation.Results;
using GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Validators;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories;
using Microsoft.IdentityModel.Tokens;


#pragma warning disable

namespace GalaxyExpress.BLL.Services;

public interface IParcelMachineService
{
    Task<List<ParcelMachineInfoDTO>> GetAllAsync(string? searchText);
    Task<ServerResponse> DeleteAsync(Guid id);
    Task<ServerResponse> CheckExistenceByParametersAsync(int parcelMachineNumber, string globalAddress, string localAddress);
    Task<ServerResponse> AddAsync(AddParcelMachineDTO addParcelMachineDTO);
}

public class ParcelMachineService : IParcelMachineService
{
    private readonly IUnitOfWork unitOfWork;

    public ParcelMachineService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<ParcelMachineInfoDTO>> GetAllAsync(string? searchText)
    {
        IEnumerable<ParcelMachine>? parcelMachines = await unitOfWork.ParcelMachines.GetAllAsync();

        if (!string.IsNullOrEmpty(searchText))
        {
            parcelMachines = parcelMachines.Where(x => x.GlobalAddress.Contains(searchText) || x.LocalAddress.Contains(searchText));
        }

        return MapperConfiguration.CreateMapper()
            .Map<List<ParcelMachineInfoDTO>>(parcelMachines);
    }

    public async Task<ServerResponse> DeleteAsync(Guid id)
    {
        await unitOfWork.ParcelMachines.DeleteAsync(id);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = $"Поштомат з id: {id} був видалений успішно!", IsSuccess = true };
    }

    public async Task<ServerResponse> CheckExistenceByParametersAsync(int parcelMachineNumber, string globalAddress, string localAddress)
    {
        ParcelMachine? parcelMachine = await unitOfWork.ParcelMachines
            .CheckExistenceByParametersAsync(parcelMachineNumber, globalAddress, localAddress);

        if (parcelMachine is null)
        {
            return new ServerResponse { Message = "Поштомат з даними параметрами не існує!", IsSuccess = false };
        }

        return new ServerResponse { Message = "Поштомат з даними параметрами існує!", IsSuccess = true };
    }

    public async Task<ServerResponse> AddAsync(AddParcelMachineDTO addParcelMachineDTO)
    {
        AddParcelMachineValidator validator = new();
        ValidationResult validationResult = await validator.ValidateAsync(addParcelMachineDTO);

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

        ParcelMachine? parcelMachine = null;

        parcelMachine = await unitOfWork.ParcelMachines
            .CheckExistenceByParametersAsync(addParcelMachineDTO.ParcelMachineNumber, addParcelMachineDTO.GlobalAddress,
            addParcelMachineDTO.LocalAddress);

        if (parcelMachine is not null)
        {
            return new ServerResponse { Message = "Поштомат з даними параметрами існує!", IsSuccess = false };
        }

        parcelMachine = new()
        {
            ParcelMachineId = Guid.NewGuid(),
            ParcelMachineNumber = addParcelMachineDTO.ParcelMachineNumber,
            LocalAddress = addParcelMachineDTO.LocalAddress,
            GlobalAddress = addParcelMachineDTO.GlobalAddress,
            Coordinates = $"{addParcelMachineDTO.X};{addParcelMachineDTO.Y}"
        };

        await unitOfWork.ParcelMachines.CreateAsync(parcelMachine);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = "Поштомат був доданий успішно!", IsSuccess = true };
    }

    private static MapperConfiguration MapperConfiguration
    {
        get => new(config =>
        {
            config.CreateMap<ParcelMachine, ParcelMachineInfoDTO>()
            .ForMember(dest => dest.X, opt => opt.MapFrom(src =>
            float.Parse(src.Coordinates.Substring(0, src.Coordinates.IndexOf(';')))))
            .ForMember(dest => dest.Y, opt => opt.MapFrom(src =>
            float.Parse(src.Coordinates.Substring(src.Coordinates.IndexOf(';') + 1))));
        });
    }
}