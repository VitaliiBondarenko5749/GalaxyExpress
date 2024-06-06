using Dropbox.Api;
using Dropbox.Api.Files;
using GalaxyExpress.BLL.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GalaxyExpress.BLL.Services;

public interface IDropboxService
{
    Task<ServerResponse> UploadFileAsync(string fileName, IFormFile file, string folder);
    Task<ServerResponse> DeleteFileAsync(string filePath);
}

public class DropboxService : IDropboxService
{
    private readonly IConfiguration configuration;
    private readonly string accessToken;

    public DropboxService(IConfiguration configuration)
    {
        this.configuration = configuration;
        accessToken = this.configuration["DropboxAPI:Token"];
    }

    public async Task<ServerResponse> UploadFileAsync(string fileName, IFormFile file, string folder)
    {
        using (DropboxClient dbxClient = new(accessToken))
        {
            byte[] fileBytes;

            using (MemoryStream memoryStream = new())
            {
                await file.CopyToAsync(memoryStream);
                fileBytes = memoryStream.ToArray();
            }

            using (MemoryStream memoryStream = new(fileBytes))
            {
                FileMetadata responce = await dbxClient.Files.UploadAsync($"/{folder}/{fileName}",
                    WriteMode.Overwrite.Instance,
                    body: memoryStream);
            }
        }

        return new ServerResponse
        {
            Message = "Файл успішно був завантажений!",
            IsSuccess = true
        };
    }

    public async Task<ServerResponse> DeleteFileAsync(string filePath)
    {
        using (DropboxClient dbxClient = new(accessToken))
        {
            DeleteResult responce = await dbxClient.Files.DeleteV2Async(filePath);
        }

        return new ServerResponse
        {
            Message = $"Файл за шляхом \"{filePath}\" було видалено!",
            IsSuccess = true
        };
    }
}