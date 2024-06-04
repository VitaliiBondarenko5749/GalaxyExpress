using GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyExpress.API.Controllers;

/// <summary>
/// ParcelMachine controller
/// </summary>
[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class ParcelMachineController : ControllerBase
{
    private readonly ILogger<ParcelMachineController> logger;
    private readonly IParcelMachineService parcelMachineService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="parcelMachineService"></param>
    public ParcelMachineController(ILogger<ParcelMachineController> logger, IParcelMachineService parcelMachineService)
    {
        this.logger = logger;
        this.parcelMachineService = parcelMachineService;
    }

    /// <summary>
    /// Getting a list of parcel machines
    /// </summary>
    /// <param name="searchText"></param>
    /// <returns>List</returns>
    [HttpGet]
    public async Task<ActionResult<List<ParcelMachineInfoDTO>>> GetAllAsync([FromQuery] string? searchText)
    {
        try
        {
            return await parcelMachineService.GetAllAsync(searchText);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Remove parcel machine by Id from database
    /// </summary>
    /// <param name="id"></param>
    /// <returns>ServerResponse</returns>
    [HttpDelete("{id}")]
    public async Task<ActionResult<ServerResponse>> DeleteAsync(Guid id)
    {
        try
        {
            return await parcelMachineService.DeleteAsync(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Checking existence parcel machine in database (you can use this method during adding a new ParcelMachine).
    /// </summary>
    /// <param name="parcelMachineNumber"></param>
    /// <param name="globalAddress"></param>
    /// <param name="localAddress"></param>
    /// <returns>ServerResponse</returns>
    [HttpGet("CheckExistence")]
    public async Task<ActionResult<ServerResponse>> CheckExistenceByParametersAsync([FromQuery] int parcelMachineNumber,
        [FromQuery] string globalAddress, [FromQuery] string localAddress)
    {
        try
        {
            return await parcelMachineService.CheckExistenceByParametersAsync(parcelMachineNumber, globalAddress, localAddress);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Add a new parcel machine in databases
    /// </summary>
    /// <param name="addParcelMachineDTO"></param>
    /// <returns>ServerResponse</returns>
    [HttpPost]
    public async Task<ActionResult<ServerResponse>> AddAsync([FromForm] AddParcelMachineDTO addParcelMachineDTO)
    {
        try
        {
            return await parcelMachineService.AddAsync(addParcelMachineDTO);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}