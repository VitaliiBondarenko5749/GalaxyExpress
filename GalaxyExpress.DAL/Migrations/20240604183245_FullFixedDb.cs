using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.DAL.Migrations
{
    public partial class FullFixedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    Login = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    FatherName = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "NotSelected"),
                    ImageDirectory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BonusAccount = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false, defaultValue: 0m),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParcelMachines",
                columns: table => new
                {
                    ParcelMachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelMachineNumber = table.Column<int>(type: "int", nullable: false),
                    LocalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GlobalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelMachines", x => x.ParcelMachineId);
                });

            migrationBuilder.CreateTable(
                name: "PostBranches",
                columns: table => new
                {
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchNumber = table.Column<int>(type: "int", nullable: false),
                    LocalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GlobalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostBranches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodes",
                columns: table => new
                {
                    PromoCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BonusSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActivationCounter = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoCodes", x => x.PromoCodeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddress = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_Emails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    ParcelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNumber = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MethodDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcelWeight = table.Column<float>(type: "real", nullable: false),
                    SenderAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RecipientAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TypePackaging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPackages = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    LossCoverage = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    HomeDelivery = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeliveryPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfDispatch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfReceipt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.ParcelId);
                    table.ForeignKey(
                        name: "FK_Parcels_AspNetUsers_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parcels_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentCards",
                columns: table => new
                {
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<string>(type: "NVARCHAR(16)", nullable: false),
                    Validity = table.Column<string>(type: "NVARCHAR(5)", nullable: false),
                    CVV = table.Column<string>(type: "NVARCHAR(3)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_PaymentCards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserParcelMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelMachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserParcelMachines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserParcelMachines_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserParcelMachines_ParcelMachines_ParcelMachineId",
                        column: x => x.ParcelMachineId,
                        principalTable: "ParcelMachines",
                        principalColumn: "ParcelMachineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPostBranches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPostBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPostBranches_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPostBranches_PostBranches_PostBranchId",
                        column: x => x.PostBranchId,
                        principalTable: "PostBranches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPromoCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PromoCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPromoCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPromoCodes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPromoCodes_PromoCodes_PromoCodeId",
                        column: x => x.PromoCodeId,
                        principalTable: "PromoCodes",
                        principalColumn: "PromoCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserParcels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSender = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserParcels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserParcels_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserParcels_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Parcels",
                        principalColumn: "ParcelId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), "519eeed1-b6a6-48a5-bb4b-53c5f54f8972", "User", "USER" },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), "42740874-f7be-4309-862c-7cf23624d2c6", "Admin", "ADMIN" },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), "45b58ab1-16e6-4c7a-887f-865b8cf4fc8b", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef"), 0, null, 964.6639701131150000m, "5239736e-ba21-4f85-92aa-188551c88080", "Rochelle", "Rochelle", null, "Legros", false, null, "Rochelle.Legros", "AQAAAAEAACcQAAAAEHzYK3QH19Z84g/MLn0sd+S2gyY8olYEXX9cL84n7/oUdwxrr5QbdjvAE6UwjQykew==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9"), 0, null, 193.470306990990000m, "5cd87e7f-0e36-4872-9e90-0068464907c8", null, "Kristin", null, "Kuhic", false, null, "Kristin.Kuhic", "AQAAAAEAACcQAAAAEOVXUQJWcBv+5Wof4qhSgf2lBQ9UHEGq74mWNBJAcGP8Ubs0leAoKAp6ICHrxqq8EQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d"), 0, null, 305.204311741940000m, "73adbd97-946a-4759-a356-6bbf7b98fcef", "Melissa", "Melissa", null, "McKenzie", false, null, "Melissa.McKenzie", "AQAAAAEAACcQAAAAEBBeZjkqIrbYksJnp1NeE0CBF7fIF9ssowx2yPCGCVkJx3Pew4qRb1uurWa8M45h4g==", null, false },
                    { new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c"), 0, new DateTime(1975, 12, 4, 14, 36, 40, 640, DateTimeKind.Local).AddTicks(5793), 821.1262727206530000m, "1c043aac-96a1-476a-a0b4-73a6a4273e23", "Loretta", "Loretta", null, "Kiehn", false, null, "Loretta_Kiehn", "AQAAAAEAACcQAAAAED29JFoevGPsu7PHF3AGbP5NOecrc5Rb6958QdMORnOEsbffbaDoTT7mve9QAYk9bw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472"), 0, null, 575.0587127239790000m, "6ffc31a2-aff1-4932-bcf1-0418d361fdc0", "Charlotte", "Charlotte", null, "Homenick", false, null, "Charlotte30", "AQAAAAEAACcQAAAAEJJcGEDdy7NzG1SncvSUB/XeNEQJYIlygvpmFrYpob5bAf1Py1y6MxU9VCxyaSQJJg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930"), 0, new DateTime(1965, 2, 12, 17, 52, 30, 341, DateTimeKind.Local).AddTicks(4588), 264.5508818810170000m, "e48ee6ec-b4ba-4210-8af0-35c8f3080c4d", "Nicholas", "Nicholas", null, "Leannon", false, null, "Nicholas_Leannon78", "AQAAAAEAACcQAAAAEJogQ3ZSR2NIzchzTefQkIBekKKVdfVaKuMcLEL0Ubw7fSuqtjFSdOuSPwNjBmJv8A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5"), 0, new DateTime(1980, 6, 9, 19, 52, 3, 251, DateTimeKind.Local).AddTicks(2813), 646.5315072763580000m, "b0871678-9229-4006-a36d-80e39a40ecb5", null, "Brent", null, "Nicolas", false, null, "Brent93", "AQAAAAEAACcQAAAAEJq+C+32N19AKF3KASwhRkVkb/AVP/FzjBR3n6ggW0ZA89wJcL7zvKjeQIzTqXxH7w==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a"), 0, null, 22.41446338966640000m, "84940ec8-8f58-4c41-8d70-7641b2117ea0", null, "Emily", null, "Hoeger", false, null, "Emily.Hoeger16", "AQAAAAEAACcQAAAAEKgUeHNSmGIkVHxtxVpZ2FE0RvGEahHBuAr35tQWFPJbPALLduWGFD/5jnT3WvdEng==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76"), 0, null, 58.20577134152780000m, "6b0508ea-0e48-4bb7-bb05-db207aa29f5f", null, "Jesse", null, "Will", false, null, "Jesse70", "AQAAAAEAACcQAAAAEK59/V+cavDCXpwim+UZr5TqTFYDAMdrEkrQyK5BXMZLcQEfaT5RaCEUDUJPAZ7Zzg==", null, "Female", false },
                    { new Guid("067bf875-8a96-48a0-978d-10d890bd7318"), 0, new DateTime(1968, 9, 21, 8, 19, 45, 629, DateTimeKind.Local).AddTicks(4020), 444.585185848640000m, "8ae9803a-2e1b-4d0f-8c96-07397544bf99", "Silvia", "Silvia", null, "Bode", false, null, "Silvia_Bode", "AQAAAAEAACcQAAAAEGa6E1yLyPqNWssBtusFhsLJalzlCdUVUGwPxhSD18sTCZf0yTM5p0H1mGh8Z522rg==", null, "NotSelected", false },
                    { new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de"), 0, null, 566.597165584370000m, "65fd0a67-8e27-476d-993b-7068c8e31e03", "Lana", "Lana", null, "Sanford", false, null, "Lana61", "AQAAAAEAACcQAAAAELteyN3Ld8iLtFyMRbMVzzj+MZMiNPFkXCUODMKUptOdeYdjAMN/sowo5SJZ98nz7Q==", null, "NotSelected", false },
                    { new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb"), 0, new DateTime(1946, 1, 12, 19, 37, 37, 301, DateTimeKind.Local).AddTicks(5943), 425.4967082582270000m, "cfe70e3f-1d69-4e43-9402-2615f89770c8", null, "Sammy", null, "Conroy", false, null, "Sammy_Conroy89", "AQAAAAEAACcQAAAAELs8jmbSOhO+fw8ktdgpjfmw/k1C3MyrTIKhplqbpekwLCAhnU8KjHLAQI3L3KdcOA==", null, "Female", false },
                    { new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0"), 0, null, 901.0004709443770000m, "40139a90-83fb-4106-989c-3fe4ccbae6ae", "Moses", "Moses", null, "Heller", false, null, "Moses_Heller", "AQAAAAEAACcQAAAAECgztdpt+KQEvNwDfv3973cZWp+0KYOML7LsBoTu0D3eVY413iGLbRMr/Xdfo3rBXw==", null, "Female", false },
                    { new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7"), 0, new DateTime(1983, 9, 16, 22, 56, 9, 603, DateTimeKind.Local).AddTicks(4067), 538.4687328833160000m, "624cbd16-bf19-44cf-a4d1-0995ddfdaf2c", "Margie", "Margie", null, "Bailey", false, null, "Margie34", "AQAAAAEAACcQAAAAEF26UpyB/pkHD8xM3Lteb3vFpq5TUQyq42fgj19jyghikPbdRoTtXJX7hn88Wbt1WA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b13afed-b734-4249-bae8-810ee4f78617"), 0, null, 263.6390802745080000m, "f7fa4156-5aec-4899-b3f1-9e02af07c310", null, "Rachael", null, "Bruen", false, null, "Rachael66", "AQAAAAEAACcQAAAAEAjrbe4tBrb1RLVfDnQ6lBIv4HJyoFp4NJBdoo3YekMA2A/4uftdxeorGQCQC1eiwA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f"), 0, null, 614.8004426643760000m, "54c4686d-9814-4af9-86e2-04d52affbef5", null, "Tina", null, "Oberbrunner", false, null, "Tina_Oberbrunner", "AQAAAAEAACcQAAAAEJne0zGoPTCxQn4HWg4qrbXbJW+lB9DzRnkG3Vfbd67+3EyLEDfxZep5mTTipfX3wQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a"), 0, new DateTime(1953, 3, 4, 23, 59, 15, 700, DateTimeKind.Local).AddTicks(2085), 824.7633659080310000m, "2e030e24-cec1-4ed3-bca4-f928c9c5ec8b", null, "Georgia", null, "McLaughlin", false, null, "Georgia25", "AQAAAAEAACcQAAAAENjBlYoe03egBoHzfjMDkCs6SOrMW85oeNSRTwkwtt1/10Witmyas0Maf3XEiazmQw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca"), 0, new DateTime(1946, 1, 7, 20, 44, 15, 388, DateTimeKind.Local).AddTicks(9359), 298.7567888295450000m, "edb7a5b3-d753-41c3-be74-b4332fb00e42", "Marshall", "Marshall", null, "Ritchie", false, null, "Marshall83", "AQAAAAEAACcQAAAAEG6OQP35IkKIMMmhJa8lPZQZIQxUBQt1OSpMy/BFf0Qj9TXKwXhWKXQuEFtuM+nwtw==", null, "NotSelected", false },
                    { new Guid("0fc27c31-ca71-419a-8df7-391205e73c05"), 0, null, 356.4351967054830000m, "d9ca1320-5ebd-457d-903a-50c8f8191f4b", null, "Jorge", null, "Strosin", false, null, "Jorge89", "AQAAAAEAACcQAAAAEDb4AoxZRAofCdEQeMX5KQ+/fJ0hNfWUaCAh3SKnzmMtFePerE2ecsjyGxeZOQYmuA==", null, "NotSelected", false },
                    { new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0"), 0, null, 280.3572912618450000m, "7c663197-b63f-4ff4-ab01-d71ce65a7e2f", null, "Kathy", null, "Conroy", false, null, "Kathy50", "AQAAAAEAACcQAAAAEJ4icHh0gj+FBakLnaL24XuEpYN1VfOJ4tAr5l7d9XnndI5MIkxfros0lum2bjeYcg==", null, "NotSelected", false },
                    { new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22"), 0, null, 280.9165636497450000m, "7411783e-7fa0-49dd-ace6-58a6a4f19a0c", "Marc", "Marc", null, "Padberg", false, null, "Marc85", "AQAAAAEAACcQAAAAELQxP8zbUxLYsC0jSIUzuDvmVbW+z2w95PuBT0NZvT/93iph2i5n2XX6y3hI7Af7hA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d"), 0, new DateTime(1940, 9, 12, 16, 15, 29, 113, DateTimeKind.Local).AddTicks(3965), 915.5741377971250000m, "494d3205-1148-46f2-a612-cfa7054cb5ab", null, "Vanessa", null, "Stamm", false, null, "Vanessa_Stamm96", "AQAAAAEAACcQAAAAEPDCGW5KUQd9Zk0baRXMSfBIW1m6yCyDS5H3aVw1TOaYUXzmb2wh3vc6+YUUj9YYAA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1144670b-de30-428e-9356-066b18301c96"), 0, new DateTime(2008, 8, 14, 7, 31, 2, 553, DateTimeKind.Local).AddTicks(5196), 555.8777834609910000m, "4d553c38-19c1-4e37-9412-9a61a72471a2", "Austin", "Austin", null, "Hegmann", false, null, "Austin5", "AQAAAAEAACcQAAAAEDeMgRb7VLKs0WhS/HqIXVRrKH+zvkKxtzBmPkhW5n/oWMO9Y/mF4mOc0tAM18wTNw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81"), 0, new DateTime(1930, 5, 3, 6, 41, 12, 568, DateTimeKind.Local).AddTicks(7937), 964.9263079910930000m, "c1eb919a-d04d-4799-8f24-1552ec4c8087", "Toni", "Toni", null, "Brekke", false, null, "Toni_Brekke", "AQAAAAEAACcQAAAAEA9z2dfSUi6itT5Oh9ZGuVu9HUm2Q7M20oSjohwK7UtNlmYivqLrsP2oIVQHXkJhfw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc"), 0, null, 804.8593284866560000m, "0b0941ca-2ebf-44b6-9e2c-8bdf32b8acaf", null, "Jerry", null, "Kirlin", false, null, "Jerry_Kirlin16", "AQAAAAEAACcQAAAAEM4eA5CCntkOPnKkqmLgWnTtN5nuk1GJTVzH+YXyGOfa2xeja0x0mKSfV1qV0QZb/Q==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("13cc902b-ca01-4670-ab3f-def800c89833"), 0, null, 102.4719491764440000m, "b9205a3a-c08b-4934-bfd3-7c1047f6dab3", null, "Sheryl", null, "Carroll", false, null, "Sheryl.Carroll37", "AQAAAAEAACcQAAAAEP1Ja89uD7B0ZRVpT3aoXZTcpPZwwk8cqYSoyGY99X5zLbeeFpafvsd3GX5ctD1wWQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("13d00315-a856-463e-abb8-2a7dd165ded7"), 0, null, 388.9617850301650000m, "caa33baf-3671-4be9-9eda-418d663f97b8", "Jodi", "Jodi", null, "Kuhic", false, null, "Jodi82", "AQAAAAEAACcQAAAAEFOZMYSBWGsIbf4LpR73LreZC93zCMWBLqyp5vqS4Z4ijfCt1wSwkj2htSYt2j4d+w==", null, "NotSelected", false },
                    { new Guid("152f42db-01de-48e4-a495-9233a821e250"), 0, new DateTime(1933, 2, 1, 0, 47, 59, 721, DateTimeKind.Local).AddTicks(7244), 595.6626461699590000m, "d23e5753-25e4-4a51-84b8-1866f9bbf3ae", "Calvin", "Calvin", null, "Cummerata", false, null, "Calvin_Cummerata", "AQAAAAEAACcQAAAAEG8H4bXiPvoQX5HkWNmNIYzfG3B3eemkYkyj5zY3jLAg2acdZ29wRexdYMh8TEJq3w==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413"), 0, new DateTime(1950, 8, 15, 4, 42, 36, 269, DateTimeKind.Local).AddTicks(4971), 294.9142804279350000m, "8f80fccc-d1bf-4716-a466-225f312701a3", null, "Elena", null, "Dibbert", false, null, "Elena.Dibbert", "AQAAAAEAACcQAAAAECn98mFoYJofjRMAtgRW/LV9+8MpuOiortM83f5AFM81KOB4eCHOazHOeGkOu5Lrlg==", null, false },
                    { new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3"), 0, new DateTime(1994, 9, 12, 21, 1, 40, 581, DateTimeKind.Local).AddTicks(4387), 369.9962462508890000m, "d5935253-a124-4166-98b8-70845a0b987c", "Benjamin", "Benjamin", null, "Gibson", false, null, "Benjamin_Gibson", "AQAAAAEAACcQAAAAEOps+y/Ev1FO5ATtd9VRU+lXvju282mNqvZILj8K007hVN57b8P4LsgIqllZZwXSlA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d"), 0, null, 847.9231002811690000m, "39c73bd5-b837-4ca0-aafd-75962c8efa67", "Miriam", "Miriam", null, "Schneider", false, null, "Miriam.Schneider99", "AQAAAAEAACcQAAAAEPXz9v3BmaR/4euAegHqS//N1IHwCDjMbM7qF6ruk1nf7K1FHwHZyjtNK0Z38EdNvw==", null, "Female", false },
                    { new Guid("171184db-5baa-42f3-92d8-64b8e76c6165"), 0, new DateTime(1978, 8, 28, 4, 30, 29, 462, DateTimeKind.Local).AddTicks(8858), 36.85771262644850000m, "ebc8f8c0-3689-4909-af42-6379c76b57fc", null, "Jenny", null, "Dooley", false, null, "Jenny84", "AQAAAAEAACcQAAAAED+JRnHYqRFz/WNdx+ZpwPs4x/dhq8Rj1vL6goPcJwkWnsP/Xr68n3ISoXjbqAPyxg==", null, "Female", false },
                    { new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779"), 0, null, 203.9841730121630000m, "c88cab30-9832-41e9-a8e0-9a1efb9a2a96", null, "Cathy", null, "Mills", false, null, "Cathy_Mills16", "AQAAAAEAACcQAAAAEE6Ky7/dspKE4Mo+r7PEnO6PRgfmXMkaSOzlnUC1hiadqZjXPT0fWJlCKineH9r5UA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10"), 0, null, 366.2402516445440000m, "fcd4f25d-165c-422a-8bbb-edb5caadbf1d", null, "Juanita", null, "Pacocha", false, null, "Juanita.Pacocha7", "AQAAAAEAACcQAAAAEDAIeLJS4kphbp4IQ/1o6qeUz8Qb1X6xNUVEW51HlTjT/EWtq9ANhwBJoEXfxtEi3g==", null, false },
                    { new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca"), 0, new DateTime(1993, 9, 15, 8, 32, 11, 301, DateTimeKind.Local).AddTicks(6805), 893.4839270375880000m, "2fc7f653-ca26-4bad-bc21-19d0e7b53af4", null, "Leslie", null, "Zieme", false, null, "Leslie_Zieme53", "AQAAAAEAACcQAAAAEEthOxWNA6VPkfjSOI5cUS+adh3Zp8ZBYvdXFJshL+pS61qz8T+gD6t62izkSN+zRw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af"), 0, new DateTime(1946, 5, 10, 5, 22, 5, 64, DateTimeKind.Local).AddTicks(5405), 390.5146872688930000m, "c1213801-81b3-45de-bcef-b0ec31b6a09e", "Marco", "Marco", null, "Weimann", false, null, "Marco_Weimann2", "AQAAAAEAACcQAAAAENnmUtKR8ceXkoMnxekbua1Gte5Jqw6pYz8h6hUxakqSo/7EIALM0AAcVL+g9rLMAA==", null, "NotSelected", false },
                    { new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad"), 0, null, 593.4694252717840000m, "cf2756ad-175f-46e3-b1a2-3425be96f56e", "Darla", "Darla", null, "Spencer", false, null, "Darla64", "AQAAAAEAACcQAAAAEL4hF4jL4FIeL86iQo2GJWKczh1LyXH8V4WgZLJAh1FHzz8bIwfBfhZ9/0rnpHDtlQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa"), 0, new DateTime(1970, 11, 18, 11, 22, 20, 275, DateTimeKind.Local).AddTicks(6652), 23.32291964404250000m, "4db36827-501e-48d3-b2d4-6621d38ada10", null, "Carlos", null, "Keeling", false, null, "Carlos56", "AQAAAAEAACcQAAAAEN0SbbLya5ZwJ6vUOMNtHqFFbkdZDfEItuQyr7FBFNIvsTeptDQtloi+GIboFrmyvg==", null, false },
                    { new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d"), 0, null, 880.4019737939180000m, "31cabe9b-a960-43cf-83a0-bc435a2aa7f9", "Carmen", "Carmen", null, "Prosacco", false, null, "Carmen.Prosacco", "AQAAAAEAACcQAAAAEGyRSO25c/UaF4PWhLGR20Cz1qvjhNiM19IU2NiTUV8a7xVJj5RDK4lPneuokTAfaw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d"), 0, null, 408.6078273872480000m, "3ed8c37f-9124-4211-b967-8933a31350a2", null, "Boyd", null, "Johns", false, null, "Boyd_Johns79", "AQAAAAEAACcQAAAAEPn9bYqLnV0hssbwhToxDt9FVnepG7W1MQwWTqp1qylreNXAmYGA2WDe7AYwooGvAA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0"), 0, new DateTime(1958, 6, 14, 18, 3, 33, 151, DateTimeKind.Local).AddTicks(3622), 795.9835026330560000m, "55cf4dee-2f64-4775-872d-e5de2cf3d8ef", "Cedric", "Cedric", null, "O'Keefe", false, null, "Cedric42", "AQAAAAEAACcQAAAAEHrhZt9ThVVUUsTtbxitl6cfmtci+5shhIGQ+3oWnEW+l8UARN0H8buxbiff7O4hwQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e"), 0, null, 95.41024988083770000m, "12e33e13-a085-4f20-bc21-678695f1b4f9", null, "Seth", null, "Schaefer", false, null, "Seth_Schaefer87", "AQAAAAEAACcQAAAAEGlWk+XIWLfKafUqUNta9LAQgorV9M0ghr4H+2Y1qNV8a4/GxWIdowwEoFPe73dV+Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19"), 0, new DateTime(1940, 7, 24, 3, 23, 22, 925, DateTimeKind.Local).AddTicks(3264), 48.57818909570000m, "d4f02949-faeb-4a4d-bcdb-ba01d6bdd5fe", "Lora", "Lora", null, "Kunde", false, null, "Lora.Kunde", "AQAAAAEAACcQAAAAEOWIVlNjqKKYSbRUdnFOwIMXW7zu6hjyfjVDs7IHpZP5VizR8iUPvFXy3IOQEzNFTg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("219b0f56-d6cc-46ef-8868-1015103b116a"), 0, new DateTime(1986, 3, 14, 11, 25, 26, 813, DateTimeKind.Local).AddTicks(3651), 74.37368476991740000m, "62718bf9-b13b-468c-b68e-d9072dae86e5", null, "Dawn", null, "Koss", false, null, "Dawn9", "AQAAAAEAACcQAAAAENnqo6LQL4xGfOg64M+JSVPRD0uyfw1tvt01Q8mrQEjoAsL0OG/GoD133URX4YENhw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de"), 0, null, 488.9647574610330000m, "456bd7f5-653a-4a12-871f-30ed856ee6ae", null, "Dixie", null, "Nicolas", false, null, "Dixie.Nicolas70", "AQAAAAEAACcQAAAAEKVmU9gzI65iy9/3JHfGxAYgG0TA/EoRASBTjP+s9Pd44Fy20NvcHy2B2pGxG0Ymuw==", null, "NotSelected", false },
                    { new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9"), 0, new DateTime(1952, 7, 27, 4, 48, 22, 51, DateTimeKind.Local).AddTicks(5561), 924.0217832474790000m, "02cb07ef-a64a-4c28-9c99-9873bc09ff1f", "Lorenzo", "Lorenzo", null, "Wuckert", false, null, "Lorenzo_Wuckert", "AQAAAAEAACcQAAAAECRoWK7htqPEui0AfZqrcG9oPxgYMeKG+Z0GZjRJmKxykE/nxB9bW3Eia0W9EQc7Nw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("24597285-23ce-4296-9004-36d913270ed6"), 0, new DateTime(1962, 7, 26, 12, 24, 22, 388, DateTimeKind.Local).AddTicks(1094), 815.2409592471870000m, "59ccbaa4-03a1-4af7-8a46-40789d53da92", null, "Darrell", null, "Conroy", false, null, "Darrell69", "AQAAAAEAACcQAAAAEIDyO+ZzZrEpcOjcFDTb/OcGU+Ggwe3/X4RjZoN5Ak+2M5f84kIoWIcygiWmKy+A1w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962"), 0, new DateTime(2001, 12, 19, 22, 2, 56, 305, DateTimeKind.Local).AddTicks(7459), 453.5915669020990000m, "f2c809b4-e072-4e3e-9cb9-add9ef521798", "Muriel", "Muriel", null, "Schultz", false, null, "Muriel_Schultz", "AQAAAAEAACcQAAAAEM76p2ftk6dkViYogcnXYRVj51iZabixd7ikutVP5AC9Nl9KvzTTO4eFzWvacIc52Q==", null, "NotSelected", false },
                    { new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa"), 0, new DateTime(1971, 4, 2, 19, 11, 27, 822, DateTimeKind.Local).AddTicks(2254), 307.6895231142720000m, "3501d952-a6e1-45e8-a0a2-fbe645abdeda", null, "Vincent", null, "Marvin", false, null, "Vincent.Marvin", "AQAAAAEAACcQAAAAELYmVnyQuUAAdmD+vOhehhv1VSp0YDDDmXKLXbP4/EMqEWkr/viPbFAW+wtpGEJbAg==", null, "NotSelected", false },
                    { new Guid("253493f6-b3da-4ae0-a428-05a0560043e2"), 0, null, 512.1700493216790000m, "1be3b098-22e5-41cd-b2a5-9ea6009449aa", "Chelsea", "Chelsea", null, "Davis", false, null, "Chelsea_Davis", "AQAAAAEAACcQAAAAEP7JsL5pvoIOZLAvxPNRrTUda/33SLPjWUmt6LuuFNPjC13fuusiV+/2aB2B4v+LHQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7"), 0, new DateTime(1971, 12, 21, 23, 58, 16, 122, DateTimeKind.Local).AddTicks(1975), 770.8493619439680000m, "3cf028c9-cf07-4478-b5ba-fc2d5a7df995", "Zachary", "Zachary", null, "Wunsch", false, null, "Zachary69", "AQAAAAEAACcQAAAAEOS8PaAQl+fO9tXT3U8ZY1aYm1mgzoWV0GJoQKvwWeQS9Mbj7Kz3D+GaA0KPLQyP0g==", null, false },
                    { new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e"), 0, null, 936.0346113921280000m, "95dd63ac-035d-4ced-bb5a-f31cd6b776be", "Hubert", "Hubert", null, "Ritchie", false, null, "Hubert_Ritchie", "AQAAAAEAACcQAAAAELY+fNyvc5GO6H4fd6CncUgmYmrguQKconkjTsZUfhzU3ZW2jWnOx+5wYjQ8cedFoQ==", null, false },
                    { new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e"), 0, null, 824.6745625530660000m, "54949835-7cce-4a9c-acfe-3a2b997b3837", null, "Aaron", null, "Terry", false, null, "Aaron.Terry33", "AQAAAAEAACcQAAAAEPkKPEgxQpIr+q/h45mgJG+Lz+0N7wYSmnCDhLyXihQFj1N8fL07/CvCfU2fSaClyw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9"), 0, null, 271.0458493521040000m, "11fb42a5-3dfa-4b96-b6f0-ed78e698ab37", "Jodi", "Jodi", null, "Gibson", false, null, "Jodi.Gibson", "AQAAAAEAACcQAAAAEHgtzN7i9G1ZV/6LkWvcPpZo0drM50Gk4FVsn9h0VQ0n/ZTnPi2pBUKlPKmDuSECcg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315"), 0, null, 888.7086910753640000m, "d93fe93a-fb3c-4f25-b820-eb8944bb2ef7", null, "Frank", null, "Kuphal", false, null, "Frank37", "AQAAAAEAACcQAAAAEJlyLj3US9dlLUQeSJjcGlieh5nfTP3hDOyTSm0MJCzoTX4iRfGErOtkIdrlakIP8w==", null, false },
                    { new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd"), 0, new DateTime(1973, 1, 23, 12, 5, 38, 168, DateTimeKind.Local).AddTicks(7170), 924.1142621720290000m, "52a0cd57-ec65-40bd-9479-b6357f64e2b1", "Maggie", "Maggie", null, "Bernhard", false, null, "Maggie61", "AQAAAAEAACcQAAAAEPR4g1sgxrj04MyI/ptvNPNRGLhPYZ1mEbsO/OUd0LctsGqwrzmN5oeeK2bsExRX8Q==", null, false },
                    { new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8"), 0, new DateTime(1975, 11, 9, 5, 15, 45, 336, DateTimeKind.Local).AddTicks(3836), 8.557113101412160000m, "e3ee564e-375a-40b1-8cb1-a57d85af9820", null, "Sergio", null, "Lindgren", false, null, "Sergio_Lindgren", "AQAAAAEAACcQAAAAEEkO4SchKdpklhz1s4ZQzVeNd8T9StbjsvnxODm4gfSCR9qlUduMZWx5VkKhEvh7BQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2f049da2-3389-49ff-a450-f063e5a81fee"), 0, new DateTime(1971, 9, 9, 9, 38, 58, 986, DateTimeKind.Local).AddTicks(3893), 279.6712398547750000m, "ba50bc40-147e-482a-8f32-7110b47d22c3", null, "Gene", null, "Brown", false, null, "Gene.Brown84", "AQAAAAEAACcQAAAAEAFN6KMT9I/LFARm3FLymQiiYwPirOLqRfhyfo/80KvFreCcKPQ0c4I5Ab8gDzPv1w==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("302771bc-d672-48ae-9a96-c489ccacf75a"), 0, new DateTime(1979, 1, 4, 3, 36, 32, 755, DateTimeKind.Local).AddTicks(9959), 95.91944719155380000m, "7e492731-0f0d-4918-a777-07e7e6b51b42", null, "Vernon", null, "Marquardt", false, null, "Vernon18", "AQAAAAEAACcQAAAAEJe18vfBRQo1Phajvw0aBi67/y3tlGvRm3EM+pgreQlH0bl/KjVa6ft1ZWw1qiufwQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("31fbc085-c45f-4025-bc26-03836052f67c"), 0, new DateTime(1990, 5, 26, 20, 8, 19, 771, DateTimeKind.Local).AddTicks(9730), 201.9552389935850000m, "dcbf06ed-1e4d-4245-8e64-5fe3838c8101", "Shane", "Shane", null, "Lynch", false, null, "Shane28", "AQAAAAEAACcQAAAAEGwvednk4d+/5tLClJkfv44WbXTrKYNJErWGWkeEN6grFfyPaykxyH0zScvAF9rG1Q==", null, "NotSelected", false },
                    { new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9"), 0, new DateTime(1996, 4, 26, 16, 19, 10, 667, DateTimeKind.Local).AddTicks(2649), 572.1953840614040000m, "cfb2433d-635c-434b-9738-72396eff4e92", "Sharon", "Sharon", null, "Gleichner", false, null, "Sharon54", "AQAAAAEAACcQAAAAEKV74coia5T8ZxBKoQIPAP9V+10/AMtFRx6v1o6+5xMaz36jENNJPS0XCr3oZwCazw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7"), 0, null, 46.24255537996020000m, "329e0590-300b-4181-87d2-2bd1bd4c257d", null, "Chris", null, "Rosenbaum", false, null, "Chris_Rosenbaum", "AQAAAAEAACcQAAAAEHPwiERpdSI23T8xx345oHKfo6szIKX3kFj/8XZ+juiZwNalFhU7yXPgNBRu4NBwjw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52"), 0, null, 52.14796195707630000m, "f7b968e5-a5b6-4c47-a7df-8f8aa302ed01", null, "Ignacio", null, "Renner", false, null, "Ignacio_Renner66", "AQAAAAEAACcQAAAAEM9iRZFapu2nVajOWQmVLpCApF3AUlFlO2Bt34N++eC3MMDCkfRVMQEfAmjbPIhidw==", null, "NotSelected", false },
                    { new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93"), 0, new DateTime(1929, 10, 31, 4, 14, 12, 215, DateTimeKind.Local).AddTicks(5017), 917.7110950967940000m, "d6d6ecc2-dab6-4dda-a903-2aef6bf3bb49", null, "Andrew", null, "Heathcote", false, null, "Andrew.Heathcote52", "AQAAAAEAACcQAAAAEEYaGiVnEvUC+J7zcOJSKjlzVZWPi/jh3lFhj9AcyXP1upuEf5lCKcdb8LNc7Zw0EQ==", null, "Female", false },
                    { new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c"), 0, null, 623.4006121974130000m, "bb2b8ea7-1eb3-4cd3-80ab-cab1d3a3bb2a", null, "Earnest", null, "Bergnaum", false, null, "Earnest_Bergnaum", "AQAAAAEAACcQAAAAEGGLDc6nHmXhXaxoyXwBaAda0MPJ87Gg3cYLJNuDf35OiQ6O+zImx5Wkqijx4za6ag==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51"), 0, new DateTime(1951, 2, 26, 6, 48, 59, 143, DateTimeKind.Local).AddTicks(4294), 172.9699425061630000m, "6adb0bff-bbca-4261-8fa3-a6a630485d81", "Sonja", "Sonja", null, "Stracke", false, null, "Sonja47", "AQAAAAEAACcQAAAAEM8PgDNxMU/F8V3D6ztblq6ta85dUFzoWvzlgF5taCHv76x8dtgX2+J7OUve9m11GQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b"), 0, null, 21.30204237075520000m, "a711fd6d-289a-4f42-b257-113720cb3ce6", "Amos", "Amos", null, "Ledner", false, null, "Amos.Ledner", "AQAAAAEAACcQAAAAEJMIG/ZkZlSLbwUUtg13dy+qcFY/2fT44QVU/cqhFnXrrKUPJk6UhESqLdzBVYOjvg==", null, "Female", false },
                    { new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304"), 0, null, 681.3555120353420000m, "93d31030-1472-4f54-a954-04d085df0ea3", "Bernard", "Bernard", null, "Brown", false, null, "Bernard_Brown7", "AQAAAAEAACcQAAAAEPjQVh0ZmKrvnEtKnFI4yldiZZ1UUZqmxn2zqKZQMTJeEVH548+1PzeujBnpzYNZrg==", null, "NotSelected", false },
                    { new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec"), 0, new DateTime(1952, 6, 9, 19, 15, 31, 841, DateTimeKind.Local).AddTicks(3974), 904.8253013724970000m, "86965d51-77f7-4991-ab17-ff5a9ae6f07b", null, "Roderick", null, "Veum", false, null, "Roderick61", "AQAAAAEAACcQAAAAEAfh69oE8i7FA2On1tHokXziY1rKbY592D4RfoaIrURHw+JiTpqZmSWCpoaf3oMo/A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104"), 0, new DateTime(1958, 11, 10, 0, 57, 29, 514, DateTimeKind.Local).AddTicks(3260), 202.6902447484370000m, "e9612b38-9bdf-44e7-9871-09a9a6351518", null, "Stephanie", null, "Kihn", false, null, "Stephanie_Kihn", "AQAAAAEAACcQAAAAEOumgTOWMvlRG96Sbg1FiMyQ8H1F7kk4YofiiPSa6lfojR83Sn9DeyFtSJdOkcoEsA==", null, false },
                    { new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235"), 0, null, 703.4790121617950000m, "847470de-d52a-4c47-845a-ce423da3ffd4", "Ana", "Ana", null, "Fahey", false, null, "Ana_Fahey", "AQAAAAEAACcQAAAAEMkcwp9/prxfBOvIQTHHx7fagghI8d9AzPe/oGL+0BlzdAy7xps9/ZZVWANV80qVXg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35"), 0, new DateTime(1997, 10, 9, 8, 38, 26, 304, DateTimeKind.Local).AddTicks(4021), 134.4143199252490000m, "9f1531af-1840-4ec8-9ec0-52878eeb609d", "Jacqueline", "Jacqueline", null, "Little", false, null, "Jacqueline_Little16", "AQAAAAEAACcQAAAAECDEGvNh0I21PT5SU1DSlgBiVvcXM7Om7pEDMszItVyWBBOiZJJDht+6qb5lx7nHWw==", null, "NotSelected", false },
                    { new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e"), 0, new DateTime(1989, 10, 1, 22, 44, 51, 511, DateTimeKind.Local).AddTicks(943), 223.2054335265560000m, "57d9b6bf-0fdc-458e-bb7b-7d760bba2e1e", "Dana", "Dana", null, "Hessel", false, null, "Dana_Hessel16", "AQAAAAEAACcQAAAAEP/azQWJJytm5XnBBl5l/HtggTJFIqRsKShvkRKt181f+PHt0vymhuscaOw7d1Chdw==", null, "NotSelected", false },
                    { new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f"), 0, null, 619.6202204224410000m, "5168fea3-d41d-4bc6-b040-8fdf59f14faa", null, "Gloria", null, "Senger", false, null, "Gloria80", "AQAAAAEAACcQAAAAEOsI9YuAdbAd6KxRHoOxDqW1ljU8QWm0dGfc0qYljlpvga+rIamHNHRFZZ7lmjd0WQ==", null, "NotSelected", false },
                    { new Guid("42395499-af46-4c51-b3e8-47c97d474f85"), 0, null, 25.29387298836010000m, "c1f27c44-65da-42e9-8d4d-3eb778739ec8", "Edmond", "Edmond", null, "Orn", false, null, "Edmond_Orn14", "AQAAAAEAACcQAAAAEGjXMkwwkLhJCOPgufyf0hK5c5D2MkY0zuML62cbZHUhXRddsy6Hkxp9Mk4dDY0FyQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9"), 0, new DateTime(1945, 6, 5, 6, 3, 37, 269, DateTimeKind.Local).AddTicks(9660), 159.7758675155210000m, "7616edfb-8712-4182-8060-be31d0a69826", "Donnie", "Donnie", null, "Wolf", false, null, "Donnie.Wolf", "AQAAAAEAACcQAAAAEJiI+l9N/Gcg55guBBBO6H7Wuqx1k+4lnKP665ByFZFo3Z0vEaiCdgiSgL6oYidWdA==", null, false },
                    { new Guid("45917911-5af0-4724-8a58-1fe212041071"), 0, new DateTime(1991, 2, 8, 13, 37, 6, 511, DateTimeKind.Local).AddTicks(7276), 505.0135918830520000m, "8be84795-67c5-4ed5-9604-99ff045f8f96", null, "Lana", null, "Jacobson", false, null, "Lana.Jacobson", "AQAAAAEAACcQAAAAEGYZjBhcMowVZCwnY5E169dLzSc1IymEEKeYj7Uz53rnHo9uxowYoJxBNWh0f/6TEg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("45dee853-0743-493d-b80b-c81b944cc529"), 0, new DateTime(1934, 9, 12, 23, 49, 36, 154, DateTimeKind.Local).AddTicks(6047), 578.0893379303470000m, "98712eea-b486-428f-a429-a4822d9de7a2", "Jeanne", "Jeanne", null, "Herzog", false, null, "Jeanne.Herzog", "AQAAAAEAACcQAAAAENlfuGoyGQEVkTbXnrDzfAlQKK7E6w7K5SnzHgP6Du8/d5QmOzxDnEfLwGbDuEE9nw==", null, "Female", false },
                    { new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3"), 0, null, 736.1983841786460000m, "df51e40d-48ed-46a9-82c9-dd822e71e0c5", "Patsy", "Patsy", null, "Erdman", false, null, "Patsy.Erdman43", "AQAAAAEAACcQAAAAEPCF7jgUbg8iB2UiBRW+9Y4ZcmxkBHaBGqk47SavMb5HDNOGa9QADjpRCF2W36xyWg==", null, "NotSelected", false },
                    { new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4"), 0, null, 941.5999167358150000m, "e39ec79a-5bc7-45df-9d9a-39337bf714ad", "Myron", "Myron", null, "Satterfield", false, null, "Myron_Satterfield60", "AQAAAAEAACcQAAAAEJBkXF9cyqrgtzStYr3r1pAZratI3mPFq29deIKmQX45ivpyKJM78sde5dWrdOSDgA==", null, "Female", false },
                    { new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c"), 0, null, 309.9626548857940000m, "0941cca8-912f-4702-89d5-d5afed93e5ae", null, "Debbie", null, "Jacobson", false, null, "Debbie_Jacobson72", "AQAAAAEAACcQAAAAEOTPKD6A2/bIHRFA979T8JwUD+lUG6ba946Ca6dsVlLAiHCv55qLWLSwzzXi65gpBQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1"), 0, null, 602.9868953446450000m, "f2ebd820-8a9a-41e3-8ed7-b3eeb4ccd57e", null, "Arthur", null, "Kuhn", false, null, "Arthur70", "AQAAAAEAACcQAAAAEHiRA3rHBuJB1YX2ZOX/Rhdruaa4B+8sI2UsO6Y0qFxeTJkJ2eaxxZqZ4b47wjBb0Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340"), 0, null, 231.356311198140000m, "4d9de25b-3d56-4807-82e4-784b7040d456", null, "Linda", null, "Lehner", false, null, "Linda_Lehner", "AQAAAAEAACcQAAAAEP0Ho2ps9My/JIkvXR+5QITj6WDzukhSHsfcsjHGpluPIVADrcQzGuAruUKRuMCAcw==", null, false },
                    { new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4"), 0, new DateTime(1990, 4, 26, 21, 50, 53, 25, DateTimeKind.Local).AddTicks(7467), 778.5431337272190000m, "d23c116d-638c-4f9a-9fdf-b5f06548d2a3", null, "Clyde", null, "Cormier", false, null, "Clyde40", "AQAAAAEAACcQAAAAEFxxN5IaWhEW3jXVN/fiJJpEn6xDfZfLVwcy9YOJxChktCX2VLMIqThGS4Djr1dALQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d"), 0, new DateTime(1958, 2, 2, 0, 24, 6, 68, DateTimeKind.Local).AddTicks(8075), 199.2800256300790000m, "ac2e15c8-9afc-4c1b-9b65-421eb84b2ea6", "Annie", "Annie", null, "Hilll", false, null, "Annie.Hilll", "AQAAAAEAACcQAAAAEPwop+nwOAs24Fdr8pf/RANBLEPxiGCrVRPr0nOopVRnBA7RVNXtXWt532q/GYVHlg==", null, "Female", false },
                    { new Guid("48cace70-1194-4581-914a-6aae6159826d"), 0, new DateTime(2000, 4, 13, 16, 3, 49, 461, DateTimeKind.Local).AddTicks(3644), 860.0199596699050000m, "76790c24-92ba-44c8-80c4-25750d4a06a2", null, "Elisa", null, "Ryan", false, null, "Elisa.Ryan15", "AQAAAAEAACcQAAAAELCEQPMsXId/JS0r0po6GxCJM+wnJYZnlIEXBQebc3wXdHIvgMflqB0bWAL0gINPnA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03"), 0, new DateTime(1957, 10, 25, 14, 29, 13, 78, DateTimeKind.Local).AddTicks(1070), 673.2885717615480000m, "4c24b46b-188f-4403-b4f3-3b31f88568f2", null, "Jeanette", null, "Lindgren", false, null, "Jeanette62", "AQAAAAEAACcQAAAAEE/JBBxrmbX347sBFimtPHUKdrim4/VQm+ZHgUk+HN0xZSQsJuEAz6o9juDqiTbztA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4a21367f-81c5-4947-b939-b44d17e67434"), 0, null, 769.6258283528670000m, "26b285e7-e84f-45fe-a496-bc766d21f720", null, "Blake", null, "Krajcik", false, null, "Blake94", "AQAAAAEAACcQAAAAECkuYDNkkMEAEqCr0Sevpt8F4tzmKyzJKoQ3n5BRx3lG1w74I8gkBjA4/WXDnvUwfA==", null, "NotSelected", false },
                    { new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6"), 0, null, 540.8348028911650000m, "b0a01751-17bf-4789-a8c4-61e788f7f25a", "Terri", "Terri", null, "Bauch", false, null, "Terri.Bauch69", "AQAAAAEAACcQAAAAED5+8lC3eVDQ0YPkjEhvrynNlaFpdlFGsk52Q7E8PIYub0dmf6AyQ7jhD/kkD9Rrxg==", null, "Female", false },
                    { new Guid("4b9baedf-008d-41e7-9781-815a81805e9e"), 0, new DateTime(1954, 12, 5, 22, 53, 17, 129, DateTimeKind.Local).AddTicks(3291), 700.2666869330000m, "e3cb83ca-0fec-4a1f-a2c4-4aa902714ad0", "Joel", "Joel", null, "Buckridge", false, null, "Joel_Buckridge", "AQAAAAEAACcQAAAAEJmcI0ZGCQa8vPvn82NBmVEW2j3xu5roSh3KlPel/rXP93bKTgXcLy4tVHumT54Xxg==", null, "NotSelected", false },
                    { new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c"), 0, new DateTime(1990, 4, 21, 12, 56, 49, 321, DateTimeKind.Local).AddTicks(62), 597.4657733423080000m, "b28ea4e1-b5fc-48c2-9411-90d022c88709", null, "Sam", null, "Davis", false, null, "Sam_Davis1", "AQAAAAEAACcQAAAAEE6vVnOSKw0EEtxY6wCdQEn3qWEuzPYC+50XPGWwBcHK3OoWZKgtuiBPwtvij2IaXA==", null, "NotSelected", false },
                    { new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de"), 0, null, 316.5353104683080000m, "5ab63644-7f8c-4d3e-a76c-407898122803", "Blanche", "Blanche", null, "Terry", false, null, "Blanche_Terry25", "AQAAAAEAACcQAAAAELJjX7GY6D/jQRo1q2vhIIunXedVJDY1eqk5yTHwspw8t627j7PLbnLQhSaKCbLNHg==", null, "NotSelected", false },
                    { new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f"), 0, null, 424.475349219590000m, "c2d6ae63-56df-408c-9773-ec92ba3e9f51", "Allison", "Allison", null, "Marks", false, null, "Allison.Marks", "AQAAAAEAACcQAAAAEHPmvU6/7bcBx7RMVMg4GO/6vu6ccMzSZWuKZPZmwhFV+QNluwplUvzcm7eey70D2w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9"), 0, new DateTime(1947, 3, 23, 10, 28, 9, 598, DateTimeKind.Local).AddTicks(2657), 326.2547767774560000m, "c72cbc47-8aac-4620-b8d5-6223454d60f3", "Cora", "Cora", null, "Sanford", false, null, "Cora_Sanford60", "AQAAAAEAACcQAAAAECji4G3gzER7s+3qGeN5f5IDc/pvhMfTVw/IaY97MjoA3X4kQAhvkWA3GEUBO6GplQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7"), 0, new DateTime(1925, 12, 16, 5, 36, 47, 501, DateTimeKind.Local).AddTicks(5146), 129.0767014701690000m, "aa1b1b82-c6a7-4ed3-8c79-1796633762e6", null, "Erma", null, "Langosh", false, null, "Erma_Langosh", "AQAAAAEAACcQAAAAEMbG3Q/HiVIReWt30vUHKujlOTrsfQkA5QoZTkoKw1xdVxXa2uPVsx0Wx6UfGZ+L6w==", null, "NotSelected", false },
                    { new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561"), 0, new DateTime(1985, 8, 11, 7, 12, 58, 458, DateTimeKind.Local).AddTicks(3275), 959.17317211360000m, "e852c0aa-8386-4da7-b3ef-9fed9afa38eb", "Nellie", "Nellie", null, "Goldner", false, null, "Nellie.Goldner", "AQAAAAEAACcQAAAAEHqUCTn5FCmFfez9hUfNqmTw51rUgSa0o6dQId7vZY13up9emh53GpwvxJKKsBZgVQ==", null, "Female", false },
                    { new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), 0, null, 554.0688874990000m, "de8fb600-7bdd-4ac2-9122-052064580138", "Carol", "Carol", null, "Schneider", false, null, "Carol.Schneider52", "AQAAAAEAACcQAAAAEH4mYo3VdGPwsiOOosCsmxq3n6Wc++AwDTjMoZ2/N7iaCECeqdplpjeTUWsKBsOhtQ==", null, "Female", false },
                    { new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086"), 0, null, 681.6315529450160000m, "2f914f1b-5283-4fc5-9cb0-99111de00948", "Ada", "Ada", null, "Waters", false, null, "Ada.Waters", "AQAAAAEAACcQAAAAEAFyYqqYzRXDiZKjZQInY1g98Qetc5yOxG6FVq1/yFw0JyQKD7xsO1WlibOOHX9HCQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("53078823-cbdb-4f6c-b393-57486464289a"), 0, null, 953.5265111727210000m, "e1351691-918f-4157-8d9e-9523d136c358", "Elizabeth", "Elizabeth", null, "Hayes", false, null, "Elizabeth.Hayes", "AQAAAAEAACcQAAAAEBauLjLnvFWPR5263RHvDcD7vEwjETQz6WvHfJ2Jz4jNTL9SlwHiBRISteHYpeO0Mg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9"), 0, new DateTime(1960, 4, 1, 21, 9, 6, 181, DateTimeKind.Local).AddTicks(324), 406.8449959004850000m, "fe442152-3e6a-466c-80f2-e82bf498d2f1", "Israel", "Israel", null, "Kuvalis", false, null, "Israel_Kuvalis", "AQAAAAEAACcQAAAAEGfEIOcuSnY9jbNFM4eatJOYd/QI6FGVXqMlS2GkT6hKVi5Fk4glNtpi1J186763Zg==", null, "NotSelected", false },
                    { new Guid("549f6398-46f0-4e11-bc59-43c056078f96"), 0, null, 968.2512442517810000m, "eeef0ebe-559e-4fa4-8e60-c76b0b1f3e0b", null, "Erika", null, "Schneider", false, null, "Erika31", "AQAAAAEAACcQAAAAEAToZSTiwSYipOcuRmXsYKQubUgMZxDj4AQ/N7Xaw4XIKz32S04OrnsbTxuE0obt6A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("55212ad4-b8ea-4552-8605-b121512b19ee"), 0, new DateTime(1942, 6, 19, 1, 18, 30, 525, DateTimeKind.Local).AddTicks(442), 754.9597633452320000m, "52bea62c-fa5a-4e96-accc-a2b1427d9dcd", null, "Sarah", null, "Emmerich", false, null, "Sarah_Emmerich", "AQAAAAEAACcQAAAAEPHejZbh8Tz0qIiMGSWdmp/NmJx3lFSyUH/ISnXPq64/0pzbS/i3CLVHJuAGHfqQYg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b"), 0, null, 111.4964337437640000m, "5f18e140-7d5a-467d-8ee0-fae520afee2a", "Bradley", "Bradley", null, "Grady", false, null, "Bradley.Grady", "AQAAAAEAACcQAAAAEFBNp2RjLwgUI09mY68lnciL+kiFxf0pDhObWhkbn+vsYrvUd/i1mdGSHTc4iovIvg==", null, "NotSelected", false },
                    { new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1"), 0, null, 477.6319123361830000m, "42be24aa-d1d5-45ee-82f2-a7f4e2355024", null, "Faith", null, "Herzog", false, null, "Faith48", "AQAAAAEAACcQAAAAEMjQbEfpeywvI31pe9DUdJhqmEyOM/0i9xMQLbN/GbAaqVX5mIuTg5VQOQx5De5SLQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3"), 0, new DateTime(1956, 6, 8, 14, 4, 57, 344, DateTimeKind.Local).AddTicks(6736), 864.783475955550000m, "1958da8a-d0b3-4052-8c7a-9153eef768ab", null, "Wilbert", null, "Kling", false, null, "Wilbert57", "AQAAAAEAACcQAAAAEIUdq5rRRkYMyA2Ojrd9OsOnzTgiNhzutBuNzWtBwgbrSY7l5IGG1/zBCmdZbuIqxg==", null, false },
                    { new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be"), 0, new DateTime(1944, 7, 23, 22, 9, 23, 583, DateTimeKind.Local).AddTicks(3535), 849.2651812928360000m, "27dc2c1d-164a-45da-ae49-e8f07f9fd35a", null, "Anita", null, "Ritchie", false, null, "Anita43", "AQAAAAEAACcQAAAAEIFB3nlCwHPS8YnlS7l48TYnQj0Z8jbhtzgL/GPbLPQU9Nq0mGjEfrNPzKN78FjtRg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c"), 0, null, 3.414415245142410000m, "bfb287e5-bbd4-4111-8b48-18e5f8e6b2aa", "Jerald", "Jerald", null, "Prohaska", false, null, "Jerald97", "AQAAAAEAACcQAAAAEDkjBICzRTnVbON4lO6AqB8XYojnMighiL7RKqx9xK9DRElaR/fGgQxyXs89XGWG+A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546"), 0, new DateTime(2002, 5, 12, 10, 15, 57, 210, DateTimeKind.Local).AddTicks(5150), 490.6940929880390000m, "ea211409-88b6-4801-a82a-46be3b75458d", "Betsy", "Betsy", null, "Robel", false, null, "Betsy95", "AQAAAAEAACcQAAAAEPI9m/+o+je0U86YQlJn1OLSZ0jbh+PMlYopPOunAwRKmUriH8N5oHcUlYSjYA3RUw==", null, false },
                    { new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2"), 0, null, 440.3010146547550000m, "09726e85-5436-4e08-b1e8-5405b9f3f9fa", null, "Cameron", null, "Schmidt", false, null, "Cameron.Schmidt4", "AQAAAAEAACcQAAAAELLwgP7AgvvyXEakkDVqjjUsAapqjhuXvZ5CjLdeNKZbG7n5q7Pnv5aYwyfBJ9Ls9w==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2"), 0, new DateTime(1931, 5, 11, 18, 4, 47, 421, DateTimeKind.Local).AddTicks(2461), 554.6363754908620000m, "d4fef72e-afc7-41ee-8047-8d083f0eae08", "Fredrick", "Fredrick", null, "Feeney", false, null, "Fredrick47", "AQAAAAEAACcQAAAAEKTB89pc9FbqKWbKN93LBac19kyOSAjUiHG9D1C3ZNI6TC1V+zGk5cyvCQjaEPcPmw==", null, "Female", false },
                    { new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528"), 0, null, 282.7781619971510000m, "813cfffe-3c05-49c3-8a76-2cf745e891f2", "Kari", "Kari", null, "Doyle", false, null, "Kari52", "AQAAAAEAACcQAAAAEHmDWKmwbE9fflklRJRq/cAO7Wdm4UNfStAcr9TpHlV/43lLEQYmIHBUjJcFbrxBTw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664"), 0, new DateTime(1971, 3, 4, 2, 14, 47, 250, DateTimeKind.Local).AddTicks(1713), 424.2705323517450000m, "c6d09881-ea30-4a89-809d-ffe6d4d1d87c", null, "Nichole", null, "Ledner", false, null, "Nichole.Ledner", "AQAAAAEAACcQAAAAEMbUKjfhsZrv+WHZQ4GNDu7PPayQ/c/krArAg64yIU9P0YxC938b8RKWFe2i6Yc54w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2"), 0, new DateTime(1960, 11, 22, 21, 34, 56, 790, DateTimeKind.Local).AddTicks(6075), 820.9376695573830000m, "204c7e11-6563-4eec-8722-b7f9cedda493", null, "Woodrow", null, "Collins", false, null, "Woodrow25", "AQAAAAEAACcQAAAAEAMjCwR2EbQ3Ts67ya1k55YSLxeSvwJ+ZygddnQKq7n+3ARKaYqGAVstk+LWDHUaGA==", null, "NotSelected", false },
                    { new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139"), 0, null, 296.5476053509540000m, "c9f4d317-c536-40ce-88a7-0b2b9d0d71a9", "Georgia", "Georgia", null, "Schaefer", false, null, "Georgia.Schaefer77", "AQAAAAEAACcQAAAAEDQ5b2fEtAyWRO0tR8G6GApXvV2j37iDLgIWEJv1MpUn+tP7FrAMDdsbD2GqLFu+XQ==", null, "NotSelected", false },
                    { new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff"), 0, null, 159.8562971336240000m, "a22f361a-fffa-4de0-91c1-0ee481b2191b", "Ramiro", "Ramiro", null, "Jacobi", false, null, "Ramiro8", "AQAAAAEAACcQAAAAEC2LqnOSTk3hoBAHRQrlSD5IzlYsk/ORlIDFXsfbymtBOQlDdbyGwlV3gFOZQzcHfg==", null, "NotSelected", false },
                    { new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6"), 0, null, 981.0608936538280000m, "4f9ed45b-cc0f-4f10-8b79-4c837d3d3eae", null, "Emmett", null, "Stracke", false, null, "Emmett28", "AQAAAAEAACcQAAAAEKx6FMErGZL1U8JTO9SDPC84ntIPQWpV/M2VsxIKpzVuXjIca7OI4gB4sJV+1MDdJg==", null, "Female", false },
                    { new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10"), 0, null, 463.1722598517750000m, "494e37f6-2efd-4b91-9af1-520b13fb2b09", null, "Claire", null, "Gleason", false, null, "Claire_Gleason", "AQAAAAEAACcQAAAAEEK4k7MAkbxRso4qpJfqZpO7go3PjUrTUhImPyO8+R8haIUEodmL9gomSws8RfVetg==", null, "NotSelected", false },
                    { new Guid("6224405d-f9d8-407b-9f81-847223041784"), 0, new DateTime(1961, 5, 5, 12, 1, 32, 471, DateTimeKind.Local).AddTicks(9008), 396.5441206649020000m, "954bcfe6-332a-499c-8016-53f2904a0c55", null, "Mathew", null, "Morar", false, null, "Mathew_Morar", "AQAAAAEAACcQAAAAEFYM7TQfMNZPQCnBtNIt9rw7zR568fmYBnSzJ9W1n4lQww8dh2tMwrmG5l8DoUxIvw==", null, "NotSelected", false },
                    { new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0"), 0, new DateTime(1983, 4, 14, 15, 8, 3, 60, DateTimeKind.Local).AddTicks(1923), 896.61675254190000m, "137533ac-59e4-4163-8082-423fb1e79ac6", "Pamela", "Pamela", null, "Schinner", false, null, "Pamela_Schinner78", "AQAAAAEAACcQAAAAEJsN0GUz82PDslitR51MgLeFW2/097mkvBlaHYBZrO+SSw6nPwyQWTOS3tmsI6PkwQ==", null, "Female", false },
                    { new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9"), 0, new DateTime(1981, 12, 28, 0, 0, 10, 995, DateTimeKind.Local).AddTicks(3279), 205.3112327287950000m, "6709d4d6-5993-424a-8f9a-6b457849648e", "Tony", "Tony", null, "Crooks", false, null, "Tony94", "AQAAAAEAACcQAAAAEJkImVO8YX0x/VJeLtJrMSWFI5Zx028uwrKWiMcvECetO/JdgYxZ5QFHYij438AfMQ==", null, "Female", false },
                    { new Guid("63684041-907c-4654-ab87-5f0c11008f52"), 0, null, 621.2546858215590000m, "8611354e-dfa2-4732-8865-9b6f1661387e", "Vickie", "Vickie", null, "Osinski", false, null, "Vickie.Osinski", "AQAAAAEAACcQAAAAENDp8xw5QkLnJ1guq8WpN+xk5PozJ6YOICt9dHA2BSDu+6Fo7On8H+UPwOf4LKaQ8w==", null, "NotSelected", false },
                    { new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce"), 0, new DateTime(1941, 7, 12, 9, 49, 9, 765, DateTimeKind.Local).AddTicks(653), 415.6801939450750000m, "4a32b7ea-b0a4-4cc4-bf6c-e83f72fc6970", "Veronica", "Veronica", null, "Rosenbaum", false, null, "Veronica40", "AQAAAAEAACcQAAAAEB0TyUn7/QfT1ZiH/LF2IgpAhHj1JWqQ0HqSYZ0WCI5Sfahc8nASwhp/lv78gzQAnA==", null, "NotSelected", false },
                    { new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6"), 0, null, 120.9718735637680000m, "0029b1c5-2d4c-4174-a1b4-8bf06ee38bd8", "Meghan", "Meghan", null, "Kuhlman", false, null, "Meghan_Kuhlman80", "AQAAAAEAACcQAAAAEAVbjVsL06UueRmjWwLC8Hp84GyL2gJ2OE8NqmoAPo9ltL2wHhLol2ZZwS9aT99Vag==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535"), 0, new DateTime(1975, 8, 22, 14, 17, 36, 826, DateTimeKind.Local).AddTicks(6152), 317.7446051120570000m, "1ffd8831-fa46-4e6f-9034-a7ccbdb00d67", null, "Candace", null, "Oberbrunner", false, null, "Candace45", "AQAAAAEAACcQAAAAEGd1D8KaKFVjNMwDZL0zcp4hvXwmG7pL1LZgQ0hAzcuS+nWrWV0FFFJ7pP3UZ5XLrw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("66bde12e-086d-4150-9c7a-89ea75047f12"), 0, null, 387.7268963973120000m, "a5c848dd-54fb-4846-9646-00cc8f41cc98", "Armando", "Armando", null, "Hudson", false, null, "Armando75", "AQAAAAEAACcQAAAAEHLiAd971JRa+11qkRenTDq5HZKt5ZUl6yGPEPXwAgF0Oloeoc+unux/5Rk1hiwwgg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("671bbcc1-9768-4630-8a24-d7626303ad52"), 0, null, 869.261625972280000m, "2d5717d5-4e77-4bfc-82bc-22ce1da7d682", null, "Kristy", null, "Hahn", false, null, "Kristy72", "AQAAAAEAACcQAAAAEBRD5XfKjnTjcrh8iZqxCyGosiWEIDE6l3thEJzQlnnDT8/88kXIwJ5gGBzQfhhb1w==", null, "Female", false },
                    { new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d"), 0, new DateTime(1989, 10, 29, 17, 40, 6, 487, DateTimeKind.Local).AddTicks(6260), 248.567056782740000m, "0eaef963-8b61-48af-bff0-7176936484b8", null, "Karen", null, "Frami", false, null, "Karen29", "AQAAAAEAACcQAAAAECLBByGYzVSPHWZmlm587Y9CaxrIEtC5eg855h61qNTBOV69iyNiCHBo3ivgGswDXA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1"), 0, null, 665.84948266050000m, "2553525a-c054-4a01-afc0-a4cf3cdb3b52", "Meghan", "Meghan", null, "Wiza", false, null, "Meghan.Wiza4", "AQAAAAEAACcQAAAAEE53ry81k+8fMG/i4ldXGSZYx4HIE2EKz/2kxlqE5+KafY7EG6RxNtw3LtxmptMe9Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6c7090cd-7244-4437-b460-88c7027c78f9"), 0, null, 117.4793412715180000m, "fe63a6b8-cafe-4e67-95d0-dcdac54351ac", "Kerry", "Kerry", null, "Johnston", false, null, "Kerry_Johnston52", "AQAAAAEAACcQAAAAEJvVok+AyJW/B6HI0okE8y7YLSRSoQHeUzXMLTlCQ/pYmmWATEC9NpzvoX9ZCpjBew==", null, "NotSelected", false },
                    { new Guid("6d717976-193a-4962-947b-f15277ce537e"), 0, new DateTime(1989, 6, 5, 3, 34, 40, 902, DateTimeKind.Local).AddTicks(8050), 6.98611611115330000m, "cb6bc6d7-415f-4132-9269-c815e4bea36e", null, "Lance", null, "Hegmann", false, null, "Lance93", "AQAAAAEAACcQAAAAEASMko1wN7v1U+VNtkDOHZvru3jOLb11GuzfzLF4oU+tV3kIYSvX8SteSzs4H3oLzw==", null, "Female", false },
                    { new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1"), 0, null, 632.1709688141130000m, "8b84a8e0-d62b-4fe3-b535-c285aff34206", "Alice", "Alice", null, "Spinka", false, null, "Alice80", "AQAAAAEAACcQAAAAELOp+1XQvttvqUWmq5A0yS4cy/bxC3SCt4h7TQM/FThpU7CW/taHJapK5XhLly46UQ==", null, "Female", false },
                    { new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440"), 0, null, 876.3972788421930000m, "0f2670fd-0411-42d0-9f47-30878446512b", "Julie", "Julie", null, "Wilkinson", false, null, "Julie_Wilkinson57", "AQAAAAEAACcQAAAAENQb703GtUTIqMnlwKCjpyfxR+THJ+Oh16K920IygaCiWKQWVGMFISh49aojofyOEQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a"), 0, new DateTime(1937, 10, 2, 21, 45, 27, 385, DateTimeKind.Local).AddTicks(6978), 15.39320294390830000m, "071e0656-d58e-43db-938a-4be1a87e2554", "Kristin", "Kristin", null, "Hudson", false, null, "Kristin.Hudson62", "AQAAAAEAACcQAAAAEAV/mBWBFPPowTkBu8GVofH5sX7YkzMCNQeO3J10/Cc4ootXbSyu7lzm885vgVG33g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d"), 0, new DateTime(1961, 9, 7, 3, 31, 2, 163, DateTimeKind.Local).AddTicks(8914), 372.909627718940000m, "99fe9373-32a5-4a9c-9e65-05366dd2b0e5", null, "Justin", null, "Skiles", false, null, "Justin43", "AQAAAAEAACcQAAAAEDX4rdkh9iX2/So3lRrINEa3BSURiQGhMQeLSHTLnNK+hGTG2D/DNP20IMJbbcnf2A==", null, "NotSelected", false },
                    { new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434"), 0, null, 432.2997441191620000m, "63aabba6-9a66-44b0-ba39-4d3a4f138e42", null, "Verna", null, "Kiehn", false, null, "Verna.Kiehn", "AQAAAAEAACcQAAAAEBT2RqQGBUy33rs21OzC2SkDBaCfiu1qRJpHiu7EnEV4CAWLH/XvGUZVeub519Pf+w==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d"), 0, null, 342.7340086026670000m, "30c5a823-2ccd-4c32-b813-98f95bcda33b", null, "Stacey", null, "Herzog", false, null, "Stacey_Herzog89", "AQAAAAEAACcQAAAAEFPwx429CtacDM7z3QoaoiYfVcHH8n4F8+F2bE+aG3Tj8+eWIikH2j8WA6RW2DI23A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd"), 0, null, 737.2760063131380000m, "bb9591c6-12b5-49e2-8956-a442fb2d8fd1", "Tina", "Tina", null, "Wolff", false, null, "Tina_Wolff44", "AQAAAAEAACcQAAAAEKixM1ZkIAYI2hAvLr218qwgLwqOEpPucYGcijTSVZ4Cu09N0FQutD3GvjbGbSM7LQ==", null, "Female", false },
                    { new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b"), 0, null, 696.3215834562110000m, "5658240f-a6b9-430f-890a-877707db1e1a", "Laura", "Laura", null, "Wolff", false, null, "Laura.Wolff44", "AQAAAAEAACcQAAAAEFPX3CkcOTZ0ZvZnE9qPAXfL1PG02lhfiNDEG8ToYJZgHVCqEaetgYwxug/1e74A7Q==", null, "NotSelected", false },
                    { new Guid("7156fae1-f350-4998-b43f-3d5664953dc8"), 0, new DateTime(2008, 10, 4, 18, 27, 3, 180, DateTimeKind.Local).AddTicks(9724), 170.3040124928270000m, "43ae9892-f15d-40a7-97d5-9787a56f8433", "Janet", "Janet", null, "Kessler", false, null, "Janet4", "AQAAAAEAACcQAAAAENxdxRFLlIl+eh2txgQ2JE+saotpBtieYwQm5dkHZ19CAeVr1riA8F9pKfgOyV3hYA==", null, "NotSelected", false },
                    { new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5"), 0, new DateTime(1929, 1, 29, 15, 29, 4, 99, DateTimeKind.Local).AddTicks(4424), 564.6070580851760000m, "4c8380e5-d5a4-4dc5-923c-497c6a2be1da", null, "Lola", null, "Huel", false, null, "Lola2", "AQAAAAEAACcQAAAAEEgEdEM4kvXIVD0u8X3cDJ029O/vw1Spt9dlBu+HSaNBTwfRI+uNTq9dYerJbmkoRQ==", null, "Female", false },
                    { new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2"), 0, null, 992.3083858730060000m, "55d11659-b331-46f8-bd2c-b7ad2102b835", "Greg", "Greg", null, "Anderson", false, null, "Greg.Anderson", "AQAAAAEAACcQAAAAEOft8MdrCWLXVSjEQCcc1Aj3Bto5S5Q/qEdbynmoZbNOAmAMBaYoHSq8birCNrSgQg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502"), 0, null, 175.8176430185020000m, "fbe82f89-b35e-4f33-b7e9-8cbc1cb5a083", "Ross", "Ross", null, "Cummings", false, null, "Ross.Cummings", "AQAAAAEAACcQAAAAEB1Uo1ThespL54cX86jcTR05RLCLaVjA7I4BPKANiFCSsqYXxQnPxUW8Ick/UigtlQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5"), 0, new DateTime(1987, 7, 7, 8, 33, 35, 114, DateTimeKind.Local).AddTicks(5933), 739.3680657356610000m, "79fae7a5-6d20-48ad-9898-de4de5477583", null, "Jackie", null, "Mosciski", false, null, "Jackie49", "AQAAAAEAACcQAAAAEIKHhO1zq1RWRItrTaJ2qkqStV4Lop6F9VC/udbJPRz3lEtr9e5O17uNVStAOGazSA==", null, "NotSelected", false },
                    { new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77"), 0, null, 588.4110481613270000m, "0fb17542-97e4-406b-bcd7-62841235ca90", null, "Wayne", null, "Gulgowski", false, null, "Wayne_Gulgowski", "AQAAAAEAACcQAAAAEHq/+u0D3w7ExAwcXa2EQOpoD4k4K+fFsdWvbW8mS+2ZamqqxICUCOPm+H8nyWAtbg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400"), 0, new DateTime(1986, 12, 29, 12, 46, 3, 744, DateTimeKind.Local).AddTicks(3779), 772.9395928283840000m, "71e6fa6a-eda9-466d-ad1b-8fbb754795f6", "Roy", "Roy", null, "Morar", false, null, "Roy3", "AQAAAAEAACcQAAAAEBGP3Ex4u/hG5gAltPJSsFa2dB9RJ3yKuSygaNFUqBupLd8nzzBkV8foL/J+zK8DOA==", null, false },
                    { new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef"), 0, null, 762.9789301349580000m, "e68bf5c6-6082-4f19-8fbe-d52cab4ac35d", "Sergio", "Sergio", null, "King", false, null, "Sergio_King", "AQAAAAEAACcQAAAAEDrouwsBP5Xb3hA675AU5g8qP5t7xxYDWSBhSXcMA7OgU0ZIVIWWna4UvoGEGC2ByQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de"), 0, null, 580.099977726020000m, "29e32001-7417-4c83-839b-f8e0c14fffc7", null, "Joel", null, "Bahringer", false, null, "Joel_Bahringer", "AQAAAAEAACcQAAAAEA+D4AnMqiX6Zw+OQKDexJ50BbI9aez6Y5Vk+3fdGDmougWt7TklAnNzJBQTSfg50g==", null, "Female", false },
                    { new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f"), 0, new DateTime(1930, 7, 28, 0, 4, 47, 782, DateTimeKind.Local).AddTicks(9767), 633.2077409849140000m, "9cb5f627-a871-4126-986d-0cccc1501050", "Kathryn", "Kathryn", null, "O'Hara", false, null, "Kathryn1", "AQAAAAEAACcQAAAAEOu+cCgO0Lb4SASOHyiWQkEhcP2jbzQfLA7cYBkxmtwoBbe41eaA53gHuJjYElrTWQ==", null, "Female", false },
                    { new Guid("78cf7f13-f6c7-43c0-88ff-689030379445"), 0, new DateTime(1950, 5, 28, 11, 41, 10, 485, DateTimeKind.Local).AddTicks(8260), 93.5762379095590000m, "47fd5ae1-e52f-454d-bcc0-74dac9bc56b4", null, "Paul", null, "Orn", false, null, "Paul_Orn", "AQAAAAEAACcQAAAAEM7ePSIt2QSObmy1NJQaT3LLM37OlE8k1Gt4ifaX2T0dMekNzHJklJyGCCR8U0Tgzw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1"), 0, new DateTime(1978, 10, 24, 17, 3, 4, 3, DateTimeKind.Local).AddTicks(7056), 393.7729152237580000m, "379c15b2-ce91-4187-9a7c-0c3a5359c6be", null, "Dorothy", null, "Robel", false, null, "Dorothy.Robel", "AQAAAAEAACcQAAAAEGhdmEEpLCJjEQ8J+oG3tCD3wTojWJw+c5PyUHWKp0v5quLDocSURE6lLad+tzkJOQ==", null, false },
                    { new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc"), 0, null, 135.4944124942040000m, "d56a90fa-29c2-48fe-a4a2-1099512c72d5", "Naomi", "Naomi", null, "Quigley", false, null, "Naomi83", "AQAAAAEAACcQAAAAEL5JGcGnLQaRXCdGToJaCqf+VVjRVig6eEU1GUOtvqBuBZPhEFAkILLzps5fa2Grqw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116"), 0, new DateTime(1927, 2, 15, 1, 17, 50, 309, DateTimeKind.Local).AddTicks(3086), 495.1424905016050000m, "949fed21-07aa-47c7-bce4-a6a390f19557", "Perry", "Perry", null, "Treutel", false, null, "Perry_Treutel", "AQAAAAEAACcQAAAAEGcp31k2KiarCRKq9M/ftfBDJBrT/zLSF608WawxbhDtrf244xa8QWnRLCGMpsBtmQ==", null, "Female", false },
                    { new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf"), 0, null, 770.5862959636280000m, "e94822d4-9abd-42ba-a438-bd5117c50af4", "Sabrina", "Sabrina", null, "Veum", false, null, "Sabrina_Veum40", "AQAAAAEAACcQAAAAEMbYSiOSBWG8Fgy4MLJ3cjlOP/LN4Hf9T1xVbdL5AX3VMHwTzsRZaBo8fU5IaDG/oQ==", null, "NotSelected", false },
                    { new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9"), 0, null, 339.7857393586010000m, "eb985d53-e730-497b-9b36-15f222b7847d", null, "Marco", null, "Morar", false, null, "Marco_Morar40", "AQAAAAEAACcQAAAAEKmkNtt1WGiAaKgUqaubnJ3CRQlly21GAeNze8y5I8gjpNxVq/Atbz6A9l0VFkTKUQ==", null, "Female", false },
                    { new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65"), 0, new DateTime(1936, 3, 31, 4, 48, 14, 488, DateTimeKind.Local).AddTicks(6715), 665.2139790139060000m, "eb58cc8e-be5d-49df-bfed-03c51a3d80b2", "Alicia", "Alicia", null, "Leuschke", false, null, "Alicia.Leuschke72", "AQAAAAEAACcQAAAAEOasHkF4LVGmT9ZTZ2iREtmYbrg6Oz9iSVIMkNkfJAdansIpxbRefa/tvfUsZrtNJA==", null, "NotSelected", false },
                    { new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020"), 0, new DateTime(2006, 5, 27, 19, 33, 9, 830, DateTimeKind.Local).AddTicks(4056), 627.4855055853620000m, "fb36fb0a-413f-45cc-949c-e96e855f488a", null, "Emilio", null, "Feeney", false, null, "Emilio.Feeney61", "AQAAAAEAACcQAAAAEMxWczKfFbOZzM4f6UVcvBMKDlsv9otiwCMvfL40Gm6hqVZWcOUz7mizOvrp5e3I9w==", null, "NotSelected", false },
                    { new Guid("7f343d83-488a-4f8e-bb83-7417580035e2"), 0, null, 670.5474089700360000m, "0a5805d3-50ee-4e0a-a971-c5df4f125b39", "Bertha", "Bertha", null, "Olson", false, null, "Bertha_Olson97", "AQAAAAEAACcQAAAAEKe528MeD56l7AgNWL5d0Mrd4cpzGx5uhbDv9oJTQIVLiLJOrHDLz0z1sWLKwNVwFg==", null, "Female", false },
                    { new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7"), 0, new DateTime(1984, 2, 29, 13, 29, 40, 328, DateTimeKind.Local).AddTicks(6616), 718.8106866713030000m, "17eb3d06-e76f-4075-aa21-517e4ed4d62e", "Eunice", "Eunice", null, "Halvorson", false, null, "Eunice.Halvorson", "AQAAAAEAACcQAAAAEC8BT6IHJs1OKhujzPWf3sYR6TusRA7xtry2qjnb/EWvDLxObCvtFztYJH08ovNE4Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("812d963b-edbc-48b1-948d-661ea6f9d645"), 0, null, 685.644130215930000m, "1b401c80-3d26-4d3c-8196-8da716b1d957", "Kent", "Kent", null, "Feeney", false, null, "Kent96", "AQAAAAEAACcQAAAAEOdlG/jcKuAKKOAJF3dmLaorcP/j7V/vvkgnOxKH/tRVOzEcAaWNZOUd0vB0C3BHLg==", null, false },
                    { new Guid("82b014c4-7208-45ad-866e-bb82c82db592"), 0, new DateTime(1941, 12, 24, 5, 42, 21, 584, DateTimeKind.Local).AddTicks(5692), 285.4365386083210000m, "71f514bf-df04-45cc-a900-c86d98e847c7", null, "Harvey", null, "Halvorson", false, null, "Harvey96", "AQAAAAEAACcQAAAAEGvknzcAlgr8ozRp6FlRlKB4ZdYgYBMps7sKEJPxsDGBGWL9ZwoYmM5GrwX9Sh5U9Q==", null, false },
                    { new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd"), 0, new DateTime(1964, 3, 14, 0, 14, 18, 648, DateTimeKind.Local).AddTicks(1065), 972.7847850095970000m, "10c2e074-2806-415b-91da-02df5e3a2be8", "Kim", "Kim", null, "Gleason", false, null, "Kim26", "AQAAAAEAACcQAAAAEJdQjXjIFv4Kj+uu78UgXLyIyCXpYYGAx3zclI+wUIJ17OLZSEam/nkxNGiVZYTGTw==", null, false },
                    { new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94"), 0, null, 72.46360944450490000m, "c94e0821-1c82-4960-92a4-57c9006ad782", null, "Jesus", null, "Nader", false, null, "Jesus.Nader49", "AQAAAAEAACcQAAAAELnCJrRI92er0d+Of784TzS3+c7LzOJZ6ck+/oiiTlXu7joUKmQe3KEcRi3oYl4Jfw==", null, false },
                    { new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6"), 0, null, 903.8843696016840000m, "87c4a6ed-64ad-4d26-876f-07e59026e903", "Lora", "Lora", null, "Cormier", false, null, "Lora_Cormier49", "AQAAAAEAACcQAAAAEP6nobRiSY+48UPDC9J0LZKFAUGWtoIbQHOxooQPguhu7MpRfd9Kxa0lW7D0UHUA+A==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651"), 0, null, 240.3088346945890000m, "a858bee7-9f4b-47ea-aa66-d8e844893a3e", null, "Lydia", null, "Daugherty", false, null, "Lydia_Daugherty", "AQAAAAEAACcQAAAAEDRNhpiIKFMvG6ajfPzEoVr8NqF1h1dIKJI4XA3dv/FsUk10loI6jAAYHnWnKmXcew==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c"), 0, null, 356.4720449283330000m, "ff008ef5-37c2-4d1e-83ba-e2bbde61018f", "Ramona", "Ramona", null, "Kub", false, null, "Ramona75", "AQAAAAEAACcQAAAAEH+/DbytmWBAqpFmyqwGVymyLyUscOD0LVBf6A+FXcQ39FLPHqII65lFG0yx6xXL7A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33"), 0, null, 856.625953967370000m, "5f9f8102-4890-4cc1-8473-a1b7e2cf67e2", "Blake", "Blake", null, "Lehner", false, null, "Blake23", "AQAAAAEAACcQAAAAEG6IkmDiZELUg1qgGe+WpEIqz9vPSGlLnJDplbVjo9ANi6JA5pJTu6s8etVtQaiMOQ==", null, "NotSelected", false },
                    { new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc"), 0, new DateTime(1972, 12, 23, 14, 21, 42, 257, DateTimeKind.Local).AddTicks(1852), 499.4641563881540000m, "4c2b33c7-c0a2-46d3-9304-4f316c6c3d20", null, "Leticia", null, "Daugherty", false, null, "Leticia_Daugherty45", "AQAAAAEAACcQAAAAEAAPcLz7+Kr9/34FwvqoWFPtq9Ej8Dj7KRbtD/8w+/+MPJiTFaxIstFuwBoo351GmQ==", null, "Female", false },
                    { new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8"), 0, new DateTime(1948, 7, 15, 7, 56, 28, 154, DateTimeKind.Local).AddTicks(1197), 581.5342101389880000m, "5c8b1735-deab-4690-aa7f-b4c9a4bbed0a", null, "Tommy", null, "Morar", false, null, "Tommy12", "AQAAAAEAACcQAAAAEFsoZBEAiHv3N6uc5ZFOQVYgFk9PjJ3q2BoBI1sMjWku33D6ABlK6Icz0lq8h8C3Dw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac"), 0, new DateTime(1961, 9, 14, 7, 42, 2, 378, DateTimeKind.Local).AddTicks(3600), 936.3346271013730000m, "738a7231-9ee7-4b6e-a956-f5abae4dbff8", "Krystal", "Krystal", null, "Bogan", false, null, "Krystal11", "AQAAAAEAACcQAAAAEJ3Wq4RN0jh0hb1p1LYcgx5huYNaqr6OdKsCLbjsNTlqLq7q6/fs9qpUjUslBHOJGw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8a966506-353d-46f9-91b9-9431f8562c71"), 0, null, 393.2697298116240000m, "7d0a6fca-6ece-4e27-9228-4e981c82c253", null, "Curtis", null, "Welch", false, null, "Curtis_Welch", "AQAAAAEAACcQAAAAEI2hLeeXmSTDAimRG6c+HWY42WE+9z2aktHlfRhGEzEma1jmkjhPfTtY/jOlGefb/g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0"), 0, new DateTime(1973, 9, 18, 22, 17, 0, 299, DateTimeKind.Local).AddTicks(6243), 548.2982173352130000m, "e3d6f39b-252a-452c-8220-3c3cb926c61b", null, "Shawna", null, "Jacobs", false, null, "Shawna.Jacobs", "AQAAAAEAACcQAAAAEInvn11Ue00b6hR4fRPuGyR+5jpIpzMwbxrihwsOL/yLpI2x2tUPgsU11zzfdD4hyw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57"), 0, null, 792.2841735148360000m, "d9f85fba-c700-4c54-b9a3-cdb149fdd1ea", null, "Hope", null, "Nolan", false, null, "Hope.Nolan74", "AQAAAAEAACcQAAAAEE5XVt9SpU7BWZxM00dlv+Yd8E2o6o0spyUskilmd/YdsCG51wFKTz2iJGxapD948A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), 0, new DateTime(1981, 3, 10, 16, 52, 29, 860, DateTimeKind.Local).AddTicks(4419), 634.5999638676660000m, "5c1ce647-87e2-4bf5-b87b-0b1def35de9f", null, "Sergio", null, "Larson", false, null, "Sergio73", "AQAAAAEAACcQAAAAEEUzwg1NQ3UKWDRO1oXHyUzxq6euqjVXQ8bx2eG/GemKRr1aFiiV35GM4FnjM//XLw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0"), 0, null, 654.0031372900560000m, "371aaaba-a77f-464a-bc46-3e7aa02526e8", "Tracy", "Tracy", null, "Predovic", false, null, "Tracy.Predovic", "AQAAAAEAACcQAAAAEF0bYhJWlM0O+xaNtpkz48OKSLWy80jxYlk3KyP5o448NlonWc37rGRU/MBdH7JnuQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c"), 0, null, 740.8736033586160000m, "6e467cee-89d5-4792-8436-3799c3a9d57a", "Margie", "Margie", null, "Hermiston", false, null, "Margie.Hermiston", "AQAAAAEAACcQAAAAEB1IU9N8Ht489XVc3h/DedBLX80WVUjjK9557dggXVd6RHMRQENcOgZ98ovXebelDA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8d077a60-6583-4591-b84d-07adff60a1a0"), 0, null, 498.983676604540000m, "d7ec03ed-d7bb-401a-aee1-a3737116f681", null, "Shirley", null, "Parisian", false, null, "Shirley68", "AQAAAAEAACcQAAAAEHUq3NxuSHpXE1ED3b7TaGi3WlTjZxZfdSIXL2euI56wl1WKZyUSkkkk0IrSotYgAw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756"), 0, null, 614.4555183470280000m, "419641fe-db47-4298-8c32-8f67bc9480ee", null, "Gretchen", null, "Gutkowski", false, null, "Gretchen.Gutkowski", "AQAAAAEAACcQAAAAEJszVRqHa2P3ub3MWOAGVp2R/Dt9PJkPn8biVgKxgkrir+M8hz/c9j4y1joVPOk4AA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), 0, new DateTime(1940, 2, 29, 16, 37, 24, 559, DateTimeKind.Local).AddTicks(9838), 880.8333074241810000m, "003f635b-5bec-4639-a11d-21748b71ba1e", null, "Raul", null, "Gottlieb", false, null, "Raul_Gottlieb", "AQAAAAEAACcQAAAAEJcsKTQbtmrw795qv2Xm3CUrsyfDb5AMfn6DXQ5L1RVf4uVUdG+EE4sQetX/w+r1Sg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52"), 0, new DateTime(1953, 1, 1, 14, 54, 48, 271, DateTimeKind.Local).AddTicks(3865), 303.0006669438720000m, "973ff333-fd57-4be3-9024-901fc8a36800", "Justin", "Justin", null, "Abbott", false, null, "Justin_Abbott", "AQAAAAEAACcQAAAAEEiOfnLRfncl1QWVCJ7T4U42fH8wUjZ5jYs9n3jtkDikGj6+rh3r0q5bS8kkB7ktfA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0"), 0, null, 653.5194627858150000m, "9976ad8f-1ded-42d6-8fc3-ac2fa27a609c", null, "Julian", null, "Windler", false, null, "Julian72", "AQAAAAEAACcQAAAAEDfO96LvYotbcwLHhSXbjAyYNbUhjErYVLhuz4Z1GMWRhvVkq6pF41ifMYgzV+WxqQ==", null, "Female", false },
                    { new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b"), 0, null, 204.3826057818240000m, "f81cc268-04cb-4a9c-9894-09db01f06e17", "Pam", "Pam", null, "Connelly", false, null, "Pam21", "AQAAAAEAACcQAAAAEO1FaL5xbnaSrSYguZouHbzsnT+Pn9Z/QDzYSIht52Cix8J0K5zwsJCMRO523m/gxA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("929221d7-8d45-4a44-b501-41a47c26cf44"), 0, null, 874.7427915005370000m, "81e317cd-d976-42e8-ae08-b66e73c5c32c", null, "Lila", null, "Collier", false, null, "Lila18", "AQAAAAEAACcQAAAAEFpxV+VkDQnWUlhIl0Y+F66y4MMQHXPzJ0O8beEuHFD5eJnmBbcmo6JE0UU4ae0Uhg==", null, false },
                    { new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6"), 0, null, 869.0208524013660000m, "f7641860-ec96-496a-aacf-027f1be6488b", "Isaac", "Isaac", null, "Lynch", false, null, "Isaac64", "AQAAAAEAACcQAAAAEDZTY4wR+4LKaWjAEfmrxZ2SbPhEp80N51V1zvv43TIUOPtlzQeE3Mx4W7aBco8kSQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("9428c7a5-a397-4b16-aff4-15dc05248196"), 0, null, 236.6306507912090000m, "ac2962e8-5e3b-4aed-852c-0debcedf8028", "Deborah", "Deborah", null, "Bins", false, null, "Deborah16", "AQAAAAEAACcQAAAAEG4uIn/ap8yPE/f2PW44JKVz/IJmi7+5zCwEg+28a7HVXCB794Xaj9LcpbkAVtzyzg==", null, "Female", false },
                    { new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77"), 0, null, 688.4270258047410000m, "f0295488-92ea-4c64-81a1-ae554a9498cf", "Juana", "Juana", null, "Welch", false, null, "Juana_Welch48", "AQAAAAEAACcQAAAAEMDLukYUoGhWhb2IosB+8dUK/Qz5SpnIii7g/5BEVPu3j3v1iuhbGBMhol9HyCX9GQ==", null, "NotSelected", false },
                    { new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), 0, new DateTime(1999, 9, 28, 18, 43, 42, 787, DateTimeKind.Local).AddTicks(498), 269.358386918950000m, "681665fa-1425-48b5-b199-512c23dfe22d", "Gerardo", "Gerardo", null, "Altenwerth", false, null, "Gerardo_Altenwerth", "AQAAAAEAACcQAAAAEDjAQGY8adhyLojJkFJeQ2fSmcMFioJjBrPnd40da5bQuysyMZmjkU5ZbftyW9vSBQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945"), 0, null, 96.73503280304610000m, "03376712-69c4-4d35-8943-0e20c18624e4", null, "Wendy", null, "Friesen", false, null, "Wendy_Friesen25", "AQAAAAEAACcQAAAAEG7KXQrsM6RprX9TEmG8Bb8OHp5agn70BDUyS24gY+rU4yo5hbf5xSqRbtcUU7DtGA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1"), 0, new DateTime(1966, 12, 19, 3, 45, 20, 143, DateTimeKind.Local).AddTicks(1502), 924.5415708427440000m, "80cf4e7f-f552-40ee-8855-d14b22de7c61", "Marta", "Marta", null, "Keebler", false, null, "Marta64", "AQAAAAEAACcQAAAAEAtdiBHj5uXGDAEuuJjCj0p4pNQhbnNaRHdEn/L09csI7YLzr6/jxENtGn/RL/BqCQ==", null, "NotSelected", false },
                    { new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e"), 0, new DateTime(1933, 2, 11, 2, 52, 18, 167, DateTimeKind.Local).AddTicks(4239), 691.5791789525040000m, "c558cbcf-234b-461d-8498-46e28e912334", null, "Theodore", null, "Tremblay", false, null, "Theodore.Tremblay30", "AQAAAAEAACcQAAAAECHv3XVbaNJUKpwwtSf4F5WxGyHCBxpBWwbcIq1N66337V7nYTYytZ4puPJgRtOy/w==", null, "NotSelected", false },
                    { new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b"), 0, new DateTime(1947, 11, 7, 12, 43, 10, 462, DateTimeKind.Local).AddTicks(5119), 238.480723874760000m, "db05e66d-54af-48fb-b3eb-3578e3dba302", "Ricardo", "Ricardo", null, "Parisian", false, null, "Ricardo53", "AQAAAAEAACcQAAAAEM/FkKH+4eY712mar97mh5GKvoPbGzfi9wtQww90rmEmHBNK/F2qWvaHj6473szf+A==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a030d800-7dee-4af6-9714-7607209659cc"), 0, new DateTime(1993, 8, 8, 11, 33, 24, 427, DateTimeKind.Local).AddTicks(4618), 88.90790167592130000m, "805b79be-84d1-4c19-bcee-2734a8b936d2", "Henrietta", "Henrietta", null, "Macejkovic", false, null, "Henrietta58", "AQAAAAEAACcQAAAAEOP+6FYZ0qS730t2//jkocjjYV4NJEvSVly7MatD30AAFmADne1v5RZVUDNiyoEhqg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a0863958-35de-49a9-a73b-decb03e0c871"), 0, new DateTime(1988, 8, 23, 20, 15, 1, 165, DateTimeKind.Local).AddTicks(5759), 727.0018268079290000m, "5ec4568b-d5da-4026-9a3d-4b7dbd0eed42", "Jean", "Jean", null, "Bosco", false, null, "Jean_Bosco", "AQAAAAEAACcQAAAAELHi8lNrOi/X0eGvt+YtnSV472iNv5jqYi4gcYewBYfYUP9UzNwRYK1qYWHfoc2yQQ==", null, "Female", false },
                    { new Guid("a0935a01-c087-4387-9782-37219c8d05b9"), 0, null, 977.0042029263270000m, "0bad7383-dd12-4d02-a27d-b95d0b78d353", null, "Terence", null, "Hirthe", false, null, "Terence.Hirthe", "AQAAAAEAACcQAAAAEJjYqxWXXJpWHaGDrZVBaf/p0tx5+hxJYwq50nH+2ue2JpgaGxo7+xO+Cup5sETweQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1"), 0, new DateTime(1972, 8, 12, 9, 29, 23, 888, DateTimeKind.Local).AddTicks(3614), 54.42605125701430000m, "52fb8f0f-0e84-49a8-a1a7-b37ed56756a6", null, "Kent", null, "Walter", false, null, "Kent_Walter57", "AQAAAAEAACcQAAAAEBNiTe3QXaMoewReSFNlR8ijTQmx7iV1F7G+U0VHPE+2NltXx/HvB7vYrKvLCCDdRA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10"), 0, null, 995.5319268898690000m, "ae860ffd-7c0d-46c2-a512-be065dbce609", null, "Brenda", null, "Haley", false, null, "Brenda.Haley", "AQAAAAEAACcQAAAAEDbWowYHLQ4M4IUaj6frkF7MSq2DGWD396IfK9kdFfe8g+ZNRR2l8hmDndjVjAzXTA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d"), 0, new DateTime(1985, 2, 27, 1, 8, 31, 496, DateTimeKind.Local).AddTicks(7071), 635.9062598441650000m, "a4e7de5b-6e8e-4b1f-860e-8d5c670209cc", "Melissa", "Melissa", null, "Graham", false, null, "Melissa80", "AQAAAAEAACcQAAAAEGmG6ZtQ+UxYfJo/5p1qfhLXSJpQyKQ+vaMvigauxY4aDPdJURKqBZ2vfcxo83XmKg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9"), 0, new DateTime(1939, 10, 24, 14, 1, 54, 706, DateTimeKind.Local).AddTicks(4773), 359.9076251979380000m, "2d7b46af-01f6-4d15-a14d-bca287813a15", "Alma", "Alma", null, "Ankunding", false, null, "Alma_Ankunding", "AQAAAAEAACcQAAAAEL1XXaLztDjmgic18cru7xacMzLHAJlQCdAMwV1nVRtPonCybES2Dmz2WI/4drXoMw==", null, "NotSelected", false },
                    { new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a"), 0, null, 176.3781247429480000m, "64c72198-0924-4902-8c8a-351de45e4af9", null, "Jackie", null, "Pollich", false, null, "Jackie.Pollich36", "AQAAAAEAACcQAAAAEGvRU+p0S/6BSLccqhnZSnCzOySeDmyi0O7pCnf9F1eSsYW+3DFTD4l8nK4utWTwPg==", null, "NotSelected", false },
                    { new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a"), 0, new DateTime(1980, 2, 23, 18, 44, 7, 473, DateTimeKind.Local).AddTicks(6222), 451.6015328024920000m, "6884d8e4-efe9-46b6-a683-7a7512226237", null, "Wilfred", null, "Wintheiser", false, null, "Wilfred_Wintheiser52", "AQAAAAEAACcQAAAAEEftLa/tcai0X9ddIga88cLAGioAnZk5qnSdGbAzGFxbh/B0xWX/qYoXzdCYYWouxw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f"), 0, null, 236.8225116498820000m, "f4df1899-1e41-4efa-ac57-a0458b8c75e9", "Jerald", "Jerald", null, "Leffler", false, null, "Jerald_Leffler39", "AQAAAAEAACcQAAAAEDQAbOk+/S+AC/2MzrEafZN81w7xX9pIFjzH8hf1xkBAEocCpt2BZJMh92lp+LtwYQ==", null, false },
                    { new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4"), 0, null, 139.3818499907510000m, "d10991f9-8fe7-42bd-b676-ca8244caae0c", null, "Jill", null, "O'Connell", false, null, "Jill_OConnell78", "AQAAAAEAACcQAAAAEI6Z4lOA+8x5EkiCaxl8JpNbGvr5mEBIAlDAhij8fNMvwnJyLyl3Wf8UoJEcdheLqg==", null, false },
                    { new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc"), 0, new DateTime(1926, 7, 29, 12, 49, 45, 583, DateTimeKind.Local).AddTicks(3711), 260.5034174064250000m, "8e1175c8-bc99-4f14-b293-caed2aa42932", "Bernice", "Bernice", null, "Hand", false, null, "Bernice.Hand42", "AQAAAAEAACcQAAAAEEg2N0Rn2Y0QFRnlFaZiicSeLZTFMBXyuwA+x/9cFbcGlVUSau1ccogJgX9+KY7yog==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623"), 0, null, 544.6650271318940000m, "d65da6b8-2a3b-4f23-b753-7521d8e6cd1d", "Debra", "Debra", null, "Moore", false, null, "Debra_Moore", "AQAAAAEAACcQAAAAEK3nIgWUQ0clLnkvXAysNh42mrcaJNk9ml2ViPMiydlQtMd1LyIKHNLSTeCrVy3rRQ==", null, "Female", false },
                    { new Guid("ae750269-835b-481a-8e36-4dd8044f9527"), 0, null, 344.2037681224930000m, "28a4fdf5-55ac-4639-832f-8638a0c54ba9", "Bethany", "Bethany", null, "Quitzon", false, null, "Bethany.Quitzon", "AQAAAAEAACcQAAAAEBzHyOTgTjnYsC3pMH0pMYXdDC+tSWCGPZXegE8w3W1gV0cpHgauDlMeSnzV5CTbUA==", null, "Female", false },
                    { new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), 0, null, 14.84564891954090000m, "c0c861df-8974-4719-8c8a-6c18626a74fb", null, "Richard", null, "Wehner", false, null, "Richard.Wehner", "AQAAAAEAACcQAAAAEEeZy2rHq+hqXd7Fr0To+AU8MXByLNyj42cZAIXRYLDGHsbpNfhOGZq+ybmGwbXSdg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b15da029-129e-47f2-8442-a8831d78a2c0"), 0, new DateTime(1955, 12, 24, 0, 59, 43, 82, DateTimeKind.Local).AddTicks(8332), 159.9065159857990000m, "3504fee6-444e-4731-8ddd-fbf2a918235d", null, "Pete", null, "Bernier", false, null, "Pete60", "AQAAAAEAACcQAAAAEJEFmm+pIYEK5H2TRJe/5n16swhIh2NSnZQgFoUFAIekA7RGN1znbuT1Bnn7qx8m+A==", null, false },
                    { new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), 0, null, 195.5705589526640000m, "36dd8699-1ca2-416f-a1e7-802efe8d33f0", "Alvin", "Alvin", null, "Heathcote", false, null, "Alvin_Heathcote", "AQAAAAEAACcQAAAAEI9QsGEf+8qeVWnn7Qjam6XWYthqYPjxLeAZb7ZymgdmwCaCR/Ms/A+E4WQcuHb5Jg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b1730870-c7ce-4652-9fde-90436bd323a9"), 0, null, 992.0779005816160000m, "e54bb58d-405f-4468-979d-01feb34cc698", "Ivan", "Ivan", null, "Jerde", false, null, "Ivan96", "AQAAAAEAACcQAAAAEApEYzAalA/k0nIVB965xRZI+93+UlrpfKMCtUOZkSU9oFDBqqhSllQ5/ZNc/wHtpw==", null, "NotSelected", false },
                    { new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86"), 0, null, 169.5768704029260000m, "33387bf3-d853-4774-915c-414f4fe2a52b", null, "Percy", null, "Kunze", false, null, "Percy24", "AQAAAAEAACcQAAAAEPkIjxzDmBS/ZhNO3riLa/A+bX5Yj/E1uhUHxr8Hk795jixI+N4vQnAhTCi3hOAl2g==", null, "Female", false },
                    { new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b"), 0, null, 121.1868311088370000m, "e25ec25f-a441-4c87-ac58-b46b2a826e1c", "Garry", "Garry", null, "Walter", false, null, "Garry92", "AQAAAAEAACcQAAAAEMh87EL4VA3QMu1Y3TNPJ+5iH1qqJrB+r6G6S8HY2GpOj0AdNpS8Lcl8hUQ4e+WafA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc"), 0, new DateTime(1990, 11, 20, 4, 22, 7, 535, DateTimeKind.Local).AddTicks(1768), 519.3096978784060000m, "cd23082f-8ec6-469e-b2a4-d12e83da2d40", null, "Leland", null, "Kertzmann", false, null, "Leland.Kertzmann", "AQAAAAEAACcQAAAAEPlGf9W+JsS+TqKfL622c3Ds7jk6wTPWhrNN/xHTVVOzBJCQtuCyvPRxBCiT2teCnw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b"), 0, null, 569.4736707930340000m, "4a1c5038-aa6f-4c56-ac18-edb73e38dcd3", null, "Karen", null, "Jaskolski", false, null, "Karen_Jaskolski", "AQAAAAEAACcQAAAAELK2q5luC5TvsDxHOGV5GaSbtEAEeB+3MY3q8ZqlIzbO39HsVa99u34uJdaLx7nVmA==", null, "NotSelected", false },
                    { new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3"), 0, null, 409.469458787080000m, "df630388-cd95-48f1-8030-ace2c2268948", null, "Dwight", null, "Hoppe", false, null, "Dwight.Hoppe43", "AQAAAAEAACcQAAAAEMcxuBcBuYtTt9gIs4ItSRITHCMvdRw4qfYUWvbOa1nLnBdPko/S1JzSdOIZQ27OdQ==", null, "Female", false },
                    { new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad"), 0, null, 259.3880588044560000m, "57e430cf-5afa-4de6-8c06-459c97907bfc", "Genevieve", "Genevieve", null, "O'Hara", false, null, "Genevieve_OHara", "AQAAAAEAACcQAAAAEBVaM12NJVqm2tfkKVUWuI2/ofwIgIUl5yvUp1Q/vAzO18RfDDvam8TunhsBnKoNrg==", null, "Female", false },
                    { new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14"), 0, null, 450.1449164732750000m, "9e39c0c7-a2c0-4ac1-91cd-d51f132c5525", null, "Jordan", null, "Sauer", false, null, "Jordan39", "AQAAAAEAACcQAAAAEB7LBSJYOemHif+rAieOUdyBafwbVLIeG/1zt6sA70Qarre5HORTNda4YDChWg5evg==", null, "NotSelected", false },
                    { new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8"), 0, null, 918.4987243637150000m, "226a9e17-3922-4867-b3f7-b46edb579fbb", "Rita", "Rita", null, "Nicolas", false, null, "Rita_Nicolas", "AQAAAAEAACcQAAAAEPNtdT3+LSONyAhstYcWVj3pshl0ApUhttnEQmE0aO/Agx+5/M/tr/GLMeuJ+ElQJg==", null, "Female", false },
                    { new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177"), 0, null, 821.4518652174660000m, "db9c3268-c8b7-4fce-997d-f1abb04d2903", null, "Lola", null, "Lemke", false, null, "Lola74", "AQAAAAEAACcQAAAAEObq0lhknFwMIh7MZ1O9oFSoLe7JDyjnqQVw5c1ZWJkUC7t2TRT9mZ1BrSxEAiuYNQ==", null, "NotSelected", false },
                    { new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f"), 0, null, 122.4045423037410000m, "e1b0b85f-64a6-49e4-a42a-7b681555f78b", "Margie", "Margie", null, "Langworth", false, null, "Margie_Langworth86", "AQAAAAEAACcQAAAAEHxlS0iympNCqATXASv/CcEQBTXm3zzTb1+uFyhuczFxqNgeG0AzqDJAgSbvTRE3Ow==", null, "NotSelected", false },
                    { new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350"), 0, null, 664.8832432845220000m, "2da25061-3482-4dbf-8506-77e5400026c5", "Lyle", "Lyle", null, "Mitchell", false, null, "Lyle.Mitchell", "AQAAAAEAACcQAAAAEFfChG3Oxp/bME/tkfhPJxKs2p5x7COYyqfgiK6OiJK8cq/fpFrHCxcOMY9u1iDMdQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("be28704f-919b-414b-b444-7bf3be5f0534"), 0, null, 416.9806057794850000m, "47830131-da70-4b3f-93af-c8586154e45e", "Roosevelt", "Roosevelt", null, "Jones", false, null, "Roosevelt_Jones65", "AQAAAAEAACcQAAAAEGLs1h4sHJLtQRJIbS1WYQmDYZqMkDkfWESc3RGz3sMdjIf9jrTWlQ2OlhPK2wmckg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7"), 0, null, 723.6604507015160000m, "4873169f-4034-429e-966e-986ae7c4fe3a", "Faye", "Faye", null, "Okuneva", false, null, "Faye80", "AQAAAAEAACcQAAAAEK2Q9TMBUwMM9N6tP4Xk2SqOCkLa/Pj+l3PjGsyfSehelFB+6D+dmTu/18xGkP7Ruw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5"), 0, new DateTime(2008, 4, 28, 9, 10, 27, 95, DateTimeKind.Local).AddTicks(5549), 987.9458020694710000m, "03e6d7a4-c180-41e1-a53f-a195f6b8ab0a", null, "Constance", null, "Fadel", false, null, "Constance.Fadel7", "AQAAAAEAACcQAAAAEJeBJf4rz6+F4g1U8vrJuyaJ5uwkDI3NWZylzW4lulzJDGKwIhzOtPGJTHaN+EFCPA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("bf057140-33a4-45d8-af53-45e3337a92d1"), 0, new DateTime(1941, 10, 13, 21, 35, 42, 921, DateTimeKind.Local).AddTicks(8891), 671.4698140129190000m, "248ff083-b77b-48e3-bb64-ef6c57dc5d5c", "Maxine", "Maxine", null, "Cruickshank", false, null, "Maxine.Cruickshank", "AQAAAAEAACcQAAAAEAioy+QlefFPnITVG6ZQKU9OWdx3Ia38xsk3rySfcS62sQOvD9Wx/ALYn6d+G8irQg==", null, "Female", false },
                    { new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6"), 0, null, 927.3723193444180000m, "b816f19c-98de-4929-a2b7-ee73f3719bec", null, "Sheila", null, "Paucek", false, null, "Sheila.Paucek97", "AQAAAAEAACcQAAAAEHH6XQISbOBBTBI91u3szY5EhurW8GcaV86sfaYylTCrMKUvWodyVhPZvhqBMLzLrA==", null, "Female", false },
                    { new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f"), 0, new DateTime(1965, 10, 7, 7, 1, 14, 95, DateTimeKind.Local).AddTicks(18), 995.5721871027050000m, "0a1c5f17-f8fc-4e5e-8905-3162b916f10c", null, "Angelo", null, "Rosenbaum", false, null, "Angelo27", "AQAAAAEAACcQAAAAEJu4TQT4m6Zqebtt5X8ttVs/gWCuRoq/kV3QqLlbvDH17/27wfXota7JhB7m/rJeXg==", null, "Female", false },
                    { new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5"), 0, null, 480.4620140012670000m, "4bc4024c-f8f8-4068-a9c1-8a81fe9275a8", "Lindsey", "Lindsey", null, "Nienow", false, null, "Lindsey68", "AQAAAAEAACcQAAAAEKWbSBYKMhiJ+RRNkpPT9tVxJPMFxVeQ3OAOXcw5dsZq9o6gVrIoUZ0GCdpfOoOtiw==", null, "Female", false },
                    { new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4"), 0, new DateTime(2003, 3, 26, 12, 47, 38, 405, DateTimeKind.Local).AddTicks(3499), 765.9038637776950000m, "800d6672-3fea-4cdc-a214-0411040a76b7", null, "Rose", null, "Sanford", false, null, "Rose_Sanford", "AQAAAAEAACcQAAAAEN0NVtfBXM0K377mEqERJhy6FoYulHhTXL88cU5wChQ0687MLmWAa4jYG0k/6V/9kA==", null, "Female", false },
                    { new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448"), 0, new DateTime(1967, 4, 8, 3, 55, 37, 880, DateTimeKind.Local).AddTicks(9926), 403.7179516237980000m, "67dd4073-6d0e-4c3e-9272-6394715a8e5a", null, "Tomas", null, "Lakin", false, null, "Tomas96", "AQAAAAEAACcQAAAAEEIhAwBN8Y6ICytoqt0BWdUWw2aqlhbhz8mFozH4ZsFjU2+Iz4NPNfG4qlS1us9SLA==", null, "NotSelected", false },
                    { new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d"), 0, new DateTime(2007, 1, 30, 11, 44, 10, 189, DateTimeKind.Local).AddTicks(1023), 193.5721725842560000m, "5027dced-ed8e-4414-85b6-7b3731896331", null, "Donna", null, "Yost", false, null, "Donna63", "AQAAAAEAACcQAAAAEFezZx462jciycUaXZQw/o/3QDBUtzk9uXQv9I532878d49bnqDzwCoCbTrM5HG3bA==", null, "NotSelected", false },
                    { new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816"), 0, null, 580.0572708215720000m, "a650796f-bfdf-4a60-a422-a4fe9c44d046", null, "Arthur", null, "Lehner", false, null, "Arthur59", "AQAAAAEAACcQAAAAEAS1CQRp7MCbbFYcybSq81b3uy+b1haPW3uQtViyZW4edilUPv0J4pSlg6D+n45dbw==", null, "NotSelected", false },
                    { new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75"), 0, new DateTime(2007, 1, 10, 4, 8, 59, 631, DateTimeKind.Local).AddTicks(4177), 526.413375695910000m, "ab7aee9c-341d-4fa6-b7a4-9d03d5d08d00", "Maria", "Maria", null, "Corkery", false, null, "Maria_Corkery60", "AQAAAAEAACcQAAAAEB8z5bOCkbu3zqbBqDLWBVonjj91RzKWE9pyZlbAEiDyeqlTGmwNI49XQMIByIer3Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240"), 0, null, 596.7065681090980000m, "67a2e220-cb18-452d-bccd-0f81c64a1b4b", "Clayton", "Clayton", null, "O'Conner", false, null, "Clayton.OConner", "AQAAAAEAACcQAAAAEKe+rR72ZE7k/5/sJyJQl/pAAg6eRkfOpUGA1rktOO06781uDhxwxGM7uzJNGh4dzQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e"), 0, null, 141.654187434160000m, "7a8f11f2-59e9-48e5-abd7-130e87f07dae", "Ruth", "Ruth", null, "Kutch", false, null, "Ruth24", "AQAAAAEAACcQAAAAEGV5zOUEzOIOpoLAtw0+Ckd9/yrYfGZJnzK2eUAhMIuWCJ9khVIIQZoPlcMsqj1mug==", null, "NotSelected", false },
                    { new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8"), 0, new DateTime(1967, 8, 17, 1, 30, 48, 768, DateTimeKind.Local).AddTicks(2257), 626.9497079969130000m, "db88839a-0f31-4d51-a77c-f0a1d1bf2d8e", "Henrietta", "Henrietta", null, "Mills", false, null, "Henrietta56", "AQAAAAEAACcQAAAAEBVocSa5XMRYnGmPxWnyQ366pj/Yea+rEWFjduu0Fmm2mdzSG+QnQTKhXlYw2J8DVQ==", null, "NotSelected", false },
                    { new Guid("cd1cbc32-3001-4296-97b1-174540c81c07"), 0, null, 145.7939339601910000m, "d529f9e6-6c26-4989-bf90-93e185cf215f", null, "Salvatore", null, "Schimmel", false, null, "Salvatore_Schimmel", "AQAAAAEAACcQAAAAEIbIviMMnCtz7USzs067V9YtieRBlP6g7QmwXnrSugnvLBTuXIiLKqw2ppwXUzauxg==", null, "Female", false },
                    { new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e"), 0, null, 720.6454975814120000m, "f682118b-9812-48d7-89a8-85e73c471e59", "Lloyd", "Lloyd", null, "Pfannerstill", false, null, "Lloyd.Pfannerstill", "AQAAAAEAACcQAAAAEHAFvMeHDtz4nyl9wCRtDtNva/zkpgRvVpqL2foiTYbyyW/V8XhdA+FzeRijOUOldw==", null, "Female", false },
                    { new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28"), 0, new DateTime(1972, 5, 12, 10, 36, 23, 297, DateTimeKind.Local).AddTicks(1161), 666.2212478604620000m, "3481fc72-fad7-46fb-95f5-f9cdd38ac595", null, "Julia", null, "Herman", false, null, "Julia.Herman", "AQAAAAEAACcQAAAAEEtRwN7AdjqW8r/mnBQKtrAbT6wU+Nj+Udl0i+xPiMz48LUPKRsnDFg01tWJNM9OLQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b"), 0, new DateTime(1943, 4, 8, 15, 11, 54, 725, DateTimeKind.Local).AddTicks(5386), 771.8125319986530000m, "dd6170c0-d658-4bda-974a-9e50f6c2d314", "Matt", "Matt", null, "Simonis", false, null, "Matt_Simonis", "AQAAAAEAACcQAAAAEKRafuW9hP2RAGZBrR2dgVtwdeHLbmqxAc2F2Uywet1rSTfvsP3dN71s1niyZXXYjA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ceaacde3-54f1-461f-bf43-13adced4d581"), 0, new DateTime(1987, 9, 7, 0, 16, 56, 299, DateTimeKind.Local).AddTicks(7432), 817.494904396190000m, "5e5b0b7a-e63a-4892-9acf-153d174062bd", "Perry", "Perry", null, "Littel", false, null, "Perry.Littel", "AQAAAAEAACcQAAAAEGpe/GiuZin6Q0Ve6ZhYDdLxe4Ei95T7QsewdeHfuTLNlW/RUNUPxis0PUBd+LUjPw==", null, "Female", false },
                    { new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7"), 0, null, 766.7805093550320000m, "2dbfcc9e-fc4e-4765-b0b2-6ad43196c0dd", "Raymond", "Raymond", null, "Mayer", false, null, "Raymond62", "AQAAAAEAACcQAAAAEBEiP2ACHYsFH5Lmk1UCRuV7TyxWM4IQAhZitfMD8dP2+S7UVprXSIuA32ZxQ6+LZw==", null, "Female", false },
                    { new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52"), 0, new DateTime(2000, 8, 23, 20, 22, 51, 333, DateTimeKind.Local).AddTicks(4087), 528.3111588102440000m, "93b04dab-6955-4a56-b21c-fd78f790ad8c", "Fannie", "Fannie", null, "Christiansen", false, null, "Fannie_Christiansen53", "AQAAAAEAACcQAAAAEH4SDZvRUu4ZxJcfxZe5h36NvmxYHrF9pkvppxXPehyCinlo+XWJuEzXqSbKbfGiGg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3"), 0, null, 353.317441027920000m, "7e506b83-6459-448b-b6cc-29eb8c911a17", null, "Leland", null, "Conn", false, null, "Leland_Conn81", "AQAAAAEAACcQAAAAELqZcmbgeKUvv2qzyQZzWQPxdYKH9haUhKTj+tdtFoUVskauEXFvXE1x6CRwxD53bA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d364b716-4b5c-4090-99d6-0f11b5849701"), 0, null, 763.7606070119230000m, "8cb459ec-e755-417a-98a6-10cf1bd327df", null, "Leroy", null, "Torphy", false, null, "Leroy.Torphy", "AQAAAAEAACcQAAAAENzcSO6gTspAu5Xf/eDXos133VGBFkevB35GfUWG68OgmxDZ7sRcVQ8vBzwMxIgzJg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919"), 0, null, 726.4105333954850000m, "516df23b-6ad7-4e82-beda-3681cbef5f17", "Sheryl", "Sheryl", null, "Nader", false, null, "Sheryl.Nader30", "AQAAAAEAACcQAAAAEMJy5Xdgs3x9khwxaaLOBIGXPjAaGSC4BTEk6z16AqU1cKYCUtpJ210nX6JOHr38Sg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a"), 0, null, 951.5837854882260000m, "73c34e05-19c7-4d49-b0b2-7ace7e59d5ca", null, "Erica", null, "Ruecker", false, null, "Erica_Ruecker", "AQAAAAEAACcQAAAAEJrvl6jkgmcuPwStmjUdZxMXANSy9K6b0S7k5sxw32a/2DFDw9GTcU/Q3WWMWpm+cQ==", null, "Female", false },
                    { new Guid("d5908335-16ba-435a-9a9d-603eaee07878"), 0, null, 287.1619565280060000m, "eff6f2cf-2306-497d-9b5b-2d5899b9ab0e", null, "Willie", null, "Hills", false, null, "Willie.Hills36", "AQAAAAEAACcQAAAAEB8TTeUnzev8L0++i+2OAOleMJU2+4f7R6NBu92U7A0Ax0dSP6nFKRQLPMdhq0WhGg==", null, "NotSelected", false },
                    { new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84"), 0, new DateTime(2002, 3, 19, 5, 1, 25, 31, DateTimeKind.Local).AddTicks(7046), 431.083852882330000m, "2ae4167d-5b3a-4847-9c81-003dfbc0cf80", null, "Francisco", null, "Ledner", false, null, "Francisco.Ledner", "AQAAAAEAACcQAAAAEM55JnompeP12MKx3HgGwFnvriLwuVzbCrKqMIeKaWqb7XuT2Vr+6qt2dHFeDMLKMA==", null, "NotSelected", false },
                    { new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92"), 0, new DateTime(1930, 1, 23, 13, 47, 24, 583, DateTimeKind.Local).AddTicks(3043), 141.8342026368750000m, "3967ba24-dcbb-41f1-952f-e548c07caeb3", "Gerardo", "Gerardo", null, "King", false, null, "Gerardo.King", "AQAAAAEAACcQAAAAEG5jkfKAWzE7j+oumAtDwMvMTMQppV+P6Qe8OwcDGTWqzyhsDe37jQisEdE2e5KKPQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36"), 0, null, 110.7557647159040000m, "5a461dba-8db5-4164-a653-c980e4c598ab", null, "Roberto", null, "Schulist", false, null, "Roberto.Schulist", "AQAAAAEAACcQAAAAEFg+yiNQ/nD88m/AxN+PK+RzLCMUlw+2AaRaFFKezIfhJhs4G8VCu/lo2DdM6WMFpw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc"), 0, null, 402.224540821270000m, "0f49e64e-54eb-46ea-a329-cbc0ee48dde5", null, "Melba", null, "Dicki", false, null, "Melba_Dicki", "AQAAAAEAACcQAAAAED1m6CrGuptqCVDAMGyH/bXubpcDcPgb3hmDMK87nF547TggYe8Gw352u/8hPxQzNw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8"), 0, new DateTime(1974, 7, 25, 10, 4, 11, 535, DateTimeKind.Local).AddTicks(4334), 663.6729562411020000m, "e1266383-46c2-487e-98c2-c07b4aa77bc3", "Michele", "Michele", null, "Terry", false, null, "Michele_Terry", "AQAAAAEAACcQAAAAEPp1GBtUPOpIEikQSeGYDYfh6EMSSoFVD/YVynRrzpgxOHTAokVG71ZtvtlhOEgPzA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217"), 0, new DateTime(1934, 6, 5, 14, 51, 11, 826, DateTimeKind.Local).AddTicks(4528), 706.8577227584280000m, "4fc3c2cb-ef9a-4173-8d9d-21a7547b3f64", null, "Frederick", null, "Feil", false, null, "Frederick.Feil", "AQAAAAEAACcQAAAAEECpH5ECS9hBfl6APnB+hvWljbIqJFLQQnksi9fjFuy6cBElw6S45A/X4y3PVdF00A==", null, "Female", false },
                    { new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), 0, new DateTime(2004, 4, 25, 7, 1, 27, 71, DateTimeKind.Local).AddTicks(9189), 352.4120901336290000m, "66a72d73-750d-440b-880d-7290c92e82e8", "Jim", "Jim", null, "Homenick", false, null, "Jim84", "AQAAAAEAACcQAAAAEF13/9zyXAbwEKSIXkuCZBRHQnzgQJ7uyh2hUwsmIpGZnM/pv/DKo0SDpRrQc6FEbQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711"), 0, null, 508.3631356911910000m, "e76a1eb0-7719-4c06-9656-3af4323c457c", "Mandy", "Mandy", null, "Kozey", false, null, "Mandy_Kozey92", "AQAAAAEAACcQAAAAEPnKR3kGe/6Tk4T1k0j8tnBhqgQkc6OI3F4qwFwwyKrOBkfk009r/WijjHzMm7mO6A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd"), 0, new DateTime(1959, 4, 13, 18, 20, 27, 296, DateTimeKind.Local).AddTicks(6431), 92.99653552150780000m, "48ee6611-718c-4ecc-b8bc-6241dc5c73d4", "Randolph", "Randolph", null, "Hackett", false, null, "Randolph_Hackett", "AQAAAAEAACcQAAAAEOQ+5LJ8Kj/PgkJIM8EaAm0ymSbOp+xK598yiqsaVPPbO1WmB3FCsc+bJP94eDRb8A==", null, "NotSelected", false },
                    { new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18"), 0, null, 996.214706514290000m, "9a73db6b-a6cf-4389-af99-3d40406a3f5e", "Krista", "Krista", null, "Bergstrom", false, null, "Krista62", "AQAAAAEAACcQAAAAEAd+8Oymto2nABca7/if+Fj7FpTJDob2I6v5iTddAvs9V3Hl7wQ4SHWXaE9dK4PsCA==", null, "Female", false },
                    { new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b"), 0, new DateTime(1934, 6, 1, 6, 34, 1, 354, DateTimeKind.Local).AddTicks(7210), 644.6660040275990000m, "0fd0167b-664f-4519-963b-cb9a013c4adc", null, "Noel", null, "Wisozk", false, null, "Noel9", "AQAAAAEAACcQAAAAEJqsiZkBKLPzCb9MmX74UHzg8uHi4aRgqgM24BvIKNCK8KnplEsXFC7CQPUbh/GN0Q==", null, "Female", false },
                    { new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37"), 0, null, 123.6097551170140000m, "92b746bb-8b2f-44dd-b4fa-ca795e299e34", null, "Patsy", null, "Jenkins", false, null, "Patsy_Jenkins45", "AQAAAAEAACcQAAAAEE6cRrMbcNlezyb6kORMFb+2E/38zOSwU3PKJF//kNMcEkWZf+4Iv5DH7CzdjqcddA==", null, "Female", false },
                    { new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8"), 0, null, 580.691557980420000m, "280b4183-6781-444f-80aa-a1868e026a66", "Mattie", "Mattie", null, "Medhurst", false, null, "Mattie.Medhurst", "AQAAAAEAACcQAAAAECwwjWAaKh2N48jsTmgtgDM4tG5ogMIDheFusrMG9YIWMRgcN8lD0R0CahnKn2dTRg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e57373e2-48de-4c55-9c02-9b87c7751318"), 0, null, 352.634773115020000m, "68348684-3283-4cd3-a0ee-84f29d898dd5", null, "Ronald", null, "Bergnaum", false, null, "Ronald_Bergnaum80", "AQAAAAEAACcQAAAAEFN9hn0dOvJYWOkSsu4CLMIyAPmGuUrhe831V/WYdsvvPsWZM9z6Gcr+ozNb3uwiFg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75"), 0, null, 352.4541597867530000m, "8bfaf257-0e80-4105-84c9-53ba10f48e5f", "Olive", "Olive", null, "Wolf", false, null, "Olive8", "AQAAAAEAACcQAAAAEAgMeREcf9Q9p5reocy3ts5SdvO3rYLhCKBb88fYFpGPhG+8u5mYUAjaGBBzIFen5A==", null, "NotSelected", false },
                    { new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca"), 0, null, 291.4856623127180000m, "e7e4130e-cd90-48dd-b11e-59bc6e56b4d5", null, "Karen", null, "Schowalter", false, null, "Karen_Schowalter71", "AQAAAAEAACcQAAAAELxORky0lh8TpMkjEZ9s23l9NNQxj7m8TPXv3O1bhhPqCLWZbgsRs/lSX6c0gOqOuQ==", null, "NotSelected", false },
                    { new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df"), 0, new DateTime(1981, 4, 13, 20, 12, 36, 595, DateTimeKind.Local).AddTicks(1305), 776.6882916275490000m, "1d16c2f0-959e-4b1c-9223-7185c47172e3", null, "Bonnie", null, "Leuschke", false, null, "Bonnie59", "AQAAAAEAACcQAAAAEJ+Ohn/cO14323zOsvXTMfdE+IgjJTgNXx4vB3PDUIXerNvR7y2qvaiOqFX8WPY3Nw==", null, "Female", false },
                    { new Guid("eada0502-f63b-424a-9d81-244529d74dc1"), 0, null, 473.0911044916420000m, "058c1f29-33a6-48a5-be26-68d41522f08f", "Darla", "Darla", null, "Crooks", false, null, "Darla_Crooks", "AQAAAAEAACcQAAAAEK/erj4VP/xL4X2dwxZ2ut7V+7+u7PygXAlRERX+ScJycyPT3NeHVMoJHBrFpqsnjQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01"), 0, new DateTime(1992, 7, 15, 15, 30, 39, 270, DateTimeKind.Local).AddTicks(5724), 315.2165542706730000m, "8a17067b-6bcc-4499-8792-f58e618b84c3", null, "Bobby", null, "DuBuque", false, null, "Bobby_DuBuque28", "AQAAAAEAACcQAAAAENIB0KFypfg18HKhzpuFBVoYIo+swIPbbjdB58AAxX5y/qRevEc0rcW9fa/VeqZMzQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070"), 0, null, 730.5103429613560000m, "00f60639-1f5e-4b5b-945c-e595b98a6b2b", null, "Kristy", null, "Okuneva", false, null, "Kristy8", "AQAAAAEAACcQAAAAELuJeMtQNdE/akfw0O8Yolu1IBvkYMBtGNU4Y4V0zQe20RGtEolnESb/hAalJdFycg==", null, "NotSelected", false },
                    { new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2"), 0, new DateTime(2002, 1, 19, 15, 11, 30, 187, DateTimeKind.Local).AddTicks(1829), 210.0461395818240000m, "cdc8ab44-2adb-4cf2-a628-ce60068780b4", "Lewis", "Lewis", null, "Halvorson", false, null, "Lewis_Halvorson", "AQAAAAEAACcQAAAAEEqlEj22o/qv45M02HBsN+7rjBJx1+uuCnElWBjRLRzkZwPTYo7r5Ul/CfaztfyF+Q==", null, "NotSelected", false },
                    { new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52"), 0, new DateTime(1991, 2, 4, 23, 39, 34, 684, DateTimeKind.Local).AddTicks(7588), 312.6778582408350000m, "5d8fe694-76af-4e4b-b4d9-36ef5f5f169b", null, "Sherman", null, "O'Connell", false, null, "Sherman_OConnell43", "AQAAAAEAACcQAAAAENyndSflClUH9q/9D92+78RQ8efqneWrm2i1nBj6sjPD/4Wyxd/E2M8M01LjRY8Z0w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11"), 0, null, 871.2379889826440000m, "4fdf65f0-93a6-4f7e-85dc-d3de942c1ee7", null, "Ellis", null, "Considine", false, null, "Ellis.Considine67", "AQAAAAEAACcQAAAAEIALky1OuZXyEkogCvTW1R+QUaB6ItTHI5scQ/efyXnKGA/VvUTfCR1xy9H7Ez3fYQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff"), 0, null, 532.481888508190000m, "18c0eddf-c0cd-4922-b768-ea9313c28d86", "Carrie", "Carrie", null, "Oberbrunner", false, null, "Carrie8", "AQAAAAEAACcQAAAAEA3xfiZmJ1EN5yooRUG+WTFfoHdzutify3c/cXJ5UNyqFxo54ufawQb1yvkkAkxHsQ==", null, "NotSelected", false },
                    { new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982"), 0, null, 252.4727087686740000m, "b7c921f7-3dc8-4403-ae33-a7d7abfd1970", null, "Debra", null, "Cremin", false, null, "Debra.Cremin66", "AQAAAAEAACcQAAAAECiZegDi1tn96RfCglLqO5WQNScERr3fHefPmfeyiLkomXHtHSkuDYuLl7bimKMcIQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d"), 0, null, 518.3935607493540000m, "b4aa8067-e4fc-4847-a3af-570cf0f1938a", null, "Holly", null, "Casper", false, null, "Holly.Casper71", "AQAAAAEAACcQAAAAEE8Qe7sAySiffTZO19anYZoQUSRoT8nSJJrBSEOliVp/mRVMWbjFUokhHsWFV37q2g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0"), 0, null, 235.8859078370220000m, "7c10b2bc-8cd0-44f3-a3d8-b0333351bfa0", null, "Samuel", null, "Greenholt", false, null, "Samuel.Greenholt47", "AQAAAAEAACcQAAAAEAYR7E3+NcG8ZOAylOMM0h22L5IVNSzBMuBM0zzg9fXYArNRHunmlR/iw8/AzGoELg==", null, "NotSelected", false },
                    { new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262"), 0, null, 229.7513090639180000m, "1ce12e6b-678c-445f-919e-1027ca7e13d9", null, "Freda", null, "Thiel", false, null, "Freda69", "AQAAAAEAACcQAAAAEA47rDI36Wvuy3KVAtAXdTrSnr4r47A3HNJlO8V1TGUmqHGwgVb+oWzEFexigiKsUQ==", null, "Female", false },
                    { new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618"), 0, null, 46.19662168551440000m, "4d52e5e4-c7ba-4bf1-9acf-4888b3966d49", null, "Tasha", null, "Champlin", false, null, "Tasha_Champlin20", "AQAAAAEAACcQAAAAEOuDf8IaQG1RfYdAWlINOEP4A3d9/kcS5VTvrsDKODxu2kbmbI5WQSZezTwBLYWFkw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fc218112-8b42-4598-a25c-227112647fca"), 0, null, 195.3406157024850000m, "484389fa-7bef-4952-b4b5-d43768f99729", "Mae", "Mae", null, "Bechtelar", false, null, "Mae29", "AQAAAAEAACcQAAAAEO8wlWCPUp0Al0YEie9GS775mF8fsf0PJpWkTIu/coZ/YA0MtGH7yUD7qV6dNiC6hA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fd051a5e-4258-4bbf-b64a-29676b007443"), 0, null, 775.0998769254630000m, "228df7bf-106f-4b0f-8ca0-e3fc96524e3e", "Juana", "Juana", null, "Walter", false, null, "Juana_Walter", "AQAAAAEAACcQAAAAELADR9ojCN9qjX6PgjmJEkwS3Itl6FuG6PssALCL2qOI8T64Ynxm0pUGbcEVQS3qpQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f"), 0, new DateTime(1976, 11, 11, 20, 43, 33, 437, DateTimeKind.Local).AddTicks(560), 258.8500746257090000m, "b640391f-a003-4479-9285-b300aabc71a2", "Rita", "Rita", null, "Conn", false, null, "Rita.Conn92", "AQAAAAEAACcQAAAAEOQ0BzVC0GW7wfJ2subPtxL7MreKpTFMLqOIoZAsakX5SbiTVhS0dL47uomQIm8NpQ==", null, false },
                    { new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37"), 0, new DateTime(1961, 12, 26, 15, 17, 19, 980, DateTimeKind.Local).AddTicks(9248), 242.8297432416110000m, "983e1462-4b27-4fb6-ae00-31d224354568", null, "Jennifer", null, "Botsford", false, null, "Jennifer_Botsford", "AQAAAAEAACcQAAAAEOsAjfBJz6m/MsLA7VLuvfYLCWpqjrjAEMQuIQ3fXgCh4Duv7ONuq/iB5drfW6yIkw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b"), 0, null, 449.0956675245610000m, "4e58500e-bc7e-44f3-ac58-5fed9571186b", "Bryant", "Bryant", null, "Simonis", false, null, "Bryant.Simonis", "AQAAAAEAACcQAAAAEEYO2V7CnDuZD68HMhhD+5yvDygsw9kabvffiO+M8sppVvleSShi3pdR4AyusvdbUA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("022db5f2-19b9-4f2b-996f-a43976ce80b4"), "48,285763;29,230536", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Imaside, Guam", "Davis Islands, 62806", 154 },
                    { new Guid("05870b14-9152-4ebb-bca3-6b7e4e9590c8"), "48,65941;26,820353", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Earline, Tonga", "Katherine Circle, 16056", 68 },
                    { new Guid("05c97cff-b6da-495f-83e6-3d8c6c5c4d76"), "48,976852;25,368927", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Buddy, Faroe Islands", "Emelie Springs, 04039", 89 },
                    { new Guid("0709dcc6-cb13-4fed-a0d7-2823a8fdb607"), "50,846714;23,585796", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Amiraburgh, Bosnia and Herzegovina", "Keebler Brooks, 05355", 2 },
                    { new Guid("07338213-2f73-4df2-acc0-5b9748c407bd"), "48,090614;26,588627", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Jerel, Netherlands Antilles", "Cody Passage, 8644", 11 },
                    { new Guid("08f03831-debb-4b50-b36d-5eeb8cdc37f4"), "50,54827;23,853695", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Trishachester, France", "Myron Loop, 53985", 104 },
                    { new Guid("09874e53-8c12-41de-83d1-c5ed35e7674e"), "49,938923;30,98968", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Theresiaton, Japan", "Ephraim Crossroad, 052", 124 },
                    { new Guid("0e2352c2-7003-4e1f-b403-02ccc0e17724"), "50,850883;28,409063", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lelahtown, Christmas Island", "Koelpin Hollow, 66710", 78 },
                    { new Guid("10dad55b-3051-47fc-ab1a-a8beaa3f9fb7"), "49,967113;29,130466", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bruenside, Tonga", "Veum Mountains, 758", 16 },
                    { new Guid("16b8d875-9573-4489-8c5a-5f034a08c35e"), "48,7209;27,432161", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Asiamouth, Mali", "Louvenia Crescent, 85388", 186 },
                    { new Guid("1b6af4ac-4168-48c6-825c-941c77d26738"), "49,411854;28,276493", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Annamaeton, Martinique", "Cormier Islands, 0815", 134 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("1d64e418-fe08-4e1e-8d85-4efd1097908b"), "50,518417;30,769648", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kolbyfurt, Dominican Republic", "Nicola Meadow, 0523", 16 },
                    { new Guid("23a44ef9-18b9-4840-ae5a-99a2855c1c96"), "50,006447;26,804098", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Laurinefort, Jordan", "Earl Canyon, 058", 150 },
                    { new Guid("27804530-9aec-4dd5-ad94-34821cfe8e7a"), "49,192883;23,766739", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Garfieldport, Saint Lucia", "Kutch Ridges, 47001", 195 },
                    { new Guid("2a1ee4ec-ae44-4660-aeb8-e9a50af02520"), "48,618416;25,090155", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Lia, Costa Rica", "Koelpin Valleys, 6523", 125 },
                    { new Guid("2cad886a-f84c-4904-baee-d92b1598b948"), "48,798794;23,301481", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Elinore, Romania", "Shane Loaf, 41578", 8 },
                    { new Guid("2ed956c6-d7b7-4227-9938-b6a3cbeca0d2"), "48,85903;26,702904", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Alyce, Seychelles", "Jeramy Summit, 19703", 100 },
                    { new Guid("30a67762-41e9-4613-94c1-6acc7ed58c2f"), "49,321987;24,632471", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mohammedfurt, Austria", "Izabella Shoals, 60628", 54 },
                    { new Guid("33a35021-c0d6-4b21-8a9b-d44e803df632"), "48,16029;26,931322", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Blanca, Wallis and Futuna", "Rebekah Ways, 74355", 107 },
                    { new Guid("3566f855-0948-4c70-b135-a7d61fba6ac8"), "49,35325;26,696692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Angieland, Guernsey", "Cruickshank Neck, 71145", 13 },
                    { new Guid("3635afb4-1f25-40b2-990d-9bf8a97f497c"), "48,49361;23,41193", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Garnet, New Zealand", "Irma Square, 258", 127 },
                    { new Guid("371bcf29-70fa-448c-9b8a-1ff6ffda1f58"), "50,102203;25,616234", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jayceetown, Netherlands Antilles", "Hills Mission, 291", 9 },
                    { new Guid("3819733c-6c71-46dd-8b87-958e9e1f349e"), "50,252556;26,208641", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Moniquefort, Vanuatu", "Brown Passage, 824", 98 },
                    { new Guid("3c5c7988-2687-4c88-8fb0-d3a1de4ba83d"), "50,565533;26,029152", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Elnora, Brunei Darussalam", "Watsica Summit, 974", 77 },
                    { new Guid("3d3f4074-48c2-4c6b-badc-681976b2fa63"), "48,36378;27,000444", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Donnellyton, Saint Pierre and Miquelon", "Jakubowski Valleys, 64950", 11 },
                    { new Guid("3d956088-4423-464e-8efc-92378533f911"), "50,20919;24,549603", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "McDermottberg, Argentina", "Russel Villages, 66582", 150 },
                    { new Guid("4086b326-16a4-4a32-b751-552499126ea4"), "48,661144;25,543997", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Johnathonton, India", "Tremayne Extensions, 031", 119 },
                    { new Guid("4688ecfe-ca83-47ca-8906-648c067f2f52"), "48,911076;27,10443", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Lilyan, Brazil", "Darrick Club, 96311", 129 },
                    { new Guid("478fd918-8d28-4c2e-89cb-27d3a145bdd7"), "48,186783;30,210066", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ferrytown, Philippines", "Quinten Heights, 569", 42 },
                    { new Guid("49a6a22a-c2c3-45e0-a5de-9c6bb6721b09"), "48,005074;25,435314", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Vergie, American Samoa", "Wiegand Station, 62950", 177 },
                    { new Guid("4b6c5da5-c1ab-4fcf-8ec8-fa3852bac42c"), "49,676537;24,409689", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Riverview, Spain", "Marie Summit, 723", 123 },
                    { new Guid("4b9189b7-1f8f-44bc-a3c2-2e4d546adfff"), "48,84743;27,061316", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Janellemouth, Belarus", "Erica Walks, 533", 78 },
                    { new Guid("4bf7b44e-d1c1-4d3e-a1a2-ea5a7fca4f8d"), "48,83043;29,72222", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Leetown, Kenya", "Moses Plains, 7184", 28 },
                    { new Guid("53e15c29-a418-4012-b4c9-9a766e994648"), "50,465687;23,756409", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harveytown, Cuba", "Reid Valley, 0816", 182 },
                    { new Guid("56424ed1-921a-4063-abdb-2bd2a0003da5"), "48,331047;30,283054", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Lupeburgh, Libyan Arab Jamahiriya", "Steuber Overpass, 4784", 56 },
                    { new Guid("57a39ebc-7161-40c5-87ed-0e295c059326"), "48,37093;24,787", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Emanuel, Bhutan", "Kianna Course, 5750", 137 },
                    { new Guid("580446cb-27f6-4644-a9db-76eca91768df"), "49,768707;23,974894", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Jakob, Barbados", "Jeremie Light, 29340", 17 },
                    { new Guid("58d0d1c1-6e01-4b3f-96d0-1d7ba6db415e"), "48,59754;24,4562", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Malcolm, Iraq", "Theodora Summit, 67306", 60 },
                    { new Guid("58fc610f-5227-4df8-b28c-ddcfd4941cf9"), "50,873653;24,871576", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lubowitzberg, Falkland Islands (Malvinas)", "Jacobson Ville, 6563", 90 },
                    { new Guid("59a34075-c9de-4988-ad9e-e29d52adc419"), "49,940598;27,560266", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Columbusberg, Tajikistan", "Amani Knoll, 33470", 152 },
                    { new Guid("5afb3456-a489-4267-b95c-a4e9283f2bff"), "50,120865;30,961613", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Rupert, Pitcairn Islands", "Maximus Dale, 62574", 191 },
                    { new Guid("5d67e914-dadd-4cce-b287-8a8188c890d0"), "48,032005;25,900585", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Jaedenville, Micronesia", "Pierre Green, 211", 23 },
                    { new Guid("64310fd3-2cd4-489f-91c2-8357f01cbdeb"), "50,57579;24,114954", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Dennisbury, Nigeria", "Barton Gardens, 3613", 116 },
                    { new Guid("6a2b484a-1660-4d1a-b9e1-3e9d6ffc48cb"), "48,95498;24,771837", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Franciscachester, Honduras", "Hills Ville, 536", 109 },
                    { new Guid("6be9c9f1-92e7-489e-9947-28c4ebcb07da"), "49,982758;29,48182", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Elmiraport, Moldova", "Russel Ports, 38021", 187 },
                    { new Guid("6fc51828-431f-4573-9779-bf2052aaaf7f"), "48,32998;27,217937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Billyside, Madagascar", "Janick Haven, 16915", 53 },
                    { new Guid("71a429c5-a18d-4115-8434-fc269dc94af8"), "48,40882;27,253288", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Salmaside, Czech Republic", "Marks Knolls, 9720", 88 },
                    { new Guid("72859e52-851b-4054-ae86-c767983d5e10"), "50,854694;25,498291", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Evalynfort, Georgia", "Damion Cliff, 13683", 199 },
                    { new Guid("73eb64bd-c584-4b40-883c-f8b91ece15d5"), "50,95149;23,421448", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Breanne, Tajikistan", "Langosh Extensions, 5951", 113 },
                    { new Guid("74ed015d-4f6f-4a03-929f-bf29a9a5465e"), "50,387302;27,488014", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Boehmmouth, Faroe Islands", "Walsh Vista, 617", 96 },
                    { new Guid("761fbb7b-9424-46c7-b9f6-195a7c75b6e2"), "50,99452;29,003466", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Joshuachester, Portugal", "Grady Station, 887", 77 },
                    { new Guid("77acbfc2-c37b-42e2-9384-292aa3858fc5"), "48,586056;25,58053", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Jettbury, Guadeloupe", "Rodriguez Radial, 134", 181 },
                    { new Guid("7fcc6a98-5e0d-4123-ba72-89c2f17917b4"), "50,661858;24,871536", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Camilla, Seychelles", "Camron Shores, 76049", 4 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("82fa8a68-7c62-4d2d-9ec1-28fc765fdffa"), "50,607857;26,76263", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Garthshire, Botswana", "Koss Locks, 4363", 108 },
                    { new Guid("8328981e-6b28-4c8c-8ebd-89ef6ab17b18"), "48,755608;23,930054", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Willard, Panama", "McLaughlin Overpass, 59093", 76 },
                    { new Guid("862e639c-7bfe-4dfc-9def-941d3707a5fe"), "49,95487;29,942333", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Brennaberg, Guernsey", "Roberts Groves, 063", 27 },
                    { new Guid("86a9cac6-fd54-4e03-ad04-f93675c24791"), "48,317066;27,381176", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Camdenborough, France", "Maximo Oval, 675", 86 },
                    { new Guid("8cbc0560-85c1-4b7c-b2b9-8c8c65fe154c"), "48,41731;27,977028", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wolffmouth, Bouvet Island (Bouvetoya)", "Wintheiser Pine, 6087", 117 },
                    { new Guid("8e9425a9-3110-4584-a8fb-66222e1b9aa9"), "50,033592;25,97063", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Zola, Jamaica", "Edmond Trail, 54214", 188 },
                    { new Guid("8f865813-2262-4054-87da-c015db4a0235"), "48,64864;29,58773", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Aron, Liechtenstein", "Wilderman Road, 397", 58 },
                    { new Guid("914f881e-6b16-49ef-923c-e91e082d05f8"), "49,358208;24,185328", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Alfredoville, Rwanda", "Treutel Tunnel, 851", 34 },
                    { new Guid("94139268-6a1f-4b2e-b825-fbd4b0e0711b"), "49,091534;30,470518", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Lucius, Nigeria", "Zboncak Run, 172", 160 },
                    { new Guid("97231493-8969-4e74-8936-53d5690827a2"), "50,99407;27,20013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Candidomouth, New Zealand", "Dayne Rue, 8713", 129 },
                    { new Guid("997fd38f-02ba-4a6d-b43a-34fe57c88da5"), "48,68414;23,64763", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Vernie, Lesotho", "Olson Trafficway, 02342", 26 },
                    { new Guid("99b386f1-5066-41bc-98ff-afddcdcbe48e"), "48,37422;27,238838", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Ethanville, Chile", "Nia Isle, 2683", 78 },
                    { new Guid("9cb0571a-fdd1-49e8-8be2-eeed49e9e99e"), "49,324722;25,150427", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harveymouth, Saint Lucia", "Ward Summit, 230", 143 },
                    { new Guid("a1921631-07bd-47f8-8776-c4bb40b4c0c4"), "50,988247;23,676432", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Kailey, Western Sahara", "Ullrich Cliffs, 44802", 57 },
                    { new Guid("a2a3c981-0806-43fe-b4bd-96fcfd693dc2"), "50,140163;30,255703", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sauertown, Micronesia", "Nicolas Road, 37887", 7 },
                    { new Guid("a9b58ae5-26f8-4f3c-b9b5-4b6adfe42ea8"), "50,900078;30,383877", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Abnerport, Papua New Guinea", "Aufderhar Gateway, 851", 132 },
                    { new Guid("aa53d527-3ab5-43be-808f-6dc388ecfa87"), "50,01486;26,54183", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Dorcasburgh, Comoros", "Ryley Ville, 72988", 104 },
                    { new Guid("aba12287-2115-48ce-9214-7413d0c96fbd"), "50,435223;30,931017", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Morarshire, Greece", "Rohan Cape, 08280", 175 },
                    { new Guid("ac5247aa-8ea7-480b-90ac-d98ab7183b53"), "50,037067;27,66046", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Eulahstad, Moldova", "Johanna Extension, 416", 66 },
                    { new Guid("acde6743-2036-4713-92ba-ca9a53f79bab"), "48,432537;30,46866", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Aprilborough, Spain", "Lottie Ridge, 0926", 167 },
                    { new Guid("ad0267d0-8c23-445f-b75a-21045c581d4d"), "49,981712;26,011602", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Adriel, Cote d'Ivoire", "Boyle Shore, 861", 141 },
                    { new Guid("ad43ab8c-3d09-42fb-8630-0224ece47ef9"), "50,268604;30,01134", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Karlichester, Madagascar", "Hintz Manor, 852", 107 },
                    { new Guid("ae29c454-29a9-41b8-ad91-973ad662c4ee"), "50,974724;30,321178", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fatimaburgh, Mauritius", "Charley Fork, 0178", 39 },
                    { new Guid("af03bb8d-d319-469e-8f61-3178a4da9de3"), "49,659634;24,001017", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Brenda, Macao", "Micheal Knoll, 481", 126 },
                    { new Guid("b113f480-b160-4d90-94a2-42fbdd3afdd1"), "50,419758;25,02304", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Monahanbury, Belarus", "Torrance Throughway, 561", 111 },
                    { new Guid("b7f503b5-54e6-469d-95f5-32242964d036"), "50,76383;24,861555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cronaside, Switzerland", "Prohaska Drive, 2566", 16 },
                    { new Guid("b911d01d-0b37-43ea-9544-5580e5b29e9a"), "50,683456;28,444998", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Lenora, Guadeloupe", "Arnaldo Groves, 1891", 112 },
                    { new Guid("baf2a792-b3b9-4437-90d2-1d70e9a826f0"), "48,70849;24,076435", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Kyliemouth, Western Sahara", "Altenwerth Run, 52134", 192 },
                    { new Guid("beea5e38-690d-483c-aba1-403b53470c5b"), "48,23757;26,861385", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ellamouth, Mauritius", "Alexandra Greens, 44699", 10 },
                    { new Guid("c712f5da-6f8d-4d90-9d09-59874198d0c6"), "50,328697;23,684895", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Milfordborough, San Marino", "Hauck Turnpike, 7663", 44 },
                    { new Guid("caf68574-fcc4-4e12-832b-ed2363d1b6aa"), "48,625614;25,732973", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Aidenmouth, Mongolia", "Hansen Prairie, 14002", 178 },
                    { new Guid("cfd25cff-f887-4076-9633-34a1216746cd"), "50,3606;27,857325", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dibbertland, Ecuador", "Wilber Common, 19824", 77 },
                    { new Guid("d67f3664-9478-4003-9c2d-f8fb3e202c59"), "50,881042;27,852709", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Justus, Ghana", "Furman Fork, 7327", 187 },
                    { new Guid("d82a0534-bc1c-4bbf-9e7b-ce5ef64a3bba"), "48,03839;27,93093", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ebertmouth, Mauritius", "Gina Walks, 545", 146 },
                    { new Guid("d940ce1b-0a80-40e8-aa74-329258d5e70d"), "49,274776;23,214525", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Akeem, Austria", "Angie Center, 109", 78 },
                    { new Guid("de6daa9b-8d65-45b5-97e0-d6c9fcd9169a"), "49,721928;24,521929", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ovafort, Wallis and Futuna", "Leonel Cliffs, 6266", 158 },
                    { new Guid("e1fa2d6a-0f76-4cd8-9ab5-a73dc844c81a"), "49,09567;25,030321", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bergstromton, Serbia", "Skiles Passage, 30418", 152 },
                    { new Guid("e4050e14-f905-492c-a12e-2834f9b3f054"), "50,24602;28,437641", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Heidenreichmouth, Heard Island and McDonald Islands", "Murphy River, 13283", 196 },
                    { new Guid("e52c29c5-245d-4a96-a17a-0afaa2f02d69"), "48,481724;27,053804", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Ashlynnport, Trinidad and Tobago", "Kavon Viaduct, 328", 141 },
                    { new Guid("e54ff9a7-c847-42bf-9c5c-ab9057b75f4c"), "49,670532;25,667015", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Gabe, Burkina Faso", "O'Connell Plains, 35789", 25 },
                    { new Guid("e9c4a6c9-50b1-4959-ad67-df580f829919"), "50,561954;23,110245", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trantowshire, Kenya", "Romaguera Mountain, 330", 95 },
                    { new Guid("eba11228-da24-4b2b-aac4-5f004c9f748d"), "48,681778;27,822344", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Evalynburgh, Spain", "Ollie Mount, 6137", 118 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("ebb147ed-0d81-4dde-b133-38b3cfcd60ad"), "48,666344;26,892988", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fanniefurt, Brazil", "Leannon Flats, 902", 67 },
                    { new Guid("eeb45b39-973f-47e5-b4a3-c2eb8784e6a0"), "49,299686;28,704912", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Johnsberg, Northern Mariana Islands", "Itzel Mount, 59481", 176 },
                    { new Guid("f5f58900-f578-4681-8cf1-b36c842fdc7b"), "49,887024;26,571964", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Beermouth, Germany", "Mills Point, 7841", 87 },
                    { new Guid("fadd1365-8aeb-4e73-b9fc-bdbfd3c3a75b"), "49,728794;27,491718", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Leliaberg, Ukraine", "Dolores Wall, 767", 32 },
                    { new Guid("fb163225-5089-4f2a-838b-2b4e00e3fa7f"), "49,362835;28,398947", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trantowtown, Kenya", "Christopher Mountains, 405", 124 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("003d1887-4605-4fdb-ac60-2e4133d54cff"), 165, "48,654408;25,437832", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Jasper, Anguilla", "Kautzer Islands, 88304" },
                    { new Guid("00ab1739-bbe2-4050-9aba-441595a7f605"), 96, "50,541523;23,268135", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Earnestine, Bangladesh", "Savion River, 16047" },
                    { new Guid("00af6535-5795-4f10-92be-1975fc8c5ea7"), 179, "50,20319;28,099258", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Haleighview, Colombia", "Royce Locks, 72490" },
                    { new Guid("0db9d408-a643-4160-8c2c-790571da471d"), 69, "48,664318;29,622437", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mariannachester, Tunisia", "Blaze Isle, 7598" },
                    { new Guid("129d53af-c696-40b3-8d1d-a2398cd64b07"), 49, "49,04954;23,025719", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Creminshire, Tuvalu", "Brenden Fords, 036" },
                    { new Guid("154ef1ad-ea7c-4deb-882f-78a73c45a0ab"), 169, "49,30854;23,147142", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Kirstin, Azerbaijan", "Hilma Stream, 717" },
                    { new Guid("180ddbb2-63d7-480b-9b85-cc42673359b8"), 134, "48,099144;26,65721", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Hopeport, French Southern Territories", "Stoltenberg Light, 10432" },
                    { new Guid("1c6a6a1a-dbf0-471e-a030-dc9d42448867"), 100, "48,471977;25,643448", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Fredyfort, Northern Mariana Islands", "Roberts Junctions, 5097" },
                    { new Guid("1d5c37c9-e8b7-4205-8c47-593124d38fca"), 1, "48,737873;24,406662", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fadelview, Palau", "Sherman Forest, 03183" },
                    { new Guid("1ea52291-fc3f-41c6-b947-d538d9086ab7"), 80, "50,40682;25,427475", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Juston, Ghana", "Fahey Walk, 02415" },
                    { new Guid("22a1b76e-b1f2-45a3-af31-bb85fa77b888"), 126, "50,03817;24,175098", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Alizaburgh, Turks and Caicos Islands", "Barton Knoll, 104" },
                    { new Guid("297ebbfd-ee68-474b-8422-8d7001f75f0b"), 17, "49,086388;29,97121", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Amiya, Ghana", "Ozella Run, 65230" },
                    { new Guid("29a96da0-7e18-4de3-bdef-8dc4fea533d1"), 169, "49,199844;29,70103", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Ericka, Papua New Guinea", "Anderson Shoals, 35148" },
                    { new Guid("2ed08553-7531-4af1-813e-b7c92275edcd"), 54, "48,052135;23,194489", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wuckertshire, Bahrain", "Miller Forks, 7593" },
                    { new Guid("33640849-1b46-4a2a-95ca-20707a68d326"), 77, "50,511787;23,185863", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Elmomouth, Iran", "Afton Parks, 511" },
                    { new Guid("394e0840-e4ce-456f-b070-33ff8849f936"), 7, "49,415653;25,318933", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Janetfurt, Liechtenstein", "Bahringer Dam, 16237" },
                    { new Guid("3a1ff7cd-0556-463a-abcd-3ff30af7d96e"), 177, "48,48083;30,89088", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Ardenshire, Papua New Guinea", "Schulist Highway, 423" },
                    { new Guid("3e81abac-1f31-4d52-a037-ace3783b85cc"), 56, "48,30072;29,726452", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dachburgh, Pakistan", "Edyth Stream, 8216" },
                    { new Guid("3fb331fe-fdcc-48c9-9ba1-222caa307100"), 78, "49,723373;30,424282", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Douglasfurt, Vanuatu", "Schoen Court, 3212" },
                    { new Guid("402d9648-11b5-4cb6-a484-9d113fbe204a"), 147, "50,377525;24,462421", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Darrelhaven, Sweden", "Pietro Lights, 253" },
                    { new Guid("46e9c672-761b-4083-8bd2-ea6ba4231ac1"), 47, "50,991272;26,053434", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Janishaven, French Guiana", "Ryan Land, 4133" },
                    { new Guid("488c9f59-55c7-4b03-9a06-9d3072f4175e"), 100, "50,29312;29,30858", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nolanfurt, Samoa", "Antonia Circle, 737" },
                    { new Guid("4b68efca-a678-4f05-880d-e490e94207ed"), 74, "48,27095;29,797215", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Leannville, Guam", "Rigoberto Bypass, 20457" },
                    { new Guid("4d94c68c-7ab2-401c-8374-17bebc2be091"), 54, "50,82013;28,97222", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Micahfurt, Belize", "Orn Harbors, 74339" },
                    { new Guid("4f481994-373a-410d-ac3d-cd0cf8f8b91a"), 63, "50,999397;23,273338", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jaquelinburgh, Hungary", "Predovic Lake, 30505" },
                    { new Guid("516cec43-ec54-4ecf-8d5c-93bfafe4c8a6"), 150, "49,6347;27,348425", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Katrina, Nicaragua", "Sanford Bridge, 752" },
                    { new Guid("5183d45d-7b99-4bf2-9900-625901debc6d"), 41, "49,724995;29,022484", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Chelseyburgh, Denmark", "Dickens Hills, 78731" },
                    { new Guid("51e960b5-8b98-414b-8d20-de036f813f8d"), 187, "50,892708;26,415564", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Patsy, Spain", "Cary Shore, 5249" },
                    { new Guid("5200c01a-8687-477d-b812-8e91914001c6"), 66, "48,72171;30,667469", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maxiefurt, Finland", "Dortha Circles, 021" },
                    { new Guid("550261b8-07ba-41b8-80f5-9c53db724fbc"), 2, "49,568264;30,168882", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Eleonorebury, Armenia", "Torphy Route, 2723" },
                    { new Guid("5b3d04d1-99f7-490a-badb-10d82779169f"), 181, "49,026653;30,514704", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bechtelarview, Luxembourg", "Sterling Hill, 4080" },
                    { new Guid("5d48cb88-ca0d-4da1-9b53-5ef826784312"), 120, "49,516796;23,62648", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Rahulhaven, El Salvador", "Rodrick Vista, 45281" },
                    { new Guid("62ac64f7-bddb-4122-94a8-d71bf4b9f5d8"), 147, "50,76342;27,732077", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Antoinettestad, Honduras", "Fritsch Plain, 67995" },
                    { new Guid("62bc0596-aa6b-40ce-808f-bbe457377085"), 175, "48,80795;25,351585", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Danykastad, Suriname", "Casper Turnpike, 1943" },
                    { new Guid("62e8c22a-429d-4ea5-8846-b0f1d16f469e"), 50, "49,720642;30,491812", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Asa, Zimbabwe", "Zakary Crossing, 383" },
                    { new Guid("67e54b10-bc50-4ce6-9193-22cd543ef7ee"), 94, "48,83638;23,419876", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Goyettestad, Tonga", "Milford Street, 9803" },
                    { new Guid("6d15825f-6c9c-4273-8e1e-a68b023d8a4c"), 174, "49,208862;26,787592", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zoeybury, Virgin Islands, British", "Marvin Mill, 294" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("749a0eb0-9c70-4dd5-993c-6ae561de3f7e"), 193, "50,23661;27,590315", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Emiliabury, United Kingdom", "Quitzon Village, 1592" },
                    { new Guid("75486ce7-cadf-4737-959d-935dff0c6fca"), 67, "50,7522;23,475798", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Olsonville, Benin", "Antonia Rest, 3228" },
                    { new Guid("7929b9f6-b11c-42b5-a0f3-6a02091450a5"), 160, "49,79209;29,6549", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pagacville, Yemen", "Amanda Common, 08286" },
                    { new Guid("793c0670-4d9a-4da8-9275-444d022476ad"), 170, "48,402332;29,059793", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schultzfurt, Croatia", "Conroy Crescent, 68196" },
                    { new Guid("795b8a9f-c63f-4f9a-b304-55d3368470bf"), 87, "50,167625;29,063122", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ashlee, Romania", "Rahsaan Fall, 891" },
                    { new Guid("79f78891-3316-49d7-b145-fca984270195"), 49, "48,970856;27,271246", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Janie, Gibraltar", "Wallace View, 61312" },
                    { new Guid("7a33226e-a0af-4636-bdc1-513e6dd2e934"), 174, "48,751106;30,013853", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Janismouth, Turks and Caicos Islands", "Keeling Ridges, 544" },
                    { new Guid("7f419b6c-598e-44c8-b631-bf01c71069c1"), 135, "49,39858;23,250793", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Stephen, Macao", "Raven Springs, 1331" },
                    { new Guid("7f5b847e-76d7-4ab8-ab4f-29504de667c3"), 169, "48,08877;23,18677", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Christiansenview, Syrian Arab Republic", "Breitenberg Junctions, 20723" },
                    { new Guid("814b34fd-7e90-4dad-9b80-e36bc4e6df53"), 129, "50,900562;27,870872", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Greggberg, Brazil", "Runolfsdottir Junctions, 583" },
                    { new Guid("8200cab7-7ed3-44a5-9c49-ad9e2da6ac5c"), 107, "50,091923;25,853708", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Violet, Guinea-Bissau", "Yessenia Ramp, 81708" },
                    { new Guid("837176aa-2bd4-4699-bc91-206f25aff235"), 118, "50,713352;27,951809", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Demondfurt, Tuvalu", "Sonya Knoll, 1115" },
                    { new Guid("84007fa2-0074-4e40-9b2f-94e32a81fcb5"), 59, "50,99001;29,582966", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Alycia, El Salvador", "Annamae Plains, 444" },
                    { new Guid("88b66bcc-1769-49f0-8097-43cbd801dac5"), 34, "50,510574;26,24523", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Brennonside, New Zealand", "Bartoletti Ridge, 7740" },
                    { new Guid("8d4203bf-e57f-47bd-814c-41131e3f3184"), 159, "48,08127;27,494534", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wisokyborough, Aruba", "Zita Coves, 0067" },
                    { new Guid("8d5e9072-3d3f-47ff-991f-848f9c7339e8"), 102, "49,12402;24,005903", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kuhicshire, Austria", "Adrienne Junction, 080" },
                    { new Guid("8ea8bc44-8370-443f-ac03-8d47435b44eb"), 132, "48,071583;29,861715", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jaclyntown, Guinea", "Maureen Passage, 557" },
                    { new Guid("9124e454-4061-4899-8d78-fd7220ce74cf"), 72, "48,735004;26,61697", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Colton, Estonia", "Cartwright Passage, 7888" },
                    { new Guid("921d5b7a-2504-4e61-b423-23fbdd44d571"), 138, "50,76818;29,480478", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Aliciabury, Iran", "Marvin Causeway, 8657" },
                    { new Guid("956937b5-c5d5-4e7a-b10c-cd51f7fc23ee"), 52, "50,123966;23,334238", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mohrland, Slovakia (Slovak Republic)", "Elisabeth Pines, 60191" },
                    { new Guid("9914adaf-5b20-4e6b-86db-165b0b379a84"), 4, "48,502304;25,553505", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kiannachester, Gibraltar", "Doyle Island, 363" },
                    { new Guid("9c1c0c6c-4bdc-498d-a4dc-732cafa5fc4f"), 23, "49,592705;23,551302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Aprilstad, United Kingdom", "Langworth Glens, 43198" },
                    { new Guid("a04d7f2b-fcc9-4b82-ab0b-857c9c2eeda3"), 52, "50,030807;23,24348", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Batzmouth, Albania", "Roberts Highway, 825" },
                    { new Guid("a0700f7c-9e39-47d7-bb7a-bb7a7641131c"), 35, "49,560722;24,26803", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Reingerfurt, Malaysia", "Selina Overpass, 83887" },
                    { new Guid("a13ced50-96aa-4a30-994a-151ecd66f0be"), 126, "50,355316;25,313545", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kailynmouth, Kuwait", "Letitia Mount, 76342" },
                    { new Guid("a51e0f6c-9a17-4a01-9d6c-7a947902db64"), 64, "48,36195;23,686087", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Morissettefort, United States Minor Outlying Islands", "Alfonso Courts, 3387" },
                    { new Guid("a53bdfdd-2adc-4532-aec3-d83e87e22b65"), 44, "50,723156;25,16244", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Laurenceville, Serbia", "Will Mountain, 511" },
                    { new Guid("ad0f72de-e8ef-470f-b9ab-181d018653bd"), 137, "48,650143;27,052786", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Aurore, Guatemala", "Coy Tunnel, 687" },
                    { new Guid("aeb71f09-f9d5-44dd-8c09-d5c4b14a18fb"), 13, "50,364716;25,483194", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Orvalchester, Bosnia and Herzegovina", "Tiffany Circle, 6289" },
                    { new Guid("b0c169d6-6f62-40fc-a40c-b60b187b1567"), 50, "50,68214;27,573635", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Ciceroland, Mauritius", "Fisher Extensions, 18314" },
                    { new Guid("b1792941-81da-47f6-8685-6bd07895b5ef"), 164, "49,820015;23,12727", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Smithland, Eritrea", "Glenna Falls, 35435" },
                    { new Guid("b22d662d-091b-47cc-b1ae-e5957ecc1562"), 156, "49,692703;29,261984", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Willa, Heard Island and McDonald Islands", "Coy Way, 4964" },
                    { new Guid("b62d02f5-8e31-4de8-99e4-cf461717da24"), 38, "48,088974;27,84186", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Jarrett, Tajikistan", "Brekke Shoal, 04769" },
                    { new Guid("b6d6d0f5-8a27-4aa1-9911-2042278f4c45"), 94, "49,85707;28,82279", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Arjunmouth, Chad", "Cartwright Lane, 26187" },
                    { new Guid("b718d702-3f1e-425e-a270-b2883df7071c"), 194, "50,38286;25,933994", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Jovany, Jamaica", "Pascale Crossroad, 76249" },
                    { new Guid("b724bf06-e95b-42f8-9251-3d775cb3dbd3"), 48, "49,804672;25,829035", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Forestburgh, New Caledonia", "Wiza Expressway, 38990" },
                    { new Guid("b779f78f-6bab-4c26-b22f-47eff4d2c3f0"), 123, "50,93452;26,018982", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Charleneberg, Egypt", "Toy Trafficway, 478" },
                    { new Guid("ba4bfeba-9ef8-4902-a837-30e456300134"), 66, "49,845905;29,141697", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hyattfurt, Democratic People's Republic of Korea", "Moore Meadow, 158" },
                    { new Guid("bc3c8683-6976-425a-bb56-da905a5712d3"), 103, "50,714367;26,552929", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Codyberg, Djibouti", "Spencer Vista, 988" },
                    { new Guid("bd32ebc2-e84a-4897-9606-9d262e7389ce"), 3, "48,190216;29,74278", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Doraberg, Afghanistan", "Mary Plain, 4053" },
                    { new Guid("c3ff190b-d1c2-489e-9f4d-bb9adaabb568"), 155, "50,74675;27,014143", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "MacGyverbury, Lebanon", "Johns Junction, 00652" },
                    { new Guid("c42b5b3c-3999-4c13-a94a-b199a16f5ea7"), 33, "50,071087;28,991367", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Dellastad, Benin", "Madalyn Forks, 43593" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("c49dba6f-5344-4801-a0a9-258cd3d862c6"), 79, "48,069134;25,262133", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gilesstad, Benin", "Schinner Park, 3378" },
                    { new Guid("c6b55ccc-a820-4bbb-8527-3b9007d2baa8"), 171, "50,69279;24,744003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Adalbertoport, Guam", "McGlynn Inlet, 06910" },
                    { new Guid("c721412d-ec33-49d4-a3e6-7bb1e5519d38"), 9, "48,604504;24,988714", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Blake, Togo", "Runte Oval, 72006" },
                    { new Guid("c99151fb-1e40-4171-b25f-ebe08e5f264e"), 200, "49,604725;26,888124", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Imogene, Reunion", "Elinore Ford, 5026" },
                    { new Guid("cb5ee772-78b0-4831-97de-b2df713b6b9d"), 191, "49,498146;26,877947", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Isabellamouth, Malta", "Ozella Drive, 11051" },
                    { new Guid("cda90a60-8365-411d-9e1a-c206903d9b68"), 136, "49,98111;29,83276", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Trystanville, Guinea", "Halvorson Lake, 1121" },
                    { new Guid("cedc6c25-aa3e-46a1-ac91-58afab48903e"), 114, "50,95215;23,089384", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Andreaneburgh, Norway", "Legros Squares, 806" },
                    { new Guid("d6309bca-ef68-4ee7-a29b-c20aee2d5ee5"), 37, "50,668;25,22104", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zoeberg, Nicaragua", "Ramiro Crossing, 147" },
                    { new Guid("d7912e41-bde5-4fa2-bc59-44621b0d08f1"), 126, "50,188267;24,944162", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake June, Turks and Caicos Islands", "Leannon Shore, 4412" },
                    { new Guid("da7d6288-bdca-40b0-8854-8a1e640b029b"), 68, "50,68553;26,904547", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Zola, Cape Verde", "Columbus Ports, 035" },
                    { new Guid("dba043a5-daa3-4839-8807-68881d2a8e09"), 73, "49,3663;27,96428", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maryamborough, Guinea", "Cole Parkway, 6449" },
                    { new Guid("de51efc9-e48b-4898-8eb7-e3d50cfecbf2"), 173, "48,747883;26,52324", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Pearliehaven, Mali", "Hartmann Ferry, 14992" },
                    { new Guid("e6247e02-b2d1-4f64-86b7-0e89dcf5baac"), 93, "49,472004;26,263792", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Tyrese, Mali", "Dante Hills, 042" },
                    { new Guid("eca4e679-74a1-4a10-937f-ca2895f7a972"), 172, "49,02177;25,818144", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Tristonland, Tanzania", "Heloise Island, 52249" },
                    { new Guid("edcb3836-2d00-421f-a937-e581c0a8a218"), 184, "49,211437;24,0752", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Barbaramouth, Ghana", "Tromp Estates, 54488" },
                    { new Guid("eed649f3-b0de-4d80-bace-9bb909e59ab3"), 132, "49,206165;27,967806", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Magnoliahaven, Ethiopia", "Elda Green, 4655" },
                    { new Guid("f155b959-8472-41db-827f-77447f6d6e98"), 104, "48,201023;25,783274", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Naomieshire, Malaysia", "Chanelle Groves, 819" },
                    { new Guid("f47ce57b-f251-4739-8576-c369583722a0"), 23, "48,57404;28,131561", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Kathlyn, Marshall Islands", "Hagenes Centers, 855" },
                    { new Guid("f8062855-4189-4ecb-96ec-29c81195aa22"), 136, "50,5932;26,038721", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cristport, Honduras", "Cartwright Forge, 250" },
                    { new Guid("fc56c62d-a314-423e-94db-71149cb9f921"), 62, "50,792637;23,498466", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Runolfssonton, Palestinian Territory", "Rau Avenue, 2711" },
                    { new Guid("ff545d09-4e84-43e4-a88b-3279f3e0946f"), 100, "48,25894;24,097765", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Franciscotown, San Marino", "Shemar Ports, 00149" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("0037544a-4b5c-4b8a-9c55-58d30da0cac0"), 1478662343, 0.6118482830031440m, "3xSeAU5fuzQp7ZCRy4bvaiTg9t3mXBL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9858) },
                    { new Guid("06a2df68-c005-4e8b-b16a-ccf80fe248c4"), -1719934966, 0.905625034562970m, "34DVCRXwFgZjqQ6T7dnvtcAKYN1u8iHS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9920) },
                    { new Guid("0c5c87d3-75a0-4ac8-a001-579d8d3396d0"), -1687826675, 0.9569488604104080m, "3CqfbeEgHRUc1ZwmuX6vih5QBodWKJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5481) },
                    { new Guid("0d4e76d9-61c2-4db9-80af-a3c335b87359"), 1843688385, 0.8153409905902950m, "3HDEyThjbPFaUL2c5w9GSJBvtoixfeN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6224) },
                    { new Guid("0f85fc87-076e-4691-801a-81d8188a4d5e"), 894354978, 0.5569649244534410m, "LQXgVNJwteyDiLdoU39B4h8MTHkRE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6521) },
                    { new Guid("113cf477-bc35-4332-802f-3c634a405e85"), -934553343, 0.3514919709352330m, "L54EkyGfmLgeopAQ3XaNb9SMBiVYTx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(84) },
                    { new Guid("11825ab0-ffc3-48dd-a498-57a8c3f1e729"), 2140703838, 0.1437500260455620m, "3wnqmbvJ1Lfd2YZrcWikS593Dt4M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(231), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(229) },
                    { new Guid("131e3609-26a7-403b-b187-c65a7be6c431"), -884351732, 0.8196865542621060m, "L61GNMjL8YuxUvVzkXCa9T7Q5wiqAgD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5891), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5890) },
                    { new Guid("14f60579-87b2-44c9-a0d8-acae9d89f86c"), 1145173083, 0.168934500441820m, "LK9eNub67Z3Ftgj5fPmWLnhYXkT81Edx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(495), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(493) },
                    { new Guid("181f512a-1035-4f8a-8d0a-e3209e74763e"), -1129024996, 0.1534906890885480m, "MYVNKxocHSaWTkAiMuXn8mytdFJ6hq795", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5674) },
                    { new Guid("18906e1f-de41-42f7-a94e-f603be94ea42"), -489577254, 0.4510984303668930m, "3fYe62t9XZJkMCLAs5Wqi1HrnVaQcujw4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(536) },
                    { new Guid("1be12980-cb88-4792-a9aa-3603ca66cecb"), 1110673255, 0.437686832535160m, "Myz37csXvoRaJDk5F9CEZenb1hUB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9604), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9602) },
                    { new Guid("20d0d01a-a8e5-4643-ba9d-ce3ee992b5db"), 862549947, 0.6897126504778560m, "3QpXFHK9jVfGxqJaYE35zk8t1cRouAUN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5834) },
                    { new Guid("21356758-86fa-4e8e-bb29-e29fc7048e76"), -1224771882, 0.5091187142204520m, "31n7uXagEDCtfBWiR8KsNq2hJzjx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6716) },
                    { new Guid("221ea982-b844-467a-b5d3-7feca3eaa2a4"), 1583036646, 0.4414858954460040m, "MBvu2WezHxEQfMX4CaSJRsgpbc67", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9758), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9756) },
                    { new Guid("22414ef8-d26e-4ded-832a-56de9978eadf"), -1446418373, 0.04107219253839570m, "LmszybUkY1LDVfK9XB7Ta8qSNc6Z2vE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6575) },
                    { new Guid("228d80ac-b321-4a55-b80c-8225adc92d39"), 1006418056, 0.01579366407512740m, "3DX9WBVEte2FgUp5T6hKb8L3HQ4zv7r", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6661), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6660) },
                    { new Guid("248855c9-76b7-457f-b54d-a6755307e5ab"), 927456897, 0.03416183786238260m, "LQbuxtM2pBmTncAVi68eEjKCHvDqZYk59J", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5751) },
                    { new Guid("2dda5055-5d19-4764-a1c3-f505aa5ab1e3"), -265180941, 0.9051106488504740m, "3q948SLCHBsRc5kEfjQJ3KTt2UNn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9693) },
                    { new Guid("300ef942-ddfe-4bec-9342-28c5f450c457"), -457647954, 0.827379623970230m, "LYkmJR5HaQqAf7os6gXS4w8C3hrbFd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6482), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6481) },
                    { new Guid("32dc1af2-4fa7-48bd-8eaf-e2bce901862f"), 1744505512, 0.3875832338003240m, "M8UXHTAfdticD5okuwnRs9QFNLVh1z6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(455), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(454) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("38fc393a-88c0-4533-b278-71a40ea5cb1b"), -1001007787, 0.7668540284310030m, "Lyka4dQvoirS8c6wXWVzRNZ2M5LxqJ71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(412), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(411) },
                    { new Guid("3b5e7a3c-725d-4794-a161-b6c8a52ca346"), 1541475005, 0.4063688890208940m, "M8VTRKiGBf1vbWs5APhoH7DMLJzQ2jyZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6187) },
                    { new Guid("3e100a79-4104-43be-9674-b3eba837a5d5"), 1080192612, 0.3507173184442060m, "LhbYMyK3TfXsSLAUC6Dn1gjHr8tJp2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9776) },
                    { new Guid("41368ffa-7dc3-4756-9b02-36de8a0dae63"), -630121146, 0.03123618429740830m, "LTmA6YRwniecEMhGHkgsWzJLf2p5vj3Cq8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(393), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(392) },
                    { new Guid("4244b9be-0eed-4e26-95d2-15340cf696d2"), 1069433918, 0.08421776320896960m, "MXcE4Yd9KbvDnHmtTfpCRVWGAqz81B2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5991), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5989) },
                    { new Guid("43ea266c-15e5-4342-9b9b-04ddf7a0060c"), 487466857, 0.2157596860091350m, "LTyw3hU7qW2JXtAM5sfvngk9ujZp41ao", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5771) },
                    { new Guid("44910451-c166-44e3-b210-22584eaaa601"), 2137414919, 0.6146218082559890m, "3Xpyqkrm5Kjt7EUNMTVCFZvuzgS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9506) },
                    { new Guid("4635a599-0bfe-40ab-bd9b-29de309f4399"), 1470689241, 0.8083646729127480m, "McZbaWQxtU9g1rLPRshufqoEwGYNFz3iy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5722) },
                    { new Guid("496788f8-4c47-4248-a5ef-15d4d28e8904"), 2019176215, 0.01478221821476630m, "3ebtdXoR1nw5QqsYKp7xJLfGvygz8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6407), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6405) },
                    { new Guid("4a4435e7-7153-4052-b2d4-0116123966e5"), -1709370236, 0.3923350840347620m, "MEcoU92HxiVJT5fhBg6Qq8rMCD4wnktFNZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9560), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9558) },
                    { new Guid("51570933-157d-478a-aa40-01dac8efaf70"), 1154991720, 0.5656209548856950m, "M5MbjNLz9sYX4UZTg2h3ytcGnJSkCDp1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6110), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6109) },
                    { new Guid("561e6d7e-ae49-4ec8-947c-ece2bc2259e6"), -1936450511, 0.4533665219523110m, "3VhtyAFdNr8kUvPGTZcgJDE4HB7es5a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6151), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6150) },
                    { new Guid("58ea3262-7ba6-4343-9665-1182286dd58c"), -414221850, 0.2283175984497390m, "L3eyq7HkbXwaM9tV8ZfrGmFhSQCJnvT2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9719), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9718) },
                    { new Guid("5a89fac9-f296-45f5-b56f-e8cc901cf0ad"), -1789967184, 0.7040020898531530m, "LNYUDQghAkGnCJK64zwrZpXWjbBPS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6504), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6503) },
                    { new Guid("5fb39fcd-2c73-4a2b-8d4c-eecf5e6d674c"), 2139365589, 0.1252951640516790m, "MMsNRQb95XnEc8d4GCpZoPe2FH3KLBx1m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6048), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6047) },
                    { new Guid("60165bcc-3714-4e09-bd9d-5cb704f604e5"), -138551026, 0.003059309951722770m, "32SmXD83VJHwA4UWC1dFTy6t5Ln9cjPsK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6206) },
                    { new Guid("658759ac-5168-45c7-9309-5126f1595ac3"), 1226027920, 0.3293423002040440m, "M3o2e5L4ifKmguFJSTdCUnDHYwGpz8q", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9797), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9796) },
                    { new Guid("66cbafb9-e7c2-4ccb-9052-7487aa27fcca"), -1846211566, 0.4651452068956730m, "MTa5zUKc1QG7S6Z8esjEBVu9gMWCnb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(189) },
                    { new Guid("66fa4b6f-9935-44d9-ad4a-9c3cbeb1e3c0"), -1247695457, 0.1012182767239850m, "3CyExVpcuZT4wjPDzFJdhGQtq6N1roef3L", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(6), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(4) },
                    { new Guid("6944f72d-751c-49a1-804d-0c753a99a463"), 1334587357, 0.07169852994371960m, "3Y6nBPvMruq2haN4TextFcWyH7G", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9820), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9819) },
                    { new Guid("6c23a95e-43fb-4e14-a895-841a77f1ffbb"), 91253459, 0.4877007611815180m, "MfViWdNh1RrPGE7qJwuatTvY2xXkj5S6e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(474) },
                    { new Guid("76313eab-ff63-43c1-83ed-c790a05250b4"), 917718074, 0.9979869399947440m, "Mwh3djNr5mcvfCs94uDz6EXAFgioeb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6389), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6388) },
                    { new Guid("7791a418-5ac6-44b5-8a34-3e9b8337d6d6"), -578575102, 0.7533704912365310m, "LZukK7Jiecsh2wT6C91xASYqMN83", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9840), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9838) },
                    { new Guid("77ae246a-64d5-4d7d-9db9-17b181857b51"), -327204959, 0.8774996560364750m, "LrUx5G67AEkgmNtMZuBPizbQjLJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(125) },
                    { new Guid("78cdc7e0-44ed-44a9-9192-81e841378a54"), 1145785864, 0.2305655690888210m, "MBTAPoh8zyk1dSr6RG3FCnbUaj97", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5854), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5853) },
                    { new Guid("794f2360-db3f-4e67-95e0-b35833daaad4"), -2135926461, 0.4650566670017220m, "31Qp62U8AqCv7diH4LKw3Z9NRDXk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9938) },
                    { new Guid("79ab4366-54e6-4cb0-ad90-07b134fc654f"), -1131626764, 0.4504829097769640m, "MXrjafUskohL4VFmNtHdq1c97pT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6638), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6636) },
                    { new Guid("827f495d-94ad-490a-8d3e-6ca9197e25ec"), 629692007, 0.9865724393306790m, "L71H9NDoTRefPkEvhiK2J86MjZU5y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5702), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5700) },
                    { new Guid("87bdfba2-2050-4f71-bd32-e36406626c6a"), -2017208797, 0.4195920130781760m, "3BzaovVQR52p3nNZiA1hu6s7yecJqjXYDk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(330) },
                    { new Guid("8cb3cd37-fbb5-49ee-a55d-7c6c57b94588"), -1155294537, 0.1499318514308010m, "M18eGDsXnWwa3ugtPJMEUQ94qZirjSBh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9582) },
                    { new Guid("8e187874-8d24-4b44-9224-a31f5d8a4ee4"), 1196518162, 0.5848780480956230m, "MdKyP5rnFUuCTgxikRJwb48EYM9vm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6558), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6557) },
                    { new Guid("8fcd6c44-9ee1-451c-a599-60b4f59688dc"), 1608955199, 0.91528970545780m, "McPypsqubGdBKMfL7Z42oUg6rV8W", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6132), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6131) },
                    { new Guid("935c5879-279e-4eab-81fe-2557a00de72b"), 1705485333, 0.7924903030581150m, "M98KebJRLmd2kWSUHGB5zvw7CMqtDx1F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6351), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6349) },
                    { new Guid("9453d24a-3ab5-42e6-ac35-0084756f6ad4"), 1446904726, 0.1673888525909560m, "3xNGQk2pjZW1HMReibhBoz6SuKAYsaPv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9882) },
                    { new Guid("95abdf21-9350-46ac-8a84-b64a7cc8e724"), -264926416, 0.8819745692230050m, "M9VSvBwEGNFyrtqaY2dC8ujsMRg3if", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5960), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5955) },
                    { new Guid("95e4f434-7842-4f1f-92e9-bd344765c31d"), 2009362409, 0.9325076459758920m, "Ly4TpYoJkPcwBnZNa8xz7gbs251Hq9u6E", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(267) },
                    { new Guid("96fbf950-ba60-4ec5-bf51-35f46c70df5c"), -1815123070, 0.3863139792827340m, "M7zSmZTWg4otJhrnNXVuYa6yx1RwMCUQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5796) },
                    { new Guid("9703165c-3223-448c-9e4b-938df39af60f"), -327157952, 0.6943435622550860m, "38JuLeWkNTwsDjbz5KVPH3Ra7BXc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6027) },
                    { new Guid("9805b03b-aaec-45b4-8e07-9651a68055b2"), 618718893, 0.3133356233772410m, "LKisDdaZp1hcQM4Ck2eXS5PxAwnN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(103), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(102) },
                    { new Guid("98a5dd01-632c-424c-8070-47d821c6321a"), -123242106, 0.02874928023029930m, "3Sr5kMH1ZmpoKh7bqxYcyNRVfT4jiUW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(373), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(371) },
                    { new Guid("99e86b66-4a51-4f29-bc77-600c5f9db367"), 524461006, 0.3401230925117190m, "MM2ZnAxcbk7vqRjGHFmaQY3WDUty", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(310) },
                    { new Guid("a16c2f41-e810-4d2c-92c6-7f576a5be9bf"), 1048332019, 0.6322652873013440m, "M28r3vuhiQyNbmjdB9PtD1FgCLX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6423) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a17d51e9-777e-4f23-b0e2-0d3db0b52c23"), -865360513, 0.7742983766784560m, "MMnrSLR8oBXKexG7zWD9JVvbdgpkj15f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5934), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5932) },
                    { new Guid("a8a81554-1f08-4f42-b832-0cf6306984c7"), 2029214103, 0.1842834733623540m, "L8CWM5uQePLEgKqdtBRa1ZspkwV63", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6539) },
                    { new Guid("a9a48e2e-7801-432c-b4e7-db1374e35fd4"), -441026212, 0.8280465591956750m, "MmYLCiet1waKNTUb9ZzQdp3BvX8GEyhj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9674) },
                    { new Guid("abd31263-d5ea-4778-97fa-ab44c638a510"), 682402749, 0.3450563875581590m, "LeXqhHWbKQmxw7MP8sdECZDpFY5B4f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5914), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5913) },
                    { new Guid("b085ef3e-8a4e-4640-8e35-3b5735320641"), -575701043, 0.764515887530770m, "LjPVw2Rz64MByCLbfEGSnhN1TtJ8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9737) },
                    { new Guid("b343f80b-dfb9-42d0-9d45-5f5eff2ca6e1"), -2027008049, 0.06988866055534320m, "LCMXoYA4h8mvkf9n12us5F7JRbzrU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(64) },
                    { new Guid("b376dfe2-02a6-4283-80bd-e7536895580a"), -1145453408, 0.6635022040386550m, "3kUftViCsRzv2jGdKYM8ASWHBcrEo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6010), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6009) },
                    { new Guid("b4afc82e-56a0-487f-b740-5502afc1f8d1"), -300930698, 0.9826994962355440m, "3HjsUwKxkq1tir8TVSpzm4aGPd5uY9NMfD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9626), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9624) },
                    { new Guid("b7ae3594-b59c-4fbf-bfe3-0fb40f339343"), -1987533017, 0.261783278384880m, "Ly7MgZzvwQqRituKn18FbJxfd5ha2UrAp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6618) },
                    { new Guid("b89ceeda-0126-4c14-bc7f-3b54980ffd65"), -330136207, 0.7110082693325870m, "MJugb42pSsNaW1Uqy6jAEwoQnim8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(350) },
                    { new Guid("ba143c24-6052-4153-978e-0a2257f22c84"), -20117397, 0.4492868647557690m, "37QZ3uCLFjmneDSiPzNobX4g2RfE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5872), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5871) },
                    { new Guid("bf06404c-1136-468f-aca2-4fff94e91a9f"), 340124868, 0.8938451311399650m, "M2YTPNGAdBD7fsU4whJj8HoL6pV3Xc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(432), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(430) },
                    { new Guid("bf1720e5-1fe7-4255-bcb0-1830a843f1e9"), -1246004524, 0.4360385431269230m, "3u7fHCbRtTd9njoW1psPNKqkJLEavX3Yy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(172), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(170) },
                    { new Guid("ca11046b-e206-4b60-a4cc-a72e529f97a0"), -506955159, 0.5064416676557580m, "LLc571dayhVSoKxUTiCBuvz2HnMkGYf3mt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6069), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6068) },
                    { new Guid("cabacc4a-dd28-4f44-aa7a-cb90078c0383"), -1661899575, 0.3809044654300230m, "MnUf3L81dCFMcvkE2A4jKziHQ9h6P7Y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6247), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6245) },
                    { new Guid("ccc65bdc-d806-474f-99d8-ea2b17df693e"), 1777600558, 0.07243308382904240m, "LuXgP7CHp3e2ULz1ZjYM9aR4bBKV6JDEmA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9655), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9653) },
                    { new Guid("cfdf7812-c9d7-4b4d-a036-41d1da9d4664"), -1267000287, 0.2737107678958260m, "Ms5gzDLkiqB1xY3PVfr2aH6CcMTpeSm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(211) },
                    { new Guid("d2f87ecb-b9b1-4c4d-804e-52640c1ec182"), -423037965, 0.01600167952181140m, "3aykEiK4rq1GbdNtCzSJAjMWZPBe3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6442) },
                    { new Guid("d4212ea1-6e58-463a-9d45-6d4674d94b75"), 412737958, 0.9868066041648530m, "3PApQq9BHFZRkd1tKeN7zvWXc56jGfwJu4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(514) },
                    { new Guid("d6d4ae5f-13d3-42aa-8ac2-009dc22c1382"), -508518773, 0.453173900016480m, "37c9WkQCtRVL6JNX2jE3umsbrvYy1qA4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6089) },
                    { new Guid("d9b57f3c-914d-4738-83b3-e9a98ab4a35c"), -1062227764, 0.3759987199077850m, "3yT47D5mVcGJbp1Pw29xBrt8FK3MEWef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6323), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6321) },
                    { new Guid("db608b28-cc64-428f-baa2-418fcc210c52"), -1273978777, 0.4951989177946760m, "LWzD9sR4H3Mwoud8N2ZEqpBhtAje71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(150) },
                    { new Guid("dc648136-7bd6-47f3-9f87-09a0043d21cd"), 565026599, 0.1981374180327560m, "LWcUJyB18XVubpYjz9oKxe56aZT7An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9982) },
                    { new Guid("de69f533-ea2d-45e0-920c-cef76cd02fe2"), 801487567, 0.1412340661274920m, "3ZmNBUz9d8aS6PFsi3jyvDHXrnAqoL5b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6699), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6698) },
                    { new Guid("df3919ae-45c7-490c-8976-cfbd6455f666"), -12706935, 0.2469454690491140m, "LApW1kTq37oR2MdNjUGmtS5csfB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5816), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(5814) },
                    { new Guid("e27d106f-16e7-4f71-9de6-22f4cb0397a3"), 1689641535, 0.8303274795605260m, "L6nvHPkLV1rWR9Gwdtg2cNSZ4jUm7ob", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(286) },
                    { new Guid("e29e643a-9769-4aca-ba7b-43df6b1dce75"), 1815345794, 0.6947463614150520m, "3TVRx6La89qXDCirZju1tdsWo4mkg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6371), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6369) },
                    { new Guid("ed945ce0-a652-4a6e-bb24-208f9c6a8bd5"), -570048524, 0.8926294583062730m, "MmGj4RDe3xvMYhysTZdtULA2SrfobQW5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(3251) },
                    { new Guid("f0cf6c54-1d57-4da5-8aa4-335f30b514db"), 444444680, 0.5653510136148130m, "MQvzw6RMFgUAPBnjCihrTkZxW2YE1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(47), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(46) },
                    { new Guid("f2ad6ab0-1b52-437a-8ac9-ef4f5df108ef"), -224828972, 0.1937375436629520m, "3EBXmghZ7R6KAeLPFp1Q4u392aWn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(249), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(248) },
                    { new Guid("f4a2f159-7ad3-491f-8e2b-4650953d5a29"), 1887484450, 0.815053307573610m, "MD5SKCeFjLGar8TyR3uAXfhH4o7xBQinJc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6598), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6596) },
                    { new Guid("f6232741-9a0c-4f9c-a268-eee685455070"), -2133302406, 0.6385279459823540m, "3uR4SBWG7EfqAz3mX8ctZkMvi6Pea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6168) },
                    { new Guid("f6bcfc5c-5f08-4a5e-b2cb-dfd55defc183"), 1938392966, 0.9212958749915160m, "LB8Q5bUeGvNi4dz36PtmJwT7VAksfpy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 6, 4, 21, 32, 42, 691, DateTimeKind.Local).AddTicks(24) },
                    { new Guid("f6f90024-2e40-48dc-8efe-b36b7b690430"), 1218382985, 0.7018035220225540m, "38xepv4jk9YUHrNEFCdRsJ63aVzX1B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9902), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9900) },
                    { new Guid("f8339470-7b0b-459e-9d75-41e5c19d921b"), -215248550, 0.6925350718018750m, "LRb6mak4NhxDLJtsjd7WTqKAGB1e8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9959), new DateTime(2024, 6, 4, 21, 32, 42, 690, DateTimeKind.Local).AddTicks(9957) },
                    { new Guid("fd184740-6fef-41ea-9e51-d389412fd000"), -1792860448, 0.2648869024244470m, "3asiufCqbS346eGoYw5QTFcXtHzNnhy1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6681), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6679) },
                    { new Guid("ff2f8546-1abd-4aed-a5c5-4c2d73d8abbf"), -193099447, 0.7743987553341020m, "MA2w5FpStZUhCkiNs1dbeVjH47D", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6464), new DateTime(2024, 6, 4, 21, 32, 44, 864, DateTimeKind.Local).AddTicks(6462) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("067bf875-8a96-48a0-978d-10d890bd7318") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("171184db-5baa-42f3-92d8-64b8e76c6165") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("253493f6-b3da-4ae0-a428-05a0560043e2") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("302771bc-d672-48ae-9a96-c489ccacf75a") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("45dee853-0743-493d-b80b-c81b944cc529") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("4a21367f-81c5-4947-b939-b44d17e67434") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("53078823-cbdb-4f6c-b393-57486464289a") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("6224405d-f9d8-407b-9f81-847223041784") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("63684041-907c-4654-ab87-5f0c11008f52") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("66bde12e-086d-4150-9c7a-89ea75047f12") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("671bbcc1-9768-4630-8a24-d7626303ad52") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("6c7090cd-7244-4437-b460-88c7027c78f9") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7156fae1-f350-4998-b43f-3d5664953dc8") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("812d963b-edbc-48b1-948d-661ea6f9d645") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("8a966506-353d-46f9-91b9-9431f8562c71") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8d077a60-6583-4591-b84d-07adff60a1a0") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("929221d7-8d45-4a44-b501-41a47c26cf44") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("9428c7a5-a397-4b16-aff4-15dc05248196") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("a0863958-35de-49a9-a73b-decb03e0c871") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("a0935a01-c087-4387-9782-37219c8d05b9") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("ae750269-835b-481a-8e36-4dd8044f9527") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("b15da029-129e-47f2-8442-a8831d78a2c0") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("be28704f-919b-414b-b444-7bf3be5f0534") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("bf057140-33a4-45d8-af53-45e3337a92d1") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("d364b716-4b5c-4090-99d6-0f11b5849701") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d5908335-16ba-435a-9a9d-603eaee07878") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("e57373e2-48de-4c55-9c02-9b87c7751318") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("951c8778-c5fc-4ed9-b640-42b644f653d7"), new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("fd051a5e-4258-4bbf-b64a-29676b007443") },
                    { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("0e2820a5-b8cd-4d6f-a32e-17aedc74591b"), new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8194ea1e-5583-4b02-8ed1-b9647c133925"), new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b") });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("00ca17de-7e85-4003-889d-da218d76360f"), null, null, "Jeanette_Stanton@gmail.com", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("015db0dd-371e-43d3-a542-da499ee858fb"), null, null, "Luella_Kautzer@yahoo.com", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("016acded-397b-4875-a145-32808b345a0d"), null, null, "Miguel82@gmail.com", false, new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2") },
                    { new Guid("01d83b70-cd63-4309-87cc-305c049cb413"), null, null, "Hubert_Zieme@gmail.com", false, new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75") },
                    { new Guid("020471cb-cc98-4397-9953-d55efed23b1d"), null, null, "Icie_Paucek@gmail.com", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("0205afbb-1970-4ba7-8d18-a2e523c65f08"), null, null, "Kiley5@gmail.com", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("0275e4f5-9a33-4565-8be0-6cf673688e25"), null, null, "Reanna89@yahoo.com", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("033d7083-04c1-49c8-b2ab-1c5dfc9f2e4c"), null, null, "Khalid_Heaney59@gmail.com", false, new Guid("9428c7a5-a397-4b16-aff4-15dc05248196") },
                    { new Guid("03536f7d-5cbb-495d-9a7b-e8e25d508a66"), null, null, "Shaniya_Abbott87@hotmail.com", false, new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7") },
                    { new Guid("0354b571-3c3d-4d31-84b8-2606a874a60e"), null, null, "Yolanda.Waelchi98@yahoo.com", false, new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df") },
                    { new Guid("04464287-8f5c-4576-94b8-f77154d1b926"), null, null, "Montana41@hotmail.com", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("046bc262-4f46-4ed2-b9bb-5da97a4419ba"), null, null, "Marielle_Cronin3@hotmail.com", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("0482e9d6-8d6b-4876-b450-1f8a993a898c"), null, null, "Gerson81@gmail.com", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("055d36a9-78b6-4625-b0e9-0bcdd63f8657"), null, null, "Kellen.Zulauf0@gmail.com", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("055e372b-3f5d-4382-a7fa-1b13b982f329"), null, null, "Avery28@gmail.com", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("05c2bcea-37d4-489b-a51b-55d2a90af5de"), null, null, "Helga.Jaskolski44@gmail.com", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("0608b776-0d8b-4c32-84fe-f84631ac5a7f"), null, null, "Pietro.OKon80@hotmail.com", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("06134fc7-ef8a-46c0-ba37-d3c17162d76b"), null, null, "Graciela_MacGyver@hotmail.com", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("065d5fe1-ab08-4327-87b0-623d8a81049c"), null, null, "Shana_Wilkinson@yahoo.com", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("0664ca82-6a18-4570-865b-2b70ba61f338"), null, null, "Flavie.Koelpin89@yahoo.com", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("06c3ded6-b060-49dc-94bf-ab44410fa543"), null, null, "Keira.Bashirian@hotmail.com", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("07120fb2-5714-40f4-b3d2-d704fa85627b"), null, null, "Clarissa.Wolf53@hotmail.com", false, new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de") },
                    { new Guid("076284e2-ad84-4a5e-ba83-6c0d89414d00"), null, null, "Grover52@gmail.com", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("07d0be28-92ed-47cd-a8f0-51d95797de3a"), null, null, "Leila.Hills93@hotmail.com", false, new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711") },
                    { new Guid("07d41444-7774-4082-a4d1-01af9815a54a"), null, null, "Alden_Schimmel@yahoo.com", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("084d6691-e403-4179-83ec-d6412a27db87"), null, null, "Orin.Pollich@yahoo.com", false, new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37") },
                    { new Guid("085a1b74-3efd-4893-918d-6fc99fc83ba8"), null, null, "Desmond.Murray@yahoo.com", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("08ed4d4d-e91f-48fe-8932-c2b4879555dd"), null, null, "Gabriel_Rowe9@yahoo.com", false, new Guid("253493f6-b3da-4ae0-a428-05a0560043e2") },
                    { new Guid("09622190-5935-46dc-9e7d-6fab189d2857"), null, null, "Delores40@gmail.com", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("098d3ab3-5d1c-4945-a5c2-7e11d253f861"), null, null, "Mervin.Rice@gmail.com", false, new Guid("ae750269-835b-481a-8e36-4dd8044f9527") },
                    { new Guid("09b8abfb-15ac-4cef-8a9c-a623a809b0b6"), null, null, "Jermaine_Paucek@hotmail.com", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("09e0b487-b96b-4574-b275-d607a57e989d"), null, null, "Tamia_DuBuque95@hotmail.com", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("09e0e3c8-2d03-4de8-ab21-0d4f694a88a6"), null, null, "Nicolette6@hotmail.com", false, new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9") },
                    { new Guid("0a1a1699-cae4-45fe-9756-8b74a3c3f8b1"), null, null, "Salvador_Kihn43@gmail.com", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("0b0fdcb3-7de9-4d27-ab8f-960bd11087f1"), null, null, "Kacey.Price29@yahoo.com", false, new Guid("8d077a60-6583-4591-b84d-07adff60a1a0") },
                    { new Guid("0b347f1d-d1e2-42f6-9a6a-5bac96504dc8"), null, null, "Nigel48@hotmail.com", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("0b6a2fbc-18e2-4caa-8ead-723bed22fb81"), null, null, "Libbie_Sipes@gmail.com", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("0ba0759a-c542-4812-baa7-3b1808a6779c"), null, null, "Lisette_Rippin33@gmail.com", false, new Guid("53078823-cbdb-4f6c-b393-57486464289a") },
                    { new Guid("0bae7488-6215-4a88-acf6-b686a5e3bf3a"), null, null, "Jaida57@hotmail.com", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("0bc68d0a-0477-452f-838b-559ecc9d5708"), null, null, "Osvaldo.Hilll32@hotmail.com", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("0be36dec-c8d4-4858-bd11-5b16346accef"), null, null, "Douglas_Morar48@yahoo.com", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c5d7cae-c332-49a6-8fc5-7998e245ba4c"), null, null, "Bridget_West@gmail.com", false, new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28") },
                    { new Guid("0d66c71f-ac31-425f-bd7a-b713118bd99e"), null, null, "Demario.Hyatt59@hotmail.com", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("0d81d66d-4768-498c-9713-9df413d3ed56"), null, null, "Gaetano_Schroeder96@yahoo.com", false, new Guid("63684041-907c-4654-ab87-5f0c11008f52") },
                    { new Guid("0e1fc2e6-4b17-4cbb-b45d-adf6fd268a3a"), null, null, "Constantin29@gmail.com", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("0e93e83e-c8d2-413f-bea7-5eabdb59859e"), null, null, "Edmund22@hotmail.com", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("0eb89f2c-4641-4a6b-bfc6-30963861788f"), null, null, "Rylee_Rau@hotmail.com", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("0efcc0c9-686d-4940-b54b-e3ec43a11afb"), null, null, "Neva_Gutmann@yahoo.com", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("0f15ea0f-7808-4041-8c3e-eaca14a24fdd"), null, null, "Ada43@hotmail.com", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("0f4bb809-4950-4009-a7a5-921a1c5292fc"), null, null, "Winnifred.Jast35@gmail.com", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("0f53b50d-2098-4972-a47d-580d4f65c628"), null, null, "Jason.Rempel0@hotmail.com", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("0f6954f4-a08a-42d5-a90a-22fe7725e95c"), null, null, "Tyrel_OReilly82@gmail.com", false, new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664") },
                    { new Guid("10555ce6-6683-4c3f-827c-22be634f8896"), null, null, "Isai25@hotmail.com", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("115feb02-c9ce-4a57-9a3a-2314fb4a0730"), null, null, "Estelle.Langosh@hotmail.com", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("116826c2-c849-4009-bf68-d14d59d35031"), null, null, "Abbigail_Dare@hotmail.com", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("11d31c18-9984-4377-9220-c003525f7f54"), null, null, "Brent92@yahoo.com", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("12607ba7-3052-43de-bded-266a700d7ffb"), null, null, "Mya78@hotmail.com", false, new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("126b7109-df4c-4ccf-9d6a-d6d80abe8f8a"), null, null, "Larissa.Jerde@yahoo.com", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("135bd056-896f-4f4c-be99-f30f85fe2f05"), null, null, "Rosario67@gmail.com", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("139aafdb-cef8-4c2d-a5d6-da1f27606e63"), null, null, "Moshe.Bauch63@yahoo.com", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("14b529c1-46bc-4080-b72c-bb82bb847dd7"), null, null, "Hertha25@yahoo.com", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("14c17a25-f2e4-4138-bb99-ef256cea9870"), null, null, "Kenny23@yahoo.com", false, new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad") },
                    { new Guid("14cbe11c-5408-4984-96b0-3b89f319a10a"), null, null, "Emmett_Berge@gmail.com", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("152a2a2f-023e-4d2b-b9fb-119e0d99fde2"), null, null, "Leonardo.Rutherford25@gmail.com", false, new Guid("66bde12e-086d-4150-9c7a-89ea75047f12") },
                    { new Guid("15737d5f-26a1-4a35-b389-6d744c5eb7cb"), null, null, "Demond43@hotmail.com", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("16069cc5-fda9-49bf-a3c3-da0d2ce629e3"), null, null, "Edd_Dicki49@gmail.com", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("16079763-e47e-4114-9987-187eaa11f09f"), null, null, "Lucius.Cummings@hotmail.com", false, new Guid("d5908335-16ba-435a-9a9d-603eaee07878") },
                    { new Guid("1622a3f8-61fb-44dd-9ed7-6a374f33326e"), null, null, "Nelda.Green@gmail.com", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("163b4b12-afb0-43f7-962a-c7f435dce65d"), null, null, "Randi_Franecki@gmail.com", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("16bdf69b-8d51-4b8a-bc08-4b419a4c5bc6"), null, null, "Nadia.Lueilwitz59@hotmail.com", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("16dde6a0-17b6-44fc-8f9b-beaad54c42c6"), null, null, "Martina.Champlin@gmail.com", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("172c6d27-fa82-44d5-8ff3-a21f1a368b33"), null, null, "Jarrett.Ernser87@yahoo.com", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("176f5bb7-26cc-4fb8-b948-b1313840e1b4"), null, null, "Katelyn.Christiansen@hotmail.com", false, new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6") },
                    { new Guid("18e2fa70-930d-4d84-95a6-ad8bd25574fc"), null, null, "Celestino.Spencer@gmail.com", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("19248105-0977-4b96-afa5-323476e0f820"), null, null, "Gene8@hotmail.com", false, new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a") },
                    { new Guid("198052c8-9e20-4936-8760-c3ef88495814"), null, null, "Keyon_Hammes8@hotmail.com", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("199af83f-9110-44e8-b895-35b5b23a9aa6"), null, null, "Aletha.Kirlin@yahoo.com", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("19e88a36-fcaa-432e-85df-69e38dac10d1"), null, null, "Dianna12@gmail.com", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("19f5f3c3-e8ed-469e-b18a-1662aa100076"), null, null, "Annabell84@hotmail.com", false, new Guid("067bf875-8a96-48a0-978d-10d890bd7318") },
                    { new Guid("1a326e0d-1959-4f20-98fe-84b1bd0ef8b0"), null, null, "Sam.Wolff93@gmail.com", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("1a6e1542-c0d2-46bc-9b6b-e93cbc8c8e02"), null, null, "Elizabeth_Schowalter51@hotmail.com", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("1a7cfc90-0a00-4f21-a58e-cf6c50f016b5"), null, null, "Alberto78@hotmail.com", false, new Guid("8d077a60-6583-4591-b84d-07adff60a1a0") },
                    { new Guid("1a925c40-35e3-4a3b-af84-6c0b576b8493"), null, null, "Lolita.Gibson16@yahoo.com", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("1b21e3de-671a-4a5d-88fc-ea53c6ec3764"), null, null, "Ebba45@hotmail.com", false, new Guid("171184db-5baa-42f3-92d8-64b8e76c6165") },
                    { new Guid("1b4f2a03-8114-4616-a7a9-1a402f78af1d"), null, null, "Velda.Hirthe69@hotmail.com", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("1bbe1591-377f-4074-8885-f65244a4d27e"), null, null, "Alysson_Hagenes39@gmail.com", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("1bf20436-282c-42cc-8ba4-8b75c3587911"), null, null, "Kaley10@gmail.com", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("1c0a6d95-005d-4d93-ac29-33f5aac13519"), null, null, "Golda30@hotmail.com", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("1c453c96-3000-470c-96d1-f38291fd2a92"), null, null, "Milford_Lemke30@hotmail.com", false, new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d") },
                    { new Guid("1c612bfc-a3f0-4ab7-b32f-df8d9aacd04d"), null, null, "Estrella.Greenfelder@hotmail.com", false, new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("1c784aaf-ca03-41bb-a6f7-c214e308e175"), null, null, "Myah24@hotmail.com", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("1c95df95-4ada-426b-80cf-9d0cf973dfac"), null, null, "Jimmie.Beatty@gmail.com", false, new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d") },
                    { new Guid("1cab15b9-fbaf-430c-bff1-bdeeb0d55cb8"), null, null, "Aniyah_Stokes37@gmail.com", false, new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440") },
                    { new Guid("1cef3c3e-ca41-4397-8027-52b3f56f5fec"), null, null, "Oswaldo.Gislason@gmail.com", false, new Guid("fd051a5e-4258-4bbf-b64a-29676b007443") },
                    { new Guid("1d2f61fc-77a4-4ff6-8338-7c91527057ae"), null, null, "Leonor38@hotmail.com", false, new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6") },
                    { new Guid("1d337059-d22d-4dd0-a8b2-b4489bf70cad"), null, null, "Alvena43@gmail.com", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("1d9cf051-8592-4d11-a061-6f20bc2db13b"), null, null, "Triston48@hotmail.com", false, new Guid("302771bc-d672-48ae-9a96-c489ccacf75a") },
                    { new Guid("1db120c5-f06e-49cd-b8bc-0087f24196fd"), null, null, "Dangelo98@yahoo.com", false, new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9") },
                    { new Guid("1e43c850-29c1-41b2-b2d3-df182d82d483"), null, null, "Jazmyne.Collier91@gmail.com", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("1e892c86-bccd-4d7a-a98e-afc0fdf5dd86"), null, null, "Lorena81@hotmail.com", false, new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f") },
                    { new Guid("1f14d9f4-e814-4a91-943a-859c34509886"), null, null, "Alessandro42@yahoo.com", false, new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37") },
                    { new Guid("1f9fea9d-5b80-49fd-bb10-b03d98c45992"), null, null, "Arely.Leuschke@hotmail.com", false, new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400") },
                    { new Guid("204039e3-e4a8-43fa-b65b-8886ffc5aa3e"), null, null, "Rosina.Stroman@hotmail.com", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("205fdf82-8a20-413b-8735-72b95d8649d5"), null, null, "Quinn.Hyatt@yahoo.com", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("210ec5ca-6922-49e7-a07f-b20736ee9df4"), null, null, "Nya.Robel@gmail.com", false, new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5") },
                    { new Guid("214964b6-c589-4c39-b8f0-46230428ca92"), null, null, "Cydney_Bernier9@hotmail.com", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("217a5696-d9e4-4208-9812-62aecfaec117"), null, null, "Albina_Predovic@hotmail.com", false, new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5") },
                    { new Guid("21feb3d3-44a5-4d92-889f-d27fc3fc2238"), null, null, "Claudie8@gmail.com", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("2272e4a7-d9d9-49d6-889f-aeee0ceb4ea4"), null, null, "Brisa29@gmail.com", false, new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc") },
                    { new Guid("22e18398-5b1e-421b-9dcf-08ecdcb6151f"), null, null, "Ima87@gmail.com", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("236af834-4349-4f40-b73f-f0b7c3a675c5"), null, null, "Sadye.Frami35@gmail.com", false, new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664") },
                    { new Guid("240e4821-25f2-4af4-8cae-b5e06e39f86e"), null, null, "Tremaine11@gmail.com", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("2420635d-aed2-4be9-a1ed-b6a1b57689d5"), null, null, "Amely.Schultz@hotmail.com", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("24818b05-cd4a-436d-80c0-effcff798ebc"), null, null, "Dorothea_Cronin54@yahoo.com", false, new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d") },
                    { new Guid("248fac62-972a-4927-80c3-7d436ee956b7"), null, null, "Norwood39@gmail.com", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("24aed18d-fc49-4311-8a7f-a6d702a17b26"), null, null, "Destin4@hotmail.com", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("24bce561-3046-48d5-a237-e8b7b02565c4"), null, null, "Hassie1@hotmail.com", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("25727be4-f27b-4037-807f-d9499a0ab6b2"), null, null, "Enrico_Walker@gmail.com", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("2652b29d-f84a-4eed-9a98-6b150bc706eb"), null, null, "Ursula72@gmail.com", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("27d755bf-771d-4073-9da8-42f26fe1b126"), null, null, "Jazlyn70@hotmail.com", false, new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b") },
                    { new Guid("28119a26-8704-4f69-9edc-ebe3f79c3e54"), null, null, "Joyce9@gmail.com", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("281aee9e-4acb-4c28-960a-0af8b44327f6"), null, null, "Judson_Torphy3@hotmail.com", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("282bb623-065d-4d5d-8b01-d39fb69b84b4"), null, null, "Mertie80@yahoo.com", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("285bf8aa-b72d-4992-a0d2-4e21d2cd5a96"), null, null, "Sam.Rau56@gmail.com", false, new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b") },
                    { new Guid("28818ab7-0efa-43b3-8bd8-92f1e1acfc39"), null, null, "Jonathon_Lowe@hotmail.com", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("29148fee-949f-493e-be30-7b623b117740"), null, null, "Trace_Blanda@hotmail.com", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("29397ff2-3a18-4d86-89dc-9f1753b22243"), null, null, "Henry84@gmail.com", false, new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f") },
                    { new Guid("29efea6a-9e47-485c-9879-c5c1e8aaad28"), null, null, "Gina.Rath26@gmail.com", false, new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2") },
                    { new Guid("2a08b714-ef85-46e2-97a3-05e4072a6241"), null, null, "Anastasia.Jast@yahoo.com", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("2a274df1-3875-4caa-b9d5-93a42259ab1b"), null, null, "Giovanni4@gmail.com", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("2a9ae66c-181a-4181-a46b-e0779de78b25"), null, null, "Lia.Wolff@yahoo.com", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("2a9f9927-f1c7-440a-bf29-821c7906c84c"), null, null, "Viva44@gmail.com", false, new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350") },
                    { new Guid("2ab0fdec-02f7-49ab-84db-810211569513"), null, null, "Augusta_Ledner@hotmail.com", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("2ac29977-e2b7-40ea-8a93-51757107006c"), null, null, "Helmer81@yahoo.com", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("2b34e0f1-2639-458f-88db-d40df91ee801"), null, null, "Maud0@yahoo.com", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("2b4de138-de0a-40ad-a5a0-7180055d2a82"), null, null, "Magnus23@gmail.com", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("2b7cfa22-1539-4590-baba-52f09c69887c"), null, null, "Seth.Fadel85@hotmail.com", false, new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0") },
                    { new Guid("2b882f96-5308-4fd1-930c-35e93c378bea"), null, null, "Dorian.Howell71@gmail.com", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("2c5313a9-28e0-46f2-809b-3945f4fc90a6"), null, null, "Alphonso_Pfannerstill35@hotmail.com", false, new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35") },
                    { new Guid("2c983d41-3cab-4660-8421-f1dc7837d844"), null, null, "Ressie14@gmail.com", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("2cb74bd6-4125-4808-9a7e-5a9580175512"), null, null, "Austyn.Kuhlman21@hotmail.com", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("2d009cbe-7ebd-44b2-b57e-ead7468f003e"), null, null, "Noelia.Maggio@gmail.com", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("2d3968a7-7616-49c3-a959-c473c2c6ec12"), null, null, "Hudson_Bradtke3@yahoo.com", false, new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de") },
                    { new Guid("2e7da28c-f7ac-4057-ba00-2427178dc790"), null, null, "Abbey96@hotmail.com", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("2e890e6e-67de-413b-88af-922434a586b6"), null, null, "Ezekiel.Herzog11@gmail.com", false, new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af") },
                    { new Guid("2ea1e81f-c536-4a78-8dd9-be9137f91779"), null, null, "Hank.Maggio@gmail.com", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("2efb288f-5760-4993-b9fc-42fbac9d7d36"), null, null, "Constance_Rowe55@gmail.com", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("2f5832dd-7726-487d-886c-347600f6b0b8"), null, null, "Johnpaul.Watsica@gmail.com", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("2f83508c-6944-4aef-bf1a-a8d7cce513ca"), null, null, "Renee_Zieme51@gmail.com", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("2fb4e2da-ecfd-4c4f-a2dd-8b5ac415c819"), null, null, "Anika17@yahoo.com", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("2fccd1d4-f4e1-455f-a052-5b167009b46b"), null, null, "Lue61@yahoo.com", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("2fd50fb8-d1df-4de2-8f91-521b9f5734d5"), null, null, "Riley81@hotmail.com", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("307cae83-b7ed-4445-9cb6-dac8200b3c7c"), null, null, "Lexus_Hamill@yahoo.com", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("30828328-a10d-42ba-8061-7dc6e74c2d0a"), null, null, "Tomasa_Kautzer@gmail.com", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("31403dde-0d35-45c4-a0a0-99366f9c51da"), null, null, "Wilson41@yahoo.com", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("3229ea33-74ed-4bd0-97fc-4558b40dd875"), null, null, "Rosalee_Herman@gmail.com", false, new Guid("4a21367f-81c5-4947-b939-b44d17e67434") },
                    { new Guid("3261cbfe-f2f0-4fbb-8231-811ae0e543a9"), null, null, "Braxton72@gmail.com", false, new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf") },
                    { new Guid("3289c8c6-df75-47fc-b5bf-39f5f030fbde"), null, null, "Guadalupe_Dare30@hotmail.com", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("32b157c3-204d-492a-bd49-10fc9ccffa58"), null, null, "Beau.Marquardt@yahoo.com", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("32b73492-6123-4459-856f-dd88b76a95e7"), null, null, "Katlyn.Bailey49@hotmail.com", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("32c5c391-a906-4f31-ac10-bc983727b370"), null, null, "Brad83@hotmail.com", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("32f8d410-2602-4140-92e4-1eac53654a86"), null, null, "Maci_Mitchell18@gmail.com", false, new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0") },
                    { new Guid("334253f1-d60c-4e10-9df6-fbfedd6c884c"), null, null, "Tad.Satterfield@gmail.com", false, new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623") },
                    { new Guid("336193d4-dabe-4357-909c-54fd90f1d52f"), null, null, "Mattie_Thiel65@hotmail.com", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("3385e547-e43a-4787-abc5-b9d3ce8a671f"), null, null, "Talon.Mitchell66@gmail.com", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("33f8900a-d540-48e6-83fa-2584ec29daf4"), null, null, "Dortha_Little88@hotmail.com", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("345b482b-df52-4290-81c9-004b65a2f007"), null, null, "Beverly.Emmerich61@yahoo.com", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3465517a-6f22-47a7-953d-423c3a3c087e"), null, null, "Melisa_Marks@yahoo.com", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("353b790f-45db-4b7c-957e-1457d2499109"), null, null, "Lurline55@hotmail.com", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("357bda15-4111-4f1c-9421-8d13fa69914d"), null, null, "Brook_Bailey@yahoo.com", false, new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7") },
                    { new Guid("3629495e-0523-4a6e-baaa-d6e4534c83cd"), null, null, "Henry_White@gmail.com", false, new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315") },
                    { new Guid("362fa349-fef7-433c-963b-57c0b3d8463e"), null, null, "Ephraim_Schimmel25@hotmail.com", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("3641dc8a-24fb-4706-a02d-a19a1fc678b3"), null, null, "Rosemarie_Lowe64@gmail.com", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("36438706-7a7e-4a6d-9f83-cbaf055638cd"), null, null, "Clinton24@yahoo.com", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("36800c5c-5365-4068-82c9-10261a7baca3"), null, null, "Harmon_Little68@yahoo.com", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("36878da3-7fb8-44b7-8eb4-8cff47732d68"), null, null, "Astrid86@yahoo.com", false, new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("370bff77-3536-46f1-92df-fe9e6f88b10d"), null, null, "Alexandria34@hotmail.com", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("374a5a45-cebf-432a-aed3-4de5cbde23bc"), null, null, "Ruthe.Gorczany@gmail.com", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("3787e5ad-c7bf-42a6-9f91-751bb6d297d5"), null, null, "Ena59@gmail.com", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("379cd8e4-dd2e-4bbd-8124-b6e396b3c8d9"), null, null, "April.Medhurst10@hotmail.com", false, new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef") },
                    { new Guid("37f183a0-eabe-4049-9433-8b07cfff1704"), null, null, "Caterina.Crooks81@gmail.com", false, new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10") },
                    { new Guid("382be788-35d2-46dc-bdaa-4ed0b47e28d3"), null, null, "Kelsie90@yahoo.com", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("3839dfcd-8f88-4ade-a3e8-47c55a363741"), null, null, "King51@yahoo.com", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("38478e88-9e43-4cda-8588-70fa995765e0"), null, null, "Lela_Trantow@hotmail.com", false, new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de") },
                    { new Guid("3888937b-cf9a-4e99-9124-85bd87760a9c"), null, null, "Rosamond.Beatty@hotmail.com", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("38bbcb88-02ca-4271-82a2-31a96b757003"), null, null, "Justyn_Rippin@hotmail.com", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("398c0495-57fc-4072-aecc-26cf668cdfb4"), null, null, "Nelson.Rippin77@hotmail.com", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("39b312d5-e8db-47f9-bfbb-8facdff0b204"), null, null, "Stephon55@yahoo.com", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("39ec9bdb-1276-4b19-9988-3d07282fd17d"), null, null, "Elody.Medhurst48@yahoo.com", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("3abc194c-87d1-4c12-8070-abded48f6489"), null, null, "Vida9@gmail.com", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("3b0c2686-c613-4ed0-8122-51c0bfc07f7e"), null, null, "Maxime67@hotmail.com", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("3b37871b-dcd6-4d38-bbb4-3013c46d8502"), null, null, "Keyon_Hirthe@gmail.com", false, new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a") },
                    { new Guid("3c0aa134-4fee-4203-8d36-16cb70bd5304"), null, null, "Oceane10@hotmail.com", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("3c2d3608-fb22-4dc5-a228-af18ca241952"), null, null, "Angelita51@yahoo.com", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("3c428a0e-7077-4ce0-a036-a4f2367bf9f8"), null, null, "Marcelina23@yahoo.com", false, new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1") },
                    { new Guid("3ce396ad-99fe-46cf-89da-9f60a9a38bef"), null, null, "Donna30@gmail.com", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("3d0f57f8-694e-4226-8617-b8cf61b01b49"), null, null, "Caleigh.Waelchi87@gmail.com", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("3d53d4bf-3fa4-4947-9365-e4bd6805eb6b"), null, null, "Laury.Conroy52@yahoo.com", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("3d71272c-9514-4aaa-9099-7035b8ac59c1"), null, null, "Robbie.Kassulke7@hotmail.com", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("3d88dcb4-45a8-4ac8-bdbe-3ea9261b8ac4"), null, null, "Alison47@gmail.com", false, new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be") },
                    { new Guid("3d918551-d98c-48ff-a61e-28467925e3d9"), null, null, "Providenci.Ernser@yahoo.com", false, new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262") },
                    { new Guid("3da4e7aa-3318-4d75-abb6-d28cf5d3bd06"), null, null, "Naomie90@gmail.com", false, new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a") },
                    { new Guid("3db3943e-1924-47d2-93b8-61a497680348"), null, null, "Rahul55@hotmail.com", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("3dbaea1a-7280-48fb-885f-fb607504eb99"), null, null, "Kirsten8@gmail.com", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("3e105ae2-e62f-4d1c-9a4c-21891fa1737d"), null, null, "Isai.Cronin@yahoo.com", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("3e7c99cd-c2ea-4f19-b160-5cdad59799a2"), null, null, "Aubrey_Steuber@yahoo.com", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("3e965d9d-ef10-4d70-ad61-68b5122df905"), null, null, "Oswald_Rogahn@yahoo.com", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("3ed0c9ba-f574-4fb2-816d-9d300e04447e"), null, null, "Krystal48@gmail.com", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("3f5f47f0-5441-45dd-969b-1cb0a5952ee0"), null, null, "Foster_Hegmann46@gmail.com", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3fb817fc-d435-4850-b985-5330bbe485e0"), null, null, "Marisa.Waelchi@yahoo.com", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("3fd53c96-d1a7-450d-8167-186d27bb748c"), null, null, "Gisselle_Weber56@hotmail.com", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("4061ec97-6c37-4680-86b4-f08d6d2d71b8"), null, null, "Angeline_Goldner24@hotmail.com", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("4071f64f-e0fb-4763-b8ec-7716be560b2e"), null, null, "Eliezer10@hotmail.com", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("40756230-e91e-4a85-a285-8de6c8914334"), null, null, "Pearline27@yahoo.com", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("40af995a-4165-4826-a449-c727f7579b8a"), null, null, "Arnoldo4@yahoo.com", false, new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b") },
                    { new Guid("40c7b291-de00-482a-9c29-41e6cf22d68b"), null, null, "Domenick91@yahoo.com", false, new Guid("be28704f-919b-414b-b444-7bf3be5f0534") },
                    { new Guid("411db384-8e84-4d4b-bad0-41ee7dc1bbdc"), null, null, "Ivah_Feil15@yahoo.com", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("4141dade-a71d-4f0c-ad0d-2a0fb2f71a2e"), null, null, "Carlee_Vandervort@yahoo.com", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("41ca78b0-691c-45dc-aeb5-39820753b108"), null, null, "Lee50@hotmail.com", false, new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546") },
                    { new Guid("423fce2d-6278-4b5c-ad06-a431cb25666d"), null, null, "Mitchell_McGlynn@gmail.com", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("423fe86d-0c11-4e8b-80d6-7812e5f6cf21"), null, null, "Judy_Greenfelder99@hotmail.com", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("425e755d-07e2-466c-b59b-93849b588d89"), null, null, "Johan.Swaniawski@hotmail.com", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("4292dd66-de22-416e-943f-392ac1c7288a"), null, null, "Lilliana.Shields14@yahoo.com", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("42ebaa48-334b-4b9c-9a44-a0c04011058d"), null, null, "Howell.Runte@gmail.com", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("4442a4aa-cd1c-4f62-8e51-62d354863d4b"), null, null, "Noel_Zulauf0@yahoo.com", false, new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be") },
                    { new Guid("45164309-3302-4b3f-b95b-29506274cbcd"), null, null, "Maude_Crist@gmail.com", false, new Guid("9428c7a5-a397-4b16-aff4-15dc05248196") },
                    { new Guid("45362a04-9054-414a-85d9-7a2055fa75c3"), null, null, "Giovani.Walker@yahoo.com", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("4563b862-ce3a-41cf-99db-c40b46c4ddb1"), null, null, "Monica.Grady44@yahoo.com", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("465d5596-4676-4745-ae76-857e3f8ab28c"), null, null, "Darryl24@gmail.com", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("46983a0b-ef1d-404c-bbed-79f9ade1b710"), null, null, "Judge19@yahoo.com", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("4770c7b0-8ae4-49f9-a78a-3b084320edcc"), null, null, "Janessa_Johns@gmail.com", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("4771c7c6-d62e-4476-a062-74917834f504"), null, null, "Thaddeus10@yahoo.com", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("4787f6c2-6a88-4cf8-9e96-e24865722933"), null, null, "Jaquelin.Thompson@yahoo.com", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("47caeda2-47f3-450d-b238-b2801fe52eee"), null, null, "Lucinda_Rath98@hotmail.com", false, new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b") },
                    { new Guid("486c34d4-3408-4953-8c48-5266476f9692"), null, null, "Flavio46@hotmail.com", false, new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1") },
                    { new Guid("48bfceeb-b92c-4586-ab64-2de6b968d5e6"), null, null, "Shyanne59@yahoo.com", false, new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962") },
                    { new Guid("48f5d7b5-9499-4b8a-a127-c72261f3d057"), null, null, "Heaven.Satterfield@yahoo.com", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("498990f8-19af-4e61-9865-a44974dd18d5"), null, null, "Oral85@hotmail.com", false, new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9") },
                    { new Guid("49c2d51b-ac92-412a-983f-a19b4c634f4f"), null, null, "Frances5@yahoo.com", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("49cee6b8-0913-4599-b556-a5882a972534"), null, null, "Jayson87@yahoo.com", false, new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28") },
                    { new Guid("4a19f57a-6648-48dd-9df8-8860c97413b2"), null, null, "Carmela.Bayer75@hotmail.com", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("4a954aae-3da3-42ad-a099-597083936b66"), null, null, "Linnea.Bailey@gmail.com", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("4abed4bd-cf91-42a2-9ac4-adf91b50259a"), null, null, "Erling71@gmail.com", false, new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81") },
                    { new Guid("4ac8f092-2150-4fc5-90c3-5e56f11cb393"), null, null, "Melany.Casper@hotmail.com", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("4ae3d048-7422-4dad-b895-6c4b475fef1c"), null, null, "Torrance_Cartwright@yahoo.com", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("4afa6798-faaf-46e1-ad0c-b9289e7287a7"), null, null, "Wade_Howell@hotmail.com", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("4b3b79a2-0f9c-4e46-a76c-2690ddcdd0b7"), null, null, "Linwood_Runolfsson@hotmail.com", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("4b5ea992-5419-4f26-a6ef-da2a28b7b72a"), null, null, "Ricardo.Friesen45@gmail.com", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("4bb30808-837f-473f-9d6f-bc0eb2b13490"), null, null, "Milan_Bruen@hotmail.com", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("4c404f5d-a79f-4e11-acf2-ac732ab3ef35"), null, null, "Tara_Cummerata97@gmail.com", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("4cc7855f-b1f3-45de-a18c-5f69ac9ecf73"), null, null, "Sophia_Schuppe57@yahoo.com", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4cca4cda-c119-4fdb-a3c2-1ce4732eec0c"), null, null, "Lenore.Romaguera@yahoo.com", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("4ce4f39f-ad77-4421-bbeb-632fc4e2dd8f"), null, null, "Brett42@hotmail.com", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("4ce7dfb5-35a7-442f-a74d-e90da0867b40"), null, null, "Josie.Flatley55@gmail.com", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("4d29f4f8-09b7-4b7d-8e93-24f0d0c6dd48"), null, null, "Rupert_Roob27@hotmail.com", false, new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618") },
                    { new Guid("4dd57cf9-fe78-490d-8ae1-2bee25f57f0b"), null, null, "Idella.Larson92@hotmail.com", false, new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139") },
                    { new Guid("4e4c70a5-0ee1-4596-b48a-b67797e11d06"), null, null, "Ben80@gmail.com", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("4e5fd02e-dca6-443b-a201-0797f7b99519"), null, null, "Claire2@yahoo.com", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("4ee72cc5-63e1-4849-be74-4509b3e12155"), null, null, "Rocky.Price63@yahoo.com", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("4f43115f-7438-48b4-810d-f5ab37022608"), null, null, "Lavon.Jenkins8@yahoo.com", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("4faec7b7-ab80-4351-9076-09b8492c5955"), null, null, "Mauricio.Bauch@gmail.com", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("4fbcdf46-25c4-49a8-8802-35a83e9c5c7b"), null, null, "Judd54@hotmail.com", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("4fbe399d-aed6-4662-bf66-6beee14c68c7"), null, null, "Lori_DAmore76@yahoo.com", false, new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c") },
                    { new Guid("4fbfb686-4506-41b8-ba2e-cdb66dc5ec4d"), null, null, "Fletcher_Reichert@hotmail.com", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("4fd10f4a-f9c7-400b-9df4-450e02324a1c"), null, null, "Hans.Reinger39@hotmail.com", false, new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440") },
                    { new Guid("4fef2169-7bf8-4479-8901-0e6a9f1896e2"), null, null, "Guy.Cremin11@hotmail.com", false, new Guid("45dee853-0743-493d-b80b-c81b944cc529") },
                    { new Guid("4ff456a7-d590-4f17-b7ce-f403fbb882ec"), null, null, "Charlie.Carter@gmail.com", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("504d57cb-4049-4672-847a-5cd52a22147e"), null, null, "Wilbert_Baumbach@hotmail.com", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("50b5f41e-7d89-4840-b1fd-1f6aec1be533"), null, null, "Abdiel.Hintz@gmail.com", false, new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528") },
                    { new Guid("50e333bc-658d-4523-a757-d813d067f1f0"), null, null, "Raven_Zemlak10@hotmail.com", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("5115fd36-2dfe-4db6-9d7f-e1c7c3d36e87"), null, null, "Wilmer_Friesen97@yahoo.com", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("51433e13-c3b1-42af-8c2a-f8fe68b8161a"), null, null, "Noemy36@gmail.com", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("51a1b0d9-0e74-4aa5-ba45-61c8f3a12612"), null, null, "Ray.Bartoletti79@hotmail.com", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("51a5dfa1-ce35-462c-bc56-0613256125f9"), null, null, "Adell35@gmail.com", false, new Guid("253493f6-b3da-4ae0-a428-05a0560043e2") },
                    { new Guid("533a7bf3-6e68-4d35-a186-5b7b5339144b"), null, null, "Quinten72@yahoo.com", false, new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("539ae95d-f005-40bf-913c-9022fd42f1a5"), null, null, "Stanford50@gmail.com", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("53d96083-d8f7-4e15-b838-df1a7b4a781f"), null, null, "Orpha_Schowalter86@yahoo.com", false, new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52") },
                    { new Guid("54b227a2-e312-4045-8118-49e8e9ab32fb"), null, null, "Lorine42@gmail.com", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("54d1d9e8-eebf-4352-9966-599d04a52ab6"), null, null, "Kaia16@gmail.com", false, new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94") },
                    { new Guid("5514c4c3-d073-4119-b61d-88ed2c92053f"), null, null, "Dangelo.Klein@gmail.com", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("5612883d-d449-4f4e-9ef8-c33530fa747e"), null, null, "Austin.Walsh47@yahoo.com", false, new Guid("a0935a01-c087-4387-9782-37219c8d05b9") },
                    { new Guid("56293485-c70f-4b3b-9b69-59f1781a27f3"), null, null, "Virgie.Mohr@hotmail.com", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("566f5857-16c6-481a-8c86-e9a19e05a58d"), null, null, "Mayra59@hotmail.com", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("56c85f47-eba2-44f9-b109-c527f72ab097"), null, null, "Jacklyn.Hintz@gmail.com", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("571a6333-6cb2-44a5-a143-97543ca0f4dc"), null, null, "Jude73@yahoo.com", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("572843a4-ca3a-468f-a18f-5782db0eba94"), null, null, "Kaya.Osinski@hotmail.com", false, new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75") },
                    { new Guid("57bea3d8-82dd-4d3b-8b48-2780f5e9ce6f"), null, null, "Cedrick_Larkin@hotmail.com", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("580880af-df1e-4b3c-95fa-92d0ffdb9b6a"), null, null, "Brandi.Witting@gmail.com", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("5a10a704-5f76-4b3d-9753-333a767a22e9"), null, null, "Kade36@yahoo.com", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("5a20aff9-ae38-4c5b-82a3-49fcb33d87bd"), null, null, "Kaia90@gmail.com", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("5a57fd6d-b34c-499b-92a9-d2f5fc211c43"), null, null, "Kaci.Lemke3@hotmail.com", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("5afae93a-0014-4a53-a60a-a160023c1a0a"), null, null, "Gregorio59@hotmail.com", false, new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("5b022313-6edb-46cd-8c52-54638d3b7f1b"), null, null, "Ofelia_Weimann@gmail.com", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ba8dcc9-1ab5-4949-b895-605751367e05"), null, null, "Breanna.Grimes96@gmail.com", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("5bcde50f-a10c-4915-a978-a8a8b5b2dbb0"), null, null, "Adrianna_Greenholt53@yahoo.com", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("5c02c449-6787-4296-beb5-e8f37ce1df68"), null, null, "Carli_Zulauf34@gmail.com", false, new Guid("b15da029-129e-47f2-8442-a8831d78a2c0") },
                    { new Guid("5c281f3b-b295-43b9-b63b-d6e03565ff25"), null, null, "Duncan.Oberbrunner@yahoo.com", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("5c9c3ebd-582d-4a6b-b237-8344267b4216"), null, null, "Jayde77@hotmail.com", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("5ca931f0-d36f-4c5f-9adf-373a03df8f41"), null, null, "Kacie_Zboncak@yahoo.com", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("5cc57bf1-3c27-4668-9061-4f0545f6ee59"), null, null, "Sigrid29@gmail.com", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("5d0f845e-9259-4718-b456-8b7c1d845a6c"), null, null, "Rocky.Keeling41@hotmail.com", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("5d787442-eb6d-4046-96bd-0afd7a54fa50"), null, null, "Lulu_McKenzie95@gmail.com", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("5dcb490e-f1a1-45ba-b387-8764e1572483"), null, null, "Belle_Padberg@hotmail.com", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("5e706508-cde8-4366-bdce-ffe00340677b"), null, null, "Koby7@yahoo.com", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("5e9292f9-ce8b-49ab-8997-349a2448a31f"), null, null, "Bernadine57@hotmail.com", false, new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f") },
                    { new Guid("5f2dc240-1a21-4ee2-bab1-a38828435613"), null, null, "Julio.Kihn80@yahoo.com", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("5f41c5a4-1a76-41ae-bd24-46c6cc3aec01"), null, null, "Jaycee_Emmerich21@yahoo.com", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("5f70dd95-33af-4257-8b58-a25f221e378d"), null, null, "Ashly96@hotmail.com", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("5f7f04d7-5d85-4371-9b8a-1ec59929940c"), null, null, "Abdiel17@hotmail.com", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("5f895aa9-450a-4c6c-bff1-4c2f72bb612c"), null, null, "Marc_Weimann16@gmail.com", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("5fa1f12f-c70c-47c0-bef5-f260cc5de8a2"), null, null, "Leo_Toy22@hotmail.com", false, new Guid("bf057140-33a4-45d8-af53-45e3337a92d1") },
                    { new Guid("5fac776c-bc21-4b51-92ad-88088639c750"), null, null, "Antonetta.Schumm@gmail.com", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("5faf664f-2674-4bb1-a612-185623c67ec2"), null, null, "Addison.Considine37@hotmail.com", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("5fead9d8-5ffd-4f11-b966-6db6793ca4f6"), null, null, "Sofia53@yahoo.com", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("609a52b2-c2fe-46f0-8680-b9fd0f5ffc86"), null, null, "Oma.Rosenbaum@hotmail.com", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("609ba9b5-328b-481c-a1a1-520e0219268e"), null, null, "Aurelia_Koelpin45@hotmail.com", false, new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139") },
                    { new Guid("6179cdb6-68fa-416e-b41e-8847b486c42a"), null, null, "Julia34@gmail.com", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("618bffb2-8adf-4140-8763-fb3b0a78a626"), null, null, "Nicole_Conn23@gmail.com", false, new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("622742d4-fefa-4676-a194-dc25a4a59b52"), null, null, "Zula_Littel@yahoo.com", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("624aa4a9-cb63-40aa-be47-e74ce27a4e16"), null, null, "Consuelo_Renner@hotmail.com", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("6250e725-b018-40ed-b91f-a4dd04cc70bd"), null, null, "Deron_Johnson47@yahoo.com", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("62a3fead-945b-43cf-aa11-caa6acd7f8b2"), null, null, "Conrad.Reynolds@hotmail.com", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("62bf62d2-f17a-4ea8-be12-2652f40e95d1"), null, null, "Augusta97@gmail.com", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("62e60ec8-1eac-44bd-a8a7-8195a94f092e"), null, null, "Loyce.Bergnaum27@hotmail.com", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("63961c4c-a5c0-4461-8979-4977ea0a9d77"), null, null, "Dashawn_Turner@yahoo.com", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("639fde50-5eec-4765-b03d-d6c7ea2568d5"), null, null, "Maximus27@yahoo.com", false, new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11") },
                    { new Guid("64185561-4c43-448d-ae1d-eadd96a79e2e"), null, null, "Evert_Casper@hotmail.com", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("64921309-6a1f-45f1-8c7c-7e548cc1bffe"), null, null, "Marion.Koelpin42@hotmail.com", false, new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7") },
                    { new Guid("649b8089-7a3a-46d2-9b9f-2e37dbcda186"), null, null, "Jailyn_Dicki47@hotmail.com", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("64ec2405-8243-4d2f-ade1-de258c5c45f2"), null, null, "Ericka78@yahoo.com", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("652c9fab-86ce-4227-b29d-eb6bc7e64d52"), null, null, "Leola_Zboncak@yahoo.com", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("652dfd17-f569-4f63-ad51-b0dfa029a873"), null, null, "Jalen7@yahoo.com", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("65657be4-9866-4522-9fbc-759521cf45ea"), null, null, "Alessandro.Moore12@hotmail.com", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("656c9f3c-5127-4c1c-a44f-5b70e207fdb9"), null, null, "Wanda60@yahoo.com", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("658047dd-25d5-47d4-b150-a01247cd4d51"), null, null, "Jadon.Will@yahoo.com", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6585b249-447f-4e42-a012-6651732f8737"), null, null, "Geovanny.Carroll@yahoo.com", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("6586da11-659f-41c4-b6cb-4169d96fd63d"), null, null, "Johanna70@yahoo.com", false, new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("65bd40bf-50c3-43a6-af4b-ed03c5c8d04d"), null, null, "Ricardo_Herzog@gmail.com", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("660147d1-7fec-4647-accf-a1046d605be2"), null, null, "Ada.Treutel10@gmail.com", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("66a3c634-9bb1-4d60-a78c-ffab486f7b2a"), null, null, "Lily_Jacobi@gmail.com", false, new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22") },
                    { new Guid("684d0ebb-524c-4e82-9e65-802f264ea82f"), null, null, "Alexandra.Kuhic@yahoo.com", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("68505e24-f75b-46bf-9a25-fc772ede522b"), null, null, "Elton_Marvin32@hotmail.com", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("68636663-7ba5-4766-aea1-c26d3abff46c"), null, null, "Lenny69@hotmail.com", false, new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("68798df9-7b0e-4020-bb8f-b5eb19be98c5"), null, null, "Magnus1@hotmail.com", false, new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2") },
                    { new Guid("687bbe91-6a77-4730-841c-1c3f66c1f366"), null, null, "Mellie_Stehr@yahoo.com", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("6932e2fb-ed9e-4eb9-b851-07f849487a2f"), null, null, "Hipolito24@gmail.com", false, new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf") },
                    { new Guid("6999f5cc-4a47-4bca-af63-743e384b8a4c"), null, null, "Bethany.Brakus@yahoo.com", false, new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9") },
                    { new Guid("6a369008-8e1e-41b6-b9b3-d833c1d4bf49"), null, null, "Jillian67@yahoo.com", false, new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240") },
                    { new Guid("6b4ca1c8-ea37-4f92-8022-db50f0997681"), null, null, "Zechariah52@yahoo.com", false, new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd") },
                    { new Guid("6b69ef8a-f088-4dc8-86c3-9356c2b29a33"), null, null, "Hillard_Schultz@gmail.com", false, new Guid("b15da029-129e-47f2-8442-a8831d78a2c0") },
                    { new Guid("6b971307-91ed-4139-ac9f-2b6b6c2a4269"), null, null, "Domenick_Schmitt71@hotmail.com", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("6bbbc967-4f58-4b5d-a850-d2c6fec3912d"), null, null, "Bernice66@hotmail.com", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("6be71d6a-b63b-4fed-987c-361f64b71a1c"), null, null, "Zachery59@yahoo.com", false, new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f") },
                    { new Guid("6c6fb749-c00a-40ff-b083-22697208c2a1"), null, null, "Kiera_Auer@gmail.com", false, new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8") },
                    { new Guid("6cd2d1f4-ed21-4977-95e0-f3b4bfbc86f7"), null, null, "Ila.Rosenbaum52@hotmail.com", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("6d36da70-172b-47d3-a313-eb8759ee0585"), null, null, "Damion_Paucek@hotmail.com", false, new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b") },
                    { new Guid("6d495360-8188-4dff-82f9-0a12bc644ab8"), null, null, "Mazie43@yahoo.com", false, new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("6d4ca556-6959-4414-a827-a0130005f606"), null, null, "Paul32@hotmail.com", false, new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37") },
                    { new Guid("6da699bd-919c-4b9a-bf1f-23d05b32d990"), null, null, "Gabe_Herzog@hotmail.com", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("6e21cd59-31bb-4312-b832-cd9db84500b7"), null, null, "Paige_Jakubowski@hotmail.com", false, new Guid("53078823-cbdb-4f6c-b393-57486464289a") },
                    { new Guid("6e394f1e-3122-49c9-8340-a09e23e79c45"), null, null, "Earnestine36@hotmail.com", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("6e724dd9-1bdc-4633-b69e-4822332ee139"), null, null, "Teagan.Terry@hotmail.com", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("6ed0e95b-0093-4c0f-8b32-046b5e94c981"), null, null, "Dandre34@hotmail.com", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("6ee486dc-e7ab-4196-8aa8-58951246ece1"), null, null, "Aimee.Ward31@gmail.com", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("6ee4f9c7-793a-462b-b082-8aa77e91dcb9"), null, null, "Tatyana.Steuber@yahoo.com", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("6f5d9df8-f4b3-4785-864d-c544ff4b19e5"), null, null, "Lilliana80@hotmail.com", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("6feafd4e-a56d-4035-bc03-c19339b3bebd"), null, null, "Grover.Skiles49@yahoo.com", false, new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1") },
                    { new Guid("6ffa7c19-9dbb-418c-afc1-4cba554d48be"), null, null, "Jade.Lesch@yahoo.com", false, new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816") },
                    { new Guid("7026bc61-5ea2-44cb-a026-98d288a40424"), null, null, "Arlo_OConnell26@hotmail.com", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("705fe4ff-6f06-45f7-aeb4-b200583a0806"), null, null, "Keon_Hills85@gmail.com", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("7063ab54-77f2-43cd-904b-e4d7ee75022d"), null, null, "Janae_Langworth51@gmail.com", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("70a9e754-1800-4908-878a-60942263922a"), null, null, "Amy.Marquardt@yahoo.com", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("716bd345-7f65-4a1d-a0b2-bc1018ab4c7d"), null, null, "Bonnie93@hotmail.com", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("71c89aad-1f4b-4ddd-bc95-b5e414f4b266"), null, null, "Ruben_Blick@gmail.com", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("71e3daad-f3c1-4f33-a116-850b9d43103e"), null, null, "Rey77@yahoo.com", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("726f5c5c-47fc-44f8-9176-20081004c2e9"), null, null, "Bernie41@hotmail.com", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("734767a3-201c-4e55-814d-4d3af1ff6f66"), null, null, "Marcus59@yahoo.com", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("73dd880a-166b-4544-bc3f-42dcb1fde546"), null, null, "Antonietta36@gmail.com", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("73fd37c0-bb48-4dbf-b345-f6b9ebdf6e00"), null, null, "Raphaelle.Stokes@gmail.com", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("7407161d-3493-4300-89e2-42eccc98dded"), null, null, "Crystel_Kris@gmail.com", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("74662edb-758b-4b49-9ec6-0421de3afd79"), null, null, "Santina.Buckridge@gmail.com", false, new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919") },
                    { new Guid("74d7fbc5-4f1f-4aca-9f73-85d44baa616e"), null, null, "Kelvin19@gmail.com", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("74f9c0d1-a705-46c7-a739-975e80755e66"), null, null, "Madeline.Hoppe3@gmail.com", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("752be726-f48c-4142-8e77-971b204406a6"), null, null, "Lorenz.Welch79@hotmail.com", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("753b67ec-42c3-468c-b20d-38967f34d3c6"), null, null, "Sophie89@yahoo.com", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("7564ad24-a85a-4ad0-900f-eae1f4b9172f"), null, null, "Kris.Durgan@hotmail.com", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("75722751-b4b0-4d97-bd5f-e87785bb8dfd"), null, null, "Sid34@yahoo.com", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("75c82402-7a44-40bb-b5a0-bce6627588ac"), null, null, "America.Bogisich@hotmail.com", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("75e3e5c2-e609-4442-925a-ecefcee4f2a1"), null, null, "Allene.Wilderman35@gmail.com", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("7658e0c0-dae3-4eb4-be46-471956dc03b4"), null, null, "Kattie33@gmail.com", false, new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c") },
                    { new Guid("766ef106-cea8-491f-ac8e-93d4e7e8c3dd"), null, null, "Louisa_Gerhold48@gmail.com", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("7680cb15-e723-416e-8593-b30367aa694b"), null, null, "Conrad.Von@yahoo.com", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("768874fb-3a59-4af5-9669-5f7aab301800"), null, null, "Concepcion_Zieme@yahoo.com", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("76962bb0-3088-4888-a442-92ead05826c6"), null, null, "Filiberto_Bogan@gmail.com", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("7718454a-a92a-48b9-b2c1-10a06f25d76e"), null, null, "Alanis.Sporer@gmail.com", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("773a073e-bde6-4d61-b179-ec71b5ed8cca"), null, null, "Karl.Mayert@hotmail.com", false, new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f") },
                    { new Guid("777cbacc-7d93-4199-94e8-48c611ea0908"), null, null, "Kathleen34@gmail.com", false, new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc") },
                    { new Guid("777d492c-ba17-4578-8b66-4687c445682f"), null, null, "Deja79@hotmail.com", false, new Guid("a0863958-35de-49a9-a73b-decb03e0c871") },
                    { new Guid("779a5d9f-cb32-4341-a2b2-b12445416d55"), null, null, "Joey.Greenholt@gmail.com", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("78b8ef96-cc4e-435e-988f-5ce938eac746"), null, null, "Bartholome44@yahoo.com", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("78c79863-9ff3-4d8d-91cf-e39bb727c3f6"), null, null, "Reinhold98@yahoo.com", false, new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c") },
                    { new Guid("78dfe0db-943e-41cb-b642-97c3ed97a547"), null, null, "Ramiro76@hotmail.com", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("794cd8a3-e587-4da9-910e-a30533b379a0"), null, null, "Randi.Langosh@yahoo.com", false, new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc") },
                    { new Guid("79bcabfc-6b97-4617-814d-8597baacf20e"), null, null, "Jamir98@gmail.com", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("79ddfe4d-62c0-45eb-b34d-74b733e961bc"), null, null, "Mustafa.Price45@yahoo.com", false, new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1") },
                    { new Guid("7a2dae26-1b73-4084-9bff-9eb4ab7a3899"), null, null, "Skylar85@gmail.com", false, new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f") },
                    { new Guid("7a2efdc1-eeb1-4093-a6bb-d2ae788d17f4"), null, null, "Kayden.Hahn@hotmail.com", false, new Guid("6c7090cd-7244-4437-b460-88c7027c78f9") },
                    { new Guid("7a521ecc-c436-43d3-b1d3-dfb6963d3ab1"), null, null, "Joaquin.Lemke@hotmail.com", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("7a802895-e865-4fe2-a8ad-ac2801e42278"), null, null, "Urban_Paucek@gmail.com", false, new Guid("171184db-5baa-42f3-92d8-64b8e76c6165") },
                    { new Guid("7b1ab6d8-8b59-4bb8-8176-8a797fb8c399"), null, null, "Lauren.Kunze@gmail.com", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("7b7d0e14-5546-4fc4-94f7-84a79cdd1b8f"), null, null, "Caroline_Veum@gmail.com", false, new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af") },
                    { new Guid("7bb3cbb5-6271-4e61-9034-b07f09df3b49"), null, null, "Brielle.Runte63@gmail.com", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("7bc5d043-15fe-4c3e-9f2f-98eb803b886c"), null, null, "Roselyn24@gmail.com", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("7be1dfc7-3e62-4ae5-9fc6-70febdcb83d9"), null, null, "Breana_West81@gmail.com", false, new Guid("e57373e2-48de-4c55-9c02-9b87c7751318") },
                    { new Guid("7c165de9-a8c4-4f92-b0c3-8911249f5fb6"), null, null, "Cleveland.Kshlerin@hotmail.com", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("7c3d0463-67af-4402-bfb0-af0e4906d1a9"), null, null, "Eloise_Hammes@yahoo.com", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("7d1cb6ae-d6cc-4e88-88d9-2ae2384507f3"), null, null, "Trent38@hotmail.com", false, new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1") },
                    { new Guid("7d694e00-fb69-4675-b4a5-350cfae10d1b"), null, null, "Tristin.Mraz73@gmail.com", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("7dc48c66-a82f-4718-aa61-b5401fa919c6"), null, null, "Demetris_Simonis@gmail.com", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7dfcca83-5279-4681-ad56-dfe237ad61cb"), null, null, "Tobin64@yahoo.com", false, new Guid("be28704f-919b-414b-b444-7bf3be5f0534") },
                    { new Guid("7e24322d-db78-446b-b143-0b98894650f6"), null, null, "Therese83@hotmail.com", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("7e45a9f7-a71d-4c2a-ba33-98c7632d05f3"), null, null, "Sallie36@hotmail.com", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("7eb7c467-f5d6-4239-b022-cd35520fac96"), null, null, "Savion.Pagac97@yahoo.com", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("7ee5e784-046c-4f3a-8012-f612c05aa116"), null, null, "Brandi72@hotmail.com", false, new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb") },
                    { new Guid("7ef70830-26c7-469b-90b8-d0165f4875b2"), null, null, "Rodolfo_Reinger52@yahoo.com", false, new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c") },
                    { new Guid("7f1e877e-da81-489f-8a92-d6207306f529"), null, null, "Cydney46@gmail.com", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("7f66663b-a89d-41c3-b8a7-102e8c0ec501"), null, null, "Gavin75@gmail.com", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("7fb44487-8b32-4c19-a1dd-e778f1b1d839"), null, null, "Kiel92@gmail.com", false, new Guid("bf057140-33a4-45d8-af53-45e3337a92d1") },
                    { new Guid("7ff77db9-c862-402f-8ffe-e57a68614ff0"), null, null, "Elaina78@gmail.com", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("7ffc6819-3ba7-4cdf-8672-ace1dd4984ed"), null, null, "Fabiola95@gmail.com", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("815dd653-afd4-4cab-9607-f23f84c51bda"), null, null, "Xzavier_Sipes@hotmail.com", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("81886dc9-5bab-4724-ba4e-145d26e0a882"), null, null, "Howard.Gerlach28@gmail.com", false, new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e") },
                    { new Guid("820a415a-123b-47b9-a919-d42d2b7c7ef1"), null, null, "Owen.Schuppe@hotmail.com", false, new Guid("4a21367f-81c5-4947-b939-b44d17e67434") },
                    { new Guid("8286bcbc-2257-463a-ae38-3ebfe8b9b0a7"), null, null, "Enrique.Olson91@hotmail.com", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("8304f1b4-a00b-4240-bd59-5ee94cca55f3"), null, null, "Lorine.Wehner80@gmail.com", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("831c02c8-980d-4054-b551-9cffb40c6783"), null, null, "Nona.Cormier63@hotmail.com", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("83631883-d1e4-41b4-9516-571324a03798"), null, null, "Meda_Berge23@yahoo.com", false, new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340") },
                    { new Guid("837aa155-ad93-47ac-880d-73306400f64e"), null, null, "Brielle78@yahoo.com", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("83a7220c-bbca-4c89-8283-29b06d19f04a"), null, null, "Jarvis.Botsford@gmail.com", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("8405e996-3b52-4517-8297-4e66d6ccddb9"), null, null, "Rico.Reynolds@hotmail.com", false, new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2") },
                    { new Guid("846acf84-c2f5-468b-9e37-6c10376e8604"), null, null, "Robin_Rau@yahoo.com", false, new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315") },
                    { new Guid("84759689-0222-4b8f-830d-9ef90f9e5b2c"), null, null, "Zelda.Collins@yahoo.com", false, new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37") },
                    { new Guid("84dd5690-acd0-4645-b618-e6da17e13569"), null, null, "Rod.Nicolas52@hotmail.com", false, new Guid("d5908335-16ba-435a-9a9d-603eaee07878") },
                    { new Guid("85298bbe-924e-42c6-bb31-eccbf8a93545"), null, null, "Aron_Trantow36@gmail.com", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("85410fa8-4ba2-4b4f-9853-ba2a72facad9"), null, null, "Wendell48@gmail.com", false, new Guid("671bbcc1-9768-4630-8a24-d7626303ad52") },
                    { new Guid("8546b1bf-a002-48a2-bfd0-5e40d22d2bc6"), null, null, "Ola.Homenick0@hotmail.com", false, new Guid("7156fae1-f350-4998-b43f-3d5664953dc8") },
                    { new Guid("85548fce-3402-4392-9a89-f3b4af93c921"), null, null, "Jonathan_Lebsack@gmail.com", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("855cadc4-8f18-4e71-b14e-6b527a944797"), null, null, "Sallie_Reilly@yahoo.com", false, new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d") },
                    { new Guid("858827d3-8ca6-46d9-8962-796f6f8143d4"), null, null, "Piper.Shields@yahoo.com", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("85b3f617-27fc-406b-95af-8656d4cdd88a"), null, null, "Marlen76@yahoo.com", false, new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac") },
                    { new Guid("85dd7b21-4075-4648-a06d-b11392bf0859"), null, null, "Jayden71@hotmail.com", false, new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8") },
                    { new Guid("8649b9d1-9c32-4287-83f7-a56720c1c277"), null, null, "Lyla.VonRueden@hotmail.com", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("86b08902-0ee2-4494-918b-fba56e5ab500"), null, null, "Myrtle.Dickens@yahoo.com", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("87f41b83-013b-4333-b3aa-b036b3d8a46d"), null, null, "Oscar.Schroeder2@hotmail.com", false, new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("8849af0e-8fb3-41c2-8fa8-e256a7e329ec"), null, null, "Tiana_Crist@hotmail.com", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("886e8c95-dd16-45fb-be6c-0a88a3a193ff"), null, null, "Michale_Runte66@hotmail.com", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("888c2e8b-0561-41c4-ab19-c404c956108f"), null, null, "Sydney_Batz@hotmail.com", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("89177e08-6012-4f67-810a-660d7cf8b719"), null, null, "Ryder96@gmail.com", false, new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b") },
                    { new Guid("898067d8-4fb2-4bc5-94cd-9412dcbd1ad5"), null, null, "Evan_Schaefer58@yahoo.com", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("898349dc-8975-4ef3-b46f-8abc5bbf9aa1"), null, null, "Kyla.Moen@gmail.com", false, new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84") },
                    { new Guid("89d85e82-fcd3-40a0-8d12-7c63dc1284a4"), null, null, "Rosemarie60@yahoo.com", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("89e8081f-5750-44c0-b0dc-30608a5b705f"), null, null, "Stephen_Borer37@gmail.com", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("8b08e2b6-314f-4c95-bc88-62517df7550c"), null, null, "Jaime59@yahoo.com", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("8b2b3837-1389-472e-ac6b-7349c52a779b"), null, null, "Sofia_Stark22@gmail.com", false, new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919") },
                    { new Guid("8b937cd1-ea8a-44c4-aa23-cd9c575e3822"), null, null, "Ray20@hotmail.com", false, new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6") },
                    { new Guid("8bd18355-fa14-4cc7-89fd-bdb2721750db"), null, null, "Maya_Jast77@hotmail.com", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("8bd542a0-a242-47c1-8f3e-d213b87c7f84"), null, null, "Jamar81@gmail.com", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("8bed6bf3-1524-4779-917e-ab5e9816b22c"), null, null, "Liza61@hotmail.com", false, new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("8c487cc4-431b-4f4a-a314-2c39c21dd401"), null, null, "Art52@gmail.com", false, new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816") },
                    { new Guid("8c5ac414-17fc-482f-900f-72a580049de9"), null, null, "Jamarcus.Hettinger@yahoo.com", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("8cb1c808-b39e-4067-b379-dde7a0f91b22"), null, null, "Mateo.Bartoletti41@yahoo.com", false, new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("8d92dbdc-1f12-450a-afbf-3e217dc9a1c5"), null, null, "Reese.Rowe78@gmail.com", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("8dd1b693-ff84-47a4-bffb-1034a31acc6b"), null, null, "Frederique_Rutherford54@gmail.com", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("8e79a8d1-c3dd-47e2-8e95-f6402769eb9f"), null, null, "Rudolph.Watsica@hotmail.com", false, new Guid("ae750269-835b-481a-8e36-4dd8044f9527") },
                    { new Guid("8e86b4dc-846b-4e50-bdfb-acb3f9156f8d"), null, null, "Lucinda.Shields@yahoo.com", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("8eb7e44b-c83d-4ba8-8a77-e5a69802ee2c"), null, null, "Nels7@gmail.com", false, new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("8ee51039-0536-4186-931b-6f2cabd9348c"), null, null, "Margret10@yahoo.com", false, new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("8fb03494-95df-43a4-9f33-39a727120c73"), null, null, "Savanna_DuBuque@hotmail.com", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("901b6ea7-1379-41a5-bd91-b221791f3766"), null, null, "Hassan.Kohler@gmail.com", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("904869a5-4eab-4248-b776-221b3967c6c8"), null, null, "Annette.Cormier8@gmail.com", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("909f5351-fe12-470f-8171-2589da09a99d"), null, null, "Xzavier_Schmidt@yahoo.com", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("910174a0-9e7f-4585-9969-dabc06b63f45"), null, null, "Georgette.Batz54@hotmail.com", false, new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a") },
                    { new Guid("910c6b87-85e1-41d6-b4cc-e59d2854673c"), null, null, "Marielle.Leffler@yahoo.com", false, new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400") },
                    { new Guid("916f1117-f645-412c-b9b2-ecb0c8b89664"), null, null, "Rosella45@gmail.com", false, new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("919322cc-87dc-4cb7-b9ce-4142eeb7b4eb"), null, null, "Daisha_Hegmann@yahoo.com", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("91ad892c-b94b-4173-803c-7543f950a2d2"), null, null, "Margarita_Schoen59@yahoo.com", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("91e01181-ed4a-42fb-863f-39683d789c42"), null, null, "Neoma.Graham20@hotmail.com", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("92376160-bee2-4c83-baa4-80e91dd5e756"), null, null, "Benjamin9@hotmail.com", false, new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340") },
                    { new Guid("925aff48-2c76-438e-84ae-7ae93f7a44cc"), null, null, "Elinore_Schiller49@yahoo.com", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("92da08a2-4385-4a8f-bee7-2196304b020a"), null, null, "Annabel.Altenwerth@gmail.com", false, new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("93134f29-9a38-4f90-b690-8b281527e1a9"), null, null, "Murphy.Morissette15@hotmail.com", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("938938ea-5853-4d1e-8d3d-45ad5e154542"), null, null, "Ike71@yahoo.com", false, new Guid("fd051a5e-4258-4bbf-b64a-29676b007443") },
                    { new Guid("93bfc06d-8dcb-4a5e-8577-8b9eddfa610a"), null, null, "Sally66@yahoo.com", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("942a904e-df59-4929-9c6a-4adfce580d5b"), null, null, "Horacio.Gusikowski@gmail.com", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("9453c4ec-e3b2-49cd-af01-93fc4d912ccf"), null, null, "Irwin.Bartell80@gmail.com", false, new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef") },
                    { new Guid("94e25fc7-6edc-4db9-8e0d-0d22093fa60a"), null, null, "Amiya_Rath@yahoo.com", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("94fb9963-868b-40df-83ea-399e4c5fa384"), null, null, "Franz.Konopelski@hotmail.com", false, new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240") },
                    { new Guid("9535a55e-2ce0-4973-85a0-8d0d2158dc0f"), null, null, "Toy_Kulas72@hotmail.com", false, new Guid("d364b716-4b5c-4090-99d6-0f11b5849701") },
                    { new Guid("9536c58b-3b2c-4e25-960e-ca09015a3249"), null, null, "Rylan51@gmail.com", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("95b0b11d-baa2-453f-b99d-75a4742ffb78"), null, null, "Oran.OHara43@gmail.com", false, new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7") },
                    { new Guid("95c6cb90-a1e2-4d28-82c7-e4286ab960a0"), null, null, "Jessie48@hotmail.com", false, new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb") },
                    { new Guid("961a3dcc-6a6e-4516-a67e-1024d37bb5c7"), null, null, "Amie_Lakin84@yahoo.com", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("9674323b-ffdc-4d89-9feb-186be1411c20"), null, null, "Isaias38@hotmail.com", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("96fbfbda-7e32-43aa-9616-5062fbed5a5b"), null, null, "Kayla_Towne@gmail.com", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("970fa419-aa41-4b93-a405-e07e45f65951"), null, null, "Haylee_Dibbert@gmail.com", false, new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("97262be0-fe17-431e-bf65-760fab0f988c"), null, null, "Dalton66@yahoo.com", false, new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc") },
                    { new Guid("97447d58-f30d-4536-894a-0eb20d8dfe8d"), null, null, "Bartholome_Powlowski@yahoo.com", false, new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350") },
                    { new Guid("975d8f93-53bd-4a96-a494-f6aea00fd7c7"), null, null, "Lola35@gmail.com", false, new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8") },
                    { new Guid("97b4cf1a-6dcb-4371-80b1-6ecc71bf1cc4"), null, null, "Jordane64@hotmail.com", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("97e1f6bc-6186-4ede-8fd6-c0d8ee07f9fa"), null, null, "Vickie45@gmail.com", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("983fdff5-520d-460d-ad81-8f86f7379a2a"), null, null, "Gay38@yahoo.com", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("98a3d0b9-7bae-4aee-a5c3-105f3ed8cfb7"), null, null, "Mariane97@yahoo.com", false, new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("98ba4a3c-4b69-4870-93d4-ae1168c95a52"), null, null, "Jazlyn_MacGyver@yahoo.com", false, new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b") },
                    { new Guid("99257aa8-30fa-4832-aaad-736f0e8a4f00"), null, null, "Lauriane.Brekke@gmail.com", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("998a597f-0125-45c7-8bc1-47ee1772b0bf"), null, null, "Toni.Gislason@hotmail.com", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("9995dc49-6399-4dd3-9e60-f523613e71e6"), null, null, "Robbie63@gmail.com", false, new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b") },
                    { new Guid("999ca4a5-ca88-4383-8174-a0c7b514eb01"), null, null, "Benton19@hotmail.com", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("99a2cd59-c603-445f-a27d-462f3f30b0b8"), null, null, "Ed14@gmail.com", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("99c81e8b-a0ba-4dff-949f-03529296632c"), null, null, "Magdalena.Lemke@gmail.com", false, new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9") },
                    { new Guid("9a4aa85a-c042-40b7-be3d-bfe42ce919bb"), null, null, "Bailey_Haley@gmail.com", false, new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d") },
                    { new Guid("9a724a26-126f-4581-b972-e21ba23073da"), null, null, "Russel21@gmail.com", false, new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("9a9c7d68-a546-475c-8d0f-da04bc695242"), null, null, "Yasmin.OConnell78@hotmail.com", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("9aa08a0f-641c-4001-bb44-68752ee16a86"), null, null, "Raul30@hotmail.com", false, new Guid("067bf875-8a96-48a0-978d-10d890bd7318") },
                    { new Guid("9ab13c98-5e57-45e9-ae2b-1db2eca02b99"), null, null, "Amy_Stracke17@hotmail.com", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("9c541eda-7fc3-41b9-8abb-2b733d3e724b"), null, null, "Rosalia_Aufderhar@hotmail.com", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("9c7a6498-7951-49ec-ba56-0ac9d6d16a15"), null, null, "Lowell.Bahringer@yahoo.com", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("9c9eaff9-9183-4f58-b3c4-2f183ec2ea02"), null, null, "Jamar62@yahoo.com", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("9ccb9db9-c731-46fb-9cc3-b95648406155"), null, null, "Elinore.Bode@gmail.com", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("9cf77eb1-4eda-4bb9-85d5-9d064757ba5f"), null, null, "Maddison.Schinner@hotmail.com", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("9e18a7f9-077e-4e4e-8aed-2f7bfc2b5059"), null, null, "Brooklyn.Olson@hotmail.com", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("9e834abf-3cc6-47d6-af5a-0c62a58fa0fe"), null, null, "Tiffany33@hotmail.com", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("9eb2faf4-2a08-4348-bf65-11df878b92a0"), null, null, "Allen.Rath@gmail.com", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("9f2f2e0f-dcf4-4381-89aa-c4f1b96d1630"), null, null, "Sven_Hauck@yahoo.com", false, new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("9fa8e748-e928-4309-bb93-c56c567a0b54"), null, null, "Sandy.Fadel@yahoo.com", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("a09ab184-9421-4141-a394-0f6f8c39d773"), null, null, "Conner67@gmail.com", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("a0ae4bd1-9bed-429d-8ab7-2fd006fc8206"), null, null, "Jeremy_Klein@gmail.com", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("a0d8f0ca-4a6f-4b1f-910f-c2db38a457e8"), null, null, "Melyssa.Durgan29@hotmail.com", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("a1f6b4b2-ed14-46ca-847a-4ce2bc3a8058"), null, null, "Wilmer55@hotmail.com", false, new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2") },
                    { new Guid("a212e151-f45d-4f40-a3a3-4df5108b62e2"), null, null, "Jasper_Rodriguez@yahoo.com", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("a2199bf7-59fa-4731-a3bf-b47701383642"), null, null, "Blaise78@gmail.com", false, new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") },
                    { new Guid("a298a0f6-3b8b-4a71-ad2d-dc4c826de104"), null, null, "Marshall.Hartmann35@gmail.com", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("a2bf2982-9831-4f0b-bca9-1c8ff12219c1"), null, null, "Omari_Mertz@gmail.com", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("a3993eb9-720b-49ea-bb3a-e017642f32bb"), null, null, "Candelario33@yahoo.com", false, new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35") },
                    { new Guid("a48f41ef-3a62-49d5-a0ca-42452d24a4aa"), null, null, "Colten.Treutel46@yahoo.com", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("a4e9568c-7058-4e39-b180-8402725233b3"), null, null, "Jacynthe_Jaskolski@hotmail.com", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a51adf1e-1ee0-4d02-995e-e3b7d09c6de4"), null, null, "Aubrey_Will42@yahoo.com", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("a5548cf3-6b55-4547-84a6-c7324344d73b"), null, null, "Kara_Denesik@gmail.com", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("a5a9ad8d-4833-4ae4-9a5f-4103a51654c2"), null, null, "Marc_Haag@gmail.com", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("a639fa86-4f3a-47cf-a5db-862f185bb1d5"), null, null, "Schuyler_Hane55@hotmail.com", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("a66aa5b3-6c21-46f4-94d4-39af21c30546"), null, null, "Vada25@hotmail.com", false, new Guid("6224405d-f9d8-407b-9f81-847223041784") },
                    { new Guid("a6f27f63-4210-462e-b56b-97d94e2725ca"), null, null, "Enrico.Leannon@hotmail.com", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("a7355013-48be-4858-9db8-1f188335909c"), null, null, "Jermain_Boehm@hotmail.com", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("a7a5b61b-17c9-408c-9801-62acc624ee90"), null, null, "Unique_Rippin14@gmail.com", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("a7eeb40f-66a1-4f95-a83e-f6861ce151f7"), null, null, "Winona25@yahoo.com", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("a8048f9f-3b6e-4cfc-be66-702dd7cdce1c"), null, null, "Everette_Prohaska98@gmail.com", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("a806fbac-f78f-4268-a128-d5e76a86f712"), null, null, "Laurine.West@yahoo.com", false, new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262") },
                    { new Guid("a8463e44-693c-45a2-b51e-fc765d76a985"), null, null, "Izaiah.Prosacco75@yahoo.com", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("a88d7acf-f67a-4f23-bf1d-129941916b9f"), null, null, "Halle33@gmail.com", false, new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b") },
                    { new Guid("a8b14b6f-a99f-4433-9515-ff7630936e55"), null, null, "Christian_Windler95@yahoo.com", false, new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8") },
                    { new Guid("a90bdc15-1f9f-4ef3-bacb-674822f00f16"), null, null, "Felton.Lebsack@gmail.com", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("a98100e5-185b-42db-bc71-1efeee69a12c"), null, null, "Rogelio_Pollich80@gmail.com", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("a9ab8013-83df-462e-8bc6-7d66ba21e083"), null, null, "Herbert_Rath82@gmail.com", false, new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6") },
                    { new Guid("aa1a9758-cc8f-4971-83f9-b3030ca4b06e"), null, null, "Caden_Kulas@yahoo.com", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("aa3ba20b-a888-44b6-b72b-fec0848deea1"), null, null, "Kirk.Volkman@hotmail.com", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("aa876e9d-0dd4-479c-8fb5-29b4a02c52c3"), null, null, "Jaycee_Cronin62@yahoo.com", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("aab370af-ef88-4e99-9771-b7a2b3fa125d"), null, null, "Andres_Quigley@yahoo.com", false, new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f") },
                    { new Guid("ab06428b-70f5-4caf-ba61-e009253ec64e"), null, null, "Laisha89@gmail.com", false, new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3") },
                    { new Guid("ab4a4666-a613-4ddc-987e-096be11ae60f"), null, null, "Mekhi_Reinger84@hotmail.com", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("ab718e98-e319-4303-832d-a642af3d779f"), null, null, "Vidal32@hotmail.com", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("ab80ab91-5999-4a19-a4ff-b22e91103977"), null, null, "Laila69@hotmail.com", false, new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51") },
                    { new Guid("ab8ad38c-29dd-4412-8fc6-9bd7567289c3"), null, null, "Derrick61@gmail.com", false, new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22") },
                    { new Guid("ac5dee64-0914-4340-b7ad-e79202489aef"), null, null, "Jordane_Rau74@yahoo.com", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("ae074764-5064-4df7-991c-254f4ad43672"), null, null, "Reed_Schowalter@gmail.com", false, new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d") },
                    { new Guid("ae08489d-1a92-4575-b899-0166aa18eb38"), null, null, "Watson41@yahoo.com", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("aea22956-bfcf-4cd6-8366-4e244a92f5d1"), null, null, "Ettie.Welch76@hotmail.com", false, new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("aefca614-1090-4c11-aa67-03c7bfbe39a7"), null, null, "Jessica.Halvorson@hotmail.com", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("afeed9d4-f184-4ab5-a5aa-09aec98f2dd2"), null, null, "Mavis.Bahringer40@hotmail.com", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("b043918e-b59a-4930-8b48-2ef9fb5f4897"), null, null, "Camila26@yahoo.com", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("b09c0369-2d94-4b84-8efc-f00d50034d8e"), null, null, "Aric_Murazik@yahoo.com", false, new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("b1423970-7f3e-4800-99b1-7048d9b383e1"), null, null, "Morgan45@gmail.com", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("b15169b8-bbf9-4805-8144-94dabaa9a4dd"), null, null, "Jeremie_Bartoletti54@gmail.com", false, new Guid("a0935a01-c087-4387-9782-37219c8d05b9") },
                    { new Guid("b1ae323d-ea2e-4d8f-bae9-31710b9acfdb"), null, null, "Tyrique52@yahoo.com", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("b2abb6ef-8203-42af-9cf3-b8c9b730e4e9"), null, null, "Bessie.Shields6@gmail.com", false, new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d") },
                    { new Guid("b35fa676-eef8-4868-9eb9-e7b1b5bf6a0f"), null, null, "Karianne.Kautzer@hotmail.com", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("b3c0c295-e8c4-4d7a-afcc-9494940bd2ab"), null, null, "Adrian.Flatley21@gmail.com", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("b3dc999c-d653-4128-96d2-c6f59c23dde5"), null, null, "Elody_Cormier6@hotmail.com", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("b4168708-c417-4c8e-b4e9-6c05e60d8a3d"), null, null, "Erik57@hotmail.com", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b489faad-ec86-4d6f-8242-3e097ef64f6f"), null, null, "Johnathan31@hotmail.com", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("b49a683f-d71d-4f8e-a6fd-e534cbb7ad74"), null, null, "Josue.Murphy65@gmail.com", false, new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502") },
                    { new Guid("b4d8b62c-f59d-4977-807d-8b875e82eee9"), null, null, "Evie_Upton@yahoo.com", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("b4d987e4-6486-45ca-a38e-58dcd2ff53e5"), null, null, "Elroy74@hotmail.com", false, new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("b4e98e0c-c2e4-4b6b-8f6a-f9c05d2e5d9a"), null, null, "Caleb.Murphy98@hotmail.com", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("b51d26c5-dbef-495b-a2e3-25b34019a3d6"), null, null, "Cicero_Koch@yahoo.com", false, new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81") },
                    { new Guid("b53ee872-8660-47e5-8638-0fc08d019e45"), null, null, "Maximillia23@gmail.com", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("b56f96d2-2de1-494d-9cc6-c7b6deaff55b"), null, null, "Merritt19@gmail.com", false, new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("b60e97a2-1194-4e32-8e77-95323b7f7a29"), null, null, "Alberto.Upton68@hotmail.com", false, new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9") },
                    { new Guid("b6601917-a64a-4f9e-95b8-111c5c151e5a"), null, null, "Elvera.Tromp@yahoo.com", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("b69575d1-cbcb-4df7-a305-a77b513a63ce"), null, null, "Carmela34@hotmail.com", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("b6ab6d50-07d0-482d-9721-2efc6b287bb8"), null, null, "Bonnie42@yahoo.com", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("b7526585-a1e0-4311-b941-d34f35278ad6"), null, null, "Daisy81@hotmail.com", false, new Guid("929221d7-8d45-4a44-b501-41a47c26cf44") },
                    { new Guid("b75dc5c1-36b3-4b55-b69f-3d9447e003f1"), null, null, "Omer_Emmerich@gmail.com", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("b78123d5-d76e-4291-b458-25153ffeb09b"), null, null, "Agnes_Klein73@hotmail.com", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("b89b2404-9f30-455c-9004-fab5f4cd2e07"), null, null, "Orval53@gmail.com", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("b8ebb815-6b81-4674-a72c-a1881d324458"), null, null, "Eloy_Walter@yahoo.com", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("b8ec42e7-18bf-41ad-a5a9-810b98d33df2"), null, null, "Nathan40@yahoo.com", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("b93acc14-0b28-402b-9cb4-6accad23377c"), null, null, "Dovie.Kris@hotmail.com", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("b9adef46-7644-4709-a1ba-2b92aeda9551"), null, null, "Claudine_Williamson@yahoo.com", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("b9f65796-58a1-409a-8c4d-a292db85a2d9"), null, null, "Rey.Gutkowski@gmail.com", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("ba232fc0-1725-49eb-84a1-2dcbaffe1cce"), null, null, "Claud67@gmail.com", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("ba277038-569b-4614-8d01-168a9ce36e80"), null, null, "Kennedi.Mosciski@hotmail.com", false, new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e") },
                    { new Guid("ba47389f-c3c3-4daa-a60c-6a5496029856"), null, null, "Cale35@gmail.com", false, new Guid("6224405d-f9d8-407b-9f81-847223041784") },
                    { new Guid("ba4cea01-9334-4400-af1d-ff651946d937"), null, null, "Simone_Grant@gmail.com", false, new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("baae6cc9-77fe-48a7-b33e-ea8557febbea"), null, null, "Omari_Rodriguez@hotmail.com", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("bb64f373-3455-4f37-a473-114137089367"), null, null, "Schuyler42@hotmail.com", false, new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104") },
                    { new Guid("bb673362-7ecd-46b8-b162-54d147067e4c"), null, null, "Jake_Willms33@yahoo.com", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("bbf7b3f5-cc50-4bb7-a303-a854040b6ee7"), null, null, "Maximus.Hills23@hotmail.com", false, new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("bc1f00a5-17a7-4f2b-a8cc-6f0b7f0a0d6b"), null, null, "Vella1@yahoo.com", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("bc98d3d6-ad3b-4e43-90a6-536384644749"), null, null, "Ezra47@yahoo.com", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("bcbfb6c2-6a59-4023-9e50-b9653d6beba4"), null, null, "Alexandria_Wuckert@hotmail.com", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("bd29ef7a-be2c-4438-aa8b-f2a0eb836452"), null, null, "Stephon_Heidenreich@gmail.com", false, new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962") },
                    { new Guid("bd72bba6-5e27-4079-a75c-ee938cfc7c77"), null, null, "Moshe_Altenwerth41@hotmail.com", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("bd81df21-0c22-4a82-bef0-f420a7c2b4b2"), null, null, "Ulices1@hotmail.com", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("bd9ddd5f-9920-426f-b012-d150ba1a6081"), null, null, "Barry.Beatty@hotmail.com", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("bdafbd5c-1f24-4d1c-ba7d-68425031dee8"), null, null, "Nicolas14@yahoo.com", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("bddd4741-e4fe-4860-b97e-3cb0e3190032"), null, null, "Macey_Johns@hotmail.com", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("bdfae8d6-5e02-4312-8c2f-3b9c41be209f"), null, null, "Torey.Dooley@hotmail.com", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("be02f9d6-dd37-4297-b566-f4a500e27a96"), null, null, "Billie81@hotmail.com", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("be0adbfc-2696-465b-a9e8-79debf6d8143"), null, null, "Esmeralda89@yahoo.com", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("be565b39-2ff6-4dad-b825-2a65d46c37ab"), null, null, "Art24@yahoo.com", false, new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("bf0545a9-bd36-4be7-a8fa-6ab7ba86da96"), null, null, "Alessandro_Lebsack37@hotmail.com", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("bf369063-1954-4d95-b754-3499aab325ff"), null, null, "Marietta_Hyatt@hotmail.com", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("bf97d6e7-dd2b-4a11-a3ae-02871d442bb0"), null, null, "Augusta.Strosin7@yahoo.com", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("c02fbf13-1f4e-4a38-b9a0-a31e1797f5fc"), null, null, "Rocky.Hudson@yahoo.com", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("c1792fa7-709e-4016-9437-16d96c283eab"), null, null, "Estel.Cummerata29@yahoo.com", false, new Guid("929221d7-8d45-4a44-b501-41a47c26cf44") },
                    { new Guid("c1b4f749-b437-456e-9adb-08931cc040ce"), null, null, "Eliseo55@hotmail.com", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("c2a123b9-74db-4a4b-87a8-7715a3c7af9a"), null, null, "Alverta_Beier@gmail.com", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("c2de4522-130e-4ac7-a74f-d0dc7ebe9f61"), null, null, "Mckayla50@hotmail.com", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("c2f4de0c-8415-4c64-84dc-1fa7ee0a171b"), null, null, "Mckayla48@hotmail.com", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("c301e75f-6730-4f50-81fc-92eec0bd51ce"), null, null, "Vilma91@hotmail.com", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("c32f968b-de79-446d-a3ac-2c0831d2c98c"), null, null, "Tommie.Waters@hotmail.com", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("c36ead45-fb5f-4102-b0f9-cadde7ec08ee"), null, null, "Oliver.Kutch@yahoo.com", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("c3883753-6071-4807-a89e-00e3c4345c87"), null, null, "Barbara.McClure@yahoo.com", false, new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e") },
                    { new Guid("c392eaf5-46f6-418b-a5d8-e60ba82a8419"), null, null, "Daron.Jerde@yahoo.com", false, new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d") },
                    { new Guid("c3bd63bf-d378-4824-a88d-cd1378d689c3"), null, null, "Lew_Ward@gmail.com", false, new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c") },
                    { new Guid("c3cd0402-a335-4925-a92e-94acfecf2903"), null, null, "Toby_Larson@yahoo.com", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("c3e3d71d-c466-4ca0-bb90-8b4053b3304e"), null, null, "Jane52@yahoo.com", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("c40a60a6-afc4-41f5-ae40-a2f2b869125d"), null, null, "Gladys75@hotmail.com", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("c434cbee-e22c-485f-855e-dc32dc5445b9"), null, null, "Sadie_Kunde@yahoo.com", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("c4699662-5149-4119-bd8b-aabc7bcc4b5b"), null, null, "Emily75@yahoo.com", false, new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1") },
                    { new Guid("c46c1144-506d-4c9c-b2eb-cd5cdf1e6357"), null, null, "Maxine.Kilback@hotmail.com", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("c4d248a4-42c2-4981-af9b-445a61737898"), null, null, "Pat.Nikolaus@hotmail.com", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("c5170afc-fa23-43c9-bd1b-8bb55b115606"), null, null, "Wiley_McLaughlin@hotmail.com", false, new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2") },
                    { new Guid("c51c1252-7569-4823-97a4-63b0c3f774c3"), null, null, "Gaston_Willms61@gmail.com", false, new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b") },
                    { new Guid("c5440e8f-93c1-478c-9188-77827a609f55"), null, null, "Oswald99@gmail.com", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("c58b91d2-5b89-4936-bf01-031835b127b2"), null, null, "Pietro.Hand26@hotmail.com", false, new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("c646ef5a-3eb0-4238-8c20-221bfa8e42d2"), null, null, "Casandra37@yahoo.com", false, new Guid("8a966506-353d-46f9-91b9-9431f8562c71") },
                    { new Guid("c64e06bb-f600-499a-b7cc-14fa81e4e1b0"), null, null, "Rico66@yahoo.com", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("c673da7c-a257-4d33-a286-205d0fe61595"), null, null, "Derick.Renner89@gmail.com", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("c6d06e1d-65ea-4f2a-a766-42b5850a3b30"), null, null, "Ellis_Abbott@gmail.com", false, new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3") },
                    { new Guid("c6f2ba35-3512-4a91-9c22-f69822700881"), null, null, "Antonietta13@yahoo.com", false, new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d") },
                    { new Guid("c71c4c37-d30b-4307-8cb5-8bcb4c99845e"), null, null, "Titus.Corkery@gmail.com", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("c7bb4556-f6e7-4ea4-bab6-e69a25ce815c"), null, null, "Onie.Jaskolski@gmail.com", false, new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502") },
                    { new Guid("c7c300b8-918c-4dbd-9746-6e790b2f2d85"), null, null, "Cathrine_Hilll18@yahoo.com", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("c87309c4-6bde-4b1c-b097-d82ab3af4e36"), null, null, "Arden.Turner85@hotmail.com", false, new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77") },
                    { new Guid("c8df3889-a891-4f0d-b8f8-732dd9670e69"), null, null, "Tia_Miller17@hotmail.com", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("c90c4fc6-393f-4556-af9c-d6de79fd9b0d"), null, null, "Junior_Aufderhar79@yahoo.com", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("c9224e8f-3048-47a5-9d3d-6040a48bb68d"), null, null, "Darrell30@yahoo.com", false, new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c") },
                    { new Guid("c961d5cd-d3c5-408b-8c65-5e73667fd51d"), null, null, "Ludie_Toy69@yahoo.com", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("ca13b7fd-7424-4ca4-992f-976483eb2171"), null, null, "Tyson_Kuphal@gmail.com", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("ca442e26-4fc3-4ee4-9399-70bdef583feb"), null, null, "Kitty80@yahoo.com", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("caaebf90-1bcf-412e-bc38-247f79fcc029"), null, null, "Henriette70@gmail.com", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("cb17e97c-7208-49de-ba74-cb9e0c809647"), null, null, "Jacquelyn61@yahoo.com", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("cb24f874-2138-4c01-bf63-d380d8cb561f"), null, null, "Nicola22@gmail.com", false, new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7") },
                    { new Guid("cd35cb92-945f-4a3d-be3a-dcafbefa4cb7"), null, null, "Tyrese_Dach93@hotmail.com", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("cd529075-2df1-480e-8e11-5e3fb837f0ad"), null, null, "Emmanuel_Little14@hotmail.com", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("cd8f1db8-223c-4223-a589-22ad79d6d791"), null, null, "Naomie11@hotmail.com", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("ce3697be-22a2-431c-97f6-f8b8e45ac6c9"), null, null, "Veda.Pfeffer0@yahoo.com", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("ce85898a-fd49-47c6-9408-8b869816ac9a"), null, null, "Geoffrey_Dooley@hotmail.com", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("cea6cabf-9c8b-4f3f-abe7-4b9d4309d412"), null, null, "Lafayette_Heidenreich17@yahoo.com", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("cf547d8c-4474-459b-b0b1-28ade84a2135"), null, null, "Lupe_Weissnat@hotmail.com", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("cf6066aa-bdcf-4a9c-962e-a7e6700d5d83"), null, null, "Amara.Jacobi@hotmail.com", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("cf710270-d16b-4dfc-ba7b-193de3f600c5"), null, null, "Anabelle94@yahoo.com", false, new Guid("671bbcc1-9768-4630-8a24-d7626303ad52") },
                    { new Guid("cf80fbda-346d-4234-8a9a-d104f4da9ddb"), null, null, "Shane.Lesch@hotmail.com", false, new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3") },
                    { new Guid("cfb1bb41-73a2-48e9-824f-2ba6e65ef2e4"), null, null, "Donnell83@gmail.com", false, new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10") },
                    { new Guid("d09bf422-aef6-499d-a4be-4b625454fc1e"), null, null, "Alexie.Padberg@yahoo.com", false, new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0") },
                    { new Guid("d0cd6f31-e957-4a57-bcf4-0a95abb81872"), null, null, "Adolfo88@hotmail.com", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("d100cde7-f3f7-4bc3-a397-bb77485a5e3f"), null, null, "Keshawn.Fisher@gmail.com", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("d1766390-ddbd-4410-892c-9569bd8076c7"), null, null, "Vivien_Ankunding@hotmail.com", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("d2207bb7-7003-4683-9534-cad5f05b70e1"), null, null, "Edd65@gmail.com", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("d22ecfe7-e1f9-45eb-9b37-baf2908d6452"), null, null, "Peggie.Simonis@gmail.com", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("d2582d60-b7b6-4e90-a6e0-92f55637c526"), null, null, "Lafayette9@gmail.com", false, new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51") },
                    { new Guid("d25cd5f7-bf39-497a-8aef-2efd04e02801"), null, null, "Annabelle_Bosco@hotmail.com", false, new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528") },
                    { new Guid("d31082af-8673-4c08-9166-b0ee62ea5a61"), null, null, "Lavonne_Leuschke@yahoo.com", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("d391570d-8b4d-4039-a5cb-27014459b87d"), null, null, "Frieda.Kohler@yahoo.com", false, new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d") },
                    { new Guid("d4415910-3255-40b9-8a96-2a7cd8c51a13"), null, null, "Don.Sauer@gmail.com", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("d4ad7abd-5448-4ef3-a9fe-c686364adaed"), null, null, "Christophe41@gmail.com", false, new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a") },
                    { new Guid("d4b8605b-d228-4c20-a045-260563781f32"), null, null, "Lizzie50@yahoo.com", false, new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac") },
                    { new Guid("d50fbbc3-883d-4bab-b0db-66d15d5dcc0c"), null, null, "Juliet30@hotmail.com", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("d59ae1ce-03ef-450c-8f4b-704fc399cb41"), null, null, "Brett.Moore@yahoo.com", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("d5c0735f-8e7e-4ebb-a464-4b2f381eb1da"), null, null, "Elda47@gmail.com", false, new Guid("d364b716-4b5c-4090-99d6-0f11b5849701") },
                    { new Guid("d5d27f99-6a29-4b4e-b841-74c31a61f9fd"), null, null, "Elmira_Olson3@yahoo.com", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("d5db4d66-7782-4ca9-9b05-182122e671ae"), null, null, "Katelynn.Spencer@gmail.com", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("d6219c6d-6682-4239-a824-e6e2927974a7"), null, null, "Jessica.Shanahan@gmail.com", false, new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("d67a97b0-d9dd-43e9-84f3-d99ed6fac480"), null, null, "Caitlyn.Schulist6@yahoo.com", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("d695efc4-5be8-46d8-8cb7-aa8fc8feebed"), null, null, "Destin.Marvin@gmail.com", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("d74d33b3-52f8-4bc4-93be-45d966d8c0fb"), null, null, "Alize_Gorczany@hotmail.com", false, new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f") },
                    { new Guid("d7cd58be-5405-496a-b9f5-7275934c4891"), null, null, "Estrella_Armstrong7@hotmail.com", false, new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1") },
                    { new Guid("d7ceee8e-b22a-4b9b-ade2-600f21fddaa8"), null, null, "Amalia79@hotmail.com", false, new Guid("302771bc-d672-48ae-9a96-c489ccacf75a") },
                    { new Guid("d7ea503a-b664-4c0f-8d2a-e54a8cd9e2fd"), null, null, "Tomas_MacGyver91@gmail.com", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("d826e8ab-2de9-4757-9e02-f33e988da54b"), null, null, "Katarina.Harris@gmail.com", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("d82a2bee-790a-461e-ace1-df2717a3ed79"), null, null, "Alessandra.Durgan75@yahoo.com", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("d90e3a9d-12f7-4684-ad8a-afe92ee99eb1"), null, null, "Shanie.Hudson67@hotmail.com", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("d93bd8f8-f528-4e49-9435-724c7a5c0528"), null, null, "Lessie.Ondricka@hotmail.com", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d996b129-55b2-4d5b-ab09-9769b539bbd8"), null, null, "Francesco42@yahoo.com", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("da58885f-1ac6-4408-afe4-a1facf90dfc7"), null, null, "Leopoldo_Graham66@yahoo.com", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("daa63a76-a220-497d-a105-528f4e04185b"), null, null, "Meta74@yahoo.com", false, new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84") },
                    { new Guid("daa8a34b-7665-493a-a6f4-fd944ec932e7"), null, null, "Augustus.Aufderhar59@yahoo.com", false, new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e") },
                    { new Guid("daadb62c-52a5-4924-a9a6-9f04e0994c7e"), null, null, "Marcella.Shields60@yahoo.com", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("daae645e-9364-42cc-8f1c-b25a58cda5eb"), null, null, "Marielle27@hotmail.com", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("dabfd8d2-8a90-41c7-b009-17ad5d6dcbd4"), null, null, "Eliseo.Herzog63@hotmail.com", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("db68a3bd-165d-4ed2-bbb4-5816255e9606"), null, null, "Sienna_Barrows3@hotmail.com", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("dc440e6d-fb73-4460-8a5e-bba44c0be884"), null, null, "Taylor.Cummerata67@yahoo.com", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("dd72e99a-46c7-4a09-8a9e-6716fede673d"), null, null, "Jody31@hotmail.com", false, new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df") },
                    { new Guid("dda008f1-ce71-48b3-bc88-711aa01b7df5"), null, null, "Marlen_Koepp94@hotmail.com", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("ddb68808-fcb6-4dd9-9c25-64175457bb55"), null, null, "Wilfred_Greenfelder44@gmail.com", false, new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711") },
                    { new Guid("ddd5916c-4f24-4547-a347-88b84d389011"), null, null, "Justine.Grady@hotmail.com", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("de0d2dd2-caed-459e-a8bf-b56241c0f8f7"), null, null, "Dessie.Wiegand@hotmail.com", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("de0d65d4-4cd5-4761-b56a-dd78864dcb42"), null, null, "Rosa.Tromp@gmail.com", false, new Guid("812d963b-edbc-48b1-948d-661ea6f9d645") },
                    { new Guid("de108fe2-9f22-486c-9ec9-e4b3c15ae6bb"), null, null, "Webster45@hotmail.com", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("de22315c-3b65-4cc1-9b49-f6dee20c4fe5"), null, null, "Maximillian_Rolfson@yahoo.com", false, new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("deeb3df7-24e2-43c5-8c64-15f05bbf4559"), null, null, "Pascale.Ledner95@yahoo.com", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("def89de5-036f-48ad-bbac-7ed43d45bfb2"), null, null, "Ernestina_Stracke@gmail.com", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("df0aa871-60d8-4b43-88ee-f4507fe7be17"), null, null, "Sigurd_Legros65@yahoo.com", false, new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e") },
                    { new Guid("df5fdd67-a888-417c-bcf1-0a6f8323fce0"), null, null, "Felicity_Hackett@hotmail.com", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("df91e3f7-90bf-4bef-b9c0-33c6adea972e"), null, null, "Sabryna_Padberg@hotmail.com", false, new Guid("66bde12e-086d-4150-9c7a-89ea75047f12") },
                    { new Guid("dfeac6df-02e2-44f6-b091-731bb19c35b3"), null, null, "Mittie_Jaskolski@hotmail.com", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("e0c0f85e-6728-4f97-856d-c654222de87f"), null, null, "Joyce_Wisozk@gmail.com", false, new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce") },
                    { new Guid("e1a80643-307c-4b1d-8557-20ad7827b116"), null, null, "Laurel92@hotmail.com", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("e1df016b-539f-47e7-ad8f-7a497a677fca"), null, null, "Chanelle4@gmail.com", false, new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546") },
                    { new Guid("e22e9b1b-f2dc-42cd-9d6d-da972afc5873"), null, null, "Osvaldo_Schinner86@gmail.com", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("e263a6c3-9960-4945-90b3-ffff9293f28d"), null, null, "Breana_Rogahn2@yahoo.com", false, new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623") },
                    { new Guid("e26adfad-84e0-4646-8956-19c48b561350"), null, null, "Sofia_Braun@hotmail.com", false, new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d") },
                    { new Guid("e270d9d3-9111-4a0e-86ae-4492f6d7db0a"), null, null, "Johan_Boehm48@yahoo.com", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("e2beef9f-1346-44ec-a8bd-aebc338b10a2"), null, null, "Nakia28@gmail.com", false, new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d") },
                    { new Guid("e303f721-987c-4cb8-a88e-e19e512538ed"), null, null, "Alexane_Heller@hotmail.com", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("e39de8fc-0a64-41ff-862b-99987a2bb2e7"), null, null, "Delphia24@hotmail.com", false, new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") },
                    { new Guid("e3b1b521-1ccf-46c5-a222-5adc9f58892b"), null, null, "Leanna.Heathcote18@hotmail.com", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("e3d21ee5-6e09-45e4-8585-9cf601e12441"), null, null, "Natasha.Robel@gmail.com", false, new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a") },
                    { new Guid("e40e100b-48ad-4ba8-bde5-42ba77c39564"), null, null, "Amely_OConner@gmail.com", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("e414687c-157c-4f4b-9b58-650435313513"), null, null, "Vesta76@gmail.com", false, new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0") },
                    { new Guid("e446b9c5-8aa7-415a-b00a-a55dc37cfa46"), null, null, "Jaylan.Crona@gmail.com", false, new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de") },
                    { new Guid("e50373dc-97dc-4fb6-9073-169b2237080b"), null, null, "Adalberto.Sawayn@hotmail.com", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("e52bc773-fcfe-4619-bb4f-6266b9886a53"), null, null, "Horacio.Witting1@yahoo.com", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("e54e4ad8-59fb-4cc6-b66b-1c461d4253da"), null, null, "Tomasa_Schaden@yahoo.com", false, new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3") },
                    { new Guid("e587c42c-43fc-4046-8c10-63314d5020bf"), null, null, "Toy83@yahoo.com", false, new Guid("6c7090cd-7244-4437-b460-88c7027c78f9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e5c04d8a-8b36-4e14-a1c7-802c885ae680"), null, null, "Justina69@gmail.com", false, new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("e5f9f8ce-53ec-4b51-9239-4e5279fa404f"), null, null, "Donna51@gmail.com", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("e61c00fa-344b-4c54-9ff4-167ec6c1408b"), null, null, "Keara_Buckridge@gmail.com", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("e6a4d6c4-7402-48aa-818b-a806e4a1d791"), null, null, "Lue_Jast@hotmail.com", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("e6b3ee49-6b4e-47dc-9be6-557d6a2182d7"), null, null, "Ansley.Waters@yahoo.com", false, new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0") },
                    { new Guid("e6fc33eb-1417-4b2a-96c6-c106d5d5d9fd"), null, null, "Keven_Rowe31@gmail.com", false, new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("e7110a4c-5d9c-420d-be0b-f69c3a122510"), null, null, "Delilah_Yundt80@hotmail.com", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("e7b4aece-f292-4b6d-8221-b418689f2fc9"), null, null, "Marilie_Schimmel@gmail.com", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("e7c92121-068d-4bab-8e69-03d059b2c030"), null, null, "Freddie.Corwin@yahoo.com", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("e7e7fb88-20e9-4fde-8361-775c771a043c"), null, null, "Janick_Wolff@hotmail.com", false, new Guid("7156fae1-f350-4998-b43f-3d5664953dc8") },
                    { new Guid("e855045a-74bc-40d1-af35-104263657ad8"), null, null, "Joanne.Herzog31@yahoo.com", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("e919772b-31b8-45f9-be80-d4025d3dc275"), null, null, "Deshaun_Lowe86@gmail.com", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("e9363652-c6ef-4cc3-960f-702606a6f8d6"), null, null, "Jeffry62@yahoo.com", false, new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd") },
                    { new Guid("e94461c0-596c-4f95-b129-7f21546fe6a7"), null, null, "Hobart.Boehm@yahoo.com", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("e984d07a-4193-4eb9-a6b0-cda882ad7027"), null, null, "Carey.OReilly67@gmail.com", false, new Guid("8a966506-353d-46f9-91b9-9431f8562c71") },
                    { new Guid("e98992be-2ea7-48d4-9f5b-8dbdf8edd934"), null, null, "Ruthie_Sporer@hotmail.com", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("e99e678b-331a-45f4-84fa-d0ef1a9bc379"), null, null, "Isidro.Goldner7@gmail.com", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("ea03f558-bd12-4a1c-9d40-7dc7149641ce"), null, null, "Jaren66@gmail.com", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("ea045a1b-34a3-473f-9661-b2ed0fb9aa27"), null, null, "Hassie3@yahoo.com", false, new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e") },
                    { new Guid("eace0c24-7efd-452b-a892-12bcf26bb9e1"), null, null, "Archibald57@hotmail.com", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("eafbfb1d-4ff0-4b54-999a-24bbd7e52220"), null, null, "Vivian_Raynor@hotmail.com", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("eb1d58ff-46db-46e9-9481-91f68b359be3"), null, null, "Ila_Dibbert71@gmail.com", false, new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("eb3d4377-7760-45a3-82f6-dd62dd578213"), null, null, "Emile_Oberbrunner85@yahoo.com", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("eb46da96-0d6a-418a-85e3-3989d1f9f919"), null, null, "Neal_Hammes47@yahoo.com", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("ebf163bb-00f1-45fe-9273-e8d68d9a1ec9"), null, null, "Maud.Wisoky@yahoo.com", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("ec031cfc-c69f-4332-ba28-490700cd6213"), null, null, "Krista.Johnson58@hotmail.com", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("ec780866-8342-4d77-afff-37933a303759"), null, null, "Adriana.Gottlieb76@yahoo.com", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("ecb4bf8f-88dd-44f6-9e40-8b725b99cb1a"), null, null, "Calista62@yahoo.com", false, new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94") },
                    { new Guid("ed2c9410-2e9f-4de0-98dd-6a6986dafcb8"), null, null, "Ward76@yahoo.com", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("ed57ad62-30d2-46ca-9f42-06dec61f7810"), null, null, "Bernita.Barton@hotmail.com", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("ed745797-51cb-4591-92f7-a5019e460ee4"), null, null, "Zita.Streich@hotmail.com", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("eda88998-c837-4c15-a762-49d107d9772a"), null, null, "Dane_Rutherford@yahoo.com", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("edd6e950-8234-4d74-8d62-5244c18b7d1f"), null, null, "Chance33@gmail.com", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("ee3babcd-2bde-4372-9237-761810affa68"), null, null, "Una14@yahoo.com", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("ee46a606-c6dd-4e57-979f-77a36a300cef"), null, null, "Adele52@yahoo.com", false, new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11") },
                    { new Guid("f0adc8eb-daa9-41c4-88f9-4b4ccc56d35c"), null, null, "Mason_Abbott81@yahoo.com", false, new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1") },
                    { new Guid("f0c790bc-bdd3-425e-9747-d7674dec5659"), null, null, "Kade_Purdy49@gmail.com", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("f14dd331-f6e3-42e9-9894-12546fe1e537"), null, null, "Clint49@yahoo.com", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("f167b76b-deb9-4c75-b9b4-162f1ef38d2f"), null, null, "Tanner.Kuhn@hotmail.com", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("f16d6bfb-03af-4c64-b250-e51cd564bc12"), null, null, "Reynold.Gleichner@yahoo.com", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("f1b8c90a-0898-4379-9993-504fc4251375"), null, null, "Ila.McCullough@yahoo.com", false, new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("f1e07eb0-a2a0-4cce-9d41-2ace3e8e2e57"), null, null, "Reggie.Daniel20@yahoo.com", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f1e1b0e1-61d8-4bf7-9d73-eec6004588b8"), null, null, "Rebeka79@hotmail.com", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("f22faf00-487a-40a2-a5ef-5607d6c87efb"), null, null, "Anita63@yahoo.com", false, new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0") },
                    { new Guid("f2711dba-fdcc-4332-8f8b-e90f0ebdc509"), null, null, "Amiya_Jerde69@hotmail.com", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("f2778ce3-5c4c-48fa-94a9-13b7448f6b15"), null, null, "Grady78@yahoo.com", false, new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("f3b774c9-e97a-4684-b512-77d4c83f31cf"), null, null, "Liam_Walsh@hotmail.com", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("f3ba561e-8e00-4e04-bc77-aeb519560430"), null, null, "Velma.Little39@yahoo.com", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("f3fba48c-b038-4b9d-b1ab-f243c5ae8225"), null, null, "Madison25@gmail.com", false, new Guid("e57373e2-48de-4c55-9c02-9b87c7751318") },
                    { new Guid("f4362834-1ddd-48e3-9660-ac3e2aa53571"), null, null, "Lamar.Johns63@yahoo.com", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("f5bbc354-0370-486c-9564-653baa467748"), null, null, "Camille95@hotmail.com", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("f5fb210f-bf64-45fe-92b6-875332d7d241"), null, null, "Lula82@hotmail.com", false, new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0") },
                    { new Guid("f6262c3a-86b7-4b7f-a843-aa1a38992158"), null, null, "Johnson9@hotmail.com", false, new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad") },
                    { new Guid("f6342b7b-6369-4438-bdd0-f5175c288ea6"), null, null, "Danial_Hane@hotmail.com", false, new Guid("a0863958-35de-49a9-a73b-decb03e0c871") },
                    { new Guid("f640cb4f-402e-4f29-b94f-5546e2892d71"), null, null, "Dannie47@yahoo.com", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("f643dc46-0b85-4d04-96ba-5983ea261aef"), null, null, "Roger_Zieme@gmail.com", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("f66b8325-f343-46a5-a7da-40709f967cc4"), null, null, "Dorothy12@gmail.com", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("f67bcb02-8316-4979-8afd-4286b98b2f67"), null, null, "Davonte51@hotmail.com", false, new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52") },
                    { new Guid("f70b19b8-d658-4f52-8db9-13dcdc7310e9"), null, null, "Berniece8@yahoo.com", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("f745e77f-0a2d-4536-86f2-483239fd1625"), null, null, "Murl.Christiansen74@hotmail.com", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("f7b97f91-a641-457f-accd-a0056fe34c1f"), null, null, "Megane.Hintz75@yahoo.com", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("f81a05e7-bd64-46c2-b1cf-3d9cc6182032"), null, null, "Fleta.Lowe75@hotmail.com", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("f86bff32-79a5-42ac-a962-59c0d2fdaa54"), null, null, "Larissa91@yahoo.com", false, new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0") },
                    { new Guid("f95ec144-82c2-4b65-8676-03fe6968e3b4"), null, null, "Demetrius_Cummerata21@hotmail.com", false, new Guid("63684041-907c-4654-ab87-5f0c11008f52") },
                    { new Guid("f97cac66-6864-4916-9f1d-9228e5f73826"), null, null, "Ophelia65@yahoo.com", false, new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce") },
                    { new Guid("fa02c5ae-3ae2-478c-af16-9ace8f68274a"), null, null, "Kaylie.Hayes97@yahoo.com", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("fa431b16-ba82-4541-9b17-f5ad8515d138"), null, null, "Dagmar5@gmail.com", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("fae56699-46f4-45e4-86e4-27e6834a6ad9"), null, null, "Lemuel_Schumm74@gmail.com", false, new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77") },
                    { new Guid("fb0991e8-6b22-4a79-acdd-4d6049209f9b"), null, null, "Amos18@yahoo.com", false, new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104") },
                    { new Guid("fb1ab099-48d2-4c0a-a2d5-1d6e3ec0e365"), null, null, "Kianna.Lakin98@hotmail.com", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("fb79f070-aa8e-487b-9c59-37148e0e3430"), null, null, "Hailey34@gmail.com", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("fbf00038-c9cd-4aec-b73e-e92b22cf1354"), null, null, "Deven.Upton@hotmail.com", false, new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7") },
                    { new Guid("fbf4aaf8-631f-4796-9ef0-58302a941793"), null, null, "Violet.Friesen@hotmail.com", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("fc57eedc-da77-469f-a4f9-2929c96ca72c"), null, null, "Erica_Leuschke@yahoo.com", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("fcd7698c-bdfa-41b4-bf14-80dfc6176a23"), null, null, "Edmond_Ryan@gmail.com", false, new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618") },
                    { new Guid("fd053622-ed18-4556-8d4d-9f20d1f5da84"), null, null, "Kayley.Hane2@hotmail.com", false, new Guid("812d963b-edbc-48b1-948d-661ea6f9d645") },
                    { new Guid("fd207ad6-1640-44e1-9863-56b5d55889a8"), null, null, "Thurman72@yahoo.com", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("fda0460c-3108-4283-9711-66f46d443371"), null, null, "Brook_Hahn@yahoo.com", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("fe7866ca-7532-47a3-804c-dbe4636b99b6"), null, null, "Leora99@hotmail.com", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("fec24425-098f-41e5-b274-13b77049fea3"), null, null, "Penelope.Mitchell@gmail.com", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("feeb755d-48af-4b81-889a-5263de1f6179"), null, null, "Janiya6@yahoo.com", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("ff8ae533-3ffc-41a8-afdc-7e291683e33f"), null, null, "Lindsey_Nader@hotmail.com", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("ffae1d0a-ae3f-4c52-919d-a13aa50fb8bc"), null, null, "Chelsea.Huels@hotmail.com", false, new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f") },
                    { new Guid("ffd701c4-8aef-42c3-8532-075699b1a06a"), null, null, "Antwon_Kertzmann46@hotmail.com", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[] { new Guid("ffe837cd-ec83-4c0e-a50f-aee4a102f76d"), null, null, "Domenick_Glover79@yahoo.com", false, new Guid("45dee853-0743-493d-b80b-c81b944cc529") });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("009f81d8-a500-4d26-b144-1ae0e96f9916"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 25, 10, 41, 26, 290, DateTimeKind.Local).AddTicks(9159), new DateTime(2023, 7, 31, 10, 41, 26, 290, DateTimeKind.Local).AddTicks(9159), null, 77.69m, 2770259918853742m, "Standart", 2, 39.456604f, "4813 Efrain Lodge, Lake Josiahshire, Singapore", new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1"), "02128 Blanda Mews, Port Naomie, Cambodia", new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("01b97f2a-32b0-462e-8573-d9f8aae4b156"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 20, 16, 26, 47, 247, DateTimeKind.Local).AddTicks(8036), new DateTime(2024, 3, 30, 16, 26, 47, 247, DateTimeKind.Local).AddTicks(8036), null, 92.67m, true, 8495408075252066m, "Courier", 1, 24.34255f, "16329 Raynor Ramp, East Americostad, Taiwan", new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1"), "03481 Schimmel Creek, Considinefort, Sri Lanka", new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("052687fe-8b2f-4833-a6ed-9207d27f8068"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 16, 11, 55, 31, 657, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 1, 25, 11, 55, 31, 657, DateTimeKind.Local).AddTicks(6792), null, 80.10m, 1680861770727091m, "Special", 1, 24.583925f, "353 Goyette Trail, Lake Wendelltown, Andorra", new Guid("ae750269-835b-481a-8e36-4dd8044f9527"), "78803 Travon Prairie, Ciaraberg, Kyrgyz Republic", new Guid("e57373e2-48de-4c55-9c02-9b87c7751318"), "OnTheWay", "CardboardBox" },
                    { new Guid("0764c376-7598-488b-9214-22d8a29ff9d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 25, 20, 35, 47, 144, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 7, 26, 20, 35, 47, 144, DateTimeKind.Local).AddTicks(7737), null, 60.56m, 1697332585804266m, "Special", 1, 3.2492466f, "5836 Uriah Heights, Port Altheabury, Poland", new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177"), "6553 Mekhi Course, Predovicport, Benin", new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("08c069a2-2dbb-456f-9890-75302ae259aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 2, 31, 13, 291, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 11, 12, 2, 31, 13, 291, DateTimeKind.Local).AddTicks(8357), null, 38.02m, 9923966377745334m, true, "Special", 1, 41.759808f, "78275 Enrico Parkways, Mitchellberg, Equatorial Guinea", new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651"), "945 Connelly Land, East Milton, Philippines", new Guid("0fc27c31-ca71-419a-8df7-391205e73c05"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("08d7d994-865d-45e0-ad03-655c2b2e3680"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 20, 8, 44, 15, 848, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 12, 22, 8, 44, 15, 848, DateTimeKind.Local).AddTicks(4603), null, 25.96m, true, 8179327911471171m, true, "Courier", 1, 44.301468f, "823 Hauck Plain, South Verda, Zimbabwe", new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240"), "149 Zaria Trafficway, Westontown, Bahrain", new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("08ef1bd3-4207-4dbb-97af-edc189511773"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 5, 13, 52, 39, 938, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 6, 13, 13, 52, 39, 938, DateTimeKind.Local).AddTicks(155), null, 20.53m, 3604254550385235m, "Standart", 5, 33.571354f, "18183 Alexandrea Junctions, Willburgh, Tajikistan", new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535"), "071 Muller Cliffs, Lake Myles, Mali", new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("08fc76e2-1722-4e65-9046-945feadf5c82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 23, 5, 3, 31, 4, DateTimeKind.Local).AddTicks(3160), new DateTime(2024, 3, 24, 5, 3, 31, 4, DateTimeKind.Local).AddTicks(3160), null, 85.26m, true, 4976800167508274m, true, "Standart", 1, 42.408752f, "25594 Champlin Wall, East Constanceton, Tonga", new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "95886 Travis Views, Millershire, Cyprus", new Guid("9428c7a5-a397-4b16-aff4-15dc05248196"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0cbcfcd8-42f7-4541-b84d-f0a3dd26ffaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 6, 19, 24, 9, 880, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 1, 12, 19, 24, 9, 880, DateTimeKind.Local).AddTicks(4786), null, 40.85m, 5229093496329522m, true, "ParcelMachine", 4, 47.36089f, "54087 Arlie Gardens, North Micah, Qatar", new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9"), "559 Amos Tunnel, Danielchester, Mauritania", new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("0f2e7f39-9bf4-48e5-af22-ed6defd98415"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 13, 1, 10, 13, 508, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 4, 16, 1, 10, 13, 508, DateTimeKind.Local).AddTicks(2293), null, 64.61m, true, 4712206347098575m, "Courier", 1, 13.297059f, "388 Willms Islands, Trudieview, Antigua and Barbuda", new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "08653 Altenwerth Circle, Simonisville, Palau", new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6"), "OnTheWay", "CardboardBox" },
                    { new Guid("0f4d15a0-7bf3-4e9d-9c56-0b9bf38b413a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 15, 5, 52, 51, 717, DateTimeKind.Local).AddTicks(3368), new DateTime(2024, 4, 19, 5, 52, 51, 717, DateTimeKind.Local).AddTicks(3368), null, 25.58m, true, 8077102873076528m, "ParcelMachine", 3, 38.510666f, "47750 Bosco Ford, Schadenville, Malaysia", new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14"), "544 Altenwerth Brooks, Evaside, Austria", new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1b8d94ba-8798-45bf-a727-7a43a7565efc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 22, 17, 43, 15, 157, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 9, 25, 17, 43, 15, 157, DateTimeKind.Local).AddTicks(9577), null, 10.05m, 2331703727801137m, "Special", 3, 39.09746f, "0505 Amelia Villages, South Neldaberg, Philippines", new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19"), "1545 Reichel Passage, North Christyberg, France", new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1bf8cbe3-602f-4fc9-a81a-b015f95be8c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 3, 2, 6, 11, 266, DateTimeKind.Local).AddTicks(565), new DateTime(2024, 2, 6, 2, 6, 11, 266, DateTimeKind.Local).AddTicks(565), null, 27.65m, true, 9188869935562052m, true, "Courier", 4, 19.292873f, "954 Duane Tunnel, Ianview, Micronesia", new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af"), "7217 Stehr Valleys, Port Antonina, Norfolk Island", new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("204cf30d-211d-4e37-b900-7c1a2ac05eb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 13, 0, 40, 49, 702, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 8, 19, 0, 40, 49, 702, DateTimeKind.Local).AddTicks(8639), null, 31.56m, true, 1775550821182148m, "Courier", 4, 35.766186f, "120 Botsford Coves, West Kristianstad, Cayman Islands", new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b"), "024 Keyon Ranch, Lake Myriamview, Uganda", new Guid("1144670b-de30-428e-9356-066b18301c96"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("216bc990-baef-4e4e-850c-9165c3baab43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 25, 4, 16, 42, 416, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 6, 26, 4, 16, 42, 416, DateTimeKind.Local).AddTicks(4163), null, 54.56m, true, 5591353310588444m, true, "ParcelMachine", 3, 10.271362f, "6233 Amara Forges, Benedictfurt, Uzbekistan", new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc"), "9638 Merl Crossroad, Karianeland, Canada", new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6"), "Registered", "CardboardBox" },
                    { new Guid("21b1d8fe-19e2-48f4-b9f0-83a93e3bf6f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 23, 0, 12, 9, 878, DateTimeKind.Local).AddTicks(8601), new DateTime(2023, 12, 24, 0, 12, 9, 878, DateTimeKind.Local).AddTicks(8601), null, 53.57m, true, 2492083897483490m, true, "Special", 2, 24.943287f, "00681 Manley Highway, Destanyland, American Samoa", new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919"), "31247 Strosin Island, Walkermouth, Haiti", new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("235c7e36-6ff9-4063-8d5f-504c946a88a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 11, 3, 10, 3, 630, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 1, 13, 3, 10, 3, 630, DateTimeKind.Local).AddTicks(895), null, 95.74m, true, 7397077194550686m, "Special", 2, 28.699543f, "007 Weber Rapids, Tyreekton, French Polynesia", new Guid("7156fae1-f350-4998-b43f-3d5664953dc8"), "49020 Aurore Harbor, Maymiestad, Jersey", new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be"), "Registered", "PlasticBag" },
                    { new Guid("243acb9b-58e6-4726-80ab-d8db1a7e66be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 8, 17, 1, 56, 797, DateTimeKind.Local).AddTicks(6738), new DateTime(2023, 12, 9, 17, 1, 56, 797, DateTimeKind.Local).AddTicks(6738), null, 18.10m, true, 7506499747322484m, "Special", 3, 1.8329633f, "9401 Keebler Center, East Pollymouth, Bermuda", new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1"), "548 Metz Point, Fayville, Republic of Korea", new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("271f0008-9b32-43a7-a4f9-f390436f6543"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 7, 0, 51, 38, 913, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 6, 13, 0, 51, 38, 913, DateTimeKind.Local).AddTicks(2312), null, 52.39m, 8375490031131482m, true, "Special", 4, 41.479774f, "602 Amira Terrace, Dickiland, El Salvador", new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7"), "903 Amaya Highway, Tyriquestad, Eritrea", new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("28265cfa-968f-4c3c-a40e-0a73b24205ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 25, 10, 34, 55, 521, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 3, 6, 10, 34, 55, 521, DateTimeKind.Local).AddTicks(6783), null, 54.97m, true, 6480779057415366m, true, "ParcelMachine", 3, 12.529427f, "57954 Fred Key, Olsonview, Niue", new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36"), "5796 Cody Trail, North Elodymouth, Liechtenstein", new Guid("a0863958-35de-49a9-a73b-decb03e0c871"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("288fa2b4-d296-402c-a190-80a112f8f75e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 18, 20, 17, 10, 168, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 1, 27, 20, 17, 10, 168, DateTimeKind.Local).AddTicks(9298), null, 81.12m, 5686529468518844m, "Courier", 4, 21.317554f, "9798 Schulist Mission, New Autumnstad, Wallis and Futuna", new Guid("6c7090cd-7244-4437-b460-88c7027c78f9"), "0141 Joey Hills, Huelsfort, Martinique", new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2c5679d8-dde5-4fcc-9fb5-59b3240ca370"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 19, 3, 36, 41, 506, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 4, 24, 3, 36, 41, 506, DateTimeKind.Local).AddTicks(525), null, 82.74m, 4711716592436004m, true, "Special", 1, 42.12389f, "2563 Dejah Route, West Casimirbury, Saint Pierre and Miquelon", new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), "538 Schaden Neck, Lake Shyann, Sri Lanka", new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2caeebe5-55db-422e-9311-e4bcb08cf122"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 20, 49, 15, 278, DateTimeKind.Local).AddTicks(4892), new DateTime(2024, 2, 29, 20, 49, 15, 278, DateTimeKind.Local).AddTicks(4892), null, 68.26m, true, 6983477323724558m, true, "Super", 4, 18.542248f, "08071 Jada Park, South Lilafurt, Cameroon", new Guid("24597285-23ce-4296-9004-36d913270ed6"), "87233 Micaela Estates, Binsville, Jamaica", new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2cc8a366-bd09-4388-bee5-cfd1e2026a03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 29, 22, 28, 22, 679, DateTimeKind.Local).AddTicks(1500), new DateTime(2023, 8, 7, 22, 28, 22, 679, DateTimeKind.Local).AddTicks(1500), null, 67.07m, true, 9965974824859484m, "ParcelMachine", 1, 41.978317f, "49044 Mathias Crossroad, South Juanitastad, Uganda", new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc"), "5198 Reuben Circles, Rubyton, Swaziland", new Guid("13d00315-a856-463e-abb8-2a7dd165ded7"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2d93aedc-f710-451f-8bf1-2174bedece7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 12, 8, 20, 58, 948, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 8, 22, 8, 20, 58, 948, DateTimeKind.Local).AddTicks(6234), null, 13.31m, 2858756395157370m, "Super", 5, 20.161411f, "0081 Carroll Shoals, Kautzermouth, Belize", new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd"), "983 Courtney Key, Richardfurt, Indonesia", new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2da742b1-9ce6-4d3c-a2f4-c4df13a9d271"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 23, 5, 49, 14, 563, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 7, 1, 5, 49, 14, 563, DateTimeKind.Local).AddTicks(8862), null, 83.29m, true, 2151507724622458m, "ParcelMachine", 5, 44.093445f, "4447 Candida Hollow, New Novellastad, Central African Republic", new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be"), "888 Baumbach Drive, Boyerport, Malaysia", new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("310a87af-6328-4129-9f17-7b46a37b5fd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 18, 16, 6, 30, 929, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 2, 21, 16, 6, 30, 929, DateTimeKind.Local).AddTicks(5556), null, 40.62m, 4524656392210518m, "Standart", 4, 1.5807133f, "92203 Breitenberg Overpass, Schusterville, El Salvador", new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945"), "53409 Jones Fords, Lake Lavon, Serbia", new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("32347b49-16d1-4f9e-9fd4-55a7c09d098a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 8, 23, 58, 55, 456, DateTimeKind.Local).AddTicks(5268), new DateTime(2023, 6, 15, 23, 58, 55, 456, DateTimeKind.Local).AddTicks(5268), null, 47.71m, true, 5004885981836892m, "Courier", 5, 31.442257f, "8625 Lakin Walk, Hollieland, Faroe Islands", new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0"), "00350 Torrance Vista, Siennaburgh, French Guiana", new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("380c7ec3-a006-4300-93b2-b3d6754fef89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 11, 18, 5, 16, 371, DateTimeKind.Local).AddTicks(1814), new DateTime(2023, 9, 15, 18, 5, 16, 371, DateTimeKind.Local).AddTicks(1814), null, 36.68m, true, 2510241681589930m, true, "Standart", 5, 13.700171f, "22210 Hegmann Lodge, West Ashleyfort, Central African Republic", new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1"), "953 Darian Divide, Reichertport, Sweden", new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3d2240f7-abab-47b6-b290-37a16660bc59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 22, 6, 51, 7, 81, DateTimeKind.Local).AddTicks(3080), new DateTime(2023, 10, 23, 6, 51, 7, 81, DateTimeKind.Local).AddTicks(3080), null, 52.50m, 7332803193072432m, "Super", 4, 6.7813745f, "1828 Shanie Canyon, North Larueborough, South Georgia and the South Sandwich Islands", new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d"), "956 Dean Cliffs, East Roy, Finland", new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("42b368fe-74ae-46b8-b9a5-0f1c27867866"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 5, 2, 6, 7, 664, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 10, 9, 2, 6, 7, 664, DateTimeKind.Local).AddTicks(2269), null, 45.18m, true, 5395179487311450m, true, "Special", 3, 18.285084f, "091 Marlene Grove, Kochstad, American Samoa", new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b"), "0861 Deckow Orchard, West Brooklyn, Turkmenistan", new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("44d9fef0-0456-4312-ae00-94dab3564e88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 20, 6, 59, 12, 535, DateTimeKind.Local).AddTicks(8331), new DateTime(2023, 7, 22, 6, 59, 12, 535, DateTimeKind.Local).AddTicks(8331), null, 19.35m, true, 2218239236588492m, "Courier", 4, 1.2115103f, "28527 Schmeler Lakes, Jacobiton, Netherlands Antilles", new Guid("cd1cbc32-3001-4296-97b1-174540c81c07"), "18840 Davis Village, Thoraland, Switzerland", new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2"), "Registered", "PlasticBag" },
                    { new Guid("46d87ef7-bf66-40ef-80b1-9d1ecddc70a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 24, 21, 13, 26, 253, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 6, 1, 21, 13, 26, 253, DateTimeKind.Local).AddTicks(7350), null, 69.06m, true, 5564540518325556m, "Super", 1, 15.818043f, "6698 Jacobson Mountain, Port Marvinmouth, Greece", new Guid("a0863958-35de-49a9-a73b-decb03e0c871"), "83848 Claude Pines, Port Dillonton, Ghana", new Guid("bf057140-33a4-45d8-af53-45e3337a92d1"), "Delivered", "CardboardBox" },
                    { new Guid("483b7d54-25b0-4fda-98c6-2d7f36b2b8fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 16, 2, 56, 8, 333, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 7, 20, 2, 56, 8, 333, DateTimeKind.Local).AddTicks(5800), null, 47.62m, true, 7089487702601400m, "ParcelMachine", 2, 3.3063521f, "2079 Retha Bypass, Collinshaven, Reunion", new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52"), "437 Friesen Light, Port Gillian, Democratic People's Republic of Korea", new Guid("fc218112-8b42-4598-a25c-227112647fca"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("498e321c-7a5d-467e-9f4f-b69dde1679a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 11, 7, 12, 20, 356, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 2, 21, 7, 12, 20, 356, DateTimeKind.Local).AddTicks(9367), null, 71.46m, 8687052702784654m, true, "Super", 4, 3.7775054f, "18403 Blick Inlet, South Albinshire, Guinea-Bissau", new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03"), "89705 Zemlak Mountain, Leannahaven, Saint Helena", new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8"), "OnTheWay", "PlasticBag" },
                    { new Guid("532e211a-4397-4237-80c6-9bf9d7945037"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 21, 15, 1, 39, 177, DateTimeKind.Local).AddTicks(9298), new DateTime(2023, 11, 25, 15, 1, 39, 177, DateTimeKind.Local).AddTicks(9298), null, 40.83m, 9983305061159912m, true, "Standart", 2, 17.657429f, "43050 Collins Roads, East Aishamouth, Brazil", new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff"), "390 Jacobs Mills, Pfannerstillmouth, Somalia", new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("542b1771-cd97-4f7e-adec-6660ac002e1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 23, 11, 54, 30, 266, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 1, 31, 11, 54, 30, 266, DateTimeKind.Local).AddTicks(6046), null, 63.74m, 6631257552785702m, "Super", 3, 36.995026f, "806 Gutmann Grove, West Karafurt, Lithuania", new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217"), "05615 McClure Forks, Bartellton, Seychelles", new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5435dd14-1502-4573-97ad-a5d688e06d5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 29, 21, 22, 18, 632, DateTimeKind.Local).AddTicks(6629), new DateTime(2023, 12, 31, 21, 22, 18, 632, DateTimeKind.Local).AddTicks(6629), null, 78.60m, true, 5969780488776720m, "Standart", 1, 48.74224f, "943 Nikolaus Cliffs, Xanderstad, Sweden", new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd"), "22076 Fay Plains, North Isaias, Kyrgyz Republic", new Guid("171184db-5baa-42f3-92d8-64b8e76c6165"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("568c1449-5662-484b-bff8-cda986563428"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 15, 14, 26, 25, 897, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 5, 23, 14, 26, 25, 897, DateTimeKind.Local).AddTicks(9500), null, 78.40m, true, 7345834061613430m, true, "Standart", 1, 27.54624f, "9480 Darrick Vista, West Oletashire, Sudan", new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d"), "231 Smith Cape, Parisiantown, Netherlands", new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5d546db3-d01d-4cbd-bd3e-7cb8e10f8c5f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 18, 13, 27, 2, 228, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 6, 25, 13, 27, 2, 228, DateTimeKind.Local).AddTicks(5165), null, 43.20m, 1648350519145731m, "Standart", 4, 5.0461035f, "11079 Hansen Loaf, Christiansenshire, Norfolk Island", new Guid("d364b716-4b5c-4090-99d6-0f11b5849701"), "9211 Langosh Loop, Heidenreichland, Belgium", new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9"), "Registered", "CardboardBox" },
                    { new Guid("5f27a16a-4247-4961-887e-2012f20d3e7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 17, 18, 21, 19, 900, DateTimeKind.Local).AddTicks(7492), new DateTime(2024, 2, 24, 18, 21, 19, 900, DateTimeKind.Local).AddTicks(7492), null, 77.15m, 6435409849279742m, "Courier", 2, 16.604258f, "1621 Brenda Locks, East Aaliyahbury, Malaysia", new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd"), "8146 Cassin Port, Lake Dollymouth, Virgin Islands, U.S.", new Guid("d5908335-16ba-435a-9a9d-603eaee07878"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("61e22ce9-32a6-4848-9ee5-949593ba025c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 22, 12, 29, 16, 883, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 3, 2, 12, 29, 16, 883, DateTimeKind.Local).AddTicks(4779), null, 75.94m, true, 7838521307376995m, "Standart", 4, 24.642653f, "541 Kiehn Groves, Lake Coy, Saudi Arabia", new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac"), "6880 Hobart Valleys, New Bart, Mozambique", new Guid("7f343d83-488a-4f8e-bb83-7417580035e2"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("63501a0d-9799-46cc-9d5c-fe95c1b8a762"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 28, 11, 9, 44, 288, DateTimeKind.Local).AddTicks(459), new DateTime(2023, 11, 7, 11, 9, 44, 288, DateTimeKind.Local).AddTicks(459), null, 80.81m, 1163858356280214m, "Courier", 5, 18.90117f, "2739 Turner Burg, New Dayna, Romania", new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3"), "40857 Antonia Island, East Karlee, Netherlands", new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("63cd9fd1-b00a-41fa-83c2-e0510f136558"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 23, 6, 14, 0, 416, DateTimeKind.Local).AddTicks(2611), new DateTime(2024, 5, 1, 6, 14, 0, 416, DateTimeKind.Local).AddTicks(2611), null, 61.83m, 8649755586782720m, true, "Courier", 2, 31.885695f, "94319 Okuneva Freeway, D'Amoreport, Nicaragua", new Guid("45917911-5af0-4724-8a58-1fe212041071"), "086 Stokes Pass, North Emmaberg, Iraq", new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("65103524-1e6e-40f1-ae3c-9b45d43d61e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 25, 19, 14, 30, 470, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 6, 27, 19, 14, 30, 470, DateTimeKind.Local).AddTicks(2234), null, 72.61m, 9578338697587042m, "Special", 4, 43.64563f, "0585 Merl Village, Alexamouth, Mali", new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), "67167 Murphy Common, Leannview, Pitcairn Islands", new Guid("a030d800-7dee-4af6-9714-7607209659cc"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("69fbcf88-e094-4f7d-886a-ec984c8b246e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 28, 23, 7, 36, 97, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 12, 8, 23, 7, 36, 97, DateTimeKind.Local).AddTicks(3581), null, 28.36m, 7422510909934848m, true, "Courier", 4, 10.796332f, "368 Huels Expressway, Homenicktown, Dominican Republic", new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9"), "7702 Joelle Street, Leschtown, France", new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6a0ad774-ae44-46d2-9e5b-57231fbc62d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 14, 11, 57, 1, 722, DateTimeKind.Local).AddTicks(1772), new DateTime(2024, 1, 18, 11, 57, 1, 722, DateTimeKind.Local).AddTicks(1772), null, 26.55m, 8324110882177253m, "Super", 3, 9.893453f, "05256 Gibson Creek, North Reese, Afghanistan", new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "093 Malinda Street, New Rex, Heard Island and McDonald Islands", new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6cf1ba62-51e1-4a52-9d9c-4f153ed285ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 18, 23, 9, 1, 57, DateTimeKind.Local).AddTicks(9447), new DateTime(2023, 10, 26, 23, 9, 1, 57, DateTimeKind.Local).AddTicks(9447), null, 16.40m, true, 8836900170123879m, "Standart", 1, 19.927046f, "78756 Hane Plaza, Lake Ramiro, Ethiopia", new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e"), "523 Korey Path, West Jada, Georgia", new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("70368a14-54f5-46ca-b987-2bf4020d68a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 1, 2, 28, 59, 721, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 6, 9, 2, 28, 59, 721, DateTimeKind.Local).AddTicks(6853), null, 94.61m, 6748117210325760m, "Special", 2, 7.8146772f, "18574 Howe Corner, West Delta, Vietnam", new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b"), "394 Cecelia Loop, New Bartholometon, Guinea", new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7175b029-6644-421f-b601-c48e9fb6b52d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 22, 23, 6, 26, 661, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 11, 23, 23, 6, 26, 661, DateTimeKind.Local).AddTicks(5877), null, 41.13m, true, 3025305269648132m, "Standart", 2, 37.69255f, "2184 Quitzon Lodge, Bartellfort, Spain", new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816"), "0308 Lowe Station, Kertzmannhaven, Turks and Caicos Islands", new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7288b589-6ece-4d53-a58e-f569baf0a77b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 28, 22, 30, 38, 742, DateTimeKind.Local).AddTicks(1521), new DateTime(2024, 1, 7, 22, 30, 38, 742, DateTimeKind.Local).AddTicks(1521), null, 32.09m, true, 1650036155210571m, true, "Courier", 4, 30.238388f, "814 O'Connell Throughway, North Constantin, Belgium", new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8"), "86373 Pfannerstill Route, New Caleighborough, United States Minor Outlying Islands", new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("74cc9280-0890-4030-90d3-de855d565942"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 24, 18, 20, 27, 195, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 7, 30, 18, 20, 27, 195, DateTimeKind.Local).AddTicks(7413), null, 85.15m, 8181763997484719m, "Super", 2, 48.709366f, "36992 Runolfsdottir Fields, South Aliaport, Honduras", new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77"), "04519 Velma Lock, Carolynefurt, Cameroon", new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be"), "Sent", "PlasticBag" },
                    { new Guid("74f9225e-51f2-47e7-bf9a-a1a09205ff5f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 9, 10, 47, 34, 56, DateTimeKind.Local).AddTicks(1963), new DateTime(2024, 4, 18, 10, 47, 34, 56, DateTimeKind.Local).AddTicks(1963), null, 87.31m, 6650875678271438m, "ParcelMachine", 3, 33.42248f, "693 Roy Stravenue, Port Melissa, Jamaica", new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502"), "860 Stark Mountain, Marianton, Saint Martin", new Guid("0b13afed-b734-4249-bae8-810ee4f78617"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("7591f4c4-667e-4068-bf8a-21d9b9919e55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 3, 5, 52, 48, 776, DateTimeKind.Local).AddTicks(7558), new DateTime(2024, 6, 13, 5, 52, 48, 776, DateTimeKind.Local).AddTicks(7558), null, 90.34m, true, 9355118353927542m, true, "Super", 2, 45.346195f, "6270 Shaylee Forges, West Millie, Norfolk Island", new Guid("171184db-5baa-42f3-92d8-64b8e76c6165"), "4418 Haley Stream, Lenorafort, Vietnam", new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "Return", "PlasticBag" },
                    { new Guid("76245221-6f2f-4da7-90b2-5e9a3b3a1553"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 19, 11, 23, 29, 759, DateTimeKind.Local).AddTicks(3792), new DateTime(2023, 8, 25, 11, 23, 29, 759, DateTimeKind.Local).AddTicks(3792), null, 13.33m, true, 7633709749427231m, true, "Standart", 2, 5.268892f, "3552 Brice Island, South Loyal, Uganda", new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240"), "61915 Darion Land, Lake Damion, Lesotho", new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("78ff6ec8-ad6e-48e5-9db5-717c5e5ac0ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 24, 18, 15, 31, 882, DateTimeKind.Local).AddTicks(38), new DateTime(2024, 5, 27, 18, 15, 31, 882, DateTimeKind.Local).AddTicks(38), null, 40.37m, 6330338730637668m, "ParcelMachine", 4, 35.432743f, "02497 Considine Islands, New Mackenzie, El Salvador", new Guid("7f343d83-488a-4f8e-bb83-7417580035e2"), "5561 Fredrick Plain, Konopelskiside, Bahrain", new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18"), "Return", "PlasticBag" },
                    { new Guid("7a29f904-e0cd-4739-a047-62abe1d831c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 10, 15, 15, 50, 694, DateTimeKind.Local).AddTicks(1454), new DateTime(2023, 12, 11, 15, 15, 50, 694, DateTimeKind.Local).AddTicks(1454), null, 30.07m, 2801372097982260m, "Standart", 4, 6.5129905f, "019 Allen Haven, Buckridgefurt, Macao", new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac"), "04417 Raquel Way, East Angelitaville, Senegal", new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("80a0d4d1-75da-4b13-9e9d-67cfea1b66d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 7, 18, 54, 0, 321, DateTimeKind.Local).AddTicks(1745), new DateTime(2024, 5, 9, 18, 54, 0, 321, DateTimeKind.Local).AddTicks(1745), null, 97.25m, true, 6627127296243986m, true, "Courier", 5, 0.82438564f, "12982 Devante Way, Warrenside, Eritrea", new Guid("ae750269-835b-481a-8e36-4dd8044f9527"), "278 Giovanna Grove, South Brown, Sierra Leone", new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("85bac5f2-c807-488c-8278-3f1500f8f8a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 3, 3, 37, 49, 109, DateTimeKind.Local).AddTicks(786), new DateTime(2023, 7, 13, 3, 37, 49, 109, DateTimeKind.Local).AddTicks(786), null, 41.15m, 1049604632078208m, "Super", 2, 10.852379f, "3655 Kunde Spur, West Lloydside, Ethiopia", new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52"), "21663 Kreiger Place, Shanamouth, Swaziland", new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8b9b99ab-54bf-46a0-9ae2-d960bc267a67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 8, 9, 28, 32, 981, DateTimeKind.Local).AddTicks(2057), new DateTime(2023, 10, 12, 9, 28, 32, 981, DateTimeKind.Local).AddTicks(2057), null, 14.76m, 4148585726989592m, true, "Standart", 5, 40.01269f, "51517 Riley Walks, Port Lea, French Guiana", new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc"), "30334 Gaylord Mall, Jarrettfurt, British Indian Ocean Territory (Chagos Archipelago)", new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8c19bcf2-965d-4c0b-b45b-b7f193ebf64b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 27, 4, 58, 52, 749, DateTimeKind.Local).AddTicks(6148), new DateTime(2024, 3, 7, 4, 58, 52, 749, DateTimeKind.Local).AddTicks(6148), null, 46.24m, true, 5807537025029163m, true, "Standart", 2, 9.2211f, "024 Marlin Ports, Dockport, Germany", new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f"), "99008 Ford Pass, Angelicaton, Norway", new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8d1577cc-f5f3-4c5b-9e58-dc3b5628b571"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 23, 17, 25, 6, 670, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 7, 27, 17, 25, 6, 670, DateTimeKind.Local).AddTicks(2926), null, 30.13m, 1529632342518246m, true, "Courier", 3, 42.98249f, "288 Price Squares, Ericamouth, Zimbabwe", new Guid("d5908335-16ba-435a-9a9d-603eaee07878"), "58956 Jeanne Forge, West Shayna, New Zealand", new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("8e4a2b0a-6800-4064-9fbe-8c7ed5705d43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 23, 10, 40, 59, 871, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 12, 3, 10, 40, 59, 871, DateTimeKind.Local).AddTicks(8134), null, 31.89m, 5574270846873091m, "ParcelMachine", 2, 4.9705887f, "27169 Oberbrunner Forest, Candelariotown, Pitcairn Islands", new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de"), "230 Gunner Canyon, Ankundingstad, Sierra Leone", new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711"), "Return", "CardboardBox" },
                    { new Guid("8f0f7e91-a88b-4fd4-86cb-0d00ea826334"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 26, 17, 24, 53, 739, DateTimeKind.Local).AddTicks(7362), new DateTime(2023, 10, 30, 17, 24, 53, 739, DateTimeKind.Local).AddTicks(7362), null, 69.89m, 1659883574650342m, "Standart", 4, 33.579628f, "937 Bernhard Avenue, North Haydenview, Georgia", new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9"), "887 Lukas Run, Wildermanfort, Italy", new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("93c5af49-8693-4ddd-bf3b-71120f8971a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 14, 17, 51, 17, 406, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 8, 16, 17, 51, 17, 406, DateTimeKind.Local).AddTicks(4734), null, 33.36m, true, 2505014275067831m, true, "Standart", 2, 27.04367f, "00326 Tremayne Keys, Dayneton, Azerbaijan", new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), "1889 Kozey Cliffs, New Courtney, British Indian Ocean Territory (Chagos Archipelago)", new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11"), "Sent", "PlasticBag" },
                    { new Guid("9926ee84-809f-443f-9003-bf43ed0b7ec6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 24, 2, 50, 45, 190, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 5, 1, 2, 50, 45, 190, DateTimeKind.Local).AddTicks(772), null, 22.49m, true, 5329882786379092m, true, "Courier", 4, 8.921406f, "8605 Robel Ports, Jammieberg, Sudan", new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c"), "980 McDermott Pine, Runtefurt, Kyrgyz Republic", new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), "OnTheWay", "PlasticBag" },
                    { new Guid("9998ecc6-f210-4059-a7fa-b099c27f3d71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 14, 15, 1, 16, 627, DateTimeKind.Local).AddTicks(5424), new DateTime(2023, 10, 19, 15, 1, 16, 627, DateTimeKind.Local).AddTicks(5424), null, 31.81m, true, 6082220551836554m, true, "Courier", 2, 38.526096f, "59496 Aimee Circle, Lake Flossie, France", new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962"), "093 Lynch Way, Ziemannside, Martinique", new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9ded1e46-ea97-4d89-86c7-e00053f86d58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 1, 45, 42, 718, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 11, 20, 1, 45, 42, 718, DateTimeKind.Local).AddTicks(7978), null, 69.75m, true, 9421599432685348m, "Standart", 1, 47.52339f, "53772 Cooper Crossroad, Port Ayden, Burundi", new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c"), "57920 Ivah Causeway, Alysashire, Uganda", new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a15dc617-e416-4bdc-a892-e9a355627c9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 1, 13, 15, 26, 575, DateTimeKind.Local).AddTicks(6409), new DateTime(2024, 3, 4, 13, 15, 26, 575, DateTimeKind.Local).AddTicks(6409), null, 87.73m, 2093065143687166m, true, "Courier", 3, 20.889675f, "509 Feil Manor, Dylanville, Andorra", new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0"), "720 Strosin Mission, Lake Rickieport, Norway", new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664"), "Delivered", "CardboardBox" },
                    { new Guid("a50719bb-72ba-4bf9-b11c-9e047a654450"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 30, 10, 35, 19, 71, DateTimeKind.Local).AddTicks(8355), new DateTime(2023, 12, 6, 10, 35, 19, 71, DateTimeKind.Local).AddTicks(8355), null, 55.22m, 2587987144874996m, true, "Super", 4, 42.66079f, "403 Pacocha Centers, South Bettyborough, Jersey", new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84"), "5271 Morissette Stravenue, Bashiriantown, Cambodia", new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a57a3321-6e09-4b8a-b692-f7f28bc9f466"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 28, 22, 17, 25, 855, DateTimeKind.Local).AddTicks(9480), new DateTime(2024, 1, 4, 22, 17, 25, 855, DateTimeKind.Local).AddTicks(9480), null, 65.12m, 4900242546774598m, "Special", 5, 15.767473f, "18559 Alisa Place, North Cleoton, El Salvador", new Guid("d5908335-16ba-435a-9a9d-603eaee07878"), "961 Schaden Oval, Kubberg, Burkina Faso", new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a71ffb17-807d-4ae2-ae44-45a60e7e4afe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 6, 18, 23, 44, 437, DateTimeKind.Local).AddTicks(837), new DateTime(2023, 12, 15, 18, 23, 44, 437, DateTimeKind.Local).AddTicks(837), null, 44.80m, true, 4893486719754652m, true, "Courier", 2, 36.46448f, "672 Lurline Lake, Port Leonel, Heard Island and McDonald Islands", new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc"), "04188 Lindsay Passage, Schroederport, Slovenia", new Guid("eada0502-f63b-424a-9d81-244529d74dc1"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ab686bde-6ba2-4257-90fd-a4828ec0a678"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 22, 23, 40, 9, 288, DateTimeKind.Local).AddTicks(4633), new DateTime(2023, 11, 1, 23, 40, 9, 288, DateTimeKind.Local).AddTicks(4633), null, 20.16m, 7137048959879694m, true, "Special", 3, 44.40052f, "70838 Sporer Plains, East Keegan, South Georgia and the South Sandwich Islands", new Guid("82b014c4-7208-45ad-866e-bb82c82db592"), "58204 Giles Inlet, Lake Jess, Angola", new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ad0dbba6-7416-42a5-84e2-4c727c8aca8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 4, 16, 20, 46, 684, DateTimeKind.Local).AddTicks(6992), new DateTime(2024, 5, 10, 16, 20, 46, 684, DateTimeKind.Local).AddTicks(6992), null, 34.06m, true, 5170983385355571m, true, "Super", 5, 20.499641f, "420 Larkin Haven, Ziemannfurt, Philippines", new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86"), "08426 Gleason Glens, Port Demarco, Mexico", new Guid("4b9baedf-008d-41e7-9781-815a81805e9e"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b00bdc10-645d-4453-8022-6ca8afc269c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 5, 16, 55, 19, 295, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 4, 14, 16, 55, 19, 295, DateTimeKind.Local).AddTicks(5579), null, 70.21m, true, 8108346629821981m, "Courier", 4, 7.4926105f, "29234 Altenwerth Lake, Maeborough, Mauritius", new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), "936 Moriah Heights, Walkershire, Peru", new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b60c4589-2830-4211-9e02-7612bb69c8f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 2, 17, 23, 52, 858, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 7, 7, 17, 23, 52, 858, DateTimeKind.Local).AddTicks(8590), null, 82.34m, 3475094710508423m, true, "Courier", 2, 30.781641f, "306 Soledad Spur, North Neva, Solomon Islands", new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e"), "34622 Rau Prairie, West Icietown, Germany", new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b718ff49-3fcb-46ef-a616-1154a901780a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 18, 22, 58, 19, 805, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 4, 25, 22, 58, 19, 805, DateTimeKind.Local).AddTicks(5105), null, 61.64m, 7508366864236802m, "Standart", 2, 11.172573f, "46271 Borer Trace, Lynchberg, Cote d'Ivoire", new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2"), "620 Kaycee Pines, West Geneshire, Nicaragua", new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bc3fd033-888f-4990-975c-4dfbac214de1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 23, 46, 52, 295, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 11, 10, 23, 46, 52, 295, DateTimeKind.Local).AddTicks(4900), null, 45.49m, true, 2849176340974568m, "Courier", 1, 1.8879458f, "858 Rex Walk, Lake Camilla, Republic of Korea", new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), "95560 Carmela Island, West Maude, Monaco", new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c2d5c18d-90b8-45ce-aa91-b417d9ab4eba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 25, 4, 56, 2, 909, DateTimeKind.Local).AddTicks(2590), new DateTime(2024, 1, 4, 4, 56, 2, 909, DateTimeKind.Local).AddTicks(2590), null, 57.12m, 7358100743423552m, "Super", 2, 25.581652f, "0265 Renee Inlet, Beierfurt, Oman", new Guid("a030d800-7dee-4af6-9714-7607209659cc"), "655 Pouros Harbors, New Zackary, Lithuania", new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c9c6d44f-a9cf-4b3a-8c80-299a2f6eada5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 10, 16, 32, 49, 720, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 1, 20, 16, 32, 49, 720, DateTimeKind.Local).AddTicks(9972), null, 18.37m, true, 9465494155552294m, "Special", 1, 30.997654f, "332 Franecki Fords, Schmittside, Czech Republic", new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33"), "3782 Bechtelar Neck, Gerholdberg, Lao People's Democratic Republic", new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cbe0c460-60b1-4e89-830f-997615dd75f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 18, 57, 43, 489, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 12, 5, 18, 57, 43, 489, DateTimeKind.Local).AddTicks(1589), null, 90.56m, 9362913497933164m, "Super", 3, 41.173836f, "71436 Enid Walk, Imamouth, Grenada", new Guid("4a21367f-81c5-4947-b939-b44d17e67434"), "175 Ratke Mills, Port Melody, Aruba", new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ce311bb3-91ea-43a7-a8bc-4ab6657ea31b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 2, 17, 16, 18, 246, DateTimeKind.Local).AddTicks(1725), new DateTime(2023, 7, 10, 17, 16, 18, 246, DateTimeKind.Local).AddTicks(1725), null, 87.26m, true, 9104091362897692m, true, "Special", 3, 1.9248457f, "733 Nikolaus Underpass, Kochtown, Egypt", new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5"), "56459 Stephen Keys, New Elyssa, South Africa", new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7"), "Sent", "PlasticBag" },
                    { new Guid("ceb5e6b3-aa27-45ff-b0b2-f69931e482e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 19, 14, 18, 50, 234, DateTimeKind.Local).AddTicks(1173), new DateTime(2023, 6, 21, 14, 18, 50, 234, DateTimeKind.Local).AddTicks(1173), null, 27.99m, true, 3358812894249764m, true, "Standart", 1, 40.347122f, "7974 Margret River, Millerburgh, Lao People's Democratic Republic", new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52"), "0336 Steve Burgs, North Arnaldo, Malawi", new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cebf3185-eb6e-4436-b7e5-f9e5f79c69ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 9, 23, 24, 58, 291, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 7, 14, 23, 24, 58, 291, DateTimeKind.Local).AddTicks(9165), null, 17.98m, true, 6574734729179131m, true, "Super", 4, 27.70848f, "433 Efren Lane, West Dedrick, Belize", new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d"), "5045 Antwan Mills, Willmsberg, Bangladesh", new Guid("45dee853-0743-493d-b80b-c81b944cc529"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("cf9997fa-b072-45b3-a5d6-790dd5d166b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 19, 3, 13, 5, 95, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 6, 21, 3, 13, 5, 95, DateTimeKind.Local).AddTicks(9794), null, 51.68m, 2073318084593560m, "Standart", 2, 1.8419738f, "082 Boehm Springs, North Emieshire, Tanzania", new Guid("53078823-cbdb-4f6c-b393-57486464289a"), "599 Heller Expressway, Volkmanfort, Tunisia", new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7"), "Sent", "PlasticBag" },
                    { new Guid("df3daffc-9a1b-482c-925a-65b7d44f05cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 9, 16, 29, 45, 89, DateTimeKind.Local).AddTicks(1534), new DateTime(2023, 9, 12, 16, 29, 45, 89, DateTimeKind.Local).AddTicks(1534), null, 22.66m, 5362750145118532m, "ParcelMachine", 4, 13.319839f, "782 Yasmin Locks, Rosannabury, Sudan", new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d"), "3999 Rolfson Drive, South Jewelhaven, Tunisia", new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e088532d-bfc8-46b5-9b5e-0bae5301d78e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 30, 19, 7, 2, 499, DateTimeKind.Local).AddTicks(1845), new DateTime(2023, 8, 2, 19, 7, 2, 499, DateTimeKind.Local).AddTicks(1845), null, 63.66m, true, 7152601064768647m, "Special", 3, 41.339703f, "085 Marcelina Gardens, South Aronland, Bahrain", new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945"), "5828 Mariam Mills, Jenkinsfurt, Moldova", new Guid("8a966506-353d-46f9-91b9-9431f8562c71"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("e3bd0277-6bf2-4fb2-af83-d6a5cb5c9823"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 30, 11, 58, 23, 657, DateTimeKind.Local).AddTicks(2831), new DateTime(2024, 6, 8, 11, 58, 23, 657, DateTimeKind.Local).AddTicks(2831), null, 96.73m, 3949030610140012m, true, "Courier", 2, 7.692325f, "7370 Ortiz Underpass, Port Barrettland, Suriname", new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756"), "84799 Berniece Ford, Lake Mitchell, Sao Tome and Principe", new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65"), "Registered", "CardboardBox" },
                    { new Guid("e4a89280-dc80-42b5-a17c-7b7aa03806af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 8, 18, 30, 59, 812, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 2, 14, 18, 30, 59, 812, DateTimeKind.Local).AddTicks(1163), null, 33.49m, 9923328547087036m, true, "Super", 5, 9.720146f, "56762 Kirlin Port, Milfordborough, New Zealand", new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd"), "61553 Ruecker Road, Donnellychester, Egypt", new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e4f676a6-27ef-4760-990c-20b6414c21aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 31, 12, 56, 22, 857, DateTimeKind.Local).AddTicks(5079), new DateTime(2024, 6, 7, 12, 56, 22, 857, DateTimeKind.Local).AddTicks(5079), null, 54.17m, true, 3479310496475732m, true, "Standart", 1, 36.87456f, "309 Bruen Bridge, Cameronside, United States of America", new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), "411 Corene Gateway, New Leopold, Greece", new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e7329996-c6cc-47da-a77f-50b7973fe3e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 5, 23, 42, 58, 828, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 3, 14, 23, 42, 58, 828, DateTimeKind.Local).AddTicks(1864), null, 77.14m, 5551189003711916m, "Standart", 3, 4.5937924f, "7744 Archibald Field, South Chaunceyborough, Guinea", new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3"), "620 Abigail Mews, Carolland, Tonga", new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ec7af651-41bc-40a8-a61c-19bd8f7c5585"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 5, 12, 58, 1, 440, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 2, 12, 12, 58, 1, 440, DateTimeKind.Local).AddTicks(3612), null, 56.32m, true, 4238920451763246m, true, "Standart", 4, 40.368664f, "72952 Swift Lodge, East Santinabury, Guinea", new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f"), "0888 Manuela Lodge, Eastonville, Mongolia", new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("edae0906-ff36-4056-9afb-df5f544ca76d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 26, 4, 39, 48, 215, DateTimeKind.Local).AddTicks(5527), new DateTime(2024, 5, 28, 4, 39, 48, 215, DateTimeKind.Local).AddTicks(5527), null, 34.71m, 4260670605149584m, "ParcelMachine", 1, 23.690212f, "43387 Waters Ways, Nicolasshire, Italy", new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7"), "86949 Caterina Stravenue, Lednerview, Turks and Caicos Islands", new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("edf90adf-ed3a-4c95-a138-0df11d8b71c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 21, 1, 50, 32, 471, DateTimeKind.Local).AddTicks(4665), new DateTime(2024, 4, 28, 1, 50, 32, 471, DateTimeKind.Local).AddTicks(4665), null, 10.55m, 9845048923575608m, true, "Special", 3, 5.88665f, "549 Cremin Flat, East Jaquelinmouth, Andorra", new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2"), "48084 Mia Prairie, Vicentafurt, Finland", new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f12527dd-d5d1-4001-86a2-7914b3b47797"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 4, 13, 32, 55, 833, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 12, 9, 13, 32, 55, 833, DateTimeKind.Local).AddTicks(7209), null, 17.96m, 2290010357954540m, "Standart", 5, 30.328709f, "80812 Amiya Mountains, Lake Daytonberg, Burkina Faso", new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10"), "07522 Neal Drive, Kuvalisport, Christmas Island", new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0"), "Sent", "CardboardBox" },
                    { new Guid("f30e0fe8-98aa-4aef-ade1-242d8daefe99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 3, 2, 30, 45, 821, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 2, 11, 2, 30, 45, 821, DateTimeKind.Local).AddTicks(2329), null, 73.82m, 4879517260740172m, "Courier", 5, 16.608727f, "40232 Stokes Island, Kaylietown, Dominica", new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84"), "256 Lueilwitz Brooks, Port Milton, Falkland Islands (Malvinas)", new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f4e8bd06-962e-456c-a12c-8f140588787b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 25, 15, 48, 59, 67, DateTimeKind.Local).AddTicks(9197), new DateTime(2024, 1, 31, 15, 48, 59, 67, DateTimeKind.Local).AddTicks(9197), null, 56.86m, true, 9347655840036748m, "Standart", 1, 18.23334f, "64120 Hoeger Lock, North Jarvis, Sao Tome and Principe", new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d"), "638 Haskell Island, South River, Saint Martin", new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f89a9877-2f15-43d3-9054-bc5d8484aa57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 22, 15, 29, 23, 658, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 4, 29, 15, 29, 23, 658, DateTimeKind.Local).AddTicks(4586), null, 65.77m, 4631618039654889m, true, "Standart", 2, 20.485003f, "46355 Lily Cliff, Port Leonburgh, Macao", new Guid("45dee853-0743-493d-b80b-c81b944cc529"), "61542 Samanta Meadows, West Isabelville, Timor-Leste", new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f9416881-2dc0-4fea-902e-bca4be23f4ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 11, 8, 20, 43, 108, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 1, 14, 8, 20, 43, 108, DateTimeKind.Local).AddTicks(2024), null, 43.43m, true, 2444592261449780m, "ParcelMachine", 3, 6.0242147f, "1162 Rex Terrace, Stuartshire, Oman", new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), "6339 Jeff Square, Mavisfurt, Ethiopia", new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fb506da3-1b99-4d7a-9b35-0515e8d0b12a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 8, 2, 29, 17, 253, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 6, 17, 2, 29, 17, 253, DateTimeKind.Local).AddTicks(5725), null, 69.66m, true, 8057912501483950m, true, "Special", 1, 15.564386f, "9592 Brekke Locks, New Vadaport, Tokelau", new Guid("82b014c4-7208-45ad-866e-bb82c82db592"), "699 Herzog Gateway, New Ceasar, Brazil", new Guid("152f42db-01de-48e4-a495-9233a821e250"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("00e5a2b9-1034-4995-9886-f4dacb1921b6"), "793", "4099600940925168", null, null, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020"), "08/08" },
                    { new Guid("01dd4f9e-cebd-479d-8be4-66b8d5754bc0"), "494", "5053741800099130", null, null, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec"), "03/10" },
                    { new Guid("01feb9b1-1165-4847-96b0-96fa1da44685"), "410", "9554849481978920", null, null, new Guid("4a21367f-81c5-4947-b939-b44d17e67434"), "02/02" },
                    { new Guid("01ff3fb2-a9ba-4686-b010-23a867c83686"), "398", "2721675133315389", null, null, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086"), "12/18" },
                    { new Guid("022aa0d7-93f7-4ccf-966f-a50768b19f95"), "078", "4410451043956122", null, null, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca"), "02/21" },
                    { new Guid("026ea88f-7f06-476a-9a4e-36e46b8ff8c6"), "293", "1005879540134230", null, null, new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618"), "10/13" },
                    { new Guid("02a99646-15cf-42ba-8420-adf1ceade6db"), "565", "3001671075980700", null, null, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad"), "06/09" },
                    { new Guid("031cdf5a-81ae-4d57-acb7-5d03df2279b6"), "391", "1098539100485497", null, null, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9"), "01/06" },
                    { new Guid("0340c229-4b7f-4dd7-96ef-c52055d5da28"), "042", "5680167352144640", null, null, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), "03/20" },
                    { new Guid("038e61ae-0ab3-4eff-b2f2-6ea58823331c"), "018", "7932692860125638", null, null, new Guid("82b014c4-7208-45ad-866e-bb82c82db592"), "12/07" },
                    { new Guid("049e5669-7166-4e51-95f1-fa67a4c8338b"), "186", "8011321985054452", null, null, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05"), "08/27" },
                    { new Guid("04cb0fb0-e71a-4ecb-a809-cedef736a44b"), "536", "5483378535128791", null, null, new Guid("152f42db-01de-48e4-a495-9233a821e250"), "09/18" },
                    { new Guid("054838ec-da43-4b7b-a625-54b8127ddef1"), "645", "1326256342375143", null, null, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52"), "06/23" },
                    { new Guid("05f1d955-c112-490b-8f96-32e644eb5f83"), "461", "6481451945654561", null, null, new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e"), "02/04" },
                    { new Guid("060ebbe4-2dd9-4726-86a9-c7d007b95405"), "464", "9944864358790535", null, null, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa"), "09/05" },
                    { new Guid("061dea29-f261-4f50-875a-29adee82a68f"), "447", "7607029824514036", null, null, new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1"), "01/18" },
                    { new Guid("06a766b7-a2ea-4050-b5cb-3ec0c99af07e"), "371", "1265187524835554", null, null, new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139"), "05/23" },
                    { new Guid("06ced761-b0db-4554-8c66-9479671ec23b"), "598", "8723672491208462", null, null, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01"), "08/09" },
                    { new Guid("0755a28a-6c0d-4d93-bb45-091238f399c0"), "499", "8994156887846390", null, null, new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d"), "01/23" },
                    { new Guid("079d1da3-a8c2-464a-b9af-88acc049d535"), "106", "7901967987620369", null, null, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d"), "02/08" },
                    { new Guid("080dd3e0-38dc-4254-a8d0-ce9e5bef2da3"), "004", "8577427858661756", null, null, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f"), "01/08" },
                    { new Guid("081814ad-563b-4216-9a3a-4697c911986c"), "310", "7447087237973596", null, null, new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9"), "03/10" },
                    { new Guid("08a7ee46-83c7-40a9-ae5a-b16b34bdcd1c"), "079", "2825982845170495", null, null, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581"), "01/13" },
                    { new Guid("08cf1105-55cd-4a82-903e-0f0279bf5a09"), "474", "3462551725018137", null, null, new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c"), "10/13" },
                    { new Guid("0990836b-9ed0-46c5-b32b-4f1a95316576"), "814", "2213473025000170", null, null, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca"), "07/21" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("09a0d1f1-27a2-4a5f-814e-0d14d13ea555"), "348", "3941873637715761", null, null, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f"), "06/05" },
                    { new Guid("09c31689-fac7-49b6-b274-7f898f8bcb68"), "894", "1060665467992285", null, null, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5"), "10/17" },
                    { new Guid("09c63be5-e3a9-4f3f-8247-1c40f53be3d8"), "160", "1614193264320150", null, null, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b"), "11/18" },
                    { new Guid("09f65d70-cb7a-48f8-be20-af9dcd110179"), "627", "3257481594342093", null, null, new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2"), "12/08" },
                    { new Guid("0a4f7b14-2457-4de2-907a-8aee3f902ddc"), "191", "9167174733519313", null, null, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f"), "12/10" },
                    { new Guid("0aabea89-e971-4c95-bee5-9e9919dfbe4e"), "901", "3427180613710694", null, null, new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad"), "11/04" },
                    { new Guid("0abfacde-2cb8-4d74-830f-1ab75ba85548"), "797", "1353412445407150", null, null, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434"), "03/15" },
                    { new Guid("0b167bb1-a284-4c51-b0f8-e947621cb193"), "551", "5185722046368035", null, null, new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a"), "02/08" },
                    { new Guid("0c76b6a9-9708-4770-aa4a-e593698b576b"), "966", "8202588328274743", null, null, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0"), "01/21" },
                    { new Guid("0d62c578-1e63-4cf7-b0ff-f849889ef3fb"), "970", "3031798571034844", null, null, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448"), "08/07" },
                    { new Guid("0dd03be0-4f9b-42bc-9844-20acec64a55a"), "903", "7498069427911281", null, null, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930"), "03/17" },
                    { new Guid("0e579bd3-bb6a-47df-81f1-6f19ebad92f6"), "597", "1360612278917889", null, null, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9"), "05/22" },
                    { new Guid("0eecd9d6-5575-4db5-b390-77a156bb3263"), "129", "6842496746667435", null, null, new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f"), "01/22" },
                    { new Guid("0f07d9d7-c8c6-445e-b7b5-5cb09dffd91c"), "225", "6801879599376070", null, null, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa"), "09/02" },
                    { new Guid("0f4bc5b5-b9e1-45f9-ae80-df0d27c5c399"), "188", "1301760377365868", null, null, new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a"), "04/04" },
                    { new Guid("0f57ecc5-440b-48f2-a3a0-f453761b0698"), "385", "8430469138420837", null, null, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5"), "09/09" },
                    { new Guid("0f638d22-b4c0-451c-81d3-d3ef53aa9aec"), "943", "7298624320400944", null, null, new Guid("8d077a60-6583-4591-b84d-07adff60a1a0"), "02/10" },
                    { new Guid("0f75c326-e8fe-48f8-939d-274696d11ece"), "139", "1304084701367634", null, null, new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d"), "07/14" },
                    { new Guid("0fd5fb17-1e84-48f7-a8b6-1b8ed076b32f"), "003", "5493744191861029", null, null, new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472"), "10/04" },
                    { new Guid("10bdd094-e31c-42fc-9bd5-3c911641070a"), "074", "9694566704415229", null, null, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c"), "11/09" },
                    { new Guid("10cc346f-0268-4ed6-b304-7839e10d7ac6"), "002", "3075220722024026", null, null, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), "05/17" },
                    { new Guid("1142814b-af38-490d-be12-6896a28bd15f"), "433", "1428894254367833", null, null, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651"), "05/13" },
                    { new Guid("115e9729-bcf2-492a-a191-a2b8db1044fc"), "158", "1715508063868384", null, null, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3"), "07/21" },
                    { new Guid("124a3859-ae9b-4618-9492-d9077b94a969"), "535", "7991611210955574", null, null, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca"), "07/18" },
                    { new Guid("12564262-9b36-4579-b754-249d8f135853"), "966", "5129135923640773", null, null, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0"), "01/07" },
                    { new Guid("12880f45-ff81-40c3-9308-e866b0331234"), "901", "3065459588405925", null, null, new Guid("fc218112-8b42-4598-a25c-227112647fca"), "06/13" },
                    { new Guid("12ebfb2b-16be-4f3b-8b8c-78ae40057e96"), "427", "4438961674689680", null, null, new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8"), "03/02" },
                    { new Guid("1303f5e4-98e1-4988-8983-375a07a29ef7"), "322", "2551115290161207", null, null, new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3"), "09/22" },
                    { new Guid("133438f9-a6d4-405a-93c9-79e5b8db8c5b"), "545", "8753049171206551", null, null, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd"), "04/17" },
                    { new Guid("13d2877c-4087-4642-b28b-d460d4ea4c8a"), "994", "4568561647970996", null, null, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1"), "03/25" },
                    { new Guid("1410d01d-d9b9-4f35-85e0-3511e44e0536"), "326", "2562436912666918", null, null, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e"), "05/25" },
                    { new Guid("1493e029-15f9-43fd-a3ab-6254a3d775ff"), "590", "9746299365031868", null, null, new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df"), "11/03" },
                    { new Guid("14d4727e-8e92-48aa-84e7-d0a2ce3ac20a"), "135", "2680465092008672", null, null, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5"), "04/17" },
                    { new Guid("150a6e66-44cb-47a2-a371-dabfd078ee95"), "601", "5197515348100200", null, null, new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f"), "07/18" },
                    { new Guid("1516e775-7a2e-4ff8-8a52-ff2b02986d69"), "999", "9554953549691905", null, null, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f"), "04/24" },
                    { new Guid("151735ef-b967-4cf6-af52-24868c25cd41"), "398", "1957846615909462", null, null, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9"), "10/05" },
                    { new Guid("15244fa6-f563-41d7-b106-3f4f387508a0"), "380", "4690277653837205", null, null, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7"), "10/20" },
                    { new Guid("16bcce86-f295-451d-825c-04a2858bf27b"), "595", "5305681939874715", null, null, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c"), "12/09" },
                    { new Guid("16c6534e-e7ce-4c99-9e7c-bf10896606a4"), "106", "4736253781786126", null, null, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a"), "10/07" },
                    { new Guid("17081d18-35ba-488b-b8d2-a6b34c7a191e"), "683", "6128871838485243", null, null, new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7"), "09/20" },
                    { new Guid("181bde64-7546-4420-aebc-e752be60efb4"), "424", "8044028264129541", null, null, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d"), "03/02" },
                    { new Guid("183b6b2a-9dcd-4127-8e40-897155dad61a"), "836", "8535814773312624", null, null, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9"), "04/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("18743bb8-0125-4338-a17b-cd6ff5b126b4"), "430", "9720646151003858", null, null, new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1"), "09/05" },
                    { new Guid("192783c1-3001-46cc-acc5-26b93eeb9797"), "066", "3183684628278429", null, null, new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502"), "10/19" },
                    { new Guid("195f2450-e221-46de-9305-e392410f093a"), "121", "9129454036050591", null, null, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d"), "01/13" },
                    { new Guid("1a002d98-fc77-44aa-bb98-c15c890083dc"), "504", "1416465211463489", null, null, new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340"), "05/06" },
                    { new Guid("1a1e404e-45dd-42a0-b970-bd27fd01ab87"), "471", "8214070515587860", null, null, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de"), "08/28" },
                    { new Guid("1b26aff1-ac30-4048-82d0-871f048c66ec"), "870", "1990563014747598", null, null, new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce"), "07/18" },
                    { new Guid("1b608791-47b0-44ff-b6e4-ea2f0db8107e"), "357", "5221296912723498", null, null, new Guid("152f42db-01de-48e4-a495-9233a821e250"), "10/04" },
                    { new Guid("1b62732f-235e-42b6-b4ab-e30437bbaa6b"), "382", "3950480881301584", null, null, new Guid("bf057140-33a4-45d8-af53-45e3337a92d1"), "12/27" },
                    { new Guid("1bcc8aec-a225-4a03-8ce7-44c9396ae1b1"), "318", "2063941067426209", null, null, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651"), "04/08" },
                    { new Guid("1c26367a-5ecd-4777-87fd-b85fa588e627"), "338", "2081902216188188", null, null, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4"), "05/21" },
                    { new Guid("1cba1af1-f57a-4077-9356-10be24f8609b"), "208", "8604302860336521", null, null, new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2"), "06/13" },
                    { new Guid("1cc1d776-f1ab-44ff-90d3-a34aa3bf2a1c"), "985", "2939757137167200", null, null, new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51"), "03/09" },
                    { new Guid("1d08968b-63f5-41e6-aa24-2f58a5b6bf2d"), "140", "4307781698332619", null, null, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca"), "02/09" },
                    { new Guid("1d7ccb4e-a96d-44a7-ba35-d0c91beaedd7"), "236", "6363826979123619", null, null, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d"), "12/03" },
                    { new Guid("1df4f3cb-2560-40cf-ade9-32eb0c0095df"), "931", "3447182448186604", null, null, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e"), "01/13" },
                    { new Guid("1e172442-3806-4372-94b9-21d21bd200d8"), "499", "2661720521974344", null, null, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), "04/01" },
                    { new Guid("1e26ce28-4cd1-4c1b-aeff-e82a8c56ecfd"), "461", "5422990932276156", null, null, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), "07/17" },
                    { new Guid("1e2dddd4-2e05-4601-8089-614c0bf95f95"), "953", "6095505890452921", null, null, new Guid("a030d800-7dee-4af6-9714-7607209659cc"), "04/10" },
                    { new Guid("1e443e49-ff84-408e-b789-5c800698af22"), "047", "2687624647343689", null, null, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e"), "02/08" },
                    { new Guid("1ea292ae-1d39-4913-b889-ee544bc3061c"), "520", "4574352366688048", null, null, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff"), "04/14" },
                    { new Guid("1edc217f-35c0-4738-90e8-64fbc7b0eda3"), "603", "9463978404476858", null, null, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d"), "05/09" },
                    { new Guid("1f6c7ac3-f4c2-48bf-9621-e27c39cfbf11"), "393", "3037109517057840", null, null, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d"), "10/18" },
                    { new Guid("1f96e895-834f-4bcf-94eb-792196b82e59"), "183", "3911638368988987", null, null, new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919"), "07/15" },
                    { new Guid("1fd2b6c8-6857-4561-846d-dce6a608242b"), "398", "5727767451731547", null, null, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a"), "05/20" },
                    { new Guid("1fda5cd4-c269-46c6-9e9e-ad8e668b6bdc"), "425", "9175488159393320", null, null, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c"), "07/26" },
                    { new Guid("202a4335-983b-4ab1-a80c-31fa8a145890"), "298", "7705876119349266", null, null, new Guid("fc218112-8b42-4598-a25c-227112647fca"), "08/24" },
                    { new Guid("204978db-4327-4cb9-a592-fa0d32908e09"), "605", "2391140041310244", null, null, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c"), "09/01" },
                    { new Guid("209c2464-b4c1-4380-8adf-2dcdac09870e"), "913", "8320839877090772", null, null, new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664"), "08/17" },
                    { new Guid("20f207b7-097e-4384-b98d-a83c02d6b0e6"), "265", "1102012305183298", null, null, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5"), "07/07" },
                    { new Guid("2177e87d-1caf-4bc4-9700-7c2e0aca95ec"), "259", "4338576949962586", null, null, new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de"), "09/06" },
                    { new Guid("223587ea-9791-4544-9aa2-67d9ac434c48"), "631", "6110202902140024", null, null, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca"), "09/10" },
                    { new Guid("2339587c-934c-4aad-a669-3e95e6d38908"), "500", "5043506521623088", null, null, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756"), "08/19" },
                    { new Guid("2372a2d7-9b2d-4a37-8d91-2d64cb898cf3"), "302", "7016846142073422", null, null, new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be"), "06/21" },
                    { new Guid("239fea9e-9c68-4759-8848-4491696dd4ec"), "001", "7363284367854642", null, null, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de"), "07/26" },
                    { new Guid("23a5bf93-96ef-4a78-9e4e-5546073c1840"), "312", "9759372481191135", null, null, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef"), "07/03" },
                    { new Guid("23c9c677-916d-4fdb-a828-5c5e9613330f"), "953", "2734881657186838", null, null, new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e"), "06/19" },
                    { new Guid("23d45b47-e67a-41cb-9894-16a59420c7d6"), "253", "6279239529963431", null, null, new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af"), "11/08" },
                    { new Guid("247d6b87-9e15-4af8-a3a8-34c9e17bb28d"), "216", "8570737257040511", null, null, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9"), "11/08" },
                    { new Guid("247da825-bf86-4389-a38f-938350c35093"), "652", "8902484525922565", null, null, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2"), "11/06" },
                    { new Guid("24c50b51-02f8-498e-9751-531fbfebe930"), "583", "2757976180522367", null, null, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116"), "06/11" },
                    { new Guid("24cd99fc-b07b-44cb-a313-5d8420fdd300"), "637", "4854978104273464", null, null, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e"), "07/22" },
                    { new Guid("24d4a4f4-23e7-4c87-b904-b8f8cdbc5763"), "897", "5368755678874401", null, null, new Guid("6c7090cd-7244-4437-b460-88c7027c78f9"), "06/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("24e76305-6d13-4a90-b93c-0f5be7555083"), "095", "6392397770879166", null, null, new Guid("6224405d-f9d8-407b-9f81-847223041784"), "03/24" },
                    { new Guid("24ebc7ea-a7b0-4c6d-ae5a-6ff87d71b9d8"), "904", "1973264066939987", null, null, new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7"), "08/04" },
                    { new Guid("2617a2f6-62db-4899-8828-ab0747fc6124"), "199", "3109839706504160", null, null, new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52"), "02/21" },
                    { new Guid("265c4e47-84c0-46ef-855b-101c7b644be1"), "038", "5369814658460216", null, null, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca"), "12/15" },
                    { new Guid("265d8780-9215-4e29-9801-a71d5292817b"), "188", "6818262285819200", null, null, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9"), "09/11" },
                    { new Guid("26a1f82a-15e1-4a85-9719-4a63a8813e62"), "635", "6871518313345934", null, null, new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10"), "06/28" },
                    { new Guid("26f1c35c-247d-42ce-85df-37395f686089"), "921", "3496286315872194", null, null, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b"), "08/23" },
                    { new Guid("270e99bb-c7cb-4a0a-a243-d9b9ce4704a5"), "795", "8216430176201468", null, null, new Guid("66bde12e-086d-4150-9c7a-89ea75047f12"), "08/25" },
                    { new Guid("27434295-a459-4158-9ecf-66e1c50f42fa"), "295", "4383367152111064", null, null, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6"), "07/12" },
                    { new Guid("27b5d32d-936c-47ed-99c3-5747bbb0121c"), "137", "7384681993321189", null, null, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14"), "01/14" },
                    { new Guid("28209533-02f3-4820-81b6-e67723f1167c"), "469", "9328426289942997", null, null, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c"), "01/06" },
                    { new Guid("28528834-6c3f-4ed7-8bcb-36430525c7fc"), "812", "7622676845972554", null, null, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca"), "06/02" },
                    { new Guid("28a1717a-9989-4824-8a49-732982b52c16"), "708", "8885578577555424", null, null, new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3"), "10/26" },
                    { new Guid("28a93776-92c0-4ebf-b7f6-9137942578ce"), "381", "3000266406241449", null, null, new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11"), "01/21" },
                    { new Guid("28b135a5-748e-4b48-a165-c2ce1ab0fffc"), "320", "1953457797721212", null, null, new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0"), "11/11" },
                    { new Guid("29a795d2-6811-43e4-8a32-c4add100a635"), "752", "2666975215792646", null, null, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413"), "01/23" },
                    { new Guid("29f42ff9-8431-49cd-8edf-505cc47de033"), "889", "5172240976098897", null, null, new Guid("82b014c4-7208-45ad-866e-bb82c82db592"), "06/20" },
                    { new Guid("29fde7de-b042-4648-be5f-c63a0b8ace02"), "962", "1766553572452973", null, null, new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f"), "06/25" },
                    { new Guid("2a56aa37-0d29-48e6-abd3-964d20c97b81"), "840", "2424823032473557", null, null, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235"), "06/22" },
                    { new Guid("2abca467-17d1-43f3-9372-c8840574ef30"), "174", "8686089263799499", null, null, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), "03/24" },
                    { new Guid("2ace6302-fb8f-4557-be9f-e453684b9be2"), "927", "7436807790624033", null, null, new Guid("fc218112-8b42-4598-a25c-227112647fca"), "04/14" },
                    { new Guid("2bbff75b-df12-4cae-b920-7300d848f044"), "931", "7250274142488062", null, null, new Guid("a030d800-7dee-4af6-9714-7607209659cc"), "08/15" },
                    { new Guid("2c3e0914-e262-4639-8ce5-166be69276a6"), "876", "6577086331922660", null, null, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff"), "07/28" },
                    { new Guid("2cd1bd74-8c19-4c29-b554-d55bb1ceb8b6"), "437", "2476622002445659", null, null, new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240"), "12/03" },
                    { new Guid("2cde8e0f-3699-4d6a-b122-8651132ca304"), "100", "9707273400186544", null, null, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2"), "10/21" },
                    { new Guid("2d301943-9e49-4a8e-9096-17041ca901a3"), "549", "4765201610870550", null, null, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9"), "01/04" },
                    { new Guid("2d634be8-0c2c-4584-8990-05fcb98de84d"), "576", "4392183328079752", null, null, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982"), "01/21" },
                    { new Guid("2ddbf1ef-2529-4535-88aa-706561fcd2db"), "192", "5806550816746266", null, null, new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f"), "05/01" },
                    { new Guid("2e5fc83a-fb38-4d25-8815-86d942311ce2"), "040", "7555982945275976", null, null, new Guid("eada0502-f63b-424a-9d81-244529d74dc1"), "04/28" },
                    { new Guid("2ea7f40f-4c3d-4731-80de-84d6d6364a64"), "912", "8102299561392099", null, null, new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9"), "09/14" },
                    { new Guid("2ed7da3c-95c2-45b7-b5b2-76e8993f7f00"), "453", "8083604338363471", null, null, new Guid("6d717976-193a-4962-947b-f15277ce537e"), "01/08" },
                    { new Guid("2f55749e-b092-43e6-83b3-71fa5c2504aa"), "102", "4052494078452925", null, null, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177"), "11/05" },
                    { new Guid("308c5c9f-d3b0-4560-b77c-2ee812e9ee1d"), "173", "7892152210898863", null, null, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec"), "07/12" },
                    { new Guid("309068dc-9fdc-49dd-9150-6588e1f12950"), "820", "5129350895792591", null, null, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9"), "01/13" },
                    { new Guid("313953a8-471a-4da3-b27c-2302cbd1778f"), "108", "8911542354921940", null, null, new Guid("8a966506-353d-46f9-91b9-9431f8562c71"), "10/15" },
                    { new Guid("31a8f821-fb67-486c-b0f1-36549b4ce1b8"), "701", "2495099939153096", null, null, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de"), "01/10" },
                    { new Guid("329060ec-7892-4f1e-ac4a-b68a6d1c58c4"), "221", "7756265243342019", null, null, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020"), "10/04" },
                    { new Guid("33b64c0b-b93c-4f23-9342-6b9c4fb430f1"), "365", "4862379701731652", null, null, new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f"), "06/09" },
                    { new Guid("341673c8-4de9-4e2f-9952-f109c1468bad"), "250", "7774596852874939", null, null, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d"), "06/14" },
                    { new Guid("3422550e-d82f-4f67-87f1-376f87210ac4"), "152", "4106998679934366", null, null, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945"), "04/23" },
                    { new Guid("344424dd-783e-4bda-9020-7e32ac17e630"), "266", "4294408768082429", null, null, new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664"), "02/24" },
                    { new Guid("344da3b5-26a1-4cc2-bef7-6e3c196599ef"), "274", "9035322170412967", null, null, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930"), "07/21" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("34604504-e07e-4648-a5c0-fb98fa209264"), "118", "5078751620457622", null, null, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413"), "11/13" },
                    { new Guid("347f21ac-2c28-497c-9f4b-4b1af17e0489"), "371", "7320130508539115", null, null, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b"), "03/17" },
                    { new Guid("347f6f1f-a64f-4fa9-a7a9-8488e1903a34"), "568", "8813501643456850", null, null, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36"), "09/13" },
                    { new Guid("34d6b762-af81-4eb7-ac05-caca03eba063"), "606", "3153544551118524", null, null, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f"), "11/06" },
                    { new Guid("357007b3-b435-4722-b525-06e4e2d384c8"), "709", "6676852539878243", null, null, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9"), "09/27" },
                    { new Guid("357eb071-3855-4cd7-8519-e07d287717e7"), "032", "5346585653976004", null, null, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9"), "12/07" },
                    { new Guid("35fd70a8-b46d-4eae-a95c-08d437b99348"), "158", "2062423749479470", null, null, new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779"), "07/04" },
                    { new Guid("365f6c62-35a7-4082-9c40-df7fc4fd7d2a"), "408", "2453177966652388", null, null, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561"), "07/06" },
                    { new Guid("3769f2a2-15a1-4e4a-b9d9-c62dccfe5ca1"), "584", "1623050125149485", null, null, new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2"), "04/16" },
                    { new Guid("376ac041-a0c5-49a1-8917-98f874453bb0"), "696", "3830501097316538", null, null, new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef"), "08/23" },
                    { new Guid("37735396-f70d-4c52-b493-17db1c8eeac8"), "388", "5033564820584091", null, null, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c"), "10/24" },
                    { new Guid("3788b28d-e8f7-42f8-9b19-eeeb86ae75d4"), "586", "3066189592822431", null, null, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8"), "11/06" },
                    { new Guid("37e14b19-bf87-4fdc-a5bd-f7b6b65efebd"), "451", "4649569499316302", null, null, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52"), "10/26" },
                    { new Guid("38487263-630d-401b-bdd1-b4c3c004b25e"), "662", "2793311977222619", null, null, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434"), "11/06" },
                    { new Guid("386588b2-58c0-4899-9ec2-a28dfa8b62e6"), "842", "8822614406869468", null, null, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff"), "08/25" },
                    { new Guid("396ea599-ff49-447b-9c14-3500f50821a7"), "202", "6533231793443943", null, null, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52"), "11/20" },
                    { new Guid("3970da10-8732-4e7e-aa55-b5e571fbe122"), "289", "6319662949818699", null, null, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1"), "06/04" },
                    { new Guid("39971f39-7ce0-4421-a386-39518e0efee5"), "526", "9333296483259532", null, null, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177"), "01/16" },
                    { new Guid("3a12bb18-46c6-4bd3-b6ba-c4e457dd1397"), "783", "2269574534973867", null, null, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), "10/26" },
                    { new Guid("3acfc2d6-a987-4e23-bb44-4261c237548e"), "323", "9076054180241177", null, null, new Guid("ae750269-835b-481a-8e36-4dd8044f9527"), "07/15" },
                    { new Guid("3b57edf7-5af0-4d64-a451-3e697436cfbd"), "075", "6644950082571978", null, null, new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8"), "10/07" },
                    { new Guid("3b5c0c2a-2f06-43dd-a02f-78c1eeb43320"), "998", "6159929921359753", null, null, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01"), "08/28" },
                    { new Guid("3b5d1437-a4c1-4e3a-a6ec-1d9af4663429"), "449", "4225756709256772", null, null, new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b"), "01/13" },
                    { new Guid("3b7990d3-3bf9-4d3d-a909-7d686164c900"), "806", "8347977388535261", null, null, new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af"), "11/25" },
                    { new Guid("3b7dccf8-566e-486a-bc68-f6e98f47043e"), "971", "1859394263472069", null, null, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33"), "07/13" },
                    { new Guid("3c069a4d-a699-49e0-b149-8b97ae6d1c0e"), "310", "6824968672117293", null, null, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b"), "01/07" },
                    { new Guid("3c2a291c-9121-44e1-b65b-4eb7d789b91d"), "562", "3913373457690211", null, null, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07"), "07/12" },
                    { new Guid("3c8630b6-6274-45e8-8b66-06cdc80bc54f"), "108", "3844569219421049", null, null, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3"), "07/04" },
                    { new Guid("3cab9463-60ca-470a-b540-294ad0de372f"), "413", "6833011522540577", null, null, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52"), "12/14" },
                    { new Guid("3ccf1dd4-9409-4f33-947f-25b35971c68f"), "042", "5513272202374985", null, null, new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546"), "01/08" },
                    { new Guid("3d08326b-c0ac-4e18-be27-7f6e8443e226"), "160", "4927752346611845", null, null, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de"), "09/27" },
                    { new Guid("3d2eec31-47b2-41be-bfb8-baf070bb7969"), "082", "6867935296778192", null, null, new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440"), "02/04" },
                    { new Guid("3d7c5efb-e1ab-4599-9090-5f41625ec305"), "627", "4828797149314574", null, null, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), "11/20" },
                    { new Guid("3e286194-f21d-48ff-9bb7-58f07a74e3ad"), "690", "2097764229939885", null, null, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8"), "01/25" },
                    { new Guid("3e39cd0d-ee7e-48c1-93ec-160a6832017d"), "443", "5348962337839360", null, null, new Guid("53078823-cbdb-4f6c-b393-57486464289a"), "06/22" },
                    { new Guid("3eb8a2ac-481c-48d6-a792-92aea7fdca61"), "013", "6860947361687961", null, null, new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28"), "01/06" },
                    { new Guid("3f3db829-1257-4a2d-93dd-1228ce1945c0"), "595", "1469455809132849", null, null, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36"), "04/05" },
                    { new Guid("3f718788-728e-4e57-b747-cd5883d2be81"), "040", "7165743958732307", null, null, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd"), "09/25" },
                    { new Guid("3fd4a6cc-6082-472e-8e08-22b663dfdf52"), "111", "8623316714584183", null, null, new Guid("152f42db-01de-48e4-a495-9233a821e250"), "03/05" },
                    { new Guid("40966ee1-dac6-4299-8723-23e47c20e25b"), "272", "3537507610753428", null, null, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65"), "08/13" },
                    { new Guid("40a8ca6c-d424-435a-ba51-2c331949a1ab"), "207", "5495747669489262", null, null, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020"), "08/05" },
                    { new Guid("40ea9065-3a6f-4465-a8a4-c2443155975e"), "715", "2376562276635294", null, null, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33"), "05/16" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("422a5c1d-7b24-4195-b7da-73ebf7cd5ac7"), "492", "2327464052293964", null, null, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930"), "06/16" },
                    { new Guid("424cb9e7-fc87-46f1-8d58-32a3dc4f2475"), "019", "6694930969908986", null, null, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982"), "04/12" },
                    { new Guid("424e5226-cbb8-4799-86ab-ded3e72241af"), "813", "7670837900094319", null, null, new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0"), "10/04" },
                    { new Guid("42efc172-cad8-4923-8ede-021785317e3e"), "360", "2880835867411937", null, null, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304"), "05/24" },
                    { new Guid("4321cf9e-ed60-4101-bf58-38e6699cf7db"), "357", "9426664723933707", null, null, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e"), "01/18" },
                    { new Guid("43e14682-70a7-44d3-ad41-202363108245"), "961", "8153179010910294", null, null, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b"), "03/12" },
                    { new Guid("441e49f8-c5ec-498e-92c5-7c3ff6db27ec"), "672", "1834197112071676", null, null, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3"), "06/22" },
                    { new Guid("4444a1de-5431-4568-8aee-5e753a01a90f"), "839", "7417357341974165", null, null, new Guid("549f6398-46f0-4e11-bc59-43c056078f96"), "06/01" },
                    { new Guid("444e7d55-90ad-4a04-b89a-755f70c41b7f"), "596", "8023067669623097", null, null, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52"), "09/03" },
                    { new Guid("44cda894-bfcc-4abb-83bc-ca2cbf2896af"), "468", "7300131881170165", null, null, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2"), "09/17" },
                    { new Guid("452bd6d0-129f-48e3-8194-7a770e83671b"), "894", "6440430322187503", null, null, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304"), "06/01" },
                    { new Guid("458d023d-d341-4e8d-9943-275be73749d5"), "531", "4454233649175485", null, null, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77"), "06/13" },
                    { new Guid("4599e882-90c3-4386-b49b-170dc1723a47"), "150", "9303900850275973", null, null, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6"), "09/15" },
                    { new Guid("45b81117-56e7-42e1-9672-4323a76ef9f8"), "396", "4275220537582464", null, null, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217"), "10/11" },
                    { new Guid("45c3f4d9-f3f9-4237-985f-a5795c89061e"), "781", "7723266289876505", null, null, new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262"), "01/11" },
                    { new Guid("463bba3d-405a-4574-9f06-627dfb2da986"), "067", "5878357460159648", null, null, new Guid("6d717976-193a-4962-947b-f15277ce537e"), "01/21" },
                    { new Guid("47a48fef-e072-4e61-957a-4bbd0f9f7326"), "156", "4797232132609058", null, null, new Guid("2f049da2-3389-49ff-a450-f063e5a81fee"), "03/10" },
                    { new Guid("47a737a4-d901-4c28-80a1-8f8f8945367c"), "852", "4012605309662705", null, null, new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb"), "12/23" },
                    { new Guid("47be46ed-f2e1-473f-bf12-b9dbf9653b51"), "733", "2218707850649066", null, null, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4"), "09/15" },
                    { new Guid("47d64935-bcce-428c-9a1f-fdae364a90dd"), "085", "3592668659317882", null, null, new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d"), "10/21" },
                    { new Guid("47dbe2b7-e925-43b6-adaf-0360bab07b1f"), "278", "2088293622686008", null, null, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a"), "08/02" },
                    { new Guid("47f468ed-c458-48cc-99a0-b5acf55c9b80"), "974", "4874171725375327", null, null, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9"), "03/14" },
                    { new Guid("496c9e6f-7ce1-4129-9481-c57c7eb927aa"), "384", "9763987545740406", null, null, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d"), "09/22" },
                    { new Guid("497ff076-3c13-4a29-8b25-cf80b5ed7403"), "698", "8336999643379758", null, null, new Guid("812d963b-edbc-48b1-948d-661ea6f9d645"), "06/11" },
                    { new Guid("498b6080-b420-44c1-b0bf-257821bf6959"), "201", "8870501939039214", null, null, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa"), "05/27" },
                    { new Guid("49917e67-9373-4630-85c9-264a2e747829"), "355", "7234364974212008", null, null, new Guid("1144670b-de30-428e-9356-066b18301c96"), "08/24" },
                    { new Guid("49ef578a-c83d-4d22-b8fe-a98f78d4e08a"), "665", "1653004573619177", null, null, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6"), "12/13" },
                    { new Guid("4a0e1482-41c2-4142-9079-b85f03bb36c9"), "725", "4728248289716152", null, null, new Guid("067bf875-8a96-48a0-978d-10d890bd7318"), "11/15" },
                    { new Guid("4a424794-29c6-419f-af69-c250891833ac"), "444", "9371108021388599", null, null, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e"), "12/23" },
                    { new Guid("4a6bd71b-5bf5-4d0a-9173-6d2347e07672"), "637", "1088652322197372", null, null, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10"), "07/17" },
                    { new Guid("4a7f967c-3f61-4a62-ab70-cbe2a7171b0b"), "313", "8988339859604741", null, null, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945"), "07/21" },
                    { new Guid("4a8c203d-598d-4010-90f1-3242d7f6dd25"), "473", "5548423696281966", null, null, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086"), "06/12" },
                    { new Guid("4acdcbb6-45b9-4459-b328-402c1d5deff7"), "384", "8615346253514728", null, null, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535"), "07/25" },
                    { new Guid("4b123faa-4c38-448c-9665-2cb520de1461"), "073", "8125050244899686", null, null, new Guid("1144670b-de30-428e-9356-066b18301c96"), "11/03" },
                    { new Guid("4bb4aab2-5ece-4c17-8c2f-7679025786d5"), "665", "7838210835948639", null, null, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9"), "03/12" },
                    { new Guid("4bb9b18f-0264-4bd3-827b-488730f77ed8"), "313", "7435178751642988", null, null, new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77"), "05/25" },
                    { new Guid("4c078193-0529-420d-b9be-fc04f8a713f6"), "623", "7760780406364966", null, null, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177"), "09/23" },
                    { new Guid("4cf14515-965e-429c-a9cf-ef05b3a6a969"), "935", "2535352527474481", null, null, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8"), "08/28" },
                    { new Guid("4d085c8e-bbfb-4bc8-bfd5-5fdffc7be3e6"), "980", "4559411782980669", null, null, new Guid("eada0502-f63b-424a-9d81-244529d74dc1"), "09/11" },
                    { new Guid("4d2ab2ad-1722-41a4-865a-ab44d2cbab36"), "980", "3758721717359476", null, null, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c"), "02/02" },
                    { new Guid("4dd01404-5651-42fb-914f-d3c186de265d"), "602", "5336778850125738", null, null, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7"), "12/11" },
                    { new Guid("4de3b458-5bdb-45a4-9fa8-257819ac1dba"), "316", "4455457126231081", null, null, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c"), "12/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("4e46282c-c03b-4408-a59b-5c4131b6f9bc"), "295", "1854534494764494", null, null, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b"), "10/24" },
                    { new Guid("4e7b893c-ecf9-434c-bced-e6d9e710fd65"), "416", "2042579338411802", null, null, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77"), "02/13" },
                    { new Guid("4edb56e3-7c5b-4ad8-a9cf-8636cea2ed27"), "885", "3802143805625267", null, null, new Guid("6d717976-193a-4962-947b-f15277ce537e"), "02/06" },
                    { new Guid("4efb3d71-5593-4d4c-8549-64778f089877"), "521", "7607967118463020", null, null, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d"), "02/09" },
                    { new Guid("4f16fe0f-5353-4602-b106-c0cded325f10"), "285", "7075817866797977", null, null, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5"), "05/27" },
                    { new Guid("5028cdc8-6a10-485c-95ae-b53c5e0a66bd"), "643", "2126589577846370", null, null, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7"), "05/11" },
                    { new Guid("50bdc2a9-1f96-4b48-b647-6f7f1e5686f1"), "936", "3301119349870017", null, null, new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919"), "12/17" },
                    { new Guid("52449e10-9cac-4d36-98f9-f68c3286a824"), "365", "7596542917440263", null, null, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a"), "07/12" },
                    { new Guid("5284001a-0de3-4fad-a318-e9996ab8103e"), "269", "1879408309483009", null, null, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff"), "03/06" },
                    { new Guid("528b72ba-fe11-47ec-8e52-9a2a67ced2d1"), "015", "2947140897929879", null, null, new Guid("549f6398-46f0-4e11-bc59-43c056078f96"), "02/04" },
                    { new Guid("5339398f-f417-4b77-bca5-56ee78848d59"), "534", "7794730902329731", null, null, new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315"), "01/21" },
                    { new Guid("53baa6e3-addc-4480-a8d4-b282e5f7d065"), "412", "6247167780546410", null, null, new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10"), "12/17" },
                    { new Guid("53dd2bab-6901-4546-9032-d4c92c58b8f2"), "659", "2097659361494347", null, null, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9"), "09/10" },
                    { new Guid("5498b38d-1a29-4cbf-8f45-a0b0141ee040"), "422", "3710564874808129", null, null, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9"), "05/07" },
                    { new Guid("54bcf211-41e1-4e59-96bc-54548b88546d"), "245", "2051101644643794", null, null, new Guid("a030d800-7dee-4af6-9714-7607209659cc"), "01/02" },
                    { new Guid("54d3f376-a7ed-49ea-b62b-430804d7e0f6"), "161", "3629604654472042", null, null, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33"), "02/21" },
                    { new Guid("550a100b-79f2-4303-b56c-a97b0d4daac4"), "833", "4303841761706000", null, null, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), "11/22" },
                    { new Guid("55300796-e86c-4825-a6ce-b65b77b02025"), "629", "2576017667873258", null, null, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4"), "05/21" },
                    { new Guid("5548eb46-54c3-44c4-91a0-7fb6d06260c9"), "799", "9685801308973686", null, null, new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1"), "04/19" },
                    { new Guid("55647a96-ef2b-423f-a450-587570bc326a"), "136", "9709463853220129", null, null, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52"), "10/10" },
                    { new Guid("5592425d-3a43-4d78-9459-3de3eb0ac777"), "129", "7417940441966856", null, null, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01"), "07/23" },
                    { new Guid("55ec82af-3051-471f-8f68-2bad0326bae6"), "846", "9432192281533832", null, null, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7"), "07/04" },
                    { new Guid("56a7b9aa-e562-448f-a876-93d5f298ac46"), "854", "8614246064591774", null, null, new Guid("1144670b-de30-428e-9356-066b18301c96"), "08/06" },
                    { new Guid("56ea00cf-3dd3-427a-b124-58a21ce07fa2"), "273", "2644078332349991", null, null, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8"), "06/11" },
                    { new Guid("56f69070-a700-4b64-970c-63dbfd7d2c88"), "680", "6507511518176206", null, null, new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df"), "03/17" },
                    { new Guid("574ca434-8acf-4b5b-bb11-7e6903137762"), "957", "7515331277405110", null, null, new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce"), "10/27" },
                    { new Guid("5751231e-bfcd-4508-aab9-cb7335635d18"), "752", "5285464641494383", null, null, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa"), "09/13" },
                    { new Guid("575a4551-e7d1-4c78-a290-d0291c384438"), "419", "6369904379617441", null, null, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434"), "01/01" },
                    { new Guid("5770057b-2e1c-4d3a-bd09-4d8629d87419"), "336", "5785788557838063", null, null, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7"), "10/25" },
                    { new Guid("581ce7da-6934-4283-9c3f-0ccf7e4114aa"), "979", "8444514722548769", null, null, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65"), "05/28" },
                    { new Guid("58410624-6d97-40d1-9d78-9a81a0dbcdad"), "089", "2026166028308425", null, null, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd"), "09/12" },
                    { new Guid("58583865-fc9d-4503-a5cb-4434e89c8ce4"), "207", "6658328238067535", null, null, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef"), "05/05" },
                    { new Guid("59d0e00a-5fc3-44da-a576-1d2937f14b2f"), "575", "4362255211275283", null, null, new Guid("671bbcc1-9768-4630-8a24-d7626303ad52"), "10/14" },
                    { new Guid("5a5ef3c3-36ec-41a8-93cd-cd225f1bb8df"), "543", "6518446249055753", null, null, new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93"), "08/02" },
                    { new Guid("5ab990f4-a5a1-4639-9963-8add4e0aa406"), "474", "3304065375137401", null, null, new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3"), "07/06" },
                    { new Guid("5b46e707-efa6-4c64-bac4-8d3e229f21f2"), "919", "5214555278977571", null, null, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65"), "04/03" },
                    { new Guid("5b51dc18-40ca-40cd-9dd5-548053b3d54e"), "928", "7063291440620437", null, null, new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546"), "08/10" },
                    { new Guid("5b5d72ec-ac6f-495e-8c92-9a6b23b0d7c8"), "166", "8156512173670741", null, null, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee"), "09/09" },
                    { new Guid("5b9b8632-8980-48a3-83d3-ead6697c71b3"), "261", "3196167373306411", null, null, new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22"), "04/07" },
                    { new Guid("5baa38b5-763b-4a1b-a4ac-0567487d80ad"), "243", "1247149016669273", null, null, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff"), "09/08" },
                    { new Guid("5bad7f8a-bb1a-43f5-b6e1-a8a234ca4833"), "655", "8805209637349287", null, null, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020"), "08/05" },
                    { new Guid("5bc4e834-0672-4002-91aa-c74ff7201b72"), "301", "7651107382543620", null, null, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1"), "06/25" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("5be874cb-b929-4ff2-b445-2a14053e32b7"), "386", "7986288613103374", null, null, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7"), "09/02" },
                    { new Guid("5c0a595d-5476-4737-b8e5-c316d5cd372a"), "788", "8329526646166446", null, null, new Guid("45dee853-0743-493d-b80b-c81b944cc529"), "08/06" },
                    { new Guid("5c103ca3-5c08-42c5-bde4-b8d3334fd8f1"), "714", "3856628386665182", null, null, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05"), "05/17" },
                    { new Guid("5c176627-3375-4f6b-8ffa-2e9b0bba61b8"), "143", "8538361454551689", null, null, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92"), "10/18" },
                    { new Guid("5c283503-ef8c-4f0f-a431-46190ade8f3c"), "745", "9219595969842713", null, null, new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315"), "04/16" },
                    { new Guid("5c6ded2a-a09c-4808-8220-28a791a804da"), "489", "1437703119677042", null, null, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086"), "04/12" },
                    { new Guid("5cf608d8-7c6a-4d0d-8550-b7873027f771"), "687", "8247281994036901", null, null, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14"), "05/10" },
                    { new Guid("5d12090d-57e2-4495-8ef7-56bfedf97d1f"), "093", "2848239816929278", null, null, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b"), "04/06" },
                    { new Guid("5db65c61-eafc-4499-b43e-071924813154"), "868", "9464566228780439", null, null, new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8"), "07/08" },
                    { new Guid("5dde8b49-f15f-49cb-9458-e298aa8ab753"), "519", "7287793297444475", null, null, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6"), "03/23" },
                    { new Guid("5df221b1-491f-4426-b3e1-efb0c1d4edd9"), "173", "4891404914010046", null, null, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc"), "02/05" },
                    { new Guid("5f131ae1-eaaf-4538-8bdd-d63fdd8b1868"), "811", "3155367788662381", null, null, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a"), "07/12" },
                    { new Guid("5fd657d2-7921-4590-b483-e04e2cef815e"), "522", "3473058636791458", null, null, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304"), "11/06" },
                    { new Guid("600d7a78-fce9-4956-a8ca-d89354a541be"), "789", "5898979110843056", null, null, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), "06/01" },
                    { new Guid("606a6401-c068-46c2-8aef-e389fcd25fff"), "437", "7217429303641938", null, null, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc"), "03/28" },
                    { new Guid("60bdc654-0253-4f3e-9d34-ce48858bd890"), "847", "5365054260745450", null, null, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7"), "02/12" },
                    { new Guid("616a7020-6620-401a-8507-2412f6b86107"), "151", "1242565537400685", null, null, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0"), "06/21" },
                    { new Guid("61c1ba0e-3578-4c12-9e12-d4ff4102fd0b"), "353", "1336267150733625", null, null, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b"), "03/19" },
                    { new Guid("624fb0c3-7da6-403b-9261-18593cebe711"), "573", "6367732954814677", null, null, new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240"), "07/08" },
                    { new Guid("62b79355-f1e9-4fde-b11f-d80db2c47eaf"), "648", "2448535054412806", null, null, new Guid("13cc902b-ca01-4670-ab3f-def800c89833"), "10/12" },
                    { new Guid("62e9f5ea-be24-43b5-9707-b77d8d6d16e9"), "834", "2838882116412902", null, null, new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5"), "01/17" },
                    { new Guid("6441550b-d0f5-4bef-abea-dcaa2c017522"), "010", "2510821277983174", null, null, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6"), "02/21" },
                    { new Guid("644f278a-849c-48a6-981e-c272f637a31f"), "116", "1828768924343835", null, null, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5"), "02/08" },
                    { new Guid("64685a73-0c75-41a1-98b8-573c5d4dbe91"), "232", "6484328975655151", null, null, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d"), "10/08" },
                    { new Guid("64ecd360-752a-4be0-a034-c627632aeab9"), "672", "9375798261750711", null, null, new Guid("be28704f-919b-414b-b444-7bf3be5f0534"), "10/28" },
                    { new Guid("651eaf19-c84d-4df6-a2fb-463ece1b2b01"), "634", "2755191428254325", null, null, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee"), "07/15" },
                    { new Guid("65ddc807-a4b1-4d56-9103-86bcf05ff7ad"), "239", "2578660089838484", null, null, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651"), "08/15" },
                    { new Guid("664cac4d-5126-4361-bca9-388537928590"), "718", "2872928103768626", null, null, new Guid("7156fae1-f350-4998-b43f-3d5664953dc8"), "04/26" },
                    { new Guid("66bd270d-e8f5-40cf-b452-a96f8f5e3531"), "533", "1371123648420447", null, null, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5"), "04/08" },
                    { new Guid("66e755fe-7ac2-41b7-bea0-131508118761"), "377", "2691039893964606", null, null, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6"), "04/18" },
                    { new Guid("66f185d8-ba4b-4fad-8c71-889a0266e11f"), "710", "9703591584640478", null, null, new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75"), "03/24" },
                    { new Guid("6702da5e-979f-484b-a9a1-a56865c8a229"), "793", "8210534484653202", null, null, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d"), "11/14" },
                    { new Guid("6715e874-02a3-4583-967a-a1892e854438"), "684", "9743975380977039", null, null, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57"), "10/07" },
                    { new Guid("67f5c5b4-ab68-4215-a1f6-ce317d5443c4"), "010", "9196838687102801", null, null, new Guid("8d077a60-6583-4591-b84d-07adff60a1a0"), "01/03" },
                    { new Guid("67feab70-e6e9-4de6-9ed1-b1d9ecf2fa22"), "512", "8159829378820842", null, null, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd"), "09/28" },
                    { new Guid("681b3a97-e4eb-4a16-8de3-71e7664ec02f"), "962", "2136557781152057", null, null, new Guid("0b13afed-b734-4249-bae8-810ee4f78617"), "06/17" },
                    { new Guid("68532f62-b2d3-43fc-aefd-990cdebdbbc3"), "289", "1710148312587394", null, null, new Guid("6d717976-193a-4962-947b-f15277ce537e"), "06/07" },
                    { new Guid("685bdd1f-3a3e-4158-be64-0083a8fee571"), "713", "8306245761076697", null, null, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e"), "12/03" },
                    { new Guid("6862da17-68bc-4bb0-8799-dd6c38c71c36"), "164", "8553718417499099", null, null, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e"), "02/04" },
                    { new Guid("68d79c4e-6292-4e81-a0a5-a9b15647b9c0"), "124", "6843881121091158", null, null, new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400"), "07/21" },
                    { new Guid("68edfd35-6783-4a17-9cdd-e5807181c7b8"), "549", "5390008996406824", null, null, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e"), "03/26" },
                    { new Guid("693dbf82-9970-4e9a-b27c-798d920d40cd"), "456", "5261852408177326", null, null, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f"), "11/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("694ce0d5-b55c-4ec7-9614-bd4911c4b819"), "223", "9208656863174829", null, null, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9"), "09/14" },
                    { new Guid("6960e6eb-4802-4c0b-83d1-a4098af27afb"), "612", "8151104059658498", null, null, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7"), "02/19" },
                    { new Guid("6961aed4-431e-4bb6-8a5e-7dbf2eba1b4a"), "600", "8517243608815557", null, null, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), "03/20" },
                    { new Guid("697b9005-85c7-4404-b376-60af5c433e39"), "109", "3385729633084815", null, null, new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c"), "05/15" },
                    { new Guid("6a7f4f56-f0c2-4cd7-a50d-6933da168b71"), "093", "5489817063211755", null, null, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7"), "07/27" },
                    { new Guid("6acceab5-db02-4165-a5b6-7794e0395171"), "093", "2306406044009447", null, null, new Guid("8a966506-353d-46f9-91b9-9431f8562c71"), "12/17" },
                    { new Guid("6b34d5cd-d190-48b5-acb6-09b4b3895f03"), "718", "9131792347336097", null, null, new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51"), "02/13" },
                    { new Guid("6b4a65c3-4707-4de0-9289-9a2353420cf4"), "500", "1522431373854503", null, null, new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711"), "03/20" },
                    { new Guid("6b926ae9-0d3f-4a3d-96a7-d502f7473111"), "759", "4903741172512996", null, null, new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5"), "05/11" },
                    { new Guid("6bf77fe7-6277-449b-99ee-56db60ff49d5"), "543", "1318193524013769", null, null, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6"), "11/14" },
                    { new Guid("6c22674a-ab97-47bc-ae2c-64f9a9e001bb"), "866", "5592789193169314", null, null, new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8"), "06/27" },
                    { new Guid("6c69aa49-4e3c-4f6a-af39-c3db0305e1a6"), "043", "7244786903282072", null, null, new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0"), "09/06" },
                    { new Guid("6c728e30-c79a-4344-88d0-fe91482efc11"), "841", "4048443815492010", null, null, new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6"), "09/19" },
                    { new Guid("6caee14b-8d44-4769-8c5b-192e3b75f8c4"), "331", "4237548613614157", null, null, new Guid("ae750269-835b-481a-8e36-4dd8044f9527"), "02/25" },
                    { new Guid("6d2a658e-142d-4b00-9776-45225f07e40a"), "689", "8501570069908308", null, null, new Guid("be28704f-919b-414b-b444-7bf3be5f0534"), "04/02" },
                    { new Guid("6d512d9c-d9c2-440c-af7a-a2fdaba42a43"), "822", "2886839954448347", null, null, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03"), "08/18" },
                    { new Guid("6d54dac7-7c32-4f20-8412-4b5ff6efb570"), "050", "8730353222725493", null, null, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9"), "01/14" },
                    { new Guid("6dcdb023-3d63-40e1-99f4-4335ef8854dc"), "650", "5267004023422207", null, null, new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1"), "12/03" },
                    { new Guid("6e3279fd-de9e-46db-bac6-77c502e57f89"), "337", "3508171718664706", null, null, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d"), "07/19" },
                    { new Guid("6e82fb3d-08f6-4946-b65b-88b678033a20"), "200", "3668420902214122", null, null, new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37"), "11/22" },
                    { new Guid("6eae8fe2-97cc-401c-9a99-bb3282ea1886"), "456", "1653837919323738", null, null, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f"), "12/26" },
                    { new Guid("6f245fe3-df93-4136-be8f-194ab940d6ab"), "528", "9752756578809168", null, null, new Guid("eada0502-f63b-424a-9d81-244529d74dc1"), "08/24" },
                    { new Guid("6f3133bf-3839-4116-814b-96fa3b1ff15e"), "790", "7553125739120529", null, null, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756"), "02/19" },
                    { new Guid("6f326b05-4f5b-4287-a0a5-95a68ad08883"), "097", "7150305663575589", null, null, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c"), "07/12" },
                    { new Guid("6f6dec96-bd43-4c5b-b94a-4baa11be2bbc"), "576", "2425060533816997", null, null, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9"), "12/02" },
                    { new Guid("6fb6f490-51cc-4afa-a474-49f41615c1ea"), "462", "9481740121848898", null, null, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d"), "02/10" },
                    { new Guid("6fc088ef-1b7a-4f37-b2f7-0782f99321c5"), "069", "7603780533577982", null, null, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e"), "02/20" },
                    { new Guid("70c1002d-b9ec-40bd-b598-f82bb54ca89c"), "963", "2788402701850419", null, null, new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5"), "10/02" },
                    { new Guid("711f7ba4-8420-4a03-8a41-eb7df69554a2"), "635", "8552186787628125", null, null, new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3"), "07/08" },
                    { new Guid("71610994-eadf-4b91-be1d-16d39e0d8a65"), "267", "8753728545520324", null, null, new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9"), "06/26" },
                    { new Guid("716574e4-75e6-4842-9ee3-cebad47c1e89"), "542", "7705374647119011", null, null, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9"), "04/09" },
                    { new Guid("71a39d99-f980-409a-9906-4fe41fa97780"), "739", "8584184163940131", null, null, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75"), "08/04" },
                    { new Guid("71ab44d4-acd0-4663-901d-8f018c586cce"), "583", "7810570937835788", null, null, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e"), "02/16" },
                    { new Guid("72100d92-79fb-4cea-b285-3125d8f5aefc"), "959", "3945796711923850", null, null, new Guid("171184db-5baa-42f3-92d8-64b8e76c6165"), "04/18" },
                    { new Guid("724d7894-eca7-4ac9-8e7f-e4c09bb6e20b"), "348", "2390735268200094", null, null, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0"), "06/17" },
                    { new Guid("72c5a315-70fc-4997-ac36-ccba14c861ca"), "800", "5827986549830521", null, null, new Guid("a0935a01-c087-4387-9782-37219c8d05b9"), "04/03" },
                    { new Guid("72ca67ae-5b2b-4dfd-8d19-0cc5d3c11c23"), "208", "1608196095577268", null, null, new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c"), "08/06" },
                    { new Guid("732f934e-3b45-4b77-b6d6-89bf61afb687"), "400", "4988071704294852", null, null, new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6"), "12/27" },
                    { new Guid("73ba2c8d-25c2-415c-af52-9a4ceef59204"), "388", "7278479649276146", null, null, new Guid("31fbc085-c45f-4025-bc26-03836052f67c"), "02/13" },
                    { new Guid("73d6dff2-10ac-4a7c-8f97-d99308522da5"), "586", "7694677459738546", null, null, new Guid("d5908335-16ba-435a-9a9d-603eaee07878"), "04/27" },
                    { new Guid("744198e0-fbfa-4b4a-a7cd-96adfd2048f8"), "511", "2584255385585912", null, null, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6"), "07/05" },
                    { new Guid("74879f4f-c084-4a05-adb5-2377d4f023b3"), "861", "2199561339845129", null, null, new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070"), "06/06" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("74cce511-12d4-43ae-b1c5-f4f965438c06"), "730", "3344327948595660", null, null, new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0"), "12/16" },
                    { new Guid("74ed7fad-30dc-48a3-8681-3800b71331f5"), "343", "6144782077005509", null, null, new Guid("0b13afed-b734-4249-bae8-810ee4f78617"), "12/28" },
                    { new Guid("759b685b-4c57-417b-87ae-25bc659b263a"), "345", "4763430580759080", null, null, new Guid("24597285-23ce-4296-9004-36d913270ed6"), "09/03" },
                    { new Guid("75bebcec-74b0-4fbb-8c60-d12eba84816e"), "891", "3925866010068803", null, null, new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9"), "04/18" },
                    { new Guid("75d3f099-88ed-4d11-a200-cea852d69bcc"), "136", "6363074627778089", null, null, new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b"), "09/01" },
                    { new Guid("76599609-27a0-479a-85a7-cce2f1cf16c3"), "865", "7068887131373703", null, null, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6"), "02/01" },
                    { new Guid("767d9761-eafe-4e3e-a9ab-7e06079b7ac5"), "601", "8586154014345731", null, null, new Guid("45917911-5af0-4724-8a58-1fe212041071"), "10/02" },
                    { new Guid("76957839-5a9c-408a-9a16-852673f2a495"), "462", "4051101539150471", null, null, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217"), "02/07" },
                    { new Guid("76a9d66c-0beb-4a62-b4c6-eef640bc2b56"), "411", "9683080025295717", null, null, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "09/15" },
                    { new Guid("76c3890c-3ed2-4984-a161-12547ab76220"), "680", "8193793976462736", null, null, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7"), "03/11" },
                    { new Guid("76dfdd6d-7174-486a-9f0b-3ddd58fdadc6"), "070", "9736431383572617", null, null, new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3"), "03/01" },
                    { new Guid("76f15986-9123-492d-9e9a-f58e1605c869"), "739", "2948472837078040", null, null, new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de"), "06/18" },
                    { new Guid("775908be-5660-4136-b90e-8deac648b1a6"), "144", "1212063781103103", null, null, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4"), "01/26" },
                    { new Guid("778b0a32-a5c5-4a1e-a304-704e9cb7087b"), "690", "2096992527680258", null, null, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2"), "08/03" },
                    { new Guid("77fca8fa-9af1-4d81-9d57-c778a8c76b9d"), "505", "7624518933525906", null, null, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4"), "04/16" },
                    { new Guid("7845ce45-9ebf-4682-b7db-6fbecc1f20ee"), "915", "6267459336476410", null, null, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7"), "08/11" },
                    { new Guid("789b2a51-3f83-4f27-830f-bdaa397c85a0"), "175", "8365950940617873", null, null, new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b"), "05/20" },
                    { new Guid("78beb105-ff49-44c5-8c84-d3868462b59e"), "654", "1806842328015230", null, null, new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d"), "08/08" },
                    { new Guid("78c61f0a-5c75-4dc6-a359-db6a4f045b73"), "228", "3486661758999635", null, null, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4"), "04/08" },
                    { new Guid("78d5db6d-dd40-4e75-953e-1a5d383e8e18"), "261", "7446277497940029", null, null, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "03/01" },
                    { new Guid("79aeb867-43ec-401a-81ff-fa6f414a6a4b"), "337", "7118397548723900", null, null, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b"), "08/15" },
                    { new Guid("79b06568-59fa-4e71-86a3-f67247f26c5e"), "137", "2275805258189103", null, null, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36"), "10/25" },
                    { new Guid("79b55584-9451-4c4e-97d5-0e1e15af02fc"), "892", "3948106493054254", null, null, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434"), "03/06" },
                    { new Guid("79bb2e7c-2d4c-4eb2-8e12-45f01fd02f14"), "421", "9615871522875294", null, null, new Guid("d364b716-4b5c-4090-99d6-0f11b5849701"), "08/04" },
                    { new Guid("79d08194-3b59-4758-be45-b75b23053430"), "233", "8160877336349680", null, null, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982"), "10/13" },
                    { new Guid("79e848d6-9656-430e-9a0d-ed62320afb0d"), "179", "5524188229780976", null, null, new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8"), "11/24" },
                    { new Guid("7a52ba78-66d1-4127-9d83-d5f42c208d87"), "812", "8538352330078355", null, null, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "06/23" },
                    { new Guid("7a61754a-a533-4c45-a313-5b8dc32563f2"), "971", "2091803920881423", null, null, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de"), "12/21" },
                    { new Guid("7ad6b71a-b5d5-449e-a2f9-d08e18919fc6"), "545", "8630224558847436", null, null, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec"), "04/13" },
                    { new Guid("7b315efe-d0a2-4767-9726-c284488c26ce"), "654", "5603379133172198", null, null, new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a"), "10/12" },
                    { new Guid("7b645edc-f51a-4704-a050-d96b05577bf8"), "551", "7974800561327663", null, null, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4"), "02/05" },
                    { new Guid("7bbcde4b-858a-4c3e-857a-97474cc55831"), "018", "9052353361865586", null, null, new Guid("48cace70-1194-4581-914a-6aae6159826d"), "03/15" },
                    { new Guid("7bfd3468-fcd2-4fb9-9554-6dcfda27aac1"), "875", "5702578493449160", null, null, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9"), "09/04" },
                    { new Guid("7c1b18d0-ac11-485b-8835-6f437fba6a32"), "572", "4293214147342039", null, null, new Guid("31fbc085-c45f-4025-bc26-03836052f67c"), "12/13" },
                    { new Guid("7c1fc465-490c-4887-bd7f-c2c21e84effd"), "488", "8550820547444515", null, null, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0"), "01/04" },
                    { new Guid("7c5eae6c-c524-4ca2-8810-e1eadd68faa1"), "928", "9768227498391730", null, null, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086"), "04/05" },
                    { new Guid("7ccabd14-b44c-4e75-8e39-04088b4ffe86"), "224", "2671926293846247", null, null, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6"), "03/28" },
                    { new Guid("7d330230-59b3-4c5d-ae24-7d7ee70493ef"), "917", "6292931173556093", null, null, new Guid("fd051a5e-4258-4bbf-b64a-29676b007443"), "05/15" },
                    { new Guid("7dc415d1-94e1-4b48-9f62-cfdbba175c17"), "630", "3376361184433986", null, null, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1"), "05/12" },
                    { new Guid("7df6e412-59c2-4ca3-bdb0-785b8776421e"), "280", "4346073304942418", null, null, new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b"), "08/14" },
                    { new Guid("7e050541-7a62-429c-9fd4-7dc3fe249aa6"), "901", "3001277509705512", null, null, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), "10/03" },
                    { new Guid("7e1ccb56-52cf-4a6d-b499-e2156862a124"), "465", "5562695490277178", null, null, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc"), "07/08" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("7eb673a9-7492-4cf0-b67e-862c4084ba88"), "388", "7943904856392222", null, null, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18"), "02/25" },
                    { new Guid("7efdc610-71fc-4ae0-9cd6-deb13ad0ec9f"), "843", "6763402688785194", null, null, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f"), "07/09" },
                    { new Guid("7f2db820-ffe1-436a-90d9-38d5e01a0b20"), "482", "1868294953933520", null, null, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa"), "04/10" },
                    { new Guid("7f47e9b0-3fbe-41ba-a884-7a5de586f4d1"), "359", "8140331927436739", null, null, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4"), "11/04" },
                    { new Guid("7f47fb9b-c794-4147-9c51-9789f44ad49d"), "503", "6574855446616880", null, null, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561"), "11/07" },
                    { new Guid("7ff94367-edd4-489e-9073-32a6b6fc6809"), "775", "3392036038807220", null, null, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6"), "04/04" },
                    { new Guid("801819e4-fdc7-445a-bad1-62cbb37dcae1"), "112", "1195491931455610", null, null, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1"), "07/22" },
                    { new Guid("8040d5dc-b3d2-4d94-9b79-688dda688bfd"), "441", "5571843254272573", null, null, new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c"), "12/26" },
                    { new Guid("807b1365-81da-4879-a811-4272cafd689f"), "236", "2777185241064026", null, null, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18"), "09/22" },
                    { new Guid("80b827ce-e8c2-4dbe-aafe-bcb7abde69d0"), "834", "1452895761672774", null, null, new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f"), "10/28" },
                    { new Guid("80ea3c0b-76fa-4b7b-a3c6-d7d094f48c9e"), "964", "4074076686433707", null, null, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad"), "09/14" },
                    { new Guid("81407ad4-c568-4f23-81bb-d02d933899c3"), "368", "2308424300286822", null, null, new Guid("24597285-23ce-4296-9004-36d913270ed6"), "05/26" },
                    { new Guid("81893b80-5d9c-4e4b-8c5e-bdf2488142b0"), "192", "6741606560457126", null, null, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e"), "02/19" },
                    { new Guid("82fc9175-ddf2-4c22-ac34-8a235a5498ee"), "286", "1871716712087117", null, null, new Guid("302771bc-d672-48ae-9a96-c489ccacf75a"), "08/26" },
                    { new Guid("83372ed7-40eb-46e6-b886-4d27a6e2a475"), "669", "8776133355755699", null, null, new Guid("fc218112-8b42-4598-a25c-227112647fca"), "07/06" },
                    { new Guid("8354c2b6-56dd-4ca8-8cdb-b5df2a5b3205"), "560", "4474766893369763", null, null, new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37"), "06/08" },
                    { new Guid("83b96e5a-dafd-4ef6-9ca0-a0d981607da2"), "905", "9657066394119267", null, null, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92"), "02/18" },
                    { new Guid("83c0be9b-a65e-4393-b86d-c4a728854f0e"), "167", "1681915934171695", null, null, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee"), "07/21" },
                    { new Guid("83d2f26b-f333-40c6-9793-bcd54f5c5a4e"), "296", "4503699782519006", null, null, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6"), "11/24" },
                    { new Guid("83eda717-df80-44a3-9265-e9c44c6fd535"), "473", "5153510672750875", null, null, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86"), "09/26" },
                    { new Guid("8497b811-f1f4-4f43-8df0-86be696ad269"), "891", "7229755355688446", null, null, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0"), "12/14" },
                    { new Guid("84c5ad3b-0169-4022-a6c6-4d87ddb23d2d"), "970", "8965704152669135", null, null, new Guid("d364b716-4b5c-4090-99d6-0f11b5849701"), "05/23" },
                    { new Guid("84cce39e-e3ab-4d0c-bfe3-ca1914799e81"), "226", "9555674293624670", null, null, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca"), "01/06" },
                    { new Guid("85251d9d-b173-4935-96da-1d5182ff8eb9"), "399", "8292572802613123", null, null, new Guid("929221d7-8d45-4a44-b501-41a47c26cf44"), "04/24" },
                    { new Guid("853b57e0-90d6-4061-a183-88d171367c02"), "440", "8487863852638212", null, null, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d"), "06/21" },
                    { new Guid("854bcb92-a304-482b-a69f-e5dd2a406cf4"), "591", "7109450062113535", null, null, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14"), "03/25" },
                    { new Guid("857f593c-bf4a-40e4-8a56-048263cbe583"), "425", "3452491838373254", null, null, new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2"), "04/25" },
                    { new Guid("863eb907-ad7b-4fd0-9211-1140b703ec33"), "531", "2394311714283696", null, null, new Guid("0b13afed-b734-4249-bae8-810ee4f78617"), "06/13" },
                    { new Guid("8737a21d-b2ad-4588-90c9-9c2e47c7a0f8"), "438", "7514656378348296", null, null, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3"), "07/26" },
                    { new Guid("87e5e977-f42e-4808-bb16-432c431933ad"), "541", "2230570716855808", null, null, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982"), "08/12" },
                    { new Guid("87ea5ae5-0314-4c66-ada4-61711e32f12a"), "493", "6417734040183911", null, null, new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b"), "07/23" },
                    { new Guid("886fb56d-cb45-41e9-80fe-8c9ab66b925f"), "174", "3631063268905051", null, null, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc"), "11/04" },
                    { new Guid("890b5cb2-8285-4f7a-8629-18ce7b0fcd7a"), "362", "4631081969754494", null, null, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445"), "10/28" },
                    { new Guid("89497c79-301a-4612-b054-c754a956e196"), "026", "7136073501114875", null, null, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57"), "04/05" },
                    { new Guid("8997ca14-273e-43ea-b77e-f304cc792bd7"), "964", "8388509506903152", null, null, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2"), "08/08" },
                    { new Guid("899c0072-f3e8-49f4-8a27-350c1f978721"), "020", "2905173985867724", null, null, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561"), "08/10" },
                    { new Guid("8a053216-5c9a-4b45-9a21-781beff43658"), "297", "3240577719793170", null, null, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18"), "06/26" },
                    { new Guid("8a334076-6a4a-4213-893f-53c2772e0b56"), "226", "6297512916097727", null, null, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd"), "10/15" },
                    { new Guid("8aa392fe-48d6-4ef6-8c8f-c3b7e31bc99d"), "752", "5642592752909065", null, null, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c"), "12/03" },
                    { new Guid("8b0062d2-cc33-4920-b84f-ef308dc33bb3"), "644", "2131449981107451", null, null, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e"), "08/17" },
                    { new Guid("8b0dfaa2-0422-495e-9ea5-2ff3853a0b1f"), "692", "7720422610045834", null, null, new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35"), "12/08" },
                    { new Guid("8bd7a0bf-9b5a-46e7-8e57-a57b525306f7"), "778", "6362957793503075", null, null, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "06/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8bf15e03-8c80-4430-bf55-a8d00552a39d"), "253", "9759885125413268", null, null, new Guid("302771bc-d672-48ae-9a96-c489ccacf75a"), "01/12" },
                    { new Guid("8c6538c8-b689-4f12-b013-afc0a57f14e4"), "929", "5862846419576570", null, null, new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0"), "10/06" },
                    { new Guid("8cab4bbf-9b2b-49f8-8dd5-18f00db77a53"), "680", "3168450417583720", null, null, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa"), "08/25" },
                    { new Guid("8d681f5c-267c-4e81-8c0d-4aace48388e8"), "568", "6912168895702975", null, null, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1"), "06/22" },
                    { new Guid("8dedcaba-8552-445a-8f85-9d310873da89"), "020", "8030842629939891", null, null, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07"), "06/06" },
                    { new Guid("8e5a9dd5-886a-4259-a692-56110af8448b"), "196", "6897291307492809", null, null, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413"), "10/02" },
                    { new Guid("8e61e027-9911-4471-a30f-2613c418f86e"), "966", "8633448255173096", null, null, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217"), "12/21" },
                    { new Guid("8e669235-9a7c-44cb-a045-cdd15ce9341e"), "372", "5768083962668318", null, null, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a"), "01/19" },
                    { new Guid("8e882834-6b6e-42b7-a66a-248bda01f4a8"), "420", "8142763274809675", null, null, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75"), "12/23" },
                    { new Guid("8e8f348d-d160-4ea9-a0ea-0d3ef032a7aa"), "983", "4573540547525683", null, null, new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37"), "03/19" },
                    { new Guid("8eee3383-1219-4f47-9f97-9d0fd43888f0"), "992", "4453588272616747", null, null, new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1"), "04/01" },
                    { new Guid("8fb5abde-fccf-4d36-864a-a92bdbbfa3d9"), "095", "5884289522880011", null, null, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03"), "11/02" },
                    { new Guid("908eea9c-c7d6-4658-8367-7ca257604311"), "099", "3479331824495455", null, null, new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b"), "07/16" },
                    { new Guid("909228ce-4e28-4985-a6a9-3de43eba33ef"), "653", "1819208301543035", null, null, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18"), "10/23" },
                    { new Guid("90bc599c-522c-42a4-9516-5d4a8bdbccee"), "944", "9418134042493039", null, null, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535"), "01/18" },
                    { new Guid("90ea6f0f-15f1-4da4-9b7b-daf9459845d3"), "822", "3296994019781549", null, null, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0"), "10/23" },
                    { new Guid("91305757-9097-443f-909e-ee7b9d66bd1b"), "744", "3890382192734486", null, null, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2"), "04/04" },
                    { new Guid("91581181-f53c-4347-8d04-d88a30ac5164"), "258", "5679019212766266", null, null, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc"), "09/09" },
                    { new Guid("917b2bd5-d8cd-4a7c-891b-1b3f4af84a74"), "954", "6996877338122182", null, null, new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11"), "08/13" },
                    { new Guid("91e5e9d7-aa0c-4714-b1bb-48a628b35b87"), "032", "3156958523953427", null, null, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7"), "06/25" },
                    { new Guid("92d270cb-1967-4552-8dcf-566227d2d171"), "089", "1008756982516762", null, null, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1"), "04/20" },
                    { new Guid("935afd8d-aef6-4067-8ca1-35d42600bf23"), "694", "8938607400972792", null, null, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76"), "08/27" },
                    { new Guid("93b386ce-4dff-4eb0-ba78-6f72292bc409"), "291", "9407528098112676", null, null, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd"), "08/20" },
                    { new Guid("9480bdf0-6447-4839-a918-bc5094034d37"), "267", "4051280032447482", null, null, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235"), "12/09" },
                    { new Guid("94e612fb-cc68-4ad3-8b24-c6d25cbc02a9"), "075", "2801377361693044", null, null, new Guid("a0863958-35de-49a9-a73b-decb03e0c871"), "06/11" },
                    { new Guid("95bcd807-95d3-48fe-8156-1b826c7021a2"), "330", "1888884827409348", null, null, new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0"), "10/01" },
                    { new Guid("95f22d41-5329-43d8-8a4b-d5324c1b6347"), "576", "1415250979571786", null, null, new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7"), "07/08" },
                    { new Guid("967e2132-9bda-4a09-ae1e-051e8ce149ba"), "291", "5011873889092975", null, null, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c"), "07/01" },
                    { new Guid("96f01579-7c4b-44f3-930a-952a275df580"), "931", "2477034035708507", null, null, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca"), "04/07" },
                    { new Guid("9739a801-44f3-44ca-9ea3-89468d63d876"), "996", "8628429377008188", null, null, new Guid("b15da029-129e-47f2-8442-a8831d78a2c0"), "11/06" },
                    { new Guid("9805160c-38f3-4463-b31e-4986f196e69d"), "966", "8283032394084172", null, null, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651"), "02/16" },
                    { new Guid("991a2f42-e1c5-4a83-abf0-2205ac739b9f"), "023", "9164698598486584", null, null, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d"), "11/26" },
                    { new Guid("9948618b-af3d-4e2c-abf2-e6a367e826cb"), "429", "4331534632003395", null, null, new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a"), "09/26" },
                    { new Guid("997fb736-d918-406b-907b-72c738479430"), "464", "4392796896220554", null, null, new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94"), "07/26" },
                    { new Guid("9988a6a0-8be1-47fc-89b7-0f015064eaa7"), "042", "7111134714896223", null, null, new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd"), "07/17" },
                    { new Guid("99cacae2-285a-4752-8147-58f23d06bb8c"), "911", "4168226341976271", null, null, new Guid("48cace70-1194-4581-914a-6aae6159826d"), "02/21" },
                    { new Guid("99e22faa-61d6-4eee-870f-7c6e0f920602"), "807", "5897351488516733", null, null, new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6"), "09/07" },
                    { new Guid("99f47cce-ca52-42eb-b6f1-3ede9aad3e3f"), "252", "2487840326470136", null, null, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9"), "01/10" },
                    { new Guid("9a4f0a36-fad5-410a-a49d-f1ca818ec35f"), "502", "2011498914039694", null, null, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), "10/01" },
                    { new Guid("9ac8fdd2-a88f-485d-8497-f6d55fbfde02"), "276", "1297831629074844", null, null, new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de"), "10/11" },
                    { new Guid("9b4845f8-b7c3-4e4a-a146-4d60dce86ca7"), "596", "8484204802115345", null, null, new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3"), "08/19" },
                    { new Guid("9b4f035f-f070-4de2-ab6b-e14917c0dda0"), "906", "7526879630130239", null, null, new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070"), "12/27" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("9b7bd5e7-fc8a-4a44-8694-b2b05789c00d"), "919", "3983160327039545", null, null, new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf"), "07/27" },
                    { new Guid("9ba2e182-81c5-4fcb-89f0-d71c8a97266c"), "888", "1250521401292575", null, null, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2"), "08/20" },
                    { new Guid("9bd12a08-90fb-409c-886c-b0b849ebe7e2"), "859", "4344329642412773", null, null, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4"), "10/14" },
                    { new Guid("9c0e6cb7-1b77-45d3-abe3-0b4452394d4c"), "701", "9370785037231690", null, null, new Guid("63684041-907c-4654-ab87-5f0c11008f52"), "08/17" },
                    { new Guid("9c7f424f-c1e5-4805-a68f-e7f6c454158a"), "076", "2481899919271561", null, null, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9"), "01/21" },
                    { new Guid("9cc5eaf8-162d-43f0-9c81-776f4cfc176c"), "610", "3133682895594582", null, null, new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc"), "04/11" },
                    { new Guid("9d50e72f-522a-47f4-9da4-17c685805586"), "686", "5521278418234755", null, null, new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a"), "02/14" },
                    { new Guid("9d6f64d1-54e2-4172-bc63-9bd58a105721"), "777", "6669100370059516", null, null, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0"), "06/09" },
                    { new Guid("9e478d25-a00c-4dc6-96aa-733e35381e61"), "421", "2819321571335352", null, null, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116"), "11/17" },
                    { new Guid("9e6f6475-c6d6-4f06-a561-a72c7f90b9e6"), "160", "7962506455030237", null, null, new Guid("24597285-23ce-4296-9004-36d913270ed6"), "04/04" },
                    { new Guid("9e9cc86c-1ea9-445e-8b75-5b948cfaa4e1"), "958", "3831947989074264", null, null, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d"), "03/13" },
                    { new Guid("9ed79c58-49cf-4ecf-a2dc-f69300797b33"), "277", "4032499166378221", null, null, new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d"), "10/20" },
                    { new Guid("9f378af7-2ae8-4452-9bfb-72d2a656e99f"), "448", "6167538565190463", null, null, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05"), "04/15" },
                    { new Guid("9f43c03a-0beb-4c8c-a483-e3a37a50915b"), "221", "2970924502848798", null, null, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc"), "07/15" },
                    { new Guid("9fc4f8c5-f436-4f2f-a9dd-0a969ee9807c"), "067", "4800142432590386", null, null, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca"), "02/26" },
                    { new Guid("9fe4e20a-8bda-4d4b-8a34-406d902f3b50"), "308", "5143767018581421", null, null, new Guid("45917911-5af0-4724-8a58-1fe212041071"), "02/25" },
                    { new Guid("a072674e-b3e3-43c6-8f27-8e67074122f6"), "336", "8118797389974625", null, null, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581"), "04/18" },
                    { new Guid("a07e8295-b6c5-4334-8e97-98d7eff71140"), "208", "7863876249519094", null, null, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448"), "06/03" },
                    { new Guid("a080eff8-06fa-4e25-9856-45f222e17047"), "771", "4525363630862819", null, null, new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad"), "01/19" },
                    { new Guid("a0eb53ea-1f12-43e1-aeb2-44175819ffa3"), "339", "2740227950189193", null, null, new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623"), "04/23" },
                    { new Guid("a0ecec17-f9f2-489e-b47e-5c34f7fd6f78"), "978", "5865560268685834", null, null, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2"), "06/17" },
                    { new Guid("a1314952-2a33-4ae6-b460-b8559bd569c2"), "055", "1239045397127192", null, null, new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84"), "11/12" },
                    { new Guid("a14724c6-e049-447e-a343-427efb546714"), "347", "6136451212739138", null, null, new Guid("067bf875-8a96-48a0-978d-10d890bd7318"), "12/11" },
                    { new Guid("a1f01e6e-ee0e-43b0-b212-c8893b4db7eb"), "419", "5111979611234847", null, null, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86"), "07/14" },
                    { new Guid("a20acd95-0c52-49ce-95b8-592812fa2399"), "499", "2907979084775246", null, null, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52"), "07/27" },
                    { new Guid("a266b923-18c7-467e-a379-2874f6a06eb8"), "786", "4487319086801371", null, null, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d"), "01/06" },
                    { new Guid("a27d6c24-b7a7-452d-aa8f-6ccbe57d4ce0"), "159", "5158865097550547", null, null, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756"), "02/25" },
                    { new Guid("a27eed0d-cadc-41c3-aa6e-fd7bf9234a52"), "488", "6287142488196913", null, null, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930"), "12/23" },
                    { new Guid("a2c883d9-1d2e-458d-bdc1-b53f0eb98ce6"), "241", "2156522749462385", null, null, new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c"), "12/24" },
                    { new Guid("a2df2ae3-75c9-4517-af78-e0da23125b78"), "614", "3410847183203789", null, null, new Guid("13cc902b-ca01-4670-ab3f-def800c89833"), "01/11" },
                    { new Guid("a31a3f25-ab0a-491f-a572-6d9a05713eea"), "914", "2168591151506980", null, null, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235"), "11/23" },
                    { new Guid("a357bb98-d81a-44ed-88db-acbf71910174"), "605", "3466900671252855", null, null, new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc"), "06/16" },
                    { new Guid("a3bf06bf-1046-4702-ba1b-6f18e6813633"), "187", "9578721503554583", null, null, new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962"), "10/13" },
                    { new Guid("a400f3d1-9471-415b-b50b-e8bf0a3e1791"), "444", "5954410619361390", null, null, new Guid("929221d7-8d45-4a44-b501-41a47c26cf44"), "10/18" },
                    { new Guid("a45bcae0-a97e-4d71-a69c-b16f9a3d956b"), "617", "7353902975112381", null, null, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4"), "07/21" },
                    { new Guid("a468ac58-9eac-47a6-a95a-2af5bde39ac7"), "596", "6867552967119796", null, null, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f"), "11/25" },
                    { new Guid("a4e4b5e1-78d1-42f3-a3e9-a3f99e48c703"), "570", "8670629744280635", null, null, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd"), "12/01" },
                    { new Guid("a551d33f-bf07-4b1e-ad20-86906e904838"), "706", "6687985646619915", null, null, new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d"), "03/06" },
                    { new Guid("a55a6c3d-5ff7-4445-a746-11f152d77c4d"), "369", "2076578350738741", null, null, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76"), "07/26" },
                    { new Guid("a5d152bf-6335-4607-913b-e2687ec78dcd"), "019", "2576348121554432", null, null, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5"), "11/03" },
                    { new Guid("a6108bf9-66ad-47c8-8f76-b83bb655b00c"), "907", "4371308755184021", null, null, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77"), "10/15" },
                    { new Guid("a6e1ae03-a73f-419b-aa5f-a11992368527"), "031", "5096728086768950", null, null, new Guid("a030d800-7dee-4af6-9714-7607209659cc"), "04/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a706b97d-99c7-4f47-8abe-c6a0d90e1724"), "723", "5272784819233316", null, null, new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f"), "12/11" },
                    { new Guid("a73e45b9-057f-46cb-a71e-1d43d32872be"), "573", "3724707463794051", null, null, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd"), "03/24" },
                    { new Guid("a74753ec-e6fe-4c86-bf27-f4ee6e48ce19"), "384", "6279396155030770", null, null, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d"), "11/09" },
                    { new Guid("a750390f-5395-4841-a676-dacf938c9e0b"), "087", "1561751152289179", null, null, new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e"), "09/01" },
                    { new Guid("a77ca24e-8fa1-4e6f-9db0-e7c89eded046"), "575", "3139543464483670", null, null, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570"), "09/27" },
                    { new Guid("a7c5f23e-d3a1-4f74-b79a-5210068c2e73"), "054", "6856221513854265", null, null, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9"), "10/13" },
                    { new Guid("a7db6aa0-63fe-4e68-b2e6-08c8d1d6d7ee"), "845", "2734335497952140", null, null, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75"), "12/28" },
                    { new Guid("a8189616-8040-454b-ae62-4fff9def8ef2"), "638", "9193177610877736", null, null, new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52"), "02/11" },
                    { new Guid("a81d4d2f-6fb2-4ad6-87ed-c37ee3960b8c"), "229", "1183231237316141", null, null, new Guid("13cc902b-ca01-4670-ab3f-def800c89833"), "11/04" },
                    { new Guid("a82c26ea-d3ab-48e3-8619-eec8bf66801b"), "076", "9091127184483005", null, null, new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b"), "03/10" },
                    { new Guid("a8696ed0-e150-4353-80d7-fa8da1dc402f"), "357", "6648548317307692", null, null, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc"), "07/01" },
                    { new Guid("a8aa7188-7a95-4b9c-bef1-ef1f969ae43b"), "559", "1284088191563803", null, null, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "11/04" },
                    { new Guid("a91e1f46-1c17-4425-bf4e-e4ad5dc433ea"), "001", "5544654930042747", null, null, new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1"), "02/17" },
                    { new Guid("a9233848-75ca-4116-8313-c7b06bebb5ef"), "594", "2794597498646998", null, null, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2"), "12/23" },
                    { new Guid("a9a9a7bf-5f5e-40eb-84a5-d294225aca31"), "967", "3580646173064116", null, null, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a"), "08/13" },
                    { new Guid("a9ac119a-9924-4913-9e14-cf440636a131"), "904", "1017674733889694", null, null, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5"), "05/17" },
                    { new Guid("a9efea12-522c-4f2d-a9b5-f2b7b291bde0"), "363", "3836254856033852", null, null, new Guid("a0935a01-c087-4387-9782-37219c8d05b9"), "10/24" },
                    { new Guid("a9f96d56-cf5f-41b4-8d9a-dc1c1453cfca"), "511", "6342106126830536", null, null, new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9"), "10/14" },
                    { new Guid("aa10f6a2-835f-492a-bc24-7d5bd6c01dca"), "343", "2407501674575806", null, null, new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a"), "06/21" },
                    { new Guid("aa31145e-12a9-4ed7-b80c-99b30477550f"), "050", "8367753425897937", null, null, new Guid("671bbcc1-9768-4630-8a24-d7626303ad52"), "06/27" },
                    { new Guid("aa4967e4-e44c-490b-9171-a12851b563fa"), "600", "4439548605047379", null, null, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), "08/25" },
                    { new Guid("aa73db25-5b59-40fb-869e-02bb75e57e4a"), "106", "7846034409850884", null, null, new Guid("42395499-af46-4c51-b3e8-47c97d474f85"), "11/10" },
                    { new Guid("aaadb6a8-4933-4a39-8160-906f08f57122"), "795", "9014995984036178", null, null, new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94"), "06/16" },
                    { new Guid("aadb8979-679b-4ae1-b549-b924c6bb63ae"), "466", "6371177002993940", null, null, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), "12/14" },
                    { new Guid("ab3ce9bb-36f2-4979-8623-82491ec662ec"), "400", "7246857908005969", null, null, new Guid("66bde12e-086d-4150-9c7a-89ea75047f12"), "04/12" },
                    { new Guid("ab4bdc2c-8847-469d-998a-36453530750a"), "170", "4243539894370892", null, null, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6"), "03/17" },
                    { new Guid("abaaf31d-1e1f-44ea-a5c5-5b0f1903ebf2"), "041", "4667736585538729", null, null, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e"), "01/24" },
                    { new Guid("abe5b618-b27a-47ae-b9b5-7d2c76d9f54c"), "508", "9936680434435549", null, null, new Guid("53078823-cbdb-4f6c-b393-57486464289a"), "05/24" },
                    { new Guid("ac591229-8a7b-4df7-850c-a98e43341402"), "920", "1595631198650390", null, null, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d"), "06/26" },
                    { new Guid("ac7383cd-574e-434f-a7a0-91ac161f7f90"), "421", "5076399691394927", null, null, new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1"), "06/12" },
                    { new Guid("acd9cce0-ca04-4d66-bfed-55151a9f062e"), "329", "4018085100938973", null, null, new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a"), "12/17" },
                    { new Guid("acda7a98-4543-4b9a-b2b1-f5ef3829b7e9"), "285", "7320458966800222", null, null, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e"), "09/04" },
                    { new Guid("acdb449f-28f8-43c0-a3f7-b2c98d52f53a"), "742", "2264294967685349", null, null, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca"), "05/22" },
                    { new Guid("acf34861-b3fa-4702-ba0e-6594d0b4ae6b"), "198", "4005451725213888", null, null, new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9"), "04/13" },
                    { new Guid("ad1141df-1aa2-4ea4-903d-672ba8f8f5d4"), "482", "5091750811554568", null, null, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4"), "04/24" },
                    { new Guid("ad42feb6-83f5-4059-83f1-e4771cb0b1b3"), "953", "9656456040244056", null, null, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff"), "06/12" },
                    { new Guid("ad91ce00-04f0-4640-900f-b56f5d13b28c"), "624", "9356544451898797", null, null, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116"), "03/23" },
                    { new Guid("ad9a16f5-f633-42cf-bf2b-13cbcdca5811"), "422", "3918969518473779", null, null, new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618"), "01/07" },
                    { new Guid("ae63c914-e5ec-4766-99f3-731e8e8848b2"), "751", "3539858036684773", null, null, new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf"), "03/06" },
                    { new Guid("ae874a1f-0c23-4697-a5b0-f95c586a901f"), "917", "9183891136849828", null, null, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e"), "09/01" },
                    { new Guid("aea92d4c-4723-4201-9376-bd397adcfc4d"), "658", "6717070919344497", null, null, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6"), "08/17" },
                    { new Guid("aecefe1e-fb7c-4428-a5af-581216b13271"), "870", "6116707277503076", null, null, new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7"), "02/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("af301ef0-1bb2-4e1f-818d-c319aaa66523"), "703", "2666457736111451", null, null, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d"), "05/01" },
                    { new Guid("af4fa638-2ef2-4768-9167-da386bafa293"), "656", "1138420288176179", null, null, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f"), "12/09" },
                    { new Guid("af84a12b-7ddc-4ee8-a7b5-5cddf441d777"), "048", "4579560650614241", null, null, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d"), "08/05" },
                    { new Guid("afa012a8-a62c-4195-bfa3-2cafb94922c3"), "467", "3284576692740199", null, null, new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f"), "08/28" },
                    { new Guid("afe2fda4-38da-4a7c-a7be-6605844f78cb"), "479", "9596691245332539", null, null, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3"), "02/16" },
                    { new Guid("b03cb143-9d45-4f0e-8278-50428d3f712b"), "314", "1712728007380146", null, null, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9"), "11/14" },
                    { new Guid("b0b6dad9-b3d7-4766-ae29-7fb83eb4a73a"), "155", "6199588716792084", null, null, new Guid("b15da029-129e-47f2-8442-a8831d78a2c0"), "08/11" },
                    { new Guid("b13af5e6-c7dc-434c-b6f9-bfcf4f5fdd38"), "373", "4569919519922597", null, null, new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e"), "10/17" },
                    { new Guid("b1852450-2213-49ef-b71e-2ec63498fe07"), "803", "6783936538090545", null, null, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3"), "07/11" },
                    { new Guid("b19e6a0f-4efc-4304-8897-d33b90a407f5"), "122", "3250864562276597", null, null, new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84"), "05/07" },
                    { new Guid("b1db59b1-f979-4c8a-9093-a1ea1ca49263"), "433", "7977007660610870", null, null, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0"), "10/08" },
                    { new Guid("b2316b8d-78ac-4207-b53f-4bf5abb9357d"), "739", "8410957606155863", null, null, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), "06/13" },
                    { new Guid("b279381a-0c79-48a7-a89b-aee2d79b1e20"), "363", "2773752330584221", null, null, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9"), "08/18" },
                    { new Guid("b29292d8-b01c-4046-9530-41b75aaa7b0b"), "796", "9660688826868906", null, null, new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de"), "04/11" },
                    { new Guid("b298f559-c6ae-4d11-a34e-f458dfe57b22"), "146", "2131786661826504", null, null, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "09/04" },
                    { new Guid("b2c93604-c52b-442b-bf91-b3f4ed5a6e98"), "241", "6293234100979153", null, null, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10"), "08/16" },
                    { new Guid("b2f473ea-d016-4264-84d8-38d61e1a7a01"), "377", "6851699914452644", null, null, new Guid("0b13afed-b734-4249-bae8-810ee4f78617"), "08/06" },
                    { new Guid("b31fe176-3f33-49a6-b3a8-6d5c80d44989"), "035", "1759880404936157", null, null, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de"), "03/25" },
                    { new Guid("b35c07ee-57fa-4935-976b-32ad46696806"), "930", "8489031443445480", null, null, new Guid("45917911-5af0-4724-8a58-1fe212041071"), "11/21" },
                    { new Guid("b36c2e3a-27f6-4beb-a58e-4309304e8075"), "048", "1912855914151800", null, null, new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a"), "05/03" },
                    { new Guid("b37477c3-ed62-4f7b-b8d5-f5a18c79eabe"), "404", "9407229221763426", null, null, new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52"), "09/09" },
                    { new Guid("b3b0eabf-ef95-4cbd-98c3-dbabb161306b"), "965", "9169755992906758", null, null, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7"), "10/19" },
                    { new Guid("b3d8f2e9-3a8d-4fba-ab70-a170f5303701"), "335", "1620310177473650", null, null, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7"), "12/04" },
                    { new Guid("b43c30e5-45d3-466a-9d04-495c7931d517"), "086", "8120413113165949", null, null, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d"), "11/02" },
                    { new Guid("b4a16d8b-6e82-45c7-968b-812bd6067736"), "955", "3476879584612615", null, null, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8"), "02/20" },
                    { new Guid("b513c326-2c6b-4bd8-9757-e8698763f835"), "213", "8215185236700894", null, null, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef"), "07/09" },
                    { new Guid("b51f9349-28fc-4a82-82aa-8264f52ca5b6"), "327", "9755027714250479", null, null, new Guid("eada0502-f63b-424a-9d81-244529d74dc1"), "02/10" },
                    { new Guid("b52cd586-96b9-49e3-aa80-dbd5a2aaaef3"), "207", "9671839276573873", null, null, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d"), "11/21" },
                    { new Guid("b58c2323-8cce-43e4-8574-445ef8a43d47"), "226", "5606757287945994", null, null, new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d"), "11/24" },
                    { new Guid("b5992dff-03a4-43eb-9d45-fd79c642059c"), "950", "9077930641031562", null, null, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b"), "02/02" },
                    { new Guid("b5a8f60f-a9ab-44dd-97fb-7a6d585e80ea"), "810", "2269038477316029", null, null, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448"), "02/21" },
                    { new Guid("b5b79722-4913-486c-8d10-b9fc202c911a"), "571", "2811393432413321", null, null, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36"), "02/08" },
                    { new Guid("b602328d-01ee-4e95-af5e-50cf13e9e089"), "845", "8690662792003357", null, null, new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a"), "10/11" },
                    { new Guid("b6c3f206-ce35-4f39-a047-63cb6c329896"), "528", "5887801182039789", null, null, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2"), "06/06" },
                    { new Guid("b73da610-d17e-4d20-8a12-2140dc1cbf9c"), "800", "1323275081876004", null, null, new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10"), "01/07" },
                    { new Guid("b7a3d129-0532-47f6-81da-1f51e4526ef9"), "392", "3413541675440365", null, null, new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93"), "03/06" },
                    { new Guid("b81c5189-14eb-4eda-8315-717546239b99"), "788", "3739108285112549", null, null, new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d"), "04/12" },
                    { new Guid("b8a8ec60-f10f-4874-b0ae-440ee37c40dd"), "087", "1653631447452946", null, null, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1"), "04/13" },
                    { new Guid("b8ee2755-d648-4376-8e8f-905f9e596aef"), "860", "6643359277014037", null, null, new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2"), "09/27" },
                    { new Guid("b9221bb8-6a29-4262-b9bb-bb5d2c6e0671"), "950", "5304810902331404", null, null, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd"), "04/01" },
                    { new Guid("b95fbdb0-69a1-4e1a-8e59-f59526efbbb1"), "420", "5104932526592944", null, null, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4"), "03/28" },
                    { new Guid("b9a812a0-32a4-4f9d-82e2-b57a62f9eabf"), "571", "8392231309792332", null, null, new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816"), "12/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("b9f0a64c-4b0f-4821-af29-283b8f3f65db"), "927", "6036584330106429", null, null, new Guid("48cace70-1194-4581-914a-6aae6159826d"), "09/02" },
                    { new Guid("ba018ec6-f213-46f2-a5cd-11ed9c067f39"), "294", "6338135732343150", null, null, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7"), "11/10" },
                    { new Guid("ba4245ea-99b0-4d9c-ae26-ead30c2457f4"), "853", "8286703444838480", null, null, new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528"), "11/23" },
                    { new Guid("ba89d820-a39d-4f58-86f1-9e596498ec1e"), "521", "1231586212505671", null, null, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8"), "03/02" },
                    { new Guid("baaed1dd-37d2-4565-a1da-5ff09b7a1e73"), "931", "5708427817578320", null, null, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445"), "06/09" },
                    { new Guid("bad2c8c5-8f73-4043-ad56-bea127c07b0e"), "461", "1466175012837592", null, null, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535"), "09/04" },
                    { new Guid("bad83768-efa0-40c7-9329-4d1a48496949"), "710", "1509763653868403", null, null, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc"), "07/05" },
                    { new Guid("bb911b35-e49e-4b6d-834f-c33a7c5dd9e1"), "604", "5103785586480062", null, null, new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350"), "09/02" },
                    { new Guid("bbb2b278-1c74-41f1-bb5f-24bfcd5b679b"), "488", "8653172676698241", null, null, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9"), "10/24" },
                    { new Guid("bbb3d3e2-aeb1-4d52-b321-0913ac58bdde"), "472", "4822784120505786", null, null, new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104"), "08/25" },
                    { new Guid("bc15d149-96a8-4c39-8b7a-2eb81ed366dc"), "325", "3572266342338769", null, null, new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f"), "08/09" },
                    { new Guid("bc1f8577-acea-4239-956a-5f6d0937d65e"), "182", "9005482652422568", null, null, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86"), "10/16" },
                    { new Guid("bc99a106-aac4-4459-b9df-560516d796f2"), "740", "1185465040498795", null, null, new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2"), "04/07" },
                    { new Guid("bcd22c0b-9be5-4542-b8b0-dbda5f689555"), "722", "7327884315269184", null, null, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7"), "01/06" },
                    { new Guid("bd742873-a2cb-4164-9856-1cb20a212849"), "339", "6288624773342779", null, null, new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81"), "08/05" },
                    { new Guid("bd8b9fb8-143d-4ee9-84e3-560058f57456"), "690", "7684067379241790", null, null, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc"), "10/01" },
                    { new Guid("bd8c274b-5ee3-4a3c-bade-b3a10083bdc0"), "277", "3209030806334925", null, null, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7"), "05/22" },
                    { new Guid("bdc79256-ff8e-4d77-98b8-9e482143162f"), "016", "2158346418280507", null, null, new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75"), "07/05" },
                    { new Guid("be16ec20-5ce7-4024-9295-fb9bbaf01209"), "822", "5978361884264094", null, null, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9"), "04/05" },
                    { new Guid("be1eb030-c40b-4d4a-99cc-05ff89866a11"), "512", "3670030939524027", null, null, new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8"), "10/06" },
                    { new Guid("be72607e-1d24-4722-a461-4477c02c96e0"), "210", "2780714201014752", null, null, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10"), "11/18" },
                    { new Guid("be959a26-5116-4388-b3cc-b3d4a557cd68"), "825", "9455546854741959", null, null, new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac"), "05/21" },
                    { new Guid("bf176519-08fe-4191-bfca-c17debd89756"), "646", "1095185534613736", null, null, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0"), "03/22" },
                    { new Guid("bffa8b74-9d36-4712-8297-d5629283b0fb"), "012", "2308355764809051", null, null, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec"), "10/06" },
                    { new Guid("bfffadc7-2645-4144-b3c5-869f95757754"), "442", "2308782527234896", null, null, new Guid("45dee853-0743-493d-b80b-c81b944cc529"), "09/26" },
                    { new Guid("c069e38b-3522-4fe2-9fca-fea31a4a65e0"), "555", "1759945778262735", null, null, new Guid("549f6398-46f0-4e11-bc59-43c056078f96"), "04/20" },
                    { new Guid("c097fb23-e992-4c0b-abea-37fee48048dd"), "476", "9497250046832666", null, null, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92"), "09/10" },
                    { new Guid("c0e2fb0c-da41-4965-b1ba-6ffb013734e3"), "682", "6204443909883221", null, null, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc"), "06/09" },
                    { new Guid("c2730195-5bc9-4626-8b17-b4e3a4d2d8c5"), "569", "2117610188042042", null, null, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1"), "10/09" },
                    { new Guid("c28574a8-c358-422b-9ac3-90e2d314b390"), "491", "7783185396800471", null, null, new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19"), "04/06" },
                    { new Guid("c28b956b-1e94-482a-8a1b-9a12f6a6ded8"), "319", "2151789240990488", null, null, new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440"), "03/17" },
                    { new Guid("c28db50e-ad18-44d2-80b6-a8fad8cb8859"), "923", "8746165876723565", null, null, new Guid("42395499-af46-4c51-b3e8-47c97d474f85"), "09/05" },
                    { new Guid("c2e2ca4b-b2ad-495e-8bae-ed885a58a674"), "569", "8021252509234093", null, null, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc"), "03/06" },
                    { new Guid("c2ee00b3-f2fd-44af-81a0-52366f9671f5"), "427", "3786403834502402", null, null, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0"), "02/17" },
                    { new Guid("c3dc8e9c-8864-4e29-93bb-a98b3968830e"), "527", "4426592250584356", null, null, new Guid("fd051a5e-4258-4bbf-b64a-29676b007443"), "05/16" },
                    { new Guid("c47e73ee-4c91-4bc8-938b-30ef111e39cb"), "893", "3957707349086435", null, null, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa"), "07/13" },
                    { new Guid("c488f4fd-77b0-4bf0-9074-269e9fbdbfae"), "570", "7020683060403845", null, null, new Guid("d5908335-16ba-435a-9a9d-603eaee07878"), "07/09" },
                    { new Guid("c56685f9-2002-4389-a884-4564970be860"), "149", "8407743847649256", null, null, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad"), "12/04" },
                    { new Guid("c59874cf-5a2d-42ef-9c15-d8ec03fc64ca"), "020", "6213700546848644", null, null, new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22"), "09/04" },
                    { new Guid("c5bd7402-9c64-469f-a617-5daf19108fc7"), "383", "6679360110467471", null, null, new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef"), "03/23" },
                    { new Guid("c5df6a58-270d-480b-8874-369f58aa7317"), "135", "8507591490289163", null, null, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b"), "06/18" },
                    { new Guid("c60cb32b-8ac2-4739-b019-d54379ce5994"), "270", "2187708293455785", null, null, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07"), "08/20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c626de16-3ca8-4c6f-a2ad-8f4ee6a62758"), "837", "4422218662969447", null, null, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304"), "12/02" },
                    { new Guid("c64833e6-67b3-435b-b516-5aeedbcb0d8d"), "876", "8027373697426608", null, null, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de"), "02/20" },
                    { new Guid("c684ee34-881d-4973-993b-5174965ee482"), "538", "3250658112566098", null, null, new Guid("6224405d-f9d8-407b-9f81-847223041784"), "03/16" },
                    { new Guid("c6da298b-4e30-4ce3-aa2e-b7a6bd9c61eb"), "145", "9563520329700778", null, null, new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d"), "06/11" },
                    { new Guid("c74d92dd-759c-4f8b-8dc7-389a431391c7"), "124", "1595769981154312", null, null, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358"), "09/20" },
                    { new Guid("c7780236-fbc6-4021-8691-729b5632bfc1"), "396", "8472603503818501", null, null, new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d"), "04/09" },
                    { new Guid("c812529a-4ce4-466a-a9e8-7458945b00a3"), "127", "6353027800761900", null, null, new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7"), "09/18" },
                    { new Guid("c81538a3-8c11-4806-9aba-e430ada12caf"), "038", "2240569293730041", null, null, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5"), "07/10" },
                    { new Guid("c9023bc7-ed04-44f0-aad8-aaa8e9d9f3c9"), "295", "7530516025964114", null, null, new Guid("6c7090cd-7244-4437-b460-88c7027c78f9"), "11/11" },
                    { new Guid("c9691824-9d08-4632-96e5-894fc83201bf"), "855", "4827348676644289", null, null, new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816"), "11/11" },
                    { new Guid("ca60a249-9746-4097-ad61-6c631b13eb57"), "534", "8827403020713924", null, null, new Guid("45917911-5af0-4724-8a58-1fe212041071"), "02/28" },
                    { new Guid("ca74776a-ecf4-4b38-a112-a55e03a5d8ad"), "431", "5072159491349279", null, null, new Guid("e57373e2-48de-4c55-9c02-9b87c7751318"), "01/25" },
                    { new Guid("cabcb602-c296-49ed-9244-6bf7fc5d5285"), "473", "8031431292990333", null, null, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3"), "06/10" },
                    { new Guid("cbfdf5e7-4e9f-4a81-ba1a-b1f345a64335"), "207", "4409848560178858", null, null, new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19"), "12/06" },
                    { new Guid("cc1c7b3c-8cb0-4894-ada4-b11f7ad05762"), "015", "3861205644770939", null, null, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14"), "01/17" },
                    { new Guid("cc7b5e50-dcda-4369-9cec-bb76cde21fed"), "072", "9411080854250704", null, null, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9"), "01/23" },
                    { new Guid("ccf4f098-7b2e-4015-a5ef-5d40b9be43c5"), "515", "2013020893870880", null, null, new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962"), "08/16" },
                    { new Guid("cd46dae4-1004-45a2-a624-40557a107257"), "008", "8130564012819552", null, null, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6"), "09/15" },
                    { new Guid("cd5d95c4-594e-4cad-a3ca-cff1a77e4514"), "869", "7173068082241539", null, null, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10"), "09/05" },
                    { new Guid("cdb19912-199a-491c-81b7-3a88f4a99e1f"), "784", "6107025719329134", null, null, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1"), "02/06" },
                    { new Guid("cdf7bb9c-b84c-43f3-8f76-b1b7291ebe18"), "038", "6351222288349150", null, null, new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340"), "12/08" },
                    { new Guid("ce3209a7-f3a3-42db-b54b-3f839371af8f"), "650", "6843602609734258", null, null, new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350"), "07/21" },
                    { new Guid("ce84a19f-6f64-4b9c-b9b0-747149f35c2f"), "891", "1805796876549881", null, null, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7"), "04/08" },
                    { new Guid("ce88939c-2b35-4b36-9095-0c3e2d03794a"), "522", "8308774331189664", null, null, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4"), "02/11" },
                    { new Guid("ceacf371-0f6f-416b-ab0b-ec4a63c0da0b"), "823", "8975103593233162", null, null, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b"), "07/26" },
                    { new Guid("ceb6fc00-1416-4dad-a087-0966f6888d01"), "773", "6086097123176388", null, null, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad"), "07/09" },
                    { new Guid("cf4301bc-cb40-4620-8cb6-52fd517c03a5"), "684", "5730154300913202", null, null, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f"), "12/26" },
                    { new Guid("cf4d03a7-905a-4963-a6c4-6cc38a4be8a8"), "322", "9053219242720907", null, null, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa"), "04/10" },
                    { new Guid("cfe47d52-3c59-4444-9df6-2986846706b1"), "722", "9131418338165051", null, null, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0"), "01/23" },
                    { new Guid("cff88bbc-f053-409b-9885-56f689b2435f"), "987", "9774861374032912", null, null, new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104"), "06/24" },
                    { new Guid("d052b65a-4756-4f16-a19a-7c417e048590"), "238", "7819961976711713", null, null, new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1"), "11/11" },
                    { new Guid("d12b8204-62e1-4464-9c40-9f85818c5594"), "621", "1915651830752740", null, null, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86"), "08/25" },
                    { new Guid("d1385562-0114-4aac-8bbd-8567976bec56"), "067", "5378407874580253", null, null, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff"), "10/02" },
                    { new Guid("d1edc24a-fafc-4011-b9ad-d235aca2e248"), "717", "4085415813299666", null, null, new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35"), "06/13" },
                    { new Guid("d214536d-d6cf-4d81-8282-19247b38aaf3"), "784", "1217085223456967", null, null, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2"), "08/02" },
                    { new Guid("d23fee5a-8937-4408-8b91-748b14d23315"), "042", "8562783808565328", null, null, new Guid("13cc902b-ca01-4670-ab3f-def800c89833"), "06/01" },
                    { new Guid("d299e754-b583-481b-ad65-586f67267543"), "706", "1786510724528765", null, null, new Guid("82b014c4-7208-45ad-866e-bb82c82db592"), "10/02" },
                    { new Guid("d2ceed53-aff9-4ae3-bdc2-79d51a73df96"), "762", "6477005362903839", null, null, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb"), "02/19" },
                    { new Guid("d311254f-d07d-4d8e-b889-ac446994c424"), "731", "8297503374024716", null, null, new Guid("82b014c4-7208-45ad-866e-bb82c82db592"), "06/17" },
                    { new Guid("d35ca833-c83e-456d-9e42-e32f8270e0a0"), "760", "7247553489206771", null, null, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d"), "11/27" },
                    { new Guid("d393fa14-a309-4bc4-98f5-46f9f44fe16e"), "964", "4193578791608077", null, null, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756"), "02/05" },
                    { new Guid("d39b77d5-ba7e-428f-b806-8fa4dca3f7fb"), "506", "2688878408073172", null, null, new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c"), "09/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d41ab5dd-1fb7-4d5f-87a5-ddd9b8f696be"), "661", "2548564928434836", null, null, new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262"), "11/06" },
                    { new Guid("d43b30e6-d38f-417c-8542-5fbf61e4be62"), "242", "5354423992186182", null, null, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc"), "04/07" },
                    { new Guid("d46f2f93-07f2-4690-a1c2-0d9704ab1af8"), "098", "2414586730266467", null, null, new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528"), "05/15" },
                    { new Guid("d48711b8-77c8-49af-81d4-2f053d4e3e03"), "027", "5297556109971610", null, null, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b"), "01/17" },
                    { new Guid("d4956cdd-2b5f-447e-a789-8ba960982471"), "825", "6019858417260697", null, null, new Guid("9428c7a5-a397-4b16-aff4-15dc05248196"), "09/06" },
                    { new Guid("d4d2c9cc-6adc-4acf-b241-fcdfcb2e76a8"), "576", "5590473827686292", null, null, new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37"), "05/02" },
                    { new Guid("d5252d35-6553-46b5-a7dc-6bf976df10fc"), "800", "7735964399498794", null, null, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0"), "03/11" },
                    { new Guid("d52e5741-5d92-447d-a108-48635d0975d1"), "831", "4887513680746413", null, null, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e"), "06/13" },
                    { new Guid("d565e92f-061d-4be7-ba40-7295fdc172e8"), "315", "3573913857499753", null, null, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57"), "06/20" },
                    { new Guid("d57fe0c5-c4b7-41e3-ab71-b78352c9c1dd"), "910", "7494710903258020", null, null, new Guid("48cace70-1194-4581-914a-6aae6159826d"), "09/13" },
                    { new Guid("d5b094f4-11b0-4918-b609-99c9ea87d1df"), "389", "8185520136050923", null, null, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d"), "08/10" },
                    { new Guid("d5d462a9-d336-439b-8129-3c9ded5acdbf"), "381", "6832000944940439", null, null, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581"), "02/19" },
                    { new Guid("d5df768c-7292-43d2-9e82-ce63aa0b4a23"), "536", "9126631142177075", null, null, new Guid("812d963b-edbc-48b1-948d-661ea6f9d645"), "12/05" },
                    { new Guid("d619733f-853a-405c-845d-14b17c5bd181"), "721", "5888718473410642", null, null, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76"), "10/15" },
                    { new Guid("d63e151b-4991-461e-a09b-6ecc6a74cf6c"), "039", "1604764680618400", null, null, new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e"), "05/14" },
                    { new Guid("d71d9bcb-9ff2-40a8-bb81-511b293a53d7"), "136", "2330577291505991", null, null, new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d"), "02/06" },
                    { new Guid("d723bba5-01b8-48ef-b0f2-9be73f3a3778"), "734", "6492166534810331", null, null, new Guid("42395499-af46-4c51-b3e8-47c97d474f85"), "08/24" },
                    { new Guid("d76d4961-ff65-4f6e-b1d1-82315aa66f52"), "759", "1349469376539839", null, null, new Guid("1144670b-de30-428e-9356-066b18301c96"), "11/07" },
                    { new Guid("d77f6390-cf44-4bd5-bd55-2555dca16d17"), "262", "1188482861058978", null, null, new Guid("2f049da2-3389-49ff-a450-f063e5a81fee"), "04/17" },
                    { new Guid("d7fef512-e20f-48b8-b50d-5da56191477d"), "094", "9481822312598935", null, null, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5"), "06/11" },
                    { new Guid("d8192c98-27ce-42fb-8a63-4f65e6bcab1b"), "211", "9145722428258310", null, null, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07"), "01/17" },
                    { new Guid("d81b1af5-db14-4eb7-85b0-64fb202f2be5"), "858", "7316224949841276", null, null, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945"), "08/18" },
                    { new Guid("d8a5e368-74fb-40e3-b35d-e022c015e4db"), "632", "7157719291473860", null, null, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a"), "04/02" },
                    { new Guid("d8adfab5-082b-4383-b138-4b581b3f7018"), "202", "8056333519589038", null, null, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee"), "02/05" },
                    { new Guid("d93a21f9-739c-479c-a597-b3afc7b8e969"), "436", "6481862244647010", null, null, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01"), "12/27" },
                    { new Guid("d9bd8e7c-e5be-4a54-bc58-d8bb16095ccc"), "610", "2264391439964288", null, null, new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c"), "04/22" },
                    { new Guid("d9db667d-367a-4971-b377-e4709355316e"), "595", "5823089870350488", null, null, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445"), "12/26" },
                    { new Guid("d9ed31cd-31ee-440f-b52c-d5bd7a04823d"), "548", "7637903715895707", null, null, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0"), "09/27" },
                    { new Guid("da23c62f-2c68-449f-a46e-b30d2de78015"), "306", "3987599067238370", null, null, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de"), "07/21" },
                    { new Guid("da50f83d-132f-4dcb-9d03-aba617f880e7"), "477", "6125212875868769", null, null, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76"), "07/27" },
                    { new Guid("da8a1521-3d29-427e-a0fc-fe102eb36444"), "562", "2102914545443608", null, null, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc"), "05/20" },
                    { new Guid("daec5ac9-cd04-4dc4-b135-321a83ed2039"), "481", "2757279502737084", null, null, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e"), "04/08" },
                    { new Guid("dbc6bc36-9ccb-44e7-90e8-dbe7de925f8f"), "628", "6630840998289887", null, null, new Guid("7156fae1-f350-4998-b43f-3d5664953dc8"), "12/25" },
                    { new Guid("dbe7ec31-172c-4299-aab5-27aa261886da"), "007", "4878722873954198", null, null, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c"), "10/23" },
                    { new Guid("dc424ccd-34ea-4602-841b-098c48cc150e"), "204", "2873804480209828", null, null, new Guid("253493f6-b3da-4ae0-a428-05a0560043e2"), "03/01" },
                    { new Guid("ddc7208f-ca40-4f97-8f19-fd1e55dc4c30"), "497", "6242755590726740", null, null, new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be"), "03/19" },
                    { new Guid("ddec983c-6cf7-4cf3-b590-63856727f472"), "649", "1380933799916335", null, null, new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0"), "01/14" },
                    { new Guid("de542540-12c6-4818-8151-5b29715ff826"), "368", "2924488187621169", null, null, new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779"), "07/10" },
                    { new Guid("df0724a6-4ed1-471a-bb75-6464e92882dc"), "772", "8949652738753153", null, null, new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10"), "07/24" },
                    { new Guid("e0a644e7-b4ef-4391-911e-ce3631bfecc1"), "296", "9919971824497654", null, null, new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28"), "11/12" },
                    { new Guid("e0d6546c-048d-4f1d-a72b-d49a6294bdb5"), "138", "6375743516570410", null, null, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33"), "02/26" },
                    { new Guid("e0fa0ac3-a9ea-440b-9e2b-9e47a4c79b05"), "396", "4906943810716427", null, null, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc"), "06/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("e12c5735-11b9-4b8f-8277-a4bdfd1dd26b"), "660", "5178547630402777", null, null, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535"), "03/23" },
                    { new Guid("e15e43ac-53af-4838-8669-14709fba62db"), "421", "3318943018602906", null, null, new Guid("31fbc085-c45f-4025-bc26-03836052f67c"), "01/10" },
                    { new Guid("e1755664-46f7-45f8-89fc-8f51ce2f30c2"), "423", "9854422783489033", null, null, new Guid("171184db-5baa-42f3-92d8-64b8e76c6165"), "12/23" },
                    { new Guid("e1d089fd-19ae-4dc7-b452-9c823e158213"), "206", "6276577923266784", null, null, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52"), "08/21" },
                    { new Guid("e21c8d5e-ad27-4821-b2e7-0f13a73f4979"), "577", "5217287821034574", null, null, new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502"), "12/22" },
                    { new Guid("e233c8bc-8be9-4324-9441-3c3fafb76581"), "970", "5045997174342418", null, null, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4"), "09/12" },
                    { new Guid("e26c551d-1d70-4932-bb0a-df147cfca867"), "347", "6599468998219286", null, null, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3"), "05/14" },
                    { new Guid("e29fd99c-3e13-4aad-8c7b-7ba91f13a6a8"), "121", "1309968194556851", null, null, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77"), "11/21" },
                    { new Guid("e3489735-70e8-4ffe-9eb4-9c772ffee57e"), "901", "4021235917318688", null, null, new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd"), "04/14" },
                    { new Guid("e3a24485-5a7d-4ec2-9fa8-e20e1abf195f"), "141", "3896369529530357", null, null, new Guid("a0863958-35de-49a9-a73b-decb03e0c871"), "03/18" },
                    { new Guid("e3ceaba5-2489-41af-be78-c7ad3c39b83e"), "057", "6741528743479496", null, null, new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472"), "05/11" },
                    { new Guid("e4d574e8-53ff-4af2-9279-385994a274e9"), "201", "2440582638261612", null, null, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448"), "05/19" },
                    { new Guid("e52e4f0d-a169-4137-aa1a-bd22804e6412"), "566", "1195896316380037", null, null, new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e"), "04/15" },
                    { new Guid("e569b61d-b3eb-428a-b680-995ef493824a"), "886", "3317020532871527", null, null, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03"), "05/12" },
                    { new Guid("e59fd1e2-4830-4a49-90f2-650b8f39467e"), "665", "6400257667567843", null, null, new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52"), "12/02" },
                    { new Guid("e5e9987a-97d6-4bdf-b0df-73787633672f"), "193", "9375474426659739", null, null, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413"), "07/05" },
                    { new Guid("e6a17aa0-72bf-4862-99de-52686e14bf66"), "656", "5728979312800468", null, null, new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0"), "04/13" },
                    { new Guid("e75c9fa3-e3e0-44f4-9c8e-0eb29c73a516"), "646", "1985319059570527", null, null, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57"), "12/03" },
                    { new Guid("e7e9933d-3348-4e75-8923-cf828cb03525"), "002", "1078730369666024", null, null, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8"), "02/14" },
                    { new Guid("e80cefbb-e97c-4f17-9139-85c532b898f8"), "710", "7967415312024149", null, null, new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623"), "04/26" },
                    { new Guid("e82d676c-08d8-46a8-a5fb-3125afc08f30"), "345", "9372396979257258", null, null, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8"), "01/21" },
                    { new Guid("e8ae35ce-6604-4c92-a39e-4753b625fd1b"), "917", "8998982032290607", null, null, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc"), "11/05" },
                    { new Guid("e96295c5-f8a9-4506-aa33-9d0a4fdeeefe"), "012", "9136840868943031", null, null, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e"), "09/23" },
                    { new Guid("e9719620-aa58-4415-b9ac-604ff90567e7"), "630", "2411210467402927", null, null, new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b"), "02/06" },
                    { new Guid("e9de95e5-55a6-4969-a8cf-17982a10f3ea"), "153", "9800263327323159", null, null, new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5"), "06/03" },
                    { new Guid("eadbd609-37af-43a7-82ec-fe6d5b1d18f2"), "488", "4341928964912547", null, null, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75"), "04/27" },
                    { new Guid("eae39991-0c61-472c-b59a-c4a6cc03bfc6"), "684", "2012085739469046", null, null, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65"), "12/18" },
                    { new Guid("eb1e5cef-5051-4a38-a05c-c504fb61787f"), "671", "3584067056481088", null, null, new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81"), "08/04" },
                    { new Guid("eb340932-c19d-4097-9827-94ada5894011"), "442", "2807876898900301", null, null, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9"), "06/17" },
                    { new Guid("eb485d11-a3c9-4496-8355-8eac95b5ae13"), "612", "2568255068522439", null, null, new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7"), "06/02" },
                    { new Guid("ec47b92e-15c8-40a5-99bb-6e24b37dc9c6"), "597", "1859185012576413", null, null, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92"), "11/07" },
                    { new Guid("ec643c9c-17ac-4598-8c6a-9917066cf40f"), "706", "7099363176721861", null, null, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd"), "12/13" },
                    { new Guid("ec7f0ca2-1846-4794-b4fb-cf4b67a1cb23"), "287", "9772642496117379", null, null, new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b"), "03/11" },
                    { new Guid("ecc3b75a-a466-41be-ac98-445668a62567"), "937", "4678180605585482", null, null, new Guid("9428c7a5-a397-4b16-aff4-15dc05248196"), "10/18" },
                    { new Guid("ed0c2897-78f9-4a7a-a43e-ea559d58ddcc"), "150", "9871736160809762", null, null, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945"), "06/03" },
                    { new Guid("ed1a27e6-57c0-4fa1-a107-12737d6b5a57"), "100", "2845945568501221", null, null, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7"), "07/23" },
                    { new Guid("ed2830e4-d539-4ad6-8c74-11dade5599f6"), "563", "7188168672586996", null, null, new Guid("42395499-af46-4c51-b3e8-47c97d474f85"), "09/04" },
                    { new Guid("ed4e2d71-7620-421d-b708-d0629c422f97"), "916", "3655784772057115", null, null, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b"), "12/01" },
                    { new Guid("ed5d5d45-8115-487e-a730-5afd7ee0b256"), "827", "3215435001864900", null, null, new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b"), "04/06" },
                    { new Guid("edcc1319-f902-4fd2-a39e-7e9c18a86956"), "721", "2747004798829887", null, null, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03"), "06/14" },
                    { new Guid("ee9eb0bd-c70d-452f-bbde-5cceaaadd404"), "463", "1994093228409246", null, null, new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77"), "11/20" },
                    { new Guid("eec5ebbc-bf9b-4a97-b4af-c3ab27aeed40"), "399", "4769737350439011", null, null, new Guid("152f42db-01de-48e4-a495-9233a821e250"), "09/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("eec7a459-2295-4d5f-93d0-9cdb5f3f8036"), "596", "4193073894540616", null, null, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0"), "03/18" },
                    { new Guid("eed0266f-bee4-4270-a792-4a6229166b54"), "492", "5206459140660865", null, null, new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6"), "01/04" },
                    { new Guid("eef24b0e-ea49-494b-95ec-7c011424b443"), "109", "4823921346579920", null, null, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9"), "06/22" },
                    { new Guid("ef4127cb-048d-47ec-aa46-be0c9221c3b6"), "526", "2580288797052229", null, null, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9"), "05/18" },
                    { new Guid("ef435681-7c53-4c74-84b8-819b4fa98337"), "686", "5553521547778625", null, null, new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a"), "03/06" },
                    { new Guid("ef6ad28f-9a3a-4325-b28e-a2ec881299a7"), "613", "1766637746840232", null, null, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0"), "08/09" },
                    { new Guid("ef6b24c8-7203-4dd9-9c4d-0b87e96b602b"), "059", "4291263371879062", null, null, new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8"), "12/19" },
                    { new Guid("efb2f753-4045-4d67-bb47-d24b2a109fc9"), "733", "5462042758981816", null, null, new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b"), "06/15" },
                    { new Guid("f0292685-56a7-4774-9dac-73368513d304"), "089", "6401572573091916", null, null, new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc"), "02/19" },
                    { new Guid("f0325c05-359c-486c-a4da-401622ef4ce0"), "092", "8999255268679158", null, null, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef"), "02/01" },
                    { new Guid("f070084a-567d-44d8-b544-9e8ae42531b3"), "675", "7895545066939221", null, null, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7"), "04/23" },
                    { new Guid("f0b59f54-7832-44a8-a377-9478518bb262"), "913", "7773228239902361", null, null, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561"), "08/08" },
                    { new Guid("f0c45872-da1f-4035-a5dd-5d7e3ac3381d"), "530", "5053660955450147", null, null, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd"), "08/13" },
                    { new Guid("f0f72497-47c5-44d5-ad36-617f61aba70f"), "769", "3066553835883062", null, null, new Guid("253493f6-b3da-4ae0-a428-05a0560043e2"), "04/24" },
                    { new Guid("f126a398-efbd-4887-9ea8-ecab7f7b0855"), "760", "8018083613610554", null, null, new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139"), "02/27" },
                    { new Guid("f1696f52-8af9-48d8-a837-0815a3f1493a"), "014", "6786943998422192", null, null, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f"), "06/03" },
                    { new Guid("f19b14e9-7b2a-40b3-9a9d-c0f8e43efb63"), "474", "1094586857621657", null, null, new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d"), "02/14" },
                    { new Guid("f22e671a-814f-49ef-8bab-22a46fc992cd"), "011", "7396388085710639", null, null, new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc"), "02/01" },
                    { new Guid("f2aa00b1-c862-4ea9-91d4-e57f5f348e06"), "098", "9823693137447623", null, null, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9"), "07/19" },
                    { new Guid("f2e82a92-d80e-4eaa-835e-f8b27466642d"), "264", "6995464317710974", null, null, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217"), "10/19" },
                    { new Guid("f3a43be8-b8b3-4ca0-adb1-7cdf0a6b1e49"), "983", "5982765146910355", null, null, new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb"), "02/13" },
                    { new Guid("f4bad3fe-5734-4918-bb6e-7ca64221056d"), "714", "9009622103244074", null, null, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445"), "05/24" },
                    { new Guid("f4c11a98-5be2-475b-a805-b47e994e1b0d"), "042", "2850610917391274", null, null, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd"), "06/26" },
                    { new Guid("f517f316-d4ea-452e-9589-95f4f3ec984a"), "481", "4470928494817999", null, null, new Guid("4a21367f-81c5-4947-b939-b44d17e67434"), "04/28" },
                    { new Guid("f5538b76-4213-4047-905d-88bd7f98dcc5"), "094", "1148275272267255", null, null, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2"), "07/05" },
                    { new Guid("f554e129-9c4f-42fa-bc98-f4708a79ae1c"), "806", "7309152753485978", null, null, new Guid("bf057140-33a4-45d8-af53-45e3337a92d1"), "10/24" },
                    { new Guid("f5adb108-df0e-43ff-999e-d5b76d84da37"), "663", "6017195269097166", null, null, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4"), "07/23" },
                    { new Guid("f5baf7ca-3608-4e05-9861-1f0458a83090"), "486", "9620263603178487", null, null, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1"), "02/16" },
                    { new Guid("f6733b76-be94-44a9-9d04-6a0c13ccaaac"), "071", "3131043527897308", null, null, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4"), "10/10" },
                    { new Guid("f675783b-e997-48f1-ba79-67139ab4cd65"), "785", "6546466818927458", null, null, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177"), "08/20" },
                    { new Guid("f6ccf86b-40f7-4a95-9b28-169c5cbd660b"), "784", "1213032670212462", null, null, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116"), "01/16" },
                    { new Guid("f6fe378b-5225-4ae7-875e-369b350bed87"), "981", "1625151930666836", null, null, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e"), "05/07" },
                    { new Guid("f72be97c-b64f-4542-b84d-c8d59cf471fc"), "341", "1854196741452398", null, null, new Guid("24597285-23ce-4296-9004-36d913270ed6"), "09/26" },
                    { new Guid("f740b317-ef7b-45f0-ae11-f0fc0515b388"), "899", "6899871031113090", null, null, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235"), "06/20" },
                    { new Guid("f7aa29a3-4ff5-4853-9861-f300541722a5"), "817", "1929289464790470", null, null, new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac"), "05/11" },
                    { new Guid("f86009ad-65c2-4c9f-a41f-1a5affa22984"), "216", "4408951281454042", null, null, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05"), "08/18" },
                    { new Guid("f90c637c-7c6c-4279-b7fd-9b9d2f93880c"), "423", "6303310637784209", null, null, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca"), "09/08" },
                    { new Guid("f937a051-4e8f-4e92-a12d-47e3fdbc9e6b"), "503", "4159911777262464", null, null, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b"), "08/09" },
                    { new Guid("f942b28f-cf6f-478e-a6c7-d9cce992d703"), "062", "8705371701433765", null, null, new Guid("31fbc085-c45f-4025-bc26-03836052f67c"), "02/11" },
                    { new Guid("f9eb6dc3-ee13-4f94-b05b-e6081bacee42"), "041", "1048200639291190", null, null, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff"), "08/09" },
                    { new Guid("fa5dc31e-d6ab-43a5-95d2-d8ea49d49b68"), "362", "9953339147617944", null, null, new Guid("549f6398-46f0-4e11-bc59-43c056078f96"), "05/25" },
                    { new Guid("fab67aaa-6538-4ece-a49b-53564cfb4f1f"), "153", "4339235491680201", null, null, new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8"), "09/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("faea7680-a96c-46c3-af34-52170481db9a"), "912", "7213729945422675", null, null, new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711"), "09/18" },
                    { new Guid("fb10f4fc-a6ff-44d3-a7cc-911e29f8d701"), "606", "3091804254267297", null, null, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1"), "03/14" },
                    { new Guid("fb834d07-4646-429b-a0df-06c86c67db98"), "459", "2817832715735614", null, null, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5"), "01/04" },
                    { new Guid("fcdfb301-8e13-4bfc-a77f-56f4756981f7"), "735", "9692745315274041", null, null, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b"), "01/23" },
                    { new Guid("fce7d01e-a158-4acc-a9d7-ac9b750d0589"), "122", "7887464379027441", null, null, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9"), "06/23" },
                    { new Guid("fcf0d1cd-2fb7-4940-ba3e-6e003c57320a"), "531", "9974047685798575", null, null, new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f"), "05/15" },
                    { new Guid("fdc1db44-1f7a-43bf-8a0a-0219806da35d"), "961", "3097711580642319", null, null, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc"), "12/17" },
                    { new Guid("fdcc7db5-f9c5-46bd-8566-ebb6d6f7a497"), "978", "6674101062900409", null, null, new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c"), "04/27" },
                    { new Guid("fdcd84c7-c344-46d4-9079-225de5419263"), "691", "8289950001881145", null, null, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad"), "08/15" },
                    { new Guid("fe5631d8-9133-482b-8f46-9ba03450b7fe"), "593", "7674998513530094", null, null, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6"), "08/01" },
                    { new Guid("fead6703-7e99-4469-bb20-759fddeafd2e"), "756", "6599069395215821", null, null, new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b"), "03/03" },
                    { new Guid("fec6e9aa-9c14-48cb-9e5e-f0b04c92802c"), "659", "7254663507613226", null, null, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f"), "03/01" },
                    { new Guid("fef49416-e10e-4fca-91fe-49e65d785c50"), "927", "4791239859807096", null, null, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d"), "07/20" },
                    { new Guid("ff063660-b1b4-43b7-9da5-52b3e1534f08"), "547", "9464750494486743", null, null, new Guid("e57373e2-48de-4c55-9c02-9b87c7751318"), "09/02" },
                    { new Guid("ff9d8cee-6581-4df3-8e55-2ff5ec36c9fd"), "313", "5214315349261407", null, null, new Guid("63684041-907c-4654-ab87-5f0c11008f52"), "12/27" },
                    { new Guid("ffb967e2-a31c-42f7-b4c7-6f412eca4ba2"), "899", "8561166271513275", null, null, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581"), "02/21" },
                    { new Guid("ffbbdc10-15c6-47ed-9029-025514275b53"), "367", "9452684355045151", null, null, new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400"), "09/26" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("014e0ad6-4d04-43ce-934e-44232be94cdf"), null, null, "+993 14 (206) 93-70", false, new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("022ebe13-93a1-4194-8278-c8c2bc94c97a"), null, null, "+421 76 (711) 75-72", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("02e12305-99fc-4018-8123-2360481b01d8"), null, null, "+944 19 (441) 82-27", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("037ec795-cfc9-46b4-afa3-1057cacd046d"), null, null, "+577 42 (900) 59-06", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("042dfc4b-d8e1-4b81-a998-52ea22ac18e2"), null, null, "+296 06 (291) 59-67", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("0448bc63-bef7-46bf-a9c2-99b8c677d1b2"), null, null, "+682 56 (894) 14-45", false, new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37") },
                    { new Guid("04773d79-555e-432f-a699-f3d01ee86316"), null, null, "+735 11 (301) 59-55", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("047b43fb-9ded-47f8-9137-cf8cfddb5511"), null, null, "+714 75 (495) 91-96", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("04b31713-2eb9-4cab-b35a-ff83697deb5d"), null, null, "+280 94 (290) 80-37", false, new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81") },
                    { new Guid("05231e88-9ce0-4765-8570-5a98c512dbd9"), null, null, "+43 55 (623) 43-38", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("0564c78f-481a-4ced-9dcd-8295deac84d9"), null, null, "+870 56 (714) 21-87", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("058c73d2-fa7e-4628-824f-831e9690c543"), null, null, "+716 80 (439) 35-45", false, new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502") },
                    { new Guid("065ff508-d14e-436e-b454-7f1f23edfb14"), null, null, "+973 53 (138) 89-79", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("06771543-b060-4c3f-954c-c3cc0c7a5148"), null, null, "+994 13 (399) 33-39", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("06ea2698-f6aa-44d3-bd82-20ea2430bc71"), null, null, "+237 73 (938) 02-27", false, new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546") },
                    { new Guid("07bf462c-6589-4247-9d75-46d3c5dc8dc1"), null, null, "+807 22 (738) 98-06", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("07c22cf1-207e-493e-83e2-acde8cc68486"), null, null, "+51 97 (493) 34-10", false, new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3") },
                    { new Guid("08224ce6-26b7-48ad-853f-df1b7fe2a250"), null, null, "+398 00 (527) 21-06", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("08992def-dfdf-4338-8b2f-04f458ff88de"), null, null, "+935 97 (823) 13-91", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("08b36a4e-8513-42d6-b923-f8802bf1f29c"), null, null, "+169 63 (876) 09-61", false, new Guid("116e5c9b-48cd-46e4-8fdd-a525c2c3cd81") },
                    { new Guid("092f3cfd-f9ef-4670-9ec5-a8abe9e7981c"), null, null, "+306 18 (390) 12-17", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("0a4fb788-d281-423e-af34-623e060e5ac1"), null, null, "+129 65 (950) 11-27", false, new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623") },
                    { new Guid("0a928f43-5b05-4fe5-bb11-3ccd4f6ba8a5"), null, null, "+567 71 (101) 96-78", false, new Guid("53078823-cbdb-4f6c-b393-57486464289a") },
                    { new Guid("0a965386-931f-418e-8a54-e6ffa55d8047"), null, null, "+984 92 (325) 54-24", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("0aac295b-0949-4e06-a016-1affa5e7e4aa"), null, null, "+387 64 (319) 37-39", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b323191-6efd-4cb0-ae2c-290585c642a8"), null, null, "+297 81 (576) 93-57", false, new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e") },
                    { new Guid("0b979e17-5cb0-4ddd-816d-a1dbf255b213"), null, null, "+883 29 (912) 06-12", false, new Guid("a0863958-35de-49a9-a73b-decb03e0c871") },
                    { new Guid("0baf8118-6e12-43ea-872d-0da498656579"), null, null, "+457 10 (496) 43-89", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("0be3c3e1-d5b4-4556-9753-6cedd3cf2174"), null, null, "+822 35 (445) 15-29", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("0bfe9518-1bff-44bb-847c-817d00e08e5b"), null, null, "+987 58 (516) 77-72", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("0c2a3346-a8c1-4d06-882d-b722a8434fc6"), null, null, "+313 78 (643) 73-35", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("0cd2fada-af94-44e6-95cc-2d0397071904"), null, null, "+396 35 (443) 56-31", false, new Guid("7156fae1-f350-4998-b43f-3d5664953dc8") },
                    { new Guid("0cd8702d-b2c1-419f-b74c-9a00354b8281"), null, null, "+882 82 (279) 90-00", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("0ce90688-471a-4775-b288-b1afd2d6b77b"), null, null, "+315 08 (506) 05-09", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("0d01e4b2-3aab-4dbe-86ae-31478a2f6862"), null, null, "+376 42 (707) 42-56", false, new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0") },
                    { new Guid("0da35d22-a929-4f98-aab0-a4eb8397c974"), null, null, "+402 41 (096) 72-70", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("0dc9b4ab-610d-4120-97bc-889991e7ac07"), null, null, "+212 72 (141) 11-68", false, new Guid("a0935a01-c087-4387-9782-37219c8d05b9") },
                    { new Guid("0de1e34f-bb3e-44e1-80c0-89fb34f7640a"), null, null, "+520 10 (910) 65-18", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("0e0d11e0-6399-4d02-8f22-0213befb9429"), null, null, "+676 53 (404) 03-50", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("0e6e01ba-f91e-47d0-9975-b040d19365c1"), null, null, "+434 19 (417) 67-87", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("0eae6deb-0ab2-4e12-a682-c4fd7c4ab105"), null, null, "+83 38 (378) 94-67", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("0f6a1e03-8ec8-4517-80e1-285985c703d1"), null, null, "+719 91 (743) 89-23", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("0fabe2f4-08c1-4d8b-9b41-0cf928603215"), null, null, "+154 56 (118) 48-14", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("104453ef-a2a7-48f4-a83f-f7adbcb91366"), null, null, "+650 82 (820) 60-08", false, new Guid("d364b716-4b5c-4090-99d6-0f11b5849701") },
                    { new Guid("1089aa96-9312-4e5a-8ad9-e9b6e863dc2d"), null, null, "+757 59 (017) 92-87", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("108dbd1a-7f48-43c7-a02b-1d554a2079c4"), null, null, "+532 98 (542) 91-80", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("1097f759-bcd9-49a3-a8ba-10d10360b14a"), null, null, "+17 10 (524) 82-30", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("111d0333-f051-4e18-b572-87b9f357bcd7"), null, null, "+977 91 (473) 77-13", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("11216847-30dd-4424-b900-4bef23757bd9"), null, null, "+756 87 (353) 62-68", false, new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b") },
                    { new Guid("114ac3d7-876f-4e62-9558-c10b8ce72925"), null, null, "+590 33 (176) 67-49", false, new Guid("8d077a60-6583-4591-b84d-07adff60a1a0") },
                    { new Guid("119112a1-6cf1-47b9-a2d0-9cde94e61ef3"), null, null, "+244 97 (525) 62-76", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("11c1fb8a-46ba-4ee0-8d33-9bff8178b3b6"), null, null, "+208 98 (258) 97-18", false, new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440") },
                    { new Guid("1232a233-f4de-4f36-a55f-f4512dab4c02"), null, null, "+318 13 (379) 98-80", false, new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315") },
                    { new Guid("1246bd25-54d3-4046-a44f-6a9febf364a4"), null, null, "+928 40 (903) 77-45", false, new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de") },
                    { new Guid("12925124-13ba-413b-829a-451f6a31884f"), null, null, "+929 84 (287) 86-09", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("12aff250-76b2-42da-854a-465693dbd56d"), null, null, "+212 97 (013) 95-98", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("12c349b6-2205-4ade-b4a3-ecac0d753574"), null, null, "+27 37 (605) 18-90", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("12f5bd51-c0a2-4b68-ad39-8b153c878744"), null, null, "+461 26 (285) 69-25", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("1384d4ee-64fa-4fa8-8624-a2a554f5954b"), null, null, "+20 38 (489) 31-37", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("139daba0-1dc9-4960-864d-055645ee5b8f"), null, null, "+901 89 (115) 77-65", false, new Guid("fd051a5e-4258-4bbf-b64a-29676b007443") },
                    { new Guid("13b6b25a-fa77-4e9a-aa52-3a0fad179acd"), null, null, "+871 68 (676) 47-78", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("142277d4-861a-4776-b562-881c173cd026"), null, null, "+98 30 (071) 98-99", false, new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf") },
                    { new Guid("145fd984-5dd2-471d-bd58-2890f9e7ee92"), null, null, "+422 39 (156) 35-59", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("151fb23f-ec3b-4d97-8610-5a56a4ca9242"), null, null, "+191 51 (667) 79-15", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("15ad217c-7784-4e54-87ee-d2e39916475e"), null, null, "+687 16 (571) 35-04", false, new Guid("929221d7-8d45-4a44-b501-41a47c26cf44") },
                    { new Guid("15b1cc74-b102-4137-a0b2-7793584b0c9a"), null, null, "+503 83 (991) 19-22", false, new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc") },
                    { new Guid("15ead1ef-cf59-49e2-bf7f-d2fb79f685ff"), null, null, "+565 63 (160) 25-61", false, new Guid("1144670b-de30-428e-9356-066b18301c96") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("16310a84-67c0-4d02-8cb6-5f21ea225660"), null, null, "+520 97 (273) 27-36", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("16aa4b93-38e2-45a2-80c0-0c519a4b6cbf"), null, null, "+484 02 (142) 82-84", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("16ca03bf-65a9-4990-af90-74c37ca1f8dd"), null, null, "+939 07 (136) 66-76", false, new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df") },
                    { new Guid("16f0a762-8f64-45dd-8d69-55ee02b94a1d"), null, null, "+444 19 (628) 64-58", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("1738496b-3b25-41b4-a5d9-9bebff2b3cd3"), null, null, "+639 16 (222) 02-87", false, new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("178d8009-a89e-4c59-9867-c4b538d4dc94"), null, null, "+928 37 (317) 64-85", false, new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("17c9e641-9163-403d-b198-345f70952367"), null, null, "+778 24 (358) 55-18", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("185bc56d-3eb9-4fb2-9b65-739bf6345826"), null, null, "+776 54 (902) 90-10", false, new Guid("63684041-907c-4654-ab87-5f0c11008f52") },
                    { new Guid("18856744-dcf4-4e7b-a62e-84d6b8533a5f"), null, null, "+191 52 (406) 36-12", false, new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84") },
                    { new Guid("198aea8d-f244-4b3f-a3c9-a3ccbcce0e8e"), null, null, "+725 72 (864) 72-90", false, new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d") },
                    { new Guid("1991096c-4a40-4441-891c-c503a06af30e"), null, null, "+323 94 (646) 11-46", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("19a52cd8-d3ee-4390-8a7f-754cfdb8f952"), null, null, "+735 14 (144) 60-15", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("19edefd0-6216-493b-b23a-90f19d4d0ec7"), null, null, "+666 85 (493) 99-56", false, new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7") },
                    { new Guid("1af456c0-c7c2-4254-aa45-ab2352661ecc"), null, null, "+350 79 (687) 06-57", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("1b1907b4-9152-408c-8dd5-daf134ebdb45"), null, null, "+818 92 (432) 49-98", false, new Guid("ae750269-835b-481a-8e36-4dd8044f9527") },
                    { new Guid("1b29f746-bd07-493c-b4fb-1a49b4f05359"), null, null, "+480 89 (889) 38-99", false, new Guid("be28704f-919b-414b-b444-7bf3be5f0534") },
                    { new Guid("1b795650-e076-4df6-9311-0257d2a40612"), null, null, "+646 87 (424) 98-34", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("1bdca078-b5ac-4183-a4d4-efcbf5d8c166"), null, null, "+284 08 (846) 92-91", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("1c0fec6e-7c0d-456d-9d1c-2aa88ef08cfa"), null, null, "+870 67 (896) 64-15", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("1c5b972d-275a-4a3d-892f-98100cb40558"), null, null, "+229 27 (956) 34-44", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("1cd15d1b-2008-4c79-b911-d4fb6624a8e6"), null, null, "+414 58 (265) 96-07", false, new Guid("171184db-5baa-42f3-92d8-64b8e76c6165") },
                    { new Guid("1d69eb7f-ec7e-4961-bb30-942668ef75ca"), null, null, "+744 86 (117) 01-14", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("1ead6fb6-c16e-40c4-a41b-64b1225285d4"), null, null, "+682 06 (365) 49-46", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("1ecceae7-068b-400a-bb1c-4a669d7870b4"), null, null, "+623 26 (782) 76-95", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("1eeb80a0-501c-4322-b2e4-ea0681770a4b"), null, null, "+131 45 (971) 33-61", false, new Guid("d5908335-16ba-435a-9a9d-603eaee07878") },
                    { new Guid("1effc890-668f-4745-8fbe-dcba38b58dec"), null, null, "+715 26 (226) 74-79", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("1f2ff353-3898-4cde-8152-12fc9b76e5bd"), null, null, "+474 90 (239) 87-63", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("1f439f4f-c33d-44b8-b811-cc7cce03de72"), null, null, "+672 79 (748) 43-87", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("1fafa902-c54c-4617-b3ee-da25a834bbfe"), null, null, "+94 37 (420) 55-94", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("20902998-7768-4e76-b355-9601651ebbbf"), null, null, "+682 22 (891) 76-61", false, new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35") },
                    { new Guid("20a080d5-9246-4285-b069-9fd6c9d2993d"), null, null, "+308 11 (508) 46-97", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("20ba8957-e471-4f3d-829b-fd115bedbf6f"), null, null, "+488 47 (001) 28-87", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("20c7decb-0afc-4101-95a1-0ac69fa0a82b"), null, null, "+675 48 (103) 90-01", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("20cd4e0b-c12c-4b35-a046-fd3e6117eb05"), null, null, "+477 19 (242) 94-01", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("217bd697-ef86-426b-91df-2e5b3415b4ce"), null, null, "+728 30 (012) 85-94", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("21a5c18a-bd94-469a-afb1-acf287ec8637"), null, null, "+272 31 (058) 81-72", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("228502ad-d83b-40d6-9141-9f6654b7edae"), null, null, "+216 78 (663) 06-88", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("22ffd2da-10e0-43f3-a45d-62e9f5218d6e"), null, null, "+405 16 (082) 54-25", false, new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8") },
                    { new Guid("230751ce-6be8-4e58-8a70-c27912fd1ba3"), null, null, "+588 62 (904) 59-55", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("235a32ae-c107-42ad-b564-ec876a140deb"), null, null, "+222 98 (873) 98-17", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("23ccf6af-dfc6-41a1-9300-b1124af6ffa8"), null, null, "+306 34 (453) 45-53", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("2421a4d5-ca07-4201-bb8a-dae9239bf901"), null, null, "+870 04 (479) 66-41", false, new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("243af60c-7223-4cc5-b838-dc4ed4cd72ce"), null, null, "+244 08 (651) 81-70", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("243f0d7d-17d4-4ae6-9123-dabce6c73838"), null, null, "+280 53 (357) 32-79", false, new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22") },
                    { new Guid("244248a7-a5c7-4f82-a20f-aaaf83eaf97f"), null, null, "+363 99 (808) 34-50", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("24505f8e-5f68-4ea5-acc7-cceeacc8d1c3"), null, null, "+135 16 (378) 39-22", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("24e12dbb-c374-4541-915e-d5abda109b46"), null, null, "+966 83 (110) 83-05", false, new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350") },
                    { new Guid("25e360c3-c8fa-46bb-9360-7786d03363cb"), null, null, "+910 81 (109) 54-97", false, new Guid("8d077a60-6583-4591-b84d-07adff60a1a0") },
                    { new Guid("266d6340-a354-4bce-b35c-71272b20f407"), null, null, "+452 79 (338) 66-55", false, new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37") },
                    { new Guid("26b9e712-ccbf-4d56-811c-c2f23c481579"), null, null, "+969 08 (868) 46-28", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("26e86381-ae22-4bcf-b811-d23ba349c9a4"), null, null, "+238 38 (311) 43-78", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("270622e9-e290-4c9e-b39c-f7cee28cbfe6"), null, null, "+545 79 (915) 87-03", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("2710215f-a38c-4228-8dae-e115f3462ad9"), null, null, "+135 67 (804) 81-15", false, new Guid("ae750269-835b-481a-8e36-4dd8044f9527") },
                    { new Guid("27231395-4ec7-4112-b2cc-ef02601730b7"), null, null, "+873 76 (458) 10-14", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("2767a01f-5f8b-4216-a169-0aad8ef29ecc"), null, null, "+269 83 (863) 95-70", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("281bf4c3-3e2c-4525-8029-4fc0d567decf"), null, null, "+128 28 (803) 56-34", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("2852e146-9b00-4898-82dc-536b7d5fccbb"), null, null, "+917 66 (858) 51-24", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("28723d77-400a-45aa-bfd6-de8a0a0c251f"), null, null, "+848 84 (899) 72-83", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("29377c77-7bd2-4b89-9be3-b08c275e9166"), null, null, "+189 39 (560) 80-36", false, new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a") },
                    { new Guid("293b49e7-8caf-43fb-a163-315278cb3bc7"), null, null, "+80 53 (012) 41-56", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("29508e33-61a0-4de5-999a-d25a28c3af25"), null, null, "+181 17 (299) 73-93", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("29725048-8c74-48c5-bf46-0832603742ad"), null, null, "+945 51 (089) 28-94", false, new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f") },
                    { new Guid("29e44e7b-58b0-4dad-aa80-6c9735400e7a"), null, null, "+247 76 (314) 37-62", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("2a67664c-bff3-431f-9c77-7df2a464c141"), null, null, "+424 25 (032) 73-24", false, new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("2aa01122-9c75-413d-a4a6-181c3f658d8f"), null, null, "+238 80 (424) 77-88", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("2aba2a9b-0999-4a39-a1b3-5fe062b19e9f"), null, null, "+411 87 (262) 01-41", false, new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("2b62dea6-b3eb-468c-a0eb-6bcb6d6199c4"), null, null, "+605 17 (576) 23-35", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("2b689fbf-b0ae-4310-8570-b53c1a82c9f7"), null, null, "+442 84 (996) 78-38", false, new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce") },
                    { new Guid("2b9af49e-aab9-40da-a897-e478b44a6abb"), null, null, "+662 89 (381) 00-86", false, new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d") },
                    { new Guid("2bd98507-279b-4a47-859c-a0de3396539f"), null, null, "+954 94 (986) 37-40", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("2bdedc40-7cc4-4a13-8ee7-a989d9026757"), null, null, "+872 05 (336) 57-99", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("2c01f5f2-4a66-4fba-849c-adaa5b493b45"), null, null, "+19 30 (642) 43-74", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("2cbba4f8-66ce-431f-b746-a6baa6315a8a"), null, null, "+987 13 (003) 63-78", false, new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1") },
                    { new Guid("2cfefbac-81f5-4599-ab34-1581e1f57f1e"), null, null, "+356 30 (047) 29-06", false, new Guid("067bf875-8a96-48a0-978d-10d890bd7318") },
                    { new Guid("2d398b6f-afba-4740-b90a-39e6dacfc485"), null, null, "+837 16 (588) 36-72", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("2d6e6ecf-c38a-413b-bba9-64d8388581da"), null, null, "+7 39 (662) 73-75", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("2dd44721-b140-4033-b680-148205b417bf"), null, null, "+292 66 (314) 32-36", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("2e2c8334-b621-49c6-9cd5-699e8571f890"), null, null, "+298 93 (320) 78-36", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("2ec78599-9e54-4448-b2df-5821c790aaa2"), null, null, "+918 85 (328) 82-63", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("2f2ae710-cd3a-42cd-bd79-817454a3190d"), null, null, "+18 30 (214) 63-78", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("2f6aa377-fd05-4e0b-bea7-64e9df56a90c"), null, null, "+860 99 (828) 47-85", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("30115b36-c7c0-4331-9fcc-551634febc92"), null, null, "+696 11 (738) 97-28", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("30330ef9-17ff-4876-8038-475b092e9a9c"), null, null, "+860 61 (890) 09-36", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("30601d31-72c8-42ca-b3d9-27e4248db53b"), null, null, "+263 12 (879) 95-51", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("31dfb6ae-045b-4ab9-98ea-c0faa740a456"), null, null, "+684 39 (484) 93-64", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("32107181-de80-4d11-8add-213b8d3e8395"), null, null, "+89 24 (475) 27-80", false, new Guid("3297f120-fc07-4cee-bf67-10b9ed90bee9") },
                    { new Guid("322047f0-a539-4c02-a08d-e05a1c3ba102"), null, null, "+570 70 (073) 59-09", false, new Guid("b15da029-129e-47f2-8442-a8831d78a2c0") },
                    { new Guid("3291463b-a4a4-446d-a0a9-29f0bb2f27cf"), null, null, "+154 81 (015) 12-68", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("32b68278-dc56-4793-be95-16e5dd2ef05a"), null, null, "+650 62 (389) 55-91", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("33240026-e471-4db7-924e-e2b94adb61b1"), null, null, "+504 85 (345) 71-84", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("335d688f-5ef3-4406-8493-4f8a73f012cf"), null, null, "+731 29 (471) 09-26", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("33bd25ea-5efd-4526-86b4-9bf17bda3c22"), null, null, "+940 30 (556) 09-86", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("3427f85c-b5ee-4d14-b760-e9728b2af1c3"), null, null, "+259 25 (983) 25-38", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("345e12ef-aa71-46c0-8dcb-d190e3819a9d"), null, null, "+462 71 (020) 63-70", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("348de723-b739-4ff6-92df-04658446fbe4"), null, null, "+797 06 (430) 00-43", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("34fbe589-f358-480c-9647-4094c83c854c"), null, null, "+880 80 (505) 21-87", false, new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d") },
                    { new Guid("350cdba0-848e-41c6-9e15-0a9793bb963e"), null, null, "+4 26 (366) 44-61", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("353673fb-2abc-47b9-9644-1ba7bb1b1ab9"), null, null, "+59 51 (312) 78-08", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("35a9085f-b80a-40b8-a020-d246870c86da"), null, null, "+634 58 (981) 06-88", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("35c651a3-95c9-4020-b187-6af3e9caf61d"), null, null, "+679 62 (581) 07-52", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("360ad5ea-9b65-42ab-b249-6ac90fd563b9"), null, null, "+669 29 (152) 54-57", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("36b4ae06-6539-41c9-8156-89e1f49bb0a9"), null, null, "+790 42 (950) 12-87", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("36d247c3-35a3-4a67-803c-2a8ede2d377e"), null, null, "+198 93 (788) 78-42", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("377198a5-5218-4a8b-86d6-e244121223bc"), null, null, "+202 77 (575) 35-16", false, new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262") },
                    { new Guid("377ba65d-c0f8-4825-8db7-94992a87d26d"), null, null, "+188 20 (475) 49-86", false, new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f") },
                    { new Guid("377c8f57-fd90-4bb9-a334-625441ed5c63"), null, null, "+502 45 (531) 36-47", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("3785ed9e-51ad-477d-8a96-1a4eee46c9a5"), null, null, "+136 62 (160) 21-44", false, new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240") },
                    { new Guid("37b0224a-af0b-4d99-b7ac-404de2c96b08"), null, null, "+722 71 (048) 40-43", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("37bff55c-0693-4c88-ae06-bd5363f7717f"), null, null, "+437 82 (462) 94-73", false, new Guid("671bbcc1-9768-4630-8a24-d7626303ad52") },
                    { new Guid("386af288-4910-4d4e-b934-a591c95e6cf8"), null, null, "+396 00 (924) 92-09", false, new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1") },
                    { new Guid("3885aaca-8776-4dc7-84be-486af31d5b2b"), null, null, "+912 63 (524) 86-10", false, new Guid("9428c7a5-a397-4b16-aff4-15dc05248196") },
                    { new Guid("39024cef-28be-46aa-9900-07c27392129e"), null, null, "+171 94 (096) 07-92", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("39381ff2-5eb9-4b1d-a035-5313451bd299"), null, null, "+204 12 (122) 60-95", false, new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("39740302-025f-4179-8d12-340950ac8a22"), null, null, "+366 00 (162) 01-36", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("3979782e-0bed-461e-869d-47655ada15a0"), null, null, "+1 58 (151) 71-96", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("39985607-7a80-4cc2-b892-380944fd30e9"), null, null, "+84 33 (526) 99-98", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("39b22482-8a7c-4442-aa29-26c0fb4a6466"), null, null, "+311 06 (746) 50-21", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("39b7cbb7-6133-413d-afda-f13f7646589f"), null, null, "+312 58 (165) 27-92", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("39d344d4-3c1d-40e0-9c69-5e266a577c83"), null, null, "+355 71 (456) 30-83", false, new Guid("2bfc5dae-5888-426e-be52-b9e65b05e315") },
                    { new Guid("3a3ab9bd-8fe7-4de8-a555-90e4b43a1fe5"), null, null, "+949 37 (695) 86-89", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("3a58e9eb-a6b8-42f3-a433-48ee0074a200"), null, null, "+13 00 (535) 24-52", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("3a612561-0311-4ea4-9fb9-cc66e49159ac"), null, null, "+217 31 (397) 88-81", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("3adc4556-7af8-4949-ae0d-b4e6f22ed395"), null, null, "+31 09 (969) 01-56", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("3afe8591-5781-42a0-868e-8cda5a91a8ca"), null, null, "+424 78 (510) 55-06", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("3b150f8e-bb1f-4cc7-8950-9707476bd974"), null, null, "+875 15 (288) 22-83", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("3cf138fa-beaa-46a3-8755-9910f051ae1d"), null, null, "+689 50 (377) 79-76", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d27b5a5-485a-4148-8187-2b31aeb0f8e2"), null, null, "+356 04 (562) 71-36", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("3e86d6f9-df3c-4030-8e89-83a085e1d363"), null, null, "+777 11 (095) 48-47", false, new Guid("fa5f0dc9-2d52-46dd-aacd-29bb730b7618") },
                    { new Guid("3e875274-ff4b-40bb-981c-bc86e6e14f3a"), null, null, "+778 80 (124) 13-28", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("3eb61692-9011-4ca7-87a6-fd1436af3281"), null, null, "+475 18 (517) 47-84", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("3eb7f9be-c658-44fc-99bd-b57a26364c3d"), null, null, "+833 25 (475) 98-09", false, new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94") },
                    { new Guid("3eedbf61-911f-4327-acf4-2f2f90061692"), null, null, "+511 59 (169) 80-99", false, new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("3f1efd31-1c00-48a8-9d54-14d4aa1d4924"), null, null, "+506 53 (815) 81-71", false, new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9") },
                    { new Guid("3f6e5fd4-42ae-40c4-a076-ef57ed3120dd"), null, null, "+631 86 (655) 45-61", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("3ffdbb87-f86a-4f47-a7b4-89dec63f9c7b"), null, null, "+530 77 (653) 52-45", false, new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919") },
                    { new Guid("40224d25-24d4-41e4-acd8-bf5f2a89e02a"), null, null, "+127 67 (327) 49-95", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("403ecb4e-4d0f-40a3-95c1-2cf64dd3f22a"), null, null, "+876 03 (895) 04-17", false, new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be") },
                    { new Guid("408ccfe8-7774-4608-b427-627f07eea3f5"), null, null, "+356 10 (770) 79-36", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("40ddbddc-6c31-441c-8b4c-b0a44695b4e1"), null, null, "+929 82 (607) 68-77", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("4149d1f7-c99d-4f5b-bc4b-979344f6cb7a"), null, null, "+461 04 (698) 03-98", false, new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("419657af-9a4a-458f-a427-f58e94777aa3"), null, null, "+666 51 (338) 87-26", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("41e6b35a-bc44-4216-bf8a-60ea277b3768"), null, null, "+449 77 (026) 62-81", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("420c625e-6326-44cc-b7fe-98e9b004da93"), null, null, "+446 33 (551) 19-20", false, new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b") },
                    { new Guid("423f7a04-faff-43cd-baca-5fe528709329"), null, null, "+363 93 (538) 34-90", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("426ba154-401d-49ba-8244-c875e01d5332"), null, null, "+227 87 (992) 77-34", false, new Guid("812d963b-edbc-48b1-948d-661ea6f9d645") },
                    { new Guid("42b4a101-f424-449e-8189-bdd22588f188"), null, null, "+512 90 (034) 13-16", false, new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d") },
                    { new Guid("42db7d44-2b93-4180-9ede-49401a75c542"), null, null, "+967 61 (351) 77-57", false, new Guid("6224405d-f9d8-407b-9f81-847223041784") },
                    { new Guid("447c7e80-47f7-46ed-9fd8-168785818b7a"), null, null, "+375 09 (067) 72-21", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("44e29fd4-a68d-4ef0-b618-915aa6221a50"), null, null, "+766 90 (589) 47-94", false, new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f") },
                    { new Guid("45a27c70-f167-4add-9795-d853125b7d7e"), null, null, "+806 80 (975) 53-78", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("460f423b-74a6-485b-ba3d-54091e87f6d8"), null, null, "+894 05 (612) 61-61", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("4611b7cb-0631-48e5-9f8f-d683845e785d"), null, null, "+788 92 (353) 50-08", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("4639c912-774e-4637-b807-3147ac25cbd9"), null, null, "+721 71 (899) 09-60", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("467ac9b9-4e5e-469c-96de-c9a068f7621e"), null, null, "+328 47 (062) 38-09", false, new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77") },
                    { new Guid("467fc3b9-e24d-42c9-9335-a576291eab0b"), null, null, "+921 43 (195) 19-56", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("46affcec-6e0a-447e-882d-aa3814c6a539"), null, null, "+692 20 (714) 40-36", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("47493f0d-e5a7-48b2-bf19-8c66f04bc3b4"), null, null, "+387 50 (084) 46-66", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("474a8e80-e1be-4f3e-bda0-c3406a33e4df"), null, null, "+474 01 (941) 56-79", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("4759a92b-ba3a-4d84-8d2a-e88f369e3dcd"), null, null, "+872 35 (935) 00-76", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("47dc88c9-9c75-4c06-bbf4-9e5599d9613b"), null, null, "+357 81 (410) 25-42", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("48017b97-aef1-4de2-a6e1-8bee1f7dd0e5"), null, null, "+924 74 (823) 00-49", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("4845c6ce-4d7a-4245-aa98-0df68e68b8bb"), null, null, "+834 45 (788) 43-23", false, new Guid("86316bb5-54c5-41c2-964a-35d5067b0d94") },
                    { new Guid("48557d81-81c6-4deb-bf7c-8628c15410c7"), null, null, "+751 73 (402) 20-87", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("48a1bd5e-c667-4292-9723-8832f3150332"), null, null, "+963 70 (640) 12-98", false, new Guid("253493f6-b3da-4ae0-a428-05a0560043e2") },
                    { new Guid("48da8132-74b6-46b5-a549-d3e9b8242833"), null, null, "+853 64 (229) 23-03", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("48eabd6e-7056-4612-b78f-7a2d91379e3f"), null, null, "+317 62 (493) 10-49", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("49893574-86c1-4dab-a316-99ae3bf1a7b0"), null, null, "+635 34 (974) 97-16", false, new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711") },
                    { new Guid("49898ee4-e1cc-42f1-86ac-c65087a22d22"), null, null, "+861 05 (522) 45-26", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("49acb5c2-e30d-42ab-8763-9e31bb6acf04"), null, null, "+112 04 (477) 76-01", false, new Guid("6f142e07-4e46-4b88-9f82-ab9ba0d0327a") },
                    { new Guid("49d4d210-54d7-477d-82ea-65f1834d72b4"), null, null, "+919 20 (095) 17-31", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("4a491a68-42ac-4d56-abbc-4fbedb4af530"), null, null, "+292 36 (828) 67-72", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("4a5144c4-a310-4dad-9243-87607473c346"), null, null, "+611 55 (953) 14-63", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("4aa60bb0-3b66-4d59-b29b-621d5c82281b"), null, null, "+132 96 (113) 71-73", false, new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e") },
                    { new Guid("4b02ec7a-57a5-4962-b1b6-fc91a7cbf5f7"), null, null, "+239 57 (454) 94-35", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("4b281a0a-dadd-4391-aa5e-139a63fd9805"), null, null, "+238 69 (994) 63-55", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("4b386dcb-5b47-4334-b814-68477dd5a9a0"), null, null, "+378 23 (429) 01-18", false, new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f") },
                    { new Guid("4b43da18-6838-4e11-8230-d1d14da5308c"), null, null, "+795 97 (692) 66-02", false, new Guid("40f19e1f-4626-444f-b08d-48a5bc824d4e") },
                    { new Guid("4b4d553e-4839-4329-80e1-cd2cdce57afd"), null, null, "+238 02 (393) 12-42", false, new Guid("e1677e23-5579-4b69-9f9b-fcdc89ee9711") },
                    { new Guid("4b5b26f8-7493-4be3-93b4-80aff227be58"), null, null, "+454 98 (452) 30-65", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("4b6b99e1-96b0-46c5-8558-256e63b6a9e6"), null, null, "+485 72 (546) 46-01", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("4baa37b1-1f8a-4ef4-95f0-34e3b90a4656"), null, null, "+804 19 (926) 24-67", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("4bab93dd-8de1-43ee-8712-fb25dfdaa62e"), null, null, "+139 63 (991) 83-75", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("4bae43e4-7bc8-4438-aff0-e3e6139a1973"), null, null, "+323 29 (314) 34-94", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("4be61141-bde8-446c-8049-f8a0d897898f"), null, null, "+493 05 (019) 38-51", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("4c21c7c1-684e-4b63-bb54-47b0c55c1e39"), null, null, "+50 57 (675) 84-00", false, new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2") },
                    { new Guid("4c4e9956-4ddb-4210-8e14-d75166bff5c5"), null, null, "+678 06 (263) 60-11", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("4ce151b1-d4ed-4e40-968b-e11c9f801564"), null, null, "+625 02 (938) 31-13", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("4da40497-1698-4e04-ab37-3d19cdb183ba"), null, null, "+392 90 (750) 98-09", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("4de0fc23-cd0c-471a-9e3f-c85e15f3a76b"), null, null, "+446 57 (431) 43-74", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("4eb38963-be79-4e3e-82c1-ecf8e384beb2"), null, null, "+582 72 (373) 92-65", false, new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("4ed2e384-2866-4049-8613-30305972ad08"), null, null, "+588 83 (608) 58-75", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("4f08247a-5476-49de-815e-79fe3e93c44b"), null, null, "+301 08 (604) 94-85", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("4f08b3ab-4382-422c-bdf2-2ca11cd7ee3d"), null, null, "+914 96 (726) 98-51", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("4f2b711d-74e8-4997-823d-65566b00405e"), null, null, "+297 81 (667) 00-69", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("4f43ffc8-aad4-439f-8de8-045a5ca0cecf"), null, null, "+261 36 (451) 96-14", false, new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2") },
                    { new Guid("4fbaa434-31ec-4c1b-85d9-b5abbbaca2d0"), null, null, "+815 27 (631) 98-06", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("4fe6ab98-5203-4507-b23c-55dbc402114d"), null, null, "+674 32 (747) 99-11", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("5012c10c-031d-4c5f-aa97-e2ac577bb9bb"), null, null, "+333 52 (976) 64-15", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("5021f77e-e59f-498a-a5bc-6698c4dfb75b"), null, null, "+363 67 (686) 80-90", false, new Guid("8a966506-353d-46f9-91b9-9431f8562c71") },
                    { new Guid("50540f30-8ce1-4bf2-8dc9-a8b5a7578a23"), null, null, "+796 56 (160) 71-22", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("507b4c36-3466-4fac-a8ae-7a2c86ddc479"), null, null, "+975 81 (156) 95-64", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("5174604c-51e3-4bd4-9aab-bbdb1b79f4f2"), null, null, "+959 80 (921) 06-14", false, new Guid("3fa16fe7-84ef-4f64-b441-7bfd78c45d35") },
                    { new Guid("519f6a76-80f2-4513-8dbd-7126dc1f49af"), null, null, "+463 82 (376) 29-46", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("529750cf-763f-4bc2-a622-e3ce3dfda520"), null, null, "+899 99 (767) 07-23", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("532f5d7c-a539-4fb4-9de5-94d2599aa278"), null, null, "+372 75 (997) 52-36", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("534716b6-8fa2-4ea5-86ef-e312652952e0"), null, null, "+689 31 (587) 38-06", false, new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d") },
                    { new Guid("5383dcf8-1e98-4f57-bc5d-90d3565804d5"), null, null, "+731 68 (836) 70-53", false, new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac") },
                    { new Guid("5460cec3-2df8-4c3b-bfb7-10ac16164c53"), null, null, "+367 84 (604) 64-98", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("54a70c86-d3f2-4c7b-a1b9-e55d01b50813"), null, null, "+953 21 (512) 23-74", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("55480853-59df-40a5-9e3e-94ff1b6602a2"), null, null, "+123 21 (957) 97-87", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("55c02d11-1b80-4a84-91c2-024df313abff"), null, null, "+615 40 (119) 88-40", false, new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0") },
                    { new Guid("5665b764-20be-42c5-887c-b28c83421e56"), null, null, "+353 25 (673) 06-51", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("56b026a8-a929-4f56-bb6c-5875ed2545af"), null, null, "+463 06 (144) 03-86", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("56d12cce-b1da-4ce9-af20-d9f80a58e7dc"), null, null, "+808 50 (121) 75-53", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("56dd14a9-7f7a-49b8-a462-a1458e39866d"), null, null, "+358 48 (510) 53-77", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("5796b927-3eaf-4010-b2d0-e07009826c9f"), null, null, "+271 06 (659) 26-37", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("57ef70a2-eb14-4e99-ae31-b707e9eb2b58"), null, null, "+125 68 (269) 05-46", false, new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104") },
                    { new Guid("589d3cca-b8b9-4f13-839c-59268c43be62"), null, null, "+861 10 (964) 93-38", false, new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6") },
                    { new Guid("58a22cea-ccd9-4a8f-9ec2-969771c62433"), null, null, "+476 11 (547) 62-72", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("59680064-b753-4499-a75f-2713fd7128f2"), null, null, "+987 74 (190) 81-05", false, new Guid("671bbcc1-9768-4630-8a24-d7626303ad52") },
                    { new Guid("596e25e9-d2a7-46db-9552-4acdea4b219f"), null, null, "+514 42 (808) 74-90", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("599ba263-e34f-4728-b8bf-06e2afe1f544"), null, null, "+443 93 (567) 10-55", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("59dbef8a-4a44-4986-9567-f5edc2b23ca2"), null, null, "+984 10 (449) 74-87", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("59fe7d0c-98cc-422b-9130-61e4abda6d83"), null, null, "+40 70 (251) 43-08", false, new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d") },
                    { new Guid("5a060fe9-a3a8-4724-a948-444acfcaad86"), null, null, "+690 93 (283) 55-40", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("5a459e84-2845-48a3-9200-5e0e21ba1686"), null, null, "+221 23 (540) 93-21", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("5a6bc43c-fbfc-42bc-98ad-82d457b5dd63"), null, null, "+121 21 (183) 03-08", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("5ac5d883-5352-4769-928f-7d9d509931c0"), null, null, "+369 29 (657) 72-85", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("5ae0cd46-6c2e-44ff-b606-cd747131ed48"), null, null, "+78 09 (022) 76-66", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("5ae4cb56-d2e0-4bb7-b474-da590f4c5f67"), null, null, "+156 61 (254) 57-07", false, new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("5aeb4b64-7e17-493c-8aa7-2ebca1caf5ed"), null, null, "+123 51 (221) 32-46", false, new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9") },
                    { new Guid("5b4e95e5-ec9c-4921-abce-f7e5a5546f2e"), null, null, "+322 95 (611) 15-82", false, new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0") },
                    { new Guid("5b9d725f-1000-4f37-b463-c63ce3128e53"), null, null, "+57 14 (130) 92-75", false, new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8") },
                    { new Guid("5beacfa7-0aa7-4768-9c04-30ee9ae70987"), null, null, "+776 38 (138) 98-64", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("5c61b7ab-d622-46c1-886f-0946decb9def"), null, null, "+672 80 (858) 01-04", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("5c744be5-0ec7-423c-9572-bd10e5538b5b"), null, null, "+204 12 (410) 00-34", false, new Guid("e57373e2-48de-4c55-9c02-9b87c7751318") },
                    { new Guid("5cd3a56c-23c6-4494-8fc0-a1aa474f2a7a"), null, null, "+681 84 (441) 67-00", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("5d243482-1f16-41bc-988d-ec4f0fdea5c8"), null, null, "+415 91 (203) 39-12", false, new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") },
                    { new Guid("5d5aea6a-5b25-47d6-8d64-6bbb92f1096c"), null, null, "+933 09 (592) 81-72", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("5d711663-0721-42fb-b4e5-b9dea7e8f145"), null, null, "+775 16 (729) 51-29", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("5d863ef6-42f1-42aa-ac72-31ec65b07908"), null, null, "+267 72 (573) 36-18", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("5dd44c23-35db-4f07-b2eb-f0468450dac3"), null, null, "+483 27 (123) 82-51", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("5e14aae5-c40a-457a-946c-acb3df1bc0ff"), null, null, "+614 76 (570) 86-01", false, new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664") },
                    { new Guid("5e26d5be-648b-4791-ac61-0e1870427be9"), null, null, "+531 79 (065) 26-42", false, new Guid("a406bcd0-ed15-43ec-970b-8b5d5c37cd6d") },
                    { new Guid("5eca137e-0a1b-43c7-8792-8d7eafb40bfe"), null, null, "+794 56 (169) 17-99", false, new Guid("929221d7-8d45-4a44-b501-41a47c26cf44") },
                    { new Guid("5ed505ea-f050-46d3-ad21-093889f51bed"), null, null, "+37 07 (395) 82-47", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("5f24715a-0fcd-46a7-8d1f-178ccdd390ed"), null, null, "+223 04 (959) 84-58", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("5f44fd5f-d53a-4357-9886-ea4bce1f2227"), null, null, "+2 61 (480) 47-34", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("5f588a23-c47a-40c3-a150-35ab1c59a0a7"), null, null, "+946 82 (667) 25-17", false, new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("5f8465a4-bebc-4df0-9cc2-f9e597dd6d99"), null, null, "+570 62 (070) 85-09", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("5f9505e6-03ec-4eaf-9223-105c12612d5f"), null, null, "+732 46 (501) 65-12", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("601cf9a7-407f-4ef7-84ef-dd99ac9dc61a"), null, null, "+241 41 (020) 83-10", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6068b8f5-8f56-42bc-af40-751445f16c7c"), null, null, "+543 75 (643) 87-66", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("60a5b0bc-ea83-4d00-8a23-d1251346c0fa"), null, null, "+551 47 (733) 22-48", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("60b3252c-3f2f-4591-8646-272bbd96def7"), null, null, "+442 77 (737) 11-85", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("60da4ad8-186a-4216-87ac-83437c449377"), null, null, "+674 47 (994) 58-47", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("61003e45-42d4-46ca-861b-5645407028b8"), null, null, "+241 83 (437) 31-94", false, new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5") },
                    { new Guid("61331657-ee69-4a33-b91a-a56d26d90061"), null, null, "+360 61 (593) 31-94", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("626040af-839d-4e15-9323-b6580048e773"), null, null, "+725 89 (876) 96-32", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("627e0769-8a43-4bc7-9d1a-feeab4180d53"), null, null, "+319 12 (287) 47-86", false, new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51") },
                    { new Guid("62ef3f48-72bf-4877-8ad1-fcf45326d7f6"), null, null, "+935 15 (130) 27-07", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("63202e6a-693e-440a-963c-2bdca7d60ed7"), null, null, "+98 73 (538) 29-26", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("63676f5c-9447-40a1-a3ea-b98f96312b1e"), null, null, "+597 84 (966) 96-92", false, new Guid("896f505e-2e1f-4a41-bb29-e9e808ba92cc") },
                    { new Guid("6400ffbd-e772-4a8b-89a5-f94afcb8f50a"), null, null, "+203 46 (517) 26-32", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("6408a36e-b413-40bf-b5f1-301a80d4f372"), null, null, "+699 10 (101) 02-18", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("640e9758-6ecd-49d0-8a26-c01053218c64"), null, null, "+822 63 (015) 38-23", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("6454b538-4faf-427c-b256-c58e142196c0"), null, null, "+452 57 (879) 91-37", false, new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400") },
                    { new Guid("647f495b-0ff9-4601-819e-7aac7ab88a63"), null, null, "+320 49 (211) 22-57", false, new Guid("cbddc7e1-529e-437b-a77d-b6e82214d58e") },
                    { new Guid("652125ad-a9d3-4f7c-81db-02c516fe59c6"), null, null, "+680 28 (451) 10-21", false, new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c") },
                    { new Guid("659038ca-e0ca-41e4-965a-1204c4588fd4"), null, null, "+602 39 (841) 69-31", false, new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b") },
                    { new Guid("65965a42-f774-41af-ac17-053a7e58b6d0"), null, null, "+603 22 (506) 48-00", false, new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de") },
                    { new Guid("6642aa61-a0a9-42d3-a194-3d974bb34cc2"), null, null, "+843 85 (034) 45-84", false, new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340") },
                    { new Guid("665d0eab-971d-4da3-9bcf-70939bfb2316"), null, null, "+852 56 (714) 28-50", false, new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7") },
                    { new Guid("666c6e0a-db27-4709-9b19-cedaf55cdb6b"), null, null, "+486 76 (694) 30-69", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("66c01842-45a1-4d9e-8e7a-6fc1a9f8b43b"), null, null, "+561 88 (841) 67-77", false, new Guid("045a425a-46a6-41ad-a0d8-0b3d7987dba5") },
                    { new Guid("670e12e6-0a43-4a61-8b0c-f6d6631e8c32"), null, null, "+392 10 (453) 04-40", false, new Guid("8a081eb2-c933-4ad9-b985-ec143ff52aac") },
                    { new Guid("671d74c6-3f36-41b2-a2d7-69c206bf7862"), null, null, "+848 04 (597) 25-61", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("673eaae1-ea2f-4bd6-a49b-a88ba2657a7e"), null, null, "+692 62 (450) 29-29", false, new Guid("e91aa61a-63dc-44d1-9ff4-e8dcb959a7df") },
                    { new Guid("67d9b657-150f-482b-acab-36cc55448a51"), null, null, "+24 58 (213) 58-84", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("67eef4d2-b368-4af2-9579-cdc44567804f"), null, null, "+326 23 (939) 44-11", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("687c1e24-43ed-4ac7-865d-c3228b621a0d"), null, null, "+450 96 (457) 02-88", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("6883d29b-1523-425c-a621-cab2fed79d51"), null, null, "+470 97 (584) 44-48", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("6895b650-f565-4d3c-9395-6afda10ef719"), null, null, "+828 91 (909) 25-70", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("68a09679-abbb-480d-a5e3-9b250e58df1c"), null, null, "+411 85 (678) 80-62", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("68b1e610-53fa-48b9-af7f-e169202838ae"), null, null, "+135 86 (849) 97-00", false, new Guid("23b0c0ec-3df7-4f54-8195-63dbaec190de") },
                    { new Guid("69715a4b-ceed-4311-aea7-b7829fdbc505"), null, null, "+452 74 (587) 64-39", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("699c2e6a-4b14-49d4-8263-aff347a8bcbd"), null, null, "+909 14 (960) 87-82", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("69d33222-39f1-471b-961e-e757d64afc03"), null, null, "+290 45 (379) 88-09", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("69d46bad-b0d6-4299-afd8-6e9e0abde6ac"), null, null, "+131 22 (961) 31-78", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("6a1ec5db-ebac-4289-94d2-a788bcf066a8"), null, null, "+408 22 (005) 04-91", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("6a2208ce-7475-458e-8bec-6a38b5527eb4"), null, null, "+732 88 (675) 92-04", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("6a2af7b4-b03f-4ab8-a578-e556776773f8"), null, null, "+747 46 (425) 93-06", false, new Guid("20a4fc8b-434d-4db2-81e7-4adb2fa1db1e") },
                    { new Guid("6a62a5d9-9a5f-4b42-8ad6-84a89f6e34cb"), null, null, "+230 38 (396) 71-27", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("6a66cb23-9a24-40fd-8cb0-2bc3bd8df72a"), null, null, "+170 38 (514) 85-63", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6a766623-f8e6-440c-96c4-e48f35fe6c60"), null, null, "+201 45 (581) 39-64", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("6b14320c-de53-47e8-b9e9-a67a5fb466f6"), null, null, "+795 14 (631) 13-16", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("6b395291-4990-4e6a-bc16-3603fc07162e"), null, null, "+705 76 (036) 15-55", false, new Guid("45dee853-0743-493d-b80b-c81b944cc529") },
                    { new Guid("6b5b9aa3-c764-440a-a5d8-79e6ec19eeb1"), null, null, "+596 38 (258) 01-78", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("6b73d023-96db-49cc-a962-6728d40b8ae7"), null, null, "+595 87 (201) 76-18", false, new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a") },
                    { new Guid("6c2ddae6-a5b8-4e6c-8c8c-a0a78258dd6f"), null, null, "+638 32 (067) 83-24", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("6c798b0f-ea28-4467-b21a-cab61bf0bdc9"), null, null, "+537 17 (348) 72-23", false, new Guid("d2f1b9de-feab-47e6-af9f-a62f1dc48ce3") },
                    { new Guid("6cac5df4-e93a-481b-94f2-5b1f3c7ac154"), null, null, "+100 34 (803) 61-24", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("6cc78bd2-8726-4997-b91d-5eb62786cb98"), null, null, "+60 18 (059) 92-65", false, new Guid("fa2868a2-7810-4ca3-9096-48d8f2907262") },
                    { new Guid("6e0db963-7e47-487d-9369-d5b9127e1b5d"), null, null, "+682 47 (877) 31-68", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("6eed71f3-da02-4d70-968d-1c9f9c823038"), null, null, "+82 60 (082) 51-19", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("6f02d5af-6bf6-4b2c-aff6-d117a71edba4"), null, null, "+644 14 (274) 50-68", false, new Guid("adb573b4-0072-4f62-9d6f-2e99840f1623") },
                    { new Guid("6f13ebbc-8902-4cb9-b88c-46ae8c8f4eed"), null, null, "+560 87 (842) 47-53", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("7025922a-8673-40aa-92ce-5c41d5ef7f36"), null, null, "+920 83 (660) 42-88", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("702a4e57-2a46-4d13-aaa8-2e3d16b15e2a"), null, null, "+372 74 (277) 43-45", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("7053aa00-1013-4dd4-817e-3af7026fdce8"), null, null, "+647 35 (277) 26-86", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("7070a72b-51fb-4a8a-93a1-cebb2a022a64"), null, null, "+191 96 (639) 79-03", false, new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("7071f6a5-dd25-4752-8411-68378cb5da6e"), null, null, "+402 29 (764) 16-37", false, new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2") },
                    { new Guid("708b47a1-f643-4996-aa9e-ab21af4d6a96"), null, null, "+463 15 (912) 24-47", false, new Guid("302771bc-d672-48ae-9a96-c489ccacf75a") },
                    { new Guid("70e1176d-50f2-4723-b9a6-a1a874700910"), null, null, "+12 10 (353) 33-60", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("71d84c5d-4bb0-41ca-b880-30e8eca9f1cc"), null, null, "+737 22 (913) 88-47", false, new Guid("1b893b24-8fca-4d78-afb5-0682e109c7aa") },
                    { new Guid("72101828-437d-4a62-a7c5-8948c3d38e95"), null, null, "+8 13 (617) 76-43", false, new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7") },
                    { new Guid("730c681d-9202-46fc-b120-4afada2789b2"), null, null, "+889 43 (415) 57-82", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("731e1ccf-08bd-4031-a7cb-052d768b333d"), null, null, "+97 83 (594) 12-75", false, new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816") },
                    { new Guid("7333edf6-30c1-4e9a-9e7e-6b3a07f08d17"), null, null, "+457 78 (389) 67-64", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("7374eb18-03ad-45ea-9636-e797127843fa"), null, null, "+473 50 (803) 83-28", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("7390f7b1-92da-4608-81e3-645cacd1ccf5"), null, null, "+266 21 (609) 64-18", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("73ec7c3b-1005-4aad-b661-f0097a6233e8"), null, null, "+689 39 (422) 18-97", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("7433b839-0ca2-4180-9128-8c8379eb3b04"), null, null, "+645 86 (477) 13-35", false, new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3") },
                    { new Guid("744f8cc0-269c-4449-bb5a-897e0e35f845"), null, null, "+30 40 (670) 79-25", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("748a527f-bb39-475e-81f2-a0a8eb35363b"), null, null, "+86 76 (817) 64-40", false, new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") },
                    { new Guid("7496130c-e9ed-48e5-bbd9-0f4338008867"), null, null, "+16 22 (578) 83-46", false, new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0") },
                    { new Guid("753a31a7-ea64-40ae-9caa-d1df51423312"), null, null, "+788 37 (592) 42-95", false, new Guid("d0e3ad65-a954-4c2d-a873-12fe45df98d7") },
                    { new Guid("754cd7e6-0053-46cd-b910-b164106f1e63"), null, null, "+752 79 (484) 96-31", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("7575de6d-f336-4ef7-93d0-9757754b1e5f"), null, null, "+35 58 (477) 68-94", false, new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10") },
                    { new Guid("759844b9-af61-466e-aa5d-6f442a559377"), null, null, "+946 48 (807) 31-11", false, new Guid("b7585057-18f8-422a-9588-5ab6e0f07b14") },
                    { new Guid("763171f4-8a21-4ce0-bdc8-d1abddc02c48"), null, null, "+10 81 (409) 91-53", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("76ef210a-b7e1-4909-93b4-23ee8ad35a3d"), null, null, "+547 38 (638) 71-51", false, new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e") },
                    { new Guid("76fb5dbd-5b71-4886-ac9a-9dc66f25d612"), null, null, "+790 39 (333) 08-03", false, new Guid("c30a0df9-6c0b-4ab9-b3e4-20612a06003f") },
                    { new Guid("774f8abc-12d4-42a9-9a18-40bd7107d11b"), null, null, "+297 83 (481) 35-02", false, new Guid("1700b06d-5cc3-4dc2-8830-c83e5f65a62d") },
                    { new Guid("77619f09-7ea8-4280-8179-ded142fa5845"), null, null, "+303 62 (884) 55-73", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("77d6bcfb-0f83-4754-a34c-08b5c64ec33d"), null, null, "+172 40 (149) 57-21", false, new Guid("4a21367f-81c5-4947-b939-b44d17e67434") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("78448a27-8c69-468d-a5f8-a9597b4983dc"), null, null, "+530 48 (626) 46-77", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("78739c7e-deff-4b3b-9f66-73908f859822"), null, null, "+586 68 (664) 29-86", false, new Guid("89a3b3a6-7663-49a5-85eb-9e6b4449a4d8") },
                    { new Guid("793f52b9-e1cd-4a06-a311-f606000c9a1f"), null, null, "+848 89 (325) 51-99", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("79c1a30e-f207-49d2-80c8-d13f30003830"), null, null, "+872 00 (487) 37-79", false, new Guid("6e91188c-bb5b-4b1c-9fb4-49127ab51440") },
                    { new Guid("7b5cb587-deda-49a5-9521-37820eead17d"), null, null, "+641 08 (041) 35-99", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("7ba223ee-1470-42b9-a3eb-e1c8d7650689"), null, null, "+148 45 (880) 61-81", false, new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef") },
                    { new Guid("7c003f98-14a8-4479-914a-7002d1b01da8"), null, null, "+671 55 (897) 63-69", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("7c5b65f7-8b2b-4ce9-9956-c5609f3e43af"), null, null, "+231 21 (385) 42-94", false, new Guid("b15da029-129e-47f2-8442-a8831d78a2c0") },
                    { new Guid("7c7c29e3-93c1-44e4-98b9-453a8b3df279"), null, null, "+487 01 (324) 65-11", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("7cc9791d-9e29-4a1d-bb0a-100c29e1a3d6"), null, null, "+768 95 (400) 38-51", false, new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("7cfefec0-0473-46c7-8463-50dd6796f9e3"), null, null, "+185 90 (954) 82-52", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("7d0056b3-5929-4c4e-9ef9-7ce307993683"), null, null, "+60 65 (134) 80-57", false, new Guid("253493f6-b3da-4ae0-a428-05a0560043e2") },
                    { new Guid("7d2f650e-580b-4af8-9be1-0e12318417fb"), null, null, "+514 64 (440) 88-43", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("7d7b46f4-f6d2-4544-9ff5-e215da07e177"), null, null, "+747 46 (471) 98-29", false, new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb") },
                    { new Guid("7dd66680-3478-4a4a-b090-2effbabb64c7"), null, null, "+815 50 (014) 07-87", false, new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1") },
                    { new Guid("7e43e65c-f56f-4eb1-9a63-52cc8459f992"), null, null, "+710 78 (571) 50-07", false, new Guid("66bde12e-086d-4150-9c7a-89ea75047f12") },
                    { new Guid("7e7e147d-a6cc-4591-8fc4-d1140ec89e83"), null, null, "+515 50 (175) 47-65", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("7ea888fa-2d60-455f-9f03-1cbb8b4c02a3"), null, null, "+317 74 (558) 94-99", false, new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6") },
                    { new Guid("7eaaadcd-4ce8-49c9-9b40-e4b327c4a4b2"), null, null, "+410 75 (124) 74-70", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("7ef2bfa8-1a9e-46af-baa0-96cb3cdc1290"), null, null, "+897 45 (573) 82-52", false, new Guid("c3ef4130-72b5-4d12-aa55-595e583e65d5") },
                    { new Guid("7f3e75c4-23ba-4f91-98f6-f7c86bbb5173"), null, null, "+261 59 (616) 41-24", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("7fb6ef7c-a6cc-4afa-9cd2-d3fdf50a3686"), null, null, "+107 00 (671) 62-81", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("7fe15ec6-6972-4a6a-be82-e131b1bc89fe"), null, null, "+777 62 (391) 87-23", false, new Guid("63684041-907c-4654-ab87-5f0c11008f52") },
                    { new Guid("8008af94-f02f-40f4-89cd-929f5a26702a"), null, null, "+180 97 (509) 01-87", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("8051d3f6-3b48-4c29-9eda-aaa92cac0773"), null, null, "+260 58 (582) 15-54", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("805f62f5-f5cc-4f4a-9277-e078c350f42b"), null, null, "+380 88 (506) 67-52", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("80982a3a-9d4f-4218-94cd-354d9353dd37"), null, null, "+937 03 (984) 13-71", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("80c62b7d-56da-4695-bc3c-2de63a0baa2e"), null, null, "+182 69 (837) 78-74", false, new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9") },
                    { new Guid("80ceebc4-2380-4a37-82e6-c7cdc9ab70b5"), null, null, "+300 81 (194) 60-95", false, new Guid("87eaf2bc-ed83-4cb4-be88-4592a6cfb9f6") },
                    { new Guid("81892b14-6906-496e-86eb-e097a97c40c9"), null, null, "+988 82 (107) 18-90", false, new Guid("e42f0091-f367-4a97-876d-82f0e3c3540b") },
                    { new Guid("81c2573b-f9b9-4840-8799-2a4dd6b332ea"), null, null, "+884 79 (438) 27-53", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("81c8653f-52b6-4062-a72d-0bf7ccd45a88"), null, null, "+612 26 (335) 52-74", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("825c5cf2-1c2b-4c3c-9936-aaec18c5fa21"), null, null, "+416 60 (306) 93-65", false, new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("825e30f5-a068-4425-b6c0-3e6d9a044038"), null, null, "+787 34 (650) 66-17", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("82afb515-e879-4a32-99fc-b5bb6cbf5769"), null, null, "+194 57 (871) 17-08", false, new Guid("a7c20923-a6a3-4b9f-8560-84976cc80e6a") },
                    { new Guid("82eab880-f766-4f54-86fd-613dcc5e6bfd"), null, null, "+2 05 (249) 33-90", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("83175d21-2eba-436f-b9d2-ce008010d72b"), null, null, "+901 06 (398) 35-17", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("838a32bd-8088-4b20-b300-d08550e3d3d7"), null, null, "+504 09 (705) 52-90", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("83a130b3-18b8-403e-aa40-d43d5eb5179f"), null, null, "+216 98 (334) 93-83", false, new Guid("1e84fe13-ee06-4424-99ba-aa7d702908b0") },
                    { new Guid("8470ff41-2773-47d0-85a7-ac80344f5803"), null, null, "+719 59 (562) 30-71", false, new Guid("086d04a2-114e-47b0-b059-e7ac1b1677de") },
                    { new Guid("84972441-9049-4306-a331-047ee64dfd44"), null, null, "+450 79 (028) 76-73", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("850bb8ba-4634-40d7-b582-5b18f22bf5de"), null, null, "+522 86 (039) 21-94", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("852de92f-bf53-43ad-8eff-2b075f0e524f"), null, null, "+363 76 (547) 71-54", false, new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528") },
                    { new Guid("8579eed2-61c1-49d7-91ef-8564359504ea"), null, null, "+160 75 (557) 76-02", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("85965ef6-dc23-4f50-8dc5-1677ac7036fe"), null, null, "+607 87 (699) 45-02", false, new Guid("3f1fbf56-a83c-410d-acc6-d1cda06d74ec") },
                    { new Guid("859a1fe8-5808-4197-92d4-d4b35f6b7a73"), null, null, "+678 56 (735) 61-55", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("85d7b868-2006-4740-b7e1-f1cd2c7315e0"), null, null, "+807 53 (868) 54-95", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("85e6a303-8686-4b9c-bbaa-353aa291cd4d"), null, null, "+739 69 (739) 19-57", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("861b57d1-d69f-4dda-8d07-050db592a63d"), null, null, "+775 65 (075) 72-74", false, new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("86676861-4fa2-4a36-aa71-52b783cae0e4"), null, null, "+721 13 (454) 52-81", false, new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52") },
                    { new Guid("86d236cd-1001-4b1f-ae51-40f6f8f157fd"), null, null, "+689 70 (310) 46-01", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("86e28aa9-ac9b-4a1f-ac9a-8b0d8a960fe3"), null, null, "+556 06 (034) 69-47", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("8762e000-c9ad-4f0f-a377-662c2712102d"), null, null, "+902 52 (740) 55-41", false, new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11") },
                    { new Guid("87e2fd57-5e21-4916-af96-409337524e55"), null, null, "+415 51 (621) 19-54", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("87ec5e5b-2263-468f-8c04-d92741ad3cd9"), null, null, "+616 53 (194) 91-15", false, new Guid("6c7090cd-7244-4437-b460-88c7027c78f9") },
                    { new Guid("8802d3ef-c7b9-4e83-b756-10af75ae7081"), null, null, "+923 81 (109) 71-73", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("881b2ccb-397e-4662-9d87-ba9dc6017f75"), null, null, "+2 98 (591) 17-26", false, new Guid("4a21367f-81c5-4947-b939-b44d17e67434") },
                    { new Guid("882723c0-0c3a-4ff1-a93d-a9b44e4f511e"), null, null, "+909 18 (288) 93-53", false, new Guid("bb12d49e-e53b-44f1-b9d1-4a6c6b20f46f") },
                    { new Guid("885579d9-5d19-4127-9ece-c57785e5e888"), null, null, "+941 41 (154) 04-61", false, new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c") },
                    { new Guid("889e9534-4c88-4ada-a146-a94b1b7cf82e"), null, null, "+272 08 (595) 22-29", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("88f21073-763d-49c7-9c76-142a75942927"), null, null, "+960 06 (360) 72-37", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("8989414c-e1db-4242-8791-05c5a688807e"), null, null, "+493 38 (888) 88-44", false, new Guid("152f42db-01de-48e4-a495-9233a821e250") },
                    { new Guid("8a99bdaf-575d-4683-bc1b-830bd242c3d1"), null, null, "+257 07 (454) 82-29", false, new Guid("f98a438b-9ae0-485f-ac48-493cf313d2b0") },
                    { new Guid("8b172a56-8c85-441a-95fd-ecadfe75b91b"), null, null, "+728 40 (701) 95-44", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("8b8ba5d1-996b-48cf-9e1c-0e0202da5682"), null, null, "+5 04 (534) 45-79", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("8bcdf4e8-5aec-4c7d-8796-1ab9788c7a6b"), null, null, "+43 55 (271) 81-90", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("8c914367-1a35-42dc-b9c2-bf8d94d8b0ee"), null, null, "+817 77 (060) 32-01", false, new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("8cd5f04a-cc3a-404b-b9ee-65d57f5b38f6"), null, null, "+464 20 (264) 95-43", false, new Guid("70f289e9-2552-45b6-b1bc-c7312c08674d") },
                    { new Guid("8d712c4b-1cd7-4908-9f9d-6e181751e4a7"), null, null, "+876 31 (852) 64-76", false, new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("8d71af00-c838-4df8-a736-b5f99a167f3c"), null, null, "+916 87 (659) 51-37", false, new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("8d821aff-74cf-4484-8fde-083731bebe3b"), null, null, "+253 02 (268) 12-04", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("8d9316b2-8079-45c8-ba54-364f66a7786b"), null, null, "+300 15 (455) 29-63", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("8df8f031-6077-4f33-9f26-70eed4934005"), null, null, "+34 01 (330) 64-54", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("8e16f873-5349-4311-82ff-1306037da9d3"), null, null, "+912 38 (713) 40-54", false, new Guid("c8f8d1dd-4d82-4db9-8ad7-3a9d67949816") },
                    { new Guid("8e1d908a-9a33-4f47-9307-0a2216cc96cb"), null, null, "+457 71 (216) 67-59", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("8e42d6ae-753a-4b83-aad6-f122c5985173"), null, null, "+756 45 (090) 60-90", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("8ecdafd4-fc69-4d29-9517-1230852b19fa"), null, null, "+669 17 (084) 03-51", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("8f0db093-1d0b-4364-922b-c68a94b5a575"), null, null, "+306 13 (473) 64-09", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("8f8569c7-db8a-4c64-ad26-1ba7d4352e80"), null, null, "+440 02 (271) 86-88", false, new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("8fae8345-7eaa-40c3-b574-1adc2d70bcc5"), null, null, "+52 02 (193) 89-26", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("8fd6aa7c-32e2-4303-a127-8b4657b7c365"), null, null, "+903 62 (391) 79-23", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("90222c85-345d-47cb-95ae-06ff2572b1d4"), null, null, "+174 47 (642) 97-88", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("903eab57-961d-44f1-9c39-ec98f72caa5b"), null, null, "+94 10 (435) 18-33", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("90c439b0-1b33-42cd-ac95-d2843491e434"), null, null, "+444 86 (505) 83-55", false, new Guid("6c7090cd-7244-4437-b460-88c7027c78f9") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("9257ecb0-e656-44b1-8289-ac6711cd3d8c"), null, null, "+626 48 (828) 89-45", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("9268d2a9-3cf9-4b25-b4e5-896d3ddc1e54"), null, null, "+884 70 (871) 12-92", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("927c471d-337c-45cc-9cff-604ac72050c0"), null, null, "+116 02 (742) 69-66", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("929f4d17-5f96-4f0d-8985-db062a092be5"), null, null, "+261 61 (376) 47-84", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("93070444-d083-4538-95bf-c4f56b1f01d3"), null, null, "+409 02 (525) 38-45", false, new Guid("58bd5ba5-64a0-40f9-bf7c-75d7c485b9be") },
                    { new Guid("930a411f-ee13-4056-8223-2eaf6e46c0f2"), null, null, "+822 44 (810) 60-61", false, new Guid("8adf5f7b-ef5b-4e44-a478-3916f403bda0") },
                    { new Guid("93bd62b0-faa5-454f-8445-cee0a7294fa6"), null, null, "+967 07 (834) 00-58", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("93c14019-d7c0-4de8-bf2a-61d11b6d13a3"), null, null, "+442 68 (501) 29-74", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("93d850d5-940a-4039-aebe-f4aa9fc4cec2"), null, null, "+705 49 (842) 72-04", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("941da321-5b29-4ab7-a5b9-27f5f2ad16af"), null, null, "+12 51 (167) 95-67", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("949b9b3b-dfcc-4e52-bcb5-370205d4edfe"), null, null, "+92 57 (399) 61-80", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("94a74807-9df7-4f3d-aded-a35b0431f0e8"), null, null, "+380 17 (213) 61-46", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("95248cf8-e27a-45d3-accc-1a114b467c41"), null, null, "+583 66 (910) 79-76", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("9558c834-66fd-4be5-9c3e-2dd8090422d3"), null, null, "+406 20 (806) 29-40", false, new Guid("d90f7ca9-44ff-4747-a4d7-5c8a5e6aa217") },
                    { new Guid("95807be8-eb8c-467c-a695-ce1fdf44ae2d"), null, null, "+507 76 (732) 23-82", false, new Guid("5a8f063f-1d80-4241-8760-84ae37b6c528") },
                    { new Guid("9594d6b3-4fc7-40d2-9028-0338b22a7ab2"), null, null, "+469 40 (762) 62-15", false, new Guid("acb4aed6-a683-46a7-af57-0a5019d5fab4") },
                    { new Guid("959790be-6ec8-4e7b-9587-ba20ead298d0"), null, null, "+204 34 (292) 86-33", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("96a37755-d1b2-4e2a-90ce-65f5217d0a73"), null, null, "+26 95 (320) 60-95", false, new Guid("4d8cb912-b2de-4bab-b33f-6d27d09303de") },
                    { new Guid("96c014bc-2cad-4e59-a1d3-ad65749c464b"), null, null, "+946 47 (452) 58-97", false, new Guid("8c9d670d-0e9f-488e-b22c-e93cfc45658c") },
                    { new Guid("9778c66a-5574-4682-a026-7d2747b4a21b"), null, null, "+491 68 (612) 23-01", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("9951a348-fe98-4b7e-b9a7-62a1d38a96ce"), null, null, "+679 95 (356) 34-92", false, new Guid("b986f914-fff4-4dc3-a07d-a9554b1cb177") },
                    { new Guid("9987b588-47aa-4858-8081-283a988fe49d"), null, null, "+286 68 (291) 99-72", false, new Guid("747f3490-9e1f-43bc-9d36-99c47b7e6400") },
                    { new Guid("99bc672f-8dfb-4a32-978b-d8361c0a4707"), null, null, "+909 04 (450) 35-32", false, new Guid("a0935a01-c087-4387-9782-37219c8d05b9") },
                    { new Guid("9b5b4236-c850-422b-a82e-5f4924f72aaa"), null, null, "+162 47 (962) 39-98", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("9b809bf6-1612-403c-97a3-2e0c88d3968c"), null, null, "+916 35 (192) 07-58", false, new Guid("3bc5eea6-16c5-48a1-9228-d63796599d9c") },
                    { new Guid("9b9d2d9a-d21e-409f-9f55-e6a2b3bd4964"), null, null, "+419 58 (909) 64-29", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("9bab6607-2ebc-4e32-9ddd-f58c85f5e36c"), null, null, "+744 45 (130) 48-56", false, new Guid("f7d5f3c1-2188-4122-97c6-774a7437a8ff") },
                    { new Guid("9c0a59de-4505-475c-8ace-2582c76aacca"), null, null, "+121 99 (647) 00-46", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("9ca9bcbe-d3d5-41fd-85b3-a429f345329b"), null, null, "+862 47 (542) 60-83", false, new Guid("517a6ed9-aa23-42f1-9619-52375fd8f561") },
                    { new Guid("9cbcea0b-71bd-41eb-90dd-55ac91d1c370"), null, null, "+427 50 (673) 55-16", false, new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("9cd975f8-2af2-4357-8610-638005479daf"), null, null, "+913 44 (184) 85-33", false, new Guid("002dfc39-233f-4a47-b20a-eccab581e6ef") },
                    { new Guid("9d8814d9-dcb9-42e9-b704-f3061f619154"), null, null, "+14 52 (713) 93-52", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("9dbc4dbf-d8d1-42af-acd7-917b20528580"), null, null, "+548 16 (856) 34-94", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("9ded1c61-b604-4dc0-911a-e89a3f89c570"), null, null, "+268 57 (182) 90-19", false, new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("9ded8414-bf19-4f7b-866c-39b317ebab4c"), null, null, "+861 38 (448) 02-11", false, new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("9df544fc-a0ce-440a-aa1a-baa9fe7fb0eb"), null, null, "+72 40 (410) 69-61", false, new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1") },
                    { new Guid("9ed56715-d065-43fe-aeef-dd99b784b998"), null, null, "+592 35 (154) 31-48", false, new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("9ee52762-1ab7-4761-9b7c-f2f65d0080f5"), null, null, "+637 54 (896) 60-30", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("9ef52dc6-e1d7-4926-baf0-a808b16d5e12"), null, null, "+542 54 (275) 83-87", false, new Guid("9428c7a5-a397-4b16-aff4-15dc05248196") },
                    { new Guid("9ef8215f-14e9-449c-b132-df824759f633"), null, null, "+390 13 (814) 74-54", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("9f1d7e60-3ea5-42c7-bd4d-d5ea5eaaeccc"), null, null, "+894 28 (924) 25-93", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("9f9766e0-627e-4460-b05f-ce2986d244c4"), null, null, "+559 00 (196) 22-91", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("9fab9b42-5ea5-4a69-ace9-623bce8eccc4"), null, null, "+935 72 (892) 99-67", false, new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("9fdd27a6-3baa-4ddc-9449-a2f0ecdb0ab7"), null, null, "+93 62 (651) 42-17", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("9fe14e15-4138-4b4f-ac08-b0b8055aa4a7"), null, null, "+278 58 (074) 18-73", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("a04b000b-d181-4c7c-9a11-745bc1c088c0"), null, null, "+275 84 (726) 29-37", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("a0b564e4-9c61-45cd-b0b7-5b05f29858d7"), null, null, "+331 87 (281) 44-59", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("a0c40f57-9466-4b21-9973-e7778900382a"), null, null, "+562 62 (541) 92-47", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("a10f1ce2-de71-42d1-aee4-96ae3601d9f4"), null, null, "+660 23 (033) 09-01", false, new Guid("41a2d933-0eb8-4f4a-a6c4-ac678f82b11f") },
                    { new Guid("a14f24cb-5861-48d0-abd0-096c3009495a"), null, null, "+997 71 (085) 70-05", false, new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("a1574dce-20bc-4c19-9136-d1888703a02b"), null, null, "+777 98 (610) 61-32", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("a1928a01-3e07-4d85-aa81-07c4ca985047"), null, null, "+96 57 (214) 24-30", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("a192a364-fe13-4ca0-bb17-d1fd02d02ea8"), null, null, "+910 30 (795) 67-08", false, new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("a1bd813a-329f-4874-8bba-f5e034ab8e4f"), null, null, "+661 69 (250) 19-74", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("a25505db-4fd9-43ff-9e67-0b49c47758dd"), null, null, "+937 47 (841) 25-01", false, new Guid("067bf875-8a96-48a0-978d-10d890bd7318") },
                    { new Guid("a26fa2c6-802c-44d0-83a7-99576e165593"), null, null, "+487 82 (563) 78-80", false, new Guid("9b0f53ee-883d-4d86-a5cd-0e5ddb30ac8e") },
                    { new Guid("a2822058-9da3-4fb7-8d0b-e67a31c92a33"), null, null, "+888 71 (429) 56-54", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("a3699ca2-3e88-405d-b795-80cc38fc4fda"), null, null, "+363 27 (058) 64-36", false, new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962") },
                    { new Guid("a391fe4f-36c5-4046-8234-30cfae86ba59"), null, null, "+5 26 (595) 48-63", false, new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("a3e0e18b-4b74-47d9-b6df-054ec41870b9"), null, null, "+791 46 (597) 49-84", false, new Guid("ca9c0515-2c9a-4ddc-9aa9-2b2fb5e96240") },
                    { new Guid("a402ae63-16e2-4169-b449-8412affeb392"), null, null, "+596 79 (166) 50-02", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("a404bd36-1265-44c8-9c85-05e3357c7899"), null, null, "+508 35 (653) 91-97", false, new Guid("3f9b303a-9e43-4fe1-8e7e-b82840e0c104") },
                    { new Guid("a414fb63-67ce-46cf-a6e2-4d1b36252f78"), null, null, "+824 06 (262) 04-51", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("a4fc00b2-f56a-45a9-82c5-c21128992031"), null, null, "+370 11 (562) 08-41", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("a57968dd-62c3-455c-94e5-117759f41bd0"), null, null, "+821 20 (863) 24-37", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("a5a166dc-b364-4cd3-8458-0dbf2e4a6e40"), null, null, "+550 53 (815) 87-49", false, new Guid("82cf6a53-e2f1-444c-a890-95a7474064cd") },
                    { new Guid("a611ec85-41d8-454e-9337-6ee3af828fb6"), null, null, "+132 79 (942) 77-66", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("a61d9e57-7818-45e7-a7b4-cff6a042efca"), null, null, "+457 42 (580) 13-13", false, new Guid("475b44a8-bc2c-481e-9c37-35d43d6e98f1") },
                    { new Guid("a673446f-c7d5-4544-ac6b-93e30542b4fd"), null, null, "+643 21 (313) 31-59", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("a6854459-9455-43f1-8499-ee3dd3356c73"), null, null, "+275 69 (542) 37-99", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("a6b6f1b5-dabb-4302-8a7c-e646d344800b"), null, null, "+315 30 (090) 76-43", false, new Guid("0d18a020-5d32-4c73-a2f7-ba3ccab7aaca") },
                    { new Guid("a6bc0a28-1e65-469f-b090-c612739fb6c6"), null, null, "+643 86 (997) 75-84", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("a6c72d77-8d88-4b32-b10d-a13e46d3549f"), null, null, "+984 42 (709) 27-61", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("a741725e-b50e-4455-aef5-f8aa0daa97d5"), null, null, "+957 31 (938) 22-53", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("a75abd65-0009-4d56-b7e4-2b1b53204398"), null, null, "+514 69 (974) 01-29", false, new Guid("73b27db8-b761-4531-b0d8-6e3cd60d1bf5") },
                    { new Guid("a7e60507-b3d4-4d84-af8b-7e7223743a85"), null, null, "+90 41 (753) 89-50", false, new Guid("0a218700-5e25-482a-b18b-3f5ccae19ff0") },
                    { new Guid("a7e64345-5d75-4df9-bd15-36599151077f"), null, null, "+122 55 (186) 14-34", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("a818ce66-cb46-42a1-84b4-cc55e1581efd"), null, null, "+511 18 (295) 73-70", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("a947e8db-ec65-4213-9039-313da5c2cc1f"), null, null, "+546 30 (726) 54-01", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("a979279b-3a77-4de7-bd8b-d27d1f56c4f7"), null, null, "+221 46 (351) 00-72", false, new Guid("7314c1c8-c5ed-43be-bdb3-638e8742c502") },
                    { new Guid("aa02f528-3cb4-40c7-9ab3-ed92e67e62dc"), null, null, "+499 72 (378) 10-25", false, new Guid("1144670b-de30-428e-9356-066b18301c96") },
                    { new Guid("aa69504f-967e-4c63-9e93-7ded5ab7a9ae"), null, null, "+827 09 (289) 49-48", false, new Guid("2be61325-ff3e-496d-b45e-555e0aa547e9") },
                    { new Guid("aa6cd5b6-c59a-41e9-b406-d9e22d673445"), null, null, "+807 75 (424) 45-54", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("ab166f5e-efc9-4385-8679-e48572c0c6d6"), null, null, "+782 82 (521) 89-25", false, new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ab1fc33e-82a9-404f-9bba-ad6fb6436c14"), null, null, "+860 36 (407) 96-05", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("ab265659-54e5-43cd-af6f-e5799f74e988"), null, null, "+391 15 (996) 65-77", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("ab5e8817-f5be-4450-ad89-50befac43562"), null, null, "+440 55 (454) 23-82", false, new Guid("e46eaae4-db67-48ec-a84b-b8d5f1790d37") },
                    { new Guid("abc8a46e-e1b2-451a-b1d8-719ed202cbb0"), null, null, "+202 57 (425) 17-09", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("abed46df-c480-4a50-82fa-144924e1e830"), null, null, "+665 38 (482) 38-95", false, new Guid("79521a8c-d31d-45a8-96a5-5e123e82b3b1") },
                    { new Guid("abf74b8a-4f08-4cea-ae0c-32c4ae96c66d"), null, null, "+102 64 (690) 05-65", false, new Guid("10cc48f4-b282-4013-9e2a-cb5b7e8ebd4d") },
                    { new Guid("ac8d6de2-e5bc-4167-ba23-214b337ccb3e"), null, null, "+264 91 (904) 41-35", false, new Guid("00779990-1304-49e8-ab5d-6edfc109ddd9") },
                    { new Guid("acdadf9c-aa77-4021-998d-6e60fc062b90"), null, null, "+792 36 (465) 31-26", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("ad6cbdd6-4c51-44b2-8b49-00f9cc9a1143"), null, null, "+23 07 (134) 63-45", false, new Guid("42395499-af46-4c51-b3e8-47c97d474f85") },
                    { new Guid("ade62af9-da16-4e69-b1b8-a239d8297a30"), null, null, "+355 19 (799) 73-80", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("adeffc59-7bdf-487b-905e-83107e128151"), null, null, "+831 63 (186) 19-32", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("ae28bc09-604c-4abf-b404-69c7149e5b9a"), null, null, "+67 46 (293) 45-93", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("af28299c-afab-4ad0-af49-dd072ae64526"), null, null, "+573 07 (605) 88-93", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("af2f8bdc-586d-46a5-a555-e6311f20422b"), null, null, "+625 59 (700) 42-77", false, new Guid("171184db-5baa-42f3-92d8-64b8e76c6165") },
                    { new Guid("af6477fe-0fd4-41ec-9981-e777a725e411"), null, null, "+171 89 (905) 94-87", false, new Guid("37217993-e4b7-4840-a96f-c19e1f28cf52") },
                    { new Guid("b003b66e-df14-4122-8bbc-2f06a81a04ec"), null, null, "+671 61 (307) 17-48", false, new Guid("60ee744f-b44c-4af4-b903-1d975cdfc4ff") },
                    { new Guid("b050ff88-4273-4b57-8cf9-da3ddeb2dda8"), null, null, "+999 36 (318) 33-80", false, new Guid("8b2a3316-4c09-46c0-bd5d-e051aa1c2f57") },
                    { new Guid("b0ca07e5-4d7a-417d-bd3c-335b5644a8e5"), null, null, "+510 55 (100) 12-46", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("b262eff0-d1ca-4e37-9d27-fdf84a7834da"), null, null, "+800 71 (820) 19-13", false, new Guid("0b13afed-b734-4249-bae8-810ee4f78617") },
                    { new Guid("b29abff2-02ad-4994-97a7-4366498addcb"), null, null, "+286 12 (399) 19-03", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("b4582372-3f7d-4f1f-a548-d32e688186cf"), null, null, "+729 64 (910) 97-38", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("b46f77e8-45e0-460c-82ba-739473dba2a1"), null, null, "+978 03 (175) 80-81", false, new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("b4c7f1c1-1021-47cd-b115-84ed2a5523bc"), null, null, "+751 48 (889) 50-58", false, new Guid("8f6e0a00-cc8d-4dd2-a45f-3f0f08ea9c52") },
                    { new Guid("b5194177-7982-47c6-84e8-fe088f5c3595"), null, null, "+462 66 (759) 73-63", false, new Guid("b849e8d2-6f0c-4728-b444-253fe3e202c8") },
                    { new Guid("b565f25b-cd4b-4d52-8528-288df28aad8f"), null, null, "+936 05 (489) 89-28", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("b62c0e95-685b-437c-927a-ef7d72ecc20f"), null, null, "+924 68 (227) 52-93", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("b63a7af0-ff26-48c5-90fd-c0db937b3cf1"), null, null, "+516 22 (717) 35-49", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("b66eafc7-7aa0-4b17-b9f4-2c7ab6f73527"), null, null, "+165 56 (275) 40-88", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("b6ddb721-9ce9-4c4b-99a8-1338dc342db5"), null, null, "+75 65 (334) 26-37", false, new Guid("59b21719-d94e-4375-b260-4b7c94d6db3c") },
                    { new Guid("b70318cf-5e02-4d9a-a839-38d0966d9b66"), null, null, "+687 22 (230) 85-78", false, new Guid("2767bfec-51e0-4087-94a0-8a6f0f1a723e") },
                    { new Guid("b734586c-a600-4ad7-b298-521cb57b8079"), null, null, "+830 41 (425) 27-17", false, new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc") },
                    { new Guid("b77f7799-e858-453c-a90a-d50ef3aeb795"), null, null, "+854 61 (813) 71-94", false, new Guid("c3f7e1da-b5cf-41d7-a115-001ecf22c9a4") },
                    { new Guid("b7fc259b-e8a1-442f-8d5a-de955e84c7c6"), null, null, "+208 59 (958) 42-37", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("b806f828-eb35-4836-a31f-2e4c332c9321"), null, null, "+663 62 (990) 63-57", false, new Guid("7156fae1-f350-4998-b43f-3d5664953dc8") },
                    { new Guid("b8416fb0-b70d-4952-be36-d0bd4758f180"), null, null, "+55 16 (674) 26-56", false, new Guid("91b55246-64e7-4778-a3c7-39b6018abe5b") },
                    { new Guid("b8555bf2-b07a-4708-bb27-f6c0b5b058b8"), null, null, "+710 83 (448) 99-56", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("b8f9a3ae-2a7e-4fb9-a051-87f7304bd303"), null, null, "+912 34 (155) 74-00", false, new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c") },
                    { new Guid("b936328a-54d2-4c99-97cf-843eedaeb10e"), null, null, "+370 64 (720) 50-55", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("b95bcd98-6b21-4852-94a9-155a5d1a6e69"), null, null, "+343 73 (125) 15-68", false, new Guid("166c6b76-a3c9-4223-a1d8-a8a4dadcb4f3") },
                    { new Guid("b99cf115-cb97-4db8-ac64-53e766abad08"), null, null, "+360 37 (367) 55-97", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("ba4590b7-d9b2-47ca-913b-207b9604e42c"), null, null, "+708 34 (211) 37-60", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("ba994cf2-08ba-41f8-ace0-65403fbc7b5c"), null, null, "+713 21 (420) 15-89", false, new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ba9a051f-0ff7-4d43-a106-70ce79342cf6"), null, null, "+745 10 (186) 25-27", false, new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75") },
                    { new Guid("bafbb375-2340-4e09-9706-2132ee7cfff6"), null, null, "+757 54 (850) 25-30", false, new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("bb13785b-ab6d-452c-88a5-75e771bfdaaa"), null, null, "+312 66 (748) 47-41", false, new Guid("62c020cb-24c9-4e7f-8fc4-71a496f144b9") },
                    { new Guid("bb2e4be5-8247-441a-b724-b3f18f8a92c1"), null, null, "+168 80 (880) 29-53", false, new Guid("be28704f-919b-414b-b444-7bf3be5f0534") },
                    { new Guid("bbab72b3-91f3-4e35-9061-3a69f6c2865a"), null, null, "+218 61 (525) 11-85", false, new Guid("05acf5fe-ea02-4d62-844a-f9b0174b1e76") },
                    { new Guid("bbedf86d-68e2-4175-b815-014b727e9369"), null, null, "+381 62 (343) 82-81", false, new Guid("aad5fad3-ea95-47df-9873-457d512e7d3f") },
                    { new Guid("bc14f43b-c1d0-4705-8a42-76b394202814"), null, null, "+855 32 (096) 82-24", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("bc31af5b-059c-4122-bec7-dd5c7f950b1e"), null, null, "+899 68 (973) 13-21", false, new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("bc328337-8893-41a4-b85b-6df62daaec02"), null, null, "+694 71 (346) 69-41", false, new Guid("b1730870-c7ce-4652-9fde-90436bd323a9") },
                    { new Guid("bc6929ca-d934-454c-bfd0-c5f6fadbd110"), null, null, "+91 75 (165) 39-32", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("bcc86004-8da2-4f19-808e-ee2d6f782071"), null, null, "+2 14 (518) 51-56", false, new Guid("6df49921-1995-4ac0-a6be-f9da96a362a1") },
                    { new Guid("bccd1018-4e44-4a1e-a90d-9a150359e704"), null, null, "+878 65 (859) 50-62", false, new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("bcea9d13-59a7-471a-a3a2-007db621294f"), null, null, "+844 18 (186) 30-95", false, new Guid("bf057140-33a4-45d8-af53-45e3337a92d1") },
                    { new Guid("bd1cce31-f333-49a9-ad63-162bdcb3ee27"), null, null, "+377 21 (858) 68-34", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("bd9966cd-3246-4ab3-ae12-ea6bd4c4ebed"), null, null, "+727 17 (438) 94-90", false, new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("bdad1480-ffbd-459f-ab66-31b476269f2a"), null, null, "+836 02 (929) 68-65", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("bde79351-6967-4b58-a66d-5f50f5ed3b15"), null, null, "+37 74 (403) 37-07", false, new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("be9f7b9a-6ba9-4570-86ce-2b8747d45c05"), null, null, "+291 89 (107) 82-84", false, new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad") },
                    { new Guid("bee4d8af-7a45-4bde-be75-c78af5061a34"), null, null, "+249 66 (264) 46-35", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("bf4558b9-b820-46d1-969e-67fb01f014d1"), null, null, "+231 02 (044) 93-00", false, new Guid("cd1cbc32-3001-4296-97b1-174540c81c07") },
                    { new Guid("bf58a9c0-cc4d-4d07-9b35-6c4effdffa03"), null, null, "+149 97 (700) 10-20", false, new Guid("4f6f614e-0770-4607-a9ac-9f3fb9f90aa9") },
                    { new Guid("bf82290b-0542-4657-9557-b12e44924e86"), null, null, "+119 07 (678) 02-20", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("bf92e775-614a-4f2e-b47f-522e5dfdcb98"), null, null, "+584 91 (421) 97-86", false, new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("bfbb8ed3-edeb-4189-9b83-67f44a5d9eac"), null, null, "+535 63 (341) 36-95", false, new Guid("b42842d9-2c85-4dba-a0e9-1a01c33bd3a3") },
                    { new Guid("bfd9f414-dbf3-4581-849b-8d1cf3a14c6a"), null, null, "+651 18 (758) 90-34", false, new Guid("6f39438c-9d5f-4457-a9f8-bd6e4572f70d") },
                    { new Guid("c0446cfd-f069-49e7-90f7-17d082e6f369"), null, null, "+641 33 (156) 51-75", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("c06765dd-c1e9-46ff-9b9f-ac06e1d90b06"), null, null, "+30 70 (778) 99-71", false, new Guid("19dee204-eb31-4800-82f4-48ed6c71bd10") },
                    { new Guid("c075b3c2-f34a-428a-95cd-c5f00559878b"), null, null, "+540 53 (759) 52-77", false, new Guid("ca5f0ff8-368c-41f0-8684-b14b50692a75") },
                    { new Guid("c0dea6e9-68bb-4e95-b6ca-732e7a27ce6d"), null, null, "+473 93 (341) 02-61", false, new Guid("5a414bb4-597e-447f-89c5-1d7e1df686a2") },
                    { new Guid("c125e9ce-d7a9-4438-9a3c-2d96985663f9"), null, null, "+220 87 (444) 40-14", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("c12b32a5-e771-4b15-b49e-cc6fe2df5e7d"), null, null, "+412 29 (859) 14-61", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("c19273b4-c83d-4d3e-a3e3-d2a17ca9371c"), null, null, "+880 32 (636) 71-40", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("c2d1b55c-947b-4b20-be19-72496c279682"), null, null, "+828 17 (741) 04-38", false, new Guid("55212ad4-b8ea-4552-8605-b121512b19ee") },
                    { new Guid("c32c1f64-8c82-4eb7-8b65-366b9665ecc3"), null, null, "+772 23 (115) 11-24", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("c39b0829-bc8c-4ed6-84aa-f886b555b795"), null, null, "+908 35 (424) 34-88", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("c40fcb62-dc6d-427c-87e0-17c061f16762"), null, null, "+734 35 (093) 31-36", false, new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b") },
                    { new Guid("c44a4187-2e62-4345-95ab-b8d485e32eb3"), null, null, "+20 12 (486) 30-29", false, new Guid("c70db0c3-b953-4f7c-a32e-f3a51712774d") },
                    { new Guid("c4536a30-a01d-4257-ab80-a1ce274e1622"), null, null, "+872 18 (205) 46-41", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("c56d3278-d08f-4745-a8fe-aa42902d9227"), null, null, "+335 39 (402) 35-92", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("c61c39c3-3a36-448a-a9ca-b594a1ef2397"), null, null, "+624 93 (796) 39-96", false, new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139") },
                    { new Guid("c68cd620-8a7c-4d2b-8733-ef2ad45f938c"), null, null, "+265 48 (148) 17-99", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("c6e8deb7-055c-4647-ac38-2fa5789bbfc4"), null, null, "+518 17 (457) 71-96", false, new Guid("a0863958-35de-49a9-a73b-decb03e0c871") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c77659e2-777a-4f7c-9085-000c2e47299e"), null, null, "+232 03 (850) 55-23", false, new Guid("1b5b0c15-531c-4560-9c23-ea2598e8fcad") },
                    { new Guid("c7a17e28-9679-4299-b2f1-f74e1b219d18"), null, null, "+221 47 (425) 21-81", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("c7c3dd0c-c2bc-4863-890c-da0f3c088155"), null, null, "+642 74 (257) 77-69", false, new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b") },
                    { new Guid("c8618f67-2f8f-48ff-a912-8981a67dabdd"), null, null, "+901 68 (600) 01-96", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("c86e5723-f196-42e3-ab8b-895577384bc4"), null, null, "+578 78 (404) 64-57", false, new Guid("4bd483a5-790c-436f-8b4c-35ec3398137c") },
                    { new Guid("c89e1deb-bab9-4961-9a7b-04004f433d6d"), null, null, "+75 92 (593) 60-49", false, new Guid("4f0745ac-532c-43a4-83be-7fd2bbe32a1f") },
                    { new Guid("c8de480d-8a74-4d66-b0e5-88fe590d340f"), null, null, "+740 99 (115) 68-51", false, new Guid("ad0b819c-9ac5-48d8-abf8-57d25002decc") },
                    { new Guid("c90d1240-239e-43a8-a021-0971ea743b5e"), null, null, "+821 73 (339) 58-82", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("c983bc18-dc3d-4fcf-91ac-059241911d73"), null, null, "+272 12 (141) 65-65", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("c9917423-2728-42eb-b7d5-283ced59a249"), null, null, "+47 50 (831) 91-27", false, new Guid("57e1bb6d-b1b0-4860-b2c2-ed3655c3ba1b") },
                    { new Guid("c99998d5-f589-4621-9f1c-bbaa3d75455e"), null, null, "+900 12 (294) 79-10", false, new Guid("475e2391-2aa5-4999-8c56-c94a98cf3340") },
                    { new Guid("ca36d084-ef7d-4f1d-9e1c-00ab1604e180"), null, null, "+532 94 (039) 06-70", false, new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("ca7f68de-c02b-4b15-a153-874273ffdb05"), null, null, "+626 69 (631) 82-53", false, new Guid("24597285-23ce-4296-9004-36d913270ed6") },
                    { new Guid("ca8f3059-bf00-450a-b290-e573f37478aa"), null, null, "+225 05 (449) 65-23", false, new Guid("62a3e97f-7ade-41ca-a073-c8bf51d0d4b0") },
                    { new Guid("cb67582e-bd52-4a2b-8ea5-714de4b10965"), null, null, "+31 84 (309) 28-31", false, new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("cb9c7959-06a7-4cb7-990c-0061329eec6c"), null, null, "+472 53 (878) 67-69", false, new Guid("b2906dbf-aaa6-4aff-967f-aa411eccdf0b") },
                    { new Guid("cc292781-8bc9-4d1f-af33-160172831171"), null, null, "+592 14 (088) 63-34", false, new Guid("02013b18-2ab5-40db-bd58-18edf1691d5c") },
                    { new Guid("cc4ccff1-12a9-4654-88f4-e4524edb60d6"), null, null, "+329 97 (235) 40-40", false, new Guid("04b80a2e-34cc-4c8c-a6ae-bdd53d698f7a") },
                    { new Guid("cc4e8489-0c6e-431f-9d94-98520cd99340"), null, null, "+678 25 (435) 40-73", false, new Guid("53078823-cbdb-4f6c-b393-57486464289a") },
                    { new Guid("cd287a05-cc43-495c-84a6-fc392e84d718"), null, null, "+221 77 (613) 48-32", false, new Guid("7478c8d6-8038-407b-aa8d-a55ee86dea77") },
                    { new Guid("cd73e5a7-1e25-48ac-8854-fa7a154fd8bc"), null, null, "+243 52 (674) 22-89", false, new Guid("7148ffde-2156-4058-b4fd-1e5fb573b74b") },
                    { new Guid("cdb0ca47-aded-4094-b167-5eb7d175fe02"), null, null, "+721 66 (774) 28-75", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("cdb80513-525a-4d9a-a812-b9378a83f594"), null, null, "+531 91 (013) 59-22", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("cde4b149-b5a9-4e7e-bf97-160b20c8686a"), null, null, "+991 00 (702) 57-15", false, new Guid("108c93d4-1288-40cf-bf34-c0176c9d4c22") },
                    { new Guid("ce65ba8e-902b-4c89-8fcf-6918e2483d15"), null, null, "+590 06 (207) 67-26", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("ceaea61d-450e-4347-aea4-a04d5af7774b"), null, null, "+365 31 (934) 96-52", false, new Guid("31fbc085-c45f-4025-bc26-03836052f67c") },
                    { new Guid("cedb4bc6-0e8b-4b1b-8719-5f50f0d38048"), null, null, "+17 73 (804) 26-34", false, new Guid("13d00315-a856-463e-abb8-2a7dd165ded7") },
                    { new Guid("cf338528-ca45-44e0-ba5a-c842d2244299"), null, null, "+784 60 (130) 86-49", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("cf80cb0c-02c8-4183-acf8-6ab1ae436e44"), null, null, "+591 82 (122) 71-06", false, new Guid("d364b716-4b5c-4090-99d6-0f11b5849701") },
                    { new Guid("cfc17c80-f0a3-4987-89a0-e55cbf40f28f"), null, null, "+351 15 (765) 84-27", false, new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("d036f286-e0fd-4281-971f-902ef3743c8b"), null, null, "+926 39 (761) 41-26", false, new Guid("8e6518ed-3b4d-4230-b784-6dfc5fe72d2d") },
                    { new Guid("d0960f94-78b2-43a7-86ef-4e9f04edd0b9"), null, null, "+640 30 (934) 55-25", false, new Guid("50895c7b-8921-4f80-9138-8cb1358f6ae7") },
                    { new Guid("d0bf1883-02ce-4162-8fa5-e22b260b404f"), null, null, "+388 46 (367) 86-14", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("d12c6899-e7a6-42b0-b3dd-eb6c5076830a"), null, null, "+909 76 (781) 62-69", false, new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("d140f48a-01f1-4eeb-b2b3-b293315e9f4a"), null, null, "+918 77 (387) 53-73", false, new Guid("5cd1d634-122d-4e15-a264-4c8b3ff98664") },
                    { new Guid("d1e58b3c-abd0-4da4-b8c9-09eacf514f9d"), null, null, "+999 87 (459) 47-33", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("d26c7200-aacb-4f30-ab68-b58f71b032b2"), null, null, "+359 23 (915) 42-21", false, new Guid("f63de249-3273-4ab8-b1bc-574ecf3abc11") },
                    { new Guid("d2d21b4f-9cf1-4bf2-9579-1d1b0ac0312e"), null, null, "+183 34 (495) 11-66", false, new Guid("b7546034-96c2-4526-86c5-7cacc01a35ad") },
                    { new Guid("d4129fac-0b30-4a34-9ff8-2f79bd426350"), null, null, "+986 72 (190) 94-31", false, new Guid("0b47c1ed-0a14-4d87-8b39-0660520eb31f") },
                    { new Guid("d412ae07-c91f-475b-baf6-497afa4136ba"), null, null, "+672 94 (233) 17-24", false, new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("d477b7ce-9794-4fdc-905b-b44bb07e3268"), null, null, "+668 11 (281) 68-45", false, new Guid("48935884-1ff7-476f-8bc8-62f990b03a3d") },
                    { new Guid("d4f137e6-6403-4e4a-bebc-f518033777b1"), null, null, "+569 06 (151) 60-22", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d549ee9f-01ed-4750-bcbe-b49ee5b961b0"), null, null, "+700 16 (215) 84-86", false, new Guid("983eb44d-a68f-4174-8aa7-0742fa0affd1") },
                    { new Guid("d5640c94-7c27-4024-b57f-71c5c305cc3f"), null, null, "+260 35 (626) 03-79", false, new Guid("d5908335-16ba-435a-9a9d-603eaee07878") },
                    { new Guid("d581c3fd-5b12-4388-a60e-287a049678de"), null, null, "+462 37 (978) 31-36", false, new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("d5e164e6-c1f2-47d8-89b4-5ba0ff659cf2"), null, null, "+734 71 (035) 84-74", false, new Guid("812d963b-edbc-48b1-948d-661ea6f9d645") },
                    { new Guid("d659e2b1-704f-4019-8fc6-aefb187e1852"), null, null, "+282 23 (849) 84-86", false, new Guid("fd051a5e-4258-4bbf-b64a-29676b007443") },
                    { new Guid("d65c2e14-d536-4d17-ad2c-ad051654fca5"), null, null, "+390 99 (074) 45-30", false, new Guid("937a87a5-848f-441e-bac8-fb5e59cbe3a6") },
                    { new Guid("d689c68a-3f8d-44c7-8327-1b170bbf6df3"), null, null, "+19 01 (283) 56-33", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("d6bfb1e3-0bdf-4003-8a53-678ad59a9c27"), null, null, "+341 74 (338) 93-51", false, new Guid("8c7cf535-948a-40ab-ad16-9b32d0189358") },
                    { new Guid("d6d1d4f6-c641-4e66-84f9-8dcb3b96d192"), null, null, "+913 63 (336) 88-23", false, new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a") },
                    { new Guid("d6dbc390-3889-4bcb-8fc0-dc66ab17b715"), null, null, "+98 48 (206) 72-44", false, new Guid("fdfc87c9-e806-471d-bdbd-8850965b9b37") },
                    { new Guid("d6e4058c-9f95-4b92-bae6-38cc1c495f84"), null, null, "+576 03 (856) 96-32", false, new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28") },
                    { new Guid("d6ec2eb7-1aca-42ae-998d-41fd7a6aec6b"), null, null, "+546 78 (270) 02-79", false, new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("d78dd362-8e3d-485b-99e5-aeed202ed165"), null, null, "+991 98 (709) 48-34", false, new Guid("c45e1eec-0743-4a1b-9e1f-f5733d7a8448") },
                    { new Guid("d79a79ff-7ee8-4984-8f41-662420c4edf9"), null, null, "+409 76 (443) 12-54", false, new Guid("ccbe97d3-303f-48ea-a894-58d8439a96a8") },
                    { new Guid("d7f3a31e-b596-4222-9172-e94639de434b"), null, null, "+596 87 (283) 81-52", false, new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("d868e54b-80dc-48c3-8b9e-368ca1eced28"), null, null, "+853 43 (774) 00-85", false, new Guid("668ffb2f-7584-4ebf-9682-65e2efe09535") },
                    { new Guid("d91434d5-59cb-4d3d-bf03-4a7aa4f957e6"), null, null, "+875 20 (407) 32-92", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("d9460389-0bb9-433a-9cd7-acf3ae743a8c"), null, null, "+926 75 (027) 51-39", false, new Guid("7117f168-cb08-4e98-a297-2ee36b438ecd") },
                    { new Guid("d99c7314-22de-4b2d-af1f-976ef9e395b1"), null, null, "+221 87 (764) 75-20", false, new Guid("035a2e83-eca2-49e5-a34c-3526f85ad930") },
                    { new Guid("da45b992-5788-4039-8c91-afbcf19fe05b"), null, null, "+359 74 (570) 07-15", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("db1b346d-be33-4d9b-96b3-ba8572967a7e"), null, null, "+215 00 (121) 55-81", false, new Guid("6d717976-193a-4962-947b-f15277ce537e") },
                    { new Guid("db52a3e6-8f67-4202-95a1-bd254e2a0207"), null, null, "+514 29 (553) 04-85", false, new Guid("fdcf457c-1e96-4277-8cc5-4d526130881f") },
                    { new Guid("db54c3e2-2382-4eba-ba65-7eb5ff9deba7"), null, null, "+668 97 (612) 18-05", false, new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("dbad32e8-29a7-4a9e-92d6-184203ed4d12"), null, null, "+701 24 (859) 88-24", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") },
                    { new Guid("dbd71690-370e-4f66-bbb8-8cdd855b8d86"), null, null, "+679 63 (676) 33-58", false, new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("dc6a0125-c58d-4e9d-9f2b-93f40945f83b"), null, null, "+441 34 (419) 27-37", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("dc714849-6046-4515-ae2e-99ef1ca155b0"), null, null, "+139 84 (500) 70-73", false, new Guid("51e76787-7a04-4a69-b833-e83e1ddd51ad") },
                    { new Guid("dc741f72-5f12-42bd-8eec-817358f3dda7"), null, null, "+617 19 (908) 80-43", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("dced698b-6c3d-409f-9a7a-119ed16deddf"), null, null, "+596 15 (660) 97-24", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("dcfc13d0-0d2a-4914-a1ec-0e5410d29162"), null, null, "+559 75 (758) 87-25", false, new Guid("c079dddc-72c0-480f-b87f-9b2e6029a9d6") },
                    { new Guid("dd1a01db-ff8e-4f5c-bd50-0cacb0a30902"), null, null, "+140 56 (218) 07-29", false, new Guid("bed9f5e6-ceff-4ea1-a292-a9eddaa74bc7") },
                    { new Guid("dd1b6add-23ab-4a27-87b5-11a238fa1e3c"), null, null, "+786 26 (546) 39-98", false, new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("dd86d64a-c3d4-4e6d-88dc-e215fc1eb23d"), null, null, "+38 71 (972) 81-79", false, new Guid("ceaacde3-54f1-461f-bf43-13adced4d581") },
                    { new Guid("ddad5060-7348-4e09-994a-aa9ad5de5393"), null, null, "+943 52 (561) 98-49", false, new Guid("728badf7-8393-4399-8ea8-d2dea8344dc2") },
                    { new Guid("df6b97ef-ecf0-4af7-859e-c4db0a5033b8"), null, null, "+791 83 (712) 93-88", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("df6d524e-cb63-43a3-8b63-63072368193c"), null, null, "+593 43 (691) 33-17", false, new Guid("33c98c0b-b105-489a-ac87-a0a71f706ac7") },
                    { new Guid("dfae4071-bfe7-421a-9638-de1722c6384f"), null, null, "+737 15 (627) 58-82", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("e0165a92-ea24-4607-96af-2c2c74a58cf2"), null, null, "+218 09 (601) 47-27", false, new Guid("46b3c135-9531-4a34-a52c-297d2f70edb4") },
                    { new Guid("e1190c63-885a-4109-a59c-de29d05c4317"), null, null, "+796 56 (326) 10-29", false, new Guid("bb3b56d9-e059-4c9c-8b79-e1279813c350") },
                    { new Guid("e1586d87-2175-4be4-962c-46ed66fdb3e5"), null, null, "+827 38 (987) 70-70", false, new Guid("b42262ce-53ec-424a-89c9-e1a6ee7f1b6b") },
                    { new Guid("e1841a66-2ad6-48bc-883c-970dcd0de4c8"), null, null, "+164 04 (128) 49-52", false, new Guid("d786eba7-a4e6-41b3-a88b-914c21ab4b92") },
                    { new Guid("e1f87f33-ae66-42c0-8823-7533d8c13862"), null, null, "+661 68 (105) 73-40", false, new Guid("63e71b26-e0fe-48d2-9b08-ce38a63a4dce") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e23e8a51-a0ad-4437-8c90-e8becc053ded"), null, null, "+586 30 (516) 82-10", false, new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd") },
                    { new Guid("e368de07-37e5-414e-b5c7-4f0daa3b7092"), null, null, "+510 64 (403) 13-12", false, new Guid("a1569d59-eba7-49b1-be47-ca2813f77b10") },
                    { new Guid("e422baf0-1f0f-4564-b119-13900d8fa29a"), null, null, "+569 03 (048) 95-45", false, new Guid("885e97cd-9f13-4c3d-90e5-f563d1d38651") },
                    { new Guid("e425024a-186f-4193-b594-d40c086a1c10"), null, null, "+957 94 (637) 62-21", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("e455c83e-367b-4ace-a613-6d0f7871eff4"), null, null, "+672 41 (489) 06-28", false, new Guid("78222848-8e4b-4cc0-aa2d-67e005151e4f") },
                    { new Guid("e4d65ccd-03ec-4f6d-b078-e08784d28080"), null, null, "+357 48 (141) 65-75", false, new Guid("b361027f-b9d0-4a16-a785-ac7411b485cc") },
                    { new Guid("e5351efb-16bb-41b3-8fb6-163783d5d3f7"), null, null, "+292 95 (495) 78-67", false, new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("e5558898-cfda-48fe-bfaa-86a3109f9a46"), null, null, "+75 43 (046) 98-84", false, new Guid("ce68e88a-db0d-4466-a2a5-031d90289f28") },
                    { new Guid("e60bed60-7311-4d6c-abce-ec44cd65f37b"), null, null, "+306 38 (573) 85-17", false, new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("e623929f-2faa-41d3-ab1a-897b299fb43a"), null, null, "+733 29 (417) 10-96", false, new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("e63e9cc8-c42f-4e45-9ba3-ed7906acae3e"), null, null, "+185 26 (165) 80-85", false, new Guid("7f343d83-488a-4f8e-bb83-7417580035e2") },
                    { new Guid("e644c9bb-f7aa-4df4-b238-5feac9c84691"), null, null, "+46 57 (572) 59-74", false, new Guid("e367eac8-62e2-4d68-a13d-f8b77ab69ddd") },
                    { new Guid("e649dddb-a16d-4e7c-8bd8-15f28aae434b"), null, null, "+802 91 (146) 61-54", false, new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("e6e2010f-8e58-4d33-9d42-dd01a68f2972"), null, null, "+724 20 (208) 75-59", false, new Guid("bf057140-33a4-45d8-af53-45e3337a92d1") },
                    { new Guid("e7173a4d-5a2d-4a3a-9d45-6ca2e1d74afe"), null, null, "+19 01 (367) 66-80", false, new Guid("6582c2a1-d13d-4d2c-82b3-49bb5d4d4aa6") },
                    { new Guid("e739a6c6-f6ed-47f6-b5b3-e806f5316eb0"), null, null, "+364 99 (707) 89-41", false, new Guid("13cc902b-ca01-4670-ab3f-def800c89833") },
                    { new Guid("e77255e2-6245-4c49-ba2d-967356d9b116"), null, null, "+148 89 (785) 24-12", false, new Guid("7a69aa81-9a26-42ed-b968-ae80733b08bc") },
                    { new Guid("e7e49e73-d89f-4f6f-aa41-a922a7aea50e"), null, null, "+601 70 (073) 25-00", false, new Guid("241ff9d9-943f-4735-a90d-9d47d7b981b9") },
                    { new Guid("e8095878-dba6-4faf-940b-e95be091dcb8"), null, null, "+74 29 (126) 43-60", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("e81c53a4-0b15-4005-b37d-537dd3a09c09"), null, null, "+807 78 (132) 04-93", false, new Guid("801d176b-6d5c-49d6-9f3a-50b415a3b2d7") },
                    { new Guid("e894d553-6a21-4489-9b8c-4ba892398e8c"), null, null, "+553 08 (265) 68-67", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("e8a503ab-2432-4998-b989-4d884a0ac119"), null, null, "+205 94 (338) 85-34", false, new Guid("a0b87f2f-db78-412c-a350-6a573c7906b1") },
                    { new Guid("e8ad6021-e9d9-4eec-9d8d-27e3ddadb1e8"), null, null, "+769 20 (412) 58-29", false, new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("e8b36959-5c6d-4099-82cd-f5f769830465"), null, null, "+99 14 (132) 63-22", false, new Guid("1ad11194-ed15-4c0b-b4a9-f80d3951a4af") },
                    { new Guid("e94d81c6-7c29-4d5b-b27d-d34eb5b9c441"), null, null, "+809 35 (807) 84-90", false, new Guid("b1626352-69e2-4e8a-b30b-be3da364d570") },
                    { new Guid("e9e45640-9923-4fb0-830d-0051e57e8ff0"), null, null, "+782 66 (789) 37-21", false, new Guid("ce8e980f-6dbd-40df-b053-cdb8ad87ab2b") },
                    { new Guid("e9f0f07a-59a5-4ad3-aed4-eda1aa9915f3"), null, null, "+157 33 (695) 51-42", false, new Guid("45dee853-0743-493d-b80b-c81b944cc529") },
                    { new Guid("ea123746-f693-4b79-9706-ba6236830c9d"), null, null, "+474 38 (845) 00-42", false, new Guid("47829859-34dd-48f4-9e14-1475a6b7ffd4") },
                    { new Guid("ea4979c4-c40e-4b8a-a4cf-8f6d4f2cf2eb"), null, null, "+546 96 (629) 28-09", false, new Guid("66bde12e-086d-4150-9c7a-89ea75047f12") },
                    { new Guid("ea6530e5-d6e5-41f5-8e77-f9a5a49ebf65"), null, null, "+980 65 (800) 72-36", false, new Guid("688b99f1-e6a2-42f5-86f5-52f93569e71d") },
                    { new Guid("ea942240-c84e-43ee-8a98-ef3f39a7badc"), null, null, "+550 98 (388) 23-41", false, new Guid("5ef4fa74-7c7c-4a21-a25a-2beb91978139") },
                    { new Guid("eb07fc13-d148-48af-b669-967a34122a1f"), null, null, "+109 66 (597) 65-52", false, new Guid("78cf7f13-f6c7-43c0-88ff-689030379445") },
                    { new Guid("eb2846de-dbe4-41a3-8c6c-3764675ea31c"), null, null, "+423 43 (529) 32-16", false, new Guid("2cba471e-f2f2-4e36-818a-d246b9637bbd") },
                    { new Guid("eb52cba9-ba8e-4a0d-a85d-4d5bcc75e7d8"), null, null, "+642 18 (681) 01-05", false, new Guid("6224405d-f9d8-407b-9f81-847223041784") },
                    { new Guid("eb795981-d418-4fd6-89f0-26de3f9b70c9"), null, null, "+830 04 (614) 51-74", false, new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("eb99c8cd-4b4e-439a-9e00-24d2e5a21d9f"), null, null, "+688 44 (471) 88-73", false, new Guid("549f6398-46f0-4e11-bc59-43c056078f96") },
                    { new Guid("ec020162-b118-48f5-885b-9832fd281b8c"), null, null, "+535 26 (404) 63-06", false, new Guid("fee25617-34de-4ee5-b5c0-934576bfb29b") },
                    { new Guid("ec2a179c-e947-40c2-8711-2ddcf1111b92"), null, null, "+647 65 (431) 38-78", false, new Guid("d7db4381-dcb1-4cce-b7ee-cea2cba85dcc") },
                    { new Guid("ecb45f11-e86f-4b15-ae0c-120b02e3c608"), null, null, "+894 19 (605) 16-82", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("ed757207-ccfd-4bfd-ba41-5592aa1500d2"), null, null, "+774 58 (287) 35-74", false, new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("edb7b3ef-dc9d-44c8-9477-219b75679141"), null, null, "+377 12 (938) 96-90", false, new Guid("45917911-5af0-4724-8a58-1fe212041071") },
                    { new Guid("ede80831-20d8-40ff-95c9-95ff5a8b9196"), null, null, "+959 83 (552) 92-00", false, new Guid("7d2e11ac-9cce-4b97-a65d-760d42dafebf") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ee3c2289-469e-4af0-a6ff-7439fd11b1f0"), null, null, "+313 31 (225) 15-33", false, new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("ee4572fd-e245-437a-9d5f-62abc632ed73"), null, null, "+863 08 (196) 69-79", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("eed606de-55d7-4795-b3d9-99d6d48787dd"), null, null, "+765 27 (903) 26-71", false, new Guid("4a0df5aa-c7e5-4726-b0af-b81bebd83e03") },
                    { new Guid("eef6759a-7c05-4b3a-88ac-33d3c4d2033c"), null, null, "+234 15 (787) 53-14", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("ef676476-22ad-412f-ae0f-62b8c48fc7f6"), null, null, "+457 94 (470) 73-74", false, new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("efd2f060-3566-47d9-b5b5-e732add6e8f8"), null, null, "+286 07 (451) 59-58", false, new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("f027875e-27b0-4ddc-b744-6a46fb21ae17"), null, null, "+274 83 (965) 65-89", false, new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("f0cc8bf0-0b10-4e0e-aa5d-6131f3fe925d"), null, null, "+209 24 (938) 52-44", false, new Guid("690a8917-cf12-4105-b3ea-e261200fd3c1") },
                    { new Guid("f0fc6dd1-acb8-4a4f-8531-d515a9e2185a"), null, null, "+919 96 (588) 51-80", false, new Guid("f8a55fad-38e8-4cc6-9279-2c6b62546982") },
                    { new Guid("f1e58118-b340-435c-9e17-7f924fdd2efb"), null, null, "+205 45 (848) 54-67", false, new Guid("11b91a19-66b1-4a2c-9a13-046ab8d5e9cc") },
                    { new Guid("f22cfad3-c569-4c13-b8ec-a76a00b2adfb"), null, null, "+424 93 (890) 11-55", false, new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("f23b3e88-7b74-4991-8b19-2e40c08f76e8"), null, null, "+805 62 (581) 79-72", false, new Guid("d5968dae-e2b0-4733-9822-c1765d68bd84") },
                    { new Guid("f25778f1-341b-46a1-976a-e598e4553065"), null, null, "+169 35 (308) 51-01", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("f2827d01-4aa5-4851-a89a-9bb1c1535ef7"), null, null, "+475 23 (926) 21-74", false, new Guid("010005dd-df44-4e9e-82c2-1a231e07de5d") },
                    { new Guid("f2c147dc-a180-4601-a697-db02d877b2b2"), null, null, "+586 34 (798) 98-48", false, new Guid("eada0502-f63b-424a-9d81-244529d74dc1") },
                    { new Guid("f2e3fa14-7491-42dd-9f93-522c59a98cdb"), null, null, "+305 27 (099) 46-88", false, new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("f395b105-b427-4a0d-aa9e-4b0d49edd652"), null, null, "+114 67 (142) 26-62", false, new Guid("48cace70-1194-4581-914a-6aae6159826d") },
                    { new Guid("f50d5048-d4b2-45d8-804c-cdcdddf27b4c"), null, null, "+580 07 (317) 74-46", false, new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("f5309e05-aeba-4c3c-9eb9-ef6016c66819"), null, null, "+176 74 (177) 82-15", false, new Guid("a5a68856-d32c-447a-93e7-319e6b1be3d9") },
                    { new Guid("f55c1945-c2cc-414f-b6bf-a3e618e8099e"), null, null, "+202 64 (771) 14-10", false, new Guid("8a966506-353d-46f9-91b9-9431f8562c71") },
                    { new Guid("f589a48d-4a1f-4e3d-a85e-682f74866860"), null, null, "+117 61 (100) 19-94", false, new Guid("d8fbed4d-5b67-4c43-b28d-42e3b6d4ecc8") },
                    { new Guid("f5ac9e0a-2368-4a56-acb9-caf28b8df9e4"), null, null, "+337 54 (496) 34-68", false, new Guid("d3b6f17c-a864-49ce-9a0e-7a38c88e3919") },
                    { new Guid("f5e814e4-1b6d-4fcb-b55e-092c15ff8153"), null, null, "+37 38 (560) 93-86", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("f5ea4eb9-c50c-4765-bc93-04b981edc04c"), null, null, "+866 34 (123) 80-35", false, new Guid("3f9dc513-8c49-4bba-80ce-93369a9ae235") },
                    { new Guid("f64795c4-e97a-42ee-827b-2cad00202940"), null, null, "+612 72 (484) 98-80", false, new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("f6b60967-b4c7-4e0b-b33f-a88f4082243b"), null, null, "+230 95 (435) 51-34", false, new Guid("82b014c4-7208-45ad-866e-bb82c82db592") },
                    { new Guid("f6d52598-4c65-4871-91dd-c26256a5c2a7"), null, null, "+38 03 (516) 20-93", false, new Guid("08f69fcb-a5ff-4d78-9d1a-034d197d74cb") },
                    { new Guid("f6dfbd45-a04a-4b3c-b7c2-877827f30ea7"), null, null, "+799 25 (140) 26-57", false, new Guid("7d6d5873-e76c-4025-8e87-08fa6120b7d9") },
                    { new Guid("f763ded2-5145-4a9e-8464-1c5cdd2993ee"), null, null, "+971 72 (339) 99-27", false, new Guid("7d025ec1-413e-4d56-965b-bd7fa58bb116") },
                    { new Guid("f76ab1ed-34f6-4385-b4db-0145273c54a3"), null, null, "+946 75 (373) 23-82", false, new Guid("9cee3eee-e473-4809-b63d-d810bb9f0b5b") },
                    { new Guid("f7bfeef2-21f0-439f-bf31-302e649422f5"), null, null, "+115 12 (007) 21-34", false, new Guid("24bba056-fbdf-40a7-9e53-727f4fdb4962") },
                    { new Guid("f7f79715-7faa-479f-a895-63bcbbe46165"), null, null, "+262 62 (652) 33-23", false, new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("f80efc16-6859-460f-8b7e-af61ca3cdf4d"), null, null, "+929 92 (707) 05-66", false, new Guid("5a18db8f-264e-4182-b2c4-365f897e57e2") },
                    { new Guid("f838b74d-482e-4ac1-ba41-fb12af7c09fd"), null, null, "+753 74 (659) 02-73", false, new Guid("8c8dd897-ab08-4a2d-bde7-02484f2be1e0") },
                    { new Guid("f8c130ee-09f7-4541-9951-901f62c17fd2"), null, null, "+326 70 (202) 04-94", false, new Guid("9645c8e3-5754-49ec-a45b-1d4460a7388d") },
                    { new Guid("f8de2a04-b9c5-476d-8ac8-28fd92c9f2e9"), null, null, "+391 78 (347) 03-64", false, new Guid("302771bc-d672-48ae-9a96-c489ccacf75a") },
                    { new Guid("f933d0e3-2af7-4b48-b3e7-358b8c52cb63"), null, null, "+252 47 (461) 29-82", false, new Guid("b1bc25ae-98d1-40f8-8178-7b30961ded86") },
                    { new Guid("f94e646a-1abd-4ff1-b4dc-e18b62d5f3ff"), null, null, "+292 51 (374) 03-58", false, new Guid("e57373e2-48de-4c55-9c02-9b87c7751318") },
                    { new Guid("f954b1a1-3504-4de0-8a77-85f7a27a12e8"), null, null, "+931 69 (976) 76-51", false, new Guid("467b1a76-da88-44c5-9650-439cdbc11ed3") },
                    { new Guid("f96d761a-2219-4c5c-adf7-30aa19cf50b1"), null, null, "+185 00 (845) 99-07", false, new Guid("97b3365c-6e0a-44c3-a268-ed56cb0a7945") },
                    { new Guid("f9e536ab-28dc-4019-b113-cb848d82916b"), null, null, "+196 60 (907) 78-64", false, new Guid("57f6f220-03b1-4ebd-923a-576083ec5ae1") },
                    { new Guid("f9fccf60-e1a9-46fd-b4d0-f42cd2cab516"), null, null, "+935 99 (693) 35-60", false, new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("fa0d0564-a49e-4daa-b812-755354049532"), null, null, "+220 48 (792) 67-45", false, new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("fa372ca8-eba4-44a4-b38c-670c3c487b5e"), null, null, "+696 40 (224) 69-65", false, new Guid("d7906fca-51de-4edd-bf26-dc1b5fac7b36") },
                    { new Guid("fae2ad3d-7f51-4db0-8d39-4f2bab92f260"), null, null, "+37 26 (673) 42-54", false, new Guid("0aecfa42-1b41-4121-a90f-0fe77a02c9d7") },
                    { new Guid("fb05f2a2-ebf6-4a41-a1a7-3629db91abd7"), null, null, "+693 51 (371) 26-97", false, new Guid("cd1d8c6d-8ec8-4b3b-b097-e6d735bd266e") },
                    { new Guid("fb5eef53-8252-4f73-959d-092ad4d7cef7"), null, null, "+698 54 (841) 51-60", false, new Guid("2765e2f8-b49a-45eb-9f36-ea4d6994098e") },
                    { new Guid("fb946bab-0171-46f0-86ac-af3ab1d32025"), null, null, "+123 91 (411) 23-30", false, new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("fbe89321-c10b-4115-9474-850899f2849c"), null, null, "+445 26 (853) 54-99", false, new Guid("3c61b8f4-b2b5-4ace-9f44-23bb6fc83f51") },
                    { new Guid("fc1ddb35-5b05-40bf-953a-8d94cd548f5f"), null, null, "+564 85 (467) 86-63", false, new Guid("942ddb1c-77c6-4285-b1e6-45c767c00a77") },
                    { new Guid("fc6d77f9-dc7e-42ea-9a3b-4242063f3bbd"), null, null, "+636 24 (438) 47-31", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("fcd45b2d-b8ae-442c-addb-f20ca1aa1a1f"), null, null, "+376 24 (985) 59-57", false, new Guid("61a2acc3-3e0f-4dc9-a6d4-d3dec15a89b6") },
                    { new Guid("fd10881f-ca1b-45bd-9561-1b4aeb85df82"), null, null, "+937 80 (534) 17-72", false, new Guid("5a1227bd-cffd-4b21-ba80-8358f8367546") },
                    { new Guid("fd543c25-836c-4284-aa41-9282725a7b05"), null, null, "+810 32 (058) 33-95", false, new Guid("0b97e5dc-1d68-4dba-a97d-2c97bbda388a") },
                    { new Guid("fe20ed9e-66ce-4943-8c6a-a8646b912320"), null, null, "+909 95 (443) 04-56", false, new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("fe6e4535-fb89-4834-acae-b450b51ef86b"), null, null, "+319 36 (048) 78-81", false, new Guid("24de53b2-9047-4e88-9b51-10dbfb204efa") },
                    { new Guid("fe7469ce-c15a-4f6b-8f48-fc9820133e1e"), null, null, "+18 08 (205) 52-89", false, new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("fe85e157-84b6-4a17-81d1-4c836a147c05"), null, null, "+15 42 (267) 78-78", false, new Guid("7500ba4a-ad3e-4574-aa61-84fea8faa5ef") },
                    { new Guid("ffbded1c-0e5a-48dd-bec9-738d070db7db"), null, null, "+274 80 (142) 46-10", false, new Guid("f44793f6-1947-42b2-8e1e-19173cfba3c2") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("034334b6-a6bc-400c-85e7-9ee02707b121"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8cbc0560-85c1-4b7c-b2b9-8c8c65fe154c"), new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("1037f8f9-54d5-4116-be2a-01c938ed410e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("59a34075-c9de-4988-ad9e-e29d52adc419"), new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("1b1fe496-4d67-43d6-af2b-0955aabe1938"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1b6af4ac-4168-48c6-825c-941c77d26738"), new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("226c571e-b5d6-4d7c-b93a-cc3ee9625d7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("23a44ef9-18b9-4840-ae5a-99a2855c1c96"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("253a9811-58de-41f0-9474-b28cdfb7b773"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3c5c7988-2687-4c88-8fb0-d3a1de4ba83d"), new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("28e9baeb-8c90-46d6-9ea8-2a86e4292d53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6be9c9f1-92e7-489e-9947-28c4ebcb07da"), new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("2997ac88-9268-4120-bfae-784724b1bf15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("77acbfc2-c37b-42e2-9384-292aa3858fc5"), new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("29b6be82-8b4b-453c-b061-7cf7541c1302"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8f865813-2262-4054-87da-c015db4a0235"), new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("2b3a955a-df07-4c36-9e66-912ccd0c1d01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2a1ee4ec-ae44-4660-aeb8-e9a50af02520"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("2b46bb73-7e83-4fd2-bd9d-99f3e67df584"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ad0267d0-8c23-445f-b75a-21045c581d4d"), new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("2bb06b57-439a-491c-8f60-1a48f851325b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("56424ed1-921a-4063-abdb-2bd2a0003da5"), new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("2ff99ed2-1d02-4c3f-8593-d1ee245282ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6be9c9f1-92e7-489e-9947-28c4ebcb07da"), new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("3fbe9739-27e9-4a46-9057-c44fd0394e5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eba11228-da24-4b2b-aac4-5f004c9f748d"), new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("401aba19-59da-4481-b268-95b73a861e70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("99b386f1-5066-41bc-98ff-afddcdcbe48e"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("40fe6218-95a7-45c9-88ca-4b0bc5ff1f3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("57a39ebc-7161-40c5-87ed-0e295c059326"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("420306cb-44d3-4d51-9ce4-46469daff463"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("74ed015d-4f6f-4a03-929f-bf29a9a5465e"), new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("44c367de-53bc-4c01-a63f-c862e0d3bf39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27804530-9aec-4dd5-ad94-34821cfe8e7a"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("46c29f0e-409f-44e0-97a2-99d14aa918e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3635afb4-1f25-40b2-990d-9bf8a97f497c"), new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("4a092c4a-f454-43ae-9b1d-894cc36c260b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("71a429c5-a18d-4115-8434-fc269dc94af8"), new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("5634b2d7-e912-434b-aa37-05f29b8a9e7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("74ed015d-4f6f-4a03-929f-bf29a9a5465e"), new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("5e5e230f-4325-4e94-8af6-cc58abdb5bd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ac5247aa-8ea7-480b-90ac-d98ab7183b53"), new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("65252e30-de9c-4689-9e0b-ebca2b807ca0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eeb45b39-973f-47e5-b4a3-c2eb8784e6a0"), new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("686915e2-b28b-41ee-8528-03d924f7b8ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("05c97cff-b6da-495f-83e6-3d8c6c5c4d76"), new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("6a60ac3b-a7b7-4485-a199-41b548bb65df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("77acbfc2-c37b-42e2-9384-292aa3858fc5"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("6b0005a8-c5e2-4f11-b4c3-1be372a7f0fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58fc610f-5227-4df8-b28c-ddcfd4941cf9"), new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("74093da0-e02b-4cb2-baee-ae38fadce465"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e54ff9a7-c847-42bf-9c5c-ab9057b75f4c"), new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("79bdf467-1852-4cec-bd83-1cfef899777c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27804530-9aec-4dd5-ad94-34821cfe8e7a"), new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("79d009f1-6a58-4928-8eda-5c35100c3775"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d67e914-dadd-4cce-b287-8a8188c890d0"), new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("8188b3dd-b296-4023-bccb-ac9ff8a23909"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("371bcf29-70fa-448c-9b8a-1ff6ffda1f58"), new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("8907c8f1-fc2f-48b4-8b22-7e5b81c33031"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("05870b14-9152-4ebb-bca3-6b7e4e9590c8"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("8cb2ccba-d3e1-4f65-b97f-d0ff12ea4adb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("07338213-2f73-4df2-acc0-5b9748c407bd"), new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("8ee33486-8069-46e2-96d4-5e847c4cabd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d67f3664-9478-4003-9c2d-f8fb3e202c59"), new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("939d6c24-9f76-4422-b024-63f902d64b96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4688ecfe-ca83-47ca-8906-648c067f2f52"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("9661aa03-fa6d-45a5-8dab-2348496075e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b7f503b5-54e6-469d-95f5-32242964d036"), new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("9a3155e0-a04d-4725-b692-c126ef6a18b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("914f881e-6b16-49ef-923c-e91e082d05f8"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("9aac133c-ab65-4423-8f74-59fbbc9e42a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5afb3456-a489-4267-b95c-a4e9283f2bff"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("9b601413-252c-4c59-b65c-c617dcdfbc20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6a2b484a-1660-4d1a-b9e1-3e9d6ffc48cb"), new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("9c9106af-9cc6-4daf-8fc8-e97cc2f7acb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ed956c6-d7b7-4227-9938-b6a3cbeca0d2"), new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("9f3207e5-5829-494e-bdfe-1b19b55f07cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0709dcc6-cb13-4fed-a0d7-2823a8fdb607"), new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("a08b714a-cc94-4d85-9b92-d77e26467c79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("82fa8a68-7c62-4d2d-9ec1-28fc765fdffa"), new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("a133d324-94db-406a-88e5-315a6e55eba9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2cad886a-f84c-4904-baee-d92b1598b948"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("a3a87842-5f14-4277-9aa1-0e9fad9c95ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("beea5e38-690d-483c-aba1-403b53470c5b"), new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("a3d8bc2f-1125-43c5-ba7a-1ce94a4fa9bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0e2352c2-7003-4e1f-b403-02ccc0e17724"), new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("a3ef4685-425e-4c41-9e6a-fd9902c6504b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ad0267d0-8c23-445f-b75a-21045c581d4d"), new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("a61ec6a7-a4fe-4072-b84c-36e93e514b78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3635afb4-1f25-40b2-990d-9bf8a97f497c"), new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("aa304e5c-abef-4456-b13b-31c6c8d3e2ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("478fd918-8d28-4c2e-89cb-27d3a145bdd7"), new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("aa513243-7241-4e0e-9b3a-93f38cc1345d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("371bcf29-70fa-448c-9b8a-1ff6ffda1f58"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("ba1e9b75-fced-4545-b7aa-1ed927b0b2c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3819733c-6c71-46dd-8b87-958e9e1f349e"), new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("c1ab8c7d-d6b1-4d1f-81b9-4503682c1814"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("022db5f2-19b9-4f2b-996f-a43976ce80b4"), new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("c99f4116-1fbb-4345-bc95-2faada772d76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3635afb4-1f25-40b2-990d-9bf8a97f497c"), new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("ce92e951-45bb-49f4-b80a-55d09bc803c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cfd25cff-f887-4076-9633-34a1216746cd"), new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("cec4c9c6-9e6c-486b-9006-6af91dd9b317"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b7f503b5-54e6-469d-95f5-32242964d036"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("d01e323e-2d98-4f39-947b-b7e0b18f27e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ac5247aa-8ea7-480b-90ac-d98ab7183b53"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("d3f90db6-7fa6-493c-9b94-106f832311da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58d0d1c1-6e01-4b3f-96d0-1d7ba6db415e"), new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("e3860748-f14d-40b5-a153-fc99b78563b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b7f503b5-54e6-469d-95f5-32242964d036"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("e69ce9ba-b48c-4c5f-8e40-5926d296f8db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("caf68574-fcc4-4e12-832b-ed2363d1b6aa"), new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("f5420308-b9ef-4df0-9a79-0e35c86aada0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ebb147ed-0d81-4dde-b133-38b3cfcd60ad"), new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("f66f790f-f144-4992-921e-a95b86eef5c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e54ff9a7-c847-42bf-9c5c-ab9057b75f4c"), new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("f6e8b753-b54e-4933-ae7b-36aba875be71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("73eb64bd-c584-4b40-883c-f8b91ece15d5"), new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("f8809240-2b18-462b-b83f-9737214a22b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4688ecfe-ca83-47ca-8906-648c067f2f52"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a9217d4-b9d2-420e-a2b4-b44740bd1426"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("75486ce7-cadf-4737-959d-935dff0c6fca"), new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("0d617618-2719-4340-90e0-220c80fac6d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d6309bca-ef68-4ee7-a29b-c20aee2d5ee5"), new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("1c8947e6-208e-4ea4-8377-9fd707eacbdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5183d45d-7b99-4bf2-9900-625901debc6d"), new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("2d984a9d-682c-4203-92a6-6e6790ef31f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("67e54b10-bc50-4ce6-9193-22cd543ef7ee"), new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("30742d0c-b8ac-41df-9598-63bbf46147fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f47ce57b-f251-4739-8576-c369583722a0"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("35a77e8e-0350-42ef-9c73-e096a21ddfc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("003d1887-4605-4fdb-ac60-2e4133d54cff"), new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("36c01cb3-4c66-48dd-8411-ab7b1f738b15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("749a0eb0-9c70-4dd5-993c-6ae561de3f7e"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3e04e0b5-4c1e-4095-b2c1-311852689826"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a0700f7c-9e39-47d7-bb7a-bb7a7641131c"), new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("4543fcdd-9d32-4cd1-a373-390a4409d45f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("edcb3836-2d00-421f-a937-e581c0a8a218"), new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("6a94a0d1-76f8-4952-b01e-6598cd13074c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb5ee772-78b0-4831-97de-b2df713b6b9d"), new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("6cc9fced-3ed4-45e2-bd68-5b3ae87caac0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("793c0670-4d9a-4da8-9275-444d022476ad"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("718522ea-2165-43f7-af68-75bd66c2d85b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d7912e41-bde5-4fa2-bc59-44621b0d08f1"), new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("73272738-eaf2-455f-ae0a-ed030bf105a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5200c01a-8687-477d-b812-8e91914001c6"), new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("759eb5c8-8021-48bb-9d90-8cc0e0520ea9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4d94c68c-7ab2-401c-8374-17bebc2be091"), new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("784caccb-d9b5-449e-a9d0-a6e1d283aebb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bd32ebc2-e84a-4897-9606-9d262e7389ce"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("7a35237c-a978-40ca-aeb9-2532ff5df583"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5b3d04d1-99f7-490a-badb-10d82779169f"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("87a13b60-f9eb-4407-9aef-7cb9013c3387"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8200cab7-7ed3-44a5-9c49-ad9e2da6ac5c"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("885a215c-94ab-469b-bb93-b046c0a62a2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a13ced50-96aa-4a30-994a-151ecd66f0be"), new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("8accdbd7-93e2-491f-b2f9-5b8a140881b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ba4bfeba-9ef8-4902-a837-30e456300134"), new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("8cb6b155-532a-4d9d-8850-4395c71970b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f47ce57b-f251-4739-8576-c369583722a0"), new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("8ce6c082-c910-4921-ad39-3149e59ee464"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("46e9c672-761b-4083-8bd2-ea6ba4231ac1"), new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("92670a13-a7de-4cc1-a589-6f728c2adb09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("402d9648-11b5-4cb6-a484-9d113fbe204a"), new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("957cd109-a055-4e34-b491-1e6951040722"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d4203bf-e57f-47bd-814c-41131e3f3184"), new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") },
                    { new Guid("9717e4b7-6152-4bdc-a3be-c217126beb96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d5e9072-3d3f-47ff-991f-848f9c7339e8"), new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("9acbb503-ec52-4fee-bca5-024ea62b067e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("67e54b10-bc50-4ce6-9193-22cd543ef7ee"), new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("9ad0dc23-ed15-44a6-b532-08257427e2f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("921d5b7a-2504-4e61-b423-23fbdd44d571"), new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("a09c9c32-186d-4940-8412-52be36ae680e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("edcb3836-2d00-421f-a937-e581c0a8a218"), new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") },
                    { new Guid("a380f815-ac65-40e7-866e-a2cdd9b51f53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f8062855-4189-4ecb-96ec-29c81195aa22"), new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("a52302e4-421d-401d-afba-850ef5e5c163"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eed649f3-b0de-4d80-bace-9bb909e59ab3"), new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("ac6f146f-bd64-4ddc-90a2-5ec0b3c14e9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1ea52291-fc3f-41c6-b947-d538d9086ab7"), new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("b27ecbeb-8638-49e4-8a40-774c5628c5f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d48cb88-ca0d-4da1-9b53-5ef826784312"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("b377ce90-3660-460d-be73-6a34c5e437dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aeb71f09-f9d5-44dd-8c09-d5c4b14a18fb"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("b4f0b66f-2ad1-42b7-b4c8-299db14898f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("29a96da0-7e18-4de3-bdef-8dc4fea533d1"), new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("b9b93149-35a3-4d99-a430-4edf8f2f3579"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f8062855-4189-4ecb-96ec-29c81195aa22"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("be5b315c-de66-4337-84ef-7ecc16eb5a30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e6247e02-b2d1-4f64-86b7-0e89dcf5baac"), new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("c23d398e-e36d-4e39-af75-029ec87f9c47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eed649f3-b0de-4d80-bace-9bb909e59ab3"), new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("c3042e90-51e2-4a05-9c0d-cdd80d87b5cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("921d5b7a-2504-4e61-b423-23fbdd44d571"), new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("c3afcc30-07cf-42c5-a64f-f9716959fd9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b62d02f5-8e31-4de8-99e4-cf461717da24"), new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("c50eed1e-615b-40d5-b651-f29ea0374b2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eca4e679-74a1-4a10-937f-ca2895f7a972"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("c5a0e65f-b59d-4985-b469-5b734d5c0863"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aeb71f09-f9d5-44dd-8c09-d5c4b14a18fb"), new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("c60487cd-aff7-4b53-9ebc-ec9e63db23e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("402d9648-11b5-4cb6-a484-9d113fbe204a"), new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("ca13b679-0ed9-4085-a0a3-8c45234c389b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ad0f72de-e8ef-470f-b9ab-181d018653bd"), new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("ca434a1f-8ed3-4196-a7e2-881751eaa36f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("003d1887-4605-4fdb-ac60-2e4133d54cff"), new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("ca8af27a-2829-4b3c-bd04-d88235816601"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("29a96da0-7e18-4de3-bdef-8dc4fea533d1"), new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") },
                    { new Guid("d14ddb16-e0b3-440e-9d63-1e98934fa190"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a51e0f6c-9a17-4a01-9d6c-7a947902db64"), new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("d42d4267-8275-4abf-b6cf-6421381a4360"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("154ef1ad-ea7c-4deb-882f-78a73c45a0ab"), new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("d4cdc906-7402-4b43-859a-26af89f6ca29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("33640849-1b46-4a2a-95ca-20707a68d326"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("d64d1298-10a4-44d6-adb7-2b5c7f091dec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("edcb3836-2d00-421f-a937-e581c0a8a218"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("dbf3bd16-bb2f-4ac3-966d-c404e691af7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d7912e41-bde5-4fa2-bc59-44621b0d08f1"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dc01cc3c-7816-4662-94a3-0d15e2e76dd5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("180ddbb2-63d7-480b-9b85-cc42673359b8"), new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("dccb748a-e648-43b5-b196-394abdd1b55c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eca4e679-74a1-4a10-937f-ca2895f7a972"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("ddfc9556-31d6-45c7-906e-f95b0a725365"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("22a1b76e-b1f2-45a3-af31-bb85fa77b888"), new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("e2e89a1c-6c45-4fbf-9877-c02f515a3c26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c721412d-ec33-49d4-a3e6-7bb1e5519d38"), new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("e6e76d81-48aa-45a2-9eed-a48b914698fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bd32ebc2-e84a-4897-9606-9d262e7389ce"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("eab033ef-1732-43b1-93f3-d881d7d4dad0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("67e54b10-bc50-4ce6-9193-22cd543ef7ee"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("ecaf09b4-4290-43ea-995b-67d89325c54b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("88b66bcc-1769-49f0-8097-43cbd801dac5"), new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("f24d1430-540d-4add-ba5a-38c14b4246c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84007fa2-0074-4e40-9b2f-94e32a81fcb5"), new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("f57d953a-f16f-48b7-9c24-c57bc2fcf0d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84007fa2-0074-4e40-9b2f-94e32a81fcb5"), new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("fa784ccc-1909-4684-92ff-17cd4b8fdbb1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eca4e679-74a1-4a10-937f-ca2895f7a972"), new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("fba8ec3c-159b-4d04-ae34-8a8b8f71ae23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bc3c8683-6976-425a-bb56-da905a5712d3"), new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("07b45973-63a7-4c4c-948c-c2f3513b71fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3e100a79-4104-43be-9674-b3eba837a5d5"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("156ff050-7111-4411-b3a8-e4bc5d837827"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("66fa4b6f-9935-44d9-ad4a-9c3cbeb1e3c0"), new Guid("54628aea-e6c1-47db-b7ce-b55b45d02bf9") },
                    { new Guid("164fcb30-d7f1-400c-8535-88d8a41615dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("113cf477-bc35-4332-802f-3c634a405e85"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("18d3cae2-346f-4779-ba76-1e0029921927"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("66cbafb9-e7c2-4ccb-9052-7487aa27fcca"), new Guid("219b0f56-d6cc-46ef-8868-1015103b116a") },
                    { new Guid("1d0840f4-bb68-4521-81df-579e2d010331"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ba143c24-6052-4153-978e-0a2257f22c84"), new Guid("0fc27c31-ca71-419a-8df7-391205e73c05") },
                    { new Guid("203e2f69-fcaf-47a5-b19a-2c47fb5d7eca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("95e4f434-7842-4f1f-92e9-bd344765c31d"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("22b5c6f7-654b-4ee3-b9ea-8fa93cfd7085"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("20d0d01a-a8e5-4643-ba9d-ce3ee992b5db"), new Guid("20b4f78c-9848-4837-bd63-1c190f33dd19") },
                    { new Guid("30a1ea25-8ead-4426-a403-fc5259eb2dad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("228d80ac-b321-4a55-b80c-8225adc92d39"), new Guid("ee8b843f-efdd-417f-bbfd-7425bb257070") },
                    { new Guid("3f2a7335-e17e-44c9-93c6-e62f6dda50cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b343f80b-dfb9-42d0-9d45-5f5eff2ca6e1"), new Guid("4b02b5bf-ceb5-497b-be76-71be4badf4c6") },
                    { new Guid("4961a57a-22ef-4b89-bbda-8a040121fdea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e27d106f-16e7-4f71-9de6-22f4cb0397a3"), new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("4ff8c412-00a3-4489-801e-e7a19cf61a45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("41368ffa-7dc3-4756-9b02-36de8a0dae63"), new Guid("88dff7e2-2b7d-4926-babe-cb3256cf051c") },
                    { new Guid("5607e05d-119f-4062-b40e-4346fcbfb2ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f6f90024-2e40-48dc-8efe-b36b7b690430"), new Guid("8d3744b8-0b9f-445f-9b8f-6f9dd0b35756") },
                    { new Guid("58f4392a-7317-4d17-be84-940cfd6628aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a16c2f41-e810-4d2c-92c6-7f576a5be9bf"), new Guid("a641f299-a530-47a5-a349-a4d8e6eab13a") },
                    { new Guid("5c90b560-73cb-468b-9324-c21748af19d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("18906e1f-de41-42f7-a94e-f603be94ea42"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("5da0fbdc-d286-4fe8-9582-178c1250e17c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f2ad6ab0-1b52-437a-8ac9-ef4f5df108ef"), new Guid("a030d800-7dee-4af6-9714-7607209659cc") },
                    { new Guid("6377854a-2737-49ba-a6eb-b33fe7eb7103"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca11046b-e206-4b60-a4cc-a72e529f97a0"), new Guid("3d88d069-1035-458c-98f4-4da7aabe8b3b") },
                    { new Guid("6f02c038-4644-4193-aab8-1f10ba7e7a44"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f0cf6c54-1d57-4da5-8aa4-335f30b514db"), new Guid("722089f0-4f8f-4a58-a620-a0a0708adea5") },
                    { new Guid("71552bf6-62b5-4985-9c23-0baea8a62e58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76313eab-ff63-43c1-83ed-c790a05250b4"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("729f4f15-cec3-46df-8a87-7ae5bcac253e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("66fa4b6f-9935-44d9-ad4a-9c3cbeb1e3c0"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("7abf4243-688c-4945-b158-743017b082b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8e187874-8d24-4b44-9224-a31f5d8a4ee4"), new Guid("584fa761-dd8b-4f86-a1d2-17ab88636fd3") },
                    { new Guid("7b3a96d2-170d-493e-9664-4a4398736d54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b89ceeda-0126-4c14-bc7f-3b54980ffd65"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("7c423d65-410f-4fb5-8a2c-979cfdd1ef60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("06a2df68-c005-4e8b-b16a-ccf80fe248c4"), new Guid("e3be09c8-4960-4e3f-b2af-5f1d2f4d6f18") },
                    { new Guid("7d7bbf64-cc12-4b40-939f-749ed2040182"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0f85fc87-076e-4691-801a-81d8188a4d5e"), new Guid("d2d36dba-a3f6-4ddf-bfc4-5bc202d65e52") },
                    { new Guid("80a517c7-8381-45e6-97ec-bddd8896d1f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ed945ce0-a652-4a6e-bb24-208f9c6a8bd5"), new Guid("7e97ff4a-e3c3-4f1c-b082-d4bcebe6f020") },
                    { new Guid("8114d54b-f25a-4f01-9084-cd5b0878a5be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("99e86b66-4a51-4f29-bc77-600c5f9db367"), new Guid("1ab02681-7419-4ba4-8712-d5c5867b4cca") },
                    { new Guid("899413f2-7348-4eca-a89f-dab053bc2e2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("32dc1af2-4fa7-48bd-8eaf-e2bce901862f"), new Guid("15e69be5-ae3a-40d2-82ea-dce2b0880413") },
                    { new Guid("95a1d97b-defb-4a51-9e28-93c404bb4b0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0c5c87d3-75a0-4ac8-a001-579d8d3396d0"), new Guid("2f049da2-3389-49ff-a450-f063e5a81fee") },
                    { new Guid("992eb945-7630-44d6-842c-4b2ac6924b3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca11046b-e206-4b60-a4cc-a72e529f97a0"), new Guid("46e2d6c6-f06b-44e1-8248-d6c398f9844c") },
                    { new Guid("9d05e791-7449-4fff-89a1-366b616b4073"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6c23a95e-43fb-4e14-a895-841a77f1ffbb"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("a1d24a49-c7b0-4f07-9ef6-ca3dd49493ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4244b9be-0eed-4e26-95d2-15340cf696d2"), new Guid("199a5b8e-fc17-4726-91e8-0ffc1df1e779") },
                    { new Guid("a993c08f-454b-4aa2-9779-dc7b6ee9cef7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a17d51e9-777e-4f23-b0e2-0d3db0b52c23"), new Guid("1dd04116-a197-48d8-8fb9-23e35976f32d") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("aa234247-9919-4899-ba16-6da5625c1cd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b4afc82e-56a0-487f-b740-5502afc1f8d1"), new Guid("893c13aa-b1a9-4905-8b3e-b33568727c33") },
                    { new Guid("abe53d74-6a6b-493a-a5a0-74685c4b2ca9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca11046b-e206-4b60-a4cc-a72e529f97a0"), new Guid("e482af92-8d38-450d-a62e-fb8fb9e52dd8") },
                    { new Guid("ae3eaf74-df57-4822-a789-75309358d71f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("df3919ae-45c7-490c-8976-cfbd6455f666"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("b5941aa3-f96c-4e87-9464-7a62b879dca9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f0cf6c54-1d57-4da5-8aa4-335f30b514db"), new Guid("2581f4df-f52c-4f5b-b9f8-f6c79a7143a7") },
                    { new Guid("b744203f-1d8c-4491-8a71-5e150d0e2e9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b89ceeda-0126-4c14-bc7f-3b54980ffd65"), new Guid("d9111d9c-8619-4515-93cb-2419e5570aeb") },
                    { new Guid("b79314e4-fcb3-439a-9034-f9d495da472b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("06a2df68-c005-4e8b-b16a-ccf80fe248c4"), new Guid("7de08a5c-830b-4770-80bc-1353ea1ffc65") },
                    { new Guid("c0bce828-be80-478a-b63d-3912a5a297a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0d4e76d9-61c2-4db9-80af-a3c335b87359"), new Guid("7804ee11-6b34-4ab6-85f8-b29671b765de") },
                    { new Guid("c7796647-ef9e-4d9c-ac0f-6d893cd570b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("51570933-157d-478a-aa40-01dac8efaf70"), new Guid("1c3fc085-174d-4b62-b7b5-36a3bb20433d") },
                    { new Guid("c7f84eb6-25e6-42ca-a9cb-b389c20e6213"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f8339470-7b0b-459e-9d75-41e5c19d921b"), new Guid("f5b9bf8c-e1b4-4b08-b377-166f01d97c52") },
                    { new Guid("c92be5ef-ccec-4db7-acae-28566c76a169"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f0cf6c54-1d57-4da5-8aa4-335f30b514db"), new Guid("3f047e68-bd8c-4ca1-b124-4129c37d2304") },
                    { new Guid("cb445c32-6f02-4b72-9402-0554be3f9b07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("131e3609-26a7-403b-b187-c65a7be6c431"), new Guid("e718cb14-d8a6-4567-85a7-3915a2eacb75") },
                    { new Guid("ce3e5f8c-13b9-40c5-a1fa-d2e3da267e9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d6d4ae5f-13d3-42aa-8ac2-009dc22c1382"), new Guid("102473a7-1ab4-4112-8fff-f825be09e3e0") },
                    { new Guid("d16ecd3d-f7f8-4cc8-afaa-e8ac5a907cf4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f6f90024-2e40-48dc-8efe-b36b7b690430"), new Guid("37dbb8d5-5645-4dbf-ac1f-8d0c0fb04d93") },
                    { new Guid("d18783c5-a1e8-493a-903e-a5f99d773f21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87bdfba2-2050-4f71-bd32-e36406626c6a"), new Guid("44ec33ec-ece5-442e-aada-fc8b2b2c12d9") },
                    { new Guid("d7c373de-24ef-4709-bb68-a3511b54c337"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9703165c-3223-448c-9e4b-938df39af60f"), new Guid("f8ca2ced-03b9-4aa7-9ed6-de1359ae299d") },
                    { new Guid("dbef5c91-8783-481e-b7fe-c53cee4e593e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("44910451-c166-44e3-b210-22584eaaa601"), new Guid("6fdff1c2-247f-46e6-9aa7-3c6d9dc4c434") },
                    { new Guid("dc3d8ef7-0c70-4439-aadb-cbbce4107717"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("66fa4b6f-9935-44d9-ad4a-9c3cbeb1e3c0"), new Guid("fc218112-8b42-4598-a25c-227112647fca") },
                    { new Guid("dd1f35ea-29dc-4cbd-88f8-cf9b6b82c40a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4a4435e7-7153-4052-b2d4-0116123966e5"), new Guid("5d6b5a74-97ba-4370-95c9-c3b609a2d0f2") },
                    { new Guid("dfe26bf4-c437-4e09-8ef5-41d57a396481"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1be12980-cb88-4792-a9aa-3603ca66cecb"), new Guid("e725eabb-c50c-4a5d-a80f-61b3ecd807ca") },
                    { new Guid("e7a9f560-4ba3-46f4-b87b-13cefd9383e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5a89fac9-f296-45f5-b56f-e8cc901cf0ad"), new Guid("62026556-0ea4-4e5a-aabd-833b5e7f5b10") },
                    { new Guid("ed1db222-e4fe-4927-a74c-3646a47e4035"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b7ae3594-b59c-4fbf-bfe3-0fb40f339343"), new Guid("2d6c0ccf-56fe-4d76-ac08-511ca8357cc8") },
                    { new Guid("ef1d2818-eeb6-4d3d-8e39-8fb16a2ed67b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("221ea982-b844-467a-b5d3-7feca3eaa2a4"), new Guid("4b9baedf-008d-41e7-9781-815a81805e9e") },
                    { new Guid("f21aadcd-0e73-4350-b415-46c40c259c62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e27d106f-16e7-4f71-9de6-22f4cb0397a3"), new Guid("beda0b1b-3045-449b-853c-c193b01c1ce5") },
                    { new Guid("f6b08229-3ba2-4545-a2f8-7d3e0d10e452"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("14f60579-87b2-44c9-a0d8-acae9d89f86c"), new Guid("aeea9959-1093-49a9-b32e-339299cdff9f") },
                    { new Guid("f8837e6a-b627-4e96-89d0-c528678e2060"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("41368ffa-7dc3-4756-9b02-36de8a0dae63"), new Guid("d44fbfff-f48f-4223-ac7e-5154c212939a") },
                    { new Guid("f9b79781-3d23-495d-a331-d075e3f5245f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dc648136-7bd6-47f3-9f87-09a0043d21cd"), new Guid("02b0feff-2009-41d5-9d4f-97d8c93c2472") },
                    { new Guid("fb6a4ed7-ed0e-4fb2-9fc2-0f170b8a6ec7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0d4e76d9-61c2-4db9-80af-a3c335b87359"), new Guid("ed9c87f1-f486-48c3-b505-d24e65fbcc01") },
                    { new Guid("fe162063-2a8b-49d0-beac-df3a5299b0c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9805b03b-aaec-45b4-8e07-9651a68055b2"), new Guid("8f7f1881-89b9-472e-837f-2cdc3dc73ee0") },
                    { new Guid("ff6eb16d-8e06-4051-80f7-b4d6926133dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f2ad6ab0-1b52-437a-8ac9-ef4f5df108ef"), new Guid("52c4edf4-c065-4619-8dee-4d6a563d0086") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Login",
                table: "AspNetUsers",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserId",
                table: "Emails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_RecipientId",
                table: "Parcels",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_SenderId",
                table: "Parcels",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCards_UserId",
                table: "PaymentCards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserId",
                table: "PhoneNumbers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PromoCodes_Code",
                table: "PromoCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserParcelMachines_ParcelMachineId",
                table: "UserParcelMachines",
                column: "ParcelMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserParcelMachines_UserId",
                table: "UserParcelMachines",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserParcels_ParcelId",
                table: "UserParcels",
                column: "ParcelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserParcels_UserId",
                table: "UserParcels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostBranches_PostBranchId",
                table: "UserPostBranches",
                column: "PostBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostBranches_UserId",
                table: "UserPostBranches",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_PromoCodeId",
                table: "UserPromoCodes",
                column: "PromoCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_UserId",
                table: "UserPromoCodes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "PaymentCards");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "UserParcelMachines");

            migrationBuilder.DropTable(
                name: "UserParcels");

            migrationBuilder.DropTable(
                name: "UserPostBranches");

            migrationBuilder.DropTable(
                name: "UserPromoCodes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ParcelMachines");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "PostBranches");

            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
