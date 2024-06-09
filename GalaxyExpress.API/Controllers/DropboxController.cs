using GalaxyExpress.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyExpress.API.Controllers;

/// <summary>
/// Dropbox Controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class DropboxController : ControllerBase
{
    private readonly ILogger<DropboxController> logger;
    private readonly IDropboxService dropboxService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="dropboxService"></param>
    public DropboxController(ILogger<DropboxController> logger, IDropboxService dropboxService)
    {
        this.logger = logger;
        this.dropboxService = dropboxService;
    }

    /// <summary>
    /// Get temporary link
    /// </summary>
    /// <param name="folder"></param>
    /// <param name="fileName"></param>
    /// <returns>String or StatusCode 501</returns>
    [HttpGet("GetTemporaryLink")]
    public async Task<ActionResult<string>> GetTemporaryLinkAsync([FromQuery] string folder, [FromQuery] string fileName)
    {
        try
        {
            return await dropboxService.GetTemporaryLinkAsync(folder, fileName);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}