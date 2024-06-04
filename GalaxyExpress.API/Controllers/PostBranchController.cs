using GalaxyExpress.BLL.DTOs.PostBranchDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyExpress.API.Controllers;

// TODO: Add roles for some methods

/// <summary>
/// PostBranch controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class PostBranchController : ControllerBase
{
    private readonly ILogger<PostBranchController> logger;
    private readonly IPostBranchService postBranchService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="postBranchService"></param>
    public PostBranchController(ILogger<PostBranchController> logger, IPostBranchService postBranchService)
    {
        this.logger = logger;
        this.postBranchService = postBranchService;
    }

    /// <summary>
    /// Getting a list of post branches
    /// </summary>
    /// <param name="searchText"></param>
    /// <returns>List</returns>
    [HttpGet]
    public async Task<ActionResult<List<PostBranchInfoDTO>>> GetAllAsync([FromQuery] string? searchText)
    {
        try
        {
            return await postBranchService.GetAllAsync(searchText);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Remove post branch by Id from database
    /// </summary>
    /// <param name="id"></param>
    /// <returns>ServerResponse</returns>
    [HttpDelete("{id}")]
    public async Task<ActionResult<ServerResponse>> DeleteAsync(Guid id)
    {
        try
        {
            return await postBranchService.DeleteAsync(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Checking existence post branch in database (you can use this method during adding a new PostBranch).
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
            return await postBranchService.CheckExistenceByParametersAsync(parcelMachineNumber, globalAddress, localAddress);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Add a new post branch in databases
    /// </summary>
    /// <param name="addPostBranchDto"></param>
    /// <returns>ServerResponse</returns>
    [HttpPost]
    public async Task<ActionResult<ServerResponse>> AddAsync([FromForm] AddPostBranchDTO addPostBranchDto)
    {
        try
        {
            return await postBranchService.AddAsync(addPostBranchDto);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}