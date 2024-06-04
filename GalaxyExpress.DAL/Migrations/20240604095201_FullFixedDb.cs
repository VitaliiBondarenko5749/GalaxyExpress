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
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Login = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    FatherName = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    ProfileImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
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
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), "bd073072-d1c4-4c17-8ce7-8d02a1de1328", "User", "USER" },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), "4f1ee941-5aad-40cd-82a9-ef1d356efefb", "Manager", "MANAGER" },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), "fdfaa956-af5f-474d-ab21-ceacfffa615d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115"), 0, new DateTime(1960, 5, 27, 16, 29, 19, 724, DateTimeKind.Local).AddTicks(502), 420.0284627217440000m, "f9277261-1f03-4fe6-875e-32e79f97383f", null, null, null, "Naomi", "Schulist", false, null, "Naomi_Schulist", "AQAAAAEAACcQAAAAEEws9aVPDyYcXHauH1p/WhcpHa5TJPXl3ihelkfooX8TpRfTinK4apfc+aJlrdQmkg==", null, null, 2, false },
                    { new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4"), 0, null, 985.8137830693020000m, "354dece9-e2ef-4b02-bc4b-da57c78ebb5e", null, null, null, "Jacquelyn", "Feil", false, null, "Jacquelyn.Feil", "AQAAAAEAACcQAAAAELPpYkmxOm9Noxrn77OxtL9u2R4f9cJyzRLFUCGoOtbrsTYjFxr/sPlvBDUIGFN58g==", null, null, 2, false },
                    { new Guid("01a8bd37-aff4-4aac-8218-b782c941985f"), 0, new DateTime(1954, 6, 30, 10, 36, 47, 216, DateTimeKind.Local).AddTicks(585), 361.5948063576160000m, "821c2372-cd06-4e4f-91da-b3f1d2264aad", null, null, "Carmen", "Carmen", "Wolff", false, null, "Carmen.Wolff", "AQAAAAEAACcQAAAAEEy6QebgWtNXaW8Ayxiy1tUN3tT6nqKoS/mF6oO0G4NyRPuOYe+AqCgKmOxWOfCC4w==", null, null, 0, false },
                    { new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa"), 0, null, 265.6536240422010000m, "fe2a358c-dd91-490f-8621-b108264029b2", null, null, null, "Israel", "O'Connell", false, null, "Israel.OConnell37", "AQAAAAEAACcQAAAAEHODuwgo5T7aLm0ngev+TKG4LbXWYDC3wcB+MqTu8HJY3RPcs/3f7uYJk97f1EkWUw==", null, null, 1, false },
                    { new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28"), 0, new DateTime(1980, 9, 6, 21, 6, 2, 420, DateTimeKind.Local).AddTicks(6206), 278.9807785686540000m, "43ae1a6d-8026-4731-b605-2288b679d3ca", null, null, "Tommy", "Tommy", "Runolfsdottir", false, null, "Tommy_Runolfsdottir", "AQAAAAEAACcQAAAAEBph45JdxlN0FoadFzaWfpMzOaGDeJ+/8FhjXXXYJYHAX72cT0DqD4yd7EUxBSOXfw==", null, null, 0, false },
                    { new Guid("05fb67eb-3b60-4c93-bf80-36153be08871"), 0, null, 573.4976730695540000m, "917c3e42-9a1e-46c2-95c3-fd7db2c4b3bc", null, null, null, "Victor", "Green", false, null, "Victor86", "AQAAAAEAACcQAAAAEDy7UdvD2r9GMgcacNJu8jMv82NlPww3GQzO2kpNmH5j8pZ5ockIrd101aAsfhvDjQ==", null, null, 1, false },
                    { new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2"), 0, null, 631.798718741830000m, "984ee687-b181-4e4b-a55c-ff7c1cbf2a6e", null, null, "Dean", "Dean", "Kemmer", false, null, "Dean.Kemmer70", "AQAAAAEAACcQAAAAEGyP52k8a74bizhHlj2kMAmAmGmuqadRXs8Xcgn6TugcH8ahmQ7Yw1w0niG+n7LJIg==", null, null, 1, false },
                    { new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361"), 0, new DateTime(1962, 10, 28, 8, 31, 34, 27, DateTimeKind.Local).AddTicks(9434), 175.0942873340010000m, "fe6854d8-d7df-4bc5-b6e7-e9072776ae0a", null, null, null, "Cheryl", "Armstrong", false, null, "Cheryl86", "AQAAAAEAACcQAAAAEMokGGaIrQ6Rp4ePH6y+Ojo6izyr4nXO86wX8hh3eBDo66TZ1CsqA2jCbWMtRCB6TA==", null, null, 1, false },
                    { new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8"), 0, null, 159.9234442134530000m, "e4adcd89-14d6-46cd-8d48-781e32eea60c", null, null, "Sandra", "Sandra", "Hodkiewicz", false, null, "Sandra67", "AQAAAAEAACcQAAAAEMp2/HPZfG19O5vL1Yz23xZMGXKl56CxU1c2O9UUICN2dEC6kkGIN3ydTI6/J4tLPQ==", null, null, 1, false },
                    { new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7"), 0, null, 929.9307277455160000m, "cf19cb6d-2b15-4b46-8923-d9be9acc5934", null, null, null, "Ernest", "Herman", false, null, "Ernest75", "AQAAAAEAACcQAAAAEFivL0fNY2kXGS+7GcRVUtYtMTWGFBWX2qfpGQpPhbmUmjuJoUQN5wen4tI2umTGEQ==", null, null, 2, false },
                    { new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1"), 0, null, 611.6615784826080000m, "f6c0d472-44a3-4c04-8ccd-d36b7d36a910", null, null, "Rosalie", "Rosalie", "O'Hara", false, null, "Rosalie18", "AQAAAAEAACcQAAAAEF2Zrl5d9QZENLrP76GgHR0gYFJm/563cNjDDHyNAeycsJGFCXu68A3RLv3LRmWrbw==", null, null, 1, false },
                    { new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5"), 0, null, 578.6931265052990000m, "c8a385d0-e4d1-4ad4-a549-7e0401194d8d", null, null, "Susie", "Susie", "Hirthe", false, null, "Susie24", "AQAAAAEAACcQAAAAEPTHRvUMuBZJ2JXRR+of0i2BDCmygcGs6bdTJxYidoSLfJfKNZ3TVF6qOEplX3KRCQ==", null, null, 1, false },
                    { new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), 0, new DateTime(1978, 5, 16, 0, 53, 48, 94, DateTimeKind.Local).AddTicks(4083), 467.0341523354770000m, "d12547b9-5360-4803-96ec-10144bf5c9fe", null, null, "Jason", "Jason", "Ritchie", false, null, "Jason_Ritchie90", "AQAAAAEAACcQAAAAEDtTgF6y80lhCBM6J+bDnZvVqbQlHfvaul/vx7tfResBUjAKcpdIvsP4v2RjdKkNgQ==", null, null, 2, false },
                    { new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808"), 0, null, 621.3867749258040000m, "61bfde80-f9e0-4f02-80e7-66ec02ef6470", null, null, "Phil", "Phil", "Konopelski", false, null, "Phil_Konopelski", "AQAAAAEAACcQAAAAEFhPVDy3KerkvAArDnu3Tj7jZKYown4ISP2irJR1iSvetBkETkV9q1Z3AH2/gM2lkA==", null, null, 0, false },
                    { new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5"), 0, new DateTime(1980, 12, 2, 20, 0, 4, 689, DateTimeKind.Local).AddTicks(3880), 268.3891141347930000m, "acab931a-f93c-4f5d-8952-b316b9ce2254", null, null, "Perry", "Perry", "Grant", false, null, "Perry.Grant", "AQAAAAEAACcQAAAAED8YIvZHxZPeNwir7TChvrO4qvgTKoa0pI479aw9oxrerRWvBveJggafRWop4/SCcw==", null, null, 2, false },
                    { new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6"), 0, null, 182.850059849570000m, "146cab09-e74d-4ca1-a25f-bb3709a51816", null, null, "Cheryl", "Cheryl", "Lang", false, null, "Cheryl.Lang", "AQAAAAEAACcQAAAAEFtUjPhFMTHBb/V8qxpJbB86GUslaz9z+HDohSGLyCK/e6n0U9lHWBiji3s60/t7Wg==", null, null, 1, false },
                    { new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0"), 0, new DateTime(1964, 1, 3, 7, 11, 45, 526, DateTimeKind.Local).AddTicks(1380), 954.9901127525980000m, "fa0e2ce1-e044-4f66-9b18-0c90c6abd91b", null, null, null, "Luz", "Nolan", false, null, "Luz22", "AQAAAAEAACcQAAAAEDQp+q7GpsYOY3W7JtIn/1iCCq4z7tr0hIlCQPoOWVZlv5Xfc8mxluJ6iuRL/ReYPw==", null, null, 2, false },
                    { new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c"), 0, new DateTime(2008, 9, 23, 12, 3, 43, 551, DateTimeKind.Local).AddTicks(5840), 124.6683212353150000m, "393ba741-8696-4be6-b729-c988256f0cae", null, null, null, "Gerard", "Bogan", false, null, "Gerard.Bogan43", "AQAAAAEAACcQAAAAEB25m9inpKZHRXE0igM/42QeKatsbRgYUo3Qcl/PDtmsqi7d1SkyrWg8Urs9KKEuZg==", null, null, 0, false },
                    { new Guid("114ac41c-5eba-4152-8f7e-622356a03762"), 0, new DateTime(2000, 3, 12, 4, 49, 10, 619, DateTimeKind.Local).AddTicks(2271), 36.98484186372390000m, "2e201ce0-bc4d-4e5e-b856-619a5af335c5", null, null, null, "Loretta", "Stroman", false, null, "Loretta_Stroman", "AQAAAAEAACcQAAAAEOSxzyOoE3JZ8dYC/7yjTHDCu7Fu06UDeXu82ZLV3niy8GF/LUsYkJs3kSbSHBLg1A==", null, null, 2, false },
                    { new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30"), 0, new DateTime(1997, 5, 29, 15, 22, 59, 271, DateTimeKind.Local).AddTicks(5661), 968.5641178732490000m, "d55ac6b6-c6b2-4cbc-afe6-521bbf6f5620", null, null, "Claude", "Claude", "Klein", false, null, "Claude.Klein21", "AQAAAAEAACcQAAAAEH1AN/6XACIn1lOfFYKc9tK7JSnZ7yEv+nBTH1cOIIMrhhvaCkx0vNcvkk+6t49PsA==", null, null, 1, false },
                    { new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14"), 0, new DateTime(1960, 12, 4, 17, 4, 49, 422, DateTimeKind.Local).AddTicks(5449), 705.7856379747570000m, "e6f0480c-28e6-4c73-92d0-1da415659876", null, null, null, "Fernando", "Wyman", false, null, "Fernando94", "AQAAAAEAACcQAAAAEGt5KblVnkQKUr9+TD3UxDx9nb0mVAVYIwkMLcIbYLzAUXoy8G9w5PeOM7wgge5YQQ==", null, null, 1, false },
                    { new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20"), 0, new DateTime(1990, 3, 24, 16, 52, 49, 451, DateTimeKind.Local).AddTicks(1602), 132.0162167448250000m, "2c037464-c8ff-411d-a366-6db0edeb68c2", null, null, null, "Fred", "Prohaska", false, null, "Fred17", "AQAAAAEAACcQAAAAEFd+MxkdSJ5ozOuRZZ+GHhks219iMmK2ANO1nOULy0bbeYjVJWBC4Jod8TdPnY1eSw==", null, null, 1, false },
                    { new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163"), 0, null, 231.8780501023530000m, "a8fb9953-5683-40da-a83f-8bb2ce1d21dc", null, null, "Jermaine", "Jermaine", "Koss", false, null, "Jermaine.Koss99", "AQAAAAEAACcQAAAAEPVw/+Wco0WinKSgSGo+/lYhdcsm3+ibqrAkCT6QPFA9+3bdH2dRNFNRiBTBmvw1qw==", null, null, 1, false },
                    { new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062"), 0, new DateTime(1957, 7, 30, 15, 56, 27, 667, DateTimeKind.Local).AddTicks(5189), 447.558702361580000m, "e1c209e2-2c17-4c32-9af6-5fbc9d576058", null, null, "Jorge", "Jorge", "Walker", false, null, "Jorge_Walker", "AQAAAAEAACcQAAAAEHsct1iL+ATgW70VHupgm737htuy9eJxkDtoLSUgA9p5GQ4LvycmgtDEYsQ8RpfoHg==", null, null, 2, false },
                    { new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9"), 0, null, 391.0963398275390000m, "5944b17e-936a-4c7b-97b6-3de0019910c0", null, null, null, "Beth", "Weimann", false, null, "Beth.Weimann", "AQAAAAEAACcQAAAAEJP3D0VGr82lU0s/7lq3LyRRpfFlZhTWtUD/ZcR+kWpJ7O30oJ8Z8VtdixQbS5hG3w==", null, null, 1, false },
                    { new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad"), 0, null, 68.04745259806830000m, "ec139fb7-25be-4b0a-8748-f1e82a1fdb24", null, null, "Kristie", "Kristie", "Crooks", false, null, "Kristie_Crooks", "AQAAAAEAACcQAAAAELR4vveqHuL6Ab5HdRb3RHItKJUmVnw0tvYJkB/agTforcHJnD3xRgtL5S0T9LC+cg==", null, null, 0, false },
                    { new Guid("18e4d405-c797-4c9c-af33-613450990efe"), 0, null, 491.8326090688360000m, "1243b6c5-cc23-40f7-9e0e-a542fc86c008", null, null, "Cecelia", "Cecelia", "Blick", false, null, "Cecelia.Blick", "AQAAAAEAACcQAAAAEBDXFoEVYTdQ1Wz5oerd8lLuCXUakiHzxfrMEsLbeX8huenDsgtFOXyy8TtKeaILyA==", null, null, 2, false },
                    { new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf"), 0, null, 556.3492141017440000m, "700c012b-0585-4ad5-8e35-bd24632fb2e0", null, null, "Leona", "Leona", "Feeney", false, null, "Leona_Feeney1", "AQAAAAEAACcQAAAAEJOTTboaq/Ombau0ZKLVHZyP0YeWwD05lrlcuA4os90H78bcuYpRFwI680QvINYgYA==", null, null, 0, false },
                    { new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33"), 0, null, 229.4627291829920000m, "81f7e0e4-0359-4860-b52f-1c79a9ad32a7", null, null, "Alberto", "Alberto", "Cassin", false, null, "Alberto.Cassin", "AQAAAAEAACcQAAAAEObTn3TOG5optRtoUafGf67PI24a/K3JVh9NBfxlUt0EG4pnr0ashxssa/4drxSMxg==", null, null, 1, false },
                    { new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b"), 0, new DateTime(1950, 2, 10, 23, 27, 21, 672, DateTimeKind.Local).AddTicks(6907), 421.073491983330000m, "6ac7b5b7-1dd4-43f1-a8d4-377706d26341", null, null, null, "Renee", "MacGyver", false, null, "Renee.MacGyver", "AQAAAAEAACcQAAAAEDLRSSSSRmObAYY0yv8ZCAjALdCzurEa88cNt2iHAPTuXcBXn+qRD9BM5Q/9YT0/+w==", null, null, 1, false },
                    { new Guid("1ca2e699-11df-445a-8084-51598bee7020"), 0, null, 292.1713563025770000m, "5a91a13b-29f4-4971-9d17-4d0eda50ff92", null, null, "Joann", "Joann", "Denesik", false, null, "Joann_Denesik61", "AQAAAAEAACcQAAAAEFS1qXioTzhzTJlaknYMByZZu3pTRV2FoZc+W3YUKwBWAZ1TyamgTAzvBI4FTydyJg==", null, null, 1, false },
                    { new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215"), 0, new DateTime(2001, 1, 29, 2, 33, 10, 99, DateTimeKind.Local).AddTicks(2414), 791.3674136766380000m, "c4692854-65d6-43df-8141-8b2dd9bdbe0a", null, null, "Molly", "Molly", "Strosin", false, null, "Molly.Strosin", "AQAAAAEAACcQAAAAEMx2oxTrQEAEistcO5KmZLVSLUW+w166GSc4b2hZpu8pGRLJHyZezdrn09T94qEXHw==", null, null, 0, false },
                    { new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8"), 0, new DateTime(1942, 9, 8, 1, 22, 17, 473, DateTimeKind.Local).AddTicks(7108), 32.19984359451270000m, "eb84d5f5-1ccb-41d9-8476-965ecd45e2c1", null, null, "Elbert", "Elbert", "Fritsch", false, null, "Elbert_Fritsch", "AQAAAAEAACcQAAAAEBa8XuIw4vWMrG3r6rGYyknXFpbik600Zh8BKJypN5s8QkON0kDfEObA8BTXVdBTrA==", null, null, 2, false },
                    { new Guid("20d4c413-4a9e-4942-a590-4b6a67675891"), 0, new DateTime(1937, 1, 4, 4, 0, 23, 284, DateTimeKind.Local).AddTicks(3177), 125.7246979368170000m, "afccc06f-c660-4194-8636-6e9f9b0fb4f6", null, null, "Madeline", "Madeline", "Hayes", false, null, "Madeline.Hayes17", "AQAAAAEAACcQAAAAEM+OwQEUj81dJkH2oABok9PzIX0HO6KoH+IDwO+GAHoaRzWKn7ZVelSsIizur+PPtA==", null, null, 0, false },
                    { new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7"), 0, null, 836.0557491054760000m, "5bed1069-89aa-41fa-b603-0105b068114f", null, null, null, "Charlotte", "West", false, null, "Charlotte_West2", "AQAAAAEAACcQAAAAELniqaNIdAjWMhrp4LaF8lYvZeypH3dgabCoRYi89NfzIDY0Y/XKmPvcx/jsavqzFA==", null, null, 0, false },
                    { new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd"), 0, null, 476.9006439678840000m, "22ad39cc-aa44-461f-8e03-b4d0a1ae5c2b", null, null, "June", "June", "Steuber", false, null, "June60", "AQAAAAEAACcQAAAAEJUcYOrCKDuNNadRagodK5Z5cA73sEP2Swf0avtn5tJG7ElJu6iARliOqEm3vhiT6A==", null, null, 2, false },
                    { new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca"), 0, new DateTime(1964, 9, 18, 14, 52, 24, 660, DateTimeKind.Local).AddTicks(80), 934.1232546667740000m, "3abeb665-054c-4c8f-972b-4c0aba2c3845", null, null, "Owen", "Owen", "Armstrong", false, null, "Owen53", "AQAAAAEAACcQAAAAECUpO5oQewqzUmbsZdrJNn2P8kzWP8Xlm9PQIldkFJ2ESSogZ6av8yAuGB3b4e1Lpw==", null, null, 1, false },
                    { new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6"), 0, null, 747.5235471046840000m, "aaad80d1-c25e-4079-bd3c-a2f1cd14ab20", null, null, null, "Trevor", "Nolan", false, null, "Trevor_Nolan70", "AQAAAAEAACcQAAAAEP0ZIr6oo6stv3INoQeTr1eM8DAmgpaLqG3UN5upBmfQVd9iaR6CUVWziGmyuNnPXA==", null, null, 0, false },
                    { new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7"), 0, new DateTime(1966, 2, 18, 22, 37, 18, 697, DateTimeKind.Local).AddTicks(7557), 284.9588930488470000m, "f2093afe-f2da-42e0-afce-dd4374b02f5a", null, null, "Mack", "Mack", "Auer", false, null, "Mack2", "AQAAAAEAACcQAAAAEMCHFGPq2IdDAAHpsAyg17SXyITVZzZD6sTK2K5uLSyOySFk+ucg/BDFhcNf7Tsg5w==", null, null, 2, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("246ee090-764e-420d-803e-5d97e7d873a0"), 0, null, 659.5712606049040000m, "685fddbe-0503-4e0d-bd69-2db0c08bfe4d", null, null, "Shari", "Shari", "Grant", false, null, "Shari55", "AQAAAAEAACcQAAAAEDWg9zm8GflRHZdJ9tg1XvkiZGZ1et0HwnjsHMT53eIvsRBpP8AevMKzpiinIY8CsA==", null, null, 2, false },
                    { new Guid("26e9f9a9-c77f-4f47-b594-e602be058706"), 0, null, 634.2022552420640000m, "8c451d99-84be-44be-b6c9-b310a71fe2c2", null, null, "Louis", "Louis", "Bode", false, null, "Louis_Bode", "AQAAAAEAACcQAAAAEGb5TVhbk2BsFeir5zLMPrpjVCwhgHqYUsmYyY5Y/v0nq1ojCtG9eRY2FVPOI51ZjQ==", null, null, 1, false },
                    { new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0"), 0, new DateTime(1962, 7, 1, 22, 20, 24, 144, DateTimeKind.Local).AddTicks(825), 475.4156917725450000m, "d0d0e80c-34e5-42d1-8abc-0e09ed37b8eb", null, null, null, "Abraham", "Larson", false, null, "Abraham_Larson", "AQAAAAEAACcQAAAAEB7HELzMQN+HMy2IBtqvXV+7d2dEklysWin1JnFajwxA6F35+HOMK0WuY0QSgpb+Bw==", null, null, 2, false },
                    { new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd"), 0, null, 230.3663311177780000m, "6dddd384-9c5d-4e88-a466-cb7154b4098e", null, null, null, "Corey", "Haag", false, null, "Corey_Haag25", "AQAAAAEAACcQAAAAEDNJPEcwsFxr07ZQGmNkTIKjrK6bhnLJuZPDi17pQXSidlU/sIEIWVjcKOriAAp8iQ==", null, null, 2, false },
                    { new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee"), 0, new DateTime(1996, 1, 3, 0, 27, 38, 38, DateTimeKind.Local).AddTicks(8998), 157.9979393256310000m, "15c2113b-ec25-4fb7-a943-701c06c61070", null, null, "Lois", "Lois", "Hettinger", false, null, "Lois.Hettinger23", "AQAAAAEAACcQAAAAEJZlV9tyXH26LmvUq89AfBTc5Yhn3BXf0QZpjA9DY5qEbvKf6m4FO1b03qiPazdzQA==", null, null, 1, false },
                    { new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781"), 0, new DateTime(1968, 9, 19, 3, 22, 6, 220, DateTimeKind.Local).AddTicks(5665), 24.01262444130060000m, "2eba070a-57c2-4a63-a1f9-e18c5de36161", null, null, "Edwin", "Edwin", "Rohan", false, null, "Edwin11", "AQAAAAEAACcQAAAAEML2WOPcjMMo4eOWEGvsmF3lqLwdwjBbfWnNKoy4/ospUXLoAcYB+fxkSNYdcCjcXQ==", null, null, 2, false },
                    { new Guid("285d8d29-53de-4979-a403-f61b887fa207"), 0, new DateTime(1994, 4, 19, 2, 4, 49, 470, DateTimeKind.Local).AddTicks(2499), 442.7578671814650000m, "f554c80d-14fe-448d-88ad-5470ba2e329b", null, null, null, "Agnes", "Schiller", false, null, "Agnes16", "AQAAAAEAACcQAAAAEJdSG+oaGxGIagf39V6cvjp+noIThYY2Xs5IE6Hv4Fhz/hEzHi/FEjN+jLkQfa7gYA==", null, null, 2, false },
                    { new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641"), 0, new DateTime(1934, 8, 11, 0, 30, 45, 511, DateTimeKind.Local).AddTicks(9139), 583.3468993319920000m, "563c6d1e-0cd3-4091-8c98-b2eb276506f9", null, null, null, "Kelly", "Lockman", false, null, "Kelly25", "AQAAAAEAACcQAAAAEM+oSRzFF9FxLAqq1nXvrPOSeYZiqVDqWUf1VK/b/3MWbk2cATKsGHoSVEGl2nWX+Q==", null, null, 0, false },
                    { new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518"), 0, null, 488.0742680969630000m, "c59d79f6-bf5c-41f7-a8f6-23a2eaae5ccb", null, null, null, "Diana", "Carter", false, null, "Diana67", "AQAAAAEAACcQAAAAELR+t2K8phrVC0iuNOG2H1cVFd0Y9pPXCNw4UiYYt+VtV6K7Ru/Guq8tjCMA8rOyog==", null, null, 1, false },
                    { new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79"), 0, null, 375.6307067489510000m, "3ae382cc-35d9-4f71-b8a1-59e6a90f9e2d", null, null, null, "Brittany", "Schroeder", false, null, "Brittany.Schroeder11", "AQAAAAEAACcQAAAAEDdWCmYiUzXyBB7uT4rQIgCwaLzbAWSKk84KSsc3QEydyKn08c+vgHXwnjn9R4l8Lw==", null, null, 2, false },
                    { new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b"), 0, new DateTime(1992, 6, 27, 16, 32, 3, 536, DateTimeKind.Local).AddTicks(1345), 570.9106762952780000m, "8d33125a-e6eb-42e5-8f61-b1b1fbc42a0e", null, null, "Boyd", "Boyd", "Goldner", false, null, "Boyd.Goldner", "AQAAAAEAACcQAAAAEGKoggbqw+KxMXuGkF7WLD7HCu6hZY7oXtPd/WmEmtCVjKtPzqlsx8tDTKt8Wf2y4w==", null, null, 2, false },
                    { new Guid("2da9ab08-6750-4a36-8423-df883774a78a"), 0, null, 529.691802642230000m, "6163c711-f303-44a2-a3d2-5b5076024ab0", null, null, null, "Beulah", "Waelchi", false, null, "Beulah77", "AQAAAAEAACcQAAAAELiVIxY0vKjc4PZUO8/v1Fa0LNZQ6dwpfjBBsweCn8Nngx/OUbuMHtsfS9Sqvo8ULA==", null, null, 1, false },
                    { new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb"), 0, null, 895.0830040504650000m, "87f481d6-1a93-4d20-8e79-5a7060ae5b4f", null, null, "Norma", "Norma", "McDermott", false, null, "Norma.McDermott", "AQAAAAEAACcQAAAAEPmQx8t47MJKEDLEhOkO1Y3G5KXqtCL47vZbeBvTdM0EON+tBa/wRAPbJ9FnPBqttg==", null, null, 1, false },
                    { new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd"), 0, new DateTime(1980, 1, 25, 23, 39, 36, 982, DateTimeKind.Local).AddTicks(1465), 695.0542296921530000m, "a7e55015-f11b-4be2-81d2-df24f80a7e95", null, null, "Jan", "Jan", "Hilll", false, null, "Jan.Hilll61", "AQAAAAEAACcQAAAAEASRLmjBXEKjy15wtRRMowr3xVFmfHZnRmha90Y9ozo6GWy9KlFtx2Bv3B+5vZChHw==", null, null, 0, false },
                    { new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd"), 0, null, 649.8895297111370000m, "b2ef6981-2083-4b0a-85aa-7622681c8a01", null, null, "Winston", "Winston", "Nicolas", false, null, "Winston.Nicolas39", "AQAAAAEAACcQAAAAEH+VGYDKriNA+XOwqS1SFrGbM1R5CCdIoG+EM5IExxndrVtuwEYADkiKdot6I3QyfQ==", null, null, 0, false },
                    { new Guid("316bd6de-f98f-4240-856b-7b943204b4fb"), 0, null, 865.7176668224270000m, "65911a9b-090a-4dda-8852-93d60b572d30", null, null, "Beth", "Beth", "Price", false, null, "Beth_Price", "AQAAAAEAACcQAAAAEOogd9tAM2L3KWJGvilRG3gVjRm/TGIUDp1aGsU4CuTIwEU9nO2k8SEl5f9TPmd96g==", null, null, 2, false },
                    { new Guid("3288753c-07c2-4e2b-85e9-1279757a9971"), 0, new DateTime(1975, 1, 10, 15, 11, 21, 680, DateTimeKind.Local).AddTicks(7508), 792.5588132799510000m, "67ba99d7-0096-47d8-a632-d055ac16bdec", null, null, null, "Garrett", "Rowe", false, null, "Garrett6", "AQAAAAEAACcQAAAAENQhEDvl0QtjsCognCYDMDL/UiKyZpBnYsUkvxhwJy0secb5y3eB9REjxOH5hQD1YA==", null, null, 1, false },
                    { new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643"), 0, new DateTime(1943, 12, 2, 23, 28, 30, 446, DateTimeKind.Local).AddTicks(8421), 784.4041408797240000m, "da1d07d1-05cf-4c0f-b7c1-56ededc262e7", null, null, "Mary", "Mary", "Kiehn", false, null, "Mary.Kiehn90", "AQAAAAEAACcQAAAAEAAofKWwQ/C43FaL2hveMYT+/OtdazAv1jKwUlNdkifAXvIfQ1LiStr3PnVdL4M0tQ==", null, null, 0, false },
                    { new Guid("354e9bbf-de43-4345-a871-f0af96ec9410"), 0, new DateTime(1939, 5, 22, 7, 47, 51, 421, DateTimeKind.Local).AddTicks(5693), 375.8828343509730000m, "a5b1cd74-07ec-4270-bc93-c7e17a2d89e6", null, null, "Edna", "Edna", "Weimann", false, null, "Edna_Weimann", "AQAAAAEAACcQAAAAEFkYVr+hRFDqMdwx8IU+wI21IOs3Z8l1wwYOtUuiDMwWqMsZDrOLBjCf2jz9klWLag==", null, null, 2, false },
                    { new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5"), 0, new DateTime(1945, 7, 7, 7, 34, 26, 494, DateTimeKind.Local).AddTicks(8359), 86.26056063407690000m, "46971aad-95db-48dc-8bce-f6aacc74ccb8", null, null, null, "Hazel", "Olson", false, null, "Hazel.Olson", "AQAAAAEAACcQAAAAEIKSLoMojpvzZjxUC3aZB+oyFfEUCWMJBRfUzL7qaycp68NK42YqMuyUpywe/sIYzQ==", null, null, 1, false },
                    { new Guid("364df856-5357-4366-afda-cf52f25f1325"), 0, new DateTime(1958, 4, 27, 22, 23, 37, 627, DateTimeKind.Local).AddTicks(174), 791.1664031657090000m, "18188218-d629-43ec-b993-718375875ecc", null, null, "Wm", "Wm", "Herzog", false, null, "Wm_Herzog0", "AQAAAAEAACcQAAAAEPyA/Fq5kzENnzrtxn3UCK2C+eMQi+ycImvYgFoskyT1JU82qYmF+Ds4D6OdKXGYSA==", null, null, 0, false },
                    { new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b"), 0, null, 826.9411792454740000m, "87f2c889-e669-477a-8bda-dd2631b6cd28", null, null, null, "Claire", "Corwin", false, null, "Claire_Corwin30", "AQAAAAEAACcQAAAAEPu+ZL+Xe2dKddCSlzXyxeHcsWjBhBtTMA0A7O54H9bx5AwUb1a+/qf72n8T5MOmvg==", null, null, 2, false },
                    { new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3"), 0, new DateTime(2005, 7, 25, 20, 29, 39, 923, DateTimeKind.Local).AddTicks(8301), 329.447544272620000m, "822f6b4c-ca91-4d0a-b71c-82dbfae7e937", null, null, "Francisco", "Francisco", "Hilll", false, null, "Francisco75", "AQAAAAEAACcQAAAAEAC1sbOKKPx7M0xZ4vXg/zquaN9KfXRmNmUVxjKGNLQg/0K2BKF+29hoWn1UF14ffQ==", null, null, 2, false },
                    { new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02"), 0, new DateTime(1940, 1, 23, 20, 34, 34, 697, DateTimeKind.Local).AddTicks(2667), 101.9085280759990000m, "27876513-0e74-47a3-a018-a3a81a420aee", null, null, null, "Marguerite", "Schuppe", false, null, "Marguerite40", "AQAAAAEAACcQAAAAEC32YeUkAmePv4dlBsPm8dVH5tC4bt7dYLtINvsK7mYoYWZIUIjY6zoECsWaNV9HHA==", null, null, 2, false },
                    { new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee"), 0, null, 661.9128866962880000m, "91a02632-2e86-49a0-a83a-5e2e9c8d8d16", null, null, null, "Lucy", "Roberts", false, null, "Lucy_Roberts", "AQAAAAEAACcQAAAAEHFoe8S3iVSww3kt94Sp1+u79CNSZzZXNmivsSp8B+of/Szub9bcIEG+WthU4HHQFA==", null, null, 0, false },
                    { new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75"), 0, new DateTime(1998, 9, 13, 7, 3, 57, 937, DateTimeKind.Local).AddTicks(1200), 960.9141081452320000m, "7fcdb85f-9939-4d5d-b98b-37f5840e9aac", null, null, "Dixie", "Dixie", "Stokes", false, null, "Dixie56", "AQAAAAEAACcQAAAAEMkAe+wWcmXZzDtm6SsFymslFFHAOuNBHmR8htDupavtdDa0aLTZfFnLiW0ZP2tlOw==", null, null, 0, false },
                    { new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35"), 0, null, 72.52719026911590000m, "eb255c63-7cf7-4daa-aaab-965aa4e20dee", null, null, null, "Cary", "Romaguera", false, null, "Cary34", "AQAAAAEAACcQAAAAEA7sxkmGJH+xkR5F3/NQ/0zYqT+t63/zfN5L9XL+nn7qQwsH4qrSUzc/DQeRkN4ETQ==", null, null, 2, false },
                    { new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4"), 0, null, 35.94706117908220000m, "8c49c7f6-5e87-4ba0-a3ab-75abbd9d703c", null, null, null, "Pat", "Robel", false, null, "Pat.Robel", "AQAAAAEAACcQAAAAEAP8YKeS9JyhvgImvdWEJ+oqSKv9Zx2JVSZUOwvWdWCTwsXADpTNHLASj2b4nUw2Hg==", null, null, 2, false },
                    { new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2"), 0, new DateTime(1953, 7, 31, 21, 4, 17, 34, DateTimeKind.Local).AddTicks(1403), 233.1574369184850000m, "bc3eeb9e-cadf-4312-a5ad-b00d3fb26e46", null, null, "Freda", "Freda", "Ward", false, null, "Freda.Ward", "AQAAAAEAACcQAAAAEH9E+U3H4YnnQ0VIBgJ6NvFMKglvRFlEd9MccP55qqi/TTfrkwHlSQLBfXbBkqsdPw==", null, null, 1, false },
                    { new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95"), 0, null, 572.915589228480000m, "b3f5d381-3fe1-4b48-916a-1e2b07736091", null, null, null, "Maryann", "Goldner", false, null, "Maryann.Goldner", "AQAAAAEAACcQAAAAEE58Zk0WJFOjAUbiordVAzvqi2wj28A84AwPk9t41culZ64LuENw4HJfgAEF8uX7hw==", null, null, 1, false },
                    { new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117"), 0, new DateTime(1924, 6, 23, 16, 26, 41, 453, DateTimeKind.Local).AddTicks(1470), 122.4765717600550000m, "89e9b755-129d-4df7-8dcc-8781c82b5a94", null, null, "Neil", "Neil", "Kerluke", false, null, "Neil44", "AQAAAAEAACcQAAAAEI1vYgfAz7B6CT41S+HE4snis2CSXSfgc3lfsw4dlTssOBhV9Y6a+fwUbglMbiinJQ==", null, null, 0, false },
                    { new Guid("4285821d-9d8f-4943-b663-27adc015a9c4"), 0, null, 628.3402553812040000m, "69db4b31-7a28-475f-99e9-8f64472efaa9", null, null, "Phillip", "Phillip", "Padberg", false, null, "Phillip83", "AQAAAAEAACcQAAAAEN/N2NNxxMAzINX9D5GYBIJ/BAinaBLl8o0z1S75OPlvuo+MmoNLQvaXMje9rp3dFg==", null, null, 1, false },
                    { new Guid("42a28881-5765-4f59-9201-be96e3fa60b5"), 0, null, 207.6190220319620000m, "247bb82c-c54a-4c3b-a733-cf375a03048c", null, null, null, "Christie", "Boehm", false, null, "Christie_Boehm", "AQAAAAEAACcQAAAAEHrluesQEGvzki9XezqqMDcplJ5bXCw4osi3gdaoJYxR9kOSRTYvAgbTu4ilrQhKGg==", null, null, 1, false },
                    { new Guid("431cb355-ae94-49cc-882c-971e60381b53"), 0, null, 122.4248052658130000m, "ec788eef-5433-4be2-8dfb-9575d445980f", null, null, "Roland", "Roland", "Anderson", false, null, "Roland.Anderson71", "AQAAAAEAACcQAAAAEENpn+m1Od6h0WiQejAzkOj7filNPigEZAYYoisdL3sEA9nqP20UqD7jHc4lDOMbQw==", null, null, 1, false },
                    { new Guid("4390173e-3194-44b0-9f5c-e816c829e49d"), 0, new DateTime(1946, 4, 25, 14, 15, 11, 858, DateTimeKind.Local).AddTicks(5900), 52.5816381001220000m, "95c06d46-2044-44ea-a92a-d688421ce92c", null, null, "Paula", "Paula", "Marquardt", false, null, "Paula51", "AQAAAAEAACcQAAAAEEvT2JzYNQ6SiI162vnSv9UHAFOmqXTxPUyGALzR5Za6ZkZvRXBFtRpKmhD/pvCysA==", null, null, 1, false },
                    { new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78"), 0, null, 360.5342447413530000m, "fb20b18b-64c5-4126-96f5-aa63b7b05d9c", null, null, "Philip", "Philip", "Walker", false, null, "Philip70", "AQAAAAEAACcQAAAAEL7dA3R3m89jBGlDMdVu2xo8oPkDX1EAQB8xaJ2/E3fQwo7GNzqtxxr/5GN6TzML1g==", null, null, 0, false },
                    { new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c"), 0, new DateTime(1992, 11, 10, 10, 46, 32, 206, DateTimeKind.Local).AddTicks(8745), 976.808710666580000m, "577f6832-afb0-4fd2-a819-7b2d3a5bfe70", null, null, "Natalie", "Natalie", "Hettinger", false, null, "Natalie_Hettinger31", "AQAAAAEAACcQAAAAEA9Ms8PpX1HUzWTzFEBrB2KsbOZgIozS+uSGPvXOT3VWHFX3bjQM9YE3Wke4Okweug==", null, null, 0, false },
                    { new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f"), 0, new DateTime(1940, 12, 21, 16, 45, 53, 252, DateTimeKind.Local).AddTicks(5402), 245.2451257058810000m, "84872e9a-d453-4c58-9fbb-72557e85ac5d", null, null, "Phyllis", "Phyllis", "Gerhold", false, null, "Phyllis_Gerhold", "AQAAAAEAACcQAAAAEN4lhPVxXWSrFwinfiQltW5ASv2hNy2OWySLTcMSp7LlPr+Xxi6l1KIWT2B/LitSsg==", null, null, 2, false },
                    { new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481"), 0, new DateTime(1998, 9, 12, 8, 19, 32, 479, DateTimeKind.Local).AddTicks(7729), 267.0324984059220000m, "53a5cd46-32be-4d36-865c-6ebaf359abd1", null, null, "Olga", "Olga", "Casper", false, null, "Olga.Casper", "AQAAAAEAACcQAAAAED99LQUHTMvXovI0E/UZln+85/gBrJ6m+iEPGOpQ7CroDdILA+vWY5YfHGThwMm/MA==", null, null, 1, false },
                    { new Guid("4860b124-2e67-49cc-b664-135729261ac4"), 0, null, 454.1842579896240000m, "218a0a83-f753-45a9-866e-5165aad351a3", null, null, "Johnnie", "Johnnie", "Ritchie", false, null, "Johnnie38", "AQAAAAEAACcQAAAAED3kiW0D3uk+ugX9g3ri1hnWjOJOs/ApXFqWT++j4NPYfj3EQVMEo3/mStJDAEXouA==", null, null, 0, false },
                    { new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036"), 0, null, 906.8260083749540000m, "582caba3-2351-49ca-90f5-5e4c6d8c8de2", null, null, null, "Joe", "Metz", false, null, "Joe_Metz73", "AQAAAAEAACcQAAAAEB6/UXT9IgEuBPR5dJJa01pMi30AQg7OdrZAClf5d2tY3KKBaMcqAxKA3kFByMLMvA==", null, null, 0, false },
                    { new Guid("4bc48bed-c113-458c-8a12-8f12565a542b"), 0, new DateTime(1942, 12, 8, 16, 25, 37, 108, DateTimeKind.Local).AddTicks(5769), 828.0773808567910000m, "02b208a7-a8ef-4b7a-a242-5201c9f0e7b4", null, null, "Olga", "Olga", "Balistreri", false, null, "Olga.Balistreri71", "AQAAAAEAACcQAAAAEPQVd4QOrgTklAaXxMhT6fqDsFc3SqHioFDziEvE1jPtUhsjMZjEKx1Byp2/NPcC1A==", null, null, 1, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549"), 0, new DateTime(1956, 8, 25, 0, 16, 1, 621, DateTimeKind.Local).AddTicks(5742), 335.684405288960000m, "4ff584aa-286b-4925-9cdf-da55e1faf344", null, null, "Jack", "Jack", "Quitzon", false, null, "Jack.Quitzon13", "AQAAAAEAACcQAAAAEEv9qXjZagyHyVbalResHE5NDNCXHEXFlm4cDdOE/dFr8+fxgV5omLeT9nhFwc8lWw==", null, null, 0, false },
                    { new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443"), 0, new DateTime(1964, 3, 27, 7, 31, 0, 520, DateTimeKind.Local).AddTicks(8077), 378.8089817869340000m, "617e7558-79da-48a1-b7b5-f7db54cc3b53", null, null, null, "Raul", "Nikolaus", false, null, "Raul_Nikolaus3", "AQAAAAEAACcQAAAAEMjipQwds0ylyO4J86DRE8WT7NGE5/oP/r5uuSFvLK8U5eFHrev/xOcTJjQP7/Iv+w==", null, null, 2, false },
                    { new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab"), 0, null, 0.2755207381824890000m, "311ec229-1436-4e9d-9f08-f48d0b0c25eb", null, null, "Brooke", "Brooke", "Ziemann", false, null, "Brooke74", "AQAAAAEAACcQAAAAEAkapmwicC/hKZMWdapN8u1j3zHQbXtHMADCWHB/MpozIwF4OWu5e6fWTticnumhxw==", null, null, 2, false },
                    { new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86"), 0, null, 493.3093489869530000m, "af0d40a6-b8cc-452c-ac06-be17917b6e8c", null, null, "Bethany", "Bethany", "Reilly", false, null, "Bethany_Reilly", "AQAAAAEAACcQAAAAEMGyqTbpGC51SgG4zW393R2VYSE6tFZCPn3iaptuOplAKyoKwlVUL3871SeejyJLog==", null, null, 1, false },
                    { new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4"), 0, null, 332.765083929850000m, "0511f7a7-b3a8-4e52-8f97-a8adc9758fbb", null, null, null, "Guadalupe", "Pacocha", false, null, "Guadalupe_Pacocha", "AQAAAAEAACcQAAAAEEgGS7dpb0hpwrrYf0tWrfFZjfyZAimA1JoS5oyfUnMeeUe+WEHj/Urm298uw8DEfQ==", null, null, 2, false },
                    { new Guid("5053bd1a-741f-48b6-8412-85c27342ccca"), 0, new DateTime(1968, 7, 16, 1, 18, 20, 538, DateTimeKind.Local).AddTicks(9935), 708.3546769410180000m, "4f94d47b-406a-49a7-b14b-d45769b780aa", null, null, null, "Clinton", "Hodkiewicz", false, null, "Clinton65", "AQAAAAEAACcQAAAAECnpvjD8AjuitvLfeeXckst9Wz+g2LP6JGuGwaY2MEoyYvECXCVoI1p8Tp4wt8Z3gw==", null, null, 1, false },
                    { new Guid("50a38340-96f3-4c16-af8c-098f142991c6"), 0, new DateTime(1943, 4, 12, 4, 18, 12, 542, DateTimeKind.Local).AddTicks(5865), 938.6685631850160000m, "312114f3-289e-4668-8bca-cdaa92f256c1", null, null, "Jaime", "Jaime", "Satterfield", false, null, "Jaime.Satterfield", "AQAAAAEAACcQAAAAEHRLRRgvUOG/dKDTgLCEG0db/dAYjBjIkNxv85iZaPGyp9PJN6Xv4dzlMb7sIj2veg==", null, null, 0, false },
                    { new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb"), 0, null, 205.8901105689420000m, "7b3860c6-3c47-47d6-810f-a9b1dfc907d2", null, null, null, "Mindy", "Osinski", false, null, "Mindy97", "AQAAAAEAACcQAAAAENTSAhy1oq3z6RAUm817MHPTz/ylCNaUWGuMivR03x+C61RB4yRiHZ6AUEdbU1J3mg==", null, null, 0, false },
                    { new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c"), 0, null, 159.5311039233110000m, "9d303e19-597d-4359-8f50-b4cc6137191c", null, null, null, "Ira", "Hammes", false, null, "Ira12", "AQAAAAEAACcQAAAAELMyOue7UOuLet5sJhRAFdx0mWDcd3UBhefbsSL8mIw73QiFHDzsmND3v79TZaNwIw==", null, null, 1, false },
                    { new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3"), 0, new DateTime(1992, 11, 29, 23, 8, 54, 458, DateTimeKind.Local).AddTicks(1113), 921.2286383384530000m, "e0cd5d03-392f-45d3-a58a-c7c607bca00e", null, null, null, "Ivan", "Howell", false, null, "Ivan35", "AQAAAAEAACcQAAAAENw9+qYqDVc0Ex2RulhnF43K8Wq+PgujHxtfVFQ+iKcFBBDan/wmit8dFf1v3Pckwg==", null, null, 0, false },
                    { new Guid("558db05b-0b8d-442b-8166-524709ea133f"), 0, null, 757.1028743120680000m, "9afa52d3-fed7-464d-9b1c-b1bcd7b821bc", null, null, null, "Ellis", "Leannon", false, null, "Ellis_Leannon44", "AQAAAAEAACcQAAAAEJupHQAB8iZjdAznlIiQEcu9899hmFHZkrPDtb7rf2jJWkE/J4QscWeyc12E7NyfFQ==", null, null, 2, false },
                    { new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0"), 0, new DateTime(1997, 1, 15, 16, 44, 0, 844, DateTimeKind.Local).AddTicks(6709), 622.9712724334470000m, "62bbeabe-aa79-483f-8243-0b5cb11f691c", null, null, null, "Ted", "Kuhlman", false, null, "Ted_Kuhlman", "AQAAAAEAACcQAAAAEL6cCRVdRU1+vx8foXpGP38lTjm4LJKmEtu5zW2WxQ1U58TYLhV8A2CNpdhw5AliNw==", null, null, 1, false },
                    { new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c"), 0, null, 53.8789162096280000m, "6e6d8680-94d9-422a-9069-850d09f99307", null, null, null, "Tabitha", "Bayer", false, null, "Tabitha.Bayer13", "AQAAAAEAACcQAAAAECyWTJQKiCs2b4rYNU+RclHP6IGHpg84eb10pp50hEO6VH+Tdr3ZbvXCXgZIf/+wyw==", null, null, 0, false },
                    { new Guid("58526312-a56b-4b29-b8d3-e131efce8cef"), 0, new DateTime(1961, 10, 12, 8, 14, 35, 579, DateTimeKind.Local).AddTicks(8584), 27.66238990019220000m, "8b5ecb8b-1c54-4d6b-a852-75524f38475c", null, null, null, "Gail", "White", false, null, "Gail90", "AQAAAAEAACcQAAAAEG+OV2up/d4P2CbHWeCG10DbfIQk9zfZ7SCO6ZV+maCfpXDFdxLjT+t8MoezFyrpTg==", null, null, 1, false },
                    { new Guid("5911b08b-117c-4079-af41-1eb1e8574741"), 0, null, 863.9427405983540000m, "febd3861-1bd1-4eeb-9cb3-8aa68243d7c8", null, null, "Shannon", "Shannon", "Bailey", false, null, "Shannon_Bailey", "AQAAAAEAACcQAAAAEDwYTY6kH/+0rR6K5rPYW4bsG8hiPmFwfZ4d1crBlYDkyolLT3oy4i6CHC63ptLPIw==", null, null, 0, false },
                    { new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265"), 0, null, 230.6800016475650000m, "be210f2f-05ff-47ac-933b-14212f93f208", null, null, "Sharon", "Sharon", "Stanton", false, null, "Sharon.Stanton", "AQAAAAEAACcQAAAAEMW+43F9vU5Yhis6LZuOkumCVgNNGvH5GmqiyznT8K1H5KAhAa+ECGw2tSb2JJHw/Q==", null, null, 1, false },
                    { new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a"), 0, null, 478.6102551457220000m, "689f5682-e1ef-47f3-955c-907c80126d19", null, null, "Tracy", "Tracy", "Stehr", false, null, "Tracy.Stehr", "AQAAAAEAACcQAAAAEFKsbVzPLsONRaMki+cMA4up9UdfUaExetTfnHwehPFBVYrGfNbXXvjiIoGYz8NUQg==", null, null, 2, false },
                    { new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc"), 0, null, 752.4970626537440000m, "c4c9103a-fce6-4fe9-8c38-146f14979cd1", null, null, null, "Orville", "Stehr", false, null, "Orville67", "AQAAAAEAACcQAAAAEItOgDSjKaDo9XYnhWmiS1PCI2AbGoslOVyVOxrpsonpknOM2BJc3F6HqawIl1vLUA==", null, null, 0, false },
                    { new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f"), 0, new DateTime(1990, 8, 29, 18, 53, 5, 655, DateTimeKind.Local).AddTicks(2739), 291.4876768155410000m, "49b4177e-9b85-4f48-a43e-a251950859a2", null, null, "April", "April", "Langosh", false, null, "April.Langosh97", "AQAAAAEAACcQAAAAEIlkzldyiLeAaEQz+2PUmvR8LMMJDiQrxN99euB2Xym/Q9HB9U6qvYPdFcbBO8mZig==", null, null, 0, false },
                    { new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f"), 0, null, 474.9198725992550000m, "46c0bbf4-ec37-43ef-ba91-b7d0934a4ca9", null, null, null, "Nichole", "Jaskolski", false, null, "Nichole_Jaskolski", "AQAAAAEAACcQAAAAEMKBzOQTPqtxvRnnXoc5UHx5pQ+WZ+9QZPFbE8C6lFc9TfM3/PdpfVxL7Dq+03+65g==", null, null, 1, false },
                    { new Guid("5d480052-0b52-4d30-b62f-37baad5187bb"), 0, null, 303.2197678198920000m, "5b325177-0db8-43db-a00e-98f7574e1b2e", null, null, "Micheal", "Micheal", "Wehner", false, null, "Micheal71", "AQAAAAEAACcQAAAAELPWANQ6Y9k4uQWYmP8q200bgN5rfilYms8MPLbELAWNBe8LcYtascVerlZ4eMlppg==", null, null, 0, false },
                    { new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e"), 0, new DateTime(1990, 5, 20, 10, 56, 13, 836, DateTimeKind.Local).AddTicks(4986), 536.8563669224850000m, "bd918571-770b-4e82-bf56-30f52303e6b4", null, null, null, "Stuart", "Ebert", false, null, "Stuart60", "AQAAAAEAACcQAAAAEBlQyH4THH1kb3/jIUfVFiT8p2IviyNcryP6cJ/rV2j+3umYYLVSbMdcGYKMCV5ARA==", null, null, 1, false },
                    { new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c"), 0, new DateTime(1928, 2, 27, 5, 46, 49, 627, DateTimeKind.Local).AddTicks(796), 606.1419624521470000m, "2c07b2d8-77ad-4aea-9433-8ecb27096075", null, null, null, "Eddie", "Moen", false, null, "Eddie.Moen50", "AQAAAAEAACcQAAAAEDBqncoySu9brxYTxC/B93Ju6uqb92geXzLuVTjn07zwR/q19PG8to/e/0cpHCe+UQ==", null, null, 0, false },
                    { new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597"), 0, null, 282.1514479108440000m, "e6ce3c04-7b02-4ba0-9106-50272db47a3e", null, null, null, "Emmett", "Lang", false, null, "Emmett.Lang", "AQAAAAEAACcQAAAAEBxjdOMBp7aqsEFriL+9hsLsvhTj8m9nTMBSaBS93I9ZilGQQO/cvuizkV/03sB7zg==", null, null, 1, false },
                    { new Guid("60f7f230-ff82-425a-a6c5-cc5156098000"), 0, null, 718.2025452591290000m, "0dd87cb4-74b4-4354-8725-ec7f933eb022", null, null, "Chester", "Chester", "Beahan", false, null, "Chester87", "AQAAAAEAACcQAAAAEMIsxPBtExwi/SzjvDurHUTnSJWvj4p46jjsfbwA7p0wCScQjvQ1OTNVy/AJtx05Gg==", null, null, 1, false },
                    { new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de"), 0, new DateTime(2004, 3, 21, 18, 5, 7, 472, DateTimeKind.Local).AddTicks(6060), 894.7091362107490000m, "e13fae22-6d58-4b04-8a3f-095757ec72e8", null, null, "Nettie", "Nettie", "Huels", false, null, "Nettie.Huels13", "AQAAAAEAACcQAAAAENvJ/BoKaLpCP//EjAvVSbNmtC088TMNMlJsUsgIJK5qA9bxF4ZkDTJy0ujCXlgKYQ==", null, null, 2, false },
                    { new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8"), 0, null, 982.336756235390000m, "4613d103-4c7a-433a-a17c-290367656f26", null, null, null, "Marguerite", "Ruecker", false, null, "Marguerite_Ruecker25", "AQAAAAEAACcQAAAAEEX8VbZi+DJhDbR56iRpO+ZA5tVy5BU2E3b1W9DAeyLCqc4/QAfi5OHpXhOlNEPb1A==", null, null, 1, false },
                    { new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8"), 0, null, 354.7056459038490000m, "8a47b902-596c-4a30-9237-f490ea4ae812", null, null, "Benny", "Benny", "Ortiz", false, null, "Benny_Ortiz25", "AQAAAAEAACcQAAAAEN3lO8I2739o1sCb4pWdknGmwyxGQroEczpCGF3WIpH4a8og+HTflh2I1x09ZhKWQA==", null, null, 1, false },
                    { new Guid("64ae7664-3300-40cf-a69a-7862eca124da"), 0, null, 193.2608249002670000m, "8e08b018-798e-459c-9459-8bd025ff0c6a", null, null, null, "Lee", "Moore", false, null, "Lee99", "AQAAAAEAACcQAAAAEGRSkKyjoY1ypZU5I+wXPz/YD0H+Ck//z4QhBdE1nQV6rpReB8onwuAkkMVsVFAdNg==", null, null, 2, false },
                    { new Guid("656e8637-7fb6-43dd-969d-25c4c065aede"), 0, new DateTime(1935, 12, 26, 11, 17, 44, 56, DateTimeKind.Local).AddTicks(3900), 373.0007759230160000m, "c9d40676-e938-4fd4-9625-3c43224375c4", null, null, "Charles", "Charles", "Auer", false, null, "Charles24", "AQAAAAEAACcQAAAAEBvftjHUGSDVT1NZyYbHU8M7vq2P44FeNbo9NK+epvjgvPNT4UdYEyxPYvATY5n21w==", null, null, 2, false },
                    { new Guid("67421d1e-5702-485e-b8e7-42fccca07695"), 0, new DateTime(1953, 9, 19, 12, 8, 31, 419, DateTimeKind.Local).AddTicks(2926), 658.3062062535190000m, "781a5b49-b8eb-414e-9ab9-ebec9e531a65", null, null, null, "Luis", "Cummerata", false, null, "Luis.Cummerata", "AQAAAAEAACcQAAAAEMx7nWZwQyXfM1+I+GNzqRPKXvUwmNBYU/k3ggrm7QDVgI8sVbo1Pd65pD1TWxMAGw==", null, null, 2, false },
                    { new Guid("680c6306-048b-493d-8369-356efb0cafae"), 0, null, 393.0481348414510000m, "65ea1e66-c022-43fb-8144-e361f8946ba9", null, null, null, "Lucy", "Funk", false, null, "Lucy38", "AQAAAAEAACcQAAAAEAUB/+HDi21x19+kwUpcuC+Cl2ZbxJKu9OWyVnPtCdn6reNYI4avd5d49l/fEwyHLA==", null, null, 0, false },
                    { new Guid("68126886-3e88-499d-9fc4-4dc56e519e25"), 0, null, 783.2799555196960000m, "666e55bc-a3a0-48cd-ac85-e8e13133a6fa", null, null, null, "Arturo", "Flatley", false, null, "Arturo.Flatley", "AQAAAAEAACcQAAAAEMGiCgLPqYPbcbZQuvx7zBkYoy2bJ7UWnUlHEXpHqXfAEz8jdFvxXmTWVomi2wNwwQ==", null, null, 0, false },
                    { new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305"), 0, null, 389.4633912808010000m, "9fcb5f4b-ea8f-4f5d-9a67-32216e5c272c", null, null, null, "Kay", "Huel", false, null, "Kay_Huel", "AQAAAAEAACcQAAAAEBTgLw3bgjbLvFgW8bD5bSN8GpONLEqzbFq8pxrYFHFcWOEgyOgOLXNmKe+dB2aGbQ==", null, null, 0, false },
                    { new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd"), 0, null, 383.7166044475930000m, "1d42d896-5b9b-4a31-8721-55d009e62b2a", null, null, "Grady", "Grady", "Ebert", false, null, "Grady.Ebert7", "AQAAAAEAACcQAAAAED9h/0t2aqNHeuNL8NxsSdAtbkap4oU2ngh/j3aND6jOk71zb4zuXX1iutaRBSG+pw==", null, null, 1, false },
                    { new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841"), 0, new DateTime(2006, 2, 7, 23, 49, 39, 461, DateTimeKind.Local).AddTicks(6620), 309.18931050480000m, "c98bb930-8840-45f2-b848-85f31d7b42a4", null, null, null, "Kerry", "Haley", false, null, "Kerry20", "AQAAAAEAACcQAAAAEGxv3Ln1+NJSAw7VRpLSl6HaEzVrULeIxdJyfdsSyUZuPHOGaklQHWtFGWBbFK17aA==", null, null, 1, false },
                    { new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1"), 0, null, 546.8843771604620000m, "1fede776-18ef-4457-a246-a0614a04adcf", null, null, "Hope", "Hope", "Ondricka", false, null, "Hope.Ondricka", "AQAAAAEAACcQAAAAEEJ/kHboVqD5v+JTfAycfSvV0D5NPxNug7ytZ/02bHICBeK0ydMsI+FL3iqjtqy3Rg==", null, null, 1, false },
                    { new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86"), 0, new DateTime(1976, 10, 21, 9, 28, 55, 990, DateTimeKind.Local).AddTicks(2964), 842.6737907808370000m, "64e445e6-e0d6-4980-83d5-37dd5d241e58", null, null, null, "Desiree", "Jaskolski", false, null, "Desiree.Jaskolski", "AQAAAAEAACcQAAAAEDcGCtPFb1fHaPVEfLD8JF4v/7J1du3/L28xUBHuPfTy79La02wGp/X4j93I+DX9ag==", null, null, 1, false },
                    { new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0"), 0, null, 701.6619811460680000m, "0d27e63f-8fcb-4f26-8d39-e9cd9812790e", null, null, "Ebony", "Ebony", "Cartwright", false, null, "Ebony_Cartwright", "AQAAAAEAACcQAAAAEM1CbJMg3caXkocrgEATl60OHDT+H/a2sZMEbj24sSYzWFSV3HZLf7Jjtk1pAYdQLA==", null, null, 1, false },
                    { new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2"), 0, null, 287.4194126883590000m, "300731c8-af3f-4876-9a30-14d78ed35f36", null, null, "Kevin", "Kevin", "Lang", false, null, "Kevin58", "AQAAAAEAACcQAAAAEJrYZ/LHrzUQ0A8Vhut7fHJfXsLYuJHiLbj5D0lWXaPBtQglBSJdH46CtigueBT0QA==", null, null, 1, false },
                    { new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf"), 0, null, 784.7743115890210000m, "812ffe3b-8570-4f1d-9437-e1d0e65db20a", null, null, "Carol", "Carol", "Predovic", false, null, "Carol_Predovic38", "AQAAAAEAACcQAAAAEBZHcUSuwfoNbljPpOVHOQwglhGcIv7aeaRiFoez0Z3tS/rsRKXlQ9gf66i4961MJQ==", null, null, 2, false },
                    { new Guid("71978c89-b953-4ec5-98a8-ab384223de1a"), 0, new DateTime(1974, 3, 17, 21, 55, 38, 288, DateTimeKind.Local).AddTicks(7958), 854.6005086320750000m, "aa7ecd10-9882-4cb2-b5e2-ac8e5ce89780", null, null, "Juan", "Juan", "Wintheiser", false, null, "Juan_Wintheiser98", "AQAAAAEAACcQAAAAELfxx+2/ksJa6SMTCWiEOE18NqnRyPmF0CLLI1fH39mLKGPlMIo2XylTKaEe2l9rYA==", null, null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7266e85e-c57f-45da-b706-f22c1c71235e"), 0, new DateTime(1957, 3, 26, 2, 57, 4, 469, DateTimeKind.Local).AddTicks(7170), 969.4065812923330000m, "6fe1c242-713d-43d3-b0d1-8fc7e87febcf", null, null, null, "Ed", "Rosenbaum", false, null, "Ed90", "AQAAAAEAACcQAAAAENc+6SYBmyFhzo8+xJfzlohp2qMaeawxnhBakb7bMYj/tf+sgkixq8L28SwUTP51vA==", null, null, 1, false },
                    { new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf"), 0, null, 815.7481755478380000m, "471cb91e-d955-4571-90ae-2fef2d4eed2f", null, null, null, "Sheila", "Lind", false, null, "Sheila_Lind", "AQAAAAEAACcQAAAAECD9g3ogzH7dfWqY0UzSmAXym7hkCq/WUEN5AP1bbGecG9QFUDzZ1a+lQKfPYBam0Q==", null, null, 2, false },
                    { new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb"), 0, new DateTime(1958, 11, 19, 7, 34, 10, 293, DateTimeKind.Local).AddTicks(77), 345.8583107993610000m, "ef29d8c3-4acc-4392-8257-aab3348a98b4", null, null, null, "Jordan", "Kovacek", false, null, "Jordan_Kovacek6", "AQAAAAEAACcQAAAAEIM1q4egTYSg0WiILDD18bH0GKWzoNZPZMgIyyUe9OYIuMDr9aX1iq8XdlfPrX242A==", null, null, 0, false },
                    { new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0"), 0, null, 722.7409109230430000m, "5e3e2efe-c876-4219-a38b-d50eb6503008", null, null, "Oliver", "Oliver", "Gislason", false, null, "Oliver74", "AQAAAAEAACcQAAAAEKuDUqgEH/7sLC2rI6VfxoB+joqgww78a2EwzBMkgMF5PykGhL+dZhkNpxEq9YCENw==", null, null, 0, false },
                    { new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f"), 0, new DateTime(1976, 9, 26, 23, 2, 9, 172, DateTimeKind.Local).AddTicks(676), 591.3232520142480000m, "f944ec52-8b21-4f5d-8c9f-42d71e5a389f", null, null, "Benny", "Benny", "Rowe", false, null, "Benny_Rowe94", "AQAAAAEAACcQAAAAEDQkraH99rPBwR2itp2glqDCsNgs3gLXQ/uSTtXRP6fgz944jLsitZgfjui28xk8fw==", null, null, 0, false },
                    { new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f"), 0, new DateTime(1966, 12, 9, 8, 0, 20, 546, DateTimeKind.Local).AddTicks(4671), 257.5546859186340000m, "ba08657a-e802-47ed-a634-562f8a20e7eb", null, null, "Silvia", "Silvia", "Johnston", false, null, "Silvia.Johnston", "AQAAAAEAACcQAAAAEJG+ar/NYuoKmKIWLpxLja1Y4Qy9+AE6c4PBiBVRuzrwLcknajAsR1/HiIsS6NGOiw==", null, null, 2, false },
                    { new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb"), 0, new DateTime(1979, 4, 12, 12, 54, 53, 2, DateTimeKind.Local).AddTicks(7342), 942.0189515195130000m, "00a3ff83-09be-4cb2-89a9-d20aaef72258", null, null, null, "Gary", "Wiza", false, null, "Gary_Wiza91", "AQAAAAEAACcQAAAAEPZ4qnIPXKJYhltPA46oT4LjI15bighC7wXa5zVVNLdgdmCxoMvQVS6BMwwD/XIFLQ==", null, null, 0, false },
                    { new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2"), 0, new DateTime(1963, 1, 1, 4, 28, 43, 259, DateTimeKind.Local).AddTicks(8759), 719.3911003935310000m, "b424e4ac-6906-4181-b9df-888c2403399f", null, null, null, "Dianna", "Wiegand", false, null, "Dianna98", "AQAAAAEAACcQAAAAEFHbOwokUQyUpK8qHT1ncLLFMsNAvNNwabPvcNV2ITqX+zs20Uoa5mL3j8CdXf4myg==", null, null, 1, false },
                    { new Guid("787d2d2c-d05b-4935-906f-090d713b622f"), 0, null, 968.3816005925820000m, "81213542-fde8-4238-86d5-ffffff40deb7", null, null, null, "Debra", "Nolan", false, null, "Debra_Nolan", "AQAAAAEAACcQAAAAEKRFMGMEcBBs0NHPeZcniS8jeOMY7vRNTdIWXQ1Lm5A2ZXiMO2hEHUB+cV2U3Z7iDw==", null, null, 0, false },
                    { new Guid("79086701-2604-4fd7-bb34-b77855e8579e"), 0, new DateTime(1958, 12, 21, 11, 14, 24, 754, DateTimeKind.Local).AddTicks(8363), 991.1248180126920000m, "a06dc8e2-77ba-48d9-b262-ad038bcdcdee", null, null, "Lisa", "Lisa", "Leannon", false, null, "Lisa.Leannon62", "AQAAAAEAACcQAAAAEDsgjwDHh2vStW30KvvsnPjvdy2SzUvmG47cw7pFNoY1glvmjUNjG/WT9//5A6Jbvw==", null, null, 1, false },
                    { new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58"), 0, null, 581.7532874177110000m, "163250c3-8b3b-4ee5-8b4b-65fb12a813cf", null, null, "Eula", "Eula", "Kohler", false, null, "Eula_Kohler31", "AQAAAAEAACcQAAAAECZ2EmSJTcF8BUwlxucMd95bRZgMRBeUd4KYKoXcuwHkLmnA+YAU1zlAcSaIMtfjlA==", null, null, 0, false },
                    { new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e"), 0, null, 43.64312971104340000m, "98411d68-7ee5-4e01-9732-28a199c71c2d", null, null, "Kimberly", "Kimberly", "Howe", false, null, "Kimberly_Howe", "AQAAAAEAACcQAAAAEKFdt+KnTPwO+Uns1kfdQHxuXO5vTqRZUlVHzIKdVwfhcUkxMDZF7a8ZpKgV6pWYyw==", null, null, 2, false },
                    { new Guid("7b8e2086-2aa9-4256-9444-793523c7a280"), 0, null, 995.7165322971130000m, "37509cce-b4e8-4e37-b08b-ee961931f419", null, null, "Tammy", "Tammy", "Reichel", false, null, "Tammy_Reichel", "AQAAAAEAACcQAAAAEA92nNZ7npUnCP46oS2rldGtyweBWbHi7SWMouDbx96mzadrGrqQtqpSZ+1qXCtPaA==", null, null, 1, false },
                    { new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5"), 0, new DateTime(1976, 10, 30, 17, 57, 5, 279, DateTimeKind.Local).AddTicks(5515), 16.22598735586370000m, "d65e2fca-f71b-4c0a-bdb8-758a314c11cb", null, null, null, "Damon", "Schamberger", false, null, "Damon59", "AQAAAAEAACcQAAAAEHsh+iEsZXUoSyvqan722WvJuklZt65HJ/HtISjofO2sd9c4yjzXXyIwpN3b9Uk9uQ==", null, null, 0, false },
                    { new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a"), 0, new DateTime(1990, 10, 14, 20, 23, 42, 930, DateTimeKind.Local).AddTicks(402), 642.2747367625210000m, "02c651f5-b0ea-46e4-9df7-a400a7362faf", null, null, "Nicholas", "Nicholas", "Little", false, null, "Nicholas_Little", "AQAAAAEAACcQAAAAEFzEE5/Ck7EPdg6jI3IiecJvofF5/J5bHCHayPfF96ohBMFxudbcOZWyzNFFUMetZw==", null, null, 1, false },
                    { new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588"), 0, null, 900.3915388754810000m, "e41c683a-9d9e-4909-8431-9f92b6b056e9", null, null, null, "Olga", "Stehr", false, null, "Olga67", "AQAAAAEAACcQAAAAEAjpGyJN+mAfd2F/XI28i9suN3tDMocIH9n/uGwyg/GU86/yjKKTI938LmPmQtWq2w==", null, null, 1, false },
                    { new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de"), 0, null, 586.7896682219270000m, "f11ec419-3936-410f-bc82-70d04885cb8c", null, null, "Eduardo", "Eduardo", "Kassulke", false, null, "Eduardo57", "AQAAAAEAACcQAAAAELDkGB1qGWhM5KnlQPl4b4LERceaDCRYhe4yU7rpRIRXqzHSch3HAjbytwTy+g/3zg==", null, null, 1, false },
                    { new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53"), 0, null, 599.803557892160000m, "5ddbb17d-216e-429c-88eb-c11e9fbb984b", null, null, "Grace", "Grace", "Rippin", false, null, "Grace.Rippin", "AQAAAAEAACcQAAAAECySmyDoxxknh2dhhWXNXIZwhTCK0NZMgwsgu0Y/SqWHEdoKXeQ+NOzxSQmgfDfCZA==", null, null, 0, false },
                    { new Guid("80527681-e153-441a-b963-5dad43aab962"), 0, new DateTime(1951, 9, 6, 23, 47, 31, 835, DateTimeKind.Local).AddTicks(2262), 554.4567387405550000m, "0610c1fa-b9e3-4845-9899-7016cd436cb0", null, null, null, "Dan", "Schulist", false, null, "Dan.Schulist84", "AQAAAAEAACcQAAAAEIJtux9EPztYPFNCKVE+ZuWK7jYiK02Mj2QvktdqaMbvDTrxygiTCqbgu2HRT6Bxag==", null, null, 0, false },
                    { new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105"), 0, null, 742.1085497175720000m, "914f601c-509e-4ed0-ae21-534169f29deb", null, null, null, "Frank", "Buckridge", false, null, "Frank73", "AQAAAAEAACcQAAAAEMHCodyTpPiWov0iFquUsHNOiqNF668zSibsSV3k4b1XYgIGMv/wt/BZzU842NAz2w==", null, null, 2, false },
                    { new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955"), 0, new DateTime(1974, 4, 14, 23, 44, 34, 282, DateTimeKind.Local).AddTicks(4297), 693.5066150814520000m, "3920d76f-5bbd-442c-95e5-4cbd8d6563a6", null, null, null, "Toni", "Lueilwitz", false, null, "Toni_Lueilwitz43", "AQAAAAEAACcQAAAAEAWitZLG2HZY/RTA779DU+hqpABD3j7lWqBPrXKP0W4KUuI8IfHqbSKIm+scEqRIvQ==", null, null, 0, false },
                    { new Guid("82d8841b-b98c-463c-96d0-9378cf908740"), 0, null, 110.7321753663240000m, "3539f119-45ce-439c-aba8-b2f203fbc96c", null, null, "Marcus", "Marcus", "Conroy", false, null, "Marcus87", "AQAAAAEAACcQAAAAEBoGZoA+UQPwJs6ZpJ3LzrDWhcOqImq2vW2tIm42w+AtUwwKg0bhVSzCw0JaPEcDhg==", null, null, 2, false },
                    { new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd"), 0, null, 744.3722249894530000m, "4b90a282-1cd5-41e6-925c-eec68b2ae459", null, null, null, "Susie", "Moen", false, null, "Susie6", "AQAAAAEAACcQAAAAEHb4RGIjWmKmKKkJrWfZjndApedslC5P4EJY5vWNdcO568d3nptK7mdZonYK4m5TXw==", null, null, 2, false },
                    { new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf"), 0, new DateTime(1985, 10, 2, 8, 39, 46, 562, DateTimeKind.Local).AddTicks(8993), 512.5502472053920000m, "fe521638-f306-4f06-8c4d-a9667a4828fc", null, null, "Danielle", "Danielle", "Muller", false, null, "Danielle.Muller61", "AQAAAAEAACcQAAAAEOiovfhLXIqa3YkKHr8tRcPVRI/Lu0VfWSjZLOe17kHsR5qFQiKKCROYxHXkV+roZQ==", null, null, 0, false },
                    { new Guid("85178881-d883-4586-bf89-10a49abb8b16"), 0, null, 496.87988896330000m, "e811eaf8-1871-4c86-b4d7-c23c4f43d1c6", null, null, "Edwin", "Edwin", "Bogisich", false, null, "Edwin.Bogisich98", "AQAAAAEAACcQAAAAEHxgixCwBps6/9jnduJ2eAQTzOSTF6croUZF83TWqGBofw63RW8eSk6tn8LJSvWcBg==", null, null, 1, false },
                    { new Guid("8576464a-f366-4076-97bd-00c2481b9a38"), 0, new DateTime(1942, 10, 13, 14, 48, 11, 989, DateTimeKind.Local).AddTicks(8519), 67.10749383433180000m, "d63e90d9-c633-446f-becb-8da34b3502ee", null, null, "Megan", "Megan", "Keebler", false, null, "Megan.Keebler43", "AQAAAAEAACcQAAAAEPULWQX4LsmrcLAu1jGwbnrbaA6m9+ULHzpK3D3or8yld8r2Qw7QK3fuqpQkNe4cew==", null, null, 2, false },
                    { new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968"), 0, new DateTime(1936, 6, 16, 5, 44, 40, 210, DateTimeKind.Local).AddTicks(7545), 681.1473787239650000m, "67aaae6e-d00e-4e06-a9bc-b468ca552303", null, null, "Norman", "Norman", "Conn", false, null, "Norman.Conn97", "AQAAAAEAACcQAAAAEDbKNHh29XTNezrd1ZNGMelp1M9rlRR9hnPJcMOfeIli7w8Cx6WF6nRngJX+KwHRPA==", null, null, 2, false },
                    { new Guid("87884942-9d13-450f-b485-62321f667eab"), 0, new DateTime(1963, 12, 30, 9, 13, 2, 633, DateTimeKind.Local).AddTicks(3727), 873.6563169345250000m, "783eaaca-2bd4-475d-afd2-e8c94c1361b6", null, null, "Eleanor", "Eleanor", "Haag", false, null, "Eleanor51", "AQAAAAEAACcQAAAAEIPc3yGt4ol+0yvSmWriRFq4Jyywf+k49mbZd7sXAXj17YQgK0ZK1TlEndsdkHv9yg==", null, null, 2, false },
                    { new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4"), 0, new DateTime(1963, 4, 13, 21, 9, 9, 363, DateTimeKind.Local).AddTicks(6567), 163.8148640957330000m, "bdebf491-3786-44e6-acc3-6737d41a8350", null, null, null, "Homer", "Herzog", false, null, "Homer.Herzog70", "AQAAAAEAACcQAAAAEEfeQnYAfPf/c1ebYX5TCHXQip6vaWTKVpwpHq3tZNtjYr9e4z3p6fu4lSN1iJg40A==", null, null, 1, false },
                    { new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf"), 0, null, 744.423288458020000m, "b98249db-8256-4283-b3dc-2645f9f3a275", null, null, null, "Jacob", "Walker", false, null, "Jacob_Walker", "AQAAAAEAACcQAAAAEN67svLr/4n24KluzQ0JvbtipSXUoqztDPxBcgo/m4XphNxcYRW8l8aZWOcGNPrtWQ==", null, null, 0, false },
                    { new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15"), 0, null, 845.2706119654310000m, "5684f16d-c895-44ee-ad2a-212bca26b6ee", null, null, "Theresa", "Theresa", "Roob", false, null, "Theresa91", "AQAAAAEAACcQAAAAEJGZMxGXQJUr62OcVZSPkF+VtMy7dnuoXE8KBDv0oFa7HKcLXT9TF2Kl60SHAE+rkg==", null, null, 1, false },
                    { new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3"), 0, null, 907.4108563694810000m, "6ee31ce4-7e83-4e22-b9c4-6bc9f554cb30", null, null, null, "Derrick", "Sanford", false, null, "Derrick51", "AQAAAAEAACcQAAAAEDsDsG5Q4SM+SDRZbJez6x2Li7s/RlVfo/dZT7Yvo95VUzrIi8Z3c1FBt+ksRG8STw==", null, null, 1, false },
                    { new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f"), 0, new DateTime(1982, 5, 17, 11, 8, 0, 158, DateTimeKind.Local).AddTicks(981), 742.7293096536120000m, "3aaa7c4b-0420-46cf-a542-693918533d63", null, null, null, "Fredrick", "Sauer", false, null, "Fredrick.Sauer53", "AQAAAAEAACcQAAAAEAM1/Q+HxTCK5PE8nLRIMAvxSi/uxwXAlD1QBGPX/CQa2SAvnS3OmG2IPNBHVCY9ew==", null, null, 2, false },
                    { new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16"), 0, new DateTime(1942, 9, 2, 3, 14, 58, 5, DateTimeKind.Local).AddTicks(6540), 591.7234008525750000m, "944ce979-cff0-413d-a4fe-15fa1d04900c", null, null, "Harold", "Harold", "Steuber", false, null, "Harold19", "AQAAAAEAACcQAAAAEOJwsehTZAeZ9d0c5qJtpwIB9f/ZnyQ13pUBGaqEoRQkFLcmGfvsI4zBAYLmp0xUvw==", null, null, 1, false },
                    { new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321"), 0, null, 609.4356811915580000m, "ef8e8fbe-5956-481c-a6af-ab01221807ed", null, null, "Mabel", "Mabel", "Kunde", false, null, "Mabel_Kunde", "AQAAAAEAACcQAAAAEPMgq+K48IsnM+HOjmDpsK2wqaxuxuKmJr0tKvr5mZRdus7zRxPOmGTBsuPnolZl/Q==", null, null, 0, false },
                    { new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50"), 0, new DateTime(1998, 4, 1, 9, 34, 46, 841, DateTimeKind.Local).AddTicks(7854), 756.6704359769740000m, "5cbeb3e8-693a-41bd-9d5f-d70cb2c29675", null, null, null, "Donna", "Rice", false, null, "Donna12", "AQAAAAEAACcQAAAAEC+/Gx2eiN1JYa9ZgNxqNBXrNBo2ABT5MXvYdHzowaL7vR9MBREOJEJPpmbe83tXxg==", null, null, 1, false },
                    { new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948"), 0, new DateTime(1981, 2, 23, 13, 26, 55, 965, DateTimeKind.Local).AddTicks(5051), 729.200211619270000m, "db52c24c-1e02-42ac-a2e9-423670604799", null, null, "Teri", "Teri", "Walsh", false, null, "Teri_Walsh", "AQAAAAEAACcQAAAAEJNM0Zo2dwGIUkfWGMK4ZtR8kgpBj79XsV1/P1K6D2ZkiF2l19FO8E8T6obMPlQJaQ==", null, null, 0, false },
                    { new Guid("963654b6-a05e-4be7-b120-45295941d954"), 0, null, 762.3391284235980000m, "5f8e9286-a3c2-43b4-8471-b1e3a6c8ab9d", null, null, "Leona", "Leona", "Ruecker", false, null, "Leona.Ruecker", "AQAAAAEAACcQAAAAEDd3g2wLKASVDRPSulAjA6tzbWCPNeq9JqelV8tlwXlzNR8VpzHHGFzNnKJ6QArayA==", null, null, 0, false },
                    { new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc"), 0, null, 679.3369491759260000m, "fd9b0ba8-742f-495d-8117-13241b6f5c1e", null, null, null, "Byron", "Mertz", false, null, "Byron_Mertz31", "AQAAAAEAACcQAAAAEA9KU+9fRwQMen1fMAO03jFtF2T1qtB2PWgUdJJu8xtj6lMFhWcz6SeAjWym35mV8w==", null, null, 1, false },
                    { new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4"), 0, new DateTime(1971, 9, 12, 12, 40, 37, 481, DateTimeKind.Local).AddTicks(6469), 69.8145797538480000m, "40236951-d2ba-4bbe-b129-e0513559987b", null, null, null, "Gene", "Koepp", false, null, "Gene.Koepp25", "AQAAAAEAACcQAAAAEFwWn/4fUuQV+pyy1UWRj6My6WiE9Q9KzEI5ChPGS8RjM0OYK0seeURfW2aL0ECiNg==", null, null, 2, false },
                    { new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd"), 0, null, 824.2242975913980000m, "5dc6875a-9be5-48ad-b1f4-daab2919df66", null, null, "Lester", "Lester", "Kuphal", false, null, "Lester63", "AQAAAAEAACcQAAAAEMd1qYAgm/40uB1ZBiuF8fkCKRoYAqf05Q0c53H8zyrpSLPwSD7UFoqwzwvz4yDLuQ==", null, null, 2, false },
                    { new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a"), 0, null, 99.53637989670080000m, "ff61271b-f411-4462-b98f-e2fe422bcae2", null, null, "Muriel", "Muriel", "Spinka", false, null, "Muriel.Spinka21", "AQAAAAEAACcQAAAAEJnH2iZJkgGWW4OzeZRazgiKPKOwyZy5UZMiChiVuBgfXZozT6v+LGeuZb+g822jhw==", null, null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("9ace24ed-f865-4310-9613-b304be005b00"), 0, new DateTime(1939, 5, 8, 23, 53, 36, 681, DateTimeKind.Local).AddTicks(4852), 825.7154794164270000m, "fde9fdaa-fdf5-4f4c-9c0a-4215a457856f", null, null, null, "Judith", "Cole", false, null, "Judith28", "AQAAAAEAACcQAAAAEBS8KdABZAVQS2RQNAAXaNXhPGEDjmaGkhihewkVMwVZL9R6/ZfL/0lU0gOicd6Ifw==", null, null, 0, false },
                    { new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0"), 0, null, 546.1856849075790000m, "d63b5e6d-6d63-4cd8-bbfb-1964457bb5f2", null, null, "Anna", "Anna", "Abernathy", false, null, "Anna.Abernathy", "AQAAAAEAACcQAAAAEGj/qf2+53EdoBddR368sQKfPoAAC6tEc+/PnQgos69RZStjYV3+9EHNT7O7B5t0Gw==", null, null, 0, false },
                    { new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5"), 0, new DateTime(1948, 10, 17, 6, 25, 57, 830, DateTimeKind.Local).AddTicks(5741), 912.3567837620750000m, "ebee0692-49b6-48a0-b49b-923853892e2c", null, null, null, "Walter", "Murphy", false, null, "Walter.Murphy35", "AQAAAAEAACcQAAAAEHulHXVw6k4G0wSWGVDzSygP4sFXwlWPkGtnU8pimVEemE8vJXGTTD+SyvAZVwL2FQ==", null, null, 1, false },
                    { new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696"), 0, new DateTime(1945, 4, 9, 3, 33, 44, 876, DateTimeKind.Local).AddTicks(9226), 457.8518533665510000m, "7c99947f-719a-4892-96ab-e5f68e53648c", null, null, "Vera", "Vera", "Jones", false, null, "Vera_Jones", "AQAAAAEAACcQAAAAEJ3LymaCR/SBXlBRe9EzZvqGXOjZiZL+lA48mBFp8EA+BQlKCH8zHYU/JyNj0090Hg==", null, null, 2, false },
                    { new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10"), 0, new DateTime(1974, 4, 10, 23, 48, 20, 380, DateTimeKind.Local).AddTicks(983), 463.5965158952210000m, "c2a96e16-3432-4156-97bc-d7c68c1bcd01", null, null, "Jan", "Jan", "Beahan", false, null, "Jan.Beahan7", "AQAAAAEAACcQAAAAECJaarak36QjtEeEBxX2HILmv8ORzbbG7kOYV0T7E0KK/cB775UxKq5Of/usURtpFw==", null, null, 1, false },
                    { new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565"), 0, new DateTime(1936, 7, 2, 15, 3, 22, 653, DateTimeKind.Local).AddTicks(5131), 903.9432303878110000m, "550d4947-8fad-4e61-97f4-1bd1d14cbe64", null, null, "Rudolph", "Rudolph", "Buckridge", false, null, "Rudolph55", "AQAAAAEAACcQAAAAEM3zw4yZ+QCIQ+qdDFeEuGLexzfHa8W2MNNe9W7rWPFEM4cfkxDXUho73KenAMSPhw==", null, null, 0, false },
                    { new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9"), 0, new DateTime(1999, 12, 5, 5, 34, 37, 529, DateTimeKind.Local).AddTicks(7603), 413.9544559300460000m, "21051c8c-d6f4-44cc-b6de-6df2e0553f33", null, null, null, "Joel", "Robel", false, null, "Joel.Robel", "AQAAAAEAACcQAAAAEAer8LVphjHiAe99xOoiyEQfPj7xWvY8O3ugcjmrtEgu/8r+vPL8Jf58KwFnBiJadA==", null, null, 2, false },
                    { new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276"), 0, new DateTime(1943, 6, 17, 11, 21, 22, 547, DateTimeKind.Local).AddTicks(514), 402.8564729377080000m, "19b1813d-ae29-4071-b84e-d36a11cbf583", null, null, null, "Andres", "Romaguera", false, null, "Andres.Romaguera4", "AQAAAAEAACcQAAAAENTh7DDff6elwa7oEffPbOPxN5DQh52VrpLQwLywv9X157C+AZtGXZ3VUi8EBmx/Pg==", null, null, 1, false },
                    { new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370"), 0, new DateTime(1993, 5, 13, 17, 30, 54, 389, DateTimeKind.Local).AddTicks(4170), 778.2842531156560000m, "b14edc8d-4849-4283-a9d4-66601c498ebf", null, null, null, "Anna", "McCullough", false, null, "Anna90", "AQAAAAEAACcQAAAAEHiYVum8cv9cCXSg365TqD0KZdwFKmg7eMKUz+zhWSG7/yKHzLWDWm7wpN4sjmyBVw==", null, null, 1, false },
                    { new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014"), 0, null, 135.5912787916910000m, "3b7ba7d9-51f5-478a-8224-4c9661fd5b33", null, null, "Joan", "Joan", "Denesik", false, null, "Joan.Denesik", "AQAAAAEAACcQAAAAEBYdWzgmpAN8osBPXDuI6ZTsLh0BasbVJiv1FP+3LTgqumDYWpwpge62OZZw00N+ZQ==", null, null, 1, false },
                    { new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9"), 0, null, 450.3998942165880000m, "8b9831ef-ef4b-4fe4-a5ca-19712dee3867", null, null, null, "Myra", "Howe", false, null, "Myra73", "AQAAAAEAACcQAAAAEK2OFfoi6BKxUsoitiX5zMiZCdVUBqoIyryMN54MldSdCjRLVZCqpf/n5Z0MVgSesw==", null, null, 1, false },
                    { new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d"), 0, new DateTime(1996, 2, 5, 13, 42, 24, 452, DateTimeKind.Local).AddTicks(4474), 228.6705073825310000m, "57f3f622-b72e-42be-a3f9-4ff5caf10a40", null, null, "Misty", "Misty", "Connelly", false, null, "Misty.Connelly", "AQAAAAEAACcQAAAAEO7N4aqzgmQtMFt8jDJj5DDB6O4DFzPzigGEEfMRaxDlGOVqC+qHD2MfEAL4Wvtsyw==", null, null, 2, false },
                    { new Guid("a0995ae3-517f-4476-bad0-18fca309cda5"), 0, null, 983.7282885007150000m, "77a1f17e-9865-471b-8a19-6c9c2dd22dde", null, null, null, "Jasmine", "Welch", false, null, "Jasmine_Welch21", "AQAAAAEAACcQAAAAEMC4HR4uiNIvn/7iHbb+X20xFPkW6B7fh+o59BhPHN24Zg9n+XwQSVj6K2I+OPgkXQ==", null, null, 1, false },
                    { new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2"), 0, new DateTime(1963, 3, 31, 1, 39, 0, 255, DateTimeKind.Local).AddTicks(7912), 954.9368209064910000m, "9cb78b7b-dbc8-4268-bd6e-6b5b0ee7a724", null, null, null, "Timmy", "Wyman", false, null, "Timmy_Wyman", "AQAAAAEAACcQAAAAEPNRtK5hb/JkEfeFnhK0531l505M+pu9qEQ+CsEGf1XZpsAxzKeTYn9FoU7KsErsXw==", null, null, 0, false },
                    { new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216"), 0, new DateTime(2006, 7, 28, 16, 17, 9, 922, DateTimeKind.Local).AddTicks(4760), 711.5180961360180000m, "8d806053-acec-47e0-a287-bf9e026ef0f6", null, null, null, "Marta", "Gottlieb", false, null, "Marta97", "AQAAAAEAACcQAAAAEPhMQkNzFlF0m4BQffnmHKfIy50cCa35tYKrsfzHp5vfr6XS/i3JpRwHTP2enlC+AQ==", null, null, 2, false },
                    { new Guid("a40e2013-0615-4cf6-82e5-5e136f732285"), 0, null, 40.82264128426740000m, "d4e759cf-d50c-49dd-abe0-67a1db294e51", null, null, "Al", "Al", "Cormier", false, null, "Al91", "AQAAAAEAACcQAAAAECesqrqwBTzWyKLIHt/YQhlXTzrO+qe5wBykYcmZlLio30KRv1zTUeYHgx99+JGelg==", null, null, 2, false },
                    { new Guid("a42b469c-fec8-4056-a4de-926b01b7f202"), 0, new DateTime(1971, 6, 3, 14, 35, 58, 993, DateTimeKind.Local).AddTicks(4507), 881.6573495330830000m, "2ecc971a-c865-4445-9a77-971b69d10542", null, null, "Alex", "Alex", "Crooks", false, null, "Alex_Crooks", "AQAAAAEAACcQAAAAEK8OE/otlmrBVhcUTy3NEsc1C+YsX+ckv00Dig8pxBxkCIub/Ewlyw2eltGdnExBYQ==", null, null, 1, false },
                    { new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), 0, new DateTime(1944, 11, 6, 13, 22, 12, 780, DateTimeKind.Local).AddTicks(5527), 941.8034249939130000m, "3a61b8d7-569a-4ca0-ac89-1c5ff6076085", null, null, null, "Ted", "Koss", false, null, "Ted.Koss34", "AQAAAAEAACcQAAAAEE+8PkCba88y18Lb4o/FvK9MnjmjRTXCmHU7qiMRdcVKE24dSdWA0HMJjOZdemEi+g==", null, null, 1, false },
                    { new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae"), 0, null, 902.4412705635450000m, "fcb1a99e-86ec-4db4-9f0d-4a28b7e2c4dd", null, null, "Aaron", "Aaron", "Shields", false, null, "Aaron38", "AQAAAAEAACcQAAAAEINaLlfb+e0fFW7qVnc/cABXXKgfZBBc5d75t6E+dEQAX6YZgiCtP/NA3GPC+DhDyA==", null, null, 1, false },
                    { new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce"), 0, null, 749.731248627560000m, "64ac2b72-cd67-4b01-8f56-70b7b2fd93be", null, null, null, "Angel", "Hirthe", false, null, "Angel93", "AQAAAAEAACcQAAAAEIBw/5PL7HAU8SvNBYdL1IeJvODb1cr6Q9hergv24PY+kpDjo23p321O1VNEgLVPVg==", null, null, 0, false },
                    { new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40"), 0, new DateTime(1980, 10, 8, 23, 54, 8, 137, DateTimeKind.Local).AddTicks(2873), 401.7707222989520000m, "d2f0db9a-66eb-4840-b3d4-fb9cf1e6c27c", null, null, "Scott", "Scott", "Brekke", false, null, "Scott32", "AQAAAAEAACcQAAAAEBmo7xywmOlz8CkPenhE2gJwIOqJGIPErxl7kX12rxcr69Iiv4oURbyjvtTO24pt8Q==", null, null, 1, false },
                    { new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef"), 0, null, 957.3352811228790000m, "cff71dfc-0bcc-4459-9111-e744b70890b8", null, null, null, "Matthew", "Lesch", false, null, "Matthew_Lesch", "AQAAAAEAACcQAAAAEHPiiQeh40gwEbjt6PQu5UAyZ4W4ps0KWRKf8d9TWMyGNwqhUPoalgMrsR8v52zFvA==", null, null, 2, false },
                    { new Guid("a8115124-4280-4a52-8af7-cb635f456958"), 0, new DateTime(1989, 5, 5, 23, 1, 29, 919, DateTimeKind.Local).AddTicks(868), 633.4414582389850000m, "97fd8241-16dc-42c6-9958-9b02694893e1", null, null, null, "Santiago", "Hirthe", false, null, "Santiago_Hirthe57", "AQAAAAEAACcQAAAAEDXq4WmfLN2S5t+1llP8Z7nkyQ0cK6NLvzDc8E/frhm6r7thez2oMZHKhz6w9l4tEQ==", null, null, 1, false },
                    { new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259"), 0, null, 800.7963984124740000m, "ce055c9a-e3cd-47b4-a5bf-fde80dbc7261", null, null, null, "Eric", "Hane", false, null, "Eric4", "AQAAAAEAACcQAAAAEJYCU/gpUcEMJhlTAdLcpZY4os03wlXqmub6KwIj5ISeG963pXe/jb7SwReGqpUqng==", null, null, 2, false },
                    { new Guid("a836bc35-12f7-485d-861b-ad1645878c24"), 0, new DateTime(1953, 8, 28, 2, 45, 4, 571, DateTimeKind.Local).AddTicks(4747), 430.3960603578920000m, "4277d1dd-d0bd-4134-9ad5-4029a93b4d5e", null, null, "Vernon", "Vernon", "Bernier", false, null, "Vernon_Bernier", "AQAAAAEAACcQAAAAEHDudnSzpYJQsv+osaY/8WjCw1cFpzb5KBitrV08CCCNTVlpEZsZ/zbtGX8X19Cfhw==", null, null, 1, false },
                    { new Guid("a8eb141c-5178-4baa-b599-679287b17c92"), 0, new DateTime(1998, 1, 30, 9, 18, 31, 581, DateTimeKind.Local).AddTicks(2201), 371.3966683570260000m, "611b2485-a11d-4438-8bae-727d7b720fda", null, null, null, "Bradley", "Fritsch", false, null, "Bradley_Fritsch", "AQAAAAEAACcQAAAAECcAc9nJkNx79yh0pAFt65X7+BOvrFu2PutPE7YNcH17LGl2FiXBS9GA5oB2GDJ1UQ==", null, null, 0, false },
                    { new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc"), 0, new DateTime(1933, 2, 20, 13, 44, 20, 602, DateTimeKind.Local).AddTicks(2717), 694.5154633669930000m, "2cfd005d-7236-493a-9cc2-d21b4b5e7277", null, null, "Rudy", "Rudy", "White", false, null, "Rudy91", "AQAAAAEAACcQAAAAEDTFJY62mNRiEbWvHCLFkSIeAWLCY7iaP9ChoSt7MMw4GfSlkIgAGmHtocaLDB98Zw==", null, null, 1, false },
                    { new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615"), 0, null, 616.4195468895390000m, "1e3d7bfb-27c4-46ca-8c03-29a91d64f1ea", null, null, null, "Rachel", "Kerluke", false, null, "Rachel15", "AQAAAAEAACcQAAAAEHSJ2e4CX12L3LXkSzeJMn5m2Wtd4RP3cTY5loOQGE5jcUmug9svrIDGlMp7rqXqmA==", null, null, 1, false },
                    { new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f"), 0, null, 999.414006964030000m, "227e4d98-b5f1-4940-8424-81c21cfefe88", null, null, "Shawna", "Shawna", "Ankunding", false, null, "Shawna_Ankunding", "AQAAAAEAACcQAAAAEG1QTRjRbEp5yQJ5VP0AgcjSbtYfPU+l9xJxqDpA/r5QuX1US7+izmEdrMKjoZLxbw==", null, null, 0, false },
                    { new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693"), 0, null, 75.65097066196140000m, "158f58c3-b732-419f-a867-26944dc581e2", null, null, "Madeline", "Madeline", "Kiehn", false, null, "Madeline_Kiehn", "AQAAAAEAACcQAAAAEPmRqLlM5FzonUzI4lLeNa0BbOMPkynx3zNwoo6ktAKaPbV0FjnAgoHvZpS568l0gQ==", null, null, 1, false },
                    { new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc"), 0, new DateTime(1975, 4, 23, 5, 20, 9, 161, DateTimeKind.Local).AddTicks(3527), 762.6726872999170000m, "36eef866-a81f-4901-aaa0-8ca6dd329b75", null, null, "Neal", "Neal", "Brakus", false, null, "Neal.Brakus20", "AQAAAAEAACcQAAAAEOGmSPrbuDJwB53AeXdP3nEbt9bPO3zTEOK9IqIMM5+n/U3/eZ6WwlbUNeZZXMg8zQ==", null, null, 2, false },
                    { new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9"), 0, new DateTime(2000, 2, 22, 14, 37, 47, 519, DateTimeKind.Local).AddTicks(2587), 368.8546422775030000m, "0a75c39b-3e1d-4d65-8788-10e4b0994864", null, null, null, "Sherry", "Fadel", false, null, "Sherry45", "AQAAAAEAACcQAAAAEBx9b2Y8hPoIz4pK3xNZasMr/clddpFle4IUgpJmtrO/kQ0p4MTv/uA3AXKozZpKIw==", null, null, 2, false },
                    { new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c"), 0, null, 594.8342563712190000m, "39b5a671-359f-4da1-8acd-5b881d04c1f8", null, null, "Julius", "Julius", "Bogan", false, null, "Julius79", "AQAAAAEAACcQAAAAECWxS1Fg0gIyCAx2GyeFCV6C/yWIwScPxmFAcaIDmhJcO1UNebEpUafMRrh8L/YJzg==", null, null, 1, false },
                    { new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0"), 0, new DateTime(1962, 4, 10, 9, 51, 9, 531, DateTimeKind.Local).AddTicks(4084), 655.8800976156470000m, "65ac2fd9-1378-4a3b-96b4-6c45faa1f183", null, null, null, "Louise", "Grady", false, null, "Louise_Grady", "AQAAAAEAACcQAAAAEF5hOiAaMaKshNMxd0psw/W2MEWZFuR/dYcQl8Y2mZBrR/PjMc7Jfnd/n2vDrAhfVg==", null, null, 0, false },
                    { new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794"), 0, new DateTime(1943, 8, 1, 7, 26, 30, 403, DateTimeKind.Local).AddTicks(4183), 914.6631587400590000m, "f357c2e6-cd40-46fd-bed1-0d214008abcd", null, null, "Fredrick", "Fredrick", "Buckridge", false, null, "Fredrick36", "AQAAAAEAACcQAAAAEGr6YOwKAPRdNQWogPm65SFnZmJku2z7mKbQ4BfJF36VgHRa6hFos+p/jpyQ1eCzzQ==", null, null, 2, false },
                    { new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271"), 0, null, 863.3622159605730000m, "66d211b6-d709-404b-a9be-d681b86fcc1f", null, null, null, "Sophie", "Runolfsson", false, null, "Sophie58", "AQAAAAEAACcQAAAAEMjfTwi7ngCUWzJult90skd615rSWzurLC28j5VIR/namKt0FXTme00f0h9hTLh6wQ==", null, null, 1, false },
                    { new Guid("b552dea4-6df2-477a-870b-1317247a51c0"), 0, new DateTime(2004, 9, 26, 9, 43, 13, 697, DateTimeKind.Local).AddTicks(4309), 873.2026264322570000m, "2d29f7cd-416e-40e8-9eff-34ae2f0c2e55", null, null, null, "Dianne", "Dach", false, null, "Dianne.Dach71", "AQAAAAEAACcQAAAAEPSmLIKVB4cefCfsJT9b8kjTdw+ero/5iGPPP6MEwxGycWR/xR4xgmSejhbIa/TrjA==", null, null, 0, false },
                    { new Guid("b74d612a-560a-493f-9b9a-e7d76b857600"), 0, new DateTime(1952, 7, 9, 14, 42, 53, 593, DateTimeKind.Local).AddTicks(8043), 144.3193700501470000m, "f616765f-870c-45a7-b853-b65df1d5c399", null, null, "Cody", "Cody", "Daniel", false, null, "Cody_Daniel", "AQAAAAEAACcQAAAAEI8nf0pcZ4efxk3Y8FuCg+ct5tM3aaZNflL1JdP8sicxIFlpuZwmFtgM8oBGZ8Jx2A==", null, null, 2, false },
                    { new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2"), 0, new DateTime(1998, 12, 1, 16, 9, 51, 665, DateTimeKind.Local).AddTicks(6787), 53.37242248922550000m, "b48b9c35-e0db-4ad8-acd4-171167d7ba3a", null, null, "Todd", "Todd", "Mertz", false, null, "Todd.Mertz91", "AQAAAAEAACcQAAAAEFC5w4J4LCJGFluwmkt8i2r/nAH0G1QRvLf7iJO9PiLnYqoB5wAZhx8LXKSwAQtXuA==", null, null, 1, false },
                    { new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb"), 0, null, 796.7312320989280000m, "c9c86ec0-0c29-4681-bbe4-ac2261e0861d", null, null, "Jeremiah", "Jeremiah", "Ullrich", false, null, "Jeremiah82", "AQAAAAEAACcQAAAAEBxIKYF+No/9c6gaRhq8GIUUUdYPDpTcUfSb/fz2F8ksOWecq92IkT7g5ddpyC72Xg==", null, null, 2, false },
                    { new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6"), 0, new DateTime(1937, 4, 13, 10, 45, 13, 371, DateTimeKind.Local).AddTicks(3501), 2.390860203879130000m, "6ecfa792-f274-41ae-a9f3-ad75679d081f", null, null, null, "Joan", "Ryan", false, null, "Joan.Ryan", "AQAAAAEAACcQAAAAEAaUuxxMrIBnYGkuvA2P7eH+tAMfo0cwmZjv9YjaQYw+M40IeBLSX1fPALa09wDJJQ==", null, null, 0, false },
                    { new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0"), 0, null, 690.1851453072940000m, "aca5f222-4fce-4d39-bc43-a8d038242a10", null, null, null, "Nathaniel", "Greenfelder", false, null, "Nathaniel_Greenfelder", "AQAAAAEAACcQAAAAEOFdJxjHYVfokehLepFZy4u0qk5Zc3i0urZbYM42AmKcwONJrdfoDXiLxUAG+dDM8A==", null, null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2"), 0, null, 156.935792180330000m, "511c2781-9064-402d-8a6c-ade64d46dc5f", null, null, "Nancy", "Nancy", "Kautzer", false, null, "Nancy.Kautzer", "AQAAAAEAACcQAAAAEMI3mCY4iRIxBC2f3dyoUEl+sM0KVX+vQg/jrTriZuemMsBPhWrOVuuDope4lrvFhQ==", null, null, 2, false },
                    { new Guid("bea80970-74bf-4539-a300-cbbac8625744"), 0, null, 12.75992748621770000m, "fe378490-57fa-4f78-ac0e-8ae1fc5e6cf8", null, null, null, "Jenny", "Considine", false, null, "Jenny.Considine", "AQAAAAEAACcQAAAAEE1TOU7PkKOxTk9Zp7fWXUaqCVv949WDH5wVeMWkT2dwTcFx7YhSyf8QI5UI/cWS9Q==", null, null, 2, false },
                    { new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25"), 0, new DateTime(1992, 5, 20, 21, 27, 31, 867, DateTimeKind.Local).AddTicks(4316), 961.6200700129020000m, "ae9b1160-795c-41b8-a062-4268f9c446ca", null, null, "Kerry", "Kerry", "O'Reilly", false, null, "Kerry.OReilly66", "AQAAAAEAACcQAAAAEHWr47Jzoxj67o3I6ELFUjebA7WU5eozNsaf85mxGIPK2xs9h4CRXitpcAGvDvHH6w==", null, null, 2, false },
                    { new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9"), 0, null, 398.6338798294880000m, "038cb023-f78b-4daf-acee-93b9875af905", null, null, null, "Eunice", "Ruecker", false, null, "Eunice85", "AQAAAAEAACcQAAAAEFrUwCePm7fomkoJpOtRdHXTOtzvDslvu7JUn3BHUZyC3GJvaVG22EhX+9yqhQNdTA==", null, null, 0, false },
                    { new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7"), 0, new DateTime(2005, 4, 12, 20, 42, 44, 989, DateTimeKind.Local).AddTicks(3927), 791.0963496303930000m, "91353bd9-5743-4479-8312-116fbbf5baf5", null, null, null, "Essie", "Beatty", false, null, "Essie_Beatty63", "AQAAAAEAACcQAAAAEBj9GDKBoqttj/OiBQA536R7IdPNzoU/N/eVjihrAAXWPbe13O1sLo78sy4T4gPeqg==", null, null, 0, false },
                    { new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed"), 0, new DateTime(1928, 5, 1, 5, 43, 46, 728, DateTimeKind.Local).AddTicks(4140), 911.2074301841360000m, "d6f54d93-17ac-44b6-a081-425b459731d0", null, null, null, "Willie", "Douglas", false, null, "Willie_Douglas", "AQAAAAEAACcQAAAAENTc6DnhVoUk4hZ08s4uszFGXoM2nRDrVpaVM5bNhWd4tOCayTYBhi5hQ/24g21K0Q==", null, null, 2, false },
                    { new Guid("c187c610-03e7-4305-96e2-96f776a463e0"), 0, new DateTime(1962, 10, 15, 6, 49, 25, 212, DateTimeKind.Local).AddTicks(6486), 965.7659001898420000m, "a652d160-d836-400c-a5c1-e3a41483a9da", null, null, null, "Kyle", "Spencer", false, null, "Kyle_Spencer", "AQAAAAEAACcQAAAAEKfhtSeYupor5DvFMqUDCoD5SLE+VI5TCrGAIilNNZ6toHeT5rmvop1eycgR+SePlw==", null, null, 1, false },
                    { new Guid("c32606de-b224-4989-bf52-f8b3cabea595"), 0, new DateTime(1931, 3, 13, 17, 9, 1, 277, DateTimeKind.Local).AddTicks(5325), 982.7401671892140000m, "b59385aa-7f50-40dc-b778-1796264fcd80", null, null, "Rosie", "Rosie", "Welch", false, null, "Rosie51", "AQAAAAEAACcQAAAAEEckzz9vDa+dx24vtdGou0DA2tSIsYG1Fu4tVx75o4u/eLvn9oIKK2AgSSQXliYwcw==", null, null, 2, false },
                    { new Guid("c41a987e-114e-4968-aa63-744e27096322"), 0, new DateTime(1931, 7, 14, 1, 7, 50, 194, DateTimeKind.Local).AddTicks(1937), 484.6124639071240000m, "c80e07a6-baa6-4597-8847-66e329a7fada", null, null, null, "Diana", "Swift", false, null, "Diana70", "AQAAAAEAACcQAAAAELI1tmUu6jJ/XQsj6FuujLU5B1VcdK8EmbgCe6Eq+q7rPznqlbo70snxmzHzGq2IsA==", null, null, 1, false },
                    { new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94"), 0, new DateTime(1954, 12, 28, 13, 44, 23, 170, DateTimeKind.Local).AddTicks(6773), 646.7816847471680000m, "97182eb5-15d0-4725-a6f0-8c91dd7095ef", null, null, "Casey", "Casey", "Mraz", false, null, "Casey67", "AQAAAAEAACcQAAAAEDs/+I1C9MttH8hx/awgl907a8QN3OrQGSip2fpXCCzBmznxsONyP9BwX3s5mY2Pbg==", null, null, 0, false },
                    { new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4"), 0, new DateTime(1935, 6, 28, 1, 4, 46, 94, DateTimeKind.Local).AddTicks(6204), 101.5962560910000m, "cd6076ae-f117-4ce4-9c05-491c4f0d4a68", null, null, "Helen", "Helen", "Hammes", false, null, "Helen59", "AQAAAAEAACcQAAAAEAMUOSaulrUIrlUQt1+nhfaKPuwNdQwnJlFXgetc9XkqjMpLs/7x94FU+drcer9QPQ==", null, null, 1, false },
                    { new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44"), 0, null, 725.4892586204250000m, "d8f96556-f185-4f62-b598-98bacfb6a4ac", null, null, null, "Donna", "Greenholt", false, null, "Donna.Greenholt31", "AQAAAAEAACcQAAAAEE9MbY4lAywN+7/JGcFulU+E+uwaMVdb6YrO5sUK/vJkQkasxZYsdAWEpE+5wD6lJQ==", null, null, 1, false },
                    { new Guid("c73bd258-469c-4d46-ad89-cd1119310c49"), 0, null, 154.9886729903930000m, "f68261c4-8453-445b-b5d0-efd12122a0d1", null, null, "Kelvin", "Kelvin", "Crist", false, null, "Kelvin_Crist55", "AQAAAAEAACcQAAAAEIxYqMqolu8P8zNQbbN4mFjBFw2oRqR/JkPs/9dosR8D40j8PkjYvDTc6UJchk5qig==", null, null, 2, false },
                    { new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190"), 0, null, 687.2869448110530000m, "c15b164f-fac6-420d-9156-5eb18bab7e1c", null, null, null, "Willie", "Ortiz", false, null, "Willie_Ortiz12", "AQAAAAEAACcQAAAAEJ9lGnukciuEcPENLZnE1Z82+iG+KmejBAKBTfyTOnfSwzvIgI8dnJoiGHag3jUPSQ==", null, null, 2, false },
                    { new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf"), 0, new DateTime(1941, 8, 22, 4, 51, 3, 768, DateTimeKind.Local).AddTicks(679), 211.9497075990160000m, "4c768f95-2543-4970-a1cc-30e45b6f961e", null, null, null, "Roberta", "Abbott", false, null, "Roberta24", "AQAAAAEAACcQAAAAEKVQoMIFpjxDuwwa5dopCX7lJfIOHLXlwBH+xB7WDFPlIhdkGX/7wT9Ghd7DyQTvEA==", null, null, 0, false },
                    { new Guid("c9809439-c97d-49ed-b84a-66149d142e46"), 0, new DateTime(1952, 5, 3, 10, 45, 50, 597, DateTimeKind.Local).AddTicks(7742), 252.6835439117080000m, "78d25e66-dfb5-4be3-9892-2c0bc1c75bf2", null, null, "Juanita", "Juanita", "Hodkiewicz", false, null, "Juanita61", "AQAAAAEAACcQAAAAEKwfxxZ3d3qzQaSMQDtF4uUPGFjJyrF35lAxKtM6x4B0Ipw/jhXjFZ4hBrRLZ5epng==", null, null, 0, false },
                    { new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6"), 0, null, 835.7589923558710000m, "b7732bf1-5488-44dd-b30c-3c2eb072fe03", null, null, "Gerard", "Gerard", "Luettgen", false, null, "Gerard.Luettgen99", "AQAAAAEAACcQAAAAEMoQzcxZoZKvXvNXQS0Yg0tTNaA1OHJxtwXcXVLAf8izol5+pOJpReNFQ7yONW/wNw==", null, null, 1, false },
                    { new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b"), 0, null, 911.865488635770000m, "78e6a728-3a14-41c3-a647-5b0e089540f6", null, null, null, "Jonathan", "Bradtke", false, null, "Jonathan.Bradtke", "AQAAAAEAACcQAAAAEF/qYZgtdx6/4E4TA5lbAb9riSjiErw4jV5sb7tbBvtjqmB7GU9kd+0XzUlDG/vZOQ==", null, null, 2, false },
                    { new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db"), 0, new DateTime(1952, 5, 3, 14, 58, 24, 744, DateTimeKind.Local).AddTicks(3459), 562.0553326003970000m, "75a89f47-8504-4938-819a-dc6dd976aa49", null, null, null, "Mandy", "Hayes", false, null, "Mandy.Hayes74", "AQAAAAEAACcQAAAAENhyRRclhvRnChA1i+gFROINSILTfKGFOF2kz2atbaimyigkITNfHUg7a7dxRocxpw==", null, null, 2, false },
                    { new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19"), 0, new DateTime(1967, 3, 20, 2, 52, 32, 183, DateTimeKind.Local).AddTicks(738), 47.95873625617350000m, "6608a2bd-698d-47b3-bb16-21abcde97ca4", null, null, "Tara", "Tara", "Rath", false, null, "Tara_Rath", "AQAAAAEAACcQAAAAEGKVlBdPxKlz/ZoD62VvxlpGoq9tACUGGEXJ/swc3I40a1eTxzcpyyc/pZjVmtZkkg==", null, null, 0, false },
                    { new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52"), 0, null, 683.7463999958010000m, "88748f59-9801-4e43-ba68-e67c147110fd", null, null, null, "Rose", "Okuneva", false, null, "Rose_Okuneva23", "AQAAAAEAACcQAAAAEAxtSSAp1YVGS7NVf3Oz1+aa16pZ/D432/3L5tfyDXJ6QjTZcx3UZPpH4RwNCRiXyQ==", null, null, 1, false },
                    { new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db"), 0, null, 55.47276206686560000m, "54063ac4-1233-42e4-9c43-6200efdac9c7", null, null, null, "Samuel", "Hettinger", false, null, "Samuel.Hettinger57", "AQAAAAEAACcQAAAAELLy8ridxWeA0UYsayvl45uCVNjualUFJTqIKs/+t/c/ABVNY+dOmJ9Ugh+Cd3a8ZQ==", null, null, 0, false },
                    { new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), 0, null, 545.445582050630000m, "e8857bf0-8c5f-4f31-b097-41d416ba1489", null, null, "Sammy", "Sammy", "Pagac", false, null, "Sammy.Pagac27", "AQAAAAEAACcQAAAAED72bkEbC3XBK4z+Nn3TuETTd+pmuOJNTnTCBXmkStuqcOIEEBgvQwb+G1gKfnbFJQ==", null, null, 1, false },
                    { new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab"), 0, null, 74.25345144035260000m, "43b348a2-5f43-4767-90a7-a1e1c066c26a", null, null, "Trevor", "Trevor", "Nicolas", false, null, "Trevor92", "AQAAAAEAACcQAAAAEMrluggdIb9o8+FOqUPigNHuXpmR7OY27IZpM4w+VGDSaF3tkiSqXRbVs7R3ylUzmQ==", null, null, 0, false },
                    { new Guid("cfa37291-0772-47b2-bbdc-842ca4428900"), 0, new DateTime(1993, 1, 21, 22, 31, 42, 31, DateTimeKind.Local).AddTicks(8981), 396.5936326465770000m, "9347ad78-3fec-4c27-a16b-bdddc12ad097", null, null, "Yolanda", "Yolanda", "Russel", false, null, "Yolanda12", "AQAAAAEAACcQAAAAEPOZb7S0Wb2xVeXA9m6X6qMRHy7W27UD5n1zK/K9kdf7KBQAHcx3BQUUjfpK5IpH2w==", null, null, 1, false },
                    { new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd"), 0, new DateTime(1998, 10, 16, 13, 36, 51, 815, DateTimeKind.Local).AddTicks(9818), 235.3441641011420000m, "52138deb-76fe-4f1a-993c-6f81716ba2ff", null, null, null, "Merle", "Abernathy", false, null, "Merle30", "AQAAAAEAACcQAAAAEHjY7z/WHrNZbyCvOMbIF0ycrayAtH8FmqHC7+oNQUHuNgH+kZGJ1aWAMEhdIsDpdg==", null, null, 2, false },
                    { new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0"), 0, new DateTime(1960, 12, 14, 18, 5, 35, 861, DateTimeKind.Local).AddTicks(9019), 485.0367981374650000m, "da14f095-a171-49a7-ac78-6d38a95d6021", null, null, "James", "James", "Gusikowski", false, null, "James_Gusikowski7", "AQAAAAEAACcQAAAAEJCm38oUZZ/sOmkSnfwDnZMLk7xey8ikQkkbaSHZX7p+XMIY+oPwKk7NmW1sG/zsoA==", null, null, 2, false },
                    { new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c"), 0, null, 749.0191153214420000m, "d8c9b43d-eb90-45a1-83f6-0d9a201d4cfc", null, null, null, "Jacob", "Schiller", false, null, "Jacob_Schiller", "AQAAAAEAACcQAAAAEObfrCmit2A3Kjn9HTe2wvB6b1JFOa41xqn3WPu+NpnuGkUrdsObnFeC0mVmyeGvOQ==", null, null, 2, false },
                    { new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179"), 0, null, 220.1153699152170000m, "f054dea5-faf0-416f-92ef-c81d298ce258", null, null, null, "Justin", "Kemmer", false, null, "Justin_Kemmer", "AQAAAAEAACcQAAAAEDODdhMmhHLsa3194/PqGbwG7Z9aJdhQ1XyhIZBVPK9rmb2oDZbiwcaY3x6h8oekQw==", null, null, 2, false },
                    { new Guid("d2c357de-2574-4d81-996d-8fd06173f665"), 0, null, 838.8162125176540000m, "15add08a-899d-45f5-b6a6-86161905d3bc", null, null, null, "Bryan", "Kozey", false, null, "Bryan.Kozey", "AQAAAAEAACcQAAAAEJnAaDYIXxKpXPJ/uCcW0aG+qD1EGAtdaZ32nubaU4CJK5CYIh+RH648QXkQqNp9Vw==", null, null, 1, false },
                    { new Guid("d35b9242-99c3-49f5-8020-bc6719205da1"), 0, new DateTime(1943, 2, 15, 1, 13, 22, 683, DateTimeKind.Local).AddTicks(6609), 437.0956774225710000m, "2f75cd5f-3b73-4d4a-992a-71f576a2966d", null, null, "Tyler", "Tyler", "Wiza", false, null, "Tyler.Wiza53", "AQAAAAEAACcQAAAAEHNPC48jrLaBX5D66mBT8I7obaF2g+8sYDj3gDbWtYuOw7Q82NZo+rKLJrEhmQe4IQ==", null, null, 0, false },
                    { new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1"), 0, new DateTime(1927, 9, 17, 2, 9, 43, 666, DateTimeKind.Local).AddTicks(8884), 669.5023493948240000m, "8d220b20-9ae0-4403-8c25-e21fdd0568be", null, null, "Doreen", "Doreen", "Bergnaum", false, null, "Doreen_Bergnaum18", "AQAAAAEAACcQAAAAECqjHOGMEgrfdu6+KY4Ykjf4PFNdGIo8It74Uf/XSZv0P8hM509krS6Y2uUPE5ClLA==", null, null, 0, false },
                    { new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547"), 0, null, 569.423682709520000m, "770baecd-c72d-48dd-ac2a-c74323590fe8", null, null, null, "Karl", "Hermann", false, null, "Karl24", "AQAAAAEAACcQAAAAEIh0B7Q4vKVPQke1mJpWCcVPwpuLG6cDpillg56/JYLEyJb7BF1SAbaUwgjJZC+X8g==", null, null, 1, false },
                    { new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0"), 0, null, 785.9500299135070000m, "84b62c1a-0c87-47a8-9697-c38bfea4fce3", null, null, "Ramona", "Ramona", "Towne", false, null, "Ramona11", "AQAAAAEAACcQAAAAEBD3u0Y6GvCj4qKuIX7a+FY2uXESRFX+ruhMTArXDFKCSSwj1O439WK3sV7ASW3Ovw==", null, null, 0, false },
                    { new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03"), 0, new DateTime(1977, 9, 30, 7, 21, 54, 876, DateTimeKind.Local).AddTicks(4269), 791.1715589073450000m, "95d51923-a3bc-41ae-8c99-729a7a905eaa", null, null, "Loren", "Loren", "Zieme", false, null, "Loren_Zieme", "AQAAAAEAACcQAAAAEEq06zHZzOgpzh3qNET3H2KumAfPYzIxbb4KDD+3XYPVVgHBWLqxC2JC+7nmXAgl0A==", null, null, 0, false },
                    { new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63"), 0, new DateTime(2006, 10, 27, 19, 37, 44, 975, DateTimeKind.Local).AddTicks(3996), 164.6295048306040000m, "4fce1732-65d5-47f0-b30d-b8710cfcf8ca", null, null, "Danny", "Danny", "Padberg", false, null, "Danny66", "AQAAAAEAACcQAAAAEBulge3grlbMeo88vsQACofnX9lk0xraEpD+yrFehsmjUWhqSKNkuBjLrbtfUFft1Q==", null, null, 1, false },
                    { new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed"), 0, null, 163.5426075646250000m, "4aed0c2d-f423-4cdf-8601-94f2e206acf4", null, null, null, "Vincent", "Bergstrom", false, null, "Vincent94", "AQAAAAEAACcQAAAAEPiyjGZdNvlUJbbR1V/aSREioae9NJ0v9SmXLyal0YGpU3FUoNxP4hfRcxgaKj11Zw==", null, null, 1, false },
                    { new Guid("d8e6873e-ae0e-4181-866e-982565b77df9"), 0, null, 903.5105277937510000m, "931722e8-75d3-4743-8d8a-58cbabebb8d9", null, null, null, "Hilda", "Graham", false, null, "Hilda_Graham79", "AQAAAAEAACcQAAAAEAPJbPofPguGuo1ELCsIYgA39Yp0UntEEiokHRAWilcYG8uU8/zAUDoFflr/hd4KMA==", null, null, 2, false },
                    { new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057"), 0, new DateTime(1950, 2, 26, 11, 50, 55, 672, DateTimeKind.Local).AddTicks(4412), 296.8638096101510000m, "b9c76cd0-e5c1-4687-ad18-7e9db2bde40b", null, null, null, "Nicolas", "Hettinger", false, null, "Nicolas8", "AQAAAAEAACcQAAAAEHJTaMHywg19RNTV0y0jPitLMPn2SBLH9R3k+yk4dPuWMRIQhFARBeh1Z2rGh+y2Ig==", null, null, 2, false },
                    { new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b"), 0, new DateTime(1965, 11, 5, 14, 58, 30, 796, DateTimeKind.Local).AddTicks(4812), 600.1303433368320000m, "235ac7bf-7724-4e17-ab99-5e0b3a867af6", null, null, null, "Melvin", "Nicolas", false, null, "Melvin_Nicolas", "AQAAAAEAACcQAAAAEC/+HICkIpNN4U7AuIMKh1Hi/IDnkdk1pTGeygEXLRgInXaoXdRhSn5avJIujGuP3w==", null, null, 0, false },
                    { new Guid("da175a26-80f5-4704-9c96-da3480a7797b"), 0, new DateTime(1941, 3, 12, 10, 13, 24, 692, DateTimeKind.Local).AddTicks(3353), 852.1119342374790000m, "dc3ddfa9-4f84-423f-8db1-e53a73e2c65d", null, null, null, "Carla", "Douglas", false, null, "Carla23", "AQAAAAEAACcQAAAAEK3NffrwStMxMXxzUIKebsLtI98XRhEjsHQG4F6fpe2acKbD8km7PjSYjjtu4bJz0Q==", null, null, 1, false },
                    { new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8"), 0, null, 182.5390277383160000m, "c292efe9-dcc9-40f5-aee5-8827e90a55dd", null, null, "Beverly", "Beverly", "Little", false, null, "Beverly45", "AQAAAAEAACcQAAAAEOHjIay/SaxmkU4Ub2KQ6uzHbGO9JtnSachfbXYzZ85tJQGnwKMzv+cCM3sN2f87jA==", null, null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267"), 0, new DateTime(1966, 11, 16, 13, 44, 56, 678, DateTimeKind.Local).AddTicks(1161), 11.76477848325990000m, "a5089b27-30bd-4e32-89f8-24fb6d694878", null, null, null, "Mercedes", "Effertz", false, null, "Mercedes_Effertz", "AQAAAAEAACcQAAAAEMwjm0aPRmzNgdk3ek06pJqdndMkot9uk14pZwbsFjDkVAuCuaccCQ8K97nc+VX7Hw==", null, null, 2, false },
                    { new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0"), 0, new DateTime(1931, 3, 13, 19, 37, 40, 101, DateTimeKind.Local).AddTicks(6624), 265.119382785420000m, "da97ecdb-3dbd-466f-8e31-30e3f530f540", null, null, null, "Glenn", "Luettgen", false, null, "Glenn1", "AQAAAAEAACcQAAAAEK+MPuEEqrTq9bS9GSFwXTAQOSojcCsx7bvuxru08LPKNCYSkzLg7bdbHtTEfUqTpQ==", null, null, 0, false },
                    { new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5"), 0, new DateTime(1932, 4, 30, 7, 53, 13, 303, DateTimeKind.Local).AddTicks(3720), 320.969074645160000m, "a194d9db-5020-436a-8a3d-4103d8b05dda", null, null, "Jorge", "Jorge", "Langosh", false, null, "Jorge80", "AQAAAAEAACcQAAAAEO8TkM/bwezNWPMdUhStBEpqL7y5DtEbV5oQuTyatbgYsyvbkM3QcQK7anrRYXuTbg==", null, null, 2, false },
                    { new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb"), 0, null, 573.1741781646590000m, "55386be3-ed99-469f-b78b-10b1b19b97e6", null, null, "Isaac", "Isaac", "Wintheiser", false, null, "Isaac_Wintheiser", "AQAAAAEAACcQAAAAEKEKV35HgMLI1AABqnI1CRNgHavGhC+4cLBOJdIuGpcMd+0XI+kbxoV1UgXnRcoyhA==", null, null, 0, false },
                    { new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405"), 0, null, 348.0976593648950000m, "ae6d0b65-e8da-463f-8069-6415d2073888", null, null, null, "Betty", "Smitham", false, null, "Betty.Smitham", "AQAAAAEAACcQAAAAECzxc2r5dZHfo8tY8IAucoyvrMbFarM+evMVEZq8LLDYYhH5HPS+BTS3LBgbNikGYA==", null, null, 2, false },
                    { new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe"), 0, null, 661.7721391353710000m, "0918a7aa-9c63-4e09-82fd-b52d48be5f4c", null, null, null, "Justin", "O'Connell", false, null, "Justin.OConnell", "AQAAAAEAACcQAAAAEPYz9ItEaNzd1j62gu4ytajsBOrfQN+c33Dyn2W1q2sU5P4GAcj5qYI1baZ6RYZzDg==", null, null, 2, false },
                    { new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807"), 0, new DateTime(2003, 6, 4, 21, 29, 44, 867, DateTimeKind.Local).AddTicks(5755), 267.8344072343190000m, "95812feb-b9ce-4c4c-8aab-0531debbe135", null, null, null, "Natalie", "Hilpert", false, null, "Natalie_Hilpert37", "AQAAAAEAACcQAAAAEMVLKlWDDtNat+dPf3d7ybLOJbic8DXfAHAWTLndYRxOQdZsi6yn4l2qvpyKFGfN+g==", null, null, 0, false },
                    { new Guid("e31a76f4-5bec-480b-974e-4e00950656e8"), 0, new DateTime(1928, 11, 14, 3, 40, 1, 419, DateTimeKind.Local).AddTicks(901), 263.4839524659890000m, "87363c65-9d55-4542-b912-1924fa0db795", null, null, "Bobbie", "Bobbie", "Turcotte", false, null, "Bobbie.Turcotte45", "AQAAAAEAACcQAAAAEFc6A+qqfzhV4/F09OQ60vdnSHNrbIWKpa8zhP1kwo+Fslgyp9Mv4aX+JuUFMMCyYw==", null, null, 2, false },
                    { new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35"), 0, null, 756.5564027505060000m, "072b5c97-b16a-4dbc-867f-b0cc6e79f1a3", null, null, null, "Judith", "Lockman", false, null, "Judith85", "AQAAAAEAACcQAAAAEJQxlohBcU1NTCiw/2KViEJl1C1BlWRbdeFgjY16geDjuSJIREKWpZDXTTvz4T9XVw==", null, null, 2, false },
                    { new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457"), 0, null, 779.6680444263380000m, "e995abfd-193d-4eec-a842-dedb05741357", null, null, null, "Kerry", "Mertz", false, null, "Kerry_Mertz", "AQAAAAEAACcQAAAAENHdwJMinDOu4FYqCcJQgTW+CkxaUOb5NkYL2KeFJn7lZmA3tVEePxnbOJF+5NLU4Q==", null, null, 2, false },
                    { new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9"), 0, new DateTime(1987, 11, 26, 21, 25, 20, 214, DateTimeKind.Local).AddTicks(1997), 691.9783222557060000m, "ff9c3fa5-0427-4246-9363-5aadf19791b9", null, null, null, "Angelina", "Rosenbaum", false, null, "Angelina.Rosenbaum", "AQAAAAEAACcQAAAAEAMLEWNJ5ZbynXx+T2DpUgIOLJqv+ekZB/8uSjjLhg4jyrT/ruPx4D3aYG7iRhr61g==", null, null, 0, false },
                    { new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7"), 0, null, 729.9415587848660000m, "bc7ba5eb-ea13-4ace-ac3b-c9d5c1144abd", null, null, "Lynda", "Lynda", "Hintz", false, null, "Lynda31", "AQAAAAEAACcQAAAAEAQ3coWwZe1TyosW4H6vOs0S6347waWym61ZDAYxDoMT0gRH6BIhowKne9vOBbBRbw==", null, null, 1, false },
                    { new Guid("e8293c7e-c598-445f-a509-d9123149ec52"), 0, new DateTime(2001, 8, 19, 11, 21, 3, 164, DateTimeKind.Local).AddTicks(5068), 748.8496799226360000m, "a79ff8e6-9019-4b1e-9ff8-aee616344124", null, null, null, "Lucia", "Bruen", false, null, "Lucia.Bruen", "AQAAAAEAACcQAAAAEH16smiczpaaGPUUEmHihqtFkQvvUBZP8h/gt3/gAZU0WB10FHdIOod0H8xtuX5NKg==", null, null, 1, false },
                    { new Guid("e881572a-cd4a-4d95-bf26-6855a9394560"), 0, null, 917.9884713565060000m, "05100429-e38e-49cb-ac7f-b6167c4182b9", null, null, null, "Simon", "Jenkins", false, null, "Simon.Jenkins45", "AQAAAAEAACcQAAAAEMGgaHHEWgR0hTZ7ZeUqnS6yxfGM5iIFVwSDLcVrL4IcCJP0ww55InsNSLwVJdaT7g==", null, null, 0, false },
                    { new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367"), 0, new DateTime(1996, 7, 17, 1, 46, 51, 335, DateTimeKind.Local).AddTicks(2234), 716.1436036265740000m, "dc79dc7e-c99d-45d3-b960-71865deadab5", null, null, null, "Russell", "Hand", false, null, "Russell.Hand", "AQAAAAEAACcQAAAAEORn+CgL1VhtVYDDDceljfLT5MWwXTPOuAgiVym8IuQ0NoqgN0j/WLOjORB0WoleWQ==", null, null, 1, false },
                    { new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727"), 0, new DateTime(1955, 7, 16, 23, 12, 2, 466, DateTimeKind.Local).AddTicks(8937), 691.1966128511120000m, "f360d2c2-f00e-420b-8061-26c287d6ed25", null, null, "Carrie", "Carrie", "Lynch", false, null, "Carrie63", "AQAAAAEAACcQAAAAEHFvAufG39OFZqT/Cx2GaRSzq1T48ANn0GUVgQWxVvDxhgXDuOIxZkomye2wiXp5NQ==", null, null, 2, false },
                    { new Guid("ec149744-9128-4f41-875a-1c96bf1c851c"), 0, new DateTime(1994, 8, 19, 15, 53, 53, 689, DateTimeKind.Local).AddTicks(8016), 594.4248730082370000m, "8309a91c-e90b-4ba2-9133-aaf6580d6027", null, null, null, "Everett", "Feil", false, null, "Everett_Feil51", "AQAAAAEAACcQAAAAEPa/YRjqDL0jz6TQjO/We78/ODMxvBA9V3uZgHMHOPIb4wAw/1EuxUMgs5LbRCw43Q==", null, null, 0, false },
                    { new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd"), 0, new DateTime(1979, 7, 5, 4, 25, 25, 29, DateTimeKind.Local).AddTicks(8790), 333.8736455073560000m, "147f6c6b-97b3-407b-a252-768f39802868", null, null, null, "Hugo", "Lindgren", false, null, "Hugo.Lindgren", "AQAAAAEAACcQAAAAEABqIm+YJGDtV12fcpnFJRK9zs3xIPq+qSplnJsIsExWH/yCaAoDRegESAbmXIHQ+A==", null, null, 2, false },
                    { new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d"), 0, null, 480.778603461820000m, "15f812bc-8407-4d8d-885c-5bd44c8d4d1d", null, null, null, "Corey", "Hoppe", false, null, "Corey.Hoppe", "AQAAAAEAACcQAAAAELzRVyK4kvZoD970p4y4PmnGKgcl3MjTlk6VGnN0mjqP6AhoPwHEWC1XWJ+xPJ7vig==", null, null, 2, false },
                    { new Guid("ee988837-dda9-4fd3-9925-0375db807eaa"), 0, new DateTime(1946, 5, 26, 8, 36, 29, 892, DateTimeKind.Local).AddTicks(2195), 997.3642953798230000m, "205bad65-df5f-4be2-bec0-968feeaad22c", null, null, null, "Traci", "Ebert", false, null, "Traci.Ebert49", "AQAAAAEAACcQAAAAEPZ7rNhH9CkNSvA30Iae6Klcb/0wLpqfzrvmTT4VYWgnQHM/Lr2owwFbOlU/SHWZNA==", null, null, 0, false },
                    { new Guid("f198b380-c53a-437b-904d-29b9d522aac3"), 0, new DateTime(1933, 8, 12, 18, 38, 16, 716, DateTimeKind.Local).AddTicks(69), 184.1352636006340000m, "99333213-582b-46fd-aa9d-f2b34e4cc3d3", null, null, "Janet", "Janet", "Halvorson", false, null, "Janet.Halvorson62", "AQAAAAEAACcQAAAAEDtzdpojm6nXtvkEZMZLAysyqbezz1kW9VSCHmHRR+uimrgrKG5/e2r2pUb0s/01jQ==", null, null, 0, false },
                    { new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92"), 0, new DateTime(1973, 5, 26, 16, 24, 12, 735, DateTimeKind.Local).AddTicks(398), 381.3602312209370000m, "4065558e-ee93-4dd1-ad04-a09188e935f6", null, null, null, "Jack", "Wunsch", false, null, "Jack99", "AQAAAAEAACcQAAAAEEFIPXWPHAAeOMYuyFqBnKFkBmAiP+s8LndIwcZjtTDqqwSK5jiI2OKSoLzVl4T4hQ==", null, null, 1, false },
                    { new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b"), 0, new DateTime(1976, 10, 25, 19, 25, 15, 823, DateTimeKind.Local).AddTicks(3097), 667.4642092415570000m, "fa0c8ffd-8612-44df-8057-a2786c46b414", null, null, null, "Edgar", "White", false, null, "Edgar.White48", "AQAAAAEAACcQAAAAED1de2f8lMF4DB84Ori8Ad4KWoG47zpccxkH7Ik7U9Pc3xbpNLPZO/zPZpqenLEoyg==", null, null, 2, false },
                    { new Guid("fa64f167-af58-425d-8dce-93642bd7650a"), 0, null, 635.6526379735730000m, "74d9b019-4073-446f-b644-13f4f98bd575", null, null, null, "Carol", "Hayes", false, null, "Carol75", "AQAAAAEAACcQAAAAEH1XWe/K24mwh6y4EzUP49u8hZzPnnTTAYpO1dlJA+V3yLZMmAIV5NjIbySgQS52VA==", null, null, 2, false },
                    { new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1"), 0, new DateTime(1999, 9, 24, 5, 40, 33, 540, DateTimeKind.Local).AddTicks(8276), 74.49042573058710000m, "02073f1e-c3c5-403c-b667-eb7c8006aba0", null, null, null, "Essie", "Mohr", false, null, "Essie.Mohr68", "AQAAAAEAACcQAAAAEAKCgX3SEyoUSToGdzQG1ryVvmgZU93SaznNM229nE3ShGymHGmyBFaPQV1bIwDplA==", null, null, 1, false },
                    { new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f"), 0, new DateTime(1965, 5, 9, 6, 11, 17, 420, DateTimeKind.Local).AddTicks(6167), 663.6051488028860000m, "fc6d4819-bac5-4796-accd-d20ba829a84e", null, null, null, "Pete", "Runolfsson", false, null, "Pete9", "AQAAAAEAACcQAAAAELrI2Qdv6NqyMZXFeyrCP1I2JHo7ofSGeI4+u2eqvy8smy8ISzpM2gGahgi8A/D0RQ==", null, null, 1, false },
                    { new Guid("fcece836-8a31-4164-8bfa-b14059865b6f"), 0, new DateTime(1924, 10, 7, 19, 18, 21, 347, DateTimeKind.Local).AddTicks(9797), 603.445621610840000m, "d7dc03ed-5827-485c-8dde-4e44c6353b17", null, null, null, "Cynthia", "Monahan", false, null, "Cynthia.Monahan", "AQAAAAEAACcQAAAAEFU3bf0nmQfTycomD8fboJE/3dhfm24UVjdDlHHKIj4JDRTZt1c58z008lkd/lEZGQ==", null, null, 0, false },
                    { new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737"), 0, new DateTime(1949, 9, 10, 22, 49, 12, 638, DateTimeKind.Local).AddTicks(6712), 905.9317520402330000m, "c87f166b-8394-44c6-9cdb-ee3eb4340d06", null, null, null, "Rafael", "O'Keefe", false, null, "Rafael.OKeefe89", "AQAAAAEAACcQAAAAEKmy2dMS1IXHA93mAomG41GddJrcwsFt+R5yrGzSxKw9kv9cmDYqw5F+mueMzwkc5A==", null, null, 0, false },
                    { new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d"), 0, new DateTime(2000, 8, 18, 0, 57, 45, 928, DateTimeKind.Local).AddTicks(3547), 875.6693952662010000m, "ff33ae80-5a08-487b-baa0-24462b228b08", null, null, null, "Andre", "Kuhlman", false, null, "Andre.Kuhlman", "AQAAAAEAACcQAAAAEK0ZxxLit+JNQCQp6PNmcpqSqiWJeT0jPEeHQiUxLi3VfoISA4QpAgwC/ZfU6BJBTw==", null, null, 2, false },
                    { new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8"), 0, new DateTime(1930, 3, 30, 17, 43, 26, 976, DateTimeKind.Local).AddTicks(6280), 126.794477230550000m, "69881085-d8fe-47a3-99a0-15ffc5252340", null, null, "Gabriel", "Gabriel", "Bergnaum", false, null, "Gabriel.Bergnaum", "AQAAAAEAACcQAAAAEMgsrwLSxpO5C+Vy8nQdOKjfc4Wl8lC40HqynpqUNXaE4Dic6jP7dw22s+rNEwYm0A==", null, null, 0, false },
                    { new Guid("ffcbaec9-773f-4373-b37e-e5854087b988"), 0, new DateTime(1932, 3, 3, 16, 23, 53, 156, DateTimeKind.Local).AddTicks(7838), 546.6326879110830000m, "8f66e80e-bf31-4cff-b5ec-801e40b93b3f", null, null, "Delbert", "Delbert", "Schmitt", false, null, "Delbert77", "AQAAAAEAACcQAAAAEGR44+s9o1C50+fryebeWe88phHeTel79UiKljcgpe7Fi2WrdIJRRFmuJ0LczlElTA==", null, null, 1, false }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("08bafeba-ccf3-4ec3-93d4-d198601222df"), "49,633114;24,624352", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vincentberg, Democratic People's Republic of Korea", "Sedrick Crescent, 919", 113 },
                    { new Guid("0add8461-3561-459a-9e90-f652f7453531"), "50,94396;29,974617", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Phoebeberg, Albania", "Allan Creek, 7202", 146 },
                    { new Guid("0c6094e0-aa7f-44d7-a0dc-bc52320b1d23"), "50,43004;23,72075", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ilaborough, Central African Republic", "Tristian Village, 563", 199 },
                    { new Guid("17e2c38f-43ae-48ce-9af6-ac3c2afae18c"), "49,482048;30,955921", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Erdmanland, Myanmar", "Casper Curve, 14227", 38 },
                    { new Guid("18e6a770-2aeb-47e5-a0bb-2a16f1e54b16"), "48,77211;23,029037", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Julianborough, Christmas Island", "Frami Place, 81485", 1 },
                    { new Guid("2193cad6-36d3-4fdf-9a62-ef1fac7a3756"), "49,39751;30,29388", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Mavis, South Africa", "Emmy Hills, 542", 130 },
                    { new Guid("22fd014c-c10d-4a80-8a58-638fd3ebc399"), "50,248867;24,0189", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Goyetteside, Australia", "Carter Manor, 185", 33 },
                    { new Guid("268296ff-0172-46c7-92d6-bca6ae829b1b"), "49,907944;24,847666", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Aleen, United Arab Emirates", "Beahan Circles, 6167", 158 },
                    { new Guid("26ff0e19-7cc6-4839-b0ef-70b4a540e356"), "48,38214;28,083017", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Eladiofort, Chile", "Mason Track, 565", 141 },
                    { new Guid("29713c61-ea65-414d-9610-fe5b5f467c70"), "50,266933;28,715014", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Emmettfurt, Cameroon", "Berge Bridge, 61256", 192 },
                    { new Guid("2a2aba05-0da0-449d-bf27-1c853b371df9"), "49,184006;24,003897", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Carleestad, Russian Federation", "Juvenal Landing, 653", 55 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("2bef7623-52e1-4125-ab5d-1342adf58c0d"), "49,585617;29,452227", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Irving, Cocos (Keeling) Islands", "Gibson Hollow, 3261", 106 },
                    { new Guid("2c9b14ae-ada0-449e-8cf7-8be5d8c7976b"), "48,039055;25,045197", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Aidaberg, Tonga", "Maggio Ford, 44013", 119 },
                    { new Guid("34f9edc4-245a-4293-b0e1-2ab889bcd7f6"), "50,47285;27,689133", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Patshire, Bahrain", "Wilhelm Road, 85883", 16 },
                    { new Guid("3769fcbf-f745-4302-b391-8f70a3e0f143"), "49,360817;25,869352", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Matt, Saudi Arabia", "Mueller Isle, 18606", 108 },
                    { new Guid("376a61aa-391b-441f-af26-38986e0aeb4d"), "49,932365;28,442543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Volkmanbury, Iran", "Deckow Bridge, 823", 185 },
                    { new Guid("3901eb43-a07c-4940-82c9-52b6f1296fc2"), "48,559486;26,510435", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Ritaside, Uzbekistan", "Predovic Shore, 831", 105 },
                    { new Guid("39c246e7-30ab-430a-9434-3c6eb4f7ff43"), "50,078106;24,363495", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schowalterstad, Seychelles", "Jennie View, 242", 91 },
                    { new Guid("3d1d42a9-4695-494d-ac28-2f14422fae73"), "49,309414;30,053705", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Rudyborough, Ukraine", "Amelie Ferry, 62131", 80 },
                    { new Guid("40574440-29dd-4c97-ba03-5282e6961fa6"), "50,411102;28,583824", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brandynburgh, Timor-Leste", "Lowe Path, 7748", 117 },
                    { new Guid("409443df-48be-4ee7-bd40-904dd2b47d07"), "49,37784;26,249493", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Jess, Tokelau", "Bogisich Islands, 875", 178 },
                    { new Guid("41aab371-656a-47ba-bf44-fbaaaa043f22"), "48,35398;24,750475", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Royland, Japan", "Fay Squares, 0107", 144 },
                    { new Guid("45f136ce-2ffd-481c-95cc-7484691c9112"), "49,09298;30,434868", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Deronland, Timor-Leste", "Krajcik Walks, 185", 3 },
                    { new Guid("4809b9d5-6679-4c8d-a8f3-22ff6fc2c7de"), "50,168907;25,78218", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Oliverbury, Congo", "Guy Lakes, 978", 15 },
                    { new Guid("4b5af9b8-a24a-4681-88d5-b6d8a3556a68"), "49,494625;23,300026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jordyfurt, Tunisia", "Bernhard Overpass, 228", 58 },
                    { new Guid("4bdb2dd6-a656-4613-9134-ae5715d4f717"), "48,217937;29,829178", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Huelsside, Tunisia", "Dach Burg, 8762", 172 },
                    { new Guid("4dd3f383-8ed5-4259-b87b-79683af18770"), "50,3633;25,745747", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Alysabury, Uganda", "Mylene Ports, 28614", 11 },
                    { new Guid("4e9d206b-ca43-4dc1-ab43-336b61db0d51"), "48,499302;24,637184", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Deantown, Mauritania", "Nolan Run, 086", 164 },
                    { new Guid("50eb7ca1-f745-4f1f-84ce-92eb7e813920"), "48,953762;25,31391", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Melbamouth, Saudi Arabia", "Loren Overpass, 38807", 170 },
                    { new Guid("52add87c-6b70-4d2a-8f5a-a65e3e99e687"), "48,33931;25,544655", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Judahburgh, Iceland", "Trantow Shore, 44476", 1 },
                    { new Guid("54064454-f170-4258-a687-93a3f92d28dc"), "49,224613;30,497932", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sauerstad, Solomon Islands", "Justyn Forest, 929", 8 },
                    { new Guid("553af93a-8a03-4e51-935d-6eece111c6d1"), "49,212612;26,435343", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Goyettemouth, Brunei Darussalam", "Funk Shoals, 8742", 88 },
                    { new Guid("588cafa3-0ca6-4cbd-9558-92db2a4f8a1d"), "50,642212;29,036865", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Leonorafurt, China", "Everett Rue, 06383", 42 },
                    { new Guid("59226700-5768-4a5b-830b-70803f4c9673"), "49,23659;26,435314", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Candice, Saudi Arabia", "Bode Causeway, 039", 171 },
                    { new Guid("5932d7fc-247e-45e8-9d6e-066673a6307c"), "48,156815;25,791752", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Adrien, Lebanon", "Chanel Cove, 0996", 4 },
                    { new Guid("5b08d811-9831-465f-9cbe-ea4bf2859a77"), "50,394234;24,550234", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ashtonberg, Togo", "Alberta Fall, 82181", 99 },
                    { new Guid("5daff4bc-5b57-42f7-97f6-2c7bd6ab0a2a"), "50,129982;25,092728", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Delphine, Trinidad and Tobago", "Khalid Divide, 0331", 18 },
                    { new Guid("62abbbaf-525d-429b-9fdd-b33bb8c1c695"), "48,22507;28,913149", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Retha, Peru", "Cummerata Garden, 70119", 193 },
                    { new Guid("62c56361-55d2-456d-abc1-8c1c7d7816c7"), "49,21419;24,6793", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dooleyborough, Nigeria", "Sid Camp, 073", 24 },
                    { new Guid("645486c1-a8d7-4715-8858-6fd61f7910c6"), "50,28489;24,339092", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Ned, Martinique", "Mante Parks, 311", 128 },
                    { new Guid("65bd4503-73e0-44de-9a92-49d4a3968272"), "48,028114;26,933987", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Eloyport, Samoa", "Webster Plain, 84588", 146 },
                    { new Guid("6d8ed292-0083-436f-b16f-7e7ea130ee11"), "48,02975;29,909122", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lonieton, Paraguay", "Kattie Stream, 800", 149 },
                    { new Guid("6fe54575-8e43-4821-93ef-3ad190e62bae"), "50,737267;28,30057", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mireyachester, Poland", "Barton Shores, 89384", 79 },
                    { new Guid("7175391b-1b4a-4349-ae24-a1ffac04e99c"), "49,68739;29,440964", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Emerson, Christmas Island", "Cummerata Junction, 79077", 61 },
                    { new Guid("7480de8a-af9d-4ca5-a053-dfd494d390f0"), "48,962543;26,989384", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Amosshire, Japan", "Meredith Street, 4400", 11 },
                    { new Guid("74a78be8-b8ff-4a32-a288-6913678a677c"), "48,177666;29,437658", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Waynefurt, Montenegro", "Tianna Plain, 76389", 153 },
                    { new Guid("74ee2893-022b-41ea-b8ce-754d4c64c68c"), "49,47346;27,224253", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Leonorshire, Netherlands Antilles", "Consuelo Way, 872", 12 },
                    { new Guid("758aaba4-b054-4133-a6d3-5819784e6f2b"), "48,811577;28,60646", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Tod, Yemen", "Cole Orchard, 48411", 8 },
                    { new Guid("7ade1ad7-94a9-4c75-a0ba-4e3bfa08ca47"), "50,689682;25,169544", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Benstad, Guinea", "Pierce Isle, 06722", 103 },
                    { new Guid("80409f82-784b-481e-a2fd-0b842acb1219"), "50,520405;23,106255", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Gwendolynmouth, Kuwait", "Marquardt Route, 10014", 177 },
                    { new Guid("8871edd1-3e8a-4bf6-bff0-ac5ba00cc31e"), "49,418453;27,785145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rainaside, Sudan", "Arjun Pine, 58538", 178 },
                    { new Guid("8b2e0e10-84ed-4d34-af14-d92f3d2c9625"), "49,012035;26,84844", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Justen, Bosnia and Herzegovina", "Laurie Crossing, 2082", 29 },
                    { new Guid("8b7e73ec-3a47-4f3e-a809-85100475c7b4"), "50,756084;23,568794", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Frankstad, Guinea-Bissau", "Durgan Island, 38642", 159 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("8d930ca5-8866-44a0-8011-5035a3a56e48"), "48,21703;25,404472", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Carolyneview, Burkina Faso", "Cleo Passage, 78591", 161 },
                    { new Guid("972b1006-8466-44ff-9e23-12dff080d6b8"), "50,021137;26,877216", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Kasandra, Nicaragua", "O'Hara Fields, 86654", 13 },
                    { new Guid("9c7cb180-6337-4808-aba9-84047274a0e8"), "49,879047;26,224878", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Ottis, Christmas Island", "White Flat, 149", 26 },
                    { new Guid("9e182090-9c04-4d56-8d22-bfbb6b4eb695"), "49,50819;23,808634", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Markville, Iraq", "Clifton Isle, 22044", 45 },
                    { new Guid("a2396936-fc58-4480-8064-ef50d30812a1"), "49,371468;24,666065", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Ricardochester, Virgin Islands, U.S.", "Elmira Junction, 4934", 144 },
                    { new Guid("ab939c67-eba8-49b9-8ebf-446a0cf7cbeb"), "50,68036;25,976873", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fredashire, Guinea", "Tito Fields, 00090", 170 },
                    { new Guid("abd2a2f9-1d98-407f-a6b1-4f667a2a2f7b"), "50,063347;25,644045", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schmelerhaven, New Caledonia", "Neal Terrace, 939", 19 },
                    { new Guid("ad2f387a-f320-4aad-a661-33f7f0bb5e53"), "49,553947;23,357492", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Croninville, Serbia", "O'Hara Motorway, 439", 128 },
                    { new Guid("b0ebf325-9386-4c7b-9fa8-8ac7d3747bce"), "50,62574;26,038818", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Flaviochester, Azerbaijan", "Caitlyn Walks, 1494", 134 },
                    { new Guid("b2ed7b7f-8c93-45be-a2af-39ca4b59efa3"), "48,30016;24,468977", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kingshire, Mayotte", "Smitham Wells, 791", 46 },
                    { new Guid("ba504f00-5dac-4403-9edf-0f78889800ed"), "48,650417;30,860313", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Salliefort, Trinidad and Tobago", "Cormier Canyon, 58365", 148 },
                    { new Guid("bbb71dda-6ea1-4254-876c-c565214707d6"), "49,027576;25,83155", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lehnertown, Western Sahara", "Cierra Viaduct, 08762", 103 },
                    { new Guid("be02f293-6ad0-4cde-9657-aa1a4f0147da"), "50,776646;30,447124", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wizafurt, Croatia", "Cremin Ville, 0125", 171 },
                    { new Guid("c010d351-88a0-4560-8c7c-75e4ae50fc38"), "50,075386;24,437151", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Violetside, Turkmenistan", "Schiller Run, 53835", 110 },
                    { new Guid("c12582c9-e9f4-44fa-9a04-a0ac3bc7c2fa"), "50,214336;26,146439", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hilpertmouth, Greece", "Trantow Valleys, 862", 39 },
                    { new Guid("c22346a4-8179-4ee4-94fb-899701f590dd"), "49,946125;25,784216", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kathrynmouth, Montserrat", "Gleichner Mall, 36977", 8 },
                    { new Guid("c53360c7-0431-4b9b-8711-3cdc622ffc85"), "48,317688;30,563692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mistystad, Isle of Man", "Justine Harbor, 038", 132 },
                    { new Guid("c6bce086-a126-4493-8ece-656a59f1ee76"), "48,79607;28,187435", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Shannyview, El Salvador", "Goyette Crest, 73914", 50 },
                    { new Guid("c91c90c8-c228-4184-a7ad-51b82e8475a2"), "48,947678;25,538143", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Norvalstad, Sierra Leone", "Von Lake, 8695", 56 },
                    { new Guid("cabec423-dedb-4008-bd08-8dfc0cc7bf70"), "49,949944;28,30474", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Abernathyview, Moldova", "Oren Gateway, 3039", 134 },
                    { new Guid("cb6a86d3-bfbf-4bf5-a0e2-ecbaecfb4b93"), "49,282345;27,0172", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Pamela, Angola", "Quigley Throughway, 7972", 54 },
                    { new Guid("cbb908e3-23f0-4b99-a743-50d7ba332a91"), "49,32598;29,048195", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Joannyport, South Africa", "Ettie Flat, 1014", 160 },
                    { new Guid("d04e49d9-c75a-4398-a1a5-4adabed5dff6"), "49,367157;24,637407", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Feeneyfort, Angola", "Eda Forges, 9470", 79 },
                    { new Guid("d33b500e-b718-4692-8ba2-a65964794aad"), "48,55232;28,21313", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ryleigh, Guadeloupe", "Parisian Landing, 5996", 8 },
                    { new Guid("d8b2039f-2612-4617-8496-a368e01f7ad6"), "50,952793;27,433023", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Alfreda, Germany", "Howell Branch, 49415", 101 },
                    { new Guid("d93c0e53-6b3e-4495-b2c6-4ba2a5e1d95f"), "50,33186;26,238173", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gageshire, Martinique", "Mikayla Trace, 5100", 81 },
                    { new Guid("d98d3f59-8d3d-4ef4-8d02-8ee39dc36e75"), "50,765446;29,090023", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Dominique, Holy See (Vatican City State)", "Wyman Point, 664", 128 },
                    { new Guid("da28daea-bab9-4aed-9037-2860302f7c1c"), "48,701138;27,137924", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Purdyview, Spain", "Kiera Cliff, 265", 27 },
                    { new Guid("dbe1e4c6-f9b6-4368-bd4c-3346f926af33"), "49,731728;27,232332", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Luciennechester, French Southern Territories", "Rylee Parkway, 7444", 69 },
                    { new Guid("de1ad85d-ca71-4560-ba6f-8d9401297899"), "48,910248;30,948896", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Nathanburgh, Iraq", "Rex Squares, 0896", 175 },
                    { new Guid("e0a5d042-0791-403a-ba69-e245c3f49a8d"), "48,96711;23,482147", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Randyview, Montserrat", "Agnes Prairie, 6145", 138 },
                    { new Guid("e383ad5a-9f2b-4c3a-aed1-c71f430ad998"), "49,73198;27,152615", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lindville, Malawi", "Moen Garden, 0783", 80 },
                    { new Guid("e409ca37-b1ed-429a-8d57-f2fdeefff9e7"), "49,58268;23,44629", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schultzmouth, Cambodia", "Smith Mountains, 68565", 107 },
                    { new Guid("e4ae44e6-eb8a-4fc9-a768-83add4ceaa23"), "49,22293;29,774588", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Walton, Palau", "Hermann Terrace, 5857", 46 },
                    { new Guid("e8e8bef3-389e-4773-bdd2-72f0ff7812ca"), "50,757504;25,843115", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Norberto, Jamaica", "Camilla Alley, 23866", 71 },
                    { new Guid("e907cafd-764a-4ced-af01-bc3c3e539e1c"), "48,00417;24,698366", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Baileychester, Syrian Arab Republic", "Graham Ford, 00999", 135 },
                    { new Guid("e958fb6b-64c6-4d08-910e-c51ad33d847c"), "48,090183;28,331974", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gutmannside, Bahamas", "Gaylord Lodge, 08811", 4 },
                    { new Guid("ea89f31a-3c42-47d6-b41c-3cf84806a717"), "50,041378;26,32748", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dooleychester, Chile", "Sasha Lodge, 590", 28 },
                    { new Guid("eb7801c6-70ce-4130-bb50-1674577a492c"), "48,102436;26,208485", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Preciousview, Portugal", "Darrion Circles, 0707", 79 },
                    { new Guid("eccd73db-e9e3-43c6-a35a-d90f343119ec"), "48,89883;23,998693", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Keyshawnhaven, Guam", "Valerie Trace, 49642", 21 },
                    { new Guid("ecd0427d-a217-42e9-9854-6ae6cfed4166"), "49,310146;26,356638", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Jedidiahton, Saint Barthelemy", "Dickens Light, 28776", 180 },
                    { new Guid("f1cc7b79-bc4f-431b-b974-245c6eefe571"), "49,192608;28,765778", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Kennedy, Anguilla", "Ashton Track, 9566", 73 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("f6e807e2-f5b6-45ce-b35b-1eb74ea80ff8"), "48,646343;23,653286", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ziememouth, Saint Kitts and Nevis", "Berniece Shore, 275", 95 },
                    { new Guid("f7a577c9-b6ab-4d62-bf7b-3f5385b2f9d8"), "48,170746;30,880772", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jakubowskiton, Benin", "Kilback Island, 4431", 63 },
                    { new Guid("fa876222-dca3-4d85-9d04-1e56fa4cb694"), "48,36763;23,20003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brucemouth, Netherlands", "Cristobal Brooks, 027", 104 },
                    { new Guid("fa965852-0681-416b-ac4d-13b8e2020248"), "48,861195;25,931795", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Maybelle, Chile", "Jamel Knolls, 72094", 194 },
                    { new Guid("ff8146e6-bdab-415f-bd56-464d9dac31b6"), "49,825375;27,406504", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hershelmouth, Mongolia", "Wunsch Brook, 80723", 87 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("0262c7ff-2a79-4f4b-a5fb-4224aa895fbd"), 11, "48,905334;30,276371", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Effieside, Kazakhstan", "Brown Squares, 11932" },
                    { new Guid("03ef044e-4632-48af-b4e8-69bf46a3121a"), 78, "48,561485;23,04122", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vinnieshire, Albania", "Littel Path, 80993" },
                    { new Guid("0819fe50-9e48-4898-8e8e-7f3703dae38e"), 79, "49,03788;26,059992", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Berthachester, Nauru", "Jasen Station, 830" },
                    { new Guid("08351e4a-19ec-4446-a7a9-60d09a91b691"), 86, "48,954243;26,981022", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Max, Reunion", "Streich Crossing, 227" },
                    { new Guid("084c80ae-70aa-4141-8807-23222e5b77a6"), 151, "50,478764;29,52374", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Littleport, South Africa", "Jacobi Inlet, 90373" },
                    { new Guid("0a7e1666-0d2b-46c0-8056-4eef8a7d2305"), 118, "50,042995;27,394123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "D'Amoretown, Bahrain", "King Knoll, 5722" },
                    { new Guid("0db0af1e-81e3-4e43-9736-14a217c277f9"), 144, "50,979053;25,03098", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Handhaven, Uzbekistan", "Reilly Brooks, 46995" },
                    { new Guid("11a92440-a056-4bd0-b4cc-8d843e1e37fb"), 42, "48,9257;24,467806", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Westleyland, Spain", "Arlo Avenue, 10092" },
                    { new Guid("1326662f-2906-4dc7-ab5c-71255720b0cd"), 65, "49,972233;27,599203", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cruickshankton, Nauru", "Johnston Pine, 35624" },
                    { new Guid("18319467-ad72-43e5-a5cd-e716ae0eeab2"), 47, "48,764885;30,042267", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Ozella, Singapore", "Bednar Falls, 550" },
                    { new Guid("19c3b613-afe6-4153-990e-6837d58ebf45"), 28, "48,876152;28,172346", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kilbackside, Guyana", "Mosciski Port, 954" },
                    { new Guid("1a1ef2f3-5c63-462b-84f3-3c1b0db18c2e"), 200, "49,99539;24,33286", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Clifford, Colombia", "Lang Square, 118" },
                    { new Guid("1ce02912-486f-48f9-82e5-d6b8488f1d83"), 107, "50,182438;26,113838", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Wilber, Niue", "Chloe Garden, 889" },
                    { new Guid("1f56e800-5509-4a2f-b721-7c9f47efb6c9"), 108, "49,348373;24,250364", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Twila, Saint Pierre and Miquelon", "Edd Unions, 3570" },
                    { new Guid("2157ae33-d03f-41dd-acd9-477243c3885e"), 139, "48,020428;25,72558", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Friedrich, Guyana", "Emard Crossroad, 93152" },
                    { new Guid("21da7f15-46b9-4c2b-8bdd-9babc59e8214"), 43, "49,99485;28,741468", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Cecile, Eritrea", "Edmund River, 7987" },
                    { new Guid("22985d54-6cae-41b2-bd21-29d0216a0588"), 77, "49,18565;26,626585", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Artbury, Northern Mariana Islands", "Tomas Fords, 411" },
                    { new Guid("22995ab7-3d33-426e-b1a1-cbcd4da77d6f"), 4, "48,366207;24,427975", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dellfurt, Faroe Islands", "Turner Brooks, 62915" },
                    { new Guid("23003272-4c2c-4a3c-b9d6-1071d0440ba4"), 173, "50,44432;24,344631", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kathrynside, Morocco", "Hank Orchard, 3086" },
                    { new Guid("231ea1f5-f689-4181-922f-26e6a3e93db0"), 80, "48,512524;25,395044", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Heaneytown, Barbados", "Halvorson Course, 4737" },
                    { new Guid("23bbfa06-c13b-4d7f-9cf4-e8a427a420b4"), 47, "49,05325;24,755772", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Chadland, Ukraine", "Gottlieb Path, 08233" },
                    { new Guid("290ec69b-f888-4a8b-91a4-5359b3d120d4"), 59, "49,627274;30,247564", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jaydonchester, Greece", "O'Connell Landing, 5687" },
                    { new Guid("2b08b372-8d32-492a-b2bb-bfb75caf3e0e"), 21, "50,174313;23,231705", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Elody, Saint Martin", "Koepp Glens, 974" },
                    { new Guid("2c52f202-8563-40e7-ba7d-0d51878c6d57"), 99, "48,623463;27,213665", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Erwin, Vanuatu", "Reichert Gardens, 00515" },
                    { new Guid("2d8cae92-0585-4cf7-ab6e-fb62072af2bd"), 188, "48,35135;26,290895", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kennithfort, Antigua and Barbuda", "Marquis Turnpike, 39235" },
                    { new Guid("2e909be4-e4a1-4f6e-aca2-6e6761fe7e58"), 36, "50,19069;29,041784", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Boganshire, Bulgaria", "Aniya Walk, 2017" },
                    { new Guid("33bf0835-84a2-4967-91fb-d43e6679f274"), 153, "50,803013;23,004267", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ardella, Central African Republic", "Schmidt Plaza, 860" },
                    { new Guid("36e14757-5570-4914-a823-dea6f3d11ea6"), 46, "50,282413;28,795145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Owenchester, Estonia", "Kassulke Lake, 572" },
                    { new Guid("3c77bb95-0b00-49b7-9eae-6ebfdf353f50"), 81, "48,95109;24,165302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Kaycee, American Samoa", "Sawayn Roads, 2462" },
                    { new Guid("3e703e0f-df3d-4cbb-82d0-0cf2d5746276"), 63, "49,45683;30,58865", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Karina, Lithuania", "Jaren Terrace, 11092" },
                    { new Guid("42a2198e-7ce4-4e0c-9509-f8623eddc604"), 40, "50,094074;25,7538", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Ed, Nauru", "Oma River, 08703" },
                    { new Guid("43b70662-e5d4-4466-9c90-92c6bd2dda28"), 158, "49,39649;30,499308", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Yostside, Holy See (Vatican City State)", "Delfina Plain, 09562" },
                    { new Guid("45d22689-c9e5-46df-b7fc-acaa6cfb50c3"), 165, "50,64612;26,787489", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Rolandoton, South Georgia and the South Sandwich Islands", "Verna Mountains, 99126" },
                    { new Guid("496a4f63-3756-404b-a8ba-ef60b72fcbf4"), 142, "48,25131;26,380972", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Blakeside, Brunei Darussalam", "Stamm Estates, 578" },
                    { new Guid("4988960d-becc-479b-9b08-e2b5291a1be4"), 43, "49,84989;23,925388", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Nola, Rwanda", "Schulist Vista, 258" },
                    { new Guid("4abe1149-79d9-4a27-ba94-a27517665aea"), 110, "50,03963;24,87884", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sanfordport, Wallis and Futuna", "Anderson Underpass, 476" },
                    { new Guid("4b56d367-e3ce-4651-90db-4d81afcd29b3"), 119, "49,535275;24,00586", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Feestton, Gambia", "Manley Cliff, 22060" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("4e1c662f-1d4e-446d-a4d3-aaa3ca688555"), 37, "48,398693;29,416464", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Elisabeth, Puerto Rico", "Aniya Well, 0159" },
                    { new Guid("50c7cccd-6a05-44ef-b737-779332489891"), 83, "48,313217;29,818062", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Anthonyberg, Switzerland", "Turcotte Centers, 279" },
                    { new Guid("5392c88f-6570-4af9-bcd2-e4c0f36bcc7f"), 77, "48,133595;30,46818", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harrisonport, South Africa", "Giovani Rapids, 8500" },
                    { new Guid("5514a07a-cde9-40ba-886e-6190a6e66828"), 200, "49,080345;29,959421", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Timmothytown, Morocco", "Chanel Ports, 426" },
                    { new Guid("56342556-fb66-4baf-ba78-a722b4fb2ee9"), 161, "50,31753;26,328314", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Louisaside, Grenada", "Kutch Forges, 041" },
                    { new Guid("5698af2d-724c-41f5-a7f9-6f50d91519c0"), 134, "48,29312;23,340395", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bransonmouth, Palestinian Territory", "Hettinger Throughway, 26794" },
                    { new Guid("5d01d1ef-d700-47af-bdc7-20c07deba6e7"), 60, "50,967514;29,474455", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trudieville, Suriname", "Filiberto Inlet, 6969" },
                    { new Guid("5eecb6ab-859d-46bb-bb5e-45b7bab115c3"), 43, "49,341812;23,814764", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cartwrightview, Uganda", "Emilie Street, 116" },
                    { new Guid("6a0067c3-f5b5-46cf-b652-d68c6bc5edd0"), 85, "48,843464;29,325665", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Treva, Republic of Korea", "Keshaun Turnpike, 74741" },
                    { new Guid("6aa1c24f-d9b8-4e3e-95ed-effe5dc4d0f9"), 80, "50,57032;25,08275", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Mellie, Macao", "Price Squares, 018" },
                    { new Guid("6ad5a9a7-d4ed-41a2-a49d-e4671920d081"), 89, "50,020466;28,192608", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jakubowskihaven, Bosnia and Herzegovina", "Russel Motorway, 69676" },
                    { new Guid("6bb5f4d1-c0e8-4bc3-a9d6-4f4bef777bac"), 135, "50,84709;23,388443", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Raumouth, Mali", "Stella Glen, 815" },
                    { new Guid("6cc07e92-5e0d-493e-8865-e59f23f4a434"), 72, "48,741512;23,897627", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Considinemouth, Taiwan", "Walter Streets, 7750" },
                    { new Guid("77e5c3de-24ef-4605-a0bf-ec7b78e9d05d"), 141, "48,594097;24,325068", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Aliyahview, Spain", "Powlowski Underpass, 768" },
                    { new Guid("7a71bc2c-7324-435e-aa6b-f1aaf4da583d"), 187, "49,847664;24,524036", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Alfonzohaven, Anguilla", "Rosendo Crossing, 8792" },
                    { new Guid("7c74d06c-f48c-475b-a6d1-56222ddea976"), 76, "50,87034;27,102373", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bradenside, Egypt", "Marks Station, 42694" },
                    { new Guid("8085e6ba-7732-4c92-a6bd-b07d9d216592"), 72, "49,499336;29,8948", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Annalise, Micronesia", "O'Keefe Radial, 1517" },
                    { new Guid("8145cf90-1497-4a2b-8135-8bece9447dfe"), 191, "49,150803;29,596998", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trevabury, Jordan", "Bergstrom Forks, 3817" },
                    { new Guid("81ae5d45-5e7f-4ff2-b21f-25f52658e81a"), 140, "50,8957;24,819185", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brodychester, Belarus", "Bins Rest, 323" },
                    { new Guid("8387d90b-09cb-4c02-a0ab-94567b81b85b"), 30, "50,105583;27,073416", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Lexie, Tonga", "Georgiana Square, 8563" },
                    { new Guid("8682861e-62d4-4f3c-9116-89ff58dc9316"), 64, "49,05592;25,735111", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mayetown, Antigua and Barbuda", "Feest Branch, 02155" },
                    { new Guid("87d2c9fc-b668-4aee-b5c9-b2b378c51ba0"), 34, "48,56547;26,584679", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Kristofer, Slovakia (Slovak Republic)", "Champlin Island, 450" },
                    { new Guid("88e85aa8-9feb-464c-8742-562a858e0ad2"), 83, "50,068188;25,809725", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Favianbury, Saudi Arabia", "Hagenes Stravenue, 872" },
                    { new Guid("8a2e927f-6e0e-43ef-866c-670f7e040a1d"), 70, "48,201576;24,52127", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Jarredview, Belarus", "Cathryn Square, 482" },
                    { new Guid("90f02f9d-12e4-4afa-b256-d6a492a69ddd"), 2, "48,78874;26,370516", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brownport, Burundi", "Halvorson Rapids, 9873" },
                    { new Guid("93a1145c-66ef-4d56-8877-b1db87bac277"), 193, "50,66986;26,33908", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Mafaldaport, Bulgaria", "Wolf Forges, 339" },
                    { new Guid("972eed91-068b-4f2d-bbf6-537c3119b056"), 51, "48,56123;25,734325", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cormierburgh, Armenia", "Schmidt Manor, 64984" },
                    { new Guid("99d60f04-abab-4cee-bd3e-59c9fc8be65f"), 152, "50,83493;26,41162", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hermanview, Canada", "Fritsch Track, 56569" },
                    { new Guid("9cc8d25a-9d12-49da-a96b-076b287c32dc"), 147, "50,96051;27,461557", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Hallieland, Costa Rica", "Christiansen Lights, 3821" },
                    { new Guid("9d4af04c-5862-49a8-ac66-414ef3ff2fac"), 176, "48,6985;27,698421", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Bertha, Slovakia (Slovak Republic)", "Erick Mountain, 03250" },
                    { new Guid("a137e86d-71f8-4ba4-a35a-9db6ba84c28f"), 169, "49,40582;27,076912", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Tressieview, United Kingdom", "Daugherty Isle, 29261" },
                    { new Guid("a308b4dc-f76a-4980-b64d-b12ef96fd4c8"), 157, "49,937115;24,258356", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "VonRuedenshire, Syrian Arab Republic", "Schroeder Rest, 7485" },
                    { new Guid("a580a93a-81a9-4559-8156-c3fd2cbd07f1"), 90, "49,168427;28,332804", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tyreseburgh, Belarus", "Hermiston Ports, 22626" },
                    { new Guid("a92aed91-69ee-4487-a619-ee12174958ec"), 70, "48,50676;27,935654", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kshlerinbury, Holy See (Vatican City State)", "Cristobal Ports, 45804" },
                    { new Guid("a9f673a5-b6b0-4f0a-9006-336478eebb0a"), 142, "48,62716;28,111948", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Patriciamouth, Congo", "Kuvalis Streets, 075" },
                    { new Guid("ad23cb16-77f1-418f-bbf2-d53691045256"), 10, "48,61643;29,416214", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Nora, Somalia", "Mckenzie Port, 8471" },
                    { new Guid("ae6321e4-141c-4e28-bea0-72aa6d0a8e14"), 199, "48,68852;26,715351", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lavinaland, Macao", "Runolfsson Stream, 55907" },
                    { new Guid("b05d306e-88aa-4438-977e-5c92cb46b526"), 195, "50,298923;27,866047", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Myrlchester, Jordan", "Kamron Gardens, 841" },
                    { new Guid("b1ff9cee-63c5-48c6-ae56-6ac5a2b10ec7"), 46, "50,32235;26,494349", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Jenatown, Gabon", "Lambert Underpass, 84937" },
                    { new Guid("b45cb1e0-4158-47a5-98ff-ffccd043c58f"), 12, "49,49789;29,683008", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nataliaburgh, Belize", "Sawayn Lake, 4216" },
                    { new Guid("b5af5d6f-c348-4d2e-a57b-f457eeba0272"), 175, "48,491585;25,035711", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Israelburgh, Barbados", "Hudson Forks, 4252" },
                    { new Guid("b5ed4770-7bcb-4bf4-820a-1e8944238281"), 170, "49,821125;25,443537", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Hillardbury, Guadeloupe", "Josiah Rue, 0168" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("b6cc10ff-f9b4-4fe3-9dc8-3ec3d3917d1a"), 80, "50,276787;25,678535", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Twilamouth, Mauritania", "Sarina Point, 814" },
                    { new Guid("bf892743-a92e-4da1-8a9d-cbe83c012890"), 130, "48,497375;23,762527", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Wallaceburgh, Turkmenistan", "America Rapid, 175" },
                    { new Guid("bfab8198-32bb-4332-aabf-475d472c00ba"), 200, "49,326996;27,860117", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Vanview, Grenada", "Nicolas Viaduct, 24112" },
                    { new Guid("bfba4540-802c-4742-a0d5-2d66eb7f6f98"), 187, "48,374416;30,378443", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Shannyport, Pitcairn Islands", "Grady Divide, 40967" },
                    { new Guid("cdecce55-f261-4c38-8c27-94f45308afdc"), 93, "48,89907;23,088186", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jacobstown, Georgia", "Mauricio Glen, 71800" },
                    { new Guid("ce8e0a14-366d-40ce-9a8c-8e03255898b8"), 171, "50,457073;27,266207", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Roobtown, Azerbaijan", "Jakubowski Locks, 236" },
                    { new Guid("d06dd21a-1216-47c9-8409-4a856add5d38"), 21, "49,917255;23,419943", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rosenbaumside, Micronesia", "Carter Corner, 7475" },
                    { new Guid("d740756c-f797-4d80-a605-2dbbd06cc3bb"), 21, "50,841637;30,63196", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stromanville, French Southern Territories", "Ray Roads, 25000" },
                    { new Guid("d8a3152b-88bf-4e7d-8e96-b93da618fe33"), 147, "48,737514;23,9551", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Eldonberg, Turkmenistan", "McGlynn Ridges, 189" },
                    { new Guid("da37e76d-d6ef-4602-b686-049b79812788"), 122, "48,51377;24,46519", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Legroschester, Bahamas", "Cummings Plains, 3404" },
                    { new Guid("dc0f2110-75f5-4f01-84bf-d2b61b3990f8"), 175, "48,53633;30,682594", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Ibrahim, Jordan", "Armstrong Avenue, 49615" },
                    { new Guid("e156bd23-8a3c-4f2c-b7d0-97872a127491"), 110, "50,78837;27,114645", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lindamouth, Falkland Islands (Malvinas)", "Gorczany Course, 3472" },
                    { new Guid("e22a3002-bb80-4643-a87b-551fcf4b8580"), 150, "48,723454;24,262735", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tristonside, Latvia", "Mueller Lodge, 65932" },
                    { new Guid("e55f81b0-1647-4944-b561-cae04d35e746"), 140, "48,009457;23,552141", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Angusshire, Iran", "Bednar Harbor, 14305" },
                    { new Guid("e6a32947-6ae0-46e2-9a7c-922c68a831d9"), 168, "50,660133;23,227177", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Alvahburgh, Mozambique", "Bosco Hills, 4567" },
                    { new Guid("e84e5692-6fd7-42b5-9bd7-b822a3453686"), 88, "48,355213;24,47694", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tessiemouth, Swaziland", "Neoma Fort, 7627" },
                    { new Guid("eee41809-ce5f-49a3-860f-846ac89968cf"), 41, "50,585503;26,628716", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Toneyshire, Swaziland", "Hailee Coves, 41809" },
                    { new Guid("f23c1b8d-f741-4174-a16b-b97305a90133"), 24, "49,058475;30,150345", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Lelahchester, Bahamas", "Kali Drive, 621" },
                    { new Guid("f5ac03b8-1576-4f58-9929-77c30a666882"), 35, "49,68119;26,27117", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sidborough, Chad", "Deshaun Ranch, 2360" },
                    { new Guid("fd57b679-f062-4c8b-b4dd-3d80a9cf6b93"), 132, "50,272934;27,590559", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Evelynberg, Chile", "Imelda Light, 49487" },
                    { new Guid("fff62fd6-bda8-468a-895a-0ec1d2049152"), 173, "48,107918;30,62972", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vernamouth, Guatemala", "Prohaska Flat, 8791" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("00a5f1c1-0c9a-4f61-8bcf-3560bf442fc5"), 491506251, 0.5838805523548350m, "MSRUmMApKYfDiqaQ8P1x39WhGws", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(3955) },
                    { new Guid("052944b8-638b-486c-b151-8f9adf6051fc"), 246064501, 0.2437640422393290m, "M9HPYjMGr3SRAWLhVz2mUZoqiB6QvJwx8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4635) },
                    { new Guid("0926aabb-81aa-4d48-9eda-a2cc3d9fa3f2"), 1661517615, 0.5355666012230m, "M43sQXq9nY8SpBg6t1iyUhJcKAC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4549), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4547) },
                    { new Guid("09d3cd6c-6fb3-442d-bf0c-a6c7703f4ac4"), 756961876, 0.1403165938855260m, "L2Cw1jqb8ndJyegptc7TZG9R5PXi3oASNW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4346), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4344) },
                    { new Guid("0ac8262e-9bda-431f-866c-05de16ab22da"), -1084868632, 0.204781602675190m, "MKjUkP83Yp42A7oVWZudsbSy9fq5hTx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4613) },
                    { new Guid("0bb3a8e1-00bd-45e5-9bac-f546e43f7d02"), 1674851671, 0.6092249472122880m, "MgYR39Na8Tw7uqDzHfFmoW5L1Jd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4061), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4059) },
                    { new Guid("0cd37b42-11db-49e7-9989-9df8e43955a0"), -1939695341, 0.6263537094590560m, "3rNdpRb3a2tCUicJPYXGyB1mS8eh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4662) },
                    { new Guid("1df72f25-29db-4d6f-ae43-7c470ee4cad0"), 1886795310, 0.5356515232822910m, "MaYf91NhyMK2o8T7nXDqez3ESiPWsr4Vgj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4762) },
                    { new Guid("287344d7-bb0f-464d-9982-14e68e59f7a9"), -1615691515, 0.9514288073136880m, "3rH24BiZaAzGmCT7NkvhtUS3DELdgRKsw8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4687) },
                    { new Guid("2f899236-9af8-471e-9df6-97b98df94132"), -1925156202, 0.6875360711375580m, "39t4fwLrnRjh8cSaUDxFAJV7WPupZQgieN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3815), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3813) },
                    { new Guid("2fb17af2-bf77-4162-971e-163078bf0d98"), 614129747, 0.7074123246010170m, "3a8feXgnyTLJvcP7HVdkoB3rWRx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3312) },
                    { new Guid("304f4c14-4446-403b-8b95-c73033e32ec3"), 91073655, 0.7730188019597940m, "LXq26voWDgsGdAKwQUirEPkzjhR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3633), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3631) },
                    { new Guid("314696ad-7209-416d-b232-96ab16985858"), 865125776, 0.02646651013331840m, "33noauEJXTh2ZqNG1AsS6Vg7RD9iHted", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4806) },
                    { new Guid("31768f31-34b2-46c1-93c6-0137b39e27d6"), 258200314, 0.5227916268934870m, "3ipLEQmotJgX9Y75znUbkP1uvSa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4037) },
                    { new Guid("3578c783-1832-4939-b5f3-a76b7c3eb51f"), -334785209, 0.6471887753091490m, "MgiRmafMWcdLoVYNnCS5wGrBp4bQs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4411) },
                    { new Guid("36d24745-0d75-40a0-8acd-ae18bd29f5d0"), 1424106518, 0.4905448159975750m, "LRDnkva73yxFHWCMre6ZXiJfQwLsN1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3066), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3064) },
                    { new Guid("37c8811e-3f75-4cc3-93c2-bf020723b573"), 1369533500, 0.9135945167748950m, "3ReEFTkucpMtUsdDf9XZxm3oKGaNBjw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3766), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3764) },
                    { new Guid("39cdd9e9-f06f-49d9-a16c-879179fd5a60"), -15487850, 0.2822948679856120m, "36MYkHDQs5E93oPBrTfwFKujpZ4y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2940) },
                    { new Guid("39e4a9d0-0d58-4ce1-9196-160f1e68b12c"), -847431076, 0.5512627708338120m, "LZgqdM4oBcSG2rAhvbUkReaip69tPK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4968), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4966) },
                    { new Guid("3af4232b-354f-4070-9b8e-b49a1ef91767"), 1596143650, 0.1732559330536920m, "MomtPCGufLF8eVKsxQ3jYaDnZAkXzqgy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5106), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5104) },
                    { new Guid("3b84d84d-1a08-4bf0-ae37-fe2b0a1be7eb"), 1220923410, 0.5042435969989180m, "LEAUc96eTusw1CDSZVjhYNbxtngM53dG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4456), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4454) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("3bd636c7-e218-4eec-9c3f-430c52f4027d"), -845558659, 0.5061205999605370m, "31oH2sK5YkDqZVb3MCFgAiePUwQJzmdfa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3792), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3790) },
                    { new Guid("3be45a10-f23d-441f-aef0-1923eb8adf11"), -661447434, 0.6238255619081880m, "MA4tQDKY7Gf2cgE6nem9Pvk3MT1pu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4498), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4496) },
                    { new Guid("3fcc5e44-eb22-4a77-8c1d-cf2316a3462e"), 864598406, 0.7851129809153790m, "3JmYZ2Rc5hous9SMzdCrynNBtD4WjPxkH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2845), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2808) },
                    { new Guid("423dfc03-0a2f-42b5-95a7-f4e57e16ec0f"), 535819665, 0.6199888833084820m, "LKwpqxkfzA9ZRct2TL67nJsy1XjBSErQa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3716) },
                    { new Guid("43e15563-ff40-4692-b904-0be69d42c476"), -556840554, 0.2957377454314790m, "3L4oxTV7RF1eEycUpgrjfHv2M9BaPdzi8A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3929) },
                    { new Guid("44d3a917-7f06-4b17-bbcd-ad5d5eb80536"), -379191656, 0.4387699930503310m, "MX13uNoLZEM97JgBCqU5dPwQmTbyVp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4717) },
                    { new Guid("46130f8a-1fec-4e23-8c4e-6424a6bb011e"), 1831789527, 0.2011528193552240m, "Myz1ETbt6RQhDXnpuK5Ucs8F7gGw3kAq2N", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5033), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5031) },
                    { new Guid("4e0f340f-2e5f-42cb-ac0b-8b7efd309e8a"), 148376410, 0.8076891841349430m, "M3V1Ehd5ptN8BPebSDFQrfRzgKZacAXiwk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3553) },
                    { new Guid("4f9274e8-ca6a-41b4-ac98-8352a6161e5d"), 941965670, 0.9510492509883660m, "3ZnXMVK4svpzrcbEtJj3FxoeQ5iD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3976), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3974) },
                    { new Guid("527e2567-1429-4991-80f5-d18320007038"), -818206211, 0.6712258104273410m, "LG8W6z7EUCf3vYTnmpZ5dJaDyMAcjtgw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3270) },
                    { new Guid("52e594b2-fa77-4c65-8e47-da18ddf713cc"), -713936636, 0.1278176775076930m, "Lo3CPaXWAcxLsUY9JwdiF1gbmkt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3431) },
                    { new Guid("5515544f-bca7-45d7-a4ff-082f6538dee0"), 411425761, 0.8384920752736310m, "3Cu7oK1Fk9eUsMPrSiThRZt6BXw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3858), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3856) },
                    { new Guid("5524aa3f-9c87-4878-97a5-1175c41edd3f"), 102224502, 0.9832960292171650m, "3jLzUsZk4RY3g2Au5Ncn8SKtrDyQ7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4206), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4204) },
                    { new Guid("57454b08-3275-4405-b56b-4590c530d047"), 1136267762, 0.3138149183536870m, "M8fy3ViYg1p2qrUHauS5KtjAX4vxWsm9w7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3410) },
                    { new Guid("576d4dcb-febe-469b-a514-df115f3315b2"), 336680052, 0.7699791920917470m, "3NVFkjzgBMSwre7UxEb3uKpvdn1G", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4291) },
                    { new Guid("590ec811-9309-43e4-a7ec-f02a9dfa7b28"), 362272720, 0.8036835909731930m, "LtdWNM3UKnagAyhPZEqYDvXbSeC2cz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3951) },
                    { new Guid("5a30302d-301a-4b5e-a266-8649993be1e4"), -1014769773, 0.738655516212860m, "3dpEPXSBiTWn6zmf4xauRH3gjqAY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4947), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4945) },
                    { new Guid("5f77c254-4119-47e9-ae4a-e9270b25efb0"), 331967161, 0.9180827056278560m, "MQ9oE2rXBbLCJchs8VSH4gMvTW1Um", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4009) },
                    { new Guid("64575632-2416-450f-a8a3-50c94b33a41d"), 1337027498, 0.09811668027846340m, "34d8taRpb3inzFfGSgjUqsQmN6v", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4311) },
                    { new Guid("662092d9-5441-44d2-8cfa-e326051a990d"), 670357876, 0.6523304737649450m, "Lp9L8RS1v6nyhwqe2XTfKboV7Jd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2772) },
                    { new Guid("6adec966-aa7e-46a4-b22b-0a2aa0f8249f"), -1295119590, 0.4726371432643670m, "MAURdowJBxZt6rNFvhusafVHzXW4DK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3365) },
                    { new Guid("6f2b92f5-6297-4b94-a1d4-4b32b1019077"), -1369664159, 0.8255080852682780m, "M9tydWC4G7o2MzNL5E1xr6emQDAXnKqh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4850) },
                    { new Guid("703d7814-9562-46fd-a7fc-d34713e0a1e8"), 1198837349, 0.8915140826886120m, "3FM9zEUs8VwHRgfGNyecX3qnPTa1A4D", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3180) },
                    { new Guid("731532da-5a34-4f69-bdad-b61692485295"), 912440261, 0.3118290923755190m, "3qQxBugeTUD6HhyRvKkSGCLnY3Fjpt27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3455), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3453) },
                    { new Guid("76f5d120-2c71-4990-ad19-174968dc7346"), -580248550, 0.3455950073601710m, "3DrE2MpVCSXw3TWbqz4tBHQ7Lg8R6Znu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3130) },
                    { new Guid("772f30f6-00a1-414a-9297-2b72851ab4b4"), 989203882, 0.09101140543826170m, "Mx4b7sN8apcGMDEtTUzAr9jLVSuY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3673) },
                    { new Guid("795329ae-f758-4c80-bc2a-9c7a537de475"), -1514389421, 0.6574713224677850m, "LiznHNEZ9YBS6XpxtgmL1whVCcKe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4390) },
                    { new Guid("79dc7e87-f14c-4c5e-9989-157c86df35bf"), 1528776785, 0.3832571077184630m, "MTBEgc4VtqFmapNy7ZXR3CSwL1Krb2U", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3738) },
                    { new Guid("7a1162dc-45b6-4254-acff-5e6131c24a65"), -476312981, 0.8572734292584140m, "3rA7CzeosnaKcMSQ2ihg6mP4ZYRvqkd3T", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3879) },
                    { new Guid("7d387bc9-8164-435e-b6ba-fba1f712c6fc"), -1341919425, 0.5056450071957310m, "3odXtNpGni8J25rsWD9ZwQLhSeYu3Bq", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4828) },
                    { new Guid("7de51b68-91c9-40c2-94db-0275e11d831e"), 369281364, 0.7712439966365140m, "Maqwrejo56QYV9upSRHGh7cULNA1XD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3899) },
                    { new Guid("7f7566ba-c095-4dea-ac8e-55802a8c78ed"), -593271017, 0.808666068126910m, "MB5Uiy4q7rFGMnKv2JtVfphcCYEg6NP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3086) },
                    { new Guid("81e61668-34e3-4467-ab3f-f17987495489"), 1185570918, 0.178020671145560m, "396Q3bgA8FwzVeLvjMWod2XcRfGs1p45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4528), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4526) },
                    { new Guid("829f3ff8-6ec2-4f7b-95fc-e4c395451e3d"), -862897794, 0.02186197284881520m, "MsKi5WcVvrqbypNe376hSd9kPznwZYTQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4082) },
                    { new Guid("8822e674-8d1d-472e-bc1d-1da6ee03231a"), 2017452280, 0.2454870048337780m, "3cpbkEqJtoghuBP9VQmWKL7rS2H84YR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4591) },
                    { new Guid("8877505c-813e-4920-a87e-ba93be06c4e0"), -919774461, 0.03479734796950010m, "M7E9YJxMFgvbpDuCHk3StAjin5UVRqc8r", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3998) },
                    { new Guid("891a8451-ccb3-478a-b1eb-af6215feca96"), 479244109, 0.5319297118269780m, "LQbZgRh9yeD2rBmaUuJopM3v6zAF8T1N", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4107), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4104) },
                    { new Guid("8e7c5daf-01d7-4193-bfb2-b03db3de9916"), -2119379378, 0.4502619747864870m, "LBDALp17iWerg9X2MSatEs3bG8KxcTJNvo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5128), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5126) },
                    { new Guid("92543f7e-a69d-4cc1-8eec-b778ef829cc4"), 1295005281, 0.3255284085551250m, "3Lu2n4BfKdPT1a3thZNX5i6yWoU7Jw8Y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3390), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3387) },
                    { new Guid("9b695527-6f12-456a-b52d-82af6b0f7f9f"), -715286733, 0.2316146197277880m, "L6owZGT39DQFC1k4ciHULqsMhdAbRgYP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3021) },
                    { new Guid("9fb89443-70fd-4cf6-9792-3530c59283e7"), 290374370, 0.3551833494248930m, "MLs5UR4DMVPXJcjxEharYpkKAtoHGW7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4987) },
                    { new Guid("a1852d4e-f6d2-4a67-a5b5-e0e3128929b1"), -1816150915, 0.4609400988141230m, "3neW89SUktg6vGch5V4ZQBAs7Cz2PE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4872) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a185e818-c532-4236-8e6e-567b47494cda"), 1647222914, 0.9277743480859140m, "L9vuwghKBtfnHTrdsDqxPN3EUkjL5b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3610) },
                    { new Guid("a4615e8c-dad4-447f-85b4-2261facac8ce"), -611615629, 0.9021034622532630m, "MCL6xcRS9BZMrnHNPqiDWfuTX5yw2Jta", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4571), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4569) },
                    { new Guid("a75a0797-480e-4a5d-b8fd-f9d65c897ab9"), 314797449, 0.2555324503664430m, "MXHpQTnAw5z9MWrPt6JgY3iGuUZeCEox", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3292) },
                    { new Guid("a96c982e-3910-4e86-8da6-ad66177fac1d"), -987019384, 0.7062627574583480m, "3m1Rbz6BeWTGvZoHELC4DnJuwQSrAN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3696), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3694) },
                    { new Guid("ae02935b-4420-4284-965b-11c003b5375d"), 740979114, 0.9629557306606190m, "MqFnSCw5PRbHVuBk6z74spxdKhyr9L8JQm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3248) },
                    { new Guid("afb64c2f-50c3-4324-a371-f2161a078afa"), -388910217, 0.5660252156469720m, "LXvAVoiHNTxRrFuhd6tsYnpSDbJLWUz8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4183) },
                    { new Guid("b33c9298-b89a-4ab4-8039-a6ecc079f430"), 295340998, 0.6631018907661690m, "3E7pkJvo38VrQWDXNqRsAYm5B1CP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4903), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4901) },
                    { new Guid("b6255f1d-1e8c-4de3-9fb2-06cb06d7bee9"), 274988287, 0.7441844656825110m, "MGJtMraxfTqu9bHYieEd5QojwR2ZyhgBUz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4158) },
                    { new Guid("b924b7d7-b51c-4f3c-8770-0de2e90bd8ae"), -60257848, 0.3570332710752730m, "LcabnRArUpqiQKFyhHk9YSPmv2xd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3652) },
                    { new Guid("bc009f02-8fe6-4a0a-a593-fd81364707a8"), 1310498591, 0.3153775349537770m, "L8vG1mekBwnH3iYt9gKVxzEoTad4F2f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3001), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2999) },
                    { new Guid("bd698c2b-4595-4cf8-90ab-cb875ba4275e"), 1768419871, 0.2982172666410320m, "MdEmWncw18k6FDTKi4ZyCzaQSMuX3gVG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4370), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4368) },
                    { new Guid("c052d71a-25a2-4079-a911-ffff4d967d91"), 213505063, 0.1975363674175140m, "LVgT1EdWnPQCStUip8cMRHhauF736eA9X", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3108) },
                    { new Guid("c068f463-ab65-4c57-8e4c-5fff0c70c374"), -716286262, 0.7150146696284140m, "3PSgLQ1fo8exEwuK9kRCdZD7FnN2Xzs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3043) },
                    { new Guid("c4585215-dd41-4d5c-80ac-69d418c4ed4f"), -975177188, 0.7600415155586670m, "MXQMqmSUEkH7FyKV3oP6Ldu1jebpBz8AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4924) },
                    { new Guid("c56a8f75-8d75-4d72-993d-0d179320aaec"), 317024087, 0.7323379279659740m, "3HjcvJNTB672fhezKYWQngoA135SX9t", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5008) },
                    { new Guid("c83b1ddc-1d31-4245-a557-3272b9f8fee9"), 1234225321, 0.9118283729124560m, "Los18rGnigKPyw6pVEjYL2hZmxqRc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2872), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2870) },
                    { new Guid("c8fe7412-eb64-4012-9a6a-d58f9ad04a6f"), 1019696287, 0.5760473305477050m, "MwahEyYGJs4KWt8FeQMZRrdqTfCSnDz9B6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3341) },
                    { new Guid("ca9955c1-1401-4237-970d-b160293a6fff"), 1418143622, 0.1053302121707920m, "MPFxqUmGvN6Ho5YaBZJ2udQirkEw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5058), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5056) },
                    { new Guid("ce4e99ad-2a7b-4a29-8fab-090993c33ea5"), 167200788, 0.09184477238265750m, "3yveKSt298CXVBZ3zHfuTG1wQFph7E4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3585) },
                    { new Guid("cfcd3d33-9406-4193-b386-c846bf43cf65"), 2100382103, 0.5554223270027510m, "M4j7VH19JBgWNpZaLnEt5uMqdwQYsmPyS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4227) },
                    { new Guid("d2939cff-1c7e-4a56-8942-a7b8399d2084"), -379500609, 0.161144560756230m, "MpZW38PqcYxkEoKRes951uUAhBCDw4NJyH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3228), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3226) },
                    { new Guid("d4a9c60b-2121-44be-bc41-374b83029d39"), 173663914, 0.3285329960757150m, "Mxruo6cLTfSs5iGjDQhmNn7PdCyM14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2609), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2544) },
                    { new Guid("d4d30cb8-c7bd-4c5a-ae06-164495a22a67"), -1593736821, 0.5636013876216210m, "LuEd96mp75VSqjbDTJFAKUoCYHzxBZwisR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2895) },
                    { new Guid("d704a922-d383-4566-8b1f-5eece4d85805"), -2025981518, 0.1879065972076180m, "3JVTd29jp58kNrh7BPZAmSGDixeyCM1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3837), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3836) },
                    { new Guid("da83b3a8-6199-49c1-b756-65a7082ce3d6"), -1958481229, 0.8470765861638050m, "Mmr6y3WMEinkg7LSAQw8zxNhpHdRaJZj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 6, 4, 12, 51, 57, 293, DateTimeKind.Local).AddTicks(6843) },
                    { new Guid("de9415e1-466d-45e6-8145-85ec077aeffd"), 245324504, 0.2174468134915160m, "3FXz4yudeVbco7S1K6gmsrBtMkT2Zahp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2920), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2919) },
                    { new Guid("df1ff5b4-4902-41d8-a174-2a06fc1ea4fb"), -663710955, 0.1968588178014830m, "3Q8VoyfLhegCYuD7cN1ARJpZBEa9b4SdP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4249) },
                    { new Guid("e453022a-5afe-4aea-b689-ca0ba6c69777"), -1562602884, 0.1410463424596560m, "LTGCJ1wADs69mLZzoBMqU5xr2cWginu7Fj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(4021) },
                    { new Guid("e51b94ce-1017-4a85-949b-bccb805533a5"), 1972534382, 0.3514472500188360m, "MqMx57aysiGtF1j9XRPEDCpWKv342m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3202) },
                    { new Guid("e72f5045-8335-400c-96ed-251bf6549105"), 1087182006, 0.8488660229422570m, "L5fxpDXraiqBZAvhtn1zEQFe3k9J7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4271) },
                    { new Guid("e9b810cd-124e-437f-97fa-5e5d707b12eb"), 2091672369, 0.6634607281973490m, "Lp9J67tZUwRNfydvaQBjb8snHTWk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4476) },
                    { new Guid("ec61ebed-0065-4ba5-a2c4-41602315a635"), -1470174445, 0.7139443892110490m, "3S6vJg8M7TPejdxVfRY43imyWACuHzEBX9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4784) },
                    { new Guid("ee7f41e0-7e98-499e-9156-751fa2902846"), -773606740, 0.8847355951636160m, "3NRK5nPiyxajqMurUbXfYJphEszmewT6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5084), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(5082) },
                    { new Guid("ef044963-e9ea-4e28-9379-71470dfdc03c"), 570105158, 0.4805206318275530m, "3tXcG2CqPeVjS9Zv4kAofR3iFpsKBMJW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(2977) },
                    { new Guid("f57edde3-e103-4ee1-b0f3-811f354a0bb6"), 247417632, 0.9434526544472840m, "3P3SC1rhdK9jngu4iBt7yWUJGoZYz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4431) },
                    { new Guid("f76762fb-935e-4bea-aef3-d6acc4369fcd"), 2036832045, 0.4028492981609780m, "LohRHwu1CWyk9am5QLdbGt3JjfK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3475), new DateTime(2024, 6, 4, 12, 51, 59, 818, DateTimeKind.Local).AddTicks(3473) },
                    { new Guid("f8e24f77-e3f7-4c0e-af14-01a6a5bf1bc4"), -784321881, 0.5955195408620920m, "3GjkvgXiMUKdb65xQEse4zuAY9CL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 6, 4, 12, 51, 57, 294, DateTimeKind.Local).AddTicks(4740) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("01a8bd37-aff4-4aac-8218-b782c941985f") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("05fb67eb-3b60-4c93-bf80-36153be08871") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("114ac41c-5eba-4152-8f7e-622356a03762") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("1ca2e699-11df-445a-8084-51598bee7020") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("26e9f9a9-c77f-4f47-b594-e602be058706") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("285d8d29-53de-4979-a403-f61b887fa207") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("316bd6de-f98f-4240-856b-7b943204b4fb") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("354e9bbf-de43-4345-a871-f0af96ec9410") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("364df856-5357-4366-afda-cf52f25f1325") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("4285821d-9d8f-4943-b663-27adc015a9c4") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("431cb355-ae94-49cc-882c-971e60381b53") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("4390173e-3194-44b0-9f5c-e816c829e49d") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("4860b124-2e67-49cc-b664-135729261ac4") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("4bc48bed-c113-458c-8a12-8f12565a542b") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("60f7f230-ff82-425a-a6c5-cc5156098000") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("71978c89-b953-4ec5-98a8-ab384223de1a") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("787d2d2c-d05b-4935-906f-090d713b622f") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("7b8e2086-2aa9-4256-9444-793523c7a280") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("82d8841b-b98c-463c-96d0-9378cf908740") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("8576464a-f366-4076-97bd-00c2481b9a38") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("a0995ae3-517f-4476-bad0-18fca309cda5") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a42b469c-fec8-4056-a4de-926b01b7f202") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("a8115124-4280-4a52-8af7-cb635f456958") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a836bc35-12f7-485d-861b-ad1645878c24") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("b74d612a-560a-493f-9b9a-e7d76b857600") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("bea80970-74bf-4539-a300-cbbac8625744") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("c187c610-03e7-4305-96e2-96f776a463e0") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("c32606de-b224-4989-bf52-f8b3cabea595") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("c41a987e-114e-4968-aa63-744e27096322") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("c73bd258-469c-4d46-ad89-cd1119310c49") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("e8293c7e-c598-445f-a509-d9123149ec52") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("ec149744-9128-4f41-875a-1c96bf1c851c") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("fa64f167-af58-425d-8dce-93642bd7650a") },
                    { new Guid("980dab90-84f9-40a1-bb3d-fcbdc58fe35b"), new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("9e69c054-44b8-4430-b63e-977dcb3bfaf0"), new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("cdad847f-2c20-458d-bb39-e52e01f7944c"), new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0016b825-73bb-46ba-8e5a-96dd66bdf2ca"), null, null, "Toy.Stoltenberg@hotmail.com", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("0019b95d-68d0-4836-8c99-7098386d56a7"), null, null, "Sibyl.Grimes30@hotmail.com", false, new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0") },
                    { new Guid("0063957d-b02d-4241-834d-1e9a2ae4a77d"), null, null, "Devonte.Herman74@hotmail.com", false, new Guid("4285821d-9d8f-4943-b663-27adc015a9c4") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0091531d-1201-400c-a736-8e2983a34c0c"), null, null, "Leanna_Considine80@gmail.com", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("0116f413-6db5-423a-8ca3-e353dbb4f87f"), null, null, "Eusebio_Mohr4@gmail.com", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("01533fb4-617f-4136-b435-3a12980058ba"), null, null, "Kristofer_Rath53@hotmail.com", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("019d5244-8297-4b71-b9af-89aa7825ec8c"), null, null, "Vada64@yahoo.com", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("02625dd0-1a51-4e6b-8c13-592da912036d"), null, null, "Ethan.Jacobson26@yahoo.com", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("02979dec-8a29-422d-b537-ba6ea1b15ad3"), null, null, "Oleta_Dickens18@yahoo.com", false, new Guid("8576464a-f366-4076-97bd-00c2481b9a38") },
                    { new Guid("02a162b9-24c7-46cc-a736-68a4c75a7406"), null, null, "Jennifer_Lehner92@gmail.com", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("037bd495-1a5e-4451-95a5-7126b5ef6cd1"), null, null, "Rory76@hotmail.com", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("037cbcd8-3d67-4eb0-b7a8-d762e66f90a4"), null, null, "Andreane.Bahringer@yahoo.com", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("03d8f013-5aab-4f8a-a758-9006e0666aae"), null, null, "Valerie.Zieme@yahoo.com", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("042d09d3-5c0e-4492-a9f8-d53fc531b28d"), null, null, "Anabelle.Yundt@gmail.com", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("047e316d-f7d9-4e9e-960e-b672d5f66e0f"), null, null, "Mallie_Schiller37@gmail.com", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("0485aba7-11d6-4718-b384-0e2879ae83a1"), null, null, "Edmond_Wisoky7@yahoo.com", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("04999271-28ed-4494-80a9-e6fe51e33db1"), null, null, "Krystel.Yundt22@gmail.com", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("05de8428-dca8-43b2-9cdb-bc1ca4ccf0d5"), null, null, "Jimmy_Morar20@hotmail.com", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("0617ce5b-5c75-43a7-93ed-102ae3e5525b"), null, null, "Lysanne81@hotmail.com", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("0639852a-3883-4583-bb58-da57fb3feeae"), null, null, "Durward40@hotmail.com", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("0675470f-df26-42e5-8f0b-fff7b86088fd"), null, null, "Jana.Streich@hotmail.com", false, new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc") },
                    { new Guid("06cb5c0d-afa9-4d34-86a1-bb99c18ffcfe"), null, null, "Gerhard_Conroy@gmail.com", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("073efada-ca80-46a4-8e7f-64403552a108"), null, null, "Noble11@yahoo.com", false, new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0") },
                    { new Guid("07867497-6123-41b9-9fe6-760d5a15594b"), null, null, "Kendall52@gmail.com", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("07f5f66d-ab4d-4c85-85b7-f56d9f87322b"), null, null, "Brooke.Koch@yahoo.com", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("082c160e-f7e0-4da1-911d-23351daba02b"), null, null, "Grayce_Feest@gmail.com", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("08a5d9fa-be4e-44e8-96c9-d0b6ac3c3936"), null, null, "Kasandra_Gottlieb@yahoo.com", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("08c36467-22cd-4189-86a8-6a5aefc9a044"), null, null, "Maximo79@yahoo.com", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("08f9ea2c-7d58-454b-93b8-3928c64e55e9"), null, null, "Emilie_Toy@gmail.com", false, new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4") },
                    { new Guid("08fd9ba9-35c6-4ad6-9be9-ff34205d3488"), null, null, "Thelma.Cronin97@gmail.com", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("094b8970-6e6b-4da0-ac06-4c45bc970b72"), null, null, "Elyse52@hotmail.com", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("094c4140-1239-44a2-b723-ac38720dc36c"), null, null, "Abel16@yahoo.com", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("099293d8-910b-4ddc-aa67-bda3b44c436f"), null, null, "Aliyah.Pollich@gmail.com", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("09a032c5-b959-45b7-83b3-489d6084576d"), null, null, "Wiley_Mitchell62@yahoo.com", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("0a01fdfd-f879-4e12-af40-6f9c8bf6d1f2"), null, null, "Tamia_Schuster17@hotmail.com", false, new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("0a59396e-09c3-44ed-8479-cea37102b087"), null, null, "Taylor_Hettinger59@hotmail.com", false, new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1") },
                    { new Guid("0a76cece-0b00-44fe-a4db-ca9233214d1f"), null, null, "Florence90@gmail.com", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("0b68a161-dce5-4b53-9f72-98172d3d78d8"), null, null, "Einar21@hotmail.com", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("0ba1addf-afe0-4476-9892-80537291485d"), null, null, "Bill.Macejkovic@gmail.com", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("0bbfb036-fab4-4358-b130-22f83ce456ec"), null, null, "Kasey68@yahoo.com", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("0c0b0c74-23bd-42da-998c-661da006048b"), null, null, "Roscoe_Marvin@gmail.com", false, new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a") },
                    { new Guid("0c52b337-d66e-4d46-8811-42d0124ae426"), null, null, "Ladarius.Olson3@gmail.com", false, new Guid("c32606de-b224-4989-bf52-f8b3cabea595") },
                    { new Guid("0c79157b-785e-4160-b0c7-909a47a6f6eb"), null, null, "Samir_Kub@hotmail.com", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("0ca23303-d578-48f6-adca-b1e6f45aec55"), null, null, "Uriah.Gaylord75@yahoo.com", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("0ca4129c-1ee4-46ff-afc4-a9314a7237dd"), null, null, "Reginald_Langosh2@yahoo.com", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0cbb14e1-cc4a-4f30-aab9-35960b0c35ad"), null, null, "Sophia34@hotmail.com", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("0d223d2c-c63a-4aab-bb17-88b38182cba7"), null, null, "Nikki.Schmitt46@yahoo.com", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("0d7e75ab-a12e-42cc-b11f-d6fa2359e310"), null, null, "Marge_Gerlach61@hotmail.com", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("0dd7e99e-9677-4d57-b91c-d441c843316f"), null, null, "Ayden.Bode13@hotmail.com", false, new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4") },
                    { new Guid("0e53fb47-43ed-47ac-9d50-2f2bc3fd8478"), null, null, "Amara.Abernathy@yahoo.com", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("0edaa935-8198-4c9f-9196-d560a021a85c"), null, null, "Beryl_Mohr41@gmail.com", false, new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588") },
                    { new Guid("0ef22062-56be-4ec8-b671-cc7a789bdc4d"), null, null, "Enoch66@gmail.com", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("0f1c6122-b45b-41e6-8383-0c548fae8831"), null, null, "Alvah_Schumm@yahoo.com", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("0f86c233-635c-4b90-aea0-22e81158a342"), null, null, "Catharine_Volkman2@gmail.com", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("0f9e5e29-42db-4fb7-bcf3-021ea1506e33"), null, null, "Bruce_Doyle@yahoo.com", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("0fb44070-b6e7-4fe2-bae6-e69eaa8391d5"), null, null, "Alberta.Abshire6@yahoo.com", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("0fb71ebc-d950-4e77-a18e-663a46134a84"), null, null, "Liliana_Altenwerth90@yahoo.com", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("0fca38a5-89a0-49a9-94c8-820a02048784"), null, null, "Jerrod.Cole7@gmail.com", false, new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd") },
                    { new Guid("10c6b29f-d872-4feb-a6e6-9242725f341a"), null, null, "Jacky.Wyman50@gmail.com", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("10c7cfe6-811d-4271-8382-3991119a7884"), null, null, "Phoebe_Frami@gmail.com", false, new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("10eb6621-2384-451e-8252-d417e1708c51"), null, null, "Daron53@gmail.com", false, new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02") },
                    { new Guid("111bc760-d8c4-45ea-8656-2285ef9ef588"), null, null, "Edgar68@yahoo.com", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("113633ac-b403-4f9c-9424-a863031d10b0"), null, null, "Franco_Russel@gmail.com", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("115bec7a-3baa-4f94-b946-c759edc5c0b2"), null, null, "Easton.Smith@gmail.com", false, new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02") },
                    { new Guid("11ac6871-056b-4dda-bf9c-0bf8779de192"), null, null, "Delpha.Konopelski51@hotmail.com", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("11e366b4-dc73-4bd3-91d1-0b422ceff346"), null, null, "Rosie_Connelly@hotmail.com", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("1203fca0-36e6-4382-955c-71de90bbf3d8"), null, null, "Vernon29@gmail.com", false, new Guid("4390173e-3194-44b0-9f5c-e816c829e49d") },
                    { new Guid("129f86f8-eb4b-4e38-bbd4-377703b2c02f"), null, null, "Katelyn0@gmail.com", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("12aca2d1-3a08-4772-ab9f-e59172014612"), null, null, "Shany93@yahoo.com", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("12db4e17-1d82-401b-aff5-af4b010b03c7"), null, null, "Elmer_Runolfsdottir@yahoo.com", false, new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036") },
                    { new Guid("12dfe3af-a351-4074-af14-63f196f5503f"), null, null, "Alexys_Sawayn60@gmail.com", false, new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3") },
                    { new Guid("12f64aea-6802-476e-a1f4-37d430affc97"), null, null, "Virginia_Ratke@yahoo.com", false, new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("1341a7ef-4093-4367-b415-187a4fd0de8a"), null, null, "Tierra65@hotmail.com", false, new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0") },
                    { new Guid("1347da3b-a73d-44da-a348-b9fcee119edc"), null, null, "Jorge_Jaskolski@gmail.com", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("13b9cfdd-dc48-4043-bdf2-9e9247f71ade"), null, null, "Serenity_Volkman70@yahoo.com", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("142a4797-af39-498a-a78e-9282b085c168"), null, null, "Hollie10@gmail.com", false, new Guid("114ac41c-5eba-4152-8f7e-622356a03762") },
                    { new Guid("14608803-216a-4df0-b755-eb734e6da903"), null, null, "Marvin83@hotmail.com", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("149ebf4d-30c3-4ee3-bec3-a862e9912842"), null, null, "Carolina.Ankunding@gmail.com", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("14f54726-0cbe-4170-8eda-dc17c056174a"), null, null, "Robert_Kuhic@hotmail.com", false, new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f") },
                    { new Guid("152d04d4-9df1-4d1a-a907-9f08dda8f292"), null, null, "Brionna_Lockman14@yahoo.com", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("15af1a8e-21d2-4e04-b57a-4bd4c6a98a6a"), null, null, "Raoul_Watsica@gmail.com", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("15d2ab5d-1fea-487f-8afb-40e15dc1ab32"), null, null, "Cordie.DAmore@hotmail.com", false, new Guid("01a8bd37-aff4-4aac-8218-b782c941985f") },
                    { new Guid("15ef9d80-4f8b-4180-9446-2a8cfc1f3318"), null, null, "Kaya47@gmail.com", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("16013e92-ddae-4966-9b99-f7f11e0462de"), null, null, "Dariana92@gmail.com", false, new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d") },
                    { new Guid("160ff1ae-029d-41db-8ac2-5d28e29ee81b"), null, null, "Camren.Cummerata@yahoo.com", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("167fed16-4877-4c76-aef2-2870386155de"), null, null, "Mustafa_Gusikowski@gmail.com", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("16b3b13c-8dc8-439c-8e3f-396fafe258ad"), null, null, "Cornelius66@yahoo.com", false, new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("17288652-1fc5-454e-8c9e-9a6fe9503472"), null, null, "Jaleel7@yahoo.com", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("172a63d6-3513-4cdd-b218-16d8f9f19acd"), null, null, "Genoveva.Collins83@hotmail.com", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("1765f227-d867-4332-93e3-e0d655a67f44"), null, null, "Juanita.Kozey@yahoo.com", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("178708a0-e772-4b1f-93a3-4cd772bd3b7d"), null, null, "Cyrus92@gmail.com", false, new Guid("7b8e2086-2aa9-4256-9444-793523c7a280") },
                    { new Guid("17ff5be5-c3da-43b1-b580-b24908b731f5"), null, null, "Joshuah.Kreiger73@gmail.com", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("1881c9d0-cbad-40ab-b4b6-3d344585b720"), null, null, "Benton37@hotmail.com", false, new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190") },
                    { new Guid("19445907-bbc1-4189-a2d8-626aa2d71070"), null, null, "Jessika.Denesik@gmail.com", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("19715dfe-12dc-474c-8a57-9abe28ea0aca"), null, null, "Haley_Kemmer76@hotmail.com", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("19ab9d8f-c250-4f27-8670-c1666343d9f1"), null, null, "Joy.Nitzsche@hotmail.com", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("19c2ac84-d3af-46e5-8520-d1263067f7d9"), null, null, "Earline_Douglas66@gmail.com", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("19d1baf6-4181-4a5e-baf4-44f32a11deb3"), null, null, "Liam33@yahoo.com", false, new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014") },
                    { new Guid("19d8928b-8691-43ca-ad4e-5e8cc96dcf22"), null, null, "Roberta86@yahoo.com", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("19e51634-6fad-4cc8-8472-609b82c4df5c"), null, null, "Tamara_Hammes53@hotmail.com", false, new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3") },
                    { new Guid("1a894b2a-22c1-42e0-8a91-6f2d9281addf"), null, null, "Jo30@gmail.com", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("1ae5cc59-3c02-4638-9f76-ec331372a163"), null, null, "Linwood45@gmail.com", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("1baf6fb9-7d90-4528-b4d2-004a5c87d02e"), null, null, "Abe_Deckow@gmail.com", false, new Guid("a8115124-4280-4a52-8af7-cb635f456958") },
                    { new Guid("1bda088f-238a-47a4-b357-4498f70d62d0"), null, null, "Dahlia.Johns@gmail.com", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("1c7ad0b9-0ccd-41fc-a643-0e936c06aa5d"), null, null, "Phyllis.Franecki@hotmail.com", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("1d96da2f-4bcc-491f-8a35-a21b3a69c141"), null, null, "Brionna43@hotmail.com", false, new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("1e8f0733-8142-4cbf-9c4a-49d9c6304ef0"), null, null, "Irwin84@hotmail.com", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("1edef13e-a4da-4b14-ba22-fe7330a1737d"), null, null, "Kyle30@hotmail.com", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("1f152da1-8426-4051-b82b-33acfefeec06"), null, null, "Jefferey_Douglas28@hotmail.com", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("1f2cab81-01b8-4c83-bea8-029026c9c9c5"), null, null, "Tamia.Mills@yahoo.com", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("1f2d4f37-4bee-4e3d-83a1-ab945b75252e"), null, null, "Angelo.Willms19@yahoo.com", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("1fafaea2-09a9-4d2b-a526-fe9c35fbb208"), null, null, "Blaise_Senger@yahoo.com", false, new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("1fd1c788-cfb8-465f-9f0b-2b33e6abd74f"), null, null, "Delia.Leffler@yahoo.com", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("20b7d789-1675-4a81-8bee-330481d466e8"), null, null, "Linnie_Paucek@yahoo.com", false, new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") },
                    { new Guid("20c646c3-1f46-4b7c-af41-e682e8f8a28e"), null, null, "Eve_Wintheiser@yahoo.com", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("20c8844f-80de-4559-9f26-1815c9490b03"), null, null, "Xander.Strosin@yahoo.com", false, new Guid("82d8841b-b98c-463c-96d0-9378cf908740") },
                    { new Guid("2119f42a-8d6e-436c-a569-8c7539adb0d9"), null, null, "Kyra.Dietrich57@hotmail.com", false, new Guid("26e9f9a9-c77f-4f47-b594-e602be058706") },
                    { new Guid("2129e225-8a63-469a-aa8e-1e5ea49d4050"), null, null, "Alta_Lindgren@yahoo.com", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("2162915a-30f7-4355-838c-371b1562bece"), null, null, "Oswald40@yahoo.com", false, new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f") },
                    { new Guid("21cc8417-1f8e-407a-ae6d-f2141d796b00"), null, null, "Catalina41@gmail.com", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("21e5580d-8192-443b-8527-3f8e17cc0782"), null, null, "Kayley.Schamberger42@gmail.com", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("21fc69b3-cea1-457d-9010-bd11159c560c"), null, null, "Nikita20@hotmail.com", false, new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb") },
                    { new Guid("223b0691-5637-4b26-9e55-b4244158b204"), null, null, "Dedrick.Brekke@gmail.com", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("2267e84e-4005-41a4-ab85-c7af5f8fa788"), null, null, "Zora54@gmail.com", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("22686a62-f552-4cfb-ab6d-648a1b255441"), null, null, "Fanny26@gmail.com", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("2271d201-82a8-470a-bd36-440ed5f8ed92"), null, null, "Kameron_Veum0@gmail.com", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("234047bd-38ca-437c-ae01-e1dd2abd5ea9"), null, null, "Loyce_Reinger@yahoo.com", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("237af453-4d76-4f9f-bbc7-5ce65c57464a"), null, null, "Myles_Lynch76@gmail.com", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("23aaaa49-834c-4184-a582-d8dac678a216"), null, null, "Tre_Ratke@gmail.com", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("23afbaa9-a42c-4280-869a-c7cc93f50f54"), null, null, "Julius_Keebler@hotmail.com", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("23f2af9d-a19e-4216-b4d7-98a090413163"), null, null, "Presley.Schmitt77@yahoo.com", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("2402aae0-ee8b-4862-b916-05f91e981f68"), null, null, "Jammie4@hotmail.com", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("2410a13a-8e23-41e5-8d7a-bad2dd8c2067"), null, null, "Jalen52@yahoo.com", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("241f6b48-3116-442c-9fee-de05b71c4e18"), null, null, "Maegan84@gmail.com", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("242a37b1-e86b-4a02-9338-e3e59f678f74"), null, null, "Jovan_Heaney13@yahoo.com", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("2507b48e-8c1f-42c1-823b-b9bd242cc88a"), null, null, "Bradly_Bernhard@yahoo.com", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("258b1fb9-6cb8-4092-905d-e413845aa21a"), null, null, "Marvin25@gmail.com", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("267d7a39-87dd-442d-8e54-9069728a850d"), null, null, "Angelo31@yahoo.com", false, new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9") },
                    { new Guid("2787cd49-f878-400d-a16d-17679fb58aec"), null, null, "Ashlynn.Bins@hotmail.com", false, new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad") },
                    { new Guid("28784ccf-1035-4602-a64c-803ee37c7698"), null, null, "Walter37@hotmail.com", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("28af30b2-0a6b-405d-a5ae-17b24afd0ee3"), null, null, "Deon44@yahoo.com", false, new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee") },
                    { new Guid("28d6555f-0202-434d-b1f9-1be7bb492aa2"), null, null, "Kailey_Keebler@yahoo.com", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("28f5b479-1e05-4c9e-af6d-56b8bf18839f"), null, null, "Adrianna.Monahan2@yahoo.com", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("292f0c35-86c6-443e-b866-dc6ff11355e1"), null, null, "Dallin51@yahoo.com", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("2948b6e2-6402-4999-8a93-3a2858353ef1"), null, null, "Candelario54@hotmail.com", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("2956268c-3163-41be-9e93-50cdfb81c6a0"), null, null, "Gay_Simonis@yahoo.com", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("29da9512-6606-475d-9510-d5ddc1bee450"), null, null, "Lura.Herman@hotmail.com", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("29eb6b12-627e-45f2-87fd-7725e6895cd0"), null, null, "Spencer1@hotmail.com", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("2a8ca3be-5dde-48a7-81f6-d7dac2c55b74"), null, null, "Naomi.Donnelly51@hotmail.com", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("2ab291dd-3c2f-434b-b99c-4bbb8f3697f1"), null, null, "Erick_Price@yahoo.com", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("2b3864c2-3ca8-435b-9921-4bb7894ce13f"), null, null, "Milo51@hotmail.com", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("2b50d631-8e58-44bc-a28a-94f0f6ec4e23"), null, null, "Marta_Collins35@yahoo.com", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("2b6539ac-7423-473a-8104-66d1cdf86e90"), null, null, "Andrew.Windler@hotmail.com", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("2c63b023-858a-4509-9218-6a38e10c5935"), null, null, "Alphonso80@yahoo.com", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("2ca956e5-8520-4f8e-aa4a-a8d3ec0554fd"), null, null, "Cheyenne.Bogan74@yahoo.com", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("2cf16c64-be33-4b5c-80d5-859d3093e5a6"), null, null, "Jalyn2@yahoo.com", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("2d20dc04-bb5d-411b-868d-e66706809888"), null, null, "Kara.Jast@gmail.com", false, new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2") },
                    { new Guid("2d6c8b33-e3aa-46d5-ab67-0a8ff24cf994"), null, null, "Lucius_Klein47@gmail.com", false, new Guid("7b8e2086-2aa9-4256-9444-793523c7a280") },
                    { new Guid("2d780447-bc71-44e7-bfb2-839b409fe7c2"), null, null, "Lenny_Gusikowski73@hotmail.com", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("2de4d550-9355-4937-a25b-e71c6f33578e"), null, null, "Jaquelin64@hotmail.com", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("2df107d4-ef33-48c7-9854-d791ef37b49c"), null, null, "Madaline.Ortiz19@gmail.com", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("2e1c89a9-0aa2-40cc-862b-f9f5021903c9"), null, null, "Leslie_Kuhlman64@hotmail.com", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("2e88957a-a845-4407-93ae-4dae2af63ef0"), null, null, "Weston77@gmail.com", false, new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") },
                    { new Guid("2ef14faa-cbd2-4a59-86e4-f8de81631aeb"), null, null, "River.Quitzon52@yahoo.com", false, new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79") },
                    { new Guid("2ef5b3ba-d64e-46b0-89ac-47e6d13669c2"), null, null, "May41@hotmail.com", false, new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd") },
                    { new Guid("2f065205-c68a-483f-8e57-8b70903734cd"), null, null, "Keely_Reichert53@yahoo.com", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("2f14622e-5a52-4b72-bee1-5901236c8224"), null, null, "Brionna14@hotmail.com", false, new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("2f8cedff-2022-47a6-a0f7-81f69d7a6448"), null, null, "Milan21@gmail.com", false, new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4") },
                    { new Guid("2fcd865c-6419-46a4-b28d-f3aa99eb417d"), null, null, "Vernice_Wisoky71@hotmail.com", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("300b0f6f-3e5e-4020-a080-5c04701e6d7b"), null, null, "Melvin.Strosin48@yahoo.com", false, new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2") },
                    { new Guid("3015b536-95db-400b-8498-a8081a422cef"), null, null, "Anastasia.Rolfson@gmail.com", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3035b2b2-e76a-4fc1-a7da-794ddaffdeed"), null, null, "Pascale.Mertz13@yahoo.com", false, new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92") },
                    { new Guid("30885a1f-25f7-4e48-82c4-e46fad3d896f"), null, null, "Gabe84@gmail.com", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("30fdf6bc-ac19-42f5-8110-9a25dc0b85d9"), null, null, "Rollin49@gmail.com", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("313d5edc-a0e7-4fbd-9e28-eae13c75f9f5"), null, null, "Damon_Schultz@gmail.com", false, new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457") },
                    { new Guid("3164c440-454e-4cdb-94e5-9c277f37a0e4"), null, null, "Henderson14@gmail.com", false, new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f") },
                    { new Guid("3192270b-eab7-435a-b071-32027c130b3d"), null, null, "Barry.Stiedemann73@yahoo.com", false, new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115") },
                    { new Guid("3243ed4d-49ac-444b-bb6e-b9365da7373b"), null, null, "Buck_Kertzmann@yahoo.com", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("32a2880b-61af-443a-91a4-5fe24c2f32fd"), null, null, "Price_Kuvalis33@gmail.com", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("32e89482-0cbc-4e51-b22d-c63cad023f3e"), null, null, "Merlin_Tremblay45@gmail.com", false, new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215") },
                    { new Guid("32f2cd1e-a1e4-498d-bed1-7a6ba0d240a4"), null, null, "Burdette_Berge@hotmail.com", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("330ceb8e-7b61-4e65-ac9f-84f4cc8f9d98"), null, null, "Garnett.Olson@gmail.com", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("33cd049e-0836-4b74-bfc2-f26a32223264"), null, null, "Torrey_Kris@hotmail.com", false, new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa") },
                    { new Guid("33d97505-0f69-4733-a864-d492136ad7e1"), null, null, "Graham_Barrows10@yahoo.com", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("340c2e58-a17d-42df-8b8b-84aa10f783df"), null, null, "Marco76@gmail.com", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("34141e02-9f87-4d1f-ab61-a2b24b6aa45b"), null, null, "Cathy_Huels@gmail.com", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("34156af8-1713-4107-b345-3dedacb52706"), null, null, "Mario_Hansen@hotmail.com", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("3427c4da-6fec-4834-b264-1b0266e1b9a8"), null, null, "Vickie_Flatley@yahoo.com", false, new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b") },
                    { new Guid("343ef17b-e8c5-4dc1-9ec0-d721d622adaf"), null, null, "Jeramy_Doyle@gmail.com", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("353c356d-2f7e-4ea7-a0f3-aa98d70984d5"), null, null, "Nathanial95@yahoo.com", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("356c099d-7f45-4538-8dd0-71b962803250"), null, null, "Elza_Morar@hotmail.com", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("35c9d7df-6039-4399-a4d4-8f710c05f956"), null, null, "Ernestina.Reynolds26@gmail.com", false, new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("36966b2d-41c1-49bc-8a00-442d257e8cad"), null, null, "Khalil.Mills@yahoo.com", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("36cb183c-5b74-4da3-b0ca-55c5ec037213"), null, null, "Alia_Labadie31@gmail.com", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("36df16d2-4a80-44cf-a170-51af62b97e4b"), null, null, "Bria.Jast24@gmail.com", false, new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35") },
                    { new Guid("36e5b4ba-9f7d-452c-b9c3-c6916936b5c2"), null, null, "Marlin.Lockman73@yahoo.com", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("3706ea27-fa88-48a0-8d50-d6e06740c0cf"), null, null, "Desmond5@hotmail.com", false, new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361") },
                    { new Guid("380bbb12-60ba-426e-a7d4-4f373cf6d520"), null, null, "Angelina71@gmail.com", false, new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b") },
                    { new Guid("3848f322-fb95-4ad2-8803-0e03f0bfbec1"), null, null, "Ansley84@gmail.com", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("3854aca1-d198-4753-8a73-ae21e149edf3"), null, null, "Vita_Crooks55@yahoo.com", false, new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f") },
                    { new Guid("3891e549-7f33-4fec-8f57-042172bcd3e5"), null, null, "Erin52@hotmail.com", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("38d034e8-ccea-4432-b94e-d7b9a61ae639"), null, null, "Immanuel.Corkery36@hotmail.com", false, new Guid("787d2d2c-d05b-4935-906f-090d713b622f") },
                    { new Guid("391cf99b-febb-497a-871d-a131f3274758"), null, null, "Terrence94@hotmail.com", false, new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163") },
                    { new Guid("397d4635-b439-43fa-bbca-8915b8199fb4"), null, null, "April99@yahoo.com", false, new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215") },
                    { new Guid("39cf365d-ee95-4026-bc45-a279fd60aa51"), null, null, "Elissa.Funk86@hotmail.com", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("39d6230e-3dcc-4f87-b995-5fc27fa826f4"), null, null, "Charity91@hotmail.com", false, new Guid("01a8bd37-aff4-4aac-8218-b782c941985f") },
                    { new Guid("3a2d83df-54c8-4366-bba4-3a36f47379fc"), null, null, "Ahmad_Hyatt@yahoo.com", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("3ab6dd30-1bdf-4c80-9863-2dd44628aeff"), null, null, "Brown.Streich@gmail.com", false, new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265") },
                    { new Guid("3b04a960-3175-41f9-b458-7e662cc79abf"), null, null, "Jermaine39@yahoo.com", false, new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") },
                    { new Guid("3b740c10-999a-4179-bcc6-b08f54e96367"), null, null, "Moriah62@hotmail.com", false, new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163") },
                    { new Guid("3bb55b83-4954-464e-89e1-8303357fd270"), null, null, "Marion.Quitzon@yahoo.com", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("3bef4e77-650c-4465-a627-9f23ebe1ba19"), null, null, "Nelson33@gmail.com", false, new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb") },
                    { new Guid("3bfd1973-2939-4de1-bb7e-c30fef3e017f"), null, null, "Daisha.Koelpin@hotmail.com", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3cc17ea3-050f-4e6f-a20a-1a893bd423ee"), null, null, "Catalina.Satterfield@yahoo.com", false, new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036") },
                    { new Guid("3cee398b-bdce-40e4-8bdb-b214bcc728fa"), null, null, "Chesley.Haley62@hotmail.com", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("3d04fe35-6214-4de6-944c-20f1545bda8a"), null, null, "Clair.Conroy@gmail.com", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("3da09d44-3389-4d9c-a05c-7543a9b9f7a4"), null, null, "Patricia_Leannon@hotmail.com", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("3db87746-d966-4898-93d8-88647d8dc22b"), null, null, "Rowland45@gmail.com", false, new Guid("a42b469c-fec8-4056-a4de-926b01b7f202") },
                    { new Guid("3dd1b832-3885-4616-a416-b57f2b3517ce"), null, null, "Lavina.Welch@hotmail.com", false, new Guid("e8293c7e-c598-445f-a509-d9123149ec52") },
                    { new Guid("3ddc4ada-1325-4d39-80ae-cb3ab794725b"), null, null, "Kelsie27@hotmail.com", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("3ec78d79-04a6-4d1a-b91a-a94f0d1a4ca5"), null, null, "Melvin.Hayes@gmail.com", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("3edf9221-e36e-429b-919a-7b21f19fad30"), null, null, "Caterina_Champlin@gmail.com", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("3f08da73-2e2c-4cfd-897e-5832438d4e2c"), null, null, "Abbie.Gaylord50@yahoo.com", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("3f6ed778-ce66-443f-a3d0-b0c808b2744e"), null, null, "Mellie_Hickle94@yahoo.com", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("3faa5573-04af-4cbf-ae46-643852583ca5"), null, null, "Marco.Hilll@hotmail.com", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("3fb96275-2fbe-4957-a820-ece13e14450f"), null, null, "Kenya53@hotmail.com", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("3fd57ac3-2327-4f74-aeaa-b6b434837f8d"), null, null, "Jerrold.Hirthe@yahoo.com", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("403a0567-92ef-455b-927d-c428eaf8687b"), null, null, "Josue_Pagac56@gmail.com", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("40e0e311-cdd9-4b60-8c6a-490ae15ecd64"), null, null, "Dalton78@yahoo.com", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("40f21c37-f358-4332-8a1e-5e8d38a5a425"), null, null, "Ulices12@yahoo.com", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("410e177b-e305-4a35-a59a-b37dc2ac9034"), null, null, "Quentin.Sipes@yahoo.com", false, new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9") },
                    { new Guid("41420bd3-b0a5-45c9-9ff0-5680981c2797"), null, null, "Flavio.Wyman@hotmail.com", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("415b4de2-7fdf-406a-a436-b84fbab77477"), null, null, "Theron_Breitenberg@yahoo.com", false, new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794") },
                    { new Guid("418dbd14-46d1-49be-bb23-c4aa5b856e3b"), null, null, "Carmela60@hotmail.com", false, new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3") },
                    { new Guid("41a5bbc0-a8ff-47d6-8e85-b4853431da51"), null, null, "Myriam49@yahoo.com", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("41b220b2-7ccf-4c0b-a10f-da13c1afaaba"), null, null, "Skyla20@yahoo.com", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("41eabeb8-ae8a-4a18-8bec-426bcf55af39"), null, null, "Ressie_Beer@hotmail.com", false, new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057") },
                    { new Guid("42241a1e-13e2-49b1-ad54-deec99d3258d"), null, null, "Everett_OConner45@gmail.com", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("4227877b-3c65-426f-bb2c-e5669a743fe3"), null, null, "Dessie_Schoen@hotmail.com", false, new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443") },
                    { new Guid("42684b83-5a8d-45cd-a686-cfead647979d"), null, null, "Monserrate.Sauer88@gmail.com", false, new Guid("4285821d-9d8f-4943-b663-27adc015a9c4") },
                    { new Guid("43755960-8d7c-4e32-9dc6-215a79bd35cb"), null, null, "Roberta_Lowe@hotmail.com", false, new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643") },
                    { new Guid("43a339d9-e76b-4790-8a45-55ab45a386d3"), null, null, "Katelynn_Nader@gmail.com", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("43dafe7f-8c5c-4af7-9faf-68c39b3b035e"), null, null, "Estrella95@gmail.com", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("43fda83a-c7c4-4b98-a7e4-1b5dbdd344d6"), null, null, "Bonnie.Bogisich93@hotmail.com", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("44203ac7-9e28-44a5-9f7f-01400ab72907"), null, null, "Diego.Rippin@gmail.com", false, new Guid("4bc48bed-c113-458c-8a12-8f12565a542b") },
                    { new Guid("4428e4a4-ce8b-416e-bfcb-068b4e851892"), null, null, "Lester.Kohler@yahoo.com", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("44700537-c66f-4c95-8f7e-537ee480e39d"), null, null, "Maryse.Littel17@gmail.com", false, new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276") },
                    { new Guid("44b6636b-17ca-4b5b-be42-4d2ff5fb73ab"), null, null, "Alden41@yahoo.com", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("44b7b18b-ea58-4166-8dfd-0265a699a996"), null, null, "Bo_Ferry@hotmail.com", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("44d0a32f-0bbb-443a-9876-d266a19ef24a"), null, null, "Jazmyn_Johns@hotmail.com", false, new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd") },
                    { new Guid("45c8bbe4-1938-41de-9548-f4ba1f3b96b1"), null, null, "Mauricio_Mohr32@yahoo.com", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("45fc8c98-0d85-4b35-bd56-bd7861ca37e5"), null, null, "Gregg.McKenzie@gmail.com", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("468adea4-1061-41f9-b48f-8ab115486429"), null, null, "Coy_Kertzmann@hotmail.com", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("46918c07-8d27-463b-a89f-2b7ac4df461e"), null, null, "Jerald.West@yahoo.com", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("46a6ed70-0acd-47e1-a8aa-9b35b85b7bc7"), null, null, "Sonya.Sporer29@hotmail.com", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("46ab4a32-a6cb-424f-bb17-c7930bf9b686"), null, null, "Anabel57@hotmail.com", false, new Guid("71978c89-b953-4ec5-98a8-ab384223de1a") },
                    { new Guid("46ad2b36-d47a-4712-b6b6-f272a898955f"), null, null, "Darrick_Crooks@gmail.com", false, new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2") },
                    { new Guid("46b61173-a8b5-4e78-8086-6e7c7a0506ac"), null, null, "Anahi.Toy@gmail.com", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("481a396a-7de5-43fd-9907-3d7a7e2695ed"), null, null, "Wanda31@yahoo.com", false, new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed") },
                    { new Guid("4914d189-f60a-4f08-ac70-70f31c158383"), null, null, "Toby0@yahoo.com", false, new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("492ee932-7851-4f4f-af5f-0354b321e56d"), null, null, "Amari.Hodkiewicz33@yahoo.com", false, new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd") },
                    { new Guid("495147a0-4a9b-44ef-bff5-500e7a696b71"), null, null, "Lindsey.OConner@gmail.com", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("49dfa4d8-d1e5-41ab-b255-c3fa8d238ece"), null, null, "Clarabelle.Fisher76@yahoo.com", false, new Guid("05fb67eb-3b60-4c93-bf80-36153be08871") },
                    { new Guid("49e30c33-19bb-43b8-9e62-1c1c8b3b61e3"), null, null, "Bianka.Hamill58@gmail.com", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("49e95faa-3639-4024-b186-9e1d8f121006"), null, null, "Hal.Dibbert@gmail.com", false, new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50") },
                    { new Guid("4a2e517e-fe42-4876-86bf-1c3efec9b5a1"), null, null, "Darwin8@yahoo.com", false, new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794") },
                    { new Guid("4abe94a4-4538-4496-b911-4e4be8705866"), null, null, "Baby_Lemke16@hotmail.com", false, new Guid("c41a987e-114e-4968-aa63-744e27096322") },
                    { new Guid("4be1723b-518b-453d-9e88-c05bcce8f890"), null, null, "Crystal_Bahringer@yahoo.com", false, new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808") },
                    { new Guid("4c895217-4877-403b-9343-9f2095eac71d"), null, null, "Jessica_Marks72@yahoo.com", false, new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee") },
                    { new Guid("4ce2e0ba-eb92-4aba-8a9a-74ee45f870b5"), null, null, "Franz90@yahoo.com", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("4d195a94-4887-47d5-b3ba-eeeb80356b45"), null, null, "Angelica94@gmail.com", false, new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4") },
                    { new Guid("4ddaf3ef-59d7-4981-a045-2601c36adc2d"), null, null, "Lamar53@yahoo.com", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("4dec2137-883b-48ea-b403-dd47ff013d94"), null, null, "Gisselle.Lesch45@gmail.com", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("4e2044c8-1bbf-4ea5-a640-91f625d33749"), null, null, "Zoie_Langworth@yahoo.com", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("4e339c7e-8d69-4c44-a19c-13a14c2b4750"), null, null, "Schuyler43@hotmail.com", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("4e73780d-ac72-44ca-adab-43c526ab94c9"), null, null, "Neil_Gibson@gmail.com", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("4ece62db-a910-413f-a67f-94a691d6d7bd"), null, null, "Noelia_Zulauf@hotmail.com", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("4f3b48e9-4c25-451b-978e-265f32e9c0fb"), null, null, "Lelia90@gmail.com", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("4f88ca86-feab-462d-94aa-c8967aa4d330"), null, null, "Kolby.Wolf57@yahoo.com", false, new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed") },
                    { new Guid("4f9dd275-f559-41d6-82c4-457bba04bb9e"), null, null, "Reuben74@yahoo.com", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("50033054-5466-41ff-a59f-8e958eb5beda"), null, null, "Shanny_Stracke@gmail.com", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("5026b4cd-fedd-4652-b45c-d28e91604069"), null, null, "Alycia70@hotmail.com", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("50853504-8f2f-457e-94d6-376202129730"), null, null, "Juana.Hodkiewicz@gmail.com", false, new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305") },
                    { new Guid("50afab5e-0097-43e7-952f-5c685789be22"), null, null, "Creola_Zieme@hotmail.com", false, new Guid("8576464a-f366-4076-97bd-00c2481b9a38") },
                    { new Guid("50dd1a44-47c8-445f-96fc-169edcdffc62"), null, null, "Alexandro_Green@yahoo.com", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("5143c17e-cc41-4212-8bfe-09dac881a04f"), null, null, "Otilia32@yahoo.com", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("516e794a-f45b-4b1c-9943-1dc4781f6c03"), null, null, "Don77@yahoo.com", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("51eaceb3-48ac-4641-8b11-8a1efde7bdc9"), null, null, "Jaclyn_Jerde@hotmail.com", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("5205b352-582f-40c9-989a-67c675da4af4"), null, null, "Lina.Hammes@hotmail.com", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("5207a044-6d3e-49f2-a337-94fc5b4d8213"), null, null, "Meda.Feil@gmail.com", false, new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("52411f84-a835-4323-9d10-439ba1b47a44"), null, null, "Eriberto_Brown@gmail.com", false, new Guid("354e9bbf-de43-4345-a871-f0af96ec9410") },
                    { new Guid("525bd74b-f743-4a71-b2a4-2186d6abe3b2"), null, null, "Monte_Bosco@gmail.com", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("525e3de0-51bf-4727-90f8-601696655897"), null, null, "George_Schimmel9@yahoo.com", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("526c925d-5ac8-4c04-a3b2-82d65132ff54"), null, null, "Jerry.Abernathy27@gmail.com", false, new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643") },
                    { new Guid("52af2d02-006c-4952-9cf9-7663d2df0c59"), null, null, "Ellsworth.Stracke51@gmail.com", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("52eeabbf-e553-464c-8383-1427adf99c8c"), null, null, "Tina.Lubowitz30@yahoo.com", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("53060fce-21a0-4134-b9f3-f1dc33962816"), null, null, "Nicholas.Champlin@hotmail.com", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("53349035-8e4e-449e-a1fc-82a0ae6a5eb4"), null, null, "Ceasar_MacGyver19@yahoo.com", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("53fd5c4e-36b6-4538-9fd0-ed4535d4abe8"), null, null, "Christiana4@yahoo.com", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("550ef6d4-a530-41ac-b5d8-3b28d2c0ccb2"), null, null, "Joey.Tromp@hotmail.com", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("55163afb-a82b-4288-af00-844e0bcdbc6d"), null, null, "Darwin_Grady@yahoo.com", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("552c190c-92d3-4493-b48d-410fa957a3f8"), null, null, "Jacquelyn.Towne61@hotmail.com", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("553f20ff-f381-4ac3-87fe-942f2ac5d5e6"), null, null, "Patrick_Emard@hotmail.com", false, new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4") },
                    { new Guid("55af5458-db3b-479f-ae71-483303a4e7a3"), null, null, "Jed73@hotmail.com", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("5613b504-ecf6-4799-8472-f4bb496bf698"), null, null, "Conner51@yahoo.com", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("56b2aeba-1518-40ef-829c-73506461d33e"), null, null, "Kameron66@gmail.com", false, new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a") },
                    { new Guid("57650633-122b-4a85-ad53-432fce6b4b22"), null, null, "Johnny_Sipes1@gmail.com", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("57791d3d-2407-4965-9fe0-70104cae1f5e"), null, null, "Rebeka.Stehr@hotmail.com", false, new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2") },
                    { new Guid("580f6134-6b55-463a-a452-4909259572f1"), null, null, "Genesis.Wuckert20@yahoo.com", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("588a2353-81de-47bc-8958-34656887bd68"), null, null, "Lonie_Collier81@hotmail.com", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("588ce447-b0d1-47e5-b71c-b989a6980da0"), null, null, "Rolando89@yahoo.com", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("59094cc1-b9c2-48f5-87e3-2e289c23646e"), null, null, "Eliezer4@gmail.com", false, new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15") },
                    { new Guid("59362a57-6697-4476-b645-f62d1658c4cf"), null, null, "Ofelia_Luettgen@gmail.com", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("59591a80-d86e-4c1a-9929-62511870491c"), null, null, "Fidel_Smith@hotmail.com", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("598fb88b-c066-428e-980e-56fae8c08036"), null, null, "Hollis26@gmail.com", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("59bbda13-771d-4c2f-94da-5cf82ccd5607"), null, null, "Kathleen2@gmail.com", false, new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f") },
                    { new Guid("5b0dca75-ad1e-41bd-a766-5025339e0484"), null, null, "Seamus.Sipes88@gmail.com", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("5b4f87a1-8865-44a4-8a3e-c746572445e7"), null, null, "Ana38@gmail.com", false, new Guid("4860b124-2e67-49cc-b664-135729261ac4") },
                    { new Guid("5bfad4ab-e950-456e-9910-b990f3364178"), null, null, "Raul_Veum@hotmail.com", false, new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50") },
                    { new Guid("5d124c52-1088-4fb6-82aa-d2f78972867b"), null, null, "Lamar.Hartmann37@yahoo.com", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("5dbcb432-ff33-4748-bbfb-1dc9167dc044"), null, null, "Clarabelle.Yundt93@hotmail.com", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("5dfb069d-0624-46e3-bc5d-10f6908d7d1e"), null, null, "Josefina94@yahoo.com", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("5e4cb503-2cd5-4f6a-abb1-2ed1a5cb230e"), null, null, "Winston_Willms@hotmail.com", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("5e763e48-e7cc-4404-9fcb-f6fe278f4e97"), null, null, "Jenifer.Kreiger28@hotmail.com", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("5f26a9bd-aaa9-4321-b3d8-d14f446f3112"), null, null, "Kira.Lehner13@gmail.com", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("5f27b838-68b2-42e3-b996-5f1ade13f9fd"), null, null, "Willy_McKenzie@hotmail.com", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("5f590593-4edd-45dd-a1b2-69e64e97c0ff"), null, null, "Katelin_Labadie61@yahoo.com", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("5fbcdb56-290c-4073-b96e-9af31a501dd1"), null, null, "Dimitri28@hotmail.com", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("5ff68785-7e4e-4bf3-b9dd-1927b00414d2"), null, null, "Sandra.Cruickshank6@hotmail.com", false, new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7") },
                    { new Guid("6069fd85-c5c4-415b-8883-2c1933bea233"), null, null, "Loyce.Connelly@hotmail.com", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("62200798-e704-4da0-b0b9-29fca07bf4cb"), null, null, "Gisselle71@gmail.com", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("62563df0-ac94-42d1-9b40-78c1cc1fdcd1"), null, null, "Henriette90@yahoo.com", false, new Guid("a0995ae3-517f-4476-bad0-18fca309cda5") },
                    { new Guid("637bcf9b-5d70-49c3-bbcd-98f8a7b90c31"), null, null, "Nona.Rogahn@gmail.com", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("64434d01-ed11-4fb0-888c-7cfbad369f4b"), null, null, "Angel29@yahoo.com", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("64b66284-2de2-4e76-b384-da83941f7963"), null, null, "Orland91@hotmail.com", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("652d3f93-48c4-411a-bf9d-9c51765754a5"), null, null, "Clyde73@hotmail.com", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("656cd0d3-f9af-4d1a-b7bf-4502131bf074"), null, null, "Nicolette74@yahoo.com", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("65d34c61-9356-4ffe-8293-99a7b1e3d8bc"), null, null, "Trent56@gmail.com", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("667d9e72-04dd-4a54-a402-a4b5bd71adac"), null, null, "Sandy60@yahoo.com", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("66a0dc74-9605-4256-93dc-480a93c96a5a"), null, null, "Jermaine.Hettinger@yahoo.com", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("66b6e9fa-180b-4f17-adb4-e5a3ddcb1470"), null, null, "Vada95@yahoo.com", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("66c235d6-38f3-4daa-b48a-8d9c86196612"), null, null, "Betty78@yahoo.com", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("67092bd9-c2d9-40c8-9d6f-b3e9373d7e72"), null, null, "Curtis35@gmail.com", false, new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2") },
                    { new Guid("677ec18c-58bf-41a0-aff0-8d2225d99084"), null, null, "Jordan2@yahoo.com", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("682d3037-2eca-4ba8-8da8-634ce625f908"), null, null, "Talon.Weimann76@gmail.com", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("68c25e4f-cfc1-4ffe-9c79-ecb712bb3786"), null, null, "Christopher9@yahoo.com", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("693d7fbb-47ca-463c-b0ca-f7cee4f3d55e"), null, null, "Devan87@gmail.com", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("694e2567-024d-4baa-aece-45b44998e5eb"), null, null, "Katlyn.Blanda@yahoo.com", false, new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696") },
                    { new Guid("69e28874-8c70-405c-a27a-a848984440db"), null, null, "Ignatius.Moen@yahoo.com", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("69e4ae1c-45d6-4073-847d-7ca7d42a642a"), null, null, "Dena.McKenzie80@yahoo.com", false, new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5") },
                    { new Guid("69e91184-991e-4c90-8c2a-ad3dee451e93"), null, null, "Nora54@hotmail.com", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("6a55f094-eab4-4648-b71b-c35ed3bc87c8"), null, null, "Rubye_Schamberger@hotmail.com", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("6ac59dec-aa19-4794-a1d2-74d6459901ba"), null, null, "Omari46@hotmail.com", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("6adb5a4f-bc50-4221-bf8d-04c916168042"), null, null, "Nathaniel.Lang@gmail.com", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("6ae65e91-5502-4d4d-bece-81a1f2cfe68e"), null, null, "Alvis79@gmail.com", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("6b0627f2-0378-4a59-928e-e0e841327cba"), null, null, "Kayleigh_Witting56@gmail.com", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("6b14fc36-8ea5-4310-a6dd-777c9aa884b1"), null, null, "Evie.Bernhard@yahoo.com", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("6b825afc-aa29-4c4f-9ecd-f70c829d21c0"), null, null, "Fermin_OConner@hotmail.com", false, new Guid("fa64f167-af58-425d-8dce-93642bd7650a") },
                    { new Guid("6bf53c12-56ac-4cd2-8f55-73c13d59b580"), null, null, "Matteo.Konopelski@gmail.com", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("6c99f79a-3422-4e4e-88d4-56fd0db93ddf"), null, null, "Zella_Okuneva2@hotmail.com", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("6d22fee3-b392-4b62-8b7c-f75b7c9749b1"), null, null, "Ed37@hotmail.com", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("6d8b8a7f-67f1-416a-be2a-2f004330714a"), null, null, "Loy32@yahoo.com", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("6d98c3fd-f594-40ec-8fc1-33051c60cd34"), null, null, "Leo_Jacobs@hotmail.com", false, new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("6e8decd2-f688-4a1c-9719-7b07113c9b16"), null, null, "Krista85@gmail.com", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("6e90f3d4-1dc9-46ad-9a9d-1371e9607246"), null, null, "Wilson18@hotmail.com", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("6ea57df1-5699-449b-94cf-a01922137b01"), null, null, "Elinore.Keebler@yahoo.com", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("6ecd779b-b36a-4313-aac8-91e0c26ecd08"), null, null, "Kaia_Fritsch23@yahoo.com", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("6edaa590-76f4-47c9-a33f-b56cbe7da578"), null, null, "Fausto_Ullrich@hotmail.com", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("6ef51265-1cc4-4e25-ad88-c9235f8c5fd2"), null, null, "Nichole_DAmore0@yahoo.com", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("6efd45fe-3595-4c60-beda-a9248cd816bc"), null, null, "Carlo56@yahoo.com", false, new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58") },
                    { new Guid("6f9ac174-628f-4142-9015-c092a6b6154e"), null, null, "Elody30@gmail.com", false, new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057") },
                    { new Guid("7024392f-7b91-47db-901c-c53f58a7060b"), null, null, "Adolfo24@gmail.com", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("7056c8bf-a3b0-44e3-a1c0-93e210cb27b9"), null, null, "Manuela_Kassulke@hotmail.com", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("707aa681-0556-4c7c-a93a-3c448cb8d84a"), null, null, "Tony_Huel47@gmail.com", false, new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2") },
                    { new Guid("70c7dc10-a73f-423f-8f54-d66fe9b37c3a"), null, null, "Godfrey18@gmail.com", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("70ebd334-fca1-4aa1-be6e-f32a6efdf7db"), null, null, "Cesar_Lueilwitz25@yahoo.com", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("71dd7338-7f13-48a7-8ee9-e560f250c316"), null, null, "Kaitlyn.Brakus@yahoo.com", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("722eb579-a18c-41b3-8dc9-d16c07b00be3"), null, null, "Concepcion.Ebert@gmail.com", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("727a53da-7985-4c80-a754-4ac22f9d0a60"), null, null, "Rod_Grimes@gmail.com", false, new Guid("c73bd258-469c-4d46-ad89-cd1119310c49") },
                    { new Guid("72a16d26-8190-4bb2-a917-5b320fda512b"), null, null, "Shanny.Dooley59@yahoo.com", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("73075b9b-5702-45c1-8de6-022013df5bb5"), null, null, "Graham30@yahoo.com", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7313d183-f907-4261-a79b-8d7093297099"), null, null, "Saul.Willms@yahoo.com", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("73670a7c-4634-4b39-98b6-dd1df2aa5ebc"), null, null, "Liliana1@yahoo.com", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("73975829-592a-48c4-8ae7-e525be6f3379"), null, null, "Darrin67@yahoo.com", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("73b4abd5-b7db-446a-994d-7a77f05d6712"), null, null, "Nicola69@gmail.com", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("73fadc1d-59e2-4ed4-bace-5a1bbc9faca4"), null, null, "Cleo19@yahoo.com", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("752d0645-316c-4d38-995c-60d372f4e7c6"), null, null, "Elna98@gmail.com", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("7586ecb1-a5ce-4fbb-92d0-bf6845e5e809"), null, null, "Sally_Graham8@hotmail.com", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("7593ba3d-91a0-4204-a949-a93de6dc5efd"), null, null, "Jacquelyn55@gmail.com", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("75fb2b66-3d4d-4725-a44b-5a816609d2b4"), null, null, "Ardith_Larson@yahoo.com", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("76052147-4952-4b06-b722-df0f5b38414b"), null, null, "Rupert_Ankunding@yahoo.com", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("76222978-0a07-4d30-8ca9-cab7eb7aec91"), null, null, "Rhianna.Marks@gmail.com", false, new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("76c926ed-9a39-48d4-86b9-4c0d9fccab7f"), null, null, "Johan_Jacobi@gmail.com", false, new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305") },
                    { new Guid("77180606-f712-4663-afea-8f3ed9769b16"), null, null, "Terrance_Schulist@yahoo.com", false, new Guid("285d8d29-53de-4979-a403-f61b887fa207") },
                    { new Guid("7792db8d-a2f2-4dea-851e-df11a1535f76"), null, null, "Bradley.Reichel@gmail.com", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("77d17c2d-4a48-458a-9b09-5916ec211ba0"), null, null, "Jerrold_Treutel@hotmail.com", false, new Guid("1ca2e699-11df-445a-8084-51598bee7020") },
                    { new Guid("781036e7-3d81-4cc1-a3a8-7b2698490256"), null, null, "Orie.Kunze12@hotmail.com", false, new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0") },
                    { new Guid("7824ac91-aa32-45c8-bc90-c4aae207e925"), null, null, "Wanda.Watsica@yahoo.com", false, new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1") },
                    { new Guid("78ccbceb-5620-4b14-9474-594cdb67eb32"), null, null, "Breanna35@yahoo.com", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("796611ea-0c64-457b-aae7-bafc5e894f92"), null, null, "Marcelle47@hotmail.com", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("7984a82d-aa9c-463c-9e09-139616d0b884"), null, null, "Isaac.Grady@gmail.com", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("798d5854-057d-4f48-9b39-2e479c532e1f"), null, null, "Arvid.Stiedemann@hotmail.com", false, new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("79ab98bc-305e-4154-826f-9bfa8d605b9f"), null, null, "Nicolas53@gmail.com", false, new Guid("a836bc35-12f7-485d-861b-ad1645878c24") },
                    { new Guid("79af6483-19e5-486c-a684-6bda23794645"), null, null, "Esther_Hudson@yahoo.com", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("79bce59e-0825-46a1-b31e-c1daa049ace2"), null, null, "Ned.Hudson97@hotmail.com", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("7a1d577d-b802-44bb-8d7a-c1d35b60bfc8"), null, null, "Junior64@hotmail.com", false, new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("7a25b14d-92ff-43dc-a54f-40628e8574f0"), null, null, "Theodora.Harris@hotmail.com", false, new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4") },
                    { new Guid("7a5d29b6-5b1f-417e-8d31-e693695144e0"), null, null, "Emerson.Sanford@hotmail.com", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("7af61e62-79c2-45a3-9f9c-3f1b96a4cfe6"), null, null, "Blaise.Wiegand6@yahoo.com", false, new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259") },
                    { new Guid("7b00b556-79da-44e1-bdc2-8e360944c6ab"), null, null, "Leanne.Price85@gmail.com", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("7b1fb700-55c6-4463-8411-b48dee8176b9"), null, null, "Toney.VonRueden47@gmail.com", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("7b9bb89e-4683-4b8c-b868-712b416ff819"), null, null, "Alexandra78@yahoo.com", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("7c4d42ca-ef46-429f-ae97-23ce4032c2b4"), null, null, "Peyton.Fritsch35@gmail.com", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("7d262473-a2f7-43d0-ae77-27f11bb6d9e2"), null, null, "Derick.Sipes@yahoo.com", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("7d4ccb78-482e-495b-83f2-eaf267256cca"), null, null, "Aleen_Lehner@yahoo.com", false, new Guid("114ac41c-5eba-4152-8f7e-622356a03762") },
                    { new Guid("7d8c1925-3d5b-48b8-b38f-e23ecae6f8a1"), null, null, "Alfred53@gmail.com", false, new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190") },
                    { new Guid("7dcf2613-7679-446e-ba8f-d2bdd3271940"), null, null, "Raina.Lakin@hotmail.com", false, new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265") },
                    { new Guid("7e8a04ce-926e-45dc-b4a2-5a719d09272b"), null, null, "Myrtis.Streich@hotmail.com", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("7e9bcc88-4b98-4f93-a67b-8a4c617d581e"), null, null, "Gabriel46@yahoo.com", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("7eda62e1-cdd2-4e47-b8b0-03cfea0a4104"), null, null, "Kenny_Denesik94@yahoo.com", false, new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15") },
                    { new Guid("7ee68e5d-0060-48be-8def-32caf5d4142e"), null, null, "Vincenza.Hickle82@yahoo.com", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("7f038bd0-bbef-421e-87e5-ecd84befe5f5"), null, null, "Matt46@hotmail.com", false, new Guid("bea80970-74bf-4539-a300-cbbac8625744") },
                    { new Guid("7f19eae1-502a-4b17-84df-a43062158252"), null, null, "Noemie95@hotmail.com", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7f274596-98bc-470f-b561-88f06bee96df"), null, null, "Jarod_Torp93@gmail.com", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("7f27c567-af03-4702-b520-907558867e4e"), null, null, "Amie.Huels66@hotmail.com", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("7f575dcc-b3d5-4e69-8856-9a841e82962f"), null, null, "Rashawn.OReilly@hotmail.com", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("7fbef9f7-e164-4c2a-9ef1-2a2018e10cf4"), null, null, "Vena.Pagac13@gmail.com", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("801f4a04-93f9-4d35-9e23-450a33d48320"), null, null, "Clint.Russel82@yahoo.com", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("8020f578-11e8-4c45-a473-3903dc4a5c9a"), null, null, "Ruth.Thompson@hotmail.com", false, new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117") },
                    { new Guid("80b36ee3-e63b-4d33-8cce-cdf93e90691d"), null, null, "Lazaro.Grimes49@gmail.com", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("80da04fe-8558-4e25-b02c-5f77ec2c4e2e"), null, null, "Winfield.Kshlerin@yahoo.com", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("8117a75f-641e-42a2-8a70-1399bb3b197f"), null, null, "Doris60@gmail.com", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("81657fe5-ee18-4035-b2ed-60a7325f6cf2"), null, null, "Cheyenne.Larkin@yahoo.com", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("8192ef6e-f789-4748-a42d-ce965cdbd527"), null, null, "Jamal16@hotmail.com", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("827edf41-0f5c-4afd-9d2c-632de0122520"), null, null, "Nolan75@yahoo.com", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("834e6ab3-d8b6-4aab-8041-b1dd68cd2e46"), null, null, "Sage_Luettgen59@hotmail.com", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("83a4141a-895d-46ce-98fd-6e45d8221bb2"), null, null, "Lloyd64@hotmail.com", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("84df10ac-8dc3-4653-9a66-689f55fcca1a"), null, null, "Savion_Kreiger49@hotmail.com", false, new Guid("c73bd258-469c-4d46-ad89-cd1119310c49") },
                    { new Guid("85c0b9cd-fa18-4469-bc74-33e4fc62ac5c"), null, null, "Cassidy_Terry@gmail.com", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("85f4f002-f091-4e50-a90e-b02e4bfc4db4"), null, null, "Earnest_Bode95@yahoo.com", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("865fed7b-a324-4b83-b961-988c533ec333"), null, null, "Aliya44@hotmail.com", false, new Guid("71978c89-b953-4ec5-98a8-ab384223de1a") },
                    { new Guid("868894be-43f4-4d58-9859-5c550b46063f"), null, null, "Jaylan16@gmail.com", false, new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014") },
                    { new Guid("86a7365b-c93f-4ad0-b61b-1c7698e31551"), null, null, "Amie91@hotmail.com", false, new Guid("364df856-5357-4366-afda-cf52f25f1325") },
                    { new Guid("8740cca1-779a-4df6-acc8-68a0ed0d1450"), null, null, "Holden.Bernhard@hotmail.com", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("877a7a34-c34b-4a52-aae2-7fad19c8cf53"), null, null, "Heather_Lemke37@yahoo.com", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("87eb11d2-78a6-41c2-b230-a4eac8635951"), null, null, "Damien.Crooks@gmail.com", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("88049e33-e567-411c-ab9c-369768b880ad"), null, null, "Emmalee_Rutherford31@gmail.com", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("88325177-06f1-4c4a-a8e2-ad2608385068"), null, null, "Tristin96@hotmail.com", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("888fd22e-8622-4041-af1b-11dfd33b9b96"), null, null, "Emelia49@hotmail.com", false, new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb") },
                    { new Guid("88a1e6c5-43cf-4e2f-b5b8-6e64d768d5c7"), null, null, "Deshawn.Hudson82@yahoo.com", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("88fb08da-ec91-4de3-8c22-ab09c07127a8"), null, null, "Gregoria_Altenwerth@hotmail.com", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("8936673f-b01f-4323-853b-42dc68ea5bbd"), null, null, "Darren.Bailey96@gmail.com", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("89386437-2b2c-4681-8f95-1986f6d53e37"), null, null, "Mathias2@gmail.com", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("89b15b00-f657-4bdb-9ceb-f0078932df3b"), null, null, "Hilton37@hotmail.com", false, new Guid("1ca2e699-11df-445a-8084-51598bee7020") },
                    { new Guid("89b69b84-f949-4bf1-9c78-a6d78d3bca79"), null, null, "Avis_Gutkowski88@gmail.com", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("89b809c8-75b3-43ca-81cd-0aea5886a999"), null, null, "Trey4@hotmail.com", false, new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615") },
                    { new Guid("8a16a1ea-1d42-491e-b280-af7bdb046d16"), null, null, "Dominique_Cummings@gmail.com", false, new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58") },
                    { new Guid("8a57b3d5-8e6e-4016-aa19-1768b039c554"), null, null, "Dianna.Mayer93@hotmail.com", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("8a5bc3dd-8ffc-4739-ae49-ce3162ac6d13"), null, null, "Geo.Hammes29@hotmail.com", false, new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0") },
                    { new Guid("8aa8dbb3-31c7-4c70-a330-d3b17237c346"), null, null, "Adele_Roob36@gmail.com", false, new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267") },
                    { new Guid("8ae6b737-1d28-4417-8770-2042f9918a14"), null, null, "Marilou98@gmail.com", false, new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("8b031ecc-fd74-47ae-b6b4-84267ccb7fe4"), null, null, "Lucio.Ondricka@yahoo.com", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("8b5d6087-a557-419e-b10b-06779f2e366c"), null, null, "Ernest.Blick@yahoo.com", false, new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("8c0117cc-58d1-49c5-be43-191e9e46d6f1"), null, null, "Johanna_Hudson@gmail.com", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("8c103d2b-55eb-491b-a9d6-f5484a92938e"), null, null, "Kari_Abbott87@gmail.com", false, new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("8c126100-6cf5-45e4-9090-b6cde1bf74db"), null, null, "Kamille.Stroman@gmail.com", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("8c2214f8-042d-4f56-9237-dc9efa0b0d59"), null, null, "Jaime.Emard@yahoo.com", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("8d6738a6-4765-4e79-a511-ccbc3d67e08c"), null, null, "Kavon_Barton@hotmail.com", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("8ea666ab-626c-416c-8c76-e559edab279b"), null, null, "Eldridge_Brekke@yahoo.com", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("8f37f567-dbfe-4f88-83fb-da4c21fcc284"), null, null, "Hobart_Okuneva15@gmail.com", false, new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("8fadf004-d6a1-4fb5-afb7-b6a0915c980b"), null, null, "Gilbert.Kuhn@gmail.com", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("8fc7dd81-2333-40c7-8d2d-4f304192c1f6"), null, null, "Norene_Wisozk21@yahoo.com", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("8fdec512-c05b-4f04-9b37-acba44a55bd6"), null, null, "Brant.Johns85@gmail.com", false, new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf") },
                    { new Guid("9058139a-2f25-4009-86a4-0d07ed13d426"), null, null, "Zetta55@hotmail.com", false, new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7") },
                    { new Guid("906974fa-e8bb-4920-b1cb-957c961fd497"), null, null, "Ernesto8@hotmail.com", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("91000542-241f-4d34-a2ac-6cc089907931"), null, null, "Sarah_Ward@hotmail.com", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("9105c640-d9de-4182-b8ea-3a7b3fc14e6d"), null, null, "Garfield.Wyman@gmail.com", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("91064ffd-bf67-47cf-8f66-6dae16f55b4a"), null, null, "Marlon.Langworth@gmail.com", false, new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("91122bbb-97fe-4727-bce2-2c3f36689cdd"), null, null, "Lyric48@gmail.com", false, new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267") },
                    { new Guid("913d01d2-ced7-4115-b419-d2b7e7b0e7c4"), null, null, "Sherwood.Jakubowski@yahoo.com", false, new Guid("a0995ae3-517f-4476-bad0-18fca309cda5") },
                    { new Guid("91adf5f0-cea7-4c66-b984-fbbda4bf66b4"), null, null, "Kaitlyn26@gmail.com", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("9270a5e6-2839-4cd0-bf6f-38356790ad44"), null, null, "Naomi19@hotmail.com", false, new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7") },
                    { new Guid("92d42365-2439-429c-a463-eeafdb3f3552"), null, null, "Gussie_Tremblay70@hotmail.com", false, new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4") },
                    { new Guid("9318637a-edd1-4682-b4e8-6819f7d0e2e9"), null, null, "Kimberly_Ernser@hotmail.com", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("934d1965-5e39-480e-bd8c-c490923741a1"), null, null, "Flavio_Satterfield@gmail.com", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("937842d0-c00f-4184-9d62-b11b4b329880"), null, null, "Weldon.Jacobson@gmail.com", false, new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117") },
                    { new Guid("93837948-334c-4b6b-bc2f-574d0a3ddd51"), null, null, "Nathaniel_Smitham@yahoo.com", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("93b95df1-57c1-4dc0-b3a7-a4e3b5184c40"), null, null, "Hailey.Blanda@yahoo.com", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("93d292ec-963e-4d23-89b2-ed6b86713137"), null, null, "Jamie_Bauch31@hotmail.com", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("9405e9b5-95ef-42fe-ad15-d3dff571a9fe"), null, null, "Freida.Hansen@hotmail.com", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("94ec0fb4-e8a5-48a0-b90f-65ee5b0e6b4a"), null, null, "Tito21@hotmail.com", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("9575a3ad-6bd8-432e-b064-a7a8134fad3f"), null, null, "Kailee.McCullough@yahoo.com", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("95a06247-3da0-4686-9098-e66eb94d5c80"), null, null, "Raymundo_Vandervort78@gmail.com", false, new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f") },
                    { new Guid("95c7c39a-315d-4a00-8756-bef184ff9801"), null, null, "Felipe_Ruecker@yahoo.com", false, new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361") },
                    { new Guid("95d07dab-b4d7-4732-a2bd-17bd731726dd"), null, null, "Bailey_Rohan86@gmail.com", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("95fa5e93-4f32-45ca-93f2-3f61e37af5d7"), null, null, "Zackary71@gmail.com", false, new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105") },
                    { new Guid("960518e3-8970-451f-a9eb-ca6ee1c5d312"), null, null, "Franco83@yahoo.com", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("96ec3cf0-382b-4a08-a33f-a777412aaa88"), null, null, "Willard_Kshlerin@gmail.com", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("96f737b0-c603-48e8-87d3-5cdaee969c19"), null, null, "Cortney_Lesch20@yahoo.com", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("97011844-3bac-4479-bb3d-8c117cd58b12"), null, null, "Vladimir_Hirthe@hotmail.com", false, new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d") },
                    { new Guid("974c5d72-7b2d-4551-9f7a-79b567896589"), null, null, "Walter_Daugherty@hotmail.com", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("979dc634-8ecf-4cde-80bb-ab6f7bf80e76"), null, null, "Kayley_Vandervort36@hotmail.com", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("97d4eacf-fe37-43b8-bca2-7ff5621a6bcb"), null, null, "Stefan.Goyette22@hotmail.com", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("987dac0d-6692-4e8b-9ba1-962226b53eb8"), null, null, "Horacio.Conroy76@hotmail.com", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("987ff072-d8ce-4042-a193-fef4f3ea9cfd"), null, null, "Art.Schneider74@hotmail.com", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("9901d169-4555-497b-af98-c4d68893f744"), null, null, "Miller36@hotmail.com", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("9a010201-a87b-4e22-aabc-cd33bb159d86"), null, null, "Florian.Johnson@yahoo.com", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("9a164990-e805-42bf-83ae-665fb14ec5b7"), null, null, "Serena.Zieme@gmail.com", false, new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("9a4e552e-7985-4455-8f72-d7b8b8975f9e"), null, null, "Jacquelyn_Nader@yahoo.com", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("9a70c268-aef3-464a-b42b-87feaa4b9ae6"), null, null, "Stewart.Howe@hotmail.com", false, new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3") },
                    { new Guid("9a7d267b-88f5-469e-83b8-4a1c3d0e87db"), null, null, "Johathan_Reichert@gmail.com", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("9aced744-5007-40f1-ae7a-dbcb0f5bcddd"), null, null, "Delpha_Walter15@hotmail.com", false, new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad") },
                    { new Guid("9bc74a24-e9fb-4c62-8328-c245088430a9"), null, null, "Heidi.Roberts26@gmail.com", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("9c4fc1c6-e5f7-44cd-addd-6f6a46980568"), null, null, "Cassandre.Maggio@yahoo.com", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("9c548e48-a542-4e39-bd15-894448e77508"), null, null, "Jovanny67@hotmail.com", false, new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841") },
                    { new Guid("9cc6e306-3f8b-46d8-b7f9-eba8599878ce"), null, null, "Santiago.Moore@yahoo.com", false, new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab") },
                    { new Guid("9cd8b74f-dc28-4a60-8bc5-fd9dcc3024fd"), null, null, "Celia.Schaefer@hotmail.com", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("9d1d9d68-dea3-4a0b-87f4-6998cc130e06"), null, null, "Melyssa.Nader90@yahoo.com", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("9d29531b-8915-4dd5-bc33-38dd99df9e90"), null, null, "Marquis9@hotmail.com", false, new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95") },
                    { new Guid("9d35d348-8b1a-410c-8c4c-789846f7ac5c"), null, null, "Maryjane89@gmail.com", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("9d8dc30a-060d-486e-a5cb-1072e988fd54"), null, null, "Pattie61@hotmail.com", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("9da39162-3bd7-491c-8e7e-f30d19b70e58"), null, null, "Guadalupe_Kemmer@hotmail.com", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("9dc67bdb-68d5-466d-9721-6bb3001b79b4"), null, null, "Ruben.Bogisich45@hotmail.com", false, new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8") },
                    { new Guid("9e3f8b18-60ec-4856-b07b-ef7f6240e8ab"), null, null, "Emma_Hackett18@gmail.com", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("9e70fb0f-bc2d-4b13-8b7f-b795f409cdfe"), null, null, "Kayla_McClure56@hotmail.com", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("9f17c6ba-0036-407a-a377-40210cd83809"), null, null, "King33@gmail.com", false, new Guid("bea80970-74bf-4539-a300-cbbac8625744") },
                    { new Guid("a0e0a01c-40ce-457e-b2c4-41cf18c302c7"), null, null, "Trever67@hotmail.com", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("a0f8f239-2418-41f1-9d35-b36aa4e6359b"), null, null, "Melisa51@hotmail.com", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("a1a7bb4b-28f0-405f-9eda-d85bf007c3b5"), null, null, "Weldon96@hotmail.com", false, new Guid("c187c610-03e7-4305-96e2-96f776a463e0") },
                    { new Guid("a203b29c-3806-4ede-984a-bc61e94708e9"), null, null, "Janelle_Berge@hotmail.com", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("a2920716-befa-4847-a4c7-53a1dd1b7a0e"), null, null, "Johanna.Koepp7@hotmail.com", false, new Guid("ec149744-9128-4f41-875a-1c96bf1c851c") },
                    { new Guid("a2ebbfe6-2930-40f4-a277-d07360b8ac69"), null, null, "Guadalupe.Hammes25@gmail.com", false, new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("a30f4d63-b804-425b-bfdd-0d4ae4975bc5"), null, null, "Brionna72@yahoo.com", false, new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968") },
                    { new Guid("a35d5f83-6997-48ff-9915-4f4a08270234"), null, null, "Mckenna_Langworth19@gmail.com", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("a3af814e-f540-473d-92cc-1f2762b3a1ce"), null, null, "Barry_Langosh29@gmail.com", false, new Guid("a836bc35-12f7-485d-861b-ad1645878c24") },
                    { new Guid("a42a8b34-d470-45fc-943e-8e5b140c09e5"), null, null, "Stefanie32@yahoo.com", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("a4583c4c-e9e8-40ab-8e87-debb3d9d5b93"), null, null, "Brycen_Windler24@hotmail.com", false, new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("a45c40b4-0a3d-4069-8788-f9c78cab65b9"), null, null, "Ismael_Raynor@hotmail.com", false, new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115") },
                    { new Guid("a4d0fb24-b9ab-4c44-a315-c116092d9ced"), null, null, "Layne47@gmail.com", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("a4d6838f-da3a-4a52-909c-713a427c9a4e"), null, null, "Ludwig.Champlin@gmail.com", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("a5b08b59-ad9e-48a7-a16a-82db9fd7978d"), null, null, "Lenny_Schumm86@gmail.com", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("a5b2bc3a-17e7-4c34-96ba-bc04addef856"), null, null, "Eryn95@yahoo.com", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("a5f35200-c328-46d6-a838-c7b92d36f468"), null, null, "Cecilia.Jacobi@yahoo.com", false, new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd") },
                    { new Guid("a62dba9c-69f4-494f-b8cd-8cd1a4376865"), null, null, "Mohammad_Mosciski@yahoo.com", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("a6388ae6-6905-48ee-9d47-4222e3a2d498"), null, null, "Orion73@hotmail.com", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("a66741a9-d6c7-4541-872d-ad7823fb4b4a"), null, null, "Judah_Lindgren@gmail.com", false, new Guid("4860b124-2e67-49cc-b664-135729261ac4") },
                    { new Guid("a6b6fc96-203c-4c00-97b4-f16cc0549cef"), null, null, "Lonzo.Gislason@hotmail.com", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("a74d00ec-fa64-442a-b172-5a35540d08d0"), null, null, "Germaine_Price78@gmail.com", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("a7fd1d37-addb-41f8-96f3-56732e2d8605"), null, null, "Alene58@gmail.com", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a80dd573-83a5-4be9-b3b1-0b81f4ac2604"), null, null, "Bobby_Ziemann@yahoo.com", false, new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("a8288a74-28e4-4704-b264-b71ed2b5a23a"), null, null, "Americo.Krajcik@yahoo.com", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("a888a423-ca7c-4707-bb14-99e0213aa98c"), null, null, "Cooper.Rowe97@yahoo.com", false, new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2") },
                    { new Guid("aa5f1ca1-720b-4d5b-9f5c-2cf274ec2542"), null, null, "Ova.Wintheiser@gmail.com", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("aa824558-5585-42b7-ab45-b9e4aea88194"), null, null, "Amelie84@yahoo.com", false, new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6") },
                    { new Guid("aab2e8b0-880c-428e-ab18-2cfbcb938bca"), null, null, "Melvina.Farrell@yahoo.com", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("aad1bd67-2980-4bd7-8371-b57d59f6c56b"), null, null, "Jewel.Mills@hotmail.com", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("ab26d670-7424-41f3-922a-559eabae0781"), null, null, "Angeline98@yahoo.com", false, new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9") },
                    { new Guid("ab725054-002a-4eda-9363-92487932ae07"), null, null, "Barton.Wyman@gmail.com", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("ab8e9c14-1a3c-4ebc-a485-681ab8eee7c0"), null, null, "Hayden0@yahoo.com", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("ac16039f-b9c2-4904-8a5e-4ce7fbdf501a"), null, null, "Deion_Bahringer74@yahoo.com", false, new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8") },
                    { new Guid("ac25b58b-a5cc-44cf-a8ea-181c556a3cbf"), null, null, "Tierra.Hammes@hotmail.com", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("acf6d590-9579-4008-a253-c18e834101db"), null, null, "Katrina.Berge57@gmail.com", false, new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca") },
                    { new Guid("ad8a4144-d2ff-49a6-a8d7-f0dfde96f499"), null, null, "Tad_Halvorson@yahoo.com", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("add752e5-79be-4061-af7e-c1a77aa48e8f"), null, null, "Deron.Tremblay82@hotmail.com", false, new Guid("e8293c7e-c598-445f-a509-d9123149ec52") },
                    { new Guid("ae31e568-9545-4ac6-afa2-8c5cf43ca671"), null, null, "Angeline65@yahoo.com", false, new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc") },
                    { new Guid("ae47b51a-f64e-4431-b65c-7daba24faeb6"), null, null, "Jaren47@hotmail.com", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("ae788031-248f-4b7f-8b71-0ba9929ed8b6"), null, null, "Muhammad_Sawayn@yahoo.com", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("aea7f2f1-7c12-4b31-9b4b-1eb7cfa99777"), null, null, "Julie45@gmail.com", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("af351550-7aa1-45f5-aafa-054e253d992b"), null, null, "Kraig_Doyle@hotmail.com", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("af962445-bf03-406d-9e52-878bc9acce1f"), null, null, "Amber.Bednar56@hotmail.com", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("afb2cd6b-50fa-4dae-9238-17f087d77adb"), null, null, "Antoinette.Simonis@gmail.com", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("b04357fd-fb3f-47c4-8c7d-6d584ec3e7a5"), null, null, "Garrison39@yahoo.com", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("b05acab7-7b81-4c67-b8ff-8921e6a5722c"), null, null, "Reymundo_Hermiston@hotmail.com", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("b07666b5-84ca-4cdd-92dd-708e806b5ba3"), null, null, "Jamal.Lowe30@gmail.com", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("b08aa66c-f3aa-47f5-877f-4948852cc79e"), null, null, "Carlo64@gmail.com", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("b090c7fb-7de8-4e8f-a477-544867eb6339"), null, null, "Dorcas_Mayer@gmail.com", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("b0a6b19d-403f-4d26-bf79-747be6255690"), null, null, "Kennedi.Bode76@gmail.com", false, new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("b161a7a9-313b-4d6c-a529-3efeb73b68d2"), null, null, "Don34@yahoo.com", false, new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("b1b7b47c-2b80-42c8-8323-74e48b10a852"), null, null, "Veda19@gmail.com", false, new Guid("431cb355-ae94-49cc-882c-971e60381b53") },
                    { new Guid("b26499d2-b15a-4ca2-8e05-c664d5ed06c7"), null, null, "Marvin53@yahoo.com", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("b2a71745-b1bc-4a60-beeb-5913f2593b18"), null, null, "Germaine_Kuhlman40@hotmail.com", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("b3153821-a2f1-4c32-80e2-4cde126706f6"), null, null, "Kaci.Douglas20@gmail.com", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("b345d608-e810-4012-bebf-5ed2e34d9ee5"), null, null, "Nellie_Runolfsdottir86@gmail.com", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("b3869f59-caa5-4d85-b8d8-ad576bc810f2"), null, null, "Milford.Bernier@yahoo.com", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("b3a19be2-f50d-463c-8aeb-2a4178afcd15"), null, null, "Eino22@gmail.com", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("b3b8fb25-14c6-4fb1-bc99-9f223f7198df"), null, null, "Maddison.Adams@hotmail.com", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("b3cf2c5f-a10d-4fae-b92d-5e290b86d5e9"), null, null, "Kirstin94@gmail.com", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("b3ef13b2-f3b4-4cd7-a9d2-36b12cd55553"), null, null, "Mohamed.Dare24@hotmail.com", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("b47f9623-c1b8-47ae-b57d-2eeea41dc3a9"), null, null, "Elva_Gislason84@yahoo.com", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("b49b74b8-fd85-4fa0-9a01-e980eca4e814"), null, null, "Owen.Hartmann33@yahoo.com", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("b5177291-67b7-42fb-b31d-b865c9cc7bbe"), null, null, "Dolly.Greenfelder@gmail.com", false, new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b5281477-4929-428c-ba49-288bfeb0932a"), null, null, "Joyce.Dicki@hotmail.com", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("b5281890-d5e4-44f6-8fed-3418f06928c8"), null, null, "Antonette95@yahoo.com", false, new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c") },
                    { new Guid("b5ae1f9f-945e-48fb-8ccf-fd5a39364a88"), null, null, "Alexander_Littel@hotmail.com", false, new Guid("316bd6de-f98f-4240-856b-7b943204b4fb") },
                    { new Guid("b5d7beec-c40e-49c6-bf3d-3678889a2d1b"), null, null, "Dolores_Shanahan63@gmail.com", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("b6d9af7c-f9df-4a42-89bf-929962a7cf74"), null, null, "Lottie_Turcotte@gmail.com", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("b6dff1eb-3855-47a1-82dc-006836aeeb94"), null, null, "Reanna7@hotmail.com", false, new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4") },
                    { new Guid("b76eae6c-868a-4293-ad5c-087811370a21"), null, null, "Annamae_Langosh71@hotmail.com", false, new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f") },
                    { new Guid("b77ade23-27f5-491f-bbf4-c364b6ff9e48"), null, null, "Archibald_Jerde37@gmail.com", false, new Guid("60f7f230-ff82-425a-a6c5-cc5156098000") },
                    { new Guid("b877173d-276b-4fc8-ac06-b667573526f7"), null, null, "Irma_Fritsch@hotmail.com", false, new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8") },
                    { new Guid("b8c0e6d7-f45f-4156-aa66-fca1ee30ea30"), null, null, "Deangelo_Heaney66@yahoo.com", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("b8cb10ce-8feb-489c-845f-fc7e55f5aa69"), null, null, "Kristoffer_Torphy@yahoo.com", false, new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35") },
                    { new Guid("b909fa4a-1736-443c-af98-9fbf1def50e2"), null, null, "Veronica41@yahoo.com", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("b94f6c2a-00a2-4cea-8203-bc40a9ad735b"), null, null, "Kody_Nitzsche@gmail.com", false, new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3") },
                    { new Guid("b999b702-db68-4dec-a7c9-06c0eb081d7c"), null, null, "Gladys67@yahoo.com", false, new Guid("316bd6de-f98f-4240-856b-7b943204b4fb") },
                    { new Guid("ba0dddad-ea24-44b7-bdb0-a2547bfa3d81"), null, null, "Rasheed_Kulas@hotmail.com", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("ba3a72e3-fe20-4c0d-8f50-b906e12bbae9"), null, null, "Angela.Toy@hotmail.com", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("ba8d0901-a248-4851-87bd-b28cac3cab01"), null, null, "Ansel.Haley@yahoo.com", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("bb882aaa-bb98-485f-bb91-201831b15c6a"), null, null, "Abigail48@yahoo.com", false, new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("bc72f5b7-24ac-4dad-94c5-9df662d2ede3"), null, null, "Jaden.Kohler@hotmail.com", false, new Guid("26e9f9a9-c77f-4f47-b594-e602be058706") },
                    { new Guid("bca939ac-e0db-4742-b22d-3c3ac2ed4b41"), null, null, "Felipa95@hotmail.com", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("bd3d00fe-92e0-4487-b696-7b4d37a32962"), null, null, "Ebony_Tillman8@gmail.com", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("bd8a4966-e8dd-48c6-8a80-3b55f13a42c1"), null, null, "Alfonzo12@yahoo.com", false, new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63") },
                    { new Guid("bdbb856b-9a77-483b-9fc5-9968663c6d7f"), null, null, "Mervin_Larkin67@hotmail.com", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("be0c6fba-32c2-4279-a8c5-909f4df082f7"), null, null, "Jefferey_Parisian@gmail.com", false, new Guid("c41a987e-114e-4968-aa63-744e27096322") },
                    { new Guid("be854924-bae2-43b4-931c-88ee84f3e72f"), null, null, "Garret.Dickinson77@hotmail.com", false, new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92") },
                    { new Guid("bed1e76e-0075-4707-9bb0-cd71f435f652"), null, null, "Brielle28@gmail.com", false, new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696") },
                    { new Guid("bed3a6dd-86cc-4f0f-ba7d-8cfa97dc52fc"), null, null, "Jennings_Schmidt@hotmail.com", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("bf267c48-0e33-48dd-bb3f-f5bd190a6e2b"), null, null, "Samson_Mann26@gmail.com", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("c03a5181-e074-4d4e-8a5a-9f3534331941"), null, null, "Nicolette.Olson@gmail.com", false, new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("c0c7a7ee-6f3d-4c76-8931-73b81354a2ad"), null, null, "Westley.Sporer@gmail.com", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("c22b7060-e2e4-4996-97db-566fcf470156"), null, null, "Joesph_Jast60@yahoo.com", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("c23b8cb7-6cf4-4207-88fe-fa3fc2309466"), null, null, "Shania.Zemlak58@yahoo.com", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("c25c9283-cdc1-4f48-9e17-1f5d977972a3"), null, null, "Hubert.Williamson35@yahoo.com", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("c2bd5d41-c1c2-44be-bb07-c25d9250931c"), null, null, "Frederick61@yahoo.com", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("c2f9e4e1-fa9e-4638-86a2-8b699aa50035"), null, null, "Torrance94@hotmail.com", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("c34632e7-8471-4da6-ab2e-6e86759b5565"), null, null, "Krystel64@hotmail.com", false, new Guid("05fb67eb-3b60-4c93-bf80-36153be08871") },
                    { new Guid("c36c20bc-1f7a-425c-bb17-94a9f7fc978c"), null, null, "Rae.Hilpert75@hotmail.com", false, new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615") },
                    { new Guid("c37ee377-1a73-4dbc-a28e-f1643eb82052"), null, null, "Claudie_Von94@gmail.com", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("c4519f4e-fab3-4535-8058-aa8dd42f57b9"), null, null, "Tyrell6@yahoo.com", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("c4be8266-9d4c-4f41-b622-4fa158e669f2"), null, null, "Tyra_Hodkiewicz32@hotmail.com", false, new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e") },
                    { new Guid("c4c3c765-9bb9-49e6-98e9-d5f9f21b7afc"), null, null, "Charles_Cartwright19@gmail.com", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("c4f74d66-e6bf-4114-b7c9-60f990689db6"), null, null, "Rollin.Crist54@gmail.com", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c4f92bde-5689-4f83-994a-84e00b46d333"), null, null, "Liam86@gmail.com", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("c5056e90-b72d-4a63-883e-bae9de81e88c"), null, null, "Annie.Kris24@gmail.com", false, new Guid("82d8841b-b98c-463c-96d0-9378cf908740") },
                    { new Guid("c5bc644d-8cb2-485e-a6f7-d692c3513333"), null, null, "Esperanza18@yahoo.com", false, new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4") },
                    { new Guid("c5bc9834-b298-4d34-8a7e-525a1e568809"), null, null, "Hildegard_Kulas@yahoo.com", false, new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63") },
                    { new Guid("c6500099-b3cc-4bab-a61e-2f84260e4eac"), null, null, "Bridie24@gmail.com", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("c650833f-f0d6-475c-85f2-d4cf7f4ae709"), null, null, "Brenna_Douglas@yahoo.com", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("c7525089-0faf-49ad-9ad5-5eed9fafdabf"), null, null, "Albert_Pouros@yahoo.com", false, new Guid("a8115124-4280-4a52-8af7-cb635f456958") },
                    { new Guid("c81f1636-f0b0-42e1-9368-2197be5d8dc6"), null, null, "Rosa_Hermiston27@yahoo.com", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("c893a387-8847-4320-82e1-1a6aa4f2693a"), null, null, "Helmer_Legros71@yahoo.com", false, new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276") },
                    { new Guid("c8b2529e-eb55-43d8-8db6-61cd52ce5811"), null, null, "Skyla23@gmail.com", false, new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd") },
                    { new Guid("c9325aec-9d5e-4313-8023-2a2ca2bba190"), null, null, "Ettie.Bartoletti@gmail.com", false, new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79") },
                    { new Guid("c985f08d-3927-4784-a2f4-c051a65d7daa"), null, null, "Jane9@hotmail.com", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("c9c9cad4-0a5e-408c-a08f-1b3132925e00"), null, null, "Darby.Cronin6@yahoo.com", false, new Guid("fa64f167-af58-425d-8dce-93642bd7650a") },
                    { new Guid("ca4cd18f-b029-4295-acfd-834a603b76a3"), null, null, "Miller49@yahoo.com", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("caa51722-3719-4c8b-95b1-c5542a113817"), null, null, "Elvis_Lubowitz28@gmail.com", false, new Guid("431cb355-ae94-49cc-882c-971e60381b53") },
                    { new Guid("cae95964-657a-4f3e-bf93-2cfca431c365"), null, null, "Nikita_Lang46@gmail.com", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("cb97bdf0-9483-4aa8-a0b8-37daeac0949e"), null, null, "Skye.Gutkowski@hotmail.com", false, new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549") },
                    { new Guid("cbd74e30-323a-4a5f-a8b0-064383bd90ee"), null, null, "Jaren.Ullrich10@hotmail.com", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("cc0a1bd6-4c93-47dd-9b3b-a6aa02a586cc"), null, null, "Tess.Corwin62@hotmail.com", false, new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a") },
                    { new Guid("cc983ad6-c141-43e8-8dec-8241a7797108"), null, null, "Polly.Herman@yahoo.com", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("cc9a6ad4-3acb-44df-9bec-f60db6a8a7cd"), null, null, "Tierra54@gmail.com", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("cd1678ae-9ee6-472d-86a2-a87fe141be4f"), null, null, "Madyson.West1@hotmail.com", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("cd66647f-2228-4907-b8d2-13f79b243580"), null, null, "Maude_Lesch@yahoo.com", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("cd7daa6d-ee31-41a1-9f96-7feb41f146b4"), null, null, "Fannie.Luettgen@gmail.com", false, new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443") },
                    { new Guid("cd85f2aa-5d6d-49c2-9b72-f2a3abb63e84"), null, null, "Casimir_Gutmann10@gmail.com", false, new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841") },
                    { new Guid("cd914c63-96a7-43d0-bf69-7ccb5e7e4e01"), null, null, "Domingo6@hotmail.com", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("cdbb04d6-bd6a-4819-8718-3d2f07388efa"), null, null, "Richie38@gmail.com", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("cdc2f9e6-6cf8-4e8b-8eb5-a20d03a4d581"), null, null, "Durward_Walker@gmail.com", false, new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db") },
                    { new Guid("cdd21a67-6856-4826-a50b-5ea10a3a62cb"), null, null, "Marianne_Watsica33@yahoo.com", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("ce5b62c7-b810-4f72-9d0a-a2a7f54f98fc"), null, null, "Jesse42@yahoo.com", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("cedb738b-a4f6-440e-9064-73be232c80b8"), null, null, "Ruben.Fisher@gmail.com", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("cf0df954-765a-4a4f-8ca2-20eace603d21"), null, null, "Aric28@yahoo.com", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("cf0ffae6-fd69-4436-9471-8e96aa663cd7"), null, null, "Gennaro.Leuschke37@gmail.com", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("cf5b3578-7c42-41fd-a38f-3eb5a9605b26"), null, null, "Guido.Krajcik92@gmail.com", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("cfa93680-9997-4d39-8494-e04ed0772569"), null, null, "Vilma.Leffler36@yahoo.com", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("cfcbf441-e21c-46f8-b82d-a8c4e537c79f"), null, null, "Bulah20@hotmail.com", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("d003f157-4acb-4656-8a6f-8d58e735855e"), null, null, "Blaze.Reilly@yahoo.com", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("d025c3b7-c2df-40d9-a9ad-080e3d38d483"), null, null, "Diamond.Tillman@gmail.com", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("d080cf26-da6e-46e5-b22e-e14d0463f6dc"), null, null, "Cathrine_Parisian31@yahoo.com", false, new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab") },
                    { new Guid("d093036f-6126-485d-b8a7-e4812b734a51"), null, null, "Kaylah_Kuhlman70@gmail.com", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("d0b96ebd-6895-4db1-ad3d-3aeb5c8bf0b6"), null, null, "Bradford.Schamberger13@yahoo.com", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("d109bc2d-eecb-4919-98e3-3f0a44bbfaef"), null, null, "Meta.Hessel@yahoo.com", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d1907980-b3fa-4c85-8ef5-5131bba38ea7"), null, null, "Jasmin.DuBuque79@yahoo.com", false, new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808") },
                    { new Guid("d21e74b1-dde7-4f23-bc01-f36ea1fed380"), null, null, "Gregorio.Block6@yahoo.com", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("d25c0462-95be-4c0f-94c3-d448bb85f3da"), null, null, "Jean68@yahoo.com", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("d2b5e956-c27a-44d4-9bd3-75e9c6c6d5df"), null, null, "Thelma.Kling52@hotmail.com", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("d39e31b1-e153-4e0e-9fe8-bbdb5dec8f60"), null, null, "Jordane47@yahoo.com", false, new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf") },
                    { new Guid("d409fbf2-2877-40b0-8a9c-32b3b694cac3"), null, null, "Porter.Shanahan33@yahoo.com", false, new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e") },
                    { new Guid("d43206c0-502f-4e02-986a-89a80b7f6f5d"), null, null, "Irwin.Gerhold@yahoo.com", false, new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf") },
                    { new Guid("d44712ca-61cf-4246-8fa8-b0e0a310db9d"), null, null, "Viva.Wilkinson29@hotmail.com", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("d47e5b4d-807a-42d2-9b0a-b753c37662d3"), null, null, "Marques88@yahoo.com", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("d499fa84-83f7-4f34-8045-b12617ea299f"), null, null, "Cleora_Wisozk@gmail.com", false, new Guid("b74d612a-560a-493f-9b9a-e7d76b857600") },
                    { new Guid("d4a0f8d6-6175-4c38-bf7d-0b533e7b26a0"), null, null, "Danyka_Kuvalis@gmail.com", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("d4ceed01-190f-4f2c-88d0-9e9248ce190b"), null, null, "Kenyatta_Stiedemann@hotmail.com", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("d4d95935-6537-456a-ac0f-59015f078d1e"), null, null, "Madaline98@yahoo.com", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("d4ec9564-f81c-41ed-bb63-e897df017483"), null, null, "Mortimer_Kulas48@hotmail.com", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("d50dccce-2a5d-462a-a7a5-2e6de7898809"), null, null, "Waylon_Zieme@gmail.com", false, new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db") },
                    { new Guid("d5e2ed74-fe19-41de-abc9-5cf9307e273f"), null, null, "Lottie_Blanda@gmail.com", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("d63d33d6-5e0b-49c2-b016-c0f7563e35a8"), null, null, "Adolphus.Douglas@yahoo.com", false, new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7") },
                    { new Guid("d6b0b85a-7105-4af2-a9d7-09e50c3ef84d"), null, null, "Kasandra_Torp78@gmail.com", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("d722429b-a7eb-4423-a479-1793c289ec51"), null, null, "Dylan26@gmail.com", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("d7c32541-ee0b-4a9d-a962-158a4cf066e3"), null, null, "Tia.Dooley80@hotmail.com", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("d84940cb-f82d-4dd9-8e0b-46277a660bf9"), null, null, "Monte_Schumm@yahoo.com", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("d8a198df-ccfd-41ab-ae37-15ebf74839c8"), null, null, "Wallace_Grant@hotmail.com", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("d8bdd280-d44a-42d0-ac52-a38682a42b98"), null, null, "Dessie20@hotmail.com", false, new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588") },
                    { new Guid("d8f31839-eacc-4733-9f5a-1fd726cb6be5"), null, null, "Chet61@gmail.com", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("d8f4df62-7e65-4c63-a601-478b958e7947"), null, null, "Savanah_Watsica@hotmail.com", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("d90cbc3c-9f57-4279-9ae2-bc0dc1c690a3"), null, null, "Emory6@hotmail.com", false, new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a") },
                    { new Guid("d9585c76-bf46-46ae-b24e-ec0af6ea7db1"), null, null, "Elna12@hotmail.com", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("d996cf78-f135-476d-86cb-6203f1a3c4ef"), null, null, "Miracle.Brakus@hotmail.com", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("d9a7ea29-9e42-4bb9-88ac-c11387490b3f"), null, null, "Darian21@gmail.com", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("d9eb003b-d85e-4b33-b214-355ef37ce87f"), null, null, "Doyle64@hotmail.com", false, new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8") },
                    { new Guid("da43d328-36b5-4aec-8751-27f4effa2d9e"), null, null, "Vergie85@gmail.com", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("da794a73-ab0a-4f43-b164-b472674f82fb"), null, null, "Moises33@yahoo.com", false, new Guid("4390173e-3194-44b0-9f5c-e816c829e49d") },
                    { new Guid("da84a0df-3bc1-4c32-b8cc-8073f6cb9f20"), null, null, "Ezekiel.Hoeger98@yahoo.com", false, new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968") },
                    { new Guid("db08fdd2-f90c-4379-9144-3f32fdbfa8b2"), null, null, "Kareem.Gusikowski76@yahoo.com", false, new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4") },
                    { new Guid("db5418fa-36ce-4017-b68d-1bae904c3a36"), null, null, "Rachel.Stroman@yahoo.com", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("db620e9c-a601-4ea2-a8cd-d5b8201092ef"), null, null, "Jordyn_Kuvalis@yahoo.com", false, new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3") },
                    { new Guid("dc30d966-a06a-48a7-a4a0-0c2aee96d846"), null, null, "Lucas36@gmail.com", false, new Guid("787d2d2c-d05b-4935-906f-090d713b622f") },
                    { new Guid("dca03e83-1dc3-43f4-ab05-bcacab7eb5f7"), null, null, "Celestino74@hotmail.com", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("dcb404e4-19a9-47a5-9de3-2e5876c40739"), null, null, "Chester.Wilderman82@hotmail.com", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("dccc4c14-a2f5-48a4-b849-23af72e3c51f"), null, null, "Lexie30@yahoo.com", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("dcd25ec2-e70f-43a3-aa24-4f705625e13b"), null, null, "Zackary75@hotmail.com", false, new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("dcde3ea4-f07e-4946-921c-c62f944969ee"), null, null, "Eduardo.Ullrich66@yahoo.com", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("dd084d6f-1eae-4044-b6c9-c424981cca3d"), null, null, "Brent.Huels@hotmail.com", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("ddace32b-9d51-4f34-8f17-bd0b8d56ee96"), null, null, "Julianne20@yahoo.com", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("ddbc062b-ba4a-46ba-a1d6-6d6f86c6a486"), null, null, "Alessia66@gmail.com", false, new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2") },
                    { new Guid("de3aa487-f3a7-4665-950f-b1236498dff9"), null, null, "Hilbert_Towne5@hotmail.com", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("de6748d7-868a-4088-b21f-7b435464b799"), null, null, "Izabella_Bernier@yahoo.com", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("de948220-df95-4a6c-a4d3-e16daafbddcc"), null, null, "Linnea84@hotmail.com", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("deae0a66-e557-4122-8b5d-7341493c80a5"), null, null, "Marquis55@gmail.com", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("dee7b05c-8f52-4d30-8d46-517cabed50f9"), null, null, "Bernie99@yahoo.com", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("df4a6ce2-7c06-48e0-9ae2-33d288d04dd0"), null, null, "Cooper_Nolan@hotmail.com", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("df5a44a4-5b30-4a79-92ca-89e5d953d25a"), null, null, "Leonor.Schmitt12@hotmail.com", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("df902011-97bb-46a6-b97a-e45dc52b8483"), null, null, "Jarvis_Bailey@yahoo.com", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("dfb3f917-93ab-4c57-a6f4-046a024220a1"), null, null, "Marshall.Marquardt@hotmail.com", false, new Guid("ec149744-9128-4f41-875a-1c96bf1c851c") },
                    { new Guid("e0886011-1354-4fa3-b48f-c94d2a786e02"), null, null, "Esther39@gmail.com", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("e08d4fcd-193a-483a-9293-86554f2e526e"), null, null, "Mathew68@yahoo.com", false, new Guid("354e9bbf-de43-4345-a871-f0af96ec9410") },
                    { new Guid("e097d41c-d0dc-4f53-b80c-72b7cfe414a8"), null, null, "Rosamond.Price86@hotmail.com", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("e0dfa202-7613-4b41-b70e-1f27bc8f4970"), null, null, "Christina.Rempel22@yahoo.com", false, new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f") },
                    { new Guid("e17c55ab-d1e2-4ea1-807c-7fba20c97a00"), null, null, "Faustino66@hotmail.com", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("e18ef617-d4eb-4b9a-9cc2-417901f8bf52"), null, null, "Selina.Beatty@hotmail.com", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("e1d36223-0c34-413b-b58d-7a1a3803a3d5"), null, null, "Enrique_Beier59@hotmail.com", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("e1e37001-30b3-481e-a05c-cc1ce4210060"), null, null, "Verna_Romaguera93@yahoo.com", false, new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c") },
                    { new Guid("e2ad75b3-784c-429b-b164-914372948fbb"), null, null, "Arlie65@gmail.com", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("e2aef8b5-bccd-49bd-965a-8fe3f4fc4033"), null, null, "Elinore_Halvorson@gmail.com", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("e2c9ce37-ba9c-46b9-8539-0bae26ec8aa2"), null, null, "Marcelino_Gutkowski@yahoo.com", false, new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("e2d15089-5db9-4035-829f-3345b29131a0"), null, null, "Eden.Keebler@gmail.com", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("e2da2bdf-3917-4f60-a70f-8af2b772200a"), null, null, "Polly.Brakus@yahoo.com", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("e2e429d7-d391-4b5c-9586-ecb4f78985cc"), null, null, "Reyna_Miller52@gmail.com", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("e3b09ad0-126b-4e66-8eb4-a2f952c8973d"), null, null, "Florine_Schiller83@hotmail.com", false, new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457") },
                    { new Guid("e3e3c4e2-5251-4edb-92f5-6792d74f87bc"), null, null, "Nathanial_Howe22@gmail.com", false, new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6") },
                    { new Guid("e440551d-c0c0-4d38-a0b8-323d9d70176e"), null, null, "Elroy52@hotmail.com", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("e46b16a3-26b4-4fec-9840-1707885dcdae"), null, null, "Randal_Stark@gmail.com", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("e4c84256-6358-4224-b4a8-354179025ae6"), null, null, "Sofia8@hotmail.com", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("e5265ad6-14d6-4c5a-a5b8-cb5c26d6dea7"), null, null, "Luis_Rogahn77@yahoo.com", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("e55487b0-c145-4340-b5af-55298cb5506c"), null, null, "Jennyfer_Blick63@hotmail.com", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("e55e7a81-1161-4204-9df3-00a1616b978c"), null, null, "Tania.Lesch42@gmail.com", false, new Guid("285d8d29-53de-4979-a403-f61b887fa207") },
                    { new Guid("e5857fbe-a819-488d-8e88-a51af20ec7bc"), null, null, "Melissa.Larson@yahoo.com", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("e6547a82-51ba-4371-980d-0aa3a5eddaae"), null, null, "Jay.Walker@gmail.com", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("e66e026a-b864-4bcd-9700-ce51f604fe97"), null, null, "Tyrique53@gmail.com", false, new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0") },
                    { new Guid("e6e8e1db-56cf-4e17-9c9a-d084aa73c94a"), null, null, "Reina14@yahoo.com", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("e769e756-1c76-45e1-a5d7-246c596b0577"), null, null, "Onie.Ratke82@gmail.com", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("e784edb9-8e95-4fec-a3af-5acd8a686208"), null, null, "Esmeralda.Feil43@yahoo.com", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("e7b55203-4147-4b6b-b5a1-d817e3518717"), null, null, "Jeanne.Wehner34@hotmail.com", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("e7da1aad-b57c-4154-82c9-6f79a8880d38"), null, null, "Kaycee33@hotmail.com", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e7e7c8e0-c1ad-4fb3-a061-f17ce4e81df2"), null, null, "Emilia_Koss95@yahoo.com", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("e8eeac78-f1cd-4b9b-a8c8-7ae6b042a9a1"), null, null, "Logan_Thompson28@hotmail.com", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("e90156b1-2fe0-4226-a1e5-9f55b76623a2"), null, null, "Bulah_Torp8@hotmail.com", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("e904691e-498a-49aa-ab5b-12c5b7426bfd"), null, null, "Leopold34@gmail.com", false, new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("e94f04c9-33e6-402a-b0c3-94fd9f125973"), null, null, "Janick26@yahoo.com", false, new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53") },
                    { new Guid("e9ec82b3-7c7c-4fa6-a303-2f74a17aa432"), null, null, "Eryn_Hermann@gmail.com", false, new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5") },
                    { new Guid("e9f66311-3985-4f41-a5a2-da4da725cc9b"), null, null, "Sven2@yahoo.com", false, new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95") },
                    { new Guid("ea6f6f64-00e8-4521-a016-b21faf0e8eb1"), null, null, "Marianna98@yahoo.com", false, new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1") },
                    { new Guid("ea6f99a0-0ab3-4744-870b-e9ef95effde1"), null, null, "Danny54@gmail.com", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("eabb31c5-4416-4004-8051-ad406b2605d6"), null, null, "Antone_Cormier@hotmail.com", false, new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd") },
                    { new Guid("eae97835-f475-4008-bff5-dface25481b7"), null, null, "Euna84@gmail.com", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("eb35ddd3-9411-4235-9354-99d196f15f56"), null, null, "Camila64@hotmail.com", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("eb740421-2ac3-4a60-b539-eb94223ebedb"), null, null, "Rhett.Carroll57@hotmail.com", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("ec1ff4f6-84ef-4604-a905-22dc6cdedfbb"), null, null, "Ivah32@hotmail.com", false, new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc") },
                    { new Guid("ec94b373-5dd0-4cdb-b264-0dad26b4ae05"), null, null, "Marcelo_Krajcik4@hotmail.com", false, new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd") },
                    { new Guid("ec9c2ecf-350d-4178-ac1e-790467309a9b"), null, null, "Electa_Deckow34@hotmail.com", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("ecda909d-1d0e-4ab1-a06e-4f41b6310c41"), null, null, "Jakayla_Schiller@yahoo.com", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("ecf7587a-4adf-4190-8c26-db86132578c6"), null, null, "Buddy28@hotmail.com", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("ed681f37-50a2-4fd1-8e7a-e584aa887f59"), null, null, "Vicky94@gmail.com", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("edfd40bb-692c-42c6-81a7-5b5385b552ef"), null, null, "Hulda.Auer@yahoo.com", false, new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53") },
                    { new Guid("ee0478d7-ee4b-472f-83d1-f8bcbebf5a6d"), null, null, "Fanny97@yahoo.com", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("ee4e78a3-0449-4784-8b1b-015c43e51ffd"), null, null, "Cory.Doyle37@gmail.com", false, new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549") },
                    { new Guid("ee9909e4-ee87-4245-a402-aff1ea493d7c"), null, null, "Jameson0@gmail.com", false, new Guid("a42b469c-fec8-4056-a4de-926b01b7f202") },
                    { new Guid("eec837ff-34fe-40a1-b3c3-8e73e53b5be8"), null, null, "Annamae_Kihn@yahoo.com", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("eed7ed5c-2730-4625-aa1c-a58b3d76e1b8"), null, null, "Sincere53@gmail.com", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("ef300acc-230c-4886-9be3-f0bc89cbc8e3"), null, null, "Derick18@yahoo.com", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("ef3550c1-4e48-49c6-8a40-f8533889411c"), null, null, "Brian75@yahoo.com", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("ef43322a-2d70-4721-9b0e-4fdbf192a1ba"), null, null, "Macie33@hotmail.com", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("ef5cdb6c-f528-4393-99f6-75fd220f3784"), null, null, "Rosalyn_Ruecker11@hotmail.com", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("ef6895bb-4edc-4a6f-beab-7960bb3246f7"), null, null, "Evan_Runolfsson@hotmail.com", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("efbea4ec-8415-4afe-994f-58ae0d2bf73c"), null, null, "Carli_Hauck@gmail.com", false, new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2") },
                    { new Guid("eff8a447-f46f-4890-a5bb-5d2defc9a0fe"), null, null, "Stacey.Nienow@gmail.com", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("f01c7001-8cf9-4ff3-acda-e2037c0678b5"), null, null, "Eryn_Adams@yahoo.com", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("f0967460-a5d2-4281-a121-3df54c778975"), null, null, "Wade_Larkin46@gmail.com", false, new Guid("60f7f230-ff82-425a-a6c5-cc5156098000") },
                    { new Guid("f0a920f6-f3e0-4dba-83c3-f0d5e1abe937"), null, null, "Antonio47@hotmail.com", false, new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc") },
                    { new Guid("f0ea8213-bd54-4433-940b-67c2850906d5"), null, null, "Deanna.Jacobs50@hotmail.com", false, new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259") },
                    { new Guid("f0fa7a69-ebac-44a8-832a-c984cb9328c8"), null, null, "Bernita_Thompson@yahoo.com", false, new Guid("4bc48bed-c113-458c-8a12-8f12565a542b") },
                    { new Guid("f12b6d01-a43a-4d01-b050-5ec364a788c9"), null, null, "Salvador_Wyman77@gmail.com", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("f24ea16c-c54c-4120-a945-b128ac33963c"), null, null, "Kailee_Doyle@hotmail.com", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("f25e6041-6a0b-45f2-96e8-b9d823d64922"), null, null, "Rosella.Walsh@yahoo.com", false, new Guid("c187c610-03e7-4305-96e2-96f776a463e0") },
                    { new Guid("f2ad52d4-c0cb-4da4-adeb-904f3fb92da7"), null, null, "Carlee.Moore@hotmail.com", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("f300d2d3-561f-4051-8242-dd180cebf0f3"), null, null, "Winnifred38@hotmail.com", false, new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f34e6160-f72d-4379-8edf-b2294de22834"), null, null, "Gertrude.Shanahan53@gmail.com", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("f3b2058d-088a-48e3-a987-65f68c9221a4"), null, null, "Hadley.Grady19@yahoo.com", false, new Guid("b74d612a-560a-493f-9b9a-e7d76b857600") },
                    { new Guid("f479853c-1fc1-434f-9a9e-ae706ddc4160"), null, null, "Oswaldo87@hotmail.com", false, new Guid("364df856-5357-4366-afda-cf52f25f1325") },
                    { new Guid("f487bb94-f0b3-49ce-b45f-22d38b02947a"), null, null, "Kory.Jenkins47@hotmail.com", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("f4d7b52d-416a-41c1-a928-e8e2cb0b5f64"), null, null, "Torey93@yahoo.com", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("f4dfef96-3377-4339-b78a-ef5fea709484"), null, null, "Freeman73@hotmail.com", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("f4f113c0-57d1-409f-88b5-69c5cb1fac91"), null, null, "Gianni21@hotmail.com", false, new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9") },
                    { new Guid("f58f0f7f-e49c-42bc-8ac7-3ebb6fe3b546"), null, null, "Hollie.Hauck@gmail.com", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("f5d0aa08-a11b-4bc6-afad-58ee12fc03c3"), null, null, "Estelle.Krajcik@hotmail.com", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("f6635ca3-a0fc-44ca-bfdc-7cdce1bfc3b6"), null, null, "Kaci77@hotmail.com", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("f669818c-30e0-406c-a44b-dfbd84c39853"), null, null, "Gene.Hackett@hotmail.com", false, new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca") },
                    { new Guid("f6c7387b-a578-4cc1-8c74-4a4cc695cf47"), null, null, "Georgianna39@gmail.com", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("f6e15931-3e2c-4b74-b023-08ac3f01f01c"), null, null, "Paolo_Bashirian54@hotmail.com", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("f758f79e-e78c-4e00-b466-5bc6d8636aed"), null, null, "Edgar2@hotmail.com", false, new Guid("c32606de-b224-4989-bf52-f8b3cabea595") },
                    { new Guid("f7721f88-8041-41b3-a207-9800224bd501"), null, null, "Corbin_Sporer8@hotmail.com", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("f7910389-3bed-4602-8612-f4a2bb74975c"), null, null, "Carlie18@gmail.com", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("f81ae0f0-ab95-48d2-862f-b14ef5da47d8"), null, null, "Rocio.Ratke33@gmail.com", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("f8357b7b-a439-48c7-a094-66e858e7ec8f"), null, null, "Gavin_Schmidt@hotmail.com", false, new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1") },
                    { new Guid("f8c18c87-afc3-499f-b20d-58cd7283cb90"), null, null, "Christopher72@hotmail.com", false, new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf") },
                    { new Guid("f9119e15-670f-4bdd-b035-394b939c6b99"), null, null, "Micah_Lakin82@yahoo.com", false, new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa") },
                    { new Guid("f91f133b-53c9-4c7a-8e90-551b29516743"), null, null, "Roxane88@yahoo.com", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("f9b94c4a-bf17-434c-8813-e566ca503410"), null, null, "Joaquin66@hotmail.com", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("f9fe74e5-2f08-4df5-80a2-6d72e6bd536d"), null, null, "Kaden_Gusikowski@hotmail.com", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("fa21fa7c-5531-419c-9317-9fbca5b4e63e"), null, null, "Chaya.Armstrong@hotmail.com", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("faae2b65-b52a-4f8a-83d4-da7fd7d9eb3e"), null, null, "Brannon.Brekke@gmail.com", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("fb0047da-2ee9-4df6-9bb2-20f9db642d71"), null, null, "Jackie.Considine37@hotmail.com", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("fb017971-5607-43cd-9f30-7db459ed7adb"), null, null, "Valentin.Mraz5@yahoo.com", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("fbafe990-b52e-4273-a7e6-14e6eafa20f7"), null, null, "Emiliano_Cartwright72@gmail.com", false, new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2") },
                    { new Guid("fbb10b31-3ea3-4f29-8d0d-13bd44ec0382"), null, null, "Archibald.Spinka@hotmail.com", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("fbdaebd3-0ce0-48e8-87c9-d5caac3b6a88"), null, null, "Eldred11@yahoo.com", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("fc61cb68-c6e8-425f-8619-84aa24d58418"), null, null, "Bettye_White19@gmail.com", false, new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0") },
                    { new Guid("fcbf91be-e597-4fea-8963-8c4d0d25954b"), null, null, "Marlin68@gmail.com", false, new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c") },
                    { new Guid("fd6839a8-731e-46e2-a49c-79e680b8353a"), null, null, "Talon_Zboncak24@yahoo.com", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("fd90442c-6887-48ec-8125-8844ecd7ba27"), null, null, "Amie.Carroll16@yahoo.com", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("fe0f710e-aa97-4027-b85f-f363e7b48bb7"), null, null, "Jack.Hintz89@gmail.com", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("fe1a2e27-532e-4bc8-8a7a-983adc6a5887"), null, null, "Rudolph.Turner77@hotmail.com", false, new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c") },
                    { new Guid("fe34fbda-49df-41cc-a749-33c77a041372"), null, null, "Stanley_Mann50@yahoo.com", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("fe3c41ad-f28d-4c3f-b8dd-3996edbece10"), null, null, "Trenton_Kiehn@hotmail.com", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("ff317653-8b9d-468b-b3c5-e3f0344931b0"), null, null, "Jaiden_Considine@yahoo.com", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("007ea87c-b556-4414-a441-c8c8a37f2d81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 25, 5, 1, 27, 585, DateTimeKind.Local).AddTicks(4484), new DateTime(2023, 7, 31, 5, 1, 27, 585, DateTimeKind.Local).AddTicks(4484), null, 15.65m, 7365080174744360m, true, "Super", 3, 32.51436f, "5721 Bell Prairie, Vonside, Puerto Rico", new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad"), "6241 Ledner Passage, East Justinatown, Sri Lanka", new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("011ce0d2-e14c-474e-87d7-d401f0a498f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 28, 12, 38, 5, 467, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 8, 31, 12, 38, 5, 467, DateTimeKind.Local).AddTicks(6452), null, 10.58m, true, 9748329852990844m, true, "Standart", 3, 30.522894f, "6001 Doris Court, Esperanzaburgh, Togo", new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7"), "0632 Hauck Village, Wolfview, French Polynesia", new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf"), "Sent", "CardboardBox" },
                    { new Guid("049a7474-2601-4474-8acb-f2f7f4c0377d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 5, 23, 59, 14, 404, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 7, 12, 23, 59, 14, 404, DateTimeKind.Local).AddTicks(8783), null, 51.66m, true, 2101890201392614m, true, "Super", 1, 6.77234f, "47200 Reilly Route, Pfannerstillmouth, Cuba", new Guid("e31a76f4-5bec-480b-974e-4e00950656e8"), "409 Friesen Vista, West Daphneyshire, Czech Republic", new Guid("354e9bbf-de43-4345-a871-f0af96ec9410"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0ad41f9c-c6a1-4875-99a6-29ec497e3873"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 2, 7, 9, 12, 314, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 9, 12, 7, 9, 12, 314, DateTimeKind.Local).AddTicks(6593), null, 46.07m, true, 5106950524805512m, "Courier", 5, 49.43355f, "4706 Block Course, Port Adolfburgh, American Samoa", new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16"), "33775 Douglas Glen, Alexannehaven, New Caledonia", new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0ea0a6c4-f8a5-4384-ac8c-a2f34344156c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 9, 3, 16, 58, 165, DateTimeKind.Local).AddTicks(7817), new DateTime(2023, 6, 16, 3, 16, 58, 165, DateTimeKind.Local).AddTicks(7817), null, 14.66m, 6062191036797103m, "Courier", 4, 22.64308f, "18668 Nathanael Corners, Kassulkeview, Antarctica (the territory South of 60 deg S)", new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7"), "7152 Satterfield Causeway, New Natalie, Armenia", new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0eaf94ea-b8d3-42d4-a01e-1ed712db0981"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 13, 9, 8, 394, DateTimeKind.Local).AddTicks(758), new DateTime(2023, 11, 24, 13, 9, 8, 394, DateTimeKind.Local).AddTicks(758), null, 47.36m, true, 4773395275467338m, "Super", 2, 33.396725f, "214 Green Turnpike, Josiannefort, Sierra Leone", new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305"), "45547 Roberts Garden, New Ottilie, Aruba", new Guid("cfa37291-0772-47b2-bbdc-842ca4428900"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("0ec6aa8b-f888-497e-9a88-2c2e14eb89da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 18, 19, 30, 53, 554, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 8, 19, 19, 30, 53, 554, DateTimeKind.Local).AddTicks(4783), null, 65.09m, 6760200826628158m, true, "Super", 3, 26.41553f, "1096 Greenholt Spur, Margaretteshire, Belarus", new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca"), "36702 Myrtle Drives, Beerborough, Azerbaijan", new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b"), "Registered", "CardboardBox" },
                    { new Guid("109e2424-e913-4479-a5bd-8d8377f57c90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 2, 17, 5, 8, 21, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 3, 7, 17, 5, 8, 21, DateTimeKind.Local).AddTicks(5642), null, 18.55m, 6499449818443063m, true, "ParcelMachine", 1, 39.861084f, "415 Wilhelmine Village, Norrisburgh, Nigeria", new Guid("a40e2013-0615-4cf6-82e5-5e136f732285"), "0497 Kunde Plains, New Anya, Montenegro", new Guid("246ee090-764e-420d-803e-5d97e7d873a0"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1296f886-92b0-4bf4-8296-630c7c63231d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 2, 7, 1, 20, 676, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 9, 7, 7, 1, 20, 676, DateTimeKind.Local).AddTicks(5198), null, 59.95m, 7248987626281306m, "Courier", 3, 6.236507f, "0785 Gilda Islands, South Amiya, Ecuador", new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a"), "77810 Hubert Burg, North Johathantown, British Indian Ocean Territory (Chagos Archipelago)", new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("14d01610-8f13-4d2d-b8a6-7a6987738695"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 22, 5, 12, 22, 640, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 4, 30, 5, 12, 22, 640, DateTimeKind.Local).AddTicks(6837), null, 26.73m, true, 9186771376616744m, "Special", 1, 36.404926f, "2298 Quitzon Brooks, North Leon, Micronesia", new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8"), "09267 Kihn Path, Elfriedamouth, Cameroon", new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1af72883-e147-48b7-8526-d337e7a06981"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 19, 4, 29, 9, 846, DateTimeKind.Local).AddTicks(1511), new DateTime(2023, 12, 28, 4, 29, 9, 846, DateTimeKind.Local).AddTicks(1511), null, 16.30m, true, 1764738403726188m, true, "Courier", 3, 37.67956f, "7611 McCullough Square, Mosciskiborough, South Georgia and the South Sandwich Islands", new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed"), "0591 Harley Center, Izaiahstad, Mayotte", new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1e1ffd70-4c1b-404d-8d70-442e9efdc854"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 16, 1, 40, 49, 41, DateTimeKind.Local).AddTicks(773), new DateTime(2023, 7, 19, 1, 40, 49, 41, DateTimeKind.Local).AddTicks(773), null, 19.95m, 3534198684297480m, true, "ParcelMachine", 1, 30.271671f, "486 Albert Crossing, Bradfordfurt, Cote d'Ivoire", new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92"), "294 Bailey Parkways, Baumbachhaven, Kenya", new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1e97beb9-1e89-462b-ba43-f7f3cc432de6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 30, 3, 14, 9, 716, DateTimeKind.Local).AddTicks(1847), new DateTime(2023, 7, 5, 3, 14, 9, 716, DateTimeKind.Local).AddTicks(1847), null, 63.20m, true, 4777960037713127m, "Courier", 2, 19.791624f, "5912 O'Reilly Plaza, Monahanberg, Philippines", new Guid("e8293c7e-c598-445f-a509-d9123149ec52"), "25823 Nikolaus Rapids, Elenoraville, American Samoa", new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("253c4ef6-2ae0-4beb-be50-5c818f3920d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 3, 18, 16, 1, 557, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 4, 13, 18, 16, 1, 557, DateTimeKind.Local).AddTicks(2350), null, 41.76m, true, 2525751061213426m, true, "Special", 2, 27.595867f, "84478 Lelah Trail, Adityamouth, Georgia", new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40"), "50444 Hirthe Springs, Hudsonchester, United States of America", new Guid("d8e6873e-ae0e-4181-866e-982565b77df9"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("25796eb8-ceaf-4182-b69a-05069d7bf7ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 18, 2, 23, 33, 297, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 7, 21, 2, 23, 33, 297, DateTimeKind.Local).AddTicks(6257), null, 69.49m, 8934491799786334m, true, "Standart", 4, 32.8707f, "2377 Ortiz Road, West Aracelistad, Grenada", new Guid("c41a987e-114e-4968-aa63-744e27096322"), "74250 Osbaldo Course, Corwinmouth, Canada", new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2ce3b4df-c491-43a8-bf2f-63aeb0f03221"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 12, 18, 49, 20, 110, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 10, 13, 18, 49, 20, 110, DateTimeKind.Local).AddTicks(6003), null, 30.20m, 4192068872424416m, "ParcelMachine", 1, 11.768191f, "43483 Cydney Mission, New Marcellaview, Portugal", new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179"), "170 Peggie Circle, South Denaberg, Nauru", new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2d446d37-7615-454f-9b01-14adb050d95b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 7, 21, 49, 45, 960, DateTimeKind.Local).AddTicks(5133), new DateTime(2024, 1, 17, 21, 49, 45, 960, DateTimeKind.Local).AddTicks(5133), null, 33.98m, 5493322956844518m, true, "ParcelMachine", 2, 19.634212f, "76428 Kihn Knolls, Walkerburgh, Saint Lucia", new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15"), "44534 Kyla Port, Bayerstad, Australia", new Guid("3288753c-07c2-4e2b-85e9-1279757a9971"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("2edeb36b-fcfc-47ee-b5d6-001265a004ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 13, 20, 31, 29, 220, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 9, 20, 20, 31, 29, 220, DateTimeKind.Local).AddTicks(2826), null, 93.68m, true, 9290821088462812m, true, "Super", 1, 44.41451f, "0491 Kozey Drives, Brakusland, Palau", new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4"), "394 Sally Junction, Lake Amirburgh, Malawi", new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0"), "Return", "PlasticBag" },
                    { new Guid("30cd18cb-e947-41ce-9cf1-2523de0003a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 29, 22, 34, 12, 548, DateTimeKind.Local).AddTicks(5225), new DateTime(2024, 3, 7, 22, 34, 12, 548, DateTimeKind.Local).AddTicks(5225), null, 76.95m, true, 8275565849619036m, true, "Special", 2, 47.317528f, "213 Travon Parkway, Sadiemouth, Palau", new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1"), "8972 Mathias Port, New Henriberg, Tonga", new Guid("82d8841b-b98c-463c-96d0-9378cf908740"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("31945834-4f3e-438c-ae2a-95086f86b1e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 7, 8, 14, 4, 510, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 10, 13, 8, 14, 4, 510, DateTimeKind.Local).AddTicks(8959), null, 96.82m, true, 3034758813377018m, "ParcelMachine", 4, 33.804764f, "08094 Lucious Light, North Malloryshire, Rwanda", new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe"), "356 Bechtelar Radial, Boyleshire, Timor-Leste", new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("36431098-343b-48ea-9d94-d660ab120a32"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 19, 4, 43, 43, 507, DateTimeKind.Local).AddTicks(5367), new DateTime(2024, 4, 23, 4, 43, 43, 507, DateTimeKind.Local).AddTicks(5367), null, 67.36m, 6537374868014181m, true, "Super", 3, 40.20657f, "882 Heathcote Track, Smithamshire, Bermuda", new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "7688 Ernest Fall, Nicholefort, Tuvalu", new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("37057b48-d8fa-4d4e-a5e3-6ef544ed67e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 12, 16, 44, 41, 845, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 1, 22, 16, 44, 41, 845, DateTimeKind.Local).AddTicks(8647), null, 45.64m, 8679650516251007m, "Courier", 1, 32.785435f, "406 Heidenreich Forge, Brakusburgh, Holy See (Vatican City State)", new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781"), "92588 Christian Station, North Colbyberg, Malaysia", new Guid("3288753c-07c2-4e2b-85e9-1279757a9971"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("379fcc57-d2e6-469e-8918-392599f5b5cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 19, 16, 58, 32, 355, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 1, 27, 16, 58, 32, 355, DateTimeKind.Local).AddTicks(4690), null, 10.17m, true, 1121672349126778m, true, "Courier", 1, 2.0144284f, "133 Webster Islands, Daughertymouth, Heard Island and McDonald Islands", new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443"), "1260 Miller Motorway, Williamsonberg, Virgin Islands, British", new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab"), "Sent", "PlasticBag" },
                    { new Guid("3886934a-3e50-4854-9c6f-3d161cd25030"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 17, 7, 0, 7, 831, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 3, 26, 7, 0, 7, 831, DateTimeKind.Local).AddTicks(3718), null, 98.02m, true, 4689780237872737m, true, "Standart", 2, 27.402073f, "842 Collier Trafficway, Port Ruby, Democratic People's Republic of Korea", new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb"), "450 Yessenia Forks, South Olga, Angola", new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("395f9f16-e3f9-4ebd-a31a-3a69105a4c36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 13, 2, 59, 33, 822, DateTimeKind.Local).AddTicks(7642), new DateTime(2024, 4, 20, 2, 59, 33, 822, DateTimeKind.Local).AddTicks(7642), null, 16.12m, 6290893795664025m, "Courier", 2, 44.166836f, "29182 McCullough Walks, West Annaliseborough, Democratic People's Republic of Korea", new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179"), "898 Lueilwitz Pine, West Pearliebury, Cyprus", new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("439d4124-3ba0-4fe2-8d7b-cdac20dfeafa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 7, 11, 26, 41, 11, DateTimeKind.Local).AddTicks(8578), new DateTime(2024, 4, 8, 11, 26, 41, 11, DateTimeKind.Local).AddTicks(8578), null, 86.54m, true, 2230678356625436m, true, "Courier", 5, 19.418518f, "38521 Louvenia Groves, Port Arjun, Argentina", new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca"), "489 Ronaldo Greens, Lake Lillystad, El Salvador", new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("46b83214-1715-4a0b-9f10-064912f87dc4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 1, 20, 24, 38, 266, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 2, 4, 20, 24, 38, 266, DateTimeKind.Local).AddTicks(6014), null, 80.52m, 7976480641844530m, "Standart", 4, 20.779932f, "8201 Lesley Port, Prohaskamouth, Montenegro", new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807"), "08596 Ullrich Forks, Lake Gerhard, Costa Rica", new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("46e3c9bc-1927-4227-a6b3-46b000cb85f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 7, 12, 40, 41, 790, DateTimeKind.Local).AddTicks(6069), new DateTime(2024, 4, 13, 12, 40, 41, 790, DateTimeKind.Local).AddTicks(6069), null, 19.98m, true, 5437843875463552m, "Super", 1, 22.618675f, "9993 Corwin Fork, Linniestad, Grenada", new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd"), "47769 Jaycee Way, Port Dashawn, Morocco", new Guid("b74d612a-560a-493f-9b9a-e7d76b857600"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("47d1474e-f907-4100-a8e3-f7e901086895"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 17, 18, 22, 35, 491, DateTimeKind.Local).AddTicks(5526), new DateTime(2023, 8, 19, 18, 22, 35, 491, DateTimeKind.Local).AddTicks(5526), null, 98.14m, true, 8174073224324283m, true, "Courier", 4, 46.625175f, "873 Virgil Flats, Jacehaven, Guadeloupe", new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5"), "53746 Abe Groves, Walterburgh, Guinea-Bissau", new Guid("246ee090-764e-420d-803e-5d97e7d873a0"), "Sent", "PlasticBag" },
                    { new Guid("48700a6b-e37c-4d74-8bff-c23fb6e1c5b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 9, 20, 11, 19, 115, DateTimeKind.Local).AddTicks(619), new DateTime(2023, 7, 19, 20, 11, 19, 115, DateTimeKind.Local).AddTicks(619), null, 60.38m, true, 5623413500153403m, true, "ParcelMachine", 2, 5.758308f, "579 Maggio Knoll, New Zander, Ghana", new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062"), "2070 Kuvalis Ramp, West Xzavier, Zimbabwe", new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1"), "Return", "PlasticBag" },
                    { new Guid("4aa38fa8-ab53-4fc1-b178-55dbbf8997fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 0, 38, 37, 352, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 10, 27, 0, 38, 37, 352, DateTimeKind.Local).AddTicks(3982), null, 92.66m, true, 9404825447956590m, true, "ParcelMachine", 3, 2.2807267f, "101 Jovan Circles, Port Cathrineborough, Serbia", new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "18188 Heaney Forks, Eugenefort, Lao People's Democratic Republic", new Guid("b552dea4-6df2-477a-870b-1317247a51c0"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("4b143f48-800d-4887-abaf-25b1eb4274c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 20, 6, 27, 33, 234, DateTimeKind.Local).AddTicks(7815), new DateTime(2024, 2, 28, 6, 27, 33, 234, DateTimeKind.Local).AddTicks(7815), null, 79.12m, 1903821847989236m, true, "Super", 1, 27.194324f, "738 Monahan Place, New Friedrichmouth, Turkmenistan", new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), "8414 Marta Divide, Hermanburgh, Kyrgyz Republic", new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5"), "Sent", "PlasticBag" },
                    { new Guid("4d92fbf4-13a3-4b66-936a-607df38a0432"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 9, 10, 39, 58, 958, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 5, 12, 10, 39, 58, 958, DateTimeKind.Local).AddTicks(3934), null, 39.56m, 3917541293957426m, true, "Special", 1, 47.484547f, "933 Otto Mountains, Lake Anabelle, Slovenia", new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8"), "6616 Daron Expressway, Mertzview, French Polynesia", new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808"), "Sent", "CardboardBox" },
                    { new Guid("4e17c2a6-510c-4035-9983-5a1f9307598d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 10, 6, 15, 31, 298, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 4, 17, 6, 15, 31, 298, DateTimeKind.Local).AddTicks(3556), null, 76.12m, 2365210619636932m, true, "Special", 4, 10.013804f, "115 Pearl Trafficway, West Cristal, Paraguay", new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588"), "639 Pacocha Highway, West Rachaelfort, Mongolia", new Guid("b552dea4-6df2-477a-870b-1317247a51c0"), "OnTheWay", "CardboardBox" },
                    { new Guid("4f18f31c-d53a-4554-89b5-ea6f5e06b16d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 29, 22, 25, 30, 661, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 5, 9, 22, 25, 30, 661, DateTimeKind.Local).AddTicks(9089), null, 42.49m, 8143066419781337m, true, "Courier", 3, 48.532253f, "2705 Penelope Springs, East Mable, Macedonia", new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2"), "86722 Gutmann Drives, Candelariomouth, Saint Kitts and Nevis", new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("507c0017-e12a-4451-867d-b046d7f1bfb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 13, 19, 38, 27, 148, DateTimeKind.Local).AddTicks(6789), new DateTime(2024, 5, 17, 19, 38, 27, 148, DateTimeKind.Local).AddTicks(6789), null, 81.48m, 7003307864793145m, "Standart", 1, 4.4469666f, "082 Elliott Courts, Isaacchester, Cyprus", new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7"), "0458 Rogers Centers, South Sharonshire, Afghanistan", new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("517a0772-69a7-415a-9681-caaeb87980f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 27, 9, 27, 23, 95, DateTimeKind.Local).AddTicks(2028), new DateTime(2023, 8, 1, 9, 27, 23, 95, DateTimeKind.Local).AddTicks(2028), null, 66.35m, 9350357332336356m, true, "ParcelMachine", 4, 9.275387f, "381 Johns River, Port Adalinechester, Libyan Arab Jamahiriya", new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518"), "85293 Linda Crossroad, Lake Herminiafort, Albania", new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5423a06e-51fc-41be-a309-ed25edc9c769"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 13, 3, 35, 18, 3, DateTimeKind.Local).AddTicks(593), new DateTime(2023, 8, 23, 3, 35, 18, 3, DateTimeKind.Local).AddTicks(593), null, 97.73m, true, 1060175803113284m, "Special", 3, 42.2032f, "201 Gerhold Knoll, Shanahanfurt, Germany", new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf"), "3250 Sandrine Vista, North Madalynfort, Ireland", new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("584fdb96-fdca-46ee-a982-1edddf9469f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 24, 0, 39, 11, 394, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 2, 2, 0, 39, 11, 394, DateTimeKind.Local).AddTicks(3569), null, 49.72m, true, 4041451481237818m, true, "Special", 3, 7.8030505f, "59808 Douglas Ridges, North Vincetown, Greece", new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19"), "274 Marquardt Lodge, Millsview, Syrian Arab Republic", new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5b8f88b7-2d5a-4e1e-95d1-18b4e6e34a32"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 12, 15, 35, 17, 148, DateTimeKind.Local).AddTicks(1148), new DateTime(2023, 10, 19, 15, 35, 17, 148, DateTimeKind.Local).AddTicks(1148), null, 97.71m, 5152473883873554m, "ParcelMachine", 5, 16.401533f, "0932 Rogahn Common, O'Connellstad, Heard Island and McDonald Islands", new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0"), "358 Curt Islands, Lake Thea, Sao Tome and Principe", new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5cf95c64-66e0-4cd9-bd2d-a929f05c8ec2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 2, 21, 55, 70, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 10, 21, 2, 21, 55, 70, DateTimeKind.Local).AddTicks(2078), null, 15.16m, 3515105319491782m, true, "Special", 2, 40.764683f, "27850 Gaylord Island, Damonland, Mauritania", new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94"), "313 Mante Hollow, Bernierside, Libyan Arab Jamahiriya", new Guid("ee988837-dda9-4fd3-9925-0375db807eaa"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5d31ad9d-4fa6-4a6c-a191-838c36df13c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 18, 19, 16, 34, 151, DateTimeKind.Local).AddTicks(2683), new DateTime(2024, 4, 21, 19, 16, 34, 151, DateTimeKind.Local).AddTicks(2683), null, 83.30m, true, 9667272783083660m, true, "Special", 4, 21.465471f, "6855 Jaime Circle, West Zechariah, Liberia", new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae"), "18496 Daniel Road, Luigiborough, Bouvet Island (Bouvetoya)", new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5dc8b0d1-bb43-4f25-9eeb-16a60c806495"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 21, 4, 31, 33, 650, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 4, 29, 4, 31, 33, 650, DateTimeKind.Local).AddTicks(4245), null, 93.47m, 9728740993728256m, "Special", 3, 48.00534f, "38761 Erdman Street, Hillsstad, Oman", new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0"), "00251 Breitenberg Gateway, New Ruthie, Philippines", new Guid("963654b6-a05e-4be7-b120-45295941d954"), "Return", "CardboardBox" },
                    { new Guid("5ec99fef-74d7-4b50-b8ff-99d760990e23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 8, 15, 29, 40, 973, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 3, 12, 15, 29, 40, 973, DateTimeKind.Local).AddTicks(1020), null, 34.43m, 1522662231621288m, "Super", 3, 29.518904f, "0337 Gay Turnpike, West Stuartborough, Moldova", new Guid("b74d612a-560a-493f-9b9a-e7d76b857600"), "022 Blick Bridge, Weimannburgh, Grenada", new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("60808fdf-b2cf-4704-bb66-c1e56f75b77c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 9, 1, 59, 43, 697, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 11, 10, 1, 59, 43, 697, DateTimeKind.Local).AddTicks(2897), null, 30.97m, true, 3852036979984490m, true, "Standart", 4, 28.04573f, "28175 Cremin Walk, Brekkeborough, Dominica", new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c"), "627 Zemlak Underpass, Katelynnmouth, Czech Republic", new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("609eadcf-8ad0-4ecc-b936-073b1766f79a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 8, 16, 53, 15, 389, DateTimeKind.Local).AddTicks(1666), new DateTime(2024, 1, 17, 16, 53, 15, 389, DateTimeKind.Local).AddTicks(1666), null, 18.10m, 7477711168297998m, true, "Standart", 2, 9.936532f, "11824 Lang Center, Lednerview, Lesotho", new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267"), "7672 Leannon Mall, South Raleigh, Timor-Leste", new Guid("60f7f230-ff82-425a-a6c5-cc5156098000"), "OnTheWay", "CardboardBox" },
                    { new Guid("684a60db-806d-4432-8f65-02304d995f8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 14, 13, 50, 27, 875, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 12, 18, 13, 50, 27, 875, DateTimeKind.Local).AddTicks(9910), null, 33.24m, 7067512161527117m, true, "ParcelMachine", 5, 35.67793f, "8635 Justine River, Judsonland, Namibia", new Guid("67421d1e-5702-485e-b8e7-42fccca07695"), "3948 Lois Island, East Gertrude, Central African Republic", new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("68c0124f-b308-4951-986d-ddbb9bacdd38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 6, 15, 55, 12, 481, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 9, 7, 15, 55, 12, 481, DateTimeKind.Local).AddTicks(284), null, 32.94m, true, 6502364879806049m, "Super", 4, 33.203392f, "057 Javier Dale, Hettingermouth, Croatia", new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481"), "17514 Kristina Valleys, Kathrynebury, Saint Helena", new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("69b7b30f-b68a-4479-98b1-ece5ce11d9e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 23, 19, 6, 17, 517, DateTimeKind.Local).AddTicks(9445), new DateTime(2023, 7, 25, 19, 6, 17, 517, DateTimeKind.Local).AddTicks(9445), null, 34.24m, 2733004293284325m, "Standart", 1, 46.183907f, "74691 Ned Glens, East Madisenbury, Bangladesh", new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40"), "007 Amelie Course, West Barneyshire, Holy See (Vatican City State)", new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6c689e10-3422-4f20-9572-1b62208cac71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 25, 18, 31, 10, 346, DateTimeKind.Local).AddTicks(2397), new DateTime(2023, 10, 29, 18, 31, 10, 346, DateTimeKind.Local).AddTicks(2397), null, 61.35m, true, 9894165958061288m, true, "ParcelMachine", 1, 39.97672f, "899 Walsh Unions, Wilmatown, Kuwait", new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44"), "320 Arno Flat, Purdyport, Haiti", new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("6d24008e-519e-47af-9193-506bff901bd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 4, 12, 33, 3, 912, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 6, 6, 12, 33, 3, 912, DateTimeKind.Local).AddTicks(8837), null, 27.91m, 1455091340402232m, "Standart", 3, 13.598832f, "1217 Maxie Pass, Germanburgh, Palestinian Territory", new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae"), "736 Brown Tunnel, Dellafort, France", new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2"), "Sent", "PlasticBag" },
                    { new Guid("715e97ad-f6b8-45d1-ac4c-9fbd0361ec79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 31, 9, 40, 57, 287, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 2, 8, 9, 40, 57, 287, DateTimeKind.Local).AddTicks(2840), null, 24.81m, 4721701563282843m, "Standart", 2, 12.865352f, "252 Roosevelt Forges, Gutkowskiport, China", new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b"), "9082 Rempel Shoals, Port Davinport, Guam", new Guid("e8293c7e-c598-445f-a509-d9123149ec52"), "Delivered", "CardboardBox" },
                    { new Guid("789a1120-ffdc-4e11-b3c7-391a92d383f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 4, 2, 45, 59, 843, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 3, 6, 2, 45, 59, 843, DateTimeKind.Local).AddTicks(130), null, 81.04m, 3080122872662645m, "Standart", 1, 43.684742f, "0585 Wilhelm Summit, Thielside, New Caledonia", new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105"), "67812 Gail Plains, Harrismouth, Bosnia and Herzegovina", new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("79231b66-ce58-4658-a9d2-3c021b995fc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 28, 1, 34, 16, 849, DateTimeKind.Local).AddTicks(3673), new DateTime(2023, 7, 1, 1, 34, 16, 849, DateTimeKind.Local).AddTicks(3673), null, 94.26m, true, 1952555717671356m, true, "Super", 3, 13.251892f, "681 Funk Mews, Valentineton, Bermuda", new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe"), "11512 Heller Coves, Port Nat, Puerto Rico", new Guid("4285821d-9d8f-4943-b663-27adc015a9c4"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("7dc63f17-f3b3-4851-bf28-8c5ab62b120f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 3, 23, 54, 9, 94, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 7, 5, 23, 54, 9, 94, DateTimeKind.Local).AddTicks(4430), null, 53.93m, 7023091517032862m, "ParcelMachine", 3, 27.16874f, "8056 Toni Pine, Wisozkbury, South Africa", new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781"), "94894 Kellen Glens, Lincolnhaven, Iceland", new Guid("364df856-5357-4366-afda-cf52f25f1325"), "Registered", "CardboardBox" },
                    { new Guid("837fb9d2-8936-4ccd-968a-b49e1a30bcc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 14, 1, 6, 10, 45, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 8, 15, 1, 6, 10, 45, DateTimeKind.Local).AddTicks(9045), null, 12.52m, 3078449584999446m, "ParcelMachine", 4, 37.0041f, "85782 Lily Coves, Lorineberg, Denmark", new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35"), "56493 Johns Corners, Ilaborough, Slovenia", new Guid("05fb67eb-3b60-4c93-bf80-36153be08871"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("83d7ac80-bd51-4a9a-af0a-997f9e5b547e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 24, 11, 35, 47, 199, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 4, 3, 11, 35, 47, 199, DateTimeKind.Local).AddTicks(7465), null, 57.89m, true, 6579042988111750m, true, "Special", 5, 24.79844f, "387 Moore Lodge, Port Sedricktown, Costa Rica", new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2"), "11842 Ferry Plains, Haileemouth, Paraguay", new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8cec813b-09a8-46f0-871c-44084a156af5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 14, 9, 9, 41, 140, DateTimeKind.Local).AddTicks(9798), new DateTime(2024, 1, 24, 9, 9, 41, 140, DateTimeKind.Local).AddTicks(9798), null, 67.59m, true, 3372816665363857m, "Special", 3, 49.68208f, "5029 Russell Creek, Lake Faustinohaven, Kiribati", new Guid("558db05b-0b8d-442b-8166-524709ea133f"), "81646 Alexa Forks, West Lauriane, Mozambique", new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("8f07fb31-f60c-4ca6-a053-985b7dbfe437"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 25, 13, 39, 56, 728, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 1, 28, 13, 39, 56, 728, DateTimeKind.Local).AddTicks(7212), null, 48.80m, 5384971108738194m, true, "Super", 3, 33.09947f, "70100 Kulas Mountains, Olsonmouth, Antarctica (the territory South of 60 deg S)", new Guid("e8293c7e-c598-445f-a509-d9123149ec52"), "979 Dicki Fork, Robelshire, Switzerland", new Guid("da175a26-80f5-4704-9c96-da3480a7797b"), "Return", "CardboardBox" },
                    { new Guid("8fe4f449-2568-4a68-a6b2-4146f15ed7e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 6, 5, 58, 22, 951, DateTimeKind.Local).AddTicks(4887), new DateTime(2024, 2, 14, 5, 58, 22, 951, DateTimeKind.Local).AddTicks(4887), null, 75.20m, 9831882954895872m, true, "Courier", 4, 41.71316f, "262 Hettie Drive, New Hipolitoburgh, Spain", new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d"), "58551 Daniela Union, Lake Brandt, Tuvalu", new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276"), "OnTheWay", "PlasticBag" },
                    { new Guid("908b393d-9bee-403a-b282-0592fd47c243"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 8, 17, 45, 40, 780, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 10, 9, 17, 45, 40, 780, DateTimeKind.Local).AddTicks(2238), null, 22.85m, 1968807900888806m, true, "Standart", 3, 10.768882f, "809 Gerda Center, Weberport, Malta", new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481"), "843 Henry Prairie, Ziememouth, Ukraine", new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("91614d73-c32c-483d-beba-78d06380215b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 14, 6, 50, 26, 264, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 7, 18, 6, 50, 26, 264, DateTimeKind.Local).AddTicks(2771), null, 22.17m, true, 1952379588428058m, true, "Super", 4, 19.078182f, "4204 Gislason Knolls, Port Daxtown, Bahrain", new Guid("85178881-d883-4586-bf89-10a49abb8b16"), "6344 Rutherford Mews, Port Henry, Maldives", new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7"), "Registered", "CardboardBox" },
                    { new Guid("938f7131-a41c-4208-80b4-39d345401f42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 12, 15, 11, 40, 251, DateTimeKind.Local).AddTicks(6645), new DateTime(2024, 4, 19, 15, 11, 40, 251, DateTimeKind.Local).AddTicks(6645), null, 97.30m, true, 9476925406897380m, true, "Standart", 3, 38.389202f, "9097 Renner Corner, Juanitaland, Republic of Korea", new Guid("e8293c7e-c598-445f-a509-d9123149ec52"), "611 Claud Forks, North Estel, Tuvalu", new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd"), "OnTheWay", "PlasticBag" },
                    { new Guid("99e952cd-3e49-494b-9492-a7d871a88631"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 9, 14, 48, 53, 724, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 10, 18, 14, 48, 53, 724, DateTimeKind.Local).AddTicks(7909), null, 91.49m, true, 3702549433522683m, true, "Super", 5, 5.066191f, "09594 Hazle Crossroad, Predovicchester, Guinea", new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8"), "696 Jerde Tunnel, Lake Thelma, Mongolia", new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9bc6de9e-8901-438c-b9ac-f6c0fa3fd4af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 6, 15, 48, 35, 546, DateTimeKind.Local).AddTicks(7465), new DateTime(2023, 12, 10, 15, 48, 35, 546, DateTimeKind.Local).AddTicks(7465), null, 64.95m, true, 3522327602202828m, "Special", 3, 15.621978f, "479 Hauck Fort, New Kathlyn, Italy", new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20"), "47596 Lionel Pines, Samstad, Bouvet Island (Bouvetoya)", new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a4166350-bfbf-46c8-8fee-a4e5ceea01c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 24, 19, 44, 14, 569, DateTimeKind.Local).AddTicks(1811), new DateTime(2023, 10, 4, 19, 44, 14, 569, DateTimeKind.Local).AddTicks(1811), null, 21.14m, 3528305881634261m, "Special", 2, 48.27134f, "2770 Sporer Forks, North Rickyberg, Macedonia", new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2"), "5575 Muller Common, Conroyshire, Libyan Arab Jamahiriya", new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a5ac7e7d-257a-44a5-abbd-e2a0105f989d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 10, 1, 38, 19, 649, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 9, 12, 1, 38, 19, 649, DateTimeKind.Local).AddTicks(7865), null, 27.11m, 2216066664355150m, true, "ParcelMachine", 2, 35.43246f, "056 Dillon Falls, West Alexborough, Solomon Islands", new Guid("ec149744-9128-4f41-875a-1c96bf1c851c"), "98237 Berneice Plains, Bartolettibury, Togo", new Guid("20d4c413-4a9e-4942-a590-4b6a67675891"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a788c652-c8d1-48cd-a735-9f07a854fe6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 20, 15, 25, 15, 106, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 9, 22, 15, 25, 15, 106, DateTimeKind.Local).AddTicks(8472), null, 11.39m, true, 8543999386044207m, true, "Courier", 2, 36.481728f, "79572 Yvette Fort, North Nigelfort, Georgia", new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c"), "74292 Bergstrom Inlet, Amirland, Central African Republic", new Guid("a40e2013-0615-4cf6-82e5-5e136f732285"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ad355e2e-c56b-4000-9686-393686ee9319"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 19, 1, 39, 40, 895, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 9, 24, 1, 39, 40, 895, DateTimeKind.Local).AddTicks(8650), null, 35.85m, 6417623011803175m, "Special", 1, 16.76916f, "090 Astrid Plains, East Carolanneborough, Philippines", new Guid("a836bc35-12f7-485d-861b-ad1645878c24"), "24919 Gerlach Neck, West Elisabethberg, San Marino", new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("adb8c2ce-75e7-43fb-b6d1-cc13ce6726fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 5, 19, 34, 27, 907, DateTimeKind.Local).AddTicks(5484), new DateTime(2024, 3, 7, 19, 34, 27, 907, DateTimeKind.Local).AddTicks(5484), null, 66.98m, true, 7231140150755118m, "Courier", 1, 37.41138f, "37002 Reilly Dam, South Ibrahimport, Bangladesh", new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db"), "09275 Brando Causeway, Nobleville, Cape Verde", new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("adfc5b6d-6c93-4d91-8dfa-59fad2de8a53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 17, 4, 36, 287, DateTimeKind.Local).AddTicks(3646), new DateTime(2023, 10, 15, 17, 4, 36, 287, DateTimeKind.Local).AddTicks(3646), null, 89.52m, 1150218037030494m, "Super", 1, 3.6569924f, "43364 Schinner Court, Arnulfohaven, Azerbaijan", new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e"), "1942 Breanna Parks, Port Johnny, Jersey", new Guid("1ca2e699-11df-445a-8084-51598bee7020"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ba1852a5-e232-47e2-b3c4-da546a2732d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 26, 12, 47, 48, 250, DateTimeKind.Local).AddTicks(680), new DateTime(2023, 11, 28, 12, 47, 48, 250, DateTimeKind.Local).AddTicks(680), null, 62.63m, true, 7767672740190788m, "Standart", 3, 8.104996f, "18731 Boyer Ports, Lake Dylanchester, Northern Mariana Islands", new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370"), "7555 Huel River, Faustotown, Saint Kitts and Nevis", new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("bb38057e-1dca-4a59-85f2-fbcb7f5a2bc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 12, 36, 12, 602, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 11, 12, 12, 36, 12, 602, DateTimeKind.Local).AddTicks(7997), null, 99.58m, true, 2443678276006260m, true, "Special", 1, 27.965332f, "98239 Elisa Station, South Waynehaven, Syrian Arab Republic", new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed"), "38080 Kassulke Shoals, Roscoestad, Poland", new Guid("20d4c413-4a9e-4942-a590-4b6a67675891"), "Delivered", "PlasticBag" },
                    { new Guid("bb4039f7-1537-4314-a9fe-0991a57ba566"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 25, 21, 8, 30, 81, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 8, 3, 21, 8, 30, 81, DateTimeKind.Local).AddTicks(8753), null, 33.57m, true, 5174812990491664m, true, "ParcelMachine", 4, 14.250793f, "83131 Myrtice Valleys, East Enid, Tuvalu", new Guid("b74d612a-560a-493f-9b9a-e7d76b857600"), "59122 Goodwin Plains, Justynland, Timor-Leste", new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb"), "Return", "CardboardBox" },
                    { new Guid("bdc813ef-f574-4808-a995-ebf68760303e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 23, 0, 10, 9, 247, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 12, 25, 0, 10, 9, 247, DateTimeKind.Local).AddTicks(876), null, 88.14m, true, 3160665155834154m, true, "Standart", 5, 29.276033f, "66763 Ramona Mountains, Kellieshire, Dominica", new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c"), "59123 Beatrice River, Penelopestad, Suriname", new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("bed0a827-e500-4536-8454-7822db27442e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 16, 2, 33, 27, 77, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 7, 26, 2, 33, 27, 77, DateTimeKind.Local).AddTicks(5857), null, 27.40m, 5143065270290745m, true, "Courier", 2, 40.933594f, "441 Cynthia Plains, Mayertland, Cote d'Ivoire", new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), "220 Runte Estates, New Kiarra, Paraguay", new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf"), "Sent", "CardboardBox" },
                    { new Guid("c9e99e11-7963-43db-8f30-c0b55eb80a22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 10, 10, 8, 2, 396, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 12, 20, 10, 8, 2, 396, DateTimeKind.Local).AddTicks(6651), null, 86.24m, 3270038239882582m, true, "Super", 4, 24.566874f, "556 Kerluke Parks, West Israeltown, Isle of Man", new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259"), "395 Burnice Rapids, Uptonbury, Holy See (Vatican City State)", new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8"), "Return", "CardboardBox" },
                    { new Guid("caee7def-dfda-4ce6-a8fa-6c2e96f56c63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 29, 20, 55, 16, 349, DateTimeKind.Local).AddTicks(4548), new DateTime(2023, 8, 30, 20, 55, 16, 349, DateTimeKind.Local).AddTicks(4548), null, 93.86m, 1648268615176370m, true, "Super", 4, 29.83439f, "40126 Hoeger Extension, Hermannburgh, Cayman Islands", new Guid("680c6306-048b-493d-8369-356efb0cafae"), "05552 Derek Club, Lake Eladio, Sweden", new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cb493731-26f9-43ce-ad0e-bd3f835a64c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 23, 18, 34, 39, 32, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 10, 29, 18, 34, 39, 32, DateTimeKind.Local).AddTicks(8068), null, 61.35m, true, 4475665730048152m, "Special", 1, 28.552162f, "22411 Estella Junction, Bogisichmouth, Tonga", new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a"), "67564 Prohaska Manors, Stehrton, Liechtenstein", new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cc8d1037-21b0-4bb9-b489-90adbbd1375c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 24, 7, 54, 43, 827, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 2, 28, 7, 54, 43, 827, DateTimeKind.Local).AddTicks(8595), null, 71.39m, 2757834413063835m, "Standart", 5, 4.7997894f, "34543 Billy Mission, Lake Ford, Samoa", new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9"), "736 Schmidt Points, Cruickshankhaven, Guinea", new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d1119a0e-022c-4385-a912-1e3575a759f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 18, 5, 39, 36, 906, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 10, 24, 5, 39, 36, 906, DateTimeKind.Local).AddTicks(1006), null, 46.72m, 4107798979988384m, true, "Super", 4, 48.146156f, "557 Aiden Field, Lake Bethanyborough, Saint Martin", new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0"), "62653 Parker Mount, Berniertown, French Polynesia", new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d3f247f4-8914-420b-b19b-87a184a750b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 4, 35, 4, 942, DateTimeKind.Local).AddTicks(3362), new DateTime(2023, 10, 19, 4, 35, 4, 942, DateTimeKind.Local).AddTicks(3362), null, 44.58m, true, 7693294922097224m, true, "ParcelMachine", 2, 36.55253f, "761 O'Conner Inlet, Wizafurt, Libyan Arab Jamahiriya", new Guid("a8eb141c-5178-4baa-b599-679287b17c92"), "5433 Bernhard Cape, Lake Presleyland, Angola", new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d7a66370-3be6-490a-9688-3843b5f59a39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 12, 17, 32, 31, 900, DateTimeKind.Local).AddTicks(7238), new DateTime(2024, 4, 13, 17, 32, 31, 900, DateTimeKind.Local).AddTicks(7238), null, 80.52m, true, 4358856751326678m, "Standart", 3, 36.66606f, "0805 Stuart Spring, South Isabell, Cuba", new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52"), "011 Reichel Bypass, Roxannefort, Comoros", new Guid("e881572a-cd4a-4d95-bf26-6855a9394560"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d8118520-60ce-436e-a6d8-d1b3d50b9f82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 1, 11, 11, 52, 799, DateTimeKind.Local).AddTicks(1997), new DateTime(2024, 5, 6, 11, 11, 52, 799, DateTimeKind.Local).AddTicks(1997), null, 95.99m, 3032530188912618m, true, "Standart", 3, 19.270073f, "305 Toy Fork, Borertown, Cuba", new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1"), "8370 Lewis Viaduct, Dickiburgh, Mayotte", new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("dde20036-f49a-4fca-bd8b-8da19add58c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 6, 5, 30, 15, 247, DateTimeKind.Local).AddTicks(1530), new DateTime(2024, 2, 7, 5, 30, 15, 247, DateTimeKind.Local).AddTicks(1530), null, 17.32m, true, 6214124844816543m, "Special", 4, 34.642002f, "0486 Zelda Turnpike, Port Joyce, Sweden", new Guid("5053bd1a-741f-48b6-8412-85c27342ccca"), "310 Henry Junction, Corwinville, Sudan", new Guid("a42b469c-fec8-4056-a4de-926b01b7f202"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("de2fb117-a84a-4ad0-aee7-8555820429a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 18, 16, 58, 7, 886, DateTimeKind.Local).AddTicks(4629), new DateTime(2024, 4, 22, 16, 58, 7, 886, DateTimeKind.Local).AddTicks(4629), null, 79.06m, 9186926073995424m, "Standart", 2, 5.266322f, "35705 Pauline Forge, Yosttown, Puerto Rico", new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed"), "40953 Alayna Lights, Oralshire, Guadeloupe", new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e192d0a3-1e6d-4e8c-b234-df7f23aca172"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 13, 5, 56, 37, 205, DateTimeKind.Local).AddTicks(7711), new DateTime(2023, 7, 15, 5, 56, 37, 205, DateTimeKind.Local).AddTicks(7711), null, 30.56m, 4745375073891666m, true, "ParcelMachine", 1, 31.464401f, "5374 Streich Ridges, Raynorburgh, Luxembourg", new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259"), "5106 Luz Trace, New Juana, Jordan", new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e6cfb476-c6f1-4384-b24e-2ffde1f24936"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 24, 17, 0, 49, 905, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 10, 27, 17, 0, 49, 905, DateTimeKind.Local).AddTicks(2922), null, 90.66m, true, 1983075950470221m, true, "Courier", 2, 0.63405603f, "419 Lenore Port, Lake Kristoferfurt, Jersey", new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6"), "8706 Lemke Row, Lake Pietroville, Romania", new Guid("963654b6-a05e-4be7-b120-45295941d954"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e7e7c1bc-5f98-41e1-b084-8687e9a9313c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 3, 1, 17, 59, 639, DateTimeKind.Local).AddTicks(6036), new DateTime(2024, 1, 13, 1, 17, 59, 639, DateTimeKind.Local).AddTicks(6036), null, 62.41m, true, 2265291948628108m, "Super", 4, 30.582891f, "9762 Davon Locks, New Ola, Israel", new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5"), "583 Edd Plaza, East Sarah, Guam", new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ebaa78b2-0c2f-4a90-86f5-33f7f8a16493"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 18, 15, 8, 49, 327, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 10, 26, 15, 8, 49, 327, DateTimeKind.Local).AddTicks(5857), null, 78.82m, 2186646608137598m, "Standart", 1, 27.418337f, "92970 Hansen Knoll, Hilmachester, Montserrat", new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33"), "132 Haag Alley, Darwinmouth, Burkina Faso", new Guid("963654b6-a05e-4be7-b120-45295941d954"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("eed5521a-7255-4bdf-8466-fcfa8c08dcf2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 9, 8, 18, 17, 923, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 1, 13, 8, 18, 17, 923, DateTimeKind.Local).AddTicks(8731), null, 34.00m, true, 2095659089469486m, true, "Super", 5, 1.9003012f, "410 Toby Circle, North Selina, Vanuatu", new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361"), "831 O'Reilly Inlet, East Julie, Botswana", new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ef61e08e-99b2-4f52-97ad-44dfc9a1f8f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 4, 22, 45, 41, 348, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 2, 7, 22, 45, 41, 348, DateTimeKind.Local).AddTicks(8601), null, 83.91m, true, 9471246505980638m, "ParcelMachine", 5, 35.20032f, "2821 Nettie Wells, Vilmaborough, Russian Federation", new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab"), "35888 Keegan Lodge, Kilbacktown, Colombia", new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794"), "Sent", "CardboardBox" },
                    { new Guid("f19457cf-6144-41d7-83b4-39a182b8f98d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 13, 22, 28, 42, 869, DateTimeKind.Local).AddTicks(1043), new DateTime(2023, 7, 17, 22, 28, 42, 869, DateTimeKind.Local).AddTicks(1043), null, 32.58m, true, 1095901005543887m, "Super", 3, 40.23026f, "27119 Jones Ports, New Willie, Chad", new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f"), "24758 Homenick Island, Fritschstad, United States of America", new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8"), "Return", "CardboardBox" },
                    { new Guid("f5e3f878-0e10-42f8-8048-7be91a9f139e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 2, 12, 40, 37, 792, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 2, 10, 12, 40, 37, 792, DateTimeKind.Local).AddTicks(4986), null, 51.05m, true, 2710063969979269m, "Courier", 1, 21.156174f, "358 Esmeralda Overpass, Maximilliantown, Kenya", new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841"), "714 Loren Stravenue, Stehrport, Greece", new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0"), "OnTheWay", "CardboardBox" },
                    { new Guid("f6efad54-e5d8-4853-a2f9-dca841cb2e72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 1, 18, 49, 13, 619, DateTimeKind.Local).AddTicks(2084), new DateTime(2024, 1, 10, 18, 49, 13, 619, DateTimeKind.Local).AddTicks(2084), null, 69.40m, true, 7492273646638472m, "Courier", 3, 43.313183f, "128 Tianna Port, Altenwerthbury, Uruguay", new Guid("c187c610-03e7-4305-96e2-96f776a463e0"), "99781 Earline Ville, Morissettefurt, Russian Federation", new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fbdafddb-d228-4fc1-937b-20cdb95b96cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 25, 19, 16, 53, 647, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 10, 2, 19, 16, 53, 647, DateTimeKind.Local).AddTicks(3043), null, 94.26m, 5563268443660732m, "ParcelMachine", 1, 47.739727f, "562 Lockman Summit, Sisterfurt, Christmas Island", new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), "51387 Mellie Drives, Willisfort, Zimbabwe", new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("fc5deadc-d029-442c-91e6-58501dde70ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 9, 6, 25, 44, 642, DateTimeKind.Local).AddTicks(8352), new DateTime(2024, 5, 18, 6, 25, 44, 642, DateTimeKind.Local).AddTicks(8352), null, 57.31m, 1603275883739039m, true, "Courier", 1, 28.174309f, "78271 Hailey Pine, West Sonnyborough, Cambodia", new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95"), "03492 Brandyn Extensions, Port Cesartown, Bahrain", new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), "Registered", "CardboardBox" },
                    { new Guid("fe163bd0-b54b-4d78-87c7-03afae98ccfa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 10, 20, 19, 18, 503, DateTimeKind.Local).AddTicks(3263), new DateTime(2023, 9, 15, 20, 19, 18, 503, DateTimeKind.Local).AddTicks(3263), null, 74.16m, 7232333543224344m, true, "ParcelMachine", 1, 25.678257f, "9899 Koch Cape, South Leanne, Papua New Guinea", new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6"), "380 Altenwerth Wall, Manleyfort, France", new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ff820a8b-680b-4ccd-97a3-1f5abd8fb6f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 22, 17, 11, 140, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 5, 27, 22, 17, 11, 140, DateTimeKind.Local).AddTicks(5163), null, 77.99m, true, 3289155761349938m, true, "Special", 2, 5.704415f, "1991 Beier Terrace, Miracleview, Somalia", new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "036 Conn Island, West Emanuelberg, Micronesia", new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ffbc4cd9-a332-4ebb-8015-069989167e21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 27, 17, 2, 20, 436, DateTimeKind.Local).AddTicks(2414), new DateTime(2023, 8, 30, 17, 2, 20, 436, DateTimeKind.Local).AddTicks(2414), null, 36.09m, 8594355797919856m, true, "Super", 4, 33.048763f, "34738 Runolfsdottir Summit, Melanyhaven, Aruba", new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b"), "035 Kyle Circle, North Daija, Burundi", new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("00383347-067f-43fd-8403-a2842570b853"), "803", "9175862978806315", null, null, new Guid("c41a987e-114e-4968-aa63-744e27096322"), "02/08" },
                    { new Guid("00514826-6df7-4ef8-8b49-213eedba9c3a"), "291", "2258055186320937", null, null, new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794"), "09/03" },
                    { new Guid("015ddd0f-62da-4cd3-ab5c-83de53c4d043"), "311", "4218771558794746", null, null, new Guid("71978c89-b953-4ec5-98a8-ab384223de1a"), "01/22" },
                    { new Guid("015e8da1-12e1-4f5e-bdca-c70b15ead336"), "601", "8369881181512857", null, null, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693"), "11/25" },
                    { new Guid("01ae2d6f-1fd1-4471-93ed-d0a3b0097e5c"), "647", "1789772605323972", null, null, new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc"), "09/09" },
                    { new Guid("02349c24-c447-4f46-a04f-1060f33a72ea"), "420", "1750982687913652", null, null, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518"), "02/02" },
                    { new Guid("028b263a-d95d-4011-b0f2-17f400e17ed7"), "838", "3433138625125496", null, null, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565"), "10/21" },
                    { new Guid("02d64f1b-b9e3-40e0-aa0f-a6615fd486d5"), "605", "2546707782020771", null, null, new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405"), "11/25" },
                    { new Guid("0366ceff-7e6c-4ed9-9631-e518852dd3d1"), "088", "7649632505221466", null, null, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988"), "08/20" },
                    { new Guid("03b5d64a-274d-4944-8b94-24b1484dcc44"), "965", "7377834587283908", null, null, new Guid("fa64f167-af58-425d-8dce-93642bd7650a"), "10/02" },
                    { new Guid("03bc8c87-26a3-4ad1-a38c-1abb378aefb4"), "207", "9710373342201116", null, null, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03"), "05/14" },
                    { new Guid("03fd75a6-58af-4753-ad08-75fc91b8d75d"), "445", "7143149203084833", null, null, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed"), "06/05" },
                    { new Guid("03ffd98c-7db7-4d93-a943-986ffb2df221"), "781", "5920412615614995", null, null, new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2"), "04/06" },
                    { new Guid("0454d0a6-771c-4ad7-861b-ff6ec36a44f0"), "869", "2139566715110787", null, null, new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163"), "10/08" },
                    { new Guid("046dfea3-7e3b-4536-ad6b-a6535db4111f"), "638", "3075022478764471", null, null, new Guid("80527681-e153-441a-b963-5dad43aab962"), "02/10" },
                    { new Guid("04766bc7-0631-4af6-8054-2f8dd05f7240"), "915", "1726697511721882", null, null, new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1"), "08/06" },
                    { new Guid("04ec3cce-b7e7-4af6-9e7b-785d7da304e6"), "482", "3204043773413189", null, null, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb"), "08/24" },
                    { new Guid("050eb40c-b86b-4730-9bcf-c447993d216e"), "865", "9673613573541101", null, null, new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215"), "09/25" },
                    { new Guid("058d9c53-bb40-439a-b32e-4521677a0c10"), "491", "9520325303429449", null, null, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33"), "12/18" },
                    { new Guid("0602ef44-1f46-4d5b-a16e-c890767a4e3c"), "996", "3193522486650850", null, null, new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92"), "10/19" },
                    { new Guid("06095821-e51d-477c-9d18-126f013eab54"), "652", "2184115886203377", null, null, new Guid("787d2d2c-d05b-4935-906f-090d713b622f"), "07/23" },
                    { new Guid("06b6e4cf-e8f2-411e-8c9b-41d84742f141"), "275", "7053050133436635", null, null, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db"), "08/05" },
                    { new Guid("0790b753-77fa-4c98-b788-f3bdde5bd14d"), "981", "6080615022362996", null, null, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f"), "07/07" },
                    { new Guid("07a601a0-7dd7-4afb-a6f3-b4ec7277d491"), "374", "5236880190643814", null, null, new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643"), "08/20" },
                    { new Guid("08151c57-3e54-4454-a629-b21789d9006c"), "279", "2415235779211312", null, null, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16"), "09/14" },
                    { new Guid("08488dec-4f5b-4e12-906e-74a580ab11a0"), "993", "8264606586305664", null, null, new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db"), "01/18" },
                    { new Guid("09971d4b-fbc1-4402-980b-c0e8233f7fb5"), "941", "3159175051867940", null, null, new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0"), "06/26" },
                    { new Guid("0a5b7467-143f-46d0-86c2-59f9fe5d4aaa"), "780", "9125074291102857", null, null, new Guid("9ace24ed-f865-4310-9613-b304be005b00"), "08/16" },
                    { new Guid("0aed6599-1b32-421b-849d-a3a5d3087f1e"), "928", "6409924646326280", null, null, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10"), "11/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0b287df4-628d-41fa-91bd-66e991a2c6d2"), "180", "5815842409993095", null, null, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6"), "12/26" },
                    { new Guid("0b75257d-ad05-440a-8c03-b7548ba85b55"), "635", "3709667381061371", null, null, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44"), "12/02" },
                    { new Guid("0bcdb36c-0d7c-4e98-b75e-f57e32355c07"), "568", "1176260250073099", null, null, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb"), "04/08" },
                    { new Guid("0bd9face-eb53-4c4a-aed9-6d8ffb4594df"), "800", "4108691865058961", null, null, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f"), "11/07" },
                    { new Guid("0be9ea5a-6b41-412c-9392-4eb77b9aeeea"), "885", "1404027199037104", null, null, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e"), "04/03" },
                    { new Guid("0ca18200-42a2-4663-8347-d286662f3929"), "956", "6975268201537251", null, null, new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4"), "07/15" },
                    { new Guid("0cafafcc-232c-4eed-9b19-ab357f674806"), "622", "7850927710313910", null, null, new Guid("e31a76f4-5bec-480b-974e-4e00950656e8"), "03/03" },
                    { new Guid("0d0fa466-af94-4577-a945-feed22c7b0b3"), "578", "7227718242252189", null, null, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd"), "09/11" },
                    { new Guid("0d4a25d8-4ef4-44b6-a236-5a5d01835c95"), "611", "7685629979362868", null, null, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe"), "06/28" },
                    { new Guid("0d6c55b2-82f3-4bee-9bf7-352cb8a91cb5"), "161", "1991508701990429", null, null, new Guid("85178881-d883-4586-bf89-10a49abb8b16"), "12/02" },
                    { new Guid("0d72cae3-a271-450b-ba85-62bb363821d8"), "459", "5423705392440837", null, null, new Guid("680c6306-048b-493d-8369-356efb0cafae"), "01/05" },
                    { new Guid("0d79ba64-d53b-46a3-b534-63d61ccfd963"), "049", "7064739751895962", null, null, new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7"), "02/14" },
                    { new Guid("0d7f1ad3-e966-43fb-9671-6dffded07172"), "514", "6596067578129577", null, null, new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa"), "12/26" },
                    { new Guid("0e0c398d-3cd1-49b9-9cbb-1a658ac40cf9"), "272", "5142497244851993", null, null, new Guid("d8e6873e-ae0e-4181-866e-982565b77df9"), "08/13" },
                    { new Guid("0e3da847-9980-4cab-ac06-a07e704488ed"), "425", "7171819344926712", null, null, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb"), "03/13" },
                    { new Guid("0f26a2fb-4988-461b-8701-1abe7f7fc2fc"), "117", "6647090445452130", null, null, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33"), "08/18" },
                    { new Guid("0fc1bd44-5eca-4baf-b765-eeff15247944"), "882", "6522004549722684", null, null, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0"), "11/07" },
                    { new Guid("0fcf68d9-7926-49b8-bebd-f713a42d1469"), "318", "9321652658493862", null, null, new Guid("64ae7664-3300-40cf-a69a-7862eca124da"), "08/06" },
                    { new Guid("10314754-f04d-4b58-8b53-67058ecc91ba"), "626", "5211116183101910", null, null, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e"), "05/01" },
                    { new Guid("106d1a8b-76d9-4da4-8376-493269eb561d"), "895", "7429314869650765", null, null, new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5"), "05/26" },
                    { new Guid("108ead8d-1d46-47c5-9281-628ef9419e0d"), "717", "4097107422119909", null, null, new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f"), "01/20" },
                    { new Guid("10bf07ad-2480-45fa-a265-1076577f78e8"), "370", "8669566679970866", null, null, new Guid("963654b6-a05e-4be7-b120-45295941d954"), "10/26" },
                    { new Guid("117d091b-9ce6-448e-a3cb-3b64c5465756"), "535", "9127909110055739", null, null, new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd"), "06/13" },
                    { new Guid("122b285f-e36b-4c59-8e7d-b9f903dd65bd"), "455", "2271939203683948", null, null, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e"), "02/17" },
                    { new Guid("125e92c8-9993-4fc4-984c-27533cc11eb3"), "528", "8132577417494696", null, null, new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305"), "12/13" },
                    { new Guid("1264f399-0b0e-4b34-a7f0-63906c8ad7f3"), "955", "1245068133279057", null, null, new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3"), "08/23" },
                    { new Guid("12db882b-620b-4a28-ba0b-4dd0e2e196e3"), "446", "6572711207564041", null, null, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062"), "08/02" },
                    { new Guid("12de9098-4221-4349-b0fa-5285e5963ff3"), "636", "6681419845505166", null, null, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc"), "09/25" },
                    { new Guid("1304c64a-f1ba-427e-b273-7e6b6db06fbf"), "806", "6941815080914251", null, null, new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db"), "03/06" },
                    { new Guid("1372627e-2273-4b69-9b06-3c14ec1f595b"), "859", "4908632784361144", null, null, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641"), "04/26" },
                    { new Guid("138c8f61-1d75-45a2-9968-ccfd19f97cfc"), "201", "7590323866660493", null, null, new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15"), "05/27" },
                    { new Guid("13c7303f-e455-4975-84a7-bf82d4ea0d50"), "104", "6820588144464205", null, null, new Guid("4390173e-3194-44b0-9f5c-e816c829e49d"), "03/21" },
                    { new Guid("13d1ebac-7cde-4033-babd-2ea3ce6164b8"), "708", "9648781948656324", null, null, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6"), "11/23" },
                    { new Guid("140a93b1-ea5e-4705-a698-adf932a531d6"), "356", "1686807122291544", null, null, new Guid("354e9bbf-de43-4345-a871-f0af96ec9410"), "07/18" },
                    { new Guid("142e8e4d-3c81-4b9f-ae55-d6c8a30e19cf"), "200", "3750775533775982", null, null, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef"), "10/27" },
                    { new Guid("14f0f455-ac42-4398-a095-c0157b8bcbc0"), "050", "8183212320438927", null, null, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5"), "09/27" },
                    { new Guid("153493ac-6c33-4fea-9582-d817031791ae"), "574", "5077426242029558", null, null, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5"), "01/02" },
                    { new Guid("15627bf8-03c3-4256-825e-c4c7cbff2a6a"), "030", "9439169819476345", null, null, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44"), "05/03" },
                    { new Guid("159e0de8-88f9-4a22-84a7-1c1950623046"), "760", "2786233726190309", null, null, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8"), "02/02" },
                    { new Guid("15be2d14-1613-4bf5-98d1-6233459c6fb0"), "455", "5333884400297943", null, null, new Guid("7b8e2086-2aa9-4256-9444-793523c7a280"), "02/08" },
                    { new Guid("16024e1e-48a3-4648-93e4-44e222ac11ae"), "968", "1943583056732797", null, null, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe"), "12/26" },
                    { new Guid("165668c7-973b-4f1a-a4be-3a09a0ce09d4"), "257", "4216089889637928", null, null, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d"), "06/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("16710f8c-f712-4758-958e-4742590cc6e0"), "845", "2681717213545583", null, null, new Guid("246ee090-764e-420d-803e-5d97e7d873a0"), "06/13" },
                    { new Guid("16af9188-ad3d-4e90-8ee8-29ebec537a6c"), "827", "7859071789196152", null, null, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb"), "09/02" },
                    { new Guid("16afbebe-c531-49e2-a560-a45de6b5f1b7"), "797", "3514069245673332", null, null, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d"), "06/22" },
                    { new Guid("17287bab-93b6-4dcb-8bbb-03745166a6d8"), "239", "8106854800525254", null, null, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9"), "04/20" },
                    { new Guid("18135092-4f58-4a0d-9478-9a71a0fc33e8"), "688", "7682190176936744", null, null, new Guid("26e9f9a9-c77f-4f47-b594-e602be058706"), "06/03" },
                    { new Guid("185977ff-f451-4967-893f-ef2144ec936b"), "391", "8024461071054995", null, null, new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a"), "06/17" },
                    { new Guid("18b7cc30-61d3-4a4d-a11b-dcdb9bca1227"), "800", "1740919617309840", null, null, new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c"), "04/15" },
                    { new Guid("18e04561-9cb2-4798-beb4-c81c407aac65"), "787", "4510529803049802", null, null, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c"), "01/12" },
                    { new Guid("18f0d4e9-a2b5-49d6-bb3f-6337a88ffaf0"), "173", "2986135557324708", null, null, new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0"), "11/16" },
                    { new Guid("1937b3f0-cd1b-4c86-bb7c-47c8f71bb5ab"), "998", "5585506313983883", null, null, new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab"), "06/13" },
                    { new Guid("19492e84-94a7-4848-9396-73b80c8fe239"), "659", "2853349489311908", null, null, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641"), "10/06" },
                    { new Guid("1aa745b0-5611-4700-b61c-4d5f9b82a580"), "395", "2035422368954561", null, null, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2"), "03/09" },
                    { new Guid("1aebafde-b30a-426f-a825-05935ccb4cfc"), "592", "8241592344206328", null, null, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0"), "11/16" },
                    { new Guid("1b572095-34e3-4987-afad-af2f553f3ff2"), "191", "3261345077868118", null, null, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc"), "01/10" },
                    { new Guid("1ba4c1aa-041c-4376-842f-9812f0059970"), "011", "2349326858537580", null, null, new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2"), "04/22" },
                    { new Guid("1bbfb206-22c4-43a5-b8ea-3f54b760bc57"), "036", "5798477820163825", null, null, new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163"), "11/28" },
                    { new Guid("1bea6d4f-9eec-4ae4-a4eb-67a4166a8564"), "128", "8080393866840067", null, null, new Guid("364df856-5357-4366-afda-cf52f25f1325"), "06/23" },
                    { new Guid("1bf2016e-02d8-4d37-a6d3-d0929e28e411"), "146", "9617203001508349", null, null, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78"), "04/04" },
                    { new Guid("1bfb1f1c-3480-47d9-a056-f6b9ebffff26"), "409", "2583864486378309", null, null, new Guid("680c6306-048b-493d-8369-356efb0cafae"), "10/04" },
                    { new Guid("1bfbd7f2-e085-408e-aa17-f8516ae39d63"), "644", "5211170110795156", null, null, new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15"), "01/15" },
                    { new Guid("1c2f864e-1737-4e74-9846-28cec6cc1f8e"), "328", "2331112335448575", null, null, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2"), "03/03" },
                    { new Guid("1c3788fc-9a31-4a0a-ab8c-559040f03d71"), "824", "9186923368577807", null, null, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900"), "05/08" },
                    { new Guid("1c4fecca-1e1d-45ef-8d63-b0206a6e3145"), "899", "2810160158482519", null, null, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971"), "07/12" },
                    { new Guid("1c5a3d7c-320f-408d-b117-d6e6cdae79ed"), "729", "8682627693173993", null, null, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5"), "10/18" },
                    { new Guid("1c5eba45-c85a-49bf-baa7-e317374fb34d"), "493", "5616094612907956", null, null, new Guid("e31a76f4-5bec-480b-974e-4e00950656e8"), "06/20" },
                    { new Guid("1cae46e1-9de9-49bc-bc00-7c95519c89e9"), "117", "5689497562882819", null, null, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9"), "07/11" },
                    { new Guid("1d5554a3-e456-455c-a436-5f2615e92c84"), "299", "7654640362894699", null, null, new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4"), "01/22" },
                    { new Guid("1d733d0a-4d4a-469d-a3f2-1d4f594476c0"), "925", "9287663662020795", null, null, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c"), "08/14" },
                    { new Guid("1d85da2e-907c-4d53-9512-9cf81cc53214"), "277", "4383951569541189", null, null, new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7"), "01/18" },
                    { new Guid("1def21ab-70a1-4a63-97ef-73a1466424be"), "928", "4752457164088144", null, null, new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036"), "09/27" },
                    { new Guid("1df13298-8088-408f-9aa7-73fdfe7653d8"), "223", "2131109090677480", null, null, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2"), "01/05" },
                    { new Guid("1e4f952b-8021-49e1-a526-31a2110d90c9"), "571", "9256932330685994", null, null, new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0"), "07/27" },
                    { new Guid("1e6ef313-2867-4259-b8ab-1542e8efacda"), "934", "9400184146516857", null, null, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c"), "02/14" },
                    { new Guid("1e8065de-8834-4fa1-a1c2-cc3c3dc02e2c"), "753", "9420806874326108", null, null, new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4"), "09/18" },
                    { new Guid("1e83f4cb-6e38-4611-974c-a0baa796920f"), "253", "5080174160878208", null, null, new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53"), "12/02" },
                    { new Guid("2036b745-27bb-407d-8f35-9dbe328f654d"), "559", "4722113280764663", null, null, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737"), "08/08" },
                    { new Guid("20571d34-80d9-4f8d-9cb1-8ef1f10b0c68"), "102", "7043501438537082", null, null, new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615"), "10/03" },
                    { new Guid("20f7fc45-7f87-42e2-91aa-4542ccc211d2"), "182", "4942312609613640", null, null, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1"), "07/13" },
                    { new Guid("214f12a6-dc75-452e-8e6f-82ca6c78dce9"), "916", "6302938643998972", null, null, new Guid("a836bc35-12f7-485d-861b-ad1645878c24"), "06/06" },
                    { new Guid("21ccc874-e088-47f9-a88e-bd5c67a56fe4"), "544", "6499363193491911", null, null, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed"), "05/17" },
                    { new Guid("220f1090-ebb4-45e1-a5de-f51f5daf3c2c"), "849", "1060976402358952", null, null, new Guid("64ae7664-3300-40cf-a69a-7862eca124da"), "05/12" },
                    { new Guid("22291e8b-98ae-47e3-9470-90713fc9c9e2"), "684", "7098024565811597", null, null, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf"), "06/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("225e049e-65c8-45b3-93b6-4c32a018603f"), "462", "9042615908882023", null, null, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8"), "07/07" },
                    { new Guid("22782925-eee1-45ca-bb9c-20230985e5b0"), "412", "1926352095765842", null, null, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5"), "09/25" },
                    { new Guid("2287504a-f27f-4528-9634-a2bf90803569"), "116", "6428128958874328", null, null, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1"), "04/20" },
                    { new Guid("2312ec31-1b4b-41a9-b160-4746197a19d8"), "101", "4588144847363301", null, null, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971"), "11/07" },
                    { new Guid("23beab4f-4ab9-4a5e-9e51-537d9fa60af7"), "762", "5599201400903845", null, null, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19"), "05/26" },
                    { new Guid("23d1ceec-7ff4-43fd-8a75-1beb22451729"), "020", "1982995792497128", null, null, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948"), "10/15" },
                    { new Guid("2503e9a8-4734-4970-b17e-3304402d9492"), "428", "1035405822527314", null, null, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db"), "07/01" },
                    { new Guid("256ec10b-26e8-44bb-ba28-b5d08bc5107b"), "683", "6325872316000467", null, null, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca"), "11/15" },
                    { new Guid("25b187b7-5482-4721-8504-904e66027318"), "058", "4832998874027746", null, null, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7"), "02/13" },
                    { new Guid("25f46775-6305-4c9e-b743-e85ab9170625"), "870", "3450726369453342", null, null, new Guid("fa64f167-af58-425d-8dce-93642bd7650a"), "08/09" },
                    { new Guid("26407d5a-6787-4aab-a8b1-2af60f215ac0"), "081", "9525370309746149", null, null, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "09/15" },
                    { new Guid("26acf26c-693b-468b-ad08-984899f3ec26"), "533", "7578252394705224", null, null, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370"), "12/27" },
                    { new Guid("26bfacb1-1698-4538-a1c2-ad32175e4cc7"), "185", "9357786755489624", null, null, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727"), "08/26" },
                    { new Guid("26d5642e-208b-4d6c-b647-34526e580dff"), "375", "1239017569494555", null, null, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef"), "06/18" },
                    { new Guid("271819b9-1bf4-4d68-beeb-db196abb8d54"), "386", "3918434287026199", null, null, new Guid("354e9bbf-de43-4345-a871-f0af96ec9410"), "07/23" },
                    { new Guid("27ae7399-6d9c-4d18-8668-ebdfe5dc4ce5"), "601", "1309563956366352", null, null, new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1"), "03/25" },
                    { new Guid("27e1f6ac-276c-4df4-a356-b6264395c11a"), "518", "7755442719982990", null, null, new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405"), "11/08" },
                    { new Guid("27ff226e-ec60-4dde-bfc7-7ca8731be558"), "580", "4804400027907141", null, null, new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad"), "12/09" },
                    { new Guid("281ad090-0645-4387-a2f1-9cdbce085e51"), "566", "8246820137596644", null, null, new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79"), "09/03" },
                    { new Guid("282b208f-7442-4d4e-a482-0c9a2978201d"), "661", "2290684740656831", null, null, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737"), "12/22" },
                    { new Guid("28b5b4e6-4ff7-43d8-822f-c4f5fa5176e2"), "192", "8587893931252571", null, null, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db"), "07/14" },
                    { new Guid("28c7443a-99fd-4656-98de-1ef0953ea65b"), "392", "4304104209633627", null, null, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed"), "12/10" },
                    { new Guid("28d4fb41-f05b-4609-9432-9e39dbe338e2"), "682", "6262802681706279", null, null, new Guid("787d2d2c-d05b-4935-906f-090d713b622f"), "11/26" },
                    { new Guid("294d300d-28a4-469e-9f3c-fa7dc1d4317b"), "536", "9593988320822323", null, null, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10"), "04/22" },
                    { new Guid("2952041d-d218-48ee-b65b-439c9fcc0a7a"), "582", "7334686598372676", null, null, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597"), "10/10" },
                    { new Guid("297b738f-f1df-46fe-8711-fb943a4b7c79"), "267", "5239033358947720", null, null, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd"), "01/27" },
                    { new Guid("298affe4-9880-4545-859f-6b2b2c417f64"), "854", "6447057701789463", null, null, new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305"), "03/02" },
                    { new Guid("29d9c3e3-ec86-4dd5-926f-f7dc51119e32"), "334", "2764584994352885", null, null, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), "08/28" },
                    { new Guid("2a0134e1-d17e-48eb-8bb2-48a0c305c53d"), "492", "3745136264859400", null, null, new Guid("5911b08b-117c-4079-af41-1eb1e8574741"), "06/08" },
                    { new Guid("2a1b35b6-a42a-4fd8-bfc7-c9642c3aa6a3"), "255", "1206059511067919", null, null, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8"), "04/03" },
                    { new Guid("2a43e2cc-cdb9-4ab6-a789-f815b49bfcc9"), "216", "6092154432441204", null, null, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf"), "08/28" },
                    { new Guid("2a73492b-419d-4d54-9e7c-76eadfff04c3"), "477", "5463849901876709", null, null, new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8"), "11/18" },
                    { new Guid("2aca25b0-9f0f-4a6f-a60d-c98960086b88"), "329", "4550479158136459", null, null, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1"), "07/16" },
                    { new Guid("2adec266-1ccf-43ce-a89f-8303e8d88e59"), "602", "2833090512613465", null, null, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6"), "09/08" },
                    { new Guid("2b552bc0-28fe-4848-a3e9-b034d1c57289"), "495", "3842471959948527", null, null, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6"), "04/22" },
                    { new Guid("2b657b4d-d7f6-412f-94e8-a50f5355ea75"), "639", "2361833780368916", null, null, new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a"), "05/12" },
                    { new Guid("2ba4afaf-622d-47f5-96cf-5d437d5a7a08"), "032", "5337196763312302", null, null, new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267"), "10/12" },
                    { new Guid("2ba5dba4-c342-4d50-84f5-667fe25c29f0"), "055", "3861332914627986", null, null, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab"), "10/12" },
                    { new Guid("2c42995a-14fb-4e03-b2f7-3a515e3d7835"), "969", "3910115172265184", null, null, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40"), "06/26" },
                    { new Guid("2ca2cf2e-df5e-4561-a1dd-32666bb3ec90"), "031", "7602930653696090", null, null, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75"), "02/12" },
                    { new Guid("2ce006b9-5573-4b5a-b405-4ba0e1ddd5cd"), "075", "4833769496011616", null, null, new Guid("8576464a-f366-4076-97bd-00c2481b9a38"), "06/13" },
                    { new Guid("2cfcdd02-11aa-4a33-8b8a-744d809c743c"), "662", "2680259522240427", null, null, new Guid("431cb355-ae94-49cc-882c-971e60381b53"), "07/16" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("2d58b098-7fb7-4a55-a7c1-7a672e8bdc8d"), "644", "4510816475197126", null, null, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988"), "05/13" },
                    { new Guid("2d645ec8-70c2-4298-8e53-1348906d83cf"), "294", "2003345531118729", null, null, new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf"), "12/11" },
                    { new Guid("2d7432c9-73b4-4c11-9391-29481e2710b5"), "861", "1432464678952367", null, null, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86"), "04/04" },
                    { new Guid("2d96036b-a607-4697-b254-1e23f584edd4"), "567", "7510723419877476", null, null, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c"), "09/19" },
                    { new Guid("2da8b2e3-40b3-44a6-9b6e-cdb0112ae09f"), "105", "8654644699697992", null, null, new Guid("bea80970-74bf-4539-a300-cbbac8625744"), "01/07" },
                    { new Guid("2de8164d-61dd-4225-b5a3-f1cf81bd04dc"), "084", "4385114043251085", null, null, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d"), "12/11" },
                    { new Guid("2decdc89-2ad8-4f49-8c71-6a9bbe2c2119"), "080", "5174841815349622", null, null, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0"), "03/21" },
                    { new Guid("2e5240d9-683a-4c49-a688-66d17b36193d"), "495", "1199369301148727", null, null, new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a"), "03/28" },
                    { new Guid("2ea4d495-d642-4962-b92d-c9fac14a8735"), "032", "4512048699125078", null, null, new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105"), "04/12" },
                    { new Guid("2eabf006-fbf1-45df-a5ac-290563a3f4d2"), "619", "1132577238656378", null, null, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216"), "02/23" },
                    { new Guid("2eb10364-4960-4469-94eb-269a4f817f13"), "601", "3217874326482282", null, null, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641"), "06/24" },
                    { new Guid("2f5cb819-7160-4c10-82f5-36908e5e5ef9"), "138", "3802683269528937", null, null, new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588"), "03/10" },
                    { new Guid("2f72fa82-61bc-49f1-bc4d-517020809987"), "292", "8555682048279213", null, null, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef"), "07/24" },
                    { new Guid("2f8eab16-2cf3-4f79-a028-3a7860ee9e14"), "290", "4563478029159223", null, null, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c"), "05/18" },
                    { new Guid("2f923c57-067f-4961-9cb4-9345ae3223d4"), "366", "8659102411108372", null, null, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de"), "04/07" },
                    { new Guid("2fa0e221-0437-4627-b681-d61aa5e1b373"), "350", "6668808146887213", null, null, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86"), "09/10" },
                    { new Guid("2ffffac3-e809-4fa1-965f-c952089fc3a3"), "720", "7462553298068987", null, null, new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb"), "06/24" },
                    { new Guid("30ca2454-1358-4dd1-873d-d527ca3e1954"), "625", "9042178469394236", null, null, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10"), "06/28" },
                    { new Guid("30d2f636-7e49-441f-b81c-a07ad8a08c20"), "013", "7326033348920248", null, null, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285"), "12/22" },
                    { new Guid("30e438f0-fedf-4f4e-829d-4856bddec14a"), "038", "1990474372074466", null, null, new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf"), "02/22" },
                    { new Guid("30e80e96-e874-441b-9c70-8b65e88a931d"), "880", "9709977937827982", null, null, new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50"), "02/03" },
                    { new Guid("31362509-f579-42f9-bfc8-84d34dc59deb"), "060", "1766752030934549", null, null, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd"), "05/03" },
                    { new Guid("315ab9e2-60ef-4f2e-9a52-65ae267fe534"), "387", "4089491968383401", null, null, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c"), "01/18" },
                    { new Guid("31dacf67-611e-4b1b-9129-9177db973075"), "618", "3517173715509367", null, null, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef"), "03/26" },
                    { new Guid("322107a9-69cf-4b08-a7a8-1bbe6c64e5de"), "332", "8905682926401574", null, null, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5"), "01/22" },
                    { new Guid("329e731a-6180-4f13-8885-a8fdf5b15d5d"), "020", "4362420141946611", null, null, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc"), "12/11" },
                    { new Guid("3306c7e8-6889-4b62-903a-d4cd7494195b"), "008", "9786571659448639", null, null, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0"), "01/26" },
                    { new Guid("3362e56a-468f-4004-9640-b5ca65dada5d"), "224", "6613640796187381", null, null, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285"), "02/04" },
                    { new Guid("337ae2dd-b94f-4e04-a04a-894dc675416d"), "715", "9777288277537881", null, null, new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb"), "07/09" },
                    { new Guid("33dbb471-1363-47f2-86ed-f8140352d2e0"), "801", "3959044148555619", null, null, new Guid("364df856-5357-4366-afda-cf52f25f1325"), "07/12" },
                    { new Guid("348fa419-1297-4c01-8140-0b1a4aa449ee"), "857", "7705866265157084", null, null, new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808"), "03/07" },
                    { new Guid("34f79186-5e15-4a09-8cd7-8d58a4c3d92b"), "957", "3852816908031362", null, null, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891"), "12/10" },
                    { new Guid("351cde3f-f747-4037-a046-05ca8bdd9664"), "769", "4732894546748635", null, null, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf"), "01/22" },
                    { new Guid("3558fcd2-14fb-448c-8856-80129aa4423b"), "716", "9819653331934513", null, null, new Guid("71978c89-b953-4ec5-98a8-ab384223de1a"), "01/14" },
                    { new Guid("3658c117-75c8-490c-9269-ac2e9ae24dae"), "340", "2584401699031008", null, null, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481"), "06/12" },
                    { new Guid("366e2c4a-f0f1-48bf-80d9-4268823f35b6"), "076", "9177198232739916", null, null, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8"), "06/01" },
                    { new Guid("367f90a4-d1fe-4837-99cd-db8ddbebec06"), "935", "4679310442535257", null, null, new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8"), "02/25" },
                    { new Guid("38333be5-2f9a-4642-b58b-a0b2d0f46e3b"), "308", "1679505864529979", null, null, new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95"), "09/05" },
                    { new Guid("38531f02-41bc-431d-b7d1-654fe02d323f"), "666", "5297022261540672", null, null, new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4"), "11/07" },
                    { new Guid("38611e8d-00f5-416d-afbe-81e1b684cc21"), "292", "3356551685147331", null, null, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8"), "05/13" },
                    { new Guid("38dc2a0f-2c14-4264-9534-565a4c08f8e7"), "135", "9263088111487486", null, null, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0"), "06/02" },
                    { new Guid("39137f9c-642d-4d92-bf6f-422acf42c44d"), "014", "4068353761538469", null, null, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597"), "12/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("394b3d9f-95bd-42fe-a19c-8c38f66f2c53"), "405", "6285891930426325", null, null, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481"), "07/25" },
                    { new Guid("39714095-9ec4-4c58-b025-2405314736b2"), "430", "3109056192668731", null, null, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271"), "08/06" },
                    { new Guid("39dc60ec-8077-4eaa-8e2a-f3f18f02fb09"), "884", "3763308512548736", null, null, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd"), "07/18" },
                    { new Guid("3a597a8f-c9ee-447a-87be-78e59624ac00"), "027", "9566313105127007", null, null, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf"), "07/01" },
                    { new Guid("3b06b719-0530-4e85-88ab-e12468861474"), "336", "9708203256044205", null, null, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd"), "09/11" },
                    { new Guid("3b79769e-86fe-4669-a093-8cacc3462fae"), "745", "5571304059131905", null, null, new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696"), "09/11" },
                    { new Guid("3b8373e6-c333-4238-a3a1-5eaf5bf2ec46"), "413", "3061614424305669", null, null, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de"), "10/22" },
                    { new Guid("3c61b2e8-f921-4244-922a-44d5504d5a71"), "352", "2877742830317093", null, null, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33"), "03/22" },
                    { new Guid("3cf10c0b-5ad9-4206-a300-32ebb3aa8a64"), "423", "1872063840222192", null, null, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b"), "08/03" },
                    { new Guid("3d7980b1-7850-4fed-90bb-1199f1d03387"), "486", "2899201527388529", null, null, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de"), "08/03" },
                    { new Guid("3d7ae44b-8fc9-4701-bcd0-f263a8eb125a"), "788", "3085151931632399", null, null, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9"), "08/18" },
                    { new Guid("3dc23c50-6bff-42d7-be75-acca102116db"), "965", "4176459596022720", null, null, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c"), "06/17" },
                    { new Guid("3dd61273-11f5-4820-8b7b-228fa984b17c"), "280", "9916898710842634", null, null, new Guid("4bc48bed-c113-458c-8a12-8f12565a542b"), "05/02" },
                    { new Guid("3ded1b48-2499-499f-b9ab-c3527ccc8c16"), "976", "9740141289389297", null, null, new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0"), "11/12" },
                    { new Guid("3e1c343c-f7d1-4f67-9b5f-8cb2d0a7e82f"), "012", "4537381902722869", null, null, new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c"), "03/02" },
                    { new Guid("3e9e4b67-70c7-499a-8f08-e0bd55ce2c4b"), "193", "2451968130265017", null, null, new Guid("64ae7664-3300-40cf-a69a-7862eca124da"), "01/17" },
                    { new Guid("3ead758b-75a9-490e-a920-d6db52fd7ef0"), "375", "2524371065062761", null, null, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33"), "10/22" },
                    { new Guid("3edd743f-da5b-4b6e-9c99-b74beb2c7259"), "224", "7018679056629668", null, null, new Guid("a0995ae3-517f-4476-bad0-18fca309cda5"), "12/15" },
                    { new Guid("3ee9df24-e283-4cfb-9d24-82e2f6b54649"), "630", "7793543064378460", null, null, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370"), "03/15" },
                    { new Guid("3f074955-3b43-4485-a4b5-29abdb0033aa"), "946", "7706185227480105", null, null, new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457"), "12/23" },
                    { new Guid("3f1101a1-5aee-4ac1-a31a-a198f747374a"), "242", "5433289314999565", null, null, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03"), "12/23" },
                    { new Guid("3f9eb949-5c57-4f95-86d0-075fdb041fd6"), "734", "8356829132014789", null, null, new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf"), "02/26" },
                    { new Guid("3fa2f45a-5e98-450e-871f-6b06a18eb919"), "059", "7393904470519961", null, null, new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276"), "07/02" },
                    { new Guid("3fbb0c4a-b8df-4111-a70f-0fb43e31e863"), "656", "9484274085263002", null, null, new Guid("80527681-e153-441a-b963-5dad43aab962"), "09/18" },
                    { new Guid("3feef5b4-cb9f-4b59-8b24-6ab9485c9f08"), "648", "9053650893872806", null, null, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75"), "10/24" },
                    { new Guid("3ffaf7e9-6111-4acc-89e7-d8587c2c8927"), "066", "9975094147864211", null, null, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891"), "08/21" },
                    { new Guid("40d22be3-82fa-4a1e-8945-c422d4503aff"), "456", "1636516196994755", null, null, new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4"), "05/13" },
                    { new Guid("40f047e0-dccb-4bf7-ae9a-d17557f83bd5"), "922", "8195671154406248", null, null, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe"), "09/14" },
                    { new Guid("414b047e-aca7-422a-b11b-5291f15316ac"), "579", "1256960884968643", null, null, new Guid("5911b08b-117c-4079-af41-1eb1e8574741"), "01/22" },
                    { new Guid("4242f8d7-7919-47fa-97e0-88a06521cde3"), "492", "2252159807863886", null, null, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5"), "09/22" },
                    { new Guid("4256a9c1-441b-4dde-af73-0d3c1a312837"), "409", "7625525401385296", null, null, new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c"), "07/25" },
                    { new Guid("432b59c1-74ef-4fc1-8bc9-c7f0c3481d86"), "842", "3881880885989175", null, null, new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105"), "05/24" },
                    { new Guid("4357264a-d96a-4691-9ede-be5ca6a17fa3"), "085", "9418101594665546", null, null, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f"), "05/18" },
                    { new Guid("4378ee67-568a-4b28-bc24-f5fbbd3a722c"), "367", "5640076314223965", null, null, new Guid("114ac41c-5eba-4152-8f7e-622356a03762"), "11/23" },
                    { new Guid("43e6eaec-711d-46ad-aea1-95a572b69907"), "904", "9796760003325841", null, null, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891"), "09/05" },
                    { new Guid("43f0228a-29f6-496a-a4e3-502fa631651a"), "548", "6946626987371999", null, null, new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7"), "11/28" },
                    { new Guid("44258940-f052-499a-a1ff-1016e8b30907"), "489", "6965413724334665", null, null, new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3"), "06/21" },
                    { new Guid("444fd154-d5bb-445b-9d88-aa8c7a14c817"), "526", "6614704687370894", null, null, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727"), "08/06" },
                    { new Guid("451e618c-50a4-4224-819b-784aae5ca983"), "276", "2212954084324734", null, null, new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f"), "11/23" },
                    { new Guid("456db31b-91da-40ea-8196-408c03946ddf"), "883", "3073446599958128", null, null, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693"), "07/19" },
                    { new Guid("4671b8dd-5595-422d-bd1d-461a4e05fcab"), "377", "3086662859851988", null, null, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf"), "10/12" },
                    { new Guid("469f9006-1b59-4eb8-bc71-2add3eb18f6a"), "330", "6400053178117219", null, null, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca"), "12/19" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("471f4fac-f28d-4a62-aa0e-d86255e86900"), "483", "3807565220171475", null, null, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86"), "11/11" },
                    { new Guid("47262a70-31bd-41a3-b0c7-3286a84c6b66"), "875", "3891722724594388", null, null, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10"), "07/16" },
                    { new Guid("4757314a-8f1c-416a-a440-76cb356df8d6"), "261", "7698363573824084", null, null, new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7"), "04/24" },
                    { new Guid("476ab4fd-475a-412d-953c-00d95c476bcf"), "756", "5227267525630939", null, null, new Guid("5911b08b-117c-4079-af41-1eb1e8574741"), "02/10" },
                    { new Guid("47bab7e7-9c57-4649-8a31-b08daf932fdf"), "408", "1330858282596239", null, null, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd"), "01/08" },
                    { new Guid("47c4b04b-de64-492b-aac4-22a5daca86e8"), "735", "1937969969964665", null, null, new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f"), "09/16" },
                    { new Guid("47d16df1-7fc1-4618-a180-1f9065f11c77"), "700", "4117410060638622", null, null, new Guid("d2c357de-2574-4d81-996d-8fd06173f665"), "03/15" },
                    { new Guid("48328572-83db-48c9-bd78-41578ee1232b"), "526", "7893794930662462", null, null, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52"), "09/20" },
                    { new Guid("48b85ae1-5446-4e4a-9ec5-8e61bac1ac36"), "819", "9619860917843189", null, null, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86"), "12/16" },
                    { new Guid("48c4fa23-6ff3-4f81-9bfe-2d7f03fd8033"), "951", "5387238983096275", null, null, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1"), "04/06" },
                    { new Guid("49a283de-17e8-4424-baca-ec3af25b16f5"), "768", "2634637191141247", null, null, new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265"), "01/09" },
                    { new Guid("49e2607d-205a-46e1-ac44-eacc6f972e1e"), "546", "9043502864089889", null, null, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4"), "07/19" },
                    { new Guid("49e3abed-641a-477c-b1fa-c56f576fbbf4"), "449", "9082658653153916", null, null, new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd"), "03/27" },
                    { new Guid("4a055a74-45d8-48a3-b293-16658cb98347"), "875", "9899528726478778", null, null, new Guid("c73bd258-469c-4d46-ad89-cd1119310c49"), "01/08" },
                    { new Guid("4a0e3fc8-83d1-41c7-af09-d0e96091996f"), "143", "4659267221041770", null, null, new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9"), "01/23" },
                    { new Guid("4a6b883c-1921-4e30-b567-10d6641c1e57"), "771", "9433786501426484", null, null, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e"), "11/02" },
                    { new Guid("4a887a89-bef8-4813-aa2a-cde82ddf595e"), "703", "3014944607051687", null, null, new Guid("c9809439-c97d-49ed-b84a-66149d142e46"), "07/04" },
                    { new Guid("4a958b14-3ce0-4a2b-bced-d9198e2ab36a"), "489", "7278520687738951", null, null, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9"), "03/14" },
                    { new Guid("4aacd1a8-3ea9-478c-8578-1b5cebd77ea9"), "183", "9750362528984656", null, null, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9"), "03/25" },
                    { new Guid("4b4ad58b-f035-4354-b53a-15c315e00d2f"), "174", "9747259897459758", null, null, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb"), "08/08" },
                    { new Guid("4b962875-77d6-4ab4-bc2b-b2a139db899c"), "714", "2273448805725702", null, null, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40"), "05/12" },
                    { new Guid("4b9e5fc0-0785-4ad0-a398-967be611cef2"), "399", "5107856751166530", null, null, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370"), "10/22" },
                    { new Guid("4bd1663c-0e3f-40fc-9730-5c8a79716c43"), "036", "7454864203317061", null, null, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518"), "01/01" },
                    { new Guid("4be81899-7f66-431e-86d7-f6117f06afdc"), "066", "9607811833066586", null, null, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd"), "12/14" },
                    { new Guid("4c24fff0-3098-4ce2-8dda-3c090b4050b5"), "271", "9132962269962474", null, null, new Guid("4390173e-3194-44b0-9f5c-e816c829e49d"), "11/01" },
                    { new Guid("4c2c35e5-bd40-4be6-b106-9e4033179e40"), "304", "2657607443893072", null, null, new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115"), "03/02" },
                    { new Guid("4c320e8d-c3e3-45d9-b400-72c33301f29c"), "181", "3817773085200229", null, null, new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c"), "11/13" },
                    { new Guid("4d6f737b-976d-4c11-8963-f31a717cb576"), "351", "1160944078692208", null, null, new Guid("18e4d405-c797-4c9c-af33-613450990efe"), "03/19" },
                    { new Guid("4dfe8a8b-56ca-4c22-a4f5-a0c6c38bd851"), "183", "3950489421441678", null, null, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf"), "06/18" },
                    { new Guid("4e67ba19-4f04-4f76-9919-4b930c8aa00d"), "761", "3393852059265420", null, null, new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3"), "01/28" },
                    { new Guid("4e8cc72d-0394-4747-9656-834dcbfe00b5"), "229", "1611763540083819", null, null, new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed"), "03/24" },
                    { new Guid("4ea65650-7cb5-4e38-bbff-8e11f930e63d"), "876", "3170522830911450", null, null, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "05/19" },
                    { new Guid("4f08e917-eafe-4c95-8bb0-dd0289d37f93"), "003", "6368227909989344", null, null, new Guid("ec149744-9128-4f41-875a-1c96bf1c851c"), "03/26" },
                    { new Guid("4f5ea08b-5635-405c-833e-50f23b7921be"), "544", "5283929521545858", null, null, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9"), "09/07" },
                    { new Guid("4f866715-2090-4bf3-8b56-9cc933edb5e3"), "534", "6225608750395963", null, null, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b"), "02/08" },
                    { new Guid("4ff3cba5-3aa1-4a25-8c79-2cacdd2a0d48"), "560", "4650798478823064", null, null, new Guid("c187c610-03e7-4305-96e2-96f776a463e0"), "09/20" },
                    { new Guid("50a83dbd-8ba4-4271-bc28-6cf8fa07ca46"), "305", "1249088435303783", null, null, new Guid("5911b08b-117c-4079-af41-1eb1e8574741"), "10/19" },
                    { new Guid("51e19cab-1c56-4a9d-b79d-b00cb537e433"), "112", "9627991582031307", null, null, new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2"), "09/15" },
                    { new Guid("51ec28d0-b8e5-47bf-877d-e0fe1fd17acb"), "147", "3072564832640105", null, null, new Guid("963654b6-a05e-4be7-b120-45295941d954"), "07/04" },
                    { new Guid("526c48b2-dad2-4ea2-bd7d-060b0834d853"), "910", "4821810396524812", null, null, new Guid("963654b6-a05e-4be7-b120-45295941d954"), "04/03" },
                    { new Guid("52f50aad-4bf4-4623-9553-3884cfaf5798"), "505", "2568315028062593", null, null, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900"), "01/16" },
                    { new Guid("538bb366-c87c-460a-b60b-9806ad5aa0ab"), "648", "3839732497573045", null, null, new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f"), "10/27" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("53ce62b6-6d8a-4657-93cc-0a1a48168820"), "776", "1761123355106728", null, null, new Guid("82d8841b-b98c-463c-96d0-9378cf908740"), "11/27" },
                    { new Guid("53d8b7ff-7f7b-4fe4-9590-0783765442c8"), "090", "6508062321044166", null, null, new Guid("79086701-2604-4fd7-bb34-b77855e8579e"), "07/14" },
                    { new Guid("54164013-a3c7-4453-8b51-85d3b033b41f"), "642", "7794585379137151", null, null, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693"), "08/09" },
                    { new Guid("5424db19-fec4-409f-9809-e8ce70fa9aad"), "506", "7456546883472369", null, null, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b"), "03/21" },
                    { new Guid("54678b19-3569-400a-be3b-7f22e64654e5"), "128", "5816217432845375", null, null, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94"), "12/02" },
                    { new Guid("54b7a3e9-156f-4ccf-ba44-dc0ab90c554a"), "075", "7392793857889305", null, null, new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb"), "08/02" },
                    { new Guid("55030579-e86c-452a-bf8e-763c5c91ea34"), "988", "1567980839395869", null, null, new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5"), "06/18" },
                    { new Guid("551d0f0b-cdf8-44c9-b854-cd3a8ddec00d"), "524", "6634807757186353", null, null, new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee"), "04/19" },
                    { new Guid("55238a8b-1e31-4101-aa83-792c45d5c4e2"), "552", "6665011504224475", null, null, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14"), "01/11" },
                    { new Guid("56b298ca-5937-46ee-8b0e-3157165f0fd3"), "320", "2688405747877814", null, null, new Guid("b74d612a-560a-493f-9b9a-e7d76b857600"), "04/15" },
                    { new Guid("56c2649c-adcf-45d1-9372-315e9dbb2354"), "283", "6622972025763521", null, null, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f"), "07/16" },
                    { new Guid("5728cca3-6171-4c9a-9377-f751a0798155"), "882", "5319396664485209", null, null, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7"), "03/22" },
                    { new Guid("57672b85-9753-44c9-8aaa-a84fb090adbc"), "667", "8309747961324631", null, null, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86"), "05/10" },
                    { new Guid("57f3ab01-2c35-4c9a-9a78-977249680c4a"), "740", "6702561306954321", null, null, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede"), "12/08" },
                    { new Guid("5809fc85-37ab-4dcd-8b6b-724f1c69092d"), "862", "1981878170459605", null, null, new Guid("c9809439-c97d-49ed-b84a-66149d142e46"), "05/12" },
                    { new Guid("5816c27a-2154-45a1-bac1-b2f35ced9175"), "869", "9742575672029643", null, null, new Guid("c9809439-c97d-49ed-b84a-66149d142e46"), "11/10" },
                    { new Guid("58331ea1-09fd-49b0-81e3-434c2e2c4242"), "327", "7447023247159960", null, null, new Guid("a8eb141c-5178-4baa-b599-679287b17c92"), "07/13" },
                    { new Guid("5837ae7c-848b-495c-ac0d-5885f5a280b4"), "360", "1425515946970669", null, null, new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443"), "08/02" },
                    { new Guid("587a0c08-7fc3-4ca2-a2ae-a54ce88b19a9"), "156", "7483048809046620", null, null, new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd"), "10/23" },
                    { new Guid("58b749bc-5625-419c-8f4f-c853ca7e2f73"), "044", "5574369457989824", null, null, new Guid("f198b380-c53a-437b-904d-29b9d522aac3"), "05/18" },
                    { new Guid("5a1734ec-3df7-4ad3-81c6-dbce0d8db445"), "440", "9979028653866257", null, null, new Guid("a42b469c-fec8-4056-a4de-926b01b7f202"), "10/09" },
                    { new Guid("5a4ad475-24a2-4594-b1c5-e9857bccb3f3"), "580", "4318129132126361", null, null, new Guid("18e4d405-c797-4c9c-af33-613450990efe"), "10/26" },
                    { new Guid("5a953c4a-1047-4ed7-92eb-876a20d6d732"), "278", "9404418345985625", null, null, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9"), "08/13" },
                    { new Guid("5c3fdeec-d53a-4b16-bfff-374a4ee76f28"), "378", "4604420801998015", null, null, new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2"), "10/26" },
                    { new Guid("5c997f2a-c7f8-438b-b41b-c7922535ec36"), "560", "4739351531051541", null, null, new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794"), "12/07" },
                    { new Guid("5ca0e912-7701-4825-a0cf-286196188763"), "677", "1492158238633479", null, null, new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6"), "01/04" },
                    { new Guid("5d0a0034-bda4-4a61-8c2c-46dc69ce3d16"), "186", "8738095192467197", null, null, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321"), "02/25" },
                    { new Guid("5d493149-a581-45b0-b4b8-10c063f6a17b"), "323", "7856217238787501", null, null, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4"), "02/19" },
                    { new Guid("5d4e4c14-3731-4c54-ad37-f6d0f1167fe9"), "956", "6551991795924760", null, null, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20"), "01/11" },
                    { new Guid("5da3a0d5-1747-4bb4-aa14-797ea62f02e1"), "959", "7898319479471927", null, null, new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a"), "01/23" },
                    { new Guid("5dccc640-8022-47a7-bd90-85f74011eb62"), "107", "8709132784615136", null, null, new Guid("79086701-2604-4fd7-bb34-b77855e8579e"), "01/07" },
                    { new Guid("5e70d626-61ce-4c35-bd18-d4f73d54b69e"), "822", "1330744571854444", null, null, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae"), "06/03" },
                    { new Guid("5eb37f69-c8b4-4a50-b53e-abb416102571"), "300", "5667211222391973", null, null, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03"), "12/21" },
                    { new Guid("5f33ef09-406d-4eab-8272-3d1828937fb8"), "821", "5807074179887400", null, null, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de"), "09/15" },
                    { new Guid("5f4021a6-a481-4ed5-b8b1-499992c1cf65"), "877", "8699548712439843", null, null, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370"), "03/01" },
                    { new Guid("5f5480f9-d65b-43bc-bdfa-433b8d91051c"), "727", "4567541261140488", null, null, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb"), "06/27" },
                    { new Guid("5f9bb948-b075-450c-bf2a-b200e6668d10"), "621", "7517685747010930", null, null, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0"), "04/04" },
                    { new Guid("6005097f-5460-411f-90ac-3a0653a9637a"), "568", "8711498379983585", null, null, new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115"), "05/04" },
                    { new Guid("603ddcbe-680b-436b-9cd4-07657ac26db8"), "312", "8869940700147700", null, null, new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968"), "06/12" },
                    { new Guid("604a1c2e-98ef-4e5e-9a95-8cac7009c84c"), "848", "5270454830585452", null, null, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae"), "12/19" },
                    { new Guid("60c7a5ec-acb4-4ee0-a14f-2d7802cc0fb5"), "351", "4140389476595778", null, null, new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361"), "06/16" },
                    { new Guid("6156635b-eee3-4b44-b09b-1699fbf99596"), "861", "3044785545527309", null, null, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae"), "01/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("61f82982-23b2-4d3e-a68e-8fd18ce32e1e"), "157", "6460444888626711", null, null, new Guid("680c6306-048b-493d-8369-356efb0cafae"), "03/17" },
                    { new Guid("61fd9196-534f-4922-9027-e12d8f648eef"), "552", "9645135125205227", null, null, new Guid("558db05b-0b8d-442b-8166-524709ea133f"), "09/17" },
                    { new Guid("621657df-4b18-43b9-9185-31e85359b90a"), "878", "2943734423233238", null, null, new Guid("431cb355-ae94-49cc-882c-971e60381b53"), "04/17" },
                    { new Guid("625d221b-408e-43cb-8579-326baae626fb"), "667", "6361671032576404", null, null, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94"), "09/27" },
                    { new Guid("6285e7a7-8e0f-4536-9ebd-ef80cb0905a4"), "189", "4390060380784330", null, null, new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58"), "04/26" },
                    { new Guid("62d61586-f492-4f99-827c-bc10740dae21"), "337", "8382971731710054", null, null, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20"), "02/03" },
                    { new Guid("62dfad09-05fe-4d48-8bd5-60bd508727c6"), "453", "4479790075021429", null, null, new Guid("4285821d-9d8f-4943-b663-27adc015a9c4"), "08/09" },
                    { new Guid("632f6f67-a71c-421c-bc61-396a5926fa2f"), "522", "1643829442806416", null, null, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7"), "05/25" },
                    { new Guid("634a0db2-7451-476a-b9af-a8903e59d339"), "387", "9814213682717761", null, null, new Guid("e8293c7e-c598-445f-a509-d9123149ec52"), "04/17" },
                    { new Guid("64ffb9ed-b134-4fe4-9910-b289dbc5c877"), "102", "1726256440590643", null, null, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b"), "09/24" },
                    { new Guid("6535cd32-ead5-4450-bcd9-d1c50d92a771"), "537", "3841427656472517", null, null, new Guid("1ca2e699-11df-445a-8084-51598bee7020"), "06/28" },
                    { new Guid("66474307-f61b-464c-8153-58a8c469640b"), "645", "9118915650052153", null, null, new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2"), "09/22" },
                    { new Guid("666c62bf-c787-46b9-b5ae-d1cc5ccbc52d"), "398", "9618024652365867", null, null, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1"), "02/26" },
                    { new Guid("6689b516-d70e-47dc-8324-561578b5c106"), "282", "2194503278206435", null, null, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807"), "06/27" },
                    { new Guid("669890cc-7abd-4f6b-bcdb-29250f955b55"), "013", "5366535767272330", null, null, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8"), "06/01" },
                    { new Guid("674e6aaf-975f-4ed5-9fa3-67aff154d14d"), "611", "5735707203758012", null, null, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216"), "12/08" },
                    { new Guid("676cdfb6-b048-464a-a7dc-156644823fd0"), "705", "9293896324274171", null, null, new Guid("58526312-a56b-4b29-b8d3-e131efce8cef"), "07/13" },
                    { new Guid("67a74682-e29b-46db-9181-fa1dad45705f"), "009", "4731142519918441", null, null, new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce"), "04/27" },
                    { new Guid("67b2038b-c86c-4a87-9c76-3e0ae6b5ceb2"), "382", "7692164109124765", null, null, new Guid("b552dea4-6df2-477a-870b-1317247a51c0"), "08/26" },
                    { new Guid("67cb809d-6ad2-4095-a86a-c8bc61c3a817"), "871", "4855410907372352", null, null, new Guid("b552dea4-6df2-477a-870b-1317247a51c0"), "07/10" },
                    { new Guid("680d48ad-ce23-4e28-a2c8-e44186a939b2"), "085", "1410131259071209", null, null, new Guid("80527681-e153-441a-b963-5dad43aab962"), "09/19" },
                    { new Guid("6842968c-47a6-46a9-bfa9-2cd331f97cb9"), "567", "4186520581231503", null, null, new Guid("67421d1e-5702-485e-b8e7-42fccca07695"), "08/14" },
                    { new Guid("68bcc932-200b-4b39-827f-7885280cd48d"), "808", "7228906776968403", null, null, new Guid("558db05b-0b8d-442b-8166-524709ea133f"), "03/11" },
                    { new Guid("6a3c8ef8-3ada-420f-a889-382dd7e30b2b"), "625", "5928574938259068", null, null, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b"), "03/14" },
                    { new Guid("6a4e65ff-f8af-42b5-91a4-e0b293ea382d"), "864", "7199544768169461", null, null, new Guid("85178881-d883-4586-bf89-10a49abb8b16"), "09/09" },
                    { new Guid("6a6059b8-795e-4a9e-af95-42da035cd4d2"), "983", "5910370205092430", null, null, new Guid("67421d1e-5702-485e-b8e7-42fccca07695"), "03/09" },
                    { new Guid("6aba4b01-4abf-4f08-9d9c-81aa86b9ccc0"), "534", "8988304629641512", null, null, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb"), "02/22" },
                    { new Guid("6ae11bc1-2478-472b-87e0-5fa42bd68f95"), "059", "4708845857213181", null, null, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c"), "04/21" },
                    { new Guid("6b182dde-1b5a-4f41-bbd0-1515c2b4e243"), "330", "9300237188600470", null, null, new Guid("4860b124-2e67-49cc-b664-135729261ac4"), "10/17" },
                    { new Guid("6b7a949a-f958-4aae-bb9f-4102df9dbf58"), "826", "8603983408354565", null, null, new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259"), "05/15" },
                    { new Guid("6ba085c4-25b8-42b2-bc91-f85a92a34e47"), "540", "8127762111610824", null, null, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b"), "10/21" },
                    { new Guid("6bb369d2-56a4-4bd5-a204-4ade9efb655b"), "891", "1867251078297687", null, null, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc"), "10/13" },
                    { new Guid("6bf86e3b-1579-4155-b567-0c1e74bbe85f"), "687", "5833112913990284", null, null, new Guid("316bd6de-f98f-4240-856b-7b943204b4fb"), "01/24" },
                    { new Guid("6c033b48-0393-498c-9afe-1b382619256b"), "748", "4736366665820118", null, null, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7"), "08/10" },
                    { new Guid("6c461d02-fdfa-4cd2-b911-6bfb806c2faa"), "934", "8055951492828250", null, null, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca"), "03/13" },
                    { new Guid("6c998a7e-3eda-43d5-a8ff-f3b0d23f5612"), "501", "4103132377037454", null, null, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7"), "08/28" },
                    { new Guid("6cbd5ccc-28e7-41d1-98eb-c207db7c6d64"), "550", "3593099972250716", null, null, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0"), "02/15" },
                    { new Guid("6ceb102e-9833-4857-a3df-8ff48b22aece"), "513", "7986722769855921", null, null, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c"), "11/01" },
                    { new Guid("6cf6d5f8-09a4-433d-b6ad-520debb58292"), "410", "7863595717241907", null, null, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c"), "06/12" },
                    { new Guid("6d655f22-433a-481a-afcd-7b21d70c11d0"), "824", "8848040229327664", null, null, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9"), "11/08" },
                    { new Guid("6d8cf949-0fc9-48d8-8aa1-24530ef1f60b"), "002", "7211807811121300", null, null, new Guid("82d8841b-b98c-463c-96d0-9378cf908740"), "01/24" },
                    { new Guid("6dfda76b-62b8-4580-adaa-933dd1642b56"), "661", "5177627105753539", null, null, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35"), "02/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("6e6343b4-a0d7-421f-9f00-cf90d56a2dab"), "085", "2131781135545942", null, null, new Guid("c32606de-b224-4989-bf52-f8b3cabea595"), "01/03" },
                    { new Guid("6ea382a3-3c6c-45f7-ab8d-0191826bbce6"), "574", "6626567795257607", null, null, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b"), "05/20" },
                    { new Guid("6ea880fa-ca24-44ca-a547-b58f1e75fa1f"), "194", "3589587752210067", null, null, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), "11/11" },
                    { new Guid("6f305b80-0934-4a17-a5e2-45575e8e744d"), "870", "4366919936005620", null, null, new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3"), "03/11" },
                    { new Guid("6f6d05f8-084b-415c-b739-d500f8b3660d"), "909", "6180780361263692", null, null, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75"), "03/01" },
                    { new Guid("6fd2f001-829f-4af6-9236-0afe6b4f9330"), "781", "4180145362839854", null, null, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb"), "03/14" },
                    { new Guid("6fe5ffa7-b8b5-449f-8b1b-aae3702dd105"), "897", "9708634520092363", null, null, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede"), "01/20" },
                    { new Guid("70afbdd8-d996-4037-bfd5-e5fcee5037a2"), "744", "4949924309362351", null, null, new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781"), "06/06" },
                    { new Guid("70ee8a94-2943-4707-9931-4cb288c1334a"), "405", "2566924202359931", null, null, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc"), "02/06" },
                    { new Guid("710cdf21-b5c5-4293-b3c0-f393c5041613"), "894", "3170066280909829", null, null, new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588"), "12/21" },
                    { new Guid("713359de-a7c7-4479-9db6-a1788d1bbc57"), "734", "3404627879529691", null, null, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94"), "02/17" },
                    { new Guid("71a4b747-91ff-4b9d-944e-d8d389f2c9d0"), "948", "8628592819382295", null, null, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de"), "08/17" },
                    { new Guid("71d4af8e-1817-49a3-9c15-46819ac15a88"), "703", "7387697975066419", null, null, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807"), "02/24" },
                    { new Guid("7262ba8e-1258-4d5b-bb4a-4c27225fa234"), "612", "6523179649954179", null, null, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8"), "12/28" },
                    { new Guid("73121bac-774b-4d47-aa42-a3ba440c2095"), "830", "1365409695687865", null, null, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), "06/20" },
                    { new Guid("73238a09-c423-41f4-9d82-ab35a74c9823"), "835", "3565494397468101", null, null, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179"), "05/04" },
                    { new Guid("734d93f7-09d4-4f27-99f9-68c24a42443a"), "911", "9871757898872470", null, null, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807"), "07/16" },
                    { new Guid("7390590d-3a10-46b4-bfc3-a319433a45ff"), "407", "6297166736898983", null, null, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19"), "07/19" },
                    { new Guid("7391beaf-0072-45a1-8fdf-adfbb4106f45"), "105", "4941970664648126", null, null, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e"), "01/14" },
                    { new Guid("7431ebe0-ab3f-42ce-83e5-ec19196d6b6c"), "177", "4557441982014230", null, null, new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215"), "08/26" },
                    { new Guid("7445e759-38ed-456f-87ba-7c2a7c36ce8d"), "923", "9461362827803433", null, null, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0"), "01/06" },
                    { new Guid("748d3d30-23f5-421a-a9bf-32aa36a27d17"), "187", "7784075319389144", null, null, new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9"), "07/18" },
                    { new Guid("74989dd6-314c-4423-82d7-e67df70941b8"), "697", "5723514563660491", null, null, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4"), "06/19" },
                    { new Guid("74dfecc1-e77a-49f3-9f2e-3097b96e4250"), "315", "3059076828329150", null, null, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25"), "12/05" },
                    { new Guid("75b99c48-e3f6-4ed2-8127-74d85ae7736e"), "736", "3953557813196690", null, null, new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf"), "01/12" },
                    { new Guid("75f895e1-3a5b-44ed-8d84-c9199085c763"), "255", "2379245281729694", null, null, new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58"), "07/25" },
                    { new Guid("7615ee34-c034-441d-9b3b-4db2329f7227"), "421", "8555686981081900", null, null, new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab"), "10/28" },
                    { new Guid("7644c653-9171-4e63-8dfe-91350c839156"), "164", "4265112996377032", null, null, new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed"), "09/21" },
                    { new Guid("7646b96f-9d61-4576-8c76-8d096433ef2b"), "445", "8797089380738745", null, null, new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02"), "02/07" },
                    { new Guid("766c6dc2-2ab7-4747-937c-28a4a42cab54"), "327", "5244044570868364", null, null, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78"), "03/03" },
                    { new Guid("76f4de7d-e32c-4b4f-9389-b474a249dcb3"), "537", "6398996279730203", null, null, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae"), "12/16" },
                    { new Guid("77421da0-fa2b-45f7-b8f2-ced96408d2dd"), "874", "8507434963387836", null, null, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1"), "03/20" },
                    { new Guid("7754a11f-f876-45a5-90e8-aafc59e53c50"), "728", "3348188518922738", null, null, new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1"), "03/24" },
                    { new Guid("778ba464-43d5-4f8c-a67b-627b23b4233a"), "058", "6673383945919124", null, null, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271"), "02/13" },
                    { new Guid("77bb56fd-0718-41a3-b632-a82b3b36e3c8"), "735", "9902162586536999", null, null, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f"), "05/13" },
                    { new Guid("77d76887-b153-46d9-b160-cd4365a35247"), "586", "9034024198028234", null, null, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e"), "09/25" },
                    { new Guid("78300591-566c-4559-a7c9-a525f5e15cd1"), "411", "2306610796951488", null, null, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7"), "04/19" },
                    { new Guid("784f9ba6-c4b0-4ead-8d95-e2238c35112d"), "315", "6361581298757324", null, null, new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190"), "02/26" },
                    { new Guid("786aaf01-5a52-4bab-87a2-7ecdc94fba96"), "832", "6736834065488520", null, null, new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0"), "01/13" },
                    { new Guid("78799f12-df5e-4241-818c-c60121f415d3"), "812", "6332023118817788", null, null, new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6"), "05/04" },
                    { new Guid("78ff41fb-f935-4dcc-99b3-e384e070b9df"), "879", "7951064984351931", null, null, new Guid("80527681-e153-441a-b963-5dad43aab962"), "05/12" },
                    { new Guid("79099df8-38be-4eb2-b0d9-53e30983e258"), "809", "7563506543648427", null, null, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28"), "09/19" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("7955250a-cacf-49ff-bae3-d6194b497500"), "362", "8299866292188432", null, null, new Guid("963654b6-a05e-4be7-b120-45295941d954"), "11/12" },
                    { new Guid("797fc348-322f-4d90-9f31-3e6c837474c4"), "694", "3412598235216155", null, null, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb"), "08/24" },
                    { new Guid("7a1bbc30-28cc-41c4-bd77-5d507117dfca"), "457", "1945218682601463", null, null, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28"), "03/25" },
                    { new Guid("7a3a53f0-8568-46e6-8542-6323e9b7cd0a"), "894", "4360986459496150", null, null, new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee"), "08/08" },
                    { new Guid("7a5228da-fe5d-4e35-b184-ef2eebce8d4e"), "199", "7606943154442836", null, null, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de"), "11/21" },
                    { new Guid("7b8ef001-eed2-48ec-892c-d3fff6c46e54"), "346", "4474121864939853", null, null, new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc"), "06/22" },
                    { new Guid("7ba87340-99c4-4a40-994c-f896a676a640"), "617", "7728705880922048", null, null, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94"), "02/23" },
                    { new Guid("7ba966e1-9061-40a1-a896-5acfbb0657a4"), "279", "8068272086767723", null, null, new Guid("c41a987e-114e-4968-aa63-744e27096322"), "02/22" },
                    { new Guid("7d042721-8b0a-401c-8b58-d557da3bb447"), "638", "9457312291830725", null, null, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b"), "10/12" },
                    { new Guid("7dac8a97-4593-40af-ad00-f5b94cbaddb9"), "093", "4204894536295536", null, null, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0"), "04/15" },
                    { new Guid("7db0615a-cb17-4d4e-9357-63f12478727e"), "454", "1267081853268250", null, null, new Guid("60f7f230-ff82-425a-a6c5-cc5156098000"), "12/02" },
                    { new Guid("7dfee920-ffc4-4854-8396-04847ac63608"), "074", "9492149944280207", null, null, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab"), "06/10" },
                    { new Guid("7e063b81-6521-4f5d-a1b3-d1c7c9e0dbad"), "330", "8807660182570481", null, null, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52"), "02/06" },
                    { new Guid("7e312ec1-f72e-42dd-b63b-09c72de4e012"), "153", "4619364270593453", null, null, new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2"), "07/16" },
                    { new Guid("7f06e1d9-3633-4f62-b381-b3a1cdeb8c8f"), "981", "6838298086263532", null, null, new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036"), "07/23" },
                    { new Guid("7f2c2945-cceb-41f5-a7df-efdb375b0f44"), "064", "9286044807327663", null, null, new Guid("2da9ab08-6750-4a36-8423-df883774a78a"), "01/14" },
                    { new Guid("7f90613f-68fa-4604-94ad-0a1bdfaf0a61"), "949", "4746732304682687", null, null, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa"), "06/14" },
                    { new Guid("7ff0b31a-8f81-4a46-b9a7-438db2493207"), "524", "2429328120430070", null, null, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf"), "04/01" },
                    { new Guid("8058610c-7ad7-4f18-a841-73634160fb5c"), "378", "8280480976813935", null, null, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b"), "10/21" },
                    { new Guid("8087ef6b-371f-4265-ab75-ea7becd23810"), "561", "5251610104701208", null, null, new Guid("87884942-9d13-450f-b485-62321f667eab"), "12/06" },
                    { new Guid("808b3ef2-f4af-41e9-baa7-bb2a4fdc66d5"), "075", "4440654609618786", null, null, new Guid("8576464a-f366-4076-97bd-00c2481b9a38"), "11/19" },
                    { new Guid("81a23724-2732-474c-9c14-5c0e314cf73a"), "362", "7428479251345166", null, null, new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4"), "03/19" },
                    { new Guid("81c3fab1-a57c-4cfa-b457-340713f2e6da"), "792", "7221988500934006", null, null, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9"), "07/25" },
                    { new Guid("81d9d198-e941-4967-ad39-64c0395129dd"), "966", "8708790691592213", null, null, new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50"), "12/26" },
                    { new Guid("821a2d11-97a3-4db0-bd49-a65959a03cf7"), "397", "9709486155783123", null, null, new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b"), "02/02" },
                    { new Guid("821a4a41-49f6-4a33-ae77-9fcb74b71c63"), "193", "1561902484014847", null, null, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807"), "03/12" },
                    { new Guid("82aba056-3d7b-4cc8-aea6-907bfb60dd1a"), "081", "9086169529743348", null, null, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7"), "12/24" },
                    { new Guid("830e8327-e844-431c-96f0-1316ff44a400"), "392", "9350991998140636", null, null, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9"), "12/25" },
                    { new Guid("833a7abb-82f1-47c3-a55f-f13f933eed3e"), "450", "2472201536382962", null, null, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d"), "05/18" },
                    { new Guid("834b7d39-bc49-4953-9828-bb33a843af31"), "671", "3530710918417752", null, null, new Guid("67421d1e-5702-485e-b8e7-42fccca07695"), "10/27" },
                    { new Guid("83b4c3d1-7380-4655-aa6a-1862d3f91c2e"), "357", "2851621027845228", null, null, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75"), "02/02" },
                    { new Guid("85595cb1-494a-4f69-90b0-d6237257a378"), "427", "2020028518182126", null, null, new Guid("a8eb141c-5178-4baa-b599-679287b17c92"), "02/10" },
                    { new Guid("85ac7f06-cb9e-4e00-b2b6-dbb863f05837"), "247", "6248724920779739", null, null, new Guid("bea80970-74bf-4539-a300-cbbac8625744"), "01/09" },
                    { new Guid("85b4d6a8-0cd2-4d53-8826-1423f151a9a1"), "738", "2066066423228521", null, null, new Guid("e881572a-cd4a-4d95-bf26-6855a9394560"), "04/03" },
                    { new Guid("85c93efa-9973-429e-baad-f26be63448b7"), "139", "5178507920460573", null, null, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f"), "01/07" },
                    { new Guid("863638b8-f947-46ea-b057-ebccf17142a0"), "485", "7783494001331579", null, null, new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781"), "04/04" },
                    { new Guid("864c639b-8ad0-459b-88f9-3cf1c02e73fb"), "696", "4453900303644580", null, null, new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6"), "05/12" },
                    { new Guid("86741dd4-76db-42ca-8117-b7c3090e6d41"), "861", "2099629995563118", null, null, new Guid("05fb67eb-3b60-4c93-bf80-36153be08871"), "11/15" },
                    { new Guid("86adc509-b787-423f-91ed-737fda3e5981"), "634", "3164033345788460", null, null, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25"), "03/17" },
                    { new Guid("86bc4f79-581f-4fd9-a92a-9496d756b1db"), "969", "7025787727172827", null, null, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2"), "06/07" },
                    { new Guid("86d1eab6-3b43-400f-938d-654fc5c07c5f"), "880", "4424578624007094", null, null, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5"), "08/01" },
                    { new Guid("872e15f4-abcf-4c49-95b6-8579d5407c29"), "759", "2817311952898498", null, null, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd"), "09/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8798bb2f-e385-4b5b-9155-3953f01e4c2f"), "641", "1209378225780324", null, null, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c"), "07/22" },
                    { new Guid("885efe01-4d0b-4ae3-95e7-e7dbd93aa88b"), "496", "5550608221597387", null, null, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481"), "02/10" },
                    { new Guid("88a3fc43-5034-42f8-b867-feb83f70e08a"), "792", "4972981992224666", null, null, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db"), "05/21" },
                    { new Guid("899a4615-07cb-411b-b384-57f10a7862e8"), "087", "5654529534629006", null, null, new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4"), "02/03" },
                    { new Guid("8a2718ee-e36b-4002-bc44-ad69c7ebdb17"), "181", "5038722833190206", null, null, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8"), "07/14" },
                    { new Guid("8a5838fa-ffbc-4661-b9ac-ac4917c89eec"), "439", "1723980369901364", null, null, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285"), "04/05" },
                    { new Guid("8aaaa352-f3fc-4a9b-9916-efbd609d45b4"), "072", "1042352929094536", null, null, new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841"), "03/19" },
                    { new Guid("8af084f9-8deb-4254-9fa3-eed2ca98f8c3"), "033", "6788867084847288", null, null, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6"), "05/07" },
                    { new Guid("8b4c4f8b-c0d7-44dc-9c9d-c0882c6d9bca"), "607", "7558106893285011", null, null, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8"), "11/27" },
                    { new Guid("8b8cfacc-92ac-4585-a0e8-52918bc1b2b8"), "288", "5997880772453113", null, null, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c"), "04/21" },
                    { new Guid("8bbd17ba-4b0a-473a-abf0-80f7a7b72a3d"), "964", "9731027077153350", null, null, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "01/14" },
                    { new Guid("8c391c43-b1b4-4c66-ad6d-79b2c689aed2"), "257", "9718820690286211", null, null, new Guid("a0995ae3-517f-4476-bad0-18fca309cda5"), "09/07" },
                    { new Guid("8cdaf3c7-330e-42a6-adda-ce740aab4980"), "198", "2256031738596902", null, null, new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35"), "11/20" },
                    { new Guid("8cded323-3b21-49da-aa89-6a0bc1565287"), "806", "8058874799705085", null, null, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc"), "01/26" },
                    { new Guid("8ce01392-5a80-4dcd-bb23-344f51f4a113"), "704", "8518850200502216", null, null, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1"), "08/07" },
                    { new Guid("8d6b1334-a590-4c3b-8bd6-ed743c0e0a04"), "612", "3984809935589039", null, null, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179"), "09/24" },
                    { new Guid("8dd8fbe1-f808-4c7f-b8fa-6891713d7532"), "048", "6829860143483331", null, null, new Guid("c73bd258-469c-4d46-ad89-cd1119310c49"), "12/16" },
                    { new Guid("8ddfd0f4-e207-491c-8c7f-f1484e5b7983"), "782", "5665800717660262", null, null, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16"), "10/04" },
                    { new Guid("8e82fdd5-5e8c-4c57-ac3e-69a1224cac5d"), "614", "4948577165063383", null, null, new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0"), "06/07" },
                    { new Guid("8f36f457-0cbf-46b7-a910-d2bc2d9f02c0"), "123", "8358079594134117", null, null, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179"), "11/16" },
                    { new Guid("8f82f846-7f6d-4157-b090-5d0a3a6ba175"), "663", "6272102782183285", null, null, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0"), "04/06" },
                    { new Guid("8ff67022-3ec7-4a21-b298-47e0c784f15f"), "060", "4665772168250854", null, null, new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276"), "12/17" },
                    { new Guid("903456c6-7bc5-433d-842b-b8a39a8195ea"), "452", "8970399538031285", null, null, new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5"), "02/20" },
                    { new Guid("9048c7c8-a66d-4831-bd89-49868f09eaca"), "039", "3453032650512328", null, null, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955"), "06/07" },
                    { new Guid("90b91666-53c9-4fb3-89e7-8c0677170742"), "320", "3060219728000934", null, null, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321"), "11/24" },
                    { new Guid("911d60b7-0704-430e-afb0-55ff8ea8e7f3"), "535", "9883203323001318", null, null, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19"), "02/07" },
                    { new Guid("91401bf9-8718-4708-b538-e353fa8b6d5b"), "418", "2817484388894104", null, null, new Guid("e8293c7e-c598-445f-a509-d9123149ec52"), "12/08" },
                    { new Guid("917b1664-db7a-4ac6-889a-f6966dd0fb60"), "430", "8006459556020058", null, null, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0"), "08/15" },
                    { new Guid("91da7a9f-130c-4c25-a387-f550630a750d"), "565", "7347124453535309", null, null, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6"), "09/06" },
                    { new Guid("91eb77d8-732c-40a4-82ec-4fb386e3e5c5"), "509", "2138677211615489", null, null, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b"), "07/13" },
                    { new Guid("922c940c-3de1-4db8-8c1e-e8a80343d37c"), "694", "4181257963291197", null, null, new Guid("c187c610-03e7-4305-96e2-96f776a463e0"), "03/12" },
                    { new Guid("92603465-2ceb-4e50-b136-dbe342abb9dc"), "268", "3867275858022129", null, null, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25"), "04/12" },
                    { new Guid("92c23c6d-4370-4c2d-a665-ef6141f45646"), "593", "6306051440113144", null, null, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25"), "05/25" },
                    { new Guid("93863747-17bb-414f-b91e-19dfe909deeb"), "520", "9165952288295709", null, null, new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457"), "09/16" },
                    { new Guid("938cd606-8dd6-4056-baee-a0ac63a666b5"), "723", "2540359868427687", null, null, new Guid("680c6306-048b-493d-8369-356efb0cafae"), "11/13" },
                    { new Guid("93a36422-4484-4853-a648-cb361657fc9c"), "761", "1883545714970005", null, null, new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc"), "03/01" },
                    { new Guid("93a5ee49-f2c0-486b-abcf-586aa3380356"), "519", "5265149242100503", null, null, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14"), "08/17" },
                    { new Guid("93cd63c7-ec8b-4854-9251-396e5aa752e1"), "829", "1159756809866008", null, null, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40"), "04/27" },
                    { new Guid("93fa2fa1-887d-49fe-a0f3-936cc57065e7"), "217", "3624167711605944", null, null, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb"), "06/26" },
                    { new Guid("941cf6bc-9fb8-447e-bc48-2a5760e08db4"), "524", "2232330681156907", null, null, new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9"), "07/04" },
                    { new Guid("942b11f1-a57b-4005-b623-8ba3bdbf1a0c"), "819", "4557038077575427", null, null, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5"), "08/04" },
                    { new Guid("94a5c267-8da8-4057-b092-d575c0e8d3c5"), "455", "8508561982488348", null, null, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727"), "04/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("94ffe04d-7c68-4ba1-97b6-276a2e1dc2b3"), "861", "8904329855686177", null, null, new Guid("1ca2e699-11df-445a-8084-51598bee7020"), "07/07" },
                    { new Guid("95044292-57ab-4289-ae0d-667df2a2333e"), "871", "8410504586971115", null, null, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b"), "09/28" },
                    { new Guid("952e3cd4-2c61-4e9a-a967-689f44620f2a"), "365", "3360717377196364", null, null, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518"), "10/24" },
                    { new Guid("953b3f3e-bb0b-43ef-b67e-7dff35f92550"), "722", "8029890262618264", null, null, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8"), "11/03" },
                    { new Guid("955b752b-206e-4caf-9591-fe3783615ebb"), "987", "7681890504675639", null, null, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f"), "02/26" },
                    { new Guid("958d8fe0-d310-4135-82f3-1468a3a5a861"), "874", "7432554490652332", null, null, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25"), "10/26" },
                    { new Guid("963804dc-f23b-4032-8ce8-18ec92681f66"), "256", "9521085780665996", null, null, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), "04/17" },
                    { new Guid("9669b809-8e5f-4e65-b6ea-177cb743afcb"), "807", "2538535291103747", null, null, new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547"), "06/21" },
                    { new Guid("96a7729a-2991-481a-a1db-31005caa56a0"), "794", "7810792923012298", null, null, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede"), "01/01" },
                    { new Guid("96c9854c-04f7-4f0d-8e6c-41b4841cfb9a"), "505", "1331239908718769", null, null, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19"), "09/27" },
                    { new Guid("96df863d-c250-4dcf-b54e-cd3abc90a39b"), "319", "6701237234188128", null, null, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0"), "10/15" },
                    { new Guid("96eb3122-6fc5-4ba7-ad9f-43fb77eedd70"), "937", "2462002802458925", null, null, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0"), "09/14" },
                    { new Guid("96f41d36-5fa4-4202-94cf-51ed78008b4a"), "485", "1195781400632551", null, null, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900"), "01/26" },
                    { new Guid("9749d02f-c4db-4151-a92e-7c632cc540a2"), "420", "2352610944276518", null, null, new Guid("da175a26-80f5-4704-9c96-da3480a7797b"), "08/16" },
                    { new Guid("9795a2fa-f510-48af-8416-929d507e728c"), "362", "4339312056201963", null, null, new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549"), "11/10" },
                    { new Guid("97ddc1fc-4b5e-4cd9-9b2c-3b46a2d77b53"), "756", "6799379796397151", null, null, new Guid("67421d1e-5702-485e-b8e7-42fccca07695"), "12/17" },
                    { new Guid("986f89c1-b7ae-4f5f-89cf-31bb3c1be41b"), "793", "7242174756728247", null, null, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab"), "08/17" },
                    { new Guid("988ae174-a1ac-473e-b9a6-6449a1763852"), "952", "6029905992569452", null, null, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948"), "05/03" },
                    { new Guid("989e10e3-2b48-46ec-95d2-3df1b7afb42e"), "991", "3896033880936556", null, null, new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117"), "05/14" },
                    { new Guid("9933db73-57d1-4b77-ac3a-bcd74ed89268"), "052", "8906334557307808", null, null, new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190"), "09/19" },
                    { new Guid("9936d7af-31e6-429e-bfc4-d9e910ce57cf"), "688", "7435496344268955", null, null, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2"), "09/28" },
                    { new Guid("997530d2-0693-488d-9052-234184b9298a"), "565", "8905844434119100", null, null, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe"), "06/07" },
                    { new Guid("998ab1a8-44ad-4577-8af6-d3bc1dcde0f7"), "942", "9008922809246539", null, null, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20"), "01/19" },
                    { new Guid("99930df9-6dc3-433a-b4ae-67693c3bf600"), "936", "4514362295056753", null, null, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb"), "03/07" },
                    { new Guid("99cf6012-5370-41a2-9ff9-dd48ea6fb1ad"), "765", "3581966575099269", null, null, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481"), "09/15" },
                    { new Guid("9a313e45-dc08-40c8-ae05-b6f30c04fac4"), "093", "5312159671760473", null, null, new Guid("4285821d-9d8f-4943-b663-27adc015a9c4"), "05/18" },
                    { new Guid("9ad5a94a-9dd9-4148-8059-8c409f95f513"), "295", "6026459758634192", null, null, new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad"), "06/02" },
                    { new Guid("9aed5fe7-2358-40de-a9bf-1f50bc04abae"), "045", "1037163828797482", null, null, new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443"), "01/28" },
                    { new Guid("9b37525c-67fa-4740-bd41-30c50097a116"), "362", "7246465060467044", null, null, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3"), "11/17" },
                    { new Guid("9b911f98-0257-4c92-8932-f1b738e3da93"), "164", "6137756652792155", null, null, new Guid("ec149744-9128-4f41-875a-1c96bf1c851c"), "08/07" },
                    { new Guid("9c011395-abed-4880-94fc-c1d45980ed62"), "937", "5396910123827204", null, null, new Guid("f198b380-c53a-437b-904d-29b9d522aac3"), "08/20" },
                    { new Guid("9cb4030a-80f9-4c7a-99a3-193a5dac3d08"), "740", "4369646662297326", null, null, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2"), "11/11" },
                    { new Guid("9ceae277-9eef-4841-aae6-cacf387eb351"), "839", "6258135723218718", null, null, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7"), "11/10" },
                    { new Guid("9d048864-75dd-4528-8e3a-5916ad8a01f5"), "960", "7681394637666556", null, null, new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd"), "09/14" },
                    { new Guid("9d340ad2-0e63-4f98-aa6c-317f6fc634e8"), "801", "1266210150880720", null, null, new Guid("01a8bd37-aff4-4aac-8218-b782c941985f"), "10/27" },
                    { new Guid("9d3cf0f5-7c2e-4194-b8c1-0bf658c3f341"), "933", "9182243588557298", null, null, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597"), "07/16" },
                    { new Guid("9d65dffa-7867-4904-aa67-3d357d463b00"), "329", "4965162732640332", null, null, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16"), "09/03" },
                    { new Guid("9d8049e5-b9d4-4f88-b9eb-1a7082df3dc6"), "219", "8292540521524903", null, null, new Guid("a8115124-4280-4a52-8af7-cb635f456958"), "06/14" },
                    { new Guid("9dd5514c-353d-41fa-9209-26e84d725770"), "787", "9252645831733635", null, null, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5"), "01/11" },
                    { new Guid("9e143168-3232-4600-bf18-f808a78618a5"), "446", "9490017800817660", null, null, new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95"), "02/27" },
                    { new Guid("9ee14fc4-795b-4eb5-ad79-11f3222fcc33"), "912", "7406964740100716", null, null, new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2"), "07/22" },
                    { new Guid("9effb83a-25b6-4423-bf62-b38a2dcd0fd3"), "298", "2754183429435868", null, null, new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd"), "04/09" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a00cf1e7-1bfd-42aa-9b88-b0112c0133e3"), "511", "7663172229355807", null, null, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597"), "05/24" },
                    { new Guid("a1140e56-5341-4958-a010-4f7c3b1c0e14"), "552", "1478828455950276", null, null, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321"), "04/28" },
                    { new Guid("a1142794-6049-447b-8d3f-dab4b4a4e181"), "355", "7158960104912807", null, null, new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd"), "07/21" },
                    { new Guid("a1400819-233b-4e25-8df4-b7a1d503b1be"), "922", "1701876132329232", null, null, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955"), "08/06" },
                    { new Guid("a14e958c-9b02-471b-957d-25d3c39f6a32"), "483", "1973367084357191", null, null, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40"), "09/03" },
                    { new Guid("a17077f1-2436-44a1-b217-15b224396719"), "929", "1609674854331974", null, null, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52"), "10/07" },
                    { new Guid("a17b3716-8ca9-4919-8403-96a88773702d"), "757", "4758221418386438", null, null, new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014"), "12/12" },
                    { new Guid("a1cc0c28-c3e2-4e4e-b59a-cdbdab6b0f9c"), "513", "5599236045597985", null, null, new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb"), "02/27" },
                    { new Guid("a1f1c981-2e1a-4d17-91c1-8217fc785610"), "972", "1838619962880762", null, null, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5"), "10/06" },
                    { new Guid("a215113c-caca-4949-a94f-b7947e4bbf97"), "805", "4590374354666939", null, null, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d"), "09/26" },
                    { new Guid("a2f6c548-9af1-48d0-a4e0-4403acec05ee"), "623", "8229320244394207", null, null, new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63"), "04/10" },
                    { new Guid("a3214351-48bb-4ef8-b32c-83c53be8e66f"), "861", "9032084452201821", null, null, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf"), "09/16" },
                    { new Guid("a323a8b1-8fa1-442d-a310-27d75635cd40"), "492", "2751465826810178", null, null, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee"), "08/21" },
                    { new Guid("a33713f4-d852-48e5-9ff9-e342e14c5272"), "739", "9390690465093624", null, null, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b"), "10/01" },
                    { new Guid("a386ce6a-1a14-4d48-873b-53cee3139848"), "178", "8184497570449266", null, null, new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267"), "04/06" },
                    { new Guid("a5494dd2-f94e-4dc4-8e84-fcc20441bdd9"), "412", "7880496265882580", null, null, new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce"), "03/12" },
                    { new Guid("a5ab3375-1045-41f5-ab6e-609f2f58a0da"), "433", "5088027183358343", null, null, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0"), "04/02" },
                    { new Guid("a5d48699-942f-49ce-bd63-566ffa327d3b"), "223", "9791210650060899", null, null, new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2"), "09/26" },
                    { new Guid("a6088a31-5a85-496f-837b-25cdc2837b2f"), "891", "5614146196426513", null, null, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0"), "08/27" },
                    { new Guid("a61f5250-7742-4620-af16-39de3e894ffd"), "762", "6759002298944870", null, null, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b"), "11/28" },
                    { new Guid("a6712dc6-f2d0-4bbc-a786-6cf96c7da124"), "304", "9586007447837870", null, null, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a"), "05/07" },
                    { new Guid("a6746eca-c9b5-4512-aef5-8778564644b7"), "136", "9028685297476626", null, null, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8"), "09/13" },
                    { new Guid("a683f8ba-4551-4ec7-aed1-6057975ce65d"), "663", "4421728309617394", null, null, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f"), "06/03" },
                    { new Guid("a697cec7-9bb0-44d0-9f6a-97a1271d26d1"), "761", "3257428953631354", null, null, new Guid("64ae7664-3300-40cf-a69a-7862eca124da"), "08/05" },
                    { new Guid("a721c078-907c-4909-a8b7-3ba0b4199ca4"), "664", "3838601513095982", null, null, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518"), "05/27" },
                    { new Guid("a77732eb-a0d7-4b48-a807-22f4819863ec"), "550", "5881856713777459", null, null, new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057"), "03/14" },
                    { new Guid("a7dca349-65c7-4fc5-a6ee-f7a71906103c"), "962", "2078331499473504", null, null, new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615"), "12/16" },
                    { new Guid("a81de26b-4700-4da0-80a0-64e972a56ae1"), "218", "2669056973063078", null, null, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb"), "09/25" },
                    { new Guid("a83020c7-f3ca-4668-b3bb-3c0dd0783766"), "002", "5118817712259630", null, null, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d"), "03/08" },
                    { new Guid("a832f423-dad9-4696-90ae-25358ba173e3"), "995", "8769230393860933", null, null, new Guid("2da9ab08-6750-4a36-8423-df883774a78a"), "10/28" },
                    { new Guid("a8681bab-e89d-4f71-8a3e-a334760d575b"), "981", "7188639672024572", null, null, new Guid("a8eb141c-5178-4baa-b599-679287b17c92"), "07/23" },
                    { new Guid("a8c418da-df7c-434c-9e01-0d41db1cbe26"), "944", "4513490019339499", null, null, new Guid("558db05b-0b8d-442b-8166-524709ea133f"), "07/18" },
                    { new Guid("a9a92181-6d5a-400d-a187-da2c252aa528"), "482", "4808422504760512", null, null, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0"), "10/28" },
                    { new Guid("aa13a263-85ba-4dcb-acee-93acf47ff7ce"), "810", "5966839622227571", null, null, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44"), "12/16" },
                    { new Guid("aa787659-8c87-49d6-a9ac-70c54db55cc6"), "608", "8926255578946595", null, null, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c"), "01/07" },
                    { new Guid("ab230ed8-b7e3-4cd0-9c17-5e7bc06f31bc"), "362", "4658480247524231", null, null, new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f"), "09/03" },
                    { new Guid("aba6c389-18f1-44cc-a22b-d96b575a8674"), "853", "5339918370665958", null, null, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062"), "03/25" },
                    { new Guid("abc085b1-fd0e-490b-9270-c8db6a9b43fe"), "836", "4907518530668934", null, null, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7"), "06/02" },
                    { new Guid("abce271a-14dd-4e66-9dea-3eab329ec3cc"), "024", "6641690886666179", null, null, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa"), "09/02" },
                    { new Guid("ac691c02-0493-451f-8d9f-15912e739e1a"), "390", "6232402945164667", null, null, new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8"), "06/18" },
                    { new Guid("ac8c4469-8fe3-473f-a76b-642d80340262"), "857", "1265895615938578", null, null, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c"), "12/12" },
                    { new Guid("aca5e3a8-3cd8-4bcd-9bb9-1f71bebee1ce"), "560", "3260404348584385", null, null, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f"), "11/18" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("accc6d76-009c-40f4-96d9-108049a714e0"), "348", "2183336835998128", null, null, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900"), "01/10" },
                    { new Guid("ae6a0dc3-f8a0-4e3b-8400-f3662e2e4336"), "427", "8234150496748737", null, null, new Guid("a836bc35-12f7-485d-861b-ad1645878c24"), "09/08" },
                    { new Guid("ae91a29c-60db-43cd-a678-024c4b24b15b"), "997", "4168046314718790", null, null, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c"), "11/15" },
                    { new Guid("aea21adc-e4d7-4d16-97ce-01851f1800ce"), "355", "3310336798479886", null, null, new Guid("50a38340-96f3-4c16-af8c-098f142991c6"), "09/28" },
                    { new Guid("af581026-4bb7-4b9a-87c1-9003469074dd"), "246", "8741692580693194", null, null, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1"), "07/03" },
                    { new Guid("af7dbe57-8b26-4cd7-8c0a-00561958ef0b"), "835", "6697868851522407", null, null, new Guid("a8eb141c-5178-4baa-b599-679287b17c92"), "03/26" },
                    { new Guid("b0153bc3-539f-48a7-ad72-237919e87535"), "291", "9944498899349522", null, null, new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361"), "11/14" },
                    { new Guid("b0a8b66a-bb90-406c-b619-52554b34de33"), "706", "5322756576527699", null, null, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f"), "09/27" },
                    { new Guid("b0af16dd-e73e-4b75-8edf-fd3308c7740c"), "711", "9444654680743633", null, null, new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d"), "11/23" },
                    { new Guid("b108b5d4-b8fe-4af9-b324-8bb0657b892a"), "720", "6470445130175171", null, null, new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e"), "11/08" },
                    { new Guid("b17aac54-7490-42d3-9bf2-4b7e323b6c56"), "607", "7187443920847679", null, null, new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02"), "05/24" },
                    { new Guid("b1ccae66-47ed-4ba9-affb-62a5d1dff3e3"), "123", "6776629866695775", null, null, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5"), "08/14" },
                    { new Guid("b1ef1c24-20ad-410c-81bc-acd5a2494c0a"), "704", "9255264470941003", null, null, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35"), "09/26" },
                    { new Guid("b21b802a-5ef6-4edf-9278-64da16909c89"), "061", "3677112638835160", null, null, new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79"), "07/28" },
                    { new Guid("b2df2c52-4dd3-44b4-acc6-65e69b621efa"), "205", "9310004049348370", null, null, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb"), "03/23" },
                    { new Guid("b2fa219d-e394-4725-91f5-6cea0f4e2938"), "384", "7769873128167264", null, null, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d"), "09/25" },
                    { new Guid("b3801983-63b3-4e26-b1a6-b22d031c58e6"), "528", "9333155062464817", null, null, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b"), "08/24" },
                    { new Guid("b3cf5006-bdb5-4ce7-98dc-5c9b7c4500d0"), "116", "7047305758194599", null, null, new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841"), "11/04" },
                    { new Guid("b43870b5-2360-4472-beef-42e376a1876b"), "412", "1669193569922657", null, null, new Guid("285d8d29-53de-4979-a403-f61b887fa207"), "12/20" },
                    { new Guid("b492c2de-7e1f-4f04-9bd8-2f0016f096b7"), "004", "4793342843907163", null, null, new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3"), "10/22" },
                    { new Guid("b4a9210c-e9de-4468-aae0-d0a941f3de55"), "653", "1770144331458708", null, null, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1"), "07/19" },
                    { new Guid("b4e67b65-4a33-41fd-a560-ad9028a7fc83"), "364", "8519064495603811", null, null, new Guid("d2c357de-2574-4d81-996d-8fd06173f665"), "01/18" },
                    { new Guid("b515f9fc-137c-4c37-9396-4fcd19f3be33"), "943", "3215751813605212", null, null, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271"), "01/26" },
                    { new Guid("b52d10aa-ed0c-4a11-9b1d-580be272b2e9"), "175", "7321114543076614", null, null, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd"), "10/25" },
                    { new Guid("b592e1a3-cc37-4b7a-a89a-bd55f5b9f81d"), "698", "3414203436948564", null, null, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216"), "08/28" },
                    { new Guid("b593b1d5-9b7e-40bd-a046-6071888e44fd"), "480", "3359479220516637", null, null, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955"), "04/27" },
                    { new Guid("b5b4de10-2ea8-49e6-b2e9-f114bee9b741"), "555", "9574233197735205", null, null, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693"), "06/01" },
                    { new Guid("b5ecfe33-2d27-47bc-8f8c-7a2d702e1fef"), "954", "4809196869814564", null, null, new Guid("285d8d29-53de-4979-a403-f61b887fa207"), "10/04" },
                    { new Guid("b68474de-8029-4f68-bc34-60f1d1058980"), "059", "1264871420273491", null, null, new Guid("114ac41c-5eba-4152-8f7e-622356a03762"), "05/08" },
                    { new Guid("b717a0ea-430b-4aea-bcdc-ebe0c56697e9"), "557", "3268022149469724", null, null, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565"), "07/19" },
                    { new Guid("b7d2b507-9088-49d0-9109-73befc0b6b24"), "951", "5008983114624094", null, null, new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd"), "09/28" },
                    { new Guid("b7d3b68c-d48c-40e3-9a1f-e9ebb453a492"), "311", "8478553972087666", null, null, new Guid("246ee090-764e-420d-803e-5d97e7d873a0"), "12/23" },
                    { new Guid("b8c2d872-3955-4f45-8e70-f960e61aab5b"), "013", "5444921114765314", null, null, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971"), "08/19" },
                    { new Guid("b8c36a65-d872-4d0e-806b-1dad6d976fbb"), "132", "2480161482750973", null, null, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd"), "05/14" },
                    { new Guid("b8c9736a-49b2-4208-87f9-d3892b5019a7"), "063", "5520037562778001", null, null, new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d"), "06/22" },
                    { new Guid("b951d76a-415b-4582-938f-17d6aa44aea1"), "490", "6746622682309977", null, null, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), "04/13" },
                    { new Guid("ba497dec-8e86-4a9c-82b3-9d3b3a3c2bbf"), "649", "3244550915258747", null, null, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641"), "04/16" },
                    { new Guid("babb6378-5831-40ee-aa75-2f1169b4623d"), "868", "6997528964683110", null, null, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf"), "10/18" },
                    { new Guid("baf86cc7-9e9f-4c00-8607-760676f69c33"), "279", "5968241370594979", null, null, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8"), "01/02" },
                    { new Guid("bb05a046-fdc3-46b9-ab47-7923a3ed54e5"), "643", "2779522173254328", null, null, new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2"), "04/06" },
                    { new Guid("bb144104-444c-4a47-a1c0-5700cdfe30e4"), "872", "5199565308424678", null, null, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8"), "12/13" },
                    { new Guid("bd90ef71-8746-48a0-860e-3e3cb9710a12"), "865", "3476902936149056", null, null, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0"), "10/19" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("bd95df89-412d-41e2-8859-4225014b0494"), "445", "5162804231917087", null, null, new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd"), "11/05" },
                    { new Guid("bd9d3375-94ca-440d-90e2-6cdb7c33d940"), "164", "1213560305989878", null, null, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367"), "07/27" },
                    { new Guid("bdc0aabc-6c4c-44be-9717-6df547466ef3"), "594", "3122836973388139", null, null, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c"), "04/22" },
                    { new Guid("be0779fe-94d8-4721-b53b-d74499d39869"), "431", "7993864403749534", null, null, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25"), "02/25" },
                    { new Guid("bef087f7-56a2-4abf-a281-dddabfb85849"), "243", "9172698778919918", null, null, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216"), "10/19" },
                    { new Guid("bf036ae2-175a-4428-9b32-f7de49f15478"), "964", "4720454128774048", null, null, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf"), "03/08" },
                    { new Guid("bf59034a-b86a-4a37-a98c-2bcd73554309"), "553", "2611706634166482", null, null, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44"), "12/14" },
                    { new Guid("bf8b7f77-d207-4730-87d9-b4b82cdd6daf"), "389", "7987685640293565", null, null, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9"), "12/03" },
                    { new Guid("bf9499d9-82d1-4e85-9983-60b4e9b66842"), "630", "9942499965091593", null, null, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4"), "04/05" },
                    { new Guid("bfe6ced8-968c-4429-be8f-90d7f6843571"), "421", "4092135708482854", null, null, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb"), "06/12" },
                    { new Guid("c00f44cd-bf2e-4fb0-a165-d0c64265b542"), "786", "8134619298434744", null, null, new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f"), "05/24" },
                    { new Guid("c01f9cd7-2046-4a79-b619-24007dea40b5"), "401", "1716373008924062", null, null, new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc"), "08/18" },
                    { new Guid("c0e0fafd-6cfb-455c-b7b8-956eae041305"), "377", "8515539973559674", null, null, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062"), "02/19" },
                    { new Guid("c0e67e8c-5ec6-4669-8259-e78362932450"), "603", "2321815624113176", null, null, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c"), "01/08" },
                    { new Guid("c10016e3-1692-4000-82b5-76e1b411d3de"), "783", "2634278294886110", null, null, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52"), "03/22" },
                    { new Guid("c152dae9-e3e5-4c18-9d26-47782ec44791"), "524", "8357294833406820", null, null, new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968"), "07/03" },
                    { new Guid("c1921b17-6090-4a22-80d1-dcc37e967e04"), "291", "8061524145857794", null, null, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5"), "08/05" },
                    { new Guid("c19bd5e5-9934-4df9-b83a-834de2f94c4d"), "302", "7425137014130735", null, null, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9"), "08/20" },
                    { new Guid("c19d93c1-4cfc-4a9e-848a-f5e229d474dc"), "234", "8750727405399833", null, null, new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643"), "03/02" },
                    { new Guid("c1cee1fd-467a-44fc-843e-8c05cf346717"), "852", "3579708284652840", null, null, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab"), "04/18" },
                    { new Guid("c2205cb7-dad6-48b4-bbc5-1c026340ba1f"), "458", "5946541603920520", null, null, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf"), "03/11" },
                    { new Guid("c2367775-b7f9-4535-85bb-e084bbce7594"), "131", "8045539398965821", null, null, new Guid("79086701-2604-4fd7-bb34-b77855e8579e"), "12/03" },
                    { new Guid("c280595c-8f38-4805-842a-84dd7d4ac68d"), "675", "1266191886814124", null, null, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb"), "07/20" },
                    { new Guid("c2e0ff99-d073-48f7-8aa9-f2e6c027de8e"), "507", "2138793282081596", null, null, new Guid("d8e6873e-ae0e-4181-866e-982565b77df9"), "08/03" },
                    { new Guid("c3617d19-3726-433a-9453-7224b892bcd1"), "160", "3701012785860398", null, null, new Guid("18e4d405-c797-4c9c-af33-613450990efe"), "07/20" },
                    { new Guid("c4cec83f-bf06-45df-abda-2daaa36749f0"), "786", "8366679885456863", null, null, new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b"), "01/06" },
                    { new Guid("c533db61-e002-4104-b839-e641e705901c"), "487", "4045168578087504", null, null, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03"), "10/05" },
                    { new Guid("c544df9f-b8e7-475a-b605-36c50679e24f"), "542", "8462657897496900", null, null, new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0"), "07/06" },
                    { new Guid("c564c792-94a3-47be-96e9-3cbca6d2ba9e"), "301", "9634230478864443", null, null, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd"), "08/24" },
                    { new Guid("c569d42c-a669-4903-aa54-e69e75baa87d"), "948", "5310076246074605", null, null, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5"), "06/16" },
                    { new Guid("c57cdd53-5e11-498a-9bdb-dcdaa8f2c7e0"), "327", "9354810582065325", null, null, new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f"), "02/04" },
                    { new Guid("c59e7cb3-f5c9-4015-b1fc-d74f8d899257"), "025", "7971395064992923", null, null, new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265"), "07/24" },
                    { new Guid("c5c5c1be-d163-48d8-aaff-55f80a3dc82e"), "517", "9110047292220331", null, null, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf"), "11/01" },
                    { new Guid("c5e40944-6f28-44df-9d1e-d4f9fbc1160b"), "598", "7378003986660773", null, null, new Guid("4860b124-2e67-49cc-b664-135729261ac4"), "11/06" },
                    { new Guid("c5fc0f45-88bd-45be-a1b7-3b00cf3d62ef"), "800", "9692221173858940", null, null, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de"), "11/04" },
                    { new Guid("c6225ff1-3919-4f45-9d8f-676869660bb4"), "712", "3220400194752792", null, null, new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63"), "01/03" },
                    { new Guid("c63d6346-3d06-469c-8f69-11e01c11fb9e"), "765", "3201502496566207", null, null, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f"), "01/15" },
                    { new Guid("c6ae7371-fa4c-4aa1-a7c5-ed1b9e5a5fb4"), "798", "3410914260881250", null, null, new Guid("d2c357de-2574-4d81-996d-8fd06173f665"), "10/25" },
                    { new Guid("c70e3660-5e40-49c9-85b6-4bbc947ab310"), "963", "3386905690555967", null, null, new Guid("79086701-2604-4fd7-bb34-b77855e8579e"), "07/09" },
                    { new Guid("c752f739-916e-465e-84b3-c35f0cdaa724"), "222", "4085141189032951", null, null, new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35"), "04/01" },
                    { new Guid("c79527a0-4c70-45f8-8350-c42e6016cff6"), "584", "3563255420077115", null, null, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14"), "04/15" },
                    { new Guid("c7a47fca-6b9a-4463-82e4-f8b1ef1651aa"), "636", "8210701908987658", null, null, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86"), "01/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c7f68dba-7c93-4b6c-b05d-02bc53f7d82c"), "133", "2929544528020741", null, null, new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808"), "04/19" },
                    { new Guid("c7fb6c94-3e4c-4a99-9266-82031eb306b4"), "183", "3826383366409925", null, null, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7"), "10/17" },
                    { new Guid("c83a892a-b456-4bef-8948-2aa33ac3017e"), "204", "9335483936883001", null, null, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd"), "11/27" },
                    { new Guid("c8cf3bc4-91e1-48d0-b432-44179aaef083"), "800", "2580959072180977", null, null, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367"), "11/26" },
                    { new Guid("c943bdfc-95a7-47c1-8200-d64d16bf1412"), "431", "1709844957988986", null, null, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e"), "01/17" },
                    { new Guid("c9c49f06-6e44-4ac8-842e-f4e2ce10723e"), "591", "8005168787255704", null, null, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f"), "05/15" },
                    { new Guid("c9ef5a80-8a4c-441c-91ef-bb556dc3aa2a"), "465", "9886302051598740", null, null, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6"), "03/03" },
                    { new Guid("ca40e622-60c9-4e52-b0ce-c42b1be678c6"), "362", "2287963820737082", null, null, new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0"), "02/21" },
                    { new Guid("cab6218e-4085-42af-b423-7d7e1d5cecc8"), "518", "2412699185105509", null, null, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), "01/14" },
                    { new Guid("cad82ed6-f0d4-4ce7-beb5-5e54157ddc8a"), "323", "9245830500313188", null, null, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5"), "04/06" },
                    { new Guid("caed7ca9-fda2-426f-8632-fdadfa8c7b91"), "373", "4094578540691569", null, null, new Guid("9ace24ed-f865-4310-9613-b304be005b00"), "05/03" },
                    { new Guid("cb4479b9-e941-465e-b863-bc12963faf57"), "536", "8247863204259746", null, null, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd"), "09/07" },
                    { new Guid("cba9eeba-2c75-43c3-abcb-2baa54fbc69b"), "871", "3820956452895629", null, null, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988"), "06/27" },
                    { new Guid("cbc076cd-fa1f-4fa1-8d14-2a64541e5070"), "329", "8699518659622539", null, null, new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa"), "10/20" },
                    { new Guid("cbe650f1-edb3-499e-b4c9-1c645ce21acd"), "718", "3779099145996741", null, null, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5"), "06/20" },
                    { new Guid("cc871927-3673-4227-9635-d23352bc877f"), "708", "2984503976647614", null, null, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285"), "09/02" },
                    { new Guid("cc92b76a-e8d5-4b40-8e72-a581438023c0"), "878", "8608845501527250", null, null, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179"), "09/13" },
                    { new Guid("ccbeb8a4-d3ef-4778-8daf-633944e078d8"), "401", "6104937914313126", null, null, new Guid("b552dea4-6df2-477a-870b-1317247a51c0"), "02/02" },
                    { new Guid("ccef6f0a-a4f3-46d9-9071-c42c7635000d"), "371", "1161072749899082", null, null, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5"), "05/15" },
                    { new Guid("ccf13aae-73a7-4833-9f12-f3479f761c59"), "370", "9080630196284785", null, null, new Guid("85178881-d883-4586-bf89-10a49abb8b16"), "09/10" },
                    { new Guid("cd3cf4b5-8dbe-499c-93d3-0f83a4c802c1"), "922", "9923362627657275", null, null, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee"), "08/28" },
                    { new Guid("ce4290f9-6049-4b5b-b455-4e37e99147f9"), "361", "6971784066815973", null, null, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25"), "08/09" },
                    { new Guid("ce6344fd-c2d3-4bd1-ab87-c3b21500890d"), "880", "8547699627029270", null, null, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2"), "12/02" },
                    { new Guid("ce69ae21-ecd9-4c25-a953-86f2cbaa5803"), "926", "6541429885983126", null, null, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20"), "07/19" },
                    { new Guid("cec915d0-7aca-4710-888b-331d741cf5dd"), "103", "8481459842070942", null, null, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5"), "04/26" },
                    { new Guid("cf343f28-914f-40f5-b928-ab342d089dac"), "323", "9738970769711519", null, null, new Guid("4bc48bed-c113-458c-8a12-8f12565a542b"), "05/23" },
                    { new Guid("cf37267d-f6ed-41f6-a6d0-108213caecb1"), "260", "9126450764796618", null, null, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727"), "12/02" },
                    { new Guid("cfe731b5-ddc5-4bb1-9829-309c394b2ce8"), "236", "1874643410853169", null, null, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2"), "02/06" },
                    { new Guid("d025c2db-dd5b-4c93-b13f-8fc5c2033409"), "806", "2198416260206485", null, null, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf"), "05/13" },
                    { new Guid("d0639125-e871-475e-9eb0-4f94055b255d"), "500", "9933385665712115", null, null, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc"), "11/11" },
                    { new Guid("d07989cb-4b6e-4c65-a6dd-d29ab73c675e"), "327", "2259944504545363", null, null, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8"), "12/24" },
                    { new Guid("d07c9216-b7ab-467b-8965-d306b01ca3b0"), "618", "1094759245848500", null, null, new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92"), "03/10" },
                    { new Guid("d0ba262d-2a37-41fd-87cd-9a572a7867fb"), "234", "8853511307764357", null, null, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1"), "10/05" },
                    { new Guid("d0c15008-3a32-4aae-ba23-ac32d4770e3c"), "655", "1368987670281804", null, null, new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30"), "03/11" },
                    { new Guid("d1af7928-f631-482d-93a4-88d23f05f258"), "168", "7053454575050792", null, null, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565"), "05/01" },
                    { new Guid("d25fca3c-19fd-42dc-a4dc-284117f4447e"), "246", "8499215422479841", null, null, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16"), "06/18" },
                    { new Guid("d2f26edd-95c8-4b6a-9b28-204d69f7e29c"), "558", "5862386163897203", null, null, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5"), "08/03" },
                    { new Guid("d32ea2ef-6e4e-412b-918f-753ad494ad08"), "325", "6177527805291717", null, null, new Guid("26e9f9a9-c77f-4f47-b594-e602be058706"), "12/25" },
                    { new Guid("d54d9eab-5934-48c7-a347-c3d69725080f"), "642", "2836119152971443", null, null, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367"), "08/21" },
                    { new Guid("d60177c2-0056-44cd-b818-7c99b0fd3133"), "523", "3073712371902250", null, null, new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca"), "02/27" },
                    { new Guid("d6bcb700-c255-41dc-a7be-d0189150d729"), "837", "5931502821397424", null, null, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9"), "12/18" },
                    { new Guid("d6c89f73-a8d8-4cac-b020-68b452583c29"), "225", "7296046966576676", null, null, new Guid("2da9ab08-6750-4a36-8423-df883774a78a"), "12/19" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d6ce0791-995c-463f-893e-25a6cb2daa4c"), "791", "1696899466726663", null, null, new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547"), "03/16" },
                    { new Guid("d6f7eccd-ca42-4462-9252-518ee8e7e0d5"), "294", "2062813609475836", null, null, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc"), "11/21" },
                    { new Guid("d750b5f1-3720-4026-a191-d1ba1ac1e6b2"), "406", "8237816785754005", null, null, new Guid("b552dea4-6df2-477a-870b-1317247a51c0"), "02/05" },
                    { new Guid("d768997d-74bc-400f-b782-8fda517e09fd"), "362", "6753921457782418", null, null, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35"), "11/19" },
                    { new Guid("d7c6e935-47c3-43ce-871a-3d3e73668bbe"), "358", "7900292217563345", null, null, new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd"), "11/28" },
                    { new Guid("d86b1512-61ba-4723-b2c6-df8b3ed29ed9"), "549", "7438709715538207", null, null, new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5"), "03/11" },
                    { new Guid("d88f37ea-641d-49a0-a43f-43d73dbe6ea4"), "326", "6250168025220055", null, null, new Guid("85178881-d883-4586-bf89-10a49abb8b16"), "06/08" },
                    { new Guid("d8bff2a0-0eac-4b0b-a004-89fc44f75a86"), "862", "3923986236664553", null, null, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca"), "12/15" },
                    { new Guid("d92384d0-6c44-40a7-aba6-de33efca35c6"), "181", "6363206073969691", null, null, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971"), "08/28" },
                    { new Guid("d93fdd6b-c2a9-4dce-b1f5-e2b80bc34e8a"), "750", "2702749103814016", null, null, new Guid("18e4d405-c797-4c9c-af33-613450990efe"), "07/16" },
                    { new Guid("d9a3c210-9b8f-4c02-925a-61341d7cab43"), "534", "1188533749907470", null, null, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf"), "12/09" },
                    { new Guid("dab95a29-d2bd-4285-b722-13e0dec83329"), "219", "7919773637560740", null, null, new Guid("c9809439-c97d-49ed-b84a-66149d142e46"), "09/15" },
                    { new Guid("daf63999-8479-45e4-81b5-afd457b429c4"), "884", "7369398019966220", null, null, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd"), "07/03" },
                    { new Guid("daf73991-3a67-42aa-9831-38790609343c"), "157", "2630258799726816", null, null, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321"), "03/03" },
                    { new Guid("db2a28bc-f4ee-4383-9424-e3e6dc5774ce"), "285", "8335067107995720", null, null, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f"), "07/11" },
                    { new Guid("db2bc5b3-a481-4a6d-97f0-4b0a6aa682da"), "195", "1171310710706968", null, null, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a"), "04/05" },
                    { new Guid("db395b62-dfd9-4230-a096-187a4ad3a603"), "795", "1908420166445789", null, null, new Guid("c32606de-b224-4989-bf52-f8b3cabea595"), "07/27" },
                    { new Guid("db6e3a8d-0376-4242-8c7a-d94dbdfbcc1d"), "662", "1458754737985341", null, null, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8"), "03/27" },
                    { new Guid("db71df2a-78a3-4e38-83bc-cf2ed2f814df"), "234", "8676191440058933", null, null, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb"), "01/04" },
                    { new Guid("db8e7cdb-0f7f-4e0f-9e13-5236ad0f86d1"), "601", "7362828698307308", null, null, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee"), "11/21" },
                    { new Guid("dbbf9bea-56d6-4d54-b449-a5212e424bec"), "549", "8477674345296858", null, null, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f"), "03/06" },
                    { new Guid("dbc40721-cbab-4cd6-94b1-b692e1bde126"), "850", "6872174301087048", null, null, new Guid("a8115124-4280-4a52-8af7-cb635f456958"), "10/23" },
                    { new Guid("dbc95ac3-cef6-4cff-a491-dd79a228aa3e"), "946", "3577683817891757", null, null, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed"), "09/06" },
                    { new Guid("dbdbba6a-d524-473d-b0a6-62dd8592b6c5"), "106", "8633345695824345", null, null, new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4"), "01/02" },
                    { new Guid("dbe2e55a-9d7c-4fd7-81b1-34d13fba209f"), "954", "6660655106009393", null, null, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271"), "10/10" },
                    { new Guid("dc183c0c-f99a-4202-9197-f01ccd2c599d"), "749", "5950349300669849", null, null, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13"), "06/23" },
                    { new Guid("dcbcf224-26a5-4ff4-b7bf-b1e2a6172e47"), "032", "1435723577876303", null, null, new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4"), "10/01" },
                    { new Guid("dcca03ee-5e2a-4c7e-980d-7322cae32182"), "470", "3020076038926708", null, null, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa"), "11/25" },
                    { new Guid("dd35dfdf-74ba-4110-a543-982b9b0131b6"), "855", "5700361227763823", null, null, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd"), "03/25" },
                    { new Guid("dd617835-72de-4967-bb80-6d5b6c91c2cc"), "204", "2922104546301907", null, null, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28"), "12/05" },
                    { new Guid("dd66366d-4d2b-40d9-aba0-3fc5b319b56a"), "561", "2364630572128767", null, null, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee"), "03/12" },
                    { new Guid("dd9608af-c7cf-4a4c-bca6-358cdbb33c59"), "396", "8313445723999822", null, null, new Guid("246ee090-764e-420d-803e-5d97e7d873a0"), "01/22" },
                    { new Guid("ddf7592f-2c26-4b22-82ff-7ef68b12a239"), "399", "6544534710237755", null, null, new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e"), "11/02" },
                    { new Guid("de55782e-81f3-4d39-be62-b864eee8e56c"), "049", "3666155092160400", null, null, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b"), "09/05" },
                    { new Guid("de62d9bf-6264-427b-bdf1-baf42f2d86a2"), "540", "8776645155061059", null, null, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c"), "10/24" },
                    { new Guid("de7f924f-ec31-49f3-9926-1b1f7f44e57c"), "045", "1076369674913491", null, null, new Guid("50a38340-96f3-4c16-af8c-098f142991c6"), "09/12" },
                    { new Guid("de8eca76-057d-442d-91e4-baf3bddc4b3b"), "345", "5861825675468736", null, null, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd"), "11/10" },
                    { new Guid("dea25723-3c60-498d-b0d6-8ac36a89d3c8"), "557", "9406961613182209", null, null, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c"), "11/18" },
                    { new Guid("def4cac9-3cee-4857-857f-0f2ecdda55ca"), "570", "3545149772661598", null, null, new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117"), "02/16" },
                    { new Guid("df0180af-c6ad-433a-8f61-c79c1163f719"), "038", "7942792828798785", null, null, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b"), "05/05" },
                    { new Guid("df4b8e23-c9dd-4f28-abe8-61ddb8265b2a"), "142", "9927468701534771", null, null, new Guid("60f7f230-ff82-425a-a6c5-cc5156098000"), "02/28" },
                    { new Guid("df63db73-266f-4c60-9127-2660e5d522b0"), "675", "4839929619227407", null, null, new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6"), "12/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("df86b071-3cf5-4242-8df0-6c89d7e1c3a9"), "637", "1206476310025175", null, null, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737"), "06/23" },
                    { new Guid("df9b3f86-20f0-4afb-a933-1ca90eaf6704"), "284", "4370877197519904", null, null, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1"), "03/01" },
                    { new Guid("dfe237a9-7b23-46ef-9ef8-e6c3891287cb"), "733", "8168263159062961", null, null, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891"), "03/24" },
                    { new Guid("dff5abcf-7fb2-4dd7-ab8a-634b806f76ad"), "394", "6764637172321764", null, null, new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53"), "11/10" },
                    { new Guid("e046a392-6872-4af0-951b-4175b7578162"), "806", "4927203623620864", null, null, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0"), "06/23" },
                    { new Guid("e04c8eb8-31ef-4af1-9c61-d06dd31d42f8"), "720", "6910348434380614", null, null, new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4"), "02/25" },
                    { new Guid("e1d500ba-cc0f-4b98-87c6-8be20a348777"), "659", "1413000375390047", null, null, new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca"), "05/25" },
                    { new Guid("e3357b55-c488-4acc-9ca2-a2de09c2c86c"), "733", "5937033338889123", null, null, new Guid("da175a26-80f5-4704-9c96-da3480a7797b"), "07/11" },
                    { new Guid("e3ba4b22-7eb7-4695-afb1-72eec737a8b5"), "764", "1036243613396587", null, null, new Guid("f198b380-c53a-437b-904d-29b9d522aac3"), "07/03" },
                    { new Guid("e405a156-f765-4287-bd3b-7b56ea190662"), "137", "1268375000305568", null, null, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9"), "09/02" },
                    { new Guid("e422f253-9220-4a11-920b-193cb7c7ef7a"), "819", "6013040264053766", null, null, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa"), "09/26" },
                    { new Guid("e428be05-66d2-4d7b-8755-2ac9991d423f"), "129", "3664527142758791", null, null, new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0"), "12/20" },
                    { new Guid("e44c15eb-2908-4689-a788-1815f7520d3e"), "966", "8208881867498121", null, null, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737"), "08/17" },
                    { new Guid("e4598824-3526-4933-aad4-dc27640a7668"), "890", "6243469187218355", null, null, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30"), "09/15" },
                    { new Guid("e4b881f0-b150-440f-967c-8996f894d6e6"), "856", "4092883035840031", null, null, new Guid("a42b469c-fec8-4056-a4de-926b01b7f202"), "01/15" },
                    { new Guid("e4e1cdad-ed18-44c5-8ad8-9ee76cadcdf6"), "981", "8397261520644913", null, null, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0"), "05/18" },
                    { new Guid("e6a381d1-894e-45d1-a326-df22c2cb83b2"), "033", "3158354992162202", null, null, new Guid("9ace24ed-f865-4310-9613-b304be005b00"), "11/13" },
                    { new Guid("e6a5d9fb-98e2-476a-9943-15ff388c9f13"), "711", "8014458517059193", null, null, new Guid("2da9ab08-6750-4a36-8423-df883774a78a"), "11/23" },
                    { new Guid("e6f94972-eb71-4f80-b419-85a44d54cf0f"), "807", "4068512855031472", null, null, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf"), "10/26" },
                    { new Guid("e78d10b4-67cf-4dd5-a310-3a8df0a4d20f"), "337", "1607418048737593", null, null, new Guid("d2c357de-2574-4d81-996d-8fd06173f665"), "04/06" },
                    { new Guid("e7c3f1d2-9e87-4cff-9dc2-dc4e56b3e5c6"), "519", "6013017284126601", null, null, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5"), "04/11" },
                    { new Guid("e7f97d2f-9cbd-4115-92d8-8b98df1c7102"), "011", "5183389774018503", null, null, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f"), "02/19" },
                    { new Guid("e812be67-b967-47f8-a815-376d67a894a2"), "759", "4582032429836033", null, null, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede"), "07/04" },
                    { new Guid("e84d155c-2409-4cd8-a8fe-4456f58f4461"), "756", "8468348438279391", null, null, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb"), "01/12" },
                    { new Guid("e85174cb-44a6-496e-93f5-15a924e32d82"), "564", "8237689350911576", null, null, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f"), "11/13" },
                    { new Guid("e879ac7b-7726-4ef1-9048-7546285847b1"), "122", "2846669037788618", null, null, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7"), "01/15" },
                    { new Guid("e8e4491e-6efa-448b-930c-6728cc4f68f9"), "845", "1339290393064108", null, null, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988"), "04/05" },
                    { new Guid("e937af7b-c333-45ce-8d94-a1da8752b97b"), "873", "3776737203027944", null, null, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0"), "08/01" },
                    { new Guid("e945c9c4-6923-407f-bc59-61473b2a1bcc"), "801", "3539012557937422", null, null, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d"), "02/12" },
                    { new Guid("e9ad43ab-8ff9-4cf4-9621-d7b7c5fe9803"), "001", "7218361604422160", null, null, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a"), "07/14" },
                    { new Guid("e9d42b48-c4a0-46ea-ac1a-0212a8090b25"), "541", "5313524108870631", null, null, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e"), "03/07" },
                    { new Guid("ea0cfc30-9a2b-40c7-98a1-31f9344c92f4"), "863", "4877196270118863", null, null, new Guid("316bd6de-f98f-4240-856b-7b943204b4fb"), "07/11" },
                    { new Guid("ea2b96ef-1d74-4617-a0f1-416159d7efcd"), "844", "1646877016944865", null, null, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062"), "05/15" },
                    { new Guid("eb0f6b2a-1a07-4ece-ae19-69f31ca07c67"), "887", "6497356184232457", null, null, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf"), "08/01" },
                    { new Guid("eb73ad4b-0358-4d87-903d-3090e8bce5ed"), "552", "1775430626516840", null, null, new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259"), "08/15" },
                    { new Guid("eb97c817-f98b-4312-88d0-af8010ebe125"), "403", "8772683970420801", null, null, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8"), "12/08" },
                    { new Guid("ec230364-2198-4a18-9bf1-a29466eb79f4"), "473", "5645843303828749", null, null, new Guid("b74d612a-560a-493f-9b9a-e7d76b857600"), "02/18" },
                    { new Guid("ed44f6f4-3481-42aa-bd6d-c65292af2e65"), "412", "1271919979563484", null, null, new Guid("7b8e2086-2aa9-4256-9444-793523c7a280"), "12/18" },
                    { new Guid("ed64192b-8304-4b11-8296-9f184ebbdd1b"), "441", "7144055482765075", null, null, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0"), "04/17" },
                    { new Guid("ed72833e-b452-4e3d-b11c-0628cd744f06"), "844", "9431222560308552", null, null, new Guid("9ace24ed-f865-4310-9613-b304be005b00"), "03/17" },
                    { new Guid("ed8800da-035c-46d4-839e-01f6afad7cac"), "566", "8165748884713480", null, null, new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1"), "11/08" },
                    { new Guid("ee6b3429-e3a6-4262-a463-adbaaae7fec0"), "204", "4157847041465185", null, null, new Guid("05fb67eb-3b60-4c93-bf80-36153be08871"), "01/09" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("eec94cae-1bd2-4d14-9df4-acf7fa362129"), "384", "5525423935114904", null, null, new Guid("da175a26-80f5-4704-9c96-da3480a7797b"), "01/24" },
                    { new Guid("ef011d4d-45eb-4e78-a711-d8b414605dc6"), "416", "6623543639239105", null, null, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c"), "05/08" },
                    { new Guid("ef727a72-2519-4205-b0a1-393a16c4c21c"), "717", "1161658517325940", null, null, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367"), "02/11" },
                    { new Guid("efab2dc4-99e8-4bfd-8e72-63ddf9abab3c"), "380", "4059869192622351", null, null, new Guid("87884942-9d13-450f-b485-62321f667eab"), "01/01" },
                    { new Guid("efcc3ab8-862c-4c04-974e-9848547fce63"), "510", "6498446130119662", null, null, new Guid("da175a26-80f5-4704-9c96-da3480a7797b"), "09/15" },
                    { new Guid("f01c5047-da15-458f-b7a9-8b4a102d1d93"), "471", "6734271399047645", null, null, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35"), "07/21" },
                    { new Guid("f05c1812-9205-4674-a4de-d00e307120f4"), "706", "6667738841284223", null, null, new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd"), "12/15" },
                    { new Guid("f1190283-b9d9-4698-93a4-404036622754"), "601", "3938748716355372", null, null, new Guid("558db05b-0b8d-442b-8166-524709ea133f"), "05/06" },
                    { new Guid("f18ea4e9-425c-41e0-919c-9246b5825eb6"), "096", "6799843007603090", null, null, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f"), "07/24" },
                    { new Guid("f1a97c88-3d22-4f9e-9c4c-694a73205266"), "645", "3426670585371706", null, null, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9"), "01/16" },
                    { new Guid("f1d2bdad-8b7d-4524-af3f-89be93065bf6"), "868", "6059674962798598", null, null, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f"), "01/05" },
                    { new Guid("f2442d03-aae2-40be-b8ac-621ce6530c75"), "870", "6331059902224768", null, null, new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b"), "02/02" },
                    { new Guid("f265075c-830a-466c-a3e7-767ce3acd09d"), "130", "2303408012848710", null, null, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0"), "12/08" },
                    { new Guid("f2acaed3-6353-4e90-baad-b937b1db9444"), "720", "5609181666763195", null, null, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f"), "05/16" },
                    { new Guid("f2b0f233-4136-4072-9264-37d05bf231f9"), "077", "4671212961062686", null, null, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948"), "03/07" },
                    { new Guid("f2e49d9d-d4c5-47b4-bad5-939fc6667e3f"), "015", "6527617382305310", null, null, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25"), "12/22" },
                    { new Guid("f3db1314-54c1-4f4e-982a-39555fbdcf5a"), "737", "1108054465806821", null, null, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9"), "03/08" },
                    { new Guid("f3f32cbd-6203-4c1c-95d1-995fe9dec090"), "472", "8008998444765623", null, null, new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0"), "12/10" },
                    { new Guid("f4ed24ef-153c-49bd-8d13-051bc5649964"), "814", "2425143642659581", null, null, new Guid("246ee090-764e-420d-803e-5d97e7d873a0"), "08/01" },
                    { new Guid("f59036bf-09e3-40d1-9756-eb4d7710fa3c"), "024", "1115167336560798", null, null, new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696"), "07/06" },
                    { new Guid("f5bf9777-4697-4a03-90b9-b2bab5cbd513"), "149", "4668808486765227", null, null, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6"), "04/23" },
                    { new Guid("f60c3f0c-b23e-4450-ae62-9e5784a56445"), "591", "7781247307082464", null, null, new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9"), "06/09" },
                    { new Guid("f6f1ce63-b48f-4452-a8ab-7ef7b1d6e4f8"), "817", "2659074229045817", null, null, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948"), "10/16" },
                    { new Guid("f746989e-04af-431d-958e-457ddf44d45e"), "025", "1240997346730543", null, null, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78"), "02/18" },
                    { new Guid("f7485626-1948-45ac-962c-5da029102a8d"), "997", "7493819668531620", null, null, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0"), "02/19" },
                    { new Guid("f7cbf78e-5035-4ffd-980d-47667a46ae05"), "939", "2379527060928461", null, null, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78"), "03/12" },
                    { new Guid("f81ae33a-4fa4-4d4d-8437-ea883098b2c6"), "756", "4435213423791165", null, null, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de"), "09/27" },
                    { new Guid("f855abaa-850c-4950-9d2e-2e29ac2a0fb7"), "158", "4181610165007591", null, null, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0"), "07/25" },
                    { new Guid("f89d3296-7da1-4d0e-8c00-a5cd0230498e"), "229", "2241763565984612", null, null, new Guid("e881572a-cd4a-4d95-bf26-6855a9394560"), "07/13" },
                    { new Guid("f8e88ad9-92f0-4d6d-9135-819d6e089879"), "285", "9116848990329513", null, null, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955"), "08/23" },
                    { new Guid("f8f536c9-56b7-486f-a2e0-756ca89d49dc"), "971", "1943685904195236", null, null, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86"), "11/06" },
                    { new Guid("f94e0d06-e3bc-4b0b-b971-428d58f7853b"), "368", "5090529323062107", null, null, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5"), "03/09" },
                    { new Guid("f94ed3f7-7831-46da-8b8f-872c0d17ea07"), "439", "7264021549468653", null, null, new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b"), "09/04" },
                    { new Guid("fa71084a-e723-4132-9caf-5d3bb7a5b089"), "009", "8534826083530118", null, null, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb"), "11/17" },
                    { new Guid("fa7b60d5-66f0-4b9b-8008-9b1f30758ddf"), "533", "9686135946720198", null, null, new Guid("f198b380-c53a-437b-904d-29b9d522aac3"), "06/05" },
                    { new Guid("fb0328a3-d0a2-424a-b927-45f5fc5f7d8c"), "001", "9632441675955409", null, null, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb"), "05/02" },
                    { new Guid("fb2205b7-db79-480b-8fd5-e6b6f47ea8a0"), "679", "2773479709717883", null, null, new Guid("01a8bd37-aff4-4aac-8218-b782c941985f"), "03/05" },
                    { new Guid("fb496c3d-f621-49f5-a595-d25f325b2524"), "461", "7919583453880680", null, null, new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2"), "12/04" },
                    { new Guid("fb6a7490-558d-4f97-8e0d-de1b00a3f982"), "646", "7875648674296562", null, null, new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014"), "06/03" },
                    { new Guid("fb6d293b-aaec-4303-8f37-2d5dd8f74a16"), "911", "8882967123335219", null, null, new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f"), "11/26" },
                    { new Guid("fb81438c-8285-42b4-b8f3-149c2bb5bb82"), "035", "4523641905277576", null, null, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1"), "04/23" },
                    { new Guid("fbbad373-3aea-4531-b715-d599f7eb97e8"), "907", "1606193602507034", null, null, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7"), "07/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("fc16478a-0b9d-4056-bc04-32c359a3dd1e"), "397", "4767942390860282", null, null, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb"), "08/04" },
                    { new Guid("fc894679-2f27-4beb-b542-719d03216995"), "295", "9495567666534079", null, null, new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8"), "08/14" },
                    { new Guid("fcf500dc-b8e9-4b27-824a-03a527344331"), "434", "2393938837142352", null, null, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a"), "02/06" },
                    { new Guid("fd08ee1b-4edf-4ac4-9305-aa30f85d40d1"), "658", "2885632951870477", null, null, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86"), "03/03" },
                    { new Guid("fd3604a6-d2aa-44b9-9f1f-5ed30e19a9d1"), "108", "5053213699212620", null, null, new Guid("58526312-a56b-4b29-b8d3-e131efce8cef"), "06/03" },
                    { new Guid("fd3cbb54-a598-4148-9e18-8bc14d0c3c66"), "564", "2591305286224912", null, null, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14"), "03/21" },
                    { new Guid("fe2bb8d8-e346-4980-90ce-90b7f9f172e4"), "743", "5820084524769204", null, null, new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30"), "10/13" },
                    { new Guid("ff16ed48-becb-4e63-86fa-e6a4681e9b98"), "175", "6823977003559124", null, null, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28"), "04/26" },
                    { new Guid("ff3454c6-4d3f-4344-9c2d-04d4b15ed684"), "954", "9322387711957817", null, null, new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549"), "10/13" },
                    { new Guid("ff50f3f5-71f4-4f36-a7ad-835f53246316"), "609", "6414049847499369", null, null, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f"), "02/24" },
                    { new Guid("ff576a56-e842-49a7-9233-dc6429ee544b"), "639", "8594699408460661", null, null, new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057"), "04/10" },
                    { new Guid("ffa6abde-cf73-48ec-9cb3-59b376c8004e"), "667", "4309072258127189", null, null, new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3"), "03/19" },
                    { new Guid("ffbaf318-96c8-4b7a-ad1c-0b569776db24"), "336", "9266116337942014", null, null, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565"), "03/05" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("00afc60a-34c6-4483-b5ad-84c8df1d1712"), null, null, "+819 07 (236) 81-04", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("01273056-938f-4678-9401-ed0d237cc2d6"), null, null, "+316 15 (565) 15-08", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("01e94c97-211f-4a5e-864c-35b70f5916a7"), null, null, "+523 55 (952) 82-50", false, new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3") },
                    { new Guid("02022143-ca60-46b3-bad4-bd4bb3c694f4"), null, null, "+19 56 (339) 01-10", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("02061600-296a-4fef-a104-7b2a8c435ab9"), null, null, "+672 02 (821) 38-94", false, new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("0213983a-1947-4d6d-9119-5211be8cd0d8"), null, null, "+6 90 (707) 39-48", false, new Guid("a0995ae3-517f-4476-bad0-18fca309cda5") },
                    { new Guid("02981898-af77-4500-ab64-8903343bb2e2"), null, null, "+311 44 (913) 43-78", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("02bc37f9-7096-49df-a563-083333c391ad"), null, null, "+197 71 (495) 74-22", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("03763f93-e477-4997-a6df-0e23017c4af3"), null, null, "+909 34 (246) 12-25", false, new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63") },
                    { new Guid("03bd4e37-844c-4568-bda6-d4a24ad486d2"), null, null, "+485 12 (104) 49-57", false, new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad") },
                    { new Guid("043606ed-e6c8-4b58-8f0d-2c1a2d36542d"), null, null, "+626 35 (688) 18-67", false, new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed") },
                    { new Guid("04a766f8-66af-412e-a533-7ac65d5bbaef"), null, null, "+295 69 (761) 13-04", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("04f2f569-cf13-4cb8-a7ad-578e596768a0"), null, null, "+407 87 (718) 75-82", false, new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2") },
                    { new Guid("0507c1b9-9d13-41db-b57e-8c907ff475b6"), null, null, "+262 17 (770) 49-87", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("0531eaa7-34d7-4689-a76d-6b52c4b66362"), null, null, "+303 95 (723) 38-07", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("055aee93-0b5a-4da9-b97d-ad5de263dfe8"), null, null, "+800 47 (286) 84-48", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("068bee9e-d9ff-42dc-a1be-fe3b0e0e888e"), null, null, "+750 88 (043) 35-93", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("06a981c1-9861-44f9-86d3-10dfb912f13c"), null, null, "+43 40 (357) 75-66", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("06f3d8f3-8554-4bca-b6e2-b44ae05b4c67"), null, null, "+280 98 (662) 24-59", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("06faa410-06c2-4a87-ad0c-447004dacc67"), null, null, "+246 78 (222) 23-99", false, new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0") },
                    { new Guid("0749959f-e800-47b3-892d-317cf3790e2b"), null, null, "+553 33 (901) 73-56", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("07c6cbb9-d2b9-4592-bf5e-a678143c7c61"), null, null, "+802 88 (598) 40-24", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("07cd7709-f445-4de9-9e8f-25c19a3183f9"), null, null, "+967 78 (531) 41-97", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("08048977-ebde-4981-b3d2-e1cb5920cc14"), null, null, "+911 64 (011) 90-66", false, new Guid("a836bc35-12f7-485d-861b-ad1645878c24") },
                    { new Guid("08562fe1-ee4d-490f-8487-a06275665e70"), null, null, "+149 98 (041) 59-05", false, new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f") },
                    { new Guid("08797ac9-e38b-4ea3-a77d-d3da6ba79b15"), null, null, "+981 93 (360) 34-91", false, new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("087e39a1-2404-4f2b-bddd-c85f03f7adee"), null, null, "+191 48 (537) 93-03", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("093c447f-f6ce-40c4-802b-c1950b2f2594"), null, null, "+136 19 (637) 49-65", false, new Guid("4390173e-3194-44b0-9f5c-e816c829e49d") },
                    { new Guid("09420727-a8b8-4451-87bd-de8dbc1614e0"), null, null, "+517 52 (264) 10-40", false, new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("096e7c6a-b538-4056-aeb5-5768a7eb2920"), null, null, "+733 98 (318) 21-34", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("09ed39ad-4fbc-4a5a-9539-0be9f5425c31"), null, null, "+656 41 (952) 02-88", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("09fd517a-b22f-4b9b-a65c-ca5ee81b5593"), null, null, "+962 57 (315) 51-83", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("0a08f94f-8e14-4866-8ccb-c83f9bf380e8"), null, null, "+227 14 (231) 03-53", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("0a9bb8a2-72c3-4054-9e1d-7b4fadf62bfe"), null, null, "+839 27 (145) 80-35", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("0aa1df1e-ec44-431e-bec3-84664c1bb0d3"), null, null, "+541 61 (109) 31-38", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("0aa4fa40-1d5f-4f59-9b30-c1d8818947c5"), null, null, "+500 77 (453) 37-98", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("0c2353ad-734d-42d5-b343-92618355ef1e"), null, null, "+502 87 (455) 29-76", false, new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4") },
                    { new Guid("0cb0ff44-b507-4913-bf1d-d336594f2b25"), null, null, "+872 46 (114) 25-04", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("0cc5be84-4fa4-4b56-8b8d-44b09332156f"), null, null, "+568 37 (688) 67-91", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("0cd01e01-592e-4694-aac6-1614f808891f"), null, null, "+106 55 (690) 88-43", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("0d5d38af-28e5-4135-bb00-28d68fb83819"), null, null, "+510 75 (101) 25-55", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("0d67f190-df07-40f1-9f3e-68263fa08e1d"), null, null, "+519 50 (584) 07-29", false, new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2") },
                    { new Guid("0d6e3299-e9c2-4ca1-8c44-574fb7f12bd5"), null, null, "+36 98 (411) 33-61", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("0e5bf936-f1ec-4649-b70f-d0dd831162d6"), null, null, "+229 08 (133) 72-61", false, new Guid("8576464a-f366-4076-97bd-00c2481b9a38") },
                    { new Guid("0ea9b97e-1902-41b8-ab1b-4f43f4595c25"), null, null, "+239 17 (278) 64-66", false, new Guid("c41a987e-114e-4968-aa63-744e27096322") },
                    { new Guid("0f140bc2-88cf-4a30-916d-4a0477cf346b"), null, null, "+91 99 (453) 09-99", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("0f1ec686-741e-4eb4-ad5e-0c2381a5a328"), null, null, "+484 51 (927) 10-45", false, new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588") },
                    { new Guid("0f84dada-8a72-4c3e-8b3b-5c07f4d6d9e1"), null, null, "+76 38 (666) 24-54", false, new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92") },
                    { new Guid("0f89392c-5a20-4651-8a01-a19ef5b22952"), null, null, "+426 04 (016) 26-27", false, new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db") },
                    { new Guid("0fedb684-6c16-4b82-b487-1ba88b5df4a1"), null, null, "+728 08 (668) 55-20", false, new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6") },
                    { new Guid("10848f16-bd01-4b68-8a14-ca988d178555"), null, null, "+370 23 (632) 14-48", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("10ef806b-1565-4847-8467-02aeb45c3d99"), null, null, "+587 68 (698) 95-00", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("1123f808-8955-4355-9531-ccc490b8ac41"), null, null, "+572 49 (395) 84-12", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("1161392e-e0fd-4a48-85c8-805575e29df7"), null, null, "+575 23 (972) 91-90", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("1173de7a-da5a-46df-aaf2-185de49d2df3"), null, null, "+882 50 (185) 15-64", false, new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036") },
                    { new Guid("11ded598-e87e-465d-9cc7-de56e25f6c5f"), null, null, "+371 18 (253) 08-19", false, new Guid("ec149744-9128-4f41-875a-1c96bf1c851c") },
                    { new Guid("12004934-782d-453a-a403-47678e0eed2a"), null, null, "+726 68 (312) 43-30", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("12911e46-1a6c-4b17-9a89-ab9e704fa401"), null, null, "+220 33 (017) 53-27", false, new Guid("c32606de-b224-4989-bf52-f8b3cabea595") },
                    { new Guid("12b28a0c-2a2a-4117-854b-2b5d4571a4dc"), null, null, "+26 44 (595) 93-25", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("138c5897-0b9a-46ba-a383-926fecf14b4f"), null, null, "+566 42 (803) 94-78", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("1393171d-1b42-46a6-990b-f2140ffcc726"), null, null, "+448 78 (899) 28-07", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("140671e8-a612-469d-b365-8fe18178ed61"), null, null, "+144 33 (790) 66-05", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("14de463f-b329-473a-bc41-ba0ea4afca0d"), null, null, "+938 46 (508) 23-88", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("15150669-a35e-4ba5-adec-4bd0c4c558d0"), null, null, "+845 97 (978) 66-59", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("1526ee1c-f511-44f7-ab5f-cd82793a499e"), null, null, "+690 86 (360) 41-42", false, new Guid("364df856-5357-4366-afda-cf52f25f1325") },
                    { new Guid("15b56c0c-d1f9-45ed-88ef-6df21f7ebc95"), null, null, "+468 13 (160) 06-19", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("15cf9744-ae95-4396-9d24-51cc5b6c6b5d"), null, null, "+497 33 (848) 82-03", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("16053314-1f41-45e2-8248-05babaa50971"), null, null, "+372 32 (431) 10-99", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("16275b9d-b80b-4440-bd92-73b27fca9b28"), null, null, "+774 23 (948) 93-55", false, new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2") },
                    { new Guid("16491f74-b1f8-4577-a417-92b511b83c0f"), null, null, "+314 04 (685) 89-12", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("164fe8c7-0a72-4d2b-bfe7-3837458f32af"), null, null, "+765 21 (858) 56-76", false, new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("16a29d89-7e0e-4dfd-898e-831154d79599"), null, null, "+438 65 (776) 31-31", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("17ad71cb-50cf-4e24-882c-9a9f4f1b44f3"), null, null, "+564 68 (602) 26-09", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("17b9d154-6803-4500-a95a-e0508c9a1c6b"), null, null, "+767 97 (847) 15-17", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("17c19010-a8a3-4b9b-9dfb-68089746d25e"), null, null, "+197 17 (459) 31-50", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("188da795-f62a-44c6-96d1-50246e3dd732"), null, null, "+727 63 (041) 17-32", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("18a272a0-349c-4624-8c57-52462b9431df"), null, null, "+838 57 (158) 53-80", false, new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f") },
                    { new Guid("18dc0681-f267-4550-a80a-a7064a63f0db"), null, null, "+591 99 (491) 25-09", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("19501959-4c95-431f-a1f5-5dee44804de7"), null, null, "+591 19 (063) 59-23", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("198b3177-c508-4613-b474-0a7844d73190"), null, null, "+467 34 (748) 82-75", false, new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("1a1511ff-36d3-4a4d-a859-bff039e1ea25"), null, null, "+859 28 (831) 75-46", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("1a216a6c-1481-4472-885e-0ecdce245596"), null, null, "+465 23 (585) 49-49", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("1a4ada60-69c7-4499-ba03-acba8e5c7937"), null, null, "+191 40 (812) 08-20", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("1a7fc86b-6d09-4bb1-b26e-c83e3f350706"), null, null, "+42 59 (458) 74-16", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("1a81ae38-60b7-4129-b751-56cdffd9294a"), null, null, "+130 23 (746) 23-25", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("1a97e5a0-0b2c-4f61-9177-3d221e2c8d08"), null, null, "+670 73 (202) 59-82", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("1ac1f1c1-6960-472d-a8b9-d0d253ddb722"), null, null, "+685 57 (484) 69-48", false, new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f") },
                    { new Guid("1b490630-0b6c-44ef-a915-f29787f38f07"), null, null, "+935 49 (615) 67-37", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("1c08d695-5dcd-4ba7-9447-40f83bc6ad88"), null, null, "+39 23 (117) 98-17", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("1c3991b3-a549-42e0-86d6-7ace5b83107c"), null, null, "+436 76 (685) 65-01", false, new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15") },
                    { new Guid("1c9432f0-127e-41cf-bb90-e9bb0238269c"), null, null, "+697 21 (565) 53-45", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("1cc0fdd9-807e-484f-8242-4e63effe4c23"), null, null, "+273 90 (967) 24-40", false, new Guid("82d8841b-b98c-463c-96d0-9378cf908740") },
                    { new Guid("1d38b001-b9b3-4327-a059-da1a97f1ecbd"), null, null, "+799 19 (175) 29-30", false, new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643") },
                    { new Guid("1d4cf59a-32ff-4e63-bc55-e6edea544136"), null, null, "+747 86 (355) 77-77", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("1dc9510d-e1db-465f-ad45-0a8576062626"), null, null, "+410 55 (201) 60-61", false, new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79") },
                    { new Guid("1ddac67f-cd91-44b4-84e4-92ce778592a6"), null, null, "+160 63 (891) 57-02", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("1e562023-d35e-4e07-9b40-a7231c700950"), null, null, "+802 50 (017) 21-57", false, new Guid("1ca2e699-11df-445a-8084-51598bee7020") },
                    { new Guid("1e686a89-9d91-4644-9f43-93129f2cb5b4"), null, null, "+594 01 (225) 09-10", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("1f0b17df-bfb3-4e9a-a026-150234064c59"), null, null, "+379 95 (795) 47-16", false, new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3") },
                    { new Guid("1f5ca124-ea7f-4ac0-a1ad-ae8e5b7cd90c"), null, null, "+421 62 (081) 48-90", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("2012f7ec-704e-4f6d-9ce6-4a0664f82bb7"), null, null, "+199 47 (612) 33-81", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("20554a2d-d4c5-4e95-8ea3-994cabd6e8e5"), null, null, "+971 57 (350) 88-45", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("206870e8-ef89-425b-bf6e-8109be628bd6"), null, null, "+385 44 (670) 84-07", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("20b1c94c-d42a-4a82-85e4-bc28ddcc588d"), null, null, "+402 91 (973) 92-35", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("2103d74b-d969-4e0e-bd9f-686d73f9b81e"), null, null, "+840 91 (940) 78-31", false, new Guid("285d8d29-53de-4979-a403-f61b887fa207") },
                    { new Guid("2154b2a7-f7c7-4dfd-bd3a-355fe247183b"), null, null, "+932 17 (244) 40-16", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("21777d50-2c7a-44f5-9357-3f5bf53fcf87"), null, null, "+938 41 (175) 88-66", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("218ad118-3012-433b-a21c-c1a15ee7ff49"), null, null, "+96 58 (432) 95-28", false, new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267") },
                    { new Guid("21941437-0ede-4827-80f2-089decef3da8"), null, null, "+687 66 (306) 37-29", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("21b5584a-7a2f-45b3-9947-11be53bae451"), null, null, "+13 62 (144) 75-14", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("21e8076c-5812-424e-a4f9-aa78a4c5cc01"), null, null, "+152 38 (572) 71-85", false, new Guid("01a8bd37-aff4-4aac-8218-b782c941985f") },
                    { new Guid("2211143e-3c1f-4692-9bfd-457887d28385"), null, null, "+446 24 (345) 62-31", false, new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca") },
                    { new Guid("222a35c2-d857-4a10-bb34-1a85f70ced56"), null, null, "+366 73 (731) 71-34", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("22b8deb6-90f6-4573-9eec-26dfab68b247"), null, null, "+386 23 (206) 23-16", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("232a468d-da75-4f75-92bb-2067fab7934c"), null, null, "+115 35 (245) 04-76", false, new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9") },
                    { new Guid("2395fd47-e929-492d-8d80-9bc5787f90f8"), null, null, "+143 70 (488) 50-49", false, new Guid("316bd6de-f98f-4240-856b-7b943204b4fb") },
                    { new Guid("2399f9bf-c15e-41e9-a4ef-4d8f437e3ae4"), null, null, "+86 66 (848) 05-37", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("24009177-4650-499d-b36d-b5f2ffd81102"), null, null, "+319 71 (227) 59-18", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("241362ac-e6df-4d6b-94ba-2d01442f3c7e"), null, null, "+260 21 (595) 46-14", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("24717699-37e7-4274-85cd-85c36bfd7944"), null, null, "+310 49 (700) 34-60", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("24c6b453-f4e0-4eef-8d2e-1f11d2b93312"), null, null, "+29 16 (087) 83-14", false, new Guid("8b33c91c-7ecd-4ec4-afc9-a9f5c4c85d15") },
                    { new Guid("24eb1c0c-8c0a-4ba6-bc98-87bd3f057bf1"), null, null, "+658 23 (800) 08-52", false, new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc") },
                    { new Guid("25d9f331-7481-4ba3-8179-a1933f039ac5"), null, null, "+258 98 (540) 23-59", false, new Guid("8576464a-f366-4076-97bd-00c2481b9a38") },
                    { new Guid("25ee3e5c-bc69-46c1-afbd-c64846ebb8df"), null, null, "+968 46 (598) 89-40", false, new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549") },
                    { new Guid("260c1dd2-f768-40b2-b321-c0f8386f995b"), null, null, "+498 07 (969) 13-06", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("2629a9a0-8a0a-4752-894d-cc76df712c30"), null, null, "+913 11 (001) 99-52", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("2667d424-3de4-41dd-834d-110fbc3a50a0"), null, null, "+36 29 (326) 05-11", false, new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8") },
                    { new Guid("26e765bc-7890-4d8e-94d7-88a7616abaa5"), null, null, "+603 71 (785) 20-17", false, new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("27055dd7-cb9b-4709-9f44-c383ea16c551"), null, null, "+150 05 (169) 85-83", false, new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c") },
                    { new Guid("2756b204-2725-40b3-9daf-63f2173f6d92"), null, null, "+496 86 (858) 18-02", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("27902caf-bbd6-4a6e-a2e2-e330b8f805eb"), null, null, "+407 84 (543) 93-18", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("27c5ddc8-3643-42f7-b9b0-c76eb0552125"), null, null, "+411 43 (891) 00-47", false, new Guid("285d8d29-53de-4979-a403-f61b887fa207") },
                    { new Guid("27f068ba-2f0a-414f-8f09-c834c25b8b49"), null, null, "+462 70 (370) 51-45", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("285692ee-e3a1-43a9-91d4-e649d8df49d1"), null, null, "+18 17 (340) 39-39", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("28780e9c-a4e5-4bce-8501-08d7a75ca2b5"), null, null, "+72 16 (798) 78-04", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("28793184-3244-4197-920c-08d64d53badd"), null, null, "+2 81 (375) 88-15", false, new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5") },
                    { new Guid("290e4746-a6a5-4de5-a2c7-56a86b16dea4"), null, null, "+69 34 (397) 43-85", false, new Guid("0883c991-1125-4309-af2f-b659b1cf5fd2") },
                    { new Guid("2924abad-75ff-49d5-ab2d-7bd339ef447a"), null, null, "+676 10 (698) 23-90", false, new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105") },
                    { new Guid("2940e21e-38c9-4af1-a383-1ea4ca157bb7"), null, null, "+659 84 (673) 09-03", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("298a82f9-64b1-4b61-882c-86c392b1b928"), null, null, "+819 10 (926) 68-48", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("29b2fc73-d8a1-4a8e-a063-32c5eccc03b5"), null, null, "+443 75 (038) 31-63", false, new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163") },
                    { new Guid("29b6e51b-498a-43cc-bcb9-64275b56bbbc"), null, null, "+455 06 (204) 56-99", false, new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4") },
                    { new Guid("29c4b2e4-9256-4a99-8e81-66bddfc0692c"), null, null, "+862 70 (935) 93-23", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("2a0658d4-7a8f-49bd-b97f-28eb3215b773"), null, null, "+630 93 (386) 14-38", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("2a67f29c-3ab1-4ad3-afb6-d54a3fdb4881"), null, null, "+275 78 (296) 75-41", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("2a6813d6-c74e-403c-934d-585825c1dca2"), null, null, "+778 94 (144) 99-91", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("2a6829a8-a0d7-4377-9499-e2198eb01a24"), null, null, "+892 97 (427) 07-35", false, new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc") },
                    { new Guid("2aee1c79-851a-48b8-9096-b043ab57b368"), null, null, "+185 10 (214) 27-14", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("2b46b367-f6a3-43a4-b3de-cbed6e0eba8e"), null, null, "+303 06 (722) 78-57", false, new Guid("26e9f9a9-c77f-4f47-b594-e602be058706") },
                    { new Guid("2b46bda1-4368-4069-9267-98cb47eb5015"), null, null, "+168 30 (998) 40-22", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("2be46195-83e9-40a3-91d6-db110ee7dbf2"), null, null, "+371 27 (388) 67-73", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("2c378818-626a-4e64-955e-24f13d18f131"), null, null, "+200 31 (528) 49-07", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("2c955b3e-2005-4344-b7f8-f7756a8b8c1f"), null, null, "+613 79 (642) 01-50", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("2d66eb60-36f2-4420-b2b9-4b54fb3ac0d5"), null, null, "+642 22 (729) 33-42", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("2d862d59-c87e-40f4-b674-f7174d930292"), null, null, "+980 10 (311) 05-30", false, new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d890bf6-38ae-4590-95ec-9546c4257f0f"), null, null, "+105 57 (518) 26-21", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("2da908dc-99b9-4a57-8403-6e555f3ae807"), null, null, "+657 85 (894) 90-86", false, new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0") },
                    { new Guid("2dbd32fd-5bcb-4249-8929-2d3bd0060efb"), null, null, "+348 50 (304) 97-80", false, new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0") },
                    { new Guid("2de6b448-084b-4c3f-a951-c63b84bb8dc0"), null, null, "+580 20 (448) 07-82", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("2dff4ff9-0ed5-402a-ac8e-dd65efdf8508"), null, null, "+421 22 (269) 10-16", false, new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443") },
                    { new Guid("2e1ce50a-f877-4a84-a84f-7329ee0effd8"), null, null, "+132 51 (129) 17-22", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("2e48b8fd-367c-4998-94d0-a78820969be6"), null, null, "+550 17 (067) 04-94", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("2e6a7a1b-d635-4b72-830a-40a869212093"), null, null, "+444 14 (360) 92-50", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("2f12b579-561a-4ba2-8114-97b616201af4"), null, null, "+408 71 (048) 72-83", false, new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35") },
                    { new Guid("2ff6b638-439c-4640-bccf-456eefe32747"), null, null, "+282 28 (741) 14-59", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("30234ac8-8c1c-4891-a1a1-1708c4c131da"), null, null, "+807 80 (931) 31-35", false, new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b") },
                    { new Guid("30ac62c4-dd48-4f8b-a59e-c3444916ecac"), null, null, "+5 18 (724) 12-46", false, new Guid("0144dc4f-2456-4e35-af3d-fc3b65da31e4") },
                    { new Guid("310ae10c-d896-449d-b8d9-3155891e38dd"), null, null, "+799 02 (087) 24-46", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("31a8900d-4309-4aee-89ff-8c15e60365b1"), null, null, "+747 67 (468) 81-68", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("32042108-c22e-42a3-a264-018ef319b7e3"), null, null, "+420 70 (058) 64-26", false, new Guid("62c45d90-c24b-4dee-a5b5-bdc39a7e3fa8") },
                    { new Guid("326d4cf4-fa54-4858-a8e8-edfd1da79d94"), null, null, "+790 34 (080) 95-08", false, new Guid("c73bd258-469c-4d46-ad89-cd1119310c49") },
                    { new Guid("32b6d781-b970-4568-bb7c-71279e126ad1"), null, null, "+338 86 (251) 58-17", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("33088b85-6f29-4cc2-b6df-a12207ad953e"), null, null, "+977 20 (920) 26-18", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("336b196c-82f4-4cd8-b1ac-1da210ba2b17"), null, null, "+437 75 (375) 97-08", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("33f75076-7427-4345-8ecd-2ab3bc87e468"), null, null, "+326 28 (874) 35-31", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("33fd467a-8c89-4d06-8331-63545206715a"), null, null, "+341 70 (202) 75-00", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("346088e0-0572-4323-a38b-0c4dfed44779"), null, null, "+740 14 (732) 85-92", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("352d8013-a0df-4de8-88f6-674d33d8bdee"), null, null, "+132 64 (305) 72-97", false, new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") },
                    { new Guid("353e7e3b-00a6-4604-b65d-a4e35ca4a68a"), null, null, "+802 96 (626) 03-62", false, new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808") },
                    { new Guid("3550c7e0-c826-4016-8ca6-839ac348e51a"), null, null, "+163 41 (908) 34-03", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("3560205e-2b97-4002-857f-633434c66a15"), null, null, "+609 22 (379) 03-52", false, new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("35a03690-04fe-440d-8578-aee69a3656cf"), null, null, "+76 73 (367) 10-27", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("35a5dec7-3081-4bde-accc-c85ed50b16b7"), null, null, "+71 26 (711) 06-44", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("35c00451-f9fc-4f36-a475-88cdae400180"), null, null, "+402 14 (900) 57-54", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("35f2b8da-4d3e-4f3a-9925-2478398c4a11"), null, null, "+455 86 (813) 71-34", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("3612e559-a952-48ed-8940-98210adad808"), null, null, "+291 63 (077) 25-76", false, new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb") },
                    { new Guid("36347ca7-e86f-43e7-8b5b-c7f724499704"), null, null, "+253 34 (126) 94-11", false, new Guid("354e9bbf-de43-4345-a871-f0af96ec9410") },
                    { new Guid("365a0363-ca43-407a-a9db-7bd3897b11db"), null, null, "+580 73 (453) 94-77", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("36d9b970-7732-46ed-adb6-e8bc00daed0e"), null, null, "+356 92 (875) 39-98", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("37296eaf-455d-43fc-9ccc-fa53ee630eb3"), null, null, "+739 03 (205) 19-88", false, new Guid("60f7f230-ff82-425a-a6c5-cc5156098000") },
                    { new Guid("3739bb5d-c13e-478f-980f-c3f5be090354"), null, null, "+243 12 (167) 97-05", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("3782f258-6a6e-477a-9d4a-d067fe474223"), null, null, "+206 36 (442) 50-60", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("386d5388-eb25-4846-8e65-59a3200c1a74"), null, null, "+457 64 (032) 44-77", false, new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276") },
                    { new Guid("3873b8b7-cbea-463a-b238-f0d9fd77325b"), null, null, "+541 90 (847) 43-27", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("389b6f74-67da-4af6-bfcf-0f083544dd4c"), null, null, "+561 08 (056) 27-91", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("38e3bd16-f843-4d07-a08f-579151396ae8"), null, null, "+898 17 (397) 23-55", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("393793e8-4a4f-4f70-bada-bb8326c2e7c0"), null, null, "+157 71 (218) 59-99", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3949943b-2e32-4667-893e-7bf2d24e1e2a"), null, null, "+457 96 (556) 04-10", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("398a036f-c216-40ec-95bd-a2da7a5afadd"), null, null, "+550 37 (876) 47-08", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("39da5be5-9577-42af-bde7-a1ec1ff38fde"), null, null, "+918 33 (681) 14-96", false, new Guid("2a307cb5-fe64-48f5-98e9-26014e2e9c79") },
                    { new Guid("3a3d3bed-fea4-4167-99e5-4f36c6faf2dd"), null, null, "+314 58 (202) 22-96", false, new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2") },
                    { new Guid("3a63b3d1-ed5f-4674-ad45-4cb0e90d540a"), null, null, "+882 04 (933) 46-79", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("3c5d8016-a45c-4e62-a69c-49dda253530e"), null, null, "+448 71 (224) 61-79", false, new Guid("4390173e-3194-44b0-9f5c-e816c829e49d") },
                    { new Guid("3c5df7ed-fb86-426a-8bff-74415f693da4"), null, null, "+11 82 (605) 13-28", false, new Guid("70ae5352-fc84-4d81-acb6-c5e9b0fa75d2") },
                    { new Guid("3cf608b0-59ed-4467-a131-0ea044af7967"), null, null, "+80 13 (595) 62-42", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("3d55ef94-601c-40ef-9fb7-05f3d25c06b3"), null, null, "+786 45 (269) 44-14", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("3d57a562-c6b8-4869-ba62-10b12c785d27"), null, null, "+970 86 (943) 44-17", false, new Guid("787d2d2c-d05b-4935-906f-090d713b622f") },
                    { new Guid("3ef59b9b-c88e-4a9c-b583-52a78bc88752"), null, null, "+390 39 (861) 96-47", false, new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd") },
                    { new Guid("3f2ecb1f-4e04-4cf0-9216-174817b4b72a"), null, null, "+434 16 (314) 05-10", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("3fccd593-c905-4fb7-a12b-9fa4ebe07ae4"), null, null, "+835 12 (402) 27-21", false, new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1") },
                    { new Guid("40220efe-b4f7-41a6-ad1d-49f40f7b4eab"), null, null, "+857 91 (678) 61-26", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("40719ea0-ec7b-4319-9542-d61ac491cc09"), null, null, "+860 43 (738) 53-70", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("40dbd436-1abb-4e4f-b3df-8f0dc0c76d3e"), null, null, "+453 45 (300) 50-42", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("4122e3e7-98de-4202-bec6-dc01969bf7d0"), null, null, "+932 61 (748) 29-81", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("419d6325-e1a1-4571-80c0-6110e4456aac"), null, null, "+774 13 (164) 67-61", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("41ae6f1b-c480-4c91-b2f4-5e761c7de6ae"), null, null, "+167 84 (220) 07-48", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("41eb303c-c988-4ae3-9947-ed43e9d17614"), null, null, "+508 87 (268) 63-03", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("42c003b3-e2ca-4d50-b10d-fccc1e751388"), null, null, "+753 72 (337) 40-59", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("4369e931-ccf7-4c7d-86d2-38322e230dcf"), null, null, "+182 29 (163) 07-05", false, new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("4393795e-6c26-4043-b671-89a731759687"), null, null, "+97 76 (038) 13-88", false, new Guid("c41a987e-114e-4968-aa63-744e27096322") },
                    { new Guid("43dd8143-f1b4-4295-987e-ddfd0395d26b"), null, null, "+662 34 (645) 12-06", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("442d19cb-c045-43ef-a0d9-f255704bcd45"), null, null, "+399 48 (794) 55-68", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("44635230-e618-43ab-8227-564f1f71d658"), null, null, "+720 94 (582) 97-03", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("44793d1d-858b-44f8-975f-0802c50e7945"), null, null, "+658 61 (391) 54-66", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("44a13c1f-a47e-4f14-b8ee-e5c778913b51"), null, null, "+876 28 (517) 47-86", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("44af37e3-f913-41b9-ac53-04e5c19489d7"), null, null, "+343 34 (518) 77-83", false, new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361") },
                    { new Guid("44ca6e68-9272-4fff-b41c-357db21fc9bd"), null, null, "+884 54 (090) 64-10", false, new Guid("3312b428-b5d5-467f-86d1-58d90fdd1643") },
                    { new Guid("44e79a95-a509-4f9f-b162-87d0fee502e0"), null, null, "+583 05 (991) 19-23", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("451dc9d9-64cf-48e9-bfef-6bfb1eed42cf"), null, null, "+308 97 (588) 64-41", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("452d9dd4-3f15-46ec-a48d-0276b7b1dd36"), null, null, "+450 45 (156) 47-56", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("452fdbdf-074e-4263-a268-ec919469bf81"), null, null, "+187 46 (035) 96-68", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("45552001-b8cf-468a-9502-013e37d1dd15"), null, null, "+391 24 (547) 97-01", false, new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd") },
                    { new Guid("457f4af6-760f-47fa-bdaf-510e8ba9b7d1"), null, null, "+281 03 (003) 44-45", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("45823db4-fa64-49df-a7e4-5786ffaca9d5"), null, null, "+883 74 (108) 07-25", false, new Guid("431cb355-ae94-49cc-882c-971e60381b53") },
                    { new Guid("462af0e3-cc5d-4f68-8a4b-c4093602d07b"), null, null, "+537 17 (807) 32-73", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("46812c97-434f-42d2-a827-d9fa91492c0f"), null, null, "+347 05 (654) 03-70", false, new Guid("60f7f230-ff82-425a-a6c5-cc5156098000") },
                    { new Guid("46c86bc9-8b2d-4360-afc7-c7965b320415"), null, null, "+392 18 (858) 65-27", false, new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("46f97dba-46c6-41bc-bf2d-5ba785925acb"), null, null, "+110 30 (615) 14-32", false, new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e") },
                    { new Guid("474cc754-e906-4354-896a-4cae50d3f9eb"), null, null, "+558 32 (539) 71-86", false, new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4782b7af-e723-45f3-b49a-62d76eadbd17"), null, null, "+382 78 (044) 15-12", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("4790404c-4ad2-4674-838f-38912b3f14f9"), null, null, "+442 89 (119) 61-92", false, new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2") },
                    { new Guid("479a0b8c-3fda-4e37-83e6-e0460ca51ac0"), null, null, "+762 63 (882) 68-75", false, new Guid("b9c46fc2-c0ba-4403-82c4-05638309e0fb") },
                    { new Guid("47baf5fe-c888-4ea2-a2d5-e1707b8fba5b"), null, null, "+450 75 (352) 30-64", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("47e5d688-ee50-4cb2-a969-0224a15f4afd"), null, null, "+33 75 (227) 96-25", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("47e86c7a-6b6a-4a14-bf21-60034cd28779"), null, null, "+882 30 (979) 32-61", false, new Guid("2bec7155-1c68-4e7a-b8b4-59786051e49b") },
                    { new Guid("482935bc-14eb-413f-b881-737cb4a468b0"), null, null, "+922 49 (671) 22-52", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("4829f824-d4dd-4a46-8029-14fe09b34bf9"), null, null, "+385 91 (620) 68-10", false, new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("483ee429-cac0-46fd-b1f2-cf0287072c87"), null, null, "+29 00 (594) 00-99", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("486ed7cf-b780-4381-8051-7537ec79ea22"), null, null, "+31 37 (534) 73-79", false, new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457") },
                    { new Guid("4881d715-1839-4149-8591-4c387f989fbe"), null, null, "+872 63 (403) 77-91", false, new Guid("9683b3eb-98aa-43f2-9467-64963d5528bc") },
                    { new Guid("495c2eed-7b9a-4e64-b075-2d33fa013abf"), null, null, "+558 51 (214) 55-72", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("49ee3c01-24b1-4962-8e82-875da47289bd"), null, null, "+66 99 (694) 00-92", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("4a63893a-f503-406f-a666-c09d97b9609d"), null, null, "+782 40 (942) 09-84", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("4a821512-7083-441c-a567-f0db16cc012d"), null, null, "+968 20 (226) 14-88", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("4af44404-e965-4a7f-8805-3fee49572061"), null, null, "+129 29 (867) 78-19", false, new Guid("aa8abf01-93a2-4d0e-8a10-082d9319f63f") },
                    { new Guid("4b441d1a-b2b2-4eb5-bfce-11ebc1730f64"), null, null, "+554 85 (308) 83-15", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("4b8efda3-4508-4240-894d-f28b831a5dc3"), null, null, "+161 97 (287) 69-72", false, new Guid("316bd6de-f98f-4240-856b-7b943204b4fb") },
                    { new Guid("4bc1b596-fbe0-40fd-8802-3aaaafbc1645"), null, null, "+299 94 (981) 47-91", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("4be1e0d6-bde8-447b-a250-7d326045413b"), null, null, "+388 15 (014) 53-32", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("4bfe344a-ebce-4c23-a909-5671e933fcc2"), null, null, "+772 40 (405) 98-43", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("4d1d4dbf-ac22-4ce1-852e-f78bd3c7f3df"), null, null, "+558 97 (727) 67-52", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("4d3638ba-6644-462a-9138-8a38f4e7f142"), null, null, "+34 42 (751) 16-90", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("4d42ca4f-54c1-40e9-83d9-40945d305d92"), null, null, "+876 86 (374) 62-45", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") },
                    { new Guid("4d7424e6-07f4-4319-a508-9f07694be25e"), null, null, "+593 90 (960) 26-26", false, new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95") },
                    { new Guid("4dd650c1-370d-4769-863d-ec2ac011cad4"), null, null, "+691 83 (270) 87-43", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("4e188550-98a8-4998-8ff6-1a5c8b263811"), null, null, "+217 47 (408) 37-03", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("4e4d3b3b-79f9-44c5-aec7-9186edf3b1d3"), null, null, "+975 73 (104) 47-00", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("4f09c297-a6c4-426a-8350-60010c48b2ec"), null, null, "+781 00 (888) 55-74", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("4f2887f3-caf9-44b1-9665-9716a00d3d51"), null, null, "+679 28 (899) 49-18", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("4f74b3a9-ef9b-4ee3-9186-210f7735e995"), null, null, "+457 54 (081) 61-93", false, new Guid("088b0355-11a0-4c5d-9df6-3d9bb4311361") },
                    { new Guid("4f9c5c11-afa8-4ec5-b476-adf5cd0e0430"), null, null, "+974 99 (949) 26-42", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("4fbc7ffa-1577-4a86-860f-7660b40139fe"), null, null, "+331 77 (892) 29-92", false, new Guid("4bc48bed-c113-458c-8a12-8f12565a542b") },
                    { new Guid("4fc150e8-861a-42f2-922f-28d544e59c9a"), null, null, "+771 26 (202) 06-62", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("5034bbd7-7a15-4f6f-b841-a12c623ea154"), null, null, "+671 08 (695) 70-92", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("5042c83c-3c36-4fbd-bb95-70988eb12247"), null, null, "+667 73 (266) 93-78", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("504d1cf7-c4a2-466c-8be0-baad52bdb181"), null, null, "+336 28 (324) 96-77", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("509f4c3d-f1b2-4fc6-b15c-77e40402d788"), null, null, "+663 68 (382) 03-32", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("50c70f38-2e43-476f-8a43-412fe1d0d3c6"), null, null, "+817 82 (653) 40-45", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("5154e0b0-2653-453f-9785-88ad65d3b471"), null, null, "+828 25 (276) 80-31", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("5178a428-0967-463a-b6c4-c1c675103af4"), null, null, "+328 74 (018) 72-48", false, new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("51ddb011-17c9-4709-b57f-ee0011b4a0c0"), null, null, "+800 26 (566) 25-36", false, new Guid("c9809439-c97d-49ed-b84a-66149d142e46") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("5257b7c9-8f9b-451c-aa42-8494698efacc"), null, null, "+618 59 (549) 56-97", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("52595e19-4fab-407a-bb2f-be70a1a0e6d5"), null, null, "+616 77 (178) 39-47", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("52c07213-7561-4e2b-af30-3dcdfb69ba2d"), null, null, "+207 33 (039) 23-53", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("52d013eb-f09c-4f3d-bcf1-a03e20e7c4b7"), null, null, "+644 12 (248) 84-35", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("5343b6da-2a6a-48d5-9e59-320241f6e560"), null, null, "+468 65 (495) 61-09", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("53592a79-9e6e-4e05-96ca-f96d348a943e"), null, null, "+431 78 (891) 12-19", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("54213c99-7a31-45f7-a174-8fe580756683"), null, null, "+90 23 (825) 16-62", false, new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50") },
                    { new Guid("546db22a-65c4-46b4-b04d-eadd5210315e"), null, null, "+927 43 (964) 33-86", false, new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1") },
                    { new Guid("556dc524-43d6-4647-a1fb-2e7f036fd4d2"), null, null, "+753 05 (813) 94-59", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("567250cb-a2f8-4bac-a6e9-c085da2008ac"), null, null, "+160 79 (422) 08-45", false, new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") },
                    { new Guid("56dd3bbf-0ed9-4f32-84e7-2dddb0c8b804"), null, null, "+292 92 (716) 28-86", false, new Guid("b74d612a-560a-493f-9b9a-e7d76b857600") },
                    { new Guid("577fddae-a105-4b6c-bcbf-41700a6c02de"), null, null, "+579 98 (585) 56-14", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("57fb62f2-9e55-49a9-8a62-f5937a10e111"), null, null, "+747 67 (159) 90-16", false, new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259") },
                    { new Guid("5848538e-f3ef-4d7a-b88f-7587aa299a15"), null, null, "+22 37 (321) 01-17", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("58487fdd-4f54-4018-9aaa-6eb703828d5b"), null, null, "+733 88 (727) 88-21", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("58c2f22a-7c69-4719-ab0f-d13c42c80c84"), null, null, "+113 13 (834) 80-65", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("595806bf-a3ac-4e4b-8c28-36dc96a47c65"), null, null, "+177 12 (552) 85-34", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("596b1ed6-4faf-4f30-a984-033e697eede2"), null, null, "+462 82 (632) 16-00", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("596bca40-a47d-4dc1-9609-d6667a17ab17"), null, null, "+819 07 (845) 29-83", false, new Guid("b74d612a-560a-493f-9b9a-e7d76b857600") },
                    { new Guid("59c76253-7447-4c1b-838b-edd3742a429b"), null, null, "+839 23 (585) 51-90", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("59e59f83-d581-4ec4-95f1-4fb6dadac218"), null, null, "+530 10 (410) 31-90", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("59eece2f-bd38-433e-bbef-a89a2beb0156"), null, null, "+311 18 (908) 08-90", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("5a06086b-d632-4c8c-b94a-e07da7765194"), null, null, "+226 95 (167) 90-42", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("5a40a691-c581-48a6-b7c6-77639160b016"), null, null, "+653 01 (233) 63-80", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("5acba11d-67ca-458b-b7c6-239c89e46649"), null, null, "+406 42 (017) 01-39", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("5affb387-d08b-4e78-b4bc-5d17c1600046"), null, null, "+566 10 (597) 37-00", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("5b7364f8-ed83-4c08-a562-179bb5c8f680"), null, null, "+101 46 (666) 62-36", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("5c256dbb-cf4c-46a4-9acc-4b34fdf32d3d"), null, null, "+415 75 (605) 05-69", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("5c4cdd89-c9c9-4b72-a60a-713926d07f09"), null, null, "+187 06 (691) 87-34", false, new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("5cd691c9-e01d-4d99-9822-54bc1920ef8b"), null, null, "+148 56 (035) 59-15", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("5d249233-dbed-4c34-9c7a-acc047d10f5d"), null, null, "+469 15 (113) 32-48", false, new Guid("27242341-84fa-4a7e-9bfe-e0f6913d66bd") },
                    { new Guid("5d3270f8-5923-4a98-9b10-1415c36d741d"), null, null, "+523 81 (985) 38-51", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("5d57f4af-7b04-4ed7-b159-2b5c6f1dcee7"), null, null, "+103 17 (704) 81-30", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("5d8986ee-9c96-48bd-b901-763d8f9f7c1c"), null, null, "+950 35 (028) 90-58", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("5d96cc56-b520-485a-9212-6e4baddc1fd3"), null, null, "+21 41 (998) 96-65", false, new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee") },
                    { new Guid("5e5a7c3c-6450-4d80-9f2f-ec640cfec7a2"), null, null, "+622 63 (925) 39-48", false, new Guid("a836bc35-12f7-485d-861b-ad1645878c24") },
                    { new Guid("5e6a631f-df8e-4cbe-9b8a-043e0a085a32"), null, null, "+810 64 (733) 81-60", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("5e71835c-d80d-4421-aa87-396d6c5a33ce"), null, null, "+747 85 (655) 85-94", false, new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb") },
                    { new Guid("6003b825-9085-4e7a-aafc-86db888c1b2d"), null, null, "+170 82 (517) 21-46", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("606cf4af-1006-4e9c-ac70-b4086d02767d"), null, null, "+989 79 (607) 60-16", false, new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("607e8661-a412-4e1f-8e68-32c6bcaced2d"), null, null, "+972 67 (596) 33-45", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("611b35ff-806f-43fe-af3b-ae897ac77aa5"), null, null, "+379 10 (733) 44-24", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("61329ead-fa2e-4f70-95ed-fe76a21d7d85"), null, null, "+680 52 (956) 23-12", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("616d49b6-a8f9-4262-8f54-09e242bda64d"), null, null, "+643 27 (680) 75-71", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("616ef134-7755-4500-a641-44c0e769601a"), null, null, "+34 34 (211) 70-87", false, new Guid("411b5dd3-a249-4fdc-a3c9-ed24510c7e95") },
                    { new Guid("6188e104-ef83-4c4a-b7b0-e892211bba59"), null, null, "+952 24 (996) 69-58", false, new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7") },
                    { new Guid("61a22e90-04d2-4fef-9aad-103889888b97"), null, null, "+623 08 (345) 96-65", false, new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841") },
                    { new Guid("6250a57d-3c67-4224-b231-23b47c442494"), null, null, "+753 80 (318) 86-54", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("625514b3-1658-418b-9aac-847f533ca097"), null, null, "+390 65 (657) 40-13", false, new Guid("fa64f167-af58-425d-8dce-93642bd7650a") },
                    { new Guid("629d042c-16bd-410f-9230-5ec2346c9f97"), null, null, "+624 46 (309) 51-38", false, new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("62e5c0bb-9a5f-4329-b5cb-ed1295bd3a9a"), null, null, "+112 49 (281) 41-43", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("632de805-87d2-4570-bb7e-6481a8b32f5f"), null, null, "+302 03 (328) 84-56", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("634752d5-5ac5-43fd-84c0-f01fd7b341ef"), null, null, "+55 28 (295) 71-19", false, new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9") },
                    { new Guid("63958fd3-4dad-44b0-bf6d-04641780169a"), null, null, "+507 21 (913) 90-15", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("63f9c843-b323-4711-ab87-37b6d0f34ade"), null, null, "+287 36 (958) 98-95", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("64c51404-459a-4e0a-bfeb-80cb0a4a26cf"), null, null, "+184 24 (824) 36-78", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("657e07da-6e4f-4020-a1b8-0ad7d3a113f1"), null, null, "+221 63 (532) 99-12", false, new Guid("4d22d5ba-86f3-4a74-ac02-a2ef9ac02443") },
                    { new Guid("65a6dbfe-4909-4284-a068-8ce8e6746949"), null, null, "+684 18 (532) 09-75", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("65b21b24-99e7-4884-badd-c652adc62e05"), null, null, "+821 48 (735) 26-84", false, new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a") },
                    { new Guid("673e41ef-20b3-44a2-bfac-b930bb6d2444"), null, null, "+19 32 (368) 36-02", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("67c0e347-f8ee-4fce-9600-5ae1d3627956"), null, null, "+100 99 (847) 62-19", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("68089b40-eeec-44cc-9daf-faf0d50ff5c7"), null, null, "+936 79 (564) 98-88", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("683e2620-120d-4e57-a5db-8e4fefd2adad"), null, null, "+546 58 (962) 79-45", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("685b8cc3-a7e9-4c59-b612-638fb0fa5f6d"), null, null, "+38 26 (135) 72-37", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("6881f975-a5e2-48e8-a583-13f5f230da38"), null, null, "+86 88 (723) 98-98", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("68b65dbf-99cc-4de2-b357-3297a5108aca"), null, null, "+904 70 (740) 51-81", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("68be08a8-a75e-4726-ab71-d44c192aa722"), null, null, "+699 58 (147) 34-28", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("690c96e9-656c-46d1-853c-5017a97b55ec"), null, null, "+503 68 (317) 51-42", false, new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("691f4bfe-d76e-4928-92b4-1161208dbd04"), null, null, "+678 21 (427) 98-97", false, new Guid("dbfa427e-5cd7-401a-bf2f-127a80954267") },
                    { new Guid("6931421f-fa9e-4774-aa86-57939c2fee15"), null, null, "+476 26 (819) 03-24", false, new Guid("9af0b293-ca77-4ff4-b876-5ed385ea54f5") },
                    { new Guid("699a1634-9f9a-4ec4-8af3-936afabc4a35"), null, null, "+157 40 (358) 68-48", false, new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8") },
                    { new Guid("6a046c87-c0cd-4456-a927-6a229f41e5c0"), null, null, "+672 72 (597) 61-99", false, new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("6a59a727-8225-42f9-8d9f-ebc8a4128316"), null, null, "+588 18 (442) 24-97", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("6a71937f-a4f3-4189-bd61-28f4f72982fb"), null, null, "+347 64 (472) 26-24", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("6aa8fa28-0d73-4e03-a02d-ce92888e2ec3"), null, null, "+959 16 (830) 35-95", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("6ac5d5e0-21a0-43ac-9dcf-8052bfd0d750"), null, null, "+149 06 (261) 33-39", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("6b61e440-882f-4f03-8418-4a87e8d0d2f4"), null, null, "+803 47 (374) 24-31", false, new Guid("c9c8216d-f600-497c-9d93-dc38cc0827c6") },
                    { new Guid("6b7eca87-f609-497a-a2c4-71b69826dd0e"), null, null, "+380 61 (172) 82-09", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("6bd9ce49-487f-4d0a-8c21-2c7553f6f52c"), null, null, "+752 85 (014) 02-46", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("6c0c7086-f7ca-4dfa-a908-f65acdc54ed6"), null, null, "+901 24 (064) 08-38", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("6c4bd6ee-f54d-4eca-9543-9b1eb1ee99e1"), null, null, "+377 59 (967) 10-23", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("6c55d6e0-4195-418d-a4a3-9624a65bc75b"), null, null, "+663 57 (213) 89-05", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("6c95fb0a-858a-4031-9d24-11adca5fab4a"), null, null, "+875 38 (214) 24-55", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("6cbf3dd1-d65b-434e-8a61-f256fdca8445"), null, null, "+383 13 (890) 33-42", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6d297b4c-c0fa-4ea0-a342-5a1445221dfa"), null, null, "+847 60 (897) 09-65", false, new Guid("100f1446-94ed-4e4a-9ded-648bb0b37cf0") },
                    { new Guid("6d480125-318a-423d-9a26-00e52750ac23"), null, null, "+249 90 (305) 37-40", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("6e18036c-cd90-4e34-a20f-8f5ea1233a87"), null, null, "+264 30 (048) 87-48", false, new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("6e960068-c1ea-4e9d-871a-b57a287c52d5"), null, null, "+653 57 (596) 41-08", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("6f03494a-5f4f-4469-a23b-1059d4092d30"), null, null, "+793 04 (821) 31-54", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("6f3daca9-0150-4dfe-bae8-57b01924dc0f"), null, null, "+963 56 (733) 63-51", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("6ff58d52-1834-4352-a2e2-fe3bbe3957ca"), null, null, "+783 79 (705) 71-76", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("7009fae9-ca03-4096-85f9-dbf4ec29a87a"), null, null, "+433 14 (277) 87-14", false, new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794") },
                    { new Guid("701775fa-4da6-455b-b85e-571e4ed408e3"), null, null, "+559 84 (654) 09-17", false, new Guid("6bca3f34-9b6f-49ce-ae24-507d39d54841") },
                    { new Guid("70d185a7-fd74-450c-8c80-1d988c3f61be"), null, null, "+409 89 (829) 84-88", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("70e73c97-24de-4dbe-b391-e308b63ccf60"), null, null, "+793 31 (816) 36-49", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("70efbe2e-cd18-451b-820a-1e5eeb3b4e72"), null, null, "+98 50 (152) 07-16", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("714f5d7d-bd84-45a5-aa6c-6ea2c78736a5"), null, null, "+90 23 (615) 18-36", false, new Guid("71978c89-b953-4ec5-98a8-ab384223de1a") },
                    { new Guid("717f2992-7c8c-4c3e-af1a-3bcc0cae1502"), null, null, "+704 71 (737) 38-12", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("7196cd6a-502d-4b3c-b5f4-ea453184620b"), null, null, "+931 85 (744) 38-49", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("71a3ee86-321d-4194-9c60-3fcf4f6a653c"), null, null, "+700 68 (308) 99-41", false, new Guid("354e9bbf-de43-4345-a871-f0af96ec9410") },
                    { new Guid("71f300aa-bebd-4221-9e18-1f1bfc010c3a"), null, null, "+896 53 (512) 17-52", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("729391cc-207a-48b2-bfd8-706e6e3e5113"), null, null, "+5 98 (049) 99-71", false, new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02") },
                    { new Guid("72d5e765-a382-4b7e-a599-108a37c8955d"), null, null, "+933 05 (132) 53-40", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("73243b5b-784f-4318-a294-296c6f5a974b"), null, null, "+412 14 (355) 19-55", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("7329d9e8-7207-4cee-bda4-7b09aa653483"), null, null, "+185 04 (766) 34-91", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("73a3eb3c-aab4-461f-b7de-212bf79aa8f2"), null, null, "+360 80 (944) 31-39", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("74098973-f040-4820-89fc-6e3c52e42d57"), null, null, "+109 82 (716) 52-20", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("7409a41d-5b4c-42b1-9d8e-7634d97d0a1d"), null, null, "+905 22 (730) 63-27", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("7638c606-01bd-47d2-b8a9-b64f84f73f5b"), null, null, "+827 35 (812) 07-85", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("76bf0e9c-8e1a-45d4-b93f-de6217c97eb4"), null, null, "+167 02 (238) 74-88", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("77371a04-a29a-4b9f-b5e7-1682d080e422"), null, null, "+747 99 (008) 63-15", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("773e95b2-4e1c-4425-96c5-d1e0c6be5565"), null, null, "+260 84 (569) 41-79", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("77709a5f-b2bf-4058-b987-6e2b4b7b2425"), null, null, "+391 37 (223) 60-76", false, new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("777eaf76-b5e0-4849-b2f2-7ac8058bcba2"), null, null, "+56 33 (236) 68-30", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("77ab3f17-09de-4754-bb35-6b0fa7a28892"), null, null, "+866 63 (229) 76-51", false, new Guid("246ee090-764e-420d-803e-5d97e7d873a0") },
                    { new Guid("77c5cb5f-ab32-4761-a47c-8e23df0ad0a2"), null, null, "+155 73 (712) 56-86", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("77e1b8ab-d020-4a1d-b7dd-578ec6e5bfce"), null, null, "+679 32 (836) 36-22", false, new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("781713af-168c-4e2f-8a05-ff19d9867e1e"), null, null, "+184 92 (869) 42-25", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("78b46acc-b5e3-44b6-b29f-5ae96dfbc853"), null, null, "+188 33 (657) 99-34", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("78c5ba77-d341-41cc-8977-59ae29cd2804"), null, null, "+423 63 (886) 22-90", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("797cc01c-7438-4a64-9c27-63ec3d4f9948"), null, null, "+67 65 (568) 56-03", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("79cfe120-ecc9-4ce5-bf0c-850c378fa9dc"), null, null, "+680 00 (392) 84-80", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("79d85acb-4403-4537-be0a-c778d211631c"), null, null, "+284 47 (430) 00-20", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("7a063218-218c-4f33-bb5c-2cf2232d85ff"), null, null, "+85 21 (393) 95-65", false, new Guid("ec149744-9128-4f41-875a-1c96bf1c851c") },
                    { new Guid("7a47514c-8209-464b-bdfc-8ea3853388b1"), null, null, "+87 93 (625) 61-20", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("7b17c59e-4f93-47aa-85f7-b4c29bd06a75"), null, null, "+132 56 (924) 80-00", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7b4e15cf-65ee-4d9c-aa07-8b9ed671e4aa"), null, null, "+440 51 (600) 79-95", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("7b6082fe-ac67-4ed9-a477-e4514407260d"), null, null, "+401 09 (522) 64-05", false, new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117") },
                    { new Guid("7bc79b95-cb1f-4f91-a561-aad981edc6e5"), null, null, "+540 11 (336) 26-36", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("7c081629-84ca-4923-a52f-a36e96efb60f"), null, null, "+147 68 (047) 96-70", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("7c4a986a-6246-4d08-a67a-8048951637ab"), null, null, "+756 50 (557) 13-94", false, new Guid("3f3897f6-9943-4597-89e3-3a1a7c5d0ca4") },
                    { new Guid("7c4c7a31-49c4-47b4-9578-feeb88a8def7"), null, null, "+14 24 (084) 27-49", false, new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab") },
                    { new Guid("7c559033-2b34-46f1-9f29-24c2a95657df"), null, null, "+408 25 (187) 63-79", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("7c81b097-14bf-42d9-b805-89e98601f450"), null, null, "+826 88 (715) 48-48", false, new Guid("fa64f167-af58-425d-8dce-93642bd7650a") },
                    { new Guid("7cfc8afb-c61a-4330-9ac3-fd074195e242"), null, null, "+366 50 (471) 22-77", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("7d46eb92-8e8b-4ba4-9362-be5fa5043af8"), null, null, "+546 27 (936) 80-35", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("7d58e009-f191-4d18-8db0-c03b59d6ed86"), null, null, "+816 62 (409) 15-52", false, new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") },
                    { new Guid("7d632d25-9f71-4c2e-bfac-dadca7133735"), null, null, "+218 50 (688) 46-46", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("7e714d0b-ad69-4d1d-9173-8b09859130aa"), null, null, "+700 70 (052) 23-92", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("7e9ea116-f18a-4ea2-8bab-59fdbf33ef21"), null, null, "+598 94 (597) 86-41", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("7f9a4a85-4739-44bc-8865-17eb0d91f498"), null, null, "+278 59 (309) 70-52", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("803a140c-359e-4b57-ac6a-2000794629d2"), null, null, "+831 64 (848) 49-55", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("8059ec76-1d52-4c0a-93f8-e168d932dcb9"), null, null, "+897 35 (776) 50-19", false, new Guid("9ae83abf-62a2-4b15-aae1-6efb304ffbe0") },
                    { new Guid("8064f3e9-8c59-4598-9d00-28e9a39bc291"), null, null, "+324 92 (814) 08-80", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("80650497-a857-4d76-9330-7d0030cf7124"), null, null, "+625 83 (365) 27-90", false, new Guid("146db1ba-c521-4b18-b8d0-0f1db8512163") },
                    { new Guid("80a1ec66-91b9-4db0-aa8a-8c4a999baf67"), null, null, "+361 18 (693) 97-23", false, new Guid("c96d8855-9abe-4d6a-bb7f-1ae9f29418bf") },
                    { new Guid("80e9436b-cb55-490e-8cc5-955d3fdeab4a"), null, null, "+612 43 (093) 44-43", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("81219cad-e05b-49d3-a633-09f634282382"), null, null, "+571 53 (760) 29-11", false, new Guid("2da9ab08-6750-4a36-8423-df883774a78a") },
                    { new Guid("815716f9-19c7-40ec-84d2-0dc2e608b1c7"), null, null, "+35 53 (318) 44-65", false, new Guid("114ac41c-5eba-4152-8f7e-622356a03762") },
                    { new Guid("81caf895-17ff-4ad8-8d1e-f1df1beb9a88"), null, null, "+749 36 (816) 55-36", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("82389f1f-326c-4856-9666-57b5555fe706"), null, null, "+77 89 (998) 04-39", false, new Guid("0283a7e7-4e98-44f5-99b4-ccd72df3fe28") },
                    { new Guid("82545ed6-4248-4454-b755-6fc8ba2502e5"), null, null, "+719 26 (455) 32-92", false, new Guid("09fdb69a-4af9-4a72-88a7-5086ac3ba0f8") },
                    { new Guid("82f3296e-6241-4f8f-8e6f-6ab100d35b8e"), null, null, "+537 84 (679) 71-96", false, new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf") },
                    { new Guid("835fe514-9de1-41d7-aa88-cd9f3f6f9479"), null, null, "+243 08 (018) 57-50", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("83727bb8-5740-4026-a9f8-78f0326b0acf"), null, null, "+598 14 (296) 53-31", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("83b2fa42-c95f-4263-babc-f9a09c03947b"), null, null, "+722 02 (970) 77-01", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("83cddac1-9b6f-4f8e-a6e1-bbbc3ec731e0"), null, null, "+363 09 (351) 65-54", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("840f5e90-8f90-45d0-af00-b676564292fb"), null, null, "+957 46 (763) 63-43", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("8542cacf-284d-4395-b0ee-4658dc992c8d"), null, null, "+345 23 (665) 27-48", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("855a688f-ebcf-488f-907f-7d7a9cd83359"), null, null, "+886 71 (890) 59-25", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("85bd6fc5-8795-4f6f-8560-8ecaac123cc7"), null, null, "+943 28 (864) 83-33", false, new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c") },
                    { new Guid("863ed949-38ac-4e26-9079-a83799ac4db9"), null, null, "+338 15 (416) 36-15", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("86f06c6d-c92a-4269-a197-71331f658922"), null, null, "+418 11 (671) 85-31", false, new Guid("4bc48bed-c113-458c-8a12-8f12565a542b") },
                    { new Guid("8733584b-ba1d-483f-869b-177bb05395fc"), null, null, "+397 00 (052) 96-23", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("875f6d79-387a-4139-8036-8a57b9584019"), null, null, "+788 32 (758) 72-70", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") },
                    { new Guid("88b7ddee-4a57-4d68-8b31-cbdc9b5891b7"), null, null, "+592 13 (508) 61-17", false, new Guid("7dfa465d-e34b-476c-b5a3-175fbd242588") },
                    { new Guid("88be339f-177b-431b-9e80-20b614ef47b3"), null, null, "+885 13 (032) 39-96", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("8960acc6-defb-41fc-bdb8-03cb6043e94f"), null, null, "+146 56 (958) 61-88", false, new Guid("431cb355-ae94-49cc-882c-971e60381b53") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("8a22dbf4-d14d-43a2-9091-d1fec36aa10c"), null, null, "+131 03 (433) 67-80", false, new Guid("bea80970-74bf-4539-a300-cbbac8625744") },
                    { new Guid("8a4926aa-4528-41b6-84f3-f3b09d9a0f2b"), null, null, "+781 75 (415) 37-25", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("8aac2b57-030a-4e3c-b453-926f2a292893"), null, null, "+290 29 (114) 84-72", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("8ab92fba-97ce-4c77-ae99-9e04cfb9331a"), null, null, "+59 64 (473) 53-94", false, new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615") },
                    { new Guid("8afd4c4e-2e08-45fa-8ce6-d1297db0101f"), null, null, "+226 03 (962) 36-97", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("8b72b0c3-daac-4318-be57-d6b93250a827"), null, null, "+177 13 (205) 86-93", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("8bb5c5c6-6229-407c-98f0-be37417c0f82"), null, null, "+121 27 (842) 47-24", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("8bc4f0ff-624c-4f69-a84f-3066ef1e782c"), null, null, "+575 57 (806) 26-26", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("8bf44523-9004-4df5-a489-20b23563674a"), null, null, "+277 45 (896) 03-57", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("8d120741-917e-4964-8405-29daa0d25f9e"), null, null, "+876 41 (122) 96-29", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("8d6a36d0-fc86-4c0d-9071-cb6ac07f286a"), null, null, "+791 74 (666) 55-11", false, new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696") },
                    { new Guid("8d73497d-e7ae-4462-9fd6-343aba13bd08"), null, null, "+532 94 (364) 97-64", false, new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4") },
                    { new Guid("8d9a7eb0-7c5b-4437-9b4c-8e5372de78d0"), null, null, "+159 86 (102) 22-28", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("8e1a809d-9202-4092-a01b-27023f0ac408"), null, null, "+369 29 (157) 03-16", false, new Guid("273b392b-98f7-4b2e-bb14-93ac2dfe01ee") },
                    { new Guid("8e89134e-21af-497f-978e-beb0e7df9948"), null, null, "+792 66 (298) 43-52", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("8ee82ce6-2016-4c1d-aa23-239f75b44f12"), null, null, "+873 27 (315) 67-60", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("8f8e09c5-c591-44fd-8205-a3c9428f6d7a"), null, null, "+167 20 (439) 46-84", false, new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d") },
                    { new Guid("8fc4a746-3790-4fcf-ab93-9ea0e32cc09a"), null, null, "+491 84 (508) 04-00", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("9004c8f6-ace3-447d-bdc4-229875ea9529"), null, null, "+158 78 (764) 63-38", false, new Guid("c8d8416e-7941-4d1f-a69b-0940a204c190") },
                    { new Guid("9034251d-8afd-4962-877d-c946e299a153"), null, null, "+981 05 (150) 24-33", false, new Guid("51b2ead1-6bc3-4532-9a33-045394e01cbb") },
                    { new Guid("908d4611-bfec-418f-b84d-3ef47477de23"), null, null, "+801 24 (274) 28-32", false, new Guid("c32606de-b224-4989-bf52-f8b3cabea595") },
                    { new Guid("90b439e1-ef41-487e-a109-072ecb8fdba4"), null, null, "+402 25 (301) 85-38", false, new Guid("3a22ad6a-784d-45f8-81e6-03202f2839a3") },
                    { new Guid("9191e06f-f7bf-47a3-8c2e-f2769cc1a093"), null, null, "+54 85 (034) 67-74", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("920a13ff-f005-4e73-a1ea-b3a8194ce555"), null, null, "+662 88 (987) 19-07", false, new Guid("91d58128-cac7-4c6f-82ea-9889d772ee50") },
                    { new Guid("921ab53c-448b-429a-b440-6f3a2846830a"), null, null, "+317 39 (560) 11-51", false, new Guid("0aaa0e10-7990-479c-9fd3-47bc5a5aa5b1") },
                    { new Guid("923c126a-4ba3-4aa6-8af1-365ffa42b1a4"), null, null, "+855 96 (507) 24-87", false, new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd") },
                    { new Guid("924965dc-7332-46a8-a9ae-7230a90dcc69"), null, null, "+582 33 (205) 98-77", false, new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3") },
                    { new Guid("92ce2a75-c4de-4633-b026-c97477271a0d"), null, null, "+437 13 (113) 65-57", false, new Guid("5fdace82-7ea1-4225-acf4-816f7eed7597") },
                    { new Guid("93001519-6206-4a4c-92d6-092447bca2c6"), null, null, "+421 03 (697) 53-21", false, new Guid("2165cbc4-0419-4660-8e3a-ae91a6129ab7") },
                    { new Guid("93121c24-94cf-4830-902b-4c80809cf7b6"), null, null, "+378 02 (662) 44-48", false, new Guid("16ed27a3-0a4f-427f-840f-2712a035f7ad") },
                    { new Guid("932f1118-cc73-4811-aaca-2e3f8240fafe"), null, null, "+64 86 (228) 20-64", false, new Guid("787d2d2c-d05b-4935-906f-090d713b622f") },
                    { new Guid("93484117-4aaf-43d8-8d58-0348c9fc6bd9"), null, null, "+108 05 (916) 16-15", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("9376e953-e63e-4495-8a9f-37ef0e6eda62"), null, null, "+661 44 (619) 31-64", false, new Guid("b46ede9e-350f-49f5-80bc-790bfb44f271") },
                    { new Guid("93934bd7-2eb5-4177-a2a7-1c5d094ba404"), null, null, "+918 28 (099) 11-75", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("94d6562c-3c1d-4b53-b6e5-8e4f24493584"), null, null, "+782 33 (652) 27-97", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("94e3fcbb-6b7d-449f-85c8-9eb0b23cd6b0"), null, null, "+574 66 (822) 89-96", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("94ede5a0-caea-45e9-a103-42dd6fe7ac89"), null, null, "+775 40 (968) 90-59", false, new Guid("82d8841b-b98c-463c-96d0-9378cf908740") },
                    { new Guid("95259370-33d2-49e3-a598-b4b19abb8be4"), null, null, "+951 95 (934) 20-72", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("9553fbbe-c72d-4daa-8c3b-9f984d33ac19"), null, null, "+796 71 (768) 96-30", false, new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd") },
                    { new Guid("9557d30d-dabd-49ae-8c2c-63389b83d405"), null, null, "+841 65 (769) 53-41", false, new Guid("a5bae0d3-e077-4281-b4c2-cd50d4af6e40") },
                    { new Guid("9675e3e8-1844-44cd-8636-1651453ece76"), null, null, "+63 14 (472) 16-81", false, new Guid("1280e1f3-2059-4bcd-9358-d70fceeeef20") },
                    { new Guid("96b4761b-6f43-4013-9b45-a41531277065"), null, null, "+981 09 (835) 30-28", false, new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("96f61e77-7ec9-4ad9-97ee-292fb5c22e36"), null, null, "+743 64 (605) 21-70", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("97b445af-15ce-4048-a9f9-3af3e1e25e07"), null, null, "+64 55 (317) 04-13", false, new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057") },
                    { new Guid("9806b100-f701-4252-aedc-ca2bc7ca8d4f"), null, null, "+795 80 (344) 00-93", false, new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("9806efeb-1ce8-4488-86d4-a607ae4f216e"), null, null, "+791 38 (691) 34-55", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("989c5f86-058a-4c48-9de9-da8804d0f938"), null, null, "+417 99 (543) 98-27", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("98e29e90-e33e-45a7-a887-890d00b9645d"), null, null, "+823 06 (931) 21-64", false, new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215") },
                    { new Guid("98f1f06e-20bd-4ff0-9819-25e79a62349f"), null, null, "+736 43 (994) 44-92", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("990153c4-bc40-43f3-9228-9e827bd362c0"), null, null, "+561 25 (176) 45-45", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") },
                    { new Guid("9902d3e8-4b2b-4366-8b92-c4d3cc05788b"), null, null, "+658 32 (057) 32-64", false, new Guid("cfa37291-0772-47b2-bbdc-842ca4428900") },
                    { new Guid("9a3565e3-61f2-4335-904b-9684f7aaf19c"), null, null, "+752 84 (521) 18-30", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("9b4cd1db-5494-4f63-bffc-e85d6818619b"), null, null, "+972 49 (254) 99-51", false, new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a") },
                    { new Guid("9b4de070-150e-4bd3-99c3-c59b63f9183f"), null, null, "+395 33 (536) 19-98", false, new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53") },
                    { new Guid("9b5f0345-a23b-450f-b25d-91f7d19e853c"), null, null, "+148 35 (341) 62-23", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("9b707ff8-db9e-4902-99b0-bd926f6fa8ef"), null, null, "+844 68 (737) 24-41", false, new Guid("8e67e3e8-5b57-4a2f-a60f-39345da3e321") },
                    { new Guid("9bb9ea86-0ee1-4607-bedc-00861e3e8687"), null, null, "+855 09 (934) 30-26", false, new Guid("5f4025f3-d2f0-4a33-8f3d-73ad08b5cf0e") },
                    { new Guid("9c0c9430-a94c-4780-87dc-b1b64bbdbfe2"), null, null, "+220 13 (391) 67-59", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("9c95efcf-525d-49b0-8591-fbfb5c6f4bc4"), null, null, "+538 56 (631) 18-14", false, new Guid("114ac41c-5eba-4152-8f7e-622356a03762") },
                    { new Guid("9ce63471-799c-4224-a3e8-853284e57b41"), null, null, "+802 13 (663) 85-01", false, new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("9d0dbfd4-58a4-4433-8be1-f835a5089903"), null, null, "+298 84 (717) 42-86", false, new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("9d3a4280-b68a-4c4b-9774-2defaf512b3b"), null, null, "+195 18 (891) 25-74", false, new Guid("6faa4cf6-10e0-4758-8bee-6c66f3e99ad0") },
                    { new Guid("9d43851c-9d23-4fa3-9370-9a6650a32db9"), null, null, "+302 52 (043) 63-72", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("9d4e4dad-5056-41e0-9bfb-4c6996e0bbca"), null, null, "+100 15 (730) 12-83", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("9d63ffbb-5382-4351-bace-fb8dc5730ed1"), null, null, "+559 15 (782) 98-08", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("9d75e84a-43c8-4d7a-a010-a32b588d17c7"), null, null, "+555 07 (287) 81-61", false, new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265") },
                    { new Guid("9dfe3962-b9c1-42d2-97af-1960035885d7"), null, null, "+924 38 (696) 52-97", false, new Guid("7571970a-7209-4d3e-b2a2-f7444ee59c2f") },
                    { new Guid("9e119669-87b1-406d-a482-a05c9358deb3"), null, null, "+484 26 (167) 88-72", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("9e71821e-6bd1-40fe-9f35-cead57e28fab"), null, null, "+268 99 (229) 86-69", false, new Guid("8731156d-38cf-4cbf-86b6-a8085edf6968") },
                    { new Guid("9e797c50-4700-42b0-a664-45584f849381"), null, null, "+148 99 (383) 43-20", false, new Guid("56f53aea-8d50-4e3e-9a62-540a01c9fd0c") },
                    { new Guid("9e8c3622-6614-4aa8-b8be-5d2e0219d119"), null, null, "+9 74 (857) 37-69", false, new Guid("20d4c413-4a9e-4942-a590-4b6a67675891") },
                    { new Guid("9eb2cafa-4beb-47ed-a8bc-a0dc1d790c64"), null, null, "+472 24 (101) 37-25", false, new Guid("8b5e08a6-5794-4a23-bedb-433517fc33e3") },
                    { new Guid("9f7f2509-1c23-4a9e-8970-e88ba8ebf116"), null, null, "+579 13 (069) 11-04", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("9f8a2f4f-f39b-4091-bca5-6e12981f597d"), null, null, "+440 82 (507) 86-49", false, new Guid("f67356ab-041f-418f-8dcc-95f8367e8d92") },
                    { new Guid("9f907182-48e8-416a-bc86-770d50b75d15"), null, null, "+291 44 (716) 44-90", false, new Guid("81b0b656-13d3-4959-b1fe-4d196fb82105") },
                    { new Guid("9fed422a-4b2b-426e-bdd6-5a01a0780df8"), null, null, "+300 62 (026) 42-17", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("a004bedc-4fdc-447e-aab0-aebe9108d11f"), null, null, "+109 94 (517) 58-30", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("a05063e1-38d8-45ca-8c1f-3a4a012a71af"), null, null, "+334 06 (690) 87-07", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("a05e640c-68b8-4d1d-80fc-ff5a4b8613d2"), null, null, "+991 85 (145) 38-32", false, new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("a08b4063-5c68-4d8a-b589-e2f9b0c11c3f"), null, null, "+366 87 (069) 82-11", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("a0cdff1e-3201-4623-bc75-966aa625f4ea"), null, null, "+396 08 (774) 79-42", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("a18057f6-a84c-4e7d-8fd2-ee4cdbdf4ad4"), null, null, "+568 62 (476) 11-04", false, new Guid("da8e072d-256a-4cff-bfbc-946889fc18c8") },
                    { new Guid("a182e668-6d0e-4b0f-a314-898a4afd0261"), null, null, "+653 52 (082) 08-67", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("a1859f02-0d55-49f2-8ee4-37b78e610179"), null, null, "+19 40 (632) 55-11", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a196774b-d23a-4765-8e8d-75aaa59cff51"), null, null, "+238 65 (293) 23-97", false, new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("a1a8654b-d7c6-4f1b-a4e0-a1e9ff6faa10"), null, null, "+821 71 (201) 26-71", false, new Guid("cac505f5-e90c-4e10-90bc-2d8127d1f61b") },
                    { new Guid("a1f87897-6e3e-4793-9a91-0d2f197429fb"), null, null, "+278 65 (644) 45-15", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("a1fc43f6-ab99-45fd-aba1-30653f1db213"), null, null, "+329 13 (871) 18-03", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("a3584227-7f27-401e-9d21-5cac4172e5ab"), null, null, "+671 16 (178) 50-56", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("a3875917-2095-410f-a5b3-1f4b5a3e2073"), null, null, "+70 95 (924) 53-95", false, new Guid("a81e507e-6b10-49f2-a884-3f7a9d8c7259") },
                    { new Guid("a452ca8f-bf53-4abb-8526-fc3f95249ce6"), null, null, "+42 89 (180) 74-38", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("a4c54c90-136b-42c9-b2fc-a1ee3af6605f"), null, null, "+246 88 (662) 71-06", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("a5922efc-c932-49d5-a40a-58cdd55c0b6f"), null, null, "+271 77 (102) 05-93", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("a5efb623-57de-4318-9b09-12c1643f4618"), null, null, "+282 04 (649) 04-82", false, new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("a61f4476-0197-4bb3-aa6e-f5ef0b9572aa"), null, null, "+253 33 (078) 61-47", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("a6236e35-55e0-4a2f-b962-ac5361f5dca1"), null, null, "+779 61 (389) 86-31", false, new Guid("c48cd1cb-616a-4b12-b7e2-483a97927c94") },
                    { new Guid("a62adee3-a4c2-46ff-8afd-d52a89e78d82"), null, null, "+497 18 (319) 28-01", false, new Guid("4ba3227c-7d99-49eb-a028-80ec3d2e5036") },
                    { new Guid("a65dd636-c93a-4b7e-a362-c371bfabb213"), null, null, "+261 95 (053) 79-98", false, new Guid("e4758532-3832-43f3-b8cf-0a5863a501e9") },
                    { new Guid("a67ece64-b456-4c6f-89ca-51c1bfd57133"), null, null, "+766 75 (064) 39-20", false, new Guid("d901c2a6-cf5c-410e-86b6-dd8dc6425057") },
                    { new Guid("a6a58fb1-c2ea-4166-bbaf-866255768927"), null, null, "+658 50 (986) 77-71", false, new Guid("6207274e-66c3-4c85-84b2-02d91cd015d8") },
                    { new Guid("a6aa66e8-a33f-4145-8e88-dee04e81d8ea"), null, null, "+291 05 (173) 91-90", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("a6c2a08c-defd-4c5c-8476-d48da332605c"), null, null, "+273 05 (748) 28-49", false, new Guid("94427bb7-e57f-4f06-94c3-5cd2a41b9948") },
                    { new Guid("a6dcbd3d-43a3-4556-814c-f41f8e4028a4"), null, null, "+937 54 (348) 95-88", false, new Guid("10ab6e8c-23c8-4271-8d0b-97d3ca17c50c") },
                    { new Guid("a6e381b1-4427-45b4-983e-4874ac8b3d3c"), null, null, "+602 23 (857) 42-63", false, new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115") },
                    { new Guid("a6f9589d-0ed0-4a3f-b637-1e0048b2d453"), null, null, "+950 09 (818) 58-19", false, new Guid("c0ab4184-266a-44bb-b3a2-898ca7e0e2ed") },
                    { new Guid("a73e5f35-17b6-4249-beb8-69b6c5176c19"), null, null, "+827 03 (558) 58-24", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("a7458282-ef68-4869-b0a4-cd28396281de"), null, null, "+496 53 (913) 32-95", false, new Guid("fe4479f6-50cb-495a-9bbc-c77a564d3737") },
                    { new Guid("a92f241e-af2a-45ab-b97b-9b6388cee6aa"), null, null, "+487 69 (476) 13-67", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("a95920a5-d993-46e9-b9c5-3b260069cb5a"), null, null, "+550 42 (278) 26-02", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("a95bdf47-1ec6-456c-b0b9-03091bef926a"), null, null, "+385 72 (205) 02-20", false, new Guid("4285821d-9d8f-4943-b663-27adc015a9c4") },
                    { new Guid("a95cc5cd-b927-410b-b1be-d53b83e27e59"), null, null, "+290 14 (822) 49-90", false, new Guid("5d480052-0b52-4d30-b62f-37baad5187bb") },
                    { new Guid("a9e56ebc-d14d-48d0-b145-1e1aeccd4ca8"), null, null, "+448 20 (401) 15-79", false, new Guid("680c6306-048b-493d-8369-356efb0cafae") },
                    { new Guid("aa5422dd-71f5-440d-a215-95222dd05b1c"), null, null, "+302 26 (143) 83-11", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("aa5495c2-3020-4742-8232-5d8427c6da1a"), null, null, "+179 63 (779) 50-19", false, new Guid("d26865d7-27dd-4d89-8a7b-25ef74b2c179") },
                    { new Guid("aa8dede1-4119-4f3c-b955-1992877ad580"), null, null, "+438 89 (846) 10-45", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("aadca610-fd61-4686-99dd-001fc8435ed2"), null, null, "+950 67 (301) 50-43", false, new Guid("d7f45f27-965f-48aa-95d0-6ce65b54ffed") },
                    { new Guid("aaef9ff2-0cf8-4719-a7e1-df21e5df285e"), null, null, "+452 47 (696) 74-61", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("ab1a7b06-0c4c-4a7f-a443-d6206a91643d"), null, null, "+441 17 (654) 25-04", false, new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("ab28f128-32ef-4be9-9d5c-f9091e2126cf"), null, null, "+525 61 (162) 80-64", false, new Guid("4cdba225-a71b-42ce-a4ea-2b76d8051549") },
                    { new Guid("ab77f058-40ea-46bb-98c1-61eda9565db8"), null, null, "+998 91 (846) 97-23", false, new Guid("0db53a0c-3e10-44c4-b814-5e23bfcc89b5") },
                    { new Guid("ab9d5de2-35ba-40f4-a51d-6f4e620e922b"), null, null, "+738 48 (385) 06-17", false, new Guid("1ca2e699-11df-445a-8084-51598bee7020") },
                    { new Guid("abb9b7f8-8bd7-45ed-a13c-7747ba97ffda"), null, null, "+523 59 (690) 07-43", false, new Guid("05fb67eb-3b60-4c93-bf80-36153be08871") },
                    { new Guid("abc352ae-04dd-484b-8df0-a5ccfe79b246"), null, null, "+411 14 (537) 18-99", false, new Guid("05fb67eb-3b60-4c93-bf80-36153be08871") },
                    { new Guid("ac48ad26-6f43-4de1-b144-f419d8e2bfbc"), null, null, "+655 84 (458) 99-22", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("aca3efde-5ca1-4c15-b42f-7e18c0ce229d"), null, null, "+213 06 (366) 57-27", false, new Guid("d2c357de-2574-4d81-996d-8fd06173f665") },
                    { new Guid("acc88729-2d86-4004-9a2c-55effb7bcb09"), null, null, "+618 49 (777) 26-49", false, new Guid("becc440f-ef98-47a9-b2e3-1f2b794abbe9") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad6a3ec5-9ba6-4ca9-a440-d6293ab86c60"), null, null, "+160 71 (436) 65-91", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("ad9ca7c4-12d4-4e63-a9c7-07f4a79faed1"), null, null, "+236 62 (294) 91-46", false, new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("adb4543f-ce17-4d4c-ad8c-59ac8c3f464e"), null, null, "+952 27 (338) 55-04", false, new Guid("4285821d-9d8f-4943-b663-27adc015a9c4") },
                    { new Guid("ade30e6f-cc78-48c6-b1da-9bad2a29f16e"), null, null, "+992 32 (979) 21-62", false, new Guid("d48193d0-834f-434f-a0b9-8afd54a021d0") },
                    { new Guid("ae16837b-a4c9-4cc8-ac60-85da9318c51b"), null, null, "+374 41 (481) 69-15", false, new Guid("4860b124-2e67-49cc-b664-135729261ac4") },
                    { new Guid("ae32c3ab-7bea-4222-b896-fe1ac2566cc0"), null, null, "+555 55 (289) 80-96", false, new Guid("9f12a065-9888-4a33-a272-3ea9a1fd1370") },
                    { new Guid("ae4241c0-46cf-4570-97e4-64d3bee99b77"), null, null, "+284 51 (037) 49-04", false, new Guid("a8115124-4280-4a52-8af7-cb635f456958") },
                    { new Guid("aeb1e7aa-a5b7-4f25-b4de-c3b2e693ada3"), null, null, "+625 51 (596) 56-54", false, new Guid("26e9f9a9-c77f-4f47-b594-e602be058706") },
                    { new Guid("aedcce6c-4495-4ef0-9bf6-d3d1f9aa680c"), null, null, "+192 64 (211) 08-70", false, new Guid("298b5e9e-61cd-4881-ba0d-6f252c2a7518") },
                    { new Guid("afada080-8d1e-4342-b577-d13b117bc9f3"), null, null, "+475 36 (071) 07-97", false, new Guid("7b8e2086-2aa9-4256-9444-793523c7a280") },
                    { new Guid("affe599f-f6f8-41a5-ad0f-49b3a42eace8"), null, null, "+289 16 (581) 53-82", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("b0069518-234f-4ae8-9fe6-eb9706dcdd86"), null, null, "+228 69 (497) 78-84", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("b0125e47-4efe-409e-b80c-dac480bb2030"), null, null, "+340 49 (785) 98-11", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("b0387c44-e36e-4773-ab27-3c531b92e979"), null, null, "+498 30 (050) 74-62", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("b058a751-181f-40d3-ac47-7b91c2ec40c0"), null, null, "+553 47 (209) 14-60", false, new Guid("beb86abb-7f17-458b-842e-cc4f1e81fd25") },
                    { new Guid("b07b8419-a7e1-44dd-9af4-c986adcffc2c"), null, null, "+451 79 (426) 42-16", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("b0e157c5-3e36-42a5-b0b9-4538d549ca4d"), null, null, "+535 30 (698) 66-19", false, new Guid("68126886-3e88-499d-9fc4-4dc56e519e25") },
                    { new Guid("b0fb49fd-42bc-4a7a-bf01-e99d60769590"), null, null, "+606 24 (143) 98-51", false, new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f") },
                    { new Guid("b10e6352-c462-4312-a4b6-96e46bfd900b"), null, null, "+897 70 (420) 23-53", false, new Guid("5ce92fb3-bc85-481d-82d5-83f5646b368f") },
                    { new Guid("b17b1cb8-fbb5-41a0-be71-e5a966967ac4"), null, null, "+919 79 (243) 06-84", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("b19277bb-ecc9-4491-a754-b54077ac308c"), null, null, "+636 66 (138) 24-72", false, new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa") },
                    { new Guid("b1dcd5a1-de8b-4079-91d8-ec0ea21ad741"), null, null, "+958 04 (786) 32-69", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("b21300eb-2a95-4b40-9010-d5466370c266"), null, null, "+439 71 (386) 36-92", false, new Guid("1504bc12-ba7e-4ab9-b60f-770bc34c26a9") },
                    { new Guid("b2418dca-8405-41cc-bd05-e5c82a5c4ad3"), null, null, "+409 44 (423) 89-48", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("b2618ef6-f03b-4948-85ed-1d8f3df25020"), null, null, "+988 15 (587) 65-91", false, new Guid("ff2770a0-d06b-485c-9349-7593889b4ca8") },
                    { new Guid("b27811bf-6cc4-4857-98ea-6c25fe424b05"), null, null, "+104 18 (770) 00-99", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("b336e55f-40b9-46da-b40a-7538c7be54ec"), null, null, "+476 31 (014) 21-45", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("b3496c2f-40ce-45d0-adfa-efe6b43876dc"), null, null, "+453 31 (009) 34-63", false, new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4") },
                    { new Guid("b3698d70-e227-4b12-a357-4777a42fd49e"), null, null, "+226 60 (389) 60-83", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("b3ab666a-2922-47e2-a65d-2d5b546ce783"), null, null, "+458 63 (669) 46-69", false, new Guid("485c45b0-00d0-473e-8acf-e0e0525a8481") },
                    { new Guid("b40352f2-ebf9-4b3b-8b87-e9217d52bb52"), null, null, "+970 32 (688) 93-11", false, new Guid("54ecf88b-205e-4ad8-a4aa-2cf2b902039c") },
                    { new Guid("b48a27c8-36f3-4e84-908f-957818cdf903"), null, null, "+452 95 (317) 74-93", false, new Guid("7d9bae8e-68c3-4758-8f23-f19694dfa6d5") },
                    { new Guid("b513a82a-3fd3-42fe-bf74-dbf4fc1640c4"), null, null, "+55 68 (111) 72-50", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("b52f63a4-51b2-40d7-b9f0-f0f828706540"), null, null, "+270 77 (899) 46-87", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("b5a19b27-6b26-48b0-b6cd-86f03cf2ffdf"), null, null, "+536 00 (715) 67-44", false, new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("b5b141a2-840b-48cf-95e1-3597478b98fb"), null, null, "+899 74 (625) 50-74", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("b61c031e-dedf-4152-8c9a-30c5756fbbae"), null, null, "+656 46 (602) 71-62", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("b652e664-492c-4c4f-ba52-18b0cb3fffc3"), null, null, "+548 32 (971) 80-65", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("b66ed7b6-9198-4a3c-bf73-75dccb5dc5a9"), null, null, "+824 30 (185) 67-68", false, new Guid("889632ea-bb16-4e53-99bf-c82c435aebf4") },
                    { new Guid("b6ec6b53-1023-4598-9b25-bab52369b2f0"), null, null, "+136 86 (192) 32-51", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("b6f31cd4-c536-4302-886e-56dc3c7840c0"), null, null, "+934 70 (990) 69-33", false, new Guid("a0995ae3-517f-4476-bad0-18fca309cda5") },
                    { new Guid("b77d111d-c90a-412b-8d98-47f74dbfd12d"), null, null, "+336 23 (527) 99-30", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b77de484-548d-4ed7-a601-1259a437706b"), null, null, "+703 11 (852) 22-19", false, new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("b78cbdf6-a8f6-4fd0-9f45-6fd000da2fe8"), null, null, "+663 33 (952) 57-15", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("b79b50ae-c30b-41f1-b744-d68caaee454f"), null, null, "+688 16 (408) 27-74", false, new Guid("ced5240d-addb-472f-ba8b-c7b0a4ee83db") },
                    { new Guid("b7b515e2-e1f2-42d3-9c01-cc1b8aca47ac"), null, null, "+383 96 (512) 12-79", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("b7d23ab8-2e87-4a3c-8a93-10da2b6a2b27"), null, null, "+59 20 (249) 43-70", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("b801a2cf-9270-4c2f-929a-2192dcb149ce"), null, null, "+808 55 (841) 32-46", false, new Guid("42a28881-5765-4f59-9201-be96e3fa60b5") },
                    { new Guid("b83d963c-1ca7-41e6-89ff-2b43dfa05482"), null, null, "+609 83 (946) 93-24", false, new Guid("1b4cb770-76a2-4aff-8a9d-088872e5a38b") },
                    { new Guid("b87ac2ca-f36d-4ecd-bf0a-30f4738ee563"), null, null, "+565 02 (400) 04-59", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("b89e3b4e-1a29-44c3-8baf-d5d75945a259"), null, null, "+919 09 (819) 73-42", false, new Guid("81b7dd81-5367-419e-ba4e-b646c1f5c955") },
                    { new Guid("b8eaa2bb-5c0c-41e4-92da-24164aa77d74"), null, null, "+807 96 (591) 06-80", false, new Guid("d36ea413-c511-4e09-aaf4-43f83aa650d1") },
                    { new Guid("b914b378-173f-406c-b1af-cd2255cff361"), null, null, "+685 69 (472) 64-75", false, new Guid("9cbbcdfa-154c-48d2-b58a-5d7f5fa84bf9") },
                    { new Guid("b92a27c0-52a0-472c-822b-445a253ff6b4"), null, null, "+771 85 (441) 28-51", false, new Guid("cffe050f-4af9-42c3-b66d-c738838d18fd") },
                    { new Guid("b9339124-5a9f-4d19-a467-e8ac9fb54ca5"), null, null, "+504 33 (910) 57-71", false, new Guid("be6aefa2-416e-4ebd-b325-a62bf286dad2") },
                    { new Guid("b97e1906-7b10-49a4-b1cf-7fa7e5b74e0a"), null, null, "+690 63 (417) 35-16", false, new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58") },
                    { new Guid("b9cdeae3-c4c3-4e9a-8c5f-5ba26180f9e9"), null, null, "+237 73 (346) 37-77", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("ba4b5eed-3ec5-44ac-aebe-ecac70d3792e"), null, null, "+446 78 (084) 50-07", false, new Guid("4da666ed-651f-45fb-9fa0-e56c65e010ab") },
                    { new Guid("baa6711f-2e74-4e6c-ba9a-f8006332a974"), null, null, "+85 37 (921) 54-96", false, new Guid("d00843c6-8994-40f0-b016-cb9760f5ede0") },
                    { new Guid("bafe0b3d-cbba-43f4-a886-d0696492f1a1"), null, null, "+638 60 (317) 51-40", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("bb16ac73-f739-4f2d-b038-af95377e21e9"), null, null, "+254 30 (404) 90-88", false, new Guid("7da2ca6b-ee25-4903-97c3-8c51cbd5469a") },
                    { new Guid("bb40e568-253e-44fd-823f-05440c7e8b32"), null, null, "+209 28 (542) 26-32", false, new Guid("d35b9242-99c3-49f5-8020-bc6719205da1") },
                    { new Guid("bb512337-5f96-4331-918a-1703215423f3"), null, null, "+407 02 (841) 36-52", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("bb5b5749-b828-4c21-9e94-5017141c260a"), null, null, "+178 49 (557) 18-49", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("bcde87da-46b1-4e27-ad2e-f7c2be26633e"), null, null, "+42 30 (248) 73-28", false, new Guid("ee988837-dda9-4fd3-9925-0375db807eaa") },
                    { new Guid("bcf2082f-26e3-4773-9f81-4820a05ef6da"), null, null, "+486 99 (266) 23-98", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("bd005570-b496-4cad-860e-5d3d44884a48"), null, null, "+19 88 (579) 61-60", false, new Guid("963654b6-a05e-4be7-b120-45295941d954") },
                    { new Guid("bd623003-2344-4b1f-a378-078f3c3dd876"), null, null, "+799 63 (505) 79-88", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("bd91916f-be52-4b6f-bb29-4a24147fb9c5"), null, null, "+708 34 (059) 75-09", false, new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("bdae8e87-8079-4be2-b0ab-bbc5b483d15e"), null, null, "+891 28 (476) 37-34", false, new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") },
                    { new Guid("be2d25d3-5639-4f79-be51-8c1ae0581fe2"), null, null, "+761 49 (529) 05-77", false, new Guid("3a00ec7d-f614-4939-8f26-9f85924f8e4b") },
                    { new Guid("beadd0ef-12b6-444e-a559-f79a6303ad23"), null, null, "+193 02 (753) 10-62", false, new Guid("c6df1a3b-6c87-442a-9801-7144d179bb44") },
                    { new Guid("bf35150d-d511-4427-bc67-f9a5b7eae7b8"), null, null, "+464 33 (005) 72-84", false, new Guid("d5ec2193-527f-4ff0-990c-6dbcd2680b03") },
                    { new Guid("bf40f1b4-6a3c-4847-b89c-ebd5af8ff2d0"), null, null, "+484 39 (264) 99-25", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("bf7cd673-f608-4b7a-9c64-1d3e792c1b49"), null, null, "+168 79 (998) 74-81", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("bfca1e4a-2e63-4a3e-ab2b-34686ecf2f3c"), null, null, "+937 84 (192) 38-37", false, new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("c06b970a-5e58-46af-878f-023e14499bc4"), null, null, "+200 36 (462) 34-58", false, new Guid("d21d9a2f-9829-4185-9025-8dab84001f2c") },
                    { new Guid("c1070785-22b6-40be-86bd-d04976dfcedf"), null, null, "+151 94 (193) 74-05", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("c1fcd818-6d69-482a-a2e9-da24dac0c443"), null, null, "+229 39 (871) 95-02", false, new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf") },
                    { new Guid("c347a89b-ab14-4456-aca4-a46c977160ae"), null, null, "+616 01 (316) 49-73", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("c3c7c915-ec05-443b-92a2-b857c69e2b61"), null, null, "+749 00 (518) 92-31", false, new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305") },
                    { new Guid("c3f11d5c-a4c6-4dbf-8bb4-dd5c3bd77ad0"), null, null, "+824 27 (855) 51-26", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("c464709a-380c-4a77-b845-ece11b789b61"), null, null, "+527 60 (748) 23-23", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("c50bf0b7-43d4-498f-8197-1b1c5b5934fb"), null, null, "+409 37 (677) 42-77", false, new Guid("9d06cce2-1709-49e1-80ed-87329fcf6276") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c5646a14-9297-459e-9d2e-e51f16508f68"), null, null, "+332 21 (826) 93-09", false, new Guid("552897cb-50fc-4256-9bd1-9945212ba0e3") },
                    { new Guid("c5731ce2-2db7-45c5-abbc-94897600ea14"), null, null, "+197 46 (585) 11-67", false, new Guid("5cbf879e-7a4b-4f2c-9943-bc1c802c157f") },
                    { new Guid("c58b5ded-8604-4f01-9ab4-0d8401ea5cd9"), null, null, "+284 15 (707) 50-13", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("c5c21b4c-25f5-42ad-9614-cd50b00d244e"), null, null, "+743 15 (547) 41-40", false, new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("c5de74b4-3db3-4463-8a6e-678e59731e71"), null, null, "+954 19 (796) 00-08", false, new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("c633ae3e-c316-4d21-ac24-782cd94d0f56"), null, null, "+899 65 (219) 16-91", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("c63cfdfb-1e9f-4249-8cac-4d215392a472"), null, null, "+767 29 (787) 27-37", false, new Guid("000f268f-f20a-4706-ad01-ce0f0aac4115") },
                    { new Guid("c67ebaff-4e32-4a0d-ad19-a7c4662a3352"), null, null, "+537 89 (737) 97-31", false, new Guid("4f7a4d52-4579-4c3d-9dc8-f29306c26c86") },
                    { new Guid("c6b0b093-c83a-46f8-b343-322ce324d1e5"), null, null, "+539 80 (054) 71-52", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("c6f6ca40-d524-422f-9318-87c3e470d047"), null, null, "+727 28 (748) 08-48", false, new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("c88a97b1-6b8c-4764-a6c8-0057dac4dc89"), null, null, "+146 54 (533) 73-59", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("c91b5cca-1b93-46eb-b879-b64080616a62"), null, null, "+889 62 (676) 35-44", false, new Guid("800e6423-1a34-4a3f-94a1-3cffd3faba53") },
                    { new Guid("c94745c9-b836-480e-b00a-d5eab368e092"), null, null, "+620 14 (055) 10-02", false, new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("c9cd317b-10d1-4ef5-8c3e-71f1b3f9dcce"), null, null, "+807 48 (578) 83-84", false, new Guid("56849926-257d-43a6-ac97-a9364a7a8ca0") },
                    { new Guid("ca2f696d-c032-4a74-8148-cd3c8c8f9e76"), null, null, "+569 76 (531) 29-52", false, new Guid("5f4d8e4f-f556-41ed-9ebb-baa90823551c") },
                    { new Guid("ca3f3266-6fa1-4858-92f1-c1dac210e2c8"), null, null, "+965 56 (818) 04-16", false, new Guid("e463df64-de2b-4de9-9d99-7b6d2cb8e457") },
                    { new Guid("cb691436-43f5-4441-b643-afc6ebfa6527"), null, null, "+237 23 (841) 16-63", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("cbdf60d8-dead-4fde-af6d-36bc74b127f3"), null, null, "+481 88 (724) 44-41", false, new Guid("364df856-5357-4366-afda-cf52f25f1325") },
                    { new Guid("ccf80878-1056-44ac-a728-1c67f47aaaaf"), null, null, "+22 75 (454) 07-77", false, new Guid("7b8e2086-2aa9-4256-9444-793523c7a280") },
                    { new Guid("cd1da8b2-316f-49ac-8821-7301daf8126e"), null, null, "+118 90 (891) 00-51", false, new Guid("844e4991-7c2b-4f7a-b906-5e3d2d361baf") },
                    { new Guid("cd58a35d-8115-4743-9779-01f22a220c67"), null, null, "+906 62 (388) 40-63", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("cd67496b-49cd-406a-b7e5-76bd73f2fa2f"), null, null, "+19 69 (099) 71-54", false, new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("cd692667-94ba-4c32-a44e-e981b3f02054"), null, null, "+598 48 (385) 78-46", false, new Guid("6874edda-3fc3-4dc9-b6d5-3cfd8ac8f305") },
                    { new Guid("cd899417-de17-4884-ba6d-f4daebf1a155"), null, null, "+593 62 (110) 84-22", false, new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("cded4f84-0033-4afe-8778-1354f36ca9da"), null, null, "+42 87 (014) 28-32", false, new Guid("a42b469c-fec8-4056-a4de-926b01b7f202") },
                    { new Guid("cdefe15f-b6f5-40f5-ad45-0d63a3c65f20"), null, null, "+426 88 (179) 71-74", false, new Guid("bea80970-74bf-4539-a300-cbbac8625744") },
                    { new Guid("cdf380e8-a78c-4b4f-878b-92a36f5013c7"), null, null, "+901 26 (390) 09-12", false, new Guid("71978c89-b953-4ec5-98a8-ab384223de1a") },
                    { new Guid("cdf7e032-5f2e-44c7-b78b-c300b442e0ba"), null, null, "+666 68 (416) 55-78", false, new Guid("e1e2e7ad-197c-4d75-aff8-06d9ae9dc807") },
                    { new Guid("cf74da81-c42c-4198-a4bb-cf30bdd12d8b"), null, null, "+417 86 (459) 24-12", false, new Guid("a8115124-4280-4a52-8af7-cb635f456958") },
                    { new Guid("cfa738e7-d66e-4900-bcab-561389ec443a"), null, null, "+979 94 (551) 16-92", false, new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("d01d5869-4c3d-4bcf-b9eb-ee121f015464"), null, null, "+314 97 (196) 70-37", false, new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("d027e4e4-684a-4b13-8ac9-1cf06975d2cb"), null, null, "+54 95 (203) 59-39", false, new Guid("21df2a78-258e-4a08-ab5d-bc1b85f3d8ca") },
                    { new Guid("d09edd4b-123c-40c1-a6dd-d9ff414cb9da"), null, null, "+703 18 (436) 24-24", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") },
                    { new Guid("d0de4345-e950-45e8-9744-e79fa431d214"), null, null, "+91 88 (118) 88-34", false, new Guid("8df6a82f-3a69-4f18-a284-47bb40952c16") },
                    { new Guid("d0e72a2e-d147-428b-a29f-0ff248774cf2"), null, null, "+238 16 (723) 03-82", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("d15ee469-ca6b-49f1-9bc7-689c3ab5ce61"), null, null, "+619 05 (694) 20-71", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("d16ee85c-4c94-4e6b-9416-7760fa1bedde"), null, null, "+835 60 (643) 79-80", false, new Guid("020745a8-efde-4c38-b1ac-7fb3002634fa") },
                    { new Guid("d177f6bd-9bd9-484d-8f95-62f473192ae8"), null, null, "+251 45 (070) 38-85", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("d1904110-4660-4488-918a-43a10e97924b"), null, null, "+345 18 (964) 54-37", false, new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014") },
                    { new Guid("d19cd552-5458-489a-95b4-9b8218295b84"), null, null, "+959 47 (494) 77-22", false, new Guid("01a8bd37-aff4-4aac-8218-b782c941985f") },
                    { new Guid("d1b8184e-d5b0-423f-80b8-375ffd674b7c"), null, null, "+805 11 (311) 90-27", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("d2119880-5334-437f-a574-8281b2c125dd"), null, null, "+824 81 (801) 70-22", false, new Guid("c187c610-03e7-4305-96e2-96f776a463e0") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d22d7fdd-9698-4c19-8abb-c3a2ed4d43ed"), null, null, "+397 35 (640) 25-78", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("d24ada74-2d15-487e-899d-8f23ca259d1f"), null, null, "+574 78 (013) 40-00", false, new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("d254be36-e297-4c08-ba35-ec2a6641974c"), null, null, "+95 34 (302) 50-90", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("d345a997-99ff-45a7-9013-61842ece1ecf"), null, null, "+918 98 (780) 45-43", false, new Guid("98e012c9-41a7-4de9-89d6-7f8e10547ee4") },
                    { new Guid("d3cea839-cba0-493a-8065-39594777bd7f"), null, null, "+708 44 (246) 49-22", false, new Guid("c187c610-03e7-4305-96e2-96f776a463e0") },
                    { new Guid("d3db48dc-7b04-4efb-ad7e-6e96928f1a55"), null, null, "+724 12 (389) 07-44", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("d40de7db-23d9-4d0b-9084-2f912f37e036"), null, null, "+177 78 (855) 92-38", false, new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("d469b6ee-b5fa-4329-89ca-50ba960854e2"), null, null, "+620 12 (886) 11-13", false, new Guid("3bd4fc60-8d02-44d9-a6be-99041f0efe02") },
                    { new Guid("d49a7847-4688-4738-aca3-db8e1bda18c0"), null, null, "+397 21 (786) 77-51", false, new Guid("88e1c2d9-5ede-40b9-998a-a64c2f7a94cf") },
                    { new Guid("d4d9ce72-2524-43a9-ace0-dc0d2fbe02be"), null, null, "+185 95 (199) 26-09", false, new Guid("27227719-63de-4c57-8bf2-79ef3a0bdba0") },
                    { new Guid("d55f3ab5-0095-4069-a2fa-debd6a7fa759"), null, null, "+567 13 (271) 52-98", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("d56ab096-dc7d-4554-9032-052bb3fc0446"), null, null, "+29 71 (246) 96-94", false, new Guid("de8e92c9-9790-46fc-932e-ffcf668aedd5") },
                    { new Guid("d57920dc-d019-4b7f-bdc3-63be760cce8e"), null, null, "+138 41 (260) 04-44", false, new Guid("4860b124-2e67-49cc-b664-135729261ac4") },
                    { new Guid("d587d696-4f54-4d47-8bfd-a3da79ebd8bc"), null, null, "+30 28 (578) 23-24", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("d622af09-2eac-4fee-a12c-0563d6b3a9e7"), null, null, "+834 39 (992) 17-31", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("d657b224-f701-43f9-882b-aed455bb5022"), null, null, "+928 37 (220) 64-83", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("d73f37de-8785-4ebd-acf2-b060a2553ba9"), null, null, "+78 67 (855) 88-30", false, new Guid("d7396696-6e82-45bf-9939-3be9e3ddfd63") },
                    { new Guid("d75e8c30-0f22-492c-a7bf-4b929ab1d6c1"), null, null, "+784 46 (668) 71-81", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("d7d8d6e0-f8ae-4846-a7bb-a31c7567cd81"), null, null, "+889 18 (767) 89-52", false, new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("d8138616-8e5d-4a82-b2c6-41263ea69ce4"), null, null, "+641 65 (461) 03-31", false, new Guid("edac6b38-9a54-41be-91a9-03035fcb2f5d") },
                    { new Guid("d8452321-0d76-46da-b829-794855d34889"), null, null, "+827 17 (276) 58-08", false, new Guid("e40e2711-9c08-4792-916e-d51b4fc58d35") },
                    { new Guid("d8e61d89-8c49-46ee-b9d4-bb5fed37a72f"), null, null, "+39 90 (346) 27-05", false, new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("d90b3271-e597-4b52-86f5-1125e106a0f8"), null, null, "+57 43 (424) 88-50", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("d9152717-725c-49fa-a8df-3ea0d1c7cb1a"), null, null, "+354 67 (232) 91-04", false, new Guid("e1889cbc-d169-44ed-baac-5f1784921ebe") },
                    { new Guid("d92c73a6-9f21-40fa-804d-b64c8571d42b"), null, null, "+595 27 (854) 01-39", false, new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("d9336484-8661-481b-9c37-1ed03b6c3544"), null, null, "+81 91 (565) 17-73", false, new Guid("c73bd258-469c-4d46-ad89-cd1119310c49") },
                    { new Guid("d9a18261-5cca-4e66-9c88-1e3b017d8dd3"), null, null, "+301 58 (559) 47-40", false, new Guid("6f9332ff-d094-4273-a535-e4c9ab5aad86") },
                    { new Guid("da168daf-f7b5-4256-925d-39f1b87a4a44"), null, null, "+538 79 (533) 64-05", false, new Guid("5053bd1a-741f-48b6-8412-85c27342ccca") },
                    { new Guid("da9b9f4d-4092-42ae-8e9f-52591045f12a"), null, null, "+196 20 (040) 98-69", false, new Guid("b1a47675-a426-40f2-92c1-05e03a4854e9") },
                    { new Guid("daf2ce81-0951-4f61-87e0-a30668b61f73"), null, null, "+682 62 (460) 11-38", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("db3072f6-78b9-42bf-89ee-ca6596a93c11"), null, null, "+75 90 (248) 45-14", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("dbbfd8df-b37a-4c65-ba97-4b289cd681e1"), null, null, "+113 53 (475) 05-23", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("dbd69e88-4c23-41ae-8fce-e3dd0961db08"), null, null, "+450 01 (587) 12-27", false, new Guid("1a598589-cd49-45e5-bf98-42bb487cecaf") },
                    { new Guid("dc04712a-e0b2-48e5-ace6-f77022ad2a5e"), null, null, "+98 13 (793) 61-54", false, new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("dc115b61-834c-4c8a-ab7a-c0576328604f"), null, null, "+200 02 (400) 57-43", false, new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("dc243563-3a1d-4cbc-9b0a-2cfa803de77c"), null, null, "+633 46 (378) 10-53", false, new Guid("64ae7664-3300-40cf-a69a-7862eca124da") },
                    { new Guid("dc3f1f44-d1c9-4d10-9742-419606d0bf2c"), null, null, "+237 80 (136) 43-76", false, new Guid("b2e8e8ed-7a0e-4d2a-8c5a-47ddcacf3e6c") },
                    { new Guid("dc80ff8b-e47e-4e3a-9b4f-5d57eecb4b60"), null, null, "+645 83 (608) 56-71", false, new Guid("e8293c7e-c598-445f-a509-d9123149ec52") },
                    { new Guid("dce72182-fab9-4e6d-8b57-4d5ae21663ff"), null, null, "+41 21 (271) 20-73", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("dd0e13c2-2a9c-465d-ba6b-b25a1c7ec7a3"), null, null, "+66 72 (381) 43-24", false, new Guid("ffcbaec9-773f-4373-b37e-e5854087b988") },
                    { new Guid("dd46f377-301c-45cc-b67a-36b0992574f6"), null, null, "+653 16 (421) 78-09", false, new Guid("da175a26-80f5-4704-9c96-da3480a7797b") },
                    { new Guid("dd5206f8-e616-46b9-9958-2064bf6fd5b1"), null, null, "+171 62 (420) 02-38", false, new Guid("a964f1fc-362b-49f0-901e-ffeb1882c615") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("dd65dd41-27d7-4403-ba43-0e7c11b0916b"), null, null, "+65 25 (486) 51-52", false, new Guid("3e4fad7e-77d0-410d-9330-4b80c8a75e75") },
                    { new Guid("ddd44646-4b77-431c-aea9-b06fdf88446e"), null, null, "+149 15 (100) 49-64", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("ddda9054-db8a-4ae4-8075-0e9f2ad2fae5"), null, null, "+381 71 (656) 13-21", false, new Guid("a4a6685c-256f-4d80-bb16-3bd97228eeae") },
                    { new Guid("debdf2a4-1cfe-4837-9478-b986c9f8c981"), null, null, "+499 47 (398) 63-36", false, new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("dee2658b-840a-41ce-b909-9eee97c8a96e"), null, null, "+730 94 (866) 55-37", false, new Guid("5bdd7df1-c772-4b8d-b99b-734013ab862a") },
                    { new Guid("e04836ef-dffe-4720-b0fd-269026427ba1"), null, null, "+475 34 (509) 20-98", false, new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("e0e7c00e-3459-4cfe-9721-3c7dd3d73ab0"), null, null, "+370 26 (773) 34-13", false, new Guid("74d9b5f7-e8ec-4969-8a2e-8a3a956313a0") },
                    { new Guid("e10c377a-2225-4d9f-840b-f412cab6b588"), null, null, "+292 64 (548) 18-68", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("e14a9253-a274-468d-8e22-da30688f78e6"), null, null, "+745 63 (008) 69-05", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("e160300d-38e9-4ef6-8cb3-bb6bfce5dd0f"), null, null, "+238 58 (762) 31-62", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("e1f394ae-1a01-42a1-b47d-ad9f97abe0ff"), null, null, "+161 44 (609) 79-67", false, new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("e1f56a06-dadf-40b4-aa6a-a957abfcd384"), null, null, "+316 28 (653) 76-87", false, new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("e2113b09-cf01-4c93-8abd-d4044cdcc666"), null, null, "+358 58 (074) 61-33", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("e2491766-3b6d-40af-a168-e1f34566118f"), null, null, "+213 96 (861) 17-13", false, new Guid("0f922f7b-44d1-4fba-a023-fc72e297bbf6") },
                    { new Guid("e257230b-960e-441e-aca3-6af056df3d1d"), null, null, "+79 35 (742) 83-76", false, new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("e27a3835-fd43-4308-a0c8-6653e5b54337"), null, null, "+262 49 (117) 39-93", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("e55732a6-c889-4594-b634-56019b9e6605"), null, null, "+857 36 (533) 72-89", false, new Guid("a8013da5-3c2b-4b83-825f-33d658cd07ef") },
                    { new Guid("e5682710-c1f7-4e1a-b723-33101e359929"), null, null, "+694 76 (730) 64-50", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("e56a937c-b1de-4dc4-a150-96243df67730"), null, null, "+480 06 (425) 07-16", false, new Guid("14de5e5a-8462-4258-92de-ef0f1f5ff062") },
                    { new Guid("e5cb15ff-465b-46ea-90f4-ac34bbfa0c21"), null, null, "+11 85 (391) 45-08", false, new Guid("471b07a7-625e-4c55-a3a6-ea46a9075d8f") },
                    { new Guid("e5e6f779-ce73-4ab0-8ee3-97f511d4943e"), null, null, "+916 77 (847) 09-94", false, new Guid("a42b469c-fec8-4056-a4de-926b01b7f202") },
                    { new Guid("e5f39eaa-e5b7-486f-a56a-7f51e30727a8"), null, null, "+929 16 (858) 94-26", false, new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("e61db362-ca30-4845-a7fb-bc3e12ae5cfc"), null, null, "+743 32 (551) 79-38", false, new Guid("8ba3fd02-ec80-4c7f-ab9e-a201898bfe2f") },
                    { new Guid("e641841a-5e7f-4f4f-9357-f98576fbca9d"), null, null, "+929 12 (017) 38-11", false, new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("e66bc262-997c-425b-b391-f65ba6321a53"), null, null, "+946 88 (805) 94-01", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("e740de2b-baf6-4818-880e-4ae4e58ac6d4"), null, null, "+246 58 (837) 70-17", false, new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("e777406b-ef02-4cbd-95cb-ec54488cfbf5"), null, null, "+729 84 (961) 39-56", false, new Guid("5911b08b-117c-4079-af41-1eb1e8574741") },
                    { new Guid("e7bfa83a-db98-49f4-9b2c-7a1c3fa1cd27"), null, null, "+326 98 (047) 72-78", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("e7db484a-433b-440c-a9fc-0ddbe8c6a928"), null, null, "+255 57 (271) 55-71", false, new Guid("0a55d11b-38c3-4d47-829c-d3b424352ef7") },
                    { new Guid("e7f585e8-742e-42fa-bbbc-582f0a87905d"), null, null, "+692 44 (101) 17-88", false, new Guid("1d1c1daa-4438-4dcd-908a-ddfaa889d215") },
                    { new Guid("e815d17f-efbd-42eb-917d-5677b6e0f6a8"), null, null, "+270 85 (655) 01-09", false, new Guid("cf122b3e-0299-4718-abfc-7ca8f269a3ab") },
                    { new Guid("e8900cc0-883e-4ae9-9017-54013440bd1d"), null, null, "+12 00 (448) 65-84", false, new Guid("656e8637-7fb6-43dd-969d-25c4c065aede") },
                    { new Guid("e8a726dc-2db6-42fa-9b9f-7dc9c262bca5"), null, null, "+145 82 (533) 80-64", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("e8b3eadb-6eda-4aa4-a542-2136e5e60f44"), null, null, "+138 87 (511) 67-98", false, new Guid("2ee9de1a-0eaa-44a2-9a9e-b2946b18e5bb") },
                    { new Guid("e8c0eb97-3f84-4995-b65a-6f3d2c0e74cd"), null, null, "+803 92 (348) 27-00", false, new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("e9ba5b43-d0b4-43f0-ada6-1f362ce15c03"), null, null, "+731 45 (455) 66-25", false, new Guid("fc826c2e-6bad-4a09-8e39-dc31906cc23f") },
                    { new Guid("ea2725a6-218f-4651-aeac-31f7c41e50de"), null, null, "+905 20 (137) 95-55", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("ea982ea6-89a9-4cc4-9abd-019c001a2628"), null, null, "+706 67 (565) 08-06", false, new Guid("3f77ba75-2eda-4943-868a-04b6a62a63f2") },
                    { new Guid("ebc29cb4-d1ab-4024-b67c-c34f3a2d1207"), null, null, "+637 36 (011) 94-06", false, new Guid("4276fb99-4cb4-4c0f-b3ad-3567f0a92117") },
                    { new Guid("ec31a4a3-ffa9-4b34-88a3-a28b5ca97393"), null, null, "+261 03 (381) 82-08", false, new Guid("f198b380-c53a-437b-904d-29b9d522aac3") },
                    { new Guid("ec53b6fd-467e-4df5-95e4-dfeb6f091231"), null, null, "+40 04 (348) 66-82", false, new Guid("5c3ca536-8db2-415c-a6dc-d731231d81fc") },
                    { new Guid("ec8d4920-4de0-4a34-8c02-e1b6967e8b8f"), null, null, "+954 99 (865) 03-72", false, new Guid("30c82c6c-9720-40c1-b90a-c27d8bf3efdd") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ecc6d7fa-ef66-43f0-9420-0726bd1497c1"), null, null, "+304 19 (327) 54-10", false, new Guid("a30a1b96-9eda-4869-baa3-7929f6f66216") },
                    { new Guid("ed955385-0cd3-43e7-9526-5273315b4dca"), null, null, "+888 62 (958) 11-07", false, new Guid("ae602e45-1f7a-4bb5-9254-e1405450d7cc") },
                    { new Guid("edf34936-9fed-405b-b7a9-83eb67e8bc15"), null, null, "+46 85 (761) 14-34", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("ee24b487-072b-49d6-8b63-f917d2cc704b"), null, null, "+570 08 (756) 54-90", false, new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("eeab0c99-c86a-4295-9a70-11024bdf7123"), null, null, "+951 34 (196) 93-89", false, new Guid("7a5691c5-741c-4ac1-a097-e8ceb68dce58") },
                    { new Guid("eeac3a2a-73a3-4d97-bf24-9b5ba2897074"), null, null, "+313 37 (269) 91-30", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("ef2852a0-52a7-4fe1-b244-1832afd12f46"), null, null, "+847 76 (195) 41-23", false, new Guid("b3d98c9a-9acc-4552-af4f-a9000a382794") },
                    { new Guid("efdc025b-7642-4373-b84e-04e1a3fa497f"), null, null, "+541 66 (881) 45-27", false, new Guid("0b72299e-f297-44bf-863e-09c1ec2dbc13") },
                    { new Guid("f0dfe55e-9c17-4421-bd57-26c7bda3f9da"), null, null, "+851 55 (661) 58-64", false, new Guid("773e0eda-1c7c-431d-9f3e-a8563f8540cb") },
                    { new Guid("f0e6fa4e-2835-48f8-97b1-5614944e735c"), null, null, "+349 03 (310) 67-37", false, new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("f11f0397-c338-4610-b82d-d3a4fb9e57f7"), null, null, "+877 79 (592) 08-35", false, new Guid("8440d8f9-2430-4c2a-bad4-7b232af4e1bd") },
                    { new Guid("f1280735-cfe3-4e93-9063-d64020ca6e9b"), null, null, "+326 04 (175) 59-72", false, new Guid("79086701-2604-4fd7-bb34-b77855e8579e") },
                    { new Guid("f197996e-ec40-4a34-97ee-70696ae5d413"), null, null, "+677 73 (420) 04-60", false, new Guid("9f82a56b-aa59-4397-8fa2-4a32bf0e4014") },
                    { new Guid("f2bbf02a-143b-43d7-9f91-e2d7e1b8e1a3"), null, null, "+931 62 (166) 56-01", false, new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("f30fedcd-7d49-4fee-8d9a-3e4b4a0ead67"), null, null, "+780 28 (202) 39-16", false, new Guid("cc4bb6cc-2859-4fba-8538-9e23fd996c52") },
                    { new Guid("f45ce424-eb2e-4e34-ae73-635d71f65492"), null, null, "+356 26 (896) 78-16", false, new Guid("4f7c59ed-7954-4fa2-9e58-0bbef54848b4") },
                    { new Guid("f53e5f40-af2f-4aef-90a8-1496be1459dc"), null, null, "+33 58 (249) 80-89", false, new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("f559ecd4-cf49-4073-ba88-3893e172ecf0"), null, null, "+685 16 (612) 84-14", false, new Guid("e8293c7e-c598-445f-a509-d9123149ec52") },
                    { new Guid("f564f24a-08ea-48a0-850f-3641bd0ded8f"), null, null, "+17 69 (580) 08-05", false, new Guid("a48032c5-e6ec-4ea6-b15f-d58e803e3b30") },
                    { new Guid("f585e63f-a17f-4f2f-9861-28a8f22e3c0a"), null, null, "+186 59 (686) 66-36", false, new Guid("9b9545b8-20a2-4d13-94ea-ed55ff3edb10") },
                    { new Guid("f5b84a26-c8de-4d41-83b1-3ee6efecbf86"), null, null, "+275 67 (836) 54-46", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("f634005b-03be-475e-b9dc-9e09d7ab2db9"), null, null, "+544 25 (721) 19-70", false, new Guid("a8eb141c-5178-4baa-b599-679287b17c92") },
                    { new Guid("f64d6cbe-0552-4ba2-bafd-6cbc4e5c2b42"), null, null, "+635 66 (406) 01-50", false, new Guid("46df41a5-5e3d-4e3f-a141-7b267120d50c") },
                    { new Guid("f662b5ee-6ad8-4b5d-8ca1-4f23b4493865"), null, null, "+392 07 (619) 96-06", false, new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("f7e67327-d76d-4cbe-b26e-e922bb0c5881"), null, null, "+344 09 (467) 43-49", false, new Guid("d9d8e0b0-fd40-46b2-9ad0-2abc3a268d5b") },
                    { new Guid("f8a1d611-ef40-4c20-9358-036349bd94dd"), null, null, "+739 94 (205) 18-29", false, new Guid("289e4bf1-5ab7-4e11-9f2f-c27229a25641") },
                    { new Guid("f94d2e1f-866c-445a-9783-4e0cf2549639"), null, null, "+146 30 (100) 38-08", false, new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("f968517f-9786-4cc7-8838-ca24a3afa765"), null, null, "+224 80 (738) 02-25", false, new Guid("9b484012-f39d-44c2-ab0d-30bc346bf696") },
                    { new Guid("f97bc787-dfe6-41f4-a081-da3bfbd78bb1"), null, null, "+428 67 (057) 12-39", false, new Guid("70d7149c-a8c1-42ea-a9f4-0b075b673cdf") },
                    { new Guid("f982bff7-8876-4a18-92f7-aa09ba28d318"), null, null, "+590 62 (779) 77-74", false, new Guid("2f8a799b-8833-4557-ad2e-44573ab299bd") },
                    { new Guid("f99072e6-7851-45d6-aad5-210fc5a7bf12"), null, null, "+266 29 (138) 70-56", false, new Guid("11c141fb-3a34-4d70-b770-3c85669e8b14") },
                    { new Guid("f9e5c186-d6c7-4d8b-b994-06343d383dcb"), null, null, "+473 03 (242) 21-55", false, new Guid("c5d2c00e-467d-4b46-8e39-5f7983e7d8a4") },
                    { new Guid("fa316309-6b0e-40cd-a7b0-f499261e15ce"), null, null, "+229 18 (021) 84-30", false, new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("fa4bf22f-c3ff-4ffd-9ac4-dec98ef08c52"), null, null, "+964 47 (595) 85-00", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("fa7a0b23-eae1-4d78-8201-18943c9da548"), null, null, "+553 69 (899) 98-46", false, new Guid("776875f6-ec81-43cb-ac8e-1debcd4e41a2") },
                    { new Guid("facaf9e7-9983-41ae-a12e-507944e0a14e"), null, null, "+267 24 (939) 34-57", false, new Guid("9f924849-6e21-44d2-9e1e-2a9041f71df9") },
                    { new Guid("faf969b2-72bb-46ec-b301-93190ffb785d"), null, null, "+86 47 (484) 53-84", false, new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("fafe274a-af02-4119-a837-16bc8aa50864"), null, null, "+828 84 (056) 20-53", false, new Guid("771969a8-06aa-4f11-a623-9ffbe1a6042f") },
                    { new Guid("fbdbe21b-c258-492a-af1c-321abb858135"), null, null, "+695 43 (523) 39-51", false, new Guid("a95924cf-66c2-4870-b67c-7f0808f7b7cc") },
                    { new Guid("fbe05fb6-6d22-4201-98a2-47f27acf79dd"), null, null, "+280 38 (920) 21-65", false, new Guid("7a9537b9-86a0-4627-845a-43fa235d1c6e") },
                    { new Guid("fbfeedd8-95e6-488a-b541-616bd988be39"), null, null, "+309 41 (430) 87-22", false, new Guid("ed14fdb1-c587-46fd-b6d0-5458c8f844dd") },
                    { new Guid("fc060978-4646-4c4b-b51e-e1156fa2a085"), null, null, "+523 99 (242) 66-51", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc135ff1-0b46-4c26-aeb9-b9dcb3c39338"), null, null, "+967 12 (985) 86-56", false, new Guid("3bfea84c-8f06-44ad-b9d5-09bb64dcd4ee") },
                    { new Guid("fc7aa687-3b4e-4c46-98a8-dd995f87010a"), null, null, "+895 74 (761) 61-13", false, new Guid("6b52c41d-3bf2-47f3-969a-d9f9b344eebd") },
                    { new Guid("fd6bae2f-14fa-4c5e-98eb-328ef598a68b"), null, null, "+949 72 (562) 07-59", false, new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("fdee1a91-5f24-4096-a708-3075f276550a"), null, null, "+273 64 (254) 06-49", false, new Guid("74cce926-8de8-4f15-895d-c4ab56501ecb") },
                    { new Guid("fe28efda-eb0c-4e39-aa95-9b52708ea84f"), null, null, "+815 53 (579) 37-01", false, new Guid("a40e2013-0615-4cf6-82e5-5e136f732285") },
                    { new Guid("fe4510c2-4e13-42f1-b6fa-519dcc337496"), null, null, "+729 93 (921) 74-22", false, new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("fe671226-3f6d-49b2-aa0a-afd7462626df"), null, null, "+61 31 (497) 32-27", false, new Guid("a1121e45-a56b-41c3-9953-664e8a5e4df2") },
                    { new Guid("fefe68d2-f393-4958-864d-a62697075ba7"), null, null, "+45 42 (368) 26-14", false, new Guid("0bcfaae6-4e02-4a8d-bf8b-593c2de4d808") },
                    { new Guid("ff10f050-b912-47e0-9fd4-81eef7c0dd6f"), null, null, "+180 98 (557) 89-22", false, new Guid("5a1ef0bd-673d-4cbc-be3f-c951239d0265") },
                    { new Guid("ff30d422-8f6a-4565-bbd8-7e4f59a5254f"), null, null, "+407 47 (029) 06-78", false, new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("ff343edd-e775-40b0-9b6d-32ede814040d"), null, null, "+582 12 (839) 82-58", false, new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("ff401fca-0d9f-4f67-9375-2c392fac7209"), null, null, "+405 23 (319) 01-78", false, new Guid("fcece836-8a31-4164-8bfa-b14059865b6f") },
                    { new Guid("ff848e61-bee8-4a02-b19c-12af478725d8"), null, null, "+490 26 (479) 81-67", false, new Guid("dec48cc1-dec0-4eca-91eb-f0d38c3427bb") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("000b8cd6-761b-48f8-b91f-a8899d6ef547"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d8b2039f-2612-4617-8496-a368e01f7ad6"), new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("041b29da-d78b-4e4a-84ac-ca71e065b86c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da28daea-bab9-4aed-9037-2860302f7c1c"), new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("0722f143-7651-425a-952f-c9ba01cea409"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c91c90c8-c228-4184-a7ad-51b82e8475a2"), new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("100f8eb9-beec-4493-8053-3bc55dd2ddd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("41aab371-656a-47ba-bf44-fbaaaa043f22"), new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("1612619c-16b6-4184-979a-f79266ccdbc9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bbb71dda-6ea1-4254-876c-c565214707d6"), new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("167cfce5-4912-4f48-8150-6d43bd6703df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c010d351-88a0-4560-8c7c-75e4ae50fc38"), new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("18887e76-5a89-400a-8807-ce3dafcb6431"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("22fd014c-c10d-4a80-8a58-638fd3ebc399"), new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("1ccc4fd9-aac7-441b-95a9-bcb1a3cafbde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4bdb2dd6-a656-4613-9134-ae5715d4f717"), new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("1d7dc498-2356-4783-853e-3f728cfa863a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dd3f383-8ed5-4259-b87b-79683af18770"), new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("21333d0d-6b2a-4d57-a7a1-7f43b3efac04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da28daea-bab9-4aed-9037-2860302f7c1c"), new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("2b159450-cafb-491f-a1b6-de5ab3d1955b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50eb7ca1-f745-4f1f-84ce-92eb7e813920"), new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("2e3fee0d-c290-4c50-ba41-60c785862559"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da28daea-bab9-4aed-9037-2860302f7c1c"), new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("36de8693-cc4c-4a61-adfb-d11c14bb0bba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("74ee2893-022b-41ea-b8ce-754d4c64c68c"), new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("38aab7af-9259-4bd8-9528-8808f5c05873"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fa965852-0681-416b-ac4d-13b8e2020248"), new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("3d651bdd-b6d7-49ee-85ce-f5225e4cdc6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d8b2039f-2612-4617-8496-a368e01f7ad6"), new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("3ec0e2a7-6978-4922-94cd-25269c72ee45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e409ca37-b1ed-429a-8d57-f2fdeefff9e7"), new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("40449950-bdeb-4ceb-a87e-1b83b7805bf4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eccd73db-e9e3-43c6-a35a-d90f343119ec"), new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("41e11081-1e25-41e4-96b3-8d74aa001c78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("52add87c-6b70-4d2a-8f5a-a65e3e99e687"), new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("467d5366-631c-4ada-9926-e9331e2ab023"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c6bce086-a126-4493-8ece-656a59f1ee76"), new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("46abed8f-3ba7-46ab-9d90-fd4f8061f1ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dd3f383-8ed5-4259-b87b-79683af18770"), new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("50b66e94-9819-4149-be66-2ca3b5850363"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c53360c7-0431-4b9b-8711-3cdc622ffc85"), new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("51da8390-c856-4df3-be3d-b5249996fe67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d98d3f59-8d3d-4ef4-8d02-8ee39dc36e75"), new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("5660e719-361d-4168-8781-293825bc346b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4809b9d5-6679-4c8d-a8f3-22ff6fc2c7de"), new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("5d82db0e-3799-4bea-a291-6a35afc46c88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8b2e0e10-84ed-4d34-af14-d92f3d2c9625"), new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("5fcbcf5d-c2c1-4a1a-914c-8b083452d698"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f7a577c9-b6ab-4d62-bf7b-3f5385b2f9d8"), new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("63359c3c-1649-4ffb-b686-f58abc518dec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("41aab371-656a-47ba-bf44-fbaaaa043f22"), new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("699e6487-802f-4e4d-84ba-11e882acc403"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e907cafd-764a-4ced-af01-bc3c3e539e1c"), new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("6c6c2411-6dc2-45c2-bcd9-626033ccdd17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("22fd014c-c10d-4a80-8a58-638fd3ebc399"), new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("76e1acf6-1b15-4ba5-8901-261a3a039372"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c91c90c8-c228-4184-a7ad-51b82e8475a2"), new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7802d78b-501f-423c-8c61-25b4a93e1b9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("74ee2893-022b-41ea-b8ce-754d4c64c68c"), new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("7812a197-56eb-4c19-81f0-1ed030b06dcd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a2396936-fc58-4480-8064-ef50d30812a1"), new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("79bae055-32e2-4555-a164-7537efde2301"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e383ad5a-9f2b-4c3a-aed1-c71f430ad998"), new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") },
                    { new Guid("7ddaacf0-1fbf-408d-87f8-d5ca695dffdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4bdb2dd6-a656-4613-9134-ae5715d4f717"), new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("9c769f61-911a-4cb1-8df2-dd15e3ba62e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("45f136ce-2ffd-481c-95cc-7484691c9112"), new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("9ce2409c-29f0-4b37-a966-54859c94a11f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("45f136ce-2ffd-481c-95cc-7484691c9112"), new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("9f414bc7-e399-40f9-a2da-891a92c8b87b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3d1d42a9-4695-494d-ac28-2f14422fae73"), new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("a1ae88c5-7fc3-44b4-ba0e-d0c8d71eda81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("62abbbaf-525d-429b-9fdd-b33bb8c1c695"), new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("abcffa8b-38e9-4f09-a072-7c00f623b25c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("26ff0e19-7cc6-4839-b0ef-70b4a540e356"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("bd65e648-c495-40ab-8d65-1f3afec47ead"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fa876222-dca3-4d85-9d04-1e56fa4cb694"), new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") },
                    { new Guid("c43b8fee-1d92-4d1b-8c10-31c7cc1eb456"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ad2f387a-f320-4aad-a661-33f7f0bb5e53"), new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("c707a877-fd11-4c63-bc40-84db901ce6b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("08bafeba-ccf3-4ec3-93d4-d198601222df"), new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("c7272e32-a364-40d2-a8b5-0a0ba576c8b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d33b500e-b718-4692-8ba2-a65964794aad"), new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("c86685be-7fbc-44ce-b3d2-c89f6c2a9cb6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a2396936-fc58-4480-8064-ef50d30812a1"), new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("c939abf3-8475-4017-b359-0a6a2767fb35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb6a86d3-bfbf-4bf5-a0e2-ecbaecfb4b93"), new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("d690fdb2-a5b9-41b5-866b-3375381d409d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("62c56361-55d2-456d-abc1-8c1c7d7816c7"), new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("d8f9430b-b7be-44fb-b9f2-e094a5cb831c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("26ff0e19-7cc6-4839-b0ef-70b4a540e356"), new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("de8d947c-d070-465a-989e-4719380dc689"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d98d3f59-8d3d-4ef4-8d02-8ee39dc36e75"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("e4d6b5cf-0af4-4913-affd-8fb8fca3dace"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4bdb2dd6-a656-4613-9134-ae5715d4f717"), new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("e91ba3e4-71e8-4937-85f5-85462f81ccfb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3901eb43-a07c-4940-82c9-52b6f1296fc2"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("e9f5453a-734a-4c4f-9230-6ee454448361"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5932d7fc-247e-45e8-9d6e-066673a6307c"), new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("f1dacf5d-8344-44f2-b371-85edd85b14f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da28daea-bab9-4aed-9037-2860302f7c1c"), new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("f3a5269e-33e8-46b0-9adb-7300599cc576"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d93c0e53-6b3e-4495-b2c6-4ba2a5e1d95f"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("f566fba0-8ac9-49c0-880b-708af0f470ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7175391b-1b4a-4349-ae24-a1ffac04e99c"), new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("f73f453a-fa09-4118-990c-004f518e920e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2bef7623-52e1-4125-ab5d-1342adf58c0d"), new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("f7dc5159-aab4-4540-8f02-3dc869b1123a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dd3f383-8ed5-4259-b87b-79683af18770"), new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("f82e1761-45f1-48ae-b272-6830d23de0e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("59226700-5768-4a5b-830b-70803f4c9673"), new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("f976cfbd-90d0-4a74-bec4-a31419a0e7f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("abd2a2f9-1d98-407f-a6b1-4f667a2a2f7b"), new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("f99f360f-b56b-4138-b8e5-b4bdf5456597"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7175391b-1b4a-4349-ae24-a1ffac04e99c"), new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("fe25a484-8b96-4008-9372-afc39f0fe6d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ab939c67-eba8-49b9-8ebf-446a0cf7cbeb"), new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("ffe0a71d-9f8c-494e-909e-c2394e9f2e56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e383ad5a-9f2b-4c3a-aed1-c71f430ad998"), new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("000ec262-ea56-4982-9b3d-8f89a5c331ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cdecce55-f261-4c38-8c27-94f45308afdc"), new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("03b11253-c001-4b16-9a30-7f3b4a56429e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eee41809-ce5f-49a3-860f-846ac89968cf"), new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("141e7afe-ae6c-4332-89f7-aa5c60094b0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("21da7f15-46b9-4c2b-8bdd-9babc59e8214"), new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("156fd680-263b-42d2-bd06-d7f73d18de90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d06dd21a-1216-47c9-8409-4a856add5d38"), new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("164b32b5-4f40-4e75-9566-900fbbf2c3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("43b70662-e5d4-4466-9c90-92c6bd2dda28"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("18f3f8e5-3cd9-4d6a-a0fb-34123c375245"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("56342556-fb66-4baf-ba78-a722b4fb2ee9"), new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("192622e4-8f57-4f9d-8933-3478c1b5b214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3c77bb95-0b00-49b7-9eae-6ebfdf353f50"), new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("1cc456bd-7f0e-4562-9616-78d1c94b2134"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f5ac03b8-1576-4f58-9929-77c30a666882"), new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("1d4aed02-11d2-48d9-9889-e97b731415b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2b08b372-8d32-492a-b2bb-bfb75caf3e0e"), new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("209f7a50-0706-4433-ad53-e168e6ff652b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("03ef044e-4632-48af-b4e8-69bf46a3121a"), new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("21d0e486-bf3f-462d-bc0f-b4d7d7fc81c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a92aed91-69ee-4487-a619-ee12174958ec"), new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("25ab17e1-1e8a-4475-8543-268ef3fe526c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a308b4dc-f76a-4980-b64d-b12ef96fd4c8"), new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("2d09e0c1-5019-4000-b120-4ee3eadd2137"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a92aed91-69ee-4487-a619-ee12174958ec"), new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("2d4769c6-3ba0-4121-8ef1-2e1d45f10033"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("43b70662-e5d4-4466-9c90-92c6bd2dda28"), new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("379aa837-0ff1-4a8e-b44e-c8475dfd42cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a92aed91-69ee-4487-a619-ee12174958ec"), new Guid("18e4d405-c797-4c9c-af33-613450990efe") },
                    { new Guid("3c372bad-2610-44d0-b8f5-1d0a5eb57288"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2b08b372-8d32-492a-b2bb-bfb75caf3e0e"), new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("41d2e8d1-1342-4b02-8fb2-c63680bdb719"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ad23cb16-77f1-418f-bbf2-d53691045256"), new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("43ab99d4-a3bf-4cf0-9679-a9c7f796e345"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("03ef044e-4632-48af-b4e8-69bf46a3121a"), new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("44c2950b-e80d-4f59-86bd-b156090bdbb4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7a71bc2c-7324-435e-aa6b-f1aaf4da583d"), new Guid("b552dea4-6df2-477a-870b-1317247a51c0") },
                    { new Guid("46f091c4-347e-4677-abde-30df8dae0346"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eee41809-ce5f-49a3-860f-846ac89968cf"), new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("56a2ab4d-0544-4f62-9a4e-1deea9ff4ce0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6ad5a9a7-d4ed-41a2-a49d-e4671920d081"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("62963a2b-76be-47e3-8844-7e9d5eca24c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0a7e1666-0d2b-46c0-8056-4eef8a7d2305"), new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("636e5252-e0d4-468c-ad24-8b5bbb121a55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4988960d-becc-479b-9b08-e2b5291a1be4"), new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("64c36f64-a63d-4e70-a2dc-2477ce25b973"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3c77bb95-0b00-49b7-9eae-6ebfdf353f50"), new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("6a7cac4c-e245-4a29-bfb0-cbd7c2a9c897"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da37e76d-d6ef-4602-b686-049b79812788"), new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("6db3c371-8e91-40a3-b32e-b75e5da5d8e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("290ec69b-f888-4a8b-91a4-5359b3d120d4"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("6f69b565-0692-4422-b57c-c72a10eeecfb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("290ec69b-f888-4a8b-91a4-5359b3d120d4"), new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("70d44375-e724-4ac4-be27-a1bf6c41a023"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e6a32947-6ae0-46e2-9a7c-922c68a831d9"), new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("767cb62b-753d-4d57-8520-eb5b3bf55744"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dc0f2110-75f5-4f01-84bf-d2b61b3990f8"), new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("7f7e21fb-edc2-4824-894b-b293904adfcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9cc8d25a-9d12-49da-a96b-076b287c32dc"), new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("83644de8-f8f4-4285-82b2-9644c82ec5cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7c74d06c-f48c-475b-a6d1-56222ddea976"), new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("85fb3877-557d-439f-acc6-f83adfba4693"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("19c3b613-afe6-4153-990e-6837d58ebf45"), new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("8b6b7592-d763-4014-8d64-e4af3e7edd85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3e703e0f-df3d-4cbb-82d0-0cf2d5746276"), new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("8d0268f7-1210-4dd6-9ce7-5b88f46984c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4988960d-becc-479b-9b08-e2b5291a1be4"), new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("914447ef-aa61-4833-93cc-5b87264a15b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bf892743-a92e-4da1-8a9d-cbe83c012890"), new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("9a5568fe-80c1-4804-a314-672e96465ae9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("23003272-4c2c-4a3c-b9d6-1071d0440ba4"), new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("9efaf1c5-c5e2-4176-9325-cf28cbd5c758"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6cc07e92-5e0d-493e-8865-e59f23f4a434"), new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("a384bacd-b044-477c-89d2-40bcb3f42e9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("77e5c3de-24ef-4605-a0bf-ec7b78e9d05d"), new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("a623cd27-f869-4e5b-9fca-c5ee1189334b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("36e14757-5570-4914-a823-dea6f3d11ea6"), new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("aed755cf-566f-4c7a-8f11-fabe0b355f9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2b08b372-8d32-492a-b2bb-bfb75caf3e0e"), new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("af496349-9b76-475b-a927-535da075e1da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4e1c662f-1d4e-446d-a4d3-aaa3ca688555"), new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("b5a9308a-a3ed-4e2a-81a4-0b0f02358741"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8085e6ba-7732-4c92-a6bd-b07d9d216592"), new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") },
                    { new Guid("b7df529f-536a-48df-b79a-8329f331a556"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fff62fd6-bda8-468a-895a-0ec1d2049152"), new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("b8cfb9a1-097a-48ef-8a56-c7e44ba85610"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d01d1ef-d700-47af-bdc7-20c07deba6e7"), new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("c49f2db4-10ab-4689-9d80-0fbb741efd8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("43b70662-e5d4-4466-9c90-92c6bd2dda28"), new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("c5c1082e-1599-4772-a9d8-f05fb266e39e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("084c80ae-70aa-4141-8807-23222e5b77a6"), new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("c86cad69-635b-4086-8dd0-197df5d58954"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fff62fd6-bda8-468a-895a-0ec1d2049152"), new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("c8f25706-f924-47ef-840a-b76adb8eb294"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("972eed91-068b-4f2d-bbf6-537c3119b056"), new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("cbed372a-66f3-4533-99bc-ca5422d783b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d8a3152b-88bf-4e7d-8e96-b93da618fe33"), new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("cd88cd87-2473-487e-901b-9f4df35b0471"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6aa1c24f-d9b8-4e3e-95ed-effe5dc4d0f9"), new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("d082f251-e8ba-4382-96ec-a78dbc8a5354"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e55f81b0-1647-4944-b561-cae04d35e746"), new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("d4c56398-2b8d-4fa4-996a-f38c55726ed1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4e1c662f-1d4e-446d-a4d3-aaa3ca688555"), new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("e4f975a4-d588-4d9e-a464-02147316d8b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("36e14757-5570-4914-a823-dea6f3d11ea6"), new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e606ff38-d3d1-4c3b-a9ee-83e6acf674a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bfba4540-802c-4742-a0d5-2d66eb7f6f98"), new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("e641d68a-a58e-4ffb-874e-7a256497e295"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b5af5d6f-c348-4d2e-a57b-f457eeba0272"), new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("e9b51491-ca96-4564-bfdb-07a062b6118e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e84e5692-6fd7-42b5-9bd7-b822a3453686"), new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("f05b53c0-4655-4894-bd3b-7c33f1c03bf9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6bb5f4d1-c0e8-4bc3-a9d6-4f4bef777bac"), new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("f150ef20-ceb3-4b66-b385-c88b2b49c555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7a71bc2c-7324-435e-aa6b-f1aaf4da583d"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("f6951603-a929-4124-adfd-439631d31fa7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1ce02912-486f-48f9-82e5-d6b8488f1d83"), new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("f6fa9c3c-f0f7-4458-a19f-6bf243a9dbce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1326662f-2906-4dc7-ab5c-71255720b0cd"), new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0227971f-9e0d-4336-9972-49c6c7acca77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b6255f1d-1e8c-4de3-9fb2-06cb06d7bee9"), new Guid("1185aaa7-ffe7-4550-88e5-67a8883fea30") },
                    { new Guid("024685b0-247f-49cf-8423-5fe15762864d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8877505c-813e-4920-a87e-ba93be06c4e0"), new Guid("50a38340-96f3-4c16-af8c-098f142991c6") },
                    { new Guid("03da177d-fcf8-460a-81aa-0a9415458bed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8e7c5daf-01d7-4193-bfb2-b03db3de9916"), new Guid("ddd3a3f4-a5a6-439b-b5f8-bfe3fa9999f0") },
                    { new Guid("07f6fe50-1b1b-4984-ae08-6eaabc9bb6e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ec61ebed-0065-4ba5-a2c4-41602315a635"), new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("08437b40-4fdb-47e9-89e8-8faa0493e944"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0cd37b42-11db-49e7-9989-9df8e43955a0"), new Guid("99f152a1-e1d4-4925-adeb-f2a6dc9907dd") },
                    { new Guid("0d47dc59-e41f-4f51-bea6-c2a6e767f59a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3af4232b-354f-4070-9b8e-b49a1ef91767"), new Guid("d8e6873e-ae0e-4181-866e-982565b77df9") },
                    { new Guid("14375cd9-388b-4dc2-bf65-5ca60d680805"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f57edde3-e103-4ee1-b0f3-811f354a0bb6"), new Guid("61535eeb-a09b-43e1-961d-2cb390ba47de") },
                    { new Guid("15b83df8-6b38-457b-9704-754ceb180528"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d4a9c60b-2121-44be-bc41-374b83029d39"), new Guid("9ace24ed-f865-4310-9613-b304be005b00") },
                    { new Guid("1b32b004-6668-45c9-b768-339cdda23544"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("46130f8a-1fec-4e23-8c4e-6424a6bb011e"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("1b945f90-41ec-4739-9c4d-96c838ec7337"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7a1162dc-45b6-4254-acff-5e6131c24a65"), new Guid("e91b6f6c-8f82-4d1c-8aa4-889296249367") },
                    { new Guid("1d26938a-cce7-4cb7-9a71-7d6aee11b576"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("731532da-5a34-4f69-bdad-b61692485295"), new Guid("dfe14def-42cb-4fef-81dd-e07172b8c405") },
                    { new Guid("1ecd98cc-6048-4ed8-a233-fc62806027d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00a5f1c1-0c9a-4f61-8bcf-3560bf442fc5"), new Guid("3288753c-07c2-4e2b-85e9-1279757a9971") },
                    { new Guid("1fa71996-7bb6-46d7-9892-18fc5cc98e19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6f2b92f5-6297-4b94-a1d4-4b32b1019077"), new Guid("7300e7e4-6586-4177-af99-9cca2dc5cedf") },
                    { new Guid("211a70b8-7f90-4829-9dc5-4e99ff4c0e82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b6255f1d-1e8c-4de3-9fb2-06cb06d7bee9"), new Guid("7266e85e-c57f-45da-b706-f22c1c71235e") },
                    { new Guid("2b86233c-d1a1-4f21-a1a5-72a72b20bded"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("09d3cd6c-6fb3-442d-bf0c-a6c7703f4ac4"), new Guid("fc7d7734-7b27-48d2-8b95-5cf704accda1") },
                    { new Guid("2f8b182a-87d6-4bdd-a84b-391fb1d41b12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("829f3ff8-6ec2-4f7b-95fc-e4c395451e3d"), new Guid("bb8757a7-ec55-401a-99ed-40b94ed003d6") },
                    { new Guid("3178a5a2-50a8-4dab-8e8d-f76c853abf89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("39e4a9d0-0d58-4ce1-9196-160f1e68b12c"), new Guid("a5030f56-558d-4ec8-b2d0-ff68dd12f0ce") },
                    { new Guid("34029ff7-1988-484f-8fd3-bae225759d12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cfcd3d33-9406-4193-b386-c846bf43cf65"), new Guid("ea113b1c-a037-4866-90b9-500b6e9d8727") },
                    { new Guid("3440697f-f5ea-44b2-af2d-a681132a54f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00a5f1c1-0c9a-4f61-8bcf-3560bf442fc5"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("34ceb7bf-c584-4c0a-8ab4-cd1232d6e145"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e453022a-5afe-4aea-b689-ca0ba6c69777"), new Guid("d457d4c2-b3a0-4b54-9456-1f22db902547") },
                    { new Guid("3e6bb4ac-a984-4e77-8fb5-33f4961c4d57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a75a0797-480e-4a5d-b8fd-f9d65c897ab9"), new Guid("85178881-d883-4586-bf89-10a49abb8b16") },
                    { new Guid("3f3bd5d5-aeec-4846-9012-d81370a3ee98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("576d4dcb-febe-469b-a514-df115f3315b2"), new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("4358b4e4-031f-4554-baf1-7542f4875e7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("576d4dcb-febe-469b-a514-df115f3315b2"), new Guid("0ab4c191-deb6-4129-9745-2650e9b98ca5") },
                    { new Guid("4ba7f7cf-05e4-403e-899d-cb6917edebd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("92543f7e-a69d-4cc1-8eec-b778ef829cc4"), new Guid("9bbe840f-6b35-4eb5-bc7b-1531cc324565") },
                    { new Guid("4c3f71a2-7016-4da9-8443-c662ce03b74b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("314696ad-7209-416d-b232-96ab16985858"), new Guid("2435fb6f-5e50-41df-bb4e-422f54768fa7") },
                    { new Guid("4fa04621-64f1-4261-8245-41294e292146"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("81e61668-34e3-4467-ab3f-f17987495489"), new Guid("7e4dc549-5c4a-497c-a107-332e9d0144de") },
                    { new Guid("58821535-0a77-4780-8472-b28a6d69b0e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da83b3a8-6199-49c1-b756-65a7082ce3d6"), new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("594dda21-c676-4f10-84c6-8dba0f84e104"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ef044963-e9ea-4e28-9379-71470dfdc03c"), new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("600c591c-77a4-47ff-9be0-9b474bdf7e0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cfcd3d33-9406-4193-b386-c846bf43cf65"), new Guid("b3c83d08-4770-490f-acf4-12a0ebb585c0") },
                    { new Guid("649c3138-4e45-4529-b419-8eb07f327367"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca9955c1-1401-4237-970d-b160293a6fff"), new Guid("fec9e765-d0e3-4324-a943-cea3bb08112d") },
                    { new Guid("6d0a342b-402e-4d26-9d5a-86da848ac178"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca9955c1-1401-4237-970d-b160293a6fff"), new Guid("27dd9c7d-d509-45a2-9f06-e693e5aa9781") },
                    { new Guid("6da1aa63-e2c1-4415-a7d4-73fee3e4f2ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0cd37b42-11db-49e7-9989-9df8e43955a0"), new Guid("bfda6ea3-0faa-45ce-a670-73ac71b7ede7") },
                    { new Guid("6f22e040-5d7b-474a-be4c-b3290ded0946"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("590ec811-9309-43e4-a7ec-f02a9dfa7b28"), new Guid("217a0dcf-96bc-43a2-9daa-82d7f96346bd") },
                    { new Guid("71ba41fd-6145-467c-b8c3-22eff0e2017b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7de51b68-91c9-40c2-94db-0275e11d831e"), new Guid("e4f69cc3-53bb-4602-861f-7ce18f9eeed7") },
                    { new Guid("7dde60af-2403-40ca-9039-3c1f337367a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0926aabb-81aa-4d48-9eda-a2cc3d9fa3f2"), new Guid("18e4d405-c797-4c9c-af33-613450990efe") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7e98d0b5-3980-4f97-b930-421f58a88aba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("731532da-5a34-4f69-bdad-b61692485295"), new Guid("67421d1e-5702-485e-b8e7-42fccca07695") },
                    { new Guid("80177c09-ef7d-4689-ac63-ce4b8a87ce9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("43e15563-ff40-4692-b904-0be69d42c476"), new Guid("465c4e88-ae28-44b2-9b11-780e59b9fd78") },
                    { new Guid("80d9ce4d-1039-4557-a467-d786e51b9707"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3578c783-1832-4939-b5f3-a76b7c3eb51f"), new Guid("9fdc1dd5-5bf4-4c47-ac8f-f8f86447f00d") },
                    { new Guid("8ba513bf-6e66-4b30-aa3f-f1dbfad25f7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5515544f-bca7-45d7-a4ff-082f6538dee0"), new Guid("22ae019c-504c-4802-8974-ef4e0f2397d6") },
                    { new Guid("9104ac1e-2e1c-49ac-a371-f231ac81bdda"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("314696ad-7209-416d-b232-96ab16985858"), new Guid("e881572a-cd4a-4d95-bf26-6855a9394560") },
                    { new Guid("977cb4a8-0f7f-4c52-bb27-df06887c2a33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b924b7d7-b51c-4f3c-8770-0de2e90bd8ae"), new Guid("f732ed2f-7142-417f-92ab-088d5cdc7c0b") },
                    { new Guid("9ca1cd6a-12a6-4c82-b38a-7e79a3270161"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f57edde3-e103-4ee1-b0f3-811f354a0bb6"), new Guid("cbbe4eaf-1d16-4937-8248-e6de08abbc19") },
                    { new Guid("b68be54e-cdb6-4799-b3ea-665e75bb223e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e72f5045-8335-400c-96ed-251bf6549105"), new Guid("b98ba13e-fb2c-459e-bae7-e5428eb1cff2") },
                    { new Guid("b73695a9-b497-4825-8f0d-1b9419caf48c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1df72f25-29db-4d6f-ae43-7c470ee4cad0"), new Guid("558db05b-0b8d-442b-8166-524709ea133f") },
                    { new Guid("b84b0e9a-b458-4472-afdb-78a2fb9c741f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00a5f1c1-0c9a-4f61-8bcf-3560bf442fc5"), new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("bbdc81f9-532c-4b72-8878-a4233d7ed8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c56a8f75-8d75-4d72-993d-0d179320aaec"), new Guid("80527681-e153-441a-b963-5dad43aab962") },
                    { new Guid("bfee3fd2-a05a-491b-8333-a1a3cb1b4c65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("314696ad-7209-416d-b232-96ab16985858"), new Guid("58526312-a56b-4b29-b8d3-e131efce8cef") },
                    { new Guid("c8f4539d-7e3d-4c32-b602-0425f0f93561"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b33c9298-b89a-4ab4-8039-a6ecc079f430"), new Guid("acfa7a52-cf75-4836-9441-2dddc1ede693") },
                    { new Guid("cbac2329-6ef5-42cc-83ae-d5b53e14a7d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("590ec811-9309-43e4-a7ec-f02a9dfa7b28"), new Guid("355d10ff-a6a1-465b-8cb5-e9a2724b04c5") },
                    { new Guid("d78dbb7b-9664-435b-be40-653a3a44e682"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0926aabb-81aa-4d48-9eda-a2cc3d9fa3f2"), new Guid("bc3570dc-810c-4892-a977-7d4a2bc880c0") },
                    { new Guid("d941bbba-9a94-4750-9b77-f19a01daeaca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("64575632-2416-450f-a8a3-50c94b33a41d"), new Guid("1f8ce0fd-48ed-48c7-bec4-912327a81ed8") },
                    { new Guid("ddb58132-6f8d-43e9-a23e-7e07d2fdbe78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("afb64c2f-50c3-4324-a371-f2161a078afa"), new Guid("cf028e63-bd8d-4137-b9dc-bae64c7fefe3") },
                    { new Guid("e39a5637-818d-4f45-b321-8320277744ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("64575632-2416-450f-a8a3-50c94b33a41d"), new Guid("3ec7ef1f-041d-4be8-b18e-301d0e5c5a35") },
                    { new Guid("ea956c07-3c18-4333-94ac-d11ccbfd40e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("304f4c14-4446-403b-8b95-c73033e32ec3"), new Guid("87884942-9d13-450f-b485-62321f667eab") },
                    { new Guid("ecc9a51d-eac4-444e-8721-6d52ea7904a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cfcd3d33-9406-4193-b386-c846bf43cf65"), new Guid("6f58466f-941b-41ab-b169-4bced1b3d9a1") },
                    { new Guid("eec068a2-66f4-4601-8d1f-43570783be2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5524aa3f-9c87-4878-97a5-1175c41edd3f"), new Guid("e31a76f4-5bec-480b-974e-4e00950656e8") },
                    { new Guid("eef37595-f859-4d57-97a9-78ce28c0c425"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a1852d4e-f6d2-4a67-a5b5-e0e3128929b1"), new Guid("1aa447cb-8acb-4ad0-8c68-9398d4537b33") },
                    { new Guid("f495ec55-6c16-45bb-add4-9ad94962750c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ae02935b-4420-4284-965b-11c003b5375d"), new Guid("9ab73f66-6024-4e36-86e0-ed988e7f3f2a") },
                    { new Guid("f8411ff6-1774-4c86-a12c-de34270cf8aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("576d4dcb-febe-469b-a514-df115f3315b2"), new Guid("cbb9c833-3c10-446a-949a-4c1e681c77db") },
                    { new Guid("f846f3fc-6b7e-4b53-a848-63fbe9cd202c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("44d3a917-7f06-4b17-bbcd-ad5d5eb80536"), new Guid("b552dea4-6df2-477a-870b-1317247a51c0") }
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
                name: "IX_Emails_EmailAddress",
                table: "Emails",
                column: "EmailAddress",
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
                name: "IX_PhoneNumbers_Number",
                table: "PhoneNumbers",
                column: "Number",
                unique: true);

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
