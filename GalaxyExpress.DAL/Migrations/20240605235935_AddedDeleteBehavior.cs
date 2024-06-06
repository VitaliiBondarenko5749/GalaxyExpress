using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.DAL.Migrations
{
    public partial class AddedDeleteBehavior : Migration
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    ParcelMachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    PostBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    PromoCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    IsSender = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
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
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), "d954a14a-06fb-4a63-9b76-6f940706f905", "User", "USER" },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), "398c766f-98f4-439c-808d-2c3bc9aa4ddf", "Admin", "ADMIN" },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), "746e0c9d-6d18-460f-a10a-359613717371", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0136c022-fcf1-47a8-a481-723709054ce0"), 0, null, 87.38454453609270000m, "d56461e9-9cc2-4c5f-bf04-4f5e8e03f123", "Arnold", "Arnold", null, "Auer", false, null, "Arnold.Auer79", "AQAAAAEAACcQAAAAENYyKtnrmL3sihcEzkyGQftKYthmAI/bkVHzYpyF6A4/K3VbWlNdbPxvn9OljeOn4g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626"), 0, true, new DateTime(2007, 5, 20, 18, 57, 18, 66, DateTimeKind.Local).AddTicks(5564), 362.7516315517340000m, "76852e48-5c84-42a1-a74d-6858d391d4cc", "Luther", "Luther", null, "Hirthe", false, null, "Luther.Hirthe", "AQAAAAEAACcQAAAAECNV+mqVyNLB1f7ZM8zOmA7CXyXfl21sLmQmBgG//5p+nVhw6MGcW32e32EbLMptuw==", null, false },
                    { new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd"), 0, true, null, 62.085119346560000m, "766d9480-b83b-436c-8d2a-a9abcf374c88", "Candace", "Candace", null, "Hilpert", false, null, "Candace_Hilpert5", "AQAAAAEAACcQAAAAEEsPNSQ3ziD+QFe0iZDk1kh1GWIQ3wDFw7Ec8xh3CzFUfsNCn7MgmwKIONhr3PP+iw==", null, false },
                    { new Guid("0462fe55-138a-4c03-a20d-8251dee6c206"), 0, true, new DateTime(1984, 10, 15, 5, 47, 27, 49, DateTimeKind.Local).AddTicks(8464), 911.722676750420000m, "1efccfdb-8ca5-4ebc-8f3c-532afbe7e66e", null, "Austin", null, "Murazik", false, null, "Austin.Murazik", "AQAAAAEAACcQAAAAEB3x2WQjJbepTtELAWtN+tTfHqdpb/LChtktjj1GVF2Tvk+prZW5u8OEPxJuvq34yQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("049885cb-e0f2-4131-a44d-71fb5816c410"), 0, null, 570.4460767398290000m, "a2372225-c245-4af4-bcb3-18a32e52eb73", null, "Eunice", null, "Jenkins", false, null, "Eunice49", "AQAAAAEAACcQAAAAEP2g0AqQ5YEWrIsc8KGAQ9Pt+JIn6W7yqaUYYNKeoz+L47o83ZGJCml8gFU7WGyrtg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037"), 0, null, 489.2755337976440000m, "5e5f8b56-1e86-48c6-8899-61763773ec1d", "Amy", "Amy", null, "Wyman", false, null, "Amy.Wyman", "AQAAAAEAACcQAAAAELEa/Mn4sLktESitYyjbZ7Og5C7W4eymgNxC+o/g65NGuKE914lA7AgunqJQWUTPlQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0511de28-2afb-4492-a1a6-ca490859b247"), 0, new DateTime(2008, 3, 22, 16, 53, 34, 288, DateTimeKind.Local).AddTicks(3024), 518.2854734937730000m, "2f422317-9e22-4481-8c7a-7bcfa3c78dc9", "Juan", "Juan", null, "McKenzie", false, null, "Juan_McKenzie89", "AQAAAAEAACcQAAAAEBCtJbJKUsL6HCAOAlH5UoxNRaQtwkrIVkwBckVUZ5nhU6zv7NNAOj60Y2mPCp3kgA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("05d888a7-8474-4565-b751-a89df2400346"), 0, true, null, 928.3534778954610000m, "66a86acc-b92c-4fb0-a4b6-d2200871132b", null, "Tommy", null, "Wiegand", false, null, "Tommy.Wiegand93", "AQAAAAEAACcQAAAAEIVawxjD7BsA083yMKrgSzRfFfqdum/gGfK5i/mX0MYb86zLA+K/LdyrsQHRRy/J7A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95"), 0, true, new DateTime(1997, 12, 3, 23, 50, 1, 48, DateTimeKind.Local).AddTicks(6161), 752.9348597781980000m, "ce67b5e6-544b-4725-b5bd-c24523039313", "Greg", "Greg", null, "Hauck", false, null, "Greg.Hauck24", "AQAAAAEAACcQAAAAEDvIS1TJfl8aFaAwHgoY6o5NZfTjRVZrFUYQ3KvxBH3EZWn9/nwcoyPQJRDjAA1lfA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6"), 0, null, 843.7741741152110000m, "1d2ef938-00b6-4efd-a077-03e77e880069", null, "Horace", null, "Baumbach", false, null, "Horace54", "AQAAAAEAACcQAAAAEHnxkMnZdib7rFezJi9XAXlswCXSAT6rFlGP+z9QntwfGABlxpSu5aqOS6fGtNIf1w==", null, "NotSelected", false },
                    { new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6"), 0, new DateTime(1982, 8, 4, 9, 21, 51, 101, DateTimeKind.Local).AddTicks(946), 910.5356006081780000m, "7dd5ad31-d4cf-4dee-b9bd-2cc3f385f9de", null, "Steve", null, "Adams", false, null, "Steve.Adams4", "AQAAAAEAACcQAAAAEGOtNsNllRwnJoT/95aMF/bzW+Mu/7e+Hx4+lic5INFKHnBo1R6sj4vuwTYanPFZnQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a"), 0, true, new DateTime(1999, 4, 10, 6, 47, 53, 262, DateTimeKind.Local).AddTicks(7468), 829.4542944760920000m, "dc460cd1-2015-4b66-80a5-e4d80d5c1ae7", null, "Penny", null, "Mohr", false, null, "Penny5", "AQAAAAEAACcQAAAAEBSO1FkZSKV7W1yG0PHrs28RL1ul7Qdpqf+KhnQoLSGwexfhpRz4kr1tmAmFr8YIIA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0823436c-27ad-4402-b5e2-b17efa08505e"), 0, null, 453.4683378867860000m, "63cbffd0-afe0-4af1-bb14-c56ceda15e54", "Roberto", "Roberto", null, "Leffler", false, null, "Roberto32", "AQAAAAEAACcQAAAAEIEuPbapOAearD3cMkejvQg1e4Q9mZ/fDag2/TpjVaftMp+mQJQebKwnevEluBf4Hg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("08e83522-0abb-4778-9027-c86ca1a0a624"), 0, null, 396.7787905632910000m, "c53f9cba-28a1-4996-80cc-ace4fd316a18", null, "Allison", null, "Maggio", false, null, "Allison_Maggio", "AQAAAAEAACcQAAAAELxJTF4MZ7qB7RRTJk2Sg0ofzHm3vMt/6eLTUE0WfCMo9lrw0L098aSz8S+yM1Jl8g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b15ae39-ea71-49c5-a132-1475793930aa"), 0, true, null, 221.5662635715170000m, "e5234bbd-8b6e-45eb-831c-062713d46de6", null, "Nancy", null, "Hagenes", false, null, "Nancy76", "AQAAAAEAACcQAAAAEHdnNnP/ZLd+w8r29OVW7rTXlVbE6OghSuqCjLHpfBPFJRfq3PX3E84PqTCDPZajfg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a"), 0, new DateTime(1938, 5, 14, 1, 52, 41, 162, DateTimeKind.Local).AddTicks(5401), 638.7278512928960000m, "d72a5194-a2ed-47ab-a1bc-46f77b300566", "Ashley", "Ashley", null, "Mills", false, null, "Ashley.Mills79", "AQAAAAEAACcQAAAAEOpUXvSitlgzUmRtagEvP3zz5Fw6uxAKXajqtFDXj197z7ID7iFo5pPKE8Y2IWvpiw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76"), 0, true, new DateTime(1944, 7, 8, 3, 20, 44, 726, DateTimeKind.Local).AddTicks(4893), 464.7926892315460000m, "946f3c66-813f-489e-afce-2e87ea404b73", null, "Hugo", null, "Corwin", false, null, "Hugo.Corwin", "AQAAAAEAACcQAAAAEBIitV2eY6zM/vpaNeVrl3laXOYSoDkvp3I+kV73kmr63Mfy4dr/75u99riF0Y2Miw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9"), 0, true, new DateTime(1936, 6, 8, 18, 40, 10, 558, DateTimeKind.Local).AddTicks(8264), 512.0009173118970000m, "dc1b72d4-70d6-4e2a-8525-7acf841eb52a", null, "Gayle", null, "Schowalter", false, null, "Gayle86", "AQAAAAEAACcQAAAAEHmxDtzxbCMJkM4a+iJvYxHVyS6n9FXJbzyEKi2zDZ5tXMDieIeH8dQdAJ5xWnMI0Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1"), 0, true, null, 958.3757479215970000m, "b285a619-27a7-468c-a63a-58da54965e29", null, "Shirley", null, "Welch", false, null, "Shirley_Welch", "AQAAAAEAACcQAAAAEPMr6orjk9ijupiI5OepXu1aSx5KQ/H0LyVJFzaFVXlL24y3kfRdMZFmy7VwilpQgw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("12656ae7-3922-41ca-b159-f79b439a354c"), 0, true, new DateTime(1970, 11, 18, 16, 42, 6, 516, DateTimeKind.Local).AddTicks(9333), 761.6755901187540000m, "ff359b3f-0ff7-4f3b-994a-0c9dbab84a48", "Ollie", "Ollie", null, "Leannon", false, null, "Ollie78", "AQAAAAEAACcQAAAAENwRluh9B2QB/RfRAOsvNJu1V41Db+FE3iH9VNyHh4iINGtlXuAA2VMBdHiMOfH0eg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("12b74093-45e4-451e-b1a4-f4797f48c780"), 0, true, new DateTime(1979, 1, 3, 15, 57, 0, 788, DateTimeKind.Local).AddTicks(4930), 61.83994963781570000m, "03c26220-295b-4fe4-b8dd-acd451599c4e", null, "Thelma", null, "Kozey", false, null, "Thelma.Kozey", "AQAAAAEAACcQAAAAEND1pp+u92c73Z0+DT4YdFpRJIue7cobJk234FA2cc2izSmwD8GjSGSF2/SCDa9SAg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4"), 0, true, null, 859.0491742416230000m, "94b14cce-0867-4aa3-921c-de1d07f4db49", "Mathew", "Mathew", null, "Jacobson", false, null, "Mathew_Jacobson59", "AQAAAAEAACcQAAAAEJoz5r1yuqIrg09R9E4EMNNhwoGCD4QwcbfXweEbrlYX/Me7Kj7v/mgqknxSP6/8bQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea"), 0, new DateTime(1998, 10, 3, 1, 44, 36, 228, DateTimeKind.Local).AddTicks(5722), 742.7596825820240000m, "49eea073-f18f-456f-bd0f-271575f88ddc", "Kyle", "Kyle", null, "Kovacek", false, null, "Kyle_Kovacek", "AQAAAAEAACcQAAAAEMrCxkaajlKnpxej89G+v2JP0Ad7bKb/ICLHi6hWg2S6FqGCVh3EzXZa+2WR8S3tlg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("15ff126d-c656-4885-a732-88f20e2b2157"), 0, true, new DateTime(1962, 7, 12, 16, 42, 12, 166, DateTimeKind.Local).AddTicks(1962), 969.1069277070960000m, "4a16a9f8-c901-4a59-8446-6da72b3b0a22", null, "Troy", null, "Gorczany", false, null, "Troy_Gorczany", "AQAAAAEAACcQAAAAEMmQCi4vnAKuJAKiHpO6lXZJSrdAjp83lqUSuzT11Y9AltE2fsubdwSpZu/qHnJZ5Q==", null, "Female", false },
                    { new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d"), 0, true, null, 159.2760845120080000m, "55231a6b-76d2-4b04-b2ab-8ec0363bd326", null, "Jesse", null, "Hermiston", false, null, "Jesse.Hermiston86", "AQAAAAEAACcQAAAAEM0E0+2cWzHWeDMvkrEJj6HPpnU13PRfyr4hOv8BMlRXekjpSZsujDSQ6MFWBew7Rw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63"), 0, new DateTime(1947, 8, 2, 4, 9, 4, 718, DateTimeKind.Local).AddTicks(9596), 821.2822304479430000m, "f92e85ad-7e9d-49d9-ba9f-c460df7e54a4", "Miranda", "Miranda", null, "Ullrich", false, null, "Miranda82", "AQAAAAEAACcQAAAAEF5J1awivTZJT3vz5q7WEcIa1tNza6ipyawPNoDfE9MPwHudKT6VcI2Ke6NUXzwt/Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473"), 0, true, new DateTime(1938, 9, 2, 19, 30, 43, 35, DateTimeKind.Local).AddTicks(8804), 740.4690422209220000m, "9053c2c6-138e-4866-9fe2-7ed48734d898", null, "Marty", null, "Cormier", false, null, "Marty_Cormier58", "AQAAAAEAACcQAAAAEIfhp6Ahn33V9CQDslOdTtl9i6KZD93HPYKFKr3evyrygQiAo8N34YH2eTlKxFrSsg==", null, "NotSelected", false },
                    { new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330"), 0, true, new DateTime(1931, 2, 3, 4, 52, 48, 434, DateTimeKind.Local).AddTicks(601), 643.496008274220000m, "a20b83ef-b65b-403d-8c04-41844db12a6c", null, "Valerie", null, "Gislason", false, null, "Valerie41", "AQAAAAEAACcQAAAAELtgdGUtj5xuVP1h7kl7zPJom15EfEOLz1b6AbqPGHWe/+oE6nPWTArmARgGF4WliQ==", null, "Female", false },
                    { new Guid("18685782-706e-445d-892d-19c39dd67689"), 0, true, new DateTime(1967, 2, 14, 5, 19, 44, 548, DateTimeKind.Local).AddTicks(9177), 512.9913283443040000m, "d24f86a2-b7eb-4320-b24a-188f2805a7c7", null, "Joanne", null, "Pollich", false, null, "Joanne46", "AQAAAAEAACcQAAAAEC8q/B/pZICSYQQ5L5jirm70zm8aYygiV3UAzZk+4e1mT3XjbBHXB7OVGI5ikxPZYw==", null, "NotSelected", false },
                    { new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6"), 0, true, null, 779.7362995698170000m, "6509f3f8-f6d1-4b40-bf96-9653a2f66976", "Mack", "Mack", null, "Hessel", false, null, "Mack_Hessel17", "AQAAAAEAACcQAAAAEJDRI457C3ppsvKSZ8wsZslerRVdJQUnSCmP/hC87U5Kdm6pUACeSgfEFHg+KYA1fA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132"), 0, true, new DateTime(1975, 7, 5, 0, 14, 53, 692, DateTimeKind.Local).AddTicks(494), 102.5492004458880000m, "dd1b367c-f122-4692-a9ce-58bfde4dfbb4", "Raymond", "Raymond", null, "Ortiz", false, null, "Raymond_Ortiz", "AQAAAAEAACcQAAAAEKpzbUhaZvI8QUvbyOgfmw4kKUjHsG1MsngxYLdGmNdLViN0f0uiB6MEvEGcWI1XSg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4"), 0, new DateTime(1993, 8, 15, 15, 32, 28, 988, DateTimeKind.Local).AddTicks(8153), 822.8143538905840000m, "f0975bda-4c2c-4f68-9f3d-cd83721b2ee2", null, "Maurice", null, "Christiansen", false, null, "Maurice.Christiansen49", "AQAAAAEAACcQAAAAEK2F0kWSgcfPflHBuWp8H2zQUWeiM5CpPqt7v+NNnPFK9B41dNX/dtzT0KTlSWAZBQ==", null, "Female", false },
                    { new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c"), 0, new DateTime(1945, 5, 9, 6, 50, 16, 335, DateTimeKind.Local).AddTicks(7696), 650.985993666920000m, "e45db26c-1cc4-4449-9ced-066d8e0946bd", null, "Ismael", null, "Bode", false, null, "Ismael56", "AQAAAAEAACcQAAAAEOZIlM7oQPsxAKISuqtPrzrbcLILBGhDwVXV4Rx1TBarZjxDIargQLswLHhpSlsSXQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa"), 0, true, null, 626.1084713602380000m, "07b4917f-0664-4415-9463-e11011e0a265", null, "Paula", null, "Kohler", false, null, "Paula_Kohler71", "AQAAAAEAACcQAAAAEFBvP2zpa8xhOiXkZmZ8lfKBsRbwIwPd5cxow/yc+bQbHtignYL/9o1+WHQ32bt8iw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29"), 0, new DateTime(1954, 1, 27, 23, 16, 49, 738, DateTimeKind.Local).AddTicks(1882), 279.294136996970000m, "f9a9167f-7d63-4d5f-b8e2-5106cdc7f72b", "Brent", "Brent", null, "Feest", false, null, "Brent11", "AQAAAAEAACcQAAAAEDS8e4/pnBCG6EqJBuGwEd9xHdCjkkVZnBatoH5drB/yc4ghkNcOKqbnB+e/e+Tbew==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405"), 0, null, 233.5011958931170000m, "df2f418e-a5da-4864-a1dc-214497eb21ed", "Faith", "Faith", null, "Mohr", false, null, "Faith11", "AQAAAAEAACcQAAAAEBn6UWguONFF1jYRXF7WoeHv/kRESW48Rw6h5DF+wTbPtynzNVaG65xKxawN61vSVw==", null, false },
                    { new Guid("203cc97b-91be-4474-b881-e9776da21af9"), 0, null, 826.8202158965190000m, "1a8c3859-8a32-4f2a-b53b-e9ceaf49232e", null, "Clint", null, "Mayert", false, null, "Clint_Mayert", "AQAAAAEAACcQAAAAEMzvStchPYJUJTmKSuWmoh9RYbkv2zwgSHKbDHPDf2+ARh4cU25TREtKjPjHG8+h6w==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833"), 0, new DateTime(1992, 7, 17, 11, 40, 1, 215, DateTimeKind.Local).AddTicks(9234), 57.20788847156470000m, "8e31763c-221a-47da-8605-4d18e829d5a3", null, "Oscar", null, "Kreiger", false, null, "Oscar_Kreiger64", "AQAAAAEAACcQAAAAENlOyPaga0uEo8Uem3X6jOeha5tnih6JsExDY9iPOQeXymgQ6RZTDUq6fJo80Jn9gA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738"), 0, new DateTime(1962, 1, 13, 17, 33, 20, 7, DateTimeKind.Local).AddTicks(1436), 430.3713559282110000m, "460ac0b6-fe6d-44b9-9c58-750056d90996", "Abel", "Abel", null, "Cartwright", false, null, "Abel.Cartwright", "AQAAAAEAACcQAAAAEB0cyZCZXh/ud+ATD5YIgysqegXg9Aky0Xk0Gy2Pb2Qbo6s0Y7l8xZeMAbeoIupjtA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655"), 0, true, null, 622.8836940445580000m, "c5249b47-66b6-43fd-be5f-4fa4d2a861c3", null, "Kevin", null, "Bashirian", false, null, "Kevin.Bashirian82", "AQAAAAEAACcQAAAAEGbmqjAakrSlK1buZW5XCMCFybanVhZMtQNziVOZKW2qYaggfw6CqT4YS5HUefVXUA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884"), 0, true, null, 395.9532073789080000m, "9a5ad8a9-43d2-477f-9c74-505fdb08ebf9", null, "Ellen", null, "Hermiston", false, null, "Ellen.Hermiston10", "AQAAAAEAACcQAAAAEHKOAjtcsY7wyX7hDuUKM4owZ0IOhYUEUvqbGbXHN025cDn0DntiT93wzei4DlO3Ig==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba"), 0, null, 134.7067618100720000m, "ad019b11-c38e-4674-8b64-d52c1527053e", null, "Darrel", null, "Schimmel", false, null, "Darrel_Schimmel23", "AQAAAAEAACcQAAAAEGu5GqhWp5ZmjKDO0cLrN1cAqK30Dw/AtXJFyQLdfHxBUquY1RiO+I/AV66fdoMrtQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc"), 0, new DateTime(1939, 2, 25, 22, 33, 54, 207, DateTimeKind.Local).AddTicks(9543), 424.4742258172390000m, "1e91cf17-3588-4215-ba11-270e8cffd595", "Camille", "Camille", null, "Carroll", false, null, "Camille_Carroll71", "AQAAAAEAACcQAAAAEE7Ygm5kWhJSuujCsIt1N9k+IpXzcB3XxOV4sGeOLUgcmg2iSeIjBqbGJi/gH0nK2w==", null, false },
                    { new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828"), 0, new DateTime(1931, 8, 18, 16, 35, 45, 891, DateTimeKind.Local).AddTicks(361), 762.4426634953350000m, "85dc15d6-b2c9-432d-aab8-20bdad244b14", null, "Caroline", null, "Upton", false, null, "Caroline_Upton", "AQAAAAEAACcQAAAAEMTk+L7sidDkjG40OT5F5I4ZKPwqb28dMk6CgllhKAXiya/rdQcSNpVI2kYhDB64SA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51"), 0, new DateTime(1995, 2, 10, 22, 18, 27, 848, DateTimeKind.Local).AddTicks(4684), 764.2791437305960000m, "dda9e896-db44-425d-8f81-19e7c96d431f", "Otis", "Otis", null, "Smith", false, null, "Otis_Smith", "AQAAAAEAACcQAAAAEF08Ga2n/XckErtYBrytdJXDns/aO6fMY/bdf4zBaqANaEUHuBChAko3S86Nz+xKtQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88"), 0, true, new DateTime(1983, 5, 6, 16, 5, 53, 516, DateTimeKind.Local).AddTicks(2584), 387.9890948978610000m, "16d763f6-48d1-4eb5-a059-cf753b122f79", "Charlotte", "Charlotte", null, "Ritchie", false, null, "Charlotte.Ritchie76", "AQAAAAEAACcQAAAAEN4NQusH+FTKhoCf6ca6SjpiIwaUy38RZLWD4aTIUYtNHSiUgnI+RGtO7FvAelKxrg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("28f12604-451b-425e-ae23-1db801053b3e"), 0, true, null, 696.4063016534030000m, "90ce11c0-5e1c-46d8-8244-769939f8e1e8", "Howard", "Howard", null, "Hilll", false, null, "Howard.Hilll", "AQAAAAEAACcQAAAAEJjXibEn1KVAGSQxZumM+w9tYMRwqx8gwoUv0jUX1UZ8icstoL46nRsVpHUf2EY1XQ==", null, "NotSelected", false },
                    { new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869"), 0, true, null, 287.4807431800860000m, "cd0facb7-3eb1-40ab-a492-d19084a56034", "Theodore", "Theodore", null, "Daugherty", false, null, "Theodore.Daugherty", "AQAAAAEAACcQAAAAEKWJ714IXusq6p0XQzCLx7vmt2WjxgJVCet9TKrQ7bfaR1gHCoNVccOCXZv2qzDILA==", null, "NotSelected", false },
                    { new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6"), 0, true, new DateTime(1941, 2, 17, 13, 57, 27, 992, DateTimeKind.Local).AddTicks(125), 862.4647598307980000m, "6f4dd383-d71d-49d1-b3a5-ad8896db3686", "Vanessa", "Vanessa", null, "MacGyver", false, null, "Vanessa14", "AQAAAAEAACcQAAAAEJ5II+G//8XykJbc33QAXB6TIBJsUuhf1oD+wMIhgJMEGkJHuDnBqIDWXhmQ3u7drQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556"), 0, new DateTime(2002, 12, 13, 4, 19, 25, 20, DateTimeKind.Local).AddTicks(8983), 471.0928071965160000m, "17e2150d-42d1-4f3d-8621-f00a51f252b4", "Johanna", "Johanna", null, "O'Hara", false, null, "Johanna_OHara", "AQAAAAEAACcQAAAAEA43UJG9JRAkjTpWuCrb9wV8p6fTeJW0Qx9043r9J0mnZ2WnPnOhEoOFcLt3LA2cEw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), 0, true, null, 304.5377105962590000m, "1e7c45b3-6252-4394-b155-7e9ec874bc03", null, "Doreen", null, "Krajcik", false, null, "Doreen.Krajcik", "AQAAAAEAACcQAAAAEJLVF6xKefSgD3FKP3PKqs6i4hCmwO/Ubga3bBSWNrb5TzIJKZEMc5mZZ4cEpEtB7g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b"), 0, true, new DateTime(2003, 5, 6, 13, 26, 31, 664, DateTimeKind.Local).AddTicks(3933), 845.1070513398630000m, "739bec40-2dbe-4882-b935-9d0c05fd813d", null, "Tyrone", null, "Koss", false, null, "Tyrone.Koss", "AQAAAAEAACcQAAAAEE6i1AVlxEYcIpUHbpmAK1IV7kJuOU0dIyt7aD+0oBBNQDPZ5+dluM5DuAjumZtFyA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779"), 0, null, 474.3630417455150000m, "5bd38eaa-dac8-45f2-8beb-e93b6d6a0cd1", null, "Latoya", null, "Swift", false, null, "Latoya_Swift", "AQAAAAEAACcQAAAAEBNh/fNG74GB2/Jbn2YsWZmKFEARpP/2XpnudD9Z4cx0QuyfrXip4GOvQYJm/uhvbw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2"), 0, true, new DateTime(1976, 11, 20, 4, 47, 35, 258, DateTimeKind.Local).AddTicks(6449), 429.9757050520610000m, "5c0ebb71-771b-40cd-a648-3b7956e41184", null, "Ken", null, "Boyer", false, null, "Ken13", "AQAAAAEAACcQAAAAELjTvTScbFnIVG/2MeGaRneQ5LJ9EqaWx/Aj0rJkn1K85cn3GcJ3wLiFI9wc1Cd+gQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("314374c4-1bd7-4eda-8546-58617e464254"), 0, new DateTime(1952, 4, 9, 15, 36, 29, 741, DateTimeKind.Local).AddTicks(9294), 162.4870049856350000m, "82e297b9-919f-41dd-9201-db33a7059f74", "Ramiro", "Ramiro", null, "Lockman", false, null, "Ramiro69", "AQAAAAEAACcQAAAAECvLv/1WyyFN0oRlTya/qtxueKq0DpFtIUGWZlV4E2dduLzlhZExAzqvTWnxc7+9lQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3"), 0, true, new DateTime(2005, 3, 31, 14, 22, 41, 91, DateTimeKind.Local).AddTicks(3151), 574.9969716277140000m, "4c068222-6f35-4e3a-b484-82d91e13c79f", null, "Wallace", null, "Aufderhar", false, null, "Wallace48", "AQAAAAEAACcQAAAAEIbVppkjcqyp8rxnoQW+eZvoPeAIYpOs85Y4NG4iZ8oiBLVMLTgm3pINwh1o/GAYCQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("33d5b081-5c0f-4871-905f-631caba91848"), 0, new DateTime(1985, 7, 21, 8, 52, 10, 801, DateTimeKind.Local).AddTicks(3568), 510.2872171517520000m, "9e59380c-8c09-4185-9d4f-cec33f84f0f5", "Samantha", "Samantha", null, "Jenkins", false, null, "Samantha_Jenkins", "AQAAAAEAACcQAAAAEM1i6mw04K56JFGsJao7I8w8WA7DYOByTLwKlwfw7ZNsJSTYELjHATQb7MlgiEHgmw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("34976e08-cfc9-417c-a480-e4cfed027f98"), 0, new DateTime(1925, 9, 25, 7, 48, 35, 365, DateTimeKind.Local).AddTicks(7744), 525.6907174388480000m, "420c633f-8833-4b5d-8552-96086a3343ca", "Velma", "Velma", null, "Tremblay", false, null, "Velma_Tremblay", "AQAAAAEAACcQAAAAEGwkWnlHySF5jyjjGfalp5SnMqf/O0Xd12Oqsrvu5ijI/V1l9FYEPyn4tPz8V4wN+Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("35482730-4c7a-4e01-aeca-0748f3123997"), 0, null, 836.9022867793420000m, "8664142e-98b8-4d34-9fb3-2c408e6981ad", "Sidney", "Sidney", null, "Wilderman", false, null, "Sidney.Wilderman", "AQAAAAEAACcQAAAAEN9EMY4Kyi4Hc9re+PL6dl5Y8LGhtHGp9c/3harP4lnV+7SF6yFqgrLHeE2wyd8d8g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("35b6c210-2256-41cd-af8e-e815527e0a84"), 0, true, null, 615.5227800759990000m, "69e67168-84d6-4cf8-875a-93c67fdf54a8", null, "Johanna", null, "Towne", false, null, "Johanna6", "AQAAAAEAACcQAAAAEIEZxd4EEJ97XbGeil2KSgs9NykVvwmCuEaTSJe9KUdX8HAKKOiQ20T7wEz1htkD7w==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d"), 0, new DateTime(2005, 12, 21, 19, 38, 28, 462, DateTimeKind.Local).AddTicks(6969), 225.815294992620000m, "216d5460-7090-4921-aa1a-fbeb5c63b3a8", null, "Morris", null, "Schowalter", false, null, "Morris.Schowalter", "AQAAAAEAACcQAAAAEKZ2Us8JHQjRHqo9W5lQAhrooNYo26V2dMlAqFUaXhLesAcIiNSdCQVp4DCZdJnPXA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3793c254-cd3f-4c42-93fb-0895042668c7"), 0, true, null, 175.8689533155920000m, "f579babc-ca13-4161-b90d-9816d1ffd69d", null, "Sherri", null, "Schaden", false, null, "Sherri.Schaden18", "AQAAAAEAACcQAAAAEHkbLsh1Pif5B5jIbwx2y4+9auD0NrwyAEe1K3vSsARML34OltT2Zl0qtf9bRufX4g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913"), 0, true, new DateTime(2007, 11, 16, 10, 4, 12, 479, DateTimeKind.Local).AddTicks(873), 16.89118575991030000m, "4402b48e-5edf-4fba-8eec-933fcf15d2a5", null, "Thelma", null, "Farrell", false, null, "Thelma68", "AQAAAAEAACcQAAAAEA7mN7Qr/POF8wQsZhrrhMCEtH0g5ND5jzPkMX/0qmqVwhKFrU62Enf6b3knzvk8QQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221"), 0, null, 499.9934889133440000m, "096ef4b1-1ff2-47a0-9a8d-0ab9aabfd13a", null, "Tiffany", null, "Hoppe", false, null, "Tiffany_Hoppe23", "AQAAAAEAACcQAAAAELeQl9iL11p7MXyuP9avCTlhcsq/fkpcM6kv8vIo3RTNVYuFLzQTIfRH4JAqXnRtDg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272"), 0, true, null, 720.7082109513930000m, "4eed7bd7-c7a0-40ac-926e-a7c7f6d33fe3", null, "Heidi", null, "Kautzer", false, null, "Heidi_Kautzer26", "AQAAAAEAACcQAAAAEBacPMcFE1hL34iDdBlwu3VKUWlz3jzOeLZbOopPRhDaE9EMxzfQw/jUl57FLAtAdg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3be56def-eb89-4486-8258-b67aa1cf9957"), 0, true, new DateTime(1961, 2, 28, 22, 13, 28, 895, DateTimeKind.Local).AddTicks(8674), 765.7338221216840000m, "b520d0d0-42cc-495c-9f92-35a4c1807460", "Amber", "Amber", null, "Lang", false, null, "Amber49", "AQAAAAEAACcQAAAAEAyXMKH/aX6oinbVHJPNbnYHGEVGdYZVfEM7YvF9fYp2CdER/qrC6JO927cb9oin9Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3e38a390-7168-426f-8d48-017588046d20"), 0, null, 74.1642168348020000m, "f3fb4e2b-bc0a-4a53-bd25-578f5801d49d", "Hugo", "Hugo", null, "Collins", false, null, "Hugo_Collins", "AQAAAAEAACcQAAAAEGqFpHQzzP5M/pwDV9kD3M7FLt/aMZO0Ei0zOhql8y2fe+W2jbCYPHn3MdtXZkiLNg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd"), 0, null, 312.4814248237340000m, "7c0981be-72af-4a42-94d7-481831f7a86e", null, "Jessica", null, "Borer", false, null, "Jessica.Borer", "AQAAAAEAACcQAAAAEAKViwVwEIdE8juH6uru+rdOXGp1L7wq+aZd4y69aJzPkzokR8/xlNLUldsrk0dKlA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119"), 0, null, 115.6513236602630000m, "2912415b-4688-4917-84e4-7022f44f3f31", "Sam", "Sam", null, "Strosin", false, null, "Sam_Strosin", "AQAAAAEAACcQAAAAEBkRB0cHenFvjZJynyv5v2rrJRJ0wdc6pg4pegKf0PTPGfn7OAFxJ3pSH/EPt87bow==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f"), 0, true, null, 105.2099201302740000m, "3c396d4e-4a81-411b-ac21-61145be4b597", null, "Blake", null, "Simonis", false, null, "Blake23", "AQAAAAEAACcQAAAAENvCbKaWMctBawYCavD3Lw4fAiiwz6I4uzDofWuUKFs2dBbLQTpEw5NDiV4mCH5S0Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), 0, true, new DateTime(2002, 5, 21, 18, 18, 9, 389, DateTimeKind.Local).AddTicks(4309), 173.6902126723540000m, "521a8bbe-d8da-4325-8346-b79f0b3de6e7", null, "Florence", null, "Reinger", false, null, "Florence_Reinger", "AQAAAAEAACcQAAAAECUcT7n0kHZ8kGHDfLQYyNgOaKH0smRIzYplhIHUBNTACBm0RLM/PURHC3cB5Q3dNQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e"), 0, new DateTime(1998, 11, 21, 8, 0, 43, 241, DateTimeKind.Local).AddTicks(8912), 880.7475584732490000m, "5bfeba46-7402-4980-85bc-641e6db99921", null, "Gustavo", null, "Sawayn", false, null, "Gustavo74", "AQAAAAEAACcQAAAAEDPlzgiaQgHF7J6t8ihsL9fIRO89/qvhSRU7pmnN0BhIrwOLZ3bAabWJHfT0DKf5YA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978"), 0, true, new DateTime(1934, 10, 9, 5, 7, 27, 130, DateTimeKind.Local).AddTicks(7955), 696.8920004226810000m, "debd3a24-a7bf-4fea-a605-f4e18a686c45", null, "Angelo", null, "Schiller", false, null, "Angelo_Schiller", "AQAAAAEAACcQAAAAEKpk4YNHB3VuKnB5qYOnOA/keL5JEyMTFukzVQF32RhDFGm7io1vdNrVohnRscHxtQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("482c0758-a476-404a-ade3-01c0818a58f9"), 0, null, 181.0474125174280000m, "0f641d5f-bdcc-4cde-9726-2a5bf9cd965e", null, "Merle", null, "Kunde", false, null, "Merle.Kunde93", "AQAAAAEAACcQAAAAEHO0kpG5W4cnhgOG30ofDP4KLjMEa1eENlu3VynHImTGTwCGIzhmutACsvp9o+ARfw==", null, false },
                    { new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c"), 0, new DateTime(1986, 5, 24, 11, 31, 41, 523, DateTimeKind.Local).AddTicks(6528), 397.5329821916930000m, "05be72a8-562d-431d-bfa3-a9abac8e9827", "Hubert", "Hubert", null, "Rempel", false, null, "Hubert48", "AQAAAAEAACcQAAAAEMh2lNhD1Y2DZTk+r/U+6nF65NKXmkWQBEt9DUyfgzt3MrKJqs3FNERviepQWrEaWg==", null, false },
                    { new Guid("48949002-3dd7-424b-b508-bb6644cad6fb"), 0, null, 200.7256828820910000m, "05b28185-ee9a-43c2-ac5b-c529310a00a9", "Leonard", "Leonard", null, "Wilderman", false, null, "Leonard_Wilderman26", "AQAAAAEAACcQAAAAEFICXMYCDGdVjnrmxtp2ZMGePwtMJZK1NhYtroqnhgwUuh8w9U04Cd8iWZVPeY9Rlw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342"), 0, true, new DateTime(1979, 4, 29, 4, 24, 50, 121, DateTimeKind.Local).AddTicks(5294), 426.7592484697940000m, "d78037d0-ba3c-4911-bf5b-0afd3463fa2d", null, "Ernestine", null, "Jones", false, null, "Ernestine93", "AQAAAAEAACcQAAAAEJg0XAUxSFvTdgEE/udKpnSRIfOD2SFPXS8I+163WFyDvk9ey+EUdFSz93fxRgkcMw==", null, "NotSelected", false },
                    { new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11"), 0, true, null, 216.3942146494230000m, "caf5a6d6-4dd8-492b-b10c-e55ed1930282", "Sherri", "Sherri", null, "Rutherford", false, null, "Sherri.Rutherford", "AQAAAAEAACcQAAAAEHIQr5tboFM/CfYlLcEZ603K3ISioUQm9A5tqRtO6LNEs2uid7Cym1efS1E499Ga5Q==", null, "NotSelected", false },
                    { new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374"), 0, true, new DateTime(1931, 7, 21, 5, 10, 18, 337, DateTimeKind.Local).AddTicks(4235), 272.5049366852270000m, "a269f7ee-4752-46b2-a566-a9d4cb01ef87", null, "Geraldine", null, "Konopelski", false, null, "Geraldine38", "AQAAAAEAACcQAAAAEEGubKGlH1gLyUZAXCb3iAFGpXYkq8Sru4mZJrOXoqfWVee9UWRPhNUSwEFskkYc8g==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7"), 0, null, 937.2457906519870000m, "22cda8b3-dbbb-451a-b232-76a6877e5d2b", null, "Jackie", null, "Kassulke", false, null, "Jackie_Kassulke", "AQAAAAEAACcQAAAAEPRlPrIeUg7LY/9FN3LcaTpHEGBXvxRlCfHpLbYusYYvN0vKsXD1u9yVrjnX9MSIhA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), 0, true, new DateTime(1982, 10, 24, 11, 40, 58, 792, DateTimeKind.Local).AddTicks(8357), 653.126504718090000m, "87350147-b257-4ab8-868e-2cef95410ce8", "Everett", "Everett", null, "Greenholt", false, null, "Everett20", "AQAAAAEAACcQAAAAEDS3T68L3+2dyqBbXOXPyVy8fB0sFKpgVOYx3MhW9eHB1+bLvprMDzkAWYEnrC3uww==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a"), 0, null, 872.4119327018230000m, "c983c6fc-5911-4d62-a7bc-2c23fb5618fb", null, "Mitchell", null, "Gibson", false, null, "Mitchell77", "AQAAAAEAACcQAAAAEI/fVNEz2ku+zSKslsqGxZmIF60yq8PkF32gmoptAQJYajcDWaC9TxBYB2tLbAx6Pg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea"), 0, true, new DateTime(1969, 9, 29, 11, 52, 40, 244, DateTimeKind.Local).AddTicks(832), 48.60700241301920000m, "9d35bb98-8ab5-4050-9032-ac73a169a0c9", null, "Joel", null, "Kuhn", false, null, "Joel80", "AQAAAAEAACcQAAAAEPkR8lSTUP9DB26sdSjME0k0rFRXIFCQWaATxRns5Q+S4OZxGMpKVYyhEdPO9v1k0A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305"), 0, true, new DateTime(1979, 11, 20, 3, 3, 3, 280, DateTimeKind.Local).AddTicks(7133), 82.81448845594330000m, "38e121c3-e9df-4f2f-a58f-befe480ceee2", "Tom", "Tom", null, "Lang", false, null, "Tom.Lang", "AQAAAAEAACcQAAAAEJ2L+K4XyIVkLQN/rkntnqS/tOmbkraml/YhMM5pIDNjPTD2f507bLWJEKaF63UTXA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5"), 0, new DateTime(1948, 6, 11, 0, 17, 26, 487, DateTimeKind.Local).AddTicks(8749), 522.8977758175230000m, "4be1a31f-ccac-4eb5-bd7f-7d4f0eb7679e", "Sophie", "Sophie", null, "Kuhn", false, null, "Sophie.Kuhn81", "AQAAAAEAACcQAAAAEBRpew2NPVurRIL7tqVcSP+IKErjpxm7mvgpznBkm97Su1sxHJj5khM/ClJZDNJ8wQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854"), 0, true, new DateTime(1976, 4, 20, 4, 45, 58, 71, DateTimeKind.Local).AddTicks(8319), 682.607572842010000m, "9846e67e-bc0a-4b5f-84d3-693271755889", null, "Dustin", null, "Koch", false, null, "Dustin.Koch42", "AQAAAAEAACcQAAAAEDkCxn8mkSAima6kEpKsc/x7lKyIUhJdVNCxKqWNqniDF/mBAnjSlD7NJzqTxrtlBA==", null, "NotSelected", false },
                    { new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4"), 0, true, null, 460.2661305371160000m, "54511132-b7fc-4560-9628-a934f95b96b7", "Derrick", "Derrick", null, "McLaughlin", false, null, "Derrick_McLaughlin18", "AQAAAAEAACcQAAAAEIv7kKyQEuGmiaFEF7zOveEyWtfb+MJvEp6u8oUqQbScriSmB8lKIkNjW8VEFS/CbQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("54544805-6149-40a0-a366-c2fb8f55975f"), 0, null, 588.8530882461680000m, "bb412855-b98c-450d-9640-5c91ee88a149", "Ellen", "Ellen", null, "O'Conner", false, null, "Ellen_OConner6", "AQAAAAEAACcQAAAAEOBDnFG2scvYZV6csH6UrSbv0D9FLcOkhMjwi+Qj2ZnsfmA7+Ozvr1K7pqEYiFdLcQ==", null, "Female", false },
                    { new Guid("5558c531-153b-4da7-9848-996b07daa782"), 0, new DateTime(1997, 12, 8, 10, 48, 44, 450, DateTimeKind.Local).AddTicks(787), 762.627107768320000m, "5feb1c6f-ea29-4da6-905e-863940f7900d", null, "Alma", null, "Littel", false, null, "Alma.Littel25", "AQAAAAEAACcQAAAAEH4hV5CcR6VH9r7V7lIQC3ML0liuv2s3z2WT/oLFyNR/pjKPJiK+kMRWWeH4JJSHaw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e"), 0, true, new DateTime(1992, 4, 3, 9, 44, 0, 490, DateTimeKind.Local).AddTicks(3430), 214.5594786222910000m, "dd075687-2905-42cb-8a94-2b5bb9c5be09", null, "Debra", null, "Fay", false, null, "Debra_Fay77", "AQAAAAEAACcQAAAAEPrJTDozidmZcSSqTDkiFbYTKQ0wSuhUrUtOcgYejDipHYpxPvBtotEcPCt9fUTnBA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899"), 0, null, 592.7841392529920000m, "1f2997ca-cf1e-475f-8b07-47185fae6a0c", "Johnnie", "Johnnie", null, "Purdy", false, null, "Johnnie37", "AQAAAAEAACcQAAAAEFk7poSg6bzaJLGrNrDYmdntYQfQSS+O/nH9mkw2SxcwvEdYxBDvQoyWG53w9aCALA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33"), 0, true, new DateTime(1993, 6, 22, 7, 34, 34, 461, DateTimeKind.Local).AddTicks(3761), 998.1820324624870000m, "1170b5b3-36d4-4822-9471-f33023fb33b0", "Ira", "Ira", null, "Beer", false, null, "Ira_Beer", "AQAAAAEAACcQAAAAEIpMnta+JVri9u8h8Q7tck0CVm0ZZfGp+WHkwo7nlYhxNbApYxi7ugHsdjF2FeXdZA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61"), 0, true, new DateTime(2007, 10, 13, 23, 10, 36, 228, DateTimeKind.Local).AddTicks(4856), 639.9145785059660000m, "d96aada0-5808-4226-a2e7-207cae1c0972", "Randolph", "Randolph", null, "Frami", false, null, "Randolph.Frami", "AQAAAAEAACcQAAAAEC9nag7Hvbn8/wy9o936031YsUR0YAeo+3aGIWXhmSY34DBBXfSuZo3z8r0RxU0eHQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e"), 0, new DateTime(2008, 10, 12, 16, 32, 59, 724, DateTimeKind.Local).AddTicks(5043), 545.1962162845410000m, "81198a55-50a0-4402-9826-4ec857dc107b", "Marion", "Marion", null, "Wilderman", false, null, "Marion.Wilderman", "AQAAAAEAACcQAAAAEN/uloct8Lm4ZE+sWwLYTYXKp1A5yB+TiQ8iwfC2zxLXgbQo8RCfBP62+Mhb6G79dQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1"), 0, true, new DateTime(1955, 9, 12, 5, 44, 25, 412, DateTimeKind.Local).AddTicks(9872), 401.9102001843970000m, "d9e899e0-d08c-4385-8be3-fb8d5e94a7ac", null, "Jay", null, "McCullough", false, null, "Jay.McCullough75", "AQAAAAEAACcQAAAAEF5ANCHyl8szTup4Pi6nB6idS0Xx/htanXUajbSIK8fJRCC3qxHowIsqZC6SMwIxmQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7"), 0, null, 81.91794444896920000m, "3c14cbe9-6b70-49be-bcc5-2f2e86aeafc6", "Beulah", "Beulah", null, "Kub", false, null, "Beulah68", "AQAAAAEAACcQAAAAEK5FNWC76gxM44xnm4V0Lk4kFr+6INQAXw1iElg7lTfcdyLSa/XVXWubViV+g5EaGw==", null, "Female", false },
                    { new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a"), 0, null, 344.0973837714830000m, "1c768e1e-5220-4959-ba9c-22e6d3bdcf6a", null, "Merle", null, "Lueilwitz", false, null, "Merle_Lueilwitz", "AQAAAAEAACcQAAAAEJswu33XibWIaIBi5UrfJP9Tz9JbndJ/yQq8r/pNlqlYY9Y135Pm5MCmso/i+ZyuIQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1"), 0, null, 583.5446236642940000m, "f9b19894-a061-4ad2-acb2-24f6121a222e", "Grace", "Grace", null, "Strosin", false, null, "Grace81", "AQAAAAEAACcQAAAAEIda76kxYu3TXo1GM6R6HaABEHLZAfqW/brfPXHNrSMkq3Q1/NyRrqdtY8QsKvK4kQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d"), 0, true, null, 939.8363754786450000m, "f0518ec3-dc51-4f06-8f3d-0324453064c6", "Salvatore", "Salvatore", null, "Graham", false, null, "Salvatore.Graham", "AQAAAAEAACcQAAAAEGi3jsHyzHIs3yW75ljJUGKYdt801KASw2Gy2M+vu57aBLrCUVUY9FLK51vCfkGZ/Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0"), 0, null, 386.8086273543540000m, "08deb455-162a-40aa-9370-13527b8601d0", null, "Linda", null, "Hintz", false, null, "Linda46", "AQAAAAEAACcQAAAAELSw2hfqnJQtwnIHJ7NrjxkCc1ThAPYKcmcpuvFG4WSd8hw9JWYlsGHpdMrfLQGFig==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("636e6fd1-c4da-47a2-b141-1921b8814132"), 0, true, null, 763.8158175111280000m, "96c2465e-525d-48d7-80d6-b7a693e64193", null, "Ignacio", null, "Willms", false, null, "Ignacio.Willms", "AQAAAAEAACcQAAAAEGpB1FshahaGJDS1FjIGE/w2EUkmuA9ZOYQPTYXhW3cCjyROR3EV0AOUwG67k93hBw==", null, "NotSelected", false },
                    { new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), 0, true, new DateTime(1928, 11, 3, 2, 38, 34, 847, DateTimeKind.Local).AddTicks(4084), 941.9546239371170000m, "20a67383-9291-45b7-993c-c0eb0c7763e5", null, "Bryant", null, "Leuschke", false, null, "Bryant.Leuschke", "AQAAAAEAACcQAAAAEAL/NKpwr7X8g42zHdZVGTzNKrSLaVCXkZl3O8LYscEisW8/+g/+jX8Inisek+EfxQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a"), 0, new DateTime(1992, 1, 12, 20, 29, 44, 649, DateTimeKind.Local).AddTicks(448), 687.5481826904180000m, "29415675-b3b3-43e6-88e1-bc8e98bce6b0", null, "Stella", null, "Brakus", false, null, "Stella_Brakus", "AQAAAAEAACcQAAAAECqmquz8eLjNDY4hs0y0Wm+AjAKI9D+N+lZ1g52r/66Q9+9zbkin7smRFq0KtjnTnw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574"), 0, true, new DateTime(1984, 9, 13, 17, 6, 47, 588, DateTimeKind.Local).AddTicks(4717), 514.5976991799210000m, "b3305f67-32fe-4529-afd3-a83b6262b1c1", null, "Jake", null, "Kulas", false, null, "Jake.Kulas", "AQAAAAEAACcQAAAAEOAyuAsd5SC67nUz2i/aVBqbZKCfdQyr+iDGG9WYiHbZxMnB21CZRzeHf+62rPI+PQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("665af7ab-85d3-48f3-bedd-30db54699f81"), 0, null, 54.11721882356470000m, "0474202d-64df-4212-88d5-a552cc9d749f", "Gretchen", "Gretchen", null, "Bradtke", false, null, "Gretchen95", "AQAAAAEAACcQAAAAENwkod2q4fuqzKCiUcozIa95g+Nt3HhLni4mMzNbSwC5Xoa+GjAZOrh1yJzQmkWRRg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6664d758-265e-40e1-8b6e-206b2c289138"), 0, true, new DateTime(1926, 9, 3, 19, 43, 41, 864, DateTimeKind.Local).AddTicks(3158), 513.7667532854920000m, "783025b6-0b1c-48a4-b55a-8a7afdc80103", "Walter", "Walter", null, "O'Kon", false, null, "Walter95", "AQAAAAEAACcQAAAAEMlOhpRUQk4vPFCPnpCiHlhXYty9T+OzqzhI4CPrgFJ44wBA2XLAbPaEQVlHn4Oo1A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("69170f92-b4b7-4c26-be44-5255d738fb20"), 0, new DateTime(1993, 4, 29, 4, 0, 19, 635, DateTimeKind.Local).AddTicks(9728), 530.3338700504540000m, "8addafce-53f7-405b-ab37-823fb3df0974", "Molly", "Molly", null, "Padberg", false, null, "Molly_Padberg66", "AQAAAAEAACcQAAAAEJaN5rYS5kVXK2dO0QUdjuOIIGccdW/XD1T1Q0Zie2Lzzagh72Hnw8hnKk9ns6/jxg==", null, "NotSelected", false },
                    { new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d"), 0, null, 400.0757118671330000m, "daea3fe5-e3f0-4691-91aa-658d293f8512", "Ida", "Ida", null, "Haag", false, null, "Ida_Haag", "AQAAAAEAACcQAAAAEDSxxcZBXydJWnyr5JzTKwEfxVTMfGLC+9ca95XzHGwmIp6b6SDvDzyhL+F4DUq5Pw==", null, "NotSelected", false },
                    { new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0"), 0, new DateTime(1930, 2, 19, 1, 24, 51, 801, DateTimeKind.Local).AddTicks(2418), 676.2271182749580000m, "50944d29-5c0f-4930-b07b-62d59ac6969b", "Blanche", "Blanche", null, "Grant", false, null, "Blanche33", "AQAAAAEAACcQAAAAEO4ilCBMP+7B1Mtx3EZS1dTnlBOt2DoXFSbvYAvlDlnVYHjqXkisMGYUYwybFJVMYA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a"), 0, true, new DateTime(1988, 1, 13, 3, 31, 53, 518, DateTimeKind.Local).AddTicks(6831), 133.0779674363270000m, "1d4f0623-84ab-4401-accf-ec2a4e652327", "Jeanne", "Jeanne", null, "Schroeder", false, null, "Jeanne.Schroeder47", "AQAAAAEAACcQAAAAEGQkhul5RNX3KA0dxdW2Y7f2HclbkJIL0v2hY4WqvBlGwAODcIck2xNwbliRXnWOSg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21"), 0, null, 150.6263292056420000m, "a6601e89-e637-48eb-8539-55076fad5ab0", "Cody", "Cody", null, "Fritsch", false, null, "Cody.Fritsch", "AQAAAAEAACcQAAAAEK2oqTSX5N+gEStPk/nNuwFQuFfwuol4wxg3Wx8d1+OZU55OOwBDijUM2AGVoAg7+Q==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5"), 0, true, null, 316.3180659616510000m, "2866351d-95fd-42bb-ac60-8417479ece69", "Chelsea", "Chelsea", null, "McClure", false, null, "Chelsea24", "AQAAAAEAACcQAAAAEHDJzQ9sFzhejrThu0Y0yWiJDTbbA/6gj2Yv6RDCZ4NgIlLdJOc6aqEMbNR4YyWGbw==", null, "Female", false },
                    { new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964"), 0, true, null, 194.8491237408610000m, "37d710f2-6cf6-4d2e-a8aa-1691abe58681", null, "Bobby", null, "Quitzon", false, null, "Bobby_Quitzon", "AQAAAAEAACcQAAAAEB8TI3uSCTvuhZtP7swyuE6ihVJ+wC2NGvpc+KysKjkwf3QRyjgYH4pNUNlnjbXkJA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5"), 0, true, null, 977.4361487431150000m, "539bebdc-c8b7-4973-b008-cd15284f0634", null, "Sonia", null, "Batz", false, null, "Sonia22", "AQAAAAEAACcQAAAAEBFqFZ7lIpEvdWaCG2UkAYtgN2/IoDUSkjZU7NAsVlzz17lJkZSy91qkkuDCoCyP8g==", null, false },
                    { new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0"), 0, true, new DateTime(1936, 2, 29, 1, 50, 31, 516, DateTimeKind.Local).AddTicks(4038), 910.4284554521220000m, "a62ef052-7f2f-4703-93fd-c920ca366c03", "Lorene", "Lorene", null, "Yost", false, null, "Lorene_Yost94", "AQAAAAEAACcQAAAAEHebsu62FdeFIcohZmEEjYPs5HJDwof0PPSG+TwK5yJhLvPoxjQrVY/7RqhjmGx0Qw==", null, false },
                    { new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed"), 0, true, new DateTime(2008, 7, 8, 15, 20, 18, 842, DateTimeKind.Local).AddTicks(931), 535.7997620379270000m, "b9cce466-2dcd-4c7d-8bab-79d9b2f0ffac", null, "Darren", null, "Goyette", false, null, "Darren38", "AQAAAAEAACcQAAAAEBYJW/D//usngw2KhA6/kwgWzIDvl74bfBkMHUuVK3SsMFq0h/8Vz9EyFz+PrQyYxQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d"), 0, true, null, 396.7431470384390000m, "7e8a5fb0-72d9-4e6a-821a-0e779c2c824f", null, "Arnold", null, "Donnelly", false, null, "Arnold_Donnelly60", "AQAAAAEAACcQAAAAEEhiTOhyCz+/Aml4uRm0w7dKyIMYNjA+Y9KsyonbXaMBOduwj0WzG9FIzfQWowHEZA==", null, "NotSelected", false },
                    { new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b"), 0, true, null, 577.3983805722660000m, "ec44baff-221f-47b2-a84b-ac4b492fba58", null, "Roosevelt", null, "Cartwright", false, null, "Roosevelt_Cartwright", "AQAAAAEAACcQAAAAEIf0KcBkGWOi4/ciP7/DYRyMrjTGp5xqt2F6YHKAmbgbMHyfPYXD69Fu2uVendSM+w==", null, "NotSelected", false },
                    { new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c"), 0, true, null, 932.583452081360000m, "5f68a389-4a21-4040-9884-b3599a12b3d5", "Elsie", "Elsie", null, "Schiller", false, null, "Elsie.Schiller12", "AQAAAAEAACcQAAAAEGXNd9QoOq5tAfoXNEOFE77PZKNFfBMKuB0LOTAlwWzNnvURUEBqcdzXx07LGdBcAA==", null, "NotSelected", false },
                    { new Guid("71725c06-aded-4994-8181-26d1683597c4"), 0, true, new DateTime(1972, 7, 17, 16, 31, 59, 202, DateTimeKind.Local).AddTicks(977), 315.1970895467910000m, "2acdb3da-326d-45d8-a212-410c996349fc", "Boyd", "Boyd", null, "Corwin", false, null, "Boyd74", "AQAAAAEAACcQAAAAEB5msKsWwWTdEOAKHG4G3TjcLg34LeOsIPeHRAF7TSM2Y+VkuYw8hrm22PWXKHUq7A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a"), 0, new DateTime(1953, 9, 14, 16, 34, 46, 972, DateTimeKind.Local).AddTicks(4246), 568.9609997773460000m, "666febb9-1789-4eff-8780-899230863a52", null, "Naomi", null, "Lynch", false, null, "Naomi_Lynch", "AQAAAAEAACcQAAAAEGdvfvHJtjAErRPoWvxgYmGmgn6KjDITCBihlKYG544EIi8EVdAn6sINzJ41oL4djg==", null, "NotSelected", false },
                    { new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7"), 0, new DateTime(1998, 5, 22, 4, 21, 1, 51, DateTimeKind.Local).AddTicks(2292), 224.5046598724180000m, "622f8401-5e73-4617-a379-790830d3d806", null, "Juan", null, "Purdy", false, null, "Juan.Purdy48", "AQAAAAEAACcQAAAAEItOM3zl9RfSDE2dm78QtbIHydBcwKvPko/MDXY525GNlwkFqiGOOYZf5YscUmp87g==", null, "NotSelected", false },
                    { new Guid("735be216-2179-4f32-8f5b-062c31f3a316"), 0, new DateTime(2000, 6, 3, 10, 15, 3, 499, DateTimeKind.Local).AddTicks(9920), 839.987827639570000m, "78e85117-35c0-4ac1-bdb2-860d7a49dc59", null, "Luther", null, "Bruen", false, null, "Luther.Bruen", "AQAAAAEAACcQAAAAEIVN6mbp9710qE2zTg4+ND+KBB81V1SKq9D1S7zcBcHhJbayDyYpi0MMQuYy3aU71A==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b"), 0, true, new DateTime(1995, 5, 6, 18, 18, 26, 217, DateTimeKind.Local).AddTicks(6657), 841.0766182371370000m, "7d1c6ba6-1450-41f4-8944-326e52ccd98b", null, "Perry", null, "Kiehn", false, null, "Perry.Kiehn", "AQAAAAEAACcQAAAAEFkZokouw2NxNG2/l9jNZZtxpLGhwuU3WoqjXk8uT00fBl7UzjOyHgLzwbjFl5yKxQ==", null, false },
                    { new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6"), 0, true, null, 76.81392600251070000m, "e0df8f33-cba2-4400-ba99-b7f4b5d258f2", null, "Ida", null, "Effertz", false, null, "Ida.Effertz", "AQAAAAEAACcQAAAAEDbd4mE6VPI4Lc1T1hUlCLvhO+84MdjKA5noxP4QQPM9Oe+jEKK7ggRAypTpvgCBVw==", null, false },
                    { new Guid("7637da20-6c85-4358-a711-5912b0358007"), 0, true, new DateTime(1956, 6, 30, 2, 40, 5, 496, DateTimeKind.Local).AddTicks(8093), 241.3814700118020000m, "def9882f-ca3f-471f-aa61-49c8d69efff8", null, "Roger", null, "Predovic", false, null, "Roger_Predovic25", "AQAAAAEAACcQAAAAEBn7o0leArlMu9uDdZ2bxiJ/fIm6RflBCLjK75l74NX57sLXeQznvcTHCG3npTfBSQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162"), 0, null, 508.7699480979660000m, "76a522bc-4c3d-46a8-8615-e21bcfd2d34c", "Jack", "Jack", null, "Pacocha", false, null, "Jack15", "AQAAAAEAACcQAAAAEHrqrJlOO06ACZlBAcp3cruMneKKJAZ72Nbn6t+QtfvpR3wracfCZFjC0v3nzg0UDg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26"), 0, true, null, 962.5381425167880000m, "4afc91bb-9264-44cc-9d22-3c4dab9cb540", null, "Jane", null, "Hodkiewicz", false, null, "Jane_Hodkiewicz", "AQAAAAEAACcQAAAAEKSV6QcZm98SK5YrIF2euUlozK2hxBfmKbL6ivSh+lwr67DisIOHaOp5lJnAmPCwOA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403"), 0, null, 882.2773021776350000m, "9dd7386a-1641-4a11-b368-81fd585f4c9f", null, "Lana", null, "Maggio", false, null, "Lana.Maggio77", "AQAAAAEAACcQAAAAEL6qKaGP1iZNpl1Blh86qnSgdEL+lwSsMc3DTQX3X78DGPWDzhq8jsRuNzVB008adg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7c2af719-e82e-4031-bc56-568a9d473316"), 0, true, null, 203.7706846608220000m, "dd0d4441-5f3a-44b6-9ab7-cb3779a12abb", null, "Jodi", null, "Smitham", false, null, "Jodi.Smitham", "AQAAAAEAACcQAAAAEPkhvKh2e+0ArlBuiM84w1ejDAm0Y7oaPjoBwX5jxM2OE50vncFf09+IzUl6ikh5Wg==", null, "Female", false },
                    { new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a"), 0, true, new DateTime(1969, 7, 25, 23, 48, 23, 574, DateTimeKind.Local).AddTicks(5434), 593.47186386350000m, "13af6eb9-ea06-42f1-9366-45c3947bbf53", null, "John", null, "Kovacek", false, null, "John_Kovacek", "AQAAAAEAACcQAAAAENeCCS/C2owFfpintJJqYxvJbkJ8ieQnlziTYboj2lUO6W75+5/E8UxNhZESNcOcCw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977"), 0, true, null, 247.6949595920080000m, "86d22bcb-32e7-4953-aebf-fa1bfd7632ce", null, "Beverly", null, "Fay", false, null, "Beverly55", "AQAAAAEAACcQAAAAEODor72zAKRKf0uTmYGx2xYu+0sXjpdHtRS3xTkQSSYUnDUKtu3QS1VuOnvVJAjbWg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("810775de-7e6f-4620-99bb-c534d912de67"), 0, null, 385.9169650333370000m, "c4075972-31c9-4c3d-89df-94effc125645", null, "Renee", null, "Jacobs", false, null, "Renee5", "AQAAAAEAACcQAAAAEMH4Wv7uPWio2pBvANz1/NvzfTnNFWU6Rh8+g/8GJ0H3bmjKmOj8WK7BkeNWgbzIOw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13"), 0, true, null, 814.9945748656330000m, "ea9f37f9-d99e-485e-962e-646587849996", "Geneva", "Geneva", null, "Stoltenberg", false, null, "Geneva.Stoltenberg", "AQAAAAEAACcQAAAAEMedgPGaw9mfjlSDK1EjIm5P/3cUHPUyAMVbsi24I9cRZ+mBo/0aMUl+ZG3s6yfpxw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), 0, null, 584.3113111503540000m, "900c54de-fe41-49ae-b37a-f8e0267906d3", "Oliver", "Oliver", null, "Spencer", false, null, "Oliver.Spencer", "AQAAAAEAACcQAAAAEC3PSohjl34o7KPW5v7cJ/ljfmwB3aS8BVjbvCDRTA/YtlLW0pXVb1ppefhzC1FiOw==", null, "NotSelected", false },
                    { new Guid("83c8f958-a3f1-448d-bad0-048533827e0e"), 0, new DateTime(1935, 10, 9, 6, 36, 44, 578, DateTimeKind.Local).AddTicks(9039), 489.1609590728860000m, "364062ca-bc91-4904-b57c-cf3382ba8196", null, "Gertrude", null, "Braun", false, null, "Gertrude.Braun", "AQAAAAEAACcQAAAAEGpEXlLmo9HAqwpJw+QtQYyrWGO7DSeUwWFJpZsYSOeTvCKTJjrqNgW0qvT7PrGmWA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b"), 0, true, null, 884.7068505605610000m, "bda5692e-553e-4a93-bc82-452a3dc5930e", "Jimmy", "Jimmy", null, "Thompson", false, null, "Jimmy62", "AQAAAAEAACcQAAAAEA9rxDACXPIodRadxCAPo3peJf+pJu1yPx0rfUjKef9bfumjwDbDIYmcdINCwr1iqQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c"), 0, null, 655.9289206043970000m, "713c327d-8c9a-4a66-a96e-15a51390960b", null, "Alma", null, "Kshlerin", false, null, "Alma_Kshlerin", "AQAAAAEAACcQAAAAEP+dmRPX/GnpUHV3qGvo83RgI3Q9te5c2bJJECW27TsNNKpspeaNbWjf98E75+Phkg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b"), 0, true, new DateTime(1948, 5, 15, 0, 11, 37, 774, DateTimeKind.Local).AddTicks(7362), 469.1635916506230000m, "97e1ca06-30bc-4477-9a44-00900e9927da", "Ronnie", "Ronnie", null, "Torp", false, null, "Ronnie_Torp3", "AQAAAAEAACcQAAAAEPizKK5qwi4gmXbj7p1MihUM6wGVE4hemInsz4HYby7yKyzO/IJyncHVWS2nXyLsCw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3"), 0, null, 979.7166296504290000m, "a37c7a69-ce1e-487c-86bb-f02cdc024875", null, "Monique", null, "Nolan", false, null, "Monique74", "AQAAAAEAACcQAAAAEHu9pIl1gHEMNoFaDZXm1isXGtFd1J59i20k+QAblZiWBUJ+2yanWjF4hemXFvsU3A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8604dfec-8284-4ca8-8911-7d89e1637747"), 0, true, new DateTime(1939, 11, 17, 14, 27, 56, 159, DateTimeKind.Local).AddTicks(2127), 98.57015675142010000m, "d6639593-9e25-4d76-9e3e-3d87eca8b561", "Carlos", "Carlos", null, "Howell", false, null, "Carlos10", "AQAAAAEAACcQAAAAEEzcnHN0+i2LRqHvrujYUd1IoU2DejvbgluzvMQYwhWPx+S6Et8CKHR0F16Jx6Nj0g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("86555a53-2ae1-40b3-98c6-17036425dac8"), 0, new DateTime(1982, 5, 17, 8, 37, 43, 769, DateTimeKind.Local).AddTicks(2087), 129.3525411615430000m, "f7c334b3-726e-439b-af8c-c8195e4272e5", "Roberto", "Roberto", null, "Kovacek", false, null, "Roberto68", "AQAAAAEAACcQAAAAEKofFUs/f8Nn8yBdfoUHCwvuE794Wb6kojnY3vbNTl1NwnCO1yTIQmYnamV9mSd7Cw==", null, "NotSelected", false },
                    { new Guid("8889579f-6a19-43b4-a939-5d6b7706de41"), 0, new DateTime(1930, 1, 5, 17, 27, 32, 360, DateTimeKind.Local).AddTicks(7837), 863.117998156070000m, "8d414ef8-d1a7-472c-a9ac-652c7bf7618b", "William", "William", null, "Rohan", false, null, "William.Rohan", "AQAAAAEAACcQAAAAENyx38ikgWGaZb9dEv+WHF7mb0aIlVLpSPtsvmG+ljWLcEU3YBdiHrKfZfA1f21RPA==", null, "Female", false },
                    { new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918"), 0, null, 685.0222510552640000m, "23670e7c-95d7-4a5a-a256-9438354ca6c0", "Vicky", "Vicky", null, "Marquardt", false, null, "Vicky.Marquardt", "AQAAAAEAACcQAAAAEGqn8fG6iAgMxxqGjEcUCrtqYXt29NwttKEbhfp0VNSK303aXsKQZOMRNP3jPJfdtQ==", null, "NotSelected", false },
                    { new Guid("8987fd2f-b286-41d7-9544-b355355a2cff"), 0, null, 651.957410811220000m, "c9112250-491b-4ec6-b32d-f5178d31dac8", "Elaine", "Elaine", null, "Konopelski", false, null, "Elaine39", "AQAAAAEAACcQAAAAEAfK9kwrZOO1FZaSeQ21HbwkUUK0stxqdGsqJxB9w8VnesrWacdjYFJQmLDXW80hew==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd"), 0, true, null, 5.09615614671210000m, "d1084b5b-40d0-4f03-ba46-ae5c695dfe20", null, "Heather", null, "Tromp", false, null, "Heather_Tromp", "AQAAAAEAACcQAAAAECoTClEj2Kxd8SxDCWJrXb1vHEewHQpnoYhsZewGGA9xoByJdnuEim+C52M8vruVzg==", null, "Female", false },
                    { new Guid("8b3ae855-3f1f-409d-8898-00767477ffae"), 0, true, new DateTime(1983, 12, 14, 4, 43, 48, 700, DateTimeKind.Local).AddTicks(504), 731.9066708393070000m, "190f3608-b570-47d8-a84b-4c7475180d97", "Nadine", "Nadine", null, "Connelly", false, null, "Nadine78", "AQAAAAEAACcQAAAAEAbccxa2BDLeNVHvBDcv0hEoHcakR7AqDo4UR+RfrFcDpncp5AG6wDL0rAKFZlVwSQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8b896efc-3b46-4670-bb2b-740919a113b5"), 0, new DateTime(1955, 1, 20, 12, 50, 7, 589, DateTimeKind.Local).AddTicks(9844), 405.0427380128310000m, "346fe7a8-d5f4-4ae4-9873-1a0a9c8559dd", "Harold", "Harold", null, "Parisian", false, null, "Harold_Parisian", "AQAAAAEAACcQAAAAEPiRTt/653vmUNY9QPzpsrMesNEqQfuQ3Wt9qoqUb5WCw5zkb+6Z8CLInGff3wo/+g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4"), 0, new DateTime(1987, 9, 16, 6, 9, 42, 874, DateTimeKind.Local).AddTicks(1044), 614.1361935098410000m, "2050d6de-10c0-4ee8-956c-cc57b90b0c21", "Keith", "Keith", null, "Howe", false, null, "Keith_Howe", "AQAAAAEAACcQAAAAEFuhWPUGBqt/hBGpqrToe9+CeWsDEBIcVuMfSdHWXl/zy0yoHmY6ctwtUC5DVCC6Ig==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8f8cd90d-fe20-4df0-8607-72f337546146"), 0, null, 726.6471042885570000m, "d8f9b6a8-c88e-4e10-8aaa-913482403b81", "Stanley", "Stanley", null, "Steuber", false, null, "Stanley20", "AQAAAAEAACcQAAAAEAkk1UXpGtMMXVCbowyH4gNw8qJ/2NpR5rg8N5cEp321O+2deVi6NilssSIHMROceA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555"), 0, new DateTime(1965, 7, 17, 14, 57, 55, 824, DateTimeKind.Local).AddTicks(4634), 523.0973311407430000m, "07bb58ac-92b3-4502-b81e-2e013e6a962d", "Debbie", "Debbie", null, "Breitenberg", false, null, "Debbie.Breitenberg65", "AQAAAAEAACcQAAAAEPVFjrvGIE+lBsockqAAJ8NGXjrf+SVZ2vAr6a0sq7qNTdwa7k6fULQj4sbJ5C5oag==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b"), 0, null, 599.5928442746480000m, "3a754122-ed53-4394-bfbc-71371164911c", null, "Diane", null, "Powlowski", false, null, "Diane.Powlowski39", "AQAAAAEAACcQAAAAEBWziWQqbkR6671kdtcRYexClOYOLrdcl/S8iPpMbRLAPiwsR3A6Y3aS9JdmHUK0WA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05"), 0, true, new DateTime(2004, 1, 28, 10, 11, 26, 231, DateTimeKind.Local).AddTicks(573), 873.5350353606340000m, "68f7bd9a-61cc-47cd-8d43-22c679657143", null, "William", null, "Nicolas", false, null, "William.Nicolas69", "AQAAAAEAACcQAAAAEAXTOK4uat1wNnqxWhtAj43KQkU1e4cNeKoGaVqo1ru6UgsXh1gGW7YJEc1QPMgcEQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4"), 0, null, 395.1298731892410000m, "61b239fe-9d83-4eaa-b11d-08a6ec0f0215", null, "Jamie", null, "Hintz", false, null, "Jamie51", "AQAAAAEAACcQAAAAENcZCLt9y/z/IXL8hSW90yMifVTIjW/C4jdN6cs8/9bnhlrGFTSAplQVk9UoVt2qPg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab"), 0, null, 31.07043516167080000m, "620de6cb-0b56-467b-8f55-be0f56d95d29", "Kerry", "Kerry", null, "Kemmer", false, null, "Kerry27", "AQAAAAEAACcQAAAAEOFPID+gw+1et0hBosI2D7THUgebzUu9LIqyV8z9oAee3D+KnrG+sGR4rpzgdDgUqQ==", null, "NotSelected", false },
                    { new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20"), 0, new DateTime(1934, 12, 24, 10, 35, 41, 196, DateTimeKind.Local).AddTicks(1490), 132.6272521503150000m, "1c76db45-74fa-4af4-9587-c11bb243387c", null, "Randy", null, "Pfannerstill", false, null, "Randy.Pfannerstill99", "AQAAAAEAACcQAAAAEMP9F7HAfPEpkg9kqi3YQSOcSeZUJpKWQ+bG+wG0FNG1rxNrWNygUsCXD4bzCnrK+Q==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9349fc86-09c0-446e-8036-e69d441a3822"), 0, null, 654.6592623025280000m, "70601fb4-2430-4192-b8d8-a3519a70b136", "Ora", "Ora", null, "Hegmann", false, null, "Ora_Hegmann", "AQAAAAEAACcQAAAAEK5pGO7HWRlUcijtE2h6n3qGLqlVuD+RIn16G/i0xYzDGU60g3R26VRKKyZjHj/xog==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34"), 0, new DateTime(1971, 4, 9, 19, 56, 18, 883, DateTimeKind.Local).AddTicks(6202), 68.38231623330270000m, "1af67d99-82af-4a87-9496-707f2ff5c46f", null, "Leonard", null, "Larkin", false, null, "Leonard74", "AQAAAAEAACcQAAAAEEd4rB0wsb45FSroUZUKl6XTkvgBggkNK2wKblh3lEdwkyiziGmtLDvDH8THmHccyg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4"), 0, true, null, 895.3305568498760000m, "1acd8338-7a53-402f-bff8-546f947865fe", null, "Nellie", null, "Jaskolski", false, null, "Nellie_Jaskolski13", "AQAAAAEAACcQAAAAEAwEY2g3/MQxG9Ot6UJVXcUEGmjSXqVocvL43RVyhsaQBCMfjEcaqhTmtyY2EL4veQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84"), 0, null, 34.50334575065770000m, "f8271c9e-d633-4486-94ba-2c6e9e672e23", null, "Brooke", null, "Champlin", false, null, "Brooke.Champlin72", "AQAAAAEAACcQAAAAEFr1yGSiQCUGDIn+OdETO5wpKHfp0rE1Bp24YC5Kb5XBWG3sU3u8h+rojxbef2Z3tw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9"), 0, true, new DateTime(1941, 10, 4, 6, 51, 40, 180, DateTimeKind.Local).AddTicks(5539), 671.5871248199580000m, "bac58313-9cde-4ec9-accc-3b88c076b432", "Rosemary", "Rosemary", null, "West", false, null, "Rosemary_West83", "AQAAAAEAACcQAAAAEKQIstSVfsOmYZkc3IoKouSmf3S1r8SIwzZzMOxR6RBKa69pS6bob/N/VXnDpeZf8g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6"), 0, true, new DateTime(1958, 10, 17, 1, 50, 37, 930, DateTimeKind.Local).AddTicks(6064), 776.492599850010000m, "8179b1d7-f5ae-4899-98eb-901b72eaf008", "Toni", "Toni", null, "Yost", false, null, "Toni_Yost10", "AQAAAAEAACcQAAAAEPnDzJCQPbGD3AaDcvFFr8jUSet8N/YtFs+dZQj4OZAWoL5vURvAwqCXNkJdDYcoyQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456"), 0, new DateTime(1998, 1, 20, 15, 19, 55, 717, DateTimeKind.Local).AddTicks(9274), 714.2972604946460000m, "f968ad3f-04a5-4287-9fe6-66f8d7222db3", "Angel", "Angel", null, "Mitchell", false, null, "Angel6", "AQAAAAEAACcQAAAAELBiFoS/D72HQSPCIxRy323RDXnvd/ENsY7WXIG6GTliCTQt6BqG+7WAVWJCFeh2uw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5"), 0, null, 300.5047150232590000m, "6f3c8fc7-4e11-4940-b462-c551d8bc04eb", "Alice", "Alice", null, "Abbott", false, null, "Alice.Abbott", "AQAAAAEAACcQAAAAEBXEYkqiD8omED5jvoGDMOyrPxL32+OS2A7jupZ55Ntp34geo1J8dEamV6WPW4wlrA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9e803182-b086-4574-bb1a-1bf4ba333604"), 0, true, null, 459.9396415941220000m, "fa2a98db-084a-441b-a342-965654e6a1fb", null, "Roland", null, "Orn", false, null, "Roland_Orn", "AQAAAAEAACcQAAAAELMHC5tiBZZiDCGdB49B4o7IY5vqL3BW5v/tY6ABkvYuuIuj2QCbWzBjliVBEJpz1w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9f745913-393e-4d75-924b-12ed8606f936"), 0, new DateTime(1942, 10, 23, 14, 53, 8, 69, DateTimeKind.Local).AddTicks(4210), 982.2739609862460000m, "61f41af4-3e11-459c-9644-a88c08bb9ab4", null, "Herman", null, "Zboncak", false, null, "Herman_Zboncak", "AQAAAAEAACcQAAAAEKWaqMOfbBuHmIgZSD6752EGVl7H37X1pOd/ONyltIYByIRP2+oEIaTHFvGyjP9yag==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6"), 0, true, null, 676.2951206484510000m, "52f4b1bd-3cb3-486b-8e31-69e9cdc404a3", null, "Frances", null, "Hermiston", false, null, "Frances_Hermiston", "AQAAAAEAACcQAAAAEPKx0I3NW/50o/acsiYfxmjpMxAX7fNkJFpF9lsSqNtbqc8nMPaA/zF39DnjmEUaDg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f"), 0, null, 392.9594911715940000m, "90fe59c2-5177-4f15-9948-8de9ffc6369a", null, "Christy", null, "Steuber", false, null, "Christy_Steuber", "AQAAAAEAACcQAAAAENv+XMQzVO+SJ1J/DYvcfkXesXsEpzeqXrxu0mN0Ls42rekwGCXxpu1bbB24cuSlZQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95"), 0, true, new DateTime(1957, 9, 30, 1, 14, 13, 520, DateTimeKind.Local).AddTicks(784), 3.838268836924620000m, "36ce30f5-3be8-47ac-9a3e-ad48ca1d412e", null, "Mack", null, "Haag", false, null, "Mack14", "AQAAAAEAACcQAAAAENo4Nwsga0qqMn8kykGfiTjX1DcAt56+ZjpeghXoRI2gfVIElk/xMXxD/VS+5jm/pw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a11d6609-e768-4189-bd78-5b34d82849e6"), 0, true, null, 857.5416473832950000m, "675eae17-a7f3-49c2-ae06-fb2d3af3ac40", null, "Belinda", null, "Lind", false, null, "Belinda53", "AQAAAAEAACcQAAAAEP/0nS7PHGmkmGUAVRbc73jX+QZmwb6cps3jleVSgbUKuiVCZkgDF/h/UiqOOULe3g==", null, false },
                    { new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258"), 0, true, null, 783.5628149796250000m, "4a273e93-fc74-45b7-b949-8ffce2b03010", null, "Clifton", null, "Larkin", false, null, "Clifton.Larkin59", "AQAAAAEAACcQAAAAEEB+7+aco+OkJKqM9BPS8N0bpc44IKhRQUw8+RuOxf0jp3Ag33kdH5K46z67A7FiCw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2"), 0, new DateTime(1946, 10, 14, 1, 33, 5, 30, DateTimeKind.Local).AddTicks(3391), 174.9584587264850000m, "e98838af-6e42-434c-9724-d5fb800334bf", "Dominick", "Dominick", null, "Borer", false, null, "Dominick_Borer78", "AQAAAAEAACcQAAAAEBN3kBQ45XxPbY9+IRaI73jRy4Djejcr9/5RqKmmGk6K82Ig7OkwGoz3DBissk2v+A==", null, false },
                    { new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26"), 0, null, 183.49633261620000m, "7bd966ed-c5ec-4dc8-975a-68ab514530f0", null, "Salvatore", null, "Cummerata", false, null, "Salvatore.Cummerata24", "AQAAAAEAACcQAAAAEO432pwUcYrBoA+SZW+lDgoA+OWRWBK0mOsL8Q3/0M5UfVVW2jXUO2xJ26qGVdfmNQ==", null, false },
                    { new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec"), 0, null, 287.3519603790080000m, "65a29f5b-018b-48bb-aee0-c83f178f485a", "Francis", "Francis", null, "Graham", false, null, "Francis86", "AQAAAAEAACcQAAAAELTH/i8uzsM1yBuG5mDEZbHxpoWmocC0cILcUlVYDB15NSq4ZYkr1m9j3Ic1i8A04A==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e"), 0, new DateTime(1932, 5, 2, 7, 31, 0, 482, DateTimeKind.Local).AddTicks(7118), 903.4014555157050000m, "0e118e3d-93d7-4918-8575-8278c6fc8b74", "Amber", "Amber", null, "Nitzsche", false, null, "Amber.Nitzsche", "AQAAAAEAACcQAAAAEBFz2fVP+pJwQP+a6q61p1w+94jGOBQGVKbsvJOPAEK72iH7dgmPYV/oXf3XgVPxzw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec"), 0, true, null, 830.3527589952790000m, "69229c57-a05d-431e-86ae-304636a5a60f", null, "Candace", null, "Frami", false, null, "Candace_Frami82", "AQAAAAEAACcQAAAAEKL0GF7PnNQxQYyI50shxjcf0NyIv9BaBsqdQeH6oN7rBmc5g8awhm/FNrwyB4ML/w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a662b3ad-6def-4527-81c0-400ae1450131"), 0, true, new DateTime(1954, 8, 23, 12, 11, 49, 957, DateTimeKind.Local).AddTicks(2567), 413.2764774637780000m, "bcfa7963-b7b8-4e3b-bbdb-ac4f5fa3be17", "Ruben", "Ruben", null, "Kilback", false, null, "Ruben.Kilback93", "AQAAAAEAACcQAAAAEAPTBpDYx5CWw6j9dYgxco+cU5EOUnkKO9ovWE06oX4j5Csz0UsbIQWCC3CNVVlaQw==", null, "Female", false },
                    { new Guid("a6f0e48a-50d2-402a-b954-f944f339456a"), 0, true, null, 5.95950581564220000m, "b6cdd4b6-b3ef-49a1-a524-0cbe32cc5c6c", null, "Eduardo", null, "Bergnaum", false, null, "Eduardo.Bergnaum", "AQAAAAEAACcQAAAAEE/yqRFd4sJSF3keEkCerOgEZO7xpsWc8tOGnD0A9UtIEvr7I5GWTp6Q/UNgJDGUbw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2"), 0, new DateTime(1928, 5, 8, 23, 44, 50, 548, DateTimeKind.Local).AddTicks(2318), 134.6297924488450000m, "4e7a2803-cb0e-4b3a-8a9d-a5e3e06110f1", null, "Margaret", null, "Little", false, null, "Margaret_Little", "AQAAAAEAACcQAAAAEANOhKAJkuC4pgemeXwVSYxnO0p3M1w7zJXHe8fdBFA29tgEkMS0RJcZtKl2SH7OXA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de"), 0, new DateTime(1940, 9, 17, 13, 42, 45, 439, DateTimeKind.Local).AddTicks(8214), 749.0716178460730000m, "a097ac4a-f05e-4f04-b405-fc74ddc536c3", "Hattie", "Hattie", null, "Leffler", false, null, "Hattie86", "AQAAAAEAACcQAAAAECj44+cmVloBTJdiPKkxfWZo3ueZztjFFJJC39d7Lor2tqixr49xsl7v5QOexC2D3A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75"), 0, new DateTime(2008, 8, 3, 8, 10, 45, 587, DateTimeKind.Local).AddTicks(8727), 618.325918475740000m, "1a405f4c-91f4-43a5-b9b7-607b67b4e771", "Jenny", "Jenny", null, "Crooks", false, null, "Jenny.Crooks81", "AQAAAAEAACcQAAAAEJum6ZdM4Y9C5E914SQPr852+UTIg2QUewQGEW5R4ZMUqD4Ud6b46vkw566kqPMxQQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a"), 0, null, 94.9774075757560000m, "784aa0f9-d5bc-47ba-bab0-83fdaea6a5aa", "Kendra", "Kendra", null, "Larkin", false, null, "Kendra.Larkin65", "AQAAAAEAACcQAAAAEJoUqTk/mVgnyKs+kA8X+arSRq4isinqVAKMJb6V8ywVnUP95tkdLoSbp77Xz/wgQA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4"), 0, true, new DateTime(1954, 4, 6, 20, 32, 56, 308, DateTimeKind.Local).AddTicks(2857), 462.6916054902250000m, "8bfe4a3e-44e9-449a-b2cc-6f1dbc09738c", null, "Isabel", null, "Hartmann", false, null, "Isabel_Hartmann30", "AQAAAAEAACcQAAAAEDHSgnQyWRDyZWa0LuYqSDQRuojkT5CB+pnJLfPKga/JOXKNzfjqGahclxDBq9BOAg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6"), 0, true, new DateTime(1967, 12, 7, 17, 14, 2, 683, DateTimeKind.Local).AddTicks(3745), 457.9493645686960000m, "ff550dc3-9b9d-4abc-8baf-437b6a375136", "Nina", "Nina", null, "Koepp", false, null, "Nina.Koepp50", "AQAAAAEAACcQAAAAEJMvUjOYD7jBqpb7/ug66hDCyq2IWjchAFnIsUoxXZK+n45JFse4lxPQe7+XAZb5Ww==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0"), 0, true, null, 35.72251564111180000m, "d9b51dd5-2bb1-41a4-bd81-b39eafb9a4b8", null, "Ismael", null, "Gleason", false, null, "Ismael_Gleason", "AQAAAAEAACcQAAAAEH1TrIHY1SVYfPSGQbto+vGwjx/Rlx2bUe83Rsa4PPe7ieteAiQBVyunggCJ4HuDvA==", null, "Female", false },
                    { new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8"), 0, true, null, 707.6649714833430000m, "9cfc82a2-0ac5-47f1-a0c4-71c29c043fc8", "Tara", "Tara", null, "Medhurst", false, null, "Tara_Medhurst", "AQAAAAEAACcQAAAAEEpVkKaWm9zji5aKZEXGfsgImp1s/KDGR/hYiod8zKNsznWJrAlFJ66+P5JLC4MbQg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ad9e1016-fdd4-48df-929c-929ac360852d"), 0, null, 22.64358703059270000m, "d9aa0d55-860d-4017-9e49-7d3bafd87609", null, "Jeannie", null, "Jacobson", false, null, "Jeannie_Jacobson", "AQAAAAEAACcQAAAAEL+GfM9F2HCpfj2wGpB3oyYF+8mYvIPturtGw814J8GJwnQ/UKLSMrMMuCtQJGQ8QQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e"), 0, new DateTime(1961, 5, 22, 13, 0, 16, 378, DateTimeKind.Local).AddTicks(8349), 426.7363251206130000m, "f1f63102-0563-4431-9889-2c7cc33e96b7", null, "Jimmie", null, "Ritchie", false, null, "Jimmie.Ritchie", "AQAAAAEAACcQAAAAEOuFbDOzOni/3jG0hfLwymMlMFZ8c4soq0Wq/CscNkc3frgBS1+MpMGeXk3trQMYDg==", null, "NotSelected", false },
                    { new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), 0, null, 494.5398897299220000m, "cba86c18-7a6c-4d5f-b8b8-1db3d83b2ac3", null, "Mattie", null, "Carter", false, null, "Mattie99", "AQAAAAEAACcQAAAAEFL4WTrG18ai/9FA7VvurmbJlE6jQa8vMLUeG9d4UCGIb9BawKMfI+faJlysSZF/sg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2"), 0, true, new DateTime(1972, 2, 15, 13, 18, 19, 344, DateTimeKind.Local).AddTicks(2190), 583.0041815841540000m, "80553195-5208-4c57-b419-4937a6d50d57", "Noah", "Noah", null, "Durgan", false, null, "Noah26", "AQAAAAEAACcQAAAAEEQTpLpUMkMHMc/ZK0BLnZLBAZ9O20ZxzaaAJLOVpWof51s69CANN6wXIHtZdbWX/g==", null, "Female", false },
                    { new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), 0, true, null, 726.9083584712780000m, "53173240-d250-468b-a244-c04718b82f2b", null, "Marcos", null, "Schaden", false, null, "Marcos.Schaden16", "AQAAAAEAACcQAAAAEJ/OiSfoaGbrbWQ/VS7MKO9ymm9dZLlaL5ThBnyrL3f/eRa7Yk/ezT90oEAQrxT5iw==", null, "Female", false },
                    { new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8"), 0, true, null, 836.6147474659570000m, "ba9884c5-401d-47ed-bf9e-716e08ba81d1", "Maggie", "Maggie", null, "Waters", false, null, "Maggie.Waters5", "AQAAAAEAACcQAAAAEG4fjqiEbUNpaEOUnnf7/plJ8ziQAjYJeqX0E3W8cRv51C2WWY+h90URKDwTrPQscA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0"), 0, null, 602.2198846849240000m, "4d89532a-e7a7-44df-9222-43fe120ec73f", null, "Laurence", null, "Windler", false, null, "Laurence94", "AQAAAAEAACcQAAAAEEGTLG5/JssvudqQLl9QgpY9YXP8MWqGyhalo8T2LUINr4BP4Uk4XOtigItvdjNzVw==", null, false },
                    { new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718"), 0, null, 831.1308619788360000m, "2b6b9b1f-48f0-4775-9b5e-95da3d19f873", "Gertrude", "Gertrude", null, "Morissette", false, null, "Gertrude.Morissette53", "AQAAAAEAACcQAAAAEOPyujj/Hbr9HAkQOxsEJ+AVKYMOqs4xc72fDc511zLEnl4jvF7Jd2K5bAOmYB9P8w==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c"), 0, true, null, 674.7094014781560000m, "7f33f54e-4947-44cf-9eec-243eb2c7550f", "Della", "Della", null, "Oberbrunner", false, null, "Della.Oberbrunner", "AQAAAAEAACcQAAAAEIYhXlWe0TOAIiLfLweebMDwiw3l3KaMQC5II64+nHiU6LsGcXFsj/+FeHUmuNH7fQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df"), 0, new DateTime(1976, 12, 12, 21, 46, 24, 294, DateTimeKind.Local).AddTicks(7229), 674.0228886473680000m, "7525f843-5a4f-4e87-8ff8-57ed63746af1", "Gertrude", "Gertrude", null, "Bergstrom", false, null, "Gertrude_Bergstrom70", "AQAAAAEAACcQAAAAEAYdUpzw7lf2xSfDeDYVUAKrHRVV4b+nB5ztn1ruCBRU75oOWacCHd4lL0/cU2lLOg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30"), 0, true, new DateTime(1955, 2, 11, 15, 25, 30, 540, DateTimeKind.Local).AddTicks(5043), 590.2165340725170000m, "63e74874-cd0f-4b07-97b6-0ebbf716aea0", "Jonathan", "Jonathan", null, "Mayert", false, null, "Jonathan59", "AQAAAAEAACcQAAAAEMxD6U/ZJdRIIZ2yca2H9qnZrDp5WKMCv9DaSAG5TLoC9sDyu+y278YB7hnG2smDOg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e"), 0, true, new DateTime(1928, 2, 14, 23, 4, 38, 28, DateTimeKind.Local).AddTicks(1395), 937.6039021755990000m, "e190981e-de9a-4459-b084-0906470c4dc4", "Dianna", "Dianna", null, "West", false, null, "Dianna.West", "AQAAAAEAACcQAAAAEIP4zCPb5A3838Q/XRMukRRFLcFXQo6tSQqQRXYaDKipzZG6N85JSKufPScLIfY1YQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47"), 0, new DateTime(1973, 1, 2, 9, 34, 2, 694, DateTimeKind.Local).AddTicks(9565), 786.3443806134740000m, "57000b66-17c7-4873-89c8-90a45c8f8228", null, "Eric", null, "Kshlerin", false, null, "Eric78", "AQAAAAEAACcQAAAAEOotFwRv0zo9o1XL6fPA2P62z52eY1UMDZvqdluI85IOdhUxlXiZ4+ulBIb6Z9W+og==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376"), 0, true, new DateTime(1961, 10, 26, 5, 16, 8, 139, DateTimeKind.Local).AddTicks(1962), 77.49898819887120000m, "b606136f-0dff-4bb7-ad75-2c806b4f9bf6", "Hugo", "Hugo", null, "Fay", false, null, "Hugo11", "AQAAAAEAACcQAAAAEEcPGWqn9MJaB/YfUcp4nfBfH+SG2ety/7wvwj20x0GckErM5va632LxVYxz042MQQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674"), 0, null, 336.539063962920000m, "99a08a33-939e-4084-85a7-d1276e825fa6", "Flora", "Flora", null, "Donnelly", false, null, "Flora47", "AQAAAAEAACcQAAAAEBl8f3FS7LH+FWHVRlZR29MVclg7QFyTcLa+YR9fpJqNUHTtJuvbXDMbfyoxwlQhWg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867"), 0, true, null, 924.278585056460000m, "268d46f1-c5f4-4fec-8daa-33922902b8ea", "Theresa", "Theresa", null, "Walter", false, null, "Theresa.Walter", "AQAAAAEAACcQAAAAECNx50c7ugzOnj9BkW+e6ozaOS8r6bjzNihnHHarJPAL8T+bbqw517CwFW47Wl92kA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c0886dea-4971-4369-8d28-75754e2575d0"), 0, new DateTime(2006, 10, 18, 11, 3, 55, 651, DateTimeKind.Local).AddTicks(8921), 951.1687681987040000m, "34cfb832-bd8f-4043-bc82-661776f18b36", "Jermaine", "Jermaine", null, "Hintz", false, null, "Jermaine_Hintz54", "AQAAAAEAACcQAAAAEMJXMmC46+RbvV2lCJrcv9Js7R5VnBann41quAyff7hWJnchP2G6D6GaN5DwJmqQEw==", null, false },
                    { new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7"), 0, null, 997.1244644038250000m, "003f5658-a5a0-49f3-a6bd-2485efcc9c9a", "Rosie", "Rosie", null, "Boehm", false, null, "Rosie.Boehm55", "AQAAAAEAACcQAAAAEPScE96COO0atLRsNCzRfPD/KJ/e8Wn6dl9QvvzG6Hy3vMxgXxIEyzbw4PGtyvqmWQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7"), 0, true, new DateTime(1981, 2, 28, 6, 17, 23, 567, DateTimeKind.Local).AddTicks(6359), 157.5147810419130000m, "c2397e7b-39b4-45e6-9f8a-23594e7f45b4", null, "Chester", null, "Fritsch", false, null, "Chester.Fritsch", "AQAAAAEAACcQAAAAENS+CQJBDG6nT9AEXrAx+fFcbps9IU2pAcuPpgWz/wHzK3OFyoH9+ftMRKBoCsKkMw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46"), 0, true, new DateTime(1968, 5, 9, 8, 52, 0, 448, DateTimeKind.Local).AddTicks(749), 880.6316208015680000m, "3307dee8-7508-49e2-91a9-2591c8dd90b0", null, "Mona", null, "Abbott", false, null, "Mona.Abbott96", "AQAAAAEAACcQAAAAEHDp8VjzwhmWzxfjJXlbB5cghw3GCrCVeV5CO6fgw0RAIEh5Yv8Vntg7EYVpt/LACA==", null, "NotSelected", false },
                    { new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0"), 0, true, new DateTime(1996, 5, 8, 17, 31, 19, 493, DateTimeKind.Local).AddTicks(9715), 684.258632190550000m, "a667728f-4b4e-40b7-a07a-1d80111bfa2d", null, "Cornelius", null, "Mills", false, null, "Cornelius93", "AQAAAAEAACcQAAAAEGFvSYrr3Xza1nT4XDVWmpfRjiCJk6VtIQKzZQ1AyAuQD91iU28SRxZrv0uOxF2vMA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4"), 0, null, 945.606690838250000m, "d8b58124-e4da-401d-b9ad-fd3bddb2510d", null, "Cindy", null, "Bailey", false, null, "Cindy.Bailey", "AQAAAAEAACcQAAAAEG+enQuOWcsgK5U3ko6mSX8wTrNuxZrctvf9hHju+eiM+oLky/6FxOPfe1XkM8vRvA==", null, false },
                    { new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9"), 0, new DateTime(1925, 10, 11, 20, 22, 51, 497, DateTimeKind.Local).AddTicks(6232), 215.9558576482260000m, "26a7efd2-1a33-40c1-84aa-5c30981994ab", null, "Jerald", null, "Hermiston", false, null, "Jerald.Hermiston", "AQAAAAEAACcQAAAAEJF6JQSPlNqDYDPRe/yIUlpTRirwQixO8nB9k1YjK+tnuqBNCp8um1TDE8FEaPfcHQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131"), 0, true, new DateTime(1960, 10, 25, 7, 32, 23, 702, DateTimeKind.Local).AddTicks(1662), 254.8127407194840000m, "b2c331b8-307f-4609-b9df-fd12d8c959d6", null, "Evelyn", null, "Stokes", false, null, "Evelyn_Stokes90", "AQAAAAEAACcQAAAAEG360NRb81NNcWdxVTxkUP+0St3/+fGF+7r+/9nKqROi/UbbFgTwUm4773Wx8LUW5w==", null, "NotSelected", false },
                    { new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a"), 0, true, null, 824.6155311611080000m, "b8fe78f6-b1da-4db9-80dc-4b28df1acb29", "Victor", "Victor", null, "Bauch", false, null, "Victor_Bauch", "AQAAAAEAACcQAAAAEAUH4lMavoou7abc+pvnUfw5Plznuh2Qfr3gDqSL+eobOD0pKKtVjxJ15lNWKI+TXw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c72abfe8-e65f-4011-a62b-ca07be376511"), 0, true, new DateTime(2006, 7, 24, 3, 14, 36, 450, DateTimeKind.Local).AddTicks(3735), 876.3425688403210000m, "b528201b-d7b9-4b3b-8587-36e9587c138f", null, "Armando", null, "Prohaska", false, null, "Armando_Prohaska2", "AQAAAAEAACcQAAAAEC1wjG5U7+DjFs6JjpZoPOY5QixP5FbplBZD7eAtKeStJQ7LNwNOp5w1w5phT0r3cw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03"), 0, null, 764.2534762948930000m, "0fcfae7b-eb8b-4a15-a17c-f41b50fa8469", "Neil", "Neil", null, "Dare", false, null, "Neil45", "AQAAAAEAACcQAAAAEBxODjxl+LjHYNXifEBawh5+Hq/zXie/gxh+3MTD1sx3a7VvMzjXQg9r3mYTI7HzNQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88"), 0, new DateTime(1992, 3, 22, 4, 51, 37, 501, DateTimeKind.Local).AddTicks(15), 359.5823282661150000m, "efd29a97-a84b-492d-9987-514ab7644b07", null, "Jacqueline", null, "Welch", false, null, "Jacqueline_Welch97", "AQAAAAEAACcQAAAAEEo/BvSftgpbs0ottSUyIMAY3QvRF7qnIdAh4xFy+vUBJ2pXez3MY1JOt8LPxnewVw==", null, "NotSelected", false },
                    { new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96"), 0, null, 325.8092669715690000m, "014c9e63-78ab-43c4-89f7-5eed8081f83c", null, "Meredith", null, "Abernathy", false, null, "Meredith_Abernathy", "AQAAAAEAACcQAAAAEAaaw7btp3Z+KypOQAoYVL5FU2uYw6CAQuQTL40sXRFypefFkarm7P3gAqcTjuNOYw==", null, "NotSelected", false },
                    { new Guid("cb635093-0872-4986-8027-340de9f12a5c"), 0, new DateTime(1997, 4, 25, 11, 6, 32, 11, DateTimeKind.Local).AddTicks(1497), 819.3772098403580000m, "c6d34808-8f5b-42bc-925f-2bb4addb1d67", null, "Jon", null, "Schaefer", false, null, "Jon.Schaefer35", "AQAAAAEAACcQAAAAEHMp0YvUz3QwEIO9DBv3UZeFc8bmAq/OSlo4eUIDcyHN3i2VGkcQp/IZgo8FSwgG9g==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861"), 0, null, 507.3181369237610000m, "614a65d2-8ae5-4445-82c5-9b018750459b", null, "Francisco", null, "Kirlin", false, null, "Francisco_Kirlin9", "AQAAAAEAACcQAAAAEDwZwCAKKLGGxV64kE34oymTraHHD7LUHZmKQGCeFZT0/ZkgAqiMR85pmbSJpBh96g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072"), 0, true, null, 289.7119854124380000m, "afd6b409-ee7a-4255-96f3-b91363df4650", "Thelma", "Thelma", null, "Goodwin", false, null, "Thelma89", "AQAAAAEAACcQAAAAEINsCTLV7AhSADXTEEumuL3G8Rb5fUYBnRlX/ps9eT+N4ElalBXtQCpsezdmiUIJWg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5"), 0, null, 18.15558340026060000m, "c2c0516c-3cb6-446a-aa6f-5424f89a829f", "Clyde", "Clyde", null, "Rohan", false, null, "Clyde9", "AQAAAAEAACcQAAAAEBaGQUTYdThVvhvglWtmBMRpLxyERpIK5KTTQ33y6v3aAqDulGyYvxa1wxo5ZeXwrg==", null, "Female", false },
                    { new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48"), 0, null, 355.710948619230000m, "d8a73e2d-75b2-44d3-915d-db335fd5e550", null, "Alexis", null, "Cartwright", false, null, "Alexis_Cartwright23", "AQAAAAEAACcQAAAAEPdSm9gZN1rmZwmAJFnfKJW4wmdQwPOizMrKXXIy9So8OY4rrq8cfwSXZyyfSzzsbg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), 0, true, new DateTime(1981, 8, 16, 11, 38, 40, 798, DateTimeKind.Local).AddTicks(8729), 557.5239579361630000m, "97138beb-3285-4fb3-93b0-146195ce3ece", null, "Leo", null, "Rosenbaum", false, null, "Leo.Rosenbaum75", "AQAAAAEAACcQAAAAEMKSZwPxCZdoq5vz4+0pyQoEln5ElQkCDxUpQHSVo9U/djcU0DPrJ1DUguVOakRmow==", null, "Female", false },
                    { new Guid("cfddcc04-5205-447d-9799-6d1945c391b4"), 0, true, new DateTime(1947, 9, 30, 15, 33, 48, 568, DateTimeKind.Local).AddTicks(9493), 607.3221904391480000m, "c510e0be-e3e5-4ffc-8916-553b7164def7", "Harriet", "Harriet", null, "Kunde", false, null, "Harriet38", "AQAAAAEAACcQAAAAEGz3K1gjjYCJdfvfJeQLYd5sgQN12U+JkNUpScG5dBg132YmBgqPR8Ll864JrctPyw==", null, "NotSelected", false },
                    { new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8"), 0, true, new DateTime(2007, 11, 19, 19, 10, 6, 793, DateTimeKind.Local).AddTicks(5229), 465.9773908086740000m, "3b9e929d-1b71-4f3e-bfba-df29b27baf03", "Sara", "Sara", null, "Breitenberg", false, null, "Sara_Breitenberg", "AQAAAAEAACcQAAAAEOPiymUnpQslTZzFHpk5aSpTSC1oeB4Y3kJTB/LpG2xf6MrAHEuqMV9dYH5DyHu/ow==", null, "NotSelected", false },
                    { new Guid("d21f18d0-79a0-4851-976c-b989e790eac0"), 0, true, null, 251.8563559116820000m, "983e5b15-a034-4f95-91cb-06a4d7ef53ad", "Garry", "Garry", null, "Hamill", false, null, "Garry.Hamill", "AQAAAAEAACcQAAAAEG9vCgVnerRDpBq2AXiAFwg5tPMysyowleBOFDLiXgwbUDonmCz22Od7JW01meiURg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d2398055-2472-48c3-a850-a08fbba5c777"), 0, new DateTime(1927, 8, 30, 3, 47, 59, 322, DateTimeKind.Local).AddTicks(7290), 698.3497897284030000m, "178be80d-e729-4102-a033-61499befa7b3", null, "Luther", null, "Price", false, null, "Luther_Price54", "AQAAAAEAACcQAAAAEHB83VgM+qPgT9+5B/TrqtDB+2dt0z6eKa1anHIFEndvflzvzC582b+kaEc6in9hqA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22"), 0, new DateTime(1965, 6, 2, 18, 24, 33, 455, DateTimeKind.Local).AddTicks(3534), 866.8490880151420000m, "2a12c0fa-63a6-4c69-9268-f8315b4787e1", "Judith", "Judith", null, "Harber", false, null, "Judith_Harber27", "AQAAAAEAACcQAAAAECVRvyXLrtCVdhNLxR1XXgNQvFQc70d6fykmy/Xu4bsww/sgRbsH0AMvi/Xd7OeWJg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d422e4b4-5d7b-484f-830c-319350a69b22"), 0, true, new DateTime(1950, 1, 8, 5, 43, 54, 747, DateTimeKind.Local).AddTicks(584), 890.4526468640990000m, "46b3e22f-ec57-4697-a7cc-bccb6796cad9", null, "Marlon", null, "Tromp", false, null, "Marlon.Tromp90", "AQAAAAEAACcQAAAAEGWNQ55RxYLe0qvN7/XrWZyAHdrs8Roq7xzjWDytIL9WAi12jUWxravG0KQxv5ZH9Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81"), 0, new DateTime(2002, 5, 16, 18, 59, 17, 768, DateTimeKind.Local).AddTicks(7916), 559.4912809853790000m, "35476f03-3609-4a1f-bce0-c2bddeff1ddb", null, "Noah", null, "Green", false, null, "Noah46", "AQAAAAEAACcQAAAAENGSSOPTDx7pMFZgIRrl+Lf19JakoLN/PzqHAdktV2SoA9JpOsQlnKNT0m27dBhGrw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042"), 0, true, new DateTime(1973, 1, 23, 0, 20, 46, 41, DateTimeKind.Local).AddTicks(5518), 485.7636935086130000m, "a4f37068-b852-4943-bf0a-654b3c760a12", null, "Jay", null, "DuBuque", false, null, "Jay_DuBuque67", "AQAAAAEAACcQAAAAEPesGIkTr9ACK8I1cYPWMRu756BejhCusr6sAru9NogCElZ/q92UmGg8uC+BrUXk2A==", null, "Female", false },
                    { new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628"), 0, true, new DateTime(1933, 12, 27, 15, 24, 10, 467, DateTimeKind.Local).AddTicks(1054), 137.2999367169290000m, "1327fc32-b553-4222-b357-7ccfa70e6f90", "Craig", "Craig", null, "Mills", false, null, "Craig_Mills30", "AQAAAAEAACcQAAAAENVCHMuK+7oWMAHdEfP/LfX+8EWmiq0fSqCY/Vh9d3Bus4ECoHaKB2qxNNPcYNDfLg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5"), 0, null, 651.0179649280210000m, "afa81449-3e5f-448c-a29c-f42b0f6ee7d3", "Vanessa", "Vanessa", null, "McGlynn", false, null, "Vanessa.McGlynn", "AQAAAAEAACcQAAAAEJaF/udeRMUDPiNpIGWZ1rxTLwoKS+lz9zMlewinzhbO3IaVexxz2gKJW4jbzRdQyQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440"), 0, true, new DateTime(1989, 2, 7, 18, 21, 26, 687, DateTimeKind.Local).AddTicks(8567), 849.5687473152680000m, "c0cbbe08-4013-401e-a8df-f0566bc1174b", null, "Victor", null, "Spinka", false, null, "Victor39", "AQAAAAEAACcQAAAAECK9j+KWWsQcgONiW+oyru/slBJ99JW2A6r5BZsths88TDqLwOUYUIERdDQcbnFNHw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0"), 0, new DateTime(1966, 1, 1, 12, 25, 53, 859, DateTimeKind.Local).AddTicks(3744), 854.1142401960740000m, "f9ef0abc-acdf-4600-a461-9f88c9983853", null, "Kirk", null, "Langosh", false, null, "Kirk34", "AQAAAAEAACcQAAAAEAzFV8aKsT4ZVngSUtbaBo/tGKcQuyST/26IbnpEp357Zu6A9SyOGNAhghf49ripaA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa"), 0, true, null, 550.2725509918220000m, "f72cc8a0-47c4-4e73-ac8d-eb07aab7b3b7", null, "Irvin", null, "Casper", false, null, "Irvin_Casper23", "AQAAAAEAACcQAAAAEIQeGlFXDJDQq/mHrqudwtivIzQNEOAfi7aWlXe+Y/2hPSlt3888gBulefpzc3/0OQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), 0, new DateTime(1925, 5, 8, 6, 23, 1, 993, DateTimeKind.Local).AddTicks(3289), 126.3661815390830000m, "c56532d7-2f07-4977-aa14-6dfec0dc8719", "Leslie", "Leslie", null, "Padberg", false, null, "Leslie_Padberg75", "AQAAAAEAACcQAAAAEGzIsJ6XMGiZH7hV0O1BlsJUJPFhSDU/+3P98xFGI4QQKBsvszkuQQd7nac7nN5wtg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3"), 0, new DateTime(2000, 3, 29, 8, 22, 18, 142, DateTimeKind.Local).AddTicks(5485), 677.7897566919130000m, "71b07255-ece1-42fb-8a17-46282e188e5f", null, "Jennie", null, "Nicolas", false, null, "Jennie_Nicolas", "AQAAAAEAACcQAAAAEIe0iBqn2wrk7tT+UJLj67z0MpGwxZxRSqxfN1TyIExsytaSuyaE8O2ntnvRX9pdoA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b"), 0, true, new DateTime(1985, 5, 31, 5, 50, 53, 961, DateTimeKind.Local).AddTicks(3127), 416.9188587886260000m, "7f8fef3f-d627-41b3-9612-34e47e131389", "Martin", "Martin", null, "Paucek", false, null, "Martin73", "AQAAAAEAACcQAAAAEM4nQIOEb/o36Wm82X/3lJXhi5B7gstJu0xj7PcpAylX+A6Rx3YD2Mchl4PoypU+zg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186"), 0, new DateTime(1979, 2, 25, 18, 22, 17, 189, DateTimeKind.Local).AddTicks(1175), 288.0968311984760000m, "9a781244-42b4-4015-b43a-8ab5ce297367", "Sonya", "Sonya", null, "Schultz", false, null, "Sonya_Schultz45", "AQAAAAEAACcQAAAAEC/qYW9eP3x4uLSlQDIoDVPbJdC8NM7tbi+0u1P+EDya6bAQSb/7qlhAGpafMp86mQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b"), 0, null, 759.2309078158630000m, "82e2acb5-808f-468e-84a7-208a419f332b", null, "Nora", null, "Hirthe", false, null, "Nora77", "AQAAAAEAACcQAAAAEKXd1CBBZtpzjv98KPXNuPAP/Puk6VcLvgy1fTwsQ9lyYvWaCWTs8J7kIrzWSmr4cg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2"), 0, true, new DateTime(1959, 6, 20, 2, 1, 20, 833, DateTimeKind.Local).AddTicks(6303), 214.394383486180000m, "f689f4ec-564b-4ec0-84d9-76daf47f33b3", "Alfredo", "Alfredo", null, "Lesch", false, null, "Alfredo_Lesch60", "AQAAAAEAACcQAAAAENioPpGRuA49U7Cn6FgEWKWZedU3aWdrvzf6OnoxIjlBAaaeP2solAwP8TlUDPtttg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe"), 0, null, 577.8829751893740000m, "b263cd64-59d4-4928-958a-42c04a59586d", null, "Todd", null, "Borer", false, null, "Todd37", "AQAAAAEAACcQAAAAEHaa53/jP51u2QMoE5uZKZ3JWEuG4mIc8PyMREfMP9qVZsedhMbq7FFgSL9Mxg+ZLQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19"), 0, null, 754.1199283047130000m, "98e4a5dd-8add-4bf1-b6e5-06c4742b736c", "Wade", "Wade", null, "Christiansen", false, null, "Wade4", "AQAAAAEAACcQAAAAEIIr9Z3qP6fHFwvUd+w19kyY/2+D8tEY0tWgsz2htJnQKC7CM/bikHl0+BeAh+ncQg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e2125995-cb39-40eb-b23a-1483130a7d40"), 0, true, null, 318.5426978454560000m, "6a89bcb1-7a89-429a-a0e4-e707b61e748b", "Ray", "Ray", null, "Macejkovic", false, null, "Ray99", "AQAAAAEAACcQAAAAEBA/flquxLu8pRaw8/RPzRcvjpL6csmcrtjr7YU3u0TtkHBquP0DB+MxuX30MnTpCQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98"), 0, true, null, 292.1490336258240000m, "cd33c735-17f4-4156-b9b2-f092cbf69442", "Nathaniel", "Nathaniel", null, "Brekke", false, null, "Nathaniel.Brekke", "AQAAAAEAACcQAAAAELkwg/EQJ416thTOb3+5dKiVBYy/xbky8yv1FLns3/Iby1KLYX3Ed0haw/TCfLNc3Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7"), 0, null, 718.173361543960000m, "05513b9e-f503-4816-88e4-5f3925f42548", "Clayton", "Clayton", null, "Farrell", false, null, "Clayton37", "AQAAAAEAACcQAAAAEFJigAZosM267HFQgBQL+WE1MtEWF0c218D0aTsRpPGnZWofr5kKV+CsA4i1pXh7MQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e2c0f944-e30b-436d-966b-858138b547a6"), 0, true, null, 485.124369218450000m, "98cf1d3d-2cf8-4728-9892-de3552c4c189", null, "Terence", null, "Kemmer", false, null, "Terence.Kemmer", "AQAAAAEAACcQAAAAEH+5RNYd/UO7az+VmPmw5YK9ruZSwmTL7YVKpDnoxN1dZ65t27unouA7x5HOf6xcfw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa"), 0, true, new DateTime(1993, 2, 8, 0, 5, 12, 304, DateTimeKind.Local).AddTicks(7168), 539.968068363690000m, "7dee3358-d843-4c1c-bbc4-7d0219fa0abd", "Rudolph", "Rudolph", null, "Pfeffer", false, null, "Rudolph.Pfeffer80", "AQAAAAEAACcQAAAAEFrLTFzXwaGrDgv3BLw7mTxOXbTMZCWM41ENRCgnb6aPqIZ5IOMJQx4SbP6pn3KGww==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7"), 0, new DateTime(1937, 2, 6, 8, 39, 45, 933, DateTimeKind.Local).AddTicks(6644), 316.6001238160960000m, "249aab28-e7f9-485e-8110-0046017db060", null, "Brent", null, "Kub", false, null, "Brent.Kub11", "AQAAAAEAACcQAAAAEBBosmFVfYtTpHs9hwDnhTLUtltFF0WZobCBXe9zssJabkMdTkxzaVpUhEDoth3sAg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e5873863-5f02-49f2-b6e6-faae1acea124"), 0, true, new DateTime(1930, 9, 3, 17, 7, 32, 502, DateTimeKind.Local).AddTicks(8951), 302.5623135431310000m, "dd0a7852-43ad-4fcf-8249-96d6e1f3ee8c", "Cecilia", "Cecilia", null, "Herman", false, null, "Cecilia.Herman", "AQAAAAEAACcQAAAAEAmdHqpnqnJNFV8ZTl3ol3JUKLfoMhE0AgeK7HqUe+dCOgjIV8mVwVYBk2h9fVuldA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e5acadcd-43bb-4225-9367-f562e86197e5"), 0, new DateTime(1928, 12, 21, 18, 43, 25, 365, DateTimeKind.Local).AddTicks(6401), 300.917481778490000m, "d71ddbce-b949-478f-8e00-61b5cddd8c83", null, "Virginia", null, "Ziemann", false, null, "Virginia42", "AQAAAAEAACcQAAAAEP3tnTP8k7w2/G+PxzF+83amptbWBLE/kCHsfu72FbCy32vmiD72pkUCvRq5UdkWsA==", null, "Female", false },
                    { new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4"), 0, new DateTime(1976, 11, 10, 22, 18, 34, 668, DateTimeKind.Local).AddTicks(5118), 517.4017332002560000m, "2639dab3-3e9a-42eb-8cee-dc278857a0fe", "Sophie", "Sophie", null, "Bernhard", false, null, "Sophie13", "AQAAAAEAACcQAAAAEC55EsJ7oJ7Zk2jdeWkvJq0WPpTreXt6+uE4vc2K4kehjv2aGZxMAaXxG7aLXHeknA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b"), 0, true, new DateTime(1971, 8, 6, 11, 6, 3, 810, DateTimeKind.Local).AddTicks(5025), 250.6585934991590000m, "829fbdcf-6c1c-4841-bfbd-738ee6170f71", "Orlando", "Orlando", null, "Krajcik", false, null, "Orlando.Krajcik86", "AQAAAAEAACcQAAAAEOCH5rVYtndDrrVBL9rF/W/PqiVcFvmOHLuFPHtatyyqd4RBnazXj7tp0sVNfbXjLA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c"), 0, true, new DateTime(1975, 8, 13, 6, 23, 35, 184, DateTimeKind.Local).AddTicks(8514), 698.414475529290000m, "548539e9-39a1-4214-9d1c-995cacf21835", "Robin", "Robin", null, "Altenwerth", false, null, "Robin34", "AQAAAAEAACcQAAAAEJGbBhLTSJLL79nUlUu5BSyV/E5sPaZ4NNoNtwmj/nI52b5oRqJ5prYJltS7B+ycbg==", null, "NotSelected", false },
                    { new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c"), 0, true, null, 288.6978325584610000m, "2c209ed6-39de-49bc-913b-a3266ff6e9c0", "Becky", "Becky", null, "Kuvalis", false, null, "Becky_Kuvalis", "AQAAAAEAACcQAAAAEAQWuew/yTnwXmJoTqR3uWnQlDBYvaDkN0R7fIy0+lmejm1j4K+rgbd/IX1CkugeTg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b"), 0, null, 483.4201820591220000m, "9deaa08d-edd6-434f-a694-f22d2e0c40b3", "Silvia", "Silvia", null, "Anderson", false, null, "Silvia1", "AQAAAAEAACcQAAAAELyNbGOo1X1apykdBcTpFQTK9RbMYFB9sDrChGW84TPQZ8aE9+nXkMcM44AgfJZ0mQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651"), 0, true, new DateTime(1965, 12, 5, 3, 47, 45, 581, DateTimeKind.Local).AddTicks(322), 794.4382949566670000m, "3072cd9e-dbb8-4600-9e87-fa8d87f567c4", null, "Delores", null, "Flatley", false, null, "Delores_Flatley6", "AQAAAAEAACcQAAAAEFzIQqK4tdwt+YNviNeInTxYTrASDrsQOCfbvSrC4R6/kxNP2lpoMPE/iijUds2OgA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5"), 0, null, 604.5864836311550000m, "203d391d-0285-494f-aa0a-9d79c23e0037", null, "Elmer", null, "Gleason", false, null, "Elmer_Gleason", "AQAAAAEAACcQAAAAEC7Uq9pBWdVsOdlru/cMm5X8UGgFIEYiK9DywuEyiLPegH6pXUmusZoTr3V5hlR+uw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ececce7b-505c-4bc7-b969-56ffcc451462"), 0, true, new DateTime(1967, 2, 1, 9, 29, 54, 651, DateTimeKind.Local).AddTicks(9068), 970.4827604587210000m, "97957a00-04b7-437e-9ca2-7a5a9f7d940e", null, "Sheryl", null, "Zboncak", false, null, "Sheryl_Zboncak84", "AQAAAAEAACcQAAAAEMyqQZXQqVqfzx47Jh8Q/9IDCvo8LApgKF7vJu1KtEvNFcBlnAA5IvJdkvAOBo09qQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf"), 0, new DateTime(1931, 7, 11, 22, 52, 26, 69, DateTimeKind.Local).AddTicks(6246), 147.9246431958180000m, "87c18a68-0500-4ed8-b211-e71a03c54be4", "Roosevelt", "Roosevelt", null, "Kuphal", false, null, "Roosevelt_Kuphal49", "AQAAAAEAACcQAAAAEKIXaTchW7BbnZaxupmrOxCrYZSpYc0/gCpH8sruw8PKHa1e26lUXOY0B0MklKQslA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d"), 0, true, null, 513.5957141461050000m, "81e0fa93-5c84-4b5a-93d3-e400dd3678d0", "Julio", "Julio", null, "Lindgren", false, null, "Julio_Lindgren44", "AQAAAAEAACcQAAAAEJP9BiDGvzEer0nHS+bg35KQbXqICUU0FONT/tUktSuPLVnt3axQqZO+u29JT4duEw==", null, "NotSelected", false },
                    { new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d"), 0, true, null, 859.7251516305390000m, "75f5c650-c4b1-4f5b-8573-db97cc9a219a", "Martha", "Martha", null, "Quigley", false, null, "Martha_Quigley65", "AQAAAAEAACcQAAAAEGg1ce/4PnxU6YdJjYcRBr5q3a7o7FpEBgQ9g0IUAW2l9FGXCfuu507gTBzzbWiRtQ==", null, "NotSelected", false },
                    { new Guid("f1038abe-cd17-40c4-844a-70a0ee863724"), 0, true, null, 768.648205908680000m, "d5ec091c-d2bc-4ce7-a5b9-c1c51461570a", "Joseph", "Joseph", null, "King", false, null, "Joseph.King", "AQAAAAEAACcQAAAAEIvQwlm2e/We0heEF2IsX6AZTuhMb51RyM8gmGvhs11EuZsg8olfa7HnMny5dESzNQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584"), 0, new DateTime(2005, 9, 22, 8, 52, 39, 579, DateTimeKind.Local).AddTicks(5734), 404.754333281140000m, "c71ac8c7-7d26-415d-aab4-82f98e3a0700", null, "Hannah", null, "Ryan", false, null, "Hannah50", "AQAAAAEAACcQAAAAEI2WmA9F5IHHKDgdh6hNEinez5ZJ6CEQnPfLwp0yNvo/wBlDVqyFG/CWa38NoY2Pdw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59"), 0, null, 456.5769359903780000m, "d5c4ee9d-2826-4772-86d7-6f4f05ca4d1d", null, "Guadalupe", null, "Bahringer", false, null, "Guadalupe_Bahringer", "AQAAAAEAACcQAAAAEL3Yi33ovD1pNA8jfSbIkF2ku25rb6xm0uUY2r2kjsm88b85SmEXNVwwTJtC/l6CPg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425"), 0, true, new DateTime(1938, 12, 28, 23, 20, 43, 993, DateTimeKind.Local).AddTicks(9487), 756.2620226683890000m, "52d158ac-e1bd-43c7-8e63-9971d826e94a", null, "Matt", null, "White", false, null, "Matt_White", "AQAAAAEAACcQAAAAENVWnNDcZX2Apj4yJ4CNa4dxDpETX5UoTBMsdzGfRDj5q/aKB7M4D7IxBw6quE5amQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb"), 0, true, new DateTime(1970, 5, 25, 12, 34, 58, 47, DateTimeKind.Local).AddTicks(4213), 767.7961830127650000m, "245dfe91-ed3d-4d5f-9a08-748ce52e9a06", null, "Trevor", null, "Wintheiser", false, null, "Trevor_Wintheiser", "AQAAAAEAACcQAAAAEEUu/3cnDm3HRDBiLtNDjOCIzhjSAM7g567Afmy6OYqpMc8R/tZw4ZOa60jgydoz4A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075"), 0, null, 745.1213070813390000m, "fa8f111e-d092-4b75-baf3-75533601bdee", null, "Wendy", null, "Bashirian", false, null, "Wendy_Bashirian", "AQAAAAEAACcQAAAAEN2A+n+hji0dv+mD92pT3CqB6NM73VwklL5g2AjIjiotY05rwEaQEdTXscVujLjsWg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816"), 0, true, null, 294.6834339405430000m, "cbe5ac55-bab3-4f80-87d6-ad9a5440b5bc", "Bruce", "Bruce", null, "Rau", false, null, "Bruce.Rau66", "AQAAAAEAACcQAAAAEI2qXfh6+d4jJ5ky3GXfhS0OAanquAKlon5QzcA39Q7t0Lt8QUCYoe7x12Hx1bQGeA==", null, "NotSelected", false },
                    { new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac"), 0, true, null, 628.0163116187360000m, "b161b45c-3d9b-4baa-92f3-6cda83cffcbd", "Leslie", "Leslie", null, "Swaniawski", false, null, "Leslie50", "AQAAAAEAACcQAAAAELjNYYMaW98KgZSO4fxgav6wp7jIoeo2GmOeWo4JSBO6LTOpRtOVupzw+kB7W1OiBg==", null, "NotSelected", false },
                    { new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa"), 0, true, null, 721.3809411640880000m, "b73153b5-7080-4846-b4f7-ce2b0e78dcaa", "Casey", "Casey", null, "Kuhlman", false, null, "Casey.Kuhlman12", "AQAAAAEAACcQAAAAEOmH2tR8/mwK22oDmBT2UYo19OONDSwGBJ57VIsnn16RIWamtoOUcMuECQtoX7yeDw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f7720de3-aaea-48e9-af48-569af731d90b"), 0, new DateTime(1948, 7, 6, 4, 27, 31, 514, DateTimeKind.Local).AddTicks(6978), 149.4998278790190000m, "8ec8aa5c-405b-4058-a71f-14b028507721", null, "Alberto", null, "Purdy", false, null, "Alberto_Purdy", "AQAAAAEAACcQAAAAEJEjrfDOfP/neKLeTnPNS8FQUOZ4rRmcoPQaYQSX5hmfkex3N+U0fqQijYk87zLfVQ==", null, false },
                    { new Guid("f7e86b66-49eb-4774-82be-b008350dc98b"), 0, new DateTime(1997, 7, 17, 5, 20, 42, 74, DateTimeKind.Local).AddTicks(6042), 517.9224582892130000m, "31c986a3-1439-4b87-af53-9c48f8366de8", "Albert", "Albert", null, "Hoppe", false, null, "Albert5", "AQAAAAEAACcQAAAAEDQgCGNHgBJ3lebvBsLmB0uyAXQqt2bhD5ZF8LO+IW58BNIWE66+lWnla6420ahqYQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f825bff2-881f-450b-a4b7-56931951c54c"), 0, null, 245.2126266817870000m, "7a8ccfae-00c5-4d63-b894-1831a9ff9030", "Elaine", "Elaine", null, "Graham", false, null, "Elaine_Graham37", "AQAAAAEAACcQAAAAEJD/VmGUF7oyhymX7xXalfWhuqAeLWZ66Esr8feBoMRONgutEsjjfTYsGY6uakgL7Q==", null, "Female", false },
                    { new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420"), 0, null, 952.8556869439660000m, "1c1dfac6-4f11-4ccc-a625-c1a96f28d571", "Gwendolyn", "Gwendolyn", null, "Marquardt", false, null, "Gwendolyn.Marquardt18", "AQAAAAEAACcQAAAAEBb97Rr3cuy5TL9w4+D91GzAXyq/pSlfOLdJwtmsNHc/ngZ+hW5392y6mUYEqpU4KA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c"), 0, true, new DateTime(1990, 7, 7, 19, 35, 47, 262, DateTimeKind.Local).AddTicks(9234), 464.9031848995940000m, "51689b2b-06ee-4c56-9f7e-c94deb722ab7", null, "Josefina", null, "Cole", false, null, "Josefina_Cole", "AQAAAAEAACcQAAAAEPpBrv3JNFkik068ft4UbKvd/wCeaefSEzk2ekLhnx+ovqFZMZk2eMD8grss3XuckA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f97b4375-8386-46ac-afd2-0892fcde0593"), 0, true, new DateTime(1929, 4, 8, 21, 58, 3, 518, DateTimeKind.Local).AddTicks(8411), 639.6160829887340000m, "be946771-83fb-40bb-aa29-a0f9360162cc", null, "Miriam", null, "Kilback", false, null, "Miriam31", "AQAAAAEAACcQAAAAEBEt31YeYebnucvW+9ZJbJlD+GeShbCP85RcODOhjiYnTp2jEgG1WnE7z5Fbm51uvQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9"), 0, new DateTime(1942, 5, 9, 5, 15, 15, 644, DateTimeKind.Local).AddTicks(7469), 34.37368028185580000m, "18465a49-e39a-4ea2-a781-5e79446cbf0e", null, "Lois", null, "Hansen", false, null, "Lois.Hansen", "AQAAAAEAACcQAAAAEJ+N9e8mFvB/NZvdpAmpiaYVKSDi2oomG6KBXdgXLxOvZFMxnhzDNySkSbPIQwc0OQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73"), 0, new DateTime(2007, 11, 6, 4, 41, 16, 266, DateTimeKind.Local).AddTicks(2271), 325.1437988880000m, "bc1307c0-5b8e-4fbc-8cbd-0c034838121e", null, "Pat", null, "Bauch", false, null, "Pat48", "AQAAAAEAACcQAAAAEPJZ8lHIWDJg88D/jdSDHCbxgEAGhL8g0/02ZJgb9MPr9S0Q7ZgnXfyv9fTfL7Oynw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65"), 0, new DateTime(1929, 11, 14, 8, 42, 3, 596, DateTimeKind.Local).AddTicks(5500), 179.3804001419880000m, "f003a0cb-d184-431a-a738-fe18ab7964ab", null, "Darren", null, "Yundt", false, null, "Darren0", "AQAAAAEAACcQAAAAEOTgrylyQYt25bG//m024Bz6hD+EswmzqZGZHRcsNYi2IZG5iYE/z/0jOMLjEju/Bw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af"), 0, true, new DateTime(1992, 10, 27, 12, 18, 10, 16, DateTimeKind.Local).AddTicks(1245), 932.4939479823820000m, "e2089533-1d4e-440e-ad0d-47531f78a35e", null, "Percy", null, "Kuphal", false, null, "Percy.Kuphal", "AQAAAAEAACcQAAAAEAiqvoUCCN66bP/Aw68e4SLGGRd06WEqUbRkTR9biwQTB/fJBB2n0+5Nt64eUxMqvA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "Id", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("0100af85-e573-48b6-a3cd-cd0880c09967"), "49,45546;23,6394", "Preciousfurt, Palau", new Guid("0100af85-e573-48b6-a3cd-cd0880c09967"), "Fanny Grove, 8384", 118 },
                    { new Guid("0417633a-ba4f-462c-8b0d-ac9c1819e3db"), "50,01858;25,730394", "Larkinmouth, Bangladesh", new Guid("0417633a-ba4f-462c-8b0d-ac9c1819e3db"), "Baumbach Street, 87476", 30 },
                    { new Guid("073b1ba1-e817-4383-a588-b71db60684bb"), "50,409565;30,988703", "Rosalindmouth, American Samoa", new Guid("073b1ba1-e817-4383-a588-b71db60684bb"), "Doyle Courts, 2971", 46 },
                    { new Guid("0bff1262-45c8-4e68-9dc6-91a6ed662e81"), "50,922234;30,438234", "Tremblayfort, Qatar", new Guid("0bff1262-45c8-4e68-9dc6-91a6ed662e81"), "Kling Fields, 217", 9 },
                    { new Guid("11042722-8461-4782-b48e-bf2a1d8d8291"), "49,53109;24,71134", "West Reina, Bahrain", new Guid("11042722-8461-4782-b48e-bf2a1d8d8291"), "Danny Knolls, 99510", 54 },
                    { new Guid("112ad45c-5a21-4e06-a51d-51a442d13c3c"), "48,05918;30,477566", "South Roger, Norway", new Guid("112ad45c-5a21-4e06-a51d-51a442d13c3c"), "Raina Underpass, 239", 154 },
                    { new Guid("125069ae-f6c1-436f-b325-268438f7e2a2"), "48,98137;28,5399", "Huelshaven, Japan", new Guid("125069ae-f6c1-436f-b325-268438f7e2a2"), "West Burg, 169", 125 },
                    { new Guid("14e99945-9082-492c-9e3e-e1bd4b1bcb1e"), "49,056488;24,312433", "North Elfrieda, Fiji", new Guid("14e99945-9082-492c-9e3e-e1bd4b1bcb1e"), "Marcellus Union, 2151", 182 },
                    { new Guid("15805b19-0e5b-4dde-a0d6-632d66b61b57"), "48,087482;28,196693", "Torphyfort, Ghana", new Guid("15805b19-0e5b-4dde-a0d6-632d66b61b57"), "Milo Pine, 3864", 158 },
                    { new Guid("16ad1902-6ee5-404b-9286-07c84cdf5ef7"), "48,256516;30,398067", "Lake Arlo, Monaco", new Guid("16ad1902-6ee5-404b-9286-07c84cdf5ef7"), "Hailee Springs, 725", 155 },
                    { new Guid("16f0ccc7-9d66-4609-a7f7-ceb6e929dd55"), "50,140392;26,825533", "East Mohammadtown, Macao", new Guid("16f0ccc7-9d66-4609-a7f7-ceb6e929dd55"), "Kilback Walk, 261", 130 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "Id", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("1c05f725-a58c-411b-bb3a-c09e7606e239"), "49,16084;27,017847", "Streichmouth, Austria", new Guid("1c05f725-a58c-411b-bb3a-c09e7606e239"), "Skiles Plain, 60308", 98 },
                    { new Guid("1d0d26df-3ba3-44c9-941f-b6dec5b93ad6"), "49,854996;24,312506", "New Baron, Switzerland", new Guid("1d0d26df-3ba3-44c9-941f-b6dec5b93ad6"), "Ayana Flats, 564", 72 },
                    { new Guid("20b9c065-6c5d-4d71-bf70-d1f095137e15"), "49,99294;23,993364", "North Emilio, Congo", new Guid("20b9c065-6c5d-4d71-bf70-d1f095137e15"), "Jaunita Grove, 946", 33 },
                    { new Guid("24efbaf7-ee47-4a8e-bd2d-e53ccd245bd8"), "49,32849;23,235905", "North Alfredshire, Lithuania", new Guid("24efbaf7-ee47-4a8e-bd2d-e53ccd245bd8"), "Dan Trafficway, 5802", 60 },
                    { new Guid("26426d7c-cc2e-4451-aa66-a7e07b7d1a3f"), "50,34432;28,097363", "Port Devenhaven, Venezuela", new Guid("26426d7c-cc2e-4451-aa66-a7e07b7d1a3f"), "Ricky Vista, 45267", 11 },
                    { new Guid("26a45442-e3d3-4d34-be1d-4f1d52e1db98"), "49,854374;25,920858", "New Hortensefort, Jamaica", new Guid("26a45442-e3d3-4d34-be1d-4f1d52e1db98"), "Daniel Skyway, 049", 30 },
                    { new Guid("27174592-817e-4bb2-b25f-37df932fbf54"), "50,248737;27,93143", "Lake Elbert, Dominican Republic", new Guid("27174592-817e-4bb2-b25f-37df932fbf54"), "Cydney Ports, 672", 29 },
                    { new Guid("286d93be-e4cd-4842-acce-8fe736557448"), "50,676014;23,746511", "Jeromyshire, Heard Island and McDonald Islands", new Guid("286d93be-e4cd-4842-acce-8fe736557448"), "Marcus Islands, 47303", 23 },
                    { new Guid("291a057a-989e-4ac8-84a5-a6cf5f165e6a"), "48,86959;29,454477", "Barthaven, Bahamas", new Guid("291a057a-989e-4ac8-84a5-a6cf5f165e6a"), "Margarete Via, 258", 60 },
                    { new Guid("29925720-4fcb-4e41-bb78-342032b93c01"), "49,54575;23,26746", "West Julian, Djibouti", new Guid("29925720-4fcb-4e41-bb78-342032b93c01"), "Roberta Trail, 31829", 103 },
                    { new Guid("2e5ad47c-d612-402e-a082-8f3d6fbb1244"), "49,335464;26,53258", "Ratkemouth, Bermuda", new Guid("2e5ad47c-d612-402e-a082-8f3d6fbb1244"), "Gerard Trail, 360", 39 },
                    { new Guid("30966547-2098-45e7-be62-a0c95dce8c9a"), "48,163433;29,983946", "Lake Zena, Pakistan", new Guid("30966547-2098-45e7-be62-a0c95dce8c9a"), "Bode Hollow, 4834", 24 },
                    { new Guid("31013379-f80d-4138-8c18-33c376bdbf38"), "48,48996;29,064718", "Summerville, Timor-Leste", new Guid("31013379-f80d-4138-8c18-33c376bdbf38"), "Bonnie Mission, 367", 168 },
                    { new Guid("35a1001e-73d9-4918-bd93-33556d79b1b0"), "49,30299;23,774027", "Lake Summer, Brunei Darussalam", new Guid("35a1001e-73d9-4918-bd93-33556d79b1b0"), "Kemmer Walk, 89598", 44 },
                    { new Guid("3bee9028-6c1a-4190-a251-d5ab0e86c05f"), "49,57925;23,098137", "West Noraville, South Africa", new Guid("3bee9028-6c1a-4190-a251-d5ab0e86c05f"), "Renner Greens, 619", 136 },
                    { new Guid("3c39a847-a7a3-4d79-82ce-1c4685d37102"), "49,967316;28,222246", "North Lambert, Indonesia", new Guid("3c39a847-a7a3-4d79-82ce-1c4685d37102"), "Foster Vista, 4654", 69 },
                    { new Guid("485464ac-a66c-4fc8-ba61-15800742c0b7"), "50,965107;30,105944", "Danaborough, Australia", new Guid("485464ac-a66c-4fc8-ba61-15800742c0b7"), "Frederic Mountains, 152", 19 },
                    { new Guid("50e36ce2-0b2b-43de-a20e-67e861e4774f"), "50,110996;23,027205", "South Katlyn, San Marino", new Guid("50e36ce2-0b2b-43de-a20e-67e861e4774f"), "Marquardt Glen, 744", 168 },
                    { new Guid("5188c21f-6a31-44d9-944f-6e29ee36c277"), "49,839962;25,735579", "Krishaven, Canada", new Guid("5188c21f-6a31-44d9-944f-6e29ee36c277"), "Lemke Causeway, 442", 90 },
                    { new Guid("53624a86-7c9c-44bb-b045-3d7317aa58be"), "48,09699;29,901976", "Port Elroyview, Bulgaria", new Guid("53624a86-7c9c-44bb-b045-3d7317aa58be"), "Alec Terrace, 175", 7 },
                    { new Guid("53b993fe-459d-4066-a8f4-7c8c62e6d9d7"), "50,309566;28,201109", "Port Ezequiel, Saudi Arabia", new Guid("53b993fe-459d-4066-a8f4-7c8c62e6d9d7"), "Yundt Corners, 1952", 80 },
                    { new Guid("5401b73d-e450-4c14-9929-89b12e43dbda"), "48,03436;25,773933", "West Camillafort, Ghana", new Guid("5401b73d-e450-4c14-9929-89b12e43dbda"), "Kitty Well, 5218", 46 },
                    { new Guid("57091b81-3d66-41ab-9884-1c7003236a6f"), "48,00486;23,178783", "South Annetta, India", new Guid("57091b81-3d66-41ab-9884-1c7003236a6f"), "Zachariah Shores, 131", 46 },
                    { new Guid("57eed468-aab2-4ec2-a54e-1cfc48020921"), "48,298492;29,177135", "Ledafurt, Holy See (Vatican City State)", new Guid("57eed468-aab2-4ec2-a54e-1cfc48020921"), "Arnaldo Street, 7446", 171 },
                    { new Guid("58a9c66e-710e-4bbc-954f-504fd0ce05bf"), "50,628323;30,165897", "Goldenhaven, Svalbard & Jan Mayen Islands", new Guid("58a9c66e-710e-4bbc-954f-504fd0ce05bf"), "Mraz Street, 3626", 4 },
                    { new Guid("5a1c88bf-9860-49b1-81c8-20b1930cc731"), "50,210327;25,080101", "North Macey, Northern Mariana Islands", new Guid("5a1c88bf-9860-49b1-81c8-20b1930cc731"), "Lind Glens, 76081", 96 },
                    { new Guid("5c1ef301-d4e2-4f32-a521-9826e1d633bd"), "50,839996;25,03426", "New Susieland, Cuba", new Guid("5c1ef301-d4e2-4f32-a521-9826e1d633bd"), "Koss Fords, 542", 12 },
                    { new Guid("5f963f05-6d09-43a2-890d-d7820d5dd2cc"), "48,72889;30,103828", "East Alizafort, Estonia", new Guid("5f963f05-6d09-43a2-890d-d7820d5dd2cc"), "Sadye Shores, 41557", 158 },
                    { new Guid("60f94c33-b9a7-49a6-a5a0-052b3a9e7d8c"), "48,982765;28,838768", "North Valentin, Kyrgyz Republic", new Guid("60f94c33-b9a7-49a6-a5a0-052b3a9e7d8c"), "Reyna Crossing, 5223", 182 },
                    { new Guid("636f1fda-966a-43b5-8851-337687d8898d"), "50,356464;29,597672", "Langworthfurt, Central African Republic", new Guid("636f1fda-966a-43b5-8851-337687d8898d"), "Raynor Harbor, 609", 157 },
                    { new Guid("66aa996d-fe35-4a8c-806a-517eccb06d5c"), "48,937992;26,917448", "New Giovanny, Lebanon", new Guid("66aa996d-fe35-4a8c-806a-517eccb06d5c"), "Konopelski Turnpike, 57640", 197 },
                    { new Guid("674ed7fb-dcbc-4e30-8e72-5080db7d4170"), "50,39345;23,980726", "Lake Christophe, Solomon Islands", new Guid("674ed7fb-dcbc-4e30-8e72-5080db7d4170"), "Schneider Club, 43356", 175 },
                    { new Guid("6ccaf7dc-b779-4491-b0ef-abf56c438ef3"), "48,431103;24,76038", "South Kassandra, Togo", new Guid("6ccaf7dc-b779-4491-b0ef-abf56c438ef3"), "Hirthe Radial, 25105", 151 },
                    { new Guid("71556740-633a-4553-8a66-e43d4f91e0c2"), "49,64968;26,065708", "East Gregg, Micronesia", new Guid("71556740-633a-4553-8a66-e43d4f91e0c2"), "Daphne Motorway, 494", 158 },
                    { new Guid("7e5de31c-3f99-454d-8219-698c13afbe61"), "50,011414;27,208227", "Lylaview, Virgin Islands, U.S.", new Guid("7e5de31c-3f99-454d-8219-698c13afbe61"), "Colten Terrace, 3667", 138 },
                    { new Guid("7f5ae0e7-d31a-48f7-b05d-257b7a9405e8"), "50,811832;24,962486", "Stromanview, Saint Helena", new Guid("7f5ae0e7-d31a-48f7-b05d-257b7a9405e8"), "Koelpin Ways, 046", 129 },
                    { new Guid("8427a1cd-09c0-4dbc-844e-707844dfa96a"), "50,50573;30,170725", "Port Monte, Burundi", new Guid("8427a1cd-09c0-4dbc-844e-707844dfa96a"), "Grimes Greens, 15487", 33 },
                    { new Guid("8529f557-82fb-403a-aba4-62dd375c565f"), "49,655384;25,450005", "Lake Sigurd, Morocco", new Guid("8529f557-82fb-403a-aba4-62dd375c565f"), "Viola Groves, 6622", 106 },
                    { new Guid("86980175-bb8b-41a5-a44e-e94b08476835"), "50,95868;24,055092", "Weststad, Bulgaria", new Guid("86980175-bb8b-41a5-a44e-e94b08476835"), "Johns Land, 3236", 7 },
                    { new Guid("87f0b331-b39a-454d-916a-fee0e4d80778"), "50,61176;30,49479", "Bethtown, Zambia", new Guid("87f0b331-b39a-454d-916a-fee0e4d80778"), "Emilie Centers, 96338", 91 },
                    { new Guid("8943dd86-3120-4f39-9fb0-9f6e48977ff4"), "50,0697;24,218395", "South Noahport, Moldova", new Guid("8943dd86-3120-4f39-9fb0-9f6e48977ff4"), "Schroeder Shoal, 5690", 40 },
                    { new Guid("8ca52e76-20f3-4ea9-8fbd-6575c70955b3"), "48,194244;24,39659", "McLaughlinport, Serbia", new Guid("8ca52e76-20f3-4ea9-8fbd-6575c70955b3"), "Kayla Ville, 181", 114 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "Id", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("8cf5c738-12cf-47f7-9b52-301f679687a8"), "49,70553;29,427132", "North Tyriqueborough, Reunion", new Guid("8cf5c738-12cf-47f7-9b52-301f679687a8"), "Edythe Mountain, 652", 35 },
                    { new Guid("8f2ca9d9-2c1d-4891-b8cd-d2d888fd7e9b"), "49,054104;30,955824", "Feestmouth, Greenland", new Guid("8f2ca9d9-2c1d-4891-b8cd-d2d888fd7e9b"), "O'Keefe Spring, 344", 162 },
                    { new Guid("8fb75d0a-1acb-4f39-b1a4-dd1a02b5c027"), "49,81107;23,734365", "Patberg, Mauritius", new Guid("8fb75d0a-1acb-4f39-b1a4-dd1a02b5c027"), "Hudson Loaf, 66552", 69 },
                    { new Guid("9251f2b4-8385-4667-8d59-e000c38005dc"), "49,67068;23,661728", "Wittinghaven, Norfolk Island", new Guid("9251f2b4-8385-4667-8d59-e000c38005dc"), "Jaquelin Hill, 62147", 46 },
                    { new Guid("93aaba6f-d570-4d11-a369-985420214058"), "49,773262;24,49671", "Zanderland, Guernsey", new Guid("93aaba6f-d570-4d11-a369-985420214058"), "Abshire Radial, 01915", 149 },
                    { new Guid("95d8f9b2-5f8e-4700-8cfe-2b70a87a340e"), "48,293232;24,8083", "Angelitaton, Slovakia (Slovak Republic)", new Guid("95d8f9b2-5f8e-4700-8cfe-2b70a87a340e"), "Joan Alley, 3980", 84 },
                    { new Guid("9ee4a727-06d9-49b1-bbf6-d6f7d3312132"), "49,95794;25,870897", "West Jedediahburgh, Uganda", new Guid("9ee4a727-06d9-49b1-bbf6-d6f7d3312132"), "Hilll Trace, 8353", 150 },
                    { new Guid("a6945887-c333-4894-b978-d823d051342a"), "48,201122;30,475803", "Lake Lorena, Burkina Faso", new Guid("a6945887-c333-4894-b978-d823d051342a"), "Miller Lodge, 668", 89 },
                    { new Guid("a7634c5b-7948-43bc-976d-bcd5b1e0c93f"), "48,277225;24,679111", "Swiftstad, Democratic People's Republic of Korea", new Guid("a7634c5b-7948-43bc-976d-bcd5b1e0c93f"), "Mackenzie Forest, 6423", 146 },
                    { new Guid("b1d8def6-d554-4787-904e-76ddf1409cb5"), "50,12501;23,877182", "Imamouth, Benin", new Guid("b1d8def6-d554-4787-904e-76ddf1409cb5"), "Bernice Bypass, 10479", 40 },
                    { new Guid("b2c3b18c-6bd7-4e8a-85e5-ce52bff56eb6"), "49,50305;29,717215", "Port Summer, Congo", new Guid("b2c3b18c-6bd7-4e8a-85e5-ce52bff56eb6"), "Bridgette Prairie, 2479", 8 },
                    { new Guid("b539d413-2d49-46c3-87ba-027ee06857ac"), "49,85568;27,790192", "North Garfieldhaven, Marshall Islands", new Guid("b539d413-2d49-46c3-87ba-027ee06857ac"), "Wolff Glens, 452", 161 },
                    { new Guid("ca07c29a-fe28-4532-8849-f85b3e7c8482"), "50,335354;26,748535", "Hartmannhaven, Serbia", new Guid("ca07c29a-fe28-4532-8849-f85b3e7c8482"), "Zemlak Fort, 332", 20 },
                    { new Guid("cac083f3-6804-45b0-8531-1e988f76abf1"), "50,895924;25,734379", "Jimmyfort, Papua New Guinea", new Guid("cac083f3-6804-45b0-8531-1e988f76abf1"), "Kitty Wall, 1530", 119 },
                    { new Guid("cc0b1a42-4ffe-400b-a306-789635e17bf5"), "49,444996;26,448229", "North Dan, Iran", new Guid("cc0b1a42-4ffe-400b-a306-789635e17bf5"), "Daugherty Squares, 60851", 39 },
                    { new Guid("cc34fd1f-b9c5-4cbf-9599-433ad3498518"), "48,36777;27,45343", "South Dockburgh, Chile", new Guid("cc34fd1f-b9c5-4cbf-9599-433ad3498518"), "Haley Trail, 05856", 137 },
                    { new Guid("cc3e358b-6b9b-40b1-a0de-3200d9a6633a"), "48,62101;23,789934", "Port Ayden, Estonia", new Guid("cc3e358b-6b9b-40b1-a0de-3200d9a6633a"), "Muhammad Plain, 0017", 2 },
                    { new Guid("cd7c8a48-f7c4-4956-aa40-9e905ced600f"), "48,247444;23,818277", "North Carletonshire, Saint Martin", new Guid("cd7c8a48-f7c4-4956-aa40-9e905ced600f"), "Grant Locks, 999", 137 },
                    { new Guid("cef8dc84-ba71-47dc-96f5-5490866ebffb"), "48,089855;30,978924", "Wisokytown, Norway", new Guid("cef8dc84-ba71-47dc-96f5-5490866ebffb"), "Bogisich Crescent, 318", 88 },
                    { new Guid("cf349a97-121b-4dec-8644-4c60a46d6153"), "50,918587;23,01593", "Wunschchester, Martinique", new Guid("cf349a97-121b-4dec-8644-4c60a46d6153"), "Perry Harbor, 89171", 167 },
                    { new Guid("d16f9da7-4dc7-4fb0-8336-75c01db25e28"), "48,43836;28,60905", "North Bernhardview, Cameroon", new Guid("d16f9da7-4dc7-4fb0-8336-75c01db25e28"), "Amos Via, 720", 7 },
                    { new Guid("d4277ca5-d047-4e60-95eb-6977fe7a5b1d"), "48,033607;30,86437", "West Salvatore, Micronesia", new Guid("d4277ca5-d047-4e60-95eb-6977fe7a5b1d"), "Wehner Falls, 19205", 52 },
                    { new Guid("d456edba-30cd-4c64-9576-6ce490429a41"), "49,37416;26,151512", "Lake Calebville, Gabon", new Guid("d456edba-30cd-4c64-9576-6ce490429a41"), "Aliza Rue, 9614", 166 },
                    { new Guid("d4bff934-4eec-4a46-be88-40342736220b"), "49,710556;26,335056", "Kamronmouth, Vanuatu", new Guid("d4bff934-4eec-4a46-be88-40342736220b"), "Quigley Crossroad, 1350", 103 },
                    { new Guid("d5c6bf1b-e4f2-4871-95b1-e971232ed9e1"), "48,63478;27,141737", "Hartmannhaven, Brunei Darussalam", new Guid("d5c6bf1b-e4f2-4871-95b1-e971232ed9e1"), "Bartell Street, 1006", 159 },
                    { new Guid("d647d6ed-06e5-4685-8910-5ac85fea248c"), "50,048016;24,007814", "North Hellen, Virgin Islands, U.S.", new Guid("d647d6ed-06e5-4685-8910-5ac85fea248c"), "Lindgren Inlet, 10941", 184 },
                    { new Guid("d7eb84e2-e261-4c8e-b740-573a143986e2"), "49,502865;28,079138", "Port Brannon, Kuwait", new Guid("d7eb84e2-e261-4c8e-b740-573a143986e2"), "Sincere Crest, 10028", 191 },
                    { new Guid("d96fef60-4ed6-4840-bdc9-2376db90a54a"), "49,164623;23,265131", "East Madalinehaven, United States of America", new Guid("d96fef60-4ed6-4840-bdc9-2376db90a54a"), "Carroll Skyway, 767", 5 },
                    { new Guid("da348a81-4551-484e-ac7f-0b503b7041ea"), "50,218422;29,482718", "Ebonyshire, Angola", new Guid("da348a81-4551-484e-ac7f-0b503b7041ea"), "Kertzmann Mill, 3469", 51 },
                    { new Guid("da44c7ca-2da2-4025-a868-f2419b63b2da"), "50,485706;24,575926", "Fayfurt, Ghana", new Guid("da44c7ca-2da2-4025-a868-f2419b63b2da"), "Kade Turnpike, 18316", 95 },
                    { new Guid("dad653a6-78cf-471e-826e-659f67530cb9"), "49,595615;29,497244", "Franeckishire, Azerbaijan", new Guid("dad653a6-78cf-471e-826e-659f67530cb9"), "Destin Mill, 015", 179 },
                    { new Guid("db4825d3-fdb8-437d-85fa-fda4f61a4d46"), "49,45498;24,890615", "Pricemouth, Turks and Caicos Islands", new Guid("db4825d3-fdb8-437d-85fa-fda4f61a4d46"), "Luis Shore, 7494", 183 },
                    { new Guid("dc7a2df1-2389-4346-94c3-e32035fbbab3"), "50,152023;26,220966", "West Hermanfort, French Southern Territories", new Guid("dc7a2df1-2389-4346-94c3-e32035fbbab3"), "Feeney Squares, 795", 75 },
                    { new Guid("dc9ffb30-8b4a-4093-a17a-fdb6700b93e7"), "50,537697;23,783335", "New Vinnieshire, Russian Federation", new Guid("dc9ffb30-8b4a-4093-a17a-fdb6700b93e7"), "Elvis Junction, 54953", 29 },
                    { new Guid("dcd32b1a-c20d-4c9e-8aac-da17ace6fd08"), "48,536297;25,427608", "East Grant, Luxembourg", new Guid("dcd32b1a-c20d-4c9e-8aac-da17ace6fd08"), "Cathy Fields, 3828", 52 },
                    { new Guid("dda45edf-97c4-4758-947c-b13e9cbc1c98"), "48,05146;28,84067", "Heloiseshire, Ethiopia", new Guid("dda45edf-97c4-4758-947c-b13e9cbc1c98"), "Ryan Skyway, 00653", 81 },
                    { new Guid("df43a17e-2176-45b2-9ae4-d12c95650a02"), "48,594135;28,994808", "Erichfurt, Portugal", new Guid("df43a17e-2176-45b2-9ae4-d12c95650a02"), "Bradley Loop, 959", 112 },
                    { new Guid("e1e8a516-1e19-4523-9b99-2c34099edc85"), "50,280304;24,10107", "Lefflerchester, Turkey", new Guid("e1e8a516-1e19-4523-9b99-2c34099edc85"), "Emmerich Hill, 2190", 63 },
                    { new Guid("e226330f-8114-40bd-ae9c-bb20afa5eab0"), "48,07736;28,564344", "Dickiborough, Aruba", new Guid("e226330f-8114-40bd-ae9c-bb20afa5eab0"), "Parisian Creek, 2723", 86 },
                    { new Guid("e6bc351b-8b5f-413a-b3b5-b19984ea3ef8"), "50,023716;23,374517", "Lake Justiceport, Russian Federation", new Guid("e6bc351b-8b5f-413a-b3b5-b19984ea3ef8"), "Brenna River, 76857", 127 },
                    { new Guid("e7520a57-b37e-4532-9167-acdd8e293d01"), "48,71079;25,572186", "West Erikburgh, Faroe Islands", new Guid("e7520a57-b37e-4532-9167-acdd8e293d01"), "Zieme Manor, 5112", 188 },
                    { new Guid("e7a5e721-8c3a-4a78-9724-886c44db51c1"), "48,853382;30,3721", "New Ozella, Oman", new Guid("e7a5e721-8c3a-4a78-9724-886c44db51c1"), "Damien Islands, 3764", 133 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "Id", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("e9c00671-ee60-4c57-92d2-4607c6cd8f90"), "50,527134;30,2615", "Port Aniyaborough, Heard Island and McDonald Islands", new Guid("e9c00671-ee60-4c57-92d2-4607c6cd8f90"), "Mark Well, 7737", 153 },
                    { new Guid("ea903924-c9ca-4241-9933-a005b0b3b68a"), "49,22159;26,518383", "Kiehnchester, Argentina", new Guid("ea903924-c9ca-4241-9933-a005b0b3b68a"), "Jena Alley, 356", 174 },
                    { new Guid("eb9a87cc-9cf4-451f-83e3-6754fc1aa245"), "49,297543;27,571762", "Port Veronicahaven, India", new Guid("eb9a87cc-9cf4-451f-83e3-6754fc1aa245"), "Clara Ports, 310", 71 },
                    { new Guid("ec9fb8f7-52df-416a-a30f-c9cec8dbf2e7"), "50,243214;27,84551", "Chaseburgh, Nicaragua", new Guid("ec9fb8f7-52df-416a-a30f-c9cec8dbf2e7"), "Emiliano Crossroad, 3118", 10 },
                    { new Guid("f32fe17e-8d75-4509-b47d-5bb2a0bd6b26"), "48,259933;27,09972", "Ellisborough, Burkina Faso", new Guid("f32fe17e-8d75-4509-b47d-5bb2a0bd6b26"), "Nikolaus Corners, 29201", 21 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "Id", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("021aeba9-bef0-45ab-a0f8-662d0f3f87c6"), 187, "48,567886;30,747591", "North Beryl, Kazakhstan", new Guid("021aeba9-bef0-45ab-a0f8-662d0f3f87c6"), "Walter Islands, 31608" },
                    { new Guid("032df6f4-6a89-49ec-a1ec-2aad72ece6ff"), 149, "48,277153;28,130684", "New Cynthia, Turkmenistan", new Guid("032df6f4-6a89-49ec-a1ec-2aad72ece6ff"), "Carlie Oval, 799" },
                    { new Guid("03711eb4-6851-4b34-9009-be3af15375ff"), 45, "49,878784;30,459597", "West Gloriaton, Cambodia", new Guid("03711eb4-6851-4b34-9009-be3af15375ff"), "Wilber Mountains, 840" },
                    { new Guid("0a41e9bd-943f-44e3-9b5d-e17b5accad0c"), 39, "49,391712;24,298626", "West Carmeloville, Madagascar", new Guid("0a41e9bd-943f-44e3-9b5d-e17b5accad0c"), "Lew Loaf, 358" },
                    { new Guid("0dee8ed3-ab59-4534-a5c7-d416460590c9"), 172, "48,568626;27,78937", "South Karianneview, Pitcairn Islands", new Guid("0dee8ed3-ab59-4534-a5c7-d416460590c9"), "Medhurst Estate, 080" },
                    { new Guid("0dfb737a-b725-4c49-8b3b-e2577ea56651"), 186, "50,96785;23,881805", "Lake Tremouth, Zimbabwe", new Guid("0dfb737a-b725-4c49-8b3b-e2577ea56651"), "Halvorson Lodge, 71713" },
                    { new Guid("0fb06aae-57dc-4096-a1d5-13b2594af4cd"), 25, "49,422115;28,755274", "East Bellehaven, Gabon", new Guid("0fb06aae-57dc-4096-a1d5-13b2594af4cd"), "Kozey Harbors, 83650" },
                    { new Guid("123b9c97-a99f-46d4-8b99-5b09c07f9122"), 22, "50,203587;27,287886", "Lake Kellibury, Cameroon", new Guid("123b9c97-a99f-46d4-8b99-5b09c07f9122"), "Torp Extensions, 976" },
                    { new Guid("1413d2bb-da6f-4fd2-b02b-5810c3aeae86"), 46, "48,695347;24,928537", "Gradytown, India", new Guid("1413d2bb-da6f-4fd2-b02b-5810c3aeae86"), "Granville Islands, 131" },
                    { new Guid("1e7a90ae-1705-4577-b587-4d4bbbdbb1e2"), 83, "48,730015;26,613728", "Buckridgeport, Sudan", new Guid("1e7a90ae-1705-4577-b587-4d4bbbdbb1e2"), "Dorris Pine, 8348" },
                    { new Guid("20a68293-47a7-4b44-8c5a-04e49ea8a1fb"), 118, "48,09274;28,913054", "Port Cyril, Sudan", new Guid("20a68293-47a7-4b44-8c5a-04e49ea8a1fb"), "O'Conner Groves, 382" },
                    { new Guid("20dacf53-165d-4ed9-a05c-b1fbfaf085ca"), 33, "49,42185;30,220774", "East Mallieland, Belgium", new Guid("20dacf53-165d-4ed9-a05c-b1fbfaf085ca"), "McDermott Forks, 911" },
                    { new Guid("21f524a8-5ecf-4dbe-9255-ede5e775bcb9"), 199, "50,66833;30,875654", "Urbanview, Sao Tome and Principe", new Guid("21f524a8-5ecf-4dbe-9255-ede5e775bcb9"), "Hector Stravenue, 155" },
                    { new Guid("25797f9e-3ad0-4a37-bf61-26d4385d3a32"), 95, "48,39363;27,832718", "Port Reba, Egypt", new Guid("25797f9e-3ad0-4a37-bf61-26d4385d3a32"), "Wuckert Plain, 750" },
                    { new Guid("28ecd174-bedb-4698-9cc5-386a372de77a"), 161, "48,236496;26,171", "Lueside, Estonia", new Guid("28ecd174-bedb-4698-9cc5-386a372de77a"), "O'Keefe Ferry, 09594" },
                    { new Guid("2d1fe088-a286-4a9a-90f4-0d3ca876694d"), 124, "48,46347;29,584112", "O'Keefeton, Tuvalu", new Guid("2d1fe088-a286-4a9a-90f4-0d3ca876694d"), "Adam Place, 9858" },
                    { new Guid("2e104f00-ef67-42e9-840b-3af7062b2018"), 81, "50,468086;26,100748", "Gottliebville, Lithuania", new Guid("2e104f00-ef67-42e9-840b-3af7062b2018"), "Jordi Burgs, 95546" },
                    { new Guid("2f8735df-af95-4d1e-8aef-86c18510a0af"), 79, "49,276752;30,891073", "South Louisaton, Andorra", new Guid("2f8735df-af95-4d1e-8aef-86c18510a0af"), "Hettinger Ferry, 771" },
                    { new Guid("30869352-a17a-4c77-b5ba-e29e79883248"), 161, "50,9249;28,408281", "Blockberg, Democratic People's Republic of Korea", new Guid("30869352-a17a-4c77-b5ba-e29e79883248"), "Bobby Hollow, 77625" },
                    { new Guid("314ff9e7-5641-4f22-8870-59b1a7da4078"), 37, "48,008587;28,967867", "West Johnnie, Russian Federation", new Guid("314ff9e7-5641-4f22-8870-59b1a7da4078"), "Kozey Courts, 52992" },
                    { new Guid("32ceeb3f-923c-46f5-a8f6-8e514cb0a7e7"), 25, "49,883446;25,302395", "Hermanfort, Belize", new Guid("32ceeb3f-923c-46f5-a8f6-8e514cb0a7e7"), "Considine Lakes, 416" },
                    { new Guid("32ff792c-e85b-4ce5-b394-85edada858ad"), 14, "49,88058;24,449213", "Lake Summer, Bhutan", new Guid("32ff792c-e85b-4ce5-b394-85edada858ad"), "Klein Circle, 44898" },
                    { new Guid("33e86693-e58b-4b62-b806-9bfcff930a14"), 121, "50,26248;27,97572", "South Jamirtown, Papua New Guinea", new Guid("33e86693-e58b-4b62-b806-9bfcff930a14"), "Gutkowski Alley, 09530" },
                    { new Guid("3d79df02-6615-45e7-9089-e1494b719783"), 156, "49,997223;29,098719", "West Amya, Mali", new Guid("3d79df02-6615-45e7-9089-e1494b719783"), "Hermiston Crossroad, 5495" },
                    { new Guid("3e3fe06b-d0dd-4dfa-af37-34afa51c944f"), 126, "50,82794;28,57629", "Port Trevionberg, Andorra", new Guid("3e3fe06b-d0dd-4dfa-af37-34afa51c944f"), "O'Kon Rest, 28738" },
                    { new Guid("46ba801a-8d52-4b4a-b69e-9c7f95dec576"), 171, "50,125668;28,161106", "Eloymouth, Belize", new Guid("46ba801a-8d52-4b4a-b69e-9c7f95dec576"), "Erdman Wall, 2057" },
                    { new Guid("46cb30cd-68a9-4db5-9079-6ba43416e72d"), 126, "48,21271;27,780165", "Gutmannberg, Saint Vincent and the Grenadines", new Guid("46cb30cd-68a9-4db5-9079-6ba43416e72d"), "Jamal Isle, 808" },
                    { new Guid("46f1074a-8cd5-4698-9a30-a4f2becb309b"), 152, "48,706562;26,491028", "Stanside, Chad", new Guid("46f1074a-8cd5-4698-9a30-a4f2becb309b"), "Bella Tunnel, 5957" },
                    { new Guid("476782d0-d9d7-4f98-86f9-3d2fac151bd0"), 128, "50,35995;24,45127", "Mariahburgh, French Southern Territories", new Guid("476782d0-d9d7-4f98-86f9-3d2fac151bd0"), "Dolores Oval, 8480" },
                    { new Guid("49fc4f23-c1bc-4a6a-929b-17e681e8ba47"), 51, "48,885086;29,496092", "Bartolettibury, Tajikistan", new Guid("49fc4f23-c1bc-4a6a-929b-17e681e8ba47"), "Charity Rapids, 2276" },
                    { new Guid("554a9f9e-e56b-45a1-9f6c-318db610c7f6"), 168, "49,548306;29,698195", "Taureanton, Ireland", new Guid("554a9f9e-e56b-45a1-9f6c-318db610c7f6"), "Chasity Brook, 7538" },
                    { new Guid("5587ea77-5158-46c0-8b18-e5b09f04f401"), 112, "49,596027;25,786772", "West Gaetanofort, Norfolk Island", new Guid("5587ea77-5158-46c0-8b18-e5b09f04f401"), "Jacky Summit, 728" },
                    { new Guid("5fbfc221-a301-4c8c-9fce-a0d7eae3e79c"), 95, "49,3251;27,29752", "New Luigishire, Honduras", new Guid("5fbfc221-a301-4c8c-9fce-a0d7eae3e79c"), "Lind Manors, 32062" },
                    { new Guid("60b8493e-9193-457e-90ba-59197b9697f6"), 144, "50,772274;23,009365", "Lake Antonetta, Monaco", new Guid("60b8493e-9193-457e-90ba-59197b9697f6"), "Hettinger Road, 86687" },
                    { new Guid("6168c7fc-f76b-44b1-bbfc-901d98e6ad1a"), 103, "50,25378;27,852701", "Tanyaton, American Samoa", new Guid("6168c7fc-f76b-44b1-bbfc-901d98e6ad1a"), "Anderson Route, 66298" },
                    { new Guid("6258405a-1054-49b6-a807-428e343ce4f3"), 175, "48,279507;29,404186", "North Elmirachester, Vietnam", new Guid("6258405a-1054-49b6-a807-428e343ce4f3"), "DuBuque Ford, 787" },
                    { new Guid("657184d1-8bd1-407a-87e7-1afa8d7a6885"), 166, "50,391373;25,419514", "Alphonsostad, Guyana", new Guid("657184d1-8bd1-407a-87e7-1afa8d7a6885"), "Hegmann Tunnel, 02331" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "Id", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("6fef9856-9fcd-48f7-bb59-79fd2ec1cff8"), 12, "49,298756;29,663397", "Kirstinhaven, Lesotho", new Guid("6fef9856-9fcd-48f7-bb59-79fd2ec1cff8"), "Fanny Brooks, 97062" },
                    { new Guid("70c12226-9aba-415d-b3d9-5169dde05cf5"), 41, "50,55368;28,23318", "East Feltonton, Zambia", new Guid("70c12226-9aba-415d-b3d9-5169dde05cf5"), "Jeffry Brook, 291" },
                    { new Guid("70cdf392-ef04-4df5-895c-171b1e79ecdd"), 23, "50,718132;28,838865", "Luciofurt, British Indian Ocean Territory (Chagos Archipelago)", new Guid("70cdf392-ef04-4df5-895c-171b1e79ecdd"), "Beahan View, 1719" },
                    { new Guid("74aa3a05-3d87-448b-a41e-c2d8780a413f"), 36, "48,488125;30,457027", "Lake Brennonton, San Marino", new Guid("74aa3a05-3d87-448b-a41e-c2d8780a413f"), "Marcellus Cove, 0583" },
                    { new Guid("76f3969e-cbac-44d9-b2ab-c616b92e7cda"), 9, "50,491947;27,80233", "West Danton, Martinique", new Guid("76f3969e-cbac-44d9-b2ab-c616b92e7cda"), "Jarrett Brook, 2394" },
                    { new Guid("7797db6a-5f7a-4048-b06e-c0b8d0939dc1"), 167, "48,151775;23,860928", "North Teresahaven, Seychelles", new Guid("7797db6a-5f7a-4048-b06e-c0b8d0939dc1"), "Matilde Crescent, 80497" },
                    { new Guid("7893ffde-9ed1-4545-a271-e7150a31d316"), 125, "49,539177;26,569899", "Christinaview, Liechtenstein", new Guid("7893ffde-9ed1-4545-a271-e7150a31d316"), "Maude Cliff, 95775" },
                    { new Guid("7b9e5459-d58f-4196-b179-187c66109092"), 69, "48,34918;29,484026", "Laceyfurt, Seychelles", new Guid("7b9e5459-d58f-4196-b179-187c66109092"), "Ivory Plains, 47687" },
                    { new Guid("7f870da0-da4d-437d-a3ce-e81bd1e4a1ee"), 23, "49,73025;23,153965", "Lake Christiantown, Faroe Islands", new Guid("7f870da0-da4d-437d-a3ce-e81bd1e4a1ee"), "Kiley Curve, 008" },
                    { new Guid("81dbcc89-064c-470f-8cda-19d01fa8303b"), 38, "50,232555;23,417955", "North Isabel, Dominica", new Guid("81dbcc89-064c-470f-8cda-19d01fa8303b"), "Marvin Spurs, 414" },
                    { new Guid("8513ceeb-5bd1-478d-ae0b-11c35b91ba74"), 200, "49,16642;26,653017", "Edgardofort, Malaysia", new Guid("8513ceeb-5bd1-478d-ae0b-11c35b91ba74"), "Jordan Inlet, 6130" },
                    { new Guid("8528082a-7036-40eb-9515-88c09c16b3da"), 125, "48,40031;27,707977", "Skilesfort, Zambia", new Guid("8528082a-7036-40eb-9515-88c09c16b3da"), "Merritt Pine, 23473" },
                    { new Guid("883a275f-ae1d-42ea-a47b-915a95806060"), 135, "50,677197;23,836502", "Langoshland, Poland", new Guid("883a275f-ae1d-42ea-a47b-915a95806060"), "Ondricka Motorway, 855" },
                    { new Guid("8d57b1fa-eaa6-448b-906d-3918ad7b8fd5"), 99, "48,147736;24,069786", "Lizziechester, Benin", new Guid("8d57b1fa-eaa6-448b-906d-3918ad7b8fd5"), "Demond Drives, 734" },
                    { new Guid("8eaf7ff7-c19c-498f-af25-3b45d40d7187"), 152, "50,598156;28,433176", "Eddiestad, Mauritius", new Guid("8eaf7ff7-c19c-498f-af25-3b45d40d7187"), "Christiansen Vista, 681" },
                    { new Guid("924be61d-0622-4e53-a50b-33096f26c202"), 112, "50,439278;30,08206", "North Joey, Northern Mariana Islands", new Guid("924be61d-0622-4e53-a50b-33096f26c202"), "Treutel Hills, 0261" },
                    { new Guid("949bd1c4-53da-47fa-ae4c-f46401f4c496"), 150, "50,757595;29,690804", "Lake Leraberg, Paraguay", new Guid("949bd1c4-53da-47fa-ae4c-f46401f4c496"), "Feeney Pine, 36793" },
                    { new Guid("99724260-6a10-4613-8194-e471c35b6bb4"), 146, "49,43598;25,750471", "Lake Corneliushaven, Saint Martin", new Guid("99724260-6a10-4613-8194-e471c35b6bb4"), "Jaskolski Prairie, 66140" },
                    { new Guid("99e243ad-e9c9-44de-b548-a80763be1069"), 81, "50,682407;30,060194", "Shayleetown, Namibia", new Guid("99e243ad-e9c9-44de-b548-a80763be1069"), "Lilian Plains, 08823" },
                    { new Guid("9ddb52ad-137a-49da-a21c-cf6a263ac85b"), 66, "49,359756;26,305279", "West Heidi, Pitcairn Islands", new Guid("9ddb52ad-137a-49da-a21c-cf6a263ac85b"), "Marvin Union, 147" },
                    { new Guid("9ef4f1d2-cd28-4aa4-aaa5-07dfde60bde8"), 30, "48,3283;23,071114", "South Shanelborough, Tokelau", new Guid("9ef4f1d2-cd28-4aa4-aaa5-07dfde60bde8"), "Whitney Junctions, 4778" },
                    { new Guid("a08a3026-54f6-4ff2-96ab-d1c077b94b8d"), 24, "50,279064;29,261059", "East Darionland, Lithuania", new Guid("a08a3026-54f6-4ff2-96ab-d1c077b94b8d"), "Blanche Overpass, 60122" },
                    { new Guid("a32e772c-e09f-460c-a8f3-91bbca18b58f"), 160, "49,86807;26,774021", "New Carson, Guadeloupe", new Guid("a32e772c-e09f-460c-a8f3-91bbca18b58f"), "Larkin Inlet, 785" },
                    { new Guid("a3d55186-4e02-49f2-96f7-504c75bf5a36"), 153, "49,33635;25,437069", "Martachester, Congo", new Guid("a3d55186-4e02-49f2-96f7-504c75bf5a36"), "Clair Squares, 7883" },
                    { new Guid("a7159cae-5e11-4a1d-bd84-d98368147142"), 179, "48,02034;28,458864", "Port Xzavier, Micronesia", new Guid("a7159cae-5e11-4a1d-bd84-d98368147142"), "Abernathy Junction, 21075" },
                    { new Guid("a80fd179-9d7d-447e-b938-805a33691980"), 51, "50,52686;23,541796", "Jonathonbury, Swaziland", new Guid("a80fd179-9d7d-447e-b938-805a33691980"), "Carolyn Village, 788" },
                    { new Guid("af45803b-2ece-4c02-9628-948c1fc6000b"), 24, "48,250843;25,927666", "Hilllborough, Lithuania", new Guid("af45803b-2ece-4c02-9628-948c1fc6000b"), "Conn Stravenue, 9909" },
                    { new Guid("b32355f7-75eb-4468-b9b5-354c611e10a3"), 94, "48,346645;24,992945", "Sheldonview, Mauritius", new Guid("b32355f7-75eb-4468-b9b5-354c611e10a3"), "Arvilla Plains, 5902" },
                    { new Guid("bc93365d-9aa9-4821-8b33-bd5d7cbd1e36"), 141, "50,431656;29,893728", "Saraiton, Spain", new Guid("bc93365d-9aa9-4821-8b33-bd5d7cbd1e36"), "Nienow Flats, 203" },
                    { new Guid("bc9beae0-5341-4243-a319-dd6ee5573a5b"), 173, "49,35664;26,4575", "West Melvin, Mexico", new Guid("bc9beae0-5341-4243-a319-dd6ee5573a5b"), "Jeromy Trail, 99616" },
                    { new Guid("be024e00-0bc2-46c2-95a9-4af4a5629dd1"), 193, "48,307453;28,384937", "Cyrusbury, Norfolk Island", new Guid("be024e00-0bc2-46c2-95a9-4af4a5629dd1"), "Rhoda Junction, 68513" },
                    { new Guid("bf4a42d1-0cd6-4cbd-8a3d-f41998ba6296"), 71, "50,45391;26,71247", "North Hollishaven, Belize", new Guid("bf4a42d1-0cd6-4cbd-8a3d-f41998ba6296"), "Schoen Island, 69192" },
                    { new Guid("c13429bb-6be5-4a00-b4af-dbbe03e91269"), 159, "50,827843;25,311152", "Jessycaside, Liechtenstein", new Guid("c13429bb-6be5-4a00-b4af-dbbe03e91269"), "Joshuah Grove, 87175" },
                    { new Guid("c437faf4-0a70-471d-a09a-ba786c89660f"), 53, "50,148884;30,942474", "Nikitachester, Czech Republic", new Guid("c437faf4-0a70-471d-a09a-ba786c89660f"), "Ada Ports, 73165" },
                    { new Guid("c50337b3-7a81-474c-be71-57184cdd3d50"), 149, "49,803337;26,949818", "New Stephanietown, Barbados", new Guid("c50337b3-7a81-474c-be71-57184cdd3d50"), "Pacocha Prairie, 129" },
                    { new Guid("c552ae3d-77fa-47e0-8fec-fcd8bab3aecd"), 58, "49,169003;26,500813", "Watershaven, Trinidad and Tobago", new Guid("c552ae3d-77fa-47e0-8fec-fcd8bab3aecd"), "Kuhn Curve, 453" },
                    { new Guid("c84394b6-c44c-4c13-9028-53244dc7646b"), 94, "50,635456;26,970085", "Port Arnoldville, Netherlands Antilles", new Guid("c84394b6-c44c-4c13-9028-53244dc7646b"), "Zulauf Valleys, 12737" },
                    { new Guid("c8d69965-574e-48be-842a-a479ca88fbe4"), 8, "49,35208;30,302319", "Susanafurt, United States Minor Outlying Islands", new Guid("c8d69965-574e-48be-842a-a479ca88fbe4"), "Marge Lodge, 51127" },
                    { new Guid("c90c6a5f-a271-4515-9f4b-2dc758c733cd"), 199, "49,92064;23,78299", "Port Kristafort, Guinea-Bissau", new Guid("c90c6a5f-a271-4515-9f4b-2dc758c733cd"), "Omari Vista, 71983" },
                    { new Guid("c967bc81-d239-4061-b105-b2f8fe963382"), 149, "50,333115;29,450869", "Scottiestad, Rwanda", new Guid("c967bc81-d239-4061-b105-b2f8fe963382"), "Baumbach Turnpike, 1511" },
                    { new Guid("ca2fb0db-fe0e-475a-8bae-56f59b084393"), 197, "48,966873;29,04003", "Lake Melvinamouth, Burundi", new Guid("ca2fb0db-fe0e-475a-8bae-56f59b084393"), "Reta Coves, 792" },
                    { new Guid("d04f2d1c-318d-45a5-ae7f-47ee783bf383"), 165, "49,9007;29,611887", "North Zaria, Saint Barthelemy", new Guid("d04f2d1c-318d-45a5-ae7f-47ee783bf383"), "Dereck Stravenue, 5801" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "Id", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("d2bc7f0a-379d-44ee-9774-0f165b1135dc"), 129, "50,228283;23,97537", "North Drew, Egypt", new Guid("d2bc7f0a-379d-44ee-9774-0f165b1135dc"), "Blaise Dam, 526" },
                    { new Guid("d483465f-596f-4b9d-b7e7-2ac8869a2831"), 98, "50,76966;28,117819", "Emmerichbury, Tajikistan", new Guid("d483465f-596f-4b9d-b7e7-2ac8869a2831"), "Patrick Streets, 438" },
                    { new Guid("d81d8f53-e255-4277-888b-3b6433997188"), 168, "49,888676;30,419466", "Hettingerfort, Madagascar", new Guid("d81d8f53-e255-4277-888b-3b6433997188"), "Flavie Roads, 20423" },
                    { new Guid("dbb08058-29c4-4964-8c0c-6269268c69d7"), 132, "48,09507;26,922094", "West Cassie, Benin", new Guid("dbb08058-29c4-4964-8c0c-6269268c69d7"), "Ora Mews, 8131" },
                    { new Guid("dbd6e060-b183-453a-9ec6-eebb5ea38dbf"), 66, "50,510998;26,538027", "Lempishire, Portugal", new Guid("dbd6e060-b183-453a-9ec6-eebb5ea38dbf"), "Eleanore Views, 06274" },
                    { new Guid("dd91f87e-4bec-4440-95df-c5b384e888f7"), 162, "50,953354;24,95547", "East Pinkside, Christmas Island", new Guid("dd91f87e-4bec-4440-95df-c5b384e888f7"), "Adrian Isle, 480" },
                    { new Guid("dfd21e0c-cb01-4c54-9f6f-b60d12adc711"), 62, "49,22755;25,781523", "Angelabury, Saudi Arabia", new Guid("dfd21e0c-cb01-4c54-9f6f-b60d12adc711"), "Kemmer Street, 08145" },
                    { new Guid("e7053ee2-c3f8-4399-830f-d1ad8e0f42ba"), 97, "49,08617;25,109957", "Providenciview, Ghana", new Guid("e7053ee2-c3f8-4399-830f-d1ad8e0f42ba"), "Kulas Lane, 861" },
                    { new Guid("e967a7bd-c68d-40cc-9a95-f3437315c21c"), 178, "49,83234;29,133247", "Zulaufside, Egypt", new Guid("e967a7bd-c68d-40cc-9a95-f3437315c21c"), "Lillian Islands, 958" },
                    { new Guid("ec4ba5c6-7ece-4fc7-b153-6a8d56d131a3"), 80, "48,540237;29,02348", "Joesphfort, Syrian Arab Republic", new Guid("ec4ba5c6-7ece-4fc7-b153-6a8d56d131a3"), "Camila Rest, 6700" },
                    { new Guid("ecf19400-e1a0-41f5-ae21-89c764122d5b"), 35, "50,12832;28,49022", "Terrenceton, Montserrat", new Guid("ecf19400-e1a0-41f5-ae21-89c764122d5b"), "O'Reilly Trace, 17039" },
                    { new Guid("ed2d0d88-63c7-4be1-b981-8947a25567e9"), 31, "48,211018;27,19853", "Jenningshaven, Kenya", new Guid("ed2d0d88-63c7-4be1-b981-8947a25567e9"), "Karina Grove, 3563" },
                    { new Guid("ef223fca-16de-45e1-88f2-47cfeb12607f"), 37, "50,465305;27,882734", "South Orlo, Antarctica (the territory South of 60 deg S)", new Guid("ef223fca-16de-45e1-88f2-47cfeb12607f"), "Kathleen Roads, 6710" },
                    { new Guid("f45805d5-ac57-4ab9-b684-f848dfb70ea1"), 180, "49,92268;30,896254", "Douglastown, Bulgaria", new Guid("f45805d5-ac57-4ab9-b684-f848dfb70ea1"), "Maximo Fort, 20528" },
                    { new Guid("f55ee97e-3ddd-462b-9ee6-10347c16c50a"), 116, "49,3859;24,76661", "South Ernestina, Pakistan", new Guid("f55ee97e-3ddd-462b-9ee6-10347c16c50a"), "Mable Vista, 5430" },
                    { new Guid("f7aab99a-29ab-4ef3-a1a2-0300c3efa9c6"), 103, "49,089565;27,971653", "New Foster, Cape Verde", new Guid("f7aab99a-29ab-4ef3-a1a2-0300c3efa9c6"), "Gusikowski Hollow, 9622" },
                    { new Guid("f7b2de48-20ea-4689-89b1-0bfea7826ce5"), 95, "48,67961;29,453703", "West Jaeden, Burkina Faso", new Guid("f7b2de48-20ea-4689-89b1-0bfea7826ce5"), "Steuber Pass, 63168" },
                    { new Guid("f978b35d-16a3-4931-a6bf-e4be9dd6054b"), 174, "50,33488;28,943142", "Joelleshire, Macao", new Guid("f978b35d-16a3-4931-a6bf-e4be9dd6054b"), "Irving Ways, 76329" },
                    { new Guid("f9ecebd6-4676-4b4e-b7ac-cfcfa0f7912f"), 117, "49,628098;30,098585", "Barrowsview, Burkina Faso", new Guid("f9ecebd6-4676-4b4e-b7ac-cfcfa0f7912f"), "Cummerata Stream, 116" },
                    { new Guid("fc77bc29-0fc9-4dc3-bece-fbfb6448db24"), 30, "49,909256;30,986757", "New Spencershire, French Guiana", new Guid("fc77bc29-0fc9-4dc3-bece-fbfb6448db24"), "Clarissa Camp, 4056" },
                    { new Guid("fed57760-157e-4c7c-83ab-302e2e829fca"), 58, "48,506657;26,398876", "East Shanieville, Japan", new Guid("fed57760-157e-4c7c-83ab-302e2e829fca"), "Delores Forges, 302" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "Id", "StartDate" },
                values: new object[,]
                {
                    { new Guid("0164d5f6-45e9-4d6b-8b0d-ca7a97d74357"), -1565424306, 0.001417316153232040m, "L5cAXKgUVzF63ymxEkHtDWeGNZp7MYdw9", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1137), new Guid("0164d5f6-45e9-4d6b-8b0d-ca7a97d74357"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1135) },
                    { new Guid("01ac395e-3d44-4f0f-b2af-b7474811b8fe"), -942186394, 0.8097463347613590m, "LZo95vd6itmaqrPNBGKzQjWpDwg3YMuF", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1848), new Guid("01ac395e-3d44-4f0f-b2af-b7474811b8fe"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1846) },
                    { new Guid("0225b9d9-4062-4a25-a440-b163575bc498"), 864260521, 0.8518451687821690m, "L85Gz3Cu2qoagLmDe7RiBY4P1SVXyNdU", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(225), new Guid("0225b9d9-4062-4a25-a440-b163575bc498"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(223) },
                    { new Guid("02890ad2-d464-4140-969c-b3062fbaf55f"), -1053762140, 0.05923205162236890m, "Mfe5TXWmYdFSbp4LVUKjgGxotsN3CHvZ", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9556), new Guid("02890ad2-d464-4140-969c-b3062fbaf55f"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9554) },
                    { new Guid("035122d4-a4be-412b-8438-124ce506a0bd"), -702163262, 0.6370620155609610m, "LhYKNy7zJisZ6x53nwvakWEtA4Bq", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9535), new Guid("035122d4-a4be-412b-8438-124ce506a0bd"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9533) },
                    { new Guid("0577b18c-6eba-4b5a-a43c-7304ab1acaa6"), -13236970, 0.1157139287251740m, "L9YVDKL3pdwno6huBHxUT1fNet5abvSZWF", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1930), new Guid("0577b18c-6eba-4b5a-a43c-7304ab1acaa6"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1929) },
                    { new Guid("058d252f-e41d-464d-bb73-6cb00789d6e6"), -825271442, 0.040733327439350m, "MkyC9DRpqPjxJ5FcTfHGEXtMUevV17dN", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(612), new Guid("058d252f-e41d-464d-bb73-6cb00789d6e6"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(611) },
                    { new Guid("0644b7f6-597c-4133-aca0-02622013c3fd"), -225446868, 0.1369582821260970m, "3dSmCEnyV2prHebigP8U1AaRMs7XGct", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(353), new Guid("0644b7f6-597c-4133-aca0-02622013c3fd"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(351) },
                    { new Guid("07425b61-313f-4786-a431-95cb4bbdca38"), -50712251, 0.4374214125154440m, "3PdkvDJL7Y2ztQxrTUBR5nqufGF", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1517), new Guid("07425b61-313f-4786-a431-95cb4bbdca38"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1515) },
                    { new Guid("0806ac2d-f4b3-413e-9d0d-4df8e2bf9dbd"), -490428762, 0.9484100044058180m, "MwRskGm81u49YevnJLVp2iX3zUy5HhCq", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1910), new Guid("0806ac2d-f4b3-413e-9d0d-4df8e2bf9dbd"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1909) },
                    { new Guid("095408f3-9cdd-42f8-bdbf-860896c0ba93"), 451408443, 0.2876796189863390m, "MfiW5yuh9vRHE2FgLmPMXcjTCrUKV1", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1435), new Guid("095408f3-9cdd-42f8-bdbf-860896c0ba93"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1434) },
                    { new Guid("0be2ee6a-bea7-48d3-b606-670348048380"), 691862208, 0.4065382833402440m, "3GEKgPLUzDdyiak2uVoCxm5YvWMJ4Aq", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1752), new Guid("0be2ee6a-bea7-48d3-b606-670348048380"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1750) },
                    { new Guid("0c7a534b-bf84-4bf0-b6fb-ffa28e11c5c8"), 1174874776, 0.1532622171399480m, "MQiAXwBbcoqEt3HfDT1J6sLm5MvrUk", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(10), new Guid("0c7a534b-bf84-4bf0-b6fb-ffa28e11c5c8"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(8) },
                    { new Guid("0e103942-2841-4c5f-a13a-e008b8a46d1a"), -764919529, 0.890815794443720m, "Lv7CGbXwrBZh5RSxim6fQ2UTJzedLFoyN", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1829), new Guid("0e103942-2841-4c5f-a13a-e008b8a46d1a"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1827) },
                    { new Guid("0f8ec9cb-d74f-4b52-b3f7-aebc4f091b48"), -1483986445, 0.1425740458450880m, "LFn3NVMQ4hP2Xt8rWUKEBGRg56u", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9783), new Guid("0f8ec9cb-d74f-4b52-b3f7-aebc4f091b48"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9780) },
                    { new Guid("11932e50-115c-4fb6-9332-52e7faa628e0"), 1839345150, 0.340155682477920m, "LiA4u2RroEm5vzeN6TtcSYyhjUCb3Vs", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1713), new Guid("11932e50-115c-4fb6-9332-52e7faa628e0"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1711) },
                    { new Guid("14bd2011-ad6f-4881-96f7-96fcff6eb4eb"), -1541815526, 0.9952636175888090m, "LsnHTYJ7he4F5U98bG1f26xN3gi", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9882), new Guid("14bd2011-ad6f-4881-96f7-96fcff6eb4eb"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9880) },
                    { new Guid("16a6ff48-ecef-427e-b7cd-d00cbee1e86e"), 1332352604, 0.8980007512735620m, "LquPxFEcek6KbnzpVgy3f5GdhNQWasio4", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1274), new Guid("16a6ff48-ecef-427e-b7cd-d00cbee1e86e"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1272) },
                    { new Guid("202eeadc-099f-497c-8abd-2276a54558c1"), 871725768, 0.8654463097395180m, "3bD2M8rVGRi5ejhkSYE1nPf7oHA6ypuW", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9408), new Guid("202eeadc-099f-497c-8abd-2276a54558c1"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9406) },
                    { new Guid("202f5845-c6b9-45b9-ab1e-050e7f140fde"), -1779301435, 0.01631606577444810m, "M7JFfGcqUe5QSk96tEuZ1WYDVMdHbNz", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9989), new Guid("202f5845-c6b9-45b9-ab1e-050e7f140fde"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9987) },
                    { new Guid("22e4169b-db3b-42d8-a6ba-cedf08065ceb"), -1222760329, 0.7304318591343420m, "MoTeubUGF8Ewi5kPd623VR1MnYzyAf", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(95), new Guid("22e4169b-db3b-42d8-a6ba-cedf08065ceb"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(93) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "Id", "StartDate" },
                values: new object[,]
                {
                    { new Guid("24e14cb4-1b56-4012-ba9f-f378806cfa3c"), -653813017, 0.6281045037470480m, "Mj3RUEKyvoCbckLTHASf97net8Wh", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9344), new Guid("24e14cb4-1b56-4012-ba9f-f378806cfa3c"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9333) },
                    { new Guid("25991b88-dd29-461f-8ec8-a6e810638ec0"), 1856161246, 0.02464155560741470m, "MzybGmWpSKsadeEiqD1kA5gjBQX6H", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(206), new Guid("25991b88-dd29-461f-8ec8-a6e810638ec0"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(204) },
                    { new Guid("293c98e3-64bd-41fe-a650-f6af34841f03"), 863525333, 0.7199828392248270m, "Mm7Q485dFgM1XuVJnSHtYERkWGa6rAws", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9649), new Guid("293c98e3-64bd-41fe-a650-f6af34841f03"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9647) },
                    { new Guid("2d464b7c-277a-46b6-a9b5-28cf6a68fc0e"), -1972321796, 0.4752661583725270m, "3YJhyGViUcAs4e5n1jrpgL63Bvuk2", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(55), new Guid("2d464b7c-277a-46b6-a9b5-28cf6a68fc0e"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(53) },
                    { new Guid("2fe5e365-4c71-41f4-aaf3-5e711eeb901a"), 520832428, 0.2859294079881380m, "LaNFyhPCrqAvcXx7EDsbMKe5Vun8W", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9516), new Guid("2fe5e365-4c71-41f4-aaf3-5e711eeb901a"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9514) },
                    { new Guid("31106897-6338-4d57-8396-2f79c2039deb"), 1549764561, 0.07864616527645170m, "3qpfuUkPoiLz6E5HCNGBySWYhdFmgJR14", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1872), new Guid("31106897-6338-4d57-8396-2f79c2039deb"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1870) },
                    { new Guid("311aef9a-c243-4594-b106-ce9cf71087ce"), -1484846602, 0.8879567635224020m, "MRkmDC1bGdMLHnxAy2ZNqwu6EotzY", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9669), new Guid("311aef9a-c243-4594-b106-ce9cf71087ce"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9667) },
                    { new Guid("313304a8-f222-42e2-8089-dde58dd3d922"), 79538721, 0.7042509007521910m, "MSs3HbhMomNq9aXKxA72dDVrPzw1W", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1891), new Guid("313304a8-f222-42e2-8089-dde58dd3d922"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1889) },
                    { new Guid("33d6f973-40da-4dbc-9385-5d31bc368ae0"), -803041123, 0.05718840361986540m, "3SJtBehVpC5P892Amb4WryTMxDXf16Ya7", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1200), new Guid("33d6f973-40da-4dbc-9385-5d31bc368ae0"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1198) },
                    { new Guid("35cb4028-cc21-4006-a395-c3c385118bff"), 1424432511, 0.2901348613232220m, "3ouKPcJ1BnhejE2sG8FXAxbMzat", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9822), new Guid("35cb4028-cc21-4006-a395-c3c385118bff"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9820) },
                    { new Guid("3a901df6-2fe6-448c-afdc-bddfc130a679"), 183665109, 0.1409809863811430m, "MMZvpSDk5b49YmFNztRWEcCGhaHdqV32", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1356), new Guid("3a901df6-2fe6-448c-afdc-bddfc130a679"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1354) },
                    { new Guid("3fc4b68a-6acc-4199-b669-8922a636fd7b"), -942124245, 0.645363681676340m, "LJCQNycAShUgv962xqMKrH5mEzu4Bt", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9496), new Guid("3fc4b68a-6acc-4199-b669-8922a636fd7b"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9494) },
                    { new Guid("42737b43-1af0-44ef-8fc0-7e1aac13a6d1"), -1830861046, 0.4630072014182690m, "MVyKNMW425e3Gg1hvDLkxdTwbnzPamH9", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(75), new Guid("42737b43-1af0-44ef-8fc0-7e1aac13a6d1"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(74) },
                    { new Guid("446c3698-7c52-4ccd-9b71-4326fa07d224"), 124250375, 0.1354549910831430m, "31E5u9kKfUj8SZMJpWvC4dAB7qawgimbn", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1312), new Guid("446c3698-7c52-4ccd-9b71-4326fa07d224"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1310) },
                    { new Guid("465000c5-d5be-4c5a-9597-33494ece6e64"), -1056618266, 0.3482850947841180m, "3HdXY1PywQKM86RbNpsaxcSJW2UvLVmEC4", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1498), new Guid("465000c5-d5be-4c5a-9597-33494ece6e64"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1496) },
                    { new Guid("4d8c3a4d-3b05-4c49-bca5-98d2968b7192"), -1997283416, 0.1346601306894470m, "LKvRG8b5hJmCLBWPoDHtzyQN1nMEaSq4", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(284), new Guid("4d8c3a4d-3b05-4c49-bca5-98d2968b7192"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(282) },
                    { new Guid("4dd5ebaa-3b8d-4ddf-a436-549fc23b9d58"), -637325676, 0.6211109860889380m, "LfHNBp4wbXvJZnhSWMT72e1UFrAy", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1179), new Guid("4dd5ebaa-3b8d-4ddf-a436-549fc23b9d58"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1178) },
                    { new Guid("4ee0b215-9d35-4eda-8301-baae35768a0a"), 116439056, 0.8958273205941540m, "LZeM79xFiX2KqwdBR65cQvPaoUjmuA", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9715), new Guid("4ee0b215-9d35-4eda-8301-baae35768a0a"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9712) },
                    { new Guid("505e2a29-717c-4b5b-a66e-33de94b59968"), -955265515, 0.6838882640736230m, "MweRCovi1mdkH23apfYgqGPNF9j", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9843), new Guid("505e2a29-717c-4b5b-a66e-33de94b59968"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9841) },
                    { new Guid("5198b770-91a4-4153-82c6-a58ab0ceed1e"), -179900566, 0.3170706350304970m, "MfESFhbtc8X7vCDgpMYUiu1jLHBrA", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1293), new Guid("5198b770-91a4-4153-82c6-a58ab0ceed1e"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1291) },
                    { new Guid("51f2f692-8953-4df7-b592-7626d6421976"), -1470674343, 0.1329321726387860m, "3LHWCRK8c7xan32jpvg9P4EBMoF5rX", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9862), new Guid("51f2f692-8953-4df7-b592-7626d6421976"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9861) },
                    { new Guid("523a0fd9-ee43-47c9-bfdc-00836c5b9ce1"), -1391252427, 0.7229608991075040m, "3cbh8W5qrGgkioYx2MZ1L79HJtmP", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9628), new Guid("523a0fd9-ee43-47c9-bfdc-00836c5b9ce1"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9626) },
                    { new Guid("52cccb6d-e75c-4ade-a4a1-807c7415f17d"), 132111912, 0.07004498677120070m, "31b6nYLKA9mxz2tCU75FoDdiPNTq", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9432), new Guid("52cccb6d-e75c-4ade-a4a1-807c7415f17d"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9430) },
                    { new Guid("5367611d-8d07-4fab-9316-fad16fc2de1b"), 1071294328, 0.8799284365014240m, "MSrTUG5KX8w9PkuvRQyxcfaDoVbWMH", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9920), new Guid("5367611d-8d07-4fab-9316-fad16fc2de1b"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9919) },
                    { new Guid("5487647a-9f3f-4c26-8263-91a47fa69450"), 1614895887, 0.1273396863283250m, "LXp7y5dEzZCPtaJevjBx36bAs4TKmGDW1f", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1951), new Guid("5487647a-9f3f-4c26-8263-91a47fa69450"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1949) },
                    { new Guid("56cadcad-4cd6-4f18-b7ae-cb15d72db406"), -1176853290, 0.9147736433594230m, "Mwu7kme3PNcrtTsLx8H61G5p2XgEy", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1240), new Guid("56cadcad-4cd6-4f18-b7ae-cb15d72db406"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1235) },
                    { new Guid("57d42ba2-1e09-4ed5-aed3-68f79f4b197e"), -687208858, 0.2688402731382310m, "3cq3MLm8yk2bEeSsXTpA7JjrwFx", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(35), new Guid("57d42ba2-1e09-4ed5-aed3-68f79f4b197e"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(33) },
                    { new Guid("5e0386c9-4257-43de-a6dc-c65b42fe0e6f"), -956534562, 0.7998852177338280m, "3fKmVcp4ZxXFL3RkMsaAdtiBCDPW", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1218), new Guid("5e0386c9-4257-43de-a6dc-c65b42fe0e6f"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1216) },
                    { new Guid("5e62fa48-fda9-4559-8d26-7f8eff40ea65"), -1517890650, 0.8533166844538410m, "35Ur2jv6TaHF4sVWuRSCcw7zZim8XAo", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(6269), new Guid("5e62fa48-fda9-4559-8d26-7f8eff40ea65"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(3021) },
                    { new Guid("66f43b13-53b0-488c-a4ee-aa2be7b33583"), 1360683767, 0.1932497433341540m, "LbpP4ZwCWjAQYsKrktG3odM6x1z9HvJXRN", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1650), new Guid("66f43b13-53b0-488c-a4ee-aa2be7b33583"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1648) },
                    { new Guid("67448a16-3247-4cce-aad7-41fd3e3a5063"), 667214711, 0.315334906839950m, "MPk6zaHK3MTr4UcSF1WtECLV98fDRwAg", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9689), new Guid("67448a16-3247-4cce-aad7-41fd3e3a5063"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9688) },
                    { new Guid("68c388d8-d489-418b-b563-e572e988f4cd"), 2051943046, 0.8499964423467440m, "Lhi2F7TyQnufYoCeXNqMVd3cpLH", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(332), new Guid("68c388d8-d489-418b-b563-e572e988f4cd"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(330) },
                    { new Guid("6de0321e-8d0b-446a-ae2a-93f4404300de"), -2106705545, 0.3038239851916110m, "3DnHmC8VZEfXY1LAQeMPhg7S4dbkx", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(115), new Guid("6de0321e-8d0b-446a-ae2a-93f4404300de"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(113) },
                    { new Guid("75cb78dd-c7bf-4098-b4a9-ba66a7d8fa64"), -1134319328, 0.007300686445997350m, "3L3VzApq8vnTNkemXchD9xow74WQr", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9609), new Guid("75cb78dd-c7bf-4098-b4a9-ba66a7d8fa64"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9607) },
                    { new Guid("786e7f1a-1d1e-44ab-9f04-3b90fa726415"), -1310171030, 0.423492415532330m, "3tC8JemXVfwQ74NZKvEiDP19URhkqS3HxM", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9475), new Guid("786e7f1a-1d1e-44ab-9f04-3b90fa726415"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9473) },
                    { new Guid("7bf2606a-e3ca-4afb-b68a-c3f1a636dd6a"), -2100537693, 0.6816399103210950m, "L6yKLnXQd8A1Ws9GqP4Ujgi7JarfmVS", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1604), new Guid("7bf2606a-e3ca-4afb-b68a-c3f1a636dd6a"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1602) },
                    { new Guid("7c615273-fa33-406c-b435-b2c45c2d6bcd"), 46114952, 0.8752818200220380m, "3m4qKzDg6RxfFHjh5J8GVCoWcer1vLUAE", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9902), new Guid("7c615273-fa33-406c-b435-b2c45c2d6bcd"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9900) },
                    { new Guid("7efb7224-d811-4e8e-b286-8cb634c34354"), -262430752, 0.3637382467693920m, "MPEeCWyGXcY1jtmQLir5Dx9KTpNMaUu", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(264), new Guid("7efb7224-d811-4e8e-b286-8cb634c34354"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(262) },
                    { new Guid("857951ff-aae5-408c-8345-a3c8fcbd28b9"), -1160532778, 0.8296194585074670m, "37udjbVSrZFamUELzyY1exCGTQW2HNoXBf", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(394), new Guid("857951ff-aae5-408c-8345-a3c8fcbd28b9"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(392) },
                    { new Guid("86f79fbe-bd12-4394-96a1-cb48995da9c3"), 413394465, 0.1637843531491620m, "Lyb7WY3A8ThMViqKDdjxULH5wJsgnG6zE", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1116), new Guid("86f79fbe-bd12-4394-96a1-cb48995da9c3"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1115) },
                    { new Guid("8967ef2d-1b1f-4e01-ac41-1dbbe483b67f"), -1640496303, 0.3535658551303850m, "3VsmpDWyrLJ5ETzoiGNQRY8ne4uX6t3v9", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1161), new Guid("8967ef2d-1b1f-4e01-ac41-1dbbe483b67f"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1159) },
                    { new Guid("8d1e1e6e-488c-4938-8c5a-99d9168220b8"), -528781378, 0.6343808290977460m, "3pi9DSfcj5u1oTHLqCPsYBKyW24R", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(372), new Guid("8d1e1e6e-488c-4938-8c5a-99d9168220b8"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(371) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "Id", "StartDate" },
                values: new object[,]
                {
                    { new Guid("8d808537-58bc-4aad-984f-ab928dd15089"), -1452018966, 0.9695031641793320m, "LK8diWE3xNhRrYouy4vSqH1z5C69A", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9579), new Guid("8d808537-58bc-4aad-984f-ab928dd15089"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9577) },
                    { new Guid("8e1a1a3a-7345-461f-b1e4-58b78400d086"), 2121137940, 0.78571546823540m, "L4CfxGtyb9gEhAPM85WKRU3ZLkYQid6oqS", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(308), new Guid("8e1a1a3a-7345-461f-b1e4-58b78400d086"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(307) },
                    { new Guid("93841682-23f2-47de-9e3b-e27eb36561f0"), -361552088, 0.3319577023383680m, "35wgtGU9spieHBL2AmFoS3CMnK7DR", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1472), new Guid("93841682-23f2-47de-9e3b-e27eb36561f0"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1471) },
                    { new Guid("959f0524-e823-46d2-90b5-aded9e4e72e1"), -1287238625, 0.455221516662020m, "Ls6vkcqDXpbV925oJinwUHzNQ7RKmuMgG", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9941), new Guid("959f0524-e823-46d2-90b5-aded9e4e72e1"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9939) },
                    { new Guid("9c7a4fa7-486a-4735-8fda-7a0ad47fa0b1"), -1147431042, 0.3314382991978820m, "3m51zRLSHCuPyMA49tgjJYKdUaoVq7BGv", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1972), new Guid("9c7a4fa7-486a-4735-8fda-7a0ad47fa0b1"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1971) },
                    { new Guid("9ce0d75e-03b9-42b8-a76b-a0b2c87c7209"), -1847521144, 0.6845563014999560m, "LNSnRMskfoB9bYXwGhtgQeJ56Ta3xiPED", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(963), new Guid("9ce0d75e-03b9-42b8-a76b-a0b2c87c7209"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(959) },
                    { new Guid("9d74a777-dcbf-4a5e-8f67-aadb7335c0f5"), 131503754, 0.8259318791397130m, "LDBXZHQo4MLqprgFuGYeJsKPS28", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1770), new Guid("9d74a777-dcbf-4a5e-8f67-aadb7335c0f5"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1768) },
                    { new Guid("a076515e-b55d-41d2-aa5d-c3dfb52a7e3d"), -1879571093, 0.7419046958699840m, "LbL3xAjwSGKhigVZYd5tUMCs7yqzm9Na2E", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(655), new Guid("a076515e-b55d-41d2-aa5d-c3dfb52a7e3d"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(653) },
                    { new Guid("a1891a11-845c-4f49-a73b-3eefaa16fac3"), -506622722, 0.9925250048776060m, "MvVzg5RKjaAkf2mcC7qypFMht3LTQUi", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1414), new Guid("a1891a11-845c-4f49-a73b-3eefaa16fac3"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1412) },
                    { new Guid("a5a3778c-16c6-47ef-87aa-95b9afd40f32"), -1803469053, 0.9962879425811980m, "33XsTo7VbH5PFcxvKJR6LqGYWDQeA9N", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1375), new Guid("a5a3778c-16c6-47ef-87aa-95b9afd40f32"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1373) },
                    { new Guid("a5de5e84-8f1f-4db6-84d4-6d43ba9d9de1"), 74642929, 0.5462565956688510m, "3XVesPHRoAx8n4SNayWBFchrQ7YJ6j5G", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9748), new Guid("a5de5e84-8f1f-4db6-84d4-6d43ba9d9de1"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9745) },
                    { new Guid("a6cfe138-e789-4bf0-b4c4-554c33bfd944"), 723798149, 0.4530285903534370m, "LZ9GoiK7sYrJRB5dNLFj6EWv8VHwnf", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(244), new Guid("a6cfe138-e789-4bf0-b4c4-554c33bfd944"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(243) },
                    { new Guid("a8294187-601f-4429-9958-635c337c2799"), -1074997268, 0.2748657351244360m, "M1xHMvPgrUFasZ45JXhyqn6kNiV", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1626), new Guid("a8294187-601f-4429-9958-635c337c2799"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1624) },
                    { new Guid("acc5658c-ea72-4136-98da-78390fb30bf8"), -576148169, 0.1130339988292880m, "3zihRq7KmH9rcW6EVnybSZM4j1p", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(994), new Guid("acc5658c-ea72-4136-98da-78390fb30bf8"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(992) },
                    { new Guid("b211863e-f080-40c8-b179-9cf4d3d19ed9"), 1471877080, 0.4906936471782040m, "MSmRyb16Mgtsx9ozeuTAr5FjiHYnq", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1454), new Guid("b211863e-f080-40c8-b179-9cf4d3d19ed9"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1452) },
                    { new Guid("b6cb18ad-693e-4ccd-ad74-ea21e54a1f9f"), 1534526118, 0.7948790185583780m, "L5D9erxL8mbqSpRy7B4dCGzaWVXHZN6MuP", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1670), new Guid("b6cb18ad-693e-4ccd-ad74-ea21e54a1f9f"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1668) },
                    { new Guid("b74bb030-e060-43db-91f3-8820a079b36c"), -1359502033, 0.9629885799429160m, "LEA6NtXSyQKPnaDur1R4dG7oF8e", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1809), new Guid("b74bb030-e060-43db-91f3-8820a079b36c"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1807) },
                    { new Guid("bddcb316-6feb-4912-913a-c796342ec280"), -1319794402, 0.2087998080859030m, "Lc4yzmkqouAECBi78YFZbDeLNvwSJT", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1395), new Guid("bddcb316-6feb-4912-913a-c796342ec280"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1393) },
                    { new Guid("c2d3d72e-d83a-45e9-954d-8d36f0569266"), -590529613, 0.4962148687049030m, "3oh72Dy49aCSJctrQqg8k1YWiFMVn", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(634), new Guid("c2d3d72e-d83a-45e9-954d-8d36f0569266"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(632) },
                    { new Guid("c500fa62-8af1-4091-a335-2cef7f34d600"), -919551912, 0.7235623206888810m, "3DcNykgV27GsWmSrj6KqQMEpLv9Yf", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1991), new Guid("c500fa62-8af1-4091-a335-2cef7f34d600"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1989) },
                    { new Guid("c747d10f-23b3-44ee-aa81-1d84b0a69e3d"), -1720339316, 0.7867655800221570m, "3km8xYRgfL9TjGD7wQBCSyV3WXb4a", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1536), new Guid("c747d10f-23b3-44ee-aa81-1d84b0a69e3d"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1534) },
                    { new Guid("c92d248d-c150-4cd0-b2a4-8ebb9301d18a"), -1411841810, 0.02082485041527860m, "LvmLuQ1y6nMrKoXSgDkUxFdePfthAE", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1097), new Guid("c92d248d-c150-4cd0-b2a4-8ebb9301d18a"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1095) },
                    { new Guid("ca9d819c-6187-4683-903b-1e268e458cb5"), -126108090, 0.02749130878479610m, "LHpRhn19vFVPX6S3YLibzKE7Dqyetafgu", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1074), new Guid("ca9d819c-6187-4683-903b-1e268e458cb5"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1072) },
                    { new Guid("cf74f045-11d2-493c-b5c1-7e3d66fa56fd"), -540718321, 0.1706941138588980m, "MJ9k4CgLVhyGTqH7udcAz6bWpaY", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(136), new Guid("cf74f045-11d2-493c-b5c1-7e3d66fa56fd"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(134) },
                    { new Guid("d613c3aa-9f8d-4a22-824e-c2144ce0a000"), -530020018, 0.06310982217192410m, "3S1aZ2yBi68jTsKEumDHGWRhQCM9XrA", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1035), new Guid("d613c3aa-9f8d-4a22-824e-c2144ce0a000"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1033) },
                    { new Guid("d75a0dc6-6cc0-4740-a4ea-0f57d3416d09"), -487135354, 0.02475820222405710m, "LZVeqpgmQkTx6so9aGHMNtYrJy287R3", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9963), new Guid("d75a0dc6-6cc0-4740-a4ea-0f57d3416d09"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9961) },
                    { new Guid("db4f7445-a869-4e01-bbdb-7c74527545eb"), 2033775275, 0.4724009829933260m, "L7o8VcYgQr9X1632pMTisKUGEvhtwdRq", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1733), new Guid("db4f7445-a869-4e01-bbdb-7c74527545eb"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1731) },
                    { new Guid("dcce3b65-d386-404f-8930-e472756ecc6c"), 1001650657, 0.5657459412855130m, "37tAy8CTxSzqjH1mFLRk4hupr3wBn692i", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(2010), new Guid("dcce3b65-d386-404f-8930-e472756ecc6c"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(2008) },
                    { new Guid("dfe1eaa5-d982-4156-a433-b403360b2efb"), 1678379239, 0.2686350729047380m, "LnhL5FZAJTRGDSBNCH1mogqwKQiy83r", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1788), new Guid("dfe1eaa5-d982-4156-a433-b403360b2efb"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1787) },
                    { new Guid("e5cd0223-69c7-4460-b567-ceb897989bc0"), -1873664063, 0.3185631545713810m, "3EuaY4BJeAbCp9LvU2xGs8DoHtd1736", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1053), new Guid("e5cd0223-69c7-4460-b567-ceb897989bc0"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1052) },
                    { new Guid("e8bbf77e-657c-4a47-a787-e4b4723d786c"), -375888115, 0.3397783245045520m, "384snCFBgvrQ6qAa3UkwotP7yVRzXKL", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1336), new Guid("e8bbf77e-657c-4a47-a787-e4b4723d786c"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1334) },
                    { new Guid("ef79dc78-fb17-4a70-ba67-224230b32855"), -856126886, 0.5536983688518950m, "3YPtkWv6EuBiF3jLUaDyZeb9q8Nfp1Hs", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(186), new Guid("ef79dc78-fb17-4a70-ba67-224230b32855"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(185) },
                    { new Guid("f24721a0-1b11-4c89-9573-34c7e629818f"), 1479755262, 0.5648878993927510m, "MCSk5Kpn4iuGzb2xwyegUmFrqf7vh", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1015), new Guid("f24721a0-1b11-4c89-9573-34c7e629818f"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1013) },
                    { new Guid("f58e0f9f-043c-42c9-b61c-d8c39a52982b"), 1518992092, 0.726755253644550m, "3KTNL7FsVzbn2hMfPmREj3AHU4rZ5dG", new DateTime(2024, 6, 11, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9452), new Guid("f58e0f9f-043c-42c9-b61c-d8c39a52982b"), new DateTime(2024, 6, 6, 2, 59, 32, 443, DateTimeKind.Local).AddTicks(9451) },
                    { new Guid("f8c5488e-0b84-4a82-b83e-c21fe0a2980c"), 347177812, 0.5246383610205480m, "LUfW64yEiNgsZtaVPFbBQdjrzoA", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1689), new Guid("f8c5488e-0b84-4a82-b83e-c21fe0a2980c"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(1687) },
                    { new Guid("f9ae0e1b-f5ab-45d7-b9a9-47025097d1ea"), 1386007454, 0.4132871024523110m, "LrLiK5ky36TFdo7Pc1BAGnh4HNRv9u", new DateTime(2024, 6, 11, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(806), new Guid("f9ae0e1b-f5ab-45d7-b9a9-47025097d1ea"), new DateTime(2024, 6, 6, 2, 59, 34, 477, DateTimeKind.Local).AddTicks(758) },
                    { new Guid("fc09d872-5ceb-41c5-b4c7-5ae0fc7de5c0"), -304224538, 0.3419144591228620m, "MdRMsYWkHwi8u5bSQaUeynr692B4AzxcE", new DateTime(2024, 6, 11, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(166), new Guid("fc09d872-5ceb-41c5-b4c7-5ae0fc7de5c0"), new DateTime(2024, 6, 6, 2, 59, 32, 444, DateTimeKind.Local).AddTicks(164) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("0462fe55-138a-4c03-a20d-8251dee6c206") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("05d888a7-8474-4565-b751-a89df2400346") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("0823436c-27ad-4402-b5e2-b17efa08505e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("08e83522-0abb-4778-9027-c86ca1a0a624") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("12656ae7-3922-41ca-b159-f79b439a354c") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("203cc97b-91be-4474-b881-e9776da21af9") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("314374c4-1bd7-4eda-8546-58617e464254") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("33d5b081-5c0f-4871-905f-631caba91848") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("35b6c210-2256-41cd-af8e-e815527e0a84") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("3e38a390-7168-426f-8d48-017588046d20") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("48949002-3dd7-424b-b508-bb6644cad6fb") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("54544805-6149-40a0-a366-c2fb8f55975f") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("665af7ab-85d3-48f3-bedd-30db54699f81") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("69170f92-b4b7-4c26-be44-5255d738fb20") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("71725c06-aded-4994-8181-26d1683597c4") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("83c8f958-a3f1-448d-bad0-048533827e0e") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("8987fd2f-b286-41d7-9544-b355355a2cff") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("8b3ae855-3f1f-409d-8898-00767477ffae") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("8b896efc-3b46-4670-bb2b-740919a113b5") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("8f8cd90d-fe20-4df0-8607-72f337546146") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a11d6609-e768-4189-bd78-5b34d82849e6") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("c0886dea-4971-4369-8d28-75754e2575d0") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("cfddcc04-5205-447d-9799-6d1945c391b4") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("d21f18d0-79a0-4851-976c-b989e790eac0") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("d422e4b4-5d7b-484f-830c-319350a69b22") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e5acadcd-43bb-4225-9367-f562e86197e5") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("ececce7b-505c-4bc7-b969-56ffcc451462") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("f1038abe-cd17-40c4-844a-70a0ee863724") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("f7720de3-aaea-48e9-af48-569af731d90b") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("f7e86b66-49eb-4774-82be-b008350dc98b") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("f825bff2-881f-450b-a4b7-56931951c54c") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("dcaeacc6-771c-4bf7-8af9-c6c92df63d1b"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("ee8286d0-4c8c-48f2-8959-9907d3d45009"), new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65") },
                    { new Guid("39d2d8ab-239a-4f23-a8e3-da2c758b2304"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("000d610e-0ef6-4ac4-9976-c19d7d885c7e"), "Brittany_Fay@yahoo.com", false, new Guid("000d610e-0ef6-4ac4-9976-c19d7d885c7e"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("004ff982-b077-42d7-b3d9-9cd9496d164b"), "Mollie_Tremblay@gmail.com", false, new Guid("004ff982-b077-42d7-b3d9-9cd9496d164b"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("008cc0fe-7ba5-46b4-8a6c-e49eec274fbb"), "Tristin24@yahoo.com", false, new Guid("008cc0fe-7ba5-46b4-8a6c-e49eec274fbb"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("008d9ecc-69d0-41d8-993b-ea7417e9c41e"), "Gus_Roberts@gmail.com", false, new Guid("008d9ecc-69d0-41d8-993b-ea7417e9c41e"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("008ddf46-2040-453c-88f4-98858f6d6137"), "Raphael.Volkman@gmail.com", false, new Guid("008ddf46-2040-453c-88f4-98858f6d6137"), new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac") },
                    { new Guid("00a70723-3702-4f25-bc10-bea4bb669e95"), "Tremaine.Wolff97@hotmail.com", false, new Guid("00a70723-3702-4f25-bc10-bea4bb669e95"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("00c2d409-44b0-45ff-8190-578a3312bf90"), "Kelton.Hand40@hotmail.com", false, new Guid("00c2d409-44b0-45ff-8190-578a3312bf90"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("012a89cb-532f-4e4b-ad3a-a1e2f0d3850e"), "Ruby.Torp67@yahoo.com", false, new Guid("012a89cb-532f-4e4b-ad3a-a1e2f0d3850e"), new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131") },
                    { new Guid("012d8bc2-89d4-4a6e-b457-0e24478e2907"), "Anabelle_Mueller@gmail.com", false, new Guid("012d8bc2-89d4-4a6e-b457-0e24478e2907"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("013d9973-accc-4f3e-ab8a-4be73ccd6c99"), "Deven40@hotmail.com", false, new Guid("013d9973-accc-4f3e-ab8a-4be73ccd6c99"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("015a7463-a655-4cc0-81da-50e28464978b"), "Cole_Weber@gmail.com", false, new Guid("015a7463-a655-4cc0-81da-50e28464978b"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("016dffb1-07cf-4345-9da3-736ff237b6ac"), "Evert6@yahoo.com", false, new Guid("016dffb1-07cf-4345-9da3-736ff237b6ac"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("016ed1b5-3cef-4f67-8dc1-ab52327725d6"), "Tanya_Streich8@gmail.com", false, new Guid("016ed1b5-3cef-4f67-8dc1-ab52327725d6"), new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6") },
                    { new Guid("01d6858d-1752-4283-bf9a-d76f3f3aa877"), "Dayana.Wiegand@yahoo.com", false, new Guid("01d6858d-1752-4283-bf9a-d76f3f3aa877"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("024a7825-640e-4792-a391-5651c1286be3"), "Hobart_Friesen@hotmail.com", false, new Guid("024a7825-640e-4792-a391-5651c1286be3"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("034f5916-ac50-4324-acf1-232af3766cf6"), "Ava.Hermiston@yahoo.com", false, new Guid("034f5916-ac50-4324-acf1-232af3766cf6"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("0429917b-5669-458c-bc39-0796f1d412c8"), "Edward63@gmail.com", false, new Guid("0429917b-5669-458c-bc39-0796f1d412c8"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("043a45cc-8f76-4952-ac11-fce17fcd38bc"), "Khalid36@yahoo.com", false, new Guid("043a45cc-8f76-4952-ac11-fce17fcd38bc"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("0468ec1d-8f5e-4bf2-8edd-3d60b397bf34"), "Mariah_Grant@gmail.com", false, new Guid("0468ec1d-8f5e-4bf2-8edd-3d60b397bf34"), new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867") },
                    { new Guid("048296d8-ca49-4ad3-a57f-04dfff2933f0"), "Alisa_Kuvalis@hotmail.com", false, new Guid("048296d8-ca49-4ad3-a57f-04dfff2933f0"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("049ec5ad-6f5d-44a0-9a0d-e6b4e63cf93a"), "Celine16@hotmail.com", false, new Guid("049ec5ad-6f5d-44a0-9a0d-e6b4e63cf93a"), new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a") },
                    { new Guid("05774b8c-6586-436c-97d1-bf141eacb54b"), "Mauricio_Bernier66@gmail.com", false, new Guid("05774b8c-6586-436c-97d1-bf141eacb54b"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("05af3c5d-49df-4361-8dbe-f26687a0fc70"), "Kamille75@yahoo.com", false, new Guid("05af3c5d-49df-4361-8dbe-f26687a0fc70"), new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22") },
                    { new Guid("05dac1fb-cb50-4bd9-a87d-edc9bfac3c63"), "Annabel50@gmail.com", false, new Guid("05dac1fb-cb50-4bd9-a87d-edc9bfac3c63"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("05e0c82b-478c-4f9a-b350-9cfd05edc739"), "Jess.Carroll55@yahoo.com", false, new Guid("05e0c82b-478c-4f9a-b350-9cfd05edc739"), new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c") },
                    { new Guid("060f33c4-aa3d-4f9e-ba94-adf5e088b634"), "Anahi_Stiedemann@gmail.com", false, new Guid("060f33c4-aa3d-4f9e-ba94-adf5e088b634"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("0687ad98-3f30-4deb-b4c5-aabd85f9b41d"), "Noble_Robel72@hotmail.com", false, new Guid("0687ad98-3f30-4deb-b4c5-aabd85f9b41d"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("06b123a8-f278-46a4-b959-ddb87630cbac"), "Norene96@gmail.com", false, new Guid("06b123a8-f278-46a4-b959-ddb87630cbac"), new Guid("8b896efc-3b46-4670-bb2b-740919a113b5") },
                    { new Guid("06b5f98f-aed2-4ff0-9b33-5ca841956a54"), "Stanford_Murazik12@gmail.com", false, new Guid("06b5f98f-aed2-4ff0-9b33-5ca841956a54"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("077f5722-c42a-4b37-aea4-909428360192"), "Mike43@yahoo.com", false, new Guid("077f5722-c42a-4b37-aea4-909428360192"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("07eaa2a8-71c9-40eb-9db5-301ae2969796"), "Camron.Anderson50@gmail.com", false, new Guid("07eaa2a8-71c9-40eb-9db5-301ae2969796"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("084fd0d8-51f5-4963-b43b-c76cf466a848"), "Blaise96@gmail.com", false, new Guid("084fd0d8-51f5-4963-b43b-c76cf466a848"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("09163bb6-7014-41ba-9441-5ae19e55ed72"), "Onie40@gmail.com", false, new Guid("09163bb6-7014-41ba-9441-5ae19e55ed72"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("093b6a0c-b7e7-4df1-bc1d-b745d7259fd1"), "Hilma_Nikolaus@yahoo.com", false, new Guid("093b6a0c-b7e7-4df1-bc1d-b745d7259fd1"), new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7") },
                    { new Guid("098d0aa0-a9c4-4b79-b26f-afc019dad80a"), "Elisabeth.Gutkowski84@hotmail.com", false, new Guid("098d0aa0-a9c4-4b79-b26f-afc019dad80a"), new Guid("54544805-6149-40a0-a366-c2fb8f55975f") },
                    { new Guid("09a116b6-a7d3-4d3b-a294-58705ec98a22"), "Emelia20@gmail.com", false, new Guid("09a116b6-a7d3-4d3b-a294-58705ec98a22"), new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("09d690e2-d327-4ed4-8610-cb239db490d1"), "Emmanuelle_McClure90@yahoo.com", false, new Guid("09d690e2-d327-4ed4-8610-cb239db490d1"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a5a0f64-6e26-4786-9c64-d21874c77a1a"), "Walter.Jaskolski77@hotmail.com", false, new Guid("0a5a0f64-6e26-4786-9c64-d21874c77a1a"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("0a64ac55-94a3-4f81-b820-97e397707b30"), "Emerald.Stamm34@yahoo.com", false, new Guid("0a64ac55-94a3-4f81-b820-97e397707b30"), new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861") },
                    { new Guid("0a983564-ceb7-413a-872c-3e260e17d126"), "Floyd_Kirlin@yahoo.com", false, new Guid("0a983564-ceb7-413a-872c-3e260e17d126"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("0ab54380-faa5-43c7-b11a-5bf21bbfa9ba"), "Noble1@gmail.com", false, new Guid("0ab54380-faa5-43c7-b11a-5bf21bbfa9ba"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("0af385f4-1e60-412d-a916-0f462c7b79e9"), "Carmel77@yahoo.com", false, new Guid("0af385f4-1e60-412d-a916-0f462c7b79e9"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("0b0e86bc-f03e-4f7b-911d-2199b6f35179"), "Janae.Friesen@gmail.com", false, new Guid("0b0e86bc-f03e-4f7b-911d-2199b6f35179"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("0b115f11-1959-4acc-ac8e-0e5bb773d34c"), "Ebony55@yahoo.com", false, new Guid("0b115f11-1959-4acc-ac8e-0e5bb773d34c"), new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("0b223487-43d2-4f2a-9055-026a358ba992"), "Kasey68@yahoo.com", false, new Guid("0b223487-43d2-4f2a-9055-026a358ba992"), new Guid("08e83522-0abb-4778-9027-c86ca1a0a624") },
                    { new Guid("0b63d112-26c6-4020-a0f9-701ee22e0ce9"), "Dianna.Rutherford73@hotmail.com", false, new Guid("0b63d112-26c6-4020-a0f9-701ee22e0ce9"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("0bbe626e-48c4-46c0-a96f-a7088efa1e34"), "Kailyn_Ruecker@yahoo.com", false, new Guid("0bbe626e-48c4-46c0-a96f-a7088efa1e34"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("0c010caf-fc59-4a68-b298-71b391356e2f"), "Imani.Wyman15@hotmail.com", false, new Guid("0c010caf-fc59-4a68-b298-71b391356e2f"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") },
                    { new Guid("0c06727f-07b5-4009-8e37-3115c1f64136"), "Anabelle_Mann@yahoo.com", false, new Guid("0c06727f-07b5-4009-8e37-3115c1f64136"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("0c4ac418-239c-453f-88ac-9b83045b6e25"), "Alena.Lehner@gmail.com", false, new Guid("0c4ac418-239c-453f-88ac-9b83045b6e25"), new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1") },
                    { new Guid("0d468a69-0294-43fa-a44e-2bdd29a962da"), "Neva68@yahoo.com", false, new Guid("0d468a69-0294-43fa-a44e-2bdd29a962da"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("0d89d791-3d70-4f6a-99a5-7dedd2fa161c"), "Dawson66@gmail.com", false, new Guid("0d89d791-3d70-4f6a-99a5-7dedd2fa161c"), new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2") },
                    { new Guid("0d8da9b6-b6fc-4ca4-be2a-8637ec2dd516"), "Sabina.Kreiger@hotmail.com", false, new Guid("0d8da9b6-b6fc-4ca4-be2a-8637ec2dd516"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("0dc235f5-3a04-4173-b06d-808afb8ac6f4"), "Annabel.Lynch@hotmail.com", false, new Guid("0dc235f5-3a04-4173-b06d-808afb8ac6f4"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("0e52c436-ee79-40a9-95aa-fd3c88143ae8"), "Damian_Toy@gmail.com", false, new Guid("0e52c436-ee79-40a9-95aa-fd3c88143ae8"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("0e5e6788-5179-4dab-ac6e-850c87c78e75"), "Darrion.Conroy@yahoo.com", false, new Guid("0e5e6788-5179-4dab-ac6e-850c87c78e75"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("0e97d76c-ed79-4079-9396-e62b80a5ad81"), "Kira.Christiansen@hotmail.com", false, new Guid("0e97d76c-ed79-4079-9396-e62b80a5ad81"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("0f8cd9ff-04e4-48e5-9857-f869128fb9f0"), "Bonnie76@hotmail.com", false, new Guid("0f8cd9ff-04e4-48e5-9857-f869128fb9f0"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("1041773c-c862-48dc-a967-09c1b641e4b4"), "Keagan41@gmail.com", false, new Guid("1041773c-c862-48dc-a967-09c1b641e4b4"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("104333e0-1c79-4c41-a1eb-89a43b03c227"), "Eldora.Davis@gmail.com", false, new Guid("104333e0-1c79-4c41-a1eb-89a43b03c227"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("10c27908-2847-4413-83d5-e416815704d8"), "Alberta.Homenick80@yahoo.com", false, new Guid("10c27908-2847-4413-83d5-e416815704d8"), new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a") },
                    { new Guid("10fd120d-7e92-4741-9e82-9fd229f70603"), "Raoul_Stanton61@hotmail.com", false, new Guid("10fd120d-7e92-4741-9e82-9fd229f70603"), new Guid("33d5b081-5c0f-4871-905f-631caba91848") },
                    { new Guid("111e85ac-e62c-413b-97c5-e58be2670532"), "Ismael.Reynolds@hotmail.com", false, new Guid("111e85ac-e62c-413b-97c5-e58be2670532"), new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119") },
                    { new Guid("115909f3-226b-4cc4-bedd-e69b1fed72d6"), "Dianna.Johns@gmail.com", false, new Guid("115909f3-226b-4cc4-bedd-e69b1fed72d6"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("11bc1bf7-52c7-4547-8ea6-e65a2022fb83"), "Kirk.Murray@hotmail.com", false, new Guid("11bc1bf7-52c7-4547-8ea6-e65a2022fb83"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("11e7a9de-7d9e-4572-ba69-83fa8e5f5e58"), "Lacey.Huel@yahoo.com", false, new Guid("11e7a9de-7d9e-4572-ba69-83fa8e5f5e58"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("12301aae-ad93-42cf-9e20-35304e33a082"), "Caden27@gmail.com", false, new Guid("12301aae-ad93-42cf-9e20-35304e33a082"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("129980ec-0d56-4aaa-b725-b1b7ad821862"), "William41@hotmail.com", false, new Guid("129980ec-0d56-4aaa-b725-b1b7ad821862"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("1306179e-3c2b-46a1-8996-c888ab4f660d"), "Mona.Kshlerin@hotmail.com", false, new Guid("1306179e-3c2b-46a1-8996-c888ab4f660d"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("130ae54b-5d37-470f-bbe8-0f46ce367737"), "Alexis.Kozey@yahoo.com", false, new Guid("130ae54b-5d37-470f-bbe8-0f46ce367737"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("1375809d-507b-4ece-9453-89f7b304e52b"), "Letitia.West51@hotmail.com", false, new Guid("1375809d-507b-4ece-9453-89f7b304e52b"), new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59") },
                    { new Guid("13d9d168-ce92-40f7-b46f-33d1acf3cd30"), "Lee.Crona@yahoo.com", false, new Guid("13d9d168-ce92-40f7-b46f-33d1acf3cd30"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("13e9dab4-3b38-41c2-928f-5850e3caa621"), "Warren46@hotmail.com", false, new Guid("13e9dab4-3b38-41c2-928f-5850e3caa621"), new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29") },
                    { new Guid("143c40b4-2695-43d8-a9dd-c7c9ae90a8bf"), "Clarissa_Farrell@gmail.com", false, new Guid("143c40b4-2695-43d8-a9dd-c7c9ae90a8bf"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("1525726e-5014-429e-a66f-ecdbe88d9b02"), "Americo.Turcotte79@hotmail.com", false, new Guid("1525726e-5014-429e-a66f-ecdbe88d9b02"), new Guid("f1038abe-cd17-40c4-844a-70a0ee863724") },
                    { new Guid("152d9b14-0af8-4294-82ac-2bb257ea1531"), "Robbie86@hotmail.com", false, new Guid("152d9b14-0af8-4294-82ac-2bb257ea1531"), new Guid("8b3ae855-3f1f-409d-8898-00767477ffae") },
                    { new Guid("15474192-fc21-46d0-bc71-2eaff0808ada"), "Jalon.Grant@gmail.com", false, new Guid("15474192-fc21-46d0-bc71-2eaff0808ada"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("157c7919-fa56-445d-bb73-e3e15b4b2fc0"), "Daryl.Dickens78@gmail.com", false, new Guid("157c7919-fa56-445d-bb73-e3e15b4b2fc0"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("15d9bd67-de7c-4c14-9cd0-0055d75cda6c"), "Destin30@hotmail.com", false, new Guid("15d9bd67-de7c-4c14-9cd0-0055d75cda6c"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("16168afd-5df5-4d46-9cd6-a6f7f2613928"), "Pearlie_Schuster@yahoo.com", false, new Guid("16168afd-5df5-4d46-9cd6-a6f7f2613928"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("16ac60b3-465a-4045-8e99-fa47f966c774"), "Clare.Spinka@yahoo.com", false, new Guid("16ac60b3-465a-4045-8e99-fa47f966c774"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("17096e12-990f-4132-87c5-5d37e8567d5f"), "Isadore.Koepp@hotmail.com", false, new Guid("17096e12-990f-4132-87c5-5d37e8567d5f"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("17a90c9d-0676-448e-8bd1-3ab9bc5ded1a"), "Nellie_Thiel76@hotmail.com", false, new Guid("17a90c9d-0676-448e-8bd1-3ab9bc5ded1a"), new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b") },
                    { new Guid("17b1ce78-dff3-4551-a000-1a83c26877b8"), "Cecile_Haag@hotmail.com", false, new Guid("17b1ce78-dff3-4551-a000-1a83c26877b8"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("181d188a-3e0d-4b76-8491-f09bdb6cd4dc"), "Jaron_Gerlach77@hotmail.com", false, new Guid("181d188a-3e0d-4b76-8491-f09bdb6cd4dc"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("184266b7-7f7e-4eab-983d-999d95cbac87"), "Jocelyn17@hotmail.com", false, new Guid("184266b7-7f7e-4eab-983d-999d95cbac87"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("1857b82c-de98-4e04-a0d4-7b09d4c85974"), "Mateo.Schoen@hotmail.com", false, new Guid("1857b82c-de98-4e04-a0d4-7b09d4c85974"), new Guid("314374c4-1bd7-4eda-8546-58617e464254") },
                    { new Guid("18ee9fdb-7c60-4b05-9ff1-7470e99643bc"), "Pearlie.Schamberger15@hotmail.com", false, new Guid("18ee9fdb-7c60-4b05-9ff1-7470e99643bc"), new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13") },
                    { new Guid("191bf118-b37c-4f28-ac9a-1521c5cb9cf4"), "Priscilla_Batz76@gmail.com", false, new Guid("191bf118-b37c-4f28-ac9a-1521c5cb9cf4"), new Guid("71725c06-aded-4994-8181-26d1683597c4") },
                    { new Guid("19674c66-1269-4d5a-b7ee-e46e187b1bad"), "Keyon.Rowe67@hotmail.com", false, new Guid("19674c66-1269-4d5a-b7ee-e46e187b1bad"), new Guid("48949002-3dd7-424b-b508-bb6644cad6fb") },
                    { new Guid("1974df59-9c33-4ce4-9b6b-970dcd365272"), "Willow.Hahn@gmail.com", false, new Guid("1974df59-9c33-4ce4-9b6b-970dcd365272"), new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46") },
                    { new Guid("198c6eb1-8452-4a53-882c-203c2120e2fe"), "Jaylin20@hotmail.com", false, new Guid("198c6eb1-8452-4a53-882c-203c2120e2fe"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("19ccd38c-10d8-48f8-8382-67f2b91d32bf"), "Lavern50@gmail.com", false, new Guid("19ccd38c-10d8-48f8-8382-67f2b91d32bf"), new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4") },
                    { new Guid("19e2e055-86f8-4776-ab03-c44110a25ed0"), "Joshuah.Deckow@gmail.com", false, new Guid("19e2e055-86f8-4776-ab03-c44110a25ed0"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("19f4ede5-82fc-4489-9438-91e21f80a85d"), "Jevon84@hotmail.com", false, new Guid("19f4ede5-82fc-4489-9438-91e21f80a85d"), new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5") },
                    { new Guid("1af54e75-a454-4097-9425-4884b1cd25b6"), "Torrance.Weber75@gmail.com", false, new Guid("1af54e75-a454-4097-9425-4884b1cd25b6"), new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6") },
                    { new Guid("1bc972ad-45ef-459f-b683-caa2382da07a"), "Javon66@hotmail.com", false, new Guid("1bc972ad-45ef-459f-b683-caa2382da07a"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("1c175790-a439-45e3-adda-4700a04c2163"), "Gardner_Pouros@hotmail.com", false, new Guid("1c175790-a439-45e3-adda-4700a04c2163"), new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb") },
                    { new Guid("1dbebebc-0155-47a9-9a61-5cf432995c7b"), "Sadye97@hotmail.com", false, new Guid("1dbebebc-0155-47a9-9a61-5cf432995c7b"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("1df9e0fe-92be-4840-bfeb-920e29aafe3f"), "Brandi.Runolfsson@gmail.com", false, new Guid("1df9e0fe-92be-4840-bfeb-920e29aafe3f"), new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9") },
                    { new Guid("1e8f30ce-999f-4423-99cb-76cc4805918b"), "Eleonore_Pollich41@gmail.com", false, new Guid("1e8f30ce-999f-4423-99cb-76cc4805918b"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") },
                    { new Guid("1eb9e66a-e133-4986-a8d4-62f64880b4c6"), "Brain_Ernser@yahoo.com", false, new Guid("1eb9e66a-e133-4986-a8d4-62f64880b4c6"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("1f239ca5-af41-43d0-8565-eb8d7ef596da"), "Johnny_Kohler94@gmail.com", false, new Guid("1f239ca5-af41-43d0-8565-eb8d7ef596da"), new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63") },
                    { new Guid("1fcd41ed-f0f2-4358-9c41-b8c697a87185"), "Ludwig.Boehm@gmail.com", false, new Guid("1fcd41ed-f0f2-4358-9c41-b8c697a87185"), new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5") },
                    { new Guid("1fd0daa7-256e-4921-8f32-0cd60456d637"), "Joannie69@gmail.com", false, new Guid("1fd0daa7-256e-4921-8f32-0cd60456d637"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("211ed3ec-f435-4e50-944a-694830bcd5ad"), "Shaina99@gmail.com", false, new Guid("211ed3ec-f435-4e50-944a-694830bcd5ad"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("21d6d61b-f036-4a5e-8d24-7922d27fc403"), "Jaunita69@hotmail.com", false, new Guid("21d6d61b-f036-4a5e-8d24-7922d27fc403"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("220b489e-43d2-42ca-8237-41f1eb008b4d"), "Mitchell_Walker99@hotmail.com", false, new Guid("220b489e-43d2-42ca-8237-41f1eb008b4d"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("2215e491-20a3-409c-8541-60dd9532a5ad"), "Ivy51@gmail.com", false, new Guid("2215e491-20a3-409c-8541-60dd9532a5ad"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("2224d190-878b-45b6-81bf-e5af9722dcde"), "Otto_Pacocha40@yahoo.com", false, new Guid("2224d190-878b-45b6-81bf-e5af9722dcde"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("226cd75a-9812-47ff-b9e4-9aace5eb6fe1"), "Edwina.Kunde86@hotmail.com", false, new Guid("226cd75a-9812-47ff-b9e4-9aace5eb6fe1"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("22b95271-37b9-4c83-92c0-e3d872c524f6"), "Yvonne_Crooks@hotmail.com", false, new Guid("22b95271-37b9-4c83-92c0-e3d872c524f6"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("22fca093-52f0-44e9-91c3-964c6b265746"), "Chaz.Crooks57@yahoo.com", false, new Guid("22fca093-52f0-44e9-91c3-964c6b265746"), new Guid("e5acadcd-43bb-4225-9367-f562e86197e5") },
                    { new Guid("230a6f89-5b84-4a0c-854d-2c6c154f40e1"), "Ernesto95@hotmail.com", false, new Guid("230a6f89-5b84-4a0c-854d-2c6c154f40e1"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("2328801f-7636-4810-bd12-9e02150a333c"), "Valentina.Sawayn@yahoo.com", false, new Guid("2328801f-7636-4810-bd12-9e02150a333c"), new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674") },
                    { new Guid("2355ead8-fa9a-4713-a781-e60f8e9c54f0"), "Sherwood37@gmail.com", false, new Guid("2355ead8-fa9a-4713-a781-e60f8e9c54f0"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("2393f7b8-4f55-4825-ab8f-5aecca59eee5"), "Caroline.Dietrich@yahoo.com", false, new Guid("2393f7b8-4f55-4825-ab8f-5aecca59eee5"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("23a6b6cc-aa99-4f54-84c5-5004e5a504fb"), "Eduardo31@yahoo.com", false, new Guid("23a6b6cc-aa99-4f54-84c5-5004e5a504fb"), new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5") },
                    { new Guid("23ea662b-c9d4-4704-97fd-dc906b7679cf"), "Stevie34@gmail.com", false, new Guid("23ea662b-c9d4-4704-97fd-dc906b7679cf"), new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb") },
                    { new Guid("2415e713-a282-4a41-b3f8-ac3554c2bdcf"), "Matilde_McLaughlin41@yahoo.com", false, new Guid("2415e713-a282-4a41-b3f8-ac3554c2bdcf"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("24280463-c603-4e61-a634-6e79261f53f1"), "Horacio_Graham63@hotmail.com", false, new Guid("24280463-c603-4e61-a634-6e79261f53f1"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("251f7c24-1c47-416b-9cdd-74eeee352ac8"), "Dena.Murphy53@gmail.com", false, new Guid("251f7c24-1c47-416b-9cdd-74eeee352ac8"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("256a81d5-7e3c-4a92-98ac-3a4848cbe870"), "Tanner_Connelly@yahoo.com", false, new Guid("256a81d5-7e3c-4a92-98ac-3a4848cbe870"), new Guid("d21f18d0-79a0-4851-976c-b989e790eac0") },
                    { new Guid("259d2682-fadf-41f3-a521-ed8e7601e7e8"), "Chauncey62@yahoo.com", false, new Guid("259d2682-fadf-41f3-a521-ed8e7601e7e8"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("2644ad2b-4836-4eb3-9951-6582b623f560"), "Ivy.Considine@yahoo.com", false, new Guid("2644ad2b-4836-4eb3-9951-6582b623f560"), new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5") },
                    { new Guid("268d75c9-add7-4f46-98f5-14eb0b72aed1"), "Hailee41@hotmail.com", false, new Guid("268d75c9-add7-4f46-98f5-14eb0b72aed1"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("26d838b3-dfe7-481f-9ca2-14ae3208c325"), "Tristin.Davis@hotmail.com", false, new Guid("26d838b3-dfe7-481f-9ca2-14ae3208c325"), new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0") },
                    { new Guid("271d78c2-d09e-42cf-b681-cd438e4412f4"), "Aubrey81@hotmail.com", false, new Guid("271d78c2-d09e-42cf-b681-cd438e4412f4"), new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13") },
                    { new Guid("27766309-5070-4af8-bb18-16b95ea3128e"), "Javonte2@hotmail.com", false, new Guid("27766309-5070-4af8-bb18-16b95ea3128e"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("27f50435-e054-4164-ad13-19306dce3a99"), "Bennie3@yahoo.com", false, new Guid("27f50435-e054-4164-ad13-19306dce3a99"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("296786d5-671f-4e8d-9d6d-240cc8351313"), "Herta55@gmail.com", false, new Guid("296786d5-671f-4e8d-9d6d-240cc8351313"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("296f4697-c4f1-4caa-ab98-1df9b7b4349b"), "Luz.Baumbach@yahoo.com", false, new Guid("296f4697-c4f1-4caa-ab98-1df9b7b4349b"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("2a1caa16-d7c0-49dc-8280-47e0e8169b67"), "Shanon_Kunde@gmail.com", false, new Guid("2a1caa16-d7c0-49dc-8280-47e0e8169b67"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("2ab778fb-9ba8-4207-b405-89ac5e473afb"), "Kristofer_Hamill76@gmail.com", false, new Guid("2ab778fb-9ba8-4207-b405-89ac5e473afb"), new Guid("54544805-6149-40a0-a366-c2fb8f55975f") },
                    { new Guid("2b99349c-5483-421f-b643-e22f567e1122"), "Daisy_Funk@yahoo.com", false, new Guid("2b99349c-5483-421f-b643-e22f567e1122"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("2be94e9c-4bac-482c-b385-306d827be956"), "Margarette64@yahoo.com", false, new Guid("2be94e9c-4bac-482c-b385-306d827be956"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("2c42d351-800d-4512-a8c5-33a0b5339855"), "Eva_Breitenberg95@gmail.com", false, new Guid("2c42d351-800d-4512-a8c5-33a0b5339855"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("2c51d84c-69fe-4c78-8dfc-262dd3356aa3"), "Darion_OConner42@yahoo.com", false, new Guid("2c51d84c-69fe-4c78-8dfc-262dd3356aa3"), new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd") },
                    { new Guid("2c9c07fe-1fa3-492c-bdfb-5ab06d1224ec"), "Lelah_DAmore69@hotmail.com", false, new Guid("2c9c07fe-1fa3-492c-bdfb-5ab06d1224ec"), new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674") },
                    { new Guid("2c9df44d-82ff-435b-bfd7-b06833338fc3"), "Brando_Wintheiser95@gmail.com", false, new Guid("2c9df44d-82ff-435b-bfd7-b06833338fc3"), new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574") },
                    { new Guid("2cb6a6fc-5bcb-4302-bb0d-68d86c27ed15"), "Alfred13@yahoo.com", false, new Guid("2cb6a6fc-5bcb-4302-bb0d-68d86c27ed15"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("2ccf8ec7-61ad-4be4-b20b-c277338c14ba"), "Lysanne_Thiel87@gmail.com", false, new Guid("2ccf8ec7-61ad-4be4-b20b-c277338c14ba"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("2d9229e6-4e1f-4d96-9ee3-e27114a9a3fa"), "Wilfredo7@hotmail.com", false, new Guid("2d9229e6-4e1f-4d96-9ee3-e27114a9a3fa"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("2da661b9-b726-4cee-88c0-af390af3f37e"), "Braden.Bauch71@hotmail.com", false, new Guid("2da661b9-b726-4cee-88c0-af390af3f37e"), new Guid("d21f18d0-79a0-4851-976c-b989e790eac0") },
                    { new Guid("2da8d0e6-fbf0-4f5a-a198-a5d8ccf0c13c"), "Israel_Blick@yahoo.com", false, new Guid("2da8d0e6-fbf0-4f5a-a198-a5d8ccf0c13c"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("2e32c111-d778-4a96-b04c-557753745600"), "Jordan.Yundt41@yahoo.com", false, new Guid("2e32c111-d778-4a96-b04c-557753745600"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("2e85b2cb-fb61-45c6-8f4f-ef1b9e06a58a"), "Coy_Altenwerth@gmail.com", false, new Guid("2e85b2cb-fb61-45c6-8f4f-ef1b9e06a58a"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("2eb212e4-8899-48f7-adf9-41b97d180c80"), "Natasha.Gaylord80@hotmail.com", false, new Guid("2eb212e4-8899-48f7-adf9-41b97d180c80"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("2ecf0ea5-995a-4c0f-8c59-5aa33f97a5b3"), "Evie_Jacobs41@gmail.com", false, new Guid("2ecf0ea5-995a-4c0f-8c59-5aa33f97a5b3"), new Guid("83c8f958-a3f1-448d-bad0-048533827e0e") },
                    { new Guid("2ecf554e-e166-4550-961f-e0442b200e17"), "Ezekiel.Renner@hotmail.com", false, new Guid("2ecf554e-e166-4550-961f-e0442b200e17"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("2f0a85d5-de93-4830-9720-49dcd130a09c"), "Magnus_Kuhn12@gmail.com", false, new Guid("2f0a85d5-de93-4830-9720-49dcd130a09c"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("2f4a8434-723c-48de-ab25-60511b5aaf74"), "Jerome.Metz88@hotmail.com", false, new Guid("2f4a8434-723c-48de-ab25-60511b5aaf74"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("2f61e298-5ed0-4f7c-8fa1-03cd93206cec"), "Eli_Ernser54@gmail.com", false, new Guid("2f61e298-5ed0-4f7c-8fa1-03cd93206cec"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("2f8252c9-fc0b-49eb-84b5-b8f98221523b"), "Marietta_Bernier@yahoo.com", false, new Guid("2f8252c9-fc0b-49eb-84b5-b8f98221523b"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("2f977c1b-c3ea-46d6-8994-c4306fdb3f13"), "Noemie43@gmail.com", false, new Guid("2f977c1b-c3ea-46d6-8994-c4306fdb3f13"), new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1") },
                    { new Guid("3052511c-1130-448e-bdac-46ecba2f49a7"), "Gage72@yahoo.com", false, new Guid("3052511c-1130-448e-bdac-46ecba2f49a7"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("3076fb4d-a75e-49a4-838d-28af052e5dde"), "Stevie5@gmail.com", false, new Guid("3076fb4d-a75e-49a4-838d-28af052e5dde"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("3081e163-5be2-4292-97d9-2b6f281a4283"), "Darron.McCullough@gmail.com", false, new Guid("3081e163-5be2-4292-97d9-2b6f281a4283"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("3137f29a-b9c7-45ac-9a41-17c440d804ce"), "Noble83@hotmail.com", false, new Guid("3137f29a-b9c7-45ac-9a41-17c440d804ce"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("317b954e-7156-4aaf-8ac7-723a42616edd"), "Lauriane_Gerlach22@hotmail.com", false, new Guid("317b954e-7156-4aaf-8ac7-723a42616edd"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("322d8f7f-dcf9-4f09-94f3-996826dec9f7"), "Melvin_Ledner@hotmail.com", false, new Guid("322d8f7f-dcf9-4f09-94f3-996826dec9f7"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("329878b1-c767-4e42-9a98-df2b71f7defa"), "Kurt45@gmail.com", false, new Guid("329878b1-c767-4e42-9a98-df2b71f7defa"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("32be576a-1d54-42f9-b8fd-9d3efd7327a8"), "Zackary_Skiles40@yahoo.com", false, new Guid("32be576a-1d54-42f9-b8fd-9d3efd7327a8"), new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("32f100f9-f2b6-4783-b2e0-16710949281e"), "Amelia.Bechtelar23@gmail.com", false, new Guid("32f100f9-f2b6-4783-b2e0-16710949281e"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("33df0cb8-2f0f-4da5-93dd-10f535268786"), "Kamryn65@gmail.com", false, new Guid("33df0cb8-2f0f-4da5-93dd-10f535268786"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("33f0d159-fcae-468b-9edf-def5eb133758"), "Tierra34@hotmail.com", false, new Guid("33f0d159-fcae-468b-9edf-def5eb133758"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("3406f679-c72a-4d2d-b470-93bf8d1b2d5f"), "Josefina37@hotmail.com", false, new Guid("3406f679-c72a-4d2d-b470-93bf8d1b2d5f"), new Guid("12656ae7-3922-41ca-b159-f79b439a354c") },
                    { new Guid("34878b24-941a-428f-8896-f83626eb891c"), "Chanel_Renner89@hotmail.com", false, new Guid("34878b24-941a-428f-8896-f83626eb891c"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("34981252-c859-40ea-8050-94dbd07f62b9"), "Austin31@gmail.com", false, new Guid("34981252-c859-40ea-8050-94dbd07f62b9"), new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed") },
                    { new Guid("3534f811-b827-466f-a079-b5e8a060580e"), "Dedric82@yahoo.com", false, new Guid("3534f811-b827-466f-a079-b5e8a060580e"), new Guid("69170f92-b4b7-4c26-be44-5255d738fb20") },
                    { new Guid("357ab507-69bc-4de3-9e2a-8e48dae3866d"), "Emmalee_Rowe5@gmail.com", false, new Guid("357ab507-69bc-4de3-9e2a-8e48dae3866d"), new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305") },
                    { new Guid("35caedfd-6849-4683-846b-88a790c0862e"), "Clyde.Mohr@gmail.com", false, new Guid("35caedfd-6849-4683-846b-88a790c0862e"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0") },
                    { new Guid("3607f889-52c8-405b-98cb-2f02d9394e0b"), "Vicky_Armstrong@hotmail.com", false, new Guid("3607f889-52c8-405b-98cb-2f02d9394e0b"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("36427112-fe1b-42fd-940c-24f44dd4e61d"), "Zane89@hotmail.com", false, new Guid("36427112-fe1b-42fd-940c-24f44dd4e61d"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("364e20ea-50a7-4797-87dc-63e3c9768859"), "Enoch.Terry@gmail.com", false, new Guid("364e20ea-50a7-4797-87dc-63e3c9768859"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("3673b046-3263-4e66-a73c-29dae51a4298"), "Meaghan.Daniel34@hotmail.com", false, new Guid("3673b046-3263-4e66-a73c-29dae51a4298"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("36953a7f-e95d-47dd-b501-fe893f49de8f"), "Rosie.Boehm@hotmail.com", false, new Guid("36953a7f-e95d-47dd-b501-fe893f49de8f"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("36aff2ea-36f8-4d29-99c9-db5446b115c1"), "Raquel.Hoppe87@gmail.com", false, new Guid("36aff2ea-36f8-4d29-99c9-db5446b115c1"), new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b") },
                    { new Guid("371b8023-c57a-4c60-9b14-c419e6b6cf6c"), "Linnea_Dickens19@yahoo.com", false, new Guid("371b8023-c57a-4c60-9b14-c419e6b6cf6c"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("3764d5d6-c491-4343-938d-f4746cca35f3"), "Mariano_Kreiger24@gmail.com", false, new Guid("3764d5d6-c491-4343-938d-f4746cca35f3"), new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2") },
                    { new Guid("3826cc39-1265-45f6-b472-eec2a1969c11"), "Marjorie_Block@hotmail.com", false, new Guid("3826cc39-1265-45f6-b472-eec2a1969c11"), new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b") },
                    { new Guid("3834d115-ce28-4197-bce2-014abf6ff570"), "Armando27@yahoo.com", false, new Guid("3834d115-ce28-4197-bce2-014abf6ff570"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("38d70670-eabb-485a-aeb2-b4ec8e380bf9"), "Ursula_Jenkins@yahoo.com", false, new Guid("38d70670-eabb-485a-aeb2-b4ec8e380bf9"), new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5") },
                    { new Guid("38f00f66-929a-46fc-a89e-600dcb186b92"), "Diana_Turner70@gmail.com", false, new Guid("38f00f66-929a-46fc-a89e-600dcb186b92"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("3922c31f-6d9f-47d1-89eb-ee538de999a0"), "Alia90@yahoo.com", false, new Guid("3922c31f-6d9f-47d1-89eb-ee538de999a0"), new Guid("35b6c210-2256-41cd-af8e-e815527e0a84") },
                    { new Guid("392765f9-d736-4073-bfa3-65d3169c48ee"), "Rosamond_Fisher@yahoo.com", false, new Guid("392765f9-d736-4073-bfa3-65d3169c48ee"), new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7") },
                    { new Guid("39c7894e-836a-44de-949d-c29225faab41"), "Vesta53@yahoo.com", false, new Guid("39c7894e-836a-44de-949d-c29225faab41"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("39d7e11a-6aa0-41cb-b073-2396ec9e1022"), "Chad32@gmail.com", false, new Guid("39d7e11a-6aa0-41cb-b073-2396ec9e1022"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("39f197d9-3669-435a-86fe-2f9a0b7972a7"), "Lori.Howell@yahoo.com", false, new Guid("39f197d9-3669-435a-86fe-2f9a0b7972a7"), new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33") },
                    { new Guid("3a279a4d-ad8e-4124-ab50-f05e15315150"), "Haley.Kuphal@gmail.com", false, new Guid("3a279a4d-ad8e-4124-ab50-f05e15315150"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("3aaa927f-c0c2-4740-8c48-0cdd522e4046"), "Addison1@hotmail.com", false, new Guid("3aaa927f-c0c2-4740-8c48-0cdd522e4046"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("3b4d89f6-1372-4bd9-8d5c-dc2e0c6720a8"), "Rozella94@hotmail.com", false, new Guid("3b4d89f6-1372-4bd9-8d5c-dc2e0c6720a8"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("3baf92d1-39cd-4dac-a02f-da1e93ff3014"), "Alicia68@gmail.com", false, new Guid("3baf92d1-39cd-4dac-a02f-da1e93ff3014"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("3bc83c18-3c2e-44f3-adbc-c800ba664b5a"), "Cornell74@yahoo.com", false, new Guid("3bc83c18-3c2e-44f3-adbc-c800ba664b5a"), new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861") },
                    { new Guid("3c19b88d-8448-4fad-9840-c715f038c625"), "Destin_Shields@gmail.com", false, new Guid("3c19b88d-8448-4fad-9840-c715f038c625"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("3c5ea2fe-6ddb-4937-b22d-f2f75e51864e"), "Irma.Champlin61@hotmail.com", false, new Guid("3c5ea2fe-6ddb-4937-b22d-f2f75e51864e"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("3c802217-fbf4-43e1-a34d-95bc9ece77f3"), "Leland_Bailey61@yahoo.com", false, new Guid("3c802217-fbf4-43e1-a34d-95bc9ece77f3"), new Guid("cfddcc04-5205-447d-9799-6d1945c391b4") },
                    { new Guid("3c9f5bb0-7080-43ea-b810-1da813fc48da"), "Jefferey_Volkman72@yahoo.com", false, new Guid("3c9f5bb0-7080-43ea-b810-1da813fc48da"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("3d081c33-3c17-4fc6-9105-c823ab0db948"), "Katelyn_Stoltenberg36@yahoo.com", false, new Guid("3d081c33-3c17-4fc6-9105-c823ab0db948"), new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a") },
                    { new Guid("3d5b32df-3689-40ab-8c49-d1b97015e883"), "Willie.Kub63@yahoo.com", false, new Guid("3d5b32df-3689-40ab-8c49-d1b97015e883"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("3d73692f-1653-4b14-aef4-24e322e05f13"), "Addison49@hotmail.com", false, new Guid("3d73692f-1653-4b14-aef4-24e322e05f13"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("3d8cb109-a895-4275-a460-91ec14646074"), "Avis83@gmail.com", false, new Guid("3d8cb109-a895-4275-a460-91ec14646074"), new Guid("f1038abe-cd17-40c4-844a-70a0ee863724") },
                    { new Guid("3e451e52-394c-469c-988b-c35bd88ef20a"), "Leonor.Daniel0@yahoo.com", false, new Guid("3e451e52-394c-469c-988b-c35bd88ef20a"), new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("3e6af975-05fe-49ba-a1fb-5c960be5d23d"), "Priscilla22@hotmail.com", false, new Guid("3e6af975-05fe-49ba-a1fb-5c960be5d23d"), new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5") },
                    { new Guid("4001ee24-b244-4854-8f16-f783e8773908"), "Eliane_Yundt37@gmail.com", false, new Guid("4001ee24-b244-4854-8f16-f783e8773908"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("4085c1c5-390d-4edc-900e-704bf0acc7d8"), "Meredith79@gmail.com", false, new Guid("4085c1c5-390d-4edc-900e-704bf0acc7d8"), new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e") },
                    { new Guid("40c09e6f-1c97-4659-b2cd-e41f070a6f2a"), "Berry34@gmail.com", false, new Guid("40c09e6f-1c97-4659-b2cd-e41f070a6f2a"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("40c32a16-0221-454d-9926-5264fd0ee1e7"), "Vergie.Miller56@yahoo.com", false, new Guid("40c32a16-0221-454d-9926-5264fd0ee1e7"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("40f5ac90-d41f-4b0c-aacf-f3c8097096d4"), "Shane.Cruickshank27@yahoo.com", false, new Guid("40f5ac90-d41f-4b0c-aacf-f3c8097096d4"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("416fd422-4da4-4bd8-af60-63c467a93ab7"), "Garfield99@yahoo.com", false, new Guid("416fd422-4da4-4bd8-af60-63c467a93ab7"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("42417441-8a19-42ed-96bb-407a200924ea"), "Queenie69@yahoo.com", false, new Guid("42417441-8a19-42ed-96bb-407a200924ea"), new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b") },
                    { new Guid("4253929b-606f-4aa2-bec8-45188ca66c68"), "Suzanne.Collins87@hotmail.com", false, new Guid("4253929b-606f-4aa2-bec8-45188ca66c68"), new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3") },
                    { new Guid("42c14c09-a79f-4384-92f6-77be9b64c096"), "Glenda44@yahoo.com", false, new Guid("42c14c09-a79f-4384-92f6-77be9b64c096"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("43ae92ad-dec4-4dbd-acb3-a1a0a76af9f5"), "Brett.Balistreri@hotmail.com", false, new Guid("43ae92ad-dec4-4dbd-acb3-a1a0a76af9f5"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("449a9e7e-4d7c-4e24-8ff4-3d7cb3604fa5"), "Letha.Lemke@hotmail.com", false, new Guid("449a9e7e-4d7c-4e24-8ff4-3d7cb3604fa5"), new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075") },
                    { new Guid("44d844ec-981c-42dd-9feb-1b18ac83d7db"), "Alek98@hotmail.com", false, new Guid("44d844ec-981c-42dd-9feb-1b18ac83d7db"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("44eae5e3-47b4-4cf8-a98f-64fd173e889b"), "Chesley19@hotmail.com", false, new Guid("44eae5e3-47b4-4cf8-a98f-64fd173e889b"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("45877561-8035-4bde-876d-0cbeac4adca3"), "Earline.Bogan@hotmail.com", false, new Guid("45877561-8035-4bde-876d-0cbeac4adca3"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("45ab5ee8-a850-49fd-b95b-3f9a33ba9d1b"), "Montana_Stamm@gmail.com", false, new Guid("45ab5ee8-a850-49fd-b95b-3f9a33ba9d1b"), new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac") },
                    { new Guid("468b9096-cf6e-4562-80e4-dfe0aa9ae53c"), "Burnice38@gmail.com", false, new Guid("468b9096-cf6e-4562-80e4-dfe0aa9ae53c"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("469cf1d1-aa7e-462e-868f-d4f9ba327fee"), "Kim.Pouros@gmail.com", false, new Guid("469cf1d1-aa7e-462e-868f-d4f9ba327fee"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("47300ca2-387c-4fed-9f0e-c31d8b94d660"), "Wilber.Hackett13@hotmail.com", false, new Guid("47300ca2-387c-4fed-9f0e-c31d8b94d660"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("47d40106-bf80-414f-95ff-5a90b7990966"), "Aidan95@yahoo.com", false, new Guid("47d40106-bf80-414f-95ff-5a90b7990966"), new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6") },
                    { new Guid("47d92090-5021-4feb-ae28-6d563916d090"), "Leatha_Grimes@yahoo.com", false, new Guid("47d92090-5021-4feb-ae28-6d563916d090"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("47fa355a-1181-4ed2-b4ef-d0806c43b1b7"), "Alverta63@hotmail.com", false, new Guid("47fa355a-1181-4ed2-b4ef-d0806c43b1b7"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("48d1d45a-18a2-4bfc-8507-7dc0b4b53631"), "Art59@hotmail.com", false, new Guid("48d1d45a-18a2-4bfc-8507-7dc0b4b53631"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("48de3174-e894-4fd3-85f7-0ecc55d14efb"), "Sam_Denesik54@gmail.com", false, new Guid("48de3174-e894-4fd3-85f7-0ecc55d14efb"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("490db4d8-24f6-4426-9d8d-e2a6efc9616f"), "Faye_Goodwin78@hotmail.com", false, new Guid("490db4d8-24f6-4426-9d8d-e2a6efc9616f"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("49f38eb5-a020-4c5b-8b95-be6b10ae01b0"), "Morton.Reinger5@hotmail.com", false, new Guid("49f38eb5-a020-4c5b-8b95-be6b10ae01b0"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("4a1ff9a9-ef67-4aae-be8e-0461627f095c"), "Tito_Adams37@hotmail.com", false, new Guid("4a1ff9a9-ef67-4aae-be8e-0461627f095c"), new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2") },
                    { new Guid("4af5ad23-2de0-4ec4-94fe-a732957f407c"), "Connie_Langworth35@gmail.com", false, new Guid("4af5ad23-2de0-4ec4-94fe-a732957f407c"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("4be39da9-cf91-4910-9393-d7ff024bfcb4"), "Hank_Becker43@yahoo.com", false, new Guid("4be39da9-cf91-4910-9393-d7ff024bfcb4"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("4c2bdab2-b3ec-4572-905a-8a5e7d1f9cbb"), "Trenton83@hotmail.com", false, new Guid("4c2bdab2-b3ec-4572-905a-8a5e7d1f9cbb"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("4c81b687-1aec-498a-ad15-37016ad2ce4e"), "Lizzie_Bednar28@hotmail.com", false, new Guid("4c81b687-1aec-498a-ad15-37016ad2ce4e"), new Guid("33d5b081-5c0f-4871-905f-631caba91848") },
                    { new Guid("4d7157c4-96d3-4348-8383-a6accef9bf63"), "Arno57@yahoo.com", false, new Guid("4d7157c4-96d3-4348-8383-a6accef9bf63"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("4d797569-559b-4452-bdfd-d39e32a0d935"), "Aniyah.Bernhard8@yahoo.com", false, new Guid("4d797569-559b-4452-bdfd-d39e32a0d935"), new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7") },
                    { new Guid("4db1f89b-b3f1-481f-9fb2-ec74b47b6f0a"), "Deshawn_Barrows4@hotmail.com", false, new Guid("4db1f89b-b3f1-481f-9fb2-ec74b47b6f0a"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("4e063bbb-dc6b-48b9-b200-13cbf2d1d269"), "Brando25@gmail.com", false, new Guid("4e063bbb-dc6b-48b9-b200-13cbf2d1d269"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("4e139e67-b572-4499-a03b-d3f040befc2b"), "Rodrigo_Nicolas@yahoo.com", false, new Guid("4e139e67-b572-4499-a03b-d3f040befc2b"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("4e8aafb6-e331-416a-a163-ab70dce3b882"), "Earnestine86@hotmail.com", false, new Guid("4e8aafb6-e331-416a-a163-ab70dce3b882"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("4ed8d96b-9496-495b-b5f9-4d92d51fc3f4"), "Davon.Cronin@hotmail.com", false, new Guid("4ed8d96b-9496-495b-b5f9-4d92d51fc3f4"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("4f4aa594-39a8-4b87-9211-5771fd1881c5"), "Aaron9@gmail.com", false, new Guid("4f4aa594-39a8-4b87-9211-5771fd1881c5"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("4fc71371-a351-4293-8d75-cb9d170560cc"), "Bill85@yahoo.com", false, new Guid("4fc71371-a351-4293-8d75-cb9d170560cc"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("4fd8a0c0-36ef-40aa-92e0-4ebaf1e956e9"), "Jerry.Cassin66@hotmail.com", false, new Guid("4fd8a0c0-36ef-40aa-92e0-4ebaf1e956e9"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("50282d04-c79b-4f86-8f02-e1fd4bc1f4a4"), "Howell61@yahoo.com", false, new Guid("50282d04-c79b-4f86-8f02-e1fd4bc1f4a4"), new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4") },
                    { new Guid("505f3ed9-e855-47c0-ad7e-10209c47fe45"), "Carlotta27@hotmail.com", false, new Guid("505f3ed9-e855-47c0-ad7e-10209c47fe45"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("506657c9-f989-4161-bf1a-c6a3fd87cc07"), "Melvina.Hettinger27@yahoo.com", false, new Guid("506657c9-f989-4161-bf1a-c6a3fd87cc07"), new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("5118f13f-d88f-4f14-9510-8ec7fff616eb"), "Kamren.Little47@hotmail.com", false, new Guid("5118f13f-d88f-4f14-9510-8ec7fff616eb"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("513cb9e9-c6cc-40fd-982d-4bd007aec15f"), "Electa_Purdy73@hotmail.com", false, new Guid("513cb9e9-c6cc-40fd-982d-4bd007aec15f"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("51a89ffa-0cff-4b43-a733-e2f4debed2eb"), "Arden.Nitzsche@yahoo.com", false, new Guid("51a89ffa-0cff-4b43-a733-e2f4debed2eb"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("51e67ad7-996b-4fc0-987f-b75f007bdc79"), "Hilda_Hartmann77@gmail.com", false, new Guid("51e67ad7-996b-4fc0-987f-b75f007bdc79"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("520d6a17-6c7b-4556-a5db-8dd04e67e54a"), "Lola4@hotmail.com", false, new Guid("520d6a17-6c7b-4556-a5db-8dd04e67e54a"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("5215f4d1-28a1-4549-a143-b63d27d8ebb3"), "Mikel.Kemmer@gmail.com", false, new Guid("5215f4d1-28a1-4549-a143-b63d27d8ebb3"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("525661a0-2e60-485d-a15e-026ac598e849"), "Sigrid75@gmail.com", false, new Guid("525661a0-2e60-485d-a15e-026ac598e849"), new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65") },
                    { new Guid("527b862e-0cb8-41aa-9611-5aea3513dad4"), "Sister_Jakubowski69@gmail.com", false, new Guid("527b862e-0cb8-41aa-9611-5aea3513dad4"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("5282f36d-a9e8-48c7-95c8-52e16af6d356"), "Ayana.Wiegand@hotmail.com", false, new Guid("5282f36d-a9e8-48c7-95c8-52e16af6d356"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("529ec85f-1dd4-43a8-8813-8447ea9f24c3"), "Alia35@gmail.com", false, new Guid("529ec85f-1dd4-43a8-8813-8447ea9f24c3"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("52b41394-0084-4136-844b-329295a982fb"), "Keyshawn32@hotmail.com", false, new Guid("52b41394-0084-4136-844b-329295a982fb"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("52c37f13-1410-4cef-99c5-bc966ab696bc"), "Winifred_Cremin70@hotmail.com", false, new Guid("52c37f13-1410-4cef-99c5-bc966ab696bc"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("52fbe183-a675-4330-8e5d-d171af9d8ec0"), "Shanelle67@yahoo.com", false, new Guid("52fbe183-a675-4330-8e5d-d171af9d8ec0"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("5301ff35-ad62-4f17-8b89-d92d5daed5bb"), "Lorine65@hotmail.com", false, new Guid("5301ff35-ad62-4f17-8b89-d92d5daed5bb"), new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6") },
                    { new Guid("5336c62a-4ed2-4c77-972e-021f250f5910"), "Tiara.Hintz@yahoo.com", false, new Guid("5336c62a-4ed2-4c77-972e-021f250f5910"), new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221") },
                    { new Guid("5361b5ea-b43a-40f3-882f-3f4519e4803e"), "Wiley.Schuster18@yahoo.com", false, new Guid("5361b5ea-b43a-40f3-882f-3f4519e4803e"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("53a6a324-dd4b-443c-a3c1-891d667dac8c"), "Tracey_White88@gmail.com", false, new Guid("53a6a324-dd4b-443c-a3c1-891d667dac8c"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("53cec685-391a-49fb-a9ee-c050a92afc4e"), "Nolan.Quigley80@yahoo.com", false, new Guid("53cec685-391a-49fb-a9ee-c050a92afc4e"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("53e1f0bb-79aa-4a97-bc88-adbf4e52a8f1"), "Claire89@yahoo.com", false, new Guid("53e1f0bb-79aa-4a97-bc88-adbf4e52a8f1"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("5431697f-2da5-4af5-a593-19e32a5c8f66"), "Melyna.Lynch89@yahoo.com", false, new Guid("5431697f-2da5-4af5-a593-19e32a5c8f66"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("55d9bf5d-13a2-4420-a0f8-630fe04c7fbf"), "Carroll_Blick61@yahoo.com", false, new Guid("55d9bf5d-13a2-4420-a0f8-630fe04c7fbf"), new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa") },
                    { new Guid("55db6f10-03ad-4b57-b1ac-516929427057"), "Verlie_Walker@hotmail.com", false, new Guid("55db6f10-03ad-4b57-b1ac-516929427057"), new Guid("0823436c-27ad-4402-b5e2-b17efa08505e") },
                    { new Guid("5674786f-7b6b-436b-8dee-ec2e8731f3f1"), "Katrina.OConnell@gmail.com", false, new Guid("5674786f-7b6b-436b-8dee-ec2e8731f3f1"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("56780812-eea4-4e42-a718-eb8ecb198fa8"), "Violette_Tremblay65@yahoo.com", false, new Guid("56780812-eea4-4e42-a718-eb8ecb198fa8"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("567e52ea-f153-483f-9ce9-a6156ecc3d0a"), "Jayden35@hotmail.com", false, new Guid("567e52ea-f153-483f-9ce9-a6156ecc3d0a"), new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c") },
                    { new Guid("567eac1a-abaa-4319-a035-a77b5bbe8561"), "Leta_Steuber@gmail.com", false, new Guid("567eac1a-abaa-4319-a035-a77b5bbe8561"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("5690d800-e4a3-4dbb-b8cf-90a391e5a1b2"), "Jimmie_Glover@hotmail.com", false, new Guid("5690d800-e4a3-4dbb-b8cf-90a391e5a1b2"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("56a209d1-b7c9-45aa-a6d6-0ab8eabef28c"), "Ariel.Pacocha@yahoo.com", false, new Guid("56a209d1-b7c9-45aa-a6d6-0ab8eabef28c"), new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed") },
                    { new Guid("56b9eb0a-b0a4-4220-b964-5d575efcdbc7"), "Clair74@gmail.com", false, new Guid("56b9eb0a-b0a4-4220-b964-5d575efcdbc7"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("57005bfb-4c80-448f-b2d3-8b4392925dfb"), "Mary_Wiza@gmail.com", false, new Guid("57005bfb-4c80-448f-b2d3-8b4392925dfb"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("5771b94a-9d72-455f-bc11-70b42de74cc8"), "Bettye97@hotmail.com", false, new Guid("5771b94a-9d72-455f-bc11-70b42de74cc8"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("5786a4e0-d1d8-46ff-b1f7-464155de8a47"), "Dorthy.Johns84@gmail.com", false, new Guid("5786a4e0-d1d8-46ff-b1f7-464155de8a47"), new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376") },
                    { new Guid("57f95184-f398-4924-9ce1-b1381123c82a"), "Donnie14@yahoo.com", false, new Guid("57f95184-f398-4924-9ce1-b1381123c82a"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("58932b8d-09c1-43d2-92c6-9767003533f4"), "Colby.Boyle@gmail.com", false, new Guid("58932b8d-09c1-43d2-92c6-9767003533f4"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("5929db0a-bead-4f79-9754-47854643aec4"), "Twila_McCullough@gmail.com", false, new Guid("5929db0a-bead-4f79-9754-47854643aec4"), new Guid("d422e4b4-5d7b-484f-830c-319350a69b22") },
                    { new Guid("597a50d1-4581-4887-b989-f15775301fb9"), "Salvatore_Shields@hotmail.com", false, new Guid("597a50d1-4581-4887-b989-f15775301fb9"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("59ccff5d-9ab4-4b05-8884-4da82066587a"), "Emil_Ruecker12@hotmail.com", false, new Guid("59ccff5d-9ab4-4b05-8884-4da82066587a"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("59d996a5-147e-4428-8921-72f4f67d96a0"), "Kristy67@hotmail.com", false, new Guid("59d996a5-147e-4428-8921-72f4f67d96a0"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("5a1e7225-74a3-4ebc-8d55-a1e5b4559f9e"), "Chyna_Boyer@hotmail.com", false, new Guid("5a1e7225-74a3-4ebc-8d55-a1e5b4559f9e"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("5a41a745-7bea-4f62-b3ac-adfcba2c2c74"), "Lenora.Maggio@gmail.com", false, new Guid("5a41a745-7bea-4f62-b3ac-adfcba2c2c74"), new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d") },
                    { new Guid("5a59fa46-0ac4-480a-80ae-546e4c3a761e"), "Catharine_Gleason@yahoo.com", false, new Guid("5a59fa46-0ac4-480a-80ae-546e4c3a761e"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("5a904c88-fd6c-4210-8107-e93fa9b6a00d"), "Marie.Beier@hotmail.com", false, new Guid("5a904c88-fd6c-4210-8107-e93fa9b6a00d"), new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("5aa5b464-0c97-48c3-93af-a44464d028ce"), "Rahsaan70@hotmail.com", false, new Guid("5aa5b464-0c97-48c3-93af-a44464d028ce"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("5abf118d-f83e-4803-b37a-f4d2f9203d28"), "Clementine.Bergstrom@gmail.com", false, new Guid("5abf118d-f83e-4803-b37a-f4d2f9203d28"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("5b5ab93a-dac6-4f53-934a-d072cfb407ff"), "Jules5@gmail.com", false, new Guid("5b5ab93a-dac6-4f53-934a-d072cfb407ff"), new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d") },
                    { new Guid("5b9fa6a0-ccc9-4f2e-874e-0a062151ebd3"), "Brown37@gmail.com", false, new Guid("5b9fa6a0-ccc9-4f2e-874e-0a062151ebd3"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("5c0523a2-6e7b-4bcd-be54-d76d3f92ecb2"), "Kasandra_Bernhard90@gmail.com", false, new Guid("5c0523a2-6e7b-4bcd-be54-d76d3f92ecb2"), new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8") },
                    { new Guid("5cbaf31c-053d-4766-a768-855a79f2e104"), "Aracely.Schowalter83@yahoo.com", false, new Guid("5cbaf31c-053d-4766-a768-855a79f2e104"), new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272") },
                    { new Guid("5d17421b-36b8-42aa-94e2-9abab77bbcc6"), "Dayne_Borer97@gmail.com", false, new Guid("5d17421b-36b8-42aa-94e2-9abab77bbcc6"), new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b") },
                    { new Guid("5dd39c9c-0a64-488a-bdc6-99b9c581610b"), "Ezra.Watsica55@hotmail.com", false, new Guid("5dd39c9c-0a64-488a-bdc6-99b9c581610b"), new Guid("8f8cd90d-fe20-4df0-8607-72f337546146") },
                    { new Guid("5ed75788-5cca-4b93-b3a9-a75078703f86"), "Clare.Connelly@hotmail.com", false, new Guid("5ed75788-5cca-4b93-b3a9-a75078703f86"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("5ee95bbc-a144-4622-91eb-3c8439f6eac8"), "Alessandra14@yahoo.com", false, new Guid("5ee95bbc-a144-4622-91eb-3c8439f6eac8"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("5f6fe654-f729-4216-a7bf-3352d4b12dd7"), "Arvid.McKenzie@hotmail.com", false, new Guid("5f6fe654-f729-4216-a7bf-3352d4b12dd7"), new Guid("69170f92-b4b7-4c26-be44-5255d738fb20") },
                    { new Guid("5fb3805a-2616-4573-8930-7d3afb37c03d"), "Kayli.Blanda@gmail.com", false, new Guid("5fb3805a-2616-4573-8930-7d3afb37c03d"), new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("5ff4fba6-ed29-47b0-929d-83a7699d7000"), "Nathen_Fisher78@gmail.com", false, new Guid("5ff4fba6-ed29-47b0-929d-83a7699d7000"), new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6") },
                    { new Guid("600143ca-fe0c-44ba-83aa-ec6913a3daab"), "Elena.Hermann67@gmail.com", false, new Guid("600143ca-fe0c-44ba-83aa-ec6913a3daab"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("60136d2d-a292-4e1e-92d4-033a527574ea"), "Naomie_Cartwright61@gmail.com", false, new Guid("60136d2d-a292-4e1e-92d4-033a527574ea"), new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584") },
                    { new Guid("604f891d-2c9a-48b8-89ce-5b64f0f98de1"), "Meda_Stracke92@hotmail.com", false, new Guid("604f891d-2c9a-48b8-89ce-5b64f0f98de1"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("610f88e3-bc37-4c2b-a7fc-8530f7506190"), "Russel_Hartmann@hotmail.com", false, new Guid("610f88e3-bc37-4c2b-a7fc-8530f7506190"), new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22") },
                    { new Guid("616a7487-ddf5-461c-a066-0576586e012e"), "Adonis.Bruen87@yahoo.com", false, new Guid("616a7487-ddf5-461c-a066-0576586e012e"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("619a4192-8bfa-401c-910d-d82486665043"), "Emmet56@yahoo.com", false, new Guid("619a4192-8bfa-401c-910d-d82486665043"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("6212c0ee-88a2-4fab-9dd5-3aa30fd2dd0c"), "Keeley23@yahoo.com", false, new Guid("6212c0ee-88a2-4fab-9dd5-3aa30fd2dd0c"), new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("621aa468-4fe8-4f31-b5b3-c72412d9d573"), "Lucie_Schmidt84@yahoo.com", false, new Guid("621aa468-4fe8-4f31-b5b3-c72412d9d573"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("63534779-cdc9-487f-84d8-fc07eb4cbd42"), "Wendell45@hotmail.com", false, new Guid("63534779-cdc9-487f-84d8-fc07eb4cbd42"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("63b1e21f-b7a3-446f-8ecd-9e202380af1a"), "Mario55@yahoo.com", false, new Guid("63b1e21f-b7a3-446f-8ecd-9e202380af1a"), new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405") },
                    { new Guid("6421b458-3be7-41a5-924f-c249b29371f8"), "Jeff.Swaniawski86@gmail.com", false, new Guid("6421b458-3be7-41a5-924f-c249b29371f8"), new Guid("05d888a7-8474-4565-b751-a89df2400346") },
                    { new Guid("64af790f-b8bd-4f27-bb06-05c87515a40a"), "Elbert_Gutkowski77@gmail.com", false, new Guid("64af790f-b8bd-4f27-bb06-05c87515a40a"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("6546a8f0-93aa-42b3-8dd2-3d9bee8b80f7"), "Kareem.Feest@hotmail.com", false, new Guid("6546a8f0-93aa-42b3-8dd2-3d9bee8b80f7"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("655b4484-2f48-4d30-bb4d-ccc01631abfa"), "Diego.Rippin58@hotmail.com", false, new Guid("655b4484-2f48-4d30-bb4d-ccc01631abfa"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("66654d1b-28c3-4ea3-a92b-8d3c7018a027"), "Jarrell22@yahoo.com", false, new Guid("66654d1b-28c3-4ea3-a92b-8d3c7018a027"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("66a55a59-ce1c-413c-bfda-e5f768e7c08f"), "Enid90@hotmail.com", false, new Guid("66a55a59-ce1c-413c-bfda-e5f768e7c08f"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("66c14b09-c609-4c2e-861f-a0f3ab17890d"), "Reina34@hotmail.com", false, new Guid("66c14b09-c609-4c2e-861f-a0f3ab17890d"), new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6") },
                    { new Guid("67df11dc-2189-45a0-b83b-7ee1b236f06a"), "Erwin27@gmail.com", false, new Guid("67df11dc-2189-45a0-b83b-7ee1b236f06a"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("68327b39-e3ab-4e42-bc20-6e985283e8a6"), "Howard82@hotmail.com", false, new Guid("68327b39-e3ab-4e42-bc20-6e985283e8a6"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("688f2d84-1169-44e1-ab9f-752c66d226ab"), "Stewart.Windler@gmail.com", false, new Guid("688f2d84-1169-44e1-ab9f-752c66d226ab"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("69085302-532b-4283-a532-6d757407427d"), "Eulah.Osinski@yahoo.com", false, new Guid("69085302-532b-4283-a532-6d757407427d"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("6926ccc0-d66a-45f9-9e86-7076c847f949"), "Hugh.Bartoletti20@hotmail.com", false, new Guid("6926ccc0-d66a-45f9-9e86-7076c847f949"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("69784206-88ce-4422-add9-6bd620d14a84"), "Alicia36@hotmail.com", false, new Guid("69784206-88ce-4422-add9-6bd620d14a84"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("698171be-329e-4061-b324-1c507230fa3f"), "Bernice54@gmail.com", false, new Guid("698171be-329e-4061-b324-1c507230fa3f"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("699f7284-4e06-4a44-8bcc-f245f5da9bfe"), "Kaleigh67@hotmail.com", false, new Guid("699f7284-4e06-4a44-8bcc-f245f5da9bfe"), new Guid("48949002-3dd7-424b-b508-bb6644cad6fb") },
                    { new Guid("69a224b5-91d5-46c0-9435-242e36ecdb25"), "Sherwood5@yahoo.com", false, new Guid("69a224b5-91d5-46c0-9435-242e36ecdb25"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("6a9e3a57-cd4e-4729-8136-b8be8ddc1931"), "Sigurd.Mraz66@yahoo.com", false, new Guid("6a9e3a57-cd4e-4729-8136-b8be8ddc1931"), new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867") },
                    { new Guid("6aafd3c1-4a0d-4e16-86c4-25d877813ee5"), "Jensen.Baumbach@hotmail.com", false, new Guid("6aafd3c1-4a0d-4e16-86c4-25d877813ee5"), new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd") },
                    { new Guid("6ac825be-4a2c-4760-9e78-05b4a0222cde"), "Brendan_Bauch@hotmail.com", false, new Guid("6ac825be-4a2c-4760-9e78-05b4a0222cde"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("6acfadaf-1304-463f-b6da-44b5c0210276"), "Effie.Bartoletti@hotmail.com", false, new Guid("6acfadaf-1304-463f-b6da-44b5c0210276"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("6b3abaf0-09b6-4caa-8e35-a4f6da54fa9c"), "Mathilde_Jaskolski78@yahoo.com", false, new Guid("6b3abaf0-09b6-4caa-8e35-a4f6da54fa9c"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("6b9f9ee7-a2bb-463e-8d10-4e417a9568a5"), "Pamela42@hotmail.com", false, new Guid("6b9f9ee7-a2bb-463e-8d10-4e417a9568a5"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("6bd6e5a4-b401-4029-be5d-896f2e5e4df0"), "Alejandra_Stamm@hotmail.com", false, new Guid("6bd6e5a4-b401-4029-be5d-896f2e5e4df0"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("6c24530e-559b-40bd-b769-57b200774976"), "Rowena69@hotmail.com", false, new Guid("6c24530e-559b-40bd-b769-57b200774976"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("6c6069ec-92fd-482a-b037-af36d8e419c2"), "Danika.Zboncak12@yahoo.com", false, new Guid("6c6069ec-92fd-482a-b037-af36d8e419c2"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("6c7cb7f0-2e8c-4a63-9a65-2c27530ceeab"), "Muriel43@hotmail.com", false, new Guid("6c7cb7f0-2e8c-4a63-9a65-2c27530ceeab"), new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29") },
                    { new Guid("6cbbf31f-4532-4ca9-a842-64f91d6eff22"), "Philip_Spencer@gmail.com", false, new Guid("6cbbf31f-4532-4ca9-a842-64f91d6eff22"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("6ced3b0e-0fe5-43a3-bf2b-06196006efc3"), "Camryn.Heller59@yahoo.com", false, new Guid("6ced3b0e-0fe5-43a3-bf2b-06196006efc3"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("6dec0f71-497c-43a6-8f63-86e9a81df837"), "Abbey_Senger6@hotmail.com", false, new Guid("6dec0f71-497c-43a6-8f63-86e9a81df837"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("6e896a58-3cb8-44b4-85f9-d615b0795851"), "Velva_OConnell@hotmail.com", false, new Guid("6e896a58-3cb8-44b4-85f9-d615b0795851"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("6ec2051a-1c1a-44e0-b5b2-8455b5728915"), "Katlynn_Reynolds95@gmail.com", false, new Guid("6ec2051a-1c1a-44e0-b5b2-8455b5728915"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("6ec6742f-6d4d-47e2-b2ab-e0da5b441aa7"), "Brady_Murazik40@yahoo.com", false, new Guid("6ec6742f-6d4d-47e2-b2ab-e0da5b441aa7"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("6ee1d9df-4147-47ca-b70e-1d68f066913e"), "Luis.Spencer54@yahoo.com", false, new Guid("6ee1d9df-4147-47ca-b70e-1d68f066913e"), new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374") },
                    { new Guid("6f6f7530-333f-4747-b69e-99c5386acb95"), "Tracy_Erdman@yahoo.com", false, new Guid("6f6f7530-333f-4747-b69e-99c5386acb95"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("6fd57248-fa6d-43a3-be07-21b2e97d7ea2"), "Vena.Hansen46@yahoo.com", false, new Guid("6fd57248-fa6d-43a3-be07-21b2e97d7ea2"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("7089b3ed-d761-4e78-94ea-67adc15614b9"), "Lonny_McLaughlin76@yahoo.com", false, new Guid("7089b3ed-d761-4e78-94ea-67adc15614b9"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("70cff63f-dff7-427d-8f7c-529ecb949c40"), "Yoshiko31@hotmail.com", false, new Guid("70cff63f-dff7-427d-8f7c-529ecb949c40"), new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("70e37f78-7950-453d-9d82-364b95644f84"), "Marjolaine_Schaefer@hotmail.com", false, new Guid("70e37f78-7950-453d-9d82-364b95644f84"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("71744eee-15bf-4ba5-bf68-f9a512f08e83"), "Emil19@hotmail.com", false, new Guid("71744eee-15bf-4ba5-bf68-f9a512f08e83"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("71a69e9c-bec0-4ef5-9bdc-76c921bc82cd"), "Eulalia34@hotmail.com", false, new Guid("71a69e9c-bec0-4ef5-9bdc-76c921bc82cd"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("71f1c8e2-b8ca-4823-a133-b8e4c3363aaa"), "Malcolm48@yahoo.com", false, new Guid("71f1c8e2-b8ca-4823-a133-b8e4c3363aaa"), new Guid("f7e86b66-49eb-4774-82be-b008350dc98b") },
                    { new Guid("7207b5ad-b7d3-4e69-8d49-00d0fc275e76"), "Krystel_Muller97@yahoo.com", false, new Guid("7207b5ad-b7d3-4e69-8d49-00d0fc275e76"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("72306355-eb75-4421-b21f-2c58e13eff4b"), "Nelson_MacGyver@gmail.com", false, new Guid("72306355-eb75-4421-b21f-2c58e13eff4b"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("72869614-0aa6-4685-a354-c49a921c2bef"), "Quentin98@gmail.com", false, new Guid("72869614-0aa6-4685-a354-c49a921c2bef"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("72b9f27a-d62a-43b2-9cdd-e5aeaaad2db1"), "Tanner_Crona@gmail.com", false, new Guid("72b9f27a-d62a-43b2-9cdd-e5aeaaad2db1"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("730c299f-d1d4-4264-983c-697b91beb78b"), "Raleigh.Upton98@gmail.com", false, new Guid("730c299f-d1d4-4264-983c-697b91beb78b"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("73153e5e-aff2-4a80-b057-ca7a8a1cbe56"), "Aurelia47@gmail.com", false, new Guid("73153e5e-aff2-4a80-b057-ca7a8a1cbe56"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("731dc54d-a2a6-4626-9e9e-1b366a915232"), "Ulices82@gmail.com", false, new Guid("731dc54d-a2a6-4626-9e9e-1b366a915232"), new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b") },
                    { new Guid("738a9d15-99e4-40cb-ad13-6fc41a42602d"), "Sheldon_Pfeffer@yahoo.com", false, new Guid("738a9d15-99e4-40cb-ad13-6fc41a42602d"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("73ac8256-5611-48ba-a2ce-9bab7b73a68a"), "Lorenz5@gmail.com", false, new Guid("73ac8256-5611-48ba-a2ce-9bab7b73a68a"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("73af580a-edb8-4721-b1e3-833875dee264"), "Cory_Mosciski83@yahoo.com", false, new Guid("73af580a-edb8-4721-b1e3-833875dee264"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("7438ce3b-80ee-4128-89d9-59468f2a906e"), "Madge_Pouros@yahoo.com", false, new Guid("7438ce3b-80ee-4128-89d9-59468f2a906e"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("7472d679-17ed-4cdb-aaec-a408bf7b0e64"), "Dan.Toy83@hotmail.com", false, new Guid("7472d679-17ed-4cdb-aaec-a408bf7b0e64"), new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738") },
                    { new Guid("7474b9de-0191-4630-89e8-1ed4fff1c550"), "Kody_Wisoky@yahoo.com", false, new Guid("7474b9de-0191-4630-89e8-1ed4fff1c550"), new Guid("3e38a390-7168-426f-8d48-017588046d20") },
                    { new Guid("74e1da85-821c-492f-b3af-489f25133814"), "Ella_Keebler@yahoo.com", false, new Guid("74e1da85-821c-492f-b3af-489f25133814"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("74e63807-0050-4f8a-b0e5-bd3d48b5f247"), "Teagan_Reichel@gmail.com", false, new Guid("74e63807-0050-4f8a-b0e5-bd3d48b5f247"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("74ea20c4-56a4-49e5-bd92-653b3effccdd"), "Corine_Moore@gmail.com", false, new Guid("74ea20c4-56a4-49e5-bd92-653b3effccdd"), new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221") },
                    { new Guid("74f1ae39-8f8d-4668-a98b-6b4eb6624c40"), "Elton.Watsica19@yahoo.com", false, new Guid("74f1ae39-8f8d-4668-a98b-6b4eb6624c40"), new Guid("203cc97b-91be-4474-b881-e9776da21af9") },
                    { new Guid("7533a1c1-0046-4f7c-905b-d9a5832ddc79"), "Ervin_Daugherty@gmail.com", false, new Guid("7533a1c1-0046-4f7c-905b-d9a5832ddc79"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("762f37f5-e3f9-481e-82ce-c0b27f0d3238"), "Colton53@yahoo.com", false, new Guid("762f37f5-e3f9-481e-82ce-c0b27f0d3238"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("76b01d1b-c217-42cb-aecf-ea3d4914f36b"), "Elvie.Wehner19@gmail.com", false, new Guid("76b01d1b-c217-42cb-aecf-ea3d4914f36b"), new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("770d7538-8444-478a-a639-4499e81c5c97"), "Maye.Bayer70@yahoo.com", false, new Guid("770d7538-8444-478a-a639-4499e81c5c97"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("771973e7-cc78-4a54-838e-712bbc5053c4"), "Nella.Walker@hotmail.com", false, new Guid("771973e7-cc78-4a54-838e-712bbc5053c4"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("7740d48b-3933-42c3-b0e0-000f206f7879"), "Nola87@gmail.com", false, new Guid("7740d48b-3933-42c3-b0e0-000f206f7879"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("77adfc6c-2f6a-4052-9c9b-92da28af343e"), "Jana_Beahan13@yahoo.com", false, new Guid("77adfc6c-2f6a-4052-9c9b-92da28af343e"), new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131") },
                    { new Guid("77aef864-9a7c-4b92-b994-5d71ca838274"), "Rogers.Collier@yahoo.com", false, new Guid("77aef864-9a7c-4b92-b994-5d71ca838274"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("780d845b-c513-4d7c-8fdb-a04e3ef1ae3d"), "Johathan_Upton98@yahoo.com", false, new Guid("780d845b-c513-4d7c-8fdb-a04e3ef1ae3d"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("787d628d-3e35-4cba-ba5c-927bdb1ef8c5"), "Wilhelmine99@hotmail.com", false, new Guid("787d628d-3e35-4cba-ba5c-927bdb1ef8c5"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("78a7d409-d93e-4fa9-8d77-a2b0b8ce2eae"), "Joey.Shanahan@gmail.com", false, new Guid("78a7d409-d93e-4fa9-8d77-a2b0b8ce2eae"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("7901857a-d18b-47a1-9bf0-47d29ae40b48"), "Joesph60@gmail.com", false, new Guid("7901857a-d18b-47a1-9bf0-47d29ae40b48"), new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11") },
                    { new Guid("79dfc46c-c2bf-4aed-b403-1b243180d1df"), "Olga_Grady38@hotmail.com", false, new Guid("79dfc46c-c2bf-4aed-b403-1b243180d1df"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("7a0c5828-f694-47d8-8baf-ef9d570f7818"), "Nyasia99@gmail.com", false, new Guid("7a0c5828-f694-47d8-8baf-ef9d570f7818"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("7a0c9127-42b4-46bd-b2ff-ff8e996a844a"), "Bernie54@yahoo.com", false, new Guid("7a0c9127-42b4-46bd-b2ff-ff8e996a844a"), new Guid("203cc97b-91be-4474-b881-e9776da21af9") },
                    { new Guid("7a13f9d1-1553-46a6-a2f5-fa9edf77d6a4"), "Naomie.Terry68@gmail.com", false, new Guid("7a13f9d1-1553-46a6-a2f5-fa9edf77d6a4"), new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa") },
                    { new Guid("7a2cd72e-972e-4f32-b4d5-c812843a9e62"), "Davon95@gmail.com", false, new Guid("7a2cd72e-972e-4f32-b4d5-c812843a9e62"), new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("7ab80592-f6a4-465f-8f2f-5cfbf3d8ff3d"), "Elvera.Luettgen@gmail.com", false, new Guid("7ab80592-f6a4-465f-8f2f-5cfbf3d8ff3d"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("7abb4e8b-65d5-46c0-8a3f-e8c74368f38d"), "Veronica.Green94@yahoo.com", false, new Guid("7abb4e8b-65d5-46c0-8a3f-e8c74368f38d"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("7adc2cc4-553b-41a7-ac47-e4aad0db4379"), "Callie.Auer@gmail.com", false, new Guid("7adc2cc4-553b-41a7-ac47-e4aad0db4379"), new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a") },
                    { new Guid("7af6a18c-8c52-430c-abcb-b47102f9ab83"), "Cecilia_Fadel@hotmail.com", false, new Guid("7af6a18c-8c52-430c-abcb-b47102f9ab83"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("7ba1f574-a57f-4c44-b143-4e245a20de3d"), "Johnathan_Altenwerth87@hotmail.com", false, new Guid("7ba1f574-a57f-4c44-b143-4e245a20de3d"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("7bb060de-ac53-473b-bedf-2712d9b9195c"), "Alexanne78@gmail.com", false, new Guid("7bb060de-ac53-473b-bedf-2712d9b9195c"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("7c0f2fb6-9588-460f-9968-2226c4d8358c"), "Ben10@gmail.com", false, new Guid("7c0f2fb6-9588-460f-9968-2226c4d8358c"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("7c447b86-fbc3-4650-849f-54f5b219a75e"), "Alicia_Kiehn47@gmail.com", false, new Guid("7c447b86-fbc3-4650-849f-54f5b219a75e"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("7c87a9e2-7aa7-4c90-b939-3f63076ec1bd"), "Neva13@yahoo.com", false, new Guid("7c87a9e2-7aa7-4c90-b939-3f63076ec1bd"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("7c9055b1-cdf3-4a9b-8e8f-8fddfacd871d"), "Arvel_DAmore@gmail.com", false, new Guid("7c9055b1-cdf3-4a9b-8e8f-8fddfacd871d"), new Guid("f825bff2-881f-450b-a4b7-56931951c54c") },
                    { new Guid("7d5b7da2-213f-4764-966c-343e101a2e78"), "Jettie_Howe57@yahoo.com", false, new Guid("7d5b7da2-213f-4764-966c-343e101a2e78"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("7dd719f7-bd71-4720-a541-7c2bc5dec03e"), "Jo46@yahoo.com", false, new Guid("7dd719f7-bd71-4720-a541-7c2bc5dec03e"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("7ed8615f-f49b-41e5-b792-5d8c4f5df2a7"), "Grayce97@gmail.com", false, new Guid("7ed8615f-f49b-41e5-b792-5d8c4f5df2a7"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("7eda427e-8d2f-4a09-95dc-0319c8442a51"), "Katelynn_Jenkins@gmail.com", false, new Guid("7eda427e-8d2f-4a09-95dc-0319c8442a51"), new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425") },
                    { new Guid("7f1bc0bb-e017-47d1-9233-9c8665c3e19e"), "Demetris_Beer60@hotmail.com", false, new Guid("7f1bc0bb-e017-47d1-9233-9c8665c3e19e"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("7f484816-90e4-4990-8565-e9c8c57c7967"), "Clair_Effertz@hotmail.com", false, new Guid("7f484816-90e4-4990-8565-e9c8c57c7967"), new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2") },
                    { new Guid("7f49c97a-cb24-488b-8f73-1e305e6cd3aa"), "Tanner91@gmail.com", false, new Guid("7f49c97a-cb24-488b-8f73-1e305e6cd3aa"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("7fa35589-5003-4ce4-8774-9e8ad6dc564c"), "Marcellus.OKon@yahoo.com", false, new Guid("7fa35589-5003-4ce4-8774-9e8ad6dc564c"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("7fc4b908-22d3-4efa-90fe-c8f0627f76da"), "Uriah_Wyman92@gmail.com", false, new Guid("7fc4b908-22d3-4efa-90fe-c8f0627f76da"), new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b") },
                    { new Guid("8096bcb1-5e74-4392-9bcf-7d1f28d38e55"), "Payton_Jaskolski@yahoo.com", false, new Guid("8096bcb1-5e74-4392-9bcf-7d1f28d38e55"), new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b") },
                    { new Guid("8109c50f-a852-4c12-8432-43d4a51c297f"), "Joyce.Kutch97@yahoo.com", false, new Guid("8109c50f-a852-4c12-8432-43d4a51c297f"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("8162886a-8b00-4110-bd6f-dd283bd306fc"), "Camden.Bednar98@hotmail.com", false, new Guid("8162886a-8b00-4110-bd6f-dd283bd306fc"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("8195bbeb-37ce-4dc6-a703-f9b8dc21f85c"), "Matilde.Murazik11@hotmail.com", false, new Guid("8195bbeb-37ce-4dc6-a703-f9b8dc21f85c"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("819f96fe-b502-487a-9afd-9d371b1826f8"), "Mina_Wiegand72@hotmail.com", false, new Guid("819f96fe-b502-487a-9afd-9d371b1826f8"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("82579777-7119-4be7-adc4-7935381acedc"), "Linnea53@gmail.com", false, new Guid("82579777-7119-4be7-adc4-7935381acedc"), new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b") },
                    { new Guid("82756d2b-8caa-4789-9f1f-28fa432a1a6b"), "Cielo68@gmail.com", false, new Guid("82756d2b-8caa-4789-9f1f-28fa432a1a6b"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("827eb379-34fb-44aa-9e31-ec02612b6b08"), "Zakary.Schiller@gmail.com", false, new Guid("827eb379-34fb-44aa-9e31-ec02612b6b08"), new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e") },
                    { new Guid("82d27b7f-4190-4e63-90f1-52a4ba81f7a0"), "Laura.Thiel52@gmail.com", false, new Guid("82d27b7f-4190-4e63-90f1-52a4ba81f7a0"), new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("83089011-8b73-48e1-8ac9-1bf86caf24d4"), "Vivian_Lang29@hotmail.com", false, new Guid("83089011-8b73-48e1-8ac9-1bf86caf24d4"), new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473") },
                    { new Guid("83174955-2d4c-4e51-9287-ce4d3f4fc0ba"), "Brycen.Littel33@gmail.com", false, new Guid("83174955-2d4c-4e51-9287-ce4d3f4fc0ba"), new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899") },
                    { new Guid("83747e2d-af0c-45b8-a998-a4a68fdac143"), "Eleazar.Halvorson@yahoo.com", false, new Guid("83747e2d-af0c-45b8-a998-a4a68fdac143"), new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03") },
                    { new Guid("83a77926-04ea-4887-abfa-a6496c84fc55"), "Marlene0@gmail.com", false, new Guid("83a77926-04ea-4887-abfa-a6496c84fc55"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("83c68451-f44e-40ab-b902-faefc6d421f5"), "Noemie_Gusikowski15@gmail.com", false, new Guid("83c68451-f44e-40ab-b902-faefc6d421f5"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("842f370e-f988-4f52-87d7-6e0778f608c9"), "Vena.Luettgen32@yahoo.com", false, new Guid("842f370e-f988-4f52-87d7-6e0778f608c9"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("846c0990-14c1-4e25-93ba-150920ddd0b8"), "Kole80@gmail.com", false, new Guid("846c0990-14c1-4e25-93ba-150920ddd0b8"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("84a52fe8-0a29-4734-bc3e-7ea69de83da6"), "Vivian.Vandervort@yahoo.com", false, new Guid("84a52fe8-0a29-4734-bc3e-7ea69de83da6"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("84d63deb-a762-4f84-9011-8835c0c60e29"), "Rachel_Prohaska@gmail.com", false, new Guid("84d63deb-a762-4f84-9011-8835c0c60e29"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("8556d657-5823-47d8-93b4-d147b8222977"), "Wanda_Olson@gmail.com", false, new Guid("8556d657-5823-47d8-93b4-d147b8222977"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("85a1efe4-7631-48de-a01a-1e4263ad209f"), "Domenica54@gmail.com", false, new Guid("85a1efe4-7631-48de-a01a-1e4263ad209f"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("85ae9429-2348-4202-83b8-742b05a75884"), "Dina.Dibbert68@gmail.com", false, new Guid("85ae9429-2348-4202-83b8-742b05a75884"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("85c7a309-14ff-47af-8056-ad8a6b6967c3"), "Orin.Yundt38@gmail.com", false, new Guid("85c7a309-14ff-47af-8056-ad8a6b6967c3"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("860b9f64-2e4b-484b-9589-a449d611d491"), "Abdiel_Kling@yahoo.com", false, new Guid("860b9f64-2e4b-484b-9589-a449d611d491"), new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456") },
                    { new Guid("860caf7d-806b-45bf-a917-f1ba388712aa"), "Davion.Botsford@hotmail.com", false, new Guid("860caf7d-806b-45bf-a917-f1ba388712aa"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("8647f909-2333-4fd5-b0f7-53bf750f57dc"), "Marina_Hudson@gmail.com", false, new Guid("8647f909-2333-4fd5-b0f7-53bf750f57dc"), new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869") },
                    { new Guid("86e652da-134b-47d0-a2fb-30b6b3fe0be4"), "Viviane.Morissette@gmail.com", false, new Guid("86e652da-134b-47d0-a2fb-30b6b3fe0be4"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("8713c457-cbab-49f6-80e6-bc88ddb051ee"), "Elnora.Waelchi4@hotmail.com", false, new Guid("8713c457-cbab-49f6-80e6-bc88ddb051ee"), new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26") },
                    { new Guid("87490a28-80aa-436c-bafc-b25ec8dc9b1a"), "Cordell_Abernathy26@hotmail.com", false, new Guid("87490a28-80aa-436c-bafc-b25ec8dc9b1a"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("875f15f7-1eda-4eb6-82ac-ac86b28d816d"), "Jackson.Gorczany38@gmail.com", false, new Guid("875f15f7-1eda-4eb6-82ac-ac86b28d816d"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("87632ab3-82d1-4ff4-8c77-69ba274f47df"), "Vita27@yahoo.com", false, new Guid("87632ab3-82d1-4ff4-8c77-69ba274f47df"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("87d0f79c-f192-4a7a-9824-18107ebd2972"), "Salvatore15@hotmail.com", false, new Guid("87d0f79c-f192-4a7a-9824-18107ebd2972"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("88240272-bda4-4ac6-ba52-5cc8cbbf9d7e"), "Alford.Ernser28@yahoo.com", false, new Guid("88240272-bda4-4ac6-ba52-5cc8cbbf9d7e"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("889adfd7-cf96-4821-b722-00b21bc6c95d"), "Ansel55@yahoo.com", false, new Guid("889adfd7-cf96-4821-b722-00b21bc6c95d"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("88a99dea-f4e8-4d24-ad96-06b2ff0e8364"), "Dortha_Fahey@hotmail.com", false, new Guid("88a99dea-f4e8-4d24-ad96-06b2ff0e8364"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("88ee3763-6803-4544-8fe4-953e3bea0ca9"), "Joshua.Murphy@hotmail.com", false, new Guid("88ee3763-6803-4544-8fe4-953e3bea0ca9"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("890fe360-7be2-454f-a09f-aa954ff902f7"), "Anastacio.Buckridge43@yahoo.com", false, new Guid("890fe360-7be2-454f-a09f-aa954ff902f7"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("89236c6f-a9d9-4cac-bce8-6a367a604d5d"), "Travis28@gmail.com", false, new Guid("89236c6f-a9d9-4cac-bce8-6a367a604d5d"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("896936df-95f2-4945-b910-481a9f804e1f"), "Lonnie75@yahoo.com", false, new Guid("896936df-95f2-4945-b910-481a9f804e1f"), new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("89e345ce-92f6-4d37-bac0-6d2094fca3eb"), "Felicia.Witting@hotmail.com", false, new Guid("89e345ce-92f6-4d37-bac0-6d2094fca3eb"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("89e5f7e4-5525-44ae-bce1-a56880a58c0d"), "Willis_Krajcik75@yahoo.com", false, new Guid("89e5f7e4-5525-44ae-bce1-a56880a58c0d"), new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c") },
                    { new Guid("8a1d0963-b7ce-4147-b34e-c9ca4a8eaa41"), "Willard.Murphy86@hotmail.com", false, new Guid("8a1d0963-b7ce-4147-b34e-c9ca4a8eaa41"), new Guid("8b896efc-3b46-4670-bb2b-740919a113b5") },
                    { new Guid("8a237b65-cc4b-43b1-873a-38422fd617c0"), "Norbert.Purdy68@yahoo.com", false, new Guid("8a237b65-cc4b-43b1-873a-38422fd617c0"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("8a974dc6-5b8c-4963-a142-60a9dd43ab72"), "Sonya_Larson96@yahoo.com", false, new Guid("8a974dc6-5b8c-4963-a142-60a9dd43ab72"), new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2") },
                    { new Guid("8aab640b-fe66-42e7-8b74-14e24300e4bf"), "Russell_Langworth88@yahoo.com", false, new Guid("8aab640b-fe66-42e7-8b74-14e24300e4bf"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("8ad1e752-a6d3-4cfc-a3ed-ee9c1d3085cd"), "Lavada99@hotmail.com", false, new Guid("8ad1e752-a6d3-4cfc-a3ed-ee9c1d3085cd"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("8aeab39d-970f-4b3c-9ba6-5cea79d602cf"), "Winfield_Boyle38@yahoo.com", false, new Guid("8aeab39d-970f-4b3c-9ba6-5cea79d602cf"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("8b64b98d-5fc5-45f4-8f9e-9b5975a3372d"), "Vivian_Vandervort58@yahoo.com", false, new Guid("8b64b98d-5fc5-45f4-8f9e-9b5975a3372d"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("8b901987-dd5e-4ea1-b066-9e53fe336cf7"), "Cierra57@hotmail.com", false, new Guid("8b901987-dd5e-4ea1-b066-9e53fe336cf7"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("8c198184-a891-42f6-b572-fb3084836aa2"), "Tina57@hotmail.com", false, new Guid("8c198184-a891-42f6-b572-fb3084836aa2"), new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("8cd8c886-d574-4701-bb54-17f586af5f11"), "Leda90@gmail.com", false, new Guid("8cd8c886-d574-4701-bb54-17f586af5f11"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("8ceaf196-5651-463f-af9c-89714a9ab8ea"), "Gussie90@hotmail.com", false, new Guid("8ceaf196-5651-463f-af9c-89714a9ab8ea"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("8cffb352-1e1b-4808-8ad0-772c3ba5cf71"), "Murphy.Metz@gmail.com", false, new Guid("8cffb352-1e1b-4808-8ad0-772c3ba5cf71"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("8daf5085-2f99-480f-9d7f-0e5600e8f36b"), "Bianka_Walter11@gmail.com", false, new Guid("8daf5085-2f99-480f-9d7f-0e5600e8f36b"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("8de7c318-fe9e-48c3-b599-1c180c1f510c"), "Boyd.Hodkiewicz5@hotmail.com", false, new Guid("8de7c318-fe9e-48c3-b599-1c180c1f510c"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("8e03e4cd-adbe-4bea-a3fb-44eaf3d2f2f5"), "Arnold52@yahoo.com", false, new Guid("8e03e4cd-adbe-4bea-a3fb-44eaf3d2f2f5"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("8e0aaa09-3d16-44c5-8df7-7c7d98fc0a69"), "Abe94@yahoo.com", false, new Guid("8e0aaa09-3d16-44c5-8df7-7c7d98fc0a69"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("8e21dab6-664e-45a1-abb5-e95b551bdb2e"), "Alycia_Huel@hotmail.com", false, new Guid("8e21dab6-664e-45a1-abb5-e95b551bdb2e"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("8e913892-98ae-4ca2-9fc8-6bc9a6ad2a30"), "Dayne_Frami27@gmail.com", false, new Guid("8e913892-98ae-4ca2-9fc8-6bc9a6ad2a30"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("8ec6c43c-1846-4836-b533-cf459d1f67aa"), "Stuart_Daniel@yahoo.com", false, new Guid("8ec6c43c-1846-4836-b533-cf459d1f67aa"), new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0") },
                    { new Guid("8f03580e-9641-4850-b6f3-181596728057"), "Elaina36@gmail.com", false, new Guid("8f03580e-9641-4850-b6f3-181596728057"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("8fb007d1-40c4-4e8d-8123-357a7284173d"), "Allison.Heaney@yahoo.com", false, new Guid("8fb007d1-40c4-4e8d-8123-357a7284173d"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("8fea836a-df3e-48b1-9434-b1772fbfdd69"), "Scot_Marks9@yahoo.com", false, new Guid("8fea836a-df3e-48b1-9434-b1772fbfdd69"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("9038608b-1754-46c5-9b3f-21ce9e417333"), "Reggie.Ritchie81@gmail.com", false, new Guid("9038608b-1754-46c5-9b3f-21ce9e417333"), new Guid("0462fe55-138a-4c03-a20d-8251dee6c206") },
                    { new Guid("906179b7-2159-4558-906e-9c17382a570a"), "Allen.McGlynn@yahoo.com", false, new Guid("906179b7-2159-4558-906e-9c17382a570a"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("90665e67-5c4f-4bae-9f28-456b8b5b6442"), "Amie_Barton50@yahoo.com", false, new Guid("90665e67-5c4f-4bae-9f28-456b8b5b6442"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("9077d121-998b-4e18-85e5-fa98eda3163e"), "Dillon98@gmail.com", false, new Guid("9077d121-998b-4e18-85e5-fa98eda3163e"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("90928047-002e-48f1-9ee7-c3f7e7344d43"), "Felicia_Koepp@hotmail.com", false, new Guid("90928047-002e-48f1-9ee7-c3f7e7344d43"), new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037") },
                    { new Guid("90dc710e-72f1-4960-91c0-d78be6ff3084"), "Moses_Rau@hotmail.com", false, new Guid("90dc710e-72f1-4960-91c0-d78be6ff3084"), new Guid("8b3ae855-3f1f-409d-8898-00767477ffae") },
                    { new Guid("90ec6d02-61a3-456e-ba08-409b26891e4e"), "Pinkie24@yahoo.com", false, new Guid("90ec6d02-61a3-456e-ba08-409b26891e4e"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("91104d78-7aca-4cdd-a074-21348ef6b18f"), "Ezekiel74@gmail.com", false, new Guid("91104d78-7aca-4cdd-a074-21348ef6b18f"), new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11") },
                    { new Guid("91b3d470-fed1-4194-b0b3-e75ce40e92d9"), "Jason_Price@gmail.com", false, new Guid("91b3d470-fed1-4194-b0b3-e75ce40e92d9"), new Guid("8f8cd90d-fe20-4df0-8607-72f337546146") },
                    { new Guid("926a535a-4ea5-4558-9cf0-c3b60419c3e1"), "Aurelio69@hotmail.com", false, new Guid("926a535a-4ea5-4558-9cf0-c3b60419c3e1"), new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("92795ab2-f98e-4c31-9525-5dfd1b2691cb"), "Christiana_Larson50@yahoo.com", false, new Guid("92795ab2-f98e-4c31-9525-5dfd1b2691cb"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("9298f71a-fd24-4e44-97eb-85519c427b7f"), "Jaquelin_Nikolaus71@yahoo.com", false, new Guid("9298f71a-fd24-4e44-97eb-85519c427b7f"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") },
                    { new Guid("938940ea-c58d-4c00-a269-d14f28f7d419"), "Dwight98@hotmail.com", false, new Guid("938940ea-c58d-4c00-a269-d14f28f7d419"), new Guid("c0886dea-4971-4369-8d28-75754e2575d0") },
                    { new Guid("93ccdbc0-f7c9-42c9-9f49-9ff903696b69"), "Willard_Abbott@yahoo.com", false, new Guid("93ccdbc0-f7c9-42c9-9f49-9ff903696b69"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("949fcdae-1b8b-460b-a16f-c1470674e243"), "Danyka71@gmail.com", false, new Guid("949fcdae-1b8b-460b-a16f-c1470674e243"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("94d2d541-d6f2-4ecb-a49e-36e799f86fad"), "Tyra_Jenkins66@gmail.com", false, new Guid("94d2d541-d6f2-4ecb-a49e-36e799f86fad"), new Guid("8987fd2f-b286-41d7-9544-b355355a2cff") },
                    { new Guid("94d6cc73-6d11-4ba5-97aa-064aec19537d"), "Saul.Yundt5@hotmail.com", false, new Guid("94d6cc73-6d11-4ba5-97aa-064aec19537d"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("94eb3b95-4adf-4873-a077-cd62def84dee"), "Nikko77@gmail.com", false, new Guid("94eb3b95-4adf-4873-a077-cd62def84dee"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("95374236-8d1f-4efd-a9b8-31ed4168dbaf"), "Garett_Morissette@gmail.com", false, new Guid("95374236-8d1f-4efd-a9b8-31ed4168dbaf"), new Guid("f825bff2-881f-450b-a4b7-56931951c54c") },
                    { new Guid("958fa021-75df-4346-a45a-bd8fbec2020f"), "Sadie_Braun@gmail.com", false, new Guid("958fa021-75df-4346-a45a-bd8fbec2020f"), new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46") },
                    { new Guid("95c22d90-256e-4480-84b0-f9b21b721b83"), "Isadore.Witting42@hotmail.com", false, new Guid("95c22d90-256e-4480-84b0-f9b21b721b83"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("95c8c396-f68f-4a60-a6a9-2e3d95c5f3f8"), "Roel_Gulgowski@hotmail.com", false, new Guid("95c8c396-f68f-4a60-a6a9-2e3d95c5f3f8"), new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a") },
                    { new Guid("964b86d1-067f-46de-8a62-1fdae5aa22e3"), "Liam_Oberbrunner96@gmail.com", false, new Guid("964b86d1-067f-46de-8a62-1fdae5aa22e3"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("9685feb8-5b4a-43aa-9649-0e4875e3bd18"), "Jazmyne_Predovic13@gmail.com", false, new Guid("9685feb8-5b4a-43aa-9649-0e4875e3bd18"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("96c0099d-d06b-468d-84b6-5f7e2c09195d"), "Elvis_Sipes7@yahoo.com", false, new Guid("96c0099d-d06b-468d-84b6-5f7e2c09195d"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("96ef8edd-e13a-4601-88ac-674740906ad6"), "Cristopher71@yahoo.com", false, new Guid("96ef8edd-e13a-4601-88ac-674740906ad6"), new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab") },
                    { new Guid("97d61c88-5150-4f6d-b0df-e0c821ffe924"), "Vivianne94@hotmail.com", false, new Guid("97d61c88-5150-4f6d-b0df-e0c821ffe924"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("98617541-35a2-42fc-bf14-9ae9b83acbee"), "Sarina_Morar@gmail.com", false, new Guid("98617541-35a2-42fc-bf14-9ae9b83acbee"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("988634f8-e6ac-462d-9aa0-e089d4cbfdf5"), "Alda_Huel@hotmail.com", false, new Guid("988634f8-e6ac-462d-9aa0-e089d4cbfdf5"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("98b377b1-8626-471c-b520-d4025fe11ef7"), "Whitney.Steuber24@hotmail.com", false, new Guid("98b377b1-8626-471c-b520-d4025fe11ef7"), new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("98b911b0-30a4-44e1-9d62-04c91b7b09cf"), "Aida.Berge@yahoo.com", false, new Guid("98b911b0-30a4-44e1-9d62-04c91b7b09cf"), new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("98c13726-82c6-464b-a90e-a9eaa081ecd9"), "Dewayne.Jaskolski@gmail.com", false, new Guid("98c13726-82c6-464b-a90e-a9eaa081ecd9"), new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7") },
                    { new Guid("99342fa1-079c-426a-9f90-dee616539122"), "Ahmad35@hotmail.com", false, new Guid("99342fa1-079c-426a-9f90-dee616539122"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("9a39f4e6-63b9-452e-814c-9d2f4aedd560"), "Iliana.Veum43@gmail.com", false, new Guid("9a39f4e6-63b9-452e-814c-9d2f4aedd560"), new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8") },
                    { new Guid("9a49f3fd-3b32-44c3-b9d4-f703b76e82a2"), "Claudie.Gleason@yahoo.com", false, new Guid("9a49f3fd-3b32-44c3-b9d4-f703b76e82a2"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("9a7d1375-2032-43bd-aa1c-e3aa8d92e187"), "German_Howe@gmail.com", false, new Guid("9a7d1375-2032-43bd-aa1c-e3aa8d92e187"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("9aa97a50-9460-4f59-837d-7929d232f70c"), "Emie19@yahoo.com", false, new Guid("9aa97a50-9460-4f59-837d-7929d232f70c"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("9bcfd80e-f3b1-40f3-884f-243181165d63"), "Garland4@gmail.com", false, new Guid("9bcfd80e-f3b1-40f3-884f-243181165d63"), new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df") },
                    { new Guid("9bef86a3-e8d9-4a97-8d4c-54f92d4735e1"), "Simeon15@yahoo.com", false, new Guid("9bef86a3-e8d9-4a97-8d4c-54f92d4735e1"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("9ccb69bf-5967-4581-b711-08bf97df231a"), "Carolina27@yahoo.com", false, new Guid("9ccb69bf-5967-4581-b711-08bf97df231a"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("9cde6834-92ae-4561-818d-11d35631d54c"), "Kaycee_Stokes0@gmail.com", false, new Guid("9cde6834-92ae-4561-818d-11d35631d54c"), new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574") },
                    { new Guid("9d07a979-6417-4e5e-ba7a-34ce6d8d3fbe"), "Danyka_Littel20@hotmail.com", false, new Guid("9d07a979-6417-4e5e-ba7a-34ce6d8d3fbe"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("9d2106f5-a59d-4103-aa63-60a7add0975e"), "Damien.Gottlieb37@gmail.com", false, new Guid("9d2106f5-a59d-4103-aa63-60a7add0975e"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("9d5a9fc9-bfaf-486e-9e56-c4fcfcacf582"), "Claudia.Yost@yahoo.com", false, new Guid("9d5a9fc9-bfaf-486e-9e56-c4fcfcacf582"), new Guid("a11d6609-e768-4189-bd78-5b34d82849e6") },
                    { new Guid("9da28bb1-7104-47bd-ad9d-3b95a2104b31"), "Sedrick_Harvey99@yahoo.com", false, new Guid("9da28bb1-7104-47bd-ad9d-3b95a2104b31"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("9ddec259-4342-46cc-a9ea-1d93278bfeb4"), "Katelin80@hotmail.com", false, new Guid("9ddec259-4342-46cc-a9ea-1d93278bfeb4"), new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a") },
                    { new Guid("9de03f07-a7ac-46f5-a735-b599a28384ad"), "Corbin87@yahoo.com", false, new Guid("9de03f07-a7ac-46f5-a735-b599a28384ad"), new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b") },
                    { new Guid("9de9c53b-9465-459b-83d2-b6699aeb562f"), "Adolf98@gmail.com", false, new Guid("9de9c53b-9465-459b-83d2-b6699aeb562f"), new Guid("ececce7b-505c-4bc7-b969-56ffcc451462") },
                    { new Guid("9e0daa45-3826-478e-abe4-ee33af3935ef"), "Dolores_Veum@gmail.com", false, new Guid("9e0daa45-3826-478e-abe4-ee33af3935ef"), new Guid("e5acadcd-43bb-4225-9367-f562e86197e5") },
                    { new Guid("9e471658-1ee3-453d-8894-9718f16af562"), "Gayle61@hotmail.com", false, new Guid("9e471658-1ee3-453d-8894-9718f16af562"), new Guid("3e38a390-7168-426f-8d48-017588046d20") },
                    { new Guid("9e7c3bd9-1b58-48f2-8d03-99e393e8a159"), "Camden74@gmail.com", false, new Guid("9e7c3bd9-1b58-48f2-8d03-99e393e8a159"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("9fa8ab4b-8434-4d1e-b7f3-4499796749dc"), "Haleigh.Heaney@hotmail.com", false, new Guid("9fa8ab4b-8434-4d1e-b7f3-4499796749dc"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("9ffe8a6e-dc1b-4dc0-ac0f-7e7a3e7f3100"), "Liliana_Leffler@hotmail.com", false, new Guid("9ffe8a6e-dc1b-4dc0-ac0f-7e7a3e7f3100"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("a00374df-c158-4fa0-9191-432428ffb8c6"), "Coleman_Konopelski77@hotmail.com", false, new Guid("a00374df-c158-4fa0-9191-432428ffb8c6"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("a01c2b37-5f9f-42a2-afb1-328b2b14e015"), "Orlando23@hotmail.com", false, new Guid("a01c2b37-5f9f-42a2-afb1-328b2b14e015"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("a0497eb9-7f13-4ae7-96b9-d5d2cc9224cc"), "Rita.OConnell96@hotmail.com", false, new Guid("a0497eb9-7f13-4ae7-96b9-d5d2cc9224cc"), new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405") },
                    { new Guid("a0a392cf-4015-4000-b350-5cf118e6459b"), "Leo21@hotmail.com", false, new Guid("a0a392cf-4015-4000-b350-5cf118e6459b"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("a0b2d909-4afa-4a42-a03d-f1d067df1eb3"), "Bertha43@hotmail.com", false, new Guid("a0b2d909-4afa-4a42-a03d-f1d067df1eb3"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("a12c8a90-ffd7-4d1f-9267-5b492694726b"), "Emmanuelle.Gorczany@yahoo.com", false, new Guid("a12c8a90-ffd7-4d1f-9267-5b492694726b"), new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a") },
                    { new Guid("a1849a3e-666f-4c6b-bb92-186eba8588d9"), "Jaquan.Rau@gmail.com", false, new Guid("a1849a3e-666f-4c6b-bb92-186eba8588d9"), new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b") },
                    { new Guid("a1c92e20-57e2-402d-a1b1-c78c73c5ae4b"), "Magdalen_Rath81@gmail.com", false, new Guid("a1c92e20-57e2-402d-a1b1-c78c73c5ae4b"), new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828") },
                    { new Guid("a2189373-ea07-45bc-8eee-08097a1fc863"), "Pansy.Legros@yahoo.com", false, new Guid("a2189373-ea07-45bc-8eee-08097a1fc863"), new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420") },
                    { new Guid("a23c71e1-69c3-4550-9efc-c7d00b1f0800"), "Herta80@yahoo.com", false, new Guid("a23c71e1-69c3-4550-9efc-c7d00b1f0800"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("a2464be6-45e5-48cd-9958-1cefd20dfb6a"), "Estell.Jacobi37@hotmail.com", false, new Guid("a2464be6-45e5-48cd-9958-1cefd20dfb6a"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("a26158a4-49b6-48fe-bfde-1e76ce4b083f"), "Litzy.Greenholt@hotmail.com", false, new Guid("a26158a4-49b6-48fe-bfde-1e76ce4b083f"), new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425") },
                    { new Guid("a2b9143e-ba1f-4591-bada-8aa2b0a51633"), "Brannon20@hotmail.com", false, new Guid("a2b9143e-ba1f-4591-bada-8aa2b0a51633"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("a30e529a-6bd5-4c31-a877-ae1523e0b123"), "Leta.Welch@yahoo.com", false, new Guid("a30e529a-6bd5-4c31-a877-ae1523e0b123"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("a37f98cc-711e-4e84-8fa8-6442603b8d50"), "Esteban_Hoeger@yahoo.com", false, new Guid("a37f98cc-711e-4e84-8fa8-6442603b8d50"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("a38f44bb-cf75-48b8-b053-1a5a69c7a694"), "Sydney.Kirlin@gmail.com", false, new Guid("a38f44bb-cf75-48b8-b053-1a5a69c7a694"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("a3d7dfce-2971-476f-b46e-d2a89d1361e2"), "Thora_Lesch31@gmail.com", false, new Guid("a3d7dfce-2971-476f-b46e-d2a89d1361e2"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("a3fcc2a7-362c-4ed5-a923-96cc6bef8220"), "Marcelle.Stark@hotmail.com", false, new Guid("a3fcc2a7-362c-4ed5-a923-96cc6bef8220"), new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075") },
                    { new Guid("a40e4784-f138-4321-a64b-db72c4333470"), "Rylan_OHara@hotmail.com", false, new Guid("a40e4784-f138-4321-a64b-db72c4333470"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("a42385e4-de7b-4838-8322-dd4eca0dcfea"), "Wilber.Pfannerstill37@gmail.com", false, new Guid("a42385e4-de7b-4838-8322-dd4eca0dcfea"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("a47404fa-01a2-4751-8fe3-2bf0b39dc170"), "Reilly.Wunsch39@yahoo.com", false, new Guid("a47404fa-01a2-4751-8fe3-2bf0b39dc170"), new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2") },
                    { new Guid("a4e8dd7f-f70f-4de2-bc7a-adf9fcec0b73"), "Daron.Schmidt@yahoo.com", false, new Guid("a4e8dd7f-f70f-4de2-bc7a-adf9fcec0b73"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("a508ab83-ddd9-434e-8438-fb276682e3cb"), "Timothy_Shanahan88@gmail.com", false, new Guid("a508ab83-ddd9-434e-8438-fb276682e3cb"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("a5230b46-bd82-48c1-91c8-5a5c46c4cfc8"), "Elouise30@yahoo.com", false, new Guid("a5230b46-bd82-48c1-91c8-5a5c46c4cfc8"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("a558e3a7-509c-4faf-a0ab-705d35ba966b"), "Hellen.OKeefe@hotmail.com", false, new Guid("a558e3a7-509c-4faf-a0ab-705d35ba966b"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("a55d0379-70b8-42bf-893a-328893e6dd36"), "Marc58@hotmail.com", false, new Guid("a55d0379-70b8-42bf-893a-328893e6dd36"), new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584") },
                    { new Guid("a5c748af-8015-44ad-b291-f8bb5766d605"), "Vilma63@hotmail.com", false, new Guid("a5c748af-8015-44ad-b291-f8bb5766d605"), new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b") },
                    { new Guid("a5eb317d-4e37-4325-b9a2-d8a9687ed54e"), "Shaun_Bayer@gmail.com", false, new Guid("a5eb317d-4e37-4325-b9a2-d8a9687ed54e"), new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("a637ff1f-73e6-44a1-b821-decf88e8d1a2"), "Aimee_Kris66@gmail.com", false, new Guid("a637ff1f-73e6-44a1-b821-decf88e8d1a2"), new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0") },
                    { new Guid("a6aab4cb-cd26-479e-b1a2-61e6e2297ed8"), "Rocio32@gmail.com", false, new Guid("a6aab4cb-cd26-479e-b1a2-61e6e2297ed8"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("a6e8cdd0-4a77-4d9f-ad9f-0d54f3de2ecb"), "Tanner_Bailey88@yahoo.com", false, new Guid("a6e8cdd0-4a77-4d9f-ad9f-0d54f3de2ecb"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("a7a684db-3143-412e-bfa5-de4bc92919a1"), "Olga_Hand48@yahoo.com", false, new Guid("a7a684db-3143-412e-bfa5-de4bc92919a1"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("a7cb25c6-e11c-44e1-91a7-2e0471a18511"), "Emanuel73@gmail.com", false, new Guid("a7cb25c6-e11c-44e1-91a7-2e0471a18511"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("a8103d50-ebdb-443e-925d-ab1a82b2e01b"), "Jaunita.Braun26@hotmail.com", false, new Guid("a8103d50-ebdb-443e-925d-ab1a82b2e01b"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("a85b9296-976d-4656-a33d-50a4caf1ef11"), "Aubrey_Towne34@yahoo.com", false, new Guid("a85b9296-976d-4656-a33d-50a4caf1ef11"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("a87b26d7-4a99-4806-aa7b-937e1c07d112"), "Jamarcus49@gmail.com", false, new Guid("a87b26d7-4a99-4806-aa7b-937e1c07d112"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("a8c042fb-4b59-4b49-b768-6271be32d653"), "Jerod.Nienow20@hotmail.com", false, new Guid("a8c042fb-4b59-4b49-b768-6271be32d653"), new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c") },
                    { new Guid("a8dbe83d-6b8d-4061-8082-8ebc49755cdd"), "Arvilla.Conn@hotmail.com", false, new Guid("a8dbe83d-6b8d-4061-8082-8ebc49755cdd"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("a8f2ab4c-1c34-43d3-9bbc-772087ee1cf9"), "Lia60@hotmail.com", false, new Guid("a8f2ab4c-1c34-43d3-9bbc-772087ee1cf9"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("a9475069-5048-49f9-a676-aadd6e1ee42b"), "Arnold37@gmail.com", false, new Guid("a9475069-5048-49f9-a676-aadd6e1ee42b"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("a957862c-b98a-434e-baa9-86aa34063ffe"), "Henry.Osinski@yahoo.com", false, new Guid("a957862c-b98a-434e-baa9-86aa34063ffe"), new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037") },
                    { new Guid("a9610122-8f6e-45b1-ae68-083d2fbd9efa"), "Lesley88@yahoo.com", false, new Guid("a9610122-8f6e-45b1-ae68-083d2fbd9efa"), new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33") },
                    { new Guid("a966d755-608c-4e0c-9a13-d0c07a2a2e00"), "Neva.Maggio37@yahoo.com", false, new Guid("a966d755-608c-4e0c-9a13-d0c07a2a2e00"), new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c") },
                    { new Guid("a98b74e5-b0f8-48f6-94bd-cd8988d5a863"), "Wilfredo_Davis@gmail.com", false, new Guid("a98b74e5-b0f8-48f6-94bd-cd8988d5a863"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("a9ab7888-90df-47cc-ae04-2eac13e3613d"), "Zola_Nolan@hotmail.com", false, new Guid("a9ab7888-90df-47cc-ae04-2eac13e3613d"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("aa3d716e-1bf6-40b4-9b42-1bd9e20a197f"), "Lon_Schumm@hotmail.com", false, new Guid("aa3d716e-1bf6-40b4-9b42-1bd9e20a197f"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("aa7f0594-ed27-4492-ba5a-2ec9d8bf4f38"), "Brooks.Schuppe@hotmail.com", false, new Guid("aa7f0594-ed27-4492-ba5a-2ec9d8bf4f38"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("ab1ae48a-f67c-494c-bc79-97b2b506927e"), "Abbey10@hotmail.com", false, new Guid("ab1ae48a-f67c-494c-bc79-97b2b506927e"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("ab89fd46-de3d-49bc-854c-54010b7f4433"), "Hugh_Casper56@gmail.com", false, new Guid("ab89fd46-de3d-49bc-854c-54010b7f4433"), new Guid("0462fe55-138a-4c03-a20d-8251dee6c206") },
                    { new Guid("ac131c98-f503-4794-9301-bfcb21a96495"), "Camila36@yahoo.com", false, new Guid("ac131c98-f503-4794-9301-bfcb21a96495"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("acc826fa-7c29-425a-853f-0256a0d9af5e"), "Harley59@gmail.com", false, new Guid("acc826fa-7c29-425a-853f-0256a0d9af5e"), new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4") },
                    { new Guid("ace6ec5c-d76f-4ac3-8a98-084f8c84b231"), "Myrtie.Sawayn@yahoo.com", false, new Guid("ace6ec5c-d76f-4ac3-8a98-084f8c84b231"), new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4") },
                    { new Guid("ad56bef0-83ac-4908-8102-aa9ff10bdda1"), "Shad12@hotmail.com", false, new Guid("ad56bef0-83ac-4908-8102-aa9ff10bdda1"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("ad57bcff-4f9f-4697-a2cf-202ad35cd0c7"), "Aurore_Murphy10@yahoo.com", false, new Guid("ad57bcff-4f9f-4697-a2cf-202ad35cd0c7"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("ad6d1d77-b280-44bf-bc7c-01c849ffe697"), "Rubye_Schoen@gmail.com", false, new Guid("ad6d1d77-b280-44bf-bc7c-01c849ffe697"), new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9") },
                    { new Guid("ae75dff6-8ff2-4a7b-8cba-6cfc170dc506"), "Brandon.Hackett74@gmail.com", false, new Guid("ae75dff6-8ff2-4a7b-8cba-6cfc170dc506"), new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5") },
                    { new Guid("aed12807-18a9-4f99-9466-f3618afa9e71"), "Jace5@hotmail.com", false, new Guid("aed12807-18a9-4f99-9466-f3618afa9e71"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("af7086df-c64c-4b98-a37c-9e77c3adb719"), "Davion.Olson60@gmail.com", false, new Guid("af7086df-c64c-4b98-a37c-9e77c3adb719"), new Guid("71725c06-aded-4994-8181-26d1683597c4") },
                    { new Guid("b0556fd4-342b-4886-86ef-870614db7d00"), "Amelie_Zboncak@hotmail.com", false, new Guid("b0556fd4-342b-4886-86ef-870614db7d00"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("b074d888-ebfd-421f-8b53-612856c2a3c1"), "Melody_Rath@yahoo.com", false, new Guid("b074d888-ebfd-421f-8b53-612856c2a3c1"), new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("b0c190f5-ae77-419c-91e3-7726d03a8887"), "Jillian_Zboncak@hotmail.com", false, new Guid("b0c190f5-ae77-419c-91e3-7726d03a8887"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("b0c19991-fe5c-4f58-94bb-6237055d31a1"), "Frederik93@yahoo.com", false, new Guid("b0c19991-fe5c-4f58-94bb-6237055d31a1"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("b10fba3d-c56b-489d-8b3e-6c1b50ca8ab0"), "Libbie_Heidenreich@hotmail.com", false, new Guid("b10fba3d-c56b-489d-8b3e-6c1b50ca8ab0"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("b1103b0c-7f96-4574-ba65-2461e1c248ae"), "Gerry_Stamm@gmail.com", false, new Guid("b1103b0c-7f96-4574-ba65-2461e1c248ae"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("b112baed-d198-4955-aaaf-e73f55a8a48a"), "Jamison.Hartmann81@hotmail.com", false, new Guid("b112baed-d198-4955-aaaf-e73f55a8a48a"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("b17e0167-f8df-4fe2-b17d-e383b6d18fac"), "Titus97@gmail.com", false, new Guid("b17e0167-f8df-4fe2-b17d-e383b6d18fac"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("b1cc5fba-0deb-4b96-837c-5f63af41da2e"), "Danika.Hand@gmail.com", false, new Guid("b1cc5fba-0deb-4b96-837c-5f63af41da2e"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("b1e4a920-460e-40ee-aef1-eaa6b4821d67"), "Ida_Hahn@gmail.com", false, new Guid("b1e4a920-460e-40ee-aef1-eaa6b4821d67"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("b251ecd4-b225-46bf-83b1-bee0d6bafc9a"), "Carlee_Flatley@yahoo.com", false, new Guid("b251ecd4-b225-46bf-83b1-bee0d6bafc9a"), new Guid("ececce7b-505c-4bc7-b969-56ffcc451462") },
                    { new Guid("b25d31c3-6254-4505-aa56-36a42742bf34"), "Dessie_Zboncak71@yahoo.com", false, new Guid("b25d31c3-6254-4505-aa56-36a42742bf34"), new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828") },
                    { new Guid("b29fa58a-4409-4567-bbc1-6abc716573ca"), "Garret.Keebler88@hotmail.com", false, new Guid("b29fa58a-4409-4567-bbc1-6abc716573ca"), new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("b32d5a89-8fe2-4d2b-b47e-53c404eb40f5"), "Wendy_Kunde@yahoo.com", false, new Guid("b32d5a89-8fe2-4d2b-b47e-53c404eb40f5"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("b369f525-c169-48ba-8072-893b1e552c54"), "Emely.Champlin48@hotmail.com", false, new Guid("b369f525-c169-48ba-8072-893b1e552c54"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("b39b507b-5954-4a4f-9047-dd66209c741d"), "Ryann90@hotmail.com", false, new Guid("b39b507b-5954-4a4f-9047-dd66209c741d"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("b3a1576e-6786-47f2-a831-ca5fd64572df"), "Chase_Lakin99@yahoo.com", false, new Guid("b3a1576e-6786-47f2-a831-ca5fd64572df"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("b3d22ef9-89f5-4c60-9e8f-6828f662ad5a"), "Brenna57@gmail.com", false, new Guid("b3d22ef9-89f5-4c60-9e8f-6828f662ad5a"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("b425ab74-13ad-4898-85f1-ebd289653a01"), "Eriberto_Kuphal@gmail.com", false, new Guid("b425ab74-13ad-4898-85f1-ebd289653a01"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("b44c98cb-6a9e-47cd-96f7-fa6190033f21"), "Kaylee15@yahoo.com", false, new Guid("b44c98cb-6a9e-47cd-96f7-fa6190033f21"), new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa") },
                    { new Guid("b456133a-5fb1-423f-9356-f2a879d3784a"), "Kiera64@hotmail.com", false, new Guid("b456133a-5fb1-423f-9356-f2a879d3784a"), new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("b4a85c34-b1da-4866-8aae-c670f6d27083"), "Keshawn.McClure@hotmail.com", false, new Guid("b4a85c34-b1da-4866-8aae-c670f6d27083"), new Guid("35b6c210-2256-41cd-af8e-e815527e0a84") },
                    { new Guid("b4b1ed7c-5979-40b7-85ab-5be55596abde"), "Layla.Lowe86@gmail.com", false, new Guid("b4b1ed7c-5979-40b7-85ab-5be55596abde"), new Guid("d422e4b4-5d7b-484f-830c-319350a69b22") },
                    { new Guid("b4d976ca-be66-44ce-a616-02502132a306"), "Elda.Schneider9@gmail.com", false, new Guid("b4d976ca-be66-44ce-a616-02502132a306"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("b514d253-6c9a-4909-93b3-7b4df08c8cfb"), "Ali.Bins62@gmail.com", false, new Guid("b514d253-6c9a-4909-93b3-7b4df08c8cfb"), new Guid("12656ae7-3922-41ca-b159-f79b439a354c") },
                    { new Guid("b52d1460-232d-4689-82cb-c6dc027203ba"), "Dean_Paucek@hotmail.com", false, new Guid("b52d1460-232d-4689-82cb-c6dc027203ba"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("b54d67f5-a1d5-4be5-83c8-56c64c8efe9a"), "Tomas.Jacobs9@hotmail.com", false, new Guid("b54d67f5-a1d5-4be5-83c8-56c64c8efe9a"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("b59fae13-86ff-482d-b4ce-4fbb9f758075"), "Santiago.Buckridge@yahoo.com", false, new Guid("b59fae13-86ff-482d-b4ce-4fbb9f758075"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("b5dd521c-0830-477a-9818-089a2e5ccd01"), "Dustin.Rutherford57@hotmail.com", false, new Guid("b5dd521c-0830-477a-9818-089a2e5ccd01"), new Guid("665af7ab-85d3-48f3-bedd-30db54699f81") },
                    { new Guid("b6c1301f-f96e-4565-b951-51b4b69af7e0"), "Destany98@gmail.com", false, new Guid("b6c1301f-f96e-4565-b951-51b4b69af7e0"), new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("b75de6da-d50a-4246-b2ba-53e40a9837b2"), "Jamison_Jones@hotmail.com", false, new Guid("b75de6da-d50a-4246-b2ba-53e40a9837b2"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("b76d6ce3-1e84-4969-bbb5-9fdb12bbfedb"), "Jasper.Wisozk11@yahoo.com", false, new Guid("b76d6ce3-1e84-4969-bbb5-9fdb12bbfedb"), new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4") },
                    { new Guid("b7e38553-b663-4d59-a5e8-7a0c0828012a"), "Destiny_Schaden@hotmail.com", false, new Guid("b7e38553-b663-4d59-a5e8-7a0c0828012a"), new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272") },
                    { new Guid("b89ba95e-5494-468a-9d40-98d417b9a31e"), "Edmund_Adams@yahoo.com", false, new Guid("b89ba95e-5494-468a-9d40-98d417b9a31e"), new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7") },
                    { new Guid("b8f4d840-8f34-4675-8ba5-ce959567ecfa"), "Granville.Medhurst@yahoo.com", false, new Guid("b8f4d840-8f34-4675-8ba5-ce959567ecfa"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("b933e667-73bc-4bb1-baec-8776495b619e"), "Lloyd.Schoen@hotmail.com", false, new Guid("b933e667-73bc-4bb1-baec-8776495b619e"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("b96f86e2-49fe-4ff2-9aa3-e47e6794bc9b"), "Felipe34@yahoo.com", false, new Guid("b96f86e2-49fe-4ff2-9aa3-e47e6794bc9b"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("ba383827-7d9e-476a-b795-d4576352ffdb"), "Horace.Hansen@hotmail.com", false, new Guid("ba383827-7d9e-476a-b795-d4576352ffdb"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("ba56ec41-4824-4ea2-958b-fbdcf776a1dc"), "Rubie_Quigley@hotmail.com", false, new Guid("ba56ec41-4824-4ea2-958b-fbdcf776a1dc"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("bab1bc47-9271-493f-b760-20158ce5e210"), "Cortez18@hotmail.com", false, new Guid("bab1bc47-9271-493f-b760-20158ce5e210"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("bb76334b-bb49-48e4-a132-bb8686359750"), "Brionna_Weber@yahoo.com", false, new Guid("bb76334b-bb49-48e4-a132-bb8686359750"), new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa") },
                    { new Guid("bba92b19-55e9-4bdd-a9de-458d6d82a4d9"), "Florian.Becker@hotmail.com", false, new Guid("bba92b19-55e9-4bdd-a9de-458d6d82a4d9"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("bc5abafc-db0e-4a90-8cea-735be49bdd59"), "Jeanette16@yahoo.com", false, new Guid("bc5abafc-db0e-4a90-8cea-735be49bdd59"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("bc66b149-26a5-4c0e-9a71-2d5b2649b0c7"), "Elmore.Bahringer@yahoo.com", false, new Guid("bc66b149-26a5-4c0e-9a71-2d5b2649b0c7"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("bcb98242-b422-4eb2-acfe-a4ce00639bd5"), "Reina17@gmail.com", false, new Guid("bcb98242-b422-4eb2-acfe-a4ce00639bd5"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("bce9495a-4a9e-4bb1-ba02-88d10ec90910"), "Abigayle85@yahoo.com", false, new Guid("bce9495a-4a9e-4bb1-ba02-88d10ec90910"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("bd36d11d-1330-4dbb-b238-f4a56532365c"), "Tyree.Sawayn@gmail.com", false, new Guid("bd36d11d-1330-4dbb-b238-f4a56532365c"), new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("bd451066-bf42-4879-9577-ae16e544f62d"), "Alda87@gmail.com", false, new Guid("bd451066-bf42-4879-9577-ae16e544f62d"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("bd625c93-b361-4491-a812-2f47be437e6a"), "Kamron.Brekke47@yahoo.com", false, new Guid("bd625c93-b361-4491-a812-2f47be437e6a"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("bdbde605-c658-4579-b16b-40f0b9b5d126"), "Wyatt_Smith@hotmail.com", false, new Guid("bdbde605-c658-4579-b16b-40f0b9b5d126"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("bdd64cf6-7a9b-4bea-9d37-4c835a10fc3e"), "Alysha_Halvorson@hotmail.com", false, new Guid("bdd64cf6-7a9b-4bea-9d37-4c835a10fc3e"), new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899") },
                    { new Guid("be49c3fd-f7b1-448d-8c44-9f3abbcb3733"), "Taya.Bartoletti37@gmail.com", false, new Guid("be49c3fd-f7b1-448d-8c44-9f3abbcb3733"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("be879f2b-635e-4505-8480-a4aa678c074f"), "Rosalia.Fay@hotmail.com", false, new Guid("be879f2b-635e-4505-8480-a4aa678c074f"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("bea653c2-a6e8-4147-9481-876a90bdf8c9"), "Lamar98@yahoo.com", false, new Guid("bea653c2-a6e8-4147-9481-876a90bdf8c9"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("bea6b3c8-4a63-49bd-b03b-bfb94c9fdc16"), "Della52@gmail.com", false, new Guid("bea6b3c8-4a63-49bd-b03b-bfb94c9fdc16"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("beac2b8a-566a-4d4f-9d30-89af9c328ad1"), "Ebba11@hotmail.com", false, new Guid("beac2b8a-566a-4d4f-9d30-89af9c328ad1"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("bed00f98-94b0-42db-ad6b-36f95ab2b4e4"), "Teagan.Williamson98@gmail.com", false, new Guid("bed00f98-94b0-42db-ad6b-36f95ab2b4e4"), new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473") },
                    { new Guid("c0548ee8-da61-437c-8d72-45e7e9240e20"), "Anastacio.Hilpert36@gmail.com", false, new Guid("c0548ee8-da61-437c-8d72-45e7e9240e20"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("c14ed672-c943-4e24-8f63-e0cee00c2ebd"), "Madie_Mosciski@hotmail.com", false, new Guid("c14ed672-c943-4e24-8f63-e0cee00c2ebd"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("c18652e4-1853-40eb-811c-d69039067d05"), "Lisa_Beahan@hotmail.com", false, new Guid("c18652e4-1853-40eb-811c-d69039067d05"), new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("c189ca21-62d2-42fb-bb6f-4de4c24b667d"), "Hassan.Miller@yahoo.com", false, new Guid("c189ca21-62d2-42fb-bb6f-4de4c24b667d"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("c1d27185-a999-4410-8058-40e8215be07e"), "Wilhelm_Vandervort@yahoo.com", false, new Guid("c1d27185-a999-4410-8058-40e8215be07e"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("c220826e-32be-40ba-9faf-d20a5188f3d7"), "Leslie_Mayert22@yahoo.com", false, new Guid("c220826e-32be-40ba-9faf-d20a5188f3d7"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("c25639b8-d1d0-423b-acfb-edc65c2bc5c0"), "Miguel_Leuschke@gmail.com", false, new Guid("c25639b8-d1d0-423b-acfb-edc65c2bc5c0"), new Guid("a11d6609-e768-4189-bd78-5b34d82849e6") },
                    { new Guid("c2569bd7-790e-4769-a4b7-1593bace5666"), "Rachel_Wolff@yahoo.com", false, new Guid("c2569bd7-790e-4769-a4b7-1593bace5666"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("c271a365-b3be-4675-bec4-df4656a54c20"), "Ariane.Schimmel@gmail.com", false, new Guid("c271a365-b3be-4675-bec4-df4656a54c20"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("c30aeb9a-0081-4528-8d3d-41d8ca91993d"), "Nona_Botsford1@gmail.com", false, new Guid("c30aeb9a-0081-4528-8d3d-41d8ca91993d"), new Guid("0823436c-27ad-4402-b5e2-b17efa08505e") },
                    { new Guid("c40765c7-e3a9-4994-b195-411c191faeda"), "Westley76@gmail.com", false, new Guid("c40765c7-e3a9-4994-b195-411c191faeda"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("c489789a-4e7a-472e-a823-f8697a8466a5"), "Courtney.Treutel@gmail.com", false, new Guid("c489789a-4e7a-472e-a823-f8697a8466a5"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("c4e89a98-1924-4771-a624-d440739f46e8"), "Annette_Yost@hotmail.com", false, new Guid("c4e89a98-1924-4771-a624-d440739f46e8"), new Guid("cfddcc04-5205-447d-9799-6d1945c391b4") },
                    { new Guid("c534ac84-1293-4d86-8e59-5cda94e9ee88"), "Ova61@yahoo.com", false, new Guid("c534ac84-1293-4d86-8e59-5cda94e9ee88"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("c5c3deb4-42c7-4ca3-ab84-1ee71ec0175d"), "Edmond.Quitzon38@yahoo.com", false, new Guid("c5c3deb4-42c7-4ca3-ab84-1ee71ec0175d"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("c5db7c51-c8d3-42a7-807c-7b6b525eb454"), "Leonardo.Crona@hotmail.com", false, new Guid("c5db7c51-c8d3-42a7-807c-7b6b525eb454"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("c60fa50b-9a03-4c9b-a6e0-c9b30414aa6b"), "Alford39@yahoo.com", false, new Guid("c60fa50b-9a03-4c9b-a6e0-c9b30414aa6b"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("c631dfb9-a6ec-4ca1-bba6-54356afe1155"), "Nelson_OKeefe4@gmail.com", false, new Guid("c631dfb9-a6ec-4ca1-bba6-54356afe1155"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("c6389934-3236-438d-96f2-b7b5808d1b83"), "Jasen.Stoltenberg@yahoo.com", false, new Guid("c6389934-3236-438d-96f2-b7b5808d1b83"), new Guid("05d888a7-8474-4565-b751-a89df2400346") },
                    { new Guid("c65233c2-ceca-4684-8b29-f769b1e2fcc0"), "Sabrina.Erdman55@hotmail.com", false, new Guid("c65233c2-ceca-4684-8b29-f769b1e2fcc0"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("c85136b2-83fc-4aa2-b1d5-8a4f9f4bb1e8"), "Cassandra_Kuhic@gmail.com", false, new Guid("c85136b2-83fc-4aa2-b1d5-8a4f9f4bb1e8"), new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4") },
                    { new Guid("c86c2331-6b5e-40f0-b2c6-88e1c7303bd1"), "Cletus97@hotmail.com", false, new Guid("c86c2331-6b5e-40f0-b2c6-88e1c7303bd1"), new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420") },
                    { new Guid("c896a8a8-7c3b-41f6-b009-f73566030cc9"), "Keanu.OReilly@yahoo.com", false, new Guid("c896a8a8-7c3b-41f6-b009-f73566030cc9"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("c9463e72-ea62-43c6-bf0e-8e596d379e75"), "Omari_Howell19@yahoo.com", false, new Guid("c9463e72-ea62-43c6-bf0e-8e596d379e75"), new Guid("f7e86b66-49eb-4774-82be-b008350dc98b") },
                    { new Guid("c982dfa4-dcfc-4228-bfc3-b021fef4dc87"), "Helena41@yahoo.com", false, new Guid("c982dfa4-dcfc-4228-bfc3-b021fef4dc87"), new Guid("314374c4-1bd7-4eda-8546-58617e464254") },
                    { new Guid("c98b2692-9c57-4001-8c27-270cb7659ac4"), "Mona_OKeefe@hotmail.com", false, new Guid("c98b2692-9c57-4001-8c27-270cb7659ac4"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("ca298b66-fb13-4db9-994b-cf28f48c0612"), "Flossie_Bins80@hotmail.com", false, new Guid("ca298b66-fb13-4db9-994b-cf28f48c0612"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("ca3b5eba-9d4c-4a21-8626-8676f6419b90"), "Jamil_Ullrich44@yahoo.com", false, new Guid("ca3b5eba-9d4c-4a21-8626-8676f6419b90"), new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63") },
                    { new Guid("ca8be4ef-5a60-41b1-b9d4-31a7fb05c59d"), "Brooke.Kutch@yahoo.com", false, new Guid("ca8be4ef-5a60-41b1-b9d4-31a7fb05c59d"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("cac614a8-282e-4e72-b1b3-1caf9e184472"), "Larue_Rohan40@yahoo.com", false, new Guid("cac614a8-282e-4e72-b1b3-1caf9e184472"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("cac78fe0-ff77-451a-8bd3-e1f6dcbb629e"), "Wilton41@gmail.com", false, new Guid("cac78fe0-ff77-451a-8bd3-e1f6dcbb629e"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("cb17baa8-fbdf-49c3-ab16-31a97f5b9bb8"), "Nannie25@hotmail.com", false, new Guid("cb17baa8-fbdf-49c3-ab16-31a97f5b9bb8"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("cb3cd017-b1b3-4e3d-9b98-b9cf85623dc4"), "Elias49@yahoo.com", false, new Guid("cb3cd017-b1b3-4e3d-9b98-b9cf85623dc4"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("cb5d5ab2-835e-40d9-a1a1-2e902f4f228d"), "Davonte73@hotmail.com", false, new Guid("cb5d5ab2-835e-40d9-a1a1-2e902f4f228d"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("cb8493e1-f5cf-4267-b980-7f71a53f328a"), "Dudley_Hansen@gmail.com", false, new Guid("cb8493e1-f5cf-4267-b980-7f71a53f328a"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("cbae0508-26e9-4c93-bf05-285a7f9f988b"), "Erica.Legros0@hotmail.com", false, new Guid("cbae0508-26e9-4c93-bf05-285a7f9f988b"), new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977") },
                    { new Guid("cbdab909-6cd4-497b-ae06-512f20dec8f7"), "Emmalee_Wyman16@gmail.com", false, new Guid("cbdab909-6cd4-497b-ae06-512f20dec8f7"), new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d") },
                    { new Guid("cbdcd378-06c5-4ef0-a13c-c3128ffe1350"), "Samson84@gmail.com", false, new Guid("cbdcd378-06c5-4ef0-a13c-c3128ffe1350"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("cbf4b18d-192c-4f82-a3b8-0a3f22e4f506"), "Kali.Cartwright75@hotmail.com", false, new Guid("cbf4b18d-192c-4f82-a3b8-0a3f22e4f506"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("cc54affd-4502-4503-a066-6d1e15a5d999"), "Dean68@gmail.com", false, new Guid("cc54affd-4502-4503-a066-6d1e15a5d999"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("cc8b5d55-274b-4298-ac8f-528fa68fba94"), "Otilia_Jerde72@hotmail.com", false, new Guid("cc8b5d55-274b-4298-ac8f-528fa68fba94"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("ccae3905-f99c-4b2a-b109-bb11e55b1ca8"), "Ora.Reichel98@hotmail.com", false, new Guid("ccae3905-f99c-4b2a-b109-bb11e55b1ca8"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("ccb690ae-1e9a-4498-84eb-29d9273e8840"), "Payton.Weber31@yahoo.com", false, new Guid("ccb690ae-1e9a-4498-84eb-29d9273e8840"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("ccd909b0-33dc-4a7f-b3db-eef1a6cb4554"), "Esmeralda16@hotmail.com", false, new Guid("ccd909b0-33dc-4a7f-b3db-eef1a6cb4554"), new Guid("f7720de3-aaea-48e9-af48-569af731d90b") },
                    { new Guid("ccdd25fc-8e59-4087-807b-2e073eaa8a36"), "Princess.Flatley51@gmail.com", false, new Guid("ccdd25fc-8e59-4087-807b-2e073eaa8a36"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("cd0af6f3-468e-4a57-94e5-11922c6a8f3c"), "Vivian.Cummerata28@hotmail.com", false, new Guid("cd0af6f3-468e-4a57-94e5-11922c6a8f3c"), new Guid("8987fd2f-b286-41d7-9544-b355355a2cff") },
                    { new Guid("cd340c14-0aec-4047-8b5a-0808ea6ddf8d"), "Delphine37@hotmail.com", false, new Guid("cd340c14-0aec-4047-8b5a-0808ea6ddf8d"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("cd422b5b-38d9-4e0e-a501-d2e7704c478f"), "Vladimir17@gmail.com", false, new Guid("cd422b5b-38d9-4e0e-a501-d2e7704c478f"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("cd432420-8e8e-4418-81e7-f936879bfd11"), "Thora.Hirthe20@hotmail.com", false, new Guid("cd432420-8e8e-4418-81e7-f936879bfd11"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("cda5397f-c8ed-4399-8ccb-fcc360caed33"), "Garnet.Bergstrom91@hotmail.com", false, new Guid("cda5397f-c8ed-4399-8ccb-fcc360caed33"), new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26") },
                    { new Guid("cdd562e7-c670-4950-b944-e8ba1ded7bfc"), "Jeromy83@yahoo.com", false, new Guid("cdd562e7-c670-4950-b944-e8ba1ded7bfc"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("ce4c6d8e-0919-4c5a-a617-23c0c8f4b0b7"), "Deja72@gmail.com", false, new Guid("ce4c6d8e-0919-4c5a-a617-23c0c8f4b0b7"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("ce4f6248-d35f-4aa4-8295-8419e9b284a5"), "Cordia12@gmail.com", false, new Guid("ce4f6248-d35f-4aa4-8295-8419e9b284a5"), new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0") },
                    { new Guid("ce523b5a-c29e-4344-98cf-21fa6c8c2018"), "Natasha_Zieme95@yahoo.com", false, new Guid("ce523b5a-c29e-4344-98cf-21fa6c8c2018"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("ceaaf7df-46b4-46fc-bfd0-8116018cca00"), "Taylor84@gmail.com", false, new Guid("ceaaf7df-46b4-46fc-bfd0-8116018cca00"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("cef3e8ce-6a7c-4eaa-ab4f-626b59ffa6ef"), "Nasir_Herzog62@hotmail.com", false, new Guid("cef3e8ce-6a7c-4eaa-ab4f-626b59ffa6ef"), new Guid("83c8f958-a3f1-448d-bad0-048533827e0e") },
                    { new Guid("cf23584e-8149-4e31-ae89-f7b6668991e5"), "Herta_Torp68@gmail.com", false, new Guid("cf23584e-8149-4e31-ae89-f7b6668991e5"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("cf297b71-fb80-4c03-b66d-cca7b367b71e"), "Mervin.Howell@gmail.com", false, new Guid("cf297b71-fb80-4c03-b66d-cca7b367b71e"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("cf2ccb3f-ed63-4828-b435-bf624ceebb06"), "Anjali.Botsford@gmail.com", false, new Guid("cf2ccb3f-ed63-4828-b435-bf624ceebb06"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("cf57dd91-cb89-4d3b-9be9-8450d8ea7039"), "Logan98@gmail.com", false, new Guid("cf57dd91-cb89-4d3b-9be9-8450d8ea7039"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("cffaceed-f740-435b-9db9-f0ef2cb15a65"), "Eino88@gmail.com", false, new Guid("cffaceed-f740-435b-9db9-f0ef2cb15a65"), new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869") },
                    { new Guid("d0a72e2c-8beb-445b-88eb-cd3c70d55a45"), "Buddy68@hotmail.com", false, new Guid("d0a72e2c-8beb-445b-88eb-cd3c70d55a45"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("d0cfb6f1-eb7c-4f52-b8bb-f0aa1f2ce9d8"), "Hailie_Franecki73@gmail.com", false, new Guid("d0cfb6f1-eb7c-4f52-b8bb-f0aa1f2ce9d8"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("d1208058-9731-4294-bf5d-2a1fa289896b"), "Leola12@yahoo.com", false, new Guid("d1208058-9731-4294-bf5d-2a1fa289896b"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("d1370454-e152-4d2b-b0eb-a0ff821066d1"), "Aaron.Reichert35@gmail.com", false, new Guid("d1370454-e152-4d2b-b0eb-a0ff821066d1"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("d1821954-c923-4ba1-a141-0e436155581b"), "Asa37@gmail.com", false, new Guid("d1821954-c923-4ba1-a141-0e436155581b"), new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("d1d264f9-7901-4b66-a325-340363ec0772"), "Angel_Daniel@hotmail.com", false, new Guid("d1d264f9-7901-4b66-a325-340363ec0772"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("d1deed48-9fc9-457d-8b31-3a1a6c18a815"), "Fernando97@yahoo.com", false, new Guid("d1deed48-9fc9-457d-8b31-3a1a6c18a815"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("d3314168-a430-4f11-b39d-1417bb861ec6"), "Tess.Metz60@gmail.com", false, new Guid("d3314168-a430-4f11-b39d-1417bb861ec6"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("d3d886fd-f5b1-474a-9400-0a03ddfac4bd"), "Augustine.Medhurst@gmail.com", false, new Guid("d3d886fd-f5b1-474a-9400-0a03ddfac4bd"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("d4011814-8b63-48eb-b5e6-f486c5c42144"), "Joaquin.Lemke49@gmail.com", false, new Guid("d4011814-8b63-48eb-b5e6-f486c5c42144"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("d44c39d8-1b6a-45ad-9a62-8560c82f5197"), "Kiley75@gmail.com", false, new Guid("d44c39d8-1b6a-45ad-9a62-8560c82f5197"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("d4a15811-c6a9-4d3f-bb80-0a470f2a8e3c"), "Nikki.Hickle85@hotmail.com", false, new Guid("d4a15811-c6a9-4d3f-bb80-0a470f2a8e3c"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("d4bf094a-8089-4768-ac31-d69491b68ec2"), "Georgianna13@hotmail.com", false, new Guid("d4bf094a-8089-4768-ac31-d69491b68ec2"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("d55d7ed6-f602-4ce0-9f8d-7ee40fa4ddeb"), "Angelica_Murray@yahoo.com", false, new Guid("d55d7ed6-f602-4ce0-9f8d-7ee40fa4ddeb"), new Guid("08e83522-0abb-4778-9027-c86ca1a0a624") },
                    { new Guid("d57f962c-c7e5-4978-9d28-3e85ecb6615f"), "Gilberto.Paucek@gmail.com", false, new Guid("d57f962c-c7e5-4978-9d28-3e85ecb6615f"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("d584427b-8073-406c-baec-f33b1a894430"), "Electa0@yahoo.com", false, new Guid("d584427b-8073-406c-baec-f33b1a894430"), new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d") },
                    { new Guid("d5e17f23-c16d-422d-8357-f696c34f4b9a"), "Favian52@hotmail.com", false, new Guid("d5e17f23-c16d-422d-8357-f696c34f4b9a"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("d61e05e4-413d-490f-80d9-55ecd7cb9658"), "Keagan_Mayert@yahoo.com", false, new Guid("d61e05e4-413d-490f-80d9-55ecd7cb9658"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("d6282370-5946-4923-a720-36dc8f990720"), "Veda.Donnelly28@gmail.com", false, new Guid("d6282370-5946-4923-a720-36dc8f990720"), new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376") },
                    { new Guid("d72c1832-3bcb-49ec-a126-f80317567cae"), "Kelley.Green@gmail.com", false, new Guid("d72c1832-3bcb-49ec-a126-f80317567cae"), new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03") },
                    { new Guid("d78f96f5-eac5-4294-9471-e1e656251ae2"), "Wellington64@hotmail.com", false, new Guid("d78f96f5-eac5-4294-9471-e1e656251ae2"), new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456") },
                    { new Guid("d818bcb1-e79a-4dac-9a67-d3b46c3c9093"), "Ronaldo.Klocko29@gmail.com", false, new Guid("d818bcb1-e79a-4dac-9a67-d3b46c3c9093"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("d8ce5150-c5ce-436d-9c56-e399ddd6772d"), "Rory.Paucek4@gmail.com", false, new Guid("d8ce5150-c5ce-436d-9c56-e399ddd6772d"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("d8f3320c-372c-44a3-806f-8339753eed43"), "Burnice_Boyle27@hotmail.com", false, new Guid("d8f3320c-372c-44a3-806f-8339753eed43"), new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7") },
                    { new Guid("d8faf630-9f0e-4802-bbe5-818b7f002d9e"), "Augustine29@gmail.com", false, new Guid("d8faf630-9f0e-4802-bbe5-818b7f002d9e"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("d8fb7a49-ad52-4eee-9bf1-d69858a85335"), "Leann_Turner11@gmail.com", false, new Guid("d8fb7a49-ad52-4eee-9bf1-d69858a85335"), new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4") },
                    { new Guid("d91596e5-be3c-4dd6-a2c4-0b78f1fbb69d"), "Mackenzie.Ziemann62@hotmail.com", false, new Guid("d91596e5-be3c-4dd6-a2c4-0b78f1fbb69d"), new Guid("c0886dea-4971-4369-8d28-75754e2575d0") },
                    { new Guid("d980b883-06d7-490c-b4d6-048fb74a2b89"), "Alf.Fritsch@gmail.com", false, new Guid("d980b883-06d7-490c-b4d6-048fb74a2b89"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("da440a03-2518-4df7-ac15-8ecd749fb1f5"), "Angel54@yahoo.com", false, new Guid("da440a03-2518-4df7-ac15-8ecd749fb1f5"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("da7b355a-e617-48c6-ae45-04a8df0b6996"), "Billy_Johns@yahoo.com", false, new Guid("da7b355a-e617-48c6-ae45-04a8df0b6996"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("dad03dba-88cf-4b56-995c-a243c5118c3e"), "Gloria.Mertz@hotmail.com", false, new Guid("dad03dba-88cf-4b56-995c-a243c5118c3e"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("db6197a8-c15a-4616-a1d3-d6617a7da939"), "Dexter.OConner32@hotmail.com", false, new Guid("db6197a8-c15a-4616-a1d3-d6617a7da939"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("db8c2775-7901-47e3-b3cc-463e8e4a4b7b"), "Stephany27@yahoo.com", false, new Guid("db8c2775-7901-47e3-b3cc-463e8e4a4b7b"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("dbb9849e-6ca6-430f-87d0-68968894a4f3"), "Lillie_Johnson39@gmail.com", false, new Guid("dbb9849e-6ca6-430f-87d0-68968894a4f3"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("dc412a3a-42b6-4034-ae66-a4731159f748"), "Monica_Jakubowski@yahoo.com", false, new Guid("dc412a3a-42b6-4034-ae66-a4731159f748"), new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6") },
                    { new Guid("dd24a619-59fe-4860-8014-21cf020e2388"), "Tara.Jaskolski@gmail.com", false, new Guid("dd24a619-59fe-4860-8014-21cf020e2388"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("dd8f8cdc-aa68-4b32-9057-5c1d610db5cd"), "Allen92@gmail.com", false, new Guid("dd8f8cdc-aa68-4b32-9057-5c1d610db5cd"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("dd9fc607-9ffb-4248-9a63-0d760aa264c1"), "Zachariah.Collins56@hotmail.com", false, new Guid("dd9fc607-9ffb-4248-9a63-0d760aa264c1"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("de3d8658-43bc-41f7-b359-ddd8df04358a"), "Eve.Stanton66@hotmail.com", false, new Guid("de3d8658-43bc-41f7-b359-ddd8df04358a"), new Guid("f7720de3-aaea-48e9-af48-569af731d90b") },
                    { new Guid("de6ffe32-1d0b-4787-8299-b8750295a31d"), "Eldora77@hotmail.com", false, new Guid("de6ffe32-1d0b-4787-8299-b8750295a31d"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("de87f589-f981-40d6-933d-df383aeb8428"), "Estell24@yahoo.com", false, new Guid("de87f589-f981-40d6-933d-df383aeb8428"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("df30ba15-a601-4b25-b3bf-ecc9d040a9cd"), "Levi.Gleichner@yahoo.com", false, new Guid("df30ba15-a601-4b25-b3bf-ecc9d040a9cd"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("df7ba852-f3cd-4231-8cda-d8b6c12282a4"), "Orion75@hotmail.com", false, new Guid("df7ba852-f3cd-4231-8cda-d8b6c12282a4"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("e055f91b-f6f5-44ea-86ca-8e7278e0267f"), "Shawn3@gmail.com", false, new Guid("e055f91b-f6f5-44ea-86ca-8e7278e0267f"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("e0dcdd67-7575-4d5c-9f32-64386bdf7383"), "Joy_Barrows@gmail.com", false, new Guid("e0dcdd67-7575-4d5c-9f32-64386bdf7383"), new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab") },
                    { new Guid("e167c8ab-351c-4e1b-9f0a-916ec24de1ed"), "Laverne_Hayes27@hotmail.com", false, new Guid("e167c8ab-351c-4e1b-9f0a-916ec24de1ed"), new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403") },
                    { new Guid("e1f0d3ad-d7c1-4c40-b3b1-de78680bb473"), "Bonnie_Terry@yahoo.com", false, new Guid("e1f0d3ad-d7c1-4c40-b3b1-de78680bb473"), new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977") },
                    { new Guid("e1fe48ed-f7c9-4e8c-b27c-e624136a7c20"), "Hermina_Lueilwitz@gmail.com", false, new Guid("e1fe48ed-f7c9-4e8c-b27c-e624136a7c20"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("e20a4b05-f562-4f08-859d-3881bc4fcb5d"), "Reba_Abbott30@hotmail.com", false, new Guid("e20a4b05-f562-4f08-859d-3881bc4fcb5d"), new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6") },
                    { new Guid("e22b3771-f7fd-4c4d-80d8-24d099c6a785"), "Laney86@hotmail.com", false, new Guid("e22b3771-f7fd-4c4d-80d8-24d099c6a785"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("e2b312f7-fccd-4795-9e00-7a2d7e9126ed"), "Rowland.Howell32@gmail.com", false, new Guid("e2b312f7-fccd-4795-9e00-7a2d7e9126ed"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("e2cdf723-3830-4839-b5c3-9bd77c5e37a4"), "Neoma_Kuvalis97@hotmail.com", false, new Guid("e2cdf723-3830-4839-b5c3-9bd77c5e37a4"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("e3318f04-36ed-4936-9cea-dd7c2e704fbc"), "Randy.Runolfsdottir54@gmail.com", false, new Guid("e3318f04-36ed-4936-9cea-dd7c2e704fbc"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("e33c9906-5973-4023-b4f3-5c354a72238c"), "Jerod_Denesik@hotmail.com", false, new Guid("e33c9906-5973-4023-b4f3-5c354a72238c"), new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("e37d59c8-4965-4760-b7e2-b06f79e502e4"), "Jessika_Jenkins@hotmail.com", false, new Guid("e37d59c8-4965-4760-b7e2-b06f79e502e4"), new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df") },
                    { new Guid("e48df537-bf6e-42f5-a0f2-a06a86b86124"), "Holden30@hotmail.com", false, new Guid("e48df537-bf6e-42f5-a0f2-a06a86b86124"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("e4bf6c1a-1c78-4ebd-b3fe-6b52a14ed5a2"), "Aryanna_Bailey37@gmail.com", false, new Guid("e4bf6c1a-1c78-4ebd-b3fe-6b52a14ed5a2"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("e51064c9-2156-4f4d-bd11-11869d106712"), "Lenny47@hotmail.com", false, new Guid("e51064c9-2156-4f4d-bd11-11869d106712"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("e577a02b-bab1-4917-af52-558d0731b4dd"), "Marlin_Mann@hotmail.com", false, new Guid("e577a02b-bab1-4917-af52-558d0731b4dd"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("e5a080c2-a79e-4949-a297-f8095aa74f6e"), "Joel.Barton1@gmail.com", false, new Guid("e5a080c2-a79e-4949-a297-f8095aa74f6e"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("e5aa7fc8-ca1d-4ac3-a6cc-71687665e4fb"), "Gloria_Waelchi@gmail.com", false, new Guid("e5aa7fc8-ca1d-4ac3-a6cc-71687665e4fb"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("e5dd97c0-d968-4737-9a13-8f39bc59e107"), "Diamond.Kihn@yahoo.com", false, new Guid("e5dd97c0-d968-4737-9a13-8f39bc59e107"), new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6") },
                    { new Guid("e680f6bc-4a89-4450-8ff8-2ac51a88e83f"), "Kendra.Crist38@yahoo.com", false, new Guid("e680f6bc-4a89-4450-8ff8-2ac51a88e83f"), new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88") },
                    { new Guid("e6b9877e-85fd-4a16-8741-3152b1538139"), "Savion83@gmail.com", false, new Guid("e6b9877e-85fd-4a16-8741-3152b1538139"), new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374") },
                    { new Guid("e742018d-0d09-4154-9afe-99c345cc36e1"), "Belle.Heller97@hotmail.com", false, new Guid("e742018d-0d09-4154-9afe-99c345cc36e1"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("e74e4731-dc79-4b9c-b6e6-833d086ca6bd"), "Wilfrid63@hotmail.com", false, new Guid("e74e4731-dc79-4b9c-b6e6-833d086ca6bd"), new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d") },
                    { new Guid("e7a315df-2b30-4c53-be17-23a6210843f7"), "Elsa.Gusikowski38@gmail.com", false, new Guid("e7a315df-2b30-4c53-be17-23a6210843f7"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("e7aa293a-66ca-447c-825e-8ec59fa4325f"), "April.Brakus27@gmail.com", false, new Guid("e7aa293a-66ca-447c-825e-8ec59fa4325f"), new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2") },
                    { new Guid("e7d2ed6c-467f-4754-a94e-68ab019a3631"), "Vida.VonRueden29@yahoo.com", false, new Guid("e7d2ed6c-467f-4754-a94e-68ab019a3631"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("e823a9b5-4dde-441a-8c45-11640890adb7"), "Aubree_Reichert@hotmail.com", false, new Guid("e823a9b5-4dde-441a-8c45-11640890adb7"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("e86de7ea-57ca-4309-ae12-9847d49ddc3b"), "Tania65@yahoo.com", false, new Guid("e86de7ea-57ca-4309-ae12-9847d49ddc3b"), new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403") },
                    { new Guid("e89ba01c-9d6a-497c-84ee-d7f92c6a8332"), "Elbert66@yahoo.com", false, new Guid("e89ba01c-9d6a-497c-84ee-d7f92c6a8332"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("e8e61636-cdea-4820-9437-474d08aa0b96"), "Kelton2@yahoo.com", false, new Guid("e8e61636-cdea-4820-9437-474d08aa0b96"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("e902bb78-ec97-40fc-8a59-b964bbc1e348"), "Sigmund.Parisian73@gmail.com", false, new Guid("e902bb78-ec97-40fc-8a59-b964bbc1e348"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("e903ea9a-1aff-4b1e-b52c-80c2c45c8682"), "Rosalinda.Crona42@hotmail.com", false, new Guid("e903ea9a-1aff-4b1e-b52c-80c2c45c8682"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("e97521e0-6cc6-4c1e-832c-e074573b8daf"), "Elbert.Pacocha93@gmail.com", false, new Guid("e97521e0-6cc6-4c1e-832c-e074573b8daf"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") },
                    { new Guid("e9a3d3d1-3600-4ad0-9ec3-92857961119a"), "Andreanne41@yahoo.com", false, new Guid("e9a3d3d1-3600-4ad0-9ec3-92857961119a"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("e9a441dc-9dd3-4b14-ae9e-8c823071d4b0"), "Charlotte.Durgan@yahoo.com", false, new Guid("e9a441dc-9dd3-4b14-ae9e-8c823071d4b0"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("eae7bba9-823e-48d0-be67-fb2d51d31b71"), "Gene84@hotmail.com", false, new Guid("eae7bba9-823e-48d0-be67-fb2d51d31b71"), new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305") },
                    { new Guid("eb0a4c1d-985a-42e8-bc06-18336bf63103"), "Alison.Kunze@hotmail.com", false, new Guid("eb0a4c1d-985a-42e8-bc06-18336bf63103"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("eb63fbc4-0e3b-4759-a2ed-05eb02144c80"), "Delbert54@gmail.com", false, new Guid("eb63fbc4-0e3b-4759-a2ed-05eb02144c80"), new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2") },
                    { new Guid("ebd42cd7-d062-45a8-955d-aca5751e6137"), "Madaline0@yahoo.com", false, new Guid("ebd42cd7-d062-45a8-955d-aca5751e6137"), new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738") },
                    { new Guid("ed81af63-ff62-48a7-8986-18017a429927"), "Felix_Herman11@gmail.com", false, new Guid("ed81af63-ff62-48a7-8986-18017a429927"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("ed86b94f-9180-45b9-9f4f-197376b00499"), "Demetrius.Ondricka60@gmail.com", false, new Guid("ed86b94f-9180-45b9-9f4f-197376b00499"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("ee077b28-4fd4-4811-86a7-da5dd3ae69ea"), "Brando_Kemmer@yahoo.com", false, new Guid("ee077b28-4fd4-4811-86a7-da5dd3ae69ea"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("ee14d8fd-d23b-4e8e-9d92-7f1c1ece3c65"), "Ottilie.Brekke18@yahoo.com", false, new Guid("ee14d8fd-d23b-4e8e-9d92-7f1c1ece3c65"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("ee5f677a-0779-44a4-a0ca-e421457a82f5"), "Rosella29@hotmail.com", false, new Guid("ee5f677a-0779-44a4-a0ca-e421457a82f5"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("ee6686a7-80f8-4f6a-adce-a202306fe2e5"), "Laurence_Gerhold76@gmail.com", false, new Guid("ee6686a7-80f8-4f6a-adce-a202306fe2e5"), new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4") },
                    { new Guid("ee725a2f-ab71-4bc3-ab2b-527076d200ba"), "Jeffry_Windler61@hotmail.com", false, new Guid("ee725a2f-ab71-4bc3-ab2b-527076d200ba"), new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2") },
                    { new Guid("eed8c7d3-f812-4abb-a422-b2eba13f7455"), "Jamal13@hotmail.com", false, new Guid("eed8c7d3-f812-4abb-a422-b2eba13f7455"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("ef167833-5f3b-4049-88c1-984561d2c771"), "Garret.Wiegand@gmail.com", false, new Guid("ef167833-5f3b-4049-88c1-984561d2c771"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("ef1ca970-eac9-4d6d-80fe-68234e1660a6"), "Megane_Mayert@gmail.com", false, new Guid("ef1ca970-eac9-4d6d-80fe-68234e1660a6"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("ef68818f-883a-4bec-916b-5c1675b4d7a2"), "Hilma.Gottlieb16@gmail.com", false, new Guid("ef68818f-883a-4bec-916b-5c1675b4d7a2"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("ef800683-855d-4230-9434-ddf5eb6479db"), "Elnora_Trantow58@yahoo.com", false, new Guid("ef800683-855d-4230-9434-ddf5eb6479db"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("f00df709-837d-47c4-acdd-1c7e64593737"), "Hermann.Kuhlman@hotmail.com", false, new Guid("f00df709-837d-47c4-acdd-1c7e64593737"), new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e") },
                    { new Guid("f0404156-4940-4388-9677-9d221a218703"), "Leanna_Beier@yahoo.com", false, new Guid("f0404156-4940-4388-9677-9d221a218703"), new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("f05faa07-b778-4d60-adc4-38a3fb8c2e06"), "Jefferey6@hotmail.com", false, new Guid("f05faa07-b778-4d60-adc4-38a3fb8c2e06"), new Guid("665af7ab-85d3-48f3-bedd-30db54699f81") },
                    { new Guid("f10d103d-1695-4714-8066-6ca573a48cbb"), "Elmore65@gmail.com", false, new Guid("f10d103d-1695-4714-8066-6ca573a48cbb"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("f10fd9f9-a46a-4f2d-b813-babad7577117"), "Casper_Corwin19@gmail.com", false, new Guid("f10fd9f9-a46a-4f2d-b813-babad7577117"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("f1137ca4-b4dd-4d18-baf7-9ec292e44e80"), "Heber_Schmeler@gmail.com", false, new Guid("f1137ca4-b4dd-4d18-baf7-9ec292e44e80"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("f121d197-19ca-487a-9ee3-f6ad7ae90f83"), "Maia21@gmail.com", false, new Guid("f121d197-19ca-487a-9ee3-f6ad7ae90f83"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("f1566265-c9ec-43e5-aa19-4d27963d00cb"), "Jean86@gmail.com", false, new Guid("f1566265-c9ec-43e5-aa19-4d27963d00cb"), new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6") },
                    { new Guid("f1c36e36-3737-486c-85c3-7a770016c222"), "Jordy_Rempel@gmail.com", false, new Guid("f1c36e36-3737-486c-85c3-7a770016c222"), new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718") },
                    { new Guid("f213e645-a65e-455b-b8c7-d87fe43ee279"), "Kareem_Christiansen40@yahoo.com", false, new Guid("f213e645-a65e-455b-b8c7-d87fe43ee279"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("f27ad197-20f0-44ed-83b1-0d995c9ee696"), "Afton93@yahoo.com", false, new Guid("f27ad197-20f0-44ed-83b1-0d995c9ee696"), new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4") },
                    { new Guid("f3049a59-3f13-42b4-8ba5-c3b052cfcfb9"), "Elna.Shields54@gmail.com", false, new Guid("f3049a59-3f13-42b4-8ba5-c3b052cfcfb9"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("f30524a0-5430-4f83-9565-4545fa263c73"), "Katelyn46@hotmail.com", false, new Guid("f30524a0-5430-4f83-9565-4545fa263c73"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("f37705d7-b99f-4920-9e2c-ebbb3df89a46"), "Heath62@hotmail.com", false, new Guid("f37705d7-b99f-4920-9e2c-ebbb3df89a46"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("f4592404-f05f-426c-8c30-c08298394c12"), "Myrna_Rath87@hotmail.com", false, new Guid("f4592404-f05f-426c-8c30-c08298394c12"), new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59") },
                    { new Guid("f4a165e0-b0b7-4974-8377-f50ce12b3f56"), "Dawson.Jacobs@hotmail.com", false, new Guid("f4a165e0-b0b7-4974-8377-f50ce12b3f56"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("f525212c-b132-4554-afa9-698c38a431d4"), "Garnett4@gmail.com", false, new Guid("f525212c-b132-4554-afa9-698c38a431d4"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("f58db925-986d-40b6-adcf-f07f0449e98d"), "Yessenia62@hotmail.com", false, new Guid("f58db925-986d-40b6-adcf-f07f0449e98d"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("f59a6b5f-f3ce-45c8-a708-ef3dd9674c65"), "Michele42@hotmail.com", false, new Guid("f59a6b5f-f3ce-45c8-a708-ef3dd9674c65"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("f5c287c0-c7a6-452a-8e72-2a4a88b33d83"), "Bernardo_Swaniawski@hotmail.com", false, new Guid("f5c287c0-c7a6-452a-8e72-2a4a88b33d83"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("f651d988-0986-4c16-8529-196d8da58622"), "Rosalinda.Lueilwitz@yahoo.com", false, new Guid("f651d988-0986-4c16-8529-196d8da58622"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("f68cd696-c6e7-4a29-9570-fc93c40cdb29"), "Joseph51@hotmail.com", false, new Guid("f68cd696-c6e7-4a29-9570-fc93c40cdb29"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("f6c23cfd-6fcb-44ef-933a-93380ee91cf0"), "Claudine_Dickinson43@gmail.com", false, new Guid("f6c23cfd-6fcb-44ef-933a-93380ee91cf0"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("f6ce7b6e-407d-44b5-92d3-7ef2f15284f3"), "Haven35@yahoo.com", false, new Guid("f6ce7b6e-407d-44b5-92d3-7ef2f15284f3"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("f8066a69-db3d-4ecb-8aa2-064d26482492"), "Anabelle.Davis@yahoo.com", false, new Guid("f8066a69-db3d-4ecb-8aa2-064d26482492"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("f81a30ad-64a5-4c21-9848-b8be50a49312"), "Vena.Turner96@hotmail.com", false, new Guid("f81a30ad-64a5-4c21-9848-b8be50a49312"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("f91a3f1d-0262-4e4d-8051-894490b07141"), "Carmelo.Larkin53@gmail.com", false, new Guid("f91a3f1d-0262-4e4d-8051-894490b07141"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("f9abe7d2-86f5-48b2-876e-c015f0896389"), "Octavia_Jacobson89@hotmail.com", false, new Guid("f9abe7d2-86f5-48b2-876e-c015f0896389"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("f9c4649b-c991-4494-9d32-a4aaa02d24c0"), "Melisa_Franecki@gmail.com", false, new Guid("f9c4649b-c991-4494-9d32-a4aaa02d24c0"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("f9d29b70-e463-443b-a8fe-7421ebacf1ea"), "Jensen0@gmail.com", false, new Guid("f9d29b70-e463-443b-a8fe-7421ebacf1ea"), new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4") },
                    { new Guid("f9e94c96-bd27-4441-8750-9f1ee959916a"), "Nannie42@hotmail.com", false, new Guid("f9e94c96-bd27-4441-8750-9f1ee959916a"), new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3") },
                    { new Guid("fa202207-4ebf-43a8-814f-a23b575a11dd"), "Hester.Wiegand6@gmail.com", false, new Guid("fa202207-4ebf-43a8-814f-a23b575a11dd"), new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c") },
                    { new Guid("fa55ec47-28f8-4ed2-8bc4-ac7d00158135"), "Brent_Dach13@hotmail.com", false, new Guid("fa55ec47-28f8-4ed2-8bc4-ac7d00158135"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("fa59bc70-643f-4114-9bf2-ee67c4e3b365"), "Ivory82@gmail.com", false, new Guid("fa59bc70-643f-4114-9bf2-ee67c4e3b365"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("faf21134-90c7-4c95-be00-969482d39bc1"), "Candelario_Rodriguez63@yahoo.com", false, new Guid("faf21134-90c7-4c95-be00-969482d39bc1"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("fb07b27e-97e5-4eec-8c8f-697ad5be0559"), "Eddie.Zieme78@yahoo.com", false, new Guid("fb07b27e-97e5-4eec-8c8f-697ad5be0559"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("fb6b4d18-6f93-4719-8f4c-065ba8333ffc"), "Domingo46@hotmail.com", false, new Guid("fb6b4d18-6f93-4719-8f4c-065ba8333ffc"), new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65") },
                    { new Guid("fbad9186-e724-459f-854f-9966fc22f4f5"), "Alan.Kub82@yahoo.com", false, new Guid("fbad9186-e724-459f-854f-9966fc22f4f5"), new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("fbbdff6f-9456-40ac-90ef-ba2dd74c5ce9"), "Leanne78@gmail.com", false, new Guid("fbbdff6f-9456-40ac-90ef-ba2dd74c5ce9"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("fcdf74bb-21ee-430d-ae93-98bc359b0f58"), "Katlynn_Bayer@hotmail.com", false, new Guid("fcdf74bb-21ee-430d-ae93-98bc359b0f58"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("fce1d3dc-a2aa-4a82-831f-3a16161f42a5"), "Vita14@yahoo.com", false, new Guid("fce1d3dc-a2aa-4a82-831f-3a16161f42a5"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("fd332165-5b30-476a-beaa-6f2bdfb8c118"), "Josiane24@hotmail.com", false, new Guid("fd332165-5b30-476a-beaa-6f2bdfb8c118"), new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5") },
                    { new Guid("fd581c94-3730-44da-9b5c-42f483c078a6"), "Birdie84@yahoo.com", false, new Guid("fd581c94-3730-44da-9b5c-42f483c078a6"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("fd5b786f-b54b-4ff0-b481-9444470ecc11"), "Justus0@hotmail.com", false, new Guid("fd5b786f-b54b-4ff0-b481-9444470ecc11"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("feec1133-a39e-4ee2-a57a-b812da6f205a"), "Alessandro_Kunze57@yahoo.com", false, new Guid("feec1133-a39e-4ee2-a57a-b812da6f205a"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("ff2004bd-a5d3-4e33-a8b7-2789090ab968"), "Emile.Hilll@yahoo.com", false, new Guid("ff2004bd-a5d3-4e33-a8b7-2789090ab968"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("ff3d9cc4-5fbd-431e-b0fb-e92fb090a5c4"), "Amie.Dickens@gmail.com", false, new Guid("ff3d9cc4-5fbd-431e-b0fb-e92fb090a5c4"), new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2") },
                    { new Guid("ff52fbbd-38fb-4ad1-9c8f-6fbb1bbd79af"), "Abe.Rice67@yahoo.com", false, new Guid("ff52fbbd-38fb-4ad1-9c8f-6fbb1bbd79af"), new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88") },
                    { new Guid("ff9410e8-92f3-4669-92fb-1dfb33d5ee76"), "Jazmin4@hotmail.com", false, new Guid("ff9410e8-92f3-4669-92fb-1dfb33d5ee76"), new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("04e469b9-a7ea-497f-af90-c88bd12cefe3"), new DateTime(2023, 10, 4, 10, 1, 3, 570, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 10, 14, 10, 1, 3, 570, DateTimeKind.Local).AddTicks(5175), 68.69m, new Guid("04e469b9-a7ea-497f-af90-c88bd12cefe3"), 6030420414758990m, true, "ParcelMachine", 1, 49.34942f, "18177 Bashirian Lodge, Casandramouth, Cook Islands", new Guid("8b3ae855-3f1f-409d-8898-00767477ffae"), "42330 Tevin Neck, New Amparomouth, Morocco", new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("05ae87ad-6f92-4e96-83e3-631a34b73216"), new DateTime(2023, 8, 15, 21, 38, 54, 529, DateTimeKind.Local).AddTicks(4468), new DateTime(2023, 8, 20, 21, 38, 54, 529, DateTimeKind.Local).AddTicks(4468), 23.83m, true, new Guid("05ae87ad-6f92-4e96-83e3-631a34b73216"), 5615846117234368m, "Standart", 3, 26.808659f, "52237 Moises Creek, New Destiney, Serbia", new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), "619 Langworth Locks, New Hunterchester, Bangladesh", new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("07824464-8fd5-4743-8f44-8da322155e11"), new DateTime(2023, 6, 6, 5, 23, 35, 693, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 6, 12, 5, 23, 35, 693, DateTimeKind.Local).AddTicks(6138), 41.98m, new Guid("07824464-8fd5-4743-8f44-8da322155e11"), 9393720592697988m, true, "Super", 4, 23.406548f, "181 Glover Ports, West Lonny, Ecuador", new Guid("5558c531-153b-4da7-9848-996b07daa782"), "48475 Tyrell Harbor, Lake Faustinoside, Kuwait", new Guid("12656ae7-3922-41ca-b159-f79b439a354c"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("08cb452c-d1db-40d7-9b2f-74b07eed3c59"), new DateTime(2024, 1, 6, 23, 7, 51, 579, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 1, 7, 23, 7, 51, 579, DateTimeKind.Local).AddTicks(6127), 63.93m, true, new Guid("08cb452c-d1db-40d7-9b2f-74b07eed3c59"), 5325922541858906m, true, "Super", 5, 2.7385855f, "61422 Gorczany Viaduct, North Celineburgh, Dominica", new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913"), "07429 Kris Lock, Windlertown, Estonia", new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("08d9b0f2-9fa0-47e1-9a07-e5f255168bff"), new DateTime(2024, 1, 18, 14, 5, 53, 312, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 1, 19, 14, 5, 53, 312, DateTimeKind.Local).AddTicks(8051), 91.99m, new Guid("08d9b0f2-9fa0-47e1-9a07-e5f255168bff"), 1005360284667964m, "Standart", 1, 47.484028f, "70484 Stamm Shoals, North Kariane, Palestinian Territory", new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a"), "28709 Giovanni Oval, West Idellaborough, Ireland", new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("09f29762-2a51-4973-8fac-05c714b267f0"), new DateTime(2023, 12, 25, 21, 18, 36, 789, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 12, 30, 21, 18, 36, 789, DateTimeKind.Local).AddTicks(4944), 27.96m, new Guid("09f29762-2a51-4973-8fac-05c714b267f0"), 3343056802338488m, true, "Standart", 4, 38.054188f, "6393 Koelpin Parkways, Port Maximofort, Seychelles", new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13"), "403 Isabel Squares, Abbeyshire, Pakistan", new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0a747048-d190-44ad-b0de-473bda1e95df"), new DateTime(2024, 6, 5, 6, 6, 13, 564, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 6, 14, 6, 6, 13, 564, DateTimeKind.Local).AddTicks(24), 28.81m, new Guid("0a747048-d190-44ad-b0de-473bda1e95df"), 5089148919310068m, "Courier", 2, 48.0811f, "80667 Mueller Overpass, Port Coleman, Burkina Faso", new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425"), "391 Funk Meadows, Tyriquestad, Tunisia", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("12a12bfe-40c4-4696-b3d7-5800fde20253"), new DateTime(2023, 12, 1, 4, 4, 5, 297, DateTimeKind.Local).AddTicks(1964), new DateTime(2023, 12, 9, 4, 4, 5, 297, DateTimeKind.Local).AddTicks(1964), 80.49m, true, new Guid("12a12bfe-40c4-4696-b3d7-5800fde20253"), 8864301781951769m, true, "Super", 4, 14.467655f, "69365 Ankunding Lodge, South Calista, Haiti", new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88"), "2715 Ruthe Knolls, West Theronstad, Kyrgyz Republic", new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("15470a7f-43e6-4d81-8961-0262874cf48a"), new DateTime(2024, 5, 5, 5, 57, 58, 917, DateTimeKind.Local).AddTicks(1988), new DateTime(2024, 5, 11, 5, 57, 58, 917, DateTimeKind.Local).AddTicks(1988), 66.87m, new Guid("15470a7f-43e6-4d81-8961-0262874cf48a"), 3586872835427290m, true, "Super", 2, 17.514282f, "7085 Kelton Greens, East Ronaldo, Guatemala", new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d"), "785 Melyssa Ramp, Hintzfurt, Vanuatu", new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("15da7214-aa9c-4594-9347-091b2c64d6c5"), new DateTime(2024, 6, 2, 3, 15, 50, 915, DateTimeKind.Local).AddTicks(539), new DateTime(2024, 6, 10, 3, 15, 50, 915, DateTimeKind.Local).AddTicks(539), 60.15m, true, new Guid("15da7214-aa9c-4594-9347-091b2c64d6c5"), 6747878133136704m, true, "Courier", 3, 25.09057f, "8368 Hammes Meadow, South Jeremie, Serbia", new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0"), "0705 Crooks Light, South Aubrey, Honduras", new Guid("7637da20-6c85-4358-a711-5912b0358007"), "Registered", "PlasticBag" },
                    { new Guid("1839cb96-971d-4bc2-97dd-55e8a23005f0"), new DateTime(2023, 12, 11, 4, 35, 38, 359, DateTimeKind.Local).AddTicks(6621), new DateTime(2023, 12, 19, 4, 35, 38, 359, DateTimeKind.Local).AddTicks(6621), 32.36m, true, new Guid("1839cb96-971d-4bc2-97dd-55e8a23005f0"), 6557913677410303m, true, "ParcelMachine", 1, 22.377691f, "4442 Wallace Hills, Taliatown, Vanuatu", new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5"), "0451 Jaron Plaza, Durganberg, Iceland", new Guid("f825bff2-881f-450b-a4b7-56931951c54c"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("189e0a47-2e93-4e77-b926-9488664e2c00"), new DateTime(2024, 1, 17, 15, 19, 36, 629, DateTimeKind.Local).AddTicks(8546), new DateTime(2024, 1, 26, 15, 19, 36, 629, DateTimeKind.Local).AddTicks(8546), 27.94m, true, new Guid("189e0a47-2e93-4e77-b926-9488664e2c00"), 2314885480175798m, "Super", 1, 27.206606f, "0946 Donald Cove, Port Yadiramouth, Chad", new Guid("482c0758-a476-404a-ade3-01c0818a58f9"), "51573 Lambert Crescent, Koeppchester, Cayman Islands", new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("1ef67503-42c2-407d-82a9-be349407ca40"), new DateTime(2024, 3, 15, 17, 15, 26, 948, DateTimeKind.Local).AddTicks(3777), new DateTime(2024, 3, 18, 17, 15, 26, 948, DateTimeKind.Local).AddTicks(3777), 56.79m, new Guid("1ef67503-42c2-407d-82a9-be349407ca40"), 4543496932740395m, true, "Special", 4, 10.135795f, "7889 Bartoletti Circle, Laviniashire, Western Sahara", new Guid("d422e4b4-5d7b-484f-830c-319350a69b22"), "65623 Mayer Villages, East Joyview, Kuwait", new Guid("f7720de3-aaea-48e9-af48-569af731d90b"), "OnTheWay", "PlasticBag" },
                    { new Guid("20b65b17-70a0-4d96-a0b9-4ce45244941e"), new DateTime(2024, 5, 6, 2, 39, 24, 386, DateTimeKind.Local).AddTicks(2528), new DateTime(2024, 5, 10, 2, 39, 24, 386, DateTimeKind.Local).AddTicks(2528), 11.44m, new Guid("20b65b17-70a0-4d96-a0b9-4ce45244941e"), 1862687641148104m, true, "Super", 4, 49.919266f, "67103 Lowe Mission, Lelaburgh, Cuba", new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7"), "95624 Gibson Walks, Yasminchester, Afghanistan", new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("218d4519-5bed-4a16-b9d9-62699a08d63b"), new DateTime(2023, 8, 24, 3, 7, 39, 894, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 8, 28, 3, 7, 39, 894, DateTimeKind.Local).AddTicks(9489), 44.16m, new Guid("218d4519-5bed-4a16-b9d9-62699a08d63b"), 4599382056106353m, "ParcelMachine", 4, 46.74067f, "01432 Jenkins Tunnel, New Carter, Georgia", new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b"), "1525 Lakin Squares, Demetrisville, Haiti", new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("23591104-e729-4f9d-a034-1067e6cc2c5d"), new DateTime(2023, 11, 15, 7, 46, 27, 557, DateTimeKind.Local).AddTicks(5984), new DateTime(2023, 11, 24, 7, 46, 27, 557, DateTimeKind.Local).AddTicks(5984), 32.76m, new Guid("23591104-e729-4f9d-a034-1067e6cc2c5d"), 1098842356218326m, true, "Standart", 5, 12.691357f, "380 Angelo Mews, South Celestinebury, Samoa", new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0"), "856 Guiseppe Wall, Saulshire, Serbia", new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5"), "Delivered", "PlasticBag" },
                    { new Guid("257721fe-011b-4065-9765-d8d22ba02a97"), new DateTime(2024, 3, 24, 9, 1, 47, 716, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 4, 3, 9, 1, 47, 716, DateTimeKind.Local).AddTicks(5555), 16.61m, new Guid("257721fe-011b-4065-9765-d8d22ba02a97"), 7798200230155340m, true, "Special", 3, 7.9377f, "709 Hyatt Tunnel, Valentineville, Burundi", new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c"), "6203 Kuhlman Isle, East Martina, Micronesia", new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("259f085b-4d05-4fb2-9e7d-ac6b436c67c4"), new DateTime(2023, 12, 3, 3, 8, 48, 414, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 12, 7, 3, 8, 48, 414, DateTimeKind.Local).AddTicks(7334), 41.06m, true, new Guid("259f085b-4d05-4fb2-9e7d-ac6b436c67c4"), 5670861430994579m, true, "Special", 3, 2.5698123f, "6085 Deanna Ridges, Dallinview, Saint Martin", new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c"), "191 Hardy Landing, West Kalebmouth, Christmas Island", new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2a35a867-0e97-4236-941e-bb7194257c3a"), new DateTime(2024, 5, 13, 18, 34, 19, 40, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 5, 19, 18, 34, 19, 40, DateTimeKind.Local).AddTicks(631), 38.49m, new Guid("2a35a867-0e97-4236-941e-bb7194257c3a"), 5036231280516868m, "Courier", 5, 2.952826f, "90435 Merlin Plains, East Kobe, Wallis and Futuna", new Guid("35482730-4c7a-4e01-aeca-0748f3123997"), "08335 Ova Spring, West Milford, Cape Verde", new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2a65cb14-c2a8-46de-a85c-099b061e4cf4"), new DateTime(2023, 10, 28, 7, 54, 24, 733, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 10, 29, 7, 54, 24, 733, DateTimeKind.Local).AddTicks(415), 79.55m, true, new Guid("2a65cb14-c2a8-46de-a85c-099b061e4cf4"), 6831375586592925m, "Super", 5, 39.98544f, "1217 Nikolaus Square, Cartermouth, Namibia", new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b"), "931 Rohan Passage, Lake Mayebury, Tunisia", new Guid("48949002-3dd7-424b-b508-bb6644cad6fb"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3473adff-f88b-42a4-8f74-d853fb57ec92"), new DateTime(2023, 8, 13, 1, 37, 37, 378, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 8, 15, 1, 37, 37, 378, DateTimeKind.Local).AddTicks(2643), 39.23m, true, new Guid("3473adff-f88b-42a4-8f74-d853fb57ec92"), 6573807593777014m, true, "Courier", 5, 28.418701f, "83064 Williamson Loaf, South Eldredville, Reunion", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "5515 Aurelie Shores, East Lamontport, Turks and Caicos Islands", new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3b68320b-8bd6-4566-be6f-660fc9f14d7d"), new DateTime(2024, 3, 20, 19, 37, 14, 199, DateTimeKind.Local).AddTicks(3862), new DateTime(2024, 3, 26, 19, 37, 14, 199, DateTimeKind.Local).AddTicks(3862), 81.35m, true, new Guid("3b68320b-8bd6-4566-be6f-660fc9f14d7d"), 1158640825186460m, "Special", 4, 31.750427f, "2182 Denesik Tunnel, Joeyview, Cape Verde", new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d"), "6093 Kelli Turnpike, New Zulahaven, Czech Republic", new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("48567da9-d2fb-48ce-a587-c873f0f085d8"), new DateTime(2023, 10, 19, 5, 59, 20, 638, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 10, 22, 5, 59, 20, 638, DateTimeKind.Local).AddTicks(2702), 84.51m, true, new Guid("48567da9-d2fb-48ce-a587-c873f0f085d8"), 8756905229358772m, true, "Standart", 4, 20.345345f, "2334 Hailey Run, South Verlie, Western Sahara", new Guid("71725c06-aded-4994-8181-26d1683597c4"), "0017 Brisa Trace, West Tianna, China", new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4d4019a0-3734-43c5-92bd-75341a1f7c70"), new DateTime(2023, 7, 30, 4, 28, 25, 209, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 8, 2, 4, 28, 25, 209, DateTimeKind.Local).AddTicks(1333), 50.81m, true, new Guid("4d4019a0-3734-43c5-92bd-75341a1f7c70"), 3320329431498808m, "Standart", 1, 15.954393f, "7237 Myrtie Row, Rohanland, San Marino", new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8"), "2824 Mariano Overpass, South Amber, Luxembourg", new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4df39d98-3959-48ea-9e93-242885ee892c"), new DateTime(2023, 9, 20, 20, 49, 47, 862, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 9, 23, 20, 49, 47, 862, DateTimeKind.Local).AddTicks(2768), 68.85m, new Guid("4df39d98-3959-48ea-9e93-242885ee892c"), 5340322985223052m, true, "Standart", 3, 17.390812f, "33477 Wisoky Walk, Tyriqueland, Paraguay", new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), "61953 Ambrose Stravenue, East Myrl, Myanmar", new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("4e6ea05a-dd55-4e1b-9d6f-dd265192ff8e"), new DateTime(2023, 11, 15, 19, 18, 8, 629, DateTimeKind.Local).AddTicks(9543), new DateTime(2023, 11, 21, 19, 18, 8, 629, DateTimeKind.Local).AddTicks(9543), 42.11m, true, new Guid("4e6ea05a-dd55-4e1b-9d6f-dd265192ff8e"), 5609554402531750m, true, "Standart", 1, 27.541534f, "98162 Anderson Land, Port Janae, Greenland", new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a"), "70138 Kerluke Forges, Port Hattiehaven, New Zealand", new Guid("69170f92-b4b7-4c26-be44-5255d738fb20"), "Registered", "PlasticBag" },
                    { new Guid("507b16c7-fe7a-4f8a-8261-d3f4126b21a6"), new DateTime(2023, 12, 31, 21, 6, 26, 159, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 1, 2, 21, 6, 26, 159, DateTimeKind.Local).AddTicks(5), 85.85m, true, new Guid("507b16c7-fe7a-4f8a-8261-d3f4126b21a6"), 9859028590660056m, true, "Courier", 1, 33.728935f, "85629 Adonis Ways, Chazberg, Svalbard & Jan Mayen Islands", new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22"), "16288 Lehner Loop, South Mortimer, Benin", new Guid("18685782-706e-445d-892d-19c39dd67689"), "Sent", "PlasticBag" },
                    { new Guid("507f83ff-b6c1-4b3d-bb84-52c61bad2029"), new DateTime(2024, 3, 7, 15, 28, 11, 233, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 3, 14, 15, 28, 11, 233, DateTimeKind.Local).AddTicks(1377), 62.30m, true, new Guid("507f83ff-b6c1-4b3d-bb84-52c61bad2029"), 8859842061389541m, true, "Special", 4, 25.900103f, "671 Kilback Lane, North Violafurt, Albania", new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b"), "8090 Tyson Landing, Huelsville, Turkmenistan", new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("59b2c12b-3a9c-4e55-a4c7-0815aed63598"), new DateTime(2023, 7, 3, 12, 16, 37, 456, DateTimeKind.Local).AddTicks(7077), new DateTime(2023, 7, 4, 12, 16, 37, 456, DateTimeKind.Local).AddTicks(7077), 86.91m, true, new Guid("59b2c12b-3a9c-4e55-a4c7-0815aed63598"), 1056435698047626m, "Super", 3, 8.189002f, "6983 Vida Canyon, Cadefort, Germany", new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc"), "0259 Stroman Crest, South Isai, Saint Kitts and Nevis", new Guid("9f745913-393e-4d75-924b-12ed8606f936"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5f0bf3ae-5932-498f-8053-cbe6758ddaf4"), new DateTime(2023, 7, 30, 2, 26, 6, 78, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 8, 5, 2, 26, 6, 78, DateTimeKind.Local).AddTicks(3593), 19.07m, new Guid("5f0bf3ae-5932-498f-8053-cbe6758ddaf4"), 9376669224708600m, "Super", 3, 32.097893f, "5493 Lebsack Course, Lebsackmouth, San Marino", new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964"), "36472 Autumn Wells, Freddychester, Montenegro", new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33"), "Delivered", "CardboardBox" },
                    { new Guid("611fba1c-8fa6-447a-91f2-33649767ba8b"), new DateTime(2023, 8, 17, 21, 46, 29, 899, DateTimeKind.Local).AddTicks(632), new DateTime(2023, 8, 19, 21, 46, 29, 899, DateTimeKind.Local).AddTicks(632), 92.68m, new Guid("611fba1c-8fa6-447a-91f2-33649767ba8b"), 1655350737151247m, "Standart", 4, 20.115513f, "3320 Moses Parks, Port Celia, Moldova", new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3"), "033 Barton Grove, South Horace, Ukraine", new Guid("a11d6609-e768-4189-bd78-5b34d82849e6"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6204488a-2673-4232-83da-89747590e9de"), new DateTime(2024, 5, 19, 11, 51, 12, 30, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 5, 25, 11, 51, 12, 30, DateTimeKind.Local).AddTicks(9930), 80.51m, true, new Guid("6204488a-2673-4232-83da-89747590e9de"), 3420293356957212m, "Standart", 2, 48.94157f, "714 Dante Turnpike, Vonborough, Nicaragua", new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88"), "84993 Lindgren Junctions, New Geovanni, Belgium", new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("666f85dc-699c-41f2-aa07-4153c8cf6e2c"), new DateTime(2024, 4, 9, 20, 8, 3, 72, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 4, 18, 20, 8, 3, 72, DateTimeKind.Local).AddTicks(5302), 94.95m, new Guid("666f85dc-699c-41f2-aa07-4153c8cf6e2c"), 6898591483000674m, "ParcelMachine", 3, 44.428543f, "3967 Kiarra Crest, Krisport, Reunion", new Guid("8b896efc-3b46-4670-bb2b-740919a113b5"), "65352 Rice Prairie, East Shadview, Algeria", new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6"), "Registered", "PlasticBag" },
                    { new Guid("66ed3e76-a539-4e0c-8eed-74b452b96f0f"), new DateTime(2023, 7, 15, 0, 55, 34, 529, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 7, 19, 0, 55, 34, 529, DateTimeKind.Local).AddTicks(8913), 46.53m, new Guid("66ed3e76-a539-4e0c-8eed-74b452b96f0f"), 7758030980767738m, "ParcelMachine", 5, 9.091279f, "980 Yvonne Parkways, Port Rex, Cape Verde", new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61"), "311 Asa Summit, Port Kendrafort, Indonesia", new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("684da7cc-8545-4e63-9e4c-394f137de86d"), new DateTime(2024, 5, 5, 14, 37, 8, 373, DateTimeKind.Local).AddTicks(9494), new DateTime(2024, 5, 6, 14, 37, 8, 373, DateTimeKind.Local).AddTicks(9494), 12.84m, new Guid("684da7cc-8545-4e63-9e4c-394f137de86d"), 4483869218799722m, true, "Special", 2, 47.862095f, "445 Jackeline Mountain, New Destinland, Cocos (Keeling) Islands", new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420"), "6135 Hand Landing, Mathewside, Equatorial Guinea", new Guid("735be216-2179-4f32-8f5b-062c31f3a316"), "Registered", "PlasticBag" },
                    { new Guid("686bc4f1-2779-4b1b-a7b5-6be6e93de913"), new DateTime(2023, 8, 21, 0, 20, 2, 963, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 8, 25, 0, 20, 2, 963, DateTimeKind.Local).AddTicks(3459), 73.94m, new Guid("686bc4f1-2779-4b1b-a7b5-6be6e93de913"), 2422285013469600m, true, "Standart", 4, 47.197906f, "5534 Hamill Well, Noblemouth, Marshall Islands", new Guid("34976e08-cfc9-417c-a480-e4cfed027f98"), "41221 Kallie Green, Port Myriam, Cuba", new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), "Registered", "PlasticBag" },
                    { new Guid("689e24ea-bf5b-41c2-b4c6-190255b0e2df"), new DateTime(2023, 8, 5, 0, 1, 51, 76, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 8, 14, 0, 1, 51, 76, DateTimeKind.Local).AddTicks(4919), 93.75m, new Guid("689e24ea-bf5b-41c2-b4c6-190255b0e2df"), 7338896378068659m, true, "Special", 1, 40.07894f, "2912 Barton Estates, Franciscofort, Germany", new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440"), "540 Lueilwitz Station, Lake Darrelbury, Germany", new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6d1fe774-3bab-455e-9679-427734221828"), new DateTime(2023, 8, 7, 8, 38, 7, 713, DateTimeKind.Local).AddTicks(5773), new DateTime(2023, 8, 15, 8, 38, 7, 713, DateTimeKind.Local).AddTicks(5773), 56.41m, new Guid("6d1fe774-3bab-455e-9679-427734221828"), 4301217434616779m, "ParcelMachine", 3, 8.410262f, "69307 Melba Junctions, East Jaron, Congo", new Guid("48949002-3dd7-424b-b508-bb6644cad6fb"), "42502 Cleveland Crescent, Idellmouth, Chad", new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("728ee6fa-e7e4-46b7-9876-4286baf1fbaf"), new DateTime(2024, 1, 14, 20, 47, 15, 628, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 1, 21, 20, 47, 15, 628, DateTimeKind.Local).AddTicks(3313), 70.70m, true, new Guid("728ee6fa-e7e4-46b7-9876-4286baf1fbaf"), 9133756475716892m, true, "Courier", 3, 13.833219f, "68401 Justina Forest, North Berniece, Iraq", new Guid("f1038abe-cd17-40c4-844a-70a0ee863724"), "23254 Kuvalis Circles, Port Genevievehaven, Bolivia", new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("72bc0ad4-549d-4f4b-84e1-1a8c94e5df62"), new DateTime(2023, 10, 24, 15, 5, 58, 914, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 10, 28, 15, 5, 58, 914, DateTimeKind.Local).AddTicks(5605), 47.66m, true, new Guid("72bc0ad4-549d-4f4b-84e1-1a8c94e5df62"), 8660354416563905m, "Standart", 3, 29.603407f, "6953 Bailey Dam, Port Princessstad, United Kingdom", new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a"), "57783 Santina Stravenue, North Sashamouth, Saint Pierre and Miquelon", new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("736d264a-e8ba-4972-93c9-71c32ad90797"), new DateTime(2023, 8, 4, 5, 32, 24, 508, DateTimeKind.Local).AddTicks(205), new DateTime(2023, 8, 11, 5, 32, 24, 508, DateTimeKind.Local).AddTicks(205), 82.34m, new Guid("736d264a-e8ba-4972-93c9-71c32ad90797"), 5062421634014076m, "Super", 1, 42.33219f, "325 Kihn Mountain, Labadieton, Antigua and Barbuda", new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425"), "08295 Emiliano Common, New Patsyburgh, Uzbekistan", new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("75202b9c-8abe-4fcf-9897-1b80908e9085"), new DateTime(2024, 2, 7, 9, 15, 29, 171, DateTimeKind.Local).AddTicks(9251), new DateTime(2024, 2, 9, 9, 15, 29, 171, DateTimeKind.Local).AddTicks(9251), 90.84m, new Guid("75202b9c-8abe-4fcf-9897-1b80908e9085"), 3891266597812394m, true, "Special", 5, 13.218118f, "023 Beahan Prairie, Gislasonmouth, Gambia", new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), "8236 Price Forge, Austinfurt, Ethiopia", new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("752e8fcc-4862-449f-8631-02389ef46618"), new DateTime(2023, 6, 6, 8, 22, 47, 744, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 6, 7, 8, 22, 47, 744, DateTimeKind.Local).AddTicks(3100), 14.35m, true, new Guid("752e8fcc-4862-449f-8631-02389ef46618"), 2092797567924474m, "Courier", 2, 46.920795f, "078 Cruickshank Coves, South Constancemouth, Norfolk Island", new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b"), "176 O'Conner Branch, Schmidtburgh, Guam", new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7792da42-0002-4ee5-bea9-9c34f1901419"), new DateTime(2024, 4, 9, 11, 17, 29, 36, DateTimeKind.Local).AddTicks(9836), new DateTime(2024, 4, 17, 11, 17, 29, 36, DateTimeKind.Local).AddTicks(9836), 48.00m, new Guid("7792da42-0002-4ee5-bea9-9c34f1901419"), 9320737304191740m, "Standart", 3, 16.341394f, "307 Name Trafficway, East Carlie, Jersey", new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84"), "216 Keanu Island, Lake Leda, Macao", new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7b90ce7a-d507-4aec-b485-fc56c5c7381c"), new DateTime(2024, 3, 1, 16, 43, 19, 10, DateTimeKind.Local).AddTicks(9072), new DateTime(2024, 3, 2, 16, 43, 19, 10, DateTimeKind.Local).AddTicks(9072), 51.89m, true, new Guid("7b90ce7a-d507-4aec-b485-fc56c5c7381c"), 1765129799126986m, true, "Courier", 4, 6.88012f, "1880 Schmidt Parkways, Port Monroeborough, Niue", new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a"), "446 Towne Crossing, North Afton, Comoros", new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7d61b52f-3e4a-4911-81f1-5193585fe202"), new DateTime(2023, 12, 22, 20, 39, 57, 912, DateTimeKind.Local).AddTicks(158), new DateTime(2023, 12, 27, 20, 39, 57, 912, DateTimeKind.Local).AddTicks(158), 31.37m, new Guid("7d61b52f-3e4a-4911-81f1-5193585fe202"), 7005522275772599m, "ParcelMachine", 1, 14.836428f, "383 Morar Roads, East Marilie, Angola", new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6"), "79252 Ida Mill, South Chester, Antarctica (the territory South of 60 deg S)", new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7e86e295-81f9-49dc-9204-2c21ba3ec8b8"), new DateTime(2023, 8, 13, 8, 34, 23, 620, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 8, 16, 8, 34, 23, 620, DateTimeKind.Local).AddTicks(6997), 47.30m, new Guid("7e86e295-81f9-49dc-9204-2c21ba3ec8b8"), 6404509656574390m, true, "Super", 5, 12.160448f, "52396 Kurt Valley, Lake Lennyside, Jamaica", new Guid("15ff126d-c656-4885-a732-88f20e2b2157"), "72874 Donnelly Hill, Croninview, Denmark", new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7eddda3a-b6a2-4eb2-8bf7-6ccec9c1e828"), new DateTime(2023, 12, 16, 13, 40, 11, 359, DateTimeKind.Local).AddTicks(7326), new DateTime(2023, 12, 25, 13, 40, 11, 359, DateTimeKind.Local).AddTicks(7326), 63.51m, new Guid("7eddda3a-b6a2-4eb2-8bf7-6ccec9c1e828"), 7446433522821084m, "Special", 4, 42.00526f, "976 Toy Common, South Angelineborough, Togo", new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf"), "8759 Parisian Crest, Agustinashire, Vietnam", new Guid("a6f0e48a-50d2-402a-b954-f944f339456a"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("80730122-ec8a-4856-866d-62dec4f213c1"), new DateTime(2024, 3, 27, 14, 44, 26, 992, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 3, 28, 14, 44, 26, 992, DateTimeKind.Local).AddTicks(6827), 11.39m, true, new Guid("80730122-ec8a-4856-866d-62dec4f213c1"), 9333906054513696m, "Super", 3, 34.18293f, "72513 Samantha Valley, Rickieland, Uganda", new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c"), "6150 Durgan Islands, Andyland, Western Sahara", new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b"), "Delivered", "PlasticBag" },
                    { new Guid("80dd75da-ffcf-4f43-866c-ddd9b821ad99"), new DateTime(2023, 11, 25, 0, 33, 7, 945, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 12, 1, 0, 33, 7, 945, DateTimeKind.Local).AddTicks(4489), 45.60m, true, new Guid("80dd75da-ffcf-4f43-866c-ddd9b821ad99"), 7760207460401816m, "Special", 2, 9.713916f, "418 Wolf Center, West Jermaineburgh, Singapore", new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13"), "52670 Hermiston Views, North Geraldine, Cape Verde", new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05"), "OnTheWay", "PlasticBag" },
                    { new Guid("80edec25-2d2c-45fc-9365-57ac502975a5"), new DateTime(2024, 4, 15, 21, 24, 35, 354, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 4, 20, 21, 24, 35, 354, DateTimeKind.Local).AddTicks(691), 86.69m, true, new Guid("80edec25-2d2c-45fc-9365-57ac502975a5"), 6410468369141311m, "ParcelMachine", 2, 3.5915534f, "26496 Schaefer Forks, Port Juanitamouth, Kazakhstan", new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3"), "5201 Kolby Walk, Hyattberg, Madagascar", new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("80fb0e38-1e3a-477b-9b13-84863a89b4a3"), new DateTime(2024, 1, 5, 7, 53, 12, 833, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 1, 10, 7, 53, 12, 833, DateTimeKind.Local).AddTicks(3578), 25.60m, new Guid("80fb0e38-1e3a-477b-9b13-84863a89b4a3"), 8880246737757877m, "Special", 4, 30.44111f, "7454 Monahan Brook, Pfefferfort, Honduras", new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), "2995 Padberg Overpass, North Brionnamouth, France", new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8418032c-cef8-467e-a7a0-ca9159b7414d"), new DateTime(2023, 10, 22, 22, 18, 41, 59, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 10, 26, 22, 18, 41, 59, DateTimeKind.Local).AddTicks(6875), 16.54m, true, new Guid("8418032c-cef8-467e-a7a0-ca9159b7414d"), 9915981883971752m, "Courier", 4, 19.68294f, "78465 Kendall Locks, New Eduardoborough, Brazil", new Guid("cfddcc04-5205-447d-9799-6d1945c391b4"), "684 Goodwin Hill, Claudeborough, Central African Republic", new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("847c8e18-662d-4c9f-9641-2585d1e67b4f"), new DateTime(2024, 5, 19, 13, 16, 45, 93, DateTimeKind.Local).AddTicks(9257), new DateTime(2024, 5, 27, 13, 16, 45, 93, DateTimeKind.Local).AddTicks(9257), 62.13m, true, new Guid("847c8e18-662d-4c9f-9641-2585d1e67b4f"), 1794386794724216m, true, "Courier", 5, 38.67188f, "22423 Cleveland Vista, South Brown, Greece", new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305"), "6877 Glen Island, New Keagan, Uganda", new Guid("3be56def-eb89-4486-8258-b67aa1cf9957"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("86ffbb25-4e38-46a3-a97f-a4719381b144"), new DateTime(2023, 6, 23, 11, 21, 15, 37, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 7, 2, 11, 21, 15, 37, DateTimeKind.Local).AddTicks(9430), 73.82m, new Guid("86ffbb25-4e38-46a3-a97f-a4719381b144"), 1549674429054858m, true, "Courier", 1, 1.0755774f, "13143 Tony Island, South Enid, Iraq", new Guid("f7e86b66-49eb-4774-82be-b008350dc98b"), "693 Nienow Plains, Towneshire, Botswana", new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("87a9cd1d-014a-4914-b65f-bf516b33ad12"), new DateTime(2023, 8, 18, 19, 32, 13, 658, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 8, 24, 19, 32, 13, 658, DateTimeKind.Local).AddTicks(3443), 21.75m, true, new Guid("87a9cd1d-014a-4914-b65f-bf516b33ad12"), 3919980747721226m, "Special", 1, 45.667027f, "3222 Considine Grove, Lake Leonard, Mayotte", new Guid("d2398055-2472-48c3-a850-a08fbba5c777"), "658 Sipes Rapid, Jaredburgh, Togo", new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8b2c0bd8-31cd-43b7-a6e4-eaa97623e494"), new DateTime(2024, 1, 18, 17, 12, 53, 374, DateTimeKind.Local).AddTicks(5945), new DateTime(2024, 1, 23, 17, 12, 53, 374, DateTimeKind.Local).AddTicks(5945), 57.67m, new Guid("8b2c0bd8-31cd-43b7-a6e4-eaa97623e494"), 5308366681225928m, "Special", 5, 7.2283883f, "98389 Schuster Glen, Vitamouth, Madagascar", new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65"), "262 Patrick Village, Port Tylerfort, Italy", new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8d509e08-e11f-4d3b-9ee9-dbface3df712"), new DateTime(2024, 6, 2, 16, 55, 34, 287, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 6, 10, 16, 55, 34, 287, DateTimeKind.Local).AddTicks(4522), 41.14m, true, new Guid("8d509e08-e11f-4d3b-9ee9-dbface3df712"), 9919892451742564m, "Super", 5, 49.893494f, "227 Franecki Meadows, East Ginachester, Cocos (Keeling) Islands", new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), "673 Gulgowski Pine, Lake Peytonshire, China", new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8dd6973f-7bc7-40b8-ac0d-bc0e65ee660c"), new DateTime(2023, 11, 19, 15, 27, 28, 292, DateTimeKind.Local).AddTicks(687), new DateTime(2023, 11, 25, 15, 27, 28, 292, DateTimeKind.Local).AddTicks(687), 54.25m, new Guid("8dd6973f-7bc7-40b8-ac0d-bc0e65ee660c"), 9539243736269490m, "Courier", 5, 17.811762f, "204 Estrella Pass, Bodeville, Saint Helena", new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674"), "8291 Feil Pine, New Rosamond, Samoa", new Guid("0136c022-fcf1-47a8-a481-723709054ce0"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("919a27fb-71ff-4207-ab18-4e50a343f5e0"), new DateTime(2023, 7, 29, 14, 0, 45, 575, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 8, 1, 14, 0, 45, 575, DateTimeKind.Local).AddTicks(4820), 89.00m, true, new Guid("919a27fb-71ff-4207-ab18-4e50a343f5e0"), 2188178285271434m, "Special", 1, 36.819668f, "1245 Buckridge Stream, Lemkeshire, Poland", new Guid("0462fe55-138a-4c03-a20d-8251dee6c206"), "323 Jones Cliffs, Bergnaumberg, Cayman Islands", new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9234dde1-4bec-4b68-a42d-355cb88e9009"), new DateTime(2024, 4, 19, 12, 35, 43, 250, DateTimeKind.Local).AddTicks(695), new DateTime(2024, 4, 29, 12, 35, 43, 250, DateTimeKind.Local).AddTicks(695), 87.88m, true, new Guid("9234dde1-4bec-4b68-a42d-355cb88e9009"), 8534337016158037m, true, "Courier", 2, 44.54449f, "62730 Sincere Lights, Johanfort, Honduras", new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88"), "16378 Hahn Fork, West Heather, Malta", new Guid("08e83522-0abb-4778-9027-c86ca1a0a624"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9dacacd7-2d35-4c45-8486-639f7ef52f64"), new DateTime(2024, 2, 29, 4, 1, 15, 547, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 3, 5, 4, 1, 15, 547, DateTimeKind.Local).AddTicks(303), 16.63m, true, new Guid("9dacacd7-2d35-4c45-8486-639f7ef52f64"), 1317257108994495m, "Courier", 1, 8.066632f, "544 Reece Courts, North Griffin, Dominica", new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa"), "816 Kassulke Crossroad, Lake Gracielaburgh, Colombia", new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a0218390-44fd-42a3-9a62-a808804397e2"), new DateTime(2023, 8, 12, 9, 44, 38, 952, DateTimeKind.Local).AddTicks(1899), new DateTime(2023, 8, 18, 9, 44, 38, 952, DateTimeKind.Local).AddTicks(1899), 70.56m, new Guid("a0218390-44fd-42a3-9a62-a808804397e2"), 8056625018833018m, "Courier", 4, 12.158339f, "049 Champlin Oval, Elinoremouth, Zimbabwe", new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11"), "8999 Ruthie Garden, Dickensberg, Kyrgyz Republic", new Guid("05d888a7-8474-4565-b751-a89df2400346"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a108ee3d-6a13-428c-9a85-ef7a67d5738b"), new DateTime(2024, 3, 29, 17, 1, 37, 729, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 4, 5, 17, 1, 37, 729, DateTimeKind.Local).AddTicks(8827), 52.25m, true, new Guid("a108ee3d-6a13-428c-9a85-ef7a67d5738b"), 8344060588853467m, true, "ParcelMachine", 5, 35.467186f, "999 Bernier Hills, Mullerland, Vietnam", new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), "48375 Waters Harbors, Sengerfort, Iran", new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a209860d-8dbf-4e21-b02c-96c3a97271bb"), new DateTime(2024, 2, 10, 8, 0, 30, 241, DateTimeKind.Local).AddTicks(7021), new DateTime(2024, 2, 11, 8, 0, 30, 241, DateTimeKind.Local).AddTicks(7021), 44.92m, new Guid("a209860d-8dbf-4e21-b02c-96c3a97271bb"), 8020717131254187m, true, "ParcelMachine", 2, 40.67794f, "4752 Schneider Ferry, Lake Samantaborough, Bangladesh", new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea"), "473 Schinner Port, Trompstad, Lesotho", new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a2ca46ad-7644-4232-b9bc-827c91641948"), new DateTime(2024, 5, 30, 18, 23, 49, 867, DateTimeKind.Local).AddTicks(2308), new DateTime(2024, 6, 7, 18, 23, 49, 867, DateTimeKind.Local).AddTicks(2308), 44.74m, new Guid("a2ca46ad-7644-4232-b9bc-827c91641948"), 5509007606501794m, "Standart", 4, 8.232736f, "80195 Kari Via, South Amie, Ecuador", new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa"), "68871 Homenick Spur, Ratkefurt, Kazakhstan", new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a5a19df4-414a-4c67-84f7-551286fca349"), new DateTime(2023, 9, 20, 9, 20, 28, 903, DateTimeKind.Local).AddTicks(177), new DateTime(2023, 9, 27, 9, 20, 28, 903, DateTimeKind.Local).AddTicks(177), 27.88m, true, new Guid("a5a19df4-414a-4c67-84f7-551286fca349"), 7758077345100133m, true, "Standart", 2, 18.89291f, "63896 Brady Mountain, Abbieville, Macedonia", new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8"), "7268 Mosciski River, North Cheyannetown, Mayotte", new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("abb4168f-63f0-46c4-8833-9afa56963acb"), new DateTime(2023, 10, 14, 23, 44, 11, 464, DateTimeKind.Local).AddTicks(1255), new DateTime(2023, 10, 20, 23, 44, 11, 464, DateTimeKind.Local).AddTicks(1255), 18.83m, true, new Guid("abb4168f-63f0-46c4-8833-9afa56963acb"), 2018746977056258m, "ParcelMachine", 5, 36.419792f, "845 Louisa Forges, Lake Orin, Guatemala", new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884"), "5607 Rodriguez Drive, Cummerataville, Eritrea", new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ae88b5c9-da23-4cd4-842c-fed3ae3de794"), new DateTime(2023, 11, 20, 18, 10, 55, 587, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 11, 25, 18, 10, 55, 587, DateTimeKind.Local).AddTicks(7288), 56.33m, new Guid("ae88b5c9-da23-4cd4-842c-fed3ae3de794"), 8555243703357114m, true, "Super", 5, 33.752876f, "2011 Cecil Keys, South Jonathan, Italy", new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb"), "2788 Witting Shore, South Juston, Ecuador", new Guid("f7e86b66-49eb-4774-82be-b008350dc98b"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("af0a81f6-4cd1-4c6a-b1b4-dd052c30b338"), new DateTime(2023, 12, 9, 0, 39, 9, 318, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 12, 13, 0, 39, 9, 318, DateTimeKind.Local).AddTicks(9649), 64.00m, true, new Guid("af0a81f6-4cd1-4c6a-b1b4-dd052c30b338"), 1648246941040927m, "ParcelMachine", 4, 49.868614f, "294 Barton Spur, East Crystal, El Salvador", new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d"), "3805 Danial Flat, Lake Keara, Argentina", new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b0469e84-e5b4-45c2-bb9d-292e94c0f117"), new DateTime(2023, 8, 2, 4, 57, 20, 244, DateTimeKind.Local).AddTicks(4184), new DateTime(2023, 8, 10, 4, 57, 20, 244, DateTimeKind.Local).AddTicks(4184), 18.94m, true, new Guid("b0469e84-e5b4-45c2-bb9d-292e94c0f117"), 1901926733593558m, true, "Courier", 5, 0.61072534f, "34351 MacGyver Trafficway, Trompberg, Romania", new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6"), "19111 Lindsay Burgs, Kihnchester, India", new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b08f81a7-7db1-4fb9-a229-1011f287cb18"), new DateTime(2024, 5, 26, 19, 25, 2, 394, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 6, 1, 19, 25, 2, 394, DateTimeKind.Local).AddTicks(8146), 77.43m, new Guid("b08f81a7-7db1-4fb9-a229-1011f287cb18"), 7617122604180733m, true, "ParcelMachine", 4, 47.621468f, "4368 Feil Dale, Lake Emerald, Switzerland", new Guid("e2125995-cb39-40eb-b23a-1483130a7d40"), "2704 Twila Pass, Borisland, Bahamas", new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("b47c5ce3-d155-420a-9b00-6f0048570dd6"), new DateTime(2024, 3, 26, 6, 25, 55, 977, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 4, 1, 6, 25, 55, 977, DateTimeKind.Local).AddTicks(2289), 25.74m, true, new Guid("b47c5ce3-d155-420a-9b00-6f0048570dd6"), 4714821865676872m, true, "Courier", 3, 37.494f, "0994 Salvatore Overpass, Hintzchester, Holy See (Vatican City State)", new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de"), "829 Keeling Parks, Evangelineburgh, Saint Helena", new Guid("86555a53-2ae1-40b3-98c6-17036425dac8"), "Registered", "PlasticBag" },
                    { new Guid("b80289ef-15e0-4f5e-87d2-a2560658a0c5"), new DateTime(2024, 3, 25, 13, 43, 52, 599, DateTimeKind.Local).AddTicks(9697), new DateTime(2024, 4, 3, 13, 43, 52, 599, DateTimeKind.Local).AddTicks(9697), 36.59m, true, new Guid("b80289ef-15e0-4f5e-87d2-a2560658a0c5"), 3124402208054110m, true, "Super", 1, 35.120445f, "6658 Dawson Station, Carmelstad, Trinidad and Tobago", new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9"), "90505 Johnson Extension, Adalineview, Oman", new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b83c3ff6-b51f-47c4-b3da-517ba5847b58"), new DateTime(2023, 8, 18, 6, 4, 58, 653, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 8, 20, 6, 4, 58, 653, DateTimeKind.Local).AddTicks(4968), 91.48m, new Guid("b83c3ff6-b51f-47c4-b3da-517ba5847b58"), 2457806791801323m, true, "ParcelMachine", 3, 24.418264f, "7344 Rowe Locks, South Marcia, Benin", new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420"), "734 Julius Pines, Port Reynaview, Seychelles", new Guid("33d5b081-5c0f-4871-905f-631caba91848"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b8fbb0c4-9810-4f4b-9f5a-57fa52fabd38"), new DateTime(2023, 12, 8, 10, 58, 14, 826, DateTimeKind.Local).AddTicks(4108), new DateTime(2023, 12, 10, 10, 58, 14, 826, DateTimeKind.Local).AddTicks(4108), 44.62m, true, new Guid("b8fbb0c4-9810-4f4b-9f5a-57fa52fabd38"), 4196119079179336m, true, "Courier", 2, 33.590122f, "2367 Stokes Ports, Townefort, Zimbabwe", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "62208 Emory Plaza, Bernieceborough, Burundi", new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bc6d105f-69ee-442b-be8e-1571fa766aa6"), new DateTime(2023, 8, 26, 4, 40, 24, 168, DateTimeKind.Local).AddTicks(7512), new DateTime(2023, 8, 27, 4, 40, 24, 168, DateTimeKind.Local).AddTicks(7512), 44.59m, true, new Guid("bc6d105f-69ee-442b-be8e-1571fa766aa6"), 3325258469028836m, "Super", 2, 27.678478f, "5065 Pfannerstill Corners, Robynfort, Venezuela", new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76"), "200 Fisher Drives, North Bernitaton, Cayman Islands", new Guid("665af7ab-85d3-48f3-bedd-30db54699f81"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bed3c71c-b453-40cb-bf52-894313ba18bf"), new DateTime(2024, 5, 28, 9, 31, 11, 8, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 6, 6, 9, 31, 11, 8, DateTimeKind.Local).AddTicks(5241), 82.36m, true, new Guid("bed3c71c-b453-40cb-bf52-894313ba18bf"), 7744813602870979m, true, "Super", 4, 18.637989f, "19357 Goldner Run, Smithammouth, Vanuatu", new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20"), "3829 Abshire Lane, Corkerytown, Lao People's Democratic Republic", new Guid("f7e86b66-49eb-4774-82be-b008350dc98b"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c112d31f-788b-49e5-b63b-965befa714d3"), new DateTime(2023, 11, 14, 6, 45, 6, 344, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 11, 17, 6, 45, 6, 344, DateTimeKind.Local).AddTicks(4694), 46.81m, new Guid("c112d31f-788b-49e5-b63b-965befa714d3"), 4266229631023949m, "Special", 5, 21.287422f, "28626 Edgar Roads, Lake Barbarachester, Bolivia", new Guid("35482730-4c7a-4e01-aeca-0748f3123997"), "7321 D'Amore Neck, North Destany, Bahrain", new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c196c5f7-b5f1-41ff-a9ff-65137edc332b"), new DateTime(2023, 12, 18, 15, 39, 37, 111, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 12, 19, 15, 39, 37, 111, DateTimeKind.Local).AddTicks(6834), 67.29m, new Guid("c196c5f7-b5f1-41ff-a9ff-65137edc332b"), 7836957367954458m, "ParcelMachine", 2, 15.113769f, "153 Lucile Landing, North Jessikatown, Iran", new Guid("482c0758-a476-404a-ade3-01c0818a58f9"), "0563 Malcolm Oval, Carrollshire, Svalbard & Jan Mayen Islands", new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c50fe85e-6f77-44d6-a0fb-b2e797ac8913"), new DateTime(2024, 3, 9, 0, 38, 2, 739, DateTimeKind.Local).AddTicks(4393), new DateTime(2024, 3, 13, 0, 38, 2, 739, DateTimeKind.Local).AddTicks(4393), 88.88m, true, new Guid("c50fe85e-6f77-44d6-a0fb-b2e797ac8913"), 6870547782438992m, true, "ParcelMachine", 5, 19.867455f, "394 Arlie Haven, Lake Gaston, Cook Islands", new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4"), "28342 Veum Lodge, Port Ashleighfort, Bhutan", new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c67e609a-5406-4ccc-a360-523af713b756"), new DateTime(2023, 12, 17, 2, 48, 47, 279, DateTimeKind.Local).AddTicks(2016), new DateTime(2023, 12, 18, 2, 48, 47, 279, DateTimeKind.Local).AddTicks(2016), 50.14m, true, new Guid("c67e609a-5406-4ccc-a360-523af713b756"), 6327539139979583m, "ParcelMachine", 4, 49.61077f, "6918 Halvorson Field, South Hayley, Tuvalu", new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899"), "9216 Casandra Skyway, Okunevashire, Ireland", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c7dadf45-2912-40b6-8a2f-cad5d25ce921"), new DateTime(2024, 1, 2, 20, 46, 4, 229, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 1, 8, 20, 46, 4, 229, DateTimeKind.Local).AddTicks(399), 55.73m, new Guid("c7dadf45-2912-40b6-8a2f-cad5d25ce921"), 4222236520908453m, true, "Courier", 4, 6.315061f, "6279 Aaliyah Drive, Dangelofurt, Germany", new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0"), "753 Hickle Locks, Lyricchester, New Caledonia", new Guid("049885cb-e0f2-4131-a44d-71fb5816c410"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("c9968f61-a828-4216-ac1b-aa475f09ee8e"), new DateTime(2024, 3, 4, 9, 23, 46, 116, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 3, 10, 9, 23, 46, 116, DateTimeKind.Local).AddTicks(6891), 11.73m, true, new Guid("c9968f61-a828-4216-ac1b-aa475f09ee8e"), 3505847524180036m, "Courier", 1, 9.262951f, "63443 Hope Meadows, Lake Junebury, Gabon", new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884"), "23806 Hansen Plains, Lake Harmon, Cape Verde", new Guid("3793c254-cd3f-4c42-93fb-0895042668c7"), "OnTheWay", "CardboardBox" },
                    { new Guid("ce51d728-7317-4920-bbd5-011e7365ecb6"), new DateTime(2023, 7, 8, 21, 45, 8, 824, DateTimeKind.Local).AddTicks(7115), new DateTime(2023, 7, 14, 21, 45, 8, 824, DateTimeKind.Local).AddTicks(7115), 21.58m, true, new Guid("ce51d728-7317-4920-bbd5-011e7365ecb6"), 6269286608045201m, "Super", 1, 23.337723f, "88215 Schmeler Squares, Port Chloe, Faroe Islands", new Guid("35b6c210-2256-41cd-af8e-e815527e0a84"), "336 June Isle, Donatohaven, Sierra Leone", new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d3444318-fb58-40eb-bd24-d9d6162e6f94"), new DateTime(2023, 7, 13, 1, 21, 12, 223, DateTimeKind.Local).AddTicks(9735), new DateTime(2023, 7, 15, 1, 21, 12, 223, DateTimeKind.Local).AddTicks(9735), 65.22m, true, new Guid("d3444318-fb58-40eb-bd24-d9d6162e6f94"), 2399829332794892m, true, "Courier", 3, 9.537003f, "077 Hilpert Lane, Mullertown, Czech Republic", new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7"), "9836 Diamond Causeway, South Allene, Zimbabwe", new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d6a5cff9-5c29-497e-a848-80217ea73bbe"), new DateTime(2023, 12, 21, 19, 48, 50, 804, DateTimeKind.Local).AddTicks(7923), new DateTime(2023, 12, 25, 19, 48, 50, 804, DateTimeKind.Local).AddTicks(7923), 55.61m, true, new Guid("d6a5cff9-5c29-497e-a848-80217ea73bbe"), 5735809782931111m, "Courier", 4, 31.766712f, "0688 Schmidt Club, Torpmouth, Reunion", new Guid("0823436c-27ad-4402-b5e2-b17efa08505e"), "969 Schmeler Wells, Kreigerview, Germany", new Guid("35b6c210-2256-41cd-af8e-e815527e0a84"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("d70d2f36-d2c4-4e34-bb36-ceb3444c7f55"), new DateTime(2023, 6, 7, 15, 48, 49, 544, DateTimeKind.Local).AddTicks(111), new DateTime(2023, 6, 15, 15, 48, 49, 544, DateTimeKind.Local).AddTicks(111), 32.46m, new Guid("d70d2f36-d2c4-4e34-bb36-ceb3444c7f55"), 8676951402477030m, "Super", 4, 24.85882f, "68556 Jammie Mission, Lake Brisaside, French Polynesia", new Guid("665af7ab-85d3-48f3-bedd-30db54699f81"), "886 Orlando Viaduct, Schillerhaven, Chad", new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861"), "Registered", "PlasticBag" },
                    { new Guid("dc466cf5-d794-4663-8e9c-990711d2311b"), new DateTime(2023, 6, 7, 5, 47, 23, 500, DateTimeKind.Local).AddTicks(5337), new DateTime(2023, 6, 10, 5, 47, 23, 500, DateTimeKind.Local).AddTicks(5337), 30.62m, new Guid("dc466cf5-d794-4663-8e9c-990711d2311b"), 9099529280349644m, "Super", 1, 40.796467f, "94651 Bradtke Track, Marianaview, Uganda", new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d"), "966 Gislason Rest, Russeltown, Estonia", new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("de5aeaf5-27c8-44d3-a0ce-d5497be874ef"), new DateTime(2024, 3, 22, 2, 2, 6, 994, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 4, 1, 2, 2, 6, 994, DateTimeKind.Local).AddTicks(1424), 62.95m, true, new Guid("de5aeaf5-27c8-44d3-a0ce-d5497be874ef"), 8223929235403274m, true, "Super", 2, 40.92323f, "3872 Camilla Pine, Abernathyhaven, Mexico", new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e"), "34643 Schiller Locks, Montanamouth, Samoa", new Guid("12b74093-45e4-451e-b1a4-f4797f48c780"), "OnTheWay", "CardboardBox" },
                    { new Guid("e30a2e08-b595-456f-9b70-b582c75bba85"), new DateTime(2024, 2, 26, 18, 49, 14, 813, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 3, 4, 18, 49, 14, 813, DateTimeKind.Local).AddTicks(1091), 65.22m, true, new Guid("e30a2e08-b595-456f-9b70-b582c75bba85"), 1565304160420689m, true, "Special", 5, 3.2511623f, "705 Laurie Bypass, Steuberbury, Chile", new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5"), "5019 Kaitlin Skyway, Domingotown, Benin", new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e85c5332-e6a5-4b58-83fb-eb4371d29d59"), new DateTime(2023, 10, 24, 10, 35, 48, 206, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 10, 28, 10, 35, 48, 206, DateTimeKind.Local).AddTicks(3325), 38.87m, true, new Guid("e85c5332-e6a5-4b58-83fb-eb4371d29d59"), 8919838655291749m, "ParcelMachine", 4, 33.94556f, "85727 Enoch Wall, Zoeyborough, Kazakhstan", new Guid("33d5b081-5c0f-4871-905f-631caba91848"), "62402 Morissette Inlet, Vonborough, Jersey", new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ebcc2e65-5d5a-487a-8dac-4fce0633002d"), new DateTime(2023, 11, 15, 16, 28, 39, 982, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 11, 23, 16, 28, 39, 982, DateTimeKind.Local).AddTicks(5800), 22.16m, true, new Guid("ebcc2e65-5d5a-487a-8dac-4fce0633002d"), 6940451772371468m, true, "Standart", 3, 48.807674f, "79376 Karianne Circle, Andersonport, Moldova", new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272"), "250 West Extensions, Salmastad, Macao", new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ed8fc330-fab0-4395-9d8d-f93addc833c7"), new DateTime(2023, 12, 18, 12, 52, 42, 997, DateTimeKind.Local).AddTicks(3509), new DateTime(2023, 12, 23, 12, 52, 42, 997, DateTimeKind.Local).AddTicks(3509), 30.88m, new Guid("ed8fc330-fab0-4395-9d8d-f93addc833c7"), 9685587072392116m, true, "ParcelMachine", 5, 37.833885f, "5535 Wuckert Gardens, New Frank, Macedonia", new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9"), "88093 Cade Crest, Adamsmouth, United Arab Emirates", new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("efddbdf3-c7d4-4e23-817d-c182f5e1ecde"), new DateTime(2024, 1, 10, 13, 28, 29, 94, DateTimeKind.Local).AddTicks(3624), new DateTime(2024, 1, 12, 13, 28, 29, 94, DateTimeKind.Local).AddTicks(3624), 30.21m, new Guid("efddbdf3-c7d4-4e23-817d-c182f5e1ecde"), 1090779193658984m, "Special", 3, 31.740957f, "401 Bernhard Orchard, South Kiel, Pakistan", new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73"), "65530 Sid Station, Lake Addie, Iraq", new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f2b61af1-76a3-4cf0-8901-a4ffcbd7b499"), new DateTime(2024, 2, 20, 11, 12, 50, 762, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 2, 27, 11, 12, 50, 762, DateTimeKind.Local).AddTicks(6394), 78.83m, true, new Guid("f2b61af1-76a3-4cf0-8901-a4ffcbd7b499"), 5038734887108156m, true, "Courier", 1, 27.289083f, "555 Chad Summit, Port Easton, Cuba", new Guid("5558c531-153b-4da7-9848-996b07daa782"), "50239 Hickle Coves, Schambergerton, Israel", new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), "Registered", "CardboardBox" },
                    { new Guid("f72f4e1c-11fe-4ef2-9e15-1f9da637d7ae"), new DateTime(2024, 2, 2, 15, 38, 57, 273, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 2, 8, 15, 38, 57, 273, DateTimeKind.Local).AddTicks(9349), 12.04m, true, new Guid("f72f4e1c-11fe-4ef2-9e15-1f9da637d7ae"), 6757279495077742m, true, "Courier", 3, 42.998898f, "462 Feeney Island, Jaymeberg, Monaco", new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a"), "63751 Ryder Stravenue, Bulahville, Chad", new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fa2a0e73-af9a-4a38-819f-9d92757d98ad"), new DateTime(2024, 3, 18, 3, 0, 11, 517, DateTimeKind.Local).AddTicks(1383), new DateTime(2024, 3, 25, 3, 0, 11, 517, DateTimeKind.Local).AddTicks(1383), 56.17m, true, new Guid("fa2a0e73-af9a-4a38-819f-9d92757d98ad"), 8655457811579560m, "Super", 5, 49.333477f, "53738 Price Burgs, Schoenshire, Libyan Arab Jamahiriya", new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), "582 Walsh Brooks, Port Harry, Anguilla", new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "Id", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("fde24e55-1a8c-4d9d-b94b-298f6ef9d33b"), new DateTime(2023, 8, 6, 22, 11, 53, 193, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 8, 10, 22, 11, 53, 193, DateTimeKind.Local).AddTicks(506), 59.94m, new Guid("fde24e55-1a8c-4d9d-b94b-298f6ef9d33b"), 8818130690755424m, "Special", 3, 19.545769f, "5606 Hegmann Light, Sherwoodtown, Bolivia", new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7"), "32765 Darrion River, North Thea, Moldova", new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa"), "Delivered", "CardboardBox" },
                    { new Guid("ff677c8d-5a8e-4830-9cd1-51edb1af6bc3"), new DateTime(2023, 8, 22, 5, 19, 54, 148, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 8, 30, 5, 19, 54, 148, DateTimeKind.Local).AddTicks(1613), 84.64m, new Guid("ff677c8d-5a8e-4830-9cd1-51edb1af6bc3"), 8243990471697086m, "Super", 2, 6.931689f, "9902 Cecilia Alley, Lake Josieborough, Somalia", new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), "16020 Satterfield Roads, North Destineyton, Burundi", new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("009ba232-ecb5-45ec-a2b8-49c9061c0e24"), "488", "3480503175617248", new Guid("009ba232-ecb5-45ec-a2b8-49c9061c0e24"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042"), "11/04" },
                    { new Guid("00d09436-d404-4744-b511-aa541d0d3677"), "551", "5081046718821548", new Guid("00d09436-d404-4744-b511-aa541d0d3677"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98"), "11/02" },
                    { new Guid("01348eab-b422-4121-95da-607700816ebe"), "881", "7418918770075022", new Guid("01348eab-b422-4121-95da-607700816ebe"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884"), "01/05" },
                    { new Guid("013da4e7-339d-4341-90f3-e76b08df8909"), "851", "5207835509307122", new Guid("013da4e7-339d-4341-90f3-e76b08df8909"), new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26"), "12/15" },
                    { new Guid("013e88a4-a998-49f2-8359-8d19796df0d6"), "900", "6307502340125611", new Guid("013e88a4-a998-49f2-8359-8d19796df0d6"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0"), "03/17" },
                    { new Guid("02a0d1f9-392e-4de5-8f1b-1458468da90f"), "552", "8964066862099021", new Guid("02a0d1f9-392e-4de5-8f1b-1458468da90f"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342"), "12/08" },
                    { new Guid("02be9942-6b87-45c4-a990-f11a674b9c16"), "685", "9951603848636663", new Guid("02be9942-6b87-45c4-a990-f11a674b9c16"), new Guid("f1038abe-cd17-40c4-844a-70a0ee863724"), "02/28" },
                    { new Guid("02d8039b-9663-4e35-a0ce-600ff5463e93"), "190", "6960056686720266", new Guid("02d8039b-9663-4e35-a0ce-600ff5463e93"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), "08/17" },
                    { new Guid("03ec4a68-0bd9-45ec-996f-55457ce6da87"), "558", "5596722502634557", new Guid("03ec4a68-0bd9-45ec-996f-55457ce6da87"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918"), "03/17" },
                    { new Guid("03fb17de-d946-4cb6-a1ce-bb7bae0d3cd7"), "392", "4564538575555949", new Guid("03fb17de-d946-4cb6-a1ce-bb7bae0d3cd7"), new Guid("8b896efc-3b46-4670-bb2b-740919a113b5"), "11/20" },
                    { new Guid("04372812-c482-4890-b869-3cfcc5bbaa91"), "558", "6606958458230753", new Guid("04372812-c482-4890-b869-3cfcc5bbaa91"), new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0"), "03/17" },
                    { new Guid("04420d5c-c9a9-494e-b5a2-7ae382cb7179"), "977", "2137117015670230", new Guid("04420d5c-c9a9-494e-b5a2-7ae382cb7179"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73"), "04/24" },
                    { new Guid("04492f9f-3e7a-4c3b-81fc-387f281f35e8"), "550", "1845645822050119", new Guid("04492f9f-3e7a-4c3b-81fc-387f281f35e8"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0"), "09/27" },
                    { new Guid("04902ed1-0fc7-4c3d-8ba6-7eb0a7af67ee"), "074", "8759547396455851", new Guid("04902ed1-0fc7-4c3d-8ba6-7eb0a7af67ee"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556"), "07/16" },
                    { new Guid("05095a1c-dfe5-4337-8ff8-10951984be5c"), "748", "3944059670786190", new Guid("05095a1c-dfe5-4337-8ff8-10951984be5c"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3"), "10/10" },
                    { new Guid("0523db2f-c2ba-4821-acd9-ad76a28ad86f"), "297", "8284345486553655", new Guid("0523db2f-c2ba-4821-acd9-ad76a28ad86f"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95"), "04/06" },
                    { new Guid("053866b4-fd6c-42d6-a35e-235869e3670a"), "343", "2108979770438094", new Guid("053866b4-fd6c-42d6-a35e-235869e3670a"), new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63"), "12/23" },
                    { new Guid("058a8a81-1539-432a-9ec1-6904a8ade1e8"), "445", "7277499942257978", new Guid("058a8a81-1539-432a-9ec1-6904a8ade1e8"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511"), "01/03" },
                    { new Guid("059068ab-71cc-461b-b9b4-d3330e07dee1"), "911", "9632908563955837", new Guid("059068ab-71cc-461b-b9b4-d3330e07dee1"), new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7"), "09/04" },
                    { new Guid("05a23e6d-279f-4a84-9730-28ae71ca31ad"), "251", "4323476671636464", new Guid("05a23e6d-279f-4a84-9730-28ae71ca31ad"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e"), "11/21" },
                    { new Guid("05a7ac5d-b489-43d7-b4c9-7daccbe07f8a"), "587", "2444064738538416", new Guid("05a7ac5d-b489-43d7-b4c9-7daccbe07f8a"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76"), "04/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0646ab4c-fc16-422f-9827-bcc394c7900d"), "466", "6555941251859760", new Guid("0646ab4c-fc16-422f-9827-bcc394c7900d"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), "06/22" },
                    { new Guid("06649072-b8e4-442f-b88c-f52aa9528225"), "198", "3702137525412597", new Guid("06649072-b8e4-442f-b88c-f52aa9528225"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), "09/27" },
                    { new Guid("070e24ee-61ef-4eda-a15e-d851e9cbb2de"), "497", "3981038026251793", new Guid("070e24ee-61ef-4eda-a15e-d851e9cbb2de"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd"), "12/03" },
                    { new Guid("0763a07c-b7f6-4d30-9f19-a26a7f4f7b76"), "294", "5904851788845924", new Guid("0763a07c-b7f6-4d30-9f19-a26a7f4f7b76"), new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2"), "10/26" },
                    { new Guid("079dacba-8212-417a-b1a1-c0392784b916"), "785", "2907034899904518", new Guid("079dacba-8212-417a-b1a1-c0392784b916"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05"), "05/14" },
                    { new Guid("07cd9d17-274b-4b45-bf5e-b5ed8d28e093"), "157", "4119963658469047", new Guid("07cd9d17-274b-4b45-bf5e-b5ed8d28e093"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884"), "04/04" },
                    { new Guid("07d3242b-fbf2-4ed0-9df0-63c1ddf5ac4d"), "401", "9339146167940146", new Guid("07d3242b-fbf2-4ed0-9df0-63c1ddf5ac4d"), new Guid("12656ae7-3922-41ca-b159-f79b439a354c"), "10/21" },
                    { new Guid("08215d47-4385-4936-a983-3e43761f3ae2"), "108", "6606053160866825", new Guid("08215d47-4385-4936-a983-3e43761f3ae2"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777"), "12/28" },
                    { new Guid("082cea4b-9fc4-4fa7-8cb9-931527eebef6"), "472", "8453475362448146", new Guid("082cea4b-9fc4-4fa7-8cb9-931527eebef6"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95"), "09/13" },
                    { new Guid("085910bf-f775-4f69-88a5-428add94e858"), "172", "3214682082380923", new Guid("085910bf-f775-4f69-88a5-428add94e858"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0"), "08/25" },
                    { new Guid("0882f026-b77d-49a2-9721-e81995023cc6"), "092", "9501683088662243", new Guid("0882f026-b77d-49a2-9721-e81995023cc6"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186"), "05/10" },
                    { new Guid("08eb122c-d7ab-45e3-8146-2cd60ac89f5f"), "902", "7038266389590444", new Guid("08eb122c-d7ab-45e3-8146-2cd60ac89f5f"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593"), "03/09" },
                    { new Guid("094c4563-4f59-4f1f-888f-a345341b49d6"), "066", "3658745257082371", new Guid("094c4563-4f59-4f1f-888f-a345341b49d6"), new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456"), "04/01" },
                    { new Guid("09b6d9ef-4844-4b13-b67b-c41dc11f06ea"), "040", "9889934266073868", new Guid("09b6d9ef-4844-4b13-b67b-c41dc11f06ea"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81"), "04/21" },
                    { new Guid("09b96fe7-6106-451b-9a72-d1475f028eb8"), "738", "8574676245530726", new Guid("09b96fe7-6106-451b-9a72-d1475f028eb8"), new Guid("9f745913-393e-4d75-924b-12ed8606f936"), "11/16" },
                    { new Guid("09ec6272-34cf-43d9-a67e-21e39478871a"), "121", "7291650145881835", new Guid("09ec6272-34cf-43d9-a67e-21e39478871a"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626"), "06/14" },
                    { new Guid("0a1cdc0e-0d94-4e9b-8565-f176986cd0d7"), "613", "3535852949660255", new Guid("0a1cdc0e-0d94-4e9b-8565-f176986cd0d7"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84"), "07/14" },
                    { new Guid("0a910dd2-2fce-45d2-b179-ea003b94eb6f"), "462", "2001005384541200", new Guid("0a910dd2-2fce-45d2-b179-ea003b94eb6f"), new Guid("314374c4-1bd7-4eda-8546-58617e464254"), "11/03" },
                    { new Guid("0ac245e0-6533-4960-b12d-5d894a1bf37f"), "510", "5434448007506969", new Guid("0ac245e0-6533-4960-b12d-5d894a1bf37f"), new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7"), "02/02" },
                    { new Guid("0aeba3a8-6a64-4ca4-ae5d-84b2765c896c"), "391", "2903759707411450", new Guid("0aeba3a8-6a64-4ca4-ae5d-84b2765c896c"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26"), "08/07" },
                    { new Guid("0c20d097-5d3c-4660-bea5-c04a6feea5c9"), "663", "9110658740684475", new Guid("0c20d097-5d3c-4660-bea5-c04a6feea5c9"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d"), "02/01" },
                    { new Guid("0c23b5aa-7f97-45bb-8324-017383d092d4"), "280", "7294890154823745", new Guid("0c23b5aa-7f97-45bb-8324-017383d092d4"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b"), "02/03" },
                    { new Guid("0c3e2e09-f451-4560-81f7-1d875821b51e"), "818", "5022461800318185", new Guid("0c3e2e09-f451-4560-81f7-1d875821b51e"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40"), "06/14" },
                    { new Guid("0d5397c7-8e33-4de4-855b-3c094291b896"), "594", "1462846712818796", new Guid("0d5397c7-8e33-4de4-855b-3c094291b896"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), "02/04" },
                    { new Guid("0d838d9f-87d3-4399-ab3c-bf82972c882c"), "303", "3100797503129399", new Guid("0d838d9f-87d3-4399-ab3c-bf82972c882c"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b"), "07/07" },
                    { new Guid("0e55de02-ac3e-4145-b6de-28ba1a01fd3f"), "198", "2005507661834386", new Guid("0e55de02-ac3e-4145-b6de-28ba1a01fd3f"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec"), "10/17" },
                    { new Guid("0ec7ad05-415f-4cc6-b07f-d3f065df048b"), "222", "2591538589014615", new Guid("0ec7ad05-415f-4cc6-b07f-d3f065df048b"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5"), "12/20" },
                    { new Guid("0ed1e0f2-be36-4308-bd46-5ae7e6b10e6d"), "191", "1389362509629097", new Guid("0ed1e0f2-be36-4308-bd46-5ae7e6b10e6d"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780"), "02/02" },
                    { new Guid("0f44d455-23e3-4def-82dc-1ce48f23d6bd"), "754", "2108651282323132", new Guid("0f44d455-23e3-4def-82dc-1ce48f23d6bd"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d"), "03/18" },
                    { new Guid("0f507e71-1dfc-4f4e-97bb-26c1241b052f"), "849", "9972286835091278", new Guid("0f507e71-1dfc-4f4e-97bb-26c1241b052f"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4"), "05/13" },
                    { new Guid("0f5d847b-1362-45cb-87c0-89d1558e0511"), "277", "3125221629439036", new Guid("0f5d847b-1362-45cb-87c0-89d1558e0511"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88"), "03/17" },
                    { new Guid("0f632c51-66a6-46b4-a062-422aeff600a8"), "587", "4879162899868137", new Guid("0f632c51-66a6-46b4-a062-422aeff600a8"), new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2"), "11/12" },
                    { new Guid("0f72680b-e00d-4074-8a28-f5decbfce1f3"), "487", "7022063215068663", new Guid("0f72680b-e00d-4074-8a28-f5decbfce1f3"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76"), "12/08" },
                    { new Guid("0ffee70b-7360-463e-8270-234e3a194e46"), "493", "4570312746525587", new Guid("0ffee70b-7360-463e-8270-234e3a194e46"), new Guid("810775de-7e6f-4620-99bb-c534d912de67"), "09/15" },
                    { new Guid("1020d3b5-7857-4d59-94ae-87e6d3db61f0"), "788", "5578277764449691", new Guid("1020d3b5-7857-4d59-94ae-87e6d3db61f0"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593"), "05/17" },
                    { new Guid("1051299b-c8d7-498c-855e-902cbaddf51d"), "925", "1373085782407395", new Guid("1051299b-c8d7-498c-855e-902cbaddf51d"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1"), "05/26" },
                    { new Guid("10546b6d-866b-42d3-bba1-cb21994cc255"), "546", "5268289227650297", new Guid("10546b6d-866b-42d3-bba1-cb21994cc255"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6"), "03/05" },
                    { new Guid("10a2ece5-fa2d-418b-9f52-be4488c21962"), "502", "7534753313862395", new Guid("10a2ece5-fa2d-418b-9f52-be4488c21962"), new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828"), "08/27" },
                    { new Guid("10ed4b77-f0e6-492e-a9c2-12b5180e2f35"), "706", "2371629402783813", new Guid("10ed4b77-f0e6-492e-a9c2-12b5180e2f35"), new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1"), "01/05" },
                    { new Guid("112c0ebb-4333-4d70-ba01-fc8c71159943"), "409", "1307745404605095", new Guid("112c0ebb-4333-4d70-ba01-fc8c71159943"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072"), "12/09" },
                    { new Guid("1139727e-bf1a-4527-be97-9264220f99a3"), "680", "6365108204600590", new Guid("1139727e-bf1a-4527-be97-9264220f99a3"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157"), "05/01" },
                    { new Guid("116fee2d-d4c6-4118-a024-0210182885ea"), "204", "8889175657033745", new Guid("116fee2d-d4c6-4118-a024-0210182885ea"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d"), "01/02" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("1176b035-9484-45c7-be75-b073e7321b29"), "736", "9781812943395938", new Guid("1176b035-9484-45c7-be75-b073e7321b29"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779"), "04/03" },
                    { new Guid("118ffc51-11b5-4518-bcc2-7ba4c7cdcd9d"), "934", "4218338276564478", new Guid("118ffc51-11b5-4518-bcc2-7ba4c7cdcd9d"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95"), "12/10" },
                    { new Guid("11d93699-44d5-4c43-a482-acde72b8b211"), "021", "9165324623489527", new Guid("11d93699-44d5-4c43-a482-acde72b8b211"), new Guid("28f12604-451b-425e-ae23-1db801053b3e"), "01/19" },
                    { new Guid("11e3d4f5-8915-4fac-8ac6-1b012c94a3bc"), "081", "3759664086469804", new Guid("11e3d4f5-8915-4fac-8ac6-1b012c94a3bc"), new Guid("0462fe55-138a-4c03-a20d-8251dee6c206"), "11/25" },
                    { new Guid("12165aab-17de-4f65-9fd5-cd3473d6ddb5"), "715", "8131954889274365", new Guid("12165aab-17de-4f65-9fd5-cd3473d6ddb5"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913"), "11/13" },
                    { new Guid("12264918-b86f-4697-b09c-d21e40069f0c"), "440", "5042296198639765", new Guid("12264918-b86f-4697-b09c-d21e40069f0c"), new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3"), "06/20" },
                    { new Guid("12b9196a-e0e4-4469-8618-63db213a9a96"), "670", "8726621975022892", new Guid("12b9196a-e0e4-4469-8618-63db213a9a96"), new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3"), "10/16" },
                    { new Guid("12f5b225-0c27-4b1d-865a-8b6d2ea8bc47"), "524", "7559596627512344", new Guid("12f5b225-0c27-4b1d-865a-8b6d2ea8bc47"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556"), "10/05" },
                    { new Guid("1300c2bd-698b-407c-8c13-94b5ac01aacd"), "311", "1638110258652893", new Guid("1300c2bd-698b-407c-8c13-94b5ac01aacd"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132"), "04/15" },
                    { new Guid("13d594dd-3102-4cd5-80e3-b6e2091db52d"), "110", "2745244554469468", new Guid("13d594dd-3102-4cd5-80e3-b6e2091db52d"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655"), "01/01" },
                    { new Guid("14526785-7485-4c90-9234-4df0745538e5"), "481", "5355398251397522", new Guid("14526785-7485-4c90-9234-4df0745538e5"), new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4"), "10/02" },
                    { new Guid("14916193-e095-4054-8c0f-224dd222c15b"), "838", "7945466514407466", new Guid("14916193-e095-4054-8c0f-224dd222c15b"), new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6"), "12/09" },
                    { new Guid("1503a72b-a3e8-40d8-8af4-dd14852c5146"), "746", "9986229815384651", new Guid("1503a72b-a3e8-40d8-8af4-dd14852c5146"), new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e"), "09/06" },
                    { new Guid("150a369b-5fb7-45ee-a5c0-918997b120e4"), "207", "5774278710290802", new Guid("150a369b-5fb7-45ee-a5c0-918997b120e4"), new Guid("69170f92-b4b7-4c26-be44-5255d738fb20"), "11/06" },
                    { new Guid("1519c279-9dcb-4614-82a1-79f95f27d49d"), "214", "3747537075647737", new Guid("1519c279-9dcb-4614-82a1-79f95f27d49d"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), "10/25" },
                    { new Guid("15f5b7c8-7df1-4d61-8469-bfce542c983c"), "058", "6838014882301299", new Guid("15f5b7c8-7df1-4d61-8469-bfce542c983c"), new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6"), "03/14" },
                    { new Guid("162bed18-f2f0-49d0-aba0-9f9db3f96e6f"), "464", "2641134026303348", new Guid("162bed18-f2f0-49d0-aba0-9f9db3f96e6f"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964"), "09/11" },
                    { new Guid("165e6876-c51f-44c2-9f6c-81f07c0ad078"), "832", "9824851874537787", new Guid("165e6876-c51f-44c2-9f6c-81f07c0ad078"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96"), "07/27" },
                    { new Guid("168e7c31-b13b-4feb-89ce-b0a1cc037b33"), "045", "5020388424155893", new Guid("168e7c31-b13b-4feb-89ce-b0a1cc037b33"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6"), "11/20" },
                    { new Guid("1690f1e1-e361-4427-82c1-a99dbcf7e430"), "099", "7266467486086680", new Guid("1690f1e1-e361-4427-82c1-a99dbcf7e430"), new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2"), "07/28" },
                    { new Guid("16b2cb4d-62e5-46a3-a513-ffc1bbd6e7b9"), "042", "1492926374255789", new Guid("16b2cb4d-62e5-46a3-a513-ffc1bbd6e7b9"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854"), "05/22" },
                    { new Guid("16c7e538-9fab-49ca-b0dc-afd6aa3ae04b"), "660", "8745949645832665", new Guid("16c7e538-9fab-49ca-b0dc-afd6aa3ae04b"), new Guid("8987fd2f-b286-41d7-9544-b355355a2cff"), "11/20" },
                    { new Guid("16f20a2b-02a7-4a13-9f50-4cff08df45b6"), "820", "7067062952832502", new Guid("16f20a2b-02a7-4a13-9f50-4cff08df45b6"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5"), "01/01" },
                    { new Guid("173edc7f-42d1-4ca2-8733-11b94bfe6a96"), "728", "5627994056334599", new Guid("173edc7f-42d1-4ca2-8733-11b94bfe6a96"), new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed"), "12/25" },
                    { new Guid("17833053-7528-444e-afa5-41b3d03e97c6"), "974", "3173011535816753", new Guid("17833053-7528-444e-afa5-41b3d03e97c6"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833"), "06/20" },
                    { new Guid("17c6b5d0-2a05-4509-a981-fdbd566d1172"), "348", "4600493619744783", new Guid("17c6b5d0-2a05-4509-a981-fdbd566d1172"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651"), "03/17" },
                    { new Guid("17d784c4-5fee-477d-8a60-d83ab7b0467a"), "490", "2615526514131618", new Guid("17d784c4-5fee-477d-8a60-d83ab7b0467a"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138"), "07/22" },
                    { new Guid("182e56fe-ed03-45ea-a4ca-05b5fca9c80c"), "325", "9277874237927034", new Guid("182e56fe-ed03-45ea-a4ca-05b5fca9c80c"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7"), "04/20" },
                    { new Guid("1865baa9-f42f-4dcc-ba42-b04e16063a5c"), "829", "8251059742509153", new Guid("1865baa9-f42f-4dcc-ba42-b04e16063a5c"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21"), "12/24" },
                    { new Guid("1873a349-e82b-43e6-afe5-d3f4da046e73"), "267", "7465960649465623", new Guid("1873a349-e82b-43e6-afe5-d3f4da046e73"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19"), "09/16" },
                    { new Guid("18847cbd-9273-480f-9f0b-b28a5ec03b7c"), "624", "4004166480955772", new Guid("18847cbd-9273-480f-9f0b-b28a5ec03b7c"), new Guid("c0886dea-4971-4369-8d28-75754e2575d0"), "05/13" },
                    { new Guid("18cf7c41-d511-4310-9aae-5a7c411feed9"), "663", "8548584647918515", new Guid("18cf7c41-d511-4310-9aae-5a7c411feed9"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), "11/03" },
                    { new Guid("18d1412e-f9da-4acf-9f4f-11b2ae64f70f"), "499", "8737685988290884", new Guid("18d1412e-f9da-4acf-9f4f-11b2ae64f70f"), new Guid("f7720de3-aaea-48e9-af48-569af731d90b"), "09/07" },
                    { new Guid("18da7e8a-f1ab-4e49-bc7a-9d7f2e7bc62f"), "600", "9910694294040063", new Guid("18da7e8a-f1ab-4e49-bc7a-9d7f2e7bc62f"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9"), "08/20" },
                    { new Guid("18ecbd31-529b-4db6-bccd-78deb3a56d23"), "567", "1905434080238250", new Guid("18ecbd31-529b-4db6-bccd-78deb3a56d23"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d"), "01/08" },
                    { new Guid("19184efe-982a-460a-bdb9-4e401dae4a29"), "282", "7775398655715719", new Guid("19184efe-982a-460a-bdb9-4e401dae4a29"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6"), "05/27" },
                    { new Guid("19739a73-fd92-4fb0-8cb4-7113601f3ed3"), "537", "8183540603534183", new Guid("19739a73-fd92-4fb0-8cb4-7113601f3ed3"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7"), "08/03" },
                    { new Guid("19aa53e5-41ba-4423-82ab-4f119c7af382"), "168", "6323407880535283", new Guid("19aa53e5-41ba-4423-82ab-4f119c7af382"), new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5"), "02/10" },
                    { new Guid("19eac323-2d6c-4cc7-96b5-639961ce67ef"), "812", "8415279256499034", new Guid("19eac323-2d6c-4cc7-96b5-639961ce67ef"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4"), "02/26" },
                    { new Guid("19f38d7d-d226-492d-b80b-e9fb0b755c80"), "997", "4147288861248432", new Guid("19f38d7d-d226-492d-b80b-e9fb0b755c80"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47"), "06/28" },
                    { new Guid("19fcd7c1-74d3-49eb-87e3-1aa0c8db51eb"), "544", "7002155793372471", new Guid("19fcd7c1-74d3-49eb-87e3-1aa0c8db51eb"), new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4"), "06/01" },
                    { new Guid("1a6c5455-3aee-4e28-829a-68a4a733d70e"), "668", "1016690161528151", new Guid("1a6c5455-3aee-4e28-829a-68a4a733d70e"), new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221"), "12/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("1a881b38-dca7-4e1b-8ba0-012f22bb8413"), "724", "2145510339326096", new Guid("1a881b38-dca7-4e1b-8ba0-012f22bb8413"), new Guid("cfddcc04-5205-447d-9799-6d1945c391b4"), "01/12" },
                    { new Guid("1ace8fd7-f25a-4775-9c00-c8e25d536e9e"), "109", "1186103587349762", new Guid("1ace8fd7-f25a-4775-9c00-c8e25d536e9e"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75"), "08/03" },
                    { new Guid("1ada0c74-bff4-4f37-8dc8-83714c1aaf80"), "802", "9599252136894034", new Guid("1ada0c74-bff4-4f37-8dc8-83714c1aaf80"), new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5"), "06/22" },
                    { new Guid("1b03aaa0-3116-43e0-8228-7e28a330f4e2"), "805", "6529595549185530", new Guid("1b03aaa0-3116-43e0-8228-7e28a330f4e2"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a"), "03/20" },
                    { new Guid("1bd44078-188b-41a8-b696-ba31f65f2ef3"), "040", "3835998065936342", new Guid("1bd44078-188b-41a8-b696-ba31f65f2ef3"), new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7"), "01/21" },
                    { new Guid("1c1d2dc1-acc3-4abf-a0ad-91ad93bce154"), "180", "9465150030818595", new Guid("1c1d2dc1-acc3-4abf-a0ad-91ad93bce154"), new Guid("0823436c-27ad-4402-b5e2-b17efa08505e"), "06/10" },
                    { new Guid("1c409a93-2152-4b51-b959-5b47c684f159"), "241", "3013144715185149", new Guid("1c409a93-2152-4b51-b959-5b47c684f159"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5"), "06/19" },
                    { new Guid("1cddee84-9589-4e54-b026-aaf0b9c24253"), "434", "9237254578449344", new Guid("1cddee84-9589-4e54-b026-aaf0b9c24253"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316"), "01/07" },
                    { new Guid("1d042b5a-e4c0-45da-991c-82861e19ed2a"), "416", "7597931136039583", new Guid("1d042b5a-e4c0-45da-991c-82861e19ed2a"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84"), "05/08" },
                    { new Guid("1d371007-2f5c-44cb-a397-853b91e4bb72"), "519", "7191011775489461", new Guid("1d371007-2f5c-44cb-a397-853b91e4bb72"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c"), "02/27" },
                    { new Guid("1e0ae889-f2d2-4fcc-871c-78cac960433b"), "185", "2956608856585579", new Guid("1e0ae889-f2d2-4fcc-871c-78cac960433b"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de"), "09/16" },
                    { new Guid("1e12c9e0-acd2-4b41-8ea4-1ab76dec4e1d"), "536", "2891061649737626", new Guid("1e12c9e0-acd2-4b41-8ea4-1ab76dec4e1d"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de"), "10/17" },
                    { new Guid("1e39ac81-990c-44f2-afd3-660b9c480465"), "934", "3946953818240631", new Guid("1e39ac81-990c-44f2-afd3-660b9c480465"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0"), "01/28" },
                    { new Guid("1e3a5e13-8289-4033-add3-ee1f8502fed5"), "912", "9627526386703160", new Guid("1e3a5e13-8289-4033-add3-ee1f8502fed5"), new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b"), "09/18" },
                    { new Guid("1f22770a-0116-4c46-bee1-32904a9ab527"), "792", "5387063971644024", new Guid("1f22770a-0116-4c46-bee1-32904a9ab527"), new Guid("9f745913-393e-4d75-924b-12ed8606f936"), "03/23" },
                    { new Guid("1f3ed327-d647-4215-87a5-a69b569981ff"), "323", "2028774453080720", new Guid("1f3ed327-d647-4215-87a5-a69b569981ff"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec"), "01/22" },
                    { new Guid("1fd60d7e-8808-447e-94e4-4033d7e83d2d"), "433", "6442352881236365", new Guid("1fd60d7e-8808-447e-94e4-4033d7e83d2d"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19"), "09/11" },
                    { new Guid("1fe0a2a6-8441-4e30-974e-78d6b9dafcb4"), "234", "5731436868723636", new Guid("1fe0a2a6-8441-4e30-974e-78d6b9dafcb4"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604"), "02/28" },
                    { new Guid("2092932c-1c28-4a0e-a1bc-fae71caa87b4"), "539", "9202408040638282", new Guid("2092932c-1c28-4a0e-a1bc-fae71caa87b4"), new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2"), "04/16" },
                    { new Guid("2104f80c-5d6e-4e06-b38a-31bfa1858dd6"), "325", "9736845093217017", new Guid("2104f80c-5d6e-4e06-b38a-31bfa1858dd6"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51"), "08/06" },
                    { new Guid("21b466ce-07e4-4b27-8c1f-11744bb7d1b7"), "118", "9321510998568596", new Guid("21b466ce-07e4-4b27-8c1f-11744bb7d1b7"), new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d"), "12/17" },
                    { new Guid("224f5213-2039-4e6a-b137-8ddb9a24dad3"), "742", "9278552599633471", new Guid("224f5213-2039-4e6a-b137-8ddb9a24dad3"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51"), "10/16" },
                    { new Guid("22974070-4867-4e6d-b8ba-971ded3d62db"), "678", "1628595775553478", new Guid("22974070-4867-4e6d-b8ba-971ded3d62db"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0"), "04/24" },
                    { new Guid("22fe20af-12a9-4729-b23d-808d0cfc40ad"), "944", "2136553135290565", new Guid("22fe20af-12a9-4729-b23d-808d0cfc40ad"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea"), "07/22" },
                    { new Guid("2312e3b9-0731-48c8-8426-72d153c38b2f"), "479", "6744688936729750", new Guid("2312e3b9-0731-48c8-8426-72d153c38b2f"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), "06/07" },
                    { new Guid("2314c171-48b7-4e55-b958-64f44a266051"), "241", "4623043025130108", new Guid("2314c171-48b7-4e55-b958-64f44a266051"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05"), "10/15" },
                    { new Guid("2398e276-e33f-4768-9a5b-54c5f92bf190"), "817", "2949738041866027", new Guid("2398e276-e33f-4768-9a5b-54c5f92bf190"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b"), "09/19" },
                    { new Guid("23d70b45-a1e0-4ac0-8d4e-f665f99f3d89"), "513", "6570059816779819", new Guid("23d70b45-a1e0-4ac0-8d4e-f665f99f3d89"), new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405"), "06/17" },
                    { new Guid("24d1e47d-d5c2-46f0-9b62-563fa2bed437"), "706", "9659707647275547", new Guid("24d1e47d-d5c2-46f0-9b62-563fa2bed437"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132"), "04/16" },
                    { new Guid("253d4af7-a57c-4d58-ab5b-3d754acde16e"), "077", "2126458342407048", new Guid("253d4af7-a57c-4d58-ab5b-3d754acde16e"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), "06/16" },
                    { new Guid("255b1ead-2344-4c62-8122-e988243c917f"), "950", "7948833165058158", new Guid("255b1ead-2344-4c62-8122-e988243c917f"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), "07/16" },
                    { new Guid("25c96aa8-5f33-4f1e-aba8-c7b519ac3ee3"), "364", "6402720134529218", new Guid("25c96aa8-5f33-4f1e-aba8-c7b519ac3ee3"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132"), "03/07" },
                    { new Guid("2659dfcd-dfc7-49aa-b151-84d953f00a79"), "497", "2408868716908048", new Guid("2659dfcd-dfc7-49aa-b151-84d953f00a79"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0"), "03/15" },
                    { new Guid("26792e04-72f9-4d76-b711-f71f5265d8a8"), "743", "7726839263777239", new Guid("26792e04-72f9-4d76-b711-f71f5265d8a8"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316"), "01/19" },
                    { new Guid("26cfca81-14c0-4c23-9f72-d361e9b58c61"), "399", "1615355983232028", new Guid("26cfca81-14c0-4c23-9f72-d361e9b58c61"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9"), "01/20" },
                    { new Guid("26dec549-a72a-4b30-a8ec-a54cc95abc77"), "496", "1761305683131344", new Guid("26dec549-a72a-4b30-a8ec-a54cc95abc77"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6"), "03/03" },
                    { new Guid("2725ec09-7fb2-448b-ab6d-abf49c87009b"), "181", "4843943402789029", new Guid("2725ec09-7fb2-448b-ab6d-abf49c87009b"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), "05/10" },
                    { new Guid("272747a5-c152-49ec-b8df-2903c903d4d1"), "969", "1193694783942220", new Guid("272747a5-c152-49ec-b8df-2903c903d4d1"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7"), "08/15" },
                    { new Guid("272e1387-faa1-4bf8-aa0e-73e865212da9"), "254", "5414738422129275", new Guid("272e1387-faa1-4bf8-aa0e-73e865212da9"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), "11/25" },
                    { new Guid("273c476d-32cc-4f16-a115-4601bbaf2ffa"), "543", "8496528788755867", new Guid("273c476d-32cc-4f16-a115-4601bbaf2ffa"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a"), "07/20" },
                    { new Guid("2757c22d-92fa-4e88-abeb-c249d386920e"), "159", "2440149255466523", new Guid("2757c22d-92fa-4e88-abeb-c249d386920e"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918"), "08/07" },
                    { new Guid("285ee7ed-3878-407b-bc92-457b79f12750"), "448", "4410123789277952", new Guid("285ee7ed-3878-407b-bc92-457b79f12750"), new Guid("665af7ab-85d3-48f3-bedd-30db54699f81"), "04/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("287d2f29-f8d3-4ff4-8501-89875efd3a85"), "198", "1645049525944421", new Guid("287d2f29-f8d3-4ff4-8501-89875efd3a85"), new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376"), "09/13" },
                    { new Guid("28871c7a-3099-495e-862e-10d800aa7d9f"), "580", "9539645662235832", new Guid("28871c7a-3099-495e-862e-10d800aa7d9f"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0"), "01/08" },
                    { new Guid("2887dea0-8bda-401a-a0c1-569182b8c36c"), "466", "9662569209187546", new Guid("2887dea0-8bda-401a-a0c1-569182b8c36c"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9"), "09/14" },
                    { new Guid("28bda6a7-a5d4-4fb4-830f-e97dd6b33a9a"), "329", "1943962239736783", new Guid("28bda6a7-a5d4-4fb4-830f-e97dd6b33a9a"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de"), "04/13" },
                    { new Guid("290f56d3-ad71-4ae0-8730-197841199902"), "833", "3041865078793002", new Guid("290f56d3-ad71-4ae0-8730-197841199902"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61"), "07/09" },
                    { new Guid("290fdb95-22b0-40a3-bf77-f57c6253ce23"), "199", "4559221959671619", new Guid("290fdb95-22b0-40a3-bf77-f57c6253ce23"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd"), "12/12" },
                    { new Guid("2932cf52-5a52-4727-86a8-ceca789b5484"), "847", "7107164801645393", new Guid("2932cf52-5a52-4727-86a8-ceca789b5484"), new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b"), "08/15" },
                    { new Guid("298ebd00-cd7b-4d6c-97bf-db2dd978bacd"), "153", "4102424445301070", new Guid("298ebd00-cd7b-4d6c-97bf-db2dd978bacd"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61"), "03/02" },
                    { new Guid("299e67dd-b6d0-4b6a-9a3c-71340d965ecd"), "240", "7720124207302753", new Guid("299e67dd-b6d0-4b6a-9a3c-71340d965ecd"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4"), "11/19" },
                    { new Guid("2a6250d6-ac46-46bc-a009-2ec99c2138f2"), "200", "7427271029116493", new Guid("2a6250d6-ac46-46bc-a009-2ec99c2138f2"), new Guid("9f745913-393e-4d75-924b-12ed8606f936"), "12/26" },
                    { new Guid("2a823ff4-72f3-4d94-9e33-a39c2a216031"), "760", "9315486375187247", new Guid("2a823ff4-72f3-4d94-9e33-a39c2a216031"), new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6"), "07/23" },
                    { new Guid("2ad15417-f7f4-4db0-963c-4a868aad2392"), "262", "6921398089510340", new Guid("2ad15417-f7f4-4db0-963c-4a868aad2392"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247"), "06/01" },
                    { new Guid("2b11999b-3bd4-4f78-98ac-87a95bddec61"), "117", "8536199414021360", new Guid("2b11999b-3bd4-4f78-98ac-87a95bddec61"), new Guid("3e38a390-7168-426f-8d48-017588046d20"), "11/14" },
                    { new Guid("2b47e621-216f-4e61-8c75-d1c568dc5493"), "256", "1674908749369818", new Guid("2b47e621-216f-4e61-8c75-d1c568dc5493"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47"), "05/19" },
                    { new Guid("2b5663b3-1b53-459e-8554-d32b74a60578"), "077", "4317894909648266", new Guid("2b5663b3-1b53-459e-8554-d32b74a60578"), new Guid("7637da20-6c85-4358-a711-5912b0358007"), "07/13" },
                    { new Guid("2b9642a8-089a-4e60-beaa-0dff3c1677b7"), "101", "1689869087669056", new Guid("2b9642a8-089a-4e60-beaa-0dff3c1677b7"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e"), "09/26" },
                    { new Guid("2befc995-5eff-4b94-9dc4-29bb76db58ac"), "260", "5029530876246042", new Guid("2befc995-5eff-4b94-9dc4-29bb76db58ac"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138"), "11/09" },
                    { new Guid("2c30868f-122c-44c9-8cb3-db914573ebb4"), "406", "8997932752540156", new Guid("2c30868f-122c-44c9-8cb3-db914573ebb4"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e"), "11/04" },
                    { new Guid("2c34d539-bbaf-4b73-8ac2-f00e87d688ac"), "964", "1893955668678514", new Guid("2c34d539-bbaf-4b73-8ac2-f00e87d688ac"), new Guid("203cc97b-91be-4474-b881-e9776da21af9"), "12/01" },
                    { new Guid("2c53e24b-b12a-453e-99db-b31318b32a17"), "951", "8839905978356190", new Guid("2c53e24b-b12a-453e-99db-b31318b32a17"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd"), "07/02" },
                    { new Guid("2cd5c450-fb64-4a1d-8c15-438561458636"), "204", "3705669241379207", new Guid("2cd5c450-fb64-4a1d-8c15-438561458636"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5"), "03/22" },
                    { new Guid("2d628af8-563e-4851-92ec-7a8f53bf958e"), "179", "9377936247396267", new Guid("2d628af8-563e-4851-92ec-7a8f53bf958e"), new Guid("e5acadcd-43bb-4225-9367-f562e86197e5"), "03/21" },
                    { new Guid("2df39d2a-e122-4c53-9549-0099fc5689e5"), "635", "5420872148740724", new Guid("2df39d2a-e122-4c53-9549-0099fc5689e5"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330"), "10/07" },
                    { new Guid("2e06837c-7198-41dc-a075-0f93532be22d"), "733", "1522317619989062", new Guid("2e06837c-7198-41dc-a075-0f93532be22d"), new Guid("3e38a390-7168-426f-8d48-017588046d20"), "10/28" },
                    { new Guid("2f1a3afa-bf5a-49c9-9884-1327bebfa0d4"), "480", "1389594579090953", new Guid("2f1a3afa-bf5a-49c9-9884-1327bebfa0d4"), new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59"), "03/09" },
                    { new Guid("2f1ae83c-78be-4965-9e0a-c4b1e230181a"), "063", "4891050699879980", new Guid("2f1ae83c-78be-4965-9e0a-c4b1e230181a"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1"), "07/14" },
                    { new Guid("2f327671-6f24-42a9-a1ba-83b02bda3d86"), "723", "9276343178126597", new Guid("2f327671-6f24-42a9-a1ba-83b02bda3d86"), new Guid("f7e86b66-49eb-4774-82be-b008350dc98b"), "07/14" },
                    { new Guid("2f39157f-367e-44da-b04c-0298c88869b2"), "836", "9625262978344344", new Guid("2f39157f-367e-44da-b04c-0298c88869b2"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61"), "12/05" },
                    { new Guid("2fd07955-e0f5-42a5-81c4-0df617269279"), "884", "6438555713950060", new Guid("2fd07955-e0f5-42a5-81c4-0df617269279"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d"), "01/04" },
                    { new Guid("3011b113-00f7-467b-b9f9-5e7c95aa524f"), "171", "3363086687163014", new Guid("3011b113-00f7-467b-b9f9-5e7c95aa524f"), new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1"), "12/13" },
                    { new Guid("303175f5-863c-4a31-b782-6ec3bed1ae49"), "532", "9861254200294694", new Guid("303175f5-863c-4a31-b782-6ec3bed1ae49"), new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb"), "10/19" },
                    { new Guid("308f01db-a4ac-48ea-aa2b-0fe91be48c7b"), "196", "5339844748658313", new Guid("308f01db-a4ac-48ea-aa2b-0fe91be48c7b"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d"), "11/28" },
                    { new Guid("30b92db8-ec12-4536-af64-e9a543a1aaf8"), "286", "5768260695134990", new Guid("30b92db8-ec12-4536-af64-e9a543a1aaf8"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e"), "08/18" },
                    { new Guid("30cbed67-d90f-4a81-8395-f29e48be2142"), "848", "8668292741479823", new Guid("30cbed67-d90f-4a81-8395-f29e48be2142"), new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7"), "12/16" },
                    { new Guid("31c329ee-2caf-4bb6-88bf-39f6cf4d5ad4"), "810", "3347212301343541", new Guid("31c329ee-2caf-4bb6-88bf-39f6cf4d5ad4"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48"), "07/21" },
                    { new Guid("31e21c86-f666-40b8-af8e-abbe62880d5d"), "740", "5722369796586435", new Guid("31e21c86-f666-40b8-af8e-abbe62880d5d"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7"), "12/22" },
                    { new Guid("3201762a-6444-4d20-bb7f-432b7790fb6c"), "194", "8652185766652211", new Guid("3201762a-6444-4d20-bb7f-432b7790fb6c"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7"), "03/01" },
                    { new Guid("3282f511-8ec3-46d9-9ac0-a416a5e6e436"), "251", "2352866210856415", new Guid("3282f511-8ec3-46d9-9ac0-a416a5e6e436"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138"), "07/08" },
                    { new Guid("32a9c88d-d345-4869-9bed-b814ac32831d"), "734", "5055290839984660", new Guid("32a9c88d-d345-4869-9bed-b814ac32831d"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d"), "09/01" },
                    { new Guid("33a857b9-decc-4b6f-846b-f972820d4b41"), "818", "7469655733384426", new Guid("33a857b9-decc-4b6f-846b-f972820d4b41"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a"), "06/11" },
                    { new Guid("34272c11-2d97-45cb-b566-38f3371f281c"), "033", "9183903524401087", new Guid("34272c11-2d97-45cb-b566-38f3371f281c"), new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c"), "09/13" },
                    { new Guid("349616e3-94f0-428a-a6f7-ab4f5e7b1d0a"), "154", "2037907744421585", new Guid("349616e3-94f0-428a-a6f7-ab4f5e7b1d0a"), new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4"), "02/18" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("34aeddcb-4325-4f4c-b14a-73b4e36149f4"), "618", "1093536285651008", new Guid("34aeddcb-4325-4f4c-b14a-73b4e36149f4"), new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df"), "02/27" },
                    { new Guid("34c14529-b8e6-4920-b5df-241e300f214e"), "926", "7009495588410156", new Guid("34c14529-b8e6-4920-b5df-241e300f214e"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4"), "02/03" },
                    { new Guid("35215b57-7534-433e-b2b9-3b732368a7ff"), "869", "3634519077532095", new Guid("35215b57-7534-433e-b2b9-3b732368a7ff"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4"), "02/09" },
                    { new Guid("361c835b-c00a-45ca-8ea9-59ff2c4414b6"), "838", "1980826731673443", new Guid("361c835b-c00a-45ca-8ea9-59ff2c4414b6"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe"), "03/20" },
                    { new Guid("3648c327-75bd-4d67-b810-031f5b90d089"), "885", "2455656185533202", new Guid("3648c327-75bd-4d67-b810-031f5b90d089"), new Guid("d422e4b4-5d7b-484f-830c-319350a69b22"), "10/08" },
                    { new Guid("36543ec0-47ad-4ac3-9af6-25a3e3b0e1b3"), "404", "8015044165578320", new Guid("36543ec0-47ad-4ac3-9af6-25a3e3b0e1b3"), new Guid("f825bff2-881f-450b-a4b7-56931951c54c"), "04/14" },
                    { new Guid("3757173f-c97c-402f-aa87-b54cdf7ada18"), "777", "7201295283010887", new Guid("3757173f-c97c-402f-aa87-b54cdf7ada18"), new Guid("7637da20-6c85-4358-a711-5912b0358007"), "04/05" },
                    { new Guid("37e0d7b7-0152-42f9-a4b7-3550bf788ab8"), "760", "5903471980817397", new Guid("37e0d7b7-0152-42f9-a4b7-3550bf788ab8"), new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131"), "05/28" },
                    { new Guid("3804e4eb-0147-48b6-97dc-5a2ab6fa1b68"), "554", "5683131992953707", new Guid("3804e4eb-0147-48b6-97dc-5a2ab6fa1b68"), new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828"), "12/22" },
                    { new Guid("381b0ac2-9f2c-46b5-b743-041669cda6c9"), "398", "9921136099290600", new Guid("381b0ac2-9f2c-46b5-b743-041669cda6c9"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628"), "05/06" },
                    { new Guid("383e6aec-db6d-44c8-a65c-2f0c04f33d7c"), "510", "1256229556539118", new Guid("383e6aec-db6d-44c8-a65c-2f0c04f33d7c"), new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8"), "12/27" },
                    { new Guid("385ebecf-cfd0-497c-b61b-850a4481e256"), "471", "1814631996245301", new Guid("385ebecf-cfd0-497c-b61b-850a4481e256"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b"), "08/17" },
                    { new Guid("38de176b-9488-46e0-8456-5ae6c39a449e"), "267", "4547287229826568", new Guid("38de176b-9488-46e0-8456-5ae6c39a449e"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b"), "05/03" },
                    { new Guid("399b7155-01fd-47b7-9ccd-441f28957d76"), "252", "6502942811558736", new Guid("399b7155-01fd-47b7-9ccd-441f28957d76"), new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65"), "01/27" },
                    { new Guid("39f5c723-71ce-43c3-8ee2-b43aa3ca2732"), "683", "1283118383527410", new Guid("39f5c723-71ce-43c3-8ee2-b43aa3ca2732"), new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867"), "02/10" },
                    { new Guid("3aaeed62-5229-4d4c-abf6-a9a012022180"), "272", "3516874222066352", new Guid("3aaeed62-5229-4d4c-abf6-a9a012022180"), new Guid("35b6c210-2256-41cd-af8e-e815527e0a84"), "04/02" },
                    { new Guid("3b0736fb-2fa0-412f-be8a-75708b12412d"), "012", "1850389132973218", new Guid("3b0736fb-2fa0-412f-be8a-75708b12412d"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132"), "05/07" },
                    { new Guid("3b102c70-5ea7-494a-bf1b-a957c5d1070a"), "033", "3825945733001363", new Guid("3b102c70-5ea7-494a-bf1b-a957c5d1070a"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40"), "01/27" },
                    { new Guid("3b36f5d2-a904-4740-a610-5bdd54543357"), "384", "3046486031998862", new Guid("3b36f5d2-a904-4740-a610-5bdd54543357"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124"), "10/08" },
                    { new Guid("3b448354-911c-4015-9888-ec6343e60be5"), "911", "9318489232002922", new Guid("3b448354-911c-4015-9888-ec6343e60be5"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978"), "08/28" },
                    { new Guid("3b4f005b-2326-4ddc-9f79-fb0e020e5ae4"), "209", "2360594717379418", new Guid("3b4f005b-2326-4ddc-9f79-fb0e020e5ae4"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd"), "11/26" },
                    { new Guid("3bd9ae0c-b9f2-4b21-89dc-b9fa20bac226"), "917", "7785408257657104", new Guid("3bd9ae0c-b9f2-4b21-89dc-b9fa20bac226"), new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46"), "09/19" },
                    { new Guid("3bdabfa1-c1bc-4e92-b59a-b90e4b6b88ef"), "383", "1247647338715020", new Guid("3bdabfa1-c1bc-4e92-b59a-b90e4b6b88ef"), new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2"), "02/12" },
                    { new Guid("3be46564-878a-4ceb-bd5c-baca83ee6f6f"), "950", "4641808629259602", new Guid("3be46564-878a-4ceb-bd5c-baca83ee6f6f"), new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4"), "12/09" },
                    { new Guid("3c76e869-491d-407d-b33e-4ab4f28ddca3"), "156", "9507800172119252", new Guid("3c76e869-491d-407d-b33e-4ab4f28ddca3"), new Guid("8b3ae855-3f1f-409d-8898-00767477ffae"), "12/28" },
                    { new Guid("3c7e0be0-d7ca-417d-aa8b-057d6e68975e"), "271", "7432419865948305", new Guid("3c7e0be0-d7ca-417d-aa8b-057d6e68975e"), new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b"), "03/24" },
                    { new Guid("3ca76a0d-6e55-4410-9089-bcb289c6eb1f"), "048", "8337404559066514", new Guid("3ca76a0d-6e55-4410-9089-bcb289c6eb1f"), new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7"), "04/24" },
                    { new Guid("3cc107db-1f86-4a51-a794-ec84e8a1c8c8"), "837", "2142781950142578", new Guid("3cc107db-1f86-4a51-a794-ec84e8a1c8c8"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042"), "03/16" },
                    { new Guid("3cedd3dc-465c-4fbf-bf4c-09d551b65fd1"), "162", "9360342569595390", new Guid("3cedd3dc-465c-4fbf-bf4c-09d551b65fd1"), new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6"), "10/08" },
                    { new Guid("3d1b451e-2ccf-422d-9c4a-c3f258e80d83"), "439", "4302337083009097", new Guid("3d1b451e-2ccf-422d-9c4a-c3f258e80d83"), new Guid("33d5b081-5c0f-4871-905f-631caba91848"), "07/21" },
                    { new Guid("3d27122d-680d-43b0-b703-189be591c6ec"), "647", "4972000611572050", new Guid("3d27122d-680d-43b0-b703-189be591c6ec"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628"), "02/20" },
                    { new Guid("3d5224c2-f958-41ce-88eb-e08c5424b683"), "535", "3082358572452700", new Guid("3d5224c2-f958-41ce-88eb-e08c5424b683"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75"), "11/23" },
                    { new Guid("3d662c9c-daeb-4c1e-b7fa-832bd445916f"), "477", "2947164922496941", new Guid("3d662c9c-daeb-4c1e-b7fa-832bd445916f"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9"), "05/07" },
                    { new Guid("3de6daaf-52f6-4e72-8bff-3f64943fa1b1"), "763", "6273243429712560", new Guid("3de6daaf-52f6-4e72-8bff-3f64943fa1b1"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d"), "10/09" },
                    { new Guid("3e14ac3a-9d46-4074-b3cf-9353f32aafa9"), "840", "5347116242187499", new Guid("3e14ac3a-9d46-4074-b3cf-9353f32aafa9"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0"), "05/15" },
                    { new Guid("3ee32fcf-ca03-4861-a2e1-cc866bd1ea16"), "323", "9167060182992872", new Guid("3ee32fcf-ca03-4861-a2e1-cc866bd1ea16"), new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420"), "05/27" },
                    { new Guid("3eeab443-02a5-42b5-8c11-ddb6f26f2251"), "118", "8842924264277814", new Guid("3eeab443-02a5-42b5-8c11-ddb6f26f2251"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa"), "04/05" },
                    { new Guid("3f034d6e-a654-45f7-aa83-5914c894f366"), "317", "3779632092582815", new Guid("3f034d6e-a654-45f7-aa83-5914c894f366"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e"), "03/28" },
                    { new Guid("3f45b34d-b30b-477d-b98f-ef8ad5c79a3d"), "705", "1473531219606396", new Guid("3f45b34d-b30b-477d-b98f-ef8ad5c79a3d"), new Guid("35b6c210-2256-41cd-af8e-e815527e0a84"), "11/21" },
                    { new Guid("3f527be7-0046-40c8-ad1a-16e5d777dae6"), "718", "7700539120901859", new Guid("3f527be7-0046-40c8-ad1a-16e5d777dae6"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7"), "06/25" },
                    { new Guid("3f765ae0-3ee3-4242-a094-e34a555507b0"), "232", "9543658279246519", new Guid("3f765ae0-3ee3-4242-a094-e34a555507b0"), new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2"), "02/20" },
                    { new Guid("3fa86873-48a2-4513-9b94-70031fe7a5de"), "469", "5512403929279840", new Guid("3fa86873-48a2-4513-9b94-70031fe7a5de"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a"), "03/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("404a7152-c314-43b7-8922-4d7e8e18ec71"), "842", "6386258400690095", new Guid("404a7152-c314-43b7-8922-4d7e8e18ec71"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d"), "08/05" },
                    { new Guid("40657d34-8225-45bd-81c2-5accc73bc281"), "572", "8856906397978265", new Guid("40657d34-8225-45bd-81c2-5accc73bc281"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440"), "08/23" },
                    { new Guid("40a88315-4275-4a9a-9694-cc22249f1f1c"), "724", "3112355700328221", new Guid("40a88315-4275-4a9a-9694-cc22249f1f1c"), new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977"), "07/28" },
                    { new Guid("412fb44e-d3e5-4ac7-a986-7cc48fa9c19d"), "966", "1639800121454282", new Guid("412fb44e-d3e5-4ac7-a986-7cc48fa9c19d"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), "03/22" },
                    { new Guid("41aefdf2-d139-46b9-8cb4-9eebefcd697d"), "616", "3316351857634020", new Guid("41aefdf2-d139-46b9-8cb4-9eebefcd697d"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6"), "09/05" },
                    { new Guid("42633681-1233-47f5-a5ca-e4a0436c63c8"), "410", "9124673057977563", new Guid("42633681-1233-47f5-a5ca-e4a0436c63c8"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651"), "11/01" },
                    { new Guid("42b24d22-3966-489a-9f01-060cfa83e054"), "975", "1054614906892282", new Guid("42b24d22-3966-489a-9f01-060cfa83e054"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c"), "06/19" },
                    { new Guid("42bc7d81-43cc-4fea-83f5-4ecf80157286"), "654", "9447518958356241", new Guid("42bc7d81-43cc-4fea-83f5-4ecf80157286"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7"), "06/28" },
                    { new Guid("42feca09-4f3c-49cb-a808-eee84bab74c4"), "092", "5880411975472561", new Guid("42feca09-4f3c-49cb-a808-eee84bab74c4"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30"), "04/24" },
                    { new Guid("431151ef-b721-412c-b28b-48b86d821060"), "856", "1567546764521327", new Guid("431151ef-b721-412c-b28b-48b86d821060"), new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574"), "10/05" },
                    { new Guid("433cff2e-5d4c-45b4-9c89-f06ccce4cc43"), "444", "8992999233900151", new Guid("433cff2e-5d4c-45b4-9c89-f06ccce4cc43"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c"), "01/19" },
                    { new Guid("433e2143-7bf9-4415-aaef-a4e028484927"), "287", "5444164173064535", new Guid("433e2143-7bf9-4415-aaef-a4e028484927"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a"), "06/25" },
                    { new Guid("43a6e306-949a-4567-88a8-f7f29094bc64"), "926", "6083449023293441", new Guid("43a6e306-949a-4567-88a8-f7f29094bc64"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593"), "05/06" },
                    { new Guid("44032b60-e7be-4e8c-986b-05edf531fcca"), "900", "9782433560281284", new Guid("44032b60-e7be-4e8c-986b-05edf531fcca"), new Guid("18685782-706e-445d-892d-19c39dd67689"), "04/10" },
                    { new Guid("4426ea91-c94e-4ae5-9644-003b35020693"), "335", "2664290054749081", new Guid("4426ea91-c94e-4ae5-9644-003b35020693"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c"), "01/20" },
                    { new Guid("442d8bcd-00f9-450e-8790-d4abdd3d8d5a"), "953", "9909855128776913", new Guid("442d8bcd-00f9-450e-8790-d4abdd3d8d5a"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132"), "01/16" },
                    { new Guid("44bae597-58e6-4b7a-8309-3226719645a4"), "100", "3813250070858264", new Guid("44bae597-58e6-4b7a-8309-3226719645a4"), new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5"), "11/26" },
                    { new Guid("44bc4c79-484d-4719-a84e-f968363d3e6a"), "666", "6357608170445118", new Guid("44bc4c79-484d-4719-a84e-f968363d3e6a"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf"), "04/06" },
                    { new Guid("44e01e12-e7a3-4e8e-b2db-aee9d0064c40"), "083", "3743911667018333", new Guid("44e01e12-e7a3-4e8e-b2db-aee9d0064c40"), new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03"), "01/13" },
                    { new Guid("454e8e45-2a80-477b-b92e-87fbf90a3a30"), "897", "1653874790293605", new Guid("454e8e45-2a80-477b-b92e-87fbf90a3a30"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342"), "09/19" },
                    { new Guid("458c9ff6-745a-4324-b7f8-1a430df77ea3"), "750", "1503783995959336", new Guid("458c9ff6-745a-4324-b7f8-1a430df77ea3"), new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b"), "12/09" },
                    { new Guid("46612a4a-b484-4f3d-8963-68be2159b095"), "721", "3118601632580547", new Guid("46612a4a-b484-4f3d-8963-68be2159b095"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d"), "12/24" },
                    { new Guid("4673b7f2-4638-43ad-93a7-877a8fab596f"), "207", "2597719294054517", new Guid("4673b7f2-4638-43ad-93a7-877a8fab596f"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b"), "06/19" },
                    { new Guid("468227c2-5d5e-4cf8-94e4-627e4e8221f2"), "649", "4231744413590015", new Guid("468227c2-5d5e-4cf8-94e4-627e4e8221f2"), new Guid("636e6fd1-c4da-47a2-b141-1921b8814132"), "09/01" },
                    { new Guid("46999899-a89a-4c9c-8ce0-337d326dd4d6"), "160", "2641923584263876", new Guid("46999899-a89a-4c9c-8ce0-337d326dd4d6"), new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7"), "11/16" },
                    { new Guid("4707a74b-1fe1-4c07-8fa9-2a1bf5028be8"), "828", "1683311540733920", new Guid("4707a74b-1fe1-4c07-8fa9-2a1bf5028be8"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4"), "12/26" },
                    { new Guid("47470c34-96f8-45fd-ace7-c85af07001ab"), "074", "9562110699139798", new Guid("47470c34-96f8-45fd-ace7-c85af07001ab"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997"), "08/14" },
                    { new Guid("47de8397-8d78-4947-8480-fafe153a1202"), "541", "3899759183364417", new Guid("47de8397-8d78-4947-8480-fafe153a1202"), new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b"), "11/13" },
                    { new Guid("47fb4cdb-eee8-47ef-b1f5-ac4cccd5ddab"), "940", "4503757252659046", new Guid("47fb4cdb-eee8-47ef-b1f5-ac4cccd5ddab"), new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4"), "01/26" },
                    { new Guid("483c0c63-bf59-4cba-bdef-1212c7b04054"), "929", "5676054328673931", new Guid("483c0c63-bf59-4cba-bdef-1212c7b04054"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa"), "11/22" },
                    { new Guid("483c9374-d0d6-423b-a4b9-78b201b1d9a9"), "563", "9799122061225262", new Guid("483c9374-d0d6-423b-a4b9-78b201b1d9a9"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa"), "11/26" },
                    { new Guid("485456d4-6127-4d04-bfaa-3837ec851503"), "503", "6209748495480627", new Guid("485456d4-6127-4d04-bfaa-3837ec851503"), new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5"), "09/23" },
                    { new Guid("49590032-01a8-4488-8dca-d30bb435c222"), "478", "1025959234555624", new Guid("49590032-01a8-4488-8dca-d30bb435c222"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913"), "07/14" },
                    { new Guid("4971aae9-6fa8-4372-882d-b3a98286b2ff"), "617", "1178004848116691", new Guid("4971aae9-6fa8-4372-882d-b3a98286b2ff"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777"), "11/16" },
                    { new Guid("4976cb7c-f910-4a0b-85e5-ba222ac94c80"), "267", "3155137388659159", new Guid("4976cb7c-f910-4a0b-85e5-ba222ac94c80"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a"), "12/21" },
                    { new Guid("49abc5b4-048e-4886-900a-0d00ce09b834"), "012", "8091410032993205", new Guid("49abc5b4-048e-4886-900a-0d00ce09b834"), new Guid("cb635093-0872-4986-8027-340de9f12a5c"), "02/15" },
                    { new Guid("49edf275-a30a-4d5c-abcb-b52a38c7988e"), "897", "4533526021533334", new Guid("49edf275-a30a-4d5c-abcb-b52a38c7988e"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042"), "03/21" },
                    { new Guid("4a418c6d-fc85-41e2-9df8-2f38a2b5b9e2"), "758", "2238856020847967", new Guid("4a418c6d-fc85-41e2-9df8-2f38a2b5b9e2"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626"), "10/05" },
                    { new Guid("4a5439eb-f398-4ae9-8172-199461b47608"), "798", "1393835436654610", new Guid("4a5439eb-f398-4ae9-8172-199461b47608"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf"), "07/08" },
                    { new Guid("4b41131a-c226-4a1a-9ee7-13100b8e7c37"), "444", "5606134984846401", new Guid("4b41131a-c226-4a1a-9ee7-13100b8e7c37"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d"), "07/14" },
                    { new Guid("4b5f1078-7c87-467f-af52-538677d69888"), "506", "4892526588047933", new Guid("4b5f1078-7c87-467f-af52-538677d69888"), new Guid("8b896efc-3b46-4670-bb2b-740919a113b5"), "12/27" },
                    { new Guid("4b7ed323-4345-42f2-abab-ccd18d6f27c2"), "190", "8332987594043987", new Guid("4b7ed323-4345-42f2-abab-ccd18d6f27c2"), new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5"), "08/28" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("4b8ae623-9188-4311-850c-6353eb4a86ef"), "194", "7119334031224008", new Guid("4b8ae623-9188-4311-850c-6353eb4a86ef"), new Guid("83c8f958-a3f1-448d-bad0-048533827e0e"), "07/04" },
                    { new Guid("4c3b0808-5c42-4c24-be32-95d928556412"), "904", "6450873329561390", new Guid("4c3b0808-5c42-4c24-be32-95d928556412"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a"), "09/07" },
                    { new Guid("4cd3b16a-62ec-4cd7-8b02-e1a673578e38"), "747", "4328125886417822", new Guid("4cd3b16a-62ec-4cd7-8b02-e1a673578e38"), new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b"), "04/15" },
                    { new Guid("4d3a502e-86a3-4605-afc3-50b6a4a92418"), "020", "1001442698536094", new Guid("4d3a502e-86a3-4605-afc3-50b6a4a92418"), new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425"), "05/15" },
                    { new Guid("4d77a641-fd2d-4d3a-93c5-a221e579b7dd"), "354", "3382463162809906", new Guid("4d77a641-fd2d-4d3a-93c5-a221e579b7dd"), new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403"), "09/26" },
                    { new Guid("4e957275-a122-4e27-afd7-1899f6072783"), "474", "6770713977149445", new Guid("4e957275-a122-4e27-afd7-1899f6072783"), new Guid("f1038abe-cd17-40c4-844a-70a0ee863724"), "06/17" },
                    { new Guid("4e9992ff-620d-4718-b8b8-5743e08d15b9"), "809", "6876299098178212", new Guid("4e9992ff-620d-4718-b8b8-5743e08d15b9"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96"), "08/26" },
                    { new Guid("4ee53a55-fc74-4500-bfb2-12e8c2dbe970"), "872", "5185417441597903", new Guid("4ee53a55-fc74-4500-bfb2-12e8c2dbe970"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40"), "07/17" },
                    { new Guid("4ee9b2f4-02e6-4ffc-9850-04f4753a5dfd"), "144", "1928775300897932", new Guid("4ee9b2f4-02e6-4ffc-9850-04f4753a5dfd"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c"), "01/13" },
                    { new Guid("4f406b9b-66a1-4456-8698-8d6987a02d39"), "624", "8931324009959387", new Guid("4f406b9b-66a1-4456-8698-8d6987a02d39"), new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a"), "10/03" },
                    { new Guid("4f69ed48-12db-48eb-8caa-99bbf0d7ff20"), "409", "6319152770010054", new Guid("4f69ed48-12db-48eb-8caa-99bbf0d7ff20"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51"), "02/18" },
                    { new Guid("4f9ee61e-9969-46b7-b792-200d4f0c7bbd"), "825", "5335981167903863", new Guid("4f9ee61e-9969-46b7-b792-200d4f0c7bbd"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b"), "01/17" },
                    { new Guid("4fc0c8cf-66c4-48ff-8f12-fd195b17238a"), "808", "7332348512250319", new Guid("4fc0c8cf-66c4-48ff-8f12-fd195b17238a"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75"), "07/20" },
                    { new Guid("50d80c9e-539e-4ac9-b902-5f38c13923ce"), "771", "4012175609498945", new Guid("50d80c9e-539e-4ac9-b902-5f38c13923ce"), new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29"), "10/25" },
                    { new Guid("50f223f3-cff8-4818-916a-f112323a6d40"), "866", "3353055248298951", new Guid("50f223f3-cff8-4818-916a-f112323a6d40"), new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9"), "06/23" },
                    { new Guid("511791d9-ae1f-405d-9fce-91859a2e6b9f"), "082", "1602867263338236", new Guid("511791d9-ae1f-405d-9fce-91859a2e6b9f"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072"), "10/08" },
                    { new Guid("51251624-ca46-4362-b08d-d2735c58d073"), "666", "1271363617640272", new Guid("51251624-ca46-4362-b08d-d2735c58d073"), new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119"), "01/26" },
                    { new Guid("513fdba7-3201-44a2-9aff-905c32c41f9d"), "070", "3478323992191549", new Guid("513fdba7-3201-44a2-9aff-905c32c41f9d"), new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b"), "05/22" },
                    { new Guid("519f1cf9-1c23-4f92-9e01-8100448b618e"), "198", "4450206516319330", new Guid("519f1cf9-1c23-4f92-9e01-8100448b618e"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d"), "01/10" },
                    { new Guid("51d2a772-34e3-4d6e-bfe6-f1b7301a2697"), "414", "7521555974073726", new Guid("51d2a772-34e3-4d6e-bfe6-f1b7301a2697"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea"), "01/03" },
                    { new Guid("527742c2-cda9-4105-bf89-3dc6a165a6fa"), "027", "3321737264744849", new Guid("527742c2-cda9-4105-bf89-3dc6a165a6fa"), new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d"), "07/17" },
                    { new Guid("533a2c4e-f1b1-42cc-8f9f-9a2402fa9527"), "648", "9817481307637010", new Guid("533a2c4e-f1b1-42cc-8f9f-9a2402fa9527"), new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b"), "03/17" },
                    { new Guid("537acd16-3de4-47fe-bf57-9110530c1d75"), "099", "8089121264894348", new Guid("537acd16-3de4-47fe-bf57-9110530c1d75"), new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e"), "10/19" },
                    { new Guid("53a054e7-fc68-411f-843a-6334e2eff2a5"), "900", "8731092246259976", new Guid("53a054e7-fc68-411f-843a-6334e2eff2a5"), new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473"), "02/11" },
                    { new Guid("548b9215-7238-40ce-ab2c-03ce455b1715"), "411", "3891427216432650", new Guid("548b9215-7238-40ce-ab2c-03ce455b1715"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964"), "12/21" },
                    { new Guid("54b013c4-8703-48b5-be88-9d9310a722b4"), "685", "5942505182493210", new Guid("54b013c4-8703-48b5-be88-9d9310a722b4"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30"), "07/10" },
                    { new Guid("556f96fc-d6e9-4c83-b758-31045f9b3b9e"), "984", "6077885098105210", new Guid("556f96fc-d6e9-4c83-b758-31045f9b3b9e"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f"), "05/25" },
                    { new Guid("55b60d58-68cb-4a0a-a233-df07893b312f"), "551", "7866479552888941", new Guid("55b60d58-68cb-4a0a-a233-df07893b312f"), new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403"), "09/24" },
                    { new Guid("560922b9-a990-446a-9bae-8610cfd267bb"), "417", "7128882590368141", new Guid("560922b9-a990-446a-9bae-8610cfd267bb"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0"), "11/23" },
                    { new Guid("564d9b5b-752f-4c43-8030-2ef7feec572d"), "209", "3552487950616700", new Guid("564d9b5b-752f-4c43-8030-2ef7feec572d"), new Guid("5558c531-153b-4da7-9848-996b07daa782"), "09/03" },
                    { new Guid("56674731-7757-468c-a07f-ae45e20c31ca"), "022", "2650502575416458", new Guid("56674731-7757-468c-a07f-ae45e20c31ca"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247"), "01/11" },
                    { new Guid("566b3cd2-de66-40f2-8c04-7b2e9e7d6348"), "222", "9801333693958013", new Guid("566b3cd2-de66-40f2-8c04-7b2e9e7d6348"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780"), "04/06" },
                    { new Guid("56b514e2-71ea-4a22-85d3-7ccf5ed3f460"), "250", "9719337503831900", new Guid("56b514e2-71ea-4a22-85d3-7ccf5ed3f460"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81"), "05/14" },
                    { new Guid("56b85e0e-1424-4b85-95e8-a46dfab994a8"), "855", "6532601708350799", new Guid("56b85e0e-1424-4b85-95e8-a46dfab994a8"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556"), "04/01" },
                    { new Guid("57dcc6ef-ac9f-4a1e-a8df-a576b3b4d168"), "712", "8278964615735391", new Guid("57dcc6ef-ac9f-4a1e-a8df-a576b3b4d168"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c"), "04/11" },
                    { new Guid("57df3d5c-c1f0-47f0-ac32-4e0aeaf49db2"), "183", "3698662416718174", new Guid("57df3d5c-c1f0-47f0-ac32-4e0aeaf49db2"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e"), "03/05" },
                    { new Guid("58011695-d4e5-4a89-87b9-46d50f5d7a45"), "811", "9592930213907531", new Guid("58011695-d4e5-4a89-87b9-46d50f5d7a45"), new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4"), "01/11" },
                    { new Guid("580a3e41-423a-4d11-81c2-7a37bb12a803"), "451", "1392644762337349", new Guid("580a3e41-423a-4d11-81c2-7a37bb12a803"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34"), "07/24" },
                    { new Guid("58262af4-dcea-47fc-9c24-ec8b59896565"), "264", "2723277327482526", new Guid("58262af4-dcea-47fc-9c24-ec8b59896565"), new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d"), "04/23" },
                    { new Guid("5831c74a-eb45-43f2-86e4-022022f98077"), "136", "7205312131904877", new Guid("5831c74a-eb45-43f2-86e4-022022f98077"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8"), "06/17" },
                    { new Guid("58b83b1e-52f8-43d0-8e8f-a60bfb9229d7"), "332", "8509610379670356", new Guid("58b83b1e-52f8-43d0-8e8f-a60bfb9229d7"), new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5"), "12/04" },
                    { new Guid("59d4d87c-9b33-4fda-888a-db47fa63db96"), "288", "8886891532133692", new Guid("59d4d87c-9b33-4fda-888a-db47fa63db96"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea"), "08/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("5a0e151c-1e17-4e0f-9116-8d3720045490"), "308", "3087674514956941", new Guid("5a0e151c-1e17-4e0f-9116-8d3720045490"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131"), "12/12" },
                    { new Guid("5a43bda9-1b26-4423-9d97-c4c4ff2c42cd"), "071", "4430611781692078", new Guid("5a43bda9-1b26-4423-9d97-c4c4ff2c42cd"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa"), "03/23" },
                    { new Guid("5ac8f22e-472f-4bf2-91e7-c89b8829a773"), "186", "7461243564146261", new Guid("5ac8f22e-472f-4bf2-91e7-c89b8829a773"), new Guid("28f12604-451b-425e-ae23-1db801053b3e"), "08/11" },
                    { new Guid("5b34e300-e4c1-44c5-9e85-5449ee1ed1b2"), "403", "3418734784351097", new Guid("5b34e300-e4c1-44c5-9e85-5449ee1ed1b2"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95"), "11/05" },
                    { new Guid("5b899b7c-1b61-482c-aee4-d422c7d9e2dc"), "606", "3900176825312221", new Guid("5b899b7c-1b61-482c-aee4-d422c7d9e2dc"), new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22"), "07/21" },
                    { new Guid("5bdd749d-a4d0-42f3-a440-1fb8501ab350"), "492", "4404070806780558", new Guid("5bdd749d-a4d0-42f3-a440-1fb8501ab350"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c"), "06/06" },
                    { new Guid("5bde532d-c76e-478e-a9f7-4e46646b477e"), "883", "2762870332158678", new Guid("5bde532d-c76e-478e-a9f7-4e46646b477e"), new Guid("71725c06-aded-4994-8181-26d1683597c4"), "12/26" },
                    { new Guid("5becbb34-5d47-4167-a6c0-d5700ee806cd"), "526", "4355155236225511", new Guid("5becbb34-5d47-4167-a6c0-d5700ee806cd"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e"), "05/15" },
                    { new Guid("5c13a24e-54be-4938-bd08-c820e4570d1b"), "500", "2127616766185882", new Guid("5c13a24e-54be-4938-bd08-c820e4570d1b"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47"), "05/05" },
                    { new Guid("5c370ecc-0f85-4a0e-b4a0-028577b6d29a"), "184", "8540294674445895", new Guid("5c370ecc-0f85-4a0e-b4a0-028577b6d29a"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247"), "12/10" },
                    { new Guid("5c5e8b41-f87c-428c-8ccf-2ea1864718b9"), "962", "4298311900294945", new Guid("5c5e8b41-f87c-428c-8ccf-2ea1864718b9"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea"), "09/09" },
                    { new Guid("5cb38131-9d4f-4653-9847-733857618cd3"), "954", "9945851840629041", new Guid("5cb38131-9d4f-4653-9847-733857618cd3"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854"), "07/04" },
                    { new Guid("5d5a507b-5553-4f8e-9a3e-63dfc05446ae"), "857", "1967009894476531", new Guid("5d5a507b-5553-4f8e-9a3e-63dfc05446ae"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b"), "07/08" },
                    { new Guid("5e052349-21e6-43c6-b21b-8e2fda4c09a4"), "256", "3051448199334598", new Guid("5e052349-21e6-43c6-b21b-8e2fda4c09a4"), new Guid("314374c4-1bd7-4eda-8546-58617e464254"), "07/17" },
                    { new Guid("5e193636-c561-4b25-bc38-f30217fb7537"), "398", "2853955210007642", new Guid("5e193636-c561-4b25-bc38-f30217fb7537"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555"), "09/06" },
                    { new Guid("5e59ca85-f851-425c-a481-005c8e710568"), "654", "7545070504500282", new Guid("5e59ca85-f851-425c-a481-005c8e710568"), new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6"), "12/04" },
                    { new Guid("5e8d67c9-a343-488c-9c58-65d736b36e71"), "788", "9369821120707221", new Guid("5e8d67c9-a343-488c-9c58-65d736b36e71"), new Guid("665af7ab-85d3-48f3-bedd-30db54699f81"), "02/25" },
                    { new Guid("5e99e69f-5658-4a73-a56b-818a0be9d11f"), "055", "5167529958182972", new Guid("5e99e69f-5658-4a73-a56b-818a0be9d11f"), new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556"), "12/28" },
                    { new Guid("5e9d5713-4928-497d-a82c-7d7df392060c"), "004", "7683728151839560", new Guid("5e9d5713-4928-497d-a82c-7d7df392060c"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d"), "09/08" },
                    { new Guid("5ea23fa3-5f21-4b44-8f2e-0a001bfa3d98"), "648", "3533428290757076", new Guid("5ea23fa3-5f21-4b44-8f2e-0a001bfa3d98"), new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29"), "07/23" },
                    { new Guid("5f7fecf7-65a9-48c6-84c8-3ec9fc40f001"), "691", "2089825767484882", new Guid("5f7fecf7-65a9-48c6-84c8-3ec9fc40f001"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6"), "08/27" },
                    { new Guid("5fd71e5d-a772-48d0-8923-9d413e1a1e07"), "783", "4419631988349206", new Guid("5fd71e5d-a772-48d0-8923-9d413e1a1e07"), new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d"), "01/19" },
                    { new Guid("5fe08895-6852-4984-97cb-00517601452d"), "048", "5637739110594052", new Guid("5fe08895-6852-4984-97cb-00517601452d"), new Guid("d422e4b4-5d7b-484f-830c-319350a69b22"), "09/09" },
                    { new Guid("6049a3ec-e96a-4594-b0fd-7e6df68a11a5"), "664", "1856229228581357", new Guid("6049a3ec-e96a-4594-b0fd-7e6df68a11a5"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4"), "04/24" },
                    { new Guid("609145b7-0c34-4c9a-a8e5-9924665e71e5"), "053", "3352078490468614", new Guid("609145b7-0c34-4c9a-a8e5-9924665e71e5"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7"), "02/02" },
                    { new Guid("60b33c91-8b49-4ce3-af84-487420770e46"), "591", "8387258861361907", new Guid("60b33c91-8b49-4ce3-af84-487420770e46"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628"), "08/19" },
                    { new Guid("60e83d76-52ab-49a8-a97d-476a94bd8812"), "661", "5115171197942421", new Guid("60e83d76-52ab-49a8-a97d-476a94bd8812"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), "10/24" },
                    { new Guid("60fc58e9-1a1d-4cdb-a2d0-f1fa2c02513b"), "520", "2086954257606255", new Guid("60fc58e9-1a1d-4cdb-a2d0-f1fa2c02513b"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8"), "07/17" },
                    { new Guid("617c1b2a-b515-4f80-8321-9ab09b7b1974"), "164", "2391356223148584", new Guid("617c1b2a-b515-4f80-8321-9ab09b7b1974"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a"), "12/23" },
                    { new Guid("6188120e-7eab-4523-84fd-d3fb96402abc"), "102", "7240577185424576", new Guid("6188120e-7eab-4523-84fd-d3fb96402abc"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c"), "07/23" },
                    { new Guid("61e6f7e9-1bab-4b35-9ada-3496d9466385"), "662", "9497349248000654", new Guid("61e6f7e9-1bab-4b35-9ada-3496d9466385"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918"), "06/06" },
                    { new Guid("62fc328f-a92e-4441-9798-2ea7d05ae665"), "600", "7167911350942072", new Guid("62fc328f-a92e-4441-9798-2ea7d05ae665"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b"), "01/08" },
                    { new Guid("63b6611f-d291-41d7-9332-23c23773ffca"), "971", "5247842604280342", new Guid("63b6611f-d291-41d7-9332-23c23773ffca"), new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918"), "07/25" },
                    { new Guid("6405c63e-a07d-4fb7-9aa7-90361c4ac193"), "505", "1558586998933272", new Guid("6405c63e-a07d-4fb7-9aa7-90361c4ac193"), new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03"), "06/10" },
                    { new Guid("648703f5-6f08-46e9-aa01-81027d49ca14"), "549", "7462494255593871", new Guid("648703f5-6f08-46e9-aa01-81027d49ca14"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e"), "07/09" },
                    { new Guid("648bbd90-751c-4473-bdc0-2a415d448862"), "198", "2572251581972555", new Guid("648bbd90-751c-4473-bdc0-2a415d448862"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978"), "07/23" },
                    { new Guid("64b4d41f-3031-4e75-b851-1f3b510dd342"), "997", "7236232015416008", new Guid("64b4d41f-3031-4e75-b851-1f3b510dd342"), new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a"), "10/08" },
                    { new Guid("65011d3b-bca6-49fc-b282-121ec45f0b44"), "200", "3183518027803244", new Guid("65011d3b-bca6-49fc-b282-121ec45f0b44"), new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456"), "12/26" },
                    { new Guid("662eb201-9a2b-48c8-9b87-75f9380dd694"), "945", "7621470719237205", new Guid("662eb201-9a2b-48c8-9b87-75f9380dd694"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626"), "03/02" },
                    { new Guid("663d03f0-3699-45a8-a886-51e612ad1646"), "606", "4151684888350117", new Guid("663d03f0-3699-45a8-a886-51e612ad1646"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a"), "10/14" },
                    { new Guid("66cb8955-9084-4714-8d6a-61651582f6b9"), "527", "2406942756916224", new Guid("66cb8955-9084-4714-8d6a-61651582f6b9"), new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33"), "02/25" },
                    { new Guid("66dd5c3b-3a20-4b37-94f0-d32b661e174f"), "972", "2810793217195409", new Guid("66dd5c3b-3a20-4b37-94f0-d32b661e174f"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124"), "03/14" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("679d5080-c888-43d5-903d-a3846c73a56d"), "665", "1260809776883393", new Guid("679d5080-c888-43d5-903d-a3846c73a56d"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1"), "04/20" },
                    { new Guid("685f17e8-86cd-445b-9d6c-a33c18fd3662"), "823", "8117588186387322", new Guid("685f17e8-86cd-445b-9d6c-a33c18fd3662"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26"), "05/17" },
                    { new Guid("686ea406-050e-408b-8b48-818d57e8fe81"), "085", "2826650204520826", new Guid("686ea406-050e-408b-8b48-818d57e8fe81"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa"), "01/20" },
                    { new Guid("68e00a7d-e630-4238-9e95-c511ba76869e"), "234", "5710032044771484", new Guid("68e00a7d-e630-4238-9e95-c511ba76869e"), new Guid("0823436c-27ad-4402-b5e2-b17efa08505e"), "07/12" },
                    { new Guid("69078cec-3e46-4a9f-8171-f2e5baea46d8"), "257", "1363294815066407", new Guid("69078cec-3e46-4a9f-8171-f2e5baea46d8"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3"), "01/20" },
                    { new Guid("6921a27e-4c41-464a-9b7e-92ce13919f25"), "782", "3537369029021267", new Guid("6921a27e-4c41-464a-9b7e-92ce13919f25"), new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674"), "11/05" },
                    { new Guid("696ed310-8f14-4cae-b2bd-071f417b192c"), "919", "8675600674457017", new Guid("696ed310-8f14-4cae-b2bd-071f417b192c"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75"), "07/26" },
                    { new Guid("6976d483-6296-4290-9c9f-9119c44c1011"), "225", "3726634030154662", new Guid("6976d483-6296-4290-9c9f-9119c44c1011"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af"), "10/22" },
                    { new Guid("69cff36e-13f8-40b3-9ab1-50c16ef462c7"), "558", "9044669272224306", new Guid("69cff36e-13f8-40b3-9ab1-50c16ef462c7"), new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa"), "11/03" },
                    { new Guid("6a23b980-2b14-47b1-8437-8818a112c34d"), "315", "6354249862240805", new Guid("6a23b980-2b14-47b1-8437-8818a112c34d"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9"), "04/27" },
                    { new Guid("6a92b1a9-fb73-492e-9474-16bbbea8ab13"), "997", "2798256818203900", new Guid("6a92b1a9-fb73-492e-9474-16bbbea8ab13"), new Guid("f7720de3-aaea-48e9-af48-569af731d90b"), "11/12" },
                    { new Guid("6b075e80-d2ec-429a-b03b-d5c295f066a6"), "769", "4501295745073555", new Guid("6b075e80-d2ec-429a-b03b-d5c295f066a6"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822"), "04/15" },
                    { new Guid("6b405f4a-1282-4bec-92e3-814f410e4126"), "129", "8925015062178552", new Guid("6b405f4a-1282-4bec-92e3-814f410e4126"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186"), "03/19" },
                    { new Guid("6b5f9a2f-d8fc-41b9-b368-3fa607a8a66e"), "141", "3057021728324364", new Guid("6b5f9a2f-d8fc-41b9-b368-3fa607a8a66e"), new Guid("7637da20-6c85-4358-a711-5912b0358007"), "05/26" },
                    { new Guid("6b70a4f0-4262-4282-a301-951dfaa67e4e"), "835", "7189565422157084", new Guid("6b70a4f0-4262-4282-a301-951dfaa67e4e"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1"), "11/25" },
                    { new Guid("6c05af30-11ce-414e-b94d-2246c1c74c48"), "116", "1157817887461256", new Guid("6c05af30-11ce-414e-b94d-2246c1c74c48"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0"), "03/28" },
                    { new Guid("6c43dc3c-6076-4e4b-a6ef-9e54d4dc62cf"), "629", "8267775179037164", new Guid("6c43dc3c-6076-4e4b-a6ef-9e54d4dc62cf"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822"), "10/17" },
                    { new Guid("6c78c9f2-d637-4907-8a00-501090447ebf"), "753", "2595794515672136", new Guid("6c78c9f2-d637-4907-8a00-501090447ebf"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964"), "01/14" },
                    { new Guid("6ca614b0-740c-40f6-ba5a-467b516c0e45"), "693", "4047417986193034", new Guid("6ca614b0-740c-40f6-ba5a-467b516c0e45"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f"), "08/20" },
                    { new Guid("6cdb93ee-6bc1-4657-8815-1f0a48550b47"), "992", "8785577813274835", new Guid("6cdb93ee-6bc1-4657-8815-1f0a48550b47"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a"), "03/01" },
                    { new Guid("6d782c16-6da8-4e2a-b5d5-a05978906c83"), "954", "5195336786796708", new Guid("6d782c16-6da8-4e2a-b5d5-a05978906c83"), new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628"), "02/13" },
                    { new Guid("6d9df1c1-242a-436a-bd61-8f8349427d77"), "563", "1408923405219297", new Guid("6d9df1c1-242a-436a-bd61-8f8349427d77"), new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5"), "03/06" },
                    { new Guid("6e1e8516-4d93-4ab0-8417-8771262e8ddd"), "423", "3974421320226318", new Guid("6e1e8516-4d93-4ab0-8417-8771262e8ddd"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48"), "03/18" },
                    { new Guid("6e278eac-5770-4e87-b94b-a92bb8f9fb3b"), "105", "1586421394642438", new Guid("6e278eac-5770-4e87-b94b-a92bb8f9fb3b"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30"), "10/26" },
                    { new Guid("6f14c6e7-a09a-410b-baa6-f65e58a0f05d"), "793", "1006819331039029", new Guid("6f14c6e7-a09a-410b-baa6-f65e58a0f05d"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7"), "04/02" },
                    { new Guid("6f2c640f-f02f-4bc0-bf78-ae5a49f371af"), "482", "9788643937070495", new Guid("6f2c640f-f02f-4bc0-bf78-ae5a49f371af"), new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a"), "03/21" },
                    { new Guid("6f5f8314-10bc-4155-adb0-becefec6eaa6"), "157", "7872752404415490", new Guid("6f5f8314-10bc-4155-adb0-becefec6eaa6"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc"), "10/19" },
                    { new Guid("6f7441ee-55d9-402f-af6a-ee86dd21fc35"), "802", "8723354652601530", new Guid("6f7441ee-55d9-402f-af6a-ee86dd21fc35"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162"), "06/14" },
                    { new Guid("6f9d4b24-6d9b-47f0-9c53-2d5fa6acb7dc"), "302", "7461946353722938", new Guid("6f9d4b24-6d9b-47f0-9c53-2d5fa6acb7dc"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957"), "04/06" },
                    { new Guid("6fc9250c-eea4-4f23-835a-4bef25af3f9f"), "287", "1917786669738365", new Guid("6fc9250c-eea4-4f23-835a-4bef25af3f9f"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf"), "12/28" },
                    { new Guid("6fdabe42-9b70-4fb0-96ea-2ac2171f567f"), "243", "4209593825592525", new Guid("6fdabe42-9b70-4fb0-96ea-2ac2171f567f"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76"), "06/11" },
                    { new Guid("70053c14-5ed3-4d32-80f4-020a5887a6c3"), "944", "4895336631068879", new Guid("70053c14-5ed3-4d32-80f4-020a5887a6c3"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af"), "02/19" },
                    { new Guid("70553ea7-f125-4606-b04a-2f7106fa9dbe"), "776", "7803179584460014", new Guid("70553ea7-f125-4606-b04a-2f7106fa9dbe"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186"), "12/05" },
                    { new Guid("70fbb979-c7cd-41a8-8a01-794d91c480c1"), "246", "3453614205567385", new Guid("70fbb979-c7cd-41a8-8a01-794d91c480c1"), new Guid("54544805-6149-40a0-a366-c2fb8f55975f"), "04/08" },
                    { new Guid("71310094-1005-4f4f-9741-cf87e85cb819"), "988", "2704203314470881", new Guid("71310094-1005-4f4f-9741-cf87e85cb819"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0"), "11/24" },
                    { new Guid("715203d6-ef39-4120-94f7-f8b31c3f4544"), "296", "2482885855044496", new Guid("715203d6-ef39-4120-94f7-f8b31c3f4544"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20"), "10/24" },
                    { new Guid("7316e1e3-515a-4dee-9967-a8d2c334de47"), "419", "1775991326457812", new Guid("7316e1e3-515a-4dee-9967-a8d2c334de47"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88"), "03/20" },
                    { new Guid("733e9dab-ae17-41d3-a404-ef6080794e21"), "497", "9066193232540313", new Guid("733e9dab-ae17-41d3-a404-ef6080794e21"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9"), "09/05" },
                    { new Guid("73d841d2-d7c9-4654-b090-a4061d2944b3"), "096", "3445823523614402", new Guid("73d841d2-d7c9-4654-b090-a4061d2944b3"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131"), "05/19" },
                    { new Guid("740c50be-dabf-4afb-b2e1-d0cae5570dd2"), "586", "3520432263149495", new Guid("740c50be-dabf-4afb-b2e1-d0cae5570dd2"), new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626"), "11/20" },
                    { new Guid("742187f5-9f9e-4e7b-ba26-4ed798e2a8b4"), "432", "9812235935495003", new Guid("742187f5-9f9e-4e7b-ba26-4ed798e2a8b4"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88"), "03/03" },
                    { new Guid("74f7dde7-469a-4b82-82fa-f6aced5da710"), "557", "3732477175637931", new Guid("74f7dde7-469a-4b82-82fa-f6aced5da710"), new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65"), "06/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("75192e58-2e2b-4353-9828-663bfaadb85e"), "849", "9604077159933546", new Guid("75192e58-2e2b-4353-9828-663bfaadb85e"), new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd"), "10/11" },
                    { new Guid("75253fd1-fee0-4061-ba76-65af429d7445"), "799", "8260874359891163", new Guid("75253fd1-fee0-4061-ba76-65af429d7445"), new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131"), "07/01" },
                    { new Guid("75516be8-841e-4777-91db-28a4daaa719f"), "465", "9957702480077468", new Guid("75516be8-841e-4777-91db-28a4daaa719f"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8"), "07/13" },
                    { new Guid("75a0bf5c-8830-4eb1-9b22-2d77eef06d8c"), "266", "3322441816960919", new Guid("75a0bf5c-8830-4eb1-9b22-2d77eef06d8c"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b"), "03/28" },
                    { new Guid("75a200c6-6117-4c59-8b12-e4e1613d34fd"), "844", "9113252415371706", new Guid("75a200c6-6117-4c59-8b12-e4e1613d34fd"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162"), "06/27" },
                    { new Guid("75d2aceb-8970-4f0f-a72e-62c24ed0de63"), "468", "9229162552656943", new Guid("75d2aceb-8970-4f0f-a72e-62c24ed0de63"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3"), "06/11" },
                    { new Guid("75dbdd25-f65a-45f2-9a45-37f76c032e20"), "026", "6238291092398705", new Guid("75dbdd25-f65a-45f2-9a45-37f76c032e20"), new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718"), "08/14" },
                    { new Guid("76d52625-7d2e-4dab-9626-f712b7b9c0ca"), "292", "5593084776955002", new Guid("76d52625-7d2e-4dab-9626-f712b7b9c0ca"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd"), "10/26" },
                    { new Guid("77346a4d-1803-4ce6-a8b6-aa8d05b38d00"), "852", "3842590226593440", new Guid("77346a4d-1803-4ce6-a8b6-aa8d05b38d00"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5"), "09/08" },
                    { new Guid("7852903e-0726-49ef-9d9e-54cce88410cf"), "475", "8241449473046817", new Guid("7852903e-0726-49ef-9d9e-54cce88410cf"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330"), "02/17" },
                    { new Guid("7890f42f-587b-4dcf-9721-bff3c889ad1a"), "812", "3391565820455668", new Guid("7890f42f-587b-4dcf-9721-bff3c889ad1a"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d"), "05/23" },
                    { new Guid("7896113e-7c7a-4577-9476-fef7f3975ff7"), "844", "3492200337885207", new Guid("7896113e-7c7a-4577-9476-fef7f3975ff7"), new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a"), "08/18" },
                    { new Guid("78f26f43-a4ad-4b85-a5da-92ac08bdac19"), "227", "2537971846348032", new Guid("78f26f43-a4ad-4b85-a5da-92ac08bdac19"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957"), "12/02" },
                    { new Guid("78f89b86-c05d-4db9-be9f-63395ec4b066"), "763", "5058332315920987", new Guid("78f89b86-c05d-4db9-be9f-63395ec4b066"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957"), "01/27" },
                    { new Guid("791985a5-a8b2-4a0b-802a-f8f9af3eb86b"), "014", "3006973937591846", new Guid("791985a5-a8b2-4a0b-802a-f8f9af3eb86b"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511"), "04/07" },
                    { new Guid("796eb69e-2495-4a5c-98dc-13c9849408d6"), "582", "6281787953296521", new Guid("796eb69e-2495-4a5c-98dc-13c9849408d6"), new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861"), "04/02" },
                    { new Guid("79e836e2-8905-4714-81bf-d1f93baef6af"), "217", "7042709458932254", new Guid("79e836e2-8905-4714-81bf-d1f93baef6af"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5"), "05/15" },
                    { new Guid("7a1d27f4-c422-4163-897a-0a5262556075"), "118", "7636213363222905", new Guid("7a1d27f4-c422-4163-897a-0a5262556075"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48"), "11/04" },
                    { new Guid("7a79539b-f02c-47a1-ae39-833daf776e77"), "533", "3627479210300197", new Guid("7a79539b-f02c-47a1-ae39-833daf776e77"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655"), "08/20" },
                    { new Guid("7ac70d49-bce2-4d07-b9db-87e87a137590"), "880", "6963190339119522", new Guid("7ac70d49-bce2-4d07-b9db-87e87a137590"), new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2"), "07/04" },
                    { new Guid("7ae5aae5-1562-40fe-a16e-e6e54bb48176"), "717", "8857080120938154", new Guid("7ae5aae5-1562-40fe-a16e-e6e54bb48176"), new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf"), "06/26" },
                    { new Guid("7ba279f6-1bf6-4d5c-9491-b89462491716"), "061", "1381665624926703", new Guid("7ba279f6-1bf6-4d5c-9491-b89462491716"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5"), "01/03" },
                    { new Guid("7bc979c5-bdc2-45a0-a417-fd8ccbfa5bcf"), "366", "6015984618668327", new Guid("7bc979c5-bdc2-45a0-a417-fd8ccbfa5bcf"), new Guid("48949002-3dd7-424b-b508-bb6644cad6fb"), "07/16" },
                    { new Guid("7bdafd45-16f4-4dbc-ad8a-6239fae068dc"), "073", "7220775584287459", new Guid("7bdafd45-16f4-4dbc-ad8a-6239fae068dc"), new Guid("8f8cd90d-fe20-4df0-8607-72f337546146"), "06/06" },
                    { new Guid("7c10f36a-fef5-450b-b9ce-bf7b542f552f"), "818", "8282018180717364", new Guid("7c10f36a-fef5-450b-b9ce-bf7b542f552f"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a"), "02/28" },
                    { new Guid("7c367a07-86e7-4928-a144-e6f4df1db11c"), "129", "6547152930090925", new Guid("7c367a07-86e7-4928-a144-e6f4df1db11c"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779"), "03/09" },
                    { new Guid("7cc03902-778e-4249-85da-e868f7aa9790"), "982", "7809323505650141", new Guid("7cc03902-778e-4249-85da-e868f7aa9790"), new Guid("8b3ae855-3f1f-409d-8898-00767477ffae"), "12/08" },
                    { new Guid("7cc3ba23-4199-4dc0-9d54-a259fb6ea661"), "476", "5155120281554244", new Guid("7cc3ba23-4199-4dc0-9d54-a259fb6ea661"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c"), "07/17" },
                    { new Guid("7d09942c-2924-4944-ae25-1aabf3ee44e2"), "507", "7961180882875599", new Guid("7d09942c-2924-4944-ae25-1aabf3ee44e2"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21"), "01/13" },
                    { new Guid("7d3dc9a7-7a77-42c1-bb8a-418ae99795e2"), "186", "2355217193582558", new Guid("7d3dc9a7-7a77-42c1-bb8a-418ae99795e2"), new Guid("cb635093-0872-4986-8027-340de9f12a5c"), "11/06" },
                    { new Guid("7d42de28-24d1-4512-98d8-665bfaff1a9a"), "036", "7627532508822566", new Guid("7d42de28-24d1-4512-98d8-665bfaff1a9a"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a"), "06/12" },
                    { new Guid("7d56b245-66ef-490f-bf1d-fd1bca3de7f6"), "740", "8737367112550246", new Guid("7d56b245-66ef-490f-bf1d-fd1bca3de7f6"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604"), "04/25" },
                    { new Guid("7da51aa6-94d0-406c-9a9c-0b139652d206"), "859", "4494693273124038", new Guid("7da51aa6-94d0-406c-9a9c-0b139652d206"), new Guid("810775de-7e6f-4620-99bb-c534d912de67"), "07/08" },
                    { new Guid("7dc43efc-70a0-474f-aabb-dd7c3e213f6b"), "846", "9104504416898650", new Guid("7dc43efc-70a0-474f-aabb-dd7c3e213f6b"), new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7"), "03/12" },
                    { new Guid("7dc50dd5-ab1e-4b52-99ec-1c270cf24cff"), "873", "8554138284257396", new Guid("7dc50dd5-ab1e-4b52-99ec-1c270cf24cff"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe"), "10/25" },
                    { new Guid("7dfc9056-2fea-4ecd-aca8-9fe2b960014f"), "087", "5263537547183787", new Guid("7dfc9056-2fea-4ecd-aca8-9fe2b960014f"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d"), "05/28" },
                    { new Guid("7ebf799d-5c0c-4bda-9a10-d74b61217501"), "675", "1784685630969859", new Guid("7ebf799d-5c0c-4bda-9a10-d74b61217501"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f"), "10/19" },
                    { new Guid("7eddb3d2-a28c-4767-8291-2a00e0e53d6a"), "306", "7240609043135080", new Guid("7eddb3d2-a28c-4767-8291-2a00e0e53d6a"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822"), "07/23" },
                    { new Guid("7f749af7-aaf9-4a2b-89f4-0d0b4870cc7c"), "758", "8570275976707641", new Guid("7f749af7-aaf9-4a2b-89f4-0d0b4870cc7c"), new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb"), "01/26" },
                    { new Guid("7f972691-fb38-4aef-a4cc-547c313292df"), "117", "2426952538057309", new Guid("7f972691-fb38-4aef-a4cc-547c313292df"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98"), "03/04" },
                    { new Guid("7fc1be8d-13fe-472e-a810-7c12b079442a"), "342", "9859748096820069", new Guid("7fc1be8d-13fe-472e-a810-7c12b079442a"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342"), "02/16" },
                    { new Guid("7fe1bb90-e92f-4907-af9b-de93da7f8dad"), "508", "9199659519270361", new Guid("7fe1bb90-e92f-4907-af9b-de93da7f8dad"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410"), "11/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("800d7497-d589-43bf-8bdb-5a11089e6e5c"), "988", "4444819161781703", new Guid("800d7497-d589-43bf-8bdb-5a11089e6e5c"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072"), "10/11" },
                    { new Guid("8094c2d1-427e-4f6f-85b9-d9a94d9095a8"), "834", "4495102226673663", new Guid("8094c2d1-427e-4f6f-85b9-d9a94d9095a8"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe"), "05/07" },
                    { new Guid("80df5bc7-b930-4f0c-beb5-55d4d67b2531"), "527", "1204545324983865", new Guid("80df5bc7-b930-4f0c-beb5-55d4d67b2531"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884"), "03/03" },
                    { new Guid("8155f056-7eb1-4ce9-a411-8567908e1f59"), "625", "5999346459073881", new Guid("8155f056-7eb1-4ce9-a411-8567908e1f59"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), "06/13" },
                    { new Guid("818e9b18-ac51-49a4-ad66-959788ac2fa3"), "770", "1127129054125840", new Guid("818e9b18-ac51-49a4-ad66-959788ac2fa3"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), "09/28" },
                    { new Guid("81bab878-19b5-436a-a06d-f1afa2c0abe2"), "120", "6759106651665141", new Guid("81bab878-19b5-436a-a06d-f1afa2c0abe2"), new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374"), "03/16" },
                    { new Guid("81da5bd9-453b-4dc7-9ec1-752dff279cec"), "320", "9691623872859767", new Guid("81da5bd9-453b-4dc7-9ec1-752dff279cec"), new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0"), "07/07" },
                    { new Guid("822033ae-c2b0-43b6-90af-dda6e4fb8215"), "056", "7834198328784011", new Guid("822033ae-c2b0-43b6-90af-dda6e4fb8215"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73"), "04/16" },
                    { new Guid("82652341-b219-408d-a3fc-e5b654f0faaf"), "011", "4329759935370586", new Guid("82652341-b219-408d-a3fc-e5b654f0faaf"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96"), "05/21" },
                    { new Guid("82923930-d304-4814-a522-a7b6cef75ecf"), "353", "8791418672751942", new Guid("82923930-d304-4814-a522-a7b6cef75ecf"), new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425"), "05/16" },
                    { new Guid("82c24bf0-4a6d-4d45-8a49-de8497127696"), "944", "4037997334033991", new Guid("82c24bf0-4a6d-4d45-8a49-de8497127696"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132"), "05/15" },
                    { new Guid("83452103-99fe-4ec1-9f6e-fa0d143adbc4"), "579", "8201485468096132", new Guid("83452103-99fe-4ec1-9f6e-fa0d143adbc4"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a"), "07/02" },
                    { new Guid("83bfbe58-446c-4de7-8ce6-6b6ec57b0a81"), "935", "5937455658813367", new Guid("83bfbe58-446c-4de7-8ce6-6b6ec57b0a81"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51"), "10/21" },
                    { new Guid("8472ea78-9876-45fa-a69c-b172147eca3f"), "363", "2264663751214867", new Guid("8472ea78-9876-45fa-a69c-b172147eca3f"), new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2"), "11/17" },
                    { new Guid("84ffb7ad-0442-41d8-b867-fd66c29a3567"), "947", "8947703435688090", new Guid("84ffb7ad-0442-41d8-b867-fd66c29a3567"), new Guid("203cc97b-91be-4474-b881-e9776da21af9"), "02/04" },
                    { new Guid("8500981b-0cd0-47f5-bb7f-775440ffb6eb"), "801", "4184587831814524", new Guid("8500981b-0cd0-47f5-bb7f-775440ffb6eb"), new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe"), "10/08" },
                    { new Guid("8566a7c8-1cd2-4437-abfd-65d03e01852d"), "116", "3391548934985270", new Guid("8566a7c8-1cd2-4437-abfd-65d03e01852d"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d"), "01/21" },
                    { new Guid("857c7468-e10e-4f11-94de-9ad58beee072"), "921", "9468445073976345", new Guid("857c7468-e10e-4f11-94de-9ad58beee072"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c"), "03/13" },
                    { new Guid("85878c20-6095-4f55-8ce0-4bf7a8463f51"), "919", "6643245984942583", new Guid("85878c20-6095-4f55-8ce0-4bf7a8463f51"), new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738"), "12/05" },
                    { new Guid("8600eeb5-0624-4ef3-a953-1c16016c7206"), "763", "8247397325621710", new Guid("8600eeb5-0624-4ef3-a953-1c16016c7206"), new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed"), "02/10" },
                    { new Guid("862bea00-1fb9-41d0-bf8c-d802f818a231"), "842", "1885899744638015", new Guid("862bea00-1fb9-41d0-bf8c-d802f818a231"), new Guid("c0886dea-4971-4369-8d28-75754e2575d0"), "02/12" },
                    { new Guid("8637b13c-fc8a-43bb-b2bb-da9e30adc7de"), "216", "6028400473338934", new Guid("8637b13c-fc8a-43bb-b2bb-da9e30adc7de"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258"), "04/01" },
                    { new Guid("868fa00f-7db0-49f1-8efc-e9274040dd0c"), "314", "7628044085785840", new Guid("868fa00f-7db0-49f1-8efc-e9274040dd0c"), new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4"), "10/01" },
                    { new Guid("869e9a0d-d748-4e2a-a133-0d4ca97b7486"), "760", "5191493226003491", new Guid("869e9a0d-d748-4e2a-a133-0d4ca97b7486"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8"), "06/04" },
                    { new Guid("877d41ad-4f4c-4333-9602-95b810bf444b"), "676", "7420200920908403", new Guid("877d41ad-4f4c-4333-9602-95b810bf444b"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41"), "12/16" },
                    { new Guid("880414ac-a579-4ebc-839a-62256739da89"), "055", "3275454820430426", new Guid("880414ac-a579-4ebc-839a-62256739da89"), new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d"), "04/07" },
                    { new Guid("882afbc6-20dd-4046-8e4b-72be98579cac"), "729", "1347678172122553", new Guid("882afbc6-20dd-4046-8e4b-72be98579cac"), new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a"), "12/11" },
                    { new Guid("88507007-a409-4e29-a8a6-dd01ca090620"), "825", "3170051707359914", new Guid("88507007-a409-4e29-a8a6-dd01ca090620"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea"), "04/06" },
                    { new Guid("88836381-471a-4cb0-859a-5f5514adbde3"), "144", "7039462751547773", new Guid("88836381-471a-4cb0-859a-5f5514adbde3"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779"), "12/10" },
                    { new Guid("88861f0b-115f-49f8-a078-b79605399727"), "237", "2113070732385655", new Guid("88861f0b-115f-49f8-a078-b79605399727"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1"), "04/07" },
                    { new Guid("88b6a600-6a2d-46ab-8aa6-c7bb50551357"), "455", "4379675207728408", new Guid("88b6a600-6a2d-46ab-8aa6-c7bb50551357"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316"), "10/24" },
                    { new Guid("88e85dd3-ad3e-40bd-8d84-6a6cc86c22a6"), "449", "2514159109461450", new Guid("88e85dd3-ad3e-40bd-8d84-6a6cc86c22a6"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9"), "03/28" },
                    { new Guid("89021495-9935-4072-9245-6db9371d76a0"), "598", "7203899626576260", new Guid("89021495-9935-4072-9245-6db9371d76a0"), new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7"), "08/17" },
                    { new Guid("89141716-8551-44d6-acaa-9ba96f4a9cc3"), "143", "6975363691682243", new Guid("89141716-8551-44d6-acaa-9ba96f4a9cc3"), new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26"), "06/21" },
                    { new Guid("89247ba0-4c96-471f-9825-13d2351cc470"), "656", "1811463135299559", new Guid("89247ba0-4c96-471f-9825-13d2351cc470"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05"), "09/10" },
                    { new Guid("8924958e-f066-4439-87be-41fcbe9d9b74"), "239", "3613569685672548", new Guid("8924958e-f066-4439-87be-41fcbe9d9b74"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0"), "02/12" },
                    { new Guid("898f3974-f8ec-4691-9149-e2a740b2dc22"), "605", "2368429920561542", new Guid("898f3974-f8ec-4691-9149-e2a740b2dc22"), new Guid("9f745913-393e-4d75-924b-12ed8606f936"), "08/19" },
                    { new Guid("89ab8ed3-f133-44af-9a1c-36f9c414ece6"), "205", "2836966229676773", new Guid("89ab8ed3-f133-44af-9a1c-36f9c414ece6"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316"), "09/20" },
                    { new Guid("89d93ad7-a0ba-46ff-817f-ddde73917dc0"), "850", "7541098143081680", new Guid("89d93ad7-a0ba-46ff-817f-ddde73917dc0"), new Guid("cb635093-0872-4986-8027-340de9f12a5c"), "03/23" },
                    { new Guid("89e6f732-3c90-420d-9f04-9d1602caccd3"), "307", "1820478175355523", new Guid("89e6f732-3c90-420d-9f04-9d1602caccd3"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6"), "05/19" },
                    { new Guid("89e92a13-7497-401a-b52a-9f4a7c058893"), "760", "5125074997929688", new Guid("89e92a13-7497-401a-b52a-9f4a7c058893"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), "12/22" },
                    { new Guid("8b15eea6-fe29-4bdb-aeb8-d7d02a437755"), "885", "7264426344329675", new Guid("8b15eea6-fe29-4bdb-aeb8-d7d02a437755"), new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e"), "03/09" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8b29c52a-c388-4b56-b0a3-325a1c1dfd15"), "742", "5976965286854196", new Guid("8b29c52a-c388-4b56-b0a3-325a1c1dfd15"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a"), "06/27" },
                    { new Guid("8b5629b4-e76e-4db9-bbbb-c7f056105248"), "553", "8223268969974561", new Guid("8b5629b4-e76e-4db9-bbbb-c7f056105248"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c"), "01/04" },
                    { new Guid("8c04ddcb-789d-4963-bd02-545f0afa7097"), "426", "8515328838708235", new Guid("8c04ddcb-789d-4963-bd02-545f0afa7097"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73"), "01/24" },
                    { new Guid("8c5b55a6-fcd2-4170-b5e1-5dcfdfdd7b6f"), "961", "3231056186233252", new Guid("8c5b55a6-fcd2-4170-b5e1-5dcfdfdd7b6f"), new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c"), "03/21" },
                    { new Guid("8c9a6922-8186-4270-994a-9b603de0022d"), "827", "4867865988672491", new Guid("8c9a6922-8186-4270-994a-9b603de0022d"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604"), "06/02" },
                    { new Guid("8ca92799-8047-473e-b418-4407b8796733"), "066", "9210581058627904", new Guid("8ca92799-8047-473e-b418-4407b8796733"), new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6"), "06/18" },
                    { new Guid("8dd4b95c-fc84-4674-98de-b55d66ecdbdb"), "902", "5172960185230729", new Guid("8dd4b95c-fc84-4674-98de-b55d66ecdbdb"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6"), "05/03" },
                    { new Guid("8de6c520-2a24-4179-a612-a46d2a7a6e0b"), "963", "2920178064527267", new Guid("8de6c520-2a24-4179-a612-a46d2a7a6e0b"), new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b"), "07/12" },
                    { new Guid("8f9f9e4e-38e7-4e83-a4fc-b2f29d0296c8"), "528", "7060732359645807", new Guid("8f9f9e4e-38e7-4e83-a4fc-b2f29d0296c8"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa"), "12/02" },
                    { new Guid("902da9b9-0dc9-49f6-80b7-12e72b001667"), "957", "4239247191948512", new Guid("902da9b9-0dc9-49f6-80b7-12e72b001667"), new Guid("5558c531-153b-4da7-9848-996b07daa782"), "11/09" },
                    { new Guid("907c0db8-d19d-4f0c-a4d0-6dfed53d8429"), "839", "6114352984430487", new Guid("907c0db8-d19d-4f0c-a4d0-6dfed53d8429"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), "09/16" },
                    { new Guid("9139f1ea-980b-40b4-bbe1-27b6b46e1c0e"), "751", "3154633789357246", new Guid("9139f1ea-980b-40b4-bbe1-27b6b46e1c0e"), new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4"), "12/25" },
                    { new Guid("91735733-c7ab-4a30-b9a4-a2919083c456"), "672", "2082146961281385", new Guid("91735733-c7ab-4a30-b9a4-a2919083c456"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7"), "07/08" },
                    { new Guid("917e4e12-eca3-4b6b-a98b-402aa1c98d26"), "454", "5479983937380169", new Guid("917e4e12-eca3-4b6b-a98b-402aa1c98d26"), new Guid("0b15ae39-ea71-49c5-a132-1475793930aa"), "08/11" },
                    { new Guid("918b8e0c-d592-4488-b813-2aaf0ff18c74"), "300", "3928209735159698", new Guid("918b8e0c-d592-4488-b813-2aaf0ff18c74"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854"), "11/03" },
                    { new Guid("918e3ce3-89e4-4e62-8a3b-75b472b77ec6"), "106", "8155931356152551", new Guid("918e3ce3-89e4-4e62-8a3b-75b472b77ec6"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "12/20" },
                    { new Guid("931fd728-ffed-4be4-8254-4d27d37f218a"), "823", "5080756563342845", new Guid("931fd728-ffed-4be4-8254-4d27d37f218a"), new Guid("810775de-7e6f-4620-99bb-c534d912de67"), "03/28" },
                    { new Guid("932dc584-9772-44ef-be3e-04775c064063"), "594", "7024198632344667", new Guid("932dc584-9772-44ef-be3e-04775c064063"), new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037"), "06/28" },
                    { new Guid("93506d9f-d09a-4644-892c-289814f5aa42"), "022", "8893008171121798", new Guid("93506d9f-d09a-4644-892c-289814f5aa42"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98"), "03/02" },
                    { new Guid("93995e4b-06d4-42e0-a74f-fa98576a6af2"), "680", "6158536801974591", new Guid("93995e4b-06d4-42e0-a74f-fa98576a6af2"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410"), "07/04" },
                    { new Guid("93d5aa28-15bd-4f84-b564-41bc8b60d3ac"), "549", "7727983658313448", new Guid("93d5aa28-15bd-4f84-b564-41bc8b60d3ac"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555"), "06/11" },
                    { new Guid("94582d93-27ba-40df-9fe9-2ed3596cb7fc"), "590", "1766341901211141", new Guid("94582d93-27ba-40df-9fe9-2ed3596cb7fc"), new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6"), "03/08" },
                    { new Guid("95085226-6ba3-41c1-aac8-d43defd716d3"), "353", "9572472357438154", new Guid("95085226-6ba3-41c1-aac8-d43defd716d3"), new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119"), "03/01" },
                    { new Guid("953c787d-d176-4997-91aa-fd3d1623ea05"), "649", "1509853848406273", new Guid("953c787d-d176-4997-91aa-fd3d1623ea05"), new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa"), "01/28" },
                    { new Guid("959df5d3-1c14-439f-9942-0450ddb35787"), "708", "9160539317021896", new Guid("959df5d3-1c14-439f-9942-0450ddb35787"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747"), "07/09" },
                    { new Guid("967ef037-c9ee-4e84-bc3e-7b6fda1754f4"), "923", "6214827278310732", new Guid("967ef037-c9ee-4e84-bc3e-7b6fda1754f4"), new Guid("18685782-706e-445d-892d-19c39dd67689"), "12/08" },
                    { new Guid("96895eb7-b2b3-416a-b4bf-c269c57b79de"), "899", "3793290972164649", new Guid("96895eb7-b2b3-416a-b4bf-c269c57b79de"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651"), "12/25" },
                    { new Guid("96f555d2-73aa-45c9-bfe7-0a565b4d6927"), "571", "1669626278581487", new Guid("96f555d2-73aa-45c9-bfe7-0a565b4d6927"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af"), "12/06" },
                    { new Guid("98206cfa-253c-4373-88aa-cf3cbdfd52e5"), "023", "2285592446390127", new Guid("98206cfa-253c-4373-88aa-cf3cbdfd52e5"), new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c"), "12/16" },
                    { new Guid("989b7662-c953-450e-8527-cfb7a253f555"), "642", "8637704052565201", new Guid("989b7662-c953-450e-8527-cfb7a253f555"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5"), "03/21" },
                    { new Guid("98d04bc7-957f-4293-bc94-7f852963fbbe"), "105", "3836516476639687", new Guid("98d04bc7-957f-4293-bc94-7f852963fbbe"), new Guid("05d888a7-8474-4565-b751-a89df2400346"), "12/17" },
                    { new Guid("98def7f5-1a8b-4828-b723-2393a136a580"), "252", "9097543059738155", new Guid("98def7f5-1a8b-4828-b723-2393a136a580"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a"), "07/03" },
                    { new Guid("98df9f7b-6dcf-429e-8db0-ac084738d409"), "918", "9007522372587407", new Guid("98df9f7b-6dcf-429e-8db0-ac084738d409"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816"), "09/05" },
                    { new Guid("9924f7ad-7616-4f80-947c-7d2ad8cf5223"), "854", "2119525951807757", new Guid("9924f7ad-7616-4f80-947c-7d2ad8cf5223"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95"), "07/09" },
                    { new Guid("993bc110-2dda-4102-a5a9-954cb27f9869"), "637", "1933353126279454", new Guid("993bc110-2dda-4102-a5a9-954cb27f9869"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec"), "01/15" },
                    { new Guid("998b354b-ad3a-4811-967a-9d55463489bc"), "830", "6418121889296202", new Guid("998b354b-ad3a-4811-967a-9d55463489bc"), new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a"), "03/15" },
                    { new Guid("99d5e0cb-9980-4ae0-b61d-df1f0aac32a0"), "635", "9931120618267371", new Guid("99d5e0cb-9980-4ae0-b61d-df1f0aac32a0"), new Guid("ececce7b-505c-4bc7-b969-56ffcc451462"), "01/11" },
                    { new Guid("9ac01a42-60b7-4186-b4be-47979b7bba86"), "974", "3288549181175847", new Guid("9ac01a42-60b7-4186-b4be-47979b7bba86"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b"), "12/19" },
                    { new Guid("9acbc1f4-6d91-4763-9759-b2782246c646"), "736", "9538053420792512", new Guid("9acbc1f4-6d91-4763-9759-b2782246c646"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780"), "11/14" },
                    { new Guid("9b8fb221-6ff9-4061-bd42-67ac0f4e9d7f"), "352", "2856172778939112", new Guid("9b8fb221-6ff9-4061-bd42-67ac0f4e9d7f"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a"), "08/23" },
                    { new Guid("9c10d6b9-e8e6-4053-9556-75b4634e9746"), "127", "2054617894373980", new Guid("9c10d6b9-e8e6-4053-9556-75b4634e9746"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7"), "01/02" },
                    { new Guid("9c649e3e-1526-426b-9cc5-a9370eee2cef"), "977", "5356652567426516", new Guid("9c649e3e-1526-426b-9cc5-a9370eee2cef"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19"), "01/13" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("9d117922-a67c-4381-9aac-e453c5044f11"), "690", "1501321085690506", new Guid("9d117922-a67c-4381-9aac-e453c5044f11"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), "04/19" },
                    { new Guid("9d25cab4-d78d-4743-b2cf-1468ad84f455"), "236", "7899302596717231", new Guid("9d25cab4-d78d-4743-b2cf-1468ad84f455"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea"), "05/08" },
                    { new Guid("9de44acb-20fa-4066-b364-6f5b66208e32"), "847", "5249074938853352", new Guid("9de44acb-20fa-4066-b364-6f5b66208e32"), new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1"), "02/05" },
                    { new Guid("9ee3dd48-cdfb-4fb3-b535-5f910a5c8f7a"), "496", "9283183692507898", new Guid("9ee3dd48-cdfb-4fb3-b535-5f910a5c8f7a"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20"), "02/03" },
                    { new Guid("9f926b0d-ffb8-448b-867b-8d965930ff68"), "272", "4188600571405308", new Guid("9f926b0d-ffb8-448b-867b-8d965930ff68"), new Guid("d21f18d0-79a0-4851-976c-b989e790eac0"), "12/26" },
                    { new Guid("9fa942d6-c4a5-4de5-abf4-aea1ede8d546"), "733", "3353162778533353", new Guid("9fa942d6-c4a5-4de5-abf4-aea1ede8d546"), new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b"), "09/28" },
                    { new Guid("a072453d-c586-4a05-8b79-30aa016dee87"), "644", "1268143680298520", new Guid("a072453d-c586-4a05-8b79-30aa016dee87"), new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884"), "03/25" },
                    { new Guid("a11d441c-1526-49f8-bc51-69208defed78"), "684", "2652474497081045", new Guid("a11d441c-1526-49f8-bc51-69208defed78"), new Guid("d21f18d0-79a0-4851-976c-b989e790eac0"), "03/26" },
                    { new Guid("a17f9754-b91e-420f-9b6e-41b896a602ce"), "425", "2307271468905020", new Guid("a17f9754-b91e-420f-9b6e-41b896a602ce"), new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854"), "08/27" },
                    { new Guid("a1cd4c5e-6d87-4c6d-8478-756db76cbe66"), "905", "9424308453754985", new Guid("a1cd4c5e-6d87-4c6d-8478-756db76cbe66"), new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5"), "12/11" },
                    { new Guid("a1f3164f-b0fd-4c01-8914-b4052f76294d"), "674", "9245159326553580", new Guid("a1f3164f-b0fd-4c01-8914-b4052f76294d"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258"), "01/12" },
                    { new Guid("a22cdbf4-deb6-42cc-9cc0-fb02c0fb9c74"), "449", "5372654157803512", new Guid("a22cdbf4-deb6-42cc-9cc0-fb02c0fb9c74"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), "04/04" },
                    { new Guid("a285f527-4043-4d3a-accb-9b8d714ade37"), "662", "4866409601809990", new Guid("a285f527-4043-4d3a-accb-9b8d714ade37"), new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4"), "11/11" },
                    { new Guid("a2d05535-faea-4e52-b691-06c0f176583c"), "148", "5007339149517424", new Guid("a2d05535-faea-4e52-b691-06c0f176583c"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316"), "11/09" },
                    { new Guid("a2e56b05-6aee-4be5-bf83-b6701b9644b0"), "162", "2051589079085393", new Guid("a2e56b05-6aee-4be5-bf83-b6701b9644b0"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8"), "05/09" },
                    { new Guid("a2ec6a5d-4a8f-4b0e-bff3-597ad00c03a9"), "644", "7617898658784866", new Guid("a2ec6a5d-4a8f-4b0e-bff3-597ad00c03a9"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f"), "01/08" },
                    { new Guid("a31fd0df-d3c9-455c-bfc8-012dea4c6962"), "230", "7488490467228347", new Guid("a31fd0df-d3c9-455c-bfc8-012dea4c6962"), new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a"), "02/11" },
                    { new Guid("a3b8a807-8768-4c7d-bd3e-ec63f9e1b109"), "221", "4142091132557130", new Guid("a3b8a807-8768-4c7d-bd3e-ec63f9e1b109"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978"), "11/19" },
                    { new Guid("a3ca2414-ea52-4590-80f9-09c94cffeaee"), "876", "5493424385817655", new Guid("a3ca2414-ea52-4590-80f9-09c94cffeaee"), new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64"), "02/05" },
                    { new Guid("a3ce6b69-2fc4-4d73-86da-173ea1de94f5"), "428", "1224882786793379", new Guid("a3ce6b69-2fc4-4d73-86da-173ea1de94f5"), new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11"), "09/07" },
                    { new Guid("a407bac0-b6cc-49a1-b4f1-981f40655b66"), "747", "6394039838988790", new Guid("a407bac0-b6cc-49a1-b4f1-981f40655b66"), new Guid("69170f92-b4b7-4c26-be44-5255d738fb20"), "05/19" },
                    { new Guid("a40c7028-7262-4048-adf4-7701cc50579c"), "460", "8107561095934494", new Guid("a40c7028-7262-4048-adf4-7701cc50579c"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), "01/16" },
                    { new Guid("a43e0504-f9e9-4697-a7eb-d0a07fccc47c"), "047", "3155058341030547", new Guid("a43e0504-f9e9-4697-a7eb-d0a07fccc47c"), new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e"), "11/02" },
                    { new Guid("a4a459ef-d664-4be0-993a-383cd052b1d1"), "023", "1235253629108673", new Guid("a4a459ef-d664-4be0-993a-383cd052b1d1"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7"), "05/19" },
                    { new Guid("a53426d4-0f50-473e-91de-b9f82e9fa0fe"), "790", "3801433603747343", new Guid("a53426d4-0f50-473e-91de-b9f82e9fa0fe"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e"), "03/02" },
                    { new Guid("a53f9b72-7846-4bbc-aa98-7ef39af70744"), "305", "9850001326018094", new Guid("a53f9b72-7846-4bbc-aa98-7ef39af70744"), new Guid("735be216-2179-4f32-8f5b-062c31f3a316"), "01/06" },
                    { new Guid("a5a41147-dea6-427e-be27-22ce4560f9de"), "664", "2239203267778259", new Guid("a5a41147-dea6-427e-be27-22ce4560f9de"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833"), "01/14" },
                    { new Guid("a7ed464d-27a3-4ca8-aec2-10999347a1dd"), "479", "7490725513612129", new Guid("a7ed464d-27a3-4ca8-aec2-10999347a1dd"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b"), "07/28" },
                    { new Guid("a831125d-2b54-4749-ab11-307a7cc437dd"), "575", "9592350059923840", new Guid("a831125d-2b54-4749-ab11-307a7cc437dd"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138"), "09/15" },
                    { new Guid("a8707f28-5a3d-4de1-bd39-afcdcdfce662"), "507", "9391714852764961", new Guid("a8707f28-5a3d-4de1-bd39-afcdcdfce662"), new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2"), "02/17" },
                    { new Guid("a8bfe7b6-52ee-4825-a258-483ca7071a71"), "735", "2655186395554097", new Guid("a8bfe7b6-52ee-4825-a258-483ca7071a71"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1"), "10/04" },
                    { new Guid("a8d534ef-efe9-4b46-aeda-ce2b98506149"), "453", "7696990904885428", new Guid("a8d534ef-efe9-4b46-aeda-ce2b98506149"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec"), "02/04" },
                    { new Guid("a966ec8b-c3a0-4ac7-8245-43f9b1af7787"), "255", "6814812038005226", new Guid("a966ec8b-c3a0-4ac7-8245-43f9b1af7787"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec"), "08/21" },
                    { new Guid("a97ff6a4-532c-4908-9a67-8b44d6be8d41"), "156", "5441814125391830", new Guid("a97ff6a4-532c-4908-9a67-8b44d6be8d41"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc"), "08/26" },
                    { new Guid("a98d2d14-1f2d-4fd9-a9b9-fbb717c0d395"), "236", "3232279746800694", new Guid("a98d2d14-1f2d-4fd9-a9b9-fbb717c0d395"), new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0"), "01/16" },
                    { new Guid("a9f3de3e-aa78-49f9-bec6-30d0ef8c7b98"), "504", "5711039690435027", new Guid("a9f3de3e-aa78-49f9-bec6-30d0ef8c7b98"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042"), "12/23" },
                    { new Guid("aa0da442-886e-468d-9601-557c54ed6346"), "415", "5772666814416155", new Guid("aa0da442-886e-468d-9601-557c54ed6346"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4"), "02/21" },
                    { new Guid("aaba7ad9-b6f0-41bc-94ef-e13e1f0bebf0"), "923", "6944479687211909", new Guid("aaba7ad9-b6f0-41bc-94ef-e13e1f0bebf0"), new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61"), "08/08" },
                    { new Guid("aace9aa6-7e20-49bc-927b-4d0232505261"), "150", "8746645603612891", new Guid("aace9aa6-7e20-49bc-927b-4d0232505261"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa"), "06/21" },
                    { new Guid("aad29264-6e0d-4703-887f-b0cf0308468e"), "174", "1956657080256093", new Guid("aad29264-6e0d-4703-887f-b0cf0308468e"), new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b"), "12/25" },
                    { new Guid("ab05f898-d3a0-4164-910a-5f6397caad8a"), "087", "3392030288292869", new Guid("ab05f898-d3a0-4164-910a-5f6397caad8a"), new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738"), "07/06" },
                    { new Guid("ab20b53f-088f-402c-846c-7e606a0ded14"), "805", "1041840481003696", new Guid("ab20b53f-088f-402c-846c-7e606a0ded14"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655"), "02/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("ab513989-2392-4034-9b74-117eb6cd736a"), "906", "4000694309180869", new Guid("ab513989-2392-4034-9b74-117eb6cd736a"), new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4"), "02/01" },
                    { new Guid("abf059ca-6c13-430d-994f-2b51ec77ce06"), "437", "9648858717136440", new Guid("abf059ca-6c13-430d-994f-2b51ec77ce06"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9"), "11/11" },
                    { new Guid("ac07ffc1-f63b-4a5a-8ce8-3b5d4832366d"), "848", "3488056025728825", new Guid("ac07ffc1-f63b-4a5a-8ce8-3b5d4832366d"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555"), "10/05" },
                    { new Guid("acd47466-3ca8-40fa-b5c6-2fa93f0e749f"), "952", "9962420127434680", new Guid("acd47466-3ca8-40fa-b5c6-2fa93f0e749f"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98"), "02/11" },
                    { new Guid("ad548aae-e7cf-4e37-b649-20c235f94c0b"), "469", "2852357210868397", new Guid("ad548aae-e7cf-4e37-b649-20c235f94c0b"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6"), "07/19" },
                    { new Guid("ad9f4569-44dd-4c0f-b0f4-9862675e9b58"), "349", "5613212091451223", new Guid("ad9f4569-44dd-4c0f-b0f4-9862675e9b58"), new Guid("3793c254-cd3f-4c42-93fb-0895042668c7"), "09/28" },
                    { new Guid("ae1ca528-d663-412e-9500-2dbf26464175"), "677", "5766076863491030", new Guid("ae1ca528-d663-412e-9500-2dbf26464175"), new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b"), "05/09" },
                    { new Guid("ae373d5e-7cec-41c7-9fed-b1618facb69c"), "070", "3289140208930478", new Guid("ae373d5e-7cec-41c7-9fed-b1618facb69c"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34"), "12/19" },
                    { new Guid("ae81f4d1-0807-4f46-a6a0-23ec55cb5cde"), "582", "6584162184590688", new Guid("ae81f4d1-0807-4f46-a6a0-23ec55cb5cde"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a"), "09/11" },
                    { new Guid("ae84cfa6-d364-4a59-9d92-4a2efac7594d"), "535", "7628138615169753", new Guid("ae84cfa6-d364-4a59-9d92-4a2efac7594d"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c"), "12/28" },
                    { new Guid("aea36417-0ee2-4e3a-8ea1-d1b7f6a07b8c"), "087", "8696913528076775", new Guid("aea36417-0ee2-4e3a-8ea1-d1b7f6a07b8c"), new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f"), "06/02" },
                    { new Guid("af77f502-1a4f-44c4-aeb0-e384a5af29d7"), "216", "9733907621465070", new Guid("af77f502-1a4f-44c4-aeb0-e384a5af29d7"), new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd"), "04/20" },
                    { new Guid("afd07c08-77dc-44be-a6c2-add5771d7d71"), "357", "7939555768663393", new Guid("afd07c08-77dc-44be-a6c2-add5771d7d71"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de"), "11/20" },
                    { new Guid("b044be01-2f6f-4f9f-ad59-89ec5eaac0db"), "825", "3504146688186143", new Guid("b044be01-2f6f-4f9f-ad59-89ec5eaac0db"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c"), "09/11" },
                    { new Guid("b06ac924-4a32-49a0-ba3f-a89ad592342f"), "758", "7471648682437298", new Guid("b06ac924-4a32-49a0-ba3f-a89ad592342f"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98"), "04/03" },
                    { new Guid("b097a99c-01f5-4611-aaf2-589094f719fb"), "099", "1603254793805252", new Guid("b097a99c-01f5-4611-aaf2-589094f719fb"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132"), "04/05" },
                    { new Guid("b0fe7b3c-79f1-42f9-a895-482223a2f0d7"), "090", "9847183386152330", new Guid("b0fe7b3c-79f1-42f9-a895-482223a2f0d7"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8"), "12/18" },
                    { new Guid("b119884d-5f62-414f-860c-b7aecd49e9c7"), "388", "8960090722098902", new Guid("b119884d-5f62-414f-860c-b7aecd49e9c7"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511"), "08/09" },
                    { new Guid("b1bca2bc-63c9-458c-873b-90da755ce17b"), "798", "6817716863268335", new Guid("b1bca2bc-63c9-458c-873b-90da755ce17b"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec"), "11/14" },
                    { new Guid("b1cf505a-1810-4b08-9a8a-4d51f9d85a99"), "723", "7687652301781917", new Guid("b1cf505a-1810-4b08-9a8a-4d51f9d85a99"), new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c"), "03/17" },
                    { new Guid("b2096fdf-19ed-482f-bd0f-6fb98acc5b08"), "567", "8714833683847869", new Guid("b2096fdf-19ed-482f-bd0f-6fb98acc5b08"), new Guid("cfddcc04-5205-447d-9799-6d1945c391b4"), "07/11" },
                    { new Guid("b2df7bd7-9852-4e2a-bb9a-64675fc48ec8"), "700", "8221261732331746", new Guid("b2df7bd7-9852-4e2a-bb9a-64675fc48ec8"), new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272"), "08/09" },
                    { new Guid("b3c3817f-d3b2-4075-9e02-ddb22c5aaaec"), "885", "4153662174409844", new Guid("b3c3817f-d3b2-4075-9e02-ddb22c5aaaec"), new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072"), "10/09" },
                    { new Guid("b403b455-1325-4f74-b2df-eea52a794da9"), "019", "8648387725824505", new Guid("b403b455-1325-4f74-b2df-eea52a794da9"), new Guid("28f12604-451b-425e-ae23-1db801053b3e"), "01/16" },
                    { new Guid("b4997dc1-0434-42f3-8b29-8ba7792f86c2"), "144", "5733056965561884", new Guid("b4997dc1-0434-42f3-8b29-8ba7792f86c2"), new Guid("48949002-3dd7-424b-b508-bb6644cad6fb"), "09/21" },
                    { new Guid("b4c198c9-a7c0-45dc-ac09-ede000dbd74f"), "313", "9971858552165315", new Guid("b4c198c9-a7c0-45dc-ac09-ede000dbd74f"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), "08/11" },
                    { new Guid("b54ef2c5-b7be-4abe-aeb8-348ea16cb247"), "947", "2228087607984412", new Guid("b54ef2c5-b7be-4abe-aeb8-348ea16cb247"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913"), "05/07" },
                    { new Guid("b5525a79-782f-4c59-a759-91a2b24657c3"), "843", "7866427269339784", new Guid("b5525a79-782f-4c59-a759-91a2b24657c3"), new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19"), "11/15" },
                    { new Guid("b5bb4313-fd82-43ee-9c6f-d626e1c1983c"), "366", "1967087631939537", new Guid("b5bb4313-fd82-43ee-9c6f-d626e1c1983c"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a"), "06/22" },
                    { new Guid("b5ed9f38-f33b-410e-baeb-c547432a6bd8"), "605", "9132603815228927", new Guid("b5ed9f38-f33b-410e-baeb-c547432a6bd8"), new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b"), "06/25" },
                    { new Guid("b62408a7-2a3d-4261-9b9e-0e25b14028c3"), "693", "4214800512428093", new Guid("b62408a7-2a3d-4261-9b9e-0e25b14028c3"), new Guid("9349fc86-09c0-446e-8036-e69d441a3822"), "04/21" },
                    { new Guid("b659bf24-768c-4d99-b811-4707f5fa2ce3"), "420", "2604839409060363", new Guid("b659bf24-768c-4d99-b811-4707f5fa2ce3"), new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73"), "10/04" },
                    { new Guid("b6eeeea0-4faa-4023-b11c-528d8542f90f"), "404", "8031633250552521", new Guid("b6eeeea0-4faa-4023-b11c-528d8542f90f"), new Guid("ececce7b-505c-4bc7-b969-56ffcc451462"), "03/11" },
                    { new Guid("b7323d6a-eb25-4d6a-b9b1-52d95807659a"), "268", "5967402180068622", new Guid("b7323d6a-eb25-4d6a-b9b1-52d95807659a"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), "01/23" },
                    { new Guid("b7a38b13-418c-45c4-bdd2-797256912c6e"), "388", "4583635431604062", new Guid("b7a38b13-418c-45c4-bdd2-797256912c6e"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5"), "07/19" },
                    { new Guid("b7b04a82-06a7-4ce6-80ed-00e39dfb5f94"), "289", "2758861131952871", new Guid("b7b04a82-06a7-4ce6-80ed-00e39dfb5f94"), new Guid("54544805-6149-40a0-a366-c2fb8f55975f"), "08/14" },
                    { new Guid("b7e02bef-2b72-416e-9cc6-1054fcd0c8d3"), "197", "3602033363322246", new Guid("b7e02bef-2b72-416e-9cc6-1054fcd0c8d3"), new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac"), "10/01" },
                    { new Guid("b7f541f3-dcdb-411d-a907-3c748b0768fc"), "129", "9623316255025881", new Guid("b7f541f3-dcdb-411d-a907-3c748b0768fc"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba"), "08/27" },
                    { new Guid("b84cc34b-e420-4a42-a66a-4396d3cb6d5d"), "415", "5122449194280775", new Guid("b84cc34b-e420-4a42-a66a-4396d3cb6d5d"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511"), "04/01" },
                    { new Guid("b86e7db5-f39a-40bc-8bf7-32563056ea8f"), "727", "9437620128755727", new Guid("b86e7db5-f39a-40bc-8bf7-32563056ea8f"), new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b"), "03/24" },
                    { new Guid("b873d500-14b2-42d2-bcfa-413430f52383"), "536", "9656898041693222", new Guid("b873d500-14b2-42d2-bcfa-413430f52383"), new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779"), "08/26" },
                    { new Guid("b8e20f47-e2ba-4f64-92cc-7bbe7bbcf0ec"), "153", "9734267319529337", new Guid("b8e20f47-e2ba-4f64-92cc-7bbe7bbcf0ec"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98"), "07/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("b900b22f-8f15-4c9f-b7f8-dc85386e618f"), "601", "2532296129167583", new Guid("b900b22f-8f15-4c9f-b7f8-dc85386e618f"), new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46"), "12/16" },
                    { new Guid("b98c270f-8524-4945-a949-87a7bc00e8ed"), "912", "8949891911793155", new Guid("b98c270f-8524-4945-a949-87a7bc00e8ed"), new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48"), "06/26" },
                    { new Guid("b9f66e44-a076-4282-a1a3-5c88795f4904"), "619", "5617932523250755", new Guid("b9f66e44-a076-4282-a1a3-5c88795f4904"), new Guid("0511de28-2afb-4492-a1a6-ca490859b247"), "10/21" },
                    { new Guid("bb10bb8b-1f9b-46e4-a0f8-eca94176029b"), "809", "6527321683350442", new Guid("bb10bb8b-1f9b-46e4-a0f8-eca94176029b"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "08/16" },
                    { new Guid("bb48d651-7bba-4f52-99f2-337e2e46aa79"), "950", "5784906916425990", new Guid("bb48d651-7bba-4f52-99f2-337e2e46aa79"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc"), "09/07" },
                    { new Guid("bb66c34a-be80-49ea-bf71-acfbd4d823f4"), "591", "3937465161548659", new Guid("bb66c34a-be80-49ea-bf71-acfbd4d823f4"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b"), "08/01" },
                    { new Guid("bc29cbc7-dcb3-4618-9b8d-bf574196fd80"), "552", "1640298076969939", new Guid("bc29cbc7-dcb3-4618-9b8d-bf574196fd80"), new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76"), "06/09" },
                    { new Guid("bc59587a-674d-422b-a1e0-c5e33a84e024"), "073", "9933436299967318", new Guid("bc59587a-674d-422b-a1e0-c5e33a84e024"), new Guid("a11d6609-e768-4189-bd78-5b34d82849e6"), "05/28" },
                    { new Guid("bc702899-02f5-4cbb-a702-c25d479ce123"), "196", "2808644830085403", new Guid("bc702899-02f5-4cbb-a702-c25d479ce123"), new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88"), "09/21" },
                    { new Guid("bd0b192f-f7c5-4667-8ee9-4fbc5294e8d4"), "005", "2032661361969324", new Guid("bd0b192f-f7c5-4667-8ee9-4fbc5294e8d4"), new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a"), "08/08" },
                    { new Guid("bd0d872b-24e0-425d-baf5-6f2b3117715e"), "373", "8865457283225913", new Guid("bd0d872b-24e0-425d-baf5-6f2b3117715e"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d"), "10/13" },
                    { new Guid("bd14a80b-2351-4c11-b18c-7eea2ff0f609"), "153", "7326667001194812", new Guid("bd14a80b-2351-4c11-b18c-7eea2ff0f609"), new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913"), "02/24" },
                    { new Guid("bd43d829-e07e-405c-aedf-37c07684e227"), "732", "7822484051414324", new Guid("bd43d829-e07e-405c-aedf-37c07684e227"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747"), "04/12" },
                    { new Guid("bd8e9b5f-685c-413d-bc71-d02272d6a716"), "781", "2803623271030546", new Guid("bd8e9b5f-685c-413d-bc71-d02272d6a716"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747"), "06/06" },
                    { new Guid("bdd6e87b-ab9e-4ac1-93c3-dfc486a6c7e1"), "692", "4196929631114791", new Guid("bdd6e87b-ab9e-4ac1-93c3-dfc486a6c7e1"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997"), "08/14" },
                    { new Guid("bddfe5bc-8f20-415a-bf51-f3f28c0f7819"), "118", "2928705469547565", new Guid("bddfe5bc-8f20-415a-bf51-f3f28c0f7819"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a"), "11/24" },
                    { new Guid("be5d31d9-35d8-4a25-b2a6-f6551d5b24be"), "900", "7149186055035691", new Guid("be5d31d9-35d8-4a25-b2a6-f6551d5b24be"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957"), "11/13" },
                    { new Guid("beb983e5-2e39-4c4c-9298-93b9c9b7a576"), "873", "2724674586574219", new Guid("beb983e5-2e39-4c4c-9298-93b9c9b7a576"), new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718"), "07/17" },
                    { new Guid("bf5d4083-8613-45e6-9048-bae8ad712ac0"), "212", "3201401671054797", new Guid("bf5d4083-8613-45e6-9048-bae8ad712ac0"), new Guid("810775de-7e6f-4620-99bb-c534d912de67"), "04/04" },
                    { new Guid("bf8aec91-0db8-4767-84cd-b762d11caff6"), "429", "5794173811981236", new Guid("bf8aec91-0db8-4767-84cd-b762d11caff6"), new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651"), "07/18" },
                    { new Guid("bfd51a22-d380-4b4f-9ae9-51314755ee6d"), "901", "2489314655940810", new Guid("bfd51a22-d380-4b4f-9ae9-51314755ee6d"), new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899"), "09/27" },
                    { new Guid("c00f9297-e737-4caa-91c6-9e1d346069c6"), "243", "4915449949369846", new Guid("c00f9297-e737-4caa-91c6-9e1d346069c6"), new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47"), "07/12" },
                    { new Guid("c04d2ce3-1182-4a56-961b-a0f8ef075edd"), "821", "3698071524690883", new Guid("c04d2ce3-1182-4a56-961b-a0f8ef075edd"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8"), "08/13" },
                    { new Guid("c14e69fd-276e-4ac1-b3ff-b3338081a5dd"), "323", "6059551045623847", new Guid("c14e69fd-276e-4ac1-b3ff-b3338081a5dd"), new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af"), "06/08" },
                    { new Guid("c16aa0ea-3be6-48c2-b912-9c30f687a67f"), "351", "8868034406014967", new Guid("c16aa0ea-3be6-48c2-b912-9c30f687a67f"), new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab"), "10/02" },
                    { new Guid("c19bdcf8-7717-4580-a29b-a316bb0def13"), "983", "4071118447905391", new Guid("c19bdcf8-7717-4580-a29b-a316bb0def13"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3"), "07/27" },
                    { new Guid("c2a0c27b-9370-4549-b9b0-51a9e4c0c95d"), "958", "8314348716365691", new Guid("c2a0c27b-9370-4549-b9b0-51a9e4c0c95d"), new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555"), "06/02" },
                    { new Guid("c2a124ee-267c-4cdb-9955-53d4dc0685c4"), "323", "9660594760241735", new Guid("c2a124ee-267c-4cdb-9955-53d4dc0685c4"), new Guid("12656ae7-3922-41ca-b159-f79b439a354c"), "06/12" },
                    { new Guid("c32540a6-80d5-43a9-982a-0485346a4b02"), "769", "2226623268121320", new Guid("c32540a6-80d5-43a9-982a-0485346a4b02"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), "02/11" },
                    { new Guid("c351b60a-37d6-4b79-899f-ead811311648"), "537", "2540218212469340", new Guid("c351b60a-37d6-4b79-899f-ead811311648"), new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723"), "05/23" },
                    { new Guid("c3a72b81-cc97-4c2a-a501-dc6dd6433702"), "675", "8645435051157530", new Guid("c3a72b81-cc97-4c2a-a501-dc6dd6433702"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a"), "02/15" },
                    { new Guid("c3df0fc0-328a-46d9-b103-94460575c43f"), "302", "4586137100123477", new Guid("c3df0fc0-328a-46d9-b103-94460575c43f"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c"), "12/05" },
                    { new Guid("c4233e3e-c096-4c04-be0c-49d3ec03b1ea"), "827", "6892230700671280", new Guid("c4233e3e-c096-4c04-be0c-49d3ec03b1ea"), new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305"), "10/21" },
                    { new Guid("c44c23aa-0953-4bbf-a8f2-dc31c6d3dd79"), "418", "7358559163232823", new Guid("c44c23aa-0953-4bbf-a8f2-dc31c6d3dd79"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124"), "12/23" },
                    { new Guid("c49266e4-f68f-42f6-a9ba-ee714fd0e2c3"), "546", "9687508297380376", new Guid("c49266e4-f68f-42f6-a9ba-ee714fd0e2c3"), new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867"), "05/01" },
                    { new Guid("c4968d51-0276-4fe8-9b33-1c1f50d28cea"), "149", "7559688685288286", new Guid("c4968d51-0276-4fe8-9b33-1c1f50d28cea"), new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11"), "09/06" },
                    { new Guid("c4994a67-e148-40a0-8ce1-deda347d5c2c"), "580", "8383406686110838", new Guid("c4994a67-e148-40a0-8ce1-deda347d5c2c"), new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4"), "12/01" },
                    { new Guid("c5539b80-6d7c-421f-9c67-ddfa74dd2e60"), "324", "8761199847201696", new Guid("c5539b80-6d7c-421f-9c67-ddfa74dd2e60"), new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd"), "10/05" },
                    { new Guid("c5ad2f85-451b-470b-8843-194ff77c2eff"), "205", "2239675367173498", new Guid("c5ad2f85-451b-470b-8843-194ff77c2eff"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162"), "03/02" },
                    { new Guid("c5b2d2a6-5b56-4ced-9ebb-c85bbc506e76"), "009", "4317225452585779", new Guid("c5b2d2a6-5b56-4ced-9ebb-c85bbc506e76"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20"), "01/17" },
                    { new Guid("c6316be4-66d4-4161-9877-64c43f1d8aa7"), "794", "6531017539590969", new Guid("c6316be4-66d4-4161-9877-64c43f1d8aa7"), new Guid("83c8f958-a3f1-448d-bad0-048533827e0e"), "06/21" },
                    { new Guid("c655fbed-a579-4f5c-bab8-4a53084f1d61"), "705", "2005128895432261", new Guid("c655fbed-a579-4f5c-bab8-4a53084f1d61"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3"), "05/28" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c6563db9-19e2-4e04-b604-9a99a37c3509"), "674", "5747938711583119", new Guid("c6563db9-19e2-4e04-b604-9a99a37c3509"), new Guid("5558c531-153b-4da7-9848-996b07daa782"), "02/04" },
                    { new Guid("c6aebc10-1585-4a20-84e7-879a592c082d"), "478", "2604249712193240", new Guid("c6aebc10-1585-4a20-84e7-879a592c082d"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "05/21" },
                    { new Guid("c6c248d8-551d-4374-85f8-47f5cc93e947"), "866", "9695861395801917", new Guid("c6c248d8-551d-4374-85f8-47f5cc93e947"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88"), "12/11" },
                    { new Guid("c6d47736-3be2-41b6-af06-15a92ecfec6c"), "829", "9045836605922499", new Guid("c6d47736-3be2-41b6-af06-15a92ecfec6c"), new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9"), "01/26" },
                    { new Guid("c7790bd4-95ca-4ab0-b4c2-6798cdb00d82"), "851", "8274018725580564", new Guid("c7790bd4-95ca-4ab0-b4c2-6798cdb00d82"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26"), "02/15" },
                    { new Guid("c7aa9082-2b7a-49e6-b8b2-74b70287a3ae"), "422", "3708454282441022", new Guid("c7aa9082-2b7a-49e6-b8b2-74b70287a3ae"), new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899"), "09/02" },
                    { new Guid("c7e6d772-fc94-434a-bed1-56a35146a020"), "853", "9120456724646022", new Guid("c7e6d772-fc94-434a-bed1-56a35146a020"), new Guid("f7e86b66-49eb-4774-82be-b008350dc98b"), "09/01" },
                    { new Guid("c7fe8b28-f1cc-42a6-8c23-2ae9410eac10"), "350", "8056786322781052", new Guid("c7fe8b28-f1cc-42a6-8c23-2ae9410eac10"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0"), "02/14" },
                    { new Guid("c809d7dd-6387-40bf-b668-7378e23c9b73"), "271", "3379430797065851", new Guid("c809d7dd-6387-40bf-b668-7378e23c9b73"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98"), "04/27" },
                    { new Guid("c815ce39-89c6-4e9c-85b3-ffcb93811812"), "280", "6060466743420233", new Guid("c815ce39-89c6-4e9c-85b3-ffcb93811812"), new Guid("71725c06-aded-4994-8181-26d1683597c4"), "09/09" },
                    { new Guid("c88eb82e-3c13-454c-a6c2-ec8e85e28475"), "985", "3158335656939948", new Guid("c88eb82e-3c13-454c-a6c2-ec8e85e28475"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0"), "08/20" },
                    { new Guid("c926d90e-21f2-45e6-882c-9931ed8666b5"), "904", "4827090508458777", new Guid("c926d90e-21f2-45e6-882c-9931ed8666b5"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997"), "07/15" },
                    { new Guid("ca584476-c48c-43a5-b203-0c6ec888037c"), "158", "1509271466349674", new Guid("ca584476-c48c-43a5-b203-0c6ec888037c"), new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221"), "03/14" },
                    { new Guid("cac9c983-3198-418c-b089-b7c0aac9f6a5"), "545", "3840047788499343", new Guid("cac9c983-3198-418c-b089-b7c0aac9f6a5"), new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a"), "12/04" },
                    { new Guid("cacbec81-8861-4879-943a-e4c18fe37871"), "658", "1124983054280154", new Guid("cacbec81-8861-4879-943a-e4c18fe37871"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6"), "03/14" },
                    { new Guid("cb890178-af48-4fb6-929f-933552978b7c"), "105", "3383838777464802", new Guid("cb890178-af48-4fb6-929f-933552978b7c"), new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96"), "09/16" },
                    { new Guid("cc5514c9-aac1-4aea-88be-de00f17a8791"), "410", "8186236865149877", new Guid("cc5514c9-aac1-4aea-88be-de00f17a8791"), new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22"), "11/28" },
                    { new Guid("cd123e21-0be1-4874-897d-90e5824a2ccf"), "068", "3325000604525640", new Guid("cd123e21-0be1-4874-897d-90e5824a2ccf"), new Guid("5558c531-153b-4da7-9848-996b07daa782"), "08/18" },
                    { new Guid("cd295e4f-36d5-4654-a21a-54e48c6cd48e"), "411", "1683767857704726", new Guid("cd295e4f-36d5-4654-a21a-54e48c6cd48e"), new Guid("e5873863-5f02-49f2-b6e6-faae1acea124"), "10/17" },
                    { new Guid("cd4f25b0-da67-4a63-b587-8b126b4f6d91"), "481", "5991769618166000", new Guid("cd4f25b0-da67-4a63-b587-8b126b4f6d91"), new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977"), "03/28" },
                    { new Guid("cd7aaad5-c428-4af9-8127-7ee8a5dff046"), "325", "9144509241446823", new Guid("cd7aaad5-c428-4af9-8127-7ee8a5dff046"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330"), "07/26" },
                    { new Guid("cdbfd647-da6f-42af-9a4e-303045ba4f7a"), "361", "7199511312372030", new Guid("cdbfd647-da6f-42af-9a4e-303045ba4f7a"), new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95"), "11/19" },
                    { new Guid("cdeef2f6-9d1f-4d1c-b4b2-7ab23365e59d"), "130", "8237586238519011", new Guid("cdeef2f6-9d1f-4d1c-b4b2-7ab23365e59d"), new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc"), "06/21" },
                    { new Guid("ce3b62eb-407b-4bb7-99cd-d8e7f6363f24"), "059", "5139047306172410", new Guid("ce3b62eb-407b-4bb7-99cd-d8e7f6363f24"), new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6"), "01/20" },
                    { new Guid("ce636225-6c58-4558-81da-17706d966c73"), "427", "2286967763858948", new Guid("ce636225-6c58-4558-81da-17706d966c73"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa"), "02/23" },
                    { new Guid("ceb01a84-1bda-4c88-85f2-a1697e0822c0"), "707", "2563281273142619", new Guid("ceb01a84-1bda-4c88-85f2-a1697e0822c0"), new Guid("f825bff2-881f-450b-a4b7-56931951c54c"), "08/15" },
                    { new Guid("cef0ac2b-5fb1-4f00-b4bb-c0c35addf81e"), "211", "1241083538286275", new Guid("cef0ac2b-5fb1-4f00-b4bb-c0c35addf81e"), new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978"), "02/25" },
                    { new Guid("cf023b25-eab6-4d03-8dfc-afebb8dd5c5d"), "382", "5601443473259127", new Guid("cf023b25-eab6-4d03-8dfc-afebb8dd5c5d"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e"), "09/27" },
                    { new Guid("cf55b5f1-28a5-45ce-a8f7-98846c3efbca"), "627", "3602967196513387", new Guid("cf55b5f1-28a5-45ce-a8f7-98846c3efbca"), new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075"), "07/26" },
                    { new Guid("cf663444-9f33-4e86-8a75-69fe409cef99"), "666", "7926316573651884", new Guid("cf663444-9f33-4e86-8a75-69fe409cef99"), new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8"), "11/14" },
                    { new Guid("cf8d5c79-fc9b-4977-b606-02779519c197"), "845", "5095254556509854", new Guid("cf8d5c79-fc9b-4977-b606-02779519c197"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316"), "09/07" },
                    { new Guid("d0d6a2d1-1002-43d5-8c03-a08d54d66492"), "214", "8130733231254070", new Guid("d0d6a2d1-1002-43d5-8c03-a08d54d66492"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba"), "12/15" },
                    { new Guid("d0da4ad5-4eac-468d-ae0c-2194c09e8384"), "741", "7665615104915337", new Guid("d0da4ad5-4eac-468d-ae0c-2194c09e8384"), new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac"), "10/03" },
                    { new Guid("d1110ddc-e280-4f2a-8c91-695ba89f6069"), "847", "5238678891671603", new Guid("d1110ddc-e280-4f2a-8c91-695ba89f6069"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e"), "11/28" },
                    { new Guid("d1363956-2f0d-40a5-8ec2-5235bb648503"), "325", "7709639460010340", new Guid("d1363956-2f0d-40a5-8ec2-5235bb648503"), new Guid("18685782-706e-445d-892d-19c39dd67689"), "02/01" },
                    { new Guid("d1809ee5-7c37-49ad-b5ef-fd9e63a08145"), "381", "6699722959763150", new Guid("d1809ee5-7c37-49ad-b5ef-fd9e63a08145"), new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df"), "07/12" },
                    { new Guid("d2329259-8a8a-4ff1-848f-41ae5bb69082"), "053", "7852295909505232", new Guid("d2329259-8a8a-4ff1-848f-41ae5bb69082"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3"), "10/19" },
                    { new Guid("d2e1d5fa-1b85-4344-95c2-01153af4abac"), "921", "7215620217954147", new Guid("d2e1d5fa-1b85-4344-95c2-01153af4abac"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a"), "08/12" },
                    { new Guid("d30fac16-832e-4259-ab54-2da3574657f2"), "286", "7398819286020046", new Guid("d30fac16-832e-4259-ab54-2da3574657f2"), new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7"), "09/26" },
                    { new Guid("d3713360-67e1-4f8b-9a4a-a55ebe8c7742"), "676", "4928595651062216", new Guid("d3713360-67e1-4f8b-9a4a-a55ebe8c7742"), new Guid("18685782-706e-445d-892d-19c39dd67689"), "04/11" },
                    { new Guid("d3d5baa9-91f7-4fa4-97d2-a6d21490fade"), "019", "4842834531062138", new Guid("d3d5baa9-91f7-4fa4-97d2-a6d21490fade"), new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342"), "03/26" },
                    { new Guid("d3f139eb-701b-40f7-9260-3e51dfbcc155"), "392", "8194885723050333", new Guid("d3f139eb-701b-40f7-9260-3e51dfbcc155"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9"), "01/08" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d4913c7a-16ac-4407-b06f-6d48692b500f"), "179", "3567507260990078", new Guid("d4913c7a-16ac-4407-b06f-6d48692b500f"), new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20"), "05/28" },
                    { new Guid("d49f62d3-a8d7-4f77-be49-6ff4c44cb1b5"), "483", "7169453177279326", new Guid("d49f62d3-a8d7-4f77-be49-6ff4c44cb1b5"), new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473"), "04/25" },
                    { new Guid("d4a57954-6894-4f1a-a82d-351e9fbe7195"), "527", "6178276571073126", new Guid("d4a57954-6894-4f1a-a82d-351e9fbe7195"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21"), "08/04" },
                    { new Guid("d4b36f85-c5d3-4e4d-9fbb-92f8b4f229e3"), "709", "2266988290403909", new Guid("d4b36f85-c5d3-4e4d-9fbb-92f8b4f229e3"), new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8"), "04/15" },
                    { new Guid("d4c03244-cca3-4cd1-af4c-b018a56b66bd"), "279", "8028242869016414", new Guid("d4c03244-cca3-4cd1-af4c-b018a56b66bd"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0"), "12/08" },
                    { new Guid("d4ce5761-01a4-4a1c-941c-3d3d642c29b2"), "058", "8456212520603926", new Guid("d4ce5761-01a4-4a1c-941c-3d3d642c29b2"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258"), "08/05" },
                    { new Guid("d4f8d4d7-0a5a-49eb-8b8e-761b6ed16699"), "705", "4121348553387546", new Guid("d4f8d4d7-0a5a-49eb-8b8e-761b6ed16699"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8"), "09/19" },
                    { new Guid("d553416e-f0bc-47a7-9d2a-5ced19f9d48f"), "967", "8450073345576015", new Guid("d553416e-f0bc-47a7-9d2a-5ced19f9d48f"), new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869"), "11/23" },
                    { new Guid("d5b69a3a-f770-4893-8d4a-96bec8d7c629"), "648", "3129452104689545", new Guid("d5b69a3a-f770-4893-8d4a-96bec8d7c629"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0"), "07/09" },
                    { new Guid("d5ede1f4-a1ae-48ec-aaa0-e182d434b8d6"), "256", "1632583063717342", new Guid("d5ede1f4-a1ae-48ec-aaa0-e182d434b8d6"), new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d"), "08/25" },
                    { new Guid("d70b5af9-ce42-4747-9d0f-7e5aa1cf811f"), "010", "8361059693370293", new Guid("d70b5af9-ce42-4747-9d0f-7e5aa1cf811f"), new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98"), "11/11" },
                    { new Guid("d7542dfa-42d2-4311-9628-20d9d32c1e5c"), "982", "9942705719651854", new Guid("d7542dfa-42d2-4311-9628-20d9d32c1e5c"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21"), "06/24" },
                    { new Guid("d7661f6e-3d97-4cf3-8932-8d499f16bc4b"), "639", "5847133086051638", new Guid("d7661f6e-3d97-4cf3-8932-8d499f16bc4b"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816"), "02/14" },
                    { new Guid("d79af1a8-0c76-4756-8624-e51f0a535584"), "555", "8820901338492114", new Guid("d79af1a8-0c76-4756-8624-e51f0a535584"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e"), "11/05" },
                    { new Guid("d801fad0-8393-4ee2-899b-71d610201654"), "169", "9983448985871812", new Guid("d801fad0-8393-4ee2-899b-71d610201654"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186"), "12/13" },
                    { new Guid("d8c65364-0211-42c0-b305-84d09c901976"), "605", "5565516474847865", new Guid("d8c65364-0211-42c0-b305-84d09c901976"), new Guid("e2125995-cb39-40eb-b23a-1483130a7d40"), "12/07" },
                    { new Guid("d9a2ec0f-9ad4-4957-a926-5a10c9a9641f"), "459", "6086137364735130", new Guid("d9a2ec0f-9ad4-4957-a926-5a10c9a9641f"), new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa"), "02/11" },
                    { new Guid("da78edf0-10f9-4414-be10-93ef1ab90095"), "937", "7844361731272644", new Guid("da78edf0-10f9-4414-be10-93ef1ab90095"), new Guid("0462fe55-138a-4c03-a20d-8251dee6c206"), "07/15" },
                    { new Guid("daa4e6cd-ddad-46b2-8767-573aa4f9b2ee"), "602", "2205445193420098", new Guid("daa4e6cd-ddad-46b2-8767-573aa4f9b2ee"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), "02/14" },
                    { new Guid("dabff76b-8754-4a49-87b5-06bd7fca8230"), "547", "5743810557333189", new Guid("dabff76b-8754-4a49-87b5-06bd7fca8230"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c"), "01/18" },
                    { new Guid("dad0c83d-2a91-44a0-805a-43245c6280aa"), "895", "4040519278915238", new Guid("dad0c83d-2a91-44a0-805a-43245c6280aa"), new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26"), "12/08" },
                    { new Guid("dae194be-11e8-49ab-bf57-e5ba01c0b391"), "612", "5977817861940805", new Guid("dae194be-11e8-49ab-bf57-e5ba01c0b391"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e"), "05/19" },
                    { new Guid("db05cab3-d7a9-4379-99fc-9968f6dd3c38"), "795", "8339354466895175", new Guid("db05cab3-d7a9-4379-99fc-9968f6dd3c38"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131"), "06/11" },
                    { new Guid("db12b0aa-034e-4c2a-b341-e72fef2cbb68"), "321", "4788595519867338", new Guid("db12b0aa-034e-4c2a-b341-e72fef2cbb68"), new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6"), "09/07" },
                    { new Guid("db35fb27-d2c1-42c7-93ea-0c1b7af1c276"), "893", "5435487829093303", new Guid("db35fb27-d2c1-42c7-93ea-0c1b7af1c276"), new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13"), "02/22" },
                    { new Guid("dbca23b0-1e9b-498f-a5fc-d71f2e82e696"), "658", "7533499595363907", new Guid("dbca23b0-1e9b-498f-a5fc-d71f2e82e696"), new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869"), "11/05" },
                    { new Guid("dbcf5568-5928-408f-92b8-364ef79bc321"), "619", "1260950459756390", new Guid("dbcf5568-5928-408f-92b8-364ef79bc321"), new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e"), "01/26" },
                    { new Guid("dc056d98-dce8-4c8b-adbb-31214a90fd7a"), "143", "1505880918417709", new Guid("dc056d98-dce8-4c8b-adbb-31214a90fd7a"), new Guid("28f12604-451b-425e-ae23-1db801053b3e"), "11/20" },
                    { new Guid("dc9ab4b0-acc6-4ef0-907e-bee5e4b7aef6"), "722", "5568708396466100", new Guid("dc9ab4b0-acc6-4ef0-907e-bee5e4b7aef6"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9"), "09/07" },
                    { new Guid("dca48525-2b51-4763-b3c5-8e5e2a3175f9"), "495", "5208318714701846", new Guid("dca48525-2b51-4763-b3c5-8e5e2a3175f9"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964"), "01/20" },
                    { new Guid("dcbb2246-f823-4e3f-8795-1e6e2eb96380"), "985", "1861659594653802", new Guid("dcbb2246-f823-4e3f-8795-1e6e2eb96380"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a"), "01/10" },
                    { new Guid("dd766ac0-e17b-44d3-ba1b-168ca7b06540"), "195", "1348435109341575", new Guid("dd766ac0-e17b-44d3-ba1b-168ca7b06540"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d"), "01/03" },
                    { new Guid("dda03586-0b06-4f14-bafa-e212fae90746"), "003", "2187047872114687", new Guid("dda03586-0b06-4f14-bafa-e212fae90746"), new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c"), "02/09" },
                    { new Guid("ddb89bde-83da-4c64-80c9-ee0e32ab6888"), "814", "9295585653569058", new Guid("ddb89bde-83da-4c64-80c9-ee0e32ab6888"), new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5"), "05/24" },
                    { new Guid("ddb9af40-1770-4688-ab85-310d44418379"), "689", "4190825308388728", new Guid("ddb9af40-1770-4688-ab85-310d44418379"), new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0"), "08/27" },
                    { new Guid("ddd326e8-4b7a-4973-9b26-bd2e0f1598f9"), "649", "7417745752343251", new Guid("ddd326e8-4b7a-4973-9b26-bd2e0f1598f9"), new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037"), "02/20" },
                    { new Guid("ddfe8fe6-6c48-4111-a699-bccfb4ac2f13"), "288", "3550258658865497", new Guid("ddfe8fe6-6c48-4111-a699-bccfb4ac2f13"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777"), "10/05" },
                    { new Guid("de15cf7e-fcfb-4e7a-a3d7-e2a82f469ff8"), "060", "7113667487339879", new Guid("de15cf7e-fcfb-4e7a-a3d7-e2a82f469ff8"), new Guid("f97b4375-8386-46ac-afd2-0892fcde0593"), "01/21" },
                    { new Guid("de838764-a18f-4725-815e-e820540f3bcb"), "843", "9805756508679880", new Guid("de838764-a18f-4725-815e-e820540f3bcb"), new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519"), "03/11" },
                    { new Guid("deb64d07-eeb7-48e7-bedf-816fc4142306"), "488", "2909579490303039", new Guid("deb64d07-eeb7-48e7-bedf-816fc4142306"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604"), "12/17" },
                    { new Guid("df180075-bcd3-44e0-b220-52c6a41cc2ee"), "666", "2090011656518217", new Guid("df180075-bcd3-44e0-b220-52c6a41cc2ee"), new Guid("7c2af719-e82e-4031-bc56-568a9d473316"), "04/20" },
                    { new Guid("df27a4c9-cc06-4a69-8b23-d343b1e588d4"), "812", "4654964353525119", new Guid("df27a4c9-cc06-4a69-8b23-d343b1e588d4"), new Guid("08e83522-0abb-4778-9027-c86ca1a0a624"), "04/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("df9cc9c8-17df-4812-922c-f99d7d2a882f"), "988", "9881158989821720", new Guid("df9cc9c8-17df-4812-922c-f99d7d2a882f"), new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162"), "04/27" },
                    { new Guid("e0362d8e-0f0d-4007-a8d5-42f225d3218d"), "705", "6048920170485304", new Guid("e0362d8e-0f0d-4007-a8d5-42f225d3218d"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95"), "10/13" },
                    { new Guid("e089a615-f77a-4821-a22a-b782808ee4af"), "097", "6138555818065618", new Guid("e089a615-f77a-4821-a22a-b782808ee4af"), new Guid("482c0758-a476-404a-ade3-01c0818a58f9"), "11/04" },
                    { new Guid("e0c00af9-87aa-4f09-8d41-2bb6cc3e9836"), "825", "9581127780035835", new Guid("e0c00af9-87aa-4f09-8d41-2bb6cc3e9836"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a"), "07/02" },
                    { new Guid("e0c9b5d4-8175-47b3-bff2-e06795b21c55"), "992", "9695482065649576", new Guid("e0c9b5d4-8175-47b3-bff2-e06795b21c55"), new Guid("e5acadcd-43bb-4225-9367-f562e86197e5"), "06/05" },
                    { new Guid("e0df39be-4588-4c8a-8384-0292b256af03"), "800", "6641575738551799", new Guid("e0df39be-4588-4c8a-8384-0292b256af03"), new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c"), "07/08" },
                    { new Guid("e17417d1-f555-40ae-b584-58b5c17920a1"), "981", "9509152526312279", new Guid("e17417d1-f555-40ae-b584-58b5c17920a1"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec"), "04/09" },
                    { new Guid("e17c69cd-6515-4e62-86d5-ef5648f7a4d0"), "339", "6154723602872589", new Guid("e17c69cd-6515-4e62-86d5-ef5648f7a4d0"), new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63"), "04/06" },
                    { new Guid("e1ba95ce-6ecc-4090-8e44-0584ca5b138c"), "392", "4239423468870570", new Guid("e1ba95ce-6ecc-4090-8e44-0584ca5b138c"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c"), "09/05" },
                    { new Guid("e244d54c-cf74-4a12-bcdf-9b86a50a7ba1"), "962", "5577996504837252", new Guid("e244d54c-cf74-4a12-bcdf-9b86a50a7ba1"), new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c"), "03/03" },
                    { new Guid("e26e29be-2330-4be0-a2b6-98f768689f0b"), "896", "5048270288114793", new Guid("e26e29be-2330-4be0-a2b6-98f768689f0b"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba"), "06/11" },
                    { new Guid("e3038fe1-5834-4e3d-b60a-3b0d318e98be"), "722", "6322992199491408", new Guid("e3038fe1-5834-4e3d-b60a-3b0d318e98be"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05"), "03/28" },
                    { new Guid("e33f4786-3a29-468f-8ca2-398dc22fba28"), "468", "6446402473751670", new Guid("e33f4786-3a29-468f-8ca2-398dc22fba28"), new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2"), "09/05" },
                    { new Guid("e35ba6c1-9ca5-4b7d-8630-588f528b0882"), "700", "3273903940790497", new Guid("e35ba6c1-9ca5-4b7d-8630-588f528b0882"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd"), "03/13" },
                    { new Guid("e3a297ca-ddf6-4b28-a39c-b773f73f5ef2"), "087", "9079292067318396", new Guid("e3a297ca-ddf6-4b28-a39c-b773f73f5ef2"), new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59"), "11/19" },
                    { new Guid("e3b8c861-ea24-4a3f-afbc-fd63f5886f5b"), "622", "8584940037631475", new Guid("e3b8c861-ea24-4a3f-afbc-fd63f5886f5b"), new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374"), "10/17" },
                    { new Guid("e42cbde3-3720-4aa1-8f61-d51bfbe9bed1"), "561", "3101216224161935", new Guid("e42cbde3-3720-4aa1-8f61-d51bfbe9bed1"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41"), "05/03" },
                    { new Guid("e438f5f6-2c35-4881-a008-7b27e65dc04c"), "104", "8827578450756154", new Guid("e438f5f6-2c35-4881-a008-7b27e65dc04c"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa"), "09/03" },
                    { new Guid("e4b3ffd0-247e-47a0-a245-873b0c72fb5c"), "176", "4486267968533291", new Guid("e4b3ffd0-247e-47a0-a245-873b0c72fb5c"), new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3"), "05/20" },
                    { new Guid("e4e15e86-c94c-48fc-9fd3-8a32d4bb0418"), "924", "6112311387266439", new Guid("e4e15e86-c94c-48fc-9fd3-8a32d4bb0418"), new Guid("12b74093-45e4-451e-b1a4-f4797f48c780"), "12/16" },
                    { new Guid("e50536b5-1807-4389-93dd-1b244601d26e"), "361", "9026411631971627", new Guid("e50536b5-1807-4389-93dd-1b244601d26e"), new Guid("7637da20-6c85-4358-a711-5912b0358007"), "05/01" },
                    { new Guid("e53d20f7-bb94-4ead-8611-32f149fbe076"), "731", "4094953062987858", new Guid("e53d20f7-bb94-4ead-8611-32f149fbe076"), new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88"), "05/20" },
                    { new Guid("e5a0ba69-c630-4af3-a5df-d894ca41feb5"), "983", "4392150593665486", new Guid("e5a0ba69-c630-4af3-a5df-d894ca41feb5"), new Guid("08e83522-0abb-4778-9027-c86ca1a0a624"), "04/20" },
                    { new Guid("e5ffa320-1684-43af-82a4-1a54e0d6b484"), "581", "9705507400141633", new Guid("e5ffa320-1684-43af-82a4-1a54e0d6b484"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157"), "05/03" },
                    { new Guid("e68967ca-8e97-40e5-8b66-7378b4b4c694"), "050", "2892367131319212", new Guid("e68967ca-8e97-40e5-8b66-7378b4b4c694"), new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd"), "08/23" },
                    { new Guid("e73e1819-42f2-413b-8904-9559906689fd"), "746", "4991932516240498", new Guid("e73e1819-42f2-413b-8904-9559906689fd"), new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b"), "12/12" },
                    { new Guid("e749d9d7-589e-49c4-89d4-79410fa4110d"), "931", "1481146574287493", new Guid("e749d9d7-589e-49c4-89d4-79410fa4110d"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f"), "08/08" },
                    { new Guid("e7a01685-2302-4814-a4ec-205b14305519"), "195", "3478199810106492", new Guid("e7a01685-2302-4814-a4ec-205b14305519"), new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258"), "08/18" },
                    { new Guid("e7b3136d-5e2d-4dce-b90e-821f21a86e7c"), "003", "3940988800538444", new Guid("e7b3136d-5e2d-4dce-b90e-821f21a86e7c"), new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420"), "10/14" },
                    { new Guid("e7d73150-2035-4f6f-a5ba-1a6f91f7a16a"), "882", "4530768402333103", new Guid("e7d73150-2035-4f6f-a5ba-1a6f91f7a16a"), new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a"), "05/15" },
                    { new Guid("e827f184-d154-4e3e-bb1f-e9dba67a8877"), "453", "5096787378432784", new Guid("e827f184-d154-4e3e-bb1f-e9dba67a8877"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba"), "12/22" },
                    { new Guid("e83c8cae-2417-4151-a03c-ddf72a630577"), "875", "7755816274514135", new Guid("e83c8cae-2417-4151-a03c-ddf72a630577"), new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6"), "05/05" },
                    { new Guid("e8b36ee1-e209-4417-b203-567720b70ea1"), "524", "2516441075052798", new Guid("e8b36ee1-e209-4417-b203-567720b70ea1"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6"), "09/26" },
                    { new Guid("e8bcab20-f9ee-4ba7-82e6-8f84fb92fa9d"), "456", "7715571551071316", new Guid("e8bcab20-f9ee-4ba7-82e6-8f84fb92fa9d"), new Guid("8987fd2f-b286-41d7-9544-b355355a2cff"), "10/18" },
                    { new Guid("e9969153-ff6b-4127-889a-e7ab32118ca6"), "370", "8725212482776073", new Guid("e9969153-ff6b-4127-889a-e7ab32118ca6"), new Guid("8f8cd90d-fe20-4df0-8607-72f337546146"), "06/06" },
                    { new Guid("e9b75751-d344-4ad6-9d52-19e9b2e4c48b"), "649", "2125048606706499", new Guid("e9b75751-d344-4ad6-9d52-19e9b2e4c48b"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0"), "03/27" },
                    { new Guid("ea4b0d17-30db-49b5-9030-3cf4c9157165"), "067", "1079760381528687", new Guid("ea4b0d17-30db-49b5-9030-3cf4c9157165"), new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95"), "09/06" },
                    { new Guid("eaa73b8a-e002-40c0-a7f1-e419a0913073"), "014", "3522925160409272", new Guid("eaa73b8a-e002-40c0-a7f1-e419a0913073"), new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0"), "07/28" },
                    { new Guid("eab7e7af-1cbb-4efd-9da2-56425efcbf16"), "156", "5023634451397630", new Guid("eab7e7af-1cbb-4efd-9da2-56425efcbf16"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157"), "05/20" },
                    { new Guid("eac5f77f-c88e-4a68-9817-caac1ecc63f9"), "417", "5827122934497264", new Guid("eac5f77f-c88e-4a68-9817-caac1ecc63f9"), new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d"), "12/28" },
                    { new Guid("eb4c8a52-40ba-43ac-b1fe-94417afef8af"), "447", "7793580994732590", new Guid("eb4c8a52-40ba-43ac-b1fe-94417afef8af"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777"), "02/27" },
                    { new Guid("eb8d715a-5e54-414f-820d-3f8bea437d3f"), "461", "1039968261838745", new Guid("eb8d715a-5e54-414f-820d-3f8bea437d3f"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e"), "09/19" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("ebdf1a62-1abd-48fa-a9f3-09fd15653e9c"), "743", "4999759330707155", new Guid("ebdf1a62-1abd-48fa-a9f3-09fd15653e9c"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5"), "03/05" },
                    { new Guid("ebeabdfb-bb45-42d5-9bc0-c4a90e8c6c4e"), "122", "9781491066212582", new Guid("ebeabdfb-bb45-42d5-9bc0-c4a90e8c6c4e"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c"), "02/16" },
                    { new Guid("ec017e16-3d65-4a82-b995-c0e9dc58832d"), "532", "1293512032509794", new Guid("ec017e16-3d65-4a82-b995-c0e9dc58832d"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c"), "08/12" },
                    { new Guid("ecba9d7f-8c9d-46f8-8f96-7244c9e2d556"), "181", "4901660236706430", new Guid("ecba9d7f-8c9d-46f8-8f96-7244c9e2d556"), new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d"), "07/06" },
                    { new Guid("ecbacdae-a0f3-49a9-8f8c-24facea5afdb"), "896", "2749626104190884", new Guid("ecbacdae-a0f3-49a9-8f8c-24facea5afdb"), new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574"), "02/01" },
                    { new Guid("ed12d8de-174c-4062-b5a5-a7f74d2d90c5"), "607", "6993373345490200", new Guid("ed12d8de-174c-4062-b5a5-a7f74d2d90c5"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa"), "12/02" },
                    { new Guid("ed2e7485-69fe-491f-8a90-9628d0af7aaa"), "300", "6857688535791577", new Guid("ed2e7485-69fe-491f-8a90-9628d0af7aaa"), new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6"), "05/03" },
                    { new Guid("ed6c5fa8-59ce-4ff2-a654-7150146ae4e3"), "750", "3655534739809126", new Guid("ed6c5fa8-59ce-4ff2-a654-7150146ae4e3"), new Guid("a11d6609-e768-4189-bd78-5b34d82849e6"), "04/03" },
                    { new Guid("edd4ab6f-53ec-483f-9ea0-8886a5b1ef86"), "358", "5109608220959869", new Guid("edd4ab6f-53ec-483f-9ea0-8886a5b1ef86"), new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c"), "12/18" },
                    { new Guid("edd832a1-044f-4fa9-bd1b-c0d3ddec81cc"), "708", "9989923600935598", new Guid("edd832a1-044f-4fa9-bd1b-c0d3ddec81cc"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0"), "03/23" },
                    { new Guid("eddd442b-71b8-4ffa-8648-5452887097cc"), "272", "4863486270423093", new Guid("eddd442b-71b8-4ffa-8648-5452887097cc"), new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305"), "04/25" },
                    { new Guid("ee0cc8aa-5bc5-4752-bb6c-1405e07f2446"), "076", "6499254280833300", new Guid("ee0cc8aa-5bc5-4752-bb6c-1405e07f2446"), new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584"), "11/04" },
                    { new Guid("ee63e747-bd08-4e96-bf73-242ebcc62708"), "034", "7433165519253172", new Guid("ee63e747-bd08-4e96-bf73-242ebcc62708"), new Guid("86555a53-2ae1-40b3-98c6-17036425dac8"), "10/01" },
                    { new Guid("ee83273a-e01d-4856-bf31-0904fe25d5a9"), "752", "6504562851705361", new Guid("ee83273a-e01d-4856-bf31-0904fe25d5a9"), new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861"), "01/04" },
                    { new Guid("eea1e608-db29-45ea-85bd-f9846c9cff2c"), "548", "6651496786165088", new Guid("eea1e608-db29-45ea-85bd-f9846c9cff2c"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816"), "07/10" },
                    { new Guid("eea51295-1022-4d19-b38b-f91b24d01194"), "686", "6028083426492738", new Guid("eea51295-1022-4d19-b38b-f91b24d01194"), new Guid("8604dfec-8284-4ca8-8911-7d89e1637747"), "05/07" },
                    { new Guid("ef275f98-cc7c-4efc-8703-101b976eaf28"), "072", "4372226965958641", new Guid("ef275f98-cc7c-4efc-8703-101b976eaf28"), new Guid("05d888a7-8474-4565-b751-a89df2400346"), "06/21" },
                    { new Guid("ef3e9834-7b38-4456-a81c-8b464a8168ed"), "790", "7258176025211556", new Guid("ef3e9834-7b38-4456-a81c-8b464a8168ed"), new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f"), "04/08" },
                    { new Guid("f02eb587-569c-4975-91dd-31389bf8db73"), "829", "5511605877677741", new Guid("f02eb587-569c-4975-91dd-31389bf8db73"), new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0"), "05/18" },
                    { new Guid("f0ee3946-33c2-433d-b12a-3d8f8e946e93"), "513", "3369086274382642", new Guid("f0ee3946-33c2-433d-b12a-3d8f8e946e93"), new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376"), "02/27" },
                    { new Guid("f159fb63-814d-4e79-a635-735cf4a00de9"), "851", "2880401371537092", new Guid("f159fb63-814d-4e79-a635-735cf4a00de9"), new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a"), "10/13" },
                    { new Guid("f1d5d931-2ead-48d6-83c1-0ac177837056"), "888", "6937813332694374", new Guid("f1d5d931-2ead-48d6-83c1-0ac177837056"), new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e"), "07/06" },
                    { new Guid("f2945ac5-4959-4001-8fca-b1fc256b4e66"), "543", "7114141541359576", new Guid("f2945ac5-4959-4001-8fca-b1fc256b4e66"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9"), "05/25" },
                    { new Guid("f4821f30-53f1-4175-a25e-352ca1a182b4"), "478", "8594803759260452", new Guid("f4821f30-53f1-4175-a25e-352ca1a182b4"), new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405"), "05/26" },
                    { new Guid("f4c439ac-019a-437e-af9d-d226a52a8747"), "829", "4838993415805099", new Guid("f4c439ac-019a-437e-af9d-d226a52a8747"), new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e"), "04/28" },
                    { new Guid("f5a88adb-7c7c-41d5-9d2b-2d1f7f5034e8"), "322", "8248558268151467", new Guid("f5a88adb-7c7c-41d5-9d2b-2d1f7f5034e8"), new Guid("33d5b081-5c0f-4871-905f-631caba91848"), "02/21" },
                    { new Guid("f62f9b5e-b8c1-4745-8ba2-e6d77126ae48"), "831", "6442484301478105", new Guid("f62f9b5e-b8c1-4745-8ba2-e6d77126ae48"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157"), "01/05" },
                    { new Guid("f660df4f-f4f0-4360-a565-3c7e8fdd462e"), "557", "7815592766521729", new Guid("f660df4f-f4f0-4360-a565-3c7e8fdd462e"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330"), "10/26" },
                    { new Guid("f6c22cb6-2e47-4aef-ab13-2a796da23443"), "724", "4338611793127195", new Guid("f6c22cb6-2e47-4aef-ab13-2a796da23443"), new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13"), "05/04" },
                    { new Guid("f6dc6b27-4a88-4b15-b1f8-5fff19c29266"), "408", "9896124954859212", new Guid("f6dc6b27-4a88-4b15-b1f8-5fff19c29266"), new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa"), "03/26" },
                    { new Guid("f6e4e471-5e0f-4b24-b2ec-37fda8fad0af"), "510", "5209341368996450", new Guid("f6e4e471-5e0f-4b24-b2ec-37fda8fad0af"), new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6"), "11/07" },
                    { new Guid("f6e53aa0-f414-4c01-910c-2ee528a87b40"), "231", "5783928519086706", new Guid("f6e53aa0-f414-4c01-910c-2ee528a87b40"), new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5"), "10/28" },
                    { new Guid("f701a7a6-1e0c-48eb-90b2-7c64beeca64b"), "513", "9162896222848079", new Guid("f701a7a6-1e0c-48eb-90b2-7c64beeca64b"), new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1"), "06/07" },
                    { new Guid("f704d96d-29c6-4317-be61-77eb3367df22"), "176", "7043505368064026", new Guid("f704d96d-29c6-4317-be61-77eb3367df22"), new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674"), "11/25" },
                    { new Guid("f7592ddf-f93c-471c-9e49-43d1c2bacc1a"), "461", "4930396999518293", new Guid("f7592ddf-f93c-471c-9e49-43d1c2bacc1a"), new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3"), "12/13" },
                    { new Guid("f7a18ab3-421e-4dc9-9422-4b4a2331f5af"), "500", "7016178419689805", new Guid("f7a18ab3-421e-4dc9-9422-4b4a2331f5af"), new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7"), "04/11" },
                    { new Guid("f8a44f43-d19f-4c89-b02a-5e354206f184"), "403", "8044140141013771", new Guid("f8a44f43-d19f-4c89-b02a-5e354206f184"), new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0"), "09/02" },
                    { new Guid("f94f82d7-9cc5-4350-89d9-78fec690d883"), "415", "8851835655786054", new Guid("f94f82d7-9cc5-4350-89d9-78fec690d883"), new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655"), "11/19" },
                    { new Guid("f9c0714a-e8d3-43bc-b4f9-0999ab255695"), "377", "4259669054284151", new Guid("f9c0714a-e8d3-43bc-b4f9-0999ab255695"), new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4"), "12/27" },
                    { new Guid("f9c10ac7-14ae-4d7d-a341-da9a63812464"), "867", "1125968992998257", new Guid("f9c10ac7-14ae-4d7d-a341-da9a63812464"), new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4"), "03/12" },
                    { new Guid("f9c8b5f6-8662-4f2d-b921-b2b8c42045fd"), "569", "4490037799430360", new Guid("f9c8b5f6-8662-4f2d-b921-b2b8c42045fd"), new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab"), "12/08" },
                    { new Guid("f9d10bca-ca8d-42f9-ae83-23df9af4dc28"), "323", "7471283929191403", new Guid("f9d10bca-ca8d-42f9-ae83-23df9af4dc28"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89"), "11/18" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "Id", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("f9fc1b04-7def-4e02-b433-3e03eb8dbe7c"), "455", "6477060941626805", new Guid("f9fc1b04-7def-4e02-b433-3e03eb8dbe7c"), new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7"), "02/06" },
                    { new Guid("fa4a2536-747b-45de-8fa6-e3e228464c0e"), "603", "8395542727543436", new Guid("fa4a2536-747b-45de-8fa6-e3e228464c0e"), new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a"), "11/10" },
                    { new Guid("fb3f313f-b286-4e02-9bae-571b96a6c96b"), "538", "9202082171228218", new Guid("fb3f313f-b286-4e02-9bae-571b96a6c96b"), new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075"), "12/12" },
                    { new Guid("fb422f3b-2070-48c7-a1e7-10fa84368897"), "752", "2585207006320252", new Guid("fb422f3b-2070-48c7-a1e7-10fa84368897"), new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa"), "12/19" },
                    { new Guid("fb50efb7-4869-4467-92cd-b0905c018d35"), "132", "7683961550841389", new Guid("fb50efb7-4869-4467-92cd-b0905c018d35"), new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30"), "04/26" },
                    { new Guid("fba14d7d-9591-446e-a4f9-3dfd209f8e06"), "748", "2861177406092106", new Guid("fba14d7d-9591-446e-a4f9-3dfd209f8e06"), new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01"), "03/10" },
                    { new Guid("fbe978c4-aefe-4960-b86b-7feab3881732"), "852", "8068210148298002", new Guid("fbe978c4-aefe-4960-b86b-7feab3881732"), new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33"), "10/12" },
                    { new Guid("fbeceb46-f3cf-464b-8684-1432eaeae78c"), "005", "5157261517110268", new Guid("fbeceb46-f3cf-464b-8684-1432eaeae78c"), new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a"), "12/01" },
                    { new Guid("fc0746e6-bae6-4647-a828-19e4e3c44fef"), "652", "5240690673810181", new Guid("fc0746e6-bae6-4647-a828-19e4e3c44fef"), new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec"), "11/12" },
                    { new Guid("fc2401ab-6e71-450a-a59f-21818535dc38"), "800", "3397953656600826", new Guid("fc2401ab-6e71-450a-a59f-21818535dc38"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440"), "11/28" },
                    { new Guid("fc9e464a-5908-4035-b3b1-bcf6d9b9c863"), "816", "9005446944678081", new Guid("fc9e464a-5908-4035-b3b1-bcf6d9b9c863"), new Guid("35482730-4c7a-4e01-aeca-0748f3123997"), "11/22" },
                    { new Guid("fce615c6-52a1-4338-8a3b-f707c43916f0"), "503", "1662021139107162", new Guid("fce615c6-52a1-4338-8a3b-f707c43916f0"), new Guid("a662b3ad-6def-4527-81c0-400ae1450131"), "08/03" },
                    { new Guid("fd1ca3f4-67ec-4e24-bac8-0e5330f10785"), "635", "6348765079771193", new Guid("fd1ca3f4-67ec-4e24-bac8-0e5330f10785"), new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5"), "03/05" },
                    { new Guid("fdaee4b4-c386-467e-8eeb-734ea4ab813c"), "543", "7981564908160408", new Guid("fdaee4b4-c386-467e-8eeb-734ea4ab813c"), new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0"), "08/04" },
                    { new Guid("fdb58b9b-7379-4fb1-8211-27a52938b012"), "681", "4322979434026966", new Guid("fdb58b9b-7379-4fb1-8211-27a52938b012"), new Guid("a6f0e48a-50d2-402a-b954-f944f339456a"), "07/08" },
                    { new Guid("fdcbaedb-ab7b-43d4-8326-26bcf08ce058"), "925", "5578068668492338", new Guid("fdcbaedb-ab7b-43d4-8326-26bcf08ce058"), new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584"), "01/08" },
                    { new Guid("fdefef43-2183-43e4-ae3e-5b242ffb6819"), "578", "4167771926187703", new Guid("fdefef43-2183-43e4-ae3e-5b242ffb6819"), new Guid("cb635093-0872-4986-8027-340de9f12a5c"), "12/05" },
                    { new Guid("fee79eba-0211-4bf8-9a0b-67f7d17823f6"), "819", "9111737468347138", new Guid("fee79eba-0211-4bf8-9a0b-67f7d17823f6"), new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816"), "12/01" },
                    { new Guid("ff610af2-d4ee-41ac-a62e-dcb8588ad93a"), "567", "8794629444350254", new Guid("ff610af2-d4ee-41ac-a62e-dcb8588ad93a"), new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272"), "05/05" },
                    { new Guid("ff9421b6-f36a-4afc-80a8-678e1305ef6f"), "288", "2592824871114287", new Guid("ff9421b6-f36a-4afc-80a8-678e1305ef6f"), new Guid("e2c0f944-e30b-436d-966b-858138b547a6"), "12/18" },
                    { new Guid("ffed5c4d-606a-47cd-bf8b-35882d250b85"), "727", "3154679560115632", new Guid("ffed5c4d-606a-47cd-bf8b-35882d250b85"), new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4"), "02/13" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("003ddf64-c466-4ae3-86bb-faf9dc85813b"), new Guid("003ddf64-c466-4ae3-86bb-faf9dc85813b"), "+956 38 (007) 11-73", new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4") },
                    { new Guid("00521c52-7b71-44db-9203-13e59fac25a2"), new Guid("00521c52-7b71-44db-9203-13e59fac25a2"), "+514 14 (260) 66-30", new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("00976a8f-edcd-43e5-bab5-cfb3208ca548"), new Guid("00976a8f-edcd-43e5-bab5-cfb3208ca548"), "+907 89 (688) 13-11", new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac") },
                    { new Guid("009a5473-1399-405e-8b5f-b6bd0391c960"), new Guid("009a5473-1399-405e-8b5f-b6bd0391c960"), "+420 06 (327) 10-80", new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("00b0b34d-1855-4ae1-a839-b3906935903d"), new Guid("00b0b34d-1855-4ae1-a839-b3906935903d"), "+630 73 (566) 09-85", new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("00d0ef9a-5cf8-40d6-9ee2-8bcf05484618"), new Guid("00d0ef9a-5cf8-40d6-9ee2-8bcf05484618"), "+2 12 (479) 06-41", new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e") },
                    { new Guid("0120f7fb-0737-41c7-9189-eab3c921e34d"), new Guid("0120f7fb-0737-41c7-9189-eab3c921e34d"), "+90 72 (079) 56-46", new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("015d6333-4d42-4018-ac88-fbd238028a7e"), new Guid("015d6333-4d42-4018-ac88-fbd238028a7e"), "+474 42 (341) 81-67", new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("018baec6-27c5-44ad-ac87-0e8a8afe8609"), new Guid("018baec6-27c5-44ad-ac87-0e8a8afe8609"), "+389 39 (784) 39-49", new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("0228b987-0def-44b7-8415-4abd347f64b6"), new Guid("0228b987-0def-44b7-8415-4abd347f64b6"), "+347 89 (602) 85-96", new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("023e9307-e87e-40ff-bb45-677c7a7ad1ad"), new Guid("023e9307-e87e-40ff-bb45-677c7a7ad1ad"), "+786 09 (416) 82-06", new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("026e5d19-c8ff-4cf9-b8dc-0b806a0ff4f8"), new Guid("026e5d19-c8ff-4cf9-b8dc-0b806a0ff4f8"), "+300 34 (351) 97-27", new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("0275fa7d-249e-4dd3-933e-91f6c52248b9"), new Guid("0275fa7d-249e-4dd3-933e-91f6c52248b9"), "+43 66 (147) 75-78", new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("030c9f37-2411-464c-a1d4-63f24a673c42"), new Guid("030c9f37-2411-464c-a1d4-63f24a673c42"), "+827 31 (916) 16-82", new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("030ddf24-a762-4547-aba1-c03df757313b"), new Guid("030ddf24-a762-4547-aba1-c03df757313b"), "+200 42 (237) 24-71", new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("036c6576-8ddb-4f7b-95f3-81c09f32e58e"), new Guid("036c6576-8ddb-4f7b-95f3-81c09f32e58e"), "+760 98 (256) 59-54", new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("03746581-32d4-4008-aed5-acd77637aadd"), new Guid("03746581-32d4-4008-aed5-acd77637aadd"), "+630 47 (029) 66-83", new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("03b311d5-e732-4cee-847c-e0bbbea0f75b"), new Guid("03b311d5-e732-4cee-847c-e0bbbea0f75b"), "+895 41 (075) 83-51", new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("03f476a0-de31-41ca-8cd9-b326a9639d38"), new Guid("03f476a0-de31-41ca-8cd9-b326a9639d38"), "+675 15 (987) 62-65", new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd") },
                    { new Guid("05cf2f76-49e7-4269-b1eb-b603c3097925"), new Guid("05cf2f76-49e7-4269-b1eb-b603c3097925"), "+462 63 (236) 54-74", new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("062210d8-8ae2-4ba0-b142-4b05c660dbbc"), new Guid("062210d8-8ae2-4ba0-b142-4b05c660dbbc"), "+243 48 (171) 23-56", new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("066a7053-f842-4352-bc54-1ceeb4e47f23"), new Guid("066a7053-f842-4352-bc54-1ceeb4e47f23"), "+661 55 (531) 37-80", new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("06885ba0-3356-460e-8d4b-7cbdf07ced84"), new Guid("06885ba0-3356-460e-8d4b-7cbdf07ced84"), "+775 22 (323) 51-15", new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13") },
                    { new Guid("06b6ae8b-93a0-43ad-b75e-8227d11a5ea7"), new Guid("06b6ae8b-93a0-43ad-b75e-8227d11a5ea7"), "+166 83 (025) 55-44", new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("06be0394-4192-4533-bd99-28004c61efd7"), new Guid("06be0394-4192-4533-bd99-28004c61efd7"), "+650 75 (569) 21-25", new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa") },
                    { new Guid("06e47194-ba41-46b0-999c-6a306cdb26fc"), new Guid("06e47194-ba41-46b0-999c-6a306cdb26fc"), "+390 43 (669) 27-57", new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("0760bb8e-3331-410c-8497-70685f0d98dd"), new Guid("0760bb8e-3331-410c-8497-70685f0d98dd"), "+951 14 (473) 96-21", new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("07d3a6d2-2879-4895-8203-c4297a3058cb"), new Guid("07d3a6d2-2879-4895-8203-c4297a3058cb"), "+427 87 (825) 50-02", new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("07d895de-8c2d-4cc3-b582-d3b7377c57f8"), new Guid("07d895de-8c2d-4cc3-b582-d3b7377c57f8"), "+211 52 (664) 52-21", new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("07dac7ea-0985-41f8-ac56-e3a90f584de9"), new Guid("07dac7ea-0985-41f8-ac56-e3a90f584de9"), "+102 88 (052) 72-42", new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("07dcfec2-d321-4e02-94a4-a7ecd2261511"), new Guid("07dcfec2-d321-4e02-94a4-a7ecd2261511"), "+860 97 (181) 19-72", new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d") },
                    { new Guid("07eca35f-4007-4a01-8a0a-b854fa599906"), new Guid("07eca35f-4007-4a01-8a0a-b854fa599906"), "+720 99 (353) 95-87", new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("08089c92-045f-4a9c-b5ca-f705488123b3"), new Guid("08089c92-045f-4a9c-b5ca-f705488123b3"), "+267 70 (453) 13-25", new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("0837149f-3426-4ac1-9908-bffdd3a890e5"), new Guid("0837149f-3426-4ac1-9908-bffdd3a890e5"), "+53 11 (080) 25-81", new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03") },
                    { new Guid("08594fcd-9067-4712-bc50-0046c831e673"), new Guid("08594fcd-9067-4712-bc50-0046c831e673"), "+57 75 (504) 29-08", new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("0877571f-b3bc-4e4e-96d2-09cb0e0d21a5"), new Guid("0877571f-b3bc-4e4e-96d2-09cb0e0d21a5"), "+801 88 (068) 60-99", new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("08874f25-25cc-4b5c-b46d-0b521cb3423f"), new Guid("08874f25-25cc-4b5c-b46d-0b521cb3423f"), "+784 11 (588) 35-80", new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b") },
                    { new Guid("09441648-b8f2-4d6a-9ea9-3f7d2e877e7e"), new Guid("09441648-b8f2-4d6a-9ea9-3f7d2e877e7e"), "+505 82 (459) 03-14", new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("09627baa-6818-41be-83c7-db5fddd78f7e"), new Guid("09627baa-6818-41be-83c7-db5fddd78f7e"), "+398 69 (322) 11-85", new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("09aa2a8d-2cce-4e57-b5d9-e6ca9836ad57"), new Guid("09aa2a8d-2cce-4e57-b5d9-e6ca9836ad57"), "+262 61 (276) 12-18", new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("09d1adc4-b435-46ab-b816-0849656d3d4a"), new Guid("09d1adc4-b435-46ab-b816-0849656d3d4a"), "+975 73 (095) 81-16", new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2") },
                    { new Guid("09ea15bf-356b-43cc-93ad-11679886f8bf"), new Guid("09ea15bf-356b-43cc-93ad-11679886f8bf"), "+580 44 (111) 82-59", new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405") },
                    { new Guid("09f2ec41-22f0-448e-a707-8d900f79b775"), new Guid("09f2ec41-22f0-448e-a707-8d900f79b775"), "+789 42 (309) 20-04", new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("0a7f9ee4-4a4b-4372-ba23-bb53ae462422"), new Guid("0a7f9ee4-4a4b-4372-ba23-bb53ae462422"), "+775 99 (613) 59-60", new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("0a848e3c-137a-4fc2-a1bc-1c1238f08dfe"), new Guid("0a848e3c-137a-4fc2-a1bc-1c1238f08dfe"), "+978 76 (771) 05-32", new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d") },
                    { new Guid("0ab71848-e29a-437f-8043-9ead759a961d"), new Guid("0ab71848-e29a-437f-8043-9ead759a961d"), "+448 09 (342) 26-67", new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("0b3cee51-f0d6-4113-a188-dac244bb0fd2"), new Guid("0b3cee51-f0d6-4113-a188-dac244bb0fd2"), "+637 27 (909) 63-09", new Guid("0823436c-27ad-4402-b5e2-b17efa08505e") },
                    { new Guid("0b50aa92-06ba-467b-90f5-21480579fb04"), new Guid("0b50aa92-06ba-467b-90f5-21480579fb04"), "+929 37 (648) 84-61", new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("0b52447d-ed8f-4fe2-958a-1bb99b8aca13"), new Guid("0b52447d-ed8f-4fe2-958a-1bb99b8aca13"), "+378 34 (797) 75-96", new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("0b602ec3-fd53-4f4f-9b1e-05834896487d"), new Guid("0b602ec3-fd53-4f4f-9b1e-05834896487d"), "+280 26 (869) 48-35", new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("0b672d47-5e43-4831-b93f-139972005d47"), new Guid("0b672d47-5e43-4831-b93f-139972005d47"), "+115 62 (556) 51-01", new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab") },
                    { new Guid("0b7d59e7-52b9-4d5c-9dff-5a6c70117c81"), new Guid("0b7d59e7-52b9-4d5c-9dff-5a6c70117c81"), "+506 63 (317) 45-83", new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("0b8ffbf1-d6c0-4ced-85c9-29a5e7c0faaa"), new Guid("0b8ffbf1-d6c0-4ced-85c9-29a5e7c0faaa"), "+876 71 (862) 65-79", new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("0bc15f34-2013-4d55-a16f-9f7e91c96e46"), new Guid("0bc15f34-2013-4d55-a16f-9f7e91c96e46"), "+400 69 (670) 55-81", new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("0bc536f0-450d-4056-a4ee-8f25d2dea014"), new Guid("0bc536f0-450d-4056-a4ee-8f25d2dea014"), "+679 25 (453) 43-06", new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("0bdb3771-d00e-4a81-b37b-aad0713dc758"), new Guid("0bdb3771-d00e-4a81-b37b-aad0713dc758"), "+381 88 (727) 82-17", new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("0bfc53f4-92e4-4545-8808-9ad1e22d331a"), new Guid("0bfc53f4-92e4-4545-8808-9ad1e22d331a"), "+601 28 (659) 17-28", new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374") },
                    { new Guid("0c1ebc32-3e92-43ec-9335-295fc82e24a4"), new Guid("0c1ebc32-3e92-43ec-9335-295fc82e24a4"), "+859 94 (493) 51-49", new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("0c54d5d0-a8a2-4635-b87d-1ee77c2b88d6"), new Guid("0c54d5d0-a8a2-4635-b87d-1ee77c2b88d6"), "+224 65 (618) 22-72", new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("0c90089a-bac5-413b-850d-8b0a3f1c567f"), new Guid("0c90089a-bac5-413b-850d-8b0a3f1c567f"), "+519 78 (641) 60-16", new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("0d18ad5d-df09-4776-ab14-ed8abbea6ed5"), new Guid("0d18ad5d-df09-4776-ab14-ed8abbea6ed5"), "+986 03 (658) 10-17", new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5") },
                    { new Guid("0d40d862-fec2-4fc3-8734-60cb389226a5"), new Guid("0d40d862-fec2-4fc3-8734-60cb389226a5"), "+185 52 (746) 84-76", new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("0d663b7d-7e1f-4826-abde-a57c23734fd8"), new Guid("0d663b7d-7e1f-4826-abde-a57c23734fd8"), "+392 19 (810) 40-56", new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e496f27-17c6-455f-9809-d19dbfcf9894"), new Guid("0e496f27-17c6-455f-9809-d19dbfcf9894"), "+36 43 (837) 64-09", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("0ee14bed-24de-44dc-9223-b458366ff742"), new Guid("0ee14bed-24de-44dc-9223-b458366ff742"), "+907 65 (219) 52-99", new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7") },
                    { new Guid("0f318051-020a-4f7c-abfb-497f530c8839"), new Guid("0f318051-020a-4f7c-abfb-497f530c8839"), "+227 29 (443) 54-22", new Guid("203cc97b-91be-4474-b881-e9776da21af9") },
                    { new Guid("0f98096f-277c-415c-8a3d-63eba97f6f31"), new Guid("0f98096f-277c-415c-8a3d-63eba97f6f31"), "+266 49 (931) 12-91", new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("0fcda202-4e1d-4a1a-a30c-9661423469b9"), new Guid("0fcda202-4e1d-4a1a-a30c-9661423469b9"), "+714 37 (001) 92-64", new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("103a6211-7b9c-47a7-a972-95f9e05c8d0f"), new Guid("103a6211-7b9c-47a7-a972-95f9e05c8d0f"), "+886 41 (600) 13-53", new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7") },
                    { new Guid("11a7ec14-3f8b-4116-8621-60148cdc9ba5"), new Guid("11a7ec14-3f8b-4116-8621-60148cdc9ba5"), "+637 88 (796) 01-20", new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738") },
                    { new Guid("11d149d3-1748-4407-a585-b9c2d899de1c"), new Guid("11d149d3-1748-4407-a585-b9c2d899de1c"), "+964 00 (530) 58-69", new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed") },
                    { new Guid("1202e9cd-0e98-415a-951b-11e291c3487b"), new Guid("1202e9cd-0e98-415a-951b-11e291c3487b"), "+549 18 (046) 69-19", new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("133acc9a-661c-412b-8583-39d8df78520a"), new Guid("133acc9a-661c-412b-8583-39d8df78520a"), "+599 09 (534) 53-03", new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("13917892-8343-450a-bf38-905b6b196995"), new Guid("13917892-8343-450a-bf38-905b6b196995"), "+835 12 (653) 39-27", new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("13a0dbf0-60ad-4fca-93c9-1d990ab67368"), new Guid("13a0dbf0-60ad-4fca-93c9-1d990ab67368"), "+583 52 (125) 55-40", new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("13a55818-ca9d-4c4e-8b73-128981855d27"), new Guid("13a55818-ca9d-4c4e-8b73-128981855d27"), "+807 07 (299) 83-91", new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("13ad0d61-76dc-423c-be26-62376fa289ec"), new Guid("13ad0d61-76dc-423c-be26-62376fa289ec"), "+558 81 (695) 66-81", new Guid("d21f18d0-79a0-4851-976c-b989e790eac0") },
                    { new Guid("13c47a77-8842-4090-a8c5-7e04ad5ecd3f"), new Guid("13c47a77-8842-4090-a8c5-7e04ad5ecd3f"), "+431 00 (538) 77-77", new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0") },
                    { new Guid("14a2992c-1343-42dd-b304-284a8f5c0e95"), new Guid("14a2992c-1343-42dd-b304-284a8f5c0e95"), "+401 59 (409) 57-68", new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46") },
                    { new Guid("15772945-d68b-40b9-97c0-730636b00b94"), new Guid("15772945-d68b-40b9-97c0-730636b00b94"), "+875 37 (719) 74-24", new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("1591cc12-9a85-4583-8cde-df74a6aa24cf"), new Guid("1591cc12-9a85-4583-8cde-df74a6aa24cf"), "+914 38 (602) 15-31", new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6") },
                    { new Guid("159273b1-0433-4dcf-8c9b-e22a270fc37d"), new Guid("159273b1-0433-4dcf-8c9b-e22a270fc37d"), "+910 20 (111) 33-77", new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("15f5e7ed-eaad-4728-8bfd-0195f236a9e9"), new Guid("15f5e7ed-eaad-4728-8bfd-0195f236a9e9"), "+5 95 (101) 83-65", new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("1637cbc6-1ca3-470a-99dd-76e140037f3e"), new Guid("1637cbc6-1ca3-470a-99dd-76e140037f3e"), "+163 88 (551) 87-33", new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("16f21574-2de6-44dd-a85c-ad905193bc53"), new Guid("16f21574-2de6-44dd-a85c-ad905193bc53"), "+302 42 (392) 95-74", new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("175ebfe6-194a-4a0d-b822-77945ef28478"), new Guid("175ebfe6-194a-4a0d-b822-77945ef28478"), "+842 16 (330) 47-14", new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("17733f5a-bc0d-4681-bad6-781199cb752b"), new Guid("17733f5a-bc0d-4681-bad6-781199cb752b"), "+103 24 (814) 10-84", new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("17799ac0-c877-4175-a0b5-64a770261bc6"), new Guid("17799ac0-c877-4175-a0b5-64a770261bc6"), "+491 47 (795) 70-89", new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("17862893-b16b-45f2-b892-9ab28ac297d7"), new Guid("17862893-b16b-45f2-b892-9ab28ac297d7"), "+464 20 (394) 70-64", new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("18211124-8ff5-4678-91f2-4ef13adf6f2f"), new Guid("18211124-8ff5-4678-91f2-4ef13adf6f2f"), "+409 66 (299) 50-11", new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("1872e838-ae15-445e-a237-eab447a668a8"), new Guid("1872e838-ae15-445e-a237-eab447a668a8"), "+974 66 (405) 99-07", new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("187b0459-2ffd-46b2-888a-d45af0de31db"), new Guid("187b0459-2ffd-46b2-888a-d45af0de31db"), "+416 89 (336) 13-95", new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b") },
                    { new Guid("189b61ed-6088-418a-ab48-a02673a5d7f2"), new Guid("189b61ed-6088-418a-ab48-a02673a5d7f2"), "+385 52 (105) 30-11", new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6") },
                    { new Guid("190a3b45-226a-49a0-9b2d-3a390bdafeb0"), new Guid("190a3b45-226a-49a0-9b2d-3a390bdafeb0"), "+271 26 (596) 51-88", new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7") },
                    { new Guid("1927de21-1e8e-46aa-9655-d4e366f09d67"), new Guid("1927de21-1e8e-46aa-9655-d4e366f09d67"), "+833 30 (283) 98-06", new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("1938ef57-b55d-4093-9736-427ecb34b5bb"), new Guid("1938ef57-b55d-4093-9736-427ecb34b5bb"), "+688 63 (452) 41-03", new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("194d233d-1a13-47f3-a655-f4e13361438d"), new Guid("194d233d-1a13-47f3-a655-f4e13361438d"), "+585 68 (888) 09-41", new Guid("83c8f958-a3f1-448d-bad0-048533827e0e") },
                    { new Guid("1961e1b1-0a8b-4379-9a87-995762d502ab"), new Guid("1961e1b1-0a8b-4379-9a87-995762d502ab"), "+113 81 (224) 81-11", new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("1990b19b-1fe8-42c4-8327-a6c076061c6d"), new Guid("1990b19b-1fe8-42c4-8327-a6c076061c6d"), "+775 03 (628) 37-27", new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e") },
                    { new Guid("1a3c00c3-d6bd-403b-9ff6-8cc06e071ead"), new Guid("1a3c00c3-d6bd-403b-9ff6-8cc06e071ead"), "+726 07 (759) 88-20", new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("1a8815d5-dc7b-41e4-a4be-26e076e7fe9f"), new Guid("1a8815d5-dc7b-41e4-a4be-26e076e7fe9f"), "+329 38 (806) 30-10", new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d") },
                    { new Guid("1acc09b7-6725-4626-86dc-d7610ed9eb5b"), new Guid("1acc09b7-6725-4626-86dc-d7610ed9eb5b"), "+930 06 (348) 84-67", new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("1ae61175-952d-41cf-aefe-d5aa3b91ae25"), new Guid("1ae61175-952d-41cf-aefe-d5aa3b91ae25"), "+179 64 (128) 70-37", new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0") },
                    { new Guid("1b4ee5f8-8d98-4450-9639-1972c9814389"), new Guid("1b4ee5f8-8d98-4450-9639-1972c9814389"), "+997 43 (735) 57-08", new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("1b8fd214-a128-4967-891a-9a5a88b7175f"), new Guid("1b8fd214-a128-4967-891a-9a5a88b7175f"), "+621 72 (092) 71-37", new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ba28b65-6aeb-4ad0-a1ef-effbeab6996d"), new Guid("1ba28b65-6aeb-4ad0-a1ef-effbeab6996d"), "+872 26 (319) 91-99", new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("1bcefe80-fe37-4706-af81-cc69e22580f8"), new Guid("1bcefe80-fe37-4706-af81-cc69e22580f8"), "+740 85 (080) 88-30", new Guid("8987fd2f-b286-41d7-9544-b355355a2cff") },
                    { new Guid("1c511b03-7a1b-48c3-aa6c-62e75845f163"), new Guid("1c511b03-7a1b-48c3-aa6c-62e75845f163"), "+912 88 (457) 74-95", new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("1c7d6516-b477-42b6-957a-cbc8a28787b6"), new Guid("1c7d6516-b477-42b6-957a-cbc8a28787b6"), "+367 86 (207) 04-53", new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("1cc9c29d-e4fd-41fd-8b6a-24e2c23cdd90"), new Guid("1cc9c29d-e4fd-41fd-8b6a-24e2c23cdd90"), "+81 39 (182) 28-90", new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("1ce1f90c-8653-49fc-8c1d-b7586cfdb347"), new Guid("1ce1f90c-8653-49fc-8c1d-b7586cfdb347"), "+355 91 (223) 47-12", new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("1ce3d607-a78b-413b-b5a2-3e9c03ea4bda"), new Guid("1ce3d607-a78b-413b-b5a2-3e9c03ea4bda"), "+21 94 (398) 88-41", new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("1ceb2416-d458-4856-a9ff-b41316c47368"), new Guid("1ceb2416-d458-4856-a9ff-b41316c47368"), "+320 17 (776) 24-52", new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("1d299213-ba36-48b4-ae54-64eeb9f52d10"), new Guid("1d299213-ba36-48b4-ae54-64eeb9f52d10"), "+235 34 (598) 56-86", new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("1d9a6c44-0c11-46de-a1ee-074be83e62b0"), new Guid("1d9a6c44-0c11-46de-a1ee-074be83e62b0"), "+216 00 (442) 92-47", new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("1deab6d9-574f-47d0-b18f-5a4f278e6d2b"), new Guid("1deab6d9-574f-47d0-b18f-5a4f278e6d2b"), "+177 19 (145) 65-13", new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("1df05f0f-7fa3-4361-94a2-1f2be55c2a9c"), new Guid("1df05f0f-7fa3-4361-94a2-1f2be55c2a9c"), "+12 64 (008) 66-40", new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a") },
                    { new Guid("1edb2a6c-741f-44c9-bda5-03a341104c1f"), new Guid("1edb2a6c-741f-44c9-bda5-03a341104c1f"), "+950 10 (567) 38-48", new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("1ef858d0-e0ce-421f-8cc1-f20ec6b09d97"), new Guid("1ef858d0-e0ce-421f-8cc1-f20ec6b09d97"), "+669 27 (712) 66-70", new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4") },
                    { new Guid("1f3ee37f-82ec-4b54-af32-707bf2daa87f"), new Guid("1f3ee37f-82ec-4b54-af32-707bf2daa87f"), "+626 99 (689) 15-84", new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119") },
                    { new Guid("1f9ba3f8-560d-4bb1-86aa-10c4cfed8168"), new Guid("1f9ba3f8-560d-4bb1-86aa-10c4cfed8168"), "+146 25 (399) 51-56", new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("20164b2a-f5a3-4f92-a3e5-409e64f1d2b6"), new Guid("20164b2a-f5a3-4f92-a3e5-409e64f1d2b6"), "+815 72 (779) 22-58", new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("2033ff0f-ac75-4b54-9a96-829c970a04e1"), new Guid("2033ff0f-ac75-4b54-9a96-829c970a04e1"), "+427 36 (739) 61-12", new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("2067d38f-3be7-4d8b-a7bf-38cbcbed7a3c"), new Guid("2067d38f-3be7-4d8b-a7bf-38cbcbed7a3c"), "+869 89 (532) 66-15", new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("20b41bc4-dfd5-4c5b-9097-62ed63c822b0"), new Guid("20b41bc4-dfd5-4c5b-9097-62ed63c822b0"), "+335 16 (583) 75-42", new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("2138c2ab-8512-4f3c-928b-c93fe6b061ba"), new Guid("2138c2ab-8512-4f3c-928b-c93fe6b061ba"), "+540 98 (769) 61-93", new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("2138f65c-1482-4772-a423-08fd823b437c"), new Guid("2138f65c-1482-4772-a423-08fd823b437c"), "+557 55 (124) 58-86", new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("219c411a-4a13-49a6-885b-145a44e1d26e"), new Guid("219c411a-4a13-49a6-885b-145a44e1d26e"), "+487 61 (947) 42-46", new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828") },
                    { new Guid("21ed8ef5-fcac-40eb-99b0-9f9391db4563"), new Guid("21ed8ef5-fcac-40eb-99b0-9f9391db4563"), "+418 75 (064) 60-68", new Guid("e3c6afb3-54ad-4c59-9967-9cb851a687b7") },
                    { new Guid("22232875-378f-4187-a96d-3fbd887e7f34"), new Guid("22232875-378f-4187-a96d-3fbd887e7f34"), "+82 51 (804) 94-36", new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("2298ae57-b407-48b0-9442-e86317fbf455"), new Guid("2298ae57-b407-48b0-9442-e86317fbf455"), "+898 98 (258) 31-92", new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867") },
                    { new Guid("23712962-c883-4433-a88a-55159aa2b553"), new Guid("23712962-c883-4433-a88a-55159aa2b553"), "+254 80 (261) 88-19", new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("23df9bf5-2337-4ee5-b119-67ff8c14e857"), new Guid("23df9bf5-2337-4ee5-b119-67ff8c14e857"), "+9 65 (500) 97-44", new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("23f0bdbf-615b-4cce-b12a-24be32e94dc4"), new Guid("23f0bdbf-615b-4cce-b12a-24be32e94dc4"), "+929 17 (598) 75-58", new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("2488c0d4-33f5-4753-9937-d2214141a01a"), new Guid("2488c0d4-33f5-4753-9937-d2214141a01a"), "+450 06 (256) 47-86", new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("24a4733d-f31e-4839-b7b3-ffe1112b9d35"), new Guid("24a4733d-f31e-4839-b7b3-ffe1112b9d35"), "+395 89 (120) 95-08", new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("24b6917d-1ac3-42a9-be17-1d84a3ce2801"), new Guid("24b6917d-1ac3-42a9-be17-1d84a3ce2801"), "+501 74 (479) 16-59", new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("24c21230-4ea7-4b51-8a78-54d16b740c5f"), new Guid("24c21230-4ea7-4b51-8a78-54d16b740c5f"), "+87 11 (825) 15-89", new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("24dd2be2-f79d-4fd2-974f-b411d08e8406"), new Guid("24dd2be2-f79d-4fd2-974f-b411d08e8406"), "+611 94 (643) 13-55", new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33") },
                    { new Guid("24f18d4f-75ec-42c3-89fc-01f028b03014"), new Guid("24f18d4f-75ec-42c3-89fc-01f028b03014"), "+417 85 (681) 91-87", new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("25b05150-c880-4632-ba58-adbe5ab7b95f"), new Guid("25b05150-c880-4632-ba58-adbe5ab7b95f"), "+720 74 (610) 15-42", new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("25e2d182-1091-42b4-8072-4d7ad2303e9f"), new Guid("25e2d182-1091-42b4-8072-4d7ad2303e9f"), "+854 72 (374) 98-54", new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("260a6047-ef0e-45fc-b3f7-6eafbefe2cc7"), new Guid("260a6047-ef0e-45fc-b3f7-6eafbefe2cc7"), "+662 32 (410) 03-54", new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2") },
                    { new Guid("276bca3d-3ab9-4d7d-a95c-85ff8c2c5d54"), new Guid("276bca3d-3ab9-4d7d-a95c-85ff8c2c5d54"), "+133 69 (497) 82-34", new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("27d68377-7bdc-432f-b3df-ec109d31978d"), new Guid("27d68377-7bdc-432f-b3df-ec109d31978d"), "+351 88 (696) 46-23", new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("27dde382-a549-40fc-a87f-f7bc1d670f44"), new Guid("27dde382-a549-40fc-a87f-f7bc1d670f44"), "+179 56 (173) 25-96", new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("288b7a89-dc2f-49ec-8659-8e4f114872c5"), new Guid("288b7a89-dc2f-49ec-8659-8e4f114872c5"), "+724 93 (137) 41-43", new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("2896ab7f-9c3f-407c-980c-68a0bcfa4230"), new Guid("2896ab7f-9c3f-407c-980c-68a0bcfa4230"), "+432 57 (049) 76-23", new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("29304da1-936d-4440-bf8b-2ff02d9cb88e"), new Guid("29304da1-936d-4440-bf8b-2ff02d9cb88e"), "+153 97 (136) 42-85", new Guid("d422e4b4-5d7b-484f-830c-319350a69b22") },
                    { new Guid("2946fa4e-d6d7-44eb-af00-7dc3d7c8f9c9"), new Guid("2946fa4e-d6d7-44eb-af00-7dc3d7c8f9c9"), "+399 93 (729) 16-39", new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("2960096b-cc28-4374-98f6-5428d1fc88aa"), new Guid("2960096b-cc28-4374-98f6-5428d1fc88aa"), "+702 30 (467) 63-69", new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("29dbb999-18dc-45ff-966a-fab6c13bb89f"), new Guid("29dbb999-18dc-45ff-966a-fab6c13bb89f"), "+19 40 (188) 13-32", new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("29ecb0e6-ac51-47f9-974b-19c90b018ff4"), new Guid("29ecb0e6-ac51-47f9-974b-19c90b018ff4"), "+424 32 (567) 45-61", new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59") },
                    { new Guid("2a8e3746-8cf8-4481-8cd3-d5dfe437e91c"), new Guid("2a8e3746-8cf8-4481-8cd3-d5dfe437e91c"), "+991 95 (237) 17-76", new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("2aa9f61a-9191-461f-8979-e11e0c6c25dc"), new Guid("2aa9f61a-9191-461f-8979-e11e0c6c25dc"), "+680 68 (517) 76-28", new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("2aaac248-e39d-4ce0-9ac1-1c43421c0c6c"), new Guid("2aaac248-e39d-4ce0-9ac1-1c43421c0c6c"), "+705 12 (642) 45-50", new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("2aaca1f2-73b4-4a37-ad92-938395f70375"), new Guid("2aaca1f2-73b4-4a37-ad92-938395f70375"), "+242 92 (332) 65-03", new Guid("c76fa928-e52c-4386-9917-2e5650ff4b03") },
                    { new Guid("2aea2f8c-8344-4d66-88f3-34069b6915aa"), new Guid("2aea2f8c-8344-4d66-88f3-34069b6915aa"), "+284 65 (365) 34-44", new Guid("e5acadcd-43bb-4225-9367-f562e86197e5") },
                    { new Guid("2aec4540-b158-4082-98b5-a0080165c8fd"), new Guid("2aec4540-b158-4082-98b5-a0080165c8fd"), "+548 62 (517) 93-70", new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("2af7610b-2702-40a5-9562-8119f1c03a9d"), new Guid("2af7610b-2702-40a5-9562-8119f1c03a9d"), "+328 40 (311) 60-54", new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674") },
                    { new Guid("2b1179de-8cc5-435f-b180-0f33af18aaeb"), new Guid("2b1179de-8cc5-435f-b180-0f33af18aaeb"), "+768 99 (091) 36-94", new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("2b29ce46-1375-4ce5-a79a-2c30343580cf"), new Guid("2b29ce46-1375-4ce5-a79a-2c30343580cf"), "+663 10 (376) 51-05", new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574") },
                    { new Guid("2b457fe1-ccdc-448b-b4b7-a4599e216a75"), new Guid("2b457fe1-ccdc-448b-b4b7-a4599e216a75"), "+331 28 (412) 68-22", new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("2bd3347b-f594-478f-8652-a634ff1867b2"), new Guid("2bd3347b-f594-478f-8652-a634ff1867b2"), "+492 14 (588) 18-76", new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("2bf289df-78bb-400c-8ae9-c9569bdb7eba"), new Guid("2bf289df-78bb-400c-8ae9-c9569bdb7eba"), "+645 81 (553) 11-36", new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("2c5e776e-316f-4ba9-a2f3-196d178c821f"), new Guid("2c5e776e-316f-4ba9-a2f3-196d178c821f"), "+768 91 (720) 67-49", new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("2c840800-9081-46a5-bb25-bb7f00386665"), new Guid("2c840800-9081-46a5-bb25-bb7f00386665"), "+185 88 (412) 74-84", new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("2d48d899-0d3f-4eb1-82b7-42343a4e8400"), new Guid("2d48d899-0d3f-4eb1-82b7-42343a4e8400"), "+141 23 (051) 50-83", new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("2d70ddd1-4333-496b-86d7-a90d025bf5b8"), new Guid("2d70ddd1-4333-496b-86d7-a90d025bf5b8"), "+458 80 (338) 20-38", new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("2d7bc6b6-53cb-43bf-8c73-8f9cdc32dc8b"), new Guid("2d7bc6b6-53cb-43bf-8c73-8f9cdc32dc8b"), "+90 84 (826) 69-80", new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("2eead879-0c52-465d-b811-cefa8518aa13"), new Guid("2eead879-0c52-465d-b811-cefa8518aa13"), "+82 28 (777) 74-64", new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5") },
                    { new Guid("2f4772d3-db3d-4aa9-b570-a282af175973"), new Guid("2f4772d3-db3d-4aa9-b570-a282af175973"), "+821 59 (143) 31-36", new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("2fc739f8-6e5a-4c40-b171-e6fdc31712e2"), new Guid("2fc739f8-6e5a-4c40-b171-e6fdc31712e2"), "+555 69 (156) 76-42", new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("2ff8fb85-a777-4c9f-bf76-c6f5c20c926c"), new Guid("2ff8fb85-a777-4c9f-bf76-c6f5c20c926c"), "+442 29 (807) 40-44", new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("3039210b-f16a-4b36-a183-cec12a72540e"), new Guid("3039210b-f16a-4b36-a183-cec12a72540e"), "+522 18 (355) 21-81", new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("309cfb61-279d-49d6-9afa-b8b85376e836"), new Guid("309cfb61-279d-49d6-9afa-b8b85376e836"), "+832 12 (057) 72-75", new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("30d04773-ed12-46e9-ac6e-523d62dc3f69"), new Guid("30d04773-ed12-46e9-ac6e-523d62dc3f69"), "+538 98 (423) 87-51", new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("30d090cc-8795-4874-888c-dc3facf8b108"), new Guid("30d090cc-8795-4874-888c-dc3facf8b108"), "+920 98 (045) 22-38", new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("314a0058-82b8-4995-8b0e-6be5cf9d795e"), new Guid("314a0058-82b8-4995-8b0e-6be5cf9d795e"), "+430 49 (575) 13-87", new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("31a620f1-816f-4ca6-8377-583c69ae5572"), new Guid("31a620f1-816f-4ca6-8377-583c69ae5572"), "+613 87 (783) 21-49", new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("321bde1d-1e14-46a9-8f19-1b4ef6047c80"), new Guid("321bde1d-1e14-46a9-8f19-1b4ef6047c80"), "+974 93 (269) 01-21", new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("324126e2-466a-4560-8bcf-25bc1849a04f"), new Guid("324126e2-466a-4560-8bcf-25bc1849a04f"), "+165 97 (239) 31-80", new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("3259ecb4-83ce-483f-9f94-7ba5ce626af6"), new Guid("3259ecb4-83ce-483f-9f94-7ba5ce626af6"), "+925 42 (914) 66-21", new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131") },
                    { new Guid("32adb246-bca6-4930-aab7-abfe25a78b88"), new Guid("32adb246-bca6-4930-aab7-abfe25a78b88"), "+778 91 (247) 78-54", new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("3326c6ed-4fba-4c52-922e-70ae11332c8b"), new Guid("3326c6ed-4fba-4c52-922e-70ae11332c8b"), "+592 69 (613) 64-20", new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("33de32ba-b21f-4661-a74d-355c2563c55f"), new Guid("33de32ba-b21f-4661-a74d-355c2563c55f"), "+433 96 (234) 61-36", new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("33e4d536-5f8f-459e-b5da-414030d8bacf"), new Guid("33e4d536-5f8f-459e-b5da-414030d8bacf"), "+327 65 (408) 40-11", new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("34376b69-18cc-4139-bd4c-bc401fbba6d6"), new Guid("34376b69-18cc-4139-bd4c-bc401fbba6d6"), "+642 29 (923) 18-62", new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("3477fdcc-34c9-48f7-922c-dd58ea190c42"), new Guid("3477fdcc-34c9-48f7-922c-dd58ea190c42"), "+741 52 (051) 54-29", new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("34c19c13-77d8-4241-8782-491edee686e1"), new Guid("34c19c13-77d8-4241-8782-491edee686e1"), "+803 47 (283) 59-48", new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa") },
                    { new Guid("34f60d49-2ccd-49d9-a3fc-733e4c01da24"), new Guid("34f60d49-2ccd-49d9-a3fc-733e4c01da24"), "+365 48 (669) 42-47", new Guid("f32288b6-da6b-4bef-b134-fd7be2f18a59") },
                    { new Guid("3533dc8f-fc7b-43f1-99bd-612e5768f424"), new Guid("3533dc8f-fc7b-43f1-99bd-612e5768f424"), "+152 22 (151) 00-37", new Guid("71725c06-aded-4994-8181-26d1683597c4") },
                    { new Guid("35575e1b-be77-41eb-9088-3a4ee01c1070"), new Guid("35575e1b-be77-41eb-9088-3a4ee01c1070"), "+604 52 (450) 47-55", new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("3564c537-4931-42a8-a263-0b66e64280f3"), new Guid("3564c537-4931-42a8-a263-0b66e64280f3"), "+174 18 (832) 96-39", new Guid("8b3ae855-3f1f-409d-8898-00767477ffae") },
                    { new Guid("356f643c-c1ba-425b-9050-460d5bd4f028"), new Guid("356f643c-c1ba-425b-9050-460d5bd4f028"), "+379 11 (756) 49-20", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("35882aa0-c5b3-4bb6-846e-34aa07251546"), new Guid("35882aa0-c5b3-4bb6-846e-34aa07251546"), "+457 45 (252) 79-54", new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("3601b932-5e08-4413-995e-d712ae3deefe"), new Guid("3601b932-5e08-4413-995e-d712ae3deefe"), "+363 41 (313) 49-19", new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("36319a06-9503-4721-9b9e-588730713447"), new Guid("36319a06-9503-4721-9b9e-588730713447"), "+158 37 (371) 06-80", new Guid("ab6dd0fe-e4dd-4dbb-bfe7-da46b6d184b0") },
                    { new Guid("36820a07-72ca-4de0-9cae-e67a8e5c3c98"), new Guid("36820a07-72ca-4de0-9cae-e67a8e5c3c98"), "+504 60 (887) 87-68", new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("37ad52c7-9dde-4483-8475-c04cf9477df3"), new Guid("37ad52c7-9dde-4483-8475-c04cf9477df3"), "+733 86 (040) 06-81", new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1") },
                    { new Guid("38161f67-a18c-4dd4-a255-f3693fd9c2f8"), new Guid("38161f67-a18c-4dd4-a255-f3693fd9c2f8"), "+350 17 (569) 48-57", new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("381ef829-2f09-4fe8-9128-7c54d7f92edf"), new Guid("381ef829-2f09-4fe8-9128-7c54d7f92edf"), "+492 29 (453) 39-70", new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("38fc48e0-15d8-431c-9c09-e92c3b48dab1"), new Guid("38fc48e0-15d8-431c-9c09-e92c3b48dab1"), "+865 55 (006) 62-30", new Guid("c8ad8daf-acdf-4acf-9265-518ccf856d96") },
                    { new Guid("396462d4-510f-4cc9-ba99-5051165775ff"), new Guid("396462d4-510f-4cc9-ba99-5051165775ff"), "+380 94 (261) 21-30", new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037") },
                    { new Guid("3967654c-432a-4c8a-86a0-7600b297908e"), new Guid("3967654c-432a-4c8a-86a0-7600b297908e"), "+512 54 (004) 00-23", new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("39dab8d9-919d-46fe-b5ef-4dbf75230500"), new Guid("39dab8d9-919d-46fe-b5ef-4dbf75230500"), "+637 23 (582) 01-10", new Guid("d21f18d0-79a0-4851-976c-b989e790eac0") },
                    { new Guid("3a2a892d-9e14-4596-be32-64d7e63f8dc9"), new Guid("3a2a892d-9e14-4596-be32-64d7e63f8dc9"), "+49 96 (304) 87-55", new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("3ab18ea1-bae7-48b5-b33d-8098034c9eb5"), new Guid("3ab18ea1-bae7-48b5-b33d-8098034c9eb5"), "+78 58 (087) 47-39", new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("3adb9198-c25c-4c43-91ab-593de2947be0"), new Guid("3adb9198-c25c-4c43-91ab-593de2947be0"), "+700 39 (062) 87-20", new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("3ae69c35-58b9-48c2-b3b4-3f1711b00ea1"), new Guid("3ae69c35-58b9-48c2-b3b4-3f1711b00ea1"), "+565 23 (410) 96-89", new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("3af7b420-7b5e-4903-88bf-ea27b579dc59"), new Guid("3af7b420-7b5e-4903-88bf-ea27b579dc59"), "+392 67 (468) 32-16", new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("3b1ba8b4-c1d5-46be-a53f-24afd32dd662"), new Guid("3b1ba8b4-c1d5-46be-a53f-24afd32dd662"), "+891 40 (804) 52-32", new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("3b2dedbe-b887-4594-add3-2493fc71d8a9"), new Guid("3b2dedbe-b887-4594-add3-2493fc71d8a9"), "+811 97 (836) 52-72", new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272") },
                    { new Guid("3b694988-c755-4b5e-b41a-0bff3be1d008"), new Guid("3b694988-c755-4b5e-b41a-0bff3be1d008"), "+201 05 (598) 68-13", new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4") },
                    { new Guid("3bb342c5-10b1-4b25-86d1-8f03a804e746"), new Guid("3bb342c5-10b1-4b25-86d1-8f03a804e746"), "+647 03 (481) 95-83", new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("3be9da5d-512b-455e-b7a1-0d45d2efbf9e"), new Guid("3be9da5d-512b-455e-b7a1-0d45d2efbf9e"), "+921 89 (455) 28-92", new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("3c2ed640-c5f7-4c18-9454-2b262d19da71"), new Guid("3c2ed640-c5f7-4c18-9454-2b262d19da71"), "+316 64 (470) 69-20", new Guid("ab1a420e-ca07-4cc7-b060-1de973571ff4") },
                    { new Guid("3ddd0c13-8faf-45ba-809b-2750762acf8c"), new Guid("3ddd0c13-8faf-45ba-809b-2750762acf8c"), "+354 03 (412) 04-41", new Guid("314374c4-1bd7-4eda-8546-58617e464254") },
                    { new Guid("3f3b8205-1ac5-486c-b400-09d915bbfbc5"), new Guid("3f3b8205-1ac5-486c-b400-09d915bbfbc5"), "+636 66 (608) 01-98", new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("3f46e218-a431-4901-a50d-9a97ca8c63a9"), new Guid("3f46e218-a431-4901-a50d-9a97ca8c63a9"), "+528 33 (083) 00-40", new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("3f6058fe-b100-4c82-98f8-24d930b25fbd"), new Guid("3f6058fe-b100-4c82-98f8-24d930b25fbd"), "+315 83 (222) 36-31", new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869") },
                    { new Guid("3f7e8aab-4bde-491d-9272-20f0ae7298b0"), new Guid("3f7e8aab-4bde-491d-9272-20f0ae7298b0"), "+948 15 (030) 43-75", new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("3fc39c40-b782-4af2-b058-8282df471ab7"), new Guid("3fc39c40-b782-4af2-b058-8282df471ab7"), "+647 69 (198) 84-93", new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("3fe5d6ed-28e7-42a2-ba49-cd3e4c16d03b"), new Guid("3fe5d6ed-28e7-42a2-ba49-cd3e4c16d03b"), "+489 02 (710) 87-92", new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("3fe603c0-e515-4afb-9a90-5ac69a676749"), new Guid("3fe603c0-e515-4afb-9a90-5ac69a676749"), "+497 75 (128) 54-76", new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("4004e7f7-e4f4-466b-9fd3-d2ef01ae23e8"), new Guid("4004e7f7-e4f4-466b-9fd3-d2ef01ae23e8"), "+993 57 (238) 94-18", new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861") },
                    { new Guid("40085083-5257-4f81-9e66-73aa411691f4"), new Guid("40085083-5257-4f81-9e66-73aa411691f4"), "+526 16 (834) 25-24", new Guid("84c9bfbb-949d-4fdc-9354-dfb70135db7c") },
                    { new Guid("4060db35-88c8-4dd6-b359-97286906b43c"), new Guid("4060db35-88c8-4dd6-b359-97286906b43c"), "+188 99 (359) 53-40", new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("4084e031-ee6c-4fd0-86db-d1388cf9c614"), new Guid("4084e031-ee6c-4fd0-86db-d1388cf9c614"), "+285 78 (549) 41-52", new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("40e97041-4a07-46a2-a7d8-edc0b18dc8ce"), new Guid("40e97041-4a07-46a2-a7d8-edc0b18dc8ce"), "+266 04 (369) 45-18", new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("41db8009-6fb3-4979-aff4-488248f834bb"), new Guid("41db8009-6fb3-4979-aff4-488248f834bb"), "+825 75 (995) 93-74", new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("42cf1f0c-aa2d-40b9-b862-823e369c2042"), new Guid("42cf1f0c-aa2d-40b9-b862-823e369c2042"), "+87 53 (967) 98-82", new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718") },
                    { new Guid("42dc1389-986c-4565-9574-f8e42743ebed"), new Guid("42dc1389-986c-4565-9574-f8e42743ebed"), "+836 78 (723) 79-43", new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("4341c423-8ec7-4a62-b99e-4a6daa8b2519"), new Guid("4341c423-8ec7-4a62-b99e-4a6daa8b2519"), "+579 50 (244) 88-98", new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("4395e0cb-b3b8-4f2d-b548-79262efde5a3"), new Guid("4395e0cb-b3b8-4f2d-b548-79262efde5a3"), "+518 47 (975) 45-43", new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("43bd44f5-19f2-481e-830e-cab58a88ce33"), new Guid("43bd44f5-19f2-481e-830e-cab58a88ce33"), "+631 64 (530) 87-31", new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("43fc0d29-89e2-45cd-a4e9-4262bb37ff40"), new Guid("43fc0d29-89e2-45cd-a4e9-4262bb37ff40"), "+520 25 (437) 13-34", new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("448801e8-c16b-4244-ab8f-960ebeda774e"), new Guid("448801e8-c16b-4244-ab8f-960ebeda774e"), "+385 53 (300) 17-57", new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("448efbad-e53a-4a12-bbe8-3f6f4fc28882"), new Guid("448efbad-e53a-4a12-bbe8-3f6f4fc28882"), "+627 16 (469) 65-88", new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("44a0897d-cbdd-4ca9-98fd-3c3dd7fdd24b"), new Guid("44a0897d-cbdd-4ca9-98fd-3c3dd7fdd24b"), "+776 42 (742) 09-97", new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425") },
                    { new Guid("44a0ca33-4a21-4ec3-b0cb-b1a146208a72"), new Guid("44a0ca33-4a21-4ec3-b0cb-b1a146208a72"), "+536 23 (323) 00-38", new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("44d4992d-875a-46b0-9618-d1eb2f768cb0"), new Guid("44d4992d-875a-46b0-9618-d1eb2f768cb0"), "+795 04 (920) 02-86", new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("457a87fe-51fe-4c7e-934a-f5b1067f3e2c"), new Guid("457a87fe-51fe-4c7e-934a-f5b1067f3e2c"), "+99 83 (261) 75-80", new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("460e4bdd-e660-4583-b30b-3cdd3e3b2956"), new Guid("460e4bdd-e660-4583-b30b-3cdd3e3b2956"), "+376 19 (617) 46-60", new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("46464591-dbd9-4654-b75d-9fc29da2fe14"), new Guid("46464591-dbd9-4654-b75d-9fc29da2fe14"), "+576 46 (465) 72-07", new Guid("08e83522-0abb-4778-9027-c86ca1a0a624") },
                    { new Guid("46649331-5ea9-434a-82dc-f6fa3d9fb940"), new Guid("46649331-5ea9-434a-82dc-f6fa3d9fb940"), "+942 84 (226) 59-74", new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("46da91a3-726e-4fd8-8189-7375938b4f04"), new Guid("46da91a3-726e-4fd8-8189-7375938b4f04"), "+925 80 (720) 76-99", new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("471e15a0-0cad-42d3-80e3-a87a672ec896"), new Guid("471e15a0-0cad-42d3-80e3-a87a672ec896"), "+893 38 (010) 77-97", new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("478533bf-964e-4ed0-aa92-1f14db99c4c8"), new Guid("478533bf-964e-4ed0-aa92-1f14db99c4c8"), "+290 27 (055) 05-78", new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("47f2c860-74ac-4681-bddd-8fd47d8c0a2c"), new Guid("47f2c860-74ac-4681-bddd-8fd47d8c0a2c"), "+985 53 (988) 21-03", new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("485c00b1-5ec6-4a62-976e-daa3899ddb91"), new Guid("485c00b1-5ec6-4a62-976e-daa3899ddb91"), "+953 25 (758) 46-50", new Guid("f7720de3-aaea-48e9-af48-569af731d90b") },
                    { new Guid("48be39be-3b9f-4df5-82a7-2259ba91214c"), new Guid("48be39be-3b9f-4df5-82a7-2259ba91214c"), "+603 34 (063) 05-08", new Guid("bf306dc7-4880-432b-92d9-c8bdb0c41867") },
                    { new Guid("48f0c936-5322-4b86-9660-0613cd771062"), new Guid("48f0c936-5322-4b86-9660-0613cd771062"), "+716 79 (131) 77-22", new Guid("f5ae72c1-56fd-4339-82b1-07fa9ff9f816") },
                    { new Guid("494eb787-0820-46c1-b629-898a523b0a6b"), new Guid("494eb787-0820-46c1-b629-898a523b0a6b"), "+778 21 (984) 19-90", new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("499a99c1-aeb3-4294-ae2e-d07075b06839"), new Guid("499a99c1-aeb3-4294-ae2e-d07075b06839"), "+262 16 (935) 32-24", new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("49a83dca-1d2a-4763-b047-eae65713b91d"), new Guid("49a83dca-1d2a-4763-b047-eae65713b91d"), "+139 01 (089) 38-90", new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("49b7c912-dbaa-444a-890c-f9077c8f4cca"), new Guid("49b7c912-dbaa-444a-890c-f9077c8f4cca"), "+577 26 (806) 31-68", new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7") },
                    { new Guid("4a37e250-946f-4c8c-ab63-8f0268109754"), new Guid("4a37e250-946f-4c8c-ab63-8f0268109754"), "+223 44 (679) 80-66", new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("4ac5b517-e0cb-487f-983a-115fc879e749"), new Guid("4ac5b517-e0cb-487f-983a-115fc879e749"), "+124 90 (275) 03-04", new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("4b0ec220-a014-45df-a427-48c0921132fe"), new Guid("4b0ec220-a014-45df-a427-48c0921132fe"), "+923 17 (658) 74-46", new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6") },
                    { new Guid("4b38f44c-292e-4a9d-8255-336a7b333da7"), new Guid("4b38f44c-292e-4a9d-8255-336a7b333da7"), "+137 77 (762) 31-39", new Guid("df227600-6242-4f6e-9d3d-ff59017a25f2") },
                    { new Guid("4b4d9aae-de86-4318-a201-1b8fe8b39d0c"), new Guid("4b4d9aae-de86-4318-a201-1b8fe8b39d0c"), "+123 60 (425) 89-15", new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("4c2a5f66-8624-42e0-b1c9-6ea3ad13aa9c"), new Guid("4c2a5f66-8624-42e0-b1c9-6ea3ad13aa9c"), "+116 71 (688) 07-88", new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("4c96cef7-4776-4d60-825a-150a6896f6d2"), new Guid("4c96cef7-4776-4d60-825a-150a6896f6d2"), "+889 95 (341) 85-94", new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65") },
                    { new Guid("4d248155-b0bc-4b87-9959-eea53734013a"), new Guid("4d248155-b0bc-4b87-9959-eea53734013a"), "+387 48 (037) 70-79", new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("4d3a906a-ff87-42b1-b8ae-b66f4dded5a9"), new Guid("4d3a906a-ff87-42b1-b8ae-b66f4dded5a9"), "+504 26 (945) 08-82", new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305") },
                    { new Guid("4d54de41-37b3-4e55-b83b-2a4647e47b2a"), new Guid("4d54de41-37b3-4e55-b83b-2a4647e47b2a"), "+85 91 (225) 36-34", new Guid("beb82ab5-e611-40b2-82b9-1de5e7e3f674") },
                    { new Guid("4d71a8ba-1ec3-4a60-a182-4307fff9af3e"), new Guid("4d71a8ba-1ec3-4a60-a182-4307fff9af3e"), "+121 84 (421) 45-03", new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("4d9a8309-43e0-4358-bc54-0be1548ba60c"), new Guid("4d9a8309-43e0-4358-bc54-0be1548ba60c"), "+308 58 (163) 13-87", new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376") },
                    { new Guid("4dc37eea-82df-4725-b307-4210c656f51f"), new Guid("4dc37eea-82df-4725-b307-4210c656f51f"), "+393 75 (123) 12-16", new Guid("2a0d61d4-8b10-4ddf-91a3-56c134f37869") },
                    { new Guid("4e24d65d-635a-4632-a0c3-51758626689f"), new Guid("4e24d65d-635a-4632-a0c3-51758626689f"), "+188 26 (573) 05-24", new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("4ebed283-3d2f-496b-9f4c-83cf1d6fe361"), new Guid("4ebed283-3d2f-496b-9f4c-83cf1d6fe361"), "+617 20 (016) 32-80", new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("4f1f2078-f34b-448b-ba42-1c71a464a8a8"), new Guid("4f1f2078-f34b-448b-ba42-1c71a464a8a8"), "+519 60 (551) 04-34", new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("4faa2522-e28d-4c0b-b5f4-c9cfc96ab411"), new Guid("4faa2522-e28d-4c0b-b5f4-c9cfc96ab411"), "+451 57 (169) 27-55", new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("4ffeabb8-d916-4236-8019-22cf2961d178"), new Guid("4ffeabb8-d916-4236-8019-22cf2961d178"), "+381 55 (869) 80-93", new Guid("665af7ab-85d3-48f3-bedd-30db54699f81") },
                    { new Guid("509075a8-e5f6-41d3-a99b-e38c3466fc2e"), new Guid("509075a8-e5f6-41d3-a99b-e38c3466fc2e"), "+61 06 (658) 42-36", new Guid("33d5b081-5c0f-4871-905f-631caba91848") },
                    { new Guid("50a1d71f-ed07-4da6-ac3e-89bee10c1871"), new Guid("50a1d71f-ed07-4da6-ac3e-89bee10c1871"), "+584 68 (731) 16-92", new Guid("86555a53-2ae1-40b3-98c6-17036425dac8") },
                    { new Guid("52c1cd59-1b27-4c91-b2e9-bda7a7aac518"), new Guid("52c1cd59-1b27-4c91-b2e9-bda7a7aac518"), "+996 28 (696) 51-21", new Guid("a00fcae6-79bd-4b5f-9bd4-b5ed6fbbb3c6") },
                    { new Guid("52db623d-83b0-402d-abdc-b5fc428b890f"), new Guid("52db623d-83b0-402d-abdc-b5fc428b890f"), "+845 91 (288) 06-31", new Guid("51bb4ed8-3860-4377-a5c7-5b597a15a305") },
                    { new Guid("52fd50e9-bd14-471a-8840-4ec4fff9b3f9"), new Guid("52fd50e9-bd14-471a-8840-4ec4fff9b3f9"), "+897 97 (343) 32-93", new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("531fd9c3-ba4a-4fb1-8d7d-9f7378b6d298"), new Guid("531fd9c3-ba4a-4fb1-8d7d-9f7378b6d298"), "+272 70 (048) 85-46", new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("5342b6df-d8a5-4525-8e14-400d5f90f697"), new Guid("5342b6df-d8a5-4525-8e14-400d5f90f697"), "+124 65 (325) 06-19", new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("5349c6ed-ce21-44b5-99d8-2c7262166b2b"), new Guid("5349c6ed-ce21-44b5-99d8-2c7262166b2b"), "+839 93 (552) 95-43", new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("542a2112-004f-44df-970b-0fa35a7613bd"), new Guid("542a2112-004f-44df-970b-0fa35a7613bd"), "+131 43 (429) 50-05", new Guid("1faae975-e6bb-441f-b25f-ce2c303a0405") },
                    { new Guid("54966e1c-2777-41fd-8e11-5dc31a61a04a"), new Guid("54966e1c-2777-41fd-8e11-5dc31a61a04a"), "+791 97 (314) 13-51", new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("54bbb221-5d58-499d-87bd-24f9190c1683"), new Guid("54bbb221-5d58-499d-87bd-24f9190c1683"), "+232 10 (977) 01-00", new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c") },
                    { new Guid("556ead5a-9e53-4ab4-9b41-fe33cf34a03c"), new Guid("556ead5a-9e53-4ab4-9b41-fe33cf34a03c"), "+473 23 (955) 30-67", new Guid("5628e432-15ce-47d8-a68c-52140a3a6a9e") },
                    { new Guid("557ef755-538f-4ddd-b14b-d5d372807bea"), new Guid("557ef755-538f-4ddd-b14b-d5d372807bea"), "+174 25 (414) 14-35", new Guid("3b9511f8-77ec-45af-9e3a-59c14df8f272") },
                    { new Guid("55d7630d-2c3e-4a66-a658-e68c4de4d5c1"), new Guid("55d7630d-2c3e-4a66-a658-e68c4de4d5c1"), "+484 69 (625) 67-04", new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6") },
                    { new Guid("55dd4dd7-530a-46e1-bf75-9938b4c7951e"), new Guid("55dd4dd7-530a-46e1-bf75-9938b4c7951e"), "+195 68 (399) 21-76", new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("55f06e8a-e544-481f-914d-dd9acee7547a"), new Guid("55f06e8a-e544-481f-914d-dd9acee7547a"), "+530 59 (837) 41-03", new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("56057a7f-6f07-4763-9659-e73add2ac7b9"), new Guid("56057a7f-6f07-4763-9659-e73add2ac7b9"), "+965 19 (553) 75-02", new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473") },
                    { new Guid("5700dc2b-d2ef-4413-a617-751bb3b21af8"), new Guid("5700dc2b-d2ef-4413-a617-751bb3b21af8"), "+149 45 (428) 08-38", new Guid("f825bff2-881f-450b-a4b7-56931951c54c") },
                    { new Guid("57c10860-c54e-4158-8433-040aa0c9b3f1"), new Guid("57c10860-c54e-4158-8433-040aa0c9b3f1"), "+471 54 (888) 92-01", new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("57cd38ed-60a9-4b7d-9c47-6716ca934c21"), new Guid("57cd38ed-60a9-4b7d-9c47-6716ca934c21"), "+652 31 (120) 92-55", new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("5855640c-4e2a-4ebf-866a-850c8cf64e2f"), new Guid("5855640c-4e2a-4ebf-866a-850c8cf64e2f"), "+872 07 (920) 53-34", new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("58e5a618-92b8-40ae-923b-a982b92ab268"), new Guid("58e5a618-92b8-40ae-923b-a982b92ab268"), "+200 66 (749) 59-82", new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("596ce648-bc0c-49dd-a335-d686c34182ef"), new Guid("596ce648-bc0c-49dd-a335-d686c34182ef"), "+211 56 (873) 58-92", new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("59ce95b2-459f-407a-bf9b-6be48cfb3dec"), new Guid("59ce95b2-459f-407a-bf9b-6be48cfb3dec"), "+200 36 (208) 86-07", new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("59e6b4d7-efc2-4faa-974f-73b5e341a0ac"), new Guid("59e6b4d7-efc2-4faa-974f-73b5e341a0ac"), "+898 58 (776) 14-02", new Guid("a11d6609-e768-4189-bd78-5b34d82849e6") },
                    { new Guid("5a2192f4-2735-4eab-8652-dc3ec32d81e0"), new Guid("5a2192f4-2735-4eab-8652-dc3ec32d81e0"), "+86 75 (810) 40-28", new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("5a5afe43-5c69-460c-b907-69287b93eba2"), new Guid("5a5afe43-5c69-460c-b907-69287b93eba2"), "+493 13 (329) 88-33", new Guid("0136c022-fcf1-47a8-a481-723709054ce0") },
                    { new Guid("5a825452-f2c3-4d6a-84c8-798b1641f88c"), new Guid("5a825452-f2c3-4d6a-84c8-798b1641f88c"), "+536 11 (794) 03-97", new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("5ad6db67-8597-411e-a64c-2bbe1311e2f3"), new Guid("5ad6db67-8597-411e-a64c-2bbe1311e2f3"), "+363 53 (102) 95-04", new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("5afb7577-4024-48bd-a32f-1cc99bebe900"), new Guid("5afb7577-4024-48bd-a32f-1cc99bebe900"), "+980 47 (701) 19-00", new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("5b28540a-5b96-4249-907c-e8810590cc74"), new Guid("5b28540a-5b96-4249-907c-e8810590cc74"), "+549 97 (146) 20-00", new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("5b97aed9-eddb-4620-812e-4b4e2b3fd56d"), new Guid("5b97aed9-eddb-4620-812e-4b4e2b3fd56d"), "+577 14 (067) 92-13", new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("5bc3a04a-79df-4a7e-a339-beb82b1d7701"), new Guid("5bc3a04a-79df-4a7e-a339-beb82b1d7701"), "+429 52 (209) 63-74", new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("5bf5b2b4-2dbc-40aa-83c7-101af798ea68"), new Guid("5bf5b2b4-2dbc-40aa-83c7-101af798ea68"), "+674 82 (910) 77-54", new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("5c6c09b7-4241-4b89-92e1-c5a2367bd77d"), new Guid("5c6c09b7-4241-4b89-92e1-c5a2367bd77d"), "+182 66 (118) 41-03", new Guid("a4d580d7-2bcf-4e46-a2a5-906f4d1075d2") },
                    { new Guid("5c75e81e-6c8c-4e9c-83f2-86ae6da753ce"), new Guid("5c75e81e-6c8c-4e9c-83f2-86ae6da753ce"), "+701 58 (273) 67-27", new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("5c89423f-b4c9-411c-9d84-4c8a4925b3a6"), new Guid("5c89423f-b4c9-411c-9d84-4c8a4925b3a6"), "+935 37 (201) 25-25", new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("5cb9c295-e50f-4878-b917-5a0d709b9ef9"), new Guid("5cb9c295-e50f-4878-b917-5a0d709b9ef9"), "+312 08 (130) 09-69", new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("5dcac3e9-3fe5-4fef-9f37-2a3a5f0d2bf2"), new Guid("5dcac3e9-3fe5-4fef-9f37-2a3a5f0d2bf2"), "+583 35 (779) 88-63", new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("5e974e9c-4438-4395-ac68-ea4cadaad887"), new Guid("5e974e9c-4438-4395-ac68-ea4cadaad887"), "+388 28 (625) 96-47", new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ea1afc2-7798-4634-9f38-fa09f24c4b82"), new Guid("5ea1afc2-7798-4634-9f38-fa09f24c4b82"), "+810 80 (597) 24-43", new Guid("ececce7b-505c-4bc7-b969-56ffcc451462") },
                    { new Guid("5f3ba728-1e56-4055-be7d-2143fa9df7ea"), new Guid("5f3ba728-1e56-4055-be7d-2143fa9df7ea"), "+14 94 (852) 11-38", new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("5f6ff094-c9fd-4842-9eb3-9977dc7338a2"), new Guid("5f6ff094-c9fd-4842-9eb3-9977dc7338a2"), "+365 18 (742) 75-50", new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("60202319-8c7f-4477-826e-adf08ecaa455"), new Guid("60202319-8c7f-4477-826e-adf08ecaa455"), "+119 40 (660) 56-68", new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("6022638c-1116-47a1-96f2-eabd131b33c3"), new Guid("6022638c-1116-47a1-96f2-eabd131b33c3"), "+496 79 (575) 52-85", new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("60af7e25-67f0-447b-8a17-01c6e4eebf21"), new Guid("60af7e25-67f0-447b-8a17-01c6e4eebf21"), "+912 68 (380) 79-77", new Guid("0462fe55-138a-4c03-a20d-8251dee6c206") },
                    { new Guid("60f467a9-b9d0-4cbc-9db6-a8275608b3e9"), new Guid("60f467a9-b9d0-4cbc-9db6-a8275608b3e9"), "+846 84 (253) 84-61", new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("614bda86-c8d6-4d10-9376-c2b0d4248f1f"), new Guid("614bda86-c8d6-4d10-9376-c2b0d4248f1f"), "+277 09 (187) 25-65", new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("61ef3f53-6e02-43c7-931d-cf83fbd4e2ac"), new Guid("61ef3f53-6e02-43c7-931d-cf83fbd4e2ac"), "+747 47 (102) 28-12", new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("62aa5bfd-995e-4792-af79-5abd11b3ea54"), new Guid("62aa5bfd-995e-4792-af79-5abd11b3ea54"), "+681 47 (032) 38-42", new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("6399c04c-9fa0-4b70-9e87-7a020efd798b"), new Guid("6399c04c-9fa0-4b70-9e87-7a020efd798b"), "+5 75 (205) 45-62", new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("63bc5155-fb31-4d1f-8de1-1b159689453b"), new Guid("63bc5155-fb31-4d1f-8de1-1b159689453b"), "+555 64 (936) 81-40", new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("64136bc6-3ceb-40a2-83a7-c1288808edf6"), new Guid("64136bc6-3ceb-40a2-83a7-c1288808edf6"), "+671 43 (154) 48-21", new Guid("82d639d5-cfe6-4420-9379-35aa1ace3c13") },
                    { new Guid("6432cd4c-5b98-4af9-af4a-c51d5ff121bf"), new Guid("6432cd4c-5b98-4af9-af4a-c51d5ff121bf"), "+62 67 (969) 11-46", new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("649d6d74-ebb4-4039-a817-2fffdd526626"), new Guid("649d6d74-ebb4-4039-a817-2fffdd526626"), "+617 19 (989) 38-94", new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("64a82db2-423d-466d-8f45-f5d3ba6973a8"), new Guid("64a82db2-423d-466d-8f45-f5d3ba6973a8"), "+332 24 (254) 37-95", new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("64d58906-c4bb-4ae0-afbe-284fcbbb1d4d"), new Guid("64d58906-c4bb-4ae0-afbe-284fcbbb1d4d"), "+682 90 (249) 78-45", new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("64e5c560-5657-4318-8ab9-7b41afd602f7"), new Guid("64e5c560-5657-4318-8ab9-7b41afd602f7"), "+700 43 (041) 35-38", new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("64fa06bd-d7b8-4f8a-bbb7-e91f89d2acd9"), new Guid("64fa06bd-d7b8-4f8a-bbb7-e91f89d2acd9"), "+797 69 (111) 27-73", new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") },
                    { new Guid("651e84a2-bbc3-49b5-ba96-a400a15a51c6"), new Guid("651e84a2-bbc3-49b5-ba96-a400a15a51c6"), "+813 64 (498) 54-75", new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b") },
                    { new Guid("6526361e-d0b5-4033-8be4-db284545a468"), new Guid("6526361e-d0b5-4033-8be4-db284545a468"), "+621 04 (133) 43-07", new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("6577e4ca-4b7f-441b-8bec-2fe8df9181b4"), new Guid("6577e4ca-4b7f-441b-8bec-2fe8df9181b4"), "+72 76 (679) 81-37", new Guid("f1038abe-cd17-40c4-844a-70a0ee863724") },
                    { new Guid("65a2c6ad-8844-406f-acf5-358ea03a22a9"), new Guid("65a2c6ad-8844-406f-acf5-358ea03a22a9"), "+103 59 (562) 61-00", new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("65b3dd2a-5acd-4e0b-9fbb-6b5548ff0a4d"), new Guid("65b3dd2a-5acd-4e0b-9fbb-6b5548ff0a4d"), "+867 82 (308) 43-76", new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("6642138e-7d67-439d-8c62-bd71097e10d1"), new Guid("6642138e-7d67-439d-8c62-bd71097e10d1"), "+478 27 (933) 42-59", new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("666956b0-dc1b-491c-9c54-e826f3cf342b"), new Guid("666956b0-dc1b-491c-9c54-e826f3cf342b"), "+762 93 (513) 94-06", new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("66cc22c5-ba6b-40e5-a09d-b028ed52006d"), new Guid("66cc22c5-ba6b-40e5-a09d-b028ed52006d"), "+511 73 (658) 61-26", new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("674da290-ba61-48ba-ab82-ee0827a6b8ab"), new Guid("674da290-ba61-48ba-ab82-ee0827a6b8ab"), "+28 75 (629) 98-86", new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("676b35c6-5b15-4509-9bba-fa0413cf75e6"), new Guid("676b35c6-5b15-4509-9bba-fa0413cf75e6"), "+843 13 (031) 13-27", new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("67800204-62bf-49f8-a6cb-2d546453a53e"), new Guid("67800204-62bf-49f8-a6cb-2d546453a53e"), "+764 61 (018) 10-71", new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4") },
                    { new Guid("678b1834-a7e3-4d71-b815-dfd8b651bcc1"), new Guid("678b1834-a7e3-4d71-b815-dfd8b651bcc1"), "+711 77 (360) 95-71", new Guid("6fb34d65-fe9f-439b-8e8b-95c4f71594ed") },
                    { new Guid("6793b4a6-768a-402f-9d82-81c7e21ce66c"), new Guid("6793b4a6-768a-402f-9d82-81c7e21ce66c"), "+704 89 (858) 75-91", new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("67a5285e-67d3-4876-bae9-c0bb116caa8e"), new Guid("67a5285e-67d3-4876-bae9-c0bb116caa8e"), "+418 42 (890) 79-44", new Guid("8f8cd90d-fe20-4df0-8607-72f337546146") },
                    { new Guid("68274d6c-41cc-473b-bcb3-43cb6dc3e485"), new Guid("68274d6c-41cc-473b-bcb3-43cb6dc3e485"), "+167 88 (397) 37-63", new Guid("05d888a7-8474-4565-b751-a89df2400346") },
                    { new Guid("68740b6e-460e-49c3-bf20-955b278b6f22"), new Guid("68740b6e-460e-49c3-bf20-955b278b6f22"), "+964 66 (934) 51-04", new Guid("35b6c210-2256-41cd-af8e-e815527e0a84") },
                    { new Guid("68f06055-7990-44c8-adb2-0329e4dad806"), new Guid("68f06055-7990-44c8-adb2-0329e4dad806"), "+424 17 (481) 51-65", new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("6903f3c7-a138-4eae-9254-23dbbc2f8e2f"), new Guid("6903f3c7-a138-4eae-9254-23dbbc2f8e2f"), "+803 52 (639) 85-08", new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("691322d8-b6d1-42f1-b9a1-59bcd6691f23"), new Guid("691322d8-b6d1-42f1-b9a1-59bcd6691f23"), "+156 99 (871) 12-85", new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("69a5b120-a843-4c2b-9d6e-3478cfd8a5fc"), new Guid("69a5b120-a843-4c2b-9d6e-3478cfd8a5fc"), "+362 37 (699) 76-46", new Guid("69170f92-b4b7-4c26-be44-5255d738fb20") },
                    { new Guid("69fc68b1-22e8-43b2-8a91-69f8e80ff3b7"), new Guid("69fc68b1-22e8-43b2-8a91-69f8e80ff3b7"), "+32 41 (272) 45-63", new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("6a3c5833-2969-4143-9434-e333c349787a"), new Guid("6a3c5833-2969-4143-9434-e333c349787a"), "+833 58 (722) 70-17", new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("6a4565cc-00d0-4b66-87a1-a14d790d2519"), new Guid("6a4565cc-00d0-4b66-87a1-a14d790d2519"), "+339 27 (502) 09-42", new Guid("a662b3ad-6def-4527-81c0-400ae1450131") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("6a77dfc7-beac-4040-9d88-540bc0ae00d7"), new Guid("6a77dfc7-beac-4040-9d88-540bc0ae00d7"), "+742 38 (513) 29-98", new Guid("c4bd5d4f-94f8-464a-a42f-270b192a3e46") },
                    { new Guid("6ade4632-4cdc-4501-9bd5-804bf341255b"), new Guid("6ade4632-4cdc-4501-9bd5-804bf341255b"), "+617 85 (924) 27-92", new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("6bb9ff6c-8da0-4e6f-938a-7c3cff3f7d0f"), new Guid("6bb9ff6c-8da0-4e6f-938a-7c3cff3f7d0f"), "+227 38 (015) 99-10", new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("6bf7a348-06cf-4ff6-a312-51da12105ba1"), new Guid("6bf7a348-06cf-4ff6-a312-51da12105ba1"), "+924 10 (517) 30-65", new Guid("21636e3b-e7c9-4cdf-8b71-9c16fd67a738") },
                    { new Guid("6c83089a-a103-4ec4-bf65-4509e0d4878d"), new Guid("6c83089a-a103-4ec4-bf65-4509e0d4878d"), "+963 49 (720) 36-16", new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977") },
                    { new Guid("6cb6f6f6-71ed-4bcb-8844-0e4cb5d9903a"), new Guid("6cb6f6f6-71ed-4bcb-8844-0e4cb5d9903a"), "+938 54 (169) 46-79", new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("6ce4aec9-f4de-40f8-b381-372d780fb3ca"), new Guid("6ce4aec9-f4de-40f8-b381-372d780fb3ca"), "+190 06 (530) 02-98", new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("6d17022d-a3c9-424b-a627-b7599f2143a2"), new Guid("6d17022d-a3c9-424b-a627-b7599f2143a2"), "+616 82 (490) 63-18", new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a") },
                    { new Guid("6d6125a4-d24c-4be8-9621-608a0526e7cb"), new Guid("6d6125a4-d24c-4be8-9621-608a0526e7cb"), "+971 16 (372) 20-63", new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("6d91e778-b919-4b0f-b82a-5931626acca4"), new Guid("6d91e778-b919-4b0f-b82a-5931626acca4"), "+539 86 (941) 41-29", new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("6da9c52a-e6a2-4a8d-b054-ec57c0c22915"), new Guid("6da9c52a-e6a2-4a8d-b054-ec57c0c22915"), "+234 92 (661) 97-68", new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("6dab17a9-7d2c-4429-a382-4589144021ac"), new Guid("6dab17a9-7d2c-4429-a382-4589144021ac"), "+127 36 (665) 36-05", new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("6dccffc6-e110-4d7f-a154-69e9dbdc8771"), new Guid("6dccffc6-e110-4d7f-a154-69e9dbdc8771"), "+237 50 (319) 76-02", new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5") },
                    { new Guid("6e9af539-b29b-4416-8aac-d2091d2d16c7"), new Guid("6e9af539-b29b-4416-8aac-d2091d2d16c7"), "+685 44 (121) 76-83", new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420") },
                    { new Guid("6ef1a1e4-5191-4f48-b70f-fb8c9cda6200"), new Guid("6ef1a1e4-5191-4f48-b70f-fb8c9cda6200"), "+912 26 (729) 76-69", new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("6fb37843-43f6-498f-a94a-16a70ec05668"), new Guid("6fb37843-43f6-498f-a94a-16a70ec05668"), "+461 11 (411) 08-68", new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("6fcd3a44-6eb6-4351-804d-4e71dc5cfc88"), new Guid("6fcd3a44-6eb6-4351-804d-4e71dc5cfc88"), "+173 99 (467) 80-03", new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("701edbb8-2146-40e8-b823-62a635c8b0d3"), new Guid("701edbb8-2146-40e8-b823-62a635c8b0d3"), "+507 28 (648) 65-33", new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("70658840-1239-4d7f-b9ac-99be316000d4"), new Guid("70658840-1239-4d7f-b9ac-99be316000d4"), "+65 94 (173) 23-05", new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("706d10b3-ea6e-4b14-803a-1d6668011204"), new Guid("706d10b3-ea6e-4b14-803a-1d6668011204"), "+157 34 (950) 14-85", new Guid("3aa7af1b-b66f-4723-8a7f-a449d8153913") },
                    { new Guid("70ebefbe-6318-47ce-aba2-cef81b98283a"), new Guid("70ebefbe-6318-47ce-aba2-cef81b98283a"), "+870 25 (476) 80-22", new Guid("f7720de3-aaea-48e9-af48-569af731d90b") },
                    { new Guid("71074990-3c3f-4db0-979f-9efe0494c8a3"), new Guid("71074990-3c3f-4db0-979f-9efe0494c8a3"), "+182 35 (770) 37-44", new Guid("6a83b8a4-edc7-4be6-b322-803b1bb59c5d") },
                    { new Guid("7114ff9b-1a78-4c55-a053-f39c4d0c56be"), new Guid("7114ff9b-1a78-4c55-a053-f39c4d0c56be"), "+399 77 (247) 32-31", new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("7134b8ed-dd2e-464e-8950-42c41b2675e3"), new Guid("7134b8ed-dd2e-464e-8950-42c41b2675e3"), "+28 65 (152) 53-06", new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("7165d84b-21cf-4177-afb6-b1b41e6ae10c"), new Guid("7165d84b-21cf-4177-afb6-b1b41e6ae10c"), "+543 62 (519) 19-63", new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("717cfa1c-c2df-452b-9016-1573b0b13280"), new Guid("717cfa1c-c2df-452b-9016-1573b0b13280"), "+394 05 (154) 76-09", new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6") },
                    { new Guid("71fb9650-3cca-43b0-b803-3002f3e9af26"), new Guid("71fb9650-3cca-43b0-b803-3002f3e9af26"), "+971 54 (843) 43-83", new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("722855f6-7a87-4296-8fa8-56778e69ee6b"), new Guid("722855f6-7a87-4296-8fa8-56778e69ee6b"), "+725 34 (693) 79-93", new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") },
                    { new Guid("73d3b908-8b55-4e94-a480-0748435d65e3"), new Guid("73d3b908-8b55-4e94-a480-0748435d65e3"), "+848 79 (867) 23-09", new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") },
                    { new Guid("742b8b5b-e7f1-4881-a87f-4575e4271a71"), new Guid("742b8b5b-e7f1-4881-a87f-4575e4271a71"), "+368 83 (519) 18-64", new Guid("3e38a390-7168-426f-8d48-017588046d20") },
                    { new Guid("746fa537-5113-4da6-b545-eeb9e55ce1cb"), new Guid("746fa537-5113-4da6-b545-eeb9e55ce1cb"), "+349 48 (366) 96-67", new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("7472c22e-bad0-4525-a1b9-4d414ea27487"), new Guid("7472c22e-bad0-4525-a1b9-4d414ea27487"), "+786 86 (787) 80-54", new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2") },
                    { new Guid("74a92d62-9833-49a2-9c93-10f35c3c2fbe"), new Guid("74a92d62-9833-49a2-9c93-10f35c3c2fbe"), "+901 36 (053) 63-51", new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63") },
                    { new Guid("74bd4471-1d0d-4f7a-9987-b22e43729b20"), new Guid("74bd4471-1d0d-4f7a-9987-b22e43729b20"), "+803 64 (429) 23-10", new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("74cd25df-5322-49b7-952d-9af298720673"), new Guid("74cd25df-5322-49b7-952d-9af298720673"), "+802 79 (137) 53-23", new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584") },
                    { new Guid("750f8e23-b20d-4597-8e88-6bb74909f719"), new Guid("750f8e23-b20d-4597-8e88-6bb74909f719"), "+992 45 (432) 43-65", new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("75224c25-aa0d-4a73-a040-fed7f74b666c"), new Guid("75224c25-aa0d-4a73-a040-fed7f74b666c"), "+34 07 (824) 84-87", new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("75c7aa33-6bf8-4972-81dd-7299fc0221d1"), new Guid("75c7aa33-6bf8-4972-81dd-7299fc0221d1"), "+489 66 (168) 48-23", new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("75ff10c1-e087-4a62-9159-5745d941987d"), new Guid("75ff10c1-e087-4a62-9159-5745d941987d"), "+705 33 (204) 48-27", new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("760cad46-9df5-4d30-9992-9f03c3d41466"), new Guid("760cad46-9df5-4d30-9992-9f03c3d41466"), "+612 69 (112) 46-13", new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("76219d76-882f-4ad7-b666-afb404f03db5"), new Guid("76219d76-882f-4ad7-b666-afb404f03db5"), "+451 70 (782) 33-14", new Guid("75822def-f0e9-4657-b4cf-a3f4d3a798e6") },
                    { new Guid("762a6b57-7339-46c5-a6c1-0fae5f50c8b9"), new Guid("762a6b57-7339-46c5-a6c1-0fae5f50c8b9"), "+210 95 (559) 95-37", new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("762f9323-c54c-4d0f-b78c-36aad2244b44"), new Guid("762f9323-c54c-4d0f-b78c-36aad2244b44"), "+965 82 (134) 06-76", new Guid("536c68a9-1f93-4e6d-bed5-c24121484ce4") },
                    { new Guid("76470884-fcdf-40d7-a48d-ad163890aa87"), new Guid("76470884-fcdf-40d7-a48d-ad163890aa87"), "+817 45 (206) 04-21", new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("766ea3a2-4102-43de-b660-a3d11a71c9dc"), new Guid("766ea3a2-4102-43de-b660-a3d11a71c9dc"), "+67 22 (714) 98-27", new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("77118212-8ee8-410b-a017-97d46e108982"), new Guid("77118212-8ee8-410b-a017-97d46e108982"), "+78 97 (232) 16-81", new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("771da1b4-87f6-4d24-b342-24fc47fd7e95"), new Guid("771da1b4-87f6-4d24-b342-24fc47fd7e95"), "+908 24 (011) 30-92", new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("77f178e5-41fb-4b05-beea-f56a617eeec5"), new Guid("77f178e5-41fb-4b05-beea-f56a617eeec5"), "+561 64 (969) 77-76", new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("78079bf0-b906-4ed3-9337-c25462565ba7"), new Guid("78079bf0-b906-4ed3-9337-c25462565ba7"), "+272 09 (451) 22-96", new Guid("1693d7a4-414f-45fc-b87f-38b5dda29473") },
                    { new Guid("7807f874-7b5f-4e89-ad23-3f0cce1ba7b5"), new Guid("7807f874-7b5f-4e89-ad23-3f0cce1ba7b5"), "+834 86 (957) 36-13", new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("78134cb1-bbb7-423e-8e66-eb165c115f55"), new Guid("78134cb1-bbb7-423e-8e66-eb165c115f55"), "+116 75 (498) 31-90", new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("78235fde-883c-45ee-82fb-07b6fc7a43a6"), new Guid("78235fde-883c-45ee-82fb-07b6fc7a43a6"), "+947 93 (959) 32-74", new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("7855f4c1-c49b-49b8-b478-1b113396b74c"), new Guid("7855f4c1-c49b-49b8-b478-1b113396b74c"), "+481 62 (977) 05-95", new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("789f1f45-7387-4aae-ae40-e9adb2e69191"), new Guid("789f1f45-7387-4aae-ae40-e9adb2e69191"), "+690 94 (203) 53-92", new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("78a35011-7adf-46ac-81f3-f3668a4877d3"), new Guid("78a35011-7adf-46ac-81f3-f3668a4877d3"), "+151 30 (381) 51-84", new Guid("48949002-3dd7-424b-b508-bb6644cad6fb") },
                    { new Guid("78cb4e80-bd88-4972-b73a-beae09453319"), new Guid("78cb4e80-bd88-4972-b73a-beae09453319"), "+540 17 (062) 51-42", new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11") },
                    { new Guid("78e1ef08-7827-49de-8885-b08318b11431"), new Guid("78e1ef08-7827-49de-8885-b08318b11431"), "+663 70 (508) 63-25", new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("79229cde-f0b9-4e92-8f9d-7ab1503555aa"), new Guid("79229cde-f0b9-4e92-8f9d-7ab1503555aa"), "+965 07 (795) 15-58", new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("7a452ca3-381d-4154-a36d-44262891ea15"), new Guid("7a452ca3-381d-4154-a36d-44262891ea15"), "+951 46 (419) 58-80", new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("7a4e2c07-60bf-4f12-a8df-e0fffadb33b2"), new Guid("7a4e2c07-60bf-4f12-a8df-e0fffadb33b2"), "+649 24 (083) 76-06", new Guid("f7e86b66-49eb-4774-82be-b008350dc98b") },
                    { new Guid("7af2db1e-7e6a-4dac-8480-e3dfea1cd236"), new Guid("7af2db1e-7e6a-4dac-8480-e3dfea1cd236"), "+684 77 (564) 16-78", new Guid("933e6296-2c05-43e2-9f91-b4edd5e99d20") },
                    { new Guid("7b2f566a-4e49-44c9-8dfe-bc1da6283299"), new Guid("7b2f566a-4e49-44c9-8dfe-bc1da6283299"), "+231 47 (537) 42-73", new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456") },
                    { new Guid("7b634866-a80d-4972-90ab-98300f7d0152"), new Guid("7b634866-a80d-4972-90ab-98300f7d0152"), "+322 19 (657) 12-55", new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("7b84fd7d-d5d3-4116-a27c-199363c529d0"), new Guid("7b84fd7d-d5d3-4116-a27c-199363c529d0"), "+943 82 (971) 40-69", new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("7baf6d5d-8253-4ac2-9e29-19c24f9e8e69"), new Guid("7baf6d5d-8253-4ac2-9e29-19c24f9e8e69"), "+271 94 (627) 01-94", new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5") },
                    { new Guid("7bd4d9a7-76bb-489b-903d-9af5c7cc3aef"), new Guid("7bd4d9a7-76bb-489b-903d-9af5c7cc3aef"), "+736 08 (679) 07-85", new Guid("cfddcc04-5205-447d-9799-6d1945c391b4") },
                    { new Guid("7bd624ea-7738-4a8d-9bab-04febeb5adb4"), new Guid("7bd624ea-7738-4a8d-9bab-04febeb5adb4"), "+962 28 (472) 69-37", new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("7bf6a151-305b-4277-8494-77b63f633bc1"), new Guid("7bf6a151-305b-4277-8494-77b63f633bc1"), "+533 12 (234) 99-15", new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("7c3610b7-b662-49e9-be4f-6b49669eeab2"), new Guid("7c3610b7-b662-49e9-be4f-6b49669eeab2"), "+256 66 (885) 56-81", new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29") },
                    { new Guid("7c3c3f54-2273-4f4c-815b-b65d8cbfc114"), new Guid("7c3c3f54-2273-4f4c-815b-b65d8cbfc114"), "+475 89 (713) 03-27", new Guid("5f9eafc8-d854-420d-9346-3fd9e6e0356a") },
                    { new Guid("7cb06348-4cd0-4d3d-b8be-e5d112581d6d"), new Guid("7cb06348-4cd0-4d3d-b8be-e5d112581d6d"), "+314 94 (495) 90-94", new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("7d4c9bd5-69b0-4cbe-b017-06bb5f810b45"), new Guid("7d4c9bd5-69b0-4cbe-b017-06bb5f810b45"), "+894 83 (211) 82-97", new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("7d9ae094-4bcc-4b5d-a5a5-a32d8a2de79c"), new Guid("7d9ae094-4bcc-4b5d-a5a5-a32d8a2de79c"), "+622 47 (779) 27-72", new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("7e74b257-a660-49fc-8aa3-a233029e8dae"), new Guid("7e74b257-a660-49fc-8aa3-a233029e8dae"), "+83 88 (470) 24-23", new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("7e9a91c9-a867-4f76-898d-16ee1799f48c"), new Guid("7e9a91c9-a867-4f76-898d-16ee1799f48c"), "+49 77 (225) 71-33", new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("7ec681ae-46bf-4d96-8278-1941559f5f5e"), new Guid("7ec681ae-46bf-4d96-8278-1941559f5f5e"), "+224 71 (851) 18-90", new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("7ed5accb-5eb5-4462-8375-14f0f753b5bd"), new Guid("7ed5accb-5eb5-4462-8375-14f0f753b5bd"), "+394 17 (871) 45-37", new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("7fb672e9-8c70-48b0-aa63-c94c2a0cc186"), new Guid("7fb672e9-8c70-48b0-aa63-c94c2a0cc186"), "+620 67 (837) 74-13", new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("806e2732-4ecb-41a6-8def-2a9896965b2b"), new Guid("806e2732-4ecb-41a6-8def-2a9896965b2b"), "+128 10 (406) 11-69", new Guid("0b15ae39-ea71-49c5-a132-1475793930aa") },
                    { new Guid("80750e0e-078c-4902-b2c4-e225f92a8558"), new Guid("80750e0e-078c-4902-b2c4-e225f92a8558"), "+205 77 (932) 48-78", new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("8101106b-435f-4532-81b4-a7253a316177"), new Guid("8101106b-435f-4532-81b4-a7253a316177"), "+83 55 (292) 52-95", new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("8108a1d6-7942-482f-a25c-44eb3dfb59da"), new Guid("8108a1d6-7942-482f-a25c-44eb3dfb59da"), "+170 21 (493) 64-52", new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("810e5597-1a0c-401a-a365-0264d75780b0"), new Guid("810e5597-1a0c-401a-a365-0264d75780b0"), "+406 42 (408) 99-45", new Guid("6d9d1f2d-9e9e-4c90-895a-f051ffd8bac5") },
                    { new Guid("81e7265d-02e7-4712-87d4-70eaca1774e6"), new Guid("81e7265d-02e7-4712-87d4-70eaca1774e6"), "+357 04 (148) 97-88", new Guid("08e83522-0abb-4778-9027-c86ca1a0a624") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("827d7a3f-46b9-4b79-82ff-e04d9efbabe2"), new Guid("827d7a3f-46b9-4b79-82ff-e04d9efbabe2"), "+999 15 (237) 24-95", new Guid("18685782-706e-445d-892d-19c39dd67689") },
                    { new Guid("841ebb17-c331-4b9b-b790-27863ec9f632"), new Guid("841ebb17-c331-4b9b-b790-27863ec9f632"), "+376 14 (619) 10-72", new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("8431619f-5deb-4d80-85b6-f82bbb0da94d"), new Guid("8431619f-5deb-4d80-85b6-f82bbb0da94d"), "+742 64 (132) 39-24", new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("84828d63-4957-404a-bf6b-2fe7ee630783"), new Guid("84828d63-4957-404a-bf6b-2fe7ee630783"), "+143 34 (388) 04-23", new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a") },
                    { new Guid("84db8c5b-77e5-407b-9b30-f80cbb41193b"), new Guid("84db8c5b-77e5-407b-9b30-f80cbb41193b"), "+425 90 (345) 79-98", new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("84e82124-5d09-4520-8791-e4125e1dc678"), new Guid("84e82124-5d09-4520-8791-e4125e1dc678"), "+203 69 (347) 30-69", new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a") },
                    { new Guid("8505dbf1-27b8-4d84-9940-5907ec9bf900"), new Guid("8505dbf1-27b8-4d84-9940-5907ec9bf900"), "+744 03 (311) 05-77", new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("853663d9-ab41-491d-8403-214bca5e9c4d"), new Guid("853663d9-ab41-491d-8403-214bca5e9c4d"), "+600 63 (409) 69-29", new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("854d4e12-1c24-4e36-afcd-3e878c07a37e"), new Guid("854d4e12-1c24-4e36-afcd-3e878c07a37e"), "+270 12 (174) 68-81", new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("854de2d9-92f6-4a07-ba78-33ee27a35f62"), new Guid("854de2d9-92f6-4a07-ba78-33ee27a35f62"), "+562 93 (844) 62-36", new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("85665c4d-1b9c-4864-b516-8f028d7405da"), new Guid("85665c4d-1b9c-4864-b516-8f028d7405da"), "+439 50 (052) 84-19", new Guid("cb7bd80f-adaa-467f-81f5-6b3f76f57861") },
                    { new Guid("85a3b7b2-6cb5-4508-987a-911cbc42d4fa"), new Guid("85a3b7b2-6cb5-4508-987a-911cbc42d4fa"), "+539 25 (763) 40-89", new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075") },
                    { new Guid("85a4b7f9-ccef-4bef-a15c-e381782c05b1"), new Guid("85a4b7f9-ccef-4bef-a15c-e381782c05b1"), "+913 96 (264) 50-16", new Guid("e2c0f944-e30b-436d-966b-858138b547a6") },
                    { new Guid("85ab9d71-4017-4d32-9dce-44db5f8f7870"), new Guid("85ab9d71-4017-4d32-9dce-44db5f8f7870"), "+235 12 (339) 43-10", new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("85c8114a-7831-4bd3-8927-6ea2f7c2953a"), new Guid("85c8114a-7831-4bd3-8927-6ea2f7c2953a"), "+640 54 (175) 13-71", new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("85d98167-4571-4527-8cc0-321c33fd19d8"), new Guid("85d98167-4571-4527-8cc0-321c33fd19d8"), "+558 17 (675) 85-63", new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("86f2d63c-422d-442c-9884-fd5a379887ec"), new Guid("86f2d63c-422d-442c-9884-fd5a379887ec"), "+508 03 (462) 16-30", new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("870fcaf1-0d85-47ab-921f-3ba03fde1c2e"), new Guid("870fcaf1-0d85-47ab-921f-3ba03fde1c2e"), "+179 29 (297) 96-99", new Guid("8b3ae855-3f1f-409d-8898-00767477ffae") },
                    { new Guid("871212b3-6925-4cce-adce-d1b5089f415a"), new Guid("871212b3-6925-4cce-adce-d1b5089f415a"), "+57 38 (408) 65-23", new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("871e3ee9-b480-4748-8cba-a48795261ba3"), new Guid("871e3ee9-b480-4748-8cba-a48795261ba3"), "+563 54 (548) 48-57", new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("875accc6-6fb9-4490-b6f2-88a6e73dfd06"), new Guid("875accc6-6fb9-4490-b6f2-88a6e73dfd06"), "+547 80 (787) 09-92", new Guid("2ba45846-5a27-4f55-9511-bc8ca2752f4f") },
                    { new Guid("87914087-16fe-48b7-9c90-bc1a8a8220fe"), new Guid("87914087-16fe-48b7-9c90-bc1a8a8220fe"), "+590 50 (971) 24-59", new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("87a29eb9-cc90-4c3a-b711-02cbc1a7e4e9"), new Guid("87a29eb9-cc90-4c3a-b711-02cbc1a7e4e9"), "+767 37 (724) 20-19", new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("87c4307e-86e4-4d03-846f-013c2a769bd6"), new Guid("87c4307e-86e4-4d03-846f-013c2a769bd6"), "+708 81 (840) 90-46", new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("88989b44-7264-4bde-8097-5a4603047fad"), new Guid("88989b44-7264-4bde-8097-5a4603047fad"), "+702 84 (460) 08-21", new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("88af2f00-4211-4d66-a730-6339876d28d5"), new Guid("88af2f00-4211-4d66-a730-6339876d28d5"), "+127 48 (957) 88-10", new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("88c672d1-f061-40c0-8346-7227459ddd6e"), new Guid("88c672d1-f061-40c0-8346-7227459ddd6e"), "+48 10 (398) 86-11", new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("88e487a8-7d64-4dfb-b4c8-9f3a73c1707f"), new Guid("88e487a8-7d64-4dfb-b4c8-9f3a73c1707f"), "+363 80 (854) 32-64", new Guid("83c8f958-a3f1-448d-bad0-048533827e0e") },
                    { new Guid("88e97f71-75be-40f9-8ef1-aa3f259ff30d"), new Guid("88e97f71-75be-40f9-8ef1-aa3f259ff30d"), "+563 73 (299) 58-04", new Guid("3793c254-cd3f-4c42-93fb-0895042668c7") },
                    { new Guid("8953d814-c505-4550-901f-8abdbb9c19e6"), new Guid("8953d814-c505-4550-901f-8abdbb9c19e6"), "+952 06 (833) 19-26", new Guid("f825bff2-881f-450b-a4b7-56931951c54c") },
                    { new Guid("89720b5e-f4b2-4e70-ba51-cee0f06df7e2"), new Guid("89720b5e-f4b2-4e70-ba51-cee0f06df7e2"), "+208 25 (764) 66-03", new Guid("ab4c160d-72a2-4834-99e6-8dbc62e86ae6") },
                    { new Guid("897288d7-40a0-4463-8ad7-f9c8f06540e3"), new Guid("897288d7-40a0-4463-8ad7-f9c8f06540e3"), "+897 51 (085) 12-17", new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("89b11b0f-552c-4a64-bd03-6d02ec7139b9"), new Guid("89b11b0f-552c-4a64-bd03-6d02ec7139b9"), "+754 03 (366) 25-75", new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("89de4c1f-4909-42a2-a53f-8bd6129c65b9"), new Guid("89de4c1f-4909-42a2-a53f-8bd6129c65b9"), "+257 40 (075) 06-91", new Guid("f8533ae7-6d07-40a6-9996-6147cbf8e420") },
                    { new Guid("89ed76e7-be3c-4cb7-beda-e5e6011b3c4c"), new Guid("89ed76e7-be3c-4cb7-beda-e5e6011b3c4c"), "+558 01 (266) 91-85", new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("8a727e1e-1217-4033-b4b1-32bce4ca7707"), new Guid("8a727e1e-1217-4033-b4b1-32bce4ca7707"), "+39 95 (521) 35-38", new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26") },
                    { new Guid("8a85ddac-71a3-4960-a284-b69f07dcb0b9"), new Guid("8a85ddac-71a3-4960-a284-b69f07dcb0b9"), "+672 66 (225) 43-72", new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b") },
                    { new Guid("8a8db2ae-b99c-44e4-b07d-54eea1f6d14f"), new Guid("8a8db2ae-b99c-44e4-b07d-54eea1f6d14f"), "+301 13 (808) 00-47", new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") },
                    { new Guid("8ab206ec-2cb4-4567-a321-40383a2f3871"), new Guid("8ab206ec-2cb4-4567-a321-40383a2f3871"), "+434 44 (126) 21-71", new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("8abafb16-5a9b-433f-9936-99eaa8509ef6"), new Guid("8abafb16-5a9b-433f-9936-99eaa8509ef6"), "+311 55 (375) 51-25", new Guid("c4e350ac-9de2-480f-b9e8-c0ef85a1f5e0") },
                    { new Guid("8abd639f-1ec6-4486-84f5-e76e6d0f47a8"), new Guid("8abd639f-1ec6-4486-84f5-e76e6d0f47a8"), "+377 93 (610) 57-66", new Guid("59bb6e9f-588b-46f7-b101-dcf19c785f33") },
                    { new Guid("8bb72416-0921-4bcb-ae2b-6b253b75ec9d"), new Guid("8bb72416-0921-4bcb-ae2b-6b253b75ec9d"), "+928 86 (160) 27-07", new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("8bcbe11c-fe33-4a09-9008-e574038dc3a4"), new Guid("8bcbe11c-fe33-4a09-9008-e574038dc3a4"), "+438 42 (814) 18-15", new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("8ccb7417-4159-4b90-9d3d-182eee5045f3"), new Guid("8ccb7417-4159-4b90-9d3d-182eee5045f3"), "+328 80 (272) 00-85", new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b") },
                    { new Guid("8ce143d6-e1f2-4e60-95a3-767b4b098f6f"), new Guid("8ce143d6-e1f2-4e60-95a3-767b4b098f6f"), "+943 28 (560) 12-57", new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("8cebcb6b-1489-439e-928c-630dd9c77961"), new Guid("8cebcb6b-1489-439e-928c-630dd9c77961"), "+769 31 (647) 16-44", new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("8d1dd291-d3d7-461f-b66a-a04ee3b59971"), new Guid("8d1dd291-d3d7-461f-b66a-a04ee3b59971"), "+562 27 (713) 38-68", new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("8d315b8f-1b4b-483a-8d5f-20e71d9baaa6"), new Guid("8d315b8f-1b4b-483a-8d5f-20e71d9baaa6"), "+321 08 (117) 64-00", new Guid("4aa5a3d9-da50-487a-8342-fcc9ef450f11") },
                    { new Guid("8d4a4341-d334-420b-bf79-8337f3f3c67a"), new Guid("8d4a4341-d334-420b-bf79-8337f3f3c67a"), "+7 43 (567) 29-38", new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("8d9c8136-3b02-4e2c-8818-03d5edd444d6"), new Guid("8d9c8136-3b02-4e2c-8818-03d5edd444d6"), "+637 62 (717) 22-77", new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("8db2cb76-391a-403b-ae66-b02e68b87d09"), new Guid("8db2cb76-391a-403b-ae66-b02e68b87d09"), "+394 78 (537) 04-49", new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("8dbb0d66-f7b2-4cf3-b17d-c860b79b2402"), new Guid("8dbb0d66-f7b2-4cf3-b17d-c860b79b2402"), "+182 74 (183) 39-15", new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("8df22744-fe88-4326-a5b6-b040cdf11939"), new Guid("8df22744-fe88-4326-a5b6-b040cdf11939"), "+742 08 (995) 63-54", new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("8e0a6e4a-4bcb-44c9-acca-79508e671d24"), new Guid("8e0a6e4a-4bcb-44c9-acca-79508e671d24"), "+266 12 (368) 57-61", new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("8e2d9c88-cf31-4afc-8a23-94c864d3c543"), new Guid("8e2d9c88-cf31-4afc-8a23-94c864d3c543"), "+616 66 (200) 81-41", new Guid("05d888a7-8474-4565-b751-a89df2400346") },
                    { new Guid("8e916164-50e0-47ab-b8fc-d3877257477a"), new Guid("8e916164-50e0-47ab-b8fc-d3877257477a"), "+752 08 (703) 04-06", new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4") },
                    { new Guid("8ece3fa1-5292-4687-9e60-9d81b9587ca0"), new Guid("8ece3fa1-5292-4687-9e60-9d81b9587ca0"), "+312 49 (137) 37-89", new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("8edb6a7f-a79e-4831-bda1-081c62c6cf1a"), new Guid("8edb6a7f-a79e-4831-bda1-081c62c6cf1a"), "+34 43 (412) 91-42", new Guid("de1becca-03ce-47ec-af55-d4650a9a1b0b") },
                    { new Guid("8f1ef52a-878e-4b79-a198-8dbddd688f92"), new Guid("8f1ef52a-878e-4b79-a198-8dbddd688f92"), "+734 68 (572) 19-54", new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("8f88249b-2cb4-4e2a-8c85-fcdc84bad2b7"), new Guid("8f88249b-2cb4-4e2a-8c85-fcdc84bad2b7"), "+308 23 (199) 08-02", new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("8fd2f844-9330-4e6d-a22f-c8a916a00b30"), new Guid("8fd2f844-9330-4e6d-a22f-c8a916a00b30"), "+617 14 (338) 50-74", new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("8fd4377d-6d48-4eb5-baab-f12f47e8066f"), new Guid("8fd4377d-6d48-4eb5-baab-f12f47e8066f"), "+92 02 (413) 76-86", new Guid("64749dc9-26b0-496b-abb4-a7411aa1c17a") },
                    { new Guid("90deff86-4068-40ad-9188-ea722ae2dcba"), new Guid("90deff86-4068-40ad-9188-ea722ae2dcba"), "+28 34 (031) 29-34", new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("90e7fffb-20e9-490b-b103-ebf94a8afc54"), new Guid("90e7fffb-20e9-490b-b103-ebf94a8afc54"), "+4 94 (502) 41-97", new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9") },
                    { new Guid("9116fc85-c413-43a7-9736-230a0e926316"), new Guid("9116fc85-c413-43a7-9736-230a0e926316"), "+683 07 (413) 57-56", new Guid("69170f92-b4b7-4c26-be44-5255d738fb20") },
                    { new Guid("9139907b-9545-41b6-b2fb-579a82140bb8"), new Guid("9139907b-9545-41b6-b2fb-579a82140bb8"), "+763 03 (848) 36-26", new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("918e0e53-e721-465d-b3ad-89973dc6e764"), new Guid("918e0e53-e721-465d-b3ad-89973dc6e764"), "+66 32 (485) 03-85", new Guid("0c7d441b-ff4c-4688-b5df-32d8d65b8f3a") },
                    { new Guid("91dc037d-daa0-4dc8-891c-5c56d542de44"), new Guid("91dc037d-daa0-4dc8-891c-5c56d542de44"), "+648 01 (858) 26-38", new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("92011832-a50d-4ba4-92c8-d1bf547d0a6d"), new Guid("92011832-a50d-4ba4-92c8-d1bf547d0a6d"), "+579 41 (686) 44-28", new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("92908fe8-a2a4-42de-b08f-9173503773ba"), new Guid("92908fe8-a2a4-42de-b08f-9173503773ba"), "+395 80 (687) 45-73", new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("92d557f4-037f-43b0-9548-01cd68058bcc"), new Guid("92d557f4-037f-43b0-9548-01cd68058bcc"), "+994 08 (750) 18-14", new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403") },
                    { new Guid("93338737-22cf-4511-b8b4-de48f95807d9"), new Guid("93338737-22cf-4511-b8b4-de48f95807d9"), "+453 45 (784) 29-45", new Guid("f1038abe-cd17-40c4-844a-70a0ee863724") },
                    { new Guid("9334368a-19e8-48b3-a4da-7525ac00cba4"), new Guid("9334368a-19e8-48b3-a4da-7525ac00cba4"), "+735 90 (198) 74-38", new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("9366db99-6860-45b3-8727-318baa33224f"), new Guid("9366db99-6860-45b3-8727-318baa33224f"), "+427 62 (357) 91-49", new Guid("0511de28-2afb-4492-a1a6-ca490859b247") },
                    { new Guid("947fb91e-661c-43e2-aead-ccf5a8d46c1c"), new Guid("947fb91e-661c-43e2-aead-ccf5a8d46c1c"), "+93 96 (088) 16-59", new Guid("a390c413-dcb9-40e9-bfa0-2d32c926e258") },
                    { new Guid("96e56ae8-1b4d-4d39-bc88-fe69b4e7c343"), new Guid("96e56ae8-1b4d-4d39-bc88-fe69b4e7c343"), "+888 88 (934) 34-99", new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("96f5570c-640f-4c0c-8e97-0586466e18e7"), new Guid("96f5570c-640f-4c0c-8e97-0586466e18e7"), "+974 60 (669) 29-03", new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("970fbb87-3d89-4b76-8aac-f95f25323e28"), new Guid("970fbb87-3d89-4b76-8aac-f95f25323e28"), "+303 06 (223) 47-91", new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df") },
                    { new Guid("978d2095-35f9-4858-96c9-7d0cd849a892"), new Guid("978d2095-35f9-4858-96c9-7d0cd849a892"), "+62 12 (601) 86-08", new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("97c078ec-df23-4716-a185-5a6c440a6d9b"), new Guid("97c078ec-df23-4716-a185-5a6c440a6d9b"), "+50 81 (552) 92-06", new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("981c186d-db7a-4637-8f49-18be11cb732c"), new Guid("981c186d-db7a-4637-8f49-18be11cb732c"), "+382 79 (034) 62-81", new Guid("8f8cd90d-fe20-4df0-8607-72f337546146") },
                    { new Guid("983d205e-38eb-44df-9134-e9d742040274"), new Guid("983d205e-38eb-44df-9134-e9d742040274"), "+451 51 (343) 22-80", new Guid("0462fe55-138a-4c03-a20d-8251dee6c206") },
                    { new Guid("984f8201-a7f8-453b-a6f8-e4d8c85d1ecf"), new Guid("984f8201-a7f8-453b-a6f8-e4d8c85d1ecf"), "+165 49 (416) 71-82", new Guid("ed7f306c-acf8-402c-83be-d31b14933bcf") },
                    { new Guid("9870f0ae-39aa-4763-8d97-144a970d6bad"), new Guid("9870f0ae-39aa-4763-8d97-144a970d6bad"), "+991 61 (381) 41-22", new Guid("1191988d-7eb8-4207-8d78-5329d9bca6a1") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("98b1ec82-ce01-4893-9209-39600ef27b00"), new Guid("98b1ec82-ce01-4893-9209-39600ef27b00"), "+619 23 (049) 96-63", new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("98bb2edc-6464-4aa6-af51-5456c533d0c2"), new Guid("98bb2edc-6464-4aa6-af51-5456c533d0c2"), "+514 33 (536) 93-69", new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("99bab7cb-74bb-4f65-9a3d-2bf27f4b9fdd"), new Guid("99bab7cb-74bb-4f65-9a3d-2bf27f4b9fdd"), "+551 58 (191) 49-65", new Guid("ebaa1ffd-e2ed-4322-a6ca-f0187d64e9f5") },
                    { new Guid("99fb4c23-30b3-49b5-80e5-526e7d55050b"), new Guid("99fb4c23-30b3-49b5-80e5-526e7d55050b"), "+307 15 (227) 26-66", new Guid("88e891f4-f687-4eab-ab6c-4cd4acc9f918") },
                    { new Guid("9a0c17e3-b63b-4588-92b3-b53a4f26c45b"), new Guid("9a0c17e3-b63b-4588-92b3-b53a4f26c45b"), "+579 34 (408) 94-16", new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("9a6a615f-8700-4d56-b91b-c9fb7ae8a025"), new Guid("9a6a615f-8700-4d56-b91b-c9fb7ae8a025"), "+335 00 (002) 58-70", new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("9a6c99d6-9993-4f77-9dfc-ce6f7ce771f3"), new Guid("9a6c99d6-9993-4f77-9dfc-ce6f7ce771f3"), "+813 25 (545) 53-90", new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("9a79a3c4-4c2b-464a-b8a7-6ff1be7a26cc"), new Guid("9a79a3c4-4c2b-464a-b8a7-6ff1be7a26cc"), "+858 48 (019) 04-54", new Guid("b8b12c74-a2c6-4fcb-9f07-d2adf37f405c") },
                    { new Guid("9b0c93b1-d0da-4e31-b31e-c9b33dc736dd"), new Guid("9b0c93b1-d0da-4e31-b31e-c9b33dc736dd"), "+568 49 (097) 94-70", new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("9b272de2-4fa5-406f-b4f7-2b24f136a61f"), new Guid("9b272de2-4fa5-406f-b4f7-2b24f136a61f"), "+135 64 (384) 33-13", new Guid("b4516831-ab62-4263-bd16-0e0413ce11c8") },
                    { new Guid("9beb8f2f-9a7a-488e-82de-d79e94526280"), new Guid("9beb8f2f-9a7a-488e-82de-d79e94526280"), "+873 07 (517) 28-30", new Guid("12656ae7-3922-41ca-b159-f79b439a354c") },
                    { new Guid("9c30ac4c-b9b9-46ce-8f12-87ff8448ac38"), new Guid("9c30ac4c-b9b9-46ce-8f12-87ff8448ac38"), "+192 48 (899) 38-89", new Guid("b8c1eef7-cfb7-4815-88ce-eced962927df") },
                    { new Guid("9c3ae72a-e89d-4943-9eb4-7cd307ef9123"), new Guid("9c3ae72a-e89d-4943-9eb4-7cd307ef9123"), "+923 13 (639) 41-49", new Guid("54544805-6149-40a0-a366-c2fb8f55975f") },
                    { new Guid("9c651967-29af-4085-8bf5-39ae31e54333"), new Guid("9c651967-29af-4085-8bf5-39ae31e54333"), "+373 99 (673) 93-19", new Guid("9d807f9b-986a-46d6-bfbc-df96128642e5") },
                    { new Guid("9d32c076-1dca-4178-812f-8338c3430d52"), new Guid("9d32c076-1dca-4178-812f-8338c3430d52"), "+531 61 (676) 15-45", new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("9d5d0e11-9e35-468a-886e-2efc8c41ca75"), new Guid("9d5d0e11-9e35-468a-886e-2efc8c41ca75"), "+171 65 (571) 27-67", new Guid("f52aa5d9-7738-43a9-8aa8-68fd78a2e075") },
                    { new Guid("9da7b629-a1af-4609-b8aa-a0fcbb602217"), new Guid("9da7b629-a1af-4609-b8aa-a0fcbb602217"), "+958 94 (535) 61-09", new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("9ddf6965-54a1-4e0b-ac94-732ed57038df"), new Guid("9ddf6965-54a1-4e0b-ac94-732ed57038df"), "+310 12 (676) 37-56", new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22") },
                    { new Guid("9e026dcf-8ad7-4de4-9199-cf1adf935254"), new Guid("9e026dcf-8ad7-4de4-9199-cf1adf935254"), "+490 63 (221) 97-97", new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("9e15eb8c-e354-40ea-9c1b-5d9ce65d901a"), new Guid("9e15eb8c-e354-40ea-9c1b-5d9ce65d901a"), "+140 22 (840) 83-47", new Guid("cdca71e7-9f3a-48d4-bd2c-c7f27b628072") },
                    { new Guid("9e30bf36-cdae-4757-8c96-a9e84f366c6b"), new Guid("9e30bf36-cdae-4757-8c96-a9e84f366c6b"), "+127 18 (498) 17-31", new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("9e720362-6780-4256-bd48-1862c9862e60"), new Guid("9e720362-6780-4256-bd48-1862c9862e60"), "+301 78 (088) 07-22", new Guid("43a7fd5b-5e50-4eac-951f-614d3c7d0119") },
                    { new Guid("9e90f0ed-8f04-46db-9a43-0dc1ee3b1455"), new Guid("9e90f0ed-8f04-46db-9a43-0dc1ee3b1455"), "+460 35 (350) 12-27", new Guid("bd6b218c-405c-427a-b127-b0aab9d91e47") },
                    { new Guid("9ea01319-7520-4677-9b28-77f136755af5"), new Guid("9ea01319-7520-4677-9b28-77f136755af5"), "+172 75 (585) 66-23", new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("9eb20664-fdee-41ed-bc94-d2a77d90e19f"), new Guid("9eb20664-fdee-41ed-bc94-d2a77d90e19f"), "+210 94 (543) 38-35", new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("9ec79110-140b-433c-9e07-b48664a43349"), new Guid("9ec79110-140b-433c-9e07-b48664a43349"), "+170 69 (853) 82-71", new Guid("9a8e93b9-cd74-4516-823c-a7d66f5ee3c9") },
                    { new Guid("9ec9605e-ed03-476a-aea1-d953c1e12c76"), new Guid("9ec9605e-ed03-476a-aea1-d953c1e12c76"), "+636 21 (176) 59-88", new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("9f8905d8-a0e8-4513-aaba-8f8e337fdb7a"), new Guid("9f8905d8-a0e8-4513-aaba-8f8e337fdb7a"), "+322 46 (133) 98-71", new Guid("5105db79-7065-4dc2-a3f4-9ae3b01d070a") },
                    { new Guid("9feb3d52-010c-4292-a6ad-706d20aeeb07"), new Guid("9feb3d52-010c-4292-a6ad-706d20aeeb07"), "+134 74 (032) 95-54", new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb") },
                    { new Guid("a0a56fd0-9004-414c-9df3-740c96743ee3"), new Guid("a0a56fd0-9004-414c-9df3-740c96743ee3"), "+511 00 (061) 94-85", new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("a1176658-9235-4912-bba4-b8a960f8edb1"), new Guid("a1176658-9235-4912-bba4-b8a960f8edb1"), "+988 55 (558) 35-01", new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("a1b6602f-3a50-4240-8b13-dc53c609aff1"), new Guid("a1b6602f-3a50-4240-8b13-dc53c609aff1"), "+282 97 (912) 27-86", new Guid("062fbf9a-46b7-44ed-bb8b-cd31087b6b95") },
                    { new Guid("a1d08b66-e7e2-4c7f-9637-cdba7b1b35b4"), new Guid("a1d08b66-e7e2-4c7f-9637-cdba7b1b35b4"), "+348 06 (415) 08-57", new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4") },
                    { new Guid("a206848c-03ee-442a-abad-2f9afc216458"), new Guid("a206848c-03ee-442a-abad-2f9afc216458"), "+583 83 (890) 99-78", new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("a217fc1c-7543-49bc-aae9-1b8490f2acda"), new Guid("a217fc1c-7543-49bc-aae9-1b8490f2acda"), "+563 61 (987) 95-49", new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("a271e77e-c2f1-4d4d-a0e5-d35b2aa26bb9"), new Guid("a271e77e-c2f1-4d4d-a0e5-d35b2aa26bb9"), "+642 93 (640) 66-13", new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("a3620266-7c0f-4f0b-8ce5-13179bddee15"), new Guid("a3620266-7c0f-4f0b-8ce5-13179bddee15"), "+503 21 (781) 75-76", new Guid("7f2101a2-e8ea-4c05-9b87-d5deecff5977") },
                    { new Guid("a39c5514-dd11-418e-9c6b-8abc35201a95"), new Guid("a39c5514-dd11-418e-9c6b-8abc35201a95"), "+131 77 (327) 49-42", new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("a3f10a9c-8fee-4804-9706-34b49cbb42f9"), new Guid("a3f10a9c-8fee-4804-9706-34b49cbb42f9"), "+688 31 (457) 34-88", new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("a410a72d-2be2-4091-b177-87d833d3c0d5"), new Guid("a410a72d-2be2-4091-b177-87d833d3c0d5"), "+152 84 (743) 06-62", new Guid("74cbfa0b-23fb-4b4e-b600-74734270523b") },
                    { new Guid("a41a4a89-d81a-4368-b08d-aa6a74dbca4b"), new Guid("a41a4a89-d81a-4368-b08d-aa6a74dbca4b"), "+759 25 (613) 86-06", new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("a46e2e5c-d079-4273-8c67-cfd8d3d15ab3"), new Guid("a46e2e5c-d079-4273-8c67-cfd8d3d15ab3"), "+257 17 (073) 10-89", new Guid("d422e4b4-5d7b-484f-830c-319350a69b22") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("a4a7696c-71f7-4625-b793-99b13668693a"), new Guid("a4a7696c-71f7-4625-b793-99b13668693a"), "+666 17 (612) 72-61", new Guid("720b27cf-4f43-4407-90ff-251b345a1c2a") },
                    { new Guid("a505cd38-74b9-474f-b8a6-33d5ca5d5be0"), new Guid("a505cd38-74b9-474f-b8a6-33d5ca5d5be0"), "+252 90 (440) 06-46", new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c") },
                    { new Guid("a5465205-da4f-4218-a540-0abab6b0b2c9"), new Guid("a5465205-da4f-4218-a540-0abab6b0b2c9"), "+841 14 (911) 40-66", new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("a5ed8102-8dd7-4cbb-936f-611d6f6e8f67"), new Guid("a5ed8102-8dd7-4cbb-936f-611d6f6e8f67"), "+122 66 (229) 36-99", new Guid("bdb18c37-1b06-4f9f-9a4e-c200b272e376") },
                    { new Guid("a5fd6631-8a9f-4acd-9927-f3b9db95871a"), new Guid("a5fd6631-8a9f-4acd-9927-f3b9db95871a"), "+953 26 (178) 59-77", new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("a61b68a5-5504-4121-a314-3d8f46eeceb5"), new Guid("a61b68a5-5504-4121-a314-3d8f46eeceb5"), "+874 23 (425) 89-14", new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("a6813586-74d1-4b10-ab59-2724877237a8"), new Guid("a6813586-74d1-4b10-ab59-2724877237a8"), "+147 42 (807) 56-35", new Guid("e5acadcd-43bb-4225-9367-f562e86197e5") },
                    { new Guid("a6a1719a-758a-43db-8b56-103219283f15"), new Guid("a6a1719a-758a-43db-8b56-103219283f15"), "+464 91 (916) 99-66", new Guid("c5150ae9-8339-4a13-86ff-e8f923c960d4") },
                    { new Guid("a73ccf12-4042-42cc-b7e1-5ce6d176bebe"), new Guid("a73ccf12-4042-42cc-b7e1-5ce6d176bebe"), "+238 35 (780) 68-60", new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("a83430c3-d74a-4458-9590-c0f5d2b8b808"), new Guid("a83430c3-d74a-4458-9590-c0f5d2b8b808"), "+620 27 (922) 98-03", new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("a865785b-425e-4823-8124-5c90c97ed037"), new Guid("a865785b-425e-4823-8124-5c90c97ed037"), "+413 31 (056) 71-74", new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8") },
                    { new Guid("a899e533-cf5c-4bab-ad85-4249612c387c"), new Guid("a899e533-cf5c-4bab-ad85-4249612c387c"), "+770 59 (501) 13-73", new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("a8d6afd3-e21a-4ebf-bc7c-339f4a2ae37c"), new Guid("a8d6afd3-e21a-4ebf-bc7c-339f4a2ae37c"), "+280 79 (454) 35-23", new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("a90475c8-b7f7-42fd-99f0-185ae5e18bca"), new Guid("a90475c8-b7f7-42fd-99f0-185ae5e18bca"), "+790 63 (634) 66-81", new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("a93cb6c1-f509-4c2a-adb2-0718bdfd124e"), new Guid("a93cb6c1-f509-4c2a-adb2-0718bdfd124e"), "+192 15 (374) 17-88", new Guid("ececce7b-505c-4bc7-b969-56ffcc451462") },
                    { new Guid("a9527e55-2d6c-4a1c-9332-40aecb6f13a1"), new Guid("a9527e55-2d6c-4a1c-9332-40aecb6f13a1"), "+765 97 (156) 51-19", new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("a992a705-ab88-42a8-8127-850f2bf4e7b1"), new Guid("a992a705-ab88-42a8-8127-850f2bf4e7b1"), "+536 79 (109) 70-68", new Guid("ce9cc1e6-a4c6-41e5-8c4d-1d787e8e7d48") },
                    { new Guid("a9b52e1a-16e2-4a36-8ae2-851c6bcee0e5"), new Guid("a9b52e1a-16e2-4a36-8ae2-851c6bcee0e5"), "+303 67 (331) 14-15", new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88") },
                    { new Guid("aa01d5c6-9c92-432d-b0ea-c835b6b17556"), new Guid("aa01d5c6-9c92-432d-b0ea-c835b6b17556"), "+205 15 (645) 72-71", new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("aa683d0a-262c-41b1-98e9-3d0e0b9b4f4c"), new Guid("aa683d0a-262c-41b1-98e9-3d0e0b9b4f4c"), "+203 89 (955) 17-25", new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("aa9b1ff3-5044-4ade-9d54-e371ba64dd25"), new Guid("aa9b1ff3-5044-4ade-9d54-e371ba64dd25"), "+509 53 (632) 43-56", new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("aad02e32-93bd-4420-82ce-deee47bcf013"), new Guid("aad02e32-93bd-4420-82ce-deee47bcf013"), "+448 00 (369) 96-87", new Guid("07dbd568-b940-43b4-9a25-b292ef963dd6") },
                    { new Guid("ab9eaa9a-7f62-44a9-af58-d86cb33f3e0d"), new Guid("ab9eaa9a-7f62-44a9-af58-d86cb33f3e0d"), "+418 05 (311) 58-24", new Guid("6aaf0da2-aff2-47a2-90db-a32a9c8411d0") },
                    { new Guid("ac01939e-77bb-41a0-8135-927774d5ff67"), new Guid("ac01939e-77bb-41a0-8135-927774d5ff67"), "+297 67 (228) 97-67", new Guid("5a7918ac-3262-4ada-a7bb-4950e5b62e61") },
                    { new Guid("adbdf0e6-2594-48f2-b31c-ac67e2f6bc73"), new Guid("adbdf0e6-2594-48f2-b31c-ac67e2f6bc73"), "+702 46 (701) 48-66", new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("ae0c153a-6cd2-4777-9d2d-e944ba9f653c"), new Guid("ae0c153a-6cd2-4777-9d2d-e944ba9f653c"), "+115 25 (104) 30-48", new Guid("12656ae7-3922-41ca-b159-f79b439a354c") },
                    { new Guid("ae2a1b5e-dbaa-4f87-8125-f4840f286c94"), new Guid("ae2a1b5e-dbaa-4f87-8125-f4840f286c94"), "+535 20 (761) 72-21", new Guid("54544805-6149-40a0-a366-c2fb8f55975f") },
                    { new Guid("ae5751dd-ecea-4610-a66b-cbb63e9a04db"), new Guid("ae5751dd-ecea-4610-a66b-cbb63e9a04db"), "+696 75 (149) 72-43", new Guid("d05e3d17-a03a-4153-ada4-1cafb88b1af8") },
                    { new Guid("ae6668bf-b438-4e9b-8b99-a19f48641d7f"), new Guid("ae6668bf-b438-4e9b-8b99-a19f48641d7f"), "+117 53 (775) 88-31", new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") },
                    { new Guid("ae743abb-d74e-4da5-ba1c-51193dabdc0b"), new Guid("ae743abb-d74e-4da5-ba1c-51193dabdc0b"), "+76 22 (778) 60-59", new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("ae935682-eeba-4d09-b9f8-3276c0ffc624"), new Guid("ae935682-eeba-4d09-b9f8-3276c0ffc624"), "+417 80 (269) 00-25", new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3") },
                    { new Guid("aeb70d83-03c7-4a3b-8555-eee0458810f7"), new Guid("aeb70d83-03c7-4a3b-8555-eee0458810f7"), "+6 59 (652) 00-21", new Guid("109546c9-8ef4-4067-8b0b-82a97c5dac76") },
                    { new Guid("aec24e7d-11bd-459d-8bd8-596bb5adb6e3"), new Guid("aec24e7d-11bd-459d-8bd8-596bb5adb6e3"), "+304 75 (175) 08-15", new Guid("72a9dd4f-9f68-4352-95d1-cccb35d37cc7") },
                    { new Guid("aeeac94e-ae93-4a69-817f-7de3dbb2cb6d"), new Guid("aeeac94e-ae93-4a69-817f-7de3dbb2cb6d"), "+496 93 (514) 50-73", new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2") },
                    { new Guid("af267aa9-6a4e-4ae1-a3b4-c110a72a0e05"), new Guid("af267aa9-6a4e-4ae1-a3b4-c110a72a0e05"), "+263 03 (302) 77-68", new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899") },
                    { new Guid("afd73267-8b2c-40ae-8b23-487981df7d4f"), new Guid("afd73267-8b2c-40ae-8b23-487981df7d4f"), "+740 59 (137) 95-09", new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("b0ef7562-fb1a-4287-974a-927ea49ec9e1"), new Guid("b0ef7562-fb1a-4287-974a-927ea49ec9e1"), "+93 47 (138) 03-90", new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("b1439079-4fc1-4fc6-8724-086aaba13c67"), new Guid("b1439079-4fc1-4fc6-8724-086aaba13c67"), "+248 94 (952) 53-05", new Guid("e5873863-5f02-49f2-b6e6-faae1acea124") },
                    { new Guid("b1925130-2f51-4599-be9b-49f5d32caa28"), new Guid("b1925130-2f51-4599-be9b-49f5d32caa28"), "+680 69 (105) 25-21", new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("b1ab22be-62fa-4d2c-9599-03754d7c3888"), new Guid("b1ab22be-62fa-4d2c-9599-03754d7c3888"), "+356 41 (065) 60-41", new Guid("0823436c-27ad-4402-b5e2-b17efa08505e") },
                    { new Guid("b1d2c480-bdce-459b-a9a8-af8770ffbd9a"), new Guid("b1d2c480-bdce-459b-a9a8-af8770ffbd9a"), "+413 70 (789) 15-06", new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("b25b4cab-d7db-4793-bad7-8864d3f1c1fd"), new Guid("b25b4cab-d7db-4793-bad7-8864d3f1c1fd"), "+586 09 (734) 97-60", new Guid("1686e88a-2154-49c5-b685-cb51bf2b800d") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("b2bfee46-fc00-4ef1-99c7-8f2fe61dccd2"), new Guid("b2bfee46-fc00-4ef1-99c7-8f2fe61dccd2"), "+352 47 (382) 48-62", new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("b314730f-41e7-4ff8-b4ec-909fbee0323e"), new Guid("b314730f-41e7-4ff8-b4ec-909fbee0323e"), "+337 38 (615) 92-33", new Guid("f34eac31-c6eb-4330-a9e7-4ad56c1dc425") },
                    { new Guid("b3471f1b-2ab2-400f-bfa0-372b298e2925"), new Guid("b3471f1b-2ab2-400f-bfa0-372b298e2925"), "+810 12 (077) 13-75", new Guid("665af7ab-85d3-48f3-bedd-30db54699f81") },
                    { new Guid("b34dc42f-8017-479f-b74d-dccdeed84078"), new Guid("b34dc42f-8017-479f-b74d-dccdeed84078"), "+337 27 (885) 61-69", new Guid("04d1b042-8e23-4b30-a8f9-1bf6ec32c037") },
                    { new Guid("b3527814-2ad4-4c70-af50-028c45f1f5af"), new Guid("b3527814-2ad4-4c70-af50-028c45f1f5af"), "+643 27 (937) 47-49", new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("b354eefb-4a3e-4443-8f27-a65a28665380"), new Guid("b354eefb-4a3e-4443-8f27-a65a28665380"), "+964 04 (898) 97-47", new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("b3f138cd-ac63-42f3-8367-f0fc3eb9ecb2"), new Guid("b3f138cd-ac63-42f3-8367-f0fc3eb9ecb2"), "+60 70 (671) 12-15", new Guid("0136c022-fcf1-47a8-a481-723709054ce0") },
                    { new Guid("b45e1696-6975-4317-85fe-474af1740d8b"), new Guid("b45e1696-6975-4317-85fe-474af1740d8b"), "+931 26 (940) 55-35", new Guid("363c7ed4-58fc-4c95-b967-b7f30909324d") },
                    { new Guid("b49726e6-e0dd-4d28-8cde-5c59c8654c3c"), new Guid("b49726e6-e0dd-4d28-8cde-5c59c8654c3c"), "+448 05 (751) 12-71", new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("b4ba6436-2f9d-4230-9fcc-c9044e32cf7f"), new Guid("b4ba6436-2f9d-4230-9fcc-c9044e32cf7f"), "+403 72 (723) 40-05", new Guid("71725c06-aded-4994-8181-26d1683597c4") },
                    { new Guid("b560c8c4-4afe-47f1-8cb5-7227562f240c"), new Guid("b560c8c4-4afe-47f1-8cb5-7227562f240c"), "+499 94 (900) 48-48", new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("b57c72e1-a247-491e-a410-be69b0b52e25"), new Guid("b57c72e1-a247-491e-a410-be69b0b52e25"), "+650 25 (771) 03-67", new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("b592cf36-281f-416f-975c-f40ef72a8afb"), new Guid("b592cf36-281f-416f-975c-f40ef72a8afb"), "+707 58 (300) 23-24", new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("b59436dd-8c7b-4ceb-be37-a21552d4c5cc"), new Guid("b59436dd-8c7b-4ceb-be37-a21552d4c5cc"), "+693 11 (930) 53-22", new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("b5b5df8b-028a-4208-90cc-36ae59f19067"), new Guid("b5b5df8b-028a-4208-90cc-36ae59f19067"), "+78 40 (445) 97-16", new Guid("01854a4c-9a7d-4592-8b51-a14c4d097626") },
                    { new Guid("b70b50dd-1ac3-4e67-8e15-ef811f409a0b"), new Guid("b70b50dd-1ac3-4e67-8e15-ef811f409a0b"), "+316 76 (830) 69-45", new Guid("e98ca19d-dcf8-45b9-bcca-f3480f0d4651") },
                    { new Guid("b713c9f4-98dc-46ae-932c-f7ce2b89ae2d"), new Guid("b713c9f4-98dc-46ae-932c-f7ce2b89ae2d"), "+828 99 (601) 35-55", new Guid("e7a927d0-7ec5-4b52-8094-4dc0e8c2de9b") },
                    { new Guid("b72370dd-5f72-4f85-89d9-7e2b995be164"), new Guid("b72370dd-5f72-4f85-89d9-7e2b995be164"), "+591 42 (278) 95-42", new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("b78fd7e1-0a09-4063-b4a4-7184a8fc34cd"), new Guid("b78fd7e1-0a09-4063-b4a4-7184a8fc34cd"), "+532 95 (679) 24-65", new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("b96815f9-2d4e-4003-ada4-80eeec4e9d6f"), new Guid("b96815f9-2d4e-4003-ada4-80eeec4e9d6f"), "+797 71 (917) 19-57", new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("b9953749-c27c-4f9c-8acf-532952fadd34"), new Guid("b9953749-c27c-4f9c-8acf-532952fadd34"), "+961 18 (047) 19-49", new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("b99e00e0-d5e4-458f-ada3-c6c6c30551d8"), new Guid("b99e00e0-d5e4-458f-ada3-c6c6c30551d8"), "+521 98 (913) 43-25", new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") },
                    { new Guid("b9aaa57e-08f9-4d16-8208-b9e812e18907"), new Guid("b9aaa57e-08f9-4d16-8208-b9e812e18907"), "+209 70 (805) 85-22", new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("b9b571b3-4af0-41da-82e2-45fa4f0e2f9c"), new Guid("b9b571b3-4af0-41da-82e2-45fa4f0e2f9c"), "+950 51 (424) 64-67", new Guid("46be47fc-f44f-4a97-adbb-3f83f74ab978") },
                    { new Guid("badef349-4519-4b32-9026-db129b05008b"), new Guid("badef349-4519-4b32-9026-db129b05008b"), "+864 30 (513) 51-85", new Guid("50c204cc-4c1e-458e-aa64-2bbe18bccd64") },
                    { new Guid("bb625633-4844-4e10-955a-94e0d1f2d5c9"), new Guid("bb625633-4844-4e10-955a-94e0d1f2d5c9"), "+784 57 (706) 98-64", new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("bb6e1e6e-815d-41cc-8d56-e11373cca9ef"), new Guid("bb6e1e6e-815d-41cc-8d56-e11373cca9ef"), "+283 72 (662) 26-23", new Guid("d69c6ac1-f3ea-4e89-a0e9-6b61b009d628") },
                    { new Guid("bb84994e-0fa2-4dad-b785-9552f004eca7"), new Guid("bb84994e-0fa2-4dad-b785-9552f004eca7"), "+433 60 (046) 62-64", new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("bbbdd2c7-6b8c-4a75-bee6-af7f15ea39c2"), new Guid("bbbdd2c7-6b8c-4a75-bee6-af7f15ea39c2"), "+98 35 (278) 70-48", new Guid("5d281e5f-cdc7-4bf8-9929-8243b58a543e") },
                    { new Guid("bc6755d8-a77c-495c-810d-03b9988a5b80"), new Guid("bc6755d8-a77c-495c-810d-03b9988a5b80"), "+387 65 (305) 56-99", new Guid("5558c531-153b-4da7-9848-996b07daa782") },
                    { new Guid("bcc2607f-51cc-4cbf-b0aa-6452a955cdd2"), new Guid("bcc2607f-51cc-4cbf-b0aa-6452a955cdd2"), "+390 05 (874) 31-27", new Guid("2bcc6f82-a2d9-46b6-b8e8-b1ae9100f13b") },
                    { new Guid("bd0e8976-b3fd-442b-8945-0057cb08a132"), new Guid("bd0e8976-b3fd-442b-8945-0057cb08a132"), "+970 53 (014) 95-35", new Guid("6ad3dae4-3069-4cef-8e13-bee86e9a4f6a") },
                    { new Guid("bd5f22a5-57c8-4275-b085-5ded90a91a35"), new Guid("bd5f22a5-57c8-4275-b085-5ded90a91a35"), "+563 22 (472) 02-98", new Guid("23ea9c4d-f791-4c66-bbef-c5387fd33828") },
                    { new Guid("be0dfb82-6709-4779-863a-7b01fca5643a"), new Guid("be0dfb82-6709-4779-863a-7b01fca5643a"), "+271 23 (709) 42-68", new Guid("d9444564-5ac6-40eb-8fd8-6c3c31c80be0") },
                    { new Guid("bee36f31-6824-4d6d-afd4-f4a6a0dcc9f2"), new Guid("bee36f31-6824-4d6d-afd4-f4a6a0dcc9f2"), "+333 70 (097) 18-03", new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("c0167e71-c936-4c3c-a2ac-10d72041507f"), new Guid("c0167e71-c936-4c3c-a2ac-10d72041507f"), "+602 06 (342) 70-03", new Guid("aecdc89e-7bb6-47d3-abc9-0e8278b0abb5") },
                    { new Guid("c01e2159-c5d4-4c64-a8a4-3fcdf4097755"), new Guid("c01e2159-c5d4-4c64-a8a4-3fcdf4097755"), "+767 90 (977) 22-22", new Guid("fcf0781a-98c8-45f5-bdd7-dcd95610bc73") },
                    { new Guid("c05803e5-9b64-4cb7-afad-fc1a17c7ef6f"), new Guid("c05803e5-9b64-4cb7-afad-fc1a17c7ef6f"), "+615 07 (066) 04-35", new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("c067890f-762e-4a79-9046-d798ed6b1d44"), new Guid("c067890f-762e-4a79-9046-d798ed6b1d44"), "+281 82 (823) 56-04", new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("c086133c-e952-4daa-9690-ea5d94acfc97"), new Guid("c086133c-e952-4daa-9690-ea5d94acfc97"), "+992 36 (581) 05-46", new Guid("fd8d42b8-9ad1-45c7-adb2-9f3adcb1cf65") },
                    { new Guid("c091cc6b-3075-41dc-a2dd-7f450999fa69"), new Guid("c091cc6b-3075-41dc-a2dd-7f450999fa69"), "+606 51 (147) 35-15", new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("c0bf5ab5-ec25-4ffd-ae00-0d328e5c4051"), new Guid("c0bf5ab5-ec25-4ffd-ae00-0d328e5c4051"), "+312 29 (848) 57-65", new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("c12b1082-7f47-44c8-911d-5181a54107ce"), new Guid("c12b1082-7f47-44c8-911d-5181a54107ce"), "+422 48 (112) 73-34", new Guid("c0886dea-4971-4369-8d28-75754e2575d0") },
                    { new Guid("c146a6f7-7597-45c5-9e73-b00ce2e9d8cf"), new Guid("c146a6f7-7597-45c5-9e73-b00ce2e9d8cf"), "+747 64 (673) 74-75", new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("c19ec444-eaeb-453d-accb-675ff89574f3"), new Guid("c19ec444-eaeb-453d-accb-675ff89574f3"), "+292 59 (138) 01-29", new Guid("28f12604-451b-425e-ae23-1db801053b3e") },
                    { new Guid("c1ac4afd-2fee-4b75-b6fa-ae6ee489b5ac"), new Guid("c1ac4afd-2fee-4b75-b6fa-ae6ee489b5ac"), "+923 12 (062) 11-44", new Guid("5f36ec0d-438c-46ac-ac3a-2c1ad6a0c9e7") },
                    { new Guid("c227260f-4412-4f4f-9995-643524359a51"), new Guid("c227260f-4412-4f4f-9995-643524359a51"), "+255 65 (259) 43-37", new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") },
                    { new Guid("c2a3e749-3dda-4d94-8889-1ea57f241439"), new Guid("c2a3e749-3dda-4d94-8889-1ea57f241439"), "+642 86 (805) 80-53", new Guid("203cc97b-91be-4474-b881-e9776da21af9") },
                    { new Guid("c2aea808-31cb-429b-81d4-25fafda64a19"), new Guid("c2aea808-31cb-429b-81d4-25fafda64a19"), "+996 71 (708) 02-38", new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("c2e7983d-0050-466d-9cc7-79d9cb2b718b"), new Guid("c2e7983d-0050-466d-9cc7-79d9cb2b718b"), "+952 14 (835) 56-83", new Guid("f7e86b66-49eb-4774-82be-b008350dc98b") },
                    { new Guid("c2ef5246-e6fc-4614-bd08-bd8af2ade90f"), new Guid("c2ef5246-e6fc-4614-bd08-bd8af2ade90f"), "+381 98 (608) 19-00", new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("c2f8fb48-0dc6-463b-adbe-938b6a25c5f6"), new Guid("c2f8fb48-0dc6-463b-adbe-938b6a25c5f6"), "+300 77 (005) 86-53", new Guid("85d18615-ac5d-41d3-a7c4-7460139b00c3") },
                    { new Guid("c3141053-53b5-478a-8933-63f1091046c6"), new Guid("c3141053-53b5-478a-8933-63f1091046c6"), "+603 21 (763) 39-86", new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("c3e06153-5f09-42af-b5dd-d8ae68894bdc"), new Guid("c3e06153-5f09-42af-b5dd-d8ae68894bdc"), "+19 82 (076) 15-71", new Guid("8b896efc-3b46-4670-bb2b-740919a113b5") },
                    { new Guid("c3f80bec-5b81-4bda-882b-8be7d41d3282"), new Guid("c3f80bec-5b81-4bda-882b-8be7d41d3282"), "+914 48 (403) 96-41", new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("c404d7bd-95bd-4c7a-80df-3cfba7ee0326"), new Guid("c404d7bd-95bd-4c7a-80df-3cfba7ee0326"), "+130 06 (597) 05-78", new Guid("6c234f62-84bb-4dc6-9c6c-2397032e19e5") },
                    { new Guid("c5c7bd8b-3002-41f8-8fe1-57aa71406038"), new Guid("c5c7bd8b-3002-41f8-8fe1-57aa71406038"), "+948 32 (258) 83-88", new Guid("1d3e2124-bdf8-4d75-abc7-e87f5f21ffc4") },
                    { new Guid("c5f7d9ff-7689-454d-82a1-b9eead4a80b8"), new Guid("c5f7d9ff-7689-454d-82a1-b9eead4a80b8"), "+523 51 (438) 79-43", new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("c63228cc-1757-4fce-be70-849fcde050b5"), new Guid("c63228cc-1757-4fce-be70-849fcde050b5"), "+659 81 (823) 96-78", new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("c66073fc-b58f-4ec0-86e2-db5e64ddf8d8"), new Guid("c66073fc-b58f-4ec0-86e2-db5e64ddf8d8"), "+71 26 (250) 57-95", new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("c667029f-a764-4595-bbdf-f91045211c9f"), new Guid("c667029f-a764-4595-bbdf-f91045211c9f"), "+504 23 (692) 29-60", new Guid("f47953d9-5cae-4c1d-bc0c-b51d063c27fb") },
                    { new Guid("c6828f8d-f7db-464e-b500-5a48467245ff"), new Guid("c6828f8d-f7db-464e-b500-5a48467245ff"), "+206 65 (657) 21-85", new Guid("03857133-3938-47ab-89b3-0f89a63bb1fd") },
                    { new Guid("c75d4f02-110a-460a-bc44-9c55585a1047"), new Guid("c75d4f02-110a-460a-bc44-9c55585a1047"), "+466 54 (569) 39-76", new Guid("89b9c517-844a-4515-b8c2-f5c60d82badd") },
                    { new Guid("c7792361-aa8a-414f-8bf0-489c2860e7be"), new Guid("c7792361-aa8a-414f-8bf0-489c2860e7be"), "+950 21 (125) 56-06", new Guid("40cf1e93-57fa-4a5e-9437-8b65032c8bdd") },
                    { new Guid("c78e6c66-c46a-4fdb-9c2e-ea15ba761496"), new Guid("c78e6c66-c46a-4fdb-9c2e-ea15ba761496"), "+934 92 (480) 98-33", new Guid("8b896efc-3b46-4670-bb2b-740919a113b5") },
                    { new Guid("c80b553e-c8c6-446f-be48-99c54fec51aa"), new Guid("c80b553e-c8c6-446f-be48-99c54fec51aa"), "+660 76 (159) 10-43", new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("c85caa20-cc7a-427d-bfb8-e89f9162be07"), new Guid("c85caa20-cc7a-427d-bfb8-e89f9162be07"), "+448 16 (443) 62-24", new Guid("e3c50cd8-9dfe-4f5d-b384-32ae179bd3fa") },
                    { new Guid("c8b22754-589f-414a-a532-6f02c0cb45a4"), new Guid("c8b22754-589f-414a-a532-6f02c0cb45a4"), "+818 01 (315) 36-72", new Guid("e2125995-cb39-40eb-b23a-1483130a7d40") },
                    { new Guid("c8e6891b-3608-4c24-8800-0896ad0e7ef9"), new Guid("c8e6891b-3608-4c24-8800-0896ad0e7ef9"), "+764 58 (981) 19-00", new Guid("1eba2acf-c6d8-4a6b-b057-f910c665b1aa") },
                    { new Guid("c9674085-4e33-45c3-adbf-d11af4f62f66"), new Guid("c9674085-4e33-45c3-adbf-d11af4f62f66"), "+570 28 (332) 60-40", new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("c984b5d5-b8d5-4eea-8a96-bdf398ec7e58"), new Guid("c984b5d5-b8d5-4eea-8a96-bdf398ec7e58"), "+650 02 (240) 55-73", new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("c9a265f1-ebc1-4ae3-92b7-94c617b0839c"), new Guid("c9a265f1-ebc1-4ae3-92b7-94c617b0839c"), "+166 75 (245) 77-74", new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2") },
                    { new Guid("c9daa5ba-c641-4efa-9c60-22c67e05ced2"), new Guid("c9daa5ba-c641-4efa-9c60-22c67e05ced2"), "+746 89 (973) 27-74", new Guid("7af8b5ae-2cae-42d8-bedf-6ab3e5bc0e26") },
                    { new Guid("ca45be0a-ad3e-407e-817a-3244f01067f8"), new Guid("ca45be0a-ad3e-407e-817a-3244f01067f8"), "+15 87 (144) 53-65", new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("ca592fb3-b0b7-42a0-a233-dbc4c240ea1f"), new Guid("ca592fb3-b0b7-42a0-a233-dbc4c240ea1f"), "+850 50 (319) 43-10", new Guid("d24a5e1f-ed0a-4bc9-9bc3-58a678f80a22") },
                    { new Guid("cb77048c-da69-47be-bfe8-f5b390181876"), new Guid("cb77048c-da69-47be-bfe8-f5b390181876"), "+995 44 (722) 49-86", new Guid("35b6c210-2256-41cd-af8e-e815527e0a84") },
                    { new Guid("cb89d45e-dbf7-4636-940f-de247de7325e"), new Guid("cb89d45e-dbf7-4636-940f-de247de7325e"), "+796 13 (664) 76-04", new Guid("9084528b-4d5e-4106-8a9a-5368fb50384b") },
                    { new Guid("cc6186d3-330a-4daa-85cd-eb0d5e3a8c2c"), new Guid("cc6186d3-330a-4daa-85cd-eb0d5e3a8c2c"), "+145 30 (955) 30-83", new Guid("6254ae63-e0dd-466b-beed-ca9a6ba84f3d") },
                    { new Guid("cc901d1f-8c3a-426a-989d-7a8c28005c36"), new Guid("cc901d1f-8c3a-426a-989d-7a8c28005c36"), "+968 46 (638) 91-03", new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("ccbfe039-5762-4a44-89a3-f565fdecf9a4"), new Guid("ccbfe039-5762-4a44-89a3-f565fdecf9a4"), "+265 58 (743) 67-85", new Guid("c0886dea-4971-4369-8d28-75754e2575d0") },
                    { new Guid("cd059422-ab47-45eb-9b3d-21b5b4aa5fe6"), new Guid("cd059422-ab47-45eb-9b3d-21b5b4aa5fe6"), "+343 75 (999) 95-04", new Guid("f6e207b0-c57d-49cd-8186-78cbdff5e1aa") },
                    { new Guid("cd1fab31-2a89-48b9-8fa7-bda73fe82134"), new Guid("cd1fab31-2a89-48b9-8fa7-bda73fe82134"), "+113 29 (230) 34-08", new Guid("929537a1-831b-4666-bd2b-bda37e8e12e4") },
                    { new Guid("cda093f3-f3cd-44d8-bfe2-92d9d9d9612e"), new Guid("cda093f3-f3cd-44d8-bfe2-92d9d9d9612e"), "+178 73 (869) 87-97", new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("ce03ed81-ba06-420e-8af3-2ac9d382b28d"), new Guid("ce03ed81-ba06-420e-8af3-2ac9d382b28d"), "+246 67 (274) 00-57", new Guid("e7a030cd-5d27-498a-9a45-cb502f901bc4") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("ce3b3354-f993-465b-90a9-6a236594cfbe"), new Guid("ce3b3354-f993-465b-90a9-6a236594cfbe"), "+629 35 (524) 84-48", new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("cf64abf5-1683-462c-8909-9a1912d50c31"), new Guid("cf64abf5-1683-462c-8909-9a1912d50c31"), "+200 67 (257) 35-18", new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("d002e2bb-7d9a-4e0e-b385-da293de4841f"), new Guid("d002e2bb-7d9a-4e0e-b385-da293de4841f"), "+304 40 (079) 41-44", new Guid("314374c4-1bd7-4eda-8546-58617e464254") },
                    { new Guid("d036cf9b-9017-4e0e-ae02-101a6479b1b3"), new Guid("d036cf9b-9017-4e0e-ae02-101a6479b1b3"), "+466 19 (879) 98-56", new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("d1812f86-848f-45bc-aada-96a906221bcc"), new Guid("d1812f86-848f-45bc-aada-96a906221bcc"), "+365 49 (673) 23-37", new Guid("810775de-7e6f-4620-99bb-c534d912de67") },
                    { new Guid("d1d2e3e8-c541-4088-9174-1cde8c554d5e"), new Guid("d1d2e3e8-c541-4088-9174-1cde8c554d5e"), "+935 91 (360) 11-28", new Guid("dce3a946-ceb1-4a1f-81d9-e96f4ccd5d1b") },
                    { new Guid("d203a9fe-a100-40c1-9c37-3d5839715b82"), new Guid("d203a9fe-a100-40c1-9c37-3d5839715b82"), "+272 83 (863) 50-52", new Guid("a032bad9-18b0-41ae-a032-0fdcbe38b94f") },
                    { new Guid("d21fd6c4-9041-4bba-8666-f1295ac74d9e"), new Guid("d21fd6c4-9041-4bba-8666-f1295ac74d9e"), "+84 59 (125) 28-36", new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("d2467eff-8c2c-4b4c-a370-96ad8998f6be"), new Guid("d2467eff-8c2c-4b4c-a370-96ad8998f6be"), "+220 85 (947) 11-98", new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("d25ce1be-409b-4ea0-9139-93e2982a9e7d"), new Guid("d25ce1be-409b-4ea0-9139-93e2982a9e7d"), "+604 62 (071) 91-56", new Guid("8604dfec-8284-4ca8-8911-7d89e1637747") },
                    { new Guid("d28eb10d-a664-43ca-9b7a-379c140e6655"), new Guid("d28eb10d-a664-43ca-9b7a-379c140e6655"), "+975 99 (074) 09-11", new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("d2a77897-b9f9-4512-9e26-b5f4ba4007ec"), new Guid("d2a77897-b9f9-4512-9e26-b5f4ba4007ec"), "+264 17 (826) 21-29", new Guid("833a46e9-08d3-4c09-9378-aa2abed3953a") },
                    { new Guid("d2c95a47-8139-4be6-8858-b3b6054214ce"), new Guid("d2c95a47-8139-4be6-8858-b3b6054214ce"), "+342 93 (417) 69-57", new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") },
                    { new Guid("d2ca3fa5-5192-4804-931a-b50f73b9763c"), new Guid("d2ca3fa5-5192-4804-931a-b50f73b9763c"), "+47 86 (211) 69-18", new Guid("2a898ede-55ab-4baf-b5df-0feecf5e1ee6") },
                    { new Guid("d2ddad74-a141-4742-909f-144455524609"), new Guid("d2ddad74-a141-4742-909f-144455524609"), "+412 25 (528) 67-05", new Guid("cfddcc04-5205-447d-9799-6d1945c391b4") },
                    { new Guid("d2fb16d7-76a4-4739-860a-1205f7eca0bb"), new Guid("d2fb16d7-76a4-4739-860a-1205f7eca0bb"), "+689 72 (776) 90-31", new Guid("c6d10fd3-8c84-4ed6-84f2-711d9f83310a") },
                    { new Guid("d31f2d25-cacb-4ae0-9e9d-3466f6ab0627"), new Guid("d31f2d25-cacb-4ae0-9e9d-3466f6ab0627"), "+345 06 (282) 50-42", new Guid("b81e94bd-bc20-4e79-a711-c9bf9aa88718") },
                    { new Guid("d42ac673-0884-463c-9d62-26804e2f79f5"), new Guid("d42ac673-0884-463c-9d62-26804e2f79f5"), "+924 29 (085) 29-10", new Guid("a589c386-bec3-482e-bd20-c5b7a1172c26") },
                    { new Guid("d464d314-a6ff-4cc9-8db7-79e581115951"), new Guid("d464d314-a6ff-4cc9-8db7-79e581115951"), "+676 31 (800) 51-36", new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("d510012c-ef75-47f5-817b-45c034d58627"), new Guid("d510012c-ef75-47f5-817b-45c034d58627"), "+921 49 (445) 53-55", new Guid("ff11082d-6c98-410b-a3c4-9945a8e1a3af") },
                    { new Guid("d511665e-90a0-4900-a807-66d407b0a587"), new Guid("d511665e-90a0-4900-a807-66d407b0a587"), "+914 63 (315) 55-63", new Guid("bb3474fd-7ee5-43ee-a89b-17145bee2a7e") },
                    { new Guid("d51ffd90-0177-460b-b6dd-be4552d19b05"), new Guid("d51ffd90-0177-460b-b6dd-be4552d19b05"), "+191 75 (281) 53-02", new Guid("e86ca1e5-6d7e-4d7c-80ac-25fe2c1f8e1c") },
                    { new Guid("d532f78f-5533-43b7-8d88-e1aaed7bf156"), new Guid("d532f78f-5533-43b7-8d88-e1aaed7bf156"), "+582 12 (628) 39-20", new Guid("625edb92-d7c6-4f97-8bb9-623bb1427bf0") },
                    { new Guid("d5df9d31-a500-48e0-b35e-0f99d7562e48"), new Guid("d5df9d31-a500-48e0-b35e-0f99d7562e48"), "+597 30 (153) 37-05", new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("d6576909-4167-4d2c-889b-651db32f97ad"), new Guid("d6576909-4167-4d2c-889b-651db32f97ad"), "+471 54 (474) 83-32", new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("d65890f7-7922-41e7-b100-8b492131eb9f"), new Guid("d65890f7-7922-41e7-b100-8b492131eb9f"), "+552 72 (912) 36-82", new Guid("1690b048-3619-4b27-9353-5b4b8d79ac63") },
                    { new Guid("d7042e7f-6655-4d95-808c-07ac6dfdaf72"), new Guid("d7042e7f-6655-4d95-808c-07ac6dfdaf72"), "+305 63 (659) 67-30", new Guid("ae69d14b-158d-46a5-95e7-662f6c190a2e") },
                    { new Guid("d7047555-c12d-4047-97e3-86f7f858e114"), new Guid("d7047555-c12d-4047-97e3-86f7f858e114"), "+512 38 (347) 37-52", new Guid("572035ee-a24c-43d1-834d-5ab83d9f8899") },
                    { new Guid("d73687bc-af02-43d2-896a-570f38bd9d81"), new Guid("d73687bc-af02-43d2-896a-570f38bd9d81"), "+985 43 (086) 94-38", new Guid("3e38a390-7168-426f-8d48-017588046d20") },
                    { new Guid("d81c61c4-1dc4-4038-8f32-f924f38f7d52"), new Guid("d81c61c4-1dc4-4038-8f32-f924f38f7d52"), "+340 09 (220) 63-23", new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("d83a9c5a-9e74-4b7c-9c56-e894893a2e1c"), new Guid("d83a9c5a-9e74-4b7c-9c56-e894893a2e1c"), "+540 37 (226) 72-40", new Guid("525c60df-3111-4aab-9e5e-a01e2d3334c5") },
                    { new Guid("d98006d8-9fcc-44ca-96ff-a02fb61fcb59"), new Guid("d98006d8-9fcc-44ca-96ff-a02fb61fcb59"), "+980 98 (242) 28-25", new Guid("a11d6609-e768-4189-bd78-5b34d82849e6") },
                    { new Guid("d99aa520-28bd-4538-8822-99032e191580"), new Guid("d99aa520-28bd-4538-8822-99032e191580"), "+779 30 (225) 52-27", new Guid("7b57ff42-aeea-4f9b-954e-d09fc1d9e403") },
                    { new Guid("d9af8054-4a4b-4a93-bdd1-e073b320e713"), new Guid("d9af8054-4a4b-4a93-bdd1-e073b320e713"), "+812 49 (665) 14-36", new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("da6ec25e-af47-4935-bfc5-787275cc34df"), new Guid("da6ec25e-af47-4935-bfc5-787275cc34df"), "+187 49 (417) 61-45", new Guid("6f383120-9e6a-4c5e-8978-4493e1225fa0") },
                    { new Guid("da704692-d5fe-41d1-93cb-7221832d55cf"), new Guid("da704692-d5fe-41d1-93cb-7221832d55cf"), "+472 38 (371) 37-49", new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("da9b0001-e870-4bac-9d6b-d998f5008e39"), new Guid("da9b0001-e870-4bac-9d6b-d998f5008e39"), "+731 83 (589) 27-14", new Guid("dbc4a2dd-a758-44b5-9a5d-8ea69ebe5519") },
                    { new Guid("daaf7cfa-15f4-4a67-9c6c-c07856ecb8d4"), new Guid("daaf7cfa-15f4-4a67-9c6c-c07856ecb8d4"), "+683 61 (812) 19-51", new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("dacaf5d0-9b99-4dc6-90da-b041143af50b"), new Guid("dacaf5d0-9b99-4dc6-90da-b041143af50b"), "+414 72 (281) 08-06", new Guid("c7ab37ef-fc9f-4a05-8a37-8d9a364ecf88") },
                    { new Guid("daeee404-895c-4848-b030-27a1d8c2a416"), new Guid("daeee404-895c-4848-b030-27a1d8c2a416"), "+182 33 (090) 62-88", new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("db0a15f8-a58e-436c-b25a-073855583a91"), new Guid("db0a15f8-a58e-436c-b25a-073855583a91"), "+76 47 (649) 46-25", new Guid("f97b4375-8386-46ac-afd2-0892fcde0593") },
                    { new Guid("db329145-0096-4d65-ae55-b0c4349655ee"), new Guid("db329145-0096-4d65-ae55-b0c4349655ee"), "+535 34 (882) 38-91", new Guid("dc6abcad-2542-4f3d-93c0-24bca38f0de3") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("db577703-7b03-4852-b71b-286b0b89af23"), new Guid("db577703-7b03-4852-b71b-286b0b89af23"), "+925 18 (922) 95-89", new Guid("ef559218-9c22-4e02-bed7-ad69c0b5723d") },
                    { new Guid("db60bb0b-e379-4da1-93ce-bc7bfcb317d2"), new Guid("db60bb0b-e379-4da1-93ce-bc7bfcb317d2"), "+38 92 (041) 27-19", new Guid("709cf1f2-b992-43f4-930d-ea9bddd8598b") },
                    { new Guid("dc96c3d9-4557-4a80-9b24-7fe45230d395"), new Guid("dc96c3d9-4557-4a80-9b24-7fe45230d395"), "+589 43 (313) 36-93", new Guid("21d78670-d38a-40e9-99c6-c87dcd5fa655") },
                    { new Guid("dcc84721-a88b-4ec8-ab04-f6de113db52d"), new Guid("dcc84721-a88b-4ec8-ab04-f6de113db52d"), "+47 78 (910) 31-56", new Guid("ba2ef915-29fb-4955-9b6a-5aaee811ad30") },
                    { new Guid("dd046ce4-a9cd-4983-8cf1-b77481814808"), new Guid("dd046ce4-a9cd-4983-8cf1-b77481814808"), "+325 49 (561) 31-21", new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("dd53d4ee-9768-46b0-b37f-71d2e8370315"), new Guid("dd53d4ee-9768-46b0-b37f-71d2e8370315"), "+807 89 (485) 19-60", new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("ddb2f82c-9532-4668-965e-012ff99f4a22"), new Guid("ddb2f82c-9532-4668-965e-012ff99f4a22"), "+701 64 (183) 28-17", new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("ddd474ad-4371-4311-81f4-2629eb651559"), new Guid("ddd474ad-4371-4311-81f4-2629eb651559"), "+945 77 (159) 71-38", new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("dee51a45-3326-46cb-a708-ca79a486052f"), new Guid("dee51a45-3326-46cb-a708-ca79a486052f"), "+32 98 (059) 68-40", new Guid("323494b9-01c8-48d9-bbd4-a3019458eab3") },
                    { new Guid("df0f57f0-8347-409d-b39c-516e71c9297b"), new Guid("df0f57f0-8347-409d-b39c-516e71c9297b"), "+671 24 (459) 50-16", new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("df1e520f-2f39-4a05-ace7-1cb7a66ad2d5"), new Guid("df1e520f-2f39-4a05-ace7-1cb7a66ad2d5"), "+285 32 (072) 81-28", new Guid("6436ac9b-47dd-4f14-85f6-995d80ae1723") },
                    { new Guid("dfb44223-c77f-4d7e-8f27-ce6d23d7cd62"), new Guid("dfb44223-c77f-4d7e-8f27-ce6d23d7cd62"), "+796 84 (680) 36-19", new Guid("7c2af719-e82e-4031-bc56-568a9d473316") },
                    { new Guid("dff4d89e-8a28-42c5-9bdd-0cb5b65cd2e4"), new Guid("dff4d89e-8a28-42c5-9bdd-0cb5b65cd2e4"), "+191 91 (114) 86-94", new Guid("8bcc345f-79ef-44d6-82fe-978a1c6bc7b4") },
                    { new Guid("e038325b-1bf0-423d-96dc-ddd3ab4d6713"), new Guid("e038325b-1bf0-423d-96dc-ddd3ab4d6713"), "+984 30 (418) 65-28", new Guid("f26cb2a1-046f-4f07-a56f-dada17bef584") },
                    { new Guid("e05e12e4-62d1-4aa0-8a91-87946291151c"), new Guid("e05e12e4-62d1-4aa0-8a91-87946291151c"), "+506 40 (590) 66-09", new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("e0c42db6-6e6f-4563-bfe5-91b0ea4ad616"), new Guid("e0c42db6-6e6f-4563-bfe5-91b0ea4ad616"), "+880 72 (201) 58-33", new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("e0d21fc5-2525-4a98-87fd-8b61ad122b9b"), new Guid("e0d21fc5-2525-4a98-87fd-8b61ad122b9b"), "+191 42 (657) 31-77", new Guid("ce3aed68-b2b4-49a8-8c5b-2005fb02eda5") },
                    { new Guid("e0f62c7a-ef0f-4433-b3dc-de329592b447"), new Guid("e0f62c7a-ef0f-4433-b3dc-de329592b447"), "+503 72 (627) 53-44", new Guid("33d5b081-5c0f-4871-905f-631caba91848") },
                    { new Guid("e1073d49-b432-4ddb-bfc1-3342d6bfa719"), new Guid("e1073d49-b432-4ddb-bfc1-3342d6bfa719"), "+652 44 (280) 61-41", new Guid("e261d290-c1d1-4cbb-936f-fbe97f43fe98") },
                    { new Guid("e144169d-64fd-4a61-b1e0-b7c8d9345926"), new Guid("e144169d-64fd-4a61-b1e0-b7c8d9345926"), "+454 11 (101) 15-44", new Guid("60ca9f76-88d3-46a2-be9f-3af64afec6a1") },
                    { new Guid("e19a4052-17b3-45fa-86fd-c5083c72ee54"), new Guid("e19a4052-17b3-45fa-86fd-c5083c72ee54"), "+723 11 (877) 13-90", new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("e1df7e79-1d0c-4ca5-981b-5868f926b607"), new Guid("e1df7e79-1d0c-4ca5-981b-5868f926b607"), "+596 93 (635) 46-58", new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("e1eea5cc-b4a1-4d6e-93f5-7e776f75870b"), new Guid("e1eea5cc-b4a1-4d6e-93f5-7e776f75870b"), "+116 28 (051) 04-14", new Guid("c24a52cc-840a-421c-9c19-bd456e8633a7") },
                    { new Guid("e306f104-c41d-4013-8a4a-94b55e8ac36e"), new Guid("e306f104-c41d-4013-8a4a-94b55e8ac36e"), "+154 65 (954) 06-12", new Guid("f6a7a40d-6e49-47f3-9a79-c5bc423d2fac") },
                    { new Guid("e38545d4-5a09-492b-8361-645d13c2f943"), new Guid("e38545d4-5a09-492b-8361-645d13c2f943"), "+376 79 (702) 78-27", new Guid("a662b3ad-6def-4527-81c0-400ae1450131") },
                    { new Guid("e4050712-8b8f-4f9b-bfe3-c3c3690a2567"), new Guid("e4050712-8b8f-4f9b-bfe3-c3c3690a2567"), "+84 19 (165) 03-22", new Guid("7637da20-6c85-4358-a711-5912b0358007") },
                    { new Guid("e41db23c-6524-4eea-85ee-e63fd81bbaaf"), new Guid("e41db23c-6524-4eea-85ee-e63fd81bbaaf"), "+375 61 (143) 47-89", new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("e4c03ca2-9050-4a39-b264-c69e4635be8e"), new Guid("e4c03ca2-9050-4a39-b264-c69e4635be8e"), "+548 02 (702) 85-79", new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("e4ea70e7-092e-4a62-9fec-1a254c722d56"), new Guid("e4ea70e7-092e-4a62-9fec-1a254c722d56"), "+531 18 (654) 22-36", new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("e51700f0-8bcd-4673-b570-a3b06b7bdab5"), new Guid("e51700f0-8bcd-4673-b570-a3b06b7bdab5"), "+698 70 (788) 21-03", new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("e554669e-0383-476b-9e17-d1d104fac0e0"), new Guid("e554669e-0383-476b-9e17-d1d104fac0e0"), "+431 40 (736) 49-27", new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221") },
                    { new Guid("e62ebd3b-f579-4b1c-a6da-7002986e4632"), new Guid("e62ebd3b-f579-4b1c-a6da-7002986e4632"), "+295 51 (987) 98-25", new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("e6339242-44f1-4a4c-b80d-1737981424dd"), new Guid("e6339242-44f1-4a4c-b80d-1737981424dd"), "+394 78 (305) 63-97", new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("e6a7e287-d9d5-4abf-ac82-780b2b5d20d0"), new Guid("e6a7e287-d9d5-4abf-ac82-780b2b5d20d0"), "+707 29 (794) 02-07", new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("e7995126-d13e-4bad-980f-72700de08800"), new Guid("e7995126-d13e-4bad-980f-72700de08800"), "+549 72 (379) 93-36", new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("e851a9bd-e00a-4214-8285-13bdf65b4c10"), new Guid("e851a9bd-e00a-4214-8285-13bdf65b4c10"), "+164 68 (740) 99-99", new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("e8801367-c519-4c65-9a8b-4d53849d35c0"), new Guid("e8801367-c519-4c65-9a8b-4d53849d35c0"), "+34 32 (690) 20-88", new Guid("85b42aba-d6d2-47e8-b940-81a591452e2b") },
                    { new Guid("e8d2b75a-b93b-472a-a13d-562751ec530a"), new Guid("e8d2b75a-b93b-472a-a13d-562751ec530a"), "+556 02 (233) 16-65", new Guid("9349fc86-09c0-446e-8036-e69d441a3822") },
                    { new Guid("e984eaae-17bd-40ed-8d18-611939c16919"), new Guid("e984eaae-17bd-40ed-8d18-611939c16919"), "+450 26 (210) 67-40", new Guid("3ada6b44-b30e-42e0-a616-6c7beeb11221") },
                    { new Guid("e9885dfe-02ba-4e1c-8812-584979e54b76"), new Guid("e9885dfe-02ba-4e1c-8812-584979e54b76"), "+858 33 (202) 89-29", new Guid("636e6fd1-c4da-47a2-b141-1921b8814132") },
                    { new Guid("eaee1af0-18ed-4690-8b33-a7d2e5ee30b3"), new Guid("eaee1af0-18ed-4690-8b33-a7d2e5ee30b3"), "+373 99 (639) 64-44", new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("eb006a90-7605-4278-9365-cf9ad6907b94"), new Guid("eb006a90-7605-4278-9365-cf9ad6907b94"), "+609 09 (413) 02-88", new Guid("2adb04be-31fc-4051-bc44-e26f5a4ea556") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("eb10a432-9f6d-4ff6-a425-87559da16426"), new Guid("eb10a432-9f6d-4ff6-a425-87559da16426"), "+945 80 (528) 60-99", new Guid("4af08fe4-f22c-49d8-a166-5915e2f17374") },
                    { new Guid("eb48ce5d-9c73-455b-9610-60d6647e2394"), new Guid("eb48ce5d-9c73-455b-9610-60d6647e2394"), "+126 99 (006) 69-33", new Guid("313f3e57-0bb1-48f8-b6e0-d94c9c2ebcb2") },
                    { new Guid("eb7048ba-4301-4dd6-ba08-57b80ef19691"), new Guid("eb7048ba-4301-4dd6-ba08-57b80ef19691"), "+211 22 (682) 62-10", new Guid("e2b3e54d-2ecb-4225-a9cc-7ec1f836b4a7") },
                    { new Guid("ebcf4904-b18d-49be-92d8-ae02630154e4"), new Guid("ebcf4904-b18d-49be-92d8-ae02630154e4"), "+614 94 (675) 50-61", new Guid("23e1736c-4d9a-441a-9675-5b3f9d16b2fc") },
                    { new Guid("ec2e85b8-b9dc-4f86-8710-875aed00169f"), new Guid("ec2e85b8-b9dc-4f86-8710-875aed00169f"), "+463 27 (238) 37-20", new Guid("b0f090ec-5dfa-4db8-baca-ff97236405c2") },
                    { new Guid("ec51b50c-261b-4267-a311-cfd9e37e565b"), new Guid("ec51b50c-261b-4267-a311-cfd9e37e565b"), "+645 19 (136) 49-44", new Guid("97b6c1d4-015f-4ef6-92ba-e38edf306ba4") },
                    { new Guid("ed46a493-e1b9-40b5-a057-1ec3025e4df2"), new Guid("ed46a493-e1b9-40b5-a057-1ec3025e4df2"), "+72 07 (262) 09-48", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("edb1644b-df5a-4df4-902f-2a7385b87001"), new Guid("edb1644b-df5a-4df4-902f-2a7385b87001"), "+834 85 (794) 36-71", new Guid("07ea95c9-e232-4aec-9b08-af9e7fa6886a") },
                    { new Guid("edc7ee00-4204-4709-9891-cdfbcc3a9c70"), new Guid("edc7ee00-4204-4709-9891-cdfbcc3a9c70"), "+985 83 (928) 54-44", new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("ee7ebc81-3cb1-4a27-b765-ea21bb8bfdf5"), new Guid("ee7ebc81-3cb1-4a27-b765-ea21bb8bfdf5"), "+22 66 (901) 28-42", new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("eef1d9ca-c7af-463e-af21-50ac472480a4"), new Guid("eef1d9ca-c7af-463e-af21-50ac472480a4"), "+780 76 (793) 28-02", new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("ef32d4f7-cb5b-4128-b525-fe019b00aa0c"), new Guid("ef32d4f7-cb5b-4128-b525-fe019b00aa0c"), "+424 50 (222) 69-07", new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("efc5b53b-387a-4096-bc3e-2c3dd136886a"), new Guid("efc5b53b-387a-4096-bc3e-2c3dd136886a"), "+330 97 (676) 42-99", new Guid("2ce0465c-dc90-4910-bd5a-229ef932c779") },
                    { new Guid("efe1dd61-615a-4dc7-a19e-6ecbf63354a3"), new Guid("efe1dd61-615a-4dc7-a19e-6ecbf63354a3"), "+32 52 (283) 73-25", new Guid("a71b9f67-b229-4bca-aafa-8e7dc8bac9e2") },
                    { new Guid("efef94c1-e28d-4892-9649-62aa475fa40a"), new Guid("efef94c1-e28d-4892-9649-62aa475fa40a"), "+361 77 (047) 70-54", new Guid("482c0758-a476-404a-ade3-01c0818a58f9") },
                    { new Guid("f06519ba-7b78-4d59-8da2-ac4f7a073758"), new Guid("f06519ba-7b78-4d59-8da2-ac4f7a073758"), "+741 59 (927) 42-46", new Guid("48949002-3dd7-424b-b508-bb6644cad6fb") },
                    { new Guid("f0e0b5fa-a674-4e7b-89cd-dfd5c31b427c"), new Guid("f0e0b5fa-a674-4e7b-89cd-dfd5c31b427c"), "+544 43 (940) 01-43", new Guid("532e9ec7-4d71-4863-9e94-a15afcf4f854") },
                    { new Guid("f1f2d5ad-bba9-4db0-9470-7810e08ff22a"), new Guid("f1f2d5ad-bba9-4db0-9470-7810e08ff22a"), "+865 18 (381) 66-12", new Guid("9c51994b-1ad7-4153-b1a5-5ea80b449456") },
                    { new Guid("f2d810ab-0451-4fca-aea1-ceb2928bea9d"), new Guid("f2d810ab-0451-4fca-aea1-ceb2928bea9d"), "+628 80 (017) 15-40", new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("f3c643c2-9469-4721-aab2-e82225a1e34b"), new Guid("f3c643c2-9469-4721-aab2-e82225a1e34b"), "+852 35 (583) 54-39", new Guid("48c305a9-2a9e-44d3-a1d5-14c873d90342") },
                    { new Guid("f41a1683-1f37-4614-bcb8-6f56e9d87f9b"), new Guid("f41a1683-1f37-4614-bcb8-6f56e9d87f9b"), "+883 51 (462) 20-18", new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("f41ed5eb-776b-4d58-a269-6bdab04fab1b"), new Guid("f41ed5eb-776b-4d58-a269-6bdab04fab1b"), "+610 16 (095) 42-02", new Guid("1f1d7dd0-e01b-4d33-9903-a228ec0bee29") },
                    { new Guid("f4203437-a321-4156-8519-50d6f8ae74d0"), new Guid("f4203437-a321-4156-8519-50d6f8ae74d0"), "+823 22 (917) 48-81", new Guid("a6f0e48a-50d2-402a-b954-f944f339456a") },
                    { new Guid("f4640409-cac5-4a11-a4ff-dc544948f7b7"), new Guid("f4640409-cac5-4a11-a4ff-dc544948f7b7"), "+263 82 (412) 28-39", new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("f497e909-68da-44bf-aa71-82382c2ed378"), new Guid("f497e909-68da-44bf-aa71-82382c2ed378"), "+969 49 (071) 62-80", new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("f55d57b1-cf6b-4d3b-a162-588683037f39"), new Guid("f55d57b1-cf6b-4d3b-a162-588683037f39"), "+740 94 (218) 85-04", new Guid("783ae4d0-4f41-4631-a66f-f1d2e80d8162") },
                    { new Guid("f57b8ee9-7ae8-4c03-85d9-90dbebed2707"), new Guid("f57b8ee9-7ae8-4c03-85d9-90dbebed2707"), "+910 74 (154) 19-90", new Guid("12b74093-45e4-451e-b1a4-f4797f48c780") },
                    { new Guid("f599231c-50e9-42c7-b6b9-1ae86e14262f"), new Guid("f599231c-50e9-42c7-b6b9-1ae86e14262f"), "+759 28 (560) 34-01", new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("f620bcb8-f5d2-446f-8239-964216a9129e"), new Guid("f620bcb8-f5d2-446f-8239-964216a9129e"), "+813 60 (419) 39-70", new Guid("9c3105e5-ac6f-4d99-b8bc-e36889942bd6") },
                    { new Guid("f622b8b4-5514-47f9-9b49-e4af49857829"), new Guid("f622b8b4-5514-47f9-9b49-e4af49857829"), "+213 17 (898) 27-40", new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("f6444116-26c8-4e1e-acdf-83b7320febb7"), new Guid("f6444116-26c8-4e1e-acdf-83b7320febb7"), "+244 50 (385) 48-84", new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("f6521536-97e5-427d-8fcc-de14af34a8a9"), new Guid("f6521536-97e5-427d-8fcc-de14af34a8a9"), "+459 04 (954) 00-60", new Guid("8987fd2f-b286-41d7-9544-b355355a2cff") },
                    { new Guid("f6baf882-77ec-48bd-9937-e674c981150b"), new Guid("f6baf882-77ec-48bd-9937-e674c981150b"), "+270 92 (680) 28-40", new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("f6e179c8-d332-46da-8d1e-63783f3e2701"), new Guid("f6e179c8-d332-46da-8d1e-63783f3e2701"), "+771 88 (594) 83-82", new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c") },
                    { new Guid("f70ab462-3c2f-4e2f-834d-c75b57316c6d"), new Guid("f70ab462-3c2f-4e2f-834d-c75b57316c6d"), "+399 13 (990) 16-61", new Guid("735be216-2179-4f32-8f5b-062c31f3a316") },
                    { new Guid("f7206e34-d8f1-40bc-a1d5-b1762137a0dc"), new Guid("f7206e34-d8f1-40bc-a1d5-b1762137a0dc"), "+309 02 (753) 60-46", new Guid("c69d5c1c-7ef1-43d4-9453-b6fd644ce131") },
                    { new Guid("f7701c0d-ffc3-4643-bc95-b5e1937ee437"), new Guid("f7701c0d-ffc3-4643-bc95-b5e1937ee437"), "+884 31 (962) 54-39", new Guid("45e909c6-4aed-4f16-82c4-cb2ae97c580e") },
                    { new Guid("f785ff80-02c1-424c-813b-c59b715181b8"), new Guid("f785ff80-02c1-424c-813b-c59b715181b8"), "+841 79 (720) 50-02", new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("f7a9c4c7-a06a-4023-85da-68e12bfab891"), new Guid("f7a9c4c7-a06a-4023-85da-68e12bfab891"), "+490 39 (995) 37-86", new Guid("e7d5b6ea-c8d7-4a67-b7be-a224bccad33c") },
                    { new Guid("f8b12d2e-8922-407a-b830-71ec883b9a7a"), new Guid("f8b12d2e-8922-407a-b830-71ec883b9a7a"), "+353 46 (756) 19-14", new Guid("35482730-4c7a-4e01-aeca-0748f3123997") },
                    { new Guid("f8fde7f2-711d-4db1-9f1b-cb4774d8a50a"), new Guid("f8fde7f2-711d-4db1-9f1b-cb4774d8a50a"), "+854 79 (799) 49-23", new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("f8ff4a82-7552-4c12-b501-f4a4f3021b1c"), new Guid("f8ff4a82-7552-4c12-b501-f4a4f3021b1c"), "+546 06 (700) 98-95", new Guid("230caf1b-7fdc-4612-86ad-4e28bd1b4884") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Id", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("f9869b1c-cacf-46db-8092-8fc2f6e8ba12"), new Guid("f9869b1c-cacf-46db-8092-8fc2f6e8ba12"), "+540 73 (650) 94-42", new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("f9b1ec40-f69f-4edb-a88f-f24255e3c7e2"), new Guid("f9b1ec40-f69f-4edb-a88f-f24255e3c7e2"), "+894 05 (432) 89-46", new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("fa192e93-693e-4a87-afab-c912b0abfba9"), new Guid("fa192e93-693e-4a87-afab-c912b0abfba9"), "+648 99 (362) 14-22", new Guid("07806be8-2d45-4514-8fb6-44f2a59672f6") },
                    { new Guid("faba2ed2-2348-4728-9c9c-188a13d695dd"), new Guid("faba2ed2-2348-4728-9c9c-188a13d695dd"), "+989 94 (856) 88-47", new Guid("e97c1155-ff06-4cba-a349-a3a513c04b9b") },
                    { new Guid("faf353fb-57f2-4c63-b8f3-ddd1ec3e4281"), new Guid("faf353fb-57f2-4c63-b8f3-ddd1ec3e4281"), "+470 63 (194) 70-09", new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("fbaac358-eb12-4315-9f00-a7a45e5b0267"), new Guid("fbaac358-eb12-4315-9f00-a7a45e5b0267"), "+30 09 (149) 12-95", new Guid("e12ba5f1-6709-4a76-9749-a1bb9ae22e19") },
                    { new Guid("fbfe57da-549b-4c72-a966-592cfe456147"), new Guid("fbfe57da-549b-4c72-a966-592cfe456147"), "+451 22 (047) 24-70", new Guid("4b687f07-e7da-48e4-bb33-2169f005ccc7") },
                    { new Guid("fc496c9d-7d71-4ef5-a5e3-dbe5f940716d"), new Guid("fc496c9d-7d71-4ef5-a5e3-dbe5f940716d"), "+785 26 (083) 38-34", new Guid("93039765-55ef-4bc4-be3d-fac0495d9bab") },
                    { new Guid("fced0327-4b9f-4c7b-bd46-ff2a88850792"), new Guid("fced0327-4b9f-4c7b-bd46-ff2a88850792"), "+951 36 (864) 48-65", new Guid("64ee2151-1057-4d46-8b8c-8515e1a6b574") },
                    { new Guid("fd078c95-4e67-4086-83f3-f2c03398bbe5"), new Guid("fd078c95-4e67-4086-83f3-f2c03398bbe5"), "+232 35 (628) 75-57", new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("fd3550e2-b19f-4ded-942a-92c1385dcd3a"), new Guid("fd3550e2-b19f-4ded-942a-92c1385dcd3a"), "+848 51 (089) 53-71", new Guid("8fc66029-2bbf-4050-8cc3-eee5e9a99555") },
                    { new Guid("fd467a8a-8860-4af7-ac81-f2e8cdbc8264"), new Guid("fd467a8a-8860-4af7-ac81-f2e8cdbc8264"), "+240 69 (224) 14-53", new Guid("71287852-50e5-4e33-a65d-eb45ed07f51c") },
                    { new Guid("fd6684e4-f6b6-450c-ac42-99628d2c96ee"), new Guid("fd6684e4-f6b6-450c-ac42-99628d2c96ee"), "+739 56 (556) 32-37", new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("fdd0fce0-f5a1-4187-82f0-f94103b22ae9"), new Guid("fdd0fce0-f5a1-4187-82f0-f94103b22ae9"), "+443 58 (627) 59-04", new Guid("5d6624cd-49c7-45be-8277-452ad9eaf3a1") },
                    { new Guid("fe3686fc-5696-4e6f-bff9-d3f8d53e8ca5"), new Guid("fe3686fc-5696-4e6f-bff9-d3f8d53e8ca5"), "+214 11 (662) 60-08", new Guid("4583fd34-4e3a-4e8b-a37b-89f78ea48c01") },
                    { new Guid("fe825665-7882-4bab-af07-0c464b9f5bae"), new Guid("fe825665-7882-4bab-af07-0c464b9f5bae"), "+776 90 (452) 10-80", new Guid("a0721591-e102-4c93-af26-7a3bd8cc6c95") },
                    { new Guid("fe961e86-5811-4c5d-a434-08cf53d605c8"), new Guid("fe961e86-5811-4c5d-a434-08cf53d605c8"), "+210 90 (791) 16-14", new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("ff05baba-5dfe-4933-a16f-d3de41586d77"), new Guid("ff05baba-5dfe-4933-a16f-d3de41586d77"), "+210 41 (996) 07-19", new Guid("a6476e8b-5d8f-4235-82a2-d2abc22e13ec") },
                    { new Guid("ff7240bc-23a3-4e00-a4dc-2bb00e0b6d83"), new Guid("ff7240bc-23a3-4e00-a4dc-2bb00e0b6d83"), "+986 04 (411) 41-91", new Guid("c0ab5328-bb65-4abb-9f8c-1ce80264eff7") },
                    { new Guid("ffa981d2-02fe-4890-9b1d-c035833b4869"), new Guid("ffa981d2-02fe-4890-9b1d-c035833b4869"), "+892 20 (204) 27-08", new Guid("e071ec8d-1dbb-4111-8986-9ab3baa10efe") },
                    { new Guid("ffbb1b2a-af93-4347-ba0e-63fb6febc21e"), new Guid("ffbb1b2a-af93-4347-ba0e-63fb6febc21e"), "+493 60 (351) 23-59", new Guid("482c0758-a476-404a-ade3-01c0818a58f9") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("008cbe86-cb3b-42ad-b884-9396035f10e9"), new Guid("286d93be-e4cd-4842-acce-8fe736557448"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("00b24bff-78ef-4781-b78b-8d8c99c3938f"), new Guid("b2c3b18c-6bd7-4e8a-85e5-ce52bff56eb6"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("0718d152-fc82-442e-bd46-8a09390951f5"), new Guid("dcd32b1a-c20d-4c9e-8aac-da17ace6fd08"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("1ccfe764-efc9-486c-a38b-b33f9e657b5e"), new Guid("df43a17e-2176-45b2-9ae4-d12c95650a02"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("1e39e05d-61ef-43fa-9989-563599fd6c59"), new Guid("cf349a97-121b-4dec-8644-4c60a46d6153"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("20cacb7b-e97c-4e63-bd61-5c03e81a9423"), new Guid("8cf5c738-12cf-47f7-9b52-301f679687a8"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("215de683-1264-4212-af7a-46c8ab3d26ff"), new Guid("50e36ce2-0b2b-43de-a20e-67e861e4774f"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("241f0a20-ce18-43e0-b167-278dc874623f"), new Guid("e7a5e721-8c3a-4a78-9724-886c44db51c1"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("24be0161-5bf2-47d8-97c3-2ad0cbbef654"), new Guid("cf349a97-121b-4dec-8644-4c60a46d6153"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("33fa15a2-d482-4d64-a932-aaff6a372a05"), new Guid("112ad45c-5a21-4e06-a51d-51a442d13c3c"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("349127cb-d060-4a74-8403-3d593b571527"), new Guid("8ca52e76-20f3-4ea9-8fbd-6575c70955b3"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("3d7466e0-1bad-404d-92d0-8f4d60735113"), new Guid("20b9c065-6c5d-4d71-bf70-d1f095137e15"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("44d45578-95ee-4c21-a7e8-37f084ff2e2e"), new Guid("5c1ef301-d4e2-4f32-a521-9826e1d633bd"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("499744bb-7fb3-43b8-b7f5-2f26c9bde0d5"), new Guid("16f0ccc7-9d66-4609-a7f7-ceb6e929dd55"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("4fe0a5a1-1c97-4120-9535-adf2687b5de8"), new Guid("ca07c29a-fe28-4532-8849-f85b3e7c8482"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("50f1604d-473a-4c50-b3dd-524176a085ca"), new Guid("24efbaf7-ee47-4a8e-bd2d-e53ccd245bd8"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("54eb40ba-2b60-4a8c-a1e5-0073cb9a0987"), new Guid("71556740-633a-4553-8a66-e43d4f91e0c2"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("585a0ceb-fb08-463a-887f-705b60658298"), new Guid("cc0b1a42-4ffe-400b-a306-789635e17bf5"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("59dab578-64ee-48b5-bb3a-8fb994bc589f"), new Guid("e6bc351b-8b5f-413a-b3b5-b19984ea3ef8"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("6b5e279a-c3c2-4121-aaae-9a73b35109c5"), new Guid("e9c00671-ee60-4c57-92d2-4607c6cd8f90"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("714a8682-baed-416c-a60a-8db681487c86"), new Guid("073b1ba1-e817-4383-a588-b71db60684bb"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("753dfa19-8b36-417b-9a7e-a141c28eb898"), new Guid("8ca52e76-20f3-4ea9-8fbd-6575c70955b3"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("7c109127-fe51-4b62-8343-4d5eb6f76efb"), new Guid("cef8dc84-ba71-47dc-96f5-5490866ebffb"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("7f120beb-76ff-4e02-ad48-a164e0216122"), new Guid("e7520a57-b37e-4532-9167-acdd8e293d01"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("7f3be36f-ead1-4707-97ab-7eb62f3a8955"), new Guid("6ccaf7dc-b779-4491-b0ef-abf56c438ef3"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("86fccbb5-d4ac-4b44-8d8e-32dd4a29ce35"), new Guid("e9c00671-ee60-4c57-92d2-4607c6cd8f90"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("8d0acb5a-aed5-4db9-bf40-c04634280dca"), new Guid("5a1c88bf-9860-49b1-81c8-20b1930cc731"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") },
                    { new Guid("8d7ecda6-f1af-4db6-b59d-1ce1161aec64"), new Guid("d16f9da7-4dc7-4fb0-8336-75c01db25e28"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("8ebbb3d2-7ab2-42be-aae3-647e870b3604"), new Guid("20b9c065-6c5d-4d71-bf70-d1f095137e15"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("9885069a-774b-4e7b-9161-8139f4ab48bd"), new Guid("8cf5c738-12cf-47f7-9b52-301f679687a8"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("98b99b4d-e170-4ca9-8822-41a4ac5bf592"), new Guid("dc7a2df1-2389-4346-94c3-e32035fbbab3"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("98ef2ebf-af42-4b71-a9cd-8a1bd401c3ca"), new Guid("16f0ccc7-9d66-4609-a7f7-ceb6e929dd55"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("9ab5e64b-331e-40b8-9be7-3184c7e2f145"), new Guid("31013379-f80d-4138-8c18-33c376bdbf38"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("a81ab243-9159-4948-b9c3-b3a8a72a7444"), new Guid("d16f9da7-4dc7-4fb0-8336-75c01db25e28"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("ae2ca61a-df31-4ff1-ae9b-795221c74227"), new Guid("8427a1cd-09c0-4dbc-844e-707844dfa96a"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("af31b3f4-8c23-42d8-b431-a4dffb449978"), new Guid("d456edba-30cd-4c64-9576-6ce490429a41"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("b40e7a47-5574-4350-9672-c98a165305fc"), new Guid("9251f2b4-8385-4667-8d59-e000c38005dc"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("bb1de452-be67-4467-ae74-0b50e943d79c"), new Guid("636f1fda-966a-43b5-8851-337687d8898d"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("c001f03f-3155-48e2-bd0d-cfe9183aa1e4"), new Guid("674ed7fb-dcbc-4e30-8e72-5080db7d4170"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("c29224c5-2339-4d4d-b561-762c669cc11b"), new Guid("d4277ca5-d047-4e60-95eb-6977fe7a5b1d"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("c2ca6592-5d01-444d-923e-3bf29feb27a4"), new Guid("b1d8def6-d554-4787-904e-76ddf1409cb5"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("c4a43276-4cf2-46ce-8ff1-45b26b6eb17e"), new Guid("cd7c8a48-f7c4-4956-aa40-9e905ced600f"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("cc441b3a-5d22-4547-bdaf-e32547a0b610"), new Guid("0bff1262-45c8-4e68-9dc6-91a6ed662e81"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") },
                    { new Guid("ce36c790-6faf-418a-bade-52462d629d10"), new Guid("e7a5e721-8c3a-4a78-9724-886c44db51c1"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("d40cb909-a529-4f2a-a4de-bd48da107b41"), new Guid("485464ac-a66c-4fc8-ba61-15800742c0b7"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("d58e331b-7e33-4be7-ac7a-f44432163d11"), new Guid("16f0ccc7-9d66-4609-a7f7-ceb6e929dd55"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("d8e2202f-4464-4d6f-b933-bf4d741458e3"), new Guid("24efbaf7-ee47-4a8e-bd2d-e53ccd245bd8"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("de4a633d-5ef1-43db-89c0-068a2b5ccfda"), new Guid("31013379-f80d-4138-8c18-33c376bdbf38"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("de79a008-8277-4df8-87ae-e000407c57e4"), new Guid("29925720-4fcb-4e41-bb78-342032b93c01"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("dfcb574a-8960-43c0-ad39-afd021c97d8f"), new Guid("93aaba6f-d570-4d11-a369-985420214058"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("e04b07ca-0252-4ec3-a3ed-d8c9563c1ff1"), new Guid("66aa996d-fe35-4a8c-806a-517eccb06d5c"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("e550961e-e760-4ccd-b6f7-ee44205de4fe"), new Guid("0417633a-ba4f-462c-8b0d-ac9c1819e3db"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("e7e63bb3-cef5-4057-bd86-2cb18e8f9466"), new Guid("53624a86-7c9c-44bb-b045-3d7317aa58be"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("ef9a79a1-d881-40c4-99fb-b9e18aa81824"), new Guid("8cf5c738-12cf-47f7-9b52-301f679687a8"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0") },
                    { new Guid("f3e862d2-2c54-4378-ac7e-e6d54c6e8d41"), new Guid("cc3e358b-6b9b-40b1-a0de-3200d9a6633a"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("f9c57475-7594-40e4-a8a2-de64a43921f1"), new Guid("485464ac-a66c-4fc8-ba61-15800742c0b7"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("f9dc26a6-158f-4e1a-bda4-e7ced35f0c26"), new Guid("8f2ca9d9-2c1d-4891-b8cd-d2d888fd7e9b"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("fa219712-a893-4283-ac95-aa24d779f878"), new Guid("ec9fb8f7-52df-416a-a30f-c9cec8dbf2e7"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("fa984c91-7eae-40be-8668-e52679396a77"), new Guid("5a1c88bf-9860-49b1-81c8-20b1930cc731"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("fb4eb09a-58ca-4c56-a89b-715937519039"), new Guid("ea903924-c9ca-4241-9933-a005b0b3b68a"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0128ad1a-87b3-47c2-8f15-a07d3f042faf"), new Guid("0a41e9bd-943f-44e3-9b5d-e17b5accad0c"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("04a7a46b-a91c-4d6a-9096-fe09863263f8"), new Guid("dbb08058-29c4-4964-8c0c-6269268c69d7"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("076b4a1c-c950-4daa-866e-ee0f217b1f69"), new Guid("5fbfc221-a301-4c8c-9fce-a0d7eae3e79c"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c187a6f-4517-4c88-b249-9f72aef7aa47"), new Guid("32ceeb3f-923c-46f5-a8f6-8e514cb0a7e7"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("120fdb5b-8a4f-4955-a70a-b06de9cd2cea"), new Guid("6258405a-1054-49b6-a807-428e343ce4f3"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("18ed2d72-d7c5-43c7-82e2-04a054f59dbc"), new Guid("f7b2de48-20ea-4689-89b1-0bfea7826ce5"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("1aab8e3a-5656-4ba0-a0de-945c9eee6939"), new Guid("ed2d0d88-63c7-4be1-b981-8947a25567e9"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("1dc8f1ac-3a8a-4414-8a2b-8d391a8ff07c"), new Guid("949bd1c4-53da-47fa-ae4c-f46401f4c496"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("1dd1c408-d287-4746-b4a1-fe95152ad6f6"), new Guid("021aeba9-bef0-45ab-a0f8-662d0f3f87c6"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("286573da-8928-4452-bf25-c03bf7804ecb"), new Guid("f9ecebd6-4676-4b4e-b7ac-cfcfa0f7912f"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("289d2734-cac1-4c57-82b4-32051b796262"), new Guid("20dacf53-165d-4ed9-a05c-b1fbfaf085ca"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("2eb6403b-81ca-4a1f-95ca-f52c82c020ac"), new Guid("bc9beae0-5341-4243-a319-dd6ee5573a5b"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("2f9e7a43-4038-4745-b5bc-6492cff580f4"), new Guid("f9ecebd6-4676-4b4e-b7ac-cfcfa0f7912f"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("3365b21a-c8b9-4092-b716-a27b8cfc6dc9"), new Guid("2d1fe088-a286-4a9a-90f4-0d3ca876694d"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("46ffee95-2147-4569-8a38-99210ad18048"), new Guid("a7159cae-5e11-4a1d-bd84-d98368147142"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("4758292c-2508-4d40-af26-5034249bc80b"), new Guid("883a275f-ae1d-42ea-a47b-915a95806060"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("48a9b69b-37fe-45fc-9040-dd515630c989"), new Guid("f9ecebd6-4676-4b4e-b7ac-cfcfa0f7912f"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("4fc5ef6a-b349-48c6-9002-74f54755d1b8"), new Guid("ec4ba5c6-7ece-4fc7-b153-6a8d56d131a3"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("5815c6be-696e-4b05-8821-24e8b408701d"), new Guid("6258405a-1054-49b6-a807-428e343ce4f3"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("5cb0550d-2ea9-4528-a19b-d7dc918c6531"), new Guid("2d1fe088-a286-4a9a-90f4-0d3ca876694d"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("5fd4dd35-4983-4495-b6af-bd165c8f644c"), new Guid("883a275f-ae1d-42ea-a47b-915a95806060"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("600aa108-4e1b-4c64-80f9-a54eb7587086"), new Guid("c8d69965-574e-48be-842a-a479ca88fbe4"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("643d1e07-bfcb-49db-bc3a-478798a68209"), new Guid("a80fd179-9d7d-447e-b938-805a33691980"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("677a595a-c86c-4120-a1f9-2a9a2af21e2a"), new Guid("f9ecebd6-4676-4b4e-b7ac-cfcfa0f7912f"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("6822fe7c-39fa-4849-bb0d-5dd62edd360f"), new Guid("f7b2de48-20ea-4689-89b1-0bfea7826ce5"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("6978efe2-6246-4962-990e-68fd54a4121c"), new Guid("c84394b6-c44c-4c13-9028-53244dc7646b"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("747bc3fb-4ff8-4940-ab93-dc0e0114670e"), new Guid("476782d0-d9d7-4f98-86f9-3d2fac151bd0"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("74a1a9be-8f3e-4358-abe3-4038be163bca"), new Guid("a08a3026-54f6-4ff2-96ab-d1c077b94b8d"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("82834a47-d7f2-439d-90c7-0bc4864c7959"), new Guid("33e86693-e58b-4b62-b806-9bfcff930a14"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("8551857d-6f1b-45aa-9444-5696f84b8680"), new Guid("6fef9856-9fcd-48f7-bb59-79fd2ec1cff8"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("87d41ee0-57e8-45ca-b6b2-2d7301cecbcd"), new Guid("ed2d0d88-63c7-4be1-b981-8947a25567e9"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("88b1d6ae-fe57-4545-b579-b248d6ef2033"), new Guid("81dbcc89-064c-470f-8cda-19d01fa8303b"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("91041204-db9a-4e8d-936b-af89f63bba2d"), new Guid("c50337b3-7a81-474c-be71-57184cdd3d50"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("9a5593dc-8c6d-4bd1-919a-d8c079ec3c61"), new Guid("c13429bb-6be5-4a00-b4af-dbbe03e91269"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("9f036102-08b3-4808-ab24-46ad4f1ccb32"), new Guid("a3d55186-4e02-49f2-96f7-504c75bf5a36"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("a8474ead-0e19-4b46-ad6f-87e1a15b5174"), new Guid("c84394b6-c44c-4c13-9028-53244dc7646b"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("a8daf6ae-98d1-4eb1-bb7c-da0b538ac2ce"), new Guid("dbb08058-29c4-4964-8c0c-6269268c69d7"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") },
                    { new Guid("ad1fc0a9-37ab-4ee6-8444-884b7dbc72e2"), new Guid("a32e772c-e09f-460c-a8f3-91bbca18b58f"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("af0125f4-8469-493b-a123-fccd55096edb"), new Guid("70c12226-9aba-415d-b3d9-5169dde05cf5"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("b0a24634-3c88-4cca-97d6-db13c8597001"), new Guid("8528082a-7036-40eb-9515-88c09c16b3da"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("b2808cd1-33c2-4aae-89ec-e42b310cc93f"), new Guid("6258405a-1054-49b6-a807-428e343ce4f3"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("b3fc21ed-248d-4f35-8907-2e77e1f760b9"), new Guid("1413d2bb-da6f-4fd2-b02b-5810c3aeae86"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("b9b709e4-a007-4085-8175-9de4417b5fb8"), new Guid("dd91f87e-4bec-4440-95df-c5b384e888f7"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("bd02a572-306d-42d2-aa47-6e37ef0b3233"), new Guid("f9ecebd6-4676-4b4e-b7ac-cfcfa0f7912f"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("bd78c78b-9237-4f8f-8c02-76459b2a5524"), new Guid("f978b35d-16a3-4931-a6bf-e4be9dd6054b"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("bdace4ea-53e2-4010-a0f4-153867a590af"), new Guid("ca2fb0db-fe0e-475a-8bae-56f59b084393"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("c99c0ef2-a824-4571-a5f7-92d4e95aa807"), new Guid("924be61d-0622-4e53-a50b-33096f26c202"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0") },
                    { new Guid("cad0347f-2847-4e44-a64e-573cf2e1d361"), new Guid("7797db6a-5f7a-4048-b06e-c0b8d0939dc1"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("d369b929-1814-4fe1-93f8-b82fe840dd6c"), new Guid("8eaf7ff7-c19c-498f-af25-3b45d40d7187"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("d3a5d32f-01cf-4cab-8081-ecffd5f13d7b"), new Guid("5fbfc221-a301-4c8c-9fce-a0d7eae3e79c"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("dcd86817-46de-4596-8300-b3270c8c0260"), new Guid("9ef4f1d2-cd28-4aa4-aaa5-07dfde60bde8"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("deb377a4-6548-4dd3-860e-4f3ec0a678bb"), new Guid("46f1074a-8cd5-4698-9a30-a4f2becb309b"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("e3a989e7-a346-45b1-97ab-e023f456269f"), new Guid("a7159cae-5e11-4a1d-bd84-d98368147142"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("e3b8a333-cf9f-4dff-b4cd-94bbd6e70b4a"), new Guid("f55ee97e-3ddd-462b-9ee6-10347c16c50a"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("e9162a92-6261-42f1-9bc1-922140d6675d"), new Guid("476782d0-d9d7-4f98-86f9-3d2fac151bd0"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") },
                    { new Guid("e9ccf37f-8c84-44d7-88d1-c2b388cfe512"), new Guid("e7053ee2-c3f8-4399-830f-d1ad8e0f42ba"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("f0c16fdf-6c60-447b-b206-a4d2cc221738"), new Guid("af45803b-2ece-4c02-9628-948c1fc6000b"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") },
                    { new Guid("f808ca87-402f-446c-b8c2-ccdc6317db4e"), new Guid("c84394b6-c44c-4c13-9028-53244dc7646b"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("fcfb68e8-6072-4990-9198-94527b58dc90"), new Guid("25797f9e-3ad0-4a37-bf61-26d4385d3a32"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("fe6eaa82-73c3-4440-bdf3-bce6134d156e"), new Guid("c13429bb-6be5-4a00-b4af-dbbe03e91269"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d16e141-d4b4-491b-8e9b-fab687ff32f1"), new Guid("75cb78dd-c7bf-4098-b4a9-ba66a7d8fa64"), new Guid("a867ac56-f3f7-4dce-9447-875fdd5eb6de") },
                    { new Guid("18bb3e8d-bfd4-4ded-b3fa-7ca42c6b2d35"), new Guid("db4f7445-a869-4e01-bbdb-7c74527545eb"), new Guid("fba2cfac-59d4-4535-8586-74ac65c5d0d9") },
                    { new Guid("1ebd7f8c-efbf-4dd2-a66b-5e3e585a6442"), new Guid("058d252f-e41d-464d-bb73-6cb00789d6e6"), new Guid("10ec4836-47cb-48d7-9a62-fb3ce50ab1f9") },
                    { new Guid("21fc27ee-bf05-4222-955c-89cdcb51c2a0"), new Guid("68c388d8-d489-418b-b563-e572e988f4cd"), new Guid("1e17ee4f-dd62-48e2-bc15-4eb3349a0b1c") },
                    { new Guid("2a782283-1481-407e-bb1d-0cc0ddcbc9e2"), new Guid("9d74a777-dcbf-4a5e-8f67-aadb7335c0f5"), new Guid("d899e026-a9a8-4793-b0d0-587cab0c9440") },
                    { new Guid("2eb9b6d0-91cd-4c7c-9c18-a6a0e41d7b2a"), new Guid("0577b18c-6eba-4b5a-a43c-7304ab1acaa6"), new Guid("049885cb-e0f2-4131-a44d-71fb5816c410") },
                    { new Guid("2f3da46c-190d-4249-a7b1-34faf4c902d0"), new Guid("7c615273-fa33-406c-b435-b2c45c2d6bcd"), new Guid("a9255af2-7df7-4fe8-848e-ea23b63dff75") },
                    { new Guid("318bae70-8117-40a5-9fd7-89a66ba86b6d"), new Guid("202eeadc-099f-497c-8abd-2276a54558c1"), new Guid("cebf56e1-5a2a-40d7-90da-3b7738f65c89") },
                    { new Guid("376d5736-b8f3-4443-a324-a760c5e25a47"), new Guid("5e62fa48-fda9-4559-8d26-7f8eff40ea65"), new Guid("4425ab22-4ea1-4481-8c4e-f2eef6ba6a9f") },
                    { new Guid("3fa38fa6-c8e6-46cb-9070-86a5b2407d1f"), new Guid("8d1e1e6e-488c-4938-8c5a-99d9168220b8"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("41218dc3-5b35-4946-9c79-6347477f9bb0"), new Guid("9ce0d75e-03b9-42b8-a76b-a0b2c87c7209"), new Guid("9f745913-393e-4d75-924b-12ed8606f936") },
                    { new Guid("42f76c91-943f-410b-a44f-267c8be50e16"), new Guid("02890ad2-d464-4140-969c-b3062fbaf55f"), new Guid("19f43848-6fc9-4551-8dba-0e9c47d6b1b6") },
                    { new Guid("43fa424a-edaf-4fc8-85df-833b5021a0ce"), new Guid("0e103942-2841-4c5f-a13a-e008b8a46d1a"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("4ab0635c-0161-4959-b304-8386245f29ee"), new Guid("75cb78dd-c7bf-4098-b4a9-ba66a7d8fa64"), new Guid("28b1acca-feb9-43e9-bd9b-19ce01929a88") },
                    { new Guid("4b3547e0-feb0-41b8-9862-943d4b4aa65b"), new Guid("2d464b7c-277a-46b6-a9b5-28cf6a68fc0e"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("503308e7-cba5-4e93-93b0-b7fec72800b8"), new Guid("b6cb18ad-693e-4ccd-ad74-ea21e54a1f9f"), new Guid("95c79681-d148-4c68-b4ae-53d2bef4ed34") },
                    { new Guid("51ab432a-85e0-4bde-955e-ab92f95a7ed0"), new Guid("3fc4b68a-6acc-4199-b669-8922a636fd7b"), new Guid("242839a4-b28d-416a-a2b4-16765b0a8a51") },
                    { new Guid("5b7e0195-27e0-4e42-892c-1015ddb256f9"), new Guid("505e2a29-717c-4b5b-a66e-33de94b59968"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("5c7c02ba-a5cb-4656-a433-1f66c960d30e"), new Guid("93841682-23f2-47de-9e3b-e27eb36561f0"), new Guid("9e803182-b086-4574-bb1a-1bf4ba333604") },
                    { new Guid("6263d32d-13fc-43f3-a4b8-a3f7e1098f3d"), new Guid("57d42ba2-1e09-4ed5-aed3-68f79f4b197e"), new Guid("3be56def-eb89-4486-8258-b67aa1cf9957") },
                    { new Guid("63acaa91-d90d-4cd1-ad87-40e04ed8e7c2"), new Guid("3fc4b68a-6acc-4199-b669-8922a636fd7b"), new Guid("b24714cc-7701-46d0-a52f-81a8626b9b1e") },
                    { new Guid("6667f19a-f75a-4683-848e-036210784a25"), new Guid("bddcb316-6feb-4912-913a-c796342ec280"), new Guid("14352acc-c97a-4755-8c19-4b5672ffebd4") },
                    { new Guid("6c9ed6e4-4b2d-4d09-96ea-821e8e49739a"), new Guid("8d1e1e6e-488c-4938-8c5a-99d9168220b8"), new Guid("d723ce6f-0b92-46d3-a0eb-b6ae5edf0ae5") },
                    { new Guid("6f9dc414-661b-4ee0-a059-ec6b97dd91e6"), new Guid("75cb78dd-c7bf-4098-b4a9-ba66a7d8fa64"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("7071f8c6-feb3-4721-aa7e-24693492a680"), new Guid("5198b770-91a4-4153-82c6-a58ab0ceed1e"), new Guid("d4b5fbf4-ba3d-4cbe-bfd1-98a3f2836b81") },
                    { new Guid("707e6ccf-3376-4d37-a49b-752089033bb8"), new Guid("24e14cb4-1b56-4012-ba9f-f378806cfa3c"), new Guid("6664d758-265e-40e1-8b6e-206b2c289138") },
                    { new Guid("72f5731c-4aa4-400f-94fd-323c2dfc3a91"), new Guid("67448a16-3247-4cce-aad7-41fd3e3a5063"), new Guid("993ab5e0-ffda-47a1-89a6-65d974bafb84") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("73344e61-e709-42bc-8510-88b4acca3292"), new Guid("a076515e-b55d-41d2-aa5d-c3dfb52a7e3d"), new Guid("1596b87b-2d97-4f27-b17f-4c3556bd0fea") },
                    { new Guid("78300e98-fef5-4881-b7b3-bc846d2a48a3"), new Guid("24e14cb4-1b56-4012-ba9f-f378806cfa3c"), new Guid("1859ad05-f03b-4e9b-9ab5-17d5d2d1a330") },
                    { new Guid("811f3991-8b4e-4395-bb45-c90ca2f78794"), new Guid("095408f3-9cdd-42f8-bdbf-860896c0ba93"), new Guid("20f82045-e7cd-44b9-bd50-a80a394f4833") },
                    { new Guid("89b597c0-dd2e-4549-b339-d2c49cb5d585"), new Guid("3a901df6-2fe6-448c-afdc-bddfc130a679"), new Guid("ac35642b-587c-4798-ba3f-b8352b40efe8") },
                    { new Guid("9c314770-2b76-46e6-a15d-c906913ca14d"), new Guid("22e4169b-db3b-42d8-a6ba-cedf08065ceb"), new Guid("847d0ed6-b72f-4e17-a28b-ec1e6ec4c82b") },
                    { new Guid("a6a9db3b-1bf3-4a18-bd85-544a590ea354"), new Guid("7c615273-fa33-406c-b435-b2c45c2d6bcd"), new Guid("6c46d17e-1568-4a78-a408-8bbb04f39964") },
                    { new Guid("afe427da-b984-4f38-b390-313ac1347cd4"), new Guid("25991b88-dd29-461f-8ec8-a6e810638ec0"), new Guid("34976e08-cfc9-417c-a480-e4cfed027f98") },
                    { new Guid("b0a275ac-3eb5-46d9-8d55-5a3620fae83c"), new Guid("57d42ba2-1e09-4ed5-aed3-68f79f4b197e"), new Guid("7f194dc0-7dee-48bd-a8b2-14b9272e7f5a") },
                    { new Guid("b47e48d8-fb35-4b74-9bcd-11d36c5d95d8"), new Guid("6de0321e-8d0b-446a-ae2a-93f4404300de"), new Guid("487cb4f0-6b4e-43e3-8278-20091ba62f8c") },
                    { new Guid("b68e190f-187e-4cc5-8e63-36d29b66b536"), new Guid("0644b7f6-597c-4133-aca0-02622013c3fd"), new Guid("9192dfb6-2b7e-48b0-856e-ec56e71e8f05") },
                    { new Guid("b886ec4f-4dfa-43f2-8575-a090a534bf28"), new Guid("35cb4028-cc21-4006-a395-c3c385118bff"), new Guid("c72abfe8-e65f-4011-a62b-ca07be376511") },
                    { new Guid("ba0af2dc-4b79-4a4c-b221-2846022f5af7"), new Guid("f24721a0-1b11-4c89-9573-34c7e629818f"), new Guid("8889579f-6a19-43b4-a939-5d6b7706de41") },
                    { new Guid("c1bf541f-0288-4e52-8d7d-1b0a472f5426"), new Guid("7efb7224-d811-4e8e-b286-8cb634c34354"), new Guid("a6472241-c2eb-4e78-9192-f06967b1c39e") },
                    { new Guid("c4f4b583-8008-4f67-af5f-196bb5962fb0"), new Guid("c500fa62-8af1-4091-a335-2cef7f34d600"), new Guid("de17f128-632a-46e3-b2fe-1c9c6d14a186") },
                    { new Guid("ca03899b-3359-4377-977e-cbd6bf9e840f"), new Guid("24e14cb4-1b56-4012-ba9f-f378806cfa3c"), new Guid("eff00d35-a433-4c04-91cc-552778c0ec4d") },
                    { new Guid("cd4b9c64-5ae9-4da6-b080-87316562e5ac"), new Guid("2d464b7c-277a-46b6-a9b5-28cf6a68fc0e"), new Guid("d2398055-2472-48c3-a850-a08fbba5c777") },
                    { new Guid("cf680245-d76b-4683-bbd3-1fa906f3fb8f"), new Guid("6de0321e-8d0b-446a-ae2a-93f4404300de"), new Guid("1cfd97ea-ad8c-4880-a1bd-2e65d4f8f132") },
                    { new Guid("cfdba685-dbda-415a-89c6-cb5d3bf5d9ab"), new Guid("8d1e1e6e-488c-4938-8c5a-99d9168220b8"), new Guid("0136c022-fcf1-47a8-a481-723709054ce0") },
                    { new Guid("d0ad5e6a-e22b-4b6e-a2c0-4d6db2039329"), new Guid("75cb78dd-c7bf-4098-b4a9-ba66a7d8fa64"), new Guid("15ff126d-c656-4885-a732-88f20e2b2157") },
                    { new Guid("d295b4ec-9ffc-4c58-b1f9-672d78445b71"), new Guid("5367611d-8d07-4fab-9316-fad16fc2de1b"), new Guid("c694c8ba-7314-4668-8b54-b59cef12f9d9") },
                    { new Guid("d3f801cf-e030-4907-aaa7-3327253f5faa"), new Guid("2fe5e365-4c71-41f4-aaf3-5e711eeb901a"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("d66f9805-2081-466b-8d4e-91b1800b352e"), new Guid("523a0fd9-ee43-47c9-bfdc-00836c5b9ce1"), new Guid("f91f88d1-1c19-42b3-9864-228e93754a0c") },
                    { new Guid("d830ab45-6d73-4b26-bddf-4d9b521a75af"), new Guid("202f5845-c6b9-45b9-ab1e-050e7f140fde"), new Guid("cb635093-0872-4986-8027-340de9f12a5c") },
                    { new Guid("dd129892-f73d-49ad-9767-31722976c699"), new Guid("857951ff-aae5-408c-8345-a3c8fcbd28b9"), new Guid("51ae249d-6c55-4f2f-986c-182b35b879ea") },
                    { new Guid("e1b69073-c0ea-4b9a-a517-34d5afdb2092"), new Guid("8d808537-58bc-4aad-984f-ab928dd15089"), new Guid("a5c9098a-571e-4245-855d-ac6adf81fcec") },
                    { new Guid("e4712931-4469-48f3-97e7-802b465a94aa"), new Guid("4ee0b215-9d35-4eda-8301-baae35768a0a"), new Guid("ad9e1016-fdd4-48df-929c-929ac360852d") },
                    { new Guid("eae41dd1-10ea-419e-a844-e9c02c98e03b"), new Guid("202eeadc-099f-497c-8abd-2276a54558c1"), new Guid("6b571b70-19b5-4b18-8252-24f8c27f8c21") },
                    { new Guid("f2582cb9-59bd-4e77-93a2-7575217d218f"), new Guid("5198b770-91a4-4153-82c6-a58ab0ceed1e"), new Guid("da889e2c-4561-41d8-aae7-1b9320baf8aa") },
                    { new Guid("f633119c-6a66-402b-b8eb-a36ca876534f"), new Guid("e8bbf77e-657c-4a47-a787-e4b4723d786c"), new Guid("d62a752a-afd0-4825-9ac5-cdddedad0042") },
                    { new Guid("fbedf89c-26fa-44b0-9cb7-7ae6913d2e73"), new Guid("68c388d8-d489-418b-b563-e572e988f4cd"), new Guid("7096e0ea-c124-4948-a07d-ca1dd648f55d") },
                    { new Guid("fd2d4de8-ce62-4c03-82b7-3d54ed5cd26d"), new Guid("2fe5e365-4c71-41f4-aaf3-5e711eeb901a"), new Guid("232c1165-4d8a-47cd-b78c-6598051a24ba") },
                    { new Guid("fdd68118-c1dd-43a8-9f92-3fe405acb8a4"), new Guid("857951ff-aae5-408c-8345-a3c8fcbd28b9"), new Guid("aac5acfb-4ffc-44be-b614-c71f26945a1a") },
                    { new Guid("fef0326b-c654-4956-a5dd-1181f5b77246"), new Guid("dcce3b65-d386-404f-8930-e472756ecc6c"), new Guid("b51bb116-c381-4676-8f1d-ca4f8a2f89e0") }
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
