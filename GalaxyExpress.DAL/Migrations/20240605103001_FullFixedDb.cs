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
                    ActivatedAccount = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "None"),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "NONE"),
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
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), "c33663a5-27bb-466d-999b-9b45695060c7", "Manager", "MANAGER" },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), "4c996118-868b-44ba-adc8-ed925ebd6c10", "User", "USER" },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), "26edc239-5a42-4146-a197-9bc44638d8e8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30"), 0, new DateTime(1966, 7, 2, 14, 30, 42, 101, DateTimeKind.Local).AddTicks(9670), 591.5291011508140000m, "3a6733a8-55a3-45a7-bc52-0955abaa5626", "April", "April", null, "Kihn", false, null, "April_Kihn77", "AQAAAAEAACcQAAAAEF3SuA1M8glfLhFx3JPzkEC9Hvig+2YkdvIi8oKbAH/h91k6OG5TplPsgIPYMvUcNg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a"), 0, new DateTime(1935, 1, 6, 23, 26, 46, 563, DateTimeKind.Local).AddTicks(9701), 340.44682151850000m, "2109d3f4-ced1-4bbd-a7ee-b46d6eb2064f", null, "Grant", null, "Fahey", false, null, "Grant94", "AQAAAAEAACcQAAAAEO1HEjJ6KSxOtDCTB9aryTvFCLaDXIGrxiX5Ve45e435iH5ro5UwhtVvrvN/ScLw+A==", null, "NotSelected", false },
                    { new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2"), 0, null, 964.9909364865920000m, "b6c93aed-79f0-48e8-9a86-5c82abb9c7a0", null, "Regina", null, "Collins", false, null, "Regina_Collins", "AQAAAAEAACcQAAAAEH4ghrRmnfy+yn0kMtVKV8UsoRkCGgKzFN02/KJzdXCTNOhU4GSmmwt9eQYE84z8lA==", null, "NotSelected", false },
                    { new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024"), 0, new DateTime(1937, 7, 7, 12, 44, 24, 657, DateTimeKind.Local).AddTicks(454), 495.7417406838080000m, "7331565a-393b-4687-8584-2dfb9bffd6c7", "Francis", "Francis", null, "Wintheiser", false, null, "Francis68", "AQAAAAEAACcQAAAAEB80I59gbpZQJk3sVC0nBmBX8kHaoojUqP+Thr2nzDEPtNDH3lZ99SAFSbyAH9QmpQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("08094f90-68b7-4576-a740-581a4878e4ab"), 0, new DateTime(1977, 4, 25, 19, 58, 23, 278, DateTimeKind.Local).AddTicks(5063), 470.7014161998450000m, "9ee7485d-2579-4604-af1c-d2fc52078de9", "Virginia", "Virginia", null, "Kunze", false, null, "Virginia_Kunze", "AQAAAAEAACcQAAAAECHUwB2L68WgUXO8cymUtTCfgzFKHrIivPNPWiNbtKmtXXtW+qU74MgxPb3BswElsg==", null, false },
                    { new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c"), 0, new DateTime(2008, 9, 10, 2, 7, 49, 1, DateTimeKind.Local).AddTicks(976), 205.0490713733920000m, "fd9fec94-2134-4883-aa9a-3d20f36eab80", "Claude", "Claude", null, "Bartoletti", false, null, "Claude_Bartoletti", "AQAAAAEAACcQAAAAEJdmJk0GBAgsXP7QtiH6biaVeSwUxSTxQbPx0g64x5nlBpKOIK7KY6C2LgwqBan4PA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219"), 0, new DateTime(1964, 8, 12, 1, 23, 11, 457, DateTimeKind.Local).AddTicks(519), 989.0311898092340000m, "b077901c-24b7-4ec6-bf26-0f92736fbe20", null, "Charles", null, "Fahey", false, null, "Charles.Fahey", "AQAAAAEAACcQAAAAEOoPG075l8fLh9Ev9NxkM4QhX01RUPkXEaniRjsiNuVi15YIczKkxf4RkzEbPulUVw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1"), 0, true, null, 247.8506132085430000m, "218c90bd-c93a-4962-8ec2-dad9c5ac1960", "Henrietta", "Henrietta", null, "Bednar", false, null, "Henrietta_Bednar74", "AQAAAAEAACcQAAAAECSKFUsTX3kj6WTVYk8ZPa77DIB996jB15Wf/OcoMpZwiUS6ZbcrBmmAJC3ATN57hA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4"), 0, null, 508.7637640611630000m, "f994b0e5-2bb2-49ac-afa1-86ce55cfebc5", "Heather", "Heather", null, "Kutch", false, null, "Heather38", "AQAAAAEAACcQAAAAEM+i8T4bo246G76Gz8m1LcgtshsZAfZeH4NoSSUtp35zZqMi/7yVasRUmFju9NDctg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b98923c-0481-432f-9b60-33427e4d8223"), 0, true, new DateTime(2002, 2, 28, 10, 54, 13, 464, DateTimeKind.Local).AddTicks(9933), 833.2250385915970000m, "8f710066-1313-46f5-84a2-9dc6bc9edc84", "Nathan", "Nathan", null, "Bednar", false, null, "Nathan_Bednar90", "AQAAAAEAACcQAAAAEFscxucKeyTKrJas7nSuq6h4I7jHzZuB+v8i4hxAIpnSpsfc4K2xsRJej/VNw+d2qA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372"), 0, new DateTime(1991, 10, 17, 13, 0, 1, 337, DateTimeKind.Local).AddTicks(5479), 732.1034015480680000m, "21ead05f-48ce-4aee-acfd-79211704a943", null, "Ian", null, "Emard", false, null, "Ian_Emard", "AQAAAAEAACcQAAAAEJZswOQW2BanhDmsJTuhAbD8aEjL/JoJjY/Cyx+rnRmC+xKlcY+RUZw3hBOEBsy3bg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14"), 0, true, new DateTime(2003, 8, 6, 8, 47, 42, 168, DateTimeKind.Local).AddTicks(352), 89.05376207428270000m, "0553fde3-f674-4c2e-8c34-6558aa7bdaab", "Tiffany", "Tiffany", null, "Skiles", false, null, "Tiffany2", "AQAAAAEAACcQAAAAEKR2WO+1upeWRI2UbVg9uYW3VvvS4ZcpJuHidGf0LCtevxjScAZSSd3DuL76Jx6QTw==", null, "NotSelected", false },
                    { new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9"), 0, true, new DateTime(1980, 7, 18, 10, 9, 5, 265, DateTimeKind.Local).AddTicks(3275), 100.2612346853740000m, "009b1c22-5562-4c19-b9e3-88442f201275", "Kate", "Kate", null, "Smitham", false, null, "Kate.Smitham20", "AQAAAAEAACcQAAAAEG6j2plipM9rXweYs9vUqgQJLcaqj4HVYuIpQJi0sp5TqgNnCzPvgCAx5Q3193sWEA==", null, "NotSelected", false },
                    { new Guid("0ef47157-46e9-440e-9f72-08b2772beb75"), 0, true, new DateTime(1964, 11, 23, 7, 10, 37, 464, DateTimeKind.Local).AddTicks(6825), 398.7391792382840000m, "8f994706-8aaa-4ba5-ad04-ebd1cc6fa2e8", "Simon", "Simon", null, "White", false, null, "Simon.White", "AQAAAAEAACcQAAAAELgfgOcMXArRyuiHfa94lLVouyZU9XgO6QmubOxCebGJI74LHcSPXPAkcGKqpyPEpQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04"), 0, new DateTime(1987, 3, 19, 12, 1, 42, 506, DateTimeKind.Local).AddTicks(8766), 686.7198090548110000m, "ab9b54a7-3328-4128-ac2c-f2c434a022b3", null, "Mack", null, "Carroll", false, null, "Mack.Carroll43", "AQAAAAEAACcQAAAAEOhIVfPhLTB8uqsrCHMQFkFbWeGUWfRNQlacuboN3htrEG68e6iPpuVW89peeshzyw==", null, "Female", false },
                    { new Guid("0f9851be-b682-479e-aec8-51795a73a90e"), 0, new DateTime(2003, 7, 15, 23, 50, 34, 899, DateTimeKind.Local).AddTicks(2277), 689.067648096160000m, "2774feec-59fd-4290-9bb3-d3cb78c7ad7f", null, "Donald", null, "Predovic", false, null, "Donald.Predovic", "AQAAAAEAACcQAAAAEIPj1cAXYl6oBX48Uv0D3xulirziX3SUlNxT2Yltvp0WYdL3zhDbylxJUF9Ozds+1A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f"), 0, null, 699.4625765679740000m, "37318ab1-3f68-4913-96e3-a88fed5f242a", "Brett", "Brett", null, "Mayert", false, null, "Brett.Mayert", "AQAAAAEAACcQAAAAEFucpn1+dUC6NUzji7ryYB46R6zNzpgx14jFNyeSNsn90L9y3w5MaBkZKJKlhGkx6g==", null, false },
                    { new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf"), 0, null, 333.0121706890880000m, "3b819ef3-1df4-4d19-b1ea-50b4f3ca0d13", "Rosemarie", "Rosemarie", null, "Kozey", false, null, "Rosemarie.Kozey", "AQAAAAEAACcQAAAAEJQlXc9nzXVQLtgAIH8VNq82haqjy1FbE33nJd28cgrpyIoz+F4m+Z2rQXmxQcO9cQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5"), 0, true, null, 203.087761817570000m, "f93502b3-9cbf-4fcb-8ebf-50a3c026f034", "Andy", "Andy", null, "McLaughlin", false, null, "Andy.McLaughlin56", "AQAAAAEAACcQAAAAENsBCiT3j89+z+ex3rmUZj81uDOQr3jJhgyLfhapfVI67+xH0SGi7WT48KDKaYGmWw==", null, "Female", false },
                    { new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446"), 0, true, new DateTime(1959, 3, 25, 5, 5, 52, 795, DateTimeKind.Local).AddTicks(1108), 4.172992200435770000m, "bf35cc7f-2a29-4bd0-9526-5ae8a726e742", "Ora", "Ora", null, "Lueilwitz", false, null, "Ora_Lueilwitz", "AQAAAAEAACcQAAAAENSmNMNJqkuVuyK0PFN3IxC3uNLtVtIBbLzueqwws+A30ckTevP4V3+H/03ghcUBtw==", null, "NotSelected", false },
                    { new Guid("1154048c-cc8b-409f-a802-5dbe51d20548"), 0, true, null, 723.9962507477040000m, "9037f693-ba79-4e02-9e4e-f3f0a4418ba5", null, "Alma", null, "Howell", false, null, "Alma_Howell74", "AQAAAAEAACcQAAAAEOLJwPK/Gi2yZnKsxreI1nqQkA8BeVqOwDKUXVxpe/UxSYOVPFrRS0gyk/On4P3ddQ==", null, "Female", false },
                    { new Guid("1253df08-c182-4a6b-bbe3-05f888b56553"), 0, true, new DateTime(1936, 8, 17, 23, 37, 22, 511, DateTimeKind.Local).AddTicks(7666), 975.7094744833960000m, "80cb1e3b-5bb4-42a2-88f0-5b962b36dc61", null, "Karla", null, "Wehner", false, null, "Karla_Wehner34", "AQAAAAEAACcQAAAAEElIEeP1xtvMFY65FMdazogqsJNByj612G9VgzVo19SubPvKXHVq77Zl/g5994p0Pw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45"), 0, new DateTime(2008, 10, 5, 16, 41, 46, 401, DateTimeKind.Local).AddTicks(3482), 602.5205038287820000m, "0bc064db-18a3-4f34-8941-f24c1a58ca86", "Dwayne", "Dwayne", null, "Bashirian", false, null, "Dwayne_Bashirian", "AQAAAAEAACcQAAAAEBXGZjRAECWpPcsynlLDYzPK5PjJJPAWLtshIxAxBTPp+Ygj8UWCh8/kKKlfS5ZACQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), 0, new DateTime(1984, 1, 31, 19, 45, 31, 571, DateTimeKind.Local).AddTicks(8000), 77.10414438705690000m, "ba6fc13c-656a-45ed-b1b2-ccae3c84e173", null, "Ira", null, "Dibbert", false, null, "Ira_Dibbert10", "AQAAAAEAACcQAAAAECLD1gNZxaxOjPnagWeqgt/MPgH4cMwSl7sDi21jgt6n71M5pyQtHBzXlipZsD3PaA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee"), 0, null, 278.741366554120000m, "d2aa53c0-82d2-4da9-8b68-c2ebea2274b5", null, "Gerardo", null, "Hickle", false, null, "Gerardo.Hickle76", "AQAAAAEAACcQAAAAEDX0qPqMNUj2fSS5dw/qOIBU3+rXUNjJ0hUp3T6fiDkNCqgeOhMP1/thf2r2sQux5g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("19034493-ddce-4219-8d74-fbdd26d02300"), 0, true, new DateTime(1951, 5, 30, 23, 8, 42, 959, DateTimeKind.Local).AddTicks(950), 645.37263657560000m, "560253f1-ed80-49f1-897a-e888db2df0ff", "Meredith", "Meredith", null, "Grimes", false, null, "Meredith_Grimes", "AQAAAAEAACcQAAAAEAJQtpfWFhIvWC4gUbeciczc9WHc5kHLVXxTnMfY5KbfhX/SfFHgLSEuS8X5wekV6A==", null, "Female", false },
                    { new Guid("19341891-e9b6-407e-aea5-b35513589e26"), 0, true, new DateTime(1980, 2, 10, 2, 40, 56, 297, DateTimeKind.Local).AddTicks(4688), 218.4627048556820000m, "7f288df1-6259-4b79-98dc-538ef4198797", "Bernadette", "Bernadette", null, "Wyman", false, null, "Bernadette.Wyman", "AQAAAAEAACcQAAAAEJe4PGqhrI6OQTl+se3EYdtplEavBG2T9Z0Ui/aZeZqJdO6Zt7qfxsOhguitLfPr0g==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b"), 0, new DateTime(1957, 11, 2, 23, 12, 35, 358, DateTimeKind.Local).AddTicks(7545), 20.62442766707070000m, "ed66543e-17a9-4e00-b7a4-f92a17b01c86", null, "Shawna", null, "Adams", false, null, "Shawna53", "AQAAAAEAACcQAAAAEHB4Vx7mWbHsekwW53HtizKb/o8SzXoCnwx70BijamWeFmc1/OdsfQJqJfPZbE9z4Q==", null, false },
                    { new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799"), 0, new DateTime(1979, 5, 10, 2, 20, 37, 442, DateTimeKind.Local).AddTicks(891), 454.4506320060620000m, "74e849a9-81f5-4dda-ab92-d7cdf88e0439", "Teresa", "Teresa", null, "Hammes", false, null, "Teresa.Hammes32", "AQAAAAEAACcQAAAAEJi8GjljrWTH8g+0xUjZFGR7gRdyvMCNAM+opbrCJzCWKW/SrEB5jrV9o4TjO4XIpg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217"), 0, new DateTime(1958, 4, 4, 23, 7, 3, 499, DateTimeKind.Local).AddTicks(4007), 718.7881850351030000m, "f421ab72-0d7a-431c-8ce5-eb43cd4b5b17", "Brenda", "Brenda", null, "Kerluke", false, null, "Brenda.Kerluke95", "AQAAAAEAACcQAAAAEHexKBk/H86H+VVJI45/y1meuhav6XaQmT7kJBrsfIyEjb3iu6qqj6FZd79M+D03bQ==", null, "Female", false },
                    { new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098"), 0, null, 689.834839236920000m, "90a2794e-d4df-404c-aa26-31271ae73309", "Donald", "Donald", null, "Lemke", false, null, "Donald96", "AQAAAAEAACcQAAAAEKUMo6/hgZPVpMI4OqZO1vl82JNPhB2cihpmQYn/XEd26WNP4vad8v5i1ODSpgMzVg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e"), 0, true, new DateTime(1971, 10, 26, 22, 18, 24, 193, DateTimeKind.Local).AddTicks(5046), 975.78036408930000m, "7f79878b-6e55-4e54-aa81-fa492e58f1ff", null, "Maurice", null, "Botsford", false, null, "Maurice_Botsford17", "AQAAAAEAACcQAAAAEAFvqHAlM1cAo0OkFtNygLFm5eoAc+igXU6ASoW5bqZIBM39PwT73ONQ31+PZxCnew==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b"), 0, true, null, 493.1895965360030000m, "0eab2085-948f-4c08-9b87-9f888c14d992", "Chad", "Chad", null, "Spinka", false, null, "Chad_Spinka", "AQAAAAEAACcQAAAAEOfMJVCiZ1+UrivaMRK7uCJMiPyH34l8ICUPfUgCBTQ4zrutCA1x5iQO9qN7of79kA==", null, "Female", false },
                    { new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc"), 0, true, new DateTime(1991, 5, 13, 3, 5, 13, 894, DateTimeKind.Local).AddTicks(3910), 837.1032586987730000m, "e40c3579-9cc1-486c-a565-787ca2d0b360", null, "Elbert", null, "Jaskolski", false, null, "Elbert_Jaskolski", "AQAAAAEAACcQAAAAEA24ZzJQ2DJYsc+rvfRpbECcIT2t0BJ/rctrZEqgHGWLXX2CLVgJ/fi45S8WHLuyqw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("220dd6a2-d37f-40ac-be91-48215271da4c"), 0, new DateTime(1987, 6, 18, 13, 7, 38, 614, DateTimeKind.Local).AddTicks(575), 329.0787204769370000m, "cdb31e5a-a95c-4729-b8e4-82c32920d5e8", "Lisa", "Lisa", null, "Spinka", false, null, "Lisa.Spinka", "AQAAAAEAACcQAAAAEKNS7Fmz0DENVhrGhsZYuVcT46RjIZWrj4ItjbEvRnxr3FpW8wqjQqA2zGOXcxhK0A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16"), 0, true, new DateTime(1978, 2, 18, 10, 1, 7, 904, DateTimeKind.Local).AddTicks(3296), 115.8529223409240000m, "eb0c5056-1584-4238-ad92-f1bcd7fca242", "Meghan", "Meghan", null, "Graham", false, null, "Meghan53", "AQAAAAEAACcQAAAAECjglT1/jRZHtFYSqL6BII9bdXqDFWyt5GZPRA+J9m2MgrGP99mcCM2N3nAYZpHB0Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4"), 0, new DateTime(2006, 5, 11, 7, 3, 41, 919, DateTimeKind.Local).AddTicks(2508), 595.8217460220510000m, "ed644618-4d08-479f-84b1-8d0a6277232f", "John", "John", null, "Stamm", false, null, "John.Stamm", "AQAAAAEAACcQAAAAEKbiWO3HiyJcTcdZzlke7s0xGcp3Nsj9qXaXRqlWZkVQCMTIGLeeWHhhQIv8taf0wQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da"), 0, true, new DateTime(1945, 12, 25, 20, 33, 2, 481, DateTimeKind.Local).AddTicks(8939), 415.7199241685710000m, "bf193f7d-c4e1-4c58-abf6-3d931522c83b", null, "Kayla", null, "Wintheiser", false, null, "Kayla1", "AQAAAAEAACcQAAAAEKprjBMMFpw0eABjQkGO3u3AiOXoBJBjfDrQZHf3Cprt4zR4DA8ziYgRrXobNeVSLg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498"), 0, null, 637.0560114954590000m, "8b7e829e-aa9f-4dfb-8685-2d38a1fcc6b3", null, "Delores", null, "Mills", false, null, "Delores.Mills60", "AQAAAAEAACcQAAAAEPjGAp6LneAXM7tGyub8e6g7vn7+9hpIQbN5GC803xW3ry3ZBp9AqizEfQlZFOZPlw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e"), 0, new DateTime(1927, 6, 15, 16, 24, 30, 510, DateTimeKind.Local).AddTicks(8765), 314.6214051992180000m, "f8052fec-f651-4ba7-b70c-f4dc1c61f338", "Delores", "Delores", null, "Reichel", false, null, "Delores.Reichel17", "AQAAAAEAACcQAAAAEPjAvp84OURFUsePkdHwCHaGxSpPFppDP/ybXm1wzRsiMOsi59yMhqgBDAFid0f6Ew==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8"), 0, new DateTime(2008, 1, 13, 9, 22, 3, 776, DateTimeKind.Local).AddTicks(6261), 945.9736748460140000m, "cb900861-ae5f-4f3a-8bb4-0e90c1381df8", null, "Blanche", null, "Heathcote", false, null, "Blanche.Heathcote24", "AQAAAAEAACcQAAAAEGqxQWbmsd3I9LKe8Kfgd3NoJN4VqR4HAcATDwXC9FyxRontZTjD7u8+a8q7oraqsg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8"), 0, true, new DateTime(1990, 9, 29, 23, 53, 21, 18, DateTimeKind.Local).AddTicks(3528), 911.2641626949060000m, "4cd56429-7166-4c66-9aed-103aa175230f", "Stella", "Stella", null, "Kulas", false, null, "Stella88", "AQAAAAEAACcQAAAAEMlBmNjMlv7M38PI/eZVVEkjgmGkplscfuFpaXGOLF1+vb4t13E9G3wHqHLW89AkPA==", null, "NotSelected", false },
                    { new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d"), 0, true, null, 91.37575392164360000m, "39f26e4b-9dcb-4af9-9c87-eb8cf20b1dfc", null, "Pearl", null, "Dach", false, null, "Pearl.Dach", "AQAAAAEAACcQAAAAEF0i0gRi43Bw5k/QDfLjeDsm5YlmYAe9F2T9tDxIdMoodxWGStkeDdiXcHXe2XAorQ==", null, "NotSelected", false },
                    { new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37"), 0, true, new DateTime(1988, 6, 15, 10, 32, 29, 28, DateTimeKind.Local).AddTicks(5761), 557.4358141795080000m, "17e2ec92-38c2-4328-ad2f-bb8ac3464c67", "Carmen", "Carmen", null, "Harris", false, null, "Carmen_Harris88", "AQAAAAEAACcQAAAAEMBiYAImUn7AM3mAFrigJo7D6kIF5WAEk8YXf7o7LFh82qHbkqfrkP35OPfKzGglBw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6"), 0, true, new DateTime(1926, 4, 13, 18, 35, 12, 934, DateTimeKind.Local).AddTicks(7953), 96.92703844378970000m, "6a9c3630-9ba6-42cc-ad46-48cee576e3b9", null, "Dana", null, "Bins", false, null, "Dana9", "AQAAAAEAACcQAAAAEDzKmqCFn/lbs1XDJuOwP5EI2Dl2iTpYwz2Sb9h4moNVlMTpNB3+WxN4yxBa2g5j6Q==", null, false },
                    { new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8"), 0, true, new DateTime(1962, 7, 27, 15, 4, 18, 269, DateTimeKind.Local).AddTicks(4696), 111.4482388247790000m, "c83d962d-3d82-4442-9847-9011141cc140", null, "Dora", null, "Morissette", false, null, "Dora.Morissette", "AQAAAAEAACcQAAAAEENshvgXZ9mKTGvq1AhMUNAQxtGDjvTKmZ8JUZfcCJeHTRjVCqv5V/GGJGNFQOsKyA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e"), 0, true, null, 541.503654768920000m, "f3dcfe78-eb2c-4782-bfb2-9be869f3061b", null, "Antoinette", null, "Rutherford", false, null, "Antoinette.Rutherford", "AQAAAAEAACcQAAAAENLiKOUx3XRJfRPMYYy/lIQLtgnbGZUqygSjZ9Zs0RXBbnV+Uw2k1kD8+qW6/drC3A==", null, "Female", false },
                    { new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767"), 0, true, new DateTime(1930, 5, 5, 1, 37, 42, 15, DateTimeKind.Local).AddTicks(3497), 80.92949043836830000m, "51046f9a-86ab-45e1-abaa-754bb251b3cc", "John", "John", null, "Konopelski", false, null, "John_Konopelski91", "AQAAAAEAACcQAAAAEI6Lobvfwhr24m4gWj2EM++uTaPiTj1/eHLFmkBEYfuhj5woDiXkAADsUg8/zxvs7g==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73"), 0, true, null, 463.170957938430000m, "52cb119a-2e66-4102-a00f-0722c14bcd9b", "Lorenzo", "Lorenzo", null, "Sawayn", false, null, "Lorenzo12", "AQAAAAEAACcQAAAAEHe80zP00IFQ+o0h+WFlXazKhi+aeWwYJog/7j/lnDcg0uHGasoUMMZAGDOlsC3y9g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("30b2066d-f465-42ae-93e3-4a38936052b2"), 0, new DateTime(2000, 10, 6, 11, 45, 38, 354, DateTimeKind.Local).AddTicks(5469), 945.3616960627890000m, "31ae9675-3fa3-497f-8e35-5a6810d413d1", null, "Geoffrey", null, "Howe", false, null, "Geoffrey40", "AQAAAAEAACcQAAAAEIK7NsiIAJLT3dkBCmIcU+pZddxUqYqe4h9rQhwQpHDWcf7elHJptAaC+jHGt5r+1A==", null, "NotSelected", false },
                    { new Guid("30e31307-3bbc-4483-bf55-601427ba031c"), 0, null, 37.2284571049240000m, "ce2e7d51-27f2-4ae7-bcb5-d0a5a3a16ae1", "Dora", "Dora", null, "Von", false, null, "Dora.Von42", "AQAAAAEAACcQAAAAEJl8nJePPUd09Mt8kgPNy7EGHXOhQX+U+ceAPN8/VtfBqS0NDjXSkwcPOw9h4d+XGA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065"), 0, true, new DateTime(2005, 7, 26, 21, 56, 16, 928, DateTimeKind.Local).AddTicks(8557), 573.0628029280730000m, "a1fb2f0a-d585-4a4f-b95f-7e7bafff72cf", null, "Sophia", null, "Grant", false, null, "Sophia60", "AQAAAAEAACcQAAAAEBKZCncUPHc0PYBA0OxtpbubejPyVw1zhZXDeG0idWWaVFJ4p7BQ7XJAf2JzYrEujw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf"), 0, true, new DateTime(1993, 1, 11, 18, 31, 30, 579, DateTimeKind.Local).AddTicks(8974), 613.5037055939730000m, "0cad1f16-7d80-4ffa-958a-528d328d0876", "Nina", "Nina", null, "Wisozk", false, null, "Nina_Wisozk", "AQAAAAEAACcQAAAAEDbTO+BsWcLZ3xN/muutvwgUqj89r+LHYJAhd7LtCWyBQsDekIBftOtllD0TM8R2eQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592"), 0, new DateTime(1976, 5, 28, 4, 53, 59, 756, DateTimeKind.Local).AddTicks(6151), 696.0733820378540000m, "1dfd857f-9089-42e5-85d7-bd47f2484ce2", null, "Rachel", null, "Breitenberg", false, null, "Rachel_Breitenberg67", "AQAAAAEAACcQAAAAEFM6V8TRoVFKr73oPVVeqKvSF7fowty+7Ut0fo/5k82ZhVYl4Xk8/nk6Z2IyqzDCyg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178"), 0, null, 725.2334263323850000m, "3b0ad0e8-cf3b-4679-8ddf-dab4d78c7105", null, "Jessie", null, "Reichel", false, null, "Jessie.Reichel45", "AQAAAAEAACcQAAAAEMZntdAQpVb1heKRle5K0wTFMEAj8JFviwYPHYLXylYsG4i/SMJF9U+NNAALeL840A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("35187412-3a05-415f-8523-ec24e84b1221"), 0, true, new DateTime(1967, 11, 27, 7, 7, 7, 14, DateTimeKind.Local).AddTicks(178), 741.8762923245280000m, "a56605f0-9835-46d1-968b-9bf94683e2be", "Bobby", "Bobby", null, "Gibson", false, null, "Bobby66", "AQAAAAEAACcQAAAAENVuO8jR82nq16KT1Z30c88S6vos3ZEZZG7WvjNNlAmnyCt384NnFQVV5oX28wJYow==", null, false },
                    { new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066"), 0, true, new DateTime(1966, 7, 8, 19, 49, 50, 932, DateTimeKind.Local).AddTicks(1229), 630.4106543673220000m, "3479494e-38b8-4bb4-abdd-11f03d211694", "Roman", "Roman", null, "Satterfield", false, null, "Roman.Satterfield52", "AQAAAAEAACcQAAAAEPVQYoSnQkl5DXJNxRZ4BTltfI1/7b6lWEXVzJ8HMUm69necgqeoef1oXs29TjQlmw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d"), 0, new DateTime(2008, 12, 28, 18, 8, 9, 168, DateTimeKind.Local).AddTicks(7185), 681.0049430387480000m, "46f20faf-c0a3-4795-a59e-c67922f621b9", null, "Dana", null, "Purdy", false, null, "Dana74", "AQAAAAEAACcQAAAAEA8VBuFaiZ//2Qofz0PMFyFa5lCK9vpl1zs0EOKyod+BDfUyrK5b5HWfRRP/V+jeSg==", null, "NotSelected", false },
                    { new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5"), 0, null, 383.3404334610760000m, "d471da16-8b95-462b-b3ae-bdf81baa69b7", null, "Edgar", null, "DuBuque", false, null, "Edgar28", "AQAAAAEAACcQAAAAEH5qQlyecWe4+bSQ5jBOCOZP9fBqK7q7lU4HlteuQu8x0cyLsQV/zoG3Km5okC55dw==", null, "NotSelected", false },
                    { new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1"), 0, new DateTime(1958, 9, 23, 22, 59, 24, 808, DateTimeKind.Local).AddTicks(4072), 730.4118079557190000m, "0d06668e-e38f-4512-a9e8-c9ff5892a7b9", null, "Myron", null, "Davis", false, null, "Myron37", "AQAAAAEAACcQAAAAECYqFytb6NltcPbA3ELAP9N4Ut+tL8j/I5k7A8e/YhcsFCp3WUuhppNNvgE0qk6qtA==", null, "Female", false },
                    { new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18"), 0, null, 763.5742039630380000m, "df6a9718-cacd-4947-9d08-f9dd83baef30", "Toby", "Toby", null, "Upton", false, null, "Toby_Upton", "AQAAAAEAACcQAAAAEGmzqr7Umy7TEo/i61EbuSoS9HoOMNhSvAInnZVhkoGwfR2Z2QlIkFX5xflwceTEQg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0"), 0, null, 969.2056999457560000m, "b122687e-f562-444d-b12b-5649e13a08ce", "Curtis", "Curtis", null, "Howell", false, null, "Curtis88", "AQAAAAEAACcQAAAAEAEO4bV5eUZzKx3duKgIia6xBt3u/Nj6GpQLnttWb+6UQWP6ONuli0f03HI/7Z4oOA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3e1827bb-2cfc-4263-be79-7b663816638e"), 0, true, new DateTime(1931, 8, 2, 5, 7, 10, 814, DateTimeKind.Local).AddTicks(8877), 518.2086050377870000m, "21d41776-a937-4afe-92f6-9e02283b800e", null, "Marshall", null, "Grimes", false, null, "Marshall57", "AQAAAAEAACcQAAAAEP6AdNuAtdLGt0bLG8Fa6F2t5uWzCVP71ZRhRO9FA7f4xWqPkzW5oidZzrB8UAtNoQ==", null, "Female", false },
                    { new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291"), 0, true, new DateTime(2001, 3, 24, 12, 17, 23, 780, DateTimeKind.Local).AddTicks(9822), 48.13067408198890000m, "c1e4e1a9-0505-40a1-a1ae-7dc02444747b", "Pat", "Pat", null, "Harvey", false, null, "Pat.Harvey21", "AQAAAAEAACcQAAAAENrfMS5vAvxs7g7A+AvwAAOHatnt8K1U2kzMBgtbM1bBk3hUY59+kYt+ty/rAO8HYQ==", null, "NotSelected", false },
                    { new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6"), 0, true, new DateTime(1956, 6, 22, 9, 37, 5, 261, DateTimeKind.Local).AddTicks(228), 74.91989857958510000m, "b5ce86e9-f3ca-4a96-b338-bbee1f7c4536", "Kristen", "Kristen", null, "Wunsch", false, null, "Kristen_Wunsch", "AQAAAAEAACcQAAAAEFMytCwlRmue6vNb7PSCgy+tx1/9pui6uIGDqmjRv7n1e0eUWVHjRI6bzYPANEaafw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2"), 0, null, 463.3244029621410000m, "ca558d38-5991-4b23-8a94-7d1b7f2912f4", "Hector", "Hector", null, "Kulas", false, null, "Hector_Kulas38", "AQAAAAEAACcQAAAAEGS2ddJqOp03p6zfwtvhbip5dCBuuC/t0vTmmqeu8746CQSfRiT0ScYPiQazNyrMfA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2"), 0, true, null, 107.5516727139040000m, "a34c06a9-4179-4c97-ba33-857c753e8076", "Marianne", "Marianne", null, "Sanford", false, null, "Marianne.Sanford", "AQAAAAEAACcQAAAAELNROnHfSP4iEsxU0H7EUVJrZWv+vDlJZgs2NhklFg5Ph8aricupAzpogbbiax6m8w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("41008513-ca62-4168-8bcd-a3f4384fd325"), 0, true, null, 223.5480166881380000m, "97a7b32c-d074-4c97-bbad-2043cbf0086f", "Elijah", "Elijah", null, "Hessel", false, null, "Elijah_Hessel24", "AQAAAAEAACcQAAAAEMh8OHfSVIJFjl9xSoqQ34sC0SgK/3bg7eKuKC8ax6YFQIv/8/tGrt0xv8oaknO0gQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a"), 0, null, 136.2114237791470000m, "5fbee3be-c9a8-4abf-a0b0-575de75f2239", null, "Alfonso", null, "Fadel", false, null, "Alfonso_Fadel69", "AQAAAAEAACcQAAAAEMS0aOvIl3QL+NNtgJFA1GTAnmg/jmpeXQ/rcBIUr7eJDEKqzcK+liiULy9TZDsqmA==", null, "Female", false },
                    { new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731"), 0, new DateTime(1966, 3, 17, 1, 50, 14, 4, DateTimeKind.Local).AddTicks(9755), 123.8159810817630000m, "06789f45-4b5e-4e83-89af-c29d60edff01", null, "Anthony", null, "Konopelski", false, null, "Anthony_Konopelski71", "AQAAAAEAACcQAAAAEF6Hftyaeuhqe5k/jX8nkbZBe0wjL+bfD/JuhcDh59BZNmQLwcuSSXJagXtIraucwA==", null, "Female", false },
                    { new Guid("42ee14ea-707b-4681-b620-98122f2d53e3"), 0, new DateTime(1973, 7, 22, 14, 7, 51, 699, DateTimeKind.Local).AddTicks(7321), 457.01617067690000m, "b578cb88-cb05-474d-9210-e9a26be861ab", null, "Carmen", null, "Barton", false, null, "Carmen_Barton99", "AQAAAAEAACcQAAAAEMkiM57LVv4nstWfTLVBprqwSVF1AUOWBqnSlxnOIZS4Obp+BQPIiAWpJNodUwQn6A==", null, "NotSelected", false },
                    { new Guid("43a79d17-6c7f-4919-8fc7-806f34234239"), 0, null, 362.2523224069610000m, "00999108-d40b-41ef-842b-1a5b039f1143", null, "Isabel", null, "Kuvalis", false, null, "Isabel.Kuvalis25", "AQAAAAEAACcQAAAAEK1rvQYUjz0yP4CHEeFNGrqE/kU9tflkLB7r9A1h7e4Outd/x3Y2Bz4lFlrfObxinQ==", null, "Female", false },
                    { new Guid("45649949-0283-499e-b496-44660ddab1e4"), 0, new DateTime(1979, 2, 28, 2, 35, 40, 865, DateTimeKind.Local).AddTicks(1241), 198.9632812118050000m, "2991064e-e664-4c8b-98f5-408d3e9b385a", null, "Veronica", null, "Abbott", false, null, "Veronica_Abbott15", "AQAAAAEAACcQAAAAEILm9kGguFjuf+3BNq9BwAKpM8c2ZvENFiJpoBRExppK7hmoLAz++sRuVMGfpfuInQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc"), 0, true, null, 218.7070924008270000m, "bf8fa669-8cd6-4d34-9daf-adb5b2f332a8", null, "Taylor", null, "Schiller", false, null, "Taylor57", "AQAAAAEAACcQAAAAEM59gEYzCp6DrzItEYZT0SkSlL+7qlBmrDH1igQBplHlJ/tp2qR2FU3T19S9z1qeKw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("46568224-f301-4805-9ce4-f87ec0533c46"), 0, true, null, 41.78961132994050000m, "fe4f3111-4f0f-4f06-92ef-5a8170cec242", "Bobbie", "Bobbie", null, "McCullough", false, null, "Bobbie54", "AQAAAAEAACcQAAAAENiFMhZy78hik5Vrgx2DYAXIGhQOMqc08312F74l+dkvzE0ipVXC7opWINsguY41HA==", null, "NotSelected", false },
                    { new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), 0, true, new DateTime(1994, 1, 9, 6, 53, 15, 57, DateTimeKind.Local).AddTicks(2570), 115.0483920662440000m, "62878a27-8047-4f98-a2f7-0f464957aca3", "Ron", "Ron", null, "Howell", false, null, "Ron_Howell82", "AQAAAAEAACcQAAAAEEOFNTWdhvJCAnxhystd43S153PgNXZbT6XJ7ROOW9tmtuDWzK/1sgKF3jYaO1a+CA==", null, "NotSelected", false },
                    { new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c"), 0, true, null, 943.6254680953380000m, "432e3e37-bff2-4220-9a1b-802a42090d1a", null, "Wade", null, "Hoppe", false, null, "Wade23", "AQAAAAEAACcQAAAAEAxuyhvjDaCYYp6HguJ7Zv+Hvb7ZwiAcW7+M4n6AcC0f+1ksNwR4eRmjVDzsjGeijg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1"), 0, true, null, 440.7030838000760000m, "321395a8-21b0-4dc2-b42c-d7d4a3aad085", null, "Dave", null, "Wisoky", false, null, "Dave_Wisoky", "AQAAAAEAACcQAAAAEPgF8Q6sZzu1/i1LYV9B3ljnnRyWczWEgD6I44NRutOddSNzPXctSHIVCEFHvopY0A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67"), 0, true, null, 476.8717972241480000m, "40e72a63-a018-42f0-bc9e-095aaedb94af", null, "Erika", null, "Bayer", false, null, "Erika10", "AQAAAAEAACcQAAAAEPvFj357bIFRxO6bAe77yhBCpoPlL53/KDxrBPlZPNzcW9D4mhBSp7ifqRiVlr0pHg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd"), 0, null, 107.3111476002710000m, "9b0f092f-9c13-401a-86f9-8eb6e43acb3f", null, "Jeff", null, "Hickle", false, null, "Jeff.Hickle", "AQAAAAEAACcQAAAAEFbhEgvN3FWFdzDbrQgjuXOwL43j1uwVhEs1Y838sBceLxwjPHpwOITINqw7YO9r9w==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754"), 0, true, null, 617.3031400785530000m, "16d75964-9955-46d6-8cb8-3ea2df85529f", "Beverly", "Beverly", null, "Kemmer", false, null, "Beverly.Kemmer", "AQAAAAEAACcQAAAAEDvh9lPTaINDg8Mafj6ky22NIgIbcSgDEdTNIrByUyhZJ+0nRN+OolpvNKobZALpvQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4d077cd3-efed-4e0f-a063-90099edb5770"), 0, null, 135.3862880020830000m, "575aabad-4b47-418f-9433-547934133639", "Claude", "Claude", null, "Huels", false, null, "Claude_Huels7", "AQAAAAEAACcQAAAAEPqDNSEsT3sXLlmjrKwLhm4CXabAunX0cC1mAmwsb6FRMXw/Wt0GkfMlaXkrSPqY2A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4e0204f0-eb29-4713-873b-136318951b1d"), 0, true, new DateTime(1932, 8, 20, 13, 19, 15, 617, DateTimeKind.Local).AddTicks(9454), 583.4916418749630000m, "f7a5f109-9dd9-498e-a763-c28d27812441", null, "Chad", null, "Leuschke", false, null, "Chad6", "AQAAAAEAACcQAAAAEJ5DFe0vDluSHAFcxTROu6uoHw5bv2SN2d5dNmtGnstTiNLh75xtnznZgVAb7J/H/Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b"), 0, null, 702.2992351964010000m, "31b776f5-9b41-4c3e-b10e-aae59da55bf3", "Jasmine", "Jasmine", null, "Kautzer", false, null, "Jasmine98", "AQAAAAEAACcQAAAAEC+gKXFRRmrzYee2WzFAWo4sEjubG68zd4EK+G07eRAZdEdjSAsZSAfGVI4unrw88w==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4ea29651-f292-4cbf-8413-d8821c394155"), 0, true, new DateTime(1991, 9, 8, 12, 11, 21, 324, DateTimeKind.Local).AddTicks(6518), 389.987301264980000m, "8adf8567-1a05-494e-9f48-041c7eafac34", null, "Annie", null, "O'Kon", false, null, "Annie19", "AQAAAAEAACcQAAAAEDoFbooPfOBtBlRsAeucRpPEt/TogvwHem2s7eXqa/X1x34KRU0YB6SutN/n8QBG8Q==", null, "NotSelected", false },
                    { new Guid("4f03daca-02fb-425a-a575-bef52173e4d3"), 0, true, new DateTime(1964, 11, 6, 7, 44, 46, 692, DateTimeKind.Local).AddTicks(4832), 859.0494679970000m, "c10ec579-d156-496c-b86b-edafa7f693dd", null, "Domingo", null, "Pacocha", false, null, "Domingo.Pacocha", "AQAAAAEAACcQAAAAEBiU+yNqDrBroqEn2dm2aw55mYCKUucBG46dykIjRuyxouKpv1CEv7sw+EGBg1UU0g==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4f80af1c-a1e2-4285-b825-e9802427655e"), 0, new DateTime(1958, 5, 6, 1, 24, 20, 740, DateTimeKind.Local).AddTicks(7231), 519.7163525252560000m, "d7bb1dda-163e-4ab1-aca2-63ead29d846a", null, "Jared", null, "Prosacco", false, null, "Jared.Prosacco68", "AQAAAAEAACcQAAAAEBaPCaqgCqh4LjGgJug/Xb6VimHyOgGz4Lw41lia+p9wd7BmC9hEXdIypRcjAJvqgw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4fde002a-ab64-405c-bb95-313bef89420b"), 0, new DateTime(1963, 1, 14, 22, 52, 5, 864, DateTimeKind.Local).AddTicks(998), 790.4723407857850000m, "21f3bdaf-26c6-4916-8524-14946295d982", null, "Katrina", null, "Batz", false, null, "Katrina.Batz41", "AQAAAAEAACcQAAAAEONOq9fiMdj0qXcYJqLpnXjvtJtE0c9m5QKj0V4fy7OpZgm4Ofc7kGQcOhryHoYI4A==", null, "Female", false },
                    { new Guid("52698753-1196-4fd7-83fd-4670d8d55456"), 0, new DateTime(1963, 9, 22, 18, 17, 14, 361, DateTimeKind.Local).AddTicks(6506), 307.6731711522240000m, "2205104e-a8e9-4258-9124-96b911bc2289", null, "Cary", null, "Moen", false, null, "Cary.Moen23", "AQAAAAEAACcQAAAAENQ+AYUq/q0Uw7tXJy8QsxjtGqxVvbo9mdREwwvxLZPbwk6FrPNW42Gzv+JEBD8YaQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("527f7c3d-02b4-465e-8153-3472af913951"), 0, true, new DateTime(1936, 2, 2, 13, 21, 19, 564, DateTimeKind.Local).AddTicks(5824), 227.2099856610180000m, "5c241757-df9a-4944-9896-94d127254f54", "Joseph", "Joseph", null, "Buckridge", false, null, "Joseph93", "AQAAAAEAACcQAAAAEMVXZNZcmIVGB4hIDQP/C0GWhIUAsXcIU0AbxZO876VJ/7FKtJOpeSf7AZ0SUsMp5g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("52f24d75-fa03-403f-8430-5ca835f68726"), 0, new DateTime(1950, 6, 6, 17, 41, 21, 821, DateTimeKind.Local).AddTicks(636), 672.8387428183330000m, "d120f2f4-a00f-49dc-acb3-5001aea3a26e", null, "Victor", null, "Hackett", false, null, "Victor59", "AQAAAAEAACcQAAAAEBjBVEUFYp5OOHEULY8CcVg3XTWX/LLrVWOWNCqTEFA6pjAal2dAWc0YRRZM1kqWnA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc"), 0, true, new DateTime(1967, 8, 10, 2, 42, 23, 597, DateTimeKind.Local).AddTicks(2016), 277.9932411780730000m, "7c76e9a2-8df2-4d40-aea9-ca3a339f6343", null, "Christopher", null, "Fritsch", false, null, "Christopher.Fritsch", "AQAAAAEAACcQAAAAEECj8f0RyKJE9+YWlEsjBch0HdM5pgpjmjJPQNYcAzYv+5hj67dB6DxUYpx9lmed3g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748"), 0, true, new DateTime(1970, 12, 16, 14, 4, 31, 130, DateTimeKind.Local).AddTicks(3818), 113.0624039462680000m, "34977589-f842-4746-b908-7df043d85ccc", "Yolanda", "Yolanda", null, "Funk", false, null, "Yolanda_Funk69", "AQAAAAEAACcQAAAAEFzpFk7Z3AGTG2/Kdk15VsLXPtwi0WIKYhlLCbIehObDrmLHbedfN0liomYCY5Nx3w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("53a7a51e-d382-4050-82a5-f33ab7641603"), 0, null, 529.926630814510000m, "9b89646a-7ded-464c-863f-87559c2bc5bd", "Bobbie", "Bobbie", null, "Leuschke", false, null, "Bobbie.Leuschke", "AQAAAAEAACcQAAAAEHRlJ8N0M2tLwqLg6itsGjix80I7fcqmOPOkwod3B5EpyPupVhBMAB539yUWanZe+g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("542cca7c-dbc2-4394-8615-7d906972ce59"), 0, true, null, 911.1286572145510000m, "05653d19-90c5-4e6d-9228-8cbfae61ca59", "Aubrey", "Aubrey", null, "Quigley", false, null, "Aubrey.Quigley58", "AQAAAAEAACcQAAAAEDaKPFBcbWmewVwEnY9nGQ94P7MrV8Whov0CB4DhV0B2DrEVJQ4UizX2aR8YaK0EVQ==", null, "Female", false },
                    { new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783"), 0, true, null, 479.1758472567450000m, "b38403dc-1793-4662-8f9f-34790f11d4b3", "Angel", "Angel", null, "Legros", false, null, "Angel.Legros56", "AQAAAAEAACcQAAAAEI6Mr0vOF98IRssSIPE34n43rINTaow3rY9r5325krngFhaj/Bz77Q++U/JdmpUv8w==", null, "NotSelected", false },
                    { new Guid("563f53c7-7654-4215-88fc-eff6cf413754"), 0, true, null, 499.0464198666910000m, "3123b080-68d6-404e-a5ee-be3239959850", "Alma", "Alma", null, "Rowe", false, null, "Alma_Rowe", "AQAAAAEAACcQAAAAEMQ9X6V0QFPqqv97MoIEo12v39d7rjsykTW8ETsQzBEr4hVA637iadDmt8I/H7G4Vw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321"), 0, new DateTime(1980, 9, 22, 23, 28, 19, 910, DateTimeKind.Local).AddTicks(9102), 220.7352901969890000m, "3fc0c01e-d173-48af-8f7b-10311ce525fa", "Marion", "Marion", null, "Schmeler", false, null, "Marion.Schmeler", "AQAAAAEAACcQAAAAEOjXYqvBIHAJrL3FLHIdV4KxDryhZByP/asWievjl3q92EzBp1AsWBZmCflLP9u5Ig==", null, "NotSelected", false },
                    { new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7"), 0, null, 456.846963615170000m, "f8696a74-199b-4270-aaa4-8a0b2222b371", null, "Jeff", null, "Nolan", false, null, "Jeff_Nolan", "AQAAAAEAACcQAAAAELRLaIn5Djb7MZF8rOkxdYi9DccXAbW0SsR7chYwWXQA58l7KEAVShkA1EG096nIww==", null, "NotSelected", false },
                    { new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8"), 0, null, 214.5375578901880000m, "d38ad2c0-b67e-4da7-8eb2-cfc0a9a31e48", "Arnold", "Arnold", null, "Bergstrom", false, null, "Arnold.Bergstrom", "AQAAAAEAACcQAAAAENwJvBip7k/N42oa1BgM9Y8hKXM966J/8c2xkxB3ssA6pU20XzD7NFdJuIu7Rr+n2g==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c"), 0, true, new DateTime(1983, 7, 8, 23, 2, 26, 150, DateTimeKind.Local).AddTicks(8233), 166.5273782807170000m, "9c61fa92-73aa-4698-a05e-7e9d9ae4ef6a", null, "Yvonne", null, "Ortiz", false, null, "Yvonne.Ortiz", "AQAAAAEAACcQAAAAEKKjR3YMxsZDc/kIDNmhFMiihTXMkJwGoyQpLVH/vHjXScRhQSRdKFzaAPsg9nXM/Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d"), 0, true, new DateTime(1931, 2, 16, 7, 8, 32, 718, DateTimeKind.Local).AddTicks(5949), 911.3480240568520000m, "c3a18599-1310-405b-ac3e-7913441affcc", null, "Renee", null, "Marks", false, null, "Renee94", "AQAAAAEAACcQAAAAEDbd/+Ky2D1Qfomm95exrnfhxVGJ9xk+ea6ERP76mtTyJ5x58FwX6eZ9ZscikW/XWg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40"), 0, new DateTime(2001, 6, 22, 15, 56, 57, 818, DateTimeKind.Local).AddTicks(5849), 94.21058144785390000m, "c6425fca-3fc4-4780-8a02-4496118326b0", null, "Andrew", null, "DuBuque", false, null, "Andrew83", "AQAAAAEAACcQAAAAEECuDFCfdm9r+TOBRQ3OG4kUMsCF6G/mfEpjJzWDB6NpyBhEzJ7Sq7YQnTMXS5Jd2g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379"), 0, true, null, 567.3126805154260000m, "4e53532b-8462-461f-8e10-faf9977d8593", null, "Irene", null, "Jacobs", false, null, "Irene_Jacobs8", "AQAAAAEAACcQAAAAEJEAnp/fBlIxVUVN70gbvt1dsGWo9NVW8XXvyFF8/yLc+cx3PTt/78dVbAJxNaQFQA==", null, "NotSelected", false },
                    { new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656"), 0, true, new DateTime(1938, 6, 2, 12, 28, 41, 757, DateTimeKind.Local).AddTicks(4883), 109.3776541590310000m, "b241d50f-7536-4ede-b5ff-ef7fd8262085", null, "Fredrick", null, "Jacobs", false, null, "Fredrick.Jacobs7", "AQAAAAEAACcQAAAAEJNH2jRRC0528eub5x/nZelhKJJG7uxwxiibQ6mhWcYJ1aOoG8QRgrgi/eXDoSDJvg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500"), 0, null, 910.8343460116950000m, "7f6b5bf6-fec5-4bee-b778-9a160ec3cc1f", "Sally", "Sally", null, "Powlowski", false, null, "Sally.Powlowski", "AQAAAAEAACcQAAAAEPTeQi6tnKd/ddSLHqcIf4ekw/1DwE/4lR4s4egEdr2f1QlKig3Qo+fS6J2un+pt0A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63"), 0, true, null, 482.3502949652840000m, "1f77ef87-68cf-4174-83e4-ddd4fd5d54dd", null, "Jon", null, "Jacobi", false, null, "Jon_Jacobi", "AQAAAAEAACcQAAAAEEzxoNhnsYxAsUaovzR8we5a0RKXgRfjXUpnTmFZcD1RWKwdNeFQIt5wBbmIRD1TZw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc"), 0, new DateTime(1950, 4, 30, 9, 3, 0, 777, DateTimeKind.Local).AddTicks(1358), 721.1932578021260000m, "6af964ca-9dbd-4a2e-8e9b-39792df7c280", null, "Donna", null, "Reichert", false, null, "Donna95", "AQAAAAEAACcQAAAAEAE1jY62EmtS3fD15j0I466dOkQws7e4H/iF2IWsGkVk1Gy1UNmtleCOqiRjcwe5Cw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5ffc49e2-50fb-41f2-8784-192077f86010"), 0, new DateTime(1955, 2, 19, 4, 45, 7, 156, DateTimeKind.Local).AddTicks(1513), 683.7300838782140000m, "522dbbd4-d6a1-4992-910d-c7d92e88a192", "Merle", "Merle", null, "Breitenberg", false, null, "Merle_Breitenberg", "AQAAAAEAACcQAAAAEFkZMB+MyHsLnrDw41VNNlnDbXKqcYldi7mboPl19BpUHYAnPz9EzqGOnyysK2gDug==", null, "NotSelected", false },
                    { new Guid("60bb9160-18e9-4302-9e15-44aa4126967e"), 0, new DateTime(1969, 1, 14, 15, 6, 30, 333, DateTimeKind.Local).AddTicks(6759), 752.7022834992780000m, "aca3050b-aaef-4ea4-a8ef-eb3826e0434b", null, "Alexis", null, "Considine", false, null, "Alexis67", "AQAAAAEAACcQAAAAEMEeMvBog/I9FAjfAVaaB2kEnYu+A2uZhqpLP9PEqN8nDAR166ZdzE1r63anRF+b7Q==", null, "Female", false },
                    { new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1"), 0, new DateTime(1978, 6, 8, 17, 37, 51, 199, DateTimeKind.Local).AddTicks(3983), 184.2123818432790000m, "9400a40f-c194-4398-b9d7-cc37ac65afb8", null, "Anne", null, "Bartoletti", false, null, "Anne.Bartoletti54", "AQAAAAEAACcQAAAAEDnlIzgEUHeYggj9M3bmQtD8m4SvK5KsnCq5v5X+wFmgRmW6bRZUwrArcR6evKv8uw==", null, "Female", false },
                    { new Guid("617100a1-d830-4170-9964-86b27fc31a31"), 0, null, 460.8063118601060000m, "6b99ed9b-b620-42b2-896f-5603623ff8f5", null, "Mark", null, "Balistreri", false, null, "Mark.Balistreri", "AQAAAAEAACcQAAAAEK2vpJJdazHhiqhPfpjG3AGBMte65Q/9b2f4/ExJtRnU2vzoqsJG4oEADNZY+PWZgQ==", null, "NotSelected", false },
                    { new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc"), 0, new DateTime(1976, 1, 13, 12, 26, 49, 163, DateTimeKind.Local).AddTicks(2902), 981.5805830177780000m, "8f4d862a-18d2-45dc-9252-f08130f64d69", "Marta", "Marta", null, "Okuneva", false, null, "Marta19", "AQAAAAEAACcQAAAAEHgZYRdvElLR+6Rt66x1yEAhOM6HBh8Vg4TmJVo51lsgyT2f18iSitkCkFcYCYFbFw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b"), 0, true, null, 672.8596686009990000m, "3816dd43-8f75-4c54-befd-23e58119de4c", "Ralph", "Ralph", null, "Bergstrom", false, null, "Ralph_Bergstrom27", "AQAAAAEAACcQAAAAEKX/qIdd2+1LVF2g+WxXYxQjLAO2p6MNAZf/8anLmNQGJ4gqb8ZPhY7PTX6kfTMLjg==", null, "Female", false },
                    { new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9"), 0, true, new DateTime(1966, 2, 21, 11, 48, 45, 696, DateTimeKind.Local).AddTicks(4823), 678.0324567918060000m, "6d05fd76-385c-4e5c-b6ff-3b858601bc16", null, "Russell", null, "Ritchie", false, null, "Russell49", "AQAAAAEAACcQAAAAEJ9WJ8hZ3z73AVo0rGR/IY1gES+HjQliEbbDgb4bqLm8D8kOKYRD+h+ec12WJQALVQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921"), 0, null, 748.7079596327820000m, "6d8e8ec4-08d2-40d9-a216-cb656e5caf74", "Sadie", "Sadie", null, "Stanton", false, null, "Sadie65", "AQAAAAEAACcQAAAAEPCmCkx6bn623APA9JaDsUlBMPjHJnu1v9colTLGnjWdZavaulEzo2h9XtCOivV+pw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be"), 0, true, new DateTime(1980, 4, 5, 9, 22, 16, 343, DateTimeKind.Local).AddTicks(4665), 343.0039205610320000m, "0416cbf1-90ca-4ee9-91ad-17526e762820", "Cindy", "Cindy", null, "Klein", false, null, "Cindy.Klein", "AQAAAAEAACcQAAAAECAL8w3XQBvos5yfCJm5MRAaxLbC7U3s22pL1PM70eHinsxP4Zf4Gwn126T0J9vOgQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729"), 0, new DateTime(1994, 12, 3, 17, 31, 26, 463, DateTimeKind.Local).AddTicks(9090), 426.7839703952690000m, "b6977edf-68dc-4842-a455-c70d62f2a94f", null, "Leigh", null, "Carter", false, null, "Leigh_Carter14", "AQAAAAEAACcQAAAAEL2uSq2jTW30EcEw9UwSWBVE1nVfp3sK0qw9Q9iNtdf1z7bsCxySgTvKdJiLYqYCOA==", null, false },
                    { new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af"), 0, new DateTime(1924, 7, 23, 22, 18, 21, 836, DateTimeKind.Local).AddTicks(3041), 594.5366322527170000m, "b5680d8e-ef7c-449f-88a2-c80dc53d85c8", "Omar", "Omar", null, "Hettinger", false, null, "Omar.Hettinger", "AQAAAAEAACcQAAAAEF9bvyQHed6EDYn8Xgoge/S3Hgc3A1k+VhcGxNwYM07LfDeRbBlXqzJr6s+/E8igEA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c"), 0, true, new DateTime(1991, 6, 28, 13, 54, 11, 926, DateTimeKind.Local).AddTicks(3388), 14.17427252696870000m, "b62bf8bb-b48c-4d95-9d30-7226bdd01ce2", null, "Steven", null, "Rath", false, null, "Steven_Rath", "AQAAAAEAACcQAAAAEEhlxX2i2KHsPV+dWUSaD86I+uipoIVDVQ6BfRNxFmfYA8vEHdprh/qjwXv6btXXoQ==", null, "NotSelected", false },
                    { new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942"), 0, true, new DateTime(1978, 1, 1, 20, 50, 22, 632, DateTimeKind.Local).AddTicks(2275), 345.8489957434580000m, "7605a643-f3b1-4d10-a452-2f1b8149ac64", null, "Vincent", null, "Hilll", false, null, "Vincent_Hilll1", "AQAAAAEAACcQAAAAEAQiBNoHNOeBUzOX3SUf3ZjB79h2Fn4E/7DS6DqsGBo6MYN2G+/DtnQ/F/lK8jqNIg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6b1f032f-060a-4040-879c-9d1305d38b12"), 0, null, 414.199489959510000m, "650079c0-251d-4408-b7d2-c9d29d204a0f", "Benny", "Benny", null, "Jenkins", false, null, "Benny.Jenkins", "AQAAAAEAACcQAAAAEE3ZJhe68vqhzESBo9fjSiJz4a77/KeULK3PoiGTv5bUIHLJkmIBAEAZRiV2Dtu7dQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6"), 0, new DateTime(1998, 7, 24, 6, 17, 19, 235, DateTimeKind.Local).AddTicks(2789), 470.9985960545310000m, "97da486b-40b2-4b50-bf1f-7130a8787c93", "Miranda", "Miranda", null, "Schumm", false, null, "Miranda.Schumm", "AQAAAAEAACcQAAAAEB6OWJyin4Rl0TXcgmmYFD/1f51SvWCEPwt7X8A8Qtmm4PUTClzuV88M2f7wKseKOA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6b524441-f464-4e08-8f72-3c7c650f6875"), 0, null, 472.9730345730960000m, "b6028780-d7df-4d5e-bafd-e35cc4f79520", "Joan", "Joan", null, "Harvey", false, null, "Joan_Harvey", "AQAAAAEAACcQAAAAEJiHupA2NQWHVA211TC5UlAy7YncUjCF3dMbA4l6gBfxaIVT0LO7lPhFn6aiJudHUg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6bf86772-9995-44ea-a063-ccc583990881"), 0, null, 929.141814183930000m, "091bff9f-012e-4172-9e80-9602e5321354", "Gladys", "Gladys", null, "Weimann", false, null, "Gladys64", "AQAAAAEAACcQAAAAEIDbto6qPXX9VK4U3fUu5CJOcMBmfSqeh+MgXChPurlb/THm2fRZrSRiPEkm1O2mkA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058"), 0, true, new DateTime(2007, 12, 2, 15, 50, 54, 773, DateTimeKind.Local).AddTicks(9396), 298.3695450347550000m, "60253be2-d802-4ac6-931f-556e16fab120", null, "Eloise", null, "Miller", false, null, "Eloise3", "AQAAAAEAACcQAAAAENbzbSz17/tOeedrbBp+fPz5ImUhyR8tycNWTTirLZ8DLX3vmh0lWJouZQc04WzaJg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae"), 0, true, new DateTime(1965, 7, 16, 18, 55, 39, 96, DateTimeKind.Local).AddTicks(8011), 162.9254692335320000m, "69557473-ae94-470b-9696-e6e81dd5f03f", "Mindy", "Mindy", null, "Feil", false, null, "Mindy.Feil59", "AQAAAAEAACcQAAAAEGzdT64nt6N+31tbOoEGw5zxoj6BLSZCsjV+j6xeE1NWD2X4nlvJK/DA2Qp9czQBig==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353"), 0, null, 541.3141138057990000m, "4b2ebbbc-f8c8-43a3-ab42-85cc6ce2dbbb", null, "Bruce", null, "Little", false, null, "Bruce.Little", "AQAAAAEAACcQAAAAEIv4KpJMbeWsvUKHm/Pu31VbiOxYvKapvULn6RnjrtcRoikkWyo+3g12DwUP7IFIJQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61"), 0, true, new DateTime(1993, 5, 18, 8, 58, 6, 46, DateTimeKind.Local).AddTicks(4679), 171.8134645959430000m, "7d3dd6b9-e5e6-41c2-8933-691b8eee9ac3", "Belinda", "Belinda", null, "Fahey", false, null, "Belinda.Fahey", "AQAAAAEAACcQAAAAEDWRbh+RWsz4mOhOr5ofexj9Qjs7etf0OZdjRdfysuOWGzqNRae/R4iXxHJh8L/jAg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("730094f2-c549-4e04-b5a9-761af8d5725f"), 0, null, 21.65305068417120000m, "b11e6aa1-3c16-4a19-bd47-1f737c589a5d", null, "Chris", null, "Kiehn", false, null, "Chris_Kiehn", "AQAAAAEAACcQAAAAEGWcLWLzAhgNcmdGtjXRMO2MDcnWUFrX0pXWE5qXkAnJicvvWlvjPCvQUnI7uO5X7w==", null, "Female", false },
                    { new Guid("748062f3-9c55-4b5c-9d17-429dac03b923"), 0, null, 848.629445847990000m, "90710e4f-3cfc-4870-b293-1b6fc8927386", null, "Elias", null, "Jenkins", false, null, "Elias_Jenkins", "AQAAAAEAACcQAAAAEMtxU6Z6THOZHZ/Djf9AEHiAm5xeqYfqq6L1jB1qk71jpzP6smsur8YqiXFVHHNKmQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c"), 0, true, new DateTime(1986, 3, 1, 19, 19, 27, 183, DateTimeKind.Local).AddTicks(5765), 437.4327634523090000m, "c43ca460-e26a-4630-a797-d7a193512ace", null, "Wanda", null, "Wilkinson", false, null, "Wanda_Wilkinson19", "AQAAAAEAACcQAAAAEJRlp4hYBRaydak4q59v67D4Gr3JNy0vSQO/yGTF1CDskukE4KzlXNfINhiogfk0Ag==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7573b136-e686-46e6-b0af-1186d8e37af1"), 0, new DateTime(1992, 9, 4, 20, 40, 6, 509, DateTimeKind.Local).AddTicks(8913), 51.27121423584380000m, "6dbcca12-f2bf-4367-b84f-f2f4e020d7a5", "Allen", "Allen", null, "Wisoky", false, null, "Allen.Wisoky", "AQAAAAEAACcQAAAAEIUBXhAZjDWtODPZCaBNUQ7QBkD9ZnT/YQ3yRVQY3AbU5L2yBcHLHmGMKPgb7VFdyQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("77f944f9-c758-4983-b702-656640bf5672"), 0, true, new DateTime(2009, 5, 16, 9, 2, 42, 156, DateTimeKind.Local).AddTicks(3796), 625.8162981056110000m, "4ebeb5e0-1354-44e5-b198-d24e4791d187", "Roman", "Roman", null, "Weimann", false, null, "Roman_Weimann51", "AQAAAAEAACcQAAAAEPv0xYehbXq3L5TRVpJAJ5wa9n6ebd+3ISsctX04E4sjCFPX7DJpSDq2WpWjDqUkTA==", null, "Female", false },
                    { new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4"), 0, true, new DateTime(1952, 7, 13, 15, 22, 37, 866, DateTimeKind.Local).AddTicks(2570), 506.9146355792660000m, "bfa52916-7428-41b4-9583-cdd081d18b62", null, "Kyle", null, "Ebert", false, null, "Kyle46", "AQAAAAEAACcQAAAAEFJ7+CXMD/2DuNc60nCbGBaShyCrcDCkfikfUc2UizStPHnZS11xYzZjoTKqZRI2/A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("78016c36-672a-4efd-980e-250a79e4d32e"), 0, null, 887.8069451309160000m, "083bd55f-65b7-4e41-8ba6-943487bda3e0", null, "Rochelle", null, "Zulauf", false, null, "Rochelle_Zulauf", "AQAAAAEAACcQAAAAEFVD0j6xAfjWqA6tzgyKe7/V4mUxLY4f5ooSCOWCH/GEmFna5yEPyUvIQxJidyzRvg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3"), 0, true, new DateTime(1992, 3, 24, 19, 9, 33, 956, DateTimeKind.Local).AddTicks(3169), 671.7064511247270000m, "34ca20ac-03ba-4f22-8057-704159b3e367", null, "Evan", null, "Beahan", false, null, "Evan_Beahan", "AQAAAAEAACcQAAAAEMWR1pZmkUZ7iesg7q/Tv4FDetARPmINKPD3KXZNg/dmYRFUCl85A47RUB9tvJq1hw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138"), 0, new DateTime(1994, 2, 21, 4, 2, 23, 285, DateTimeKind.Local).AddTicks(4301), 580.2324495246370000m, "06ca5f66-a57b-42e4-a126-a51c8ba30e6a", null, "Otis", null, "Bartoletti", false, null, "Otis_Bartoletti", "AQAAAAEAACcQAAAAEJkQL+9QV95+Jg+PA8sM5lot6btpSIj8JxRzxfdLDfp+PPQ5FbY6GEhseSqCP9xoiA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a"), 0, true, new DateTime(1925, 12, 20, 17, 30, 50, 96, DateTimeKind.Local).AddTicks(2990), 668.0723652930030000m, "775cb50f-7e3e-4fd6-a32d-e12260d38c58", "Brett", "Brett", null, "Green", false, null, "Brett56", "AQAAAAEAACcQAAAAEGEd6poZuXCbbYX39tGBGLnLC6cePTPffmXREaDYW7UgEMAZ6ymiafGHeommmSXMew==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9"), 0, true, new DateTime(1942, 5, 25, 22, 50, 29, 707, DateTimeKind.Local).AddTicks(2480), 766.6743123919840000m, "6ad7c30d-c625-4642-a9db-55afcc84799d", "Darla", "Darla", null, "Pfannerstill", false, null, "Darla.Pfannerstill", "AQAAAAEAACcQAAAAEHj4BK8eOczY5xtgjKHt/yvQTnN3XfB5fG95i3GatL5Rc9K+yxpAIWnV4z5ei8tYYw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024"), 0, new DateTime(1992, 2, 2, 7, 9, 30, 422, DateTimeKind.Local).AddTicks(5969), 962.6537936751990000m, "e013d5c9-dc7c-4859-bd74-578b0dbfa977", "Andy", "Andy", null, "Kreiger", false, null, "Andy_Kreiger19", "AQAAAAEAACcQAAAAEJ7lwTBBI1ePoPBErfmNYjnxzhJtVGmlm7Wd8AbnkAdAZHHz0U7ZWWHnBwM3WKEpcA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87"), 0, true, new DateTime(1952, 2, 4, 1, 21, 25, 691, DateTimeKind.Local).AddTicks(614), 529.4902137801980000m, "cbc092db-93b3-49f3-8c60-deff3a4b3dcb", "Lorenzo", "Lorenzo", null, "Hand", false, null, "Lorenzo6", "AQAAAAEAACcQAAAAELO0JxcQ5G0b1JxqlTncKGuNcp0vHh5c8IaSzt8+uIgX8l7IQMnoSoQcEE39msQeEw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da"), 0, new DateTime(1948, 5, 12, 17, 0, 58, 26, DateTimeKind.Local).AddTicks(5229), 756.1612388360140000m, "14cf1ac6-a1f8-465f-848d-2039ce82861a", null, "Monique", null, "Shanahan", false, null, "Monique_Shanahan33", "AQAAAAEAACcQAAAAEKTamzxQXyGGS0ie6fbDOmLjzMVGvNnWpcuyNp6kam6Gt/5rKiZqRAN7qM00/T1Clw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6"), 0, true, new DateTime(1976, 3, 22, 12, 38, 58, 339, DateTimeKind.Local).AddTicks(2727), 239.9991842979950000m, "2e014911-1d80-4d3b-b823-fca5f23c2a37", "Bernard", "Bernard", null, "Feest", false, null, "Bernard_Feest", "AQAAAAEAACcQAAAAEMgshpaQqOoB0VN/e7NQVVsKhUV4Ki1nVLOj4SHRgkeiYOSq9F3BgzT0wSkEEVVRrA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8"), 0, null, 525.2505945492170000m, "78a5cf0e-d109-4dcb-84f0-b0919ed83e3b", null, "Yvonne", null, "Harber", false, null, "Yvonne54", "AQAAAAEAACcQAAAAECgTmf5iKfcJoqab45bBLOsZcOmqvR+aj1v7VOh+HK4Bz2c39VigQnao86UhJjxvwA==", null, "Female", false },
                    { new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0"), 0, null, 499.9012591620430000m, "3b88da2d-ed99-4270-b699-45bf13c80e87", "Mark", "Mark", null, "Berge", false, null, "Mark15", "AQAAAAEAACcQAAAAECttLGsnF/KrEwDV1rpzZg/NLwBPrgOBUUuKECm2eA1p3zdijhzmFG/W1DonYiPkXw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("80ed64a5-2f87-4262-aed3-901da3da1369"), 0, null, 628.7594750454470000m, "42b8327a-8a26-443e-b843-5005503d1f9d", "Brad", "Brad", null, "Sawayn", false, null, "Brad.Sawayn", "AQAAAAEAACcQAAAAEFCddaPO3u0e3btGwKiLdy2RGfzkS/R2m6Qdu0CAvhjxXrdTXW2mCcPgJLsALW+I1A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("816326af-094b-4b97-b10b-548a2296766b"), 0, new DateTime(2008, 5, 31, 18, 54, 22, 834, DateTimeKind.Local).AddTicks(3436), 25.99896036179720000m, "0ba49126-10a8-4338-b8b7-db0c6ba889ec", "Darryl", "Darryl", null, "Bernhard", false, null, "Darryl_Bernhard", "AQAAAAEAACcQAAAAEAPu3VwMWzZjI2LJy8ioaz3c/bVioomR6ymI836KbIcZVwC2sijZdv5Hjq4TFvexNg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("83059c11-6c07-4892-a0cb-ced177c551d8"), 0, true, null, 165.4550078715260000m, "2ad3f092-ef15-4add-bf77-fcecca949fd7", "Carol", "Carol", null, "Hauck", false, null, "Carol_Hauck", "AQAAAAEAACcQAAAAEDkiwZwxOejke0Ht5OHWQrce7LRJgYDuEkGlSmSGTsjhJKUtZ7oumfnI4EJmDvbE+A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("832c338d-accc-4431-af4f-b163f4abe6c5"), 0, new DateTime(1964, 3, 13, 11, 7, 15, 818, DateTimeKind.Local).AddTicks(3485), 31.82066413864430000m, "12648292-6c4a-4055-a058-303b3db65e9c", "Bryant", "Bryant", null, "Senger", false, null, "Bryant.Senger64", "AQAAAAEAACcQAAAAEGT1tehPdKDGnf3cpZlQgxdvBmjRD2Uik94EkRn472MYQjknn/PuSfsMPXKfEj3nOA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a"), 0, new DateTime(1936, 3, 3, 18, 29, 42, 613, DateTimeKind.Local).AddTicks(5941), 871.9297284485070000m, "767f5495-f0d7-43d5-ab49-82d34cbf426c", "Benny", "Benny", null, "Greenholt", false, null, "Benny45", "AQAAAAEAACcQAAAAEBhAuEVLeN5bJtAImDiGNaHxF8TqgObGuPA8IyJtdrUVUQhG45w2fd8Xw+Eihf6XZw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154"), 0, true, new DateTime(1965, 11, 26, 4, 19, 25, 734, DateTimeKind.Local).AddTicks(8689), 904.5591815897980000m, "ecc0d0fb-ea80-4a86-9422-c15441b15dc5", "Rosie", "Rosie", null, "Waelchi", false, null, "Rosie6", "AQAAAAEAACcQAAAAENEo+atxr5QcYPug8CqiRDmMZY21NfrGM/NXL75H52im45qvIjhZI1PEsjpQVJFjCA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee"), 0, new DateTime(1975, 2, 17, 21, 57, 13, 688, DateTimeKind.Local).AddTicks(1566), 266.8085460742360000m, "7b9e4b32-b206-4f24-9263-adb6785a45ad", null, "James", null, "Brown", false, null, "James_Brown94", "AQAAAAEAACcQAAAAEBi6stu40Z/rY2GltkEWY4zcyjxWg/czL7DR//+Tpl2c2aNUexcVYbRuDazNDF+vqw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8461c967-9f1c-48cc-85ae-66b9741be768"), 0, true, new DateTime(2000, 7, 31, 15, 15, 37, 728, DateTimeKind.Local).AddTicks(1645), 226.0013515635670000m, "7a007d64-ded9-4076-a315-7c5f0b2da4bc", null, "Kyle", null, "Nolan", false, null, "Kyle.Nolan71", "AQAAAAEAACcQAAAAEA+BFI6PXpGb2gkNOLfeo1HwSVfB2p5FzYs7svPrCEXnsW+LgUpJH/wr1XvWEzw+rA==", null, false },
                    { new Guid("862a826f-0eba-4891-9241-dff3a8896969"), 0, true, null, 797.4794847521760000m, "15c7d68c-040b-46db-b778-85b04f6b88d8", null, "Candace", null, "Bernier", false, null, "Candace_Bernier73", "AQAAAAEAACcQAAAAEA6GZ38l/viuW8CC5zfzff97aBk7UNDv3LZ3pV6LiKrpGlZtiNTyKGLu9WgSTHcvug==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("865b430e-4516-4a31-ae36-1eecddd681f1"), 0, null, 116.8863569286840000m, "4b7454cd-f04b-4cc9-abe6-350ed2c0989b", "Constance", "Constance", null, "Marvin", false, null, "Constance85", "AQAAAAEAACcQAAAAEDbrYLztHhfIglH2dKItaPwWpfVydqEQHDs+Ra/t9MD616C68XC5ixG+R7o4/F+zRw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("88fbd469-d541-4e89-9736-988ca894e0e8"), 0, true, new DateTime(1934, 6, 26, 16, 59, 37, 17, DateTimeKind.Local).AddTicks(8239), 66.71459301505660000m, "88e8ceec-157d-48f3-ba31-7e5b523409cf", "Gayle", "Gayle", null, "Mitchell", false, null, "Gayle.Mitchell", "AQAAAAEAACcQAAAAEM8R5YOQCXu+AZN7xZCVoE2MAmUtqiVMpeKfT6NGqqY86+HmH9MKQoPVDuI1/OEY2w==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8905b747-db92-42c9-8385-1d49f6b8e578"), 0, new DateTime(1990, 8, 13, 5, 27, 36, 199, DateTimeKind.Local).AddTicks(5325), 209.8377265285980000m, "7b684f84-972c-4592-bd5e-f99822753f34", "Mack", "Mack", null, "Cummings", false, null, "Mack.Cummings", "AQAAAAEAACcQAAAAEJRrvzAB+F8oFXpPxwBANFRtzSIpQBFqIpylteWYJS9wxKeWn1Ey7ijeq/NlxMmgQA==", null, "Female", false },
                    { new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8"), 0, new DateTime(1989, 9, 27, 11, 4, 58, 703, DateTimeKind.Local).AddTicks(8800), 193.3673116946740000m, "4dfbb35e-6136-4b60-b2e3-63ddce766502", "Emma", "Emma", null, "Rempel", false, null, "Emma_Rempel", "AQAAAAEAACcQAAAAEObZ5UDRkSTxQ/l9S9x/ikfByDL4OMnOiXnDx+EW24u2oXdzsWft51HihEPgLZcVVQ==", null, "NotSelected", false },
                    { new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689"), 0, new DateTime(1948, 11, 26, 21, 18, 59, 100, DateTimeKind.Local).AddTicks(81), 897.6665577753520000m, "a59304ae-8811-40ab-b9b2-a90626c965f3", null, "Myra", null, "Kris", false, null, "Myra36", "AQAAAAEAACcQAAAAEEBnKbhfdQGXjhzBD842uIWNapIqsFhVynsE9IF7KktkIvAcxo+V/bRxI0dyeEX2cg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64"), 0, null, 411.7715987181650000m, "736d5f07-8bea-416b-837f-305cac04de6e", "Moses", "Moses", null, "Harvey", false, null, "Moses22", "AQAAAAEAACcQAAAAEFRWRRYhah8/Q9tyoqsY6EVB6cYIQ5OtRCqVUYtNDa9ojiNSNbYGDCjb9aDx5yAqLQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6"), 0, true, new DateTime(1945, 6, 25, 4, 3, 44, 373, DateTimeKind.Local).AddTicks(7121), 770.331948167910000m, "bb1f93c7-0976-4e62-b8f1-6fb84a568789", "Rose", "Rose", null, "Crona", false, null, "Rose.Crona98", "AQAAAAEAACcQAAAAEIayjBzojlI9kRpooQwQcRMCRFbKMMUdW6bLSL5fxcdjJ4UipuuSo8iR/rnwoTZiDQ==", null, "Female", false },
                    { new Guid("8be83005-0ddc-42eb-877d-582666d35fea"), 0, true, null, 872.6446035960260000m, "aaf3a698-f6c4-468b-97b1-5974a781e7f4", null, "Todd", null, "Dickinson", false, null, "Todd.Dickinson38", "AQAAAAEAACcQAAAAEJXuGgvWMykpXvUuzr5iG+PmZiX/YQlXvxfEiagxCOiKbpGp4+LHHsECLoYSrIL4Rw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32"), 0, null, 516.2702975776380000m, "73e00492-9670-4f60-b4d6-dff092995d0d", "Lester", "Lester", null, "Toy", false, null, "Lester44", "AQAAAAEAACcQAAAAEB8jF+Mgsuo+FGMeivREKGIOHngzSjG/Y7jSEYPgZeKDK6BdUiruSusYoHymPM90rw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334"), 0, null, 99.4158965282590000m, "d826a04c-a21d-4cc4-bc82-132299a162e1", "Willis", "Willis", null, "Fahey", false, null, "Willis79", "AQAAAAEAACcQAAAAEF1SUEhtaovhWLMHv8TPEOIU/nRH665WpBO6I1zXdmlvdtByvu2D3TP7D5u1NdFP9Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd"), 0, true, new DateTime(1950, 4, 5, 2, 56, 8, 430, DateTimeKind.Local).AddTicks(5496), 874.2370513817590000m, "b83a76d3-268e-4833-929b-8c221fd5f5bd", "Velma", "Velma", null, "Hayes", false, null, "Velma59", "AQAAAAEAACcQAAAAEF55NhbVtLcfUNEc23HpB25TUhh3bwb6Y5PBQoFZhSZyOT2+R7RW2k/0YB1kEgIg3g==", null, "NotSelected", false },
                    { new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b"), 0, true, new DateTime(1944, 7, 19, 20, 39, 0, 396, DateTimeKind.Local).AddTicks(4801), 584.1579594795840000m, "b9061e5d-8cb8-421b-8ba3-a393d8a88330", null, "Grace", null, "Jacobi", false, null, "Grace_Jacobi14", "AQAAAAEAACcQAAAAEDtR+Vnh7bS4JJD4Nvle1B3i65ScUktdzdxEYItTYkU6TwCUPdchrleGpOYvmpU1Vg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010"), 0, null, 575.5969651948760000m, "71909c7e-72b3-404b-84d8-4a94e002a3b4", "Saul", "Saul", null, "Nitzsche", false, null, "Saul57", "AQAAAAEAACcQAAAAEBYtvT/lcHdu4rQj9WsQPwin2sPGkIKQ/GvBFxDpol4yOpMuyo/IxzcSCl7cQVLYMw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673"), 0, true, new DateTime(1955, 3, 2, 12, 9, 24, 410, DateTimeKind.Local).AddTicks(8391), 273.1101681313330000m, "401634e3-4bb4-4666-83a3-4239e6e5e1c9", null, "Lionel", null, "Weber", false, null, "Lionel38", "AQAAAAEAACcQAAAAEAvF0JyVCWgzcQ5+vgMCRWQnqCDWCEKchRNX8NIYIfD2A8g234hcHCxoaUR3hHzhnQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("94aaefbb-3b69-4a12-8609-44039863dc44"), 0, true, new DateTime(1958, 3, 3, 15, 40, 50, 291, DateTimeKind.Local).AddTicks(4817), 935.3374956718710000m, "54df8631-5726-4763-8968-37e130bd921a", "Sharon", "Sharon", null, "Barton", false, null, "Sharon.Barton46", "AQAAAAEAACcQAAAAELZz9izP8ujhaDNJS64QeVAhLsMqfCNSEe6XdHBvxkR/HtDP8UfHfENAK3/jQV7SLA==", null, false },
                    { new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9"), 0, true, new DateTime(1957, 1, 10, 20, 4, 43, 856, DateTimeKind.Local).AddTicks(8930), 983.2558533964440000m, "31c3dd0d-357c-42bd-ac3b-6338f4128e94", null, "Gilbert", null, "Stehr", false, null, "Gilbert_Stehr16", "AQAAAAEAACcQAAAAEAiEoHu7fAxxml8bkMh/SOi9UgPMbxyR4VKO9hec+aQpdwVw2lPu3PgBc+jfi2GxcA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("97fd604a-eb78-4e29-829c-caf68b162e92"), 0, true, null, 285.339316619820000m, "9de1d075-ed91-4938-8650-121f83a73b9e", null, "Jesus", null, "Fritsch", false, null, "Jesus_Fritsch87", "AQAAAAEAACcQAAAAEP8ps8ciZXrkeavBRfLt99y/lb95G0dnMfyeYTpmBNB5LyD6kDY2FsEGAIA7w1dEWA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9"), 0, new DateTime(1925, 9, 1, 18, 35, 9, 11, DateTimeKind.Local).AddTicks(8623), 101.1543257930410000m, "4df6261d-e417-4874-a293-5f5164e5ca85", "Raquel", "Raquel", null, "Hyatt", false, null, "Raquel_Hyatt62", "AQAAAAEAACcQAAAAEMHNM+XnKZrSxazdG6MxbR3ZSzLvZUtkyLxmsrVhlUw52eOGAOVXJHS+9KYimC83AQ==", null, "NotSelected", false },
                    { new Guid("98ec5653-7775-432e-9be5-3149a15fca62"), 0, null, 78.01261673370850000m, "0e553fa3-cc01-46cd-b1b0-156cc20cabba", "Katherine", "Katherine", null, "Satterfield", false, null, "Katherine_Satterfield", "AQAAAAEAACcQAAAAEAKnSHtQiua8iYY6x9CNBWBMTx5PS3irrqUXfWJaUFY6uczRN7XYFZ8h1yRFET4n+A==", null, "Female", false },
                    { new Guid("99227d48-6d3f-45fd-971b-83f0198ee703"), 0, new DateTime(1946, 4, 7, 4, 49, 12, 838, DateTimeKind.Local).AddTicks(4778), 217.8911328041170000m, "242d57ee-0460-4fa2-b021-d732f90a4ab8", null, "Kerry", null, "Hagenes", false, null, "Kerry67", "AQAAAAEAACcQAAAAEHRWI/ZXzTRKKQYMmrSdqESWR7a9/Hj6+eeqyNNQymgQdumELIBMUljl71DqUXkpUg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("99484890-5bb7-47f9-b211-218700e48dad"), 0, null, 292.8286569329860000m, "ec098983-1dee-4fc4-8fe2-915012f01864", "Tara", "Tara", null, "Hoeger", false, null, "Tara73", "AQAAAAEAACcQAAAAEKxMvhaty+UUmCtR/Xu2w0kgFOVTxGmaQqrSO9QgjMbyRTsnC3AeTbK45li9oEHdUA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2"), 0, true, new DateTime(1983, 6, 29, 3, 38, 23, 937, DateTimeKind.Local).AddTicks(4216), 544.9393905690040000m, "6ff05b2e-c342-41e5-854b-10c1b68eb2ef", "Olivia", "Olivia", null, "Waelchi", false, null, "Olivia_Waelchi58", "AQAAAAEAACcQAAAAEC3jDj/j1Z31C3tWCcCEQcTRGXwWZ218RGg52tp0jWsR0xAd0oYzVAUH608m8J0jLg==", null, false },
                    { new Guid("9d7effeb-d071-4689-a103-74400c1c3344"), 0, true, new DateTime(1947, 2, 21, 4, 5, 25, 326, DateTimeKind.Local).AddTicks(4827), 667.8154045881310000m, "040cf965-764c-44fc-9d17-4d2d44f91bb1", "Pablo", "Pablo", null, "Muller", false, null, "Pablo83", "AQAAAAEAACcQAAAAED3+9PhINwSk+SM7Ia8NCYLFFTvVoPdYM7vh/V9LeXDbLXMgmyP1vi7TZ9ChOZS5PQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d"), 0, null, 950.9844219870000m, "6e15d519-aef0-429a-a5e2-8376f9ff4671", null, "Chris", null, "Vandervort", false, null, "Chris.Vandervort", "AQAAAAEAACcQAAAAEEkI53VJ7d7XWNjKVRM7T6+3t5o0ulAFQ8+zLqZUx2KyMhdgN8wCQxyIiRX8XjqI5A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5"), 0, null, 851.7097866632560000m, "30bfb723-2445-4300-989c-3959ff759c60", "Robin", "Robin", null, "Rau", false, null, "Robin90", "AQAAAAEAACcQAAAAEDnbGcfVlWFCsyW4erNF4nEtj+lU8Xsia7w4xcGwON9VEYes7oQXh5GtN72hrqR7Ww==", null, "NotSelected", false },
                    { new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98"), 0, new DateTime(1943, 9, 3, 9, 29, 0, 816, DateTimeKind.Local).AddTicks(916), 827.7976116155740000m, "f9c77333-ffd6-4e58-932b-186523fd77c9", "Stewart", "Stewart", null, "Gaylord", false, null, "Stewart.Gaylord", "AQAAAAEAACcQAAAAEMfJViJncSaSg1QQbyK0SQH1cplEQia8HG5AaQEiAFcLIhxduVZmCzVxnaMc3Sq9ag==", null, "NotSelected", false },
                    { new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1"), 0, new DateTime(1985, 11, 27, 8, 44, 48, 825, DateTimeKind.Local).AddTicks(9657), 566.6251143177650000m, "4c7791a3-2e03-47fe-9918-d0c7c7d88774", "Dixie", "Dixie", null, "Schneider", false, null, "Dixie.Schneider", "AQAAAAEAACcQAAAAEGa7nYqTPxYKqS82Naxh9oMq2T0i95BBqhtBIVbBDIWQgrbPxY6hou7xnIXzMWYpIg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4"), 0, true, null, 182.8631616005860000m, "fd5f72c9-aa9b-4257-9dca-d698347c46d4", null, "Francis", null, "Considine", false, null, "Francis58", "AQAAAAEAACcQAAAAEDOuOXmXbUNFDCdMbE/vjFQat1v4SMZhPENOdfy/dGmWMEAmPqxvUmmQWJscDxxDyA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117"), 0, null, 708.7781601779610000m, "9c37abec-b8da-4d4d-bd19-15760d288e60", null, "Dolores", null, "Koss", false, null, "Dolores.Koss", "AQAAAAEAACcQAAAAEK37riqNHYDUTJyGyW5ZvS6zfS1A2C/LkRHH+/Xrf77GQhEm89z3tKjGyAP1LpBHUg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9"), 0, true, new DateTime(1987, 1, 15, 20, 56, 29, 922, DateTimeKind.Local).AddTicks(4980), 802.1211394732260000m, "9fa75797-b75e-4ff7-939a-eb24c7fa084c", "Laurence", "Laurence", null, "Schinner", false, null, "Laurence15", "AQAAAAEAACcQAAAAEBNqN7Iyu7b+GxdBdENthuOp4BwpB2kRClmfZTJoAvHlJiygLgE5bg1VtvXmpLVZcg==", null, "Female", false },
                    { new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09"), 0, true, new DateTime(2006, 3, 22, 20, 49, 5, 313, DateTimeKind.Local).AddTicks(6919), 714.8801461523180000m, "1ee33b8a-afbc-4599-b553-2131e95a20c1", null, "Debra", null, "Kunde", false, null, "Debra.Kunde", "AQAAAAEAACcQAAAAELDgYstLmtIbj3N6g6+fjo4T/dWqWjKXQEw9F1nu3KTHC71MYvOiDG7b/lSEbvMidQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760"), 0, null, 799.6155130836280000m, "aa7d5b66-8b28-41e4-b0e8-0a3f97c42375", null, "Gwendolyn", null, "McKenzie", false, null, "Gwendolyn77", "AQAAAAEAACcQAAAAENYjI7iStq7e9PIKx9TbfY+vFtnPybayg9OcVEND1z13wR2c6j4UpH+XSHhue/yyrA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a"), 0, true, null, 406.0112228027740000m, "71c54a92-139d-409b-8698-67c51b8442fd", "Pauline", "Pauline", null, "Kub", false, null, "Pauline.Kub", "AQAAAAEAACcQAAAAEA2QUI1g3N50J0mTpdigBa8bQtr7PvWlOszwaRfN4+AKIpQr431HdrKWeRZYc85gRA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99"), 0, true, new DateTime(1966, 11, 6, 22, 8, 56, 101, DateTimeKind.Local).AddTicks(3578), 406.5528598720080000m, "ae45f069-02cf-4f51-a731-c422c5955a55", null, "Jennie", null, "Raynor", false, null, "Jennie51", "AQAAAAEAACcQAAAAEMtp25TAx1wObKUfpE+EJgrHQ+xVwg0psYyKYYSVTk3DBDr/khVVm5qmQpfWcePDMw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b"), 0, new DateTime(1926, 9, 19, 6, 4, 57, 353, DateTimeKind.Local).AddTicks(8931), 551.4756339357510000m, "328a064c-48f4-4970-b51e-01a00c83be0c", "Christine", "Christine", null, "Quitzon", false, null, "Christine.Quitzon72", "AQAAAAEAACcQAAAAEOsMp2ZLERTLYohU2u32FJGCSDSLyL18x0vg8ShxpvqWO7Q/tLs+gq4r1oYeGOne1A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa"), 0, true, null, 481.8619841759660000m, "aa265c5c-871f-4475-ad78-b7f292f88c83", "Tracey", "Tracey", null, "Rippin", false, null, "Tracey3", "AQAAAAEAACcQAAAAEMXzbDuvEHF175P1JyQxYNFeJxCYE+eoWVgE4OARmH6rIwQdye1qhcZCKTKl3AukfQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811"), 0, true, new DateTime(2003, 2, 24, 12, 24, 23, 728, DateTimeKind.Local).AddTicks(224), 729.8536870021540000m, "32e1ff0d-261a-44cc-964c-6fd22b5145be", null, "Ernesto", null, "Gerhold", false, null, "Ernesto2", "AQAAAAEAACcQAAAAEBP0zR0xpG6t8kmDI3B6dXBULzJ39LuY19KhxX2Drk+vXsDuBmN4mY3yEaOAr0zj9w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420"), 0, null, 94.90263907300320000m, "51581214-2d69-4c32-8a21-42a080ddf2bc", null, "Madeline", null, "Swaniawski", false, null, "Madeline26", "AQAAAAEAACcQAAAAEK3p1JP4nF6vEwe936aVgzxAR06Pk263tb59PINRgsDKXyZQnew5lxMLVeeut3QT3A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f"), 0, new DateTime(2000, 6, 28, 17, 15, 40, 205, DateTimeKind.Local).AddTicks(7369), 644.6197140037470000m, "d19b48d0-4598-4869-be82-70349d74d90e", "Angelica", "Angelica", null, "Breitenberg", false, null, "Angelica_Breitenberg", "AQAAAAEAACcQAAAAEJBiTrIENbnyyg8cdu4OrmyFUVNpq8EmTt7gOgIgmY+Sup0tDyRwn+m31Hi0rfoTCg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), 0, new DateTime(1964, 11, 29, 22, 47, 37, 464, DateTimeKind.Local).AddTicks(8426), 826.136165582690000m, "637c77a4-e519-4bda-8afa-37c2ba2be565", "Dolores", "Dolores", null, "Willms", false, null, "Dolores78", "AQAAAAEAACcQAAAAEMdlm6R/2EWyq1+VnwI65lOiW9ZilRR0eXcM9a9EHudmm8fZUDBODjrwOy3hQLwX3g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc"), 0, null, 226.4648787401390000m, "9874aeba-a778-49d1-a155-7dca81c73661", null, "Teri", null, "Streich", false, null, "Teri_Streich86", "AQAAAAEAACcQAAAAEIA+2g9ibH3Kp7+na4EuD/FFOUnhKEK14Aa8OTKkJDsjXRmnoKN9ZzAPHdLLbJuIgQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1"), 0, true, null, 8.721251810695050000m, "d849fbaa-f999-412b-a7f3-a23aaa8e9662", null, "Joseph", null, "Gutmann", false, null, "Joseph.Gutmann13", "AQAAAAEAACcQAAAAEAF4KMrW9bcWqHIoN5CMWYVOFXUusFH74xziwM0Fp/hb2l871ma+qbNuogbX48qKRA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614"), 0, new DateTime(1984, 3, 31, 5, 25, 8, 13, DateTimeKind.Local).AddTicks(9119), 940.9562139551620000m, "31c370ca-2238-48ec-b24d-fbaaf5acf1d9", null, "Darla", null, "Abbott", false, null, "Darla.Abbott20", "AQAAAAEAACcQAAAAEN0YkvUWGzyn34abwFkHfGeg11KpaAam/WpjUYC0QLn6d/ZagqpxoLZ8b4holaDJdA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a"), 0, true, new DateTime(1980, 1, 6, 6, 52, 51, 224, DateTimeKind.Local).AddTicks(2423), 553.1936527848380000m, "f4ebb240-88f9-4994-91a2-f52d95a3ccd4", "Julia", "Julia", null, "Walker", false, null, "Julia.Walker", "AQAAAAEAACcQAAAAEChKmKzAJX51sVeK6+FkjSnP0ZiljarjBm1EEi+eJI+8DzNMXVH67iSfa2k3JFCgAA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018"), 0, null, 480.0766924529530000m, "0819b70a-8464-41f0-9242-602bbb9d3728", null, "Luther", null, "Towne", false, null, "Luther19", "AQAAAAEAACcQAAAAEFa3jCD01cjY+DZBG/tubPQZrPVSElmfmKmEG1r/xoY4/E0Xw7uC4PQRu0qFRrLg7g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979"), 0, true, new DateTime(1983, 11, 30, 13, 11, 20, 413, DateTimeKind.Local).AddTicks(8365), 143.4130701566310000m, "875e7ccd-7998-4d63-9e10-9e7b07102467", null, "Randy", null, "Connelly", false, null, "Randy.Connelly", "AQAAAAEAACcQAAAAEMje7j7N5CcoTFavOI0Lwz9XNn1ZOlylTP8HxLtjCbesvdP4HKjsR3ExeXi6z/UWbQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b738ba4a-67e6-46e7-a96d-61371262722a"), 0, new DateTime(1971, 8, 14, 10, 1, 31, 990, DateTimeKind.Local).AddTicks(7012), 980.5022127219310000m, "333ef7b6-236d-43a3-8603-2ef32ca06aca", "Antonio", "Antonio", null, "Cassin", false, null, "Antonio_Cassin64", "AQAAAAEAACcQAAAAELGzWMQohRGOjIWtb1yJozRqhvrVu6AE1pEUtvtwpj0CAKhnw63+LtgXoXAvT4ml+w==", null, false },
                    { new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc"), 0, null, 931.9061990443880000m, "597fda72-eb22-4434-ae07-67ee7f16caad", null, "Jim", null, "Bins", false, null, "Jim_Bins", "AQAAAAEAACcQAAAAELSOs490IL0Naq5e8c+JfeoRrmSn/7ykSnvftFeInhdla5OpMSFbQdLwOjVWYSqxdg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1"), 0, true, null, 706.7906755261520000m, "12564ce4-5604-4f58-a7c5-d2367613374d", null, "Jeffrey", null, "Hessel", false, null, "Jeffrey_Hessel", "AQAAAAEAACcQAAAAEKxCiTIiNlrcmO8FhJlGo7os1SMFgtbEcji8nz2sR1RYxSpA4Y3s+yZrSR4qBTaGiQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b930078b-fd85-4335-8beb-db13fd3746ce"), 0, null, 814.9892964829880000m, "90c5bd07-f331-4721-98a9-722fbd7031c4", "Ron", "Ron", null, "Roberts", false, null, "Ron_Roberts", "AQAAAAEAACcQAAAAEC61Aub+0Voa8SX29og5Iw2StB1dzG+q2Jztr7L/wZlkMsuuAwxfUe2st+q8+RbXvA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ba4e9530-0050-46fc-9d19-c319bf533845"), 0, new DateTime(1990, 11, 22, 5, 36, 29, 795, DateTimeKind.Local).AddTicks(8266), 501.4730355724220000m, "1afd90bc-d1aa-4c74-9832-66f3c09c8307", null, "Sheri", null, "Hintz", false, null, "Sheri.Hintz40", "AQAAAAEAACcQAAAAEIYcT94coSAwlfQ2GVLW/tSC3NUyesD+cXa5RQdIMfhCUFW5znyJ9Yo7t8b7yjzeBw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b"), 0, null, 130.4455025428390000m, "2cb95399-6580-4e70-a2be-2d1528188e3e", null, "Alfonso", null, "Howell", false, null, "Alfonso_Howell", "AQAAAAEAACcQAAAAEDY2x0VBNN0nbei4JgbGzLRz73eZT2Kvmh9Hf4Dnpxe6soNALaOnxpfUiVRApAzV7A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8"), 0, new DateTime(1955, 8, 9, 10, 36, 34, 962, DateTimeKind.Local).AddTicks(978), 841.8852800683510000m, "f3ef4ca9-99b6-409c-bc57-833887685e86", null, "Jake", null, "Macejkovic", false, null, "Jake.Macejkovic", "AQAAAAEAACcQAAAAEEM6Aq/yXDOEK76NFkwHTbkt4/dy87/oEe9LlmikXWh5dpBsyudPh5GZNKrpxnuLcQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e"), 0, null, 461.7342361280960000m, "9cca61c1-4f0e-4162-bc68-c1dc8e5d64b0", null, "Lois", null, "Braun", false, null, "Lois_Braun14", "AQAAAAEAACcQAAAAEBLWYml5fubYtAuSL6FtkCiBTEBffJrkUzx7FmjY2U+WEdK9VocjsvbCNkgvpWu6uw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b"), 0, true, null, 669.8424132250440000m, "8a185acc-6ca3-4b52-8c95-68f0e031aceb", "Ann", "Ann", null, "Feil", false, null, "Ann.Feil21", "AQAAAAEAACcQAAAAENwZRy1vg6k3U+YHH+0JpT96SCrT4p8F/E8ns1p77QcRWNUuc+gAZKwdvmNm95bCWg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6"), 0, true, new DateTime(1961, 5, 24, 13, 55, 5, 259, DateTimeKind.Local).AddTicks(7824), 776.5280496820580000m, "ecf6443f-7e67-4e76-9c83-483e4f97cf90", null, "Woodrow", null, "Wisozk", false, null, "Woodrow.Wisozk", "AQAAAAEAACcQAAAAEDiZLzDm+zgBGtjWXOiFISZcwYsSom4aU4SI0xfsYXoQcWJqyyyTHFRG/HigdmfXUA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f"), 0, new DateTime(1995, 12, 2, 15, 33, 58, 262, DateTimeKind.Local).AddTicks(7745), 49.06142357015660000m, "b20cedc0-688c-4a7c-8156-6c8bc4e1ff0a", "Marshall", "Marshall", null, "Schneider", false, null, "Marshall_Schneider75", "AQAAAAEAACcQAAAAEDwsF8GtJaH7NLfGHYx2zk+1FIk07mDRS9pQjlZyZqHxQ/50quo+49UMUYFxeSf1Vg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae"), 0, true, null, 438.3072294499110000m, "c47273c3-847c-4131-8c2a-9e4ee9eebbec", "Andre", "Andre", null, "Rippin", false, null, "Andre.Rippin12", "AQAAAAEAACcQAAAAEHiL4xkF5D2L3Co0e1XbnF2m9gYXborlqJzG2+eGSj1X7rjh3dCzbmqWoVC4Rov7HQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1"), 0, true, new DateTime(1978, 10, 19, 18, 29, 34, 300, DateTimeKind.Local).AddTicks(4486), 585.6500525176390000m, "bc0f1ea9-7cb1-4b0e-b5fa-58218abc8260", null, "Jane", null, "West", false, null, "Jane82", "AQAAAAEAACcQAAAAEJFyW6XjT3tMU/4Iz5aPIS5l/8qR0fSfMdQXbGH/E7j7Xitqwrc3h/et4bQW2ab7mQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1"), 0, null, 790.4423140427930000m, "3fd8ef11-0883-49ed-b602-8282509956d0", "Dianne", "Dianne", null, "Kiehn", false, null, "Dianne_Kiehn", "AQAAAAEAACcQAAAAEGVTsW+yhrWMYJBLGhc91xQaQSku1T9gQ1APNBPW5qOU58oiVIDuOCLhNaK6DzLY2g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8"), 0, true, new DateTime(1992, 3, 26, 15, 14, 29, 910, DateTimeKind.Local).AddTicks(3014), 800.5519211929860000m, "1a9a7e95-ac59-4ad6-93ab-7f07d0387938", null, "Danny", null, "Feil", false, null, "Danny.Feil13", "AQAAAAEAACcQAAAAECt72W8RGNkx7zc0n03GH1OkDoOPTzkVAvfye43URyqa5Xt7uLpr5chW7RgtPInmog==", null, false },
                    { new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26"), 0, true, null, 702.173666152120000m, "1eb87ce2-16d3-4b50-b43b-1ad534ebf4c8", "Denise", "Denise", null, "Kreiger", false, null, "Denise.Kreiger", "AQAAAAEAACcQAAAAEDSQdGRDVrqAIbUnmjF5E4az3W7+mKxBXLagSa0HJrJN8WuFMHsUw1E/g0GNeO0wCQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5"), 0, null, 806.9571860142360000m, "207cab03-59f9-4198-99cd-99158ef7a661", "Annie", "Annie", null, "Stokes", false, null, "Annie_Stokes29", "AQAAAAEAACcQAAAAEMa807L4W5NR7h8ETmO+cqoD/ZcpraVLC8ELB2pnq3JGiysu4AuhNITEo/CMWDgopg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303"), 0, new DateTime(1969, 1, 12, 23, 21, 34, 16, DateTimeKind.Local).AddTicks(9359), 617.3276485468360000m, "be349cce-4a2d-42dc-8047-2ddb0d6c5503", null, "Dora", null, "Renner", false, null, "Dora62", "AQAAAAEAACcQAAAAEL8dUe1r5ntl9C4C2O4j09I6sGcNDacxTkcA3on7J76Wy++EqzXyCEt1Yx9EUavYsg==", null, "Female", false },
                    { new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739"), 0, null, 539.7635306105370000m, "da7fb16a-4b19-40ca-bc70-c0bcaa28ee21", "Victor", "Victor", null, "Schmidt", false, null, "Victor0", "AQAAAAEAACcQAAAAEEh/jl/cP4dk2iOpPeWypRmL6DzxKrx09uc8bGn1yyJGdEwG6hFjpLUk3q/8f+C+wg==", null, "Female", false },
                    { new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4"), 0, null, 505.9021059198170000m, "1b61bb8e-ae52-408f-86d4-b7dc950e9a5d", null, "Jessie", null, "Gibson", false, null, "Jessie_Gibson34", "AQAAAAEAACcQAAAAEBcxXKDAwF4DePD4SZD3ScBeiC9LuX2SApbOW3eQAOHGKG/hMFcRNgZml3ORJqXtHQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228"), 0, new DateTime(1949, 6, 16, 1, 23, 39, 29, DateTimeKind.Local).AddTicks(3504), 173.6594559818170000m, "27d3869d-be8b-4943-821e-10a4c0f4edc3", null, "Margaret", null, "Dickens", false, null, "Margaret77", "AQAAAAEAACcQAAAAEDIVZ4iHHvluGtioYpy8mKw8JCrcirpLWBJx+NuayC13FP9bHsBUFVJ+a4dKV+271Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470"), 0, null, 371.9867523218620000m, "695cad7b-a810-44f8-bb2a-6b3174c73204", "Joyce", "Joyce", null, "Braun", false, null, "Joyce.Braun", "AQAAAAEAACcQAAAAEKnETYWCzdIEaABFxAgQgIeo6eZ/T7ygL0hYJeWAAiQW8zzIjOTKSCYEEai/vbXD6w==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a"), 0, true, null, 567.6161608327650000m, "ebcf701b-d181-4cb8-8653-79a6f326b87c", null, "Rufus", null, "Bartoletti", false, null, "Rufus.Bartoletti", "AQAAAAEAACcQAAAAEIFyz/WHXDFY3j7Cku0t6y4+k4vyaFnHublTAQdp8zP/V3LJdtoPmSKsfuiUkM3uVA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd"), 0, true, new DateTime(1953, 5, 25, 23, 52, 18, 467, DateTimeKind.Local).AddTicks(8597), 496.6535049304550000m, "098700c5-bcf4-4d59-ab22-3c4e797b5e69", null, "Jeremiah", null, "Wisozk", false, null, "Jeremiah68", "AQAAAAEAACcQAAAAED0buNDGhOSfldJEnOFJvnAw+W+lUVQWKZ5tAwoivKarPiFP4T17G3rce5P03mPjsg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5"), 0, null, 872.653491431240000m, "7f636b8b-d54a-42da-9739-936623ceb3be", null, "Bradford", null, "Dach", false, null, "Bradford.Dach23", "AQAAAAEAACcQAAAAEOVhGdFe7h5oz2CwKDqbmORgMRJhwbjjPX4C1CwuTCt84V+/6qJ0adG4cFgBESN8PQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("cc9fd67a-df81-4c57-9231-20a528617118"), 0, new DateTime(1996, 11, 28, 13, 50, 3, 145, DateTimeKind.Local).AddTicks(5033), 288.7515343737220000m, "13e043b6-cde5-41c8-a1fe-ad45c19bc25e", "Julius", "Julius", null, "Wolf", false, null, "Julius37", "AQAAAAEAACcQAAAAEC2mRrfdA3wZR+rfymxGDOinX1Zz3KK+Mv7TE/f9WeOxPLROvd1a9KQyrB2cJbXWQw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ce1f07b6-54d9-4379-9845-3751b9499199"), 0, true, new DateTime(1952, 9, 26, 19, 45, 57, 851, DateTimeKind.Local).AddTicks(5315), 190.1514952534810000m, "2c8bc2e9-7f9c-4d58-8f80-313c8440e60a", null, "Rudolph", null, "Rempel", false, null, "Rudolph.Rempel76", "AQAAAAEAACcQAAAAELdFmrTS30U8M8XGD6UtGAnA+IvXTwZRJzsgOGdyw8e56aAhTbFRk/+Jeue0OdO5Dw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f"), 0, true, null, 742.0238432658220000m, "7f6f9bd7-f0a7-4d79-8562-b39e30a28b30", null, "Lloyd", null, "Effertz", false, null, "Lloyd8", "AQAAAAEAACcQAAAAEIwoTD1rmKBRvOoj0Cz3CwtMJGD4+j9S1v8G3tqNbj49/YnCBu6Ja6py1h5Tpr0w/A==", null, "NotSelected", false },
                    { new Guid("d0104096-4d1f-467f-bbee-58d4127caa28"), 0, true, null, 173.5084184660610000m, "725d1d4a-b0c2-40df-a4f4-4dd7992e3e4f", "Oliver", "Oliver", null, "Waelchi", false, null, "Oliver38", "AQAAAAEAACcQAAAAEK0auGLWli9mOeO5pvfkPLwRTioLsjA+MbnvVDJHDy7vMjcALx8iANZiYFE9ybz9Ew==", null, "Female", false },
                    { new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477"), 0, true, null, 470.6986152986980000m, "c5a93eb7-c2f8-460d-97ca-f4467f108601", null, "Erica", null, "Halvorson", false, null, "Erica.Halvorson43", "AQAAAAEAACcQAAAAEL3u6Kz50kAn/ys109pmlRLpblXi3prCiKEqgmKXL4UCNzTETr42/GRR3iKsKLgJPw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665"), 0, null, 146.2944440945990000m, "40acd1de-a300-457b-87e2-4a4a93a7750a", "Dianne", "Dianne", null, "Hilll", false, null, "Dianne7", "AQAAAAEAACcQAAAAEAHXln31ScD4aauhbQ54Imy4WRU394yOa0IOW412D7bq/Sc3k+ZeCDQq04bJ/P7QNg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae"), 0, true, null, 146.6798900189910000m, "bddaf037-58be-4553-89a1-55a19d16d750", "Cynthia", "Cynthia", null, "Kutch", false, null, "Cynthia16", "AQAAAAEAACcQAAAAEMVY3XP6GN5KQxtWyoOsW/YCeRqEJPvG5/vu1YG8h1lchpMb+qxwZD1klQVNyxKdoA==", null, "NotSelected", false },
                    { new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece"), 0, true, new DateTime(1970, 3, 20, 18, 16, 13, 4, DateTimeKind.Local).AddTicks(5127), 172.5445439921770000m, "14ae811e-e1f7-473d-8e0a-2993ba21a4c6", "Velma", "Velma", null, "Leuschke", false, null, "Velma_Leuschke8", "AQAAAAEAACcQAAAAEDNobx5u25d4KvB9mH+Tl6tDwNPwnE5ls4guFuRr+tWrEz3kQdsUwQpgyxstXwJJIg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba"), 0, null, 462.5642562995910000m, "226fbac7-4ab7-4621-8726-6b67fce575dc", "Paul", "Paul", null, "Carter", false, null, "Paul51", "AQAAAAEAACcQAAAAEFSpwxR8RbiZ+YkJKw1gvtUCE1J6JJwsDpO4FCM3tWI9MeL2Pg8g4pC39urexgNTMw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38"), 0, true, new DateTime(1948, 4, 14, 14, 32, 18, 530, DateTimeKind.Local).AddTicks(9292), 525.2720692040360000m, "5d495b0c-8d02-4ef9-9941-a2e802593452", "Kimberly", "Kimberly", null, "Windler", false, null, "Kimberly83", "AQAAAAEAACcQAAAAEIeoHhW/NpR3+zkJRoBRZc1gf68s14kLjmDFAmW/6Gdd+lSNd40IUkMdcYAQqBI7ww==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd"), 0, true, new DateTime(1933, 1, 9, 20, 59, 20, 299, DateTimeKind.Local).AddTicks(3444), 617.9110718141910000m, "544baaf0-2be9-468f-8bd9-c03d5117e580", "Wanda", "Wanda", null, "Schroeder", false, null, "Wanda32", "AQAAAAEAACcQAAAAEIAaVlwWxBAfkncoZOoiWvvu7a1eIL7Qrm2To6eDeo6X4azb7n0MN9bmS6pIQOEq8Q==", null, false },
                    { new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a"), 0, true, new DateTime(1991, 1, 22, 2, 35, 25, 958, DateTimeKind.Local).AddTicks(2331), 896.3648581313950000m, "051a1716-5fbb-47fb-81fd-eedac3b11eb4", null, "Rufus", null, "Batz", false, null, "Rufus94", "AQAAAAEAACcQAAAAEMMLmGnw0evpz4CKa4M/p62gY94GTmoFOXnizltsKWUjnESFQRjBfXlhT8mPh7GWWA==", null, false },
                    { new Guid("d8d1525f-e931-4e18-a476-365f02c6e363"), 0, true, null, 567.3231860755650000m, "363f1282-11b0-4a41-aa86-a3b4f62b7a8c", null, "Tony", null, "Bruen", false, null, "Tony.Bruen", "AQAAAAEAACcQAAAAECIKLdvajxtoHf4S78zzptkCWtPU9NSAGbapynns9TvyIVZh5PaFAVAAXHUEp3Ouww==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56"), 0, true, null, 415.4181734861820000m, "12124ef0-78d8-42d0-a422-59a643f2b725", "Derrick", "Derrick", null, "Beier", false, null, "Derrick24", "AQAAAAEAACcQAAAAECcG6kYl5sPc0aT7OvHZVEdW3nSubdQutiHFxXl9JL4ftkS2eQHmWNNQP/0xFs+QkQ==", null, "NotSelected", false },
                    { new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca"), 0, true, new DateTime(1977, 1, 11, 14, 43, 6, 323, DateTimeKind.Local).AddTicks(5577), 664.2866449804110000m, "dd76a5b3-2473-403e-81e6-74a29845a05a", null, "Doreen", null, "Shields", false, null, "Doreen_Shields57", "AQAAAAEAACcQAAAAEM53qcRvfIYAgCPx+U1xVnMJPooH+7GKjMjTIQZjaukX6htVTevXUazoZ61CdHsn7Q==", null, "Female", false },
                    { new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1"), 0, true, new DateTime(1950, 2, 11, 20, 39, 33, 612, DateTimeKind.Local).AddTicks(7648), 376.2970036529610000m, "a696bd80-ebc2-42d6-9d09-214b79658175", null, "Mitchell", null, "Olson", false, null, "Mitchell_Olson", "AQAAAAEAACcQAAAAELIBerJIDJafMTfLaUHu9ojy67tGob4iMmcwp+1tMXXEUXnFSLwyfh+vBlfHo/Db2w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f"), 0, new DateTime(1978, 3, 15, 3, 41, 22, 732, DateTimeKind.Local).AddTicks(2792), 999.4434390938440000m, "51e325b9-5fa5-493b-ac71-cbfa34ef9ac8", "Josefina", "Josefina", null, "Nicolas", false, null, "Josefina.Nicolas97", "AQAAAAEAACcQAAAAEEvBrF0QE9N09N9l9DNAI63VNI2gCA0aBQZK+0zMhcFJjuV+4vkx+HI/4xMwqE21aw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("de956589-c440-4477-908f-fd0e51a90148"), 0, true, new DateTime(1971, 8, 16, 12, 3, 27, 300, DateTimeKind.Local).AddTicks(2732), 633.4941875825670000m, "e0fa749a-9cba-41cc-aa2b-db488bb4c4b1", "Billie", "Billie", null, "Torphy", false, null, "Billie_Torphy", "AQAAAAEAACcQAAAAEP7Ah46qLRMCjUFvo53Y0V+PPY+TP396U3Ge7RkOu0OXrFnDyEPDI/jaKBTSO+QIaA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc"), 0, null, 230.4857928922440000m, "8049ee1b-6525-480e-a6bc-768ca21da5a4", null, "Hannah", null, "Grimes", false, null, "Hannah.Grimes40", "AQAAAAEAACcQAAAAEDk87tVwB915UTtcOojXcD1w+KrxGV2WPm0LjxUBFQzZ9FjNdGtJYX6MNG+C367NVQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef"), 0, null, 681.3782557841120000m, "52958a6f-c659-4c1a-a36f-623468802dbc", "Katie", "Katie", null, "Gorczany", false, null, "Katie7", "AQAAAAEAACcQAAAAEGAvTqeZGLokGVI+GTqytW3w1TU5uzOirvhLLQSGEdXpC90vcVYh28m0xMI0lVnwnw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e352c3a5-25cc-4796-8c60-703443aad68b"), 0, true, new DateTime(1950, 12, 13, 14, 59, 16, 30, DateTimeKind.Local).AddTicks(4594), 993.191986342010000m, "f882192a-1bc8-48ae-b487-df197ac6f6e2", "Leonard", "Leonard", null, "Tillman", false, null, "Leonard.Tillman23", "AQAAAAEAACcQAAAAEA8ayAjQN+FN69tIPz53WEhtvT4CgHPmmsv5xhHALgTY/LgjgYmLSF8uqvmCJTZD7Q==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b"), 0, new DateTime(1929, 3, 20, 5, 56, 1, 135, DateTimeKind.Local).AddTicks(931), 97.05355426943960000m, "f7f29f00-b3d1-47b0-9f2c-0e49c57f5c64", "Kate", "Kate", null, "King", false, null, "Kate25", "AQAAAAEAACcQAAAAEC3XOvuIljglAlEus0ZWEvt76hG6NYkrbaRd/jB6lvDsyhu6Yd4L8PRxbxhRF9YDJw==", null, "NotSelected", false },
                    { new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc"), 0, null, 836.9399295954780000m, "1f1071e0-0eac-445a-b0fd-255f3d1e3195", null, "Flora", null, "Osinski", false, null, "Flora_Osinski", "AQAAAAEAACcQAAAAEMRLkXPyQ1c8urZlYjbysGRNF1DMjCDgL9gnmk2kQwfkU8zVYs3NZ6nWfc4Y3MWxtQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9"), 0, null, 768.7543314418070000m, "395f56ea-ce86-4279-91ba-03b2d4c17889", null, "Wallace", null, "Erdman", false, null, "Wallace_Erdman95", "AQAAAAEAACcQAAAAEDb4FrMZCSRM5Eb8T5aZPf2GLzBUIcxPQeJNQh24gjn6Jij6I4i6I2T3gl8GoiSRqA==", null, "Female", false },
                    { new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594"), 0, null, 956.1168265769550000m, "6640d36f-d0e5-4e1e-843e-81871709128a", null, "Della", null, "Lemke", false, null, "Della59", "AQAAAAEAACcQAAAAEBDolQ5tw33+Q5QDbxeE6L9JQne9d3Ut1i1+8PfqHa7yK8byb6LRpriG2jKqFKBp7w==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854"), 0, new DateTime(1933, 4, 6, 15, 20, 24, 755, DateTimeKind.Local).AddTicks(9225), 381.5851639483450000m, "918c601c-be2e-4d8a-9633-919e242f514e", "Elena", "Elena", null, "Dietrich", false, null, "Elena.Dietrich", "AQAAAAEAACcQAAAAEORNnm9nzSIIwYuNxPUXasb4UJSg4fGVJYMbEIZhkSfxupcAVxmBuu8VeXlv0shVtA==", null, false },
                    { new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d"), 0, null, 845.267167517830000m, "8ab54272-1d5e-409d-922a-3a6b335c29e9", "Estelle", "Estelle", null, "Swaniawski", false, null, "Estelle.Swaniawski", "AQAAAAEAACcQAAAAEJeVIRSauuDGw92Zzrih0hM8zBGVdZYQoIDa3nCHsMndQUvmAwakQpier4KFLdiFkw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f"), 0, true, null, 34.25368711369460000m, "c6fcf6e0-150f-4574-8fe3-5ac2e6fab9fd", "Katrina", "Katrina", null, "Rutherford", false, null, "Katrina_Rutherford", "AQAAAAEAACcQAAAAEG6kxoqZvI/1CR/VzAQKlDf6zWZ5eRmil8dZWwmaq/lVoD95Wk6FNb2hk7b1RayRuA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("eae5197e-6974-4190-b4e4-085b2af871ca"), 0, null, 18.19199815666130000m, "4ccc05e6-ecb8-48e2-ba33-d596fc0a082e", null, "Philip", null, "Oberbrunner", false, null, "Philip_Oberbrunner71", "AQAAAAEAACcQAAAAEEzKc3aX8yfAE8M0tQnbBdR4USfa5hEIhIC3usVjA8yqG+JPPZkew01X0SO0bSRrXg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2"), 0, null, 486.4138483092890000m, "9be0a24b-4277-4953-833a-fc461d3853f0", null, "Bruce", null, "Zemlak", false, null, "Bruce.Zemlak", "AQAAAAEAACcQAAAAEM4LZ15Xuh3jFSP8Rvht+IG4yUW3fDY6uOJ7oUAUGfrVU6X+sXeNK+lwxT1ZMcuiLw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70"), 0, new DateTime(1975, 7, 20, 14, 35, 56, 581, DateTimeKind.Local).AddTicks(8566), 986.6857466063480000m, "9cccf196-d808-4e99-b305-11e097b84ab9", "Paul", "Paul", null, "Wisoky", false, null, "Paul34", "AQAAAAEAACcQAAAAEPdEGZ4WdhNkaDhoWwGX/JiQCa6EQMt0Ie8y6WsAYNTEXUJXsGUt55BHxeVTflt3sQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec"), 0, true, null, 854.3340095342960000m, "6cb74d34-04e2-4d4c-a1c5-70930a25cf0b", "Ronnie", "Ronnie", null, "Mills", false, null, "Ronnie_Mills66", "AQAAAAEAACcQAAAAELffoFz5OEZgXQ+TIefB6REa6Vu1/pMK1VGymJy5lkaA/YydycfkLetlQ6Q2hyDxkg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1"), 0, new DateTime(1959, 10, 10, 7, 52, 58, 644, DateTimeKind.Local).AddTicks(3202), 407.9912052465520000m, "59aeb7c6-6ea2-43fe-b6fe-293874978d64", null, "Dennis", null, "Cassin", false, null, "Dennis21", "AQAAAAEAACcQAAAAEIjVkTxdlo/jilaGNP7tnyaHy0k8ySoRK3D4qTfQyQTOY9OrYRvrOtTot6Fgog3zfA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7"), 0, true, null, 278.8444885197430000m, "41238888-41bb-44d8-bbe5-7d4f2f7cfc73", "Deanna", "Deanna", null, "Koch", false, null, "Deanna7", "AQAAAAEAACcQAAAAEMosrCmInCd4M90rzOQ/WA+OxtM8aB3JRA1PvjMzvnmfEWDpn079NQ7Oxlhuv5+t+g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f"), 0, null, 701.9382358574160000m, "94b206cd-9183-4e9f-ada4-c977b9018cce", null, "Kathleen", null, "Bode", false, null, "Kathleen_Bode17", "AQAAAAEAACcQAAAAEIadHrmhlPj/0nVnMNfXWDypIqIb3LOAUO8TWSpn+ts6oKec08pB1aS9YH6hN1K4Ug==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785"), 0, true, null, 69.19709466469950000m, "8e6a6cc3-4e7b-4fb4-a2cb-4d92ff1ff4d2", null, "Carla", null, "Ryan", false, null, "Carla_Ryan91", "AQAAAAEAACcQAAAAEORntCwZkvG4wtTFSd2FRG8apUq6ggWRykvepU6U34OtHjE7m57dcr0+rY/+yPOXiA==", null, "NotSelected", false },
                    { new Guid("f027517a-8745-4767-8a34-aaadc0a70189"), 0, true, new DateTime(1947, 1, 23, 7, 47, 23, 537, DateTimeKind.Local).AddTicks(7855), 850.6583603688740000m, "96cccd91-844f-45cd-8753-3bd046925a8d", null, "Alison", null, "Greenholt", false, null, "Alison.Greenholt", "AQAAAAEAACcQAAAAEMOEkN1sKnSBNL4E79C8KhUbDafVO0QBmtKuJ86nc0hTY0VHhvFEUqx1tQyLp4nv/w==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f0811698-5de9-42a6-a253-8958ca513eb5"), 0, null, 155.7712616744470000m, "9409d4f1-bb4c-4f2e-9a70-a1a9d799a840", null, "Alicia", null, "O'Hara", false, null, "Alicia69", "AQAAAAEAACcQAAAAEE1A6VK84OEeOmFzUrnkW5wEYy0gyjZryLMG+UHDeK0EYyGPTi3Tt3UfyW47YDCGJQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c"), 0, true, new DateTime(2003, 5, 29, 12, 33, 8, 445, DateTimeKind.Local).AddTicks(8245), 224.6503488452720000m, "d7bb26fa-e0a9-401d-b596-85b16e02f709", null, "Eloise", null, "Ratke", false, null, "Eloise84", "AQAAAAEAACcQAAAAEKn/Bui2SlU3kp0dPOsIDshkTeZ8Wz/sZj65ccd34KMUi7L80OIo/agX4K1ClW7wSQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2"), 0, null, 642.2951627411120000m, "c3fff922-1bdd-4fd9-a23a-120522c52213", null, "Jonathan", null, "Dooley", false, null, "Jonathan.Dooley97", "AQAAAAEAACcQAAAAEHjOPcjTjxHt+8oFeLnXeF0OHbnf02Lrv8OErwJwQikBOzMsMdHgUuofL713ggn8Uw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4"), 0, true, null, 433.2268719732460000m, "dda69e0f-32c4-4704-a9f6-e6d205431e0c", null, "Yolanda", null, "Ondricka", false, null, "Yolanda_Ondricka", "AQAAAAEAACcQAAAAEEOmg2xZhENr5iXP3VJiAMa2S9inybRjKpj/jGfNhfLVVmUN+3Y7JpDaJkAwPgtGDQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb"), 0, true, null, 136.0590319051050000m, "6478e558-44d4-4464-a310-a6589e1e6c86", "Flora", "Flora", null, "Paucek", false, null, "Flora.Paucek", "AQAAAAEAACcQAAAAENrJFuUxJpU1rSG09KWj7x8USWJc7YKD6oblqG2OAQD/Nibn8JDoRuY24DRNf+xmIQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063"), 0, new DateTime(1925, 12, 1, 19, 21, 35, 329, DateTimeKind.Local).AddTicks(1768), 652.366451139890000m, "378b82c7-84aa-4bb6-a367-1c2c8602aa19", null, "Clifton", null, "Wehner", false, null, "Clifton_Wehner19", "AQAAAAEAACcQAAAAEMiVHNtnMQT+NjZqWlBcJ8EYW+aZLvq6CEE6wCh5Gh1Y+1Llm49T3mhQ689XQlsxhQ==", null, "Female", false },
                    { new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc"), 0, new DateTime(1971, 1, 19, 14, 28, 17, 649, DateTimeKind.Local).AddTicks(3311), 259.7284845594970000m, "926ee5a3-bb46-4ac6-a9a6-33c29f0afba0", "Margie", "Margie", null, "Kunde", false, null, "Margie_Kunde77", "AQAAAAEAACcQAAAAEFR0s+VInKb1bBH8oYyZglrFuje1MUxQYtLsPpHPdXZz65a/KVkAxDBmG8TBKTlOZQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e"), 0, null, 903.5172207373510000m, "09990c6a-35ed-4b0a-8b22-0d3be54dae44", "Brad", "Brad", null, "Boehm", false, null, "Brad.Boehm", "AQAAAAEAACcQAAAAEMCCYVFC6vc3HYuyCxix2Ir1xLsUWvIAdwLpPRwvkwKxfUMqSiAxeN57XAGAmC9A/A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770"), 0, null, 213.2289189935440000m, "5b4e9deb-73ef-46d4-bc05-452400f1719e", "Julius", "Julius", null, "Buckridge", false, null, "Julius68", "AQAAAAEAACcQAAAAEBhxC3IGUzJ9I1TE7KGol38sgKbv20WHLnTvn8s435DIyad+CDuVzhk5GtRzelfspQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7"), 0, new DateTime(1965, 11, 16, 9, 51, 52, 540, DateTimeKind.Local).AddTicks(9569), 974.8088498625020000m, "78d27879-01df-4885-ad31-149201ce352e", "Martin", "Martin", null, "Berge", false, null, "Martin47", "AQAAAAEAACcQAAAAEDalfkiy5dSvwkPJuKWoZiIMUj9Tbx9x70ELpM+4XVJ7CJ2bMC+/6Yk16PpWc5w33w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9"), 0, new DateTime(1947, 5, 30, 11, 17, 49, 42, DateTimeKind.Local).AddTicks(1710), 748.1688441007320000m, "581069f2-3440-40b1-b93d-fe0a7ae60fc8", "Vincent", "Vincent", null, "Swift", false, null, "Vincent_Swift", "AQAAAAEAACcQAAAAEO8QLWCwAdizUC/R/DWk+6fn91Lnfbz8LHlg9nbZIjSd0p6sORxyaCtcmECYSlCATQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6"), 0, true, null, 28.0131716661030000m, "abc0ac0e-ae57-4417-86c6-0c2d8e2b825b", null, "Corey", null, "Connelly", false, null, "Corey_Connelly92", "AQAAAAEAACcQAAAAEMb2UEpIxzzSgH3rztnItS3jOPqvmEKlTn9LsAhZPrsdipXHUvlTpMu94oC8VsTbIQ==", null, "NotSelected", false },
                    { new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b"), 0, true, new DateTime(1996, 8, 9, 15, 49, 2, 802, DateTimeKind.Local).AddTicks(7064), 436.81749774190000m, "654f7962-cba6-41ed-a88c-91498fe61caa", null, "Herman", null, "Reinger", false, null, "Herman.Reinger44", "AQAAAAEAACcQAAAAEMcgKmDBe3aIbhkJcgHgzlgPgCu2dbKfittnzTQ7KFDhlCH1g3IdemEFMUpdL3LTGA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89"), 0, null, 885.5935805429140000m, "dc8c680a-dbba-4031-90d3-2b889da6df40", null, "Wendy", null, "Kirlin", false, null, "Wendy.Kirlin75", "AQAAAAEAACcQAAAAENNvCZ0f8ZkDbS3mIevOWrfM2Y9NS6QkRT3ML3iN9CPof/65INQ/UHLfJB8osdsFlQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fb455a22-8198-413a-89a8-e92c01f42483"), 0, true, new DateTime(1978, 8, 6, 16, 28, 49, 929, DateTimeKind.Local).AddTicks(3839), 888.1801254786550000m, "2fde6d6c-2aa6-4c7b-b794-13c56a910612", "Annie", "Annie", null, "Flatley", false, null, "Annie70", "AQAAAAEAACcQAAAAEGvJNkwQWQCqwNkbGwhaQdod9Srtp4J5INzrdYvCNNRLh9rzsttwE6y9hNf6wyA4ug==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44"), 0, true, new DateTime(1949, 1, 4, 7, 43, 19, 610, DateTimeKind.Local).AddTicks(6908), 606.9025346083520000m, "f56c2038-2072-4200-9e91-1cee4856c637", "Joanne", "Joanne", null, "Stanton", false, null, "Joanne6", "AQAAAAEAACcQAAAAEAT9QMbOR6EfN6cXC3YCwC/zFKWAxSt1cg2kGy1P4E1im/+fwC9mrfPkHO5JDfATNQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9"), 0, true, new DateTime(1992, 1, 28, 16, 0, 50, 18, DateTimeKind.Local).AddTicks(8152), 555.3388458737320000m, "46d397ad-23fc-4cea-8a8d-890fe0330022", null, "Frances", null, "Schaden", false, null, "Frances_Schaden36", "AQAAAAEAACcQAAAAECLKcG8jYnxl9GrAIssymUvc86t805kupsvBCmQ5xVXJtPg82y/pY8dqYrxJWTl8+g==", null, false });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("0027f29a-3b6a-4644-9de8-3290e92240f5"), "49,64969;27,338903", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Quintenton, Gibraltar", "Deshaun Ramp, 13026", 119 },
                    { new Guid("02807f25-03bc-49cf-a833-ca97486f058b"), "49,752033;24,862404", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kaileychester, Tunisia", "Predovic Land, 84444", 36 },
                    { new Guid("036d6f81-0745-431d-84da-6d9d69789444"), "50,47606;28,125051", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Starkstad, Czech Republic", "Caden Keys, 0038", 31 },
                    { new Guid("039f43c5-7918-4f32-89da-329c48c10259"), "49,635487;25,251766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Devanborough, Guinea-Bissau", "Wava Summit, 6494", 145 },
                    { new Guid("0715ab04-87db-485b-915f-44808a18d373"), "48,430626;26,405201", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Michaelton, Azerbaijan", "Barrows Fields, 1942", 33 },
                    { new Guid("079aac52-9590-4abd-838c-09864d668b4a"), "48,461304;23,866432", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Michelle, Macao", "Heidenreich Grove, 225", 174 },
                    { new Guid("092fb9e2-15c3-4641-869d-7d6602b7cf53"), "50,748413;29,770311", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kuvalisville, Chile", "Hessel Heights, 9502", 126 },
                    { new Guid("0aa87743-cf56-4676-b725-ea5531ea6f54"), "48,246708;28,981739", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vinniefurt, Marshall Islands", "Pagac Knolls, 384", 158 },
                    { new Guid("0b4a3440-b637-44c2-8d99-e6dc722858c7"), "48,79843;27,226637", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Edmondville, Faroe Islands", "Nyasia Roads, 328", 54 },
                    { new Guid("0f2f45ed-4313-4ae0-a5e1-21d520e44fb1"), "50,96015;28,004513", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wilkinsonchester, Tokelau", "Fadel Street, 10990", 106 },
                    { new Guid("1280e076-96ba-46d9-ba31-f00e4c2a6cf2"), "49,273407;30,44984", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Adeleland, Burkina Faso", "Purdy Hollow, 540", 89 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("12e739e5-e736-4a55-9892-e21609e4441a"), "49,755047;27,478704", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Edenhaven, Uzbekistan", "Judge Lodge, 119", 90 },
                    { new Guid("2352c00c-d9d1-4094-b952-8f79f78827e1"), "48,997726;23,46447", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Briana, Wallis and Futuna", "Mark Crossing, 93792", 135 },
                    { new Guid("2419a676-341f-4e2c-9ef2-e069576a61b4"), "50,172146;26,28475", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Cierraland, Kenya", "Augustus Fork, 1230", 182 },
                    { new Guid("25428e2a-685e-4ada-aaef-77e95403e750"), "49,275253;30,828987", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stantonburgh, Austria", "Fabiola Cliff, 42092", 83 },
                    { new Guid("27ef23ce-0ac3-481d-992b-079af817f721"), "48,84695;24,862158", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sawaynburgh, Costa Rica", "Wisoky Pines, 50144", 84 },
                    { new Guid("2a534262-e96a-41b4-8458-396558641917"), "49,99353;23,126575", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Reannashire, Japan", "Emmanuelle Fields, 12458", 176 },
                    { new Guid("2bf42395-67a0-413f-99d9-e9813c1311f7"), "49,265884;30,52662", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Christiansenland, Antarctica (the territory South of 60 deg S)", "Hilbert Crossing, 310", 11 },
                    { new Guid("2c330810-c999-4e6d-8557-e392b87e7763"), "50,52971;26,424465", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Matt, Saint Helena", "Adam Greens, 802", 7 },
                    { new Guid("30f944dc-508a-4c7f-90da-a609b255ed4a"), "48,527084;26,272999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rosenbaumchester, Malawi", "Kamille Estate, 048", 195 },
                    { new Guid("31d81755-0f76-4d68-bbe2-4e07bd4f598a"), "50,776905;29,988018", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rogahnside, Sweden", "Schmeler Parks, 307", 59 },
                    { new Guid("340e46bd-5027-445b-8a77-2b4fcd1f0fc6"), "48,658707;24,753134", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bryonborough, Germany", "Ova Stream, 3172", 102 },
                    { new Guid("3a5f0062-d8c2-4a57-b75c-7b9e812a33bf"), "48,11087;25,41942", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Nils, Guinea", "Brent Pine, 78829", 37 },
                    { new Guid("3be5832f-5f45-4699-aaea-67ea48cb24d9"), "49,568928;28,030836", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Dimitri, Algeria", "Friesen Road, 852", 26 },
                    { new Guid("3f121fc5-4de0-40e1-9c5a-60a802961852"), "49,85317;27,889717", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bayerton, Tonga", "Steuber Avenue, 775", 86 },
                    { new Guid("4089ae66-2afc-4775-9010-43235f78f075"), "48,20234;25,771065", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Boport, Solomon Islands", "Langworth Highway, 341", 125 },
                    { new Guid("420381f0-7135-4787-844d-153522d8571b"), "49,958214;25,808949", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stromanborough, Comoros", "Madison Valley, 4775", 118 },
                    { new Guid("42f85f93-18ae-44ad-827d-63771aa95213"), "50,918446;24,43499", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Johnstonhaven, Denmark", "Rosemary Glen, 42606", 113 },
                    { new Guid("4812f7f3-33d2-4d0f-b99f-a6a504574bd9"), "50,489666;24,637302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Elyseburgh, Ghana", "Fadel Station, 4074", 140 },
                    { new Guid("49abbf0e-5582-465f-aeb1-85920f0781bd"), "50,681908;25,198112", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gusikowskiberg, Niue", "Felicity Motorway, 5338", 178 },
                    { new Guid("4a0518bf-a75a-4aa6-9591-e8e1b37297b9"), "50,48502;25,830042", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Durwardmouth, Greece", "Amely Run, 6706", 130 },
                    { new Guid("4c292819-7aed-47c0-9824-2891a3f39137"), "49,36885;24,362463", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wisokyfurt, Palestinian Territory", "Micaela Extension, 929", 150 },
                    { new Guid("4f20f390-eacb-4709-aa0b-744da5684305"), "48,1673;24,38954", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Elouiseside, Timor-Leste", "Ike Mews, 277", 15 },
                    { new Guid("50667182-1a19-47ad-99bc-dd1c72d49fff"), "48,620247;27,54613", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Patmouth, Bahrain", "Russel Hollow, 4294", 52 },
                    { new Guid("52033510-a4b7-4107-a490-2442ef99945b"), "48,354362;24,38405", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Carmelaborough, Thailand", "Murazik Spur, 679", 115 },
                    { new Guid("57e3675f-0da4-4e0e-b7c2-34e5a3390417"), "49,881203;30,125423", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Darius, Sweden", "Brakus Shores, 10319", 133 },
                    { new Guid("58f15b56-57ac-47c6-94db-1473ee4957e6"), "49,81602;30,06521", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Billy, Reunion", "Price Curve, 3061", 136 },
                    { new Guid("593f5685-f800-410e-98f6-11fe2dce4a76"), "48,636185;24,237694", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Camrenbury, Ghana", "Alvena Lake, 6643", 48 },
                    { new Guid("5ebf49a2-8a31-4b90-936d-b335caabf6fc"), "49,90552;29,553257", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ivory, Finland", "O'Hara Place, 6821", 2 },
                    { new Guid("66107c62-29a8-4518-9f09-7b54b1e83b63"), "48,47047;27,183544", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Murrayview, Norfolk Island", "Bosco Dale, 398", 45 },
                    { new Guid("6680c97d-7d91-43b5-822c-dc6fc3a4bddd"), "50,668266;25,854013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Corkeryberg, Jordan", "Pacocha Station, 57447", 64 },
                    { new Guid("6b4621b1-c2af-41fe-bd75-78c505c4867e"), "48,7558;30,764477", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kautzerburgh, Equatorial Guinea", "Wiza Harbors, 110", 64 },
                    { new Guid("6e2e84f1-2ab8-440f-8d0d-ff689ceb437e"), "50,73024;27,01824", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hyattland, Ireland", "Parker Glen, 6193", 175 },
                    { new Guid("71591770-a45d-4537-a369-67293e10578e"), "48,971565;29,461695", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adamsshire, Tanzania", "Jace Shores, 7007", 142 },
                    { new Guid("74d7f65a-80c7-4beb-ba8c-c824593a79de"), "50,95419;23,929491", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mrazhaven, Tokelau", "Okuneva Corner, 458", 134 },
                    { new Guid("7648b567-6345-4c1f-a9f9-3fb97ffddb51"), "48,499313;25,957794", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Chelseyburgh, Georgia", "Fadel Lodge, 3177", 180 },
                    { new Guid("76f1daa5-f6db-43b0-8fed-c550c11bdd7d"), "50,726772;29,407932", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Garrett, Dominican Republic", "Shanahan Isle, 55424", 86 },
                    { new Guid("7c3cb180-6099-4c72-97f3-f77d045e174b"), "50,782387;27,301958", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Winona, Cook Islands", "Guido Meadows, 848", 91 },
                    { new Guid("7d58fff5-a22b-4f42-af01-5b74a5286167"), "50,446556;25,534412", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Giovani, Egypt", "Krystal Landing, 0257", 41 },
                    { new Guid("80307d1d-a21b-4fe0-a424-b2127428a01f"), "49,911507;28,638144", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Virgieside, Solomon Islands", "Hammes Terrace, 2738", 92 },
                    { new Guid("80fb7d7b-ef3c-43e6-9879-4a80808c95a3"), "48,013546;28,126736", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Flatleyshire, Libyan Arab Jamahiriya", "Alexanne Fords, 29356", 90 },
                    { new Guid("83a08ed2-ddf0-45c1-8fec-3b532e29111d"), "50,55337;27,435995", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Fredy, Costa Rica", "Lori Lodge, 141", 123 },
                    { new Guid("8446f33f-1392-44dc-895a-b526eebeffa4"), "49,06062;23,882044", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Rheashire, Sao Tome and Principe", "Mariah Streets, 244", 200 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("89e9218a-29e0-4ebc-8f88-ff5cc7845496"), "50,75329;29,505983", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Miltonhaven, Luxembourg", "Dale Locks, 01049", 121 },
                    { new Guid("8a350a58-860a-43b1-9689-bf0fb1f4f7ab"), "49,212967;25,122332", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Zita, Papua New Guinea", "Ivy Station, 30790", 7 },
                    { new Guid("8cb8a186-7697-4572-8d46-22758b76337f"), "49,9352;24,893024", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Altenwerthfurt, Western Sahara", "Alivia Trail, 08909", 51 },
                    { new Guid("8d2abd3a-0eac-4a26-a0c8-bdc78d15dc2d"), "50,264847;27,844414", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Salvadortown, Belgium", "Witting Locks, 08649", 34 },
                    { new Guid("8d9a99bc-63d0-456c-89bc-950c8a3a8cbd"), "48,38882;26,435894", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "McCulloughfort, British Indian Ocean Territory (Chagos Archipelago)", "Emilie Estates, 51682", 134 },
                    { new Guid("903b43f7-7c1c-4ff7-b1d3-ca56219af57d"), "49,538708;28,400785", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Lenorestad, Nigeria", "Orpha Branch, 0766", 168 },
                    { new Guid("90a1f3f4-a382-4f41-b6dc-f087794f5b92"), "49,220467;28,089315", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Maudie, Tunisia", "Hirthe Tunnel, 838", 45 },
                    { new Guid("93fd4733-123f-452e-a5b2-b06b516ef1ae"), "48,700935;29,766325", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Ivah, Tuvalu", "Davis Dale, 4059", 98 },
                    { new Guid("9416bb3f-7443-4968-8acd-d7d1600e49ea"), "50,23241;28,4208", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Freedamouth, Afghanistan", "Kassulke Port, 72622", 135 },
                    { new Guid("95a6aa98-526f-4861-8fe0-f8665f569838"), "48,25424;25,229218", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Margaretefurt, Azerbaijan", "Herman Hills, 0178", 149 },
                    { new Guid("96631eb1-a2ec-4875-9566-39315bd16dbb"), "50,508186;30,837534", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Larkinview, Tunisia", "McDermott Motorway, 155", 161 },
                    { new Guid("a1d7c999-da50-4ae4-8053-76ca265f7e1b"), "48,140903;28,329302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rudyfort, Norfolk Island", "Tromp Route, 1136", 93 },
                    { new Guid("a23e127a-1a3b-4312-b4d8-855c27eee818"), "50,702698;27,172983", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sterlingview, Christmas Island", "Hauck Port, 0242", 130 },
                    { new Guid("a28d7d71-ffd1-4c16-8d6f-64855b661b20"), "50,324024;23,45222", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Savannaville, Netherlands Antilles", "Altenwerth Hills, 4963", 131 },
                    { new Guid("a8f67f2a-a492-485d-aecc-d6bc0253aa37"), "50,41728;26,361292", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Isadoremouth, Saint Barthelemy", "Wiza Parkway, 50346", 22 },
                    { new Guid("aa5c6825-8564-4bec-bd93-0e3686f5a7fa"), "50,758625;24,55118", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ceciliaborough, Peru", "Willis Crossing, 294", 124 },
                    { new Guid("abedee82-a3fa-4a42-9b83-0561b4de95e0"), "50,722275;27,629158", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Deionbury, Niue", "Luettgen Hills, 46418", 151 },
                    { new Guid("afbf5632-37a4-44cf-9145-1265ae1491bc"), "48,093918;25,417122", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Germanmouth, Saint Martin", "Rodolfo Burgs, 299", 134 },
                    { new Guid("b1108c10-21a0-4a4b-acbd-04f0d380f629"), "50,45636;30,679089", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Tina, Vanuatu", "Vandervort Knolls, 7415", 74 },
                    { new Guid("b3f1950d-4bcc-4ddb-95b6-9e953b009f84"), "49,97488;23,312056", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Kirsten, Chile", "Bertram Meadow, 69723", 83 },
                    { new Guid("ba21edb4-a6b7-4ae1-94a7-9ae02b42c07d"), "48,502914;26,298065", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Catalina, Belgium", "Fritsch Flats, 72449", 73 },
                    { new Guid("bc04fe23-b4b6-4729-b247-82f60a00b48b"), "50,67513;24,269358", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Weimannstad, Bahrain", "Abbott Mill, 04841", 41 },
                    { new Guid("be6a0ef7-31dc-4338-a313-ad4233189dcf"), "50,347385;30,877642", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Melissa, Croatia", "John Ways, 625", 13 },
                    { new Guid("c0b42664-6737-4ed8-a934-4ddc150ccd1e"), "49,170567;23,67409", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rohanview, Montserrat", "Carlee Way, 005", 70 },
                    { new Guid("c0e3c0da-2ab6-43ba-aa13-93fdd4c4c9ba"), "49,66414;29,76077", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Ivybury, Saint Helena", "Ebert Valley, 641", 106 },
                    { new Guid("c11eac64-3f24-47b7-8c9a-37b99ae56028"), "48,397156;28,449348", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Millsshire, Isle of Man", "Noemi Neck, 019", 22 },
                    { new Guid("c1ac5898-b96b-4a7a-9a9d-2058f23d4f76"), "48,476685;23,100735", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Moises, Benin", "Bechtelar Green, 895", 185 },
                    { new Guid("c2efc314-ec3e-40be-a449-04e2b29fbfcc"), "50,391357;26,62566", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maggioview, United States of America", "Johnathan Circles, 05280", 35 },
                    { new Guid("c43feea0-c9d9-44e0-b06a-9704d5a0f342"), "49,58712;28,254826", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Weissnathaven, Mexico", "Parisian Divide, 07839", 118 },
                    { new Guid("c969eeca-f8e8-4bd7-9691-c505bf5e0abb"), "49,58455;25,394657", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mathildeberg, Saint Lucia", "Koelpin Throughway, 5436", 1 },
                    { new Guid("cd140653-6bef-494f-a552-d8fe2262b34e"), "49,98338;28,82235", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rempelmouth, Tajikistan", "Mayert Well, 265", 110 },
                    { new Guid("cd1fc6fc-1057-4fd8-9b62-51cba4485462"), "49,048576;28,87609", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Montetown, Dominican Republic", "Aufderhar Harbor, 4640", 44 },
                    { new Guid("d23e9cf7-ab89-484d-bd75-82c079bcd4e7"), "50,608902;30,874521", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Reanna, Ghana", "Kaya Mews, 4284", 162 },
                    { new Guid("d38e973a-4358-4245-b91e-44f0cee9f6a3"), "48,089214;23,564514", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kiarastad, Bahamas", "Funk Club, 97646", 105 },
                    { new Guid("d7a05560-11f6-4b1f-9036-e2c304e433ef"), "50,809;29,94365", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Jasenbury, Malawi", "Camilla Terrace, 15038", 99 },
                    { new Guid("dba41b51-5b9f-46ed-993d-f1d2d4e37827"), "49,44211;24,155134", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rosariochester, Spain", "Weston Forges, 3754", 162 },
                    { new Guid("dbd1f6a7-fd24-41e3-b895-24fac5e66e24"), "49,03978;30,142925", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Novella, Turkmenistan", "Taurean Mountain, 3968", 106 },
                    { new Guid("dc2b0c3d-b2fc-40fb-9477-f802bb4c128e"), "48,155033;28,243902", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brendenmouth, Comoros", "Erdman Rapids, 144", 122 },
                    { new Guid("dcf63ae4-ff1c-40d5-b22a-296503b34bd9"), "49,791;26,01005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Janieville, Marshall Islands", "Samir Motorway, 5748", 129 },
                    { new Guid("df097abb-f580-4204-a0db-040fee631ac9"), "49,47313;30,822937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Clementineville, France", "Wilderman Spurs, 05083", 131 },
                    { new Guid("e12ba42d-bcd2-43b7-8fae-1e1a2c612344"), "50,25198;28,07341", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Omariburgh, Angola", "Muller Springs, 7547", 8 },
                    { new Guid("e67b94e6-8c32-4871-a7f3-1ea2b799be99"), "50,10195;25,075579", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gerlachmouth, Colombia", "Jenkins Port, 11390", 88 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("e74fb442-b6aa-4baa-89b5-dbc63f01c24c"), "48,964535;29,033037", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Colliertown, El Salvador", "Lynch Pine, 69272", 117 },
                    { new Guid("e9042ca1-329d-40c8-9fc2-23dd2934901d"), "50,605488;23,95316", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Jorgeview, Tuvalu", "Harris Walks, 3230", 70 },
                    { new Guid("ee086b89-5748-4004-b141-3d537860fd51"), "50,564816;25,151537", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Alessandro, Bermuda", "Jefferey Point, 80932", 146 },
                    { new Guid("f1d64598-9bc3-43f6-8933-07dc290a522c"), "48,62176;28,230337", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bernardhaven, Jersey", "Trevor Ports, 5515", 160 },
                    { new Guid("fab39138-33fc-4d09-9f0f-a4e722f36d51"), "50,65812;29,382992", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Toneyport, Tuvalu", "Zboncak Street, 5927", 140 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("00095aed-4a22-4e06-8106-0a7b5c89f8dc"), 90, "50,814583;28,524977", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Christophermouth, Belarus", "Crona Radial, 183" },
                    { new Guid("011d914d-4486-4ad3-a3a7-88b35563e2ec"), 18, "49,145206;26,44847", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Tatum, Norfolk Island", "Lavon Ridge, 95495" },
                    { new Guid("0188375f-ec8e-4406-90b4-169ab0528e21"), 134, "48,01053;26,338388", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Van, Netherlands", "Judson Motorway, 1593" },
                    { new Guid("05e478be-a9e1-4f47-abe1-6aa2cf8b7457"), 56, "48,727016;26,935581", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Josueborough, Iran", "Kathlyn Hill, 152" },
                    { new Guid("0a23f15e-8b8f-4714-93d2-2e5ff42568ea"), 124, "48,611588;26,457392", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kyleeport, Djibouti", "Rachelle Port, 9953" },
                    { new Guid("0cf16ee9-2165-4cd2-b935-cbd881933d8d"), 190, "50,751263;24,708916", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Predovicland, Paraguay", "Jast Path, 38992" },
                    { new Guid("0d8fe31b-4aaa-4984-8270-4a57aa7d42e9"), 133, "48,379776;23,738644", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Myles, Sri Lanka", "Hickle Stravenue, 220" },
                    { new Guid("13d25e5c-d949-43bf-b84e-f92a4b9f928c"), 174, "48,78385;28,915142", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ornberg, Hong Kong", "Myah Passage, 7204" },
                    { new Guid("17be3e3a-2b0c-402c-acb2-c8b54e03572d"), 147, "49,584103;29,816898", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Mariaport, French Polynesia", "Pansy Shoals, 056" },
                    { new Guid("1f51823d-0241-4ee6-ab57-23734bd64261"), 23, "50,761322;30,27482", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Deborahstad, Slovakia (Slovak Republic)", "MacGyver Island, 5947" },
                    { new Guid("1fcde776-5491-464f-8440-7b97121bb1d2"), 56, "49,54948;23,795147", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Olafland, Eritrea", "Maureen Summit, 186" },
                    { new Guid("215a7191-be73-43aa-81cf-02d73754378c"), 124, "48,864166;28,504433", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trompstad, Honduras", "Kuhlman Valley, 380" },
                    { new Guid("21f85cc1-8031-4e05-b754-829eafc16031"), 67, "49,52057;26,831322", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kihnhaven, Qatar", "Wolff Viaduct, 386" },
                    { new Guid("228ae616-6ea7-4a14-a72d-a2e88a21a3fb"), 146, "49,64904;26,828188", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Dillan, Bangladesh", "Noelia Pines, 7394" },
                    { new Guid("23e3e60e-b6ce-42f0-94f7-6461c3273e68"), 34, "48,313515;24,310692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Alexzander, Sudan", "Hahn Streets, 59421" },
                    { new Guid("2a76463f-a397-4b2d-9e1a-e7c54c95ae35"), 55, "50,081753;29,886143", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ankundingport, New Zealand", "Dana Key, 658" },
                    { new Guid("2d7f80ce-d73a-4e7e-8ebc-5734b9d8676c"), 8, "50,456295;25,07426", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wehnerton, South Georgia and the South Sandwich Islands", "Deion Causeway, 02018" },
                    { new Guid("2dfa9947-880c-46c9-9a7e-05d063df8597"), 13, "49,88723;28,862875", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Willahaven, Western Sahara", "Emanuel Garden, 9847" },
                    { new Guid("2f5bd5a7-0959-451c-a2f4-6bd10170105d"), 105, "49,770027;27,613117", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Burleyshire, Ghana", "Collins Garden, 39420" },
                    { new Guid("31074f33-6c9c-4499-9838-813b73aff399"), 67, "50,682;28,92533", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Deronland, Kazakhstan", "Katelynn Trafficway, 6162" },
                    { new Guid("313ebcdb-8e44-4ace-a52f-e49bb254418c"), 167, "50,23212;30,242771", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Emilybury, South Georgia and the South Sandwich Islands", "Javon Ports, 5453" },
                    { new Guid("3186f7ca-b445-4c64-b12b-6864b38c24aa"), 133, "48,0315;30,6421", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lueilwitzmouth, Guernsey", "Haley Village, 5196" },
                    { new Guid("36e700c8-ce35-4aea-bcbb-fca0fb77d9fa"), 21, "49,66307;23,38066", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Israel, Western Sahara", "Ara Locks, 022" },
                    { new Guid("387f031d-fb07-4dc5-be2a-f64f2e50a27a"), 162, "49,562557;26,211618", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bergeborough, Gabon", "Mueller Route, 0730" },
                    { new Guid("38efbc1b-5e05-4871-9245-a2a864a7dbcb"), 49, "50,159744;28,353504", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Anissaborough, Northern Mariana Islands", "Katelin Street, 880" },
                    { new Guid("3b141809-ef5f-4c01-b6ba-38002a272a27"), 183, "48,804134;26,03964", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Alvahport, Singapore", "Gus Underpass, 43416" },
                    { new Guid("3c2a6f5e-288f-4667-8097-54204b5fbd80"), 71, "49,33679;25,390442", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Alanisville, Marshall Islands", "Russel Points, 792" },
                    { new Guid("3d1aff99-aafd-4fda-a0b1-e2f450dd12b9"), 102, "50,14028;24,551378", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Amyafort, Anguilla", "Magnolia Views, 9074" },
                    { new Guid("473ac499-d8b7-4990-8bef-57ed42f537fc"), 9, "50,070484;28,737421", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rippinmouth, Iran", "McDermott Canyon, 240" },
                    { new Guid("4b0555c4-3a2f-4f0e-878d-32ac7ec1fb0d"), 91, "49,58718;25,115334", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Mariana, Kenya", "Green Harbors, 537" },
                    { new Guid("4bb4f776-f126-44f4-b21a-1693481f8751"), 107, "49,108604;30,502441", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Davonburgh, Puerto Rico", "Evans Knoll, 2318" },
                    { new Guid("54b78b76-63a9-46b0-ba78-b5dd1036e382"), 62, "48,085423;23,678854", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hegmannberg, Saint Kitts and Nevis", "Clemens Hollow, 47059" },
                    { new Guid("60225139-bf18-4520-81a0-beea0b459df1"), 65, "49,579033;24,72735", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Prudencechester, Svalbard & Jan Mayen Islands", "Windler Prairie, 541" },
                    { new Guid("60ae6256-e8ba-4e4c-a861-52eb7150b975"), 31, "50,10281;27,651525", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lorenzoland, Mauritius", "Peter Expressway, 95587" },
                    { new Guid("61794bf1-e887-4289-86c6-4deef6acceca"), 187, "48,44894;28,794008", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Margie, Belize", "McKenzie Motorway, 61590" },
                    { new Guid("632a5c80-4c57-4be4-b88a-14c757494599"), 129, "49,84115;28,112108", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Selinabury, Bouvet Island (Bouvetoya)", "Skyla Falls, 107" },
                    { new Guid("65fedf5a-2b6e-4653-af03-0092b582a674"), 65, "50,584915;26,018475", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Torpside, Svalbard & Jan Mayen Islands", "Rogahn Station, 44197" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("67a5bc53-0c75-4cae-a04e-f2084b113334"), 52, "49,655426;24,340126", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Alverachester, French Polynesia", "Frida Street, 855" },
                    { new Guid("68016ba7-c16b-4895-91a0-d222ece91c1f"), 77, "49,41214;27,656513", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Cecil, Norway", "Kling Route, 0308" },
                    { new Guid("69188688-0062-499f-a413-55f1c05220dd"), 100, "50,299522;28,99589", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Casimer, Rwanda", "Brielle Drives, 946" },
                    { new Guid("6d33c0e7-0856-4e81-b8ba-f2e11a87f53b"), 126, "49,381695;26,031668", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rayhaven, Isle of Man", "Enos Lodge, 797" },
                    { new Guid("754e82f2-1c51-4508-b32b-e22e1c0329d1"), 152, "50,179832;30,457575", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Lionel, United States of America", "Callie Valley, 011" },
                    { new Guid("76cb0031-406b-456f-8110-2094f67234f4"), 22, "48,036236;24,699722", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Steuberville, Barbados", "Homenick Park, 153" },
                    { new Guid("78648148-3ebc-4197-9d38-bf6f13070e97"), 154, "48,150005;27,085556", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lednerstad, Isle of Man", "Bosco Street, 4868" },
                    { new Guid("79c74e81-ae80-44ab-8172-6fbc2a455928"), 84, "50,41612;26,677984", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gottliebtown, Reunion", "O'Keefe Trail, 84266" },
                    { new Guid("7ec65a6b-5273-45e0-b830-99582a0264eb"), 49, "50,419266;24,882164", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "D'Amoremouth, Iceland", "Anderson Light, 088" },
                    { new Guid("81c00fdc-dad5-47f3-a1fb-12bb3f36b2d9"), 74, "48,71671;24,062906", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Freedaville, Togo", "Bryana Shores, 8966" },
                    { new Guid("8ac7d05a-a649-4656-9f3e-fc88afb6bb85"), 151, "49,825703;28,582775", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wyattland, Malaysia", "Grady Glen, 384" },
                    { new Guid("8b31bf20-6216-4a7a-b436-f956eeadbf3a"), 115, "49,084724;30,104351", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Lilian, Syrian Arab Republic", "Green Radial, 7013" },
                    { new Guid("8bd8e193-9a40-43e6-ba1b-3d28640c22ce"), 194, "50,17998;28,483728", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cathystad, Guadeloupe", "Vella Junction, 6193" },
                    { new Guid("90861355-47dd-4406-abc5-92412c188349"), 198, "49,230663;26,62393", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Pansyton, Cayman Islands", "Donnelly Parks, 432" },
                    { new Guid("91d57d0c-1b15-40c2-a1de-28f22c5de1ae"), 84, "50,216442;23,402618", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Rebeka, Malawi", "Leola Island, 6201" },
                    { new Guid("91f4f3c8-b105-4071-a41c-1089b736209b"), 94, "49,84751;29,238386", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Rowena, Bahrain", "Glen Park, 4699" },
                    { new Guid("9528559b-56f8-4cda-b66f-047178e39b0f"), 178, "48,230946;25,427544", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Enashire, Sao Tome and Principe", "Golden Cape, 7971" },
                    { new Guid("973e3a38-95d0-4377-b4e9-37852b9e43b9"), 107, "49,750027;24,412596", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Dakota, Saint Pierre and Miquelon", "Balistreri Stream, 51641" },
                    { new Guid("97a2b09b-f70c-4049-91ea-5c2bdce7fb8c"), 97, "50,69706;30,432722", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kuphalhaven, Djibouti", "Johnston Manor, 82770" },
                    { new Guid("a4839725-5e52-4006-aa01-85329b0cde76"), 90, "50,354153;29,293268", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Arlie, Turkey", "Stamm Ramp, 06528" },
                    { new Guid("a4fe0ea7-b764-43c5-9281-404d57d07442"), 11, "48,61198;27,62454", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Xander, Slovakia (Slovak Republic)", "Little Plains, 83883" },
                    { new Guid("a53cf696-e974-494e-a560-27544f2d955c"), 7, "50,115437;26,57549", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Torpfurt, Slovakia (Slovak Republic)", "Selena Wall, 58068" },
                    { new Guid("a7539a50-3a81-43e3-97e3-2c1b919c8603"), 68, "48,178757;28,528416", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Tressietown, Netherlands", "Angelo Wall, 196" },
                    { new Guid("a81cbab1-b262-446c-a624-046f1af09ce6"), 129, "50,771793;28,231457", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Jayson, Greece", "Maudie Pines, 72308" },
                    { new Guid("a95818f3-5c68-4479-8594-a7e56e745ad9"), 68, "49,21693;28,00568", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Bennettmouth, Saint Vincent and the Grenadines", "Lesch Fork, 735" },
                    { new Guid("aaec1979-a0dc-46e2-9089-849b34f6a329"), 155, "49,879913;29,453724", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Alessandro, Hong Kong", "Nicolette Parkway, 7485" },
                    { new Guid("ab553639-c128-4f40-adc4-9d45c9078dd5"), 126, "48,456303;29,535297", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Chandlerborough, Iran", "Goyette Squares, 404" },
                    { new Guid("abd6a0d7-520d-40e1-83a7-7db3ebfb045e"), 68, "48,52462;30,569202", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stammview, French Southern Territories", "Mann Villages, 1657" },
                    { new Guid("af2c0ba9-b15d-4aa9-98f6-cb578f90a5fc"), 109, "49,731617;29,587969", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Carlottafort, Nigeria", "Corkery Mill, 4943" },
                    { new Guid("b10d3ee0-d3a3-4da5-be2e-0dbe2eeff26f"), 31, "50,06044;27,39829", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Alessandro, Chile", "Felipe Rapids, 2649" },
                    { new Guid("b18efc6a-b6c1-4df0-854e-3085febc3cd9"), 78, "48,315655;24,07871", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ivaview, Venezuela", "Cole Ford, 038" },
                    { new Guid("b719e179-93c2-41fa-ad65-81633dd2ca1f"), 42, "48,132584;30,407064", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Nicolas, Malta", "Purdy View, 9320" },
                    { new Guid("b8c85c44-0afd-4fa8-a1e7-503544ddb798"), 86, "50,29499;28,439785", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Satterfieldfurt, Timor-Leste", "Huel Lock, 568" },
                    { new Guid("bd68aab5-5ef3-4ca2-83bd-273d73823d6e"), 14, "49,030224;28,138704", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Angelinamouth, Japan", "Mayert Throughway, 7947" },
                    { new Guid("c090dcf7-09ba-48f9-baff-1a30cc8ec414"), 22, "48,388184;26,613194", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Feilland, Chile", "Alan Trace, 1482" },
                    { new Guid("c6595321-2748-46f2-baa2-c656b75e9c18"), 136, "49,725723;24,409506", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hansenborough, Equatorial Guinea", "O'Hara Branch, 079" },
                    { new Guid("ca21dc3f-cd19-42d0-a30c-9ca8828825ec"), 109, "48,564697;30,10647", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lilyanburgh, Cote d'Ivoire", "Wyman Corner, 0288" },
                    { new Guid("cb02afdb-dc83-4102-948e-70fd0090fcf1"), 17, "48,84255;26,867342", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Hazle, British Indian Ocean Territory (Chagos Archipelago)", "Fae Forge, 59797" },
                    { new Guid("cbf597c7-f2b2-4aa2-aa8c-b2f2d8431e74"), 163, "50,98036;25,281622", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Sallie, Tanzania", "Reta Curve, 33908" },
                    { new Guid("ccb29f02-57ef-4cf6-bc6f-f2231b277861"), 40, "48,666107;30,59297", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bernhardview, Sudan", "Kautzer Terrace, 38118" },
                    { new Guid("d139098a-5af2-43ae-9c01-7052c5e587ad"), 49, "50,38887;26,828333", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Boganfort, Canada", "Mills Unions, 2096" },
                    { new Guid("d3fe6341-8017-4562-bdb5-dff23168c49b"), 68, "49,2783;24,6013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Whiteshire, Iraq", "Yesenia Motorway, 3752" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("d65306d4-5dc4-48b5-a91b-517f26fc9946"), 63, "48,80397;25,377483", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Pink, China", "Wava Mountains, 427" },
                    { new Guid("d725f129-76f6-48ad-9262-7f9f94c8687a"), 77, "48,258575;25,089912", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Uniqueville, Jamaica", "Dooley Meadow, 206" },
                    { new Guid("d73c7d46-85df-49b9-8cae-07f9550403b9"), 121, "49,476444;29,203663", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Donaldview, Guam", "Abby Garden, 1714" },
                    { new Guid("dcdb7572-15c7-461b-91e9-b9eaaa0a041f"), 22, "50,055393;25,604582", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jensenview, Saint Kitts and Nevis", "Kirk Common, 1524" },
                    { new Guid("dd303782-a016-447a-b30b-ed9d31debb96"), 13, "49,92082;24,706608", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Sebastianfort, Bangladesh", "Jerad Pike, 5412" },
                    { new Guid("dd672d2c-0061-48ad-b4c2-49daf74b82c7"), 140, "49,975384;27,960949", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Karliemouth, Colombia", "Natasha Manor, 39241" },
                    { new Guid("e0a8db54-e06f-4f8d-9910-9e1885940fc9"), 76, "50,474186;25,034428", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Asa, Bhutan", "Pagac Island, 9657" },
                    { new Guid("e2f7dc27-c06c-4b6c-bf58-4d9703d8fe84"), 123, "48,936443;26,772646", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Goodwintown, Zimbabwe", "Daija Route, 78993" },
                    { new Guid("e32c11d1-3c7c-4f02-b5ba-d8cff95a8970"), 79, "48,756973;27,631067", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Opal, Lebanon", "Brad Tunnel, 513" },
                    { new Guid("e42ee7be-27d3-4c9c-9a0b-79607fbdb37d"), 90, "50,603115;29,66436", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Kathlyn, Virgin Islands, British", "Conn Mount, 0931" },
                    { new Guid("e5b786b0-7624-4480-b469-28686c6a38dc"), 135, "50,768295;26,751163", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kodybury, Republic of Korea", "Katelin Shoals, 28579" },
                    { new Guid("e76f7601-df33-4a29-9acc-2f32ce2280b3"), 34, "50,9447;24,300318", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Janisshire, Congo", "Rita Islands, 4593" },
                    { new Guid("e9e35dba-d930-45a5-8e2a-31133a5598ed"), 125, "50,864296;29,090418", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Preston, Belgium", "Lina Burg, 9287" },
                    { new Guid("eab17151-c79e-45c3-80bf-018b3e377549"), 169, "48,768063;30,107246", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Stephanie, Uzbekistan", "Price Bypass, 857" },
                    { new Guid("ec081b02-c43a-47aa-9116-792f9b6d243b"), 106, "49,45577;24,290913", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Dougfurt, Cuba", "Aletha Union, 725" },
                    { new Guid("f4bd6a84-2b51-46bf-bb28-f73be6740da3"), 24, "50,50681;28,548145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Homenickview, Malawi", "Dietrich Common, 25585" },
                    { new Guid("f52a7530-8aa2-4ca9-a2de-6e9bcdbfcc07"), 30, "49,55016;25,153402", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Jacintoland, Equatorial Guinea", "Lemke Walks, 9351" },
                    { new Guid("f64ba1ed-ef23-4ffd-bda6-3210f4e813d2"), 82, "48,882507;23,616203", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sporerborough, Ukraine", "Gleason Forges, 429" },
                    { new Guid("f87220d6-f817-4265-9ad5-39c14d0fb0b8"), 47, "48,9335;26,25405", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Randystad, New Zealand", "Cartwright Fort, 0605" },
                    { new Guid("f8a41ada-e2ff-4a5b-b8ac-befab9ea08cb"), 88, "50,945496;27,468605", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Rosa, Antarctica (the territory South of 60 deg S)", "Burnice Dale, 7415" },
                    { new Guid("fe1330e5-9694-4ab8-94ed-60c633dd3cbb"), 130, "50,0047;30,336294", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Caylaview, Burkina Faso", "Koss Skyway, 665" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("04c58d8f-ba26-43bd-973f-412ce21e73e5"), -723672874, 0.8776565023801480m, "MUg1S5Md6YrjPxiN2zWuyGQKfnhEHRa3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8696) },
                    { new Guid("0608a21c-7aee-4637-830f-880206925d91"), 933947252, 0.9190844945522180m, "3JfqWYmVSAj9gHT7crawdUbtF6yNpvLoRK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7712) },
                    { new Guid("06ddbb5d-74b3-45ae-9a15-378e36443134"), -2073335872, 0.3362707632040370m, "3sjuY2AmypHQBdGwL8ZrK9iVvbR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8433), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8431) },
                    { new Guid("0704c532-3f16-4d8c-8a3d-c49b36a1b027"), -1041336755, 0.7260866199099920m, "Ma2WSh1tp857NVbUKAsuEBxZcDoM6gyT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7803), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7801) },
                    { new Guid("0a00375a-403c-4e45-81d9-5648453e19b2"), -2077819092, 0.1010677364523690m, "MtAbeWdaDwYHMcxZ98zvgJ5oG4rfSLC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8248) },
                    { new Guid("0b7f70c2-a24c-4fb3-bd0c-3754d89f9eb2"), -938422177, 0.9652328185086310m, "3B2uxvKLd5UwpqoYjXAaJFRDgc1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7663), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7662) },
                    { new Guid("0d80f38f-8d63-4fed-a11c-e8b49aea1413"), 1419112778, 0.4754955733093980m, "L7zLrfYViqNjmDXAoR42wHBKSkM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8252) },
                    { new Guid("0e91185b-5cd3-4061-8163-8349d36c7825"), -1211004464, 0.2153583211683710m, "31gPLuzrVZNwKHqvo4yGYhncUFjkiB62Ds", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7766), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7764) },
                    { new Guid("0ebd4e4c-0d4f-4a4f-bfc5-b6b9ec527763"), 1575730560, 0.171457289435990m, "LRtn4N9iu35pqwgAV2Pj17KoySzLQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7923), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7922) },
                    { new Guid("0ec85794-295f-4d64-beb5-2f4589264491"), -1464561339, 0.4531347762917680m, "MX9mjwcubNCf7BZi8aeJVysoEQ6tS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7702) },
                    { new Guid("12c50288-17da-4706-9afe-086240c1601d"), -552660231, 0.7609551695652660m, "MWVY41MJ5tPCpzDdU3ZjiseFNuLK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8355), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8353) },
                    { new Guid("173289aa-c7c8-4668-b4c6-4e252ff47837"), 155280073, 0.4460319765481340m, "Mys3K4WDSuE2azqYkXPRmeFH9hd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8039), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8037) },
                    { new Guid("174e65b5-5761-42cc-8ff8-1616310dafef"), -1336631257, 0.2161730834161620m, "3i9WyLDj2hdEr8t7gv5xFBRA4mTNU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8775), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8773) },
                    { new Guid("1b15a1f2-5b3a-447e-87fa-e319183117b4"), -1052302275, 0.9014741059435150m, "LSeyTJUCVN3572tp1k8BHmMxXDduszQifa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8296) },
                    { new Guid("1fac047e-c5e7-45bb-a806-13a690e4517b"), 1033771827, 0.8027603530309550m, "3CtaZDU81krYL7z5R2B9eXfJm4sdFVQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8451) },
                    { new Guid("205874c1-dbbd-4c48-878f-a87065ca80a1"), 795888288, 0.8567728131962890m, "LyPWbvtLS1D2aYh5w8VnXpdQK64fuCo7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8411), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8410) },
                    { new Guid("25262f6a-33dd-493e-bec2-179e07b4a499"), 2027709553, 0.496165469253290m, "L1AzH65dcqGJ8FZEUgfKkxj2VDTQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8048) },
                    { new Guid("2577265e-8ca0-453f-ae9d-fddf29bda5bd"), 1580593646, 0.8899448475203980m, "M4fBQahzG1yMY8KLSAEJiT2wgCXqvV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8293), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8291) },
                    { new Guid("266cf96a-ea62-4949-853b-ed76b7792939"), 475085758, 0.874129460749060m, "3YQxs4EyR7FAWGkPV2rvKwSgtJB56LCaT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8312) },
                    { new Guid("2761c490-0502-44d1-81de-c750dcde59af"), 1525432709, 0.6734462633922710m, "MfpSeyctN5i7wA8CqKJunabhWkogjE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8658), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8656) },
                    { new Guid("279b44ee-4bd2-4d3d-b4fb-c5a0bc29f175"), 1281293585, 0.8829638925193320m, "3nqGcFZLTwMHeNyizAjsB7Prua1XxE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8142), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8141) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("286d606a-42f0-457b-b87f-ddaeb079fd47"), 1726622669, 0.6813507629929570m, "3rpKH3U7Vqo82tYnNCkZTPwzXjsuWF4h", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8231), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8229) },
                    { new Guid("2cb38dc0-699a-4b32-8913-897097108132"), 270803968, 0.1278891860939750m, "LYWcT4yvzQ8LSp6ECAm5VutrBqws", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8176) },
                    { new Guid("307a3003-b492-4f24-bee3-32e6f79361fd"), 1279668229, 0.1601202316664820m, "M7BR5sJQrn6fjUm43bcD9PEvyYgkKSeptA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8411), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8410) },
                    { new Guid("36eafe3e-85c0-47ff-9d12-70738a914e6b"), -944384305, 0.09884648119449980m, "MhHKxmSCj57GY6kpZaoWgsUdP3vwLt2eD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8491), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8489) },
                    { new Guid("37344190-f549-415e-a2b0-9533e8c59a06"), 1639824970, 0.02422687529015970m, "37odDfg8Zqvx2ahAtFXk51rbT3pPCN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8277), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8275) },
                    { new Guid("3c148198-2789-4c63-a1b4-2c818edda1d1"), 827041294, 0.2173063798991380m, "LadyTuQUScnGHPpg5e746jK93fDEh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8235) },
                    { new Guid("3c81f39c-545e-4013-a2db-4bfb3eb5a217"), -14868910, 0.9754562734790980m, "3qy9xAiRf128z67aboPNutW5mdMgDhwGZv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7685), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7683) },
                    { new Guid("3ca454a6-7bf6-47ad-96f5-ea1f47f8abf9"), -517621567, 0.7407576026299810m, "M8ziFc6ut4TKYjw72QBAsMVZ3LW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7571) },
                    { new Guid("3dcb1fa4-524b-4eb5-917f-a9df366764c3"), 346604496, 0.6558826703534690m, "3HCgUu2znkQ85ScWbMpjNe4BDA6P731wXa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8876), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8874) },
                    { new Guid("3e25b804-6a01-4667-a97d-9915bae87d9f"), -2035196842, 0.3879660974241710m, "MoC9yY58ZVHQsEbLxSgFNT2K3PvaX1qRk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7746), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7744) },
                    { new Guid("3fcb2484-0837-4ba9-b6e5-a56ab2141295"), 1912016418, 0.1701494179048160m, "MWtr7kXzNLCVMBovxgj2afEn1b5Ze", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8977) },
                    { new Guid("413968e2-12b0-47d0-997a-3e3612c53648"), -198531896, 0.6868171248924160m, "Lctq1ak79HjT3iVsyR2Sepmb5YMwvn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8352) },
                    { new Guid("43fa609b-3cc5-410d-b1c9-45d1fbbc273a"), -1954892359, 0.129273334710280m, "L53u2z7of8gSCFtb6eDKnPEpsj9hmWA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8390) },
                    { new Guid("45014d3c-d9f7-46f8-bc03-f6af2addb2e1"), 1804224656, 0.353543819472820m, "M6JNW51EfKqcydCSvTnF9earZRu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8016) },
                    { new Guid("47a5b5f0-4be6-4cdf-8485-ff1ab2f67210"), 230632982, 0.4603792748143570m, "Lw2NPSvTZs7dfHky5zmgpx8bMJc6YqFB1L", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8899), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8897) },
                    { new Guid("48d4852b-def2-49f7-aca3-645eb92e2a39"), -587817802, 0.5407806634250020m, "Mct6YbzExuHvUnXsoDp2ZyNkerWd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8333) },
                    { new Guid("4a85f686-8320-42c1-8bb0-bebdd729cae9"), -1780109525, 0.3471011279940020m, "3N6xvH1AMu24BDFwC73nfkQKiZbT5PXJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8612) },
                    { new Guid("4ecd7825-c670-498e-8085-4b5421ef854a"), -501732486, 0.6092989988266170m, "Ms5EBj8QPNum2KZTiycwVRFzMbqkp3raA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8199), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8194) },
                    { new Guid("4f7b9ada-dde2-4279-bebb-7194671e2b5f"), 1569820423, 0.1132919788704920m, "McBkh5LFGDmz9TtWr7fwbPXgHRyS24ex", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8057), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8056) },
                    { new Guid("5474578e-fb64-4cfd-9f94-150a9aba1b28"), 1911788065, 0.8176412574343790m, "36ABLHoCZtygNFcrknPz3vdjUhXm95R", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8132), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8131) },
                    { new Guid("566467bd-b02a-4880-9329-c1e62f9a2b7b"), -891203657, 0.198251250165470m, "LZvRYtxm7SFCTh3fnio6EzDgG8ubkrPWe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8476) },
                    { new Guid("5f93d2c4-cb9b-4f40-bdca-1862d6155c9f"), -567169416, 0.2762149935239810m, "Lk36a4ToDmBetnKs2YQrEHLx8uc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8953) },
                    { new Guid("60104021-6be6-4259-b8a9-c35ba72933dd"), 1742446201, 0.9361486022827860m, "LazBZ6r38wmHGsCSAvMJ5XhTpnif1t", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7941), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7940) },
                    { new Guid("6028ce47-bb9e-402b-ab09-a0c9bb505ea9"), 1126905626, 0.508314029362490m, "M46sreVwTbqRHkJxmQX9KNCjvfDhz2SPpU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8677) },
                    { new Guid("61783dbd-99be-44b6-b761-179a6e48ffc6"), -1096051599, 0.4434451636983580m, "3qMrZhGzPgcHFp9bLAiNem6V7Ud2X", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7982), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7980) },
                    { new Guid("625ce4e7-cf76-4173-b96a-a0dc54f08ee4"), -1296274937, 0.6192334573163140m, "3FJjfEtnNdavpmxuC762esrLDg91BV3McT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8175) },
                    { new Guid("6471430c-91a4-4992-979e-f0dbf990180e"), 77052870, 0.9501043623673740m, "3CoerUgjuEpR7dGFPDJ8TWm9fcb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7906), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7904) },
                    { new Guid("64b287e5-410a-4477-be21-7d67a88fc31e"), 1656176756, 0.4374120432177570m, "3vPCSeZWQ6ALxT1biwtr8daVGufY2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7998) },
                    { new Guid("6dc6fa19-775b-4ed9-8cd7-45ef2e05bab9"), -1652291714, 0.7185159060752110m, "MVyDA17YEkuvHpgLzMj692GRbdXqeto4BF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8437), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8435) },
                    { new Guid("73089516-6070-47d7-9c7a-b0505a71ba6e"), -1466765337, 0.6797709266523470m, "MduUQkiPMe1fmZ5AJNpXwr3VLYTs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8791) },
                    { new Guid("7480478e-c2db-4cbf-9d7e-bb368d9b0a68"), -824833680, 0.01905650014550m, "Lb3jxqUV2vcDwerpthX9MgWuJ46KPf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7847), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7846) },
                    { new Guid("7697f2b9-8dd1-40ff-82b7-5ea1802e2de0"), -2057567484, 0.3925009934015290m, "MQkSXdCWh8NzLtJbAHFY4pmRu9BVZE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8855), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8853) },
                    { new Guid("79380ac3-7673-400f-9be5-f59b7bdb2fde"), 69013726, 0.5664628046152260m, "3FW2XK8hzmTjVkCt51PH6MaDZxoq4Yp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8332), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8331) },
                    { new Guid("7c852fdb-9597-4d1c-9890-06e9e5d72ff5"), -1249542061, 0.1319823444951830m, "M7a9q6CYXpkneFvMEmUjWD45ogJGA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8392), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8390) },
                    { new Guid("80b81674-830b-4cbe-aa4d-8c76cecb1616"), -356474350, 0.0591429466117840m, "LLsrypeJ6EvfWuCQo2c84hA5aP17wSqKi3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8199) },
                    { new Guid("81448153-13a5-4b4e-8e00-3f8e31055f8d"), 1829782442, 0.5802042319550070m, "MWy6g2rksSJUtuA1aZEYFe4b9LKhRv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7782) },
                    { new Guid("8152baec-f6e6-48fe-877a-628dc5b477f5"), 1691146097, 0.69571390874440m, "MeKCRkNhnVsy1bPjtrx9LmaTqvgHwSQD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8150) },
                    { new Guid("828b79ae-7895-4329-a86a-a5bdaa9f894f"), -697083753, 0.8928530657390940m, "3Boscx6qTv1uMtV5XiPFwKRAWQ4e97", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8756), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8754) },
                    { new Guid("83dcb72a-fbe7-4189-acd4-02a343bcc364"), -1243693046, 0.06027745013025990m, "3YfmabhnLU28vR63qdcTuQyiDVE5XM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8032), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8030) },
                    { new Guid("8406a0bb-3255-4ea5-bb17-bbfc9f6c3663"), -745806392, 0.4082373231739220m, "LZEqnmTxyPkK5QVr13GiFC2a6cMNUowtLp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8593) },
                    { new Guid("88320527-9f6d-41ee-bdd8-88b2b4dc8688"), -964045590, 0.9743129817917940m, "M3yn2ghfH75mq9JrRNtYGi46PZvMLoScj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8090), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8088) },
                    { new Guid("8c1cd229-06ae-442e-878e-76caf661390b"), 1218924348, 0.0454511247377610m, "LDAazjBTxmoL6t2rnbp3EVGguwhWSqk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8070), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8068) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("98764152-0f08-4e92-a0f9-614a62693135"), -1316616083, 0.8982140817174840m, "L6y3rkNwfCM91RdF8Amv4DQZBsn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7596), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7594) },
                    { new Guid("988fba48-f8d4-4075-8ac6-50916f546683"), 476507236, 0.9233754029907720m, "MofSrF38vQDWCknHqe5yZuw4xa1d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8012), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8010) },
                    { new Guid("9924afe1-dcd5-4ef6-9590-1873684f3884"), -232223800, 0.6012461388649880m, "ML4SqnzxH8wv5DZkb2G7tEiTdyoNfu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8372) },
                    { new Guid("9b965bb9-bee6-441e-a269-8b2737cc6d10"), 899810520, 0.09180292198450540m, "ME4H59pnUXNGZK3QMAe2jmoYF1Pacbqsd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7827), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7826) },
                    { new Guid("9d8e2123-d8fa-44a1-a780-aaf1951abab2"), -133320161, 0.8630576169698440m, "Mmh3yHfi6198sKjunTzkWrUJX2wtc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8918), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8916) },
                    { new Guid("a77267ae-8e8a-408d-a7ef-f58a9dabb34a"), -169365314, 0.9611217351445620m, "Lsj9eXYUCGmuLZi8MboBzkFH1g7PS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8510) },
                    { new Guid("a8b12127-2e57-4a28-a33d-d9a77020c2cc"), 1152535099, 0.8794227786416350m, "LQumVb8U4SBFoDtkgnpiX9AEPT5frv3R", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8567) },
                    { new Guid("aa9fbc27-8acf-45a8-bd29-51f8a7a6f8a7"), 1386008098, 0.1647730118646760m, "Lc5y1DAehkZLJUgVatrQXipq7Eub", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8113), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8111) },
                    { new Guid("aae0ccff-93f2-4533-8744-d0195147c42f"), -405802927, 0.9015624920343370m, "M641GuDTBcLp8ASjsyr7FbiqxEw92HPV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8834) },
                    { new Guid("ac23bc6b-0953-43f2-8bd2-281b45c32176"), -253033213, 0.5498530828406590m, "34afBKWesZF3gRdwXruvcVzjG7ykQm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7864) },
                    { new Guid("ac6f9a25-b79a-4028-b4d0-a53c82f5b2f3"), -814850675, 0.263928361507240m, "MfWxZ7BbsHKyeUFjC1q3rwtgQoaEA9nu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8937), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8935) },
                    { new Guid("ac99d53e-9359-4c8d-b403-26bce8b4a5fb"), -285259907, 0.3988149157339460m, "346RKPrTAnm5eY1gSb3iHBDwCjZWNJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8219), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8217) },
                    { new Guid("ad5f9c7f-1097-4ef7-9fb1-80cc36c592f9"), -1818260026, 0.1258918335069110m, "37DjS2cuYoiHmTg1eWU4xPzdyXtA6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7988), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7986) },
                    { new Guid("adda4a15-acc7-4dd6-ba6e-fb9afb5c68fd"), 1421036872, 0.2861646874971290m, "MAZTNoJ5K2yzkgWXMjh9EwFL1spC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8371) },
                    { new Guid("ae80524e-1125-4b32-8736-3172d03dcc4f"), -2088629235, 0.851911424803250m, "3yAeKMEdq2Qm9kTCnXcS51GrPU4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8075), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8073) },
                    { new Guid("b1cddaf0-4d5b-4e23-9320-4529f2425184"), -133708749, 0.784859635189910m, "LifuyGwnHrvBV9Jgc17ohPs8txSMXUj4e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7887) },
                    { new Guid("b842705a-0169-4c4e-9161-9b194a31d5de"), -725440278, 0.8631238448207980m, "LRuk3xKT2vXLs4JU9CbrdYtamiQP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8159) },
                    { new Guid("bc266e10-fa26-4830-a731-20019fb72dbd"), 892401959, 0.7900347858775990m, "3TrqwaMPpRgzv79Lkj42KHANU1f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7968), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7967) },
                    { new Guid("bc9574d8-1db5-4352-9579-826f7e5348cf"), 1956403968, 0.905267529085520m, "LWais2ZYMPH3NnRqLJfDTGQBm5AV6dFECk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7635) },
                    { new Guid("c15b49ca-ab64-43b6-9047-65bf53c68683"), -41212016, 0.5564222430082760m, "MWBcjVfLxAbyPtweXEZn8vzq34F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8735) },
                    { new Guid("c1d5cdd2-93b7-445d-9201-993f9f8489cc"), 1989597546, 0.1232580993311310m, "LZvk1uftNUAFRxYnVTS7i3HKm8sor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8715) },
                    { new Guid("c68beac6-4d84-4b21-a1dd-bd420eaf355f"), -662810512, 0.482010832211780m, "3gNdzZBuWwyQcihKLM814CjaDb32EnVYpF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8121) },
                    { new Guid("cb2f205c-9a3c-417d-8abf-b599db1c2c57"), 1141292291, 0.9205141871610910m, "3v9QKVhGS17yJzUC4djq5FRe32Li", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8315) },
                    { new Guid("cb73879d-ef35-41cf-b8be-3307cf72a5dd"), -844412529, 0.293095972630340m, "3FRueWDXsTfEPNxbkQHzB42qVYpL71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8632) },
                    { new Guid("cd5ca92e-a200-4026-999a-0b93847e810e"), 1016883555, 0.09259679382783420m, "My3JvqsxcToj6niLX2C5PHzWYmFuQMU7Ze", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8456) },
                    { new Guid("d6895404-e81e-4f14-be7a-c89efacde006"), -1206725603, 0.08815710523070130m, "Mot1fvcsKGULrwM2iu36JhzVFj4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7963), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7962) },
                    { new Guid("d716c9f4-3656-4f3a-957b-05cfe6aafa18"), -642654140, 0.02647775476410160m, "MqEh3jyzHUDocdSZKX1CFBYAJvaium2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7948), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7946) },
                    { new Guid("d72ccbe5-720d-47a3-a8c3-555f3e2f29fc"), -254733010, 0.8536289729252820m, "L8rL54FzvgXZVcsdwmAbuMUQiHx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7917), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(7913) },
                    { new Guid("d85771fa-d495-488e-8ccd-d979e4635f38"), -1556052003, 0.1152728079542610m, "3g8MJA73V5RdSpwb4kQcYHtyrGZfNUEq", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8470) },
                    { new Guid("d9ed6a0b-20db-4de9-9a25-2d7791712e06"), 1038405361, 0.7677825244817310m, "MMPmudKktFGRycf2z7AsQEv6raqX5pe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8268) },
                    { new Guid("e2b58dfc-754e-4f75-b4c3-ae1454c53172"), 249616816, 0.4573079453530680m, "LyqTVSkMvXuzfWFHGa6ropBt8Qh2K4eCc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(4385), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(1209) },
                    { new Guid("e7829059-5b9a-45e1-9249-259c9ce6a50e"), 1437005722, 0.9305676625671880m, "3jJK5cGmX6xiWYftD1hP3qv4u2T", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8496), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8494) },
                    { new Guid("f4552fb5-fd3a-47ce-952d-5d320761e6be"), 219857614, 0.6700197501256320m, "MyVoS3CHzhN8Fi1MQEcrLRmjKkeq7B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8816), new DateTime(2024, 6, 5, 13, 30, 0, 276, DateTimeKind.Local).AddTicks(8814) },
                    { new Guid("f6c816a5-2f39-45b7-ab3b-5cd0f6e4f65a"), 428413749, 0.08046169617078080m, "LVx954hdRzkXeQK8s1rtaW3fNTnuJMwy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(8092) },
                    { new Guid("f7b1783f-4083-4e7f-a915-1243f8e11d03"), 561902115, 0.07174341654076480m, "MoZTd8AfPq12DcbEiXYaQNkU3FhKwr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7535), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7527) },
                    { new Guid("f84b828e-9378-43e4-908a-8a128166503e"), -979540776, 0.5973030444721840m, "LRy1aKusfkqYj8VovSzdHnTJ4GwBb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7614) },
                    { new Guid("f9a1a188-de3e-42fd-bf4a-7548fd8ace02"), 2123346706, 0.9275622419500580m, "LYJ7LtonV3gF6vpRKGmafz2SNsCZk9Te", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 10, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 6, 5, 13, 29, 58, 222, DateTimeKind.Local).AddTicks(7725) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("08094f90-68b7-4576-a740-581a4878e4ab") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("0f9851be-b682-479e-aec8-51795a73a90e") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("1154048c-cc8b-409f-a802-5dbe51d20548") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("30b2066d-f465-42ae-93e3-4a38936052b2") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("3e1827bb-2cfc-4263-be79-7b663816638e") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("43a79d17-6c7f-4919-8fc7-806f34234239") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("45649949-0283-499e-b496-44660ddab1e4") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("4ea29651-f292-4cbf-8413-d8821c394155") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("4f03daca-02fb-425a-a575-bef52173e4d3") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("4fde002a-ab64-405c-bb95-313bef89420b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("527f7c3d-02b4-465e-8153-3472af913951") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("52f24d75-fa03-403f-8430-5ca835f68726") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("53a7a51e-d382-4050-82a5-f33ab7641603") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("5ffc49e2-50fb-41f2-8784-192077f86010") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("617100a1-d830-4170-9964-86b27fc31a31") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("6b524441-f464-4e08-8f72-3c7c650f6875") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("6bf86772-9995-44ea-a063-ccc583990881") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("7573b136-e686-46e6-b0af-1186d8e37af1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("77f944f9-c758-4983-b702-656640bf5672") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("78016c36-672a-4efd-980e-250a79e4d32e") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("80ed64a5-2f87-4262-aed3-901da3da1369") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("816326af-094b-4b97-b10b-548a2296766b") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("8461c967-9f1c-48cc-85ae-66b9741be768") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("862a826f-0eba-4891-9241-dff3a8896969") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("88fbd469-d541-4e89-9736-988ca894e0e8") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("8905b747-db92-42c9-8385-1d49f6b8e578") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("8be83005-0ddc-42eb-877d-582666d35fea") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("94aaefbb-3b69-4a12-8609-44039863dc44") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("97fd604a-eb78-4e29-829c-caf68b162e92") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("99227d48-6d3f-45fd-971b-83f0198ee703") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("99484890-5bb7-47f9-b211-218700e48dad") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("cc9fd67a-df81-4c57-9231-20a528617118") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("ce1f07b6-54d9-4379-9845-3751b9499199") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f0811698-5de9-42a6-a253-8958ca513eb5") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("820728cd-34a7-4b37-bdcf-99861585c75e"), new Guid("fb455a22-8198-413a-89a8-e92c01f42483") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44") },
                    { new Guid("0a71bdb4-557e-41e7-a640-76919d7c1f60"), new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("8e487ecf-f1da-4b14-897a-8c68905ce054"), new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("004833d7-25ec-4739-bb9c-0e70670894df"), null, null, "Chauncey18@gmail.com", false, new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0") },
                    { new Guid("00bbd0fa-5f3b-4639-b254-e3de3f3d4490"), null, null, "Yoshiko_Heller@hotmail.com", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("0158f11d-90ff-4f4a-a3a8-2bcf3c60597a"), null, null, "Damien_Jakubowski34@hotmail.com", false, new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee") },
                    { new Guid("01643175-6ce7-47d1-a415-57a7315b91e2"), null, null, "Patience_Mills35@gmail.com", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("01781bf4-4a9d-4212-8fcc-1b9eedfbd383"), null, null, "Trever29@gmail.com", false, new Guid("6bf86772-9995-44ea-a063-ccc583990881") },
                    { new Guid("019cc040-78be-4534-8380-89d47523e8ae"), null, null, "Johnson49@hotmail.com", false, new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("01b9f58c-552f-4b61-b06e-aadddfd8831b"), null, null, "Blake_Schneider51@yahoo.com", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("01e756b8-96db-42d4-b722-bb5541837e70"), null, null, "Brendon.Dickinson85@yahoo.com", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("022294c9-3d10-4e33-8484-c46bc996383a"), null, null, "Adolph.Armstrong@gmail.com", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("024612f7-c210-44c3-8fd4-73c9effd5cb2"), null, null, "Dianna_Gerlach@gmail.com", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("03b15895-f06b-4e02-99de-9008572f864a"), null, null, "Aditya9@yahoo.com", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("03d0929e-4053-4f97-96c8-4aef779fb1b8"), null, null, "Alene.Schoen66@yahoo.com", false, new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("03dd9851-259f-49fe-83fa-1f1fb3f0f6e5"), null, null, "Dariana_Roob12@gmail.com", false, new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e") },
                    { new Guid("047b4984-4980-45b1-93cc-e0197150beee"), null, null, "Shaniya_Kub93@gmail.com", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("04f8cbf0-4e42-4825-9c0e-02d6108b9e79"), null, null, "Verner34@gmail.com", false, new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063") },
                    { new Guid("0559c226-34f6-4859-89d4-7516fafa94d2"), null, null, "Alena64@yahoo.com", false, new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799") },
                    { new Guid("058a4a22-bab6-4a76-9df7-0a30049960f2"), null, null, "Eunice_Collins@hotmail.com", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("05cd1a64-6840-4ab7-bdb4-1efccf5d6d40"), null, null, "Aniya.Turcotte55@yahoo.com", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("061f12c7-e3cc-4378-ae49-3338452475ac"), null, null, "Stan80@gmail.com", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("0629e85c-4a6c-4595-9c84-ef6d92036f0f"), null, null, "Marion_DuBuque80@gmail.com", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("063159cb-c7f6-4aee-bdb4-0606bf3a5d04"), null, null, "Lessie.Kerluke@yahoo.com", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("066ab8c0-98c3-451f-8dec-f7bc347dc802"), null, null, "Alex_Terry@gmail.com", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("067dfdfb-814d-41da-a3e9-e95f1eeb4168"), null, null, "Neil_Jacobi@yahoo.com", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("06e6363f-c375-41d5-b272-b99e551f810b"), null, null, "Llewellyn13@hotmail.com", false, new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da") },
                    { new Guid("06ea3c62-cc8b-4eb4-bfe9-a01114d24a1b"), null, null, "Geovanni29@gmail.com", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("073272cc-d63c-46e3-b925-2fd5368f3925"), null, null, "Baron_Ankunding@yahoo.com", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("07652077-249a-43e3-9bb5-b65f463bbe52"), null, null, "Terry_Prohaska8@hotmail.com", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("07f87b18-bc0b-4472-9c28-4966d0d29af0"), null, null, "Zetta.Gleichner@hotmail.com", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("090bb417-817a-45a8-9764-32df7f8c57d7"), null, null, "Hunter43@gmail.com", false, new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2") },
                    { new Guid("09f7491e-c85f-41c2-9ccc-e7c87a30bd89"), null, null, "Courtney10@gmail.com", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("0a6bc61e-89d8-4e32-b883-527dcfb72ec8"), null, null, "Orlo48@hotmail.com", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("0c2d58fa-e6c4-45cb-af25-658e8b7a492f"), null, null, "Scottie.Price26@gmail.com", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("0c9ad4f4-6af5-4809-ac4f-d08771b186d2"), null, null, "Wilburn.Stokes@hotmail.com", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("0ca6ce58-af23-4a17-81cf-73bbafdf4e34"), null, null, "Domenico.Bode58@hotmail.com", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("0cf576db-b2c9-4cba-9335-1f171121d197"), null, null, "Wiley_Hauck@hotmail.com", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("0cf7720a-f7e5-48f5-944d-6e74894aeb2f"), null, null, "Max97@gmail.com", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("0d334245-6c84-4653-b486-a247ea6c8a0b"), null, null, "Noemi_Will74@gmail.com", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("0d586637-6ee6-44af-b97a-fb6e6331118a"), null, null, "Dannie.Lesch@hotmail.com", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("0da4c689-ec69-4977-a951-8a9d9af31a92"), null, null, "Morgan_White@yahoo.com", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("0de94b08-8256-4880-b080-193bcec2ae25"), null, null, "Barry18@hotmail.com", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("0e1853e2-14e5-4fd7-87d8-0b76eb90fdbb"), null, null, "Brendon_Robel12@gmail.com", false, new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c") },
                    { new Guid("0f3528c0-a5dd-4ca4-9c8b-cd6c83a33b4e"), null, null, "Bernardo_Hane9@yahoo.com", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("0f8d1121-858c-4f72-9152-e8904f2f2e32"), null, null, "Hazel.Dach16@hotmail.com", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("0fb2c980-6438-4a10-abc7-7aa7ffc1c67c"), null, null, "Jaleel_Emmerich@gmail.com", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("10c21bd9-da59-432a-b799-fca542ef900b"), null, null, "Else_Walter9@hotmail.com", false, new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9") },
                    { new Guid("11a730ab-0aad-4956-a96e-761164f4708f"), null, null, "Charles62@yahoo.com", false, new Guid("8461c967-9f1c-48cc-85ae-66b9741be768") },
                    { new Guid("11e12788-1a74-4d33-b7c2-8ddb9a97fde2"), null, null, "Jalyn.Pollich22@yahoo.com", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("122b986c-f135-42cb-bb4f-b390851309be"), null, null, "Jerrold.Pfannerstill@gmail.com", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("123cc827-b078-4f53-9528-d9c66006c27d"), null, null, "Eleanore69@gmail.com", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("12992a8b-2648-4f16-9fb1-bab9031a7118"), null, null, "Peyton76@yahoo.com", false, new Guid("5ffc49e2-50fb-41f2-8784-192077f86010") },
                    { new Guid("12b172b1-61c8-490d-a31f-b119170a58dd"), null, null, "Henriette.Collins96@yahoo.com", false, new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a") },
                    { new Guid("1412682e-0bed-40e0-bc37-6c17165d9129"), null, null, "Heidi.Hackett12@yahoo.com", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("1417e96e-100a-49f4-87fd-b56c28c4677a"), null, null, "Gust.Berge@hotmail.com", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("143ebeac-1659-4845-a11b-bea6a212e6b2"), null, null, "Sibyl.Wilderman@gmail.com", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("14425ad5-0200-4953-97e0-7e6dd9ef370d"), null, null, "Roberta_Walker52@gmail.com", false, new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a") },
                    { new Guid("1458e536-8430-4bb8-b0d0-75278040f18a"), null, null, "Cleo13@gmail.com", false, new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154") },
                    { new Guid("1483e4ed-de49-40d6-a4b5-caf10c001000"), null, null, "Bettie67@yahoo.com", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("14d58e54-0e49-4757-a8b6-b2cbe4987194"), null, null, "Zula85@yahoo.com", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("155bad5b-966e-4c24-b613-c6489cf51e6c"), null, null, "Wade_Keebler@hotmail.com", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("157ca67d-0802-49fe-93ac-1705ca3885b0"), null, null, "Krystal.Renner@hotmail.com", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("157ed770-12f5-4930-93ba-9f0b17a03889"), null, null, "Arnold81@hotmail.com", false, new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2") },
                    { new Guid("16136c8c-50bf-490e-970a-581e1917a268"), null, null, "Berneice_Friesen17@gmail.com", false, new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1") },
                    { new Guid("16fc400a-c59c-449c-801b-4299b316ca2d"), null, null, "Kali3@yahoo.com", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("178a02e7-baa6-440e-82ed-b3252f5fef94"), null, null, "Theodore91@gmail.com", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("1849622e-8515-43c3-9be8-95105cd6a553"), null, null, "Joy.Hackett79@hotmail.com", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("1878192b-4344-4792-8430-725e2ea7a243"), null, null, "Marisa.OHara@yahoo.com", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("19e376cf-cb3b-4625-9372-c3c6fd926702"), null, null, "Nicola66@gmail.com", false, new Guid("0f9851be-b682-479e-aec8-51795a73a90e") },
                    { new Guid("1a7d4420-0a4c-4bce-9bc2-a28f83c76512"), null, null, "Cristobal53@yahoo.com", false, new Guid("3e1827bb-2cfc-4263-be79-7b663816638e") },
                    { new Guid("1c72fc8d-d618-45d4-bc83-258b643f7dd8"), null, null, "Novella.Lynch@gmail.com", false, new Guid("53a7a51e-d382-4050-82a5-f33ab7641603") },
                    { new Guid("1c94e8f9-6266-4d76-8f1d-1f4b5a03870e"), null, null, "Felicita.Reichel85@yahoo.com", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("1c9e7607-2d73-41f2-9f75-92450c4ef875"), null, null, "Jerrod_Dietrich@hotmail.com", false, new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd") },
                    { new Guid("1cad318e-2f15-45e1-a655-549c47fd5d6e"), null, null, "Bennett_Jast@gmail.com", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("1cb19eac-7a3a-4846-923b-605c2e433cf6"), null, null, "Teresa5@hotmail.com", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("1d2efc6d-6006-450c-9b80-2a32ec1ceba7"), null, null, "Roger_Reynolds@hotmail.com", false, new Guid("527f7c3d-02b4-465e-8153-3472af913951") },
                    { new Guid("1d5af23d-8151-430f-b1b2-ddbfaeebe8a4"), null, null, "Velva.Renner77@hotmail.com", false, new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739") },
                    { new Guid("1e453410-4096-4e23-8b36-fe47318d8adc"), null, null, "Donny7@yahoo.com", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("1ee4044a-35d7-4f04-9bc6-445c983674bd"), null, null, "Natalie_Huel@yahoo.com", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("1f14abc8-a123-44d0-9f3b-04f68fe85220"), null, null, "Ibrahim33@hotmail.com", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("1fb2a8cc-7ce8-4d3f-a5e5-9cc414172416"), null, null, "Dameon_Carroll14@gmail.com", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("1fe631e2-b36d-41cf-9567-f56f9d6763ea"), null, null, "Terrill_Durgan@hotmail.com", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("207cb523-6284-45a7-9dbf-754d4ad2ba52"), null, null, "Jeremie72@hotmail.com", false, new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303") },
                    { new Guid("20bd0a46-4b6f-4dd7-be86-d2e4315480c6"), null, null, "Abelardo_Kautzer@hotmail.com", false, new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1") },
                    { new Guid("20f4667d-6888-4282-9624-7dde1d973a63"), null, null, "Imani.King@gmail.com", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("211a97e0-7916-4c42-b4eb-bbc4e87ce673"), null, null, "Brooke.Bruen36@gmail.com", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("214de7fc-b3a3-4061-bc37-cdf0310507c6"), null, null, "Veda.Ferry@gmail.com", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("225e906b-77e8-41ca-ab4a-4439b6f5b156"), null, null, "Audie_Terry@hotmail.com", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("22cd0ce8-25fa-4c04-a9b3-a983685eb460"), null, null, "Branson1@hotmail.com", false, new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a") },
                    { new Guid("22ce9d31-0c84-4573-89c4-df02521ecd7d"), null, null, "Derek_Larson@yahoo.com", false, new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8") },
                    { new Guid("232efc74-8ce3-4f90-9368-3039314566fa"), null, null, "Josh.Hartmann@gmail.com", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("238cda08-0ec3-483a-955d-278b777283c6"), null, null, "Abbie_Lesch@hotmail.com", false, new Guid("30b2066d-f465-42ae-93e3-4a38936052b2") },
                    { new Guid("246272ba-86b7-4fe5-8c25-cc9067da3e29"), null, null, "Demarcus.Reichert25@hotmail.com", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("24661197-27ea-4504-8b17-1d590c198073"), null, null, "Kayleigh2@yahoo.com", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("249cf8f2-66ba-450f-a0a9-11672636bc5e"), null, null, "Melany.Stoltenberg@gmail.com", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("24a3a5a8-5f2d-4abb-a6b9-1093da2aae54"), null, null, "Savanna.Bashirian@hotmail.com", false, new Guid("cc9fd67a-df81-4c57-9231-20a528617118") },
                    { new Guid("2560c2c5-5487-48bc-97e3-9724a6f87ed5"), null, null, "Dameon_Kuphal@hotmail.com", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("25b0e7f3-9213-44c5-b96b-341659b2f2d4"), null, null, "Dortha34@hotmail.com", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("25d28d67-b0d4-498c-be8c-e6b730ca55fa"), null, null, "Cornell_Treutel@yahoo.com", false, new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4") },
                    { new Guid("25d518dc-6197-4e2c-aa20-448330da096e"), null, null, "Casimir_Welch74@yahoo.com", false, new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("266beaf0-1d78-42df-b816-8e8b2025d0ce"), null, null, "Amie.Bashirian33@gmail.com", false, new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("26af3597-3cc1-44fb-9910-911c19a454a7"), null, null, "Alford93@yahoo.com", false, new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470") },
                    { new Guid("26d68357-b46e-45a9-bb0e-697ea25feb48"), null, null, "Bethel_Veum9@gmail.com", false, new Guid("99227d48-6d3f-45fd-971b-83f0198ee703") },
                    { new Guid("27007f0e-0abb-4ca5-a8d8-dbeaa1247636"), null, null, "Lenna_Bogisich17@gmail.com", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("27032c87-e36d-46ef-959e-64f0b96f8eb6"), null, null, "Louie11@hotmail.com", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("2733f016-d60e-46f9-96ea-e94203af0315"), null, null, "Marge_Wisoky@gmail.com", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("274e9918-293a-49d8-b845-e2ae43bdaa37"), null, null, "Pierce.Bergstrom@hotmail.com", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("2789c0f7-399e-4148-a546-91781cd53338"), null, null, "Thea_Gottlieb@gmail.com", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("27b19276-cb00-4245-82de-f877261ff318"), null, null, "Aliya_Terry66@hotmail.com", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("27c5d3d3-fab7-4449-ad3d-f0b5d5cfc87b"), null, null, "Roberta94@yahoo.com", false, new Guid("0f9851be-b682-479e-aec8-51795a73a90e") },
                    { new Guid("280a0a3f-7843-4804-9e23-28f2aa5139f5"), null, null, "Alda.Durgan@gmail.com", false, new Guid("52f24d75-fa03-403f-8430-5ca835f68726") },
                    { new Guid("28565b07-a950-437e-9b0e-aa0e44463e33"), null, null, "Joshua.Denesik@hotmail.com", false, new Guid("fb455a22-8198-413a-89a8-e92c01f42483") },
                    { new Guid("286d5359-df22-47fc-8ee3-b518207c4a51"), null, null, "Madisyn.Johnston@yahoo.com", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("28870a89-5299-425f-bc34-197eab18e971"), null, null, "Finn.Dibbert@yahoo.com", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("2904251e-9203-44e6-bdbf-91366ed5eea0"), null, null, "Audie_Kub13@yahoo.com", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("291d7a34-8d1c-4c02-bba9-e494c878ab7d"), null, null, "Jillian_Keeling58@hotmail.com", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("2921c1a0-a8fd-4d9d-aaee-9fb7b7228a79"), null, null, "Citlalli82@yahoo.com", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("2a2d218c-2fe7-484d-953d-a2bf6ee168ee"), null, null, "Laila.DAmore29@yahoo.com", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("2a71ec0f-79af-407a-8e01-bbc9c9aec6c6"), null, null, "Dedrick.Bogisich56@gmail.com", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("2a918aea-f216-4a3b-a2ec-98e300f8e831"), null, null, "Golda.Treutel@hotmail.com", false, new Guid("53a7a51e-d382-4050-82a5-f33ab7641603") },
                    { new Guid("2aa16a33-3ecb-441f-8efd-52a4e00acf02"), null, null, "Dashawn72@gmail.com", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("2ad21c2e-09d7-4199-bac7-12e0f4c15780"), null, null, "Agustin_Keeling@hotmail.com", false, new Guid("97fd604a-eb78-4e29-829c-caf68b162e92") },
                    { new Guid("2b4131be-15a5-4fb3-8f7e-7a56ad07d7da"), null, null, "Arnulfo.Schulist22@yahoo.com", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("2bd34f9a-95e0-4c77-a924-37e06e3ded0b"), null, null, "Lexus_Goodwin46@gmail.com", false, new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1") },
                    { new Guid("2bd7cd21-505d-4566-bf04-6ffce369ef53"), null, null, "Brooklyn_Hilpert@yahoo.com", false, new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec") },
                    { new Guid("2c23fbe6-5854-4ea5-b364-ad4aaa0f1225"), null, null, "Ozella53@yahoo.com", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("2c85eb2d-4a18-4a36-99ac-a63ec2a19906"), null, null, "Sadie47@yahoo.com", false, new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb") },
                    { new Guid("2cd08266-47ed-40ac-84fb-8acce91ea2fe"), null, null, "Ahmed34@gmail.com", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("2d2862d0-44c1-4e3b-b8cc-0600dff56e3b"), null, null, "Verda12@gmail.com", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("2d6ebd85-4ad1-466a-b395-580fbda40f6d"), null, null, "Rosalia86@gmail.com", false, new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7") },
                    { new Guid("2dd9905b-eb70-466b-80cd-3ddc131e1800"), null, null, "Titus_Fay@yahoo.com", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("2e25daa9-4ffa-4950-9de8-e8766d4ed2bf"), null, null, "Isaias30@gmail.com", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("2e48cd10-46dd-4043-971c-0ff580519527"), null, null, "Rafael.Harris53@hotmail.com", false, new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979") },
                    { new Guid("2ecb93a2-661e-4504-95a5-88fd40317eef"), null, null, "Aleen.Rippin68@hotmail.com", false, new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098") },
                    { new Guid("2ef38210-a674-460c-afff-493fb198b5ae"), null, null, "Geoffrey27@gmail.com", false, new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8") },
                    { new Guid("2ef534b0-fbc2-4f1b-9304-b80a1b0bc91f"), null, null, "Abner40@hotmail.com", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("2f3ee6c9-3868-4b62-ad79-94cc8d90c41d"), null, null, "Nigel3@yahoo.com", false, new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219") },
                    { new Guid("2f60bea3-b06a-4beb-9b87-37ac52ce3f4a"), null, null, "Shyanne19@gmail.com", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("2f8963d4-a755-4741-816b-28e286bcd4d0"), null, null, "Ted78@yahoo.com", false, new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379") },
                    { new Guid("30175927-af5e-490a-9984-224f6c5a4322"), null, null, "Marcus_Dooley@gmail.com", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("306da1ef-6b2d-4c16-a463-aef10c045276"), null, null, "Caesar73@gmail.com", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("306fbb67-2a11-491f-b51e-ecf39be11293"), null, null, "Lorena.Erdman@hotmail.com", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("30769740-4220-4ebf-a34b-cb71df9c110b"), null, null, "Lisa.Greenholt50@hotmail.com", false, new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6") },
                    { new Guid("309e729f-5ff9-4e27-9402-e2ff5811bcf1"), null, null, "Katrina.Cole@hotmail.com", false, new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731") },
                    { new Guid("30d2fcf8-cd95-41b4-8cf9-acef71a7d7ca"), null, null, "Maeve62@hotmail.com", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("311e3de4-b19d-49ae-a252-0b71a3581142"), null, null, "Barney.Bednar@yahoo.com", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("313186de-4088-42a9-8dc8-c1d675da5a60"), null, null, "Christophe45@yahoo.com", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("31d995c9-90a0-4b10-b762-32851493dec5"), null, null, "Jocelyn.Fahey@gmail.com", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("3202d01c-5328-4961-87e9-6181f0975564"), null, null, "Kory54@yahoo.com", false, new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748") },
                    { new Guid("320e08e0-0bb5-42c2-b320-98f275734b08"), null, null, "Desiree64@yahoo.com", false, new Guid("4f03daca-02fb-425a-a575-bef52173e4d3") },
                    { new Guid("32169448-1bcb-477b-a93c-dffe0aa775a0"), null, null, "Madisyn_Okuneva20@hotmail.com", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("326fa7e3-6f87-4810-a576-964d2bf8fb55"), null, null, "Francisca64@yahoo.com", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("32858d66-e8b9-498e-b996-a90549052e6c"), null, null, "Faustino_Steuber@yahoo.com", false, new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af") },
                    { new Guid("33af35c2-f3da-46eb-b447-2e58e8c1b02c"), null, null, "Stefan_Lebsack73@yahoo.com", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("345fe122-0a72-4e2c-9935-4c5539acc25b"), null, null, "Charlotte.Jenkins@hotmail.com", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("3512b785-fe61-4f5b-9685-74f51c9d193e"), null, null, "Kristopher_Feeney@gmail.com", false, new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500") },
                    { new Guid("354324f5-9069-466d-8995-4a301c66672e"), null, null, "Emilie.Considine@gmail.com", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("3577a11e-d512-4127-afe3-d69f727a7910"), null, null, "Leopold_Schinner60@gmail.com", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("35d1fdd4-5054-40dc-9d00-ec91cb9e551e"), null, null, "Shyanne_Roob2@gmail.com", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("35dcc604-efac-43f0-a6cd-5f62499bc341"), null, null, "Dayana65@gmail.com", false, new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f") },
                    { new Guid("3643ed6c-f0ac-4a15-a2d7-83374d1486f2"), null, null, "Emiliano.Langosh@gmail.com", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("368daa17-a2aa-45c4-b4bb-1fda69c3a738"), null, null, "Joshua69@yahoo.com", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("37b225f2-d74e-46a8-8f75-c4c96120e415"), null, null, "Simone_Stiedemann@yahoo.com", false, new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a") },
                    { new Guid("37bfbb87-ba08-4cb8-8995-03aa25e71545"), null, null, "Margaret42@hotmail.com", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("381bc519-5359-44e7-80c4-4e38bc6dacd6"), null, null, "Tomasa.Quitzon98@yahoo.com", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("38aa8ab9-9d5d-4bc8-87f5-44c24f1b996a"), null, null, "Sofia.Dietrich@gmail.com", false, new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14") },
                    { new Guid("38b737a5-2b25-43f3-aa70-62fee300e41d"), null, null, "Marian57@gmail.com", false, new Guid("6b524441-f464-4e08-8f72-3c7c650f6875") },
                    { new Guid("38d41a9f-c1f2-4fbf-a99a-9ab6a1c63060"), null, null, "Erin84@hotmail.com", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("39edd578-94a1-4b01-bd98-86422345cc0c"), null, null, "Joshua44@gmail.com", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("3a0445b8-ac37-4648-8c06-bb7ba714d129"), null, null, "Carlo.Walsh@yahoo.com", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("3a21faab-a826-49b6-af6c-43e2ce9ee41c"), null, null, "Breanne_Greenfelder37@yahoo.com", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("3ab7dc20-96e6-4a96-8570-6b433d9ced0f"), null, null, "Katelynn_Bartoletti85@gmail.com", false, new Guid("6b524441-f464-4e08-8f72-3c7c650f6875") },
                    { new Guid("3ae58c12-3352-4504-902b-785f0ffd61bc"), null, null, "Ophelia_Zemlak@yahoo.com", false, new Guid("8905b747-db92-42c9-8385-1d49f6b8e578") },
                    { new Guid("3af61bd7-136f-40a7-bc02-94336a5b42fc"), null, null, "Stone.Dibbert13@gmail.com", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("3af7ac9e-00f2-4c88-81bc-f693bacbbdf3"), null, null, "Carley61@hotmail.com", false, new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2") },
                    { new Guid("3b12d425-ce3a-46bb-a967-cb4695ffc5c8"), null, null, "Jessica_Connelly6@yahoo.com", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("3b41ca51-ecfd-4f3c-9adc-9c6835e18ce6"), null, null, "Edward.Wisoky55@gmail.com", false, new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a") },
                    { new Guid("3b5edf62-cde0-4ebf-994f-4531a9f78ba2"), null, null, "Chester_Turner2@hotmail.com", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("3c5736e8-3f8d-4f98-ba44-ce8850510d29"), null, null, "Anthony5@hotmail.com", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("3c72168b-6906-4d3f-86dd-d551d22b9b3b"), null, null, "Cali.Jenkins@yahoo.com", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("3cb0509a-e4e3-45c0-94be-0406172a8cb8"), null, null, "Mina12@yahoo.com", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("3ce58712-575b-4617-9593-f7e7af3673b7"), null, null, "Susanna_Larson@yahoo.com", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d07ded8-262f-4a44-8320-bb409d6a5abf"), null, null, "Rylee.Larkin@hotmail.com", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("3d18b903-0761-4c56-a7bd-7348181c79d0"), null, null, "Fausto58@gmail.com", false, new Guid("7573b136-e686-46e6-b0af-1186d8e37af1") },
                    { new Guid("3d2e2f4f-fa75-48cd-a440-2210596388e5"), null, null, "Guillermo.Rice@hotmail.com", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("3d30a160-2480-45df-be56-91803a271271"), null, null, "Marisa_Brekke@yahoo.com", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("3d362365-83f6-4c2e-8332-dd46cc0708da"), null, null, "Pierre_Windler84@yahoo.com", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("3d70f874-f1e2-4a4e-abe3-ac5df6af073c"), null, null, "Gayle.Robel90@gmail.com", false, new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0") },
                    { new Guid("3d849ce4-6d78-46a0-915b-eda421a180cb"), null, null, "Prince.Hauck@hotmail.com", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("3dc554bd-371f-4315-aa3e-dec71cd3c6d5"), null, null, "Krystal.Breitenberg25@yahoo.com", false, new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303") },
                    { new Guid("3df70680-73d4-45ad-84f2-ff3570d4d57a"), null, null, "Lesley.Mante64@hotmail.com", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("3e5a726f-6b8d-4bc9-9d1f-9f69264d58ed"), null, null, "Myrtle.Prosacco35@yahoo.com", false, new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5") },
                    { new Guid("3f41d55a-b225-4257-b542-93bcd094ea75"), null, null, "Demarcus.Reilly18@yahoo.com", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("3fa05bb9-ae7f-4f8f-8fa7-331b0cc29d6c"), null, null, "Dahlia.Ziemann73@gmail.com", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("3fae535a-134f-4c06-a8cd-26d172c26785"), null, null, "Elwyn_Gleichner80@hotmail.com", false, new Guid("3e1827bb-2cfc-4263-be79-7b663816638e") },
                    { new Guid("3fba67c9-6706-401e-bdd7-fec4b028123a"), null, null, "Marlene_Koch27@yahoo.com", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("3fc737cd-0d5d-47c2-bb45-1698b758a3a0"), null, null, "Mylene_Padberg@hotmail.com", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("405fb197-2aca-4dc9-b101-8a5c69139f98"), null, null, "Delpha_Hermann@gmail.com", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("4090d7fe-b961-4d8f-95d8-9208fd27480e"), null, null, "Armando_Pacocha33@yahoo.com", false, new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228") },
                    { new Guid("40a7a4f8-0b58-447f-9bb2-2d6d161825b4"), null, null, "Murl22@gmail.com", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("40ae04f7-e5eb-44e0-9a73-663cbb4c9755"), null, null, "Garland.Leffler74@yahoo.com", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("40c4699d-32a6-4430-898f-c36e41150aa5"), null, null, "Ardella68@hotmail.com", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("40e3a150-5843-4f43-b092-340e4dac1de2"), null, null, "Retta.West28@gmail.com", false, new Guid("77f944f9-c758-4983-b702-656640bf5672") },
                    { new Guid("428c7df1-b7e4-487d-822b-01113e2b50ef"), null, null, "Amari30@hotmail.com", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("4295cd6c-51ab-496b-af37-c045351fb4f6"), null, null, "Nickolas59@hotmail.com", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("42b3b39b-a332-4e3d-a4c8-2e90da7a0d78"), null, null, "Enos8@hotmail.com", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("43b3683e-ca5c-4d34-897f-52ed5eed591d"), null, null, "Tomasa.Satterfield59@hotmail.com", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("45bc6f35-76b2-4f9a-9372-79c82553901e"), null, null, "Sadye_Kerluke46@hotmail.com", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("4628bb72-4191-4c24-99d1-6407b11185af"), null, null, "Tom72@gmail.com", false, new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1") },
                    { new Guid("4632b2dd-78be-4cde-ac01-37e03bbeb9b8"), null, null, "Raina_Watsica@gmail.com", false, new Guid("08094f90-68b7-4576-a740-581a4878e4ab") },
                    { new Guid("46711010-fb0d-4ede-93fe-5ab167154e70"), null, null, "Garry83@gmail.com", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("46c38b4b-59d2-46ee-b0e0-ce8fec9d7744"), null, null, "Jean71@gmail.com", false, new Guid("ce1f07b6-54d9-4379-9845-3751b9499199") },
                    { new Guid("47944291-81cb-4b4d-b062-fcd8ba00979e"), null, null, "Arnaldo19@gmail.com", false, new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d") },
                    { new Guid("47b10e22-990c-4956-9317-99cb16218a69"), null, null, "Weston.Windler36@hotmail.com", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("482dda74-0777-4141-aaac-c409cf080639"), null, null, "Eli30@yahoo.com", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("488c4434-b36e-44d1-9632-ed6a6bc8ba1c"), null, null, "Jovani_Purdy60@yahoo.com", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("488e48df-8a3a-43d8-991e-b03a8d9048ac"), null, null, "Everette.Stracke@gmail.com", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("48d61408-d52f-45c2-8cb0-d28953346ae5"), null, null, "Linnea_Buckridge0@hotmail.com", false, new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") },
                    { new Guid("48efc972-2f48-4d3d-b834-6640137f006a"), null, null, "Christelle.Hauck@yahoo.com", false, new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd") },
                    { new Guid("48f121af-11f4-471e-82d9-5b169c633c46"), null, null, "Leonie52@gmail.com", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("48f195ad-517f-445d-9bf1-2bd5856e54ed"), null, null, "Kyle_Hartmann25@gmail.com", false, new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5") },
                    { new Guid("499ddd35-bee8-4404-b4f1-7e24efd6603e"), null, null, "Kirstin.Veum2@gmail.com", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("49bd097a-f0e2-46ab-a340-62f3c8b44e9b"), null, null, "Reba_Halvorson@yahoo.com", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("49bda779-278d-4a77-a795-b58476df8d5e"), null, null, "Hiram27@yahoo.com", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("49d0ac58-9160-4115-8f8f-08ae86137fe4"), null, null, "Luz.Collier@yahoo.com", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("4a2c131f-9c9e-485b-aaee-724acc9c4875"), null, null, "Addison_Heathcote5@hotmail.com", false, new Guid("1154048c-cc8b-409f-a802-5dbe51d20548") },
                    { new Guid("4a31b8a7-e1ca-43ce-8e07-9046772daeb3"), null, null, "Jovanny_Lueilwitz27@gmail.com", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("4a9dc6b0-6083-48be-a796-82d1d0ae5363"), null, null, "Hugh.Trantow3@yahoo.com", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("4aa02cf3-0db8-42f4-a24e-3f8df6f76e48"), null, null, "Bernard59@hotmail.com", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("4b087d5c-c4ac-4422-9ef6-0581b00b8996"), null, null, "Andreanne.Dickinson88@yahoo.com", false, new Guid("816326af-094b-4b97-b10b-548a2296766b") },
                    { new Guid("4b232136-e29c-4f4a-a2ac-8e7e57f15f04"), null, null, "Quincy60@yahoo.com", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("4b40933f-d9e6-4800-a729-13a3948b0cf5"), null, null, "Grant13@hotmail.com", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("4b4c3877-d07f-4c35-b2df-da2a0a2516b0"), null, null, "Schuyler66@gmail.com", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("4b88799a-6c12-41eb-9fd6-781f01a2f1d1"), null, null, "Rosa_McGlynn@gmail.com", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("4c00a027-ab32-41a6-a822-bcd9da4c21bd"), null, null, "Katrine.Hayes@gmail.com", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("4c65121b-ba77-4074-83cd-78aadd313323"), null, null, "Remington_Thiel2@yahoo.com", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("4d644720-3f4d-4ba2-ae12-e6c1b29d0c41"), null, null, "Paula_Ziemann27@gmail.com", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("4d8514d5-a39d-4ed2-acc9-becc1f3a4797"), null, null, "Lessie_Paucek75@hotmail.com", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("4dc573e0-27ab-4b0c-bd72-0081401d08b5"), null, null, "Eunice_Kessler98@gmail.com", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("4e0bd867-7ddd-4e54-8e72-a64ac5edabba"), null, null, "Maryjane.Wuckert9@hotmail.com", false, new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae") },
                    { new Guid("4e2b74ac-0f57-423e-bc40-e9ddfea41790"), null, null, "Misael_Bernhard33@yahoo.com", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("4e47056d-f214-4ecf-bb4d-559c7f044d47"), null, null, "Jules_Luettgen30@gmail.com", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("4f1dd623-5dc0-461a-8632-609ac74804ae"), null, null, "Helga26@hotmail.com", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("4f3ad694-b008-4fa5-ac51-09ccd908d4a8"), null, null, "Horacio.Waters@gmail.com", false, new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f") },
                    { new Guid("4f7812a3-3fd5-4b3c-b643-fc5ec699d16b"), null, null, "Jena_Tremblay65@yahoo.com", false, new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf") },
                    { new Guid("4fe96e32-5a8f-4fee-baf4-1340a81df5ac"), null, null, "Tyrel_Marquardt@gmail.com", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("507820cd-82a1-4151-85ed-0f340aaba4a2"), null, null, "Hanna_Spencer@yahoo.com", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("5089e760-dde1-4513-8589-0cda4b9a51d4"), null, null, "Clarissa_Gottlieb@yahoo.com", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("50ac0457-7eec-4f80-8f3b-d9fcb109b154"), null, null, "Jessika_Krajcik@gmail.com", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("50b88ebe-1fb2-4171-90a9-53f5e346979d"), null, null, "Madaline50@gmail.com", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("50d66ed0-b099-4ec4-8cb6-66f9b8c7edd1"), null, null, "Novella.Jakubowski79@hotmail.com", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("519cbbf4-4c2b-4a71-b65d-1e685f34e2f5"), null, null, "Peggie.Ankunding@gmail.com", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("5208541b-1256-47f3-b254-0fe510d5a5ba"), null, null, "Lesley83@gmail.com", false, new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("526d4c85-10a4-428e-b1e6-ff635739d667"), null, null, "Katheryn10@hotmail.com", false, new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef") },
                    { new Guid("52c4c380-ebfa-4dd7-85bf-3564947b2baa"), null, null, "Niko_Turcotte@gmail.com", false, new Guid("30b2066d-f465-42ae-93e3-4a38936052b2") },
                    { new Guid("53184f88-a5c7-44a8-88b9-430322db415b"), null, null, "Rahsaan_Huel@hotmail.com", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("5346c1f7-6f36-4e3f-ad9d-e868c647f878"), null, null, "Guy_Osinski@gmail.com", false, new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec") },
                    { new Guid("537b5482-08f2-4d0e-b611-d9cecaeb1de4"), null, null, "Domenic_Kautzer@gmail.com", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("537dac3f-58e1-4c3d-83cc-7bcac4231830"), null, null, "Jewel30@yahoo.com", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("53bd684b-dbbb-4abc-b9af-08aab98e47ff"), null, null, "Jonas.Raynor@yahoo.com", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("542ddf59-6a18-43a5-b10b-a33758459b6b"), null, null, "Christopher81@yahoo.com", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("542e24ef-515a-4560-bf09-c94edb5da319"), null, null, "Eladio_Jaskolski@gmail.com", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("5477c46c-8b85-41eb-8789-9ddeab561114"), null, null, "Harmon72@yahoo.com", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("5493c6c0-e9bd-4944-9c50-c9be98a566bc"), null, null, "Lisette61@gmail.com", false, new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4") },
                    { new Guid("54c88eba-14d2-43c0-abbb-48904bc419e9"), null, null, "Toney4@gmail.com", false, new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73") },
                    { new Guid("55c6a290-1817-4b2a-9ad6-ff5a485efade"), null, null, "Chet_Gleason30@gmail.com", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("55f03f38-f229-4ad4-bf1b-f4fdad62350c"), null, null, "Lew.Carroll17@hotmail.com", false, new Guid("4fde002a-ab64-405c-bb95-313bef89420b") },
                    { new Guid("56c0bdb3-3080-4537-b297-3ce88116b29d"), null, null, "Arden.Barton@yahoo.com", false, new Guid("fb455a22-8198-413a-89a8-e92c01f42483") },
                    { new Guid("56e0f348-d2b3-4246-bde9-b53ee0793772"), null, null, "Margot.Smith@gmail.com", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("56fd11f4-ed81-4962-ac0f-1fdf6ac32fdd"), null, null, "Tomas12@hotmail.com", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("57203052-d7db-4a58-b303-35be770305a7"), null, null, "Jade_Feeney71@yahoo.com", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("57d8c362-8797-4b22-a1f3-b78ce21af57d"), null, null, "Sanford18@yahoo.com", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("57ed89fa-4e31-4fba-9966-e41c674fd05b"), null, null, "Reese93@yahoo.com", false, new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6") },
                    { new Guid("58331663-4d8f-4450-952e-f54923fde22f"), null, null, "Marian_McLaughlin7@gmail.com", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("58814e74-fcc8-4a2e-be32-e0b40be70447"), null, null, "Raul.Dibbert@hotmail.com", false, new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc") },
                    { new Guid("58bcf418-ba6b-4b1e-a688-4ebb33009215"), null, null, "Anahi.Beatty@yahoo.com", false, new Guid("8461c967-9f1c-48cc-85ae-66b9741be768") },
                    { new Guid("58f9f40b-0ad7-4e42-90fc-2bd8ac69e35e"), null, null, "Wilfredo_Treutel@hotmail.com", false, new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee") },
                    { new Guid("5993e21e-1b87-45ee-a139-206c14089514"), null, null, "Elisabeth67@gmail.com", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("59aef908-21d9-40b4-927f-2c6d74c37721"), null, null, "Natasha_Romaguera1@gmail.com", false, new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379") },
                    { new Guid("5a1ff7cd-665c-4bde-810e-2e36693d5d0e"), null, null, "Lloyd_DuBuque77@hotmail.com", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("5a8f723d-1046-4539-af79-a9fac44003e5"), null, null, "Jennings83@hotmail.com", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("5b7dc3f0-94a7-4023-8fe3-19d3d48924e2"), null, null, "Joey_Ankunding@hotmail.com", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("5b9aa860-c932-4358-ae90-927203e79362"), null, null, "Samir.Osinski@hotmail.com", false, new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("5bceb60b-d088-41e0-a0de-fbba6ca37335"), null, null, "Vickie.Greenfelder@hotmail.com", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("5be0ff21-a353-4d9c-9532-cab9eae713c8"), null, null, "Pamela11@yahoo.com", false, new Guid("862a826f-0eba-4891-9241-dff3a8896969") },
                    { new Guid("5c08b695-7cd4-4726-b8b4-7e25df6bc5c1"), null, null, "Krystel.Heathcote22@hotmail.com", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("5c2995d0-3a43-4b20-a140-adc2ed350919"), null, null, "Benny.Koepp4@gmail.com", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("5c63c72a-605d-42d7-9e9b-e2405ef56802"), null, null, "Marquise_Stracke@gmail.com", false, new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8") },
                    { new Guid("5ca29929-55c2-42d0-958b-ab4031d23413"), null, null, "Rowena_Bartoletti@hotmail.com", false, new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64") },
                    { new Guid("5cbbde1d-209e-4ceb-9180-a0e6c227281e"), null, null, "Lorenz_Hills@yahoo.com", false, new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf") },
                    { new Guid("5cedaef1-406d-46d2-9bf5-14528980bcef"), null, null, "Zechariah.Bosco@hotmail.com", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("5d22661c-a753-42e0-a20b-775ae895cdbb"), null, null, "Winifred_Ortiz@gmail.com", false, new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5") },
                    { new Guid("5d48ad03-5697-40ae-8164-d13be165462a"), null, null, "Kristoffer73@gmail.com", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("5d7112f9-b2e2-4ee0-9ebc-7b5ae31c2946"), null, null, "Willa58@hotmail.com", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("5daecaa2-5d54-4dc0-a4ff-146e15747082"), null, null, "Domenick_Hahn87@yahoo.com", false, new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614") },
                    { new Guid("5ebdec64-2d8b-423c-b551-48000963ed4c"), null, null, "Jesus72@gmail.com", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("5ed113ad-2fea-44ff-91e6-3c82a1b136db"), null, null, "Trent5@gmail.com", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("5f03a9cc-61ea-4cea-860f-a0483f37dfd3"), null, null, "Emily47@gmail.com", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("5f4a6972-ef11-4284-a759-56b980df7c4c"), null, null, "Jayme_Stracke@gmail.com", false, new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1") },
                    { new Guid("5fa9bb8f-3d65-49ee-88e4-4dc6b0103710"), null, null, "Eunice_Douglas89@yahoo.com", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("5fd86007-8d5f-4050-90cb-3a3c06938a0e"), null, null, "Teresa72@yahoo.com", false, new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353") },
                    { new Guid("5ff1ca14-0766-4761-9f2f-743671ec07d7"), null, null, "Lydia58@hotmail.com", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("5ff9a0cc-c3f4-4f58-a4e6-d87abbbd730c"), null, null, "Gunnar.Mann24@yahoo.com", false, new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592") },
                    { new Guid("601f66ee-c1a7-452d-8113-16d13b703f68"), null, null, "Carmelo50@hotmail.com", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("60387173-6eb4-4fa3-bece-087bf7d7372b"), null, null, "Larissa.Kshlerin@gmail.com", false, new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") },
                    { new Guid("606dc8c7-106c-41cd-bd4b-82d89265e143"), null, null, "Orie.Lynch@hotmail.com", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("6072ce25-8741-46ae-83c3-59b2e0e5051b"), null, null, "Sebastian.Schowalter@hotmail.com", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("60c8fa44-da82-4893-ae20-1b0d95be5edd"), null, null, "Rosamond_Goyette@yahoo.com", false, new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("60fe80c2-c5f3-4b3c-847d-634224a67360"), null, null, "Kianna.Harris@hotmail.com", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("6100c9fc-dfb4-413e-8f19-164e6de8c244"), null, null, "Sylvia_Mitchell@yahoo.com", false, new Guid("f0811698-5de9-42a6-a253-8958ca513eb5") },
                    { new Guid("612e7952-b982-4b85-b92b-6ee095210734"), null, null, "Hayley91@gmail.com", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("6156b898-8466-49c4-948d-ecd2be250f45"), null, null, "Efrain10@yahoo.com", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("615b4c85-0df2-4a82-86c3-977fb222e0b3"), null, null, "Vincenzo_Skiles95@hotmail.com", false, new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("61a6aec0-8cc5-4df7-a45a-f677e2427a0a"), null, null, "Omari.Vandervort78@hotmail.com", false, new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("61dfec66-4e3a-4bc9-b7b3-e22109349dd3"), null, null, "Serenity.Beier@gmail.com", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("61e4c08f-dd3e-45b2-bdeb-338af883394b"), null, null, "Romaine.Ratke23@hotmail.com", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("620687f4-ae06-41c5-92ff-8a4bcc2784f3"), null, null, "Nia10@yahoo.com", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("62449e1d-44d5-40a8-9cfa-d81382156e38"), null, null, "Jairo42@gmail.com", false, new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26") },
                    { new Guid("62e97dd9-9304-4b44-91f6-843fdb468c7b"), null, null, "Consuelo97@hotmail.com", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("637e3254-b2ff-4730-9935-9d7397933484"), null, null, "Arnoldo_Nienow90@hotmail.com", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("638fdcc9-6727-4000-a9d0-117629a447bb"), null, null, "Jerrold_Kuhlman@yahoo.com", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") },
                    { new Guid("63d91b84-4882-4408-92a7-4b0dcd3452c0"), null, null, "Forrest.Schuster@gmail.com", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("6464a1a9-7f32-48c0-8530-2d19cc0fa3be"), null, null, "Bryce_Swaniawski35@gmail.com", false, new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760") },
                    { new Guid("64654185-c47c-4a2a-b012-40852aaa5751"), null, null, "Pedro24@yahoo.com", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("649680d5-21df-459e-a0f1-4b0935785374"), null, null, "Eveline.Graham@yahoo.com", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("65dd6035-feb0-4d2b-9665-c1c01344b64a"), null, null, "Danyka_Ankunding@yahoo.com", false, new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26") },
                    { new Guid("65f6e6b2-b33e-455f-96e9-ceabee61b77f"), null, null, "Garret_Weissnat@gmail.com", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("66bc1823-4309-4cc4-8f86-17a71143f532"), null, null, "Brigitte.Hintz@gmail.com", false, new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e") },
                    { new Guid("66c090c6-7998-4d8e-a10a-6189623213ab"), null, null, "Guy.Harvey@hotmail.com", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("6712ef6d-c584-43f7-ba94-045910421767"), null, null, "Tillman.Runte@yahoo.com", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("67484e58-bbc9-42bc-a41b-b5bca15979c3"), null, null, "Ken75@gmail.com", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("678bf30d-7339-4642-ab12-2781f67dceeb"), null, null, "Cheyanne10@yahoo.com", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("67efefd4-ccb6-40c7-8665-d52ca27dc4ad"), null, null, "Enos76@hotmail.com", false, new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b") },
                    { new Guid("684b3b8f-4370-4b43-8040-278f964b30d9"), null, null, "Roderick0@yahoo.com", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("68b0c231-4700-4bfa-adca-0888fab69657"), null, null, "Hannah3@hotmail.com", false, new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c") },
                    { new Guid("68b99286-595e-4595-b415-1cfef4f00ed6"), null, null, "Brent.Wuckert@yahoo.com", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("6985a4a5-d677-4249-aa46-6d6336e00091"), null, null, "Kale.Rau@hotmail.com", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("69b9ffb4-1e8d-4b9a-a7bc-2374a8aea71d"), null, null, "Nyasia77@gmail.com", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("69d205f8-8554-43d4-be76-7b212ed2ce32"), null, null, "Yesenia_Larkin@gmail.com", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("6a4b3fed-3bd2-47fb-a2e7-37177e73f42a"), null, null, "Zachary72@yahoo.com", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("6a696e90-a764-4ad9-9a07-986d696b1b03"), null, null, "Estell86@gmail.com", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("6a6db5d4-006f-4596-9df7-97ade08c7c88"), null, null, "Nicklaus.Beer@hotmail.com", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("6a7871b3-b336-4af4-8e1a-a02bf6c699d9"), null, null, "Jodie85@hotmail.com", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("6ac9d90c-3d57-4840-a59e-48155f8b8a87"), null, null, "Friedrich_Wiegand90@yahoo.com", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("6aca2524-cc1c-42a0-b82b-b5e46075debf"), null, null, "Aida89@hotmail.com", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("6b15c206-b62d-4406-a528-461e0b91b3c1"), null, null, "Vicente_Lueilwitz1@yahoo.com", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("6b27494d-ee2e-41d0-8127-25de5d9a9943"), null, null, "Forrest13@hotmail.com", false, new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9") },
                    { new Guid("6b36272f-48fc-4379-b8f2-d50d9259d8b8"), null, null, "Madilyn27@yahoo.com", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("6b3ccc8c-9fd4-456d-9168-9f5587e903c9"), null, null, "Ted15@hotmail.com", false, new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64") },
                    { new Guid("6c434f6c-8acf-4a68-b258-48592dbd63ae"), null, null, "Letha62@gmail.com", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6c879dec-7636-42da-8338-a98b169ac6ea"), null, null, "Clair11@gmail.com", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("6ccf7b63-be87-48ef-82e6-4cd8a83dccba"), null, null, "Salvatore.Dickens58@hotmail.com", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("6ce6e34b-999c-4905-ab79-2b9111127c37"), null, null, "Tara_Howell@hotmail.com", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("6d027860-2345-4e67-b342-b5c137e041e7"), null, null, "Cayla_Kerluke@gmail.com", false, new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14") },
                    { new Guid("6d1dd072-e2a0-41ce-9839-a152f8b2b681"), null, null, "Brianne5@hotmail.com", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("6d96170b-80dd-42a0-992d-d15258266702"), null, null, "Fae89@hotmail.com", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("6de53f75-ad57-4f10-8305-624677c365c9"), null, null, "Makenna48@gmail.com", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("6ec9b316-ca29-4267-a9e5-933119c9217b"), null, null, "Rogers.OKeefe@gmail.com", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("6ecb3c0c-8e92-4aa3-80f2-37d77d3813eb"), null, null, "Maiya_Reinger65@hotmail.com", false, new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc") },
                    { new Guid("6f52d5ed-fdca-49f1-92d7-bb168abc392b"), null, null, "Reece_Hand@yahoo.com", false, new Guid("4f03daca-02fb-425a-a575-bef52173e4d3") },
                    { new Guid("6f96d928-50a8-4fdf-9ec6-bb30d6cdb8be"), null, null, "Alvena_Hand@yahoo.com", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("6fe88438-a5e0-41e3-ac7c-ac8aefae02d7"), null, null, "Cordelia81@yahoo.com", false, new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2") },
                    { new Guid("7016fe91-71c8-4d45-96ea-72e68d3e2d50"), null, null, "Antonietta76@hotmail.com", false, new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca") },
                    { new Guid("70765952-cd47-4413-9e12-36dfd1815d16"), null, null, "Hunter_Bruen60@gmail.com", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("70c1d0a5-0bde-4ec8-b619-74999badd059"), null, null, "Frances62@gmail.com", false, new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("71090210-231a-4adf-91a0-71ae47772d60"), null, null, "Gavin_Howe98@yahoo.com", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("71b9e887-8000-49eb-90e1-ddb991e8af20"), null, null, "Corene.Metz@yahoo.com", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("726bb37c-a444-4ec6-a938-08a873847daa"), null, null, "Jalyn.Braun55@hotmail.com", false, new Guid("617100a1-d830-4170-9964-86b27fc31a31") },
                    { new Guid("72fb6f3b-6e14-455f-a8a4-d2b4a49211e7"), null, null, "Jevon.Lubowitz13@yahoo.com", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("731c528e-934c-4d55-a5a6-88d0f3bf78f4"), null, null, "Neva.Kemmer@hotmail.com", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("733cd772-f6b8-4458-8a3c-b8c4a048ddf8"), null, null, "Avis57@yahoo.com", false, new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("73472991-15cf-4dbf-be36-151df630333a"), null, null, "Hal_Gerhold27@yahoo.com", false, new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5") },
                    { new Guid("73805798-6490-4a76-87da-78a1d6a11483"), null, null, "Autumn_Bednar@hotmail.com", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("73d500c5-3584-43ad-8a6c-f540b5f1b70d"), null, null, "America38@hotmail.com", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("740994ed-9989-4e43-8e91-ae5bd0503004"), null, null, "Lenny.Bergstrom34@gmail.com", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("755f0128-75db-4814-b522-8f0ab1287ad9"), null, null, "Casimir30@gmail.com", false, new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b") },
                    { new Guid("75d793dd-a972-4b67-b3b4-86478a7f3347"), null, null, "Stuart75@yahoo.com", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("760decea-c1a9-4137-8af3-7a7ab050756c"), null, null, "Berry_Nienow@yahoo.com", false, new Guid("52f24d75-fa03-403f-8430-5ca835f68726") },
                    { new Guid("7640d3cb-63b4-4e62-86e7-0234b46539b9"), null, null, "Carmine73@gmail.com", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("76c38171-1c3b-46db-8263-cf1f1014de3e"), null, null, "Timmothy_Bednar64@gmail.com", false, new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6") },
                    { new Guid("7748be4c-efdd-49bf-8322-ed23c929e9cc"), null, null, "Tremayne.Ortiz54@gmail.com", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("774d2bdb-4ecc-4938-a48a-f5f2a0a71c7e"), null, null, "Clyde46@yahoo.com", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("77525460-7af2-4e78-990a-3ea175ff21b3"), null, null, "Ryley_Murray@yahoo.com", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("77746fc8-a8c4-44f3-93c9-fdaf9b0d25b3"), null, null, "Winston.Schultz98@gmail.com", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("78580e6b-751e-4bc9-9b80-158996a45915"), null, null, "Abelardo35@yahoo.com", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("78d58f7d-8a06-434b-a6e4-676f7802b0a9"), null, null, "Odie.Shanahan@yahoo.com", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("78e56c50-ce40-42a3-a421-44267ce9d1b4"), null, null, "Pearlie45@yahoo.com", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("7914bb2a-25b3-4b5d-9665-1155d30cc7b1"), null, null, "Ardith_Donnelly16@hotmail.com", false, new Guid("43a79d17-6c7f-4919-8fc7-806f34234239") },
                    { new Guid("79df787c-e3cf-44cf-a6db-ed02d70a249f"), null, null, "Macie_Bergstrom27@yahoo.com", false, new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c") },
                    { new Guid("7a0ab3f0-a08f-42c0-bf39-f05aefeca438"), null, null, "Jacklyn83@yahoo.com", false, new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9") },
                    { new Guid("7aacd8dc-619c-49b2-b6a0-9d55db03fa8c"), null, null, "Crystal_Hills1@gmail.com", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("7abaab58-6102-4b55-a8f9-41b9c0d19bee"), null, null, "Josie96@gmail.com", false, new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7b08d0d6-933b-4202-8108-f6d4ca7b5b1d"), null, null, "Pearlie.Mitchell15@yahoo.com", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("7b0c0cee-9f55-4815-a9ee-67695112c388"), null, null, "Domingo.Hansen@hotmail.com", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("7b915d98-a573-4f0c-a674-084d55a8db9e"), null, null, "Lance61@gmail.com", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("7ba7b54b-236a-4751-9f01-de347834a74f"), null, null, "Trace_Ledner@hotmail.com", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("7be58ece-1d97-4ae6-ac28-231fe20a124e"), null, null, "Nathaniel_Bednar60@hotmail.com", false, new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1") },
                    { new Guid("7c9f7fce-1447-4e3f-848d-fa642a516a4e"), null, null, "Forest.Olson29@yahoo.com", false, new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b") },
                    { new Guid("7cb778b5-0c7c-49db-a18a-e89e3ec74318"), null, null, "Dora.Fahey@gmail.com", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("7ccf4804-472d-49b8-a186-19fa8ea9deb3"), null, null, "Autumn.Larson@hotmail.com", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("7d5207ab-b5e6-4bac-8b74-fe57d6fbe74b"), null, null, "Reid.Friesen@hotmail.com", false, new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4") },
                    { new Guid("7dc39e2b-3d45-4b71-9036-eb4ab811ea46"), null, null, "Kacey.Greenfelder82@yahoo.com", false, new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1") },
                    { new Guid("7df48e48-795e-4c97-a562-2096828f7d0a"), null, null, "Elyssa18@gmail.com", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("7e0bea88-cab8-4750-8e36-18447f97058e"), null, null, "Earl.Emmerich13@hotmail.com", false, new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117") },
                    { new Guid("7fb999b8-f6be-4fa0-b778-19e673b84d82"), null, null, "Golda.Schamberger@yahoo.com", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("802663b5-e115-4961-84a9-7c52b293e046"), null, null, "Elias.Hessel29@hotmail.com", false, new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04") },
                    { new Guid("809055a5-cdc1-4b98-b299-76df7c6df42d"), null, null, "Ewell63@hotmail.com", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("80be8c43-18c4-492b-bd7f-91e1f61ea8f1"), null, null, "Aubrey_Borer26@gmail.com", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("80cf14e7-0e75-46a4-92ac-1b239022d514"), null, null, "Kamryn.Romaguera@hotmail.com", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("811c4c40-daf2-4178-a1a5-bf81235bd5d7"), null, null, "Emelie_OHara@hotmail.com", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("81234f67-5530-4bfc-a921-43d0e8f3ebc0"), null, null, "Jaida_Hane61@hotmail.com", false, new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353") },
                    { new Guid("8183392e-56da-4ced-a755-9d3d8466722b"), null, null, "Allie.Erdman70@gmail.com", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("827373b9-de3a-4ed1-96ae-350af0f74257"), null, null, "Keshawn.Sanford@gmail.com", false, new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6") },
                    { new Guid("8388e5b0-3a0d-4555-8c0c-2a6fc34f0251"), null, null, "Bobbie50@gmail.com", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("8395387b-0f9b-4088-9c92-6e5bc1302070"), null, null, "Hilton.Greenfelder@hotmail.com", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("844d1f0b-23bb-4933-bd04-041bc3660aa1"), null, null, "Clair.Fisher@gmail.com", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("849b8ca3-08be-4991-a970-4f9ac6ac07bb"), null, null, "Janis.Harris54@gmail.com", false, new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7") },
                    { new Guid("84f7d60d-fd75-447c-ae61-cf0ddd85eec6"), null, null, "Isabell_Williamson@hotmail.com", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("851cedbc-6246-4891-8dc3-bb4c019696a1"), null, null, "Schuyler26@hotmail.com", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("8524cc68-9d94-4694-894e-315151d72858"), null, null, "Sadie.Reilly@hotmail.com", false, new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("8560d006-d217-4a5f-b7d5-557b251b20db"), null, null, "Rose_Feest@yahoo.com", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("85c0d388-71dd-4065-9b2e-7f5edd07360b"), null, null, "Gussie_Adams14@gmail.com", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("85d60dda-c4b4-4936-b925-bdf8eb9bb2d4"), null, null, "Casandra_Wisoky6@gmail.com", false, new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56") },
                    { new Guid("85ed6337-b007-4958-8735-69ebd078c068"), null, null, "Pinkie.Kuhic@yahoo.com", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("8616099b-5849-4f8e-8269-78c381b313ca"), null, null, "Casper9@hotmail.com", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("863b1cf1-a79b-48df-b080-bec692c8d720"), null, null, "Alva.Wintheiser57@gmail.com", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("869be4e0-50d0-404c-9a56-7ec1b11b69e4"), null, null, "Beatrice_Hermiston@gmail.com", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("87300be8-067f-4fe0-bd5a-7146ebd43461"), null, null, "Malika_Satterfield@gmail.com", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("87366af3-98b0-47b8-b58b-169e5e8fffed"), null, null, "Michale_Wilkinson@hotmail.com", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("8740a632-6b28-407c-a9c4-93fb61092016"), null, null, "Zelda_Kutch@yahoo.com", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("87609a20-2b1e-43db-93e1-950ea9160bb1"), null, null, "Linnie91@yahoo.com", false, new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6") },
                    { new Guid("876f3133-3c00-40da-9ec0-d3e6ed28dda2"), null, null, "Golden.Vandervort@gmail.com", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("87d2ac1b-ecc0-46f7-835a-e4f947172f54"), null, null, "Dayana.Kshlerin99@gmail.com", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("8806e673-6033-4a7c-b87f-a109765c4155"), null, null, "Rudolph_Harris79@gmail.com", false, new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("88b7b989-e8b4-4e4d-adce-0b47c02677ea"), null, null, "Brigitte.Bednar71@gmail.com", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("8996e3fb-9013-4420-abb0-72d1ca1452ef"), null, null, "Kelsi.Hickle@gmail.com", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("8a37f48c-fec1-4714-97cc-069a548e496e"), null, null, "Elody_Casper@gmail.com", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("8a40db25-ff82-4995-b825-438a9c1766c2"), null, null, "Nathen.Feeney@gmail.com", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("8aa94210-7429-45f0-8553-255add9fa332"), null, null, "Gunnar31@hotmail.com", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("8aee0011-92f3-43b4-b523-8ea348073ed2"), null, null, "Armando_OConnell@gmail.com", false, new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614") },
                    { new Guid("8af71ba7-0f6d-492d-8699-70f67092bc18"), null, null, "Branson37@yahoo.com", false, new Guid("527f7c3d-02b4-465e-8153-3472af913951") },
                    { new Guid("8b24e7a8-361a-4e42-9d0d-a1956a32bb40"), null, null, "Oscar.Rippin@gmail.com", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("8b53e96c-9ef7-4f29-8147-604d8a7fc120"), null, null, "Claudie.Yundt61@hotmail.com", false, new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a") },
                    { new Guid("8b85af69-f11a-4229-8d0d-04f97915d44f"), null, null, "Hope.Kovacek65@gmail.com", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("8c897ac8-0b69-4d67-abd5-3b67f78e8afb"), null, null, "Pamela70@hotmail.com", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("8d66abc3-4efc-434d-a16c-d44e99b55bd7"), null, null, "Cleve_Block14@gmail.com", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") },
                    { new Guid("8d79cc3a-dd46-4490-8b82-0f13673e5c72"), null, null, "Gaston.VonRueden18@hotmail.com", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("8de3823f-20d2-4f37-b08e-8d2a7d47fe58"), null, null, "Merl.Marquardt@gmail.com", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("8e0c25dd-ae13-42dc-b2ae-7bbc972dda18"), null, null, "Clarissa_Dach@gmail.com", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("8e1625b4-e68a-43c8-8301-7f6c44a34447"), null, null, "Arno58@hotmail.com", false, new Guid("ce1f07b6-54d9-4379-9845-3751b9499199") },
                    { new Guid("8e30852f-e772-4f11-a71a-45adb2beeab7"), null, null, "Annie.Stracke@hotmail.com", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("8e3bb7d3-e550-4020-b9b5-f231e99cf769"), null, null, "Leila.Thiel76@gmail.com", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("8e91a788-106f-47eb-a2b9-71e1ec0f821c"), null, null, "Kevin_Bayer69@gmail.com", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("8eeaafad-6c7b-4f87-b8c6-213ea774a344"), null, null, "Myra38@hotmail.com", false, new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063") },
                    { new Guid("8f2faadc-d019-4c2c-a4c0-3e94965aebdc"), null, null, "Luisa_Huels38@gmail.com", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("8f611f8b-96a7-4b66-9fa9-a1c2ec95b722"), null, null, "Estelle32@yahoo.com", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("903b0381-fe68-4929-aa90-5eceda74f9e7"), null, null, "Lonny68@gmail.com", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("9060d6e2-5518-44b0-a171-59ae7cae394f"), null, null, "Flossie.Fahey23@yahoo.com", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("90dc3e22-01bb-4cc0-b18b-4aea21ce00c1"), null, null, "Brielle.Gaylord@yahoo.com", false, new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8") },
                    { new Guid("90ec428c-89ea-49a2-a167-8ee1065288a9"), null, null, "Darien.Sawayn45@yahoo.com", false, new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8") },
                    { new Guid("91445b12-e273-494c-bfc8-97c77f04f35a"), null, null, "Granville.Koelpin@hotmail.com", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("91a099ba-b31b-4b84-bc87-29a222c62ceb"), null, null, "Rita58@yahoo.com", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("91b27afe-e1a7-4aae-b4f6-6e0a82bd208e"), null, null, "Felicia90@gmail.com", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("91da8b51-f041-4d36-99d4-51c048647f14"), null, null, "Greyson_Stanton53@yahoo.com", false, new Guid("4fde002a-ab64-405c-bb95-313bef89420b") },
                    { new Guid("928a75ac-2226-45a1-a9ea-d689a690d41b"), null, null, "Alicia.Purdy@yahoo.com", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("933da0eb-a2ee-46dc-a945-5a03fe29a6e8"), null, null, "Antonina_Wyman44@hotmail.com", false, new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45") },
                    { new Guid("93480bc8-09fa-4d46-9a8b-ae26745532ef"), null, null, "Daisha_Wilkinson46@gmail.com", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("93bb142a-4f05-4b62-a50c-19ece0dbcc42"), null, null, "Jody.Hilpert72@hotmail.com", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("93c74c3f-ef5a-462d-8fc9-8b7dffb98117"), null, null, "Casimer_Dare@hotmail.com", false, new Guid("88fbd469-d541-4e89-9736-988ca894e0e8") },
                    { new Guid("93ef415f-7aa9-4d6e-bcf2-cdb1b1b3d9ee"), null, null, "Elaina_Hyatt@gmail.com", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("9410b5fe-90c0-4fb8-90ff-934425c5e19b"), null, null, "Alyce_Bednar35@hotmail.com", false, new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("94395321-ee49-4b0f-8b05-9c74fbcac0be"), null, null, "Zackary.Mohr70@yahoo.com", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("948df593-ac5c-4bbd-bef1-cbf2bf339a0c"), null, null, "Jennings_Hermiston@hotmail.com", false, new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("94d19c1a-e80a-4746-8b9c-c6b18db6b4ae"), null, null, "Foster7@yahoo.com", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("957487e4-ada4-4c33-bb2c-d18b1a32cf4c"), null, null, "Ellsworth_OConner@yahoo.com", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("9582f462-7d89-47cf-8f11-4dd0361afe0a"), null, null, "Rodrick_Heidenreich@gmail.com", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("95d52e44-9b33-414d-ba23-f8722758571c"), null, null, "Art44@hotmail.com", false, new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc") },
                    { new Guid("9692843a-168f-4f6d-9708-f42caccf724b"), null, null, "Pat74@gmail.com", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("96d69d5a-8bfe-4eae-95d2-6bb624d90dde"), null, null, "Taurean97@yahoo.com", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("96fe9814-e0ed-4aa8-b874-7ad359967d4e"), null, null, "Camylle_Welch@yahoo.com", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("972bff8a-82b4-4885-923a-1afafe6164ca"), null, null, "Cynthia10@yahoo.com", false, new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") },
                    { new Guid("973c3cb3-ce40-4288-b21c-a310dca9ad5a"), null, null, "Tara59@hotmail.com", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("97a93e85-8d1f-44fa-81b3-d12ddffe1d79"), null, null, "Harrison73@hotmail.com", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("989dbecb-8b5c-42da-b00b-226b865e3e3a"), null, null, "Maya_Gulgowski@gmail.com", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("98e85e06-dcba-4fca-8afe-5481f9bf76af"), null, null, "Horacio33@hotmail.com", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("9911190d-acf2-4699-bfa7-88afde525fc6"), null, null, "Lucious89@yahoo.com", false, new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291") },
                    { new Guid("9919671c-913b-493e-a361-70fec1269869"), null, null, "Rudolph_Willms@gmail.com", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("9921443d-f285-42b7-9618-f5d2d8718cbe"), null, null, "Mike.Bernier@yahoo.com", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("998acd16-41b1-4161-8d7a-0e7e48324113"), null, null, "Gerardo44@hotmail.com", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("99945ac6-3bf6-4c80-b37d-b5ac42ce537f"), null, null, "Vivian_Sawayn96@yahoo.com", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("99a8573c-8039-4c16-9a9d-7e4083c41f5b"), null, null, "Virgie_Pfeffer61@gmail.com", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("99ef3032-d8a8-4141-aac6-b7c66ea30da5"), null, null, "Wendy_Shanahan20@hotmail.com", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("9a169b33-3c23-4199-ab1f-cc8bc488d819"), null, null, "Westley_Robel15@hotmail.com", false, new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9") },
                    { new Guid("9acbff72-0b61-4d62-9ba9-567fa649a5fa"), null, null, "Conrad29@yahoo.com", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("9b254439-d8bd-47d3-9040-6544cf4017d1"), null, null, "Avery_Hartmann8@hotmail.com", false, new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("9b39f1b0-2efe-49d4-9cde-848c6af79494"), null, null, "Dovie_Kreiger51@yahoo.com", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("9b656f4c-4899-4c2a-a974-b14d2197868a"), null, null, "Cecil_Friesen16@gmail.com", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("9b6d7089-239a-49c5-8a7c-71ca27d32619"), null, null, "Evangeline.Upton@gmail.com", false, new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8") },
                    { new Guid("9ba93120-795a-4587-9fe7-3864c2eda3d6"), null, null, "Peggie_Mann54@yahoo.com", false, new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44") },
                    { new Guid("9badd650-fc5e-4c2b-ab6a-4665fb81eb0e"), null, null, "Rosella11@hotmail.com", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("9c33c961-f40f-4a80-a0e5-2285bc2ab91b"), null, null, "Florence.Kovacek@gmail.com", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("9c47986c-dc4c-475a-8579-8cb39b47e188"), null, null, "Donald_Hilll37@gmail.com", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("9c6bd68a-249d-439e-9f90-2c7a1a54ca25"), null, null, "Imani_Morar@gmail.com", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("9cdd85e4-611f-439f-9305-33a7adf17ede"), null, null, "Augustine_Brown58@yahoo.com", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("9cece60c-5cbe-4d6d-b38a-ffcdfce36f07"), null, null, "Elta.Schowalter34@hotmail.com", false, new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291") },
                    { new Guid("9cf08c8f-d2d5-40b0-861b-28cb7133d106"), null, null, "Jasmin29@gmail.com", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("9cf20734-9770-49b2-b27e-77a9f6521582"), null, null, "Nathaniel.Thompson25@gmail.com", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("9d2ec28f-effe-4495-9295-5570d648aeaf"), null, null, "Thomas.Braun@hotmail.com", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("9d5b2c3e-7163-4c4e-b742-d177ba0260ad"), null, null, "Leonora40@hotmail.com", false, new Guid("99484890-5bb7-47f9-b211-218700e48dad") },
                    { new Guid("9e5c12f4-6643-4640-b74d-e75a4b25b481"), null, null, "Ansley.Thiel36@hotmail.com", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("9e813625-cdf4-4370-84c0-c29effba0b1f"), null, null, "Ada93@gmail.com", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("9e9594ef-66b2-4931-98fb-cf4ee610021d"), null, null, "Ellie.Barton@yahoo.com", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("9f108abc-8008-4271-8c01-4083947bd6f2"), null, null, "Tate_Howe43@gmail.com", false, new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420") },
                    { new Guid("a024460f-5ecf-40f0-82ad-39e9894ed184"), null, null, "Piper47@yahoo.com", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("a02c0fc9-5e01-45c1-a50a-263735d3adf8"), null, null, "Janick.Smitham@yahoo.com", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("a06a2015-658e-4470-9f64-d3fb0c9a9443"), null, null, "Tess.Schuster32@hotmail.com", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("a08a7b13-bc4e-4c3d-97c4-c4f668d0350f"), null, null, "Adriel.Rogahn3@hotmail.com", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("a0ce1229-1f16-4fbb-862b-1e9ee1cdb270"), null, null, "Darius47@gmail.com", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a0d53ede-3ec5-4970-8b05-253004ad25c7"), null, null, "Remington12@hotmail.com", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("a14b9ab8-9ecc-4be5-8819-5bd053eb61d5"), null, null, "Pamela_Gusikowski41@gmail.com", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("a1695332-1b6c-4261-affd-e80b58ace8d4"), null, null, "Karson51@gmail.com", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("a1a592d1-3cf1-4628-8211-8c4938791bb1"), null, null, "Christiana59@gmail.com", false, new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04") },
                    { new Guid("a2493cdd-1eda-4134-94d2-993fc545168f"), null, null, "Leopold_Koch@hotmail.com", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("a26c7a70-6139-4e9a-88a5-cb071c458fa1"), null, null, "Jerod82@yahoo.com", false, new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2") },
                    { new Guid("a2b0fee3-0e4b-447d-8925-b5b3d1f2175d"), null, null, "Alicia46@yahoo.com", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("a2c224bf-d1f0-4e4e-8743-e8176bba3d41"), null, null, "Ulices.Green@gmail.com", false, new Guid("45649949-0283-499e-b496-44660ddab1e4") },
                    { new Guid("a2ddcc66-7924-436e-9d0c-f57718ab6d41"), null, null, "Loy.Bergstrom72@yahoo.com", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("a324ca4b-93d0-444e-bd22-bf39081833cc"), null, null, "Parker.Donnelly65@yahoo.com", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("a3501bab-3d49-43f6-a0f4-59c5442e5c87"), null, null, "Nona45@hotmail.com", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("a38ebadc-a9fc-46fa-9691-6202639819ce"), null, null, "Janae57@hotmail.com", false, new Guid("77f944f9-c758-4983-b702-656640bf5672") },
                    { new Guid("a3e98157-37d7-4f44-94d5-f77e698f0bd3"), null, null, "Valentin_Koss@hotmail.com", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("a4544cd5-9e89-4437-8d58-156502dab153"), null, null, "Elmer72@hotmail.com", false, new Guid("97fd604a-eb78-4e29-829c-caf68b162e92") },
                    { new Guid("a50aa0a5-39f8-4ba7-a88b-8cc85af6c180"), null, null, "Lilly_Schinner@hotmail.com", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("a534ce80-34ff-4bfb-b3c5-1dcd27d82578"), null, null, "Chaim74@gmail.com", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("a58a06be-3e94-4b72-860d-40581decda72"), null, null, "Vivien16@gmail.com", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("a6317148-b67d-4fe0-9763-2fa551e3c1ac"), null, null, "Cyrus_Batz@hotmail.com", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("a660972d-c907-40c8-8f80-cb46aa18b5ff"), null, null, "Elyse_Friesen84@gmail.com", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("a67e6efc-5411-4870-a6a3-5e2d1b878203"), null, null, "Kaylee.Smith@hotmail.com", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("a6daf5f7-82d1-4050-822f-1312010689e5"), null, null, "Jannie_Denesik13@yahoo.com", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("a701f01a-c482-4691-9340-b1cd4a715a86"), null, null, "Adela37@hotmail.com", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("a7048d46-047e-4c67-9557-dc0df58111d2"), null, null, "Darron.Heaney87@yahoo.com", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("a72cb7b3-8eeb-43ce-81ea-0312e0acb908"), null, null, "Tyree48@yahoo.com", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("a72ee6c5-1141-49b3-96b1-ae6df84dbe1e"), null, null, "Anna.Becker66@hotmail.com", false, new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2") },
                    { new Guid("a7789919-3acf-4074-8064-ea6bbebb9bc4"), null, null, "Aurelie_Rodriguez39@yahoo.com", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("a7982c60-857f-402d-a2ad-c3477c4eba0c"), null, null, "Orval.Ziemann77@gmail.com", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("a7c55103-c1d0-479f-b284-75469382d589"), null, null, "Jacques_Ferry@yahoo.com", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("a7e4974f-28a0-42ea-a1be-42e0160ccbff"), null, null, "Quinten_Reichel@gmail.com", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("a8c9c971-0633-4977-8710-fafef5a9c879"), null, null, "Leo35@hotmail.com", false, new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1") },
                    { new Guid("a974f2d8-dd7a-4731-9f2a-28c03255f493"), null, null, "Bradly.Gaylord58@gmail.com", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("aa43bfcd-2c4e-4271-a2bc-b2d9070d23c8"), null, null, "Ted45@gmail.com", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("aa975664-fc16-46ee-9713-be43ef79b6c4"), null, null, "Yvonne.Gottlieb@yahoo.com", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("aaea16b1-00ae-4aa2-bfdf-cbac0ef24266"), null, null, "Sarai.Terry22@yahoo.com", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("ab14fbd6-b4bb-4db3-85b7-e7b82741ee2d"), null, null, "Demetris.Macejkovic19@yahoo.com", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("ab90197a-3c39-4cc0-80c2-37d830611174"), null, null, "Roman_Kessler@yahoo.com", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("abecf02b-7bfc-49e3-b1df-b47a613b3092"), null, null, "Alford.Davis@hotmail.com", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("acb0e3fd-7a35-4eae-850c-3ea8846c1558"), null, null, "Carmela28@hotmail.com", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("acee90af-cb97-48b5-b6fb-65287d511cf3"), null, null, "Maiya.Boyle47@hotmail.com", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("ad072ac5-1cb0-4c73-92f4-7844f9733a6e"), null, null, "Kale_Kautzer13@hotmail.com", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("ad1f90f7-1706-4db3-9912-42e34dedf480"), null, null, "Christine.Turcotte31@gmail.com", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("ad2880db-215d-4342-810b-696d6886154e"), null, null, "Drew.Littel68@hotmail.com", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad862a52-842f-4297-ac99-e9799eeae8b2"), null, null, "Raphael_Stroman67@yahoo.com", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("ad9c6866-a97e-4944-9fcc-9609fb3df10b"), null, null, "Roberta39@hotmail.com", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("adc23bd3-2f2a-473c-9d41-7e0fd3b76b72"), null, null, "Lea60@yahoo.com", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("ae4e93e0-b71d-4258-87a3-706b25fc643a"), null, null, "Oceane.Wolf@yahoo.com", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("aeb713c6-8dea-4ca7-bc18-e13b9138afda"), null, null, "Domenica37@gmail.com", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("af097f60-5699-4c32-a9ed-cf14cfa74061"), null, null, "Maudie10@hotmail.com", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("af83d842-b4e8-4bdc-8496-099a8a13d292"), null, null, "Karine_Torphy@yahoo.com", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("afa4f005-ce33-4f95-8b56-c9f74703443b"), null, null, "Narciso62@hotmail.com", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("afaa2410-4b04-4508-a476-fd484d2ffe46"), null, null, "Bethel_Kihn53@hotmail.com", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("b09ba7d5-1c4d-4660-822c-e10b3612712b"), null, null, "Carolina.Waters83@yahoo.com", false, new Guid("08094f90-68b7-4576-a740-581a4878e4ab") },
                    { new Guid("b1472887-603f-4d96-a00c-78d31ac5788e"), null, null, "Jarod_Larson16@yahoo.com", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("b21d2567-49ef-4a8b-ac57-a3c90d890b97"), null, null, "Hallie.Kuhlman@yahoo.com", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("b24615b1-4963-4d09-b854-05548df65a64"), null, null, "Gideon.Connelly@gmail.com", false, new Guid("7573b136-e686-46e6-b0af-1186d8e37af1") },
                    { new Guid("b24df6b6-7eac-4d87-806f-970bab13759e"), null, null, "Kristy_Kiehn24@yahoo.com", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("b254c868-2786-46cb-aa56-91e0596731a8"), null, null, "Alfonzo.Walker71@hotmail.com", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("b3111bea-a949-4cca-a809-738ac6f8d618"), null, null, "Gerardo.Becker16@hotmail.com", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("b382ed7c-6916-48bc-b899-8a10dd6e2c1b"), null, null, "Juwan.Flatley56@gmail.com", false, new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd") },
                    { new Guid("b3859b1f-50cd-41a8-b5ae-f1a9ca525efc"), null, null, "Kaylie18@hotmail.com", false, new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc") },
                    { new Guid("b40915d9-7664-41b2-baa1-4ab8a9a75a86"), null, null, "Tyree.Miller@yahoo.com", false, new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c") },
                    { new Guid("b40f3e23-7417-47cc-aff7-b3048a7469fe"), null, null, "Zula81@hotmail.com", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("b4be15c4-c8ee-499e-8077-279b4856216f"), null, null, "Shawna90@yahoo.com", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("b560bbab-2291-46d0-a5ca-a8ec9b90d0c2"), null, null, "Anabel_Lindgren98@gmail.com", false, new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9") },
                    { new Guid("b56ceacc-ca98-4b78-bcb1-57efea31271b"), null, null, "Mark_Rohan27@gmail.com", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("b5878fb6-3501-466b-b1de-013f8f2539e8"), null, null, "Emmy.Little41@hotmail.com", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("b5f9c77b-1943-444b-8330-8dc537ac2bf1"), null, null, "Derek_Kozey45@yahoo.com", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("b627ead4-41d9-4c07-b472-27cf94d22d28"), null, null, "Darron.Hermann@yahoo.com", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("b632a6ba-a697-4bcb-b793-e26fbd938ce5"), null, null, "Berta_Roberts@hotmail.com", false, new Guid("8905b747-db92-42c9-8385-1d49f6b8e578") },
                    { new Guid("b6cf4249-ed95-4b0e-9c8c-f1a4711e9113"), null, null, "Bailee56@hotmail.com", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("b7035aa5-eb23-4d25-98eb-375746813fdc"), null, null, "Jedediah.Beatty@gmail.com", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("b7299ec0-39c7-4d77-8ef1-c91a1b9d6ca2"), null, null, "Carson89@yahoo.com", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("b742423d-c12a-4f69-824d-c19768600f58"), null, null, "Trey_Goodwin@hotmail.com", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("b78201b4-c0eb-429d-ace5-c56973cd24c5"), null, null, "Clarissa_Tillman80@hotmail.com", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("b7c2eeaa-ddcc-4f45-956d-6f13703b6826"), null, null, "Ignatius0@gmail.com", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("b7cac8e3-cd43-41d7-a8ce-c838116bb8db"), null, null, "Geo_Heidenreich76@hotmail.com", false, new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee") },
                    { new Guid("b7cdb8cc-3e32-4428-a0cb-ed92d5c2235f"), null, null, "Leora.Greenholt39@gmail.com", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("b81c028e-1c2c-4df5-93ac-4e1231037836"), null, null, "Verda.White@yahoo.com", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("b8618b68-1bf5-46ca-9f46-0616a9e0e227"), null, null, "Werner59@hotmail.com", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("b8650eec-d08c-4079-921e-dc7d840bfa06"), null, null, "Ava.Nikolaus64@yahoo.com", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("b883bd4b-5b23-4bf9-971e-b832bcc5e4b5"), null, null, "Twila39@hotmail.com", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("b8eb3e74-d186-4cdf-b078-c774fb28f6c1"), null, null, "Ilene78@yahoo.com", false, new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("b9c39575-355f-4c66-85ce-be8c32d30bcc"), null, null, "Caleb.Grady@yahoo.com", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("b9f44363-63f6-4aea-bfe5-c849237f0257"), null, null, "Kathryn71@hotmail.com", false, new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b9f9bfa4-ab44-429b-9985-0347e64d846f"), null, null, "Darian_Reinger92@hotmail.com", false, new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6") },
                    { new Guid("ba2bc80b-3eea-4848-9048-df6241724b85"), null, null, "Jevon67@yahoo.com", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("ba59dac8-b1a0-4f54-8680-e9ca8acc78ec"), null, null, "Kailee_Rowe63@gmail.com", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("baad4f80-6581-470b-9d1e-dad83e73fe1e"), null, null, "Zoie_Brown85@gmail.com", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("bac39334-5a0d-4894-8ebe-f8ab2ea5a721"), null, null, "Tristian.Cruickshank@gmail.com", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("bb586694-bd80-4a52-803c-c5c25f8b20c3"), null, null, "Electa31@yahoo.com", false, new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117") },
                    { new Guid("bb70632d-975c-4dfc-be3e-7c5a1c4df9d3"), null, null, "Heber69@hotmail.com", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("bc058a62-33d6-4649-9968-0eab13f9e1ce"), null, null, "Myra.Ullrich49@yahoo.com", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("bc0803c9-87a2-4f46-9f4e-eafe84b3a703"), null, null, "Zackery.Marks@gmail.com", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("bcb42b87-8f69-4140-8506-16fb38c051b6"), null, null, "Shania_Fay5@yahoo.com", false, new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470") },
                    { new Guid("bcdc81ec-05c1-4d4b-a9b8-5f815cd9a1e6"), null, null, "Amya.Shields@gmail.com", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("bcf254a6-038a-4b22-9f3f-b9750e3ea90d"), null, null, "Elbert10@yahoo.com", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("bcfaf3c2-db8a-4306-9a4b-ab882fedacf9"), null, null, "Roger_Pfannerstill@yahoo.com", false, new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8") },
                    { new Guid("bda77cb2-0675-4181-b3db-6496e8a59c18"), null, null, "Kathryne33@gmail.com", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("bdbdd2cf-4fc9-400c-b761-531908ffea77"), null, null, "Theodora_Beier73@yahoo.com", false, new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154") },
                    { new Guid("be2a775f-faae-44df-80b4-5dd320a3dd84"), null, null, "Nayeli8@hotmail.com", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("be701432-9add-47d9-97c2-774965130926"), null, null, "Julien_Zboncak60@yahoo.com", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("becda03b-60e5-4fbd-9ea0-a9644c8f602c"), null, null, "Florian_Gerhold21@gmail.com", false, new Guid("43a79d17-6c7f-4919-8fc7-806f34234239") },
                    { new Guid("bee956b7-14a0-421b-8eeb-df8c8bb383df"), null, null, "Delilah.Stiedemann@yahoo.com", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("befa0f36-8999-4eda-86d3-37d34448fe58"), null, null, "Leda.Jacobson@gmail.com", false, new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2") },
                    { new Guid("bf6e5657-c79d-4578-ace5-08a647dc46bf"), null, null, "Jake.Pfeffer@gmail.com", false, new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e") },
                    { new Guid("bf9507e8-ff61-4678-85f5-4ab12f1b531c"), null, null, "Enrique_Muller22@yahoo.com", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("bfc71d0a-377f-4e8a-a33f-3e9b1560f2f4"), null, null, "Mathias67@yahoo.com", false, new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba") },
                    { new Guid("c02190c9-6230-45cb-bf48-95ec1d0e2d8e"), null, null, "Myrl_Kuhic@yahoo.com", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("c0643b65-6bf8-45f2-bbb6-5720b89dfc0f"), null, null, "Makenna_Hayes63@yahoo.com", false, new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6") },
                    { new Guid("c0fda45c-127b-4d7b-b58c-7396de233a57"), null, null, "Zachariah.Mueller@hotmail.com", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("c109d3b3-0017-45ad-b357-899b10a154be"), null, null, "Andreanne_Ritchie9@yahoo.com", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("c1104fd1-e8ad-4ddf-8fde-a77c2760362f"), null, null, "Mohammed58@gmail.com", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("c12d6bcc-c9a0-40d6-bffa-6291323f5643"), null, null, "Eulalia.Schuster@hotmail.com", false, new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592") },
                    { new Guid("c16dc313-aab8-4f9c-a321-bdc66047726d"), null, null, "Emma34@hotmail.com", false, new Guid("f0811698-5de9-42a6-a253-8958ca513eb5") },
                    { new Guid("c2111e7e-a3b7-42af-bc29-b484826a832c"), null, null, "Rowland53@yahoo.com", false, new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("c24e7d55-c1c6-4fe1-a446-0ea1c3766a8d"), null, null, "Lolita70@gmail.com", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("c2c44201-066b-4569-96ad-ea32a9e21631"), null, null, "Karley19@yahoo.com", false, new Guid("5ffc49e2-50fb-41f2-8784-192077f86010") },
                    { new Guid("c351d14e-f8dc-43dc-9e75-c126d0a0333c"), null, null, "Loyal26@gmail.com", false, new Guid("4ea29651-f292-4cbf-8413-d8821c394155") },
                    { new Guid("c372579a-c662-49b3-9b14-cf66f628cf1f"), null, null, "Mario.Gislason@hotmail.com", false, new Guid("80ed64a5-2f87-4262-aed3-901da3da1369") },
                    { new Guid("c375a4c8-a6ec-44d2-9f75-af7d3d012d0b"), null, null, "Josefina.Osinski@yahoo.com", false, new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8") },
                    { new Guid("c3c56633-e06a-4ce5-9658-cfd77b35560d"), null, null, "Ophelia63@hotmail.com", false, new Guid("8be83005-0ddc-42eb-877d-582666d35fea") },
                    { new Guid("c3e59864-5258-4b4d-a5af-d70522ac6731"), null, null, "Aida.Rohan84@yahoo.com", false, new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("c4503e3b-9f7f-415d-a2e0-4eecf9b7bdeb"), null, null, "Lee.Lubowitz1@gmail.com", false, new Guid("6bf86772-9995-44ea-a063-ccc583990881") },
                    { new Guid("c463cf60-3e32-4746-9d08-d07873941765"), null, null, "Clarabelle_Fritsch@hotmail.com", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("c4a5b65d-4466-4bac-a9cb-c721106ed976"), null, null, "Teagan_Hilpert74@gmail.com", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("c4e54562-da18-4f17-adfb-07fb64a5a712"), null, null, "Vance_Pouros@hotmail.com", false, new Guid("78016c36-672a-4efd-980e-250a79e4d32e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c54cc70c-3240-4f5f-8ce4-da7c7cfd3b2f"), null, null, "Troy79@hotmail.com", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("c560c055-9340-4495-bbc6-e4b86f57e185"), null, null, "Tristin32@gmail.com", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("c5ee30aa-ff41-449a-822f-a56587b2095d"), null, null, "Melba_Emmerich0@gmail.com", false, new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420") },
                    { new Guid("c70aa0c5-820c-4483-a4c0-17ff4005e259"), null, null, "Curt_Nolan97@hotmail.com", false, new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018") },
                    { new Guid("c748e9b2-a496-4c58-bce9-97ad453d2045"), null, null, "Jodie.Bergstrom77@yahoo.com", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("c74c113f-257c-4a99-bf9a-98e156979471"), null, null, "Ola58@yahoo.com", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("c7ce3cb1-79be-45ef-b449-76912b6e8335"), null, null, "Josie.Cummings@yahoo.com", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("c85d5cba-2079-4ed2-b204-7e891e642bc4"), null, null, "Yasmeen39@hotmail.com", false, new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee") },
                    { new Guid("c8a03db5-bbe5-4af9-ab10-6903555475b7"), null, null, "Zora_King38@hotmail.com", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("c94906eb-bc39-406c-947d-0428d41c15d3"), null, null, "Kyler_Barrows@yahoo.com", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("c9857374-547d-4eb2-a4f2-49c8e6eaf7e0"), null, null, "Jovany_Mann@gmail.com", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("c9ecf1a4-1a8a-45f5-a4db-eb648ec7420b"), null, null, "Wilson46@hotmail.com", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("ca8596e7-b8ff-4da0-966c-5c6ff6d7df18"), null, null, "Matilde.Conn19@hotmail.com", false, new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef") },
                    { new Guid("caac11f5-6234-491e-a93e-18546989cf9e"), null, null, "Arianna_Dach@gmail.com", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("cac8d453-93f0-40c3-b106-2960c7379d1e"), null, null, "Rodrigo.Stamm51@hotmail.com", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("cb140505-8c84-4149-92f2-0689ee8fae9a"), null, null, "Maye_Legros@hotmail.com", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("cb1700a0-6b84-4a7f-8aa2-6e9888a956ef"), null, null, "Raphaelle.Rutherford@gmail.com", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("cb2760d4-96c5-4090-98a8-44a0f4550bb9"), null, null, "Melisa_Kunze16@yahoo.com", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("cb2ca996-b0f9-43aa-b28d-16e41daa2096"), null, null, "Zoey.Rogahn24@gmail.com", false, new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6") },
                    { new Guid("cb6005de-df8d-4929-8860-b07d592ac57a"), null, null, "Deron_Kris@gmail.com", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("cbc8c29c-ad74-4102-88de-8be295405cda"), null, null, "Vada_Kohler@hotmail.com", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("cca88b05-f6e5-4104-ad20-3c6d9b1e25f2"), null, null, "Zack_Nader@hotmail.com", false, new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e") },
                    { new Guid("cd618317-444e-497d-ab3a-c06c991407ba"), null, null, "Keenan62@hotmail.com", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("cd773041-f399-4d0b-85f7-6f6fce51dff5"), null, null, "Stan.Frami@gmail.com", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("ce1235e8-38aa-4a08-89ae-ff16cbf465d6"), null, null, "Joaquin.Baumbach90@gmail.com", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("ce469b9d-1e4c-46d0-9411-1ffc78132fa0"), null, null, "Monte_Prosacco@hotmail.com", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("ce5daf63-da71-42bd-ac7d-65ce466d65d0"), null, null, "Edison_Beer@yahoo.com", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("ce9a2d9e-9aae-4a0a-b646-e6c55b055de9"), null, null, "Tess27@hotmail.com", false, new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da") },
                    { new Guid("cef2d5d2-91db-47b8-a652-63c51e8f299b"), null, null, "Myles_Klocko4@hotmail.com", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("cf55c8a2-a067-48a8-b2fb-e64270b36506"), null, null, "Walton_Rowe@yahoo.com", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("cfa080bc-db5e-4195-9ceb-329ecfd1806d"), null, null, "Tyrell94@gmail.com", false, new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd") },
                    { new Guid("d0b598c3-71cc-471b-b8d9-83da6d806eda"), null, null, "Herminio.Bins@yahoo.com", false, new Guid("94aaefbb-3b69-4a12-8609-44039863dc44") },
                    { new Guid("d0b63b6e-4e1e-43a9-9147-479fd53d3fb5"), null, null, "Arely_Goldner10@hotmail.com", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("d1a7b43f-8c83-45ad-9761-2b1db4954193"), null, null, "Noemi.Schmidt38@yahoo.com", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("d1bae146-1e42-4180-b74c-a86a7b7ea6eb"), null, null, "Kayli_Swift28@gmail.com", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("d1d3edca-2be0-4e86-9ec5-7ad3d2631595"), null, null, "Aliya_Hintz@yahoo.com", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("d232d558-7a59-4894-b1c5-2e7805688128"), null, null, "Lucile80@gmail.com", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("d2418b32-8be6-4d92-86a3-d9c38ef1851b"), null, null, "General_Prosacco@hotmail.com", false, new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748") },
                    { new Guid("d2dd28c3-29ff-4202-b437-ddc291d5b898"), null, null, "Liza_Moen39@yahoo.com", false, new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("d337aec8-6a79-4be6-812a-99040078b2d3"), null, null, "Jeramy86@hotmail.com", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("d3737881-7d3c-4a15-a931-3ed1bd69226c"), null, null, "Carole.Wehner@gmail.com", false, new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6") },
                    { new Guid("d3d3c058-8a2f-4b94-8419-953d79e2dd7c"), null, null, "Jena_Towne51@hotmail.com", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d3e86bc9-7be8-4e40-ad61-4b17af3a839a"), null, null, "Zula73@yahoo.com", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("d3f2e053-0585-42c6-8d62-43e0251dc689"), null, null, "Wilber52@gmail.com", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("d4eda2eb-c04f-428d-8d9d-d2b0c23260f4"), null, null, "Agnes54@yahoo.com", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("d522e0d4-e5f5-4aa7-8390-8aff31df3a36"), null, null, "Carol66@yahoo.com", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("d543647e-0e1f-4b1c-a291-dccb790ff65c"), null, null, "Cory.Hahn39@yahoo.com", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("d5438405-f8f5-4c45-99c1-1c01c73609f4"), null, null, "Alene_Kunde38@yahoo.com", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("d57abee0-b8bf-4366-97c5-d2907d3edaba"), null, null, "Bria_Littel16@yahoo.com", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("d6badf39-2467-41c9-9875-932c45b0d259"), null, null, "Amalia83@yahoo.com", false, new Guid("88fbd469-d541-4e89-9736-988ca894e0e8") },
                    { new Guid("d77d743a-4eb2-4da7-9796-a380abd69c1b"), null, null, "Loma_Cormier99@hotmail.com", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("d7c655e9-68e8-4e86-8f6a-4ae586e33231"), null, null, "Maria36@yahoo.com", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("d7c922ce-3c64-468f-83bf-e918554b4e28"), null, null, "Darlene_Bernier9@yahoo.com", false, new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665") },
                    { new Guid("d7e12217-86d6-401c-a772-f63f5d057f86"), null, null, "Cleve54@hotmail.com", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("d7eaf0dc-915e-421d-b264-40ed2f563569"), null, null, "Graham.Corwin46@gmail.com", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("d8131829-bb3d-4a29-abb2-a8e2987b03c5"), null, null, "Araceli_Rutherford@gmail.com", false, new Guid("4ea29651-f292-4cbf-8413-d8821c394155") },
                    { new Guid("d8151cf1-0575-47cc-a0fc-47e69b521eb0"), null, null, "Raegan.Bernier58@yahoo.com", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("d84a03de-750d-4f35-8ff7-7c9abcee5ad2"), null, null, "Devon.Schumm97@hotmail.com", false, new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594") },
                    { new Guid("d886e637-37c8-4882-a1e2-aff48fe35515"), null, null, "Griffin37@hotmail.com", false, new Guid("94aaefbb-3b69-4a12-8609-44039863dc44") },
                    { new Guid("d89c1e22-063c-46c8-bd60-7e42434e470d"), null, null, "Blanche.Robel@hotmail.com", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("d8afcfe0-00e3-4ce8-9da6-9fd2af9599e0"), null, null, "Maximillia.Ernser40@yahoo.com", false, new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("d8bbcc34-089b-4706-b2d3-f05d263a8381"), null, null, "Alivia89@gmail.com", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("d8db3d24-25c4-4132-b596-0855c6ab9c19"), null, null, "Jennings19@hotmail.com", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("d94917ed-786f-4e06-8c34-650575e73006"), null, null, "Wilburn94@hotmail.com", false, new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba") },
                    { new Guid("da4dffd6-4f29-49b8-96e7-a8935c915256"), null, null, "Ernesto_Legros93@gmail.com", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("da5ae352-3f57-4612-91e6-a68294827c26"), null, null, "Howell.Keeling67@yahoo.com", false, new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979") },
                    { new Guid("dab38dc2-880f-48cb-a508-171b37016f09"), null, null, "Maiya30@gmail.com", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("db34fad5-abc3-4d36-8333-213c0111c78e"), null, null, "Lupe38@yahoo.com", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("dc27976e-ff02-46c2-b46a-676400707c83"), null, null, "Herminio.OHara42@yahoo.com", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("dcaa9ad1-3608-4096-8571-4aba786b8fd3"), null, null, "Camron68@yahoo.com", false, new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c") },
                    { new Guid("dd5d3c7a-d235-4123-8cae-9e6e62c24fa8"), null, null, "Mallory_Crooks20@hotmail.com", false, new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae") },
                    { new Guid("ddc5f048-01a5-42cf-8fd1-ef30bb43d84a"), null, null, "Edwardo69@gmail.com", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("dde215a4-3fdc-4b95-9952-03a8aa671634"), null, null, "Ismael_Witting@hotmail.com", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("de127608-7c47-4c7f-a6fa-e5f814b10576"), null, null, "Sherwood.Cummerata@hotmail.com", false, new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56") },
                    { new Guid("de32a49e-ad41-44b5-b16c-4713d9a53a4d"), null, null, "Kellen_Raynor@gmail.com", false, new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665") },
                    { new Guid("de629283-9276-4dcf-93ac-3430ef20678d"), null, null, "Maynard_Schmidt20@hotmail.com", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("de7c9a7f-849f-4459-b18a-ea28d680829e"), null, null, "Lupe68@yahoo.com", false, new Guid("99227d48-6d3f-45fd-971b-83f0198ee703") },
                    { new Guid("de997472-c7bd-4e3f-9340-cd808308e03a"), null, null, "Wilbert.Nicolas@yahoo.com", false, new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a") },
                    { new Guid("dea35877-be51-4c02-89a8-3d1a3041f8ac"), null, null, "Haley.Wyman83@hotmail.com", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("deb18b2b-62d3-4705-a061-21f1a03f098f"), null, null, "Mariana.Hegmann76@hotmail.com", false, new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760") },
                    { new Guid("deb79bce-b963-436c-b21c-898c96f264c9"), null, null, "Garnett.Schamberger@yahoo.com", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("def2338b-1054-4f12-a55f-dc7b1a602c3b"), null, null, "Desmond.Klocko75@hotmail.com", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("df10172c-01dc-4217-9c54-f073ea9c25b3"), null, null, "Samanta74@gmail.com", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("df273cf2-5b5b-41dd-bee3-ad2badf529fd"), null, null, "Hayden89@gmail.com", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("df9c1d84-ef82-4066-b0ed-c4da28ac5486"), null, null, "Cristobal_Wisoky@hotmail.com", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("df9e146e-a7aa-4e95-9639-a74ac261c3c4"), null, null, "Clifford74@hotmail.com", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("dfa804e1-bdbf-441a-a223-bccf2992124c"), null, null, "Mavis.Jacobi64@hotmail.com", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("dfd576ed-4b8b-4618-836c-e0132ef50390"), null, null, "Casandra57@hotmail.com", false, new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb") },
                    { new Guid("e0524e42-5a11-4ce7-a894-4dc8354e9803"), null, null, "Katelin.Abbott@yahoo.com", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("e07459f0-d9f8-402d-a361-817075872fca"), null, null, "Kasandra_Lueilwitz57@hotmail.com", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("e10c4f1a-93dc-4a9d-baa4-a34682716517"), null, null, "Liliane.Mertz@hotmail.com", false, new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa") },
                    { new Guid("e138d38b-406d-4fc3-b0fd-a766cb564fd2"), null, null, "Rashad71@yahoo.com", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("e143ed62-7855-426a-8601-13b7db796cd2"), null, null, "Emiliano_Schinner@gmail.com", false, new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500") },
                    { new Guid("e1536e2e-0305-448c-9da5-0ec501187e55"), null, null, "Alan77@yahoo.com", false, new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739") },
                    { new Guid("e1c9ea3f-a847-4030-bec4-dfc371a6f16b"), null, null, "Pierre_Swaniawski@gmail.com", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("e28dd0d9-ee8f-4bff-9328-cc76d95bac5e"), null, null, "Eldred70@hotmail.com", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("e2a5ec39-2cd7-4102-ae5a-69c2f3e86a6e"), null, null, "Adonis.Padberg61@yahoo.com", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("e30d3225-de99-422b-8732-056389b6b0cc"), null, null, "Rosa92@yahoo.com", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("e3615645-3ee0-407b-814c-d6b3d35b6a27"), null, null, "Alexandro_Wisoky79@gmail.com", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("e371e9a1-92c0-435f-97be-28bfeb96b83f"), null, null, "Raphael51@hotmail.com", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("e4001ed0-f665-45ad-b879-3e55c370a4fd"), null, null, "Emma.Kreiger@hotmail.com", false, new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("e48b07a0-c054-460e-a12f-ceb9d6ab87cc"), null, null, "Dallin.Romaguera@gmail.com", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("e4cc3ced-edd0-41c1-8e38-769217b4065c"), null, null, "Luz57@gmail.com", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("e4cf35dc-0842-4128-a1fc-f5f05191acb2"), null, null, "Hertha32@hotmail.com", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") },
                    { new Guid("e4eb9c93-7c00-4175-85a4-db422dbe06a6"), null, null, "Frieda_Dibbert@gmail.com", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("e511f25f-6e73-4b74-8657-1952235686bf"), null, null, "Delaney.Cole@gmail.com", false, new Guid("1154048c-cc8b-409f-a802-5dbe51d20548") },
                    { new Guid("e5620494-5d66-4f29-a2a9-c89035627eda"), null, null, "Avis90@gmail.com", false, new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67") },
                    { new Guid("e59254a8-cfbc-4691-aaf8-5fc3ed446af0"), null, null, "Katelynn.Rogahn18@hotmail.com", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("e598da52-994d-41bd-bdcf-4b01e66ace20"), null, null, "Dedrick_Heathcote5@hotmail.com", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("e5ba8860-d019-4f89-9e54-f17566ab689c"), null, null, "Margaret_Reichel16@hotmail.com", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("e6163135-065f-428e-bdbe-a3f3ec390aa6"), null, null, "Darron46@gmail.com", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("e61b81a8-71c7-44c7-b5f4-c73d19045500"), null, null, "Erik42@yahoo.com", false, new Guid("816326af-094b-4b97-b10b-548a2296766b") },
                    { new Guid("e6ad09f3-fbbd-4d0e-87ac-b4bc8535d029"), null, null, "Garrison.Herman@yahoo.com", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("e71e6363-82e0-44d5-bc59-147e0de57ed9"), null, null, "Chaya_Collier94@yahoo.com", false, new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67") },
                    { new Guid("e79f1581-1821-4434-9b07-9e39377b6a42"), null, null, "Charlotte.Krajcik@gmail.com", false, new Guid("862a826f-0eba-4891-9241-dff3a8896969") },
                    { new Guid("e7aa9bf4-3518-4a0f-9c66-90073aee9d9a"), null, null, "Merl_Ziemann@yahoo.com", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("e7bb5c80-a09b-415e-85cb-c0a81c58d13f"), null, null, "Shyann.Leuschke64@hotmail.com", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("e7fa9a20-84d7-43e5-b99f-65e2e19de8af"), null, null, "Adolfo31@hotmail.com", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("e8193c6b-0bd2-475b-9a80-03a6fb44dd3f"), null, null, "Zachery.Kuphal90@gmail.com", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("e84178be-9143-48c1-b1ca-7069dfce0347"), null, null, "Cristal_Little@yahoo.com", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("e8831e1b-5aa6-4b59-9158-a0786491a341"), null, null, "Maud59@hotmail.com", false, new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d") },
                    { new Guid("e89bdfc0-4c7f-461f-a0ee-6d8c15b6dcae"), null, null, "Christy55@hotmail.com", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("e96dd572-1a39-4909-8bb8-d75320622783"), null, null, "Margaretta_Rath64@yahoo.com", false, new Guid("45649949-0283-499e-b496-44660ddab1e4") },
                    { new Guid("ea1391b6-ff56-40d9-88e0-9d6779c8c015"), null, null, "Gilbert_Simonis66@yahoo.com", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("ea410689-6c54-4b00-8fa6-18beb4034b47"), null, null, "Jimmie_Muller81@gmail.com", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("ea5ae46f-c3b5-47ce-86f8-d0ee1e21456b"), null, null, "Eula45@gmail.com", false, new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ea813c27-cd7e-4bfe-b49e-4ea8c0214b8d"), null, null, "Fannie.Williamson66@gmail.com", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("eaae3235-57cb-498b-8bec-c705b40892cc"), null, null, "Adalberto_DAmore@gmail.com", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("eb11e67d-6a7e-4dba-850c-dbbc26a353bc"), null, null, "Zita.Kautzer@gmail.com", false, new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9") },
                    { new Guid("eb6e0621-a76e-4c2e-b88a-b0a393b4cf53"), null, null, "Ora_Stroman@hotmail.com", false, new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c") },
                    { new Guid("ec000875-ef7a-48ee-8729-4c5044cb2858"), null, null, "Cedrick_Satterfield52@gmail.com", false, new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("ec64d5f8-5382-4abb-918b-7d435fb82af0"), null, null, "Cecil39@gmail.com", false, new Guid("8be83005-0ddc-42eb-877d-582666d35fea") },
                    { new Guid("ecca85eb-dd57-4eb7-abbe-88d0fb5d2fbb"), null, null, "Rosemary.Oberbrunner35@hotmail.com", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("ece4f493-2c5b-46fc-ae55-059b88eea9ae"), null, null, "Kiara.Flatley57@yahoo.com", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("ecf10f2c-42ae-4688-b1af-aaaa26ba0e2d"), null, null, "Kayleigh.Abernathy@yahoo.com", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("ed647183-2275-42c0-9650-51d0c0d2655d"), null, null, "Katelyn_Reynolds59@gmail.com", false, new Guid("617100a1-d830-4170-9964-86b27fc31a31") },
                    { new Guid("ed980f06-b92a-45ac-b38d-a49b85447ee1"), null, null, "Luther.Beier60@gmail.com", false, new Guid("99484890-5bb7-47f9-b211-218700e48dad") },
                    { new Guid("edc75f3d-105c-411e-b373-df8938a7f511"), null, null, "Pattie95@hotmail.com", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("edeb647a-9a6c-4e6a-aee5-e4ed09bd6e3d"), null, null, "Lyric87@yahoo.com", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("ee348032-4f67-423c-adef-c4222575b59e"), null, null, "Jaden69@gmail.com", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("ee5c2c5b-df75-4c6f-b57f-3617709e2bd4"), null, null, "Halie.Dicki59@gmail.com", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("eed046e3-d8c6-4939-856d-377ef23f1359"), null, null, "Ari31@gmail.com", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("eee9d538-fc0b-4c7f-b475-d5ba8e1c7e7f"), null, null, "Keegan_Wiegand64@yahoo.com", false, new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("eefeaf6c-6275-4e89-98b1-6439e5da6cac"), null, null, "Rhianna21@yahoo.com", false, new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219") },
                    { new Guid("ef2df83d-9202-4fb4-8c58-22498d92656c"), null, null, "Noelia95@gmail.com", false, new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942") },
                    { new Guid("efe0accf-7f93-4e69-b9c2-0fed29ea77b5"), null, null, "Tessie_Fisher54@yahoo.com", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("f034cfc9-f1cb-4231-bf45-acc86e868563"), null, null, "Milan_Hermiston12@yahoo.com", false, new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7") },
                    { new Guid("f042a5db-21c6-4b77-b240-00c1386ca2c2"), null, null, "Maudie_Gutkowski@gmail.com", false, new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7") },
                    { new Guid("f0a50cb2-8390-41d8-bdf2-ec762fe84b56"), null, null, "Daisy94@gmail.com", false, new Guid("cc9fd67a-df81-4c57-9231-20a528617118") },
                    { new Guid("f143e81a-bf68-4335-89c9-59d321e99bd3"), null, null, "Alysa64@hotmail.com", false, new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44") },
                    { new Guid("f1477f9f-d01f-4580-857d-885bb509d52a"), null, null, "Flavie21@gmail.com", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("f23fab4c-3612-4f8b-9b35-50037606975c"), null, null, "Aylin.Abbott25@yahoo.com", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("f3411c7b-3685-400f-b271-69637d1db112"), null, null, "Rosario.Lockman@hotmail.com", false, new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa") },
                    { new Guid("f360f53b-c682-4017-a528-564351753ff4"), null, null, "Raina_Frami99@yahoo.com", false, new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228") },
                    { new Guid("f3acee66-6af4-475b-a40e-1ca479e5e537"), null, null, "Larissa59@yahoo.com", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("f4094a77-3b90-4594-965f-fcbb0ae280d7"), null, null, "Waylon_Torp@gmail.com", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("f412f163-dc6e-418f-a68a-d6dc1f3d9290"), null, null, "Jaden.Rippin@hotmail.com", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("f43cd07d-5853-4846-8a47-6107fdd4bccd"), null, null, "Kristina_Mayer@hotmail.com", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("f483a405-0cad-4b10-8a8e-b2a21fccfeff"), null, null, "Hosea83@yahoo.com", false, new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a") },
                    { new Guid("f496ca3f-e2d8-4d24-b0c2-c3d260942c4f"), null, null, "Cornelius.Marquardt65@hotmail.com", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("f4ba7e2d-7a5c-489a-89f9-11d23f4b24cb"), null, null, "Ladarius47@yahoo.com", false, new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9") },
                    { new Guid("f50b6e5d-533f-46eb-bdcb-908371b54706"), null, null, "Kaya.Hackett@yahoo.com", false, new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9") },
                    { new Guid("f5ebd52c-e9a4-4f07-a875-6e5d90ee0802"), null, null, "Hillary.Goodwin@gmail.com", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("f5ec4bbd-6e2f-40bd-98ce-e3459826b707"), null, null, "Cade_Schaden92@yahoo.com", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("f604c25e-b262-407b-88a1-cb41be6cd517"), null, null, "Lazaro_Legros@hotmail.com", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("f627b23b-c139-4299-8430-059d2eb962c2"), null, null, "Marcel_Daniel24@hotmail.com", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("f6b6ed25-5bba-45b3-a0f4-838dff0c7761"), null, null, "Amani.Blanda86@gmail.com", false, new Guid("80ed64a5-2f87-4262-aed3-901da3da1369") },
                    { new Guid("f71286e3-3ea8-443f-82fa-4be783968ff2"), null, null, "Nella62@yahoo.com", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f744533c-14c3-4b75-860c-b8581f018582"), null, null, "Cristian_Schultz@yahoo.com", false, new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45") },
                    { new Guid("f7bc36f9-7a30-4358-9c4b-e3e931b7db5c"), null, null, "Wyatt.Volkman19@hotmail.com", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("f7c0cc79-d217-4ce6-b06b-a7369905fb93"), null, null, "Rico43@gmail.com", false, new Guid("78016c36-672a-4efd-980e-250a79e4d32e") },
                    { new Guid("f8063975-069b-4aed-9269-b1c3e1353e70"), null, null, "Marianne_Lesch82@yahoo.com", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("f8c5f153-a312-4915-8bba-e87fd1c34395"), null, null, "Vergie8@hotmail.com", false, new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942") },
                    { new Guid("f91fceb2-2806-4c00-9a56-e68e9384b201"), null, null, "Albin91@hotmail.com", false, new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4") },
                    { new Guid("f9c3acf6-6274-4ed4-a1b4-1775193dd655"), null, null, "Esperanza_Ortiz@yahoo.com", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("f9f3ebec-068a-4bcb-86d8-b03a33b47120"), null, null, "Toney_Beier58@gmail.com", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("fa6c01d4-e642-4446-82ef-9b4642840bf1"), null, null, "Dejah_Schultz60@gmail.com", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("fa6f3861-770d-4e96-a90c-a6a47325f4aa"), null, null, "Kelvin_Larkin@hotmail.com", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("fa9e6e14-50a3-4853-ab61-d889d65dfc37"), null, null, "Dayana.Collins57@yahoo.com", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("fab9e1ac-14be-409a-945f-521964d9505f"), null, null, "Suzanne97@hotmail.com", false, new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372") },
                    { new Guid("faef4039-3baf-4a86-886d-30f661eb1455"), null, null, "Lenora.Reichel@hotmail.com", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("fb2d8ce8-5c0a-48bf-91d8-b50fa4bf08fb"), null, null, "Breanne_Bode@yahoo.com", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("fbbd1a35-0f66-4828-b766-351ac795f14a"), null, null, "Austen.Mayer86@yahoo.com", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("fc2378e5-1e90-4250-9afe-6acba5b61f34"), null, null, "Kianna82@gmail.com", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("fc7bed1c-eaf5-4ef0-881a-b1fcf022fb93"), null, null, "Sylvester26@hotmail.com", false, new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("fce14803-443f-4b4e-acf2-d29d708a33f7"), null, null, "Olen.Hartmann@gmail.com", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("fd29f577-00e2-48b7-8f83-c058af02ee93"), null, null, "Salvador91@hotmail.com", false, new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018") },
                    { new Guid("fd37ad9c-4fd2-4b6b-8791-36b51145454a"), null, null, "Rosa.Graham@gmail.com", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("fd55723a-d454-47fb-b9b6-2e85d04ecd8f"), null, null, "Theodora.Wyman@yahoo.com", false, new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2") },
                    { new Guid("fd79d9da-bebf-4136-b478-e339b71b0d66"), null, null, "Katharina_Anderson33@gmail.com", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("fd943de2-ed21-410f-969c-308dea23394b"), null, null, "Sarai33@hotmail.com", false, new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799") },
                    { new Guid("fdadf8cb-96cd-4e3a-a056-501173128f69"), null, null, "Marquise_Dach@hotmail.com", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("fdbd3794-528b-4343-bac8-7ab0586972d3"), null, null, "Rowan_Mayert@gmail.com", false, new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73") },
                    { new Guid("fdbff80b-6793-4b1d-afb5-71a19edfb526"), null, null, "Collin.MacGyver26@yahoo.com", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("fde9b7c3-a9cd-4eb5-9e13-1a9893bf9f2c"), null, null, "Emmalee70@gmail.com", false, new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca") },
                    { new Guid("fee7a234-21ff-4e17-80e0-a19df4b073d7"), null, null, "Elijah79@yahoo.com", false, new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731") },
                    { new Guid("ff3afb98-42ba-40c4-9c20-aef311c727f8"), null, null, "Hiram.Metz@yahoo.com", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("ffc2e24f-26fd-4720-a84c-2ddf054a2e0a"), null, null, "Brenden_Mills@yahoo.com", false, new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("03eb06ab-ffce-4d53-b317-13ea3f64e59d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 19, 6, 15, 39, 499, DateTimeKind.Local).AddTicks(3250), new DateTime(2023, 7, 22, 6, 15, 39, 499, DateTimeKind.Local).AddTicks(3250), null, 80.97m, true, 4200764468986980m, true, "Super", 2, 4.451131f, "30171 Bernhard Squares, Hilpertport, Angola", new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec"), "3315 Evangeline Causeway, South Saraihaven, American Samoa", new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("073732bb-d4cf-47f9-a877-b38881203b05"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 18, 22, 19, 36, 202, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 12, 28, 22, 19, 36, 202, DateTimeKind.Local).AddTicks(7419), null, 30.62m, 9836965248988420m, true, "Standart", 4, 24.808636f, "08817 Turcotte Drive, Luzton, Antarctica (the territory South of 60 deg S)", new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748"), "481 Irwin Greens, Valentinaton, Croatia", new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("07a325a4-e184-4635-9456-f8c8d8e7edce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 15, 11, 52, 58, 176, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 9, 23, 11, 52, 58, 176, DateTimeKind.Local).AddTicks(8370), null, 67.33m, true, 1857167898268072m, true, "Courier", 1, 43.27885f, "7121 Nikolas Bridge, New Hettie, San Marino", new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379"), "69516 Hannah Mall, Lake Hertahaven, Saint Pierre and Miquelon", new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("07d0b4b6-81b9-4ccd-9c97-f40518caae1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 26, 12, 37, 30, 971, DateTimeKind.Local).AddTicks(6320), new DateTime(2024, 3, 30, 12, 37, 30, 971, DateTimeKind.Local).AddTicks(6320), null, 14.92m, 1640626197500094m, true, "Special", 1, 0.8180891f, "232 Lucas Estates, Santinohaven, Seychelles", new Guid("88fbd469-d541-4e89-9736-988ca894e0e8"), "243 Johnson Cliff, South Adam, French Guiana", new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("0e5045fa-5e4c-47d7-8147-3f676b215ddb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 11, 12, 33, 54, 858, DateTimeKind.Local).AddTicks(3317), new DateTime(2023, 10, 17, 12, 33, 54, 858, DateTimeKind.Local).AddTicks(3317), null, 46.04m, true, 5047303155531911m, "Special", 1, 40.10124f, "03139 Johnson Circles, Nolanton, Netherlands", new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4"), "12298 Kenneth Cape, West Arjunburgh, Tunisia", new Guid("4f03daca-02fb-425a-a575-bef52173e4d3"), "Delivered", "CardboardBox" },
                    { new Guid("12528027-11dc-4bfb-b31e-9135bd0b0e6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 31, 4, 31, 14, 316, DateTimeKind.Local).AddTicks(9316), new DateTime(2024, 1, 1, 4, 31, 14, 316, DateTimeKind.Local).AddTicks(9316), null, 11.58m, true, 7786778852974642m, "Standart", 1, 40.961952f, "35127 Milford Spring, East Jevonchester, Argentina", new Guid("80ed64a5-2f87-4262-aed3-901da3da1369"), "841 Elda Trafficway, West Alexisborough, Faroe Islands", new Guid("88fbd469-d541-4e89-9736-988ca894e0e8"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("148ee761-7b9b-444b-832d-317fd8d6ebaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 9, 17, 1, 1, 216, DateTimeKind.Local).AddTicks(1257), new DateTime(2023, 10, 19, 17, 1, 1, 216, DateTimeKind.Local).AddTicks(1257), null, 33.49m, 7241528418355596m, "Courier", 2, 18.838818f, "157 Ferry Light, Port Humberto, Sierra Leone", new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc"), "799 Borer Ways, Lake Ralphport, Bouvet Island (Bouvetoya)", new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d"), "Registered", "PlasticBag" },
                    { new Guid("14ec0c41-c397-4361-b9b6-b0f4d3c1de8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 31, 16, 36, 49, 63, DateTimeKind.Local).AddTicks(7264), new DateTime(2024, 4, 10, 16, 36, 49, 63, DateTimeKind.Local).AddTicks(7264), null, 42.02m, 5472821897991880m, "Special", 2, 46.888306f, "05405 Maggio Field, New Geoffreyfurt, Lebanon", new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6"), "628 Natalia Route, Naomiebury, Algeria", new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1987c25b-e00b-4d71-803a-21fcb0cb8c23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 30, 3, 52, 52, 823, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 8, 7, 3, 52, 52, 823, DateTimeKind.Local).AddTicks(8995), null, 73.83m, true, 9269079445548122m, "Super", 2, 18.960846f, "32005 Teagan Manors, Lefflerstad, Bosnia and Herzegovina", new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63"), "509 Bailey Mill, Camronbury, Somalia", new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("1c64b2fe-97b1-48be-8222-20f2335654bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 6, 2, 49, 26, 814, DateTimeKind.Local).AddTicks(3374), new DateTime(2023, 9, 8, 2, 49, 26, 814, DateTimeKind.Local).AddTicks(3374), null, 64.45m, 6984208567925750m, "ParcelMachine", 4, 17.897654f, "62108 Wolf Route, New Stevie, Iceland", new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b"), "623 Hermiston Flat, New Orlandside, Guadeloupe", new Guid("1253df08-c182-4a6b-bbe3-05f888b56553"), "Registered", "PlasticBag" },
                    { new Guid("1c74378e-6762-41ea-aabb-b8f61d81a3ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 4, 14, 40, 44, 642, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 10, 5, 14, 40, 44, 642, DateTimeKind.Local).AddTicks(2380), null, 53.37m, 7061536545775702m, "Super", 5, 8.38224f, "0867 Wiza Radial, Cristfort, Zambia", new Guid("35187412-3a05-415f-8523-ec24e84b1221"), "4451 Michael Park, Leschton, Ecuador", new Guid("862a826f-0eba-4891-9241-dff3a8896969"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1e227165-0f4d-4360-bbb5-1c935de81ea9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 5, 16, 22, 24, 432, DateTimeKind.Local).AddTicks(7453), new DateTime(2024, 5, 6, 16, 22, 24, 432, DateTimeKind.Local).AddTicks(7453), null, 11.42m, true, 6102845164702836m, "Special", 4, 32.517574f, "1408 Cristina Terrace, South Christellemouth, Benin", new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d"), "31945 Schimmel Parkways, Rosemaryton, Niger", new Guid("0b98923c-0481-432f-9b60-33427e4d8223"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1e8d2d13-fc3c-4e48-892b-bcb1df21d6a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 13, 20, 49, 5, 592, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 7, 21, 20, 49, 5, 592, DateTimeKind.Local).AddTicks(1896), null, 12.64m, 1858463218909528m, true, "Super", 2, 44.533443f, "1325 Karley Track, Kennyfurt, Hungary", new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689"), "9519 Ziemann Shoals, North Jaidenbury, Syrian Arab Republic", new Guid("94aaefbb-3b69-4a12-8609-44039863dc44"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("225ebfb4-ac6b-41e7-996d-49c07d1ddc87"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 14, 5, 48, 3, 329, DateTimeKind.Local).AddTicks(2497), new DateTime(2024, 2, 16, 5, 48, 3, 329, DateTimeKind.Local).AddTicks(2497), null, 11.86m, true, 3240325457264422m, true, "Super", 1, 8.322538f, "21861 Pagac Rapids, Barrowschester, Ireland", new Guid("6b1f032f-060a-4040-879c-9d1305d38b12"), "515 Lueilwitz Pass, Corkeryland, Turkmenistan", new Guid("816326af-094b-4b97-b10b-548a2296766b"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("25453b83-3624-4883-9265-972dfb32485b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 22, 10, 46, 22, 773, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 12, 30, 10, 46, 22, 773, DateTimeKind.Local).AddTicks(4061), null, 82.22m, true, 9658533486905772m, "Super", 3, 19.70546f, "114 Devonte Turnpike, Lillianachester, Oman", new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178"), "67161 Dickens Islands, Port Lauriannestad, Cayman Islands", new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("25cb106f-5de7-46bc-ae3f-218134120766"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 5, 20, 4, 7, 377, DateTimeKind.Local).AddTicks(6055), new DateTime(2024, 5, 15, 20, 4, 7, 377, DateTimeKind.Local).AddTicks(6055), null, 21.38m, true, 6175179065686940m, true, "Standart", 2, 26.98543f, "9744 Helene Union, Lucileville, China", new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a"), "96855 Jayson Groves, New Verdabury, Portugal", new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("26f00603-9936-4898-8a44-0f44c1fd0100"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 25, 17, 3, 31, 215, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 10, 27, 17, 3, 31, 215, DateTimeKind.Local).AddTicks(7347), null, 75.63m, 2343001542906567m, true, "Special", 3, 48.328823f, "301 Libbie Turnpike, South Dedric, Kazakhstan", new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e"), "558 Huels Greens, Aufderharview, Kazakhstan", new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("27a73829-fd22-4122-83af-4ddee833ea74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 21, 2, 27, 5, 819, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 9, 30, 2, 27, 5, 819, DateTimeKind.Local).AddTicks(8168), null, 25.73m, true, 8515252155830436m, "Courier", 3, 0.4023158f, "58856 Adams Fort, North Lillychester, Aruba", new Guid("52698753-1196-4fd7-83fd-4670d8d55456"), "8309 Green Highway, South Alberthabury, Somalia", new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2a30bc02-4a19-4f12-ae89-28a8e8eaec57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 7, 23, 21, 12, 803, DateTimeKind.Local).AddTicks(4281), new DateTime(2024, 1, 17, 23, 21, 12, 803, DateTimeKind.Local).AddTicks(4281), null, 36.49m, 4152209297604459m, "Special", 4, 36.65496f, "596 Ortiz Landing, Serenityville, Western Sahara", new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783"), "382 Little Landing, Lake Kobyhaven, French Southern Territories", new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2c350bd0-8003-48cb-a8f3-164be24b58d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 7, 6, 58, 31, 990, DateTimeKind.Local).AddTicks(6184), new DateTime(2024, 1, 12, 6, 58, 31, 990, DateTimeKind.Local).AddTicks(6184), null, 33.19m, true, 1618965122965464m, "Special", 2, 15.629009f, "877 Kenny Street, East Melvinfort, Slovakia (Slovak Republic)", new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4"), "917 Constance Shores, Murphyview, Netherlands Antilles", new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2c4b2e16-2cc9-4fd7-a2b8-e949fe481980"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 3, 6, 25, 46, 190, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 8, 9, 6, 25, 46, 190, DateTimeKind.Local).AddTicks(5629), null, 78.71m, 4160699345103239m, true, "ParcelMachine", 2, 21.727058f, "888 Olson Port, North Effie, Kazakhstan", new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1"), "89198 Lucile Springs, Dickistad, United Kingdom", new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2cccaa75-8bff-4fea-98cc-3247fd42a851"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 5, 1, 48, 49, 409, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 7, 11, 1, 48, 49, 409, DateTimeKind.Local).AddTicks(1577), null, 84.24m, true, 6267583566004432m, true, "Super", 2, 0.109863624f, "36460 Lourdes Isle, South Stanley, Iraq", new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd"), "135 America Plains, Camilleville, Saint Martin", new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2e9a533b-91ff-4b7d-9bf1-3337b20ad766"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 19, 22, 10, 7, 696, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 9, 23, 22, 10, 7, 696, DateTimeKind.Local).AddTicks(2278), null, 27.45m, true, 3670790227533402m, "Special", 4, 11.143102f, "0944 Walsh Parks, Farrellhaven, Niue", new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), "903 Abdiel Inlet, West Austyn, Malaysia", new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3023ca30-55cf-4635-9c51-886df462f4a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 29, 15, 30, 20, 323, DateTimeKind.Local).AddTicks(6401), new DateTime(2024, 2, 7, 15, 30, 20, 323, DateTimeKind.Local).AddTicks(6401), null, 37.91m, 9466454986122014m, true, "ParcelMachine", 4, 44.431915f, "74663 Bauch Mall, West Rosie, Togo", new Guid("d8d1525f-e931-4e18-a476-365f02c6e363"), "479 Wehner Manor, New Dwight, Turkey", new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("33732498-710e-4465-b398-0f7d13ba256a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 15, 14, 51, 59, 601, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 6, 20, 14, 51, 59, 601, DateTimeKind.Local).AddTicks(8894), null, 36.24m, true, 1071224062496646m, true, "Standart", 1, 7.089825f, "96665 Katlynn Ferry, Aufderharshire, Tunisia", new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500"), "14235 Emelie Radial, North Hiram, Ukraine", new Guid("ce1f07b6-54d9-4379-9845-3751b9499199"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("36046d04-711a-435a-834b-80d4eb571096"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 30, 3, 22, 7, 246, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 2, 9, 3, 22, 7, 246, DateTimeKind.Local).AddTicks(6557), null, 25.88m, 4489470955101926m, "ParcelMachine", 1, 5.7759047f, "9423 Araceli Mill, Ziemebury, Reunion", new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd"), "11815 Ledner Shoals, Adriannaton, Austria", new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("426db315-ae90-42cd-8be7-123c45461d62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 15, 16, 18, 17, 328, DateTimeKind.Local).AddTicks(4963), new DateTime(2024, 5, 22, 16, 18, 17, 328, DateTimeKind.Local).AddTicks(4963), null, 86.47m, true, 3679009452201109m, true, "Courier", 3, 45.600956f, "242 Marks Neck, Lake Tristianberg, Jamaica", new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811"), "428 Abshire Motorway, West Toreyside, Poland", new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5"), "Return", "PlasticBag" },
                    { new Guid("44955473-e23d-41e0-8fba-f12df01a20b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 21, 5, 30, 35, 764, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 2, 28, 5, 30, 35, 764, DateTimeKind.Local).AddTicks(6281), null, 34.57m, true, 6588275443205760m, true, "Standart", 3, 40.981995f, "064 Moore Freeway, Edythville, Ireland", new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae"), "738 Cassin Estate, Vernonton, Mozambique", new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("44ec5cba-d0cb-4e53-bc41-8ed86f23bf0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 3, 12, 4, 8, 2, DateTimeKind.Local).AddTicks(3336), new DateTime(2024, 5, 12, 12, 4, 8, 2, DateTimeKind.Local).AddTicks(3336), null, 22.49m, 6295563865400682m, "Special", 3, 1.9496295f, "5887 Eliseo Glen, South Makenziehaven, Sweden", new Guid("fb455a22-8198-413a-89a8-e92c01f42483"), "78452 Selmer Roads, Larsontown, Puerto Rico", new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1"), "Registered", "CardboardBox" },
                    { new Guid("47af0a4a-930c-4346-9024-3d2f93222c08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 6, 8, 50, 26, 631, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 4, 16, 8, 50, 26, 631, DateTimeKind.Local).AddTicks(723), null, 56.21m, 8039642442084907m, "Super", 1, 18.13734f, "11061 Destiney Well, Asiashire, New Caledonia", new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9"), "63348 Donnelly Prairie, Connellyton, Costa Rica", new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da"), "OnTheWay", "CardboardBox" },
                    { new Guid("48a0c8b4-6c1f-49f0-9142-a3b7cb8172af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 14, 16, 46, 44, 34, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 6, 19, 16, 46, 44, 34, DateTimeKind.Local).AddTicks(8250), null, 70.61m, 5034079505811259m, "Super", 3, 35.369072f, "15038 Rolfson Pines, Annaport, Bolivia", new Guid("99484890-5bb7-47f9-b211-218700e48dad"), "2587 Cole Garden, Marcushaven, Brunei Darussalam", new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("48f10772-3872-450f-a842-7c5b1788342e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 3, 15, 40, 52, 924, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 5, 4, 15, 40, 52, 924, DateTimeKind.Local).AddTicks(4594), null, 94.37m, true, 8337933730812389m, true, "Special", 4, 39.533924f, "91123 Collins Wall, Carolynburgh, Eritrea", new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6"), "287 Farrell Points, Port Geovanniville, Democratic People's Republic of Korea", new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5a645893-8114-461c-b8b1-44c57fa82feb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 21, 20, 16, 6, 556, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 1, 28, 20, 16, 6, 556, DateTimeKind.Local).AddTicks(8671), null, 84.68m, 5317552979455470m, "Special", 1, 49.92582f, "6993 Wintheiser Walk, West Luella, Suriname", new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f"), "6801 Lindgren Squares, East Salvatoreville, British Indian Ocean Territory (Chagos Archipelago)", new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5bb79194-0cea-4c11-9304-dbb7e107493f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 15, 8, 33, 36, 840, DateTimeKind.Local).AddTicks(5235), new DateTime(2024, 4, 25, 8, 33, 36, 840, DateTimeKind.Local).AddTicks(5235), null, 99.87m, true, 4609633651439292m, "Standart", 4, 12.758503f, "803 Stoltenberg Forest, New Jody, Marshall Islands", new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9"), "15253 Reynolds Tunnel, Celinemouth, Zambia", new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5e5a79a9-37da-4c02-bf50-cf0355e4a06e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 7, 15, 49, 48, 602, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 11, 17, 15, 49, 48, 602, DateTimeKind.Local).AddTicks(4193), null, 95.65m, 1664108369982375m, "Standart", 4, 20.488018f, "07623 Hintz Forest, Devanmouth, Bahamas", new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d"), "576 Melyna Turnpike, Kaceyview, Equatorial Guinea", new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6561c46e-9926-4fe4-94f6-b0b45ed86001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 25, 18, 43, 5, 636, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 2, 3, 18, 43, 5, 636, DateTimeKind.Local).AddTicks(8714), null, 58.03m, true, 6365241822853975m, "Super", 4, 14.140649f, "74873 Rogahn Fort, New Odaton, Armenia", new Guid("30b2066d-f465-42ae-93e3-4a38936052b2"), "0534 Bradtke Gateway, Bechtelarside, Fiji", new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("65c8382f-7c32-4a8f-b81d-bde5cb4b5809"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 16, 3, 14, 18, 369, DateTimeKind.Local).AddTicks(5468), new DateTime(2024, 4, 25, 3, 14, 18, 369, DateTimeKind.Local).AddTicks(5468), null, 52.67m, true, 6351466012667537m, true, "ParcelMachine", 3, 41.610844f, "7132 Herman Stream, Langton, Israel", new Guid("1154048c-cc8b-409f-a802-5dbe51d20548"), "76479 Koss Causeway, Marlonville, Jordan", new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70"), "Return", "CardboardBox" },
                    { new Guid("680031d8-712f-43fd-8e3f-5dff95865667"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 19, 3, 23, 44, 82, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 5, 22, 3, 23, 44, 82, DateTimeKind.Local).AddTicks(4796), null, 51.94m, true, 4480687298606270m, true, "Courier", 4, 9.475592f, "83710 Creola Mission, Farrellside, Liberia", new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f"), "841 Steuber Vista, South Marciaview, Romania", new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024"), "Registered", "PlasticBag" },
                    { new Guid("6a4376cc-f427-4297-ac10-9d8a7d63e508"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 6, 7, 2, 31, 822, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 6, 8, 7, 2, 31, 822, DateTimeKind.Local).AddTicks(1831), null, 85.17m, true, 6759805112143017m, true, "Special", 2, 29.988213f, "896 Ullrich Wells, East Lucinda, Eritrea", new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b"), "48562 Aiden Branch, Kertzmannville, Thailand", new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("6aa716f5-9d4d-4a64-a94b-c4a97ff2a09c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 8, 13, 17, 28, 133, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 11, 13, 13, 17, 28, 133, DateTimeKind.Local).AddTicks(7433), null, 76.89m, 9994755281922620m, true, "Standart", 3, 21.691055f, "5668 Adele Hill, Elainaville, Micronesia", new Guid("0b98923c-0481-432f-9b60-33427e4d8223"), "75532 Rodriguez Knoll, New Hettiebury, Slovenia", new Guid("748062f3-9c55-4b5c-9d17-429dac03b923"), "Sent", "CardboardBox" },
                    { new Guid("6ac48ebd-2b85-4720-91e0-f831f4cd61eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 16, 36, 0, 118, DateTimeKind.Local).AddTicks(810), new DateTime(2023, 11, 17, 16, 36, 0, 118, DateTimeKind.Local).AddTicks(810), null, 69.23m, 7889064450977531m, true, "Super", 2, 25.799097f, "30107 Greenfelder Isle, Lake Elena, Vanuatu", new Guid("0f9851be-b682-479e-aec8-51795a73a90e"), "652 Jarrett Corners, West Thora, Bolivia", new Guid("cc9fd67a-df81-4c57-9231-20a528617118"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7366a8b0-f70f-420e-a4f0-2e5f97208a3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 21, 16, 43, 34, 749, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 10, 26, 16, 43, 34, 749, DateTimeKind.Local).AddTicks(6742), null, 66.20m, true, 5320622625437788m, true, "Standart", 4, 19.97678f, "6293 Dietrich Track, McClureburgh, Cayman Islands", new Guid("3e1827bb-2cfc-4263-be79-7b663816638e"), "2401 Kylee Crossroad, New Hulda, Niue", new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("75e8966b-00c1-4faa-8bfa-02d6d48cf89c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 8, 17, 32, 27, 97, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 8, 16, 17, 32, 27, 97, DateTimeKind.Local).AddTicks(7306), null, 87.24m, 2177841154214985m, true, "Super", 2, 41.27742f, "715 Ricardo Port, Mertzport, Morocco", new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9"), "3525 Orland Drive, Bauchstad, Tokelau", new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("76b79ea0-16c5-4c66-b3b8-ab82637b482b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 15, 22, 53, 8, 716, DateTimeKind.Local).AddTicks(6111), new DateTime(2024, 3, 18, 22, 53, 8, 716, DateTimeKind.Local).AddTicks(6111), null, 83.90m, 7725136787476349m, "Standart", 4, 20.560154f, "560 Rosie Hollow, Mertieside, Spain", new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc"), "6990 Jaskolski Plaza, East Annette, Tuvalu", new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1"), "Registered", "CardboardBox" },
                    { new Guid("78444ca1-6b5d-4e5a-8aaf-c00db62f0f5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 23, 14, 25, 1, 64, DateTimeKind.Local).AddTicks(9538), new DateTime(2024, 2, 2, 14, 25, 1, 64, DateTimeKind.Local).AddTicks(9538), null, 85.12m, 4649875204819989m, "Standart", 1, 28.472403f, "268 Meghan Views, Ankundingmouth, Guernsey", new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811"), "517 Grimes Common, New Wilton, Mali", new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7910fe5e-9fd3-4000-8cd9-d77775fe7f1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 30, 1, 37, 23, 215, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 4, 9, 1, 37, 23, 215, DateTimeKind.Local).AddTicks(2902), null, 13.32m, true, 4521055048684518m, true, "Super", 5, 4.41096f, "411 Austin Villages, Teresaborough, Turkmenistan", new Guid("83059c11-6c07-4892-a0cb-ced177c551d8"), "54011 Herzog Extensions, Elliotville, Kenya", new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("794a8b95-8f27-44f0-9f2c-9f27f265b065"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 30, 17, 27, 54, 775, DateTimeKind.Local).AddTicks(152), new DateTime(2024, 5, 2, 17, 27, 54, 775, DateTimeKind.Local).AddTicks(152), null, 51.52m, true, 3493131288709798m, "Standart", 4, 42.123466f, "51787 Odessa Keys, East Marge, Guyana", new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1"), "7466 Emmanuel Curve, South Cullen, Czech Republic", new Guid("94aaefbb-3b69-4a12-8609-44039863dc44"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7ba41ed3-23d4-4359-aaac-aa0effad2857"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 2, 12, 46, 59, 394, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 4, 10, 12, 46, 59, 394, DateTimeKind.Local).AddTicks(8584), null, 84.81m, 7486879570881267m, true, "Courier", 5, 13.942377f, "849 Faustino Greens, Candidofort, Northern Mariana Islands", new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8"), "51598 Carol Hill, Ashlynnberg, Timor-Leste", new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7d60d32c-8d14-4d73-8278-156d59d08015"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 21, 13, 10, 49, 929, DateTimeKind.Local).AddTicks(3254), new DateTime(2023, 8, 26, 13, 10, 49, 929, DateTimeKind.Local).AddTicks(3254), null, 53.93m, 1945120378418563m, "Standart", 3, 43.09253f, "2184 Ettie Haven, North Mathias, Micronesia", new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30"), "22952 Feil Summit, Gudrunview, Denmark", new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7ddec779-af01-4996-8dfd-d9ea4f70b5b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 1, 19, 48, 5, 730, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 10, 11, 19, 48, 5, 730, DateTimeKind.Local).AddTicks(4455), null, 81.06m, 3550011277378204m, true, "Courier", 1, 40.995388f, "277 Cruickshank Roads, Kihnburgh, New Zealand", new Guid("19034493-ddce-4219-8d74-fbdd26d02300"), "69957 Jailyn Rue, New Durwardberg, Qatar", new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7e67b763-3314-47bf-86b6-c28a9d431119"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 22, 17, 29, 54, 451, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 4, 27, 17, 29, 54, 451, DateTimeKind.Local).AddTicks(4221), null, 20.08m, true, 3316515712779516m, true, "ParcelMachine", 4, 28.842197f, "4281 Mekhi Gateway, East Babyport, Wallis and Futuna", new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8"), "8056 Jakayla Pines, New Paytonborough, Denmark", new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7e820c8f-12b2-48ef-b045-96a55253d677"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 25, 16, 57, 18, 598, DateTimeKind.Local).AddTicks(4002), new DateTime(2023, 10, 26, 16, 57, 18, 598, DateTimeKind.Local).AddTicks(4002), null, 93.38m, 4905721327773773m, "Super", 2, 4.763587f, "538 Olaf Square, Runteberg, Democratic People's Republic of Korea", new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef"), "99333 Celine Lodge, Ricestad, Republic of Korea", new Guid("35187412-3a05-415f-8523-ec24e84b1221"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7e9c593b-e891-4212-9c0b-c5026d6caa2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 22, 23, 48, 42, 127, DateTimeKind.Local).AddTicks(1194), new DateTime(2024, 4, 24, 23, 48, 42, 127, DateTimeKind.Local).AddTicks(1194), null, 36.38m, true, 2189756205089110m, true, "ParcelMachine", 3, 15.789833f, "132 Prosacco Lock, South Jakaylastad, Iraq", new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), "53634 Pfannerstill Meadows, Jastville, Lithuania", new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("80d56db5-9feb-4106-89aa-b33c77c101aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 4, 16, 32, 879, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 11, 6, 4, 16, 32, 879, DateTimeKind.Local).AddTicks(2674), null, 74.76m, true, 3449976814705882m, "Standart", 4, 42.393276f, "2204 Dulce Union, Port Hardy, Macao", new Guid("0f9851be-b682-479e-aec8-51795a73a90e"), "1099 Lamont Trail, Lake Walkermouth, Anguilla", new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("821b599b-abcb-40bd-b597-ee602d5a2a3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 9, 7, 14, 25, 533, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 8, 13, 7, 14, 25, 533, DateTimeKind.Local).AddTicks(4666), null, 76.84m, 4870208572808794m, "Courier", 4, 44.354473f, "228 Reynolds Radial, Cleoraton, Western Sahara", new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6"), "95197 Delphia Brook, South Bernadette, Belgium", new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("83085931-b31c-4b66-9e99-2d8aec7ea95e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 6, 14, 40, 1, 262, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 5, 15, 14, 40, 1, 262, DateTimeKind.Local).AddTicks(4929), null, 18.95m, 6691905730023959m, true, "Super", 2, 28.746096f, "676 Mohr Throughway, Loweview, Panama", new Guid("b738ba4a-67e6-46e7-a96d-61371262722a"), "17326 Goodwin Vista, East Katrineshire, Equatorial Guinea", new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("836645ca-37db-4e4f-8117-21470d179e0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 9, 10, 2, 39, 556, DateTimeKind.Local).AddTicks(3815), new DateTime(2024, 3, 15, 10, 2, 39, 556, DateTimeKind.Local).AddTicks(3815), null, 91.39m, 6496659030743581m, "Super", 1, 35.244167f, "1766 Kuhic Drives, Stacyton, Portugal", new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2"), "45084 Gerlach Lodge, Wildermanfort, Eritrea", new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("858b5b74-40dc-43e1-89a1-23a90ef576ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 7, 13, 4, 41, 899, DateTimeKind.Local).AddTicks(1672), new DateTime(2024, 1, 9, 13, 4, 41, 899, DateTimeKind.Local).AddTicks(1672), null, 73.11m, 6043287617123578m, true, "ParcelMachine", 5, 42.586758f, "314 Morar Row, West Luciebury, Indonesia", new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d"), "77588 Ted Rapid, Port Walton, Nigeria", new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8"), "Return", "PlasticBag" },
                    { new Guid("862000b4-ae40-403f-9821-1f466bf22bb4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 4, 13, 41, 57, 178, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 4, 12, 13, 41, 57, 178, DateTimeKind.Local).AddTicks(2335), null, 26.49m, 1993077068660587m, true, "Super", 4, 15.371994f, "31346 Jody Turnpike, East Willow, Mauritius", new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1"), "6803 Price Light, Lacyfurt, Falkland Islands (Malvinas)", new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024"), "Delivered", "PlasticBag" },
                    { new Guid("89030be7-a321-4071-81fd-6aad3c8348c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 9, 14, 43, 51, 559, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 12, 13, 14, 43, 51, 559, DateTimeKind.Local).AddTicks(7914), null, 97.91m, 7473735918352075m, true, "ParcelMachine", 4, 3.7112117f, "839 Leanne Mill, Lake Hudson, Zambia", new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae"), "4464 DuBuque Course, Terrencemouth, India", new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8b750cfc-e7ff-45d0-be07-59bf579899a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 26, 18, 30, 36, 993, DateTimeKind.Local).AddTicks(758), new DateTime(2023, 12, 28, 18, 30, 36, 993, DateTimeKind.Local).AddTicks(758), null, 83.77m, true, 5123840898588154m, true, "Standart", 1, 14.828538f, "11462 Conroy Coves, Gabrielleton, South Georgia and the South Sandwich Islands", new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c"), "5691 Marisa Manor, Eliberg, Isle of Man", new Guid("99227d48-6d3f-45fd-971b-83f0198ee703"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8f66cbaf-b5d4-4213-8465-ca1c81367aca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 3, 1, 18, 12, 499, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 4, 7, 1, 18, 12, 499, DateTimeKind.Local).AddTicks(4776), null, 88.41m, 8817954456547255m, true, "ParcelMachine", 2, 6.269483f, "572 Nigel Trace, East Stanfordport, Saint Pierre and Miquelon", new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f"), "9822 Cassin Green, Greenstad, Cameroon", new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("922b5e85-43e4-42c0-b411-d15aca14fbc4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 29, 4, 58, 16, 8, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 9, 1, 4, 58, 16, 8, DateTimeKind.Local).AddTicks(8603), null, 93.20m, true, 9373640790731380m, "Standart", 2, 44.850582f, "01034 Windler Stream, West Lue, Nepal", new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae"), "1331 Ignacio Brooks, Runolfsdottirville, Myanmar", new Guid("f0811698-5de9-42a6-a253-8958ca513eb5"), "Delivered", "CardboardBox" },
                    { new Guid("978d72f1-95e4-440c-8fc9-268a4e0936a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 2, 18, 11, 44, 417, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 10, 5, 18, 11, 44, 417, DateTimeKind.Local).AddTicks(9191), null, 35.07m, true, 7359515026870795m, "ParcelMachine", 4, 34.087074f, "08596 Henriette Forks, New Arelyfurt, Venezuela", new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6"), "5556 Camryn Valleys, Goyetteport, Nicaragua", new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066"), "OnTheWay", "PlasticBag" },
                    { new Guid("9be81352-ea9a-4e7e-9bac-c8c2a5c36f58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 4, 8, 12, 59, 392, DateTimeKind.Local).AddTicks(348), new DateTime(2023, 7, 6, 8, 12, 59, 392, DateTimeKind.Local).AddTicks(348), null, 90.09m, true, 8804280042715817m, "ParcelMachine", 5, 47.952053f, "863 Hartmann Parkway, Lake Ramon, Malawi", new Guid("52f24d75-fa03-403f-8430-5ca835f68726"), "20014 Maribel Park, Peterberg, Lebanon", new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291"), "Sent", "PlasticBag" },
                    { new Guid("9c513d5c-d609-4b28-9981-47724cf08b46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 10, 18, 11, 55, 459, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 2, 20, 18, 11, 55, 459, DateTimeKind.Local).AddTicks(4191), null, 38.73m, true, 3709729243805916m, "Super", 1, 18.618101f, "83975 Monahan Throughway, Hirthefort, Faroe Islands", new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470"), "84132 Muhammad Turnpike, Nitzscheton, Estonia", new Guid("4f80af1c-a1e2-4285-b825-e9802427655e"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9d2265d2-b4e0-41aa-8b7e-2a3af80af91b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 29, 6, 43, 20, 63, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 3, 4, 6, 43, 20, 63, DateTimeKind.Local).AddTicks(9437), null, 88.12m, 3877405503959310m, true, "Super", 1, 36.3166f, "7996 Hershel Place, Dorianbury, Netherlands", new Guid("ce1f07b6-54d9-4379-9845-3751b9499199"), "13374 Jaskolski Knolls, New Daveville, Iran", new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9e9962d7-cae5-4643-9824-2e9beb78ef76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 9, 19, 7, 47, 343, DateTimeKind.Local).AddTicks(3128), new DateTime(2024, 1, 10, 19, 7, 47, 343, DateTimeKind.Local).AddTicks(3128), null, 77.89m, true, 6161305372029737m, "Courier", 1, 31.66775f, "160 Evie Ways, Tromptown, Tuvalu", new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), "315 Thalia Unions, North Raleigh, Ghana", new Guid("f0811698-5de9-42a6-a253-8958ca513eb5"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a1d33689-76d7-431b-8d02-3504fea03471"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 23, 15, 1, 3, 57, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 4, 1, 15, 1, 3, 57, DateTimeKind.Local).AddTicks(5100), null, 53.74m, 1307710247879324m, "ParcelMachine", 1, 0.38120613f, "6524 Myrna Stravenue, Kulasmouth, Sierra Leone", new Guid("77f944f9-c758-4983-b702-656640bf5672"), "837 Genesis Ranch, Aufderhartown, Eritrea", new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a227025a-6aed-49e4-be6a-e6d7cd8f838e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 19, 21, 59, 26, 637, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 12, 21, 21, 59, 26, 637, DateTimeKind.Local).AddTicks(8727), null, 31.07m, true, 8204933633973512m, true, "Standart", 5, 1.9652841f, "722 Brianne Mountain, Gwendolynmouth, Isle of Man", new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420"), "75071 Craig Lodge, Port Cole, Cote d'Ivoire", new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a753ac0a-9ad2-4f75-9827-96a691b043cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 11, 2, 44, 41, 382, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 10, 14, 2, 44, 41, 382, DateTimeKind.Local).AddTicks(7966), null, 58.83m, 4246130918536103m, true, "Super", 4, 9.685565f, "856 Tillman Walk, South Israelhaven, Wallis and Futuna", new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38"), "994 Landen Terrace, North Korbinbury, Sweden", new Guid("19341891-e9b6-407e-aea5-b35513589e26"), "Return", "PlasticBag" },
                    { new Guid("a7cf97d1-c31c-4781-843a-433de9d9c3d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 13, 6, 57, 48, 304, DateTimeKind.Local).AddTicks(7621), new DateTime(2023, 9, 20, 6, 57, 48, 304, DateTimeKind.Local).AddTicks(7621), null, 20.42m, 2921431604951675m, true, "Special", 3, 48.13349f, "964 Jones Crescent, Sydnieburgh, Zambia", new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4"), "3947 Isaac Wells, North Dustyshire, Bolivia", new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a99d7892-d451-495a-b293-d4d1f3c2925a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 13, 20, 18, 22, 911, DateTimeKind.Local).AddTicks(6204), new DateTime(2023, 9, 15, 20, 18, 22, 911, DateTimeKind.Local).AddTicks(6204), null, 34.02m, true, 7638096112040516m, "Standart", 1, 3.9212928f, "0840 Edgar Stream, Dollychester, Hong Kong", new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6"), "0905 Powlowski Canyon, Matildeland, Thailand", new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("abbb3244-a7a3-4704-9552-838dee74d8cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 9, 19, 22, 42, 862, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 4, 18, 19, 22, 42, 862, DateTimeKind.Local).AddTicks(2525), null, 14.32m, true, 5479902548217766m, true, "Special", 1, 30.6033f, "17205 Okuneva Station, North Monicafort, Singapore", new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4"), "811 Abernathy Ranch, Boganville, Congo", new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ac9aac7c-28e4-4a1b-9c6e-a9ec5a1c93ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 17, 12, 24, 29, 444, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 3, 26, 12, 24, 29, 444, DateTimeKind.Local).AddTicks(8668), null, 46.08m, true, 1303648315013652m, "Standart", 2, 4.847623f, "5681 Cleo Cape, Mosciskiberg, Haiti", new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1"), "25248 Kling Gardens, Walshhaven, Reunion", new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("acac236d-0867-41f2-8dee-19b3338bd846"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 15, 9, 44, 31, 757, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 2, 16, 9, 44, 31, 757, DateTimeKind.Local).AddTicks(5860), null, 65.33m, true, 1904354654530900m, true, "Special", 1, 11.044092f, "5884 Ardella Crossing, North Kennafort, Equatorial Guinea", new Guid("748062f3-9c55-4b5c-9d17-429dac03b923"), "3719 River Via, Port Marietta, Guyana", new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("b8dc5a60-b9e4-4c7c-8b87-89022ce407b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 20, 2, 31, 19, 151, DateTimeKind.Local).AddTicks(2198), new DateTime(2024, 2, 29, 2, 31, 19, 151, DateTimeKind.Local).AddTicks(2198), null, 41.60m, 1830632188949141m, true, "Courier", 2, 21.980003f, "9034 Keegan Viaduct, Port Rocio, Thailand", new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b"), "396 Verner Plains, Amoschester, American Samoa", new Guid("fb455a22-8198-413a-89a8-e92c01f42483"), "Registered", "PlasticBag" },
                    { new Guid("b95c6bbe-e11f-436d-9353-307966a0e87a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 17, 6, 47, 824, DateTimeKind.Local).AddTicks(3534), new DateTime(2023, 11, 19, 17, 6, 47, 824, DateTimeKind.Local).AddTicks(3534), null, 43.69m, 9347901186907788m, true, "Courier", 5, 10.662877f, "297 Garfield Mountains, Baileyview, Latvia", new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372"), "2087 Chester Way, New Gretchenshire, France", new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f"), "OnTheWay", "CardboardBox" },
                    { new Guid("bb69049c-7156-44ca-8fdd-7d271b04a4f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 13, 13, 58, 50, 766, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 4, 18, 13, 58, 50, 766, DateTimeKind.Local).AddTicks(5906), null, 77.35m, 9310851925780096m, true, "Courier", 2, 37.46043f, "259 Nichole Flats, Rolfsonview, Mexico", new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760"), "34843 Heaney Street, Rempelshire, Mexico", new Guid("ce1f07b6-54d9-4379-9845-3751b9499199"), "Sent", "PlasticBag" },
                    { new Guid("bbc4f32e-0cfb-42be-9726-caf33eff7c7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 25, 19, 20, 30, 809, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 11, 29, 19, 20, 30, 809, DateTimeKind.Local).AddTicks(3602), null, 96.97m, 9054656251153976m, true, "Standart", 5, 10.9493f, "71011 Corkery Isle, Corkeryborough, Gabon", new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1"), "7531 Kraig Club, Rickiestad, Turks and Caicos Islands", new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bd6f99fb-b0b2-4ee4-9f0f-0cf38868c6cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 10, 0, 39, 30, 692, DateTimeKind.Local).AddTicks(8251), new DateTime(2024, 2, 16, 0, 39, 30, 692, DateTimeKind.Local).AddTicks(8251), null, 68.17m, true, 5744316526932785m, true, "Super", 5, 13.399077f, "2167 Tomas Court, Donnellyfort, Palestinian Territory", new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058"), "560 Darlene River, East Jessie, Nigeria", new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bece26e1-98c9-4f0f-b4fc-25aa1f5726c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 12, 23, 29, 17, 344, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 9, 21, 23, 29, 17, 344, DateTimeKind.Local).AddTicks(9968), null, 17.37m, 2941650519032617m, "Special", 4, 8.549195f, "7488 Hand Manor, Quitzonfort, Saint Pierre and Miquelon", new Guid("e352c3a5-25cc-4796-8c60-703443aad68b"), "8873 Krajcik Squares, Ernaview, Guam", new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("cab55367-9e33-464a-87b0-365859c406ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 23, 13, 35, 54, 248, DateTimeKind.Local).AddTicks(2294), new DateTime(2024, 3, 24, 13, 35, 54, 248, DateTimeKind.Local).AddTicks(2294), null, 43.38m, true, 9456165860735582m, "Standart", 1, 33.59372f, "56351 Kub Fort, Ankundingborough, Andorra", new Guid("80ed64a5-2f87-4262-aed3-901da3da1369"), "203 Travon Estate, Weberborough, Jamaica", new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), "Sent", "PlasticBag" },
                    { new Guid("caed7654-05e6-48e0-80e2-1441f9b87c12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 8, 8, 4, 52, 413, DateTimeKind.Local).AddTicks(3369), new DateTime(2023, 9, 14, 8, 4, 52, 413, DateTimeKind.Local).AddTicks(3369), null, 58.67m, true, 6527292899700026m, "Super", 3, 34.130207f, "73297 Hettinger Drive, Tayaton, Guinea-Bissau", new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353"), "591 Gerhold Meadows, Port Brantville, Marshall Islands", new Guid("9d7effeb-d071-4689-a103-74400c1c3344"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cfd027ef-d688-46a7-bee6-e674762f0a04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 12, 20, 24, 26, 532, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 2, 19, 20, 24, 26, 532, DateTimeKind.Local).AddTicks(6094), null, 94.26m, 6875466977118361m, "ParcelMachine", 2, 32.93961f, "6218 Crooks Knoll, Larkinberg, Brunei Darussalam", new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc"), "31470 Hessel Dam, West Katheryn, Guam", new Guid("35187412-3a05-415f-8523-ec24e84b1221"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d62571be-2362-4f31-95b9-c766f60de835"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 1, 16, 17, 31, 558, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 4, 5, 16, 17, 31, 558, DateTimeKind.Local).AddTicks(2948), null, 95.92m, true, 4820587387306676m, true, "ParcelMachine", 5, 49.615314f, "1153 Arnold Skyway, Mullerberg, Belarus", new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4"), "76978 Michale Heights, East Lucienne, Togo", new Guid("99227d48-6d3f-45fd-971b-83f0198ee703"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ddba3ffb-a66e-4c42-829d-f9809a72fa03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 10, 22, 7, 18, 216, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 1, 18, 22, 7, 18, 216, DateTimeKind.Local).AddTicks(9726), null, 34.42m, 3123404092606108m, "ParcelMachine", 2, 3.6044092f, "588 Watsica River, Matteoside, Vietnam", new Guid("60bb9160-18e9-4302-9e15-44aa4126967e"), "4709 Stiedemann Radial, East Humbertohaven, British Indian Ocean Territory (Chagos Archipelago)", new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee"), "Return", "CardboardBox" },
                    { new Guid("e4fcecc5-38fa-4d06-986b-7d36fe6a0d29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 24, 10, 42, 26, 127, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 8, 26, 10, 42, 26, 127, DateTimeKind.Local).AddTicks(2771), null, 98.48m, 4226270563423354m, "Courier", 3, 43.907722f, "004 Haleigh Hill, Harrisonshire, Cook Islands", new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73"), "23567 Hoppe Union, Lillianborough, Nigeria", new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e934cb40-2a68-4737-a5a3-2756aef6ec19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 7, 1, 55, 49, 175, DateTimeKind.Local).AddTicks(6231), new DateTime(2024, 2, 11, 1, 55, 49, 175, DateTimeKind.Local).AddTicks(6231), null, 90.06m, true, 4434046004534252m, true, "Special", 3, 22.680937f, "73902 Hudson Trail, Trantowstad, Pitcairn Islands", new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446"), "047 Rhea Plaza, Port Nickolas, Romania", new Guid("30e31307-3bbc-4483-bf55-601427ba031c"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ea1bb075-ca8a-4a43-a9f2-e0c9f7092387"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 27, 12, 52, 59, 204, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 2, 6, 12, 52, 59, 204, DateTimeKind.Local).AddTicks(5640), null, 73.30m, 6849011228897781m, true, "ParcelMachine", 1, 2.540501f, "8826 Jordon Stravenue, West Christelleberg, Gabon", new Guid("7573b136-e686-46e6-b0af-1186d8e37af1"), "19913 Michelle Spring, East Seanbury, Lesotho", new Guid("de956589-c440-4477-908f-fd0e51a90148"), "Delivered", "PlasticBag" },
                    { new Guid("ece82088-66d2-4888-9069-e2381232c3ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 21, 49, 26, 865, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 10, 18, 21, 49, 26, 865, DateTimeKind.Local).AddTicks(9450), null, 31.50m, 5635523496856743m, true, "Special", 1, 49.31826f, "5655 Ryann Harbor, Hammeschester, Bouvet Island (Bouvetoya)", new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa"), "40858 Hauck Cove, Gerholdmouth, Reunion", new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ed38457a-183e-4a3e-bd4e-4794c6efb381"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 7, 19, 29, 37, 381, DateTimeKind.Local).AddTicks(5302), new DateTime(2023, 8, 17, 19, 29, 37, 381, DateTimeKind.Local).AddTicks(5302), null, 52.45m, true, 3703497672432348m, true, "Courier", 1, 9.98271f, "07603 Connor Mountain, Mantechester, Kyrgyz Republic", new Guid("41008513-ca62-4168-8bcd-a3f4384fd325"), "6422 Triston Village, Paoloview, Burundi", new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ed8239b8-900c-443e-a0ec-0275be2d7a1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 28, 20, 15, 9, 439, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 6, 7, 20, 15, 9, 439, DateTimeKind.Local).AddTicks(1028), null, 72.11m, 2080519534446386m, "ParcelMachine", 4, 17.609045f, "488 Fredy Roads, Cynthiamouth, Wallis and Futuna", new Guid("ba4e9530-0050-46fc-9d19-c319bf533845"), "616 Sidney Squares, South Pansyton, Ireland", new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9"), "Return", "CardboardBox" },
                    { new Guid("ee148a09-cb60-4952-9f44-0c5edb3dbb36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 12, 5, 39, 27, 118, DateTimeKind.Local).AddTicks(8712), new DateTime(2023, 6, 20, 5, 39, 27, 118, DateTimeKind.Local).AddTicks(8712), null, 41.79m, 8088751397532757m, "Standart", 1, 30.57887f, "3397 Wisozk Key, New Jana, Greece", new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4"), "291 Ericka Port, Koeppborough, Sweden", new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ee2f214c-ae39-4d78-b231-9b82c7195c38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 4, 10, 32, 51, 960, DateTimeKind.Local).AddTicks(2686), new DateTime(2024, 2, 12, 10, 32, 51, 960, DateTimeKind.Local).AddTicks(2686), null, 55.99m, true, 3873908670747902m, true, "Courier", 5, 8.35815f, "7687 Stefan Walk, West Catherinestad, Guyana", new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14"), "8663 Pagac Cliff, Velmaville, Bolivia", new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f1806de3-408d-4462-9095-198905912337"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 13, 16, 4, 36, 785, DateTimeKind.Local).AddTicks(6674), new DateTime(2023, 7, 16, 16, 4, 36, 785, DateTimeKind.Local).AddTicks(6674), null, 18.50m, 8004483354464521m, "Special", 2, 40.75771f, "6923 Quigley Falls, East Virgie, Bangladesh", new Guid("4f03daca-02fb-425a-a575-bef52173e4d3"), "516 Walsh Parkway, Leonorfurt, Suriname", new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f3f377d9-a963-4a62-aef3-00d0e1adf8d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 6, 0, 21, 40, 724, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 1, 12, 0, 21, 40, 724, DateTimeKind.Local).AddTicks(7011), null, 38.76m, 8277821113829242m, true, "Super", 1, 14.283652f, "564 Neha Harbor, Port Magnusview, Hong Kong", new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5"), "476 McLaughlin Light, Gussiefurt, Slovakia (Slovak Republic)", new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f4aa54eb-3977-41fd-b220-5abc2cd53f10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 19, 13, 28, 18, 929, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 22, 13, 28, 18, 929, DateTimeKind.Local).AddTicks(8849), null, 64.68m, true, 9570958792409696m, true, "Courier", 1, 16.428438f, "99954 Marvin Walk, Binsstad, Liberia", new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8"), "27240 Emanuel Mall, Tamaraport, South Africa", new Guid("865b430e-4516-4a31-ae36-1eecddd681f1"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("faabae65-aec2-4f40-9eea-39d172d9f080"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 20, 18, 45, 36, 331, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 7, 25, 18, 45, 36, 331, DateTimeKind.Local).AddTicks(6791), null, 59.66m, true, 3956986443509866m, "Standart", 2, 8.602338f, "6625 Lola Shoals, Bertrandview, Saint Barthelemy", new Guid("30b2066d-f465-42ae-93e3-4a38936052b2"), "30684 Hettinger Stravenue, Mabelleville, Chad", new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b"), "Return", "CardboardBox" },
                    { new Guid("fe0189ef-c2eb-4329-af2f-5cea5f90efa7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 5, 10, 30, 3, 586, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 3, 15, 10, 30, 3, 586, DateTimeKind.Local).AddTicks(946), null, 27.26m, true, 8055169162435468m, "Super", 2, 32.134644f, "19438 Bartell Highway, Lake Rhiannaborough, Reunion", new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), "441 Lon Islands, Abdulmouth, Saint Vincent and the Grenadines", new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0050bece-f8a6-415d-94e5-1977b6c41035"), "174", "7210179570563277", null, null, new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14"), "01/03" },
                    { new Guid("00c76a12-118b-406e-8433-4f4ca6a1080d"), "825", "9222633067815740", null, null, new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1"), "12/10" },
                    { new Guid("00d11b13-640f-4b70-a331-b491c293f89e"), "552", "4282740665759912", null, null, new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7"), "01/12" },
                    { new Guid("00d32606-113b-49b8-a8bc-6338b4026b92"), "006", "8292939401257252", null, null, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece"), "03/21" },
                    { new Guid("00f0882f-8ddc-4453-a128-6f60fabe048b"), "359", "3264455635501278", null, null, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b"), "02/09" },
                    { new Guid("014600f7-8a6f-4283-bc2c-029d87b36398"), "997", "3343475086772974", null, null, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b"), "08/19" },
                    { new Guid("01b74815-315c-4221-97fa-811e191ba1d9"), "845", "4002611673838719", null, null, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37"), "09/09" },
                    { new Guid("01ba7b63-a7ce-4234-852e-3881c2d7286b"), "397", "1714242519632585", null, null, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6"), "05/17" },
                    { new Guid("01c21895-9adb-42a9-a301-15ea767e1d07"), "272", "8883215068735967", null, null, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5"), "06/27" },
                    { new Guid("01c608b7-88ae-413d-b388-775788e90f7d"), "683", "3448515638092592", null, null, new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098"), "09/22" },
                    { new Guid("01f68bbb-d379-4ad3-9964-142e77f3f433"), "851", "9160102549327392", null, null, new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba"), "03/15" },
                    { new Guid("026818af-e490-44b4-ad45-89ef823a1b12"), "197", "8331221980934730", null, null, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6"), "01/26" },
                    { new Guid("034967b1-8797-4f03-bcce-49f7aa045d06"), "032", "1201302846964690", null, null, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854"), "08/09" },
                    { new Guid("036e77b1-4b8d-4ac3-8a1e-73da461bfa82"), "415", "7187826427518631", null, null, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf"), "02/20" },
                    { new Guid("0427f9c4-e49c-413b-b49f-d28ab7a3ff5b"), "311", "5415943984732803", null, null, new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee"), "06/07" },
                    { new Guid("048b93a7-8014-4d24-ae7d-9cad19482fcd"), "672", "2560161807657590", null, null, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1"), "08/22" },
                    { new Guid("04b40303-a8c0-4c6a-b66d-60a731c68e3f"), "675", "9253195574645284", null, null, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae"), "04/27" },
                    { new Guid("04c7404c-81e4-465a-833b-c792d7b8283e"), "005", "7970785739572914", null, null, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f"), "01/20" },
                    { new Guid("04c9d963-315d-4432-9fb0-3e6ffd290168"), "892", "8537800258407663", null, null, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16"), "01/23" },
                    { new Guid("050737da-2b58-4fc6-9c59-c32a8ed30875"), "881", "4489684290046001", null, null, new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26"), "07/17" },
                    { new Guid("05ba0a3b-4122-417c-bbba-dcb6a6080913"), "719", "7328071852775986", null, null, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca"), "07/07" },
                    { new Guid("0632b0ae-665b-466a-b673-40219d77b78e"), "658", "6284428519037906", null, null, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c"), "10/12" },
                    { new Guid("069f4122-c389-4b6e-8c82-3d7261be9608"), "128", "4742866402829564", null, null, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4"), "07/13" },
                    { new Guid("06c496ad-2d78-4472-bc18-a5004f59f132"), "420", "5660114357116217", null, null, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c"), "04/24" },
                    { new Guid("06ecffe2-5b84-4890-bf11-c71779e0b27c"), "086", "6833384493547103", null, null, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), "01/01" },
                    { new Guid("0764d421-ceed-459a-8408-a19643075e6b"), "112", "8806949679011953", null, null, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754"), "09/13" },
                    { new Guid("07b77794-3eb0-4b37-9b74-cf20e50c7cf7"), "263", "4225462485410673", null, null, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e"), "07/13" },
                    { new Guid("07f735da-3c11-40d0-b470-41a366c55636"), "676", "7293707030473402", null, null, new Guid("563f53c7-7654-4215-88fc-eff6cf413754"), "05/11" },
                    { new Guid("07f76fa2-b06c-47e6-9895-03cd4db3ee3f"), "161", "1556180989131712", null, null, new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748"), "01/24" },
                    { new Guid("083308c7-712a-4484-925c-9b882590090c"), "101", "4720357995711691", null, null, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5"), "06/23" },
                    { new Guid("08448753-f297-4e25-abfd-1729efa45336"), "042", "4461851788808550", null, null, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477"), "04/12" },
                    { new Guid("087ed4de-1f73-467f-84d2-6d55531c1e4d"), "148", "3144847945907219", null, null, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923"), "06/09" },
                    { new Guid("0a259448-72cb-4360-a909-2c1ea9196446"), "310", "5706519226514876", null, null, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1"), "04/04" },
                    { new Guid("0a9bc7b0-26ca-4392-9781-fc6910af777a"), "233", "2640139284132202", null, null, new Guid("52698753-1196-4fd7-83fd-4670d8d55456"), "09/15" },
                    { new Guid("0ace9d4b-9122-4261-b049-3f05cc3373f5"), "597", "6731662801070860", null, null, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc"), "02/18" },
                    { new Guid("0ad711fa-7b76-4228-9a48-149feff5c902"), "275", "6704051106714639", null, null, new Guid("617100a1-d830-4170-9964-86b27fc31a31"), "04/07" },
                    { new Guid("0bb2e0d5-07b6-438b-a967-37fca8d581fa"), "756", "3456815216298945", null, null, new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0"), "12/15" },
                    { new Guid("0bb5c9bb-ad10-4e01-b265-17ca1e906845"), "086", "6970920574253466", null, null, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446"), "09/16" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0c04f714-1d61-4515-a76d-1f9113df2c68"), "341", "9057999719992874", null, null, new Guid("563f53c7-7654-4215-88fc-eff6cf413754"), "03/28" },
                    { new Guid("0c35e8ab-c59f-436d-9566-e8fddf7d15e6"), "994", "1438059409464549", null, null, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854"), "04/15" },
                    { new Guid("0cd68069-9b55-43ab-810a-f8a7d1bce8dd"), "756", "7041013210988439", null, null, new Guid("77f944f9-c758-4983-b702-656640bf5672"), "03/08" },
                    { new Guid("0d4980bd-75f3-4ba0-b755-0b4e2767c560"), "749", "5988242079070288", null, null, new Guid("19034493-ddce-4219-8d74-fbdd26d02300"), "08/20" },
                    { new Guid("0d73ed68-9879-4bfa-8ddd-da90e639ae3a"), "057", "4303332191862440", null, null, new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979"), "01/10" },
                    { new Guid("0d9a8429-a3b8-403f-8d82-a91426928322"), "840", "6165584181088464", null, null, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59"), "01/20" },
                    { new Guid("0dabb811-08b3-432f-bdec-dc2e33db51c2"), "870", "7917950314888026", null, null, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217"), "12/17" },
                    { new Guid("0dc72cc4-929a-4d31-b395-829049039850"), "254", "1682496782991336", null, null, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446"), "11/05" },
                    { new Guid("0deb42cb-504a-4644-a6aa-eca4124fd7de"), "669", "5825825522187295", null, null, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09"), "05/16" },
                    { new Guid("0e2a14d2-2a63-42d0-bc6e-abe71a3e2fbe"), "779", "9865287488126895", null, null, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4"), "08/19" },
                    { new Guid("0e69c4a8-3d74-4068-b8fb-63f720deb290"), "253", "5883863530994126", null, null, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28"), "11/23" },
                    { new Guid("0e7bb3dd-6f5f-4c2a-bc87-5eb8a9a64ce0"), "889", "6966810993906902", null, null, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1"), "07/11" },
                    { new Guid("0e8d590c-fa90-4b19-83a7-4948ea77d86d"), "738", "9206868914477955", null, null, new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4"), "07/12" },
                    { new Guid("0eaede18-5287-45a4-b61c-de64d1acab91"), "538", "6779680047455554", null, null, new Guid("1154048c-cc8b-409f-a802-5dbe51d20548"), "01/11" },
                    { new Guid("0ecf4a0b-40a3-4862-a9dc-9e09bcf2615a"), "159", "8290409858799248", null, null, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3"), "11/23" },
                    { new Guid("0f017695-770c-4928-b1c6-8e32ce7e1361"), "666", "9503191651078570", null, null, new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8"), "01/02" },
                    { new Guid("0f21fe63-8b7a-4284-b08d-c810c0a81ac7"), "549", "3075306717299845", null, null, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783"), "05/12" },
                    { new Guid("0f31cd61-4a01-49d9-951f-9c1c042739bf"), "897", "9219211931891142", null, null, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785"), "12/15" },
                    { new Guid("0f369fda-9917-4d32-8b5c-1259c6b55d71"), "419", "1838823481187087", null, null, new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd"), "10/08" },
                    { new Guid("0fef9cc6-aaf6-4313-b82a-8a7ed1e9c3bd"), "463", "2555393288400534", null, null, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f"), "05/13" },
                    { new Guid("103e1755-1fef-41ff-878f-ee6f2b22f126"), "309", "3211303964121656", null, null, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c"), "09/17" },
                    { new Guid("10d1104e-99a4-4be9-a40f-b63bb23cbb9b"), "587", "9020926238300959", null, null, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010"), "09/26" },
                    { new Guid("10dda09f-91c3-4dd4-8e00-dd79a288da06"), "601", "1314047490683910", null, null, new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154"), "09/21" },
                    { new Guid("10ee623c-3fad-44c0-870a-18b738d43ff3"), "324", "9923623227590556", null, null, new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14"), "12/27" },
                    { new Guid("11036b49-ad1d-4902-8bc9-c46f50edc3b6"), "951", "4938843506485152", null, null, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f"), "04/24" },
                    { new Guid("113e1212-9287-487f-9df1-f2395c53002c"), "710", "7721224443249648", null, null, new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c"), "01/24" },
                    { new Guid("11e59d59-6f9c-4e13-8387-e0baf69b04c8"), "161", "3078880026551282", null, null, new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1"), "01/06" },
                    { new Guid("12783fa5-9953-41bb-8249-a0a875627fcb"), "376", "7174833510204230", null, null, new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665"), "12/04" },
                    { new Guid("12a6ff81-56ba-4790-97c2-3ede7596197d"), "243", "9086602974399000", null, null, new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae"), "11/09" },
                    { new Guid("137fddfc-7071-45f1-90e4-7e6f59af631d"), "758", "5385533966625832", null, null, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b"), "08/05" },
                    { new Guid("13e39660-595e-4fb6-a1fd-e178f68bf91c"), "608", "5484986183633942", null, null, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16"), "11/20" },
                    { new Guid("14033ecd-d71a-4da3-abf8-6ea64ca993b5"), "826", "1083037085542073", null, null, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9"), "11/17" },
                    { new Guid("148b1e90-535b-45ba-9268-c82157c477ae"), "093", "2518552480395228", null, null, new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6"), "03/23" },
                    { new Guid("14929dd5-c366-4727-b570-5f023daa4b60"), "296", "3525079776048969", null, null, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), "06/04" },
                    { new Guid("155ae4bb-f6a2-47dc-89e6-66e26955310f"), "834", "7369661534810383", null, null, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b"), "02/04" },
                    { new Guid("15cbddb5-1012-4c4c-a901-71a9e11749da"), "277", "7867340036279762", null, null, new Guid("527f7c3d-02b4-465e-8153-3472af913951"), "04/08" },
                    { new Guid("15d38df9-d8c9-46e0-8fee-e6ffa488fb4e"), "049", "5814077189731988", null, null, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325"), "11/04" },
                    { new Guid("160895b8-e081-49ac-9572-5caf547b8148"), "152", "3188017190161494", null, null, new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b"), "09/26" },
                    { new Guid("16333f0c-0058-424c-9ec1-a3e9ada85b9d"), "382", "5737190255184185", null, null, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5"), "06/28" },
                    { new Guid("1678fad5-6d84-4a10-ab82-f3e03b27fc68"), "850", "6541517043581277", null, null, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783"), "12/21" },
                    { new Guid("168b0bae-e2b3-4c92-adc9-a1f17132f470"), "816", "9112001008554512", null, null, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5"), "09/21" },
                    { new Guid("16f78561-4333-498a-98a5-6f169387121a"), "356", "9337975280119935", null, null, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16"), "06/02" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("170e886a-e9f9-478e-88b7-53cc9be24674"), "594", "6461728078179285", null, null, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754"), "04/07" },
                    { new Guid("17193779-8478-4a6e-b090-9f74f7078d0e"), "383", "3589388221722960", null, null, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd"), "10/27" },
                    { new Guid("1726788b-cf39-4246-9e31-8fd33f8dfa59"), "739", "5971692098848560", null, null, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c"), "01/14" },
                    { new Guid("17b4cf32-53dd-4a4d-825f-b961019d7685"), "417", "1822346203174670", null, null, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc"), "01/19" },
                    { new Guid("17e80045-7bd2-43ee-8ace-7155e978a786"), "622", "7325129548521258", null, null, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40"), "05/01" },
                    { new Guid("1877803d-a20e-4052-b61e-e5a29fef59fc"), "335", "7216253083677497", null, null, new Guid("99484890-5bb7-47f9-b211-218700e48dad"), "11/05" },
                    { new Guid("189c1bc1-aae4-4137-9224-8a19eff8b832"), "473", "7311100818071812", null, null, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5"), "03/01" },
                    { new Guid("18d00f36-38ab-467b-b230-44e9ac5433ad"), "512", "8794720133833563", null, null, new Guid("0f9851be-b682-479e-aec8-51795a73a90e"), "01/21" },
                    { new Guid("18e587cf-5b3f-4d73-baf3-46392d58d2f8"), "323", "4253055193254568", null, null, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5"), "04/11" },
                    { new Guid("1932fc27-d0c2-49a1-9d30-4005fda293b9"), "141", "6664891716180127", null, null, new Guid("f027517a-8745-4767-8a34-aaadc0a70189"), "02/18" },
                    { new Guid("19933629-d144-4573-bf4e-aa9fcb3fcdbf"), "073", "6072036926490891", null, null, new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a"), "01/05" },
                    { new Guid("19aac64c-dbf8-4d2c-877c-28a41435bb8b"), "064", "5607418596926035", null, null, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217"), "01/19" },
                    { new Guid("1a120acf-df24-4c04-9654-628f8fb88b92"), "307", "1733116894586965", null, null, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7"), "01/01" },
                    { new Guid("1a4c6b66-d8bd-41e8-8daa-a43c2bdb8aaf"), "816", "2616201820449884", null, null, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae"), "12/01" },
                    { new Guid("1a73fe3c-4168-47d7-b156-b947d2174c61"), "399", "1731935184828712", null, null, new Guid("19341891-e9b6-407e-aea5-b35513589e26"), "06/01" },
                    { new Guid("1b1377d3-3c2f-43d9-81c0-100eff4d5097"), "830", "9914321758799847", null, null, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a"), "05/09" },
                    { new Guid("1b45e291-af74-4b97-8b9f-035735c7b5db"), "268", "8045681354764477", null, null, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b"), "10/03" },
                    { new Guid("1b662883-790f-44fb-9c38-fec23d4eb60b"), "065", "5576269503749061", null, null, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16"), "08/20" },
                    { new Guid("1bdb5fa7-27b7-460f-a1ae-b71e75aa2a35"), "378", "1888642401196008", null, null, new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018"), "03/13" },
                    { new Guid("1bf99c28-25ca-4ac7-a9cb-58f30a9a17a7"), "227", "3157643692277735", null, null, new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), "06/07" },
                    { new Guid("1c8115b2-1fdc-4454-a88e-de5dc54dbd30"), "220", "7414495056098851", null, null, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6"), "01/04" },
                    { new Guid("1d342227-3630-44a6-8bf3-3df84298daf2"), "769", "5103494480081108", null, null, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae"), "05/26" },
                    { new Guid("1d567379-9f97-4548-8e5c-10505974395c"), "188", "6932930588404190", null, null, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770"), "08/26" },
                    { new Guid("1d6b5cd9-6565-4c09-a922-578e6abd1594"), "645", "6704523021610497", null, null, new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26"), "01/14" },
                    { new Guid("1d86fa42-0f4f-489c-a4ae-2c7856144e3e"), "094", "7801763116588472", null, null, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065"), "06/10" },
                    { new Guid("1dbb0022-d910-4e8b-bbc0-71b1391c8298"), "707", "3457157975343402", null, null, new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2"), "08/06" },
                    { new Guid("1e424433-d703-45a3-9182-c2cf16205b31"), "427", "2324290407471917", null, null, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12"), "12/02" },
                    { new Guid("1f20f013-a16b-4cf9-96f1-5ae382affc62"), "127", "8212417922525666", null, null, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e"), "01/12" },
                    { new Guid("1f2e3b29-6f17-49fb-9ea5-d151c74b9ce7"), "795", "2526964600825437", null, null, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024"), "01/10" },
                    { new Guid("1f4e66b7-171f-4c6d-8e4b-5e61320484f0"), "019", "3362258544657277", null, null, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f"), "11/21" },
                    { new Guid("1f8f409e-dc10-454f-ba73-6c4b1d3fbfee"), "083", "1575301099206365", null, null, new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73"), "11/02" },
                    { new Guid("205b84d6-2ede-44b0-9ca8-c80e1f557a5f"), "617", "2979062341350899", null, null, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8"), "10/27" },
                    { new Guid("20b03ba9-7eb2-4ce5-a71c-38f94357eacc"), "660", "9176898620024001", null, null, new Guid("35187412-3a05-415f-8523-ec24e84b1221"), "06/20" },
                    { new Guid("212f58a2-abb9-4fb6-beca-5a76196a6429"), "321", "6198994203162881", null, null, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325"), "01/07" },
                    { new Guid("219ca1fa-1ebb-4da8-9a6f-dbc356aca7da"), "333", "3172049692917026", null, null, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae"), "02/08" },
                    { new Guid("21c9fc1d-1d15-4fdd-b778-2a008f4ff127"), "869", "4922586245423398", null, null, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9"), "12/07" },
                    { new Guid("22068770-459e-4da3-a294-de66431a4862"), "462", "5107699635900466", null, null, new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8"), "10/21" },
                    { new Guid("2212c592-73f1-4cc5-a538-cc9a397e158b"), "240", "5787016514042609", null, null, new Guid("08094f90-68b7-4576-a740-581a4878e4ab"), "11/27" },
                    { new Guid("22b2105a-2a24-4fd7-bb00-ac7941cc5d13"), "266", "4538469409157483", null, null, new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e"), "09/12" },
                    { new Guid("230fe39e-799f-4bcb-84cb-15fbaa249755"), "516", "9595679478637534", null, null, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363"), "07/16" },
                    { new Guid("235771ec-d48b-4bea-a949-1f6b7f8363dc"), "154", "3795238235052815", null, null, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770"), "08/12" },
                    { new Guid("23f8e5fa-b758-4c66-bc25-095f04464fc8"), "712", "1690055022795931", null, null, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498"), "04/08" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("24766add-1cac-439e-b29e-9806155b8592"), "372", "2002342480033052", null, null, new Guid("563f53c7-7654-4215-88fc-eff6cf413754"), "02/24" },
                    { new Guid("24a91dd1-e61c-4dbe-ac41-e06312914cde"), "793", "8753286562810426", null, null, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1"), "04/25" },
                    { new Guid("250e3874-02b0-40f7-ad2c-3a5239b85da6"), "495", "7744569135813734", null, null, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a"), "04/23" },
                    { new Guid("25f1a8a6-0bfc-4762-b6f0-c733c033de25"), "648", "3379568460818133", null, null, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), "02/25" },
                    { new Guid("25f679a9-49c1-4923-8b02-731ce8e64715"), "671", "2625708391459617", null, null, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f"), "06/06" },
                    { new Guid("25f6a477-ae98-4bcc-9b2e-0f9cbec12d5d"), "235", "3457348941208542", null, null, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f"), "03/09" },
                    { new Guid("267f39eb-faae-4ad7-8b87-6c37553ec515"), "144", "7809971092029547", null, null, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30"), "02/24" },
                    { new Guid("26b10f51-4b5b-4016-8948-3e727ec9493d"), "837", "5776515270916892", null, null, new Guid("0b98923c-0481-432f-9b60-33427e4d8223"), "01/24" },
                    { new Guid("2717cc59-e485-42bb-9ab7-eadea5e6004e"), "184", "3423071175402451", null, null, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921"), "09/13" },
                    { new Guid("2790913b-bc17-4388-96d2-ffc8f81708c6"), "325", "3001735475146115", null, null, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b"), "05/28" },
                    { new Guid("27ad4522-06c4-442a-b669-1be1e4e701f1"), "454", "1445064204769241", null, null, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9"), "03/04" },
                    { new Guid("27c97715-f2c7-4ab3-b9e9-3b7954dd48ff"), "986", "1760255878820590", null, null, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a"), "02/22" },
                    { new Guid("27f91598-480f-4d1e-82f2-b7898a25e903"), "379", "5203601807350002", null, null, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1"), "09/14" },
                    { new Guid("28219ae4-29c6-41ce-b761-1055be02eac2"), "826", "1141050917812050", null, null, new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731"), "02/27" },
                    { new Guid("28546a95-9bb0-4a38-b113-76d66958e698"), "736", "7131088819612244", null, null, new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739"), "11/11" },
                    { new Guid("287fc54c-451e-4ec1-a397-144b9c71d6af"), "049", "8464268521885468", null, null, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921"), "01/25" },
                    { new Guid("2918d7f6-5f35-4f0f-a204-bd0a6fbd9e21"), "099", "2228915994702356", null, null, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477"), "08/23" },
                    { new Guid("295a22f2-bcd5-4ebb-8bab-d33f818152a9"), "767", "9526482550310434", null, null, new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2"), "08/07" },
                    { new Guid("2b07a6ca-f080-4652-9503-cbb205d3c443"), "678", "8723253283093072", null, null, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b"), "11/05" },
                    { new Guid("2b68951f-c6e4-44f8-9315-194fa00ad37b"), "095", "9496453874425628", null, null, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc"), "01/19" },
                    { new Guid("2b7da35e-5094-4cd2-a309-844342a4d1bb"), "925", "1038354103574960", null, null, new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e"), "07/01" },
                    { new Guid("2b92c121-a268-4ade-b7d9-f6935979674b"), "396", "7137743198229091", null, null, new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6"), "03/05" },
                    { new Guid("2badec11-b2fe-471c-a519-22f5ab010ab5"), "726", "3167084762059684", null, null, new Guid("46568224-f301-4805-9ce4-f87ec0533c46"), "06/26" },
                    { new Guid("2bd6b79c-aa09-4d31-87e4-c0767275ddae"), "046", "5717415916266525", null, null, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553"), "04/02" },
                    { new Guid("2c35afab-f248-4875-95e4-105365ce49f5"), "270", "3152973356497859", null, null, new Guid("19034493-ddce-4219-8d74-fbdd26d02300"), "04/28" },
                    { new Guid("2c871c07-7c69-487e-999c-45905c4cccc7"), "636", "9905320558176718", null, null, new Guid("46568224-f301-4805-9ce4-f87ec0533c46"), "03/07" },
                    { new Guid("2c87c88e-1bbb-4721-87f8-5ae7c61e7463"), "117", "1054147257532132", null, null, new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), "04/12" },
                    { new Guid("2c894162-f52c-416d-85e6-d8ec3654ac71"), "251", "4532855897464348", null, null, new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99"), "01/09" },
                    { new Guid("2cd09e7e-2d33-49d0-8854-58bd331c22e6"), "265", "3578786819434703", null, null, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9"), "09/18" },
                    { new Guid("2cf2be58-43c2-4836-95c7-2fd4ac7fb109"), "432", "5728644489343281", null, null, new Guid("de956589-c440-4477-908f-fd0e51a90148"), "07/02" },
                    { new Guid("2d2f4893-50a6-422e-b205-13db2b13f0fa"), "784", "2778772086705524", null, null, new Guid("ce1f07b6-54d9-4379-9845-3751b9499199"), "08/17" },
                    { new Guid("2d3e10ff-6c43-4e68-9436-14632d6e6ae2"), "218", "9118002163147810", null, null, new Guid("94aaefbb-3b69-4a12-8609-44039863dc44"), "12/23" },
                    { new Guid("2d482085-8105-44e9-a493-6500dd4078ec"), "884", "9221032558024684", null, null, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f"), "05/16" },
                    { new Guid("2deec669-d8c4-4e4c-9fab-5469afcdaa77"), "112", "9449961643894527", null, null, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37"), "04/23" },
                    { new Guid("2e49c7f2-21ce-4fbd-9446-b0faccf7082c"), "979", "2677955001082812", null, null, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f"), "10/28" },
                    { new Guid("2ed995cb-e706-4d58-b60f-385190e5227a"), "513", "7567230877792678", null, null, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767"), "02/16" },
                    { new Guid("2f10be70-cf38-4c2a-bbd0-f9d225e0dd87"), "563", "7369717403822936", null, null, new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799"), "11/05" },
                    { new Guid("2f9c1cfe-e323-4114-a560-38ec140b6fb4"), "209", "6582067337275847", null, null, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845"), "01/26" },
                    { new Guid("312b89f1-363f-4a31-8042-3701e5ffb835"), "782", "2373479520522111", null, null, new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353"), "07/25" },
                    { new Guid("31490762-2019-473d-8d76-00e6499e48aa"), "128", "6451671495828856", null, null, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a"), "09/27" },
                    { new Guid("31545caa-0649-4e08-91f1-ba53ef4dba78"), "222", "4925259058195104", null, null, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138"), "04/05" },
                    { new Guid("316a8630-329c-46d9-a20a-783c541f2c1f"), "957", "1926913396483263", null, null, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363"), "02/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("323a1fcc-1bbd-42cf-a0b6-0ef957c0ba28"), "758", "2348772574698868", null, null, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce"), "11/20" },
                    { new Guid("3246bf72-efc2-433f-aec9-116060c73c44"), "585", "8735499960957075", null, null, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8"), "01/20" },
                    { new Guid("32f329cc-d0f3-4b2b-8692-93e2d0a9ec4e"), "536", "2741548179858212", null, null, new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353"), "09/21" },
                    { new Guid("33890211-6659-4325-9cb7-37e8f8e61d86"), "973", "3894851447165546", null, null, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f"), "12/04" },
                    { new Guid("338d3064-5ea6-4347-8ba0-9d9e0cb2e8fe"), "858", "1899076349386708", null, null, new Guid("f0811698-5de9-42a6-a253-8958ca513eb5"), "04/28" },
                    { new Guid("33958c0e-6e5e-458a-9f15-15f8c206c1e6"), "617", "2181515654116529", null, null, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1"), "12/28" },
                    { new Guid("33a72eb7-63b7-400d-8878-e413dc1f29aa"), "782", "7029449766802470", null, null, new Guid("fb455a22-8198-413a-89a8-e92c01f42483"), "06/04" },
                    { new Guid("34e74141-a099-4bab-85c0-3e9d85609538"), "887", "5430365200985726", null, null, new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c"), "06/15" },
                    { new Guid("3518f0da-b42b-4740-b7c7-04b4fb013561"), "803", "7250927331878762", null, null, new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219"), "06/11" },
                    { new Guid("35316ac2-205c-48de-87ea-9e78877c9d51"), "991", "2382043975319329", null, null, new Guid("19034493-ddce-4219-8d74-fbdd26d02300"), "11/14" },
                    { new Guid("3550080b-8249-4108-8503-d56d003c7ff2"), "992", "3649483740423873", null, null, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28"), "06/10" },
                    { new Guid("35726f8a-860d-444a-b19c-01701aafe18d"), "522", "8302165747613179", null, null, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40"), "03/05" },
                    { new Guid("3587baf4-7b26-4bed-aee8-c2367d831d9f"), "611", "2439971266156189", null, null, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c"), "01/22" },
                    { new Guid("35d52e3e-51f0-41ea-84cb-dbd434bb0c54"), "441", "2652972361941951", null, null, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f"), "08/18" },
                    { new Guid("361f1a56-f376-4ab1-84e0-2568a398cf6a"), "987", "3581203336765452", null, null, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058"), "02/17" },
                    { new Guid("3694ba18-d5cd-412a-8418-fe321420e69a"), "228", "3278760817036172", null, null, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a"), "10/24" },
                    { new Guid("37200d28-ba6d-458e-87a3-dbbd7cdd0e56"), "637", "3399571064905763", null, null, new Guid("4e0204f0-eb29-4713-873b-136318951b1d"), "02/18" },
                    { new Guid("3821ecd4-59d4-40f4-b272-612e3e91159f"), "918", "2953376127501705", null, null, new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6"), "01/13" },
                    { new Guid("3833becc-3882-433d-86ed-2c315f34cba6"), "108", "8606286562345581", null, null, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12"), "01/15" },
                    { new Guid("38c7ca70-36ee-41cc-a2c2-df4d6c0005d8"), "415", "3473060925052925", null, null, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89"), "03/08" },
                    { new Guid("39040fe8-b44f-42d1-bad3-1b6f198be864"), "385", "3105728814656559", null, null, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673"), "03/08" },
                    { new Guid("391065d4-3983-460d-90f3-73b436be065b"), "482", "4506551478361402", null, null, new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063"), "04/21" },
                    { new Guid("39638f84-db7c-4e4f-b2c5-dc6dcee02ee2"), "136", "5109250836831322", null, null, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e"), "04/22" },
                    { new Guid("39cc9402-833d-4879-bcd6-f5b373c498bb"), "771", "9829259423880844", null, null, new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8"), "07/09" },
                    { new Guid("3a00ca79-2dc8-4f65-9f6f-a49267a70895"), "883", "3003329598194680", null, null, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70"), "07/07" },
                    { new Guid("3ae223b2-e0dd-47ed-b30e-b0030aa670eb"), "831", "7559297140241240", null, null, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c"), "01/26" },
                    { new Guid("3b961b63-e875-4ddb-88da-b8391b286f36"), "372", "7781246300929450", null, null, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767"), "08/03" },
                    { new Guid("3bc53d13-460d-4586-982e-880b8c114499"), "175", "9077309347363849", null, null, new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4"), "09/01" },
                    { new Guid("3be3906d-3a67-418c-bbf3-8f269721cd1e"), "115", "4435753479134827", null, null, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498"), "10/20" },
                    { new Guid("3c42d9d6-9790-4bcb-9239-8e7b6d7809ec"), "410", "3102482283749728", null, null, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c"), "10/27" },
                    { new Guid("3d50381c-51c3-45fa-b231-759d42e7ab75"), "241", "8164180951013866", null, null, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325"), "02/02" },
                    { new Guid("3d91e8a3-5343-407d-90e8-77895f7a2143"), "100", "8545276195669781", null, null, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363"), "02/12" },
                    { new Guid("3df6127e-b84e-4dc2-ac1b-2a3b96302b02"), "936", "9990691138212899", null, null, new Guid("53a7a51e-d382-4050-82a5-f33ab7641603"), "10/05" },
                    { new Guid("3e2018f0-a891-4948-b075-b2f218abe96e"), "578", "4007245057965867", null, null, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854"), "10/18" },
                    { new Guid("3e626bb5-1019-49ae-93aa-ba3ec8d69c36"), "971", "9558268773702893", null, null, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f"), "01/08" },
                    { new Guid("3e7f5e87-a41d-4901-9d4d-1b8d682312ad"), "525", "4268097078341303", null, null, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c"), "02/17" },
                    { new Guid("3eadad92-c440-4008-9296-52586283c40a"), "211", "2685487562605947", null, null, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b"), "04/01" },
                    { new Guid("3eb70859-9a7c-494a-b49e-e63077c22d11"), "282", "4233184874373095", null, null, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e"), "07/23" },
                    { new Guid("3ebdfc15-b65b-4e1e-8538-c61bac588fef"), "101", "2051757884094803", null, null, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845"), "08/09" },
                    { new Guid("3ec1ee86-7904-44ad-8210-f239a917f79a"), "461", "1447481223972721", null, null, new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372"), "05/07" },
                    { new Guid("3ed38d0d-ea15-4b79-95da-cb6ee31faab4"), "799", "7507252438138337", null, null, new Guid("8461c967-9f1c-48cc-85ae-66b9741be768"), "08/06" },
                    { new Guid("3eddef4c-bc1d-40d3-8d95-156378e7c952"), "120", "3872320548281468", null, null, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3"), "03/17" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3eed3a74-e1fa-42aa-9d02-201ef2545ea8"), "327", "6236038949379080", null, null, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b"), "01/15" },
                    { new Guid("3f00826c-9226-442e-b333-7298283a5763"), "197", "2495003066312771", null, null, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d"), "05/24" },
                    { new Guid("3f5cc9fd-f493-4d3a-ae15-aea45e008f27"), "888", "3977946988296455", null, null, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), "08/02" },
                    { new Guid("3f761c16-8369-4ffa-9b61-931d0bfc2fde"), "255", "8098576423700606", null, null, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b"), "09/25" },
                    { new Guid("3fa1c847-dc89-4b1c-9848-ea5304644982"), "097", "1588264670315451", null, null, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87"), "02/02" },
                    { new Guid("3fca66e1-c755-4cb3-9029-dcb79460f0fa"), "413", "1347959182328262", null, null, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70"), "02/25" },
                    { new Guid("3fd6d60d-4516-490f-9e4e-0e291ab5b318"), "826", "6204087875434449", null, null, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a"), "09/11" },
                    { new Guid("40886d8b-cdaa-4697-8c62-717465947b8b"), "509", "9051963107444576", null, null, new Guid("8be83005-0ddc-42eb-877d-582666d35fea"), "08/27" },
                    { new Guid("4097166b-2b1a-43e3-b9d8-f8131ff547fb"), "308", "5205123384438041", null, null, new Guid("98ec5653-7775-432e-9be5-3149a15fca62"), "05/24" },
                    { new Guid("40a44a89-a061-4153-af78-51380500b8dd"), "124", "2454235319078877", null, null, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d"), "11/27" },
                    { new Guid("41119d9a-f772-49ae-9d31-3c10c397a95f"), "375", "3574262366001004", null, null, new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6"), "03/03" },
                    { new Guid("41588d1b-1e5f-4bd0-ac6c-eebe70b33d83"), "326", "3166742992681917", null, null, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf"), "06/13" },
                    { new Guid("41ee13ca-5fe0-4da4-818f-f79ee9b98295"), "356", "2734875403183475", null, null, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc"), "05/21" },
                    { new Guid("42241dc8-f9e7-44cf-8cc0-13fa12b83e8c"), "891", "9390451338622768", null, null, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4"), "07/20" },
                    { new Guid("4351eba7-5ecc-467b-90da-b0b9a7a109c0"), "049", "1927255795414955", null, null, new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04"), "06/03" },
                    { new Guid("441b6cea-7e73-46e3-94a9-5dd8d09526d0"), "993", "3659497589870249", null, null, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b"), "12/27" },
                    { new Guid("443c31d7-210e-44d1-8f0f-dab3ed166e01"), "970", "4997674009611623", null, null, new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117"), "03/23" },
                    { new Guid("44c9139d-e31e-4995-b619-2a3ac9eda97c"), "548", "4112224758327802", null, null, new Guid("0b98923c-0481-432f-9b60-33427e4d8223"), "05/05" },
                    { new Guid("458c0e37-f694-41e0-96f7-154b2989cd43"), "065", "3865027265757144", null, null, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8"), "07/09" },
                    { new Guid("458c1ba6-4b70-400d-a744-166b74ca724f"), "819", "8582185775633430", null, null, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553"), "01/17" },
                    { new Guid("45a215d3-d211-4ff8-aff9-3a46d3f4ff82"), "119", "4040095344586615", null, null, new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc"), "12/19" },
                    { new Guid("45ae9ee3-8589-4626-893f-18c6e351f631"), "927", "9156727226325116", null, null, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5"), "04/02" },
                    { new Guid("45bc3e88-53e3-43fa-9490-5c9fdc6a190f"), "390", "4977353443217947", null, null, new Guid("45649949-0283-499e-b496-44660ddab1e4"), "02/11" },
                    { new Guid("45e3bd19-9cb5-4778-99ee-50ebfefad57b"), "015", "2701951538793889", null, null, new Guid("08094f90-68b7-4576-a740-581a4878e4ab"), "03/08" },
                    { new Guid("4672d318-002d-4338-8785-ec4d77bbbf07"), "127", "6631747695284668", null, null, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b"), "11/28" },
                    { new Guid("467e3187-00ca-4737-9d72-7e29e5d5d2d1"), "322", "2638993528137462", null, null, new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1"), "04/02" },
                    { new Guid("46897143-d95c-4a0c-abf0-fc383b8e1575"), "469", "5636545588318809", null, null, new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1"), "04/03" },
                    { new Guid("46ba3b2b-0584-4c49-89e7-75b3ed20c3fd"), "640", "5901520763382344", null, null, new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799"), "08/22" },
                    { new Guid("478bfca7-1654-43e0-874d-a26390cad863"), "945", "4171904314686189", null, null, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40"), "01/19" },
                    { new Guid("48500f61-7a4d-4533-a481-42cc4b082383"), "999", "3754113024176036", null, null, new Guid("816326af-094b-4b97-b10b-548a2296766b"), "12/03" },
                    { new Guid("4883ab5a-76a1-4b29-8126-cf6182219d15"), "983", "5688178945886676", null, null, new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5"), "12/15" },
                    { new Guid("48bdd03f-5d56-46fb-b1e5-9ab83a86717f"), "225", "3052656831969668", null, null, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a"), "02/19" },
                    { new Guid("48d1ec9b-bc4b-4cea-b8f0-48cce628b89e"), "125", "5313695666098818", null, null, new Guid("78016c36-672a-4efd-980e-250a79e4d32e"), "10/18" },
                    { new Guid("49604004-9f68-4df8-afc9-d9292037bffd"), "420", "4643802890593582", null, null, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477"), "12/20" },
                    { new Guid("49aaad00-6988-4127-a631-727b6f405d9e"), "344", "5620698953583005", null, null, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217"), "04/02" },
                    { new Guid("49abc1cb-b26d-4857-a16e-20d11b1d883d"), "599", "2527445846351966", null, null, new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38"), "02/15" },
                    { new Guid("49c26feb-6065-49e1-9fd6-1533fa07df0d"), "797", "7028732984951330", null, null, new Guid("cc9fd67a-df81-4c57-9231-20a528617118"), "01/26" },
                    { new Guid("4a31b779-1fd0-4b60-96cb-81cff22dd7b7"), "462", "3134168587860920", null, null, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40"), "10/16" },
                    { new Guid("4b14feb0-855c-4b9d-8320-81929c524a27"), "622", "1232544022830295", null, null, new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1"), "02/08" },
                    { new Guid("4b508363-8314-4822-b5ee-27ffc492e695"), "490", "7574347775525030", null, null, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854"), "10/08" },
                    { new Guid("4b5f85d4-402b-45b0-8bcc-5f87931d4b0c"), "804", "7272582324950436", null, null, new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc"), "10/28" },
                    { new Guid("4bb157fd-83b4-4f5d-b3ce-a671e7daccfa"), "688", "7127038063040877", null, null, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689"), "12/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("4c34ec0e-62b8-4ae0-8279-289c446cba44"), "977", "1062985550397635", null, null, new Guid("19341891-e9b6-407e-aea5-b35513589e26"), "04/04" },
                    { new Guid("4c40f7da-cde5-4222-b59c-773873032416"), "479", "9739567527313660", null, null, new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5"), "10/12" },
                    { new Guid("4c6f574e-eee0-43ae-927b-01256477b86c"), "141", "7869574691571910", null, null, new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64"), "06/12" },
                    { new Guid("4c70dc5d-eea3-4961-af8d-8fef6cc56125"), "817", "9747645785095217", null, null, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1"), "12/23" },
                    { new Guid("4c9c1496-1117-4715-8363-879283b1f66d"), "504", "9771575856740292", null, null, new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379"), "06/10" },
                    { new Guid("4cb5c284-2f19-4af8-8176-cf605141d3e3"), "500", "3624076762210905", null, null, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b"), "08/26" },
                    { new Guid("4ceaf7ab-94aa-46a7-8289-4293fd3530f6"), "804", "9659814232505338", null, null, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f"), "06/04" },
                    { new Guid("4d0eab3d-b454-4f1b-969d-1e1e78604341"), "717", "3837471936768354", null, null, new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2"), "05/07" },
                    { new Guid("4e2b9725-01ee-4e95-af28-f3192ced92eb"), "571", "3725335209654540", null, null, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065"), "06/01" },
                    { new Guid("4e75a129-1cfe-4c1a-8052-d1b1057ee02c"), "718", "2951128442761528", null, null, new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd"), "05/24" },
                    { new Guid("4e814c90-b7ae-4222-9f52-39d1c6a140ba"), "532", "3287432793558283", null, null, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754"), "04/01" },
                    { new Guid("4ec29fba-7ca6-4c55-8615-31207b779ae0"), "410", "2869553239644963", null, null, new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), "07/16" },
                    { new Guid("4f0f42d7-a7a9-490b-8bf9-d31b790363a1"), "490", "9521017498278751", null, null, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334"), "02/06" },
                    { new Guid("4f189903-1da2-4acb-82cd-4c66d2ad7662"), "579", "2400194217558787", null, null, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8"), "03/24" },
                    { new Guid("4f596d5f-8c20-413f-adcf-4f24c2cb6bb7"), "344", "5513690596586136", null, null, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59"), "03/27" },
                    { new Guid("4f59faf0-b338-40e0-8639-fc2a2dcddf72"), "916", "2013092153737932", null, null, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5"), "11/11" },
                    { new Guid("5056d670-0a2d-4878-a646-cbc0edbc3141"), "282", "9622934497891746", null, null, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673"), "12/12" },
                    { new Guid("50680c06-f353-48c1-a182-8c36ee1c83a5"), "555", "3844479880027503", null, null, new Guid("19341891-e9b6-407e-aea5-b35513589e26"), "03/23" },
                    { new Guid("507d9361-f223-42a5-ab85-556ccabe34a6"), "739", "8443100553974995", null, null, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656"), "04/05" },
                    { new Guid("5156a707-50c1-4d2f-8b2e-0058bfe3c798"), "228", "2444086218269651", null, null, new Guid("f027517a-8745-4767-8a34-aaadc0a70189"), "02/24" },
                    { new Guid("5168ebf3-4b3a-48dc-b709-62e340760fe8"), "408", "9728164566357449", null, null, new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117"), "06/10" },
                    { new Guid("5175b822-9801-4feb-b8fb-183cafe16e54"), "938", "9696149353873947", null, null, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334"), "10/10" },
                    { new Guid("51bcb857-55aa-40d0-905d-7ec9adbc7dac"), "919", "5455971031833731", null, null, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e"), "05/13" },
                    { new Guid("51caff52-85ec-4506-bdf9-dc29527e5711"), "008", "9696200242881478", null, null, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066"), "10/11" },
                    { new Guid("52804682-8970-47db-8730-fefba44d2f2f"), "445", "7338642253949435", null, null, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98"), "09/24" },
                    { new Guid("52ad68a9-9321-4b81-8a6e-ca7631885961"), "564", "2097476942542177", null, null, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770"), "12/09" },
                    { new Guid("52c00570-8e9f-43fd-a3c9-d25ce737e6a5"), "493", "5776443880334058", null, null, new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291"), "06/24" },
                    { new Guid("53032487-cbe5-4b58-b93e-a87f2ba0b36c"), "271", "2331889877606658", null, null, new Guid("fb455a22-8198-413a-89a8-e92c01f42483"), "12/24" },
                    { new Guid("534b48c3-c746-4b24-8c67-47a4340a38ee"), "551", "3851912192772173", null, null, new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470"), "02/03" },
                    { new Guid("534b7429-a438-48ef-8382-298e62551f27"), "314", "7624272752079298", null, null, new Guid("99227d48-6d3f-45fd-971b-83f0198ee703"), "03/18" },
                    { new Guid("536c41cd-5bd4-43f9-ba9c-f27b0df522d3"), "972", "7737618218562060", null, null, new Guid("8905b747-db92-42c9-8385-1d49f6b8e578"), "11/24" },
                    { new Guid("53df0e34-af86-49b8-a46a-305df76933b8"), "715", "9705780464513457", null, null, new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a"), "04/06" },
                    { new Guid("54180e5a-c581-4142-846a-b195a8e0a555"), "797", "8284912856903153", null, null, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3"), "01/27" },
                    { new Guid("54ed2451-a585-4226-bf75-cba22f3214ef"), "480", "4059246892842015", null, null, new Guid("77f944f9-c758-4983-b702-656640bf5672"), "03/07" },
                    { new Guid("557a3750-d78a-48c1-911e-9762f805728f"), "758", "7853130198711969", null, null, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be"), "09/23" },
                    { new Guid("55a69b08-633c-4298-9cde-8224d806f11f"), "187", "2232061413160342", null, null, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b"), "05/05" },
                    { new Guid("56e71732-32bf-46ae-81a3-f1e4c8f30951"), "041", "1700410569984127", null, null, new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018"), "09/13" },
                    { new Guid("570175d1-09b1-4425-a16b-34739202294b"), "097", "9886568963369671", null, null, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9"), "08/15" },
                    { new Guid("577098df-cc30-4700-8d74-9d5e91b27020"), "063", "7374243693833276", null, null, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065"), "01/27" },
                    { new Guid("57ec221f-7a0d-4d42-a526-fd567747c171"), "334", "1590550653155410", null, null, new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd"), "05/13" },
                    { new Guid("585ad3c8-d90b-4a9a-977a-537f039e88dd"), "744", "3027180156868829", null, null, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d"), "07/19" },
                    { new Guid("588f2564-670c-4f9a-ae7f-a3b9e991c5f1"), "251", "3060107352742898", null, null, new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665"), "06/27" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("592ea816-a19d-4911-ac93-28671f35f676"), "668", "4831794622111208", null, null, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0"), "03/28" },
                    { new Guid("594b7e5c-4e3c-4bb7-95c1-abc6bfd6758f"), "461", "6298758851127630", null, null, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce"), "05/12" },
                    { new Guid("59a438e2-f514-4f98-ba1c-aad0ecc691bd"), "162", "1085922518063944", null, null, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca"), "11/08" },
                    { new Guid("5a0b21a6-c183-4329-9c54-172d78bb2766"), "252", "8144650505367670", null, null, new Guid("97fd604a-eb78-4e29-829c-caf68b162e92"), "03/12" },
                    { new Guid("5a4b9e88-2732-40b2-b9ba-799a3b14daa6"), "115", "4443073129063659", null, null, new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9"), "06/26" },
                    { new Guid("5a571213-d631-4291-92ac-f3397ec774ff"), "542", "8439314005317508", null, null, new Guid("0b98923c-0481-432f-9b60-33427e4d8223"), "06/06" },
                    { new Guid("5ccfdc69-9c7e-4f0e-9f8b-93d079783995"), "620", "1381882651622351", null, null, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321"), "06/19" },
                    { new Guid("5df0de28-ae9a-4df5-bf94-995df820d069"), "179", "4859392603982142", null, null, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010"), "06/26" },
                    { new Guid("5dff6a93-d3f6-4373-ac2e-ac2613a52f0f"), "986", "3083058034449069", null, null, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f"), "03/24" },
                    { new Guid("5e657b9a-c4d2-48da-9118-890ab2bfe188"), "596", "4747438526691309", null, null, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9"), "02/11" },
                    { new Guid("5e92a8ad-f6ef-4d80-b9f2-a76e9b7525b3"), "796", "8411071544872752", null, null, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d"), "11/17" },
                    { new Guid("5f2dca2d-a020-4a88-a1d7-dbda9f193c87"), "392", "4419893458685639", null, null, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2"), "06/18" },
                    { new Guid("5f8aca8f-ee7d-45bd-867a-005862c41122"), "355", "6522845656767225", null, null, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc"), "01/15" },
                    { new Guid("5fac70fb-36cb-4c89-976b-9d6c8b6c90c2"), "872", "4681712813907570", null, null, new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7"), "09/09" },
                    { new Guid("60252ad0-0504-49ce-8cc7-645d6cc0721f"), "320", "2013855888118618", null, null, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be"), "09/20" },
                    { new Guid("6076449a-2253-465a-8139-791290f4c68f"), "114", "6175678685156708", null, null, new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2"), "05/12" },
                    { new Guid("608cc533-940f-4b1f-9720-3726afaf649c"), "674", "5105418381288862", null, null, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1"), "06/24" },
                    { new Guid("60d733ca-a3c6-4ec6-88cc-601646a2742d"), "700", "1207096157928044", null, null, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8"), "10/13" },
                    { new Guid("60dd5f0a-e776-44a9-b513-48ebe1b7eca4"), "644", "9711559742766682", null, null, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9"), "10/17" },
                    { new Guid("612488c8-75eb-4629-8032-fbb55a0f57a4"), "975", "5334364051286219", null, null, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a"), "05/02" },
                    { new Guid("61a12f5e-30ed-4e60-a403-13efb5670e38"), "891", "6022045617498400", null, null, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363"), "12/16" },
                    { new Guid("61ed4f30-bc8b-469a-bccf-2258a00f32b6"), "547", "6051248954641139", null, null, new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef"), "12/12" },
                    { new Guid("61f799ab-6fc9-4796-81da-796cbd3235c6"), "459", "1521767390028563", null, null, new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8"), "10/11" },
                    { new Guid("6256c156-2353-47b0-85e2-8ef9147f783a"), "302", "8718570502019947", null, null, new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8"), "06/02" },
                    { new Guid("62dc1759-d739-4a1c-8db4-8faa41945b75"), "287", "6604585940190054", null, null, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767"), "06/19" },
                    { new Guid("632de3eb-d0ad-4029-a1a3-7b6b42a362d0"), "381", "6810110806535524", null, null, new Guid("7573b136-e686-46e6-b0af-1186d8e37af1"), "12/15" },
                    { new Guid("634e00d2-396e-4edb-848a-98e42b503a17"), "632", "3394481907149947", null, null, new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45"), "09/01" },
                    { new Guid("63ed5bb3-a027-4662-b2ef-351249e5636c"), "314", "3662842998953893", null, null, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770"), "04/27" },
                    { new Guid("643c9600-2d6f-4dc4-93e4-9def016ae422"), "377", "1858507169758313", null, null, new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45"), "06/22" },
                    { new Guid("6467233d-4ba0-4cdd-9fe0-5200b5375dd0"), "063", "6767371969449448", null, null, new Guid("78016c36-672a-4efd-980e-250a79e4d32e"), "04/12" },
                    { new Guid("64d6c7ba-4243-42e2-9822-e04711adf866"), "373", "2819203708899427", null, null, new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67"), "03/25" },
                    { new Guid("65d4a4d1-d6dd-48b4-94aa-5da15a8469d4"), "475", "7325617729318951", null, null, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc"), "03/09" },
                    { new Guid("65ef274a-d72e-433b-bc00-8a8f4e2d9a7d"), "882", "8606902538671016", null, null, new Guid("862a826f-0eba-4891-9241-dff3a8896969"), "04/05" },
                    { new Guid("6613b772-d0ea-42f1-910c-f51d71847a0b"), "066", "5477334660918175", null, null, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89"), "03/17" },
                    { new Guid("6619284c-5eac-45c7-ad23-e36cb161b3db"), "528", "9569378021233886", null, null, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be"), "10/26" },
                    { new Guid("66df9857-6aba-4d5a-9713-5ad0034d97cd"), "009", "6264664368759359", null, null, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c"), "10/20" },
                    { new Guid("672d4068-d600-4ebb-b5a1-2fe468e43384"), "645", "8840311193039488", null, null, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673"), "07/23" },
                    { new Guid("67553b66-8da3-4a1d-8597-dfb2fcc16477"), "093", "6412328577864685", null, null, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656"), "06/24" },
                    { new Guid("6783df4d-af8e-4845-9696-101409a886e4"), "833", "3351450074733954", null, null, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9"), "10/13" },
                    { new Guid("680ac7f2-eb13-493b-a186-de29dc16e52d"), "704", "3186763012882419", null, null, new Guid("46568224-f301-4805-9ce4-f87ec0533c46"), "03/26" },
                    { new Guid("687be01b-202e-4a16-ac73-43c817fec535"), "903", "2217277628352582", null, null, new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594"), "12/20" },
                    { new Guid("688e1fab-db08-4f05-8aad-1571f3f32036"), "855", "1987146718101027", null, null, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09"), "12/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("68da1f49-8b64-4db9-a022-b6336ca96832"), "794", "3592578483976938", null, null, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0"), "06/13" },
                    { new Guid("692acdc2-5702-48e4-91d5-d6b05b01532d"), "719", "2191110872606757", null, null, new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2"), "05/15" },
                    { new Guid("69f2e9bb-867d-41e6-9ee6-d45e7bfb3907"), "960", "2987321295673816", null, null, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87"), "04/18" },
                    { new Guid("6a1b3790-63f1-402a-ae8d-d1609699f40c"), "604", "8319938987266217", null, null, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc"), "10/15" },
                    { new Guid("6a9ef899-2fa5-49a3-a0ff-49cf3ff021bb"), "839", "9097930937576042", null, null, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8"), "03/15" },
                    { new Guid("6aa87bb0-d278-403d-916d-268e7b0d3712"), "258", "3381176246952125", null, null, new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f"), "12/02" },
                    { new Guid("6aa89613-e36d-4f37-9971-0d51608867f4"), "281", "3599683399901429", null, null, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc"), "11/26" },
                    { new Guid("6b10ad78-def4-4113-b667-ea831fb4fd71"), "223", "5850717728187448", null, null, new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731"), "04/12" },
                    { new Guid("6ba1ddfd-1927-43e6-87ad-cd1470f860ff"), "340", "1864895030001614", null, null, new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc"), "06/20" },
                    { new Guid("6babd99e-8da7-433b-aa3f-c7737df4aa7e"), "511", "3591583320782759", null, null, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87"), "08/13" },
                    { new Guid("6bdaaa31-ac92-4b1e-b563-f525714d8932"), "197", "1440858969034555", null, null, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d"), "03/14" },
                    { new Guid("6c36a724-60cc-4f06-9265-e4dffb732913"), "689", "3953377755294158", null, null, new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614"), "05/22" },
                    { new Guid("6c56acca-97ca-471c-9389-18b75988d1f0"), "483", "6690935389596273", null, null, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8"), "06/17" },
                    { new Guid("6c627695-f3e8-4cef-83d5-15c5435b9fe8"), "844", "9566180003308683", null, null, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d"), "09/09" },
                    { new Guid("6efdc0a6-b27c-4cee-bcdf-9472dcbcc2d6"), "423", "7810049366628835", null, null, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc"), "07/11" },
                    { new Guid("6efe6d5e-1f1a-4d63-bb29-92255aa43c6f"), "150", "6112199181099415", null, null, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce"), "03/09" },
                    { new Guid("6f0ca34a-ffa5-4806-b0d3-48df72024b66"), "827", "8217680279380201", null, null, new Guid("19034493-ddce-4219-8d74-fbdd26d02300"), "05/06" },
                    { new Guid("6f5a1578-994f-4ae4-b0b0-972a1c4bf5f1"), "032", "9126452626882690", null, null, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0"), "07/26" },
                    { new Guid("6f8033f8-7d41-4730-80f0-6162907e1cb7"), "928", "4168321365446020", null, null, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8"), "04/28" },
                    { new Guid("703372ec-4bd5-4b40-9b70-239a498f0c0e"), "187", "5741436274438262", null, null, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c"), "02/14" },
                    { new Guid("7038ea11-b342-400e-8a5f-029b9a980520"), "604", "6230000887347713", null, null, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a"), "12/05" },
                    { new Guid("7039fb3c-baaa-4bd4-b90d-7210e18d440f"), "627", "3305093346929004", null, null, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5"), "05/16" },
                    { new Guid("70f576e2-f336-4824-9c45-59cc706b90c2"), "935", "1019234965623058", null, null, new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc"), "07/26" },
                    { new Guid("712642f1-3fc4-4b07-8045-df33c4b467fe"), "277", "6213014574821910", null, null, new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594"), "06/26" },
                    { new Guid("71292d1e-e2a5-4f76-8d0b-117ee301dc3e"), "669", "8919541805580952", null, null, new Guid("35187412-3a05-415f-8523-ec24e84b1221"), "08/07" },
                    { new Guid("714a0129-871e-4671-95a6-af2e9fef39ee"), "647", "5096850912828708", null, null, new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73"), "07/10" },
                    { new Guid("71ba613c-5dde-4b30-b657-b14214f89c4d"), "900", "6893816872093334", null, null, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61"), "08/09" },
                    { new Guid("71baf0e9-b6a6-4bda-aafa-cff786c893e1"), "711", "7547516152219434", null, null, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece"), "02/03" },
                    { new Guid("7204aaa3-7a3c-4d3a-8c34-0246eff806bb"), "336", "3581176809970543", null, null, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921"), "09/12" },
                    { new Guid("723461af-d571-4f38-bb48-abc06f9d94e5"), "893", "1043895077206995", null, null, new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4"), "11/25" },
                    { new Guid("72a38fc8-daac-447f-a9f2-6aeef5d3c4f2"), "755", "1159730180623598", null, null, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc"), "10/06" },
                    { new Guid("72ae19ee-eb9b-4206-82ee-e2603a76b1cd"), "925", "7267454872957463", null, null, new Guid("de956589-c440-4477-908f-fd0e51a90148"), "05/11" },
                    { new Guid("72e87dcc-016a-49ec-9ede-644868587922"), "064", "4858339340296213", null, null, new Guid("30e31307-3bbc-4483-bf55-601427ba031c"), "11/10" },
                    { new Guid("739d8dc6-6d30-41fb-8427-472d85277dbd"), "880", "2050279754873955", null, null, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321"), "09/19" },
                    { new Guid("73df38ff-c48e-4a1c-b3e9-2263bf2f9e86"), "899", "3371717555434775", null, null, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e"), "08/18" },
                    { new Guid("73e8b75c-b81c-42cb-8d42-c42f2c875493"), "689", "3075406878292820", null, null, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5"), "09/09" },
                    { new Guid("73f75de7-5876-4baf-92d7-689fb3a4ee2b"), "953", "5497589500936438", null, null, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e"), "07/28" },
                    { new Guid("7444ad88-3dc4-469c-96c7-0b0fd19b1ce3"), "341", "3629053505425498", null, null, new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7"), "06/14" },
                    { new Guid("74695045-7861-476d-8ee2-ff05f6596ae8"), "364", "1166190046416291", null, null, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1"), "05/22" },
                    { new Guid("74b76881-a786-4e71-869c-7ad5b41800a1"), "473", "1055946240886892", null, null, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673"), "07/14" },
                    { new Guid("74db98ed-e1cc-4e18-a90f-ffee2693f78d"), "820", "7480175230485484", null, null, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc"), "02/05" },
                    { new Guid("75500fa6-fc3b-4731-b3f6-fa862eb2285f"), "660", "9692322505888188", null, null, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1"), "02/08" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("75684cce-95b6-4ff2-8c07-56d1dd895c2f"), "185", "2257907160638298", null, null, new Guid("f0811698-5de9-42a6-a253-8958ca513eb5"), "04/02" },
                    { new Guid("75992bd1-8c47-43d2-aa50-32d7b5e70305"), "862", "3254928308138609", null, null, new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500"), "06/03" },
                    { new Guid("76023085-20da-45c2-8cf2-694e00730fb0"), "475", "9820427572670536", null, null, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b"), "12/26" },
                    { new Guid("7725b8d8-d2c4-4547-8af1-22bed22f35f3"), "873", "1576376068736690", null, null, new Guid("45649949-0283-499e-b496-44660ddab1e4"), "05/12" },
                    { new Guid("7734fb5f-a8a1-4a38-a8c4-143cccc41d7e"), "459", "9851837172219490", null, null, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70"), "05/01" },
                    { new Guid("777d02e5-0992-45b4-9f6e-cd21e9388d3b"), "725", "9061408634765639", null, null, new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739"), "11/06" },
                    { new Guid("77ceaa7c-ed44-4104-b42c-6adef9ef798e"), "722", "1682309509036392", null, null, new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44"), "01/27" },
                    { new Guid("785ad220-e30a-4c6f-aa4e-cc98f5952ad0"), "492", "6199321359459107", null, null, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6"), "12/15" },
                    { new Guid("7895c74d-c705-4202-9efb-4765775c045c"), "366", "7206205917795719", null, null, new Guid("4f03daca-02fb-425a-a575-bef52173e4d3"), "05/01" },
                    { new Guid("7952d7a0-28c3-4b87-a757-e45b81eeba2d"), "101", "7027104464566249", null, null, new Guid("5ffc49e2-50fb-41f2-8784-192077f86010"), "10/02" },
                    { new Guid("79747873-48bc-464c-834c-e927989f4c83"), "903", "5647610957754354", null, null, new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5"), "06/19" },
                    { new Guid("79992c38-07aa-4c0e-aca9-57b2a222c270"), "456", "7512531273754921", null, null, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b"), "06/09" },
                    { new Guid("799a2463-a2b7-4e91-9409-231a10905f15"), "219", "5723628453942755", null, null, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc"), "09/03" },
                    { new Guid("79a8a3dd-3083-445c-b85c-99b7a2a6ff7e"), "097", "6189595938372237", null, null, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc"), "04/06" },
                    { new Guid("79f779ad-3286-4d38-8914-b9afd87cfc00"), "987", "3640950109187928", null, null, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138"), "11/26" },
                    { new Guid("7a5774d5-ab9c-47f3-b8ed-b6df82e87a50"), "520", "3466308580743049", null, null, new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da"), "06/28" },
                    { new Guid("7a610484-a288-4f47-99e7-75d98b889030"), "348", "6137891323551236", null, null, new Guid("35187412-3a05-415f-8523-ec24e84b1221"), "05/01" },
                    { new Guid("7ab47aa0-ee5b-4de9-b546-897e0fd4fdeb"), "862", "9180637814574279", null, null, new Guid("52f24d75-fa03-403f-8430-5ca835f68726"), "04/17" },
                    { new Guid("7b2296a7-19a5-441e-a28c-c414e921b8eb"), "005", "5319482676077664", null, null, new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2"), "03/24" },
                    { new Guid("7bfdbe18-2ac8-428c-bfef-247623561b7f"), "852", "8676142403844122", null, null, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921"), "12/20" },
                    { new Guid("7c572c67-5f34-4e8c-a782-08283fe80259"), "457", "3670893718859082", null, null, new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d"), "12/19" },
                    { new Guid("7c641957-1b57-4e57-8557-6bef49eaf4dc"), "588", "2239741621281213", null, null, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2"), "06/12" },
                    { new Guid("7d4cdb5d-71a2-4b32-bf32-a04957097f8a"), "854", "5345371126255002", null, null, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6"), "02/08" },
                    { new Guid("7d5ef1d7-ea1f-4883-bae7-eb559e25d00b"), "368", "6800580962774085", null, null, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b"), "07/17" },
                    { new Guid("7d641cb5-df42-4f69-8f8e-30cfaceafb69"), "248", "2304784984212947", null, null, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b"), "05/23" },
                    { new Guid("7d854989-085b-41d9-b1a6-72a41960557d"), "433", "4131796552054851", null, null, new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500"), "09/28" },
                    { new Guid("7d885df4-9b95-4dc7-902e-901b099444df"), "699", "4091453313237189", null, null, new Guid("30e31307-3bbc-4483-bf55-601427ba031c"), "12/04" },
                    { new Guid("7d9df186-34f8-4a29-8fc9-8b97b1f0114a"), "373", "3750061133675477", null, null, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be"), "01/20" },
                    { new Guid("7da543c3-f565-4db3-a1ee-38c1aca97b23"), "621", "3870148023487397", null, null, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d"), "09/24" },
                    { new Guid("7f24e9ae-963b-42a3-8bf1-5dcc2a00aecf"), "471", "9704860476076913", null, null, new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9"), "07/03" },
                    { new Guid("7f838d36-3c97-4e06-91a1-9ccebe3fb6c5"), "156", "8169647288794490", null, null, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3"), "01/28" },
                    { new Guid("7f9055dd-0757-44d5-a1e9-eab895b69d07"), "856", "2767119177498101", null, null, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d"), "12/05" },
                    { new Guid("7f91499f-c1db-4267-b87b-4d9914ad200d"), "140", "8193025483935430", null, null, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc"), "01/13" },
                    { new Guid("7faf3bf0-897f-42a2-9d20-d3fe4797dec4"), "878", "9348726664902130", null, null, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b"), "09/20" },
                    { new Guid("7fc21b13-1d78-42e4-9ecf-6517a1b99f25"), "054", "6059054767219241", null, null, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1"), "08/12" },
                    { new Guid("7fca3bfe-ecff-4e96-be13-a21919b121d1"), "661", "8545752588050640", null, null, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9"), "04/28" },
                    { new Guid("7ff7a3db-151b-4650-ac9f-6e3952ea4387"), "692", "9504887763217791", null, null, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024"), "11/04" },
                    { new Guid("8023d8ad-d9f3-45d6-a8f0-50ac20063983"), "492", "1627761152235878", null, null, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37"), "06/05" },
                    { new Guid("8049156d-24a7-4164-825c-63d3ccf9cb3a"), "648", "9897863559397192", null, null, new Guid("30b2066d-f465-42ae-93e3-4a38936052b2"), "05/15" },
                    { new Guid("80613ed2-2af1-4b0e-844d-ce9dfee689cd"), "053", "7410487755195205", null, null, new Guid("f027517a-8745-4767-8a34-aaadc0a70189"), "04/08" },
                    { new Guid("8162a433-a528-4b5b-b731-a7dd231cdfa8"), "304", "9671460905959859", null, null, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b"), "09/27" },
                    { new Guid("81d81043-5e34-4abc-9446-209348ca0359"), "933", "2301584867189162", null, null, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729"), "02/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("82039b1e-8feb-415a-9e14-3ae68ee482e1"), "056", "3832236877513028", null, null, new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa"), "08/08" },
                    { new Guid("8206ee67-22b7-471b-be6b-5d9c6e88f53e"), "985", "3256911765945905", null, null, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a"), "09/08" },
                    { new Guid("826a0bd0-af83-451f-b7a6-bd257048ecc7"), "087", "2235485554677902", null, null, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b"), "04/26" },
                    { new Guid("8294432b-8b38-4b3e-8d83-f9fc46aa56b8"), "998", "3243484087480547", null, null, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18"), "12/20" },
                    { new Guid("82b26447-588d-4339-a26a-2c2da62cc2a3"), "368", "5584753276451088", null, null, new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1"), "05/02" },
                    { new Guid("82ec3867-0884-47f2-9e5b-295f27b0e455"), "513", "1828579402686026", null, null, new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04"), "08/19" },
                    { new Guid("83208f03-9bb1-4610-b263-37a341d95045"), "530", "4109853458037053", null, null, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a"), "02/11" },
                    { new Guid("832c16b2-a767-44c0-a711-cacaa4c76993"), "308", "4273870562732318", null, null, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1"), "02/05" },
                    { new Guid("839c47d2-6c44-4579-95ef-7874417c201a"), "487", "4452983157512322", null, null, new Guid("9d7effeb-d071-4689-a103-74400c1c3344"), "10/14" },
                    { new Guid("845d1876-9055-4e9b-a095-bc4da9d8188b"), "423", "6635895588342301", null, null, new Guid("97fd604a-eb78-4e29-829c-caf68b162e92"), "12/07" },
                    { new Guid("84686a58-32f7-4fef-a6b4-f7c5d7c1b82c"), "549", "1370190804576084", null, null, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024"), "05/26" },
                    { new Guid("84d5beb8-2b25-4ccb-8c19-3b53220bfc7e"), "678", "4858094558187933", null, null, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058"), "10/14" },
                    { new Guid("84f3ee83-6c4b-4d72-a330-f4c027e5ec9a"), "524", "4032352961213946", null, null, new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228"), "05/13" },
                    { new Guid("85450aae-a5a3-404c-9a3b-c051201fc87f"), "884", "9541157271862311", null, null, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28"), "07/22" },
                    { new Guid("854fbf51-85cb-4b0d-8cbc-d9cd637383d8"), "714", "9579068246953796", null, null, new Guid("6bf86772-9995-44ea-a063-ccc583990881"), "01/03" },
                    { new Guid("8589f00d-436b-48dd-b7fe-aa756e021851"), "991", "6659876402824697", null, null, new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec"), "08/05" },
                    { new Guid("85be56cf-f45c-47cb-99f0-5592709bd0ea"), "274", "4174794896953902", null, null, new Guid("98ec5653-7775-432e-9be5-3149a15fca62"), "11/23" },
                    { new Guid("87026f55-dadb-422f-a0dd-aa2aa223f48c"), "024", "1770973475103340", null, null, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc"), "03/19" },
                    { new Guid("873bd1ca-c7c3-47d7-a43c-c65e4b3d665b"), "846", "1480778369673249", null, null, new Guid("4ea29651-f292-4cbf-8413-d8821c394155"), "07/09" },
                    { new Guid("873e3deb-a047-43ff-968c-c6484318acbf"), "437", "6508663335748112", null, null, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138"), "11/13" },
                    { new Guid("875afe0a-1dae-42b2-9a61-dd666a9d7b7c"), "242", "1536707961043063", null, null, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770"), "01/10" },
                    { new Guid("875e381f-4de6-4e3d-a5f3-f25a3a3f042f"), "520", "4368852016791996", null, null, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c"), "11/23" },
                    { new Guid("87c9251f-fc60-4d31-94d7-86bd889377e5"), "251", "5014993767061046", null, null, new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf"), "05/19" },
                    { new Guid("87fbb728-7e47-4a52-b2fc-ba1e626576c8"), "353", "9131996394656450", null, null, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc"), "11/10" },
                    { new Guid("8844c254-1240-464f-af71-81130dd37bf8"), "168", "6393061225214515", null, null, new Guid("14616263-d2fa-48db-a24a-d892043c3e33"), "03/07" },
                    { new Guid("88537528-c8f7-4c91-af29-7ea8ac0a2308"), "547", "8637403592033926", null, null, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1"), "08/14" },
                    { new Guid("88547e2b-ba43-4204-8ca2-ecf1d8f89f25"), "132", "5780760148943336", null, null, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75"), "02/19" },
                    { new Guid("88c9dbf4-583a-4421-9660-1c0f08dd11c3"), "454", "4613433776658330", null, null, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9"), "01/05" },
                    { new Guid("88e2df3e-0bb2-4bbb-a265-227072e391f8"), "961", "6516596553982953", null, null, new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da"), "07/11" },
                    { new Guid("89522a8f-2e41-499f-b744-bbd6eda1921d"), "163", "6621671406200413", null, null, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc"), "06/03" },
                    { new Guid("89c798c6-f066-419f-99f5-a364c20fd5ad"), "066", "9033688156926393", null, null, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7"), "01/23" },
                    { new Guid("89e2bb4f-fca3-4d27-a04e-912fc15a60e4"), "107", "7739289000200539", null, null, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c"), "04/21" },
                    { new Guid("8a2cbb4a-778a-4355-9c8a-10b1e28b880a"), "255", "1105491165716770", null, null, new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592"), "06/15" },
                    { new Guid("8a4f315b-f28e-4119-a080-be143e39a660"), "640", "4769703972021870", null, null, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28"), "01/08" },
                    { new Guid("8a729d0e-3d75-4c3f-8421-eef55b6f0bd1"), "753", "5102381128853833", null, null, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a"), "04/24" },
                    { new Guid("8a8bd713-d418-45bc-9c1c-c0c0651a3e7f"), "681", "9960884343525241", null, null, new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee"), "03/22" },
                    { new Guid("8aa89d94-93ac-4ca5-a549-d2e200240a89"), "573", "2597878530794987", null, null, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e"), "04/14" },
                    { new Guid("8ae03b3e-3e43-4107-9c6a-3e854c9d78f0"), "655", "2257350907185888", null, null, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729"), "09/09" },
                    { new Guid("8aed77f3-e4e7-4e0b-9bcd-d3f2f14609fa"), "074", "9707264713098808", null, null, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b"), "03/16" },
                    { new Guid("8b775e58-a449-4ac8-8902-f875f1059c5b"), "200", "5550547215275559", null, null, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09"), "09/14" },
                    { new Guid("8b8da539-4a32-40a3-b2ef-de8e56c8caad"), "886", "7925058081410470", null, null, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3"), "06/08" },
                    { new Guid("8b945238-6437-4f7e-b25b-fa3047242af4"), "208", "1761117856436773", null, null, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc"), "08/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8c113ca1-9593-481d-8233-90ce91e74d56"), "065", "4330812007625346", null, null, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), "10/22" },
                    { new Guid("8c174b5e-90df-4d05-bb45-15b00727905d"), "105", "9378110322495007", null, null, new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178"), "09/10" },
                    { new Guid("8c310962-143a-43fb-90f2-988afc1f1e20"), "931", "5436049196003119", null, null, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a"), "08/09" },
                    { new Guid("8c7e617c-2c6b-42a3-ad42-c45a829813f8"), "139", "6375135561599325", null, null, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d"), "01/11" },
                    { new Guid("8c7fc1a8-9715-4839-aabe-e1bf9989ea5b"), "216", "6405228931493564", null, null, new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7"), "07/01" },
                    { new Guid("8ca30900-2350-4c55-97d0-bd5fb2e80cc1"), "187", "4227144566299992", null, null, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9"), "10/12" },
                    { new Guid("8caa5894-8e8d-457b-98d6-3b71f5203ca1"), "638", "2794510803356291", null, null, new Guid("99484890-5bb7-47f9-b211-218700e48dad"), "02/18" },
                    { new Guid("8ce2836e-4439-46bf-acd1-ce11ea5bbe39"), "583", "5130712622716423", null, null, new Guid("de956589-c440-4477-908f-fd0e51a90148"), "07/25" },
                    { new Guid("8d6161ad-8b6d-4496-ad3c-18478799bbf3"), "941", "1527153678511141", null, null, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63"), "03/26" },
                    { new Guid("8dcaccb4-5e14-455d-b0a0-288cc13656ae"), "117", "8273125850197924", null, null, new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f"), "10/25" },
                    { new Guid("8ddf82eb-6526-401c-9bb8-8d72b85f576f"), "639", "3346662388602424", null, null, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59"), "02/08" },
                    { new Guid("8e38e5e2-776c-47e3-842d-eaa6bbd06142"), "105", "4779019084232189", null, null, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1"), "05/20" },
                    { new Guid("8eaeeffe-58e0-46f4-934a-4b9596af6b84"), "388", "8266393750998593", null, null, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477"), "10/23" },
                    { new Guid("8ed43261-e724-42f0-8b40-197bfd49966b"), "374", "3911815956697150", null, null, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f"), "06/03" },
                    { new Guid("8eef2bed-8052-4d48-b274-7df6b8c2c37a"), "476", "7185566524592313", null, null, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8"), "04/23" },
                    { new Guid("8f121d61-1fac-41f5-991e-ddb220f74f90"), "513", "1122896733970814", null, null, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9"), "10/20" },
                    { new Guid("8ffa07ed-dea6-480a-907d-4c0a6b14f84f"), "173", "1094421404693258", null, null, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845"), "08/19" },
                    { new Guid("9044967e-bd39-47d0-a274-24333e1f8695"), "430", "2576960257861173", null, null, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75"), "06/28" },
                    { new Guid("9087d9a0-020f-4684-8d8e-ebb31907e842"), "121", "4723238936939290", null, null, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4"), "10/02" },
                    { new Guid("91040a6a-efb4-4574-b512-e70a2224c9c9"), "171", "2866307714433103", null, null, new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e"), "06/18" },
                    { new Guid("915fc037-607b-473c-80dc-285b9c9122da"), "770", "2473856970820952", null, null, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138"), "09/17" },
                    { new Guid("91925710-3b52-4a6a-8888-4bff08e15eb8"), "394", "9534354812962320", null, null, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89"), "11/04" },
                    { new Guid("91d4f4fe-3fb1-4ff7-b78b-debb4bd73348"), "907", "8769045874545508", null, null, new Guid("4fde002a-ab64-405c-bb95-313bef89420b"), "07/10" },
                    { new Guid("923eb193-6f4b-4c8e-a60e-e5159e1edd22"), "741", "2065886405474524", null, null, new Guid("19341891-e9b6-407e-aea5-b35513589e26"), "03/10" },
                    { new Guid("92748d30-b88a-4c8e-88bb-8de2666a1220"), "489", "9946880794084876", null, null, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9"), "12/03" },
                    { new Guid("92879ac7-010c-462a-aaba-cdfddc28f7ea"), "813", "3711731487877436", null, null, new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c"), "01/14" },
                    { new Guid("92ade254-6b6f-4c52-9241-1bf6ccb7f790"), "911", "7709894701717849", null, null, new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6"), "04/21" },
                    { new Guid("92b6dbf0-8e1d-4dfb-b7e5-46386793d0fa"), "552", "7843381103762358", null, null, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498"), "01/24" },
                    { new Guid("93942e48-39e0-45a8-a662-c9d525f48792"), "468", "7233659994359463", null, null, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1"), "06/13" },
                    { new Guid("93bfbd21-b772-492a-bdc9-d436b2736819"), "129", "9627138905296651", null, null, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8"), "01/16" },
                    { new Guid("93f10260-1040-4eb6-921e-0820d1096f86"), "394", "7598561925260348", null, null, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1"), "12/15" },
                    { new Guid("9415270e-4063-433c-9083-26d0c329b064"), "289", "1125532560033378", null, null, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63"), "07/07" },
                    { new Guid("94c89048-8370-4dbd-82b5-524196453621"), "782", "9033523318420204", null, null, new Guid("8461c967-9f1c-48cc-85ae-66b9741be768"), "12/09" },
                    { new Guid("94ff5f8c-c374-46a0-a918-a879f8c724b7"), "167", "9398863782892395", null, null, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18"), "06/14" },
                    { new Guid("9569a75b-3cd8-4827-aece-b70748dc242e"), "001", "7769048572753574", null, null, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010"), "10/21" },
                    { new Guid("95999ffd-2789-4c74-9ded-aea5a262670f"), "429", "7960471611031375", null, null, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1"), "10/15" },
                    { new Guid("960d1b2d-1629-45c4-a580-8397d379659e"), "148", "5712252089734852", null, null, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b"), "02/27" },
                    { new Guid("967d413f-b51f-401a-8b49-db75d670bdbc"), "014", "8487135553731987", null, null, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b"), "08/06" },
                    { new Guid("967dc73e-5f37-4213-a2a6-e7bb280c297b"), "703", "5520895257174530", null, null, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811"), "04/28" },
                    { new Guid("9700276c-63f0-4997-8ad9-80c56ab86044"), "323", "3410054205217377", null, null, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc"), "02/17" },
                    { new Guid("97066449-c474-49cd-909a-0ee647e725b7"), "576", "5237601824146092", null, null, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca"), "07/04" },
                    { new Guid("97a4163f-33fc-4a5c-b030-9e015de7d3d1"), "545", "5434506995908723", null, null, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18"), "10/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("984ebb9e-6c89-49b2-95d3-c26f220c756b"), "382", "7680711253715279", null, null, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece"), "07/18" },
                    { new Guid("98730558-800c-4782-a596-2d051ec86f67"), "184", "7637505494396900", null, null, new Guid("ce1f07b6-54d9-4379-9845-3751b9499199"), "11/28" },
                    { new Guid("98e003e9-78d1-4f95-ae97-2338ef74e620"), "125", "2446075831058763", null, null, new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154"), "12/08" },
                    { new Guid("993ad06f-c90b-4d0d-b24f-98d96699883e"), "933", "3028551904617258", null, null, new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b"), "12/09" },
                    { new Guid("99567b22-be20-4118-99ca-ae13d6f7db85"), "927", "5443869276839414", null, null, new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372"), "11/21" },
                    { new Guid("995fe37e-21e6-4544-9c96-c12a3f3bf867"), "932", "8537107554781076", null, null, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d"), "05/25" },
                    { new Guid("99ae3a48-15da-4497-af2d-2668c3da6ed9"), "979", "4827398467711775", null, null, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a"), "07/26" },
                    { new Guid("99eddd80-6e33-427e-8eb6-e4a23d45a7f0"), "261", "9047903369237172", null, null, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4"), "05/05" },
                    { new Guid("9a13581e-2725-4c6e-bd26-e419990dc0ce"), "707", "9122732705082360", null, null, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f"), "11/24" },
                    { new Guid("9a511703-5247-44aa-b05f-7be83bf62bd3"), "182", "8719099817948770", null, null, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334"), "03/16" },
                    { new Guid("9a85c9e6-4104-4ba7-9025-4d925cde93db"), "894", "9198463677143282", null, null, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8"), "06/17" },
                    { new Guid("9ad5046b-b51d-43a8-a171-1ae7a02c29e8"), "829", "4216373792369600", null, null, new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942"), "10/27" },
                    { new Guid("9ad6193d-1097-40aa-84c4-66d36741824c"), "779", "5255244305542650", null, null, new Guid("94aaefbb-3b69-4a12-8609-44039863dc44"), "04/27" },
                    { new Guid("9b4286d8-00f5-4fe3-a0e6-c8ccc7d37ac8"), "108", "2680898244390557", null, null, new Guid("f027517a-8745-4767-8a34-aaadc0a70189"), "11/13" },
                    { new Guid("9c1284d1-9129-4d0f-a439-1cde7ed038d2"), "958", "8430573615523532", null, null, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c"), "06/22" },
                    { new Guid("9d07f1c1-7dc8-4865-8a96-238a8e9389a2"), "304", "5655599704343806", null, null, new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba"), "12/20" },
                    { new Guid("9d17dcd7-c2cc-4efc-90b2-0adfcdeeef68"), "537", "3152619072216322", null, null, new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef"), "05/08" },
                    { new Guid("9d19e0bf-99ad-4995-a776-41fd67ef7856"), "257", "7688990644599628", null, null, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811"), "12/25" },
                    { new Guid("9d1dd87f-b564-4d08-be17-7bab74fc5d36"), "084", "2826468257684026", null, null, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f"), "07/26" },
                    { new Guid("9d2b2afe-7063-4370-8079-1c1aa1c7f66b"), "897", "1954581784600083", null, null, new Guid("6bf86772-9995-44ea-a063-ccc583990881"), "09/05" },
                    { new Guid("9d3f520a-dc4b-4745-8f97-2d62690548e1"), "980", "4724633417251878", null, null, new Guid("5ffc49e2-50fb-41f2-8784-192077f86010"), "02/01" },
                    { new Guid("9dce75b8-1e1c-42d7-92bc-56d0c98b6387"), "953", "1087329829097375", null, null, new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2"), "08/06" },
                    { new Guid("9e4eb594-9724-459e-8825-5c157fd02305"), "576", "3557105812395042", null, null, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8"), "02/03" },
                    { new Guid("9e71bf52-3d13-4969-ad4b-1557889be005"), "837", "8524492306910560", null, null, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6"), "08/06" },
                    { new Guid("9e7611e9-d29a-48b4-8211-4bd7e7ac1f72"), "563", "2396847056261260", null, null, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc"), "12/07" },
                    { new Guid("9e8551b7-c87c-4989-8238-c9ca0ed39a87"), "292", "2980020141926188", null, null, new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb"), "08/14" },
                    { new Guid("9ebf1f43-b2aa-4f96-a149-7f7057bff0d0"), "089", "7370095042041446", null, null, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d"), "03/28" },
                    { new Guid("9ebf65b2-8a78-44fd-bc03-d42e50757a93"), "096", "1808683987648538", null, null, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217"), "10/17" },
                    { new Guid("9f00bf7d-4ca6-4a3b-8001-36f3c93c95a0"), "308", "4527627940891521", null, null, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d"), "11/24" },
                    { new Guid("9f156570-c5b7-424a-b072-686fa02d201d"), "099", "1498120650800687", null, null, new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c"), "10/21" },
                    { new Guid("9f9986d3-87c0-4b1c-a2c3-503f6bb79c7d"), "067", "5972180843804067", null, null, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325"), "11/20" },
                    { new Guid("a017c806-4109-44f8-b0e3-48716c919de5"), "517", "7343243848222372", null, null, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923"), "01/10" },
                    { new Guid("a031723a-0a52-4ad6-af0b-1724da638e9c"), "895", "1392653180121401", null, null, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd"), "01/27" },
                    { new Guid("a072c80b-aaf3-4b5b-bb5b-d67c73937531"), "928", "5703296467542701", null, null, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b"), "08/26" },
                    { new Guid("a09b9878-c2e1-4c24-b2dd-7c4e34d634fb"), "865", "4181908381476505", null, null, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321"), "06/09" },
                    { new Guid("a0b6727e-041d-4a2c-9629-153ca27e452e"), "247", "4570462421458639", null, null, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770"), "11/08" },
                    { new Guid("a15487d7-22cf-45a5-80ed-de1ea8d834dd"), "920", "6490408046982493", null, null, new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1"), "12/07" },
                    { new Guid("a1e68bf2-7f5a-4738-a279-017dde118e68"), "936", "4697890349555531", null, null, new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2"), "02/09" },
                    { new Guid("a28e9650-6c2a-44b9-87a2-6a3277079acd"), "610", "5443630049642612", null, null, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8"), "06/19" },
                    { new Guid("a3e04aee-d7e1-45a4-9bbf-642af986dc8b"), "251", "7643451727479762", null, null, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770"), "10/12" },
                    { new Guid("a4576c84-bde4-4963-8875-19d6b28b02aa"), "052", "1542303674431836", null, null, new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a"), "01/07" },
                    { new Guid("a46192e0-50a7-4979-a4df-b8b4c9c48684"), "722", "2103180261705628", null, null, new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a"), "02/06" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a46efd69-a22d-487f-99cc-d3f2ab851a00"), "657", "6441970265566493", null, null, new Guid("1154048c-cc8b-409f-a802-5dbe51d20548"), "03/23" },
                    { new Guid("a486dd50-ddaf-4010-9fe6-d95868ac5a10"), "134", "9653892405153645", null, null, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321"), "05/12" },
                    { new Guid("a49331cb-d67e-4e2d-bfe5-55e298d8d853"), "816", "5057377145492123", null, null, new Guid("4e0204f0-eb29-4713-873b-136318951b1d"), "02/02" },
                    { new Guid("a494698e-e88c-4570-8beb-e85c5feaa020"), "863", "9869075763915538", null, null, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a"), "08/14" },
                    { new Guid("a4c8868a-d702-4444-a090-fe52573004d6"), "654", "1387130270922168", null, null, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61"), "05/25" },
                    { new Guid("a514cd0c-a22b-4907-a061-aa243a5e9677"), "517", "3601419240597756", null, null, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5"), "09/10" },
                    { new Guid("a5fd43ec-9e8f-4b0d-9ff7-00c7e62e741f"), "008", "2302907805663656", null, null, new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592"), "01/09" },
                    { new Guid("a639bec5-18e9-4817-bb75-2068728cc70d"), "919", "1650673371756058", null, null, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b"), "11/21" },
                    { new Guid("a6dd7cee-bdee-43d1-b304-51734da96631"), "757", "8891038584362511", null, null, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75"), "06/27" },
                    { new Guid("a71c9a76-1fe1-4865-905c-e75581c3b824"), "599", "9001692980919016", null, null, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b"), "08/26" },
                    { new Guid("a757b51d-36a4-404c-81cc-4f25e7080519"), "995", "5313055374224945", null, null, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b"), "01/11" },
                    { new Guid("a7eaf067-d072-41df-9ff1-ebef046edfa5"), "689", "1038566155846250", null, null, new Guid("35187412-3a05-415f-8523-ec24e84b1221"), "06/24" },
                    { new Guid("a84c7e75-ef9d-4cce-9ed7-42c553165f8f"), "709", "6174472958741071", null, null, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783"), "02/26" },
                    { new Guid("a8547cac-1d95-4e44-b0f3-a410e52a3e78"), "838", "2681326196892840", null, null, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334"), "09/06" },
                    { new Guid("a870cbc3-8c1a-4049-9f6e-6fa83d58f833"), "162", "4183589092639764", null, null, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87"), "05/18" },
                    { new Guid("a95279d4-aa2c-4465-9409-5f43738ada98"), "862", "3784466322324375", null, null, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b"), "12/02" },
                    { new Guid("aa0a0b23-eb98-4c40-9884-89b8adf4865d"), "768", "7550340056097959", null, null, new Guid("98ec5653-7775-432e-9be5-3149a15fca62"), "02/28" },
                    { new Guid("aa4c5c73-3cdb-4116-8fbd-6feec000acf6"), "227", "8419037637703245", null, null, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce"), "03/26" },
                    { new Guid("aa612251-0362-4cbf-9214-ca9aa4004ce6"), "407", "6737756848111475", null, null, new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56"), "02/28" },
                    { new Guid("aa7b6627-5c6a-4ecb-932f-f60ed8e9bc24"), "013", "1032072790172987", null, null, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a"), "06/10" },
                    { new Guid("aae10b5f-8378-439e-b100-7d78e4109499"), "804", "6362934843195365", null, null, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845"), "07/01" },
                    { new Guid("ab9a83a3-44d9-4c35-9cca-290669a6df8f"), "803", "4588052220872664", null, null, new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6"), "02/06" },
                    { new Guid("abea5201-71f4-4122-8f7b-593fb9b2433b"), "882", "4489967922314166", null, null, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c"), "03/21" },
                    { new Guid("ac42fadb-bf20-4161-83af-3ebd07ba587a"), "494", "8093776047994146", null, null, new Guid("de956589-c440-4477-908f-fd0e51a90148"), "01/16" },
                    { new Guid("ac95a85a-2a92-4a92-becb-efbe14dc2524"), "264", "9082573093971099", null, null, new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2"), "08/17" },
                    { new Guid("ac98c63c-5795-4b60-99a7-f10cc6c08eac"), "662", "8525862462562015", null, null, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689"), "07/16" },
                    { new Guid("ad587570-9445-4232-85fa-2d9f10cdb444"), "594", "3404537044609237", null, null, new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32"), "07/27" },
                    { new Guid("ad60519e-3cbc-43f5-aa6e-f2b8fa34e7e5"), "365", "7449000832346328", null, null, new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f"), "08/01" },
                    { new Guid("adbaff3b-b126-4887-94b5-cbd6e3fde00e"), "068", "6765573173240939", null, null, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e"), "03/01" },
                    { new Guid("adca4bf2-6872-4320-9120-5f2a9f3612b9"), "353", "9904465980063396", null, null, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058"), "10/07" },
                    { new Guid("addd02ac-0d2c-4b8c-955e-424aae4bec6c"), "642", "6821289387890925", null, null, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2"), "09/14" },
                    { new Guid("ae013be1-c4dc-4184-a9f6-891874671af0"), "841", "9821302425251090", null, null, new Guid("30e31307-3bbc-4483-bf55-601427ba031c"), "07/24" },
                    { new Guid("ae0f3f98-8a88-4bb7-8bd7-586ae447bd43"), "404", "1578525171115055", null, null, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae"), "04/19" },
                    { new Guid("ae17b14f-0dbf-4d99-a42f-9ca26e9de6f8"), "288", "5469798541431822", null, null, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12"), "09/22" },
                    { new Guid("ae3b9782-9939-4262-915f-569b9c8948df"), "441", "6027171111038610", null, null, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024"), "12/14" },
                    { new Guid("ae92a219-2b3e-45d5-baea-2492a74129c4"), "461", "7793532883982252", null, null, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2"), "03/22" },
                    { new Guid("af52b6ea-d8ba-41a3-a513-85ca83155410"), "582", "3270444704040575", null, null, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689"), "08/07" },
                    { new Guid("af609cb7-b952-4545-b69b-35e41ceee8fc"), "416", "3256277451502910", null, null, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9"), "06/08" },
                    { new Guid("af7dba14-4142-42bb-beed-ca6b52be1b56"), "999", "2193255754157452", null, null, new Guid("563f53c7-7654-4215-88fc-eff6cf413754"), "11/04" },
                    { new Guid("af95d924-5a1f-4320-974c-d83d3cf1ca15"), "639", "8429466864762124", null, null, new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9"), "10/24" },
                    { new Guid("b03b657b-bf71-484b-9884-e183fa7468a1"), "428", "3769766096853034", null, null, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e"), "10/03" },
                    { new Guid("b0ef0091-6579-4311-a791-873ed121b3e8"), "262", "8059895852072244", null, null, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3"), "06/09" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("b1a9cd37-0af8-4037-a63c-7520a1b22e81"), "570", "3674207695331672", null, null, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc"), "12/07" },
                    { new Guid("b20aa1f1-130b-4a05-b305-d7ef9b02f2bc"), "386", "9633245050760608", null, null, new Guid("4ea29651-f292-4cbf-8413-d8821c394155"), "09/28" },
                    { new Guid("b21df12f-68d7-4e30-a7f2-93ee63e2e396"), "916", "5191999261757129", null, null, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98"), "06/03" },
                    { new Guid("b2228fc3-d478-4eac-9acb-f17bd57371b9"), "933", "5713434640332978", null, null, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f"), "09/25" },
                    { new Guid("b23f7e6a-4689-4b07-8fc8-91428f1f9327"), "569", "1987404120988260", null, null, new Guid("3e1827bb-2cfc-4263-be79-7b663816638e"), "12/26" },
                    { new Guid("b28fc6a5-0ad2-4a29-ae0d-b903ceb94eb4"), "520", "5461222870843023", null, null, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7"), "10/18" },
                    { new Guid("b3b4a691-7a4f-4e17-b9b7-fe7d3342ed73"), "556", "6091922805032005", null, null, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e"), "07/19" },
                    { new Guid("b3f1ae97-cca4-4e4e-8463-386992981248"), "749", "4565239846851969", null, null, new Guid("8905b747-db92-42c9-8385-1d49f6b8e578"), "11/06" },
                    { new Guid("b41f0835-75dd-411b-8f01-50fad3a3f4f3"), "530", "4653995614061485", null, null, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065"), "02/20" },
                    { new Guid("b5e8682a-3354-4a8b-93e9-a8e3c0c140c7"), "894", "4335561348562873", null, null, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785"), "10/24" },
                    { new Guid("b6050493-bd0c-419b-a898-24aeb1ab43ee"), "197", "4304604447152995", null, null, new Guid("4fde002a-ab64-405c-bb95-313bef89420b"), "03/15" },
                    { new Guid("b6204d34-0fbc-4a78-8bc6-c4c817ae71ec"), "904", "5384511716695797", null, null, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc"), "01/24" },
                    { new Guid("b651afe4-0c9b-4b60-80d7-89c80a1db20b"), "864", "4927492967032029", null, null, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1"), "12/27" },
                    { new Guid("b668d129-8b12-49f7-8273-d3053bb89125"), "373", "9483403442961249", null, null, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729"), "03/21" },
                    { new Guid("b692651b-1f13-4796-abb8-25a0240c7ddc"), "224", "4300632354826916", null, null, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59"), "12/02" },
                    { new Guid("b6df07b7-f69d-4c1e-8407-25a5c4847387"), "208", "6939776095786173", null, null, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae"), "08/13" },
                    { new Guid("b711cb00-b3e7-4e3c-b26d-6c6f520d8822"), "816", "4715011877618740", null, null, new Guid("0b98923c-0481-432f-9b60-33427e4d8223"), "08/26" },
                    { new Guid("b7515322-7168-42b8-979a-bbb26c094d0f"), "705", "4605377502340008", null, null, new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64"), "08/05" },
                    { new Guid("b802108a-c64a-4d13-81e4-21febcd9ec04"), "253", "5220616967783465", null, null, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b"), "07/03" },
                    { new Guid("b856db57-dab9-4495-8929-06d0fbf9a54f"), "009", "9058966689682648", null, null, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3"), "05/18" },
                    { new Guid("b85abf55-28c9-4ebf-8d29-394d7297da44"), "120", "8490967369420213", null, null, new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca"), "05/28" },
                    { new Guid("b98f5792-91e4-41e8-b45a-b6e797958fb4"), "914", "4661837188829345", null, null, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024"), "07/06" },
                    { new Guid("b9d0ff69-8d3b-496e-bb23-43183dbd7e8d"), "629", "8516477296531984", null, null, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca"), "07/24" },
                    { new Guid("b9ed4656-587f-4ce3-8be5-d555fe9952ef"), "744", "1098503443583234", null, null, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783"), "06/16" },
                    { new Guid("b9f14b1d-171a-473d-a22c-ec7aad431334"), "717", "9740278463547093", null, null, new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614"), "09/06" },
                    { new Guid("ba12890d-b351-4fbf-b5ec-bf659c5bbd2f"), "471", "7233804907043531", null, null, new Guid("816326af-094b-4b97-b10b-548a2296766b"), "10/01" },
                    { new Guid("ba23453a-6fd3-447d-9f27-565aec38254a"), "850", "1953187994723242", null, null, new Guid("52698753-1196-4fd7-83fd-4670d8d55456"), "02/23" },
                    { new Guid("bb464923-9e8e-4571-81a4-65679ed6c644"), "776", "6383820739644573", null, null, new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd"), "09/20" },
                    { new Guid("bb996a05-a64b-4c15-a952-a0a66e5a8b25"), "211", "1537674243096244", null, null, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4"), "08/06" },
                    { new Guid("bb9f6515-b9f4-4d43-a5fc-519be7879c58"), "124", "8448338869616442", null, null, new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098"), "07/21" },
                    { new Guid("bbb5ea32-35a5-4621-b048-1b4c3bc006ee"), "666", "3921498523688514", null, null, new Guid("43a79d17-6c7f-4919-8fc7-806f34234239"), "04/03" },
                    { new Guid("bbff2a8d-b7e7-4aec-85a8-da893fc514c2"), "168", "5838640116065376", null, null, new Guid("52698753-1196-4fd7-83fd-4670d8d55456"), "12/22" },
                    { new Guid("bc137203-3498-4be2-b5f8-79fe61437afe"), "730", "7703160177224909", null, null, new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748"), "11/08" },
                    { new Guid("bc161cd8-76c6-4509-9a20-d6332d86c880"), "814", "5701864366302676", null, null, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8"), "04/28" },
                    { new Guid("bc4eb6ad-9793-43d3-9485-4b477c9ccede"), "297", "8907741673893968", null, null, new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38"), "11/28" },
                    { new Guid("bc5d8aea-0c08-4ffa-bd52-d98f620f539d"), "890", "3035293436357106", null, null, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5"), "07/27" },
                    { new Guid("bcdc8168-2a6b-4baf-8469-7d3f8631cac9"), "878", "8504873932286710", null, null, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729"), "05/15" },
                    { new Guid("bcfb3c8d-22e1-41d1-82a0-499f88259eb2"), "773", "2557727136816571", null, null, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a"), "07/18" },
                    { new Guid("bd2096c6-5251-4bb6-a673-cd9a93de07e9"), "621", "3907650769399701", null, null, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b"), "12/17" },
                    { new Guid("bd4a1011-ca9c-48ca-8ca8-fad919326ec1"), "517", "1310292829641418", null, null, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a"), "05/10" },
                    { new Guid("bd5d83af-c367-4d2f-8de4-8c05e497437a"), "523", "5140129161190485", null, null, new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec"), "11/11" },
                    { new Guid("bd89b70b-ec6d-4bd3-b514-fc577ebac468"), "123", "8534517821383048", null, null, new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca"), "08/18" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("bdeb4cfb-fc16-4a9f-89da-2d93d1140798"), "650", "9484847815494669", null, null, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8"), "01/05" },
                    { new Guid("be0132b8-fbd3-4796-a6ac-738d60b39ba3"), "165", "3212229395914995", null, null, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae"), "11/01" },
                    { new Guid("be39634f-c571-4dec-88ad-cd947aa671ff"), "862", "4056111479914884", null, null, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09"), "07/27" },
                    { new Guid("be3aa1ac-357f-43a4-bc35-5cedcbcebeed"), "063", "1966482102463927", null, null, new Guid("52698753-1196-4fd7-83fd-4670d8d55456"), "01/15" },
                    { new Guid("becba052-88cf-4ca8-9e9e-c80c33a1b760"), "509", "5973347661417288", null, null, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30"), "01/07" },
                    { new Guid("bf1c3e51-fecb-483f-a086-ed49c4309dab"), "883", "5628922750154688", null, null, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811"), "11/08" },
                    { new Guid("bf2074d1-c518-45d0-a502-2cab6a3ac92e"), "288", "2088325898066898", null, null, new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1"), "12/07" },
                    { new Guid("bf840372-b052-4501-9885-40b4a6dded28"), "781", "1803077969447746", null, null, new Guid("730094f2-c549-4e04-b5a9-761af8d5725f"), "10/16" },
                    { new Guid("bf8a01a7-2b43-48ba-9bcb-4a49467691d4"), "301", "7445938068167820", null, null, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5"), "02/21" },
                    { new Guid("bfb9c097-8b86-4c51-9f6c-25b34fde2f2d"), "456", "1940114649995681", null, null, new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303"), "11/22" },
                    { new Guid("bfd6ccd4-0986-459d-adfe-a9aa2bd5636d"), "117", "4426822393769659", null, null, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4"), "07/09" },
                    { new Guid("c06c4dfc-11a9-4070-bd2b-6e0ad09372d1"), "813", "7665974086060848", null, null, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e"), "04/03" },
                    { new Guid("c0a39c42-6756-41aa-a01f-7b69c02305f3"), "707", "7806221688285608", null, null, new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9"), "09/03" },
                    { new Guid("c1182d7d-e422-4493-a66d-80c410b104b9"), "795", "4967026784911186", null, null, new Guid("4f03daca-02fb-425a-a575-bef52173e4d3"), "02/03" },
                    { new Guid("c1434171-6609-423f-aa60-5acc1389e1da"), "249", "6093491668561146", null, null, new Guid("53a7a51e-d382-4050-82a5-f33ab7641603"), "06/08" },
                    { new Guid("c17f9944-b9fd-446f-bd59-4ddf8c063c86"), "258", "5612526611693397", null, null, new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a"), "07/07" },
                    { new Guid("c29c9518-3720-4142-a61e-b62809dc0efc"), "890", "4710528665222426", null, null, new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063"), "10/19" },
                    { new Guid("c2c5403a-0747-4236-ab36-e3184328784f"), "556", "3150856114104928", null, null, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8"), "10/05" },
                    { new Guid("c2e7d40e-1ebe-44b6-9fec-18e1b2de0284"), "137", "4801301740527730", null, null, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18"), "01/19" },
                    { new Guid("c3d4f3ac-f2ec-450e-8436-d2d73de2062c"), "231", "1494376584134157", null, null, new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942"), "02/02" },
                    { new Guid("c3db9312-6597-47f3-92c2-972e4b355b24"), "996", "6538062659281150", null, null, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8"), "02/10" },
                    { new Guid("c402fc95-682d-42a6-a8d7-05e3b38efe39"), "487", "4044075219769854", null, null, new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4"), "06/02" },
                    { new Guid("c41adfb5-a942-4e66-bd36-f2820eaad06f"), "613", "8308299944044493", null, null, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9"), "11/03" },
                    { new Guid("c4576ed2-9486-4e7f-b849-5c7ca8bb9fd3"), "747", "2144366222733572", null, null, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7"), "10/19" },
                    { new Guid("c4aa60b9-65c6-4241-ad07-c94bf7ff9a97"), "722", "1139373161548674", null, null, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785"), "04/09" },
                    { new Guid("c500e20e-dee5-4eed-82ed-7250042805aa"), "822", "2345044747771921", null, null, new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67"), "06/12" },
                    { new Guid("c51b9858-3df6-4ab1-924d-53c0b66fba2b"), "182", "1083070874078081", null, null, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37"), "04/02" },
                    { new Guid("c550dee9-312e-458e-a767-8a57f298a543"), "238", "5448385139997637", null, null, new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af"), "09/19" },
                    { new Guid("c56dc533-75bb-4de0-b0ec-2f994164c05f"), "397", "4439381963484504", null, null, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4"), "11/04" },
                    { new Guid("c5c07d99-defa-41d2-bab0-98eb2cfdfc0b"), "776", "1157954764066190", null, null, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70"), "05/13" },
                    { new Guid("c6179a80-c79f-4598-88ad-49a48c8e0be0"), "152", "8310622478092351", null, null, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754"), "02/08" },
                    { new Guid("c6988a57-2a16-4512-8115-cf2d37430264"), "154", "8677416337974098", null, null, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e"), "01/01" },
                    { new Guid("c6b56d6b-d7ca-49da-ba88-acf5dca16167"), "239", "4015468802195523", null, null, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98"), "05/07" },
                    { new Guid("c6ccbbee-49d9-4aa6-9036-6caaa5abec3f"), "191", "8576889707766123", null, null, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f"), "04/18" },
                    { new Guid("c7004ff9-8475-4001-a645-929f2d63293e"), "844", "8797779739292147", null, null, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9"), "03/23" },
                    { new Guid("c70c70e9-5fb3-4bf5-b03f-e5c93bc596b0"), "079", "7626688597284773", null, null, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63"), "01/28" },
                    { new Guid("c72044b1-ebd2-49ab-a2b6-b660889715c2"), "115", "6972489998141472", null, null, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5"), "04/21" },
                    { new Guid("c7691df7-be43-40b1-b0f7-5e3cbab8cd39"), "440", "6757469583850836", null, null, new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6"), "01/01" },
                    { new Guid("c7862c5e-7917-4cde-b10c-fe795eb15768"), "042", "9358245325554569", null, null, new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa"), "11/13" },
                    { new Guid("c7876897-2126-47dc-bbdb-1c43aac2872e"), "194", "2889932752637710", null, null, new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af"), "12/22" },
                    { new Guid("c7e36558-4839-4914-96d2-b96984c0d907"), "466", "3060840679499478", null, null, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), "12/10" },
                    { new Guid("c8280c5b-cf44-4e2f-887f-e10fec8acdf2"), "751", "7898935768427320", null, null, new Guid("4e0204f0-eb29-4713-873b-136318951b1d"), "03/09" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c8a1c463-664e-4bd5-96a8-61bf51d6cd04"), "894", "6845309721352018", null, null, new Guid("46568224-f301-4805-9ce4-f87ec0533c46"), "06/05" },
                    { new Guid("c8ba88f0-09f8-41e3-ad31-a28b4ffbd7d8"), "336", "9128497502139872", null, null, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9"), "09/11" },
                    { new Guid("c8f8a1fa-95da-4e29-93ac-cda80d0a411b"), "843", "4656815841110935", null, null, new Guid("30b2066d-f465-42ae-93e3-4a38936052b2"), "04/11" },
                    { new Guid("c90e328a-d60c-4889-8393-066e3654fb15"), "292", "3155346547070837", null, null, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767"), "09/13" },
                    { new Guid("c92c485c-1900-43c1-b8e8-a3cb64391958"), "272", "4889471617966535", null, null, new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae"), "06/01" },
                    { new Guid("ca100f27-d73f-4c08-a599-ad9347f039d8"), "273", "9078422916636363", null, null, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d"), "08/02" },
                    { new Guid("ca4cc272-3637-491c-9f89-a6ede2644702"), "892", "3295057608961977", null, null, new Guid("862a826f-0eba-4891-9241-dff3a8896969"), "06/28" },
                    { new Guid("ca87db26-2d71-490b-a7cd-29c8b08ee958"), "082", "2390309373811750", null, null, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689"), "01/14" },
                    { new Guid("cad5ecf7-acd2-4af1-b496-1e72ae05e1cc"), "538", "9493465326276679", null, null, new Guid("9d7effeb-d071-4689-a103-74400c1c3344"), "08/22" },
                    { new Guid("cbc50c62-04b8-4811-9694-0e2d9602388d"), "151", "7044148646763083", null, null, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc"), "08/18" },
                    { new Guid("cbc8e907-95a5-445d-a62e-4f3945c6d8d9"), "351", "5604374807099707", null, null, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498"), "10/27" },
                    { new Guid("cc5f4198-6f5e-47ab-a7ef-9202254aca2f"), "076", "6599848438539565", null, null, new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9"), "05/25" },
                    { new Guid("cc739997-2d2a-4cca-9893-96c7ebddeade"), "269", "7469307152151050", null, null, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61"), "12/14" },
                    { new Guid("ccd18fdc-9bd1-42ef-aa90-d71666315467"), "379", "9761996757795869", null, null, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd"), "11/24" },
                    { new Guid("cd2336c0-640c-4b63-b34d-131f95434d6b"), "089", "8235697399471100", null, null, new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291"), "07/02" },
                    { new Guid("cd387af8-cc55-42c3-ae32-9c2b4baa2e28"), "127", "6999687651701346", null, null, new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8"), "05/10" },
                    { new Guid("cd50a47f-bbab-4d40-a6ea-8d3cb753dbaf"), "816", "9017847213106194", null, null, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc"), "07/14" },
                    { new Guid("cd6b4dc4-fe84-4db2-aa05-778577e32239"), "005", "6159375702089550", null, null, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc"), "10/24" },
                    { new Guid("cdb7c8ff-35e6-4938-8475-3bd83091b785"), "236", "6996694707659457", null, null, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a"), "05/03" },
                    { new Guid("cdc30a1a-d46f-4cfb-a8bf-bfe1412899e6"), "155", "7213090050666856", null, null, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75"), "02/15" },
                    { new Guid("ce345ded-adf6-4cda-9578-ed1bcea7f86d"), "872", "3285734856234917", null, null, new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6"), "04/22" },
                    { new Guid("ce439e13-5cf0-4cc8-b557-5117111fa1a8"), "312", "9484181370464784", null, null, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e"), "03/06" },
                    { new Guid("ce529809-617f-4db2-ab9c-8da15bcdd02d"), "047", "9185989596142883", null, null, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923"), "12/15" },
                    { new Guid("ceabdd9e-e62f-449d-bcdc-5a787a24c569"), "742", "8461121694173773", null, null, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b"), "01/03" },
                    { new Guid("cebcb8b8-7846-4c2d-84d7-9c055362c928"), "817", "3499582864054041", null, null, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066"), "01/26" },
                    { new Guid("cec97f19-2840-4935-8509-b89742531b96"), "390", "7549674807491556", null, null, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc"), "01/23" },
                    { new Guid("cf3bfd88-8762-4760-8cf8-0b08e77de0cf"), "178", "9288192974099203", null, null, new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219"), "08/24" },
                    { new Guid("cf77fe56-b656-48b8-8332-0ae2216dda5d"), "918", "1557711278276692", null, null, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd"), "05/22" },
                    { new Guid("cfdca73a-5be4-4b87-b709-ee12da59d716"), "053", "2713770238735755", null, null, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4"), "09/11" },
                    { new Guid("d01aa364-17a0-46cd-bcf3-626ebe29e9f2"), "084", "9984955823797049", null, null, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf"), "11/10" },
                    { new Guid("d059bafa-381c-4fad-a892-7a150d47f4a5"), "759", "3004221499253504", null, null, new Guid("98ec5653-7775-432e-9be5-3149a15fca62"), "09/28" },
                    { new Guid("d09b4d01-046f-4c4e-af79-06b0e991f969"), "540", "4582484795307876", null, null, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066"), "05/04" },
                    { new Guid("d09c20ce-5960-4dcc-82cc-f80f0cabdd11"), "786", "9615201886868483", null, null, new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4"), "09/11" },
                    { new Guid("d0c32f76-d688-4215-b2d2-db1364659121"), "392", "5234946308647041", null, null, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6"), "05/20" },
                    { new Guid("d1002626-0438-48ac-b449-b1aa3d608e50"), "325", "9680882697575033", null, null, new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9"), "07/02" },
                    { new Guid("d1a2b9c9-d620-441a-857b-e2a485713f1b"), "063", "9791804361529702", null, null, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d"), "08/25" },
                    { new Guid("d1b8b802-bc5d-4c9c-90a7-34ee5ac4227b"), "349", "3822840198066746", null, null, new Guid("0f9851be-b682-479e-aec8-51795a73a90e"), "10/27" },
                    { new Guid("d213c4cd-1ed5-4420-9019-b05257516fee"), "492", "9168343336892436", null, null, new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4"), "11/03" },
                    { new Guid("d2f9e75b-1a22-4090-9794-fca5b9e15d43"), "206", "5381665728309257", null, null, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9"), "05/22" },
                    { new Guid("d35b35b1-8f8a-4f52-bbb4-e9535f64dfd4"), "068", "5091398271803372", null, null, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0"), "05/16" },
                    { new Guid("d36a3c20-383b-42c4-92d4-5e8ef067f36e"), "505", "6792371736432154", null, null, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f"), "12/08" },
                    { new Guid("d3a751ed-226f-4833-9477-95876d7651f9"), "887", "1940612515415392", null, null, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9"), "10/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d3e8ae67-9eec-4669-a874-6423519f1cc4"), "844", "4288096102214793", null, null, new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b"), "02/16" },
                    { new Guid("d4e6e06c-acaf-423a-a289-efc6a0a22ba9"), "161", "1700578546139205", null, null, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b"), "11/08" },
                    { new Guid("d4efdf19-ca3c-4eb1-931b-432179bd70ed"), "941", "2930546988125571", null, null, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e"), "12/19" },
                    { new Guid("d513b611-f42b-4ca9-a193-fce43f6876b1"), "108", "8029083990743607", null, null, new Guid("527f7c3d-02b4-465e-8153-3472af913951"), "11/21" },
                    { new Guid("d5bd4b56-59f5-4547-ae29-199f1e570a4b"), "935", "4045669328868975", null, null, new Guid("7573b136-e686-46e6-b0af-1186d8e37af1"), "10/10" },
                    { new Guid("d665604b-39e5-4fdf-b9c2-42afbd4ff818"), "599", "7980399328043199", null, null, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656"), "02/07" },
                    { new Guid("d687446f-a994-459d-8701-21683aeffb52"), "887", "4933765777343968", null, null, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446"), "02/26" },
                    { new Guid("d698397a-a9a3-448e-9fa1-4236743273f6"), "598", "5204057922591725", null, null, new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9"), "04/14" },
                    { new Guid("d6a9dc76-f237-4cf1-8560-d715d32e16b2"), "129", "4222871861513298", null, null, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61"), "04/13" },
                    { new Guid("d70466dc-3c58-4584-952b-6c5a13523719"), "186", "9728160211358109", null, null, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12"), "02/13" },
                    { new Guid("d75eee3c-0d58-4d3a-82c6-9533e13090e0"), "161", "6722508134459885", null, null, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c"), "12/13" },
                    { new Guid("d79349f1-a2f5-41cf-b667-ea097b7ecf3d"), "524", "3998363131955007", null, null, new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a"), "02/21" },
                    { new Guid("d80f5337-4d2c-4a7f-ba36-e3fbbad1b0c2"), "554", "1775282799232817", null, null, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d"), "09/07" },
                    { new Guid("d86f42bd-978a-4e97-accf-29da0fbe5297"), "248", "5450022565137788", null, null, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6"), "11/06" },
                    { new Guid("d8de97dc-d2cf-4489-9c9e-8b24d14552e7"), "656", "5076520933691445", null, null, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d"), "12/26" },
                    { new Guid("d9127131-86bc-4a97-a446-551e83d894b3"), "499", "4956539533600652", null, null, new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303"), "01/01" },
                    { new Guid("d93137e9-d93e-4fb8-98ac-a81016474819"), "392", "3435260337260372", null, null, new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1"), "02/08" },
                    { new Guid("d9771660-22c4-4140-a2b7-cddef0e46bda"), "262", "4146147905447360", null, null, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1"), "10/02" },
                    { new Guid("d97b48ca-651c-4c85-887f-51f7c23b0136"), "102", "6655182305235374", null, null, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b"), "12/02" },
                    { new Guid("da48657e-b940-4ebf-9958-ccad62943430"), "038", "6751466317506484", null, null, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece"), "11/11" },
                    { new Guid("db285156-733e-4be0-8bfa-8f24550ecec9"), "762", "2317796455747175", null, null, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30"), "10/15" },
                    { new Guid("db3b1a71-3f9e-4b0e-a4aa-4fefa4176a76"), "177", "7009565692399543", null, null, new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32"), "11/23" },
                    { new Guid("db89d587-9df8-43c5-93bb-9a706f8767b0"), "670", "4342137485329065", null, null, new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e"), "10/07" },
                    { new Guid("db93d2cc-58ce-4493-acd3-1d2ddad3ce3c"), "479", "5839360850121485", null, null, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8"), "12/15" },
                    { new Guid("dbd5e970-d2d1-4bd9-b8df-796049cb142f"), "965", "2834615102253408", null, null, new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760"), "08/04" },
                    { new Guid("dbff9d34-6cfd-40af-9cdf-59a87e2ba6af"), "037", "6669203625097910", null, null, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e"), "09/18" },
                    { new Guid("dc2de105-1f4d-4961-b8fe-24644f45a5eb"), "944", "1709298040915641", null, null, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1"), "01/06" },
                    { new Guid("dc73495d-0c2b-42be-9770-c151a6af6e72"), "736", "7651180780388106", null, null, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010"), "05/23" },
                    { new Guid("dcf07b9f-6e68-4e49-97c1-3a14930b97f8"), "026", "2958994291530678", null, null, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066"), "07/23" },
                    { new Guid("dd247343-6587-4a2c-9e70-1cda2736b997"), "222", "4265022573070166", null, null, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553"), "07/02" },
                    { new Guid("dd6bb305-a2bf-40e4-906b-96780454d92f"), "330", "5139586939175571", null, null, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446"), "08/17" },
                    { new Guid("dd7e5e2d-392f-4eb8-9b3c-8c77c200998d"), "670", "3125948572336544", null, null, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e"), "07/07" },
                    { new Guid("ddabc467-8dc2-4db2-9069-c187c4e2b1f9"), "210", "2111235282311746", null, null, new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8"), "02/06" },
                    { new Guid("de1c615a-5655-47f2-9812-b7e68e770469"), "421", "3968916836217691", null, null, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1"), "01/17" },
                    { new Guid("de3ee753-7be8-49f8-827c-7acf18d80789"), "808", "7472742588750486", null, null, new Guid("617100a1-d830-4170-9964-86b27fc31a31"), "09/23" },
                    { new Guid("de9b3bae-edfc-46b2-9eed-ccb22d0c40d6"), "635", "5423854186371206", null, null, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f"), "01/04" },
                    { new Guid("df095658-456b-4f06-b505-e22e75a26a96"), "349", "7961342444047596", null, null, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058"), "03/15" },
                    { new Guid("df32d135-d2d6-4712-863d-05ced9b9320f"), "608", "2776519412394828", null, null, new Guid("52f24d75-fa03-403f-8430-5ca835f68726"), "02/03" },
                    { new Guid("df3695aa-e017-4b77-84c5-5ddcddb0e02e"), "601", "1772571022048325", null, null, new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2"), "03/02" },
                    { new Guid("dfa1d819-9550-4a1e-a774-cf1377a7175a"), "882", "4721482906151941", null, null, new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0"), "12/02" },
                    { new Guid("dfa28393-f89f-4441-a9c1-717f8d74f5cb"), "300", "5538982380308044", null, null, new Guid("43a79d17-6c7f-4919-8fc7-806f34234239"), "04/26" },
                    { new Guid("e09e974e-1c5f-40b5-a27f-4f144afce1e8"), "371", "4457140983579148", null, null, new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd"), "06/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("e0a09aba-f6b3-4fa1-bf68-2bc31d86ae51"), "839", "3811232456540734", null, null, new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420"), "02/15" },
                    { new Guid("e0a17115-c5bc-4add-858e-ae81cba260fb"), "598", "8554433747107619", null, null, new Guid("99227d48-6d3f-45fd-971b-83f0198ee703"), "04/03" },
                    { new Guid("e1f43a77-8312-4e73-a253-a5b5279362ee"), "391", "5174056370986856", null, null, new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6"), "11/15" },
                    { new Guid("e239b96c-1981-4c61-924b-2f35935f56b8"), "383", "3474832534333404", null, null, new Guid("80ed64a5-2f87-4262-aed3-901da3da1369"), "02/02" },
                    { new Guid("e26e62a0-1be9-42fa-9f21-727777549cdd"), "208", "4186777060316330", null, null, new Guid("cc9fd67a-df81-4c57-9231-20a528617118"), "05/02" },
                    { new Guid("e282baec-3191-406c-a83d-7a0ba2102b13"), "143", "8295028306583001", null, null, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923"), "06/09" },
                    { new Guid("e2a4c6ea-b666-4739-9198-f18ccd87aead"), "238", "2846883868515859", null, null, new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee"), "02/05" },
                    { new Guid("e3ca9151-f5f5-4b89-af64-ceeb1643c7c0"), "811", "7384568552452337", null, null, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5"), "07/28" },
                    { new Guid("e4afa812-f3aa-499f-9dcb-d465ad51aa75"), "780", "8059578064837261", null, null, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5"), "09/02" },
                    { new Guid("e4d99068-e6a4-4c74-9a4d-7771c6bb5dde"), "407", "1627750431647731", null, null, new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f"), "12/02" },
                    { new Guid("e6d88f15-707f-4f63-9c18-b4fa51399ddc"), "195", "6009163606735027", null, null, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc"), "10/10" },
                    { new Guid("e7329310-e97a-418c-8220-be58fda679c4"), "969", "2031509795686201", null, null, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc"), "08/02" },
                    { new Guid("e7ee9694-045b-4fcc-b8e3-71c5be175857"), "049", "5693507471193847", null, null, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4"), "12/22" },
                    { new Guid("e933eb58-5892-432d-a8d0-dc3353b04175"), "659", "8885512860171038", null, null, new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd"), "03/11" },
                    { new Guid("e9b594b7-9b35-4405-8b1f-cfff307e0549"), "861", "8559141421313046", null, null, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8"), "08/26" },
                    { new Guid("ea20975a-258f-4669-9317-4aafb484b721"), "723", "4208340410647562", null, null, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024"), "11/19" },
                    { new Guid("ea80dc29-dc04-46d9-a25b-7698748e4309"), "456", "4457546880888103", null, null, new Guid("730094f2-c549-4e04-b5a9-761af8d5725f"), "04/16" },
                    { new Guid("ec1be324-8b34-4d13-a562-5e5acef0d107"), "745", "2304348953392649", null, null, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c"), "04/08" },
                    { new Guid("ec3df317-756f-43d6-a6c9-5165f6e3ad58"), "289", "5917561858765462", null, null, new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da"), "09/13" },
                    { new Guid("ec767493-f338-421a-9209-9b1321f42129"), "834", "9893754604630521", null, null, new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6"), "09/14" },
                    { new Guid("eca093fe-f204-435a-81e9-3b9f4a5da9bb"), "558", "3187348598480067", null, null, new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c"), "07/20" },
                    { new Guid("ecbe9204-2494-4386-b81f-ebae8d0cb5d3"), "206", "5136823543798733", null, null, new Guid("6b524441-f464-4e08-8f72-3c7c650f6875"), "07/26" },
                    { new Guid("ecf89b5e-ca57-4e5a-b913-7ea36fad622d"), "876", "4660810181546852", null, null, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770"), "02/16" },
                    { new Guid("ed0a8496-422a-47fe-a332-5c30e8944756"), "645", "9541554211873995", null, null, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89"), "01/12" },
                    { new Guid("ed430a00-91a9-42a7-a03d-523fe17e6365"), "704", "9977677003505496", null, null, new Guid("88fbd469-d541-4e89-9736-988ca894e0e8"), "07/08" },
                    { new Guid("ed50bc8d-d5cc-4e62-9570-d58e8627261c"), "428", "2228130211560913", null, null, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1"), "03/18" },
                    { new Guid("ed947131-04a7-4771-ae04-af041be10239"), "300", "9009333485795941", null, null, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c"), "12/11" },
                    { new Guid("edb688c9-ebdd-4e97-ba12-104ec2bcd4ed"), "718", "2381359747514355", null, null, new Guid("3e1827bb-2cfc-4263-be79-7b663816638e"), "08/12" },
                    { new Guid("edc5d6b0-4e5b-4316-b2cf-938c516d5f1c"), "905", "1080696158617916", null, null, new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1"), "04/07" },
                    { new Guid("ede6d78d-7061-4c9c-b253-cbd25dc48581"), "098", "1670879746433655", null, null, new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99"), "04/10" },
                    { new Guid("ee226dd0-d048-415e-9cc4-69c75bf21904"), "801", "9133588274095017", null, null, new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228"), "05/20" },
                    { new Guid("eecac88c-e142-4c2e-87af-4094973c7078"), "876", "3362331165820984", null, null, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63"), "08/25" },
                    { new Guid("eecdcdad-3617-4c7a-9975-08c45e5c4d00"), "139", "6774335326495901", null, null, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a"), "10/21" },
                    { new Guid("ef9fe5fa-5c85-4c01-ba7b-63aeb4d3e498"), "389", "6918942399722580", null, null, new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760"), "05/28" },
                    { new Guid("efc256a3-7db2-4473-9c63-657cd56fde0e"), "914", "2732793868612987", null, null, new Guid("30e31307-3bbc-4483-bf55-601427ba031c"), "11/28" },
                    { new Guid("effe70c8-0512-40ea-a45c-6d73d26f43fc"), "422", "3430951591735755", null, null, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e"), "08/19" },
                    { new Guid("f06a678c-5f54-4084-b8ec-f941891c1fe3"), "719", "8260493168824188", null, null, new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a"), "01/27" },
                    { new Guid("f1c64074-eb99-49a7-a384-837eac0612b9"), "796", "3482378818093224", null, null, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4"), "11/20" },
                    { new Guid("f1fa5c42-7289-47f7-ab72-e05f99e60e7b"), "972", "6124843803046628", null, null, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b"), "08/26" },
                    { new Guid("f20327cb-475c-4b2b-97b5-b9bc9072cdca"), "680", "6287899253866829", null, null, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e"), "06/27" },
                    { new Guid("f207087a-75ec-4f09-9947-100c8a2f4a3e"), "394", "6547355237833121", null, null, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e"), "04/20" },
                    { new Guid("f21080a8-4549-4718-9eab-fd87be2bf6e4"), "232", "3391892903148550", null, null, new Guid("6b524441-f464-4e08-8f72-3c7c650f6875"), "06/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("f24d631f-ed5d-4cc5-b747-dfcd0efcfefa"), "477", "1394797024211164", null, null, new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1"), "11/14" },
                    { new Guid("f2d1cf6e-75d7-41aa-b3cf-a60fead87b42"), "834", "7642057659832788", null, null, new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979"), "05/11" },
                    { new Guid("f3521110-5559-4e54-aefa-f65f536dab01"), "218", "5935174154107837", null, null, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8"), "08/02" },
                    { new Guid("f3be7d30-6e08-4da9-9be0-25ba4cb1af1d"), "892", "3672970078739787", null, null, new Guid("80ed64a5-2f87-4262-aed3-901da3da1369"), "04/15" },
                    { new Guid("f432c56e-e84f-49a5-a017-3c71c293dd9e"), "526", "1722502738598200", null, null, new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5"), "11/20" },
                    { new Guid("f45086af-5e9d-4107-9865-de88727bb739"), "691", "3216359809171303", null, null, new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178"), "02/14" },
                    { new Guid("f459d333-7ed1-43a4-a396-c49871859424"), "864", "6842555938788931", null, null, new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a"), "08/07" },
                    { new Guid("f517d059-95a5-411b-be3b-20baa154ca65"), "502", "6924586654208581", null, null, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf"), "08/10" },
                    { new Guid("f56a28c0-5948-4305-8027-1ff275fd11bc"), "688", "6236797793280340", null, null, new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44"), "08/09" },
                    { new Guid("f58f2b41-ed16-40ac-acd9-8f65573fd7db"), "136", "8767403529673112", null, null, new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379"), "07/10" },
                    { new Guid("f5a1a351-514c-4d7b-966c-a9f0cf134aae"), "338", "1661689877381069", null, null, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656"), "02/16" },
                    { new Guid("f5a948d1-5d9a-4a0a-aa58-09ac418d83dc"), "073", "6644366519886967", null, null, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30"), "07/25" },
                    { new Guid("f6512e96-d69d-4c79-93a1-a709920fe30e"), "845", "4740037137251029", null, null, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc"), "10/14" },
                    { new Guid("f65edd79-40e4-4a1b-a052-fbfd9a89cc7a"), "053", "5718213545646561", null, null, new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470"), "07/05" },
                    { new Guid("f6ba1312-2b85-4dc7-a976-b8955ecbdde4"), "353", "4821933702756961", null, null, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811"), "04/15" },
                    { new Guid("f6ed1b98-2bdb-4345-8085-4c8e9270bd80"), "781", "6018463087596192", null, null, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553"), "10/18" },
                    { new Guid("f70576cd-c389-4a49-a333-383743fa1412"), "225", "2096395217354987", null, null, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae"), "09/08" },
                    { new Guid("f7327b12-fc45-4152-bcac-bf4ee25a4880"), "031", "6654994262007161", null, null, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc"), "07/16" },
                    { new Guid("f742167b-5948-4707-92a9-e384b1fe66aa"), "549", "2797137588041354", null, null, new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1"), "03/13" },
                    { new Guid("f7685b94-e71a-4364-942b-3835166ebca6"), "619", "9650849927227687", null, null, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4"), "04/10" },
                    { new Guid("f7926fbc-4ee3-46db-851f-ef0ca4ad2035"), "668", "5787071798419697", null, null, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785"), "04/05" },
                    { new Guid("f7df1fcb-33e4-40dc-bc20-85021b7352fb"), "875", "8923947788465828", null, null, new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9"), "03/20" },
                    { new Guid("f8005c19-a422-4e26-930c-16e781a60635"), "825", "3979483063627126", null, null, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1"), "09/01" },
                    { new Guid("f82fe727-7b0a-406d-8a55-480792e784fb"), "201", "8478632626817030", null, null, new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b"), "05/01" },
                    { new Guid("f8795fa9-8675-41be-8d13-5afbd921b6b0"), "836", "1170499269219768", null, null, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9"), "03/12" },
                    { new Guid("f8c0d995-d74f-44e7-aab9-bf57761cb87e"), "340", "6581787394952188", null, null, new Guid("88fbd469-d541-4e89-9736-988ca894e0e8"), "09/17" },
                    { new Guid("f9441a8d-e735-4c89-8926-bf172995dfe1"), "223", "5857479168466883", null, null, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1"), "03/06" },
                    { new Guid("f987bd01-6bc3-4272-8555-56cfdbd9dd67"), "468", "2956661562295706", null, null, new Guid("4e0204f0-eb29-4713-873b-136318951b1d"), "07/22" },
                    { new Guid("f9df87fe-73c0-408a-a51c-2fb3bad5a372"), "999", "2349268378380529", null, null, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc"), "02/08" },
                    { new Guid("fa663c06-30eb-4feb-ab49-ca389d16ac34"), "523", "6948522755528000", null, null, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3"), "12/19" },
                    { new Guid("fabb3101-9862-4118-a7d3-f98bac258c5e"), "953", "4644636716123771", null, null, new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8"), "05/28" },
                    { new Guid("fabc4594-62e2-49c1-b7de-41be002a2d2b"), "974", "3815513723700047", null, null, new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c"), "08/22" },
                    { new Guid("fad9a7d9-21d2-4323-929b-55e0946ba215"), "732", "5637347822891851", null, null, new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee"), "10/11" },
                    { new Guid("fb45a1dd-bd2c-4c1a-bec2-40516a89b7b6"), "438", "9386893426569534", null, null, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc"), "10/14" },
                    { new Guid("fb58b032-20a5-4e7a-8a23-b075fd281cd0"), "901", "3991920007345807", null, null, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98"), "07/04" },
                    { new Guid("fbd222fd-7043-4551-a39f-ecac9df4273a"), "181", "6020463407953996", null, null, new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d"), "04/23" },
                    { new Guid("fbff600d-0638-4fb8-8ffa-d8f6efb0f6da"), "123", "1142438018302716", null, null, new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da"), "02/14" },
                    { new Guid("fc552b34-0630-4bae-aecd-e325cf4cf97c"), "634", "4396802943322597", null, null, new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb"), "07/27" },
                    { new Guid("fcbbbd5b-1a19-45e7-bb2c-c285ec355148"), "754", "3808454707150669", null, null, new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56"), "06/16" },
                    { new Guid("fcdd43e0-bc29-409e-87c1-781779321498"), "633", "1986466785812958", null, null, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024"), "12/22" },
                    { new Guid("fd014bbf-d998-413d-bf54-2409e7ea3ebc"), "717", "9923356993603079", null, null, new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf"), "04/02" },
                    { new Guid("fd2c7ab8-b6a5-4e51-9d30-c25b1bf3b78b"), "659", "6616600954767812", null, null, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024"), "10/06" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("fd4a8343-059e-4132-aba2-a8d694e633b9"), "052", "9715524235086117", null, null, new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420"), "03/28" },
                    { new Guid("fd4cd31d-7f55-4fdc-b667-b0a98e9d6d16"), "620", "6967442419937632", null, null, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b"), "04/12" },
                    { new Guid("fd961f10-616d-4051-b5c5-2a2e62d8381e"), "392", "1531529146511713", null, null, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1"), "05/10" },
                    { new Guid("ff099b8b-975e-4487-ad3e-2b3dd60eb847"), "474", "6267074982264180", null, null, new Guid("8be83005-0ddc-42eb-877d-582666d35fea"), "06/07" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("000971d3-a8d7-4cb8-85cf-a287eddfe728"), null, null, "+622 02 (068) 58-77", false, new Guid("5ffc49e2-50fb-41f2-8784-192077f86010") },
                    { new Guid("00187b60-0aaa-4bf7-9cd7-f8a33f9fa391"), null, null, "+258 69 (223) 64-09", false, new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b") },
                    { new Guid("001ab5cf-e4de-460e-a854-b9a05ad0e59b"), null, null, "+302 18 (477) 10-36", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("0028f92a-ab6e-49c0-9539-8f19d20d7e25"), null, null, "+53 42 (520) 56-75", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("00f767bd-bf47-44fb-9f84-3bff0e74dfb2"), null, null, "+515 71 (642) 81-93", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("013b7aff-6c46-43e4-8824-643f6a40c409"), null, null, "+447 16 (263) 83-62", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("0166bf71-f016-44a4-af66-f8624ea149d1"), null, null, "+479 22 (674) 76-32", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("01a13b26-d30d-40ec-9154-958ba95c7094"), null, null, "+878 97 (084) 89-28", false, new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14") },
                    { new Guid("01c97c61-77d9-4e1a-9fa6-bb6a2a5a7885"), null, null, "+839 66 (596) 11-17", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("01ca8fd5-e69c-4c3b-9967-c1228588772e"), null, null, "+65 43 (753) 95-13", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("02396928-af1d-4164-9e5b-21c8f7e079f8"), null, null, "+511 90 (959) 92-28", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("02438951-3f90-43eb-95ad-fd318db0be4d"), null, null, "+523 08 (725) 22-85", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("0262efa9-bf8b-4812-8e82-ac16a72cf852"), null, null, "+779 08 (173) 84-04", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("02d2591a-c1a4-455d-aaf4-6bbc5928d734"), null, null, "+675 89 (132) 29-55", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") },
                    { new Guid("02ff77eb-1bba-4fce-8bc9-b59fb84a5dab"), null, null, "+961 47 (319) 74-41", false, new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a") },
                    { new Guid("031bc950-482c-4d2b-8bfc-971d695fb8de"), null, null, "+10 89 (403) 07-85", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("03bcb4e1-e5c8-4a2b-be4a-ecad70cddfdd"), null, null, "+123 66 (086) 97-71", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("03cd5d05-ef33-4aa9-ad88-79cf3cfd426f"), null, null, "+447 53 (199) 70-12", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("03f06097-ada9-4a6a-be1d-e51014f620a9"), null, null, "+260 94 (807) 91-13", false, new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a") },
                    { new Guid("042b0b4e-fd11-4658-affc-80da440d3a97"), null, null, "+43 20 (825) 28-01", false, new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6") },
                    { new Guid("04642156-5f7c-45a4-b270-2ad4d27b28d1"), null, null, "+155 85 (152) 74-45", false, new Guid("4fde002a-ab64-405c-bb95-313bef89420b") },
                    { new Guid("0572d733-e9a4-4556-9e5a-fddfd8b2b36d"), null, null, "+20 01 (089) 28-44", false, new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56") },
                    { new Guid("05cfbc27-4e2d-4d5c-8cec-d0ef5e5b8c43"), null, null, "+210 71 (101) 27-63", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("064aec74-13a2-44c3-bc81-11f16b1acd24"), null, null, "+960 91 (874) 71-05", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("0669f200-83bb-433d-a215-438296554919"), null, null, "+254 01 (083) 17-55", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("06a80292-4efc-424d-86a6-9a3f7840ba39"), null, null, "+646 19 (545) 54-26", false, new Guid("6bf86772-9995-44ea-a063-ccc583990881") },
                    { new Guid("06b2956d-1c6a-4dfa-bdfc-5883445f36d2"), null, null, "+525 07 (092) 80-79", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("06f86ba2-b4ed-4812-b48b-e7e1f94e4c1e"), null, null, "+11 53 (423) 44-93", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("07233757-d752-46be-b835-6acc2cebfe81"), null, null, "+757 25 (682) 02-22", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("079c2797-f6c5-4ee5-8076-27c4bd9216fd"), null, null, "+77 32 (622) 09-63", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("084fdf1e-e028-47dc-83e1-df690498ef85"), null, null, "+638 98 (068) 99-32", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("09d2059c-8eaf-4b46-9773-2c3144f42ce9"), null, null, "+731 16 (445) 45-43", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("0a0ce22f-5a4d-42ce-9cec-0e4a442b0177"), null, null, "+857 99 (773) 32-45", false, new Guid("8be83005-0ddc-42eb-877d-582666d35fea") },
                    { new Guid("0a7ed091-b5e6-4ad1-b499-8b4e3f60b589"), null, null, "+214 72 (627) 40-27", false, new Guid("52f24d75-fa03-403f-8430-5ca835f68726") },
                    { new Guid("0aa50f60-e0a1-4b17-84d8-9010716f1c94"), null, null, "+471 46 (675) 96-40", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("0ab30cd5-91a4-4a67-931c-2d1305ba0dc4"), null, null, "+410 53 (958) 13-30", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("0abe372f-66d0-4c36-b270-c955790b24a7"), null, null, "+785 73 (147) 57-74", false, new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2") },
                    { new Guid("0ac618ca-ab9e-4a4c-af86-200369c50357"), null, null, "+34 67 (214) 38-67", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b33b0ef-0d98-41fc-ae35-e20b8608a2a8"), null, null, "+918 47 (105) 27-47", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("0b396737-00b0-419d-8141-f44118c7e1dd"), null, null, "+179 29 (471) 23-57", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("0b97a375-5584-47df-8d7a-2e7d3d17bbd7"), null, null, "+807 13 (828) 23-73", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("0be3031e-75ef-4576-8145-7a319da329f0"), null, null, "+274 73 (959) 41-48", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("0beb0a0f-9f97-4336-9cd2-3cbe53614d46"), null, null, "+656 63 (773) 39-94", false, new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b") },
                    { new Guid("0c29bfb5-344d-43a5-9cf0-a986949fe233"), null, null, "+203 02 (951) 07-67", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("0c594a9e-9f89-428f-a0bd-147d05a20506"), null, null, "+876 15 (970) 21-02", false, new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9") },
                    { new Guid("0c68c99d-f67c-4496-8ff8-1c57be1c763d"), null, null, "+2 60 (292) 08-52", false, new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8") },
                    { new Guid("0c804911-a503-4165-8d38-3658de9da152"), null, null, "+711 59 (902) 73-63", false, new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73") },
                    { new Guid("0c84ba94-feb5-4b26-af0a-8fc490667703"), null, null, "+976 01 (606) 65-15", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("0caeadac-4446-4b87-a18f-85502eae4229"), null, null, "+732 94 (408) 27-13", false, new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9") },
                    { new Guid("0ce9fb58-d314-4cb2-be85-f2dc7474ed91"), null, null, "+847 59 (006) 66-90", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("0d219a56-1b4a-45e7-ab7f-5afa6f3cacb2"), null, null, "+905 85 (210) 13-71", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("0d38b688-6d46-41bc-ad7f-56ebb93f4e65"), null, null, "+809 49 (206) 01-64", false, new Guid("1fd15a4f-2c37-4b8e-8a54-96d88e59484b") },
                    { new Guid("0db06db8-ed51-4c58-9d0c-e58c38f21ffe"), null, null, "+697 13 (449) 74-48", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("0df696a8-7e33-4aa3-841d-db03d11a384d"), null, null, "+57 48 (606) 84-03", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("0e02febe-1726-4762-b9b9-74f30adaef85"), null, null, "+44 47 (895) 06-79", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("0e1b75cb-e435-4fa8-a6b2-fea424930b8b"), null, null, "+107 88 (801) 18-18", false, new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760") },
                    { new Guid("0e29bf6a-4ea6-432d-96c5-f5f96eda0dd3"), null, null, "+423 22 (997) 65-61", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("0e9f888e-6fa0-44e4-8ccf-d9e9d4270a39"), null, null, "+155 52 (937) 65-13", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("102f8f50-9571-46d0-8456-bafb0bc15ba3"), null, null, "+421 40 (324) 26-06", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("104738f4-c6f8-4bf9-a9dc-3478e455850e"), null, null, "+705 58 (667) 92-81", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("10dd03c8-8d3e-4df2-bf78-02b37eed810f"), null, null, "+287 60 (310) 81-53", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("111a928d-1ab9-4ea8-8b1b-00ce75b75e40"), null, null, "+793 26 (033) 67-10", false, new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1") },
                    { new Guid("11645512-5c4c-4d8f-8a51-d30aaa689a3b"), null, null, "+805 73 (506) 87-20", false, new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8") },
                    { new Guid("1166540a-dd15-495c-ab30-af1acd99835e"), null, null, "+351 60 (079) 99-64", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("11b0b047-7c54-4366-a277-e25dfd84e703"), null, null, "+625 95 (414) 22-62", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("11ff5bc2-5126-4dec-810a-f3ca1af3a3fd"), null, null, "+948 36 (460) 90-97", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("1273e624-3861-49b1-a4e6-4e2dc582506c"), null, null, "+487 00 (880) 04-90", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("12d44687-455f-467e-987b-dbc4059d2a9a"), null, null, "+943 89 (348) 73-37", false, new Guid("617100a1-d830-4170-9964-86b27fc31a31") },
                    { new Guid("12f7dd34-3041-442e-9fe4-2a9f3801b143"), null, null, "+894 32 (679) 88-41", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("1337890d-9457-4ff5-b382-2786180c8266"), null, null, "+928 29 (641) 18-87", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("13feda25-00fe-470d-a7a5-39caf6b1fd46"), null, null, "+124 14 (580) 91-72", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("14203ccb-e00a-48be-8f87-e9e02b0b1896"), null, null, "+175 83 (006) 25-97", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("1450d71b-c102-4aba-8a3a-34089bc87908"), null, null, "+696 45 (031) 37-31", false, new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942") },
                    { new Guid("14663028-4aea-43f9-9239-3309c2108932"), null, null, "+375 98 (129) 50-82", false, new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303") },
                    { new Guid("14729b71-476d-42f6-a163-d1912520c790"), null, null, "+328 42 (079) 71-36", false, new Guid("88fbd469-d541-4e89-9736-988ca894e0e8") },
                    { new Guid("14cb814f-ec90-47c0-99f9-27d99afd97ea"), null, null, "+692 24 (266) 20-69", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("151dab67-dc4a-4a61-ba24-d8e208945e53"), null, null, "+989 63 (704) 64-90", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("158adb2d-0239-42c9-8d43-880bf32c8290"), null, null, "+499 92 (452) 24-82", false, new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af") },
                    { new Guid("16e1dda5-1997-4337-9d07-c147180173e8"), null, null, "+293 99 (155) 46-23", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("17225a61-4d37-4f4f-b23e-c95b0bbc1d45"), null, null, "+276 33 (116) 65-07", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("17702153-c74f-474f-9d92-822c6734a785"), null, null, "+729 47 (010) 48-65", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("1779b035-401c-4f90-be93-07a65589cde4"), null, null, "+522 38 (787) 92-60", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("17a2e765-1e17-4158-ba08-4670dcb3d68a"), null, null, "+911 93 (401) 90-45", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("17f0c69a-5906-4faf-80ef-6729ec7e9858"), null, null, "+186 49 (629) 24-17", false, new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979") },
                    { new Guid("184a8b34-4e89-4f28-b8c9-f26f9765e456"), null, null, "+669 21 (014) 33-95", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("1886073a-1260-4c5c-9972-272df61b8227"), null, null, "+180 70 (659) 36-52", false, new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a") },
                    { new Guid("189dbc6f-9d33-40f7-a208-823804cd96ee"), null, null, "+941 02 (917) 96-28", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("18ab3a6d-07cb-484d-b2e1-4edad5841634"), null, null, "+150 40 (089) 27-84", false, new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("18b99202-86d9-431e-8613-07b44b364250"), null, null, "+503 77 (482) 68-45", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("193a5a14-093b-4dc8-8cd2-9a914e8b07d5"), null, null, "+307 79 (380) 32-46", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("19885c66-7180-496a-be3b-1cf95a586ca7"), null, null, "+532 12 (019) 34-48", false, new Guid("816326af-094b-4b97-b10b-548a2296766b") },
                    { new Guid("198d27b7-c3b8-406d-ba38-4647139bd408"), null, null, "+269 29 (261) 98-01", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("19bda2d0-877c-4aa9-b2dd-1ffb4bb7caa5"), null, null, "+363 24 (130) 95-98", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("19d7fb9f-8600-494e-8d0e-0e813bf4d8c8"), null, null, "+487 62 (861) 35-65", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("1a759aa8-5552-4bf2-ac69-e4abcf796b76"), null, null, "+33 66 (042) 10-17", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("1ac2a06a-71eb-48f3-a6c1-f250bf74480e"), null, null, "+414 63 (433) 72-23", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("1ae903dc-3539-42da-a276-35138fdc498c"), null, null, "+339 96 (695) 10-30", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("1bf99545-50ec-4e55-9f45-f68a0f0a4b51"), null, null, "+657 04 (697) 44-45", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("1c49001c-3df9-4afd-a9bd-c67b0b8e0b25"), null, null, "+418 14 (588) 42-04", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("1c6af485-f939-4288-af8c-f838cf8f5330"), null, null, "+699 29 (840) 03-31", false, new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("1c7f2016-2b1d-4e95-848c-96e872a51bc8"), null, null, "+958 00 (085) 96-60", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("1ca10148-d8f5-4444-bacd-2265286d6c6a"), null, null, "+611 19 (321) 18-11", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("1ddaf876-66cd-4529-a88b-7671107b9fce"), null, null, "+790 35 (692) 78-32", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("1debbc52-1b43-49c4-9d46-d896dc6f7c23"), null, null, "+62 79 (273) 17-93", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("1e4a87f2-24e9-453a-8607-ac76f9df3aaf"), null, null, "+909 12 (290) 22-99", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("1e8f711b-656f-4d9f-99cc-2ff4c1b012c2"), null, null, "+796 35 (442) 89-79", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("1e9ba289-2fa2-4afa-96b6-80a85e802e5a"), null, null, "+770 46 (929) 20-19", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("1eacd144-6631-44dc-9c26-6982a469e007"), null, null, "+238 61 (958) 86-80", false, new Guid("7573b136-e686-46e6-b0af-1186d8e37af1") },
                    { new Guid("1ebf3447-3d99-4e67-a277-b009500a35c7"), null, null, "+60 05 (842) 27-04", false, new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("1ec72d10-bced-4ade-88fa-614f572dabc6"), null, null, "+724 24 (069) 42-90", false, new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1") },
                    { new Guid("1f5825be-6ef5-4788-b306-82e3d280ff2c"), null, null, "+567 12 (176) 16-23", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("1f80138c-4663-4688-acc8-9fdc566ec87d"), null, null, "+946 22 (642) 38-54", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("20374c76-5f46-4b2f-af0f-dd57a6bd9c7f"), null, null, "+859 02 (242) 21-50", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("205dff18-bdf4-443c-9d14-66377b22453f"), null, null, "+388 90 (747) 70-51", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("20e818e2-7a6a-4681-9033-7e2f2fa126c0"), null, null, "+418 48 (993) 85-98", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("21cbd495-9ecc-43bf-8f1b-28cd5df8045c"), null, null, "+116 73 (917) 58-17", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("229d1747-16ae-45d2-8674-6c2e1a4b3dcc"), null, null, "+837 03 (055) 47-96", false, new Guid("7573b136-e686-46e6-b0af-1186d8e37af1") },
                    { new Guid("2310d743-d00a-4ae1-a291-4eeb33b5f6af"), null, null, "+198 64 (482) 20-92", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("23c12d57-932e-4439-a528-de3cefed13aa"), null, null, "+841 64 (695) 25-64", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("248e8f1f-e40a-4f2e-96ca-dd75050c77cd"), null, null, "+793 08 (864) 56-06", false, new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098") },
                    { new Guid("24bb679a-d511-4205-a91e-ae0852cc17e6"), null, null, "+877 77 (331) 38-56", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("24f63413-d1a0-485b-aea1-0ee19f85193d"), null, null, "+669 36 (494) 24-81", false, new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("25ad2cce-7822-4633-99c6-f48dceb7ec89"), null, null, "+811 17 (867) 73-08", false, new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1") },
                    { new Guid("25e4985f-5023-438b-a4d7-897fa7f85295"), null, null, "+452 59 (687) 98-51", false, new Guid("cb7bdda6-c336-4649-b7a8-30a838ba671a") },
                    { new Guid("25f35d20-4330-4490-91a8-fb383b09c04f"), null, null, "+305 09 (861) 68-82", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("26199dca-6978-41b6-8da9-8e405f325bdf"), null, null, "+834 12 (361) 12-67", false, new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117") },
                    { new Guid("266945cd-d09f-4351-9ac8-d74605eb549e"), null, null, "+775 56 (879) 70-49", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("272995a2-b34a-4ce3-9272-774a276f2a21"), null, null, "+311 22 (613) 51-39", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("274557b4-e7ba-42ba-a6e2-1d11d38ea9f8"), null, null, "+334 82 (471) 04-66", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("27f9cf73-2bbc-4aa3-9d7f-28215ac879d3"), null, null, "+246 25 (135) 88-61", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("2861eb84-007b-4ac8-8da2-b3806581d3e3"), null, null, "+553 66 (221) 94-21", false, new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063") },
                    { new Guid("28f4b44c-3508-4d56-b2eb-0c766a320438"), null, null, "+660 02 (737) 05-48", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("2974429b-c949-406c-9f33-2ee69024c167"), null, null, "+488 38 (812) 04-65", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("2a5d3690-148e-48cf-9a04-2779e377d009"), null, null, "+831 07 (305) 50-85", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("2a81f108-d7c0-457e-9503-2dccbbdf446c"), null, null, "+915 59 (242) 30-44", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("2aacd3f3-3422-41d3-8dde-1e9c47bf4b8b"), null, null, "+949 78 (329) 11-34", false, new Guid("30b2066d-f465-42ae-93e3-4a38936052b2") },
                    { new Guid("2b032bd0-7dc9-4270-bed7-00d6d5512014"), null, null, "+158 01 (936) 26-24", false, new Guid("78016c36-672a-4efd-980e-250a79e4d32e") },
                    { new Guid("2b7eaf2c-7d7a-41d3-abf6-d9d2083a5004"), null, null, "+396 76 (713) 87-51", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("2dc03896-4d3e-4f70-8702-2d68c6cef0c2"), null, null, "+662 42 (765) 91-60", false, new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4") },
                    { new Guid("2dc2de1a-cdc7-487f-b1a6-110065960b67"), null, null, "+394 55 (458) 83-19", false, new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6") },
                    { new Guid("2de947d7-f6c0-4d50-8f36-1180a4b44d4a"), null, null, "+395 92 (443) 23-37", false, new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf") },
                    { new Guid("2e6558c9-409d-4c18-a560-5f01ebd3ffd2"), null, null, "+352 68 (450) 56-46", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("2f2648f7-a8ab-4841-a353-89b9c3ceca00"), null, null, "+559 00 (154) 76-50", false, new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8") },
                    { new Guid("2f717457-03dc-4e82-98b9-92b2a2abdf02"), null, null, "+758 27 (869) 28-92", false, new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee") },
                    { new Guid("2f8dccfc-fbeb-4084-82fb-bb461d78bf23"), null, null, "+981 89 (425) 43-46", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("2f93180b-e43e-47c0-82b6-88ab14b1be84"), null, null, "+873 13 (033) 70-85", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("2f94533a-a7b8-4d7f-8815-d220d5c4d486"), null, null, "+888 65 (304) 62-58", false, new Guid("b6d7f146-cd4d-45ac-b151-77e482bd0979") },
                    { new Guid("2fb3ed18-4956-42ab-a90e-eff4315ace59"), null, null, "+54 52 (459) 11-19", false, new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("30360c27-1ed0-4493-8187-6432b4c47065"), null, null, "+63 14 (914) 26-52", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("30565684-1a62-47ad-af54-e970c9c7808d"), null, null, "+913 52 (289) 02-23", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("3075745b-4057-418c-b1a6-12041a4836d3"), null, null, "+56 73 (013) 25-10", false, new Guid("80ed64a5-2f87-4262-aed3-901da3da1369") },
                    { new Guid("309eed15-321f-4ab6-8581-6a08abcf1897"), null, null, "+878 68 (250) 31-77", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("30d9b224-3341-42f1-b1c6-639ae326ed18"), null, null, "+248 91 (215) 10-42", false, new Guid("0a216877-a641-4931-b378-aaf35dcfe2c1") },
                    { new Guid("30e66432-2d65-4dac-9f3b-cb70f4e569c8"), null, null, "+364 87 (771) 08-59", false, new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219") },
                    { new Guid("3109d506-b282-4d80-bb84-d5754bc0d34c"), null, null, "+778 83 (467) 61-69", false, new Guid("0f9851be-b682-479e-aec8-51795a73a90e") },
                    { new Guid("3130fc0c-4f5c-43d6-a6d7-3d1c59364024"), null, null, "+427 61 (037) 41-45", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("31f9f463-7901-4f98-aa36-e0c59415deb1"), null, null, "+578 86 (561) 53-91", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("31fed91e-3141-4c05-b54d-ce2dfd4653b3"), null, null, "+482 55 (618) 35-01", false, new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614") },
                    { new Guid("3205a7bb-3da6-44ad-9d7a-e7f9f18a369e"), null, null, "+665 14 (638) 66-54", false, new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb") },
                    { new Guid("320b43a4-a17c-48f0-a857-31398192f0f3"), null, null, "+524 57 (993) 02-90", false, new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef") },
                    { new Guid("320c8fff-c350-4853-af67-e482ed382ece"), null, null, "+467 59 (222) 96-92", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("3212db92-3106-4194-9693-8f1c86813b5c"), null, null, "+957 08 (542) 76-24", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("32144107-ad0e-4df3-b997-de315517521c"), null, null, "+52 74 (659) 15-81", false, new Guid("e2a434c4-432b-4289-b5d4-a2e1b797ffef") },
                    { new Guid("326a1e9e-7dcd-4a54-824d-6a2960648970"), null, null, "+405 16 (905) 75-48", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("32771825-a37e-4c9b-94fe-14ffc0ad975e"), null, null, "+668 91 (771) 29-52", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("32981368-6d6c-42c6-a2ee-bbdb4ba5ca1d"), null, null, "+433 41 (134) 98-44", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("32b1ec66-4abd-436a-bf5f-76505744c8ce"), null, null, "+675 97 (192) 27-30", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("34e40170-6bde-4f0e-949f-4a5697c0e69f"), null, null, "+138 23 (729) 65-06", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("3567ac9c-9cbb-4275-bab2-1ad865e02315"), null, null, "+203 70 (950) 07-60", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("35d4ad8d-7db1-4bc6-ad77-6682909416e3"), null, null, "+641 28 (643) 47-03", false, new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4") },
                    { new Guid("35e3633e-31ea-4fdb-a2d9-36bb3daa645b"), null, null, "+60 05 (006) 97-11", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("364bd428-530e-4d31-abff-18a9ae9c9375"), null, null, "+803 62 (608) 33-78", false, new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67") },
                    { new Guid("3652d8b0-df55-4c60-b612-a48ab007a08d"), null, null, "+65 19 (067) 87-41", false, new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("365a69ab-7f65-4bbc-9eef-f29b871319a7"), null, null, "+312 74 (988) 81-89", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("365ed000-cfd3-4f7b-8d59-b95dce183a1c"), null, null, "+896 60 (803) 18-78", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("3677649a-20c0-4427-a4cf-838b6bace69a"), null, null, "+897 38 (462) 67-59", false, new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e") },
                    { new Guid("36a843f3-b2c3-4490-8f81-0cf94d582d79"), null, null, "+91 23 (649) 03-96", false, new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c") },
                    { new Guid("36b6ca67-5474-47ff-b213-5234eda74162"), null, null, "+952 56 (997) 39-45", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("371fc857-2ae5-4789-98c9-f6e54fddeec3"), null, null, "+913 43 (347) 55-39", false, new Guid("ce1f07b6-54d9-4379-9845-3751b9499199") },
                    { new Guid("388b59ed-081d-4077-925d-25c5449f3588"), null, null, "+420 90 (722) 72-79", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("390f9eb3-acdf-4aea-9ec8-d726f9fcbc92"), null, null, "+222 52 (635) 81-86", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("396a1890-f687-4eb9-b536-afb0924bbca0"), null, null, "+101 70 (084) 91-11", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("39ae695d-9447-447b-a675-721313a634aa"), null, null, "+680 24 (965) 10-17", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("39f135d0-65ca-435f-8f09-ad4c848d455b"), null, null, "+251 20 (042) 61-31", false, new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228") },
                    { new Guid("3a1c4d88-cecc-40d5-b374-43448ce06541"), null, null, "+630 58 (294) 21-25", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("3a20e681-eeff-4411-83b5-e034c7fa8019"), null, null, "+437 85 (020) 85-66", false, new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("3a3b2395-7564-48be-9a24-aa6272ee50b6"), null, null, "+267 51 (392) 02-10", false, new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("3ad11e2e-c7c2-4882-966f-c1180f73924b"), null, null, "+321 59 (337) 60-27", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("3b33fdd5-7ca7-4887-b284-cf06bcc45931"), null, null, "+173 59 (140) 78-36", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("3b43ad09-9b1f-4813-80b4-872c99c1743c"), null, null, "+70 28 (519) 24-15", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("3bd12b10-4ef4-4e99-81da-0cb59ecb30f8"), null, null, "+627 02 (906) 98-44", false, new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665") },
                    { new Guid("3c37283c-0524-4f20-827b-9a5b46ca8cd5"), null, null, "+126 05 (500) 84-78", false, new Guid("da01c05f-d8e2-431d-b7a8-ed6287296d56") },
                    { new Guid("3c3b8433-64fd-44d6-ae5b-52a7c30a63c9"), null, null, "+550 53 (174) 62-73", false, new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c") },
                    { new Guid("3cd0ad22-a5f5-4ae4-8959-532b1c8978cb"), null, null, "+21 86 (346) 20-86", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("3d59ffb4-002e-48b5-a4e1-0491236517a9"), null, null, "+980 66 (047) 70-85", false, new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9") },
                    { new Guid("3d7fdd59-7c71-40cf-ad54-5af61dcab396"), null, null, "+651 54 (732) 52-74", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("3e179948-c8dc-49d7-b9f5-1ce49e0d657e"), null, null, "+793 85 (123) 78-27", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("3e1c0599-4b76-426d-9196-c42d05c30eef"), null, null, "+145 57 (062) 67-30", false, new Guid("8461c967-9f1c-48cc-85ae-66b9741be768") },
                    { new Guid("3e63e4ad-5a74-42be-b194-5e417b5f9b03"), null, null, "+991 80 (982) 58-35", false, new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9") },
                    { new Guid("3f120c85-13e2-4822-9d37-78783ebe97f9"), null, null, "+547 10 (435) 34-29", false, new Guid("d0fc5c34-79cd-4b2e-ada0-ba81b3f43665") },
                    { new Guid("3f4dd348-93b7-4b90-bd25-5272d004fe2f"), null, null, "+394 01 (069) 45-28", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("3ff3de5b-50bf-49de-b7d3-0a4c7e724669"), null, null, "+764 56 (120) 02-54", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("405c697f-c700-4465-8fe4-809e33d5354a"), null, null, "+532 84 (339) 91-83", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("407960f7-e662-4141-87b9-32214c66876e"), null, null, "+141 09 (835) 60-97", false, new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("40e8809b-8a89-4733-b3f2-18008655c82b"), null, null, "+727 39 (851) 80-58", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("4234d508-4dbd-4f3b-a2cd-a7f0a9c75b09"), null, null, "+175 79 (771) 31-65", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4253348d-d04e-4742-8566-9e8d8f2d99be"), null, null, "+640 59 (106) 62-56", false, new Guid("408baf60-7a28-4b53-a327-b4c8234de1d2") },
                    { new Guid("4270c2bf-500e-4947-ba19-95415579431e"), null, null, "+858 95 (890) 27-77", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("42d262af-bbff-4ace-8375-5a469cc3fbdd"), null, null, "+821 31 (270) 96-98", false, new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") },
                    { new Guid("4328444b-6988-4e7a-a6ba-dc3a7d2715aa"), null, null, "+593 88 (104) 59-57", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("433a3ba8-d6e8-46d6-86c5-f321a8e97afd"), null, null, "+887 72 (278) 77-16", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("433e85d9-83d0-40d6-83f6-b8d487cc2f90"), null, null, "+843 74 (895) 41-75", false, new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45") },
                    { new Guid("436b5cac-1931-42f9-abac-7a7babd0efdd"), null, null, "+316 38 (064) 87-79", false, new Guid("8fc1a564-83eb-42fe-bb4c-f320e292768b") },
                    { new Guid("43f5eb87-d81f-4d90-b2c2-d22b373d1c10"), null, null, "+275 35 (586) 11-25", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("4427b3d9-46bc-408b-850d-976940e4fcf0"), null, null, "+376 68 (072) 45-67", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("444a1c14-9fa7-400b-be61-202400b18cee"), null, null, "+638 32 (144) 83-04", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("447cf47b-e3fb-42ff-8cf9-2c4b1117f905"), null, null, "+402 53 (089) 06-17", false, new Guid("816326af-094b-4b97-b10b-548a2296766b") },
                    { new Guid("454bc639-8e68-42aa-941b-3ba852635593"), null, null, "+455 91 (532) 54-53", false, new Guid("6bf86772-9995-44ea-a063-ccc583990881") },
                    { new Guid("455b6ae6-4404-41b9-bc4e-a2bcd4e7d8cd"), null, null, "+421 69 (647) 42-38", false, new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6") },
                    { new Guid("457040e2-2161-436e-ab4c-f5b058a21444"), null, null, "+957 16 (411) 85-95", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("469d9c8a-8332-4bdc-9e54-0e76d44fda8f"), null, null, "+600 93 (257) 80-95", false, new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5") },
                    { new Guid("473d084a-0456-4bfc-9115-da6cbf974764"), null, null, "+500 10 (666) 77-40", false, new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("476192c1-41b1-4a0a-86d1-83fafe35ef8b"), null, null, "+457 87 (439) 35-92", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("47713e6b-db4f-4960-bf54-b7447db3edbf"), null, null, "+470 68 (581) 59-59", false, new Guid("4f03daca-02fb-425a-a575-bef52173e4d3") },
                    { new Guid("478dc65b-4839-4b0d-aef4-557c310397a0"), null, null, "+109 25 (142) 57-74", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("478ecbed-482e-4601-a6bb-886605d5ad7e"), null, null, "+763 25 (540) 54-57", false, new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0") },
                    { new Guid("480e7651-afbf-425d-b490-22008c268a40"), null, null, "+826 69 (014) 12-67", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("489592a5-2aac-4988-b611-3859e8ba96a1"), null, null, "+469 60 (231) 55-25", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("489e3d35-b834-4127-8deb-df90be6a776e"), null, null, "+593 89 (184) 20-05", false, new Guid("ac8e99f4-d56d-4ac3-a22d-ad5e01fa2811") },
                    { new Guid("48ba5070-bb9a-4eb0-bad1-ba5d005a7adb"), null, null, "+317 63 (645) 26-15", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("49111d3e-8e87-400a-9da0-437fa36db754"), null, null, "+180 52 (125) 09-79", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("495fb978-2c9b-4b36-aae6-ac69e4b9b3e2"), null, null, "+531 73 (657) 40-29", false, new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6") },
                    { new Guid("4982123d-4021-4abb-a539-6fec561ba609"), null, null, "+876 39 (078) 55-99", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("49a04ef6-8d43-4702-952a-2697a96d64c3"), null, null, "+84 95 (262) 43-91", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("49c54703-e88b-424b-8a84-0478d9488a80"), null, null, "+995 52 (444) 37-83", false, new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("4a4c7e03-c29c-4750-bbe8-b7ca6c1d4cb2"), null, null, "+694 64 (627) 40-61", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("4a8ba7cc-4dea-456b-927c-4f21e6b22a1e"), null, null, "+649 33 (740) 30-23", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("4aa457e7-e143-46d3-bdef-3e9d6bb23326"), null, null, "+323 96 (684) 71-15", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("4b485f50-f5ab-4df0-9e7f-5f0e89fb7d4e"), null, null, "+872 80 (706) 09-24", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("4b548835-c022-46b1-84d4-51e9e61d3eb4"), null, null, "+565 29 (663) 43-25", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("4b95d39f-333b-4eb8-a4c9-060a581cab0f"), null, null, "+792 52 (624) 33-19", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("4d0ca611-0c15-4041-b53c-d91f3255bc46"), null, null, "+832 01 (384) 54-24", false, new Guid("0b83ed86-5e1d-4aca-a9e8-351977209ce4") },
                    { new Guid("4ef688de-77a6-45ef-b09d-637907fd69f8"), null, null, "+714 41 (541) 70-59", false, new Guid("527f7c3d-02b4-465e-8153-3472af913951") },
                    { new Guid("4fd30f1d-6c47-4895-b4b5-47188376a3a2"), null, null, "+358 15 (689) 49-36", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("4ffb5795-3388-4309-8afe-92746c168331"), null, null, "+264 35 (498) 79-52", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("50e8e2a2-2608-4a05-ba4d-cee9e4388d9b"), null, null, "+256 73 (540) 09-87", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("519df8ab-2eb2-4087-a5ee-f3151b234242"), null, null, "+340 75 (120) 70-28", false, new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2") },
                    { new Guid("51a3c309-cacd-4e4d-8fcc-c663c08c8078"), null, null, "+487 54 (827) 20-46", false, new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("51d2b489-90f8-45f1-9eaf-6f6f2285e9b0"), null, null, "+348 21 (949) 38-34", false, new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") },
                    { new Guid("51f5e931-2912-4e05-ac8c-a333beeeb1ef"), null, null, "+23 10 (919) 53-71", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("51f64e1f-ca8f-4e44-bed8-a49410b44112"), null, null, "+63 37 (185) 74-87", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("52119012-4c22-4689-a61b-64af4b439d30"), null, null, "+84 01 (051) 37-40", false, new Guid("bea13bb8-b45e-48ea-adf8-8fc36c01726e") },
                    { new Guid("5253f7f4-a2a1-4018-81b7-1da10b2f9a57"), null, null, "+603 71 (514) 23-85", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("52b8624a-2168-42bb-9d57-28129c72928f"), null, null, "+118 15 (505) 97-52", false, new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592") },
                    { new Guid("52d835a7-ebde-4fd2-8310-d694477d0416"), null, null, "+944 00 (921) 81-21", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("530e8dac-3013-4930-89a6-4aa60f2c4da3"), null, null, "+976 80 (437) 06-12", false, new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("532f1718-5f5f-488b-bb6a-b2fc36170a98"), null, null, "+421 53 (247) 45-38", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("534a4d84-37c2-4d58-8b5f-d63bb777bec5"), null, null, "+206 66 (250) 28-41", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("5402ebe5-3530-4ad2-8b21-02449bdc05a1"), null, null, "+767 31 (323) 89-71", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("5421583c-6556-4d8b-92dc-7d92e974defd"), null, null, "+268 01 (035) 09-05", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("544012a4-9ce1-47f3-aad5-f3f2ac1b5535"), null, null, "+185 45 (131) 71-99", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("54444ce2-2b3d-4a3b-8759-0f3d9e8aedb1"), null, null, "+378 00 (741) 21-33", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("54c29f36-11ba-43c1-9964-e5413e04572b"), null, null, "+662 27 (358) 24-55", false, new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799") },
                    { new Guid("5582aac3-1910-4afe-846d-5c7ed2b80d80"), null, null, "+39 50 (715) 17-80", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("5583eb57-3e6b-4d5c-a5c6-082b2a100ea4"), null, null, "+758 84 (508) 78-58", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("5611a980-0527-411d-b7e7-87e2e6d9c26b"), null, null, "+579 93 (581) 26-32", false, new Guid("f1996305-bedf-4ee8-9ad7-b7f8891a84fb") },
                    { new Guid("5614d7a9-ffb1-434c-af65-35e19ee8607d"), null, null, "+768 63 (821) 59-61", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("5658d5be-4c2e-43bf-abaa-ecc7b8e34b2a"), null, null, "+427 28 (727) 52-33", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("566080c6-98a2-4829-bd51-fa5bcf397f6d"), null, null, "+605 00 (136) 49-19", false, new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1") },
                    { new Guid("56e48a14-62c7-44c7-bdbe-33bf8f6053a4"), null, null, "+423 67 (955) 31-53", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("56e8c2ec-7986-4af6-ab63-6e62089e690a"), null, null, "+555 51 (850) 32-90", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("570a1765-e3c1-4208-9906-54dbdf349f55"), null, null, "+845 50 (493) 78-31", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("5729e94f-e388-4d9f-9d96-270e6e2fbeb6"), null, null, "+984 39 (551) 08-73", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("581eed86-d2b6-4f99-9485-ef8b433c1f29"), null, null, "+247 43 (599) 08-23", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("58ca9dcb-d624-4b59-bf81-afb097249a34"), null, null, "+637 53 (911) 18-45", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("5968b077-c556-47c2-ab3b-241b6921564f"), null, null, "+23 95 (047) 14-14", false, new Guid("94aaefbb-3b69-4a12-8609-44039863dc44") },
                    { new Guid("5ac993ed-a4e2-4559-a7ab-2e09ff8e9922"), null, null, "+160 40 (986) 33-72", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("5add3d5b-4f18-4b0b-bf86-d7484b6271c8"), null, null, "+8 10 (496) 42-42", false, new Guid("4ea29651-f292-4cbf-8413-d8821c394155") },
                    { new Guid("5b1c5941-fc9d-4065-975d-97f728552170"), null, null, "+855 60 (034) 52-60", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("5b2039de-a060-461c-8a81-2ebaabbbe036"), null, null, "+900 49 (240) 80-05", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("5b51ea0b-6643-40b4-b970-4ac283669190"), null, null, "+426 75 (196) 39-76", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("5bbee6e3-5ca2-43c1-a02f-c04f9f65e179"), null, null, "+765 82 (409) 36-80", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("5bcff8bc-f801-47c1-a59f-f01b6cf1446b"), null, null, "+393 16 (385) 55-65", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("5befed7d-d763-4dbf-a575-70f7d5f0bad5"), null, null, "+138 53 (796) 97-50", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("5bf857a8-5cea-496a-bc29-932bc2480448"), null, null, "+662 57 (616) 57-46", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("5c98479a-bf53-436f-b835-1a78b021d223"), null, null, "+579 92 (940) 59-03", false, new Guid("f0ce20d1-405a-416d-bf05-e1a86378748c") },
                    { new Guid("5ca0783a-0808-41f6-92a1-2e8b97ef39bf"), null, null, "+296 43 (095) 49-92", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("5caf0d2c-5f34-4b79-9edd-1c42bf49f46f"), null, null, "+349 87 (784) 09-90", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("5cbec9d3-5624-4fe9-a4dd-2126b9c32a18"), null, null, "+991 13 (999) 91-10", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("5ccb8f5f-797d-445e-a128-d6b2125e2e2a"), null, null, "+47 63 (139) 63-96", false, new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("5cda053b-7cad-46d4-bef1-bd492e1d67f6"), null, null, "+552 94 (919) 00-90", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("5cea8b58-924e-46fe-840c-83694125fba7"), null, null, "+676 84 (417) 45-61", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("5d281bb2-d88e-4b17-b789-779cb446ae0e"), null, null, "+679 27 (438) 48-61", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("5d671678-e610-42a9-adc7-2ab0c920d690"), null, null, "+75 62 (251) 69-79", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("5e07c394-a863-434d-bff6-6763cd52cc7a"), null, null, "+312 46 (747) 23-11", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("5e17a1c8-9c47-4c5f-a28c-df13261d7d7f"), null, null, "+950 83 (404) 53-28", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("5ec7b14b-3a84-4e72-ab9c-6999fb051e8b"), null, null, "+951 88 (586) 18-41", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("5ed1b421-2d72-4d18-9d15-2bb926f265e5"), null, null, "+160 26 (028) 71-28", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("5f1562ef-e052-4e9e-9b94-c8627c7b4371"), null, null, "+362 49 (573) 55-09", false, new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26") },
                    { new Guid("5fd37909-2124-44c9-8068-9cc1ef3e3360"), null, null, "+963 13 (364) 13-48", false, new Guid("99484890-5bb7-47f9-b211-218700e48dad") },
                    { new Guid("602525e5-a18f-4cc8-9ccf-194dec6a2fa8"), null, null, "+786 80 (663) 91-76", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("60682bb9-5149-4026-ab92-555dcf5c1f79"), null, null, "+918 99 (769) 20-00", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("6078612e-a571-409e-83b1-55975a54a5f0"), null, null, "+544 43 (618) 15-99", false, new Guid("ce1f07b6-54d9-4379-9845-3751b9499199") },
                    { new Guid("609a63d4-ceaa-4357-83ca-d8e9c5612c7b"), null, null, "+539 78 (356) 53-28", false, new Guid("f0811698-5de9-42a6-a253-8958ca513eb5") },
                    { new Guid("60f31a57-692d-4bfd-bcc0-f9ec513ab665"), null, null, "+494 72 (886) 44-76", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("60f444e0-9a3b-4324-a6cf-f2972ce85f19"), null, null, "+151 06 (605) 80-86", false, new Guid("cc2503d2-d6ee-4611-988a-1b08e90ff2c5") },
                    { new Guid("618044cc-5c6b-4adb-be24-96e36874897b"), null, null, "+6 10 (160) 59-51", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("618f22fe-f181-4a93-b98b-dd09c865b3fa"), null, null, "+668 27 (798) 18-22", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("62023461-e646-4a5d-b33d-6afde931fa3d"), null, null, "+869 17 (990) 29-12", false, new Guid("eee52bcd-f98f-4405-9c91-ce452c5e2e0f") },
                    { new Guid("6248c21c-bb43-47c6-97ad-1abed394f9dd"), null, null, "+958 98 (063) 79-59", false, new Guid("ca9b719c-35f6-479d-a975-e2d63da1a228") },
                    { new Guid("62880bb3-a449-4911-aff0-9cd95c51e973"), null, null, "+546 21 (796) 72-62", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("628aefc1-fb20-4a56-a796-2cfc7fb7cbc6"), null, null, "+513 38 (580) 24-99", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("62c86247-3b1d-490a-8d4a-613c4769833d"), null, null, "+765 72 (333) 04-95", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("630e7159-90fc-48d0-bb2e-aad8403f2137"), null, null, "+446 29 (161) 01-45", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("633c980f-7228-4c44-afd9-bd5aad6a9ebc"), null, null, "+924 75 (228) 99-96", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("63735408-7050-4a98-8f07-a70481518f58"), null, null, "+263 26 (067) 17-15", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("63c337fa-1a37-4eea-9ea6-974d96bebd31"), null, null, "+721 74 (443) 80-48", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("64206dd6-4268-44e3-9428-c71512a07fce"), null, null, "+191 44 (119) 71-19", false, new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7") },
                    { new Guid("644c1b7f-cbfb-423a-9cf3-2d6ad81f51bd"), null, null, "+855 41 (735) 91-17", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("6488709a-58a4-413a-aa4d-872f026af8f1"), null, null, "+818 55 (063) 76-79", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("65092e44-b504-4584-9767-f639384fa0d9"), null, null, "+420 87 (831) 13-57", false, new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6") },
                    { new Guid("65663d8a-a764-41b8-9dbd-c7ff4ec93aa3"), null, null, "+885 70 (606) 70-66", false, new Guid("49087f50-2ee6-4e33-b79c-c4cde6a95db1") },
                    { new Guid("656d618b-a552-4105-bfbb-580dee24248b"), null, null, "+834 03 (981) 96-80", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("65c2994a-226f-4761-b908-98b09f406079"), null, null, "+601 43 (967) 34-28", false, new Guid("bfc1e5bf-bebd-4f20-94d1-ec56d99fdab6") },
                    { new Guid("6616b34c-bd4e-4f08-930f-84056f8840a2"), null, null, "+383 08 (104) 52-44", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("669b4dbb-1bcb-4162-865e-225c331bd310"), null, null, "+122 56 (969) 43-69", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("66f82a02-6fa3-423b-9cf5-aeb50e97ba92"), null, null, "+369 95 (197) 61-34", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("66f8b5ca-e1fb-47c8-ae91-c4863a3ea4e6"), null, null, "+989 70 (078) 60-89", false, new Guid("58b959a4-3cb8-49bc-a00f-e4613f7557b8") },
                    { new Guid("6720e132-489c-4a3f-8279-f2f77927be39"), null, null, "+197 70 (317) 60-80", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("6732b322-ff2b-4fcc-bcaa-2ce6683d7b67"), null, null, "+582 11 (964) 59-57", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("676e75ce-3a46-471e-b539-97d78fbc3c3c"), null, null, "+778 28 (068) 14-34", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("682bae63-575b-44ac-916b-cf8ddc2f76b2"), null, null, "+830 84 (327) 97-18", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("683428d5-fa4d-410e-af68-85aee10ad4eb"), null, null, "+366 08 (536) 59-20", false, new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca") },
                    { new Guid("68c8822a-9f87-4a2b-a557-16873a63b8fe"), null, null, "+824 34 (883) 90-68", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("6901cb04-1491-4826-a5d5-24f79e5e4f01"), null, null, "+199 57 (206) 96-99", false, new Guid("89cf5cc8-80ee-44b4-95aa-8a292b77cfe8") },
                    { new Guid("69735c9c-fde0-4806-b360-3f7f1386906d"), null, null, "+980 83 (208) 64-51", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("697b80b3-8a93-434d-8420-678876130144"), null, null, "+642 39 (147) 24-34", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("69e7dbef-4c54-492a-a9ba-cd3750450545"), null, null, "+744 85 (323) 16-16", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("69fa9c05-2bd9-4888-be96-fbb1e9734b9d"), null, null, "+579 51 (920) 78-27", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("6b15dbf3-a668-4331-9c44-053ee19d617a"), null, null, "+845 24 (661) 94-39", false, new Guid("b088985a-72ff-4e1f-84e4-b3576ae6e0f1") },
                    { new Guid("6bb087ef-1745-4c80-9bbd-317a78669303"), null, null, "+251 19 (093) 67-66", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("6bc0b3a3-efc2-4091-9279-b54141adff2f"), null, null, "+286 87 (355) 17-91", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("6bfc78c1-3b25-419e-b62b-9b8b5c1ddccd"), null, null, "+62 84 (324) 03-04", false, new Guid("5ffc49e2-50fb-41f2-8784-192077f86010") },
                    { new Guid("6c3df04e-7fc5-4b63-85e3-91b02b01f8ec"), null, null, "+230 46 (393) 33-37", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("6c6cb372-21f1-4496-815d-079f978b821e"), null, null, "+251 69 (274) 45-20", false, new Guid("f69d15ea-e2f5-4989-a662-bb7f4a46b9f6") },
                    { new Guid("6ccb40ed-736c-4026-93c8-1a63fc959313"), null, null, "+868 93 (629) 55-04", false, new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c") },
                    { new Guid("6cdc6a12-209f-4553-b231-a7db7941d070"), null, null, "+401 46 (759) 87-94", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("6cedf831-07ab-4148-9cf8-f9c5b01f1bfd"), null, null, "+981 81 (282) 95-61", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("6cff8118-a8de-40c4-a051-b66b2bef7c6e"), null, null, "+386 98 (520) 15-10", false, new Guid("862a826f-0eba-4891-9241-dff3a8896969") },
                    { new Guid("6d005193-2959-4a86-9000-61591b5ee482"), null, null, "+912 40 (473) 94-86", false, new Guid("f9447aea-75fd-4ed1-86d5-aea894695f89") },
                    { new Guid("6d273a75-d2a7-4cbb-ac0d-b8811d977a7a"), null, null, "+554 31 (625) 13-31", false, new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500") },
                    { new Guid("6e40cd97-37a1-4803-9967-684481852c6d"), null, null, "+899 11 (812) 20-94", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("6f03373c-3fb9-4c04-ae90-520444bcd700"), null, null, "+361 95 (130) 86-32", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") },
                    { new Guid("6f3d0b62-8e28-4014-8eee-58f19a1d534b"), null, null, "+645 30 (655) 89-73", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("6f4296c9-5919-486a-b59e-5846f08075e8"), null, null, "+748 48 (108) 99-78", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("6f8c0842-9cf0-464b-b12a-1e3c74243a32"), null, null, "+655 09 (391) 02-40", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("6f9da5a2-d045-434d-a287-07095f4c87dc"), null, null, "+640 03 (955) 57-61", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("6fc9eb72-c589-479b-95be-692276b60fb1"), null, null, "+114 07 (708) 68-93", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("6ffae889-c49d-4dd9-bbc2-43f6fb274584"), null, null, "+390 93 (164) 66-31", false, new Guid("6aee0a4b-5c93-4a05-9075-0c8a7dd79942") },
                    { new Guid("70953751-4489-4aa6-84b0-f87a41826c21"), null, null, "+226 38 (340) 70-36", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("716b355d-8c04-4cfd-b565-f919308c5ccd"), null, null, "+92 00 (371) 04-00", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("716badc8-d25e-4d1f-a5a6-909c7dfc4103"), null, null, "+649 46 (206) 25-26", false, new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") },
                    { new Guid("71a13b9c-6147-4c10-baf0-5cdfe8468706"), null, null, "+473 55 (793) 05-96", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("71d87c3f-4539-4c59-9b0d-ce7de179c4c0"), null, null, "+996 33 (569) 31-19", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("71f4fee9-bbba-4a86-af14-cf3d75269961"), null, null, "+217 60 (631) 58-29", false, new Guid("db70630e-a542-4e46-b0b7-db5b5c3cdbca") },
                    { new Guid("72182420-835a-4f82-ba57-14ab17c0dafb"), null, null, "+744 23 (193) 96-62", false, new Guid("43a79d17-6c7f-4919-8fc7-806f34234239") },
                    { new Guid("7273a8a4-dd01-46b4-aabf-c14a0afc5bd3"), null, null, "+184 62 (377) 83-00", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("735ccd99-f1f1-4909-a5f6-9afd8d84920c"), null, null, "+206 79 (311) 40-65", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("7396a29f-c824-4f79-921f-be3450944131"), null, null, "+645 98 (757) 03-54", false, new Guid("5473aa20-5600-4dc5-a173-b889ecd5b783") },
                    { new Guid("73ec362d-ea3d-403e-89e5-0af14ef0bb37"), null, null, "+705 93 (649) 17-87", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("74714a2b-e991-4c4b-a7ff-cbaedc56664d"), null, null, "+505 09 (053) 37-87", false, new Guid("100fb35d-720a-45eb-80c0-3114ce3f0af5") },
                    { new Guid("756ce048-523d-4fe6-8867-37dd2864bcda"), null, null, "+290 43 (278) 46-84", false, new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a") },
                    { new Guid("75adec9f-5b4a-4eac-814f-eac635e23c0d"), null, null, "+602 58 (786) 30-63", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("76254def-0bb3-435e-a05a-9f73eb251fbb"), null, null, "+587 90 (539) 99-78", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7640ca5d-af0c-46bd-82c7-e10cff8c4f9c"), null, null, "+79 14 (110) 63-66", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("766bded6-c79c-4745-a12e-aa678d26e6db"), null, null, "+62 33 (570) 76-50", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("76cc6ae8-2f06-45d6-9c02-48a7211eeefd"), null, null, "+894 73 (116) 67-03", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("773529cd-5725-4850-bba9-48601febfbd8"), null, null, "+301 76 (239) 53-82", false, new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291") },
                    { new Guid("7748480c-c433-4fdb-97b8-2956ad2d7854"), null, null, "+992 07 (068) 87-63", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("776db716-3d38-4591-9317-582984182000"), null, null, "+639 34 (394) 63-78", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("77c5f686-279a-44a6-ac82-bf35c688991b"), null, null, "+523 65 (495) 26-15", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("77cc2fab-f2a1-4e22-b764-f9fe784a1fea"), null, null, "+228 73 (077) 48-26", false, new Guid("77f944f9-c758-4983-b702-656640bf5672") },
                    { new Guid("77e107aa-31b6-4f3a-8e03-b60af247db78"), null, null, "+990 36 (643) 17-81", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("77e12996-2026-4b9b-9d84-27916bfc59ae"), null, null, "+991 47 (692) 70-57", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("78236883-20e9-4551-bf13-fb55362a5753"), null, null, "+825 31 (416) 36-68", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("78486ad8-5b7c-472d-8f75-b3ff8ca6b9af"), null, null, "+632 52 (460) 62-27", false, new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420") },
                    { new Guid("78a2ee83-a133-4ba3-88da-3a948e7c6d2b"), null, null, "+259 32 (390) 86-16", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("78d0b58a-135e-444d-b22c-9b33a06c1df5"), null, null, "+274 61 (175) 31-96", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("78e42fff-d47c-44fe-8a86-f6fa938f0dbf"), null, null, "+811 73 (234) 77-30", false, new Guid("ca970d21-00f3-4a91-b445-a07dd8caeca4") },
                    { new Guid("791895aa-cbbf-4e9c-9423-042603071024"), null, null, "+884 65 (990) 67-64", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("7945ed53-9b37-487a-b1da-027eba60530f"), null, null, "+237 25 (668) 43-07", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("7949afdc-67e2-4df7-84d2-cb5e0530e6ca"), null, null, "+71 45 (796) 65-93", false, new Guid("4fde002a-ab64-405c-bb95-313bef89420b") },
                    { new Guid("79c3a4e2-a639-400f-b223-aa216254f8bd"), null, null, "+367 65 (715) 75-47", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("79da64ca-a3d8-417b-9f4b-fda61e1e0cfc"), null, null, "+513 32 (497) 66-92", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("7a26b617-289b-4f27-bffd-6014bc20ecd5"), null, null, "+323 48 (661) 92-80", false, new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594") },
                    { new Guid("7a4a3311-1f1a-4de3-ab79-62db777fc2c0"), null, null, "+923 01 (366) 48-37", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("7a547334-59a1-4bf2-9228-e8188a886e66"), null, null, "+579 73 (011) 51-30", false, new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc") },
                    { new Guid("7ab6101d-b249-49d3-8137-ee8ed2672376"), null, null, "+85 65 (452) 61-17", false, new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470") },
                    { new Guid("7ac7d9b7-fae9-4c24-8701-4fd1d55eedb9"), null, null, "+98 84 (952) 11-76", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("7af2218a-d9b8-4138-bbdc-34b7b79bff86"), null, null, "+642 60 (274) 81-23", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("7b2904be-1c74-4342-b4f7-69cc7f2c15b7"), null, null, "+978 03 (955) 88-93", false, new Guid("a17ee777-6775-4936-8d6a-37ccdcd601c1") },
                    { new Guid("7b31cd44-da90-4d01-af36-df85ed2bb27c"), null, null, "+320 25 (548) 92-05", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("7b57f069-63af-40be-992b-a6408b8e1680"), null, null, "+43 51 (965) 68-72", false, new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353") },
                    { new Guid("7b7b0d84-4cbf-4aeb-9d04-e7439712c42c"), null, null, "+907 31 (799) 52-37", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("7bbe012d-dd1f-406f-bfaf-95c4143e546d"), null, null, "+770 67 (873) 61-86", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("7c92c7b9-1135-4a78-90e5-c5cbdc5d3d83"), null, null, "+514 89 (915) 84-57", false, new Guid("1154048c-cc8b-409f-a802-5dbe51d20548") },
                    { new Guid("7ca1c946-2aec-425e-a2be-5031fae38b0a"), null, null, "+604 64 (818) 22-20", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("7cb1bf02-1798-4503-b46a-fded51a5493e"), null, null, "+271 98 (570) 29-82", false, new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731") },
                    { new Guid("7cdbbb80-9267-49fe-baf3-1c9f01a20293"), null, null, "+556 52 (100) 96-59", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("7ce7a0aa-494f-4c60-af21-a65dc7e70989"), null, null, "+702 81 (089) 64-02", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("7d1f0e14-2b24-4b3e-8bc1-519f08fc9c9a"), null, null, "+111 21 (648) 48-05", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("7d2bf22b-c966-4cd4-946a-3741d6581406"), null, null, "+646 11 (907) 31-04", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("7d54ae61-2b76-4ba5-94ac-0c13ec5fc031"), null, null, "+522 31 (109) 62-68", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("7d54e44c-ff49-49e5-ac7c-a7622862140f"), null, null, "+956 86 (364) 53-69", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("7d5f63b6-1d82-488b-bd31-06fa7558a4e1"), null, null, "+75 58 (297) 92-96", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("7d80c49b-75c1-471e-9f1e-c9de20733ee8"), null, null, "+527 01 (159) 08-12", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7dc3929f-4403-4479-8325-0273e536a21d"), null, null, "+599 57 (398) 74-09", false, new Guid("1154048c-cc8b-409f-a802-5dbe51d20548") },
                    { new Guid("7dd7863e-fb93-40e7-8168-a0df2db3449c"), null, null, "+354 70 (832) 99-98", false, new Guid("5d569721-45f7-4a9f-9baf-c46b1d3c8500") },
                    { new Guid("7e2df98a-cb41-4821-aa45-84576cfe718c"), null, null, "+564 91 (350) 34-73", false, new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748") },
                    { new Guid("7e5792e5-252e-4445-9bf6-e73100d685f0"), null, null, "+21 57 (348) 25-44", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("7e9bb048-2c42-4b49-8aca-fed0b57ecb61"), null, null, "+999 67 (400) 54-14", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("7ea0708f-9008-4923-8e70-bdf7e02df7dc"), null, null, "+858 63 (810) 67-70", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("7eabbbce-36e1-4896-a4e2-3422b7d3d4df"), null, null, "+483 78 (878) 32-60", false, new Guid("563f53c7-7654-4215-88fc-eff6cf413754") },
                    { new Guid("7ecc0320-d8a3-40a0-a211-442e887db6b9"), null, null, "+296 78 (036) 30-14", false, new Guid("30b2066d-f465-42ae-93e3-4a38936052b2") },
                    { new Guid("7f771b0a-e6b9-4dae-a744-709af975e883"), null, null, "+914 99 (658) 53-87", false, new Guid("2959f8d4-4315-43a9-a512-f55673e26ba6") },
                    { new Guid("7fddbf77-d8b4-4bc0-8ab8-599e2c3d3779"), null, null, "+110 56 (262) 81-72", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("800f0f68-f90a-4500-9498-fc9f7dc59f2a"), null, null, "+158 96 (469) 11-51", false, new Guid("c665640c-ca33-4d98-b9f6-0cc275f09ea8") },
                    { new Guid("80cf51c4-126b-4110-bc50-56d95261ee34"), null, null, "+995 14 (446) 54-05", false, new Guid("2f8b3c81-3d71-446e-aac9-ef2000d7ce73") },
                    { new Guid("814305cd-79ff-4ec3-837e-0359c4f62a4f"), null, null, "+661 13 (203) 31-03", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("814c2737-2f33-4e7d-8c15-9756cd83479b"), null, null, "+623 84 (160) 24-23", false, new Guid("84604b83-cbfa-4034-b1d2-974d0de9cfee") },
                    { new Guid("81d1e211-985b-41e9-b78d-e4d4089802d7"), null, null, "+857 87 (372) 37-60", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("81e19d21-31ba-40c5-ba04-07fba74bb74b"), null, null, "+638 68 (624) 80-31", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("81e5c73a-603d-420c-b76b-df065df687cf"), null, null, "+880 93 (423) 66-50", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("821c34f2-257b-44b7-982a-14024a8c7eb5"), null, null, "+579 42 (337) 69-98", false, new Guid("0730df90-ed9c-4785-b51d-6eb66c9b1024") },
                    { new Guid("8265efa5-008b-4820-8a93-929cc08752eb"), null, null, "+836 49 (187) 90-78", false, new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04") },
                    { new Guid("82aef2ca-0542-4306-b753-a0b379cbdc1e"), null, null, "+31 98 (324) 31-67", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("82b221db-fc6a-4d0c-a077-ee601974a154"), null, null, "+129 26 (353) 05-31", false, new Guid("fb455a22-8198-413a-89a8-e92c01f42483") },
                    { new Guid("83c59357-2d8e-41ce-bb1d-0363a6fca157"), null, null, "+123 24 (677) 08-75", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("83c665dd-d069-4cca-8dbe-afe1da06587f"), null, null, "+283 60 (435) 19-46", false, new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee") },
                    { new Guid("83d897bb-0702-4bf2-84bc-009b05f7770e"), null, null, "+298 97 (324) 68-42", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("8407bfbc-5db1-4981-8358-258228affefe"), null, null, "+899 78 (111) 60-86", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("849e51ec-9cfc-4592-b621-f59cfe4a335e"), null, null, "+875 28 (278) 84-13", false, new Guid("0cd05e0c-29c1-4592-a13d-a60c2b367b14") },
                    { new Guid("84c81d04-614b-4fcb-9fdb-e7d530300ef6"), null, null, "+667 92 (613) 49-97", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("85d8b367-32ec-4bff-b643-b2fbbf97f173"), null, null, "+591 72 (931) 46-81", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("86118eed-179a-40db-916d-a9ba6a3c61f0"), null, null, "+494 38 (134) 40-72", false, new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("869ed960-f604-4845-a98a-2734999f5767"), null, null, "+192 63 (889) 55-16", false, new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa") },
                    { new Guid("86ea27d2-ec51-4fde-93e1-0949a51e0e17"), null, null, "+667 52 (145) 62-38", false, new Guid("570ffeeb-614c-4c2b-b17d-c6d3a5071fb7") },
                    { new Guid("871d7a25-7237-4c96-be24-1595587b56ca"), null, null, "+699 56 (651) 75-84", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("8740a965-9bcd-46d7-a8bc-6121e063337f"), null, null, "+326 60 (577) 03-85", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("8756e546-3cc9-4b26-95b1-1448c1e0882f"), null, null, "+576 29 (416) 22-52", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("87b985ef-2888-4658-a091-42545e1bb0e2"), null, null, "+812 25 (661) 64-72", false, new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5") },
                    { new Guid("87f27882-9c35-4909-80e7-41cad9da6723"), null, null, "+656 86 (475) 15-54", false, new Guid("95c5c49a-56b6-430a-be1c-4fad0ca0dff9") },
                    { new Guid("8801644b-fe0e-4543-80fa-1e2c5f7ab0d7"), null, null, "+538 01 (218) 89-40", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("88a40258-5211-4772-b7af-f0a5b68d5649"), null, null, "+485 00 (742) 02-77", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("88cd1901-5fc5-49d5-b0f6-f182bc2ee378"), null, null, "+452 45 (807) 71-51", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("89022bcc-958d-4045-9956-ab818ca8c20d"), null, null, "+474 53 (474) 70-13", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("89b5287c-f150-44ab-88a9-d55ce788b26c"), null, null, "+961 53 (465) 54-65", false, new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018") },
                    { new Guid("89b8abe8-e991-4cfb-a106-413b57a9e547"), null, null, "+688 81 (965) 97-63", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("8a2b94b0-f35c-4ee3-9bac-feebaf390032"), null, null, "+335 76 (804) 50-64", false, new Guid("6886670d-8004-42e6-9a4e-8b3729e3e5af") },
                    { new Guid("8a6d76df-9402-4f58-883c-14d4f302316f"), null, null, "+78 53 (904) 68-93", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("8b027662-055d-4303-a567-840a4c56d1d3"), null, null, "+661 59 (911) 53-00", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("8b411f3e-aed7-4cca-82e9-80cde3cb924d"), null, null, "+632 42 (268) 79-93", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("8b41528c-b6d4-49a7-8ab8-12b82aecf551"), null, null, "+38 14 (036) 26-56", false, new Guid("05e67d2e-e1bd-4344-adfb-afeac4fbc5d2") },
                    { new Guid("8bb1a57b-a162-4e6f-8398-741e7bd41f37"), null, null, "+367 22 (520) 91-87", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("8bcc09f1-9a68-46b0-9cf4-b72d792f9f21"), null, null, "+62 15 (352) 58-23", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") },
                    { new Guid("8bf08d9a-329d-4f0c-913a-30da68dec8c0"), null, null, "+523 51 (006) 23-70", false, new Guid("88fbd469-d541-4e89-9736-988ca894e0e8") },
                    { new Guid("8c3ab3ad-401a-43af-be2f-d659bc096b40"), null, null, "+443 87 (810) 57-54", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("8ca68c51-a9db-4d5a-982d-aa83fab09f2a"), null, null, "+544 42 (170) 71-19", false, new Guid("481b5666-d37b-4a2e-b326-f1ac06649f3c") },
                    { new Guid("8cd53778-f07a-40ac-b95c-f0ca74d365a7"), null, null, "+420 07 (770) 80-77", false, new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64") },
                    { new Guid("8ce92a86-2088-4a36-8876-413138163d15"), null, null, "+936 98 (482) 65-97", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("8d31855b-3531-4b7e-9a9b-e350b8c6d254"), null, null, "+145 24 (234) 92-55", false, new Guid("79c54043-c7f1-48dc-83ba-964ca9f54138") },
                    { new Guid("8df1d57c-f4a9-4e8f-9d04-96b3645e6828"), null, null, "+279 12 (100) 20-91", false, new Guid("c255a261-8bc7-41ba-9419-99ca6b26ab8f") },
                    { new Guid("8e451dc8-a3ec-4d23-9411-241c85ffecd2"), null, null, "+28 24 (154) 47-18", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("8e4db287-1ab8-4409-80f0-0e9fd124d0a0"), null, null, "+330 50 (734) 63-32", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("8ec711e2-0d2f-44c9-aac6-b82d23a55d6a"), null, null, "+455 39 (838) 64-14", false, new Guid("3ecc7c3a-7275-470c-a4ab-7d87e011b291") },
                    { new Guid("8f0abb5a-4b00-49ab-8522-64e80f689a06"), null, null, "+582 66 (961) 09-93", false, new Guid("b10c4b2b-67da-4e3c-b943-7a188c78b614") },
                    { new Guid("8f953a92-8d07-4ed1-9146-757cfd01d06c"), null, null, "+964 57 (524) 63-97", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") },
                    { new Guid("902fecf1-5453-4a9c-8aa9-450b5f599ef2"), null, null, "+362 52 (166) 70-75", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("90365a88-3472-4434-bbff-e707331dec7c"), null, null, "+244 43 (040) 09-96", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("90cbf874-f2a2-41e9-be74-40ff3d7f17ba"), null, null, "+653 35 (869) 02-56", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("90d67581-7c4d-448e-bd60-b53d5c586479"), null, null, "+142 67 (217) 07-49", false, new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("9150e395-acff-4a3f-a33d-80b0824339cb"), null, null, "+11 94 (491) 65-48", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("91e0cb52-5754-41e2-b8eb-e222fab00014"), null, null, "+292 14 (221) 42-21", false, new Guid("97fd604a-eb78-4e29-829c-caf68b162e92") },
                    { new Guid("929a67bc-5ee7-475f-8eb7-a458c100a579"), null, null, "+498 54 (418) 21-36", false, new Guid("1df098ee-cc1f-4233-b0fb-45b2ea6f4098") },
                    { new Guid("92cc565b-b0a0-4017-b590-9dfd64061176"), null, null, "+165 93 (195) 94-12", false, new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba") },
                    { new Guid("92fe8a80-26cf-429c-8968-c1d9d1ba687f"), null, null, "+631 01 (054) 44-83", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("937ffd75-7c72-49a4-a160-e96d02f32be5"), null, null, "+296 36 (242) 79-73", false, new Guid("e51c2bcd-4a45-4b09-ab41-0ca239ef49fc") },
                    { new Guid("93ce6b1f-9cf8-42f3-b65a-9fd2d716a94d"), null, null, "+1 27 (274) 11-38", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("9546c1d9-45f5-44e0-a193-1952c13e51bd"), null, null, "+368 63 (605) 07-96", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("962541a4-0865-48ee-97d9-826767f6ed6d"), null, null, "+549 28 (296) 87-26", false, new Guid("53a7a51e-d382-4050-82a5-f33ab7641603") },
                    { new Guid("96b9dbfb-f430-4796-981e-e38ccb238674"), null, null, "+391 38 (471) 13-57", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("96f39cd8-b0b7-4c2f-ab46-a3eeaa4e38ae"), null, null, "+400 21 (429) 29-69", false, new Guid("41008513-ca62-4168-8bcd-a3f4384fd325") },
                    { new Guid("9764b7a6-147d-4ea2-b382-6e8945d1b75a"), null, null, "+877 22 (696) 35-51", false, new Guid("5db08daf-eab2-4e80-94a6-a8c438405b63") },
                    { new Guid("97787247-f777-4ddd-a442-9cd83c93a155"), null, null, "+187 60 (871) 17-71", false, new Guid("f0811698-5de9-42a6-a253-8958ca513eb5") },
                    { new Guid("9798d94a-adbb-4dd8-a296-e5d94a198b65"), null, null, "+16 44 (956) 40-59", false, new Guid("7a944923-89e8-4f75-9582-9a1111c3aec9") },
                    { new Guid("97a36b8b-ca56-4161-a59a-5adbf9d25eb7"), null, null, "+619 94 (296) 87-49", false, new Guid("c5f6bdba-1da9-4ce9-b85e-8e032d732ad1") },
                    { new Guid("98051a31-3e47-4a73-b074-407d35b19a0f"), null, null, "+881 87 (903) 45-16", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("98bd7a3c-74c3-4c53-83c0-05af66c739a0"), null, null, "+721 88 (883) 92-68", false, new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae") },
                    { new Guid("990c5fc3-8d7b-4ce3-aa98-265c6a8137c4"), null, null, "+912 21 (178) 09-93", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("9943366b-ba95-47ae-8730-396c6667ff8d"), null, null, "+742 45 (018) 94-53", false, new Guid("748062f3-9c55-4b5c-9d17-429dac03b923") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("999e03e1-a48a-4c6f-b6c7-a3be80161cd7"), null, null, "+967 89 (337) 31-37", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("9a0598da-523c-4dff-b375-72467661f927"), null, null, "+209 78 (134) 06-98", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("9a36759f-00bc-495a-ba14-07df3341b016"), null, null, "+861 23 (893) 22-87", false, new Guid("78016c36-672a-4efd-980e-250a79e4d32e") },
                    { new Guid("9a502141-8dac-4e21-9dd4-49c05070a6e1"), null, null, "+721 92 (480) 06-44", false, new Guid("0fc290d6-e2b2-42c4-8d1e-c568e772d6bf") },
                    { new Guid("9a603ddb-ac34-41aa-9ae5-60ae66677d6a"), null, null, "+840 28 (044) 88-36", false, new Guid("8905b747-db92-42c9-8385-1d49f6b8e578") },
                    { new Guid("9a876d1d-8a4f-46a2-8d08-8651eed3efe7"), null, null, "+885 50 (945) 01-44", false, new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d") },
                    { new Guid("9b0da0e6-7bec-4eba-954f-2d42c60f5eea"), null, null, "+674 22 (802) 79-87", false, new Guid("3e1827bb-2cfc-4263-be79-7b663816638e") },
                    { new Guid("9b32027b-9ef4-49d5-83a1-37171fcef306"), null, null, "+697 38 (007) 63-56", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("9c10a53d-a6c6-407c-88d1-f0120ec88274"), null, null, "+141 46 (633) 91-91", false, new Guid("ad9b5cf2-70cc-4675-a1cb-8103a0688420") },
                    { new Guid("9c1204f4-f727-4ac6-8d1d-941d9f42ee4c"), null, null, "+312 26 (434) 45-59", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("9c651cac-d69f-4dc3-95c8-64512b349505"), null, null, "+608 92 (159) 50-95", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("9cd4268b-7507-46d4-9ad3-c0776d964f4f"), null, null, "+742 05 (857) 00-06", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("9cf0a2ac-03be-447c-8ae0-e4e84ee4ecd8"), null, null, "+862 42 (968) 56-01", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("9da77668-675b-4bd5-bb88-31fa63d4896f"), null, null, "+947 92 (662) 52-96", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("9ddd9bce-62eb-47e3-95c7-cba14c122a95"), null, null, "+368 23 (564) 20-48", false, new Guid("3dae95ef-6c78-4f71-875d-0977eabe87b0") },
                    { new Guid("9e02be8b-ec56-403f-9be5-4824ac758a14"), null, null, "+184 82 (666) 56-01", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("9e0c0c56-f690-4af6-9f21-73c12caa302d"), null, null, "+830 74 (922) 11-14", false, new Guid("e6cf8c90-f10b-4d87-bc7a-a85c93131594") },
                    { new Guid("9e3def0a-568f-44d0-8c9d-48c915549a28"), null, null, "+814 30 (738) 71-78", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("9ea5b1bc-4f05-4342-84c4-e143d29b8ad1"), null, null, "+215 89 (016) 89-69", false, new Guid("d25d2ce8-62a1-405c-8606-dec7c126faae") },
                    { new Guid("9ea5c6fb-f06c-43b3-89f0-6821b561e134"), null, null, "+748 41 (367) 92-93", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("9f0f8f7a-7d4f-4a72-bea0-bf9bc5a8d14c"), null, null, "+176 14 (580) 41-27", false, new Guid("527f7c3d-02b4-465e-8153-3472af913951") },
                    { new Guid("9f527034-b687-42ab-8ecf-1b26d99b2ec0"), null, null, "+808 62 (240) 13-90", false, new Guid("8a6cd4ba-0b99-4926-b792-0b7bf869ef64") },
                    { new Guid("a018c112-3ffd-48af-bf7d-e805378fe1bf"), null, null, "+379 08 (712) 13-91", false, new Guid("99774ffa-17b3-4c52-b10a-c1331b7810d2") },
                    { new Guid("a043243f-d048-4bdb-9ccc-1f838ebe8510"), null, null, "+277 77 (170) 59-21", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("a0881fce-2775-4c44-9fc1-a78c6f369590"), null, null, "+869 43 (573) 92-93", false, new Guid("8dfa1f14-c8d1-4d6e-bc65-59db71370334") },
                    { new Guid("a08ab6a8-e906-4120-a101-42cf23bb8554"), null, null, "+719 59 (657) 34-89", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("a0a74d16-cd7b-4349-ad97-c9b4545f31a9"), null, null, "+91 81 (322) 85-93", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("a0b57284-fcc9-4abd-8881-b782f9b4aa2e"), null, null, "+792 15 (464) 31-07", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("a0f41d16-2cc4-4f3a-ac90-f1d3cbcf89aa"), null, null, "+912 78 (672) 86-61", false, new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("a15dd575-c991-41ff-af12-4e2aa1141882"), null, null, "+46 93 (066) 99-71", false, new Guid("cc9fd67a-df81-4c57-9231-20a528617118") },
                    { new Guid("a16aca77-8f6a-40ef-a2c8-bf0273afc884"), null, null, "+165 69 (010) 78-60", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("a16c664b-574a-4087-9b56-4362a766a4ec"), null, null, "+248 37 (229) 94-44", false, new Guid("2de132d0-d6b1-47fa-8d51-678ee2c54767") },
                    { new Guid("a1b5e061-b895-4d22-84f2-9d9bd4454a54"), null, null, "+862 95 (245) 42-68", false, new Guid("52f24d75-fa03-403f-8430-5ca835f68726") },
                    { new Guid("a1fae9f7-d915-425c-9c16-afc9099ef6ea"), null, null, "+309 54 (745) 48-16", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("a24a244d-a745-4734-bbba-cdb376d96537"), null, null, "+869 06 (916) 24-12", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") },
                    { new Guid("a2d0cfb8-8027-4559-881a-33cf31d34afc"), null, null, "+184 45 (333) 90-80", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("a2d1a5d6-32e4-48b5-a5cc-fc3bdc902637"), null, null, "+160 54 (947) 68-05", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("a2d2e3fb-32e7-4a8c-8bb8-f9a5703fecc8"), null, null, "+797 35 (451) 20-39", false, new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("a2f14f50-4ca6-4b5a-b90f-61f67c82e36f"), null, null, "+917 35 (505) 16-42", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("a34c6ac6-30e2-427a-bff3-9ee01942d6ea"), null, null, "+548 30 (395) 26-96", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("a362c375-a96e-48f7-993f-b6e1ba85c874"), null, null, "+40 40 (155) 99-84", false, new Guid("8905b747-db92-42c9-8385-1d49f6b8e578") },
                    { new Guid("a3852547-f5dc-4938-8ea3-8826203defa2"), null, null, "+120 51 (646) 09-71", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a3e20738-2906-43b5-8172-ad90e9cca839"), null, null, "+640 83 (732) 62-21", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("a5082b92-ef60-49ad-b273-1f94189e4efe"), null, null, "+580 55 (166) 95-87", false, new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc") },
                    { new Guid("a5260959-3e35-4d44-939d-da1dd8a901ee"), null, null, "+239 84 (690) 31-23", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("a5d96455-8b19-4125-a3ec-96700f9dde0a"), null, null, "+325 01 (548) 38-50", false, new Guid("33cc8f50-c6dd-40cb-8264-c9b3bab15592") },
                    { new Guid("a5e11108-5ab0-48bd-a4f4-f04b0d5d0128"), null, null, "+172 86 (936) 69-71", false, new Guid("4f03daca-02fb-425a-a575-bef52173e4d3") },
                    { new Guid("a65f1e51-27da-4d5c-8c49-a7f86d8d4652"), null, null, "+728 68 (600) 98-31", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("a6677d4c-37d7-42dd-a133-5bbb0ba41e9d"), null, null, "+334 47 (368) 23-84", false, new Guid("64bc7fd4-a41b-4837-b732-4a286af113e9") },
                    { new Guid("a7055a99-94ab-40bd-9015-90f38812366a"), null, null, "+750 93 (196) 61-91", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("a71aa6cf-783e-4705-b340-fbe0d61a0d7c"), null, null, "+758 36 (821) 16-43", false, new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("a7aa0b2c-1c4d-45b3-b427-d5d25f8be66a"), null, null, "+888 67 (126) 44-62", false, new Guid("3f75d001-97a7-4520-b3a1-15f824f492c6") },
                    { new Guid("a7c4d363-c392-42fb-bfc1-1cac03bb9f75"), null, null, "+319 47 (200) 32-05", false, new Guid("43a79d17-6c7f-4919-8fc7-806f34234239") },
                    { new Guid("a7f6ab9d-7b40-4e6a-a03a-082a323cae38"), null, null, "+412 46 (600) 75-97", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("a803939e-0ab6-4409-9f2b-0c12f928d151"), null, null, "+143 82 (565) 10-94", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("a84c7f0f-b537-44fb-971c-7ee14ae8bef3"), null, null, "+582 40 (418) 85-74", false, new Guid("0f9851be-b682-479e-aec8-51795a73a90e") },
                    { new Guid("a85b0026-db27-413c-8bb6-5ac391c15748"), null, null, "+636 54 (110) 20-98", false, new Guid("3a07b706-34b5-445c-8077-df7a27e9ca1d") },
                    { new Guid("a86f0df9-f851-4b1a-8c78-18d730074f94"), null, null, "+784 80 (880) 31-65", false, new Guid("14616263-d2fa-48db-a24a-d892043c3e33") },
                    { new Guid("a8d8fca6-e605-4d61-be6e-67808cd81df3"), null, null, "+366 17 (853) 27-74", false, new Guid("0f2e8aa4-4f00-45f2-98e4-863fa87a4f04") },
                    { new Guid("a9930f80-2554-49f0-8298-faf19e058df3"), null, null, "+787 68 (242) 90-62", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("a9cce642-827a-4e86-8b06-80babecd41a2"), null, null, "+685 91 (624) 87-00", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("a9e5f1cd-928a-4fe0-b841-69bd6ddd966b"), null, null, "+615 70 (457) 97-38", false, new Guid("a0d218cb-ab28-4295-9255-4324ebe45a98") },
                    { new Guid("a9e70e39-d022-403c-a590-4bbe4ebcbcde"), null, null, "+206 04 (956) 74-32", false, new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("aa144475-8057-44b3-bd42-09ef5c595d2c"), null, null, "+393 57 (889) 12-33", false, new Guid("53a7a51e-d382-4050-82a5-f33ab7641603") },
                    { new Guid("aa4d42d5-507e-4934-84c0-b770dcdc8765"), null, null, "+527 07 (618) 61-88", false, new Guid("617100a1-d830-4170-9964-86b27fc31a31") },
                    { new Guid("aa8cb5e0-47cd-428f-a359-d9c1a44f230f"), null, null, "+720 03 (422) 33-59", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("aba99f00-7682-4b96-9fe6-dd97d7c5ce84"), null, null, "+122 26 (649) 06-32", false, new Guid("839ee652-8687-4a7f-b23c-b7946aaf573a") },
                    { new Guid("abbadf1e-7591-4ec1-bbd0-1c61b34fc9fd"), null, null, "+756 79 (816) 83-82", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("abd6741e-9323-4206-a7a1-52cc6412dd1e"), null, null, "+304 71 (405) 61-21", false, new Guid("8be83005-0ddc-42eb-877d-582666d35fea") },
                    { new Guid("abff24cf-aa56-4593-bca3-2b510de8b4d2"), null, null, "+770 05 (032) 06-12", false, new Guid("b44dcd20-fbaa-4948-8ad7-1345c9cb2018") },
                    { new Guid("ac673458-d53d-430c-ae45-8b29a01146cf"), null, null, "+504 36 (550) 14-92", false, new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") },
                    { new Guid("ac9978d5-22d0-4744-9043-8763baf5b21d"), null, null, "+39 11 (824) 12-26", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") },
                    { new Guid("acaf2abb-dcb0-4629-ab39-ef5d4be8dfb3"), null, null, "+342 48 (378) 98-67", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("acefc640-fd05-49ad-b0b1-0c29866fc9a3"), null, null, "+723 98 (529) 86-64", false, new Guid("c7e61d9f-e66b-4c01-98d3-a4ba52b02303") },
                    { new Guid("ad100f90-d7c5-4071-a838-279272edc462"), null, null, "+392 07 (021) 90-67", false, new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("ad2b7810-c51b-4a52-a434-c464cd918d87"), null, null, "+911 80 (937) 93-39", false, new Guid("6c6603f0-15e5-4343-859f-b88e9ccdc058") },
                    { new Guid("ad638ba0-0890-4d98-bd3a-0d05b46d9947"), null, null, "+696 67 (705) 51-50", false, new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("ad6bbe13-1889-47b2-bc7f-60c766bc6502"), null, null, "+198 15 (852) 32-90", false, new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e") },
                    { new Guid("ada59b9d-4ea1-45b2-a9aa-0109902640a3"), null, null, "+833 18 (093) 39-37", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") },
                    { new Guid("adcfe294-f4f8-4b4a-83e2-c4759d8a02a7"), null, null, "+732 86 (454) 34-76", false, new Guid("6fd9abb5-bf82-45d1-902d-f90f330fa353") },
                    { new Guid("ae4c369f-69cc-45b3-8ecd-ff5e45e849d4"), null, null, "+15 01 (209) 94-80", false, new Guid("6b524441-f464-4e08-8f72-3c7c650f6875") },
                    { new Guid("aecb32e7-38ba-4901-aa26-3d21185c7b83"), null, null, "+668 17 (748) 03-16", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("af3d69bb-8f3f-43ff-8073-f3ba123b953c"), null, null, "+981 05 (826) 29-93", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("af3f3409-ddd7-476d-8d04-20912a856ce2"), null, null, "+236 39 (803) 63-83", false, new Guid("a6fa0b6a-b8a3-4e34-bd6c-a4f112bb4760") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("af51969a-c977-4e6e-9103-45390f637138"), null, null, "+36 58 (637) 82-72", false, new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("b0cb6a3b-859e-4af7-9435-661b5b249fc4"), null, null, "+632 35 (238) 43-29", false, new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec") },
                    { new Guid("b0fea785-63ed-4cae-9230-65de5e9a1ed7"), null, null, "+41 63 (736) 90-04", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("b1330f46-9a83-42ad-b241-fdd820c9abec"), null, null, "+488 84 (063) 43-35", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("b14bb152-0612-4713-937d-2651bb5e907e"), null, null, "+773 58 (069) 76-40", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("b2697dbd-a4fb-48de-82bc-0947b891d261"), null, null, "+724 96 (573) 73-26", false, new Guid("8bd29528-e234-4d23-8b23-8b7854993fa6") },
                    { new Guid("b2b5224a-fae4-4174-a03a-6f0af5bfaa8e"), null, null, "+870 89 (963) 24-53", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("b3255d47-7492-42b6-9fc0-a50860acc8e9"), null, null, "+748 06 (305) 14-58", false, new Guid("7b9d9a45-7408-46ad-92ec-c4dee291f024") },
                    { new Guid("b334b250-0028-4bbe-9649-2249a2772397"), null, null, "+474 68 (969) 71-86", false, new Guid("6b3b042a-cae6-4427-a4dd-fa173ea5c3f6") },
                    { new Guid("b3630318-73a9-4ecf-964f-6359d93c1649"), null, null, "+890 07 (468) 84-93", false, new Guid("97fd604a-eb78-4e29-829c-caf68b162e92") },
                    { new Guid("b3708d1d-19c5-4cec-b05d-240f779ef9f7"), null, null, "+906 38 (185) 63-17", false, new Guid("52698753-1196-4fd7-83fd-4670d8d55456") },
                    { new Guid("b3e32b53-e18a-4fd1-930b-fa2250d37efd"), null, null, "+957 68 (048) 50-94", false, new Guid("08beccf1-c6b5-4048-900f-2b13eea8e219") },
                    { new Guid("b3e8ddc2-8f29-45cf-b967-dbfa4e120fe0"), null, null, "+193 67 (606) 59-34", false, new Guid("6999cbe5-c0c6-49c2-98b6-4617d573375c") },
                    { new Guid("b3f5847a-13ff-46f7-9e1c-8e86c121bb64"), null, null, "+158 77 (373) 91-46", false, new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("b4704e9c-829a-4f6a-9de2-ac9483b95de2"), null, null, "+367 54 (856) 43-59", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("b48c6552-5dd2-41ff-851b-079923973369"), null, null, "+408 68 (927) 92-96", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("b4d33007-c4c6-47a5-adc0-530c1a4df1f1"), null, null, "+125 74 (443) 06-42", false, new Guid("1253df08-c182-4a6b-bbe3-05f888b56553") },
                    { new Guid("b57bfbc1-1981-4201-bf08-09fe467b726f"), null, null, "+351 00 (611) 68-44", false, new Guid("99484890-5bb7-47f9-b211-218700e48dad") },
                    { new Guid("b5f317b5-8c42-4854-9c6c-ff25b0a97bf5"), null, null, "+388 24 (096) 76-04", false, new Guid("2857a63a-8b4c-48c5-a008-a2e0f10ab9d8") },
                    { new Guid("b6406746-e610-497f-8a6c-7f0dccf09d56"), null, null, "+549 85 (491) 41-83", false, new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372") },
                    { new Guid("b6b189b6-92dd-4bf0-908d-881ec091c7ee"), null, null, "+316 81 (060) 42-09", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("b6bb19df-a336-490e-ba70-aa6a2e0e36cc"), null, null, "+850 88 (994) 83-46", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("b7c3ffac-cdd7-4d66-b746-92f7b70332f9"), null, null, "+29 98 (574) 95-96", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("b7e822b4-40c2-4a09-959d-e59d179c00d9"), null, null, "+497 22 (991) 54-14", false, new Guid("65c9d2d3-518c-4e5f-96dd-d7b245e5d921") },
                    { new Guid("b87dfd10-e088-4cd8-8c85-cd22bda0ad6b"), null, null, "+593 78 (159) 38-60", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("b8a8a0f1-4933-44d0-86a9-7cafb8b7b960"), null, null, "+247 67 (131) 28-59", false, new Guid("8461c967-9f1c-48cc-85ae-66b9741be768") },
                    { new Guid("b941f8cc-e07f-45a4-a329-58596e166d8d"), null, null, "+456 17 (952) 84-68", false, new Guid("fb455a22-8198-413a-89a8-e92c01f42483") },
                    { new Guid("b99203b2-6c8e-4735-bba1-ff06b824f212"), null, null, "+352 39 (690) 97-43", false, new Guid("71cab690-3d2a-48a4-9157-ca87952e4f61") },
                    { new Guid("ba214964-56ee-44bd-a9ad-141f8851cc5b"), null, null, "+105 51 (868) 54-65", false, new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("ba7389d6-512b-41af-b02a-cfeda7915cf5"), null, null, "+672 47 (620) 07-55", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("bae57c43-82c7-4b94-907c-3959657d4f2a"), null, null, "+169 82 (302) 31-63", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("bb701595-0ec1-4491-8204-88c7028160f3"), null, null, "+411 65 (346) 73-24", false, new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("bc1493e3-79fc-43ec-9bcd-45a419b23526"), null, null, "+235 47 (289) 48-24", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("bcbd6dba-4e84-4f4c-b2cb-8ccaa084ccbf"), null, null, "+719 14 (936) 06-30", false, new Guid("99227d48-6d3f-45fd-971b-83f0198ee703") },
                    { new Guid("bcca6c13-4d08-4540-bb2b-da1aefab8d26"), null, null, "+936 15 (481) 51-20", false, new Guid("23dbc71b-d9ff-4bae-9df6-3dca4e8024c4") },
                    { new Guid("bcee312c-c804-47c4-9809-7aaee1446ec3"), null, null, "+833 62 (950) 43-79", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("bd72f51d-5941-4aab-8daa-87be652b8ed0"), null, null, "+589 13 (070) 57-88", false, new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f") },
                    { new Guid("be93743b-7a20-4446-be6e-dd1c0044ea13"), null, null, "+600 75 (853) 49-79", false, new Guid("bd5e74fa-fa68-45c7-bfc4-8e94f7be04a8") },
                    { new Guid("bea96102-2bb8-498e-a293-6fd5e0ab32cf"), null, null, "+398 06 (512) 33-16", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("bf22a0f2-a2f6-4901-9863-5c47c27d1b80"), null, null, "+976 36 (922) 75-19", false, new Guid("f47320e6-1a4f-48c6-9bb9-2f582ce6258e") },
                    { new Guid("bf60fe09-61c1-42fa-96e4-0400db47cac1"), null, null, "+64 53 (195) 84-68", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("bffabe30-9e91-43e6-92a0-05a558b265c6"), null, null, "+340 54 (031) 07-37", false, new Guid("aff8201b-8f5f-49a5-8fd2-0e8c9a55addc") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c0639b16-53ed-495e-823b-4c26347cfec0"), null, null, "+360 28 (700) 66-34", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("c096cd5e-7ee7-4956-a01a-afac96c6048f"), null, null, "+892 97 (896) 18-58", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("c0d69a9b-36d2-409c-b15c-dd67a0742d98"), null, null, "+827 57 (558) 11-22", false, new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd") },
                    { new Guid("c1167aa4-1f1f-4753-be18-27b18499a5c2"), null, null, "+366 81 (595) 68-84", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("c1823b3e-fc49-4358-9632-2bb07670df8e"), null, null, "+393 47 (186) 85-66", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("c2400242-032c-4a25-9cef-633d8a554b4d"), null, null, "+279 66 (239) 13-36", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("c3698e85-4f21-4cbd-9934-779b2cc5b421"), null, null, "+189 32 (834) 18-22", false, new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("c394cd20-184e-459e-b9e7-3a0eb8e1dedf"), null, null, "+26 64 (276) 89-95", false, new Guid("45649949-0283-499e-b496-44660ddab1e4") },
                    { new Guid("c398c85f-118c-44ab-ab05-f7334cc6b8e8"), null, null, "+922 25 (141) 28-75", false, new Guid("4ea29651-f292-4cbf-8413-d8821c394155") },
                    { new Guid("c39ab38f-7309-4ded-bd34-2431e345cf7d"), null, null, "+494 01 (260) 58-03", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("c409b9c5-94b8-47b8-9360-626051227285"), null, null, "+924 45 (311) 24-37", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("c4a12563-9f61-4d25-92f6-467c956d736c"), null, null, "+942 74 (480) 13-99", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("c4e028a0-5515-4e02-980e-449fdfdbba99"), null, null, "+822 01 (485) 55-78", false, new Guid("832c338d-accc-4431-af4f-b163f4abe6c5") },
                    { new Guid("c5b37050-cb9d-42d6-acbf-2deae0ef694a"), null, null, "+573 27 (883) 85-84", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("c687f756-5709-4bde-aa9b-53fe93df2d47"), null, null, "+606 21 (267) 83-11", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("c6b0f76b-7b43-48c8-9d6c-2649bbe4434c"), null, null, "+636 56 (995) 93-57", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("c6dff681-6ef1-477a-9ddb-de78edd239ba"), null, null, "+686 43 (806) 71-50", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("c6e0bb34-b0d7-487e-884c-751698bc5a73"), null, null, "+303 57 (998) 29-40", false, new Guid("49ca8858-3e96-4018-80ae-1402fcb52e67") },
                    { new Guid("c75ee87b-8abb-4a78-b92f-4d0912b8b72a"), null, null, "+78 13 (791) 19-16", false, new Guid("f114059b-b2c2-4c90-a0b2-c50b00534fd2") },
                    { new Guid("c7b62805-613e-4d4f-a0e5-3c38159586b6"), null, null, "+151 51 (199) 61-79", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("c819bc78-fffa-425c-b46a-32cbfd8601d7"), null, null, "+621 59 (222) 91-40", false, new Guid("ae5483f3-2518-47a0-bbeb-14f94d94091f") },
                    { new Guid("c89ea511-cad2-4446-baec-4ea6ef355e7e"), null, null, "+477 40 (286) 08-71", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") },
                    { new Guid("c93386e3-5bf4-4e29-8e46-0f5e25232534"), null, null, "+280 06 (228) 36-43", false, new Guid("83059c11-6c07-4892-a0cb-ced177c551d8") },
                    { new Guid("c9368eb6-c4f9-4b3e-aca2-c70b388a07db"), null, null, "+10 62 (975) 09-56", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("ca0bd0bd-84c3-4c17-adb4-0d5b2b96128c"), null, null, "+253 82 (882) 92-53", false, new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154") },
                    { new Guid("ca1eed44-7760-4fe7-9cfb-fe8298c98110"), null, null, "+31 95 (685) 52-58", false, new Guid("c74424cf-d0aa-489b-b879-f623f6fadab5") },
                    { new Guid("ca24828a-1c1b-48c1-8ae4-13030130a6e1"), null, null, "+606 19 (267) 40-82", false, new Guid("32b7d0ff-52e6-4c9a-9ac8-a4770eaf6bbf") },
                    { new Guid("ca33512b-c790-4e8f-b02f-2fdffa5ea85f"), null, null, "+347 90 (696) 90-82", false, new Guid("08094f90-68b7-4576-a740-581a4878e4ab") },
                    { new Guid("ca4ac4f7-4c62-4d20-baf5-5d94eaac0e39"), null, null, "+535 05 (669) 85-18", false, new Guid("aa7e1d8c-ea66-4d97-97ae-e66f7ffd6b7b") },
                    { new Guid("cb0d00e5-fa93-4611-a9f7-c4fdcf4d6b38"), null, null, "+58 10 (386) 07-24", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("cb190a28-b760-4a0d-8fb6-ee1a28724029"), null, null, "+197 01 (944) 93-85", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("cb35855b-45e5-4177-bd9a-be4549a60e40"), null, null, "+970 44 (442) 63-87", false, new Guid("7ec12a31-b6d5-4be2-8e95-5a1d3e3ed6f6") },
                    { new Guid("cb9a623e-c044-4d5f-9524-f6ff3cadf629"), null, null, "+500 66 (953) 75-90", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("cba217c8-91bc-4575-a422-2dbf95118439"), null, null, "+438 06 (378) 05-74", false, new Guid("08094f90-68b7-4576-a740-581a4878e4ab") },
                    { new Guid("cbe49079-87e9-4d8a-a763-b722fb4cfacf"), null, null, "+117 04 (676) 60-84", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("cc10b99a-0c55-46de-a3c1-e378a3d3a0cd"), null, null, "+857 49 (377) 96-15", false, new Guid("3ca411ff-d5aa-4fff-a532-51b811b543e1") },
                    { new Guid("cc143e7a-57c8-4250-b634-e8e6f70966c7"), null, null, "+259 81 (284) 04-97", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("cc17d253-b49b-42ed-931d-d35431a74e55"), null, null, "+584 40 (885) 99-97", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("cc2f1d9f-6610-449a-8a6f-0a3460bb6f8e"), null, null, "+8 20 (658) 86-46", false, new Guid("5922607f-fa5e-493c-94ec-c548b2c4c02c") },
                    { new Guid("cc32fda3-3c24-4975-bfbf-aafccc665314"), null, null, "+632 10 (315) 40-78", false, new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("ccfc94bd-a1f3-46f3-b220-baad9cd226cf"), null, null, "+251 25 (331) 64-61", false, new Guid("5a54e81a-8c68-40f8-a2c1-0dffe798185d") },
                    { new Guid("cd1b73d7-d58d-4f0d-95a4-70cf74ac95ad"), null, null, "+506 81 (566) 13-44", false, new Guid("f5437872-2b7a-4bb8-a1a3-176bb652d770") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("cd21e549-4da6-4fe0-8516-5f1e926a91e5"), null, null, "+86 12 (078) 15-56", false, new Guid("eac2054b-05f8-4a2d-a019-7f2ce9121e6f") },
                    { new Guid("cd33368b-fdf8-4fe1-91bb-80315d1bcbb0"), null, null, "+453 86 (776) 38-93", false, new Guid("bf4e418c-e9b1-498c-b01f-1f75bd2a490b") },
                    { new Guid("ce2f30cd-fd33-4130-accd-50a029bb3c6d"), null, null, "+765 32 (938) 87-28", false, new Guid("31336dfc-cc0f-4af9-a4ec-4a5930078065") },
                    { new Guid("ce789d75-e08b-4edb-b4e3-ed1e34a6ada3"), null, null, "+108 16 (485) 11-03", false, new Guid("623f80e5-d4cc-4390-9c01-ed456272fabc") },
                    { new Guid("cec8f98f-6ac7-4cb7-9dd5-44c621d748af"), null, null, "+336 31 (775) 47-65", false, new Guid("efe3f082-f8ee-4021-90ff-4a5e7b273785") },
                    { new Guid("cf607cce-6f9c-47b7-996b-f7e084d0ae5d"), null, null, "+29 23 (850) 39-66", false, new Guid("750b154e-9b3c-48d8-957d-33d3db20a64c") },
                    { new Guid("cff6ba1a-3f5e-4bd9-9286-3f4a735b4b32"), null, null, "+731 00 (917) 78-28", false, new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("d05ab5d5-902b-4c9e-8fd6-2d78192f2efc"), null, null, "+800 98 (372) 20-16", false, new Guid("12cc4b91-40fc-4dab-8e23-6a4d1c412b45") },
                    { new Guid("d07b4bd4-4f20-4df4-bea1-75a654f8a6bc"), null, null, "+705 71 (297) 86-53", false, new Guid("a95360f0-028c-4dd4-9dcb-eedefd13829a") },
                    { new Guid("d0928299-f08c-4cf8-94bf-a86f728ea789"), null, null, "+795 76 (089) 52-97", false, new Guid("cb6c4d6b-a4f6-4d3a-9918-be709c335470") },
                    { new Guid("d0a40e6d-36ff-4631-96c9-2f2bff52ee4e"), null, null, "+592 14 (965) 78-27", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("d0c2247e-e176-421f-8b21-11bfa5ba97af"), null, null, "+735 04 (258) 28-04", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("d0dfadc8-ad12-478f-b68a-d09f319a99bd"), null, null, "+688 57 (694) 63-82", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("d0e0fdf9-cf90-4555-990f-e0386a22e95c"), null, null, "+604 65 (980) 04-04", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("d0f12be4-74b6-4dd9-8918-396d54bf7d62"), null, null, "+690 82 (492) 12-44", false, new Guid("b82a6e28-0433-4b40-b4b0-22b881b712cc") },
                    { new Guid("d0f46380-4363-42ab-a48b-c02b4461a159"), null, null, "+619 06 (838) 65-26", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("d159bb93-56fb-4b11-bf85-24e2e5ef1062"), null, null, "+485 31 (626) 07-59", false, new Guid("388f76d3-9b2a-485c-9de9-f783ecb36066") },
                    { new Guid("d1cfb414-e83c-43f8-9918-54b10330af9e"), null, null, "+710 56 (117) 69-36", false, new Guid("56e230b3-4d41-44b6-8fe8-a54ee23ce321") },
                    { new Guid("d2195f32-ed5c-4572-b1c4-f24d73ebcf55"), null, null, "+591 42 (797) 64-60", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("d22dc62b-7f2d-4d15-ac0f-a21133d0cfdc"), null, null, "+863 29 (004) 31-41", false, new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("d236f11d-9f5d-40ce-9887-0bab77ef3c17"), null, null, "+22 88 (326) 14-31", false, new Guid("45649949-0283-499e-b496-44660ddab1e4") },
                    { new Guid("d27ea960-a14c-4996-8b62-c587e079bb97"), null, null, "+477 38 (327) 49-42", false, new Guid("19034493-ddce-4219-8d74-fbdd26d02300") },
                    { new Guid("d2a564ce-a0db-42cf-a618-0dba941d9e79"), null, null, "+916 92 (209) 55-10", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("d2ab6238-3a87-402b-a4b6-512b2cde23ec"), null, null, "+318 92 (137) 95-70", false, new Guid("611f7dcb-127b-4251-92d0-469cf835b3e1") },
                    { new Guid("d4057692-bd3e-4861-8054-96d9791ea6e9"), null, null, "+878 64 (638) 06-60", false, new Guid("3cc09211-78b5-49eb-92bc-3e91bc6e9e18") },
                    { new Guid("d4dd07dd-9894-4d1a-8928-3c62134df49b"), null, null, "+716 37 (299) 70-43", false, new Guid("4776aced-a807-4c2e-a3ed-efdf7b1b5c0c") },
                    { new Guid("d4e3e26a-15da-425d-bf94-abee431014f4"), null, null, "+656 46 (923) 46-31", false, new Guid("862a826f-0eba-4891-9241-dff3a8896969") },
                    { new Guid("d502c179-6ea1-4786-9843-75c5ac5ee9c4"), null, null, "+563 00 (729) 08-62", false, new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("d5457606-5e9c-4f72-badf-8fbaf98a8d60"), null, null, "+40 34 (515) 71-33", false, new Guid("1c0b12ce-d17c-4e21-9878-43ba05d77799") },
                    { new Guid("d55052fd-fce7-448a-b29f-688c47469a03"), null, null, "+616 92 (942) 05-28", false, new Guid("42cced7c-7761-4e63-bca4-0d2f6655e731") },
                    { new Guid("d5525497-1936-4339-90b0-942924d81844"), null, null, "+184 06 (459) 45-39", false, new Guid("9000d5a6-88f4-4f82-8d66-d6bddbcd0010") },
                    { new Guid("d5fce589-76a1-4876-8d8c-6d2c8766f1e9"), null, null, "+681 11 (276) 49-42", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("d606411a-db58-4afc-885e-28e2cdb0b609"), null, null, "+99 71 (415) 75-44", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("d62114d6-40b4-4f06-b6db-4f2970979ded"), null, null, "+109 92 (189) 36-44", false, new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("d646cc62-8b0d-4550-a7dc-af72098f2d2b"), null, null, "+275 97 (499) 58-64", false, new Guid("cb96eb06-e320-431d-b09f-ec1e30673afd") },
                    { new Guid("d663c2e7-b705-4650-8207-bef7175d241c"), null, null, "+513 24 (521) 55-86", false, new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("d6aaf3b4-8954-42a8-9645-a389479b2280"), null, null, "+571 86 (206) 70-60", false, new Guid("8f3ea2a8-454d-458f-836c-7770fcc100fd") },
                    { new Guid("d6b88a49-6566-42a3-a147-7727a1993720"), null, null, "+907 51 (917) 65-27", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("d742b33d-a7fe-476c-89e8-c98d4def8087"), null, null, "+456 07 (506) 86-90", false, new Guid("67dd6ad8-cd02-4f75-a100-0e8934fc9729") },
                    { new Guid("d759bc49-610a-4f81-9d55-de197c51c319"), null, null, "+719 19 (459) 49-47", false, new Guid("c3fe951d-3ac7-403a-a1c3-13c9b27a34ae") },
                    { new Guid("d826d2a8-01e6-4460-a0f4-392b40dfce82"), null, null, "+150 44 (499) 68-98", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("d83e7a04-aa79-41b3-bf31-fafa9e0d35d9"), null, null, "+960 88 (923) 88-49", false, new Guid("a03c7943-6fd1-41c5-84be-6de9d00b6fb5") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d8cb840d-53a6-4654-9258-50cd738a2d04"), null, null, "+729 24 (487) 15-52", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("d94185d2-92b5-4562-b0a3-9df1b9cfbdcc"), null, null, "+81 32 (250) 36-09", false, new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("d97f8097-afb7-4442-8541-6a6d653ac86c"), null, null, "+534 06 (631) 97-46", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("d9a6d82c-bdca-4289-94c1-855acd754f08"), null, null, "+678 26 (191) 36-10", false, new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("d9a7191a-0352-4091-87ca-90121c810a15"), null, null, "+387 76 (318) 69-74", false, new Guid("53328c4d-155b-46bf-9717-1f519f42d5cc") },
                    { new Guid("d9c3b949-e678-4ea0-bac7-eff0c01bc0c0"), null, null, "+975 78 (321) 44-27", false, new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739") },
                    { new Guid("daa97af8-5c96-4443-8378-6e86a2adb83f"), null, null, "+266 75 (470) 58-29", false, new Guid("f027517a-8745-4767-8a34-aaadc0a70189") },
                    { new Guid("dad99bc8-714f-4e9a-b3fb-7b4aef6890a9"), null, null, "+647 30 (712) 84-62", false, new Guid("dbdc3e64-fce2-4b1b-b337-a74c4ef3e90f") },
                    { new Guid("dadb5a00-508d-468e-a19c-18990733b2d9"), null, null, "+572 04 (099) 63-16", false, new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379") },
                    { new Guid("db173baf-d4db-441d-bdaa-413e42907e5b"), null, null, "+442 88 (977) 55-32", false, new Guid("94aaefbb-3b69-4a12-8609-44039863dc44") },
                    { new Guid("db40291d-3e61-4d04-8ef8-c95494432a59"), null, null, "+268 87 (562) 32-40", false, new Guid("022afc38-5eca-40fe-984b-bb4349ad1e30") },
                    { new Guid("db747b10-1f20-44ff-a82b-2c1a48a3711a"), null, null, "+156 90 (487) 48-72", false, new Guid("66dc9f98-25c3-44a2-8b64-0d0aee31c1be") },
                    { new Guid("dc220cc7-d874-48d2-8dfe-cc3d04bfb063"), null, null, "+403 82 (460) 54-77", false, new Guid("538f5fff-c1a8-4b50-b6a6-c595053f0748") },
                    { new Guid("dc23ac42-1759-419e-9baf-9410757ec3c5"), null, null, "+302 03 (781) 57-72", false, new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("dc4829fc-69b9-4ad6-9f71-206a7887b30e"), null, null, "+173 38 (722) 24-95", false, new Guid("7bf65f45-8502-47e1-ac39-6af95c9a8a87") },
                    { new Guid("dda1dfb8-7194-4d49-ad03-38ed11ab0106"), null, null, "+368 68 (217) 81-46", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("de0ada36-ec67-4b44-b799-a7e022234221"), null, null, "+101 81 (304) 60-49", false, new Guid("460ff94f-c5bf-402e-bb8e-9fdaf961acfc") },
                    { new Guid("de0c4760-fb4a-444f-8117-a7a46af1a260"), null, null, "+516 48 (367) 16-56", false, new Guid("99227d48-6d3f-45fd-971b-83f0198ee703") },
                    { new Guid("de22cc08-4b16-48c4-a22b-3b75ec800e16"), null, null, "+326 59 (116) 36-94", false, new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7") },
                    { new Guid("de5ec3df-c102-4d3c-8a8e-2b36721b36ec"), null, null, "+312 30 (903) 76-46", false, new Guid("220dd6a2-d37f-40ac-be91-48215271da4c") },
                    { new Guid("de76de4e-731b-4d12-aba7-71ed675dd60c"), null, null, "+154 76 (802) 66-51", false, new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da") },
                    { new Guid("defd1fbd-9a26-4933-80d1-4848e2cfcbf7"), null, null, "+813 86 (109) 85-95", false, new Guid("5afe6f5c-9b64-4991-acb3-d122f9a23379") },
                    { new Guid("df356476-d46f-40f2-84b0-d9fb60e45cce"), null, null, "+777 37 (248) 40-05", false, new Guid("7c7f16dd-91ea-49a5-8311-ccd8e23bc3da") },
                    { new Guid("df577484-129a-4c04-b734-9cc335184cd6"), null, null, "+795 05 (438) 14-63", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("dfb41df4-b076-422a-af97-4b4dfebeb974"), null, null, "+998 59 (044) 73-77", false, new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("dfc9b830-2ecc-471c-9a27-2626428cc3fd"), null, null, "+594 76 (318) 31-62", false, new Guid("19db6e81-ce52-480c-84b4-04db9f6b979b") },
                    { new Guid("dfd83398-6e7c-46ef-b452-5229fd187049"), null, null, "+416 23 (958) 96-01", false, new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("e034cd61-48c2-4b0f-a00e-0f7ac08fc1d4"), null, null, "+250 46 (324) 43-63", false, new Guid("cc9fd67a-df81-4c57-9231-20a528617118") },
                    { new Guid("e08ff6f9-4d13-4fda-9d9d-6f5de857874e"), null, null, "+236 35 (666) 96-33", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("e0f76b71-3351-4635-bf0d-1e3c6dd117b5"), null, null, "+654 09 (500) 08-03", false, new Guid("9ff56735-1fcb-48ab-88e3-4b80de02322d") },
                    { new Guid("e163b3d4-6ef8-4182-ba0c-40087945388c"), null, null, "+282 62 (704) 02-19", false, new Guid("29147a8b-a8cb-4a0c-ae36-98a782d2be37") },
                    { new Guid("e1851d37-1f12-4656-9705-de7052ddb123"), null, null, "+259 84 (785) 93-20", false, new Guid("865b430e-4516-4a31-ae36-1eecddd681f1") },
                    { new Guid("e1a09bba-dd28-4632-9965-f7c402f53944"), null, null, "+543 10 (276) 69-17", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("e1e51477-b1d2-40b0-8521-0834969c7ee1"), null, null, "+517 62 (019) 46-50", false, new Guid("42ee14ea-707b-4681-b620-98122f2d53e3") },
                    { new Guid("e266d93f-b567-43b7-a532-2d918628d038"), null, null, "+862 10 (631) 90-22", false, new Guid("0c4c14ce-c82a-43e9-b0f8-3e6cbbb7b372") },
                    { new Guid("e2e37d4f-3fd6-482e-9f00-bdf6bf4904f0"), null, null, "+682 66 (924) 04-94", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("e2eddfa8-cbb1-4383-94b5-81624e25d606"), null, null, "+15 51 (989) 27-91", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("e398100e-9bb6-449f-9057-0e2cc61d9989"), null, null, "+122 71 (994) 59-51", false, new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("e3a13ff7-6f36-485a-b67e-f33b6f47e9ba"), null, null, "+235 09 (622) 55-28", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("e3d22561-00d2-4be3-a914-87059d66e299"), null, null, "+80 48 (679) 64-12", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("e3e5c802-89bb-4b4e-a78b-948935de78ff"), null, null, "+624 58 (580) 43-35", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("e3fc9de9-7d51-4114-af17-66160eedab17"), null, null, "+909 81 (746) 71-59", false, new Guid("0b98923c-0481-432f-9b60-33427e4d8223") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e422db31-827b-4682-8935-51095c0f03b7"), null, null, "+955 49 (467) 24-09", false, new Guid("982f49cc-7421-4c4b-886c-140a6c2fafe9") },
                    { new Guid("e46f137e-0ca4-4d7d-aee3-0ec22fc3c799"), null, null, "+374 53 (717) 00-32", false, new Guid("46568224-f301-4805-9ce4-f87ec0533c46") },
                    { new Guid("e48438fd-e4d4-4fda-8b4b-327a1abf8cd3"), null, null, "+940 86 (856) 68-31", false, new Guid("2cafe8e0-e93a-4a12-afef-881a5f1605f8") },
                    { new Guid("e4b92dca-8cdf-4f6d-bfd0-f391278e509a"), null, null, "+344 59 (453) 81-78", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("e4ccbe57-1bcd-4100-a6fd-0a8615cc0d79"), null, null, "+582 65 (092) 99-10", false, new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("e4e5c356-9097-4b4b-b5cd-0fc022478b2f"), null, null, "+660 25 (136) 89-68", false, new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("e4e6b157-515a-4b42-bdde-5818d555c25c"), null, null, "+398 92 (327) 90-64", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("e4fd21fa-c43f-4a24-971b-f16fa852ee26"), null, null, "+141 52 (120) 58-32", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("e51ad994-9ce6-4d0e-a89e-923f13a5e0eb"), null, null, "+65 04 (455) 05-54", false, new Guid("d0848276-b13b-40d7-b358-6f73dcf1d477") },
                    { new Guid("e53f52ad-c971-4f91-aeed-b03d081675d8"), null, null, "+64 03 (422) 08-48", false, new Guid("f194e3c0-285c-4915-a24f-3af88a56f3e4") },
                    { new Guid("e5726005-ccc4-411b-b1b7-5fefde2293bf"), null, null, "+326 40 (023) 24-13", false, new Guid("a3bd5268-d6f8-45d2-8fe2-3d269ce49117") },
                    { new Guid("e58233df-d14a-41e0-9da2-7f0d54467566"), null, null, "+135 71 (938) 08-59", false, new Guid("6f08fed2-0c07-4ee1-918b-ac15ce6069ae") },
                    { new Guid("e5908ec7-4c76-4037-8f66-c3e132a2b241"), null, null, "+635 62 (522) 89-80", false, new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("e5975419-90ce-40a4-b34d-a00e3d83fb42"), null, null, "+349 02 (677) 48-08", false, new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44") },
                    { new Guid("e597e719-28f7-41b5-82ef-03971e1569a5"), null, null, "+823 84 (439) 93-58", false, new Guid("18342c77-3dd1-491d-96e4-0ee20a471fee") },
                    { new Guid("e5c48678-8a33-499e-8e3c-164331e052a2"), null, null, "+814 49 (989) 42-30", false, new Guid("6415329a-ef08-45b6-b176-c5830ca9c52b") },
                    { new Guid("e6791945-33f9-4a12-abb5-097ac50d9502"), null, null, "+755 51 (098) 74-37", false, new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("e6a666ac-a18e-49e9-9987-a20fe66a69c2"), null, null, "+722 93 (429) 41-74", false, new Guid("80ed64a5-2f87-4262-aed3-901da3da1369") },
                    { new Guid("e6d602db-51d0-42dc-857e-3fdf24e81d73"), null, null, "+299 01 (008) 64-75", false, new Guid("f5693a23-d9e4-425f-a429-a674aeaf0bb7") },
                    { new Guid("e76eca0f-41d5-4f8d-bad9-cb81d1bd7a39"), null, null, "+801 91 (051) 69-78", false, new Guid("3e1827bb-2cfc-4263-be79-7b663816638e") },
                    { new Guid("e84ab45b-2304-44b7-bf76-a4c97221fa22"), null, null, "+660 60 (749) 63-81", false, new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("e8b1128b-36c2-4cd6-bb1a-14046381840b"), null, null, "+551 51 (612) 52-49", false, new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("e8dfde53-35ee-478a-a5b7-73e8c78d5be6"), null, null, "+514 02 (923) 36-32", false, new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("e98d1852-bce6-48b7-a107-b137f0553747"), null, null, "+466 01 (701) 34-38", false, new Guid("4c7fbba6-ecab-4134-9627-17e6c4590754") },
                    { new Guid("eb07fbfb-877d-4852-aa9c-a1d763d56185"), null, null, "+967 74 (945) 97-21", false, new Guid("08b7750e-6f1a-43e7-aba6-dfa80e26314c") },
                    { new Guid("eb224c79-be68-4cee-9f99-b43bec396b68"), null, null, "+754 61 (092) 46-39", false, new Guid("7fe9459a-d0c6-43a7-b687-d4504010a2c0") },
                    { new Guid("eb3b029e-6976-4fd8-b797-d44408cdada2"), null, null, "+237 83 (499) 33-07", false, new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("eb8c1206-06f2-4305-9433-9153c6c0db6f"), null, null, "+468 17 (813) 71-86", false, new Guid("3fbd12de-d2f4-4a69-bd00-df31ad7fe6a2") },
                    { new Guid("ec3ec430-0cae-43c5-a688-eb1545906a12"), null, null, "+275 77 (048) 27-02", false, new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("ec3f3d3b-3cc6-487d-a85f-c46e22cdf47a"), null, null, "+771 45 (206) 29-34", false, new Guid("e1e10c7d-76ad-4aea-84bd-ed35f985c2dc") },
                    { new Guid("ec667ece-e613-4e18-9bf7-4e86f7d99cbf"), null, null, "+598 32 (177) 97-82", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("eca4846e-ceb9-4ab1-8950-cb5f04dde2b6"), null, null, "+736 83 (605) 93-07", false, new Guid("edd435f6-25a5-4ae8-a3c1-e5b6501197ec") },
                    { new Guid("ecd0bab0-c054-4d98-870d-b1c438a2ce73"), null, null, "+664 09 (422) 73-94", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("ece9be70-51d5-4aa1-a447-4b1608635048"), null, null, "+890 64 (158) 36-30", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") },
                    { new Guid("ed5d36c9-b67f-4270-b692-1f35187c9810"), null, null, "+932 54 (961) 63-59", false, new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("edd1f185-3f54-4135-9916-732c3175ce8d"), null, null, "+272 56 (690) 32-06", false, new Guid("1d8dc63a-47c0-46fe-9596-0626fdec1217") },
                    { new Guid("eddc0c1c-f009-48a3-be77-22ea24a80e05"), null, null, "+977 25 (452) 82-89", false, new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("eeb7139b-d62c-4cac-ba87-22579094d43d"), null, null, "+888 32 (571) 35-81", false, new Guid("6b524441-f464-4e08-8f72-3c7c650f6875") },
                    { new Guid("eed95b8d-0218-4b87-aacb-4211c5744e9b"), null, null, "+418 09 (766) 28-18", false, new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("ef75f3c6-67d8-46c6-adc5-8da5dc3c2a55"), null, null, "+820 23 (276) 99-03", false, new Guid("5edf9a62-0420-4baa-98e7-88c55b62e1dc") },
                    { new Guid("efe3aaa9-e1e4-400f-837a-d402194cc5c1"), null, null, "+144 28 (180) 76-61", false, new Guid("4f80af1c-a1e2-4285-b825-e9802427655e") },
                    { new Guid("eff76b75-54e0-44e3-8255-7ff72ab6023a"), null, null, "+18 14 (507) 68-08", false, new Guid("542cca7c-dbc2-4394-8615-7d906972ce59") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f0209f90-9f86-4cfe-9c4d-761f82703cf8"), null, null, "+878 91 (266) 56-69", false, new Guid("843448a9-4bd5-4c80-be7c-b79ffe9f4154") },
                    { new Guid("f03f1144-c862-4c38-8076-def793fa78b4"), null, null, "+143 80 (446) 60-60", false, new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("f099a285-ef67-4308-9ceb-a5720ae24f42"), null, null, "+985 27 (647) 35-52", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("f1145aa1-9e50-46ea-ad59-0befcd7bc7f1"), null, null, "+929 87 (765) 34-75", false, new Guid("30e31307-3bbc-4483-bf55-601427ba031c") },
                    { new Guid("f16963f7-89a3-4608-bf45-f9bfe8cc8be7"), null, null, "+856 23 (906) 94-77", false, new Guid("f43ceb8f-345f-47c1-ae1c-c3b30cedc4cc") },
                    { new Guid("f1c56981-0080-46e8-870e-e180940379eb"), null, null, "+693 34 (740) 02-16", false, new Guid("e89130d7-0d62-4166-8eb1-3dcda5e79854") },
                    { new Guid("f21e6b48-1a00-4683-91fc-d7b592e78712"), null, null, "+464 78 (724) 51-48", false, new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("f23dfe4e-c80d-4508-a2bb-8bce4e8ab584"), null, null, "+140 70 (385) 38-08", false, new Guid("ac3e69fd-382e-4be8-8a5a-5fe084dc1baa") },
                    { new Guid("f3832d7e-6d6c-4eb7-9c47-3a00f7f4e632"), null, null, "+302 32 (762) 44-65", false, new Guid("5bd347b6-b8b5-493f-a6bc-58deaff2f656") },
                    { new Guid("f3fd83db-505a-4214-afe9-501f1a954742"), null, null, "+919 49 (236) 12-07", false, new Guid("a1c95292-cef1-48d0-a0b6-30645d678fa4") },
                    { new Guid("f40b3363-9978-4ff6-a72b-0083e153350d"), null, null, "+149 88 (554) 73-98", false, new Guid("5a5d60ee-8d5c-4cdf-93a2-95fe2655cc40") },
                    { new Guid("f42228c0-040e-4605-b33e-50fb60b4f738"), null, null, "+48 91 (249) 24-28", false, new Guid("af08d81e-3cb9-400b-8224-eb14952987e1") },
                    { new Guid("f5373f19-6207-457d-abbb-e42077b863c8"), null, null, "+644 55 (940) 51-55", false, new Guid("eec0ee6a-5dfb-4534-aeee-f7b2532966b7") },
                    { new Guid("f5612fae-a5b8-4365-b18e-9da179174740"), null, null, "+603 68 (541) 40-06", false, new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("f5c6625c-bd33-4872-a86e-ed3c2e599a4e"), null, null, "+235 69 (215) 73-27", false, new Guid("77f944f9-c758-4983-b702-656640bf5672") },
                    { new Guid("f6ad7076-6f2f-43c0-8ee6-3ce14c217862"), null, null, "+866 76 (256) 07-06", false, new Guid("fc5b0171-50ce-4e7f-9aab-4a172cbe2a44") },
                    { new Guid("f6df35fb-a509-4b0c-a37b-0d934ec0d054"), null, null, "+793 46 (304) 35-63", false, new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("f6f585cb-d99c-4bbe-b2f2-49330b96738e"), null, null, "+337 58 (240) 60-82", false, new Guid("d0104096-4d1f-467f-bbee-58d4127caa28") },
                    { new Guid("f713ca42-d838-44c8-bf2f-efd8d53cd59c"), null, null, "+895 57 (776) 52-50", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("f72bd215-def4-49cb-aa5e-d272956438f9"), null, null, "+912 84 (191) 73-13", false, new Guid("c8bf551f-48bd-453f-a3a5-bc53e552e739") },
                    { new Guid("f81ed3b6-a68c-4e6d-9ea3-3bd9b2b6e0ce"), null, null, "+880 06 (460) 97-97", false, new Guid("ed80cd22-e4d9-4bcf-98e6-2918fdc78d70") },
                    { new Guid("f885f59c-ff83-4aa0-b84f-a9e8f2d5c4c5"), null, null, "+259 92 (594) 82-99", false, new Guid("3bb7db8f-8fe7-42a6-82fd-4cde04a8fca5") },
                    { new Guid("f937bb03-4b15-4bd0-9b19-7e66e688897d"), null, null, "+4 93 (007) 42-82", false, new Guid("f2050c8a-8483-4fb1-90d8-b271ea159063") },
                    { new Guid("f93b7e21-e2f2-4e97-9e47-111fb46a430c"), null, null, "+556 20 (961) 90-95", false, new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("f9759716-66e2-4615-b889-0a2b5a38ab88"), null, null, "+931 88 (930) 16-59", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("f9778fd7-b52f-48b9-894a-a5f1b94a5777"), null, null, "+588 46 (014) 24-55", false, new Guid("104628c3-a62e-48cb-a6fa-9d1784dde446") },
                    { new Guid("fa0963a4-714c-4731-9fa9-6b9657410b63"), null, null, "+640 66 (442) 38-54", false, new Guid("a578ae78-81ac-4b41-bdaa-dab03c7271c9") },
                    { new Guid("fa169761-cf18-48b3-aa8c-736fd797d473"), null, null, "+262 92 (759) 18-04", false, new Guid("e506739d-a920-4945-906a-9a8a6bc1dc4b") },
                    { new Guid("fa275ab6-fc81-4ae9-8269-f42fd5412350"), null, null, "+445 50 (195) 24-21", false, new Guid("7a4e94bd-fa03-4c84-9fa1-6d684bf19b1a") },
                    { new Guid("fadd103d-8297-4759-965d-22b3784f3ef1"), null, null, "+303 40 (654) 73-68", false, new Guid("eae5197e-6974-4190-b4e4-085b2af871ca") },
                    { new Guid("fafda9c6-fc92-4644-9c21-65fd5070fe44"), null, null, "+512 38 (394) 59-62", false, new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("fb0e9882-be13-446e-b8b3-93ab7d1a1cf6"), null, null, "+528 89 (339) 16-76", false, new Guid("ba4e9530-0050-46fc-9d19-c319bf533845") },
                    { new Guid("fbf63d27-3023-4a7d-997f-a191d02aed19"), null, null, "+128 77 (164) 30-37", false, new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd") },
                    { new Guid("fbf6b080-f129-4d43-b7f0-f2542192aa46"), null, null, "+802 13 (423) 62-64", false, new Guid("c6cb6a90-5682-46f4-ba38-b1de2829fe26") },
                    { new Guid("fc7ba716-fff8-4e00-bb60-2d630242fa29"), null, null, "+586 59 (771) 78-57", false, new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("fc8d09c1-b4f7-4328-8ca1-bf8836cf1633"), null, null, "+498 25 (210) 07-88", false, new Guid("2061dbe8-ef53-4c2c-9975-b63e09df7ecc") },
                    { new Guid("fcd71eb3-02cf-4d5f-ba1d-050dce2ccc86"), null, null, "+954 27 (022) 34-01", false, new Guid("d7c2dedb-78e8-4746-81a9-cb1f530df1dd") },
                    { new Guid("fd56dab8-d19f-4666-8339-31c7e118e8d9"), null, null, "+816 25 (516) 59-45", false, new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("fd622699-7087-4d58-8ee6-18be4b0d8297"), null, null, "+591 18 (622) 51-53", false, new Guid("d6409d0d-5842-4ac6-81c4-dd566ddc4aba") },
                    { new Guid("fd97f652-0afe-4150-af87-41b39e4381a0"), null, null, "+856 39 (107) 26-15", false, new Guid("d8bda4f6-fb15-4ea7-b412-82dc2339710a") },
                    { new Guid("fdb4a155-77e6-4fc4-9354-f3b9d86d47d9"), null, null, "+660 29 (321) 48-22", false, new Guid("b8572d4c-b3af-4645-b753-4a766b4567f1") },
                    { new Guid("fef7fa0e-a56f-4c7a-ac88-49d4ba9a8e42"), null, null, "+63 48 (311) 44-11", false, new Guid("a5f7afe1-58d9-4ffd-b11d-12ae9b606e09") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("fefb1db2-57f3-4e72-8cda-019c98346d85"), null, null, "+986 60 (424) 58-77", false, new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("ff6362da-a1d0-4970-b54e-8ecb3d968077"), null, null, "+521 95 (213) 84-18", false, new Guid("7f6ddbba-d467-41f7-85e2-ca2091d315e8") },
                    { new Guid("ff9e0b53-bfe5-4d47-a4c1-8b6cd449ec0a"), null, null, "+168 19 (595) 66-24", false, new Guid("2554fa16-c2e5-459e-9d84-60e93ec32e5e") },
                    { new Guid("ffd5fd39-bce0-4e35-ab78-3890a5568ff2"), null, null, "+971 90 (838) 21-80", false, new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("08b41477-de18-4707-aca9-545f25a9c7c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("80307d1d-a21b-4fe0-a424-b2127428a01f"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("0f4b49ca-74e9-470b-8664-a9084a964df1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c11eac64-3f24-47b7-8c9a-37b99ae56028"), new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("11bdafb2-c83d-4613-a59a-13a2cdb7fb51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3f121fc5-4de0-40e1-9c5a-60a802961852"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("169ef690-290a-4094-8011-de86ac81fa9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0f2f45ed-4313-4ae0-a5e1-21d520e44fb1"), new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("1c2ba998-a4d2-4088-a0d3-c95c99bcade5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dc2b0c3d-b2fc-40fb-9477-f802bb4c128e"), new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("1ddd638e-64c1-4a35-90cb-4f3988ac9af9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c11eac64-3f24-47b7-8c9a-37b99ae56028"), new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("1e59f5c4-e945-4f79-8bdd-9e6eebc8dc8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fab39138-33fc-4d09-9f0f-a4e722f36d51"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("261bdcba-aca9-40ab-826c-0c500b9a5920"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d7a05560-11f6-4b1f-9036-e2c304e433ef"), new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("2f2d5cef-41d0-4ba2-81de-c5283614dcaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0027f29a-3b6a-4644-9de8-3290e92240f5"), new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("36ccdd7e-0165-40ac-8b72-914b07e18d98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50667182-1a19-47ad-99bc-dd1c72d49fff"), new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("3835907a-a065-49fc-bf7f-29b39f8002ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c43feea0-c9d9-44e0-b06a-9704d5a0f342"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("3dab830a-46f5-4d1b-a9a4-aaa10b202f55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dcf63ae4-ff1c-40d5-b22a-296503b34bd9"), new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("4121302a-9af7-4fe7-b300-d3ca25077fc3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("25428e2a-685e-4ada-aaef-77e95403e750"), new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("44882d8c-44d5-45c5-a5c4-0095b7aacb4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2352c00c-d9d1-4094-b952-8f79f78827e1"), new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("4567fc84-c183-4f7d-8ddc-eac9fd6c004d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("079aac52-9590-4abd-838c-09864d668b4a"), new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("483966dc-aa38-416e-93f2-d361231c748c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b3f1950d-4bcc-4ddb-95b6-9e953b009f84"), new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("517775e5-9e2b-4f19-ad97-90e4ce92dd6a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2352c00c-d9d1-4094-b952-8f79f78827e1"), new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("51c37cdb-4384-4c60-9ba0-c69e39daa356"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("039f43c5-7918-4f32-89da-329c48c10259"), new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("56154976-f712-4c75-92d5-406e01fecadb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e67b94e6-8c32-4871-a7f3-1ea2b799be99"), new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("585a8c6c-05c8-47f6-a298-da8d14122365"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("30f944dc-508a-4c7f-90da-a609b255ed4a"), new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("5919f73f-e853-471f-ac64-7d9f4f55ad42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0715ab04-87db-485b-915f-44808a18d373"), new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("5caffd0e-2d46-4d60-835e-b169e6a4d714"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("593f5685-f800-410e-98f6-11fe2dce4a76"), new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("614ab861-5b34-49d2-84cc-ec58ff2a9b1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0027f29a-3b6a-4644-9de8-3290e92240f5"), new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("63882d48-8eda-4c7e-8fc7-630518e5187f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("be6a0ef7-31dc-4338-a313-ad4233189dcf"), new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("6c9c239c-8527-4f26-9a8d-ec4af1e325d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0027f29a-3b6a-4644-9de8-3290e92240f5"), new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("71d408a3-c5d4-4eaf-8f01-aa47c0a5fd37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c43feea0-c9d9-44e0-b06a-9704d5a0f342"), new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("71dddf2c-13f6-40e0-91b0-3269f563e47d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c11eac64-3f24-47b7-8c9a-37b99ae56028"), new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("72109e50-b2c0-4924-a58a-252f81bc67d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cd1fc6fc-1057-4fd8-9b62-51cba4485462"), new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("723f44e0-b4f1-4899-aa56-258d3a844a4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dba41b51-5b9f-46ed-993d-f1d2d4e37827"), new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("7325a2c0-fba7-4c61-be56-454a69f23880"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("42f85f93-18ae-44ad-827d-63771aa95213"), new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("73de861e-8fc2-4c29-a666-d7f8e64741e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0b4a3440-b637-44c2-8d99-e6dc722858c7"), new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("74f01cf9-3c43-4b6e-9869-4cf0de7c95f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58f15b56-57ac-47c6-94db-1473ee4957e6"), new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("77322a21-956f-425f-877a-f62acb4b00a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("afbf5632-37a4-44cf-9145-1265ae1491bc"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("7791a0c6-9219-467b-a55e-03e05907c9ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa5c6825-8564-4bec-bd93-0e3686f5a7fa"), new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") },
                    { new Guid("8230951f-33e9-4b4c-b7f9-711f471b588f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("afbf5632-37a4-44cf-9145-1265ae1491bc"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("8727806c-2892-41c0-bbca-83c94853a898"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4089ae66-2afc-4775-9010-43235f78f075"), new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("8db7bc83-415f-4f94-a6e9-f521f881d679"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a28d7d71-ffd1-4c16-8d6f-64855b661b20"), new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("94847a3b-03da-4edd-b5f8-d65554d48145"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2bf42395-67a0-413f-99d9-e9813c1311f7"), new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("99d28e8b-378e-461f-afd7-18b851801bf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d9a99bc-63d0-456c-89bc-950c8a3a8cbd"), new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("a69bbeba-dd43-4d4e-a344-93f4574daf2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c43feea0-c9d9-44e0-b06a-9704d5a0f342"), new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("a6eed537-89a9-4ed6-9016-d15dcc7db3a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27ef23ce-0ac3-481d-992b-079af817f721"), new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("ba97c1da-6bb4-47ea-b01e-d44a395b15d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0027f29a-3b6a-4644-9de8-3290e92240f5"), new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("bb62bc80-c85c-4766-9771-d0a6e36aa8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d23e9cf7-ab89-484d-bd75-82c079bcd4e7"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("beef0b89-226c-423d-a6b2-26181929b3a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("afbf5632-37a4-44cf-9145-1265ae1491bc"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("c10fb0d6-07f2-4302-b541-a92f4a989c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d2abd3a-0eac-4a26-a0c8-bdc78d15dc2d"), new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("c29c0d51-8010-45ea-84b0-4695775fac49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dba41b51-5b9f-46ed-993d-f1d2d4e37827"), new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") },
                    { new Guid("c2d3796b-5002-4de6-8f13-2966c1319f95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a23e127a-1a3b-4312-b4d8-855c27eee818"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("cccad2f8-049e-4861-9c17-9b3343df0fb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b3f1950d-4bcc-4ddb-95b6-9e953b009f84"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("ce1a1796-7856-4250-b8f6-0971944976c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d7a05560-11f6-4b1f-9036-e2c304e433ef"), new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("d1a250b3-55a2-40ee-8a08-629841fcddd7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d9a99bc-63d0-456c-89bc-950c8a3a8cbd"), new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("d9cfcf54-4e7a-4133-90f6-02ea8a56f35d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("90a1f3f4-a382-4f41-b6dc-f087794f5b92"), new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("dba0b6d4-a611-460d-9713-73323231ad65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c43feea0-c9d9-44e0-b06a-9704d5a0f342"), new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("e2d971a3-65cb-49f4-948e-a23e67b0de9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0f2f45ed-4313-4ae0-a5e1-21d520e44fb1"), new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("e6200f7a-ded7-496a-929c-8c4a6111ff17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("42f85f93-18ae-44ad-827d-63771aa95213"), new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") },
                    { new Guid("edd4b909-9ab4-41e9-bc53-21623ef5d5a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dc2b0c3d-b2fc-40fb-9477-f802bb4c128e"), new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("f299e62a-a592-489d-88a6-92ad78161880"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e74fb442-b6aa-4baa-89b5-dbc63f01c24c"), new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("f44f0c9a-fd26-4b31-b616-63e8794c9579"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0027f29a-3b6a-4644-9de8-3290e92240f5"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("f5864990-4324-477c-a94d-9c90f71ad51e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d23e9cf7-ab89-484d-bd75-82c079bcd4e7"), new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("f8694a11-1e7e-497b-955b-999791637b31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e67b94e6-8c32-4871-a7f3-1ea2b799be99"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("fc2cda5b-705c-4879-ad30-a506e3dcf95b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a28d7d71-ffd1-4c16-8d6f-64855b661b20"), new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a250af-9a16-4a8f-ad54-954975a501da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a4fe0ea7-b764-43c5-9281-404d57d07442"), new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("02928f06-35a0-419b-93f5-9ed68a5ecedf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("38efbc1b-5e05-4871-9245-a2a864a7dbcb"), new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("095be804-02b5-4ba9-a188-c6699c41edc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("23e3e60e-b6ce-42f0-94f7-6461c3273e68"), new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("0cca07c5-0baf-4db3-99f2-69494ec2f1bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d725f129-76f6-48ad-9262-7f9f94c8687a"), new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("0dfd139b-4328-4bf8-903e-aeacb10e8a2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("215a7191-be73-43aa-81cf-02d73754378c"), new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("0f7f8a16-e004-4a80-a1f0-7679aab1e344"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0cf16ee9-2165-4cd2-b935-cbd881933d8d"), new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("1ab526b3-6fde-4579-ba82-286f0e4ac5c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fe1330e5-9694-4ab8-94ed-60c633dd3cbb"), new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("2b2afab9-8dd6-4452-a94d-acaea9901e50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3186f7ca-b445-4c64-b12b-6864b38c24aa"), new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("2d842ad9-be6e-43a5-899a-5fa6b4931a33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af2c0ba9-b15d-4aa9-98f6-cb578f90a5fc"), new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("2ddffe63-5740-475d-ab1a-db179cca6a31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("91f4f3c8-b105-4071-a41c-1089b736209b"), new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("30e1a753-bd4a-44dd-86d1-9b0d7f947ce0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("17be3e3a-2b0c-402c-acb2-c8b54e03572d"), new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("319e2984-1501-4e2a-ab7f-8a33b965912e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8b31bf20-6216-4a7a-b436-f956eeadbf3a"), new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("3629f0e0-5612-495b-8774-e9ee70e02729"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2dfa9947-880c-46c9-9a7e-05d063df8597"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("3d2d3353-9293-40e7-90d3-ed939b6149b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("17be3e3a-2b0c-402c-acb2-c8b54e03572d"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("45d2af32-e0fe-4c64-8371-d8a9e92c6861"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b719e179-93c2-41fa-ad65-81633dd2ca1f"), new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("4a5de7b8-3d50-4ed0-9a74-44b1a91abf3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3b141809-ef5f-4c01-b6ba-38002a272a27"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("4aface87-82cb-4325-a935-2c0eb70993b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bd68aab5-5ef3-4ca2-83bd-273d73823d6e"), new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("514f4188-a51c-4c12-bf33-795238724621"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("313ebcdb-8e44-4ace-a52f-e49bb254418c"), new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("5eb3010d-cab6-49b6-8f22-68ea9612099d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ec081b02-c43a-47aa-9116-792f9b6d243b"), new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") },
                    { new Guid("63756355-9ac0-4cf8-8ae4-5271f122a980"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2d7f80ce-d73a-4e7e-8ebc-5734b9d8676c"), new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("654302f6-cb3b-44e4-9e9c-bb07d7433174"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2a76463f-a397-4b2d-9e1a-e7c54c95ae35"), new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("71dcc962-ee62-4f71-952e-2a0fc1721e9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("23e3e60e-b6ce-42f0-94f7-6461c3273e68"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("721d4798-c670-47a8-a8ea-30da5b9208c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4bb4f776-f126-44f4-b21a-1693481f8751"), new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("7319e005-8631-46a6-9386-9d4bce5dc0ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f4bd6a84-2b51-46bf-bb28-f73be6740da3"), new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("735ae2a5-ad21-4c5f-b892-6d010a252b8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7ec65a6b-5273-45e0-b830-99582a0264eb"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("7aba946c-ce22-4d74-9afe-8420043b0c40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("81c00fdc-dad5-47f3-a1fb-12bb3f36b2d9"), new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("7c06b27c-802d-41e3-b635-07a368cb2db3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b719e179-93c2-41fa-ad65-81633dd2ca1f"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("7df94bce-4c05-49f4-a56c-8da421a5d235"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ec081b02-c43a-47aa-9116-792f9b6d243b"), new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("7f189909-c182-4d7c-8408-6accf7523fb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0188375f-ec8e-4406-90b4-169ab0528e21"), new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("8d84c26a-2ce4-414d-9366-2a1842c9de7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("23e3e60e-b6ce-42f0-94f7-6461c3273e68"), new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("8f0d1572-7a28-43a7-a5ed-ec0bb0ba28cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2dfa9947-880c-46c9-9a7e-05d063df8597"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("900579bf-0054-4e52-8279-008d09a6f2c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb02afdb-dc83-4102-948e-70fd0090fcf1"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("9163839a-1e5d-453a-90fc-c1e0046cc36a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("31074f33-6c9c-4499-9838-813b73aff399"), new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("a2132d3c-8f11-442a-81dc-beb27356cafc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8bd8e193-9a40-43e6-ba1b-3d28640c22ce"), new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") },
                    { new Guid("a5b15cb9-83fa-48ea-9948-83c7982858ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a53cf696-e974-494e-a560-27544f2d955c"), new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("a7f829ef-dfd0-4256-b041-9cab15728881"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e0a8db54-e06f-4f8d-9910-9e1885940fc9"), new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("a80c6a0b-da73-48b2-8d0c-db3ec70082a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d139098a-5af2-43ae-9c01-7052c5e587ad"), new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("b81562ba-633e-4353-bb55-1a9ce203896b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("65fedf5a-2b6e-4653-af03-0092b582a674"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("bb61df4d-dd74-41c7-98c3-c18e8b098559"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("011d914d-4486-4ad3-a3a7-88b35563e2ec"), new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("c4c7746b-54ca-4673-a5ca-5d93d1c61e82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("228ae616-6ea7-4a14-a72d-a2e88a21a3fb"), new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("c73b88c4-6706-4523-848a-7e21434bc052"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0cf16ee9-2165-4cd2-b935-cbd881933d8d"), new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("c8e40dcb-556d-4676-b32c-f70a06fce355"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("05e478be-a9e1-4f47-abe1-6aa2cf8b7457"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("ca6c68bd-2581-4bea-b888-41bcde57e80e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("17be3e3a-2b0c-402c-acb2-c8b54e03572d"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("ce8f1b68-945a-4355-943f-c7933123219b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af2c0ba9-b15d-4aa9-98f6-cb578f90a5fc"), new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("cf789c27-cc77-4511-9e98-510b54dd2c22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f51823d-0241-4ee6-ab57-23734bd64261"), new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("d01e2480-628c-4243-8d5c-138d630918e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("90861355-47dd-4406-abc5-92412c188349"), new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("d08feb1c-214a-483a-aed4-1c07bb6197be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("215a7191-be73-43aa-81cf-02d73754378c"), new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("d6db5dea-e9d4-4404-883a-a7c118c17bb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6d33c0e7-0856-4e81-b8ba-f2e11a87f53b"), new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("d79cb68b-be24-42a4-9381-19bc543bc75b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3b141809-ef5f-4c01-b6ba-38002a272a27"), new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("da22fe2d-2c61-4b5d-adaf-6fa74d3c3254"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3b141809-ef5f-4c01-b6ba-38002a272a27"), new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("daee6128-85dc-4e96-9099-432bf83eb479"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("387f031d-fb07-4dc5-be2a-f64f2e50a27a"), new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("dc48b007-fbc2-4f78-a30e-ebc265470dbd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("61794bf1-e887-4289-86c6-4deef6acceca"), new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("de3c61a6-dae6-4987-9638-bf41ef84098e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a4839725-5e52-4006-aa01-85329b0cde76"), new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("ee4a67e9-7630-4bed-84ea-029848391224"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("65fedf5a-2b6e-4653-af03-0092b582a674"), new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("f499f46d-028c-409b-a5c8-76d49dbb2429"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b10d3ee0-d3a3-4da5-be2e-0dbe2eeff26f"), new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("f4f6f373-2192-49c4-822b-14ebc823f98a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0a23f15e-8b8f-4714-93d2-2e5ff42568ea"), new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("f91dd43c-6925-40e6-a090-6b035e67d0b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("38efbc1b-5e05-4871-9245-a2a864a7dbcb"), new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("fadc6558-8a9a-469b-8e49-d999df562570"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb02afdb-dc83-4102-948e-70fd0090fcf1"), new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("fc822926-4e95-4544-b3e5-782e676c97c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fe1330e5-9694-4ab8-94ed-60c633dd3cbb"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("fe27dc80-106c-4ef3-bb18-3afed619c425"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e76f7601-df33-4a29-9acc-2f32ce2280b3"), new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("08285bec-009d-46e2-b195-1b8c81884e7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a77267ae-8e8a-408d-a7ef-f58a9dabb34a"), new Guid("b930078b-fd85-4335-8beb-db13fd3746ce") },
                    { new Guid("09832faa-df25-4d0b-91b2-5c546eb587fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48d4852b-def2-49f7-aca3-645eb92e2a39"), new Guid("7893ab50-b77c-4433-a04a-dc40c25aa2f3") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("14862a28-315e-493e-9277-186ae2387065"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3c148198-2789-4c63-a1b4-2c818edda1d1"), new Guid("6b1f032f-060a-4040-879c-9d1305d38b12") },
                    { new Guid("1535cff7-6647-446d-8f89-db8a16833cbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7480478e-c2db-4cbf-9d7e-bb368d9b0a68"), new Guid("de956589-c440-4477-908f-fd0e51a90148") },
                    { new Guid("1885c750-d329-4f77-afe1-22d5940a55f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d6895404-e81e-4f14-be7a-c89efacde006"), new Guid("9d7effeb-d071-4689-a103-74400c1c3344") },
                    { new Guid("1968a161-9a33-49d7-8ccf-0341134a5e98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa9fbc27-8acf-45a8-bd29-51f8a7a6f8a7"), new Guid("cf63157a-f923-4d1b-8a77-3506e413df2f") },
                    { new Guid("1c2e0848-a634-4327-a243-e9365e1c02cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0ec85794-295f-4d64-beb5-2f4589264491"), new Guid("9457dda7-9eaa-4cfe-bd9b-085b37cea673") },
                    { new Guid("3611520b-dfe5-4aeb-b412-ec0916e3a218"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("988fba48-f8d4-4075-8ac6-50916f546683"), new Guid("aa5cc0c6-b92e-4af2-90d3-79b7d4ad7b99") },
                    { new Guid("38e75556-6e96-4a44-a2d1-83d88e3070cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f84b828e-9378-43e4-908a-8a128166503e"), new Guid("d7704f32-3ba0-49b9-a1dc-759c069b0f38") },
                    { new Guid("3a5e424c-71d8-42c2-b695-4a8731b3d485"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("286d606a-42f0-457b-b87f-ddaeb079fd47"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("3aaaeb9e-1ef5-4b20-b7e6-c4d4561fc647"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d85771fa-d495-488e-8ccd-d979e4635f38"), new Guid("fcf82129-240c-4f17-9f56-8621cc73c8f9") },
                    { new Guid("3ef4fe9b-b3f4-4f16-aac7-0938b9487a63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f6c816a5-2f39-45b7-ab3b-5cd0f6e4f65a"), new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("41d556e4-531a-408d-9536-bdec9a68603b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("43fa609b-3cc5-410d-b1c9-45d1fbbc273a"), new Guid("e66064a9-81ed-4ee3-9a25-eb332e7102d9") },
                    { new Guid("43812b6b-9b79-4f45-abef-8c5cbc93874e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("60104021-6be6-4259-b8a9-c35ba72933dd"), new Guid("4d077cd3-efed-4e0f-a063-90099edb5770") },
                    { new Guid("4ac863f9-e3cd-4fe9-a51b-a94a3d541fd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f7b9ada-dde2-4279-bebb-7194671e2b5f"), new Guid("1f7c8399-8b87-4556-bba8-27ddc97daf2e") },
                    { new Guid("551ca345-2662-4c0b-93e4-3fe30aab9c0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a8b12127-2e57-4a28-a33d-d9a77020c2cc"), new Guid("8da5ff90-595b-462a-b9e9-153b0f264e32") },
                    { new Guid("609833c2-2b5c-4a76-9d8a-996591e1dd9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2cb38dc0-699a-4b32-8913-897097108132"), new Guid("0fbf0853-1a25-4279-9e05-bd843acf0b4f") },
                    { new Guid("60a30f29-5f25-4637-8fc9-fbc3fa6f2923"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f6c816a5-2f39-45b7-ab3b-5cd0f6e4f65a"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("658010fd-ccf4-4f50-b235-6ddf81b3be9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b1cddaf0-4d5b-4e23-9320-4529f2425184"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("6981a95c-4217-4edb-9c8d-062df03d28cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("06ddbb5d-74b3-45ae-9a15-378e36443134"), new Guid("19341891-e9b6-407e-aea5-b35513589e26") },
                    { new Guid("69c4645b-e537-4834-9168-e2e67869a962"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ac23bc6b-0953-43f2-8bd2-281b45c32176"), new Guid("26287e5d-b3d8-4c3c-8a28-659f417068a8") },
                    { new Guid("6e04fd94-83d5-46cc-bcd2-5ac37793dea3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("828b79ae-7895-4329-a86a-a5bdaa9f894f"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("6f7bcda9-c952-4b81-a617-300a94b99643"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6dc6fa19-775b-4ed9-8cd7-45ef2e05bab9"), new Guid("34321ead-c549-4cbc-82ce-a5eb2d49b178") },
                    { new Guid("793803bf-9fde-44dd-b6d6-28c2c2f74788"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("828b79ae-7895-4329-a86a-a5bdaa9f894f"), new Guid("d8d1525f-e931-4e18-a476-365f02c6e363") },
                    { new Guid("860cf3be-1acc-41ee-bd27-16f65607a39c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("06ddbb5d-74b3-45ae-9a15-378e36443134"), new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("894a1880-b6e7-44c8-83df-3a9ca5e0dd28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7480478e-c2db-4cbf-9d7e-bb368d9b0a68"), new Guid("f7e17b44-d38f-4cde-8152-13b3d946d72b") },
                    { new Guid("8c545e99-ef86-418b-ba83-1f4c4072dd15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("12c50288-17da-4706-9afe-086240c1601d"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("8f9029d8-bf0d-4f19-a665-d20748c71118"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d85771fa-d495-488e-8ccd-d979e4635f38"), new Guid("e9f3eeab-369f-4fa8-9494-e2a969dbda1d") },
                    { new Guid("94448049-106a-4291-845c-9e36b69a3b93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("266cf96a-ea62-4949-853b-ed76b7792939"), new Guid("28e4ff13-6fb9-4f9c-aac6-e8c05a787d4d") },
                    { new Guid("9fc3193e-c762-44e6-88c6-2abce35406cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5474578e-fb64-4cfd-9f94-150a9aba1b28"), new Guid("e352c3a5-25cc-4796-8c60-703443aad68b") },
                    { new Guid("a566dc32-1ff4-4e7e-8741-3d4d371914b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5f93d2c4-cb9b-4f40-bdca-1862d6155c9f"), new Guid("24460a5a-e2e7-4751-9188-6a7cb632f2da") },
                    { new Guid("a7aef1c3-1019-4a0b-9de8-7460823f6288"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("88320527-9f6d-41ee-bdd8-88b2b4dc8688"), new Guid("0d1a2a26-7dd1-4c38-b7f2-6c1fbb8c00f9") },
                    { new Guid("a84f7eb4-45e2-4b79-af74-7b74cb42463d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48d4852b-def2-49f7-aca3-645eb92e2a39"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("a8dc5aaa-8dc3-40fc-9c4c-f5d1d697cf1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f4552fb5-fd3a-47ce-952d-5d320761e6be"), new Guid("77fd4e19-452f-4507-80bb-64ffc0d6b6e4") },
                    { new Guid("a90fda91-92bc-49b6-aa73-d8b062017f81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48d4852b-def2-49f7-aca3-645eb92e2a39"), new Guid("b1623125-482a-4a7c-b43a-768c4ddd812a") },
                    { new Guid("a99e31e2-4e44-4ae0-a2db-fd59ae774e5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb2f205c-9a3c-417d-8abf-b599db1c2c57"), new Guid("4e0c1912-bc35-442a-afce-e8c679ef210b") },
                    { new Guid("ab6dce97-5e6a-4476-8bc2-09a29541e84d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3ca454a6-7bf6-47ad-96f5-ea1f47f8abf9"), new Guid("bc9593f0-1c77-4500-b5a3-b3de2a36f11b") },
                    { new Guid("b13def2d-b125-45c3-a8dc-b59cf523cdf6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f4552fb5-fd3a-47ce-952d-5d320761e6be"), new Guid("eb5f4ec1-7022-4df5-beed-6bb04f31c6b2") },
                    { new Guid("b1ffb98a-aba9-45e7-9c9a-126354c21df8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bc9574d8-1db5-4352-9579-826f7e5348cf"), new Guid("0ef47157-46e9-440e-9f72-08b2772beb75") },
                    { new Guid("bce3de64-7b68-4389-bbf6-74a4287f9551"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("06ddbb5d-74b3-45ae-9a15-378e36443134"), new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("bd18f5bf-0cc8-40a9-975e-c8039684b186"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f7b9ada-dde2-4279-bebb-7194671e2b5f"), new Guid("b738ba4a-67e6-46e7-a96d-61371262722a") },
                    { new Guid("c0bbc445-02aa-4b9a-87fd-1fef2a608f73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d9ed6a0b-20db-4de9-9a25-2d7791712e06"), new Guid("251a9b49-0b0e-498a-bc22-ae474c6b0498") },
                    { new Guid("c2e64bd2-0d4b-4311-97eb-bef318b0ea2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6028ce47-bb9e-402b-ab09-a0c9bb505ea9"), new Guid("23c64b60-1ae9-4c27-9444-eeb81dd84c16") },
                    { new Guid("c38e0e1c-7b4d-4312-8144-38c20ea5080e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7480478e-c2db-4cbf-9d7e-bb368d9b0a68"), new Guid("f63d8fa7-56ed-479e-ba40-4aab5ab7cfd9") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c7b6a4e2-5227-438a-b56c-15c39e650871"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("adda4a15-acc7-4dd6-ba6e-fb9afb5c68fd"), new Guid("428f02d4-137c-4471-9a00-2d60009e0b8a") },
                    { new Guid("cedb76e8-f95d-4d2c-84c0-52fa5b6d4b79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3dcb1fa4-524b-4eb5-917f-a9df366764c3"), new Guid("98ec5653-7775-432e-9be5-3149a15fca62") },
                    { new Guid("d2d42779-fe00-4d54-ae3d-51a3438b9c39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3dcb1fa4-524b-4eb5-917f-a9df366764c3"), new Guid("35187412-3a05-415f-8523-ec24e84b1221") },
                    { new Guid("d87f9511-adb9-481f-82af-7885a07c8293"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5474578e-fb64-4cfd-9f94-150a9aba1b28"), new Guid("dbae81a4-571a-40f6-bef1-84685692cfa1") },
                    { new Guid("d9dcf8eb-718a-4c9e-8470-9d59917793c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9924afe1-dcd5-4ef6-9590-1873684f3884"), new Guid("edf2d84e-19dd-4b52-9813-0ab8619352e1") },
                    { new Guid("da596f30-4465-4d67-acd3-817d6287e7df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d85771fa-d495-488e-8ccd-d979e4635f38"), new Guid("2d08a1d2-0b57-4fc3-8689-ce7698f53c1e") },
                    { new Guid("e160a2c6-b855-4e21-94cd-e3d845f3c1ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a77267ae-8e8a-408d-a7ef-f58a9dabb34a"), new Guid("d37ee9e4-d40a-47eb-8420-ad671ef86ece") },
                    { new Guid("e338db4b-ba73-4784-9506-5f081deffb0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f6c816a5-2f39-45b7-ab3b-5cd0f6e4f65a"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("e3eccee4-5115-49ee-ac54-730d7a4d4a91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f7b9ada-dde2-4279-bebb-7194671e2b5f"), new Guid("4bd39cdb-d6d6-4489-ae00-bb26f5f71edd") },
                    { new Guid("eb312dec-9484-4527-b75f-6ed0966363e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ac99d53e-9359-4c8d-b403-26bce8b4a5fb"), new Guid("8a1ff123-8ef0-4999-9738-26a6ab033689") },
                    { new Guid("f7fad0d7-129e-47ea-882a-9324f4a7dc7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("adda4a15-acc7-4dd6-ba6e-fb9afb5c68fd"), new Guid("c425a8f6-9197-4d99-a241-3bcaec0b2ab1") },
                    { new Guid("fa1ced5e-e0ef-474a-806c-3a1ee64acd90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("80b81674-830b-4cbe-aa4d-8c76cecb1616"), new Guid("04ee67fb-4b20-4ab6-94d6-9a8e42576f2a") },
                    { new Guid("fc0055a4-b982-4246-9fec-009eccb262fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("37344190-f549-415e-a2b0-9533e8c59a06"), new Guid("4e0204f0-eb29-4713-873b-136318951b1d") },
                    { new Guid("fc23facd-0f6b-45fb-a648-602c8e6683fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ac99d53e-9359-4c8d-b403-26bce8b4a5fb"), new Guid("730094f2-c549-4e04-b5a9-761af8d5725f") },
                    { new Guid("fc6259b0-f562-481c-b59e-707aa14828bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("37344190-f549-415e-a2b0-9533e8c59a06"), new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") },
                    { new Guid("fd14a982-ec2c-4cc1-b7c8-9a1df213df8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("98764152-0f08-4e92-a0f9-614a62693135"), new Guid("60bb9160-18e9-4302-9e15-44aa4126967e") }
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
