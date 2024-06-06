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
                    Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    ActivationCounter = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    DateOfReceipt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), "e0ed2c1c-738d-4ba0-8f4e-651a798a80e0", "Manager", "MANAGER" },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), "08b037e8-9893-4956-a822-63ddaa695df4", "User", "USER" },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), "cc09cced-a2a9-4c60-91dd-a8ae885456d7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), 0, true, null, 398.8160434266460000m, "7a3ff0a3-c4f2-43dd-874c-4318dbd087bb", null, "Viola", null, "Rempel", false, null, "Viola_Rempel40", "AQAAAAEAACcQAAAAEG5Ylw5Sj4ScW+908K82TWKZCq/BuedqJ0StM1OKnbJzad52xDUnu3F4uPDN6mAtTA==", null, "Female", false },
                    { new Guid("00f931ba-9042-4fff-bab5-15657060d8e9"), 0, true, new DateTime(1943, 6, 19, 4, 40, 51, 372, DateTimeKind.Local).AddTicks(7077), 899.8899802243550000m, "abf91e53-8fc1-4774-b027-95085928939d", null, "Guy", null, "Shanahan", false, null, "Guy27", "AQAAAAEAACcQAAAAEHlcXzje+Tyq06wBqJdtMOLz2ZAfyHC4h8aLYQKkPH8Q3gQMDWF418Jgqaop6WvTFw==", null, "NotSelected", false },
                    { new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d"), 0, true, new DateTime(1956, 6, 12, 16, 1, 58, 735, DateTimeKind.Local).AddTicks(5635), 236.278234164510000m, "a8c12975-04e1-43b6-a5dd-410adc376a90", "Rickey", "Rickey", null, "Romaguera", false, null, "Rickey_Romaguera", "AQAAAAEAACcQAAAAEOGPvH0j2CRxfps+DKYOqVrJq4UWj152P/D70GsWlO+ZMlis+tZD46UwwJeGltkTfQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a"), 0, null, 628.0646140635370000m, "987684b5-5917-4587-8c62-4e6c889ae0f4", "Meredith", "Meredith", null, "Jacobs", false, null, "Meredith95", "AQAAAAEAACcQAAAAEMzbv8W5BOOa7CBA7PNTt9M09v6AQNEQy2tLIwkaYDO2O8piilhWU2QnCrCtVleoQQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0459684a-9478-4760-922c-cdff0f159395"), 0, null, 979.0581583165060000m, "ca564dda-a758-406d-bdae-c9a502b3b78a", "Isaac", "Isaac", null, "Jerde", false, null, "Isaac_Jerde59", "AQAAAAEAACcQAAAAEPHxbwLeeubVAm/dX0gs5bgVXj0DpWVVeCzmxDH++z++XE/OfJcMRR5r9gBKw6h5Jg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b"), 0, true, new DateTime(1940, 10, 11, 4, 5, 13, 766, DateTimeKind.Local).AddTicks(7216), 140.6361427340310000m, "19f4c0bd-6a40-4ef6-834f-86265b431a4c", "Kristopher", "Kristopher", null, "Gorczany", false, null, "Kristopher6", "AQAAAAEAACcQAAAAEOGqcQbXSTwD5F0BC7yQSvCgyb9/7mXqUGn2UEqkr7oAv6ymbwocS0FMARWTTgzWmg==", null, "Female", false },
                    { new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee"), 0, true, null, 378.210158923530000m, "d5e8ec21-a8e7-4f4e-aa1c-c8debcbe3819", null, "Dwight", null, "Jacobson", false, null, "Dwight_Jacobson", "AQAAAAEAACcQAAAAEGtwt7ZIvAcFShf8H8qtrNSgGXtrELnLgc+Oess7zAnS1GYWBpvm6wffr9ZeMr0I0g==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("06583580-4c31-420a-9d2d-f2148abc06a3"), 0, new DateTime(1977, 1, 14, 9, 52, 49, 159, DateTimeKind.Local).AddTicks(9741), 620.0698307923180000m, "e69a1804-fcd7-4b99-a146-369121f70d75", "Molly", "Molly", null, "Mohr", false, null, "Molly.Mohr", "AQAAAAEAACcQAAAAEIw7NoP9PXNog1mM9FM7I/GZJzt55bPRpd8zRmJdAFfJIJCiK5eqzni6DFZyjd+T5w==", null, "Female", false },
                    { new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2"), 0, null, 504.0024673698390000m, "436f2bf9-d66a-4f42-a97e-1bf73db944fb", null, "Toby", null, "Grant", false, null, "Toby7", "AQAAAAEAACcQAAAAEMvgFbPTmNLygE3+xGnNiLLbZp2ser+FOl6PZKqLb/OrvA3lTUBl5D7EjyzMTq9Niw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d"), 0, true, new DateTime(1989, 10, 19, 18, 45, 26, 140, DateTimeKind.Local).AddTicks(3523), 637.5498429842540000m, "219a47dc-0a23-4cc9-bd0c-6dfc6a212b7a", null, "Kay", null, "Jacobi", false, null, "Kay.Jacobi", "AQAAAAEAACcQAAAAEGJ+Nxp45mBkSB5OXaFiNW2a+lk9VQNgOVZlek3d3/HfBrC0+tPkTnVl9KNcFw5HPw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7"), 0, new DateTime(1996, 9, 3, 11, 8, 34, 198, DateTimeKind.Local).AddTicks(956), 766.3757939686990000m, "e8db4b95-9510-428b-b1e2-fe922ea7bb6d", "Fred", "Fred", null, "Lynch", false, null, "Fred91", "AQAAAAEAACcQAAAAEO4MPGp00Ks1KJlozSbcmULHlaxNTMsRDIoS7zQ85CNK7r0uNGtd57uWEUWa8NZ1Dw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), 0, true, new DateTime(1988, 7, 24, 9, 46, 52, 316, DateTimeKind.Local).AddTicks(8271), 448.2350455491810000m, "7054a2e8-edfd-4d72-bf1c-00d49cff6a79", "Clifford", "Clifford", null, "West", false, null, "Clifford.West", "AQAAAAEAACcQAAAAEJCGvoVJPxtRtPP3qLM66L7A11ybvl2TK5X4g/BLoJ/gCV15BofTUanJ8l7QqN6maw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf"), 0, null, 621.8677061877770000m, "40e3580d-f93d-4771-bae8-dc8bdd9176d2", null, "Nicole", null, "Dibbert", false, null, "Nicole.Dibbert61", "AQAAAAEAACcQAAAAEMIVNiaMcI06vrjzY99sIMy6IAvvouJQ4IflBeg+O7sLtwlh9cXoaz1fmAjYYkP12g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff"), 0, true, new DateTime(1990, 7, 18, 2, 37, 43, 873, DateTimeKind.Local).AddTicks(7942), 725.3634922021380000m, "93cfcccf-42af-44be-8e4d-d66317cb4029", null, "Justin", null, "Pouros", false, null, "Justin.Pouros52", "AQAAAAEAACcQAAAAEIndfX2Eea1B+0TLWrg27kjSKUQ2gmaSLixF60I7g+QVnbBAeUooTKO5AbNTX81JZg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("0be23392-599f-43dc-97d5-6396327167ba"), 0, true, null, 200.6487526879190000m, "97d1ae3c-60f4-4231-bb62-98ee91778fed", "Bertha", "Bertha", null, "Mayert", false, null, "Bertha51", "AQAAAAEAACcQAAAAED48RK5EIMgUZw8uG2MauVx8JFY1k/5eXfWxIZv6J1MrR1jWBQj7crNQadvdXyf7PQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9"), 0, true, new DateTime(1995, 11, 25, 12, 45, 45, 166, DateTimeKind.Local).AddTicks(5508), 46.28533132713870000m, "9ba43c01-235f-4994-9c8a-fa8b3492517b", null, "Bill", null, "Jakubowski", false, null, "Bill_Jakubowski90", "AQAAAAEAACcQAAAAEHxyRba5IeGEiskSamUh461bd8QV+d88tESZWnX9RktSqhpSp1MeyZ4gbcHdv/U2hg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0e809aac-90e9-4073-992f-0a9348838efe"), 0, new DateTime(1956, 4, 23, 10, 36, 20, 898, DateTimeKind.Local).AddTicks(3697), 893.9744259964070000m, "8397b42c-1d5a-4161-b798-c3ba5d20539d", null, "Sadie", null, "Rowe", false, null, "Sadie.Rowe", "AQAAAAEAACcQAAAAEM2BsunjZKHJ7HvYCxUDi7dfuOF7LL6CmBQj/mz6fPO7fGMb3iwUuVwuZ5DbucQi6A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6"), 0, true, null, 878.9253682138530000m, "30dd731e-c592-434b-8404-bc50565ebbfe", "Joanna", "Joanna", null, "Pacocha", false, null, "Joanna46", "AQAAAAEAACcQAAAAENB+8Go4GMgxvQONYsaT4kH0rA/7KBjTTFiCEJbuow/zIVwacRy99o5nUY8DEzwh/w==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff"), 0, new DateTime(1942, 4, 29, 1, 7, 24, 587, DateTimeKind.Local).AddTicks(7449), 789.5263081951750000m, "d751a068-e5cc-4ae3-89ac-16140623ddbb", "Debra", "Debra", null, "Cassin", false, null, "Debra33", "AQAAAAEAACcQAAAAEDChTReMwaVBnBp3XcRrcyB4H9Pkr6j4uEpddRpMTjuezgeyc8KGy2AcLLZNXw4ubg==", null, "NotSelected", false },
                    { new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc"), 0, new DateTime(1930, 7, 25, 23, 59, 32, 407, DateTimeKind.Local).AddTicks(9512), 848.7887052849760000m, "c7031293-a906-468b-ad5d-3c9641735033", "Delores", "Delores", null, "Torp", false, null, "Delores_Torp", "AQAAAAEAACcQAAAAECEjlNZq0AsHqe4pBtJhpXm7dUWyGHonXp8DSbM2IC2T5UbfTg0KibwZI5nbZww4zg==", null, "Female", false },
                    { new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3"), 0, new DateTime(2008, 1, 27, 8, 34, 19, 77, DateTimeKind.Local).AddTicks(3658), 256.3767280667930000m, "c8e74711-49aa-470f-a182-5035e9de71b6", null, "Melissa", null, "Boyer", false, null, "Melissa1", "AQAAAAEAACcQAAAAEBHFc4zID5dTVFjjNMYXVPi6BD0wjU7pzDxTCI6zoy4AaiDgPN2xumj56OF4F0+jIg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47"), 0, true, null, 302.9980479517910000m, "5b455607-ce55-4bdb-8bc4-49f2b7fa8927", null, "Natalie", null, "Homenick", false, null, "Natalie9", "AQAAAAEAACcQAAAAEA8L7M5SZHiZ7VRxxEKJGyhuO9bnSssLiO6rNFz+Vj1ptu6K3qZ7j6BCAaUZq0PVxA==", null, "NotSelected", false },
                    { new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385"), 0, true, null, 831.9859178890260000m, "909822e5-5994-4cfc-ac5c-672b53d10dfe", null, "Lynn", null, "Yost", false, null, "Lynn.Yost20", "AQAAAAEAACcQAAAAEDVYaGh1ajYbdLjcsYeE+/H67vWNj+myCBMAVHiQdw7P/Rg1pGvOGvvtPEVDuTwzDA==", null, "Female", false },
                    { new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337"), 0, true, null, 433.4621296343610000m, "d277ca42-9ef5-480d-8043-6a65a6feebdb", null, "Julian", null, "Labadie", false, null, "Julian24", "AQAAAAEAACcQAAAAEMxvQNem03EsVS3kNT0tKyGs/IeoQ3yWAKa7DTTsvJGxjm7H56oA7wO7uC4mHyfzaQ==", null, "NotSelected", false },
                    { new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee"), 0, true, null, 7.023315380260240000m, "02aefca5-d29b-4644-9002-7ea1284243bc", null, "Toby", null, "King", false, null, "Toby_King", "AQAAAAEAACcQAAAAEHq0wHrGwWbWREFjsumdYKZVuvOWbRYBP/6cr+B5h/n4Yrh+CU/R7WxSkeWGQLs76A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367"), 0, true, new DateTime(1998, 5, 28, 3, 40, 7, 471, DateTimeKind.Local).AddTicks(9704), 767.785948078290000m, "4be7e3c9-3597-4147-9ed7-4ed7b87b4a5b", "Victoria", "Victoria", null, "Glover", false, null, "Victoria89", "AQAAAAEAACcQAAAAEI2pESBfsUjSjBGPnOVWORIlo/l56ZFyMLoC1Sz0psR/InGBbkKLjy7dNvacSeLi5A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7"), 0, true, new DateTime(1947, 11, 5, 2, 28, 8, 498, DateTimeKind.Local).AddTicks(4662), 630.9878061067230000m, "0fdbc59f-45c2-4b1b-bc7a-1301c3b7ca0e", null, "Boyd", null, "Pollich", false, null, "Boyd_Pollich", "AQAAAAEAACcQAAAAEPldInnu71+eJw7f7N+EdNCZOfOXuXWYluMCB0jrp4X/Ewl5fFaJ8TplSUMcLVw1Dg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232"), 0, new DateTime(1979, 1, 9, 0, 50, 56, 747, DateTimeKind.Local).AddTicks(2463), 895.4472995618660000m, "d499aaca-d0dd-4c1e-870f-652ff9e00e6e", null, "Jake", null, "Murazik", false, null, "Jake_Murazik", "AQAAAAEAACcQAAAAEKJXjSC0PWs8ERMGHUYtk/nZrhP13g/MBQmx8hwn4GAjhwKIz8Gw0qraxDnRuwQzIg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77"), 0, new DateTime(1998, 10, 12, 3, 7, 55, 530, DateTimeKind.Local).AddTicks(9676), 632.3845660602880000m, "3c011a23-3fb7-4b85-93dc-d0f47b78e55a", null, "Moses", null, "Schmeler", false, null, "Moses29", "AQAAAAEAACcQAAAAEAyQyfYzrkg1yHfcrtZiCjHeuVtediXhHTE6zawY2rwirQNXIPXKLK/+1wDJ2UExtw==", null, false },
                    { new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a"), 0, new DateTime(1999, 9, 5, 4, 22, 25, 936, DateTimeKind.Local).AddTicks(3524), 280.4594089372010000m, "51d7df8b-223d-4b5f-af73-9cfc6a07819c", null, "Garry", null, "Casper", false, null, "Garry3", "AQAAAAEAACcQAAAAEHubZEjnUuhe1kIdvFejZRrVmrTGcBqm5pMefgrJR8Bre+UU3rFSJ/kWj8WV++lxHw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1f55a324-d084-4122-815d-e1f65a8435b4"), 0, true, new DateTime(1995, 10, 27, 19, 11, 53, 64, DateTimeKind.Local).AddTicks(4179), 507.6725004968090000m, "69e14641-0b99-446e-b127-a99fd800af52", "Miranda", "Miranda", null, "Kautzer", false, null, "Miranda_Kautzer", "AQAAAAEAACcQAAAAEGx7+X7pXbECirLThXkvzmP5dWtr4SwMv0xrkpwJ/bzxzQngQCh3eYr66r3yG7qQKg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679"), 0, null, 923.9407172507210000m, "c2331e25-5a81-421d-829d-1685960826b8", "Genevieve", "Genevieve", null, "Dibbert", false, null, "Genevieve.Dibbert", "AQAAAAEAACcQAAAAEJLlh6IHcCkhDZEeUsIxbFFfvEcL284LcR5tsebJvPB71yrIUd8BoIhzhfF/p0QiyA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858"), 0, true, new DateTime(2009, 1, 7, 5, 32, 35, 381, DateTimeKind.Local).AddTicks(38), 717.8558173565750000m, "dd40e4f1-073f-4d1b-83c4-ff1f8b8fdf27", null, "Joel", null, "Yost", false, null, "Joel66", "AQAAAAEAACcQAAAAEEcZG6I1Vl0eebZ1nZkxs9jcZzHpINDSyvdwIr3nalJGw3jDjT+Z0TAywrv+AYRIGw==", null, "Female", false },
                    { new Guid("2183f862-871a-449c-b3da-ea6005e9e472"), 0, true, new DateTime(1925, 1, 13, 5, 19, 12, 749, DateTimeKind.Local).AddTicks(349), 352.0347117427560000m, "9c94d92a-59ea-4ed1-a438-9cb6ce398cec", null, "Faith", null, "Marks", false, null, "Faith.Marks91", "AQAAAAEAACcQAAAAEHOWcY7riau6bO3pCCd7vMZYQpor/ggFzESblM/3HOeiCHbPXBunqQh/CX7/lPQQdA==", null, "Female", false },
                    { new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9"), 0, true, new DateTime(1955, 9, 25, 4, 50, 12, 439, DateTimeKind.Local).AddTicks(5751), 561.7275453434030000m, "a1075eb8-7504-4ea4-87d3-ba20b85b856e", null, "Rosemarie", null, "Hammes", false, null, "Rosemarie.Hammes18", "AQAAAAEAACcQAAAAEJWsLUJ36rN+yY+IJ+RISeNGXPz36n09MIHGVqNLsjUuhIQYHjGPYN4IsBb3VcIOcg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179"), 0, null, 828.0851435866260000m, "f35a25b6-ebca-497c-a35d-1f135420b488", null, "Douglas", null, "Murazik", false, null, "Douglas_Murazik97", "AQAAAAEAACcQAAAAELR8QfRnnhkzLLB7ACHi90hHzqpV93KE0+BIVy1YhSYUBSCXEKB6SQ4yhU/OK57ceA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524"), 0, true, new DateTime(1981, 10, 20, 14, 26, 48, 9, DateTimeKind.Local).AddTicks(7523), 162.9298247711420000m, "d23fd86f-a414-4fe7-acdc-951cf8f3719c", null, "Jaime", null, "Kirlin", false, null, "Jaime.Kirlin16", "AQAAAAEAACcQAAAAEOIYZ0vgd7Kh4TSUC1liilTORYhbQInuyN7HJPZt50cUBvbi9JBviVXQ3vhKmqW5lw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("29ab604b-7a76-439b-8129-93142c9b6cee"), 0, true, null, 349.626827424390000m, "48c57d54-13e6-4130-8e1a-8b92f0e96a49", "Terry", "Terry", null, "Turcotte", false, null, "Terry.Turcotte0", "AQAAAAEAACcQAAAAEFBOGz0k9pmYByZsgBbWQJNIaYbSFqlCPJdNMJuTvk7u1sBQjoUzzCGUTU95xYn8lQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0"), 0, true, new DateTime(1938, 9, 1, 1, 8, 6, 767, DateTimeKind.Local).AddTicks(3475), 147.4229373107150000m, "7904d2c6-95a8-47f0-a5a2-3d5da71940ca", null, "Nicole", null, "Pfannerstill", false, null, "Nicole.Pfannerstill", "AQAAAAEAACcQAAAAEKBDM6Vt7XrmBxtSWLEoQi2riuivRcwFAYKSNUqvVVEI8JLf1vycrqB9BNssYHv0rw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2b73b7f1-451f-41db-b14e-91c27c148562"), 0, true, new DateTime(1986, 12, 3, 18, 33, 26, 4, DateTimeKind.Local).AddTicks(6129), 207.0009868121870000m, "959292b4-b616-42cb-83a1-d804c585f604", null, "Timmy", null, "Morar", false, null, "Timmy.Morar", "AQAAAAEAACcQAAAAEIncPvnQK7zmwweovDswR7bDjXPItVYtSwbh1NOvNynzsGGHlA8a1jAnTaF9fbBtMw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2e036c59-b30c-4add-a80e-9813b03909a7"), 0, true, null, 289.6440981040110000m, "fb52c6bb-3cd6-40d5-970b-eb2da2e2da13", null, "Kurt", null, "Pagac", false, null, "Kurt.Pagac62", "AQAAAAEAACcQAAAAEO2Yebs2aIP2zATpkrnY36QJ8PrN9NXVSsRGMuPPDijFyNB2YsJN5qUPKWnbnGT3Dw==", null, "Female", false },
                    { new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e"), 0, true, new DateTime(1994, 10, 27, 21, 8, 32, 705, DateTimeKind.Local).AddTicks(8500), 900.4318644727730000m, "5dda004f-330b-4631-8dac-8ebd2488fc01", "Hugo", "Hugo", null, "Sauer", false, null, "Hugo_Sauer", "AQAAAAEAACcQAAAAELB8hfhdLj/JFM+dTp4RB/6vorHtuMX4Y44rKbAZnVVpFuxfdvtWKgHUCSt93aIOYg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e"), 0, new DateTime(1981, 8, 1, 0, 56, 58, 122, DateTimeKind.Local).AddTicks(9856), 872.5166132797380000m, "a043e25c-61e0-4dea-a74b-ce3d36e990a7", null, "May", null, "Kohler", false, null, "May_Kohler", "AQAAAAEAACcQAAAAEDQ4nph/tPTl9NO60dWO9oe9EVCTLyBsXD30nsHXGaPSgpRHmncdY0okGImNTAQdjg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022"), 0, true, new DateTime(1994, 11, 29, 9, 38, 8, 824, DateTimeKind.Local).AddTicks(4244), 753.1269871189030000m, "faffbf4f-96db-4740-ac52-ab47467c2700", null, "Rose", null, "D'Amore", false, null, "Rose_DAmore", "AQAAAAEAACcQAAAAECSj6CRxAHwPFY6uoRy4ByggeZ1hPubdfVBwPh/vwe322Qgn4tj70PMF2m0BrC9+Mg==", null, false },
                    { new Guid("30eaf229-a750-446f-b353-8f619614a839"), 0, true, null, 569.7043449325220000m, "80be5541-6d70-4524-8659-6b0686293784", "Shari", "Shari", null, "Fadel", false, null, "Shari_Fadel68", "AQAAAAEAACcQAAAAEFTqRNo/xYY+5hJRgs0n+LwpxLRsUaKwHcb5EDsmgkOpESejAvAQ0O/ZdZRPLZ67Lg==", null, false },
                    { new Guid("31147f68-7359-46eb-af11-622a8764424a"), 0, true, null, 671.0551674574840000m, "e3e0e6ca-2223-434b-bf71-71f722444403", "Troy", "Troy", null, "McGlynn", false, null, "Troy_McGlynn", "AQAAAAEAACcQAAAAEMZ27pP4HiCg1vg1xyb/TPNtmvxzfpMc0Mcp12Q2K4NG8FFrEP6SdLy4ke5OXmFKAw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3162f344-f10f-45da-971c-d41cc675f838"), 0, true, new DateTime(1981, 5, 10, 3, 46, 56, 117, DateTimeKind.Local).AddTicks(411), 18.05193647521570000m, "8bba750b-01df-404c-ac2c-f606f9853751", "Nelson", "Nelson", null, "Stanton", false, null, "Nelson.Stanton", "AQAAAAEAACcQAAAAEEijU35vPi8tW3LZCRKXZP+c2HJBJc+QGTN/qrYeVE1fEn1xnjc736KvZZOF/N8crg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3164a0af-914e-4e8a-9e4d-83d760107757"), 0, new DateTime(1932, 7, 25, 2, 25, 21, 341, DateTimeKind.Local).AddTicks(6533), 17.7761932842220000m, "ca8388da-bed4-4223-b72e-4e6d8281b4e5", "Virginia", "Virginia", null, "O'Conner", false, null, "Virginia.OConner", "AQAAAAEAACcQAAAAELMyqXyA+tw8qTKP2DZqgPZjaDmQwH4Q1NnYYHnMxr92D7sH4I6SAbtul8JWfzquPQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("31995843-45fb-4fd4-bf87-4209bd790c02"), 0, true, null, 182.6645758603160000m, "4d1e836a-e5c6-4a5e-b3b0-c27282dcf24b", null, "Herbert", null, "Davis", false, null, "Herbert.Davis", "AQAAAAEAACcQAAAAEDkJ/WyqFCEAGuP7TLdvZMVktT89AYO/NvTyAFpYlnl2XdIoKxTAfr4LCom9K1K64g==", null, "Female", false },
                    { new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0"), 0, true, new DateTime(1937, 4, 28, 18, 48, 13, 415, DateTimeKind.Local).AddTicks(9352), 964.8783391995280000m, "178c80b3-353e-4913-957c-35638cc4087c", "Tom", "Tom", null, "Ritchie", false, null, "Tom8", "AQAAAAEAACcQAAAAEP2jAM6pgzR9yKDAH+q9ZjB2HJob3D7Mv6MH9E+4rJzQO2TtsZvAPspEYi1pfzDegw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("36333093-6685-44ce-9e09-9007f88e766b"), 0, null, 517.0905565747870000m, "8f6ad8c3-add1-4848-88a9-c7039fd1b865", "Amy", "Amy", null, "Wolff", false, null, "Amy.Wolff0", "AQAAAAEAACcQAAAAEKFcAibUjt9LifnYZn/6F35mPtyLfXqIHqFiUPayY0x9Fzbwj+PWSZew/3qZqhUoPQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b"), 0, new DateTime(1926, 4, 22, 6, 5, 55, 570, DateTimeKind.Local).AddTicks(9686), 17.04599382711820000m, "71ac3177-34c6-4555-9f39-3f509c425d32", "Lionel", "Lionel", null, "Mante", false, null, "Lionel_Mante", "AQAAAAEAACcQAAAAEGR7wsLSYL6+zkp3OGZAQcocBTM8wTsAelbBWmVFQgSWWYUw5DcVkuTzkYnI0h2/8w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("38262136-b169-413b-ac46-ad2f34893b37"), 0, true, null, 584.1473216224620000m, "9e890657-4233-482d-a8ee-5153d5bd231a", "Marvin", "Marvin", null, "Brekke", false, null, "Marvin_Brekke45", "AQAAAAEAACcQAAAAELrYbeqg3y+Is4sqhdebwm1g3aUhWLA8PHB1mGtWuo8hPwRB5Fuavv+FU3VF3iUa4w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7"), 0, null, 457.7705623181340000m, "39dba888-5c44-4f99-8407-9f4f22c5876a", null, "Jessie", null, "Schoen", false, null, "Jessie95", "AQAAAAEAACcQAAAAEJhZfbgH08/aC6qAQI8X2A73xRtSasmwAhIL7UeCGRBy5MaOx4zTgcqk4SULQa5ZDg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6"), 0, true, new DateTime(2004, 11, 8, 19, 0, 14, 513, DateTimeKind.Local).AddTicks(4517), 201.7765892184960000m, "2d9669ce-33cb-4268-9f4b-07b1be1621e3", "Martha", "Martha", null, "Hettinger", false, null, "Martha.Hettinger", "AQAAAAEAACcQAAAAED87x85j2eGapuj/EODVPLNoho+P/upgPHMUQQINrx3RCVEXrkqnkz1YXKQ6Zi4Erg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117"), 0, new DateTime(1928, 7, 21, 12, 5, 28, 108, DateTimeKind.Local).AddTicks(3317), 7.212688133097280000m, "3673a7ed-0ef1-4158-a6ec-9bb2456778a6", null, "Joe", null, "Schulist", false, null, "Joe.Schulist", "AQAAAAEAACcQAAAAEDQC2Peg5zTNHtYGPTUNsGx+rRGqQkD4AG8qVHGWcQ9XA2nSrrvoNqRO/US6z/sDRg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17"), 0, true, new DateTime(2005, 1, 23, 2, 2, 14, 761, DateTimeKind.Local).AddTicks(3036), 398.8923225845380000m, "77136a73-c495-4a3b-920c-555a259d4f14", null, "Levi", null, "Daniel", false, null, "Levi33", "AQAAAAEAACcQAAAAEAqnwuEgppr0YrgnrCMl8PuTb5PgWHLg5fAiL6btPijjw7O5EdT8tEBs2Lz0ApN6pw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e"), 0, true, new DateTime(1952, 9, 6, 15, 25, 37, 580, DateTimeKind.Local).AddTicks(3433), 310.0971520047640000m, "183f066b-c79f-4bca-81f6-bb6562417a65", "Sandra", "Sandra", null, "Farrell", false, null, "Sandra.Farrell20", "AQAAAAEAACcQAAAAELxvTAQpDSG3RXf4NkWnqtOvQ3Jh6N+8Es3F6edRa72lL9MRGQDeCUU//9pUQUbVOA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("406d2568-124d-499f-ab91-bf26387bbe3d"), 0, true, null, 63.79823865476030000m, "a81a2b1a-859b-47a2-9dad-0834074ab18b", null, "Lauren", null, "Beier", false, null, "Lauren29", "AQAAAAEAACcQAAAAENU0JWr1ckbXHyuLy65FuD2VhnnoMcMArezk2EvjGisugSVL+tD4HRBv5NyjckeYtA==", null, false },
                    { new Guid("41654f75-1b53-494e-9d06-289e15fbc423"), 0, true, new DateTime(1932, 5, 4, 5, 47, 0, 495, DateTimeKind.Local).AddTicks(3760), 402.5821196274030000m, "6e04dc3d-d694-4fda-a025-9f7b46fcc394", null, "Wilfred", null, "Glover", false, null, "Wilfred34", "AQAAAAEAACcQAAAAEJq1mSDNeZq2ihFeyZNOQstbpUAbFQFJyxP+ARpAo2cZ3aU7c3yZEq4ohIfcCw64kQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8"), 0, true, new DateTime(1943, 3, 16, 16, 3, 53, 717, DateTimeKind.Local).AddTicks(5396), 0.7831641876028250000m, "f4792f7f-f80d-41d1-ab83-006db2e0d73e", "Lindsey", "Lindsey", null, "Gorczany", false, null, "Lindsey7", "AQAAAAEAACcQAAAAECXYNC3shgV55knfpFB4HdvBwiWZcm1ru8OFAUa12BQ++rig2vZDWxI+zpcZLU6F4w==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b"), 0, null, 853.6429981862430000m, "1fa99fa9-1b12-483f-bbfd-fa6b5cf858c8", "Zachary", "Zachary", null, "Bernhard", false, null, "Zachary.Bernhard", "AQAAAAEAACcQAAAAED0DUVa/WHHG6ScznM4HmUgOr2P4iLisAetYPqieaz5NgOjP0cTN/VW6wvwttuE1gA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), 0, true, new DateTime(1985, 3, 3, 15, 3, 42, 985, DateTimeKind.Local).AddTicks(6941), 782.8014920117790000m, "98b68953-8d96-460c-a28c-0793ac2baacf", "Arlene", "Arlene", null, "Kirlin", false, null, "Arlene.Kirlin49", "AQAAAAEAACcQAAAAEFZwHdOHlN60Ve18Vt+0YJZIpBM837c/gyvEieYEcGX9h3ujE76F2AZTcQeDpUztKA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b"), 0, null, 966.6866537540920000m, "8c30e4c6-bbad-48e8-a962-a6f845e6db78", null, "Katherine", null, "Rath", false, null, "Katherine.Rath23", "AQAAAAEAACcQAAAAEASskuBhuaS+DBe+PJ/pxYEXlxojee5CTtj73UFSYbuPjnNby+FPhJi5IqVBw4P/UA==", null, "NotSelected", false },
                    { new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164"), 0, null, 338.8842592665210000m, "ba629296-6d7d-4dbe-9450-7bb55f1e2da9", null, "Myra", null, "Ward", false, null, "Myra_Ward71", "AQAAAAEAACcQAAAAEFViCFJSf2TzmPiIBKIvcQhaahAk5zKrl9G9p5CcKtfeF0t4tNZb2DHvtZeXREzLQA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("48f78165-0368-457a-a33f-c7c330b9016e"), 0, true, new DateTime(1932, 9, 27, 4, 22, 32, 149, DateTimeKind.Local).AddTicks(4367), 260.326729944330000m, "7926e2d1-a656-4e0d-bf3f-4fea7cd8c9d9", null, "Sherri", null, "Boyle", false, null, "Sherri88", "AQAAAAEAACcQAAAAEOoJYhHCLEL9fhLfRceBcfqJpYTMpZ/8g6gh/j35P44TIDYsl0S1jKD76Eefms896Q==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("48fec127-ff7b-4341-9417-71a573651f92"), 0, new DateTime(1974, 6, 13, 13, 10, 8, 511, DateTimeKind.Local).AddTicks(7580), 211.4769513465150000m, "46893ce7-a7ba-4156-a4d3-4ce0420e7fb5", "Cesar", "Cesar", null, "Dicki", false, null, "Cesar.Dicki55", "AQAAAAEAACcQAAAAEPgRkLXMNvnz4Vfe/WaQ6LqepZ79py75LnTBOjGQnJQIDgSaX/aGXPvtuc57sW1ybw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), 0, true, null, 528.2725371616150000m, "868b06d9-7eb2-43ba-b175-c65222aa41b8", null, "Josh", null, "Johnston", false, null, "Josh.Johnston", "AQAAAAEAACcQAAAAECdPv5esXKdI8G9xY98yWfcj/QcT9N1RIqiyNwi/qGIPR/PH3TENLmYcEWlU/M/+fw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4a67c697-28bb-45af-bedf-56c801f41cce"), 0, null, 824.0110030493360000m, "b7fbffde-ba12-4edf-9016-41eb965ed6b0", "Isaac", "Isaac", null, "Mosciski", false, null, "Isaac_Mosciski", "AQAAAAEAACcQAAAAECZOoLZ3x5IMI8ygAwgf/PHf2LnlXvCamWJT5KkNObItO3AtAiuC49mSAh/ZHHAjDw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4a9c9271-d464-4065-866c-61bebcbab92a"), 0, true, new DateTime(2008, 9, 8, 15, 16, 9, 410, DateTimeKind.Local).AddTicks(5923), 742.4744361869580000m, "6743df0f-4143-4b3d-9374-ee0b9595e183", "Jacob", "Jacob", null, "Doyle", false, null, "Jacob.Doyle23", "AQAAAAEAACcQAAAAEKP+scVvlpviWfRGJpV1fWt3+VOm9jkuVWRIsxKyhBJTu+6WgVOejWQ5hbPYxcRmPA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4b419694-b708-45f4-ba12-d448054d38e8"), 0, null, 959.9090497877210000m, "53ed2a26-b9ab-4079-bc86-2e1f0da5997c", null, "Mamie", null, "Padberg", false, null, "Mamie_Padberg38", "AQAAAAEAACcQAAAAEIwfU7CTE10GcD/uJMHQ0vy+qxeUAvhITBQmtub1iWIqTIQeJJSYwyRiGWmO9Imr5w==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e"), 0, null, 675.3487421151050000m, "53bf5ab1-4488-4e74-a074-78122afe9428", null, "Billie", null, "Kling", false, null, "Billie.Kling0", "AQAAAAEAACcQAAAAEORPP+SgLMDb3peWqyE8dYnDpWVdIgilXGAap418ZyYZT+tK9uN9D8MJGkq5Y5Q+YA==", null, false },
                    { new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b"), 0, null, 540.5474097466210000m, "5a701007-b62f-499f-860e-ee3d9c4a33c2", "Jonathan", "Jonathan", null, "Aufderhar", false, null, "Jonathan88", "AQAAAAEAACcQAAAAEBzj0PkukDgdunPhOavaJ8hRHHWCy6i1X25dB7wqDNLG3Q6v4WdVY02mpzv25Ol+oQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4d7ad763-f133-4452-a52c-bf8209b54131"), 0, null, 77.27244306465430000m, "ea2267a9-bb9c-478b-b6d1-a75855b12951", null, "Charlotte", null, "Strosin", false, null, "Charlotte_Strosin", "AQAAAAEAACcQAAAAEJEOL1SwwfnciBZq66r0S1+DIPAIbtFhydNbJQKXPYsQkKvLAaNzX8cYe5UwnLFWlQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70"), 0, true, new DateTime(1948, 5, 25, 2, 31, 42, 186, DateTimeKind.Local).AddTicks(3607), 177.3376912307290000m, "c05d258d-a8d2-4b3f-af89-ea99db62dc6a", "Salvatore", "Salvatore", null, "Schuppe", false, null, "Salvatore5", "AQAAAAEAACcQAAAAEIqJfvAWiEXHMcIDKaDy/xv8UL5rP6K6lRnzT1S7tMoOAHmYt8/BAAgYxgnDWObskw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1"), 0, true, null, 201.177057663740000m, "34101a18-0518-4a6b-bd35-7241a05621b3", "Allison", "Allison", null, "Little", false, null, "Allison26", "AQAAAAEAACcQAAAAEAOeGe9LjKHPJPy5i5Iy1znkd2qxLAWX6ypUp+kp9rRMsLOhsASJuQMH6GajcBSiUQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4eccd787-74d0-467e-9de9-4f711c05852c"), 0, true, new DateTime(1998, 7, 13, 4, 8, 50, 709, DateTimeKind.Local).AddTicks(6289), 192.7761682800960000m, "52b82b25-1720-4a5a-80a1-fa4eccc51603", null, "Tami", null, "Bode", false, null, "Tami_Bode86", "AQAAAAEAACcQAAAAEPKlD0u7ziwgQUT64TEIebfbw14OB6ZzJSlpAPGfWN7m9ieGvOhg7BTZqwdCv8I1ww==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da"), 0, new DateTime(1943, 12, 19, 6, 23, 12, 492, DateTimeKind.Local).AddTicks(2931), 489.6838727940420000m, "875b4ca9-4a3a-4d49-9f4c-d822ca97a0c7", "Merle", "Merle", null, "Schroeder", false, null, "Merle.Schroeder84", "AQAAAAEAACcQAAAAEOZCAd1Mje+GekRh+HDnwBlD/dDRlzhgIPm97nNHfOUeN+Oiz5qOGqL0FpTcPCPWyg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4f18c06d-9e38-4392-a135-68af41671c23"), 0, new DateTime(2003, 3, 29, 23, 3, 5, 110, DateTimeKind.Local).AddTicks(4772), 510.9357978404190000m, "55cb8a15-be64-4914-9af9-abd594078870", null, "Lorraine", null, "Orn", false, null, "Lorraine_Orn51", "AQAAAAEAACcQAAAAEIF9/G35wYoJeTmLLaNimep4vUGBt+F2/VPG4M9AwXbFqSIt3dFlC28mcnHjttF1yQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141"), 0, true, new DateTime(1963, 3, 4, 18, 52, 37, 268, DateTimeKind.Local).AddTicks(7684), 701.0687585487670000m, "a0913513-90d5-4a25-adb4-f96b8dedfd7f", "Mack", "Mack", null, "Cremin", false, null, "Mack_Cremin41", "AQAAAAEAACcQAAAAEC3jjhVibmwSNGMdQl/o8l7b66Uy/4SsR7HbhcqKiIxRGOXZsEXcAahoJUezBC5y3Q==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204"), 0, null, 752.1829538019450000m, "43b03862-cf63-4e22-a0da-f9f584fae192", "Ronald", "Ronald", null, "Bruen", false, null, "Ronald_Bruen", "AQAAAAEAACcQAAAAEGauR05kGm6Y5hOoQ51EKC/P11cmfIOdXoWV6orQzRo4YtdHSX62JfQ+N44FChKLKw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2"), 0, true, null, 939.5862797704070000m, "7b7ce0d2-768d-4029-b57a-ccbf692f1890", "Anna", "Anna", null, "Stoltenberg", false, null, "Anna80", "AQAAAAEAACcQAAAAEKL2PhOWwC4F4Q0JMrkBhuC8/ob4fNoHH6wkDRX0aIovGMMDuvok35Qjg6/qpnttwQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2"), 0, null, 703.7878829260740000m, "1ce52114-7377-4229-b9c4-529f618c4a88", "Rex", "Rex", null, "Emmerich", false, null, "Rex.Emmerich59", "AQAAAAEAACcQAAAAEBOj9rOjNWhdZLJmCRHQKf2AzZpr6UnmP/psEloey8lTDkjrGpHqZpf/+lGKR2Dxjg==", null, false },
                    { new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f"), 0, new DateTime(1936, 3, 17, 1, 29, 10, 58, DateTimeKind.Local).AddTicks(1843), 596.5956160345960000m, "9ccaa995-72a1-4d4e-8b47-20e3c5b0ec40", null, "Joel", null, "Kshlerin", false, null, "Joel.Kshlerin32", "AQAAAAEAACcQAAAAEPWz74TD50UGMhS3ec4IPHLocfjL/ELAP8y+xVksOOvUU2Z+F4viv9JjfRx6Oe3zGw==", null, false },
                    { new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33"), 0, new DateTime(1983, 12, 1, 21, 35, 46, 380, DateTimeKind.Local).AddTicks(2637), 574.6129484404430000m, "5bf257ac-ae6f-446f-bf22-5d574453d1ca", "Lisa", "Lisa", null, "Lueilwitz", false, null, "Lisa.Lueilwitz58", "AQAAAAEAACcQAAAAEIfuhl+96k9685anEYFCKJnLvP66zQH0Ejojp3hNCIG0jBjsUMbHx4cBASzpZBHqtQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01"), 0, new DateTime(2001, 8, 25, 22, 23, 21, 372, DateTimeKind.Local).AddTicks(1103), 754.9224841756480000m, "2812db15-fc6c-4450-97ec-da5c9c38048f", null, "Winston", null, "Shanahan", false, null, "Winston90", "AQAAAAEAACcQAAAAEB69LJFErGP0bZA0yAAmXCrWN3V6wb4oeb7dK1q0oWOn8IhD9DLPEVOXPzn9+Gilsg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda"), 0, new DateTime(1991, 5, 8, 3, 13, 7, 154, DateTimeKind.Local).AddTicks(3731), 877.3944542639610000m, "6551a36c-b21c-4580-bed5-cfc001bc004c", null, "Blake", null, "Krajcik", false, null, "Blake_Krajcik", "AQAAAAEAACcQAAAAEPqIJaV/dyRlFy/7QYikE3qIscbvo1wshJdjE9LKbJi4hu0s0E8o+fH22TYSND4XkQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("576c41db-7388-43c8-8b70-27543c323237"), 0, true, null, 920.9397546704540000m, "4d195b78-4070-4d8d-aa1c-33c6c9e448a5", "Irving", "Irving", null, "Boyle", false, null, "Irving30", "AQAAAAEAACcQAAAAEJNmb/RuhhYxx+59QWCRRl5dKYeX1GXx4ItqQELNi4ubMvek6lgLaQNHdpjPij+Z2A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead"), 0, null, 607.1991053036520000m, "0c1517c0-6006-469a-bf3d-dc4bf08b071d", "George", "George", null, "Feest", false, null, "George_Feest", "AQAAAAEAACcQAAAAEPc+Ngr2rRCjhwrhknep4IX9hsR6phcaJd90Tcqup8OE3e81YOn5JfT3JRRIf7eoeg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426"), 0, true, new DateTime(1939, 1, 30, 18, 28, 0, 638, DateTimeKind.Local).AddTicks(1646), 748.9986242672010000m, "0444cd0e-c956-4b73-991d-77a1fc831ced", "Gloria", "Gloria", null, "Jakubowski", false, null, "Gloria94", "AQAAAAEAACcQAAAAENjhMm9SUG25CZq+CKXdYYxTTcN2D0rW5iVQrl0P9ui2pwzIWBrKY8pSNMt83b/b4g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe"), 0, new DateTime(1937, 8, 3, 19, 54, 24, 557, DateTimeKind.Local).AddTicks(2023), 973.1875151761580000m, "bdb4112f-c0ad-47b2-b6f7-4cb069798557", "Charlene", "Charlene", null, "Effertz", false, null, "Charlene.Effertz", "AQAAAAEAACcQAAAAED7SWM4JDEWiGPal6UkvTLbD6tcOjsIG+Tcf3zNOV3Ao4ge6AAgSjMM5wN1I+bmnkA==", null, false },
                    { new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193"), 0, null, 874.6487350211670000m, "8357816e-d0a2-4721-9781-0d8606d9b0c6", "Grant", "Grant", null, "Muller", false, null, "Grant_Muller32", "AQAAAAEAACcQAAAAEDG84qd/qTG2lg8gFIxb/lWT76SaOK7v9/kUMddmhd8iGH+KoiE5s1oVo/bxw5ptLA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5d96609e-242a-4e81-841d-15924cb829f7"), 0, true, new DateTime(2004, 1, 14, 3, 43, 48, 119, DateTimeKind.Local).AddTicks(7439), 736.7782287377550000m, "b63b7a68-bda9-4a0c-a1dc-bb0053910541", "Tina", "Tina", null, "Prosacco", false, null, "Tina61", "AQAAAAEAACcQAAAAEC58wrrtWm0p97um7unxXBYaMasgoL6Zef6KrjgGCLz31IlRhy36ACYSPwLCIXUyIQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea"), 0, null, 156.7843665853410000m, "273a1f1f-68f3-49f7-86cc-7ba86c84e0bc", null, "Timmy", null, "Goyette", false, null, "Timmy_Goyette9", "AQAAAAEAACcQAAAAEAI3fWHp4bEdRdt4u+/Q9XL+dHJnjo++XBfxHlM2W7LABLEjwSX2ndd8bnsUMvscFA==", null, "Female", false },
                    { new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc"), 0, null, 911.7145455821760000m, "57ab7e2d-3849-4bd8-a31e-fbf16b66d590", "June", "June", null, "Lowe", false, null, "June_Lowe34", "AQAAAAEAACcQAAAAEFyvgGfrvp12fPMA6IgDehBmCY0ULQBAv+LVOAk0On+p8+Hi12xaJecy5p7DJzKYOQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5f081f26-af78-4d3a-b693-1268567854c9"), 0, true, null, 887.0931435524230000m, "f3b33378-2cfb-432c-9fe5-0b8e126f11ea", null, "Tasha", null, "Ratke", false, null, "Tasha.Ratke36", "AQAAAAEAACcQAAAAEFQYtiHiLX2bg/kNX3YU5Jmss4eEniG28+fRwv6TVgNs8/MCccWlHoJ8sido4ylQtw==", null, "Female", false },
                    { new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b"), 0, true, null, 777.6330446099510000m, "6bdb4c0a-d531-4686-b9a7-4e51b44d4438", null, "Rosemarie", null, "Spencer", false, null, "Rosemarie39", "AQAAAAEAACcQAAAAELi8nb2aCpBdjgfEaYQgR+hhvjn3CIv59q+p+5UZv7xrxHGtDQfqqnPuHfQZT+P7OQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd"), 0, new DateTime(1967, 2, 28, 3, 57, 39, 950, DateTimeKind.Local).AddTicks(7454), 103.3643035803770000m, "bf00d457-6956-4cd5-9578-fb843477aff1", "Jasmine", "Jasmine", null, "Schuster", false, null, "Jasmine.Schuster", "AQAAAAEAACcQAAAAECMNKVXaQgiCDSuzNXToJr7g8KjyZAv7RwYgM3Dwb70wOigTRJMWmIAEWwkugxeSuA==", null, "NotSelected", false },
                    { new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6"), 0, null, 478.4405620923550000m, "62e57612-e8da-491a-af4a-905b2ba3791b", "Arturo", "Arturo", null, "Kilback", false, null, "Arturo.Kilback", "AQAAAAEAACcQAAAAEE67BJ8Kyh5D1nxTKEAgY3IjUpSdn5z8s4+5vJtX/aPT7Luc/CsHUcBPc3IXL5QYhw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f"), 0, new DateTime(1972, 10, 27, 6, 43, 19, 246, DateTimeKind.Local).AddTicks(8531), 113.2378230827990000m, "becf9073-ed65-493f-9f77-e9bf1ab0e191", null, "Dianna", null, "Johnson", false, null, "Dianna_Johnson", "AQAAAAEAACcQAAAAEPx+vbAtLM1I/ljArGTnws/K6coUytWDunhQLmimXXI/3+OcIrCVBktWrcSEACsSmg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("60de2347-d620-407d-9699-3b783da3d34d"), 0, true, null, 640.909425731510000m, "a079719c-c358-46c8-afe8-52490b982655", "Cameron", "Cameron", null, "Hirthe", false, null, "Cameron.Hirthe", "AQAAAAEAACcQAAAAEEsyPXRwWNBM5HOzY5Ndrk7f2eVb/JkDQQCzuXKZRCmbY4Wi9ij3uayip7PdSesTDA==", null, "Female", false },
                    { new Guid("61677545-614e-49f5-a121-bebdd3c34a62"), 0, true, new DateTime(2002, 1, 2, 1, 54, 16, 109, DateTimeKind.Local).AddTicks(9743), 393.0817953221490000m, "44af57fc-e3ba-4ee3-87fa-ed35678450bd", null, "Rolando", null, "Hamill", false, null, "Rolando.Hamill54", "AQAAAAEAACcQAAAAEGA4KwALVYCjcDfyW8Bhb3o4rVdrJAn3RLzw769AcbuP3JTOdwQ4HpO1kJrMiF2o8Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6"), 0, new DateTime(1938, 5, 22, 19, 36, 34, 250, DateTimeKind.Local).AddTicks(8721), 90.18988450288860000m, "80fd0b61-44d0-4f4a-98a1-861223ebe8de", "Lester", "Lester", null, "Willms", false, null, "Lester47", "AQAAAAEAACcQAAAAEF/0gspEyUB5k+24G0qEjh6WMkYV2yHHwD1jtImDRPPflQFurCQnBdu9A6b819OD2w==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826"), 0, true, new DateTime(1981, 3, 6, 3, 5, 56, 322, DateTimeKind.Local).AddTicks(8208), 129.3707331478310000m, "412d2647-77e3-4a59-bed7-5c52b49be90e", null, "Stewart", null, "Franecki", false, null, "Stewart_Franecki", "AQAAAAEAACcQAAAAEIvf6PaDRwP0sf2/xZ9JgF5VBDNXi9f08LwpVNgD9ul72C7YbR9bCjLNwVr5VHR1ew==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("63f59de1-31f5-4826-bae2-9494ab073e70"), 0, true, new DateTime(1984, 8, 12, 23, 48, 47, 72, DateTimeKind.Local).AddTicks(9902), 51.53543386860190000m, "ac58ead5-876c-4c5b-880f-f0598ee3c28d", null, "Timothy", null, "Abbott", false, null, "Timothy33", "AQAAAAEAACcQAAAAEFLyYLtSGweh6AzTzXkbwtypeWwjgtoCVNccgCwXfs4g9gBpna0sRRE89AZWYoQu1Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5"), 0, null, 793.2285623808460000m, "214e55b1-d82e-47e5-8769-6f1cc77caf5e", "Spencer", "Spencer", null, "Dicki", false, null, "Spencer71", "AQAAAAEAACcQAAAAEBssBnx753reOqHdKbgnkmNDgU6Zz8gYpgbVPuw+xszG6YleeLfjt3wREGbfavqvcA==", null, "Female", false },
                    { new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), 0, new DateTime(1991, 4, 8, 22, 19, 8, 27, DateTimeKind.Local).AddTicks(2809), 299.429402860860000m, "ef6e8cb1-f74c-4255-99f0-a2e7e2095bd9", null, "Percy", null, "Kuhlman", false, null, "Percy.Kuhlman51", "AQAAAAEAACcQAAAAEGbAPH0zR1bNLONhtQhzdckxxi0pbZiBrFq2HWM1OEW/e41AQKWeHUaL0mAy7X+x/Q==", null, "NotSelected", false },
                    { new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), 0, new DateTime(1981, 11, 27, 23, 26, 30, 557, DateTimeKind.Local).AddTicks(3945), 478.8004355152190000m, "7c22787e-d0ee-4c1f-981c-e464297a4a1d", "Brittany", "Brittany", null, "Carroll", false, null, "Brittany83", "AQAAAAEAACcQAAAAEOI+YbK86H3MYksNWuqKvbqLxRrMsJQdbgeUeRcUiyVEA6/TiaCkQqUYyGjDUDD1uw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d"), 0, true, null, 962.5340737255010000m, "62099237-8212-4eff-8500-7fb146757322", "Arnold", "Arnold", null, "Reichert", false, null, "Arnold.Reichert84", "AQAAAAEAACcQAAAAEMToMe3zeDUP2/s0hh24y6zv+0lA2zvt/aswybcUEaK4eKGMkl0gxGPBpBE5Okkv2A==", null, "NotSelected", false },
                    { new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc"), 0, true, new DateTime(1967, 7, 29, 6, 58, 2, 907, DateTimeKind.Local).AddTicks(1696), 278.5790315734190000m, "82ff571e-2e82-4d39-a79c-5f6fed830822", "Alexandra", "Alexandra", null, "Blick", false, null, "Alexandra3", "AQAAAAEAACcQAAAAEG3g66wVF76p8Vqg8dy8Vih6XLcZWZN4kfKH4M/8b0sbhzEuSt9Nwzzn3i7FVRjGHA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("69445845-4c7f-4276-a288-559e4b4df167"), 0, true, new DateTime(1933, 2, 13, 21, 40, 30, 394, DateTimeKind.Local).AddTicks(9369), 753.8810976962520000m, "d9a358c4-3c18-4360-8bb1-6a45901c32fd", "Hugh", "Hugh", null, "Paucek", false, null, "Hugh16", "AQAAAAEAACcQAAAAEM87Jt4vODccloXTqpO4T7CXSXhIThBd9xDJeS14L3ANS53j0z2Y5mEF7mfdktqMZg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91"), 0, true, null, 121.8544343223510000m, "d19f6bed-e354-4b94-906a-cacb99ed2e77", null, "Chelsea", null, "Morissette", false, null, "Chelsea_Morissette", "AQAAAAEAACcQAAAAEDe7aZ/vbBxGzgbMKDlrgY2g+vs18s1STofdftMUg3zRSu2LUDNJ4xQCqPYAhdCu8g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001"), 0, new DateTime(1946, 9, 26, 7, 16, 16, 805, DateTimeKind.Local).AddTicks(4836), 658.729819679930000m, "d1622177-8750-4270-b9a9-53ed8a50df30", "Cornelius", "Cornelius", null, "Collier", false, null, "Cornelius.Collier30", "AQAAAAEAACcQAAAAEGIIbJJS2U2iTXJ1h2IRJ/Tnbl0h/tVLv1dMuie8ClVNy5G0p7sdqSENNkSsCcnDcQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3"), 0, null, 205.0303702234510000m, "d187f0b6-84b9-47a7-81c9-9aa2c41d6f43", null, "Javier", null, "Schinner", false, null, "Javier_Schinner38", "AQAAAAEAACcQAAAAEIFgwhTdV59Jjb4UXKW4ACRd+Hr4Pq43ztfD6tz0t9uXWENLVzKiXe7KSxxI8D5chw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6bd6126d-6465-493b-abdc-935b7afbc646"), 0, null, 551.5435835484980000m, "161b2755-b9e1-41cd-9413-9fcb6fcee65e", "Flora", "Flora", null, "Streich", false, null, "Flora.Streich56", "AQAAAAEAACcQAAAAEP9HWH7k9mLqVYD/sEqd04Nz/ZUcV9+M1eKB7kb/+AnsyDK0myl/NcDkMp0aDpCnXw==", null, "NotSelected", false },
                    { new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12"), 0, new DateTime(1982, 9, 5, 15, 16, 46, 633, DateTimeKind.Local).AddTicks(6702), 260.6321531424440000m, "b999e5ae-c9c8-4a8a-ae97-75dafed2cfa6", null, "Randy", null, "Frami", false, null, "Randy.Frami22", "AQAAAAEAACcQAAAAEOL5zN2ZMneXtDPj+Tm3uAd5c52XmyyiNBOU5N+xsQ5vNgNGZEXSBgYso9k8cL3x2Q==", null, "Female", false },
                    { new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e"), 0, new DateTime(2001, 2, 8, 20, 29, 26, 959, DateTimeKind.Local).AddTicks(6383), 998.6765475085370000m, "a6342bd3-a3d0-41bb-8ec3-803ff6336cd2", null, "Mandy", null, "Zboncak", false, null, "Mandy.Zboncak", "AQAAAAEAACcQAAAAEJAMf9fH8c4WgzcsaGbdpdT7Lk5Skj4vo1Qq2mNTUJxzpzgto4ln4/py1g10dWdXKQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10"), 0, true, new DateTime(1930, 6, 19, 17, 8, 46, 361, DateTimeKind.Local).AddTicks(5585), 987.5343473097190000m, "140490c8-9eb6-41be-88df-6ecc4a644bff", null, "Carl", null, "Greenfelder", false, null, "Carl_Greenfelder94", "AQAAAAEAACcQAAAAEJdlVNsHDbQBGaSLd4Bc/9eVaFeoFJM7+R7ZxTQqlWlUrgzbCwfKSfqwGC/t78O+9g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e"), 0, null, 405.8872890832760000m, "e4f1027a-1877-4525-b44d-c1febad6ca92", "Emanuel", "Emanuel", null, "Spencer", false, null, "Emanuel_Spencer71", "AQAAAAEAACcQAAAAEIXE2T9VELZWI4kI5b/gviP+NzmQNgKIGIOU4mF8XQSZWULTdnmWIiAY86KtFvvsuQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2"), 0, true, null, 322.8501223436020000m, "6b7235b7-6eda-4de2-85fe-bbb825b0a4df", "Dixie", "Dixie", null, "Kshlerin", false, null, "Dixie.Kshlerin", "AQAAAAEAACcQAAAAEIHqInUCyC4MgY1weA1e848M3dc7mD+OUfs83vXMrAWLQFr84hGFAbqKDgAFDKn0rw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8"), 0, new DateTime(1939, 8, 17, 3, 2, 32, 457, DateTimeKind.Local).AddTicks(6640), 93.43107098545340000m, "42d285ce-b56f-4ce1-9e1f-8b15a177356b", null, "Angel", null, "Zulauf", false, null, "Angel90", "AQAAAAEAACcQAAAAEHLEMD23OZRi1nKCGAt2AnvYOHR3u9UOCrgbkmr6veutsJ8ahANOKiRJkh20XkdROQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc"), 0, true, null, 468.610528642280000m, "dbf4e125-feeb-4bee-86d6-f8252a1a2c14", "Flora", "Flora", null, "Marvin", false, null, "Flora17", "AQAAAAEAACcQAAAAEJVP8rHFr8LFYfzvvBEZbhR3K6PgzmZGDeBfDw+qKvpW6aUcvlQREN7KmfETh7JEbg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7613a4be-1868-4124-8145-c559fd0b8b95"), 0, true, new DateTime(1928, 9, 8, 11, 11, 47, 274, DateTimeKind.Local).AddTicks(87), 500.1697623282470000m, "104e6524-5335-4289-96c0-25d6c78977c3", "Grace", "Grace", null, "Stiedemann", false, null, "Grace65", "AQAAAAEAACcQAAAAELI+xmfQkGhbZTUnIIj/OxanegWKA23Vqbs6mjrh9G+2NOjEANfeXpqz5AUFpnZunQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714"), 0, new DateTime(1994, 12, 13, 9, 59, 23, 742, DateTimeKind.Local).AddTicks(1189), 394.0131352443060000m, "4d68e199-f005-4a07-821a-fe94578aa938", null, "June", null, "Feeney", false, null, "June97", "AQAAAAEAACcQAAAAEMKdXNmYwXJB8sWDbYZkOGJw2J0UDy1jnx1Di+ImxkpLq+IqUYI7Wle2Ias8PQH3SA==", null, "Female", false },
                    { new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b"), 0, null, 872.5421484415390000m, "76c20a17-ff83-4758-94c0-4f8de5a5e05b", null, "Dixie", null, "Sauer", false, null, "Dixie57", "AQAAAAEAACcQAAAAECxG3JV/xbzKh9uz9KJ2Tvjkiz8zpKf+8c67evspkcC2zMJyr9XOPbbRhyAhKLl5Gw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd"), 0, new DateTime(1950, 5, 3, 23, 55, 20, 225, DateTimeKind.Local).AddTicks(8975), 379.6385630521310000m, "f9d517cb-ea9f-4139-a839-e8e5d1f68fac", "Julie", "Julie", null, "Labadie", false, null, "Julie.Labadie71", "AQAAAAEAACcQAAAAELQGPxHCK0W45xrnjSM4qH9QP5iGEFkb470CsrdEE6QIPWZVUa8GlN9sFlIFN0tCRg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f"), 0, true, null, 181.1084788927020000m, "162a3d63-2112-4405-935d-de4271013210", null, "Christopher", null, "Morissette", false, null, "Christopher24", "AQAAAAEAACcQAAAAENTRoFzbkW8jKiRIj+RNYSRgobbAhVuuPkyalM+bD1Wc4/2NRNzWjSV2DvsOa17xgw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982"), 0, null, 682.7984138856930000m, "376168b5-5c1a-49ca-b006-07f01a522a10", "Angela", "Angela", null, "Schamberger", false, null, "Angela.Schamberger35", "AQAAAAEAACcQAAAAELJvlVhrIOs5vQIYMWqgLbAaorntfQOI0afWPCOWeF7Nun2NBNo+z+FIy8BayM1+kQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206"), 0, true, new DateTime(1989, 10, 3, 0, 58, 15, 985, DateTimeKind.Local).AddTicks(3648), 292.8788011147890000m, "97cfeb07-9ba2-4afc-adf4-2bf787f84ef4", "Patsy", "Patsy", null, "Jerde", false, null, "Patsy_Jerde", "AQAAAAEAACcQAAAAEF0Md0qf+DwOV26z7zwVFLFsiDXinzWB8x+9yijPTNnCLkqW8bemvZIMlxPb2jPvcg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c"), 0, true, null, 473.0068777689890000m, "ab8b39ee-c45a-4fb0-a151-3693d42bb516", "Mathew", "Mathew", null, "Schulist", false, null, "Mathew39", "AQAAAAEAACcQAAAAEF38jIL1fd/iEASLicf6ZmsWusnJZArPzCNYGf2RF/2Y/cZuwesEiz0q7o1jHL4fMg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08"), 0, null, 213.5580921189410000m, "04f6bf75-915a-4276-85e6-c8e8e8fc18d7", "Kirk", "Kirk", null, "Mann", false, null, "Kirk_Mann", "AQAAAAEAACcQAAAAEOoWfRmUDp1QBOrMHedn808TocKOXG5q89B9bL+vgPEg34eWC7wHa1cg0lPOdgmxow==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01"), 0, true, null, 768.9624942549880000m, "5da6644f-e9f2-47cd-90b0-3b02c390ce41", null, "Rosie", null, "Hessel", false, null, "Rosie.Hessel93", "AQAAAAEAACcQAAAAEE7B6C5lEK+CGD4iYqSIxWwIKgJqvn5XU/2DmG9krAC89nfkP+rIBR5CfedWQ/0yGw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0"), 0, null, 553.0884204618690000m, "7efc4efe-e71a-49cf-8e6e-70f417830d17", null, "Rosa", null, "Cronin", false, null, "Rosa.Cronin", "AQAAAAEAACcQAAAAEMMEAltEnXBDwQqeeUCMSLK8gQqZd/WOKqrKpKJdNSyKLsBNno5+WeNmNAQKrFTlow==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8123e452-c630-459f-8068-cd86f68c9a1c"), 0, null, 59.74676027364330000m, "d2eb6300-be06-42d1-9a1e-9f49784d2634", "Oscar", "Oscar", null, "Moore", false, null, "Oscar27", "AQAAAAEAACcQAAAAEPKufwzymlMAuYyoDWrSNsU1Zo1rvlIRuL6q4Ip4txEgviiyGKOb/zTmnwJ/bquKaA==", null, false },
                    { new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765"), 0, null, 901.4925675135190000m, "f1194859-6ce8-47e9-a226-bfedd9d8de72", "Alton", "Alton", null, "Hermiston", false, null, "Alton.Hermiston", "AQAAAAEAACcQAAAAEInbRFTBE3Z1RIVC20CU7CfJ6f0Li8PRPn6henKhYGogsERKZsLlC2X3QRCqFOAMxA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a"), 0, true, new DateTime(1957, 1, 31, 1, 40, 40, 212, DateTimeKind.Local).AddTicks(3791), 809.5158615986720000m, "939458f3-8f2e-4437-8293-c4078b366800", null, "Joan", null, "Ebert", false, null, "Joan.Ebert", "AQAAAAEAACcQAAAAEP4EtGL7jLNjrhuVdj5Go1EzUFQ/O7vj3ive9wfne/8bxglHoxf605SoN5HQif/gVQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0"), 0, null, 589.3389398318150000m, "6b79dccc-4945-4cb8-a4d6-1dfb9209cd19", null, "Phyllis", null, "Schumm", false, null, "Phyllis.Schumm", "AQAAAAEAACcQAAAAEKVRyIxKQo7GpuKAYMtEdOLRlMuberSXNmDKKeOR6JuIGC06BHqMDRloia62DGESyg==", null, "Female", false },
                    { new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f"), 0, new DateTime(1951, 8, 30, 15, 7, 9, 464, DateTimeKind.Local).AddTicks(3848), 997.9059129072040000m, "998047d7-3a88-4821-bbc5-3b9ddea0e8f2", null, "Deborah", null, "Willms", false, null, "Deborah_Willms50", "AQAAAAEAACcQAAAAEDMn8L3lbpuzgdNCrdxASSMB0+iMaTiWh34YJDaHmRQ9ZXCBmt7x9m34QFNUWbvzCA==", null, "NotSelected", false },
                    { new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95"), 0, new DateTime(1973, 6, 26, 6, 19, 26, 38, DateTimeKind.Local).AddTicks(1861), 526.8976675031450000m, "37fc6616-d181-496d-9141-4bdd5cc73c5e", "Garrett", "Garrett", null, "Franecki", false, null, "Garrett83", "AQAAAAEAACcQAAAAEJu49rB4UrIuRVHY6tV/7lX+U4mkWcP+FjHJU5g0KI3gs/FDjvm4eOPmBSRD26rsLQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f"), 0, true, new DateTime(1975, 9, 22, 0, 20, 28, 664, DateTimeKind.Local).AddTicks(7263), 831.1308049973970000m, "4b1340e0-1697-4fff-8078-7c7038cc2376", "Willie", "Willie", null, "Schowalter", false, null, "Willie.Schowalter92", "AQAAAAEAACcQAAAAEKV1X8zn3pZRyZ3dhSsILe+Bm/KCsii8FW/3phjrn2VMANaQ5d2+qhD+e75IKp3KuQ==", null, "NotSelected", false },
                    { new Guid("85465426-23bd-45da-8610-8fbf237a6018"), 0, true, new DateTime(1945, 9, 10, 4, 34, 8, 144, DateTimeKind.Local).AddTicks(9147), 247.1771728051310000m, "ec624a3f-9fa0-4dc9-aea7-e50f8ceefa8d", "Ramon", "Ramon", null, "Rice", false, null, "Ramon_Rice", "AQAAAAEAACcQAAAAEMH+ZyXiHeAO1Kx0YQyKseZcyqpt9W2qXgOR/XcDQMkJC02WqW3JH/XuynwAUIu+ag==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("86132647-79dc-4073-869d-dd0cc40068f9"), 0, new DateTime(1951, 8, 22, 1, 45, 58, 576, DateTimeKind.Local).AddTicks(7988), 86.88649408348720000m, "be3b6569-cd32-472e-9516-5acde07a25de", null, "Lillian", null, "Bernier", false, null, "Lillian.Bernier", "AQAAAAEAACcQAAAAEET2Kn2xBh/AWpsRluriyN92LBNJgC04OoWJXY84Sgo4RGG21WjAFgTF0a47xu4LrQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2"), 0, new DateTime(2005, 11, 27, 19, 35, 46, 590, DateTimeKind.Local).AddTicks(770), 939.032877637190000m, "c824177e-5196-41a0-ace7-b0f9cfc37319", "Harvey", "Harvey", null, "Weber", false, null, "Harvey25", "AQAAAAEAACcQAAAAEBGVyhwW/w2fr43FC+qb/CTn+1sXrDdCkMOA9ySGkZD7xiCvPrMvUBwVxaPnTa2xEQ==", null, "Female", false },
                    { new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1"), 0, null, 481.7565590698680000m, "cf0e89b3-aef0-4acd-b694-ae43bec9521a", null, "Naomi", null, "Schuster", false, null, "Naomi_Schuster30", "AQAAAAEAACcQAAAAEDbZCrf86LTwbSzlemdzSGh+kCF3Hv4BXN6XMHKSKuT5oCd63nKVKsEuk37g43EO3g==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c"), 0, true, new DateTime(1973, 5, 25, 4, 46, 38, 273, DateTimeKind.Local).AddTicks(7999), 124.1042350007350000m, "eb17c69d-f2cd-4c8a-a427-f5bbd2457065", null, "Vanessa", null, "Gutkowski", false, null, "Vanessa.Gutkowski", "AQAAAAEAACcQAAAAEPZVO5qWB7EkwE7xtKV5hLb82GL0sy/8zZLH8LtVRlWISNc9NeOND9U6eMsGyocHSQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb"), 0, null, 63.39626117738260000m, "b6bfcc35-fcee-4e21-99f9-c424aca445a3", null, "Cecil", null, "Nolan", false, null, "Cecil.Nolan", "AQAAAAEAACcQAAAAEOGdV0PlXf8OEuWuS99EY8qtmN0vZrnSjNgMKkL8LF1RrBMuCUitBrDFWbFsvUcJCQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93"), 0, true, null, 887.7246435376020000m, "0e250720-d6b4-47a6-89be-607a330c512b", "Estelle", "Estelle", null, "Parker", false, null, "Estelle18", "AQAAAAEAACcQAAAAEPMnJigkaHW7iQb/lSoS8z5Ob9JuzGa8pbyF1C+7sZuWyiXBJMeNHrIa8gTvS/H8Fg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9"), 0, true, null, 368.0218891291280000m, "78480e05-9ff9-4553-a327-698dcd3e551e", null, "Bobby", null, "Ward", false, null, "Bobby92", "AQAAAAEAACcQAAAAECWOJ111LkJULSsSRD/0a7319bK8cTblLS4Zn5HGS2+nZSIP8yiuVwRE1ogy6OIMdg==", null, "Female", false },
                    { new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), 0, true, new DateTime(1995, 5, 29, 10, 44, 21, 615, DateTimeKind.Local).AddTicks(4918), 428.1717201707150000m, "f0e3fead-2612-4c82-aa16-9146ae767167", null, "Clara", null, "Kiehn", false, null, "Clara61", "AQAAAAEAACcQAAAAEBdYmxFx7tpd12l8nq+HUzegaMxMbYBf2kyfRTkc3g9VSWfO3gTALwsh/MRiKYDTFw==", null, "Female", false },
                    { new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8"), 0, true, new DateTime(1942, 1, 9, 17, 53, 1, 992, DateTimeKind.Local).AddTicks(9), 269.0919611253650000m, "b50f186d-1ef1-40d1-8994-d8ea82a1bf93", null, "Miguel", null, "Reinger", false, null, "Miguel_Reinger79", "AQAAAAEAACcQAAAAEGQ9Cst9E/UcoZlxfgpu1XAErGrbbam0JyIlqtGsBMcDIiBdatsA77OUDdmIaWoYaQ==", null, "Female", false },
                    { new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a"), 0, true, new DateTime(1976, 1, 22, 12, 3, 24, 512, DateTimeKind.Local).AddTicks(7289), 769.9765469928110000m, "ad48e37b-be48-4177-8545-a1bb2b9610f7", "Myrtle", "Myrtle", null, "Swaniawski", false, null, "Myrtle_Swaniawski2", "AQAAAAEAACcQAAAAEGH7dJp3ZaGtbyO1bbWtB2FkrriAbE6WK+qzVefdJmWA9ooTglzjwFGkc2vyZZ1HDw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("914a9168-2743-43d3-9989-0d61085f953c"), 0, new DateTime(1990, 10, 31, 1, 29, 19, 704, DateTimeKind.Local).AddTicks(5465), 60.05176857549010000m, "325d4c00-b747-424e-ab53-9b3c63d6f561", null, "Gilbert", null, "Gibson", false, null, "Gilbert71", "AQAAAAEAACcQAAAAEIGdZRV1XpI7/adn0osipUW6xt1p3ASLUVfWEfmsaIr3XomnG9egj7tMm3Sz+pi7jA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54"), 0, true, new DateTime(1925, 5, 19, 8, 1, 41, 479, DateTimeKind.Local).AddTicks(7024), 919.9271426497120000m, "3ba89861-ae83-44a8-a892-862809092fe2", null, "Felix", null, "Hessel", false, null, "Felix.Hessel78", "AQAAAAEAACcQAAAAEF+kv01495gvnLB1wJxMXMzLWYw4Q+jAKu6OjnVApqz9XRwSLCfs6sjvKnmoc5qwRg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e"), 0, null, 530.4427140105450000m, "ef39ce67-d59b-48ca-b415-098c5514aea5", "Lindsey", "Lindsey", null, "McKenzie", false, null, "Lindsey_McKenzie61", "AQAAAAEAACcQAAAAEJ97HaudED1efvrcTZlQ+ytwwwEtcE6KkrCT55OoEAzNbyruKhuUsHA8AzLzS6msqA==", null, "NotSelected", false },
                    { new Guid("971421dc-8faf-49dd-9b88-ce6998be2699"), 0, new DateTime(2003, 11, 4, 20, 47, 31, 193, DateTimeKind.Local).AddTicks(6623), 25.4544527611850000m, "de58f75a-fbce-4694-bea8-c2b447daeb51", null, "Orlando", null, "Parisian", false, null, "Orlando37", "AQAAAAEAACcQAAAAECozU9mpHI8/l1ku+0K4RKlIZ7I2dlWKzIufly9TdHpyZM0hL30KGZDsKQmhg4yWcA==", null, "NotSelected", false },
                    { new Guid("973d13f2-9619-4004-9439-5abc562bad41"), 0, new DateTime(1962, 10, 28, 15, 43, 22, 925, DateTimeKind.Local).AddTicks(6314), 645.728476036250000m, "22f9f3aa-e606-4a70-b561-8a34423b768f", null, "Tracy", null, "Bosco", false, null, "Tracy_Bosco37", "AQAAAAEAACcQAAAAEFkmtYZYtyF/HHL7VHz+GVGB7sffFO0p+rMH2KOP6vUQUTWGiK9vFv0SPOCGIlQZhA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("988291f5-f421-4687-aafa-58e64481070f"), 0, true, null, 946.1330552513890000m, "b8f182ee-d3ce-4b2c-ba05-b20f64bf35b1", null, "Eleanor", null, "Bergstrom", false, null, "Eleanor.Bergstrom41", "AQAAAAEAACcQAAAAEO+psZYL49mVLD2gBYNTAKb09fAqyKAZ1L90CdTtqFZ/bJoSR75pSqTgXoFL8ma5Iw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), 0, new DateTime(2002, 4, 8, 6, 13, 13, 215, DateTimeKind.Local).AddTicks(4098), 13.46099644101230000m, "2522ae62-284c-4df1-9078-ebe14906ded7", null, "Hannah", null, "Rolfson", false, null, "Hannah70", "AQAAAAEAACcQAAAAEOEY/xmmJ06zNrMLfggPvCZHpx026sGzaGQ6aZX5MGoOtsWEnem87kebmlskzD5FTA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2"), 0, true, new DateTime(1932, 2, 15, 4, 27, 18, 436, DateTimeKind.Local).AddTicks(9316), 651.5572698928850000m, "fbbd15fc-dba3-4868-b485-3d110c4a1618", "Mary", "Mary", null, "Gibson", false, null, "Mary6", "AQAAAAEAACcQAAAAEKhqJIDJ6Ap17jXVFBIw4OFT1SPWlMO5SArZOIX1MyHQY+PROKYjXTahKslRy0IJTQ==", null, "NotSelected", false },
                    { new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d"), 0, true, new DateTime(1954, 6, 4, 4, 0, 38, 711, DateTimeKind.Local).AddTicks(1097), 547.458961360310000m, "ade856d2-4a6a-44b7-b45a-d310d0a56432", "Elmer", "Elmer", null, "Goyette", false, null, "Elmer_Goyette14", "AQAAAAEAACcQAAAAEIbQxvYVpog9wODJzSgMb6sii88sZwDiTsboIp1sRwyKHiWrPond/UDAZlgLQkHWwQ==", null, "NotSelected", false },
                    { new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c"), 0, true, new DateTime(2005, 2, 14, 15, 47, 7, 784, DateTimeKind.Local).AddTicks(241), 232.0132839900640000m, "04b9a952-508b-4d96-99ee-bf476a82fe3e", "Raul", "Raul", null, "Beahan", false, null, "Raul_Beahan30", "AQAAAAEAACcQAAAAEGrBA1DPP7yANzQVoyAPj08dZmpfGCWKxA1jWGSyXPLXXEesELOV1ZuZuE+FzeN+7A==", null, "NotSelected", false },
                    { new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4"), 0, true, new DateTime(1938, 2, 25, 23, 41, 17, 844, DateTimeKind.Local).AddTicks(8178), 404.8627151853140000m, "364a2443-ca64-4543-88a0-60292babb888", null, "Pearl", null, "McDermott", false, null, "Pearl1", "AQAAAAEAACcQAAAAEBLuMTY4UB1kmjjniup2v2wiLlUIihHBKr42oNCiTXd8DjOBlOOm36P8IJ0r3Tcu2A==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), 0, true, null, 858.2066359600390000m, "07f6e377-e250-48f6-80e0-9b4b82c8c806", null, "Salvatore", null, "Hoeger", false, null, "Salvatore.Hoeger", "AQAAAAEAACcQAAAAEF9BojiWVEl8ARBpAGB2ZHFfLVWDqYSWRRYnsfHmG0i1wN+DerFJ7h6aPM4A3g1wmA==", null, false },
                    { new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a"), 0, true, new DateTime(1987, 2, 4, 23, 42, 37, 336, DateTimeKind.Local).AddTicks(8537), 76.93189302387050000m, "0da30caa-b8f5-476b-af5c-068bb4589094", "Ernest", "Ernest", null, "Huel", false, null, "Ernest.Huel", "AQAAAAEAACcQAAAAEP5sVAh7aMhLl6DEoVDQfN30J4zjYLMkFqPbDz5JospufMR0kN7DqjNf+p7BmnlVRQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430"), 0, true, new DateTime(1925, 4, 26, 8, 7, 52, 584, DateTimeKind.Local).AddTicks(2875), 458.2854628174510000m, "0dd0ecaa-f11d-4e3f-aafb-5944cfdd601f", null, "Cynthia", null, "Hoeger", false, null, "Cynthia_Hoeger76", "AQAAAAEAACcQAAAAELz15k41/A56tHjl5i5JWu/sBVrD0nJt1V1FsYZ0b/50m2m/v6S8aqhHlTk///OU7g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a"), 0, null, 987.2695329793310000m, "6cb2ab7c-0da3-43fa-a7f7-ff5ff3e5b52d", null, "Marcos", null, "Wuckert", false, null, "Marcos_Wuckert60", "AQAAAAEAACcQAAAAEIuL9zYaR6wI/tTR3pCtQBOUfH/ZOmjitWTkJYtt77Nluuqey50t002qzbtGozaAxg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295"), 0, true, null, 712.0732444722650000m, "f9500027-3b5d-4f4c-801b-8cd88fc1da4f", "Sandra", "Sandra", null, "Auer", false, null, "Sandra.Auer", "AQAAAAEAACcQAAAAEBf+P1M7jwO1XVSKD6dWNwKjBSXUZVXbEtZudUz3HcB0jonGCdAd5QRNgGoe9KK4dg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9"), 0, new DateTime(1953, 1, 27, 5, 27, 40, 272, DateTimeKind.Local).AddTicks(7939), 998.4425636323440000m, "fa92a8db-6646-4776-ad64-92ce64b790f5", null, "Hilda", null, "Grady", false, null, "Hilda26", "AQAAAAEAACcQAAAAECOUnUt4Y+CY1M/HxxUdBBhH3dCVnOlG6ND+B3OzhKZIQilI5ca9V9bu0sGB1W/e3A==", null, "NotSelected", false },
                    { new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a"), 0, null, 628.7490152396740000m, "4a36f5d4-d3f5-49d0-aa94-4e024dae2405", "Raquel", "Raquel", null, "Cormier", false, null, "Raquel_Cormier10", "AQAAAAEAACcQAAAAEEJMYoLOw/HDZIj27ElJQt8pYFYJw2HV7hbVWpgqhAmx7jzXn0BL6ie/lCYjV3p3Ig==", null, "NotSelected", false },
                    { new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7"), 0, new DateTime(1971, 3, 24, 3, 50, 53, 137, DateTimeKind.Local).AddTicks(9564), 556.7619191544080000m, "5efd3570-6de1-4acc-af68-e7f9ccf84069", "Mamie", "Mamie", null, "Crist", false, null, "Mamie.Crist4", "AQAAAAEAACcQAAAAEPzV8uPlfxvpueqNeFPfjui6SXcDlNwuGCrGcGaUDMBrNSARmmiQ6pGf4F4VlAzMNA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea"), 0, true, new DateTime(1947, 5, 25, 1, 49, 35, 922, DateTimeKind.Local).AddTicks(5764), 277.0299803188540000m, "0c633f3c-f2a3-429f-98fa-0eb5b7a02d68", null, "Cristina", null, "Kohler", false, null, "Cristina98", "AQAAAAEAACcQAAAAEDtHVUsEg81Ti9kXVIOs7u7U6cbl94kDVR9YOweYN/YgHxVSsammxhJInX8zQPeMJQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7"), 0, true, null, 595.2103992086380000m, "6f8f92ec-b5bd-46cb-be81-0745973a66a2", null, "Abel", null, "Carroll", false, null, "Abel.Carroll25", "AQAAAAEAACcQAAAAEBlzju4z+sFO0luHt9yxvTrjIVyTAMe2dJ1WSYc56jmDJkCxB5jbPjbSRh1/6F7o/w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c"), 0, true, new DateTime(1937, 7, 14, 12, 22, 20, 889, DateTimeKind.Local).AddTicks(4815), 143.7429348632780000m, "e329a481-cea9-48e8-9b8e-a187bab90a1e", "Trevor", "Trevor", null, "Kshlerin", false, null, "Trevor0", "AQAAAAEAACcQAAAAEBZWJ4rA2u/Dtg648FJB/ryQZSdV19cd0gYLlHZoiD5LDn9LO1sWdLxbSXlTQI5ywg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0"), 0, null, 56.19987713648280000m, "a9a09cb7-4fc1-4e69-bee5-894edba67b2e", "Willard", "Willard", null, "Donnelly", false, null, "Willard19", "AQAAAAEAACcQAAAAEHSE5OTKUa7et+Pan/NGk7lMUsljI8EXYHRyVUK47r6A4fjIag+RSYHU3vFdzUN+vA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb"), 0, true, new DateTime(1947, 5, 11, 21, 4, 4, 176, DateTimeKind.Local).AddTicks(5602), 540.400999795650000m, "b445cb66-003c-4fc8-852a-82a87ce4ad7b", null, "Mona", null, "Lesch", false, null, "Mona_Lesch", "AQAAAAEAACcQAAAAEDmdSmRCG4mJn/jOPU4WiRdyhFgaVKqJDqJiuLdKF3A9XH+Fq+22XR2K1KgXVgVigw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a53f5353-b991-4cad-908a-6761b66bec5f"), 0, null, 767.8846669604720000m, "3ac79324-6f6b-4d86-97d7-a614457c3232", null, "Theodore", null, "McGlynn", false, null, "Theodore82", "AQAAAAEAACcQAAAAEPWF6CG/8Pk1Mr8OZnm3LKrCJ2ySMrje6gekgeyOZO59GoYGH1fmIyUWAq0TX8+ptQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a548d594-0e72-40b8-a222-3504b474972b"), 0, true, null, 345.2564437996430000m, "b692bc3e-a75a-4c8f-8710-74d2f23e0db1", null, "Homer", null, "Goyette", false, null, "Homer_Goyette85", "AQAAAAEAACcQAAAAEHPNEetotmoNHFbaeqoNQXfGgf3KwvDa+Ko0EjYfVbRrxhFSE2xUYkQyBzk8qybWJw==", null, false },
                    { new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446"), 0, true, new DateTime(1934, 1, 24, 10, 35, 1, 474, DateTimeKind.Local).AddTicks(1749), 771.3319278010140000m, "d4e6ba3a-8814-4a91-ab19-43b98753ce3a", "Larry", "Larry", null, "Parker", false, null, "Larry_Parker", "AQAAAAEAACcQAAAAEA56Sd/rh5MRV8dMYEK5V6uabUqMXVQlvMm3Tl3MDK9HNii/2U8U6/9T5x65tR4+JQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43"), 0, true, null, 287.3259884532980000m, "01b96592-d55e-4f4b-a822-cd4deaf47fd4", null, "Michael", null, "Gaylord", false, null, "Michael48", "AQAAAAEAACcQAAAAEEv9S6z41HagvqS9e7O9I4qeFnFmW6I2LEJPtvGMKcRpbdz8SKCfhOIIa3Ac87NWAg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e"), 0, true, null, 228.3630777495090000m, "0894dbf2-1f0d-4a69-823a-e87f1fa6fff5", null, "Sophie", null, "Walsh", false, null, "Sophie.Walsh33", "AQAAAAEAACcQAAAAEHy43IdDH8ppnpRs+4MJEl0Y08LO73T/LTbPiFunXNekiNhoJjTB8jIVN+X2azwvOg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a9259e4b-5b4f-4608-968c-07272216574a"), 0, new DateTime(1993, 2, 21, 9, 5, 2, 493, DateTimeKind.Local).AddTicks(3486), 617.4098515433910000m, "9691e051-9dad-4616-ad43-898f38eaeed1", null, "Ben", null, "Konopelski", false, null, "Ben94", "AQAAAAEAACcQAAAAEOXaKuVdeMJLbX1x744ANhYBOCZWOqU91YtsMhxCiANTXIdQl/o0UwgB3jF02k/NcA==", null, "Female", false },
                    { new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66"), 0, new DateTime(2000, 12, 9, 4, 23, 58, 359, DateTimeKind.Local).AddTicks(3872), 862.9480713815640000m, "8c572b33-8cd1-456f-8b3a-1ab60a67bba4", null, "Carl", null, "Lynch", false, null, "Carl39", "AQAAAAEAACcQAAAAEOMDaOJnDk137N8TNI2nBGmvpjsXyuDGp8ajNdp76VQljSBeW8zeOxHMCb0pAsOnjg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6"), 0, true, null, 127.800639829070000m, "f4335461-679f-4ab5-b10f-0101e85e4bcf", "Lionel", "Lionel", null, "Cassin", false, null, "Lionel_Cassin", "AQAAAAEAACcQAAAAEMsevqxKm7Q4O9A8jIVgfT8ZwdmQIEuAJx6RSG5G5so6BlwcLgIb4DnvGOnsYoz9WA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("aa9f962d-9138-47ea-a506-253355f2eff9"), 0, true, new DateTime(1929, 9, 26, 9, 18, 57, 755, DateTimeKind.Local).AddTicks(4946), 397.7133269985840000m, "40efe6b1-17ee-4f2e-aad1-a1715396df18", "Jordan", "Jordan", null, "Oberbrunner", false, null, "Jordan.Oberbrunner", "AQAAAAEAACcQAAAAENApzkXdD3LO5boQvNOFCCAKE0zr2Q+9DpcDt5ZFpcxqlr2/ASm8hvpaQ7U/3HpwTw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b"), 0, null, 524.7820445328420000m, "155e5a73-511a-4591-8999-9c4951376fa8", null, "Leonard", null, "Schmitt", false, null, "Leonard.Schmitt", "AQAAAAEAACcQAAAAEKVpxhs7TLfpZakDkpW+CtvqyC61IZmcQnpvGRj0SWQCurY37DxZdIBWWftMwoXGKQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd"), 0, true, new DateTime(1946, 6, 26, 4, 17, 36, 944, DateTimeKind.Local).AddTicks(1104), 679.2734646111070000m, "e66f0e7d-cb88-433a-a883-1c750d32065b", "Sylvia", "Sylvia", null, "Ruecker", false, null, "Sylvia.Ruecker", "AQAAAAEAACcQAAAAEOAEq5iJoN61pEnPK9upBY27ZGauw4CXfTGfshuo1nMoRKmaPQaJ8mULJYZfx6PBdg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85"), 0, null, 598.6192333947840000m, "f2706add-35a4-49bf-8467-b05fc4f0e50d", "Kerry", "Kerry", null, "Corwin", false, null, "Kerry_Corwin", "AQAAAAEAACcQAAAAELnOeo2bMSN4yZd0X2EvxlZxP+twPRvAZhOz5ImUHHAV1Lze998UF42cD690DoVlnA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3"), 0, true, null, 829.8516328812640000m, "f688a50f-6b07-4d5d-bc00-e3f9998b56bc", null, "Keith", null, "Hirthe", false, null, "Keith_Hirthe14", "AQAAAAEAACcQAAAAEDeGfHCuYLyVVoCS8Jgj4BljD4fd1/ZivB0rmP8oqkFuIFG1xMb6dB2iovn9hyBLXQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08"), 0, new DateTime(1945, 9, 6, 6, 33, 6, 314, DateTimeKind.Local).AddTicks(4676), 439.2572222380370000m, "84025936-c6c8-4544-ad1c-014aea672257", null, "Vincent", null, "Miller", false, null, "Vincent.Miller68", "AQAAAAEAACcQAAAAEJFMVQBkz29sfxebsx+M6lANVDseuDNAon1o4YUJcQWlrwdaYXHJrr//7Kou4/gsVQ==", null, "NotSelected", false },
                    { new Guid("b34e9d23-9b12-49b3-b069-734a50918afc"), 0, null, 242.7726373015730000m, "670638ed-15db-4424-9bd8-52eb96aaea85", "Gwen", "Gwen", null, "Ritchie", false, null, "Gwen_Ritchie", "AQAAAAEAACcQAAAAELT0n1UtsNUihPeMAOf2ASR8q6xcu6RNeQzcHrMh4W/cfcFNpAfYsegzNqG3dxrZpg==", null, "Female", false },
                    { new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c"), 0, null, 903.4283076815220000m, "96a85d07-1e91-489f-95cc-1d5db5d7a738", "Johanna", "Johanna", null, "Stiedemann", false, null, "Johanna.Stiedemann26", "AQAAAAEAACcQAAAAEAH26ok5ErYFJhQ5d6onfaN8WTJItn2S2GtZaE7FjIJ4kd1DMjRfMCZp9o9oeSgpDQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2"), 0, true, new DateTime(1951, 3, 20, 2, 56, 1, 906, DateTimeKind.Local).AddTicks(4149), 853.0759487192890000m, "e172d438-6711-408b-80ce-3b38a93e51ed", null, "Lindsey", null, "Spinka", false, null, "Lindsey81", "AQAAAAEAACcQAAAAEFX3vSS9dSSC90onp6rb4qoSjTbSfbZi6Axd//MyWBUKdqF3CGVOI3YZPkHCsNKwWQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b5652445-32c0-44e8-b366-391041e6d37d"), 0, new DateTime(1952, 5, 9, 3, 15, 51, 473, DateTimeKind.Local).AddTicks(9965), 881.3159787352320000m, "bba57964-330b-480e-9293-e97d5788caa6", null, "Lowell", null, "Mraz", false, null, "Lowell20", "AQAAAAEAACcQAAAAEJqzXzsQXmAe3npSAHWlennWEsD8bBanEYEOAS3BC93hZXLm5J++28CpedKBwgzE6w==", null, "Female", false },
                    { new Guid("b61b0669-9383-4f00-947e-75db5b8c7915"), 0, null, 520.1867045569720000m, "92d1e007-208a-463e-b54a-00e47d995b3b", null, "Derek", null, "Mitchell", false, null, "Derek_Mitchell", "AQAAAAEAACcQAAAAELloF9NxEQtWTAAUZEsg/1/4Kw8SEqNrKr/MX1CAWfI7OkG2bQBaWl5w1Rs7CFqE6g==", null, "Female", false },
                    { new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10"), 0, new DateTime(2001, 2, 9, 20, 2, 46, 541, DateTimeKind.Local).AddTicks(5665), 536.6437440102660000m, "9c1f8ff6-e2e8-4013-a0d5-0a52e5ebd469", "Tara", "Tara", null, "Bayer", false, null, "Tara.Bayer32", "AQAAAAEAACcQAAAAENdOL/qTny/LPHd4D5zyZQj0oHeaPB0/KPE9ABWffY9ZzQCRfNwGrOw2KwA6C3PJWQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2"), 0, true, null, 319.9537282145890000m, "79f9c429-9744-43d5-aea3-3e11a077c63c", null, "Vanessa", null, "Huel", false, null, "Vanessa54", "AQAAAAEAACcQAAAAEFkKo3hjdSSRDT++AXrzeJrhU0YDUMlO3lDIxHGWrGLGcD/+8IzRIP/oXbQb9rqSpQ==", null, "NotSelected", false },
                    { new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337"), 0, true, new DateTime(1996, 3, 16, 3, 14, 24, 825, DateTimeKind.Local).AddTicks(1618), 569.1614802774350000m, "d02814f3-13c8-4ed5-a607-7aa61d5fb76b", "Emanuel", "Emanuel", null, "Blanda", false, null, "Emanuel3", "AQAAAAEAACcQAAAAEHcYsOfAbD+8PU4jdC2dkvnackuSDNWBCehaLwMY34gZZvPwfewPubWQH7QRxRe1xA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413"), 0, new DateTime(1971, 3, 24, 16, 54, 54, 527, DateTimeKind.Local).AddTicks(8558), 758.5985502534910000m, "010a10ee-9ab6-4fb3-b5ce-d7f60abfcbe0", null, "Ed", null, "Daniel", false, null, "Ed.Daniel63", "AQAAAAEAACcQAAAAEP3ALg9RWzeVBZwXqeUN/Z5MRd4kK2hYQQFqi5YBLWKiyoQaND7g6osk2Dk2kK+hQQ==", null, "Female", false },
                    { new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e"), 0, new DateTime(1953, 1, 1, 22, 42, 11, 510, DateTimeKind.Local).AddTicks(8322), 839.6698310191530000m, "54ac9d19-6fbc-4af9-a7df-0789f3babde4", null, "Edna", null, "Nicolas", false, null, "Edna.Nicolas", "AQAAAAEAACcQAAAAELAG2SoqxY+j7dnLGss5zBkY35AWqrXPKQyvjj/YnlYwqOPs/6pTgKGmqIab8Yp1OQ==", null, "NotSelected", false },
                    { new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100"), 0, new DateTime(1934, 10, 16, 19, 26, 21, 517, DateTimeKind.Local).AddTicks(7625), 457.7338209021720000m, "72287649-0bc2-474e-a164-46914e0ba465", "Al", "Al", null, "Botsford", false, null, "Al.Botsford73", "AQAAAAEAACcQAAAAELpMsLf7H8STKotIYCQv5f/uCaMWT7yLopVEq73lvtpEeFy/C5Wk2Ccgm9DdDPCB+w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae"), 0, true, null, 639.2899469818060000m, "7efb07d5-5f68-4b09-83a1-13fa99e0fb87", null, "Sandy", null, "Bins", false, null, "Sandy_Bins68", "AQAAAAEAACcQAAAAEI9Xpxk2NUvZqCVFZWbnqGgsGxQlgU1/Maq51z9OQydB9wQh0kbm42BtIqPFMFRPtA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce"), 0, new DateTime(1941, 10, 10, 11, 15, 51, 188, DateTimeKind.Local).AddTicks(4915), 758.7040391217880000m, "20960b7c-f30d-45f4-9bb8-e6d86372343a", null, "Yolanda", null, "Maggio", false, null, "Yolanda89", "AQAAAAEAACcQAAAAEIlKFiqINEru/D70bNlyFpd6la3INWKpxKels781cqGEGOpcZjagFyLu6v4Hxa7Sgw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7"), 0, true, new DateTime(1988, 8, 6, 16, 23, 35, 824, DateTimeKind.Local).AddTicks(3227), 177.3581280266510000m, "e06fcc71-c122-432f-a4e8-aced848fbadf", "Vera", "Vera", null, "McKenzie", false, null, "Vera.McKenzie", "AQAAAAEAACcQAAAAEKmQNYm6/bxKJZFq19QffzuxpSVWB3+5DrKdsu9CErWLd1Tqgu9HFVWrrRF2/dHw8w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646"), 0, true, new DateTime(1929, 3, 22, 22, 10, 26, 684, DateTimeKind.Local).AddTicks(6228), 577.2356231226870000m, "29124a1a-5bda-4ae2-8215-978a87fe68a3", null, "Shannon", null, "Marks", false, null, "Shannon16", "AQAAAAEAACcQAAAAEGYqRLK7sBk+mJNoBGzbo8hT/FQF+SmO9+pExvMHBWkueFYMKmtwidljU05O8WlVVg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57"), 0, new DateTime(1947, 12, 30, 11, 47, 22, 454, DateTimeKind.Local).AddTicks(5093), 27.86679518871950000m, "a46be4bb-3184-4eae-8d39-66e8d9e6b75e", null, "Fred", null, "Nikolaus", false, null, "Fred92", "AQAAAAEAACcQAAAAEDcvS7mjEHn2t+QpmQs/b38YjsHOL0SCCTFFjqE6dXm3mRclUFFlqXwZBAO2kAg0cA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97"), 0, true, new DateTime(1952, 1, 23, 13, 47, 32, 917, DateTimeKind.Local).AddTicks(8512), 89.24373051108670000m, "6143af58-2f1b-4636-80c6-4df8f18c17b6", null, "Clarence", null, "Wisozk", false, null, "Clarence.Wisozk", "AQAAAAEAACcQAAAAEC11deeARzRclBJNG+oJ2mecjjwIs6iXNEyddFe+yVsyLF8pjy3V7k2tj5HkxzQLEw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0"), 0, null, 355.0573312570510000m, "ce91e046-166a-442c-8d32-83364a5a0312", "Jorge", "Jorge", null, "Barton", false, null, "Jorge.Barton", "AQAAAAEAACcQAAAAEH+SKMFfm445Sgyk33ELJsyRaDF7Mfdpg/VhLe/RQc/gK5Tjv5522Jv75kojo96ZiQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6"), 0, null, 911.9783720558180000m, "49529dba-b15e-4590-ba56-b41672dcd699", "Cindy", "Cindy", null, "Strosin", false, null, "Cindy57", "AQAAAAEAACcQAAAAEFcF764XV9qLdlmOKFcCu/JALP5lz3xujIz7Z+PIjOUYjoGYjdyfoOds8+D7cr44og==", null, false },
                    { new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd"), 0, null, 452.9399217281420000m, "95cfcee5-80cb-45ef-a6be-5114343e114e", null, "Miriam", null, "Boehm", false, null, "Miriam_Boehm41", "AQAAAAEAACcQAAAAEPtSoTC5U4Hs3JjnvVBPPgma8enhiB2khopgInm0031DLnspqskujCiSWNaX3kWu4Q==", null, false },
                    { new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919"), 0, null, 689.8191089575470000m, "201a1b79-6391-4e21-bd55-82b29430ad43", null, "Carlos", null, "Champlin", false, null, "Carlos.Champlin", "AQAAAAEAACcQAAAAEBsegHjQ9P1EfiN5Kj6Z6fKkspqX7THX16ecNNsGtPXjh0Zz741yU3kI68E8/1e6gw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12"), 0, new DateTime(1967, 3, 26, 15, 5, 54, 91, DateTimeKind.Local).AddTicks(8475), 645.4736356704430000m, "8ccf3fd2-0344-489a-9a14-5d48d674bfd0", "Sheldon", "Sheldon", null, "Lynch", false, null, "Sheldon75", "AQAAAAEAACcQAAAAEIsT+IcceXgBLuEBrxoirw11rlJLAKsCOx4oJl6r45Uko/OjHQjEku+tHP91tTkHmA==", null, "NotSelected", false },
                    { new Guid("c12506d4-2612-4a16-a14f-cd9163860d65"), 0, null, 73.80675872439310000m, "69a3c262-fdd3-41b2-b190-4a881dbdc891", null, "Cynthia", null, "Oberbrunner", false, null, "Cynthia35", "AQAAAAEAACcQAAAAEDi6KOtwAinZ4x2PuclOInK0aSW8cB1Qow/dcT8WV8oeHbfD1tQ6AEg3l1O6zrAwHw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c"), 0, true, null, 144.2044413883610000m, "3da5c550-08f6-4199-9d07-249d9b688e02", "Eunice", "Eunice", null, "Cassin", false, null, "Eunice38", "AQAAAAEAACcQAAAAEGbcRfABK7AA7blU+oo72a0HAiveEQ5ZluUypBArkaiZkN6C3lCjYeEtb5hy5BEipw==", null, false },
                    { new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a"), 0, true, new DateTime(1928, 9, 28, 21, 2, 12, 250, DateTimeKind.Local).AddTicks(255), 680.4676208588340000m, "62875825-d7c3-42bc-bdc3-101a25daf590", null, "Ada", null, "Konopelski", false, null, "Ada_Konopelski", "AQAAAAEAACcQAAAAENNM7dJQjf0oV2LV4S8/ejlzAYDqS1oD6tv9ZA6elScmGUvPRk1A2AN3egaSjlLfow==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299"), 0, true, new DateTime(1995, 9, 14, 12, 54, 44, 974, DateTimeKind.Local).AddTicks(5435), 245.6990755335150000m, "249caace-aedc-4380-9238-99edda092f7f", "Gerardo", "Gerardo", null, "Satterfield", false, null, "Gerardo.Satterfield", "AQAAAAEAACcQAAAAEHNW8hgCPVRJHBEWmoNvu+lJi3wIadAgWLqoH9eDbnPJgoZHWTwURC09Lmn67eoHFQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8"), 0, null, 899.7556714639180000m, "22681c87-49b4-4c32-9b4b-9829611db2a5", "Rose", "Rose", null, "O'Connell", false, null, "Rose_OConnell", "AQAAAAEAACcQAAAAEOGWi65tII19txB51ccMzqgaqOMvR3xTN+nQ5QbfYWExbcTGIe3E1KcEefoZAyWGMA==", null, "NotSelected", false },
                    { new Guid("c559b832-f4e6-4f67-9eca-337973071293"), 0, new DateTime(1993, 2, 24, 13, 40, 13, 452, DateTimeKind.Local).AddTicks(5909), 827.4334477461040000m, "4b8e947b-cc9c-4178-b706-e90782b52627", null, "Edna", null, "Reichert", false, null, "Edna_Reichert84", "AQAAAAEAACcQAAAAEAWOUnb7G88RNgJWw9tVn0/gJIAdr5eaQmfQ4w0T/y/Yj3MVcBL7wXBpa9kRqOmYTg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4"), 0, true, null, 890.0925605776420000m, "b203600c-4147-4855-a6a2-4d4b1dc138d0", "Jodi", "Jodi", null, "Lynch", false, null, "Jodi92", "AQAAAAEAACcQAAAAEJHcSHGH9+rcVjoy2RmVxUxQPv5Rmq9yVqu0W5GqqUXje2EoqVZq7LupJm2iTKdyIg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa"), 0, new DateTime(1949, 7, 19, 18, 58, 43, 479, DateTimeKind.Local).AddTicks(8215), 391.047526297160000m, "5922bf1f-0944-4894-b55f-3e2261d5a70e", null, "Bruce", null, "Hansen", false, null, "Bruce_Hansen", "AQAAAAEAACcQAAAAEJQWGNGz26amHPp5Q2EV103jy6wYvw3q5KWQHBxQDcNzmA3Q+59u0BDRxF0AbjR+bA==", null, "NotSelected", false },
                    { new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66"), 0, null, 339.7915178910080000m, "d46d0433-581f-40bf-a05b-492606d91087", null, "Essie", null, "Ankunding", false, null, "Essie_Ankunding", "AQAAAAEAACcQAAAAELh3Qoe4axJ6OAwvoodhIbFsHNpQbqOKKxcFAKeYvwBj487Hw93d66r1p5TVKeSJwQ==", null, "Female", false },
                    { new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3"), 0, new DateTime(1974, 10, 13, 14, 10, 57, 912, DateTimeKind.Local).AddTicks(8973), 607.7056985972440000m, "d46132e3-3efe-416c-8e9c-af1ae9d07bec", "Mona", "Mona", null, "Casper", false, null, "Mona.Casper", "AQAAAAEAACcQAAAAEPXWa66UHQvF2VPL1O4zWP747I0JbeR1wUkb/m9Z7Svvys9Mgyt05cUkoVWvPrOiRA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e"), 0, true, null, 70.71905368678320000m, "f7573163-65e4-4f5d-b00f-c01a5e83de24", "Dora", "Dora", null, "Armstrong", false, null, "Dora.Armstrong", "AQAAAAEAACcQAAAAEMjKRKmLeHocQ4jFh67KTNHVtgay4jrlLPfi2Pq+y6up0vrCW6L+7Moh7WWZBr8KCg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4"), 0, true, new DateTime(1986, 8, 7, 23, 30, 19, 598, DateTimeKind.Local).AddTicks(9329), 434.4687842904480000m, "132cfcb1-eb75-43c0-aaad-9b726a2cb05f", null, "Miranda", null, "Lynch", false, null, "Miranda_Lynch86", "AQAAAAEAACcQAAAAEFKA5Pvu+KN4OUtOh+r28IZ0a4GU0nImKK714IMLaYxYaSVEG8j8lDSde/DdnU40AA==", null, false },
                    { new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764"), 0, true, new DateTime(1981, 3, 3, 2, 29, 24, 558, DateTimeKind.Local).AddTicks(6015), 216.773454121190000m, "2d8b6bc1-89cf-4451-bd5b-e977b0469894", null, "Francis", null, "DuBuque", false, null, "Francis.DuBuque14", "AQAAAAEAACcQAAAAEKXnOCY107MQKStjxJL76dQEgvgVEn3bfLI7no3A06spzzSL9A8cISyCpXcEBSPbSw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b"), 0, true, new DateTime(1960, 7, 3, 3, 13, 28, 366, DateTimeKind.Local).AddTicks(6241), 906.7460754125260000m, "497c4a1c-d4a3-48bd-bb3c-7bdf363ffc4a", "Stanley", "Stanley", null, "Upton", false, null, "Stanley45", "AQAAAAEAACcQAAAAEKmcnniJ3wouJvt7ZYfsE/XdHGXWk7Wud/At8HcFaXzxT83Hc3E/wS2wOeKcJBoZIQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ced525b3-3974-42b5-93e7-ab23169f89df"), 0, null, 269.4340148288640000m, "40b4b806-c241-431e-8ac4-c6debb20471f", "Katie", "Katie", null, "Cassin", false, null, "Katie.Cassin4", "AQAAAAEAACcQAAAAEDpJkph7XxEQteoTSPNHzpqoWF9bxDA4VlhS8NXKVymo8/0GJ6E2kzH8lKYfrfxtmA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2"), 0, true, null, 148.8307140468210000m, "da1be484-1aed-4f69-ba06-e324f3ed7b18", null, "Rickey", null, "Ortiz", false, null, "Rickey_Ortiz11", "AQAAAAEAACcQAAAAEJQCd6zJADFMNkIgsNWuErrRfhGwpOjIbWVpB+ro1bKR37ypxMuBrmfanYcfEs5L3A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7"), 0, null, 768.5254245084420000m, "c4a150f3-72bc-461b-9433-970277851aaa", "Mercedes", "Mercedes", null, "Koepp", false, null, "Mercedes_Koepp", "AQAAAAEAACcQAAAAEB5uRgKIslGxcvifZ/4EYQsCqiZpJmpvSoMY/t2mGBYob7YA9vmPDCoJxLRWAz6Qsg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc"), 0, true, new DateTime(1968, 1, 26, 15, 25, 5, 900, DateTimeKind.Local).AddTicks(8004), 729.4971963092160000m, "b37717d6-9368-4706-b4ab-273a4c5f9296", null, "Francis", null, "Boyle", false, null, "Francis27", "AQAAAAEAACcQAAAAEP+Pgp8mN+5+vJwSeNk23o2Pjr38J4Xrj0jBHiB2qDZwCSrZ3HRY0JIrInCsV5Tx3A==", null, "Female", false },
                    { new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9"), 0, true, null, 113.6274595400840000m, "db1cc5b1-b6c6-49a7-8ca9-8e780604fff5", "Marguerite", "Marguerite", null, "Funk", false, null, "Marguerite12", "AQAAAAEAACcQAAAAEDCkH3lBRlCoOxKNcYQpRyO0Vj5yKPqOYRqfTYY8IK2fyGpbW3QvIlhv6t+a9Y1qAg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d6044624-c058-4b3c-9d01-47f91c93279b"), 0, null, 835.3348934922940000m, "abeffc77-84c5-4b2a-8c73-70c800ed42c1", "Pete", "Pete", null, "Bergnaum", false, null, "Pete_Bergnaum51", "AQAAAAEAACcQAAAAELU7n3lwCeFSAnXPuLPfhw+eUfxxZsTwVrAZbUSqO1XW//fTT5tXxcDrWeMoumJxxA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91"), 0, true, new DateTime(1937, 10, 4, 20, 10, 24, 385, DateTimeKind.Local).AddTicks(289), 983.2978684775560000m, "3729ed63-dc9a-4106-86d5-f66d73abed24", null, "Cameron", null, "Sipes", false, null, "Cameron_Sipes63", "AQAAAAEAACcQAAAAEMbPmlX+Imc/RrPNSglb1o2l8/TwFE5esE/7qWkrS/8fFfTL3pR5AY45J8pVwRmHfQ==", null, "NotSelected", false },
                    { new Guid("d81428a8-c640-4761-b657-cfa05c180948"), 0, true, new DateTime(1949, 5, 19, 14, 15, 22, 648, DateTimeKind.Local).AddTicks(9891), 192.2988915471160000m, "84cef261-0d31-40fe-9d37-0caa03d260e1", "Vanessa", "Vanessa", null, "Beatty", false, null, "Vanessa.Beatty", "AQAAAAEAACcQAAAAECq+UpZ4r3gSDfqkDJPLtFjm9mA1ypHgaiRSVTvcPhIhU6UsLDEQYE+HwO7inM+ttA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("db25f40f-9692-48ca-96f6-63866a9c9299"), 0, true, new DateTime(1968, 4, 5, 9, 19, 55, 409, DateTimeKind.Local).AddTicks(5209), 325.0540933344660000m, "572439dc-1258-4379-9d0f-af72c2bcc6eb", "Earl", "Earl", null, "Lockman", false, null, "Earl_Lockman24", "AQAAAAEAACcQAAAAEPSYevVJchYVFuzRtG3Cezwsyn9vBznRAlSnPtfMtnYPuVGDtwQ+gAX2/7UzcAOY8w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68"), 0, true, new DateTime(1926, 8, 13, 21, 9, 29, 362, DateTimeKind.Local).AddTicks(155), 704.0271460794080000m, "81b3a2b8-2e39-45de-a386-993652673995", "Timothy", "Timothy", null, "Rempel", false, null, "Timothy_Rempel", "AQAAAAEAACcQAAAAEK4CGiOVmtvSBGIFEd6cmzmLhg7a3/Vsw1VzM/BZIwqzmjTwa6TCKQoSIRTG+VFrDw==", null, "NotSelected", false },
                    { new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32"), 0, true, null, 241.0133004021060000m, "8d410f89-65d1-475e-8618-e47d090a3dca", "Courtney", "Courtney", null, "Cummings", false, null, "Courtney.Cummings74", "AQAAAAEAACcQAAAAEJPXEuGWgV4gSA9OiVTGOYpmyDdn5no6Sunl09gc4Xsd1U2hJnPUjwlMqzwnJ31FQQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471"), 0, null, 737.81884562530000m, "919e9d91-2b19-4b91-9487-871f14747129", "Alyssa", "Alyssa", null, "Blanda", false, null, "Alyssa_Blanda48", "AQAAAAEAACcQAAAAEFweZyXej40I3iQTTnl0kZHaLHoKfKHd1fv3j8CAg4eczdC+ENDLAzdE8osM2WFVqQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("def8845a-24de-49d2-a341-fdf28b9883be"), 0, true, new DateTime(2007, 8, 22, 22, 43, 14, 352, DateTimeKind.Local).AddTicks(3456), 326.9139168303450000m, "8ebd96ed-9bfa-48da-aa89-de5ea7e525ef", null, "Levi", null, "Aufderhar", false, null, "Levi_Aufderhar", "AQAAAAEAACcQAAAAEGp4KYFSr34QaOV9CwyXyQOSZ8S+3RVOVUmpA5d2UM2f0I5srlFYdx65JdqH+JVGOw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797"), 0, null, 593.6643456436560000m, "db209113-0470-4a43-81ae-1ed434174f0a", null, "Brent", null, "Corwin", false, null, "Brent_Corwin", "AQAAAAEAACcQAAAAELOcjIyaxDeDyVPjwqex8F4EzwvlIto+lXzD2i0IU+tuvXK4Hq67l2tp/fPpmKjHDg==", null, "Female", false },
                    { new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888"), 0, new DateTime(1994, 6, 1, 22, 46, 19, 399, DateTimeKind.Local).AddTicks(6662), 339.2811960677280000m, "bef4a59c-93f5-49c7-bd0f-88219174a12e", "Neal", "Neal", null, "Jacobson", false, null, "Neal.Jacobson", "AQAAAAEAACcQAAAAEMrWCifk1oNIYBe+yToEPD/eaEnsnaEXyVucV0pmIroKIJlkvUl51+k17jiTzK9JXg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac"), 0, true, new DateTime(1970, 10, 25, 5, 10, 38, 380, DateTimeKind.Local).AddTicks(2998), 701.1813255117170000m, "94c6aad9-17b4-4bc0-a09c-0d6c11780211", "Carroll", "Carroll", null, "DuBuque", false, null, "Carroll_DuBuque49", "AQAAAAEAACcQAAAAEDN5et8hBEMtUqcU2kym0qC3J7cPmNRN5Y6vAeiGsAvDZpyyeXjmE+Uaom9BJNvZJA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf"), 0, new DateTime(1988, 7, 22, 18, 28, 41, 271, DateTimeKind.Local).AddTicks(7119), 690.3270918406220000m, "3fa25c2f-0a9a-4b1e-b6d4-3536323e1fa5", "Jenny", "Jenny", null, "Batz", false, null, "Jenny_Batz", "AQAAAAEAACcQAAAAEORfXXyli9mcISEsiufHI3xaepfHoZWh9U7i3FI3a4hs/UO3kDarC2hNAqsjHl3pAg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), 0, true, new DateTime(1927, 1, 16, 0, 52, 53, 821, DateTimeKind.Local).AddTicks(5000), 861.6220098198420000m, "da4ae06c-040d-4138-b32a-fdd81d821ea0", null, "Courtney", null, "Beahan", false, null, "Courtney20", "AQAAAAEAACcQAAAAENCqIrPTrFqdIPhOeaSw2MXEc4So4hrCJ2wIPGj9KZCj7BgkjPy7f9/0YZMwpcVCDQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732"), 0, null, 95.52848291222420000m, "e3506573-c00c-49f8-b25d-2a0d3eb90237", null, "Percy", null, "Ondricka", false, null, "Percy.Ondricka53", "AQAAAAEAACcQAAAAEPsl+roSWY5bjRyhXGvoIAYtHH3pnxjm4CxSPqEuL6A0w1NOQG/7WvPFCXL8A2A1Xg==", null, "NotSelected", false },
                    { new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9"), 0, null, 644.87308959940000m, "e0caf21d-e48a-4e4e-a600-db15adf9a6f5", "Leonard", "Leonard", null, "Hayes", false, null, "Leonard80", "AQAAAAEAACcQAAAAEAP78ZhhAGxAsEcfhgM2QNZREymFBJsDenjFd+Hv2uI131rCnCO9T39zLFmyBgfLWw==", null, "NotSelected", false },
                    { new Guid("e532c6b4-1991-456a-82b7-b5c360a20603"), 0, null, 569.7905108144060000m, "542e6308-d594-46a7-a888-6a106e25321f", "Lana", "Lana", null, "Buckridge", false, null, "Lana_Buckridge36", "AQAAAAEAACcQAAAAEGgmKJF30kDxGOsbdFfcVFbR8ORs4JlIntl/sCIP0fzSiF2POlt2g+gTzRriwvSqaA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e6097123-c594-4bdb-870c-0cf57528e39a"), 0, null, 255.5662375692760000m, "ed9b1934-0e14-4ee6-b1fe-4af57d712879", "Alma", "Alma", null, "Moore", false, null, "Alma49", "AQAAAAEAACcQAAAAECmTx5lQfkk9pVvK1jaJTt/g0nGV3zKZsAKrvb1ZPkhaTxEXBAJDCNQZOwC+7Vgl4A==", null, false },
                    { new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46"), 0, new DateTime(2008, 6, 2, 1, 52, 7, 197, DateTimeKind.Local).AddTicks(344), 293.7076968436360000m, "12159440-97c0-455c-b5ce-ffe2a74b2f15", null, "Jo", null, "Wolff", false, null, "Jo17", "AQAAAAEAACcQAAAAECm+z6fuOqnHP+0J+dbRvY+kKEjDltHBvjqGiNBS3wDTYdcVLLXAfz93GVZlwkvOQw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e78bfe86-03b9-49d6-a310-41e75123a834"), 0, new DateTime(1925, 3, 28, 17, 6, 57, 116, DateTimeKind.Local).AddTicks(5873), 484.4130414890580000m, "4f7c4d0c-74f7-4116-86ab-f228123cb416", "Lisa", "Lisa", null, "Bradtke", false, null, "Lisa_Bradtke", "AQAAAAEAACcQAAAAEHJN6GTptOWLEv+KtHjH/fkKNHzOS1cQlyUXffxrVS6eam9dkNr2SzAlgeg/XwnlFg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df"), 0, true, null, 77.32049980619020000m, "398b15ff-9f1f-4b65-8544-da968f1b2333", "Arnold", "Arnold", null, "Littel", false, null, "Arnold88", "AQAAAAEAACcQAAAAEDhdDggRS5Tga3z321p+Ncjo1jZh4sZDm+8WtsNfX8ujN3GpTNWIG8CTrV623a8EQw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4"), 0, new DateTime(1966, 2, 16, 13, 16, 13, 307, DateTimeKind.Local).AddTicks(4706), 788.6367589143720000m, "5ee0f5bd-94ee-4257-8ded-ce87ad837f8c", "Dianna", "Dianna", null, "Halvorson", false, null, "Dianna87", "AQAAAAEAACcQAAAAEHYVa5uN2fAHXYVTAhtGCD25zNzH/Z1mdnmQN0rqJVfnwU4jMdXZIKbW1/IqThNL+A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f"), 0, true, new DateTime(1984, 9, 29, 7, 26, 7, 70, DateTimeKind.Local).AddTicks(1699), 184.3640420226820000m, "86a783b3-50f1-4b78-84c6-d4fd187abaca", null, "Lloyd", null, "Schmeler", false, null, "Lloyd14", "AQAAAAEAACcQAAAAEEXm/xi53+DTXn5BrtIb4efhxXDRozS6isDmSRz4Vw1/vPBoaQQF7d3LzgM0i9T3JA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b"), 0, true, new DateTime(1973, 5, 27, 17, 1, 20, 975, DateTimeKind.Local).AddTicks(2352), 309.545322090590000m, "8323ff9c-6e26-431e-bcdd-ef1d3ddc6df9", null, "Muriel", null, "Weber", false, null, "Muriel44", "AQAAAAEAACcQAAAAEBxYzZzxpKlsPOLdzepK1Gng9/wlcJwEox5YPA8P0NLTrlAffT7tKmIw7xp3C9l2vQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882"), 0, new DateTime(1968, 6, 19, 19, 22, 58, 414, DateTimeKind.Local).AddTicks(1605), 779.6490987556140000m, "933d6d0b-57d9-4036-b056-acd2a9178d34", null, "Don", null, "Crona", false, null, "Don.Crona", "AQAAAAEAACcQAAAAEGjIAQGgWR2ftkK3ZNA+k3/c5qVouY5+VP/NP4OCEaLrV9jrs9gDZcrhTPOZ1qahdQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f"), 0, true, new DateTime(1977, 6, 6, 11, 40, 53, 703, DateTimeKind.Local).AddTicks(3735), 627.910801595330000m, "28260275-8e9b-412c-83d8-7d065ccf9d19", null, "Joshua", null, "Reilly", false, null, "Joshua_Reilly43", "AQAAAAEAACcQAAAAEK64bft3FPYyzoI1zWO9Kvwvd8mNvYQYu+/QOgE0Md5lNgaOKDOvgH31lBZ7x5rwhA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19"), 0, new DateTime(1976, 12, 2, 20, 48, 57, 341, DateTimeKind.Local).AddTicks(6199), 365.9069823776710000m, "5da9b7f6-f77f-456f-948d-d34506a8691d", "Arturo", "Arturo", null, "Skiles", false, null, "Arturo_Skiles", "AQAAAAEAACcQAAAAEFJZ6/OQAzgJEugSLQxY/aoRcT6FQHahYJGh209+R5GaPYJYhdCHl7SzQqn3bT5B+A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092"), 0, true, null, 730.7017042554280000m, "f7720744-c19e-4b2c-8b3e-72af382b13c1", null, "Marta", null, "Romaguera", false, null, "Marta.Romaguera6", "AQAAAAEAACcQAAAAEGPbZdB/Mj7rXVkjWqfjt87dy6U4MYI3EKfREhlj0MQF+d6SpHnyq6oP7jfUFXTzPw==", null, "NotSelected", false },
                    { new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89"), 0, true, new DateTime(2003, 3, 1, 17, 50, 4, 670, DateTimeKind.Local).AddTicks(6332), 867.0480052269730000m, "ad62d9a2-adec-4802-b5ea-8700fd06a69f", null, "Wendy", null, "Fay", false, null, "Wendy.Fay", "AQAAAAEAACcQAAAAEOT5FqlcUMni6c6csbWZ4waHaTamlZ16u0sUCJgjQ9ZAz7QGW0XYiCSRfu0Lvs0Jsg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f33ed058-0d5e-4f28-8270-398f55394914"), 0, null, 983.4801735696640000m, "a321e016-a3c6-46ce-81b7-239d0769b1b1", null, "Travis", null, "Wiegand", false, null, "Travis45", "AQAAAAEAACcQAAAAEF4RHmnCTf/nyl2pxGwZZ+SigNW4i12y+Rd2XLutKo+svOelr5M3lKTqLc+qWIvfsw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5"), 0, true, null, 851.7569204023840000m, "37a1604b-84b7-436d-ab31-ca68fc0b2ec7", null, "Israel", null, "Gusikowski", false, null, "Israel_Gusikowski", "AQAAAAEAACcQAAAAEHUoU51KyW5m/0dpb2ZbG4Uig7ELgTTE42k6Qkiq+lNinXvGTH4jojELvWVxEcC8iw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f6425efe-44a9-4764-877a-c0d313b88196"), 0, new DateTime(1927, 7, 2, 0, 46, 42, 744, DateTimeKind.Local).AddTicks(9588), 936.9965154768560000m, "fe2a345f-0b3c-485f-bc29-ee3a9969d5f3", "Steven", "Steven", null, "Sauer", false, null, "Steven_Sauer", "AQAAAAEAACcQAAAAEOXqjqcQKuMHdfY0G3KRzUeZwIZJk799PBOeKLY6pYcqeWTT6put7aG8bcXDtw/0DQ==", null, "NotSelected", false },
                    { new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), 0, new DateTime(2009, 2, 10, 11, 12, 6, 999, DateTimeKind.Local).AddTicks(6338), 646.5656756630180000m, "dcdd06d0-251d-4e87-8a39-0556f4a4d820", "Clayton", "Clayton", null, "Wintheiser", false, null, "Clayton.Wintheiser70", "AQAAAAEAACcQAAAAEG/W2pBZRVR/LYWTeME+5EElgxmwHz0o1r3aHjg+iyczqXmWxLlLvupq62eRRVz5tg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f"), 0, true, new DateTime(1977, 7, 14, 18, 52, 13, 312, DateTimeKind.Local).AddTicks(9911), 487.4840130414010000m, "39a2b97e-359f-4f4f-9906-e70464de753c", null, "Wendy", null, "Willms", false, null, "Wendy62", "AQAAAAEAACcQAAAAEBZho5ZECZVM6XjCTCOuugNkMfAhNT2VMK4re4MHlEaMqTVQk1F3KmX5GRfb1d9lvQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf"), 0, new DateTime(1969, 8, 3, 5, 4, 34, 976, DateTimeKind.Local).AddTicks(2450), 209.514993673050000m, "f1c1392a-bf68-4f38-9b76-05b3274322c7", null, "Dawn", null, "Hills", false, null, "Dawn.Hills65", "AQAAAAEAACcQAAAAEPiEC/LdyAf0aCk5VW1oST72OmfOCr6gb0xPcap0hzhyt1koyI+MqGxsrynr4BWL5A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b"), 0, true, new DateTime(1987, 7, 2, 9, 27, 12, 155, DateTimeKind.Local).AddTicks(6947), 168.3703576368890000m, "b1ac52cc-86d5-485e-9d10-25806c4b6003", null, "Rosalie", null, "Schaefer", false, null, "Rosalie_Schaefer", "AQAAAAEAACcQAAAAEIWg+FaEu2gAOSJqtDscnEZRb08xZw0YTOjD9GsJrKI3TQnvjIc0fEr9RAEsmH7Oqw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f8331316-2615-4a9c-aac6-3bc582886724"), 0, true, null, 122.324819985520000m, "7d275b2c-51de-4d8f-8ffa-ba17f682a477", "Kerry", "Kerry", null, "Mohr", false, null, "Kerry37", "AQAAAAEAACcQAAAAEIRh6RLLPy1buaqagcVCVDA5HHLeJMXxfjKe2aKYqkrb6MFH9ziDo26ntjtqmXjfcw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e"), 0, null, 526.565161463370000m, "eaa32146-22ce-4465-88e7-758ad4229786", null, "Kristen", null, "Friesen", false, null, "Kristen22", "AQAAAAEAACcQAAAAEGDq9dZpRCoE9ANUB9YEKyztxm9GvNXgxh6ZrEYWuKTDAEmzPAxF+w3xtSBawjgzNA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467"), 0, new DateTime(2004, 4, 11, 23, 24, 27, 996, DateTimeKind.Local).AddTicks(3823), 665.9333765008030000m, "4a9d3e62-63b6-4264-b5d0-bd6909d020e0", "Abel", "Abel", null, "Pfannerstill", false, null, "Abel_Pfannerstill", "AQAAAAEAACcQAAAAEJSumb57Iz2tjE95UC11LV9JeQ/2XmW1lxX7YsucUCjRVHmMvFM5fDBKFbAUUz/IvQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b"), 0, new DateTime(2000, 6, 25, 21, 12, 56, 1, DateTimeKind.Local).AddTicks(275), 60.86710544545060000m, "0e7c8f25-8596-4bb0-8442-3c321d8bdfb7", "Laura", "Laura", null, "Kunze", false, null, "Laura91", "AQAAAAEAACcQAAAAEJ9NTERP94+0i9Amu0HrGMHq7hQyluJtKubBtv5zwzWy5lTkflT2mUdI/1iGEs6buA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165"), 0, true, null, 600.5051993732440000m, "668d9589-ed43-45ec-8aaa-1786cbc25a95", null, "Deborah", null, "Macejkovic", false, null, "Deborah_Macejkovic", "AQAAAAEAACcQAAAAEKXGHb4R+Mlqlj11fxUyzo3IBJxDB/DJH+50mDegmO1mgDNg2UvkzK76w+RLpPUDxQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf"), 0, new DateTime(1951, 7, 28, 0, 10, 20, 802, DateTimeKind.Local).AddTicks(5553), 247.4099255079610000m, "a912c318-7252-4c4a-969e-8698722522aa", null, "Francis", null, "Franecki", false, null, "Francis.Franecki10", "AQAAAAEAACcQAAAAELe39JIUnD50EBvf4LPGM/fWOEeIT1lJXoGOf1cISxbpRbQp8Iyn7xzMTEz+KiE9bg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0"), 0, new DateTime(2001, 11, 11, 10, 16, 33, 472, DateTimeKind.Local).AddTicks(1348), 854.007364501320000m, "91fcd9fc-5aba-400b-85e6-14fee15562dd", null, "Donnie", null, "MacGyver", false, null, "Donnie.MacGyver13", "AQAAAAEAACcQAAAAENsAlB4++25vqy4fct+dKEWjk6A+84drYy4xi1pyjEEQj6tC1TTKdZ+IUJ4NyCnfHQ==", null, "NotSelected", false },
                    { new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad"), 0, null, 107.6151263151450000m, "543d1884-03a3-42b6-89cd-6eaa61b52019", "Ruth", "Ruth", null, "Cronin", false, null, "Ruth.Cronin", "AQAAAAEAACcQAAAAEOFXQaIMYJTnbiMuX5tQMCheue+uc4KPLC/mvKctTRusW4FaQ/jQBziXGBDnr1H1dQ==", null, "Female", false },
                    { new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), 0, null, 643.3606690363020000m, "4697e25d-4ec3-4b85-8834-dbcbe6027e8f", null, "Andre", null, "Kreiger", false, null, "Andre.Kreiger", "AQAAAAEAACcQAAAAEGDdf59VXqo3GEq0I0Ypy8SNrKCcWwsHoUz5E+ZNI0xBZuBMja7jxLFB3YZsqR4oTA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f"), 0, null, 718.6451525032160000m, "1fb0679c-0b5e-48c2-ad74-9e0d22a7d94c", "Jaime", "Jaime", null, "Hagenes", false, null, "Jaime_Hagenes33", "AQAAAAEAACcQAAAAEC/4/3byxjqB4DmJ8TcJolAa/0ndU5InF8XTItscsXo/VqouWbWE7zDuXiTR5S5ytA==", null, false },
                    { new Guid("fdb536da-cede-4b09-bad0-b86702d0452e"), 0, new DateTime(1972, 11, 6, 17, 37, 20, 348, DateTimeKind.Local).AddTicks(819), 381.4160691818980000m, "c52bc94b-1edd-4d72-9e82-243c70dcb875", null, "Nettie", null, "Bogisich", false, null, "Nettie.Bogisich24", "AQAAAAEAACcQAAAAEAAG/YmXf+YDopKE/7W1/TCi/vy45CXwryD8vz03ejrv5D//OL3ZVjSnZaoP+J8zPQ==", null, false },
                    { new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8"), 0, null, 259.4472330188810000m, "3e340f1e-61f9-4ec9-9cb8-8086253a203b", "Billie", "Billie", null, "Leuschke", false, null, "Billie.Leuschke", "AQAAAAEAACcQAAAAEIq1urgD/sGWUemW1BbDohIjDOue+tBskoJ3yedpxZyDjVQ0JNP28K1JWPBpmKpPAg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("feeae310-c37b-49b5-b035-e9098493766b"), 0, new DateTime(1950, 5, 27, 19, 8, 43, 787, DateTimeKind.Local).AddTicks(2099), 500.1165228345420000m, "b99a89bd-7e19-4c56-9db7-2362a6817d5c", "Brenda", "Brenda", null, "Bruen", false, null, "Brenda.Bruen79", "AQAAAAEAACcQAAAAELBTM2i+e0fluRxVJZvz6D4AVmJHgHCGW/IgcJAOqqfKFuQ1LWRxwe+1jjEshfdz4g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ff032668-ac2d-465e-a8be-49991c69a967"), 0, true, null, 975.0419490766360000m, "4a88953d-1603-4281-a211-1414fcc4d4b2", null, "Dwight", null, "Strosin", false, null, "Dwight27", "AQAAAAEAACcQAAAAEJQmhYNR6sknBT3XlbFTITtJzJH2M/mpt5pLjwlnMDVMz+hah3Evu0Kr9nfEKE46uA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3"), 0, new DateTime(1935, 9, 27, 14, 26, 51, 622, DateTimeKind.Local).AddTicks(9312), 467.0228884428240000m, "f2b95157-5efd-41e0-9ecd-3d6cf4e7b682", "Guadalupe", "Guadalupe", null, "Sauer", false, null, "Guadalupe.Sauer", "AQAAAAEAACcQAAAAEE+wDsO7GKvYcRjKDhcNdPE8pUFbWYy17mn/M0hVpU8BCy9GtHllX+fZDsYa3S909A==", null, false });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("01030a54-97ad-477c-b85f-5b12864da2f7"), "49,80139;26,443958", "Wiegandchester, Pakistan", "Sawayn Via, 766", 150 },
                    { new Guid("03f83e97-a6db-4172-9a52-4e53c29476f3"), "49,739456;29,147959", "Traceyville, Haiti", "April Run, 110", 168 },
                    { new Guid("066d8edd-4d22-4b21-97a9-a7030acede6c"), "49,41624;30,830881", "Gersonfort, Botswana", "Windler Junctions, 5074", 111 },
                    { new Guid("09c4707c-944a-4335-9d89-735bb16f4e1e"), "49,117588;25,213364", "Jordaneshire, Jamaica", "Angelo Common, 466", 161 },
                    { new Guid("0a014bcb-33e4-480f-a8f6-3aba7a3d7046"), "49,238586;30,95604", "New Destinyberg, Guadeloupe", "Natalie Crest, 198", 80 },
                    { new Guid("0df7ca54-5954-466d-861e-e586d34a4e51"), "48,161728;28,77128", "Sadieview, Barbados", "Wehner Extension, 76148", 138 },
                    { new Guid("0f875d7b-59a6-499a-82a0-97977c3b3a99"), "48,378704;28,702147", "Port Reyesland, Australia", "Manley Alley, 62591", 136 },
                    { new Guid("0fc2fe77-61d0-4bb1-921f-5c4df1c792bf"), "49,741974;26,289736", "Hagenesfurt, Pakistan", "Littel Island, 6057", 40 },
                    { new Guid("111f7b0b-953c-4d5d-9b0d-a3b017566362"), "48,694355;26,987438", "Naderville, Solomon Islands", "Keely Spurs, 3095", 148 },
                    { new Guid("1175bdab-3950-443b-a9db-26933ab4ef62"), "49,34508;29,351995", "Port Delphiaside, New Caledonia", "Goyette Greens, 17323", 26 },
                    { new Guid("12ba01bd-19fb-4e7e-9397-f4e6ecb2e661"), "49,879513;26,14512", "New Nickmouth, Algeria", "Michel Light, 313", 7 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("1a09f14e-c9b8-4a60-bf60-261844b4e956"), "50,93786;25,982565", "Lake Ramiroshire, Northern Mariana Islands", "Erdman Landing, 603", 141 },
                    { new Guid("1f04f237-633c-4689-b50c-5e11b3465790"), "49,70541;28,231928", "East Edythshire, Zambia", "Kulas Well, 062", 160 },
                    { new Guid("1ffb4a05-fc29-441b-8ecb-244e68c7b33c"), "49,800865;23,626339", "Mylesport, Saint Barthelemy", "Hamill Oval, 940", 162 },
                    { new Guid("22b9dfe6-4581-4991-a100-1148b60b26ec"), "48,05476;27,492706", "South Eladio, Paraguay", "Rowland Glen, 002", 24 },
                    { new Guid("2b714d35-c58b-45d8-8f9f-d3d772a43d86"), "50,53482;29,143332", "Hauckside, Slovenia", "Buck Groves, 532", 141 },
                    { new Guid("2bea4cdc-c8ed-4e9c-bf00-e1f50fc4d8cb"), "50,22632;29,571339", "Robertsfort, Comoros", "Mozelle Stravenue, 3188", 5 },
                    { new Guid("2cbe84af-472b-4822-8373-c0f52cc4898c"), "48,27438;30,784637", "North Darlene, Netherlands", "Feest Stream, 9246", 78 },
                    { new Guid("2e2d35c6-0d0f-466d-85a6-d24a3471ea1f"), "50,202507;23,57478", "Lake Donnell, Senegal", "D'Amore Crescent, 5495", 138 },
                    { new Guid("31683466-daab-472f-ae5b-9a616964ae91"), "49,50809;25,489063", "O'Connerfort, Andorra", "Rosendo Fall, 606", 113 },
                    { new Guid("34e6212e-a82b-4fa3-8303-7f2738c2a9e3"), "49,43771;25,237297", "Dickinsonfurt, Guadeloupe", "Rickey Flat, 230", 161 },
                    { new Guid("3a9f057f-2be5-456d-aa5f-66b33a1e70fa"), "49,420414;30,754738", "Ziemeton, Zimbabwe", "Phyllis Alley, 5432", 97 },
                    { new Guid("3b0ca5f5-95e7-4059-a237-abbe933aa311"), "50,024517;30,601404", "Lake Agustinville, Malta", "Fay Green, 081", 51 },
                    { new Guid("3c97cdea-27b6-450b-b4b5-25280d610c4c"), "50,446888;27,86372", "Port Jacestad, Myanmar", "Moen Throughway, 6154", 75 },
                    { new Guid("3d86041d-b6ef-4af9-ab3c-b75a7b1ecdbf"), "48,179623;30,28627", "South Lucas, El Salvador", "Sandra Mews, 838", 47 },
                    { new Guid("3f14d0e3-3105-448b-a597-3837a66bcdb9"), "49,79893;25,158669", "Lake Dale, Romania", "Heaney Dam, 923", 114 },
                    { new Guid("40ba5ec7-01c4-446d-8f87-4f1fb81b6502"), "48,379093;27,984276", "West Yolandaburgh, Latvia", "Austyn Forge, 535", 42 },
                    { new Guid("4312648f-21b0-467d-a345-d901cc064e0b"), "49,819084;30,503212", "North Johathan, Equatorial Guinea", "Jakubowski Estate, 98270", 69 },
                    { new Guid("439cd9b6-f720-4de5-8267-5fe63d355d18"), "49,601337;23,721542", "New Alisahaven, Macedonia", "Mueller Lodge, 95409", 81 },
                    { new Guid("45dbd552-3523-4e02-829e-c82c7c855819"), "49,005924;23,695913", "Alishaside, Congo", "Luettgen Ports, 3314", 168 },
                    { new Guid("4adfd7ac-1e3d-4c3d-8e20-8a6d9448b85d"), "49,939804;23,536509", "Jonestown, Cuba", "Kay Knoll, 36357", 180 },
                    { new Guid("4b8f69ab-8d1b-45e9-84f7-52450827b5dc"), "49,336735;28,494177", "North Ulises, Canada", "Joey Hollow, 7820", 62 },
                    { new Guid("4b98fc66-872b-4728-ab9e-0e57028c4fb2"), "50,069084;25,378458", "Dorcasshire, Mozambique", "Jolie Centers, 97768", 119 },
                    { new Guid("4ecbd7a6-5263-4190-aee3-654383d9e6cd"), "50,29053;26,681952", "Grimesburgh, Mozambique", "Ruby Estates, 0599", 192 },
                    { new Guid("4f92ccf5-2abd-432d-b252-ac88ab9fbcfb"), "50,077374;26,704391", "South Muhammad, Norfolk Island", "Jayme Freeway, 37846", 1 },
                    { new Guid("51c8020b-66ae-46f3-b766-f9ec9314b3fa"), "49,250626;25,95929", "Troyhaven, Hungary", "Conroy Manor, 804", 49 },
                    { new Guid("5c5e5670-1624-4681-a863-54945e4be3af"), "50,25438;28,570688", "Runtechester, Samoa", "Keeling Drives, 44164", 65 },
                    { new Guid("5cb24fad-3b1c-4eda-86c2-c9fae55e5823"), "48,09334;30,112694", "Lake Eugeniaport, Italy", "Bins Valleys, 6215", 112 },
                    { new Guid("6533dc7b-722a-4175-9713-6cf5b6f3b6ea"), "48,016262;24,441895", "Port Andy, Bhutan", "Hessel River, 803", 62 },
                    { new Guid("65bcdd02-11d9-460b-a2fd-ab8fdbd4c2c0"), "50,60968;23,007616", "Tannerport, Croatia", "Green Spurs, 262", 119 },
                    { new Guid("66a6fcd1-0b55-4c0c-add3-45b5ca07f7ed"), "49,059265;29,410315", "Caitlynborough, Seychelles", "Johnson Courts, 87804", 191 },
                    { new Guid("6ad6ebca-c926-427f-92f0-06446f57182c"), "50,145687;26,531075", "Harrymouth, Bosnia and Herzegovina", "Wiegand Avenue, 85028", 164 },
                    { new Guid("6c847db9-aa4a-44fa-bc5f-9c3c2d372572"), "50,63017;24,381943", "New Grace, Zambia", "Kaci Streets, 7893", 85 },
                    { new Guid("6c8ea1fd-3689-470f-985a-a2e9894f30c5"), "48,079227;23,453642", "Nathanielstad, Bangladesh", "Runolfsson Ramp, 4653", 186 },
                    { new Guid("6dc2c39b-8af6-436a-a975-d4052c747f71"), "48,648495;29,128462", "Brandynmouth, Norway", "Zulauf Forges, 14144", 89 },
                    { new Guid("6e7a343a-335c-449b-b22d-21d05848e3aa"), "49,06974;26,772243", "Lake Faustino, Saint Martin", "Judd Unions, 11595", 62 },
                    { new Guid("6ea23db5-dc56-4bd5-9726-5b40e4923bd1"), "50,504604;25,438667", "Cartwrightborough, Israel", "Keira Hills, 58921", 81 },
                    { new Guid("6ea499bf-7276-4d14-8c1b-3c16830b2800"), "49,039944;30,02528", "Kipland, Taiwan", "Fiona Flats, 549", 13 },
                    { new Guid("6f29431f-693c-44eb-afc4-1710a5320fd5"), "50,339;23,644005", "South Claudiemouth, Sri Lanka", "Casper Prairie, 151", 130 },
                    { new Guid("7114d9a2-1c07-43c4-9c0f-0e2db60b0f4d"), "50,735214;30,808016", "Reillymouth, Ghana", "Hammes Trail, 123", 32 },
                    { new Guid("72c5195c-7945-4195-9254-6cbb7f80f5ef"), "48,73312;29,142042", "Lake Emmitt, Guinea", "Lewis Flat, 8375", 80 },
                    { new Guid("72e2f75d-37a1-4263-a5ce-d97b48800ebb"), "49,69038;29,479883", "Madysonfurt, Martinique", "Daniel Villages, 15558", 8 },
                    { new Guid("7395dd2f-645f-48a5-b4b8-b1cd86183d23"), "48,89905;30,920918", "Abdullahmouth, Central African Republic", "Jovani Views, 1785", 117 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("751d207d-d434-47a9-8a29-4fef772e7236"), "49,893444;24,351357", "Bruenport, Slovenia", "Farrell Ferry, 7993", 116 },
                    { new Guid("793a1ab3-1201-4a35-ba30-684a43317544"), "48,85302;29,63965", "Kubchester, Solomon Islands", "Dare Meadow, 749", 11 },
                    { new Guid("7afb0012-5c36-49e3-a6a7-53ded66f3b6b"), "49,992462;26,898739", "South Mazieberg, Peru", "Jacquelyn Cliffs, 940", 86 },
                    { new Guid("7b1da58f-5b4f-451a-914b-8317a075bdad"), "48,591946;26,537954", "South Chadd, Ecuador", "Donavon Keys, 47091", 115 },
                    { new Guid("8770ce06-de74-4097-9998-a2e401273d73"), "48,087658;27,937384", "North Gretchenmouth, Senegal", "Skiles Keys, 79132", 85 },
                    { new Guid("892deffb-a08b-4f2e-b9f5-b0a64cfd4003"), "48,255993;26,584114", "Reichertfurt, Ghana", "Shields Avenue, 53343", 112 },
                    { new Guid("8b039e5d-4946-45ff-ad85-2f2fe0893a78"), "50,75207;23,092253", "North Clementineville, Monaco", "Vandervort Mills, 834", 26 },
                    { new Guid("90af0f08-d4ea-4ba7-8237-4f92be2f98e1"), "50,82034;25,581469", "New Mathilde, Norway", "John Valley, 6833", 58 },
                    { new Guid("92030ccc-5180-414c-aae8-18992a0abf66"), "50,670963;26,333294", "New Jonasland, Taiwan", "Cynthia Stravenue, 091", 102 },
                    { new Guid("a05cc3ab-789a-46c5-ad98-8ca116b10601"), "48,831287;30,588877", "New Sierra, Uzbekistan", "Casper Alley, 67519", 18 },
                    { new Guid("a4470e7c-e816-4bf9-b771-1dfb4a4fc96f"), "49,32384;23,252653", "West Hillary, Wallis and Futuna", "Bernita Mill, 755", 153 },
                    { new Guid("a4fdc62c-3b6b-4ea1-b171-7f529a27fad3"), "49,988884;24,49771", "Smithville, Sudan", "Grimes Ways, 54800", 33 },
                    { new Guid("a5ac15d8-0f8e-4971-ab28-881048b5dd3f"), "50,176086;25,47416", "East Ralphside, Macao", "Eden Alley, 2653", 164 },
                    { new Guid("a64e2725-ce35-45c9-92ed-92e8ac77d2f2"), "50,719193;24,23221", "East Jessica, Indonesia", "Alysha Squares, 2465", 33 },
                    { new Guid("aac731f5-6c04-4fe0-9cfb-51dae019bb15"), "50,703808;23,39756", "Murazikstad, Guatemala", "Kelly Mission, 5057", 100 },
                    { new Guid("ac03dfd2-e1cd-4f8e-aab6-62b1dc8b9841"), "49,953632;23,6959", "South Briceberg, Belize", "Davis Canyon, 3498", 18 },
                    { new Guid("af489542-b5d8-4135-b3d3-06d3931167c5"), "48,899857;28,410368", "Huberttown, Hong Kong", "Felipa Views, 3001", 111 },
                    { new Guid("b1025387-6d16-41a1-82f7-275c3fc42fe6"), "50,200733;30,050934", "Lake Rosa, Guernsey", "Bennett Coves, 2297", 6 },
                    { new Guid("b253ca3e-55f1-48a2-b356-a6b80f64188a"), "49,921715;30,96057", "Klockofort, Saint Martin", "Little Burg, 727", 30 },
                    { new Guid("b4c909b0-5d20-4059-aab7-5d0c56d44629"), "49,163692;25,329332", "Kozeychester, Chile", "Aiden Village, 84433", 115 },
                    { new Guid("b591da3c-8f7d-49c0-9023-8fa871d46fb7"), "50,698353;23,804039", "Reynamouth, Macedonia", "Cleora Spurs, 8173", 97 },
                    { new Guid("b6ac4cc8-1dda-4a49-9fe8-d4a4f4329986"), "49,356438;29,610723", "Alexisberg, Swaziland", "Gracie Cliffs, 2686", 127 },
                    { new Guid("bdbd045f-4f60-4205-b2d8-4d11893d8c4a"), "50,575733;24,531904", "West Miketown, Sierra Leone", "Willms Cliffs, 3143", 118 },
                    { new Guid("c0fead0f-1237-44aa-aa75-fa6d5f050ffe"), "49,545406;26,090683", "Corkerystad, Nepal", "Clemmie Forest, 3841", 184 },
                    { new Guid("c51df42d-ea1d-4159-bf5f-ae01b7e5027f"), "48,643097;28,981562", "Jeffereyburgh, Ecuador", "Luigi Bridge, 720", 35 },
                    { new Guid("c6cf41f3-0858-4fbc-8c7f-425ca062c180"), "49,425972;28,258997", "Aramouth, American Samoa", "Douglas Dam, 30171", 126 },
                    { new Guid("c6dc6553-ebfd-41c7-9aa9-c6b018960762"), "48,009747;28,1212", "Mohamedchester, Belarus", "Klocko Plains, 7674", 138 },
                    { new Guid("cc2748ff-ac02-48cb-8d9e-ffb49796acc0"), "50,072372;24,570004", "Saulmouth, Western Sahara", "Bernhard Stravenue, 069", 68 },
                    { new Guid("d082b156-7241-4fd6-a69e-e40010915a65"), "49,878773;27,518576", "West Aimee, Pakistan", "Kiley Junction, 194", 150 },
                    { new Guid("d1085972-793e-4706-b589-4bfad2b79c5d"), "48,211052;29,00685", "South Brooksbury, Romania", "Stephania Course, 7926", 177 },
                    { new Guid("d2a8ee54-cb5b-49b5-8b82-95f69efe8775"), "49,491173;30,4289", "Mrazmouth, Martinique", "Davon Stravenue, 35764", 109 },
                    { new Guid("d6b2b917-165d-48fa-8688-b3c227d99df7"), "49,795704;27,697512", "North Clarabelleborough, South Georgia and the South Sandwich Islands", "Bennett Ranch, 358", 10 },
                    { new Guid("da91e603-d879-4b20-9212-ef0bb66e9a49"), "49,119823;28,751831", "North Floy, Mexico", "Tyree Street, 774", 97 },
                    { new Guid("dcaec4b7-ade6-478a-9c85-85b442eb17bc"), "49,891735;27,288301", "Dorthystad, Nauru", "Waelchi Heights, 76462", 102 },
                    { new Guid("dd7612a3-5532-4a3f-a9d9-2a24182a4650"), "50,40372;29,993225", "Gulgowskimouth, Bhutan", "Hildegard Lakes, 617", 14 },
                    { new Guid("ddd2731f-f444-4ccc-b060-2bb70cc6ff18"), "49,59477;30,39809", "West Moriahchester, Azerbaijan", "Halvorson Lane, 584", 78 },
                    { new Guid("deaf0a49-cc4d-41d3-ad5e-cdda1b370015"), "49,948692;29,044418", "Cassinville, El Salvador", "Sabrina Walks, 701", 174 },
                    { new Guid("df969dbd-dffa-4c01-a701-8b1d0ba26550"), "48,70903;27,40759", "Eastonberg, Puerto Rico", "Giovanni Isle, 31183", 183 },
                    { new Guid("e3c4fda4-bff6-4000-b337-679c3acec877"), "49,417973;23,521645", "Torpchester, Maldives", "Sawayn Islands, 124", 131 },
                    { new Guid("e5cdf508-2f3d-480c-b4b1-7d73c03466d8"), "48,478924;27,856112", "East Nicholasville, Guinea-Bissau", "Gutkowski Dale, 9528", 162 },
                    { new Guid("e5fa1074-35be-4230-b010-66eef94680ef"), "48,34862;23,63539", "Odiestad, Cocos (Keeling) Islands", "Elmore Glens, 9912", 143 },
                    { new Guid("f082e0b0-bc9b-4953-8246-bfbb6ea5680b"), "49,031067;25,759895", "Novellaberg, Moldova", "Eula Highway, 8635", 96 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("f62fe85b-062b-4e1d-9bac-0260aeb49214"), "49,108276;26,813242", "Smithamfurt, Virgin Islands, British", "Cindy Isle, 738", 76 },
                    { new Guid("fb6c3671-f9ed-4c30-b84a-f7606888f0da"), "50,339233;26,147678", "Jonathonhaven, New Caledonia", "Chase Mountain, 14616", 16 },
                    { new Guid("fb7aab77-ab85-4040-84a3-4ae3d22fe838"), "50,258617;23,307827", "North Lillianaport, Equatorial Guinea", "Linwood Plains, 6909", 65 },
                    { new Guid("fb992575-02b7-4b44-afaf-e7ecb5717feb"), "48,11088;29,353745", "Reichelview, British Indian Ocean Territory (Chagos Archipelago)", "Satterfield Bridge, 242", 162 },
                    { new Guid("fcea49d9-b4d4-4640-b63d-de231e546e6d"), "48,99052;29,175032", "Port Vladimirbury, Uganda", "Eddie Forge, 6069", 185 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("01543438-ec71-4077-a595-54e20ee7e00c"), 83, "48,581936;29,532116", "Mittiemouth, Germany", "Bartell Fort, 31028" },
                    { new Guid("03af1c70-7a0b-40a8-a591-a5bf9f1c1802"), 117, "49,591343;25,436056", "Laurineville, Germany", "Ben Squares, 3727" },
                    { new Guid("075feda5-87a9-4d1d-9a83-4a13d9117dea"), 30, "48,696293;26,241125", "Garfieldbury, Nauru", "Von Common, 89416" },
                    { new Guid("0cba57cd-3500-40aa-b16a-b0156ceccba1"), 62, "50,4282;28,093578", "Louisafort, Russian Federation", "Wiley Skyway, 5734" },
                    { new Guid("1019cebc-61fc-4773-a0cd-6f7ed17829a7"), 153, "48,429848;23,650785", "South Jakaylaville, Lithuania", "Cara Ford, 18836" },
                    { new Guid("1266c61e-fba1-4b75-8aba-2c7a028d787b"), 78, "50,266228;25,829046", "North Daniela, Ukraine", "Efrain Islands, 196" },
                    { new Guid("14ec02f8-8bc1-4298-8850-77347d4505e9"), 168, "50,031635;29,186544", "West Josianestad, Afghanistan", "Hickle Station, 8246" },
                    { new Guid("1a97317d-df94-439c-9963-4b0ba90aed81"), 198, "50,27964;26,586538", "West Aimeefurt, Pitcairn Islands", "Dooley Alley, 09063" },
                    { new Guid("1f80c20a-f467-4484-970e-679f94ba7a85"), 185, "48,753593;30,03269", "Turnerland, Netherlands", "Robert Village, 449" },
                    { new Guid("1fd55ac8-3143-4706-a9ae-42f135c22db3"), 196, "48,015987;29,43956", "Weimannfort, Solomon Islands", "Buck Road, 381" },
                    { new Guid("230b2f3b-9feb-4fd8-801a-537406424d43"), 31, "49,599564;30,61878", "Lake Giovanna, Grenada", "Kitty Vista, 3463" },
                    { new Guid("23509448-1e3d-47cc-9daf-9761fdc0a64f"), 180, "50,740467;28,470255", "South Johnathonmouth, Indonesia", "Damaris Dam, 0912" },
                    { new Guid("2657ba22-1494-49d4-b150-e68d228a90cc"), 83, "49,088337;27,471508", "Chazfort, Pitcairn Islands", "Lang Plains, 0823" },
                    { new Guid("26f31672-af65-4e7c-8e32-4374cfa359f8"), 147, "50,1005;28,672888", "Port Brayanhaven, Portugal", "Murray Plain, 800" },
                    { new Guid("2aeeda0e-af7f-47b7-920e-c38b895a312e"), 110, "50,577442;25,758099", "Port Paolo, Serbia", "Nicolas Underpass, 88168" },
                    { new Guid("2d160ef9-7836-42b2-a8e5-acfb3cccc994"), 38, "48,788258;25,368038", "Littleton, Ecuador", "Lincoln Rapid, 15253" },
                    { new Guid("2ea7f215-b2ab-41b6-b38e-6b3a697ffe2c"), 51, "50,670506;29,249231", "East Lizeth, Cook Islands", "Kattie Center, 523" },
                    { new Guid("3070faa0-9899-4356-ba9e-b9614b27ed83"), 1, "50,616024;26,810673", "Port Dylan, Saint Pierre and Miquelon", "Walker Spurs, 295" },
                    { new Guid("32752ab1-a568-41b3-9255-cd10cc50fd26"), 80, "49,621338;30,927465", "Port Cooperchester, Saint Vincent and the Grenadines", "Kuhic Villages, 63654" },
                    { new Guid("3608d862-2771-4cb4-b1a4-f6ec2dd2b71c"), 144, "49,711857;29,567558", "West Sammy, Tokelau", "Purdy Villages, 572" },
                    { new Guid("38fcc6c0-485b-43b2-a1a3-8eaf47a10e0f"), 117, "50,691807;24,221313", "Lefflertown, Mozambique", "Haag Garden, 119" },
                    { new Guid("3991a038-ed04-43c3-956c-c4ece60e31d6"), 61, "49,38306;28,90691", "Jenkinsside, Liechtenstein", "Hettinger Mews, 437" },
                    { new Guid("3fd072ac-c66d-4bbc-a4fd-4a9792e21cec"), 28, "48,77926;23,465736", "Port Taniamouth, Mali", "London Isle, 9717" },
                    { new Guid("40b2eb69-8bb2-4e61-bd26-74572a9864cb"), 191, "48,591923;24,21995", "Labadieton, Jordan", "Torp Stravenue, 186" },
                    { new Guid("436c9e03-03af-4817-87a5-14d3a14e7cd7"), 66, "50,81736;24,785421", "Foresthaven, Malawi", "O'Kon Fall, 893" },
                    { new Guid("4669b21b-908c-4f17-bcb6-245c2c7802e4"), 137, "49,384186;25,812136", "West Unique, Italy", "Considine Shore, 81858" },
                    { new Guid("4977bfcc-96fe-4447-86cf-c61126427d16"), 74, "50,757374;25,949278", "Heaneyview, Uzbekistan", "Harry Ridges, 59540" },
                    { new Guid("4b428343-3ed0-4cc9-be36-c8f905f22c0f"), 176, "50,658333;24,904032", "East Blaise, Mozambique", "Carleton Stravenue, 6635" },
                    { new Guid("53f9b66c-c052-444f-a556-d3443287ef78"), 81, "48,594967;30,923788", "Lake Rory, Bahrain", "Keeling Rapids, 27116" },
                    { new Guid("57b10320-87b5-418d-8405-1169a75e1e97"), 135, "49,533234;24,286837", "West Alisa, Liechtenstein", "Wisoky Burg, 736" },
                    { new Guid("59b3ccde-fdce-491e-ab64-f7d2c6bbc128"), 186, "48,679493;29,144604", "Breitenbergville, Kazakhstan", "Wolff Row, 62583" },
                    { new Guid("600db10e-8d44-4611-a2d8-699d12f97779"), 128, "50,196026;26,37219", "North Marion, Liberia", "Steuber Roads, 0192" },
                    { new Guid("65877d32-2be4-40b9-aeee-dd32fbd8cb1c"), 119, "48,11899;23,89711", "Hintzfurt, Republic of Korea", "Patrick Mill, 236" },
                    { new Guid("65cec080-4e88-48c5-8780-a3b9d5c33676"), 58, "49,24407;27,613607", "Sophiaport, Papua New Guinea", "Magnus Center, 7022" },
                    { new Guid("668f7f7f-ca44-43d8-afcf-d3820702df5b"), 15, "50,50731;25,500237", "Heaneychester, Congo", "Rice Light, 6606" },
                    { new Guid("6ad5db2a-b501-47b6-9c5b-f7579cf6cba5"), 21, "49,835716;25,35151", "Mitchellshire, Ethiopia", "Gerlach Island, 11830" },
                    { new Guid("6b9d9dcd-13b4-4f6e-bf56-960961e98c3a"), 158, "49,2374;25,00972", "South Flobury, Dominican Republic", "Goodwin Station, 7249" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("6fee1e8b-08e9-42d5-8502-672f92fdd2a1"), 89, "49,98611;27,629345", "Weissnatburgh, Cameroon", "Bartell Divide, 73256" },
                    { new Guid("704a67b5-17a1-4f25-a9ff-ca29dc7e627e"), 148, "48,548126;23,009739", "Herzogtown, Namibia", "Karley Center, 2857" },
                    { new Guid("71879894-a52f-4467-98d6-c04ddac9c059"), 37, "50,298336;28,462889", "East Ethelynfort, Democratic People's Republic of Korea", "Smitham Mountains, 784" },
                    { new Guid("73202f76-13a4-492b-9179-3904e8393c30"), 78, "48,44094;30,830492", "Reillyville, Uzbekistan", "Rice Mountain, 10562" },
                    { new Guid("7b4acef9-a9b3-4059-a5e6-87789da1e9a9"), 185, "50,241566;24,188864", "Port Uriahfort, Spain", "Parisian Prairie, 393" },
                    { new Guid("82cdf11d-99ee-49b0-aee0-4724918b9718"), 171, "48,23366;25,833786", "Lake Torey, Austria", "Schamberger Terrace, 49780" },
                    { new Guid("83319e1d-0d71-424f-a316-d8b3884ba445"), 21, "49,61134;23,219906", "North Dudleyport, Mexico", "Jaylan Keys, 2576" },
                    { new Guid("85dee941-4e4d-4287-b739-7887e228e83d"), 55, "50,83863;24,90307", "North Lorainefort, French Southern Territories", "Hansen Point, 1460" },
                    { new Guid("8625e94b-7bf0-4d10-a96b-a15b5320e38d"), 37, "50,155163;28,361946", "Estelleburgh, Fiji", "Berge Stream, 943" },
                    { new Guid("8684eae6-656b-41f4-9df5-a723c7b48db2"), 78, "48,072136;28,376976", "South Marlenfurt, Cocos (Keeling) Islands", "Astrid Avenue, 42691" },
                    { new Guid("88fbb507-b25f-473d-9439-e524360128cb"), 179, "48,63743;24,096985", "Cindyhaven, Greenland", "Klein Parkway, 8951" },
                    { new Guid("8940737b-d480-41e2-90b5-b4d36e39c4e4"), 71, "49,137344;27,210585", "North Bernardside, Sierra Leone", "Kelli Well, 386" },
                    { new Guid("89c6793a-8814-4d17-abfe-b0a7a650876b"), 61, "49,54779;28,479279", "Lempitown, Jordan", "Kilback Street, 55336" },
                    { new Guid("8a8c2d22-2b93-4078-b573-50cfae2f0b35"), 185, "49,440273;28,277729", "Predovicstad, Lithuania", "Gleichner Radial, 73167" },
                    { new Guid("8e2508bc-aaca-4977-9b23-ec6b32eb914a"), 72, "49,020416;27,229227", "Townetown, United States Minor Outlying Islands", "Marcella Locks, 2853" },
                    { new Guid("91814aa1-be0d-413a-9b4e-bdbc006c1a02"), 72, "49,24026;23,39747", "Heathcoteview, Vietnam", "Jacobs Track, 776" },
                    { new Guid("927c7087-28f6-41d3-83dd-c72526a00655"), 119, "50,15261;27,222826", "Norbertoville, Benin", "Tremblay Island, 7830" },
                    { new Guid("99c1d65c-3ad8-45e0-a597-9d4ed6a92a5c"), 78, "49,609123;24,582771", "Treyborough, Faroe Islands", "Jones Causeway, 03523" },
                    { new Guid("99ea63f3-189d-4d04-9a61-c6bd8dbaf51c"), 57, "48,145954;23,91068", "North Melyssaville, Fiji", "Marks Junction, 970" },
                    { new Guid("9a75ff28-f8aa-45c6-b642-84d243c40015"), 170, "49,09948;28,697416", "Port Amina, Finland", "Chanelle Grove, 4590" },
                    { new Guid("9fc9bd28-789f-4c43-8428-04a6ffe1c5e0"), 83, "50,576256;23,91939", "South Kiramouth, Bolivia", "Ceasar Pike, 97795" },
                    { new Guid("a2fab122-afbf-4e8e-a44d-21e072c27dc4"), 160, "48,629314;24,63229", "South Jerrodmouth, Cuba", "Deion Flat, 589" },
                    { new Guid("a4097989-eac3-469a-bcfc-e6fb39fbf0e5"), 4, "50,53518;23,429327", "Huelston, Lithuania", "Smitham Viaduct, 6342" },
                    { new Guid("a59958f3-65ae-44f6-8119-b2676ee0ced8"), 109, "50,47176;26,049362", "North Lula, Pitcairn Islands", "Abernathy Shoals, 579" },
                    { new Guid("a5bc736a-1f5f-4422-8d5f-0118f046d8df"), 122, "49,049427;26,133184", "Port Kaileyshire, Romania", "Andreane Spring, 763" },
                    { new Guid("a8112e0b-57f4-4f27-919c-41b164d4869d"), 146, "50,432175;26,6309", "Elainachester, Costa Rica", "Breitenberg Course, 999" },
                    { new Guid("a8374876-e178-496c-867b-001fd5bf6d0a"), 138, "50,098305;26,477789", "Port Ambrose, Aruba", "Swift Villages, 1421" },
                    { new Guid("aa218d84-231e-4867-8e56-cad9e1144059"), 23, "49,515293;28,971554", "Nolanmouth, Denmark", "Marilie Ridges, 99998" },
                    { new Guid("aaed7865-a580-4f49-b971-2182f6986380"), 18, "48,32535;24,956676", "Cynthiamouth, Saudi Arabia", "Legros Ford, 2936" },
                    { new Guid("af867009-d46c-4b68-a875-dc10ea7b784c"), 199, "49,13311;29,789928", "West Keith, South Georgia and the South Sandwich Islands", "VonRueden Extensions, 56864" },
                    { new Guid("b04f2acf-f81a-4447-8d0b-e7b9b20f767e"), 59, "50,932724;24,683424", "Port Opaltown, Bahrain", "Reinger Villages, 758" },
                    { new Guid("b3460f5c-a332-4480-9b52-3248bddbaf34"), 134, "48,43595;25,1607", "Port Luis, Vanuatu", "Witting Mills, 3727" },
                    { new Guid("b39fc1f5-a7d9-4f1f-b43c-91b277ba02fd"), 189, "48,540913;25,627798", "South Chaya, Yemen", "Dan Loaf, 636" },
                    { new Guid("b65b227d-7e11-42d7-a659-ad0a104b0c3e"), 106, "49,550274;28,087051", "Port Evelyntown, Malaysia", "Lavinia Curve, 72154" },
                    { new Guid("b8ed636d-a539-48db-8a43-3bc3c81b7220"), 55, "48,88326;23,228361", "North Jewelmouth, China", "Hammes Extensions, 89385" },
                    { new Guid("ba671965-b327-4c7b-beb1-3e38f5aed3c4"), 172, "48,819687;30,863214", "Conradville, Belgium", "Terry Manor, 841" },
                    { new Guid("bc052da1-36b8-4787-a741-98d980c9206f"), 19, "49,27514;25,171955", "Willmshaven, Egypt", "Bartoletti Viaduct, 8211" },
                    { new Guid("c5908e9b-a5ed-4449-a66d-b27345565d59"), 24, "49,43812;28,136662", "Murphystad, Solomon Islands", "Faustino Trail, 94680" },
                    { new Guid("c938714b-85b3-49f7-9b62-a47f10b6b3e3"), 190, "49,526283;29,348703", "North Dulce, Faroe Islands", "Deonte Viaduct, 84427" },
                    { new Guid("c9a8d37d-3adb-44f9-8064-636afc2a5d0c"), 96, "48,59149;23,217169", "Jenkinsborough, Burundi", "Bergnaum Alley, 4558" },
                    { new Guid("ca7ec7ba-3327-4c8d-bb6b-b9e964007efc"), 199, "48,774307;23,751417", "New Anais, Sao Tome and Principe", "Kenton Island, 116" },
                    { new Guid("cc237ff4-e716-457f-83f7-cf6da535c924"), 190, "50,271946;26,97541", "Vergiefort, Guatemala", "Connor Course, 064" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("cc2ab51e-0839-4f5a-99e7-bd9e40702cbb"), 51, "48,78519;23,538641", "Lake Kevenville, Brazil", "Amya Walk, 7271" },
                    { new Guid("ce2e5f94-97fd-4444-9363-a7d8afc3f170"), 57, "48,480286;30,084276", "Lake Ryann, Macao", "Earnestine Locks, 019" },
                    { new Guid("d287d4be-331d-43fb-8ba1-94f0f3a11fd8"), 8, "49,812412;23,167673", "Monicaburgh, Bolivia", "Batz Crossing, 838" },
                    { new Guid("d58a5efe-973d-4445-b87f-6dddc6936b0e"), 187, "49,373016;23,773115", "New Eddie, Tuvalu", "Casimir Mount, 860" },
                    { new Guid("d64d380a-9c51-4e39-80b8-84626317e505"), 35, "48,114346;28,65696", "East Lacyhaven, United States Minor Outlying Islands", "Hettinger Corners, 14533" },
                    { new Guid("d965f60c-b2ac-4418-a18d-adf2ce5e6670"), 60, "50,1363;23,858892", "Port Reinaside, Ecuador", "Monahan Ways, 238" },
                    { new Guid("da92c128-e818-459b-8a0f-ca90b59ced06"), 10, "50,89021;27,442556", "Johnstonview, Ethiopia", "McLaughlin Via, 8532" },
                    { new Guid("dc00271d-fd8b-44cb-91ff-0b85ce1217ab"), 159, "48,39199;26,07394", "Lake Geraldberg, Lebanon", "Witting Lake, 0401" },
                    { new Guid("dc47f529-848f-43bb-8526-38a1384d9d9f"), 9, "48,949966;26,853437", "West Chesleyberg, South Africa", "Jaskolski Land, 43358" },
                    { new Guid("df324ba7-925b-494a-a8a6-495a6ca31f08"), 198, "49,090782;23,415136", "North Kianaburgh, Iraq", "Clemmie Views, 416" },
                    { new Guid("e826b6cf-0558-4a68-9bfc-3a160258a624"), 145, "49,228355;30,580935", "South Westley, Ireland", "Stephanie Flat, 82532" },
                    { new Guid("f0825b84-bcc8-4b3f-a01b-3b5af918ca68"), 16, "48,840595;26,894255", "North Gloria, Papua New Guinea", "Bosco Mill, 5641" },
                    { new Guid("f3455713-065e-4ed5-a166-c0f8a6f0bbb5"), 195, "48,16637;30,536684", "West Leonardo, Western Sahara", "Xavier Ways, 3097" },
                    { new Guid("f3c56543-43ae-40e8-bb98-86112eab8662"), 29, "48,942234;30,542374", "Port Jamil, Ecuador", "Alta Lane, 30539" },
                    { new Guid("f5917f79-ee28-406b-840a-32a4f0ae623b"), 75, "49,049686;30,201586", "DuBuquestad, Norway", "Deckow Tunnel, 366" },
                    { new Guid("f8643ded-1669-4785-a409-999592e0a0b6"), 52, "49,623333;27,790745", "Lesterbury, Palestinian Territory", "Lauren Courts, 8746" },
                    { new Guid("f91f8ae5-534c-4d9b-ab43-604748eebc8c"), 133, "49,178425;28,129955", "Rauport, Suriname", "Jordane Mews, 4152" },
                    { new Guid("f99b5ec7-f882-421f-b0a9-21bd2ec23a2a"), 84, "48,85642;23,12631", "Paytonbury, Uzbekistan", "Balistreri Views, 465" },
                    { new Guid("fb8699d5-8f7a-4440-b077-c4864ae0b271"), 87, "49,694366;24,10728", "Thompsonburgh, Republic of Korea", "Colten Springs, 916" },
                    { new Guid("fcbf4767-d1c2-4179-b7c7-ae9013f624c1"), 59, "50,503136;25,347862", "Morarland, Zambia", "Bartoletti Pike, 4361" },
                    { new Guid("ff0cb218-e9ff-42f1-9f4a-56bd0448a7d6"), 32, "50,532204;26,2666", "Beerville, Central African Republic", "Lester Rest, 671" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("013f1c94-c621-4848-a691-59b9e8c5bf7e"), 210263654, 0.5323160956370760m, "LjvyRpqAJfSeKNt1H3Zab7GWQD64", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(928) },
                    { new Guid("0386a386-3269-4e50-8dba-54aecdfb1844"), -1605484219, 0.5468434097349020m, "LGZFnv4g8s6JrPKdeQxoHpNiuy2La7R", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(632), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(630) },
                    { new Guid("06c91dad-bfea-46c4-940e-59840dd6a43f"), 1508005005, 0.7996349519320890m, "MFcYRAgbB7mEGKM1fvzn83xDju9HaNSZ4", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(670) },
                    { new Guid("086a1465-92b8-4adc-a082-b92fdc02f4d9"), 413189736, 0.364291461759430m, "3PdRuKDmxLjtoAkhbvEw4UJBzF5", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8304), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8302) },
                    { new Guid("09312d0a-1916-40f9-85d5-568f451251a9"), 9954046, 0.007690121199982470m, "3BQ78oK5NqMa3spnXh6AkdzmVweLG", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1143), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1141) },
                    { new Guid("0b54cab3-f304-45ca-ae93-0cf4892d83bf"), -1107768648, 0.7062865691396610m, "3sFTnEa7wGpXb53Z8NkWM46RxofemrH", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(390) },
                    { new Guid("0b7aabe0-6058-4f91-ad00-757f95bb94bc"), 1841296769, 0.09608507218562090m, "38ADLJtpWhvqbNza4jwcGxCsr3n", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7879), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7877) },
                    { new Guid("103f79e6-bfc2-42ac-9d89-eaa25c2d32a7"), -718594861, 0.5852611853551310m, "Li46a3xC2EPoAnbNUJ8gevBdkyF", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(418), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(416) },
                    { new Guid("1251d7fc-8742-4e53-a5b3-7c5acdcead6d"), 1752500092, 0.9883596119965920m, "LZGy4LagAnorBfED8NxKsMC7Vj6XW1Qqw", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7757) },
                    { new Guid("191e0a9e-2828-4df1-bfd4-a7f102eb2c34"), 484095276, 0.7317427573985460m, "Lez6CW3xSht8g759HAkuPLsqNJVa", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7692), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7691) },
                    { new Guid("1ccdb886-b403-4e72-85a8-2b7e303acb2b"), 838601849, 0.06488730864495770m, "3TAVqr6PU32vug4Nexi9J1KskEMh5CL", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7457) },
                    { new Guid("1d36b191-65ea-464e-b057-ae4a7af224cb"), 1588106410, 0.373074331074440m, "3e6F4bGMAoUgNEPTimZR2zBtpLwX1d", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(995), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(993) },
                    { new Guid("2322fe3d-20af-4638-bf8a-56c5536f7187"), 853999807, 0.2491949443284760m, "3AfjgK7YJEpCGPSmxZTbB1DX8VMUuF4kL", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8028), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8026) },
                    { new Guid("292f15bb-4ae7-401b-9e1a-467bee6778ea"), 1215450101, 0.8320956606125650m, "3E1UbcJ6K8vQWNA4H3jhXmFzTZDieRu", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7398), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7396) },
                    { new Guid("2b99afef-2ef8-4617-a715-a65c42fc623d"), 1599593357, 0.2521475557898180m, "3kKWsAHj9v874oCZQiRnxaFurw2dz", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1264) },
                    { new Guid("2e93e465-884d-4720-8907-1401840040c6"), 625802981, 0.1209640744291470m, "MLd8iSHQxtUZ96gNe1o3KFCkzwhbTrDXRf", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7419), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7418) },
                    { new Guid("30cddf27-f017-40e0-9d7f-83c5ae955a15"), -1898390274, 0.5453266661577540m, "319CGxtJsNru7XSw2jza4WRokBiP", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8166), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8165) },
                    { new Guid("33d30757-954f-48cb-9d70-4bf01e06a6b0"), 33369398, 0.2442894051840010m, "MpimwARGkfV96tKS1gN3Yced2XWnZDqjsu", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1203) },
                    { new Guid("352d9e7b-3982-4ca9-9ff7-9531dec221cc"), 1629109531, 0.9750187519280950m, "3A7RJEg19HL5zbN2kaMtQPpCKj4mVy", new DateTime(2024, 6, 11, 17, 12, 37, 819, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 6, 6, 17, 12, 37, 819, DateTimeKind.Local).AddTicks(4016) },
                    { new Guid("3af1adbd-7971-4f01-bfe8-8047556d8fa1"), 1194493368, 0.7407798588522240m, "L2RtNJnSQ7oh5XmDpPvrb8uUTHKg", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7377), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7375) },
                    { new Guid("3d8c0621-357f-46b3-98b8-04829f77141a"), -407755956, 0.1370419206503110m, "Mu1zUjneXmDwFMAxtvKRQfGSpiyks73bq", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(973) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("45c23fd3-2959-49db-9963-75b97f3bc2c4"), 1224246886, 0.7759742840413380m, "3sDMK89jC6uaFUeXy3GdpStWhPRL7", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(371), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(369) },
                    { new Guid("461df417-579d-4398-9e9d-7bac6129beb9"), 1763545515, 0.4214668429431240m, "3DRxmwMNFqiJPeZpVErHuBXQdTbsY1", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(337) },
                    { new Guid("47ff5d9d-a1db-4431-8cfd-9ce76e7ddf97"), 102948613, 0.2490473738238120m, "M7m4HLAx8ChGbrNcVu6dDaRUZkv", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8108) },
                    { new Guid("4a272027-3e37-4520-b0d2-1bb5c7d76701"), -532072394, 0.00002260626839911680m, "3DvBfxJiGQ39yrKqn5aSACz17jYXsw2tPk", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(292) },
                    { new Guid("4da0fede-cc35-47b9-bef3-1ce994e8eb26"), -124384318, 0.2859523658583570m, "3aRVFfGpTPrSbAM6B43exkdt9hgywCoc1Q", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7797), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7795) },
                    { new Guid("53a06a06-0078-463e-a2e0-442381d4992f"), 1298357466, 0.6516255113819850m, "Lacw8seF3hPzjD9xJVo4ZTnubM6fy7BNtA", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7718) },
                    { new Guid("53e9c47c-f5d8-4dfc-a81b-cbeddd4dba9b"), 180238682, 0.9410272835343460m, "Ld43Z2KjDHMTRfQyus7PGcL58Fm1hawYoV", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(315) },
                    { new Guid("5b58c722-704b-49cf-a5ef-9a473146ea17"), -1352783363, 0.4527905380838870m, "3ZCqrpuyWEMJYstvz875fkGBmTASoH", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1123), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1121) },
                    { new Guid("5cc47e23-9c4a-4660-8afe-9ae5c37cf5ff"), 1939344239, 0.2036779553900960m, "3vPxrSyYWBgdefkibphCaKJ29M8u67L3", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(888) },
                    { new Guid("5cf8a703-f8a1-4023-953b-d915aafc8f4c"), 777384031, 0.5783726972898050m, "LawB7N9ZEV46RX3uCdHSg1yqvUGDmfnk", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7989) },
                    { new Guid("5d96efdd-28c5-416f-bdab-44449d047cf1"), 1766198497, 0.4588906480586680m, "LPDxh5yJFW3zYeNgH1iwSCdbK68", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1013) },
                    { new Guid("5ddeb0fa-28a7-49d1-b0bf-7862f00c2e3d"), 1782439438, 0.5555433060489570m, "36iusxkqpLZdmDtzRagNVjE8M79ehbwc", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8183) },
                    { new Guid("5df5014c-ee5d-4747-b995-fb61b01b3aa1"), 489462433, 0.6078779582052520m, "LPTjx5XBcvr19wqgCYSzuVt8esHd4ApJ7", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7295) },
                    { new Guid("6945db94-d115-437b-ae1a-62152804e5e6"), -394559770, 0.7753355027413880m, "36RpBjwMruz5V2EqCdnskGFJLbHQWi1g", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8066), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8064) },
                    { new Guid("6984b609-3374-4c49-9aa2-20d3372e846f"), -521103547, 0.9649679294711720m, "3pQzSWVx2Hyf3mUKjb7TFiE5so6uMAXa", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7588), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7580) },
                    { new Guid("6b25f2b4-56b6-4b97-8a72-12a814657e9d"), -2096954013, 0.6527649153774820m, "3VNLuzBmeJiHwc9kSU23pfZnKT68G", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(910), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(908) },
                    { new Guid("6bd8a299-98a7-4bd6-84f5-229826de61c1"), 1181618536, 0.9461742925236320m, "3Gzi2raxeJ6HT3hbwXdUsyqNSpDYEonP", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7560) },
                    { new Guid("6f12ab32-7543-4518-a720-9d64b82c7ae2"), 1350989767, 0.9596757659688230m, "3nHLFMGwaJyZ1xkqVj4rc96mi3NS28", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(714), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(712) },
                    { new Guid("73155c01-663e-411d-bd8a-86c9a9b8e885"), -663833417, 0.2299016989514260m, "LKoQkZXHexYcwNzmnGV54239CPJ71", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8126) },
                    { new Guid("73282046-132c-420a-bf7b-2bb82c33032b"), -320902158, 0.0803929874135250m, "3wcagK9rSTC2E3t6VAZsqF7ixGoUy", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(543), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(541) },
                    { new Guid("7bb574b6-b42e-4e04-b1fc-117e9f8ea787"), 1467468851, 0.3423452100269210m, "34NUGyYLskDogbP5STjWatqEuZ92c1p76", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1183), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1181) },
                    { new Guid("7bfdb164-7673-4508-b4f0-9ed88466e60a"), 1543227757, 0.1926459882141010m, "3nSFDHJTt4eRPNV5MaCk9yiEYGABZod", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7972), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7970) },
                    { new Guid("7e438d95-d1be-4cfb-b515-543a128376b9"), -207949292, 0.388088597788320m, "MTDn8LNFvs69R7emiHrt2VjxqZyP", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(588), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(586) },
                    { new Guid("832c9bc0-5ab2-4c34-9d1f-a101b7140a2f"), 2006444543, 0.4874435800189670m, "3jfmUL29tPRpFrMJcnbY7qNHswaDe", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7477), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7475) },
                    { new Guid("83c6ea49-5d2c-4f9d-af7f-e7db8ce21563"), -571940425, 0.1864663890922970m, "LJ1D4dxsnGeqEihQT9SPCuHWwp6VgLamN", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1080), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1078) },
                    { new Guid("852415e0-eec0-4cda-90f0-0632c0b3c0a3"), -1404037817, 0.9189530638550840m, "M6R1xicK2emyM7qTD54okzpWCQd", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1246), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1244) },
                    { new Guid("895912ba-ae01-411f-a62e-89a2a143b73c"), 519309072, 0.7568516216446450m, "MChq27KxV8TDNSgUojQ1MsrHPARuY", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1227), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1225) },
                    { new Guid("8d6dde37-e371-4d07-9a7d-57add175b36b"), 659694535, 0.9360855563134430m, "MNke5GRvgty9a3qUMXLSHujmiz1AnYos4", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7836), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7834) },
                    { new Guid("8fd04688-82b2-489e-9f7e-9a5891fed3c4"), 564132922, 0.5259800415397130m, "LFgQmPGKH6qEpjhXLZfN9rDbBtM48", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7540) },
                    { new Guid("953b7e56-04b5-40ac-94d1-2c76b71ce6d0"), -233664774, 0.6209863815057120m, "3e3ZGfhMxcVbDYWEFS6oNAK9RH2vt8", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(498) },
                    { new Guid("98030b31-3fe0-4958-8cc8-1bbaaba69e7b"), -1460774226, 0.1138242447131260m, "3UDeLM73sZYWGm1NpoyJfPg9w5vHdjh", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(800) },
                    { new Guid("98dbec47-ddbe-4589-bc4c-03e277122b1f"), 780408406, 0.3418490647453120m, "3WRpeioZhPTtuC6XVJ9HqE5U8vSMma", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8203), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8202) },
                    { new Guid("9be30f3c-e00e-444b-a787-0f3845b0e359"), -1666969274, 0.586092838487290m, "MMLDb5cuzo62qFGUaJSBmxEvpN1yfdHeP", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7946), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7944) },
                    { new Guid("9f980f80-6cf8-46ee-a9aa-694824476792"), 543240327, 0.2875132758254550m, "MBPm3ujQHbtVDgYhs5xSMzdqXckv", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1099), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1097) },
                    { new Guid("a00cccc8-7618-4941-a460-60bc32ee9911"), -1249028458, 0.5330397056040760m, "MNEnPFgc4A7YB6aedpxUhKwrzkX1Mvsj", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7777), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7775) },
                    { new Guid("a253de45-411e-48b9-97b0-c81e61112160"), 1542197780, 0.01959102406853150m, "M5uSYKFNXQrGWfymjpsbLV2BH7i", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(865) },
                    { new Guid("a726e2da-4774-449d-8748-97166adde596"), 163582092, 0.5364187081811140m, "MZ2tn8B9yExAz4gpkVCMDNK3GSoju", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8009), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8007) },
                    { new Guid("a742b371-89a5-4cb8-940b-8a5a7cfde9a4"), -162791182, 0.6317818570645350m, "M14D8tTnmEhLfAFRp9vXZePzxWMbjViQ", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8341) },
                    { new Guid("a8adce70-5d7e-40a1-b1ea-d342c991f801"), -252958101, 0.1221699526807050m, "L7cZkpxE26R5tfzVvAinhD9rjoLsUCX", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1056) },
                    { new Guid("ae808282-db49-4c34-a50f-1394c2244565"), 35406042, 0.3449712643053960m, "L1LTWQf3AXKHp7MbdJUtehs6vz9woB", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(437) },
                    { new Guid("af1c1c74-d91a-45f6-8c85-0be1f63b2ee1"), 1041081358, 0.7790476953123360m, "MSmxuGqBcHysbY4VoCf596KLa712zEPD3", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7673) },
                    { new Guid("afc86180-b2a5-4ebe-8298-054468d0cf94"), -18305988, 0.2141879200636410m, "McEQFz9Z3bvrdDXk8t5SnLAqVa2RPUgheY", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7817), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7815) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("b066284d-16f4-440e-9ac6-d220db7ad9e0"), 1679595646, 0.327173764613370m, "3EJNA2M95VDweYHb4gQzWajksdPXu6F", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(564), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(562) },
                    { new Guid("b0d038dd-06f3-4533-9d5c-884697f5cdb0"), 903904883, 0.5201458698040310m, "MaPHXKsd4gWQuBTnrfFSJY9N6eZ", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7616), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7614) },
                    { new Guid("b268f37c-1836-4207-84e4-2a9a2d0f46a1"), 1742513869, 0.4307472959344640m, "MVGwvKUNCiBzuWqg6Ljtmh5YFJoTESrdn", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7513) },
                    { new Guid("b560c563-fbe1-4635-a0e6-fd6119396c8a"), -1623453730, 0.1302020400642340m, "3BEHgFum7KCwdtVo9jxT8riqUZbD5XcQhR", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8046) },
                    { new Guid("ba4aef4c-7c6d-4013-ab2f-e8bd83189cf4"), -755356965, 0.00579424720619770m, "3YUvGWtsTiujrXRZnKqwEpCByFxfb", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(518) },
                    { new Guid("bb723801-bbf0-4b17-b5ed-d1532c8f5769"), 2044046859, 0.4363187725029380m, "Mq5ZKXWxN3jCcptPa1Dy6wU2VuEAHbsJG", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7437) },
                    { new Guid("bbf53c06-f591-43d1-b5fb-de7cb0aeb8aa"), 2094660766, 0.9051565449321760m, "LBWFut5sh2XbUHf7YdnArjN4yxvkpG", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7633) },
                    { new Guid("bc69a075-e200-4104-af9e-1405212fc628"), 1979614843, 0.4302872801325570m, "3XW1tADPzicCYw8oGBQU3ExaNSpZJ52jdu", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8268), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8266) },
                    { new Guid("c12d2093-ac39-4933-8640-b1bf5500448e"), -29330687, 0.3181756428127680m, "MegwVHhZzorSMPfq4kE1aY9XC8UpD5xNJ", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8222), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8221) },
                    { new Guid("c2e6985b-1752-4b7d-b7ae-f9fccc08de59"), -535141451, 0.1814308885126490m, "MbYFxoTPpNHcUEzWgdDs78XBvKjruRmy", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(458) },
                    { new Guid("c619765e-aaff-4a20-ab00-259aab1d8939"), 1810939338, 0.9531541229273590m, "3GBhFb6zWEAPU5R1H2Cva7pknsM", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(754), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(752) },
                    { new Guid("c7cbd7fc-d79d-45f1-af1e-74a75fb7cd13"), -2095527280, 0.7475598664343150m, "3zrTXma8ZUKp6yPNQDE1vALqMk3FJ9h2u7", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7324) },
                    { new Guid("c984705a-65fe-4e51-b4ea-f175981922ee"), 1582525767, 0.6272831085861870m, "LePYWaZd3kLJ6q4Chwp1GyHsnitBT", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7494) },
                    { new Guid("cb981804-6046-4146-b76d-271c92608516"), 14889032, 0.2087174739082470m, "LAaKEdcxT4Pbf6QLmN15kVqrezg7Dun8", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(733) },
                    { new Guid("cd57fd72-bee4-449d-899f-176e18677c25"), -1520281537, 0.9164514839501580m, "LNugF6zDVrfL923eCUSbxykKRQJpEmi7", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(952) },
                    { new Guid("cd6dd9f3-afd5-4fe5-8f9f-33c42f8ac04a"), -1196013045, 0.715994237908650m, "3714U3ZV9Rxv8psGXgNqtrJHeFo", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7853), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7852) },
                    { new Guid("cf989657-228a-4f1e-b635-21aab72d9a96"), -361943678, 0.4950108124838320m, "MZfQGAU2oha4R5pLxwEYnkKWcNsmVTJ", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7345) },
                    { new Guid("d24facee-a415-4861-9fd9-47d8366270ac"), 1505650048, 0.9731206384962230m, "MaB8UNGA2eJW4XsCY9butRx6dZigH", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(650) },
                    { new Guid("d254d895-0cf7-4b59-a605-d374c9fe4cec"), 2042938603, 0.4517706517678040m, "Lp6N7rECJAba4qwKgZSdWX5GY2PeQtsi", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1033) },
                    { new Guid("d29b7fc4-2f2f-4e49-885a-4143c3b33d14"), -753247136, 0.508572826917820m, "3Jd6fSvrpAWamBghV2XDQG94eEcw", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(480), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(478) },
                    { new Guid("d355abfd-9eae-4c33-a5a2-3a59c552b298"), 654581980, 0.8899844210388060m, "3jSxu8t3zH1oEFi7Lc4wndbBvmfa6JkhN", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(610) },
                    { new Guid("d682716b-683a-4edb-9ae6-6824170b54c8"), 1948855233, 0.07331023113820040m, "L8HxwXQYmfj16UGriaEFe4KpVWz", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(689) },
                    { new Guid("d7d8172e-b725-49f0-81d5-6bc0f7720754"), 1441959116, 0.009362832791229740m, "MBdkmUZexy4AKuQJsYPRC321vof", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7116) },
                    { new Guid("d9dd2a55-c3a3-4fb4-aea4-a32e7af3de0d"), -1048636580, 0.4927209007503910m, "MQ1qaVHSdTMn6DKtUgxFokLsBZifm2Jvp7", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8148), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8147) },
                    { new Guid("ddafbbd9-7f2d-4a21-954f-ce20a57462af"), 1346925249, 0.2933961692053160m, "L9LTHMPjoq6wQzxFBYdaubmJyXD8cN", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(1161) },
                    { new Guid("e67d2ba7-1de8-41be-83aa-ebe03ee11591"), -534581721, 0.3892290047602950m, "LWu82E6YZghLKeS7QiGywU9Hdt14X", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(245) },
                    { new Guid("e6b09326-a01a-4bab-b543-f4fd62d9fde7"), 1715181415, 0.802986201016530m, "3q47RhcvzUbLi9juXJWkKE3sd5wnC", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8091), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8089) },
                    { new Guid("e6d2b097-3c3f-4757-a081-ba3108642994"), 853938549, 0.08209659893834320m, "332t67r9TmhLpoWYVyesCB4qZSjwJ5gUx", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(847), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(845) },
                    { new Guid("ed188acc-6517-45fa-9942-e68972d07d9d"), 52679624, 0.5717807560315320m, "MLdmoie2G38NKtMujbHZDRwYJXVh", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(268) },
                    { new Guid("ef2cf196-3960-4c5e-8555-e61a81df0687"), -2085503891, 0.5257841327095140m, "LXJzNuefP6WDCQVmypobqEKkUtHA7395w", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7738) },
                    { new Guid("ef88e2f2-ca84-47e1-a6ce-e338dca0cf92"), -520292435, 0.3987867008118980m, "3Zg8mLF7zfNsYM3urPp4XDtGnJ2Wwi", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(202), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(192) },
                    { new Guid("f049d737-efc1-4e1c-8d95-c99a99dd46f7"), -122866921, 0.7333169331931980m, "LfvieZjxPygWB74uhUNHqJ9FdTEY612r", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(779) },
                    { new Guid("f68a2af9-be51-4602-8acd-23b713554a9a"), -711206373, 0.7915876609257430m, "M7x6PzCgMbyhecFv2EXQpA1r4Y3SHD", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8286), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8285) },
                    { new Guid("f6d2cee6-a211-412a-b301-65e3a0980d53"), -191114954, 0.3226558993330170m, "35uLAiFVUHGEfzhSjs4v1qmQ9tKgaJ", new DateTime(2024, 6, 11, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 6, 6, 17, 12, 37, 820, DateTimeKind.Local).AddTicks(820) },
                    { new Guid("f954f135-3268-4425-8285-c70dcd7bb9dd"), 589652898, 0.8517954304628080m, "LPfABNXRdZpWs9Cq5VnHSv1hbriK6UYtzw", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7655), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(7653) },
                    { new Guid("fc83cdee-ee11-453b-99d1-7144004e1532"), -679871257, 0.5429590556442470m, "MXVPkEMfTGUbK1JLhxiunzZvHA768W2c5w", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8323), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8322) },
                    { new Guid("ffb645b0-df99-4d8a-b2c8-17ff8f5b2a40"), 1520392737, 0.7198778391361990m, "39LVHS3Axk76ZvE8YrGbhWuKsPq", new DateTime(2024, 6, 11, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8242), new DateTime(2024, 6, 6, 17, 12, 39, 831, DateTimeKind.Local).AddTicks(8241) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("0e809aac-90e9-4073-992f-0a9348838efe") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("1f55a324-d084-4122-815d-e1f65a8435b4") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("29ab604b-7a76-439b-8129-93142c9b6cee") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("2b73b7f1-451f-41db-b14e-91c27c148562") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("2e036c59-b30c-4add-a80e-9813b03909a7") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("31147f68-7359-46eb-af11-622a8764424a") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("3164a0af-914e-4e8a-9e4d-83d760107757") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("31995843-45fb-4fd4-bf87-4209bd790c02") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("36333093-6685-44ce-9e09-9007f88e766b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("48f78165-0368-457a-a33f-c7c330b9016e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("48fec127-ff7b-4341-9417-71a573651f92") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("4f18c06d-9e38-4392-a135-68af41671c23") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("5d96609e-242a-4e81-841d-15924cb829f7") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("5f081f26-af78-4d3a-b693-1268567854c9") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("60de2347-d620-407d-9699-3b783da3d34d") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("63f59de1-31f5-4826-bae2-9494ab073e70") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("69445845-4c7f-4276-a288-559e4b4df167") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("6bd6126d-6465-493b-abdc-935b7afbc646") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("7613a4be-1868-4124-8145-c559fd0b8b95") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("988291f5-f421-4687-aafa-58e64481070f") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("a548d594-0e72-40b8-a222-3504b474972b") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b34e9d23-9b12-49b3-b069-734a50918afc") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b61b0669-9383-4f00-947e-75db5b8c7915") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("c559b832-f4e6-4f67-9eca-337973071293") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("d6044624-c058-4b3c-9d01-47f91c93279b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("db25f40f-9692-48ca-96f6-63866a9c9299") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f33ed058-0d5e-4f28-8270-398f55394914") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f6425efe-44a9-4764-877a-c0d313b88196") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f8331316-2615-4a9c-aac6-3bc582886724") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("4fdfda7f-f921-438f-afd2-72ce0c635575"), new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("88a07c86-c797-4c77-8fdd-2262b13f8b0e"), new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("feeae310-c37b-49b5-b035-e9098493766b") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("ff032668-ac2d-465e-a8be-49991c69a967") },
                    { new Guid("0092c4aa-27be-4dba-949c-f98a6206c80d"), new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0004f9b2-42c5-4653-8147-e8cd0d7935b9"), "Lyla_Bernhard88@gmail.com", false, new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("003c9a88-eafc-457f-a4ad-81b358b2d0a2"), "Elroy3@yahoo.com", false, new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("005cb5f4-cb4a-468b-9c94-93d174652b1b"), "Julia_Weimann@hotmail.com", false, new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4") },
                    { new Guid("00c51f6f-a1cd-4d10-8c1e-c778ce5fd75c"), "Burdette_Jacobson30@gmail.com", false, new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("0124b18a-b0c8-4342-9d7b-d94131518e92"), "Tommie_Goodwin@hotmail.com", false, new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("0186940a-9d68-4def-8109-575a3627d1fa"), "Stephanie46@gmail.com", false, new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("02027efe-aac8-46fd-b8c5-7b9c3f437434"), "Brooke.Kovacek@hotmail.com", false, new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("02652dee-9fcd-414a-919d-d310d5aa5935"), "Murl95@gmail.com", false, new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("02a83e86-1eac-4baa-91d5-cbc4c0d5b7b5"), "Jovanny.Douglas@gmail.com", false, new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("02d8549c-bde6-4678-9fbc-c8248132d153"), "Era.Boehm@gmail.com", false, new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("031c5849-6ef7-4d1c-bafc-dbc9dc75d8aa"), "Kaleigh.Murazik34@hotmail.com", false, new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("032fbc63-638c-4919-8757-99b74cdd3693"), "Kameron91@gmail.com", false, new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("0367896a-6852-41cb-bcc7-31de1059f32c"), "Laurine61@yahoo.com", false, new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193") },
                    { new Guid("037f8a4e-0d7b-4997-9841-59d2a2aff32f"), "Ryleigh.Satterfield56@yahoo.com", false, new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce") },
                    { new Guid("03a1e0f9-25b8-4d2d-a57d-5ccf6ab35049"), "Orin.Purdy@yahoo.com", false, new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("03c91731-1b73-4b14-ac1c-68b66f20ebd4"), "Madilyn_Herzog@hotmail.com", false, new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("0417fb7c-18d4-4c06-978f-4f689c41dc80"), "Ernestine.Reilly91@hotmail.com", false, new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("0523b395-bf14-4caf-a80c-c1396138578f"), "Darryl_Cronin42@gmail.com", false, new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299") },
                    { new Guid("05cd09e5-80ad-4470-ac96-583f4ecbd5b0"), "Zack17@gmail.com", false, new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b") },
                    { new Guid("062cc013-661d-40f3-b498-d42fc15da0df"), "Aubrey63@gmail.com", false, new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("0631a09f-4622-4d9b-8ba1-ee970e0f5d3f"), "Hilton.Ziemann@gmail.com", false, new Guid("36333093-6685-44ce-9e09-9007f88e766b") },
                    { new Guid("0673eccd-d3a4-4f8a-8f0a-b5bac00b837f"), "Cristian74@gmail.com", false, new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2") },
                    { new Guid("06b61e8f-9adc-47a3-bec9-8d0f3ecc063f"), "Xzavier15@gmail.com", false, new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("06cb12f5-a206-4d2e-8a80-41f2d7cdc4bb"), "Chelsey96@hotmail.com", false, new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("06ed273f-5e40-445d-8622-8b827ccd96d2"), "Hertha_Ullrich@gmail.com", false, new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("07371a7a-a245-4918-955b-147b31bfafa0"), "Tia_Jones92@hotmail.com", false, new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299") },
                    { new Guid("07b457c0-49bf-4de7-b225-b74668388528"), "Merritt4@hotmail.com", false, new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("07b9cbf0-4694-42e5-a26d-c9e98d6281b6"), "Lizeth_Cremin21@yahoo.com", false, new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54") },
                    { new Guid("07c4aa32-c66b-43df-bedb-c4855a333bdb"), "Deondre_Rogahn@gmail.com", false, new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("07d0bc1e-769a-4b09-a7e9-25bfeac91279"), "Mekhi.Nitzsche28@gmail.com", false, new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("07e39721-888b-4016-87f0-dbb010ce521a"), "Curtis_Bergnaum66@yahoo.com", false, new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("0844135c-27aa-47cb-8bfe-ec6880e6dd8b"), "Nelson.Kub@gmail.com", false, new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("086a8dcc-453b-44c4-9445-586993607b9e"), "Tara_Wilkinson86@yahoo.com", false, new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("0958951e-42b0-48f8-82f7-ead6a358313e"), "Vicenta24@gmail.com", false, new Guid("feeae310-c37b-49b5-b035-e9098493766b") },
                    { new Guid("09c524d8-cbac-451a-9500-808b61cdf521"), "Laverne_Denesik@gmail.com", false, new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") },
                    { new Guid("09e0e9e9-caa9-462e-b587-269722b91cb1"), "Cale.Funk@hotmail.com", false, new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("09e88474-9404-410e-8de9-fe27b4ff05c4"), "Ethyl_Funk81@hotmail.com", false, new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("0a43bf52-e3f7-4a63-b03b-1a7149073dff"), "Angela76@yahoo.com", false, new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("0aba1ef8-10a2-4840-a44b-01fc238dad09"), "Daphney_Ziemann@gmail.com", false, new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6") },
                    { new Guid("0b300f4c-6581-44b8-a717-fb67c7deca0c"), "Whitney_Hirthe@yahoo.com", false, new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("0b962efe-23b9-41a2-8491-e22c3e50e8f2"), "Ladarius.Runolfsdottir@hotmail.com", false, new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("0be38338-9319-4e28-acc7-00d3eb2569c9"), "Kayden.Donnelly15@gmail.com", false, new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2") },
                    { new Guid("0c0f6cce-03c8-4dbd-845c-ce2c832f2703"), "Bryana99@yahoo.com", false, new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("0c66cfb1-3b50-4730-87a5-d44162099261"), "Price16@hotmail.com", false, new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("0c6a55d3-7615-4d06-a922-4e3a8aceac49"), "Caterina75@hotmail.com", false, new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("0d15de49-7cb7-4cbc-86f5-8d820551f222"), "Shemar_Willms@hotmail.com", false, new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("0d22a913-eaa8-4b87-8dc5-cbc9965d776d"), "Rachel16@yahoo.com", false, new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("0d2a3c46-d4a9-4963-a378-543b956b20a0"), "Krystal_Jacobson44@yahoo.com", false, new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e") },
                    { new Guid("0da943e9-92fd-4a46-8690-b69b065762de"), "Yasmin.Auer99@hotmail.com", false, new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("0e9d5cd0-fc7d-4a2a-bc20-fa2fcd4fed2d"), "Justine41@yahoo.com", false, new Guid("5f081f26-af78-4d3a-b693-1268567854c9") },
                    { new Guid("0ec8f479-00b9-4def-a9e9-4286475cb6d7"), "Desiree23@gmail.com", false, new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("0f05f51a-4eb4-45b8-957c-2702a479eb15"), "Carlie.Johnson@hotmail.com", false, new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("0f0fc495-fca9-4603-9cf9-7a990d33f73c"), "Layla.McGlynn95@hotmail.com", false, new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f4a6831-15dd-4cec-9621-5c206a666230"), "Rigoberto.Feil72@hotmail.com", false, new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee") },
                    { new Guid("0fa0d367-ff76-4840-947e-39426f47e49b"), "Ottis0@hotmail.com", false, new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("0fd810c3-417d-4e2b-ab5d-09364d183cd4"), "Cordia7@hotmail.com", false, new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("0fe81665-453f-4a99-951e-52d67527a9fd"), "Schuyler_Kuvalis@hotmail.com", false, new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("1017a37a-cf6d-4215-8842-6dcd67110c4c"), "Abbie.Smith16@yahoo.com", false, new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("105ad3e3-2ce2-4761-8755-1bff359d9b5c"), "Judge52@hotmail.com", false, new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("10a6781b-5544-4ef4-a04f-3c497b706b4e"), "Reina66@hotmail.com", false, new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("10f6580b-0ff3-4357-98c8-b1c739439a89"), "Antonette.Gottlieb@yahoo.com", false, new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a") },
                    { new Guid("111a0fb0-b4e4-49f3-84d0-db9e8c75c34d"), "Miguel.Fahey@gmail.com", false, new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("11367345-accb-47af-a004-b1461f3b5beb"), "Hester.Vandervort54@hotmail.com", false, new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("1149ebdb-0aa0-45ec-a628-c314cac10c7d"), "Winfield.Wunsch35@yahoo.com", false, new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2") },
                    { new Guid("114af0dd-d058-4495-812a-ebe973170edc"), "Laverne27@gmail.com", false, new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("11c2a0ad-5110-4304-83e8-036211daad47"), "Tatum_Gutkowski@hotmail.com", false, new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0") },
                    { new Guid("11ee4687-3c65-47eb-a5bc-03f8918c6046"), "Carmela_OConnell@yahoo.com", false, new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("120ac53c-6782-4667-8d78-20e7ed79d57e"), "Alexandre_Hyatt73@yahoo.com", false, new Guid("36333093-6685-44ce-9e09-9007f88e766b") },
                    { new Guid("12f1fe07-2139-4c43-83d0-de58b1daf2bc"), "Jamaal_Kutch98@yahoo.com", false, new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("1323ae9d-765d-46bc-ae87-61618e495198"), "Jaqueline56@gmail.com", false, new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("135776ae-1541-4c01-a7fb-9882c4e447ec"), "Meta85@yahoo.com", false, new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("1365231b-2d61-4c9e-ba39-40ac809c06fa"), "Jermaine.Schneider@gmail.com", false, new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("13e250a5-af0f-47a5-acea-9e877dde5a09"), "Jerrod.Rau39@hotmail.com", false, new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("13f9f2d0-1cf5-4fe4-b1e7-6fd33204c95a"), "Lola47@hotmail.com", false, new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb") },
                    { new Guid("1421f7cb-08e3-4272-9076-de6b68e18fdb"), "Tyree99@gmail.com", false, new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("14bf47da-9798-4cfd-b9a2-ec05ced7c510"), "Cicero_Champlin@gmail.com", false, new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("1518f348-1ba5-4401-acb6-d485c30643ca"), "Sandy.Homenick@gmail.com", false, new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("15586149-7fef-4db1-bcc1-0a508439c905"), "Lourdes.Turcotte18@yahoo.com", false, new Guid("c559b832-f4e6-4f67-9eca-337973071293") },
                    { new Guid("160fe275-bb1c-46f2-8925-05a2ed19b37f"), "Alexane5@gmail.com", false, new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471") },
                    { new Guid("1697ad56-b89d-475f-a1fb-9f340af68c03"), "Tatyana56@yahoo.com", false, new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("17b2e5ac-12e8-4a79-bdec-0de0d33704fd"), "Carmella.Keebler@hotmail.com", false, new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("17ede80a-c113-43a5-9017-ec61264bf781"), "Aileen_Walker61@yahoo.com", false, new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("1825827d-402f-4cd0-adce-848b49d2e1cc"), "Denis_Hoppe59@hotmail.com", false, new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("189d9f6f-4aab-4dc2-8998-aca15fcf3843"), "Rod15@yahoo.com", false, new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("18bce399-31de-439b-9b5e-468de8154793"), "Eula_Lebsack@hotmail.com", false, new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("193ce30e-3102-44e3-90ee-c06952b6786a"), "Lafayette64@gmail.com", false, new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("196f8393-6bba-4f75-85b7-6d3cec2c77ea"), "Eddie_Turner@yahoo.com", false, new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("19ae3217-1b7f-4572-bb09-fb46c8110fb9"), "Monica_Hoeger45@gmail.com", false, new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d") },
                    { new Guid("19ed8247-0fbc-4ba4-aa23-193fd2289491"), "Elvie53@gmail.com", false, new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10") },
                    { new Guid("1a078485-36b5-4067-b3d7-5e6624afb6eb"), "Araceli_Considine57@gmail.com", false, new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("1a4c6034-1584-4b0a-be1c-c0b0c8b6bc1f"), "Lempi92@gmail.com", false, new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("1aa7c5e9-3312-472a-b7df-a5a2b985ea36"), "Jody.Cummerata25@yahoo.com", false, new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413") },
                    { new Guid("1ac55924-dc15-470e-aaf3-3e14bdbbf46e"), "Trenton.Hudson@yahoo.com", false, new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("1ad65228-6538-4727-acf7-e3748f9538c7"), "Aric.Reilly17@gmail.com", false, new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b") },
                    { new Guid("1b04862b-7fc4-43cd-b3f6-3d67be785ea9"), "Guido.Grady0@hotmail.com", false, new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("1b54c8bf-232e-44f4-b4d1-90d2fabe8784"), "Jerrold29@gmail.com", false, new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("1b6949f5-f9a9-4396-a82e-03867bd3e55d"), "Meta66@yahoo.com", false, new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("1bffc1bb-fb90-4db6-b48c-259ba26a1c21"), "Hulda_Kemmer@yahoo.com", false, new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a") },
                    { new Guid("1c35665a-a4f5-45c0-97ba-aae060f4de96"), "Arely.Collier@hotmail.com", false, new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01") },
                    { new Guid("1c82572b-d094-4333-9a63-0ce63c5601c6"), "Timothy78@hotmail.com", false, new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("1cc2aa62-28b2-4b97-918c-cb7dd084cae0"), "Ola22@yahoo.com", false, new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("1d244a12-15be-4c20-b71e-a216e060a364"), "Elmo.Corkery50@gmail.com", false, new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("1df5081c-0e19-4e10-adb3-1e7a37333a0f"), "Celestine.VonRueden@yahoo.com", false, new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("1e13affd-81b6-4f31-96e4-c77ee7c19e85"), "Lolita.Wiegand@yahoo.com", false, new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b") },
                    { new Guid("1e268e39-41dd-46ed-93b9-b8f251b19ac4"), "Devyn.Wilkinson15@hotmail.com", false, new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9") },
                    { new Guid("1e515d49-c122-4eb1-9cb1-b21f89288813"), "Mabelle.Erdman@yahoo.com", false, new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("1f024eab-a680-4963-a78f-9121d22a458e"), "Mossie.Jerde@gmail.com", false, new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("1f84db70-2359-4818-bd5f-42d7d62baad1"), "Marcelle98@yahoo.com", false, new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("2078a678-90a3-46a5-8611-dded1bcf92c0"), "Dejuan35@hotmail.com", false, new Guid("5d96609e-242a-4e81-841d-15924cb829f7") },
                    { new Guid("208bee97-3c6b-453d-8c7f-6f3c721175dc"), "Zula_Christiansen98@gmail.com", false, new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("208dbd58-5b32-471e-8ace-efa2df22b76d"), "Caden.Schumm37@hotmail.com", false, new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("208de861-4f6f-426d-8a3c-9d4ecb513b81"), "Bud99@gmail.com", false, new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("20ca30f1-9aeb-4b31-88f1-52a24450569c"), "Dave86@gmail.com", false, new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b") },
                    { new Guid("210a7fb4-cd46-4478-b497-86ed0f1e217a"), "Kacey18@hotmail.com", false, new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("2149f611-8a29-40ec-8b53-bae92a4a6cba"), "Mafalda88@yahoo.com", false, new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("21c4cb41-ce30-45f5-9fe2-a2fe4c8269c9"), "Alford_Bode8@gmail.com", false, new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765") },
                    { new Guid("22986c23-a5cf-4c80-a6c8-7d2f125b7be8"), "Naomi.Ebert@hotmail.com", false, new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("2325678f-6948-45e4-b102-bd801e3bd2b6"), "Carlie.Satterfield@yahoo.com", false, new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("2359fadb-4fe3-4ee5-83ec-9156f135c6b3"), "Dulce11@yahoo.com", false, new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("240be310-482d-4872-9cce-7af6b1c79344"), "Romaine_Lang44@hotmail.com", false, new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5") },
                    { new Guid("24f9e2de-f838-48e0-a676-b63e92fdad72"), "Rigoberto.Schowalter@yahoo.com", false, new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("2518f98f-ef45-4d87-85a5-3ff94f03da66"), "Daniella_Wiegand56@hotmail.com", false, new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("263b446e-9346-4a1b-9793-f1500e5b26de"), "Juwan.Ziemann36@gmail.com", false, new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("2705ad16-9323-494e-92a1-e245bd4eeba7"), "Lisa54@gmail.com", false, new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("283edb52-2ce1-412f-98d4-0e87d810ec53"), "Lupe_Schiller@yahoo.com", false, new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("285b2ce4-b72f-4301-a1de-fa6cd568bb68"), "Tiana39@hotmail.com", false, new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193") },
                    { new Guid("28e3ac06-55db-457a-9f17-b1519640c188"), "Ardella.Rosenbaum@yahoo.com", false, new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("28e8bb77-8934-4b8a-8648-beeb6d470048"), "Earl.Gibson74@yahoo.com", false, new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295") },
                    { new Guid("2904cc57-4aa9-42bd-b63c-92b61b2b2ce6"), "Shania_Rosenbaum@yahoo.com", false, new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("299a5c0a-a4e5-442d-be1d-462c059b746d"), "Madonna_Kuvalis@yahoo.com", false, new Guid("db25f40f-9692-48ca-96f6-63866a9c9299") },
                    { new Guid("299e2db4-133a-44bc-9c51-67c52b14a0e2"), "Marcia30@yahoo.com", false, new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("2a5d55cf-fa81-46c6-9db9-f893f36172a3"), "Gretchen_Beer7@gmail.com", false, new Guid("d6044624-c058-4b3c-9d01-47f91c93279b") },
                    { new Guid("2a7ea4a1-740b-461d-addb-ab8bc75baed9"), "Shane.Hartmann@yahoo.com", false, new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("2ac6933b-f508-4704-b2f7-5e474278d72f"), "Ellis61@gmail.com", false, new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("2ad0ca8d-7136-4dad-8dd0-075a01268bfe"), "Terrance97@hotmail.com", false, new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("2c23254d-83ed-47f7-8385-25528599c299"), "Rodolfo84@gmail.com", false, new Guid("b61b0669-9383-4f00-947e-75db5b8c7915") },
                    { new Guid("2ca9cbea-f6a7-4c28-a83c-32c6faeccdab"), "Russell.Frami46@hotmail.com", false, new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d19c813-4f81-476f-b7d3-10d5c1c9b574"), "Jany.Homenick46@yahoo.com", false, new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("2d3e20d3-7f0d-419f-84f5-78a2830f3041"), "Billie.Hintz@yahoo.com", false, new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10") },
                    { new Guid("2e1eb2cd-c173-4313-9446-bd92c9163bdc"), "Mabel_Cassin55@gmail.com", false, new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204") },
                    { new Guid("2e37e40b-0cf2-41ce-825d-c369df898e09"), "Margarett.Yost5@hotmail.com", false, new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("2e5a7c1c-a65d-4459-bb9c-37e70c99d614"), "Ike_Prohaska@hotmail.com", false, new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("2ef3217d-f6e3-47b3-9625-1800d9f5643e"), "Vidal46@yahoo.com", false, new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e") },
                    { new Guid("2f62db8f-0a55-40b8-ae11-f130f4a516cd"), "Deborah.Ortiz@hotmail.com", false, new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9") },
                    { new Guid("2f6948af-e99d-49c3-bd66-304425a6ad5c"), "Allie.OKon92@yahoo.com", false, new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("2fdfb73a-c74d-42c7-9aa2-8279e1aa008f"), "Ervin_Bode71@hotmail.com", false, new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("30c5cd60-2d8e-431a-91eb-123472ac6338"), "Obie_Schamberger56@gmail.com", false, new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("3116560d-f4f9-4620-af5c-f6c4abf5c249"), "Jennie78@hotmail.com", false, new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("314178be-48f7-4eb3-94bb-bfb406ffefbc"), "Ulises.Casper56@gmail.com", false, new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("319ea119-8b59-4cbc-9f50-dcbf7ea53f10"), "Richie.Rempel@yahoo.com", false, new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("31b36375-3059-40fb-b08a-648516ff4035"), "Kyla45@gmail.com", false, new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("32320eba-766f-4dae-ae30-5b3a6bc5dbe8"), "Wade_Jones26@gmail.com", false, new Guid("2e036c59-b30c-4add-a80e-9813b03909a7") },
                    { new Guid("33410cef-2f2c-473e-8dd5-d86387920278"), "Leone6@yahoo.com", false, new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("3365e346-8d5c-4c25-977e-d551743a1538"), "Nash6@hotmail.com", false, new Guid("d6044624-c058-4b3c-9d01-47f91c93279b") },
                    { new Guid("33a127c0-3395-4478-9c74-fd6a399cba0b"), "Orlo_Schulist@hotmail.com", false, new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("33bd5973-0956-499d-836b-67a59866c55b"), "Gwen63@gmail.com", false, new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3") },
                    { new Guid("344aa860-c34d-41f6-a447-d46b05e686ee"), "Abigayle.Schamberger@hotmail.com", false, new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("34d936f6-eb3e-4fc9-8ddc-0c3b8d5eeb52"), "Edyth_Jacobi79@hotmail.com", false, new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("35b0a7ad-2d0b-432f-af0b-5f9d12ac2613"), "Laisha_Altenwerth57@gmail.com", false, new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("368e339a-b5c2-469b-83e6-bb1950277f70"), "Reuben_Pagac35@hotmail.com", false, new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("36a65f8f-1a97-4d6e-a65b-c3d1d560504c"), "Lonie83@yahoo.com", false, new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("3700b6e3-9f58-455a-8c13-a5eca5e7f66b"), "Ken66@hotmail.com", false, new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("3701906a-053d-4921-b4f6-66d218b562df"), "Arlie45@gmail.com", false, new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("37378cd8-c2a0-4289-9082-34a5ec11a614"), "Wilfrid.Romaguera@hotmail.com", false, new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("37426e99-a1f3-4f3a-8d0a-703168d514a8"), "Ladarius_Runolfsson@hotmail.com", false, new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("377a4cfc-fae5-4e47-9c2d-bd96c3f25402"), "Mya81@hotmail.com", false, new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001") },
                    { new Guid("37a75de6-5db8-43cd-ba00-87ef372fe420"), "Lavon3@hotmail.com", false, new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("37b0588c-9958-4121-bccc-524b379f967b"), "Isac_Hyatt@hotmail.com", false, new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("384cbb59-a5a4-403a-af86-8791baa3dcc3"), "Kendra_McLaughlin@gmail.com", false, new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff") },
                    { new Guid("388672aa-2366-4193-bcd2-a93c6a83ae18"), "Brandi_Wintheiser@yahoo.com", false, new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("390016f4-0072-4f75-8fc2-35bd5a1fb876"), "Kayley29@gmail.com", false, new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714") },
                    { new Guid("393f5712-0799-4449-89e4-d716576ed8fe"), "Leslie.Schmeler@hotmail.com", false, new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("39ea61c1-41f4-4746-afbc-06dcdc85a4ca"), "Cornelius35@yahoo.com", false, new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("39f7d42d-7e09-4cde-ac92-48eff7b3cb6a"), "Rocio_Jerde@gmail.com", false, new Guid("988291f5-f421-4687-aafa-58e64481070f") },
                    { new Guid("3a6f9c37-4dee-4640-a0e7-c83c526ffadc"), "Clarabelle2@yahoo.com", false, new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("3a71155a-0c28-4121-8dae-6b2fdc50aec2"), "Bobby.Goyette20@gmail.com", false, new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("3ab5b9eb-0249-4254-8096-3415fa55d55f"), "Brandi.Koelpin97@hotmail.com", false, new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("3ac56fa6-63e0-4c66-b011-91e57d6c1acc"), "Corene.Boehm44@yahoo.com", false, new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7") },
                    { new Guid("3b6a0be2-54f6-4d36-b185-653126413afc"), "Tyshawn.Purdy57@yahoo.com", false, new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3c1e9c70-a1f8-4b21-ba4f-1074183db34a"), "Scotty.Heathcote@gmail.com", false, new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("3c305fae-2fa1-4a8b-ae36-c5b8b85b4f96"), "Gonzalo14@yahoo.com", false, new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("3d2dc370-cd4a-4d1b-8114-debcabf6b558"), "Matt_Lehner@hotmail.com", false, new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765") },
                    { new Guid("3d85a866-e4f8-4307-999d-6ed913179856"), "Harley40@yahoo.com", false, new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68") },
                    { new Guid("3df26df3-81fd-4f2e-9d23-28a8d74e24c0"), "Leon36@yahoo.com", false, new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6") },
                    { new Guid("3dfab80d-3abd-42cd-876b-0e9d89080f41"), "Nina77@gmail.com", false, new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("3e63b798-5d7b-4f56-9f8b-9f07893f2240"), "Natalia82@hotmail.com", false, new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("3e764750-c9d8-46fd-94b9-5d6d44fef877"), "Martina_Monahan11@hotmail.com", false, new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7") },
                    { new Guid("3e9b1190-f8e2-44e0-b87c-544e7f32d173"), "Gladyce86@yahoo.com", false, new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("3ea60e8a-71ea-45dc-a302-d8ba207b959e"), "Olin.Kuhlman@gmail.com", false, new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("3ebba1e3-8747-46fd-bab9-06a66b386367"), "Tracey70@gmail.com", false, new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("3ec7d7f2-c65d-4c67-9dc5-e9a116bd4a43"), "Mavis_Jakubowski11@yahoo.com", false, new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("3fdeda5e-0961-4a80-8efc-d18a3eb0ce6d"), "Jerry_MacGyver17@hotmail.com", false, new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("4073480a-f89a-418c-9257-bf167d720aec"), "Cordell_Zulauf@gmail.com", false, new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("41148043-16d5-499a-9c82-37a6844183d8"), "Devante76@gmail.com", false, new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("411d251f-45c6-42dd-a155-bc8dd080cbf9"), "Oceane.Boehm@hotmail.com", false, new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("418883fe-923a-452b-95c4-60ecafb02adb"), "Kirk39@yahoo.com", false, new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b") },
                    { new Guid("41981760-93a5-45b4-b3af-e8d33a9896e1"), "Lazaro62@yahoo.com", false, new Guid("f33ed058-0d5e-4f28-8270-398f55394914") },
                    { new Guid("41b54dc5-e84c-4248-9897-b065f96a4209"), "Eunice24@yahoo.com", false, new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12") },
                    { new Guid("42105d73-fe17-4c0b-b2fe-140dbea8c3c6"), "Laurel_Kiehn28@yahoo.com", false, new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("421394cc-149e-422f-998b-5b4f3ccb00f4"), "Sheila_Gleichner74@yahoo.com", false, new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("427b8163-a563-4198-83fb-13329215613b"), "Pedro.Schimmel64@gmail.com", false, new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("427bb9be-0f1d-49e3-aaf2-058e0ad4d67c"), "Trevion29@yahoo.com", false, new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("43e28b86-e621-4108-bfe9-2e91d03bde07"), "Kariane_Gibson50@gmail.com", false, new Guid("3164a0af-914e-4e8a-9e4d-83d760107757") },
                    { new Guid("43fb49e3-37bc-40da-89ac-fb1f4d4b6a85"), "Holden29@gmail.com", false, new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19") },
                    { new Guid("441246d2-460f-4cbc-b59d-4b5b393418c7"), "Letha_Schowalter8@yahoo.com", false, new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("44480e87-29c8-4925-a917-3a372d14d6fc"), "Hermann.Heidenreich@gmail.com", false, new Guid("c559b832-f4e6-4f67-9eca-337973071293") },
                    { new Guid("4452a697-ffcb-4ea4-b97b-394e70af3694"), "Karen.Breitenberg65@yahoo.com", false, new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("447e16c9-ed8e-498d-bb02-5380ee765b6a"), "Belle_Boyer61@yahoo.com", false, new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("4569cb0c-6244-4d29-bf74-e33370a541d5"), "Kaia9@yahoo.com", false, new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("4588d184-8b9a-4caa-92af-234837106276"), "Alanna_Gutmann@gmail.com", false, new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8") },
                    { new Guid("45a992e5-e093-4c65-b0e7-11295e51cc1e"), "Faustino_Feil@yahoo.com", false, new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7") },
                    { new Guid("45adeda2-ee7b-46b8-83b2-c0e80f3138d8"), "Jarrod_Heidenreich@gmail.com", false, new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7") },
                    { new Guid("462980f9-67a9-4d07-a55a-67259fa066b8"), "Aisha.Lubowitz@yahoo.com", false, new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("466ab1f2-2482-4497-922d-2d6e8ed0d083"), "Billie35@hotmail.com", false, new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204") },
                    { new Guid("46ea008a-625d-4cf6-9be7-a7d655f16648"), "Justen6@yahoo.com", false, new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("47327109-6d75-4f05-b490-3a9b03eb3009"), "Jillian.Bauch@hotmail.com", false, new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714") },
                    { new Guid("47c3408c-fe59-4e7c-ad7b-953af9f69105"), "Magnolia_Heidenreich92@gmail.com", false, new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("47c53bee-59a7-4ec3-85cd-159fc66c47e8"), "Wyman_Marks@hotmail.com", false, new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001") },
                    { new Guid("47ceabf7-6712-4f76-b16d-a9c50daa952d"), "Brendan57@yahoo.com", false, new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("481e4257-3bd1-492d-bd17-6d2075156939"), "Lila.Murazik@hotmail.com", false, new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("4871352e-9800-49eb-95b1-690e39ed9c86"), "Rachelle_Kessler20@yahoo.com", false, new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("48874be7-d7e5-47ca-afbb-cf44d1b6cd50"), "Amani.Leuschke@gmail.com", false, new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295") },
                    { new Guid("48ed3c0a-3195-4a72-86bb-08762de19f14"), "Consuelo.McKenzie@hotmail.com", false, new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("495c809f-5d59-494f-baa7-309effd8405f"), "Ruthe_Terry76@hotmail.com", false, new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("496135f7-2549-439c-aa7c-6f61bb7c56b9"), "Emil47@hotmail.com", false, new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("49a155e3-9f82-4fe2-9440-8d47023e9a0d"), "Maureen_Kovacek@hotmail.com", false, new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("49c6addf-27db-41bd-9231-583d3b220b60"), "Neil23@gmail.com", false, new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("4aa6e72a-1169-4b38-8e74-46d5e6ae1237"), "Orie_Watsica67@gmail.com", false, new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("4b04323d-3940-465e-ae18-fa3d6a411c47"), "Pamela.Quitzon30@gmail.com", false, new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") },
                    { new Guid("4b2b5568-a3ad-45a7-983c-293eee28aa84"), "Cordie.Kozey@yahoo.com", false, new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("4b8322d7-d3c3-453d-a249-c8defb795188"), "Osvaldo_Davis@yahoo.com", false, new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("4ba54691-b1e6-44cb-b083-63fca44ea367"), "Collin.Hahn9@hotmail.com", false, new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("4be561bb-b8d4-47a0-9b3f-a3bd7aecabf6"), "Claudia_Kirlin@hotmail.com", false, new Guid("48fec127-ff7b-4341-9417-71a573651f92") },
                    { new Guid("4c46b6e6-a43a-4b3c-a642-f8f61f0ce176"), "Courtney78@gmail.com", false, new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b") },
                    { new Guid("4c5964e2-f5b0-4ce9-aa27-c251192be58d"), "Jennie.Lang@yahoo.com", false, new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("4cc865df-3b12-4a46-a46e-d638e8f4108f"), "Mathew_Mitchell@yahoo.com", false, new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("4d03a9e2-5bc6-4f7d-9493-449bdc54a44e"), "Damian.Bahringer@hotmail.com", false, new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df") },
                    { new Guid("4d04ebea-4e20-4385-9691-d537ef78cc40"), "Marcelle_Wolf@yahoo.com", false, new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb") },
                    { new Guid("4d05ee3b-17b1-41a2-bdf6-da317bbac0e8"), "Leda_Welch91@gmail.com", false, new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c") },
                    { new Guid("4d8955ab-1219-457e-9a14-7a2709fd2ff7"), "Chester_Reynolds@hotmail.com", false, new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("4dc33153-bf16-41b4-aea8-3318dd3a4d93"), "Ahmad_Spencer88@hotmail.com", false, new Guid("5d96609e-242a-4e81-841d-15924cb829f7") },
                    { new Guid("4dcadb29-5adb-494e-bbc7-b2e2533b934d"), "Jazmyne_Rohan21@yahoo.com", false, new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("4e5f41a4-d61a-43a1-a698-15136182c540"), "Wanda.Jaskolski@hotmail.com", false, new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("4ed0df39-fc42-4fe6-a732-db10e70d973e"), "Sofia12@yahoo.com", false, new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4") },
                    { new Guid("4f301a8f-1a49-4655-b669-c251cb55f3a8"), "Marian.Davis43@yahoo.com", false, new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("4f386549-b713-493c-a8fb-12a33a93dcb1"), "Lori.Koepp@yahoo.com", false, new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646") },
                    { new Guid("4f46bdb3-19ec-4a9b-bff2-ae27c2352b27"), "Madonna_McLaughlin41@yahoo.com", false, new Guid("2e036c59-b30c-4add-a80e-9813b03909a7") },
                    { new Guid("4fef31a8-fb73-4211-8619-153f8806e48f"), "Gilda.Zboncak27@yahoo.com", false, new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("4ff205f3-0324-4cc7-bc19-4da5a81f70f8"), "Kali83@hotmail.com", false, new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("4ffd125a-ac3b-425c-bb86-c2b8427e5037"), "Neoma_Fahey@yahoo.com", false, new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("503da9e9-ba1d-45a1-a90c-410d299d1d0f"), "Claudia_Greenholt51@gmail.com", false, new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("50cc8eac-d085-4633-9cf8-7e5e4bcd18cd"), "Felipe.Aufderhar66@gmail.com", false, new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385") },
                    { new Guid("50cd9bd5-bd3e-41c6-ab2a-209aa3b9e53d"), "Herta51@gmail.com", false, new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("51073b2a-745d-42fb-9df1-902c36a4ed95"), "Albin_Prosacco@gmail.com", false, new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("5108a8c0-05d0-47d5-91ef-a334cf7bb92a"), "Joe.Walker@yahoo.com", false, new Guid("db25f40f-9692-48ca-96f6-63866a9c9299") },
                    { new Guid("51b4fc3f-f4d8-41ca-aca8-750f0b21d0cd"), "Vaughn.Beer45@hotmail.com", false, new Guid("31995843-45fb-4fd4-bf87-4209bd790c02") },
                    { new Guid("51e4c919-6b3d-4ae0-a0d9-ddc582deab77"), "Sim_Kutch21@hotmail.com", false, new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("523809be-11a1-48d0-b9a1-385d3dfe9359"), "Misty62@hotmail.com", false, new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("52b1659d-dfc7-48a3-aaff-2711514ed267"), "Lindsey_Herman80@hotmail.com", false, new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("53d6c255-7732-4013-b792-125ac54b632b"), "Nicole23@gmail.com", false, new Guid("0e809aac-90e9-4073-992f-0a9348838efe") },
                    { new Guid("53f774be-b574-4e2e-b30e-888bd25e9ede"), "Bret_Lakin60@yahoo.com", false, new Guid("f6425efe-44a9-4764-877a-c0d313b88196") },
                    { new Guid("5441b26a-df1e-4255-b3e0-c844e0856396"), "Alfred20@hotmail.com", false, new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("544fc496-2e2d-4949-bae5-dc83d8c81752"), "Erik_McLaughlin@hotmail.com", false, new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("547db3bd-a941-4a08-bd6d-31de81867006"), "Deontae_Monahan3@hotmail.com", false, new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("54be5414-f767-4f8b-9654-5c3e03fe1500"), "Amara_Schulist23@yahoo.com", false, new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") },
                    { new Guid("55e10613-18cf-4fe8-9be9-6c5cdf386c0c"), "Margarette_Jones69@gmail.com", false, new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("55e5d513-e6c1-424a-9e20-0e56803dd741"), "Cornell89@gmail.com", false, new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("5650737e-6170-4637-aa39-721368aa5e70"), "Sabrina35@gmail.com", false, new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("5654a775-c8bf-4cd7-aebd-ded98a563ea5"), "Clarissa.Rohan9@yahoo.com", false, new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("566197b7-acad-439c-abe4-94a57f616141"), "Mckayla_Kovacek59@yahoo.com", false, new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7") },
                    { new Guid("56665cf0-fe54-4dd2-ba73-267b0891449a"), "Keenan95@hotmail.com", false, new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("57d2dcdd-7d74-4ef2-a714-9b5bade6374a"), "Brando.VonRueden@gmail.com", false, new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("57df7c48-49e3-4065-a9ca-4b2ea7ec6fda"), "Otis_Lang@hotmail.com", false, new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("581e030b-f205-41f7-bd74-d89b2ac7f0e7"), "Aaron_Bernhard@gmail.com", false, new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("58c7c708-b72f-4f5d-827a-acd684171324"), "Broderick.Johns80@gmail.com", false, new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("58c8a63f-d8ba-4e19-8d65-fdd18ac6b463"), "Orval.Kiehn@hotmail.com", false, new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("591fa9e8-04fb-4de7-a72e-21f00481795c"), "Darren.Fay25@gmail.com", false, new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("59249ae4-04fa-468c-b0b6-8f3074ee6087"), "Modesto41@gmail.com", false, new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("593734be-afde-4e15-a917-2e04621368b2"), "Rosina.Rowe@gmail.com", false, new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("5a478fb7-c0de-46f1-b788-d7b4590e888a"), "Leora.Greenholt39@yahoo.com", false, new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("5a619cd5-66c7-4fc1-9695-b79f6c32d6c9"), "Daryl.Harber65@yahoo.com", false, new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("5b347d3a-a130-4342-850f-5b63ae14c61b"), "Lyric.Reilly86@gmail.com", false, new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("5bd97206-5fae-47bd-a3c1-7658016324ad"), "Curt.Orn4@hotmail.com", false, new Guid("29ab604b-7a76-439b-8129-93142c9b6cee") },
                    { new Guid("5c2a2cd3-681e-4613-b217-54a131c53edf"), "Jaylon66@hotmail.com", false, new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("5c5459ee-256c-4bc5-a6a3-c2603619d52d"), "Ewald.Rice28@yahoo.com", false, new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("5c5669bc-e5e8-4586-a60e-1ca83f48aa49"), "Johnnie_Effertz63@hotmail.com", false, new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("5c765c90-e12d-4b88-802c-f4bd073936e7"), "Sam.Wisozk@gmail.com", false, new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("5cb31abb-b5ad-475e-ac25-d04a384b31e3"), "Makenzie26@hotmail.com", false, new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66") },
                    { new Guid("5cc30538-c308-4512-ad0d-0d27422efb6e"), "Zakary_Keebler20@hotmail.com", false, new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7") },
                    { new Guid("5cd0077a-b70a-4cbf-bc49-1126fec9551d"), "Madie.Zieme16@hotmail.com", false, new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("5ce7d328-1b0e-4e5a-82bf-a05b4fc28658"), "Rocio_Zieme@yahoo.com", false, new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("5d12dedc-e38e-43c5-9296-52e4a587987a"), "Henriette.Mayert@gmail.com", false, new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee") },
                    { new Guid("5d530edd-5c3e-4b75-a3df-3fa0c52554e5"), "Madonna.Paucek@hotmail.com", false, new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("5d54ed82-3dbe-4b5a-8a73-f704f741aff0"), "Carli.Greenfelder58@yahoo.com", false, new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("5d97de7d-aaaa-4dc9-8e4c-c55f71d33c4a"), "Elwyn48@hotmail.com", false, new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("5e6a0c25-98ae-41c3-8b12-73e57c94e425"), "Larue.Collier@gmail.com", false, new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("5e6d8fa2-e0f9-4de9-adae-db582bed9bdd"), "Norris_Medhurst@yahoo.com", false, new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("6035f941-aa29-4336-958a-fe2a02e04d4d"), "Haylee.Marks@gmail.com", false, new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764") },
                    { new Guid("6138d466-e9a5-448b-a5af-29e5521228cb"), "Jeanne0@hotmail.com", false, new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97") },
                    { new Guid("6144e577-bbe2-4df4-98ae-d1fe07c4e270"), "Missouri_Kub@hotmail.com", false, new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("617ecd00-f7b7-4b38-ba9d-e5eea90a0465"), "Penelope.OReilly@gmail.com", false, new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("61852656-85aa-464d-b84d-5f67347d95c0"), "Marilou_Dibbert@yahoo.com", false, new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6") },
                    { new Guid("61a2c93f-135e-4cc7-8740-13b91afd0e0a"), "Lillie27@yahoo.com", false, new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("61a4f488-1113-4652-860e-4b17207bb723"), "Neha_Dare@yahoo.com", false, new Guid("f8331316-2615-4a9c-aac6-3bc582886724") },
                    { new Guid("62003bf2-220b-4a02-a58a-6f46bd85d739"), "Iliana_Langosh44@gmail.com", false, new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("621bd3f1-3a62-4e80-9169-1776db45b43d"), "Efrain60@gmail.com", false, new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("628be06f-19ad-4da3-a43a-3d1528b44d5d"), "Filomena.Schuster@gmail.com", false, new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6") },
                    { new Guid("6295806a-2eb0-4d0f-a6b1-939ef3c7ec98"), "Larry.Quitzon97@gmail.com", false, new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("62bcc8cc-b048-4edf-ba81-30bf600b4fc8"), "Hosea.Beer46@hotmail.com", false, new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4") },
                    { new Guid("62f8e78e-a665-4ec1-b65a-f7f2e236c7b8"), "Julianne_Gerlach@gmail.com", false, new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa") },
                    { new Guid("63321330-08e0-4e5d-a9eb-de0d1b37f21d"), "Elyse.DuBuque@yahoo.com", false, new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888") },
                    { new Guid("654a95cc-7b60-44ac-8f9f-520590b9628c"), "Ahmed_Bergstrom@hotmail.com", false, new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("65601023-4a27-407d-bb80-203a523ed10f"), "Joanny97@hotmail.com", false, new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982") },
                    { new Guid("6561fc31-abfc-4c2f-8699-ebf4c4a78887"), "Zena.Zieme5@gmail.com", false, new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("657d3c2f-e18a-48c1-9304-a3d8831d5ed0"), "Camryn_Barton8@hotmail.com", false, new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("65a35697-f412-46f3-8b0a-36e12429fff4"), "Albertha57@gmail.com", false, new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("65b290dc-9798-4a08-a674-88a914029512"), "Eugenia.Emmerich@yahoo.com", false, new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43") },
                    { new Guid("663edef6-2781-4fba-b538-d4705f70ff10"), "Wyatt.Haley@hotmail.com", false, new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("6648bb96-f79c-4e8d-b878-05dafbbdf190"), "Kareem52@yahoo.com", false, new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("6681e2a1-7ec0-403e-87c8-0b531766b0ff"), "Toby_Halvorson@hotmail.com", false, new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("6731a197-40fa-4851-b2e2-289ff3adc6ac"), "Imelda.Kilback@gmail.com", false, new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("67993f8a-ad00-42ef-9f74-cf7d0148538d"), "Scotty20@gmail.com", false, new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("68299c6f-61f6-4096-8c5b-d91be4be55a5"), "Christophe_Hansen@yahoo.com", false, new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("68d2baf9-44eb-4bfd-99a8-834cd5fdb776"), "Floy_Haag34@hotmail.com", false, new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("68d3d4cb-b189-4946-82f6-2459127c484c"), "Linda_Abernathy@hotmail.com", false, new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("6915f3c6-5768-4a38-8d36-6b6239cc6ab6"), "Jay12@yahoo.com", false, new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("6934d6a8-be20-4f78-875f-b7d8045636c0"), "Abraham77@gmail.com", false, new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("69791fb6-034c-41f1-af27-c471eef9ce62"), "Jadon_Jakubowski26@hotmail.com", false, new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("69ac9572-2ace-4b8b-b794-6abab3ddca24"), "Clifford.Sipes71@gmail.com", false, new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77") },
                    { new Guid("69b862c8-36fe-47b7-a776-1c2dc1d746cd"), "Stanley7@yahoo.com", false, new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e") },
                    { new Guid("6ad6487c-f3e4-4e73-8120-67ffbdf5ca76"), "Adolphus.Mueller14@yahoo.com", false, new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("6aecb4c1-d8d1-46bd-a5cb-cc6dc71fb403"), "Seamus_Pouros@gmail.com", false, new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("6aefa643-126d-40e1-80c9-f1baf55ba31d"), "Treva.Rice1@hotmail.com", false, new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("6b983747-23ca-4fa6-963a-50d8c48ce76f"), "Christy.Lind@hotmail.com", false, new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("6bf68229-1f5d-4eb5-a430-cee031912647"), "Misael53@yahoo.com", false, new Guid("1f55a324-d084-4122-815d-e1f65a8435b4") },
                    { new Guid("6bfe7dda-3d90-4198-95ee-0de47e86bef2"), "Josie.Satterfield75@gmail.com", false, new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("6ca5ed72-265d-4643-a505-ea48d1c474ff"), "Carey_Dickinson@gmail.com", false, new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("6caf3ac9-749d-4919-af0d-c4d930216190"), "Leila21@yahoo.com", false, new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("6e6ce941-ea96-44c3-918f-0d17d061e93e"), "Emie.Hilpert@gmail.com", false, new Guid("69445845-4c7f-4276-a288-559e4b4df167") },
                    { new Guid("6eba7222-8e93-407d-9573-a7766c02843f"), "Kelly21@hotmail.com", false, new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("6fc9b02a-766c-4151-a1a2-829a7868164b"), "Matilda95@hotmail.com", false, new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e") },
                    { new Guid("7003ce86-b5fe-4170-85fc-0d4249068f15"), "Zakary.Rice67@hotmail.com", false, new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("701b528a-8809-4d12-a679-bd6cdc5ce679"), "Cecilia.Schaefer@yahoo.com", false, new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("7085b053-968a-44f5-9fbf-7412263137b3"), "Nyah_Nader@yahoo.com", false, new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc") },
                    { new Guid("70cf92c5-30fb-4c2e-bfc0-16a3b7e4f38f"), "Leann87@yahoo.com", false, new Guid("3164a0af-914e-4e8a-9e4d-83d760107757") },
                    { new Guid("71481b41-7066-416c-a4ce-3029cdc8ee7f"), "Sherwood.Mante6@hotmail.com", false, new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("7169fe87-f0b3-4b50-b6f5-d5cc94281e2e"), "Patsy_Parisian76@gmail.com", false, new Guid("4f18c06d-9e38-4392-a135-68af41671c23") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("71accbb5-67e3-4186-83ac-c5294dc45a3f"), "Kasey62@yahoo.com", false, new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33") },
                    { new Guid("71c730ee-c323-413e-b9ea-9f4f532be75b"), "Ophelia_Gislason33@gmail.com", false, new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("7212829d-43f1-45da-9497-fad61bf45439"), "Danika.Daugherty@hotmail.com", false, new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93") },
                    { new Guid("72a025ae-4278-4972-9855-1e7f516b6a79"), "Brant_Corwin@yahoo.com", false, new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("72db1170-3199-4a3b-b7ab-3e642711f10c"), "Dax_McGlynn@yahoo.com", false, new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("731f5959-2f2d-4430-b92f-50c9ef78922c"), "Johnnie_Spencer@gmail.com", false, new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2") },
                    { new Guid("7380e6ec-46e9-46a5-a70a-43a8d4bea6a1"), "Faye21@yahoo.com", false, new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("738a9925-87e6-4b1f-898c-2468cfe79f83"), "Erick.Dibbert59@yahoo.com", false, new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("73a9a2ee-2a2d-4fef-9ac7-dddde4b248e3"), "Ashley.Haag36@gmail.com", false, new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("740f292e-86d0-46ed-8ef6-26bb35be3d5e"), "Giovani.Adams9@gmail.com", false, new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("74477987-80ab-44c5-9ef3-0e10d54f56a0"), "Gloria72@gmail.com", false, new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("7462b2ae-aa86-43da-a90a-f0e817d39d2a"), "Austen7@yahoo.com", false, new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("7478f901-fdbd-4d60-822c-0e13d8212cdc"), "Vickie98@yahoo.com", false, new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471") },
                    { new Guid("74b0198c-3f4f-44a8-807c-b0ac7835d4f6"), "Roosevelt_Blanda55@yahoo.com", false, new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("74ffbf21-27b3-4f91-a26c-c8564d7fe3fb"), "Bailey_Deckow92@gmail.com", false, new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b") },
                    { new Guid("75347534-a067-4693-a82c-c20908ee3378"), "Jasen42@hotmail.com", false, new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("753a6236-ec31-4552-8f32-c71ff82d6585"), "Kaylah66@hotmail.com", false, new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("7547cab0-bf1d-43d0-a8d9-d41bf11b6488"), "Jabari90@yahoo.com", false, new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("75dc26a7-b7a8-4454-b648-c7300bcfb17c"), "Jermaine_OKon@hotmail.com", false, new Guid("1f55a324-d084-4122-815d-e1f65a8435b4") },
                    { new Guid("764ed88d-84d2-4c29-b5ea-327bc98d70b1"), "Evans.Streich@hotmail.com", false, new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("7657e05b-85cd-440d-bc25-0bcd95618e11"), "Odie.Lemke@gmail.com", false, new Guid("2b73b7f1-451f-41db-b14e-91c27c148562") },
                    { new Guid("7668bc6e-cf76-4daa-a1d8-695e5bb778ae"), "Harry17@yahoo.com", false, new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("77edae7e-73e6-4f96-a6de-da39b943a219"), "Phoebe.Rosenbaum76@hotmail.com", false, new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("78356cc6-8862-4dfa-8907-29b891c97bc5"), "Eliza_Weissnat@hotmail.com", false, new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("78db1e1f-032f-4105-9d9c-5013d15c6ee4"), "Geoffrey35@yahoo.com", false, new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("792e4236-7d0b-4ef6-a638-df61ae18f106"), "Randy.Wyman@gmail.com", false, new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("793815e7-0c81-44ef-bf1d-7705f99eb711"), "Rocio_Morissette@gmail.com", false, new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c") },
                    { new Guid("79981150-0b33-4ee8-a607-fd028fc02705"), "Dayna.Wilderman@hotmail.com", false, new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("7a17a353-2d03-4cf1-99d4-7e2b1e34edde"), "Rhea69@gmail.com", false, new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("7a885fa9-7a2a-423e-9f3c-7b4767a67f1b"), "Benton_DAmore@hotmail.com", false, new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("7acfff8c-f7b3-4adb-bbba-7fdd194914c1"), "Julia17@gmail.com", false, new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("7ad302c4-e62b-4955-8a2f-69a76409e20f"), "Linwood85@gmail.com", false, new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("7adbdbfe-4e83-4f30-a58c-2fdcd0f770a4"), "Davin_Nolan@yahoo.com", false, new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("7af27195-89fa-4ce7-9cbd-ac4100af4886"), "Selina32@hotmail.com", false, new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("7b9e5f99-b028-4d21-b9b1-cc46ecbaabf7"), "Quinton80@yahoo.com", false, new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("7bf17ae5-c056-477c-a4a6-8aca411ae4ab"), "Raoul_Farrell91@gmail.com", false, new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc") },
                    { new Guid("7c056a67-cf8d-4b13-8b22-4867b405938e"), "Nola.Pfannerstill@yahoo.com", false, new Guid("a548d594-0e72-40b8-a222-3504b474972b") },
                    { new Guid("7c087125-a309-4416-abb5-0019da611833"), "Candace_Lebsack@gmail.com", false, new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e") },
                    { new Guid("7c31b510-300f-4b80-bc03-1bb986a6abb8"), "Lue.Reichert49@gmail.com", false, new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("7c41a653-6fc8-463f-9803-19cdbc3f679d"), "Jovani22@gmail.com", false, new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("7c54b96c-fa85-4d22-8839-9ad611b4ca4f"), "Keanu42@gmail.com", false, new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf") },
                    { new Guid("7cfcd4ab-68d1-4db2-9c5f-7c60e18a0521"), "Sanford.Kunze@gmail.com", false, new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d059d21-d7b8-4fcf-9550-38a872db4008"), "Art23@gmail.com", false, new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("7d0e2df7-30f5-44b2-a1aa-89a6449d2030"), "Anya.Veum@gmail.com", false, new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("7d2cb336-fded-4d53-a314-9c03a0d7183c"), "Nina_Runolfsson90@yahoo.com", false, new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf") },
                    { new Guid("7e20d8fc-c771-4703-94c4-79320e58f0cb"), "Laurence.Muller66@gmail.com", false, new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("7e821569-a859-4207-bd02-0ed49148aee0"), "Modesta13@yahoo.com", false, new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("7e8720f5-6def-4ffd-a7c8-49d44f6e9cd9"), "Giovanni_Tremblay@gmail.com", false, new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("7f16e61a-dc4b-4419-8c68-b1ea1c3d427d"), "Cody6@gmail.com", false, new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("7f203a41-bea0-4b90-85d1-105d05d000df"), "Laura.Kunde@gmail.com", false, new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("7f5586d0-2f09-441e-bf98-1352eeaee963"), "Jacynthe.Aufderhar55@yahoo.com", false, new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc") },
                    { new Guid("7f675125-ccec-4951-8b1c-61826f9e019e"), "Keira_Gutkowski86@gmail.com", false, new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") },
                    { new Guid("7f6bbcf1-9146-4ec4-882d-925dd961b4fd"), "Judah14@hotmail.com", false, new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e") },
                    { new Guid("809c39db-1e5b-4b06-840d-36fd5cd0e483"), "Osvaldo.Hudson21@yahoo.com", false, new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("80ef6e63-af27-4556-9092-1be9cbcb6528"), "Bo.OConner@yahoo.com", false, new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("813fb096-7399-4422-b128-b5afc9488a4d"), "Frederic33@yahoo.com", false, new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("81492594-da1b-41ff-91ab-6134ae397328"), "Leonel_Gottlieb95@yahoo.com", false, new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57") },
                    { new Guid("818732ce-ca7d-4319-8f0d-091882708220"), "Linda_Connelly@hotmail.com", false, new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa") },
                    { new Guid("8189b43f-6aed-4fb6-bb1f-cd0ff7cb8650"), "Giovani82@gmail.com", false, new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d") },
                    { new Guid("81a1d01d-0738-4235-9a88-44dabc57b975"), "Deonte.Frami@yahoo.com", false, new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("81cae7d4-8584-4db3-aa54-f6e7337f575f"), "Nicholas_Koepp@gmail.com", false, new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df") },
                    { new Guid("82220b03-bf04-4d02-b4cc-9c5bcd35cd46"), "Arnold36@gmail.com", false, new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("823ff6a2-d030-4ae8-88a0-889104c9eecd"), "Carlie_Hane@yahoo.com", false, new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("8291dcd2-c653-4efc-a508-bf0e322be063"), "Carleton25@hotmail.com", false, new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("838dd623-c0f1-433f-8131-9a0804401c22"), "Max_Spinka@hotmail.com", false, new Guid("7613a4be-1868-4124-8145-c559fd0b8b95") },
                    { new Guid("8397451e-2931-4880-bf7f-3889bfc5e908"), "Barrett25@gmail.com", false, new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022") },
                    { new Guid("8439449b-e81e-4a9a-8cf0-a03a8df27bc8"), "Maximilian22@hotmail.com", false, new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("84844f55-ba53-4b36-9933-3df311d7ae59"), "Imelda_Jaskolski45@yahoo.com", false, new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("856bd591-5409-4862-93e9-33a3e126ee6e"), "Eloy_Kuhic@gmail.com", false, new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206") },
                    { new Guid("85edf4ff-02f7-4d5b-81a1-37728e6f1ccc"), "Joshuah_Gerlach@yahoo.com", false, new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("861a136f-b691-4797-bcab-14fdf137fb24"), "Jazmyn.Marks27@yahoo.com", false, new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("86688696-42df-4a82-a4fb-9fc65be52e63"), "Russel.Crist62@yahoo.com", false, new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("86947af8-3b89-4a36-b9d2-1476be1c16ef"), "Josue_Dickens40@gmail.com", false, new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66") },
                    { new Guid("86e5fb84-85e8-4bfc-a389-21467acf8780"), "Norbert.Hodkiewicz97@hotmail.com", false, new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("876e7772-7d5b-4582-9a7c-97eababde662"), "Kiel_Buckridge42@yahoo.com", false, new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43") },
                    { new Guid("8789b013-4ed4-4439-b786-19d1952968d4"), "Everardo22@hotmail.com", false, new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("87c8cf35-a307-491d-8b24-6f8b010f14f9"), "Cecile_Romaguera69@gmail.com", false, new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("884042e5-91a1-41c9-bb51-c956a02fd5bb"), "Harold68@hotmail.com", false, new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("8857159c-3837-41ad-9f04-38f35bbe80a0"), "Claudia.Stoltenberg30@hotmail.com", false, new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("8942d34e-0dc7-4bee-9ef4-fe0d315ce7f4"), "Hayley69@yahoo.com", false, new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("8a13ce6c-916f-4795-996e-0d0a91bb6113"), "Kiel51@hotmail.com", false, new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("8a4b7b98-cda8-425c-a929-75477da596a0"), "Gunnar.Schinner81@gmail.com", false, new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b") },
                    { new Guid("8a6ae21a-d20b-4fad-801a-ff78c3cc7010"), "Odie_Robel@gmail.com", false, new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("8a897275-15d0-4fb5-9517-c6a290e17b82"), "Ian.Wilkinson22@hotmail.com", false, new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("8aa8025c-8d31-4e75-9d73-ea14feb90185"), "Kylie69@yahoo.com", false, new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("8aaf98c5-d2a8-491d-9a38-64562bc9c260"), "Bennett2@yahoo.com", false, new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("8ae92bc6-eee6-404e-b512-9886af198f4d"), "Reilly_Cronin1@yahoo.com", false, new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("8b679192-a55b-41fc-aae8-34adb593dded"), "Immanuel_Ryan95@hotmail.com", false, new Guid("31147f68-7359-46eb-af11-622a8764424a") },
                    { new Guid("8b70b22f-2396-456c-babf-3a319a9a7f5a"), "Wilma78@hotmail.com", false, new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982") },
                    { new Guid("8b959661-960f-4562-b5e6-1adde755ad54"), "Claudie74@hotmail.com", false, new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01") },
                    { new Guid("8bc984e2-88e4-4b96-8643-6530405561b8"), "Rosario81@gmail.com", false, new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("8bf5b67a-b203-4a72-9c87-ea79cce7cd91"), "Amely_Kreiger19@hotmail.com", false, new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("8c225677-15b1-428d-9681-19a4e4660b4e"), "Santos.OKon14@hotmail.com", false, new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("8c42846f-82a5-4943-904f-4b2ddc147501"), "Lenora50@hotmail.com", false, new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19") },
                    { new Guid("8c57b4ef-898a-439c-be73-4b8ce838b4ae"), "Adeline.Boyer91@gmail.com", false, new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("8c83dcc7-bea5-4e69-a08f-0fd26f62ebb7"), "Kiarra_Schamberger81@hotmail.com", false, new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("8d2a4ef1-e6a8-4532-a926-1831360e61b7"), "Keon.Nicolas@yahoo.com", false, new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("8d3c47f2-d358-4778-ad73-4ce74dbf0495"), "Stephan_Beahan40@hotmail.com", false, new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("8d6c3df5-d4ca-4260-b8dd-609f710b3ee1"), "Woodrow_Schulist@hotmail.com", false, new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("8e278d04-4998-4b70-81ba-472a166dfba4"), "Lottie58@gmail.com", false, new Guid("b61b0669-9383-4f00-947e-75db5b8c7915") },
                    { new Guid("8e4f2772-c142-4076-8093-8dd15a5898d0"), "Abdiel21@yahoo.com", false, new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("8e51ec2d-bcc7-47b0-8f44-0a8b53de86ac"), "Rowland_Borer11@hotmail.com", false, new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3") },
                    { new Guid("8ec0ddb7-e902-486a-be04-a76c47db7482"), "Rossie.Berge24@yahoo.com", false, new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2") },
                    { new Guid("8ec2dbc7-8dbf-4fc6-b310-0390daa409c8"), "Alexandre81@hotmail.com", false, new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("8f6681d0-9f6f-4837-9131-1d107ee3800d"), "Jonathon95@hotmail.com", false, new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("8f89482a-c2d8-450d-81a6-6374a6911e8b"), "Petra.Cole@yahoo.com", false, new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("8f8da3f4-cafb-4eae-be42-9623d1496ad5"), "Camylle82@yahoo.com", false, new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("8f9b687c-3142-4a59-8e8d-1a367d4d9e7b"), "Jed_Bergnaum38@hotmail.com", false, new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888") },
                    { new Guid("9006d7d2-b849-45ee-ab0f-fee98ae1cece"), "Beverly86@hotmail.com", false, new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430") },
                    { new Guid("9017a722-6385-4b32-95c9-2fc57e765401"), "Kallie63@yahoo.com", false, new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("90c66aa7-86b5-4091-bdff-fb2d1503baf9"), "Dorris_Mante@hotmail.com", false, new Guid("60de2347-d620-407d-9699-3b783da3d34d") },
                    { new Guid("90d244e0-c3d9-467f-9b50-5256f09036b1"), "Alexander.Lubowitz13@yahoo.com", false, new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("90e008a6-b3d9-4b9f-9799-d998cac5800c"), "Vena.Medhurst@gmail.com", false, new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("917c1f11-2806-4e16-917c-26e2b5f8704b"), "Aniya.Homenick66@yahoo.com", false, new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("91b9aa8b-6608-4e28-b81c-93e71f6a5cb0"), "Benton_Parisian45@gmail.com", false, new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4") },
                    { new Guid("91f68bf6-4a8b-4a52-ac4d-6be70a4f6038"), "Esther_Robel@hotmail.com", false, new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e") },
                    { new Guid("925439ee-03e8-4f7c-8413-426463b5c742"), "Thea.Batz43@yahoo.com", false, new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("9268f1a3-bd4a-4e87-b321-542fa28d0428"), "Brenna.Raynor46@hotmail.com", false, new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("9276146b-6b50-4b6a-ae1e-0431c6067408"), "Duane83@hotmail.com", false, new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("92fe727d-fba7-468d-9e87-6b7d38888738"), "Roscoe76@gmail.com", false, new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57") },
                    { new Guid("9313ef08-bf91-42c4-96e8-148a44fa9be5"), "Amanda.Sporer@yahoo.com", false, new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("931d5861-7543-4870-8b13-b07c002cd286"), "Jason_Schultz@gmail.com", false, new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("932d37f0-c5ad-4146-98d5-13c1ef82547d"), "Coty48@gmail.com", false, new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("93588a8e-f242-4f5e-bc2f-4c95e8d6191d"), "Weston.Donnelly@hotmail.com", false, new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("94701bc2-3af5-4c8b-b38c-5d5235e53e51"), "Maybelle.McCullough66@gmail.com", false, new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97") },
                    { new Guid("947e8dfe-1ff0-4520-bd76-4eb739630829"), "Garland20@gmail.com", false, new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("9526c71c-8808-4ea7-9a88-711f1cb89c27"), "Albertha.Pouros@hotmail.com", false, new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("9565af03-6b5b-4ddd-88ae-efd249353796"), "Marisa54@yahoo.com", false, new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb") },
                    { new Guid("959f7191-4dfc-4e63-8de5-c8e588999687"), "Mia_Conroy30@yahoo.com", false, new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("95d11fbe-1ea3-4975-93f2-570223990842"), "Tressie.Cruickshank@gmail.com", false, new Guid("63f59de1-31f5-4826-bae2-9494ab073e70") },
                    { new Guid("964a1c26-965e-4383-a7e3-3c5f5192f727"), "Evans_Beier@gmail.com", false, new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("96b40d47-c392-48bd-a867-2c848e7de855"), "Petra_Beier50@yahoo.com", false, new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("974e2175-1f4a-4085-b097-b579ed1e6717"), "Elena_Willms13@hotmail.com", false, new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("9765a926-63a4-4f2e-bacd-b205b4e123f0"), "Brisa96@hotmail.com", false, new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("97714343-e758-418c-bf64-407dc17eacf4"), "Garrison.Balistreri@hotmail.com", false, new Guid("6bd6126d-6465-493b-abdc-935b7afbc646") },
                    { new Guid("97f09f64-c623-4cd0-b95b-b37a7afaab7b"), "Jedidiah_Kuhic@hotmail.com", false, new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("984a706e-1cef-423f-8d7f-51592875226c"), "Russ48@gmail.com", false, new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("98be3d16-7222-42bf-9f23-dbe5a077e502"), "Gino37@yahoo.com", false, new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("98ee8d25-b3a7-4dcd-9b79-421995379c22"), "Adah_Bartoletti63@gmail.com", false, new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("99aaae41-b86a-4b44-808b-fc5540393168"), "Rebekah.Morissette1@yahoo.com", false, new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("9a363995-04de-45ea-868a-7ffb78b87a80"), "Yvonne_Walter@gmail.com", false, new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("9acaa448-fc8a-4209-9e40-8622da58f61d"), "Issac89@hotmail.com", false, new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("9aea0283-7935-4d8b-9204-d0d6c27c434b"), "Danyka60@gmail.com", false, new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("9af934c3-d407-4902-b897-316e15faf360"), "Genoveva97@hotmail.com", false, new Guid("ff032668-ac2d-465e-a8be-49991c69a967") },
                    { new Guid("9b190cd8-bdd5-44f6-9fe9-fedf4a605b94"), "Ericka.Krajcik8@hotmail.com", false, new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("9b369f05-712d-49b6-beee-95bb0e52c2ef"), "Daren.Cormier71@gmail.com", false, new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("9b394abc-eb84-4c61-8e4f-8d6bd1375073"), "Greg_Davis@hotmail.com", false, new Guid("0e809aac-90e9-4073-992f-0a9348838efe") },
                    { new Guid("9b5de876-f43a-43c7-9ade-0e402c6a2e76"), "Paula92@hotmail.com", false, new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("9b900204-2208-4c16-a9c0-23b4a2fd9f12"), "Corbin5@hotmail.com", false, new Guid("2b73b7f1-451f-41db-b14e-91c27c148562") },
                    { new Guid("9be64414-18ba-4180-831b-e378f572b731"), "Sabryna7@hotmail.com", false, new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a") },
                    { new Guid("9c26e401-bcc7-400f-bb23-52745a0a5e8f"), "Kelsie.Greenfelder@gmail.com", false, new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("9c4e834d-ee6b-4645-b2f8-bd9f75414a72"), "Annetta.Gibson93@yahoo.com", false, new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("9c93256d-0004-4d0d-b191-4174e3f167a0"), "Catalina23@gmail.com", false, new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0") },
                    { new Guid("9cadf25a-52c1-473e-8bf0-b1ac9f5fbbe7"), "Kade_Keebler@gmail.com", false, new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3") },
                    { new Guid("9cb750b7-fd2f-4900-b865-b4fcbd412d80"), "Nova68@yahoo.com", false, new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc") },
                    { new Guid("9cbe7dd6-3aa7-4f47-829f-5076722e6e49"), "Ericka82@hotmail.com", false, new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("9d4bac1a-85c1-4e6d-b0ee-931dc777cdc4"), "Ellen.Murazik94@hotmail.com", false, new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("9df20901-fd26-4983-b321-84d5b0f3a192"), "Alicia7@hotmail.com", false, new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("9e0a4f6f-4df9-4acc-b612-fbcea83af896"), "Davonte_Batz@gmail.com", false, new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a") },
                    { new Guid("9e712dd3-8df3-4b72-8f72-81b8733827a0"), "Aida62@hotmail.com", false, new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("9e7b77ae-1c7b-4e3d-8eb9-a0a39b64c326"), "Santos52@gmail.com", false, new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("9efe729b-5f2f-452d-badf-12137b0787c0"), "Theron_Blick@yahoo.com", false, new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("9fb4f668-e938-41b1-a74b-1d392842300d"), "Lacy82@yahoo.com", false, new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("9fd99d3e-3836-486b-a5fa-806a9b23eab1"), "Penelope_Weber74@gmail.com", false, new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("9fe2c00e-5885-413d-8925-a2951e4a035b"), "Abdul37@yahoo.com", false, new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("a052c3e5-f139-473f-b8f5-87acfe8aae04"), "Craig_Rodriguez92@hotmail.com", false, new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("a0595e41-5e7a-4bb4-8112-b7361f5182e7"), "Trent58@gmail.com", false, new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e") },
                    { new Guid("a0602b58-51e5-470f-b196-1ea44ab4df6a"), "Augustine.Labadie14@hotmail.com", false, new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a0b9ff47-84a5-4c0d-bb91-068c7bc40b6c"), "Icie.Murphy88@gmail.com", false, new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732") },
                    { new Guid("a0ce5dd7-be06-4323-ab1e-b94e1ec1658f"), "Henri.Weissnat@gmail.com", false, new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("a0fbb594-4f52-40ab-9641-3513262f75c6"), "Marcella_Kuhlman@gmail.com", false, new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("a177c133-bf54-44a4-8636-96167d9e0d67"), "Tara38@hotmail.com", false, new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("a2578027-2d16-496e-958d-f52b4ac0bf7e"), "Adolph69@gmail.com", false, new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("a361fc87-9367-4227-9df5-fb36c4066dde"), "Geovanny_Turcotte@hotmail.com", false, new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91") },
                    { new Guid("a44b20b2-d9c0-4689-9c90-3e3bfcdde26a"), "Jude.Waters47@gmail.com", false, new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("a4840807-e301-4a46-afe4-15ae1593fca3"), "Rosalia_Ondricka50@gmail.com", false, new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce") },
                    { new Guid("a4b3319c-1869-4d09-b767-0efb51e21bfc"), "Sheridan.Gaylord@yahoo.com", false, new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("a4f028f3-ffec-4138-90da-688cec384e19"), "Fidel79@yahoo.com", false, new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("a4f485ac-8657-4692-9d56-792e889b78db"), "Alaina.Feil@yahoo.com", false, new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10") },
                    { new Guid("a5ae53d4-0f87-4ed9-9076-382ccd95158c"), "Kirk_Stracke23@gmail.com", false, new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("a5d7271d-8fff-49c3-a62c-629026cadca4"), "Harley84@gmail.com", false, new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("a5e43c4e-6398-463e-8684-98031806bee8"), "Gunner_Casper18@gmail.com", false, new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("a6ded824-4fe2-4777-8c98-4e56b723ea1f"), "Owen82@yahoo.com", false, new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("a72062c7-c9f6-490b-8c8e-5cd64164713c"), "Kasey.Dooley@gmail.com", false, new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("a762d0eb-8233-4408-b580-b593a4738858"), "Minerva_Mayer5@hotmail.com", false, new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("a786ef30-328b-4897-ae85-544480c09905"), "Johnathon_Ziemann@hotmail.com", false, new Guid("31147f68-7359-46eb-af11-622a8764424a") },
                    { new Guid("a8e20956-1341-4b29-8200-44a85aa0e313"), "Maryam_Lubowitz@yahoo.com", false, new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("a9dbaf43-1e26-4b8d-9d3b-9ceaf378a7c8"), "Lyda22@gmail.com", false, new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("a9f47d86-c87e-40ee-94db-7c087d219202"), "Kristin6@gmail.com", false, new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("aa08932d-6b04-47f0-81e5-a53862a40cab"), "Antone_Corkery20@hotmail.com", false, new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("aa5e4381-1e2d-41c3-af82-46bf576dbdfe"), "Mose26@gmail.com", false, new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("aa79dddf-a73a-4ba7-b74d-91322a90e4e2"), "Shanny.Nienow@hotmail.com", false, new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("ab14f7e4-d9bd-4059-8476-d8cd13f9b3f3"), "Bret.Gleichner63@hotmail.com", false, new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("ab1aa624-fae9-42ea-9651-ae5fb36f8e6f"), "Gabriella_Sipes@yahoo.com", false, new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("ab26040f-bd9c-4263-8546-b1206f5fdbf2"), "Walker.Turcotte71@hotmail.com", false, new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("ab5dad7b-96ec-4969-a128-797d5a61dcc0"), "Cleve_Batz@gmail.com", false, new Guid("69445845-4c7f-4276-a288-559e4b4df167") },
                    { new Guid("ab709eed-335d-476b-a4cc-16593274810a"), "Alexie.Larson@yahoo.com", false, new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93") },
                    { new Guid("ab727e47-8e5d-441d-8bbf-7b8205a34e5b"), "Caroline45@yahoo.com", false, new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("ac9aef49-4438-4a28-8e73-ed4913483cac"), "Burdette_Kassulke@yahoo.com", false, new Guid("48f78165-0368-457a-a33f-c7c330b9016e") },
                    { new Guid("accb159e-7bef-4620-81e0-9e7ec4da5a91"), "Uriah_Collier@hotmail.com", false, new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("ad0c2ffe-4a2b-4533-8620-9d74c44ff5fc"), "Kip.Collins89@hotmail.com", false, new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("ad4385b8-3a54-40fc-9b88-34a0bade2a8b"), "Sylvia.Weber@hotmail.com", false, new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("adb05cde-9845-4d48-97b9-f275a2f8b840"), "German.Kohler24@yahoo.com", false, new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("ae4c8809-2d9b-4190-bed2-e43529a9d63d"), "Demetrius40@yahoo.com", false, new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("aed3e439-5411-44ad-b7ce-f5c4784e24d4"), "Floy.Keeling@hotmail.com", false, new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b") },
                    { new Guid("aee0a402-62dc-4e23-a428-80d1b63b7139"), "Giovanny_Rempel52@yahoo.com", false, new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e") },
                    { new Guid("af477faf-5c36-434a-930b-de2061461f8d"), "Kris.Thompson91@gmail.com", false, new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("afab415e-3c59-4326-a7ea-90153ebff620"), "Elisa65@gmail.com", false, new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("afcc4bcd-9a3c-4eb1-9ec6-bbccf67a9a37"), "Anabelle28@hotmail.com", false, new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("affbdaa9-b90b-43dc-8596-ee6e8a794c12"), "Jordane_Conroy@hotmail.com", false, new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("afff150d-eb4a-47cc-8433-f10d6bcff7a3"), "Meaghan_Feest@hotmail.com", false, new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("b018ba13-e641-43b8-894a-2b4822adc842"), "Dameon_Collins@yahoo.com", false, new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("b0317549-4fce-4c7a-a3c4-d95f56eb262d"), "Fleta30@yahoo.com", false, new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("b0b28d6e-921f-4c47-be23-09d2db62ae14"), "Patsy.Hoppe8@gmail.com", false, new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("b0eb02ef-bae5-4c19-95d9-99d1e6e00699"), "Dallin.Miller71@hotmail.com", false, new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae") },
                    { new Guid("b16002aa-2979-4a1d-b0b4-9735f656f0b5"), "Shayne.King87@yahoo.com", false, new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("b1637920-e5c5-45c2-8216-cc7a5bede327"), "Curtis_Dibbert@hotmail.com", false, new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("b1cf7b6b-2b54-4d84-80ad-8a2b0538f899"), "Rollin.Orn59@yahoo.com", false, new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68") },
                    { new Guid("b2513c46-4879-4ffb-a41c-181384cb5850"), "Cecilia43@gmail.com", false, new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("b291b45a-c609-4b47-9629-817564254fe1"), "Alexys76@hotmail.com", false, new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("b2e1a7d6-6c33-4ca9-8830-efaf1679be13"), "Giovani_Rosenbaum@hotmail.com", false, new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("b378f010-096e-4846-ab58-3aa85eebb858"), "Luciano85@gmail.com", false, new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("b431b768-b204-4762-b921-ccc85ca8ee9e"), "Daisha42@gmail.com", false, new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2") },
                    { new Guid("b45f22b7-76c1-4c82-a150-449d227a402f"), "Kelly.Kuhn25@gmail.com", false, new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826") },
                    { new Guid("b4ff4f93-d3a8-47e6-b3f1-6352643a0a1c"), "Friedrich_Towne@yahoo.com", false, new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d") },
                    { new Guid("b5a22d49-dbbd-4126-a67d-a296b0af51b1"), "Nash.Volkman@yahoo.com", false, new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("b5dca339-a7e0-4124-abb1-a064ed9be822"), "Evan5@yahoo.com", false, new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("b5fb40b8-7e32-43a3-b822-ebec8e43a4d4"), "Newton.Hessel99@hotmail.com", false, new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("b647e461-07d4-45e6-9c71-082c73f95806"), "Joanne97@yahoo.com", false, new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("b6f65477-bcb3-4f2b-9902-9d64cab6be84"), "Gisselle.Hudson@hotmail.com", false, new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2") },
                    { new Guid("b72afaf8-8a93-46b1-b6a5-8bc6ee48e2c2"), "Maya_Dicki23@yahoo.com", false, new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("b7a049e2-05a6-4432-877d-b748cd365d8a"), "Buck_Blanda@gmail.com", false, new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("b7c354df-8840-45d7-b0f5-e268ba30f35c"), "Mohamed_Dietrich75@gmail.com", false, new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5") },
                    { new Guid("b83b109b-9a6f-4566-8ecf-40c340d844f9"), "Adell_Feil60@hotmail.com", false, new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("b84d544b-4975-4334-a4b1-0def6dcae455"), "Lloyd94@yahoo.com", false, new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("b88919a9-f74d-46c5-9e7e-5cb929525e65"), "Adonis.Konopelski63@hotmail.com", false, new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("b8996092-7d57-417c-87bb-2501949140b0"), "Kiarra89@gmail.com", false, new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("b8af8b93-59ea-464a-b6de-b87547f193ed"), "Lee44@hotmail.com", false, new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54") },
                    { new Guid("b8e5bb58-a96e-47dd-ad64-53101d8f7520"), "Luis.Strosin89@yahoo.com", false, new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("b903fa75-387d-4bb2-b349-0fea3ce3ac5c"), "Ivy_Cremin@yahoo.com", false, new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("b9c7911e-60db-4577-88f0-7aa8a35c5f7a"), "Kaelyn_Grady@yahoo.com", false, new Guid("b34e9d23-9b12-49b3-b069-734a50918afc") },
                    { new Guid("ba1a45ba-06c3-43f8-8df0-144fdacb6f9f"), "Jonatan45@gmail.com", false, new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("ba2f42f0-e97f-4f7a-b61b-d4ddf394bb45"), "Josue_Keeling@gmail.com", false, new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("ba474921-20c9-4d66-8cd2-deb3ac014d6a"), "Mackenzie.Kuphal60@gmail.com", false, new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("ba9b1f50-8635-4a39-8f1d-f96de12d1994"), "Sienna40@hotmail.com", false, new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f") },
                    { new Guid("baae561b-8da9-40dc-b3d2-241cf5c66a20"), "Cade_Beer25@yahoo.com", false, new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("bb2561bb-8fb8-4228-9d07-9e8ca323527f"), "Genoveva.Kuhic@hotmail.com", false, new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff") },
                    { new Guid("bb551ce6-d86e-48d3-8f8e-f70f1ad0d71c"), "Salvatore_Hirthe@hotmail.com", false, new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022") },
                    { new Guid("bba23a41-2dd3-40fa-83a1-acfcfd3eeaf6"), "Joey38@hotmail.com", false, new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("bbadb240-343d-4812-8692-44a61138a391"), "Brandyn.Wehner76@yahoo.com", false, new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("bc1f687c-8138-4d86-a0c9-d9d31236300d"), "Darien.Moore11@hotmail.com", false, new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("bc2344ea-a0dc-4f31-bd36-95cff5842fd7"), "Elinore.Brown@gmail.com", false, new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("bc6c99e6-0997-4378-b748-2387757834c9"), "Elna52@gmail.com", false, new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("bc7c2ff3-e537-47a4-a122-8e58b8f1dfc8"), "Javonte_Littel@gmail.com", false, new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc") },
                    { new Guid("bcbc84e1-f4d0-4118-bd7a-577ee501827b"), "Lafayette11@yahoo.com", false, new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("bd070601-4810-4b45-8ec5-66b1705f9a21"), "Brant.Considine@hotmail.com", false, new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("bd291ec5-1392-4b6f-af61-38d980c98167"), "Zackery.Ratke@yahoo.com", false, new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("bdf087f3-a82c-4429-b187-659066e03f7b"), "Adam87@hotmail.com", false, new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("be2c59d0-2cee-4394-bbf5-b1f359c09286"), "Catharine.Hackett@hotmail.com", false, new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("be3f7894-dbc8-4027-922c-73dd156e2f5b"), "Damon.Feeney49@gmail.com", false, new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("be4a3bfc-c833-496b-adb8-deca74510ea2"), "Laurie88@gmail.com", false, new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232") },
                    { new Guid("be5a1548-268c-4660-8c49-da4fd37496df"), "Raphael_Frami41@yahoo.com", false, new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0") },
                    { new Guid("be8519f5-6f5a-4639-820f-999fe1631375"), "Boris91@yahoo.com", false, new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08") },
                    { new Guid("bf6e1cef-5b67-42ab-88b4-c412adf25bca"), "Yoshiko_Brakus32@hotmail.com", false, new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("bfb04dcc-9e52-4f92-bb15-ef0cef3c5ab4"), "Westley.Emard@yahoo.com", false, new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("c068dca7-5cc0-4896-8931-71c8bcfb1767"), "Obie.DAmore@gmail.com", false, new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("c0dd6fdf-1f7d-4d29-9f19-52ac68ff5c07"), "Madyson99@hotmail.com", false, new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("c10a81d7-2c0d-4716-aca9-2e0c5d221aae"), "Elenora.Shanahan@gmail.com", false, new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("c1138159-0cc1-4591-93bd-6161cea89d68"), "Rosa_Macejkovic34@hotmail.com", false, new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("c172866b-00b0-4181-ac6f-f1a73aca2c0d"), "Idella.Bednar92@hotmail.com", false, new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("c1c94d7d-a309-4e8a-8c8e-92a4f44106cd"), "Aron_Gutmann40@gmail.com", false, new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232") },
                    { new Guid("c21a9bc4-b5a9-43e8-beaf-cdd7afe41fbb"), "Amalia_Boyer77@hotmail.com", false, new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("c26b6323-1d87-4c0c-af97-5d23707f0beb"), "Kenyatta_Armstrong@yahoo.com", false, new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a") },
                    { new Guid("c2711df1-c456-442e-869d-628c8ba3db89"), "Nikita25@hotmail.com", false, new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("c28ea0ad-1d8c-46d9-b49f-658d954469ac"), "Ethan.Okuneva89@hotmail.com", false, new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66") },
                    { new Guid("c2ac41df-af19-41d6-b14b-f712fcaac6ab"), "Orion67@hotmail.com", false, new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("c2ecf883-f94d-4507-8618-c4379697feeb"), "Pinkie.Spencer45@gmail.com", false, new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("c329b2a8-2465-43d8-bf30-46cff33ff50e"), "Susie27@gmail.com", false, new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("c34f7163-4cbb-4c4e-aac4-585a5c0128c7"), "Emelia.Parisian@yahoo.com", false, new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("c411b0ad-091e-496c-88f9-8d80160ccb48"), "Francisco80@hotmail.com", false, new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("c4a8d8c9-cbe3-4035-b4a5-1327ac5276d0"), "Simone_Maggio@yahoo.com", false, new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae") },
                    { new Guid("c4fba597-62fb-4d4e-bf83-01f84fc4b283"), "Arvel.Cummerata@hotmail.com", false, new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("c6b03f4d-1212-4393-80a5-07189ef694ef"), "Kirsten11@hotmail.com", false, new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("c6e328d2-1e65-4594-9217-163763dada0d"), "Charley_Weimann@yahoo.com", false, new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a") },
                    { new Guid("c762c5ba-ead9-4bdc-8110-e1247c6ce0b4"), "Jamie_Cassin7@gmail.com", false, new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("c772e8e7-8d73-4348-9210-414a15d22a63"), "Orville_Cummerata@gmail.com", false, new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("c7aa6993-5fa8-43cc-872b-b3924bdb72a1"), "Kyle88@hotmail.com", false, new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("c9299280-e759-401a-9425-342f7426e300"), "Tomas_Kreiger@hotmail.com", false, new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("c97a1368-509e-40b0-b9b5-00e0063008b5"), "Alysson_Harvey66@hotmail.com", false, new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("ca0c8997-89c8-450a-9e1c-046ae029f48c"), "Violet.Lowe@yahoo.com", false, new Guid("63f59de1-31f5-4826-bae2-9494ab073e70") },
                    { new Guid("ca5bd5e4-9a02-4e97-b465-73e2121de93f"), "Anthony43@yahoo.com", false, new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430") },
                    { new Guid("caab05b5-0952-44a3-a5e5-0acfdb4fb1c3"), "Dolores83@yahoo.com", false, new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("cb1c96dd-5c37-427e-aa5f-e5f199b6b24c"), "Shannon34@hotmail.com", false, new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("cb72109a-19e2-483a-a65b-1d1576fa1e60"), "Raleigh_Robel48@hotmail.com", false, new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("cbab4e44-8e2e-4cf7-a2aa-5594b270f64a"), "Otto.Raynor@yahoo.com", false, new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("cbcee176-8131-4c33-bced-426ec9bbb1e7"), "Corene_Hirthe@yahoo.com", false, new Guid("48f78165-0368-457a-a33f-c7c330b9016e") },
                    { new Guid("cbe1cf9e-a243-40b4-9ec1-318bb883898a"), "Ardith31@hotmail.com", false, new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("ccf5e3ba-1139-4f93-a71a-a2519edf89c4"), "Guiseppe_Dooley73@gmail.com", false, new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("cd0990b7-c8e6-4b6d-bf72-ae88915aa462"), "Elyssa.Kunze34@yahoo.com", false, new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("cd253e0a-a938-459a-94a8-92749ea46e52"), "Lisette42@hotmail.com", false, new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("cd791360-e267-4f06-8527-b98aac8bf4f3"), "Joanny_Volkman29@yahoo.com", false, new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("cd7b155c-b8ff-44cf-9871-ba244ad57caf"), "Dejuan30@yahoo.com", false, new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("cd7b28b3-3fca-4dfd-a3f7-9468c66c2bfd"), "Elvis_Wuckert@hotmail.com", false, new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("cd7f0991-3232-47fe-b7a9-0ff42f3f835b"), "Coty_Hermiston@hotmail.com", false, new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("cdb15e69-e7d9-4b2e-b989-cf82f3990b75"), "Zakary.Lueilwitz@gmail.com", false, new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("cdbf6061-43ef-4d7e-8fa1-3a41b9a1bdbd"), "Brycen_Batz39@yahoo.com", false, new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77") },
                    { new Guid("ce30e7a6-03b3-4872-a7b2-feb49c355907"), "Dusty20@yahoo.com", false, new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8") },
                    { new Guid("ce5c60d2-70a7-4d5c-9fe2-899da8a22811"), "Derick70@gmail.com", false, new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("ce632a09-e455-4202-9896-ef1e71fad4f7"), "Luigi.Beier85@yahoo.com", false, new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("cea2b3c8-8bd8-4a0f-ad75-81f3dbed1e83"), "Howard_Sanford37@hotmail.com", false, new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("ced3a496-a65f-4c0b-8b87-0a1d7183a6f8"), "Cory22@yahoo.com", false, new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("cee294e8-05e2-4fde-9ce2-59ca96ab7858"), "Pablo_Kuhn20@gmail.com", false, new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3") },
                    { new Guid("cef25248-ba1e-47e2-bd88-2d656f9cab3c"), "Matteo93@hotmail.com", false, new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("cf0daad0-3ed1-45a7-888d-fddce3fed76e"), "Frederique.Will@yahoo.com", false, new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("cf266fa5-53e2-4d54-9c2d-d2efc552e586"), "Kristofer.Hansen@gmail.com", false, new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66") },
                    { new Guid("cf63d36f-04c0-485d-8ef3-9d72f62a2c58"), "Rodger10@hotmail.com", false, new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95") },
                    { new Guid("cf8899e9-6bcb-4990-b9ae-39a5dc5f2236"), "Moriah41@hotmail.com", false, new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("cf930aae-7196-4592-ab31-9790f1979fed"), "Zula_Shields82@gmail.com", false, new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("cfc0db93-958f-4efb-b645-8e8cee125811"), "Eduardo_Hansen@gmail.com", false, new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("cff27cf4-cc97-4a7f-901f-f71c72867e1d"), "Tracey_Flatley67@hotmail.com", false, new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("d0646d23-ab24-42f9-8c78-134e4f065473"), "Frida83@gmail.com", false, new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("d0dc9997-8ce3-425d-b852-0cb50541cbfc"), "Christa.Hammes86@hotmail.com", false, new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("d2e84489-d728-4ace-ab5c-1d48eb5aca43"), "Jabari4@yahoo.com", false, new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("d2f6bbb0-5772-47e7-88d3-de2364c063ab"), "Breanne_Spinka@hotmail.com", false, new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("d35a03c3-bdce-42c8-a754-1b81ff5f81af"), "Ellis9@yahoo.com", false, new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385") },
                    { new Guid("d3613c73-7363-4114-a7b0-0a7186f7cbb1"), "Ahmed11@gmail.com", false, new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8") },
                    { new Guid("d3b94ec1-e9cb-4a26-bd8d-76d1a28d696d"), "Gabrielle86@gmail.com", false, new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("d3c3c0f7-f647-4705-af5a-60107fd21118"), "Reyna_Harber71@yahoo.com", false, new Guid("5f081f26-af78-4d3a-b693-1268567854c9") },
                    { new Guid("d3d1308b-2e83-48f3-bde2-6575f74ba9eb"), "Renee_Corwin@yahoo.com", false, new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732") },
                    { new Guid("d4512cf8-75b9-447f-af57-226dc1812860"), "Keagan82@gmail.com", false, new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8") },
                    { new Guid("d4fcff08-c5b9-4c3d-8dc9-9b8f389fe9ef"), "Noel47@yahoo.com", false, new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("d5178e86-9d96-46fe-bb92-dd2a5d02aad7"), "Meghan.Renner8@yahoo.com", false, new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("d572999c-0d20-4f25-b362-a22c7a1822c5"), "Jean50@gmail.com", false, new Guid("988291f5-f421-4687-aafa-58e64481070f") },
                    { new Guid("d5db0876-fa2b-4f61-a6fa-dc43804058fb"), "Ella88@gmail.com", false, new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("d5e6fdc7-d600-4f96-9c64-c9957cb6ddcf"), "Larissa_MacGyver@hotmail.com", false, new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("d5f23d8a-e44c-464a-977f-17e63bb0a747"), "Guido_Tromp18@hotmail.com", false, new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d6a346e5-a6c9-4db6-946b-3ae8cded1b25"), "Roselyn.Pollich@gmail.com", false, new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("d6c41423-47f2-4b53-b7c5-a57216f1347f"), "Korbin_Johnson14@yahoo.com", false, new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") },
                    { new Guid("d72c1d17-a20a-45ae-a92c-96d3e4c8d86a"), "Jose_Gibson@hotmail.com", false, new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646") },
                    { new Guid("d733cd9c-c08c-4639-8c79-9fd29a87a243"), "Eleanora.Schinner70@yahoo.com", false, new Guid("7613a4be-1868-4124-8145-c559fd0b8b95") },
                    { new Guid("d7410644-71be-43be-b459-e2f428e33cf4"), "Sabryna.Zulauf53@yahoo.com", false, new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7") },
                    { new Guid("d76105d4-85c8-4c08-a6c6-96255f31b14e"), "Emma_Lehner43@yahoo.com", false, new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("d77c10dc-9786-4aba-9469-c8edad6bdaeb"), "Gerson.Leannon33@yahoo.com", false, new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("d78d65f3-5b4d-4544-91bc-e53157f313ed"), "Tyrese_Kessler46@hotmail.com", false, new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("d7c0ae31-4f38-485f-bf6a-56076b520502"), "Alexis8@hotmail.com", false, new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("d7cda854-cd03-4c25-a00f-2300f5fb279d"), "Ahmed.Leuschke89@gmail.com", false, new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("d838ac03-b31a-4e04-830f-75c88b598566"), "Dejon30@yahoo.com", false, new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("d85ac755-8d49-4f1c-8dfa-0aa44df74ad2"), "Ova_Lehner75@yahoo.com", false, new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95") },
                    { new Guid("d894d555-2155-457c-ad90-647ab4e3ad0d"), "Madonna7@hotmail.com", false, new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("d8a5b50c-dcb2-472e-8785-f4ce343fa45e"), "Lexus_Ankunding20@hotmail.com", false, new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6") },
                    { new Guid("d8f19b9a-5e3e-4196-9d09-b8a68152d6d0"), "Garret_Monahan@hotmail.com", false, new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e") },
                    { new Guid("d95f79ae-6b7f-4cdc-9425-a51cbf7954ac"), "Alvina93@hotmail.com", false, new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("d9dac874-1e05-4176-99be-237c6047e908"), "Jaylan.Beahan@yahoo.com", false, new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("d9fbea85-6059-4bb1-b6dd-2a5bb4a189a4"), "Laurianne_Ritchie@gmail.com", false, new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919") },
                    { new Guid("da12cc3f-ad89-40f9-a64e-217f856f36c1"), "Clarabelle_Herman69@hotmail.com", false, new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("da84f394-30b0-43ea-b97d-22388420d706"), "Francesco_Collins@yahoo.com", false, new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524") },
                    { new Guid("da95b7de-5ecf-4ac0-bc5a-a0b06657592d"), "Creola58@hotmail.com", false, new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("daa6824f-aa77-426d-b108-c22ff31a81e6"), "Shyanne_Moen41@yahoo.com", false, new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("dab47fce-6226-4f30-8b07-17c008030505"), "Caitlyn10@gmail.com", false, new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("daba29f0-88df-488c-b72d-d975cec7d58e"), "Anastacio38@yahoo.com", false, new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("db8bd5f9-5358-46a8-b9a6-33f1b3910010"), "Rusty90@gmail.com", false, new Guid("31995843-45fb-4fd4-bf87-4209bd790c02") },
                    { new Guid("db8bdc96-6ac7-4602-ac53-86395e854f3d"), "Randi11@hotmail.com", false, new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2") },
                    { new Guid("dbca3bd2-41e2-489d-8ce6-9e6a1c96a102"), "Gladys.Wolff@gmail.com", false, new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e") },
                    { new Guid("dbe950da-e3fe-4cb5-b10c-17eb4b788472"), "Aliyah_Waters@gmail.com", false, new Guid("a548d594-0e72-40b8-a222-3504b474972b") },
                    { new Guid("dc2766e1-cf26-417b-92d4-3f757c30f913"), "Ozella.Mante82@yahoo.com", false, new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("dc770568-7045-41de-ac13-9e798c184299"), "Hyman41@gmail.com", false, new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("dc97e8dc-fa0b-44cd-9461-b74f9784d622"), "Efrain.Olson10@gmail.com", false, new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4") },
                    { new Guid("dc994ba6-80da-4449-8a6d-182c6a087fe7"), "Frida_McClure@yahoo.com", false, new Guid("4f18c06d-9e38-4392-a135-68af41671c23") },
                    { new Guid("dcd1c1b3-b56a-4e5d-8f5b-db2c80f0b1d9"), "Maud.Bartell@hotmail.com", false, new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("dd0f8be8-e63e-4cd8-a8db-ba889606f7e8"), "Gudrun15@hotmail.com", false, new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919") },
                    { new Guid("dd22568b-fdcf-4333-9c56-bf08525e70ba"), "Halie_Dibbert49@hotmail.com", false, new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12") },
                    { new Guid("dd2fa756-cc2b-465e-8a62-84a521b2e2bd"), "Maryjane.Purdy@yahoo.com", false, new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206") },
                    { new Guid("dd45d6d6-a0ce-4212-b120-67579be4bf29"), "Cora41@yahoo.com", false, new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("dd4fb478-9b5e-4a86-a57c-b690ea3ecb7a"), "Isobel.Shields94@yahoo.com", false, new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("dd934fc8-5fb0-4a9d-aa73-b0a399ab49f0"), "Chris95@hotmail.com", false, new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("dd99b543-9c05-4feb-83db-34a88fa0f641"), "Nona45@gmail.com", false, new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("ddb5750b-8b5b-4129-b7ab-7918d106132f"), "Gracie.Price76@hotmail.com", false, new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("de57934e-1d1f-4fac-a85d-7553db1b6b07"), "Ena_Balistreri@gmail.com", false, new Guid("48fec127-ff7b-4341-9417-71a573651f92") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("de7b371f-61eb-4aa7-a998-f527d250a791"), "Gracie81@yahoo.com", false, new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("df05f55c-d20b-4412-abb5-790e0ddf5e52"), "Humberto_VonRueden21@yahoo.com", false, new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33") },
                    { new Guid("df302f60-1817-4d05-90bb-9a442c237eeb"), "Nya12@hotmail.com", false, new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("df545770-bd65-4550-b661-c154056bd65d"), "Eli.Strosin@gmail.com", false, new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("df565053-672c-4000-a83a-a4ba2d922524"), "Kamryn_Stoltenberg@hotmail.com", false, new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("dfb5966b-6b60-4693-bc0b-a337313737b1"), "Naomi_Doyle@gmail.com", false, new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("e07818b0-84ab-4cfe-a8fe-c3e159a734ca"), "Kellie76@yahoo.com", false, new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("e10909aa-c68a-43f0-8759-b067a4ff689a"), "Terry.Haley@yahoo.com", false, new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("e156f8c5-7cd7-475f-98bb-e9288dec62fa"), "Cleora52@gmail.com", false, new Guid("f6425efe-44a9-4764-877a-c0d313b88196") },
                    { new Guid("e1b09a28-f4fa-4c62-af68-560b8cced36d"), "Giovanna.Maggio53@gmail.com", false, new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("e1c3950b-3671-40a2-921b-ccf4359538c5"), "Hadley.Sanford95@hotmail.com", false, new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2") },
                    { new Guid("e1fb77b7-4911-4353-881d-b3497c6badff"), "Hal66@gmail.com", false, new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("e2143567-eaa8-4245-8249-45801ea7da79"), "Dillan_Sanford11@hotmail.com", false, new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826") },
                    { new Guid("e2ac5780-9ef7-4f04-8142-4846203fd15b"), "Bradley_Hane13@yahoo.com", false, new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9") },
                    { new Guid("e2cb33df-e66e-41e6-861d-dc5a44655c00"), "Crystel.Quitzon@gmail.com", false, new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("e3136a8e-ad36-4708-ad9b-4b81047a9162"), "Guadalupe91@yahoo.com", false, new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("e32d9575-c674-41c1-bf87-95e0f53dc06b"), "Jerald2@hotmail.com", false, new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0") },
                    { new Guid("e3767f32-8665-4a4c-b974-555d7d168ac4"), "Aryanna.Stark@gmail.com", false, new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("e38b0f26-d0d3-4419-9e23-fcd46b285762"), "Eriberto_Littel@hotmail.com", false, new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("e38da9f2-56b2-4326-9a38-e7b0f290dd3a"), "Jayde92@hotmail.com", false, new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10") },
                    { new Guid("e3b8dd5d-e7fd-4e3f-b86e-a3bf60166e37"), "Sheldon_Schuppe39@gmail.com", false, new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("e3d14b85-0cab-46ab-b20d-b70397d71577"), "Green_Brakus@hotmail.com", false, new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("e4190d60-d83a-420d-bf37-2c59754bdc38"), "Ocie50@gmail.com", false, new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e") },
                    { new Guid("e487117d-07cb-41e3-bdbc-f4ad02db14c4"), "Gail_Reichel@hotmail.com", false, new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f") },
                    { new Guid("e4bd5403-a759-4e5f-8cd5-70e8624dc651"), "Viola20@yahoo.com", false, new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("e4e6c6ae-0b08-429e-a09c-e5a09833a119"), "Monte84@gmail.com", false, new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("e5e7abf1-1d69-430f-8845-c785347a1670"), "Kurt.Frami77@gmail.com", false, new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") },
                    { new Guid("e61096d6-44d6-4be0-abf3-c67af00f531a"), "Jimmy_Franecki65@yahoo.com", false, new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("e690465a-622f-4ec7-94b3-8ee841c57d0a"), "Adrain_Daugherty@yahoo.com", false, new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("e70dc57f-9841-4a2a-9e60-bed0878b4629"), "Bonnie_Miller@yahoo.com", false, new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("e7169f7a-80f6-4039-9e2c-0747a0af776b"), "Edgar_White25@gmail.com", false, new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("e720eb2d-1c81-4c47-907e-42ce2b92ea85"), "Meda_Corkery@yahoo.com", false, new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("e73cde56-4e15-4e60-a2e2-d087f9005610"), "Quentin.Schinner@yahoo.com", false, new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524") },
                    { new Guid("e7ac4eb8-a6ed-4838-95be-9e532a750ca8"), "Cristopher.Nicolas@gmail.com", false, new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("e7f4f28e-f08c-4908-afa5-44d3d5883e4a"), "Jedidiah_Fahey@gmail.com", false, new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("e80335cf-6d7e-4e5d-a73d-979c359fc51b"), "Clement7@gmail.com", false, new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764") },
                    { new Guid("e850e382-3d49-4e56-b5e6-148634ddc8ba"), "Prince99@gmail.com", false, new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("e854b5aa-e7ff-4b9a-a3f5-8f1a2551ca71"), "Jerrod.Oberbrunner@yahoo.com", false, new Guid("b34e9d23-9b12-49b3-b069-734a50918afc") },
                    { new Guid("e85f120c-4b72-4ef7-b035-25e4f826cf89"), "Ron_Jerde39@gmail.com", false, new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("e873dcb5-78a9-4c8f-8e1a-5d87de9e6140"), "Heber44@yahoo.com", false, new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("e88af198-2ad8-4b22-b27b-ce5e6256ed06"), "Kiana24@gmail.com", false, new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("e90f9236-01b2-402d-a379-f9c5cd680c21"), "Sheila_Hand@gmail.com", false, new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e957fca5-0573-419a-9fb9-d790f4fa6877"), "Austin4@gmail.com", false, new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("e97a0d08-771e-49ed-a20d-432f8c88f994"), "Gladyce_Kunze20@yahoo.com", false, new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("e98e8f21-87fd-42da-af9a-d523df986d7e"), "Hulda_OHara1@yahoo.com", false, new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08") },
                    { new Guid("e994774f-2ad5-4b31-aa4d-f6821deac638"), "Nettie_Hoppe50@yahoo.com", false, new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("e9d46aa1-b1e6-4745-bb0f-1baefb4256ad"), "Kianna5@gmail.com", false, new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("e9f71cd0-8fc4-4331-a4fe-cc8de206faeb"), "Maryam.Funk94@gmail.com", false, new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8") },
                    { new Guid("eae5f8fd-d125-4970-bdd4-f5765551694e"), "Genevieve87@gmail.com", false, new Guid("f8331316-2615-4a9c-aac6-3bc582886724") },
                    { new Guid("eae7e899-d5a8-4438-8e51-ceadb954ff2a"), "Domenic61@hotmail.com", false, new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("eb0445a9-a174-4188-8df2-c0287a3fac08"), "Zena97@hotmail.com", false, new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("ec7feca8-376f-49b5-8545-6e2f3919c78c"), "Greta16@hotmail.com", false, new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("eca7674a-69b0-4bf0-8b0f-46113b080b73"), "Zoila51@gmail.com", false, new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("ed27dee9-eb64-4a74-9824-21d1def5baa5"), "Terrell.Funk@hotmail.com", false, new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("ed4bc379-5b26-4b3c-809b-11dd5f460ef4"), "Arvilla_Sanford@gmail.com", false, new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("edf5afe7-b8f4-4b05-815e-7e6e6f27c75c"), "Wyatt69@yahoo.com", false, new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("ee42f61d-9f0e-4e45-bebc-cfa48554643c"), "Jarret.Mosciski46@gmail.com", false, new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("ee6874b9-6172-4e06-aaf0-186d69c064b6"), "Katlynn.Lindgren10@yahoo.com", false, new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("ee8c9892-48a6-4960-a6e9-d6fafdd0c058"), "Lolita.Bosco13@yahoo.com", false, new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8") },
                    { new Guid("ee92066c-bf19-4833-bef1-7dbd4a735bb8"), "Jimmie6@gmail.com", false, new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2") },
                    { new Guid("eed684cd-aa87-4ab6-9570-5948fca44cbb"), "Zachery.Schuppe@yahoo.com", false, new Guid("29ab604b-7a76-439b-8129-93142c9b6cee") },
                    { new Guid("eef9c144-8682-483a-a219-f29e7efd5fd2"), "Rasheed.Klein@hotmail.com", false, new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("ef8c51f1-ca55-4f2d-9798-65564f8b268f"), "Linda_Zboncak43@yahoo.com", false, new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("efa10b07-76d9-4172-b87a-6303773cc6ab"), "Zion60@yahoo.com", false, new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("efdd4c43-e9e6-4e44-abdd-f5d9cf75f55a"), "Leanna74@hotmail.com", false, new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b") },
                    { new Guid("f0390e23-fed0-4e99-bd63-c8c505719742"), "Rosendo.Kiehn@hotmail.com", false, new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("f046a3ca-a6ed-4528-81ff-b3f3f7b5cb49"), "Garnett76@gmail.com", false, new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("f0e37bfe-161f-4829-872b-957ec6bdc766"), "Adah.Padberg2@gmail.com", false, new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("f114cc81-a371-4abb-bbf3-86d1fd871c3a"), "Margie87@hotmail.com", false, new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("f1aa0f7c-4b64-41f6-8153-c31b5959fd78"), "Adolphus_OReilly@gmail.com", false, new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("f1b6a1d2-f013-4457-8755-8d415b9b7e0e"), "Carli_Bechtelar67@yahoo.com", false, new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("f290cafd-67f1-4691-b9f0-02099e94ff20"), "Jermey_Price26@gmail.com", false, new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("f2c32594-798f-4ace-a151-92203e715d26"), "Chelsey55@gmail.com", false, new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("f2cecab2-2546-421e-9e78-f54381720996"), "Serenity83@hotmail.com", false, new Guid("60de2347-d620-407d-9699-3b783da3d34d") },
                    { new Guid("f3082548-b28e-4540-abb4-c526584f83c1"), "Athena_Kihn97@gmail.com", false, new Guid("f33ed058-0d5e-4f28-8270-398f55394914") },
                    { new Guid("f3dfd577-e982-4494-9550-4a526df14b99"), "Nora.Sporer71@yahoo.com", false, new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("f3e43f6f-24b4-468f-8252-64012d2a1eb3"), "Giles_Waelchi84@hotmail.com", false, new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("f433943f-07a2-47a3-be54-59aebddf5eac"), "Franco.Ondricka36@gmail.com", false, new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("f434b189-4219-42ff-bf7a-34713ab38348"), "Toby15@hotmail.com", false, new Guid("ff032668-ac2d-465e-a8be-49991c69a967") },
                    { new Guid("f43a0461-91fe-4259-a293-2092f39e704f"), "Ozella.Wisoky54@hotmail.com", false, new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413") },
                    { new Guid("f4e41334-b45b-4723-9a6c-0aebfb6524ca"), "Leta85@gmail.com", false, new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("f513979e-c2a3-42f3-978e-af41564d1e54"), "Casimer47@yahoo.com", false, new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9") },
                    { new Guid("f55d1e98-326a-4d5e-a692-5dc4cea99436"), "Joyce.Lang42@gmail.com", false, new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e") },
                    { new Guid("f5b9c6ec-9282-4808-9412-df696f866656"), "Kendall88@yahoo.com", false, new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f62ddf56-67ec-413e-9e6e-387261669e45"), "Waino67@gmail.com", false, new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6") },
                    { new Guid("f6360435-7f10-4ab5-9ba0-979f225d120a"), "Margie.Adams83@yahoo.com", false, new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("f71e5718-c77a-4b49-81cd-1391f9649b30"), "Anika_Howe@hotmail.com", false, new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7") },
                    { new Guid("f72b3703-f45d-4177-890f-3703435b09f7"), "Vanessa65@gmail.com", false, new Guid("feeae310-c37b-49b5-b035-e9098493766b") },
                    { new Guid("f740c52c-8830-484c-b6ec-f5fc62945e14"), "Lisette.Marquardt83@yahoo.com", false, new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("f74db932-282b-4341-8fd8-3a80822337c6"), "Vivianne39@hotmail.com", false, new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0") },
                    { new Guid("f82727ac-ac2f-46f6-804a-6f07a0d77120"), "Kade_Hintz@gmail.com", false, new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("f8e317c5-151d-4d53-af70-e0e525c11abd"), "Kaci_Corwin48@yahoo.com", false, new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("f998d52b-7e7e-449f-bb3b-dc18d49380ea"), "Rachelle88@yahoo.com", false, new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("f9ecd82e-eeb6-467b-8fb0-d338a0087750"), "Letha18@hotmail.com", false, new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91") },
                    { new Guid("fa74d93b-6212-4eda-a82b-0eef36b54e29"), "Leanna_Klein38@hotmail.com", false, new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("fb03e7bc-16ad-44b3-9192-c589674f24e0"), "Maya13@hotmail.com", false, new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("fb115464-dae3-405c-bd62-1bb27b43e507"), "Edgar.Christiansen@gmail.com", false, new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("fb1a938b-4611-4883-8551-905cb9888ddb"), "Maya.Mann6@yahoo.com", false, new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("fb2b72bc-f90a-4309-8b0d-40ed05e1c711"), "Diego71@yahoo.com", false, new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("fb359553-b9a6-4fdc-b283-a8c8aa20ee1a"), "Kristy55@hotmail.com", false, new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("fb5886bf-09b1-4ebc-a3fe-36258ae4360e"), "Prudence_Prosacco87@yahoo.com", false, new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("fb5a40ca-420d-4284-9ffe-d67c958b276b"), "Reginald_Sporer@hotmail.com", false, new Guid("6bd6126d-6465-493b-abdc-935b7afbc646") },
                    { new Guid("fb6307ec-dc16-41af-895f-919ff4bd0513"), "Santos19@hotmail.com", false, new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("fbc9172b-9668-476d-b5b9-600e7b912065"), "Emanuel.McCullough3@yahoo.com", false, new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("fc2cbffa-fc1e-4194-a5bb-785d64b782f5"), "Maymie.Leffler87@hotmail.com", false, new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("fd236ccc-0455-4823-b090-3e67ce0ca743"), "Milford63@yahoo.com", false, new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("fd4082f3-a760-4736-9170-2f65a98d9a0e"), "Jessie_Corkery@hotmail.com", false, new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("fdc53762-1a48-4910-bdaa-70deea1f8ecf"), "Alia30@hotmail.com", false, new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("fdcdcce3-881d-4ff6-a14d-8629e1afda98"), "Oda38@gmail.com", false, new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("fdfe216b-2a60-49b5-b383-467c4733a24e"), "Kelsi.Roob39@gmail.com", false, new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("fe3871b8-ef91-46d4-9616-6438e1338268"), "Delphia_Jacobs@hotmail.com", false, new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("fedaa21e-afcd-49a1-8331-d48c326c931b"), "Claire_Collins84@gmail.com", false, new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("fedd36b5-c9c3-4408-a4ac-f46ba3c04dce"), "Jaclyn36@hotmail.com", false, new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("feee3814-380c-40de-941f-f601a71c982b"), "Gregory72@gmail.com", false, new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("ff926b2b-729f-4ae0-9729-1179fc746da8"), "Gerald_Gusikowski@yahoo.com", false, new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("0af40592-4722-427a-80f3-b09b82674eb9"), new DateTime(2024, 2, 9, 19, 8, 47, 467, DateTimeKind.Local).AddTicks(9016), new DateTime(2024, 2, 12, 19, 8, 47, 467, DateTimeKind.Local).AddTicks(9016), 90.75m, true, 4079325509104084m, true, "Super", 5, 41.82295f, "225 Melody Stream, North Patience, India", new Guid("914a9168-2743-43d3-9989-0d61085f953c"), "178 Beer Drives, New Kenya, Macedonia", new Guid("60de2347-d620-407d-9699-3b783da3d34d"), "OnTheWay", "PlasticBag" },
                    { new Guid("0b64875d-16f5-4c62-9133-148a52ee3d5d"), new DateTime(2024, 1, 1, 1, 42, 57, 321, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 1, 6, 1, 42, 57, 321, DateTimeKind.Local).AddTicks(2204), 27.91m, true, 3379072498549380m, true, "Standart", 3, 44.352318f, "55118 Wisozk Canyon, Mayertview, Bahamas", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f"), "50074 Winifred Stravenue, Goodwinmouth, China", new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8"), "Sent", "CardboardBox" },
                    { new Guid("0e471c78-70a9-4734-beac-e20314cd4150"), new DateTime(2024, 5, 13, 15, 11, 11, 843, DateTimeKind.Local).AddTicks(8936), new DateTime(2024, 5, 21, 15, 11, 11, 843, DateTimeKind.Local).AddTicks(8936), 82.47m, true, 4482011635694471m, true, "Super", 4, 35.8087f, "034 Pasquale Underpass, New Domenick, Guam", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b"), "854 Kacie Brook, Olsonfurt, France", new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385"), "Delivered", "PlasticBag" },
                    { new Guid("11706868-fa83-4eab-9179-170a94060151"), new DateTime(2023, 6, 14, 6, 20, 53, 912, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 6, 19, 6, 20, 53, 912, DateTimeKind.Local).AddTicks(9950), 76.09m, true, 1845182061401192m, true, "ParcelMachine", 1, 39.888916f, "526 Grace Curve, Port Emmett, Norfolk Island", new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7"), "445 Ondricka Station, Edwinaburgh, Samoa", new Guid("5d96609e-242a-4e81-841d-15924cb829f7"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("16c94dc1-e835-46ae-b9b6-72418f160134"), new DateTime(2024, 2, 6, 8, 22, 53, 294, DateTimeKind.Local).AddTicks(6457), new DateTime(2024, 2, 10, 8, 22, 53, 294, DateTimeKind.Local).AddTicks(6457), 67.22m, 8403897578319891m, true, "Courier", 4, 21.63848f, "655 Leonora Ways, Kossborough, Iran", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337"), "8173 Jerde Heights, Orenshire, Kiribati", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1a3a642b-4271-4350-a644-2921e3470aa7"), new DateTime(2023, 7, 30, 11, 18, 40, 475, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 8, 1, 11, 18, 40, 475, DateTimeKind.Local).AddTicks(2830), 46.92m, true, 4894218468906684m, "Special", 2, 39.3319f, "9531 Hilda Center, Lake Domenico, Guatemala", new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6"), "3494 Skiles Port, New Ritamouth, Pakistan", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1ddc6a31-f1e3-4e0d-bf61-46082a069e6e"), new DateTime(2023, 11, 24, 10, 1, 0, 979, DateTimeKind.Local).AddTicks(4917), new DateTime(2023, 11, 30, 10, 1, 0, 979, DateTimeKind.Local).AddTicks(4917), 45.70m, true, 2789877046957568m, true, "ParcelMachine", 2, 4.5872235f, "98873 Goyette Cliff, South Garry, Venezuela", new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df"), "4078 Mathias Isle, New Eliview, Bahamas", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1eb85129-773a-41af-a884-b92c9593a631"), new DateTime(2023, 8, 1, 6, 7, 34, 401, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 8, 4, 6, 7, 34, 401, DateTimeKind.Local).AddTicks(3196), 99.39m, 2347688916320764m, "Courier", 1, 39.966305f, "25777 Bianka Expressway, Chrismouth, Puerto Rico", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7"), "0364 Waelchi Ports, South Gay, Zimbabwe", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1f7829bb-971a-4ec6-ba85-62b15300b810"), new DateTime(2023, 9, 11, 2, 51, 55, 921, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 9, 18, 2, 51, 55, 921, DateTimeKind.Local).AddTicks(3222), 52.81m, true, 3731557946658220m, "Standart", 3, 42.183388f, "9920 Armstrong Key, Port Lucychester, Vanuatu", new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a"), "81391 Turner Mall, Emardfurt, Netherlands Antilles", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("21822129-2323-49c6-9ec7-c0eb4996a278"), new DateTime(2024, 5, 7, 14, 19, 3, 526, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 5, 12, 14, 19, 3, 526, DateTimeKind.Local).AddTicks(3904), 28.05m, true, 2120199126996067m, true, "Super", 5, 34.08338f, "8330 Goodwin Cape, Leoraview, Zimbabwe", new Guid("3162f344-f10f-45da-971c-d41cc675f838"), "954 Hamill Camp, East Lea, Saint Vincent and the Grenadines", new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2311c675-34d8-492e-8c4e-208a310530b9"), new DateTime(2023, 9, 27, 0, 52, 34, 290, DateTimeKind.Local).AddTicks(8588), new DateTime(2023, 9, 29, 0, 52, 34, 290, DateTimeKind.Local).AddTicks(8588), 49.98m, 5278160927413886m, true, "Courier", 2, 31.180912f, "718 Lenna Brooks, Parkerside, Hong Kong", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), "9625 Stiedemann Prairie, South Jocelyn, Chile", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("23dc31a0-33a9-4b28-aadb-d3dc4e5ea21f"), new DateTime(2024, 2, 8, 6, 51, 52, 32, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 2, 17, 6, 51, 52, 32, DateTimeKind.Local).AddTicks(4920), 39.11m, true, 7932063580804351m, true, "Courier", 3, 12.282734f, "355 Oberbrunner Lake, North Autumn, Palau", new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6"), "66632 Block Inlet, Dannyton, Pakistan", new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("24b7549a-b419-4703-bea2-9eb83d0e0ba5"), new DateTime(2024, 3, 1, 23, 27, 51, 520, DateTimeKind.Local).AddTicks(5872), new DateTime(2024, 3, 4, 23, 27, 51, 520, DateTimeKind.Local).AddTicks(5872), 60.08m, 3050998418256371m, "Super", 4, 22.872238f, "70236 Domenick Streets, Tanyaborough, Haiti", new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf"), "2465 Gutmann Glen, West Clementine, Barbados", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("29f0f1a4-3e29-4ca3-a7f8-cd451866673e"), new DateTime(2024, 3, 7, 10, 31, 53, 404, DateTimeKind.Local).AddTicks(5754), new DateTime(2024, 3, 17, 10, 31, 53, 404, DateTimeKind.Local).AddTicks(5754), 18.81m, 7453561322084373m, true, "Super", 2, 44.587963f, "1949 Koelpin Islands, Port Roma, Hungary", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f"), "19065 Arnold Overpass, Tylershire, Kuwait", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2b20c13e-7413-4136-816b-c954f4e3bdcc"), new DateTime(2023, 7, 17, 2, 58, 12, 706, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 7, 20, 2, 58, 12, 706, DateTimeKind.Local).AddTicks(3608), 73.12m, true, 1324584153091415m, true, "Special", 1, 2.2805643f, "49592 Dooley Wells, Billieside, Indonesia", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea"), "638 Steuber Road, West Lilliana, Swaziland", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2c5185f9-9182-44af-bf64-d5b9ec753a6a"), new DateTime(2023, 9, 28, 20, 20, 27, 891, DateTimeKind.Local).AddTicks(9645), new DateTime(2023, 10, 8, 20, 20, 27, 891, DateTimeKind.Local).AddTicks(9645), 20.36m, 6433041345093865m, true, "Standart", 1, 22.850206f, "0408 Preston Causeway, Lake Aidenmouth, Kyrgyz Republic", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9"), "01457 Autumn Orchard, New Ginoshire, Niue", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2e630b0c-7af6-40eb-96bc-96dd7f0f8738"), new DateTime(2023, 9, 2, 8, 55, 18, 128, DateTimeKind.Local).AddTicks(9051), new DateTime(2023, 9, 7, 8, 55, 18, 128, DateTimeKind.Local).AddTicks(9051), 14.95m, true, 2301945555960718m, "Special", 2, 13.983399f, "9325 Frami Flats, Torphyside, Moldova", new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826"), "2321 Hulda Rapids, East Rodrick, Slovakia (Slovak Republic)", new Guid("d81428a8-c640-4761-b657-cfa05c180948"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2e76e705-9c68-4a46-b60a-01f4de2f78c9"), new DateTime(2024, 1, 20, 19, 13, 26, 531, DateTimeKind.Local).AddTicks(2722), new DateTime(2024, 1, 25, 19, 13, 26, 531, DateTimeKind.Local).AddTicks(2722), 51.95m, true, 4853040410542864m, true, "Super", 5, 39.576916f, "062 Bergnaum Highway, East Stephanfurt, United States of America", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea"), "607 Peter Summit, Port Liahaven, Slovenia", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2e8541d9-234f-42be-9a4e-bf48ce3be2f1"), new DateTime(2023, 10, 28, 14, 41, 12, 650, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 11, 4, 14, 41, 12, 650, DateTimeKind.Local).AddTicks(9112), 16.94m, true, 1161776794996824m, "Special", 2, 37.001328f, "330 Auer Circle, South Tavaresfort, Rwanda", new Guid("b34e9d23-9b12-49b3-b069-734a50918afc"), "04986 Wiegand Prairie, Creminmouth, Tonga", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2ef2a2bb-b514-46e6-bbcb-14f4fad8b7b3"), new DateTime(2023, 9, 30, 19, 53, 11, 788, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 10, 7, 19, 53, 11, 788, DateTimeKind.Local).AddTicks(3761), 39.74m, 6599243151286790m, true, "Courier", 4, 27.490843f, "1790 Roob Stream, Lacystad, Dominican Republic", new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e"), "208 Haley Lane, Lake Max, Bouvet Island (Bouvetoya)", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3963b598-e275-4c36-afa6-c981bfa647ae"), new DateTime(2024, 5, 24, 18, 9, 26, 736, DateTimeKind.Local).AddTicks(5891), new DateTime(2024, 6, 1, 18, 9, 26, 736, DateTimeKind.Local).AddTicks(5891), 60.48m, true, 6220511093090947m, "Special", 2, 13.654506f, "3549 Madge Course, Billborough, Guatemala", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e"), "929 Kaela Gardens, Crooksland, Falkland Islands (Malvinas)", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3d41b2e9-cf67-4c66-b4da-08a275144deb"), new DateTime(2024, 6, 3, 6, 10, 55, 489, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 6, 11, 6, 10, 55, 489, DateTimeKind.Local).AddTicks(8449), 35.94m, 1953300641233183m, "Standart", 3, 49.82445f, "1506 Krajcik Common, Lake Ryann, Peru", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797"), "5770 Hyatt Unions, New Deloreston, French Guiana", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4213fc5f-2167-44dd-af0d-29a48c77a224"), new DateTime(2023, 11, 2, 8, 0, 53, 457, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 11, 10, 8, 0, 53, 457, DateTimeKind.Local).AddTicks(6638), 82.63m, 7024151092481419m, true, "ParcelMachine", 2, 11.885919f, "6451 Lang Keys, East Clementinastad, Portugal", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c"), "1530 Carissa Estates, Schowalterfurt, Antigua and Barbuda", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("442c0bed-3e2b-461c-a4ba-49b4b0d59c47"), new DateTime(2023, 6, 14, 0, 55, 35, 138, DateTimeKind.Local).AddTicks(1925), new DateTime(2023, 6, 24, 0, 55, 35, 138, DateTimeKind.Local).AddTicks(1925), 45.90m, true, 2599909209200658m, true, "Super", 4, 6.9793487f, "73767 Macie Roads, Lake Florinefort, Germany", new Guid("36333093-6685-44ce-9e09-9007f88e766b"), "1913 Emmerich Manor, Stephaniaville, Costa Rica", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("461da226-834d-4ec8-b9ec-0774c5963ceb"), new DateTime(2024, 5, 9, 6, 52, 38, 665, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 5, 19, 6, 52, 38, 665, DateTimeKind.Local).AddTicks(9684), 30.44m, 3123717381933618m, "Special", 3, 9.231729f, "611 Lakin Stravenue, Hoegerfort, Czech Republic", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), "5102 McDermott Ferry, West Emeliashire, Russian Federation", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4b6fef58-0abc-4f20-90b8-6e27d1deb554"), new DateTime(2024, 4, 30, 9, 30, 29, 419, DateTimeKind.Local).AddTicks(7603), new DateTime(2024, 5, 1, 9, 30, 29, 419, DateTimeKind.Local).AddTicks(7603), 80.26m, true, 1050107339070485m, true, "Super", 3, 36.590965f, "83218 Beatty Forks, Ryanton, Northern Mariana Islands", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd"), "358 Humberto Trace, Makennaview, Luxembourg", new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4d5b51b0-3598-4223-829b-791257eda896"), new DateTime(2024, 3, 28, 2, 36, 43, 646, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 3, 29, 2, 36, 43, 646, DateTimeKind.Local).AddTicks(9768), 83.26m, 6818341835351243m, true, "Courier", 2, 33.217915f, "49529 Zelma Union, Morrisland, Uzbekistan", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), "8136 Schroeder Shoal, North Shanel, Turkey", new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("4f2bd89f-f947-4290-b522-08717908e924"), new DateTime(2023, 8, 6, 9, 20, 51, 825, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 8, 15, 9, 20, 51, 825, DateTimeKind.Local).AddTicks(4260), 53.47m, true, 3589633308302548m, true, "ParcelMachine", 1, 23.397331f, "808 Mertz Walk, Dareberg, Azerbaijan", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a"), "897 Arvid Mission, South Hassanhaven, Finland", new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022"), "Registered", "PlasticBag" },
                    { new Guid("505e96c3-abab-452a-9084-239834f2f21e"), new DateTime(2023, 11, 12, 2, 39, 53, 357, DateTimeKind.Local).AddTicks(1020), new DateTime(2023, 11, 17, 2, 39, 53, 357, DateTimeKind.Local).AddTicks(1020), 99.94m, true, 8444928008336749m, true, "Courier", 3, 21.57968f, "617 Napoleon Island, North Toreyborough, French Guiana", new Guid("2b73b7f1-451f-41db-b14e-91c27c148562"), "996 Cummings Drives, Darleneview, Puerto Rico", new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6"), "OnTheWay", "PlasticBag" },
                    { new Guid("55fd4545-a6f6-49f2-ba3b-3a201ac720f5"), new DateTime(2023, 11, 4, 9, 40, 21, 723, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 11, 14, 9, 40, 21, 723, DateTimeKind.Local).AddTicks(3413), 56.33m, true, 1603432098156121m, true, "ParcelMachine", 1, 9.812774f, "508 Robbie Plaza, Marysemouth, Luxembourg", new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6"), "056 Neva Park, Port Jay, Guyana", new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("56d47017-4676-4e75-b582-6551103ed11d"), new DateTime(2024, 2, 4, 12, 17, 17, 865, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 2, 11, 12, 17, 17, 865, DateTimeKind.Local).AddTicks(3215), 90.18m, true, 7449426300984191m, "Standart", 5, 44.75209f, "41371 Velva Cliff, South Finnhaven, Bosnia and Herzegovina", new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d"), "22734 Linnie Streets, Vandervortside, Papua New Guinea", new Guid("41654f75-1b53-494e-9d06-289e15fbc423"), "Delivered", "PlasticBag" },
                    { new Guid("5898f8b2-b3a7-43d4-b96c-25da879143a6"), new DateTime(2024, 3, 28, 19, 55, 52, 921, DateTimeKind.Local).AddTicks(8201), new DateTime(2024, 3, 29, 19, 55, 52, 921, DateTimeKind.Local).AddTicks(8201), 66.08m, true, 7201480593567463m, "ParcelMachine", 1, 48.526814f, "9461 Carleton Plaza, Konopelskichester, Burkina Faso", new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4"), "360 Mariah Fords, Port Pedroburgh, Yemen", new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5"), "Sent", "CardboardBox" },
                    { new Guid("595bed89-0a60-40b2-a6c1-268eb88de268"), new DateTime(2024, 4, 3, 19, 2, 26, 865, DateTimeKind.Local).AddTicks(2052), new DateTime(2024, 4, 7, 19, 2, 26, 865, DateTimeKind.Local).AddTicks(2052), 48.75m, true, 6725840976619746m, "Standart", 4, 34.657757f, "32913 West Estate, Seanview, Japan", new Guid("86132647-79dc-4073-869d-dd0cc40068f9"), "373 Stoltenberg Burgs, Johnstonchester, Rwanda", new Guid("3164a0af-914e-4e8a-9e4d-83d760107757"), "Registered", "CardboardBox" },
                    { new Guid("59926721-c57c-470d-bd56-a2ff805170d5"), new DateTime(2023, 11, 9, 17, 50, 53, 806, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 11, 19, 17, 50, 53, 806, DateTimeKind.Local).AddTicks(7767), 41.06m, true, 2827150771839010m, "ParcelMachine", 3, 34.986973f, "409 Jonatan Tunnel, Port Laceybury, Guyana", new Guid("29ab604b-7a76-439b-8129-93142c9b6cee"), "422 Streich Summit, North Melisa, Hong Kong", new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7"), "Sent", "CardboardBox" },
                    { new Guid("59f6cf82-1aea-49e6-9961-47584acf6ff8"), new DateTime(2024, 5, 29, 8, 18, 42, 352, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 6, 7, 8, 18, 42, 352, DateTimeKind.Local).AddTicks(9995), 37.52m, true, 6643055988679937m, "ParcelMachine", 2, 32.86303f, "72751 Richmond Port, Port Brannonchester, Kyrgyz Republic", new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95"), "9516 Torrey Brook, North Cruzberg, Gibraltar", new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5a437392-bd04-4d09-b4f0-10730acd959b"), new DateTime(2024, 4, 26, 9, 52, 38, 513, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 5, 5, 9, 52, 38, 513, DateTimeKind.Local).AddTicks(6425), 23.55m, 9518446195733702m, true, "Special", 1, 36.133884f, "246 Niko Canyon, North Korbin, Brunei Darussalam", new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100"), "08161 Gust Underpass, Reeceton, Jersey", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5aa7a876-70ef-4b40-808b-d5f8cdb0a71b"), new DateTime(2023, 11, 2, 12, 22, 31, 145, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 11, 8, 12, 22, 31, 145, DateTimeKind.Local).AddTicks(986), 13.15m, true, 3832417376084747m, "Special", 3, 42.889847f, "75828 Jadon Glen, Lakinstad, Kiribati", new Guid("2183f862-871a-449c-b3da-ea6005e9e472"), "37581 Dickinson Estates, Hazletown, Cameroon", new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e"), "Return", "PlasticBag" },
                    { new Guid("61faecbe-4884-4428-926e-1b76ab88ade4"), new DateTime(2023, 12, 28, 2, 23, 59, 294, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 1, 1, 2, 23, 59, 294, DateTimeKind.Local).AddTicks(5577), 60.31m, true, 1091399235988022m, "Super", 4, 29.627825f, "1981 Bosco Lakes, Auerburgh, Ghana", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), "38968 Heidenreich Villages, Rileyburgh, Paraguay", new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("625566be-0a3a-4a57-8cd1-8b33c80c0b01"), new DateTime(2023, 6, 29, 10, 5, 2, 439, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 7, 7, 10, 5, 2, 439, DateTimeKind.Local).AddTicks(2043), 76.70m, true, 8872050107388510m, true, "Standart", 3, 11.05686f, "2522 Denis Springs, North Nyasia, Western Sahara", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446"), "3315 Elta Green, Funkview, Ethiopia", new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("64828690-17b4-45bd-8a8c-1d13db27da93"), new DateTime(2023, 9, 16, 17, 43, 21, 179, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 9, 24, 17, 43, 21, 179, DateTimeKind.Local).AddTicks(8815), 89.64m, 1142417944768121m, true, "Standart", 2, 10.894422f, "592 Clyde Corner, Gusikowskistad, Solomon Islands", new Guid("5f081f26-af78-4d3a-b693-1268567854c9"), "7351 Alexzander Viaduct, Croninton, Norway", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("64db9695-dee5-49cd-8ae0-bc19982e4005"), new DateTime(2023, 11, 12, 7, 38, 6, 692, DateTimeKind.Local).AddTicks(7689), new DateTime(2023, 11, 17, 7, 38, 6, 692, DateTimeKind.Local).AddTicks(7689), 86.98m, true, 6207649688788299m, true, "Courier", 5, 36.656906f, "1692 Brekke Club, Kossbury, Moldova", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5"), "72717 Quigley Spurs, Ziememouth, Madagascar", new Guid("6bd6126d-6465-493b-abdc-935b7afbc646"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6531f403-2778-4dbc-96e9-2f8b66a03fd3"), new DateTime(2024, 2, 10, 18, 41, 0, 451, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 2, 13, 18, 41, 0, 451, DateTimeKind.Local).AddTicks(5242), 51.91m, true, 3759601269855456m, "Courier", 1, 39.25443f, "460 Johnson Plains, Carterport, Martinique", new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb"), "026 Bechtelar Stravenue, Port Leatha, Serbia", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("695f5e2a-a0da-492e-86ca-0ba6924e159b"), new DateTime(2023, 10, 24, 19, 39, 5, 36, DateTimeKind.Local).AddTicks(983), new DateTime(2023, 11, 1, 19, 39, 5, 36, DateTimeKind.Local).AddTicks(983), 74.79m, 9320888113201052m, true, "Standart", 5, 31.83649f, "038 Alec Tunnel, Caterinaberg, Poland", new Guid("36333093-6685-44ce-9e09-9007f88e766b"), "14893 Oswald Club, Salvadorfurt, Ghana", new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6d2b7126-72f4-465e-87b5-b60a31a235c0"), new DateTime(2024, 1, 4, 19, 44, 31, 852, DateTimeKind.Local).AddTicks(4346), new DateTime(2024, 1, 9, 19, 44, 31, 852, DateTimeKind.Local).AddTicks(4346), 85.46m, true, 5426122987559870m, "Standart", 5, 26.936207f, "321 Auer Trail, Port Dexter, Uganda", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c"), "55347 Jeanie Spring, South Margotmouth, Mauritius", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("70462361-b356-4ecf-a831-7db8748314a4"), new DateTime(2023, 12, 15, 3, 4, 56, 995, DateTimeKind.Local).AddTicks(8522), new DateTime(2023, 12, 20, 3, 4, 56, 995, DateTimeKind.Local).AddTicks(8522), 81.38m, 6750450175686817m, true, "Special", 3, 33.114204f, "2224 Sam Glens, Robynmouth, Zambia", new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc"), "94335 Brendon Hollow, Genovevatown, Jordan", new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("71383c76-8362-4544-9fa7-def6cc289a9c"), new DateTime(2023, 12, 15, 19, 7, 32, 514, DateTimeKind.Local).AddTicks(5494), new DateTime(2023, 12, 22, 19, 7, 32, 514, DateTimeKind.Local).AddTicks(5494), 30.29m, true, 5896704339092912m, true, "Super", 4, 35.183437f, "890 Norris Burg, Lake Alvah, Suriname", new Guid("406d2568-124d-499f-ab91-bf26387bbe3d"), "33054 Sigmund Drives, South Emilio, United Arab Emirates", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad"), "Sent", "PlasticBag" },
                    { new Guid("758fa62d-baf4-48ee-856c-32aba42ee1c5"), new DateTime(2023, 9, 8, 12, 29, 55, 30, DateTimeKind.Local).AddTicks(9486), new DateTime(2023, 9, 18, 12, 29, 55, 30, DateTimeKind.Local).AddTicks(9486), 77.54m, true, 6984537934165871m, true, "Courier", 4, 11.303122f, "39869 Kuphal Plaza, Boyerstad, Lithuania", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), "091 Brekke Crest, Okunevatown, Comoros", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("77bae660-af24-47ad-a993-6625bcdcb242"), new DateTime(2023, 9, 21, 22, 38, 55, 385, DateTimeKind.Local).AddTicks(3933), new DateTime(2023, 9, 26, 22, 38, 55, 385, DateTimeKind.Local).AddTicks(3933), 17.75m, 1993251816563254m, "Standart", 4, 10.458876f, "74875 Gaetano Hills, West Michelton, Iceland", new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3"), "212 Krajcik Island, Ryannmouth, Saint Barthelemy", new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("781589d9-682f-4f9d-9e5c-0fde3259f13a"), new DateTime(2024, 3, 19, 20, 25, 34, 579, DateTimeKind.Local).AddTicks(4408), new DateTime(2024, 3, 29, 20, 25, 34, 579, DateTimeKind.Local).AddTicks(4408), 40.43m, 8814221300959158m, true, "ParcelMachine", 5, 29.590261f, "661 Treutel Way, Julianamouth, Canada", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9"), "3623 Dedric Haven, Sawaynmouth, Afghanistan", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7867d6e5-fa84-45a4-8a34-4c11d61470d8"), new DateTime(2023, 8, 11, 10, 0, 41, 910, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 8, 20, 10, 0, 41, 910, DateTimeKind.Local).AddTicks(4619), 33.10m, 7089800425061734m, "Special", 3, 27.983109f, "68819 Miller Prairie, Christopberg, Moldova", new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764"), "7917 Leannon Valleys, Priceton, Latvia", new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7ae1bf92-5576-4a03-94a6-7f50247d1608"), new DateTime(2023, 10, 8, 19, 44, 20, 848, DateTimeKind.Local).AddTicks(8206), new DateTime(2023, 10, 18, 19, 44, 20, 848, DateTimeKind.Local).AddTicks(8206), 21.19m, true, 6086715086483650m, true, "ParcelMachine", 1, 13.723605f, "577 Edythe Bypass, East Billfort, Botswana", new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f"), "5944 Kilback Fords, East Averyport, Macao", new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7fc17b54-f58f-4634-bcff-b4df83d84617"), new DateTime(2024, 5, 8, 8, 51, 23, 48, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 5, 16, 8, 51, 23, 48, DateTimeKind.Local).AddTicks(3003), 91.53m, 2481628405938801m, true, "Standart", 2, 37.819603f, "363 Vallie Street, Medhurstchester, Colombia", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0"), "90997 Trevor Mill, Jairomouth, Luxembourg", new Guid("0e809aac-90e9-4073-992f-0a9348838efe"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("80058edf-f81b-4979-8fee-b08928cc29ae"), new DateTime(2023, 12, 2, 5, 58, 45, 813, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 12, 6, 5, 58, 45, 813, DateTimeKind.Local).AddTicks(4522), 99.57m, true, 2446702272249348m, true, "Standart", 5, 49.270206f, "36321 Adelia Path, North Erikberg, Isle of Man", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7"), "11599 Volkman Island, New Fabiolafort, Tanzania", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8228259d-e74f-4d1a-8c3c-78a570fef971"), new DateTime(2023, 9, 20, 9, 44, 14, 731, DateTimeKind.Local).AddTicks(9220), new DateTime(2023, 9, 21, 9, 44, 14, 731, DateTimeKind.Local).AddTicks(9220), 16.09m, true, 6016009846547221m, "Special", 4, 13.3759575f, "945 Berry Fort, North Clydeville, Saint Martin", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), "086 Aufderhar Bypass, Donnellybury, Burkina Faso", new Guid("feeae310-c37b-49b5-b035-e9098493766b"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("832b6e96-3ea8-413c-be76-34970e3978f6"), new DateTime(2023, 7, 6, 11, 31, 41, 385, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 7, 16, 11, 31, 41, 385, DateTimeKind.Local).AddTicks(4820), 92.93m, 4525475146000594m, true, "ParcelMachine", 2, 42.878105f, "4981 Warren Common, New Yeseniaport, Saint Martin", new Guid("6bd6126d-6465-493b-abdc-935b7afbc646"), "7235 Rodriguez Court, Port Berylside, Bulgaria", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("836afc81-8390-4504-ad57-dcf4a332d4f3"), new DateTime(2023, 9, 26, 23, 17, 30, 254, DateTimeKind.Local).AddTicks(3670), new DateTime(2023, 9, 27, 23, 17, 30, 254, DateTimeKind.Local).AddTicks(3670), 94.41m, true, 9582771357322972m, "Super", 5, 46.724342f, "79952 Gerhold Valleys, Brakusville, Bolivia", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), "0512 Douglas Corner, South Nikko, Botswana", new Guid("b34e9d23-9b12-49b3-b069-734a50918afc"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("84dd0dee-90d7-4965-8fa9-eb58a4530e19"), new DateTime(2023, 8, 23, 8, 22, 48, 486, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 9, 2, 8, 22, 48, 486, DateTimeKind.Local).AddTicks(9879), 90.10m, 5809197511689180m, "Super", 5, 13.024482f, "62948 Austin Skyway, Lake Inesborough, Congo", new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10"), "97480 McCullough Road, Bahringerchester, Guinea", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("85aa8136-8a42-450c-8077-9eb68107dd1d"), new DateTime(2023, 10, 4, 14, 30, 28, 913, DateTimeKind.Local).AddTicks(499), new DateTime(2023, 10, 13, 14, 30, 28, 913, DateTimeKind.Local).AddTicks(499), 76.97m, true, 3634170341595506m, "Special", 3, 5.832651f, "729 Shayne Ways, Kianashire, French Guiana", new Guid("69445845-4c7f-4276-a288-559e4b4df167"), "576 Giovanna Forge, Beaulahstad, Malta", new Guid("29ab604b-7a76-439b-8129-93142c9b6cee"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("903bb25c-f03b-4ca8-b9f0-245bedc29a8d"), new DateTime(2023, 10, 7, 23, 35, 2, 775, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 10, 8, 23, 35, 2, 775, DateTimeKind.Local).AddTicks(7876), 10.46m, 2952820532807298m, true, "Courier", 2, 35.302017f, "1498 Isadore Shoal, Nikolasville, Mali", new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff"), "80399 Randy Meadows, South Christianshire, Saint Barthelemy", new Guid("ff032668-ac2d-465e-a8be-49991c69a967"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("90f03d34-65ea-4d3c-889a-b0a768fe0bd5"), new DateTime(2024, 4, 10, 15, 43, 59, 60, DateTimeKind.Local).AddTicks(8149), new DateTime(2024, 4, 20, 15, 43, 59, 60, DateTimeKind.Local).AddTicks(8149), 50.84m, 4336239183729940m, "Standart", 5, 5.347841f, "794 Runolfsdottir Track, East Akeemberg, Saudi Arabia", new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e"), "18311 Gabriel Stream, Leviside, United States of America", new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("926758e2-a4d4-458b-8506-da71d1c0eec5"), new DateTime(2023, 8, 24, 15, 21, 49, 58, DateTimeKind.Local).AddTicks(9771), new DateTime(2023, 8, 28, 15, 21, 49, 58, DateTimeKind.Local).AddTicks(9771), 53.74m, true, 3146952852932298m, true, "Courier", 5, 1.7651786f, "9329 Rath Track, Jaronmouth, Estonia", new Guid("f33ed058-0d5e-4f28-8270-398f55394914"), "4388 Giovanna Creek, Rosalindatown, Serbia", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac"), "Return", "PlasticBag" },
                    { new Guid("956eab55-dc39-4f9b-9669-509dac5055c6"), new DateTime(2024, 1, 16, 12, 11, 4, 968, DateTimeKind.Local).AddTicks(4886), new DateTime(2024, 1, 21, 12, 11, 4, 968, DateTimeKind.Local).AddTicks(4886), 36.79m, true, 2493769186467536m, true, "Courier", 2, 17.778841f, "0687 Heaney Plains, Lake Gianniville, Guatemala", new Guid("def8845a-24de-49d2-a341-fdf28b9883be"), "22105 Marquardt Crescent, North Brittanyberg, Vanuatu", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd"), "Registered", "PlasticBag" },
                    { new Guid("97015c5c-ed9b-4b47-b058-51cbcbb140b9"), new DateTime(2023, 10, 2, 16, 27, 5, 886, DateTimeKind.Local).AddTicks(2208), new DateTime(2023, 10, 12, 16, 27, 5, 886, DateTimeKind.Local).AddTicks(2208), 36.53m, true, 8047000843356012m, true, "ParcelMachine", 1, 26.826687f, "285 Finn Ranch, Port Damianbury, Jersey", new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc"), "5984 Geovany Route, Carolinastad, Anguilla", new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("98f6d52a-d47e-4c60-8236-df91ef50af0c"), new DateTime(2024, 2, 24, 13, 50, 22, 910, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 2, 28, 13, 50, 22, 910, DateTimeKind.Local).AddTicks(8632), 26.55m, true, 6402968723889123m, "ParcelMachine", 5, 15.613458f, "590 Stacy Gateway, North Antone, Guatemala", new Guid("0be23392-599f-43dc-97d5-6396327167ba"), "7612 Yvonne Place, West Rahsaan, Virgin Islands, British", new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("9a524b00-84b8-4c07-858e-a6e468e6f628"), new DateTime(2023, 12, 15, 15, 29, 33, 574, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 12, 17, 15, 29, 33, 574, DateTimeKind.Local).AddTicks(9547), 63.30m, 4532888988994063m, "Courier", 4, 41.060482f, "49363 Armstrong Freeway, Nikkichester, Bermuda", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426"), "3265 Randi Tunnel, North Darron, Belarus", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), "Delivered", "PlasticBag" },
                    { new Guid("9b15c6fa-e967-4601-88ad-e94feaf1be1a"), new DateTime(2023, 9, 10, 4, 56, 55, 173, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 9, 16, 4, 56, 55, 173, DateTimeKind.Local).AddTicks(5824), 63.02m, 9260868352687668m, "Courier", 1, 47.070004f, "681 Cierra Isle, New Karson, Sao Tome and Principe", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092"), "117 Brekke Knoll, New Dereckberg, Belarus", new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9bc58ca7-7ed0-45c2-8dec-4957d869195b"), new DateTime(2023, 12, 23, 3, 27, 33, 503, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 1, 1, 3, 27, 33, 503, DateTimeKind.Local).AddTicks(9062), 33.43m, true, 2239027967445213m, "Special", 4, 11.329069f, "49269 Elisha Union, West Estrellaview, Cyprus", new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54"), "772 Antone Canyon, South Aiyanaview, Honduras", new Guid("c559b832-f4e6-4f67-9eca-337973071293"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9d35f11c-7ad8-4fe6-88a4-c31c7368106e"), new DateTime(2023, 12, 3, 2, 25, 59, 85, DateTimeKind.Local).AddTicks(8281), new DateTime(2023, 12, 6, 2, 25, 59, 85, DateTimeKind.Local).AddTicks(8281), 35.86m, 7913037602879449m, true, "Super", 4, 11.900635f, "08689 Keanu Highway, Sydniside, Macedonia", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), "612 Elmo Route, Lake Jevonberg, Cambodia", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9f21a5e7-6b27-4fc1-ba47-16aee6a7d996"), new DateTime(2023, 10, 12, 15, 50, 52, 265, DateTimeKind.Local).AddTicks(1229), new DateTime(2023, 10, 20, 15, 50, 52, 265, DateTimeKind.Local).AddTicks(1229), 24.43m, 1199622417953094m, "Special", 2, 27.79418f, "528 Tomas Shoals, Garnettmouth, Zimbabwe", new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a"), "12695 Hauck Ville, Grantville, Burundi", new Guid("31147f68-7359-46eb-af11-622a8764424a"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a545cf62-f345-4889-bc4c-714e7a6245c1"), new DateTime(2024, 5, 20, 14, 5, 27, 308, DateTimeKind.Local).AddTicks(6826), new DateTime(2024, 5, 24, 14, 5, 27, 308, DateTimeKind.Local).AddTicks(6826), 48.70m, true, 3201328446014101m, true, "ParcelMachine", 5, 35.962715f, "49072 Stroman Land, South Isaiahmouth, Gabon", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), "8309 Trinity Springs, West Rhianna, Azerbaijan", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), "Sent", "PlasticBag" },
                    { new Guid("a66650d5-9435-43bc-a757-8f8c03dd5f98"), new DateTime(2024, 6, 6, 16, 40, 55, 642, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 6, 10, 16, 40, 55, 642, DateTimeKind.Local).AddTicks(5763), 30.65m, true, 3566916364721009m, true, "Super", 1, 7.9734836f, "127 Ayana Square, Jarrodshire, Montserrat", new Guid("30eaf229-a750-446f-b353-8f619614a839"), "869 Melisa Pike, New Marshall, Belarus", new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb"), "Sent", "CardboardBox" },
                    { new Guid("a952b9cf-9813-4fbb-aa8b-f0a6c504f5aa"), new DateTime(2023, 8, 31, 6, 57, 51, 994, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 9, 2, 6, 57, 51, 994, DateTimeKind.Local).AddTicks(4930), 53.89m, true, 3565266739644300m, true, "Super", 1, 35.651695f, "8066 Emelie Extension, South Merlemouth, Morocco", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "7318 Uriah Roads, Annabellmouth, Bermuda", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603"), "Registered", "CardboardBox" },
                    { new Guid("ab29e8b0-28da-4b66-a7b1-2a3ecae6cb7c"), new DateTime(2024, 5, 25, 19, 6, 52, 952, DateTimeKind.Local).AddTicks(1919), new DateTime(2024, 5, 27, 19, 6, 52, 952, DateTimeKind.Local).AddTicks(1919), 80.03m, true, 5563048203441983m, true, "Courier", 3, 1.6690844f, "583 Nels Spurs, Koeppside, South Georgia and the South Sandwich Islands", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "0352 Chelsea Locks, North Damianport, Uruguay", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), "OnTheWay", "CardboardBox" },
                    { new Guid("b2c3ad42-4f88-4595-ad98-2981beb2d84a"), new DateTime(2023, 7, 2, 0, 44, 40, 954, DateTimeKind.Local).AddTicks(6633), new DateTime(2023, 7, 11, 0, 44, 40, 954, DateTimeKind.Local).AddTicks(6633), 22.75m, true, 5170455560341726m, true, "Standart", 4, 49.190445f, "794 Kunze Extension, East Walker, Norway", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b"), "63735 Zachary Ways, Maudietown, Sao Tome and Principe", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b2d68614-dd70-40fb-b1b6-2cdf225ee1ec"), new DateTime(2023, 7, 7, 0, 23, 14, 43, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 7, 11, 0, 23, 14, 43, DateTimeKind.Local).AddTicks(9314), 63.18m, 6147663883434098m, "Standart", 3, 48.754303f, "45996 Gerlach Well, Hoppechester, Tajikistan", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367"), "43994 Baumbach Drive, Port Evebury, Vietnam", new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b46e3f09-3f80-415b-8500-71f7386edcb6"), new DateTime(2024, 1, 23, 9, 27, 15, 550, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 1, 28, 9, 27, 15, 550, DateTimeKind.Local).AddTicks(8150), 88.96m, true, 5171805368577266m, "Courier", 1, 10.256777f, "2191 Donnelly Grove, New Fiona, India", new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91"), "0936 Myrl Viaduct, Port Deondre, Indonesia", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b78faeae-0e33-446a-8dfa-bcb27f829aa9"), new DateTime(2024, 5, 1, 12, 39, 31, 752, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 5, 7, 12, 39, 31, 752, DateTimeKind.Local).AddTicks(6770), 31.68m, 1661500355662268m, "Courier", 3, 25.57011f, "3322 Dooley Village, Cristchester, Sri Lanka", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1"), "4709 Gibson Freeway, Zelmaview, Philippines", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("beb98182-46cb-4d4b-8663-01f2c0325c8e"), new DateTime(2023, 6, 23, 4, 54, 53, 988, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 7, 3, 4, 54, 53, 988, DateTimeKind.Local).AddTicks(6021), 52.73m, true, 2684925860540250m, "Special", 3, 24.269867f, "938 Brain Mews, Noahfurt, Tuvalu", new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882"), "375 Elmo Mountain, West Frankie, Oman", new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c00df7f5-a27e-464e-bae2-10a014536251"), new DateTime(2024, 2, 5, 18, 6, 33, 813, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 2, 9, 18, 6, 33, 813, DateTimeKind.Local).AddTicks(6770), 28.34m, 8782741076513349m, true, "Super", 4, 20.830097f, "046 Kendra Mountain, Lake Easton, Bermuda", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), "7422 Hamill Course, Carterfurt, Antarctica (the territory South of 60 deg S)", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("c242ff27-3167-41bb-bc08-e2bdefb01522"), new DateTime(2024, 4, 9, 20, 35, 28, 631, DateTimeKind.Local).AddTicks(157), new DateTime(2024, 4, 14, 20, 35, 28, 631, DateTimeKind.Local).AddTicks(157), 89.85m, true, 8939106535790656m, "Courier", 4, 45.19487f, "74616 Hintz Mall, South Stefaniefurt, Barbados", new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413"), "05597 Lexus Drive, Hansenmouth, Malta", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), "Return", "PlasticBag" },
                    { new Guid("c3d4ca28-e617-46fa-9ffa-caca824d70e6"), new DateTime(2024, 5, 1, 18, 28, 54, 139, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 5, 2, 18, 28, 54, 139, DateTimeKind.Local).AddTicks(1408), 66.05m, true, 1512375812763437m, "Standart", 1, 18.919565f, "94174 Borer Trail, Port Ozella, Timor-Leste", new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce"), "05539 Cora Village, Lake Rosalindamouth, Albania", new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("c924b9e8-6bb5-4d26-9c7b-55365fc70aa0"), new DateTime(2023, 12, 9, 5, 44, 18, 647, DateTimeKind.Local).AddTicks(2899), new DateTime(2023, 12, 18, 5, 44, 18, 647, DateTimeKind.Local).AddTicks(2899), 90.53m, 9204954066348428m, "Super", 4, 4.521293f, "5616 Koelpin Meadow, Lake Boris, Tunisia", new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33"), "4199 Dooley Route, East Americatown, Timor-Leste", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), "OnTheWay", "PlasticBag" },
                    { new Guid("ca8ef177-2600-4e33-9f88-0049c235754c"), new DateTime(2023, 6, 8, 15, 26, 48, 557, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 6, 13, 15, 26, 48, 557, DateTimeKind.Local).AddTicks(2407), 25.67m, 3743639122822620m, "ParcelMachine", 2, 6.600388f, "635 Reba Turnpike, South Mollybury, Liberia", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), "49716 Kuvalis Villages, Martinetown, Oman", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cae371b3-1a7d-45cb-ab0e-cdf2ac8a1653"), new DateTime(2023, 10, 31, 18, 4, 28, 117, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 11, 10, 18, 4, 28, 117, DateTimeKind.Local).AddTicks(3227), 44.25m, true, 4958141007446535m, true, "ParcelMachine", 5, 26.254305f, "606 Wolf Expressway, North Pauline, Holy See (Vatican City State)", new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413"), "45309 Carole Rapids, South Reyeshaven, Senegal", new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ce5b3a8a-ffd1-4641-8a3e-357594cd4ca8"), new DateTime(2024, 3, 16, 3, 3, 21, 187, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 3, 18, 3, 3, 21, 187, DateTimeKind.Local).AddTicks(5362), 50.57m, 3884553222214651m, "Courier", 5, 31.90462f, "7949 Corkery Junction, West Tyler, Ethiopia", new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646"), "6043 Kshlerin Plains, West Elise, Vietnam", new Guid("e6097123-c594-4bdb-870c-0cf57528e39a"), "Delivered", "CardboardBox" },
                    { new Guid("d0580c37-31d7-4319-9f68-b4c613ec8549"), new DateTime(2024, 4, 5, 2, 31, 20, 951, DateTimeKind.Local).AddTicks(6022), new DateTime(2024, 4, 7, 2, 31, 20, 951, DateTimeKind.Local).AddTicks(6022), 95.93m, 1142190108605836m, "Super", 1, 49.87625f, "8802 Murray Drive, Julesborough, Venezuela", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), "4408 Savanah Cape, Gabrielside, Micronesia", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d07a9562-d61f-410b-b597-05deb41cf7e6"), new DateTime(2023, 10, 5, 22, 14, 11, 614, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 10, 15, 22, 14, 11, 614, DateTimeKind.Local).AddTicks(2869), 70.14m, true, 5116906564756208m, "Standart", 3, 22.583853f, "08130 Runte Burg, Port Shyannmouth, Bangladesh", new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7"), "85918 Schneider Squares, Framimouth, Malaysia", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("d2beb264-ae54-4c34-b991-3279fa05119a"), new DateTime(2023, 9, 12, 4, 5, 49, 879, DateTimeKind.Local).AddTicks(5506), new DateTime(2023, 9, 22, 4, 5, 49, 879, DateTimeKind.Local).AddTicks(5506), 39.01m, 9791219007690082m, true, "ParcelMachine", 1, 8.638802f, "51204 Feeney Manor, East Nikkiside, Bhutan", new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc"), "0136 Block Stream, East Maziemouth, Uzbekistan", new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2"), "Registered", "PlasticBag" },
                    { new Guid("d564072f-6ea5-4f3e-a966-a0793c0cfb9f"), new DateTime(2023, 10, 11, 0, 54, 5, 444, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 10, 18, 0, 54, 5, 444, DateTimeKind.Local).AddTicks(8448), 29.92m, 2625828540259595m, true, "Courier", 1, 21.91207f, "042 Wilkinson Islands, New Dallas, Trinidad and Tobago", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0"), "374 Witting Mountains, Lizziemouth, Singapore", new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e57ed333-ea76-4764-b409-7dec620a5366"), new DateTime(2024, 5, 31, 10, 49, 2, 467, DateTimeKind.Local).AddTicks(8902), new DateTime(2024, 6, 6, 10, 49, 2, 467, DateTimeKind.Local).AddTicks(8902), 29.63m, true, 5893006413896942m, "Standart", 1, 4.9177446f, "289 Wilderman Turnpike, Daughertyland, Egypt", new Guid("0459684a-9478-4760-922c-cdff0f159395"), "2873 Beahan Pines, Wunschside, Djibouti", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("e8dd1e85-371f-4bd2-b600-612a5c60f205"), new DateTime(2024, 1, 22, 7, 36, 7, 475, DateTimeKind.Local).AddTicks(4238), new DateTime(2024, 1, 28, 7, 36, 7, 475, DateTimeKind.Local).AddTicks(4238), 56.68m, true, 6043032567930727m, true, "Super", 4, 10.596721f, "650 Bonnie Cliffs, North Jalon, Guadeloupe", new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8"), "6778 Frederik Trace, Port Kattie, Guinea-Bissau", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), "Registered", "PlasticBag" },
                    { new Guid("ea4e4c0c-90f1-4675-af69-699ebf539e1d"), new DateTime(2024, 2, 1, 6, 32, 22, 361, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 2, 6, 6, 32, 22, 361, DateTimeKind.Local).AddTicks(2975), 94.62m, true, 4031265189580669m, true, "Standart", 2, 17.635574f, "1576 Giuseppe Tunnel, East Van, Greece", new Guid("38262136-b169-413b-ac46-ad2f34893b37"), "119 Bruen Land, Bernierbury, Turkey", new Guid("0e809aac-90e9-4073-992f-0a9348838efe"), "Sent", "PlasticBag" },
                    { new Guid("eb94af73-229f-47e6-a432-91d5b497689b"), new DateTime(2023, 10, 7, 23, 55, 37, 344, DateTimeKind.Local).AddTicks(7204), new DateTime(2023, 10, 13, 23, 55, 37, 344, DateTimeKind.Local).AddTicks(7204), 59.98m, true, 8829671707877333m, true, "Courier", 3, 41.5846f, "821 Emilia Path, Dellstad, Barbados", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3"), "9877 Troy Roads, Lake Hunterchester, Cape Verde", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ee5147be-1a94-4d6b-a7fb-97f5a09da41d"), new DateTime(2023, 10, 28, 5, 15, 7, 191, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 11, 7, 5, 15, 7, 191, DateTimeKind.Local).AddTicks(1038), 29.32m, true, 7941372849988798m, "Super", 1, 33.149742f, "40102 Carroll Plains, Hellerchester, Namibia", new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19"), "168 Evangeline Forges, East Marjory, Italy", new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f408ffd7-ad1d-462a-8f24-335430a4e3f4"), new DateTime(2023, 7, 9, 0, 39, 48, 986, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 7, 15, 0, 39, 48, 986, DateTimeKind.Local).AddTicks(4821), 65.12m, 4853251358205200m, true, "Courier", 5, 29.700996f, "50420 Kevon Pine, O'Keefeshire, Namibia", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), "49188 Luis Rue, Titusshire, Singapore", new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f9ba76dd-bb55-4172-8725-e66a7b959bcd"), new DateTime(2023, 7, 19, 19, 20, 41, 611, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 7, 24, 19, 20, 41, 611, DateTimeKind.Local).AddTicks(1732), 19.15m, true, 8950491210445214m, true, "Standart", 5, 45.879585f, "59519 Casper Common, North Jeromy, Dominican Republic", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2"), "796 Ritchie Plain, Stantonberg, Maldives", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fa9484a7-46e1-4ba8-932d-1cd1d4d01089"), new DateTime(2024, 4, 11, 10, 34, 48, 448, DateTimeKind.Local).AddTicks(6721), new DateTime(2024, 4, 12, 10, 34, 48, 448, DateTimeKind.Local).AddTicks(6721), 35.28m, 2625380008648829m, "Standart", 4, 37.785114f, "955 Austyn Burg, West Brendonville, Netherlands", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165"), "4705 Rath Shoals, West Destini, Cape Verde", new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fdd3dbd5-e671-4b96-a62d-bd4c663d4b82"), new DateTime(2023, 11, 29, 5, 29, 25, 340, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 12, 1, 5, 29, 25, 340, DateTimeKind.Local).AddTicks(2567), 21.08m, true, 5840861757790746m, true, "ParcelMachine", 4, 3.4883325f, "4603 Josephine Meadow, Gusikowskiberg, Portugal", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141"), "0767 Myrtis Mountain, East Caleigh, New Caledonia", new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("fe1b4964-a8fd-4057-8bb9-04b9fedbfcc1"), new DateTime(2023, 11, 18, 14, 49, 27, 357, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 11, 25, 14, 49, 27, 357, DateTimeKind.Local).AddTicks(7403), 19.10m, 5630615405811184m, "Super", 1, 22.259315f, "08045 Beer Springs, South Shawnton, Albania", new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9"), "1856 Josiane Lodge, East Marcellus, Ireland", new Guid("7613a4be-1868-4124-8145-c559fd0b8b95"), "Delivered", "CardboardBox" },
                    { new Guid("fe857097-8e97-4f74-bca0-d760fd1e1716"), new DateTime(2024, 5, 22, 2, 24, 16, 290, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 5, 24, 2, 24, 16, 290, DateTimeKind.Local).AddTicks(4491), 54.77m, 2610902061904471m, "Super", 5, 8.6768465f, "68208 Kautzer Mission, D'Amoreport, Bulgaria", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "7306 Philip Fords, New Jamaal, Serbia", new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("00a53107-8a73-4037-b794-6ed150743f5f"), "867", "7436664652614036", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3"), "04/27" },
                    { new Guid("01717a0a-d1c2-4477-ac6a-65b80436ad48"), "606", "2026465958077510", new Guid("48f78165-0368-457a-a33f-c7c330b9016e"), "03/06" },
                    { new Guid("0240dc8c-ac0d-48b6-b346-12b7d1880b38"), "685", "2228037608347362", new Guid("7613a4be-1868-4124-8145-c559fd0b8b95"), "09/05" },
                    { new Guid("027b0f52-5654-47a0-8a29-29fca52312d7"), "878", "3042784518991464", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf"), "06/02" },
                    { new Guid("0304ea69-c9e6-4f68-9435-68c834f63bd6"), "359", "2558513016983269", new Guid("0e809aac-90e9-4073-992f-0a9348838efe"), "07/05" },
                    { new Guid("031f35b3-7360-4ca0-a2a9-bec98bdfcad1"), "276", "2266901759538537", new Guid("b5652445-32c0-44e8-b366-391041e6d37d"), "09/21" },
                    { new Guid("033f4eb0-eb99-4c3e-8828-877db91516f2"), "615", "5037585174509786", new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc"), "06/23" },
                    { new Guid("03b36b7b-2cb3-4358-b646-16770bd78d11"), "972", "9534673277684510", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b"), "02/07" },
                    { new Guid("040c7517-5297-4f9e-987b-4c14dc4be714"), "186", "7227007167836365", new Guid("2183f862-871a-449c-b3da-ea6005e9e472"), "06/26" },
                    { new Guid("040f3f7b-b6b9-4c01-98f4-dcf05ae57d45"), "075", "5444975676663027", new Guid("b5652445-32c0-44e8-b366-391041e6d37d"), "10/02" },
                    { new Guid("044265cc-32a8-44ea-a1f5-c8313ec769e8"), "714", "4721263237404436", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117"), "05/10" },
                    { new Guid("04440a94-8114-45df-8a1d-e7e5d650e479"), "473", "7006321564150580", new Guid("5d96609e-242a-4e81-841d-15924cb829f7"), "01/04" },
                    { new Guid("0455961b-0214-4c77-a40f-1558370a8f45"), "986", "9383084051253539", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337"), "06/14" },
                    { new Guid("04d48ec7-304e-442a-a53b-43929ab35732"), "403", "3044624247648993", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7"), "12/21" },
                    { new Guid("05132978-ca9b-4c54-b7ab-11135d74b2b4"), "888", "2263241629340146", new Guid("576c41db-7388-43c8-8b70-27543c323237"), "04/22" },
                    { new Guid("05315286-522e-42ec-8929-269812442b2f"), "614", "5378808653190040", new Guid("86132647-79dc-4073-869d-dd0cc40068f9"), "10/22" },
                    { new Guid("05f0d32c-327a-4091-af41-6d8badc9e5e0"), "472", "2174352735047649", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01"), "09/16" },
                    { new Guid("06461961-ea6e-4956-bd84-c7a6f0a5bcea"), "596", "1642496020819230", new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8"), "11/21" },
                    { new Guid("066dcd97-fd1f-4a82-9c17-cc4c54fd19c9"), "781", "4802614398900966", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f"), "09/07" },
                    { new Guid("06f8dd81-3020-459d-b3a8-0ca9253a1942"), "288", "4933697113523394", new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77"), "09/04" },
                    { new Guid("077615e8-b597-49ae-8c1a-b716c8074518"), "886", "6130419745600980", new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12"), "02/09" },
                    { new Guid("077bc292-ad41-49ec-9934-4f892d9b1455"), "805", "3500972954678290", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7"), "03/23" },
                    { new Guid("08033a0f-b9df-4179-bfc0-b4dff5586723"), "316", "4271270771862435", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad"), "11/01" },
                    { new Guid("080811ee-cffb-416f-8ab6-a69288162c05"), "564", "3004927189930092", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a"), "05/21" },
                    { new Guid("08270d73-3c6e-425f-bd1c-8952cade3d59"), "930", "4143202764601599", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0"), "10/11" },
                    { new Guid("0899bc04-4a1e-4d04-b7bc-3d2d2e7d9bee"), "499", "7439461358768299", new Guid("3164a0af-914e-4e8a-9e4d-83d760107757"), "02/17" },
                    { new Guid("08b30e91-1340-4186-a825-e7507c30bc3f"), "811", "5077704661623150", new Guid("30eaf229-a750-446f-b353-8f619614a839"), "06/13" },
                    { new Guid("095838a0-c285-4654-bc94-b5c2a93c957b"), "923", "6095378476517592", new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f"), "09/11" },
                    { new Guid("096f6d92-5cb8-495d-b016-c7f9d84ec64e"), "049", "4768637277407752", new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e"), "03/19" },
                    { new Guid("0984c012-bb93-43a8-851e-8988d92a0e38"), "717", "2079051969122094", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf"), "11/10" },
                    { new Guid("09906302-2bbc-4f21-abff-0e12cdbeb389"), "296", "2794630745101014", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c"), "12/28" },
                    { new Guid("09b98dcb-4871-4041-a295-8382af09d65b"), "371", "9906449690265090", new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193"), "10/28" },
                    { new Guid("09bd6efc-daef-4bb0-b02a-65b1f29412ce"), "072", "3460569696139914", new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66"), "05/02" },
                    { new Guid("09c10d92-d0b7-41e6-a095-7461be622afa"), "260", "7190640360196937", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a"), "02/13" },
                    { new Guid("0a2112e2-476f-4da3-91c4-40dd7360f06a"), "345", "3582976208737738", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141"), "04/17" },
                    { new Guid("0a2cb178-f16e-40e1-9b3b-5f909ff41fda"), "840", "4249426411690696", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c"), "08/19" },
                    { new Guid("0a4fa5f3-f2b8-4295-91c7-32dd5d3ed5cd"), "418", "4688966592739823", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a"), "07/25" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0ac0c00f-d691-4ce1-b0f9-bee71de8ea53"), "569", "6966849615709865", new Guid("f8331316-2615-4a9c-aac6-3bc582886724"), "01/12" },
                    { new Guid("0ae907aa-3159-4cdc-acaf-e0d157a88a76"), "262", "3907738062714764", new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001"), "11/05" },
                    { new Guid("0b2372eb-82b5-4c2a-bb1e-04dd7ff9161c"), "419", "2350119107812731", new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68"), "06/22" },
                    { new Guid("0b7a14f6-df10-451d-b710-6872731d90be"), "304", "1048276181233321", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9"), "07/19" },
                    { new Guid("0b7c9628-5c10-4d4a-b6e6-e8b79db2b42b"), "972", "1423271959384741", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1"), "02/09" },
                    { new Guid("0bafcd7c-5722-4a77-b33d-307523b0b54a"), "352", "7389386665219285", new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7"), "07/14" },
                    { new Guid("0bc003bd-c402-461d-a872-3c6ef5c7f733"), "350", "6521359474459576", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2"), "05/27" },
                    { new Guid("0bce4f7d-5aea-4ab4-9609-d3e65eec18c5"), "497", "1797669755928872", new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe"), "03/10" },
                    { new Guid("0bdef793-11b7-49d1-b004-0c6554c071c3"), "792", "1545627992569208", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603"), "10/15" },
                    { new Guid("0cf4a39b-70a6-4b94-9592-aeec4fa8d88d"), "107", "7760277305782328", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131"), "05/15" },
                    { new Guid("0d309cfa-52d9-4e75-854b-152029a69e51"), "972", "3902754383413199", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08"), "09/01" },
                    { new Guid("0d32e5db-03f3-4466-a809-729cd9a2fe6f"), "042", "7600547026104534", new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2"), "03/19" },
                    { new Guid("0d657cbc-8304-4811-8ef6-64bd9bb361dc"), "983", "8114271424593978", new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08"), "09/09" },
                    { new Guid("0d93c87d-d017-4cfa-a5a5-7de911cfde16"), "869", "7342894571703869", new Guid("914a9168-2743-43d3-9989-0d61085f953c"), "11/07" },
                    { new Guid("0e86758e-a0a5-40be-a075-4024ca975811"), "400", "9139280274091327", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65"), "11/11" },
                    { new Guid("0e8be783-3b49-4f99-9ebd-ec0d234ade20"), "290", "4737902658857642", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a"), "10/23" },
                    { new Guid("0e9e2a11-3119-4b62-ab1d-b049c05271e0"), "430", "1196269836821639", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), "06/11" },
                    { new Guid("0fd58853-af74-44d9-a2cb-1b113b56d3ea"), "444", "4451947002324199", new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8"), "05/27" },
                    { new Guid("10038b3a-39a4-4e55-a0d4-4c7f657f0aca"), "096", "2980134154102002", new Guid("914a9168-2743-43d3-9989-0d61085f953c"), "04/18" },
                    { new Guid("104d1412-ad59-4015-b335-72bec413a912"), "237", "9308566338908339", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46"), "02/02" },
                    { new Guid("110ba2c7-263c-4fff-89cc-b9bf0b3a6d34"), "132", "5546347596390698", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467"), "07/13" },
                    { new Guid("11691ffb-623e-4672-b39d-0c80fd40aebf"), "734", "8047374305337059", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65"), "04/12" },
                    { new Guid("11953e62-86b7-4f2c-b1b1-5215f05c80e8"), "993", "7218239778948521", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9"), "05/08" },
                    { new Guid("127e2687-de77-4ca2-83c8-594ca1413707"), "054", "1728657890173495", new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3"), "03/13" },
                    { new Guid("129482b1-35d0-4e3b-9e1e-dc1907bc8d38"), "575", "4911720468023831", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c"), "06/19" },
                    { new Guid("12ef195e-067e-4047-b8e7-15a801f89ac6"), "721", "6712455158753768", new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97"), "05/02" },
                    { new Guid("1351a60c-2a40-4026-b636-f47cec5c6493"), "961", "1090301107262503", new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299"), "07/07" },
                    { new Guid("137104a9-8c08-4619-b974-cd882a6b8290"), "880", "5967333156510393", new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e"), "02/12" },
                    { new Guid("138159a7-4d9d-431d-b55f-b00ca22906e3"), "573", "8666705483535509", new Guid("feeae310-c37b-49b5-b035-e9098493766b"), "02/12" },
                    { new Guid("138919f4-ebbc-45db-8add-d6501fd589c2"), "280", "6571869769884268", new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4"), "08/08" },
                    { new Guid("13e6a2bc-3485-4ad9-b4ca-550432f09cdd"), "828", "5035220408583728", new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68"), "12/06" },
                    { new Guid("1492eb30-975f-4cfb-8bf4-1d3f497f65c8"), "263", "3815994335513203", new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66"), "12/24" },
                    { new Guid("14be2f0a-11eb-4212-aa2c-b76020d434a4"), "603", "5438609028138805", new Guid("0be23392-599f-43dc-97d5-6396327167ba"), "03/02" },
                    { new Guid("14d760fe-da24-4b95-b2a2-250806226c3f"), "560", "2597091239699513", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858"), "10/03" },
                    { new Guid("1579e5bb-7c23-4127-99dd-79f5cac3f05e"), "822", "6415434608511349", new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66"), "10/18" },
                    { new Guid("158a1db3-6571-4252-bbaa-5ca2b5bb60c1"), "522", "2878545160549896", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), "09/17" },
                    { new Guid("15a6b280-70ed-4753-b307-0e1d1ce4d715"), "805", "4062976795789747", new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430"), "05/12" },
                    { new Guid("15e83f25-d7ee-4c2d-8bac-2c89c936403c"), "029", "2769286170483816", new Guid("85465426-23bd-45da-8610-8fbf237a6018"), "06/28" },
                    { new Guid("162ab3df-ca08-4c31-bb19-dc8a436d3410"), "119", "9339594408541733", new Guid("e6097123-c594-4bdb-870c-0cf57528e39a"), "12/21" },
                    { new Guid("163e48f1-e1c5-4f52-b83a-323e71c737f6"), "022", "2330505859980960", new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc"), "01/25" },
                    { new Guid("1664b4ef-a4e2-4a0c-abf5-6122cad95dfa"), "785", "9431865517766581", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834"), "09/23" },
                    { new Guid("167647fe-7d56-48fc-91b0-f79f04ce5cc9"), "076", "4150079837791764", new Guid("7613a4be-1868-4124-8145-c559fd0b8b95"), "05/19" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("16fb3cf8-c0a0-4ec4-bead-79b1562686f2"), "637", "5130540444279298", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), "04/21" },
                    { new Guid("175c238b-fc75-4809-bb39-2ba6cec3ffbc"), "982", "7614557360007398", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b"), "09/11" },
                    { new Guid("17993f07-fc09-4ac7-97f5-636577fa79fb"), "480", "5023928948653437", new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7"), "06/24" },
                    { new Guid("1809b2be-f924-4546-9602-fe320566d49f"), "876", "5319115080275725", new Guid("b34e9d23-9b12-49b3-b069-734a50918afc"), "04/02" },
                    { new Guid("180f37e1-52bc-40c9-b5af-d755112e214b"), "414", "2636071403833293", new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e"), "05/20" },
                    { new Guid("184499a9-8b18-4f96-b7d5-77124ec69cef"), "660", "8446328148228368", new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4"), "06/27" },
                    { new Guid("19014216-0915-47a2-8334-ed31239de8b4"), "230", "4901549641091087", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01"), "12/08" },
                    { new Guid("193aa3ab-6c1b-47a2-a0db-e3cfc9df3a7d"), "365", "3136320419112147", new Guid("2e036c59-b30c-4add-a80e-9813b03909a7"), "01/15" },
                    { new Guid("197358ad-5088-4be1-9427-8fe279067fd3"), "606", "8177313152258531", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead"), "11/02" },
                    { new Guid("198d8695-7ed1-4400-b697-67e686a5cb6b"), "445", "7729395059270883", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c"), "02/08" },
                    { new Guid("19907402-4007-4750-a782-ace47459ff89"), "779", "8544250901630473", new Guid("def8845a-24de-49d2-a341-fdf28b9883be"), "02/24" },
                    { new Guid("19a972b1-5a4f-489e-a254-6a2c7579a02a"), "866", "8888088549370840", new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9"), "10/08" },
                    { new Guid("19cfb5cf-98b8-419f-a051-724af4171b00"), "899", "8058543752534318", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e"), "02/18" },
                    { new Guid("19f4c539-6ee8-436d-bfff-2a4efcfb6c70"), "330", "8847149212594454", new Guid("973d13f2-9619-4004-9439-5abc562bad41"), "09/22" },
                    { new Guid("1a0d9751-1001-4d40-8fd7-d89ac7ce8553"), "951", "4709002756328930", new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a"), "03/21" },
                    { new Guid("1a0dfa8e-9c29-4f14-a51a-f72affedaf16"), "995", "9464667729843003", new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b"), "02/15" },
                    { new Guid("1a802164-1d3d-4924-a863-43ba386a135c"), "629", "4014866144966947", new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10"), "10/05" },
                    { new Guid("1ac0b680-f6de-430f-8d10-7b5af997158a"), "834", "4169306779145270", new Guid("38262136-b169-413b-ac46-ad2f34893b37"), "05/26" },
                    { new Guid("1ad30636-8468-4ebe-80f1-dee6f60651ee"), "640", "1765856256815047", new Guid("0be23392-599f-43dc-97d5-6396327167ba"), "11/04" },
                    { new Guid("1b014b61-b0f5-4ee9-b7a1-c23e79446505"), "996", "6452562821665769", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), "03/09" },
                    { new Guid("1b670efd-3e68-4385-803b-0f9c5abb801d"), "191", "9277251965931364", new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888"), "10/27" },
                    { new Guid("1bf9678e-7675-441f-a144-5874891e2ff3"), "807", "3943946037789478", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141"), "08/16" },
                    { new Guid("1cc2992d-a2be-41a9-814b-c99ab1750b81"), "477", "3349127681036484", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), "08/16" },
                    { new Guid("1cf7a062-a79b-491a-8ca8-a1ddf62392c3"), "576", "2068053789902714", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e"), "05/07" },
                    { new Guid("1d5ade1c-9211-4504-855c-632e1b78df45"), "487", "3112102136267915", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f"), "03/15" },
                    { new Guid("1d60e97e-7f3d-4a44-99ad-b97a17ba3b6a"), "083", "7538010765170955", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf"), "06/11" },
                    { new Guid("1d9a957d-18ff-43a4-8055-e83263925bce"), "101", "5655376866220452", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467"), "11/24" },
                    { new Guid("1dabc765-d2ad-44f9-905d-797eeebc11d6"), "574", "5204246670426110", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834"), "03/20" },
                    { new Guid("1db5bbfa-9eae-41a1-99e8-7e67829b7764"), "579", "5072231309562054", new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93"), "09/13" },
                    { new Guid("1de758d6-a760-4134-8d45-0ee77769b03b"), "775", "6613847003069454", new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337"), "08/07" },
                    { new Guid("1e4c3317-4b60-4c0d-adcf-fface8c10382"), "879", "6644713319855307", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), "12/27" },
                    { new Guid("1e75a910-4808-4f29-86b0-5d9fbd5a4d8d"), "276", "1195405002056815", new Guid("d6044624-c058-4b3c-9d01-47f91c93279b"), "03/13" },
                    { new Guid("1ec0c4d7-fe3e-4a7e-9fb4-4503854dac54"), "654", "9767033395170169", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858"), "10/13" },
                    { new Guid("1ef995c7-c869-4283-9ff9-edcb60f97d39"), "584", "7477037806662756", new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2"), "09/26" },
                    { new Guid("1f50f533-ad89-4e6c-a683-88539d007f24"), "610", "2219678698920639", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3"), "08/22" },
                    { new Guid("1f57360f-84d3-4f63-ada0-17f845c69f18"), "030", "1633859937481074", new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19"), "11/22" },
                    { new Guid("1fa61bd0-3a8d-4029-ab2f-38c91247c13f"), "734", "6398782070312508", new Guid("5d96609e-242a-4e81-841d-15924cb829f7"), "09/14" },
                    { new Guid("1fe7d1af-f300-4d44-af5f-d56a4c7481f1"), "990", "1112559200119321", new Guid("41654f75-1b53-494e-9d06-289e15fbc423"), "08/19" },
                    { new Guid("20107606-f98b-4cfb-b8b7-4efb2a1c2442"), "443", "8043517447812523", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0"), "01/28" },
                    { new Guid("20146772-fc9c-4ff6-aac9-784396dc2a07"), "691", "7836885160505707", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17"), "12/18" },
                    { new Guid("20234cb3-4be7-40f4-9469-fab325e5d054"), "495", "1595713474693199", new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0"), "09/12" },
                    { new Guid("2038b649-6b27-4047-a2ef-1eeb3a54b0cb"), "306", "8985397156970472", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff"), "08/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("20606eec-d20c-4e07-b38e-421497fd9919"), "389", "4642884735183057", new Guid("41654f75-1b53-494e-9d06-289e15fbc423"), "07/11" },
                    { new Guid("208a9382-32c9-4511-b25c-ca997accd4ae"), "433", "2450974428475310", new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8"), "08/22" },
                    { new Guid("20d61901-69e5-4ab1-8198-efe211c961e4"), "630", "3834850846465016", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da"), "12/19" },
                    { new Guid("21083cf2-22ce-4986-8ab2-873d77bdb3df"), "115", "8954931037647248", new Guid("576c41db-7388-43c8-8b70-27543c323237"), "06/16" },
                    { new Guid("21ed04b1-5b0a-4dec-a7a7-8aa4acd7e50e"), "031", "6462334008022086", new Guid("d81428a8-c640-4761-b657-cfa05c180948"), "05/16" },
                    { new Guid("21ee4ffd-9d53-43c4-a7b2-ef391e0934fc"), "675", "4161702618622026", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17"), "05/01" },
                    { new Guid("221b7fb5-8707-44ed-ba2c-b45be9576076"), "011", "1149104538918593", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e"), "04/10" },
                    { new Guid("228330b5-bc5c-4eca-8895-4b25089ac6c0"), "847", "3321007109185998", new Guid("a9259e4b-5b4f-4608-968c-07272216574a"), "08/27" },
                    { new Guid("233a4ed9-52f2-47a6-98da-597314a24833"), "279", "5519257628049507", new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d"), "07/06" },
                    { new Guid("23d60bd4-e71c-4958-9671-4c0ea2616577"), "768", "7735381301300221", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf"), "12/01" },
                    { new Guid("24986349-a508-44ea-862c-9b6ce783c41f"), "505", "1980427396213430", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), "04/07" },
                    { new Guid("2543df8b-0671-4959-b207-a7134d7e826d"), "434", "6060345873196405", new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54"), "08/15" },
                    { new Guid("2563146e-d13b-46ab-b910-ee811df29f2a"), "600", "2972681956584501", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c"), "06/13" },
                    { new Guid("259da589-b140-4edd-9384-e441883550ce"), "536", "3340549120087651", new Guid("85465426-23bd-45da-8610-8fbf237a6018"), "01/03" },
                    { new Guid("25a26763-7145-4ed4-9c95-8f60db930389"), "744", "2524473569353896", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9"), "03/08" },
                    { new Guid("25a76092-5f78-4b0e-84ca-2cc5132b6338"), "587", "7942040222542342", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), "04/10" },
                    { new Guid("25ea013c-e991-4686-b435-5a2c838997b4"), "058", "7758734157019840", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e"), "03/19" },
                    { new Guid("262a8e7a-8189-444d-9d33-0cf9bcdee9e6"), "577", "6850708518426467", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7"), "05/17" },
                    { new Guid("264e21b2-84be-4725-8581-0556884feecf"), "177", "3487786167698930", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda"), "01/16" },
                    { new Guid("26b99a6d-c93b-4166-ad95-b514dd4f2832"), "117", "5229222401372445", new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b"), "09/23" },
                    { new Guid("2725d103-9001-4036-a035-3d7bbdd76d92"), "512", "9348809656743844", new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524"), "12/12" },
                    { new Guid("278d2339-0870-443f-a81b-d591e4773a6f"), "644", "1102946390101613", new Guid("0be23392-599f-43dc-97d5-6396327167ba"), "02/10" },
                    { new Guid("27d072c2-2daa-489b-85a7-ec7ad220cfe7"), "128", "1387575145533458", new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7"), "04/19" },
                    { new Guid("283515c5-7d87-40d6-881c-52000e20e877"), "317", "7244541566575704", new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc"), "03/15" },
                    { new Guid("284703e4-3f13-4a18-a959-359af1756821"), "473", "7753007428801756", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e"), "08/25" },
                    { new Guid("286fec2a-21df-4bd8-9258-412e5d9f25ce"), "819", "8064875782880557", new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9"), "09/01" },
                    { new Guid("28722010-c506-4265-afab-a485bac47a65"), "535", "3298550959257584", new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd"), "08/06" },
                    { new Guid("28bda09e-8412-4232-a2d0-ef08dd52fefb"), "324", "7000448381884593", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f"), "10/11" },
                    { new Guid("292487a0-6b29-47e8-a24e-b38557e7e7e3"), "049", "3233849861812924", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9"), "12/02" },
                    { new Guid("29a9a23e-725c-44ff-91d3-55107645ccb2"), "523", "2817196751167515", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f"), "02/26" },
                    { new Guid("2a38b6d0-14b1-4782-aac5-f7328963823b"), "915", "6965843093951363", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3"), "04/27" },
                    { new Guid("2a468967-ee36-42a0-ae1d-0105b9975fe1"), "862", "1129487134276461", new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2"), "02/03" },
                    { new Guid("2ab607cc-749a-4de2-934f-3e557da1e03a"), "662", "6975367456899349", new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4"), "05/15" },
                    { new Guid("2b44e6bb-7783-4e59-8e0b-6749562d6991"), "960", "1087923198433087", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85"), "09/21" },
                    { new Guid("2b5838ac-7fec-4af2-b51f-4001a2bd3749"), "189", "1068133220519502", new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f"), "06/17" },
                    { new Guid("2b58d1e8-dd31-4e89-8efe-a2352630826d"), "824", "8584676354997212", new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e"), "11/17" },
                    { new Guid("2b7a046b-c2fd-4c91-aa89-420c0bde4cbd"), "220", "8396583422474837", new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c"), "12/11" },
                    { new Guid("2b8813af-1505-4cda-8f98-5450889f91c6"), "704", "7363295791967566", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1"), "01/01" },
                    { new Guid("2bc2f003-fbfc-4b28-9bce-06489a80c165"), "482", "4827635470341182", new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714"), "07/25" },
                    { new Guid("2c4c407c-b2dd-4dc1-aa1b-4d2ac2d04869"), "511", "8855355293745193", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), "10/08" },
                    { new Guid("2cc11e70-7b70-4973-933d-c85613575c85"), "546", "6042947932774003", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd"), "03/27" },
                    { new Guid("2cd40a3c-93f9-437f-8c25-49e606e463dc"), "955", "4157664618661170", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b"), "01/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("2cd9a9a8-6c7a-44a2-8da7-036dc49f7f32"), "548", "4395359271678825", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), "01/28" },
                    { new Guid("2cf07ffc-6733-459a-a027-e84b6bfeb4cd"), "305", "5217257858352960", new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b"), "02/14" },
                    { new Guid("2cf66bc3-a4d7-4e85-b675-89ddbe679a2d"), "060", "1872063339222736", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17"), "05/04" },
                    { new Guid("2d1373a4-aee7-4cde-bbfa-a997cec15045"), "529", "4492536780078470", new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10"), "05/22" },
                    { new Guid("2d7e8e8b-d186-4d0a-b8b9-db64784bfcf8"), "116", "7687720425723135", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0"), "01/28" },
                    { new Guid("2dc08359-ae53-44cc-ada4-2bb9420d04d2"), "140", "8703441917006751", new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77"), "02/10" },
                    { new Guid("2dc73d3c-e2f2-4835-a2eb-a75ba10629a0"), "441", "3780399877283631", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac"), "04/16" },
                    { new Guid("2e40afff-aa24-4640-904a-89639a470fa0"), "194", "9118755658925708", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b"), "01/12" },
                    { new Guid("2e66b6cd-5628-4a2e-90c0-3cf28e8d5ad9"), "704", "5450393204431417", new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c"), "11/16" },
                    { new Guid("2e941699-b4b6-4279-940e-417234f98892"), "979", "2211728742341249", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2"), "02/28" },
                    { new Guid("2f2cba26-51ce-46ed-a80a-88c48e688839"), "687", "7989831391879862", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd"), "01/13" },
                    { new Guid("2f452302-f3b8-4f4e-8c1e-69547141725a"), "363", "7385674009529613", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b"), "05/28" },
                    { new Guid("2f4a9372-2d46-4025-8d50-fa1b46a885c4"), "436", "6005423725227904", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8"), "04/28" },
                    { new Guid("2f919e08-bb31-4025-97fe-2f20c8f33e40"), "395", "1175356552085344", new Guid("2183f862-871a-449c-b3da-ea6005e9e472"), "02/04" },
                    { new Guid("2fc06c47-400d-4fcc-ba08-830b7cea3b97"), "208", "6139285219883586", new Guid("69445845-4c7f-4276-a288-559e4b4df167"), "08/11" },
                    { new Guid("30beafcb-2bee-4775-b298-e271d2917a1c"), "688", "6309201778836359", new Guid("c559b832-f4e6-4f67-9eca-337973071293"), "07/21" },
                    { new Guid("30fa2134-d4d7-462e-85cf-6db710a01b09"), "329", "5458739683170495", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092"), "09/11" },
                    { new Guid("311d3ce0-df6f-4820-8319-af5d0b30a617"), "875", "8918287092037303", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), "02/01" },
                    { new Guid("31957c1c-0836-49f2-9d8f-747ab0166327"), "796", "4397282513531213", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32"), "04/07" },
                    { new Guid("31e67447-5d8a-4029-a5cf-38418b61e789"), "847", "3474024892555267", new Guid("576c41db-7388-43c8-8b70-27543c323237"), "05/03" },
                    { new Guid("320c66e1-3cea-43fe-b997-773ae6f490ea"), "223", "2168036409625657", new Guid("2183f862-871a-449c-b3da-ea6005e9e472"), "08/07" },
                    { new Guid("325c578f-03f2-420c-8229-783694012e0f"), "771", "2841384369313313", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), "04/20" },
                    { new Guid("327580eb-736c-4474-8152-c52b58d9ba1a"), "131", "4649883250753956", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b"), "03/14" },
                    { new Guid("333dfe12-7b91-449a-a6bf-6baa09bce842"), "234", "9008396748872451", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c"), "12/24" },
                    { new Guid("33a81301-e8d5-4788-8233-855e829f129d"), "581", "6129548826209142", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85"), "11/12" },
                    { new Guid("33d0e435-22df-403b-9abf-bab33602fe38"), "407", "9771548005645992", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff"), "02/24" },
                    { new Guid("33d84962-c8dd-4459-b307-3ed81ae14e3b"), "109", "2413096828462222", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9"), "05/04" },
                    { new Guid("33f1708d-8418-4f67-9fa7-7a364a03c3ab"), "427", "6636537308952866", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6"), "02/10" },
                    { new Guid("34518b80-2181-4199-995c-dfee241590a7"), "333", "9674647990795057", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1"), "12/20" },
                    { new Guid("34acf0c7-b3ce-4975-924a-478b5d295744"), "698", "1323782501300752", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426"), "12/03" },
                    { new Guid("34afbc30-7352-494a-ba07-517ce126f015"), "386", "3691991183264938", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5"), "12/04" },
                    { new Guid("35739ee9-48dc-4def-87d7-8bbd5379f6e9"), "005", "1588352868782795", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0"), "06/14" },
                    { new Guid("358309d9-bff9-47bc-8e57-d27384a4e247"), "669", "6571660321484523", new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2"), "09/03" },
                    { new Guid("35ad3353-376c-4d89-a0cc-5f2d98b03333"), "857", "3912654831423021", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), "04/08" },
                    { new Guid("3746376b-37f1-4533-9b3a-8f055ed60402"), "379", "4227637633083127", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117"), "07/21" },
                    { new Guid("37471567-78d3-4bcf-929d-05e720aae3e3"), "281", "4059146861675814", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc"), "05/25" },
                    { new Guid("38432d4d-8f30-4797-9605-55eb9e0f9ba0"), "544", "5367182283459258", new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299"), "10/25" },
                    { new Guid("38758105-4488-487e-92c0-818f53dab4fc"), "818", "5134753482347626", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4"), "06/03" },
                    { new Guid("3887e53a-c63b-4c9f-bf37-a45e7b3738ea"), "178", "2573079737961237", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e"), "03/10" },
                    { new Guid("38f3e809-a826-4097-b539-3788115a1a67"), "126", "1903217252192158", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b"), "10/16" },
                    { new Guid("3987a9dc-e77c-41a4-b32e-600c80163685"), "933", "6579340571853851", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3"), "06/08" },
                    { new Guid("3a5a2138-d30d-4de1-ae55-9c348a16d54a"), "708", "1823639287472384", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf"), "12/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3a739f49-b1c1-457b-80fe-33c2a230bcbe"), "055", "2090395615696152", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f"), "05/19" },
                    { new Guid("3a8c2b0a-c552-47cc-8ecf-75c7db4f66f4"), "364", "6089405992881821", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f"), "09/25" },
                    { new Guid("3b971931-0bf2-401f-aa94-f0345e33cd74"), "247", "9323800729611123", new Guid("b5652445-32c0-44e8-b366-391041e6d37d"), "05/24" },
                    { new Guid("3bbfb37e-0609-4a27-b659-4fb442db8ac3"), "525", "2992106608668196", new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b"), "04/01" },
                    { new Guid("3be0a2c8-b637-4035-84ce-ab23f778a47b"), "813", "6892598021385025", new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a"), "09/06" },
                    { new Guid("3c39104a-888b-433c-9bf6-b7f888ce214a"), "981", "2803470639628350", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd"), "11/04" },
                    { new Guid("3cc9ec62-1b3c-48ee-a76e-b9ce99f9d840"), "249", "3145688451023043", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3"), "01/19" },
                    { new Guid("3d6d0206-6fa2-471b-83e5-9e6089b368c2"), "417", "2917651512417309", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8"), "02/04" },
                    { new Guid("3e342b79-1f0f-442a-99e7-c6bba4c0fe46"), "212", "7228372363135457", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f"), "11/26" },
                    { new Guid("3e91bb74-11f9-4e03-8cd3-20a81594d279"), "409", "4127750387086914", new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100"), "05/08" },
                    { new Guid("3efd8e60-825a-4b12-96a0-2d89646198f3"), "747", "1657765830913321", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf"), "10/16" },
                    { new Guid("3fb6dea3-c5ac-44b4-800c-4c4a4c93fa09"), "812", "8040272511772648", new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df"), "02/21" },
                    { new Guid("3fc3e08b-7a3a-421d-a5e3-14f464c1567e"), "773", "8825845474021356", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179"), "11/18" },
                    { new Guid("3fd55556-1af8-41bb-b72a-ea20787d69a7"), "455", "4847027587307809", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd"), "12/26" },
                    { new Guid("3fe2d077-2293-4c53-aeda-08d0a9e31b36"), "470", "1101077881734084", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b"), "12/15" },
                    { new Guid("3ffe4d38-489a-4bf3-8f51-91b0f4d5c01c"), "487", "4347097020903406", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6"), "06/08" },
                    { new Guid("40585864-cc76-4621-aec3-df588e0ba988"), "623", "6710404047645335", new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232"), "04/22" },
                    { new Guid("40675f13-689b-4dcc-a0ae-da70499d6fe9"), "655", "9663793957739041", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c"), "11/23" },
                    { new Guid("40682f46-81b0-4d97-80e7-b2594f65c216"), "388", "6829870788786982", new Guid("e6097123-c594-4bdb-870c-0cf57528e39a"), "03/10" },
                    { new Guid("407f29ce-9867-4eba-ba4e-0d4de9b23510"), "811", "9361758030110066", new Guid("406d2568-124d-499f-ab91-bf26387bbe3d"), "11/20" },
                    { new Guid("411052d9-8248-40d2-9ced-eb539ba27307"), "350", "7471072015422881", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b"), "02/12" },
                    { new Guid("4147efdb-9ffa-4cd5-a5a0-e08a5026e669"), "789", "2790749934450369", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70"), "03/12" },
                    { new Guid("417cca6a-de1d-4351-8d99-a197aa81e26c"), "884", "3936435490835195", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b"), "09/11" },
                    { new Guid("419bcd2f-5fa6-4060-bd5d-1237ea1eb373"), "948", "6682672599432787", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679"), "04/27" },
                    { new Guid("420cf2e6-536f-49c1-8492-b21ff09434c2"), "979", "5292333486412596", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2"), "06/21" },
                    { new Guid("425627a9-c5d0-4a83-9c56-c1ac4e18b233"), "777", "7510669155541763", new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97"), "03/16" },
                    { new Guid("43b04b96-1c9d-47b3-b083-ab94cd6ea670"), "753", "9282675032390769", new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95"), "02/09" },
                    { new Guid("43e68ccf-c5a2-468d-9f1b-92bf13f1a600"), "643", "8651948349062438", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3"), "11/04" },
                    { new Guid("43f9474f-1836-43ec-87d1-4c7f972b684d"), "160", "9278462582648175", new Guid("d6044624-c058-4b3c-9d01-47f91c93279b"), "11/06" },
                    { new Guid("44237236-c448-4b49-b136-f9fe848e26a8"), "389", "2440637805081120", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89"), "06/07" },
                    { new Guid("4466c604-70ea-4f11-b568-d725fea2d904"), "223", "5109720646152853", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1"), "05/26" },
                    { new Guid("44bfe534-6755-4eb1-b3bf-3665574ff034"), "429", "6522484983226409", new Guid("a548d594-0e72-40b8-a222-3504b474972b"), "06/15" },
                    { new Guid("44ef96f9-30ba-4406-82cb-19afd9d3f26c"), "703", "4616435535677896", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d"), "07/24" },
                    { new Guid("4504712f-725e-4de7-9ba4-dd6d3d7bed42"), "764", "2381410489633913", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9"), "01/12" },
                    { new Guid("45093bb9-fc6c-4af9-ad21-a267a44e7dcd"), "555", "5664100508489372", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a"), "06/13" },
                    { new Guid("45379512-da1c-4fe8-857a-8d5d9370e92a"), "952", "1998918711979847", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a"), "04/03" },
                    { new Guid("4538f1ad-1e4d-4f08-b36b-5fca90e03dce"), "261", "3288198611427073", new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0"), "10/20" },
                    { new Guid("4580ea49-0ec3-4e42-920e-71d1ff43303c"), "501", "1393456946545965", new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e"), "02/14" },
                    { new Guid("45cf17e9-9b9c-488e-88cc-055fa432dab2"), "731", "7566642717491169", new Guid("61677545-614e-49f5-a121-bebdd3c34a62"), "08/20" },
                    { new Guid("45e7f606-11e1-4548-9c3e-746cb4f132d2"), "041", "4959643863874741", new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385"), "04/05" },
                    { new Guid("46959c38-a09f-4ed0-ad7f-e71e909ccfd2"), "509", "5416880104368968", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797"), "05/21" },
                    { new Guid("472c729f-7fd6-40e3-a9bc-0a939a915e26"), "148", "4914167049883636", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), "03/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("4738d97e-d112-43bf-918f-ab2dcc02e469"), "255", "1101865263955099", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47"), "05/20" },
                    { new Guid("47879686-2a5d-4bb5-afd0-a369011f772f"), "363", "7537716204630805", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d"), "08/02" },
                    { new Guid("47c79060-eef3-49e1-9037-4e4d96f225e8"), "082", "2909179276869749", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797"), "06/15" },
                    { new Guid("47fc5b9b-2d7d-4634-ac77-025259e9ed80"), "970", "1227673686425319", new Guid("988291f5-f421-4687-aafa-58e64481070f"), "01/09" },
                    { new Guid("4862b871-b05e-47e2-ba38-02c65c059347"), "591", "5966581718628282", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8"), "01/24" },
                    { new Guid("48730a3d-958f-4f7a-b638-06a355db0518"), "539", "5551231196060532", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9"), "10/06" },
                    { new Guid("48f26ffb-8f3f-46e7-9a95-3c2800dc9ab2"), "303", "5755402310627369", new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57"), "02/18" },
                    { new Guid("493f8f7e-6224-4aa6-a08f-0a29010c2a56"), "630", "1972824813688100", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c"), "12/18" },
                    { new Guid("496c6fc4-4fd5-45bb-8d4e-b78ee153a9cc"), "823", "8954533225681711", new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e"), "11/13" },
                    { new Guid("49eb2782-5ab1-4606-abaf-d72f450c9058"), "367", "1676660070632222", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c"), "03/21" },
                    { new Guid("4abcb267-6383-4ede-958b-4b2f62680b88"), "956", "2532810383509029", new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6"), "03/06" },
                    { new Guid("4b3a527c-23b4-4914-a315-e4b83ee9d4bc"), "348", "6729667053227464", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd"), "01/11" },
                    { new Guid("4b61ad7b-cc28-469b-95b1-9e2de42941f0"), "510", "5233068657502635", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5"), "05/17" },
                    { new Guid("4ba38203-71f7-4208-afbf-e62c1278ea58"), "961", "7456769276233725", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), "05/17" },
                    { new Guid("4ba61b38-6411-4aee-8ba2-49a419310a5e"), "205", "9505589072639431", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32"), "10/03" },
                    { new Guid("4bb433f8-8514-47e8-8827-a297c6a6ce90"), "431", "1338722790798545", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b"), "07/19" },
                    { new Guid("4bf6455d-a813-4521-bf56-1bac5a6a7457"), "052", "9001075918422797", new Guid("a548d594-0e72-40b8-a222-3504b474972b"), "08/05" },
                    { new Guid("4bffc862-f256-4fb1-b6fd-e39ea81e3a16"), "470", "8721808088903430", new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e"), "09/17" },
                    { new Guid("4c165c29-4bac-400e-a1c6-d714d6e63dc0"), "378", "3337464165504027", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), "01/23" },
                    { new Guid("4c2c954c-53bb-4e0e-9439-1dc5e3878001"), "944", "7522039889192431", new Guid("4b419694-b708-45f4-ba12-d448054d38e8"), "09/14" },
                    { new Guid("4caf5cf7-3015-4710-a102-17d1f3008926"), "770", "7966827238632239", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0"), "11/05" },
                    { new Guid("4cca3978-0c44-421f-bf54-f9e9c7479ec6"), "367", "4315351828327085", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a"), "12/02" },
                    { new Guid("4cf1cb1d-08a4-4114-8a54-a0f536917f7b"), "216", "6612105712215744", new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3"), "11/09" },
                    { new Guid("4cfdd273-626c-497a-aff0-4828197a53b0"), "882", "6879356219926530", new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295"), "10/14" },
                    { new Guid("4d3f3770-5dea-4a44-a1de-c2c5b2901b9a"), "603", "4046958324399858", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc"), "02/10" },
                    { new Guid("4d54ee73-6d7c-4383-bbd1-df89d92ccd64"), "205", "1585263808992419", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65"), "09/04" },
                    { new Guid("4d858150-58ef-45cc-904a-0f65a94fdd8b"), "128", "5612675061093878", new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f"), "06/16" },
                    { new Guid("4dd4e11a-6724-41f8-a2dc-9ed084a0f355"), "434", "2289718352869103", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e"), "01/20" },
                    { new Guid("4dffea40-2f59-4eb1-ae4c-9b9d7c0e1cdc"), "783", "1816190851113501", new Guid("31995843-45fb-4fd4-bf87-4209bd790c02"), "06/05" },
                    { new Guid("4e70b711-a8a6-4bb0-b359-55d199338f62"), "480", "7423334617444192", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3"), "03/06" },
                    { new Guid("4eb64ca0-454f-4e99-93fa-13021e53ca71"), "194", "9502110822988243", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf"), "07/15" },
                    { new Guid("4ee5e5a1-2375-4f48-a97c-5f3e178db6b8"), "193", "8746490908138151", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce"), "04/27" },
                    { new Guid("4f205e7c-63ed-4d4e-96a1-b4478c652cce"), "504", "7808454689024001", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c"), "10/17" },
                    { new Guid("4f92cc22-16c9-4272-8041-8c2b9768f143"), "031", "6619981130763689", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf"), "12/25" },
                    { new Guid("4fa76a2c-be0a-4a70-8795-6096606bb337"), "058", "7001651290716245", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b"), "09/09" },
                    { new Guid("4fc32070-8fb8-4757-9c17-780d322cbc85"), "908", "2800013579171828", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446"), "08/27" },
                    { new Guid("4fea2f69-9f8d-4b3d-bee3-7741c41c6ac6"), "861", "5801307461447925", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8"), "06/09" },
                    { new Guid("5019ceeb-d1d6-48e5-8743-d8f337896182"), "448", "8306530273099616", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0"), "07/26" },
                    { new Guid("50a0c354-f1fa-43c6-b3a2-4c5e2bd48aa4"), "255", "6259585079570504", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), "11/13" },
                    { new Guid("50b6c53e-0767-46f1-ba17-92f418f8b6ac"), "898", "3352210667927178", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a"), "11/03" },
                    { new Guid("50b73a59-f9e8-4ef1-9eb9-d949b31cb8c8"), "455", "4626332457921685", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9"), "12/17" },
                    { new Guid("50d38a79-3b2a-4818-becd-449a97eaccfe"), "042", "8694753769384401", new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01"), "12/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("51096a81-c650-4ec5-a660-cb8fcd8a3c68"), "177", "6073162245174325", new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc"), "07/03" },
                    { new Guid("516eb150-0a4d-4d26-8359-4f628744cf65"), "805", "1925020385627745", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd"), "06/16" },
                    { new Guid("5194da57-45b7-4eef-828c-7b4a65b8e02d"), "344", "8018907579473523", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b"), "01/21" },
                    { new Guid("51cc62a3-9a7e-409a-ba39-d3664fdccb5b"), "425", "6479186416297957", new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882"), "07/09" },
                    { new Guid("52522623-beda-47f9-912a-638d7515c289"), "414", "4392604708694326", new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb"), "10/28" },
                    { new Guid("52ff1a89-d7f8-4609-b110-b7736bdd3198"), "803", "7931769907605313", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9"), "07/23" },
                    { new Guid("52ffb75d-3091-4c01-a3e1-211dde675b31"), "698", "4161178707560736", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46"), "08/11" },
                    { new Guid("5361c83f-9e30-45c7-b967-bd5cec120af7"), "146", "8827509780684858", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc"), "04/27" },
                    { new Guid("53a49a33-d347-4cc2-99c4-795c4547f00f"), "042", "1477545136206064", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0"), "12/10" },
                    { new Guid("545d3a1f-baee-4805-85cd-164367cafd1f"), "852", "1019805584607820", new Guid("2b73b7f1-451f-41db-b14e-91c27c148562"), "04/04" },
                    { new Guid("54709183-24df-4fe4-b196-92d15e02991d"), "098", "9171771981305215", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426"), "01/22" },
                    { new Guid("54ac00f7-241e-47fe-b501-d6e315a374ee"), "398", "4176162770137619", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0"), "11/13" },
                    { new Guid("54bfbc36-9174-4c5b-86b0-b73c47f9d19b"), "865", "9560426879525038", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b"), "12/21" },
                    { new Guid("54d5e31a-6bae-4f96-9688-47716bbaef57"), "915", "3051225665255305", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), "08/23" },
                    { new Guid("551d146a-78e1-4001-99b0-3034d5d70525"), "475", "8706195479618222", new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2"), "11/10" },
                    { new Guid("551e8bd5-684f-411b-bc35-872ad0058c10"), "561", "8703178091265010", new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57"), "01/15" },
                    { new Guid("55a26064-87db-4e84-a216-4b4e7c68365f"), "610", "1687901100693995", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd"), "04/19" },
                    { new Guid("55a3a7ad-fff4-41b5-b61a-8031c730ab2f"), "561", "3619094011816358", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), "10/28" },
                    { new Guid("561f364d-9fd9-4ac9-b375-10b704f1074f"), "448", "9546818213891296", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c"), "04/25" },
                    { new Guid("570ce113-1027-4ed4-87fd-78b1ad01b549"), "610", "2408766006404569", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc"), "01/16" },
                    { new Guid("573a87fe-0a24-4176-8223-21bc473ed0d6"), "200", "1098617274528876", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7"), "06/11" },
                    { new Guid("578c6885-6325-4079-914c-106881b4d132"), "318", "5821747308905478", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5"), "06/05" },
                    { new Guid("58b1b4bf-e0e5-40a5-8449-0e523283eb72"), "836", "7540166598407379", new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193"), "09/08" },
                    { new Guid("58ed6515-f401-4cfd-b8f6-723646f7417c"), "788", "9778498238409968", new Guid("576c41db-7388-43c8-8b70-27543c323237"), "06/10" },
                    { new Guid("5926a9f1-89cb-43d6-b06e-b946d3622b18"), "869", "9993375726457996", new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff"), "05/14" },
                    { new Guid("5990fd9d-015d-48e3-9107-e2a2870f4af6"), "488", "9675488028158756", new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e"), "11/21" },
                    { new Guid("5a6dc96e-92c6-4b7c-a55f-69d72d36e5c3"), "848", "1347525641278993", new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e"), "06/22" },
                    { new Guid("5a9f650d-748d-40cd-9bf0-c93b481b5ff7"), "700", "1874085121756554", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131"), "12/18" },
                    { new Guid("5aeed598-1a23-487c-9050-fc143e24bb0e"), "808", "5680184390638059", new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01"), "10/21" },
                    { new Guid("5bbdb0b7-93a5-4c9e-8322-715355d54a77"), "748", "4519301914638741", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7"), "08/03" },
                    { new Guid("5bf20fa9-af5c-4bba-b5d5-dfe7114d6b57"), "882", "6128163511849563", new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4"), "08/12" },
                    { new Guid("5c112395-917e-4180-afba-e3410f59f25d"), "897", "8174133599222981", new Guid("a9259e4b-5b4f-4608-968c-07272216574a"), "09/15" },
                    { new Guid("5c1a3ce1-13ef-40ef-97f2-5a1663d7e346"), "453", "5222067462453042", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1"), "10/14" },
                    { new Guid("5c1f4e10-c3ba-4f8b-bcbe-2e5a4160b69f"), "924", "6509186774868695", new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919"), "03/28" },
                    { new Guid("5c2788f9-931e-4a4c-a161-eb09d51b49bf"), "582", "2979184511947980", new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee"), "01/02" },
                    { new Guid("5cdfa8d5-fc74-4519-afa8-1d431b27aada"), "796", "5114312968937989", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797"), "01/27" },
                    { new Guid("5d09eb6d-4bc8-4079-8374-d2efa147d438"), "045", "8330010063435353", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a"), "04/03" },
                    { new Guid("5d4e612d-af59-4edb-b648-73a7272c7dc9"), "126", "2052636445140721", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337"), "02/04" },
                    { new Guid("5dc2df77-4738-46de-994c-96611f155f14"), "310", "5578706170216394", new Guid("30eaf229-a750-446f-b353-8f619614a839"), "03/20" },
                    { new Guid("5e5f9b4d-3fb9-4d4f-a12a-b583e4f0b883"), "622", "3158434245807969", new Guid("63f59de1-31f5-4826-bae2-9494ab073e70"), "10/16" },
                    { new Guid("5ec073db-0452-4a39-bb0b-c51ab2b71837"), "875", "4110767377502019", new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888"), "04/28" },
                    { new Guid("5ed53cfd-fe73-4fd6-b497-e443549ce0eb"), "222", "8185933211529165", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0"), "12/25" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("5f000a68-61ed-4164-98d0-0cedfa65f1a6"), "331", "4156300393961806", new Guid("48f78165-0368-457a-a33f-c7c330b9016e"), "04/17" },
                    { new Guid("5f5b5303-f6dc-4516-8f83-5ed6cfce4c81"), "903", "2717988633500876", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), "01/16" },
                    { new Guid("5f6d8a7b-2aca-44f9-80b0-7d9537b3ec32"), "953", "2628037183568154", new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19"), "10/08" },
                    { new Guid("6008dc95-04ae-4c22-aefe-e4330d163aea"), "040", "5733396000721638", new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0"), "11/01" },
                    { new Guid("605929fc-a821-467b-a38d-36acf2b86dab"), "670", "6851949678571509", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), "12/02" },
                    { new Guid("60c7dabd-1678-44bd-b13a-bc774cf12944"), "214", "5198950051928476", new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae"), "07/15" },
                    { new Guid("60cfa963-cda3-4585-b598-3917c5ea1153"), "274", "4158333835890485", new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f"), "08/06" },
                    { new Guid("613bd489-849b-4a76-8fb0-8a83f20ff876"), "425", "8905807091471598", new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5"), "07/19" },
                    { new Guid("623fb382-a18c-4938-ad5e-0741ac99d981"), "252", "7298625451617070", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47"), "10/16" },
                    { new Guid("6266a837-c8f7-45e9-98ae-730048cae53f"), "416", "4455346474792463", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2"), "09/21" },
                    { new Guid("62727a8f-eaf4-41b7-be4d-6322ae8b1372"), "226", "9478832132654845", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9"), "08/16" },
                    { new Guid("6393eaf1-412d-48bf-b14d-014123ec2f5a"), "752", "5183753214708480", new Guid("3162f344-f10f-45da-971c-d41cc675f838"), "09/25" },
                    { new Guid("63ac6f08-f579-4e15-a23e-c172d9c75806"), "646", "1836817514648864", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c"), "02/25" },
                    { new Guid("63b29943-198a-4e0c-8958-ba810a10fab7"), "067", "1198798158258203", new Guid("988291f5-f421-4687-aafa-58e64481070f"), "03/24" },
                    { new Guid("63b667f4-44b0-4af7-ae1f-80bbaf2d9719"), "256", "4970518258889362", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2"), "06/28" },
                    { new Guid("64575941-024e-448c-9518-47f50c61f864"), "632", "9646912693435514", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0"), "02/06" },
                    { new Guid("646d489a-4786-45df-bb6b-c1c09aabf83d"), "272", "9271115295180788", new Guid("4f18c06d-9e38-4392-a135-68af41671c23"), "07/07" },
                    { new Guid("64e3638e-294c-4b66-8df6-aee6d2ee6fa7"), "014", "2276237924645311", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e"), "12/09" },
                    { new Guid("655df151-455c-49d7-95a6-0fe0ffb1df4a"), "078", "4761105529844861", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70"), "12/27" },
                    { new Guid("65c42df8-d5ff-4a68-9d96-d5ef1980bc24"), "293", "3914986802958955", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b"), "05/10" },
                    { new Guid("65cb7837-1516-4997-b58b-6d7931daa60f"), "095", "5537627442030497", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc"), "09/01" },
                    { new Guid("65fa2c21-1d2b-42a1-93ea-f8d4d472d122"), "892", "4850853774366010", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12"), "03/01" },
                    { new Guid("664b2d9c-7926-4179-9eb0-ae91fa44bc18"), "035", "5720114300334587", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3"), "09/14" },
                    { new Guid("664eecfb-9aae-4ff7-b479-c52244748469"), "559", "8526041136049738", new Guid("5f081f26-af78-4d3a-b693-1268567854c9"), "10/16" },
                    { new Guid("66a9b3d0-f189-479c-bd50-c7c202bd5adb"), "731", "9458699132662271", new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce"), "03/06" },
                    { new Guid("66b38e88-48b2-4eeb-b4ad-b6fe472d19b6"), "562", "4438916695691023", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367"), "10/22" },
                    { new Guid("67723b22-5ea1-47e7-9041-e784b85f2b08"), "623", "4640354619048255", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce"), "08/11" },
                    { new Guid("677fc73e-d000-4bd7-9f81-bb46a1da922d"), "487", "4102521425613104", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679"), "07/21" },
                    { new Guid("693941b3-acf5-4d3d-a98b-69d0e276ba83"), "161", "9645850810218483", new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54"), "12/05" },
                    { new Guid("69454fee-2f31-49a7-af6d-e38de751c5ba"), "813", "1757613359275398", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b"), "07/22" },
                    { new Guid("69c8e6bb-edf4-4657-9aae-6d1f3e6ff143"), "708", "6502878912037942", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f"), "12/19" },
                    { new Guid("6a22645c-2272-4534-8d08-5102943ac1db"), "965", "4812792360923796", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea"), "02/15" },
                    { new Guid("6a43b511-5ae6-425d-9b0c-1467ae05ab19"), "916", "2168801973868162", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "06/09" },
                    { new Guid("6a5acc13-4772-4e77-8af2-262755ca0d5f"), "304", "5021687691510486", new Guid("2b73b7f1-451f-41db-b14e-91c27c148562"), "01/04" },
                    { new Guid("6a893ba7-4895-47fb-b31f-a7f1e91c06ac"), "329", "8566394619759624", new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc"), "11/05" },
                    { new Guid("6a98ab8d-14f2-4c40-a8de-ffaa69a5ea81"), "599", "9886499420854873", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91"), "02/22" },
                    { new Guid("6ab18a58-54f5-4a47-82c9-643513bf5322"), "636", "8814973151589777", new Guid("29ab604b-7a76-439b-8129-93142c9b6cee"), "07/23" },
                    { new Guid("6acee59b-66fc-49cc-bbca-b9727c7e88fa"), "270", "2785630893564302", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85"), "01/15" },
                    { new Guid("6ae2da5f-f2d7-4675-805b-435a3f23300c"), "903", "2659604650827094", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac"), "08/13" },
                    { new Guid("6b276aef-877a-4c17-9a85-f19d93655086"), "820", "8329208400215318", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834"), "04/10" },
                    { new Guid("6b6b03eb-f49f-49b6-8e0e-e6fa017b7260"), "423", "5162295415845146", new Guid("b61b0669-9383-4f00-947e-75db5b8c7915"), "09/16" },
                    { new Guid("6b8892e8-6a32-4e9e-847f-9a8d12edc297"), "522", "6861371916930756", new Guid("914a9168-2743-43d3-9989-0d61085f953c"), "02/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("6bb141a1-97d1-4bc3-ba7c-48ec0525aa75"), "333", "6956551510662016", new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91"), "06/25" },
                    { new Guid("6bee5983-f206-4fa7-a787-c0a342e3c726"), "457", "4552303250912688", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c"), "02/28" },
                    { new Guid("6c0b2e65-a613-4b0a-a20c-f9855c4bb6d7"), "321", "1183123228764345", new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471"), "03/23" },
                    { new Guid("6ca2dceb-1f4a-4bea-aff2-13a726e70c46"), "622", "5700923738171896", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), "09/17" },
                    { new Guid("6ce490d1-d1c6-4d41-90a2-f5fe83ef61ef"), "526", "7086106117265029", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), "10/24" },
                    { new Guid("6ceb9872-d69d-4fc8-97fa-c6969e383ae9"), "332", "5658617622043401", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a"), "06/01" },
                    { new Guid("6cfb3c98-1c07-4053-b54f-2b87ad0d06a6"), "077", "6807717928694321", new Guid("d81428a8-c640-4761-b657-cfa05c180948"), "08/20" },
                    { new Guid("6d25d8a5-6368-4efe-973e-47f174dde960"), "978", "5886061503072237", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), "07/10" },
                    { new Guid("6d3966ce-da8f-4712-9de6-18a161bd9a60"), "695", "4134595485562944", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea"), "02/26" },
                    { new Guid("6d726e13-d7af-4ea0-93c1-d0689c6fd0b3"), "611", "6650766385427839", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc"), "02/02" },
                    { new Guid("6d82f381-445b-4395-950a-908f2aa1071e"), "853", "1859892758371447", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337"), "09/24" },
                    { new Guid("6d96521c-838d-405f-b7e6-2d9074407786"), "383", "8129472102176288", new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7"), "06/21" },
                    { new Guid("6da5726c-a41c-4e03-a709-22bc4eb697fa"), "776", "4410536651083491", new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764"), "02/01" },
                    { new Guid("6de446a9-210f-499c-b93c-a89048e6762a"), "555", "9861776858868404", new Guid("48fec127-ff7b-4341-9417-71a573651f92"), "02/21" },
                    { new Guid("6ebe8aec-98cf-4af4-8538-1dd3be07008e"), "743", "1904471551020289", new Guid("5f081f26-af78-4d3a-b693-1268567854c9"), "05/26" },
                    { new Guid("6f6f0b55-e685-42ca-b592-b89bde030be7"), "296", "6690092559682707", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9"), "04/25" },
                    { new Guid("6fc4ec16-4230-4dea-8ea6-e355477f303a"), "176", "2352215614742836", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85"), "04/19" },
                    { new Guid("70319545-28d5-43f3-96fa-6d9d73d9af14"), "212", "8889731025644691", new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919"), "11/09" },
                    { new Guid("70bc98ba-ce3c-4188-8822-4dcb69086054"), "174", "3658733768928312", new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337"), "08/12" },
                    { new Guid("70d3136e-2f43-4610-bf94-8244de478032"), "660", "9529520999154411", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead"), "10/10" },
                    { new Guid("70fb0858-0cab-4b90-a2c6-de0611181d2c"), "455", "2836419345541624", new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf"), "03/24" },
                    { new Guid("712d4a14-52bc-4fe9-82f2-25ba12dee4b3"), "567", "1493969737218293", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47"), "06/19" },
                    { new Guid("716ce561-adbc-48b8-b814-4207a65d8949"), "855", "1838588337857525", new Guid("f8331316-2615-4a9c-aac6-3bc582886724"), "11/01" },
                    { new Guid("72237ee6-1dc8-4f3b-85f6-310ced458711"), "232", "1801062488905469", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91"), "09/18" },
                    { new Guid("722f73cf-ded0-44e7-935d-dbfdd94b1557"), "687", "2357885130618579", new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2"), "10/12" },
                    { new Guid("72cd94c6-2c4e-4943-a08c-0947f5d73b71"), "606", "6807440103460637", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac"), "03/20" },
                    { new Guid("73efd2e9-22a6-4162-b928-33a04c77acd3"), "561", "9908546421410090", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2"), "10/15" },
                    { new Guid("740d3f67-d7e0-4496-9014-b8080e0f6527"), "746", "4310011878102518", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a"), "07/25" },
                    { new Guid("742fa54b-b4a9-40b6-892d-a9cfe52dd8b8"), "072", "3932290260530653", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), "12/10" },
                    { new Guid("74b78fe2-e0a0-43ec-af9b-1f67dd3923d5"), "865", "2842394855957511", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467"), "01/05" },
                    { new Guid("74c5cad1-314a-4a25-927b-67ff25c98d5f"), "787", "3063791018725979", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), "03/11" },
                    { new Guid("75144b87-22fe-4912-b675-4d9acdba78a8"), "939", "4362284377582865", new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33"), "07/20" },
                    { new Guid("7529af4b-2306-4080-a3f5-a99c84a711cf"), "658", "4871783985527051", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3"), "01/13" },
                    { new Guid("7581fc5d-d0aa-4858-9bc5-7fdb9f77c3c4"), "537", "8871074113486335", new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43"), "09/15" },
                    { new Guid("75a2660b-c392-44da-a492-2cd4216b2fa4"), "663", "4837810161689229", new Guid("4b419694-b708-45f4-ba12-d448054d38e8"), "01/14" },
                    { new Guid("75a3ad02-cdc4-432a-9723-0b78bf4fe327"), "942", "5667470272012880", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea"), "11/11" },
                    { new Guid("75c14689-c10c-4f46-9176-6e58e8655238"), "713", "7350684121570867", new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e"), "06/23" },
                    { new Guid("75c4e857-61d3-407d-88bd-568abf96ceb7"), "403", "1323595051074554", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd"), "05/26" },
                    { new Guid("75dace5a-c266-4bbe-9c0b-f78b1085a631"), "919", "3150630012619878", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6"), "02/02" },
                    { new Guid("75eea9af-72c0-4062-95e5-3992ba300c49"), "197", "8569685578798402", new Guid("f33ed058-0d5e-4f28-8270-398f55394914"), "09/17" },
                    { new Guid("75f54f9a-9315-40df-88a4-05ad4d928080"), "900", "9216558321706368", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0"), "07/20" },
                    { new Guid("76330e9e-24fa-41bc-aadf-72757bb55e17"), "674", "7167723091313930", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0"), "11/13" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("78560a21-30d8-4e0e-8d31-eaef36c04177"), "131", "7123863219644439", new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001"), "09/12" },
                    { new Guid("7865e299-b9c2-42a5-86f9-3e25c2d312cc"), "867", "2886128135878609", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), "10/21" },
                    { new Guid("7879bf2f-8566-49da-8884-23a756551f8a"), "955", "8110395256464458", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4"), "04/13" },
                    { new Guid("78ab2cf5-f966-4762-a221-0296d4836661"), "307", "3357935026180911", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f"), "10/14" },
                    { new Guid("78e82721-ed52-49f2-b712-b7fbe9f872c5"), "456", "8243266123288236", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797"), "05/09" },
                    { new Guid("795ed67a-dd26-4ca5-92cf-e933a52f302d"), "730", "6002019357599281", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165"), "02/03" },
                    { new Guid("7a30c76f-9c4c-43ae-9c0d-20eeb2a4decc"), "789", "5279083420643834", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f"), "09/11" },
                    { new Guid("7a36e0eb-b351-4aef-9ba9-6d0ce8d91e25"), "053", "9298971512585811", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9"), "04/20" },
                    { new Guid("7a5b2388-b9af-4e60-afdd-b0385b06059d"), "013", "4662691056595876", new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714"), "04/05" },
                    { new Guid("7b6a4ccd-8630-4208-9dae-4257a4b2ef8c"), "408", "6573277349876299", new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732"), "06/01" },
                    { new Guid("7c065ccc-0c13-4249-936c-1b654ec60d50"), "642", "4640576785949630", new Guid("def8845a-24de-49d2-a341-fdf28b9883be"), "04/24" },
                    { new Guid("7c92bf9a-bab9-468f-a5c4-9a88022e8f2f"), "811", "1895897335013729", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3"), "03/06" },
                    { new Guid("7c9a5d25-16f1-462a-bae6-b8e71670db3a"), "694", "7271976982018205", new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385"), "09/07" },
                    { new Guid("7cc97915-f8cc-427b-9d75-4a6f72e159cc"), "985", "4133312044102248", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d"), "07/16" },
                    { new Guid("7ce51a41-bbb3-45f0-bc2e-f80b3e9fcea4"), "285", "3972979102288382", new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df"), "04/01" },
                    { new Guid("7d452371-ad69-41b2-86f5-2a7a4245e94d"), "536", "5496152843015907", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a"), "07/05" },
                    { new Guid("7d50beb1-d182-4fb5-bda4-78ddda88917f"), "268", "6214106220160907", new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6"), "11/27" },
                    { new Guid("7d889ced-72fb-471e-9d41-563743391665"), "226", "1164183824150718", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c"), "05/13" },
                    { new Guid("7dc22b7c-399d-4e61-baf9-b75905b8fff1"), "275", "1150564510620805", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446"), "11/05" },
                    { new Guid("7dd92d18-5584-457d-bfa1-8478b0211130"), "865", "8836603524380662", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e"), "10/12" },
                    { new Guid("7e17427a-d215-4b4d-898f-4a972278099d"), "024", "6408302284538864", new Guid("85465426-23bd-45da-8610-8fbf237a6018"), "04/17" },
                    { new Guid("7e1eb6d7-6bd5-4c77-a416-69d78fe68d2f"), "496", "2076707264105514", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda"), "12/01" },
                    { new Guid("7e3057b2-8acf-4fb1-939e-ec5016685b96"), "233", "8065669819496696", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda"), "11/18" },
                    { new Guid("7eb68527-62eb-4316-9dd7-fde6098a42ae"), "641", "1222922743831277", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0"), "02/05" },
                    { new Guid("7ef11524-9394-48fe-adfb-18c4dcab0ed9"), "504", "5870188023525574", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f"), "01/24" },
                    { new Guid("7f262481-72e1-4e01-b6ab-45c641fbbff2"), "374", "4416819210413485", new Guid("f33ed058-0d5e-4f28-8270-398f55394914"), "04/15" },
                    { new Guid("7fdb9928-7635-47c0-a311-f20df4b06196"), "095", "8318180522546208", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac"), "07/27" },
                    { new Guid("804144bb-82ad-4aa1-8b24-2f8b44f4502d"), "651", "9027312001665338", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2"), "11/12" },
                    { new Guid("808ef4a0-49cf-41eb-8c23-9517196ad222"), "485", "5543680071576189", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46"), "04/06" },
                    { new Guid("80f9af8f-e65b-4fb0-863a-a100cff2a1d8"), "302", "8112877707100991", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), "11/02" },
                    { new Guid("81261dd5-b51d-40e5-b91d-7e0f3fc10789"), "090", "6723944089189210", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c"), "06/11" },
                    { new Guid("815b79f6-6e61-4755-85a6-f175d8a18328"), "590", "2225875763033456", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9"), "04/20" },
                    { new Guid("81607216-86cf-4d25-b95f-dc39633e560a"), "849", "3721074703079476", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1"), "02/28" },
                    { new Guid("81972d55-d817-4fcd-a6aa-0e80acb0df80"), "141", "5838179045554324", new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882"), "02/08" },
                    { new Guid("81bdaad7-acac-4740-8606-abaca8a32198"), "180", "9698775436946836", new Guid("86132647-79dc-4073-869d-dd0cc40068f9"), "02/07" },
                    { new Guid("8207b7d6-6afa-439e-87fa-11ca052e6a04"), "979", "5765723497948990", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89"), "01/19" },
                    { new Guid("82119a0f-f5ce-46ce-834d-cc19b12f4b2b"), "315", "4347154314476875", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e"), "02/18" },
                    { new Guid("821e92b9-a142-45f3-8db3-79f160fe0a6e"), "509", "3576249583904437", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f"), "12/21" },
                    { new Guid("8231d91f-c9d6-447d-a629-e151386dba70"), "328", "4625525828952158", new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7"), "08/18" },
                    { new Guid("83944349-96a7-4392-90fc-02784535b2e3"), "978", "2873263122689101", new Guid("36333093-6685-44ce-9e09-9007f88e766b"), "07/28" },
                    { new Guid("839f63db-c76f-42d7-b374-db3de715b071"), "847", "3868647341907035", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9"), "10/11" },
                    { new Guid("849da003-9877-42a0-b35d-409dc42828fd"), "130", "9632445774586081", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad"), "10/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("850172a5-38d7-4381-83ec-7a88dd5a93df"), "807", "9095269347744712", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141"), "09/07" },
                    { new Guid("85bc3265-4ec9-485e-931f-98d53c01c0f9"), "016", "3399838458329987", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179"), "08/03" },
                    { new Guid("85dbf4de-d339-4262-a366-29a3b7c954a5"), "587", "3798373136110535", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc"), "07/18" },
                    { new Guid("85e31490-8c67-4f04-b593-828eecd5a900"), "885", "2029109106930849", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d"), "08/23" },
                    { new Guid("8629850c-b231-4646-be1f-465f26550f4b"), "781", "5951665929829023", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131"), "08/23" },
                    { new Guid("869ccccd-0096-46b9-b508-054e60f22b17"), "909", "9651209098464545", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "03/09" },
                    { new Guid("86d44e37-26a5-4c00-a7e4-2a3674ae863b"), "581", "4743428219974738", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e"), "08/25" },
                    { new Guid("86e44561-cd4e-4ec7-a361-89eda1845638"), "063", "4127437808101389", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea"), "12/28" },
                    { new Guid("8724561f-3c7d-4935-8fd3-e4179e21569c"), "100", "8122298150826812", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea"), "11/02" },
                    { new Guid("8729bd0e-a833-408c-992b-a9ad9bba37da"), "956", "2495063601676705", new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff"), "04/12" },
                    { new Guid("8780ed73-2cb2-40af-862a-23ae4f0277b5"), "577", "2033441420200341", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446"), "08/07" },
                    { new Guid("879959d0-8a37-49ed-bf6f-9610f48f096e"), "382", "3907794276031509", new Guid("feeae310-c37b-49b5-b035-e9098493766b"), "04/17" },
                    { new Guid("87a62da6-d3d4-4074-8af0-972591e1dc99"), "985", "3037498990790717", new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb"), "12/10" },
                    { new Guid("87aedc3f-98b7-4b11-af08-5ab6ab343370"), "630", "6828387516849903", new Guid("41654f75-1b53-494e-9d06-289e15fbc423"), "12/11" },
                    { new Guid("882844d6-b668-4458-b8ee-9684e0ea1bd5"), "412", "3195595489704694", new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a"), "06/14" },
                    { new Guid("88898748-602f-49cf-be33-55ab47ad9230"), "652", "5796887670949090", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c"), "09/02" },
                    { new Guid("89244826-4960-48d7-b86a-1a94e1329506"), "020", "2278540176962408", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32"), "04/12" },
                    { new Guid("8950f08b-06bd-40d3-b7e4-434f571fd2ff"), "366", "5468834010333368", new Guid("def8845a-24de-49d2-a341-fdf28b9883be"), "11/18" },
                    { new Guid("895bd5c6-6c9c-42c7-8fc7-7b44bb3eb44a"), "504", "8767650917908943", new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf"), "07/20" },
                    { new Guid("89a19e41-3f57-41aa-96c5-831373b2c136"), "284", "1835005596867414", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b"), "04/06" },
                    { new Guid("8a2b43f1-2765-4787-ad6a-bf55ae00e7ce"), "795", "6467658111351103", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f"), "11/20" },
                    { new Guid("8a616cef-dccb-4e14-95de-4098bac2c557"), "980", "2905533310024880", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), "11/12" },
                    { new Guid("8a92322d-652d-4e72-abc4-6d5750f02650"), "181", "6742833793524319", new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204"), "12/15" },
                    { new Guid("8ac8a03c-6352-414a-8101-516e2f010b05"), "562", "8421440005666811", new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f"), "02/24" },
                    { new Guid("8e18d967-fc77-4569-80e5-08e0684d538e"), "105", "6313604791578257", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a"), "06/23" },
                    { new Guid("8e403eba-4aa6-4553-95e7-d5b9ca34e0d7"), "273", "9071376991380399", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c"), "06/24" },
                    { new Guid("8f1eae0f-61f5-4d9b-9371-9f2e746023ce"), "373", "4971455871492560", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4"), "07/25" },
                    { new Guid("8f38324c-b6f2-4d3e-9394-aad51a360e08"), "592", "9568579848534413", new Guid("f6425efe-44a9-4764-877a-c0d313b88196"), "10/10" },
                    { new Guid("8f5e44c1-c4b3-49f3-a0c6-73945f831ed8"), "467", "9423816021078735", new Guid("1f55a324-d084-4122-815d-e1f65a8435b4"), "07/27" },
                    { new Guid("8fc117aa-dd58-4e05-b2bd-3d5eff49b216"), "682", "3192390379674796", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e"), "10/20" },
                    { new Guid("8fc54114-d333-4663-a40d-2dbfe9d5b398"), "419", "6587577585065294", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17"), "01/09" },
                    { new Guid("8fe6c1d8-bdd0-4ced-b07e-d35bba8c33fc"), "536", "2240377034017701", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117"), "09/17" },
                    { new Guid("8ff164ed-8f17-484c-a35f-985bcf980594"), "370", "7228610134110734", new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430"), "11/13" },
                    { new Guid("9021a37c-94a7-4758-be10-bf4244a40fe5"), "936", "5811653133092513", new Guid("85465426-23bd-45da-8610-8fbf237a6018"), "07/25" },
                    { new Guid("903ad804-20f7-43a5-9dd6-c491649f0dd0"), "791", "2450691441687246", new Guid("b34e9d23-9b12-49b3-b069-734a50918afc"), "11/11" },
                    { new Guid("90421973-7838-463e-a551-d4ce79f920a7"), "082", "4831293679261102", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367"), "09/15" },
                    { new Guid("904a6607-626f-4635-8722-79676ef98cf7"), "594", "2261900437483847", new Guid("f6425efe-44a9-4764-877a-c0d313b88196"), "12/13" },
                    { new Guid("9099da9c-9f95-40aa-80a6-8d0ffed4c313"), "898", "6295875232542964", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6"), "06/15" },
                    { new Guid("91df96f7-93ab-4788-b401-73782a2e1e6d"), "696", "6197359183435178", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e"), "04/13" },
                    { new Guid("92288f7e-bd36-4d2e-9814-421e5fa81103"), "822", "6437928989889226", new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee"), "09/24" },
                    { new Guid("92792322-3ce5-4170-86cc-f3c5ea9cb114"), "486", "5150386909848271", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f"), "04/22" },
                    { new Guid("9315765a-7124-43a6-8e23-ddd71b38be55"), "683", "5022384507115430", new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12"), "04/28" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("933c2461-89fd-47db-93d4-1d05c5bfb245"), "857", "7454651237737589", new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2"), "12/05" },
                    { new Guid("933d8a1c-3cec-42b1-a7ea-099c0e728318"), "530", "8309256169884495", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c"), "02/20" },
                    { new Guid("93538a8e-a38d-44f9-8ec4-20b5ba0d5c02"), "077", "8556836337405471", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9"), "10/17" },
                    { new Guid("9357f71e-c975-45d9-9cb4-0816616c6b8a"), "293", "8849806197654699", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c"), "06/02" },
                    { new Guid("9360e4e2-7c2d-4488-a633-f1d90c37377e"), "679", "3530474556437950", new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e"), "07/27" },
                    { new Guid("938c7c0a-6933-4a2f-9f23-227c4fb342d7"), "695", "7735565896679944", new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd"), "04/21" },
                    { new Guid("938e93fa-e41b-41b5-b4cc-e523312940dd"), "929", "8022070359808573", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6"), "01/05" },
                    { new Guid("93a6e9c1-eab6-4dd8-87bc-6d11818cacfc"), "386", "9987920218529882", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b"), "09/24" },
                    { new Guid("93cc3278-96c8-4661-a3a8-b5d62709f0b3"), "266", "1821836860608665", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c"), "12/13" },
                    { new Guid("93cfcf7c-1698-4407-9bcd-fac92fc0be3b"), "340", "5020016164131667", new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646"), "02/24" },
                    { new Guid("943162d0-d607-43d4-870e-84faddef2120"), "094", "8611846050507494", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc"), "11/27" },
                    { new Guid("944403c4-e127-4cf1-8bf3-05e7123841e0"), "075", "2331582567385549", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "11/18" },
                    { new Guid("949d7867-b1d7-4076-91aa-55fdf9db6869"), "352", "9566849760644898", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a"), "07/05" },
                    { new Guid("94e6556e-d3ef-4f60-ba38-59f5f57c8bb8"), "563", "2986019197249635", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6"), "08/09" },
                    { new Guid("9539e13f-629d-4248-a3db-b8ec371a1b1a"), "769", "9847697547737112", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164"), "07/05" },
                    { new Guid("95cae66d-35b9-4036-a899-2f3b7fc0e5fc"), "487", "8171224679936880", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b"), "11/03" },
                    { new Guid("95ed3a51-60c1-4953-a992-36d05205a6c6"), "048", "1525786239384715", new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e"), "05/13" },
                    { new Guid("9641e2d7-51d4-4c9a-b0ad-0d0e08ce6d80"), "900", "5788745361911587", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7"), "07/08" },
                    { new Guid("96a85803-83a1-4f6d-9846-6188c168bc14"), "344", "1039356657328592", new Guid("c559b832-f4e6-4f67-9eca-337973071293"), "08/13" },
                    { new Guid("96d79094-d620-4c46-8a46-cdf161bc400e"), "144", "5936857343422499", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3"), "12/08" },
                    { new Guid("96f24e10-ed62-4318-b826-ccc72e6d9156"), "933", "3233713233285912", new Guid("0459684a-9478-4760-922c-cdff0f159395"), "11/01" },
                    { new Guid("97d994d2-4044-4206-9169-5bcc1699c971"), "908", "5016080319570563", new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413"), "01/07" },
                    { new Guid("984824d2-c264-4430-8caa-c66dfb7ce8b2"), "678", "2687542954548499", new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022"), "03/25" },
                    { new Guid("989f9800-4deb-41e4-b18c-3c3b8a227c4b"), "267", "8417022001794070", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a"), "09/05" },
                    { new Guid("98ba8ec7-4e97-4435-89e2-07b55fd266c3"), "425", "1407332210987083", new Guid("973d13f2-9619-4004-9439-5abc562bad41"), "06/23" },
                    { new Guid("99141a1f-86a9-4ff1-bac2-8df6e830bf51"), "981", "1570625919131301", new Guid("31147f68-7359-46eb-af11-622a8764424a"), "08/14" },
                    { new Guid("99aa136d-1b9f-40c3-be8c-14bb17ebed1e"), "797", "2588486234427754", new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4"), "10/05" },
                    { new Guid("9a3cb7ee-a9fb-4cf8-8ff6-eab52d624ab9"), "355", "8129440864904486", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c"), "07/19" },
                    { new Guid("9b8bcdc0-df03-47ed-882d-e4b2084f3424"), "618", "1210998767414954", new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee"), "03/17" },
                    { new Guid("9ba3ddb8-9601-4833-8aa3-18e2d3e7f0b2"), "559", "3443547782160776", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f"), "05/08" },
                    { new Guid("9ba876e3-7850-4aa8-a0b8-b37c1ee4c0d6"), "363", "6215515667787935", new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022"), "10/16" },
                    { new Guid("9be11e12-bad2-42fa-9cb8-d734bad95dde"), "775", "5055189231080931", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9"), "02/03" },
                    { new Guid("9c9e9d40-7983-4d59-8a03-d436f188174c"), "853", "7299202556069549", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f"), "12/14" },
                    { new Guid("9cde740d-475a-4194-aaf9-c9caf3eb0b6e"), "826", "8273863698278482", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182"), "06/23" },
                    { new Guid("9d3f85e5-0bc3-4e30-b18d-3667885bbe92"), "238", "9876069489258588", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead"), "09/08" },
                    { new Guid("9da6e749-d347-44b3-8157-e178cbb472e0"), "992", "6289301391579146", new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a"), "06/18" },
                    { new Guid("9e86d1b9-1af4-4e0e-b72c-1909a094d062"), "795", "8796498923114082", new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6"), "01/14" },
                    { new Guid("9eb3682b-d69c-4760-9fb7-6d17473c46b4"), "172", "6498465490712406", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08"), "10/07" },
                    { new Guid("9edc5f1f-2e75-4e4a-9a96-76c9e5efa858"), "921", "5007631730732162", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f"), "01/03" },
                    { new Guid("9f13cbde-b969-4f53-9c3a-bbda8a348855"), "283", "6327637279789889", new Guid("b5652445-32c0-44e8-b366-391041e6d37d"), "11/18" },
                    { new Guid("9f2d4b03-0953-4c5d-bcb6-b6450dba1bac"), "363", "5369082664321963", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603"), "04/10" },
                    { new Guid("9f38a2c5-b05c-4f9e-a295-8ffa26e3f225"), "142", "8322224556931479", new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6"), "04/17" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("9f6893f1-1d97-4cfb-9a29-96750989ba9a"), "931", "3340103857524187", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1"), "12/27" },
                    { new Guid("a0957239-80e5-4e05-8f1e-4998250b2e86"), "820", "1677297172842285", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8"), "07/10" },
                    { new Guid("a0ca9224-1970-428e-b1d4-0c7180d3a316"), "945", "2685200487742957", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c"), "03/05" },
                    { new Guid("a0f247ae-8054-4ed9-a15a-5ae3d3c3f736"), "488", "7689141307166917", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad"), "02/08" },
                    { new Guid("a11589b5-e5ef-4111-ab39-ce9d2223ecc0"), "256", "1525522817162480", new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d"), "08/23" },
                    { new Guid("a12869f4-fb58-4c38-8445-9c9028945587"), "877", "9709279096349294", new Guid("4b419694-b708-45f4-ba12-d448054d38e8"), "03/12" },
                    { new Guid("a15c0a33-b813-4669-83ad-d70dcdf6727b"), "596", "3550473689688644", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a"), "04/27" },
                    { new Guid("a1a85335-2054-4b1f-9bcd-28917ce96d7a"), "012", "8883282239217717", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3"), "02/27" },
                    { new Guid("a1c21a77-5a63-4bd8-b97e-9e2a96e19290"), "447", "4746486509608957", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), "09/05" },
                    { new Guid("a21a34eb-263d-4345-ae52-2c45ba703f14"), "674", "1127453873555938", new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa"), "05/09" },
                    { new Guid("a29a9671-74b4-417c-a28b-802432669d3d"), "191", "7223487209720230", new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2"), "07/26" },
                    { new Guid("a2e5dde1-b019-4a7b-b512-ff86f67c3c68"), "720", "9406487642697002", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9"), "12/12" },
                    { new Guid("a351f27c-e984-485f-a00a-f25923775b60"), "916", "2487106011663698", new Guid("db25f40f-9692-48ca-96f6-63866a9c9299"), "12/04" },
                    { new Guid("a372525d-2205-4c68-80eb-06f991315244"), "876", "1671806509613729", new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232"), "07/26" },
                    { new Guid("a3919768-b6ff-4bd0-ba49-ca111e24ef90"), "608", "9207070972506891", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092"), "11/04" },
                    { new Guid("a3cac481-e987-4b81-ad50-5bf471b329d0"), "030", "1339618651112967", new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9"), "12/21" },
                    { new Guid("a40f3411-3666-4822-91a2-950e1580912b"), "981", "8949498802868669", new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2"), "12/13" },
                    { new Guid("a446a678-737b-4732-b6d2-3b06cf1170f0"), "356", "9557762720388728", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0"), "02/17" },
                    { new Guid("a4f48cd4-a169-4291-8851-00f9b200cb44"), "694", "2338349229263433", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f"), "01/10" },
                    { new Guid("a5353143-1f99-4285-9637-2b5657f9a3fb"), "553", "4257073611562078", new Guid("db25f40f-9692-48ca-96f6-63866a9c9299"), "10/04" },
                    { new Guid("a5478fc5-0108-41cc-abad-d7bdff9d8535"), "706", "9993027632128826", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c"), "08/20" },
                    { new Guid("a550a524-43d3-47f1-bcba-8811fbb93e70"), "604", "3861300583132865", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), "09/14" },
                    { new Guid("a5539668-3657-4f97-bab7-99dc3d6e335c"), "468", "3087842398652124", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da"), "12/15" },
                    { new Guid("a5f035de-cfeb-46bc-ba38-4c434941d49f"), "853", "6665851269874530", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426"), "07/01" },
                    { new Guid("a608c26d-b922-4efa-8b81-3431fabdf55f"), "554", "1965736206523424", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e"), "06/22" },
                    { new Guid("a653df8d-acc6-4bcc-9fa4-b15900c67241"), "677", "6756017528966085", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a"), "01/03" },
                    { new Guid("a6f56efd-42cd-4d53-aa9f-56f3e072e71e"), "630", "8978322444772367", new Guid("36333093-6685-44ce-9e09-9007f88e766b"), "05/28" },
                    { new Guid("a73a405d-a917-4000-87af-422edae6b03d"), "478", "2373316737403600", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91"), "02/15" },
                    { new Guid("a7673f2f-d947-4f46-9f32-2e2b2792c000"), "257", "5752398153665829", new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471"), "12/17" },
                    { new Guid("a7b36194-1b7a-4ffe-a1b3-8c656179bacd"), "451", "5470475499760775", new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0"), "10/25" },
                    { new Guid("a89cb6d2-72a1-460f-931f-98e160bff3be"), "690", "7623807097807664", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d"), "09/24" },
                    { new Guid("a8d82171-e551-450b-b1d6-d7c7c86e6229"), "647", "1833376824239981", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b"), "12/10" },
                    { new Guid("a8febe0b-4210-4813-ae58-920e53ba99db"), "316", "4829413401393199", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12"), "05/13" },
                    { new Guid("a90756b1-b907-4d76-9ed2-eb18ee7c5a30"), "173", "1907499128438301", new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b"), "07/10" },
                    { new Guid("a950f103-fd5c-4fac-a75d-4ddd24ea8512"), "293", "3479345621503236", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd"), "01/15" },
                    { new Guid("aa98eb2d-09b9-4e48-a886-386afd774e49"), "046", "4740774596942266", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0"), "03/16" },
                    { new Guid("aaca2a6e-bd60-4c34-a43d-ebb32e56d9f6"), "609", "2313654947213394", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c"), "04/04" },
                    { new Guid("ab17cff5-22ed-4dfb-ac47-55cde9f37442"), "399", "2688817483012510", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e"), "06/04" },
                    { new Guid("ab50d494-a98c-4101-928e-e19d29e1abf9"), "515", "1458084794538600", new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7"), "09/13" },
                    { new Guid("abc5c02e-1ac4-4994-b036-7c03c07d0696"), "543", "3093906923876519", new Guid("41654f75-1b53-494e-9d06-289e15fbc423"), "02/03" },
                    { new Guid("abdb596d-1803-46ea-846d-a6f5a17f68e9"), "887", "9896819581769054", new Guid("60de2347-d620-407d-9699-3b783da3d34d"), "03/16" },
                    { new Guid("ac672a19-1fd5-41cf-88e6-cd1367be3bce"), "416", "7945395549284162", new Guid("86132647-79dc-4073-869d-dd0cc40068f9"), "06/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("ad0720bf-c3cc-4792-a826-ecafd2fecdaf"), "597", "6571734363519924", new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe"), "08/10" },
                    { new Guid("ad2db479-4373-41ab-a61f-39b687d21ad4"), "340", "6703886033904404", new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0"), "09/17" },
                    { new Guid("ad40dfb6-5007-4613-8c00-6fe4263fc7ec"), "748", "5464888648095251", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164"), "01/05" },
                    { new Guid("ad528950-05f3-4027-b7b1-aa6e643c0c36"), "149", "3557011246442226", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f"), "05/26" },
                    { new Guid("adac6ad6-9179-44e7-a16d-a9d166cef907"), "426", "7493514177500380", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c"), "07/22" },
                    { new Guid("adb34c62-9cd7-42eb-8601-a96541b8dcf0"), "372", "5630005703561238", new Guid("0459684a-9478-4760-922c-cdff0f159395"), "12/17" },
                    { new Guid("add219b8-efa0-4f4d-bed6-29a6c59ecd40"), "901", "2396804922347308", new Guid("61677545-614e-49f5-a121-bebdd3c34a62"), "06/01" },
                    { new Guid("ae010a0f-28ae-4039-8bbc-87989f2835bc"), "571", "1440608109157579", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165"), "11/02" },
                    { new Guid("ae3fe309-e7d9-4190-a3af-bfa7d2cf3ea7"), "159", "3379077294912090", new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95"), "10/14" },
                    { new Guid("aee86d90-5c9a-4446-b715-947e17f3c278"), "458", "9895281650054316", new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e"), "10/09" },
                    { new Guid("af24f70a-5ccd-48b9-95c3-8f5e517f01d3"), "997", "3654274565317243", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da"), "01/13" },
                    { new Guid("af255309-a166-40ec-b764-a486dcc06cb5"), "399", "3586738713286410", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131"), "01/09" },
                    { new Guid("af6e4f90-4c31-4020-8da6-b335ccb5a4c1"), "492", "3415308802018215", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), "03/02" },
                    { new Guid("b025a622-af71-46f5-a306-216aac8c0312"), "707", "4224721062482710", new Guid("406d2568-124d-499f-ab91-bf26387bbe3d"), "07/05" },
                    { new Guid("b03e7afc-a666-4931-a831-1993041307d7"), "588", "2554456237348239", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12"), "02/17" },
                    { new Guid("b14311b0-e678-4ed3-9a9d-e255aa8e744e"), "618", "2998627377440553", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164"), "06/21" },
                    { new Guid("b158bc9c-db2c-4ab7-a9a0-e613bcc15f34"), "446", "6269882873018782", new Guid("def8845a-24de-49d2-a341-fdf28b9883be"), "02/18" },
                    { new Guid("b1ed5081-b61e-4cbb-9d8a-ec806ee13ac4"), "740", "6382096596755992", new Guid("6bd6126d-6465-493b-abdc-935b7afbc646"), "08/28" },
                    { new Guid("b3033e84-63d0-424b-a468-ed29484e4350"), "154", "8291662898287428", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d"), "11/08" },
                    { new Guid("b325b74b-a6d9-4f21-90eb-5ef0ef05805d"), "587", "1496808468636280", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f"), "09/22" },
                    { new Guid("b331c989-8df5-41db-be1d-4f0b33210469"), "608", "3713935616933083", new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295"), "08/16" },
                    { new Guid("b391221e-6e1e-4495-a024-1a9d9a0f2571"), "281", "7673475693675747", new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826"), "04/28" },
                    { new Guid("b392d4c7-169f-40b5-ad2b-6a69556e0423"), "138", "2607752165300831", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367"), "02/03" },
                    { new Guid("b3b0a520-1e31-4be9-be75-f5479710eb06"), "558", "4129947811701776", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9"), "11/18" },
                    { new Guid("b43a1dec-d31b-4466-aff5-76e6f1c32cef"), "369", "3849987533828117", new Guid("4b419694-b708-45f4-ba12-d448054d38e8"), "02/23" },
                    { new Guid("b441dc5d-5c35-42ea-b9a8-35e7f44c6c9b"), "478", "4680701133124682", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c"), "04/01" },
                    { new Guid("b5061d24-9402-487e-abab-ca4d944ed947"), "573", "4861888369191782", new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7"), "02/23" },
                    { new Guid("b5a7ac78-b538-457a-9197-3abcaf2fba67"), "367", "1705141754677800", new Guid("86132647-79dc-4073-869d-dd0cc40068f9"), "07/27" },
                    { new Guid("b5edd876-df53-49df-b06d-f33a53ab9268"), "730", "7177616485298935", new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6"), "08/13" },
                    { new Guid("b64dcb11-dfe1-4910-ac28-c2e14ddf0a45"), "641", "4684649131198958", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092"), "09/22" },
                    { new Guid("b6748936-5543-4124-965f-a3acca57639f"), "796", "7870958602738262", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6"), "08/11" },
                    { new Guid("b69066d4-4627-41b2-8920-65f6e8905645"), "841", "5209855543623978", new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765"), "07/18" },
                    { new Guid("b6f17bdc-228f-4ad1-858b-3a057de9e510"), "324", "6397057117871622", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512"), "11/16" },
                    { new Guid("b71dc58e-c1db-415d-8f79-68fbf7360e53"), "326", "1407237332888819", new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982"), "09/03" },
                    { new Guid("b75bab21-7ae0-42e8-b365-a137ae0fc205"), "404", "8026062922988216", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad"), "06/04" },
                    { new Guid("b77134b4-beec-46cc-ba26-a4b1a0702a91"), "204", "5780547931119760", new Guid("ff032668-ac2d-465e-a8be-49991c69a967"), "08/05" },
                    { new Guid("b79a3a04-3fed-4422-a00b-07bd3d995838"), "804", "6761370148244080", new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8"), "11/13" },
                    { new Guid("b8409a09-0fb4-4fdf-b3ce-d4407e2be088"), "869", "6818966049819059", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c"), "05/23" },
                    { new Guid("b84f8f5a-ff6f-4263-b327-eecf84c669d9"), "041", "9247523284717133", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf"), "11/15" },
                    { new Guid("b8d3479b-a82b-442a-b255-bc53c9929933"), "261", "1241631958794556", new Guid("4f18c06d-9e38-4392-a135-68af41671c23"), "02/17" },
                    { new Guid("b92e5726-fbcc-4f9e-a373-930a94ba2b73"), "859", "2664485533174119", new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10"), "09/06" },
                    { new Guid("bab773de-6fd8-4a00-8539-16871b958bd8"), "071", "6622146684960683", new Guid("914a9168-2743-43d3-9989-0d61085f953c"), "08/11" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("babaf0f3-e3fb-4550-96fa-83f07cfc379c"), "282", "1719295406460516", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e"), "04/11" },
                    { new Guid("bae0fc01-e212-4c3e-a984-22e0c49af575"), "433", "6731438977700424", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b"), "01/17" },
                    { new Guid("bb6da2da-f070-4b6e-b00b-c24ca53f5b73"), "002", "3610377519435333", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d"), "11/08" },
                    { new Guid("bcd26f9d-f76a-477d-828c-a3ce3f26faae"), "512", "4855024535045975", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e"), "02/06" },
                    { new Guid("bd122637-ca26-42a1-a800-ac3abc6bec26"), "995", "5548746050022215", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426"), "09/08" },
                    { new Guid("bd7ca0e0-f689-47d5-a843-d278c9702dc7"), "574", "6089864583056096", new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10"), "10/15" },
                    { new Guid("be1cb0c3-1546-4a9e-8389-e56a8839f0a7"), "729", "5762385989996987", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6"), "10/27" },
                    { new Guid("be45022d-a3b1-4a21-a5de-30119dcb1b3e"), "540", "3570003436085060", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf"), "10/13" },
                    { new Guid("bf245747-b198-45a9-a04a-f930386312b4"), "069", "7328961342829161", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f"), "06/17" },
                    { new Guid("bf3eabf2-82a8-485d-be02-cbac6592af50"), "258", "9899458957582813", new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7"), "12/11" },
                    { new Guid("bf47729c-1ccb-4af0-ab11-3033f79fbf62"), "829", "4195134759034032", new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764"), "04/13" },
                    { new Guid("bf5cb24a-6098-4356-9733-592a3d7fe7ce"), "822", "9267593325010807", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3"), "03/05" },
                    { new Guid("bf6b8819-072a-44f3-9300-bac5a7d09b5d"), "800", "4129950572526828", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89"), "11/25" },
                    { new Guid("bf853cd0-b23f-4e0f-8654-112914d59af6"), "522", "5025261702681295", new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9"), "01/21" },
                    { new Guid("c01e293a-db84-4f01-ac17-91eb35ba1475"), "697", "2980972771107214", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46"), "12/10" },
                    { new Guid("c120d5ea-2d88-48f2-aaa6-60dda3ac3afe"), "577", "7459983377141695", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df"), "08/14" },
                    { new Guid("c124fa04-494e-4eee-8de5-32834f521747"), "079", "4447921625584929", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e"), "08/26" },
                    { new Guid("c169ebb1-1a4a-4665-a226-7bb5590adc3a"), "527", "9120027284145572", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce"), "08/23" },
                    { new Guid("c1f24436-b87d-4385-ba5d-3678137a8e21"), "645", "3950401252898786", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165"), "07/01" },
                    { new Guid("c272da48-0e26-4436-ab8c-ac706bf6f985"), "407", "8006115696440630", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7"), "03/17" },
                    { new Guid("c2df9360-b513-4ff5-ba2c-4a15e1207df2"), "960", "8888881841961206", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367"), "10/14" },
                    { new Guid("c2f74808-04fb-45a9-b5fa-bb32050b07cc"), "727", "7072367416561777", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9"), "08/11" },
                    { new Guid("c2f8c5a3-629b-4e25-a2c4-55e0fdd30a9a"), "649", "6876930510579218", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01"), "09/26" },
                    { new Guid("c368a2d0-ac51-4a3b-ac25-409837dbb267"), "634", "8525670410024635", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b"), "10/19" },
                    { new Guid("c36e28d7-8c33-4a46-b6e2-3989b344e0a2"), "008", "7384511818578233", new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4"), "09/26" },
                    { new Guid("c3b3372a-2e09-433d-b4f3-0553bccff65a"), "963", "4545227535276330", new Guid("38262136-b169-413b-ac46-ad2f34893b37"), "05/25" },
                    { new Guid("c3f25b83-9d25-4b31-8dc9-d3e2afe35de1"), "437", "8705164690051793", new Guid("2183f862-871a-449c-b3da-ea6005e9e472"), "02/13" },
                    { new Guid("c4179b7b-f4e3-4269-9687-8a6175337ad7"), "104", "4803291357824531", new Guid("d81428a8-c640-4761-b657-cfa05c180948"), "11/04" },
                    { new Guid("c46dcdfa-9001-44ef-b77b-4a761e316af3"), "373", "1762940192117928", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a"), "09/28" },
                    { new Guid("c515c481-6a90-46bb-a0bd-49ddaf4cd76f"), "685", "6604125635585741", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f"), "03/14" },
                    { new Guid("c5292480-118e-46ee-8a56-97177e1c38b7"), "238", "7191094915973337", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858"), "03/01" },
                    { new Guid("c551287a-55be-4447-ba58-12eeea3d6cfd"), "926", "6969054726454204", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337"), "05/15" },
                    { new Guid("c5b69d5e-cd8d-43ca-91fe-2c761268e7b5"), "386", "4705335113922660", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e"), "05/19" },
                    { new Guid("c5c1c728-c251-4cd5-81d7-e1800fed5b72"), "426", "1053095772495298", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70"), "08/14" },
                    { new Guid("c5f38c4a-62f2-4321-81b0-acffe57cd013"), "325", "3656005413285085", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf"), "09/03" },
                    { new Guid("c6be7e4c-acd9-4e94-a0c5-b71906d1f6e5"), "759", "5593387166218887", new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee"), "07/16" },
                    { new Guid("c6e756ff-ce3d-4c32-a1fe-759ef4d7cc8b"), "466", "2166373846408881", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2"), "10/01" },
                    { new Guid("c6e8cda8-e3c4-4982-8f2b-caaa2128012a"), "619", "3880776328444455", new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3"), "07/07" },
                    { new Guid("c7976467-f2da-4926-9031-cc280cbde4f3"), "259", "5909643280502813", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b"), "12/09" },
                    { new Guid("c8181764-1c24-466e-9245-5b9dbe49cb61"), "267", "5480989842017157", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df"), "10/25" },
                    { new Guid("c823dc9b-e596-4b7d-baac-18aa0708ccf3"), "133", "2955412779082871", new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91"), "10/18" },
                    { new Guid("c8ad9aa1-cad0-4f81-91e4-db2cd9c87029"), "642", "2355245361825704", new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a"), "09/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c91f5aed-130e-454f-815e-4a0ceb8b20e2"), "182", "4594686060151157", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a"), "07/01" },
                    { new Guid("c92ed29f-d5d5-4579-912c-2d13d7226b00"), "404", "9089403163372603", new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0"), "08/06" },
                    { new Guid("c948f66f-d60d-486e-8fff-0dc3a94ac582"), "716", "5987096945531540", new Guid("48fec127-ff7b-4341-9417-71a573651f92"), "01/03" },
                    { new Guid("c94b1df4-a4da-4781-bdee-b91d66b8011e"), "439", "3489715007782314", new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b"), "09/02" },
                    { new Guid("c9c42982-6d29-4544-a5e4-331998489501"), "603", "3975447977786016", new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8"), "06/14" },
                    { new Guid("c9f8db4f-fe87-4e79-bef9-14a2c498e028"), "010", "6036309859941869", new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8"), "10/04" },
                    { new Guid("ca4b4930-ed02-4088-ba00-4a4f8ad02e4f"), "513", "6228538161874692", new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5"), "06/18" },
                    { new Guid("ca4c6463-3d02-4b20-9617-72fcf8ae3e36"), "174", "7717365746149182", new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b"), "08/27" },
                    { new Guid("ca56eb27-0a79-4251-86c7-17c2b9a24ab1"), "899", "6049590521929678", new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204"), "03/21" },
                    { new Guid("caaa2d43-bc7f-4804-8026-91730f6c5920"), "891", "2973957576227718", new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb"), "03/06" },
                    { new Guid("cadf37d5-58ba-44a0-9bd0-a591f991ee53"), "448", "1328075681370898", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6"), "11/28" },
                    { new Guid("caec2fc6-c036-41b1-84d0-d28bba57eca3"), "090", "8714018768832901", new Guid("0e809aac-90e9-4073-992f-0a9348838efe"), "07/10" },
                    { new Guid("cb3ad02a-741f-4c07-aa9e-25150c9ce8a7"), "134", "2290489599650635", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7"), "11/02" },
                    { new Guid("cb3c7dbe-3190-4c35-bb52-a4953b8d1b85"), "842", "4353174435428532", new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93"), "05/07" },
                    { new Guid("cb89d10d-ee98-4bdd-bc11-3d2a1691ac42"), "785", "2245010074710363", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df"), "02/04" },
                    { new Guid("cc175158-39f6-4609-a783-16d3654744b0"), "107", "6723432696774476", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f"), "07/09" },
                    { new Guid("cc49744a-2eef-4c5d-8699-af8add20db04"), "137", "4632308416585865", new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d"), "01/06" },
                    { new Guid("cc5fbfe0-4d90-42fb-a20a-1be2c20b79c1"), "993", "3008346383834793", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd"), "11/25" },
                    { new Guid("cc95bda1-4a5f-4d6f-aae1-df487f193b5a"), "420", "8696865652599756", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f"), "01/28" },
                    { new Guid("ccc0a630-682f-428e-9f26-a9f4c9e5cf5c"), "377", "7138470723690212", new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08"), "01/09" },
                    { new Guid("cd25b866-80a1-47f8-a9f5-9f5777eafff0"), "715", "3615754029886702", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3"), "02/22" },
                    { new Guid("cd94e465-45fd-433d-8b9d-0bcb72e180b3"), "745", "7869772715930437", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01"), "12/14" },
                    { new Guid("ce07f0ad-4cc0-4040-87b1-8bdbd67e3d49"), "557", "1757702683795573", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1"), "02/13" },
                    { new Guid("ce29637b-43cb-4fb7-a4bb-abc1676b78cf"), "717", "5869971897193493", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7"), "11/11" },
                    { new Guid("ce4427f6-f68d-496c-afbb-7c5c5fad6cf4"), "531", "8474308795403474", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89"), "01/06" },
                    { new Guid("ce9028d6-b4a1-4952-bae4-518a2439aa5f"), "376", "8240422251295723", new Guid("0be23392-599f-43dc-97d5-6396327167ba"), "11/02" },
                    { new Guid("cec2d759-3f78-4e19-9eaf-439aa3efd90e"), "857", "6130513735038324", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a"), "05/20" },
                    { new Guid("ced8196a-91d6-4264-82f9-86d2ea63254e"), "469", "1560913518671972", new Guid("61677545-614e-49f5-a121-bebdd3c34a62"), "04/17" },
                    { new Guid("cfc4bf69-57e9-4bd6-9776-622752ccf41e"), "123", "9591554055878127", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b"), "02/01" },
                    { new Guid("cfc97863-4bf9-4cd2-8789-98652ba2fa8b"), "241", "4073095520511102", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3"), "07/27" },
                    { new Guid("d007843c-492a-4fa5-98c9-0966753219e0"), "642", "8358854424666442", new Guid("3162f344-f10f-45da-971c-d41cc675f838"), "07/05" },
                    { new Guid("d04f4b49-7544-48a9-94a5-927a878ad6c8"), "046", "9436776183475649", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda"), "06/23" },
                    { new Guid("d10436ae-c59e-4f59-ba9c-40bdd9724174"), "986", "8952268040045824", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7"), "06/25" },
                    { new Guid("d160207a-b0e7-4e3f-b679-9f717635e5b3"), "621", "9804220391239827", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64"), "01/26" },
                    { new Guid("d1d8c6b5-30d2-4993-ace8-4b9262edf4b0"), "006", "3810000449812189", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b"), "05/24" },
                    { new Guid("d1eec68f-25e0-4792-83b2-b94d8b25e2e1"), "550", "7410833612913195", new Guid("61677545-614e-49f5-a121-bebdd3c34a62"), "02/23" },
                    { new Guid("d1fea2ae-a757-46c3-9bf5-ade392b1b64c"), "401", "9165527431290807", new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33"), "01/14" },
                    { new Guid("d210e9e7-83a0-46d3-be65-6cab5de071a1"), "912", "3199291671619941", new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66"), "04/19" },
                    { new Guid("d27272d9-db13-4e67-b8df-a82d261c5efa"), "534", "5529529896086876", new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b"), "10/22" },
                    { new Guid("d27e8600-1544-4066-bdff-7d5d5dec3c95"), "273", "4159598352880840", new Guid("31147f68-7359-46eb-af11-622a8764424a"), "01/10" },
                    { new Guid("d335e0c7-5bc0-44b3-8ea7-2e6875dc0473"), "314", "8032224101619354", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49"), "03/08" },
                    { new Guid("d33b5b3c-fabd-4063-946e-7657c0691951"), "613", "6120012718980630", new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2"), "03/02" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d395cc81-5dae-4615-ab9d-b3dd745371dc"), "603", "3445799389615345", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a"), "03/08" },
                    { new Guid("d3a14b65-7bf4-4bdc-8d84-f10900c61f69"), "411", "5405960532948539", new Guid("3162f344-f10f-45da-971c-d41cc675f838"), "03/28" },
                    { new Guid("d3ec356a-87c3-40a3-a523-f088f37dea06"), "015", "7876302976870740", new Guid("0459684a-9478-4760-922c-cdff0f159395"), "10/06" },
                    { new Guid("d3f33ec4-d0ed-49cb-8b16-583df303c47f"), "550", "5148273774199988", new Guid("6bd6126d-6465-493b-abdc-935b7afbc646"), "04/18" },
                    { new Guid("d412ca4e-0186-46f3-ab74-4ab6c5f6d2c7"), "712", "3964001153067777", new Guid("a9259e4b-5b4f-4608-968c-07272216574a"), "11/25" },
                    { new Guid("d43b68cf-43d6-4f69-909d-2a40e15d07aa"), "256", "7323115929377276", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141"), "06/19" },
                    { new Guid("d47b799d-8d02-49a5-8d13-bd4189485696"), "677", "6797989064543211", new Guid("b61b0669-9383-4f00-947e-75db5b8c7915"), "07/18" },
                    { new Guid("d48e4662-63cb-4d91-8905-bc975d22afa7"), "573", "3036505807391234", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8"), "11/18" },
                    { new Guid("d5531f0d-95f9-4155-988d-560e3993523c"), "322", "7563633207536350", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446"), "08/08" },
                    { new Guid("d5dd7b88-347e-446a-85c9-3f195f79b894"), "069", "8796732369468022", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8"), "08/07" },
                    { new Guid("d64615f4-7343-412f-a910-0de16bcfe957"), "855", "6054219128527228", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3"), "05/01" },
                    { new Guid("d736ee69-cdac-4180-b163-b30a724ff315"), "218", "2349654867897690", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32"), "04/15" },
                    { new Guid("d75788ee-3faf-4fdd-b574-5c1d166ea00f"), "273", "7668237714761148", new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e"), "07/26" },
                    { new Guid("d75a92a0-3caa-4214-b163-8ad9356cfc73"), "825", "8695894876841975", new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce"), "07/25" },
                    { new Guid("d8463be2-5fff-4b31-a70f-31063306b1a9"), "337", "1567695353985299", new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6"), "09/03" },
                    { new Guid("d859ebbc-82c7-4e1d-8455-1f29839839eb"), "840", "1461724839993777", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7"), "11/19" },
                    { new Guid("d8eb9b78-e7c6-4e5d-b03b-29571d8c5c5d"), "279", "1766330043608493", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117"), "01/17" },
                    { new Guid("d8f52281-0c54-4461-b95d-2c82b6d87b2f"), "686", "3297378657940679", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179"), "02/08" },
                    { new Guid("d8ffc5fc-1a3d-48cc-8a1d-2a43d01ee085"), "967", "9304010255310280", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5"), "12/13" },
                    { new Guid("d9691c56-db2a-4b30-aff3-736621c13621"), "772", "4230785483203794", new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413"), "01/16" },
                    { new Guid("da099ff3-7798-46f3-abd2-cee3d599ff79"), "770", "4904941925335022", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f"), "09/02" },
                    { new Guid("da221c7b-4c88-4c13-accb-23b940cd4700"), "284", "1438810893327097", new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206"), "06/20" },
                    { new Guid("da3a83c7-a689-4079-8ef9-efba3526c0c3"), "501", "5499253064454894", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b"), "10/27" },
                    { new Guid("da5cb833-68ee-4e98-9abc-9604a5e0ee1e"), "552", "6561654778866128", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a"), "02/26" },
                    { new Guid("daabde2b-5653-4b2d-85a7-dedbbc35b5ae"), "227", "9064675735159511", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699"), "07/28" },
                    { new Guid("db1ca5a4-d181-4a60-8865-77a9a7387157"), "191", "7843810440273130", new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100"), "04/14" },
                    { new Guid("db22bd90-60bc-46ef-adaa-d43ba62b35b9"), "611", "6954254006422948", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e"), "02/01" },
                    { new Guid("db354752-fb74-482d-893c-4249b908a48f"), "232", "2818652714268316", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a"), "04/24" },
                    { new Guid("db59ec02-510a-467f-a503-f3462f9dd66d"), "283", "3402510445693105", new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae"), "03/13" },
                    { new Guid("dba45aa0-6825-4f0a-a7c7-ec07a4ce3677"), "572", "3992043430861032", new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d"), "05/16" },
                    { new Guid("dbf74857-edc3-4a22-9a19-339c1e86c40b"), "624", "6280686900364638", new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2"), "08/23" },
                    { new Guid("dc11c2c3-3933-4799-bc76-6e5451e8f382"), "635", "2998008315903398", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd"), "11/16" },
                    { new Guid("dc255995-1bbe-4a58-ac59-618b07bc8d93"), "694", "2491199248197692", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164"), "10/11" },
                    { new Guid("dc3bb975-5b6c-4bdd-9a64-e7286888b5db"), "010", "3794349381416981", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679"), "11/23" },
                    { new Guid("dcb88621-ac34-46c7-9a29-23e3ef74c7e8"), "131", "8744740161916846", new Guid("38262136-b169-413b-ac46-ad2f34893b37"), "05/22" },
                    { new Guid("dcd70233-bebc-413b-8d48-d0ac615a9a51"), "911", "5467796432543471", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858"), "01/16" },
                    { new Guid("dcfd1fb7-b150-4d62-8491-12b6e3ce7e3c"), "556", "2489698212309491", new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b"), "06/10" },
                    { new Guid("dd0e0a6a-250e-4123-a35d-e7b254f34084"), "058", "9840726132374218", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), "06/18" },
                    { new Guid("dd63485e-e346-4a54-986b-38f6036f8ba4"), "244", "7140670949001715", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7"), "09/03" },
                    { new Guid("de1510c0-789f-41ce-9095-3a64054e5ec2"), "740", "8597824679646228", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2"), "03/28" },
                    { new Guid("de2d09af-e189-40ec-94fc-e624005930fd"), "220", "4265025594941816", new Guid("30eaf229-a750-446f-b353-8f619614a839"), "04/18" },
                    { new Guid("de85dccc-135a-407c-865f-2fe3cdbb8c8d"), "644", "8515756889703252", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f"), "05/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("debf6f2d-d45a-4f1e-9c6f-cd9921186122"), "355", "7246959599449081", new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6"), "10/03" },
                    { new Guid("dfc1d4d6-f05a-4ee4-8bf5-73231e14d53c"), "115", "2321645764929387", new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826"), "12/13" },
                    { new Guid("dfd4a611-c63d-4a33-a546-cbd2487646df"), "102", "3214970002593466", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c"), "12/24" },
                    { new Guid("e065b797-d399-419c-94e6-b7785f213474"), "125", "4936874542922373", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df"), "11/16" },
                    { new Guid("e0b20a9b-03b0-439f-95f4-2f769ced41ca"), "154", "6570194003201361", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08"), "11/04" },
                    { new Guid("e1107fdb-4bf9-40f7-81e0-29578b923524"), "672", "8072140972655666", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91"), "10/23" },
                    { new Guid("e1507958-2d8d-4ab2-941e-b5b22464b61d"), "021", "1267231064049442", new Guid("d81428a8-c640-4761-b657-cfa05c180948"), "07/03" },
                    { new Guid("e1d2f165-9248-48bf-bd43-9ef598f85bb6"), "217", "8816213138107914", new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3"), "05/02" },
                    { new Guid("e1edaddc-bfaf-40ab-9df4-88c7b0c4430d"), "079", "8517506830829528", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2"), "10/05" },
                    { new Guid("e201e34f-5635-49ca-a06c-e6e559f1371e"), "351", "8800441241782307", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd"), "02/15" },
                    { new Guid("e27ccad1-d503-4aba-985b-6cacd1337991"), "357", "1251713802460699", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c"), "02/04" },
                    { new Guid("e2a8421f-f0eb-4823-b6a9-48e17064f111"), "768", "8436911243729003", new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6"), "01/02" },
                    { new Guid("e38f5b04-5c49-4c31-8771-4c9d28b63588"), "531", "8536956579759507", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c"), "12/09" },
                    { new Guid("e3e0f23f-7f52-42e7-9daa-9c305fd03526"), "490", "4124390425404708", new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982"), "07/20" },
                    { new Guid("e4f67665-42f8-47cd-bafb-a905d55582ad"), "219", "1613639947874712", new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f"), "12/20" },
                    { new Guid("e5213744-3e02-44c2-a6b5-648dee9ac8f3"), "328", "3199059020139374", new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732"), "11/02" },
                    { new Guid("e6945b3d-89a0-4609-be98-24ac3ae06879"), "728", "3829163537975636", new Guid("29ab604b-7a76-439b-8129-93142c9b6cee"), "04/21" },
                    { new Guid("e7023d8b-1a27-4b04-bd7b-e089608a8f3f"), "912", "3187505954617230", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699"), "09/13" },
                    { new Guid("e7522f73-6628-4942-b2c9-60de7125a97d"), "939", "3346687290386345", new Guid("973d13f2-9619-4004-9439-5abc562bad41"), "08/21" },
                    { new Guid("e7b903c2-26d1-434d-a383-fbb877fce139"), "100", "5672381512721872", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9"), "06/18" },
                    { new Guid("e8d011da-d8b4-451d-acd7-2f071ba36cc4"), "572", "4301263333668479", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a"), "05/20" },
                    { new Guid("e8d325a4-cf53-47d8-b2f5-e20e2dda2472"), "022", "7781864476100738", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0"), "04/19" },
                    { new Guid("e95c3795-e553-4b71-a899-49098f899d6d"), "961", "1001844276234968", new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646"), "12/22" },
                    { new Guid("ea011438-c416-4b26-9bb5-e1ea9099eef5"), "378", "4018991142627674", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c"), "03/21" },
                    { new Guid("ea03559d-4624-4f81-8a7f-eed7c1e55d58"), "337", "5755341356093940", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834"), "09/24" },
                    { new Guid("ea795346-c87f-4df7-9dcd-c1b52c391103"), "232", "6378100636999278", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d"), "12/16" },
                    { new Guid("ead93315-b3dc-428b-b0a1-9f21cb74b315"), "136", "3197609208361659", new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb"), "03/19" },
                    { new Guid("ead945f6-c8bf-43d8-b53b-10c2554d08b2"), "283", "6449088512637409", new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b"), "05/07" },
                    { new Guid("eaeba540-f299-4efc-b529-74f68095cfd9"), "440", "4913851724000982", new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc"), "08/22" },
                    { new Guid("eb615bca-753e-4bc8-aeaa-a203b061026b"), "312", "6218625624847943", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b"), "12/19" },
                    { new Guid("ec0c74cc-29b6-463a-927b-9be3cbb69feb"), "921", "1647644923547157", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65"), "10/27" },
                    { new Guid("ec7bb8b0-9aee-483a-9d3f-2514abb4b316"), "488", "4912131002378438", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12"), "09/17" },
                    { new Guid("ed40ce44-dea1-4156-9e32-d3dfc079d477"), "822", "8523518048868301", new Guid("973d13f2-9619-4004-9439-5abc562bad41"), "11/05" },
                    { new Guid("ed42fb17-8cb5-425f-98be-85fbdab67508"), "680", "2820512591262273", new Guid("31995843-45fb-4fd4-bf87-4209bd790c02"), "07/23" },
                    { new Guid("ede772e8-045a-47cc-9a14-6bbc0ff03037"), "163", "9516661315341895", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce"), "09/02" },
                    { new Guid("ee489141-e0bd-4d85-b27c-973e793aa525"), "305", "7215906549770015", new Guid("3162f344-f10f-45da-971c-d41cc675f838"), "10/03" },
                    { new Guid("ee6bb573-e337-44ff-a0a4-3cc651e2b1f2"), "710", "6609059732767574", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179"), "06/09" },
                    { new Guid("ee85c960-28bf-42df-9219-1a836337dd43"), "066", "5089247072626487", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9"), "06/11" },
                    { new Guid("eebe8fdc-a22f-4cf4-9879-63798a05b695"), "265", "1615036680043332", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea"), "07/21" },
                    { new Guid("eeda0a28-ad69-4ada-b4db-765d1a026b9f"), "614", "4965499489833791", new Guid("3164a0af-914e-4e8a-9e4d-83d760107757"), "06/20" },
                    { new Guid("ef269d4e-4cb2-4f8f-a98c-73c1ea473258"), "398", "6072186925065589", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603"), "08/26" },
                    { new Guid("efc9bf50-4d71-4292-9358-474b857d0d38"), "844", "1804929019147991", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f"), "10/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("f055cf55-c998-4f49-a2c0-5002471b089a"), "987", "5195676333116035", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08"), "03/04" },
                    { new Guid("f0987ca9-22f1-4555-8c3b-5a8455173664"), "140", "4338630252583851", new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524"), "12/18" },
                    { new Guid("f09e63cf-228f-4072-a729-5c063f087305"), "027", "9310770604476886", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165"), "11/14" },
                    { new Guid("f0ce84d9-3389-40b4-adb1-ebf589cf2af9"), "606", "3944451297280262", new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a"), "08/12" },
                    { new Guid("f0d3540a-848d-47d2-8cc5-ea7e482ad763"), "849", "5720236553321055", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699"), "02/09" },
                    { new Guid("f0e40e5b-3555-48d7-8c3a-45a2e11b9783"), "797", "1385512568838845", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2"), "04/12" },
                    { new Guid("f20133d4-dc87-471d-a15b-4efbbcc683ee"), "507", "5235380541866073", new Guid("30eaf229-a750-446f-b353-8f619614a839"), "04/05" },
                    { new Guid("f253155f-bdac-46c3-b73c-c5a704886021"), "441", "8947453329145208", new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2"), "06/25" },
                    { new Guid("f320ef08-8512-432c-889a-50743dfb2f70"), "219", "1907353157294154", new Guid("1f55a324-d084-4122-815d-e1f65a8435b4"), "02/07" },
                    { new Guid("f389a586-eaa9-4a98-99c1-dc47d25051e3"), "787", "1017304892763744", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679"), "04/01" },
                    { new Guid("f39d5e7b-18f3-4d73-b0d3-f52116d4f84c"), "709", "8724346816555926", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf"), "03/07" },
                    { new Guid("f3b619a0-0786-4a1f-895d-045d7e40e00b"), "449", "2917188745374689", new Guid("0459684a-9478-4760-922c-cdff0f159395"), "04/05" },
                    { new Guid("f3b8051e-c514-4cc7-931f-2eb43a75acfe"), "116", "4867740008546033", new Guid("63f59de1-31f5-4826-bae2-9494ab073e70"), "05/03" },
                    { new Guid("f41b25d5-fed3-4ef1-94b6-90dcb7d9ba45"), "623", "4843291965674775", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699"), "12/05" },
                    { new Guid("f4be8623-8f8b-45ed-8ce4-842f3559b395"), "525", "1051000509860802", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9"), "02/11" },
                    { new Guid("f54da70c-f544-4540-8cf5-f362dc7ede32"), "953", "3236428748012775", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b"), "09/16" },
                    { new Guid("f5a2db98-5058-46a3-9e53-d7d93493dc69"), "406", "5408958484736583", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8"), "09/12" },
                    { new Guid("f67d4623-0409-4dd1-97cd-d1030b190033"), "699", "5298099224225650", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff"), "01/06" },
                    { new Guid("f6c438ad-f7fc-453d-b9a0-c23c60eb1bfa"), "136", "3448410440947925", new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765"), "11/11" },
                    { new Guid("f6f1650f-3937-4fe0-b24f-23ee663da25e"), "045", "4171335223761470", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70"), "09/05" },
                    { new Guid("f70b5164-bd56-4ebc-a694-e9c30111a00d"), "621", "9478947640669668", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea"), "01/22" },
                    { new Guid("f7166ca9-faff-424e-a6c6-35759ed3d778"), "960", "8488148088025731", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2"), "04/22" },
                    { new Guid("f7445328-0dc2-4459-a657-b6e18565ce1e"), "528", "6263884300012617", new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43"), "04/03" },
                    { new Guid("f81e9a78-482e-46a6-9789-789b8d8d7243"), "774", "8092727881083716", new Guid("38262136-b169-413b-ac46-ad2f34893b37"), "01/27" },
                    { new Guid("f83c7425-e4ed-4e75-8b91-09a4407bd529"), "822", "6888202620037640", new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa"), "11/17" },
                    { new Guid("f84359f1-0d6a-4292-83f3-dd1ca468fbe3"), "558", "6933933027618594", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f"), "08/19" },
                    { new Guid("f87d165c-bac7-4d20-b4c8-a713be42c4fd"), "037", "5732946612793611", new Guid("60de2347-d620-407d-9699-3b783da3d34d"), "08/17" },
                    { new Guid("f90583e0-ccae-4173-a14d-8b22b054b94a"), "570", "4327681493244874", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea"), "03/24" },
                    { new Guid("f9625a27-6028-4978-b6ad-a289fd2bd2da"), "572", "6999713616659762", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff"), "10/11" },
                    { new Guid("f9c79c60-69fb-46a4-bceb-df166c4d437a"), "961", "6302680718696139", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467"), "04/03" },
                    { new Guid("fb52b0c3-8d23-453a-bdf7-956c42f75c81"), "074", "5721479173948595", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6"), "04/19" },
                    { new Guid("fb8c0501-98fb-402c-8ce1-402ba6f9cce8"), "733", "1555206187239087", new Guid("ff032668-ac2d-465e-a8be-49991c69a967"), "12/28" },
                    { new Guid("fbe66ad0-b61b-483b-b3e6-a57b65c16598"), "767", "6692848286653339", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47"), "04/05" },
                    { new Guid("fc02541f-ab75-4e4f-a74b-5e11fd132015"), "990", "5690232377025905", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a"), "09/25" },
                    { new Guid("fc37e1aa-07a1-4918-b3f7-1b0a6943f91c"), "000", "4703628651152534", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da"), "12/20" },
                    { new Guid("fc7ca733-eb1e-43ca-8d9c-eabfe1fc9672"), "274", "5638540150706781", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4"), "11/15" },
                    { new Guid("fc8e3262-fddb-4a6d-be11-48979d34027e"), "110", "1096649144330999", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3"), "01/20" },
                    { new Guid("fd29c2d7-187e-4acf-8601-74285bc93ff8"), "664", "2613910508385914", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9"), "12/11" },
                    { new Guid("fd68b99d-266f-4c04-95f9-e9a7d5ecf9d7"), "336", "3142116697446796", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9"), "12/24" },
                    { new Guid("fd7e4fe7-cdda-43a0-a0ed-e04a7667cd55"), "838", "3137983404763435", new Guid("69445845-4c7f-4276-a288-559e4b4df167"), "08/03" },
                    { new Guid("fd9fed82-23ab-4499-b3d6-ee55edbccb8f"), "050", "5341645674189259", new Guid("a9259e4b-5b4f-4608-968c-07272216574a"), "07/12" },
                    { new Guid("fe195711-c365-4f95-809a-6bd887b265a1"), "727", "5061282001977555", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603"), "01/27" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("fe8c8f11-459a-4e3b-9ee0-ac17149fdca4"), "216", "1500318606655030", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092"), "04/18" },
                    { new Guid("feedf366-b21d-4451-ae78-afb1c764dd7c"), "623", "7720362724291427", new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206"), "12/03" },
                    { new Guid("ff5210c0-d07f-4b65-9c03-570207851a14"), "019", "7386358037278977", new Guid("2e036c59-b30c-4add-a80e-9813b03909a7"), "08/10" },
                    { new Guid("ff71f8cb-aed3-4135-a9f8-02c6c8e3702d"), "467", "8979602164615789", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead"), "05/02" },
                    { new Guid("ffe3bf14-1156-4ebe-b907-4a46f9866399"), "368", "8673178114274287", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d"), "08/10" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("000daf8e-4047-45f6-a918-3923aff4a544"), "+400 76 (671) 18-19", new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("0093dcd1-b727-4aee-a3e4-98752defd92c"), "+635 14 (641) 32-22", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("013fd142-ab28-42ca-998c-7a029e03e5e5"), "+48 40 (365) 91-67", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("014d5960-c5d7-48a5-8ea8-0b85c60232e0"), "+216 73 (984) 16-02", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("019b6571-1fca-40b0-b9ab-7ddf9c9c5072"), "+338 17 (442) 23-65", new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982") },
                    { new Guid("01cef463-6488-4b0e-a173-02e7cc91cb0c"), "+691 41 (779) 97-89", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("0236b09d-c243-419f-ba50-c4f1df46c68e"), "+452 19 (479) 22-17", new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a") },
                    { new Guid("024a70d2-695c-436a-bf11-1bab03e7de3f"), "+647 04 (143) 46-90", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("025bd94a-6877-4ec7-9bae-8f2e890e0197"), "+560 83 (376) 45-44", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("02ad6560-30f0-426e-bcd0-5c5af2bcff1e"), "+267 68 (343) 12-76", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("02ee256c-c391-46c3-a854-5eed6413c635"), "+922 23 (531) 77-41", new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01") },
                    { new Guid("03206480-8701-43d2-b172-89d5d4f3a35c"), "+995 64 (974) 30-73", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("0324caef-3684-475a-b755-9c648154d3d4"), "+916 99 (263) 85-88", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("032c2268-c0eb-45b5-80c6-e97ab04727a7"), "+471 61 (493) 51-35", new Guid("d6044624-c058-4b3c-9d01-47f91c93279b") },
                    { new Guid("0362e7a5-9815-4b53-8bfc-7391e80ebffd"), "+943 50 (691) 14-06", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("036dc600-2099-4e2d-8485-fdba2a0b342e"), "+523 60 (485) 54-27", new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0") },
                    { new Guid("03917aa2-1dc9-43e7-9ec6-b97117c091c1"), "+651 05 (531) 31-64", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("0405f4ca-dcd6-42b4-9472-752e4fc4f9fc"), "+168 86 (450) 43-53", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("042b43f2-e3f7-4394-bc49-3066712ffffa"), "+1 18 (020) 17-87", new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68") },
                    { new Guid("058f33db-320c-4144-ba05-541901cc4198"), "+564 51 (563) 24-44", new Guid("69445845-4c7f-4276-a288-559e4b4df167") },
                    { new Guid("063de2aa-068a-4049-9690-c16e50ad5895"), "+799 72 (517) 03-77", new Guid("63f59de1-31f5-4826-bae2-9494ab073e70") },
                    { new Guid("06610ab7-7607-44dd-a040-09a5118a7c67"), "+92 80 (677) 44-69", new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001") },
                    { new Guid("067aeaf2-6df9-4374-99a5-709437e0317b"), "+371 74 (351) 37-60", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("06922561-4b13-4768-830c-025cea6fa3a2"), "+199 97 (021) 09-80", new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93") },
                    { new Guid("0744064c-31a5-425a-898e-4dc340d1e189"), "+723 59 (720) 21-93", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("07532da5-41d1-4238-9e36-be00c9e6a18d"), "+818 29 (721) 04-86", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("07902627-c4a5-4b10-8e30-406e286d3cda"), "+974 16 (313) 76-26", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("08bb3ac7-8118-4570-b839-b29fa9795391"), "+243 89 (164) 88-59", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("08bc0b5e-8efb-4e6a-a7da-05eee4dd3c16"), "+383 05 (902) 08-09", new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf") },
                    { new Guid("09378859-03df-4ab0-9221-9e4c4951c6a3"), "+656 61 (133) 00-01", new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2") },
                    { new Guid("095efa3a-9411-436b-8800-61d792d8f021"), "+506 87 (562) 86-55", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("09a69171-3600-4b9f-b1cf-7cb5a309997a"), "+266 82 (848) 70-86", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("09c40c6c-5194-4d6e-927e-6188040e2093"), "+712 14 (261) 60-23", new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("0a45d27e-13c5-402d-9de0-e19c1ce2e8b2"), "+41 10 (604) 74-97", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("0ac56ceb-5e67-4346-ad24-50dec3c61b90"), "+122 62 (204) 86-08", new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204") },
                    { new Guid("0b156c17-af19-40ec-904d-38654ce77c64"), "+195 37 (984) 13-62", new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66") },
                    { new Guid("0c097731-d3fc-4ea0-9474-514d71f1b715"), "+624 59 (376) 39-29", new Guid("2e036c59-b30c-4add-a80e-9813b03909a7") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c249b88-51a3-4511-8d87-707a5b8b6a23"), "+263 05 (528) 20-99", new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa") },
                    { new Guid("0c27c2c4-1d75-4ec3-bb57-99809db87b6e"), "+768 80 (741) 55-05", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("0c334629-b64e-4501-b7bf-d1613992d2cb"), "+818 76 (129) 01-77", new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9") },
                    { new Guid("0d814192-01ec-466e-8c87-9f4271809a3b"), "+401 32 (019) 75-56", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("0d843386-2b14-4ff2-b35b-df8ccb08abea"), "+28 89 (238) 33-59", new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("0dc76920-d165-4d0d-b203-5dde6e27a895"), "+831 50 (486) 98-44", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("0e34d445-896f-488f-acb8-9d409321dc99"), "+821 74 (096) 65-60", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("0e3b62b6-c08a-47ea-8c5b-504f5e1e3316"), "+308 91 (322) 78-11", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("0ead8ea6-4825-4b38-a805-7a0e4ef46c1a"), "+193 80 (491) 19-54", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("0eb4b64a-cd0d-401b-9afe-21c6f5ae8e55"), "+911 76 (711) 76-06", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("0ef924df-84bf-4231-b30d-9d2e77866725"), "+67 06 (378) 50-64", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("0f6f9b19-3c55-4444-a2ed-2040bd6a0a95"), "+985 27 (581) 40-05", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("0fabdaef-e89a-41c8-8d6a-7c1c969684c1"), "+645 42 (560) 97-70", new Guid("6a8b98c2-b5fd-4493-b57a-a16eafcbf001") },
                    { new Guid("0ff3097f-36b3-475e-bff5-694be27bb4da"), "+73 99 (919) 85-63", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("1044a540-ab4b-42cb-bf3f-9f7ff95949fc"), "+563 43 (650) 17-85", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("107fa922-c5d3-45f9-bff4-29ce7bf10943"), "+715 26 (326) 68-15", new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("10d191b6-0193-42a3-917b-b197b66fb971"), "+82 43 (482) 40-70", new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("11cf5a88-46f3-43f8-b546-ca878cea6ef6"), "+943 01 (913) 92-13", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("11ddffb7-be0a-4469-99af-c3531f096a21"), "+380 86 (088) 52-02", new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("1321ad28-388c-4b89-8b5c-168494f3f660"), "+698 20 (582) 61-74", new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b") },
                    { new Guid("133014a8-b50d-47a1-9d67-f016b08182ba"), "+821 66 (706) 02-59", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("1341cf69-dc58-4fb3-a1e2-87f1bc2a1af1"), "+427 65 (438) 47-70", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("13571897-4e40-43a6-853d-a2ea2dea67c1"), "+277 95 (396) 18-64", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("13e807c5-f599-4cc3-8a29-352c9f5ddc8b"), "+54 02 (857) 26-52", new Guid("1f55a324-d084-4122-815d-e1f65a8435b4") },
                    { new Guid("142bea4a-c5ac-40c7-be2b-315240bec79e"), "+668 04 (597) 81-90", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("144750f6-8106-46b9-a8fd-c311db3293d3"), "+567 13 (828) 45-21", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("147aed05-90cd-4122-b72a-059ed13c2ab7"), "+285 55 (846) 02-72", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("1480ae8f-d0f2-4028-b046-b1c054ec909e"), "+33 62 (570) 00-80", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("15851939-f390-4ce2-844e-699064822d3c"), "+971 85 (232) 81-70", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("15ac5dec-5f40-4413-9dc8-c5d69db29b27"), "+829 88 (938) 51-12", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("15e0e1ee-67c8-49a1-a83a-c677dc4aa1ea"), "+820 52 (398) 05-51", new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc") },
                    { new Guid("15e736e4-3b95-4bdd-b17a-eaf6a76a8c8e"), "+886 44 (303) 97-67", new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6") },
                    { new Guid("16438920-9728-4234-be1c-c51114d48809"), "+257 14 (943) 36-36", new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2") },
                    { new Guid("1651db59-7289-441f-b8da-51e053ec2a56"), "+903 62 (876) 29-56", new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("166b9607-a695-4cd7-999a-8d6dd9e06f95"), "+111 32 (447) 97-58", new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91") },
                    { new Guid("16f76af4-434e-4c7e-910e-e8c666fd58b9"), "+592 61 (834) 26-15", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("17379e00-a9b2-4403-8ff4-8ef14c1ae164"), "+552 74 (586) 11-80", new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471") },
                    { new Guid("181039be-4582-435e-893c-76865e78d2b2"), "+785 30 (259) 06-54", new Guid("db25f40f-9692-48ca-96f6-63866a9c9299") },
                    { new Guid("186a2740-a294-4ab2-8980-5cf37142c255"), "+659 23 (342) 84-24", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("18802c1e-9f16-47b0-a10c-3496d009cff1"), "+89 06 (681) 51-43", new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10") },
                    { new Guid("18ded506-d594-4696-9820-ab28ec68d2ac"), "+41 50 (935) 81-30", new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("1900710b-3d77-4ba2-9503-60d9485d9bae"), "+917 97 (649) 84-87", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("1931d467-c490-49b0-a5ce-ea31979a2e88"), "+860 19 (269) 95-65", new Guid("36333093-6685-44ce-9e09-9007f88e766b") },
                    { new Guid("195bfbd4-fe9e-435b-9d09-6289091b90c3"), "+997 75 (276) 88-92", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("1a7216e4-b743-47fa-b330-44ff0beb1690"), "+360 97 (527) 82-08", new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("1b312e35-414e-4c0b-8eee-bc9b0e8aaed9"), "+294 20 (213) 51-72", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("1b5840d4-fde1-401c-ab84-83aa5863f1f6"), "+360 81 (239) 81-55", new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae") },
                    { new Guid("1c2fa4fe-fe04-4c04-bcaa-9ed419870e6f"), "+122 58 (593) 07-07", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("1c4d832a-60db-4b20-a994-d95bb002d868"), "+938 28 (384) 63-28", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("1c56bb59-366d-4e8f-b40f-ab8241ea1799"), "+563 27 (897) 81-40", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("1c9e1096-9b34-428e-9700-7e4adbd219ba"), "+810 21 (343) 89-66", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("1ce7e0b3-8fff-439d-99d4-934a9697ede8"), "+963 46 (394) 74-07", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("1dc6fa2b-6823-4bfd-9a5e-6f9fc4625e16"), "+251 44 (214) 02-16", new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193") },
                    { new Guid("1dff0376-262d-44db-977a-889fa23fdbdf"), "+806 47 (067) 43-46", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("1e4ba368-ffb1-43e5-be1a-2f27ebf401fc"), "+678 06 (736) 58-25", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("1e7e93e8-dbf4-4f58-9fe5-86cbec16721b"), "+557 60 (854) 84-24", new Guid("5d96609e-242a-4e81-841d-15924cb829f7") },
                    { new Guid("1ee621ed-bfec-4e58-b54d-aa5a506b4b31"), "+14 27 (770) 76-27", new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("1f0086f4-8adb-44ef-8d05-77298dcdce94"), "+522 13 (993) 31-32", new Guid("7613a4be-1868-4124-8145-c559fd0b8b95") },
                    { new Guid("20263c9a-2f03-4dab-9922-b0be08a485b0"), "+628 27 (670) 07-03", new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("203be17b-dd96-4665-af74-ae0629042df2"), "+129 19 (907) 55-51", new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("208eb18a-8d85-400e-be84-1c054551c554"), "+768 04 (924) 85-40", new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("20a6dee4-4ad1-4461-8f36-3ac50cede9ef"), "+834 56 (664) 78-55", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("20e16679-80cd-4b28-b742-29ec5dc29403"), "+996 67 (378) 55-29", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("21963c2b-1780-4ea7-b17a-293124c06164"), "+301 11 (978) 11-41", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("21d6cd92-3ee7-4cbe-93fa-46e862141609"), "+493 63 (553) 68-02", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("221f7cab-1746-44e4-b2ac-4634b27d648d"), "+124 29 (444) 27-23", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("22401ba7-abae-4018-a702-2315b363ab3e"), "+185 79 (529) 04-47", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("2295dc18-591a-432f-bbf5-194659a78ca2"), "+2 51 (031) 25-63", new Guid("dd96b1bd-a1d1-4c63-82f1-fa6270d31471") },
                    { new Guid("22edd77a-b8b3-4a69-9731-955742513534"), "+346 72 (211) 48-51", new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7") },
                    { new Guid("231817be-5560-493b-bd26-a96513ff1016"), "+239 48 (404) 39-61", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") },
                    { new Guid("241e243e-5c39-4ce0-81ab-e44e4836bf35"), "+24 97 (725) 42-19", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("24318325-2d7e-419c-899a-1340624e3a5c"), "+576 26 (332) 40-08", new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("249a2a36-3693-40ed-977d-05c7c5150326"), "+422 36 (603) 03-25", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("249d8cd4-b320-4416-8cd6-f2b1321568f4"), "+152 99 (318) 38-34", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("24c51004-e404-45e4-9405-a51217534dce"), "+227 25 (539) 81-73", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("252c53e4-e88c-4453-9a36-7cab37da6444"), "+99 44 (289) 26-00", new Guid("988291f5-f421-4687-aafa-58e64481070f") },
                    { new Guid("25514cdd-b7c5-489d-b091-48f088781467"), "+83 25 (091) 13-92", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("2594a6c5-367f-4238-ac44-610d56c64d00"), "+888 96 (113) 27-94", new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("25a04829-6f11-4301-b5cf-f16f86f88f01"), "+728 56 (742) 58-42", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("25c1f0f8-dc1f-4c3b-95b5-7a41e02f8f2e"), "+26 37 (310) 50-04", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("26520b8b-4f0b-427d-8b32-d1b5a445565f"), "+367 08 (964) 66-09", new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("26fd8d1a-b574-4370-8031-8a9c073fb8cf"), "+265 65 (575) 51-82", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("271d475c-e498-4276-9b3d-a764d3ab7124"), "+50 33 (391) 92-42", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("272a87e3-dbd0-4e3d-9ae0-1d147a65ef6d"), "+950 91 (554) 47-65", new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("273ff9d7-bf2a-4ece-96bc-08ca3211e22a"), "+695 79 (399) 63-23", new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("27b2029e-c962-4355-91e7-80dc0948a079"), "+941 21 (831) 77-18", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("280b465d-db35-47bb-beba-a0a97f86997a"), "+185 67 (606) 70-85", new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc") },
                    { new Guid("282a8670-bc45-43e9-8dec-3263e372eb46"), "+460 91 (168) 79-28", new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("283f89a4-8cbf-4a42-ba2d-f2aa9e19a911"), "+696 87 (593) 86-70", new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("28a8dc24-1910-4720-8790-70630e3bc523"), "+212 90 (863) 86-30", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("28ac0af0-158a-4685-bc38-017a9eb372a7"), "+772 40 (678) 74-12", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("291d09bb-f1aa-4104-9b41-fc36655ae15e"), "+346 41 (955) 46-21", new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e") },
                    { new Guid("293f4841-df8e-4a5f-8829-0e8578d64411"), "+756 64 (670) 05-80", new Guid("04fd6503-1b71-456d-9934-427ae29ccb1b") },
                    { new Guid("295975c7-3f81-4c3d-9577-01b7700f410f"), "+737 65 (301) 48-17", new Guid("2b73b7f1-451f-41db-b14e-91c27c148562") },
                    { new Guid("29c4a939-750c-48ed-bbb6-4ebd6966bbdf"), "+224 36 (385) 91-05", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("2a292224-6304-4864-bf2a-31c10eef32a2"), "+143 90 (420) 65-31", new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("2a3bc63e-4428-40f6-a04a-31b2a2fdb7ce"), "+113 68 (441) 11-88", new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df") },
                    { new Guid("2a4a78a7-bd7d-4d9f-961f-613afd1e5476"), "+698 03 (819) 23-92", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("2a60b881-86ca-49b4-b47c-f81e4d5aaee0"), "+911 92 (927) 28-44", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("2a7d9919-6e17-46fe-8147-7e89c39beffe"), "+303 74 (268) 43-01", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("2b6485ad-7ab8-4880-b2e0-8bf48da50e18"), "+25 54 (562) 42-14", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("2b78021a-293a-4174-865d-5af52056de59"), "+503 48 (667) 13-81", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("2bc4e0bd-c7cc-4b4d-aa9e-2a32dc6a79eb"), "+882 18 (725) 78-85", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("2bda9b04-d29a-4f4a-9054-1cae6ee2c7da"), "+726 26 (860) 49-19", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("2c1b650f-b1de-45c6-9eb0-2a6887dcd84a"), "+536 40 (669) 75-90", new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8") },
                    { new Guid("2c3d28c2-5a6f-4956-a008-615c04351684"), "+432 40 (859) 27-73", new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee") },
                    { new Guid("2c8e1fc1-f3ec-4f18-b8f8-e46d66d05973"), "+391 76 (650) 17-70", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("2cfc247a-1ffe-492f-97a1-df63045df8f1"), "+428 90 (602) 39-39", new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646") },
                    { new Guid("2d0c8fd8-1946-4369-9bb9-a4a95520dfdc"), "+285 48 (251) 12-39", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("2d4d6298-8d06-4074-a73d-65280cccdcfe"), "+357 70 (106) 55-78", new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524") },
                    { new Guid("2daef129-e7ba-4576-8fac-1bf4026488c7"), "+709 39 (574) 47-37", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("2e1ad383-cd47-4a92-b33f-e203d7db2203"), "+820 35 (654) 00-36", new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("2e3b85e4-52d3-4377-8b30-0f3b677a2577"), "+308 19 (138) 26-95", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("2e5f20e3-74b6-40ec-8263-147a5d9f207f"), "+316 55 (400) 05-78", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("2e79fa67-8a94-40d3-bcad-6ffb9e91e2f5"), "+683 84 (734) 49-46", new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("2e8b068a-f719-453d-8a84-71fb1412eca1"), "+317 93 (553) 16-37", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("2ed6ebb7-a8ed-463a-add1-b1a76dac5156"), "+642 51 (390) 85-76", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("2f74ef87-7061-4d09-898e-738657b96058"), "+845 88 (089) 00-00", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("2fc81a87-ae9d-4869-ad78-c8242ee31676"), "+257 58 (554) 30-14", new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e") },
                    { new Guid("2fd5c321-8b43-48b9-b480-863c131f0125"), "+665 41 (256) 00-06", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("302db1c3-197c-4910-963b-3658db5cfe07"), "+6 12 (556) 85-82", new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("304efefc-dfe1-47b8-a6f5-9c1504a7ca6b"), "+30 52 (195) 78-47", new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9") },
                    { new Guid("31377b13-8996-45b4-82b0-3e53ddcae748"), "+364 52 (682) 87-27", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("317b9893-34f9-4a14-b5cf-6db8b24f83e6"), "+132 03 (058) 57-75", new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12") },
                    { new Guid("317f3c6c-d580-40a7-a66a-a4013784ac5c"), "+974 18 (946) 42-97", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("31b065aa-d1e5-45fd-924b-8a4d7bcee234"), "+843 27 (764) 87-39", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("32ac5277-ba30-4584-92fb-1bac36ac90f7"), "+850 88 (785) 51-43", new Guid("a548d594-0e72-40b8-a222-3504b474972b") },
                    { new Guid("32cab4ae-0a44-4455-ba40-aaddb80c8f86"), "+414 53 (078) 65-91", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("32f32131-6969-47f8-8e60-03bcdfac26ec"), "+695 63 (536) 95-45", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("332c2f42-b378-48bc-aeb4-b6fa3bc9b7c5"), "+608 33 (815) 84-41", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("333e859b-b276-4af3-ba6f-808b1101ee1c"), "+836 23 (966) 47-78", new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("3341a8cf-7837-4861-b561-5f3eca23f40b"), "+671 90 (188) 22-32", new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888") },
                    { new Guid("344bfd19-3b29-4f64-ac55-939c5caba75b"), "+250 27 (443) 40-61", new Guid("3164a0af-914e-4e8a-9e4d-83d760107757") },
                    { new Guid("34a54a63-16fd-4818-858b-8a4e03a42377"), "+903 69 (078) 95-16", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("34a90062-475c-43ba-a2d9-23be28cae21c"), "+798 33 (623) 68-60", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("34ee3277-3070-408d-8f05-c3932f23aabf"), "+191 37 (600) 28-62", new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e") },
                    { new Guid("3545fa39-7ff5-4d44-9b81-aa2211f155aa"), "+482 47 (792) 37-64", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("35784761-1040-4348-b871-99467097b661"), "+753 64 (460) 68-84", new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2") },
                    { new Guid("35d83647-aa14-4540-ad3b-2c256bed7701"), "+283 34 (157) 51-67", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("35fcbf9c-586c-4ba3-8dd1-8d6961cdab69"), "+843 40 (561) 24-44", new Guid("14172cef-38d4-4f48-b7bc-ed6c74a46385") },
                    { new Guid("360805e9-702c-40e4-8aab-d88f1d57dba5"), "+2 70 (125) 81-37", new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765") },
                    { new Guid("363bf711-f36f-4e3e-909b-9268cf1a2a7e"), "+783 08 (424) 51-76", new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206") },
                    { new Guid("36976a1c-d127-4fc6-abca-82f8b639b21b"), "+943 81 (022) 18-08", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("369d0fbb-81bd-4a8f-824b-efc04ed60414"), "+222 82 (014) 98-84", new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("36e8b231-da79-4848-b4e0-6162c320a0a3"), "+682 67 (743) 92-39", new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232") },
                    { new Guid("37afbe11-273c-4a3f-98ec-d29d6373cd8d"), "+493 02 (784) 11-98", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("37f59cf8-f99c-4bc9-b527-45e6426abc76"), "+656 86 (975) 46-03", new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("381b53b7-ac0a-4858-9965-5d4a3fd65f9b"), "+491 46 (410) 71-27", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("396071cd-6dce-4125-bb1a-616e234aac08"), "+13 45 (064) 84-61", new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("3963fef8-db2a-4368-a845-ccec9aa92aac"), "+517 76 (864) 46-27", new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022") },
                    { new Guid("3981bd3d-ee09-431b-b64b-022ceacd9599"), "+269 91 (179) 88-99", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("3a1492c0-c83b-4d3a-afff-31cf2fac7193"), "+999 77 (373) 95-76", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("3a6a5e78-4823-4662-9069-86546b8369e3"), "+959 93 (664) 25-40", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("3abe3ce2-e08f-4030-91b2-2a60d7e99507"), "+852 67 (628) 59-85", new Guid("5f081f26-af78-4d3a-b693-1268567854c9") },
                    { new Guid("3ac14feb-7c46-44d4-814b-d58c68cc8241"), "+143 25 (642) 31-36", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("3ac76a91-2394-432a-ace2-ede33cea5711"), "+362 91 (929) 52-11", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("3b4eaac7-6056-405e-80ae-248ed497d0e8"), "+818 23 (585) 13-99", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("3c6604c8-fb04-4062-9c3a-87bd36f72ffa"), "+897 16 (000) 51-04", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("3d1da1ea-b849-4673-b583-cd6e779c2ed3"), "+781 33 (049) 04-98", new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("3d205324-f350-402e-bc68-b3fbed32a5ad"), "+116 16 (509) 51-57", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("3d51ecc1-1bb1-4447-bd41-28e95436218d"), "+530 63 (776) 58-10", new Guid("f8331316-2615-4a9c-aac6-3bc582886724") },
                    { new Guid("3d70ed64-4615-4743-873a-e917c7fa2b26"), "+631 49 (004) 61-01", new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("3db18c20-25cd-480e-b087-adb4565cbf63"), "+472 27 (899) 54-23", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("3df42c4d-aaa2-4f49-bc8b-c2985dd39b04"), "+529 14 (085) 97-94", new Guid("36333093-6685-44ce-9e09-9007f88e766b") },
                    { new Guid("3df7cab5-ac9f-41c7-8259-d0ed10531fdd"), "+755 59 (375) 67-92", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("3e20bcb8-da9b-4183-940a-07d6b5e61103"), "+74 52 (934) 94-62", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("3eb128fc-6764-4b24-af59-d59573d2db83"), "+754 66 (060) 81-30", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("3ef4d3dd-0e23-4c71-8675-0a6b68da4d5b"), "+280 44 (065) 34-34", new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f2754b7-b2f7-4d0b-bf93-23ccffe34da2"), "+418 16 (099) 99-58", new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e") },
                    { new Guid("3f6b39e0-5778-446a-84db-1e8d12db59da"), "+468 44 (229) 39-04", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("3f8ef6a5-f814-4c1d-81b9-3c1494acc868"), "+151 24 (848) 10-77", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("3ff229d9-b4e8-40fc-bab7-8f0ee1eb6cb4"), "+40 14 (654) 14-37", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("3ffd0274-8b93-4c6c-8a43-c4a13030e58b"), "+703 80 (536) 95-58", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("40726a5d-f464-4be5-9258-9bd61ca1b869"), "+528 22 (193) 71-91", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("407990b7-5246-42e4-b69f-cd78dd630b53"), "+526 54 (630) 66-25", new Guid("63f59de1-31f5-4826-bae2-9494ab073e70") },
                    { new Guid("40b97666-ce96-4904-8f2d-1f4f0ac94d2a"), "+187 42 (189) 13-23", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("40c4bfcd-53a7-46f2-8738-0d745ded5c03"), "+580 06 (613) 20-44", new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("410ef735-3369-403e-9f41-4e1954a25625"), "+838 93 (806) 93-87", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("4151c0f5-7f1c-4bdf-bec5-e5928e2f2341"), "+41 86 (641) 16-71", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("416c9d76-b847-4b61-804d-2389e687bbcb"), "+765 56 (252) 08-60", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("41f7abcb-60ce-4a00-9b90-9a2a6c7a9aaa"), "+629 32 (774) 55-61", new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8") },
                    { new Guid("428fc9d7-9c9f-4f28-8af5-be39eaf462bb"), "+132 85 (198) 74-72", new Guid("ff032668-ac2d-465e-a8be-49991c69a967") },
                    { new Guid("42b9f9c3-933d-481e-b980-ffea649e65c5"), "+426 14 (750) 81-47", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("42e3c628-d0de-4cd4-baec-726c86e35434"), "+561 04 (937) 99-92", new Guid("cd89073d-c202-4402-95fb-fe3a8d1a2764") },
                    { new Guid("43a60042-492a-4fe2-99be-a265e9d76f7e"), "+966 26 (546) 13-25", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("43b35500-51c2-464a-afa1-01f2f526993b"), "+116 14 (124) 93-71", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("43bd1ddc-b19c-4446-8b13-353b5af586eb"), "+739 81 (575) 89-40", new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33") },
                    { new Guid("43dba0a9-262b-455f-92ac-6be113f072e3"), "+915 90 (597) 76-92", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("4465bfcd-53a0-4e87-881f-9d88e9859d68"), "+670 20 (748) 28-08", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("448a3606-f1e9-40f2-bdaf-5301bcd93a01"), "+39 36 (824) 58-47", new Guid("e82470a8-aba2-4d94-9119-1b0987ca33df") },
                    { new Guid("448b2105-ce71-4738-9d3a-d2966d866bca"), "+659 19 (503) 49-12", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("44b0d7da-a88b-40b7-8033-47ecefb06e29"), "+758 30 (887) 22-96", new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0") },
                    { new Guid("45898211-e78c-4592-85a5-90167cf6eb6d"), "+835 71 (660) 08-93", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("45c397b8-d6dd-47b5-89e7-3692e4335a8d"), "+442 71 (886) 84-80", new Guid("b34e9d23-9b12-49b3-b069-734a50918afc") },
                    { new Guid("45cbd250-bb0c-4889-b3ef-b215ae2ead2b"), "+204 76 (957) 65-10", new Guid("dffca8ca-1610-4ff9-b1a1-45cc9894f888") },
                    { new Guid("463ec6bd-2bc1-4b6c-9ac1-ec3949cf0a5d"), "+337 75 (644) 36-73", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("464727e8-32d7-4de3-b027-e90445777ce9"), "+874 78 (889) 33-00", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("467551d3-7e38-457e-8816-0c145686e351"), "+486 78 (644) 20-24", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("4696190d-d3e3-446c-ad57-8282bc680a1a"), "+48 88 (086) 97-00", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("4718bd26-4d7c-4cc9-9513-8e1d2c1e2a5a"), "+292 94 (947) 56-14", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("473f5ee5-7748-4dac-9fec-b5f0d8203596"), "+66 49 (139) 53-38", new Guid("6bd6126d-6465-493b-abdc-935b7afbc646") },
                    { new Guid("47441965-0870-46f0-9238-036900f6a18e"), "+747 04 (812) 63-84", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("474f27c3-527d-4de3-8c52-4b863613eb2a"), "+841 72 (034) 38-07", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("4760a886-3a48-4ea5-b6b1-367a467663ef"), "+582 84 (694) 71-62", new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b") },
                    { new Guid("478fc393-b0fa-40d8-a57f-9d413e30bd24"), "+303 29 (867) 43-89", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("47cbbbb9-0a69-47bd-b428-3d12d67e4871"), "+809 81 (121) 71-82", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("48506a31-8a07-4a9e-9125-d2925ac2ccbd"), "+140 20 (791) 47-84", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("486d83c8-74d1-4d95-927c-74877dd54a10"), "+102 46 (840) 20-35", new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("4877dc69-6cde-47f9-ac6b-cf4e1cabbb8e"), "+791 21 (203) 61-47", new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("489ebb91-f2a4-4e38-a137-9c42b5e20ba7"), "+799 12 (037) 13-93", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("48bb0bc3-9cf8-40b8-acf7-6448823236c4"), "+602 86 (062) 85-57", new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("4947eedc-0544-4f79-a75b-cfbc33136395"), "+583 94 (182) 98-40", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("49521657-1f64-49d7-a74d-62aae4376d93"), "+802 97 (199) 46-57", new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430") },
                    { new Guid("498aad47-a972-43be-9bb9-3242978021b5"), "+870 09 (390) 57-12", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("4a042489-cbb9-4d19-8469-cec6d9acee65"), "+231 03 (395) 92-93", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("4a16f387-8ad3-41e5-b0ed-74012ff50e01"), "+111 83 (493) 38-32", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("4a5ef815-71b6-4893-ae8a-50d08d397b96"), "+676 88 (306) 72-17", new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("4a6f1dde-ef09-45d8-b137-bdffdf21fe31"), "+645 94 (503) 09-61", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("4adb73b8-8834-41f5-8cdd-6b73277d16ce"), "+875 50 (592) 81-69", new Guid("69445845-4c7f-4276-a288-559e4b4df167") },
                    { new Guid("4af19da5-2291-485a-a831-b1d812d043a7"), "+227 11 (293) 50-76", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("4b1a9086-b80f-403d-baf3-a6fd531181c9"), "+325 64 (424) 93-37", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("4baadf97-e1c5-497e-9853-8aacb5a2e140"), "+388 86 (095) 49-46", new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c") },
                    { new Guid("4cccd032-e081-4a46-995d-bd3f077c25be"), "+392 38 (691) 50-28", new Guid("feeae310-c37b-49b5-b035-e9098493766b") },
                    { new Guid("4cf51bf3-b425-429e-8223-0184e55d6b5c"), "+277 25 (173) 82-14", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("4d0d8b1f-289c-4bfa-98d1-4f0d16a6dc21"), "+984 98 (215) 99-88", new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5") },
                    { new Guid("4d24030b-2220-48f3-be1a-1a40570db8b7"), "+251 39 (427) 63-93", new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("4d4648f6-100f-4d74-87e1-e43d9394c387"), "+117 21 (348) 50-78", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("4d666159-0caf-4a5c-85e0-059ea23c851d"), "+612 41 (158) 95-32", new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d") },
                    { new Guid("4da871a1-e339-4e9c-9d3f-d3fb54ccd21c"), "+765 32 (492) 34-03", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("4e693a5c-da7d-4ba4-8ae2-c6b9097a95b7"), "+232 75 (430) 62-06", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("4e70af4c-3771-4f14-9010-f77a4b940f21"), "+474 51 (183) 77-24", new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7") },
                    { new Guid("4ec82425-3174-4b37-b9a9-7d824605d947"), "+649 72 (777) 54-02", new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97") },
                    { new Guid("4f976645-1971-4701-867c-68d207763acb"), "+809 50 (249) 04-15", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("4ff2ac16-c158-4eb9-b0e1-e66efb9c78d7"), "+45 94 (980) 89-68", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("5088bd55-fde6-405c-afd0-b5cdbe827433"), "+639 31 (713) 79-25", new Guid("c8bf9034-8d15-4f9f-a830-2e4d4011ee66") },
                    { new Guid("51076c87-1ac3-46a5-9251-026ded7e5cac"), "+315 35 (488) 17-29", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("5123f6ed-32fd-4087-a354-5e1d7d18e06c"), "+729 17 (590) 07-60", new Guid("1f55a324-d084-4122-815d-e1f65a8435b4") },
                    { new Guid("516aa9e4-685d-46b7-a87b-dc9ada242d5d"), "+288 56 (802) 95-78", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("53f15b36-2c24-4f5c-8ca1-f418dd66aa65"), "+859 01 (348) 19-08", new Guid("29ab604b-7a76-439b-8129-93142c9b6cee") },
                    { new Guid("5491e45b-f424-490e-b268-b4546d954f4c"), "+805 49 (548) 01-50", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("54934a06-427c-4c6d-8219-ba91cc27fe98"), "+789 63 (441) 27-29", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("54adc9e9-11dc-4d28-8fc0-e051ece5554f"), "+996 55 (984) 21-48", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("5618cc41-770d-47ed-aae7-02a54d4797f9"), "+655 79 (499) 78-48", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("562df5fd-36e8-4791-8be9-fedba7a50318"), "+316 59 (917) 21-61", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("578a5da0-2485-41c3-b67e-dccc8e6966b7"), "+715 02 (861) 38-55", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("578b527e-a78c-4a0f-a5cd-9c3b90a0d6a9"), "+767 97 (618) 50-85", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") },
                    { new Guid("57e80949-b020-4fab-999b-70ce80512c94"), "+858 18 (023) 23-66", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("58f61ec8-6af4-4c55-913d-ac6c450c615f"), "+340 62 (624) 42-19", new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54") },
                    { new Guid("58fde65d-36f4-484a-b7b7-ae9dfd2eca87"), "+706 35 (742) 69-53", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("5921cfc4-1672-4225-ab47-ba96431d0444"), "+463 07 (807) 22-74", new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299") },
                    { new Guid("5945ef37-e98d-4be1-bafd-a1d2601805c1"), "+344 95 (747) 37-45", new Guid("0e809aac-90e9-4073-992f-0a9348838efe") },
                    { new Guid("594d6cf0-f067-4315-83b9-e823916bf383"), "+831 83 (457) 23-21", new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("59722bb4-3ab9-4d5b-836d-6a27b0839582"), "+776 80 (029) 72-47", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("5a76c8d6-5b97-4d8e-b35a-bbc5b3733abf"), "+47 04 (653) 57-24", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("5af6cd23-8204-424c-9f4a-796394318c62"), "+315 60 (806) 78-18", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("5b2dd017-1aef-4c6f-957a-929f1b2a1f3f"), "+245 61 (192) 46-76", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("5b329d0b-0e40-465f-80bc-c65f6e4c93b1"), "+332 90 (674) 09-97", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("5b4fd8b4-b84d-4ee2-863b-df16d8e666be"), "+4 99 (542) 19-16", new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2") },
                    { new Guid("5b8516d3-5b0d-43b1-8ae4-eb414931ab96"), "+970 49 (906) 71-32", new Guid("b49c1503-a7aa-4326-aa93-270d59c003b2") },
                    { new Guid("5b970697-ef8e-43ed-9020-ffaa7c559dc9"), "+521 91 (176) 94-02", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("5be68c24-e893-43bc-bf0f-2d014778d029"), "+60 95 (868) 74-11", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("5c141bb6-86b4-4e6a-8655-1bfc7dd5612d"), "+115 39 (230) 35-40", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("5c881cb1-a799-4f6a-95a4-f15cee094d1d"), "+51 34 (070) 46-52", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("5cb45e7d-89d0-4dd8-a6bd-7b3780ed4df1"), "+178 04 (331) 10-51", new Guid("2e036c59-b30c-4add-a80e-9813b03909a7") },
                    { new Guid("5d1ed1c5-cbb2-4f72-940e-2d6a8a0cf02d"), "+534 05 (877) 05-08", new Guid("b61b0669-9383-4f00-947e-75db5b8c7915") },
                    { new Guid("5d70d501-7bf1-46dc-bea1-c71cf814e1c0"), "+921 34 (767) 92-54", new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d") },
                    { new Guid("5e486219-4965-4c47-b000-0a65c2eb9075"), "+562 41 (186) 82-22", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("5e60a57d-c601-45e7-a3f4-ed237d1a12c1"), "+579 51 (218) 68-76", new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732") },
                    { new Guid("5ec3c6b4-769b-49ae-8a35-82c8785d54c5"), "+289 47 (111) 88-82", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("5ff3eb2a-03da-44ed-9a33-b7ecf7fc2637"), "+291 62 (107) 25-13", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("61175cd7-8b15-485f-87e3-aef9d10d7e41"), "+875 09 (045) 28-13", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("61dfe552-e9af-4ee3-9fca-c324118a9630"), "+171 33 (809) 79-15", new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("6227755f-ac55-4a73-91ca-2ba35db73b95"), "+999 10 (327) 88-06", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("62817db7-db38-4f75-85af-d2ef2e5908f6"), "+848 07 (245) 44-08", new Guid("54a4ee92-c985-4063-86f2-3fa6bf4b6d33") },
                    { new Guid("62d1617e-88b1-43a6-9088-710458c3a299"), "+597 61 (565) 93-79", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("62e7a2ae-e15e-4d78-979b-4e978e253972"), "+696 02 (036) 25-90", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("64085ed4-3667-49d4-b6ae-b5f1f4bea797"), "+396 55 (772) 47-34", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("64321e2a-4ecb-4055-a07d-739f4a982725"), "+389 08 (256) 37-43", new Guid("31147f68-7359-46eb-af11-622a8764424a") },
                    { new Guid("64fcce82-8572-4fe0-b99e-a581daa1a97b"), "+710 02 (758) 28-10", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("6541b6e8-dea2-408b-806c-b8b0a988e9e3"), "+390 67 (162) 09-25", new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("655245d7-d361-4ab5-9f8d-8fb66cfae5f8"), "+806 56 (779) 50-08", new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("65879507-712e-4bf1-bbd1-8f4da397bda4"), "+368 62 (967) 35-04", new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb") },
                    { new Guid("65a9aca0-1267-49e7-b5fa-f991e5de6f0f"), "+548 95 (056) 33-91", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("65d58773-76ac-49c6-afc0-d2761f383701"), "+285 32 (228) 16-24", new Guid("6bd6126d-6465-493b-abdc-935b7afbc646") },
                    { new Guid("6624d5d5-be05-4d57-bbee-f07af990c65c"), "+313 21 (068) 39-29", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("6686c7bd-8938-4aef-8f58-57ac8fd0dd95"), "+126 48 (656) 87-11", new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff") },
                    { new Guid("66875c5d-ba72-4e0f-a7dc-53665c959330"), "+179 60 (542) 42-79", new Guid("2f22ca56-2ef8-4deb-89aa-8528e9dead5e") },
                    { new Guid("6746e3db-4756-4013-b09f-58d1f604ed25"), "+463 85 (857) 24-65", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("68430c07-109b-4b5d-a292-5d7449d0fa3e"), "+966 88 (424) 28-41", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("68acc80b-723f-499f-a4f5-9f185cffcfcf"), "+782 65 (283) 37-00", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("6915c63a-20b2-4647-911f-aab7a4ae82f3"), "+630 39 (129) 71-31", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("694ffa2c-06d3-4901-9673-eed8feb2b0d3"), "+971 86 (554) 50-50", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("696a716b-a195-45f2-948e-ee490137f411"), "+866 40 (048) 03-43", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("6a4bac34-391c-4ff5-aab0-d1f618804426"), "+412 24 (346) 60-39", new Guid("9b7c61a7-ca80-4608-ad49-4f55f1e73a5c") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("6a92f969-6d86-4344-b215-2ea232848eb5"), "+38 35 (936) 66-41", new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("6aa6371f-a035-4414-9f77-ba341ab937a8"), "+919 27 (265) 95-70", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("6ab8554f-7ef8-4a54-a591-1fc2d5c4a1af"), "+299 45 (853) 29-07", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("6add517a-895a-488d-95d6-a5055e8c35ae"), "+144 21 (072) 15-08", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("6ae3eb21-3a13-42b8-a9ca-5cb6f6820fb9"), "+190 43 (804) 04-07", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("6b1f4983-d218-4923-b4e4-418182df02a3"), "+418 05 (376) 92-95", new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e") },
                    { new Guid("6b8a96bf-5533-4f9a-869f-6b24332ef033"), "+306 03 (549) 04-05", new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("6bdabee4-529e-4bc0-b586-5071c7906882"), "+847 21 (247) 32-97", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("6be17b58-fbad-4f67-8975-beb084420c61"), "+461 64 (786) 30-01", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("6bef82ae-5cc5-42e1-8ca0-8b6515335673"), "+924 15 (939) 15-84", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("6c01f29c-65bd-44ff-9494-e3e4bb0568c2"), "+177 76 (508) 22-85", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("6c1f2e14-5f4c-4342-b8a9-2d48951f7956"), "+197 24 (375) 09-43", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("6c4402c0-562f-4f2f-adba-c21b1ac706dd"), "+697 10 (821) 21-09", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("6c9e0175-847a-414a-a72e-85bd2a1a393c"), "+744 39 (435) 57-57", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("6cc60d17-2aa2-4af0-902e-f6c8f178036d"), "+523 53 (178) 98-47", new Guid("b6f95b75-b7c4-48cc-bf6d-965197cf81b2") },
                    { new Guid("6d520261-7444-4f8d-9b02-13f82c1aa057"), "+612 63 (042) 74-28", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("6d62b3bf-68f9-41cd-843a-d845b9fbb416"), "+837 53 (567) 71-32", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("6d70a134-d96b-4f8e-a852-80bb2cbeeeb0"), "+738 54 (018) 94-89", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("6dc24896-5093-4615-86d5-6aababc5a198"), "+587 57 (661) 59-84", new Guid("95f0b167-c625-4bb1-842c-2c33e8f9781e") },
                    { new Guid("6dfb786a-e8db-4754-a24b-0a8fe960103c"), "+844 49 (597) 07-52", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("6e434e8c-f027-41ae-a1bd-f47650f60a22"), "+671 17 (475) 51-47", new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6") },
                    { new Guid("6e557efa-d8fa-48bf-8888-16d36583c707"), "+814 65 (161) 78-53", new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("6eeb78cc-4a2d-4bd0-bc50-0c06101fe441"), "+883 63 (939) 13-90", new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7") },
                    { new Guid("6eed95fb-be74-4a2b-a307-8ee488a54f2a"), "+555 63 (434) 27-10", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("6f1807e4-7158-4af9-8833-90576fe463a7"), "+35 72 (165) 19-62", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("6f20d6ad-1bde-4d34-8905-87768d4cd66f"), "+860 07 (949) 68-55", new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e") },
                    { new Guid("6feb6fac-3ef9-4c54-8629-311524a427ae"), "+437 83 (659) 52-32", new Guid("07c4ad69-1eec-4688-9b01-943b3d15bbd2") },
                    { new Guid("70096d70-e434-40cb-a1f4-090c20426923"), "+534 48 (553) 21-59", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("705c2391-d4da-4b62-b9ba-b965273abcdb"), "+781 55 (197) 61-92", new Guid("e78bfe86-03b9-49d6-a310-41e75123a834") },
                    { new Guid("706b9c69-e660-4a70-94c3-e38741ca1369"), "+622 10 (785) 73-20", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("70843e2d-064c-4979-9498-b517f79307fe"), "+879 67 (818) 86-81", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("7154c4bb-fb63-46ee-b797-2dbb2ff171a8"), "+75 25 (837) 02-21", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("718e1721-ad0d-422e-9bd1-6916b82c92e4"), "+409 76 (733) 33-56", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("723bb2d7-2ff4-476a-9215-e3dda6b87c61"), "+229 25 (719) 75-81", new Guid("a0f83a37-caa3-44c6-859b-c935e81451ea") },
                    { new Guid("724e3b0b-41c2-4015-a9b3-363193569fb7"), "+898 39 (038) 88-61", new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a") },
                    { new Guid("7259e97b-e3e4-4e5b-b28a-552e8f357c5f"), "+707 79 (351) 73-73", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("72cd6910-2211-46ba-ab0a-a4001b4c2bc9"), "+454 87 (367) 05-58", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("7340098d-adc7-46b2-b408-42329bcac3f3"), "+377 69 (761) 58-17", new Guid("29ab604b-7a76-439b-8129-93142c9b6cee") },
                    { new Guid("7385c4f4-894e-4fc0-8c5a-2d26fe64a697"), "+706 26 (658) 42-90", new Guid("48fec127-ff7b-4341-9417-71a573651f92") },
                    { new Guid("73bb39dc-7d78-450c-b092-f70e51330c64"), "+381 75 (021) 06-57", new Guid("2b73b7f1-451f-41db-b14e-91c27c148562") },
                    { new Guid("7491e785-a86b-4452-8f6a-144eb25a1400"), "+653 86 (859) 78-12", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("74aeab2f-4d3b-433b-82e7-d3904c85ffd2"), "+34 18 (494) 80-52", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("74fd0606-ebf1-4eca-84c5-ca1f0953acd0"), "+95 13 (079) 39-80", new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95") },
                    { new Guid("7516963f-06d7-43d4-9365-30bea51c4484"), "+41 19 (904) 80-54", new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("756a066b-fd43-4152-9c74-283bc640a9f3"), "+614 93 (626) 35-55", new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("760f38dd-de2b-49e4-bb98-b41fb9c4728b"), "+157 21 (938) 85-04", new Guid("4f18c06d-9e38-4392-a135-68af41671c23") },
                    { new Guid("761a5e62-0a14-4b7e-815f-4143af69d571"), "+998 78 (893) 07-10", new Guid("46ae70e3-0a12-4912-a01f-34884705ec1b") },
                    { new Guid("762e7480-286d-4bd5-b900-62a47d231508"), "+547 61 (452) 50-46", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("7778c097-7c7e-4f22-8d94-55b6406c7bbb"), "+18 08 (903) 85-49", new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19") },
                    { new Guid("77a34c91-2c27-43a3-9581-0f2b42722872"), "+255 55 (195) 98-75", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("77f673dc-e247-4e4c-8d73-56ce686aa798"), "+389 89 (493) 97-96", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("79465a63-eed5-4122-af94-6ea10405f6d8"), "+988 46 (258) 22-50", new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("79df87cf-c8ae-41be-83ad-2c9fe5ab8461"), "+103 79 (990) 94-49", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("7a54b76e-a937-48bd-b11e-d6d2161b46e3"), "+236 10 (549) 81-66", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("7b0e5444-1f91-4f92-b21c-8372e3276d09"), "+405 45 (720) 43-90", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("7c2168b1-7575-481c-b2e6-b73bc4c40ff7"), "+673 12 (526) 31-16", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("7c360543-f837-4b18-9a30-0ce6c99c2997"), "+807 32 (566) 30-22", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("7cf31f1c-8596-480f-80d6-fd2086d00ed4"), "+954 14 (932) 77-67", new Guid("c4f7b55e-65ed-4f0b-9cf3-34c15fd5d299") },
                    { new Guid("7cf492ab-ff44-4a6b-917b-c1655d7cfb57"), "+726 38 (127) 42-07", new Guid("630fa980-a36f-44e5-bd4e-54b4d5ef6826") },
                    { new Guid("7d345400-d747-4eab-aeeb-89a18a2140a8"), "+160 83 (385) 30-03", new Guid("bede9c98-d046-4749-b0f9-bcaed4bafc12") },
                    { new Guid("7d7beab1-b7d0-428f-aec7-6632d105b013"), "+658 88 (694) 70-50", new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("7dc828d3-284e-4cbd-b85e-28547b8781b5"), "+779 40 (505) 74-59", new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66") },
                    { new Guid("7de26699-62f8-4c4e-9d9c-e0be1bd10dc0"), "+324 46 (976) 03-22", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("7eb61fc5-02be-4bc3-82a0-4a5c6f3ba493"), "+914 36 (270) 20-91", new Guid("31995843-45fb-4fd4-bf87-4209bd790c02") },
                    { new Guid("7ecb389f-59d1-47af-bf27-0978d4abb1f7"), "+439 01 (516) 69-18", new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919") },
                    { new Guid("7f0639c8-e739-4fc1-a781-59c1fed3ff95"), "+95 25 (908) 74-40", new Guid("4f18c06d-9e38-4392-a135-68af41671c23") },
                    { new Guid("7f082413-ba07-498e-a137-050282e8d8a5"), "+276 50 (639) 38-18", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("8001a5f5-bee4-4095-a87e-ff74aca59afc"), "+646 59 (932) 56-85", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("8004490a-3a5c-4547-96fe-3b7d01a543ec"), "+37 54 (092) 73-02", new Guid("4d36138f-0f80-42b4-94d3-a6ccd2f5b42b") },
                    { new Guid("802f44f8-e2a3-40a1-8c72-60619d6f3074"), "+300 58 (868) 35-79", new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77") },
                    { new Guid("80f090ec-6e50-4ae8-8470-9419d9b579e6"), "+155 67 (378) 56-09", new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("81502456-333a-4ed1-bdc9-5e3589f5bf8f"), "+214 10 (364) 20-16", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("81948b49-a5d7-44bc-a1c4-d037a3ef148b"), "+419 48 (437) 61-30", new Guid("d7c6915b-32bf-4438-ae14-31c936f81a91") },
                    { new Guid("81f0e87e-38d6-4017-82f9-43f35c093cce"), "+180 02 (513) 46-43", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("81f17b01-e492-45cc-b2b3-c5b8ac6f4cd3"), "+228 96 (307) 94-54", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("822ad2b0-2786-42f9-81d3-d5e267ccf13a"), "+226 52 (724) 46-78", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("8230682f-74e2-49cc-8a19-ae3af3c7d97e"), "+798 63 (503) 51-66", new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3") },
                    { new Guid("82371ea4-ef53-4a5b-ab52-909f18ddb1b0"), "+396 42 (884) 59-44", new Guid("ca7a1923-a6fc-4e9d-ac1a-cd9cca979f4e") },
                    { new Guid("8242f61f-630d-4ad4-b85b-6b878bf9bac3"), "+147 12 (216) 10-07", new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("832c7fa1-061a-4536-a104-92fc2eb14152"), "+261 24 (970) 17-71", new Guid("c2e07462-b5cb-4124-ba4b-ec30a684e15a") },
                    { new Guid("83442269-0937-48c3-9641-2a4804947c53"), "+288 34 (329) 01-04", new Guid("d51b3fc7-e2bc-4b95-9017-746f1d895eb9") },
                    { new Guid("838ea98e-968f-4a83-8fe1-59ec60cb630e"), "+123 92 (854) 98-24", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("84925222-0ff4-4572-9769-7a0576c2b4cf"), "+492 15 (692) 85-56", new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("866339fd-aedc-4a41-ab9f-ee84c12892c1"), "+111 34 (525) 01-01", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("86dd0dd6-64cf-408d-a99e-e226005186cd"), "+425 06 (101) 61-27", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("86e112ed-4797-414d-980a-6e9e45427140"), "+467 99 (458) 90-36", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("875bbba9-db71-4771-a2ef-070f6012ac77"), "+474 29 (501) 90-81", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("87e9d6a1-c5dc-416d-b17a-6f10099df668"), "+512 02 (501) 15-54", new Guid("f8c640b8-86c4-4042-a5cd-f4e1b338eb2e") },
                    { new Guid("8835070c-646f-487a-b278-2d72f9362f82"), "+382 94 (851) 14-57", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("8845b28a-ed61-4214-9185-4cdcdaaa0be5"), "+527 82 (744) 35-92", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("88b24c28-3f78-401b-b5be-84d3f995ea6b"), "+257 37 (727) 08-62", new Guid("1e05bd72-7c43-4754-9b56-6e4649fedb77") },
                    { new Guid("89049c17-6876-481e-aac3-0b4977475876"), "+431 69 (652) 63-06", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("891b1309-f231-41be-9513-ff97ba4b4d33"), "+236 31 (826) 97-68", new Guid("51975aa5-5969-4a8a-b387-6cf896e366d2") },
                    { new Guid("892c7406-6364-456c-ab44-1a55660e513a"), "+893 73 (985) 85-10", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("8955793a-10b7-48a5-bd5a-f422d8dc6598"), "+628 91 (938) 89-62", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("89921ce7-56da-48a8-b68a-c8ca4f8c0f97"), "+356 79 (882) 90-32", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("89ba2466-2a6e-4267-98f0-c6930173af3b"), "+14 04 (090) 99-54", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("89d333e2-5255-4f49-a32e-f3093172ff17"), "+210 34 (660) 94-12", new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("89f5438c-47e9-41d4-b7b8-9123a5417aeb"), "+571 09 (706) 75-27", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("89fda60a-4add-4bd6-88a4-c54118a0f40b"), "+267 28 (691) 11-30", new Guid("ff032668-ac2d-465e-a8be-49991c69a967") },
                    { new Guid("8a3d158a-224a-475d-8fc0-3008bdddaf1e"), "+204 18 (676) 22-29", new Guid("058a6d9c-0ac9-42b6-9df9-97284214f7ee") },
                    { new Guid("8a4e9ca4-fe48-4163-bae4-a7909feae648"), "+491 09 (141) 84-15", new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3") },
                    { new Guid("8a586dee-90f2-4362-aa95-59f5686ea63e"), "+853 89 (016) 78-75", new Guid("4eccd787-74d0-467e-9de9-4f711c05852c") },
                    { new Guid("8aba33bd-06e4-4584-bbff-c11559c5f93e"), "+108 06 (226) 55-76", new Guid("31147f68-7359-46eb-af11-622a8764424a") },
                    { new Guid("8ad27477-175f-4980-90d2-e086d7bb18f5"), "+449 32 (331) 31-74", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("8afd4265-9cf8-48e5-b5d0-f6b3118152f6"), "+411 12 (544) 39-38", new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("8b10b313-c2d6-46e9-924a-27b75b1cf5f0"), "+500 53 (517) 26-46", new Guid("aa9f962d-9138-47ea-a506-253355f2eff9") },
                    { new Guid("8b77ab3b-e590-4e5a-b479-b425f8d5d83c"), "+636 28 (024) 96-95", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("8bb5f3a5-a7b3-47f8-b2a6-f0560383e8d1"), "+5 26 (628) 40-09", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("8c096cd0-ba7b-419b-87ab-a2d1b8626fb9"), "+533 58 (297) 73-99", new Guid("9c116fa9-ae6f-4346-9007-5d88cf1ce430") },
                    { new Guid("8c2c3edc-fdea-4f14-a507-4dd49579ab08"), "+731 73 (929) 60-76", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("8c9f20f9-8f30-4fd3-a059-37c5f9d4a23b"), "+449 54 (128) 55-50", new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e") },
                    { new Guid("8ca16fce-490d-4080-ab4c-af7e31229081"), "+669 79 (740) 16-79", new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc") },
                    { new Guid("8ca1b111-4453-4f80-9cbf-6672fc32308b"), "+698 44 (067) 67-73", new Guid("a5d43eab-1c21-4f2b-aacc-1cf361370446") },
                    { new Guid("8ceb326b-5e37-4868-ae55-6116714a1319"), "+123 10 (914) 47-19", new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6") },
                    { new Guid("8d1ae21f-10e5-42e6-834a-d5b9bf9d0018"), "+509 93 (167) 43-13", new Guid("c8091c58-6b7c-4d53-8cb4-a4bd34f346fa") },
                    { new Guid("8d5038a6-7ded-475b-a46f-28d4676b0442"), "+783 76 (420) 92-67", new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b") },
                    { new Guid("8d579067-6afa-4d9c-bd05-d24dc95d5e30"), "+544 30 (348) 29-92", new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce") },
                    { new Guid("8d81dc76-e89c-429a-956e-555b72515b95"), "+947 45 (008) 61-10", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("8dc95d7a-384d-4d7e-816f-96cfd5e5416a"), "+987 99 (542) 00-15", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("8e09d462-e44a-4233-9a17-05b1ada3ad14"), "+288 79 (447) 26-85", new Guid("c559b832-f4e6-4f67-9eca-337973071293") },
                    { new Guid("8e5ff76c-8c1b-44a2-85ee-e930d26215bd"), "+464 92 (099) 96-99", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("8f442922-c568-4e7a-b98d-4252aca35708"), "+895 16 (480) 70-18", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("8f61fc5f-a06e-4fcc-bdee-1d1dfa17c98d"), "+42 71 (412) 77-36", new Guid("f6425efe-44a9-4764-877a-c0d313b88196") },
                    { new Guid("8fd0348e-58f6-40e7-b8e1-fdebbc5fecaa"), "+234 03 (524) 59-11", new Guid("0b918335-ee73-4a8a-9e35-7df2050ac7ff") },
                    { new Guid("8ff2599a-aea3-484b-bcb9-f645a82af59c"), "+513 16 (785) 42-90", new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("9011071a-10ed-4ce4-84c4-a1660afa2883"), "+887 70 (832) 11-27", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("903193ad-e1f5-43a8-9389-501ce8cd2f27"), "+636 79 (588) 07-33", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("903a1cc0-5e2f-453d-ac82-d941e14947ec"), "+149 83 (028) 41-02", new Guid("b61b0669-9383-4f00-947e-75db5b8c7915") },
                    { new Guid("9049d2bc-3129-4bb4-a1e3-32c7d4235a40"), "+661 93 (442) 89-24", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("904d92c5-c824-4631-809f-37128ebcbaa2"), "+437 78 (986) 69-77", new Guid("37c9a72e-26c2-40cb-986c-d5636c1c520b") },
                    { new Guid("9066f3f4-c758-404f-95e7-ec6df5e2575c"), "+811 32 (735) 79-28", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("90c36ef6-e15d-426a-a0e3-017dbba9fbee"), "+108 95 (757) 20-87", new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b") },
                    { new Guid("9113980b-3e5e-44ab-a0be-c4b8e314f72b"), "+526 73 (032) 45-13", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("911aef09-be49-43b8-9cde-748ce1172597"), "+124 53 (919) 97-61", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("91677e3f-ec2e-4b3c-9b9a-c7d1538f2ca0"), "+896 65 (908) 70-35", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("916b802d-a6fc-4ebf-9177-05d5e53af422"), "+741 70 (562) 71-29", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("918e38b4-97d6-47e7-8def-0d2972cb48d5"), "+100 15 (797) 61-15", new Guid("7e51c592-b29d-4cfe-a9b1-7262bf4a2206") },
                    { new Guid("91dfba4b-bdf6-43d7-ab2b-e52bd41c96a0"), "+201 96 (571) 15-74", new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2") },
                    { new Guid("92195182-b3d3-4f43-9b10-b0c73c83506c"), "+945 64 (224) 72-03", new Guid("81f9778a-12b9-45d6-b0a7-d162d915552a") },
                    { new Guid("926281a1-1926-4d9c-b4d6-436b80d769a9"), "+900 03 (642) 58-79", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("92a34695-0f9f-40cf-b1ba-7881621ab731"), "+605 62 (160) 71-53", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("92b6234b-82eb-4f9e-809d-7d5559921d35"), "+491 54 (108) 46-82", new Guid("e2b13e4e-ebcc-4f7a-8235-010b4da5978d") },
                    { new Guid("93086763-5e77-43eb-8972-50c772066bd1"), "+264 92 (995) 05-50", new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295") },
                    { new Guid("936fffd0-42aa-4fc5-a41f-8e6bcd7140c3"), "+705 85 (418) 91-30", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("938bb587-490d-4833-ba22-d2a4711e2644"), "+530 97 (119) 42-90", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("938eb995-5850-4caf-9887-5e4db7830487"), "+88 83 (412) 72-35", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("93ab1cf6-9764-41eb-8687-fd2e5ddf09cb"), "+992 67 (292) 75-14", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("94ab4ef7-bad4-4b78-aaf0-37a11b11a67b"), "+594 95 (165) 88-40", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("94ac63bf-36ac-4a77-b061-d0571da07070"), "+879 67 (777) 98-23", new Guid("709bbc1e-f61a-4153-a1a4-6648be82b2d2") },
                    { new Guid("94f0564e-c8d5-4cbf-b975-ee02001f19f5"), "+366 73 (780) 84-28", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("94f62032-70ef-4fcb-8c6c-e23b5e8e1b5b"), "+496 62 (330) 37-07", new Guid("e2df93a3-9a71-4b27-93a5-714d8518a732") },
                    { new Guid("95394416-947e-435c-8bd1-b0fa0642572f"), "+157 38 (486) 78-60", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("95399a1c-2f52-4069-8bc6-82a464093cad"), "+655 97 (054) 08-65", new Guid("bb8866ff-dcdf-47de-a74a-60dc763b7fce") },
                    { new Guid("95651d7d-f9a3-47eb-b951-6ba70e7024fe"), "+916 99 (176) 86-99", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("9588be5a-c4f9-46b2-9ec7-ad68ccf7f230"), "+269 68 (043) 06-35", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("95ce49ed-ee5c-48eb-85c1-2d81c31f582b"), "+536 49 (543) 36-72", new Guid("f75db8ec-4eca-4e72-b694-32976ec85eaf") },
                    { new Guid("95f968e0-50b1-40a3-b4a1-099aff516cc3"), "+669 21 (317) 88-66", new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("968d2aec-c2fd-402c-a7c1-df46e37a3284"), "+204 49 (027) 34-05", new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") },
                    { new Guid("96a4a879-5af4-496f-bd98-68d9755ed8e8"), "+712 26 (481) 64-50", new Guid("0e809aac-90e9-4073-992f-0a9348838efe") },
                    { new Guid("96f3b7ba-6ed7-4b4b-9794-f36cf8a8feb9"), "+117 92 (653) 60-49", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("972304a3-ae45-479b-b628-ed6ec6c087ab"), "+391 88 (002) 29-21", new Guid("84d9bf71-d234-4b4e-ae4c-0289901fae95") },
                    { new Guid("9754fc08-4456-437a-b546-c086276f420c"), "+983 31 (262) 00-19", new Guid("8123e452-c630-459f-8068-cd86f68c9a1c") },
                    { new Guid("97697ee9-8778-469c-aca1-39034c0762e0"), "+121 90 (413) 05-43", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("97a9ba37-f619-4683-9a4f-15dd50ee5197"), "+808 87 (384) 31-63", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("97e052f9-e1b8-485a-9850-ccfd61f826b1"), "+867 37 (974) 40-34", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("9803e6ce-241f-4d5d-859b-8f2caa2a0aa8"), "+408 56 (273) 82-87", new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("981f607b-796c-49d7-a143-9a95859f05da"), "+544 81 (235) 33-81", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("982a6387-d677-4318-8b7e-7b9de2eaf0ec"), "+246 91 (254) 33-57", new Guid("5af6aaa0-89a8-4745-9963-ad74e95c7193") },
                    { new Guid("98b62bdd-ad8f-4ab5-b92a-1c44ba1d1bd1"), "+315 45 (281) 81-63", new Guid("302e1ca3-8c80-434d-9fb8-4e1aea0f8022") },
                    { new Guid("98f9e88c-ccdd-4a08-9381-17730aa219ab"), "+383 25 (804) 86-60", new Guid("2f7377a2-8d21-4d22-865d-0ca12b5e8a9e") },
                    { new Guid("9947a9b2-ee2f-4f08-8880-a5cd76413928"), "+364 16 (457) 62-52", new Guid("feeae310-c37b-49b5-b035-e9098493766b") },
                    { new Guid("996838a4-a672-4801-9329-561f5ad6463f"), "+858 47 (326) 12-78", new Guid("5f081f26-af78-4d3a-b693-1268567854c9") },
                    { new Guid("99c0cad1-b60e-42d3-9bdc-fbc754e56005"), "+705 98 (348) 29-83", new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7") },
                    { new Guid("99ee7c51-43c6-47f4-858c-1da8b969abc5"), "+80 00 (669) 45-19", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("9a074aed-5060-4393-b096-8497a23e5f28"), "+248 27 (941) 09-25", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("9abd6cc6-f588-4133-bed3-89907a2bdb56"), "+431 67 (171) 00-87", new Guid("0fc85717-b5c8-45bb-ae26-fdecc070b8cc") },
                    { new Guid("9accd795-5cf1-4772-bb1d-932db5e19f15"), "+531 79 (899) 86-84", new Guid("f33ed058-0d5e-4f28-8270-398f55394914") },
                    { new Guid("9b0c6046-d3a7-4cd6-957b-6b3994c37270"), "+980 66 (420) 89-57", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("9b98ecae-4348-4bec-9ec5-28c07803bd11"), "+729 37 (183) 38-56", new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("9b9d4831-2e49-4274-a056-bf250e72544b"), "+250 50 (127) 40-58", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("9b9ea67c-89bf-4901-a092-0505994abf2f"), "+857 52 (063) 37-58", new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("9bcc903f-ddb4-4408-87b3-f3580a23cc9e"), "+551 71 (390) 35-54", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("9c0e129a-496a-4c42-b194-6646bd6f2cf9"), "+821 34 (597) 49-10", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("9c31a641-e3a3-4f89-a990-924080957a5d"), "+66 71 (132) 87-96", new Guid("0b2e3014-34e8-4e41-970e-3a0955c306cf") },
                    { new Guid("9c4de792-5d81-4ef9-a848-1b5e0df899f2"), "+403 59 (175) 34-95", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("9c5781ee-8d6b-4eb3-9599-ddc30b23cb56"), "+561 82 (626) 86-44", new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("9c7673d5-6d5a-45a0-9310-ff8bd981ff0d"), "+315 39 (632) 42-26", new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("9c8ce59d-02e9-487d-88bf-44a0ce10abfb"), "+233 64 (850) 56-94", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("9e52a4ba-6c38-47c3-b574-b45f659b35b2"), "+217 81 (399) 62-80", new Guid("a53f5353-b991-4cad-908a-6761b66bec5f") },
                    { new Guid("9e54058c-f131-49f3-bb9a-40c03f1cd143"), "+334 18 (838) 15-07", new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("9e883fc2-2347-4b98-a0d8-0257e3f58804"), "+53 10 (830) 23-51", new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("9e9c07a7-05b5-4221-81ad-f911b03b2765"), "+111 42 (911) 81-81", new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("9ec1e0e4-5547-46f8-bf25-90e176c030fa"), "+59 59 (539) 73-25", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("9f3baf24-c58b-4934-8dc0-851e15ce0e96"), "+940 70 (026) 27-00", new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("9f46e8e3-868b-4d90-ace2-2316e0046f9f"), "+925 96 (800) 70-73", new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("9f68f643-3c5e-4d85-9091-d4893fc343c3"), "+370 14 (270) 76-62", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("9f751e16-9ebf-4811-a76f-ebf75f102759"), "+576 11 (626) 35-13", new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("a0896a70-0b44-449c-bcb5-9a7975fc4d1b"), "+126 11 (954) 87-88", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("a08a1af8-50c3-48ad-be02-54dc73ede22c"), "+154 93 (437) 60-64", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("a0ba145f-d940-469b-852c-c7a01efb4b0f"), "+175 10 (992) 52-14", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("a0ce82bb-2dfd-41fc-a70b-8aa769c30a8d"), "+223 16 (545) 00-06", new Guid("4ff6406c-0b62-4bff-9682-3d28ffe84204") },
                    { new Guid("a17c9d9c-5434-430f-b23b-ef1498049381"), "+915 71 (177) 32-02", new Guid("4a67c697-28bb-45af-bedf-56c801f41cce") },
                    { new Guid("a1813057-c558-4f4b-8d76-af0ded76a857"), "+306 58 (446) 04-77", new Guid("f3875380-39ad-4555-b7d9-7d7e0290b9d5") },
                    { new Guid("a1bb3e38-3a4e-4826-b6cd-00b82e909367"), "+109 06 (777) 93-29", new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714") },
                    { new Guid("a1cc5088-fa8a-4411-81dd-3b7d3651c7e7"), "+956 99 (187) 60-65", new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a") },
                    { new Guid("a221f681-10f3-485a-ada1-cef7f4103eb8"), "+727 63 (465) 08-07", new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("a2aea617-476c-4913-86f1-10f8fa786703"), "+61 57 (474) 94-07", new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f") },
                    { new Guid("a2e52a52-4e5a-4bf0-b073-d4e1e0dbf512"), "+833 46 (282) 39-48", new Guid("bcc6f75d-ac55-47ed-89bb-b638e63e0b97") },
                    { new Guid("a367f16e-685b-40aa-b72f-bc26dc289f64"), "+222 31 (271) 32-15", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("a3a508b3-c82d-4a0f-a5ed-e29198702201"), "+792 19 (338) 26-39", new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("a436b4c4-d915-4153-a68b-90387d1b81c5"), "+727 74 (972) 66-83", new Guid("aed604ac-a2a2-4442-8848-f3716d9851b3") },
                    { new Guid("a553e1d6-7dd2-469a-9ad0-6c2911bc8dbf"), "+834 84 (823) 37-27", new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("a5d9f6a7-87f2-437e-a5c8-c60586a55b15"), "+584 14 (064) 83-39", new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("a5dd495d-9836-4878-9976-feca4ea65027"), "+421 70 (347) 76-46", new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("a60ea9ec-2229-4df1-82ec-86d8da206822"), "+875 18 (663) 19-32", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("a663bcbf-9096-40e0-b4ef-1c02d94ccc63"), "+300 83 (728) 12-98", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("a6907aae-786c-48ff-96c6-df3476cad848"), "+91 31 (886) 84-00", new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("a73744a8-7f32-4666-a6d7-02f4ab61c797"), "+444 10 (334) 32-44", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("a78c2d0b-c7f8-4942-b9e3-f5b4afaef9a5"), "+74 42 (173) 60-23", new Guid("7c20b9e2-ac83-454a-80a7-1b58554f8982") },
                    { new Guid("a79a744e-980a-452e-8622-4f13355951a4"), "+427 74 (416) 77-80", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("a7dae741-467c-49ff-abd1-5f8496e800a3"), "+751 55 (900) 38-30", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("a81b7d05-45b8-4969-9d38-409fe9020ed9"), "+596 04 (760) 02-14", new Guid("43e018ff-7b2d-49e5-a387-a15ced8a7d0b") },
                    { new Guid("aa0d627b-1f92-44da-8172-a4df7338013d"), "+179 38 (403) 53-24", new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("aa2724ea-2712-4633-98d1-91d3661101a6"), "+354 65 (873) 92-48", new Guid("51f1905f-9fdc-4411-8ffe-20e58fcdb2a2") },
                    { new Guid("aa507819-3901-4524-b068-69531631985f"), "+983 84 (452) 38-96", new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("aa67da33-78c6-4d5a-ba63-845f8be83289"), "+921 50 (853) 80-86", new Guid("6e0b3ad4-e6d7-463a-b386-c8473dde3c10") },
                    { new Guid("aa6dc5cf-31d3-47f4-97a3-54c9dd324d6a"), "+176 80 (583) 43-52", new Guid("94a0dae3-2ea3-43bb-9748-c028c62d3c54") },
                    { new Guid("aabeb86d-de32-4a6e-9209-7fb2723a5ed9"), "+298 21 (823) 58-25", new Guid("b34e9d23-9b12-49b3-b069-734a50918afc") },
                    { new Guid("aac4f1d4-87fa-4b41-96a4-4d649044994c"), "+768 40 (537) 60-29", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("aad4794d-abef-4515-877c-7f254cf8484a"), "+624 03 (572) 26-53", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("aaf6d093-d374-4c46-bf7e-e4978653f6ed"), "+24 56 (122) 52-85", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("abc5ebd2-3b9e-461d-a70e-4069e91bbdc2"), "+692 97 (582) 23-37", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("ac003258-0676-4d5e-9a92-6d9c172604ba"), "+792 55 (837) 66-64", new Guid("a0df4522-90d5-4a49-bd71-ad37fc5398d7") },
                    { new Guid("ac81f145-9ca6-4e4f-b30a-60c224e68fb4"), "+77 77 (364) 46-23", new Guid("5f940c37-cbb4-4f0a-93b6-67d989e267dd") },
                    { new Guid("acaa17b6-2956-4a21-805d-830d929e1a3d"), "+583 97 (410) 67-77", new Guid("560d01ae-7b91-45df-a4d9-a5c493100e01") },
                    { new Guid("ae222bcc-fc97-45e5-b4e4-aa1735f83376"), "+674 60 (593) 20-04", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("ae75c93d-4c6a-4ab9-b0af-bb0ec40a5d52"), "+678 76 (938) 97-62", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("ae99ab8d-0e82-4fc0-9033-84bcfc9c3c77"), "+282 31 (357) 27-32", new Guid("f6a1da80-0200-42f8-9361-b1d010fe1a64") },
                    { new Guid("af0d62be-1140-4cc7-8f6e-79b966cbee66"), "+321 44 (028) 77-69", new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("af3d7815-95de-4068-8f9e-35a6d15c2397"), "+320 89 (970) 17-12", new Guid("8ab4fe62-c0c8-4f8d-83cb-5cbafc106c93") },
                    { new Guid("af7313a6-803a-4279-8628-a310e2afd0af"), "+633 01 (512) 89-83", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("afc3d230-54cb-4119-8028-72d358b9393b"), "+456 69 (487) 37-62", new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("b05b792f-1172-40e7-a065-d73720f66e91"), "+244 14 (243) 44-56", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("b13b5581-c5a9-49f5-9ec3-790c564f5178"), "+344 57 (998) 45-32", new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("b18225f9-ca4d-41f6-813f-8ba06edb70f4"), "+891 97 (476) 04-19", new Guid("def8845a-24de-49d2-a341-fdf28b9883be") },
                    { new Guid("b1baf142-8180-4bbd-abd0-9debd4cbc187"), "+198 05 (536) 71-23", new Guid("a9e48ebd-e510-4577-887f-e1c93f0ad0c6") },
                    { new Guid("b1cc92d2-0895-411e-b1a3-b35c9210024f"), "+819 13 (451) 05-20", new Guid("60de2347-d620-407d-9699-3b783da3d34d") },
                    { new Guid("b1fc8305-e62d-4768-a768-e848a0b8187e"), "+712 13 (997) 49-51", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("b209e0bf-6835-4105-8a05-92874602eff4"), "+37 08 (035) 93-41", new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb") },
                    { new Guid("b236e56d-0f49-46eb-bff4-fc426e72021e"), "+822 80 (884) 55-47", new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43") },
                    { new Guid("b25485d5-8ba1-42b7-b2b1-7646eb00b420"), "+968 88 (232) 76-59", new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("b2b85d09-e1af-4db3-9de6-e9df574750fb"), "+310 40 (555) 38-53", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("b377a5fa-c6f2-42d5-960d-5dbada9fe6c8"), "+479 66 (804) 28-50", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("b3b831a0-d1e4-483b-b547-c38ddb5d3837"), "+886 06 (174) 88-65", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("b40a3daa-5e67-4b7e-a369-8b8830c8278c"), "+36 66 (936) 21-46", new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08") },
                    { new Guid("b43d12b0-d2bc-4d81-a767-a3e5003289c3"), "+301 61 (084) 71-47", new Guid("bb8d53c5-09e6-4adf-8607-2de0161256e7") },
                    { new Guid("b47dc4e7-dfe5-4979-b961-4ecbc693450a"), "+447 53 (130) 73-50", new Guid("64a84f40-e460-4cdd-a17f-40daa95e33f5") },
                    { new Guid("b48fba79-f2a9-419d-a0ef-966e6e1776ef"), "+255 80 (772) 68-33", new Guid("75902a9e-e261-47f3-93d8-6dbf0472b8dc") },
                    { new Guid("b531a059-e29d-4a68-a81a-8e1429f6aecb"), "+494 18 (590) 80-78", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("b583c0fc-5f3c-4e6c-8a68-f27927426cc9"), "+355 48 (708) 40-78", new Guid("b0aaf76e-5403-42bf-b64c-4b99f9fefe08") },
                    { new Guid("b58b52bd-9cb7-4f5d-bd14-4c86d2e2f2e2"), "+42 65 (586) 50-44", new Guid("6018825a-ad7a-4e7d-95b8-804c52a579b6") },
                    { new Guid("b5a9a944-2892-40c8-8ea4-12fd2fe97ff3"), "+827 68 (751) 53-47", new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("b5ee9d80-eb19-4689-89fd-04d5f4c62494"), "+988 56 (274) 53-52", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("b601a95d-19f3-476d-b8f1-ce0549b05694"), "+639 54 (732) 50-56", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("b61aeaf0-03cb-44b3-9296-04059bbad3be"), "+306 75 (554) 65-63", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("b697ed89-ebf1-475c-b8e9-619e1be7b277"), "+553 68 (982) 32-89", new Guid("813b1ca6-e7e8-4c78-831c-99196c9f1765") },
                    { new Guid("b6c1681b-1e4d-4ba8-ba41-d29561e9c50d"), "+778 21 (102) 41-68", new Guid("7eaedc6b-9209-479e-87e2-96a2837d3a9c") },
                    { new Guid("b7612fe5-529a-44f4-8b9f-5709997be170"), "+394 56 (156) 48-63", new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4") },
                    { new Guid("b7e91382-d780-432c-9dc0-a59855baee5b"), "+874 60 (740) 02-39", new Guid("a9259e4b-5b4f-4608-968c-07272216574a") },
                    { new Guid("b866e9c8-2a79-4e3d-9184-e0c6cca464dc"), "+157 75 (863) 96-14", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("b9fc9cc5-35e3-4356-aebb-a227c67dc759"), "+759 72 (659) 86-08", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("ba6b92f1-be7d-4c29-9ae9-f61783676a35"), "+542 94 (844) 47-77", new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0") },
                    { new Guid("ba732d3e-63c7-49ee-9e3d-d1caef5ede27"), "+288 33 (696) 50-69", new Guid("0be23392-599f-43dc-97d5-6396327167ba") },
                    { new Guid("ba94a53b-554d-4d6c-adbe-8faf9122bf33"), "+970 39 (118) 20-12", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("bbc3f7e1-3aea-4fcc-a548-b32918808913"), "+461 51 (887) 47-65", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("bc192280-00b4-444f-be29-7b280a39dff0"), "+964 01 (989) 50-03", new Guid("fb2b938e-166d-4da9-a12f-f4f5272b110f") },
                    { new Guid("bc3c93eb-495f-4126-b0e3-36489a5a2d08"), "+514 62 (968) 37-40", new Guid("015414ef-9e41-4cd4-8e5b-865ae8e9fd3a") },
                    { new Guid("bc53bccb-6c8f-4b5f-8f1e-ff5176a9bb2a"), "+141 27 (342) 10-08", new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4") },
                    { new Guid("bc6002f5-48ed-47a7-b6c9-8711d0a7423c"), "+19 52 (924) 27-64", new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("bc9c29dd-80cf-4754-a738-9a4639412704"), "+288 92 (656) 02-35", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("bcfe1712-9046-4273-aa3b-b8c68c1e661f"), "+854 03 (506) 03-73", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("bd4bb367-9598-4cf1-b3fc-91f472074687"), "+94 64 (861) 18-54", new Guid("eeffb088-6d62-4e10-890f-0de5910efc7f") },
                    { new Guid("bd50768e-ea5a-46ca-9217-e0b709ad43e6"), "+50 40 (776) 41-92", new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("bd7105c8-962b-4893-ae60-ba3a90b209cb"), "+127 93 (651) 84-11", new Guid("f145c7d2-b7f2-4f3b-8fc9-f3c1e129ef89") },
                    { new Guid("bd83b8e2-4976-48dc-8ee7-500267c78d1a"), "+196 39 (541) 88-48", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("bd96d477-d263-4ecd-ba62-27106f6517fd"), "+783 86 (240) 79-89", new Guid("a9751b8d-c640-427f-a033-6ebb68a5ef66") },
                    { new Guid("bde8a607-2771-458b-85ef-3ece9b5fb042"), "+675 92 (337) 63-29", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("be19d04a-0d02-4c04-861b-cc6e1204c1f6"), "+398 29 (092) 00-83", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("be1c4d58-a825-46c3-af84-6f96d02a1ccd"), "+920 27 (073) 36-48", new Guid("a9166594-c572-4cf7-af63-8f8dc07d6e3e") },
                    { new Guid("be2ba0fa-0972-444e-906d-24b49f434c90"), "+506 96 (067) 21-44", new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("be4efcb7-8f81-49e8-9332-080203389276"), "+276 14 (046) 81-58", new Guid("5d96609e-242a-4e81-841d-15924cb829f7") },
                    { new Guid("be6da70a-4d2f-4f4a-b3b2-ed56c08a518c"), "+216 45 (349) 46-91", new Guid("fa141615-1ef8-4556-89f6-ce190e25e4c0") },
                    { new Guid("be88882c-4cc9-4a96-966a-d805725f0ad1"), "+715 35 (445) 21-96", new Guid("85109e79-f828-49ee-b4ee-27d276d39b8f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("bec4c683-e21c-4c7f-812e-51e2ab9e696d"), "+329 50 (383) 50-19", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("bed09b6f-ca69-49af-b69f-6267c227e7b5"), "+648 22 (667) 04-67", new Guid("3164a0af-914e-4e8a-9e4d-83d760107757") },
                    { new Guid("bfb39f84-eca3-49e8-9fbd-8778dfe767ae"), "+102 77 (978) 83-33", new Guid("09aa3983-95b7-431f-868c-a4e72d5210e7") },
                    { new Guid("c0059702-f2eb-4ef6-b26d-7f986e47275b"), "+84 63 (201) 89-73", new Guid("9b64a1e3-ae71-4d1d-b8bc-2f5cd7e623f4") },
                    { new Guid("c04d7d32-f330-452c-925b-09cde13d5091"), "+228 17 (115) 40-76", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("c0eba959-e82a-4a39-a0b2-67e4b8f30ba7"), "+343 21 (656) 43-22", new Guid("fee4af00-7e62-47fb-bfcb-b9b397afddf8") },
                    { new Guid("c1094841-d933-428d-bacb-5e78ce01dc96"), "+711 77 (746) 19-18", new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("c160260c-1c49-4ee3-9d28-84b502c0d96f"), "+861 66 (981) 32-37", new Guid("41654f75-1b53-494e-9d06-289e15fbc423") },
                    { new Guid("c1b4eeb5-f7ee-4342-a902-23164b592331"), "+845 02 (019) 01-67", new Guid("a548d594-0e72-40b8-a222-3504b474972b") },
                    { new Guid("c2069c9d-8493-412c-bf17-355b9dc5a43d"), "+925 46 (334) 10-45", new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("c35542fe-f4cf-479e-9ed7-742fbc18696f"), "+17 86 (579) 47-07", new Guid("ebe3ae1d-e262-4d3b-a569-983c1b83460b") },
                    { new Guid("c3f4eb23-9f64-4236-ac58-b5580ee6ffd4"), "+113 60 (088) 55-11", new Guid("c5d22c47-b0d8-4e08-8fd0-f324b9a0acc4") },
                    { new Guid("c40a9bec-d180-4c22-972d-2cc73a28e688"), "+173 96 (244) 98-16", new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("c42ef576-5d4f-4ba8-8f39-889cef73afb5"), "+567 41 (030) 39-07", new Guid("c559b832-f4e6-4f67-9eca-337973071293") },
                    { new Guid("c500fb57-6f14-4dd7-b336-dd1bfde07bad"), "+165 50 (116) 61-49", new Guid("9b507934-f639-4c8b-8986-b879cb7bb36c") },
                    { new Guid("c603668a-c3e4-4613-bde5-2422f1bf4b32"), "+199 19 (441) 50-23", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("c627cdb0-1927-4738-b150-b1846b7c8902"), "+166 97 (992) 37-14", new Guid("991f0e55-ea08-4d02-b803-e20071e7673c") },
                    { new Guid("c6bfa9e6-fb29-4dca-ba01-4db767dcbd26"), "+95 78 (931) 87-86", new Guid("b95c4dbe-99fc-47a1-8e3c-eb2af103e95e") },
                    { new Guid("c6f7a224-d0ff-4439-a9dd-cadfb09d779d"), "+556 17 (111) 02-78", new Guid("56ebd4eb-dcbb-4f7c-9c70-0d0cfda16eda") },
                    { new Guid("c7238727-2896-4d8f-b06c-23ae30c77f63"), "+684 60 (367) 23-11", new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8") },
                    { new Guid("c7535496-a93c-47cf-a359-f93a82d5fc50"), "+58 70 (890) 60-39", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("c7578761-86f6-41eb-bc99-6b8c3a80b903"), "+106 06 (422) 96-38", new Guid("2b65819a-0e9f-4271-b6b4-3b0a2a69fcb0") },
                    { new Guid("c7bd0192-95db-41a0-b855-86f26343a2c5"), "+347 78 (421) 02-75", new Guid("b3fd8a60-6595-4277-a5c7-49b5cd18e27c") },
                    { new Guid("c819faba-660f-4036-ae27-cec4082256f4"), "+112 22 (517) 01-44", new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("c83c67a5-9dbb-4385-9d06-119986e830dd"), "+798 40 (675) 80-61", new Guid("31995843-45fb-4fd4-bf87-4209bd790c02") },
                    { new Guid("c871a1d2-6725-47fa-9672-59cd53c55f64"), "+445 24 (098) 26-55", new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") },
                    { new Guid("c894d782-a2e7-49c4-bd04-30d99766417d"), "+131 38 (043) 62-13", new Guid("2296341e-fcd3-4ab3-8ebc-aa3817659179") },
                    { new Guid("c8b2c384-bd39-45c4-a97b-325c0daa847e"), "+897 34 (306) 31-08", new Guid("4293e321-9572-455e-a69c-20f2ef4f2ec8") },
                    { new Guid("c8e0dcf1-69aa-46ac-8644-9d706151c5e0"), "+971 38 (613) 46-34", new Guid("66029e6f-cf6a-461f-96df-9660817e2c5d") },
                    { new Guid("c8f32f8c-9d92-424f-addd-2fdaf68619b7"), "+658 46 (854) 48-10", new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413") },
                    { new Guid("c9096d18-fa5c-483c-a931-a39208358fea"), "+233 81 (689) 17-22", new Guid("a41c8658-f533-492b-b01e-8c6c9794f5e0") },
                    { new Guid("c90b1d6e-c954-4b9d-bcb4-e5c46d35a739"), "+507 68 (163) 51-45", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("c9374d77-1d44-40e2-8603-44125846513a"), "+78 89 (031) 84-60", new Guid("78d9d506-9dec-4a6a-a69b-a9befedc368b") },
                    { new Guid("c94db718-4409-48fb-811d-fbed0e42573e"), "+216 58 (613) 39-36", new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("c9545854-edb3-45fb-bbf0-fb6ba65bf7d8"), "+524 01 (005) 64-89", new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("c9d06e2c-3552-42a1-93e4-ed003b24f0c7"), "+771 00 (233) 20-50", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("ca082fda-646e-4c4a-a870-c3285bc5423a"), "+448 39 (719) 20-20", new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("ca1a60c5-e615-4107-9e41-5c40531edb07"), "+955 71 (329) 70-85", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("ca26da7f-af20-4f73-82ca-5ec2337cf665"), "+55 16 (636) 59-20", new Guid("7613a4be-1868-4124-8145-c559fd0b8b95") },
                    { new Guid("ca5f7462-1fa0-4164-9b36-2f4abd194b7e"), "+77 76 (924) 67-51", new Guid("4f02761d-a6d3-448c-8144-f17dd1d158da") },
                    { new Guid("cb6429a8-4fa5-4a1e-955d-7118704ff0d0"), "+300 92 (660) 20-35", new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10") },
                    { new Guid("cbc57252-91af-4860-8b09-dd1262ce3216"), "+617 65 (709) 08-78", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("cc00eee6-04da-49fe-b1eb-26ac738291ce"), "+866 34 (955) 27-86", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("cc1330a5-25b5-4401-bf30-f5d1d54eb010"), "+545 27 (840) 45-67", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("cc52b508-ebd1-499d-b0cc-089cbe63b871"), "+609 02 (335) 43-18", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("cc6f6ac6-48c5-4ff7-a6d5-3a11e029c602"), "+716 00 (860) 49-15", new Guid("e656c8c4-a4b5-4e45-b43f-280fb643dd46") },
                    { new Guid("cc8d8738-e2b3-4e09-aa8c-d9eefa14d311"), "+818 74 (377) 66-95", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("cd3e8d93-0f1d-4be3-af4b-95de7cee3dd8"), "+798 14 (108) 33-92", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("cd455b11-7168-40a8-9c3f-d015c043158e"), "+206 93 (312) 00-19", new Guid("914a9168-2743-43d3-9989-0d61085f953c") },
                    { new Guid("cd93f2a3-d828-455a-8178-b199483975cc"), "+297 75 (841) 34-39", new Guid("71534b3b-5fdf-4f9c-9769-bee4e6c7c1a8") },
                    { new Guid("cf4a949e-f2b2-4b55-a2bc-cc69fc58df89"), "+731 38 (489) 30-46", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("cf9e8e17-0e39-4d4c-97b7-cfcc07a9c02f"), "+543 91 (608) 53-41", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") },
                    { new Guid("cfb19eb0-3c73-4425-8380-cb87742e9a17"), "+164 38 (364) 32-57", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("cfd4723a-a5c3-4b12-a42c-4103324a4e42"), "+513 31 (521) 67-23", new Guid("83b61df5-01ea-49ce-b4b0-cad08f41ef5f") },
                    { new Guid("d026c81d-d389-40e9-9007-7b73bff570f6"), "+497 71 (768) 58-30", new Guid("58ba8d03-c481-4520-91fe-b97ba6d0f426") },
                    { new Guid("d0906998-78b4-4718-bda5-c280af069230"), "+515 99 (344) 54-19", new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("d09986f9-b4b6-42d3-b49b-0c2ff55ca57c"), "+814 65 (110) 78-68", new Guid("60de2347-d620-407d-9699-3b783da3d34d") },
                    { new Guid("d108299f-6386-4a30-a0a0-3d5bbce2b686"), "+713 44 (581) 81-92", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("d1653ca7-1df8-42e4-918b-51ba28b89541"), "+500 45 (990) 82-57", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("d1ab86c5-16b3-4969-a539-1a6a7bd86be6"), "+76 24 (995) 06-08", new Guid("11e6cdde-afe2-497b-a6d9-7735b2bf9d47") },
                    { new Guid("d20d9dda-b29e-4fb9-a2dc-5bed72e26ae0"), "+814 86 (964) 33-60", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("d2576cf1-3f51-4834-97b8-10fdcfa16c6f"), "+56 27 (291) 02-40", new Guid("6befe55c-36c4-441b-91bb-a3fdb04b9b12") },
                    { new Guid("d29eecf3-cf8b-484d-b332-5038d5f8dcf9"), "+639 55 (476) 07-18", new Guid("a88ac8d2-3962-4df6-94ae-f79b0bfdbb43") },
                    { new Guid("d2aed3b4-4837-49e3-81cd-65436d03535d"), "+909 30 (686) 94-09", new Guid("8a0a5cef-5fd8-4e2c-a984-f1ca2ee79edb") },
                    { new Guid("d3062e62-d00a-446a-9e1d-0c2b78e56a3e"), "+558 40 (938) 11-99", new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("d3502b96-5cc8-450c-901b-80329eb5ec66"), "+135 86 (511) 86-30", new Guid("001a6222-624c-4834-ba5c-8defe6bdae49") },
                    { new Guid("d36fb01c-15b8-4f56-8cdd-e8ac185daace"), "+79 23 (160) 21-99", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("d3d56dbf-f3e4-4780-9542-943f7c016c40"), "+618 70 (576) 34-12", new Guid("f33ed058-0d5e-4f28-8270-398f55394914") },
                    { new Guid("d3efc618-c5f0-4af3-804a-076a03d9ec65"), "+591 82 (745) 79-87", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("d42eba0c-a395-4a16-af32-cc3bce4c9669"), "+989 40 (459) 79-12", new Guid("dbd3fe46-a148-4bb0-8b86-6e16349b9c68") },
                    { new Guid("d43a8cd5-8f00-4ec2-9924-9cf5b3b1e78a"), "+737 65 (697) 15-52", new Guid("00f931ba-9042-4fff-bab5-15657060d8e9") },
                    { new Guid("d4832517-d112-424d-89df-e9d37211c7a5"), "+850 81 (680) 44-32", new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("d5385efe-058e-450d-aa5d-9530019edee8"), "+603 09 (628) 31-23", new Guid("5f619dcf-1cee-4212-be2c-1870c432fa1b") },
                    { new Guid("d581a77a-2488-4d1f-b04b-5d76c3147128"), "+565 45 (375) 60-92", new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("d6a1ddf6-f7fb-4ded-910e-a4d18969960d"), "+397 58 (099) 60-84", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("d6c1beaf-478d-4470-9cef-3f50e4a24f72"), "+310 44 (877) 83-56", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("d749af9f-6b2b-4b9a-8ffa-d8d83e37d46d"), "+453 76 (740) 25-34", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("d7cf143f-8d8d-41ba-9b2d-ed85a8f6ae47"), "+65 19 (040) 03-26", new Guid("2206c2a0-1e8b-45a9-aa82-58eddc2d5eb9") },
                    { new Guid("d7dd49c9-fe64-4d4b-9bd3-70a326184042"), "+587 05 (038) 23-40", new Guid("d238fd80-8eb7-4daa-af5a-05170eabc6b2") },
                    { new Guid("d80a22fb-70a1-454f-838f-46cc6505e646"), "+89 33 (980) 72-02", new Guid("48f78165-0368-457a-a33f-c7c330b9016e") },
                    { new Guid("d8331e73-eaf1-4075-a89c-6aff4628c358"), "+563 38 (369) 65-73", new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("d89356ea-5057-4a85-83a4-327616e0e2e7"), "+453 93 (784) 46-05", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("d981fb8c-ea69-4e9e-825c-88d63125a610"), "+73 85 (179) 86-34", new Guid("1fb397e8-45e5-4ede-bfe3-f72002301679") },
                    { new Guid("d9d00614-3d86-4a50-8340-91c12d994a78"), "+179 93 (283) 24-00", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("da0aa491-abe5-496b-bf99-5427718a6680"), "+562 58 (780) 87-69", new Guid("4936f8df-ca22-4b86-9711-3559e3062cc6") },
                    { new Guid("da851171-5f11-4e8d-900e-e223bb97f3e3"), "+987 59 (517) 58-60", new Guid("a00531ed-2af7-406d-afa9-a72ad24f750a") },
                    { new Guid("db6ef706-074e-4051-af69-0d6a22a404c6"), "+694 48 (973) 16-89", new Guid("b9464561-a8cf-4e9a-ac30-a71e52d9f413") },
                    { new Guid("dc1a3157-8b29-476f-bfa5-59db3f1341e6"), "+885 17 (102) 23-73", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("dc54e3f2-8982-41f2-a4e1-5b75a12f6add"), "+749 71 (641) 80-50", new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") },
                    { new Guid("dc6725d7-2b3a-4fec-bcac-8bdc48444569"), "+800 51 (222) 93-82", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("dcd20ad4-a043-4490-aae4-b9855245fdcc"), "+182 66 (640) 88-04", new Guid("20cba3e8-2c08-439f-bedf-55c3d5725858") },
                    { new Guid("dce61325-a180-4a36-82a8-c3a8da9bd623"), "+527 50 (627) 30-25", new Guid("88188425-2c1a-4040-bbf4-e0c4a4ee98c1") },
                    { new Guid("dd2de908-3224-4fbf-82c2-3f2abdac4858"), "+844 49 (420) 49-74", new Guid("09dc3d3d-47da-4ae8-b66c-3051fadab3e6") },
                    { new Guid("dd9d19b9-5b11-4b1c-8378-f1771d10e899"), "+311 11 (471) 01-80", new Guid("4fe8ba47-8e4d-4a53-8d7f-f487a3811141") },
                    { new Guid("ddb15bd0-13df-4c13-a991-c48515422263"), "+466 57 (338) 71-35", new Guid("1bf30f4e-bf95-4de7-812d-93ae4382f367") },
                    { new Guid("dea3e4f6-f80d-4f86-90d7-c292e2a04875"), "+2 68 (136) 81-80", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("dee1ffdf-708d-425f-b404-73551d57d5a2"), "+394 58 (951) 33-36", new Guid("e9440582-539b-4d67-9bd0-e57123ae1fe4") },
                    { new Guid("df12185c-9311-4d2e-8da2-274cb0f8f740"), "+35 72 (196) 36-33", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("e01251fc-45d4-44c8-abed-ec4f571c1395"), "+617 27 (357) 34-13", new Guid("c9e3607d-126d-4143-8320-2bed3c9e15a3") },
                    { new Guid("e03210b3-b60c-4d75-891d-d3b91d47347b"), "+32 90 (656) 96-97", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("e0ea6848-1577-42b4-9cda-958c36e565c4"), "+405 03 (348) 67-47", new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("e12e577f-fc06-45c5-bf7c-8f9feb01aea4"), "+809 00 (989) 98-98", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("e1388393-4a55-4fb2-a722-207114fda97a"), "+204 00 (203) 17-56", new Guid("f03a715d-f6ca-40c2-a246-832b0fe3de19") },
                    { new Guid("e178a836-1ee9-44e8-81f3-42153bae54b3"), "+371 71 (952) 03-36", new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") },
                    { new Guid("e1f4ae3d-9ab9-4971-a8b7-9310fe79562e"), "+806 76 (294) 84-56", new Guid("d4dc71ec-bc53-4dd5-8602-7a2dbcdaf7cc") },
                    { new Guid("e21af31d-a2df-43c1-8d62-a7e2aaa5560b"), "+928 72 (196) 11-11", new Guid("988291f5-f421-4687-aafa-58e64481070f") },
                    { new Guid("e260740c-9d9e-4e60-b358-2c98b7ebf5d5"), "+718 18 (160) 09-09", new Guid("1dc88160-ca53-4d0f-b560-8b5dbb656232") },
                    { new Guid("e2bd513c-9ebc-4e2e-bc4a-03e2f8f0a341"), "+170 65 (160) 27-03", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("e2ce231f-6e9d-44cc-8cf0-cf8d13ada647"), "+69 43 (520) 40-34", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("e2f0a203-8188-4ae8-a512-faaff4146193"), "+154 49 (737) 78-00", new Guid("46b5ac21-0ede-4cd3-9081-863f40d5b164") },
                    { new Guid("e33e1534-f9a4-4627-8690-11d675958245"), "+886 20 (792) 74-17", new Guid("f72d04f3-755f-4cb8-9c87-d05ec091fc1f") },
                    { new Guid("e3702dad-198f-4309-a3e0-1c3d3dbee3d6"), "+943 59 (820) 34-79", new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("e3cab8ba-b8f8-4e57-a9d5-f8cdf75337bb"), "+421 35 (045) 81-09", new Guid("5818c2c2-18b2-44b8-83a9-c41fa20e4ead") },
                    { new Guid("e3d7b8dc-ced0-4ea1-80f3-c38055a70083"), "+907 23 (441) 11-57", new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4") },
                    { new Guid("e3ec0583-d577-4b69-9fc7-f0cfbae66d37"), "+724 97 (081) 74-69", new Guid("f9e90e43-565b-4c74-9085-f2d4011b35bf") },
                    { new Guid("e3fca985-c7e5-40f5-aa8c-50d2f95ca332"), "+278 05 (812) 14-11", new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") },
                    { new Guid("e41a7780-6399-4297-808f-647ce1876204"), "+341 56 (847) 52-95", new Guid("9baa81ea-3d49-418e-9ee1-8ddaadc3885a") },
                    { new Guid("e4272271-0294-4409-95a2-b6a38581217e"), "+806 93 (494) 10-51", new Guid("77af70b4-04ff-4932-8615-6a0a7d30f714") },
                    { new Guid("e4376ef0-f574-4aaa-b97e-debe51e7d9db"), "+863 34 (135) 32-16", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") },
                    { new Guid("e4d51f18-8c7e-470b-ae6a-88608893f63d"), "+947 17 (814) 16-08", new Guid("a2f160e6-4a6e-413e-b37a-30708a65d2f7") },
                    { new Guid("e4d6e9b5-7129-405b-9036-6ebf85897163"), "+751 59 (623) 40-75", new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("e51ba315-8150-41b4-a9ee-cb67e0ae6b34"), "+223 18 (431) 32-24", new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("e573fe64-55f0-4ce6-b34c-ee2558cd4706"), "+465 68 (812) 18-05", new Guid("a5342aff-dac1-4a6c-88b4-3f51963beebb") },
                    { new Guid("e57ba739-8505-43a1-91a3-89dd7e5c20d3"), "+55 27 (038) 88-11", new Guid("9aa2bdb6-1c08-4ca5-a727-4835703da1e2") },
                    { new Guid("e590b2f8-c8cf-41e1-9087-941ab5e54be1"), "+94 95 (791) 28-87", new Guid("dc9fd8ca-dc37-44a5-9705-5e7489556a32") },
                    { new Guid("e59eba03-08ea-4b2a-9480-9c1a62e65e5b"), "+584 29 (000) 81-24", new Guid("52c0612c-8ed3-4245-a7e2-2ededc303e4f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("e66f559f-22f4-4fff-999c-ea4a2ed0ea18"), "+647 17 (677) 58-49", new Guid("0459684a-9478-4760-922c-cdff0f159395") },
                    { new Guid("e6bc9c1b-006b-4f67-a0d8-58a469579896"), "+668 11 (438) 49-12", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("e6de6bd4-a439-40be-aece-806d14fbbe9c"), "+923 94 (948) 96-09", new Guid("971421dc-8faf-49dd-9b88-ce6998be2699") },
                    { new Guid("e7185071-bc3b-4e0f-9130-cb843758896a"), "+963 62 (669) 89-01", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("e7228d7e-a0f4-4af1-8fff-7d0ab72096b6"), "+157 09 (256) 47-38", new Guid("aea2774c-ca79-4930-b74d-5113fa68bd85") },
                    { new Guid("e7819eab-f8d1-4d1e-bee0-1cf617cc7640"), "+550 47 (741) 91-49", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("e7c33f11-dc00-4c6c-b3fb-118aac1b1bb5"), "+71 83 (065) 27-29", new Guid("bbc9c516-a005-4b0e-8bb2-788c073fb646") },
                    { new Guid("e8c0d64a-31e0-46d9-8d3b-2fd745b3a3b0"), "+77 49 (562) 47-10", new Guid("7f9d43d6-a63e-470b-8ded-ae1bc7d84d01") },
                    { new Guid("e8cafb8e-bb1a-4190-a676-cd9a895f53ea"), "+976 94 (356) 93-40", new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("e93e486d-1b27-4243-a796-351b75bd8fd0"), "+627 62 (828) 52-53", new Guid("9aa55e46-5383-4099-adec-70a0f5d3351d") },
                    { new Guid("e9c91469-92d8-4106-95f6-a2d7c0f21547"), "+492 97 (361) 49-17", new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("ea03da5b-6377-45c8-85d4-feec80fea64d"), "+786 00 (982) 90-22", new Guid("0c1292b8-667d-47c3-a6a7-ffd620e177c9") },
                    { new Guid("ea3a14b1-e9e6-415b-b4ab-52600c0e9219"), "+185 01 (208) 80-52", new Guid("3d8f78da-8014-4230-96f6-e96c1d62da1e") },
                    { new Guid("ea6390bd-b8e1-4d67-9fef-8340a71dec98"), "+110 74 (145) 09-19", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("ea813073-adfb-4ffa-93d7-c45085772863"), "+822 18 (103) 82-00", new Guid("6188e8aa-cf50-45bf-a2ff-24b283dc36d6") },
                    { new Guid("eb3c3dbd-dc62-4259-b721-83822056cb9b"), "+570 33 (127) 06-41", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("eb6316f8-ceb8-4343-a032-409d6d219b50"), "+474 17 (786) 76-84", new Guid("f6425efe-44a9-4764-877a-c0d313b88196") },
                    { new Guid("eb779bbe-c610-4f34-a342-d129d87e259e"), "+753 36 (960) 48-94", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("ebfe1914-a3e3-4e6e-b92c-bbab13df90c2"), "+395 13 (619) 63-51", new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("ec0c7cad-c123-490c-9fd7-5373a1454f59"), "+14 65 (744) 67-51", new Guid("ab66a410-e9d3-450d-8b28-50d6a4d5381b") },
                    { new Guid("ec266477-b2fe-45df-97ad-8f5ab7701115"), "+214 34 (749) 01-87", new Guid("8d8b5e10-655e-4b28-ab75-aa6a0d90d512") },
                    { new Guid("ec47c2bc-a044-4c4e-8079-739f77a858fb"), "+856 46 (569) 40-56", new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57") },
                    { new Guid("ec597176-5938-4ff7-bfb0-1810b211e25a"), "+737 32 (293) 55-26", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("ecb73900-5543-44ef-a522-fb5657959b88"), "+560 63 (012) 66-04", new Guid("901efa57-bd70-4897-bceb-295ab4bcbbf8") },
                    { new Guid("ecd5288a-3507-4afe-bdba-e1496764353f"), "+710 38 (783) 39-38", new Guid("1ec72ac6-ba59-4ae7-a6ed-4b6347b5545a") },
                    { new Guid("ecf4589e-d129-4f74-bb72-e8438e5f7ebd"), "+892 78 (091) 24-03", new Guid("f8331316-2615-4a9c-aac6-3bc582886724") },
                    { new Guid("ed9b0350-962d-4b7e-b295-b68bf4982141"), "+436 10 (654) 74-47", new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("edaf3ab1-d08a-48e9-8d87-f76c8fcd731f"), "+853 85 (250) 43-58", new Guid("db25f40f-9692-48ca-96f6-63866a9c9299") },
                    { new Guid("eddf67ac-f456-4540-8e2c-ec2f3a0c2278"), "+451 73 (052) 14-66", new Guid("d6044624-c058-4b3c-9d01-47f91c93279b") },
                    { new Guid("ee5aaad0-0f70-4ab7-a98d-58330e66b8b2"), "+757 28 (849) 43-05", new Guid("ffd79b48-ad14-4bbf-a5ee-6de941e4a8a3") },
                    { new Guid("ee7d187e-59d5-4657-a8e1-2fab2166b1ed"), "+664 89 (403) 75-95", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("ee7f7f1f-7b78-4c8d-ae00-5dcacdf106b0"), "+529 56 (793) 61-57", new Guid("902d612d-71bc-4c11-b9c3-2ce5d035950a") },
                    { new Guid("eeb6c3f5-7208-424c-bc6e-d10649b119f2"), "+267 68 (685) 01-69", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("efc4c4f3-e666-4ee6-8611-38d2b8d0f964"), "+174 23 (904) 88-98", new Guid("7081901c-585b-4e2c-9fb8-efbae29b5e6e") },
                    { new Guid("f0044c2c-2cc7-4451-a1d3-183f9712b169"), "+340 45 (317) 82-54", new Guid("cc05fe80-bfd7-4a47-8dc9-f69e45e337b4") },
                    { new Guid("f00cd057-6020-43da-8937-ae3d7f266d4d"), "+936 20 (921) 60-92", new Guid("e41b8c09-3b46-477f-adf6-92c259a39ea9") },
                    { new Guid("f0e3727a-6c96-4d01-a059-334e23a557dd"), "+356 41 (245) 51-01", new Guid("ced525b3-3974-42b5-93e7-ab23169f89df") },
                    { new Guid("f103537a-74ad-4f27-a9be-561096576ffc"), "+843 49 (080) 05-72", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("f10848b1-33c2-4738-a2ff-f7e57e27ecaa"), "+382 73 (083) 10-63", new Guid("82f935ec-f185-4df7-8ea2-de06a919aba0") },
                    { new Guid("f10fbf96-c7c1-40f9-811a-98819343c849"), "+744 49 (207) 08-51", new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("f1103c10-bcdf-4397-a251-d53fbbafb7bd"), "+107 28 (952) 47-03", new Guid("c555ded4-4193-484d-8cab-ac21e0996fb8") },
                    { new Guid("f1775f8e-5881-4e71-abbb-bb7a848a6803"), "+708 00 (065) 33-25", new Guid("0e99d283-f152-43da-aa06-54eaa1c81ab6") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("f17f03ad-d971-46d4-bd64-01c9601d643e"), "+167 28 (184) 02-01", new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("f27a75b4-4e50-42cf-8547-8b832f733a17"), "+139 82 (715) 71-24", new Guid("6b20140a-7bbe-4240-80d4-47ffd501caa3") },
                    { new Guid("f27c91c1-8011-4936-9ef3-92c80f3d9ae8"), "+679 66 (500) 53-12", new Guid("6d184502-9ffd-4216-8e33-7bb9f411780e") },
                    { new Guid("f2c86b28-1583-4669-9c3e-cd571ff35431"), "+846 51 (585) 53-79", new Guid("4e0f38dc-3db7-4fda-9801-094677c6ae70") },
                    { new Guid("f3f51fd8-2c32-442e-a9a8-fb0adad80f28"), "+164 20 (043) 94-16", new Guid("576c41db-7388-43c8-8b70-27543c323237") },
                    { new Guid("f4287cb5-1307-4673-ab92-dec8c41b96d1"), "+908 11 (717) 03-13", new Guid("5ee45660-8daa-4ae3-aee6-3413fbc60ccc") },
                    { new Guid("f435389e-126a-4f6a-bd4f-b0417b949d3f"), "+604 68 (627) 33-63", new Guid("d81428a8-c640-4761-b657-cfa05c180948") },
                    { new Guid("f49f4a46-0b5e-4eae-bd52-ca0d5c49bc4c"), "+785 87 (699) 23-41", new Guid("ad5c3886-4050-43c4-b1c9-24334f81e9dd") },
                    { new Guid("f55a2f01-c77f-4131-a886-7ccd5f0fd153"), "+689 51 (114) 17-46", new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("f55e6a37-c150-494e-9a82-798b43ecd1d0"), "+146 95 (877) 34-64", new Guid("88453da9-d9ec-48e2-9168-66f0233a8d8c") },
                    { new Guid("f5c04d3e-9b51-4ef8-8842-1e29dd93b86d"), "+307 07 (700) 86-43", new Guid("48f78165-0368-457a-a33f-c7c330b9016e") },
                    { new Guid("f6457f08-02b1-4bc1-a16a-cc5b43f0528d"), "+385 21 (851) 17-49", new Guid("bb617c27-432e-4b63-ba7f-2437a6b419ae") },
                    { new Guid("f691c26a-571b-40b1-9f25-263529113f94"), "+382 58 (739) 07-97", new Guid("7ee32877-462c-4a33-86e7-bd32e4e0da08") },
                    { new Guid("f7d1ab2c-2fed-4085-b4c9-815b735316af"), "+400 39 (859) 34-89", new Guid("39758a37-8f8a-4cb5-b788-2817fcb73ff7") },
                    { new Guid("f7d9a503-c7ad-4191-99c8-65b691d35000"), "+430 66 (897) 60-11", new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("f7ff542b-8739-41d8-b078-f3364def5aba"), "+399 82 (314) 67-29", new Guid("48fec127-ff7b-4341-9417-71a573651f92") },
                    { new Guid("f817df4b-6a6c-4b9e-8697-38dbfe267c5e"), "+122 44 (356) 59-59", new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("f89edda9-e328-45ea-87f3-78b3e8152149"), "+951 45 (989) 00-01", new Guid("f96e24f3-04ab-45f9-985e-7d5a8f4dff3b") },
                    { new Guid("f9081cac-b11f-4747-847f-54a9c0d02819"), "+354 07 (478) 70-42", new Guid("bc43407b-92cd-4e52-8b7b-74e7192b6d57") },
                    { new Guid("f95c4977-a309-4a88-a8bb-a54f00abae67"), "+829 05 (614) 54-64", new Guid("61677545-614e-49f5-a121-bebdd3c34a62") },
                    { new Guid("fa184c9b-f94a-4047-be6f-791325e0a098"), "+127 98 (670) 62-66", new Guid("808ded37-2be0-4bfd-bfe3-f003fee55fd0") },
                    { new Guid("fa38615b-aaa4-4377-aa6b-f7016086c21d"), "+982 87 (056) 85-34", new Guid("d3b46340-a6f1-4614-9c77-9f96d412ecc7") },
                    { new Guid("fa490b36-6a46-4fd2-8268-da052362ccc2"), "+863 64 (869) 03-86", new Guid("2183f862-871a-449c-b3da-ea6005e9e472") },
                    { new Guid("fa77b131-ead0-4ee4-b75c-72f4d65bb0b0"), "+773 44 (750) 49-58", new Guid("9cc49daa-f8cf-4997-9bc5-ce7c6167f295") },
                    { new Guid("fab3e4f9-e419-483f-9377-750cec2933fa"), "+678 13 (446) 04-73", new Guid("1d83e957-34ae-47e8-af11-95efcf0a2fe7") },
                    { new Guid("fb6f78e6-6a46-42b8-88a2-708372a3cbf9"), "+113 80 (814) 96-21", new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("fb8466fc-5f78-4247-8491-4d0e19a67dc7"), "+743 02 (918) 74-62", new Guid("c18b8b6e-fdf6-406c-ba40-4ce9bc3cb63c") },
                    { new Guid("fb92bba4-c1cd-47eb-aa6b-68be0da44e14"), "+787 35 (889) 31-64", new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("fbe1fa30-3df4-49b4-a17b-2f185d35374c"), "+78 17 (512) 84-31", new Guid("86132647-79dc-4073-869d-dd0cc40068f9") },
                    { new Guid("fca61c60-f28a-42f0-befe-e3fe2f6624a9"), "+477 61 (920) 35-41", new Guid("5e8ac5de-ea3f-45f1-8db3-f9197c5bd6ea") },
                    { new Guid("fcb9b2a5-84fd-4dbc-936e-ad487dc35686"), "+781 02 (278) 87-01", new Guid("65237b4c-eba0-4cd3-898d-20cd57c57182") },
                    { new Guid("fcba2a0e-87e6-4ddd-bc9a-88d57998965b"), "+177 63 (167) 20-34", new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("fd6f1c28-afb3-453b-837a-5f1cb1badf43"), "+395 37 (442) 06-07", new Guid("f7b8e534-59eb-486a-8c4e-c278bec4f42b") },
                    { new Guid("fdbfd338-66b2-4117-a608-290fd3f3fe16"), "+352 57 (298) 93-14", new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("fdf7dddc-9d8d-4c13-b0ea-a6499d3830ef"), "+446 24 (272) 60-30", new Guid("23abb9b6-cec5-4c7f-80c8-6a435f0c8524") },
                    { new Guid("fe22fa20-64fc-4883-9ce0-d27afff585d8"), "+539 03 (630) 99-69", new Guid("4636f1b5-e3b8-4800-b43d-c18ead92a24c") },
                    { new Guid("fed1acd1-ba95-47bc-b68b-670572db314a"), "+89 73 (889) 70-95", new Guid("bddb9664-3f88-4c1b-887a-2475d56b02f6") },
                    { new Guid("fee148a3-ef6c-44fa-8808-bf9fff8c226b"), "+163 18 (086) 87-68", new Guid("b6d60e56-d97c-4b75-a00f-b0450c943a10") },
                    { new Guid("ff0c307b-ba5b-4913-abca-57346496b945"), "+131 49 (950) 97-58", new Guid("a40bcce8-2eac-4a66-b2ac-58c2d5c9c15c") },
                    { new Guid("ff45ed60-cd68-4343-b37e-c3f25368ca7d"), "+647 49 (263) 94-92", new Guid("dfeeb125-4e3a-4485-b5c2-ce7a0d281797") },
                    { new Guid("ff54e897-7f4f-427b-b676-2fb32de2c78d"), "+518 44 (820) 23-13", new Guid("bde91f10-313f-4da1-9a75-bfac22aa78bd") },
                    { new Guid("ff69b381-d2c0-44f4-af68-fffa73222d7a"), "+754 49 (132) 99-75", new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("ffad5063-95a5-4be5-b82f-552cf13096ef"), "+931 85 (993) 62-23", new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("ffb6e94f-ffbd-46b6-80c6-3bd9dfdbee36"), "+991 49 (785) 36-15", new Guid("11603ff4-41d4-4039-81cb-9142762a3ea3") },
                    { new Guid("ffc14718-2595-4ac1-ab93-e36498b651e6"), "+343 71 (398) 26-74", new Guid("8ca3a7d9-2df5-4a32-b4fa-3b9c870a82d9") },
                    { new Guid("ffcf9844-802f-47a9-8011-2829829785b8"), "+644 49 (118) 45-62", new Guid("e0c046fb-3a22-4053-b4bc-77f84a782bac") },
                    { new Guid("ffe97c78-8f30-40b9-8e89-f97dd642722e"), "+417 47 (159) 72-61", new Guid("be75e92e-4d17-422c-a9d9-dba9cd4d6919") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0081687f-44b5-4eb2-9b6a-e79bee117436"), new Guid("c6cf41f3-0858-4fbc-8c7f-425ca062c180"), new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("02bc639a-406f-4b52-acde-da66b729503d"), new Guid("4ecbd7a6-5263-4190-aee3-654383d9e6cd"), new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("0336fb17-759b-4366-908c-d8a8181580b0"), new Guid("439cd9b6-f720-4de5-8267-5fe63d355d18"), new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("0eb83b4f-1096-48df-ba90-0e3d492cdb6f"), new Guid("a4fdc62c-3b6b-4ea1-b171-7f529a27fad3"), new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("0f24dff2-9f13-419c-9e00-7b73c33f605f"), new Guid("3d86041d-b6ef-4af9-ab3c-b75a7b1ecdbf"), new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("1a2ac84e-e80f-4ebd-92bf-13e6468b025f"), new Guid("f62fe85b-062b-4e1d-9bac-0260aeb49214"), new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("1aa36d61-c5b0-45fc-80c6-12b84b4d219a"), new Guid("7395dd2f-645f-48a5-b4b8-b1cd86183d23"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("1bab0399-685a-4f03-b1a9-e28902b04450"), new Guid("fb6c3671-f9ed-4c30-b84a-f7606888f0da"), new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("26540ea5-3669-4f06-a6c5-c8b3aa1115cd"), new Guid("4adfd7ac-1e3d-4c3d-8e20-8a6d9448b85d"), new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") },
                    { new Guid("4559c6f9-f250-4264-8209-83b051deda47"), new Guid("ddd2731f-f444-4ccc-b060-2bb70cc6ff18"), new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("46c85ac7-f5c6-44f1-af56-769846d786c8"), new Guid("111f7b0b-953c-4d5d-9b0d-a3b017566362"), new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("49bd8782-ec05-4da8-ad30-8ec9fbd67230"), new Guid("fcea49d9-b4d4-4640-b63d-de231e546e6d"), new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("4de04c0b-0c12-4e2f-a876-274938841132"), new Guid("a64e2725-ce35-45c9-92ed-92e8ac77d2f2"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("4ebbd5b8-4b92-4cfd-b11c-2c642ba0e001"), new Guid("c6cf41f3-0858-4fbc-8c7f-425ca062c180"), new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("516ec2ef-5148-4dcf-af78-ff9591436ce9"), new Guid("fb7aab77-ab85-4040-84a3-4ae3d22fe838"), new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("56b20326-fabb-4af4-8c15-e2f01d3d07f1"), new Guid("a64e2725-ce35-45c9-92ed-92e8ac77d2f2"), new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("5736ac31-9689-4990-9ec7-d4bed089df95"), new Guid("72c5195c-7945-4195-9254-6cbb7f80f5ef"), new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("57a676fd-c83d-4982-ad73-d707225e1f61"), new Guid("03f83e97-a6db-4172-9a52-4e53c29476f3"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("627e1bc2-048d-4596-aeb5-a24cc1b937d8"), new Guid("fb6c3671-f9ed-4c30-b84a-f7606888f0da"), new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("66896e7f-ad09-4660-b63b-de2f591f3078"), new Guid("3d86041d-b6ef-4af9-ab3c-b75a7b1ecdbf"), new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("66b6d545-6244-46e4-8d13-5b29b4523231"), new Guid("aac731f5-6c04-4fe0-9cfb-51dae019bb15"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("691369dd-f4d7-45b3-b685-f6eb0c3b7cfe"), new Guid("b6ac4cc8-1dda-4a49-9fe8-d4a4f4329986"), new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("70c55813-ac1c-414a-908c-519a62df70fa"), new Guid("6c8ea1fd-3689-470f-985a-a2e9894f30c5"), new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("7b813f79-a4d4-4efe-9a62-34eb079eb4f3"), new Guid("3c97cdea-27b6-450b-b4b5-25280d610c4c"), new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("7c038c48-862a-4c60-aa62-990ab100dd11"), new Guid("b253ca3e-55f1-48a2-b356-a6b80f64188a"), new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("7c6c973b-53c5-412b-b674-fe9a261e5f1c"), new Guid("a4470e7c-e816-4bf9-b771-1dfb4a4fc96f"), new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("7d7b2546-94dc-47f9-8125-d4be6ee209a0"), new Guid("af489542-b5d8-4135-b3d3-06d3931167c5"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("7ed2051a-51df-4485-b5dc-4a954341033d"), new Guid("0f875d7b-59a6-499a-82a0-97977c3b3a99"), new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("7f2af522-60ee-4783-aaf0-0749f670be49"), new Guid("66a6fcd1-0b55-4c0c-add3-45b5ca07f7ed"), new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("81b8c819-79dd-4978-8236-c96ccf933376"), new Guid("65bcdd02-11d9-460b-a2fd-ab8fdbd4c2c0"), new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("861bc744-8ef4-4199-bc6f-c38982485872"), new Guid("af489542-b5d8-4135-b3d3-06d3931167c5"), new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("867f469c-4358-4c9d-959e-6b5a60dd7a2d"), new Guid("7114d9a2-1c07-43c4-9c0f-0e2db60b0f4d"), new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("8e58c89a-f865-4ad3-8c23-554c06f569b7"), new Guid("c6cf41f3-0858-4fbc-8c7f-425ca062c180"), new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("9dd30f55-9674-4046-bdc4-e4abc4e4f25e"), new Guid("cc2748ff-ac02-48cb-8d9e-ffb49796acc0"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("a18ba909-266b-4894-8392-d4cc98a72f67"), new Guid("e5fa1074-35be-4230-b010-66eef94680ef"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("a6243f8b-ace5-4406-a2fa-d3e47903ba5b"), new Guid("3b0ca5f5-95e7-4059-a237-abbe933aa311"), new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("a6da704b-6f90-44fc-abf3-cc757e115731"), new Guid("0a014bcb-33e4-480f-a8f6-3aba7a3d7046"), new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a9f6990e-d2fd-4638-8ac4-1231eb2f33b8"), new Guid("4b98fc66-872b-4728-ab9e-0e57028c4fb2"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("af22acb2-43f0-4354-9181-029e9c76af6d"), new Guid("4adfd7ac-1e3d-4c3d-8e20-8a6d9448b85d"), new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("b0eb3a07-15f0-4a69-916c-bac0d318e30a"), new Guid("6e7a343a-335c-449b-b22d-21d05848e3aa"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("b42bc39d-97fb-4286-bd0b-6360ed675064"), new Guid("40ba5ec7-01c4-446d-8f87-4f1fb81b6502"), new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("b8de71de-ae6e-4b5d-ba5f-4a2139d8ff90"), new Guid("fb6c3671-f9ed-4c30-b84a-f7606888f0da"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("ba042c54-e418-43de-9fb1-74a58881d00d"), new Guid("6e7a343a-335c-449b-b22d-21d05848e3aa"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("bb6e91b5-66a1-4058-bc49-0fa4241afca7"), new Guid("4ecbd7a6-5263-4190-aee3-654383d9e6cd"), new Guid("5d96609e-242a-4e81-841d-15924cb829f7") },
                    { new Guid("bd8e642a-7dd7-4dc3-b386-22a9827472be"), new Guid("d2a8ee54-cb5b-49b5-8b82-95f69efe8775"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("c7dfe51d-1412-4213-aa55-a693982c37f2"), new Guid("d2a8ee54-cb5b-49b5-8b82-95f69efe8775"), new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("c8dbc639-b946-473a-80c6-c221fd64a518"), new Guid("6ea499bf-7276-4d14-8c1b-3c16830b2800"), new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("c9467752-317b-432b-ae1c-30066783eb11"), new Guid("6533dc7b-722a-4175-9713-6cf5b6f3b6ea"), new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("cc8b5dfd-8bbb-4626-9575-6f05bc17e671"), new Guid("e5cdf508-2f3d-480c-b4b1-7d73c03466d8"), new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("d54446ed-37f9-4425-ab61-bd021db360e5"), new Guid("e3c4fda4-bff6-4000-b337-679c3acec877"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("d68f9869-f915-4f2c-a874-1df273ac48e7"), new Guid("45dbd552-3523-4e02-829e-c82c7c855819"), new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("e3d33ead-f155-4fc8-b5d6-bc3cf27bdcdc"), new Guid("439cd9b6-f720-4de5-8267-5fe63d355d18"), new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("e95971c4-6baa-431c-a253-3600c9f2b331"), new Guid("4ecbd7a6-5263-4190-aee3-654383d9e6cd"), new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("ec95a095-65b8-4be7-ba52-cb7e5d02f7b6"), new Guid("d1085972-793e-4706-b589-4bfad2b79c5d"), new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("ecab252e-af0a-4e18-a29a-2443973973d2"), new Guid("4ecbd7a6-5263-4190-aee3-654383d9e6cd"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("eee44234-b86a-494b-83cd-97c70159e085"), new Guid("df969dbd-dffa-4c01-a701-8b1d0ba26550"), new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") },
                    { new Guid("f2f5d335-8c72-44ef-bfd8-84e9cae03199"), new Guid("7114d9a2-1c07-43c4-9c0f-0e2db60b0f4d"), new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("f367f1af-aa96-49a5-9ba6-360727e0eb6d"), new Guid("fb6c3671-f9ed-4c30-b84a-f7606888f0da"), new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("f61ab408-f6d5-4722-93be-2fbba8961c79"), new Guid("a64e2725-ce35-45c9-92ed-92e8ac77d2f2"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("fae752fb-c9f1-4d57-a715-a3e7862dffde"), new Guid("1f04f237-633c-4689-b50c-5e11b3465790"), new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0788aa8d-9561-4941-8a14-16e294fd23b8"), new Guid("3fd072ac-c66d-4bbc-a4fd-4a9792e21cec"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("0958d6ad-47f8-4c93-bdeb-463d1c3e8a78"), new Guid("436c9e03-03af-4817-87a5-14d3a14e7cd7"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("09f790fb-37cd-409b-bbd0-cee8b6057e52"), new Guid("a4097989-eac3-469a-bcfc-e6fb39fbf0e5"), new Guid("5d96609e-242a-4e81-841d-15924cb829f7") },
                    { new Guid("113b1714-0b6f-4b3d-aa24-05c96db1859d"), new Guid("600db10e-8d44-4611-a2d8-699d12f97779"), new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("1555e0f0-0ef3-413f-9ba2-5acd056f5279"), new Guid("1f80c20a-f467-4484-970e-679f94ba7a85"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("19611fb0-c1e1-4e7b-a91d-4c9a19723134"), new Guid("8684eae6-656b-41f4-9df5-a723c7b48db2"), new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("1a99e77d-ace8-4328-899d-5275d228d43f"), new Guid("7b4acef9-a9b3-4059-a5e6-87789da1e9a9"), new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("1b92332d-917e-4e31-a2d2-33e42b5b34d0"), new Guid("7b4acef9-a9b3-4059-a5e6-87789da1e9a9"), new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("2643d055-6873-42de-8b33-71479f200817"), new Guid("b04f2acf-f81a-4447-8d0b-e7b9b20f767e"), new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("26ee0843-e926-4390-9a3e-003cdf2f8bc7"), new Guid("f8643ded-1669-4785-a409-999592e0a0b6"), new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("3a09f805-b2c5-44d2-82cc-a7e62cf0b8c5"), new Guid("65cec080-4e88-48c5-8780-a3b9d5c33676"), new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") },
                    { new Guid("3d4eab8a-70e8-4ede-b64d-7743fee3b00e"), new Guid("6fee1e8b-08e9-42d5-8502-672f92fdd2a1"), new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("40bc8f04-5952-46fd-8427-a0e0e49b35a8"), new Guid("c5908e9b-a5ed-4449-a66d-b27345565d59"), new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("424d7365-0792-469c-9264-ac08bc4502d7"), new Guid("f0825b84-bcc8-4b3f-a01b-3b5af918ca68"), new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("43fec362-674a-4d44-ad6e-eb4787038260"), new Guid("f91f8ae5-534c-4d9b-ab43-604748eebc8c"), new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("46acc397-469f-464d-b4d0-64ac42f09fa0"), new Guid("6b9d9dcd-13b4-4f6e-bf56-960961e98c3a"), new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("4ab628ba-40ba-4835-9d26-3572ed148daf"), new Guid("1fd55ac8-3143-4706-a9ae-42f135c22db3"), new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("4c929df0-664d-47ef-be41-48ed2df68a2e"), new Guid("cc237ff4-e716-457f-83f7-cf6da535c924"), new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("502da0a4-f46f-480b-bc2b-a642433e343c"), new Guid("cc237ff4-e716-457f-83f7-cf6da535c924"), new Guid("b5652445-32c0-44e8-b366-391041e6d37d") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5654948b-a502-4b55-ba9f-249ea74cae04"), new Guid("600db10e-8d44-4611-a2d8-699d12f97779"), new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("5a6dc4d2-acd0-4198-a663-06eacdb53299"), new Guid("6fee1e8b-08e9-42d5-8502-672f92fdd2a1"), new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("6231e878-f63c-4fdf-88be-3ada2de7981f"), new Guid("a4097989-eac3-469a-bcfc-e6fb39fbf0e5"), new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("6544eb83-3c4b-472f-9181-3203bd362603"), new Guid("8a8c2d22-2b93-4078-b573-50cfae2f0b35"), new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("6b956b48-871d-49f4-b695-02f52022ff9e"), new Guid("71879894-a52f-4467-98d6-c04ddac9c059"), new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("737fc2ef-6e67-46d9-9195-e41b97c4e7cf"), new Guid("436c9e03-03af-4817-87a5-14d3a14e7cd7"), new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") },
                    { new Guid("7769d7b3-8e46-4977-93fb-575bb0998bb7"), new Guid("600db10e-8d44-4611-a2d8-699d12f97779"), new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") },
                    { new Guid("804d68e4-d2c8-45dd-b184-c60334bea7f6"), new Guid("b8ed636d-a539-48db-8a43-3bc3c81b7220"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("81d01e0c-e248-47b8-b1bc-f87fe1c5eca8"), new Guid("9a75ff28-f8aa-45c6-b642-84d243c40015"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("856ab2cf-9f39-4af3-b093-c70c0b547921"), new Guid("1019cebc-61fc-4773-a0cd-6f7ed17829a7"), new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("8869ec37-2815-426c-bdec-859003e7dbf5"), new Guid("4b428343-3ed0-4cc9-be36-c8f905f22c0f"), new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("88f71770-ed7d-493f-8563-3fad675a0138"), new Guid("6ad5db2a-b501-47b6-9c5b-f7579cf6cba5"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("89f21a38-484d-4902-afc4-9906bd4e0476"), new Guid("8684eae6-656b-41f4-9df5-a723c7b48db2"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("8beb0867-7f37-4350-89ec-aa0ab7099b6d"), new Guid("82cdf11d-99ee-49b0-aee0-4724918b9718"), new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") },
                    { new Guid("91e08f8f-06ec-430e-8f74-c80432e5f5ad"), new Guid("8e2508bc-aaca-4977-9b23-ec6b32eb914a"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("99ef5d60-8bd3-474e-b0d4-fcc49fab5204"), new Guid("ba671965-b327-4c7b-beb1-3e38f5aed3c4"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("9ba3357c-7300-4178-a81d-f29039e00b9c"), new Guid("8625e94b-7bf0-4d10-a96b-a15b5320e38d"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("9c3dfad3-1ce0-4c87-8aaf-4b7bd12c5ccc"), new Guid("6fee1e8b-08e9-42d5-8502-672f92fdd2a1"), new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("9c6e6c11-4fb6-46e7-94c5-d335fea11a1c"), new Guid("9a75ff28-f8aa-45c6-b642-84d243c40015"), new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("9d1c7095-9581-43d1-b4f3-6c82d130ec1e"), new Guid("c938714b-85b3-49f7-9b62-a47f10b6b3e3"), new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("9e7a4ff0-b750-4f1c-8745-f33a4b703c8f"), new Guid("a8112e0b-57f4-4f27-919c-41b164d4869d"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("9eebfb9b-44e1-47f4-89f8-1ad0ab6e6b37"), new Guid("230b2f3b-9feb-4fd8-801a-537406424d43"), new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("a4e3435c-e5e5-4957-a5be-6d87e597f62c"), new Guid("a8374876-e178-496c-867b-001fd5bf6d0a"), new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("ab9d5b8d-7626-4067-857a-00e1438345dc"), new Guid("600db10e-8d44-4611-a2d8-699d12f97779"), new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("ae597b23-d4fd-4a06-8392-2e2a9383b08c"), new Guid("99ea63f3-189d-4d04-9a61-c6bd8dbaf51c"), new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("b5615d24-654e-42cb-a2d6-af5a287aa863"), new Guid("a59958f3-65ae-44f6-8119-b2676ee0ced8"), new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("b5c781b1-4fea-4ff5-bf41-eba222ba7241"), new Guid("f8643ded-1669-4785-a409-999592e0a0b6"), new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("b7239b2d-8117-4225-992a-e7def1b304dd"), new Guid("c5908e9b-a5ed-4449-a66d-b27345565d59"), new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("b7cc85e2-f34c-4768-a4ed-ef470e791b73"), new Guid("1266c61e-fba1-4b75-8aba-2c7a028d787b"), new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("bfe619c0-b2ac-43f8-847f-561c9cac80c8"), new Guid("3fd072ac-c66d-4bbc-a4fd-4a9792e21cec"), new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("c198dfa7-6627-4a14-aff5-9df65810edc8"), new Guid("fb8699d5-8f7a-4440-b077-c4864ae0b271"), new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("c3b4c582-1997-455e-8688-2bf7c06015f9"), new Guid("d287d4be-331d-43fb-8ba1-94f0f3a11fd8"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("cba6bfe6-d622-44fd-9416-7d676a2c9c67"), new Guid("b3460f5c-a332-4480-9b52-3248bddbaf34"), new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("d4d6865c-1d4e-4398-b593-9c7c82d2af18"), new Guid("cc237ff4-e716-457f-83f7-cf6da535c924"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("d50e5ce4-4b31-4296-b4dc-8f0101e7b58f"), new Guid("a8374876-e178-496c-867b-001fd5bf6d0a"), new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("d654fbe0-df02-4706-a0e5-850bb6e0e3dd"), new Guid("a8374876-e178-496c-867b-001fd5bf6d0a"), new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("eace4786-3ad3-4d32-bfad-9116ec7dc396"), new Guid("ca7ec7ba-3327-4c8d-bb6b-b9e964007efc"), new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("f1c3c863-0eb9-4113-86f4-b5e083d88d74"), new Guid("59b3ccde-fdce-491e-ab64-f7d2c6bbc128"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("f2516d19-46b6-4f0b-9871-2fd76f478941"), new Guid("3608d862-2771-4cb4-b1a4-f6ec2dd2b71c"), new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("fa0e0d65-0e26-42e1-b809-44cf46b15f3d"), new Guid("f0825b84-bcc8-4b3f-a01b-3b5af918ca68"), new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("ff50e7e3-28d2-49e6-87ac-ad233f7daf85"), new Guid("6fee1e8b-08e9-42d5-8502-672f92fdd2a1"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "PromoCodeId", "UserId" },
                values: new object[] { new Guid("008958d1-ced7-461d-92c5-e89c3a7f8402"), new Guid("2322fe3d-20af-4638-bf8a-56c5536f7187"), new Guid("68aabafd-916e-4fb8-ab1c-7380e1573bdc") });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00ab7d9c-4032-4e58-b365-8f3870ec9ec3"), new Guid("1d36b191-65ea-464e-b057-ae4a7af224cb"), new Guid("f04a0f44-bc77-4eec-8c00-a2c46ac31092") },
                    { new Guid("06a0fab6-48d9-424a-9263-e8676e87628a"), new Guid("103f79e6-bfc2-42ac-9d89-eaa25c2d32a7"), new Guid("f94ac40d-39d1-4a16-bc0f-b9c0629b6467") },
                    { new Guid("10123a54-fc0e-4966-ab34-beadc2e894a9"), new Guid("832c9bc0-5ab2-4c34-9d1f-a101b7140a2f"), new Guid("3ac32d9f-9771-4eb5-9eef-20e12ce89cf6") },
                    { new Guid("15129d8c-2494-409a-ac14-bda1b9878cb7"), new Guid("9f980f80-6cf8-46ee-a9aa-694824476792"), new Guid("092ff5dc-7026-46b7-9b5f-3cb3da509c9d") },
                    { new Guid("162633d5-27e4-4df5-9e2f-46cefe27079a"), new Guid("09312d0a-1916-40f9-85d5-568f451251a9"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("16801d08-5e80-4706-95f2-408231f63256"), new Guid("1d36b191-65ea-464e-b057-ae4a7af224cb"), new Guid("e20dc5e9-d231-4590-9288-c1430cf497cf") },
                    { new Guid("17255bb6-da92-4c11-9cf5-048571ef06f1"), new Guid("5b58c722-704b-49cf-a5ef-9a473146ea17"), new Guid("ba263609-12ed-41fd-8f29-33cf16ddb100") },
                    { new Guid("17767f8a-8225-4eef-b49b-5be336c66ee4"), new Guid("ddafbbd9-7f2d-4a21-954f-ce20a57462af"), new Guid("4e0f75d9-00a7-4954-812e-b29c82b2fed1") },
                    { new Guid("1895cb6e-177c-4fd0-b030-a0f3d820134e"), new Guid("fc83cdee-ee11-453b-99d1-7144004e1532"), new Guid("e532c6b4-1991-456a-82b7-b5c360a20603") },
                    { new Guid("22b89b95-68f5-4a1e-9f76-e4f61e4a1682"), new Guid("852415e0-eec0-4cda-90f0-0632c0b3c0a3"), new Guid("4d7ad763-f133-4452-a52c-bf8209b54131") },
                    { new Guid("322e6c3a-e970-4007-9e6d-72e19527cd8d"), new Guid("191e0a9e-2828-4df1-bfd4-a7f102eb2c34"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("413ce283-c55a-4c07-9c41-be638af64c21"), new Guid("086a1465-92b8-4adc-a082-b92fdc02f4d9"), new Guid("8739d498-f150-4032-bd74-8a1a62b19ff2") },
                    { new Guid("418bafdd-7dd8-48ae-b463-132cb80928ee"), new Guid("2e93e465-884d-4720-8907-1401840040c6"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("468fa5dd-1264-4629-9171-f53c8c58559a"), new Guid("8d6dde37-e371-4d07-9a7d-57add175b36b"), new Guid("4cb49d3a-8147-4413-8ba8-999a4bd4309e") },
                    { new Guid("508fb214-abbd-4e1f-8dc9-15a1d6abb5ef"), new Guid("5df5014c-ee5d-4747-b995-fb61b01b3aa1"), new Guid("59833684-3b12-4dc5-8797-a3d5cb4b62fe") },
                    { new Guid("5694a9d3-4de5-4d06-985c-6d0e833df9ca"), new Guid("461df417-579d-4398-9e9d-7bac6129beb9"), new Guid("b5652445-32c0-44e8-b366-391041e6d37d") },
                    { new Guid("581b1c8d-1e3f-44d3-adcf-ef1edc09bea6"), new Guid("73282046-132c-420a-bf7b-2bb82c33032b"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("6c204fe5-a026-47bf-a56c-1171ccdb6bb5"), new Guid("103f79e6-bfc2-42ac-9d89-eaa25c2d32a7"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("7287390d-0ec2-4410-99af-e7cca1877929"), new Guid("d254d895-0cf7-4b59-a605-d374c9fe4cec"), new Guid("ce668b5b-7796-4ec0-b2de-b2d608b48c9b") },
                    { new Guid("7995f723-63dc-4d66-a370-c78ae4183698"), new Guid("9f980f80-6cf8-46ee-a9aa-694824476792"), new Guid("c12506d4-2612-4a16-a14f-cd9163860d65") },
                    { new Guid("7c16e843-4d9a-4c81-bfcb-cba7d76ae027"), new Guid("53e9c47c-f5d8-4dfc-a81b-cbeddd4dba9b"), new Guid("38262136-b169-413b-ac46-ad2f34893b37") },
                    { new Guid("7edf70b6-fef5-43cc-99eb-36dc6d68ad25"), new Guid("33d30757-954f-48cb-9d70-4bf01e06a6b0"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("832cc492-7993-4bfb-ba8f-47f3cb96dd08"), new Guid("cf989657-228a-4f1e-b635-21aab72d9a96"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("87458ee5-25e2-4947-9027-30fdd2af6619"), new Guid("cb981804-6046-4146-b76d-271c92608516"), new Guid("fa638c00-d981-4aa4-832a-fcc8233561ad") },
                    { new Guid("8e8e1132-f497-4629-bf66-03478efa50ec"), new Guid("ed188acc-6517-45fa-9942-e68972d07d9d"), new Guid("f9bfa7e4-6e1e-4aaa-b28a-636dfb5f8165") },
                    { new Guid("8f78fd4e-4f3a-441c-802c-1cb1b16d12e3"), new Guid("47ff5d9d-a1db-4431-8cfd-9ce76e7ddf97"), new Guid("ee031cb9-cac8-44bb-aa1e-6eed52e3a882") },
                    { new Guid("94179013-e6d2-4992-8ec0-0e287a073b51"), new Guid("6f12ab32-7543-4518-a720-9d64b82c7ae2"), new Guid("30eaf229-a750-446f-b353-8f619614a839") },
                    { new Guid("97f231e0-9685-41d1-880c-124e33e95169"), new Guid("ae808282-db49-4c34-a50f-1394c2244565"), new Guid("406d2568-124d-499f-ab91-bf26387bbe3d") },
                    { new Guid("9af4ad3a-cfd3-4767-bd2f-eddb53288322"), new Guid("d24facee-a415-4861-9fd9-47d8366270ac"), new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("9d3cb5fa-bf77-4a9a-abf7-675e026f468b"), new Guid("3d8c0621-357f-46b3-98b8-04829f77141a"), new Guid("012410d8-9338-40b1-b094-2c9efa3c1c5d") },
                    { new Guid("9fda0c84-5b17-499e-9712-baf892464b95"), new Guid("cd57fd72-bee4-449d-899f-176e18677c25"), new Guid("973d13f2-9619-4004-9439-5abc562bad41") },
                    { new Guid("a4329b0d-0d16-4d4b-8ac9-70afae1642e7"), new Guid("b268f37c-1836-4207-84e4-2a9a2d0f46a1"), new Guid("e6097123-c594-4bdb-870c-0cf57528e39a") },
                    { new Guid("aac1db45-563e-4d4d-b554-749e65cffd8c"), new Guid("ed188acc-6517-45fa-9942-e68972d07d9d"), new Guid("6a5fe53e-8e86-457d-b572-41769cb2fc91") },
                    { new Guid("ab5ae00b-d352-4691-878a-d6259030a215"), new Guid("98030b31-3fe0-4958-8cc8-1bbaaba69e7b"), new Guid("0ef317a7-cc1c-4b06-a1e7-9b6e063ea0ff") },
                    { new Guid("ad6a9d99-ea44-48e9-8084-fc13779e7a1b"), new Guid("c619765e-aaff-4a20-ab00-259aab1d8939"), new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("aea168ed-c560-45b1-9321-93808bfe111f"), new Guid("73282046-132c-420a-bf7b-2bb82c33032b"), new Guid("4a9c9271-d464-4065-866c-61bebcbab92a") },
                    { new Guid("afefc891-f066-48a1-bffe-99741fcb7e1f"), new Guid("09312d0a-1916-40f9-85d5-568f451251a9"), new Guid("3b21ed1f-7564-42c7-b095-9d7d26c4b117") },
                    { new Guid("b75fa2bf-1d41-4586-ab0e-136a96ee4709"), new Guid("5d96efdd-28c5-416f-bdab-44449d047cf1"), new Guid("7b8e4931-841d-4c14-9a0c-ea2a4db5a49f") },
                    { new Guid("b9f5b005-55aa-4451-9c73-67df35e95418"), new Guid("98030b31-3fe0-4958-8cc8-1bbaaba69e7b"), new Guid("14901d8f-ff41-45f0-89bb-3316f1d3f5ee") },
                    { new Guid("bbc803fd-d867-433c-8187-060bf60b34b8"), new Guid("d355abfd-9eae-4c33-a5a2-3a59c552b298"), new Guid("9f8b3067-6b98-4e50-9b27-b922901849b9") },
                    { new Guid("be9f79b6-b54f-4794-9fa8-480687da8b42"), new Guid("d29b7fc4-2f2f-4e49-885a-4143c3b33d14"), new Guid("fdb536da-cede-4b09-bad0-b86702d0452e") },
                    { new Guid("befa249d-5bea-4541-bd69-4f695250ea7a"), new Guid("af1c1c74-d91a-45f6-8c85-0be1f63b2ee1"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c570a3c1-efde-4d63-8ee0-57f62c7f6c2e"), new Guid("d682716b-683a-4edb-9ae6-6824170b54c8"), new Guid("eab380e1-e4aa-4fd0-986b-992d36adbd5f") },
                    { new Guid("d148feb6-4036-4f65-adb4-f01fb61a3c9c"), new Guid("73282046-132c-420a-bf7b-2bb82c33032b"), new Guid("9c37ed6e-7e40-497c-a150-86e94e98129a") },
                    { new Guid("d1d740a3-22fc-4d52-8e01-958d5377020b"), new Guid("292f15bb-4ae7-401b-9e1a-467bee6778ea"), new Guid("3162f344-f10f-45da-971c-d41cc675f838") },
                    { new Guid("d3b4715f-1e95-4973-8d89-468d8626e6ea"), new Guid("bc69a075-e200-4104-af9e-1405212fc628"), new Guid("7948de76-604a-49ae-b05a-d3bdde08aacd") },
                    { new Guid("d939f449-8878-47fa-be5f-d4cbe7e37437"), new Guid("2b99afef-2ef8-4617-a715-a65c42fc623d"), new Guid("1487f226-aa5e-469e-bbf3-c30fac73b337") },
                    { new Guid("da3f2d5a-fe04-42b9-8b47-db0abaf7edea"), new Guid("f6d2cee6-a211-412a-b301-65e3a0980d53"), new Guid("6518a1e3-618d-4481-b8d6-3a7090ec070a") },
                    { new Guid("de1df67e-e7e6-43ff-ab99-68d88b964838"), new Guid("5d96efdd-28c5-416f-bdab-44449d047cf1"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("e21e743e-39dd-430a-87e8-7176ab4b2b26"), new Guid("33d30757-954f-48cb-9d70-4bf01e06a6b0"), new Guid("3c0091f1-f303-46cb-8f22-2791dd3d8c17") },
                    { new Guid("e2de37bc-8114-40c6-92c9-736ffe13c9d2"), new Guid("b560c563-fbe1-4635-a0e6-fd6119396c8a"), new Guid("5d96609e-242a-4e81-841d-15924cb829f7") },
                    { new Guid("e3baacf0-d12c-4a26-be4d-aa612dfe14af"), new Guid("f049d737-efc1-4e1c-8d95-c99a99dd46f7"), new Guid("85465426-23bd-45da-8610-8fbf237a6018") },
                    { new Guid("e6ae84a6-aefc-470e-beb4-2a5f6f44467d"), new Guid("cb981804-6046-4146-b76d-271c92608516"), new Guid("bce8259a-ef9e-4932-a47b-c1efe9066bd0") },
                    { new Guid("e846b279-92ec-4954-a0fb-38c2f9a4c796"), new Guid("d254d895-0cf7-4b59-a605-d374c9fe4cec"), new Guid("06583580-4c31-420a-9d2d-f2148abc06a3") },
                    { new Guid("eaa712cc-9560-4ecf-bdce-d119a34a0682"), new Guid("f049d737-efc1-4e1c-8d95-c99a99dd46f7"), new Guid("b73d98af-0a57-4d3b-bbfe-812711da8337") },
                    { new Guid("ead0cbda-d039-4921-a988-dccbe8d2720c"), new Guid("ed188acc-6517-45fa-9942-e68972d07d9d"), new Guid("3240c306-4cda-430e-bd41-4d8b8abeefa0") },
                    { new Guid("ef009685-3319-445d-9e42-b696d49a425a"), new Guid("5cc47e23-9c4a-4660-8afe-9ae5c37cf5ff"), new Guid("facad5df-d1d4-447a-9e86-00d4f05f13f3") },
                    { new Guid("f9d57c9d-7cb7-4749-9d2e-3c611076f761"), new Guid("c2e6985b-1752-4b7d-b7ae-f9fccc08de59"), new Guid("4b419694-b708-45f4-ba12-d448054d38e8") },
                    { new Guid("fc1a0930-4ddc-4f02-9002-c386abdde508"), new Guid("461df417-579d-4398-9e9d-7bac6129beb9"), new Guid("6058378d-35ff-41d4-9a9f-12010e0ec07f") }
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
