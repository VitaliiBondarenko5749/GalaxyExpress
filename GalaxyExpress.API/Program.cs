using GalaxyExpress.BLL.Services;
using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Entities.Identity;
using GalaxyExpress.DAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

#region SERVICES
{
    #region API
    {
        // Logging
        builder.Services.TryAdd(ServiceDescriptor.Singleton<ILoggerFactory, LoggerFactory>());
        builder.Services.TryAdd(ServiceDescriptor.Singleton(typeof(ILogger<>), typeof(Logger<>)));

        // DbContext
        builder.Services.AddDbContext<GalaxyExpressDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));
        });

        #region IDENTITY
        {
            // Reads data from our previously created JWT Section of appsettings.json
            builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));

            // Register ASP.NET Core Identity with method AddIdentity<TUser, TRole>
            builder.Services.AddIdentity<User, IdentityRole<Guid>>(options =>
            {
                options.SignIn.RequireConfirmedPhoneNumber = true;
            })
                // To register the required EFCore implementation of Identity stores
                .AddEntityFrameworkStores<GalaxyExpressDbContext>()
                .AddDefaultTokenProviders();
            // Adding Authentication
            builder.Services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:Audience"],
                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"])),
                    ValidateIssuerSigningKey = true
                };
            });
        }
        #endregion
    }
    #endregion

    #region BLL
    {
        builder.Services.AddScoped<IParcelMachineService, ParcelMachineService>();
        builder.Services.AddScoped<IPostBranchService, PostBranchService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IEmailSenderService, EmailSenderService>();
        builder.Services.AddScoped<IPhoneNumberService, PhoneNumberService>();
    }
    #endregion

    #region DAL
    {       
        builder.Services.AddScoped<IEmailRepository, EmailRepository>();
        builder.Services.AddScoped<IParcelMachineRepository, ParcelMachineRepository>();
        builder.Services.AddScoped<IPostBranchRepository, PostBranchRepository>();
        builder.Services.AddScoped<IPhoneNumberRepository, PhoneNumberRepository>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
    #endregion
}
#endregion

builder.Services.AddHttpClient();

builder.Services.AddControllers();

// Register a Swagger generator by defining 1 or more Swagger documents
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Galaxy Express",
        Version = "v1",
        Description = "API for performing operations with \"Galaxy Express\""
    });

    // CUstomizing the comment path for Swagger JSON and UI
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    option.IncludeXmlComments(xmlPath);
});

// Add CORS React application can have access to the server.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
           builder => builder.WithOrigins("http://localhost:3000")
           .AllowAnyMethod()
           .AllowAnyHeader());
});


//DataGenerator.InitBogusData(); // seeding db
WebApplication app = builder.Build();


if (app.Environment.IsDevelopment())
{
    // Enable middleware to serve generated Swagger as a JSON endpoint
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = "swagger";
    });
}


// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

await app.RunAsync();