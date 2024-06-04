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
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), "c73cb111-faa7-4e4a-9eb6-de5a234ab8b1", "Admin", "ADMIN" },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), "8d430d1a-e6d6-4188-897f-49af920c98fa", "User", "USER" },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), "49ab9f25-761f-4057-ae05-a0b2a2fa8308", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("02500051-99f5-4144-945b-877e80352edf"), 0, new DateTime(1957, 10, 13, 12, 29, 15, 520, DateTimeKind.Local).AddTicks(6954), 112.1392411427740000m, "1636242c-a0d1-40f7-b81e-7fc33b70e615", null, "Noel", null, "MacGyver", false, null, "Noel_MacGyver16", "AQAAAAEAACcQAAAAEKbJ5ci3qAOHcTE2Rxz/Cx9touF604pmnFC/QQAYJxhVbHigf9+nKSgpUB95p3Yw2w==", null, "Female", false },
                    { new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f"), 0, new DateTime(1940, 6, 17, 14, 20, 59, 50, DateTimeKind.Local).AddTicks(9933), 832.5395122682710000m, "c65e9cc9-888b-4f1a-a866-b82111a54867", "Theresa", "Theresa", null, "Reinger", false, null, "Theresa37", "AQAAAAEAACcQAAAAEAOFmeXnhSrkbxDznaDJmG9DT5i4QsWLbCUCZIhenX7+VtYhZo3Yts6SgWEGesxWDQ==", null, "NotSelected", false },
                    { new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3"), 0, new DateTime(1955, 12, 19, 13, 21, 16, 338, DateTimeKind.Local).AddTicks(9296), 849.9579399881510000m, "edabe3bf-f868-47b6-b0c8-d36925638307", null, "Ed", null, "Schaefer", false, null, "Ed.Schaefer46", "AQAAAAEAACcQAAAAEHR9DHrq1fngB3VIt04dTckhVMxeikzQjmcM1/HpDE36N5f5e3j3mX2cQRKDYRdvbw==", null, "Female", false },
                    { new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640"), 0, null, 345.022047146330000m, "2acb0f3d-29ab-4e08-a1ec-89adb874b6f9", "Becky", "Becky", null, "Konopelski", false, null, "Becky_Konopelski", "AQAAAAEAACcQAAAAEOGYoBzcQcXpSZvLJe8j6Vxl2k3GeOStUbYdrDbxngfEgYhPTYSc00wvO5bp1dBEIA==", null, "Female", false },
                    { new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf"), 0, new DateTime(2009, 4, 19, 7, 40, 2, 653, DateTimeKind.Local).AddTicks(7336), 133.8880011809830000m, "4a3d9bbc-3842-4f47-98ec-bbdfd2fc03e2", null, "Sophie", null, "Hessel", false, null, "Sophie.Hessel", "AQAAAAEAACcQAAAAEImWGajzm4T65GtSfIWVAYp/7aYWsDA3tOdwwBpTR2415+rivVB8g461wwFTvsDezA==", null, "NotSelected", false },
                    { new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20"), 0, null, 188.5733065715170000m, "bfef4042-04dd-4525-899c-364098741b8d", null, "Darryl", null, "Schroeder", false, null, "Darryl.Schroeder", "AQAAAAEAACcQAAAAELUS0qCXgkSfV6sUnaB2HE0RAojpHtzwKw1ZND+HgHsgqGrjp4xvyGCHLDCt5GCV1Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084"), 0, new DateTime(1945, 7, 26, 23, 44, 36, 947, DateTimeKind.Local).AddTicks(8850), 784.8975038647860000m, "e0a58c47-6019-49f1-8187-7c8cbca9b497", null, "Herbert", null, "Lowe", false, null, "Herbert_Lowe38", "AQAAAAEAACcQAAAAEOviEoSb7HLqQ2ioumTrPa3++7tc9mZlFEQmmIJFwze+IQauRriaaOaACexQC9gudQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("06011f47-6f44-443c-a5da-5bb7964a0933"), 0, null, 22.01283980561490000m, "493747cc-6419-47ba-9b7d-cab6d20b20f5", "Ann", "Ann", null, "Schuster", false, null, "Ann80", "AQAAAAEAACcQAAAAEGAOth5x/hp3Z6/1+wMfck3mqwmRXsMtdoSfDaXG+qT1DHTeXKEIC+1KRTW88xH3Ng==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c"), 0, null, 78.18045886761580000m, "8f2732b2-6ca7-49a9-b7e7-e826832a427f", "Henrietta", "Henrietta", null, "Reilly", false, null, "Henrietta_Reilly13", "AQAAAAEAACcQAAAAEMAn2bJ7dVhNmysa4YgnGIKZOpJay6gOIrPCzMd8rNCWmE1oiSSISCKfcbVd096KuA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("072b74c5-5e1d-46de-9caa-66d36218f554"), 0, null, 331.5439622177290000m, "392d8c3c-4211-49a2-b84a-0c8a5788caf5", null, "Ella", null, "Emmerich", false, null, "Ella.Emmerich", "AQAAAAEAACcQAAAAELmevufCfxE6x1mPm4iIuZMIeN7PbRLn7d9dEXeSNj0Po0yvNssdzrh4SmHPeWuTfw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940"), 0, new DateTime(1991, 6, 8, 6, 3, 14, 733, DateTimeKind.Local).AddTicks(5494), 105.7859419774940000m, "aa33fb8d-c5b5-4db2-8dfd-12dc9fd360f7", "Mary", "Mary", null, "Gutmann", false, null, "Mary17", "AQAAAAEAACcQAAAAEMs0Zp+e4YiSjq7r+5UZVTgN00R53fTPuWYYrxyZVqzgVwhI64wlZrMjNFhkOnNmAA==", null, false },
                    { new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb"), 0, null, 819.8454083558250000m, "c40b4deb-db4f-424c-8025-b3d524f96260", "Delia", "Delia", null, "O'Hara", false, null, "Delia_OHara", "AQAAAAEAACcQAAAAED1k9DPg18cqO3FIAM4OjR1qBVcUoVQTJKLIjWVxfj2n/cqg/aV5xgs7HNFlXD4YWw==", null, false },
                    { new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab"), 0, null, 43.81662713148370000m, "6d6d7f83-7b6e-48aa-b77f-90a1d4e692b5", "Noel", "Noel", null, "Smith", false, null, "Noel95", "AQAAAAEAACcQAAAAEKJPP8OVgG8nAzO5iAlKNIwx+OA3uxKnaE++/Woyuke3AEUNYA4UFATLeOXY7+5Xiw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f"), 0, new DateTime(1997, 8, 27, 18, 41, 48, 427, DateTimeKind.Local).AddTicks(5769), 652.3455682639680000m, "f2161d3f-c469-40f0-8b66-1f220425562d", "Edith", "Edith", null, "Cummerata", false, null, "Edith24", "AQAAAAEAACcQAAAAEPvVi3s6KxuSaKe1Z9qLRIXo+BDXaLMIZTLJR6ttkF0oujJoft+JkbpOr/wo8k1OwQ==", null, "NotSelected", false },
                    { new Guid("09fd275e-b209-4f17-84ed-5884b76fc276"), 0, null, 764.9150420749990000m, "ef71c0c3-4801-45b9-9034-609e4c6355b3", null, "Shannon", null, "Senger", false, null, "Shannon40", "AQAAAAEAACcQAAAAELUevnXyzXzCKz+lbU0XU2Sr/mEL1fljbC3dflMYTa5stwhOkYPEmPG4RD7sswL2tw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16"), 0, new DateTime(2001, 8, 17, 2, 55, 58, 459, DateTimeKind.Local).AddTicks(746), 794.3318792555250000m, "cf14e320-db45-445b-bfe3-e1acd976ef08", null, "Jack", null, "Tillman", false, null, "Jack.Tillman77", "AQAAAAEAACcQAAAAEMskGHARd41dCmal3Wl/WYq4Jxw4lKcaCILdV1Kq26t9po/VQXobnosO8Gx+CyHwbA==", null, false },
                    { new Guid("0ec20584-d26f-41c4-b682-05916743e30a"), 0, new DateTime(1998, 3, 12, 13, 21, 7, 607, DateTimeKind.Local).AddTicks(9188), 829.3300228770930000m, "e4ddfdbd-f98b-4e47-89df-784b1d1581db", null, "Benjamin", null, "Streich", false, null, "Benjamin.Streich", "AQAAAAEAACcQAAAAEED0Jc/unEmMMHVSBaOgMPMMu9EhoziE4CaJu85904cY0FkJ9pBHFhBr756DSDYpHQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5"), 0, null, 886.9418048056360000m, "951e4cae-cb56-467e-a7e8-a65a2d9cd28a", null, "Erick", null, "Wisozk", false, null, "Erick_Wisozk", "AQAAAAEAACcQAAAAEG/y5lMqmUz763l7waIH2VjUaRsgF7GcBbGfM16ZTeTw4VP/toQWfH8tUwdFe4W+Wg==", null, "Female", false },
                    { new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3"), 0, null, 305.2748431406710000m, "2f8d0cfc-7d49-4406-82ec-418bc041e46d", "Andres", "Andres", null, "Skiles", false, null, "Andres.Skiles", "AQAAAAEAACcQAAAAEI9fATLOf26mbOS2yk6FggjZuCmzEUkw+b8D/+KN0/SgLge5jvFTaTRlnoYTw5hNFg==", null, "Female", false },
                    { new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756"), 0, new DateTime(1941, 2, 11, 18, 5, 34, 273, DateTimeKind.Local).AddTicks(8093), 958.2154915146880000m, "fffa2e21-7317-4d14-84b1-368da59b6092", "Ellis", "Ellis", null, "Schamberger", false, null, "Ellis.Schamberger", "AQAAAAEAACcQAAAAELauWSo1QyZF+qJVjT3Jiy7wkXJkQgYI6Py7t5pMeLpSTRrUQRqJG8uCt9/yzfxyig==", null, "Female", false },
                    { new Guid("11712f31-db09-482e-bdab-2c19dff98304"), 0, new DateTime(2007, 9, 10, 1, 25, 55, 685, DateTimeKind.Local).AddTicks(7507), 45.35259792745060000m, "b176f678-a06b-46f0-9520-6217eb699eb7", "Kim", "Kim", null, "Koss", false, null, "Kim_Koss", "AQAAAAEAACcQAAAAEHL14O9mE/vF2fuxyfcIjxhtIvIOxtvLwRdcEiICX0p/TmxC6DX1iqfgl4rSxy5eig==", null, "NotSelected", false },
                    { new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826"), 0, new DateTime(1936, 11, 6, 19, 53, 51, 359, DateTimeKind.Local).AddTicks(4671), 616.9887308337240000m, "a26b8b9d-b72e-4686-b16a-5ce9a43b0b93", "Dana", "Dana", null, "Blick", false, null, "Dana31", "AQAAAAEAACcQAAAAEOTesIlZmcdGf5bcofPzPW/wvzF9+tvGwCoycxWtgAKWUxwSD/BQ6/NnpeuqbGA5yQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("121881ba-a56e-41d4-80e8-e59f5def1562"), 0, null, 494.8163058519080000m, "134add5d-e502-4447-90b2-144d4c67870d", null, "Lonnie", null, "Corkery", false, null, "Lonnie_Corkery", "AQAAAAEAACcQAAAAEEjluZaWzFOUWxdMLIb8NRnFxliIxIr9QIW9/2LQzbHq8y5s/UKPXV8g+kF6kXwh/Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3"), 0, null, 205.9876463080970000m, "5668d0bf-a53d-4c34-89fd-9f78d7ad8659", "Fredrick", "Fredrick", null, "Koch", false, null, "Fredrick58", "AQAAAAEAACcQAAAAEPjR5xWh/13HMgSBMX25p/hUi2aMCtISPEnv4zRssgzQAjAyn16N3jJ0lxH6JphWKg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3"), 0, null, 119.7284519594930000m, "11a850ba-946c-4ce7-a94b-b88db6086f98", null, "Robert", null, "Rosenbaum", false, null, "Robert84", "AQAAAAEAACcQAAAAEJNEJdITe7EiYV1zvduQwq+0/UlvzgqVFl5BV1SL2zXU0AzrNqXS5iQGeOmibNzbmg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69"), 0, null, 70.66944569573960000m, "82265be2-aa48-4777-a095-6b66b5ced519", "Kari", "Kari", null, "Frami", false, null, "Kari.Frami", "AQAAAAEAACcQAAAAEBmqvQj1Bxjnh+ApaBTzu1zoPp5mQ0FgKZsKO6gvH8TMyFSap6y40KwSMs4iJ6VGgg==", null, "Female", false },
                    { new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1"), 0, null, 191.9164986312650000m, "5771c6a1-ae5a-4e03-a9cf-62eaa9339370", null, "Jamie", null, "Johnson", false, null, "Jamie81", "AQAAAAEAACcQAAAAEKbpwGEVX2tJcoezCFpY51cgZG2GksHmF9Zr67nLZcbz8NCdxQqu9xCU+WNJxKoksg==", null, "NotSelected", false },
                    { new Guid("1909a070-eed8-440c-9e1c-16073e761c90"), 0, null, 190.5016109389480000m, "2558f116-7e00-4aaa-b21d-4b41c846c035", "Anita", "Anita", null, "McGlynn", false, null, "Anita91", "AQAAAAEAACcQAAAAEATA4yWm4S8ag73MENqOQUj0LnY63e3H9gJS2E+PHI6bsLW+N8Uz62JbhxbtBg1LIw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04"), 0, new DateTime(1940, 12, 1, 4, 11, 0, 166, DateTimeKind.Local).AddTicks(950), 693.2919375037490000m, "0ba1854b-5bfb-4803-b5ad-5617174a06bf", null, "Cesar", null, "Corwin", false, null, "Cesar.Corwin13", "AQAAAAEAACcQAAAAENT9hGRA2NBQ2rzgkjgO4mvgfcalZ4gMKYKZcZqAMfKWi/VhvFpquYnzvk22t+abHQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a"), 0, null, 138.4435793851250000m, "fccd755c-c037-4aca-bdd4-1fe9a4a7ffb0", null, "Lucia", null, "Bednar", false, null, "Lucia88", "AQAAAAEAACcQAAAAEHybp1rDxhakqX0XeyRfGoXIVuaNf9ozklYzAr0bPzkNhQSDhFaTlXZBOxKx7MS4OA==", null, "NotSelected", false },
                    { new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d"), 0, new DateTime(1941, 9, 13, 22, 3, 29, 432, DateTimeKind.Local).AddTicks(8832), 168.924348498810000m, "1543bd74-e3e0-41c7-af5f-f871f770f956", "Roberta", "Roberta", null, "Klocko", false, null, "Roberta.Klocko11", "AQAAAAEAACcQAAAAELl+a2gnm2dDhVgRZ0FVcJhAiabRFFMtYDK9oCCIjpGFpvgyYQwmRNBtyczVvHi1ew==", null, "NotSelected", false },
                    { new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17"), 0, null, 569.1253197756080000m, "74c783a8-47ec-4b7b-aa11-48dd9205f751", null, "Judy", null, "Becker", false, null, "Judy.Becker", "AQAAAAEAACcQAAAAEMQA8Ca1tYFywgf5zgGxB0D8uYunNbl4b0pqcn2ie5uOHmDXMvyQEwCJXWNMMB42Wg==", null, "Female", false },
                    { new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2"), 0, new DateTime(2002, 10, 17, 7, 52, 22, 419, DateTimeKind.Local).AddTicks(2070), 880.9681334962320000m, "9e218fb4-9c20-45ae-b9b2-d7260bf03e9e", "Thomas", "Thomas", null, "Lynch", false, null, "Thomas22", "AQAAAAEAACcQAAAAEFBh9YKUxtT/tFA2VIjmJVoWp7Q4Q/vDFLNOx9+lHDloOcV5ViRJfKWFJoAUwFDX9Q==", null, "Female", false },
                    { new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), 0, null, 447.806372445760000m, "480c8ba5-ac5c-4900-ac41-0dcc4da0a11b", "Casey", "Casey", null, "Kuhlman", false, null, "Casey4", "AQAAAAEAACcQAAAAEEZhZCVCQrEPR+/BqnGr0XUGMX1WU7A8ftcYXYzLa7Mfq9zU/n7aZXSNgQyLBZqJYA==", null, "Female", false },
                    { new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512"), 0, null, 35.5718644997620000m, "c4b80979-7b9f-43ab-94a1-019357ea0d85", null, "Edwin", null, "Nienow", false, null, "Edwin_Nienow", "AQAAAAEAACcQAAAAEPc5tYkkYN0IJ4PFKmpBgASW4tH2MnLFQGNBrtRKrtIYnQfsgUW6LxmfTLO2BLKpvQ==", null, "Female", false },
                    { new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432"), 0, null, 549.3835826096170000m, "76c277bc-617d-4126-8c31-e6ba3549aab0", null, "Elvira", null, "Hermann", false, null, "Elvira45", "AQAAAAEAACcQAAAAEGFhs4NjPx32sTXRi2EuEJ+AMXRJNQb+BJNjJdR+l4XVPNtv9At+7tVhG1HKa46QPQ==", null, "NotSelected", false },
                    { new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d"), 0, new DateTime(1981, 7, 29, 2, 30, 44, 292, DateTimeKind.Local).AddTicks(7534), 81.22588378189040000m, "f0cc2b5b-3751-4008-9890-bec89d10e3a4", null, "Mattie", null, "Rice", false, null, "Mattie32", "AQAAAAEAACcQAAAAEG5Yh9oJKKW19GCDGhNnl6QysKWnwkjJNb6U6nzupD77LZpU2GQyKyITLLy95MLtLQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("223295f7-9195-4510-8bcc-44f043830497"), 0, null, 136.3582655666130000m, "fb540cfd-b6ea-4e65-980f-c32b964d9f98", null, "Clyde", null, "Ernser", false, null, "Clyde63", "AQAAAAEAACcQAAAAEPjJhZJlV6Or8JltGd8vIvVR+UKxtz2Ex+mtZ1A1LkqIdbTyruyoLo4nD9cKRdwGkQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), 0, null, 328.9515694528840000m, "74733822-ff00-4037-86fd-26dff1cd1bc5", null, "Joanna", null, "Corkery", false, null, "Joanna.Corkery", "AQAAAAEAACcQAAAAEDcpIc9RAKmooH27lzSzO7rVA7I56LqpSSSg6BikEHj/VdLHodIgcIO9H6zOc505Fg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("234cf821-c69e-41fd-b13e-68660060a87e"), 0, new DateTime(1995, 6, 8, 1, 9, 33, 445, DateTimeKind.Local).AddTicks(5204), 644.3655471112470000m, "39459bef-7042-41de-bdbc-f1d250be11ce", "Jimmy", "Jimmy", null, "McClure", false, null, "Jimmy.McClure", "AQAAAAEAACcQAAAAEKC5Hdq24lPrR2wOUSNiUYy2a8mEjH3FGw9kGRitCusIJwbCLAAGBqac4X8E7DfiuA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84"), 0, null, 645.7495807362330000m, "8440f85d-b688-463d-9e8e-b6081b10a3cf", "Violet", "Violet", null, "O'Hara", false, null, "Violet.OHara", "AQAAAAEAACcQAAAAENlH8LH5+4OdZG0wbcQpSl6XwfBtxXGQ/FS8axMYWzoy/EjyYVwjpo7IE7nOSSm3fg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f"), 0, new DateTime(2007, 7, 5, 4, 29, 38, 782, DateTimeKind.Local).AddTicks(5265), 115.307910160330000m, "4b9a2945-1c3e-4025-8273-5a345eaff56b", null, "Hilda", null, "Donnelly", false, null, "Hilda_Donnelly", "AQAAAAEAACcQAAAAEPiuVA3Yq9JPdbfTPirIFakPOST+yKC+YAOS/BdHMnpLuLBT4muKven8ltPHzjzJmg==", null, "Female", false },
                    { new Guid("26db4c52-c906-415a-848e-eb60cadca362"), 0, new DateTime(1934, 11, 18, 4, 36, 3, 478, DateTimeKind.Local).AddTicks(2617), 547.1993785280820000m, "28e43aa4-6160-4811-9ab0-0690380889ae", "Donald", "Donald", null, "Greenfelder", false, null, "Donald.Greenfelder35", "AQAAAAEAACcQAAAAEIKaI4jaxHtSKu+NGoxxIbf8bvi4kaRznG9COjaQrcs3KWYCb+MLIZ8UgVgyDtV7Hw==", null, "NotSelected", false },
                    { new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a"), 0, new DateTime(2001, 10, 28, 3, 59, 52, 416, DateTimeKind.Local).AddTicks(1290), 233.2441557128710000m, "f156c6ff-4e62-4e34-8ab6-7849d3b459ca", null, "Cameron", null, "Gerlach", false, null, "Cameron_Gerlach47", "AQAAAAEAACcQAAAAEE0tpC6DJeAiB2ie8Xim2PimsyRgJ2LtLQE8bgav/eAjHkwTnvEccsNgEg/F8Uav6w==", null, "NotSelected", false },
                    { new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58"), 0, null, 780.0721219776720000m, "e2d4d155-c7b6-4bf5-80d2-0396e991acc9", null, "Perry", null, "Casper", false, null, "Perry17", "AQAAAAEAACcQAAAAEDI1eWIEXwdZa0FKHpqGbdURJu/RauXNzdwOTYbn2nBKZeZYbq7mdsfqyvRMXL2N3g==", null, "Female", false },
                    { new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f"), 0, null, 969.3006450472230000m, "7b03fe6e-fb71-4d88-8d4c-44fea86bc3dd", null, "Lucy", null, "McCullough", false, null, "Lucy_McCullough16", "AQAAAAEAACcQAAAAEHnESxL7LCST2wbp1OcNhtYrow3duLgoHdjqxxF6RUlcY/f3hT7xgtQYRGKMSRZGzQ==", null, "NotSelected", false },
                    { new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9"), 0, null, 893.6377529983320000m, "19a5c084-1a47-4cd9-ab29-dd2f63ce4d09", "Crystal", "Crystal", null, "Huel", false, null, "Crystal.Huel43", "AQAAAAEAACcQAAAAEJBJwBa4wL7UaJHOOP8q1kbwtkz96RSg1dP36lbqQBB0BagW8mCK4Wl1wuqZb6b3vg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa"), 0, null, 189.89542658860000m, "a61e2607-973d-4b1a-977b-5be313386dcb", null, "Herman", null, "Leuschke", false, null, "Herman59", "AQAAAAEAACcQAAAAEPCUJktDdRTKBfAwlxdRMKftZnAnoBPRtNm4szGKdmLREEMPL7xgEZzRz8bjF1ob2w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797"), 0, null, 423.2964681955870000m, "157ba084-a5b6-46ad-b165-0f97478600e8", null, "Joshua", null, "Wiza", false, null, "Joshua_Wiza", "AQAAAAEAACcQAAAAEG4hA+xEc7/uab+sQynNRhY6s+8Es3Yaf2FzoNyLZar++nb9Bq+veC8aKVwm5/BAdQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483"), 0, new DateTime(1932, 12, 11, 13, 26, 5, 444, DateTimeKind.Local).AddTicks(2759), 448.8949086950550000m, "f6644089-8c6f-4cc5-905e-127e58736db3", "Clark", "Clark", null, "Harris", false, null, "Clark_Harris", "AQAAAAEAACcQAAAAEFhi7PMDOARy6tiSE2E5cP6L6u/4r0z+w3Hs47xmUn8HvCdIhnNk+c9IXsRVtYPo9w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0"), 0, new DateTime(1992, 3, 16, 22, 0, 37, 773, DateTimeKind.Local).AddTicks(301), 769.6264979932710000m, "7eda30b5-c83b-4970-a7c6-0141844c5721", "Rufus", "Rufus", null, "Johns", false, null, "Rufus4", "AQAAAAEAACcQAAAAEKXPJkEoO0lA+TEqlxDIu/LqASsgE4wJMf1yPTfjY2PoMPvyy0Vyr9WhnFDQHm4NKw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f"), 0, null, 810.5440304424780000m, "1b2eefe5-940f-4787-92fb-e03f9c31e9b5", null, "Josh", null, "MacGyver", false, null, "Josh94", "AQAAAAEAACcQAAAAEHwZfwvUHlKVPtj95Fmw9oez/32gMocnjHkdZPgfAFs6va3R/HKpSNiA9XE0krnJfA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9"), 0, new DateTime(1995, 10, 10, 11, 50, 0, 614, DateTimeKind.Local).AddTicks(3057), 220.4079068561070000m, "ddf6d0cc-6b13-43ef-9544-3fd55605cc35", "Stacey", "Stacey", null, "Wuckert", false, null, "Stacey_Wuckert80", "AQAAAAEAACcQAAAAENDi4JueMjd5SXQKhxl3gOdu3Xmi//MAubP5LEccENAHcnlM2aoryo0WLwdKTsOdOQ==", null, "Female", false },
                    { new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020"), 0, new DateTime(1983, 1, 8, 3, 28, 59, 251, DateTimeKind.Local).AddTicks(298), 127.5339408952270000m, "1e59baae-7b5c-496c-a031-7803254bfd25", null, "Angel", null, "Rath", false, null, "Angel.Rath33", "AQAAAAEAACcQAAAAEKvDUYd05P5PAFPxU/Y49jYp20VTKU3HS+caIGHSptnz9ev+nXiE41Ft/uSpvgijnQ==", null, "Female", false },
                    { new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c"), 0, null, 214.7050957902350000m, "40d83bcb-1757-481f-afe9-e148d3f603b3", "Elijah", "Elijah", null, "McCullough", false, null, "Elijah_McCullough", "AQAAAAEAACcQAAAAEG536omm0npMAKjsBEQdcl1gwotIpSdn1b/Bc6/aqcgqp7JNwG6z+4dr2jcO+1Pftg==", null, "Female", false },
                    { new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565"), 0, new DateTime(2004, 3, 17, 3, 51, 27, 786, DateTimeKind.Local).AddTicks(2875), 551.8913743816430000m, "a0f192ca-c5a9-4c7a-b43d-06096c6b75b0", null, "Lucia", null, "Lynch", false, null, "Lucia.Lynch", "AQAAAAEAACcQAAAAEF53U4M48hEZY6CJG8C0E0mvvGneh2FoK8PyceXxQIKQ3WUCkyXvurbm6ts9de7HSw==", null, "NotSelected", false },
                    { new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803"), 0, new DateTime(1969, 8, 10, 3, 20, 23, 802, DateTimeKind.Local).AddTicks(9010), 570.6475278620040000m, "5b6b52a4-25e6-434f-905c-12938b4469fa", null, "Ernest", null, "Williamson", false, null, "Ernest_Williamson6", "AQAAAAEAACcQAAAAECdwrO6v1lNK9b+Yk6Wzd7vMzCnuvmrK7IxproMtk1KNXiddLxoOgHG5TI7FK4AeJA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f"), 0, new DateTime(1991, 5, 1, 0, 45, 2, 149, DateTimeKind.Local).AddTicks(7625), 804.6863950389790000m, "9320accf-b5a7-48e4-8877-de5cb54e9c59", null, "Angelina", null, "Ernser", false, null, "Angelina_Ernser12", "AQAAAAEAACcQAAAAECIJj5fvBEDIrPeSPNeTMgsLWefhnk6dhpTrtuHFjThZRNLBM2RsgGhovBqYBQspZQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3525c903-c292-4d3e-942f-aeae98225a62"), 0, new DateTime(1971, 1, 1, 1, 51, 7, 934, DateTimeKind.Local).AddTicks(6008), 488.77316401250000m, "c14336e0-c45b-4e52-a58f-b564ec0e775a", null, "Aaron", null, "Renner", false, null, "Aaron.Renner", "AQAAAAEAACcQAAAAENCHXusySaI338jmcwSKM59kz75gYtj/F+RMNYGDOU8P4E7oZ7eQf0Fgzuhg4M0kpQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("35263c47-5006-4ddc-a824-47120f6a334d"), 0, new DateTime(1994, 2, 9, 5, 1, 56, 576, DateTimeKind.Local).AddTicks(4174), 712.0375733155460000m, "5a3a6703-8d9a-44c6-9309-a4283786ed07", "Nathan", "Nathan", null, "Jacobson", false, null, "Nathan.Jacobson74", "AQAAAAEAACcQAAAAEA4XD7E7qKZvQqSomdl2OV6/OubdKBgF0X4W9zo/q1XFJMqk3c1cZEhGBiL+OUzwzQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("36b35b89-da67-408b-9178-d5d020a70822"), 0, new DateTime(2000, 8, 17, 8, 43, 58, 649, DateTimeKind.Local).AddTicks(172), 50.570495509660000m, "b5fddfa0-346f-441b-8a2b-59de64459a8a", "Phillip", "Phillip", null, "Spinka", false, null, "Phillip9", "AQAAAAEAACcQAAAAEBXnvdiZTtD5ug/vIUNgYD/SgyC4mobHqq+Di8gHMBU0XBP5xylty6ST2dV1PX5S7Q==", null, "Female", false },
                    { new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc"), 0, new DateTime(1989, 5, 17, 5, 9, 15, 984, DateTimeKind.Local).AddTicks(3522), 299.008627770310000m, "e5270362-bdbc-4a16-9c07-a7aafee3c727", null, "Krystal", null, "Prohaska", false, null, "Krystal_Prohaska", "AQAAAAEAACcQAAAAEJ6BvyN8ZjfYoXuibUZkyYu8b4JTfnddDdcPOdqQNjA47nGYwDJBcn1qfVy4vkzKow==", null, "Female", false },
                    { new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938"), 0, new DateTime(1964, 8, 30, 5, 40, 50, 223, DateTimeKind.Local).AddTicks(8787), 803.8445607927710000m, "168e991a-5d1b-44c7-8d74-0f5498f3ad49", "Rafael", "Rafael", null, "O'Conner", false, null, "Rafael44", "AQAAAAEAACcQAAAAEHIvBczzTl+gDNlKSryz/kTrMKEGqjuEG+ZY5gbbDGvp6wkC6pB2/EFnSvhTWfdizw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00"), 0, null, 276.0414710455580000m, "8ddf63f3-4c60-4ad4-a155-362acd050968", null, "Nathaniel", null, "Wolff", false, null, "Nathaniel93", "AQAAAAEAACcQAAAAEM8jdjEoZ5Su2lW9SrEhslH+Q2q7agOV18IP384KHcRBkTIYc+CbXI43a/leRabUXQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da"), 0, new DateTime(1975, 4, 25, 17, 19, 32, 251, DateTimeKind.Local).AddTicks(2011), 724.1175697642860000m, "961d0bea-8187-47a0-9c52-47913aadad2f", "Andres", "Andres", null, "Borer", false, null, "Andres_Borer", "AQAAAAEAACcQAAAAEG7Fe4plsFYP02/wHWoGvp3xGKo4ehpHnVbwSVDNvx5IJRY6Pks6DrbzGgiBtVSb1A==", null, "Female", false },
                    { new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1"), 0, null, 358.8917274799970000m, "10ccbdd1-7cf0-4268-b9fc-2606b70869ed", null, "Toby", null, "Mertz", false, null, "Toby35", "AQAAAAEAACcQAAAAEP60xk95KqD0tI4s9NCLkiZ2DTjrLzImI5Uh+jHtLsRQZK2TS22hwveNvxcCK0mL3w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3855a279-823e-41a4-ad2e-768e134c626f"), 0, new DateTime(1987, 1, 12, 5, 58, 11, 522, DateTimeKind.Local).AddTicks(9477), 54.15683571091510000m, "90d3b901-3bb6-46e8-92ea-c76f682b01c8", "Jenny", "Jenny", null, "Bednar", false, null, "Jenny.Bednar70", "AQAAAAEAACcQAAAAED4ieN3MmXPNRcmVtz8eRN2FDVhLedtz5Yq/ZblCCC0bfdHlDHnzsq2EaxCqxyggSw==", null, false },
                    { new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a"), 0, null, 837.8942472116290000m, "278ce337-89c1-4e5d-8e32-522b6a533617", null, "Al", null, "Barrows", false, null, "Al_Barrows73", "AQAAAAEAACcQAAAAELQW/7FLkJ5LjVt9WWDrTZE9McsxIha1cQdnbFrXo4yGMadpWZBGrOdovc2W2e7xjg==", null, false },
                    { new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61"), 0, new DateTime(1942, 7, 15, 6, 27, 26, 533, DateTimeKind.Local).AddTicks(4532), 460.5351772474260000m, "8fb092e1-6b46-4667-96c9-0c8e5957a0aa", "Marvin", "Marvin", null, "Prohaska", false, null, "Marvin88", "AQAAAAEAACcQAAAAEMyhC9dzMTy8IWNdWdNG72YVcWZEAdl3MbnHFDvhK6VKaAks1KE89LICgAZf++tCww==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f"), 0, new DateTime(1930, 12, 2, 23, 20, 55, 11, DateTimeKind.Local).AddTicks(8615), 620.828179747950000m, "4bbd27fe-2b48-4944-ab8e-f4234085eeb5", null, "Ismael", null, "West", false, null, "Ismael_West", "AQAAAAEAACcQAAAAEAaE+jNv5kLdWul3KYiBwBly4ECVzjOINtFqdc9AzYa6GqShFv/cDX22M8WUgigXDg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c"), 0, null, 699.5057181559110000m, "bff5bbfe-9993-41c0-8226-b250791980ea", null, "Alice", null, "Bergstrom", false, null, "Alice_Bergstrom", "AQAAAAEAACcQAAAAEK5IwTL2ocakq+i032qGr5b1AOtIUyYtF2w99mD11KhyXraoOVKHJnpCNjW0tbvIEA==", null, false },
                    { new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46"), 0, null, 670.4705358682710000m, "1de06533-261d-4118-85fa-dc2e11869463", null, "Lauren", null, "Schumm", false, null, "Lauren_Schumm49", "AQAAAAEAACcQAAAAELD3Jl5/enlwsfgb72L5pkVP2Izr0v2S4kSmaHu7FfzTCQOmgv019vqv09azXz8wNg==", null, false },
                    { new Guid("41bf7410-7941-4fca-a717-3874d970309c"), 0, new DateTime(1984, 10, 13, 13, 2, 50, 156, DateTimeKind.Local).AddTicks(402), 738.8394388843750000m, "99c5227e-6b27-4e45-990d-727a1bf6d229", null, "Byron", null, "Trantow", false, null, "Byron_Trantow24", "AQAAAAEAACcQAAAAEDLbl2AhATgTtimft+ijOKSdsxfryL3s5l2LWjB6wRUD0jZexqt1nih8SG2rvHUiaQ==", null, false },
                    { new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff"), 0, new DateTime(1981, 7, 25, 2, 16, 10, 304, DateTimeKind.Local).AddTicks(7466), 472.4172085630410000m, "3a39c121-006e-477f-851c-cf4a73b4dae8", null, "Mary", null, "Vandervort", false, null, "Mary23", "AQAAAAEAACcQAAAAEDSOv8iKEPgA2vk0fL8q8erQ+BMpxbCbSqHtDeUBz8r1Qgwscdj2lwA1ZqdQ/8bULg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07"), 0, new DateTime(1935, 3, 12, 13, 29, 9, 837, DateTimeKind.Local).AddTicks(5093), 464.4133038692860000m, "247f3d99-3d8e-4ab2-9da4-e8aad2bdff8e", null, "Bernard", null, "Cronin", false, null, "Bernard.Cronin31", "AQAAAAEAACcQAAAAEHmRFlDvY7PxQXq1CGCD9+4drEt6LSbXF6rpVAW++ZFxMndx5oYu+3avRsDTQWM84w==", null, "NotSelected", false },
                    { new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838"), 0, new DateTime(1986, 4, 4, 20, 41, 8, 162, DateTimeKind.Local).AddTicks(2809), 86.02783231861360000m, "458dd09e-6d7b-46a7-ad55-bc4754dc98ee", "Zachary", "Zachary", null, "Jerde", false, null, "Zachary_Jerde", "AQAAAAEAACcQAAAAENuoHdcieJkygy5EnGo3xYC2dVMczQb1T5U09HYjJXO5xUJoQx/kduHcctXMZSiC8w==", null, "NotSelected", false },
                    { new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3"), 0, null, 416.3676738666970000m, "48d50a9f-e70f-4199-b6fd-affd1d726258", "Sarah", "Sarah", null, "King", false, null, "Sarah_King", "AQAAAAEAACcQAAAAELEyBVONH8B/0R+EQ3SY+06NIH51YkChcYmXUdUKAM21O97MiY3e6j4U5Hq40UcW0Q==", null, "Female", false },
                    { new Guid("44275811-c945-4a4f-8382-272488a907aa"), 0, null, 83.42672854091330000m, "1988e480-bedd-4612-bc12-d9ee133e8663", "Sophie", "Sophie", null, "Padberg", false, null, "Sophie41", "AQAAAAEAACcQAAAAELS6OYIwE6K1CpurDLejN8/ZeplVtt9ZI5YOYvQX9OiUAJvpwJZ3mmixvuLZWSPiUg==", null, "Female", false },
                    { new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7"), 0, new DateTime(1935, 11, 14, 13, 47, 56, 494, DateTimeKind.Local).AddTicks(4464), 466.2771326754590000m, "a539e738-d7e8-44cf-bb9d-2e645f3f7f4a", "Frankie", "Frankie", null, "Rippin", false, null, "Frankie.Rippin", "AQAAAAEAACcQAAAAEJjRP8eiiO3EHaClKuLikawExQ0B2DMjMVm5qSIXPzEAQZPYCmUA5ySJGQ+zzaiUTg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f"), 0, null, 165.4167544188190000m, "968facae-62e1-4c47-812a-af5b3ee4eab4", null, "Ashley", null, "Ward", false, null, "Ashley_Ward28", "AQAAAAEAACcQAAAAEGIAkY7WAA88hl0kpzf46q5AEwZrrBu+m4gQYAesHEKPOzIyRZUy6F+3o/MHGHqrnA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("44736c29-d473-4b0c-9aca-5f9518cda391"), 0, null, 106.5228052715170000m, "cb4d415b-80b9-4894-8b5f-b2d3c101adef", null, "Erma", null, "Parisian", false, null, "Erma21", "AQAAAAEAACcQAAAAEF56rXrTrhEOSeHSVhMSZ12YN8m6L41B6K5iueyWP0yoaRC9UMvtlmeWYt3BJCF8cw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6"), 0, null, 539.1429847476940000m, "540773b0-4d94-4f57-995f-e324bb02ae8e", null, "Toby", null, "Marquardt", false, null, "Toby82", "AQAAAAEAACcQAAAAENhpn5cJeCHIB2C+6AfVlG/1vmkSaURfBw2+ZK1fKFOnVhSOGELHdkhrVbd1QkHrOg==", null, "NotSelected", false },
                    { new Guid("46075330-4d61-4bde-be40-948e47bd19fb"), 0, null, 186.0066169230450000m, "e7d06d24-ca1f-4dac-b649-e587090c714f", "Francis", "Francis", null, "Heidenreich", false, null, "Francis.Heidenreich42", "AQAAAAEAACcQAAAAENYM8k7tdr57vprKl4dFN2LQtAZ+KoKUbVgTAae2wFvynh4czq2//bmqKXcS6gQq7w==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("489038c7-0441-436a-a527-66069a8b1473"), 0, null, 715.7712987444420000m, "3b9dbb63-1238-4fef-97d2-3fa5dbd0a2f9", null, "Violet", null, "Blick", false, null, "Violet.Blick", "AQAAAAEAACcQAAAAEPCjm9g1anPXL3lhVEEPgh1FtANkBtdLbSSKG/IDUPoi13S2KMDW46isGs6vyJL7mw==", null, false },
                    { new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128"), 0, new DateTime(2008, 6, 23, 8, 12, 20, 385, DateTimeKind.Local).AddTicks(6623), 438.5390229318680000m, "007dfe81-7137-4028-8840-3aa01a03cf74", null, "Jim", null, "Simonis", false, null, "Jim.Simonis13", "AQAAAAEAACcQAAAAECKUzgghAE3WeStq2yNCAfDErTLHmntFQzHqvMAUuXS4m8AB2LNIO+RoYNpsqdsAgg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2"), 0, null, 713.322766942110000m, "69e0f27f-b8ad-43c0-9036-f84cae7d3c8e", "Terri", "Terri", null, "Tremblay", false, null, "Terri67", "AQAAAAEAACcQAAAAEO3rO7luzZew0hxsEW3qrjzoV7R00vOr26oMRb/WnU1Z1gTxGewVO5DVZ6xrizcoPA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5"), 0, new DateTime(2006, 3, 9, 17, 35, 44, 698, DateTimeKind.Local).AddTicks(3879), 847.0939636011040000m, "921104a3-77fe-4bb1-89c8-bd3658251e48", null, "Josh", null, "Botsford", false, null, "Josh31", "AQAAAAEAACcQAAAAEPBpeJ+ypqUTfENPqjTdWS7OEaHRarJkHU1RGreeH6qjD3niRn5W5GcfszDEZhSBTQ==", null, false },
                    { new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835"), 0, new DateTime(1934, 2, 8, 15, 48, 46, 55, DateTimeKind.Local).AddTicks(3946), 827.7222881747080000m, "57951ccc-b070-4582-bf80-a4613231a73d", "Wanda", "Wanda", null, "Flatley", false, null, "Wanda.Flatley27", "AQAAAAEAACcQAAAAEF5NSIaXIsPsiJU0lACgo4nk/DMogwUNs6NHDNNkNSR0GnjHi1Ip2wjDDPajLuZnMQ==", null, false },
                    { new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b"), 0, new DateTime(1956, 1, 14, 16, 58, 39, 319, DateTimeKind.Local).AddTicks(9245), 820.0034566837720000m, "2db76219-d510-46e8-a6e1-672866019038", "Ismael", "Ismael", null, "O'Reilly", false, null, "Ismael10", "AQAAAAEAACcQAAAAEK/fOMi6XZSSSqEGn15dAfzaxKH9b17kRaOUfa5SbB8Y4EXowFCx/4E06/TINV4goQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742"), 0, null, 530.7808128368450000m, "a0c2a09e-b37e-45c1-a451-2f0d398f24c1", null, "Alice", null, "Beer", false, null, "Alice.Beer29", "AQAAAAEAACcQAAAAEF57QhZilwT0FQ5tEV8ZCK1uhJ5/vIwVXpichbpQzRTdWE+Z7e25+6LtMXWnW6LMmQ==", null, "NotSelected", false },
                    { new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e"), 0, null, 836.3690064792590000m, "727da1bc-807d-410a-aff7-7c0dcf008a56", null, "Kristie", null, "Glover", false, null, "Kristie15", "AQAAAAEAACcQAAAAEIoNeC5yx6xuC9vN/GFbpNUpeINyA0ZxAtYF1v7iVhaT2x1MM8UHt4YdMIC4+yuzXg==", null, "Female", false },
                    { new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285"), 0, new DateTime(1951, 4, 20, 18, 10, 27, 999, DateTimeKind.Local).AddTicks(5530), 297.2700571834740000m, "709be306-cdb5-411e-b201-6f356ec73e2e", "Madeline", "Madeline", null, "Reichert", false, null, "Madeline49", "AQAAAAEAACcQAAAAEIYHgbPL+QVNTpPhRb+UU4Y1odZ1Ur3QATaUEN87zrhcY8QKJMD2NlrAWPXfoi59uQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), 0, null, 926.8626628735180000m, "4349269e-c8d4-46ae-9ec7-7d3ddada218c", null, "Latoya", null, "Cremin", false, null, "Latoya.Cremin66", "AQAAAAEAACcQAAAAEB+LpnOli5ZbJGwTIBK6jd31Dmn8YUZtzwBnE7OVFcdxNPBbM9bIdbdJVMCfdHZ5Xg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("4e8e0581-239d-4586-9cca-aad850d7d329"), 0, null, 787.6793154434850000m, "a303cef2-40c7-42fa-b145-cc367fccd725", "Glenn", "Glenn", null, "Renner", false, null, "Glenn_Renner52", "AQAAAAEAACcQAAAAEInaVSQxFvL6ritdfrJmtY8GCyngqQmMDQhofz8MCCyFcgxJxMT75DCzu9tNeRW87Q==", null, "NotSelected", false },
                    { new Guid("504f690e-3a1c-49ed-94a4-1238f972b696"), 0, null, 634.9085256579480000m, "02d3d0dc-1778-4a7e-92c0-6f86eee3004f", null, "Monique", null, "Nienow", false, null, "Monique.Nienow63", "AQAAAAEAACcQAAAAEKVMXIuTIcOqZ6Th6EMNegjvseqopBib6FQafpoYVcmypV7GEMkQGwLRLco04ROysA==", null, "Female", false },
                    { new Guid("5227b046-d260-4727-89e6-90bfa60f5f27"), 0, null, 490.8456949247480000m, "5ffc5192-7986-4d20-ba6b-6ce0c9b5cda0", "Dora", "Dora", null, "Pouros", false, null, "Dora12", "AQAAAAEAACcQAAAAEMgBZyHIGQEHMO4WQaRo/mQrOE5nWKeN3H2xnN9AJJg5duaqk/wt8wJDwXAjEwJQXQ==", null, "NotSelected", false },
                    { new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a"), 0, null, 164.8811566608730000m, "07906333-7a13-4948-9674-1758b5ea5bec", "Gregg", "Gregg", null, "Shanahan", false, null, "Gregg.Shanahan77", "AQAAAAEAACcQAAAAECOxDCuApRsco4mwwC2i8fFL0vlwjyR8+HJKBjciGaSju6vbSS7zf2BF/9WbaiyRpQ==", null, "NotSelected", false },
                    { new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4"), 0, null, 959.8463348944140000m, "c22af4b5-8c99-4c68-97d1-199979d09ce0", null, "Tyrone", null, "Kuvalis", false, null, "Tyrone_Kuvalis1", "AQAAAAEAACcQAAAAEFiil5gXKTjDxGz4B2jBal+Q2tEW00j+2XZJyHJWYzTraz46LzZTpr77naoockx4zw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("56acd153-5467-4111-9ca4-96f34533a050"), 0, new DateTime(2002, 5, 12, 18, 11, 15, 493, DateTimeKind.Local).AddTicks(2395), 516.9549473610870000m, "a6a714d1-9d67-4a21-b435-f43b5d82e6a8", null, "Nora", null, "Sipes", false, null, "Nora_Sipes", "AQAAAAEAACcQAAAAEJrZV/sbLSUNz0OWdv1wk4/NI/nxBktEFB0H1KA0aaAHJbtIbhJ0d3q7W3OP4eMKRg==", null, false },
                    { new Guid("57710136-3092-497c-8523-6e222848ceaf"), 0, null, 43.35632994816140000m, "5892019a-c21b-4eed-9231-0ec2d4190745", "Bertha", "Bertha", null, "Barton", false, null, "Bertha_Barton70", "AQAAAAEAACcQAAAAEKd8jwt86VmpxB6qNROKlD3y6lg6QzTEYtbRuW2UiqfouENR/hp4Daz8UChPsmlwdw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a"), 0, null, 859.9545844652820000m, "e5dd8f6b-11ea-49e2-9843-d5638e5ccbc2", null, "Todd", null, "Satterfield", false, null, "Todd69", "AQAAAAEAACcQAAAAEOafsrBaLLO6BU8FcWsCZfcfhpjFcVEj9JGcfnGTUOJhzGfGCOPXiJrx1poV90johA==", null, "NotSelected", false },
                    { new Guid("58a68d56-e166-49e9-ab53-b148a241cc49"), 0, null, 648.4743565286920000m, "16c54865-4223-4877-a9e9-eefbe0e44a54", "Violet", "Violet", null, "Ullrich", false, null, "Violet_Ullrich32", "AQAAAAEAACcQAAAAEPz4c2mZuxyRZDq4P4xTGB/A933tSKW+R+jiknHmEF6tgd0JTzuFDoyJDXE2LRkg0A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5967c8b0-b331-4553-bab0-23d04868d703"), 0, null, 734.7668735548510000m, "f7793bdc-0966-457d-a50f-8c4eabe27eb4", "Beulah", "Beulah", null, "Ritchie", false, null, "Beulah_Ritchie41", "AQAAAAEAACcQAAAAEGmz3t0aLrcIpuTLADBKMk7kJFy72qVsOv4hzu2ohylKzOsOKbA0JDO/lCGv3nbaiA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("59917ef6-495b-463e-9d58-75b21f8544bc"), 0, null, 475.781157523040000m, "78218ad8-e995-4b0a-9062-0d7e4bbf735a", "Bernard", "Bernard", null, "Leffler", false, null, "Bernard.Leffler", "AQAAAAEAACcQAAAAEMXJeDvX12p8VkeE1TTdmAhG0UX+bOfnYdl+BcW2CYaQ7vDltMEauavaxAzuqvn4ug==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1"), 0, null, 788.4543628324070000m, "d350d45a-4853-44e5-a2ee-94c02f9de257", null, "Phillip", null, "Homenick", false, null, "Phillip.Homenick82", "AQAAAAEAACcQAAAAEKBLI6Pmf76sk9ey6RcTK04rPrSno3ZOMtUeQUX0Dl0ndaBKxyJeL19HaX5yOdsk6g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("59bca1c3-a467-4623-b95f-1679227c24ca"), 0, null, 95.57054366255670000m, "7ed49a36-9a3b-4df3-b86c-3a26b6a3065b", "Karl", "Karl", null, "Grant", false, null, "Karl.Grant17", "AQAAAAEAACcQAAAAEKsKgqIpP7BYpRQvZvLuCkbCE5fb4pXeDiJ3x1l+gaw85HI0ndpiqMTjThf92rLRQg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32"), 0, new DateTime(1999, 3, 3, 18, 7, 44, 912, DateTimeKind.Local).AddTicks(3018), 352.0982645632510000m, "a1c344b8-be3a-448e-96f3-25b67a3a9ad3", null, "Julio", null, "Jast", false, null, "Julio.Jast", "AQAAAAEAACcQAAAAEE8k1e+qUxDTramn4KFp1qq81KbDxxFSjg3qY+NaexlDr/quQNUT+JC/e7zgKbJtsw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6"), 0, null, 790.4061125142480000m, "8e0c7d9a-05b7-49ba-8152-e35507d23e37", null, "Randall", null, "Schinner", false, null, "Randall_Schinner25", "AQAAAAEAACcQAAAAEGPdNYY2M8FX3zc1bdjAH63oPnKyBK0hHKmuZtdBBFBr4TTm0GkUvuHU0geAZKu+Kg==", null, "NotSelected", false },
                    { new Guid("5db09bf3-8454-4fff-bfe9-003854416f82"), 0, null, 454.4616287195870000m, "89036e97-c583-4b18-b64f-7a7ab22beb40", null, "John", null, "Kirlin", false, null, "John.Kirlin", "AQAAAAEAACcQAAAAEJ4ciARxJWIM1x486S1mGgXUmsTVa4Vg6i6r/UmtejZf3K7qGURhvNLjHFsv44Z1vw==", null, "Female", false },
                    { new Guid("5e421353-3237-4b90-a7a1-a061d45dbede"), 0, null, 730.3990027748540000m, "f45885ed-6376-4d30-bedb-9d6188f920c1", null, "Julio", null, "Flatley", false, null, "Julio13", "AQAAAAEAACcQAAAAENR0a32rnOP4c74ocBn/S4ZF8l3C5vR5JDWPdM48ypc9LsvDMP4BrZw7KkZlW/KayQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0"), 0, new DateTime(1995, 10, 14, 14, 54, 25, 623, DateTimeKind.Local).AddTicks(5162), 368.635134724740000m, "2358aaf8-c917-4d5b-966e-94e23e20b66a", "Patrick", "Patrick", null, "Williamson", false, null, "Patrick.Williamson83", "AQAAAAEAACcQAAAAEOT3GG3QIp8T3IhkJ0vPfe5vEpBK8LlshdIXQ1kxbR+pLHhYzhzwX8E4oPrr20jxig==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5ee54399-9054-4429-a438-7a6f33482943"), 0, new DateTime(1965, 4, 26, 4, 13, 13, 2, DateTimeKind.Local).AddTicks(2947), 164.0522006616230000m, "1caa4a7e-a0f9-4f5f-9d14-a088d20355fb", "Marcos", "Marcos", null, "Crist", false, null, "Marcos.Crist", "AQAAAAEAACcQAAAAEKiMzg456OIdn1xfXTEjs6lcaFh759MwLiZuCFi1/h/GLfNIj1dI0EtMVz/R7aw1Vw==", null, "Female", false },
                    { new Guid("5f0ac6f8-c976-486f-b071-e2049e475599"), 0, null, 452.5202235454120000m, "3a0eb278-464d-4702-a686-85aab8ee62ba", "Violet", "Violet", null, "Grady", false, null, "Violet_Grady21", "AQAAAAEAACcQAAAAEKH3csZiJjs2eNhC9wdEbeKC0v6H7Tcs5UVOd9ty01T8z9tGKm0BWYOx/q9btw7NTg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5f140f7e-803a-444d-8158-03815cbd832c"), 0, new DateTime(1983, 7, 20, 15, 23, 28, 696, DateTimeKind.Local).AddTicks(3242), 92.03941348066070000m, "3bef37a0-360f-4811-8d85-b184ef8b28bb", "Kendra", "Kendra", null, "Tromp", false, null, "Kendra_Tromp", "AQAAAAEAACcQAAAAEHRRwTysmjTLi9u07682XPpOex1iZYRzbNu939nghpe51UbyGvZpGqTHgl3PQu5e1w==", null, false },
                    { new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda"), 0, null, 857.0403123546780000m, "241f48b5-ac10-43fe-9e1a-ad3cf812bad9", null, "Dewey", null, "Wintheiser", false, null, "Dewey18", "AQAAAAEAACcQAAAAEBPEYLH0//ZzSlGED/HMGZrGWV0Fn2LQe5s5MyRSDRB1L6UJfNIJJ8rkxW0iR9yP1Q==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3"), 0, null, 219.5602532527810000m, "5cdc2fd3-b4a7-4e76-b3a2-354fb240e2a8", null, "Neal", null, "Schulist", false, null, "Neal_Schulist", "AQAAAAEAACcQAAAAEDgGOi7Ikc8Yxi4oN0b4Z96D7UYdisaR4F1Dyg9htYdVyvKpDpwc8V/PqQRGbYRWrw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6085da89-2350-460f-ad12-9bdc60c6760e"), 0, new DateTime(1983, 10, 4, 1, 57, 48, 835, DateTimeKind.Local).AddTicks(3683), 552.0342114769470000m, "e35e0b2c-bda8-434c-a060-7eb2e0f1d0a2", "Adrian", "Adrian", null, "Paucek", false, null, "Adrian42", "AQAAAAEAACcQAAAAEKSLBHJa6bneijqfH3cJ+u8X9ke4cElnpaLY25Dt4eVDIwkZSJvHvx2Fi/3qxfUXrQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f"), 0, null, 437.3094335415860000m, "92690c32-b88c-4e34-aae9-099403ad8dd9", "Erick", "Erick", null, "Pouros", false, null, "Erick.Pouros25", "AQAAAAEAACcQAAAAEJhJZM3pF7iO4LuLSLi1ad/9P3YP/LTmk2u5JkSfXe3vZFFUYjkbx/Mnv1QPBZ44vA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("62780013-8c47-4235-a42a-798d9bf04220"), 0, null, 209.0373721524960000m, "1006f18a-b06f-409c-88f6-d87c43df001f", "Deborah", "Deborah", null, "Mueller", false, null, "Deborah_Mueller84", "AQAAAAEAACcQAAAAEG8b6rNZpYWaabov8S/cdIiRciCIhrfkvt3xwd9XyNZJR588OVaLxO77xEt7GjvWnA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53"), 0, null, 636.5463100679710000m, "6e676026-c5c9-444d-a5db-62efb2b936a1", "Olga", "Olga", null, "Hackett", false, null, "Olga_Hackett35", "AQAAAAEAACcQAAAAEGxyhzRkqNetG7nlCjoD/dPax/F2gRsRiBKEyIe9aXZsTtHunqHjyXTbUy2TPcdqXA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc"), 0, null, 371.8184675103290000m, "ad30fe73-1fa7-408f-928d-e3a125a5d927", null, "Sandy", null, "Aufderhar", false, null, "Sandy_Aufderhar5", "AQAAAAEAACcQAAAAEBGAI624HmTC2/+/UaSb/CNQsxlAg+HxrsAZhoZy3VJBH+/akoSyHvquJJS8pkDSSA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5"), 0, new DateTime(1927, 1, 21, 21, 55, 23, 494, DateTimeKind.Local).AddTicks(2635), 685.8724299289970000m, "f70da3f3-9dac-496c-8ac1-5b7322ca48ee", null, "Dallas", null, "Raynor", false, null, "Dallas_Raynor92", "AQAAAAEAACcQAAAAEITc9eq3Z/NmHx4ZDwzB+3FGpPEgmVDlYOdie7diGKtIjNoCgvpORuDB/PGaUQEmpg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684"), 0, null, 904.013157074910000m, "466daf0d-57a5-4399-8b34-65ee4d0fb589", null, "Alton", null, "Moore", false, null, "Alton_Moore", "AQAAAAEAACcQAAAAEFjGIM7p52J1IiAFkr9ZbukSabzwVeiY0nb+jKmnfRw+tzmLzR5KFaORRBb5/9T0ag==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d"), 0, new DateTime(1955, 12, 19, 2, 51, 22, 729, DateTimeKind.Local).AddTicks(6854), 41.352337914880000m, "87d5d379-19cd-469a-9e30-10d2e53b6f28", "Gina", "Gina", null, "Luettgen", false, null, "Gina_Luettgen", "AQAAAAEAACcQAAAAEBxf52Z0e5R4/eRmT2R2L2aatnHGphYYVXNpncnDpqr4wDSNV3au/VMqVdzLBUiLwQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056"), 0, new DateTime(1963, 4, 6, 2, 38, 4, 85, DateTimeKind.Local).AddTicks(1423), 639.0275362916720000m, "c7fdf888-cc7e-4c94-b17e-ba3b9d106393", "Susie", "Susie", null, "Christiansen", false, null, "Susie_Christiansen", "AQAAAAEAACcQAAAAECTT6GMT6iX7CcSsYkAkD6bJvQQ+oThns+EO12tTGQByptzVwGxD6IYtDnwu3uCfNg==", null, false },
                    { new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071"), 0, new DateTime(1926, 11, 8, 19, 38, 0, 986, DateTimeKind.Local).AddTicks(1596), 629.2630122247610000m, "05236d2d-dd1f-4213-84ef-e8abfac9609d", "Ruby", "Ruby", null, "Dickinson", false, null, "Ruby55", "AQAAAAEAACcQAAAAEPGo3QAoWj/dgJ36CCfJJeg5Uoi3ecgvzxUQO53wnzLjiatRhsB+5793df0QdfvPPQ==", null, false },
                    { new Guid("70409336-0f26-4108-8c79-213e320c07f7"), 0, new DateTime(1970, 10, 7, 4, 40, 56, 515, DateTimeKind.Local).AddTicks(3803), 406.4259118789580000m, "70fdfd76-0a22-429b-a5d9-9c12a0c6efbc", "Simon", "Simon", null, "Lemke", false, null, "Simon81", "AQAAAAEAACcQAAAAEH1gUWYhtiqDOZzTaqFcUUKnAL7/w5t2VeLrQfiwW/z9Cpr5gsyJquPh7LaJFqq95Q==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483"), 0, null, 956.095906832990000m, "427422ad-a17b-49fe-8baf-e49b616c4415", "Jeffery", "Jeffery", null, "Barton", false, null, "Jeffery_Barton", "AQAAAAEAACcQAAAAEEBttnD6TtX0QkKKlF+gSpmCtYkovDVU4dQkiDVZpfmKHhGtTXgwgH3Jea54z9WlxA==", null, "NotSelected", false },
                    { new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d"), 0, new DateTime(1940, 5, 17, 16, 32, 56, 980, DateTimeKind.Local).AddTicks(1066), 217.1030103846340000m, "697949d9-de80-4fd6-bc99-453f655ebf3a", "Alfred", "Alfred", null, "Spencer", false, null, "Alfred.Spencer47", "AQAAAAEAACcQAAAAEK3FXQnlvdclG8AUR7ca379Vl0TxBPSMUp0getNTYAktbYYtRtV+6eVmfIiwz8V+Nw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe"), 0, new DateTime(1924, 7, 3, 20, 41, 50, 628, DateTimeKind.Local).AddTicks(8120), 600.1230346334960000m, "2a159492-e1b3-4f1a-a51f-144563dc5ab5", "Bryant", "Bryant", null, "Schowalter", false, null, "Bryant_Schowalter", "AQAAAAEAACcQAAAAEBl4v/PjOgW1VVv80BOr8o/xQQlpztL2mQSnXbCpVGswJdGbS6k2hRF2ySkqh3w+pw==", null, false },
                    { new Guid("757e8d68-6931-451c-9e0e-78a03f927058"), 0, new DateTime(1929, 1, 18, 17, 49, 31, 550, DateTimeKind.Local).AddTicks(1214), 242.2880220768130000m, "af2e622b-b1aa-4259-8eb8-02df7090da9f", "Candice", "Candice", null, "Kilback", false, null, "Candice.Kilback31", "AQAAAAEAACcQAAAAEBaUX2QQyDoDctyyAYDSKW3x1tfSpwo9I19S8BJoIb6pCv4VxM+SjNskir00cWsxiw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("76807668-f1d2-47ed-a084-0771d51bc761"), 0, new DateTime(1932, 4, 16, 15, 2, 26, 266, DateTimeKind.Local).AddTicks(837), 33.97349570799580000m, "577cf5ee-239b-46c8-9d59-da21501c92d0", null, "Samuel", null, "Koss", false, null, "Samuel_Koss80", "AQAAAAEAACcQAAAAEKW8jt4roBRAGYGuK5WUQ8jg6AEp3XEJByrwk+55P3zwmIm2Imy3q8EBvchGnwFFKg==", null, "NotSelected", false },
                    { new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf"), 0, new DateTime(1966, 6, 20, 11, 53, 52, 99, DateTimeKind.Local).AddTicks(6903), 433.3889817927260000m, "54a953fe-6d84-4ce6-9f63-dbac7761db90", null, "Camille", null, "Kovacek", false, null, "Camille.Kovacek", "AQAAAAEAACcQAAAAEBI4q18Q+2CAWZNwirhXWEHfNcLO7es1OiHEn25xzIO5aAuT1SZJS9PggdE2Cigv+A==", null, "NotSelected", false },
                    { new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3"), 0, null, 724.7891262386260000m, "009d4fb1-09d4-4d2f-8844-4806c76de7a9", null, "Lela", null, "Leannon", false, null, "Lela.Leannon31", "AQAAAAEAACcQAAAAECKhC1HsptLDVWt8tFB/4Tq4F4huCagMa4JWaF03sOfkuurWJoMrwu0wmKNJYnGNyQ==", null, "Female", false },
                    { new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca"), 0, new DateTime(1990, 2, 1, 8, 56, 8, 110, DateTimeKind.Local).AddTicks(2608), 837.9274310071850000m, "2ac35e42-adc6-48b4-99e9-4c8ef3376d37", "Evan", "Evan", null, "Schmeler", false, null, "Evan43", "AQAAAAEAACcQAAAAEE1G5JNqnV7Zlx7fsj7cm9rIW9zfobPwqWI3V7O/17dO5hyPVPfpLThEoFWnABsBnw==", null, "Female", false },
                    { new Guid("77941635-e388-4774-9d8a-53d61f8a1c10"), 0, null, 479.5738418922220000m, "97b469dd-e0de-4246-be89-0c934622b64d", "Bridget", "Bridget", null, "Kulas", false, null, "Bridget_Kulas59", "AQAAAAEAACcQAAAAEKokXdxm8IFDg9U/r4Se4Ny16DojtQ3udcKCSsmWyCJZae2YdXZe2uUzkkrViS1Bvw==", null, "NotSelected", false },
                    { new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8"), 0, null, 439.3626878499840000m, "4845c8d2-8f67-4501-ae64-0e5327f0f687", "Kate", "Kate", null, "Hills", false, null, "Kate_Hills", "AQAAAAEAACcQAAAAEMZZknp4qpfYcDYDM20EiKrXINhJpJ3UnazLawhfsgvCiwoK67qvlmkovUIFXGnhkA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a"), 0, new DateTime(1993, 11, 14, 9, 47, 16, 786, DateTimeKind.Local).AddTicks(1695), 430.0925638002440000m, "2c64f383-e833-43be-90af-fe0f4e7e7ab4", "Terry", "Terry", null, "Hansen", false, null, "Terry.Hansen26", "AQAAAAEAACcQAAAAEOk4OLTk1fG6J7eYHpgDeSTLTGD7Tdg91iPHS3JXEt9ZP72h+RWbsdTCtX1xmiJJJQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d"), 0, new DateTime(2004, 10, 14, 22, 50, 6, 374, DateTimeKind.Local).AddTicks(5667), 11.58476633915140000m, "05ff3b0d-069f-4350-9d75-b35f8e6b48bf", null, "Leon", null, "Weissnat", false, null, "Leon_Weissnat", "AQAAAAEAACcQAAAAEFaG8DhGj8ssHZG+068A0BPXqjsVTDVcU/lxbqybc/RsVl/5YBoqqvjdWiMpnQuOiQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5"), 0, null, 743.2395015306540000m, "609925bb-c8aa-47e2-abf5-1230c945e1f5", null, "Jermaine", null, "Lubowitz", false, null, "Jermaine_Lubowitz", "AQAAAAEAACcQAAAAEJ0jP8JMTz+GhwgQVsZEelIT0iSxEPemMGVhuNfZ5f+KE54sA64mHYJet/RAVNM5Ww==", null, false },
                    { new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7"), 0, new DateTime(1941, 4, 30, 15, 21, 56, 79, DateTimeKind.Local).AddTicks(8767), 374.7145742396230000m, "6e93a5f3-ebad-4c4e-bf33-8ed64f33c0b3", null, "Kent", null, "Hegmann", false, null, "Kent.Hegmann", "AQAAAAEAACcQAAAAEFeQMInX/HvNq+IDumnHG+ZgJ9IwBIAxAthKBTbpbflbRPRqbD3vXoMOh6gy2xwCJg==", null, false },
                    { new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2"), 0, null, 911.179512313190000m, "e1bc2a21-081f-4256-aa53-56b67f75056d", "Edith", "Edith", null, "Spencer", false, null, "Edith.Spencer", "AQAAAAEAACcQAAAAEPl9AQ+xYdI8mk6Bayz8PPE3FiVoXLPg6nw6k1SBxjhvgCvMPPnHiEoM+zXRgSfqdw==", null, false },
                    { new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1"), 0, new DateTime(2002, 5, 1, 1, 18, 22, 649, DateTimeKind.Local).AddTicks(3266), 350.3604990741440000m, "895c4d78-c170-4a7c-b622-b1b760a24110", "Beth", "Beth", null, "Stokes", false, null, "Beth68", "AQAAAAEAACcQAAAAEDBpya8h7BNPssaP4v6ed4seUpQtlGyOtFwqZ0Q94890YoOHnrJcey6LPYMYfU9Xtg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe"), 0, null, 850.5817862413860000m, "8fb06d44-a86b-4434-8ea1-077f870941c9", "Emanuel", "Emanuel", null, "Mosciski", false, null, "Emanuel97", "AQAAAAEAACcQAAAAEK636PqnKe7UGJEMLvoIRUbptRD9Ww9ZAW5oD01Aey3wOIyP20agORJZLLs4CohRGw==", null, "NotSelected", false },
                    { new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e"), 0, new DateTime(1933, 1, 7, 19, 56, 22, 594, DateTimeKind.Local).AddTicks(6351), 120.3570955716270000m, "e6cde2bc-a528-46ac-9fa6-78563bd19f6a", "Lynn", "Lynn", null, "Kassulke", false, null, "Lynn.Kassulke48", "AQAAAAEAACcQAAAAEJjbi2WCJRBCpR9NaH8suOx4RkUC+REp8VaK8i08eKP2NoNSxXRGFr8LMrnCdADKbw==", null, "Female", false },
                    { new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec"), 0, new DateTime(2002, 8, 26, 14, 33, 33, 515, DateTimeKind.Local).AddTicks(1397), 790.2396133077870000m, "9aa1a33a-283d-4107-9cd8-c2892f3f6b92", null, "Alyssa", null, "Mertz", false, null, "Alyssa86", "AQAAAAEAACcQAAAAEIs5ZNq3aTlTCz2MpKHfF0Uogzpp9RH/a1LJkqcR6El6bOd7vmWHJZJtZc5dVQqNIg==", null, "Female", false },
                    { new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3"), 0, null, 653.257246605480000m, "536cd41f-8640-4346-9ccf-cad8ba79edcf", null, "Denise", null, "Price", false, null, "Denise34", "AQAAAAEAACcQAAAAENF/0wyH1MzCPYANFe2hKxlFaschmVDvOdanepb1HWKBOuuhxbn8Db2zqy6RSmnJfg==", null, "NotSelected", false },
                    { new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f"), 0, null, 892.4530091535840000m, "6aecb51f-89b0-4d7c-a77d-7e8170424353", "Lance", "Lance", null, "Thiel", false, null, "Lance_Thiel11", "AQAAAAEAACcQAAAAEDu9J5mBtfsp+paDGN+TuXbYYUlqCjvJl8Rbdb8ogTYSX9GcCCJjHBJZfIgdbrqlAg==", null, "NotSelected", false },
                    { new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db"), 0, null, 702.9217247279050000m, "c411d0ab-2028-4e1c-a564-7c7f793384a1", "Bertha", "Bertha", null, "Konopelski", false, null, "Bertha_Konopelski", "AQAAAAEAACcQAAAAECBYmoCy46QdbFw22IRIka5xc4VaBtpOKRNNB6RCeRkOIwy/ZRWua2pdrfG4n8p/Jw==", null, "Female", false },
                    { new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500"), 0, null, 104.7632112110630000m, "fbdd93fd-61e8-4d9c-8018-3f74315e4630", "Daniel", "Daniel", null, "Green", false, null, "Daniel_Green", "AQAAAAEAACcQAAAAEPS3lD1lI27Fk0MlnNwKe/QeanUQa45Pf0uUdefU6dMK73UAnfK5i9Iys1IHO2iUiQ==", null, "NotSelected", false },
                    { new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf"), 0, new DateTime(2000, 8, 20, 9, 48, 34, 661, DateTimeKind.Local).AddTicks(6346), 336.9746375079410000m, "b22d3d00-8b58-4fc1-ab5b-d5b30e58b3f1", "Isabel", "Isabel", null, "Shanahan", false, null, "Isabel.Shanahan61", "AQAAAAEAACcQAAAAEG4TgzaIe37s6/1MgFqM+3Sw/vcOeACkU3V4GWSyZoYuAJjZ777wdMzu49t4G4865A==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953"), 0, new DateTime(1976, 4, 10, 5, 25, 23, 649, DateTimeKind.Local).AddTicks(6143), 184.9677227859620000m, "347f1384-b73d-4221-991d-c4497aeb4597", null, "Stanley", null, "Cummerata", false, null, "Stanley_Cummerata", "AQAAAAEAACcQAAAAEHaJr7lVAnWoG+jlZ7xPFc41DAlw4IqV+6Vob919l5BuGJaP8JWzfzjZXJ/l+SkvQw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad"), 0, null, 4.745818773949970000m, "243ed058-c9da-4de7-9b76-9187d403e901", null, "Bridget", null, "Jacobson", false, null, "Bridget.Jacobson", "AQAAAAEAACcQAAAAEGtKJXWWnlWAZJrTKsgPRsMi/pQ+/bjuWtD4ktxdAjNIJ4DMxALzhPp2l2NoTvuWaA==", null, "Female", false },
                    { new Guid("8ae7642e-7905-444f-ad68-f873370b7b14"), 0, null, 299.7524123467510000m, "8b03777b-4d66-4561-84d2-26e044989c46", "Leona", "Leona", null, "VonRueden", false, null, "Leona_VonRueden21", "AQAAAAEAACcQAAAAEDjCNV3SzCiWdAfd+We5U3CCBdAmcQfgedfD+qlhuyp/uN2oY8dA4oXycW+jqO5TGA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8c396faa-ad98-400d-a562-77b4902806e1"), 0, new DateTime(1979, 1, 17, 7, 45, 22, 97, DateTimeKind.Local).AddTicks(4611), 678.4742204530540000m, "ef42bff3-70bf-40ec-a7f6-79870de5d4e8", "Brian", "Brian", null, "Mayer", false, null, "Brian84", "AQAAAAEAACcQAAAAEE/GQZn+pjN4E15UhQzkF9p2RufU/pOtLYT49cUku0UuFx2vzZJ6iQNJFXTNfVy1jw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43"), 0, null, 875.5410855739940000m, "4f8694d5-2642-4452-bbac-62c235bb34c1", "Winifred", "Winifred", null, "Sauer", false, null, "Winifred74", "AQAAAAEAACcQAAAAEOzXFJhreVe6pz0ZsYO7+VKfyUInbpEL3KPrXdkbm2mmIK55dykFDli/ihIqYQ2D2g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925"), 0, new DateTime(1946, 12, 25, 3, 37, 37, 51, DateTimeKind.Local).AddTicks(8398), 132.0239844523230000m, "82d4e8ba-263b-414f-9f0b-c2f1bf768b56", "Cynthia", "Cynthia", null, "Daugherty", false, null, "Cynthia30", "AQAAAAEAACcQAAAAEPiCWNOk0Zu9BE4WPmOYGRERFk/XaeF5NftdXvwghnqnupq57c1uCGcRkwmFDezUJg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89"), 0, null, 995.4490347948820000m, "ba73fa01-1e50-42a2-b4f2-23687298f37e", null, "Jason", null, "Kemmer", false, null, "Jason96", "AQAAAAEAACcQAAAAEMlhQOQLSJj+8AYiOHAIaM9vWbWOGVnQ++snWWVpeyWQUpsEYMhk9JzjidxQvKiErg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7"), 0, new DateTime(1982, 1, 14, 17, 27, 8, 404, DateTimeKind.Local).AddTicks(2454), 404.5187640281220000m, "d0e22810-48fd-4366-8ec8-4d6a6e8f1db3", "Nancy", "Nancy", null, "Schinner", false, null, "Nancy4", "AQAAAAEAACcQAAAAEOhIVY57BsZn8FT8kI51nBsAexYpjuda9gNsx1Ibgy/2nEy8fGyALnIjgnM3txbICQ==", null, false },
                    { new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827"), 0, null, 139.8578106596350000m, "68e9b55b-6f9e-4701-8cfd-319a7ea1e829", "Louise", "Louise", null, "Huel", false, null, "Louise.Huel", "AQAAAAEAACcQAAAAEB2SD+Ryld9XDV9HeGFIoD+wq7Xp6Gr6kqqGzzQUJQbxqRD5j5pyqZVsvjGPeBvFdg==", null, false },
                    { new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8"), 0, new DateTime(1965, 9, 30, 12, 33, 32, 179, DateTimeKind.Local).AddTicks(4384), 939.9303663072240000m, "d0069f83-525f-43c3-b643-92cb06851b9e", "Brandy", "Brandy", null, "Deckow", false, null, "Brandy_Deckow3", "AQAAAAEAACcQAAAAEC8JKaunWgfHp2wwDKK7kUtaVhwviLaMNI6wfLQ1lSs6wmZYh3Cwjwx9bAg2vOiQ9A==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("9202ce4d-7121-4324-8f36-f303a63531ef"), 0, null, 5.729869823647980000m, "99f7cb35-a9e5-40c3-8b4c-f2681140b56f", null, "Meghan", null, "Hodkiewicz", false, null, "Meghan.Hodkiewicz", "AQAAAAEAACcQAAAAEJXZ/IjY0JCvagb4L7FlsrsnEPNIWRSm1dpCC9AGEH2XdZtqlcErGQA8CWpss80SqA==", null, "NotSelected", false },
                    { new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27"), 0, null, 646.989214638760000m, "ed50e2fe-fd6c-4be1-ae9e-358d2cffce46", "Katie", "Katie", null, "Turner", false, null, "Katie23", "AQAAAAEAACcQAAAAEDmjYrM1O7/Ne0GtiP1EwG2LhMFoEPcXHD1eaqI7pEfUAxN4o5CKIHKVzntGDC6K2w==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2"), 0, null, 467.3045365924680000m, "899074e8-0ac2-4d43-836a-fe4367841725", "Bryant", "Bryant", null, "McGlynn", false, null, "Bryant90", "AQAAAAEAACcQAAAAEBgncJi9Of4ZEsRzgBpt9J2f2C7kFiY+0beaWwiEY6+LZaMSjsWBLq8feZen5RNaIQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44"), 0, new DateTime(1953, 5, 17, 5, 57, 25, 573, DateTimeKind.Local).AddTicks(628), 524.541843361540000m, "ce89cdce-26b9-4546-8968-cd5cf333629b", null, "Eric", null, "Jones", false, null, "Eric_Jones", "AQAAAAEAACcQAAAAEP1ybUXXJTeqsCQhds6aMJkNPsBrx2e+K15F8Pk7PAxOjCA/KXrvTVIoEI4BAs8geQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1"), 0, new DateTime(1956, 9, 17, 20, 42, 26, 332, DateTimeKind.Local).AddTicks(187), 682.218022728090000m, "1b0f6aa7-77af-4cfc-be90-9f17fe246c05", null, "Jack", null, "Turner", false, null, "Jack_Turner49", "AQAAAAEAACcQAAAAEMM/lre/3FhUa+2hp/oQefpD14pjEOJVSIsY0HwkvRYGjBrCL2AZEUCRScoWukl9wg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9"), 0, null, 256.0830792769030000m, "a28ba8ad-46f2-4370-bc6c-43c8d7ee8ff9", "Danielle", "Danielle", null, "Hartmann", false, null, "Danielle64", "AQAAAAEAACcQAAAAEOiHLXlN6p3tiPZDNd0y0foSZR6thAGXZUgdkfMXjPzvJF21Nywo88cAC8IG4D2NqA==", null, "NotSelected", false },
                    { new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f"), 0, new DateTime(1959, 1, 18, 16, 20, 28, 18, DateTimeKind.Local).AddTicks(788), 536.1817578992050000m, "b0595cfd-8a4f-476c-8252-f98a4a4b1f47", null, "Mathew", null, "Hansen", false, null, "Mathew.Hansen", "AQAAAAEAACcQAAAAEL+CyO2BC+2EbzaeOAN+t1O0kC2sb/zNGN0nhK/LWfT/bcNjeKxHiufwpEfgwd5YsQ==", null, "NotSelected", false },
                    { new Guid("95f06adb-a1fa-40bc-8351-b298d818044d"), 0, new DateTime(2001, 1, 13, 13, 11, 12, 330, DateTimeKind.Local).AddTicks(8080), 888.918198407790000m, "f3a9d908-3de7-4076-9141-4350a81a4e1e", "Micheal", "Micheal", null, "Champlin", false, null, "Micheal.Champlin16", "AQAAAAEAACcQAAAAEBnOX3vt0tc+i55eMqGLGp4KgB26k+G68QsVhJpaxe5Bf0xQYqr0J+or3dR2Jakk0g==", null, "Female", false },
                    { new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed"), 0, null, 596.382980221630000m, "3c67c376-b35b-4121-b4a0-54b2ac44df06", "Elsa", "Elsa", null, "Toy", false, null, "Elsa_Toy59", "AQAAAAEAACcQAAAAEGiJpoA3qaAoLER8o76gG9iF7tFWNfmPRYdGzDB6unVMV5ccsz33hwvdkQbEmfV6lg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a"), 0, new DateTime(2008, 7, 12, 15, 31, 24, 5, DateTimeKind.Local).AddTicks(3189), 235.0734214061120000m, "4b1c4981-7630-4892-bda5-f955723b0ddc", null, "Cesar", null, "Labadie", false, null, "Cesar.Labadie", "AQAAAAEAACcQAAAAEJ+7NIQwgMXxhOXkY2qgu2uZ965ZWur7y8lA2c30ZM9IuMKZIoiD6IoizIASbzbDSA==", null, false },
                    { new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e"), 0, null, 470.9740418088230000m, "b558a9b6-d3c7-4fda-aa86-8cdfeaf00dd3", "Rick", "Rick", null, "Tillman", false, null, "Rick.Tillman", "AQAAAAEAACcQAAAAEA3YewU7d2QQyeADNAnrJT2HIo5PRSfFKa+pSpems1udgHnE6LlnxnSUrNuHJ9ZZMg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("97253083-0ecd-4730-b815-c4b8137ab125"), 0, new DateTime(1939, 1, 3, 12, 44, 7, 77, DateTimeKind.Local).AddTicks(833), 756.7694347555440000m, "c6e06c94-25ab-4998-aedf-dda938d89c4f", null, "Bryant", null, "Windler", false, null, "Bryant_Windler26", "AQAAAAEAACcQAAAAEANySrT6xwrKi99xLhF8W5CjNVAC+LmTYmgmARcpif+sJ+S/LHlrsSuKocz0jtpQmQ==", null, "NotSelected", false },
                    { new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6"), 0, new DateTime(1954, 11, 14, 6, 14, 59, 104, DateTimeKind.Local).AddTicks(7974), 351.6886047419950000m, "355e026c-3d94-49d7-9600-c8d90cc639cd", "Linda", "Linda", null, "Bauch", false, null, "Linda.Bauch", "AQAAAAEAACcQAAAAEAEPpLEm/vNRLKpXdkeb63TFqkDL0clwMj5b66RvU3Zq3QHvN5+JbFj+qCL8tGOS0Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed"), 0, new DateTime(1988, 1, 18, 14, 21, 30, 739, DateTimeKind.Local).AddTicks(1683), 692.978332831660000m, "efc9fa4d-e485-49e5-b091-6060513d68d0", "Amber", "Amber", null, "Boyle", false, null, "Amber_Boyle57", "AQAAAAEAACcQAAAAECzvRsclfBs0LEbMPj3rrDPMX8Uev8AEGmo7QoI41i2I7eXivSx3RfosRbcjza2QeA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3"), 0, null, 14.73969343244770000m, "25a2cb1e-4502-4f60-8c21-04c9e021d4ba", null, "Jeffery", null, "VonRueden", false, null, "Jeffery_VonRueden0", "AQAAAAEAACcQAAAAENJdT+3tOQY+g9oUgr3MVep8FO7ZYQdWQr8NTUhaJ4QWHVCU1aAEtOUbDUMpxEzbfQ==", null, "Female", false },
                    { new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc"), 0, null, 494.6703245760770000m, "b6f9e309-5afd-4aef-b5f3-1dea70837dae", null, "Vicki", null, "Doyle", false, null, "Vicki_Doyle", "AQAAAAEAACcQAAAAEAYINGC2f1T9hrvFvHnyySLHIeibmaDhU/G8qxb+4Qs+/o4GFsopET0zY0+aHjm/Cg==", null, "Female", false },
                    { new Guid("99f374c8-d976-4051-99c3-7305e5fea09d"), 0, new DateTime(1982, 11, 15, 17, 17, 50, 20, DateTimeKind.Local).AddTicks(773), 625.986370863920000m, "27a82959-04f0-4fc7-9993-bd6c5bc3fae0", "Tricia", "Tricia", null, "Okuneva", false, null, "Tricia96", "AQAAAAEAACcQAAAAELmNYJOPG5bm+bhh39w7e/ApfV2gredI19SYwdCVam/9s7x9xjL/iGARKBGAgJQbwQ==", null, "NotSelected", false },
                    { new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969"), 0, new DateTime(1988, 5, 12, 18, 37, 26, 296, DateTimeKind.Local).AddTicks(3336), 504.2997708122180000m, "e3f74d94-36d1-45fa-b9a3-aba294cc2048", null, "Desiree", null, "Walter", false, null, "Desiree_Walter", "AQAAAAEAACcQAAAAEHYg2uYIhwa8769XBRDk3/4u5qpeISwuT/N0XSt2CqopovT2YRWAmX5HXRiMAQ6vmw==", null, "Female", false },
                    { new Guid("9af47343-7f95-4006-8dea-4975912f5989"), 0, new DateTime(1932, 3, 18, 16, 3, 42, 390, DateTimeKind.Local).AddTicks(7805), 235.5562784423150000m, "4095b31f-5cc3-4d2f-bbb1-63284c4072d7", "Daisy", "Daisy", null, "Lynch", false, null, "Daisy.Lynch65", "AQAAAAEAACcQAAAAEN2lVZJnl1YMbpS8SI88BhTTkssL+WKPudg8SXwvvq7Rr4AN35C5XD3bufDt5A5Q8Q==", null, "Female", false },
                    { new Guid("9bea6011-9948-451d-9195-7c4cc4339cba"), 0, null, 79.96853033055650000m, "236b9f4d-ac12-41a1-90f4-032094b977d7", "Terrell", "Terrell", null, "Wyman", false, null, "Terrell_Wyman", "AQAAAAEAACcQAAAAEGKPhPAOCRcMMKoT4TFareQOMvYglHSrHUXrdPjPEfw0UQqRgSVBNEVNglXGUXnBKQ==", null, "Female", false },
                    { new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1"), 0, new DateTime(1995, 2, 18, 18, 36, 5, 509, DateTimeKind.Local).AddTicks(1188), 388.2328024112720000m, "f3f16855-6d88-471a-bb50-e160d981782b", null, "Guadalupe", null, "Stehr", false, null, "Guadalupe_Stehr", "AQAAAAEAACcQAAAAEIr1XT4UJg6yQ18zFgjJfl4LiWqlWHbpunKfK3TzcJOssdzopeM99m0eDRAeJVtStg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6"), 0, new DateTime(1959, 1, 17, 8, 6, 44, 52, DateTimeKind.Local).AddTicks(3565), 995.096766738140000m, "65d63878-463f-472a-81ab-f45e227b65bc", null, "Merle", null, "Volkman", false, null, "Merle27", "AQAAAAEAACcQAAAAENoWEcFlW/ItY3X7htjcgOgv7dGDP7rdJ46X/ysF0a0KHcDTMT+DnPZ+gU67IPfMJA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7"), 0, null, 475.451367379030000m, "85efbc57-f148-43d9-9cca-1b67b70ca18f", null, "Sonja", null, "Bauch", false, null, "Sonja.Bauch", "AQAAAAEAACcQAAAAEMuNEnnIEaMegXjFNubGRZD8hrnR2QhITjSC+uwv4RxQQGNLH1GgZLSeVJt8F9IQeQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12"), 0, null, 523.7720533275850000m, "31fb734f-5229-4ee4-8752-7083bb4027db", null, "Jon", null, "Hilpert", false, null, "Jon.Hilpert", "AQAAAAEAACcQAAAAEKX8JfXla/oSFLoqMYkRV5EK/YKE9a8MZJ6Lv32noiTPl5d0F8mKb4XFWkztXpjmRQ==", null, false },
                    { new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607"), 0, null, 179.7390162075940000m, "35bcddbb-80d7-43f5-9d31-3541d94c89b4", null, "Rufus", null, "Leuschke", false, null, "Rufus_Leuschke", "AQAAAAEAACcQAAAAECgiKBtSVkMCK/nLfii87g0GJg9QAv7XXlQ/FztZoj2XFA3w9cAjQ2nOlHikOyNJWw==", null, false },
                    { new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4"), 0, new DateTime(1984, 1, 26, 3, 38, 3, 196, DateTimeKind.Local).AddTicks(3528), 328.4704921817330000m, "41e6307d-78bc-4242-926b-5dd7e723bff5", null, "Craig", null, "Howe", false, null, "Craig51", "AQAAAAEAACcQAAAAELGIXThn3vF7U4mOPxLboxmZUVFn3I2k6juX7SDd2lAX985KtjuqhgzF2HNETCbuSg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888"), 0, new DateTime(1954, 7, 23, 0, 17, 29, 47, DateTimeKind.Local).AddTicks(9288), 868.4103812858670000m, "9dadf343-a043-4182-93b9-9758f1ce6cde", "Lucille", "Lucille", null, "Stanton", false, null, "Lucille_Stanton91", "AQAAAAEAACcQAAAAEAchaeU1YrLqmxi00MEfgc8g1310/krCe80f9pBXhPgcSLY5YuVuzdQ2/aXoD2oKng==", null, "Female", false },
                    { new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a"), 0, null, 60.96657630559710000m, "0796993b-b60e-4637-a8ad-e95c0c4c67ab", "Ignacio", "Ignacio", null, "Windler", false, null, "Ignacio_Windler", "AQAAAAEAACcQAAAAEByTxg1fFiFPlfl/TYuOFg+zNakQuBwj32a5dElrHxyExGXjvvIW/43OGl1JtCSYHw==", null, "Female", false },
                    { new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8"), 0, new DateTime(1931, 7, 11, 2, 41, 53, 533, DateTimeKind.Local).AddTicks(8416), 199.6272298230680000m, "dd1a3d70-a72d-4204-b551-9c654d83beb4", "Violet", "Violet", null, "Jaskolski", false, null, "Violet78", "AQAAAAEAACcQAAAAEK20GpS8tk+3r+1ARpjifUL8MfTqjG/j+rIJS+9AxUkrIDmvxrDpmFCUETb96mnqwg==", null, "NotSelected", false },
                    { new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93"), 0, new DateTime(2004, 3, 1, 12, 46, 6, 510, DateTimeKind.Local).AddTicks(2051), 890.9529315017990000m, "23c98973-d9e8-42f1-8b3d-f613c083f238", null, "Jerome", null, "Reichel", false, null, "Jerome.Reichel26", "AQAAAAEAACcQAAAAELgASVNyEKOiWYeEAaiwaWzPj26zvHbnlQjjK35/6RfQ+FBMQrBRxSnUxBXkQjaY6w==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058"), 0, new DateTime(1996, 8, 29, 11, 18, 32, 300, DateTimeKind.Local).AddTicks(473), 179.0632617833020000m, "e405f510-3aed-44ab-a33f-1cf6e86842d2", "Grant", "Grant", null, "Von", false, null, "Grant_Von", "AQAAAAEAACcQAAAAEI5iAE25/qyxonE/iVCV84SHPaxkl07U+3rpQJLyBoq9qgVcDCvmQu/AUwREdRrRmw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644"), 0, null, 24.65336233266440000m, "7c685587-c1d0-49fd-801b-908c1dfb81d8", "Stewart", "Stewart", null, "Prosacco", false, null, "Stewart33", "AQAAAAEAACcQAAAAEJKojIhNNODSjDIOlEPiq1G81Y0uBCm7K+TbrY1u3qK6ZDVBnlGoeWsvm349BWK0qQ==", null, "NotSelected", false },
                    { new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32"), 0, null, 136.0775276679260000m, "6dc1dfbe-e007-4410-90e8-e102d0c07a46", null, "Monica", null, "Kuhic", false, null, "Monica_Kuhic", "AQAAAAEAACcQAAAAEFQFgS9WnUFJrwkNBhxiQqxJpBhuTLE3+T9/T5ETuRlRj9n8O2LZMDMyABs46ipkmg==", null, "Female", false },
                    { new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1"), 0, new DateTime(2001, 8, 10, 14, 9, 23, 693, DateTimeKind.Local).AddTicks(4272), 200.0292258537770000m, "932ee213-b518-497a-a585-14275e48f362", null, "Jeffrey", null, "Gerhold", false, null, "Jeffrey.Gerhold", "AQAAAAEAACcQAAAAEJW5Elybdie5L6BxyyGSMQH/4x6ebOpUiIzujVxj6R4NjnJFkcbrGGMTblPZbMEVzw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc"), 0, new DateTime(1979, 9, 14, 8, 58, 2, 772, DateTimeKind.Local).AddTicks(7472), 884.437935676230000m, "d205e417-3d69-4b84-a7fc-c1b1ec76bf88", "Terrence", "Terrence", null, "Welch", false, null, "Terrence_Welch", "AQAAAAEAACcQAAAAEBfzuNDV2BgTBM5jdDm/ibstQk6O/hw/B9sy5nEMdxmyiEkT0APRwMwbuv5iEkhYqw==", null, false },
                    { new Guid("ad755590-668c-421d-994e-b7a783d9dcd5"), 0, new DateTime(1972, 11, 13, 21, 7, 52, 740, DateTimeKind.Local).AddTicks(9130), 818.487221788050000m, "a8bc6c36-2b59-41b6-b95a-4998a84d5d6a", null, "Flora", null, "Blick", false, null, "Flora40", "AQAAAAEAACcQAAAAEBTDZJa7D3pv0yy6J65EOOwlgSar4wTk9pOMMEFNrM0ASsk0xCoP4gH2dYxQwR9rDQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2"), 0, null, 335.5858811851090000m, "9092d771-0afe-4f87-8c59-69a2460cac45", "Daniel", "Daniel", null, "Lubowitz", false, null, "Daniel90", "AQAAAAEAACcQAAAAED0xbS//P/jZDMY3nXbzp09qqiEb+TlV7mnUfIZhfFuZ9IrTvsfmB3gXU343dkIGJA==", null, "NotSelected", false },
                    { new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce"), 0, null, 702.9569373639840000m, "77c76561-76cd-4cba-b641-0795e35a173f", "Tyler", "Tyler", null, "Weimann", false, null, "Tyler.Weimann39", "AQAAAAEAACcQAAAAEFUwPAZSn80KEJE1IAgm23tCofg1815VIyAZ7Lyo3vvctuL2z8Fxrbk2zrLqVt4O2g==", null, "Female", false },
                    { new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80"), 0, null, 591.2194504765630000m, "8a959e4c-5955-473c-a200-1f5cd48bc692", null, "Joann", null, "Schuster", false, null, "Joann48", "AQAAAAEAACcQAAAAENte6UmmDgxn9eMLlQfyR3fQYG7pxTU6Ju5QGF8psAPEHw74xxJ2BFyL8qfqonyHsg==", null, "Female", false },
                    { new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2"), 0, null, 869.7580897835720000m, "71ced9ab-69fb-4a96-beff-dcb702abf87e", null, "Eleanor", null, "Zieme", false, null, "Eleanor_Zieme", "AQAAAAEAACcQAAAAEAAjrlAPoDA3KPcKpjzfbPmrV718VrymLcArp98U/QmMZX2DRU//oCZoMHMG/GnVUQ==", null, "NotSelected", false },
                    { new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd"), 0, null, 634.242042082510000m, "89efdd98-0e7f-4951-ae69-cbf0e9c92c8f", null, "Diana", null, "Bruen", false, null, "Diana18", "AQAAAAEAACcQAAAAELpih/5b62OjpGc7QYz5NLgUwCcXDP+tDAOGX26eZnl/j+2plwSqzt9HvBUBiRhTIA==", null, "NotSelected", false },
                    { new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e"), 0, null, 175.7071377545110000m, "612558a1-1fbc-4f75-aa5f-768120768ccc", null, "Maxine", null, "Barrows", false, null, "Maxine_Barrows", "AQAAAAEAACcQAAAAEKUZM7JN9wKHukxkh7cfXuV5+wOniaQDEajfeEuM4xFVEKdFhXzlcej9eseqbDwIFQ==", null, "Female", false },
                    { new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7"), 0, new DateTime(2001, 12, 27, 10, 4, 4, 29, DateTimeKind.Local).AddTicks(3278), 582.684960098590000m, "73bfd753-e490-44c8-8b4b-3b96d88ffee3", null, "Ruth", null, "Greenholt", false, null, "Ruth_Greenholt2", "AQAAAAEAACcQAAAAEG6yEPlnOQFnx5Ot2SfiX6TnCY3p5YjJ4uwi2SjPXCrYKxETrrqBDotfCZs7ptrZpg==", null, "Female", false },
                    { new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17"), 0, new DateTime(1955, 2, 27, 17, 52, 39, 314, DateTimeKind.Local).AddTicks(2760), 765.471009363190000m, "3ec0b528-c684-48a1-b191-a400b8863115", "Antonio", "Antonio", null, "Turner", false, null, "Antonio59", "AQAAAAEAACcQAAAAEIZ4Rt1xNidYCYpQLobofbOjk2bDGFQVIdaAd2BgCqc3tbzCDV0XmCCAh9/619tctQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb"), 0, null, 869.9080156539120000m, "e16681e4-b5a6-47e1-bd97-7ae0b2fc7397", "Justin", "Justin", null, "Pacocha", false, null, "Justin.Pacocha98", "AQAAAAEAACcQAAAAEG7elcnznhUFdOAC1ZoX/MTD0DswNu4j018efUHXxIhkuahRf7bUl9Tp3ic9kTLT6g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a"), 0, null, 458.5757580974880000m, "54a0c752-31f3-4a0d-a4de-dddd84dc8157", "Saul", "Saul", null, "Hessel", false, null, "Saul48", "AQAAAAEAACcQAAAAEEjIOh0ZRrwTLcByYJmWbLfnpT4XMvC7omEor+xXoal1ERHRy+PUUx3sEgbLNKXA5A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("bb76498f-37b6-48d3-b979-97246498ed03"), 0, new DateTime(1969, 8, 27, 20, 25, 43, 858, DateTimeKind.Local).AddTicks(662), 843.0542967031380000m, "5b411807-89ce-4b51-962d-cc671946a172", "Elbert", "Elbert", null, "Bailey", false, null, "Elbert.Bailey", "AQAAAAEAACcQAAAAEEUubnvxhn37yr9Ajwtryl1sWlZOTjhm+jY3exR+mooTgbuh6qmdRJRnOK5qkb0SpA==", null, "Female", false },
                    { new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5"), 0, new DateTime(1994, 4, 13, 19, 58, 11, 570, DateTimeKind.Local).AddTicks(6038), 745.5751705314120000m, "ef379bd4-6634-4c56-825a-3b22d61e1378", null, "Hattie", null, "O'Connell", false, null, "Hattie.OConnell17", "AQAAAAEAACcQAAAAEMm8WZO4louksPvw1//arlLE6xHN3QQ8lpRxUGYie9Gy/ohRlclnq/nL3J6W7EgPIg==", null, "NotSelected", false },
                    { new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6"), 0, new DateTime(1942, 7, 27, 19, 21, 18, 210, DateTimeKind.Local).AddTicks(8626), 763.7964361292820000m, "e5dea542-6a00-499d-96a0-dc6615d16808", null, "Noel", null, "Collins", false, null, "Noel_Collins", "AQAAAAEAACcQAAAAEIjUrpFL4SYZoNw+j8FTJPqVr+UfWEp9gRuKXQe5mEErgDXac3xdF40WSMv0r/8PSg==", null, "Female", false },
                    { new Guid("be43e642-1907-4f60-913b-2b34c8343cdb"), 0, new DateTime(1966, 3, 3, 9, 23, 43, 359, DateTimeKind.Local).AddTicks(9033), 681.2639361864830000m, "4161f9d7-02f5-47d7-9f1d-28223070ed44", "Dorothy", "Dorothy", null, "Wiza", false, null, "Dorothy27", "AQAAAAEAACcQAAAAEBiiIzt6NXZ5Ig2YUP6Cj8DYNYwB3yAeAfBLz1mBcVNgORuDv23ybsaRLdQbERSm2g==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e"), 0, null, 828.7160805810540000m, "f4d8829d-218d-47a0-bfc0-9e037b834c0d", null, "Lee", null, "Bergstrom", false, null, "Lee.Bergstrom14", "AQAAAAEAACcQAAAAEDoL0UNCq2N3dlQhxg6A2tChSbg982xuPveqGv5B7sH59pq4/3sJoH7AFzGRCF4Fbg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141"), 0, new DateTime(1969, 3, 4, 3, 29, 33, 979, DateTimeKind.Local).AddTicks(9201), 812.6608213147520000m, "4c4c53cd-5105-42b2-8f0e-ac6e3e2a4a51", "Andrea", "Andrea", null, "Jacobs", false, null, "Andrea.Jacobs68", "AQAAAAEAACcQAAAAEC8ohZ2eCpAYqnrPaxpsoViFL/clMBScxC07mbZnAmrrEEZvW8LK+KlTvleapvsy6w==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399"), 0, null, 712.3258089155640000m, "9ab9ff8c-81b6-4a9d-a3b6-77ae755e4b41", null, "Peter", null, "Bogan", false, null, "Peter_Bogan", "AQAAAAEAACcQAAAAEBekpsqfnwhLWdTdLOgUv6R21rMMOmEAijS33vEeqvzM6y+wS6fE79YU/gWYv9oQhA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2"), 0, new DateTime(1928, 1, 3, 19, 48, 28, 514, DateTimeKind.Local).AddTicks(4075), 483.689965493590000m, "9c8f9048-a99c-4024-a6d5-14e0c5acab25", "Alonzo", "Alonzo", null, "Collins", false, null, "Alonzo_Collins92", "AQAAAAEAACcQAAAAEEHq00wb4tlrT1SV5zxYmbgssaWBQffKHqwKQtk2Q88R3l+563mgQdw6Eptx4ExyKg==", null, "NotSelected", false },
                    { new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5"), 0, new DateTime(1962, 1, 3, 11, 16, 59, 644, DateTimeKind.Local).AddTicks(9933), 589.1914314605570000m, "bad7bf15-64b0-415a-86c8-34f50a310c22", "Willie", "Willie", null, "Hudson", false, null, "Willie8", "AQAAAAEAACcQAAAAEA7hLnaDtwMfF9E1Cn5Div/XNTVHzL0vePlAABSkFRWDucK/wWRnz0KNkmCB5u8S4w==", null, "NotSelected", false },
                    { new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7"), 0, new DateTime(1944, 10, 18, 21, 7, 13, 989, DateTimeKind.Local).AddTicks(133), 330.5299306451430000m, "3c6a2b98-d56d-447b-ac10-2876006055ef", "Randy", "Randy", null, "Gleason", false, null, "Randy78", "AQAAAAEAACcQAAAAEOpodvl7exsynxY8uPFEWfJeWrqAm/jfFp4byFZbpo0z7oCYuCzHVdvLATTgLXuIng==", null, "NotSelected", false },
                    { new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2"), 0, null, 844.7725890818860000m, "fcf84cd4-ab8b-4d48-8b6f-2a61381a93aa", "Amos", "Amos", null, "Roberts", false, null, "Amos.Roberts83", "AQAAAAEAACcQAAAAEF2p0Cxv5sJlZrtKwny5fn7IXxTimmfQlYREKnOp6Fqsi31EZPUW8TPwvdqUtDmYJg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724"), 0, null, 113.7484235958180000m, "b76627ad-921d-4765-ae82-e372d9ed3e52", null, "Phil", null, "Nader", false, null, "Phil.Nader", "AQAAAAEAACcQAAAAEIXf2BWmpdhAqOl/TM3DcCIis4TKonh4V+NGuT8oG9V6PFxqNU6faa1iF29Phcg+KQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c8507284-511b-425f-9aab-13ef42992af5"), 0, null, 604.3894403343890000m, "2f8ea5fc-6a88-4c85-9baf-3246fc4dc327", null, "Shawna", null, "Daniel", false, null, "Shawna_Daniel", "AQAAAAEAACcQAAAAEI6SQNzRx/AsHD98zIYLhapffig3k33xHDOy9mV7vC/1mQkOvTzFQaaDo5n7YRPjaw==", null, "Female", false },
                    { new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a"), 0, null, 824.2967200180390000m, "7af77ede-fba7-40d7-8f9a-0643de6adc83", "Alexandra", "Alexandra", null, "Ondricka", false, null, "Alexandra_Ondricka95", "AQAAAAEAACcQAAAAEBqKaa2cfPNLNiBRvsQbt6FAOjK5fG0WJsMbxIhZCTjeUOH6NoMY2Y+G7YErftqjSQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d"), 0, null, 895.1783822948810000m, "19ec9fbf-38d1-45b5-973f-49066698488a", null, "Helen", null, "D'Amore", false, null, "Helen_DAmore14", "AQAAAAEAACcQAAAAEBAraDqwTQMoxTj4T40FkWGtzrXRtarfMSECWLceoO/jZyYLlNMelsDv3Ffw5dJK3A==", null, false },
                    { new Guid("ceb699bd-8c01-4831-9438-e8c30f353919"), 0, null, 926.4866669739910000m, "7a10e693-b096-4e68-b0e0-7a0b0cea5905", "Lisa", "Lisa", null, "Nader", false, null, "Lisa.Nader", "AQAAAAEAACcQAAAAEAG1b/ZgFVEg9fBFFFHFLZkjhmVdHf5b/o/cvE9Fyz/n01ocOicOfCmDbwfjQA82eQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867"), 0, null, 547.7055644102650000m, "18854448-2ce8-4001-8327-a087a0b58d0c", null, "Georgia", null, "Mraz", false, null, "Georgia17", "AQAAAAEAACcQAAAAEDYuLAgh+ITgSkWDUV61wkUsP3e5yxAmrRhtK6JQ8z9fJN4PsE0IzbWvcO4HrFdV+w==", null, "Female", false },
                    { new Guid("cf715f5b-d690-415d-b228-62054ae77a1f"), 0, new DateTime(1927, 3, 19, 16, 58, 7, 135, DateTimeKind.Local).AddTicks(3499), 750.98286837920000m, "0925405c-f3c6-4f97-b8b6-63bd2015c52e", null, "Lamar", null, "Skiles", false, null, "Lamar_Skiles66", "AQAAAAEAACcQAAAAEB+JyU3Pxn1VK4UsBuZbg+o1osKMHyxVuetucmJXpJmtVUNcDPnagX65vupKTUXesQ==", null, "Female", false },
                    { new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee"), 0, null, 411.0276114330680000m, "f46505fb-ac89-489f-8a23-2c6b49cccc8f", null, "Leticia", null, "Corkery", false, null, "Leticia98", "AQAAAAEAACcQAAAAENL7gkxg0DFqVBDXORzu2lVuzXF66BssvZTn6ImjSK9mNJ5mwZADnnfYkuEjqeQY8g==", null, "Female", false },
                    { new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc"), 0, null, 849.8503469678420000m, "61b37aa4-2456-4e60-bc9b-fe726da85741", null, "Lena", null, "Parisian", false, null, "Lena_Parisian", "AQAAAAEAACcQAAAAEGPM2IvlpZK3BUZ5aW6QRjUbNXk8czq6HIpJEyarGj6GiG9ZoHFOAlkKKigddLOYAQ==", null, "Female", false },
                    { new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9"), 0, new DateTime(1982, 9, 23, 21, 55, 35, 264, DateTimeKind.Local).AddTicks(181), 629.9821730185060000m, "28e0a621-35d2-468e-a3f8-a1d91875752d", "Elizabeth", "Elizabeth", null, "Bechtelar", false, null, "Elizabeth_Bechtelar", "AQAAAAEAACcQAAAAEOdFi+PDnwONDE3LkyWtcaJyZu2pzG2XIbDhGp+fXYtkHnW4ncOl33vMA1B1v5Q1WQ==", null, "Female", false },
                    { new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e"), 0, null, 682.0525850611670000m, "538c22b9-5e24-4542-841b-da517c9ffb80", null, "Henry", null, "Roob", false, null, "Henry_Roob", "AQAAAAEAACcQAAAAEGIEd1rVwrr2Hq573aREXQdzotBe5pLY96BJ2tayD/ed00GNuUOLQHRcbda6mSH0hA==", null, "Female", false },
                    { new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091"), 0, null, 93.5140325495170000m, "be6b3c4e-b832-4a8e-9dd3-76effd799419", "Angelica", "Angelica", null, "Johnson", false, null, "Angelica.Johnson46", "AQAAAAEAACcQAAAAEBqUNOZ8vrJcGW4SdapEXGG1uhP9Ewp7UNqeuBrj4jKYwxHbGB8GjjB2hYs0w5ggiw==", null, "Female", false },
                    { new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0"), 0, new DateTime(1946, 11, 12, 1, 5, 38, 897, DateTimeKind.Local).AddTicks(4699), 215.7836772869310000m, "d638456c-4f88-47a8-81f8-2a3e5ceda1d4", "Dana", "Dana", null, "Bergnaum", false, null, "Dana1", "AQAAAAEAACcQAAAAEIap0NKA5+kj+EdTQM+6wnA5EtPk+ilx1i5Y/6izjPCuvgeTSOXlEbCz2W1/t6ushg==", null, "NotSelected", false },
                    { new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec"), 0, null, 631.4895757598680000m, "2c268daa-5276-4001-ad07-08fdcef2499d", null, "Veronica", null, "Dare", false, null, "Veronica_Dare", "AQAAAAEAACcQAAAAEIBuOATih5vB7tXglCj4UYYgHw1liBL5YUp33R+janU6VsvRORBhM9JT0G9uVrQyDg==", null, "NotSelected", false },
                    { new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3"), 0, new DateTime(1988, 7, 1, 9, 9, 36, 420, DateTimeKind.Local).AddTicks(3454), 87.67709618697330000m, "a1c325f4-3099-4dd8-8bbb-44e14923f0f9", "Fred", "Fred", null, "Koepp", false, null, "Fred75", "AQAAAAEAACcQAAAAEM/oN9QJgGwmfLnAGcFIIo1SgLc/qdNOFfoBIBj3tv2sZWQFxRvwle957bBhPN3wOQ==", null, "Female", false },
                    { new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b"), 0, new DateTime(1961, 12, 13, 18, 46, 30, 832, DateTimeKind.Local).AddTicks(5383), 162.9063257571640000m, "c4bad266-1287-4d49-90d9-723974d4ef90", "Jennie", "Jennie", null, "Batz", false, null, "Jennie.Batz31", "AQAAAAEAACcQAAAAEMCJxa6f4bzFgxxItXna6V3RsvoN1XXZGEPpoUVyKBYzbQqHIY8mn5B27p1gl9h59g==", null, "NotSelected", false },
                    { new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae"), 0, new DateTime(2008, 10, 5, 4, 39, 47, 47, DateTimeKind.Local).AddTicks(4260), 619.9644774733240000m, "5002d732-ad25-488e-b93c-1b2b4ba484bb", "Wallace", "Wallace", null, "Fadel", false, null, "Wallace_Fadel71", "AQAAAAEAACcQAAAAENiNMPBQBaGJMs4QBsy8/FJhV2mQB7EuHfraGBw4BemJQmbrvNg0L0xiigtm1eSBNw==", null, "NotSelected", false },
                    { new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694"), 0, null, 523.0431245887840000m, "26b1bfc9-7563-4a9c-87e1-f83fc31fc2d7", null, "Marilyn", null, "Schmeler", false, null, "Marilyn42", "AQAAAAEAACcQAAAAELEw0TZhP+6StGF0ac+HNHJTir4DyGa7/N9KyFpkt4wqas1a8ypJFittoGX/kDPm6A==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d"), 0, null, 423.2925465934720000m, "13af8137-8b83-4ff6-b770-074703e02f90", "George", "George", null, "Turcotte", false, null, "George.Turcotte", "AQAAAAEAACcQAAAAENYKM/zuX/LIH8qlTuXTVX5XDEDNMsA0EUgPV2uz4q/BRfFS4XB0brZ+EriV/LaVew==", null, false },
                    { new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97"), 0, null, 687.0124573180030000m, "9dd0cc63-edee-4a34-8f6e-a4202b8e1923", "Neil", "Neil", null, "Christiansen", false, null, "Neil_Christiansen", "AQAAAAEAACcQAAAAEBh3kcG4g25sCI9jOdgQGzdLXjwONk+jqLCWeLVlkhTPeuBAt+aJmsHXqhysgur9JQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c"), 0, new DateTime(1996, 6, 29, 9, 30, 43, 620, DateTimeKind.Local).AddTicks(6549), 663.7463236840420000m, "d7fbf01d-ed86-4003-9a1d-fd3ef80598ed", "Enrique", "Enrique", null, "Kunze", false, null, "Enrique.Kunze", "AQAAAAEAACcQAAAAEFcnKN1Vg4OAEv7e6l6qHI4HnwJ6GtJ7oEjXKsrOTB2NhA25rAGiILZIrqVnJjJSfg==", null, "Female", false },
                    { new Guid("e046fca1-590d-4528-9a08-8baa91140ac9"), 0, null, 469.2519259998120000m, "72cbbeae-f14f-4ac3-a714-67cdc359e966", "Gilberto", "Gilberto", null, "Pfannerstill", false, null, "Gilberto_Pfannerstill65", "AQAAAAEAACcQAAAAEJJ3KcKqqccaeXzuHOeconoddDhfTf3z7bkok45cZda/kpt1BydOKJ+dVKwYIuh/8g==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6"), 0, new DateTime(1986, 8, 21, 1, 36, 48, 670, DateTimeKind.Local).AddTicks(1298), 285.3609365405130000m, "aa80538c-363c-4970-8e77-509ed94aeff8", "Mae", "Mae", null, "Ledner", false, null, "Mae.Ledner69", "AQAAAAEAACcQAAAAECBSgPE3H34fdy0A+aOg7v3MFuDmE9YrHPZ4ZYdXwbjKKFgsrWEaMA/CkIEMlx9NKw==", null, false },
                    { new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2"), 0, new DateTime(1997, 2, 19, 14, 3, 16, 592, DateTimeKind.Local).AddTicks(4324), 36.34485035169450000m, "5319a609-633a-4655-b3de-556ddadc2397", null, "Sophie", null, "Schaden", false, null, "Sophie_Schaden", "AQAAAAEAACcQAAAAEMm/UFysfDlzqAIBRMFptHv/mv0r8SBSCfvobb9DS2jRAaVoD8OKfytAU9rusHmsQw==", null, false },
                    { new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042"), 0, null, 890.0175232441910000m, "41dbc1b2-5251-4b4b-984b-7f021ed014c1", null, "Joanne", null, "Homenick", false, null, "Joanne44", "AQAAAAEAACcQAAAAEApO5LO6DDmbHXJJydSCSVvyltBOYzGy37KkbEauAF40MxUoRgc6yKNkYhuooKp4nA==", null, false },
                    { new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c"), 0, null, 475.2281041143330000m, "595c2d66-eb21-440f-8e0c-c7a5b6745ae3", "Bert", "Bert", null, "Armstrong", false, null, "Bert_Armstrong", "AQAAAAEAACcQAAAAEEipgKsUEkjPjEfpPsn40VuS12LraCp2clB8cxrx3hu7fHXzxw83zrDgztW+GfMzBw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e50b5106-c89a-489a-b970-99024a53f892"), 0, null, 727.8104016946040000m, "bfd760b6-2e70-44a6-9f1f-633a17425452", null, "Bessie", null, "McClure", false, null, "Bessie.McClure", "AQAAAAEAACcQAAAAELTZnFoFlPeTOYI4XY1MmKNtjduBjGLEolVgItMFLA5sRbsU9n49sXur6pj/jA0mxQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8"), 0, new DateTime(1979, 5, 9, 13, 45, 33, 28, DateTimeKind.Local).AddTicks(7583), 733.9385956123040000m, "985c86fc-2db4-4729-a0a7-73e6c5cec79c", "Roger", "Roger", null, "Smitham", false, null, "Roger85", "AQAAAAEAACcQAAAAENpH8zZpTC+9dvwPFC+OwhciPGBekh3xOxlvg8248WBcnb9sdZFTijk9XaG7pIOObA==", null, false },
                    { new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3"), 0, new DateTime(1950, 11, 28, 9, 50, 37, 314, DateTimeKind.Local).AddTicks(5575), 771.6619337632720000m, "56e23f39-e633-4c21-8e03-ee09ad7d0325", null, "Benny", null, "Kertzmann", false, null, "Benny_Kertzmann", "AQAAAAEAACcQAAAAEILVnhdNSXA7h7c6ORARZhi0RHV8WKckr9qZjLa7VDzRRAixx4fXyCfMqnCZiPIi6w==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e87e502a-19b0-4f23-969d-aabf313d6591"), 0, new DateTime(1944, 7, 5, 0, 9, 29, 83, DateTimeKind.Local).AddTicks(7757), 849.8409054797220000m, "2c9ee4c2-7ba5-42e0-8d9d-9592897e3cca", "Michael", "Michael", null, "Pacocha", false, null, "Michael.Pacocha42", "AQAAAAEAACcQAAAAEGdJbRuNaB16P0TuDhPBQPZmylLCNL+2g0zlCxYDTaNaEy/ec0B+pFNe3eSUDk7aqw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e908834c-4383-4b44-a138-de5de4aa621a"), 0, null, 145.5609933249460000m, "3dbd0fa4-4161-4ff9-8bca-df2f2b075556", null, "Russell", null, "White", false, null, "Russell_White61", "AQAAAAEAACcQAAAAEFwYwM0zAFLY7S8rI1sZwkDAv5pq3XPy7YVJZztN26//3MnNcbXLdL4/eGx/PnbBqw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3"), 0, null, 480.0187946122760000m, "1398128f-0912-4a51-8e37-06fea95364d0", null, "Jan", null, "Bartoletti", false, null, "Jan_Bartoletti56", "AQAAAAEAACcQAAAAEHDlSdXuE1uQdCdZQk5zbh1twEX5bMWwribtsuN+ORn42GTFdEXsoD0yIY0RetKXHw==", null, false },
                    { new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000"), 0, new DateTime(1981, 2, 21, 13, 0, 14, 615, DateTimeKind.Local).AddTicks(7020), 596.1519837273160000m, "229eecc6-6ab2-4ee3-8e15-169880f3c9fb", "Olga", "Olga", null, "Mayert", false, null, "Olga.Mayert", "AQAAAAEAACcQAAAAEFccMITh75FUZBskfBZvirFaX/UaKS+RGtuJpXXUh8xglU1sQHN6L5a0BN/5r3p9SQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a"), 0, new DateTime(1924, 8, 18, 5, 40, 38, 18, DateTimeKind.Local).AddTicks(5370), 427.2320449796730000m, "9d6dd32c-0f9b-4c28-9089-9559bfee91ec", "Yvonne", "Yvonne", null, "Rau", false, null, "Yvonne_Rau", "AQAAAAEAACcQAAAAEM0FYArBXms3RiojvchcrFflkwoKgfFhsHSaSl7XFLymZ8Wee3i2BgubwgO8t2dPww==", null, "Female", false },
                    { new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f"), 0, null, 900.1284118935430000m, "c15067e8-ffda-40ed-9696-2cc124e78769", "Shelly", "Shelly", null, "DuBuque", false, null, "Shelly19", "AQAAAAEAACcQAAAAEFUqXqqEvrkingXAPzzOs3/R6IYCV+3jxJsUBsiOUVK1a4edK3igI2yDj/Wr06bPzQ==", null, "Female", false },
                    { new Guid("eea73942-2019-41c4-9063-ab64deb92300"), 0, new DateTime(1945, 3, 28, 13, 45, 56, 683, DateTimeKind.Local).AddTicks(8081), 954.1688055817750000m, "1a059ab1-b7fb-4e50-975f-8dd062b49612", null, "Arturo", null, "Weber", false, null, "Arturo88", "AQAAAAEAACcQAAAAEJJ12Q802uXAAGzkRs2CxXiRd9Ng+SWxd9QCw3+onIr4e/URgCKdiBLkuCn7nefWZA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4"), 0, null, 993.4817528943520000m, "93213ebe-0487-4928-9a56-4436da4de06d", "Sally", "Sally", null, "Botsford", false, null, "Sally94", "AQAAAAEAACcQAAAAEKHZEf9Iz+euy/JLRKXTBmPKQ1UL6sUa7sUvIDxN6CUL5wWFHmrdQfMUCIiuqUsCDw==", null, false },
                    { new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357"), 0, null, 448.661263713290000m, "3ca6dfba-7c95-45c3-bc6c-95c4946a3aff", "Clifford", "Clifford", null, "Legros", false, null, "Clifford.Legros0", "AQAAAAEAACcQAAAAEDfc4/zyvEbBegmEY3qUWa3YfGTxGHpb/y5hSKtgcqQR8bpEptzes/jbX/hwTEd8EA==", null, false },
                    { new Guid("f06e4de8-bda0-47a2-811b-385e6e623687"), 0, null, 930.3310133434120000m, "fc6f6d5e-625b-4dd9-8666-162189546fa4", null, "Joel", null, "Schaefer", false, null, "Joel.Schaefer34", "AQAAAAEAACcQAAAAEGhD03Zgg2fCalH1jrqZzysQffwkxWb+AuBDlCqqOTN55X6Rpkp4/TK7kCA5kKNI0g==", null, false },
                    { new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722"), 0, null, 915.003551548170000m, "9004d602-8387-4c7f-82f6-5bef478ec4d5", null, "Laverne", null, "Carroll", false, null, "Laverne_Carroll84", "AQAAAAEAACcQAAAAEPSzXb1/1LumdnEMozpIzYsJM29kdjq3XT6GKLmOtRK5ndf9ccGZt5BNhuvz7T9qFg==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f2542110-27bc-4868-b96c-53e10a66800f"), 0, new DateTime(1979, 11, 8, 10, 0, 55, 71, DateTimeKind.Local).AddTicks(8501), 234.0883467452460000m, "828485cb-eef8-435f-bdcd-7989649879e9", "Rose", "Rose", null, "Gerhold", false, null, "Rose_Gerhold36", "AQAAAAEAACcQAAAAEPs7b8P3p/jylqNOjxixG9dacl/7lVESsksyLKrfY/hcu1YLYCuqBHzOFMExg4cjfA==", null, "Female", false },
                    { new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe"), 0, null, 756.2378007962570000m, "7c76fd61-8dcc-4974-a632-9c35996592c4", null, "Oliver", null, "Douglas", false, null, "Oliver.Douglas", "AQAAAAEAACcQAAAAECetqP4L7k/FsijaRG5HO+JYsV5vxNhZmpFzC2K9L2ux6QdqGeUrEFQRm1Grwfy38g==", null, "Female", false },
                    { new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e"), 0, new DateTime(1937, 9, 28, 18, 56, 42, 551, DateTimeKind.Local).AddTicks(5738), 143.4193632112120000m, "11248f01-e65c-40c4-befa-a5c9189cca5d", "Dixie", "Dixie", null, "Gerhold", false, null, "Dixie.Gerhold", "AQAAAAEAACcQAAAAENXfjAdPVzzLoRs8K9tfnbzhBcPVdkL6oheQB90+YMSmkK9xN3wduPnVDpuAnQRgMw==", null, "Female", false },
                    { new Guid("f443c798-1151-4757-94ca-517bef15e381"), 0, null, 928.3862640210230000m, "d6f3f917-e4c4-480d-a6ba-06d8ddd8da45", null, "Cary", null, "Crist", false, null, "Cary11", "AQAAAAEAACcQAAAAEPY+ryhXsBi1JoqJa1163i93B6ITYWVPs6RApGt8fkiEF5T9UjC4v/DO0FVC2sP/+A==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4"), 0, new DateTime(1957, 8, 14, 2, 33, 8, 155, DateTimeKind.Local).AddTicks(6100), 63.24347091304670000m, "04f300e7-5329-4094-8803-2089e3f73caa", null, "Celia", null, "Shields", false, null, "Celia75", "AQAAAAEAACcQAAAAEKawmTb9BbYaXhbbTe44tGEEvljRd64sL3w4NdSYey4yx5j86oa+PYujj/zeNxOKEw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f485798d-1525-429a-8e8b-8604e1673c1b"), 0, new DateTime(1927, 9, 1, 2, 57, 25, 444, DateTimeKind.Local).AddTicks(2191), 296.3688854684220000m, "ddfa55d7-aa55-4644-a216-d61508f2bd1c", null, "Fredrick", null, "Kirlin", false, null, "Fredrick_Kirlin51", "AQAAAAEAACcQAAAAEHQYMVt6ca2axuaqgfXtXw1ySqyG03rJ+z+iyYjJeZxoEsbXPZkXkV01sPLJ+xkR8w==", null, "Female", false },
                    { new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549"), 0, new DateTime(1944, 11, 18, 4, 33, 5, 594, DateTimeKind.Local).AddTicks(2881), 46.35801921462140000m, "c6d617f8-515f-47f2-994a-f5e88b7d9a32", null, "Micheal", null, "Purdy", false, null, "Micheal_Purdy", "AQAAAAEAACcQAAAAEMb8XJnzwHDJLSdpgd+ASOKEaPYQJJ4waiegHBvIxhhfqCqcB+50Ura/EWy0DemHWg==", null, "Female", false },
                    { new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce"), 0, new DateTime(1977, 9, 17, 5, 24, 57, 498, DateTimeKind.Local).AddTicks(5633), 93.57239974758580000m, "f938e7e6-122e-445d-b961-d1c07f4609c9", "Holly", "Holly", null, "Schmeler", false, null, "Holly.Schmeler30", "AQAAAAEAACcQAAAAEC+TWrUyAk/+8ahKVk0z47kwTxJVvjQ7buwTt1Hrn09Gz3F2xP59fHI6DZFOk+kjIQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86"), 0, new DateTime(1966, 5, 8, 18, 57, 8, 851, DateTimeKind.Local).AddTicks(4560), 492.5562114445780000m, "253aa90c-cbd0-4d7a-bc04-bc47479d5a08", "Irvin", "Irvin", null, "Friesen", false, null, "Irvin_Friesen", "AQAAAAEAACcQAAAAEE89C1U1qJ1llNQv5Sqmqi/DhYdWxxuKB8/9o6FrFHv+8N07cEQqHx66bn4U/wjIHg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f819889a-570b-4521-a36f-42d900233678"), 0, null, 698.4956650781010000m, "d437615c-3856-42d2-b588-8fbfe57a3605", "Dana", "Dana", null, "Bednar", false, null, "Dana_Bednar81", "AQAAAAEAACcQAAAAEEcp2KsO21AR9HJJCTwaj0dzjhmw9lAfpxNwuBdGy1lc63PBzvwKVScLQpfknM/ucg==", null, "Female", false },
                    { new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d"), 0, new DateTime(1926, 10, 4, 4, 10, 42, 331, DateTimeKind.Local).AddTicks(3242), 498.8083953440920000m, "3e6adfb2-6c9d-4a3b-921b-82cf3f4a74e3", "Leo", "Leo", null, "Wehner", false, null, "Leo30", "AQAAAAEAACcQAAAAEBI09f9QjpSZ+dJaJJ/cSCOFvLPw7SkXXiktEohGrq5D345dgYiU8PXnu11qjziXKA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a"), 0, new DateTime(1978, 10, 22, 15, 39, 51, 160, DateTimeKind.Local).AddTicks(1346), 113.530019904490000m, "cdc490b1-6fe7-49f2-8266-64009025f7e8", null, "Patti", null, "Conroy", false, null, "Patti55", "AQAAAAEAACcQAAAAEAJXZKUqqlLcy7CRsz0sbtj4VSxAMpFy34GvoIwmC9ZORzCQjQx+YyKXGclTHfGscQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b"), 0, null, 800.793293410640000m, "d1a6d5a2-1572-42b1-93b0-63a1a18caf7e", null, "Ted", null, "Predovic", false, null, "Ted.Predovic", "AQAAAAEAACcQAAAAEP76yrxdcSjAqxyTktC3Z0viogP2NbOVpZbP8eZ/iDEg37Df4edL6R28Kkc9cjP87A==", null, "NotSelected", false },
                    { new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213"), 0, null, 466.5547741709460000m, "c2432af6-eb91-4cdc-b8d0-ec18425e2407", "Shaun", "Shaun", null, "Bahringer", false, null, "Shaun10", "AQAAAAEAACcQAAAAEDVwdNDtgEDJQW2i242zshA6uhZHLCS2MOYvnC7smwK3T6qTJmOhiqszKTbsQkg59A==", null, "Female", false },
                    { new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337"), 0, null, 585.5837096234880000m, "250f77b5-c631-4378-bd27-0e6906772f71", null, "Alton", null, "O'Conner", false, null, "Alton.OConner58", "AQAAAAEAACcQAAAAEAnkyTLqbLASmOCfGL8CRDv4O47bHf/y7xhv7iDWzSKM6VeyPvhaw1QnzWKzaNWDYw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fca3cb7d-c11d-445d-8752-00136c100d96"), 0, null, 230.7605484796290000m, "4b630f64-1ed5-4b81-9c67-136b10786b6a", null, "Virgil", null, "Cummings", false, null, "Virgil_Cummings83", "AQAAAAEAACcQAAAAEDxmGEMJkw2oC8x5GzOr1MWxVjXMxkvvW9tfBlSaKJdmn74kc/s7IHz5tF7omL2J4Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea"), 0, null, 355.2989309024840000m, "f5f0c503-b849-4170-9625-8f79e9372855", "Celia", "Celia", null, "Rippin", false, null, "Celia_Rippin", "AQAAAAEAACcQAAAAEKKH89DOCNMoPL7AJ+tUL3QkPkEDKg6RgsDjJ3v4ni4kJj0EvounwXH+064GFbi3BQ==", null, "Female", false },
                    { new Guid("fe394c33-39cb-4280-b774-a82eab155fa5"), 0, new DateTime(1955, 5, 15, 0, 46, 34, 742, DateTimeKind.Local).AddTicks(962), 556.6130929757090000m, "a4bbae34-583b-4842-898e-494a68729f89", "Genevieve", "Genevieve", null, "Frami", false, null, "Genevieve_Frami", "AQAAAAEAACcQAAAAEMA+sF15GHfBst3YDLze5Xnnci/naVT1oF8mGy6YbkdAq4XSJJQNSWkEHTlvkxl2cg==", null, "NotSelected", false },
                    { new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5"), 0, new DateTime(1982, 9, 21, 18, 25, 29, 631, DateTimeKind.Local).AddTicks(5873), 480.345451523010000m, "8240f02b-b55a-4403-9da0-9feacf6e10f1", "Orlando", "Orlando", null, "Schamberger", false, null, "Orlando_Schamberger", "AQAAAAEAACcQAAAAENxybohpeMikVFeOEhaNDCewL+dN9meN2RpSvB0b9iSesKZSN5hFvsO7e3AIaJW65A==", null, "NotSelected", false },
                    { new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8"), 0, new DateTime(1957, 10, 31, 9, 18, 30, 324, DateTimeKind.Local).AddTicks(2128), 198.3529251723820000m, "577a344a-a442-4f25-869c-209119a96935", "Doug", "Doug", null, "Dooley", false, null, "Doug_Dooley", "AQAAAAEAACcQAAAAEGr6H9n9YtMvhZHbRhMNlL/Zv8nAfYVQj+KRvMNccSXSgTKiJMZQm3ySdAfQIrYxxA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807"), 0, null, 206.6192082026440000m, "5b9be25a-2d6a-4b71-be06-f193e5e42893", null, "Arturo", null, "Keeling", false, null, "Arturo.Keeling", "AQAAAAEAACcQAAAAEDU0X5DN76gIoIWpnAelF1ABMdU1yfVdkZTzMoSzGOi4+UwHqvkWKwbcS9C6Zug+WQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "ImageDirectory", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5"), 0, new DateTime(1980, 12, 22, 13, 59, 15, 195, DateTimeKind.Local).AddTicks(849), 507.4173751365850000m, "0cf2d829-c4f8-4307-9148-5a3aedeb6b2a", null, "Lynette", null, "Greenholt", false, null, "Lynette98", "AQAAAAEAACcQAAAAEFm62AM8YxUEhoZkmZp3TWn73pmlMFaS2JLBB1dBFTcSRPsfiVwgBQ6B1Vn8f0IcKg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("00ed3819-4da8-475b-a78e-5c8d4f232aee"), "50,187725;24,972296", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Candelario, Equatorial Guinea", "Bradtke Prairie, 1822", 123 },
                    { new Guid("01763114-3ab5-46eb-ab75-b44b869e0f78"), "50,299774;29,766726", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kochhaven, Italy", "Lora Bridge, 57336", 102 },
                    { new Guid("04b7a460-57e3-4582-871b-adbd5be22e2f"), "50,328106;27,387379", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Elsaton, Bouvet Island (Bouvetoya)", "Colleen Brooks, 29387", 41 },
                    { new Guid("0523c28f-3747-4730-9cce-c08cb591d174"), "48,11327;26,768343", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hamillport, Bouvet Island (Bouvetoya)", "Tyree Inlet, 902", 187 },
                    { new Guid("066569c6-7b94-4971-bcc0-575e73552772"), "48,938305;25,1998", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hagenesborough, Malawi", "Wintheiser Mill, 95378", 179 },
                    { new Guid("0673fffa-bc3c-4c6d-a523-efcbcb79f93f"), "50,86107;30,017954", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Arnulfoton, Wallis and Futuna", "Rosemary Isle, 6662", 59 },
                    { new Guid("0cc36fe7-5548-4d86-8ee6-d78ac7b518c3"), "50,612038;24,94859", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Marcelstad, Tanzania", "Dessie Brook, 1489", 150 },
                    { new Guid("0e8f9bc5-c58f-4214-9b1f-c9951796c7f8"), "48,480907;27,318916", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Cleo, South Georgia and the South Sandwich Islands", "Samara Well, 8371", 96 },
                    { new Guid("0ea451ca-b7d1-4d35-ae94-e829d79920e9"), "49,165733;27,186495", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hillsburgh, Vanuatu", "Green Rapids, 49881", 101 },
                    { new Guid("0fb78bae-1f19-4b47-bcec-be71de61beff"), "50,18381;25,696932", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Clay, Andorra", "Abdiel Plains, 39733", 18 },
                    { new Guid("104b0e26-7f1e-4bf1-a8f1-fd8dd91d7a8c"), "49,571922;26,827402", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hudsonfurt, Norfolk Island", "Medhurst Burgs, 455", 159 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("113a3f64-4c88-4e11-a76b-67e849847091"), "49,156475;27,648508", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Elbertside, Sri Lanka", "Berge Plain, 157", 19 },
                    { new Guid("1627ef01-60c3-4478-a5ce-3b239099a72f"), "48,288445;23,834093", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Hubert, San Marino", "Adell Roads, 692", 181 },
                    { new Guid("17d8ab2e-a957-457e-82f8-2bc286257ba3"), "48,011616;27,766897", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Mozell, Nicaragua", "Lexus Crescent, 41563", 100 },
                    { new Guid("1a2bcbe2-8c9b-469d-b026-38218c9e10f3"), "50,953983;25,940783", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Millsstad, Cape Verde", "Heller Skyway, 522", 60 },
                    { new Guid("22b75005-6c01-4920-81c6-8d6d5271c6df"), "49,954185;27,683231", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hahnfort, Greenland", "Turcotte Cliff, 304", 99 },
                    { new Guid("27ab7dbd-176d-4bbb-b9c6-93b91b79276e"), "48,617653;26,696093", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Sierra, Bhutan", "Stamm Vista, 455", 50 },
                    { new Guid("2cb11778-c61e-44eb-bb23-ba4ae9d3b433"), "48,04642;28,046534", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tiashire, Peru", "Wyatt Fields, 71135", 52 },
                    { new Guid("2cc495b9-a04b-4e29-b5f0-24b2cddb7ea3"), "50,92724;24,17851", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Kileymouth, Solomon Islands", "Edgar Spring, 08006", 24 },
                    { new Guid("2cf9aac2-0321-4ba6-98f0-5bbab55c3afe"), "49,808853;23,704437", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jaedenhaven, Pitcairn Islands", "Champlin Parks, 92026", 97 },
                    { new Guid("2ed8484b-4374-4a8e-bc41-ba7c0da6ae14"), "50,471813;30,606144", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schummfort, Mongolia", "Sporer Walk, 42322", 74 },
                    { new Guid("30602a29-2f90-4d1b-b5ad-e2ab163915d3"), "50,455914;29,237902", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Rubie, Bulgaria", "Collier Hill, 0876", 141 },
                    { new Guid("30e9c07c-afbd-4049-97e8-038b6aa8ce5b"), "49,151413;24,288961", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harveyport, Saint Lucia", "Feil Stravenue, 1125", 140 },
                    { new Guid("321dfac2-769e-45ad-87ab-474fe56a5363"), "49,052017;23,417152", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Howardside, Bouvet Island (Bouvetoya)", "Mayert Pines, 4047", 197 },
                    { new Guid("350529d9-ff47-4f4e-ba62-af222f2f2ea1"), "50,75989;27,365187", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Al, Turkey", "Ayden Haven, 84996", 133 },
                    { new Guid("36ec0cff-464b-48cc-bf94-0e120fb8e342"), "48,00923;25,767376", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Braeden, Cayman Islands", "Amparo Islands, 8546", 130 },
                    { new Guid("37b0d5cb-1f14-49b8-b364-fffa956ef141"), "48,829346;24,29373", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Elisaview, Heard Island and McDonald Islands", "Howell Harbor, 6837", 116 },
                    { new Guid("408b6e66-b58c-461c-aef4-05fa835243b2"), "50,373432;28,735285", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ullrichmouth, Argentina", "Shaina Court, 277", 160 },
                    { new Guid("41b7e3ef-b8d8-4c0c-a024-8280f6d7bcc8"), "50,709164;23,007042", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Elliottmouth, Nicaragua", "Will Cape, 8072", 178 },
                    { new Guid("438edd88-524e-4e66-afba-58238d954f23"), "49,41588;24,469233", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hyattburgh, Iraq", "Hirthe Rue, 37756", 31 },
                    { new Guid("4b68db94-1b80-46c4-929f-942ccc433dec"), "49,253727;27,224747", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lavinamouth, Cyprus", "Crona Branch, 12070", 140 },
                    { new Guid("4be6c3cf-049e-4617-95ea-61dc8061cb44"), "49,732925;24,008703", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Heatherbury, Mauritius", "Wilkinson Ramp, 49456", 87 },
                    { new Guid("4cdcba94-23b7-4b02-ad35-4a0b24ef841d"), "50,002537;28,454248", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bergeburgh, Burkina Faso", "Chester Mills, 97928", 39 },
                    { new Guid("4d65b573-d092-4de4-9123-77be770a4b91"), "50,794678;29,863909", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sipesmouth, Reunion", "Virgil Passage, 146", 27 },
                    { new Guid("5cd8f8a2-7eac-4fbc-8851-a8271d94315d"), "48,587543;30,119967", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Marisol, Malaysia", "Bradtke Streets, 462", 46 },
                    { new Guid("5d5cb8f0-bdaa-4b24-a39b-59c9bc87fec3"), "50,22857;23,754335", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Aryanna, Suriname", "Leslie Port, 829", 53 },
                    { new Guid("5e2a99bc-320f-44ba-85a4-cf16407391ca"), "50,912827;30,157814", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Athena, Tuvalu", "Magnolia Run, 84312", 192 },
                    { new Guid("653f061e-abe4-423c-b54e-2bbbc42a12a4"), "49,61418;23,54782", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Claudiaton, Latvia", "Medhurst Mountains, 73531", 7 },
                    { new Guid("6f947750-0283-44ba-9342-aefd4e3f7685"), "48,950085;29,430569", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jenkinston, Venezuela", "Joel Valley, 6372", 115 },
                    { new Guid("730a6784-687f-49c5-8585-601fab1fe4e4"), "48,28682;29,453297", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Ronnyton, Marshall Islands", "Kathryne Shore, 089", 59 },
                    { new Guid("737c6d24-dc7a-4c44-bf69-b727e846d2ca"), "49,15488;25,69474", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kertzmannburgh, Falkland Islands (Malvinas)", "Dock Mall, 888", 111 },
                    { new Guid("741c2954-a901-40eb-a67b-943dd3b8c85a"), "49,94938;25,680536", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Christop, South Georgia and the South Sandwich Islands", "Americo Ford, 01731", 95 },
                    { new Guid("74bb0137-d5e4-416b-b593-bb7c895da854"), "50,624702;28,522184", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Streichmouth, Samoa", "Horacio View, 408", 168 },
                    { new Guid("74f758d6-2c48-4574-a51d-6b106c82003e"), "49,495026;24,014194", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jovanshire, Cambodia", "Izaiah Stravenue, 414", 138 },
                    { new Guid("76fe643b-431c-4d23-be6b-603bb1a5eb86"), "48,646225;29,521881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Elsefort, Belize", "Lessie Manors, 45277", 140 },
                    { new Guid("77bb95f7-c361-4f72-b164-bd05392ae4d3"), "50,416653;28,149431", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Chazchester, Niue", "Kutch Estate, 69784", 27 },
                    { new Guid("7835629a-4178-40cd-839e-cf3f3aae3aba"), "48,870155;29,271082", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Makenzieborough, Equatorial Guinea", "Kuhic Terrace, 73578", 108 },
                    { new Guid("7a8d1bd0-3795-43a2-bba0-f6da883f5963"), "49,437504;26,237488", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pacochatown, United States of America", "Christop Cove, 8856", 160 },
                    { new Guid("7b03fffc-a8ef-4c6f-9194-50213c310f24"), "50,465755;28,98661", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Helgamouth, South Georgia and the South Sandwich Islands", "Cordie Meadows, 86258", 197 },
                    { new Guid("7d7c549d-a80b-43ef-bcbc-7211978ad841"), "49,684895;26,793776", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hillston, Lithuania", "Heathcote Lane, 9306", 157 },
                    { new Guid("7dcaa3b1-63cc-4ac8-b02d-c01f393cf119"), "48,310875;27,231434", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Greentown, Republic of Korea", "Hodkiewicz Brooks, 5799", 169 },
                    { new Guid("7e41320b-7a6f-455a-9e8d-3451f5d0d908"), "48,32354;24,321798", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Dedricktown, Ireland", "Gottlieb Corner, 8725", 138 },
                    { new Guid("82114fca-8a1c-4243-8bba-c43ccae5a6c3"), "48,14256;24,531986", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Christopherchester, Sierra Leone", "Goldner Ridge, 66504", 164 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("82235bdc-b26d-46c0-984f-bd588e1a7ac7"), "49,0748;24,995485", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bernhardtown, Malawi", "Conroy Divide, 6964", 141 },
                    { new Guid("84131b65-2491-4dd1-94f6-d7714be97f15"), "48,547768;30,632475", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jessefurt, Mauritania", "Jordi Corner, 3810", 151 },
                    { new Guid("88bfa982-5505-4160-b61f-5b45c5223622"), "50,32325;29,967697", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vinceburgh, Guyana", "Thompson Shoal, 55022", 48 },
                    { new Guid("8b213e3b-6f5c-46a5-ab9d-b516299d85c0"), "48,307995;28,856295", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Lorimouth, Burkina Faso", "Oran Crescent, 922", 191 },
                    { new Guid("8cc563f5-0f73-4bc8-8960-1c39e8e7c89a"), "48,853878;23,44047", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Erin, Estonia", "Solon Knolls, 38500", 10 },
                    { new Guid("8cd731a0-9a78-4135-a68a-897ca0c17ee4"), "50,915955;24,938152", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schummbury, Guinea-Bissau", "Daniella Glen, 17402", 137 },
                    { new Guid("99a7b026-cdac-40db-b68b-ef763c142f6c"), "48,342155;30,287003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Valerieburgh, Kazakhstan", "Morgan Landing, 198", 2 },
                    { new Guid("9de05efe-6995-4c77-b711-1a5c3496c63c"), "48,8161;25,345013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zelmashire, Maldives", "Denesik Hollow, 43345", 6 },
                    { new Guid("9ed9c345-88b6-4953-850f-b0cca9e69f78"), "50,729465;27,41973", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Estelle, Faroe Islands", "Mandy Underpass, 8990", 137 },
                    { new Guid("9f2fd672-f226-4cb3-9467-183e5a87016b"), "49,105244;25,105408", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Streichport, El Salvador", "Elmira Expressway, 53894", 111 },
                    { new Guid("a27aac90-e996-4a91-97a3-32d1372d37da"), "49,283035;24,475964", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Armandmouth, Djibouti", "Rolfson Street, 736", 195 },
                    { new Guid("a78601ef-1d97-4707-b472-945fd66def25"), "50,317066;25,180107", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Noeliahaven, Jordan", "Buckridge Brooks, 0535", 33 },
                    { new Guid("ad5354d9-b271-4685-9faf-ac8ccd97b7a9"), "50,773815;25,591885", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kirk, Slovenia", "Enid Parks, 4197", 40 },
                    { new Guid("aefcbab9-66b5-4f00-81c6-fa67356f744a"), "50,944798;29,167702", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Lempi, Grenada", "Will Forks, 5092", 11 },
                    { new Guid("aeff0e2a-59f3-4507-80e8-f00fab6ae5bd"), "50,506226;29,92326", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Sistertown, Samoa", "Deja Key, 3651", 34 },
                    { new Guid("af15b13a-67f7-4775-ac7a-4ae6c6d43dd1"), "48,903454;24,801662", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Lauriechester, Guinea-Bissau", "Keon Spur, 86792", 64 },
                    { new Guid("b150766a-a45f-4ba0-b8de-18024189a7ea"), "49,936756;28,528755", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Katelynn, French Guiana", "Gudrun Loaf, 07201", 91 },
                    { new Guid("b3c1a702-0812-4ce8-b21b-f7b3fefadc65"), "48,704258;25,537714", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Shanelleview, Tajikistan", "Nyah Ridge, 193", 57 },
                    { new Guid("b9b5ac37-4c4b-4178-b418-4d44e65b26b6"), "50,743862;30,595276", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Demondfurt, Iran", "Effertz Trail, 55293", 192 },
                    { new Guid("bb2deab7-31f7-4746-a182-eaa4f7bf2d07"), "48,023197;25,575302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Idell, Finland", "Hoeger Coves, 162", 22 },
                    { new Guid("bcfc8e6e-e01a-4799-a804-7567c1ddd2cb"), "48,54029;23,758438", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Fordfurt, Pakistan", "Fahey Rest, 892", 192 },
                    { new Guid("bde5812c-d234-45f3-be2d-329ee8befb1f"), "48,774097;23,101307", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Joshuashire, Tunisia", "Kerluke Motorway, 20302", 145 },
                    { new Guid("ca08419d-4c9b-4f01-9a48-100f93fd2c09"), "49,875782;24,251202", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Runolfsdottirhaven, Ireland", "Isai Ville, 6110", 4 },
                    { new Guid("ccc61f4d-4791-49dd-928c-1aba34e79e3e"), "50,896423;28,889767", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Francesca, Ethiopia", "Art Burg, 2967", 43 },
                    { new Guid("d0e6e381-354d-4323-ad3a-c4f945792596"), "48,567196;25,560356", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Tod, Kyrgyz Republic", "Reichert Ports, 247", 68 },
                    { new Guid("d225bfd6-6d7d-4acd-8598-a1a048a53061"), "50,414364;27,735891", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Alexiehaven, Guinea", "Jast Meadow, 9336", 118 },
                    { new Guid("d3a54a94-f360-499b-963a-8a9796212ba8"), "48,939167;27,9343", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Gladysmouth, Tanzania", "Kiana Shoal, 3911", 58 },
                    { new Guid("d3bf9404-5c09-499d-b067-c499f7c544b1"), "50,678246;25,194698", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Emardstad, Latvia", "Jeffrey Drive, 085", 39 },
                    { new Guid("d66f17f1-5dfd-432f-8920-955bc207a1c4"), "48,099083;23,565804", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lazaroport, Lao People's Democratic Republic", "Bechtelar Trace, 61803", 23 },
                    { new Guid("d88ca811-3423-4bb5-a132-bdb5eaffe588"), "48,930065;29,501728", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Kalebville, Mongolia", "Purdy Greens, 1823", 180 },
                    { new Guid("da059eea-ee28-4fe0-ad0b-7592c743e6ae"), "48,978245;23,714224", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mrazshire, Gibraltar", "Jordy Spurs, 994", 60 },
                    { new Guid("df0b5091-444b-434a-9405-10cae706301d"), "50,401024;30,668238", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Whitebury, Japan", "Amya Creek, 58358", 189 },
                    { new Guid("e3dec9ac-b954-4b63-bba9-ae344309d524"), "49,95175;25,142792", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kozeytown, Brazil", "Brandi Estates, 762", 144 },
                    { new Guid("e5b3e9e2-4ad0-42c3-a8b1-47ac7e13c54f"), "48,44606;26,600641", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jaronmouth, San Marino", "Moen Burg, 807", 57 },
                    { new Guid("e646577d-fb6b-460b-8324-5c42c9908e17"), "48,1963;25,302975", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Claireburgh, Ireland", "Ziemann Falls, 419", 39 },
                    { new Guid("e852c2b5-de61-412e-9c44-4753448926bf"), "50,671764;24,288952", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Milliefurt, Brunei Darussalam", "Farrell Court, 9440", 1 },
                    { new Guid("ecd8a98e-b8a3-4211-a350-fbe2b69a5b54"), "48,581196;28,129108", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fritschchester, Germany", "Merritt Garden, 8461", 107 },
                    { new Guid("ee315e14-bf33-4f37-b626-9064ed2910f7"), "49,537533;29,958948", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hoegerbury, Saint Lucia", "Sabina Neck, 88679", 76 },
                    { new Guid("effd58fe-03de-4883-8b95-4a297aeffece"), "50,140327;23,300886", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zulaufmouth, Jamaica", "Annamae Ports, 0271", 37 },
                    { new Guid("f0da9670-e58f-4d4c-80f4-2eca3d4db1a6"), "48,29897;26,728384", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rogelioville, Niue", "D'angelo Prairie, 237", 57 },
                    { new Guid("f1275426-5eee-45d3-a1f8-cc4846afa81a"), "48,44228;30,326643", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Marquardtshire, United Arab Emirates", "Edmund Wall, 4280", 121 },
                    { new Guid("f6d359a6-c326-4a32-a1c5-d0c711f08e60"), "49,5066;24,079166", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Perryshire, El Salvador", "Marquardt Drives, 12382", 17 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("f7a81b55-4e8f-44db-b6fd-718393954d16"), "50,35706;26,629387", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lubowitzfurt, Azerbaijan", "Kub Brook, 19137", 147 },
                    { new Guid("f7cb947f-7351-480a-aea4-099665cb06af"), "48,72952;23,349003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zulaufbury, Gibraltar", "Greenholt Forest, 54509", 39 },
                    { new Guid("f9b9736b-ba8c-46a8-bb69-f5807565922e"), "49,456512;27,035543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Rosalyn, Djibouti", "O'Conner Isle, 24832", 74 },
                    { new Guid("fa14bba8-6c3f-42a3-a2bc-ca0cfabefbcc"), "49,81403;26,89036", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Emilio, Macao", "Bednar Neck, 35247", 88 },
                    { new Guid("fb0193e5-d40b-416f-842d-8a2c03dbaef0"), "49,253365;30,74332", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Ruth, Ethiopia", "Evangeline Stream, 31294", 88 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("08ec83f8-d357-4a33-a419-3f8b472dff13"), 98, "48,864098;23,923494", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zanemouth, Northern Mariana Islands", "Lamont Ramp, 8448" },
                    { new Guid("0d4c7479-6786-441e-86bf-31c803fbc798"), 90, "49,190792;25,568666", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Moises, Guyana", "Cameron Radial, 418" },
                    { new Guid("0f07a03e-8a2a-402f-ae14-79f21f774489"), 137, "50,458748;26,234892", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dejafurt, Samoa", "Madilyn Turnpike, 5729" },
                    { new Guid("0f92d5d9-aba3-41ac-ab6e-0808cd3ee450"), 47, "49,708057;28,287825", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Lempitown, Armenia", "Stefan Greens, 989" },
                    { new Guid("0fe89428-3ca0-483e-96d4-2cff6537e70f"), 118, "49,819923;29,592773", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Raynortown, Dominica", "Miles Grove, 21998" },
                    { new Guid("10194074-f890-4fde-a03d-02aacdd84f02"), 15, "49,612545;30,454067", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Meghantown, Nepal", "Rohan Dale, 66043" },
                    { new Guid("1093dd1a-66f3-4e46-872e-57a265ea9030"), 140, "49,911312;23,538143", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Roman, Turks and Caicos Islands", "Earlene Harbors, 8212" },
                    { new Guid("12922a9d-4374-4863-a25e-3407c19759ad"), 137, "50,104355;23,040272", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Renebury, Mali", "Caden Common, 8303" },
                    { new Guid("144a41fc-835b-4830-b4f1-0c50e94e99a3"), 96, "50,054417;26,72759", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Elmirabury, Sri Lanka", "Berniece Lodge, 98003" },
                    { new Guid("165f3161-b1ba-429c-9dbb-1c8134bc2b8c"), 61, "48,02823;30,371248", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trantowview, Wallis and Futuna", "Wilderman Trail, 903" },
                    { new Guid("1d1cf380-72a5-4297-9fe6-6f1108292693"), 36, "49,82582;29,623117", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stoltenbergton, Syrian Arab Republic", "Loren Ferry, 9490" },
                    { new Guid("20a43250-23b4-44bb-b397-22dbf9a5bfb7"), 100, "50,144993;26,848959", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Brenden, Timor-Leste", "Kulas Village, 912" },
                    { new Guid("270f2166-29c8-45e0-9af7-9cda7f7a976a"), 168, "49,110535;23,041113", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Camren, American Samoa", "Mitchell Dale, 48235" },
                    { new Guid("2770f473-a6ea-4fc5-aa75-477d133e5d06"), 42, "48,844494;27,622766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Tressie, Montenegro", "Stracke Unions, 3655" },
                    { new Guid("2839558e-bfdb-4473-8223-d6818ac77f9e"), 112, "48,001633;27,065096", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Esmeraldafort, Bahrain", "Eli Forks, 60477" },
                    { new Guid("2d55d818-d1f5-42fb-b58f-7e00b8dad229"), 27, "48,947887;29,329382", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schroederside, Syrian Arab Republic", "Jamarcus Isle, 99511" },
                    { new Guid("2ddf2c83-8798-479a-800d-e43cc81baf58"), 144, "48,00146;30,586325", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Kellenberg, Benin", "Schaden Curve, 39985" },
                    { new Guid("3188c66c-0cbd-489e-9201-ee00c7f0b114"), 25, "50,65471;23,159174", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Macichester, Grenada", "McKenzie Spring, 1611" },
                    { new Guid("33a912fb-f080-4237-b3bf-17d4589ca1f3"), 100, "50,44203;30,705912", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Felicia, Algeria", "Turner Pine, 1219" },
                    { new Guid("3603dafb-96d9-448b-948e-f358214c6b16"), 156, "50,343407;24,504274", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cormierbury, Estonia", "Kris Pines, 452" },
                    { new Guid("37321f4e-e893-4ba4-a9b0-facf84c52ae3"), 125, "49,279015;29,854156", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Mireya, Liechtenstein", "Roderick Springs, 777" },
                    { new Guid("37521c6e-a3a4-4a39-88a8-79315d35577c"), 174, "50,95285;27,770061", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schillerfort, Brunei Darussalam", "Darion Pine, 6832" },
                    { new Guid("38f5b1f9-576f-44b5-974e-3166e8550965"), 148, "48,060352;24,745676", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Brad, El Salvador", "Upton Lights, 31820" },
                    { new Guid("38f6ff55-1dc2-474a-ba49-9d2810fc5627"), 191, "49,50681;26,03981", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Madisenview, Samoa", "Zieme Way, 99973" },
                    { new Guid("3b3701bc-bdbf-4614-997b-2bb4a1e3b257"), 65, "50,274723;25,215094", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Shawnaberg, Estonia", "Haag Fork, 8850" },
                    { new Guid("3d34be56-5ffe-4e23-9e43-0537da4c877f"), 42, "48,599037;26,638645", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Allanview, Guinea", "Evans River, 150" },
                    { new Guid("3e8df192-f1c9-4785-a150-01f761e2d0b1"), 159, "49,47658;29,156172", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Stefanfurt, Palau", "Kaya Fort, 7954" },
                    { new Guid("465765d7-a93f-4d15-b27b-9ff6ea17f400"), 67, "49,795883;26,7223", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maryamshire, Suriname", "Bernier Run, 325" },
                    { new Guid("4ca0e020-2300-4e18-b1a5-e671dea4758f"), 17, "49,42431;27,37909", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adrienmouth, Tajikistan", "Modesto Freeway, 1592" },
                    { new Guid("4dc87fe7-2fa7-489a-8162-ddaa041ef42e"), 35, "50,491043;27,321257", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Antonietta, Kiribati", "Mills Mountains, 8535" },
                    { new Guid("4de06bdc-e5a3-4bc3-a453-84eb31e14a58"), 140, "50,141376;23,394716", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Gavin, Saint Helena", "Schroeder Stream, 1306" },
                    { new Guid("4e369155-4671-4617-80a8-1429d91dbc13"), 108, "49,784267;25,536383", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Josephhaven, Turkmenistan", "Abigail Course, 177" },
                    { new Guid("4ff58d23-8c6a-43ab-9314-ce92ab3b2969"), 194, "48,874065;24,0382", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Albertmouth, Gabon", "Beier Rapids, 363" },
                    { new Guid("51191354-cc5d-41b8-9d86-313ea2e4b09f"), 107, "48,16401;28,189928", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Cindyton, Lesotho", "Salvador Keys, 430" },
                    { new Guid("57641c69-c0b1-4dc0-99c5-41235065ab37"), 157, "50,655354;23,923594", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Jacksonstad, Guyana", "Little Flats, 716" },
                    { new Guid("57efe4d6-5497-4f87-a21f-605f849b2eab"), 177, "49,06291;30,924685", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Carmelstad, Norway", "Hegmann Flat, 079" },
                    { new Guid("587247b8-bbde-499d-847e-f9152bc39d06"), 196, "48,10175;26,318214", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hagenestown, Grenada", "Sophie Lock, 555" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("593b5a25-a244-40b0-9160-c451733aa668"), 106, "49,109276;26,884785", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Dejuanborough, Greenland", "Ivah Meadows, 526" },
                    { new Guid("5a932df7-0116-4afc-8828-e4ca466b1b05"), 52, "50,789528;30,095415", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Cathrinebury, Maldives", "Reinger Views, 100" },
                    { new Guid("5ad1f113-c4e1-410e-aad9-1ecaccea0041"), 95, "50,606426;25,976587", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lockmanstad, Reunion", "Hansen Curve, 6880" },
                    { new Guid("5e9f65a3-ef79-45eb-834d-b39084ad5100"), 148, "49,26639;25,051876", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Jeffry, Uzbekistan", "Tamia Green, 3646" },
                    { new Guid("60d4b70f-682d-4bd4-9d76-c9a2e7ab3d04"), 12, "50,3403;29,84303", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Billy, Grenada", "Gavin Mountains, 805" },
                    { new Guid("61dbf985-2e92-43ff-94e0-b907cf71ab96"), 42, "49,43623;30,796013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Odell, Qatar", "Turner Mountains, 461" },
                    { new Guid("640a5800-8df5-4991-82a8-f106a9154600"), 148, "48,57238;25,198608", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Grahammouth, Western Sahara", "Osvaldo Parkway, 9241" },
                    { new Guid("6c452d84-5f55-4b9c-8d68-9664b453b72e"), 12, "50,755894;30,09876", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wittingfurt, Uruguay", "Walter Junction, 51650" },
                    { new Guid("6c66cb72-8bc3-4043-a4a7-c43497235dff"), 165, "50,633022;24,827845", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Orionfurt, Slovenia", "Yost Shoal, 13794" },
                    { new Guid("6ec4c156-eea8-44f7-a902-fd5a6dae536e"), 156, "50,62643;23,389208", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Rowland, Germany", "Tremayne Brooks, 58564" },
                    { new Guid("70ffe223-bde2-47bd-8d74-1aee2d9ac192"), 125, "48,102043;27,510841", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Opal, Nicaragua", "Connelly Run, 25075" },
                    { new Guid("7418f911-99b0-4b54-a95f-e2fea94175cf"), 54, "48,388042;30,58966", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Drake, Sri Lanka", "Feeney Run, 9279" },
                    { new Guid("7783b22a-b439-4f95-95e4-14a16101a08c"), 116, "48,69199;28,69007", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Selena, Liberia", "Turner Plaza, 89386" },
                    { new Guid("7e6bb587-2cbc-49a9-b6b6-ef3a016e8d02"), 195, "50,672466;29,192936", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gutmannside, Guam", "Javier Fall, 3043" },
                    { new Guid("7fb17078-b1a4-431d-a99c-7705ec2b0638"), 48, "50,191795;27,617323", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Hannaberg, Saint Lucia", "Kenyatta Street, 896" },
                    { new Guid("818777c5-974e-49e1-9e60-dc64c10ffc10"), 119, "48,844505;25,619637", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Balistreriside, Netherlands Antilles", "Nader Roads, 8580" },
                    { new Guid("83858947-f085-4633-bcf7-4d46841eb2c9"), 96, "49,563457;26,509068", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Dawsonhaven, Bouvet Island (Bouvetoya)", "Strosin Shoal, 307" },
                    { new Guid("84ba62f3-3d99-4b63-89ef-42d40958aead"), 47, "50,40211;25,341728", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Khalilville, Falkland Islands (Malvinas)", "Goldner Ports, 2817" },
                    { new Guid("8a660bc6-e975-412d-a8b9-f6a1c49e30a3"), 45, "50,170135;29,6276", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wisokymouth, Maldives", "Roob Dam, 03491" },
                    { new Guid("8eef1011-1be8-40e2-b53a-5de4b391373a"), 115, "49,120342;27,80533", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lennaburgh, Turks and Caicos Islands", "Mac Islands, 0416" },
                    { new Guid("93a9c32d-00cc-45f3-8aac-dd5a44abcce5"), 155, "48,35502;29,273306", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ullrichchester, Andorra", "Elmore Track, 48869" },
                    { new Guid("959f7d32-bd1d-4838-b147-a2034a20b93a"), 169, "49,724243;26,931587", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Hailee, Cyprus", "Gusikowski Fields, 31272" },
                    { new Guid("964fdc3b-de32-47df-ba81-5c7522b815ba"), 168, "49,81046;28,448444", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Eulaliaborough, Azerbaijan", "Dina Estates, 2427" },
                    { new Guid("9a35ad40-d3b0-4c11-a568-7dc84531d3eb"), 105, "50,164654;23,852163", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Araceli, Montserrat", "Kuphal Plaza, 750" },
                    { new Guid("9c4b38e4-3432-4dbc-b9da-b47e5a4e9d48"), 14, "50,92267;30,165333", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nicolasberg, Dominican Republic", "Pamela Shoal, 7149" },
                    { new Guid("9c81a632-c71e-4da5-89b4-1d14ea900fdf"), 19, "48,110134;26,194454", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Clare, Suriname", "Hegmann Plain, 63062" },
                    { new Guid("9cd59302-d9f2-475e-b3cc-e92ccdd5d8a2"), 40, "48,18042;24,121857", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Novellaberg, Qatar", "Hettinger Tunnel, 904" },
                    { new Guid("9e4848ff-306f-438a-8087-a2373bb0dfa4"), 30, "50,986103;23,19397", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jazmynefort, Trinidad and Tobago", "Esta Courts, 4415" },
                    { new Guid("a0bee8f0-3965-4a23-8f0d-f1cc0bd26eac"), 13, "49,994106;26,198402", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Jonatanstad, Kuwait", "Padberg Falls, 433" },
                    { new Guid("a27568e4-d728-4a62-8050-97429f2b5cbb"), 89, "48,044643;25,513742", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Coty, Cocos (Keeling) Islands", "Metz Cliff, 650" },
                    { new Guid("a78a7549-4b6a-4f9d-b64e-cd0f40d79f90"), 181, "48,51716;26,85591", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Stephanside, Tunisia", "Kovacek Points, 86288" },
                    { new Guid("b00f7159-10f0-401b-a5d6-1b1b18b106e7"), 124, "50,10349;28,143032", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Funkchester, Cote d'Ivoire", "Malcolm Field, 381" },
                    { new Guid("b21e5d6a-a982-46cc-ad6c-6b0493aa4e02"), 179, "49,21266;27,219748", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Jerald, Mali", "Monroe Crossroad, 123" },
                    { new Guid("b383ff3c-ed78-4b5a-a92d-0c75265c67f6"), 112, "49,275715;24,10294", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lindsayfort, Senegal", "Chasity Branch, 30947" },
                    { new Guid("b8bacec5-47e9-48ec-8880-208063e24871"), 32, "49,72486;26,540579", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Meghanborough, Mali", "Olen Overpass, 329" },
                    { new Guid("b9207f5f-2e38-4820-9e54-3aa6fed996c3"), 71, "48,138973;28,805119", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pourosberg, Trinidad and Tobago", "Kayleigh Village, 63447" },
                    { new Guid("b949b770-1da7-4b0e-83bc-babd2dcbe4b4"), 151, "50,812054;26,811916", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jacobsmouth, Saudi Arabia", "Lilliana Lake, 47782" },
                    { new Guid("b9f04a6b-e630-4a70-a4aa-366aa0724ba6"), 134, "50,303257;27,414585", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Keyonville, Uganda", "Mohammad Ports, 86057" },
                    { new Guid("bbf04a03-3f68-4b10-9013-181fe96b0c2b"), 189, "48,844475;24,635683", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Rahulland, Tonga", "Baumbach Station, 7216" },
                    { new Guid("bc8eadc5-9c24-483e-9c43-c897284da788"), 75, "49,873;30,996332", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "D'Amoreland, Macedonia", "Toy Orchard, 41970" },
                    { new Guid("bf2ac3f6-eb89-4c74-aad1-7a138f10b4c7"), 160, "50,194454;30,523691", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Al, Kenya", "Harry Tunnel, 778" },
                    { new Guid("c1d95b76-eb85-4f7d-ae42-d0b7632b16df"), 89, "50,467453;29,635979", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Quincy, Argentina", "Adan Pike, 71517" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("c37f44f6-ef2e-4097-9659-6add0f81b6e0"), 121, "50,019505;24,24655", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Princefort, Congo", "Claudine Gateway, 77642" },
                    { new Guid("c60fbe19-a03c-46d5-b551-74b798d63412"), 156, "49,16646;28,51191", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Alizechester, Nauru", "Stracke Parkways, 47242" },
                    { new Guid("cd5f0510-414a-4d0d-9053-109abe234452"), 31, "48,14419;30,257622", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Runolfssonmouth, Denmark", "Abner Brook, 228" },
                    { new Guid("d308e123-5879-4f19-9e48-c5c1da88d68b"), 10, "48,265007;29,358198", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Armstrongborough, Guatemala", "Volkman Mill, 08994" },
                    { new Guid("d9434644-759b-4f86-a92a-67f90c93001f"), 159, "48,246006;28,494299", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Juanitaland, Sudan", "Rodger Shoal, 6717" },
                    { new Guid("d951c273-6e82-41ff-8d87-14cd322e3a36"), 168, "49,671112;23,6949", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Devin, Austria", "Sporer Falls, 8672" },
                    { new Guid("db450733-3cf1-4a4e-b589-596784234579"), 196, "48,20865;27,561302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mayerville, Maldives", "Reynold Viaduct, 25642" },
                    { new Guid("e6965328-c211-45c7-8158-af87623388ef"), 91, "48,55938;27,533283", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Jonathan, Saint Vincent and the Grenadines", "Leon Isle, 809" },
                    { new Guid("e78df454-0b54-4c4b-8f97-63c7f2ed14cb"), 88, "49,89881;28,09744", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sydneyview, Turkey", "Shanna Wall, 6979" },
                    { new Guid("e7d4b2d0-7bed-4ff2-ab6d-d5558e5a05fa"), 159, "49,321285;25,599401", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Aliyaberg, Taiwan", "Lori Valley, 5810" },
                    { new Guid("e82e1a78-ee2f-43c7-8762-e93690bd0662"), 5, "50,175827;29,16382", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Lesliechester, New Caledonia", "Vella Harbor, 7361" },
                    { new Guid("eb1eea26-eeaf-494d-9391-22fa196afcc9"), 36, "50,296528;27,50767", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schusterhaven, Burundi", "Kuhn Cape, 6189" },
                    { new Guid("eb6c40b9-7805-4825-a003-5873b1528442"), 72, "49,315628;29,62058", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kameron, Benin", "Cody Stream, 43698" },
                    { new Guid("ec3061ae-74ef-44e9-ac11-d35cc3d768f0"), 82, "50,117996;30,590622", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Andreane, Guatemala", "Ilene Plaza, 69896" },
                    { new Guid("ed19bf5a-67fc-4f66-9d3e-b501377cb882"), 23, "48,197506;26,022997", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Chayamouth, Armenia", "Aiden Circle, 95387" },
                    { new Guid("ed1da477-8270-473d-81bc-3df61deab0da"), 94, "49,634567;27,677183", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Joannieburgh, Iraq", "Chesley Lakes, 4837" },
                    { new Guid("edeefb43-bb72-4070-81db-f5212807a127"), 48, "50,77378;23,984444", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Botsfordview, Morocco", "Schmitt Inlet, 143" },
                    { new Guid("f0bf170f-9e15-4032-ad6d-282a08fffe37"), 83, "48,592377;30,205572", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schusterbury, Cambodia", "Funk Shoals, 4155" },
                    { new Guid("f5279f96-d0de-4b1f-a9f2-61646686a3bc"), 181, "49,829926;25,764822", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Guiseppeview, Malta", "Walker Mountains, 04637" },
                    { new Guid("f7f98754-344b-40a2-ba11-944c1bc84548"), 140, "48,413666;25,14691", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Kayleehaven, Armenia", "Considine Forge, 9982" },
                    { new Guid("f9979226-a0e7-4694-ac8e-b8bc227c3524"), 86, "49,574318;28,246685", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ankundingview, Comoros", "Cicero Springs, 9936" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("02bb6b03-9911-49a8-96aa-ac1300673286"), 1347738860, 0.1550770955865350m, "3DWrhRBGSPmYE4MaeKH5nzXfLFk6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7517), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7516) },
                    { new Guid("077e3486-7d20-47c6-9bbc-31eb53ac1e38"), 1294724951, 0.06208611032871340m, "3zWoCTbvfLDMXa25BdgNcsQx3nZ7A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7692), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7690) },
                    { new Guid("08d42395-9a13-4f54-8b71-f59c1d724e04"), -77307404, 0.5442702034920420m, "3WpHRa1hx7Edjztgn5c4TyruF9sBCovkUD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3809) },
                    { new Guid("08f3316f-b3f6-4113-98f3-8322391163cf"), -1053112436, 0.2989455436764950m, "3dn1ZxgU9QK2PeJruwaGMsokRvS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4283) },
                    { new Guid("0d8a3e26-e04d-4ca4-9c53-35853e479c4c"), 1602687165, 0.9908893845493710m, "LJFQ1jLK9UVmiqXYy7rz5o6DhtRNW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4322) },
                    { new Guid("0e99f711-ce8c-4360-8b08-493893d7db16"), -1362542535, 0.7945673480556390m, "LArv3fjiQ9R6Ny7d82DCs4uLMngGP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7988), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7987) },
                    { new Guid("0f90dc8d-6142-4609-8ee4-98e5380886c6"), 668906904, 0.6655344900382210m, "L3ihP7rm1FkvMXbNVYzEDUBqZeaW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(6796) },
                    { new Guid("140bb9a4-09d7-4c51-880d-640ab9e9d556"), -1492806327, 0.2930107645608340m, "LizaoRY79LdqAbGTmC8E5ZDXNcg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4248), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4246) },
                    { new Guid("15ee3631-7775-4ea2-baf5-baabd1515c17"), 23422388, 0.5871341212453660m, "Md14gFk8Yn6qPQhN2Zst9xGuAbpSLVev73", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3773), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3771) },
                    { new Guid("260b8532-6b21-4d4f-8df5-dcc68db7947a"), 652165576, 0.181690509779910m, "LN6nR15yVtJs2UpPLiq7MhvxfXFKG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3791), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3789) },
                    { new Guid("26c75633-db48-4314-b0ab-6ab629eeb0d3"), -136808017, 0.7282825750616170m, "3H1qBhTygMR2SDnsLm8oX7CVNaZru", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7324) },
                    { new Guid("275c65b2-58a9-403c-919b-85deba442827"), -1858282947, 0.1331690932664730m, "LDQZWCnrxXYuat8GLHgmAyEs1P2kp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7438), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7437) },
                    { new Guid("2853656c-eef1-424b-b386-d46f403e166c"), -1965636659, 0.6358032853311410m, "39wLBvK1htpsJYQZefWTNUn5cHbPj4A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7745) },
                    { new Guid("2af6d204-e30f-46cf-a049-94a47f644faa"), 2103998992, 0.1377136015244640m, "3yKHTQXMCectq5GrbkiPFm4A3zDZSfB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7004), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7002) },
                    { new Guid("2d7af7ea-9a4f-4949-97ee-a4dc345f39a9"), -823272309, 0.6296178089439320m, "MHPbMj5cvLBs6NhFRJSiCxEW3VeyuKd8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3562) },
                    { new Guid("320f7c05-4ada-445f-8812-1e2a97790b27"), -1753329145, 0.1469211021055070m, "MNwtvok57VJfr1SADQdRsiUX2zMmqbKa3G", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7812), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7810) },
                    { new Guid("3539c564-5f0c-4f49-acef-1be28fdac2f2"), 1760337213, 0.8645718095000980m, "33FhMxCmai9NrdetbSgKQRnHJfEAVZvsc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3703) },
                    { new Guid("35b913e3-23b3-4f12-8455-9460a481a385"), 595351436, 0.6180971836158580m, "3JaEqSPRHTFo67x9Wkb8NcrAfCsmVBjpG2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4011) },
                    { new Guid("372da68b-d641-4a85-b7db-190fc55ff90f"), 1952947800, 0.02309032930375840m, "L5Um32PYAtFVXbKBwe1n6xdkjZpJW8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3506), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3505) },
                    { new Guid("38c1cf35-ec45-4543-b523-659c412499c0"), 668450914, 0.1326943268564660m, "LW6dwKScxGf83MNu9UAz51nkCRv27a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7222) },
                    { new Guid("3a57dbd8-b3c2-4951-a10b-716fc2282352"), 943891146, 0.5599873433769110m, "3wRcmqg2Ppv3tsuy9GxSn7JLDEZV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3371), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3369) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("3ac98e30-f833-4da3-924d-562e30b73c61"), -1722705065, 0.4404410286163020m, "LxsbEiFA5MnwmKz2vuJ97DXaGUQWdk3h", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4048) },
                    { new Guid("3ec14289-ae08-4f83-a89d-a54ebbac4784"), 802921292, 0.3325934699409320m, "M6NRtB1ybxzkYh2AZgmPUar7KLdCQ948", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3667) },
                    { new Guid("40ee8e98-eaf0-4654-b8c1-57a562a97257"), -204755232, 0.4159669815785140m, "31Sc5gDdCTXL2fjeAJtwFbMVkoHx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7786), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7785) },
                    { new Guid("425b3471-afd5-4a18-81f2-ebd4a499551b"), -1908115268, 0.09932306986442870m, "3HfbND2qihYEeoZsPtxgkwa9pAvWmV6rS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3830), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3829) },
                    { new Guid("46c16108-4a12-4d8a-980c-023afc9e0898"), 883586886, 0.5780311642650310m, "38CPzJ4b7xpsXNFdKhq3Z6Ry9omfDEQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7970), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7968) },
                    { new Guid("49c75d1a-aca1-44c2-884e-523984fb6e6a"), -818702744, 0.06190142992024130m, "MSNy81F6qBL5GVRpeHdDMoQj92Pb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7418) },
                    { new Guid("4c405340-5d7c-426b-9611-b1afaed48c48"), -652189933, 0.2861720137183690m, "3mUS7XaHEBFcxRuQ25f3k4rPjdwb6LgM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 6, 4, 23, 8, 13, 818, DateTimeKind.Local).AddTicks(7603) },
                    { new Guid("4cb827eb-fe03-4050-982a-643b6c00198e"), 1470480779, 0.06534852554029020m, "3M1maGuY6QxzvATj7g5nPViq8dZB4schtp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3976), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3974) },
                    { new Guid("4d4f79d5-168b-45fa-aebe-4b884f482eb1"), -806894596, 0.653072834919340m, "3vY2mbju5qE6nkp7s8aPhfMDewSC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3488), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3486) },
                    { new Guid("4ee71d49-5054-41a5-85f9-fe111572bc38"), -503125700, 0.09089694380634980m, "3w9y2u5sfzLdQ6CFpxPtYTNnmhg8Z7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3908) },
                    { new Guid("4f880b11-e1fd-437f-8e0f-0d8630f07210"), 1600295728, 0.5782607768306650m, "L6fxK9hCbSrjEiGsTPQua3BFRknpL28mV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3590) },
                    { new Guid("532174b5-becb-475b-9237-65b8169ad1f7"), -1877208843, 0.282583296123350m, "Ls3FU5KwLpHtzk7JEjfohSPCbxiX4869m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3544), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3542) },
                    { new Guid("5476aca2-f9f0-40e4-805e-1f4bce950c48"), 100625361, 0.8371225629481730m, "Mm7HGyZfFk1t6vQnWx2jYSNqVUB3rgbR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7282), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7281) },
                    { new Guid("56079bc5-f900-424e-809e-17138f5d02ef"), -137219430, 0.1798668246760010m, "LjpFQr1wf4ayCVkXzdmDYcTu7Ao", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7672) },
                    { new Guid("56c0e99b-68cd-4bc4-9590-ab81e381f1fb"), -431434196, 0.1517737809058660m, "LMPa9HomLZNBsGTJXjkAfuxVbS86", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3321) },
                    { new Guid("5817d6f5-1346-467c-8eff-db8ce4be4b5d"), -815936368, 0.6504520780240860m, "31LsUKm3eR9M7ihZnSrXJdap48Q5bvP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4167) },
                    { new Guid("5fdf738c-24f2-418c-93f8-e77cc30fbb6d"), 1819467072, 0.2392259565674190m, "LfxjbWtpg3mRsiSJFyLH1G7P58KB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(8005) },
                    { new Guid("6117726a-8f02-4f60-9329-2e2e7780bda4"), 853848183, 0.821923450629120m, "MgfywFRKS6c2LkeajYmVJA4qpQ8Nrh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7085) },
                    { new Guid("61f5aee2-3ba3-43f1-921c-1cac249b199a"), 116255417, 0.6803277891283040m, "383DsAhy1XHBGKkESqrcCLMpRTvboi2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3848), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3847) },
                    { new Guid("629ead4b-d7d3-4f52-b4f3-e67a18707e9b"), 895237659, 0.4858534925437570m, "3qkcCsWuBirURxDtd75LYQKze2F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7851), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7849) },
                    { new Guid("63360775-fb28-4a82-9ed5-4696fe652049"), -521675042, 0.7749905975492820m, "3SAgdfewnP1VGZtTahy8YzmMEkqsK2vQp9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7536) },
                    { new Guid("63431dcd-0f58-4198-9452-bc7be3d5fafe"), -1591230703, 0.9170895484376540m, "L6A1BDGLe3bNcWvR4JSYs9M5P7z", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7103) },
                    { new Guid("6481c2ef-7fab-4a3f-b1cd-20b9fbf951a6"), -658850235, 0.06615063178844230m, "3JCirVmYyLSWUv9uPcMnwe23H8Gsjg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7608), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7607) },
                    { new Guid("699924af-ddb6-4b57-a4dd-48ac429e350d"), -716927295, 0.6649707922926580m, "LuqnJkAh2a6CWB9zQ1xfj8XDvo7dV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4133), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4131) },
                    { new Guid("6ca4e2a3-2e3c-43d7-8b92-001e0c43f5a6"), 793067506, 0.7053372305555660m, "3RAJei5c87UmHjpb2vfPESuVqQw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7499), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7498) },
                    { new Guid("717081df-c673-485f-8e80-d2ca9d6a73af"), 1926889951, 0.3162207833373760m, "M2inxd1va4HLtyKfw67ZETmVFuS9DrPh5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7830) },
                    { new Guid("742fb35e-a6bc-402d-ac72-8c5d52a5c9b5"), 248280036, 0.5225960564591960m, "MSy5xUVabmFckijHYguRG69Mn8v", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7183) },
                    { new Guid("7442a689-910f-4031-8238-c26f7f8c53c8"), 91019857, 0.571619275718920m, "3k6vPSWFwu83BA7iaz1KH9J4TfoL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3866), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3865) },
                    { new Guid("75949533-b1ce-41fb-a362-f8a29acdd2c8"), 1618236698, 0.3769650493528920m, "LSHXzPiBqJbDatjQn95FNLGZ1pUKf72ur8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4268), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4266) },
                    { new Guid("773199f4-63f5-4acd-8ca7-51022963fbe9"), 76733625, 0.5220515606866920m, "36RTLKBGwatckpAVxDeSM85Qs9bz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3992) },
                    { new Guid("77f616c9-8f77-44cc-b2cc-95db137ba9c4"), -278284203, 0.5546985622007780m, "LRsfq6FhQ7MiZ2agJ4VAT5o19m3Wz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7768), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7766) },
                    { new Guid("7b5b5a08-09b6-47a7-87cb-b3d1535ab0c9"), 2011212891, 0.918921825349550m, "LLb1HJNq5wQA6FsmVxpKnftjcS3X2yMhi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7906) },
                    { new Guid("8214696c-14bc-4be2-9aba-0f7f7b84b643"), -645101780, 0.9310129171161740m, "MZiKYe4m8yFuv9jSUs2Mx3XcNVqof", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(6977) },
                    { new Guid("823aed64-3909-4467-949e-0c20dd12554b"), -1415559236, 0.2997577148230110m, "LgpR4FCcbEkmo9szLwn6e5VT3drjX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7632), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7631) },
                    { new Guid("83613ccf-b0ca-4fa8-816c-6fa099a560c1"), -1863705396, 0.5569310599694510m, "Mt5ibQh1AeSyJPVucMCwm4KqRLjgxaYU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7463), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7461) },
                    { new Guid("83e0c99b-98cb-438b-be5c-6d88b7b6948c"), 826304193, 0.8152242398505530m, "Lig3njSNB1oLarRGtyK2cYJ9Hpw5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7201) },
                    { new Guid("85e461dd-b75d-4429-a5b5-5738bb998d19"), -899694666, 0.06025257411642590m, "MKnFhvQ4NXqbgjUwB2axyZWA71z", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3648) },
                    { new Guid("873fc18a-6e9e-4f61-ba17-06e93bbdc78c"), 144106446, 0.9584396640445450m, "MvwbqJ2suohrWNkaQdxic4Bp3P7zn5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7709) },
                    { new Guid("8968c36c-a7b9-4178-aede-b7f6d704be6e"), -1206476698, 0.8624393515895260m, "LgqL4iQy6nJo7U9pwsvkR2SfVMXA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7381), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7380) },
                    { new Guid("8a0abdb7-4444-498c-8830-7c633da88dc7"), 937492727, 0.711696403684630m, "LS5sJFKu7po1dACrLjZVQ9qf3xMt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7649) },
                    { new Guid("8b1f78a4-db1e-4e31-9010-da91e4bef501"), -825634343, 0.3326177063928330m, "MYeT1VykxBAaw7sWt2EP9Kc3o85LqZb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7305) },
                    { new Guid("8b572d21-9966-460d-9f74-d5b40c2df86f"), -349237151, 0.3264377415830730m, "3PnqBRm2a1gyfE8xDVTWKbSvicr7pNQe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3525), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3524) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("8c6655a0-d6a0-42ba-84f3-2fdc8697b279"), -1868031244, 0.6384117545495520m, "Mf2hZSk1vQNpoKmaHqwdEGgVFz6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4115), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4113) },
                    { new Guid("8fd96d91-a5d9-4cbd-ba02-b977eeddf71b"), -617940444, 0.8083292625186980m, "M31UJfCcTw8rdQoenRmzBP29LYa4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4208), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4207) },
                    { new Guid("9345e76c-b0c5-4176-8c7d-64211635556a"), -1279164191, 0.2207232527412340m, "3kVKQd8HD49rqPvE3NcMgpAjC6iR7ox", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7363), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7362) },
                    { new Guid("93619aeb-6454-4ba4-860b-ad2258d54ab0"), -1090243319, 0.6049208432713270m, "MJorN6iZC95exjaRVWnKMfEtHb2Y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3686), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3685) },
                    { new Guid("93bc1c99-09e1-4c54-baa7-38ef4724949a"), -2132351209, 0.5527799698870660m, "3xwSPTHyuMKQerfXD1gF28EZ4WiUbAqRn7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3750) },
                    { new Guid("9509e619-5e3d-4ac1-a079-b6647dcc4d32"), -996025761, 0.6807300771261220m, "3unJm4T6HZwPfQcsaxEA8zMNK7j31kp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7147) },
                    { new Guid("9d27cd85-906f-40d6-93a0-9f1f83409a48"), -1293945099, 0.5514905210009520m, "MVKz2PAy8Gsv3HekU5BpuxirLmjnE4MbCo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4305), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4303) },
                    { new Guid("a05cffce-6441-4bd7-8afc-d09cdceb8ecc"), 906275708, 0.6443531205608950m, "LAGWXy9oFPNpKH8Ef1qQBt7vkRcbd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3420) },
                    { new Guid("a12c8bc2-96fb-4cf3-a519-6d690b8559b5"), 946586553, 0.4673103918813860m, "M1TCd2jhY3sumtUek96aLVJxAyZX7b5QP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3956), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3954) },
                    { new Guid("a21dbffc-3d27-4853-9025-d785bb3e7d08"), -1941591995, 0.08362500977311360m, "3yUvcdVxXsiGRAZ8MD62aPtm3frE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3448) },
                    { new Guid("a48e9fe0-b6e4-4263-a489-794f0a2847a5"), 44402129, 0.6321465631542410m, "LwB7iynYNT8DbkRcVsCmS4L6M2HfGa3Zxe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3630) },
                    { new Guid("a6a6f885-f30e-4ae9-8004-cd4d9b184be3"), -1666531188, 0.6712146055496450m, "LHWuqKUVTXMari5byjeztPNGQEFJ8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7927) },
                    { new Guid("a8dacb32-0665-4dc2-8c18-1ca4b28c6bcc"), 1394437301, 0.04800499601377750m, "3LDez9gfTrcXWstNS5odk3qhCnHy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4148) },
                    { new Guid("ab7e5a3b-47cc-4721-a086-ebd0b57b147a"), 1138505734, 0.3330244460235750m, "LxumbqAfi12gtHUkVFpcEP6CMzR7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7066) },
                    { new Guid("aeac9ac8-78a9-4708-965f-45610994ec70"), 1750280946, 0.5911631971979110m, "L5xDhfHSXQL3g6tcdymKuEwaNq8Z7WM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4185) },
                    { new Guid("b8bbae9a-3f7d-40a8-bc68-9782916a2aef"), -20341155, 0.5080363659076750m, "3RZL4TNDrewamtsxcz8yjU3K25opF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7729), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7727) },
                    { new Guid("ba4f9895-5818-4a33-a368-9b7ea56ffb92"), -553455625, 0.9368706360309190m, "3ysxp3M1CjzUkt8fuEviw2c9QFJh6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7165) },
                    { new Guid("c0f4b19b-dcdb-4565-865c-c61a95781fde"), 638594738, 0.6466438371626560m, "3zFCPe5T8jnqVMfp1cwgi2hQsmD6ErbGB3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4096) },
                    { new Guid("c3b42eff-f368-4682-8b91-784c4255b3a5"), -235314829, 0.08814095289518060m, "3rJAubvpVLqFRajQH8t9Mzs6Ph5WKGD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3885), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3883) },
                    { new Guid("c45412ba-eb2a-447c-9845-a0c72dd49aca"), 1398740775, 0.9719678459544480m, "LdC2m1ynQWVfKFq8seuaBZt47EDHz5rR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3934) },
                    { new Guid("c53453aa-0221-4e56-96ac-f36edb9f5ed4"), -874871632, 0.05603235010545730m, "Lk56UxTmMvYBjbCwypo12ZXKDeg39nath", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3470), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3468) },
                    { new Guid("cd48bf24-7390-4b2c-86de-65349daa89af"), 410469595, 0.3636256074430060m, "LJrScCWRynMXwqeTAz247aNPvsQ8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7481), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7480) },
                    { new Guid("d5695a47-56c0-4ad1-94f2-9b14d9a6b9b9"), -631691580, 0.2759201977283670m, "LEXcdShyTUjeWaGps2ArzC3NKZDRMLg8Y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4030) },
                    { new Guid("d9130d41-ac9d-47f4-af78-def097548ee1"), -1055019648, 0.06169488946578570m, "MFoTu2HiD4tzKZ8kxEhSCwymp7B3nqY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7343) },
                    { new Guid("d952601e-22d3-49a4-b5cd-85665bef2b1c"), -1993540177, 0.859525649734630m, "Lw4FsaqGjhJTv7YXkeLgWRon8Nt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7023) },
                    { new Guid("da1211a8-68cf-4e01-9725-9d3aaab8bd9f"), -947385662, 0.9147847880414370m, "MCaRBL7jrfHK6YWSQn5hMe493Eq8voib", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7887) },
                    { new Guid("e15c1317-91cd-4e05-aed7-cf1fe922a861"), 1834012410, 0.2447574394182360m, "3iNJzv3SC5uyr7BbndTMXHo98Vt2A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7869), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7867) },
                    { new Guid("e483edd0-9377-42d6-9dd2-d5879a7703eb"), 1999978702, 0.9408175143082760m, "3ofgBsXcG2LEzUMeT9hPn1ZtKYm6vkRJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7402), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7401) },
                    { new Guid("e815fff7-37b5-47a6-a758-e3764cdcdcb3"), -2073014150, 0.1736141013548260m, "LEgW5U3xsBezCVvioPRy7aKdj8tmY9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7043) },
                    { new Guid("e99e0629-ba86-4c99-94a5-524154f6eab1"), 2063173475, 0.6561370128195430m, "3YUGmyXqKvp15Dx3wS69g48Q7be", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3611), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3609) },
                    { new Guid("f0b7b1fc-c4c7-42f5-8de8-5b55f2eb1735"), -263528324, 0.92790299405140m, "MdXxFPuzch24Degywr8Ltj9qC7HY3oap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7127) },
                    { new Guid("f3450211-118c-490f-8f51-6792c19c6b07"), -2035706710, 0.4352562266108830m, "MwQAR1yvrqxjFH5kzp9eCLtEgWo4s", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7241) },
                    { new Guid("f75acd93-eaf9-4802-8980-870d049d163f"), 2130397822, 0.7687381348045020m, "L1Wv2uZEHMJXNAUtjmCeyrnG7fd6Raz5DF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4076) },
                    { new Guid("f85ff746-2054-4610-afc3-a8de4f6af2b8"), -352894362, 0.05726863863965710m, "3czuTi5ps6gdfRPw9LU7kAFtm8YVN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3721) },
                    { new Guid("fb6b363c-0ffc-4a40-ab03-122bb6d60c50"), -984854905, 0.01301024311967010m, "Lb4uU2SoPW3eYLGXF1NiMm9yqhcZt5aAf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(3393) },
                    { new Guid("fcf404f8-cba5-4314-8f2c-859836b983c7"), 479677269, 0.6850703215041780m, "LtVeuc2XwNE7km4hoszMTQ19WSj6CdJvgF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4231), new DateTime(2024, 6, 4, 23, 8, 13, 819, DateTimeKind.Local).AddTicks(4229) },
                    { new Guid("fd886542-0389-4748-90b2-d18593dd6da2"), 507600188, 0.588719058910820m, "Lyr4J32cC1W9wkuxYTPMXhQB7eUtfin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 9, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 6, 4, 23, 8, 15, 802, DateTimeKind.Local).AddTicks(7945) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("02500051-99f5-4144-945b-877e80352edf") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("072b74c5-5e1d-46de-9caa-66d36218f554") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("09fd275e-b209-4f17-84ed-5884b76fc276") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("0ec20584-d26f-41c4-b682-05916743e30a") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("223295f7-9195-4510-8bcc-44f043830497") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("26db4c52-c906-415a-848e-eb60cadca362") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("35263c47-5006-4ddc-a824-47120f6a334d") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("36b35b89-da67-408b-9178-d5d020a70822") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("3855a279-823e-41a4-ad2e-768e134c626f") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("44275811-c945-4a4f-8382-272488a907aa") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("44736c29-d473-4b0c-9aca-5f9518cda391") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("489038c7-0441-436a-a527-66069a8b1473") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("4e8e0581-239d-4586-9cca-aad850d7d329") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("5227b046-d260-4727-89e6-90bfa60f5f27") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("57710136-3092-497c-8523-6e222848ceaf") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5f140f7e-803a-444d-8158-03815cbd832c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("70409336-0f26-4108-8c79-213e320c07f7") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("76807668-f1d2-47ed-a084-0771d51bc761") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("77941635-e388-4774-9d8a-53d61f8a1c10") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("8c396faa-ad98-400d-a562-77b4902806e1") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("95f06adb-a1fa-40bc-8351-b298d818044d") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("97253083-0ecd-4730-b815-c4b8137ab125") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("99f374c8-d976-4051-99c3-7305e5fea09d") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("9af47343-7f95-4006-8dea-4975912f5989") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("9bea6011-9948-451d-9195-7c4cc4339cba") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("ad755590-668c-421d-994e-b7a783d9dcd5") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("c8507284-511b-425f-9aab-13ef42992af5") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("ceb699bd-8c01-4831-9438-e8c30f353919") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("e046fca1-590d-4528-9a08-8baa91140ac9") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("e87e502a-19b0-4f23-969d-aabf313d6591") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("eea73942-2019-41c4-9063-ab64deb92300") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("f2542110-27bc-4868-b96c-53e10a66800f") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("f443c798-1151-4757-94ca-517bef15e381") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("f485798d-1525-429a-8e8b-8604e1673c1b") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("f819889a-570b-4521-a36f-42d900233678") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("54ffa309-0c9b-4d4e-b248-56aaf69762dc"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("196112e9-d691-4e88-a622-2bdb22f1cc89"), new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("7d391805-5a3d-47e5-94ba-c16efeb11e0b"), new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[] { new Guid("000fdc19-a5e7-4b83-a3b8-44ee38cb4401"), null, null, "Osborne_Metz31@gmail.com", false, new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86") });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("003f00eb-5554-46e3-842d-6ab9091dc5fc"), null, null, "Brandy.Will@gmail.com", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("0084ecce-df12-4222-8ecd-2216c6b745fc"), null, null, "Nia_Emmerich94@hotmail.com", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("00c062dc-b577-426c-a521-72147f0ef92f"), null, null, "Sylvester.Tromp@hotmail.com", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("011129f5-3385-443e-8b77-2675d9399223"), null, null, "Lauryn_Schultz@hotmail.com", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("0125174f-a84b-4c53-a8b8-3888bdb70be5"), null, null, "Norberto.Nienow@hotmail.com", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("013e0c26-f4f7-4307-81d2-79d483015b35"), null, null, "Kristian_Abshire19@hotmail.com", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("0185811b-c0e8-4c7d-9685-a8aa290e528e"), null, null, "Clay12@hotmail.com", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("01ae145e-27f3-4c44-ba17-317c7e6a59cb"), null, null, "Ambrose.Kuhn@gmail.com", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("024b8e4d-fccf-4fad-8ed4-2ce2b37c2013"), null, null, "Camden_White@hotmail.com", false, new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213") },
                    { new Guid("025ec263-e798-4807-97fe-727af3450c33"), null, null, "Leilani_Wehner6@gmail.com", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("026cc7a5-ecf2-421e-9142-82627f1e9e00"), null, null, "Noel.Kunze39@yahoo.com", false, new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644") },
                    { new Guid("027aaa8c-8295-47de-ac77-9ef86dfe8274"), null, null, "Korey_Torphy@gmail.com", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("029c28ed-b136-44c8-beba-64cb8eb26a91"), null, null, "Andy_Tremblay@yahoo.com", false, new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69") },
                    { new Guid("02e4c030-ec98-4237-954a-376c0ed603aa"), null, null, "Davon_Krajcik21@yahoo.com", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("03240431-fe3e-472a-9d07-a88bc599c51f"), null, null, "Darius.Pfeffer40@yahoo.com", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("0368b38b-5f4e-4f86-9cc3-185bcbb9fc47"), null, null, "Reese_Hane91@yahoo.com", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("037c5fd3-540a-4e66-bf08-44ccbfa983e0"), null, null, "Vada_Lueilwitz@yahoo.com", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("043cf970-79f9-426b-a301-840a82d1c1e6"), null, null, "Aurelia_Bailey@yahoo.com", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("0441f9f1-b578-4bb8-8b77-84f45e59000f"), null, null, "Madelyn.Cartwright@yahoo.com", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("04e772a1-ee3b-4975-9807-ee1cceb0be96"), null, null, "Jodie_Sipes@yahoo.com", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("0554267d-6ffb-4200-9695-b98710aad59d"), null, null, "Kellie.Conroy79@hotmail.com", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("057b2d2c-e25d-491e-adec-0a309c31f488"), null, null, "Alisha.Wintheiser@yahoo.com", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("0656ac61-e99e-4665-92eb-bb33d1b9cf27"), null, null, "Sarah_McKenzie13@hotmail.com", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("06b5876b-8a12-44e4-9d4a-4e899c9a6dc4"), null, null, "Jairo_Mitchell@gmail.com", false, new Guid("26db4c52-c906-415a-848e-eb60cadca362") },
                    { new Guid("07133cdc-6b53-42f3-9a8c-f94c91fa99a2"), null, null, "Mauricio42@yahoo.com", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("07482722-00a2-476d-9d67-0ee69b64ab26"), null, null, "Zelma.Hettinger@hotmail.com", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("07b58584-098e-47e9-86ae-b38d5fc6a679"), null, null, "Chelsea.Halvorson77@gmail.com", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("07f4020a-63f2-4fbc-87cf-8160e530c02d"), null, null, "Leonel.Grant@yahoo.com", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("084eb20b-6776-4bc7-9b32-30ddc6e21e01"), null, null, "Natasha_Crona80@gmail.com", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("0854aad0-32a2-4f52-8472-15ea18f54241"), null, null, "Dulce_Jones71@hotmail.com", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("089e7649-9500-435b-8eee-a7b3fd5eb357"), null, null, "Graciela_Towne86@yahoo.com", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("091859e3-c105-4306-ae92-9d32d057c0cb"), null, null, "Alexa.Russel@yahoo.com", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("09ccfa06-35b0-4acf-940b-078b69c2e876"), null, null, "Brannon_Witting@gmail.com", false, new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8") },
                    { new Guid("09f2cedf-79d9-4e4f-9266-9aed9e6bf769"), null, null, "Stephanie.Price2@yahoo.com", false, new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f") },
                    { new Guid("0a1be257-6452-4219-8162-333ae79b431a"), null, null, "Sarah40@yahoo.com", false, new Guid("95f06adb-a1fa-40bc-8351-b298d818044d") },
                    { new Guid("0a57a5cb-2683-4bd3-924c-14845ef0f222"), null, null, "Jace.Mraz60@yahoo.com", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("0ad68623-a117-416e-9b44-0f000abd492d"), null, null, "Daphney73@hotmail.com", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("0ae5d5fa-b2af-4f16-96e0-b054289dc734"), null, null, "Blaze.Lehner48@hotmail.com", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("0bdbe321-4daa-463f-8f77-84dd3b0b5e51"), null, null, "Alexandre.Morar16@hotmail.com", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("0c287a9b-b522-4e7a-8945-075fa7f9b2c3"), null, null, "Minerva88@gmail.com", false, new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1") },
                    { new Guid("0c61db77-83f0-482d-bde4-2b0cb5933d46"), null, null, "Mariela_Hyatt@hotmail.com", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("0cb99bb2-dc08-4534-89e4-0e51f12531a2"), null, null, "Augustine81@yahoo.com", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0cf0cadc-81da-4e32-92bd-a5644685c360"), null, null, "Nakia.Kunde@hotmail.com", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("0cfccff1-f64e-4f91-96b4-a91a92c717c3"), null, null, "Verlie.Moore@gmail.com", false, new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca") },
                    { new Guid("0d0afa4f-5352-403d-b0a9-0cc602952b95"), null, null, "Austyn.Connelly@gmail.com", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("0d261dd4-9977-4da4-84e3-bdfcba63330c"), null, null, "Dante_Howell@gmail.com", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("0d366163-d68e-4ca4-a616-7c638687bef0"), null, null, "Chaz60@yahoo.com", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("0d56249e-fd35-4a3a-bb44-d60132daa534"), null, null, "Garrison91@yahoo.com", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("0da5d1df-8ced-4d56-b641-fc78c24f1216"), null, null, "Ron_Gibson@gmail.com", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("0dcafde2-15f0-4491-bfa9-41a709ffdef5"), null, null, "Ebony46@hotmail.com", false, new Guid("e046fca1-590d-4528-9a08-8baa91140ac9") },
                    { new Guid("0dcbc9ab-73ba-4dc9-9d85-4ba3af63a319"), null, null, "Bridgette.Beatty@hotmail.com", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("0dffc94f-987a-41e5-a80e-0357e8b72d65"), null, null, "Isaac.Kling58@yahoo.com", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("0e4ca59e-458c-451f-bf55-c50ec80b0bd7"), null, null, "Olin.Morissette@yahoo.com", false, new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("0e5b3a07-a1ef-4d07-b057-68c467b06308"), null, null, "Cordia_Kunde@hotmail.com", false, new Guid("09fd275e-b209-4f17-84ed-5884b76fc276") },
                    { new Guid("0ef47ce7-957a-4f08-a786-c5b2a5f4cbe3"), null, null, "Rahul_Heidenreich@hotmail.com", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("0f4c54c4-4a09-48f0-a0d3-62236cd3415c"), null, null, "Ashtyn_Douglas@hotmail.com", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("0f839758-9c5c-4300-9631-650698a06b59"), null, null, "Clarabelle51@yahoo.com", false, new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f") },
                    { new Guid("0f97b3cc-72ea-4532-8112-81cd334ea639"), null, null, "Neha19@hotmail.com", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("0fc470f1-ecc9-4a8c-94ff-4090ba4de525"), null, null, "Kacey83@yahoo.com", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("10650632-afcf-461f-a1c3-7ef76d93bffb"), null, null, "Laron.Pouros@hotmail.com", false, new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3") },
                    { new Guid("1072b4f5-4c3f-491b-87d9-c789f2e4f358"), null, null, "Ozella65@hotmail.com", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("109f39fc-aa44-4021-93ad-7724debfcefe"), null, null, "Thea71@yahoo.com", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("10ffc937-48c3-46a9-8939-9376d4e375c0"), null, null, "Gerry.Leannon@yahoo.com", false, new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab") },
                    { new Guid("1102814c-b655-402f-b6fa-a85def7d0f8e"), null, null, "Gabe_Klocko@hotmail.com", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("11144b26-9007-4c04-8514-23ab5b8f83ad"), null, null, "Brain_Bartoletti96@gmail.com", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("11251ad8-83d5-43c0-9f2e-7b007e5620ce"), null, null, "Kraig.Hammes@hotmail.com", false, new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("11521fba-1bc7-4478-894f-5b674b81c983"), null, null, "Tiara84@gmail.com", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("116537b7-8fb4-4dd4-9fa5-0eda1087fe1f"), null, null, "Owen.Gulgowski@yahoo.com", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("11ebd415-e00b-4205-880b-0d373b655af5"), null, null, "Aron_Lueilwitz36@hotmail.com", false, new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") },
                    { new Guid("121a051e-b494-4777-8f61-9182e81a416b"), null, null, "Camille_Connelly7@yahoo.com", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("123428b7-bb5c-4523-851c-fe07ed3f8b70"), null, null, "Jettie.Pfeffer43@yahoo.com", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("1250f85f-ae7c-4490-9db0-f92d8277ab48"), null, null, "Margie.Beatty80@hotmail.com", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("125c6e6e-b604-4ed8-88a0-2d08f44a4709"), null, null, "Jailyn.Roob@hotmail.com", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("125fbd8b-484e-416a-a9e3-6e47eaf5de62"), null, null, "Jarrell32@yahoo.com", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("139d5468-12c2-4a20-adf0-b40deb4ec39a"), null, null, "Grant66@gmail.com", false, new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c") },
                    { new Guid("14378b2a-0420-4d0f-8abf-3d7304de7d24"), null, null, "Amaya10@hotmail.com", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("1448ee87-e8ae-4d2a-b763-1fd66fafb7a2"), null, null, "Penelope.OConner@hotmail.com", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("1462f2fd-641c-4690-8566-a88b36dbafdc"), null, null, "Lottie_Bahringer96@gmail.com", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("14711315-d53e-41c5-9264-4ed0f85f3caf"), null, null, "Omer.Parisian10@gmail.com", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("1486dfe7-93aa-4722-971e-c3a44459444f"), null, null, "Ansley20@gmail.com", false, new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640") },
                    { new Guid("149debb5-4977-446b-acfc-12676910e287"), null, null, "Wiley.Barton@hotmail.com", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("154070b3-14d2-4ecb-a612-f8b127329b79"), null, null, "Trace39@gmail.com", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("15cad5ca-b0ed-496b-9c57-c5ccc90d7ec5"), null, null, "Darren.Goodwin20@hotmail.com", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("15e7f752-6069-487d-85d9-74c4dd4b139b"), null, null, "Christina.Dietrich99@hotmail.com", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("15f843b2-d27f-47f5-9937-2d1440fbee1d"), null, null, "Annetta78@hotmail.com", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("16da17f3-b141-4d79-bc29-ed8e6db6e54f"), null, null, "Vernon_Zulauf23@gmail.com", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("1717f362-3533-4206-a373-e30eded963d6"), null, null, "Joaquin57@yahoo.com", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("1748f4c3-a39d-417e-b6f5-3db70b3e8e1d"), null, null, "Bianka.Lowe@yahoo.com", false, new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe") },
                    { new Guid("17f7ca28-70b9-4981-bbc3-7f82e7a5703a"), null, null, "Meta.Bosco@yahoo.com", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("18498a96-899e-432f-b58a-a0575de6be75"), null, null, "Leda16@yahoo.com", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("18536d1e-3aca-4a8a-a81b-0cdd5d51ae3c"), null, null, "Reta47@hotmail.com", false, new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f") },
                    { new Guid("1967fd71-c0fe-4374-b870-771c8f3564e7"), null, null, "Edna23@gmail.com", false, new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a") },
                    { new Guid("1996f2ca-342c-435b-8628-16a94a5d15d9"), null, null, "Kallie.Abbott33@gmail.com", false, new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5") },
                    { new Guid("19c8732b-fda8-41d1-bd19-717b97903c3f"), null, null, "Myrna29@yahoo.com", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("19fc732f-43b3-469c-9c8f-0c604622151b"), null, null, "Cooper_McGlynn23@gmail.com", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("1a0a7c6e-2be6-4829-a0cf-0973d6dfd82b"), null, null, "Kyle_Beatty53@gmail.com", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("1a327f7e-1fac-4398-8da9-2fa41b0f5331"), null, null, "Ozella0@hotmail.com", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("1a8b7193-b499-4ecd-b28b-33db50f64134"), null, null, "Jakayla.Sauer3@hotmail.com", false, new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4") },
                    { new Guid("1a9904d6-3edd-4e74-9960-dca95ee74f1c"), null, null, "Misael.Jacobs@yahoo.com", false, new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20") },
                    { new Guid("1ac3c976-b0d2-4b41-a726-fde33674cdd5"), null, null, "Fritz69@gmail.com", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("1b1081a4-125f-45ee-9dbd-f30a4f84cdc9"), null, null, "Brayan_Schaefer36@hotmail.com", false, new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("1bf0f0b9-4a6b-41cb-8f28-767a42b03ea9"), null, null, "Aaron_Hilll@hotmail.com", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("1d06e095-f478-400d-9fff-5aa114ce2358"), null, null, "Emilie73@yahoo.com", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("1d723e1a-c91b-432a-be9f-7252968e476b"), null, null, "Ardith.Shields84@yahoo.com", false, new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3") },
                    { new Guid("1dc592f4-aedc-4007-95da-ee7bc26b25bc"), null, null, "Eugene17@yahoo.com", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("1e587d58-f66e-4956-ab55-6a9c0d7cca4d"), null, null, "Kiel.Roberts86@yahoo.com", false, new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7") },
                    { new Guid("1e76c550-aff5-4183-a38f-3bb64246c71b"), null, null, "Delores_OHara80@hotmail.com", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("1eec0623-051f-4291-83e1-25e3219a0b60"), null, null, "Brant.Jerde53@hotmail.com", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("201ee1f8-a542-4199-9990-bc28be0520bb"), null, null, "Sam.Herman8@yahoo.com", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("2025efb4-b378-4b95-90ef-20cbb0d1246f"), null, null, "Anabel.Ferry@gmail.com", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("204245d3-f03d-4cc0-aa76-05ab1c2b0cf8"), null, null, "Ludie_Prosacco@hotmail.com", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("20a79e6e-7b12-4073-a2ff-222c7ef21c92"), null, null, "Lesly48@gmail.com", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("20d77674-6260-447f-8009-7d656e1932b3"), null, null, "Bell_Bernhard40@gmail.com", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("20f4c249-c28c-4153-a951-4132c3452703"), null, null, "Gladyce47@gmail.com", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("21652b01-b5c1-4adb-89c2-9124d24b6e41"), null, null, "Ferne_Zulauf@yahoo.com", false, new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2") },
                    { new Guid("21a0fdfb-1a8c-4a89-b9df-c905afcb4a7c"), null, null, "Micah27@hotmail.com", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("21fab9c0-d037-4125-aac3-697e42e7e0bb"), null, null, "Pat30@yahoo.com", false, new Guid("c8507284-511b-425f-9aab-13ef42992af5") },
                    { new Guid("224f2f44-f45e-445a-b0fd-15231597cb00"), null, null, "Ola.Collier73@gmail.com", false, new Guid("ceb699bd-8c01-4831-9438-e8c30f353919") },
                    { new Guid("225783c0-f43d-4850-a0d0-3341283828dd"), null, null, "Twila.Skiles34@yahoo.com", false, new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722") },
                    { new Guid("2395dc56-deb9-44e2-8c91-a13a61329b4b"), null, null, "Deshawn.Johns@yahoo.com", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("23bd2744-4b78-4343-82be-70e33c325283"), null, null, "Carter_Sporer96@yahoo.com", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("23f0104d-b2d6-4b12-889f-03810fdcb744"), null, null, "Rhoda_Tillman19@gmail.com", false, new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a") },
                    { new Guid("2407e1be-8693-4f55-b8ef-3b36408fc83f"), null, null, "Kayleigh99@hotmail.com", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("247cb0d7-3292-46a6-88b2-5a5ce4e6ae34"), null, null, "Brooke.Weimann94@gmail.com", false, new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6") },
                    { new Guid("2487c26b-ba0d-43d4-b7b8-95f746ad364a"), null, null, "Ted66@yahoo.com", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("253e10ad-4ea0-484d-a444-b2bf49eea558"), null, null, "Bella19@gmail.com", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("25908e16-7f11-4117-a058-952a8e21161c"), null, null, "Stanley97@yahoo.com", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("25b25844-1c23-4d27-97f2-9d3c5619ccf3"), null, null, "Gretchen41@hotmail.com", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("25e2bc87-5d79-4da0-a6a3-c38a5f760a22"), null, null, "Carson19@gmail.com", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("2602dcb2-b35e-4531-833a-d140296e5b54"), null, null, "Jovan_Mayert@hotmail.com", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("263b80f4-0fea-40ce-80ee-3eb6b8d7ad7d"), null, null, "Grayson_Franecki@hotmail.com", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("2701081a-ba0d-49a2-a5c1-3838434390bd"), null, null, "Idella_Konopelski25@yahoo.com", false, new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512") },
                    { new Guid("2721e27d-da5d-440d-ad4e-211d91b038f5"), null, null, "Chelsey12@gmail.com", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("273761b4-4cbf-42ee-89b7-d7efc3bd35ad"), null, null, "Glenna89@gmail.com", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("274a7d4e-bc4d-4ab4-bbc4-c216ccbcdd3a"), null, null, "Hassan.Sipes@gmail.com", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("28068948-4676-46f0-a014-f11ead722177"), null, null, "Jany.Lind61@gmail.com", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("28376146-f2e6-41a2-a9fa-b3f5f21bddd5"), null, null, "Terrence.OHara33@hotmail.com", false, new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4") },
                    { new Guid("283fc0d5-69c6-41cb-8cee-3436b8d1ef1d"), null, null, "Humberto94@gmail.com", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("28431105-87b5-498c-a0be-7cfd3fcc9fe0"), null, null, "Lacey.Hodkiewicz@hotmail.com", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("2889b57d-90cc-4907-9c38-f145b8ac3ee9"), null, null, "Ova_Skiles94@hotmail.com", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("29244ab6-d8ab-4690-8795-8f3e4aa7ccb7"), null, null, "Lily.Jones@hotmail.com", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("2952c8e7-5331-4b92-bd74-ed6bc62be5f6"), null, null, "Stefanie47@gmail.com", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("29b85fdb-a9a1-4d99-ae1f-1a6e372c788f"), null, null, "Aida57@hotmail.com", false, new Guid("44275811-c945-4a4f-8382-272488a907aa") },
                    { new Guid("29d49c21-18e2-404d-ab77-8a1838a3a865"), null, null, "Kaleb42@hotmail.com", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("2a14927a-4723-46ad-bb14-3a68b9a46997"), null, null, "Laney_Torp@gmail.com", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("2a351ce0-f760-4953-b99e-00cf4a476503"), null, null, "Retha_Bergnaum@gmail.com", false, new Guid("ad755590-668c-421d-994e-b7a783d9dcd5") },
                    { new Guid("2bdcb4ab-315a-4215-a994-31f96d96c5b5"), null, null, "Celestine_Waelchi@yahoo.com", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("2c2ba391-d443-4d93-9c9d-cc727309db81"), null, null, "Kennedy_Hodkiewicz60@yahoo.com", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("2c3544cf-2a51-41f4-b1a6-770fb4fc66c4"), null, null, "Shyanne_Nienow94@gmail.com", false, new Guid("e87e502a-19b0-4f23-969d-aabf313d6591") },
                    { new Guid("2ce4e12e-ce77-43e4-896d-2b28e468a8cd"), null, null, "Drake_Price@yahoo.com", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("2cfbba79-10c7-4542-9c90-dc5db80b87a4"), null, null, "Colleen_Schoen7@hotmail.com", false, new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756") },
                    { new Guid("2d6ded1f-5c2b-4291-bc37-e7ed4d77df9f"), null, null, "Jerad49@yahoo.com", false, new Guid("35263c47-5006-4ddc-a824-47120f6a334d") },
                    { new Guid("2db3516e-25ac-4084-a87a-b73b6884b097"), null, null, "Fernando_Mitchell@gmail.com", false, new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f") },
                    { new Guid("2dc1eb14-6991-4d04-8e0d-c610fbb4a14b"), null, null, "Oran85@gmail.com", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("2e15adf1-8ed8-4783-9533-13c648072821"), null, null, "Simone77@yahoo.com", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("2e4148be-4e57-436b-a457-20f27cef0024"), null, null, "Jackie83@gmail.com", false, new Guid("36b35b89-da67-408b-9178-d5d020a70822") },
                    { new Guid("2e997188-caec-414c-a7b2-cd12767cef9d"), null, null, "Mallory.Marquardt15@hotmail.com", false, new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797") },
                    { new Guid("2ebbad40-9bea-4eb9-af9d-11f2560a382b"), null, null, "Jarvis_Kilback93@yahoo.com", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("2ef51782-b285-4f9a-8e1b-1f0b0cac9a54"), null, null, "Marques_Stokes@hotmail.com", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("2f9f589f-5f8c-4f69-927b-3245675c4ba7"), null, null, "Jerod.Johns6@gmail.com", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("301e6c5c-260a-4c3b-be2a-11d76f8749f8"), null, null, "Monte41@hotmail.com", false, new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2") },
                    { new Guid("3046610e-5241-4f2d-8d10-7875ce24b2a6"), null, null, "Palma97@gmail.com", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("30cded73-e642-4d5e-95cd-a2488c30af58"), null, null, "Madelynn.Larson@gmail.com", false, new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953") },
                    { new Guid("30ded7c4-2d9f-47d2-b024-82a90d15358a"), null, null, "Aniya_Haag@gmail.com", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("30ee0737-c3b2-46f4-a36e-432f33402468"), null, null, "Anthony_Quigley82@hotmail.com", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("315094b5-e5da-4622-a66f-df89d9d207af"), null, null, "Fleta.Johnston86@yahoo.com", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("319b1a59-ba35-4404-8465-876bf18e11b7"), null, null, "Jailyn.McDermott57@hotmail.com", false, new Guid("f485798d-1525-429a-8e8b-8604e1673c1b") },
                    { new Guid("31c27433-7ae8-4554-ac34-ce77ceb82004"), null, null, "Kaylah.Hills@yahoo.com", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("31d6e2c9-ece9-4984-b547-c090bd18a5db"), null, null, "Brooke_Wolf41@hotmail.com", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("320f570c-19f1-42ce-8152-c1ed1eb0ed9e"), null, null, "Chadrick.Casper35@hotmail.com", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("321e2cc7-1e3c-4462-b4b6-898bc5ac6b83"), null, null, "Bessie10@yahoo.com", false, new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c") },
                    { new Guid("32266820-8e11-4d60-a6fa-f1fbcac57578"), null, null, "Else71@hotmail.com", false, new Guid("9bea6011-9948-451d-9195-7c4cc4339cba") },
                    { new Guid("32f658ec-746d-4486-8460-e4cffd39bdbd"), null, null, "Krystel56@yahoo.com", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("34018f92-dc0a-468d-863e-121b84ed8cb4"), null, null, "Agustin.Champlin@hotmail.com", false, new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") },
                    { new Guid("34751644-d84a-4517-a3ec-1e306ec49478"), null, null, "Tomasa94@hotmail.com", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("34cc1873-9048-40d2-a040-0c4d6aaef274"), null, null, "Ruben99@gmail.com", false, new Guid("02500051-99f5-4144-945b-877e80352edf") },
                    { new Guid("34d11ee4-25e2-4faa-b1fe-809a6d22d553"), null, null, "Isaiah_Spencer@gmail.com", false, new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722") },
                    { new Guid("34d9561e-8c79-42a4-81c3-78127890e7f6"), null, null, "Clemmie_Runolfsdottir@hotmail.com", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("34da4dfc-23c4-4f1c-adaa-dfd966bbc9eb"), null, null, "Anabelle.Emmerich27@hotmail.com", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("35fc7a29-3c32-48e4-a54b-ebd39911b26e"), null, null, "Amira.Reinger@gmail.com", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("35fe0237-72ca-4470-a8ed-41fc57d886fa"), null, null, "Lydia51@hotmail.com", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("36af6049-4b87-4d4e-a0f2-8750c2366133"), null, null, "Javonte6@yahoo.com", false, new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("374381ab-7cfa-4cf0-9917-2f8048ec465e"), null, null, "Ricky_Batz51@yahoo.com", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("3791ad09-d2be-48f5-882d-3ffe4573b1bf"), null, null, "Cletus.Jaskolski58@gmail.com", false, new Guid("f819889a-570b-4521-a36f-42d900233678") },
                    { new Guid("379c7a5b-3253-4b0b-86cf-5a0704266a72"), null, null, "Theo72@yahoo.com", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("38453af4-69ee-4f88-b0e9-a29f4d8ecc5a"), null, null, "Brycen.Dicki15@hotmail.com", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("38d19646-69e5-4ab5-9188-40bb843da1a5"), null, null, "Wyman7@yahoo.com", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("392fb92c-e256-4ef6-8b10-721223b689a8"), null, null, "Sabrina.Harvey@hotmail.com", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("393d8750-077b-4627-a197-c177539f1b61"), null, null, "Tanner_Metz@hotmail.com", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("39b32183-9c8b-4885-a954-d8442c7cd9f9"), null, null, "Presley_Stroman33@gmail.com", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("39c52665-d70b-4a1b-93b7-d4d4f0de38da"), null, null, "Chanel_Walsh13@hotmail.com", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("39ec25b0-334a-4cee-9b11-4a53145f2573"), null, null, "Nelson22@hotmail.com", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("3a012d13-9bec-44d7-966c-15e610489d33"), null, null, "Emile_Dach@hotmail.com", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("3a54c8e0-6b29-4fa1-aa16-a5da8ace8e84"), null, null, "Jadon_Green@yahoo.com", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("3a6a8435-b2a5-4b03-a122-6e1fe7214875"), null, null, "Jean_Mohr@hotmail.com", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("3a8c306a-5f0f-4597-8353-ffb5ddcb9c9c"), null, null, "Jeanne.Beahan@hotmail.com", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("3a8d6dd5-9156-4c34-8934-1096ca53fc08"), null, null, "Preston41@yahoo.com", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("3aa7747e-df92-474b-bcec-082bd996bd3e"), null, null, "Cordia_Bernhard@gmail.com", false, new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") },
                    { new Guid("3ae76d6c-29e9-4134-926c-ef5acf3531e1"), null, null, "Al_Reilly72@hotmail.com", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("3aeb847d-da28-4ac1-9bb6-f8afd2995fec"), null, null, "Tod.Hagenes71@hotmail.com", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("3b2bf1c1-a8a4-454a-81d4-c83f9f31ba0e"), null, null, "Raymond_Dibbert@gmail.com", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("3c3120f5-ec8e-4946-9287-86b06d3d5517"), null, null, "Carmella24@yahoo.com", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("3cf84994-edc4-4a93-bed9-c7a7e16ba0fb"), null, null, "Deven.Koelpin@gmail.com", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("3d77035a-5a62-4eb2-abb5-4bfaa545f0e1"), null, null, "Skylar1@gmail.com", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("3ed571ca-69c3-456e-9a57-31395437d3a1"), null, null, "Daphne22@hotmail.com", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("3f80b8ab-9d41-4e25-93ec-2a5ea4ff3fec"), null, null, "Alfreda_Predovic67@gmail.com", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("402f0c5c-b70b-45e6-ae68-fb291735acd5"), null, null, "Lemuel28@gmail.com", false, new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("40a8d21b-bfee-4372-8c9b-c3bf5e12d300"), null, null, "Edd.Nicolas75@gmail.com", false, new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512") },
                    { new Guid("40ab4e6b-ed51-46ea-b573-673e33acd77a"), null, null, "Kylee.Zulauf@gmail.com", false, new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf") },
                    { new Guid("40c8c88f-1f3d-49d7-a14e-ca5fecc9bf51"), null, null, "Lyric_Bartell@gmail.com", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("410fe4de-52c5-4123-b52a-bcd1884f74ff"), null, null, "Jamey69@yahoo.com", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("41103f2d-254f-4706-b0ed-a9ede3d66419"), null, null, "Icie_Cronin@yahoo.com", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("41393b61-ce0c-43bb-882c-7ded80e3c0f9"), null, null, "Nellie84@hotmail.com", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("419f1599-b2c5-4939-83e4-5efb6e0b5118"), null, null, "Kamron_Stark@yahoo.com", false, new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3") },
                    { new Guid("41a0d883-f867-4c99-bba8-d5de04ce4205"), null, null, "Layne.Schmidt85@yahoo.com", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("41c3aa7c-279b-437f-b157-e17d8f80e940"), null, null, "Louie15@hotmail.com", false, new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf") },
                    { new Guid("41cab87f-2442-4bb4-b375-b18018b674e5"), null, null, "Garrett_Gibson27@gmail.com", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("422d2c47-abfc-4a2d-83c1-14b063d7e27c"), null, null, "Amos16@hotmail.com", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("4260ab06-860a-4e1e-921c-f4b39f0961f5"), null, null, "Breanne.Marquardt15@gmail.com", false, new Guid("f443c798-1151-4757-94ca-517bef15e381") },
                    { new Guid("4271ac34-948d-4d40-9031-3463179b9014"), null, null, "Savannah74@yahoo.com", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("427fe2a9-a943-4762-a4f2-3135de910143"), null, null, "Katlyn.Keebler@gmail.com", false, new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803") },
                    { new Guid("429c0fd7-2068-43eb-99b3-03e90d03b6e7"), null, null, "Colton96@gmail.com", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("42beb0c7-cb10-40ac-a9ae-2cddcfd5e862"), null, null, "Corene97@gmail.com", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("435ecb01-1fb8-4006-8a16-b6e805bdca5b"), null, null, "Providenci_Kris@gmail.com", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("44481a6f-3af7-41ae-ab50-4b97ef2cf5df"), null, null, "Wyman.Shanahan@gmail.com", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("4474e37b-176e-4dfa-8ad2-8bc7cc89f6b6"), null, null, "Baylee78@gmail.com", false, new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc") },
                    { new Guid("4537e4ba-2165-4756-9299-eb39f2f79764"), null, null, "Davin42@yahoo.com", false, new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("45d90c50-14da-41df-b39a-171fc379c229"), null, null, "Allie_Hane@yahoo.com", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("464159af-060c-4b94-8cfd-2143787db28b"), null, null, "Abigail_Lemke@hotmail.com", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("46557b8d-f1a8-4eb8-9ab4-be0aeae3396e"), null, null, "Reanna.Lesch27@yahoo.com", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("46e9fcea-e0af-419b-8198-75cb6f4c20fb"), null, null, "Jordy46@yahoo.com", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("46f22cdf-0b0a-4ac6-94fe-61e6b827c161"), null, null, "Anderson6@gmail.com", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("470b04e1-37c8-42f6-908c-0269a0de239a"), null, null, "Edd62@hotmail.com", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("475646d6-f3d2-4a6f-b485-517b338d9d05"), null, null, "Dessie.Friesen19@gmail.com", false, new Guid("70409336-0f26-4108-8c79-213e320c07f7") },
                    { new Guid("4766a171-1bdc-406a-b342-bb96a7d6bd8a"), null, null, "Jeanette_Lehner17@hotmail.com", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("479745a9-5e16-4fa0-9551-acc775c47cbd"), null, null, "Irma.Mohr20@yahoo.com", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("4805cabf-8586-4461-b37b-bb8b14558d0b"), null, null, "Crawford.Bahringer@gmail.com", false, new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938") },
                    { new Guid("4815fbfd-a336-464b-b5c7-daad6c3e48e0"), null, null, "Herminia62@gmail.com", false, new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8") },
                    { new Guid("4867db91-00a6-423a-bd6c-a33a03c07f38"), null, null, "Roma.Waelchi18@yahoo.com", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("486aaa48-1bd9-4a5c-af5f-482f97c9adcb"), null, null, "Easton_Beahan@gmail.com", false, new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925") },
                    { new Guid("48741704-b81f-4281-a3cb-d56ce5cf08e5"), null, null, "Luis77@gmail.com", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("4875b589-6aa1-46b6-b313-7273cc7d0568"), null, null, "Kristian_Christiansen@hotmail.com", false, new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae") },
                    { new Guid("487e24d3-4fee-45b4-98f7-19f45e384639"), null, null, "Doyle97@hotmail.com", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("48c8955c-d538-4cf0-a013-d64031f6e064"), null, null, "Alford_Collins20@hotmail.com", false, new Guid("97253083-0ecd-4730-b815-c4b8137ab125") },
                    { new Guid("490efe8e-9f9b-4f82-ba51-75aa4da53833"), null, null, "Morris.Reinger89@yahoo.com", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("491510f4-02cb-4f5e-86b5-f61fa628610b"), null, null, "Deja_Roberts85@gmail.com", false, new Guid("eea73942-2019-41c4-9063-ab64deb92300") },
                    { new Guid("493dc6f3-846d-4bd2-b9ca-ff6fe7de45ce"), null, null, "Lonnie77@gmail.com", false, new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca") },
                    { new Guid("496c21d3-22bf-476a-8b1a-8f73779f8a4e"), null, null, "Sandy.Bruen@yahoo.com", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("499944e7-1b41-4f89-b68a-e4eb9cdad55f"), null, null, "Mollie77@hotmail.com", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("49aebfd6-3041-4477-9452-9a6c9c1c4fad"), null, null, "Prince69@hotmail.com", false, new Guid("02500051-99f5-4144-945b-877e80352edf") },
                    { new Guid("4adc7520-c23e-4e04-9c4e-805d37f59380"), null, null, "Catalina61@hotmail.com", false, new Guid("5227b046-d260-4727-89e6-90bfa60f5f27") },
                    { new Guid("4af67435-f4f1-4c71-bdd2-f6dc4af3022e"), null, null, "Tevin_Collins34@gmail.com", false, new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4bc8a64d-9a53-4fcf-bf9c-f21c4947d5e6"), null, null, "Delfina88@gmail.com", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("4be9d037-bbf0-4411-9e69-fe46e2212c63"), null, null, "Effie15@yahoo.com", false, new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953") },
                    { new Guid("4c1955eb-b4bd-4024-999a-24b9e5918fcc"), null, null, "Taya_Davis21@gmail.com", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("4c5e3545-9b2f-43e1-9cf3-8932dd3de8ba"), null, null, "Elroy_Daugherty30@yahoo.com", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("4c5e71f5-6a04-488a-90a4-5ffa74b098e0"), null, null, "Walter_Stokes@yahoo.com", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("4cb52e64-47e4-431d-a74a-02fd31288209"), null, null, "Kaya.Leannon17@yahoo.com", false, new Guid("76807668-f1d2-47ed-a084-0771d51bc761") },
                    { new Guid("4d77dd83-a4f8-4969-988d-166a08011958"), null, null, "Godfrey.Veum@yahoo.com", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("4dd363e9-c470-40bf-bfc3-5722187af341"), null, null, "Lloyd_Thiel@hotmail.com", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("4dfebcd6-8cdf-49f3-a42b-b3c5d5aa4a97"), null, null, "Jedidiah_Rice@yahoo.com", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("4e0d7e24-94f3-470a-86c6-2cadad7ad851"), null, null, "Trudie_Deckow@gmail.com", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("4e727d0d-d187-4800-9ffe-35983a0fa8b3"), null, null, "Hilbert.Harber76@hotmail.com", false, new Guid("f485798d-1525-429a-8e8b-8604e1673c1b") },
                    { new Guid("4e857777-acfa-4146-8d43-2d45006839e9"), null, null, "Margarette_Bergnaum75@hotmail.com", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("4ebaa154-e24e-441e-b3d0-7fd1cbe4e5d9"), null, null, "Lilliana.Steuber@hotmail.com", false, new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a") },
                    { new Guid("4f4a7e7c-fb23-45c1-bde5-9773d1b384ba"), null, null, "Queenie_Bailey43@hotmail.com", false, new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a") },
                    { new Guid("4f6b3ec0-0e84-40f1-a2c7-91a02bea359c"), null, null, "Maritza.Batz15@yahoo.com", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("4f8ae648-b103-447f-bff3-5d01150483d8"), null, null, "Hilbert32@gmail.com", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("501a4ea0-6884-4880-b308-338586839bf4"), null, null, "Bryon19@gmail.com", false, new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") },
                    { new Guid("509da6bd-b6f2-4308-a4fc-70936cadd3ee"), null, null, "Loma.Parisian@gmail.com", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("51702782-e90a-4e71-a260-2f90aaeb7d31"), null, null, "Kay_Emmerich45@hotmail.com", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("5222a1d3-8452-430e-8a09-db37cb1beea3"), null, null, "Glenna_Kessler@yahoo.com", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("52542458-af03-4780-a21c-397380ff9ab7"), null, null, "Marcel.Connelly@yahoo.com", false, new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4") },
                    { new Guid("526c267b-ae49-48d3-a9bf-210b8d19f796"), null, null, "Audreanne_Runolfsson@yahoo.com", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("527256a6-2b27-4f3a-bc24-1fc65256eee9"), null, null, "Anya44@hotmail.com", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("528e6dc4-e26d-44a7-b4d8-820f2b23ba0b"), null, null, "Althea59@hotmail.com", false, new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c") },
                    { new Guid("52b3515c-b4c0-4d4d-ab2f-666bf01bf4b8"), null, null, "Adrain_Corwin@gmail.com", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("52dbddbb-2fc2-4410-9b1b-39958020d278"), null, null, "Cicero_Leannon16@gmail.com", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("5362cd32-4076-4df0-8423-d5f56602e1f1"), null, null, "Selina18@gmail.com", false, new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("53b3f30e-422e-4603-bec4-9f80de88b7d9"), null, null, "Waldo66@yahoo.com", false, new Guid("f2542110-27bc-4868-b96c-53e10a66800f") },
                    { new Guid("54171410-5da2-4e7f-8a38-9a1090a866a0"), null, null, "Christ_Beatty26@hotmail.com", false, new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058") },
                    { new Guid("54459e3f-b97f-48ad-977c-962976fba993"), null, null, "Annabelle90@yahoo.com", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("54625c91-0242-4bf9-afa3-2f5d3beb6588"), null, null, "Leonardo.Littel45@gmail.com", false, new Guid("99f374c8-d976-4051-99c3-7305e5fea09d") },
                    { new Guid("54da182a-23bf-44b3-9274-267b82c98254"), null, null, "Jerald_Ruecker8@gmail.com", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("55818723-a428-4939-8799-346600945eda"), null, null, "Imani81@yahoo.com", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("56717752-ad45-4b3c-8b87-65165155e769"), null, null, "Myriam71@yahoo.com", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("5677dd2b-075d-4a06-940d-abe5ac1aed2b"), null, null, "Joy27@gmail.com", false, new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("568edc8b-301b-4ec9-a175-a247d176844a"), null, null, "Lee.Hauck@gmail.com", false, new Guid("44275811-c945-4a4f-8382-272488a907aa") },
                    { new Guid("56ca41c5-a4ab-458f-881e-f719c83a0afe"), null, null, "Virginia60@gmail.com", false, new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2") },
                    { new Guid("56f9cbc0-7996-48fc-9ed6-116dfd41ec2c"), null, null, "Brooks_Muller87@hotmail.com", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("57114954-b46a-4fd6-b1eb-cae2701d6373"), null, null, "Payton.Bode@gmail.com", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("5711f6ec-bcd7-48e8-a643-1ec790cbc2a6"), null, null, "Pietro.Terry@yahoo.com", false, new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17") },
                    { new Guid("57204f71-4a34-42fd-9643-09631276fcc8"), null, null, "Cicero.Oberbrunner@hotmail.com", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("57272c8f-7017-4534-b7a5-48876691d75c"), null, null, "Josh_Herzog@yahoo.com", false, new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("57520305-973f-4b3c-81e5-4c89f624c8ea"), null, null, "Kathlyn30@hotmail.com", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("5765d966-0025-42f8-b75e-6b8daf93f54a"), null, null, "Hailey.Rowe18@yahoo.com", false, new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce") },
                    { new Guid("577a4069-3a24-4c8e-bfe5-277ceb2180df"), null, null, "Grady_Moore73@gmail.com", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("5795ca0f-3c83-4a7c-890b-93f75bf22992"), null, null, "Raina.Witting53@hotmail.com", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("57d297c6-fe89-428c-ac03-20154c093dc9"), null, null, "Cathy20@yahoo.com", false, new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") },
                    { new Guid("58299fcd-ba4b-45ab-acf0-ac72ba1bd2d8"), null, null, "Charley.Ernser10@gmail.com", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("58bf0e0d-8d5c-4684-aa85-689705f40416"), null, null, "Everette32@gmail.com", false, new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3") },
                    { new Guid("58f7389a-43df-49db-b13a-ee23a7d82c7a"), null, null, "Mariah21@yahoo.com", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("5971f1d2-9880-4d2d-82d1-d54fa9f8a5e8"), null, null, "Cynthia36@yahoo.com", false, new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1") },
                    { new Guid("59754706-976f-4623-98b8-a2d797c41fbb"), null, null, "Zack_West94@yahoo.com", false, new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056") },
                    { new Guid("59ebfe53-f118-4cfb-8cba-6ade9f4454a4"), null, null, "Eloisa_Botsford90@hotmail.com", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("5a3f28b1-1712-4482-a6f3-2f7521ad587d"), null, null, "Peyton_Mitchell@gmail.com", false, new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1") },
                    { new Guid("5a4ec1e3-f060-451b-9bac-d41951d09a70"), null, null, "Brett_Collier@hotmail.com", false, new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084") },
                    { new Guid("5a910db2-8e2a-4a65-bbaa-66adaa7e5e6b"), null, null, "Fred.Dickinson75@hotmail.com", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("5ac1189c-e63d-4247-a6b2-56dec13422f5"), null, null, "Edison7@gmail.com", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("5afd6e46-39c3-42c1-8385-f0f21a58c7d6"), null, null, "Esteban.Blanda@yahoo.com", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("5b234b35-6159-4e21-8c1c-7f725cf1316a"), null, null, "Zetta33@gmail.com", false, new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d") },
                    { new Guid("5b5fad7a-4083-4994-b3e7-52c2992edcaa"), null, null, "Scot57@gmail.com", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("5b775c47-e862-43be-8dc6-d5a67507bf08"), null, null, "Adeline_Marvin@gmail.com", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("5b97f11c-a87f-41f9-b4e1-f83b99221e70"), null, null, "Annalise_Tillman90@yahoo.com", false, new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3") },
                    { new Guid("5c0877e4-e5ac-4280-ad59-1f21e75407cc"), null, null, "Aimee.Anderson75@hotmail.com", false, new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d") },
                    { new Guid("5cc13ae8-8e59-4fcb-94fc-f5b577ce1bce"), null, null, "Arnulfo23@yahoo.com", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("5cc5e0fe-42f1-4682-980c-0a6af59b4677"), null, null, "German_Corkery69@gmail.com", false, new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("5cd933d8-067d-448a-a198-ec208c7e6d32"), null, null, "Laisha.Corwin49@yahoo.com", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("5d04093d-c331-46d4-8688-85c1afe96f72"), null, null, "Mireya_Vandervort@hotmail.com", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("5d5273d4-5e00-4b0c-8907-b4ee5b114c0f"), null, null, "Nichole.Conroy0@yahoo.com", false, new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed") },
                    { new Guid("5da91fc2-2ae3-43d5-9de0-8501532dd80f"), null, null, "Armand_Batz@gmail.com", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("5dec5cfb-3520-4735-bdd3-00e631cd6b51"), null, null, "Issac_Bergstrom@yahoo.com", false, new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c") },
                    { new Guid("5df1b7d5-6264-4e63-b9c6-91954c99f58c"), null, null, "Demario60@yahoo.com", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("5df6208a-34d4-4bb0-9ea9-e7d6fca7f6cc"), null, null, "Kaela21@gmail.com", false, new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5") },
                    { new Guid("5e71fe4d-c76c-4863-a467-d03ce038ab67"), null, null, "Kailee20@gmail.com", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("5ef09499-05ce-4801-bfec-bb4965228d1e"), null, null, "Antonia.Koss87@yahoo.com", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("5f4156dd-0d03-4eec-8973-0d0473a46bf5"), null, null, "Syble_Hammes60@gmail.com", false, new Guid("3855a279-823e-41a4-ad2e-768e134c626f") },
                    { new Guid("5f52da6b-5af7-4515-815b-cfbad941db20"), null, null, "Alexandrine22@yahoo.com", false, new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7") },
                    { new Guid("5f562b61-c63f-4656-8270-13c99464a2d7"), null, null, "Dalton.Little@gmail.com", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("5f7d5857-8059-4fcf-b0e8-6014e9b12f4b"), null, null, "Omer_Becker3@hotmail.com", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("6004fbf5-c9f2-4a93-a3a9-f868958b0fb7"), null, null, "Lennie_Metz@hotmail.com", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("606e737f-187e-402c-8364-f2fce10abbc1"), null, null, "Elyssa_Hyatt31@gmail.com", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("60940807-8a66-485e-802a-1d85521ef4b8"), null, null, "Delta32@yahoo.com", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("6116e097-0302-4592-90c2-a5b51ec3323f"), null, null, "Bo83@gmail.com", false, new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("6121f0eb-3718-458b-bb2f-31726d77e80c"), null, null, "Elisa21@gmail.com", false, new Guid("f2542110-27bc-4868-b96c-53e10a66800f") },
                    { new Guid("61f0b37b-26cf-4711-9127-b799f82153be"), null, null, "Sarah68@yahoo.com", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6219fab3-d2b1-4359-b773-fb88881296af"), null, null, "Betty.Kautzer82@gmail.com", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("6222ce94-1db8-4ddd-a3b5-30f1373276a1"), null, null, "Tremaine10@gmail.com", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("625381bb-bc78-44cd-b57b-ba6fda2dafd0"), null, null, "Sincere.Schamberger@yahoo.com", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("628271cf-cda0-4d65-b4c1-3b3f7681bb2d"), null, null, "Hannah50@hotmail.com", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("62e70fdd-558c-41a1-8406-1f87631d856b"), null, null, "Germaine53@gmail.com", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("631297a3-3a64-4a24-85a5-7c6546a7cfa5"), null, null, "Dewitt2@yahoo.com", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("63139465-92c2-4d83-956d-35d82ca44483"), null, null, "Hillard91@yahoo.com", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("6317008f-a0ce-4e43-ba5c-1fc94ccc8c6d"), null, null, "Tyrel.Kessler97@hotmail.com", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("63608ab9-a34e-4737-ba6f-5239855d3002"), null, null, "Javier.Torp@hotmail.com", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("63f01b1e-553b-45f2-9a4d-d252ad5d829f"), null, null, "Laurel.Ziemann27@hotmail.com", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("64579ec2-2d35-4727-835f-d9fcdbdedcdd"), null, null, "Alba_Dicki96@hotmail.com", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("649ced9d-89d1-453b-aea4-ec523aba0617"), null, null, "Murray2@yahoo.com", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("64a84ec6-15a5-4961-9664-fd95eafa18d2"), null, null, "Colby_Buckridge@gmail.com", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("64db64fd-d7a7-4d0a-a54e-ef139b99fbe7"), null, null, "Alexandre31@yahoo.com", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("64dcd711-681a-45a2-b020-6256bdb40afa"), null, null, "Kaylee42@gmail.com", false, new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5") },
                    { new Guid("64e89b0e-de0b-4907-bbb1-eaf18d683a6b"), null, null, "Dakota.Lindgren26@gmail.com", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("6515978a-ecdc-4293-bbd0-2f18b599bb58"), null, null, "Roberta25@yahoo.com", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("65ad1981-364a-4933-9136-1631910545b5"), null, null, "Delaney_Batz@gmail.com", false, new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf") },
                    { new Guid("6644bd13-f5d8-4ab9-8a4f-2861f6ad3e41"), null, null, "Margarett11@gmail.com", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("66d31b35-a2d7-4108-8027-8149cbb7e835"), null, null, "Jazlyn.Crooks@hotmail.com", false, new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058") },
                    { new Guid("66dbbe9a-f1e8-426d-aa42-79843927c5b2"), null, null, "Asha73@gmail.com", false, new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc") },
                    { new Guid("66fe224d-8707-47cd-aa43-eef3c6a1a13f"), null, null, "Emerald.Kris@hotmail.com", false, new Guid("36b35b89-da67-408b-9178-d5d020a70822") },
                    { new Guid("6709d9a0-e71d-4458-944f-9aa5efa3421b"), null, null, "Joseph.Crist7@hotmail.com", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("675296da-46f7-4e6b-ba66-c4ffc5e52c0e"), null, null, "Meggie30@hotmail.com", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("6766ef1d-47c7-4808-9fc6-f1d2c057dd12"), null, null, "Weston.Flatley@gmail.com", false, new Guid("489038c7-0441-436a-a527-66069a8b1473") },
                    { new Guid("67962b58-8a4b-4ddd-9137-47a5723b0449"), null, null, "Gunner.Heaney@yahoo.com", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("6831e7cb-c17a-47f4-ab94-bc08a6fda2a7"), null, null, "Elvis_Armstrong97@gmail.com", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("683e3b04-f601-4ba0-a374-6f32e678a658"), null, null, "Donny_Haag@hotmail.com", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("68e37e35-ef2e-4c84-b6c4-0e244acfde43"), null, null, "Delmer_Mills@hotmail.com", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("68fb484c-a9f1-4231-9366-ca99d801eb12"), null, null, "Megane43@gmail.com", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("693d95f9-91e9-4c98-b193-c0ad9e3b094c"), null, null, "Ewell_Renner@gmail.com", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("6a0a0f43-cf24-4927-8d8c-2ede369228ac"), null, null, "Valerie.DuBuque@gmail.com", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("6a0ad2a1-6d80-4487-95bc-3ccabe2b8506"), null, null, "Malika3@hotmail.com", false, new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797") },
                    { new Guid("6a2fccdb-21be-4339-b410-e30fd411fd80"), null, null, "Thalia.Bednar@yahoo.com", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("6a34a2b6-ff03-4350-bad3-d26695a6a663"), null, null, "Marlee.Pacocha26@hotmail.com", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("6a5b2ff7-a7ca-48c4-be3d-bbd7a28421d4"), null, null, "Elenor55@hotmail.com", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("6adc3ce4-c235-4018-b0ab-80c2186e8805"), null, null, "Alexander.Gerhold83@gmail.com", false, new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7") },
                    { new Guid("6af0923d-202e-488d-b439-a00f068f0813"), null, null, "Berniece45@yahoo.com", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("6b4cdca3-a38f-4e7d-9d6e-1249838fc3b3"), null, null, "Leonor_Brakus19@hotmail.com", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("6b67c193-b26a-4676-91c9-f43fe823f216"), null, null, "Jamison.Prosacco10@hotmail.com", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("6bce0b0c-97a6-4436-90d8-d2d41975a49e"), null, null, "Benjamin.McGlynn27@gmail.com", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("6c108867-4e58-4260-bf38-3b3cc2b356d6"), null, null, "Lonny8@yahoo.com", false, new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6c8f28c3-3db4-4cec-92c3-b2e3bc79f9a0"), null, null, "Aditya.Reinger40@yahoo.com", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("6c96ef1c-62c7-4ac6-bc8a-384dbc0e00f7"), null, null, "Gavin24@yahoo.com", false, new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07") },
                    { new Guid("6cb8063b-9f92-49de-ab2e-9cc5022830ad"), null, null, "Laurie_Schoen@yahoo.com", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("6cbc73fd-829f-4b2c-b280-243b7d9132f1"), null, null, "Margarita1@hotmail.com", false, new Guid("09fd275e-b209-4f17-84ed-5884b76fc276") },
                    { new Guid("6cca3fba-f256-48de-bdb6-68c7d3feceea"), null, null, "Jaqueline.Heller@yahoo.com", false, new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3") },
                    { new Guid("6e06155b-3494-4426-865a-4f5a6a69736b"), null, null, "Gudrun.Kuhn23@gmail.com", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("6e16f25b-ad44-4f03-805b-756c771c9daa"), null, null, "Jayden_Bradtke@yahoo.com", false, new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf") },
                    { new Guid("6e903590-7bcb-4e54-b937-d4817da01124"), null, null, "Isabel.Bruen@yahoo.com", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("6ea03de0-7b2e-49c2-84bb-282cc76e04ff"), null, null, "Vallie94@gmail.com", false, new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f") },
                    { new Guid("6ebe0e16-663e-4288-b748-80c0ae8424a6"), null, null, "Kendall_Macejkovic32@gmail.com", false, new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07") },
                    { new Guid("6f014325-1820-4a1d-8ed9-89e13935c9d7"), null, null, "Clyde.OKeefe2@hotmail.com", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("6f3a4a30-6228-4558-aad6-cc805e724640"), null, null, "Aracely35@yahoo.com", false, new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe") },
                    { new Guid("6f4f3021-c00e-4c7e-ade5-dc9bd5036b96"), null, null, "Ozella_Upton20@yahoo.com", false, new Guid("072b74c5-5e1d-46de-9caa-66d36218f554") },
                    { new Guid("6f812a08-509f-48c0-b83a-5565cb633267"), null, null, "Lemuel63@hotmail.com", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("7094d656-2ae9-4ef8-8e44-3bb6af9f7a37"), null, null, "Ralph_Corwin12@gmail.com", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("70ff783f-6933-4c26-a94b-f4d3761341e2"), null, null, "Mable_Lesch@gmail.com", false, new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2") },
                    { new Guid("71064275-c792-48e7-8cbe-6924202d6300"), null, null, "Astrid_Bins76@hotmail.com", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("711b7cb2-64ea-466e-89b7-10e8a662c887"), null, null, "Dejah.Prohaska75@hotmail.com", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("72ad84fc-23f5-4bf0-8c73-0384be6a6ee2"), null, null, "Justyn64@hotmail.com", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("738fe95a-aec7-4ebb-82c3-bb68d12e4591"), null, null, "Beverly.Crooks84@gmail.com", false, new Guid("57710136-3092-497c-8523-6e222848ceaf") },
                    { new Guid("739a119b-3b09-47f1-bcf9-133179cab377"), null, null, "Kennedy_Crist@yahoo.com", false, new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5") },
                    { new Guid("744e5551-803f-4baa-b541-c41169b44913"), null, null, "Geovany_Champlin26@hotmail.com", false, new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084") },
                    { new Guid("74838712-4b3f-462b-a5f9-b4c25bae85e1"), null, null, "Darwin5@gmail.com", false, new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938") },
                    { new Guid("74e13df0-e0af-4045-9201-d9144baf9154"), null, null, "Jaylin72@gmail.com", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("74e5f39c-cf16-4df9-bc56-524a43130829"), null, null, "Jordyn.Wolff@hotmail.com", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("75704f33-93a2-47d8-afd2-f6830ec0e084"), null, null, "Keyon37@hotmail.com", false, new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("757e0c74-7a49-4fec-8d6c-067ad875aacb"), null, null, "Bella30@yahoo.com", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("7586dbf5-25bc-4de4-b815-c3e39bc00451"), null, null, "Kylie_Boyer92@gmail.com", false, new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") },
                    { new Guid("75b3e86a-1617-4580-824c-83bc4273f265"), null, null, "Rowland87@gmail.com", false, new Guid("44736c29-d473-4b0c-9aca-5f9518cda391") },
                    { new Guid("75bcda9f-7e29-4bc1-a48a-c754407f6066"), null, null, "Lorenzo_Padberg69@hotmail.com", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("75e63610-ab2a-4bbf-bb56-ef335f584e32"), null, null, "Karen80@hotmail.com", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("761030c1-1a0e-44a1-8939-92103b03c837"), null, null, "Doyle.Johns@gmail.com", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("7660e0a0-f4f7-4ba0-bf87-3909bd084045"), null, null, "Helena_Braun82@hotmail.com", false, new Guid("f443c798-1151-4757-94ca-517bef15e381") },
                    { new Guid("7704ad11-67ed-4192-856e-fc118d60ed23"), null, null, "Trenton.Miller@gmail.com", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("777b2691-c3c2-432a-a3df-6139de0867a5"), null, null, "Prudence.Trantow3@hotmail.com", false, new Guid("35263c47-5006-4ddc-a824-47120f6a334d") },
                    { new Guid("77c877ef-5b10-467a-8e02-6548c0103184"), null, null, "Alexander80@yahoo.com", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("78a2e608-5f3a-4c97-9bc5-fb5bebcee3ea"), null, null, "Twila10@hotmail.com", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("78c3828d-39f6-4c4a-9003-3bfabb945467"), null, null, "Noelia33@yahoo.com", false, new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f") },
                    { new Guid("78d2f39a-d1c2-482a-a112-87f0e8f116b0"), null, null, "Vivian82@hotmail.com", false, new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b") },
                    { new Guid("79a21010-9189-45ef-868f-925a3a0bb7f3"), null, null, "Annabelle.Yost89@yahoo.com", false, new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f") },
                    { new Guid("79de2887-4be1-4c00-8f17-3992c30392c7"), null, null, "Susie_Bosco@gmail.com", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("7aaf0c68-c83f-4221-b9f2-2ea7445ba365"), null, null, "Keon_Beahan60@hotmail.com", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7b26be89-55d7-4e0b-ac68-df9e8b62d926"), null, null, "Zita.Osinski38@hotmail.com", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("7b353194-889c-4e30-9b53-d9e8b5fc6166"), null, null, "Juliana_Batz@hotmail.com", false, new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17") },
                    { new Guid("7bc0de55-9543-4e81-887f-f393cf81123e"), null, null, "Flo_Skiles10@yahoo.com", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("7bfe2ca0-c22f-48e9-b4e0-f3c851c16cdb"), null, null, "Francis.OReilly@gmail.com", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("7c01a9d7-f429-4fc9-bf17-d362aa780b93"), null, null, "Raegan84@yahoo.com", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("7c355deb-2023-47e1-9dfa-cc5489419fc6"), null, null, "Ryann_Roberts@gmail.com", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("7c5d7bc0-3b86-472b-99a6-c9bb6c1711f3"), null, null, "Timmy76@hotmail.com", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("7d69d79f-a097-4db8-8fea-f10093b6fd50"), null, null, "Edd69@yahoo.com", false, new Guid("f819889a-570b-4521-a36f-42d900233678") },
                    { new Guid("7d7beaeb-1923-4174-a565-c66292f60ac1"), null, null, "Mara47@hotmail.com", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("7de701ba-2302-49d2-8248-9b92627ee884"), null, null, "Micah98@yahoo.com", false, new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc") },
                    { new Guid("7e387de8-c1b2-4e83-9e92-fc6e4c76b084"), null, null, "Jaycee_Collier@hotmail.com", false, new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4") },
                    { new Guid("7eb6dccb-148d-4fb7-ad7d-91f70305fa82"), null, null, "Elva_Little30@hotmail.com", false, new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925") },
                    { new Guid("7ed8b73e-f85e-4c11-8101-c4e5c9d8b960"), null, null, "Kaylee_Johns86@yahoo.com", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("7f0f2f55-95aa-4509-816d-4d74c732193f"), null, null, "Travon_Jenkins@gmail.com", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("7f4a7209-a1a9-4904-8262-5b8f8c5c44f9"), null, null, "Freida.Keebler36@yahoo.com", false, new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e") },
                    { new Guid("7f62fc8f-a83f-456c-8a8c-10575fdb8b75"), null, null, "Anika50@yahoo.com", false, new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f") },
                    { new Guid("7fc7d9d4-e697-4780-a120-2a969fbd55f0"), null, null, "Melody.Ward@hotmail.com", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("7ffc5da0-8b03-4ec4-9629-4aa38f0db9bc"), null, null, "Emory.Berge@yahoo.com", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("8079766e-9bd4-4263-a3a1-0e5fd55fc335"), null, null, "Sofia71@gmail.com", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("80de84e4-f9cc-4fb5-a0e1-e3ee1b054ecd"), null, null, "Joanne49@yahoo.com", false, new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("814d7585-12df-4347-acbe-fd2b09268d28"), null, null, "Nya_Armstrong@hotmail.com", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("8166994c-84cf-499c-af09-60906cc97c79"), null, null, "Gladys88@yahoo.com", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("818dd5a0-6426-4ea6-af47-894b909b1b64"), null, null, "Bertha_Gleason@yahoo.com", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("81ae2bfc-9c39-4524-a6ab-609281b903df"), null, null, "Alysha_Bergnaum57@gmail.com", false, new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213") },
                    { new Guid("820a8922-594e-4700-979b-5f892cab10e1"), null, null, "Dixie5@gmail.com", false, new Guid("e046fca1-590d-4528-9a08-8baa91140ac9") },
                    { new Guid("8316a9bb-9c22-477f-8fed-e1171de30a43"), null, null, "Annalise_Wisoky25@yahoo.com", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("836e1a86-b431-49a7-85b6-09dd6d909a5b"), null, null, "Abelardo_Halvorson@gmail.com", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("85a62f7c-b0a3-4a1e-b539-00a13139277a"), null, null, "Emmet.Grady@hotmail.com", false, new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc") },
                    { new Guid("85b96758-13e1-4c30-b3d4-245699725b2d"), null, null, "Hank.Price1@hotmail.com", false, new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed") },
                    { new Guid("85d36fd4-2c4b-4bba-8e34-8adef60ec463"), null, null, "Nia_Waelchi90@gmail.com", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("86452f35-bc13-4260-a77b-ffe1dc467864"), null, null, "Rory.Shanahan@yahoo.com", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("865e0cdb-cff4-4f05-8e2c-15016c8cd6ed"), null, null, "Sonya_Witting89@yahoo.com", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("867de6fe-a493-4e48-bc38-954fbd93a7b6"), null, null, "Kelton72@gmail.com", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("87bc2374-f437-4dae-ab11-56e173dd82b7"), null, null, "Monica58@hotmail.com", false, new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8") },
                    { new Guid("87cd54a9-e346-4f21-ba19-0d78558189f9"), null, null, "Maudie25@gmail.com", false, new Guid("5f140f7e-803a-444d-8158-03815cbd832c") },
                    { new Guid("8865db78-20ad-4249-9c3f-1a327dcfa3bb"), null, null, "Isac16@yahoo.com", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("88a86a95-861c-478e-a948-5071115e56c8"), null, null, "Ariane.Schamberger@hotmail.com", false, new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9") },
                    { new Guid("8983ce69-4997-484b-b590-56ae0c6e364a"), null, null, "Erik_Harvey97@hotmail.com", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("8997e905-acd9-49f0-bea1-ee436c4752f2"), null, null, "Nathanial78@gmail.com", false, new Guid("489038c7-0441-436a-a527-66069a8b1473") },
                    { new Guid("89ac53a5-397e-41e9-85eb-121292e6cb44"), null, null, "Jamar15@yahoo.com", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("89e8a993-7f49-4026-8605-4c8a86f6f416"), null, null, "Logan_Crona15@gmail.com", false, new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3") },
                    { new Guid("8a53a044-f186-44e8-a825-f8b37e13ccdd"), null, null, "Clifton.Stroman55@hotmail.com", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("8ab57fc1-6d3c-4aed-92a6-102506c00491"), null, null, "Hattie26@hotmail.com", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("8c0a6ba7-714d-4c8e-ad59-1863a57d5052"), null, null, "Caesar.Crona@yahoo.com", false, new Guid("5227b046-d260-4727-89e6-90bfa60f5f27") },
                    { new Guid("8cea471a-3076-4f07-b99c-6ac3ed65eae0"), null, null, "Javier3@gmail.com", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("8d8d6f02-a4dc-41a6-a85a-5646d6314912"), null, null, "Declan.Macejkovic@gmail.com", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("8da1d596-22ef-484e-baa0-e1709e365fe6"), null, null, "Zora_Durgan30@hotmail.com", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("8e19e0ef-fa87-4909-9be5-2d0976bd1da4"), null, null, "Hoyt_Kessler@hotmail.com", false, new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda") },
                    { new Guid("8e1e5978-37ff-48a6-85b3-bae8bbb0af73"), null, null, "Osvaldo56@yahoo.com", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("8fbf9fc0-5df0-4027-88a3-47f4fa08ac57"), null, null, "Antonina.Satterfield@gmail.com", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("90bbae8b-893a-4e99-83e0-79e3cb55d036"), null, null, "Berneice_Senger@gmail.com", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("91000320-2b5b-45c5-a162-31643315b9f6"), null, null, "Gloria.Hansen@gmail.com", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("918ad0a0-d16a-4b46-b26a-49fa347ecb03"), null, null, "Clemens_Koelpin@hotmail.com", false, new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c") },
                    { new Guid("91a17b78-3240-48dc-bc75-904a5e414900"), null, null, "Lysanne_Heller@yahoo.com", false, new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae") },
                    { new Guid("921287be-be15-4fef-bf51-fd4877986854"), null, null, "Arvilla.Marvin@gmail.com", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("922869b6-5a90-4f2d-b0e8-483adf1b524e"), null, null, "May_Kautzer@hotmail.com", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("928626da-c75f-410c-8fdd-bf3c288e1a8d"), null, null, "Estelle76@yahoo.com", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("92a14f38-857d-4095-a5c1-04aca6d46bb3"), null, null, "Reid.Mertz18@gmail.com", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("92eec1e2-012c-48a0-938f-46c331797c04"), null, null, "Rey63@yahoo.com", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("93047556-d50d-405b-bfb0-9149ebf5e49f"), null, null, "Kyla.DuBuque@gmail.com", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("9319cd3f-537d-4faf-b7cf-6d78654e05a2"), null, null, "Maye_Pagac@hotmail.com", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("93acf7c7-f8ce-4812-9683-8405f64abdc9"), null, null, "Edwina_Jenkins@hotmail.com", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("93daba4d-ea43-4e04-9bf0-917d09a2ea6a"), null, null, "Olin.Bergnaum8@yahoo.com", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("93de8807-5b75-470b-9e13-89f58cc043fe"), null, null, "Rey7@gmail.com", false, new Guid("e87e502a-19b0-4f23-969d-aabf313d6591") },
                    { new Guid("9427933f-32f0-4106-8345-252a47df7d9b"), null, null, "Ferne_Hand@yahoo.com", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("94287683-f6d0-4bd9-9d79-9deca15c41f5"), null, null, "Terrence_Hodkiewicz@gmail.com", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("9433528a-dca0-4b14-8069-cbc229dd8a83"), null, null, "Nathan.Strosin@gmail.com", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("946877ec-51b6-4e9a-9615-dd5345fe2919"), null, null, "Nathanael.Breitenberg@gmail.com", false, new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4") },
                    { new Guid("94866dc7-3a71-492b-a171-63b17d4356d0"), null, null, "Okey13@yahoo.com", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("94cbdd98-efc4-45d1-bd3d-b473dc89d70f"), null, null, "Etha.Parker25@yahoo.com", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("95063e6c-bed7-4df6-a5ed-50487ddf501f"), null, null, "Destiny18@yahoo.com", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("95503a48-df38-4a60-8323-5ed6dd1e68ae"), null, null, "Cayla_OReilly@gmail.com", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("95defcb7-57a5-422c-a86e-43a1df8b5366"), null, null, "Lou74@gmail.com", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("95fec67c-d53e-424c-b96f-1522076084d9"), null, null, "Eloise.Quitzon@hotmail.com", false, new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042") },
                    { new Guid("96204484-c658-4448-931f-feb0ff0c5657"), null, null, "Malinda_Koss3@gmail.com", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("96984ab7-792b-4032-9021-f66f623668fb"), null, null, "Sherman37@yahoo.com", false, new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f") },
                    { new Guid("96e68f4a-b641-476a-8164-20e65f7597f2"), null, null, "Laurence.Adams52@hotmail.com", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("97070db1-90ea-4dc8-b593-c46ce17ea7ae"), null, null, "Leatha83@yahoo.com", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("97819449-d87e-4528-bddf-4144a5304e9c"), null, null, "Dashawn_Rowe63@yahoo.com", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") },
                    { new Guid("9790465e-94f0-449c-9d01-e3df4edd950e"), null, null, "Fannie.Fay97@hotmail.com", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("97bf4e7e-02e9-4799-a215-f435169250e9"), null, null, "Amir_Parker94@hotmail.com", false, new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8") },
                    { new Guid("9866e853-4e59-4555-8be6-d0110db68634"), null, null, "Cletus14@yahoo.com", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("98e3ae40-28e2-46ac-9192-a6b10278cb96"), null, null, "Andre84@hotmail.com", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("9923cfaa-ec87-4ed5-94d9-61d737dcc765"), null, null, "Candice.Schultz@yahoo.com", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("993bc948-bfc2-4244-813c-8dd65a4fe58e"), null, null, "Cierra85@hotmail.com", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("99404c14-8b4d-4820-928d-0ace7feccf66"), null, null, "Shanelle_Nitzsche@yahoo.com", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("9a05dcef-f8c5-4627-b0c9-2724add4268d"), null, null, "Javier21@hotmail.com", false, new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2") },
                    { new Guid("9a062fe2-bb96-411f-b1ae-794ff7e81566"), null, null, "Kacie.Keebler@gmail.com", false, new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("9a8bd34b-1c50-4859-9e87-767a526e9d0b"), null, null, "Wendy_Blanda@gmail.com", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("9ae03e89-b84f-4456-a727-e6a9b60bceef"), null, null, "Cathy1@gmail.com", false, new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69") },
                    { new Guid("9aeccdf4-8330-4763-8347-3effb9a84479"), null, null, "Tomas.Leannon29@yahoo.com", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("9afe28a9-db42-4fd9-91ee-af59a0e952d7"), null, null, "Jules49@hotmail.com", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("9b74c31c-3fd4-4a87-b304-cf906e8cb756"), null, null, "Tara.Stark3@yahoo.com", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("9c4abac9-4142-4ca2-8fdb-5bc8a7b31c23"), null, null, "Alexandre_Marvin63@hotmail.com", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("9ca73339-a688-41db-b15c-70b6de5e8bce"), null, null, "Rosemary_Boyer@gmail.com", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("9caeedbe-df55-47d3-9092-ace2b4e16d9d"), null, null, "Clint56@gmail.com", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("9d474e5f-6bcd-4519-a6d9-dca2a779ddb0"), null, null, "Sophie.Gerlach51@yahoo.com", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("9dbb54c1-c1b5-4229-b5e3-e51a0e9cacc3"), null, null, "Francisco.Friesen@yahoo.com", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("9dc48a43-31c4-4ab1-a6ed-31235f7eb584"), null, null, "Rupert.Langworth67@gmail.com", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("9e0b03a4-07c5-4e4f-bc80-6169e795eb8b"), null, null, "Emmet_Ziemann0@gmail.com", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("9e3abf96-913e-404e-9b6f-8c88db1ce48e"), null, null, "Richard.Mayer93@hotmail.com", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("9e672e2a-ff69-4144-ade8-feeb501b5e53"), null, null, "Jillian45@yahoo.com", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("9ec3cabd-9658-469f-81c5-7991ded8519a"), null, null, "Elmore_Bergstrom69@gmail.com", false, new Guid("5f140f7e-803a-444d-8158-03815cbd832c") },
                    { new Guid("9ef5aa9b-b3e9-4e17-b6be-67c9562b8a2b"), null, null, "Amy.Morar24@gmail.com", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("9efa7cdb-b76d-4185-b579-89ccb96ec349"), null, null, "Zion_Abshire49@yahoo.com", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("9f2b5205-52ef-4313-995c-841810a34e0b"), null, null, "Trace_Kemmer50@yahoo.com", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("9fa4d39c-3aeb-4d28-a250-4f5c3c40466d"), null, null, "Koby.Bradtke76@hotmail.com", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("9fdf0f5d-aa99-4889-86aa-f598c8189ca3"), null, null, "Princess.McCullough@gmail.com", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("a0261261-bbfe-440f-8e74-c74da9874d8f"), null, null, "Litzy_Walter@gmail.com", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("a061caf3-ef78-4dba-b1e8-bcef4f99d0c8"), null, null, "Percy.Buckridge@hotmail.com", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("a067e7b6-d222-4374-999a-30feca5b3960"), null, null, "Jeramie.Steuber@hotmail.com", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("a09aa415-0b2b-4971-98bf-15af31e918f4"), null, null, "Leanne_Friesen71@yahoo.com", false, new Guid("4e8e0581-239d-4586-9cca-aad850d7d329") },
                    { new Guid("a117208d-2ef9-4f37-9def-2c55ff8b1a3a"), null, null, "Lisandro.Macejkovic@yahoo.com", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("a1279501-8b0a-474e-aa26-840c1907ff92"), null, null, "Dock93@yahoo.com", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("a13ee400-203f-43d2-8e60-5a286cad9d18"), null, null, "Mona.Johnson@gmail.com", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("a14a9914-bba5-40dd-acf1-c061f7db4f20"), null, null, "Magnolia64@hotmail.com", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("a17b79f3-5d96-452a-9b02-64fdaa8a4c64"), null, null, "Ayana.Lindgren@hotmail.com", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("a1d92101-4a56-4fd1-9906-f0c6a96fb9de"), null, null, "Darrion69@yahoo.com", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("a241f4f3-b363-4860-b634-ae410a167839"), null, null, "Kiel43@hotmail.com", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("a285a792-de8e-463e-8354-3058773731c2"), null, null, "Carrie76@hotmail.com", false, new Guid("9af47343-7f95-4006-8dea-4975912f5989") },
                    { new Guid("a2aa64cb-c982-4850-81e8-245184a83ca8"), null, null, "Anna_Moen@gmail.com", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("a300d9fd-e96e-4a24-81b8-c38ba9c3bbd5"), null, null, "Waldo.Lockman@yahoo.com", false, new Guid("223295f7-9195-4510-8bcc-44f043830497") },
                    { new Guid("a32e8928-f7a2-4249-b512-cc642cc77b5b"), null, null, "Gianni_Schinner60@yahoo.com", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("a3bd3711-7345-4274-acb4-6f74e2ffd722"), null, null, "Raul.Jones9@hotmail.com", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("a3cecb43-a51e-4079-921b-a586c73b8a50"), null, null, "Alize53@yahoo.com", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("a4e0666f-b59a-48ea-b538-2274ee4620f5"), null, null, "Nova.Wunsch@hotmail.com", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a533f4b0-3117-47e5-ac44-1b5409f6995b"), null, null, "Chaya0@hotmail.com", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("a5b2e47c-4e56-455f-ba6b-43744d30bbde"), null, null, "Foster63@yahoo.com", false, new Guid("9af47343-7f95-4006-8dea-4975912f5989") },
                    { new Guid("a5d1146d-38e7-492b-a03b-2cd97e0959e7"), null, null, "Glenna.Beatty7@hotmail.com", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("a5e0efe0-f1f6-46a6-9e91-e47f2be7a3ad"), null, null, "Mozelle_Powlowski@yahoo.com", false, new Guid("44736c29-d473-4b0c-9aca-5f9518cda391") },
                    { new Guid("a6468521-a004-4695-9e81-162d7aa91311"), null, null, "Camren44@gmail.com", false, new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f") },
                    { new Guid("a6c4c245-e97a-44de-97a1-926ebada2df1"), null, null, "Antonietta_Greenfelder42@gmail.com", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("a6cde2e2-fd88-41e7-b5c1-3c54d2e819f0"), null, null, "Mac.Pollich39@hotmail.com", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("a6d6bf70-44cc-4a55-a50c-b999039479f8"), null, null, "Rebeka90@hotmail.com", false, new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1") },
                    { new Guid("a7bd0e28-4bba-4561-acc4-d9ccfceed618"), null, null, "Leopoldo_Denesik38@hotmail.com", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("a7ce8385-09dd-4dc1-b709-ad95f89c855f"), null, null, "Brennon.Macejkovic@gmail.com", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("a822ca39-9022-469c-ade7-a3c6e43903f0"), null, null, "Candido_Wiegand45@hotmail.com", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("a836add6-476b-4f00-9bce-d5f12e315920"), null, null, "Dahlia_DuBuque26@hotmail.com", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("a86f8376-52f1-453f-9dec-1bbd1cfd485f"), null, null, "Margarete57@yahoo.com", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("a8777b5b-06f4-4428-87e9-a610eca1340f"), null, null, "Lura.Jenkins@gmail.com", false, new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8") },
                    { new Guid("a8df9ca1-ebf0-468b-bd56-cdf21e524eb9"), null, null, "Geo56@hotmail.com", false, new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce") },
                    { new Guid("a958ae2f-50fc-432c-b5ff-a8307eb40d0f"), null, null, "Avis39@yahoo.com", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("a9839d7f-3c1f-4714-99c0-063745af49ee"), null, null, "Randy_Rice@hotmail.com", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("a9d7fc0d-5119-4653-a425-b5aa9f388752"), null, null, "Parker_Pagac3@yahoo.com", false, new Guid("eea73942-2019-41c4-9063-ab64deb92300") },
                    { new Guid("aa815c77-d929-4c7c-860f-d37a733fb7cd"), null, null, "Jermaine.Smith@gmail.com", false, new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1") },
                    { new Guid("aa89865a-1523-44d5-be65-1425d6e09567"), null, null, "Madelynn.Jaskolski@hotmail.com", false, new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20") },
                    { new Guid("aa902d07-12f3-4f82-b2ea-aea98c1f782a"), null, null, "Jarrett55@yahoo.com", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("aaa32444-b4b8-4d00-a2aa-47fa39c6e078"), null, null, "Ashtyn.Batz@hotmail.com", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("ab1de3d0-fd8d-46cf-9601-3b3d596dbacb"), null, null, "Jaylan.Connelly@hotmail.com", false, new Guid("95f06adb-a1fa-40bc-8351-b298d818044d") },
                    { new Guid("ab249b7d-2094-4841-be7f-3a8f65d2884f"), null, null, "Rylee51@yahoo.com", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("ab6cd925-a029-4671-8064-0e29f84dc843"), null, null, "Thea.Connelly65@gmail.com", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("ab96d2ec-cd91-4779-88e5-86c33f3ee69d"), null, null, "Kali_Schulist@yahoo.com", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("abb4be10-c0a0-478a-aacb-6c99a50dba3a"), null, null, "Cristobal.Bahringer@gmail.com", false, new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5") },
                    { new Guid("abbe5b9f-cceb-4c74-bf91-9439e3969cea"), null, null, "Gerry74@yahoo.com", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("abef6b53-b38c-4505-ad90-d8166df6eda1"), null, null, "Kamron_Doyle@gmail.com", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("ac0f444a-3b5c-43cd-aea9-9ae454572443"), null, null, "Mallory_Gulgowski92@yahoo.com", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("ac19bbdf-6b75-415b-8e1a-eab141347578"), null, null, "Brody.Fadel@gmail.com", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("ac7e2dfb-fe1d-489f-bc44-36ccf52ad01b"), null, null, "Gina37@hotmail.com", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("ac9eea41-437d-4263-b00c-af36daab6e30"), null, null, "Trinity31@yahoo.com", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("aca1deb4-876e-4f82-af38-7bf9388cb1de"), null, null, "Camille_Greenfelder8@hotmail.com", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("ad5a1c5c-4075-4a3d-9115-39179179ff05"), null, null, "Arthur.Muller67@yahoo.com", false, new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e") },
                    { new Guid("ad982268-2e02-411b-aa64-01d641d4c861"), null, null, "Theodora_Shields@gmail.com", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("add8c7e4-ae34-433c-96ca-0bf4bbdc7648"), null, null, "Gerald_Lang8@yahoo.com", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("adf3df6b-ff63-4e7d-a2df-d295ff5077c9"), null, null, "Joe.Harber76@hotmail.com", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("ae550c76-3db3-42d4-a140-5da557f899d3"), null, null, "Israel_Bashirian42@yahoo.com", false, new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3") },
                    { new Guid("ae61a0f6-5cb0-4eaf-88bb-7137c97a6e20"), null, null, "Etha.Shanahan@hotmail.com", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("aed8c54d-c977-4a6a-b402-d4fb691e6472"), null, null, "Zelma15@hotmail.com", false, new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a") },
                    { new Guid("aef64361-cc96-489d-bd51-241d9ee55680"), null, null, "Athena.Murazik27@hotmail.com", false, new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("af06d2ec-577a-4ab6-8ff5-7359a37060ea"), null, null, "Johnson.Gleichner7@gmail.com", false, new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694") },
                    { new Guid("af607c41-82ed-400d-9dd0-6aa85b8b3672"), null, null, "Drew_Feil0@yahoo.com", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("af753543-8ac9-4252-ad05-b6b35a5dc7d6"), null, null, "Caroline_Zieme66@hotmail.com", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("af9764fb-4bd6-4805-bf04-a823871a0b5a"), null, null, "Oscar_Mertz44@hotmail.com", false, new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056") },
                    { new Guid("b005d51f-8d5c-4f6f-8d86-599cbc1ad6a5"), null, null, "Andreanne72@yahoo.com", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("b00b7ac4-9e6e-4541-bdaf-88dfa1970b7d"), null, null, "Joey34@gmail.com", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("b0e1c57d-669d-4977-a90c-0cc5c4489bed"), null, null, "Jovani_Russel85@yahoo.com", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("b1326cde-cc71-4f37-81b2-fe5dc26ab41f"), null, null, "Jonathan18@gmail.com", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("b18b0177-a009-4601-82fd-b4ec1d82cfb9"), null, null, "Vicky52@gmail.com", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("b19e95ca-20a6-4df2-94e5-6c9d7133ea51"), null, null, "Rod.Upton@gmail.com", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("b1f491f3-8c7f-4cc8-9fa5-0d155464b97b"), null, null, "Jacques90@hotmail.com", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("b2d70e84-b644-400b-b9c1-aea2c6d967ac"), null, null, "Brionna31@hotmail.com", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("b2fdecd9-82b7-4c7f-af3e-b8a75fa1fa3b"), null, null, "Claudie_Bahringer23@hotmail.com", false, new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2") },
                    { new Guid("b3123394-7a15-4943-afd0-74e9a714dc1a"), null, null, "Dorothea_Barton@yahoo.com", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("b35c61f3-5c2e-4f9c-b5af-5154ff1bbaec"), null, null, "Gretchen29@gmail.com", false, new Guid("8c396faa-ad98-400d-a562-77b4902806e1") },
                    { new Guid("b375a3ee-5f61-4ab9-9184-ed6fec468385"), null, null, "Ethelyn46@gmail.com", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("b40303c5-65dc-44a9-9ab6-5f68cda678a9"), null, null, "Oral_Schamberger31@gmail.com", false, new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("b4de4bdc-b10f-46a6-934e-28bd7c116015"), null, null, "Sabryna_Gulgowski@yahoo.com", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("b590d8fd-7da5-4fc5-b13b-abc5a4465090"), null, null, "Hal.OHara72@yahoo.com", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("b5f754da-e4ba-4e81-b589-1350b70b0365"), null, null, "Denis6@gmail.com", false, new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") },
                    { new Guid("b6186220-bddd-4dbd-9e7e-5b0936dd67d5"), null, null, "Manuel_Mills43@hotmail.com", false, new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483") },
                    { new Guid("b6685c92-1177-4b88-ad95-34a3c273a812"), null, null, "Tod_Spencer81@gmail.com", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("b6c4f8bd-fbbd-465e-841b-ddf87aa65a7f"), null, null, "Remington.Hagenes@gmail.com", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("b6e6f69c-9e2f-426d-998a-20c1bfeba541"), null, null, "Garnett82@hotmail.com", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("b7252fcb-4794-45ec-aaae-9d5d3f47d85c"), null, null, "Helen_Christiansen2@gmail.com", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("b77fa74a-9ee4-4428-8cd1-7287234c881c"), null, null, "Ezekiel_Moore76@gmail.com", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("b7ff8d66-9888-4997-a911-fd6a816ada6c"), null, null, "Jalyn94@hotmail.com", false, new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a") },
                    { new Guid("b804daea-e431-4fc3-b1f9-ebf9b1023bf1"), null, null, "Reba.Crona50@hotmail.com", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("b8390002-0d32-4f5d-a1d4-a34a67b7840f"), null, null, "Susana.Dibbert2@hotmail.com", false, new Guid("ceb699bd-8c01-4831-9438-e8c30f353919") },
                    { new Guid("b90bd0c2-1e93-4773-8611-cbd1ddacebda"), null, null, "Vanessa.Crooks8@gmail.com", false, new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("b9924641-e159-4dfb-8360-69ce7c08f98b"), null, null, "Joe_Fahey@hotmail.com", false, new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f") },
                    { new Guid("b9e5bb13-580b-4d68-9d99-1eea4fb5237c"), null, null, "Nelle_Dooley29@gmail.com", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("bb191a4e-4e0d-4950-b026-13fafff53b68"), null, null, "Ole_Schimmel84@gmail.com", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("bb5f53ef-f2c9-4671-b7a9-4a45931e409f"), null, null, "Emma79@gmail.com", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("bb69a650-53f4-4968-a2cf-dc11ec0e81f6"), null, null, "Gabriel_Renner@hotmail.com", false, new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb") },
                    { new Guid("bb9c0223-5bf2-4fc4-859d-f9a0b66ff873"), null, null, "Lon_Okuneva@hotmail.com", false, new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d") },
                    { new Guid("bbb00d12-74ab-4873-af44-ae1a5057994a"), null, null, "Cayla97@yahoo.com", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("bbbd5754-c867-466f-89fd-23f09a5de7dd"), null, null, "Maureen_Renner82@hotmail.com", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("bbf7b15a-34df-46f9-b57e-741d343eaa42"), null, null, "Jovanny.Schimmel90@gmail.com", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("bc1c6db9-1446-4dcb-b47e-3aa2db1fcde7"), null, null, "Felicity70@hotmail.com", false, new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888") },
                    { new Guid("bd2f912e-537c-4608-9c7a-2777a25e766e"), null, null, "Chloe42@hotmail.com", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("be311343-c40c-4b27-9055-e81f4c7653fc"), null, null, "Horacio22@gmail.com", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("bec672d9-3122-41a3-9bfd-c2e918ac6c5a"), null, null, "Shaina59@yahoo.com", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("bf5fc2ff-7671-4e13-b167-4c43ca12ad1a"), null, null, "Lou.Heathcote89@gmail.com", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("c006d9b2-e195-43a0-8f74-7146ae640f49"), null, null, "Holden.Steuber60@hotmail.com", false, new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("c04413de-77c6-4e74-8810-dce3296b31ff"), null, null, "Samir78@yahoo.com", false, new Guid("0ec20584-d26f-41c4-b682-05916743e30a") },
                    { new Guid("c0c18b05-25e9-400d-9a47-86799e42a886"), null, null, "Aurelia.Keeling@gmail.com", false, new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6") },
                    { new Guid("c0d82a2f-9dfc-45be-93b8-b26d3ecb67da"), null, null, "Kenna22@hotmail.com", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("c1600d6f-117e-4943-b400-15880b0fc555"), null, null, "Winona_Weber@yahoo.com", false, new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7") },
                    { new Guid("c1bab6d5-aa8a-43ab-910e-2c62d77a7668"), null, null, "Evangeline.Rath82@yahoo.com", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("c2b12bb0-f94a-48b6-aedc-63002348f2da"), null, null, "Kelsi51@hotmail.com", false, new Guid("223295f7-9195-4510-8bcc-44f043830497") },
                    { new Guid("c2fd136d-789c-486e-ab39-4a7d4db5be63"), null, null, "Marlee_Wiza@gmail.com", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("c3878485-db0e-4795-8269-291ba34079cf"), null, null, "Eleanore_Blanda36@hotmail.com", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("c3a1d32c-ed29-4721-8abb-fb44a29dc1de"), null, null, "Penelope22@gmail.com", false, new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483") },
                    { new Guid("c3ef585a-8b80-48aa-bd5a-ccadb91da143"), null, null, "Erna_Senger35@gmail.com", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("c3f7d28f-07e1-4957-b09a-e9604b8bba6b"), null, null, "Pete.Schumm@gmail.com", false, new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4") },
                    { new Guid("c4232732-83f9-40d5-a0a8-fcfd06509408"), null, null, "Felton.Nikolaus@gmail.com", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("c427bea2-16b8-48dc-97a5-9a30a19e43c1"), null, null, "Garrick.Fisher@gmail.com", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("c4471584-3362-4452-b4c9-6f42e02ae981"), null, null, "Magnus.Schmeler@hotmail.com", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("c46881a4-61ab-4c73-937a-0d6d012cab70"), null, null, "Adrienne.Balistreri26@yahoo.com", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("c474fbc3-ca44-4364-8fb6-51d7d241dd7c"), null, null, "Terry_Bergstrom85@gmail.com", false, new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f") },
                    { new Guid("c48cc0d6-87f4-44f5-bf19-0dd2ccfee736"), null, null, "Marcia73@yahoo.com", false, new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("c4ab8725-9693-45fe-b17c-202797986200"), null, null, "Johann.Tremblay@gmail.com", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("c500bc6d-9a69-437c-a53c-8ed0877a064b"), null, null, "Jamil31@gmail.com", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("c552d989-9608-4ff4-ad83-5ec6b62b6a33"), null, null, "Deborah.Bednar34@hotmail.com", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("c554099f-c174-4e83-bae5-ae14a0072c3f"), null, null, "Adriel_Fisher@hotmail.com", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("c56e0f54-f94e-4fa2-914f-a972c6c1ff8f"), null, null, "Mazie6@yahoo.com", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("c56ea271-5557-4b0c-8e34-d4bcea3798c0"), null, null, "Gwen.Reichert36@hotmail.com", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("c5966169-dcf5-422c-9758-cdc547ef09d4"), null, null, "Jillian.Hartmann30@gmail.com", false, new Guid("99f374c8-d976-4051-99c3-7305e5fea09d") },
                    { new Guid("c656b325-4586-41c8-95a1-123553813f7b"), null, null, "Margie.Sanford65@gmail.com", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("c66d7164-fc9d-46ac-9e57-cae4c5948777"), null, null, "Samir_Cummings@yahoo.com", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("c672e170-1747-4b88-85f4-f32acd27eb1a"), null, null, "Carlos48@yahoo.com", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("c67e9d77-a564-4420-9557-0baf6eda3850"), null, null, "Marilie.Ledner@gmail.com", false, new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5") },
                    { new Guid("c6a52ca5-b084-48cf-9314-70dcbc55664c"), null, null, "Jadon17@gmail.com", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("c6ad3345-a13a-4eff-aee4-7291e4e3158e"), null, null, "Lucie79@hotmail.com", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("c761a404-afe9-4900-ace6-c365c5077d53"), null, null, "Janessa.Lakin@gmail.com", false, new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644") },
                    { new Guid("c76c1817-4a45-4055-a2f3-74be00c508e9"), null, null, "Rosina.Ziemann42@gmail.com", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("c7c5a79b-5e96-4d7e-868c-4956768f0642"), null, null, "Clarabelle_Crist22@hotmail.com", false, new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6") },
                    { new Guid("c7db26d0-2792-46b8-9cdb-d47b22ed1b5f"), null, null, "Liana_Vandervort13@gmail.com", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("c879dbc6-a0b9-4255-be40-02ff531284b6"), null, null, "Mylene.Koelpin51@hotmail.com", false, new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a") },
                    { new Guid("c8e22544-f7e4-4b8a-a799-4cda14b9fe13"), null, null, "Furman13@hotmail.com", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("c8ed28c7-5339-4afc-a368-552030f87dbe"), null, null, "Lia19@yahoo.com", false, new Guid("77941635-e388-4774-9d8a-53d61f8a1c10") },
                    { new Guid("c906df7e-1547-49e5-8fce-59053286c09f"), null, null, "Alejandrin.Sporer@yahoo.com", false, new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab") },
                    { new Guid("c9307498-2339-4baa-9b17-0b50af6b4eb8"), null, null, "Aiden18@yahoo.com", false, new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c9ae26c7-45b6-46c2-bb9f-ab6278833db8"), null, null, "Lina.Ziemann@gmail.com", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("caca7d3b-8ca5-4e61-9ed1-1df36bd7f1a0"), null, null, "Reuben32@gmail.com", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("cb5cf938-23b7-4a49-bb2d-bfa9752f64ac"), null, null, "Akeem.Skiles30@gmail.com", false, new Guid("9bea6011-9948-451d-9195-7c4cc4339cba") },
                    { new Guid("cb9961f0-9d71-4ad8-b65d-67c6bb3b4b53"), null, null, "Ibrahim33@yahoo.com", false, new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042") },
                    { new Guid("cc4c3525-0aca-4810-92aa-1676f8b46c23"), null, null, "Yolanda29@yahoo.com", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("cc5083b7-2b7c-408b-8b72-849a32016210"), null, null, "Lizzie36@gmail.com", false, new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f") },
                    { new Guid("ccc4657e-1c23-491e-a366-eeb4ec6c9b52"), null, null, "Russ.Hoppe44@gmail.com", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("cd67a2b0-7ec7-4bfe-872a-18925a6e2a1d"), null, null, "Skylar.Fadel@gmail.com", false, new Guid("57710136-3092-497c-8523-6e222848ceaf") },
                    { new Guid("cd887d55-aea9-4a1e-9b8b-d33ed4c2b432"), null, null, "Elisha.Towne13@hotmail.com", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("cd94d555-d05a-4805-92bc-7ea27f5269e0"), null, null, "Vena.Bode15@gmail.com", false, new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8") },
                    { new Guid("cda656a2-5cbb-4042-8b9d-208060e035fe"), null, null, "Kellie12@yahoo.com", false, new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9") },
                    { new Guid("cde61db2-0aae-41be-973f-b2dbf751526a"), null, null, "Maurine_Schmeler32@yahoo.com", false, new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("cdea6ce4-cff0-4ddf-b5f4-da0d16fbf3f7"), null, null, "Gussie.Kozey@hotmail.com", false, new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("ceda9508-f6f3-485b-907e-c58583337c0e"), null, null, "Beverly.Douglas61@yahoo.com", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("cf04484a-bf0e-4bfd-b899-eae8f77e7bce"), null, null, "Zoey_Larson@hotmail.com", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("cf6099a6-bfae-45ac-ac62-4fc97f53812c"), null, null, "Alex_Ondricka@hotmail.com", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("cfa60f29-1286-4027-8002-e06b0ff2b0df"), null, null, "Casper_Koelpin34@hotmail.com", false, new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a") },
                    { new Guid("d0122e33-70a5-424c-abb7-d178f9722082"), null, null, "Elwyn32@hotmail.com", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("d03758e7-49b1-413e-a379-ae74f5506444"), null, null, "Reid.Kub24@hotmail.com", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("d04fab37-c06b-415d-bae9-e5b67ca78ec8"), null, null, "Phyllis.Ernser42@hotmail.com", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("d0b3c60d-c211-4e63-a5ca-0e4630e11859"), null, null, "Thelma18@yahoo.com", false, new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("d0be72dd-0310-4b32-b1e3-1c43a28e5ace"), null, null, "Danny_Kub21@yahoo.com", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("d14d9042-f8b6-421e-91d7-36f6eb9d91e5"), null, null, "Margret_Ferry51@gmail.com", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("d1662367-77ff-4eeb-a593-899219f9594b"), null, null, "Eliane_Bergstrom74@gmail.com", false, new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5") },
                    { new Guid("d17130c1-ba1a-4ee4-9415-5f208e1e2c90"), null, null, "Ceasar_Farrell@hotmail.com", false, new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6") },
                    { new Guid("d1f024b5-4d42-4617-830e-9b961432a2f4"), null, null, "Jaleel30@gmail.com", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("d1f1a731-801b-47b1-b57d-c85eca8ab7d0"), null, null, "Tremayne81@gmail.com", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("d262addd-dadc-471b-8e6c-3c785c71639e"), null, null, "Wilma_Metz30@yahoo.com", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("d29455d1-0ca0-4f4f-8992-0bdeec024c4c"), null, null, "Darrin.Romaguera@yahoo.com", false, new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4") },
                    { new Guid("d2d9ba8d-3203-4106-b9da-5dc602f80a7e"), null, null, "Brennon.Schoen@gmail.com", false, new Guid("77941635-e388-4774-9d8a-53d61f8a1c10") },
                    { new Guid("d2f14f45-82fd-4f54-8190-389ce2a7ff90"), null, null, "Robin_Marvin35@yahoo.com", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("d324e404-7d1c-4145-ae11-dcf0c184f6f3"), null, null, "Sean_Bailey@hotmail.com", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("d3765160-deca-44dc-813c-b734dad09bef"), null, null, "Sarina_Swaniawski@hotmail.com", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("d4c813f8-e80e-4d62-b457-26ffb911b073"), null, null, "Jessie56@gmail.com", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("d4dc6ee5-32a8-424a-a3c5-fd07d36b2cfa"), null, null, "Nicolette_Schmitt@hotmail.com", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("d4ee40d1-1f97-4f27-a2ea-a326a008993e"), null, null, "Allen6@gmail.com", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("d4eebebc-19fe-4daf-9bea-b1d67788cfe1"), null, null, "Nelson_Collier@yahoo.com", false, new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86") },
                    { new Guid("d50b14cc-b748-4166-8e81-9afe0bffb8ca"), null, null, "Melany17@hotmail.com", false, new Guid("0ec20584-d26f-41c4-b682-05916743e30a") },
                    { new Guid("d566891c-f7a0-4cfb-bd2f-33dd817fb947"), null, null, "Diana_Witting@gmail.com", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("d5ef18f5-2df3-4490-9150-7915ce8d623d"), null, null, "Mattie52@hotmail.com", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("d62ef4b1-30e8-4dbf-825b-8ce021e07a67"), null, null, "Kiley46@gmail.com", false, new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640") },
                    { new Guid("d64e849a-c80f-4081-b5e3-42c6612e877d"), null, null, "Daphney_Jast16@yahoo.com", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d65acd9b-5bcb-440b-9a82-cf872621d6fe"), null, null, "Torrey9@hotmail.com", false, new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") },
                    { new Guid("d65d12ea-36be-407d-bae3-0dce912bf18a"), null, null, "Marc15@yahoo.com", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("d74af56a-04b6-4f91-a392-82d1bcc43ac6"), null, null, "Wyman_Stroman@yahoo.com", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("d8392de6-8fe9-43a5-8538-7a9115a91b60"), null, null, "Coleman.Reichert@gmail.com", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("d83c299a-7adb-4eb1-a412-928526517d8b"), null, null, "Jamie_Heathcote@hotmail.com", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("d90e6338-ada8-45a4-a0eb-8281b3195a0c"), null, null, "Abelardo.Beer61@yahoo.com", false, new Guid("4e8e0581-239d-4586-9cca-aad850d7d329") },
                    { new Guid("d9245c7d-3e21-40f9-894c-361a01371775"), null, null, "Arthur.Konopelski87@gmail.com", false, new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3") },
                    { new Guid("d983c40f-6247-4108-86ed-738dfd72f9fd"), null, null, "Fern_Pollich@yahoo.com", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("d99fd8f3-3c72-4fcb-bd17-8dc67ebbf517"), null, null, "Clair_Oberbrunner@yahoo.com", false, new Guid("97253083-0ecd-4730-b815-c4b8137ab125") },
                    { new Guid("da55f24d-c118-4806-ad5d-42fceb7b0782"), null, null, "Leonard.Turcotte@gmail.com", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("db7d2815-5cc9-4e8f-9dcb-0d18c753d395"), null, null, "Judah_Pfannerstill@yahoo.com", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("db888411-3050-4eaa-a254-2cd3b546b555"), null, null, "Eunice9@yahoo.com", false, new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") },
                    { new Guid("dba5ab31-5dd1-40c2-9eaa-caff591db79c"), null, null, "Rosalee.Hagenes@gmail.com", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("dbc44294-8129-42bd-9163-c58c06e0b863"), null, null, "Connor.Wilkinson@yahoo.com", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("dc61fddf-dc91-4f9b-9ae4-dbe60c215813"), null, null, "Rodrick.Gerhold65@gmail.com", false, new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b") },
                    { new Guid("dc7b43ea-51a0-41af-97dc-7a47c057c333"), null, null, "Lempi.Cartwright@gmail.com", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("dca06404-2ee7-4ce8-bf16-89bee2c8cb55"), null, null, "Bailee9@gmail.com", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("dce08efc-0ebf-4e60-915c-5452032708f7"), null, null, "Arne3@yahoo.com", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("dce397da-a3e0-4d27-b2da-31f2edf1aa22"), null, null, "Helena.Schroeder@yahoo.com", false, new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc") },
                    { new Guid("dd15c107-b36e-4210-be5f-06887e2ef752"), null, null, "Tanya_Fisher@hotmail.com", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") },
                    { new Guid("dd69eb92-d2ff-46a4-9777-71d69b8ff0a0"), null, null, "Jeramie_Lockman21@gmail.com", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("dd90a443-2a8a-4eb1-906e-352400f5276a"), null, null, "Ahmad.OKon@gmail.com", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("ddd638dd-c276-4906-b9a4-18ea26727653"), null, null, "Myrtice24@hotmail.com", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("de0e67e6-d528-449d-a63d-10edcd7c85f9"), null, null, "Letitia_Hoeger23@hotmail.com", false, new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f") },
                    { new Guid("debdcc75-384c-4fc8-b1a9-8ea8107eedd3"), null, null, "Velda_Sawayn75@gmail.com", false, new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888") },
                    { new Guid("df29dc0f-f32f-4224-86ce-43e9d9ab12cc"), null, null, "Daren41@hotmail.com", false, new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a") },
                    { new Guid("df2b55cf-5777-4c87-8722-59572305baff"), null, null, "Pearl18@hotmail.com", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("df3ec3c4-06a8-4ead-af8a-e2937bb290c6"), null, null, "Kari.Lehner@yahoo.com", false, new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2") },
                    { new Guid("df687d2d-106b-4d5a-b485-01a2dcec8b75"), null, null, "Retta_Zboncak98@yahoo.com", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("e064f2b7-0ec7-4486-bde2-4eda2a1e99af"), null, null, "Heath.Hessel84@gmail.com", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("e09b3210-20df-4ff5-a47b-0b11aaee9a04"), null, null, "Juston.Hyatt9@yahoo.com", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("e0e3e94f-a7da-45b2-9486-dd38f2a0a926"), null, null, "Michel72@yahoo.com", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("e1528e0f-76a5-404e-9dc2-1879d09129e5"), null, null, "Kariane_Torphy@yahoo.com", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("e1ad25dd-c212-4628-b87e-348351b16700"), null, null, "Sonia.Goldner@gmail.com", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("e1fa1754-0580-4619-8821-7b0b15e7def1"), null, null, "Arielle_Wilderman@yahoo.com", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("e22ee6bd-ff9c-4d74-85a8-87805002f22a"), null, null, "Destinee.Cassin25@gmail.com", false, new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("e24f1c1c-3ea8-48b2-80c2-a31597fbb727"), null, null, "Dean.Marquardt@yahoo.com", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("e25516f5-3637-4c5c-a0f9-8fbbaa2c0fa6"), null, null, "Haley.Collier@hotmail.com", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("e3480f89-fa20-4c56-881b-f250fd63e62d"), null, null, "Samir_Renner@gmail.com", false, new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1") },
                    { new Guid("e36ce77a-c60f-48b6-9ef0-f3b7186a651f"), null, null, "Landen_McClure@yahoo.com", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("e3fead1a-509a-42ce-8f6f-56841b52a229"), null, null, "Delmer.Christiansen55@gmail.com", false, new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694") },
                    { new Guid("e435199f-765d-4029-a021-3fa41d7c57b4"), null, null, "Patsy28@hotmail.com", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e4858407-7b0b-4e14-a326-36f9bc2f69c5"), null, null, "Sarah55@gmail.com", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("e4f437c7-2759-4c13-bdf8-5263730529bd"), null, null, "Henry_Greenholt@yahoo.com", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("e50e7c11-2233-4650-9d14-0aadf5f31cf1"), null, null, "Liana98@hotmail.com", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("e5824c8c-a800-43c7-ab32-91b1d6d59226"), null, null, "Richard_Sporer46@yahoo.com", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("e596d3b8-0aff-4ae4-bf82-fcf888166afa"), null, null, "Name_Shields67@gmail.com", false, new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2") },
                    { new Guid("e5ace866-cf30-49b3-b0c8-43b7eec002e1"), null, null, "Lazaro94@yahoo.com", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("e5c5307c-1da1-4858-a182-2642f5a67ea4"), null, null, "Mariane.Flatley@gmail.com", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("e5c5b306-7288-4248-a994-22e61bf60351"), null, null, "Suzanne.Homenick@hotmail.com", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("e60c80d2-b5bc-4bf4-83ba-083105bc258d"), null, null, "Angelita_Nicolas58@hotmail.com", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("e672678e-2b61-432e-9a22-77a7f6a99bf6"), null, null, "Briana49@yahoo.com", false, new Guid("76807668-f1d2-47ed-a084-0771d51bc761") },
                    { new Guid("e69abc41-7c98-4b68-9f1b-c62412558c48"), null, null, "Roberta.Glover50@gmail.com", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("e6a59da4-b083-47c4-b87a-0c74baace765"), null, null, "Makenzie.Smith@hotmail.com", false, new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed") },
                    { new Guid("e6aef3d0-2b15-4946-ade8-f08bebb28c25"), null, null, "Antwan61@yahoo.com", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("e71efc01-c01f-4ef2-aed6-d1de75f860f8"), null, null, "Kelsi48@gmail.com", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("e72f820d-1f87-47cc-ab0b-79f430e86482"), null, null, "Anabelle18@hotmail.com", false, new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") },
                    { new Guid("e76b94a2-63e5-4f78-84b9-b536a32bfe68"), null, null, "Jerrod72@gmail.com", false, new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5") },
                    { new Guid("e7994079-05ef-4691-af16-fc5a881da993"), null, null, "Helen_Price@hotmail.com", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("e8c88fb9-bd10-45ca-9345-c0eec92ac154"), null, null, "Randi_OHara@yahoo.com", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("e8f37133-a6e0-4cc5-b5f2-592c922d110b"), null, null, "Garnett_Russel32@yahoo.com", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("e90f59fa-448d-4352-b9ca-fdc6f44692dd"), null, null, "Lon.Haag@yahoo.com", false, new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda") },
                    { new Guid("e919bec3-bdc6-4fd5-bc2e-6045bd2a4cc3"), null, null, "Grayce4@yahoo.com", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("e939345d-0076-4b50-82c1-69202efeecfd"), null, null, "Marcel_Mante@yahoo.com", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("e98d967e-cb8d-441a-b091-5a8b624644ca"), null, null, "Julien.Langworth@gmail.com", false, new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a") },
                    { new Guid("e98e6ad6-ecc2-4388-ab12-e9b93936be3a"), null, null, "Laurence0@yahoo.com", false, new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f") },
                    { new Guid("ea8680a0-c276-4a8f-95ef-de527d6f7892"), null, null, "Lily44@hotmail.com", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("eab1d48d-a41a-45b8-9e48-dbd6ed9ec4fc"), null, null, "Emelia.Bradtke@yahoo.com", false, new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1") },
                    { new Guid("eafd9b3a-fad4-4d78-9e95-900e105c1a75"), null, null, "Hayden70@hotmail.com", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("eb037900-37c1-4762-a77d-f2d362f4b00f"), null, null, "Shyann.Reichel23@hotmail.com", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("eb0b9a8a-b679-4808-9ec3-b9025a7ad84f"), null, null, "Geovany_Okuneva@yahoo.com", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("eb9b9ac7-b03b-4c43-931e-54a8769260a2"), null, null, "Lisette.Ferry@hotmail.com", false, new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a") },
                    { new Guid("ecda0452-3f59-415f-9b9b-6bdc0127511e"), null, null, "Aliya45@hotmail.com", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("ed2399a2-63c5-4d10-92cb-764de602c482"), null, null, "Hilma.Friesen42@yahoo.com", false, new Guid("072b74c5-5e1d-46de-9caa-66d36218f554") },
                    { new Guid("ed6726cf-ca28-4f00-85e5-d70fef4dee88"), null, null, "Larissa42@yahoo.com", false, new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("ed7e01e6-1949-41d8-96ae-3894aa4f83ab"), null, null, "Hildegard.McLaughlin20@hotmail.com", false, new Guid("8c396faa-ad98-400d-a562-77b4902806e1") },
                    { new Guid("ed9acada-2cc8-4c5a-bdaa-ed24fb79e9d8"), null, null, "Jimmie98@hotmail.com", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("edcc28a6-7bb3-4967-856f-bc68a30fc515"), null, null, "Buford_Kovacek@gmail.com", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("ee4f8f45-412a-43a8-9321-6557945b526c"), null, null, "Jane.Schinner@yahoo.com", false, new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803") },
                    { new Guid("ee593899-2577-4f81-b0f8-7c94de74c157"), null, null, "Keaton35@gmail.com", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("ee7419d8-2cf3-45db-9e05-5648b1966fc8"), null, null, "Ernesto_Wunsch58@hotmail.com", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("ef5a08a3-40c8-409b-b15e-2f618b4c75b2"), null, null, "Trent.Predovic@yahoo.com", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("ef83610a-672d-4bb4-980c-99e8ab34941e"), null, null, "Bryon58@gmail.com", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("ef91360f-524b-4a6e-ad44-f6f8cf03c65f"), null, null, "April.Grimes62@hotmail.com", false, new Guid("70409336-0f26-4108-8c79-213e320c07f7") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("efd47fae-47da-449c-8eff-97c857d814e4"), null, null, "Eloisa_Lesch38@gmail.com", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("f07300a9-52ea-4013-bb3f-94582ccb2d87"), null, null, "Maida.Toy@gmail.com", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("f074c0b7-4246-4502-97c5-b987f44e5a53"), null, null, "Pascale.DuBuque@yahoo.com", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("f113c5ac-31f0-49e3-8a7e-9922c5eee031"), null, null, "Cornell50@hotmail.com", false, new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1") },
                    { new Guid("f13921e6-dfc7-4cd5-886e-8a8c4f04ecd7"), null, null, "Verlie.Spinka@hotmail.com", false, new Guid("ad755590-668c-421d-994e-b7a783d9dcd5") },
                    { new Guid("f15a28b3-eace-42ff-93d5-8f27f9ab54f8"), null, null, "Jesse.Metz@hotmail.com", false, new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4") },
                    { new Guid("f3915d6c-eb5b-4c15-b385-f5fe7ef4ad94"), null, null, "Jedidiah_Grant28@yahoo.com", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("f3923524-f6c1-45a6-8a4f-a35f0159d199"), null, null, "Margot.Crooks86@gmail.com", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("f3e6431c-666a-43ba-bc7d-06464e8094ec"), null, null, "Jeromy22@hotmail.com", false, new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc") },
                    { new Guid("f524b1b4-fedb-48eb-bf58-89ac799b9c99"), null, null, "Vella_Kiehn@gmail.com", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("f579332b-0e57-47ca-9c4a-e307ad0a3cbf"), null, null, "Nicolas_Emard@gmail.com", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("f584fcd7-559b-4fb3-97b5-81a76b5410ae"), null, null, "Ernestine.Prosacco33@gmail.com", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("f61c195b-d603-48e3-808d-6300ef483398"), null, null, "Cleve.Murray@yahoo.com", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("f6a51a6a-1cf0-4999-9f4c-1c9eb28298fb"), null, null, "Blair_Braun15@yahoo.com", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("f6b56ad5-40b7-4ec1-83cc-5fc99d3e4491"), null, null, "Delilah.Kozey57@gmail.com", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("f6d11ddf-2bf7-4505-8405-bb1512e4fc96"), null, null, "Frederick_Bednar@yahoo.com", false, new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2") },
                    { new Guid("f6e44b4f-dd0c-4586-ab53-9a9e5f74293b"), null, null, "Hillard68@gmail.com", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("f7d998f4-ed5b-47bf-8bab-3a265d768bd9"), null, null, "Clint.Thompson@yahoo.com", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("f80245b0-66b8-445b-8a94-6841cab23dd3"), null, null, "Rogers.Marvin10@hotmail.com", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("f86fb7c6-2b21-4fee-9722-92cbbc4b8926"), null, null, "Rosemarie.Senger@hotmail.com", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("f895e789-f8ac-4d57-a1ce-80a27a2f777a"), null, null, "Fermin_Douglas33@gmail.com", false, new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756") },
                    { new Guid("f89c93ed-78b5-4449-87ae-96939f912596"), null, null, "Jaycee_Tillman@yahoo.com", false, new Guid("26db4c52-c906-415a-848e-eb60cadca362") },
                    { new Guid("fa16ed72-fbcc-4b3f-b2d6-d1ace189a9fb"), null, null, "Dashawn_Nitzsche@gmail.com", false, new Guid("c8507284-511b-425f-9aab-13ef42992af5") },
                    { new Guid("fa4b01f1-d315-4b33-8826-7fd823e4f15a"), null, null, "Ava_Jacobs@hotmail.com", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("faad9347-ca69-4d4e-905a-02dc148c555f"), null, null, "Santino67@yahoo.com", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("fb500004-352c-48a5-bc1b-568aca8fba6c"), null, null, "Daphney.Leuschke8@yahoo.com", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("fbb6fb32-ec3f-4803-8469-9fbbc54dcde3"), null, null, "Bret.Bayer2@gmail.com", false, new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") },
                    { new Guid("fc6fc96f-df1b-404e-8586-da610d610da6"), null, null, "Madeline_Ankunding39@yahoo.com", false, new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed") },
                    { new Guid("fcb6d03e-395d-4426-a5ca-0826caa032dc"), null, null, "Taryn35@hotmail.com", false, new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f") },
                    { new Guid("fd48e277-3dc0-4519-ab23-bc1f289acb5a"), null, null, "Rhea.McGlynn20@yahoo.com", false, new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c") },
                    { new Guid("fd4a5d02-c06e-4e5b-970b-fdd26bf510ef"), null, null, "Forest45@yahoo.com", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("fddd9249-d2f8-428b-9075-45061adbba93"), null, null, "Rhea_Hagenes@hotmail.com", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("fddd9b32-1f66-4b9b-afdb-448c4095b7e5"), null, null, "Kian_Simonis87@yahoo.com", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("fde941fe-0ce6-446a-809a-9e849f6e7dbf"), null, null, "Jennifer.Russel26@yahoo.com", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("fdf3b304-a61e-41ba-b5fe-aa9ec2ddc813"), null, null, "Lamont.Wilderman@hotmail.com", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("feb496f1-496e-4822-bd61-e82d6a6a52ff"), null, null, "Imelda.Tillman85@yahoo.com", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("fed359ca-82f0-4ebe-bc48-1c910e145b0f"), null, null, "Garry_Mayert@hotmail.com", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("fee77701-c85f-47a5-b9a4-1a41fc55a209"), null, null, "Isom68@yahoo.com", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("fef08921-5279-4e4b-ac06-25b038265af3"), null, null, "Mireille_Hackett@gmail.com", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("ff01bbb6-c41e-472d-86f2-a854d9ef276f"), null, null, "Zachery.Jaskolski@yahoo.com", false, new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3") },
                    { new Guid("ffe0c025-1594-48af-8401-11738b7ce000"), null, null, "Cameron.Bartell95@gmail.com", false, new Guid("3855a279-823e-41a4-ad2e-768e134c626f") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("00586589-0496-492d-9d67-90177ae89b39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 28, 2, 46, 26, 799, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 5, 30, 2, 46, 26, 799, DateTimeKind.Local).AddTicks(4905), null, 45.53m, 9091390840533356m, "Super", 2, 22.264359f, "352 Dameon Center, Andersonfort, Togo", new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61"), "017 Sister Plains, South Meganeport, Cook Islands", new Guid("0ec20584-d26f-41c4-b682-05916743e30a"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("048aba20-3c7f-465c-a901-d9e4c5772e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 12, 15, 29, 15, 12, DateTimeKind.Local).AddTicks(6562), new DateTime(2024, 4, 21, 15, 29, 15, 12, DateTimeKind.Local).AddTicks(6562), null, 32.34m, 7427606423021774m, "Super", 2, 31.819592f, "53256 Ivory Keys, South Caliberg, Montserrat", new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa"), "189 McClure Ways, East Kariannemouth, Guam", new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("08def566-b41a-4971-ab8c-cc5492a19c9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 5, 2, 35, 4, 988, DateTimeKind.Local).AddTicks(8499), new DateTime(2023, 7, 7, 2, 35, 4, 988, DateTimeKind.Local).AddTicks(8499), null, 25.40m, true, 6131736548768670m, "ParcelMachine", 5, 34.9922f, "7210 Rozella Rapids, Lake Tiffanyborough, Antigua and Barbuda", new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742"), "2976 Florian Dam, Bryonhaven, Uruguay", new Guid("c8507284-511b-425f-9aab-13ef42992af5"), "Return", "CardboardBox" },
                    { new Guid("0990d6d9-0f27-4f52-8181-34b9229c5e2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 3, 22, 21, 13, 803, DateTimeKind.Local).AddTicks(552), new DateTime(2023, 8, 12, 22, 21, 13, 803, DateTimeKind.Local).AddTicks(552), null, 48.83m, true, 7506860794512978m, "ParcelMachine", 4, 8.340633f, "5341 Stehr Spring, East Gilda, Ireland", new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), "164 Brenna Rapids, Priceville, Bolivia", new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0ae3557e-197e-4c88-80fa-a6b30876a4a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 27, 3, 34, 10, 744, DateTimeKind.Local).AddTicks(5492), new DateTime(2024, 4, 1, 3, 34, 10, 744, DateTimeKind.Local).AddTicks(5492), null, 36.16m, 3826777341448665m, "Courier", 4, 48.42746f, "58759 Ibrahim Wall, North Flaviomouth, Marshall Islands", new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca"), "6009 Beatrice Estates, South Oswald, Paraguay", new Guid("02500051-99f5-4144-945b-877e80352edf"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("0e536ac6-60e9-480a-a1a8-434ca2b16837"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 1, 52, 889, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 11, 11, 20, 1, 52, 889, DateTimeKind.Local).AddTicks(2541), null, 71.52m, 1304065124914726m, true, "ParcelMachine", 3, 30.687609f, "44880 Della Falls, Hermannchester, Swaziland", new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c"), "608 Della Fort, West Bernitamouth, Norfolk Island", new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab"), "Sent", "CardboardBox" },
                    { new Guid("100e8871-4639-4b5e-847a-f8ff69c62fb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 16, 17, 1, 16, 175, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 11, 24, 17, 1, 16, 175, DateTimeKind.Local).AddTicks(2785), null, 47.13m, 1596169493560555m, true, "ParcelMachine", 3, 39.656578f, "5737 Gleason Islands, West Hankport, Chile", new Guid("1909a070-eed8-440c-9e1c-16073e761c90"), "11588 Schumm Estates, East Junechester, Solomon Islands", new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("117f142e-391e-4ba0-8545-7f063be31dd2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 24, 20, 12, 12, 633, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 4, 1, 20, 12, 12, 633, DateTimeKind.Local).AddTicks(6274), null, 75.22m, 6748698928974013m, "ParcelMachine", 3, 9.801993f, "949 Batz Mount, South Jared, Netherlands Antilles", new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf"), "26895 Destini Mall, Lake Ursula, Cayman Islands", new Guid("3855a279-823e-41a4-ad2e-768e134c626f"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("15b2169a-3ae6-46c2-b0fd-bb7b63b6b027"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 13, 3, 0, 43, 433, DateTimeKind.Local).AddTicks(2407), new DateTime(2024, 4, 14, 3, 0, 43, 433, DateTimeKind.Local).AddTicks(2407), null, 90.39m, true, 8891089876862202m, true, "ParcelMachine", 5, 9.7290125f, "67666 McCullough Glens, New Tristonmouth, Greece", new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff"), "766 Maggio Avenue, Lottieton, Faroe Islands", new Guid("4e8e0581-239d-4586-9cca-aad850d7d329"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("162c61e8-d0c1-466c-ad26-bed79b92883c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 25, 17, 9, 2, 752, DateTimeKind.Local).AddTicks(733), new DateTime(2023, 11, 1, 17, 9, 2, 752, DateTimeKind.Local).AddTicks(733), null, 44.78m, 4232603662892990m, "Standart", 1, 5.393307f, "9388 Kristofer Bridge, Priscillaberg, Niue", new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9"), "817 Senger Brook, Lanefurt, French Guiana", new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("174d92fe-58bd-4e9c-b2d3-94b8af402467"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 1, 4, 15, 5, 818, DateTimeKind.Local).AddTicks(4052), new DateTime(2024, 1, 8, 4, 15, 5, 818, DateTimeKind.Local).AddTicks(4052), null, 92.54m, true, 2436400442254889m, "Super", 1, 23.727585f, "915 Morar Forks, Audiehaven, Uganda", new Guid("5db09bf3-8454-4fff-bfe9-003854416f82"), "5413 Haag Row, Lake Jermaine, Iraq", new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("191061f5-9681-4ff2-9daf-7dca0a590ff9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 10, 11, 55, 15, 566, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 6, 11, 11, 55, 15, 566, DateTimeKind.Local).AddTicks(5584), null, 76.79m, 4231851879906518m, "Super", 2, 41.98305f, "9021 Kohler Ford, North Lanceview, Indonesia", new Guid("11712f31-db09-482e-bdab-2c19dff98304"), "8015 Stamm Cape, West Boland, Seychelles", new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), "Return", "CardboardBox" },
                    { new Guid("2081982f-e7a8-4f7d-84e9-1a1e04103558"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 20, 20, 45, 52, 570, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 5, 21, 20, 45, 52, 570, DateTimeKind.Local).AddTicks(2826), null, 81.95m, 9497550178015220m, "Courier", 5, 19.530739f, "3320 Lynch Stravenue, North Tania, United Arab Emirates", new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399"), "51256 Ziemann Ridge, East Joanneville, Tunisia", new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e"), "OnTheWay", "CardboardBox" },
                    { new Guid("220b8694-e1e3-44f4-b9ac-13720c50503a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 30, 0, 37, 30, 511, DateTimeKind.Local).AddTicks(5492), new DateTime(2023, 12, 4, 0, 37, 30, 511, DateTimeKind.Local).AddTicks(5492), null, 77.00m, 3800837592509741m, "ParcelMachine", 3, 4.0736084f, "3520 Jenkins Mews, Raumouth, Jersey", new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed"), "237 Zulauf Pines, East Nevahaven, United States of America", new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("230563a0-6bfa-4111-91ce-65618d1c5b7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 23, 23, 28, 27, 888, DateTimeKind.Local).AddTicks(204), new DateTime(2023, 9, 30, 23, 28, 27, 888, DateTimeKind.Local).AddTicks(204), null, 40.48m, true, 8335486686393599m, true, "Special", 5, 18.194826f, "85543 Gia Shores, Lake Carroll, Kenya", new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d"), "0882 Schowalter Course, Lake Lempifurt, Grenada", new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2a92234a-d068-4ad9-969c-c7591847b206"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 12, 22, 34, 50, 150, DateTimeKind.Local).AddTicks(9485), new DateTime(2024, 2, 17, 22, 34, 50, 150, DateTimeKind.Local).AddTicks(9485), null, 12.98m, true, 2249886030474554m, "Courier", 5, 9.614668f, "6826 Collins Canyon, West Henryton, Ireland", new Guid("57710136-3092-497c-8523-6e222848ceaf"), "3885 Kamron Cliff, Runolfsdottirland, El Salvador", new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2c7ddfd7-71ec-4909-9462-f537f309f386"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 21, 19, 20, 33, 509, DateTimeKind.Local).AddTicks(6996), new DateTime(2023, 8, 29, 19, 20, 33, 509, DateTimeKind.Local).AddTicks(6996), null, 10.84m, 2156573380363638m, "Special", 5, 3.068042f, "9884 Tyreek Spurs, Funkburgh, Ghana", new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc"), "569 Brown Lakes, New Floy, Australia", new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("2d203183-df41-483d-b451-c39579faf718"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 8, 9, 28, 19, 190, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 2, 11, 9, 28, 19, 190, DateTimeKind.Local).AddTicks(2939), null, 16.45m, true, 7426207229084748m, true, "Special", 2, 1.5730193f, "37011 Glover Trafficway, Kunzeborough, Maldives", new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9"), "6017 Sanford Mountain, Madieside, Jordan", new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0"), "Registered", "CardboardBox" },
                    { new Guid("3601039d-ada9-4121-8ddc-121fabca087e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 10, 13, 18, 59, 485, DateTimeKind.Local).AddTicks(6686), new DateTime(2023, 6, 13, 13, 18, 59, 485, DateTimeKind.Local).AddTicks(6686), null, 93.99m, true, 3106696288581386m, true, "Courier", 5, 27.929712f, "85059 Tom Prairie, South Violatown, Saint Martin", new Guid("62780013-8c47-4235-a42a-798d9bf04220"), "02300 Nash Prairie, West Robertochester, Turkey", new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c"), "Return", "CardboardBox" },
                    { new Guid("375b7c56-8075-4398-9231-3a74dd724aa1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 4, 4, 14, 33, 573, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 5, 12, 4, 14, 33, 573, DateTimeKind.Local).AddTicks(9296), null, 58.30m, true, 3064228937759404m, true, "Special", 5, 21.566257f, "39314 Gisselle Street, Jeramietown, Puerto Rico", new Guid("f443c798-1151-4757-94ca-517bef15e381"), "5956 Parker Prairie, Murrayshire, Panama", new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a"), "Delivered", "PlasticBag" },
                    { new Guid("3929d775-e2e9-47d3-897d-2f6281310039"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 13, 12, 7, 40, 644, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 9, 18, 12, 7, 40, 644, DateTimeKind.Local).AddTicks(1251), null, 59.31m, true, 8725427631152458m, true, "Standart", 2, 47.762604f, "72550 Auer Ridge, Leanneton, Ecuador", new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97"), "838 Gutkowski Land, Julianmouth, Western Sahara", new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3c7cbb4e-557b-41f3-8326-0a853d0b4788"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 24, 16, 46, 16, 532, DateTimeKind.Local).AddTicks(6986), new DateTime(2023, 11, 29, 16, 46, 16, 532, DateTimeKind.Local).AddTicks(6986), null, 14.20m, 3584095581445216m, true, "Standart", 1, 32.947334f, "648 Jeffrey Overpass, West Masonstad, Saint Barthelemy", new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8"), "841 Aliya Estate, Kunzemouth, Norfolk Island", new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("428eed4d-8bb5-4672-b8ac-f88131fdbbd5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 24, 3, 6, 23, 267, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 1, 25, 3, 6, 23, 267, DateTimeKind.Local).AddTicks(5947), null, 96.64m, 8881392896382142m, "Standart", 5, 5.832749f, "76481 Sterling Island, Yvetteburgh, Netherlands Antilles", new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27"), "3249 Reinger Parkway, West Isaac, Svalbard & Jan Mayen Islands", new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("42c9edb3-f1e2-4bd5-8059-b912982fd736"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 15, 0, 35, 0, 319, DateTimeKind.Local).AddTicks(5898), new DateTime(2023, 11, 24, 0, 35, 0, 319, DateTimeKind.Local).AddTicks(5898), null, 29.40m, true, 2649035849155662m, true, "Standart", 4, 2.0251982f, "246 Howe Center, East Addisonshire, Iraq", new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce"), "58849 Trever Ridges, Port Tysonchester, Tajikistan", new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("42d586d5-8de5-425c-ab03-2c7e1e0d684c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 14, 56, 43, 501, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 10, 22, 14, 56, 43, 501, DateTimeKind.Local).AddTicks(1253), null, 27.40m, 3819453010734966m, "Courier", 1, 43.980976f, "21508 Bailey Place, Port Jaleel, Somalia", new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), "3721 Moen Ports, South Roel, Niue", new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4336fd00-f1ef-422e-8897-d1ec51fb0da0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 13, 0, 45, 0, 110, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 10, 18, 0, 45, 0, 110, DateTimeKind.Local).AddTicks(2643), null, 28.06m, true, 7300258366209418m, "Courier", 1, 35.56142f, "1269 Pollich Cape, New Flavio, New Caledonia", new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61"), "37685 Marilyne Crossroad, Port Thereseland, Myanmar", new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("43ec8656-255a-4c8f-972b-1572c463e9c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 2, 1, 52, 49, 811, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 1, 4, 1, 52, 49, 811, DateTimeKind.Local).AddTicks(275), null, 25.75m, 6206803219505276m, "Super", 1, 31.845776f, "968 Xavier Cliffs, Jacobsmouth, Afghanistan", new Guid("41bf7410-7941-4fca-a717-3874d970309c"), "38118 Joshuah Roads, East Gerhard, Jordan", new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("44702798-cf02-466c-9c94-58ac3b103e9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 30, 18, 41, 41, 828, DateTimeKind.Local).AddTicks(1005), new DateTime(2023, 8, 6, 18, 41, 41, 828, DateTimeKind.Local).AddTicks(1005), null, 94.02m, true, 2340839292757708m, "Standart", 4, 49.595177f, "2275 Johns Centers, Lake Drakebury, Poland", new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141"), "598 Goldner Mission, Abshireton, Portugal", new Guid("97253083-0ecd-4730-b815-c4b8137ab125"), "Delivered", "PlasticBag" },
                    { new Guid("47288b8c-9cec-435f-a4a0-a96c5ffe37e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 5, 40, 40, 961, DateTimeKind.Local).AddTicks(3268), new DateTime(2023, 11, 21, 5, 40, 40, 961, DateTimeKind.Local).AddTicks(3268), null, 62.76m, true, 5946589117382192m, "Super", 1, 42.71134f, "38296 Rashad Stream, Ceciletown, Mauritius", new Guid("f819889a-570b-4521-a36f-42d900233678"), "413 Chelsea Trafficway, Schneiderside, Lesotho", new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("56015f23-cbd3-4f36-8d4d-5fda4fd1c8ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 22, 12, 33, 13, 338, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 8, 30, 12, 33, 13, 338, DateTimeKind.Local).AddTicks(8314), null, 61.37m, 6545317033387145m, "Courier", 5, 45.13435f, "8847 Kaleigh Shoals, Lake Isidromouth, Afghanistan", new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc"), "5661 Diana Plaza, Douglasburgh, Guam", new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("567fb485-d115-48ed-a17b-79c9ddfeb763"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 26, 19, 19, 8, 940, DateTimeKind.Local).AddTicks(5277), new DateTime(2023, 7, 27, 19, 19, 8, 940, DateTimeKind.Local).AddTicks(5277), null, 87.12m, 6113253456877915m, true, "Courier", 5, 33.23595f, "895 Hillard Estate, Marlonton, Congo", new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8"), "5257 Swaniawski Forks, Hillarymouth, Iraq", new Guid("5227b046-d260-4727-89e6-90bfa60f5f27"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("56a67f75-2912-44f1-9b69-bfd2d573e65b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 3, 18, 12, 11, 908, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 7, 7, 18, 12, 11, 908, DateTimeKind.Local).AddTicks(7859), null, 41.49m, true, 6981085639241923m, true, "Special", 4, 20.898144f, "9504 Macejkovic Manors, New Chynahaven, New Caledonia", new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), "615 Greenfelder Stream, New Sterling, Svalbard & Jan Mayen Islands", new Guid("99f374c8-d976-4051-99c3-7305e5fea09d"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("58b72a97-e18f-42fd-acaa-1203c97a9876"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 19, 14, 52, 9, 312, DateTimeKind.Local).AddTicks(737), new DateTime(2023, 11, 24, 14, 52, 9, 312, DateTimeKind.Local).AddTicks(737), null, 64.88m, 2304475813203732m, true, "Standart", 2, 34.121185f, "711 June Trail, South Kristophershire, Suriname", new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a"), "90591 Amely Avenue, Port Rita, Japan", new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5ae03e58-e126-4966-973c-7c58f9a4373a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 9, 17, 7, 57, 24, DateTimeKind.Local).AddTicks(8580), new DateTime(2024, 3, 14, 17, 7, 57, 24, DateTimeKind.Local).AddTicks(8580), null, 39.87m, true, 3006228355844574m, true, "Standart", 2, 49.277035f, "04123 Wyman Stream, Josianneland, Hong Kong", new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d"), "50638 Karli Mountains, Idaborough, Turkey", new Guid("77941635-e388-4774-9d8a-53d61f8a1c10"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5dc1fa7b-0457-478d-86d6-fbdf721eee74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 29, 8, 5, 46, 946, DateTimeKind.Local).AddTicks(2320), new DateTime(2023, 9, 3, 8, 5, 46, 946, DateTimeKind.Local).AddTicks(2320), null, 95.46m, 1139500365264598m, "Super", 5, 2.6201158f, "64958 Prohaska Prairie, Trentchester, Aruba", new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f"), "890 Alison Ville, Mustafahaven, Ecuador", new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5e968136-66f2-4c19-9b33-6886af1de382"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 17, 20, 1, 44, 442, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 2, 18, 20, 1, 44, 442, DateTimeKind.Local).AddTicks(7185), null, 12.86m, 3368446418805027m, true, "ParcelMachine", 2, 40.004734f, "59844 Eva Village, Sipesberg, Italy", new Guid("62780013-8c47-4235-a42a-798d9bf04220"), "2465 Boyle Trail, Hilllbury, Brazil", new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5f84d9f0-dae6-4d42-8746-38b25b37ea7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 29, 11, 9, 53, 519, DateTimeKind.Local).AddTicks(429), new DateTime(2024, 4, 4, 11, 9, 53, 519, DateTimeKind.Local).AddTicks(429), null, 98.13m, 5085839806838892m, "ParcelMachine", 1, 13.998622f, "6970 Tito Common, Heaneyfurt, Fiji", new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6"), "29721 Schimmel Burg, Danielborough, Monaco", new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6423a626-592d-4953-a5be-13b8c45a3da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 10, 10, 16, 47, 722, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 4, 20, 10, 16, 47, 722, DateTimeKind.Local).AddTicks(1571), null, 45.38m, 5207585948784921m, true, "Super", 2, 24.156647f, "6996 Kerluke Road, West Giovannyfurt, Falkland Islands (Malvinas)", new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432"), "2965 White Springs, East Murl, Guatemala", new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6af93680-908a-43be-9594-9230dd2595c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 26, 4, 2, 13, 357, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 8, 30, 4, 2, 13, 357, DateTimeKind.Local).AddTicks(6480), null, 12.92m, 9190647062264040m, "Special", 3, 1.773619f, "016 Hillary Pines, East Mossie, Norway", new Guid("c8507284-511b-425f-9aab-13ef42992af5"), "26051 Kautzer Crest, Lynchtown, Kuwait", new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7444b9e5-c74d-4adb-96a0-57e2d22724cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 25, 15, 23, 53, 391, DateTimeKind.Local).AddTicks(5252), new DateTime(2024, 2, 28, 15, 23, 53, 391, DateTimeKind.Local).AddTicks(5252), null, 93.01m, true, 1329526483482039m, true, "ParcelMachine", 2, 4.161555f, "035 Jerry Pass, Rosiebury, Kuwait", new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93"), "95843 Hessel Drive, Port Sanford, Iran", new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7602bb37-c462-4dd1-83a5-153c600b53e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 3, 6, 38, 29, 389, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 10, 8, 6, 38, 29, 389, DateTimeKind.Local).AddTicks(2299), null, 69.06m, 9547218869621620m, true, "Standart", 2, 12.609937f, "10685 Harvey Springs, Bogisichfurt, Sweden", new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a"), "33151 Shawna Fields, Janickbury, Guyana", new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7680b7d8-20b2-4438-99b4-69c7ca9bffd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 4, 6, 42, 51, 299, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 12, 10, 6, 42, 51, 299, DateTimeKind.Local).AddTicks(8127), null, 16.58m, 6435172568141780m, "Special", 4, 47.743484f, "24333 McKenzie Light, East Alejandrinmouth, Samoa", new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1"), "14129 Theron Mountain, New Loufurt, Vanuatu", new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("78259b9b-83d2-4133-9719-d39e62bde75a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 12, 2, 35, 40, 417, DateTimeKind.Local).AddTicks(1034), new DateTime(2024, 5, 15, 2, 35, 40, 417, DateTimeKind.Local).AddTicks(1034), null, 13.81m, true, 8749767367562858m, "Courier", 1, 21.717655f, "38372 Stoltenberg Keys, North Corrine, Guatemala", new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4"), "7451 Rolfson Overpass, Laronbury, Tonga", new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7878ad62-4be3-42ae-9aa6-9d04a41714a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 20, 19, 38, 0, 752, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 9, 29, 19, 38, 0, 752, DateTimeKind.Local).AddTicks(6229), null, 11.01m, true, 2716298108069882m, true, "ParcelMachine", 4, 32.449844f, "35036 Osbaldo Branch, Keelyhaven, Kiribati", new Guid("ad755590-668c-421d-994e-b7a783d9dcd5"), "15173 Virgie Lake, Haylieland, Kenya", new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7b48c72e-8e89-4bed-89eb-8c30ae0e1985"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 6, 20, 0, 18, 518, DateTimeKind.Local).AddTicks(6668), new DateTime(2023, 11, 7, 20, 0, 18, 518, DateTimeKind.Local).AddTicks(6668), null, 32.08m, 6205765410397281m, true, "Standart", 1, 40.90571f, "302 Murazik Crossroad, Franeckihaven, Guernsey", new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61"), "803 Margot Crest, Davischester, Italy", new Guid("e50b5106-c89a-489a-b970-99024a53f892"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7e63eba3-0a0e-4188-8198-42aad4ef17c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 12, 17, 28, 13, 273, DateTimeKind.Local).AddTicks(5783), new DateTime(2024, 2, 14, 17, 28, 13, 273, DateTimeKind.Local).AddTicks(5783), null, 66.21m, 7278754370058245m, "Special", 4, 44.49183f, "360 Uriah Walk, Kerlukemouth, Montserrat", new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), "0638 Jast Ford, South Kayley, Norway", new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7fcfd3d0-303b-4f0e-9e5b-03a0e0e8a08c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 27, 20, 58, 31, 645, DateTimeKind.Local).AddTicks(610), new DateTime(2023, 10, 7, 20, 58, 31, 645, DateTimeKind.Local).AddTicks(610), null, 89.80m, 9961627855870304m, true, "Courier", 3, 21.967812f, "314 Milan Throughway, Lake Stanton, Guinea-Bissau", new Guid("36b35b89-da67-408b-9178-d5d020a70822"), "870 Bergnaum Corners, West Esperanzaside, Netherlands Antilles", new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("818944f2-ec8f-469c-85a3-61d122bf395b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 31, 2, 58, 31, 405, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 11, 2, 2, 58, 31, 405, DateTimeKind.Local).AddTicks(9641), null, 88.83m, true, 8914878624368345m, true, "Super", 5, 14.499808f, "01314 Lockman Lodge, DuBuqueview, Antigua and Barbuda", new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80"), "3955 Conroy Extension, Benedictfort, United States Minor Outlying Islands", new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8279645f-862f-40ce-a0fd-dd7eb7a7502a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 17, 3, 3, 47, 451, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 8, 27, 3, 3, 47, 451, DateTimeKind.Local).AddTicks(3347), null, 50.18m, 2246884250933779m, true, "Standart", 4, 16.023972f, "1010 Williamson Lodge, Robertshire, India", new Guid("8c396faa-ad98-400d-a562-77b4902806e1"), "309 Eusebio Garden, South Elton, Mayotte", new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("84353813-9fcf-4271-a2ad-1922d85101a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 10, 9, 44, 51, 576, DateTimeKind.Local).AddTicks(5404), new DateTime(2024, 5, 20, 9, 44, 51, 576, DateTimeKind.Local).AddTicks(5404), null, 43.94m, 2686227477863828m, "Courier", 2, 27.290165f, "018 Tillman Freeway, Port Mose, Seychelles", new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27"), "06252 Janet Passage, Collinsland, Oman", new Guid("bb76498f-37b6-48d3-b979-97246498ed03"), "Delivered", "CardboardBox" },
                    { new Guid("86b03c0a-78c2-4ee3-b5f6-5784ccd29b69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 25, 18, 42, 52, 930, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 5, 26, 18, 42, 52, 930, DateTimeKind.Local).AddTicks(6731), null, 81.65m, 4897443882790680m, "ParcelMachine", 5, 12.587956f, "289 Nikolaus Field, East Rigobertoburgh, Burkina Faso", new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a"), "328 Simonis Coves, Veronabury, Somalia", new Guid("26db4c52-c906-415a-848e-eb60cadca362"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("86e249f3-995c-4eca-b9fc-aad812dd72e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 25, 10, 48, 47, 550, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 11, 30, 10, 48, 47, 550, DateTimeKind.Local).AddTicks(2721), null, 76.84m, true, 1842329483159975m, true, "Courier", 4, 22.242157f, "67600 Bauch Avenue, Mandytown, Svalbard & Jan Mayen Islands", new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc"), "532 Kirsten Views, Boyermouth, Turkey", new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8816ffa7-8e60-4b1b-b3ce-d54911d81bce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 24, 14, 17, 53, 128, DateTimeKind.Local).AddTicks(7219), new DateTime(2024, 3, 5, 14, 17, 53, 128, DateTimeKind.Local).AddTicks(7219), null, 97.93m, true, 1265856269215942m, "Courier", 1, 10.202397f, "58587 Kunde Ferry, North Virgieberg, Hungary", new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6"), "704 Rodriguez Street, Walterport, Singapore", new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8bd3fa40-910c-46b6-b2a0-303815b69296"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 22, 14, 1, 21, 80, DateTimeKind.Local).AddTicks(6097), new DateTime(2023, 8, 25, 14, 1, 21, 80, DateTimeKind.Local).AddTicks(6097), null, 80.34m, 9223275203842632m, "Special", 3, 34.282166f, "78104 Amie Stravenue, Farrelltown, Georgia", new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a"), "1326 Watsica Trace, Lake Einarstad, Lebanon", new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("8dc6eacd-bda8-4733-bc21-6af52b62dfd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 1, 22, 10, 58, 839, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 3, 11, 22, 10, 58, 839, DateTimeKind.Local).AddTicks(7575), null, 11.99m, true, 1830103572499708m, "Standart", 3, 18.13528f, "70287 Schmeler Stream, Binshaven, Ireland", new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042"), "906 Annalise Rest, Strackemouth, San Marino", new Guid("5e421353-3237-4b90-a7a1-a061d45dbede"), "Registered", "CardboardBox" },
                    { new Guid("90bf7ca6-57c3-4f1b-908c-33097b5e508a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 11, 5, 59, 43, 143, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 12, 21, 5, 59, 43, 143, DateTimeKind.Local).AddTicks(2822), null, 53.57m, true, 7148854973630035m, "Standart", 5, 48.78945f, "4778 Schowalter Union, East Ottisfort, Iraq", new Guid("072b74c5-5e1d-46de-9caa-66d36218f554"), "4594 Gerald Point, Eliasside, French Southern Territories", new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa"), "Delivered", "CardboardBox" },
                    { new Guid("92e5ddb5-7bc9-4811-b8a9-d435886aa306"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 5, 15, 28, 47, 818, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 2, 12, 15, 28, 47, 818, DateTimeKind.Local).AddTicks(3445), null, 68.52m, true, 2332929619569207m, "Standart", 2, 29.430473f, "3954 Labadie Rapids, Davisbury, Mali", new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe"), "34392 Littel Roads, Jenkinsfurt, Palau", new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("93474584-b73d-42e4-ade2-1970bce3841e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 21, 23, 15, 28, 667, DateTimeKind.Local).AddTicks(7430), new DateTime(2023, 9, 28, 23, 15, 28, 667, DateTimeKind.Local).AddTicks(7430), null, 18.85m, true, 4718748045931218m, true, "Standart", 3, 24.424866f, "35325 Hegmann Squares, Port Rhiannaview, Panama", new Guid("4e8e0581-239d-4586-9cca-aad850d7d329"), "0126 Karen Brooks, Leuschkemouth, Fiji", new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("93c8af05-3ed0-47d2-80b8-90bf94df254c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 4, 16, 4, 37, 861, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 3, 11, 16, 4, 37, 861, DateTimeKind.Local).AddTicks(2298), null, 87.51m, 7870539396878517m, "Courier", 5, 13.962445f, "962 Diego Brooks, Haleyhaven, Serbia", new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867"), "12380 Hand Springs, Angeloshire, Mongolia", new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("953e1536-546c-4ecc-841a-4746cf8a8c10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 19, 22, 19, 57, 643, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 11, 25, 22, 19, 57, 643, DateTimeKind.Local).AddTicks(4444), null, 75.73m, 2422056493975950m, true, "ParcelMachine", 5, 5.1082187f, "066 Florida Trafficway, McKenzietown, Lao People's Democratic Republic", new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec"), "672 Gilbert Avenue, Port Jackeline, Bhutan", new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("96acde61-8bd0-41aa-991d-2ac6ca45f7ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 17, 10, 56, 22, 263, DateTimeKind.Local).AddTicks(1797), new DateTime(2023, 9, 24, 10, 56, 22, 263, DateTimeKind.Local).AddTicks(1797), null, 20.53m, true, 6327855502074266m, true, "Special", 5, 41.84498f, "931 Gleichner Tunnel, Donnellyside, Mali", new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4"), "06718 Tressie Spring, West Melvin, Equatorial Guinea", new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9c1427fc-684d-487b-8d05-db762dfa55c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 12, 13, 12, 17, 172, DateTimeKind.Local).AddTicks(7843), new DateTime(2024, 3, 20, 13, 12, 17, 172, DateTimeKind.Local).AddTicks(7843), null, 84.28m, true, 7102502615422650m, "Super", 3, 10.450557f, "688 Dasia Passage, North Kathryne, Moldova", new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838"), "223 Nolan Fork, Lake Karleebury, Libyan Arab Jamahiriya", new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a04e1813-16cc-40b5-8494-903c11cb3e03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 2, 19, 5, 54, 478, DateTimeKind.Local).AddTicks(1847), new DateTime(2024, 1, 7, 19, 5, 54, 478, DateTimeKind.Local).AddTicks(1847), null, 88.91m, true, 8563731005302747m, true, "Standart", 4, 12.140815f, "356 Gaston Flat, South Feliciashire, Uzbekistan", new Guid("59bca1c3-a467-4623-b95f-1679227c24ca"), "50264 Diego Greens, West Ginaborough, Russian Federation", new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3"), "OnTheWay", "CardboardBox" },
                    { new Guid("a280e0a4-44a6-4ba6-860f-dfddcaaeb863"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 8, 18, 3, 11, 999, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 1, 13, 18, 3, 11, 999, DateTimeKind.Local).AddTicks(4872), null, 82.12m, true, 9152867285584558m, true, "Courier", 2, 0.9537547f, "6987 Hills Corners, East Clementina, Czech Republic", new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04"), "988 Mya Pass, East Aaron, Bangladesh", new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a8e717cb-d583-4f1e-a5af-6c8d100e7479"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 29, 5, 29, 58, 634, DateTimeKind.Local).AddTicks(990), new DateTime(2023, 12, 9, 5, 29, 58, 634, DateTimeKind.Local).AddTicks(990), null, 34.60m, 2279383734208952m, "ParcelMachine", 1, 5.589759f, "9185 Devyn Village, Zulahaven, Sierra Leone", new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6"), "503 Ophelia Vista, Orvilleton, Sierra Leone", new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a93ad52e-c3fb-4d35-b523-eafa21dd4956"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 31, 8, 25, 7, 428, DateTimeKind.Local).AddTicks(2135), new DateTime(2023, 8, 10, 8, 25, 7, 428, DateTimeKind.Local).AddTicks(2135), null, 85.13m, true, 7277044436184680m, true, "ParcelMachine", 1, 6.4551826f, "711 Langworth Circles, Rahulshire, Belarus", new Guid("fca3cb7d-c11d-445d-8752-00136c100d96"), "794 Hagenes Meadows, New Herthamouth, Djibouti", new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a9b0f7bc-c4ed-4db3-9c8f-599b4df5f1fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 10, 5, 52, 52, 279, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 9, 17, 5, 52, 52, 279, DateTimeKind.Local).AddTicks(190), null, 57.10m, 7962705629663419m, true, "Special", 2, 15.965727f, "432 Doyle Centers, Harmonmouth, Nicaragua", new Guid("97253083-0ecd-4730-b815-c4b8137ab125"), "45939 Hilpert Loop, Lake Annamae, Uzbekistan", new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ab313dfb-45f6-40a8-bfc4-edc829ac0480"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 25, 17, 6, 51, 147, DateTimeKind.Local).AddTicks(9787), new DateTime(2024, 2, 4, 17, 6, 51, 147, DateTimeKind.Local).AddTicks(9787), null, 92.72m, 9493613148903048m, "Special", 5, 3.2743363f, "84034 Bessie Field, Braxtonfort, Turks and Caicos Islands", new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea"), "089 Mills Harbors, East Delilah, Argentina", new Guid("5f140f7e-803a-444d-8158-03815cbd832c"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ace9acf2-0fa2-4b22-8926-215399a6e748"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 1, 11, 41, 26, 717, DateTimeKind.Local).AddTicks(5363), new DateTime(2024, 2, 5, 11, 41, 26, 717, DateTimeKind.Local).AddTicks(5363), null, 74.89m, true, 1753748487208010m, "ParcelMachine", 3, 24.586258f, "506 Estella Lock, Gaylordville, Saint Kitts and Nevis", new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826"), "692 Myrtle Pike, West Joanfurt, Philippines", new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5"), "Sent", "PlasticBag" },
                    { new Guid("ad22c281-27b8-4a2f-bedf-a0a1f7f49553"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 22, 8, 50, 48, 542, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 4, 30, 8, 50, 48, 542, DateTimeKind.Local).AddTicks(4104), null, 95.93m, true, 2842793987190133m, "Courier", 1, 43.99014f, "25317 Watson Walk, South Trevor, Denmark", new Guid("58a68d56-e166-49e9-ab53-b148a241cc49"), "60681 Lemke Green, North Greg, Belarus", new Guid("09fd275e-b209-4f17-84ed-5884b76fc276"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ae6f38b1-488d-4687-95ac-a39597bb59b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 7, 22, 51, 8, 41, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 11, 14, 22, 51, 8, 41, DateTimeKind.Local).AddTicks(9774), null, 54.54m, true, 6731044890710120m, true, "ParcelMachine", 1, 46.179684f, "2029 Ted Hills, Edwardoshire, Equatorial Guinea", new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d"), "6916 Tanya Manors, Alekfort, Costa Rica", new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53"), "OnTheWay", "PlasticBag" },
                    { new Guid("ae9ad2db-f51a-49c3-b6af-c334933164d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 15, 17, 33, 13, 653, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 2, 18, 17, 33, 13, 653, DateTimeKind.Local).AddTicks(5500), null, 46.55m, true, 2123383457958216m, true, "Courier", 3, 34.905075f, "6154 Lydia Plains, Labadiestad, Cyprus", new Guid("46075330-4d61-4bde-be40-948e47bd19fb"), "360 Konopelski Common, Robelmouth, Sao Tome and Principe", new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4"), "Sent", "PlasticBag" },
                    { new Guid("aecedd46-9ed5-46f1-84fc-acf47e3f08c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 4, 15, 12, 48, 804, DateTimeKind.Local).AddTicks(9498), new DateTime(2023, 7, 6, 15, 12, 48, 804, DateTimeKind.Local).AddTicks(9498), null, 90.53m, true, 8449970837079268m, true, "Special", 5, 33.759228f, "3587 Kub Square, Pfefferstad, Libyan Arab Jamahiriya", new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04"), "844 Pagac Courts, Omerberg, Thailand", new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b49e8019-f67d-412b-ae71-fd257599ae56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 16, 23, 32, 53, 928, DateTimeKind.Local).AddTicks(2420), new DateTime(2024, 1, 20, 23, 32, 53, 928, DateTimeKind.Local).AddTicks(2420), null, 16.66m, 2340853987919532m, true, "Special", 5, 8.385619f, "5880 Koss Highway, Altenwerthfort, Turkmenistan", new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2"), "651 Fisher Parkway, North Tito, Heard Island and McDonald Islands", new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b8d8fc40-fe20-49c0-a548-9bc9083550b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 11, 1, 17, 28, 62, DateTimeKind.Local).AddTicks(3732), new DateTime(2023, 12, 16, 1, 17, 28, 62, DateTimeKind.Local).AddTicks(3732), null, 50.05m, true, 6814531264087033m, "Standart", 1, 40.973488f, "2564 Melisa Branch, MacGyverburgh, Guam", new Guid("44275811-c945-4a4f-8382-272488a907aa"), "86197 Kihn Knolls, Jeramieshire, Iran", new Guid("5db09bf3-8454-4fff-bfe9-003854416f82"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("bd7f571f-9dbf-4988-bdcd-964174c08fca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 15, 5, 0, 32, 75, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 6, 21, 5, 0, 32, 75, DateTimeKind.Local).AddTicks(7867), null, 63.32m, 9591118270590404m, "Standart", 2, 35.288933f, "9995 Niko Mill, Pollichbury, Heard Island and McDonald Islands", new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4"), "79824 Yadira Lodge, New Zoie, Philippines", new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e"), "Sent", "PlasticBag" },
                    { new Guid("c8cd1541-5aeb-4162-8915-7fb0cd0f4194"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 25, 10, 18, 2, 666, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 3, 4, 10, 18, 2, 666, DateTimeKind.Local).AddTicks(5377), null, 34.32m, 3569899176528172m, "Special", 4, 36.79552f, "2015 Schowalter Locks, New Ramiro, British Indian Ocean Territory (Chagos Archipelago)", new Guid("f443c798-1151-4757-94ca-517bef15e381"), "63272 Karlie Street, West Lutherside, Gibraltar", new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), "Registered", "PlasticBag" },
                    { new Guid("c98faf58-c4d5-460e-aef3-4388605d73ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 24, 2, 19, 20, 47, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 6, 25, 2, 19, 20, 47, DateTimeKind.Local).AddTicks(9718), null, 59.50m, 5279523694010034m, "Standart", 4, 19.806726f, "1843 Rutherford Drives, Strosinton, Panama", new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93"), "0413 Gayle Isle, East Raphaelborough, Holy See (Vatican City State)", new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("c9de1da8-8bb9-44c2-b6c7-f7ade3c21557"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 21, 1, 9, 31, 871, DateTimeKind.Local).AddTicks(6760), new DateTime(2024, 5, 28, 1, 9, 31, 871, DateTimeKind.Local).AddTicks(6760), null, 32.91m, true, 9504072023867190m, true, "Standart", 5, 35.173855f, "967 Raynor Crossing, East Lacey, Cote d'Ivoire", new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc"), "83219 Lockman Land, Feestshire, Seychelles", new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf"), "OnTheWay", "CardboardBox" },
                    { new Guid("cbf28c7d-bac8-42c9-909a-1c930b7a9f31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 21, 4, 22, 19, 24, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 4, 23, 4, 22, 19, 24, DateTimeKind.Local).AddTicks(9035), null, 50.68m, true, 4309411655773483m, true, "Courier", 3, 26.565416f, "765 Adriana Stravenue, Claireview, Suriname", new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5"), "2759 Welch Mount, Quitzonhaven, Panama", new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a"), "Return", "CardboardBox" },
                    { new Guid("cc5bac1e-9454-4908-9ff0-d53783a2f7b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 13, 1, 49, 59, 425, DateTimeKind.Local).AddTicks(3811), new DateTime(2023, 10, 16, 1, 49, 59, 425, DateTimeKind.Local).AddTicks(3811), null, 26.71m, true, 1691082924888766m, true, "ParcelMachine", 4, 14.47071f, "985 Runte Locks, East Rosina, Latvia", new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae"), "65989 Gillian Orchard, North Otisland, United Kingdom", new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d136f34b-56f6-4edd-ba96-5b957f10b818"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 5, 2, 30, 53, 658, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 1, 9, 2, 30, 53, 658, DateTimeKind.Local).AddTicks(2527), null, 69.90m, 1173338566010550m, true, "Courier", 4, 8.578543f, "33534 Simonis Haven, East Douglas, Kuwait", new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17"), "38603 Ayden Bypass, Doyleland, New Caledonia", new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d5043e27-bbdc-4938-af59-e75a801669d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 8, 23, 42, 10, 140, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 4, 11, 23, 42, 10, 140, DateTimeKind.Local).AddTicks(7208), null, 88.22m, 4408186336222014m, "Special", 2, 16.599564f, "24667 Stephen Views, Alexahaven, Bouvet Island (Bouvetoya)", new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a"), "68419 Candice Mount, South Ignaciomouth, Kyrgyz Republic", new Guid("44275811-c945-4a4f-8382-272488a907aa"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d62e1a21-095d-4aeb-b1c2-b97b3ad2424d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 28, 18, 5, 51, 783, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 1, 2, 18, 5, 51, 783, DateTimeKind.Local).AddTicks(974), null, 44.42m, true, 7147973049569202m, true, "Courier", 5, 25.765516f, "6895 Quigley Keys, Lake Abigayleshire, Indonesia", new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0"), "66823 Schinner Rest, Lake Makenzie, Macedonia", new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("da078dda-e930-468d-9df5-88c6f40ea652"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 8, 21, 39, 37, 118, DateTimeKind.Local).AddTicks(4378), new DateTime(2023, 8, 12, 21, 39, 37, 118, DateTimeKind.Local).AddTicks(4378), null, 64.80m, true, 5393901734743726m, "ParcelMachine", 4, 26.532852f, "4699 Delpha Summit, East Marlon, Rwanda", new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058"), "2261 Milan Forest, O'Reillyberg, Philippines", new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("da967769-cfbb-4782-bd52-441ab5beefcb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 14, 0, 19, 24, 250, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 7, 22, 0, 19, 24, 250, DateTimeKind.Local).AddTicks(6872), null, 38.05m, 6886766732804961m, true, "Super", 1, 47.702377f, "6989 Brian Turnpike, Donnyview, Cocos (Keeling) Islands", new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb"), "516 Marta Ville, West Alvera, Croatia", new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("dfd3e9fb-55ef-4c10-a779-9f1df99360e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 26, 7, 50, 59, 843, DateTimeKind.Local).AddTicks(8702), new DateTime(2023, 7, 3, 7, 50, 59, 843, DateTimeKind.Local).AddTicks(8702), null, 43.02m, true, 3154323781374350m, "Super", 2, 33.16165f, "9248 Olson Forges, Johnschester, Iran", new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3"), "07806 Alexandrine Dale, Lake Rashad, Isle of Man", new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f"), "Sent", "PlasticBag" },
                    { new Guid("e6b7404c-d68c-4122-a50c-381d8c1cc93a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 20, 17, 49, 6, 37, DateTimeKind.Local).AddTicks(1518), new DateTime(2024, 1, 28, 17, 49, 6, 37, DateTimeKind.Local).AddTicks(1518), null, 82.27m, true, 3587207806884508m, "Special", 5, 27.675117f, "4566 Jast Canyon, Kutchshire, Indonesia", new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4"), "1050 Blanda Gardens, Lake Alexanetown, Nicaragua", new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e8d51677-e751-442f-b24e-c510a10998d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 27, 7, 0, 51, 59, DateTimeKind.Local).AddTicks(1293), new DateTime(2023, 8, 2, 7, 0, 51, 59, DateTimeKind.Local).AddTicks(1293), null, 26.62m, 9604220249418168m, "Super", 5, 11.281252f, "6484 Kertzmann Inlet, North Juneport, Antarctica (the territory South of 60 deg S)", new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940"), "0498 Chelsey Glen, Aurelioview, Saint Lucia", new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e95c6192-b4a9-4647-b389-f61594aca2d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 29, 21, 2, 3, 687, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 10, 8, 21, 2, 3, 687, DateTimeKind.Local).AddTicks(8756), null, 56.69m, true, 5107698186877428m, "Courier", 2, 36.801212f, "01303 Adriana Valley, North Desmondchester, Pakistan", new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694"), "05980 Bogisich Mountain, West Lysannestad, Holy See (Vatican City State)", new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("eada00a9-872d-48db-b68e-3f4e0136517a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 24, 13, 48, 26, 703, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 10, 26, 13, 48, 26, 703, DateTimeKind.Local).AddTicks(900), null, 19.62m, true, 9208626058102424m, true, "Standart", 1, 33.044487f, "4367 Fisher Lane, North Jordychester, Venezuela", new Guid("234cf821-c69e-41fd-b13e-68660060a87e"), "9376 Stoltenberg Knoll, New Gisselle, Gambia", new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("eb22ebcb-4bf9-4e1c-ab99-9934d1424b21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 23, 21, 21, 29, 569, DateTimeKind.Local).AddTicks(7487), new DateTime(2023, 6, 27, 21, 21, 29, 569, DateTimeKind.Local).AddTicks(7487), null, 30.66m, true, 5407966961178802m, "Courier", 5, 0.4468511f, "92711 Janiya Plains, Daniellestad, Spain", new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2"), "79590 Franecki Extension, Rolfsonside, Western Sahara", new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f164bf26-529d-49ad-8e60-c20647f5dbad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 11, 5, 43, 1, 216, DateTimeKind.Local).AddTicks(138), new DateTime(2024, 4, 18, 5, 43, 1, 216, DateTimeKind.Local).AddTicks(138), null, 48.95m, 1299566885071058m, true, "Courier", 5, 34.425343f, "77693 Dora Forges, Heidenreichfort, Cook Islands", new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3"), "6757 Stokes Glens, Estevanbury, Saint Martin", new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9"), "OnTheWay", "CardboardBox" },
                    { new Guid("f1967435-5b0a-4707-aff6-9a9c1c0143b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 1, 17, 23, 11, 669, DateTimeKind.Local).AddTicks(5738), new DateTime(2024, 6, 11, 17, 23, 11, 669, DateTimeKind.Local).AddTicks(5738), null, 40.77m, 2392898025804943m, true, "Special", 5, 8.346431f, "35446 Dibbert Shores, South Austinburgh, Tuvalu", new Guid("11712f31-db09-482e-bdab-2c19dff98304"), "921 Lina Wells, Giovanniland, Slovenia", new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f382c040-12c4-40f5-9f6a-62b13f50004f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 27, 15, 20, 25, 588, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 8, 29, 15, 20, 25, 588, DateTimeKind.Local).AddTicks(4999), null, 59.14m, true, 5927033427068275m, true, "Super", 4, 31.554153f, "46452 Raphael Loaf, New Derick, Germany", new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a"), "738 Kunze Centers, South Josue, Palau", new Guid("cf715f5b-d690-415d-b228-62054ae77a1f"), "Delivered", "CardboardBox" },
                    { new Guid("f61960c0-a845-4daa-bbbd-f7642b230d1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 18, 18, 32, 48, 371, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 10, 19, 18, 32, 48, 371, DateTimeKind.Local).AddTicks(4533), null, 14.48m, true, 7622082423351566m, true, "Super", 4, 6.7508044f, "9819 Eddie Corners, Port Luellaville, Jordan", new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f"), "67812 West Club, North Antoinette, Cambodia", new Guid("59917ef6-495b-463e-9d58-75b21f8544bc"), "Return", "CardboardBox" },
                    { new Guid("f8180307-394c-4ca2-a650-6a4631433a96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 26, 6, 8, 51, 690, DateTimeKind.Local).AddTicks(3562), new DateTime(2023, 8, 27, 6, 8, 51, 690, DateTimeKind.Local).AddTicks(3562), null, 56.98m, true, 1461992996436558m, true, "Courier", 3, 23.033514f, "7373 Bailey Bridge, Harveyshire, Svalbard & Jan Mayen Islands", new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4"), "2155 Dietrich Unions, South Jermaine, Gibraltar", new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("fa7b6437-4a53-49ed-87d8-bc8654bd5b5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 23, 15, 39, 6, 184, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 6, 28, 15, 39, 6, 184, DateTimeKind.Local).AddTicks(7354), null, 47.61m, 9126357199904866m, "Standart", 2, 38.29996f, "74214 Randal Tunnel, Noahborough, Ukraine", new Guid("9bea6011-9948-451d-9195-7c4cc4339cba"), "492 Demarco Walks, Pagachaven, Gambia", new Guid("9af47343-7f95-4006-8dea-4975912f5989"), "Return", "PlasticBag" },
                    { new Guid("fa92e718-bd6c-4280-9265-c60671bab71f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 31, 6, 18, 13, 880, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 6, 5, 6, 18, 13, 880, DateTimeKind.Local).AddTicks(5932), null, 48.46m, 8850482467572082m, "Super", 4, 42.97047f, "72818 Harvey Circle, Deshawnview, Tonga", new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432"), "89035 Myah Trace, Kuphalhaven, Belize", new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8"), "OnTheWay", "CardboardBox" },
                    { new Guid("ffa4d497-e15e-48be-a425-9b2292741e3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 18, 20, 29, 31, 198, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 3, 26, 20, 29, 31, 198, DateTimeKind.Local).AddTicks(2270), null, 16.08m, 9533672443950736m, "Special", 1, 17.124434f, "5025 Parker Cliff, Mosciskihaven, Ukraine", new Guid("57710136-3092-497c-8523-6e222848ceaf"), "469 Ziemann Landing, East Montemouth, Azerbaijan", new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("00f4b3d6-a8d9-496a-89bd-7b8cbc274d54"), "373", "6684185318253043", null, null, new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8"), "12/25" },
                    { new Guid("013328f9-a960-4c92-9607-161140701dc4"), "231", "7801183614862663", null, null, new Guid("95f06adb-a1fa-40bc-8351-b298d818044d"), "05/05" },
                    { new Guid("016f02a5-16f5-43bc-8eb7-3fd877541920"), "616", "6880346819054658", null, null, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89"), "01/28" },
                    { new Guid("017ecc7c-8f2f-47dd-bfb1-8e98f72038d3"), "372", "3821294499736008", null, null, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6"), "03/25" },
                    { new Guid("017f3082-583b-43fa-bb3b-8e47d005e74f"), "463", "6604451192582389", null, null, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad"), "11/24" },
                    { new Guid("01aca6cb-074d-47a4-9db4-cee52bb818bf"), "044", "6692389392845494", null, null, new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5"), "09/22" },
                    { new Guid("01c188de-c2ba-4f96-bcd0-eb671ec7f66e"), "426", "2492454456110133", null, null, new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888"), "04/06" },
                    { new Guid("01c19d0a-eecc-4a88-82a2-61de52187b9e"), "539", "4645062133330967", null, null, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec"), "03/16" },
                    { new Guid("01d69f90-ee3f-4dba-b198-896450a16291"), "508", "9325272426859829", null, null, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565"), "06/14" },
                    { new Guid("027b32d1-d1d6-40bc-87d9-5e2177e8b1c8"), "883", "1307165813883573", null, null, new Guid("36b35b89-da67-408b-9178-d5d020a70822"), "10/19" },
                    { new Guid("02a44381-c3a2-4dbe-b820-a0b90841565b"), "157", "6685877045246380", null, null, new Guid("ad755590-668c-421d-994e-b7a783d9dcd5"), "09/20" },
                    { new Guid("02aae0ec-63ab-4ad1-8d87-d55f4abe9948"), "367", "3697310632987343", null, null, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c"), "06/20" },
                    { new Guid("02c2f7f9-faae-44ea-ad99-d58d3fd20b03"), "271", "2999684007391033", null, null, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c"), "09/18" },
                    { new Guid("0313b3c3-0807-47d9-8af7-b57581ec7022"), "200", "6623473565430660", null, null, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84"), "01/12" },
                    { new Guid("0339ff3e-53f6-42d6-9b24-e2c4329857e4"), "842", "9395327281674565", null, null, new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4"), "02/16" },
                    { new Guid("037a5053-6722-4953-83d6-3d912a005a61"), "583", "9473373851333911", null, null, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3"), "08/04" },
                    { new Guid("03a496b2-471d-4833-bd80-26b987891ae7"), "861", "2154685677906567", null, null, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827"), "06/23" },
                    { new Guid("03f44a97-e7b9-43f3-81a9-898bbd27c09a"), "565", "2510308982723272", null, null, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f"), "12/10" },
                    { new Guid("03f6c5ca-d4bd-4f68-b44d-06d29c8cefe9"), "384", "8689027511263369", null, null, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500"), "04/06" },
                    { new Guid("0426569e-5a7c-4a71-af49-cbbcbb686a32"), "003", "5128316644885163", null, null, new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5"), "08/09" },
                    { new Guid("045e52f4-bd07-4f8c-917a-8304898e4e94"), "822", "5002647922253387", null, null, new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae"), "08/09" },
                    { new Guid("0467d258-33a1-4c99-bdf4-5a778f51c79d"), "927", "7204991268363151", null, null, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e"), "10/11" },
                    { new Guid("04aba6a6-7aa4-410f-8fec-107af3c9ce57"), "585", "7355728201568867", null, null, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c"), "11/10" },
                    { new Guid("05177448-7974-4955-9562-6251c547ef49"), "552", "4391715557056695", null, null, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c"), "06/09" },
                    { new Guid("0530e45a-e059-40c0-8a26-ff39503649d5"), "523", "7733987292524945", null, null, new Guid("eea73942-2019-41c4-9063-ab64deb92300"), "10/21" },
                    { new Guid("053cbdf7-7f1f-4aae-844e-c85f8d0a8a42"), "907", "6634258180783726", null, null, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0"), "01/15" },
                    { new Guid("057891d3-45b1-4e6a-a44e-f4f8680fb0f5"), "688", "7825607282483397", null, null, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141"), "07/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("05bb9c69-21d5-45e9-837d-946e739f7f5c"), "865", "3252683845871448", null, null, new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed"), "10/19" },
                    { new Guid("05cbc589-8965-4499-9b82-ddc23e63a6ab"), "089", "5650948109212558", null, null, new Guid("5227b046-d260-4727-89e6-90bfa60f5f27"), "12/15" },
                    { new Guid("061a124f-32c5-4e88-8425-572719a88cf4"), "893", "3677050152568692", null, null, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe"), "01/19" },
                    { new Guid("06416957-aeb1-4c8c-b94e-262094999e3a"), "843", "1442576256851019", null, null, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8"), "06/22" },
                    { new Guid("066fae6f-956d-4c8c-bba1-fd8c2fb7782f"), "473", "4381637550133656", null, null, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b"), "09/18" },
                    { new Guid("06a5b382-f8f1-4c3f-b2b9-c2cc1ec7264c"), "318", "3654430986148170", null, null, new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3"), "08/18" },
                    { new Guid("06b8f7a5-2b84-4d93-a0bb-2bcff7ce6a0c"), "524", "2960488635284728", null, null, new Guid("62780013-8c47-4235-a42a-798d9bf04220"), "06/21" },
                    { new Guid("06d3d178-ea99-4d87-bec2-76b1f19918e7"), "943", "7164298737079591", null, null, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), "07/24" },
                    { new Guid("06d46697-9dbc-4c6a-9146-d667b90d4bb3"), "633", "5129037219543817", null, null, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b"), "07/20" },
                    { new Guid("07100dea-e3cf-4592-beb3-518c0f35e72a"), "275", "4907374117036123", null, null, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696"), "06/26" },
                    { new Guid("074a9774-f6ce-4bb1-8761-711f2e9f8dce"), "518", "2730017197273645", null, null, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969"), "02/26" },
                    { new Guid("0774cf2f-8b6a-4096-8a98-a24e38eeff7c"), "460", "1535334397609044", null, null, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d"), "01/05" },
                    { new Guid("0785d7f4-1c85-4703-a975-58fa4df5ca5a"), "523", "9133583380294727", null, null, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285"), "06/13" },
                    { new Guid("07e27a98-f749-4a0a-9e69-56b4b857d02d"), "735", "9605203002007130", null, null, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969"), "04/06" },
                    { new Guid("081a154e-4bb4-4485-949f-e6a4abfede5b"), "356", "3781393914116369", null, null, new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f"), "07/26" },
                    { new Guid("0872adb5-f81e-4af9-be52-fa0f51414145"), "791", "2182629990424188", null, null, new Guid("41bf7410-7941-4fca-a717-3874d970309c"), "06/10" },
                    { new Guid("0882cc05-0b1f-444a-8fe9-0086ff074892"), "056", "8145577206029120", null, null, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32"), "03/18" },
                    { new Guid("0905feb9-ddcc-4935-b643-c764a11d64d6"), "647", "1804572821754509", null, null, new Guid("97253083-0ecd-4730-b815-c4b8137ab125"), "11/06" },
                    { new Guid("0a11d74c-6afc-48b6-a140-a6d5ceceaccb"), "592", "6810027555312392", null, null, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17"), "05/03" },
                    { new Guid("0a2175e6-a37b-4510-bd19-8ce4c3d63e51"), "383", "7480589085944415", null, null, new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2"), "11/11" },
                    { new Guid("0ab52245-b122-45ac-9cfc-4d8ae7863710"), "011", "1193518510546553", null, null, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b"), "08/07" },
                    { new Guid("0af9ce43-2d42-4002-948a-d102c05ebe7a"), "317", "9888766401754268", null, null, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826"), "02/17" },
                    { new Guid("0bbe80a4-528b-4820-a7c2-60e35ae95a8f"), "724", "8216838132981687", null, null, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5"), "05/21" },
                    { new Guid("0c6b0abb-b285-43c8-ad30-8cdbf970211d"), "901", "7689416328270299", null, null, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec"), "01/24" },
                    { new Guid("0c803fc0-754c-4b29-8b4e-cd7fc1b99b3e"), "027", "6793690086218403", null, null, new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058"), "07/03" },
                    { new Guid("0ce88a40-193a-4bab-a0d1-450bb515a221"), "340", "2953222241254820", null, null, new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f"), "01/26" },
                    { new Guid("0d930417-53d7-4c0d-8ab3-125737397d1f"), "867", "6754325334930965", null, null, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940"), "11/11" },
                    { new Guid("0ddba378-b4be-49b4-8be6-6fa9caefbf23"), "803", "8763639000918057", null, null, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835"), "09/06" },
                    { new Guid("0dfd3edd-0009-4b03-9f87-60023d47af22"), "314", "2745769459392545", null, null, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020"), "03/03" },
                    { new Guid("0e5ec942-5539-4d71-81f7-d739b3a7b9ba"), "776", "7483041237951096", null, null, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d"), "11/17" },
                    { new Guid("0efa43cd-76b4-4ed9-9808-4f3c2a11e69f"), "905", "6752102688979956", null, null, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7"), "01/27" },
                    { new Guid("0f1a4bd6-9bd0-4bdf-acf3-06be789a42c8"), "135", "4705834483272860", null, null, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357"), "07/14" },
                    { new Guid("0f7dbc8f-5c00-43c3-8166-bdf56f92622b"), "133", "1128413868014013", null, null, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d"), "03/23" },
                    { new Guid("0f8dde18-9048-47ec-8b89-889396ad8cc3"), "638", "7766324485136645", null, null, new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d"), "02/23" },
                    { new Guid("0fa92c09-8fc7-44f7-959a-e361112c477b"), "415", "3578322499403471", null, null, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3"), "06/09" },
                    { new Guid("0fb1a890-5439-4b96-aa9e-0f0cfc729141"), "766", "3021743664216494", null, null, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea"), "07/05" },
                    { new Guid("0fe49943-9160-40e1-b03c-8f79b7296085"), "620", "6002629799842223", null, null, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5"), "05/22" },
                    { new Guid("0fe98005-c7b4-47c2-8f4c-ea6019d2a832"), "328", "5985240771065953", null, null, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e"), "11/14" },
                    { new Guid("102e72f7-1e48-449d-bc38-ba787f777343"), "199", "9677939696922116", null, null, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b"), "04/27" },
                    { new Guid("10733cda-c8e3-474b-aaee-1a89678adc18"), "382", "2058754356664701", null, null, new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f"), "05/13" },
                    { new Guid("11bbdfb0-5e51-4298-83d8-02643d50e003"), "062", "2251300301840901", null, null, new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43"), "11/20" },
                    { new Guid("11f7f5d0-869d-4158-85fb-7434ccb3fdf7"), "786", "5948201802454147", null, null, new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab"), "09/06" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("1218ec33-c595-46a5-ac3e-598f561ab1e5"), "541", "9081819033731444", null, null, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a"), "05/17" },
                    { new Guid("123ac125-3ae1-416c-9077-7e7eec672711"), "708", "3559706392725101", null, null, new Guid("f819889a-570b-4521-a36f-42d900233678"), "12/03" },
                    { new Guid("124e9051-e3a1-4236-98a2-3da8bb2a4c01"), "940", "3145120941363116", null, null, new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3"), "01/21" },
                    { new Guid("12bdbdef-f6bd-4634-897b-ccff17877245"), "840", "8121990584713723", null, null, new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c"), "01/26" },
                    { new Guid("1333bdf2-0b4d-4edf-9913-7b64d8461e64"), "706", "2172136638718339", null, null, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6"), "01/23" },
                    { new Guid("148f5c2f-e035-4ec6-af16-a710b7cec514"), "135", "1096384411342205", null, null, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0"), "08/22" },
                    { new Guid("14e7c65f-5cff-46d4-93d0-c8a6b53e267f"), "005", "8240217656358765", null, null, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44"), "05/24" },
                    { new Guid("15006214-1ba5-4d29-9da6-9daf6175b4f1"), "277", "1587134814646766", null, null, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46"), "11/26" },
                    { new Guid("15170789-fcb6-4b25-b401-178ed0d9029b"), "163", "2592403834214922", null, null, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e"), "03/05" },
                    { new Guid("15272f10-4729-455c-b49a-add00f48c6f7"), "205", "6936143942677490", null, null, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f"), "09/16" },
                    { new Guid("15312c51-4c86-4f86-8fab-270147b6f535"), "319", "2365980016740427", null, null, new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512"), "05/24" },
                    { new Guid("15982154-1cc6-46bd-a9f0-a405248af340"), "742", "3447843103441980", null, null, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071"), "07/18" },
                    { new Guid("15cebf65-681a-4a8f-8473-ff8ed83cd4d5"), "598", "1402637706541779", null, null, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500"), "04/14" },
                    { new Guid("15d036aa-b41b-4c8c-9c6c-dffd3d57c1ba"), "191", "7115516919328167", null, null, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7"), "12/07" },
                    { new Guid("15efb7c0-3c7a-4969-8cfa-739c7b0c4537"), "389", "7710018983670708", null, null, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a"), "01/03" },
                    { new Guid("160a860e-eeb5-4f2d-8c80-8a56ab0a57c5"), "829", "4268634507181049", null, null, new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2"), "11/15" },
                    { new Guid("161a40b8-c2ce-4899-9d1e-c6aa43f7a209"), "165", "9412294903125342", null, null, new Guid("36b35b89-da67-408b-9178-d5d020a70822"), "05/22" },
                    { new Guid("169a91a2-ed96-4c79-82b4-362c93acdbd7"), "958", "4709009160098207", null, null, new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), "01/24" },
                    { new Guid("16fc33a1-8b56-4b86-9c52-2894a21e1d20"), "041", "2231273223298627", null, null, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399"), "01/12" },
                    { new Guid("171207e7-a50a-4383-944d-135b1f1e1250"), "448", "3091640857285738", null, null, new Guid("11712f31-db09-482e-bdab-2c19dff98304"), "07/06" },
                    { new Guid("179048af-9a3d-49c8-a0e5-51e67fe3d998"), "674", "8964818831813440", null, null, new Guid("5967c8b0-b331-4553-bab0-23d04868d703"), "03/15" },
                    { new Guid("179e01c2-4378-4191-a940-8d38cbba6d9d"), "499", "9951452864368567", null, null, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff"), "01/19" },
                    { new Guid("17b333aa-443a-4bf2-8073-28822d459893"), "041", "4985490315271506", null, null, new Guid("f443c798-1151-4757-94ca-517bef15e381"), "11/27" },
                    { new Guid("17c0897a-a12d-4458-b6c0-437550171a66"), "298", "5617822283760452", null, null, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53"), "10/15" },
                    { new Guid("17d39118-d6ca-4735-af8e-ac32c4cd6891"), "094", "1494515124477551", null, null, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff"), "04/02" },
                    { new Guid("18db75e5-993e-4994-a57e-aac311d14218"), "581", "3045483876740703", null, null, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8"), "06/28" },
                    { new Guid("19008922-235b-47dc-be2e-1eb1590d85dd"), "764", "6382816773002341", null, null, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97"), "03/19" },
                    { new Guid("1936c5c4-59bb-4e77-bfc1-4e74fa33b72d"), "391", "7475062934874407", null, null, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc"), "10/20" },
                    { new Guid("1941d890-6138-4abe-b8e9-fb3c1494a864"), "415", "5627648608380047", null, null, new Guid("f485798d-1525-429a-8e8b-8604e1673c1b"), "02/15" },
                    { new Guid("1950195d-e896-4ac2-9c4a-47195395e2c8"), "530", "2555955296631224", null, null, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742"), "08/07" },
                    { new Guid("1a0632b8-3d50-471c-96ad-6ac2a5d79558"), "004", "8598100617321537", null, null, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285"), "11/06" },
                    { new Guid("1a37e254-8ccc-499b-b429-2e90c8d95ca4"), "340", "6678283480002712", null, null, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5"), "08/09" },
                    { new Guid("1ac42af8-285b-4c63-b931-3a47ddb97034"), "333", "3117881018261299", null, null, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000"), "01/13" },
                    { new Guid("1bb16aac-bc60-4886-b4c3-cc98aea6b5a9"), "414", "2369796984788657", null, null, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838"), "07/17" },
                    { new Guid("1bec1728-de5f-4e08-ba2d-4cc85fe08eae"), "017", "1895884458457625", null, null, new Guid("e908834c-4383-4b44-a138-de5de4aa621a"), "09/09" },
                    { new Guid("1c063864-8a42-482f-9701-b042d0d8e8b4"), "938", "5068631732030619", null, null, new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128"), "04/10" },
                    { new Guid("1c755de0-99a0-4b42-b644-18b7d01dc625"), "214", "6087712014937917", null, null, new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43"), "06/22" },
                    { new Guid("1d0a89ce-fe3e-4c8d-afb9-c796e6def788"), "040", "8189369481059621", null, null, new Guid("26db4c52-c906-415a-848e-eb60cadca362"), "10/20" },
                    { new Guid("1de35001-cd51-468b-8225-21d68f520653"), "085", "8522161680210989", null, null, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53"), "11/05" },
                    { new Guid("1eb025f9-877c-45b5-b44c-6a69d7c44589"), "619", "1436134008767705", null, null, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17"), "12/09" },
                    { new Guid("1eb7eb04-544a-492c-99df-5c17cd19eb80"), "759", "3441285012146416", null, null, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2"), "12/17" },
                    { new Guid("1eee32dd-8645-4263-a2bf-1ce064164855"), "445", "2439044997980409", null, null, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec"), "12/08" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("1f07e9dc-86a0-4cd3-aeee-aad1cc0585a4"), "901", "2775134634559818", null, null, new Guid("77941635-e388-4774-9d8a-53d61f8a1c10"), "06/04" },
                    { new Guid("1f4e3480-9df2-493a-8ce7-5570482b1cd0"), "561", "6447282680696420", null, null, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede"), "07/23" },
                    { new Guid("1ffb9d05-ca28-445f-8341-ee1a5a76d74c"), "994", "1425079274557618", null, null, new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c"), "10/13" },
                    { new Guid("2039200b-2268-49a0-a1b9-2e7af7bbcaa9"), "755", "4632501848718458", null, null, new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a"), "12/22" },
                    { new Guid("20e53b23-3e4a-4af4-9a68-4bcb50ec7231"), "714", "1879265677961847", null, null, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a"), "07/12" },
                    { new Guid("20f34448-0085-4e3a-98df-caf84844cf0a"), "584", "2132066142472908", null, null, new Guid("77941635-e388-4774-9d8a-53d61f8a1c10"), "01/21" },
                    { new Guid("20fa68ed-ebc1-4bf9-98f7-e4ea5e87eb5d"), "545", "3131259623960282", null, null, new Guid("bb76498f-37b6-48d3-b979-97246498ed03"), "08/08" },
                    { new Guid("2109ed1d-91a8-42bb-81a9-1fe7c01c940f"), "204", "5465878722785715", null, null, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f"), "02/17" },
                    { new Guid("21543826-cf32-4a46-a432-c06b8f4b90d8"), "642", "2294853236170514", null, null, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a"), "04/24" },
                    { new Guid("2155b4fc-c409-450a-a022-e7cbfaf8ae37"), "114", "9288512774811245", null, null, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d"), "08/14" },
                    { new Guid("216e971e-6585-4cc1-ac06-1089a0b2d8f6"), "589", "3830535605222032", null, null, new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), "07/23" },
                    { new Guid("2197ed0c-9994-4224-827e-eb219d3054e2"), "157", "1268213289312433", null, null, new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed"), "05/04" },
                    { new Guid("21c1c157-8e5b-4f3b-84f3-6cd43362dfff"), "470", "2962691323926290", null, null, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e"), "02/13" },
                    { new Guid("2243628e-3c21-4fd4-88d0-aa7152768e56"), "751", "7199694258358706", null, null, new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07"), "08/13" },
                    { new Guid("22e3099f-8c22-4826-b444-f1f34d0d9001"), "438", "9405514387410972", null, null, new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), "01/02" },
                    { new Guid("23ae024b-c32d-4141-81a4-6c7686a0dd50"), "218", "7508447721686909", null, null, new Guid("1909a070-eed8-440c-9e1c-16073e761c90"), "08/28" },
                    { new Guid("24190e9a-3ec5-4ec6-b7f4-0342fb87a323"), "494", "7178824875354805", null, null, new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a"), "06/06" },
                    { new Guid("24994499-3db2-4db2-88df-8ecc8dd63e13"), "509", "5066956210925562", null, null, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89"), "04/03" },
                    { new Guid("24e92f6f-3b5f-4f41-bac8-90f8d8ce17c1"), "649", "9741856126433790", null, null, new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2"), "12/19" },
                    { new Guid("24f98d36-99e8-457c-be4f-d6dddf111366"), "840", "8534152206128158", null, null, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357"), "03/09" },
                    { new Guid("25b76004-b3d4-4e5b-a9a8-31396462abfe"), "953", "9245405225658833", null, null, new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2"), "03/01" },
                    { new Guid("25fe9cc0-2a43-4a56-affb-729535774142"), "105", "6893172660889333", null, null, new Guid("489038c7-0441-436a-a527-66069a8b1473"), "06/09" },
                    { new Guid("26018e6d-1355-427e-9bcf-3c8af726b0b2"), "801", "6637065228741208", null, null, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14"), "09/27" },
                    { new Guid("26028ebe-287a-44b3-93d2-b07311339905"), "578", "3135092656913604", null, null, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a"), "09/21" },
                    { new Guid("26853643-1549-4ceb-9f76-c0f619359eb7"), "229", "5688592738064623", null, null, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337"), "02/24" },
                    { new Guid("26949053-6c27-475b-ae7b-6968325aca30"), "634", "5827253196613352", null, null, new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c"), "03/26" },
                    { new Guid("26a949f7-9ee3-4a74-a0f8-79ef6a978483"), "777", "8232174220251902", null, null, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32"), "06/23" },
                    { new Guid("26cf8a44-dc45-4324-baa1-62ac35b3a994"), "348", "7206581821441331", null, null, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d"), "03/19" },
                    { new Guid("27003482-f9e9-4fc9-a540-b78ba9ebd892"), "075", "8231420677715263", null, null, new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1"), "05/03" },
                    { new Guid("270e1f38-d868-402b-9303-2d6ac9bc7302"), "120", "9577976728353035", null, null, new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa"), "02/26" },
                    { new Guid("2710f3e5-0a9c-40e7-aed3-13a8c48a8d7b"), "286", "4730826851697088", null, null, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6"), "10/10" },
                    { new Guid("2760bbdd-58cc-4e9e-a126-559aaa7855c1"), "703", "2734231248912973", null, null, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565"), "08/22" },
                    { new Guid("27a7902d-ed5d-4388-a34a-d44953384330"), "131", "4757280407956335", null, null, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742"), "11/06" },
                    { new Guid("27a9f5e1-bfec-40ee-a573-43fc188ee69a"), "704", "4088042406436933", null, null, new Guid("234cf821-c69e-41fd-b13e-68660060a87e"), "02/13" },
                    { new Guid("27dbe884-27bf-431b-a383-1881b47a953a"), "679", "1303203650021188", null, null, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12"), "06/01" },
                    { new Guid("28253968-9ddd-44cc-b962-a07a7e9f9895"), "497", "3835517911675990", null, null, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da"), "05/10" },
                    { new Guid("287db3ce-975f-484b-9bfd-effaa20ff6d2"), "922", "2890716906360437", null, null, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec"), "08/04" },
                    { new Guid("28baa829-cd11-4544-a1dd-7fc85de6bae7"), "444", "8422507649821564", null, null, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020"), "04/03" },
                    { new Guid("28fbf5d6-aa54-42fe-ae4c-a929a2c79b4e"), "976", "5859342018677160", null, null, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e"), "09/09" },
                    { new Guid("2a09b125-864f-4744-bf27-ce12abf81ac4"), "098", "9882612196952204", null, null, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d"), "02/07" },
                    { new Guid("2a3c417d-8e8a-4225-82b4-f229dd13637c"), "829", "5809072463527137", null, null, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc"), "02/05" },
                    { new Guid("2aa063b8-2baf-4a5c-9684-00732d469e2f"), "356", "1144650987671317", null, null, new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3"), "08/16" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("2b7bf6b1-5bdd-435a-a729-7d6d73ae0be4"), "112", "4873502528133265", null, null, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a"), "10/14" },
                    { new Guid("2ba8ecf4-b8b3-4d25-ba8f-49b4fd2cae38"), "754", "1225765948192892", null, null, new Guid("41bf7410-7941-4fca-a717-3874d970309c"), "10/18" },
                    { new Guid("2c6bc8d7-f6a5-4702-8010-f08f551e60b2"), "680", "8952158861683431", null, null, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da"), "02/04" },
                    { new Guid("2c756c68-dede-4583-a7c2-511d7e3240de"), "704", "9543863577191985", null, null, new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f"), "01/15" },
                    { new Guid("2c8be0e1-177c-4f13-afb8-b2f50f2a2cc2"), "395", "2499771151981781", null, null, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7"), "07/28" },
                    { new Guid("2de23e80-b6fa-4a8f-afda-f979dd6dbef8"), "661", "7463965252606050", null, null, new Guid("e87e502a-19b0-4f23-969d-aabf313d6591"), "11/12" },
                    { new Guid("2e266e07-aaa8-47b3-8d9c-b2bcf51d2357"), "312", "9244702405832542", null, null, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3"), "10/27" },
                    { new Guid("2e3d4b78-2338-4eec-b8f8-f686715c6036"), "934", "6891374994881191", null, null, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0"), "01/25" },
                    { new Guid("2e47d636-6112-4349-a379-97dcf21d8ce5"), "037", "8891653499128831", null, null, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db"), "05/14" },
                    { new Guid("2e7b0de2-0740-49b1-bf7a-e87392425520"), "409", "3254139651123783", null, null, new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3"), "08/15" },
                    { new Guid("2ef5ac1f-6719-429f-983a-35c86eb7e5c1"), "268", "2196411826800434", null, null, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357"), "01/05" },
                    { new Guid("2f21a342-e2cd-43b4-b5b2-fb882f61e87d"), "486", "5184440830112535", null, null, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a"), "03/17" },
                    { new Guid("2f4cba1e-b607-4c9c-bce9-4a37d43730a7"), "364", "5716014529849312", null, null, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3"), "07/09" },
                    { new Guid("2f5b7a6e-5aa2-41b7-b0b8-3b8919c1a1ea"), "347", "7801584988964298", null, null, new Guid("234cf821-c69e-41fd-b13e-68660060a87e"), "07/01" },
                    { new Guid("2f8e14bc-ab31-4a33-865d-3d1a114deb3b"), "469", "5532573061522483", null, null, new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4"), "04/27" },
                    { new Guid("30863df8-7a2b-4fa9-adfb-c0335eb3cc9c"), "666", "5419478299504599", null, null, new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803"), "02/01" },
                    { new Guid("30e4a487-734b-4583-9320-823fc8b14e3b"), "080", "6901095807160384", null, null, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2"), "04/05" },
                    { new Guid("30fa1723-5ee2-463f-8eb6-7a5da605c313"), "243", "1225778402108458", null, null, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000"), "07/23" },
                    { new Guid("3104b461-be56-4345-94ca-647d2d208f84"), "977", "5428925301434325", null, null, new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e"), "10/18" },
                    { new Guid("31399b76-86ec-4a81-be02-73268614384f"), "302", "9179299131511416", null, null, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93"), "10/16" },
                    { new Guid("31410b9d-98d9-4cf4-a36c-1435dd0e867a"), "985", "5688069680300514", null, null, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef"), "06/09" },
                    { new Guid("31691e1d-d22f-4e50-bf04-d99f8237cc51"), "955", "1451802544455947", null, null, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835"), "11/07" },
                    { new Guid("31a206b8-74c1-4760-804a-ef43ecb3ea1b"), "210", "6672275652997868", null, null, new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f"), "12/18" },
                    { new Guid("31cf1850-a5d2-44d9-8e6b-3a6728984f26"), "451", "7554841768621129", null, null, new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f"), "07/02" },
                    { new Guid("322f759a-c96e-4dd7-adb1-02f295ca2c41"), "782", "9540559222605436", null, null, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2"), "01/25" },
                    { new Guid("32533cd7-c282-4ce5-afbe-82ede3efe09b"), "764", "5799106462057706", null, null, new Guid("3525c903-c292-4d3e-942f-aeae98225a62"), "08/05" },
                    { new Guid("325cd4d4-5131-4229-b50f-fcb4e0860426"), "091", "1956272155550446", null, null, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27"), "12/08" },
                    { new Guid("32605a74-b8ff-491b-a599-c7949d501d12"), "122", "3910646401085521", null, null, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d"), "03/04" },
                    { new Guid("32e1ab51-b966-4fee-ae2b-024207ca9d52"), "155", "6455460632818438", null, null, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16"), "03/01" },
                    { new Guid("32f449b3-670a-4ffc-8d60-afba0a162dc8"), "888", "2643990775499685", null, null, new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f"), "12/18" },
                    { new Guid("331e12cc-3910-4512-a56d-f183a4ca8983"), "496", "3101646340809398", null, null, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf"), "02/23" },
                    { new Guid("3346cd62-6e0c-4024-8629-006f6a643f15"), "521", "8489220804360906", null, null, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea"), "02/06" },
                    { new Guid("340d96d4-c2ea-4ebb-a997-bc574b557ec8"), "538", "2276322802614437", null, null, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14"), "02/26" },
                    { new Guid("34af90df-bfa8-4ca1-add5-d81844e964de"), "274", "3908717910907209", null, null, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad"), "02/28" },
                    { new Guid("34be905f-13b0-4b15-8859-22e9424bec50"), "776", "7040758423538862", null, null, new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf"), "01/02" },
                    { new Guid("34c3bc2b-a766-498c-acbe-6a4031055bd9"), "301", "4537159672837801", null, null, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16"), "03/21" },
                    { new Guid("3516ce35-3440-417a-b23e-fe608a6ff02b"), "747", "2698596454299029", null, null, new Guid("5db09bf3-8454-4fff-bfe9-003854416f82"), "06/16" },
                    { new Guid("35306626-3d1e-47c8-98e0-5d1f76dbf9d9"), "626", "5887050335802953", null, null, new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2"), "12/04" },
                    { new Guid("35c5fcb3-9157-4de7-9d6e-2b4cec318613"), "283", "4695398740329907", null, null, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32"), "02/28" },
                    { new Guid("35ca25f9-017e-44ea-863a-09660146da98"), "058", "6453263671174890", null, null, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5"), "06/22" },
                    { new Guid("35d8d790-a9da-47c5-9f81-d3c9ca760e46"), "788", "9195719826695587", null, null, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a"), "02/22" },
                    { new Guid("36214306-c3bb-4a66-ae24-a417a42013c7"), "669", "7467999466825980", null, null, new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5"), "06/13" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("362e21dd-c1af-4950-b403-76fe2c254dcb"), "520", "1255919518690127", null, null, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e"), "02/13" },
                    { new Guid("372e28bf-f76e-4252-83a6-ef43575d4f19"), "008", "3171503516969217", null, null, new Guid("8c396faa-ad98-400d-a562-77b4902806e1"), "11/13" },
                    { new Guid("37880f22-462a-4009-9208-3030dfefb7df"), "102", "7815325193340856", null, null, new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf"), "05/19" },
                    { new Guid("37be2aa5-68d6-47db-88b0-e003da3e624f"), "936", "3554416540676045", null, null, new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3"), "12/14" },
                    { new Guid("381c81c2-62f0-4003-a4c4-caf1708850d7"), "618", "6721167123577542", null, null, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb"), "09/12" },
                    { new Guid("382e49c4-cc2f-4e6f-9f44-a1d98a9f1c32"), "718", "5097468541759255", null, null, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a"), "03/14" },
                    { new Guid("3914c3ca-a96a-4397-afe4-d88a77a3559f"), "860", "4715501844993696", null, null, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000"), "04/01" },
                    { new Guid("3940c02a-695c-4a0a-b9c0-78f0bf399cce"), "706", "6539920780687355", null, null, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80"), "01/04" },
                    { new Guid("3985ba04-bd1c-411c-bc41-fc1567206841"), "915", "4436871688498919", null, null, new Guid("bb76498f-37b6-48d3-b979-97246498ed03"), "08/24" },
                    { new Guid("3a5189ab-01a8-41be-91ba-da1a6c709476"), "327", "9636446766916160", null, null, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46"), "05/26" },
                    { new Guid("3ada81ac-deac-4735-a8dd-d5d1dd5faf3f"), "186", "6952470672070116", null, null, new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1"), "02/02" },
                    { new Guid("3b736339-3086-47d8-96d6-08c373e0365f"), "298", "5725192495569770", null, null, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826"), "03/03" },
                    { new Guid("3c02599f-3f36-482a-9503-69d5b0d08aeb"), "660", "9818300213212064", null, null, new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a"), "03/18" },
                    { new Guid("3c37b270-87f4-4cf3-88a1-092783c8f0e7"), "640", "6841008652907038", null, null, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a"), "04/06" },
                    { new Guid("3c3ea8aa-0af6-4eae-9ce9-ac769c5fc5d6"), "889", "9263245661933765", null, null, new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084"), "05/15" },
                    { new Guid("3c8d054b-9bd7-40b8-84a2-5991a6a02169"), "091", "7483967310160264", null, null, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3"), "03/05" },
                    { new Guid("3cc3f9f3-f65a-4fe1-9683-4461f7b93698"), "259", "8767526882287423", null, null, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8"), "01/24" },
                    { new Guid("3ce5615a-e515-4ab2-8c28-4190d741638d"), "381", "8818740115788565", null, null, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f"), "04/19" },
                    { new Guid("3ce8bb85-0474-4062-ae83-2462f7d6cc3f"), "273", "9836390325608590", null, null, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00"), "10/02" },
                    { new Guid("3e02fa15-bc26-4f6b-a78f-398ea7d5f906"), "666", "9798995000028948", null, null, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e"), "11/21" },
                    { new Guid("3e8b13e0-5877-4e26-a06d-6fd4f6f2d08e"), "606", "4742151809545180", null, null, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d"), "01/10" },
                    { new Guid("3eba7387-ed9e-49a3-b65a-d269158b588e"), "112", "2863816239441986", null, null, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93"), "07/05" },
                    { new Guid("3f10f8cf-54f0-4747-9ea9-f84089df26be"), "308", "3640475661092050", null, null, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a"), "05/09" },
                    { new Guid("3f3edcd1-8955-4055-9a79-d05a4917795d"), "759", "2714067106414009", null, null, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc"), "01/24" },
                    { new Guid("3f487738-707b-4ca7-813b-a11924a9fde0"), "411", "4362732793188400", null, null, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5"), "05/22" },
                    { new Guid("3f7bedbb-8cf1-4e1e-adb5-078781e41225"), "530", "9213632247369086", null, null, new Guid("757e8d68-6931-451c-9e0e-78a03f927058"), "05/07" },
                    { new Guid("404f9656-61d3-48d2-8617-8f35c84b0a7d"), "378", "1761099195822010", null, null, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724"), "09/16" },
                    { new Guid("406b3eb0-a6ef-4d50-be77-70d9087d9c5d"), "150", "3826949098705260", null, null, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940"), "02/28" },
                    { new Guid("4072d42a-72ea-4430-9aaa-d14924c99d66"), "390", "3814164138732147", null, null, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399"), "10/28" },
                    { new Guid("40d0daf1-3b0c-4b21-8a52-051ba5cc042a"), "177", "5421561171396462", null, null, new Guid("223295f7-9195-4510-8bcc-44f043830497"), "04/17" },
                    { new Guid("40f8a62c-cafd-4265-ae5b-72113a96faa5"), "500", "1597669351595650", null, null, new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed"), "02/16" },
                    { new Guid("411fc05f-447c-4a34-b36b-83907076af4d"), "494", "2341520510795149", null, null, new Guid("62780013-8c47-4235-a42a-798d9bf04220"), "08/13" },
                    { new Guid("415d5dd9-cce7-40d6-8a0a-24d39a6e1904"), "956", "9932525738806676", null, null, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a"), "02/21" },
                    { new Guid("4193c89e-56d0-4c87-8c3c-cc3b47937e25"), "073", "5235488129237458", null, null, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f"), "02/06" },
                    { new Guid("41989464-7aee-4a83-bb03-f5cfe8eb1369"), "293", "5851949746389667", null, null, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7"), "02/07" },
                    { new Guid("41c0efcf-e2d0-4d8f-ac98-f84369b31faa"), "155", "2406306323859020", null, null, new Guid("35263c47-5006-4ddc-a824-47120f6a334d"), "12/26" },
                    { new Guid("41cd3a4c-a307-47d6-96a6-1e940613a031"), "482", "7388180591536801", null, null, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9"), "12/28" },
                    { new Guid("41de554b-2c16-4d11-b728-63b8c4fc36f6"), "736", "6122375934478027", null, null, new Guid("e50b5106-c89a-489a-b970-99024a53f892"), "08/28" },
                    { new Guid("41e0042a-2cb1-4f62-8816-5426a8851b13"), "988", "2314264798031548", null, null, new Guid("0ec20584-d26f-41c4-b682-05916743e30a"), "10/06" },
                    { new Guid("41f5936c-d4aa-49ff-a7af-f65ba76762b1"), "522", "3328502951018391", null, null, new Guid("c8507284-511b-425f-9aab-13ef42992af5"), "02/21" },
                    { new Guid("424c0179-c04d-4beb-8319-8bbe1c9eb0e8"), "857", "3124402620498589", null, null, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00"), "03/16" },
                    { new Guid("42839e3a-99ac-429f-847b-21424e500f79"), "372", "4067814844805088", null, null, new Guid("e87e502a-19b0-4f23-969d-aabf313d6591"), "02/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("42cdab52-3c0e-455d-a015-ec548261df5f"), "162", "8174635555374717", null, null, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58"), "02/24" },
                    { new Guid("432734cf-655e-491b-960d-9fb112259ef8"), "730", "4946697521444339", null, null, new Guid("3525c903-c292-4d3e-942f-aeae98225a62"), "05/06" },
                    { new Guid("436d5781-9c57-48d7-9e89-c4cf0452a8c7"), "659", "5077910189541418", null, null, new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1"), "11/11" },
                    { new Guid("4388b664-d5b4-4d44-8beb-02d80554feb9"), "117", "4247719591691398", null, null, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357"), "01/28" },
                    { new Guid("43b8e73f-c565-4d34-b6c5-abadaf2fdc6b"), "942", "2920316942854331", null, null, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc"), "01/17" },
                    { new Guid("43fcdbad-8108-4415-9ee8-846fb6ba0664"), "899", "9888967917687000", null, null, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7"), "11/26" },
                    { new Guid("442a72cc-0c1c-42ce-8d95-f64816bc6aa3"), "972", "6264321775914695", null, null, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3"), "09/25" },
                    { new Guid("44e3952f-c581-4753-9b57-a2a778eb6187"), "382", "2139433232214142", null, null, new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae"), "05/02" },
                    { new Guid("452dc8bd-b2ba-4f57-ab17-68f679b9995c"), "153", "4166221800919067", null, null, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f"), "10/14" },
                    { new Guid("45764385-e938-40ec-a900-a9e878835432"), "537", "5948205919263571", null, null, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec"), "08/22" },
                    { new Guid("459cc993-40bf-4cb1-88e6-d7ba2968aeea"), "090", "7113010631521506", null, null, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7"), "08/20" },
                    { new Guid("46492ed1-35b7-4a8a-8294-94ad733459d6"), "778", "9926926444799308", null, null, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f"), "08/12" },
                    { new Guid("46901b28-3e85-4ec5-a3e5-b54aecc6a203"), "808", "4790009588476199", null, null, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684"), "06/04" },
                    { new Guid("470ec7bd-827e-4b1c-a7a9-f2a96876fb42"), "459", "8969135038707464", null, null, new Guid("234cf821-c69e-41fd-b13e-68660060a87e"), "02/27" },
                    { new Guid("4721fbdd-41a6-44dd-988d-9c0b16875e89"), "163", "3934459267442566", null, null, new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3"), "09/19" },
                    { new Guid("473d2a20-78be-4ae8-8c48-342d25a80e22"), "164", "8619777775580982", null, null, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0"), "07/12" },
                    { new Guid("4750ebab-1dcf-4d82-8154-b6e2270f941f"), "648", "8921917916810949", null, null, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32"), "12/08" },
                    { new Guid("47d3a63e-8f22-4ca7-b0ac-e39b97eff8ae"), "731", "3316462292937671", null, null, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a"), "01/09" },
                    { new Guid("47f11805-82c9-4da8-9a7c-27ecc0e988f5"), "776", "1730165641248683", null, null, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2"), "03/20" },
                    { new Guid("4807df3c-6ae9-4e16-a5f3-bfa6ddec7386"), "944", "9204544445437952", null, null, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef"), "08/09" },
                    { new Guid("482d20ca-6817-4bb4-8eba-cebfe3363e9d"), "719", "9556449406888136", null, null, new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938"), "11/12" },
                    { new Guid("48d92e83-c1b7-411a-9d7d-a82a13fe09fc"), "493", "4773096878592895", null, null, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe"), "07/14" },
                    { new Guid("49521b95-ef8d-45dc-ac76-018dfe3b73ea"), "178", "4201630983749933", null, null, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696"), "05/18" },
                    { new Guid("496676dc-ee18-4f7c-aa1b-4efbb7755f68"), "565", "7268171168504678", null, null, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d"), "08/23" },
                    { new Guid("49e0cd16-414f-43cf-b13d-98287c44885f"), "030", "8221813373963426", null, null, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32"), "01/05" },
                    { new Guid("4a46a9eb-0c23-4734-abe9-cd603167eb92"), "441", "6479421770524443", null, null, new Guid("5967c8b0-b331-4553-bab0-23d04868d703"), "04/01" },
                    { new Guid("4bd73062-01d1-4102-81c9-6c5d3043a119"), "646", "8465204656864569", null, null, new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8"), "10/01" },
                    { new Guid("4c8fe3b5-827c-464d-9acc-5311af926b55"), "612", "1754714558029338", null, null, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9"), "05/03" },
                    { new Guid("4cd1ae5f-32d6-4375-b0bb-bb22b2aa7889"), "758", "2907493775154588", null, null, new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2"), "03/12" },
                    { new Guid("4dc300ce-9a8b-42df-a8b4-356972bcd94c"), "162", "7878363234849333", null, null, new Guid("11712f31-db09-482e-bdab-2c19dff98304"), "04/02" },
                    { new Guid("4ddf2963-c704-4d2d-aac6-355568999b32"), "954", "3375217003190259", null, null, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da"), "12/07" },
                    { new Guid("4dee0d09-92d8-486b-9db2-80e3dac99895"), "554", "5116245496322803", null, null, new Guid("95f06adb-a1fa-40bc-8351-b298d818044d"), "12/14" },
                    { new Guid("4e13fb90-98b9-4d90-8e6a-e5f313129260"), "313", "3403694399524798", null, null, new Guid("ceb699bd-8c01-4831-9438-e8c30f353919"), "08/27" },
                    { new Guid("4e343560-9af6-4cb7-b3f3-a39179c7a34f"), "406", "3936955683698982", null, null, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad"), "03/03" },
                    { new Guid("4e56d54e-4e0b-45b2-809e-773e76ea876a"), "939", "8069289223985044", null, null, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e"), "05/14" },
                    { new Guid("4e5bf089-d888-480d-8787-753edc5bcc9b"), "558", "4749388317968810", null, null, new Guid("4e8e0581-239d-4586-9cca-aad850d7d329"), "10/15" },
                    { new Guid("4f2475a0-047e-464c-afd3-92e9c14fc88c"), "741", "6666494225427920", null, null, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b"), "07/11" },
                    { new Guid("4f70079f-cc1b-4260-ab5d-dc8246fa6a5f"), "256", "2823393980132745", null, null, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399"), "05/24" },
                    { new Guid("4fa1088f-4c0e-4540-85c5-41217542f596"), "058", "4233287128534447", null, null, new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69"), "12/01" },
                    { new Guid("4fcdc65b-9cc6-48af-b05b-f35b432a2d23"), "720", "7474599754099361", null, null, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e"), "01/26" },
                    { new Guid("4fd6eb18-44b5-4325-8067-b318ac80e1b6"), "852", "2198996455054033", null, null, new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f"), "06/20" },
                    { new Guid("5026e76e-11d7-41de-ae4b-d757fd4a352a"), "527", "5557577433909546", null, null, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e"), "06/13" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("50553c8d-250b-4de9-ba63-617dab3b9036"), "505", "3971669264737096", null, null, new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867"), "11/28" },
                    { new Guid("507a2e60-ce61-4fbe-afd3-76bfc309d3fa"), "840", "5395100534548408", null, null, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc"), "07/07" },
                    { new Guid("510762d2-cabb-4169-996f-5e53d83ea004"), "698", "4980406195682259", null, null, new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b"), "08/28" },
                    { new Guid("5161cfb7-aa2e-49df-b055-ae65e1efbb40"), "898", "4647162427596870", null, null, new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca"), "06/16" },
                    { new Guid("518bb80b-e4b6-430b-9c9b-fb9380b02b0c"), "178", "2291470552077798", null, null, new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f"), "01/21" },
                    { new Guid("51cae55a-33dd-4a96-b33a-d6d786130fe9"), "081", "1069859682776651", null, null, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb"), "10/01" },
                    { new Guid("51f0a2b1-5c3c-4023-815b-ae6f7b8a1924"), "866", "1194767806122155", null, null, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea"), "10/24" },
                    { new Guid("51f91488-1144-42f9-b50c-65a72a50eeee"), "453", "9178445830121398", null, null, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091"), "07/18" },
                    { new Guid("520e0c29-43cb-4ba4-a491-d0545319f185"), "060", "6692363485084087", null, null, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9"), "04/06" },
                    { new Guid("5265fa2c-5c9b-4062-b8fb-eb36762666fa"), "243", "2793898787801915", null, null, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58"), "08/26" },
                    { new Guid("53047299-9456-452d-bae8-bb4e8b79d8c9"), "402", "9193288653302299", null, null, new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888"), "07/11" },
                    { new Guid("532d2725-706a-4054-a0ac-33f5ca11b3aa"), "265", "6343893294829106", null, null, new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4"), "01/02" },
                    { new Guid("53ca10ac-24ce-43a4-b1a9-a567f9063903"), "250", "8649034279724598", null, null, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7"), "06/27" },
                    { new Guid("53f1e0af-0c49-4882-8e8f-4ea15f5900f5"), "295", "7472605757710503", null, null, new Guid("4e74259f-0264-4f06-8e5d-85d289652986"), "08/18" },
                    { new Guid("54422ff4-a71b-4918-b986-1230c24b5d16"), "095", "7615054921210743", null, null, new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a"), "01/20" },
                    { new Guid("54fa8de7-0e40-4eae-a3ec-a675283ae799"), "525", "3656174213662690", null, null, new Guid("62780013-8c47-4235-a42a-798d9bf04220"), "02/04" },
                    { new Guid("558a7356-bd0c-49d7-bf95-90ef7f85d4a8"), "046", "3589130072452938", null, null, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3"), "12/10" },
                    { new Guid("5591af7e-bd8a-4fd9-8d15-e0ced37b5091"), "098", "2246625958831985", null, null, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a"), "10/01" },
                    { new Guid("55da41e7-f86e-441c-9cf9-523798c7b6aa"), "968", "9466477827692965", null, null, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1"), "04/20" },
                    { new Guid("56a91a5a-1705-48a7-9ab8-4b8617d36bb2"), "727", "4992518178376575", null, null, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562"), "01/08" },
                    { new Guid("56ba9852-99e8-4e2a-b6c4-efe99838e376"), "367", "9889440279693073", null, null, new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9"), "09/26" },
                    { new Guid("56c5feac-bdab-432b-bef7-8c953d346bf5"), "281", "7510278865786492", null, null, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe"), "02/28" },
                    { new Guid("56ed5600-6b3d-4384-8fe6-4e00ae294759"), "643", "7384155244474231", null, null, new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084"), "11/17" },
                    { new Guid("56fd59ed-53ad-4bda-b199-07f80d0f3323"), "307", "3920028457831095", null, null, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce"), "07/05" },
                    { new Guid("5707ac00-449a-4bd0-b2f0-f38d31d51b21"), "275", "1200441297049320", null, null, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe"), "06/02" },
                    { new Guid("57197eeb-3d77-4f57-a503-527c837e45dd"), "755", "8245047463311165", null, null, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0"), "04/04" },
                    { new Guid("57985ed3-c6db-482b-92de-f33082799c39"), "123", "9701053166098214", null, null, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6"), "12/23" },
                    { new Guid("58b03f22-8468-4f2b-9161-494f24a73611"), "163", "5306123399058349", null, null, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe"), "07/17" },
                    { new Guid("58f9ae54-8984-43fc-a78b-f318e1d5068b"), "724", "7656382689940673", null, null, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742"), "01/24" },
                    { new Guid("5916c453-dd3b-424c-af4d-877a6733665b"), "191", "3203497884899412", null, null, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6"), "07/14" },
                    { new Guid("5936016f-8831-49ff-bf47-4fe2cb41069c"), "588", "1298099435102466", null, null, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483"), "12/03" },
                    { new Guid("594f3258-4933-430d-974b-f36bc9dca77f"), "469", "1110615208545330", null, null, new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694"), "11/26" },
                    { new Guid("595bf6aa-a04c-4b48-951e-2fb162008155"), "319", "9744819984438028", null, null, new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7"), "11/25" },
                    { new Guid("5a06662d-6e8b-4bb7-a6f0-10882eb97382"), "528", "2544053399150286", null, null, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969"), "02/05" },
                    { new Guid("5ac27aaf-f9bc-40a7-98e3-a095cfde0ab9"), "247", "5862396745780081", null, null, new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4"), "02/03" },
                    { new Guid("5b2b21bb-ab21-40ef-9a0d-e64c6692ce34"), "084", "4046845394830812", null, null, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827"), "03/16" },
                    { new Guid("5b6be810-f372-404e-a1dd-e2ad1f85b10a"), "300", "5003915120045095", null, null, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd"), "05/05" },
                    { new Guid("5b7f80d2-1417-4d41-9975-25394704583a"), "553", "2795147259139601", null, null, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a"), "10/05" },
                    { new Guid("5b8f9b14-686e-43e6-a576-14385b92f738"), "412", "3533532067715715", null, null, new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d"), "09/02" },
                    { new Guid("5b975825-ace5-4161-90b5-6f0b149758f1"), "490", "2736842336637469", null, null, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca"), "07/25" },
                    { new Guid("5b9bd10a-bf4b-40cb-b104-c0491e5e8828"), "108", "9186286532108897", null, null, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17"), "11/24" },
                    { new Guid("5ba9979e-7706-462a-8335-7e941aed7b2d"), "682", "5579676197873778", null, null, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e"), "04/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("5c236b51-f971-41a2-987a-6279b8671fae"), "700", "7126290992282395", null, null, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d"), "03/25" },
                    { new Guid("5c826634-2e56-4d2b-bcd5-b34fe2b7e6a6"), "923", "5947606242442421", null, null, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9"), "07/24" },
                    { new Guid("5cb2b9fc-6662-48c3-bf4a-13b7651cea28"), "786", "2581366873539004", null, null, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562"), "09/25" },
                    { new Guid("5cba188b-948d-482b-8f87-6b7cc79c2b7c"), "506", "9287305641781112", null, null, new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a"), "02/09" },
                    { new Guid("5cc929f0-b393-4779-aed7-adcbcce7a268"), "783", "4171285667652398", null, null, new Guid("46075330-4d61-4bde-be40-948e47bd19fb"), "06/14" },
                    { new Guid("5d099f5f-b12b-4012-99fc-6d0278c9bd13"), "187", "7303530319926508", null, null, new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512"), "03/05" },
                    { new Guid("5d3916e7-25ed-4f07-a170-f22b3f556554"), "298", "2248840030903890", null, null, new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058"), "01/26" },
                    { new Guid("5d600593-7b87-40c0-9c81-2ac560c5ca81"), "996", "8335110809763977", null, null, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071"), "08/23" },
                    { new Guid("5d61f156-1afa-4b59-8fb0-61d3e0ae29a2"), "330", "4638067214080274", null, null, new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722"), "04/10" },
                    { new Guid("5e31a2c5-6a3a-4bb5-9f56-ce27059894fb"), "976", "4058509510304300", null, null, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9"), "01/11" },
                    { new Guid("5e5bd39f-d08f-4f34-80ce-5aa0c002d2b3"), "911", "9019617823238855", null, null, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d"), "09/25" },
                    { new Guid("5e60ecdd-a458-49e2-ae9b-7d3e2ae44f89"), "034", "7102735177394792", null, null, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7"), "04/23" },
                    { new Guid("5fc9ae39-21fe-46d9-b8c8-d0aa5b5d163c"), "171", "1612152165079011", null, null, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea"), "08/24" },
                    { new Guid("60464f82-1695-4345-83a3-791dc1cb154a"), "906", "1187351073115683", null, null, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5"), "05/09" },
                    { new Guid("606b3d8e-44e7-4405-a009-a1ce74ea4c2c"), "416", "4699699717042539", null, null, new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6"), "10/20" },
                    { new Guid("6077d9e4-97e5-42f5-9734-109db7e3c9b8"), "850", "3138970394012889", null, null, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1"), "04/16" },
                    { new Guid("6098ad9b-c2bc-4425-a385-fd61f3c8a371"), "283", "3922391922078191", null, null, new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a"), "07/01" },
                    { new Guid("60d195a1-eb56-4dda-b94a-5e74080f2694"), "349", "7300932250676858", null, null, new Guid("f485798d-1525-429a-8e8b-8604e1673c1b"), "12/10" },
                    { new Guid("60e94b84-1032-483c-893b-da8b9dd3a6b2"), "094", "3332521623395539", null, null, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d"), "01/26" },
                    { new Guid("60fe23a2-ac86-4fb4-ba89-d3f8c99acb56"), "293", "8866867044243798", null, null, new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722"), "06/04" },
                    { new Guid("6143996e-941a-4a82-8388-4a57543a2d51"), "511", "4984499760317258", null, null, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2"), "07/08" },
                    { new Guid("618da70c-a069-4455-a7f6-2e7438abfa2d"), "317", "3551933291814318", null, null, new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce"), "07/19" },
                    { new Guid("61f19dd2-6ae6-4c7c-9e1c-0ced9fc3839c"), "168", "3546530251347824", null, null, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d"), "07/20" },
                    { new Guid("621eb688-240f-4dfe-9331-3eb657e1b66d"), "404", "4122913679020256", null, null, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96"), "04/27" },
                    { new Guid("622a3249-17d6-49ad-8de7-abfc58022a08"), "249", "3332351499266845", null, null, new Guid("35263c47-5006-4ddc-a824-47120f6a334d"), "09/08" },
                    { new Guid("627201de-0284-4285-ad2c-9aa7a699785d"), "597", "4201103037316273", null, null, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce"), "03/16" },
                    { new Guid("63634bc8-f701-461f-8b55-583149c3a549"), "440", "6143538327543415", null, null, new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f"), "12/23" },
                    { new Guid("63a86b0d-6027-4ede-b33e-42a336a15ee3"), "930", "1909751582807921", null, null, new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213"), "08/16" },
                    { new Guid("64555d3d-9ab2-40d9-a5bd-bc39faa73185"), "657", "2970188443352348", null, null, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db"), "08/17" },
                    { new Guid("64b0c7a5-c504-4354-bc82-3a396c7d3c08"), "338", "2153271266940919", null, null, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091"), "03/20" },
                    { new Guid("65d75608-54ea-41d7-8cec-e4792e9c7351"), "715", "4444621395248006", null, null, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0"), "06/06" },
                    { new Guid("65e6175a-b5cf-4f79-9417-d67628a63ca5"), "642", "5837487715993459", null, null, new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5"), "07/14" },
                    { new Guid("65f73742-eaca-4d09-9393-1402f0d24776"), "921", "3607035042662924", null, null, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838"), "03/15" },
                    { new Guid("66242bb8-7c5b-4b57-b858-4eebc70abb88"), "348", "5986380492656188", null, null, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a"), "08/12" },
                    { new Guid("66753386-9279-4107-bce4-efd0cb102c11"), "058", "6379220915261055", null, null, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141"), "02/19" },
                    { new Guid("6690a38e-76af-4561-a48e-0eef4b33c47b"), "280", "1947920096274394", null, null, new Guid("44275811-c945-4a4f-8382-272488a907aa"), "03/14" },
                    { new Guid("66f36fbd-289b-4af0-a472-8ac9f789d741"), "020", "4554311534595560", null, null, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6"), "02/10" },
                    { new Guid("67ad25c9-c882-42bc-b2b7-b9bab4c50d0e"), "045", "9495671797834717", null, null, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14"), "08/01" },
                    { new Guid("67c48c09-68e4-4c01-9903-4d5c0a02fd6b"), "819", "9244933549717518", null, null, new Guid("0ec20584-d26f-41c4-b682-05916743e30a"), "04/15" },
                    { new Guid("67dde6c5-5af6-427e-bb77-de3c9787e33c"), "918", "7848005847666134", null, null, new Guid("5ee54399-9054-4429-a438-7a6f33482943"), "05/26" },
                    { new Guid("68c4f214-3f02-4da9-b981-f3768f5a2edb"), "752", "2888140602710426", null, null, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826"), "06/27" },
                    { new Guid("69141699-1d34-446c-8228-bc47939e7608"), "168", "1310054293057887", null, null, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd"), "08/18" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("69395c4f-1171-411c-8087-0b2decc51d6e"), "593", "4481598369114142", null, null, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d"), "07/20" },
                    { new Guid("69cc25e1-0843-4bdf-a54f-50ff0dcd6d35"), "344", "7392525619436385", null, null, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f"), "12/20" },
                    { new Guid("69cf4412-e783-48e9-bc63-192a549e03b7"), "158", "9897938265424348", null, null, new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925"), "11/02" },
                    { new Guid("6a9b8ae0-ce7b-4d45-ad2c-5e61f97ca46e"), "601", "5131045969113271", null, null, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80"), "09/10" },
                    { new Guid("6b346e04-5081-46c9-b5ca-0ffde98294cb"), "585", "9836193411787033", null, null, new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda"), "07/12" },
                    { new Guid("6c43c121-d53b-4f81-ae4a-3a6124fb6ecc"), "428", "2154307557216270", null, null, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565"), "01/02" },
                    { new Guid("6d0d7a2c-d791-4834-b60c-1ba6feba8453"), "344", "4123566431648516", null, null, new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3"), "01/02" },
                    { new Guid("6d5ae246-66b6-483c-bee4-46cc60b73ee6"), "367", "5804122568735874", null, null, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a"), "06/06" },
                    { new Guid("6d7b1999-024f-46f2-839c-673e5b29ad6c"), "552", "2820795859114414", null, null, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5"), "12/13" },
                    { new Guid("6daf8c85-1fc3-4e31-8755-5368b9fe0049"), "888", "8270979179651505", null, null, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58"), "07/08" },
                    { new Guid("6db48949-4bdd-4fce-8cbf-c2be73cf1a20"), "216", "4036082144056678", null, null, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14"), "11/19" },
                    { new Guid("6e3d119b-f005-413c-865c-cba7e5b7c056"), "017", "7585629230571652", null, null, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc"), "05/13" },
                    { new Guid("6e40471e-4d56-412d-9555-b2bf1a95a086"), "890", "8027284509799322", null, null, new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e"), "03/25" },
                    { new Guid("6e8aa44a-d0cc-4bd8-9738-9ea62daf18da"), "434", "7991342311737990", null, null, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549"), "06/21" },
                    { new Guid("6e9926e8-35a6-47db-a629-09f2d9f1687c"), "462", "8513453536769220", null, null, new Guid("5f140f7e-803a-444d-8158-03815cbd832c"), "12/10" },
                    { new Guid("6eb04c9b-6d46-4b72-bff6-e259840a7763"), "770", "2427698225370027", null, null, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12"), "05/28" },
                    { new Guid("6f28cae9-1178-4751-acd2-a264fc357fb0"), "691", "1367280528326741", null, null, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a"), "03/18" },
                    { new Guid("6f48e28e-efe9-43f8-9fc5-18ad84b97898"), "687", "7306808094375324", null, null, new Guid("9bea6011-9948-451d-9195-7c4cc4339cba"), "05/06" },
                    { new Guid("6f65b99e-b91f-400c-8102-adc310937baa"), "696", "5990862611167248", null, null, new Guid("9bea6011-9948-451d-9195-7c4cc4339cba"), "12/17" },
                    { new Guid("6fb4ba4f-341a-4ea9-aa9a-1ea6589dce66"), "190", "2336762468988873", null, null, new Guid("46075330-4d61-4bde-be40-948e47bd19fb"), "05/23" },
                    { new Guid("6fe4a6ba-3969-4952-8ae0-29267fdfa42f"), "505", "5169035860812596", null, null, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef"), "06/17" },
                    { new Guid("701a509b-7cdf-448c-83f9-c07430d5a0c6"), "323", "8174557607808549", null, null, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17"), "06/14" },
                    { new Guid("703f5bdf-0250-48cc-a558-c8f4ca425104"), "356", "3937967411033170", null, null, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d"), "07/10" },
                    { new Guid("7073f274-98b9-4b1c-a657-eb282d334e3d"), "068", "5684924238335350", null, null, new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7"), "09/23" },
                    { new Guid("70a1a91c-8d96-4f2d-8465-48b051374dbc"), "008", "5301968081934485", null, null, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f"), "08/14" },
                    { new Guid("70f88ff0-31ad-4263-88d2-89370d50cef9"), "302", "3478198246882085", null, null, new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1"), "08/16" },
                    { new Guid("71288180-1aff-466a-8c9c-31c1a72c8aef"), "578", "6743400930079520", null, null, new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3"), "11/27" },
                    { new Guid("7142072d-5ac1-4842-bc63-57306011918c"), "646", "4058462779813491", null, null, new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e"), "08/10" },
                    { new Guid("715134e7-8416-4e6a-b520-821378336b0d"), "655", "5723804071910404", null, null, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb"), "05/04" },
                    { new Guid("716a22a1-e45f-4aa0-ab5d-fedede9bc512"), "065", "6719852691851819", null, null, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b"), "01/03" },
                    { new Guid("717c46c6-671f-4965-8577-6357d78ff0e0"), "131", "7607504464831133", null, null, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96"), "11/12" },
                    { new Guid("71880e75-97cb-404f-a02e-87e91733a0dd"), "549", "2279529228724238", null, null, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e"), "08/28" },
                    { new Guid("71da577a-a3ad-40ee-a4c8-e25bd66131c5"), "587", "8612611347921179", null, null, new Guid("5227b046-d260-4727-89e6-90bfa60f5f27"), "09/21" },
                    { new Guid("7216f951-ba80-4d38-b439-301bda943871"), "417", "9273027845756311", null, null, new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda"), "06/08" },
                    { new Guid("722baa90-f97a-45b6-896a-7c6b551ea80f"), "134", "4937634807796791", null, null, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8"), "07/23" },
                    { new Guid("725b2e97-a0c1-41d3-9d2e-2ade412901d2"), "153", "7984306148454163", null, null, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12"), "04/04" },
                    { new Guid("727b0cfe-a39f-44cf-908e-a8edabd047a8"), "762", "7861621411517937", null, null, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), "08/09" },
                    { new Guid("731c3296-903f-4287-8adb-84b29ee23356"), "711", "6659181383285610", null, null, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0"), "10/24" },
                    { new Guid("73486d27-ac34-47fd-a1c1-7150c44c94b4"), "227", "2713419717845363", null, null, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9"), "02/22" },
                    { new Guid("7352ec1d-4ed0-4994-9e76-373a3a54488e"), "748", "4120170229179441", null, null, new Guid("44736c29-d473-4b0c-9aca-5f9518cda391"), "12/19" },
                    { new Guid("73909ccd-8342-47c5-a590-72a3a655350a"), "986", "5218078500832546", null, null, new Guid("3525c903-c292-4d3e-942f-aeae98225a62"), "04/20" },
                    { new Guid("74053d64-b25d-4155-8535-0a1a53bbf4c6"), "066", "4838232260157030", null, null, new Guid("e046fca1-590d-4528-9a08-8baa91140ac9"), "03/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("74413f2b-6227-4f0a-98d3-d22d2b9b1553"), "053", "3908962249730806", null, null, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684"), "12/11" },
                    { new Guid("7488e440-d12d-4ac7-bdae-1036181446bb"), "043", "3330861568065916", null, null, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc"), "05/27" },
                    { new Guid("7599da6c-429a-42cf-89a6-1cde9b2c657f"), "884", "7487988166800610", null, null, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3"), "09/19" },
                    { new Guid("75a9d7ee-984a-43d1-98d2-31cef3b61fc4"), "212", "5333373435288537", null, null, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3"), "02/09" },
                    { new Guid("7675cf18-5e37-4754-a86d-920b313046d8"), "081", "2973370230490607", null, null, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89"), "07/08" },
                    { new Guid("76b6e744-297e-43b7-93c1-0edb1eaa3fd8"), "111", "1649621882967205", null, null, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27"), "08/04" },
                    { new Guid("76ea8440-08b6-4c12-93bd-e4b17ce2399d"), "790", "3552039136073637", null, null, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2"), "07/26" },
                    { new Guid("76ffbe35-1b24-473a-982b-4b6e581ae801"), "987", "3575842350131931", null, null, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337"), "09/26" },
                    { new Guid("77457c1c-85af-492b-a6cf-ee20e67579de"), "102", "1685049169213412", null, null, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97"), "01/24" },
                    { new Guid("780751e2-c646-47e2-80f1-86c5d38a88e3"), "864", "3630964470852197", null, null, new Guid("9af47343-7f95-4006-8dea-4975912f5989"), "05/25" },
                    { new Guid("78d35c52-6710-44b9-bcf6-1ec047827262"), "408", "6806287412425504", null, null, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141"), "11/23" },
                    { new Guid("78e00a53-aaa4-4da5-a3b0-d7553af95614"), "788", "7013657193353154", null, null, new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4"), "03/25" },
                    { new Guid("7989db4c-c29a-45cb-a256-b841aeb9cdbd"), "430", "9559527407594184", null, null, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d"), "10/07" },
                    { new Guid("79b26ef9-7cc0-415b-8ca7-63faeeed4052"), "674", "9189791247728080", null, null, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad"), "04/03" },
                    { new Guid("79c8d9b1-166d-4ff3-8e74-89fdd1662ce1"), "105", "9312452652382230", null, null, new Guid("bb76498f-37b6-48d3-b979-97246498ed03"), "04/15" },
                    { new Guid("7a1bdd91-81c8-499a-90dc-82f8873be1d2"), "221", "3235953149741592", null, null, new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc"), "10/10" },
                    { new Guid("7a2b4833-85c0-4ffd-8b7f-9ed8ec9bb60c"), "409", "8571867294187991", null, null, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d"), "05/15" },
                    { new Guid("7a454ee2-c05e-4f38-a6ca-4d9b6b76007a"), "951", "2640158376628371", null, null, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a"), "10/24" },
                    { new Guid("7b080b4f-6c20-464b-a920-4e1667d39aeb"), "061", "3722478851874297", null, null, new Guid("3525c903-c292-4d3e-942f-aeae98225a62"), "03/12" },
                    { new Guid("7b101c83-1025-4e36-9ad1-950eb2426550"), "610", "7154927591490389", null, null, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93"), "04/28" },
                    { new Guid("7b3f0328-fd54-4f9a-9bb0-2361ce029b36"), "258", "8368860628320611", null, null, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8"), "12/10" },
                    { new Guid("7bace4ce-3619-4a2d-a9d4-22dd2a51461d"), "260", "9294367817865243", null, null, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f"), "09/25" },
                    { new Guid("7bb6a00d-7b00-4075-a461-58a393a9db65"), "146", "9896605058474073", null, null, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe"), "01/28" },
                    { new Guid("7bb703ab-98d0-423f-9873-792c2cef093f"), "377", "3639671197588225", null, null, new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17"), "11/28" },
                    { new Guid("7ca89007-4b55-4a22-b1b1-a4900efa46cc"), "217", "7676903844423141", null, null, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3"), "02/09" },
                    { new Guid("7ca9a9ea-e31b-4cdc-813f-8a19abf077b0"), "908", "6672318655595380", null, null, new Guid("9af47343-7f95-4006-8dea-4975912f5989"), "12/11" },
                    { new Guid("7d6def5e-5dfa-49a8-9f5b-0a01e2349c87"), "379", "7699174121925271", null, null, new Guid("ceb699bd-8c01-4831-9438-e8c30f353919"), "10/22" },
                    { new Guid("7d800881-6670-4da6-9585-4687e8b45fd9"), "676", "8138010742838909", null, null, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5"), "05/28" },
                    { new Guid("7d8a600c-1771-4816-a1c1-604e09a41ce2"), "663", "2971045282596367", null, null, new Guid("56acd153-5467-4111-9ca4-96f34533a050"), "02/23" },
                    { new Guid("7dd27ea8-95a9-4f3a-be02-e2fb4721e318"), "599", "4517671459969107", null, null, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97"), "03/26" },
                    { new Guid("7e1a2930-147d-4e72-af3c-cc09ce037631"), "032", "7934536979931773", null, null, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf"), "01/23" },
                    { new Guid("7e2d6119-a93c-45fd-85a8-9f8d5b908ea7"), "167", "6900551032340788", null, null, new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483"), "01/20" },
                    { new Guid("7ee0e568-fe2f-46ba-bed9-4dbd82c2cd78"), "474", "2030517903390100", null, null, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c"), "05/14" },
                    { new Guid("7f17d81b-573a-4132-b416-0b45bd32928d"), "727", "4186829229299983", null, null, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44"), "05/11" },
                    { new Guid("7f3ce542-1ea0-4c1f-acbf-2f4cf3749cd6"), "469", "4225379852877309", null, null, new Guid("11712f31-db09-482e-bdab-2c19dff98304"), "04/15" },
                    { new Guid("8015726b-cf23-4275-ad3d-4c798afcfda1"), "531", "4490094016265882", null, null, new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a"), "01/23" },
                    { new Guid("80169686-8914-4acf-ba98-b2548759228e"), "129", "5701207048426565", null, null, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96"), "05/19" },
                    { new Guid("80891463-bd04-4f56-8f4d-97d5c0ced8ef"), "957", "5199546569449628", null, null, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483"), "06/03" },
                    { new Guid("8094af92-e145-4828-bad2-7109c2d8322a"), "477", "9697157321978300", null, null, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49"), "09/10" },
                    { new Guid("80a23c5d-7337-49d8-ab17-cba9a272fbbb"), "911", "8766109463317769", null, null, new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e"), "10/26" },
                    { new Guid("80bf19f0-927f-4b34-83df-69fcdd18a060"), "861", "2171986649347460", null, null, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb"), "10/18" },
                    { new Guid("80dbb24c-9fc2-4dba-bd14-e0d3947142da"), "124", "2696929133176673", null, null, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6"), "01/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("80ebe8f7-f191-4255-a895-d146ab60a39a"), "287", "6336267017862612", null, null, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2"), "09/13" },
                    { new Guid("810f8056-4dba-4c30-8221-3b7af5fb3ca2"), "608", "3465014463726086", null, null, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84"), "06/20" },
                    { new Guid("813f391b-0ae5-48f2-acba-bdcf46512dcc"), "394", "2300039019166883", null, null, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc"), "04/03" },
                    { new Guid("81a08a2d-ddce-4f02-ac14-ef746e692c25"), "207", "1211610058511595", null, null, new Guid("4e8e0581-239d-4586-9cca-aad850d7d329"), "04/27" },
                    { new Guid("81b546f1-253d-447f-9ea7-ab37cdb67514"), "430", "6317468350938724", null, null, new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042"), "01/15" },
                    { new Guid("81c42db1-c446-4928-a3d3-bac9a503e55f"), "055", "7925245171810054", null, null, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1"), "02/25" },
                    { new Guid("81c72119-b057-43b9-bff9-24e93a932351"), "843", "1088857370819534", null, null, new Guid("223295f7-9195-4510-8bcc-44f043830497"), "09/23" },
                    { new Guid("81e5f888-820b-4e00-8b82-c0ba71654360"), "435", "1541963572900657", null, null, new Guid("1909a070-eed8-440c-9e1c-16073e761c90"), "11/19" },
                    { new Guid("81f0e3d7-5488-4aa4-b881-77ac8ea2b059"), "416", "6074405205876444", null, null, new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756"), "10/12" },
                    { new Guid("824a747b-fd83-4369-b686-c841b1b070a7"), "626", "9665511003087425", null, null, new Guid("97253083-0ecd-4730-b815-c4b8137ab125"), "09/27" },
                    { new Guid("838bd6bc-33e5-4a0e-a7d1-102d313d7746"), "341", "4741728909879235", null, null, new Guid("bb76498f-37b6-48d3-b979-97246498ed03"), "01/27" },
                    { new Guid("8450f88b-9bd7-43fe-927a-44f54fc91608"), "591", "8887245365095116", null, null, new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8"), "09/17" },
                    { new Guid("8484f79f-91af-467e-abd4-8b409376af26"), "278", "1881934792505816", null, null, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7"), "02/24" },
                    { new Guid("85009e47-47f9-4902-859f-d6109a854b70"), "071", "8660843511677118", null, null, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f"), "02/23" },
                    { new Guid("85b1d498-046d-4121-8486-106281c5bc46"), "884", "8761647980187789", null, null, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562"), "12/24" },
                    { new Guid("860d4d3d-d418-4a36-80c6-890daf35dda8"), "595", "1463088347305637", null, null, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7"), "11/02" },
                    { new Guid("864de02c-f53a-4a34-b39a-92cedc670611"), "598", "2033237189610670", null, null, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c"), "08/21" },
                    { new Guid("86dde129-3d39-4850-ac91-cd99ed1748ac"), "487", "9250450925398448", null, null, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933"), "08/01" },
                    { new Guid("877e74b6-dad2-472f-b0e0-bee508e292ff"), "703", "2079811102841027", null, null, new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483"), "05/18" },
                    { new Guid("878dc5c2-c22a-4dd2-8667-368d74801370"), "059", "1731117820186781", null, null, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6"), "04/10" },
                    { new Guid("889f19f6-a8f0-46c7-98b2-a6cc4726e561"), "912", "3412980050827085", null, null, new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20"), "11/05" },
                    { new Guid("88ab7a5b-80ba-4151-bc64-049fdf0a6222"), "841", "3676660808295933", null, null, new Guid("072b74c5-5e1d-46de-9caa-66d36218f554"), "10/05" },
                    { new Guid("88bb5a21-4a2c-4a53-8112-52d44bc68c10"), "642", "7426695961397989", null, null, new Guid("56acd153-5467-4111-9ca4-96f34533a050"), "01/20" },
                    { new Guid("891b3893-9b3d-49a0-9e6f-41e47aae13e8"), "567", "1805274111093533", null, null, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565"), "08/21" },
                    { new Guid("8933f006-cc43-4aa5-abb1-5be8043fddcd"), "320", "9440765159696964", null, null, new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694"), "03/21" },
                    { new Guid("89971f08-3598-4348-bb44-7d567cb320ba"), "240", "7468335718009445", null, null, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826"), "10/14" },
                    { new Guid("8a028426-6d4a-43e4-a4fa-e2f66da33c3b"), "488", "7985961232527678", null, null, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7"), "06/12" },
                    { new Guid("8a0a9002-3a22-4576-9a98-e4d09d20f46c"), "888", "4241693599746763", null, null, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1"), "10/24" },
                    { new Guid("8a63e36b-90d8-427a-8428-ea293bbf1787"), "389", "8818896259124090", null, null, new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644"), "11/15" },
                    { new Guid("8a725613-d5c6-4120-8ee3-d9acec27296f"), "756", "9821541726995541", null, null, new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8"), "07/28" },
                    { new Guid("8ab5016e-6903-44ca-92b3-ce80f4615e3b"), "922", "6112539692157577", null, null, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6"), "09/27" },
                    { new Guid("8ac135f1-75e3-44c6-a4be-0ef3a6bc6851"), "631", "8980998348694408", null, null, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483"), "08/20" },
                    { new Guid("8b0b8cd7-9f75-4806-83f2-d70f6350405a"), "212", "5068280207551688", null, null, new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1"), "07/19" },
                    { new Guid("8b2ebf11-5ed5-47a6-97e5-df852a74506c"), "667", "6433745017009592", null, null, new Guid("09fd275e-b209-4f17-84ed-5884b76fc276"), "06/12" },
                    { new Guid("8b3b5507-b020-414f-88c4-48940179967d"), "623", "6974096298526643", null, null, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3"), "04/18" },
                    { new Guid("8bc94205-3469-4bb9-8075-52d0cda3e0d8"), "938", "6417636025871239", null, null, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80"), "02/11" },
                    { new Guid("8c99d286-fce7-457e-ad10-af0c99013ef8"), "575", "3690973163654085", null, null, new Guid("70409336-0f26-4108-8c79-213e320c07f7"), "09/06" },
                    { new Guid("8cf2847e-d5d9-44e3-b015-125114e16cb2"), "109", "6995474475146796", null, null, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141"), "02/27" },
                    { new Guid("8dd58ef6-a8a4-4ce6-97bf-3789d94657d9"), "753", "3379274881589573", null, null, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e"), "02/11" },
                    { new Guid("8e8f13eb-349f-4f37-8c14-c659dacdffd6"), "006", "1818666606840899", null, null, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), "02/20" },
                    { new Guid("8ecc98af-4f0a-466d-a20b-96c3b8b96de4"), "574", "9164296613853097", null, null, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede"), "04/17" },
                    { new Guid("8f09c2c0-8df9-42c7-ad6e-8ad67e47b701"), "298", "2551915119356499", null, null, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec"), "09/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8f276db2-a7c3-4af9-a9e3-925e671b48f1"), "017", "7617458393926281", null, null, new Guid("234cf821-c69e-41fd-b13e-68660060a87e"), "09/19" },
                    { new Guid("908f4baf-5a6c-4069-80f7-2caeb57d7b96"), "631", "6064734863720721", null, null, new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3"), "03/10" },
                    { new Guid("90be3eb0-da6b-4e5a-9bda-2e636125ca35"), "705", "6773268478391188", null, null, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599"), "08/14" },
                    { new Guid("90d2e21b-67ef-4f0a-a2c6-3551fa12f8df"), "548", "3543235099960723", null, null, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483"), "03/15" },
                    { new Guid("90f48ac9-cf4d-4b33-9665-9a0309b3de6e"), "094", "9630679418873745", null, null, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd"), "02/07" },
                    { new Guid("90f7223d-ba5b-4c7b-9e22-160e4e57d915"), "247", "5490120343655104", null, null, new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5"), "12/12" },
                    { new Guid("914e3cb7-e132-47b2-8701-2b3f9b6f5ac3"), "650", "7586317396701450", null, null, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285"), "11/22" },
                    { new Guid("916653dd-296b-4b82-9219-43701b5fdaaf"), "364", "9475773743052775", null, null, new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7"), "02/02" },
                    { new Guid("922dbfcf-6e1f-4234-bfea-a90f29c3924a"), "019", "5853787307943429", null, null, new Guid("ad755590-668c-421d-994e-b7a783d9dcd5"), "11/27" },
                    { new Guid("927229d3-727e-42f4-8873-2856153384e9"), "929", "6346144754203029", null, null, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec"), "10/14" },
                    { new Guid("9296669d-47fa-4664-bede-30bafb9b5ae2"), "553", "7544240590369750", null, null, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d"), "03/08" },
                    { new Guid("9461d79c-2720-4172-b990-3010b2869ccb"), "459", "9341648567549023", null, null, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6"), "08/19" },
                    { new Guid("9475a880-0a2f-4ec2-ae6f-178b8b8bfff6"), "820", "8672057891157923", null, null, new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f"), "12/10" },
                    { new Guid("94d05e63-cc6b-45fb-a3fe-0e84ead3f8f7"), "136", "4640639060899527", null, null, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3"), "12/03" },
                    { new Guid("94d4aada-61bf-459b-8528-3af92190768e"), "728", "9348910905537460", null, null, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f"), "01/22" },
                    { new Guid("95775467-090a-4bba-b8f4-5a6383a183a0"), "732", "9650018309483428", null, null, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), "04/21" },
                    { new Guid("95cc786f-6d0e-49fd-9d33-67293b306d11"), "370", "1334182550802166", null, null, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46"), "12/17" },
                    { new Guid("95db5437-6d80-46c1-9e3d-5ecf033b3b08"), "103", "5956422606182401", null, null, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16"), "04/09" },
                    { new Guid("95ee192e-03be-408b-bdcd-caa67e63e7c2"), "519", "9424120539283523", null, null, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9"), "02/05" },
                    { new Guid("960827ef-b240-4ba3-aaca-708c656682de"), "082", "9442567830784063", null, null, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8"), "12/06" },
                    { new Guid("96319b46-8c0b-4dc9-a26f-5c1515e28a5a"), "771", "2734278523095738", null, null, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399"), "07/21" },
                    { new Guid("96af41d5-8c74-4431-bfb7-b375446eea04"), "655", "9824748173536400", null, null, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0"), "01/21" },
                    { new Guid("973406de-a47c-4c92-8f34-8bd134539a97"), "639", "8686408284771718", null, null, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00"), "12/17" },
                    { new Guid("975546d0-1c00-4e33-8ee6-4c2ed2004cf4"), "571", "8723846119092955", null, null, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8"), "03/26" },
                    { new Guid("978151e9-37ce-48a9-89ca-399e3b50daac"), "592", "5653491136880498", null, null, new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc"), "11/13" },
                    { new Guid("988934f8-e516-4141-917e-2f9e8674ede1"), "514", "9505265472508944", null, null, new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5"), "07/06" },
                    { new Guid("991ee227-d0b5-46e9-bbef-6ca53525d7b9"), "746", "7161607368683871", null, null, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807"), "04/23" },
                    { new Guid("992cc99a-5cab-4642-a048-75c605c17917"), "500", "4672531479794260", null, null, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d"), "03/26" },
                    { new Guid("993ce93d-8935-4f5e-8008-9f71453c12d5"), "053", "1797297574755854", null, null, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a"), "08/01" },
                    { new Guid("99814e2c-4e16-415a-ab5e-c37f6b2c7afa"), "924", "1722715775109285", null, null, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838"), "05/14" },
                    { new Guid("99c0a256-b388-4e63-89b9-3dad41ce3b3f"), "842", "8813370736257201", null, null, new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797"), "08/09" },
                    { new Guid("9a3e7dc8-5ada-4b4e-80e4-7e621ed09675"), "090", "6262694354504177", null, null, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000"), "09/11" },
                    { new Guid("9a6d5858-acd0-44d9-ad3e-0f6a302b8a90"), "166", "8373134379063783", null, null, new Guid("76807668-f1d2-47ed-a084-0771d51bc761"), "01/07" },
                    { new Guid("9a747922-8ae3-41d7-a5b5-b76f991ca47a"), "970", "3554250402748437", null, null, new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2"), "05/14" },
                    { new Guid("9ae2830c-d324-4c56-bb13-59973f8e1600"), "427", "4059622615104236", null, null, new Guid("e908834c-4383-4b44-a138-de5de4aa621a"), "02/01" },
                    { new Guid("9b0928d7-dd1e-4425-82ea-7cf19608bf94"), "774", "5980657454437412", null, null, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2"), "01/22" },
                    { new Guid("9b24b819-cbb2-48d2-9aa8-97bf97204338"), "257", "9533218395762094", null, null, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9"), "09/16" },
                    { new Guid("9b3ce81f-8f38-4170-b4c1-ea33be7e99da"), "649", "1005304470603499", null, null, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d"), "10/23" },
                    { new Guid("9bd113f9-c857-48ff-8c2e-def5e05e1078"), "128", "7938560174695906", null, null, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5"), "03/28" },
                    { new Guid("9ca59415-341b-4fb6-9cc2-10b85be8d771"), "295", "1192176556625392", null, null, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3"), "01/20" },
                    { new Guid("9ca6286f-5e74-47db-b60d-719ab005be09"), "337", "9091468405730218", null, null, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5"), "10/10" },
                    { new Guid("9cac6e69-35df-4e35-ba2a-3e63792779c7"), "746", "3029375101963382", null, null, new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756"), "03/20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("9d7fdb01-16a7-4594-a148-c5f075e96d3b"), "635", "2417532284613869", null, null, new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056"), "09/25" },
                    { new Guid("9da0b1a1-df76-4fb4-a3de-3933d744b160"), "670", "4618466305854146", null, null, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d"), "05/18" },
                    { new Guid("9da2e3bd-3351-43fb-a29c-3c2652ff005e"), "106", "7802604938458602", null, null, new Guid("57710136-3092-497c-8523-6e222848ceaf"), "11/04" },
                    { new Guid("9dd55f52-41e2-4a50-8d9d-9ef63916244d"), "222", "3102993768149044", null, null, new Guid("62780013-8c47-4235-a42a-798d9bf04220"), "04/26" },
                    { new Guid("9e040a91-e4bb-4c7f-ae19-8f60050069b1"), "056", "3667474722161292", null, null, new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb"), "11/21" },
                    { new Guid("9e0b79da-71f3-47c3-94c1-61e5ff03683d"), "021", "7559942904619940", null, null, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff"), "06/05" },
                    { new Guid("9e2967c9-e92b-49ad-b1c5-7258c16dd79b"), "454", "6108470436880741", null, null, new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1"), "05/28" },
                    { new Guid("9e9a5f6b-de62-4ec3-b49f-7d1158415aef"), "917", "7570534079101416", null, null, new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1"), "02/27" },
                    { new Guid("9ea0035b-47c9-42b0-9991-50591021d01a"), "429", "4372363466685190", null, null, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c"), "04/13" },
                    { new Guid("9f3d4a04-01f6-489f-9499-83b8b1b94bf9"), "840", "9678443890837634", null, null, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5"), "06/18" },
                    { new Guid("9f8658a6-7f3a-4fca-be28-9ca8b48ef96f"), "577", "4303412983823985", null, null, new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640"), "11/05" },
                    { new Guid("9f9084c0-c8cd-4c1d-aec8-e90320550478"), "663", "6776845486232997", null, null, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724"), "06/02" },
                    { new Guid("9ff69fdb-698e-4048-9506-03cfdf1e4aa5"), "589", "7441386176167618", null, null, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3"), "09/24" },
                    { new Guid("a04e56ae-6cbd-4070-a36f-f241d8674528"), "143", "5383141332244804", null, null, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e"), "11/17" },
                    { new Guid("a11785da-0147-4be4-b9e8-cf1d9b50763f"), "330", "8019986428258562", null, null, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3"), "06/14" },
                    { new Guid("a166ba78-8f7e-40a6-9fb0-ec937fb68ca3"), "530", "9167294112439989", null, null, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e"), "08/12" },
                    { new Guid("a1847513-5d32-4c1a-80c7-4cb28383503f"), "656", "8572858764181277", null, null, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32"), "03/17" },
                    { new Guid("a18d6cf1-6c2b-4945-9635-4c2402a4b117"), "697", "2706989495088115", null, null, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1"), "01/06" },
                    { new Guid("a1b716b8-5a45-4376-b4cc-e0c39f902fcf"), "027", "8323335102471356", null, null, new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1"), "06/01" },
                    { new Guid("a1d0c8a1-84a5-41f1-99ff-20d689f335f6"), "200", "9670046236426722", null, null, new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf"), "04/28" },
                    { new Guid("a22ebdbf-c514-4183-ad84-d06384fe01d8"), "842", "2569155978858138", null, null, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9"), "01/13" },
                    { new Guid("a23bdeb8-daf3-43a5-ba43-517c11d51cbe"), "432", "2835132146006615", null, null, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e"), "02/17" },
                    { new Guid("a258a750-e316-4d4a-9f61-e13bccbbf75d"), "165", "6326038046943638", null, null, new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6"), "08/26" },
                    { new Guid("a2f0e30b-2905-4f14-8c1f-d10519079e8f"), "521", "5436811307499610", null, null, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6"), "06/17" },
                    { new Guid("a301d515-5887-42b2-805b-113eca980734"), "661", "2943134147632085", null, null, new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4"), "09/16" },
                    { new Guid("a304f6b1-9299-4157-a32f-5da6ac6495b5"), "323", "6513179765448277", null, null, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49"), "01/24" },
                    { new Guid("a3189ded-7f2f-4359-b49f-82ce7dc2b276"), "278", "4675991245438671", null, null, new Guid("3855a279-823e-41a4-ad2e-768e134c626f"), "08/22" },
                    { new Guid("a3a6fceb-71ca-4d62-ba72-92b7e76b5931"), "237", "5667890473399007", null, null, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32"), "05/05" },
                    { new Guid("a42097e0-5da0-4082-8fe3-5ed5e5448be9"), "083", "2843763385118931", null, null, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500"), "01/12" },
                    { new Guid("a43d908d-3c75-4d66-b0ba-19cd9b99a2cb"), "967", "6543061710501289", null, null, new Guid("70409336-0f26-4108-8c79-213e320c07f7"), "02/06" },
                    { new Guid("a4ab9e5b-3c30-4e1f-8c86-05b564b2bd8d"), "094", "5266627715142175", null, null, new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f"), "04/22" },
                    { new Guid("a4c049a4-e3de-46d4-a5a9-2e924a44e071"), "849", "1769263090202016", null, null, new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a"), "01/02" },
                    { new Guid("a4cd8ea6-64d0-46c7-b4e7-6019b0cfaf28"), "944", "1859247625788997", null, null, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3"), "05/15" },
                    { new Guid("a4ebf1ee-539a-4c6f-b80e-4f6373ad12fd"), "893", "4615496846436481", null, null, new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee"), "09/21" },
                    { new Guid("a534c0b7-6413-4540-b5ce-cbd8038720cf"), "447", "6249373920524862", null, null, new Guid("e50b5106-c89a-489a-b970-99024a53f892"), "04/05" },
                    { new Guid("a55d662e-d92d-4337-bfb0-fbc49578b009"), "819", "6061508628774695", null, null, new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04"), "08/17" },
                    { new Guid("a586f6f9-510b-468d-b376-4e9fcf588aa6"), "678", "7087883528206121", null, null, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020"), "11/08" },
                    { new Guid("a5b6d6a0-0369-44bb-bf42-8aca42ca000b"), "258", "7758712768786330", null, null, new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69"), "10/18" },
                    { new Guid("a5f183ba-5157-4a6b-9ccf-b26cd80c0dda"), "080", "3426992716456010", null, null, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724"), "10/02" },
                    { new Guid("a62403dd-0adb-4e68-b17d-2d90f06122d7"), "383", "2256055359065348", null, null, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb"), "08/20" },
                    { new Guid("a69c190b-0eb7-40f7-b0a8-101e8885f260"), "291", "9837835535992226", null, null, new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867"), "04/08" },
                    { new Guid("a7368b7c-f4e4-4ca2-ad22-0b620f448b7b"), "066", "3014346909811433", null, null, new Guid("e50b5106-c89a-489a-b970-99024a53f892"), "04/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a884b288-157c-46b8-86a0-c568495ec266"), "523", "9844674219804427", null, null, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933"), "01/02" },
                    { new Guid("a8aa8957-c979-41ff-b72f-805dd18f81a0"), "072", "9705566181584119", null, null, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f"), "06/20" },
                    { new Guid("a8c4ef40-ce7e-430a-992c-d6889c86c5ba"), "406", "7362892198576847", null, null, new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed"), "02/18" },
                    { new Guid("a932bf8d-4cde-427f-93cd-31c917032e2e"), "025", "2448555356226861", null, null, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7"), "12/22" },
                    { new Guid("a947ce9f-610c-4f6f-bc0a-ae32b02459d6"), "673", "8524708563666158", null, null, new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128"), "10/01" },
                    { new Guid("a9b43363-5521-44d9-931e-c61d62d10144"), "724", "8481775788252771", null, null, new Guid("f443c798-1151-4757-94ca-517bef15e381"), "11/03" },
                    { new Guid("aa04d286-d233-4625-848d-6bad06bde141"), "201", "8634315099008489", null, null, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e"), "07/20" },
                    { new Guid("aa7ff417-eb2a-422d-8036-223c4c2fd006"), "957", "6589587047036624", null, null, new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644"), "11/15" },
                    { new Guid("aaafbb51-4317-4e76-afa2-3767400f3d82"), "600", "9696011342926708", null, null, new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3"), "08/13" },
                    { new Guid("ab71e6d0-158f-4f2e-84ed-6442d5bf3682"), "501", "4518894022729648", null, null, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a"), "07/06" },
                    { new Guid("ac14740b-55b5-49bc-8e81-b4dead9e827c"), "616", "2757016912621512", null, null, new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8"), "04/19" },
                    { new Guid("ad0c8c69-9e6b-47ac-ac9c-9269e23ef285"), "776", "3264718375363458", null, null, new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c"), "02/09" },
                    { new Guid("ad242efd-6e24-4200-9386-aeadd140fc9e"), "607", "1040096892165657", null, null, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca"), "11/23" },
                    { new Guid("ad2cef19-c6ab-45d5-9a0b-380251103646"), "327", "9145832232870058", null, null, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0"), "08/14" },
                    { new Guid("ad61ba0d-0b43-4c86-a259-cb3f199c8f70"), "300", "9568629438498949", null, null, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db"), "12/21" },
                    { new Guid("ada76d54-5d75-49e6-b597-64d5aa487c88"), "133", "1884870638093686", null, null, new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20"), "03/21" },
                    { new Guid("adb39e11-4f97-443c-82c4-60860d6f07e2"), "970", "4479373459189311", null, null, new Guid("57710136-3092-497c-8523-6e222848ceaf"), "03/10" },
                    { new Guid("adcd50ca-b196-44a2-8430-ff4baf675ab9"), "767", "1789393997054967", null, null, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2"), "12/06" },
                    { new Guid("addb571f-29e9-4373-8b54-15070fb8d657"), "692", "1971042447731810", null, null, new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc"), "05/08" },
                    { new Guid("adec5f94-86f6-4a07-b2eb-10a20be1e73a"), "391", "8185850200287409", null, null, new Guid("f819889a-570b-4521-a36f-42d900233678"), "03/01" },
                    { new Guid("adf0be52-ad55-4757-9402-9016f04fe4ef"), "525", "2202649454929143", null, null, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549"), "06/14" },
                    { new Guid("adf23f76-94d7-4eae-8e77-59f46dac08ac"), "034", "2189213895701716", null, null, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071"), "03/24" },
                    { new Guid("ae0c98a0-89a4-4431-9e39-f06b8bd0dab8"), "653", "4765723651228493", null, null, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc"), "12/15" },
                    { new Guid("ae897474-15f8-40e7-86b8-727230cb6239"), "549", "8972349822015095", null, null, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724"), "06/01" },
                    { new Guid("af19f824-f8ae-4202-b4cb-77a8692f263e"), "636", "3032152805968844", null, null, new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86"), "02/22" },
                    { new Guid("af3f0084-7bbe-4b88-9278-b95e3592f890"), "026", "9767439025914771", null, null, new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953"), "08/10" },
                    { new Guid("af48c26f-81d5-459c-a322-0c692ed366c8"), "157", "1731939106486339", null, null, new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640"), "07/04" },
                    { new Guid("af4d52e5-9e79-431e-9a36-8d76e7f117bd"), "364", "3590772807151206", null, null, new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953"), "04/27" },
                    { new Guid("b009bd90-cfbe-444a-94ff-f5e66cfc4298"), "846", "4991174810083076", null, null, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84"), "09/20" },
                    { new Guid("b12290a0-372a-44dd-9cb7-2f973183b83e"), "638", "6915631299791333", null, null, new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a"), "11/23" },
                    { new Guid("b1230f6e-050b-4536-a865-a70169ca4875"), "165", "8783465713456492", null, null, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1"), "08/14" },
                    { new Guid("b14b9b1b-e2fd-464f-864e-c37d7881b0ba"), "251", "8134982446512355", null, null, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f"), "02/12" },
                    { new Guid("b1ae56d6-718c-4fe7-847e-20bad1bfb392"), "440", "8569232007187071", null, null, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684"), "06/24" },
                    { new Guid("b1cc0793-9c6d-4bea-a02e-47a4c3d8740c"), "178", "4910562004857483", null, null, new Guid("44736c29-d473-4b0c-9aca-5f9518cda391"), "05/04" },
                    { new Guid("b21b5a55-d343-4449-b9b3-ec7b799d2e68"), "786", "6243473414136921", null, null, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00"), "08/25" },
                    { new Guid("b2520b14-0e33-45c0-beb5-dff2c5e28699"), "981", "8792635155573171", null, null, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9"), "10/24" },
                    { new Guid("b263ff2b-2ba1-4470-b71c-ff489e97715b"), "365", "9523533589126332", null, null, new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61"), "06/18" },
                    { new Guid("b27449e3-171d-467b-9ece-a5ec99d762da"), "814", "3530923677802065", null, null, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe"), "07/23" },
                    { new Guid("b2b4c49b-99dd-4c57-af8d-bb868f24b2e9"), "482", "3133294432576960", null, null, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d"), "02/09" },
                    { new Guid("b2c8629c-4e95-468d-813e-92d5f89d7cc8"), "877", "5127573303341440", null, null, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2"), "10/08" },
                    { new Guid("b33c348b-7d2b-4a91-8a27-132dcfc5c4f4"), "701", "5941421574964034", null, null, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091"), "07/16" },
                    { new Guid("b3691104-9aa0-425d-9cd4-8580bd30f563"), "195", "7321757835727272", null, null, new Guid("f2542110-27bc-4868-b96c-53e10a66800f"), "09/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("b399f248-8f89-4cae-ae7c-01dae033e86a"), "419", "1753694839417526", null, null, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44"), "02/15" },
                    { new Guid("b41a6d36-f00e-4063-bcb8-55fecdb1bc15"), "878", "7814591273829396", null, null, new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6"), "12/13" },
                    { new Guid("b44210d4-37d4-47d7-bf61-ba075379683c"), "842", "2787149600476788", null, null, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32"), "04/04" },
                    { new Guid("b46486a1-f555-43bc-9c6f-0c900820ed1c"), "834", "8532529160625373", null, null, new Guid("5967c8b0-b331-4553-bab0-23d04868d703"), "09/06" },
                    { new Guid("b502c0db-80fb-460d-b042-fff901ea2b07"), "709", "7520623953208077", null, null, new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f"), "05/05" },
                    { new Guid("b5320ffb-a647-4c75-a8b4-3116f18a6d11"), "298", "9965665359256836", null, null, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827"), "04/13" },
                    { new Guid("b5e658f7-9666-4919-9561-527116dd497c"), "543", "3024008312582103", null, null, new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17"), "10/28" },
                    { new Guid("b715df20-c068-43fd-9f38-d57ebbb4e0fc"), "637", "9219459279956510", null, null, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807"), "11/11" },
                    { new Guid("b7606510-b9e1-4fb4-b91d-481dea3bb811"), "902", "6084979836727451", null, null, new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8"), "02/24" },
                    { new Guid("b7cf3468-8cbc-47f5-bf42-aca516dd51ac"), "009", "3747619328671505", null, null, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696"), "09/28" },
                    { new Guid("b8129e43-0725-4f4e-8d11-b0c74318c954"), "970", "1843615488296584", null, null, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53"), "10/23" },
                    { new Guid("b8207a8d-bf55-4af0-bc9a-10838a3a7a6a"), "438", "1667885984064250", null, null, new Guid("41bf7410-7941-4fca-a717-3874d970309c"), "09/11" },
                    { new Guid("b82657de-2b2b-4796-bceb-8dafcdc58652"), "299", "6500032632355889", null, null, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a"), "01/23" },
                    { new Guid("b9241e46-3b5f-462e-b737-e83b13f26f74"), "916", "2920330277659023", null, null, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5"), "06/08" },
                    { new Guid("b92f71c0-aaa5-462e-9505-9dd5a045a7a3"), "386", "8747695185285973", null, null, new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2"), "03/19" },
                    { new Guid("b9d7c99c-0369-4521-a21f-f277c7b73f54"), "176", "6535275980377506", null, null, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835"), "08/17" },
                    { new Guid("b9ef12db-02b5-4ee3-b0b8-6f4ce6359e54"), "470", "6715782026198622", null, null, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97"), "07/01" },
                    { new Guid("ba3aa965-51a1-44e7-9953-fe225269c13e"), "939", "8012764490314742", null, null, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb"), "07/25" },
                    { new Guid("ba7023f0-cb5c-4930-bd4b-498525e1d7a7"), "880", "9086552025396341", null, null, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49"), "12/09" },
                    { new Guid("bad8cba3-71d3-42dd-8d01-082703c17bba"), "937", "5828433251765848", null, null, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46"), "10/15" },
                    { new Guid("badbd8c6-bf18-4785-9bdc-a993127eb3b8"), "921", "8213881394258627", null, null, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96"), "03/05" },
                    { new Guid("bb469bf0-94e0-4720-b64c-e214546b405b"), "760", "5194017656782000", null, null, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf"), "07/21" },
                    { new Guid("bba5b354-ce66-479d-ae0b-bd6c337e155a"), "452", "7763202410498692", null, null, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940"), "06/27" },
                    { new Guid("bbc67e8a-208f-4eb6-b368-81579ac71a3d"), "033", "9761659090805807", null, null, new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b"), "12/01" },
                    { new Guid("bc0ea4f0-7ceb-47b2-8a5e-4a9d1355812f"), "178", "1896284043386159", null, null, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f"), "12/02" },
                    { new Guid("bc0f94c0-d507-4f9a-af1a-83dbb8eee64c"), "512", "5326067933521438", null, null, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7"), "04/08" },
                    { new Guid("bc102a6e-a4c2-4126-9225-67de2df951f9"), "461", "2355520553326228", null, null, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca"), "06/01" },
                    { new Guid("bc7d792b-505a-461e-ae31-c3763e4ff363"), "768", "1992288859348143", null, null, new Guid("99f374c8-d976-4051-99c3-7305e5fea09d"), "07/07" },
                    { new Guid("bd5e7970-d831-4485-a859-eafba8a01b3a"), "514", "2146583147882730", null, null, new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213"), "12/28" },
                    { new Guid("bd7118a6-0c2e-48cd-ba85-43fe9f4014c6"), "319", "6009439269568385", null, null, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb"), "04/22" },
                    { new Guid("bd8f3490-8435-4177-8d3c-d9a5c6d70915"), "788", "3214183314239948", null, null, new Guid("56acd153-5467-4111-9ca4-96f34533a050"), "12/26" },
                    { new Guid("bed239a3-d4b4-4025-9d4c-79e42a6670fe"), "166", "3438211706625848", null, null, new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938"), "07/05" },
                    { new Guid("bedd2d4d-806b-4a47-ae48-79123ce3f75b"), "711", "9345246025069943", null, null, new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2"), "03/04" },
                    { new Guid("bf1bf208-3ed0-4086-bc3d-b068260c70d9"), "813", "2737512272759573", null, null, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f"), "02/25" },
                    { new Guid("bfdbb12d-0cd5-4ea3-8ced-772894af2ed7"), "912", "9570130473870182", null, null, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3"), "10/16" },
                    { new Guid("c04f63a4-5cc5-410d-92d0-57cae4bbf234"), "035", "5622249074457533", null, null, new Guid("5967c8b0-b331-4553-bab0-23d04868d703"), "12/21" },
                    { new Guid("c0b601ee-aae2-4aeb-816f-80609951fbb8"), "363", "8465189019820481", null, null, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933"), "04/23" },
                    { new Guid("c1558042-2c15-4844-9d96-582f16b7fe99"), "582", "8862045209172410", null, null, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9"), "04/24" },
                    { new Guid("c1852847-2949-45f2-99c8-9e5fb094b63b"), "915", "8862005367792358", null, null, new Guid("02500051-99f5-4144-945b-877e80352edf"), "04/19" },
                    { new Guid("c1eda5e1-e644-4c41-9477-13ee3864994c"), "593", "7529909481896848", null, null, new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3"), "05/04" },
                    { new Guid("c277762f-ea93-427c-8bf9-8ebc49902841"), "763", "6740862332897174", null, null, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53"), "09/03" },
                    { new Guid("c2e9ec78-9879-4a79-bd23-e3f9313e7fb0"), "631", "8093497675805670", null, null, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb"), "02/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c2ecc788-bed3-49f8-84cb-a2cc908a036a"), "419", "5626279546289218", null, null, new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f"), "01/07" },
                    { new Guid("c3400dd3-0c9d-46be-be30-118fc1651273"), "494", "2675363855448970", null, null, new Guid("44275811-c945-4a4f-8382-272488a907aa"), "05/09" },
                    { new Guid("c35fab6b-361d-4649-9eb7-4cc52e9dcdd8"), "961", "5981916706064442", null, null, new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d"), "08/08" },
                    { new Guid("c3b3b699-3761-4b04-bca6-6a6c3b6c8f81"), "125", "7871203314065852", null, null, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b"), "06/18" },
                    { new Guid("c3be1af8-6ae7-48a3-a86c-5d89bee4e4c0"), "681", "1733950728842279", null, null, new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432"), "11/27" },
                    { new Guid("c3e8fd33-1369-43b9-b4f8-051ed2bcdee0"), "258", "3098177640526851", null, null, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6"), "04/26" },
                    { new Guid("c49e1106-b0d3-4521-b8ec-c86ffaf232d5"), "641", "4541237698715950", null, null, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549"), "08/01" },
                    { new Guid("c55237a9-2ef0-4909-a653-d1a246a9be12"), "157", "8457829992007857", null, null, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549"), "10/10" },
                    { new Guid("c5b4830c-cb5e-4b10-8fb1-0a613e6370c3"), "929", "8369905405825298", null, null, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e"), "07/27" },
                    { new Guid("c6aa494e-3fa1-4e80-b69d-764e89c7d64d"), "928", "4639882791483428", null, null, new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a"), "12/01" },
                    { new Guid("c73544e9-f320-43ad-82f7-e3b943367d6f"), "200", "9985624646750420", null, null, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3"), "02/02" },
                    { new Guid("c757f555-f60c-40da-9281-4ff07f390538"), "991", "9826942619660933", null, null, new Guid("02500051-99f5-4144-945b-877e80352edf"), "09/02" },
                    { new Guid("c793f71b-240c-4965-ab12-99a453fb4118"), "480", "3148753364984392", null, null, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e"), "11/15" },
                    { new Guid("c7f130cb-a27e-4d44-b698-364846f89298"), "652", "2073137458313212", null, null, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f"), "11/02" },
                    { new Guid("c7f936fb-9339-4133-ba28-c2464f8a324f"), "923", "3833695067060893", null, null, new Guid("99f374c8-d976-4051-99c3-7305e5fea09d"), "04/22" },
                    { new Guid("c86aea08-62e3-4b00-baa8-d5d01958e0de"), "633", "5080846768342139", null, null, new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe"), "12/03" },
                    { new Guid("c96f7f05-e45b-4ab0-b900-6e53e37b5d1a"), "894", "2912101467675892", null, null, new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042"), "04/27" },
                    { new Guid("ca31ea62-4521-4190-865e-b93e74baecfa"), "059", "5491235472367048", null, null, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89"), "03/24" },
                    { new Guid("caade125-c3c6-4ccb-8fc5-cb55d682d97a"), "943", "5105942057632298", null, null, new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab"), "01/14" },
                    { new Guid("cabab8b3-f874-46c2-84e1-d3072f75e829"), "901", "1934152384419548", null, null, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a"), "09/18" },
                    { new Guid("cb7163ed-5c5d-41bc-a927-8155d4bef9bd"), "340", "9016106332878321", null, null, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940"), "04/25" },
                    { new Guid("cb95aa78-8c5d-4d8a-b5fd-5014e9608c5d"), "363", "5038485060507239", null, null, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49"), "06/28" },
                    { new Guid("cc06e533-5361-4eae-8d25-726a05894035"), "458", "4725756741174281", null, null, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c"), "06/16" },
                    { new Guid("cca02c12-8f9f-43fb-ade9-9bd850522da1"), "046", "9054515862058693", null, null, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce"), "10/04" },
                    { new Guid("ccc79b18-9623-4e8a-8529-5f6d4eeef127"), "789", "8075411617891149", null, null, new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6"), "11/27" },
                    { new Guid("ccdc7bb3-2f59-4b02-a0c7-7cd84d88a193"), "653", "9633706008203920", null, null, new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925"), "07/03" },
                    { new Guid("ccf31f46-1a5b-4540-bf1c-4a9691e20e8c"), "444", "8550885515508206", null, null, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc"), "01/16" },
                    { new Guid("cd15d1b0-f846-47c5-9cd0-ea609fb31a22"), "756", "7834953548715081", null, null, new Guid("757e8d68-6931-451c-9e0e-78a03f927058"), "02/08" },
                    { new Guid("cd8ae3d6-acfb-4942-a906-bc6219a29f0d"), "127", "9020582749511360", null, null, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599"), "04/11" },
                    { new Guid("cda72b8a-bd13-4c1c-9875-55506f1e8625"), "116", "8460129003865283", null, null, new Guid("1909a070-eed8-440c-9e1c-16073e761c90"), "03/22" },
                    { new Guid("cdb4feaf-860c-4c01-bfe0-69ab5218a434"), "338", "3663050902099300", null, null, new Guid("5ee54399-9054-4429-a438-7a6f33482943"), "06/19" },
                    { new Guid("cdefac63-1e93-4277-92af-10f00cedda3b"), "071", "2393728038773453", null, null, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3"), "08/18" },
                    { new Guid("ce5d27cc-0201-4903-bd4f-a4eb99fa55cf"), "103", "7195990378395836", null, null, new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a"), "11/16" },
                    { new Guid("ce78aacf-56b8-40ca-9402-f531a82bc855"), "159", "7215042999049540", null, null, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d"), "02/21" },
                    { new Guid("cef24840-e4bd-4996-bde4-4f8964b68236"), "139", "9719225272848195", null, null, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27"), "12/24" },
                    { new Guid("cf1dcd15-379e-4d4d-ba76-cf5adfbec271"), "414", "9227689219630239", null, null, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0"), "06/28" },
                    { new Guid("cf861df5-3197-4476-a2ea-cfc319840920"), "336", "6985652637069489", null, null, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd"), "08/16" },
                    { new Guid("cfd92d3d-3b86-4bb0-b0fc-b0ca0f9ee73f"), "545", "4004204285698212", null, null, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec"), "06/12" },
                    { new Guid("cfe00325-782c-4710-acfa-7401b440d5df"), "038", "7667333897129534", null, null, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b"), "09/19" },
                    { new Guid("d034349f-3ebb-4789-b38d-5f722221b8aa"), "429", "9621107218281848", null, null, new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca"), "07/14" },
                    { new Guid("d03a13c8-6973-4292-a98f-a18703f7bda4"), "292", "5287460117085240", null, null, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7"), "08/14" },
                    { new Guid("d03e05d4-2b29-4085-a598-f48ab3071358"), "489", "3324017664753458", null, null, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0"), "05/02" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d0565d06-211e-46e5-bb62-917f1c0ef2eb"), "417", "1244611349703703", null, null, new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432"), "08/04" },
                    { new Guid("d0d38733-8fd0-477f-b3ab-2c4d4a95f68d"), "424", "5204719957887606", null, null, new Guid("489038c7-0441-436a-a527-66069a8b1473"), "12/23" },
                    { new Guid("d104d12e-c083-4945-8f40-2d40b51fad65"), "962", "1207832996204891", null, null, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3"), "10/04" },
                    { new Guid("d10b3dbf-b418-46a6-8045-17acb3a1d5d9"), "167", "9653087351199249", null, null, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337"), "12/17" },
                    { new Guid("d158d1c4-9336-463a-8e02-02e0507749c7"), "380", "3920970707590927", null, null, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6"), "03/14" },
                    { new Guid("d1dd0f25-74d0-4083-a16c-79bf97af2f96"), "650", "4930770053838239", null, null, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838"), "03/28" },
                    { new Guid("d20b8fac-dfcf-499d-979c-efb26909122b"), "390", "9459640453496677", null, null, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede"), "09/10" },
                    { new Guid("d28ea6f2-056b-4240-b640-1f5f4938656a"), "445", "9617013940849329", null, null, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16"), "02/25" },
                    { new Guid("d29c0576-43b8-42a5-ac5f-98d5ff4a8aa4"), "808", "4628544481628698", null, null, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091"), "10/11" },
                    { new Guid("d2df9c23-9e48-4827-94d2-9309e2a54944"), "787", "6073247190976694", null, null, new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2"), "07/06" },
                    { new Guid("d3040052-d99a-4de5-b1a0-9a1199fd324d"), "644", "3989725128251755", null, null, new Guid("e046fca1-590d-4528-9a08-8baa91140ac9"), "06/28" },
                    { new Guid("d33c3eda-91b9-4906-b8e3-fae1dc7721db"), "929", "9730026956696141", null, null, new Guid("eea73942-2019-41c4-9063-ab64deb92300"), "07/20" },
                    { new Guid("d35f4780-a9f5-46eb-9d0d-b73799d50f69"), "976", "7291831868009109", null, null, new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1"), "11/09" },
                    { new Guid("d40b4207-cdf4-4376-87c0-53b316eb176c"), "309", "9803209760263793", null, null, new Guid("072b74c5-5e1d-46de-9caa-66d36218f554"), "10/22" },
                    { new Guid("d41cad18-d69e-422f-adee-09da5a902897"), "513", "7445428277473380", null, null, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84"), "02/18" },
                    { new Guid("d42061e5-ce82-4608-a3cb-243e5e71568d"), "239", "5372443565074115", null, null, new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797"), "12/17" },
                    { new Guid("d42b39c0-8c05-49c1-8425-3bb34c23adbf"), "420", "8737471559032534", null, null, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285"), "03/26" },
                    { new Guid("d44947ae-e951-46f4-81a8-30e75c43b6c6"), "239", "2157228274898711", null, null, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0"), "05/10" },
                    { new Guid("d5349c86-2230-4056-a2a8-f71b4693f36c"), "940", "3010841124760373", null, null, new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc"), "01/17" },
                    { new Guid("d55b2279-4ee7-4d2d-865e-2761673080fa"), "850", "9281487481240002", null, null, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835"), "06/05" },
                    { new Guid("d5b31fe9-cfc5-469f-a493-4ef4b65d4773"), "620", "3386667805949420", null, null, new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc"), "03/18" },
                    { new Guid("d61b38a4-b447-406a-bf38-f430edb059df"), "292", "9264044844986964", null, null, new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb"), "01/04" },
                    { new Guid("d6934975-a5ae-487b-b980-1d057c14f636"), "163", "7995776213557786", null, null, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599"), "10/18" },
                    { new Guid("d6a86cf2-4951-4f67-a83c-ad26127aa89f"), "858", "8249105993015331", null, null, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337"), "05/23" },
                    { new Guid("d6efb4d2-236a-479b-b6fa-5078da8a0687"), "658", "7077970376769038", null, null, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2"), "05/27" },
                    { new Guid("d7819c32-1353-4f6f-8a2c-114a0e2d37b9"), "302", "5826132732829653", null, null, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2"), "02/24" },
                    { new Guid("d7f8c5f3-e3b7-4b7e-9399-acd4500b09f4"), "680", "6052243973881250", null, null, new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5"), "08/04" },
                    { new Guid("d88ab02b-3e4f-42bf-a1fe-844866f274dd"), "970", "2692780157397541", null, null, new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1"), "01/11" },
                    { new Guid("d96a0edb-5bb6-4d2b-852e-480d2e913309"), "101", "9649391550043088", null, null, new Guid("757e8d68-6931-451c-9e0e-78a03f927058"), "01/14" },
                    { new Guid("da250ab0-e067-4b91-8f33-3e74dc757b23"), "396", "4355988060116843", null, null, new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5"), "06/26" },
                    { new Guid("dacc846f-76ae-4992-915a-8643c82182b6"), "281", "1104708241783047", null, null, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58"), "09/07" },
                    { new Guid("daceb402-2849-485b-b701-af167051105f"), "283", "3220377764592245", null, null, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684"), "01/15" },
                    { new Guid("dadd433f-81c1-43bb-afc7-dc4fd9edb33a"), "452", "8381657477451831", null, null, new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61"), "06/22" },
                    { new Guid("dc1ef33c-6d53-4f05-a2c5-3070de6ff115"), "566", "7108533416088232", null, null, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807"), "06/26" },
                    { new Guid("dc8fe4db-5898-4750-9f65-54b206439b13"), "539", "3976584868472251", null, null, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8"), "10/06" },
                    { new Guid("dd98a079-4655-4470-80a6-8ba6df7f4869"), "517", "9060913945361940", null, null, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312"), "11/05" },
                    { new Guid("ddc53aa8-d4b8-466a-91cc-77abf82e883b"), "223", "7876106593209503", null, null, new Guid("e908834c-4383-4b44-a138-de5de4aa621a"), "11/15" },
                    { new Guid("de636a4e-3bb6-425e-b76c-84c7ebd0ffa3"), "182", "2911965769528640", null, null, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f"), "04/27" },
                    { new Guid("de96f89c-a41f-45a6-a62b-5287d850aecd"), "057", "6505233694844231", null, null, new Guid("41bf7410-7941-4fca-a717-3874d970309c"), "01/26" },
                    { new Guid("df04ab7b-2b47-4ca6-90a7-52d5e71caa9b"), "829", "9360088312656801", null, null, new Guid("3855a279-823e-41a4-ad2e-768e134c626f"), "01/15" },
                    { new Guid("df80502d-4758-4788-8abb-bf2d8cc37c04"), "623", "8730278706713544", null, null, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3"), "05/11" },
                    { new Guid("dfb3a8f3-dc5c-4021-b5d5-9bc74485a79e"), "249", "5950193798642819", null, null, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f"), "09/21" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("dff4e4db-c27f-42af-8aff-b0ba5b47d9ad"), "952", "1991873908156505", null, null, new Guid("8c396faa-ad98-400d-a562-77b4902806e1"), "03/20" },
                    { new Guid("e0593e56-34ec-4949-a186-509f75308649"), "800", "3785427881709337", null, null, new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86"), "10/21" },
                    { new Guid("e0874bc1-eb1f-4c30-8e94-ed24870574bd"), "977", "3109524972223728", null, null, new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4"), "12/07" },
                    { new Guid("e0dbc9d5-6a53-471e-a71c-d39dcc6d93b1"), "789", "1800391693360019", null, null, new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5"), "09/14" },
                    { new Guid("e12deaad-4c4f-4610-ab0f-1dea70758467"), "720", "1093806163171054", null, null, new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056"), "09/21" },
                    { new Guid("e15377b4-2549-4e45-9b65-162249465772"), "734", "2817363830193287", null, null, new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d"), "09/10" },
                    { new Guid("e1a18d08-a503-4171-a6a9-7b284ef1a5b2"), "485", "3856748949920173", null, null, new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f"), "09/02" },
                    { new Guid("e1d0861f-84e5-4948-a2ae-6d8dd00f3645"), "746", "5199773358986360", null, null, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071"), "12/25" },
                    { new Guid("e1e2086a-38e9-4f17-98c5-310405ec6e4d"), "479", "7743425048290408", null, null, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca"), "03/05" },
                    { new Guid("e26f18be-a3f2-40dc-809e-0ea341e853c5"), "449", "7084130295865151", null, null, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93"), "01/07" },
                    { new Guid("e2dcd7e5-912d-4d20-bc26-8950ab39d74f"), "476", "1810695395460864", null, null, new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2"), "01/03" },
                    { new Guid("e39b3fa8-7860-4541-a4f1-c83ef7396de2"), "103", "5389554586703469", null, null, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe"), "01/27" },
                    { new Guid("e3b9d4e5-2f7b-47c1-b91d-902e7e824cce"), "549", "8928884724031180", null, null, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12"), "08/21" },
                    { new Guid("e495b20f-e691-4224-96f7-03a20c59f20f"), "701", "7108382490749422", null, null, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc"), "08/04" },
                    { new Guid("e4ea5747-1f9b-4373-a37b-4eb917436969"), "252", "8396488247417991", null, null, new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07"), "11/02" },
                    { new Guid("e55455dc-7d8c-4304-ade7-726e197d5ea9"), "700", "7147519673178294", null, null, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827"), "11/02" },
                    { new Guid("e5b3fbbb-a03b-48d1-a2e4-c59bd3721911"), "468", "5952494491787895", null, null, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), "11/18" },
                    { new Guid("e5eb2edb-897e-4aee-b052-51b272d40c2c"), "833", "3228145229485141", null, null, new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7"), "09/25" },
                    { new Guid("e64c2040-d94c-46e5-a83c-8b97fdd0f908"), "967", "8816065334665603", null, null, new Guid("e50b5106-c89a-489a-b970-99024a53f892"), "05/23" },
                    { new Guid("e688c6ad-47c9-4e2d-9bdc-5c9b87b75fd0"), "453", "9539333674153807", null, null, new Guid("11712f31-db09-482e-bdab-2c19dff98304"), "04/11" },
                    { new Guid("e6c2b97f-a1d1-4599-aad8-a5d2bcf114d5"), "193", "8273069406622884", null, null, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d"), "04/03" },
                    { new Guid("e6eb6cee-54f6-42d3-90ac-10bc50098d5f"), "349", "6505914101993327", null, null, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da"), "03/27" },
                    { new Guid("e75f4a63-4f9f-4ba6-b1fe-5de9a56a05f5"), "359", "1664908615968621", null, null, new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3"), "11/12" },
                    { new Guid("e77421d0-9cbc-40d8-a7d1-0697f3bb5833"), "431", "6823730173119639", null, null, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6"), "08/23" },
                    { new Guid("e7747881-664e-41b4-8dc3-3db53744f8d3"), "636", "8067946301456112", null, null, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599"), "10/12" },
                    { new Guid("e7a6666e-f294-4574-9686-f006ce952375"), "685", "4749785673591774", null, null, new Guid("f06e4de8-bda0-47a2-811b-385e6e623687"), "11/11" },
                    { new Guid("e7c42015-fcb7-48dd-af6d-8a7a9fbf2faf"), "599", "2788854182835802", null, null, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44"), "04/15" },
                    { new Guid("e7f8b190-69a8-4a98-a894-f6c2fa39401a"), "028", "1731342600859030", null, null, new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5"), "05/01" },
                    { new Guid("e87441d3-48d5-43fa-bfbb-e553012aaa45"), "975", "2578300228696355", null, null, new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2"), "09/02" },
                    { new Guid("e936f442-294f-41f2-807d-45ec47399415"), "140", "2863403621686441", null, null, new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa"), "01/01" },
                    { new Guid("e97ac9d0-e4ad-4d91-aab2-c10f96a423db"), "574", "5612189591261520", null, null, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562"), "02/19" },
                    { new Guid("e99a627f-6c09-4fd1-a165-871a1733d154"), "782", "6441898392935332", null, null, new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4"), "07/27" },
                    { new Guid("e9c05017-a619-4037-8ba8-60e38a592ef6"), "422", "1949324200345512", null, null, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf"), "06/02" },
                    { new Guid("e9fc2d12-95f0-40a1-a6d0-d2b2cd22834a"), "879", "2725242312779253", null, null, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500"), "01/23" },
                    { new Guid("ea91adda-930b-43cb-b48c-9a3ff9fcbcac"), "306", "9135574945765362", null, null, new Guid("5db09bf3-8454-4fff-bfe9-003854416f82"), "12/02" },
                    { new Guid("eabc0ae7-f29c-41ad-9c70-bf7818d292e3"), "507", "9298803637707170", null, null, new Guid("e908834c-4383-4b44-a138-de5de4aa621a"), "11/14" },
                    { new Guid("eac2bea4-d0b6-416d-9d72-89ce24844bc9"), "418", "6406514856269293", null, null, new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04"), "11/23" },
                    { new Guid("eb0e6df8-e3d2-4ce8-923c-a1159dbd4246"), "896", "7232501382452829", null, null, new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9"), "02/02" },
                    { new Guid("eb64fdfb-56ba-482d-a98b-e4351cf966ff"), "283", "8793748757115624", null, null, new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c"), "08/13" },
                    { new Guid("eb6cf6f1-fd3c-4f9e-90c7-5193ac2538b6"), "492", "4727203068605807", null, null, new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee"), "08/20" },
                    { new Guid("eb732cdf-9a78-40f3-8e93-f5b2e3a312ad"), "915", "9249305349226861", null, null, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3"), "12/17" },
                    { new Guid("ec31df53-6283-4a73-8aa8-2d78d6f60b1e"), "254", "4675070901943066", null, null, new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce"), "08/17" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("ec99e1b3-92f2-40db-b849-dca0689e801d"), "950", "8218501613026864", null, null, new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5"), "06/13" },
                    { new Guid("ed2f492b-5b21-4b3d-a3fc-98bb2667d092"), "821", "4237050916935717", null, null, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696"), "09/23" },
                    { new Guid("edf0574c-e06e-4604-90ee-67fc457226a5"), "363", "8721870139065851", null, null, new Guid("46075330-4d61-4bde-be40-948e47bd19fb"), "07/23" },
                    { new Guid("edfd126f-01d4-4162-a82d-b411959f5b7f"), "707", "1560537000639076", null, null, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db"), "06/13" },
                    { new Guid("ee10f7b1-c727-4229-bf91-3d7c971a5646"), "494", "8249482825906267", null, null, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020"), "07/01" },
                    { new Guid("ee9ce913-830c-438a-acba-c4bab5444bc1"), "737", "1338076982398165", null, null, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef"), "04/08" },
                    { new Guid("eeaa088f-eb33-4aba-a008-ffa6849763be"), "053", "7909863083724840", null, null, new Guid("5ee54399-9054-4429-a438-7a6f33482943"), "10/16" },
                    { new Guid("ef3f872e-53b2-462e-8366-587c68845cf9"), "191", "5011637484444272", null, null, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969"), "05/21" },
                    { new Guid("ef58d218-43f3-4c3b-a978-4e381222f702"), "987", "9807698820679118", null, null, new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803"), "06/19" },
                    { new Guid("efbd9ff0-5902-4789-bb8e-ae0e53604938"), "276", "8776869171048431", null, null, new Guid("f06e4de8-bda0-47a2-811b-385e6e623687"), "09/17" },
                    { new Guid("effce734-3660-47b9-91dd-9de1b2bdd733"), "578", "3840250992321359", null, null, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede"), "05/26" },
                    { new Guid("f02d3ba5-a204-4282-b071-d3294ac75fc3"), "131", "7439985855536571", null, null, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933"), "01/13" },
                    { new Guid("f074a82a-8bf1-47c8-b48e-52932c5077c8"), "193", "1528688640240798", null, null, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3"), "12/06" },
                    { new Guid("f0dbcb97-c776-4437-ba9d-b817201d14a3"), "410", "6219110266500669", null, null, new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f"), "08/18" },
                    { new Guid("f1063294-070c-4765-96ec-2cd93c22221f"), "698", "5121596965396273", null, null, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e"), "09/09" },
                    { new Guid("f18f052d-7226-435d-8309-df6b88b8cce3"), "673", "2623048559897944", null, null, new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe"), "02/25" },
                    { new Guid("f1c45bb4-f7ae-4045-9e2f-cc3adb08249b"), "932", "1643898906082909", null, null, new Guid("46075330-4d61-4bde-be40-948e47bd19fb"), "11/16" },
                    { new Guid("f1eeb547-987a-4f52-968b-b29680334cf6"), "642", "2732045617713432", null, null, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6"), "06/07" },
                    { new Guid("f23117cc-6f37-4fc1-ac75-29f3365efe2a"), "804", "4012370615876605", null, null, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807"), "06/04" },
                    { new Guid("f28061c6-8437-40c0-bf8d-a9c8434b3c0e"), "736", "2306401037958788", null, null, new Guid("1909a070-eed8-440c-9e1c-16073e761c90"), "05/09" },
                    { new Guid("f466a335-e81a-4652-83c8-d624dc5d2d5a"), "292", "9726927070325229", null, null, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80"), "01/26" },
                    { new Guid("f466d943-aa36-49bb-b6dd-1e6b796b4c07"), "523", "2504187994279750", null, null, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1"), "07/02" },
                    { new Guid("f4cfbdc4-0c00-4d57-98ca-c283f5598959"), "978", "7752477606332237", null, null, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742"), "05/11" },
                    { new Guid("f57b19b1-7290-46ca-97b3-3957d3d8627d"), "441", "2293349133972376", null, null, new Guid("c8507284-511b-425f-9aab-13ef42992af5"), "04/01" },
                    { new Guid("f57bf4a9-fc28-4030-bdb8-cdb6e0db8b50"), "025", "8456252552473094", null, null, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), "07/02" },
                    { new Guid("f648acb2-d65d-4c04-aa5c-647cc7b31e00"), "812", "3950444470534077", null, null, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3"), "11/14" },
                    { new Guid("f6758466-5bb5-4dc8-b706-472043290817"), "881", "1935345609049057", null, null, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7"), "09/07" },
                    { new Guid("f6d10db4-7c04-4738-858b-2d5df5af032c"), "804", "1771851700307272", null, null, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e"), "03/06" },
                    { new Guid("f703b4e0-30e3-4f69-b0a9-cb5a981776f2"), "200", "8277886571179030", null, null, new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607"), "03/07" },
                    { new Guid("f71e5170-9614-49c4-9953-0d804e30e6fa"), "867", "4279598122789191", null, null, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311"), "03/03" },
                    { new Guid("f7620783-155b-4a99-a1b9-7570b1512150"), "777", "6095389569864514", null, null, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e"), "01/09" },
                    { new Guid("f7d52cb4-67c2-4f3b-aa86-2b422366228b"), "349", "1210111301969787", null, null, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff"), "11/17" },
                    { new Guid("f80ae990-5308-4225-bc2e-97bc992e2e30"), "406", "3148386785133875", null, null, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6"), "11/15" },
                    { new Guid("f82db52c-25de-4355-b9f3-cf03541745de"), "327", "5265840196966843", null, null, new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607"), "05/13" },
                    { new Guid("f84ddd05-cef9-4932-a417-146e62718298"), "631", "9576390203622769", null, null, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9"), "03/24" },
                    { new Guid("f864c97c-9bcd-4ec4-9209-c41b988e1e64"), "536", "4543508377609659", null, null, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7"), "08/08" },
                    { new Guid("f86e9fbd-cd75-4e08-96b3-4d8e56bcd237"), "292", "8147610040030388", null, null, new Guid("f2542110-27bc-4868-b96c-53e10a66800f"), "11/25" },
                    { new Guid("f890069d-1017-4a07-8572-1eaaeaca22b4"), "385", "6589111454097843", null, null, new Guid("5ee54399-9054-4429-a438-7a6f33482943"), "10/20" },
                    { new Guid("f89e4eda-c42f-483c-bff2-47751f0d065e"), "900", "9438969942025164", null, null, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a"), "06/18" },
                    { new Guid("f8e6e92e-7061-4bab-b2ae-d9822e6196ab"), "395", "4064184665556437", null, null, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e"), "09/13" },
                    { new Guid("f98521bd-6670-4f98-8a47-21938c617dd1"), "420", "7189788230303373", null, null, new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a"), "11/10" },
                    { new Guid("f987453f-34f9-4919-b73c-02eba6815703"), "584", "7776671450843428", null, null, new Guid("56acd153-5467-4111-9ca4-96f34533a050"), "11/09" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("f999c947-1609-4f80-8cd8-90fa01d0bef2"), "969", "2862345561792081", null, null, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce"), "09/18" },
                    { new Guid("f9e43bfb-d39d-4f06-a0d9-10f7a099818c"), "438", "4770461254102789", null, null, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e"), "02/16" },
                    { new Guid("fa0f68d3-606b-4da6-84a2-a6bb8917534f"), "090", "8932316190348368", null, null, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc"), "12/02" },
                    { new Guid("faba8ce3-3c9e-4857-8783-d685f2a3598b"), "649", "8712698827086438", null, null, new Guid("5f140f7e-803a-444d-8158-03815cbd832c"), "12/18" },
                    { new Guid("fabf5ed9-4691-4efe-8d2e-ecd076d1b278"), "575", "3702253803498727", null, null, new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf"), "11/16" },
                    { new Guid("fc9e39e0-7334-4642-808d-7c330243c982"), "342", "6212269518306713", null, null, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f"), "11/12" },
                    { new Guid("fca0c002-a854-4d4b-ae9c-18320b8f0dec"), "704", "2815779556565757", null, null, new Guid("09fd275e-b209-4f17-84ed-5884b76fc276"), "10/05" },
                    { new Guid("fd1ffaae-d00b-4ffe-8099-1328428ed282"), "073", "4390921603931545", null, null, new Guid("26db4c52-c906-415a-848e-eb60cadca362"), "04/08" },
                    { new Guid("fd347358-6f6d-429f-93fe-a00e37b57597"), "597", "2804342156420537", null, null, new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc"), "04/07" },
                    { new Guid("fe021aa8-e8ed-4aed-b3a4-41b4e53c17d1"), "291", "8672512387962244", null, null, new Guid("76807668-f1d2-47ed-a084-0771d51bc761"), "08/12" },
                    { new Guid("fe49521a-9016-4166-ac9b-5c9a7459ed3e"), "576", "6068802591986852", null, null, new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5"), "07/19" },
                    { new Guid("fe67e0f3-0688-4404-82f6-e8d4d708e79a"), "114", "1659825995730835", null, null, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1"), "05/27" },
                    { new Guid("fe98e941-2b18-46c0-bd7d-9b7f48713cb5"), "424", "1680555865854773", null, null, new Guid("757e8d68-6931-451c-9e0e-78a03f927058"), "09/01" },
                    { new Guid("ff8832e3-42de-49c6-958c-fae6dae48ec4"), "013", "5022214940415956", null, null, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27"), "08/02" },
                    { new Guid("ffec49f7-82a9-4011-8fb9-8d062bde8921"), "247", "4148173091207970", null, null, new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c"), "01/06" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("003cba46-71c4-47c1-b7b4-52db6955503f"), null, null, "+353 14 (438) 65-51", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("00720271-0ef1-4d4c-96dc-3ac4bb8880ec"), null, null, "+150 64 (940) 44-87", false, new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1") },
                    { new Guid("0175372c-0f35-4533-ac1c-a881a433b0db"), null, null, "+285 67 (551) 89-41", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") },
                    { new Guid("018ad86f-d571-46e5-8131-b7dd330a7543"), null, null, "+272 52 (846) 45-31", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("026167b1-7369-40e7-b7a7-dd067250856d"), null, null, "+772 33 (245) 19-86", false, new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9") },
                    { new Guid("026f6322-41d9-4c4c-8af2-038de6714e77"), null, null, "+946 32 (081) 96-17", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("028e5af8-89ac-4f14-aa79-59d0d564f6a8"), null, null, "+776 11 (420) 10-52", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("03481b93-abd5-4b93-9a47-c12cf39131d7"), null, null, "+850 78 (562) 56-73", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("0353fa80-38cb-4131-b33b-4f1c51c4e5da"), null, null, "+181 74 (868) 67-49", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("0375bd55-1f58-4921-8a22-c50808c038f1"), null, null, "+900 72 (786) 85-20", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("03a16589-f2f2-486d-b654-80978065dde9"), null, null, "+230 93 (590) 21-81", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("03c404a5-2f29-4ff5-a5de-5565d0bf7925"), null, null, "+392 47 (438) 11-53", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("03d60723-60b7-47ff-a209-640638926e8c"), null, null, "+673 64 (725) 16-59", false, new Guid("09fd275e-b209-4f17-84ed-5884b76fc276") },
                    { new Guid("04bb4ffe-eb27-47d9-aeb3-d544d4278c68"), null, null, "+989 33 (925) 13-18", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("0502af7f-e30f-4ecf-972c-3b995bde8eb3"), null, null, "+820 52 (899) 82-91", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("052d5d84-c545-484c-8ff9-2c1d45cd224b"), null, null, "+587 40 (146) 03-16", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("05b66352-01b2-425b-a277-ded526c4e1cc"), null, null, "+234 15 (802) 50-87", false, new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab") },
                    { new Guid("05cda71e-9283-42ed-8295-f4cf9184a4d4"), null, null, "+611 61 (374) 39-82", false, new Guid("c8507284-511b-425f-9aab-13ef42992af5") },
                    { new Guid("05f1d428-c00d-424c-b201-dde2f5cebef8"), null, null, "+495 14 (895) 62-02", false, new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2") },
                    { new Guid("065293ea-5bc9-4688-a465-db1162916972"), null, null, "+526 54 (149) 69-79", false, new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07") },
                    { new Guid("06b4c49a-a8cd-4bf1-8b64-fcb4c07da8eb"), null, null, "+423 37 (227) 92-21", false, new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("07219697-d8f0-462a-b669-5a4bef680f4b"), null, null, "+499 21 (838) 54-43", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("076e50e3-ae4f-4b7a-be6f-18aac38ae9ed"), null, null, "+102 83 (772) 27-93", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("07b61bbf-29dd-429f-923d-9f655b061275"), null, null, "+247 69 (002) 00-47", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("07f9ecda-a687-4aca-a9a6-e5e4a05bdda1"), null, null, "+791 70 (893) 56-64", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("085eba78-7b8d-4bce-aa43-ad4610a594f9"), null, null, "+904 47 (081) 13-08", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("089b48ff-53c9-4286-ad5f-64ad8902f9bf"), null, null, "+816 99 (888) 17-90", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("08e797f9-7e41-4d78-be87-bfe5da3f308a"), null, null, "+810 00 (260) 56-01", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("090c1fa3-eed4-473c-89d9-b753687d03be"), null, null, "+698 23 (644) 59-49", false, new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644") },
                    { new Guid("09874b6f-684c-4bd4-99f0-1d2f105e9b18"), null, null, "+237 93 (538) 68-14", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("09bc12ca-60d9-4e05-b306-25b08f2b4f4b"), null, null, "+297 64 (826) 76-40", false, new Guid("223295f7-9195-4510-8bcc-44f043830497") },
                    { new Guid("0a209f7d-2004-4937-ad8b-1b4f3f5f41df"), null, null, "+256 18 (342) 03-80", false, new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f") },
                    { new Guid("0a5415c3-467a-4bc7-99c6-2898d470c8dc"), null, null, "+976 39 (815) 02-95", false, new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("0aa49705-caf7-4a13-94ed-8504763a34b7"), null, null, "+583 85 (214) 25-36", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("0aa68210-dd88-4ab1-a940-aabd4a716cb1"), null, null, "+146 79 (757) 23-92", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("0afb074a-c47d-40a3-857f-df1e334fac51"), null, null, "+90 04 (662) 99-95", false, new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a") },
                    { new Guid("0bacab95-00b0-4a17-8193-29ea20be2ce6"), null, null, "+348 37 (480) 87-00", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("0bc36652-fa10-43c9-987d-a4c5cda3e4ee"), null, null, "+773 05 (080) 54-41", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("0c9aa3fd-a6eb-4688-a2b2-9ba7c1322fe4"), null, null, "+194 70 (270) 31-78", false, new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640") },
                    { new Guid("0cd5e783-27f2-46fe-9739-22fa369e178e"), null, null, "+203 46 (845) 57-26", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("0d1527d1-06d8-4d85-b7ba-bec778bb1e5d"), null, null, "+19 73 (902) 19-37", false, new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") },
                    { new Guid("0d4287f6-03ed-4ba9-9cf3-b9ec186c08cb"), null, null, "+807 01 (436) 42-80", false, new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc") },
                    { new Guid("0d66f355-dd9c-41eb-9582-ffc9bd8014b0"), null, null, "+290 86 (522) 93-07", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("0dd43a81-71d0-491d-a55b-fdafe153c705"), null, null, "+46 36 (737) 73-34", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("0de6fd75-d712-4728-9706-b57cf58889b6"), null, null, "+37 04 (369) 60-91", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("0e00ece5-5d38-4fa6-811b-e2aa08347e09"), null, null, "+852 94 (851) 76-84", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("0e1401c7-4e56-4f0d-bb7b-a2fb2a9c136a"), null, null, "+690 36 (134) 78-75", false, new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2") },
                    { new Guid("0e54efa6-1b87-4c3a-859f-f64e12a85116"), null, null, "+22 73 (998) 10-25", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("0e821158-73e7-4555-bb71-ce6c41d1da30"), null, null, "+508 75 (666) 71-65", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("0e98777e-44bc-4675-8d71-43b444d9b44f"), null, null, "+341 37 (285) 97-70", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("0ec691f5-6035-45cc-a754-09f100bac87e"), null, null, "+993 89 (616) 02-84", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("0f508ebe-6fd4-4fc6-b9f5-bb87e17128ad"), null, null, "+245 79 (973) 23-83", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("0fa4e1e3-0598-421d-baa5-c366b1719ec5"), null, null, "+870 94 (067) 22-92", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("1037c3d7-5406-42e1-9928-c81dd43e8d0e"), null, null, "+89 87 (398) 68-78", false, new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae") },
                    { new Guid("105a67e6-f9f4-45b1-b220-372f6fa88934"), null, null, "+859 24 (257) 31-08", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("105c787f-6115-4194-95f0-ed4c7fa60843"), null, null, "+406 99 (348) 45-74", false, new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a") },
                    { new Guid("10d0b4be-d200-4794-a941-f008451a8be7"), null, null, "+650 67 (526) 41-31", false, new Guid("9bea6011-9948-451d-9195-7c4cc4339cba") },
                    { new Guid("10f80f1f-095e-4e10-9ad7-dc5e6ab64edd"), null, null, "+182 68 (917) 61-47", false, new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f") },
                    { new Guid("114ca0ee-77b5-4efa-a103-bc1cfad75ebd"), null, null, "+691 61 (496) 93-00", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("1225e7b9-33aa-4619-b85d-a97e24565b6b"), null, null, "+767 73 (073) 31-67", false, new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") },
                    { new Guid("124323f3-9cf2-4caf-a440-b9dc1941931d"), null, null, "+518 63 (927) 87-13", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("12590311-05b7-4348-957f-12252349ef50"), null, null, "+850 80 (123) 32-86", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("12877aa3-660c-4ac8-9bf2-dd5951aad16d"), null, null, "+243 73 (986) 55-16", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("12f861a7-7a9c-44a5-bed2-ff4cfde641fe"), null, null, "+421 25 (253) 24-04", false, new Guid("52ac7c81-4d50-47c5-a190-a30e4dbe8e7a") },
                    { new Guid("13285866-41a1-4fd4-89c3-9932d280d4ce"), null, null, "+454 29 (351) 13-63", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("132f11d2-2c4f-40bc-8981-de6a5574462f"), null, null, "+12 22 (482) 48-62", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("13e2ab77-7aff-4a1b-8714-95eaf6af5444"), null, null, "+674 44 (362) 82-87", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("1401f8cd-21d3-43f5-bb5a-cd23e236b71e"), null, null, "+178 01 (468) 93-54", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("145c9a1b-fe5d-420a-a44c-f7e9e0d149d2"), null, null, "+166 69 (145) 18-10", false, new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("14728662-8f61-4502-8a75-e34e1ccd39ff"), null, null, "+328 00 (812) 70-72", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("14929911-a69d-474d-9975-e5797e8ebd12"), null, null, "+810 78 (338) 99-72", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("14fecebf-5df7-427a-97e6-a42834967e35"), null, null, "+654 92 (570) 84-46", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("1509fcc6-491c-4bb4-92c7-023dd9fa78b6"), null, null, "+192 21 (407) 95-67", false, new Guid("f819889a-570b-4521-a36f-42d900233678") },
                    { new Guid("15767494-44b6-413f-b757-d5c0e39b151c"), null, null, "+228 48 (747) 59-30", false, new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5") },
                    { new Guid("16d36379-ab0e-488d-95af-cca6922e3866"), null, null, "+117 59 (252) 30-06", false, new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("170fd495-a967-498e-9b04-39f8d07222c4"), null, null, "+487 08 (049) 64-84", false, new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed") },
                    { new Guid("177d19de-7d4b-441e-be75-db4091545bd0"), null, null, "+412 51 (606) 47-03", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("1787844a-6fa4-4741-a682-8238ac5fac10"), null, null, "+411 51 (889) 68-28", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("17a2d5bc-c8a2-44c1-8edd-0dfba358a8b0"), null, null, "+823 16 (842) 45-61", false, new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c") },
                    { new Guid("17a9ad6b-9583-48b3-86f2-b94136c614a3"), null, null, "+532 37 (639) 80-52", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("186639c4-8a86-494c-856c-37b020ac409a"), null, null, "+444 30 (477) 36-27", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("18a4b93c-1d28-423b-831e-f6cfc76d9ca9"), null, null, "+245 21 (743) 49-90", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("198bc916-a10d-4a7d-9f28-0ac317aebcf1"), null, null, "+628 70 (387) 89-29", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("1a636ad4-b943-4ac3-83eb-4d1c1933e694"), null, null, "+131 06 (940) 62-27", false, new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca") },
                    { new Guid("1ba1e930-1099-4534-8333-df272ccb4170"), null, null, "+719 21 (393) 15-98", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("1d25d349-2ee7-493e-89a3-ded789e4887d"), null, null, "+260 59 (847) 34-56", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("1d2cb9fe-3995-41e1-b037-3fda522b38b1"), null, null, "+205 84 (637) 11-96", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("1d4fd541-69b7-4d50-9f64-c4294a6faced"), null, null, "+569 23 (928) 45-91", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("1d594b9a-873f-4b85-a264-c87f76aa04bc"), null, null, "+725 31 (790) 21-28", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("1e20a7ca-36ac-4ec3-8b63-873d9d1e9fc1"), null, null, "+308 88 (665) 84-50", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("209f38e9-368a-4725-a68a-9bbb3b4f559a"), null, null, "+161 31 (269) 16-90", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("20bc818f-4d32-4106-873c-91b1e5ff4f0e"), null, null, "+710 70 (889) 55-79", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("20e2533e-f477-4fc9-a3c0-9cb55254adc1"), null, null, "+155 23 (152) 81-92", false, new Guid("072b74c5-5e1d-46de-9caa-66d36218f554") },
                    { new Guid("20ed5442-c077-487e-b2d8-fe791198543e"), null, null, "+745 15 (965) 12-06", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("217b5aa2-423c-4fcb-a315-49de35eb3f6e"), null, null, "+66 81 (741) 06-96", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("21a82f38-25e7-406e-a571-40f12cfeaac7"), null, null, "+402 17 (512) 53-45", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("2284ffb9-fd3f-4ae1-a2b5-c2ce1d0bf513"), null, null, "+282 44 (719) 04-40", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("2299a1fe-0e2d-42f5-a8c0-90dac52dce17"), null, null, "+387 77 (594) 25-00", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("22e42d51-fef0-4213-945f-5a2667317fe1"), null, null, "+722 08 (487) 54-78", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("23184023-12a8-4343-b3de-6acc04a011b5"), null, null, "+119 96 (234) 29-76", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("2324b777-af14-4ca9-95e8-70cd6241ed47"), null, null, "+225 22 (961) 74-28", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("2358c753-ebac-4583-b3d2-90f165b52169"), null, null, "+516 59 (005) 85-31", false, new Guid("ee6741f4-6370-4202-aff1-149d13e38e9f") },
                    { new Guid("23c44a20-fe3b-4f86-a99f-3b223756acdb"), null, null, "+279 70 (015) 74-62", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("23caa41f-ae27-446f-a3c2-a455b839e131"), null, null, "+601 22 (666) 81-83", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("24222a1e-3510-4014-a384-f02037eedb29"), null, null, "+337 17 (415) 98-38", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("255002fb-dbe9-4928-879f-80f3dd4e1783"), null, null, "+599 26 (088) 10-22", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("255e2264-6b08-4495-8dea-726acc1b4135"), null, null, "+104 32 (369) 97-39", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("25a24969-d31e-4534-a33a-49ba127cabe7"), null, null, "+242 46 (363) 14-02", false, new Guid("9bea6011-9948-451d-9195-7c4cc4339cba") },
                    { new Guid("26140915-7356-4eff-bc04-c176de29e284"), null, null, "+704 34 (831) 10-79", false, new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5") },
                    { new Guid("26621ada-58e3-4908-a5a2-5d641575f4d2"), null, null, "+265 26 (679) 12-65", false, new Guid("8c396faa-ad98-400d-a562-77b4902806e1") },
                    { new Guid("268b65e8-9e6e-4a43-b144-01b956dfa6eb"), null, null, "+685 09 (318) 55-36", false, new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("26f0924d-7dba-4946-b65e-be1c3dc4392c"), null, null, "+780 44 (100) 12-33", false, new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483") },
                    { new Guid("27011edb-c7d4-4d22-be33-e64c6c772f12"), null, null, "+282 96 (742) 99-77", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("27a5fe89-866f-4e1c-9b31-33522dac7261"), null, null, "+525 45 (848) 60-70", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") },
                    { new Guid("282f44a5-ee08-465b-b199-5fe64a4d56cb"), null, null, "+760 95 (540) 18-62", false, new Guid("9600b978-d436-4b7d-926b-34c5ab2a76ed") },
                    { new Guid("283464e8-84de-4f7e-8fa1-c2f21fa03bf3"), null, null, "+219 92 (806) 09-78", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("28558fc0-4fa0-4dd1-ac7b-ad9f2919e714"), null, null, "+526 63 (891) 44-16", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("2902c9db-2e57-49c4-8721-b24263056757"), null, null, "+568 57 (030) 44-79", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("294bca4b-6272-4d6a-b481-fea7286288d9"), null, null, "+44 66 (934) 76-47", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("2983ed92-1286-46bf-a8f5-da19f713a17d"), null, null, "+623 76 (814) 22-84", false, new Guid("02500051-99f5-4144-945b-877e80352edf") },
                    { new Guid("299c1327-fc78-4711-a1b6-ac49efa49c6c"), null, null, "+777 05 (588) 03-18", false, new Guid("95a32c20-4120-4d8b-b147-87f8e9b418e1") },
                    { new Guid("2a484a1e-19f5-4bdc-bc36-10b040a6f8dc"), null, null, "+949 92 (459) 37-41", false, new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("2a515d3e-6a6e-41f7-bd20-45cb30046989"), null, null, "+659 92 (373) 58-42", false, new Guid("26db4c52-c906-415a-848e-eb60cadca362") },
                    { new Guid("2b03edd1-2137-4cca-9f39-6ecce2600db3"), null, null, "+203 98 (835) 27-51", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("2b7c5b19-eda2-4513-9b8b-affae92f1004"), null, null, "+261 58 (341) 00-02", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("2b81d679-7814-4396-8162-b7f371a2c49f"), null, null, "+10 90 (727) 25-02", false, new Guid("02500051-99f5-4144-945b-877e80352edf") },
                    { new Guid("2bb6c7ad-a8df-4b8d-a8f2-1663fd1f4c13"), null, null, "+86 91 (831) 97-56", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("2bdfc776-5f20-4929-b2d5-c9df9437c96b"), null, null, "+200 86 (203) 69-01", false, new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe") },
                    { new Guid("2c43977e-1251-4b1b-8cfb-96783a170daf"), null, null, "+950 67 (718) 51-27", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("2d4ae84b-62c6-471f-a31d-93a57dcab5d5"), null, null, "+784 23 (538) 34-33", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("2d656a9a-3003-4389-97f5-f582e5bc4f4e"), null, null, "+382 93 (414) 28-48", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("2d7e77cc-a02d-49fb-8d4e-b85e60b14cee"), null, null, "+921 09 (076) 47-29", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("2de1e87f-df1f-406b-bebb-ba59b8eaf4a3"), null, null, "+466 89 (716) 44-83", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("2e6a53b6-052e-4d4b-aa19-a67387411cdb"), null, null, "+567 85 (780) 18-09", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("2e8871e9-26aa-4aab-8a35-c91629e3ef0f"), null, null, "+88 36 (682) 37-23", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("2ead0542-f798-490b-928f-e8746a70ebb6"), null, null, "+853 90 (694) 62-41", false, new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") },
                    { new Guid("2ebabbe3-a575-4dee-8812-bc81d953a857"), null, null, "+661 41 (309) 40-99", false, new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084") },
                    { new Guid("2efb64a1-ad1b-4097-a467-6b68153f49bc"), null, null, "+425 47 (618) 21-79", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("2ff349f7-662f-44d1-949f-712ca66fb05d"), null, null, "+671 58 (377) 36-19", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("30284f2a-21da-47bc-8768-20dc91a1db99"), null, null, "+748 00 (567) 36-38", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("30494b07-bff2-4b9d-8421-04e81864b036"), null, null, "+674 70 (581) 51-27", false, new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512") },
                    { new Guid("304f7384-ed9e-45b4-a965-fe095976ba2a"), null, null, "+473 61 (435) 77-88", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("309ad1ef-a4f9-458d-8d94-707d65f519a5"), null, null, "+878 99 (986) 09-30", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("30b2f345-b18a-458d-b382-a13f96fdd905"), null, null, "+519 80 (041) 88-13", false, new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938") },
                    { new Guid("30e09a30-f023-4330-9519-5e2056ac92fe"), null, null, "+388 49 (281) 71-75", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("311f7a56-cd7b-4478-9874-a9945d0ece1f"), null, null, "+47 98 (908) 79-04", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("312092f8-2c4f-4cc6-aee1-33b8c6943e31"), null, null, "+798 33 (498) 97-73", false, new Guid("36b35b89-da67-408b-9178-d5d020a70822") },
                    { new Guid("3133983c-d118-4b10-8a57-bd21b6f9d113"), null, null, "+318 20 (596) 98-99", false, new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756") },
                    { new Guid("31721b84-044c-4095-a9ae-c363d6869266"), null, null, "+406 48 (101) 52-07", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("32404d44-c7bb-4c03-bf58-6766a053d8a6"), null, null, "+31 70 (891) 43-03", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("3259d4bf-4843-41c7-aa63-b31ec46cdf8f"), null, null, "+851 03 (227) 02-04", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("32dcbfea-e39a-4393-acb0-16eac1e0d597"), null, null, "+40 13 (948) 26-78", false, new Guid("f2542110-27bc-4868-b96c-53e10a66800f") },
                    { new Guid("32fba782-7b25-4772-a89c-e3b7249047f6"), null, null, "+683 29 (108) 04-95", false, new Guid("424adfec-f7e4-44f9-b3d2-451e9d1f2b07") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("331f9de3-6287-474e-b7f3-bc3aa3824866"), null, null, "+957 25 (063) 03-37", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("33e98044-c5e8-4cf7-8cc4-b2189d7c6b64"), null, null, "+616 68 (627) 23-15", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("33eb2557-32bc-4f0a-bdf5-6a62fc9b5bc2"), null, null, "+722 66 (210) 62-57", false, new Guid("370052d4-d1c9-45aa-b0a3-1087c2ffb938") },
                    { new Guid("340d2898-e8c7-41a0-8ea2-c42bbde17b5a"), null, null, "+913 71 (773) 45-96", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("340fcece-1626-49f7-8c1e-5cff8e6c52ec"), null, null, "+475 73 (742) 15-67", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("35974f6a-3549-4cba-8ac6-ce530102f053"), null, null, "+115 55 (682) 34-21", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("35f2b624-c4e8-4cc5-9337-d473f6cf91c7"), null, null, "+687 38 (182) 85-12", false, new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("3601176d-9f94-44e4-be49-4b569d5814e5"), null, null, "+142 30 (923) 99-81", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("3618d82f-170b-43ec-87c1-f95f8adb8dac"), null, null, "+221 53 (394) 26-00", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("365924c2-7924-4cdf-97a6-78be0f761cf6"), null, null, "+86 73 (277) 31-43", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("3691557c-cd2c-435f-86ba-2b4450cba09e"), null, null, "+341 28 (366) 15-15", false, new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("3726163a-13c2-4829-859e-945e4199abff"), null, null, "+422 77 (680) 42-59", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("372a9723-01da-40ea-9a35-0a57e8be3ea0"), null, null, "+679 86 (673) 86-80", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("37819176-11ba-4563-b8e1-43f810d572f6"), null, null, "+565 67 (268) 20-44", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("384c234d-3373-4a9c-96e1-844fbc206ccb"), null, null, "+961 58 (245) 64-40", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("38afa56d-8b34-420f-9894-adefe8a01c18"), null, null, "+654 90 (966) 64-35", false, new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f") },
                    { new Guid("38c3916b-26da-4131-a001-2df769e6ddcf"), null, null, "+526 87 (355) 13-68", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("38c89016-3da0-4c81-a756-45945064858d"), null, null, "+531 41 (733) 20-27", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("38f8653e-8e3f-4860-b545-635226482c04"), null, null, "+237 08 (921) 76-25", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("39e7806f-3552-402a-9170-babd5141bd92"), null, null, "+886 82 (157) 77-06", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("3a189fb5-6ad0-4fd4-ae3b-472aa52f83ac"), null, null, "+306 76 (322) 65-36", false, new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") },
                    { new Guid("3a4ba485-6159-4c7e-b166-02795aee7ea5"), null, null, "+222 98 (042) 03-78", false, new Guid("76807668-f1d2-47ed-a084-0771d51bc761") },
                    { new Guid("3ac358d6-b965-4d88-a46f-088713ae00c8"), null, null, "+259 39 (499) 78-92", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("3adbb061-2029-4edd-8a20-b1257d33a4c9"), null, null, "+522 18 (642) 82-46", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("3add0a95-87e7-47c4-8a54-ba9006f10308"), null, null, "+523 21 (195) 13-37", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("3b4ba240-0b7b-4d59-9b30-5b209542cf20"), null, null, "+162 07 (103) 71-96", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("3b8c8daf-72da-4215-a097-65150718996f"), null, null, "+543 19 (228) 34-66", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("3ba97cec-c280-48b8-a0d9-2756693b564f"), null, null, "+56 08 (685) 39-60", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("3c50ea98-30a5-43b7-85fc-d3adbc3c3cb5"), null, null, "+757 39 (299) 82-02", false, new Guid("dac6b165-e5ff-4ff2-9767-e783eba2f9ae") },
                    { new Guid("3c7f1787-03df-4490-aa67-aa563dfb7e59"), null, null, "+260 64 (950) 62-24", false, new Guid("38299130-8bc0-46ec-9ec8-d80298fa17f1") },
                    { new Guid("3cabef87-ec12-429a-af48-3b8624ed1583"), null, null, "+616 86 (381) 80-89", false, new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") },
                    { new Guid("3cd8c6c3-a674-4338-aeff-61111d2d4ac0"), null, null, "+38 21 (346) 55-51", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("3d147114-3479-4a15-a225-7349691bcbaf"), null, null, "+179 54 (639) 74-68", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("3dadf84c-a09c-4d64-85e8-bcbf862bcd28"), null, null, "+796 45 (844) 07-16", false, new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") },
                    { new Guid("3e2fcee3-b323-4c92-92d7-3f5ee595c36e"), null, null, "+697 67 (586) 39-31", false, new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e") },
                    { new Guid("3e415b79-5e29-47c2-a51d-a243230d01d4"), null, null, "+61 85 (936) 95-88", false, new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("3e5361fa-6937-4259-bdbb-cfb3ca56a9c5"), null, null, "+806 77 (037) 75-82", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("3ec874cf-9f58-4112-9cae-d86f9c030f6e"), null, null, "+394 35 (595) 87-58", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("3ee3baf1-5342-4d5d-958f-420f1dbf59e1"), null, null, "+336 11 (301) 46-37", false, new Guid("09fd275e-b209-4f17-84ed-5884b76fc276") },
                    { new Guid("3efb3f90-0fd2-42f0-862d-b3fb318c0d0b"), null, null, "+610 69 (193) 93-03", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("3f0e6b70-7ba2-44df-a108-240216b30a9c"), null, null, "+224 70 (194) 50-93", false, new Guid("9592762d-b2ae-4d33-b414-c02e0d45ee44") },
                    { new Guid("3fcfac33-c566-4789-b9d7-5f2381288edc"), null, null, "+452 91 (702) 99-79", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3fe8d2a7-5b85-47fe-878c-e6051430d8f0"), null, null, "+367 53 (347) 10-29", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("409f815a-d014-48e6-924a-125639297995"), null, null, "+320 36 (781) 06-86", false, new Guid("5227b046-d260-4727-89e6-90bfa60f5f27") },
                    { new Guid("40a5b4c1-9e59-46c4-857d-1675f9295970"), null, null, "+280 86 (563) 25-77", false, new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3") },
                    { new Guid("40e619f1-8f49-45b9-a8b9-d68c2286de29"), null, null, "+122 20 (990) 03-01", false, new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb") },
                    { new Guid("419ae2c7-efbe-48b0-bafd-e7339b417884"), null, null, "+708 42 (790) 52-11", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("41c910c5-1356-4071-aede-a6499efc5e6f"), null, null, "+589 08 (535) 99-21", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("422db682-bf06-4451-b6d0-8cae2af2d2ad"), null, null, "+37 04 (069) 12-54", false, new Guid("1c0a3aa9-2d71-481c-8951-d26d6c49228a") },
                    { new Guid("4274459c-6117-4be2-a9b9-1b7d45d7a2cb"), null, null, "+519 36 (396) 93-53", false, new Guid("1328ab54-06e6-4db5-929c-ea862381f6e3") },
                    { new Guid("42fb1bc9-ca78-4f52-a340-bf5ffd3063e9"), null, null, "+571 23 (267) 76-25", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("4334e1ff-1261-4ab5-a925-90736026cb32"), null, null, "+318 13 (514) 13-47", false, new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c") },
                    { new Guid("4358e82c-7809-498b-ade1-babb3adb1d04"), null, null, "+42 53 (936) 28-84", false, new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c") },
                    { new Guid("436e71cc-b7b3-4776-8454-cf762d8d048c"), null, null, "+82 05 (503) 25-30", false, new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8") },
                    { new Guid("44970f5b-c199-439f-a350-05e31eeb01ba"), null, null, "+276 95 (863) 87-15", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("449dc4fd-5127-4b70-88e5-39e9218a29ee"), null, null, "+187 78 (409) 24-44", false, new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f") },
                    { new Guid("44cbe887-277b-45c1-8d64-e3291573aeb1"), null, null, "+48 34 (710) 56-88", false, new Guid("77941635-e388-4774-9d8a-53d61f8a1c10") },
                    { new Guid("44e5e9ae-db99-44cc-a7e7-98b438bf7c1d"), null, null, "+681 73 (088) 01-46", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("459efee3-cc5f-4724-ad9b-c826980d7bcb"), null, null, "+606 36 (726) 97-49", false, new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4") },
                    { new Guid("45e2b520-e7c5-4e87-ae63-fe524ec95e44"), null, null, "+541 66 (738) 12-11", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("46232dcf-2e7b-4044-9e31-4498b1c1ac91"), null, null, "+253 10 (557) 32-61", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("46a0c9c5-2f97-4b71-a19a-77b6aece5ed4"), null, null, "+326 30 (141) 01-52", false, new Guid("8c396faa-ad98-400d-a562-77b4902806e1") },
                    { new Guid("46f02214-3627-48f1-8454-cd13c86803e8"), null, null, "+601 99 (222) 95-77", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("470f2ea8-86cc-4951-91b0-4c27f2d173e5"), null, null, "+350 26 (163) 42-72", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("4728fa57-871b-4f8c-b23c-710c0c095022"), null, null, "+943 73 (766) 21-72", false, new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86") },
                    { new Guid("47904148-1e71-48c9-91dc-ef366b73a13e"), null, null, "+137 88 (808) 57-00", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("47a06348-bbc8-4817-9da7-3e07e37fc011"), null, null, "+747 19 (926) 03-53", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("47b44abd-459c-4293-8dd2-52fa26f12889"), null, null, "+264 27 (523) 36-28", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("47e78a9c-f19e-48bd-8602-83b3c8764d14"), null, null, "+227 42 (257) 84-38", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("47fcae90-b77c-40ec-9717-af014063a449"), null, null, "+271 11 (865) 12-44", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("48370fe7-5b65-4225-bf4f-0a6d25f9c0bf"), null, null, "+574 91 (518) 62-62", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("48e3581a-7b9a-4fb5-95fb-3dc80fca897b"), null, null, "+693 88 (903) 69-59", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("490aa12e-b6cd-42dc-88eb-494066a2b458"), null, null, "+141 54 (310) 74-03", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("49853a4d-edcd-44fa-a4ac-fdcfea4e2c70"), null, null, "+84 33 (303) 91-34", false, new Guid("05c57cb0-9f46-4a1d-83c5-717905a88084") },
                    { new Guid("4989ca22-09ab-492d-a54e-cc3bc51cbb03"), null, null, "+83 28 (264) 73-53", false, new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f") },
                    { new Guid("4999dbbf-9ed2-4544-abcc-01ca8c960b6d"), null, null, "+717 11 (995) 66-69", false, new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") },
                    { new Guid("49a37c1b-e90c-4170-b51e-e1b792c2fd89"), null, null, "+920 48 (646) 38-60", false, new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("49b72809-40dc-46b7-a01f-fd96c52564b8"), null, null, "+778 12 (673) 94-74", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("49ca611b-6e89-4e8d-aa60-5b03eec18ee8"), null, null, "+60 14 (344) 75-58", false, new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a") },
                    { new Guid("4a94ae98-8ea3-4e8c-9919-f2c8024aad78"), null, null, "+88 97 (451) 64-33", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("4abe0d27-f8dc-40d7-ab25-e633f65a14d8"), null, null, "+560 11 (230) 11-00", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("4ad00c4b-92ac-48e7-ac5e-4435b66890b1"), null, null, "+939 33 (086) 50-66", false, new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7") },
                    { new Guid("4af7c209-5fcb-4f9d-aed1-7a75b78c8860"), null, null, "+196 37 (759) 25-87", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("4afab73b-4a7c-4238-8f50-22d2d1367b9e"), null, null, "+820 37 (343) 30-76", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4b02c22c-c7cf-4ee8-9b90-439520419406"), null, null, "+251 02 (816) 87-42", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("4b04a0b4-3c9a-418f-b30f-f7332daa4025"), null, null, "+437 24 (871) 86-92", false, new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") },
                    { new Guid("4b73f096-2cfa-4710-9f31-555f27ea58cb"), null, null, "+428 24 (751) 32-78", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("4b796dfc-b97a-498d-8c51-fd0c18d7c73a"), null, null, "+266 99 (402) 50-27", false, new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3") },
                    { new Guid("4bc99a02-829b-4ea7-a562-f50e1b7748e8"), null, null, "+725 75 (082) 62-44", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("4c106293-bd60-41e2-93db-6c32df4eca37"), null, null, "+323 49 (996) 54-96", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("4c29971b-5435-4cc7-9435-8cecde69baa5"), null, null, "+656 39 (776) 19-21", false, new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5") },
                    { new Guid("4c63002d-43c1-4e0d-8e60-ebb1a80e51b4"), null, null, "+238 72 (365) 89-77", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("4cc0c628-830a-4acf-b608-0059a98b3f8c"), null, null, "+219 04 (494) 29-49", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("4cd853f6-e581-4bdd-a693-6a03b208b657"), null, null, "+509 24 (804) 58-53", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("4de09ecb-a948-40a0-9738-ae4ae005926b"), null, null, "+323 08 (661) 98-39", false, new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1") },
                    { new Guid("4e0be676-d393-405c-ab99-8cb4f7a18904"), null, null, "+920 96 (320) 04-35", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("4e9c0a80-e2e9-4e19-8021-d81de5994c7d"), null, null, "+427 92 (449) 35-65", false, new Guid("5f140f7e-803a-444d-8158-03815cbd832c") },
                    { new Guid("4eb5689b-65fa-4253-8cc3-3da4dd8ee566"), null, null, "+223 86 (089) 34-33", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("4ee3453b-4509-4978-9238-b8e7e2a98b1e"), null, null, "+427 23 (762) 51-59", false, new Guid("77798e54-1f6a-4c15-89b7-1c5e099c26ca") },
                    { new Guid("4f4d480d-1762-4d22-b824-15b1cba5598b"), null, null, "+88 77 (377) 97-79", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("4f9a8dc2-8a3a-4686-8080-9af64c77376b"), null, null, "+886 76 (482) 34-89", false, new Guid("d491a5fe-5d80-4031-b8d8-47e6a8397091") },
                    { new Guid("4ff39966-dd28-4da3-b368-84d9c06cf166"), null, null, "+784 21 (947) 97-20", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("502514cb-41d4-430f-a8b6-c000ddb200f8"), null, null, "+473 04 (368) 63-84", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("509801f5-18f4-4ea6-bcdf-9090949a488c"), null, null, "+21 53 (256) 14-85", false, new Guid("1deb7fc7-46a7-43da-854d-8ca9d0d42512") },
                    { new Guid("509f7756-d66b-4d4d-8eef-44314f86dd29"), null, null, "+440 28 (441) 16-56", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("50af5385-57a8-4906-9b0d-d992b1f389dd"), null, null, "+378 01 (936) 11-73", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("525d4d7b-a0ec-40f4-8cc8-769d8dd5e842"), null, null, "+320 75 (337) 78-52", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("528609ce-36ef-4299-9b9a-05fe1d14762b"), null, null, "+355 32 (997) 31-77", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("52ea894d-b33b-42e9-a15e-6a33626a4c7b"), null, null, "+25 40 (209) 70-46", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("53075727-e82c-42de-b385-d3aa3c416773"), null, null, "+74 69 (499) 89-06", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("531c83ab-dd35-4429-84ed-cb61723fed6f"), null, null, "+508 67 (615) 19-03", false, new Guid("5e421353-3237-4b90-a7a1-a061d45dbede") },
                    { new Guid("53b1b33e-8b05-474e-925b-9b6d3e5500b7"), null, null, "+601 00 (173) 67-44", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("54210d97-3802-48ac-af20-8e50690528f9"), null, null, "+557 43 (800) 38-60", false, new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("54f63d2b-b6f4-48ff-867c-37ab21abde8b"), null, null, "+945 08 (037) 19-16", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("551825b0-ac76-467b-aa78-3b928bc3421a"), null, null, "+729 72 (553) 83-07", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("552e043a-aa9a-441f-85f0-d3e34f3796e0"), null, null, "+481 37 (093) 88-36", false, new Guid("44660f18-55c3-49c8-9abf-a0a921050e9f") },
                    { new Guid("5551ed02-63dd-440f-beac-c673571c464b"), null, null, "+114 48 (122) 95-88", false, new Guid("6930eb06-375f-4b2d-b463-d7ce154cefcc") },
                    { new Guid("561fd959-f241-4e5d-8450-4c19a4e0b974"), null, null, "+226 48 (652) 09-27", false, new Guid("5f140f7e-803a-444d-8158-03815cbd832c") },
                    { new Guid("56807a4c-a550-440f-846d-0fa0471e6215"), null, null, "+580 61 (468) 06-33", false, new Guid("5227b046-d260-4727-89e6-90bfa60f5f27") },
                    { new Guid("569c9c38-1bea-480b-8165-4435f2f90105"), null, null, "+771 20 (452) 27-70", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("572c526d-927e-46bc-b848-6033f185f303"), null, null, "+131 36 (080) 64-04", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("574f8590-ec97-44f2-bceb-2207bed0c3b0"), null, null, "+728 29 (293) 47-14", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("57681449-6eb5-4a4f-9efd-bed0f3910195"), null, null, "+209 99 (128) 93-60", false, new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("579a0d8f-e2a4-465f-a678-02ba195d3dbd"), null, null, "+112 79 (562) 03-82", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("5984d9ba-96ff-49bb-878a-a8b13834ef16"), null, null, "+405 93 (483) 54-16", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("59f97a56-f888-4bfe-af7d-771d61be64d5"), null, null, "+570 48 (148) 85-06", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("59fb615a-21d8-45e2-9061-3e9b050cc252"), null, null, "+957 21 (975) 00-51", false, new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f") },
                    { new Guid("5a32b56a-61d5-4d53-b39f-0864467cc624"), null, null, "+407 61 (568) 54-00", false, new Guid("f443c798-1151-4757-94ca-517bef15e381") },
                    { new Guid("5a7f5a24-771b-4d13-a6b9-8b9a46d80f54"), null, null, "+559 78 (905) 61-37", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("5ad2e0c3-6d67-47d8-9c8c-6598dcb42810"), null, null, "+395 67 (302) 24-63", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("5b3135dd-8afe-436e-a5b7-b9d0491b5441"), null, null, "+235 78 (265) 10-73", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("5b5219ef-0522-4adb-a70e-4e03cbbd5183"), null, null, "+701 35 (552) 52-58", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("5b85af1f-7358-4efc-891d-955ab3da6ba2"), null, null, "+510 14 (024) 98-06", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("5b8e7183-6f63-480d-a302-980db5440604"), null, null, "+702 97 (102) 49-03", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("5bb79048-aeba-4923-8bee-72525713a5e4"), null, null, "+222 26 (039) 94-07", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("5beb9244-3f40-4558-96e9-1af72b8b9548"), null, null, "+140 09 (692) 62-68", false, new Guid("223295f7-9195-4510-8bcc-44f043830497") },
                    { new Guid("5bef4a29-55d8-45ba-ada8-37bd00a38da4"), null, null, "+95 99 (421) 79-85", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("5bef7034-9a3c-4fcb-b6af-3d486304cebb"), null, null, "+229 36 (730) 33-31", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("5bf37b3b-40b1-445e-b44d-558fe07ef240"), null, null, "+888 89 (532) 64-44", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("5bfb1913-0db2-41b2-a557-d33a3abf4712"), null, null, "+886 69 (817) 39-37", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("5c60f558-5fa3-4f21-a267-8f396c74d21e"), null, null, "+557 38 (593) 04-91", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("5c931b72-c5af-4243-8ba9-5e62056b7af7"), null, null, "+445 02 (550) 72-20", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("5d4f078b-3e93-4997-ab73-81bc9e3e06b4"), null, null, "+951 00 (352) 99-09", false, new Guid("2a0ad518-ed0a-4ace-bbf0-92f687c518f9") },
                    { new Guid("5d88afa3-35cb-469e-bba5-be44193c3fad"), null, null, "+56 09 (258) 24-90", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("5e1b33e3-98c9-4c23-b2f1-cd9e82742fbb"), null, null, "+268 89 (940) 18-02", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("5e730797-c2f1-44b9-a0c7-8cf3158ccc8f"), null, null, "+889 33 (077) 86-90", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("5ea8dae5-7727-4181-9b20-f50b8dbd66da"), null, null, "+401 85 (163) 31-91", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("5ec0583f-11c6-4457-bcd1-613baf069621"), null, null, "+538 74 (280) 01-92", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("5ec5c110-ed7f-4e4d-9997-e3e46b7e5057"), null, null, "+111 78 (883) 63-22", false, new Guid("57710136-3092-497c-8523-6e222848ceaf") },
                    { new Guid("5f52d537-2c7e-43ea-924c-655b7d4cdd42"), null, null, "+106 34 (085) 22-55", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("5f5473fd-7595-4f45-ae15-4400dc73619d"), null, null, "+741 79 (936) 49-58", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("5f757f37-3af4-4598-b6f2-7bdf55d6411b"), null, null, "+588 51 (058) 54-87", false, new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058") },
                    { new Guid("5f7da6d5-056f-46dc-93b6-e62b17468423"), null, null, "+558 95 (837) 50-06", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("5fa5faa5-b513-4317-945a-23ccc321f8c6"), null, null, "+878 54 (091) 78-26", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("5fdd881e-5139-4e4b-9d85-d28dbcb0d653"), null, null, "+566 65 (708) 94-42", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("5fde9b68-2c19-4ef0-bf2e-38cac7b54a21"), null, null, "+225 58 (461) 08-51", false, new Guid("c3f4daf9-4bfd-4f95-a0cd-d9822afa3fd7") },
                    { new Guid("606a8597-cb43-4fad-b37b-a5151fee92e8"), null, null, "+810 13 (510) 76-57", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("609256b3-81fa-4764-9fb7-98e73f821f8a"), null, null, "+105 70 (610) 05-12", false, new Guid("62780013-8c47-4235-a42a-798d9bf04220") },
                    { new Guid("60e81c59-e880-466e-a3c7-fa2c17d7f817"), null, null, "+80 35 (472) 08-10", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("6119f90a-beb6-4fec-8ff2-e687fc55d1d6"), null, null, "+682 34 (958) 52-38", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("613ea074-ba35-4331-b5aa-79190e8e3f02"), null, null, "+181 31 (358) 81-21", false, new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed") },
                    { new Guid("61bb56c6-cd65-4a66-ac8b-7fbdc245074d"), null, null, "+861 01 (578) 21-66", false, new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8") },
                    { new Guid("6202470d-9c3b-4002-9c06-7f75d42304a0"), null, null, "+43 96 (464) 01-27", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("622c9e26-c1f1-426c-91f4-2cee664adf39"), null, null, "+373 58 (180) 05-89", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("6236ca38-6431-4b25-a114-0901112d70b6"), null, null, "+235 61 (937) 06-39", false, new Guid("44275811-c945-4a4f-8382-272488a907aa") },
                    { new Guid("6290c08f-f9bd-4dda-963b-c1da5f88822c"), null, null, "+997 84 (114) 23-39", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("629279f8-120c-4d4d-b1ae-cf3736b06543"), null, null, "+148 31 (697) 82-29", false, new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7") },
                    { new Guid("6379a1fa-9d83-4a07-bd73-56a0f77f0858"), null, null, "+856 44 (776) 76-05", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("637e96f8-286d-431b-a74e-8fb4d437ad79"), null, null, "+748 23 (755) 82-16", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("640491e9-6e9a-45b3-bed1-1a19aca1eaee"), null, null, "+451 53 (473) 74-80", false, new Guid("c8507284-511b-425f-9aab-13ef42992af5") },
                    { new Guid("6461bf49-83b9-4f4a-b413-8e63419ce6f8"), null, null, "+489 69 (107) 62-63", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("6461f560-1956-4d8c-ae7e-4eeba8e54fae"), null, null, "+639 03 (305) 26-96", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("649449c0-deba-47a7-b8ed-6e6a9a8cf454"), null, null, "+229 73 (808) 06-49", false, new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925") },
                    { new Guid("64ab9a1c-78ce-4754-8d81-06e89b9631e2"), null, null, "+488 53 (621) 11-19", false, new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953") },
                    { new Guid("64d0d8f3-e0ab-4dfe-8c07-415e29c4d562"), null, null, "+271 59 (705) 52-96", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("64ee14f4-96e2-477d-b278-fc74aac6b7bb"), null, null, "+760 92 (642) 32-70", false, new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("6532b109-ba29-4ec0-b2cc-a8755d7c6a5d"), null, null, "+34 52 (498) 62-60", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("658eca40-7ac6-4e82-96ac-395d705b5b11"), null, null, "+260 08 (721) 29-31", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("65a618c1-a4cd-4b09-be14-3fd589b9315a"), null, null, "+258 25 (760) 87-51", false, new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3") },
                    { new Guid("65a6735f-f57a-4da3-9d33-af88b4d816be"), null, null, "+810 30 (852) 62-69", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("65a889b8-0720-4726-93d2-fe7117640520"), null, null, "+191 92 (639) 73-23", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("65e3fb8f-3fe3-497b-84fc-0476115bdf45"), null, null, "+994 86 (161) 19-65", false, new Guid("2551eff5-94b7-4adf-9291-e82fa60e157f") },
                    { new Guid("6613c6b3-e3de-450d-8fde-96b3e12bf75d"), null, null, "+887 76 (041) 42-45", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("6615dfe2-4ef0-4b25-a3b9-52862394566e"), null, null, "+61 68 (720) 04-23", false, new Guid("c54f7014-7a59-4b94-b3e3-4c67d3b87724") },
                    { new Guid("66719f43-fa78-4625-bec8-f2a8b29b1a41"), null, null, "+961 97 (316) 88-99", false, new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213") },
                    { new Guid("672b3574-370c-4b42-b73b-18739d886627"), null, null, "+699 63 (741) 58-56", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("67a22075-1386-44af-b1eb-64397cc749db"), null, null, "+43 42 (618) 83-41", false, new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda") },
                    { new Guid("67af7f85-5f6b-41a6-9c56-e965025118a9"), null, null, "+430 42 (592) 54-10", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("68a9507b-4ef7-4464-bdeb-ff6a6f54bfd3"), null, null, "+579 39 (848) 63-90", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") },
                    { new Guid("691118de-3ae5-46ab-b0c0-f28b82d32dff"), null, null, "+733 22 (171) 60-66", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("69a54e4c-d7f5-49f2-8772-df028802b8fb"), null, null, "+758 43 (606) 81-51", false, new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797") },
                    { new Guid("69ce6687-568e-4f1d-9c82-2476ed918133"), null, null, "+527 10 (480) 07-74", false, new Guid("5ee54399-9054-4429-a438-7a6f33482943") },
                    { new Guid("6ab9bcd2-6bdb-4588-9c47-daf27e45773c"), null, null, "+453 93 (701) 94-89", false, new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694") },
                    { new Guid("6afc6cf2-0de9-4c0a-9409-db11ff42fd7b"), null, null, "+598 92 (524) 94-07", false, new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3") },
                    { new Guid("6b7ab9bb-c2cb-4bb9-ac94-370bfdaeeda6"), null, null, "+359 18 (088) 91-54", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("6bf73a39-1e20-4ed1-89e0-22be24c7fa98"), null, null, "+62 07 (195) 82-31", false, new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") },
                    { new Guid("6bfb6ea5-019d-4402-bbe4-7896a3092452"), null, null, "+425 81 (054) 94-43", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("6c15cb2c-5fde-4e03-a9ad-c27320b74629"), null, null, "+56 94 (412) 71-98", false, new Guid("35263c47-5006-4ddc-a824-47120f6a334d") },
                    { new Guid("6c748939-ecc1-417d-9707-cb033580f787"), null, null, "+444 73 (887) 51-87", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("6cd1b6d1-1f46-4a52-ac40-a4b4759e2773"), null, null, "+779 09 (477) 16-57", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("6d034e9c-91dc-45dd-bd9f-feec6551977f"), null, null, "+849 08 (428) 51-79", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("6dc91d60-38f2-452e-b278-2db368625c4d"), null, null, "+979 04 (893) 62-26", false, new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17") },
                    { new Guid("6e1a44b7-6d35-470b-ad3c-d36e07f05820"), null, null, "+477 35 (937) 29-20", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("6e5bff77-fe2f-4ee9-b8dc-2cdefb786e90"), null, null, "+630 02 (865) 26-62", false, new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") },
                    { new Guid("6e9cc3bb-8f9f-413d-b204-d0ce7d0c7537"), null, null, "+676 46 (369) 63-97", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("6ec86fbe-893a-412b-bd65-99cfa9cdf340"), null, null, "+490 45 (189) 85-91", false, new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc") },
                    { new Guid("6ee3ef1d-4517-45ef-bb4a-0d1de1715d15"), null, null, "+528 02 (674) 55-78", false, new Guid("8ae7642e-7905-444f-ad68-f873370b7b14") },
                    { new Guid("6eef75d5-0d26-465b-a2da-74750d05cd65"), null, null, "+336 61 (575) 01-20", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("6f05cbe7-b8cb-404c-8c6b-86d8a7fd7a89"), null, null, "+6 82 (311) 27-61", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("6f0801b2-24ef-4a3e-98e0-5d51d7119a40"), null, null, "+459 50 (643) 31-32", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6f363b38-0085-4cff-a313-b0c894e6fef6"), null, null, "+563 65 (293) 96-62", false, new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042") },
                    { new Guid("6facd337-09e9-47f1-ac76-cc6af5dd5924"), null, null, "+68 37 (092) 33-01", false, new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1") },
                    { new Guid("6fe04450-c906-416c-8273-a25946dec04a"), null, null, "+438 09 (462) 33-96", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("704fd3b3-4b10-4053-892e-ea566bc0dda9"), null, null, "+340 33 (146) 75-90", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("70c48216-f97b-47de-b5fc-8f60d3709228"), null, null, "+190 95 (642) 18-53", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("71a0d7d1-4c42-4bb4-ad01-fcc3e517dace"), null, null, "+17 45 (963) 17-85", false, new Guid("35263c47-5006-4ddc-a824-47120f6a334d") },
                    { new Guid("71bcd9e8-5864-45c9-98fc-926bf7fe9071"), null, null, "+383 32 (263) 71-65", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("72f97ee7-a373-469f-9e95-6b60987745dc"), null, null, "+105 20 (970) 64-83", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("74738480-0617-422c-bcd4-47efb9a3ce71"), null, null, "+519 53 (014) 07-08", false, new Guid("1dcb875c-209b-40a9-a664-ed0ddd37f311") },
                    { new Guid("74a03730-1cae-4aa4-83d3-476e48211591"), null, null, "+426 43 (232) 97-02", false, new Guid("e50b5106-c89a-489a-b970-99024a53f892") },
                    { new Guid("74c28648-6bc8-447c-9c5c-d5dae0a15b2b"), null, null, "+157 45 (953) 62-86", false, new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("74d96145-4a1c-4afa-8904-911666175641"), null, null, "+136 97 (385) 08-03", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("74de2996-b850-4894-b0aa-439e451dca07"), null, null, "+677 56 (407) 91-59", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("750038a7-04fa-43dc-9070-33ba059f238b"), null, null, "+565 00 (666) 90-49", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("753bb6f8-b00c-4f1f-a553-360b90d47d5b"), null, null, "+900 27 (419) 25-13", false, new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6") },
                    { new Guid("755c4038-5887-4b5c-84db-d08c669c6088"), null, null, "+93 88 (826) 24-95", false, new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3") },
                    { new Guid("758258b4-9cea-47f9-b922-9ccc4fcba456"), null, null, "+918 93 (558) 13-99", false, new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6") },
                    { new Guid("7587159d-e2e2-4760-9422-2e6ee5fdb972"), null, null, "+199 47 (518) 25-28", false, new Guid("9af47343-7f95-4006-8dea-4975912f5989") },
                    { new Guid("75da4c8e-9c8e-4b89-90ec-0e553869d8aa"), null, null, "+794 01 (984) 31-85", false, new Guid("77e33620-f6ed-4b8a-97ed-020acb6bbfd8") },
                    { new Guid("7620fdca-4128-4cbe-8271-dededfb574b2"), null, null, "+744 40 (251) 09-05", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("76359187-be58-4984-8b73-e58c5765b920"), null, null, "+422 18 (795) 11-61", false, new Guid("f6183101-6c01-46e2-a877-9bfcb5a59549") },
                    { new Guid("76663489-d9cc-4420-a609-e9a5719cad02"), null, null, "+309 85 (436) 45-95", false, new Guid("f79e936c-ba6e-4044-8bf3-0940dbcebd86") },
                    { new Guid("76ab221a-e3fe-4afc-8951-22837c1a1557"), null, null, "+641 44 (301) 70-94", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("76bc5a67-ab0d-4135-affc-0af2e2e4fd0c"), null, null, "+624 31 (492) 30-45", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("7701d173-52c2-411a-b5de-a8bab3c4205b"), null, null, "+179 50 (470) 78-58", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("77100e17-bb11-4451-b936-28f8fe727f0d"), null, null, "+105 23 (850) 07-08", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("7734af6e-220a-4fdd-95c3-2d601b7b119e"), null, null, "+333 27 (365) 52-11", false, new Guid("57710136-3092-497c-8523-6e222848ceaf") },
                    { new Guid("7768c343-fde4-4d22-83ab-e044762702e9"), null, null, "+119 26 (954) 32-89", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("77ace9a3-cbce-42c5-a512-9d9906496fc3"), null, null, "+402 42 (731) 08-99", false, new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf") },
                    { new Guid("77b929d0-90c4-4a6f-8fd0-7ab3407c227f"), null, null, "+831 72 (639) 42-48", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("77c97d06-1d11-42bc-8007-20cf9592047e"), null, null, "+712 08 (200) 62-49", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("77cf1aac-0501-4951-8c6a-44a0d4c8a906"), null, null, "+719 83 (639) 87-20", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("79a0790e-7421-4d75-9299-a0ff22482b9b"), null, null, "+769 97 (590) 89-40", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("7a04a64b-e2d8-4637-9126-6a01129c3974"), null, null, "+84 17 (060) 57-91", false, new Guid("e046fca1-590d-4528-9a08-8baa91140ac9") },
                    { new Guid("7ad4ac0c-ce58-473d-8703-6ae590db4f2b"), null, null, "+516 64 (847) 36-91", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("7ada7828-2dd9-40d6-a794-30ac5f019fb4"), null, null, "+343 37 (735) 77-59", false, new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d") },
                    { new Guid("7b51f2ab-7b85-4ead-8971-68d70cc36ec4"), null, null, "+636 94 (237) 33-28", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("7b6ce696-cfe2-423e-81e6-65231e1467e5"), null, null, "+251 31 (839) 97-05", false, new Guid("34eeff05-deff-4c5b-8d00-3cf32d88446f") },
                    { new Guid("7bf51b03-5e2c-4fd7-bd1a-fa537b78a350"), null, null, "+438 77 (414) 11-48", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("7bfa2075-bd56-404b-9869-92ff09fa285e"), null, null, "+51 52 (849) 65-04", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("7c103ece-802d-4836-8eed-f0abe2b5a3b7"), null, null, "+368 03 (622) 34-84", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("7c16d35e-269d-421b-8753-76ec7b936df4"), null, null, "+932 85 (597) 68-91", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d702dbf-0347-45c1-831e-6d5cac5ed59d"), null, null, "+290 49 (441) 93-84", false, new Guid("abc21a49-3fd9-4787-b95b-3982c67e22e1") },
                    { new Guid("7db2394d-a1a1-435e-8dcb-0193873f94ee"), null, null, "+287 36 (681) 62-63", false, new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("7dd1a133-1f28-4333-bad2-c9fdcb496e00"), null, null, "+117 65 (062) 69-12", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("7e030d6f-d399-4324-83a8-dcf571bcbdb5"), null, null, "+244 32 (373) 81-57", false, new Guid("9af47343-7f95-4006-8dea-4975912f5989") },
                    { new Guid("7e38bb46-bf1f-44b1-8ab0-1f6e8bc336ab"), null, null, "+833 99 (321) 13-40", false, new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("7e66967d-6ed1-4e93-ba41-9c0134010f92"), null, null, "+480 06 (815) 97-93", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("7eb9d79e-fd00-4be1-b296-efe7f15fa065"), null, null, "+92 94 (209) 51-86", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("7f3799fe-0c7a-40cd-a6be-b3d1fbfbc384"), null, null, "+214 87 (933) 48-88", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("7f88048d-707e-48c7-85f1-b552917171da"), null, null, "+401 03 (881) 45-58", false, new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("7fe989e4-b6ab-4d6d-9b60-8059838e8a84"), null, null, "+725 37 (390) 67-77", false, new Guid("489038c7-0441-436a-a527-66069a8b1473") },
                    { new Guid("7ff1aaaf-89ae-42a9-9923-030642ab4eac"), null, null, "+727 58 (421) 25-16", false, new Guid("8ed1700c-bd50-4340-8c5d-b14e688dc1f7") },
                    { new Guid("80663167-4879-4673-a378-beb8ef7754fa"), null, null, "+586 92 (522) 14-40", false, new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("80ae4607-6264-4a88-af22-dc1894b2f59c"), null, null, "+528 63 (242) 36-26", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("81559c70-47f9-493c-afb0-fcb8ca288675"), null, null, "+558 03 (834) 38-34", false, new Guid("0ee2da5c-09da-48fd-8440-e6589ef709f5") },
                    { new Guid("818ea7b7-8324-4c18-bfe3-dd8fde8adcec"), null, null, "+529 24 (742) 45-81", false, new Guid("70409336-0f26-4108-8c79-213e320c07f7") },
                    { new Guid("81b50e30-6bc5-4b97-9be6-5be9f75a6c8a"), null, null, "+163 45 (800) 13-94", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("81bad5cd-f33c-4c95-a358-71e9998b7d9d"), null, null, "+461 95 (278) 51-37", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("82163426-fc14-44d3-86e7-c244c7aa2de4"), null, null, "+164 86 (513) 50-74", false, new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20") },
                    { new Guid("82435968-b7a7-4eac-839d-5a01374a0ee9"), null, null, "+479 16 (821) 91-03", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("8337626a-049f-45e0-9ff0-63db6e5ac5c9"), null, null, "+813 83 (449) 17-32", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("846957ac-f63f-406a-aeaa-db158fb210f4"), null, null, "+138 86 (525) 62-45", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("8471e1b3-8560-4c35-a3a9-d26808013193"), null, null, "+304 38 (231) 48-52", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("849c8eef-aaca-4deb-b0b2-5efe06be04ae"), null, null, "+810 48 (750) 84-10", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("850c4300-0c49-4905-af1b-223385fd740e"), null, null, "+120 48 (849) 57-27", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("852ea784-90c0-4d06-874e-9ab0ca30ad50"), null, null, "+566 30 (667) 43-59", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("854aee25-0997-4f60-b531-feaa6e4c1b47"), null, null, "+278 72 (146) 27-86", false, new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") },
                    { new Guid("85e8c1ad-4213-4c0d-a2df-c906fc00b181"), null, null, "+980 15 (960) 28-10", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("85eb1fab-92ea-4143-b526-cba28ff4e396"), null, null, "+250 29 (018) 68-40", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("85f37ab3-5ceb-45f5-b4f8-be9a9678f838"), null, null, "+862 24 (884) 26-40", false, new Guid("8d2347a9-e8f3-498e-93ef-d83b4c3eb925") },
                    { new Guid("860f7506-af3f-41ab-9119-41f914b62c2a"), null, null, "+463 20 (451) 25-92", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("8673c1d0-b0dc-470d-808a-25549ab92dac"), null, null, "+657 79 (140) 98-41", false, new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d") },
                    { new Guid("86784cdf-9e3c-4393-8dd3-480cb7f54913"), null, null, "+613 59 (906) 63-53", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("86c4e9b0-36c5-482a-acdf-10ac4a52c0a6"), null, null, "+287 23 (653) 22-47", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("86d70dd8-4e24-4a44-b48d-ec3972a7c3b2"), null, null, "+936 89 (273) 09-41", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("86edaa8f-7430-45af-81c5-39244e60fa44"), null, null, "+712 88 (785) 42-65", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("8788a600-0d4e-479d-8780-87e9b14d2e94"), null, null, "+458 00 (806) 13-82", false, new Guid("ceb699bd-8c01-4831-9438-e8c30f353919") },
                    { new Guid("87bc693d-5760-4c87-9dfe-f0135ac8bcfe"), null, null, "+187 23 (661) 42-55", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("87d5b75c-5947-4818-bfea-8c62f92165b6"), null, null, "+263 00 (531) 34-47", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("88035be8-7afd-4af4-826c-83d3410bd9d7"), null, null, "+790 10 (920) 69-84", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("886c21cb-a1a7-455e-b3c0-e518c32fb83c"), null, null, "+924 53 (810) 98-40", false, new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b") },
                    { new Guid("8876fafa-02ca-4b6f-985f-3b0211f7f2d2"), null, null, "+330 76 (621) 90-87", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("88c93317-2c7b-432a-bd6e-de85a6c416ee"), null, null, "+373 78 (565) 20-83", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("88f7d7f3-5251-4764-94c5-08ecf39c5ad5"), null, null, "+226 92 (062) 24-14", false, new Guid("76807668-f1d2-47ed-a084-0771d51bc761") },
                    { new Guid("8964c469-a973-45f3-b51b-753c54386832"), null, null, "+732 91 (514) 41-57", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("8976736b-4148-4aba-96af-e19c201c15d2"), null, null, "+963 72 (985) 25-54", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("89af4acb-2cdc-40cc-95d9-e1250abec256"), null, null, "+915 22 (816) 99-16", false, new Guid("fbfc8cd9-e292-49ad-bb2d-cb99fe6ad213") },
                    { new Guid("89b5fe0b-edb4-4403-9a92-e571a03220d5"), null, null, "+993 76 (409) 90-21", false, new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f") },
                    { new Guid("89d27e10-98be-44a6-9978-3f73f156c0da"), null, null, "+18 13 (076) 31-63", false, new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2") },
                    { new Guid("89da3a58-6dfc-46b9-a126-afddc9fe0a33"), null, null, "+407 12 (232) 88-03", false, new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("8a1f7392-9514-4d43-8645-b10d6954379f"), null, null, "+368 54 (722) 84-68", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("8a2611f4-1a97-4542-99c0-6065dcb2f53f"), null, null, "+486 34 (846) 60-87", false, new Guid("95ac55e0-f72e-4326-8f28-e08c652f58f9") },
                    { new Guid("8a3a022d-269d-4af9-ab05-77feefcb5b11"), null, null, "+140 33 (889) 34-43", false, new Guid("072b74c5-5e1d-46de-9caa-66d36218f554") },
                    { new Guid("8aa732dd-a72c-4bc7-9efb-1c72519fe106"), null, null, "+116 30 (744) 14-37", false, new Guid("993cf5bc-47bc-4b39-bb9f-2fbe5c121cb3") },
                    { new Guid("8ad7b129-c560-4cae-93f3-447d76c4363a"), null, null, "+155 38 (767) 17-64", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("8b9abef3-eab5-406c-89a0-4a412a8c9bf1"), null, null, "+277 73 (928) 62-84", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("8ba4cc96-bfee-4941-b43d-88dbd85f3429"), null, null, "+309 76 (872) 92-99", false, new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce") },
                    { new Guid("8bbb9a07-8d19-4a90-a5a9-eedc0e174dcf"), null, null, "+98 45 (455) 80-10", false, new Guid("725f0e1f-a790-426b-960a-c1ed7e9e2483") },
                    { new Guid("8c00fc93-90c6-4013-9fb4-b33f322f0cfe"), null, null, "+575 26 (480) 86-65", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("8c53253a-a503-42e0-aca1-139d2771175d"), null, null, "+327 51 (783) 86-27", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("8c7184aa-f12e-47ff-ae52-2ec43193a754"), null, null, "+585 39 (175) 66-50", false, new Guid("0584504d-f79f-4ecc-878f-d41d8d570e20") },
                    { new Guid("8cae028d-2028-4ca9-84b0-1600bd8fb9c5"), null, null, "+10 38 (247) 08-41", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("8cbe1da2-fcfa-4b89-bcc1-96c98b344f71"), null, null, "+788 69 (329) 94-79", false, new Guid("5b7c8a22-b5c4-4bff-86a4-3714a37e1f32") },
                    { new Guid("8cd91061-e71b-463b-b399-9a53c7537230"), null, null, "+532 04 (378) 34-99", false, new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a") },
                    { new Guid("8cdd934a-9ec4-4c7e-9fd5-251809153e59"), null, null, "+792 74 (482) 86-67", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("8d7e489f-58d7-4adc-8f51-7c9f43d3f815"), null, null, "+373 69 (485) 77-88", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("8daaa89e-2ae6-4ab2-b91c-32f28055e2b6"), null, null, "+502 61 (525) 65-64", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("8dc949d7-965e-42f7-84a6-ef94ed2ff839"), null, null, "+748 39 (849) 13-54", false, new Guid("e87e502a-19b0-4f23-969d-aabf313d6591") },
                    { new Guid("8de59675-9b41-49f9-8ebe-542222fbe091"), null, null, "+887 03 (146) 56-20", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("8dfc5ddc-0015-4024-94f2-04f91183c597"), null, null, "+667 80 (550) 80-13", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("8e0aaaf6-47f4-487c-9469-0037fdf99c06"), null, null, "+878 36 (982) 80-49", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("8e1e4e86-8c1c-44a0-968f-be724c31ae4b"), null, null, "+504 86 (175) 25-28", false, new Guid("41bf7410-7941-4fca-a717-3874d970309c") },
                    { new Guid("8ea88450-11c3-4a45-9fcd-3b7b126a786d"), null, null, "+739 22 (040) 32-20", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("8ecb98c2-bbe2-4099-9d63-91262d02c96f"), null, null, "+390 53 (019) 94-77", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("8ed56dd1-b426-4d48-95ba-08ff5727a4c4"), null, null, "+51 94 (693) 64-49", false, new Guid("f2e0997b-1f9c-415b-a3a3-e7d1cad380fe") },
                    { new Guid("8effe925-7571-419b-8b79-b2c804e70377"), null, null, "+212 54 (600) 55-55", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("90123c32-ac27-4b11-896b-ca74790f6d65"), null, null, "+498 41 (196) 54-96", false, new Guid("b180c4f7-e014-4ee1-9c70-5990a1318eb2") },
                    { new Guid("909bdf65-fd62-4c42-814e-79af18715981"), null, null, "+149 72 (606) 05-60", false, new Guid("121881ba-a56e-41d4-80e8-e59f5def1562") },
                    { new Guid("90a66340-067e-4d45-9344-74ea9a50e72f"), null, null, "+902 14 (024) 43-64", false, new Guid("3e08bd05-cb18-4562-a0bf-a631b0c3269c") },
                    { new Guid("91a03a75-5b5a-4ede-9d35-d817f7bb167a"), null, null, "+213 33 (466) 92-52", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("91d5b5a0-39e0-4419-9422-bcb333ea5ce4"), null, null, "+313 77 (684) 38-54", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("923414ad-7332-4a75-a036-f50607a4cf29"), null, null, "+528 13 (220) 73-66", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("92643884-2707-4827-ac5e-df3b7fba6df1"), null, null, "+589 31 (962) 96-68", false, new Guid("84394bd5-aa3a-495f-8194-830f4a7e734f") },
                    { new Guid("92f70795-6168-49c0-94fb-6e8ff9bcbf5a"), null, null, "+849 41 (038) 96-53", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("937c80fb-2167-4123-a86c-5181b51b8d13"), null, null, "+873 02 (037) 86-79", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("942492bf-6b9d-42f4-9394-cba9754a9f64"), null, null, "+704 46 (311) 83-79", false, new Guid("26db4c52-c906-415a-848e-eb60cadca362") },
                    { new Guid("9432d29b-b953-4835-837b-5ba2689140d3"), null, null, "+58 58 (375) 48-59", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("94cc0a1c-6312-462c-924b-ac64a395db54"), null, null, "+849 88 (701) 70-46", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("9527774a-0f53-4cf0-b83f-c517563a8e58"), null, null, "+160 28 (344) 76-81", false, new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("9578a725-da2a-46d4-9ef5-8a67862eae72"), null, null, "+479 71 (765) 19-77", false, new Guid("bb2f2d67-8eec-4c20-8f50-880164bad5cb") },
                    { new Guid("95968923-92df-4024-81c3-15beb10b2826"), null, null, "+385 50 (488) 20-37", false, new Guid("06011f47-6f44-443c-a5da-5bb7964a0933") },
                    { new Guid("96493178-5c28-46bb-a909-7dbe68db7c21"), null, null, "+137 47 (244) 33-79", false, new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4") },
                    { new Guid("96522d81-5c27-452f-9bfd-975676d83388"), null, null, "+672 16 (053) 26-31", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("96617920-1aed-4659-85ed-8543fc5c7390"), null, null, "+582 79 (974) 16-09", false, new Guid("ef8556e4-bb07-404a-96b5-fe54c4180db4") },
                    { new Guid("97053f7f-1574-4625-bb6a-a200979b03d8"), null, null, "+464 98 (605) 82-30", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("970c18c1-e2c1-4e78-b74e-981ad811de7d"), null, null, "+640 90 (182) 41-94", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("98192f85-00f5-4cce-a0d3-11750fad5cba"), null, null, "+705 49 (265) 72-10", false, new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4") },
                    { new Guid("985d75f8-5c11-4c16-a69c-088334206da8"), null, null, "+474 66 (562) 53-65", false, new Guid("80e465db-0486-4f38-9fad-a2c18611ebf7") },
                    { new Guid("9863612b-4618-4edb-a935-b3128bd7b1e0"), null, null, "+851 05 (388) 74-87", false, new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f") },
                    { new Guid("989979a3-6db9-43e9-ab2a-abf7a0520540"), null, null, "+333 85 (279) 29-55", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("9899b7f5-1b53-409d-987f-0eac11689a6b"), null, null, "+133 98 (892) 23-04", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("98e02376-0079-4b80-a31d-bfc44905c70e"), null, null, "+877 16 (422) 53-44", false, new Guid("4c6d7da9-8b2c-4e1a-9f7b-e5e6b8aa212b") },
                    { new Guid("98e84da7-2621-4d28-8045-6ceb478869e7"), null, null, "+214 24 (368) 86-90", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("990d339d-d50a-42a1-9581-f91092dce7be"), null, null, "+585 96 (376) 43-02", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("99c35309-de58-4ad1-ab1c-cd0ac6b0af0a"), null, null, "+993 09 (951) 64-48", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("99d4eab5-29e5-4a5a-b183-bb8370abb698"), null, null, "+708 60 (129) 78-50", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("9a036a16-a46e-4e0d-8ce0-b75399740896"), null, null, "+763 07 (483) 99-93", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("9abd66f7-00eb-4738-bac7-0f7d583c3c85"), null, null, "+737 07 (173) 78-35", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("9ac0cf02-645c-4310-aa90-8621a18d228a"), null, null, "+937 29 (280) 43-07", false, new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("9afea1d0-9cf9-40c3-b99f-74c7f498373c"), null, null, "+685 93 (007) 42-92", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("9b12cd5c-d797-4392-99fe-3ed292c6d8f1"), null, null, "+882 14 (017) 21-32", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("9b67caf7-bdab-4f25-81af-036ad465b748"), null, null, "+197 92 (008) 36-37", false, new Guid("be43e642-1907-4f60-913b-2b34c8343cdb") },
                    { new Guid("9b68a7d1-b8fa-4c15-ac02-87f175dec7ba"), null, null, "+742 93 (336) 94-53", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("9b716750-0079-4bd5-a7fc-0f5a7b9c1dfc"), null, null, "+837 68 (280) 37-10", false, new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a") },
                    { new Guid("9b9a2cb5-85c7-4c70-9600-9c2726753f90"), null, null, "+681 75 (321) 26-39", false, new Guid("289481de-41de-41fd-9ada-a1a75c48ae8a") },
                    { new Guid("9bfffaf7-e59c-4143-ba75-31200c59b421"), null, null, "+832 96 (332) 30-59", false, new Guid("b77e828d-e54b-4141-a555-97cf88f23cbd") },
                    { new Guid("9ccf6a95-f7f6-4c49-8635-5099d5884441"), null, null, "+981 73 (680) 89-23", false, new Guid("ceb699bd-8c01-4831-9438-e8c30f353919") },
                    { new Guid("9d5cd6bf-1c0b-42ee-917c-a81eee64db07"), null, null, "+234 53 (741) 87-66", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("9d7d5727-45cd-4c52-99cc-17f50b7431a1"), null, null, "+152 41 (672) 00-47", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("9d8b6aa6-a817-4472-be5d-880a8a73762c"), null, null, "+911 44 (684) 60-45", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("9d8cb93b-5e48-4fc9-b7a2-9285cfbd7054"), null, null, "+532 55 (425) 47-31", false, new Guid("5ff76085-f948-43fa-aace-b09e8565dcd3") },
                    { new Guid("9e975891-77a4-4e38-b478-a3d159a4cb75"), null, null, "+711 84 (281) 28-44", false, new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("9ef6610e-6ba9-4e72-a49f-15d41cfa8552"), null, null, "+629 98 (768) 72-64", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("9ef9eb51-b63b-4bc9-843b-68f27ac33cbc"), null, null, "+928 72 (951) 86-98", false, new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803") },
                    { new Guid("9f0dd197-a4f8-4472-9c30-28b112296f5c"), null, null, "+273 12 (410) 48-89", false, new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2") },
                    { new Guid("9f4e245d-9c5e-40e8-9fa9-85b9adc3e9ad"), null, null, "+628 39 (671) 22-02", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("9fd19476-1288-4e73-a3da-026353734ede"), null, null, "+275 80 (228) 53-57", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a007c3d2-8cb0-4236-831a-4d5fc35f51e0"), null, null, "+476 25 (296) 96-28", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("a02214ab-c375-4180-8618-4651e17bd9ef"), null, null, "+326 31 (651) 85-90", false, new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf") },
                    { new Guid("a056187c-d366-4ce5-96b9-a954443f87ae"), null, null, "+516 65 (189) 78-45", false, new Guid("b9e8aa1c-7077-4088-b35f-cd5717f14f17") },
                    { new Guid("a069fc96-f4de-4bf0-98be-81e8cf36096d"), null, null, "+529 35 (575) 54-88", false, new Guid("bb551609-42ef-4406-8812-4a0cad8b3a0a") },
                    { new Guid("a07e3ca3-d1ba-4863-9ca4-597feac7cb61"), null, null, "+220 89 (974) 92-73", false, new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("a0ab9d06-8307-4fc6-adcd-6023316601f9"), null, null, "+904 92 (675) 94-71", false, new Guid("f443c798-1151-4757-94ca-517bef15e381") },
                    { new Guid("a109be1a-f9cf-4da5-b728-b30b59be991a"), null, null, "+219 16 (245) 02-33", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("a1993913-8dd2-4eb9-aee6-b62d53c8b1a2"), null, null, "+593 15 (705) 41-42", false, new Guid("e44c1ec9-9f80-4552-baa0-19bc1c34c34c") },
                    { new Guid("a1e0a8d0-5d9f-4f8e-b56f-98b2fc79e4f9"), null, null, "+25 19 (495) 72-14", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("a232a9bf-756d-40ca-8241-32402a251707"), null, null, "+925 77 (450) 70-94", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("a23bf8ac-23de-4415-976c-76ef941d3495"), null, null, "+518 43 (577) 35-44", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("a26fa91a-db1c-4cb4-a930-972652807a03"), null, null, "+103 63 (040) 98-42", false, new Guid("5f5fd2c9-49cd-4a96-9b96-06190882adda") },
                    { new Guid("a2c2edbe-e89d-4b6c-8649-90d04e854f55"), null, null, "+772 48 (750) 52-98", false, new Guid("4e8e0581-239d-4586-9cca-aad850d7d329") },
                    { new Guid("a2f4b31b-b6e7-4beb-b960-335be5e265c7"), null, null, "+873 00 (048) 03-41", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("a320d69e-0127-455f-85d4-7be471e37bda"), null, null, "+592 81 (415) 10-62", false, new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("a32922ac-ce17-4203-877c-99cbeea995f8"), null, null, "+744 76 (043) 45-04", false, new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("a363839e-50b0-4abe-9e66-bc4644885b39"), null, null, "+398 62 (749) 65-77", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("a36a8baa-3cc4-478b-93d3-8ba0e8d22a4b"), null, null, "+486 08 (844) 48-62", false, new Guid("a9b45c9f-1f20-4863-8d77-bf3f59bb3058") },
                    { new Guid("a3b9991b-4c4d-4397-af6c-e4034d4ef85d"), null, null, "+543 72 (940) 42-85", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("a3c94cfc-1c92-4620-8bf6-283c5487e58b"), null, null, "+224 41 (417) 66-77", false, new Guid("99813ce4-2d4c-4ae1-ab11-3c76e5d353dc") },
                    { new Guid("a43f56af-3f21-4b9a-a5e6-0825f416c952"), null, null, "+839 17 (925) 34-59", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("a462422b-95b2-4365-a266-c25d5153a0ec"), null, null, "+735 45 (555) 16-68", false, new Guid("44736c29-d473-4b0c-9aca-5f9518cda391") },
                    { new Guid("a4813523-dc06-48de-9dab-46f40af83cb3"), null, null, "+795 23 (694) 02-50", false, new Guid("dbbf6df0-dbcb-46ee-88cd-99592a7df694") },
                    { new Guid("a51b62f0-4c3c-488d-8b30-68d53a2d6ebb"), null, null, "+116 46 (534) 76-13", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("a595f05e-985a-44d3-8962-60acedf52396"), null, null, "+128 88 (801) 53-65", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("a5b36133-81ae-4c1d-b33e-55d07995b17c"), null, null, "+6 98 (494) 21-90", false, new Guid("9aeea14a-6bc2-4b4f-b59b-596df96e6969") },
                    { new Guid("a5c6c84b-1028-4fc6-a72b-0a427040bd4c"), null, null, "+149 31 (167) 86-24", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("a633d212-ce17-4601-8882-6730db447b9a"), null, null, "+928 43 (958) 69-53", false, new Guid("42084417-3fa0-42b8-b8db-cde8e23b28ff") },
                    { new Guid("a6405646-9b07-47b7-b2a8-742bd00dcf4b"), null, null, "+975 79 (203) 32-34", false, new Guid("d6ff184d-068a-4142-ab7c-89ed9524cbec") },
                    { new Guid("a681a73c-b6c8-4d30-8aed-eb08ca725b35"), null, null, "+210 49 (199) 38-45", false, new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("a6a5467b-dbce-416d-8a4b-2e2ba8d43250"), null, null, "+524 16 (863) 58-40", false, new Guid("1cfb1bcf-42b2-45fb-9158-878306220f17") },
                    { new Guid("a6ca6da0-5ee2-422d-aced-ddcf5c0ff4c5"), null, null, "+626 84 (265) 45-78", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("a6cb7dc4-e37e-49fa-899c-8371c2b3c5a5"), null, null, "+896 12 (835) 98-01", false, new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("a6f9218f-2332-45b7-bb0e-ebaea4466106"), null, null, "+849 31 (601) 06-11", false, new Guid("1909a070-eed8-440c-9e1c-16073e761c90") },
                    { new Guid("a7488cd1-b955-42e3-bdec-44255e043f96"), null, null, "+955 08 (584) 31-73", false, new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056") },
                    { new Guid("a7702061-0098-444a-9e91-c6b6050d8285"), null, null, "+810 58 (785) 93-11", false, new Guid("e046fca1-590d-4528-9a08-8baa91140ac9") },
                    { new Guid("a7795d21-94f6-4de1-b7bb-90475b98172b"), null, null, "+488 41 (039) 31-34", false, new Guid("29e89fb4-1641-4ea8-8793-cf13238e1c7f") },
                    { new Guid("a79c8e9f-4fa8-4c74-bc3f-4fe6b35d9a02"), null, null, "+268 64 (856) 42-19", false, new Guid("a753ea39-154c-4adb-b9aa-27606b63c8d4") },
                    { new Guid("a7db2b69-8e6d-4e0d-b13a-939baff16b2a"), null, null, "+548 37 (905) 29-78", false, new Guid("a9de6c0b-3985-46d0-bc00-704a332b1644") },
                    { new Guid("a8074df5-84a1-4dce-8085-f14459f53e95"), null, null, "+404 01 (119) 71-23", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("a8cfcb50-42ef-48a1-bf35-227fd4fcfe1b"), null, null, "+493 22 (367) 51-75", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("a8e01d42-75c2-408a-b991-4c983ab3ecef"), null, null, "+494 88 (730) 36-18", false, new Guid("fb921f32-dc2f-4bc8-9fa5-62f1b32ecd5b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a91d0639-2b08-4a9b-b4c0-3c87e639294f"), null, null, "+517 70 (667) 67-30", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("a92615b2-be9c-4877-9343-c439cf6baf78"), null, null, "+523 48 (936) 85-22", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("a98afd14-29bb-475e-ad3d-310c8f81b848"), null, null, "+765 41 (316) 92-72", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("aa34c7db-044c-44d9-a706-2f8284517bcb"), null, null, "+703 06 (285) 60-88", false, new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722") },
                    { new Guid("aa4dc0c7-ca2b-4f80-b596-84f34ebc6627"), null, null, "+401 36 (233) 20-55", false, new Guid("09090c24-0518-4ef5-bc86-1551cb33e8ab") },
                    { new Guid("aaf8e53a-b1fa-46d9-b2be-5811ab9e4916"), null, null, "+25 49 (246) 00-36", false, new Guid("88d1d9d2-9944-471f-a2c5-6c1882e1c953") },
                    { new Guid("abc7a0ff-ad51-41d2-a220-cd54cfe3d511"), null, null, "+464 33 (524) 41-02", false, new Guid("f485798d-1525-429a-8e8b-8604e1673c1b") },
                    { new Guid("abf0c4f5-a67e-4163-a786-5f3ec9cdeb91"), null, null, "+547 17 (058) 03-92", false, new Guid("95f06adb-a1fa-40bc-8351-b298d818044d") },
                    { new Guid("ac544a08-1159-4184-9b7d-fb2dd7e745f2"), null, null, "+462 38 (761) 65-11", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("ac75b5eb-2e98-4293-8ed0-ec0242fefea3"), null, null, "+43 20 (996) 33-05", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("aca01c43-c7be-401d-a91e-8adb120b36ce"), null, null, "+58 93 (821) 11-51", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("aca11740-1189-45ad-ba01-e23bbee64e42"), null, null, "+821 10 (170) 59-12", false, new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("acd689bd-9ff0-4398-9af8-8237e2578d05"), null, null, "+627 04 (352) 82-99", false, new Guid("be3f1be7-5610-4301-9ffe-b2aa215b16d6") },
                    { new Guid("ad015322-7afd-481a-a31a-3280923c074a"), null, null, "+196 83 (558) 86-74", false, new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("ad5a82d9-d37b-4a68-8c1f-ea134faae548"), null, null, "+767 76 (763) 47-08", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("adcbabaa-4a9c-41fa-8959-d35679d89683"), null, null, "+406 35 (951) 39-65", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("ae0dbb87-341b-4b05-927f-7bfc0ec184a9"), null, null, "+553 40 (903) 76-70", false, new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8") },
                    { new Guid("ae1394e0-bcd6-40af-8887-18e90607ac1b"), null, null, "+348 62 (762) 86-46", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("ae50fc83-7a78-43d9-a4e1-9db8ed6faec5"), null, null, "+939 14 (633) 45-12", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("ae74c5a8-1ec1-4713-a775-f1e3b34a0698"), null, null, "+472 62 (586) 09-90", false, new Guid("53b6bc9a-8118-498a-b3b5-8213e921b5e4") },
                    { new Guid("aee364fb-b2d9-4374-9cd8-a4c590e49a47"), null, null, "+278 51 (932) 49-85", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("af0e8db9-8217-4e69-9fac-235ed23457de"), null, null, "+502 92 (469) 06-93", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("af3b5028-99fd-4c83-abf8-1e0f437387de"), null, null, "+136 44 (398) 52-03", false, new Guid("840d3146-7ba5-4d4d-bcbf-4bf5c12740c3") },
                    { new Guid("af3d8059-229b-43a9-867f-59cddcc9c15b"), null, null, "+445 06 (646) 29-98", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("b0ae5fa8-71bc-4dff-ae19-e1a1ff667e5e"), null, null, "+64 76 (957) 03-85", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("b11d48f8-4812-41b5-b18c-3d35ab0c1463"), null, null, "+869 04 (784) 86-01", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("b1774011-1bdc-4f44-a482-5699dc8aac95"), null, null, "+48 97 (319) 74-82", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("b23c353f-db7e-4afa-8f11-a8a1184daa31"), null, null, "+232 82 (358) 87-52", false, new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5") },
                    { new Guid("b25492f5-604b-464c-ad19-7bfaf00ca868"), null, null, "+642 14 (961) 98-37", false, new Guid("1820cce0-3b0b-4c3c-846e-7b0dc050ecf1") },
                    { new Guid("b25ff3d6-c746-4cc7-8c97-b581d676605e"), null, null, "+411 19 (457) 44-20", false, new Guid("3263060c-6f77-4e22-8838-b9c1fe61395c") },
                    { new Guid("b26e2864-0816-463d-9bb8-a0eb4129ba55"), null, null, "+483 49 (878) 86-05", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("b3ba9e30-4707-4cf1-abb9-cafc353076d3"), null, null, "+828 93 (747) 92-97", false, new Guid("c85a3b0a-0be2-4956-8248-886bba9f2a4a") },
                    { new Guid("b3ee1ff7-cb0d-4b4b-a51b-710901d1e513"), null, null, "+757 35 (750) 56-56", false, new Guid("0ec20584-d26f-41c4-b682-05916743e30a") },
                    { new Guid("b40e79fa-5c67-4689-8599-d35a2f70383b"), null, null, "+893 59 (416) 11-27", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("b41c4cd3-f07f-44a8-9311-74926a2670d3"), null, null, "+462 65 (835) 63-26", false, new Guid("5879cb17-a6c5-49a4-9eb8-ff06895b656a") },
                    { new Guid("b4847728-7b54-4348-8199-e713e72f24bd"), null, null, "+484 52 (333) 54-91", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("b5a4251c-60f2-4bfc-b340-f38953dd30aa"), null, null, "+44 71 (831) 32-66", false, new Guid("b6ffef31-ba54-42ab-aa06-04dd660b1ef2") },
                    { new Guid("b5bdfcac-f2b9-4f9b-9eeb-c0263cc1bdad"), null, null, "+69 49 (528) 90-10", false, new Guid("95b7ea8f-4e10-4561-8b84-a54703f9e55f") },
                    { new Guid("b5ee831c-0ed8-4376-bb54-904bc4128cab"), null, null, "+58 74 (728) 48-27", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("b64da2bc-8dc6-4523-88c7-3e5d5ad6e9e0"), null, null, "+94 31 (593) 89-04", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("b68a3c76-8a4a-439c-8357-86e482ff47d2"), null, null, "+427 04 (627) 14-75", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("b69ac43e-2eeb-44e0-bbf8-7c2e580305b3"), null, null, "+727 37 (854) 74-32", false, new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b6cf9397-709c-4e42-aeaa-7a2b32543eaf"), null, null, "+76 73 (575) 20-21", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("b7427fd6-de1b-4a98-b7d7-72b015a2a191"), null, null, "+35 80 (391) 04-27", false, new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("b8b5a84b-9911-4034-b4f3-5c5062927669"), null, null, "+372 46 (843) 17-49", false, new Guid("99f374c8-d976-4051-99c3-7305e5fea09d") },
                    { new Guid("b8e68b79-b9a7-4094-9758-2cb49fe2d27c"), null, null, "+851 73 (822) 43-98", false, new Guid("ad755590-668c-421d-994e-b7a783d9dcd5") },
                    { new Guid("b9139254-dc04-4d0b-b432-ec33de15ddb2"), null, null, "+148 07 (914) 24-53", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("b950c74f-bf7c-40ed-ab71-3f99c8e8ebc6"), null, null, "+80 48 (312) 55-14", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("b99a0bda-cd15-4e7d-a8df-88d5a9c4a332"), null, null, "+135 66 (331) 94-01", false, new Guid("f2542110-27bc-4868-b96c-53e10a66800f") },
                    { new Guid("b9a25332-9f36-469d-89a0-fefe0c464d9c"), null, null, "+279 16 (671) 36-45", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("b9db0848-03ac-4957-b563-053599ff5a07"), null, null, "+639 90 (669) 87-44", false, new Guid("7dcb8bc6-2010-432f-bbd3-868b182427f5") },
                    { new Guid("b9e0297e-638a-46c5-9ea5-381a0f3c1177"), null, null, "+500 73 (782) 78-97", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("ba0257f6-a19b-496a-ac51-bc35a0e8a0f3"), null, null, "+541 92 (939) 97-57", false, new Guid("a832bbc9-4a3d-44a3-a2e5-cf14d05cce1a") },
                    { new Guid("ba13eff7-ebfa-4a2e-b3a9-9158f5f9ea2e"), null, null, "+591 73 (294) 77-90", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("ba198d9b-7039-442a-be15-422680e03ebb"), null, null, "+366 00 (555) 63-04", false, new Guid("83f601a3-a2fb-4eb6-8cf7-26928d9204ec") },
                    { new Guid("ba2da7d9-1df2-4f7a-b11b-47e0259703f1"), null, null, "+15 05 (849) 67-10", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("ba85b694-56a3-4fa4-8a94-5e7580a576dd"), null, null, "+998 69 (415) 94-71", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("ba91632b-8ce2-426d-9eb5-cf7a57c22b2f"), null, null, "+967 50 (486) 76-92", false, new Guid("34e61bca-be2b-4e70-93ed-21fc29a3f803") },
                    { new Guid("bae4756d-e682-43d6-b5c4-f8b415df38d0"), null, null, "+707 31 (152) 37-10", false, new Guid("a9088496-0447-4b25-abb9-fce3ab7b03a8") },
                    { new Guid("bae6d42c-18da-4e75-94b2-c5cfa30ff767"), null, null, "+463 71 (003) 16-22", false, new Guid("08dba47c-71be-4728-9f96-d3e7b1e070cb") },
                    { new Guid("bb274307-bff8-4993-ac51-ee9e67fecd90"), null, null, "+691 25 (650) 12-21", false, new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("bb3eb80e-c590-49df-9ff8-4b36db07eba0"), null, null, "+528 73 (644) 31-43", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("bb9ecaa5-2dda-41bf-a92a-d2544ecf7251"), null, null, "+778 75 (666) 55-02", false, new Guid("0ec20584-d26f-41c4-b682-05916743e30a") },
                    { new Guid("bc33d13c-1661-4ba3-a04e-26e97b6626c7"), null, null, "+134 15 (314) 56-89", false, new Guid("489038c7-0441-436a-a527-66069a8b1473") },
                    { new Guid("bc49f49c-bd41-4ef5-916e-e70506c97367"), null, null, "+695 50 (463) 89-34", false, new Guid("77941635-e388-4774-9d8a-53d61f8a1c10") },
                    { new Guid("bcc1aa26-2430-4d7e-810d-537d18b0b243"), null, null, "+171 02 (041) 62-10", false, new Guid("44275811-c945-4a4f-8382-272488a907aa") },
                    { new Guid("bd0bd4d4-ad0e-41c3-b653-9c439d412caf"), null, null, "+858 42 (780) 57-03", false, new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("bd3d606e-0685-4f0a-8124-705f03192713"), null, null, "+736 39 (759) 05-25", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("bd585380-d6f2-41e1-b37a-ac87db8f80ee"), null, null, "+462 98 (872) 37-67", false, new Guid("2c35ae57-b692-42ac-b496-6afcfbf1f797") },
                    { new Guid("bd6aebbd-58d0-4db2-85ff-1b52cb6143e3"), null, null, "+778 30 (171) 65-82", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("bde73e7f-c03b-47cd-a540-ec5ef7bb893b"), null, null, "+902 88 (431) 14-81", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("be78534a-c563-491a-9d64-b719fdba2ec3"), null, null, "+367 23 (367) 59-51", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("be835f3b-2598-4347-a2c6-9dfe595108a4"), null, null, "+685 73 (643) 68-25", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("be93c6fc-8f85-4d77-9da5-57aa19425804"), null, null, "+960 62 (456) 39-16", false, new Guid("4453b63b-79b9-4821-95d5-b6b2892539d7") },
                    { new Guid("bfbec378-5aa8-4696-aea7-423c5009244a"), null, null, "+506 20 (479) 40-09", false, new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2") },
                    { new Guid("bff2bc39-026f-42d2-bfdb-d68df73682a1"), null, null, "+278 10 (834) 96-14", false, new Guid("113bc9c0-c03d-4956-8061-5d68ba3e3756") },
                    { new Guid("c0251e20-1306-45fc-a024-9fc4ac8d8798"), null, null, "+650 87 (363) 29-27", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("c026bee9-603e-4e4d-b31e-35a4ad8b3ba8"), null, null, "+632 05 (800) 17-95", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("c05057b3-85bd-4e2b-aa4e-97f35f670271"), null, null, "+586 76 (186) 39-08", false, new Guid("23fd6fb9-91ac-4883-a0fc-9f523e1cea84") },
                    { new Guid("c091f7bc-e2ca-4e86-8dc6-cd6f06672dd7"), null, null, "+172 45 (648) 10-77", false, new Guid("d40b88b3-c448-4bd9-9263-8ebd58efb04e") },
                    { new Guid("c0ab5b55-e169-4b07-ad44-ae78e449e833"), null, null, "+935 16 (389) 05-82", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("c14924fd-e059-4a4f-abc9-3abfd0515edc"), null, null, "+140 22 (557) 33-62", false, new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("c1818165-3f1a-44df-9bae-55f7ee8503cf"), null, null, "+528 44 (364) 24-30", false, new Guid("02c90068-83b7-4371-a95a-81a752d4a9a3") },
                    { new Guid("c20a4d34-ddea-4593-9c32-c048f2c8473d"), null, null, "+724 80 (970) 17-60", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c2aaa8cb-7ed0-4808-846d-1b537c6f26dc"), null, null, "+421 24 (760) 21-99", false, new Guid("6c1b994c-ec66-4c0e-97da-2b5438542056") },
                    { new Guid("c2beb78f-de40-4250-9a31-f544053a8300"), null, null, "+704 10 (133) 49-57", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("c30b72e6-9bb5-492b-ada8-a4710792607b"), null, null, "+314 81 (930) 99-61", false, new Guid("36b35b89-da67-408b-9178-d5d020a70822") },
                    { new Guid("c337c50f-2925-484d-9dee-b376d94548bf"), null, null, "+363 93 (825) 90-96", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("c3b51313-760c-4ea8-a7e8-77fd32f0c474"), null, null, "+303 48 (627) 83-93", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("c3c8f873-bab0-434d-9010-955217eb2aba"), null, null, "+44 23 (150) 86-76", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("c3ed9cd6-273b-41cf-bc4c-9c5d826a0b6f"), null, null, "+951 44 (058) 22-12", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("c56386ba-62f8-4bc0-b00e-8acca97d6960"), null, null, "+693 81 (929) 26-68", false, new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("c5694f61-daf5-431e-9596-4fa467e3e907"), null, null, "+519 73 (465) 04-64", false, new Guid("233b9929-d665-4f01-a2dc-5abdd8bb6312") },
                    { new Guid("c5e33160-914e-402c-ad69-82a15058408e"), null, null, "+117 13 (254) 05-86", false, new Guid("46075330-4d61-4bde-be40-948e47bd19fb") },
                    { new Guid("c63601d6-7e87-4b95-bf96-00da64a9f096"), null, null, "+370 55 (976) 97-90", false, new Guid("3b9b059d-ffec-48ba-8544-5ebd315ff67a") },
                    { new Guid("c681a095-a8e2-4ae4-92ea-26b7fdc130c9"), null, null, "+85 72 (276) 21-45", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("c6fae89e-560f-46f6-a842-90a9b1440b7c"), null, null, "+487 95 (876) 73-59", false, new Guid("97253083-0ecd-4730-b815-c4b8137ab125") },
                    { new Guid("c73d5b45-f8b2-4ed0-b2e7-330546c9a432"), null, null, "+842 09 (613) 90-49", false, new Guid("4e4a741c-1e5b-4f7f-a6d0-628fb47c2285") },
                    { new Guid("c801337e-0c26-4499-a802-7c27444d8657"), null, null, "+742 54 (727) 28-72", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("c8975be9-fb6c-41c3-860c-3344963b7fa2"), null, null, "+81 52 (925) 64-62", false, new Guid("962c87e2-8c20-497c-ae5e-1cbcb3fda44a") },
                    { new Guid("ca57b21a-0958-4c32-ae4b-8add43515d0a"), null, null, "+713 03 (968) 37-36", false, new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4") },
                    { new Guid("ca6fb623-ed6e-497f-a751-9341b8d43b12"), null, null, "+59 74 (945) 66-57", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("cb4e87e8-0b13-4135-9f77-f9ec64bdfb84"), null, null, "+420 04 (650) 47-58", false, new Guid("ed2879c5-5c43-4e8b-982a-fd9aab90a32a") },
                    { new Guid("cc39f319-354f-4e71-84ae-f33f7fd0bedc"), null, null, "+919 57 (121) 29-98", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("cc8c2868-1d81-46e5-a91f-5066d2c65456"), null, null, "+229 93 (042) 47-81", false, new Guid("2e9a8f45-b30c-48d6-a7f7-0d70c6aca9d0") },
                    { new Guid("cce2834a-3352-472f-9c20-90f18616f867"), null, null, "+169 98 (994) 25-81", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("cf28516a-3889-4706-843e-94746b4019b8"), null, null, "+663 04 (933) 38-47", false, new Guid("4a66e9c3-f23c-427e-852e-fa3becb846e2") },
                    { new Guid("d176d144-82e3-43f9-a14f-60f4bf096f07"), null, null, "+982 54 (703) 48-27", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("d1c52b80-5aee-4c6d-9f9e-b3ee6079cc98"), null, null, "+34 96 (747) 33-91", false, new Guid("2f21f4e2-cc80-4751-9645-5d5b8b7f004f") },
                    { new Guid("d1f52712-a17f-4eb4-a3e8-a3a920d52430"), null, null, "+834 27 (892) 06-84", false, new Guid("eea73942-2019-41c4-9063-ab64deb92300") },
                    { new Guid("d269ac99-b3ed-4eff-ab0d-ac689b10e143"), null, null, "+55 51 (827) 79-60", false, new Guid("4e8e0581-239d-4586-9cca-aad850d7d329") },
                    { new Guid("d322e976-548c-4687-9652-2d8fb24d99c1"), null, null, "+946 00 (760) 68-53", false, new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("d35aa39c-6496-4372-9040-ce74dd70a6b4"), null, null, "+337 00 (028) 19-91", false, new Guid("eea73942-2019-41c4-9063-ab64deb92300") },
                    { new Guid("d3751c37-6a98-455c-b5a0-4105d93eaecc"), null, null, "+65 57 (850) 37-65", false, new Guid("e3cc1fbb-5141-4fa1-a79c-03ceb2042042") },
                    { new Guid("d37e1789-826c-484f-8e5c-d36108143511"), null, null, "+22 02 (289) 39-99", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("d3bfc450-6761-40db-8b7e-ae3daf91aef1"), null, null, "+140 29 (483) 92-07", false, new Guid("11712f31-db09-482e-bdab-2c19dff98304") },
                    { new Guid("d4348069-d97a-4456-ac72-f6e30aea9e04"), null, null, "+661 55 (936) 17-18", false, new Guid("0449c00b-67fb-44ee-b38d-625e9e39c640") },
                    { new Guid("d47dc7d7-da50-4ce5-8b1d-a36324e72238"), null, null, "+616 69 (800) 71-63", false, new Guid("d034f7e9-251b-43e2-912d-0a4bd94283bc") },
                    { new Guid("d4b90a65-83df-450e-b87d-66976d92fb0e"), null, null, "+408 71 (188) 45-33", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("d4dd95de-fc5b-4d37-bf1f-03ba6e7a2767"), null, null, "+133 01 (286) 11-52", false, new Guid("7aaf1d3d-bf81-46b9-9b0c-d3dfd4dd7d0d") },
                    { new Guid("d4df7627-e28d-4c9e-ab86-e948672c6a1b"), null, null, "+607 41 (066) 79-23", false, new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") },
                    { new Guid("d54941cf-5395-470a-bfcc-54614f51a819"), null, null, "+850 05 (566) 89-00", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("d5c1bc2f-42df-42c3-85e8-afef1bb05aee"), null, null, "+114 35 (039) 59-04", false, new Guid("1da41f3d-f18d-4228-a8e1-4faa5d44cec2") },
                    { new Guid("d5c88a32-0f95-4c54-9884-aceab24fc54b"), null, null, "+286 89 (832) 87-44", false, new Guid("9700829d-372f-4f5b-a27f-e9d392217b8e") },
                    { new Guid("d5d8eaa8-1152-478d-b5ee-79b8698d67cb"), null, null, "+735 65 (722) 54-48", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("d5e28a15-ba72-4d22-981a-e1d2a676c509"), null, null, "+285 78 (377) 05-21", false, new Guid("9c69ea1b-3930-4f19-b236-f620f9575ce1") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d5f238e7-c192-45ca-b16f-442b0c35e58d"), null, null, "+890 07 (712) 68-88", false, new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("d65c5813-88c3-4230-a13e-7798309be730"), null, null, "+941 80 (868) 72-80", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("d6ec21ab-25e2-4b0d-af6c-6588ba28c53d"), null, null, "+189 82 (165) 23-10", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("d7498dd8-92b6-4954-91ef-137b85d32a83"), null, null, "+158 56 (067) 91-18", false, new Guid("fc6ec065-3aae-4eff-9eb1-caf2d293c337") },
                    { new Guid("d7af6d9d-0f60-40f9-90c0-20d9a6915b62"), null, null, "+761 83 (107) 69-45", false, new Guid("12bcae5a-4c6d-4950-899e-09cd78bfbbb3") },
                    { new Guid("d7b1613d-2b53-4a91-b886-fe62bb262b00"), null, null, "+363 05 (096) 21-45", false, new Guid("aa0bdb51-a14b-4dd0-a522-d6cf778aad32") },
                    { new Guid("d7df7cfd-7ab2-4ade-8a4c-e0c400fc3113"), null, null, "+849 16 (753) 28-32", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("d8544116-96f0-4a43-9bc9-df37a5d312c4"), null, null, "+627 93 (570) 62-50", false, new Guid("92dc01ef-8344-4bd4-ac38-0d80ae5a4ea2") },
                    { new Guid("d8dafca5-fe3f-4063-9646-aaf068505ea5"), null, null, "+124 16 (290) 67-96", false, new Guid("99f374c8-d976-4051-99c3-7305e5fea09d") },
                    { new Guid("d8ebe383-5cc7-4ee6-9589-d1d7a874a569"), null, null, "+673 79 (815) 53-58", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("d8ec46c1-6d41-461a-8bdd-a06b6a85d061"), null, null, "+8 83 (307) 70-92", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("d928dfb7-50d3-4b99-a993-ffaeb98a95e5"), null, null, "+95 42 (572) 64-30", false, new Guid("5c4b4997-d098-4675-a8a6-a46941da73c6") },
                    { new Guid("d935811b-cc09-427f-a267-a159880355ad"), null, null, "+888 48 (775) 96-83", false, new Guid("0a6e93cb-d6f8-468f-8219-aaf731f7cd16") },
                    { new Guid("d9625e8f-c69c-48d7-810c-6d044165cccd"), null, null, "+462 15 (023) 54-03", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("d9b090de-bb07-41f7-9647-03e6487565ad"), null, null, "+40 16 (796) 53-88", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("d9e34af6-6cd2-4e38-9519-aedb4a9e5787"), null, null, "+154 85 (003) 42-55", false, new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("da0a79ac-d614-43c5-86d5-8ac21a9b3e73"), null, null, "+268 62 (675) 04-47", false, new Guid("3740ad90-a6f2-44a7-8bad-c6ab82ed6b00") },
                    { new Guid("daa27d1c-f27d-4f27-b1c4-235363d5d903"), null, null, "+860 12 (727) 48-06", false, new Guid("95f06adb-a1fa-40bc-8351-b298d818044d") },
                    { new Guid("dadf1ea5-a119-4934-a1df-0d0ad9989357"), null, null, "+798 32 (191) 76-02", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("db1df031-a0cf-4f0d-b592-18323437a7d7"), null, null, "+838 03 (578) 17-36", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("db8d7d06-426a-4208-8c12-6da2ad379fa0"), null, null, "+158 26 (755) 72-68", false, new Guid("70409336-0f26-4108-8c79-213e320c07f7") },
                    { new Guid("db915deb-2edc-44c3-9ad5-b068394527a5"), null, null, "+896 80 (543) 97-96", false, new Guid("e8404e1f-da32-4f4b-9a9f-9213c10e98d3") },
                    { new Guid("dba1b048-1468-4a8f-a1c4-ffcd1b6f888b"), null, null, "+480 43 (765) 74-60", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("dc19ad03-a129-4a71-94e7-fba93933d105"), null, null, "+676 79 (765) 86-34", false, new Guid("f0f7f335-d1bc-4bfd-b937-07c64eb5a722") },
                    { new Guid("dc2cc74b-07dc-483d-ad08-151608f87641"), null, null, "+499 23 (829) 26-86", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("dc99f507-7e23-4694-aac0-5c9eadade0ff"), null, null, "+510 01 (900) 82-26", false, new Guid("c2840039-156f-4b4b-9b1b-9e5c4207c5f2") },
                    { new Guid("dd23f008-f072-44c4-a99a-de77f164544e"), null, null, "+510 62 (724) 66-51", false, new Guid("97253083-0ecd-4730-b815-c4b8137ab125") },
                    { new Guid("dd63e9cb-34ed-488d-a66e-9640d789120a"), null, null, "+318 03 (552) 75-78", false, new Guid("59a12fe4-11b3-4852-8520-bd4ebd82dcd1") },
                    { new Guid("ddf21d51-3a7b-411a-b846-7a28d36f8246"), null, null, "+802 63 (561) 09-24", false, new Guid("6085da89-2350-460f-ad12-9bdc60c6760e") },
                    { new Guid("de14892a-0040-40e7-a9d2-d4afa9d4d264"), null, null, "+120 43 (708) 75-45", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("deb42be5-7a12-449c-8ccf-9a744d6ffab2"), null, null, "+574 54 (146) 89-93", false, new Guid("f819889a-570b-4521-a36f-42d900233678") },
                    { new Guid("debccfc8-ded4-4f94-a0fe-db79b8ed4121"), null, null, "+783 68 (384) 56-51", false, new Guid("10f14992-154a-4eeb-a5fe-23d6ceba7af3") },
                    { new Guid("ded613ba-1e96-427d-ad56-11c844260062"), null, null, "+41 85 (270) 48-09", false, new Guid("44736c29-d473-4b0c-9aca-5f9518cda391") },
                    { new Guid("df14f718-4bcf-4571-86c8-b096543dd23a"), null, null, "+249 92 (374) 76-71", false, new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("df893fdb-9867-4edd-af7f-68977608a493"), null, null, "+158 57 (541) 93-85", false, new Guid("66fa35f8-b079-4d87-96a0-cd59d477ce53") },
                    { new Guid("dfac5f15-b481-4fb6-a81c-872e1e18a7af"), null, null, "+530 66 (069) 20-12", false, new Guid("1cf7099d-379a-4f4a-98c3-f3f3277bd27d") },
                    { new Guid("dfdeec8d-627d-4fa6-a89e-a038461ed6ee"), null, null, "+292 03 (611) 91-94", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("e008cb3e-8a6e-43fa-b6a3-cd4086ec275d"), null, null, "+188 49 (656) 56-83", false, new Guid("fe7cc411-8395-4a31-8956-9b9b9fabdad8") },
                    { new Guid("e070d75f-8611-4c80-acc5-d1d87867788e"), null, null, "+732 82 (492) 02-52", false, new Guid("72e5a242-7f54-4bd9-ab0b-2e218f18188d") },
                    { new Guid("e13af783-3d91-43e1-bcd2-efddc0490b08"), null, null, "+407 44 (479) 16-07", false, new Guid("6bd2af06-7969-4a40-a8e2-60b8b21d797d") },
                    { new Guid("e143b19a-341f-4cd2-b25e-470f4363ed9d"), null, null, "+518 38 (506) 62-70", false, new Guid("98625fc6-b286-41b9-947a-4b3616cd79ed") },
                    { new Guid("e145d477-7a1c-45ff-b210-f230db626fb6"), null, null, "+8 82 (882) 20-42", false, new Guid("ac51d63c-5b0f-4783-83ff-e8a8a1331afc") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2004a39-ed6c-45f0-b5c0-64a420f5178e"), null, null, "+129 91 (523) 10-94", false, new Guid("f33a7c55-6bf6-4aa2-9260-a6fc9dc18b5e") },
                    { new Guid("e2018040-ce1a-4d64-b606-f02d77ed5786"), null, null, "+738 26 (153) 72-27", false, new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("e24eecc4-3e64-4e36-aa62-f968f5127053"), null, null, "+576 18 (080) 65-93", false, new Guid("fd38c251-62d8-47b6-a3fe-3644bd2aadea") },
                    { new Guid("e30b12e8-5af3-463d-9c3f-c97482839f38"), null, null, "+65 04 (145) 39-72", false, new Guid("045e886f-32ea-4079-bd78-6f687a96f5bf") },
                    { new Guid("e3331ff9-93ca-46c6-9c4c-ca033574e144"), null, null, "+293 66 (147) 38-90", false, new Guid("f45c4734-09f3-47be-a309-27e9dfb6fbd4") },
                    { new Guid("e35527b0-1fa0-4478-b5b8-865c35eca5a8"), null, null, "+309 80 (749) 15-94", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("e365ac8e-b2b7-42a9-864d-7b2a98ddd379"), null, null, "+165 57 (362) 64-41", false, new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("e3d40202-5155-40ca-aa6a-cd002ee22e08"), null, null, "+5 28 (756) 68-64", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("e3d66db9-7f67-410b-bf8d-32000cd1059e"), null, null, "+576 61 (179) 83-51", false, new Guid("eac7c2e6-1a6f-49b1-9489-a573f46b0ff3") },
                    { new Guid("e458b9b3-7a47-477b-93e2-9c88ee07c0b6"), null, null, "+927 40 (873) 95-62", false, new Guid("fee7146e-2aaf-4a0c-b616-0bb8a2228ea5") },
                    { new Guid("e46cc869-dbf8-4f03-aba3-f52a22999abc"), null, null, "+777 81 (916) 76-72", false, new Guid("5ed2ef7e-ef6f-4dd7-b43b-487b743b83b0") },
                    { new Guid("e4e7f94f-b46f-47d9-9881-2f781a70f2ec"), null, null, "+733 25 (456) 92-94", false, new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("e4f2d619-a9cc-49a7-b028-617869e731e8"), null, null, "+500 08 (751) 58-67", false, new Guid("921afb0d-3003-4662-95c2-a2c74a4b8a27") },
                    { new Guid("e528c19b-e3d6-4046-9e37-e5e73af8ee3d"), null, null, "+584 28 (265) 90-02", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("e56ffe27-8ccb-4b9d-99dc-0828cd631413"), null, null, "+438 59 (891) 14-90", false, new Guid("f485798d-1525-429a-8e8b-8604e1673c1b") },
                    { new Guid("e5fc2278-df65-4885-93c5-8ca3e30a76ef"), null, null, "+999 34 (435) 08-32", false, new Guid("cd9b7a5f-1d3d-4a32-bd2f-baa99e0eaf3d") },
                    { new Guid("e5fd079c-8240-49b7-93d4-2319dba668c6"), null, null, "+520 02 (719) 55-17", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("e63cc053-878e-4ccc-b3d1-0a7adb4b3323"), null, null, "+193 15 (081) 31-72", false, new Guid("59bca1c3-a467-4623-b95f-1679227c24ca") },
                    { new Guid("e697c1b4-33e3-4750-b5f6-aae4d9a92014"), null, null, "+375 87 (727) 65-43", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("e6dc971d-76b8-4f61-9f35-06a9c1921ede"), null, null, "+910 46 (426) 00-38", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("e6ea33ed-2a27-4067-876b-3e2ea5ea952b"), null, null, "+445 98 (023) 77-65", false, new Guid("828fdd3b-83f4-41d9-92e0-611d8f22e1fe") },
                    { new Guid("e72e83df-f258-4e03-b2b6-cdd6f3e434ec"), null, null, "+465 89 (851) 19-94", false, new Guid("0285733f-1deb-4aad-891f-d1fa68e2928f") },
                    { new Guid("e76703aa-068a-45f9-b1ed-b61f98e36a85"), null, null, "+129 26 (260) 30-86", false, new Guid("4e74259f-0264-4f06-8e5d-85d289652986") },
                    { new Guid("e7e92cc5-ac0f-43e7-81c3-17f8638a668e"), null, null, "+323 38 (918) 03-59", false, new Guid("3d0ce621-29e8-466c-8ed0-69e6e4e6af2f") },
                    { new Guid("e7f3c3dc-5f4d-41a9-911a-381d008205b4"), null, null, "+448 36 (552) 23-02", false, new Guid("a94a614f-da78-4ea4-95aa-47dec8052b93") },
                    { new Guid("e84ae2be-090c-4391-91ff-c029e417b1bc"), null, null, "+831 16 (305) 01-94", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("e8c4fbc2-5d21-4dbb-b6ce-1c950a5f8ac8"), null, null, "+723 26 (215) 01-45", false, new Guid("6b222fe8-27fb-428b-9be6-8c21f4a85684") },
                    { new Guid("e94e50d0-2583-4918-9f80-a22b30b9d337"), null, null, "+462 32 (202) 37-02", false, new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("e99fd964-683c-42fe-a06a-fe1b7883e8dd"), null, null, "+788 22 (731) 72-96", false, new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("eb43a349-1562-4d6e-886b-d0764b5da93e"), null, null, "+728 33 (254) 62-74", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("ebd1b87d-a4d7-4245-9570-f3625fc29f9b"), null, null, "+795 50 (007) 25-46", false, new Guid("9f1ab90d-1427-4b47-94f1-881f01a691c6") },
                    { new Guid("ebf5645a-413f-47f2-bb6b-a613aa2d1917"), null, null, "+635 65 (228) 31-09", false, new Guid("a190d9f3-2d99-4ca1-9381-864c52de60d7") },
                    { new Guid("ec026ac4-e4de-4a68-843f-f856282cd7ca"), null, null, "+659 97 (187) 06-02", false, new Guid("a672ae4f-a6af-4cd7-ab65-0f0441fa9c12") },
                    { new Guid("ec2b34ff-342d-45aa-804e-3fbe52881e47"), null, null, "+764 31 (457) 09-86", false, new Guid("118c42ca-84f9-4646-8054-9d6aa2b2b826") },
                    { new Guid("ec445c7a-0a6f-417e-9fbb-5b65d6171849"), null, null, "+556 66 (349) 14-62", false, new Guid("f68934d9-5a6f-4cfb-8b29-0812d0b7e9ce") },
                    { new Guid("ec5fa0e4-9094-44cd-8ff2-72006aa89fc1"), null, null, "+359 72 (575) 18-95", false, new Guid("757e8d68-6931-451c-9e0e-78a03f927058") },
                    { new Guid("ec8198d9-9fa5-490b-929c-1f877daccd50"), null, null, "+824 08 (232) 34-99", false, new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888") },
                    { new Guid("ec984315-642f-45e0-94b6-e1858ee03f6d"), null, null, "+759 73 (228) 53-24", false, new Guid("697b6664-9bc7-4079-afcd-c2363400f5a5") },
                    { new Guid("eca36c5b-ef83-4947-9e8a-134d80b3a042"), null, null, "+979 76 (215) 76-23", false, new Guid("b94bd5c8-9cfa-48b6-881a-f9af964ba7e7") },
                    { new Guid("eca4d940-e6e3-4d14-9987-f6142045e061"), null, null, "+16 52 (452) 61-71", false, new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a") },
                    { new Guid("ecb4578e-590f-4089-a65e-f8d5810f17f7"), null, null, "+300 80 (376) 33-23", false, new Guid("5f0ac6f8-c976-486f-b071-e2049e475599") },
                    { new Guid("ecb9efb8-9bda-4155-baa7-6ee73681c202"), null, null, "+24 01 (094) 50-06", false, new Guid("36f2fc01-2b45-498e-bb97-b6e101686abc") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ed47047c-40c6-456a-9909-05e02c252ca0"), null, null, "+560 07 (785) 73-59", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("ed519b68-a46a-4f17-bd82-bf9c0a275a36"), null, null, "+67 48 (213) 13-35", false, new Guid("85e891eb-3f26-47f6-88f8-2cfc12a454db") },
                    { new Guid("ed71967c-077f-4d18-8798-821019fdd8a1"), null, null, "+824 40 (338) 58-72", false, new Guid("3525c903-c292-4d3e-942f-aeae98225a62") },
                    { new Guid("edaa57fc-33f9-428c-b7a8-39315bba4f53"), null, null, "+590 75 (480) 81-50", false, new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69") },
                    { new Guid("ede6950b-9e4b-4b45-92b5-3ab7c2f3403a"), null, null, "+995 80 (911) 15-18", false, new Guid("e0808893-52a5-409e-98bf-8ce6c6048df6") },
                    { new Guid("ee0dfd46-6ea2-4b9b-b76f-f254e991da3b"), null, null, "+598 45 (923) 27-91", false, new Guid("43a61852-1e99-4cc3-a2c9-1efa515fbfb3") },
                    { new Guid("eeb7dff6-87f2-431f-8b20-cf07b6f8445e"), null, null, "+938 87 (908) 77-45", false, new Guid("8ebb8e6f-deef-40b0-b5c5-ed201b16aa89") },
                    { new Guid("ef163846-8c20-4014-9f9c-fd780beacecd"), null, null, "+895 92 (039) 72-33", false, new Guid("3e5fbebe-b3b8-454b-a81e-57c912ec3c46") },
                    { new Guid("ef4b6961-815e-46e6-b3e6-b1976c473a8b"), null, null, "+719 61 (199) 27-37", false, new Guid("da47e362-4e1f-4c27-ad94-4046d10b579b") },
                    { new Guid("eff4b868-2c09-4378-9d9e-49263f0717c0"), null, null, "+742 33 (623) 01-41", false, new Guid("5967c8b0-b331-4553-bab0-23d04868d703") },
                    { new Guid("f016bde5-98af-44a8-8234-e623b3bfb811"), null, null, "+903 15 (793) 90-37", false, new Guid("917e6b33-0701-49d9-adca-88d7a49e38c8") },
                    { new Guid("f066eb05-5ce6-43e4-b95a-90d5d04757b4"), null, null, "+925 45 (089) 79-94", false, new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("f08f4ff1-f854-464b-9c10-4616fd4b920d"), null, null, "+405 32 (906) 46-07", false, new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("f090ae98-dcda-4ac3-9fb2-3a0ba270e19f"), null, null, "+120 22 (246) 61-53", false, new Guid("dcdad7a1-337a-425c-bdf6-6762e6acf50d") },
                    { new Guid("f0a2f412-b610-46c2-bd06-f2fe4242d82d"), null, null, "+957 09 (859) 96-67", false, new Guid("fe491e07-144b-434c-8282-ac49a9bfa9c5") },
                    { new Guid("f0dcd3ad-25cf-44b0-8f18-b5f8637ee01b"), null, null, "+709 74 (847) 40-00", false, new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("f197c139-9cae-47dd-8dc5-d58326d04f16"), null, null, "+17 87 (814) 40-03", false, new Guid("2202c5eb-6b46-4836-95e6-84d273647c0d") },
                    { new Guid("f1af673f-ff8a-4fdf-9830-c95d953371c7"), null, null, "+473 74 (787) 04-55", false, new Guid("82dea5d6-6f6d-460c-869d-56fe2e520d8e") },
                    { new Guid("f272f109-dfe6-48e2-a421-734a3c9d76e9"), null, null, "+443 52 (195) 47-72", false, new Guid("78a3f217-70d6-4719-be4b-bbfc3d3a443a") },
                    { new Guid("f284a7fc-06d5-4f37-b3d9-ab9f58597686"), null, null, "+99 14 (355) 92-05", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("f2b3427d-1ec1-41ef-b725-604f1e3ddb33"), null, null, "+447 83 (698) 38-24", false, new Guid("b7d83000-87bd-4ab2-8283-0807f0ee172e") },
                    { new Guid("f2b3961b-4114-4800-8a99-fd9481ecf61d"), null, null, "+809 15 (646) 80-69", false, new Guid("76d6c2c9-4dfd-4bf7-a80b-a1c5fdd7a5cf") },
                    { new Guid("f2bab94b-4e78-4c99-80fc-cffcde33267b"), null, null, "+77 70 (625) 70-35", false, new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("f3364ac0-e257-4c91-bf69-ccc1f4904ec2"), null, null, "+973 35 (230) 94-62", false, new Guid("ad755590-668c-421d-994e-b7a783d9dcd5") },
                    { new Guid("f3df0ddd-08ec-4a76-81dc-a5ed9e0ffb78"), null, null, "+925 14 (082) 53-51", false, new Guid("b6ddaf07-48c7-4e4c-a937-e451450a8a80") },
                    { new Guid("f3f7f81b-6bbd-4f63-b782-0c38ac82cf39"), null, null, "+180 61 (316) 12-35", false, new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("f438788a-0bce-4c1b-a1eb-c9491c1a8e3d"), null, null, "+866 37 (118) 91-89", false, new Guid("2def2b5c-c6e9-44b6-a91a-b4b56b926483") },
                    { new Guid("f4c6a01a-35f5-4839-9d39-4ce583bdd523"), null, null, "+495 19 (357) 75-53", false, new Guid("fabca31d-fc90-4328-bcd6-7dfc07cf503a") },
                    { new Guid("f51e5531-954b-4930-88cf-521062f28ef8"), null, null, "+122 83 (144) 00-80", false, new Guid("f832e211-7847-47ed-9b0a-2a52032ba50d") },
                    { new Guid("f5b2078a-d587-4e6b-a9f8-f25b6c806cee"), null, null, "+436 89 (811) 85-04", false, new Guid("e87e502a-19b0-4f23-969d-aabf313d6591") },
                    { new Guid("f638861a-4d1d-4de1-8fc6-c0d6915ed770"), null, null, "+85 67 (415) 82-09", false, new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("f656d73d-05a0-4cf2-b383-4a9fb1776a68"), null, null, "+640 05 (931) 18-37", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("f665bcda-6a4c-480d-938d-9d2eaff477de"), null, null, "+853 00 (276) 27-24", false, new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("f6b73315-2e65-44dd-8622-a05a12d8a04b"), null, null, "+953 27 (659) 09-20", false, new Guid("616b58da-6ad7-4e69-bf6c-28366139e91f") },
                    { new Guid("f7c9a059-7598-41b9-8908-1c472b91a78a"), null, null, "+588 61 (538) 98-94", false, new Guid("16b5e2ea-193b-4980-ba2f-5b3923ef1a69") },
                    { new Guid("f7f9b254-f668-4f25-95e8-a48a5cb5b7c9"), null, null, "+974 14 (302) 29-53", false, new Guid("88ca4f85-6fa2-4198-94dc-4285226c75cf") },
                    { new Guid("f83bb4d0-02b4-4a3e-8fbb-ed94601775ce"), null, null, "+145 99 (422) 61-14", false, new Guid("d6981353-e0f4-4a8a-ab45-ac0cbff313c0") },
                    { new Guid("f863cbff-d736-4db0-8a13-125ad77fcd48"), null, null, "+303 46 (066) 93-39", false, new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("f8cf966b-938c-4f8e-ab44-7f153dca31cd"), null, null, "+992 88 (118) 73-26", false, new Guid("4cb87e0f-3c69-4c89-90eb-ebe6785d7742") },
                    { new Guid("f8d431d0-a121-4a8d-adf1-6d9c02d189d4"), null, null, "+549 12 (701) 90-39", false, new Guid("886834e8-e5bd-4426-961f-ce0d1c7d1500") },
                    { new Guid("f8ddc465-e33a-4b3b-aa3d-76262299bb95"), null, null, "+343 53 (180) 52-60", false, new Guid("a766a08b-8683-4fd6-aa43-248f0a0c3888") },
                    { new Guid("f8f6f52e-5bd9-4bd3-b779-182605e2d195"), null, null, "+43 72 (514) 05-18", false, new Guid("bd502b55-765c-49bd-97a0-3d22eeb09ed5") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "PhoneNumberConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f9009202-c851-4880-af79-857ecf908df0"), null, null, "+371 25 (500) 26-37", false, new Guid("234cf821-c69e-41fd-b13e-68660060a87e") },
                    { new Guid("f9010aee-d9dd-4e98-a220-6a635642d51d"), null, null, "+26 74 (951) 58-55", false, new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("f92851f8-cedf-4807-b681-a306a45ecfec"), null, null, "+274 26 (765) 49-47", false, new Guid("44d3ba4d-ae7d-47af-8776-7fdd0db030c6") },
                    { new Guid("f99a59bd-72f9-4534-8d37-bf939d4666fc"), null, null, "+436 87 (329) 83-62", false, new Guid("bf376840-e8e1-42cc-8d40-56a430a87b7e") },
                    { new Guid("f99dfbea-85fd-4630-8a60-1ef42b8cdeaa"), null, null, "+598 65 (079) 82-34", false, new Guid("3855a279-823e-41a4-ad2e-768e134c626f") },
                    { new Guid("fa2bfc03-e151-4de9-87af-f2add0d1a303"), null, null, "+594 15 (275) 13-75", false, new Guid("09c20ba9-9a1b-486b-861c-31559b71d08f") },
                    { new Guid("facb37e6-728e-4107-a9b3-26186b12be37"), null, null, "+254 13 (116) 46-88", false, new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("fafe3460-7db8-47aa-9d40-9e0840458a5b"), null, null, "+971 06 (012) 89-86", false, new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("fbb3d9c9-6512-4ef9-8170-dd183bbda029"), null, null, "+969 06 (742) 61-77", false, new Guid("de928398-b9e7-48b3-8338-521cfb5f5c0c") },
                    { new Guid("fd7f173d-b103-4992-a0f0-6fe67e47569f"), null, null, "+530 40 (937) 76-37", false, new Guid("88f9b1fd-786f-47cb-b81e-9654bddcc7ad") },
                    { new Guid("fe12e866-4500-4de3-af9f-22cc69f4cfd5"), null, null, "+592 71 (234) 02-75", false, new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("fe9e5bdb-2733-4553-9acc-ccf2e45f40dc"), null, null, "+832 93 (575) 79-02", false, new Guid("296afb0f-f9b3-4c49-8bda-f2101933ab58") },
                    { new Guid("fea44b6d-7f04-4aff-a33c-95ddeb2f24f7"), null, null, "+919 10 (133) 79-43", false, new Guid("6d79ff5f-5842-459a-a78f-3c84d675f071") },
                    { new Guid("fee2927a-14e4-46fa-bddb-51f32a556ead"), null, null, "+472 47 (200) 78-10", false, new Guid("3855a279-823e-41a4-ad2e-768e134c626f") },
                    { new Guid("ff4036bb-9ffd-459c-95e9-f0f476000991"), null, null, "+249 90 (665) 85-27", false, new Guid("81183e18-3837-4360-b9c7-144c81c3f4c2") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("05954aa8-2c70-4a74-9c02-8a8e2a41e0e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d225bfd6-6d7d-4acd-8598-a1a048a53061"), new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("0a7faf32-2467-4588-b0ad-208a2b091b29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5cd8f8a2-7eac-4fbc-8851-a8271d94315d"), new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("13b135ab-6ed3-4806-802b-68d2478d34da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af15b13a-67f7-4775-ac7a-4ae6c6d43dd1"), new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("1464682a-04fb-436a-aa30-883aeecf7d1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9f2fd672-f226-4cb3-9467-183e5a87016b"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("17964360-f047-4e07-81d8-44b13bc3568c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("066569c6-7b94-4971-bcc0-575e73552772"), new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("22416819-4fe9-4895-a9e6-663d4c3c91c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a27aac90-e996-4a91-97a3-32d1372d37da"), new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("253d820d-4f04-44fb-a0bf-ac99da61581b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5cd8f8a2-7eac-4fbc-8851-a8271d94315d"), new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("2767cf0b-780c-48ce-ab4c-f44ab89392fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d0e6e381-354d-4323-ad3a-c4f945792596"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("2b22d8be-f4ab-4d1e-aef7-47d7f151eef1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0523c28f-3747-4730-9cce-c08cb591d174"), new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("42d4225c-00e0-4e69-86ff-d233d02abe95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d3bf9404-5c09-499d-b067-c499f7c544b1"), new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("455131ea-f7aa-4b55-a968-14a8affb230d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af15b13a-67f7-4775-ac7a-4ae6c6d43dd1"), new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("45f13a23-4a01-46dd-b9c0-fbd634b8cc90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9f2fd672-f226-4cb3-9467-183e5a87016b"), new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") },
                    { new Guid("4a02a9dc-7e7c-40e7-ba12-e6b18e63c94d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7e41320b-7a6f-455a-9e8d-3451f5d0d908"), new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("4babb649-b71a-487b-aaf6-4161e26a51ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9ed9c345-88b6-4953-850f-b0cca9e69f78"), new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("4e84a19f-65e1-49eb-884d-75320b1df1f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ad5354d9-b271-4685-9faf-ac8ccd97b7a9"), new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("4f524ef7-e4b3-489a-af4b-73ff74c43ecf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bde5812c-d234-45f3-be2d-329ee8befb1f"), new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("54df32cc-1507-4eab-9a64-3f77f4a38c7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aefcbab9-66b5-4f00-81c6-fa67356f744a"), new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") },
                    { new Guid("59f6fa81-be4b-44a0-b1ab-fb3e8b8165f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d0e6e381-354d-4323-ad3a-c4f945792596"), new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("5fa0bcca-31b4-44fe-96f9-47a67c2ce7aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9de05efe-6995-4c77-b711-1a5c3496c63c"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("6004dfad-55d0-4ab4-809d-c23a2e4fdaab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4be6c3cf-049e-4617-95ea-61dc8061cb44"), new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("610f03dc-6dd4-4aaf-8b03-66528131338f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("066569c6-7b94-4971-bcc0-575e73552772"), new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("69233eb8-2554-4aa9-a0f0-acaf5d78a4b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9f2fd672-f226-4cb3-9467-183e5a87016b"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("6d29c030-354e-47d5-9741-ea3149e2eb98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("066569c6-7b94-4971-bcc0-575e73552772"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("7a1436ec-1bef-40a4-8228-b5d0c2c23006"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0e8f9bc5-c58f-4214-9b1f-c9951796c7f8"), new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("80d51610-0796-4943-a87e-1247af465c86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca08419d-4c9b-4f01-9a48-100f93fd2c09"), new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("81806614-5efe-4730-9584-3b4b9e35350f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0523c28f-3747-4730-9cce-c08cb591d174"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("82226451-969e-4ad7-83d6-1748f353b9fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9ed9c345-88b6-4953-850f-b0cca9e69f78"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("83056632-5f03-4da4-a4a1-9c1ee26ea389"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7dcaa3b1-63cc-4ac8-b02d-c01f393cf119"), new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("8692a5f6-893e-4e2f-95e3-bb919a2507a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7e41320b-7a6f-455a-9e8d-3451f5d0d908"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("8be86ba4-ac0a-4549-8928-8b65f4ef3901"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84131b65-2491-4dd1-94f6-d7714be97f15"), new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("8f31fa76-6b85-48e3-8092-ad849d11bf03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9ed9c345-88b6-4953-850f-b0cca9e69f78"), new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("93b22b9d-f4f3-4633-a4c6-29a79027a7be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84131b65-2491-4dd1-94f6-d7714be97f15"), new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("93c8e21c-409c-4776-b0a2-67d4116b32f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("82114fca-8a1c-4243-8bba-c43ccae5a6c3"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("9736e40e-0b4d-4172-b7bd-7691bec96013"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("653f061e-abe4-423c-b54e-2bbbc42a12a4"), new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("9819595e-fe99-441d-9206-8577b8d4aab8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aeff0e2a-59f3-4507-80e8-f00fab6ae5bd"), new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("98807887-ed74-4cf8-868b-d5e4f0c9f358"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("408b6e66-b58c-461c-aef4-05fa835243b2"), new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("abc3ea0f-96c1-43f3-a88e-17ba8b5cba7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a27aac90-e996-4a91-97a3-32d1372d37da"), new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") },
                    { new Guid("acbe252a-218c-4381-8780-7a1a0d56a037"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("01763114-3ab5-46eb-ab75-b44b869e0f78"), new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") },
                    { new Guid("b1b530c4-7651-4232-a2ba-bf02cbfb856e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("effd58fe-03de-4883-8b95-4a297aeffece"), new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("b3bfc0fa-2082-44e1-a846-0e1a4412760f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ed8484b-4374-4a8e-bc41-ba7c0da6ae14"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("b3fd0cf4-b3e4-4202-9f24-a947b34ff212"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("066569c6-7b94-4971-bcc0-575e73552772"), new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("b5607cba-2a75-4dbc-b895-2067abad2b43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9de05efe-6995-4c77-b711-1a5c3496c63c"), new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("b58819fd-6fa3-4684-9197-598236559def"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4be6c3cf-049e-4617-95ea-61dc8061cb44"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("b67a1162-d34d-41de-b182-8b351faa8b75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e5b3e9e2-4ad0-42c3-a8b1-47ac7e13c54f"), new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("ba7b25ff-1424-4000-a4b2-ff658ecdda18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("22b75005-6c01-4920-81c6-8d6d5271c6df"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("bba1b6b7-25e6-44bc-8663-0ee7872436cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9ed9c345-88b6-4953-850f-b0cca9e69f78"), new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("bd02c5a8-f390-402f-9c11-cf5a535cdf3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0fb78bae-1f19-4b47-bcec-be71de61beff"), new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("be74a88c-7ad0-488a-a817-ea99d73be982"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("22b75005-6c01-4920-81c6-8d6d5271c6df"), new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("bfb57b60-4e44-4e5d-9580-4e1e2655ec30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e5b3e9e2-4ad0-42c3-a8b1-47ac7e13c54f"), new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("c1555d40-01b7-4345-9779-b978dbfe76d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e646577d-fb6b-460b-8324-5c42c9908e17"), new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("ca982867-582d-42d1-888e-da04e88f5ccb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("113a3f64-4c88-4e11-a76b-67e849847091"), new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") },
                    { new Guid("d8a7edbb-8087-4fff-90fa-575d52b1ccb3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0523c28f-3747-4730-9cce-c08cb591d174"), new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("dbd9b7b3-7090-4be3-963a-1658b1d5afb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2cc495b9-a04b-4e29-b5f0-24b2cddb7ea3"), new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("e04c9a26-6027-4b98-9838-04e90f5633dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8b213e3b-6f5c-46a5-ab9d-b516299d85c0"), new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("e13af4f5-7d92-4cf2-9e37-65cffd487679"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7835629a-4178-40cd-839e-cf3f3aae3aba"), new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("e2f4bb41-12de-4f5b-bae8-6330ff3a9521"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("74bb0137-d5e4-416b-b593-bb7c895da854"), new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("eb6c36b5-cac2-4488-b2a1-fb813f4f8479"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f0da9670-e58f-4d4c-80f4-2eca3d4db1a6"), new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") },
                    { new Guid("f4b0e99a-bc0f-4237-8dcd-904fcde85786"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ed8484b-4374-4a8e-bc41-ba7c0da6ae14"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("fd7c4307-962b-4d7d-9c53-16f06996c74b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4be6c3cf-049e-4617-95ea-61dc8061cb44"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("fe1b23fc-c41b-4387-bab6-006b24ab1661"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bde5812c-d234-45f3-be2d-329ee8befb1f"), new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("03d7158e-26f6-4c92-bda7-b832c6578782"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("640a5800-8df5-4991-82a8-f106a9154600"), new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("03e549ea-d824-4ad0-b756-68cbb45119f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("83858947-f085-4633-bcf7-4d46841eb2c9"), new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("148467ed-6a20-4f79-9d44-f4e15d162aca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7418f911-99b0-4b54-a95f-e2fea94175cf"), new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("177e26e9-4818-4427-ba12-3e990f982b29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9c81a632-c71e-4da5-89b4-1d14ea900fdf"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("193e0f09-0b67-44e3-866d-abf76f0f3f7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c37f44f6-ef2e-4097-9659-6add0f81b6e0"), new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("1e29e8df-ca09-46d9-98b2-82a03963c39e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e82e1a78-ee2f-43c7-8762-e93690bd0662"), new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("1f88c5c3-55a2-4ee6-b342-261df1ec6423"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("10194074-f890-4fde-a03d-02aacdd84f02"), new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("26fde4f9-b129-4258-90b4-d9ea307f9941"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5e9f65a3-ef79-45eb-834d-b39084ad5100"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("271178e3-8512-4188-b5eb-e3a1ef680802"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f5279f96-d0de-4b1f-a9f2-61646686a3bc"), new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2b0dde1f-4f77-46b6-b56b-8d6bfba08502"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e6965328-c211-45c7-8158-af87623388ef"), new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") },
                    { new Guid("306f4af1-5db6-43b8-8dbf-28efe457e298"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6c452d84-5f55-4b9c-8d68-9664b453b72e"), new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("3c8add40-d4ba-4ff2-b9b6-d34fa91e6bad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9c81a632-c71e-4da5-89b4-1d14ea900fdf"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("41810bc8-7370-437f-a96f-8ce65124aa34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("edeefb43-bb72-4070-81db-f5212807a127"), new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") },
                    { new Guid("4de22719-8e7e-4fa7-8934-1bf9d5f638d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b383ff3c-ed78-4b5a-a92d-0c75265c67f6"), new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("52ad719f-a34f-4f88-ba85-a57d5696b3c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("37321f4e-e893-4ba4-a9b0-facf84c52ae3"), new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("53c4ba0d-b712-4c95-a28f-314d7fe95332"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b383ff3c-ed78-4b5a-a92d-0c75265c67f6"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("5672f744-e71b-4298-840c-6d1310d6fc9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("465765d7-a93f-4d15-b27b-9ff6ea17f400"), new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("59356251-6172-4755-ba63-0279c08ed3d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bc8eadc5-9c24-483e-9c43-c897284da788"), new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("5a8f4126-c203-4db5-ae4d-d865e8e18272"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("959f7d32-bd1d-4838-b147-a2034a20b93a"), new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("6113cd65-3e60-4ba2-ae84-81670d12100f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("51191354-cc5d-41b8-9d86-313ea2e4b09f"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("62505edf-8edd-4663-ad60-3e5f0ad61db9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84ba62f3-3d99-4b63-89ef-42d40958aead"), new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("684d7f73-5b9a-41f6-a871-d9ff8d23091f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b21e5d6a-a982-46cc-ad6c-6b0493aa4e02"), new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("7c9b7c0d-e010-4dec-8a5c-883e76df7c1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a27568e4-d728-4a62-8050-97429f2b5cbb"), new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("7d812e65-f0e5-4a44-8b6f-329ad92ee385"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b21e5d6a-a982-46cc-ad6c-6b0493aa4e02"), new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("850c43c9-7750-4489-b70c-7cff334ac988"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9c81a632-c71e-4da5-89b4-1d14ea900fdf"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("8a5573a2-1e08-496d-92d2-e2129e21625a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eb1eea26-eeaf-494d-9391-22fa196afcc9"), new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("8db077f9-7c57-423d-abc8-82f47b6ad080"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("593b5a25-a244-40b0-9160-c451733aa668"), new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("900ed927-0d76-4a2c-8edf-eee200037759"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7e6bb587-2cbc-49a9-b6b6-ef3a016e8d02"), new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("904fb2c1-d54a-49f5-849b-541ec521746b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("144a41fc-835b-4830-b4f1-0c50e94e99a3"), new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("914b87cb-5ae6-4b8e-8e6f-b4dc23866560"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("593b5a25-a244-40b0-9160-c451733aa668"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("91f61c67-475b-45e8-b981-534de041a706"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4ff58d23-8c6a-43ab-9314-ce92ab3b2969"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("a21f0850-887a-4b5c-b3ae-1c18ea8e52e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9c4b38e4-3432-4dbc-b9da-b47e5a4e9d48"), new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("a3368c54-cf20-4aef-b8a8-aae4e352f3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ed1da477-8270-473d-81bc-3df61deab0da"), new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("abc70c91-1b1d-461e-adc7-2020f1bad8ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e78df454-0b54-4c4b-8f97-63c7f2ed14cb"), new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") },
                    { new Guid("b8917a2f-9c90-4e75-b441-e28cce338cd4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3e8df192-f1c9-4785-a150-01f761e2d0b1"), new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("b8c4e0a4-a3c3-4f11-a0c7-0a955aabf009"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f9979226-a0e7-4694-ac8e-b8bc227c3524"), new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("bc18c594-f306-4f8b-8675-29024449f647"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dc87fe7-2fa7-489a-8162-ddaa041ef42e"), new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("bc87be7d-c807-4d62-9ce7-3d6337997acc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4ff58d23-8c6a-43ab-9314-ce92ab3b2969"), new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("bfc1a0d4-2869-4852-99d8-dd138027bbed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2770f473-a6ea-4fc5-aa75-477d133e5d06"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("c05d1a9d-fd59-4f78-bbcc-3feb703d6319"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("37321f4e-e893-4ba4-a9b0-facf84c52ae3"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("c4bb2251-3ead-49fc-9157-8f07c0c8bb52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4de06bdc-e5a3-4bc3-a453-84eb31e14a58"), new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("c840eebe-cad0-4221-b073-33754ea2ac34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("593b5a25-a244-40b0-9160-c451733aa668"), new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("ccaa101b-cfcd-4411-8301-541f18f9ae3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6c452d84-5f55-4b9c-8d68-9664b453b72e"), new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("cdac3e67-8227-44b9-ab64-5f375553f956"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("08ec83f8-d357-4a33-a419-3f8b472dff13"), new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("ce9012e8-4f68-4168-826d-e74b92ced376"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5e9f65a3-ef79-45eb-834d-b39084ad5100"), new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("cff6c39c-d485-448c-9a0d-66bd1e047436"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dc87fe7-2fa7-489a-8162-ddaa041ef42e"), new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") },
                    { new Guid("d6605389-b08d-442f-91e2-d6615f4f857c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3e8df192-f1c9-4785-a150-01f761e2d0b1"), new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("d701d575-8f5b-4c25-a713-866523db4e7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("144a41fc-835b-4830-b4f1-0c50e94e99a3"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("db39afe6-305c-4c41-acfd-bedc33cda5b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a78a7549-4b6a-4f9d-b64e-cd0f40d79f90"), new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("db88e9e5-6210-4baf-a082-5aa8696fc1f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84ba62f3-3d99-4b63-89ef-42d40958aead"), new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("e143f4c9-dace-420c-8dbe-b4fc7b266e49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("db450733-3cf1-4a4e-b589-596784234579"), new Guid("e908834c-4383-4b44-a138-de5de4aa621a") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ea9c867f-41fd-4cd1-81dc-07544e8ab44e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("165f3161-b1ba-429c-9dbb-1c8134bc2b8c"), new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("eb611c06-92ba-4f4a-81b4-6ae4fe798a14"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("144a41fc-835b-4830-b4f1-0c50e94e99a3"), new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("ef45b902-8942-48c9-af6c-3b1a9adaa38e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c37f44f6-ef2e-4097-9659-6add0f81b6e0"), new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("f098fdb8-3add-43e2-9a6a-532c57093ff2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c1d95b76-eb85-4f7d-ae42-d0b7632b16df"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("f4eb16fc-8054-4ef3-b841-b493ee9821d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("964fdc3b-de32-47df-ba81-5c7522b815ba"), new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") },
                    { new Guid("f6463546-a085-4ec0-9bfa-08f6df4a957f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("20a43250-23b4-44bb-b397-22dbf9a5bfb7"), new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("f9a37f52-165b-478b-bacf-79b0740ab485"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c60fbe19-a03c-46d5-b551-74b798d63412"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("f9c3642a-c809-4f28-9a9e-39ba685dd041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a0bee8f0-3965-4a23-8f0d-f1cc0bd26eac"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("f9eaeca8-791a-4304-8a9d-559c28bb7ce4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3603dafb-96d9-448b-948e-f358214c6b16"), new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("023a3203-658a-4046-bc01-f5e08b4a74f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("93bc1c99-09e1-4c54-baa7-38ef4724949a"), new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("06512ef8-542b-4bc8-9d0b-8824c1cf7d65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4cb827eb-fe03-4050-982a-643b6c00198e"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("0b2d77d2-f9fe-4309-92fa-7e5beb4b3298"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("629ead4b-d7d3-4f52-b4f3-e67a18707e9b"), new Guid("cfbb728a-e4fb-476a-aca2-4f7a13647fee") },
                    { new Guid("0ba68f6b-816d-4b0a-a614-ce44de7e5c27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("532174b5-becb-475b-9237-65b8169ad1f7"), new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("0f274b1b-1a5d-4d66-a023-094e75b039c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c3b42eff-f368-4682-8b91-784c4255b3a5"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("127bc921-561e-49ff-bd2c-0b3e6fef1e09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("320f7c05-4ada-445f-8812-1e2a97790b27"), new Guid("3c796385-d267-4fbc-a8c1-b46899e21f61") },
                    { new Guid("15f2676a-6148-4c52-9dab-faffe54ca48c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4cb827eb-fe03-4050-982a-643b6c00198e"), new Guid("81bd8d9a-d3bb-4151-8eb6-f38b2693ffb1") },
                    { new Guid("1c5fbaa9-ac35-4ba6-8b50-2b0039a1b207"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("93619aeb-6454-4ba4-860b-ad2258d54ab0"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("20958811-40fc-4209-8a1e-e9f65e193049"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9509e619-5e3d-4ac1-a079-b6647dcc4d32"), new Guid("cf3dae75-446f-425a-82c6-ba435ec4d867") },
                    { new Guid("263575a6-3ed5-44e8-8bd1-df102b49f96d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f85ff746-2054-4610-afc3-a8de4f6af2b8"), new Guid("bfff036b-bfa2-4c91-8a45-f17d7c62e141") },
                    { new Guid("29fb6eb3-5831-4578-9adb-69e15e5a11bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("372da68b-d641-4a85-b7db-190fc55ff90f"), new Guid("fee352c9-ba8f-46c8-be66-27223ab1e807") },
                    { new Guid("2f0b7cdb-3a14-4e71-96ec-10dfb995be5b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("83e0c99b-98cb-438b-be5c-6d88b7b6948c"), new Guid("da24e237-3bde-45b1-9e53-947c0a1cfcf3") },
                    { new Guid("36f1bda8-1e01-4d6a-b38e-030d62689e92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("56c0e99b-68cd-4bc4-9590-ab81e381f1fb"), new Guid("32bef272-e10f-46db-a3fe-d9cd9a00c565") },
                    { new Guid("3b6280a7-fa86-4225-9a88-ea32701d96df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0e99f711-ce8c-4360-8b08-493893d7db16"), new Guid("eba8e86b-b2bb-4874-aa23-cac54b51b000") },
                    { new Guid("3ccca427-2f6d-4c71-b18d-f559211acd9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("425b3471-afd5-4a18-81f2-ebd4a499551b"), new Guid("c44253bf-72eb-457e-a8c5-9ef50175e7e2") },
                    { new Guid("3e88f762-2a55-44ea-8c74-e5e8aeac095f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6481c2ef-7fab-4a3f-b1cd-20b9fbf951a6"), new Guid("c31223ae-ad6a-44e1-af80-c5879c0c9de5") },
                    { new Guid("3efaec1e-d06c-48b5-89f8-94a7baaccacb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f85ff746-2054-4610-afc3-a8de4f6af2b8"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("41ed88b4-076e-45fe-90dd-0759024b5350"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4d4f79d5-168b-45fa-aebe-4b884f482eb1"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("447d81ac-846d-4513-99ee-7ed0b4fb0e0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8c6655a0-d6a0-42ba-84f3-2fdc8697b279"), new Guid("d39f4500-72e3-4ae3-bce6-8b936a2748d9") },
                    { new Guid("4cce156b-9109-4ef6-98a1-da4bd9993fbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("699924af-ddb6-4b57-a4dd-48ac429e350d"), new Guid("2f97d57a-272b-4ee2-811a-aefa2e3cf2e9") },
                    { new Guid("4d4be862-f4f8-4dc8-8e85-c6de79300047"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d952601e-22d3-49a4-b5cd-85665bef2b1c"), new Guid("75003614-4b57-4b31-82ae-8b88ae9945fe") },
                    { new Guid("5585de4e-9dd8-438d-b173-c5d1007a3da0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("699924af-ddb6-4b57-a4dd-48ac429e350d"), new Guid("cf715f5b-d690-415d-b228-62054ae77a1f") },
                    { new Guid("578bd95d-7b46-4733-92db-ed4bccf6dcf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("40ee8e98-eaf0-4654-b8c1-57a562a97257"), new Guid("0665c7e1-0533-4e3d-a67c-6801a08f719c") },
                    { new Guid("5c4a26c8-bdf6-46e2-827f-056147437310"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4d4f79d5-168b-45fa-aebe-4b884f482eb1"), new Guid("435ea3cd-937f-45c5-ab9c-95cb1d171838") },
                    { new Guid("5fd487b8-a6fd-43b1-b251-1b68d62039c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c45412ba-eb2a-447c-9845-a0c72dd49aca"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("6416ccdd-bd5a-4d72-87bc-5667609347b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d5695a47-56c0-4ad1-94f2-9b14d9a6b9b9"), new Guid("bb76498f-37b6-48d3-b979-97246498ed03") },
                    { new Guid("6ea377d9-4e7b-48cf-abe5-6954696b2642"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("56c0e99b-68cd-4bc4-9590-ab81e381f1fb"), new Guid("b5cba7f7-e7ba-4f19-ba7f-fcf4d4f426ce") },
                    { new Guid("70274e84-0355-426e-a3ac-662d6e512eb8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("629ead4b-d7d3-4f52-b4f3-e67a18707e9b"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("7479548e-21a4-4794-95ea-63a136ef8934"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("773199f4-63f5-4acd-8ca7-51022963fbe9"), new Guid("314f3ebf-5291-4f25-8051-89c8c0a53020") },
                    { new Guid("773368b0-2534-44ba-8411-b28f3403dea1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("93619aeb-6454-4ba4-860b-ad2258d54ab0"), new Guid("fca3cb7d-c11d-445d-8752-00136c100d96") },
                    { new Guid("81b40ad2-8d2e-4210-aba3-5006d03acfe0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("93bc1c99-09e1-4c54-baa7-38ef4724949a"), new Guid("e14c3e5e-b0ce-470a-aedb-cf088a4921c2") },
                    { new Guid("85eaf640-15f5-4115-b623-4310cfe8aafb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a21dbffc-3d27-4853-9025-d785bb3e7d08"), new Guid("58a68d56-e166-49e9-ab53-b148a241cc49") },
                    { new Guid("8dbe97f8-3f40-4c6e-8b79-01348a4d218f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3539c564-5f0c-4f49-acef-1be28fdac2f2"), new Guid("4bcfc238-672d-4ff7-8c91-f487632606f5") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("914d4515-751d-49ad-8d8a-112d4fe2d0c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c45412ba-eb2a-447c-9845-a0c72dd49aca"), new Guid("77208a41-8666-48c8-9ab4-e2485ddf23f3") },
                    { new Guid("982fe400-963b-478e-a152-80be19e421b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("02bb6b03-9911-49a8-96aa-ac1300673286"), new Guid("e908834c-4383-4b44-a138-de5de4aa621a") },
                    { new Guid("99bf8877-01cc-4f7e-a58b-27f1c30f40df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8fd96d91-a5d9-4cbd-ba02-b977eeddf71b"), new Guid("2ad6b60e-9401-446c-969c-c93cd5fab3aa") },
                    { new Guid("9a2108e8-ad8c-4d0b-862c-063c69baaa09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2d7af7ea-9a4f-4949-97ee-a4dc345f39a9"), new Guid("dd72a8b8-b582-4610-8c54-3d237afecd97") },
                    { new Guid("9fdf0a28-85b7-4f36-871c-cb1c5cd24d1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f85ff746-2054-4610-afc3-a8de4f6af2b8"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("a14d37ad-9aa5-4421-a626-573396a5d517"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aeac9ac8-78a9-4708-965f-45610994ec70"), new Guid("56acd153-5467-4111-9ca4-96f34533a050") },
                    { new Guid("a28b634a-35c8-40a4-a48d-e6d0390ec99b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9345e76c-b0c5-4176-8c7d-64211635556a"), new Guid("8c96ee4b-4ca6-4439-91d0-adf496952a43") },
                    { new Guid("b257f28e-2340-4a77-95a3-02de1ef702c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2af6d204-e30f-46cf-a049-94a47f644faa"), new Guid("4a07cf95-91cb-4bf6-bee7-c7b0ebbeb128") },
                    { new Guid("b2cda205-759f-449e-ba1d-baff11c5a956"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3ac98e30-f833-4da3-924d-562e30b73c61"), new Guid("e589a67e-b294-44d9-b13f-238167e4f0b8") },
                    { new Guid("b59723a2-3579-4ea3-9670-25bcd8f923c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a8dacb32-0665-4dc2-8c18-1ca4b28c6bcc"), new Guid("19dfb17a-8d5a-4c8e-84ac-6743b0678f04") },
                    { new Guid("c215bac3-dcde-49a8-87e7-ecde3b0b220a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fcf404f8-cba5-4314-8f2c-859836b983c7"), new Guid("c2408441-b0b1-41a2-95b0-c7c1c41ea399") },
                    { new Guid("c938c41a-32a6-480e-86ba-90e75186cf3f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f880b11-e1fd-437f-8e0f-0d8630f07210"), new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("c9c14b3c-85f3-4d7c-bdf3-9d7b11daffbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8fd96d91-a5d9-4cbd-ba02-b977eeddf71b"), new Guid("375067e3-f507-44ac-9a33-e9cfdd15a0da") },
                    { new Guid("d2284a30-7c0d-4fda-96dd-7d0b9177be98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("320f7c05-4ada-445f-8812-1e2a97790b27"), new Guid("1f6f158a-5dc6-4f4e-bfcd-63715e28e432") },
                    { new Guid("d6cab5ae-de5c-4f69-9609-af973e2f3a40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c3b42eff-f368-4682-8b91-784c4255b3a5"), new Guid("504f690e-3a1c-49ed-94a4-1238f972b696") },
                    { new Guid("d8097daa-7666-4f88-9ad3-2d1f6c5590ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7442a689-910f-4031-8238-c26f7f8c53c8"), new Guid("f04124ae-11f5-4d5f-92c6-1928140b0357") },
                    { new Guid("da0866fb-f669-478f-bb47-0760edf2c20f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c45412ba-eb2a-447c-9845-a0c72dd49aca"), new Guid("59917ef6-495b-463e-9d58-75b21f8544bc") },
                    { new Guid("ddb378a8-4d08-4515-8994-55e54896a4bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4c405340-5d7c-426b-9611-b1afaed48c48"), new Guid("91536fee-0a2b-4532-82d5-adbdd5e6e827") },
                    { new Guid("ded28022-f5ae-4739-85be-baa6177387d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9d27cd85-906f-40d6-93a0-9f1f83409a48"), new Guid("fe394c33-39cb-4280-b774-a82eab155fa5") },
                    { new Guid("e33ff0ae-c243-4090-a39d-2500175be135"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("40ee8e98-eaf0-4654-b8c1-57a562a97257"), new Guid("f06e4de8-bda0-47a2-811b-385e6e623687") },
                    { new Guid("e3b904b8-6b81-4cbe-ad0f-c6e6f6a773c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9345e76c-b0c5-4176-8c7d-64211635556a"), new Guid("a6c345ab-57ed-45ca-b626-c41a182b9607") },
                    { new Guid("eaabc58f-1403-41b0-bb0f-521f8b35829e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("372da68b-d641-4a85-b7db-190fc55ff90f"), new Guid("97de82e9-c733-47c2-b418-b507bf8cc1f6") },
                    { new Guid("ee65e21f-51e4-44a4-9f7a-f92b319b2340"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f3450211-118c-490f-8f51-6792c19c6b07"), new Guid("4cfa9a9a-6420-4266-8a99-76613756a53e") },
                    { new Guid("ee942bd3-0549-4019-a0c6-77287c4a7782"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a8dacb32-0665-4dc2-8c18-1ca4b28c6bcc"), new Guid("07e4b380-1cc9-4e8e-98d4-c422453a6940") },
                    { new Guid("f1500b0a-f7b5-404c-a95c-6ae21f9e47bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("61f5aee2-3ba3-43f1-921c-1cac249b199a"), new Guid("4be486d8-ad00-4a59-a8dc-5c97264bc835") },
                    { new Guid("f605f1a1-3392-41bb-bb7d-3a0b35d69104"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("773199f4-63f5-4acd-8ca7-51022963fbe9"), new Guid("9202ce4d-7121-4324-8f36-f303a63531ef") },
                    { new Guid("f8423ada-9240-43cb-8cf1-f294f73349b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0f90dc8d-6142-4609-8ee4-98e5380886c6"), new Guid("5db09bf3-8454-4fff-bfe9-003854416f82") }
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
