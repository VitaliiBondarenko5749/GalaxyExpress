using Dropbox.Api;
using Dropbox.Api.Files;
using GalaxyExpress.BLL.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace GalaxyExpress.BLL.Services;

public interface IDropboxService
{
    Task<ServerResponse> UploadFileAsync(string fileName, IFormFile file, string folder);
    Task<ServerResponse> DeleteFileAsync(string filePath);
    Task<IFormFile> ChangeNameAsync(IFormFile file, string newName);
    Task<string> GetTemporaryLinkAsync(string folder, string fileName);
}

public class DropboxService : IDropboxService
{
    private readonly IConfiguration configuration;
    private readonly string accessToken;
    private HttpClient httpClient;

    public DropboxService(IConfiguration configuration, HttpClient httpClient)
    {
        this.configuration = configuration;
        accessToken = this.configuration["DropboxAPI:Token"];
        this.httpClient = httpClient;
        this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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

    public async Task<IFormFile> ChangeNameAsync(IFormFile file, string newName)
    {
        MemoryStream memoryStream = new();
        await file.CopyToAsync(memoryStream);

        byte[] fileBytes = memoryStream.ToArray();

        IFormFile renamedFile = new FormFile(new MemoryStream(fileBytes), 0, fileBytes.Length,
                                              file.Name, newName)
        {
            Headers = file.Headers,
            ContentType = file.ContentType
        };

        return renamedFile;
    }

    public async Task<string> GetTemporaryLinkAsync(string folder, string fileName)
    {
        string request = "https://api.dropboxapi.com/2/files/get_temporary_link";
        var requestBody = new { path = $"/{folder}/{fileName}" };
        StringContent content = new (JsonConvert.SerializeObject(requestBody), System.Text.Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync(request, content);

        response.EnsureSuccessStatusCode();

        string responseContent = await response.Content.ReadAsStringAsync();
        JObject jsonResponse = JObject.Parse(responseContent);

        Console.WriteLine(jsonResponse.ToString());

        return jsonResponse["link"]?.ToString() ?? string.Empty;
    }
}